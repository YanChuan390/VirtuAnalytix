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
		[Address(RVA = "0x965074", Offset = "0x965074", VA = "0x965074")]
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
	[Address(RVA = "0x96506C", Offset = "0x96506C", VA = "0x96506C")]
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
	[Address(RVA = "0x96507C", Offset = "0x96507C", VA = "0x96507C")]
	public void Update()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x9651B8", Offset = "0x9651B8", VA = "0x9651B8")]
	public void Start()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x96522C", Offset = "0x96522C", VA = "0x96522C")]
	public void hand()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x9652A0", Offset = "0x9652A0", VA = "0x9652A0")]
	public void back()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x965314", Offset = "0x965314", VA = "0x965314")]
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
			[Address(RVA = "0x9657FC", Offset = "0x9657FC", VA = "0x9657FC", Slot = "4")]
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
			[Address(RVA = "0x965844", Offset = "0x965844", VA = "0x965844", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x965578", Offset = "0x965578", VA = "0x965578")]
		[DebuggerHidden]
		public <Import>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x9655A8", Offset = "0x9655A8", VA = "0x9655A8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x9655AC", Offset = "0x9655AC", VA = "0x9655AC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x965804", Offset = "0x965804", VA = "0x965804", Slot = "8")]
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
	[Address(RVA = "0x96531C", Offset = "0x96531C", VA = "0x96531C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x965454", Offset = "0x965454", VA = "0x965454")]
	private void OnFileSelected(string path)
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x9654E8", Offset = "0x9654E8", VA = "0x9654E8")]
	private IEnumerator Import(string path)
	{
		return null;
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x9655A0", Offset = "0x9655A0", VA = "0x9655A0")]
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
		[Address(RVA = "0x9659AC", Offset = "0x9659AC", VA = "0x9659AC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x9659B4", Offset = "0x9659B4", VA = "0x9659B4")]
		private set
		{
		}
	}

	[Token(Token = "0x17000004")]
	public virtual AudioClip audioClip
	{
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x9659BC", Offset = "0x9659BC", VA = "0x9659BC", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x9659C4", Offset = "0x9659C4", VA = "0x9659C4", Slot = "5")]
		protected set
		{
		}
	}

	[Token(Token = "0x17000005")]
	public virtual float progress
	{
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x9659CC", Offset = "0x9659CC", VA = "0x9659CC", Slot = "6")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x9659D4", Offset = "0x9659D4", VA = "0x9659D4", Slot = "7")]
		protected set
		{
		}
	}

	[Token(Token = "0x17000006")]
	public virtual bool isDone
	{
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x9659DC", Offset = "0x9659DC", VA = "0x9659DC", Slot = "8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x9659E4", Offset = "0x9659E4", VA = "0x9659E4", Slot = "9")]
		protected set
		{
		}
	}

	[Token(Token = "0x17000007")]
	public virtual bool isInitialized
	{
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x9659F0", Offset = "0x9659F0", VA = "0x9659F0", Slot = "10")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x9659F8", Offset = "0x9659F8", VA = "0x9659F8", Slot = "11")]
		protected set
		{
		}
	}

	[Token(Token = "0x17000008")]
	public virtual bool isError
	{
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x965A04", Offset = "0x965A04", VA = "0x965A04", Slot = "12")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x965A0C", Offset = "0x965A0C", VA = "0x965A0C", Slot = "13")]
		protected set
		{
		}
	}

	[Token(Token = "0x17000009")]
	public virtual string error
	{
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x965A18", Offset = "0x965A18", VA = "0x965A18", Slot = "14")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x965A20", Offset = "0x965A20", VA = "0x965A20", Slot = "15")]
		protected set
		{
		}
	}

	[Token(Token = "0x14000001")]
	public event Action<AudioClip> Loaded
	{
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x96584C", Offset = "0x96584C", VA = "0x96584C")]
		add
		{
		}
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x9658FC", Offset = "0x9658FC", VA = "0x9658FC")]
		remove
		{
		}
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x965710", Offset = "0x965710", VA = "0x965710")]
	public void Import(string uri)
	{
	}

	[Token(Token = "0x6000023")]
	public abstract void Abort();

	[Token(Token = "0x6000024")]
	protected abstract void Import();

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x965A28", Offset = "0x965A28", VA = "0x965A28")]
	protected void OnLoaded()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x965A64", Offset = "0x965A64", VA = "0x965A64")]
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
			[Address(RVA = "0x966CC0", Offset = "0x966CC0", VA = "0x966CC0", Slot = "4")]
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
			[Address(RVA = "0x966D08", Offset = "0x966D08", VA = "0x966D08", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x966464", Offset = "0x966464", VA = "0x966464")]
		[DebuggerHidden]
		public <refreshFiles>d__21(int <>1__state)
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x966C04", Offset = "0x966C04", VA = "0x966C04", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x966C08", Offset = "0x966C08", VA = "0x966C08", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x966CC8", Offset = "0x966CC8", VA = "0x966CC8", Slot = "8")]
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
			[Address(RVA = "0x966DCC", Offset = "0x966DCC", VA = "0x966DCC", Slot = "4")]
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
			[Address(RVA = "0x966E14", Offset = "0x966E14", VA = "0x966E14", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x96648C", Offset = "0x96648C", VA = "0x96648C")]
		[DebuggerHidden]
		public <refreshDirectories>d__22(int <>1__state)
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x966D10", Offset = "0x966D10", VA = "0x966D10", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x966D14", Offset = "0x966D14", VA = "0x966D14", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x966DD4", Offset = "0x966DD4", VA = "0x966DD4", Slot = "8")]
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
		[Address(RVA = "0x9666E8", Offset = "0x9666E8", VA = "0x9666E8")]
		public <>c__DisplayClass23_0()
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x966E1C", Offset = "0x966E1C", VA = "0x966E1C")]
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
		[Address(RVA = "0x96693C", Offset = "0x96693C", VA = "0x96693C")]
		public <>c__DisplayClass24_0()
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x966E3C", Offset = "0x966E3C", VA = "0x966E3C")]
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
		[Address(RVA = "0x9653A4", Offset = "0x9653A4", VA = "0x9653A4")]
		add
		{
		}
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x965A6C", Offset = "0x965A6C", VA = "0x965A6C")]
		remove
		{
		}
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x965B1C", Offset = "0x965B1C", VA = "0x965B1C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x966008", Offset = "0x966008", VA = "0x966008")]
	public void Up()
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x965C64", Offset = "0x965C64", VA = "0x965C64")]
	private void BuildContent()
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x9660D0", Offset = "0x9660D0", VA = "0x9660D0")]
	private void ClearContent()
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x966314", Offset = "0x966314", VA = "0x966314")]
	private void OnFileSelected(int index)
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x9663AC", Offset = "0x9663AC", VA = "0x9663AC")]
	private void OnDirectorySelected(int index)
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x9662A0", Offset = "0x9662A0", VA = "0x9662A0")]
	private IEnumerator refreshFiles()
	{
		return null;
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x96622C", Offset = "0x96622C", VA = "0x96622C")]
	private IEnumerator refreshDirectories()
	{
		return null;
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x9664B4", Offset = "0x9664B4", VA = "0x9664B4")]
	private void AddFileItem(int index)
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x9666F0", Offset = "0x9666F0", VA = "0x9666F0")]
	private void AddDirectoryItem(int index)
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x966944", Offset = "0x966944", VA = "0x966944")]
	private void Update()
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x966BFC", Offset = "0x966BFC", VA = "0x966BFC")]
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
			[Address(RVA = "0x967950", Offset = "0x967950", VA = "0x967950")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000054")]
			[Address(RVA = "0x967958", Offset = "0x967958", VA = "0x967958")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public int sampleRate
		{
			[Token(Token = "0x6000055")]
			[Address(RVA = "0x967960", Offset = "0x967960", VA = "0x967960")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000056")]
			[Address(RVA = "0x967968", Offset = "0x967968", VA = "0x967968")]
			private set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public int channels
		{
			[Token(Token = "0x6000057")]
			[Address(RVA = "0x967970", Offset = "0x967970", VA = "0x967970")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000058")]
			[Address(RVA = "0x967978", Offset = "0x967978", VA = "0x967978")]
			private set
			{
			}
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x967980", Offset = "0x967980", VA = "0x967980")]
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
	[Address(RVA = "0x966E5C", Offset = "0x966E5C", VA = "0x966E5C", Slot = "16")]
	public override void Abort()
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x967010", Offset = "0x967010", VA = "0x967010", Slot = "17")]
	protected override void Import()
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x967198", Offset = "0x967198", VA = "0x967198")]
	private void DoImport()
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x9673C8", Offset = "0x9673C8", VA = "0x9673C8")]
	private void Decode()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x967528", Offset = "0x967528", VA = "0x967528")]
	private void CreateClip()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x9675E0", Offset = "0x9675E0", VA = "0x9675E0")]
	private void SetData()
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x967710", Offset = "0x967710", VA = "0x967710")]
	protected void OnError(string error)
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x9672B4", Offset = "0x9672B4", VA = "0x9672B4")]
	private void Dispatch(Action action)
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x967758", Offset = "0x967758", VA = "0x967758")]
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
	[Address(RVA = "0x96788C", Offset = "0x96788C", VA = "0x96788C")]
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
			[Address(RVA = "0x967D00", Offset = "0x967D00", VA = "0x967D00", Slot = "4")]
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
			[Address(RVA = "0x967D48", Offset = "0x967D48", VA = "0x967D48", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x967BF0", Offset = "0x967BF0", VA = "0x967BF0")]
		[DebuggerHidden]
		public <WaitForWebRequest>d__14(int <>1__state)
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x967C20", Offset = "0x967C20", VA = "0x967C20", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x967C24", Offset = "0x967C24", VA = "0x967C24", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x967D08", Offset = "0x967D08", VA = "0x967D08", Slot = "8")]
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
		[Address(RVA = "0x9679BC", Offset = "0x9679BC", VA = "0x9679BC", Slot = "6")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000012")]
	public override bool isDone
	{
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x9679D4", Offset = "0x9679D4", VA = "0x9679D4", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000013")]
	public override bool isInitialized
	{
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x9679E8", Offset = "0x9679E8", VA = "0x9679E8", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000014")]
	public override bool isError
	{
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x9679F4", Offset = "0x9679F4", VA = "0x9679F4", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000015")]
	public override string error
	{
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x967A34", Offset = "0x967A34", VA = "0x967A34", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x967A98", Offset = "0x967A98", VA = "0x967A98", Slot = "16")]
	public override void Abort()
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x967AFC", Offset = "0x967AFC", VA = "0x967AFC", Slot = "17")]
	protected override void Import()
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x967B7C", Offset = "0x967B7C", VA = "0x967B7C")]
	private IEnumerator WaitForWebRequest()
	{
		return null;
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x967C18", Offset = "0x967C18", VA = "0x967C18")]
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
	[Address(RVA = "0x967D50", Offset = "0x967D50", VA = "0x967D50", Slot = "18")]
	protected override void Initialize()
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x967F50", Offset = "0x967F50", VA = "0x967F50", Slot = "19")]
	protected override void Cleanup()
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x967F98", Offset = "0x967F98", VA = "0x967F98", Slot = "21")]
	protected override AudioInfo GetInfo()
	{
		return null;
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x968064", Offset = "0x968064", VA = "0x968064", Slot = "20")]
	protected override int GetSamples(float[] buffer, int offset, int count)
	{
		return default(int);
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x968124", Offset = "0x968124", VA = "0x968124")]
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
		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool IsAchieved;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Button3D Icon;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int Counter;

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x96BDCC", Offset = "0x96BDCC", VA = "0x96BDCC")]
		public Achievement(string name)
		{
		}
	}

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static AchievementsManager instance;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool officialTrack;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Text achiveName;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Text achiveDesc;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<string> collectedAchives;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static Achievement GreenEnergy;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static Achievement Untouchable;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static Achievement OneArmedBandit;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static Achievement WithoutAMiss;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static Achievement Score5000;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static Achievement Score10000;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public static Achievement Speed20;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public static Achievement Speed25;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public static Achievement L5R5;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public static Achievement Hit5In1;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public static Achievement Headache;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public static Achievement HiMed;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public static Achievement FirstBlood;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public static Achievement MP3;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public static Achievement Customer;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public static Achievement Longplay;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public static Achievement Combo;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public static Achievement TenMilions;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public static Achievement Minutes88;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public static Achievement LeMans;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public static List<Achievement> AllAchievements;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool lastHandL5R5;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private int noChangesL5R5;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float[] hitTimes;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int noHeadache;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Game game;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private CommonVR vr;

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x968128", Offset = "0x968128", VA = "0x968128")]
	private void CheckGreenEnergy()
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x968358", Offset = "0x968358", VA = "0x968358")]
	private void Update()
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x96835C", Offset = "0x96835C", VA = "0x96835C")]
	private void CheckUntouchable()
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x96842C", Offset = "0x96842C", VA = "0x96842C")]
	private void CheckHiMed(string track_vid)
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x968570", Offset = "0x968570", VA = "0x968570")]
	private void CheckOneArmedBandit(string track_vid)
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x9686B4", Offset = "0x9686B4", VA = "0x9686B4")]
	private void CheckWithoutAMiss(string track_vid)
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x9687F8", Offset = "0x9687F8", VA = "0x9687F8")]
	private void CheckFirstBlood()
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x96889C", Offset = "0x96889C", VA = "0x96889C")]
	private void CheckMP3()
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x96896C", Offset = "0x96896C", VA = "0x96896C")]
	private void CheckCustomer()
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x968A40", Offset = "0x968A40", VA = "0x968A40")]
	public void OnGameFinish()
	{
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x968CC0", Offset = "0x968CC0", VA = "0x968CC0")]
	public void OnPlaylistFinish()
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x968D64", Offset = "0x968D64", VA = "0x968D64")]
	public void OnFullCombo()
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x968E08", Offset = "0x968E08", VA = "0x968E08")]
	private void CheckScore5000(int score)
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x968ED0", Offset = "0x968ED0", VA = "0x968ED0")]
	private void CheckScore10000(int score)
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x968F98", Offset = "0x968F98", VA = "0x968F98")]
	private void CheckSpeed20(float speed)
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x969058", Offset = "0x969058", VA = "0x969058")]
	private void CheckSpeed25(float speed)
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x969118", Offset = "0x969118", VA = "0x969118")]
	private void CheckL5R5(bool right_hand)
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x969208", Offset = "0x969208", VA = "0x969208")]
	private void CheckHit5In1()
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x969334", Offset = "0x969334", VA = "0x969334")]
	private void CheckHeadache(Game.HitTarget target)
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x96940C", Offset = "0x96940C", VA = "0x96940C")]
	public void OnHit(float speed, Game.HitTarget target, bool right_hand, int score)
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x969498", Offset = "0x969498", VA = "0x969498")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x969500", Offset = "0x969500", VA = "0x969500")]
	private void Start()
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x968224", Offset = "0x968224", VA = "0x968224")]
	private void OnAchievement(string achievement_name)
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x968C4C", Offset = "0x968C4C", VA = "0x968C4C")]
	private void AchievementCounter(string achievement_name, int count)
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x9696C4", Offset = "0x9696C4", VA = "0x9696C4")]
	public void CheckForAchievements()
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x969B6C", Offset = "0x969B6C", VA = "0x969B6C")]
	private void RefreshIcons()
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x96A024", Offset = "0x96A024", VA = "0x96A024")]
	public List<Vector3> GeneratePoints(int N, float MAX_X, float MAX_Y)
	{
		return null;
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x969958", Offset = "0x969958", VA = "0x969958")]
	private void CollectAchievementsToCheck(ref List<string> to_get)
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x96A714", Offset = "0x96A714", VA = "0x96A714")]
	private void SetupAchievementByName(string name, int count, bool unlocked)
	{
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x96A888", Offset = "0x96A888", VA = "0x96A888")]
	public void OnSelectIcon(int idx)
	{
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x96AC14", Offset = "0x96AC14", VA = "0x96AC14")]
	public void GenerateIconsOnSummary(StatsSummary summary)
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x96AF54", Offset = "0x96AF54", VA = "0x96AF54")]
	public AchievementsManager()
	{
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x96BE18", Offset = "0x96BE18", VA = "0x96BE18")]
	private void <CheckForAchievements>b__57_0(Oculus.Platform.Message<Oculus.Platform.Models.AchievementProgressList> msg)
	{
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x96C0C0", Offset = "0x96C0C0", VA = "0x96C0C0")]
	private void <CheckForAchievements>b__57_1(Pico.Platform.Message<Pico.Platform.Models.AchievementProgressList> msg)
	{
	}
}
[Token(Token = "0x2000015")]
public class Activator : MonoBehaviour
{
	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject[] objectsToActivate;

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject[] objectsToDeactivate;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Animator[] animators;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string[] anims;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public MonoBehaviour[] componentsToActivate;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public MonoBehaviour[] componentsToDeactivate;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public AudioClip sound;

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x96C224", Offset = "0x96C224", VA = "0x96C224")]
	private void Start()
	{
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x96C3C8", Offset = "0x96C3C8", VA = "0x96C3C8")]
	public void Activate()
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x96C3D4", Offset = "0x96C3D4", VA = "0x96C3D4")]
	public Activator()
	{
	}
}
[Token(Token = "0x2000016")]
public class AimOnCamera : MonoBehaviour
{
	[Token(Token = "0x6000095")]
	[Address(RVA = "0x96C3DC", Offset = "0x96C3DC", VA = "0x96C3DC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x96C468", Offset = "0x96C468", VA = "0x96C468")]
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
		[Token(Token = "0x4000081")]
		None,
		[Token(Token = "0x4000082")]
		Up,
		[Token(Token = "0x4000083")]
		Down
	}

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Mode mode;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TwoBoneIKConstraint ikArmsL;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TwoBoneIKConstraint ikArmsR;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform headTransform;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform spineTransform;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Vector3 ikPosHeadL;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private Vector3 ikPosHeadR;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Vector3 ikPosSpineL;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private Vector3 ikPosSpineR;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float weight;

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x96C470", Offset = "0x96C470", VA = "0x96C470")]
	private void Start()
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x96C628", Offset = "0x96C628", VA = "0x96C628")]
	private void Update()
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x96C968", Offset = "0x96C968", VA = "0x96C968")]
	public ArmsCorrection()
	{
	}
}
[Token(Token = "0x2000019")]
public class Avatar : MonoBehaviour
{
	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private CommonVR vr;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Game game;

	[Token(Token = "0x4000086")]
	private const float ARM_ACTIVATOR_PERIOD = 0.25f;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform headDetector;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform bodyDetector;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform handRDetector;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Transform handLDetector;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Transform guardDetector;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Transform armRDetector;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Transform armLDetector;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Transform upperarmRDetector;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Transform upperarmLDetector;

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Transform handRDetectorCopy;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Transform handLDetectorCopy;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Transform armRDetectorCopy;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Transform armLDetectorCopy;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public GameObject markerL;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public GameObject markerR;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public GameObject elbowVisL;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public GameObject elbowVisR;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Material hitMat;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public GameObject hitEffect;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public GameObject blockEffect;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private float hitEffectProgress;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	private float hitMatAlpha;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private float hitMatColor;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public Material guardMat;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private float guardMatColor;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	public float armActivatorL;

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public float armActivatorR;

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public GameObject centerMarker;

	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public Vector3 avgPlayerPos;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
	private Vector3 <playerCenter>k__BackingField;

	[Token(Token = "0x17000018")]
	public Vector3 playerCenter
	{
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x96E8B4", Offset = "0x96E8B4", VA = "0x96E8B4")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x96E8C4", Offset = "0x96E8C4", VA = "0x96E8C4")]
		set
		{
		}
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x96C970", Offset = "0x96C970", VA = "0x96C970")]
	private void Start()
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x96CA34", Offset = "0x96CA34", VA = "0x96CA34")]
	private void UpdateGuard()
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x96D2C0", Offset = "0x96D2C0", VA = "0x96D2C0")]
	private void UpdateCopies()
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x96D3F8", Offset = "0x96D3F8", VA = "0x96D3F8")]
	private void UpdateArm(ref Vector3 cam_pos, Vector3 body_left, Vector3 body_dir, Vector3 hand_pos, Vector3 hand_fwd, Vector3 hand_up, bool isLeft, Transform elbowVis)
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x96DEA8", Offset = "0x96DEA8", VA = "0x96DEA8")]
	private void UpdateArms()
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x96E584", Offset = "0x96E584", VA = "0x96E584")]
	private void UpdateDetectorTransforms()
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x96E8D4", Offset = "0x96E8D4", VA = "0x96E8D4")]
	private void UpdatePlayerCenter()
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x96EB94", Offset = "0x96EB94", VA = "0x96EB94")]
	private void Update()
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x96EBB4", Offset = "0x96EBB4", VA = "0x96EBB4")]
	private void UpdateHitEffect()
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x96ED70", Offset = "0x96ED70", VA = "0x96ED70")]
	public void OnHit(Detector detector, bool left, bool kick)
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x96EF6C", Offset = "0x96EF6C", VA = "0x96EF6C")]
	public void OnBlock(Collider other, Detector detector)
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x96F55C", Offset = "0x96F55C", VA = "0x96F55C")]
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
		[Token(Token = "0x4000103")]
		NoReaction,
		[Token(Token = "0x4000104")]
		TwoNoneOne,
		[Token(Token = "0x4000105")]
		TwoNoneTwo,
		[Token(Token = "0x4000106")]
		TwoNoneNone,
		[Token(Token = "0x4000107")]
		OneNoneNone,
		[Token(Token = "0x4000108")]
		OneNoneTwo,
		[Token(Token = "0x4000109")]
		OneNoneOne
	}

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OnHitBeh onHitBehaviour;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool noRotate;

	[Token(Token = "0x40000A7")]
	private const float HAND_ON_TIME = 0.3f;

	[Token(Token = "0x40000A8")]
	private const float SNAP_TO_BASE_PERIOD = 0.4f;

	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float hitEffectPower;

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Animator animator;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float[] atacksLen;

	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float[] atacksHitFrame;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float[] atacksRatio;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public int[] attackSeq;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public int[] berserkerkSeq;

	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public int[] complicatedSeq;

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Game game;

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GameObject mainMesh;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Vector3 animatorBasePos;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private Quaternion animatorBaseRot;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private bool duringAttackAnim;

	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8D")]
	private bool rightHandAttack;

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8E")]
	private bool leftHandAttack;

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8F")]
	private bool rightLegAttack;

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private bool leftLegAttack;

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private float duringMovementAnim;

	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private float lifeTime;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public SkinnedMeshRenderer[] bodyParts;

	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public int[] matIndexes;

	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public bool mirrored;

	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	private float movementLayerWeight;

	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private ArmsCorrection armsCorrection;

	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private float handOffLayerWeight;

	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	private float handOffTime;

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public float handOffPower;

	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	public bool handsOffDuringCombo;

	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public ComboMarker[] comboMarkers;

	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private AudioSource audioSource;

	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public Vector3 hudOffset;

	[Token(Token = "0x40000C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	public bool duringBerserker;

	[Token(Token = "0x40000C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private float comboLayerWeight;

	[Token(Token = "0x40000CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	public float comboLayerPower;

	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private float baseScale;

	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	public float baseDist;

	[Token(Token = "0x40000CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public float minDistToPlayer;

	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
	public float maxDistToPlayer;

	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public float offsetToPlayerDuringAttack;

	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
	private float animatedOffsetDuringAttack;

	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public float rotationCorrection;

	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
	public float ANIM_IDLE_SPEED;

	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public ComboMarker finisher;

	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public GameObject[] toHideDuringDissolve;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private Vector3 basePos;

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
	private float timeToNormalSpeed;

	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private float nextAttackTime;

	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
	private float nextAttackMaxLen;

	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private Game.EEventType nextAttackType;

	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
	private float attackTime;

	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private float attackMaxLen;

	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
	private Game.EEventType attackType;

	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private float handsOffWindow;

	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
	private int attackIDX;

	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	public bool canBlockDuringCombo;

	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
	private int headBonus;

	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private int upBodyBonus;

	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
	private int downBodyBonus;

	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	public Material[] mainMats;

	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	public Material[] appearMats;

	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	public Material[] finisherMats;

	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	public Material shadowMat;

	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private float beatHighlight;

	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	public Material[] beatHighMats;

	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private bool appearMatChanged;

	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
	private float dissolve;

	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	public Material hitMaterial;

	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private Vector3 lastHitPos;

	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
	private Color lastHitColor;

	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	private Transform lastHitTransform;

	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	private float lastHitProgress;

	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
	private float lastHitRadius;

	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	private Vector3 prevHitPos;

	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
	private Color prevHitColor;

	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F4")]
	private float prevHitProgress;

	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	private Transform prevHitTransform;

	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	private float prevHitRadius;

	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
	private float timeToPlayerDodge;

	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	public bool dead;

	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
	private float timeToDisperse;

	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
	private float timeToDelete;

	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x214")]
	private Game.HitTarget prevHitTarget;

	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
	private float snapToBasePosDuringIdleTime;

	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21C")]
	private float snapRotataionTempo;

	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
	private bool outOfRingDirLeft;

	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x224")]
	private float timeToChnageOutOfDir;

	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
	private float toCloseTime;

	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x22C")]
	public bool flyingBeh;

	[Token(Token = "0x4000101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
	private Vector3 bodyPenetrationInfluence;

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x96F5C0", Offset = "0x96F5C0", VA = "0x96F5C0")]
	public float GetBaseDist()
	{
		return default(float);
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x96F5D0", Offset = "0x96F5D0", VA = "0x96F5D0")]
	public float GetMinDistToPlayer()
	{
		return default(float);
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x96F5E0", Offset = "0x96F5E0", VA = "0x96F5E0")]
	public float GetMaxDistToPlayer()
	{
		return default(float);
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x96F5F0", Offset = "0x96F5F0", VA = "0x96F5F0")]
	private void Start()
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x96FE4C", Offset = "0x96FE4C", VA = "0x96FE4C")]
	private void UpdateHandsOff()
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x9700FC", Offset = "0x9700FC", VA = "0x9700FC")]
	private void UpdateCombo()
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x9702E8", Offset = "0x9702E8", VA = "0x9702E8")]
	private void UpdateDead()
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x97037C", Offset = "0x97037C", VA = "0x97037C")]
	private void UpdateOffsetDuringAttack()
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x9703B0", Offset = "0x9703B0", VA = "0x9703B0")]
	private void Update()
	{
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x970AD0", Offset = "0x970AD0", VA = "0x970AD0")]
	private void UpdateAnimTransition()
	{
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x972734", Offset = "0x972734", VA = "0x972734", Slot = "11")]
	public bool IsDuringAttack()
	{
		return default(bool);
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x97276C", Offset = "0x97276C", VA = "0x97276C", Slot = "12")]
	public bool IsLeftHandAttack()
	{
		return default(bool);
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x972784", Offset = "0x972784", VA = "0x972784", Slot = "13")]
	public bool IsRightHandAttack()
	{
		return default(bool);
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x97279C", Offset = "0x97279C", VA = "0x97279C", Slot = "14")]
	public bool IsRightLegAttack()
	{
		return default(bool);
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x9727B4", Offset = "0x9727B4", VA = "0x9727B4", Slot = "15")]
	public bool IsLeftLegAttack()
	{
		return default(bool);
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x9727CC", Offset = "0x9727CC", VA = "0x9727CC", Slot = "22")]
	public void PrepareAttack(float time_attack, float max_move_length, Game.EEventType type)
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x972888", Offset = "0x972888", VA = "0x972888")]
	public void SynchronizeIdleToMusic(float time_attack)
	{
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x972998", Offset = "0x972998", VA = "0x972998")]
	private void UploadNextAttackFromOrder()
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x972A04", Offset = "0x972A04", VA = "0x972A04")]
	private int SelectAttactIDXFromSequence()
	{
		return default(int);
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x972AB0", Offset = "0x972AB0", VA = "0x972AB0")]
	private float GetTimeToAttack()
	{
		return default(float);
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x9705E0", Offset = "0x9705E0", VA = "0x9705E0")]
	private void UpdateNextAttack()
	{
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x972AF4", Offset = "0x972AF4", VA = "0x972AF4", Slot = "23")]
	public void Strafe(bool left, float max_move_length)
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x972BE4", Offset = "0x972BE4", VA = "0x972BE4", Slot = "21")]
	public void PlayEmot()
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x972C5C", Offset = "0x972C5C", VA = "0x972C5C")]
	private void BlockDown(float time = 2f)
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x972D68", Offset = "0x972D68", VA = "0x972D68")]
	private void BlockUp(float time = 2f)
	{
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x972E6C", Offset = "0x972E6C", VA = "0x972E6C", Slot = "16")]
	public void OnBlock()
	{
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x973220", Offset = "0x973220", VA = "0x973220", Slot = "17")]
	public void OnPlayerDamage()
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x973224", Offset = "0x973224", VA = "0x973224", Slot = "9")]
	public bool IsComboSucess()
	{
		return default(bool);
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x97026C", Offset = "0x97026C", VA = "0x97026C", Slot = "24")]
	public bool IsDuringCombo()
	{
		return default(bool);
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x9732B4", Offset = "0x9732B4", VA = "0x9732B4", Slot = "10")]
	public void StartCombo(float period)
	{
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x9734E8", Offset = "0x9734E8", VA = "0x9734E8")]
	private void CalculateBonus(Game.HitTarget target, ref int body_part_bonus, ref Color hit_color)
	{
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x973690", Offset = "0x973690", VA = "0x973690", Slot = "20")]
	public void OnHit(Vector3 pos, Vector3 dir, int damage, XRHandController hand, Game.HitTarget target, Collider collider, ref int body_part_bonus)
	{
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x972664", Offset = "0x972664", VA = "0x972664")]
	private void UpdateDisperseEffect()
	{
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x970B2C", Offset = "0x970B2C", VA = "0x970B2C")]
	private void UpdateAppearEffect()
	{
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x9710D0", Offset = "0x9710D0", VA = "0x9710D0")]
	private void UpdateHitEffect()
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x970E00", Offset = "0x970E00", VA = "0x970E00")]
	private void UpdateBeatEfect()
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x973A68", Offset = "0x973A68", VA = "0x973A68")]
	public void OnStartAttackRightHand()
	{
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x973B70", Offset = "0x973B70", VA = "0x973B70")]
	public void OnStartAttackRightLeg()
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x973BD8", Offset = "0x973BD8", VA = "0x973BD8")]
	public void OnStartAttackLeftHand()
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x973C40", Offset = "0x973C40", VA = "0x973C40")]
	public void OnStartAttackLeftLeg()
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x973CA8", Offset = "0x973CA8", VA = "0x973CA8", Slot = "19")]
	public void OnEndAttackAfterHit()
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x973CB4", Offset = "0x973CB4", VA = "0x973CB4")]
	public void OnEndAttack()
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x973CEC", Offset = "0x973CEC", VA = "0x973CEC", Slot = "5")]
	public void Disapear()
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x970370", Offset = "0x970370", VA = "0x970370")]
	public void Die()
	{
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x973AD0", Offset = "0x973AD0", VA = "0x973AD0")]
	public void PlaySound(string clip_name, float volume = 1f)
	{
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x973D00", Offset = "0x973D00", VA = "0x973D00", Slot = "6")]
	public void Activate()
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x973D24", Offset = "0x973D24", VA = "0x973D24", Slot = "7")]
	public void Deactivate()
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x973D48", Offset = "0x973D48", VA = "0x973D48", Slot = "4")]
	public void Despawn()
	{
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x973988", Offset = "0x973988", VA = "0x973988")]
	private void OnHitBehaviour(Game.HitTarget target)
	{
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x973F9C", Offset = "0x973F9C", VA = "0x973F9C")]
	private void UpdateOutOfRing()
	{
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x97453C", Offset = "0x97453C", VA = "0x97453C")]
	private void UpdateEnemyToClose(Vector3 center_pos)
	{
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x971464", Offset = "0x971464", VA = "0x971464")]
	public void UpdateFlyingBeh()
	{
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x9748E4", Offset = "0x9748E4", VA = "0x9748E4")]
	public float GetRotataionCorrection()
	{
		return default(float);
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x971B38", Offset = "0x971B38", VA = "0x971B38")]
	private void UpdatePosAndRotation()
	{
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x9748FC", Offset = "0x9748FC", VA = "0x9748FC", Slot = "18")]
	public void OnBodyPenetraaion(Vector3 avatar_pos)
	{
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x972414", Offset = "0x972414", VA = "0x972414")]
	private void UpdateBodyPenetration()
	{
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x974A54", Offset = "0x974A54", VA = "0x974A54", Slot = "8")]
	public Enemy GetEnemy()
	{
		return null;
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x974A5C", Offset = "0x974A5C", VA = "0x974A5C")]
	public BagEnemy()
	{
	}
}
[Token(Token = "0x200001C")]
public class BeatColorizer : MonoBehaviour
{
	[Token(Token = "0x400010A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Game game;

	[Token(Token = "0x400010B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Material material;

	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string paramName;

	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Color[] colors;

	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool alphaModify;

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x974B5C", Offset = "0x974B5C", VA = "0x974B5C")]
	private void Start()
	{
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x974BD4", Offset = "0x974BD4", VA = "0x974BD4")]
	private void Update()
	{
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x974D74", Offset = "0x974D74", VA = "0x974D74")]
	public BeatColorizer()
	{
	}
}
[Token(Token = "0x200001D")]
public class BeatScaller : MonoBehaviour
{
	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 baseScale;

	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Vector3 destScale;

	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Game game;

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x974D84", Offset = "0x974D84", VA = "0x974D84")]
	private void Start()
	{
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x974DFC", Offset = "0x974DFC", VA = "0x974DFC")]
	private void Update()
	{
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x974E74", Offset = "0x974E74", VA = "0x974E74")]
	public BeatScaller()
	{
	}
}
[Token(Token = "0x200001E")]
public class Bliboards : MonoBehaviour
{
	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public SpriteRenderer[] rendereres;

	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Sprite[] sprites;

	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float[] times;

	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int[] sequences;

	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int seq_idx;

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x974E7C", Offset = "0x974E7C", VA = "0x974E7C")]
	private void Start()
	{
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x974F3C", Offset = "0x974F3C", VA = "0x974F3C")]
	private void Update()
	{
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x975084", Offset = "0x975084", VA = "0x975084")]
	public Bliboards()
	{
	}
}
[Token(Token = "0x200001F")]
public class BoxHandle : HandInteractable
{
	[Token(Token = "0x4000117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private PuzzleBox puzzleBox;

	[Token(Token = "0x4000118")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector3 snapPos;

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x97508C", Offset = "0x97508C", VA = "0x97508C")]
	protected void Start()
	{
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x9750E4", Offset = "0x9750E4", VA = "0x9750E4")]
	private void Update()
	{
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x9750E8", Offset = "0x9750E8", VA = "0x9750E8")]
	private void UpdateBoxHolding()
	{
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x9753A4", Offset = "0x9753A4", VA = "0x9753A4", Slot = "4")]
	public override void OnStartDragging(XRHandController hand)
	{
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x975448", Offset = "0x975448", VA = "0x975448")]
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
		[Token(Token = "0x400012E")]
		Exit,
		[Token(Token = "0x400012F")]
		Restart,
		[Token(Token = "0x4000130")]
		Continue,
		[Token(Token = "0x4000131")]
		Play,
		[Token(Token = "0x4000132")]
		Tutorial,
		[Token(Token = "0x4000133")]
		Lobby,
		[Token(Token = "0x4000134")]
		Test,
		[Token(Token = "0x4000135")]
		TOT_Official,
		[Token(Token = "0x4000136")]
		TOT_Custom,
		[Token(Token = "0x4000137")]
		TOT_Mp3,
		[Token(Token = "0x4000138")]
		CHA_OPT1,
		[Token(Token = "0x4000139")]
		CHA_OPT2,
		[Token(Token = "0x400013A")]
		CHA_OPT3,
		[Token(Token = "0x400013B")]
		CustomEnemySlot,
		[Token(Token = "0x400013C")]
		SelectEnemy,
		[Token(Token = "0x400013D")]
		SelectIntensity,
		[Token(Token = "0x400013E")]
		TimeBtwnSpawns,
		[Token(Token = "0x400013F")]
		AddTrack,
		[Token(Token = "0x4000140")]
		RemoveTrack,
		[Token(Token = "0x4000141")]
		UpTrack,
		[Token(Token = "0x4000142")]
		DownTrack,
		[Token(Token = "0x4000143")]
		StartPlaylist,
		[Token(Token = "0x4000144")]
		AutoStart,
		[Token(Token = "0x4000145")]
		TutorialChapter,
		[Token(Token = "0x4000146")]
		ArenaSelector,
		[Token(Token = "0x4000147")]
		SFXVolume,
		[Token(Token = "0x4000148")]
		SFXType,
		[Token(Token = "0x4000149")]
		Achievement,
		[Token(Token = "0x400014A")]
		HowToPlay,
		[Token(Token = "0x400014B")]
		Accept
	}

	[Token(Token = "0x4000119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Type type;

	[Token(Token = "0x400011A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int data;

	[Token(Token = "0x400011B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector3 movement;

	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public Vector3 addTranslate;

	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject selector;

	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Vector3 basePos;

	[Token(Token = "0x400011F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private Quaternion baseRot;

	[Token(Token = "0x4000120")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private bool selected;

	[Token(Token = "0x4000121")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
	public bool animateFromGround;

	[Token(Token = "0x4000122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Material selMat;

	[Token(Token = "0x4000123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Material baseMat;

	[Token(Token = "0x4000124")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public bool playSoundOnSelect;

	[Token(Token = "0x4000125")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
	private bool readyToUse;

	[Token(Token = "0x4000126")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public float blockTimeAfterUse;

	[Token(Token = "0x4000127")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private float blockTime;

	[Token(Token = "0x4000128")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public Vector3 clickTranslate;

	[Token(Token = "0x4000129")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public float clickAnimTime;

	[Token(Token = "0x400012A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private float clickAnimProgress;

	[Token(Token = "0x400012B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private XRHandController lastTouchedHand;

	[Token(Token = "0x400012C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public float waitTime;

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x9754A8", Offset = "0x9754A8", VA = "0x9754A8")]
	public void SetReadyToUse(bool val)
	{
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x9754B4", Offset = "0x9754B4", VA = "0x9754B4")]
	private void Start()
	{
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x975650", Offset = "0x975650", VA = "0x975650")]
	public void SetBaseTransform()
	{
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x96AABC", Offset = "0x96AABC", VA = "0x96AABC")]
	public void SetSelected(bool sel)
	{
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x975760", Offset = "0x975760", VA = "0x975760")]
	private void Update()
	{
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x9757C8", Offset = "0x9757C8", VA = "0x9757C8")]
	private void AnimateButton()
	{
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x9756A0", Offset = "0x9756A0", VA = "0x9756A0")]
	private void PlaySound()
	{
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x975AD8", Offset = "0x975AD8", VA = "0x975AD8")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x975BD0", Offset = "0x975BD0", VA = "0x975BD0")]
	private void ExecuteButtonAction()
	{
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x975FC4", Offset = "0x975FC4", VA = "0x975FC4")]
	private void HandleCustomButtonActions()
	{
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x9760D4", Offset = "0x9760D4", VA = "0x9760D4")]
	public Button3D()
	{
	}
}
[Token(Token = "0x2000022")]
public class ComboMarker : MonoBehaviour
{
	[Token(Token = "0x400014C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float timeToDeactivate;

	[Token(Token = "0x400014D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private float activeTime;

	[Token(Token = "0x400014E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float prevScale;

	[Token(Token = "0x400014F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool passed;

	[Token(Token = "0x4000150")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
	public bool mainTarget;

	[Token(Token = "0x4000151")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
	private bool leftHandInside;

	[Token(Token = "0x4000152")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x27")]
	private bool rightHandInside;

	[Token(Token = "0x4000153")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Material mainMat;

	[Token(Token = "0x4000154")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Material standardMat;

	[Token(Token = "0x4000155")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public MeshRenderer rederer;

	[Token(Token = "0x4000156")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool finisher;

	[Token(Token = "0x4000157")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public MeshRenderer finisherTimeMarker;

	[Token(Token = "0x4000158")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float timeToPerfectHit;

	[Token(Token = "0x4000159")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public Color inactiveColor;

	[Token(Token = "0x400015A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public Color activeColor;

	[Token(Token = "0x400015B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public GameObject sphere;

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x97329C", Offset = "0x97329C", VA = "0x97329C")]
	public void SetMainTarget()
	{
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x9733C0", Offset = "0x9733C0", VA = "0x9733C0")]
	public void Activate(float period, float active_pause)
	{
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x976200", Offset = "0x976200", VA = "0x976200")]
	private void Update()
	{
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x976934", Offset = "0x976934", VA = "0x976934")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x976F5C", Offset = "0x976F5C", VA = "0x976F5C")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x976B00", Offset = "0x976B00", VA = "0x976B00")]
	private void OnPassed(Vector3 dir, XRHandController hand)
	{
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x9738E0", Offset = "0x9738E0", VA = "0x9738E0")]
	public void OnHit(XRHandController hand, Vector3 dir)
	{
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0x97702C", Offset = "0x97702C", VA = "0x97702C")]
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
		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Compositor <>4__this;

		[Token(Token = "0x17000019")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600011C")]
			[Address(RVA = "0x97A71C", Offset = "0x97A71C", VA = "0x97A71C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600011E")]
			[Address(RVA = "0x97A764", Offset = "0x97A764", VA = "0x97A764", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x97A59C", Offset = "0x97A59C", VA = "0x97A59C")]
		[DebuggerHidden]
		public <WaitForWebRequest>d__29(int <>1__state)
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x97A5C4", Offset = "0x97A5C4", VA = "0x97A5C4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x97A5C8", Offset = "0x97A5C8", VA = "0x97A5C8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x97A724", Offset = "0x97A724", VA = "0x97A724", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400015C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private RhythmAnalyzer analyzer;

	[Token(Token = "0x400015D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AudioSource musicSource;

	[Token(Token = "0x400015E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool compose;

	[Token(Token = "0x400015F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private RhythmData rhythmData;

	[Token(Token = "0x4000160")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private List<Beat> m_Beats;

	[Token(Token = "0x4000161")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private List<Value> m_Segments;

	[Token(Token = "0x4000162")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private List<int> m_BeatSeg;

	[Token(Token = "0x4000163")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private List<int> upDownSeg;

	[Token(Token = "0x4000164")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public int BPM;

	[Token(Token = "0x4000165")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public int LEN;

	[Token(Token = "0x4000166")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public int RATE;

	[Token(Token = "0x4000167")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public int SLOTS;

	[Token(Token = "0x4000168")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public int INTENSE;

	[Token(Token = "0x4000169")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Material progressMaterial;

	[Token(Token = "0x400016A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private string notes;

	[Token(Token = "0x400016B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private string tamps;

	[Token(Token = "0x400016C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public bool m_UseHigestBPM;

	[Token(Token = "0x400016D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private float TIME_BTWN_SPAWN;

	[Token(Token = "0x400016E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private int left_right;

	[Token(Token = "0x400016F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private int lastRotateBeatIDX;

	[Token(Token = "0x4000170")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private UnityWebRequest webRequest;

	[Token(Token = "0x4000171")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private AsyncOperation operation;

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x977054", Offset = "0x977054", VA = "0x977054")]
	public void SetTimeBtwnSpawns(int time_btwn_spawn)
	{
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x977070", Offset = "0x977070", VA = "0x977070")]
	private int RandomizeRotation(ref string notes, int beat_idx)
	{
		return default(int);
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0x977150", Offset = "0x977150", VA = "0x977150")]
	private void ComposeNotes(int version)
	{
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0x977B84", Offset = "0x977B84", VA = "0x977B84")]
	private int AddPadding(int beat_idx, int i)
	{
		return default(int);
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x977CEC", Offset = "0x977CEC", VA = "0x977CEC")]
	private void TestSegments()
	{
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x978124", Offset = "0x978124", VA = "0x978124")]
	public void CalculateBPM()
	{
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x978504", Offset = "0x978504", VA = "0x978504")]
	public void Abort()
	{
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x978594", Offset = "0x978594", VA = "0x978594")]
	private IEnumerator WaitForWebRequest()
	{
		return null;
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0x978608", Offset = "0x978608", VA = "0x978608")]
	private void LoadAudioClip()
	{
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0x97873C", Offset = "0x97873C", VA = "0x97873C")]
	private void Update()
	{
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0x978780", Offset = "0x978780", VA = "0x978780")]
	public void Compose()
	{
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0x978920", Offset = "0x978920", VA = "0x978920")]
	private void UpdateProgressMaterial()
	{
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0x978740", Offset = "0x978740", VA = "0x978740")]
	public void UpdateCompositor()
	{
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0x979154", Offset = "0x979154", VA = "0x979154")]
	private void MakeHeader()
	{
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0x979264", Offset = "0x979264", VA = "0x979264")]
	private void CalculateSegments()
	{
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0x979B10", Offset = "0x979B10", VA = "0x979B10")]
	private void RemoveToOftenSequences()
	{
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0x9789B4", Offset = "0x9789B4", VA = "0x9789B4")]
	public void CreateTrack()
	{
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0x97A004", Offset = "0x97A004", VA = "0x97A004")]
	private void SaveTamps(string title_path)
	{
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0x97A3C8", Offset = "0x97A3C8", VA = "0x97A3C8")]
	public void SaveGeneratedTrack(string title_path, string notes)
	{
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0x979D10", Offset = "0x979D10", VA = "0x979D10")]
	public void StabilizeTempo()
	{
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x97A49C", Offset = "0x97A49C", VA = "0x97A49C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x97A52C", Offset = "0x97A52C", VA = "0x97A52C")]
	public Compositor()
	{
	}
}
[Token(Token = "0x2000025")]
public class Damager : MonoBehaviour
{
	[Token(Token = "0x600011F")]
	[Address(RVA = "0x97A76C", Offset = "0x97A76C", VA = "0x97A76C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0x97A808", Offset = "0x97A808", VA = "0x97A808")]
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
		[Token(Token = "0x400017C")]
		Body,
		[Token(Token = "0x400017D")]
		Head,
		[Token(Token = "0x400017E")]
		HandR,
		[Token(Token = "0x400017F")]
		HandL,
		[Token(Token = "0x4000180")]
		Guard,
		[Token(Token = "0x4000181")]
		Camera
	}

	[Token(Token = "0x4000175")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Avatar avatar;

	[Token(Token = "0x4000176")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Game game;

	[Token(Token = "0x4000177")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Type type;

	[Token(Token = "0x4000178")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private bool wasDamageInLastFrame;

	[Token(Token = "0x4000179")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
	private bool kickDamage;

	[Token(Token = "0x400017A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E")]
	private bool leftDamage;

	[Token(Token = "0x6000121")]
	[Address(RVA = "0x97A810", Offset = "0x97A810", VA = "0x97A810")]
	private void Start()
	{
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0x97A8B4", Offset = "0x97A8B4", VA = "0x97A8B4")]
	private bool IsHandAtackPart(string name)
	{
		return default(bool);
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0x97A968", Offset = "0x97A968", VA = "0x97A968")]
	private bool IsLegAtackPart(string name)
	{
		return default(bool);
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0x97A9F4", Offset = "0x97A9F4", VA = "0x97A9F4")]
	private bool IsEnemyBody(string name)
	{
		return default(bool);
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0x97AA80", Offset = "0x97AA80", VA = "0x97AA80")]
	private void CheckAttackCollision(Collider other)
	{
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0x97AFC4", Offset = "0x97AFC4", VA = "0x97AFC4")]
	private void OnTriggerStay(Collider other)
	{
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0x97B174", Offset = "0x97B174", VA = "0x97B174")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0x97B260", Offset = "0x97B260", VA = "0x97B260")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0x97B29C", Offset = "0x97B29C", VA = "0x97B29C")]
	public Detector()
	{
	}
}
[Token(Token = "0x2000028")]
public class Enemy : MonoBehaviour, IEnemy
{
	[Token(Token = "0x2000029")]
	public enum OnHitBeh
	{
		[Token(Token = "0x40001EE")]
		NoReaction,
		[Token(Token = "0x40001EF")]
		TwoNoneOne,
		[Token(Token = "0x40001F0")]
		TwoNoneTwo,
		[Token(Token = "0x40001F1")]
		TwoNoneNone,
		[Token(Token = "0x40001F2")]
		OneNoneNone,
		[Token(Token = "0x40001F3")]
		OneNoneTwo,
		[Token(Token = "0x40001F4")]
		OneNoneOne
	}

	[Token(Token = "0x4000182")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OnHitBeh onHitBehaviour;

	[Token(Token = "0x4000183")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool noRotate;

	[Token(Token = "0x4000184")]
	private const float HAND_ON_TIME = 0.3f;

	[Token(Token = "0x4000185")]
	private const float SNAP_TO_BASE_PERIOD = 0.4f;

	[Token(Token = "0x4000186")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float hitEffectPower;

	[Token(Token = "0x4000187")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float[] atacksLen;

	[Token(Token = "0x4000188")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float[] atacksHitFrame;

	[Token(Token = "0x4000189")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float[] atacksRatio;

	[Token(Token = "0x400018A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int[] attackSeq;

	[Token(Token = "0x400018B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public int[] berserkerkSeq;

	[Token(Token = "0x400018C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public int[] complicatedSeq;

	[Token(Token = "0x400018D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Game game;

	[Token(Token = "0x400018E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Animator animator;

	[Token(Token = "0x400018F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public HitEffector hitEffector;

	[Token(Token = "0x4000190")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Vector3 animatorBasePos;

	[Token(Token = "0x4000191")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private Quaternion animatorBaseRot;

	[Token(Token = "0x4000192")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private float baseScale;

	[Token(Token = "0x4000193")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private bool duringAttackAnim;

	[Token(Token = "0x4000194")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
	private bool rightHandAttack;

	[Token(Token = "0x4000195")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x92")]
	private bool leftHandAttack;

	[Token(Token = "0x4000196")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x93")]
	private bool rightLegAttack;

	[Token(Token = "0x4000197")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private bool leftLegAttack;

	[Token(Token = "0x4000198")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private float duringMovementAnim;

	[Token(Token = "0x4000199")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private float lifeTime;

	[Token(Token = "0x400019A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public SkinnedMeshRenderer[] bodyParts;

	[Token(Token = "0x400019B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public int[] matIndexes;

	[Token(Token = "0x400019C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public bool mirrored;

	[Token(Token = "0x400019D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	private float movementLayerWeight;

	[Token(Token = "0x400019E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private ArmsCorrection armsCorrection;

	[Token(Token = "0x400019F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private float handOffLayerWeight;

	[Token(Token = "0x40001A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	private float handOffTime;

	[Token(Token = "0x40001A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public float handOffPower;

	[Token(Token = "0x40001A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	public bool handsOffDuringCombo;

	[Token(Token = "0x40001A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public ComboMarker[] comboMarkers;

	[Token(Token = "0x40001A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private AudioSource audioSource;

	[Token(Token = "0x40001A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public Vector3 hudOffset;

	[Token(Token = "0x40001A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	public bool duringBerserker;

	[Token(Token = "0x40001A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private float comboLayerWeight;

	[Token(Token = "0x40001A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	public float comboLayerPower;

	[Token(Token = "0x40001A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public float baseDist;

	[Token(Token = "0x40001AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	public float minDistToPlayer;

	[Token(Token = "0x40001AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public float maxDistToPlayer;

	[Token(Token = "0x40001AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
	public float offsetToPlayerDuringAttack;

	[Token(Token = "0x40001AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private float animatedOffsetDuringAttack;

	[Token(Token = "0x40001AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
	public float rotationCorrection;

	[Token(Token = "0x40001AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public float ANIM_IDLE_SPEED;

	[Token(Token = "0x40001B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public ComboMarker finisher;

	[Token(Token = "0x40001B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public GameObject[] toHideDuringDissolve;

	[Token(Token = "0x40001B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private Vector3 basePos;

	[Token(Token = "0x40001B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
	private float timeToNormalSpeed;

	[Token(Token = "0x40001B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private float nextAttackTime;

	[Token(Token = "0x40001B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
	private float nextAttackMaxLen;

	[Token(Token = "0x40001B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private Game.EEventType nextAttackType;

	[Token(Token = "0x40001B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
	private float attackTime;

	[Token(Token = "0x40001B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private float attackMaxLen;

	[Token(Token = "0x40001B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
	private Game.EEventType attackType;

	[Token(Token = "0x40001BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private float handsOffWindow;

	[Token(Token = "0x40001BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
	private bool blockAttacks;

	[Token(Token = "0x40001BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private int attackIDX;

	[Token(Token = "0x40001BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
	public bool canBlockDuringCombo;

	[Token(Token = "0x40001BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private int headBonus;

	[Token(Token = "0x40001BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
	private int upBodyBonus;

	[Token(Token = "0x40001C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private int downBodyBonus;

	[Token(Token = "0x40001C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	public Material[] mainMats;

	[Token(Token = "0x40001C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	public Material[] appearMats;

	[Token(Token = "0x40001C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	public Material[] finisherMats;

	[Token(Token = "0x40001C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	public Material shadowMat;

	[Token(Token = "0x40001C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private float beatHighlight;

	[Token(Token = "0x40001C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	public Material[] beatHighMats;

	[Token(Token = "0x40001C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private bool appearMatChanged;

	[Token(Token = "0x40001C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
	private float dissolve;

	[Token(Token = "0x40001C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	public Material hitMaterial;

	[Token(Token = "0x40001CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	private Vector3 lastHitPos;

	[Token(Token = "0x40001CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
	private Color lastHitColor;

	[Token(Token = "0x40001CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	private Transform lastHitTransform;

	[Token(Token = "0x40001CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	private float lastHitProgress;

	[Token(Token = "0x40001CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
	private float lastHitRadius;

	[Token(Token = "0x40001CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	private Vector3 prevHitPos;

	[Token(Token = "0x40001D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1EC")]
	private Color prevHitColor;

	[Token(Token = "0x40001D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1FC")]
	private float prevHitProgress;

	[Token(Token = "0x40001D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	private Transform prevHitTransform;

	[Token(Token = "0x40001D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	private float prevHitRadius;

	[Token(Token = "0x40001D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
	private float timeToPlayerDodge;

	[Token(Token = "0x40001D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
	public bool dead;

	[Token(Token = "0x40001D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x214")]
	private float timeToDisperse;

	[Token(Token = "0x40001D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
	private float timeToDelete;

	[Token(Token = "0x40001D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21C")]
	private Game.HitTarget prevHitTarget;

	[Token(Token = "0x40001D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
	public bool scalerBehave;

	[Token(Token = "0x40001DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x224")]
	private float destScale;

	[Token(Token = "0x40001DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
	private float scaleProgress;

	[Token(Token = "0x40001DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x22C")]
	private float currScale;

	[Token(Token = "0x40001DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
	public bool jumperBehave;

	[Token(Token = "0x40001DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x234")]
	public float jumpTime;

	[Token(Token = "0x40001DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
	public float jumpSpeed;

	[Token(Token = "0x40001E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x23C")]
	private float destJumperAngle;

	[Token(Token = "0x40001E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
	private float curr_angle;

	[Token(Token = "0x40001E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x244")]
	private float jump_progress;

	[Token(Token = "0x40001E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
	private float snapToBasePosDuringIdleTime;

	[Token(Token = "0x40001E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24C")]
	private float snapRotataionTempo;

	[Token(Token = "0x40001E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
	private bool outOfRingDirLeft;

	[Token(Token = "0x40001E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x254")]
	private float timeToChnageOutOfDir;

	[Token(Token = "0x40001E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
	public bool blockOutOfRing;

	[Token(Token = "0x40001E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25C")]
	private float toCloseTime;

	[Token(Token = "0x40001E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
	public bool dancingBeh;

	[Token(Token = "0x40001EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x261")]
	public bool flyingBeh;

	[Token(Token = "0x40001EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x262")]
	public bool capoeiraBeh;

	[Token(Token = "0x40001EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x264")]
	private Vector3 bodyPenetrationInfluence;

	[Token(Token = "0x600012A")]
	[Address(RVA = "0x97B2A4", Offset = "0x97B2A4", VA = "0x97B2A4")]
	public float GetBaseDist()
	{
		return default(float);
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0x97B2B4", Offset = "0x97B2B4", VA = "0x97B2B4")]
	public float GetMinDistToPlayer()
	{
		return default(float);
	}

	[Token(Token = "0x600012C")]
	[Address(RVA = "0x97B2C4", Offset = "0x97B2C4", VA = "0x97B2C4")]
	public float GetMaxDistToPlayer()
	{
		return default(float);
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0x97B2D4", Offset = "0x97B2D4", VA = "0x97B2D4")]
	private void Start()
	{
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0x97BBAC", Offset = "0x97BBAC", VA = "0x97BBAC")]
	private void UpdateMovement()
	{
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0x97BCAC", Offset = "0x97BCAC", VA = "0x97BCAC")]
	private void UpdateHandsOff()
	{
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0x97BF5C", Offset = "0x97BF5C", VA = "0x97BF5C")]
	private void UpdateCombo()
	{
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0x97C148", Offset = "0x97C148", VA = "0x97C148")]
	private void UpdateDead()
	{
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0x97C234", Offset = "0x97C234", VA = "0x97C234")]
	private void UpdateOffsetDuringAttack()
	{
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0x97C268", Offset = "0x97C268", VA = "0x97C268")]
	private void Update()
	{
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0x97C9A8", Offset = "0x97C9A8", VA = "0x97C9A8")]
	private void UpdateAnimTransition()
	{
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0x97F214", Offset = "0x97F214", VA = "0x97F214", Slot = "11")]
	public bool IsDuringAttack()
	{
		return default(bool);
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0x97F24C", Offset = "0x97F24C", VA = "0x97F24C", Slot = "12")]
	public bool IsLeftHandAttack()
	{
		return default(bool);
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0x97F264", Offset = "0x97F264", VA = "0x97F264", Slot = "13")]
	public bool IsRightHandAttack()
	{
		return default(bool);
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0x97F27C", Offset = "0x97F27C", VA = "0x97F27C", Slot = "14")]
	public bool IsRightLegAttack()
	{
		return default(bool);
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0x97F294", Offset = "0x97F294", VA = "0x97F294", Slot = "15")]
	public bool IsLeftLegAttack()
	{
		return default(bool);
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0x97F2AC", Offset = "0x97F2AC", VA = "0x97F2AC")]
	public void BlockAttacks(bool val)
	{
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0x97F2B8", Offset = "0x97F2B8", VA = "0x97F2B8", Slot = "22")]
	public void PrepareAttack(float time_attack, float max_move_length, Game.EEventType type)
	{
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0x97F390", Offset = "0x97F390", VA = "0x97F390")]
	public void SynchronizeIdleToMusic(float time_attack)
	{
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0x97F54C", Offset = "0x97F54C", VA = "0x97F54C")]
	private void UploadNextAttackFromOrder()
	{
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0x97F5B8", Offset = "0x97F5B8", VA = "0x97F5B8")]
	private int SelectAttactIDXFromSequence()
	{
		return default(int);
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x97F664", Offset = "0x97F664", VA = "0x97F664")]
	private float GetTimeToAttack()
	{
		return default(float);
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x97C4B4", Offset = "0x97C4B4", VA = "0x97C4B4")]
	private void UpdateNextAttack()
	{
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0x97F6B4", Offset = "0x97F6B4", VA = "0x97F6B4", Slot = "23")]
	public void Strafe(bool left, float max_move_length)
	{
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0x97F7B4", Offset = "0x97F7B4", VA = "0x97F7B4", Slot = "21")]
	public void PlayEmot()
	{
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0x97F834", Offset = "0x97F834", VA = "0x97F834")]
	private void BlockDown(float time = 2f)
	{
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0x97F940", Offset = "0x97F940", VA = "0x97F940")]
	private void BlockUp(float time = 2f)
	{
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0x97FA44", Offset = "0x97FA44", VA = "0x97FA44", Slot = "16")]
	public void OnBlock()
	{
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0x97FE2C", Offset = "0x97FE2C", VA = "0x97FE2C", Slot = "17")]
	public void OnPlayerDamage()
	{
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0x97FE30", Offset = "0x97FE30", VA = "0x97FE30", Slot = "9")]
	public bool IsComboSucess()
	{
		return default(bool);
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0x97C0CC", Offset = "0x97C0CC", VA = "0x97C0CC", Slot = "24")]
	public bool IsDuringCombo()
	{
		return default(bool);
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0x97FE98", Offset = "0x97FE98", VA = "0x97FE98", Slot = "10")]
	public void StartCombo(float period)
	{
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0x97FFA0", Offset = "0x97FFA0", VA = "0x97FFA0")]
	public void ClearBodyBonus()
	{
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0x97FFAC", Offset = "0x97FFAC", VA = "0x97FFAC")]
	private void CalculateBonus(Game.HitTarget target, ref int body_part_bonus, ref Color hit_color)
	{
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0x980150", Offset = "0x980150", VA = "0x980150", Slot = "20")]
	public void OnHit(Vector3 pos, Vector3 dir, int damage, XRHandController hand, Game.HitTarget target, Collider collider, ref int body_part_bonus)
	{
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0x9804F4", Offset = "0x9804F4", VA = "0x9804F4")]
	public void SetAppearMatChanged(bool val)
	{
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0x97EFA8", Offset = "0x97EFA8", VA = "0x97EFA8")]
	private void UpdateDisperseEffect()
	{
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0x97CA04", Offset = "0x97CA04", VA = "0x97CA04")]
	private void UpdateAppearEffect()
	{
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0x97CFAC", Offset = "0x97CFAC", VA = "0x97CFAC")]
	private void UpdateHitEffect()
	{
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0x97CCDC", Offset = "0x97CCDC", VA = "0x97CCDC")]
	private void UpdateBeatEfect()
	{
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0x980500", Offset = "0x980500", VA = "0x980500")]
	public void OnStartAttackRightHand()
	{
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0x980608", Offset = "0x980608", VA = "0x980608")]
	public void OnStartAttackRightLeg()
	{
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0x980670", Offset = "0x980670", VA = "0x980670")]
	public void OnStartAttackLeftHand()
	{
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0x9806D8", Offset = "0x9806D8", VA = "0x9806D8")]
	public void OnStartAttackLeftLeg()
	{
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0x980740", Offset = "0x980740", VA = "0x980740", Slot = "19")]
	public void OnEndAttackAfterHit()
	{
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0x98074C", Offset = "0x98074C", VA = "0x98074C")]
	public void OnEndAttack()
	{
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0x980784", Offset = "0x980784", VA = "0x980784", Slot = "5")]
	public void Disapear()
	{
	}

	[Token(Token = "0x6000159")]
	[Address(RVA = "0x97C1D8", Offset = "0x97C1D8", VA = "0x97C1D8")]
	public void Die()
	{
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0x980568", Offset = "0x980568", VA = "0x980568")]
	public void PlaySound(string clip_name, float volume = 1f)
	{
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0x980888", Offset = "0x980888", VA = "0x980888", Slot = "6")]
	public void Activate()
	{
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0x9808AC", Offset = "0x9808AC", VA = "0x9808AC", Slot = "7")]
	public void Deactivate()
	{
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0x9808D0", Offset = "0x9808D0", VA = "0x9808D0", Slot = "4")]
	public void Despawn()
	{
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x980414", Offset = "0x980414", VA = "0x980414")]
	private void OnHitBehaviour(Game.HitTarget target)
	{
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0x97D81C", Offset = "0x97D81C", VA = "0x97D81C")]
	private void UpdateScalerBehave()
	{
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0x980B18", Offset = "0x980B18", VA = "0x980B18")]
	public void OnJump()
	{
	}

	[Token(Token = "0x6000161")]
	[Address(RVA = "0x97D340", Offset = "0x97D340", VA = "0x97D340")]
	private void UpdateJumperBehave()
	{
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0x980BFC", Offset = "0x980BFC", VA = "0x980BFC")]
	private void UpdateOutOfRing()
	{
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0x9811A4", Offset = "0x9811A4", VA = "0x9811A4")]
	private void UpdateEnemyToClose(Vector3 center_pos)
	{
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0x97D958", Offset = "0x97D958", VA = "0x97D958")]
	public void UpdateDancingBeh()
	{
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0x97DD98", Offset = "0x97DD98", VA = "0x97DD98")]
	public void UpdateFlyingBeh()
	{
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0x97E46C", Offset = "0x97E46C", VA = "0x97E46C")]
	public void UpdateCapoeiraBeh()
	{
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0x980BE4", Offset = "0x980BE4", VA = "0x980BE4")]
	public float GetRotataionCorrection()
	{
		return default(float);
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0x97E470", Offset = "0x97E470", VA = "0x97E470")]
	private void UpdatePosAndRotation()
	{
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0x98156C", Offset = "0x98156C", VA = "0x98156C", Slot = "18")]
	public void OnBodyPenetraaion(Vector3 avatar_pos)
	{
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0x97ED54", Offset = "0x97ED54", VA = "0x97ED54")]
	private void UpdateBodyPenetration()
	{
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0x9816C8", Offset = "0x9816C8", VA = "0x9816C8", Slot = "8")]
	public Enemy GetEnemy()
	{
		return null;
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0x9816CC", Offset = "0x9816CC", VA = "0x9816CC")]
	public void SetupTransform(Vector3 position, Quaternion rotation, Vector3 scale)
	{
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0x9817B4", Offset = "0x9817B4", VA = "0x9817B4")]
	public Enemy()
	{
	}
}
[Token(Token = "0x200002A")]
public class EqualizerEffect : MonoBehaviour
{
	[Token(Token = "0x40001F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private MeshFilter m_Mesh;

	[Token(Token = "0x40001F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private MeshRenderer m_Renderer;

	[Token(Token = "0x40001F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Game m_Game;

	[Token(Token = "0x40001F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private AudioSource musicSource;

	[Token(Token = "0x40001F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool m_Tutorial;

	[Token(Token = "0x40001FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Material m_AnimLightMat;

	[Token(Token = "0x40001FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Material m_RoundEqulizerMat;

	[Token(Token = "0x40001FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Material m_BarsEqulizerMat;

	[Token(Token = "0x40001FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Material m_BarsEqulizerHaloMat;

	[Token(Token = "0x40001FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Material m_SkyscraperWindowsMat;

	[Token(Token = "0x40001FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Material m_SkyscraperWindowsHaloMat;

	[Token(Token = "0x4000200")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Material m_MotionMat;

	[Token(Token = "0x4000201")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Material m_MotionColorofonMat;

	[Token(Token = "0x4000202")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Material m_MotionColorofonHaloMat;

	[Token(Token = "0x4000203")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Material m_FlorHaloMat;

	[Token(Token = "0x4000204")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Material m_SkyMat;

	[Token(Token = "0x4000205")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Material m_ArenaMat;

	[Token(Token = "0x4000206")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Material m_ArenaMatNoReflects;

	[Token(Token = "0x4000207")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Material m_ArenaLinesMat;

	[Token(Token = "0x4000208")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Material m_ArenaLinesHaloMat;

	[Token(Token = "0x4000209")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Material m_LavaToAnimMat;

	[Token(Token = "0x400020A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public float LavaMul;

	[Token(Token = "0x400020B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public Light m_HUDLight;

	[Token(Token = "0x400020C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public float m_WallEffectPow;

	[Token(Token = "0x400020D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	public float m_SpecAmpltudeMod;

	[Token(Token = "0x400020E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private float m_AnimMatTime;

	[Token(Token = "0x400020F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	private float m_ScaleMod;

	[Token(Token = "0x4000210")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public float m_Hue;

	[Token(Token = "0x4000211")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	public int m_HueIDX;

	[Token(Token = "0x4000212")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public int m_HueStep;

	[Token(Token = "0x4000213")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	public int m_NoBands;

	[Token(Token = "0x4000214")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public float[] m_SpecVis;

	[Token(Token = "0x4000215")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public float[] m_NotesVis;

	[Token(Token = "0x4000216")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public float[] m_NotesVisBlend;

	[Token(Token = "0x4000217")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public bool m_UseNotes;

	[Token(Token = "0x4000218")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x109")]
	public bool m_MainMenu;

	[Token(Token = "0x4000219")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
	public int m_ColorScheme;

	[Token(Token = "0x400021A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public bool m_DimColors;

	[Token(Token = "0x400021B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
	private float m_LavaProgress;

	[Token(Token = "0x400021C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public float barScale;

	[Token(Token = "0x600016E")]
	[Address(RVA = "0x9818D4", Offset = "0x9818D4", VA = "0x9818D4")]
	private void UpdateHue()
	{
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0x981A28", Offset = "0x981A28", VA = "0x981A28")]
	private void Start()
	{
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0x981B68", Offset = "0x981B68", VA = "0x981B68")]
	private void GenerateMesh()
	{
	}

	[Token(Token = "0x6000171")]
	[Address(RVA = "0x982184", Offset = "0x982184", VA = "0x982184")]
	private void GenerateBox(ref Vector3[] vertices, Quaternion rot, int offset, Vector3 center)
	{
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0x982648", Offset = "0x982648", VA = "0x982648")]
	private Vector3 GetBlockDir(Vector3 forward, Vector3 up, Vector3 left, int idx, Quaternion rot)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000173")]
	[Address(RVA = "0x9826E8", Offset = "0x9826E8", VA = "0x9826E8")]
	private Color HueToColor()
	{
		return default(Color);
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0x982838", Offset = "0x982838", VA = "0x982838")]
	private Color HueToLineColor()
	{
		return default(Color);
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0x982A30", Offset = "0x982A30", VA = "0x982A30")]
	private void UpdateLava()
	{
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0x982B6C", Offset = "0x982B6C", VA = "0x982B6C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0x983044", Offset = "0x983044", VA = "0x983044")]
	private void RoundEquzlizerUpdate()
	{
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0x98329C", Offset = "0x98329C", VA = "0x98329C")]
	private void BarsEquzlizerUpdate()
	{
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0x9838C8", Offset = "0x9838C8", VA = "0x9838C8")]
	private void MotionMatUpdate()
	{
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0x983F88", Offset = "0x983F88", VA = "0x983F88")]
	private void UpdateLightSynchroMats()
	{
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0x984060", Offset = "0x984060", VA = "0x984060")]
	public EqualizerEffect()
	{
	}
}
[Token(Token = "0x200002B")]
public class EventCatcher : MonoBehaviour
{
	[Token(Token = "0x400021D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Enemy enemy;

	[Token(Token = "0x600017C")]
	[Address(RVA = "0x98412C", Offset = "0x98412C", VA = "0x98412C")]
	private void Start()
	{
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0x984184", Offset = "0x984184", VA = "0x984184")]
	public void OnStartAttackRightHand()
	{
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0x984200", Offset = "0x984200", VA = "0x984200")]
	public void OnStartAttackRightLeg()
	{
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0x98427C", Offset = "0x98427C", VA = "0x98427C")]
	public void OnStartAttackLeftHand()
	{
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0x9842F8", Offset = "0x9842F8", VA = "0x9842F8")]
	public void OnStartAttackLeftLeg()
	{
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0x984374", Offset = "0x984374", VA = "0x984374")]
	public void OnEndAttack()
	{
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0x984418", Offset = "0x984418", VA = "0x984418")]
	public void OnJump()
	{
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0x984494", Offset = "0x984494", VA = "0x984494")]
	public EventCatcher()
	{
	}
}
[Token(Token = "0x200002C")]
public class Game : MonoBehaviour
{
	[Token(Token = "0x200002D")]
	public enum HitTarget
	{
		[Token(Token = "0x4000289")]
		BodyUp = 1,
		[Token(Token = "0x400028A")]
		BodyDown,
		[Token(Token = "0x400028B")]
		Head,
		[Token(Token = "0x400028C")]
		Other
	}

	[Token(Token = "0x200002E")]
	public enum EEventType
	{
		[Token(Token = "0x400028E")]
		Empty,
		[Token(Token = "0x400028F")]
		TutorialTest,
		[Token(Token = "0x4000290")]
		Emot,
		[Token(Token = "0x4000291")]
		SpawnEnemy,
		[Token(Token = "0x4000292")]
		DespawnEnemy,
		[Token(Token = "0x4000293")]
		Attack,
		[Token(Token = "0x4000294")]
		Berserker,
		[Token(Token = "0x4000295")]
		Complicated,
		[Token(Token = "0x4000296")]
		Left,
		[Token(Token = "0x4000297")]
		Right,
		[Token(Token = "0x4000298")]
		LasrDespawnEnemy
	}

	[Token(Token = "0x200002F")]
	public struct HandStats
	{
		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool m_Missed;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float m_Speed;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float m_Timing;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float m_Variety;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float m_BodyVariety;
	}

	[Token(Token = "0x2000030")]
	public struct TrackEvent
	{
		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EEventType type;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int timeLen;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string enemyName;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float timeStamp;
	}

	[Token(Token = "0x2000031")]
	private sealed class <LoadWebFile>d__90 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Game <>4__this;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private UnityWebRequest <www>5__2;

		[Token(Token = "0x1700001C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001BC")]
			[Address(RVA = "0x994BD4", Offset = "0x994BD4", VA = "0x994BD4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001BE")]
			[Address(RVA = "0x994C1C", Offset = "0x994C1C", VA = "0x994C1C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x9948CC", Offset = "0x9948CC", VA = "0x9948CC")]
		[DebuggerHidden]
		public <LoadWebFile>d__90(int <>1__state)
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x9948F4", Offset = "0x9948F4", VA = "0x9948F4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x9948F8", Offset = "0x9948F8", VA = "0x9948F8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x994BDC", Offset = "0x994BDC", VA = "0x994BDC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000032")]
	private sealed class <WaitForWebRequest>d__91 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Game <>4__this;

		[Token(Token = "0x1700001E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001C2")]
			[Address(RVA = "0x994DA4", Offset = "0x994DA4", VA = "0x994DA4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001C4")]
			[Address(RVA = "0x994DEC", Offset = "0x994DEC", VA = "0x994DEC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x994C24", Offset = "0x994C24", VA = "0x994C24")]
		[DebuggerHidden]
		public <WaitForWebRequest>d__91(int <>1__state)
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x994C4C", Offset = "0x994C4C", VA = "0x994C4C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x994C50", Offset = "0x994C50", VA = "0x994C50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x994DAC", Offset = "0x994DAC", VA = "0x994DAC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000033")]
	private sealed class <LoadLocalClip>d__95 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Game <>4__this;

		[Token(Token = "0x17000020")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001C8")]
			[Address(RVA = "0x99508C", Offset = "0x99508C", VA = "0x99508C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000021")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001CA")]
			[Address(RVA = "0x9950D4", Offset = "0x9950D4", VA = "0x9950D4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x994DF4", Offset = "0x994DF4", VA = "0x994DF4")]
		[DebuggerHidden]
		public <LoadLocalClip>d__95(int <>1__state)
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x994E1C", Offset = "0x994E1C", VA = "0x994E1C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x994E20", Offset = "0x994E20", VA = "0x994E20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x995094", Offset = "0x995094", VA = "0x995094", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400021E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static Game instance;

	[Token(Token = "0x400021F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool movieRecorder;

	[Token(Token = "0x4000220")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool onlyFXes;

	[Token(Token = "0x4000221")]
	public const float TIMING_PERFECT = 0.9f;

	[Token(Token = "0x4000222")]
	public const float TIMING_GOOD = 0.8f;

	[Token(Token = "0x4000223")]
	public const float TIMING_OK = 0.7f;

	[Token(Token = "0x4000224")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject dissolveSphere;

	[Token(Token = "0x4000225")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AdvancedDissolvePropertiesController dissolveController;

	[Token(Token = "0x4000226")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool comboTest;

	[Token(Token = "0x4000227")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	public bool offsetTest;

	[Token(Token = "0x4000228")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float timeTest;

	[Token(Token = "0x4000229")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string m_Notes;

	[Token(Token = "0x400022A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string m_Song;

	[Token(Token = "0x400022B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float m_AvHeight;

	[Token(Token = "0x400022C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private float currTime;

	[Token(Token = "0x400022D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float prevTime;

	[Token(Token = "0x400022E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public int startBeat;

	[Token(Token = "0x400022F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public float BPM;

	[Token(Token = "0x4000230")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public float offset;

	[Token(Token = "0x4000231")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public AudioSource musicSource;

	[Token(Token = "0x4000232")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public LevelCompleted levelCompleted;

	[Token(Token = "0x4000233")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public HUD hud;

	[Token(Token = "0x4000234")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public float m_Volume;

	[Token(Token = "0x4000235")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public bool m_RepeatedTut;

	[Token(Token = "0x4000236")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7D")]
	private bool m_SmallArea;

	[Token(Token = "0x4000237")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameObject[] toActivateOnFinish;

	[Token(Token = "0x4000238")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public GameObject[] toActivateOnPause;

	[Token(Token = "0x4000239")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public float slomoFactor;

	[Token(Token = "0x400023A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public float slomoTime;

	[Token(Token = "0x400023B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public XRHandController lGlove;

	[Token(Token = "0x400023C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public XRHandController rGlove;

	[Token(Token = "0x400023D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public CommonVR vr;

	[Token(Token = "0x400023E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private bool wasStarted;

	[Token(Token = "0x400023F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
	private bool m_Inited;

	[Token(Token = "0x4000240")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	public int m_FinisBeatIDx;

	[Token(Token = "0x4000241")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public AudioClip m_ClipToPlay;

	[Token(Token = "0x4000242")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public TrackEvent[] events;

	[Token(Token = "0x4000243")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public float m_Blackout;

	[Token(Token = "0x4000244")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private HandStats[] m_LStats;

	[Token(Token = "0x4000245")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private HandStats[] m_RStats;

	[Token(Token = "0x4000246")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private int m_LStatIDX;

	[Token(Token = "0x4000247")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	private int m_RStatIDX;

	[Token(Token = "0x4000248")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public int noDodges;

	[Token(Token = "0x4000249")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	public int noDamages;

	[Token(Token = "0x400024A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public int noBlocks;

	[Token(Token = "0x400024B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	public bool m_Pause;

	[Token(Token = "0x400024C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private float[] m_TimeStamps;

	[Token(Token = "0x400024D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public float m_GlobalSynchro;

	[Token(Token = "0x400024E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public IEnemy currEnemy;

	[Token(Token = "0x400024F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public int m_TrackLength;

	[Token(Token = "0x4000250")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
	public int m_AnalizedBeat;

	[Token(Token = "0x4000251")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private int m_PrevAnalizedBeat;

	[Token(Token = "0x4000252")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
	public int m_GBeatIDx;

	[Token(Token = "0x4000253")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public float m_GBeatProgress;

	[Token(Token = "0x4000254")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
	public int m_FXBeatIDx;

	[Token(Token = "0x4000255")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public float m_FXBeatProgress;

	[Token(Token = "0x4000256")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
	public int m_PrevIDx;

	[Token(Token = "0x4000257")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public int scoreMul;

	[Token(Token = "0x4000258")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
	public int scoreCounter;

	[Token(Token = "0x4000259")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	public float comboProgress;

	[Token(Token = "0x400025A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
	public float duringCombo;

	[Token(Token = "0x400025B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	public float comboDecraseTempo;

	[Token(Token = "0x400025C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
	public bool m_Finished;

	[Token(Token = "0x400025D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	public string[] enemyNames;

	[Token(Token = "0x400025E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	public int noEnemyNames;

	[Token(Token = "0x400025F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
	private int currEnemyIDX;

	[Token(Token = "0x4000260")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	public Transform spawnPlace;

	[Token(Token = "0x4000261")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	public Light mainLight;

	[Token(Token = "0x4000262")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	public Color NORMAL_LIGHT;

	[Token(Token = "0x4000263")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	public Color SLOMO_LIGHT;

	[Token(Token = "0x4000264")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	public Color PERFECT_COLOR;

	[Token(Token = "0x4000265")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	public Color GOOD_COLOR;

	[Token(Token = "0x4000266")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	public Color OK_COLOR;

	[Token(Token = "0x4000267")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	public Color BAD_COLOR;

	[Token(Token = "0x4000268")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	public bool getFromWeb;

	[Token(Token = "0x4000269")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	private Avatar <avatar>k__BackingField;

	[Token(Token = "0x400026A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	public Transform orientation;

	[Token(Token = "0x400026B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	private bool noCombo;

	[Token(Token = "0x400026C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	public Text skipText;

	[Token(Token = "0x400026D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	public Text restartText;

	[Token(Token = "0x400026E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	private UnityWebRequest webRequest;

	[Token(Token = "0x400026F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	private AsyncOperation operation;

	[Token(Token = "0x4000270")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	private int trackRate;

	[Token(Token = "0x4000271")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
	private int trackSlots;

	[Token(Token = "0x4000272")]
	private const float FULL_COMBO_PROGRESS = 100f;

	[Token(Token = "0x4000273")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
	public bool musicVolControlledOut;

	[Token(Token = "0x4000274")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x214")]
	private float comboMod;

	[Token(Token = "0x4000275")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
	public LiveTutorial tutorial;

	[Token(Token = "0x4000276")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
	private string sceneToReload;

	[Token(Token = "0x4000277")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
	private float timeToReload;

	[Token(Token = "0x4000278")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x22C")]
	private float m_LHandEnergy;

	[Token(Token = "0x4000279")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
	private float m_RHandEnergy;

	[Token(Token = "0x400027A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x234")]
	private float m_HeadEnergy;

	[Token(Token = "0x400027B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
	public float m_Calories;

	[Token(Token = "0x400027C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x23C")]
	private Vector3 m_LHandSpeed;

	[Token(Token = "0x400027D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
	private Vector3 m_RHandSpeed;

	[Token(Token = "0x400027E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x254")]
	private Vector3 m_HeadSpeed;

	[Token(Token = "0x400027F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
	private Vector3 m_LHandSpeedPrev;

	[Token(Token = "0x4000280")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x26C")]
	private Vector3 m_RHandSpeedPrev;

	[Token(Token = "0x4000281")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
	private Vector3 m_HeadSpeedPrev;

	[Token(Token = "0x4000282")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x284")]
	private Vector3 m_LHandPos;

	[Token(Token = "0x4000283")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
	private Vector3 m_RHandPos;

	[Token(Token = "0x4000284")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29C")]
	private Vector3 m_HeadPos;

	[Token(Token = "0x4000285")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
	private Vector3 m_LHandPosPrev;

	[Token(Token = "0x4000286")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B4")]
	private Vector3 m_RHandPosPrev;

	[Token(Token = "0x4000287")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
	private Vector3 m_HeadPosPrev;

	[Token(Token = "0x1700001B")]
	public Avatar avatar
	{
		[Token(Token = "0x6000187")]
		[Address(RVA = "0x9845E4", Offset = "0x9845E4", VA = "0x9845E4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000188")]
		[Address(RVA = "0x9845EC", Offset = "0x9845EC", VA = "0x9845EC")]
		set
		{
		}
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0x98449C", Offset = "0x98449C", VA = "0x98449C")]
	private void OnLoaded(AudioClip clip)
	{
	}

	[Token(Token = "0x6000185")]
	[Address(RVA = "0x9844CC", Offset = "0x9844CC", VA = "0x9844CC")]
	public int GetBeatTiming()
	{
		return default(int);
	}

	[Token(Token = "0x6000186")]
	[Address(RVA = "0x984544", Offset = "0x984544", VA = "0x984544")]
	public float GetStatsBeatTiming()
	{
		return default(float);
	}

	[Token(Token = "0x6000189")]
	[Address(RVA = "0x9845FC", Offset = "0x9845FC", VA = "0x9845FC")]
	private IEnumerator LoadWebFile()
	{
		return null;
	}

	[Token(Token = "0x600018A")]
	[Address(RVA = "0x984670", Offset = "0x984670", VA = "0x984670")]
	private IEnumerator WaitForWebRequest()
	{
		return null;
	}

	[Token(Token = "0x600018B")]
	[Address(RVA = "0x9846E4", Offset = "0x9846E4", VA = "0x9846E4")]
	private void LoadMP3Clip()
	{
	}

	[Token(Token = "0x600018C")]
	[Address(RVA = "0x9847D0", Offset = "0x9847D0", VA = "0x9847D0")]
	private IEnumerator LoadLocalClip()
	{
		return null;
	}

	[Token(Token = "0x600018D")]
	[Address(RVA = "0x984844", Offset = "0x984844", VA = "0x984844")]
	private void Init()
	{
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0x9848B8", Offset = "0x9848B8", VA = "0x9848B8")]
	private void Start()
	{
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0x984C7C", Offset = "0x984C7C", VA = "0x984C7C")]
	private void ClearEvents()
	{
	}

	[Token(Token = "0x6000190")]
	[Address(RVA = "0x984D60", Offset = "0x984D60", VA = "0x984D60")]
	private void StartGame()
	{
	}

	[Token(Token = "0x6000191")]
	[Address(RVA = "0x984DA4", Offset = "0x984DA4", VA = "0x984DA4")]
	public void PrepareTrack()
	{
	}

	[Token(Token = "0x6000192")]
	[Address(RVA = "0x985820", Offset = "0x985820", VA = "0x985820")]
	private void GenerateTamps()
	{
	}

	[Token(Token = "0x6000193")]
	[Address(RVA = "0x984EC4", Offset = "0x984EC4", VA = "0x984EC4")]
	public void ParseInfo(string notes)
	{
	}

	[Token(Token = "0x6000194")]
	[Address(RVA = "0x985FEC", Offset = "0x985FEC", VA = "0x985FEC")]
	private int ParseBeatsLen(ref string track, ref int beat_idx)
	{
		return default(int);
	}

	[Token(Token = "0x6000195")]
	[Address(RVA = "0x98597C", Offset = "0x98597C", VA = "0x98597C")]
	private string ParseTrack(string track, ref int beat_idx)
	{
		return null;
	}

	[Token(Token = "0x6000196")]
	[Address(RVA = "0x9860F8", Offset = "0x9860F8", VA = "0x9860F8")]
	public float GetCurrProgress()
	{
		return default(float);
	}

	[Token(Token = "0x6000197")]
	[Address(RVA = "0x97F6A4", Offset = "0x97F6A4", VA = "0x97F6A4")]
	public float GetCurrMusicTime()
	{
		return default(float);
	}

	[Token(Token = "0x6000198")]
	[Address(RVA = "0x98610C", Offset = "0x98610C", VA = "0x98610C")]
	private void UpdateSlomo()
	{
	}

	[Token(Token = "0x6000199")]
	[Address(RVA = "0x986324", Offset = "0x986324", VA = "0x986324")]
	public void StartCombo()
	{
	}

	[Token(Token = "0x600019A")]
	[Address(RVA = "0x986608", Offset = "0x986608", VA = "0x986608")]
	public void OnComboSucess()
	{
	}

	[Token(Token = "0x600019B")]
	[Address(RVA = "0x9866CC", Offset = "0x9866CC", VA = "0x9866CC")]
	public void OnComboMicroSucess()
	{
	}

	[Token(Token = "0x600019C")]
	[Address(RVA = "0x9866DC", Offset = "0x9866DC", VA = "0x9866DC")]
	private void UpdateCombo()
	{
	}

	[Token(Token = "0x600019D")]
	[Address(RVA = "0x986848", Offset = "0x986848", VA = "0x986848")]
	private void Update()
	{
	}

	[Token(Token = "0x600019E")]
	[Address(RVA = "0x9877E0", Offset = "0x9877E0", VA = "0x9877E0")]
	private void UpdateBlackout()
	{
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0x9869BC", Offset = "0x9869BC", VA = "0x9869BC")]
	public void Pause()
	{
	}

	[Token(Token = "0x60001A0")]
	[Address(RVA = "0x984BB8", Offset = "0x984BB8", VA = "0x984BB8")]
	public void HideAllButtons()
	{
	}

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0x988140", Offset = "0x988140", VA = "0x988140")]
	public void Resume()
	{
	}

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0x9882B4", Offset = "0x9882B4", VA = "0x9882B4")]
	public void OnPlayerDamage()
	{
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0x9884CC", Offset = "0x9884CC", VA = "0x9884CC")]
	public void OnBlock()
	{
	}

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0x97F078", Offset = "0x97F078", VA = "0x97F078")]
	public void OnDodge()
	{
	}

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0x9886E0", Offset = "0x9886E0", VA = "0x9886E0")]
	public void AddBonusPoints(int points)
	{
	}

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0x9886F4", Offset = "0x9886F4", VA = "0x9886F4")]
	public void SetComboMod(float val)
	{
	}

	[Token(Token = "0x60001A7")]
	[Address(RVA = "0x9886FC", Offset = "0x9886FC", VA = "0x9886FC")]
	public int OnHit(Vector3 pos, Vector3 dir, float speed, int hand_variety, XRHandController hand, HitTarget target, Collider collider)
	{
		return default(int);
	}

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0x986E14", Offset = "0x986E14", VA = "0x986E14")]
	public void OnFinish()
	{
	}

	[Token(Token = "0x60001A9")]
	[Address(RVA = "0x988D24", Offset = "0x988D24", VA = "0x988D24")]
	public void ReloadScene(string scene_name, float time)
	{
	}

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0x98691C", Offset = "0x98691C", VA = "0x98691C")]
	private void UpdateReload()
	{
	}

	[Token(Token = "0x60001AB")]
	[Address(RVA = "0x986568", Offset = "0x986568", VA = "0x986568")]
	public void PlaySound(string clip_name, float volume = 1f)
	{
	}

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0x988DE8", Offset = "0x988DE8", VA = "0x988DE8")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0x987898", Offset = "0x987898", VA = "0x987898")]
	private void EnergyCalculator()
	{
	}

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0x986500", Offset = "0x986500", VA = "0x986500")]
	public bool IsDespawnEvent(int no_beats)
	{
		return default(bool);
	}

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0x97F4B8", Offset = "0x97F4B8", VA = "0x97F4B8")]
	public float GetPeriodToBeat(int no_beats)
	{
		return default(float);
	}

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0x988E24", Offset = "0x988E24", VA = "0x988E24")]
	private void UpdateTimeStamp()
	{
	}

	[Token(Token = "0x60001B1")]
	[Address(RVA = "0x986C40", Offset = "0x986C40", VA = "0x986C40")]
	private void UpdateBeatIDx()
	{
	}

	[Token(Token = "0x60001B2")]
	[Address(RVA = "0x9876A8", Offset = "0x9876A8", VA = "0x9876A8")]
	private void AnalyzeEvents()
	{
	}

	[Token(Token = "0x60001B3")]
	[Address(RVA = "0x9893CC", Offset = "0x9893CC", VA = "0x9893CC")]
	private void PrepareAttack(int curr_beat)
	{
	}

	[Token(Token = "0x60001B4")]
	[Address(RVA = "0x98921C", Offset = "0x98921C", VA = "0x98921C")]
	private void SpawnEnemy(int curr_beat)
	{
	}

	[Token(Token = "0x60001B5")]
	[Address(RVA = "0x9890D8", Offset = "0x9890D8", VA = "0x9890D8")]
	private void DespawnEnemy(int curr_beat)
	{
	}

	[Token(Token = "0x60001B6")]
	[Address(RVA = "0x988F1C", Offset = "0x988F1C", VA = "0x988F1C")]
	private void PlayAnim(int curr_beat)
	{
	}

	[Token(Token = "0x60001B7")]
	[Address(RVA = "0x989510", Offset = "0x989510", VA = "0x989510")]
	public void OnButton(Button3D.Type button_type)
	{
	}

	[Token(Token = "0x60001B8")]
	[Address(RVA = "0x989514", Offset = "0x989514", VA = "0x989514")]
	public Game()
	{
	}
}
[Token(Token = "0x2000034")]
public class HandInteractable : Interactable
{
	[Token(Token = "0x40002AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
	public bool hapticOnlyWhenGripOff;

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0x9950DC", Offset = "0x9950DC", VA = "0x9950DC", Slot = "8")]
	public virtual void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0x99519C", Offset = "0x99519C", VA = "0x99519C", Slot = "9")]
	public virtual void OnTriggerStay(Collider other)
	{
	}

	[Token(Token = "0x60001CD")]
	[Address(RVA = "0x995410", Offset = "0x995410", VA = "0x995410", Slot = "10")]
	public virtual void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x60001CE")]
	[Address(RVA = "0x9954FC", Offset = "0x9954FC", VA = "0x9954FC")]
	public HandInteractable()
	{
	}
}
[Token(Token = "0x2000035")]
public class HeightSetup : ItemsList
{
	[Token(Token = "0x40002AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public bool metricUnit;

	[Token(Token = "0x60001CF")]
	[Address(RVA = "0x99551C", Offset = "0x99551C", VA = "0x99551C", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0x995618", Offset = "0x995618", VA = "0x995618", Slot = "8")]
	public override void FillData(UIItem item, int idx)
	{
	}

	[Token(Token = "0x60001D1")]
	[Address(RVA = "0x995590", Offset = "0x995590", VA = "0x995590")]
	public void SetupHeight(float height)
	{
	}

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0x99577C", Offset = "0x99577C", VA = "0x99577C", Slot = "9")]
	public override void OnSelect(int idx)
	{
	}

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0x995794", Offset = "0x995794", VA = "0x995794")]
	public void OnChangeUnit()
	{
	}

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0x99579C", Offset = "0x99579C", VA = "0x99579C", Slot = "6")]
	public override void OnHideItems()
	{
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0x995888", Offset = "0x995888", VA = "0x995888", Slot = "5")]
	public override void OnShowItems()
	{
	}

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0x995908", Offset = "0x995908", VA = "0x995908")]
	public HeightSetup()
	{
	}
}
[Token(Token = "0x2000036")]
public class HitEffector : MonoBehaviour
{
	[Token(Token = "0x40002AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform spine1Effector;

	[Token(Token = "0x40002AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform spine2Effector;

	[Token(Token = "0x40002B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform spine3Effector;

	[Token(Token = "0x40002B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform headEffector;

	[Token(Token = "0x40002B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform downMarker;

	[Token(Token = "0x40002B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Transform headMarker;

	[Token(Token = "0x40002B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Transform leftMarker;

	[Token(Token = "0x40002B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Transform rightMarker;

	[Token(Token = "0x40002B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Vector3[] rotations;

	[Token(Token = "0x40002B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Vector3[] rotationsToPlayer;

	[Token(Token = "0x40002B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Vector3[] destRotations;

	[Token(Token = "0x40002B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float hitPower;

	[Token(Token = "0x40002BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public float powerAmply;

	[Token(Token = "0x40002BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Game game;

	[Token(Token = "0x40002BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Enemy enemy;

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0x995918", Offset = "0x995918", VA = "0x995918")]
	private void Start()
	{
	}

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0x995990", Offset = "0x995990", VA = "0x995990")]
	private void Update()
	{
	}

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0x995E58", Offset = "0x995E58", VA = "0x995E58")]
	private void UpdateRotationToPlayer()
	{
	}

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0x996304", Offset = "0x996304", VA = "0x996304")]
	public void OnHit(Vector3 pos, Vector3 dir, float power, bool right_hand, Game.HitTarget target)
	{
	}

	[Token(Token = "0x60001DB")]
	[Address(RVA = "0x996834", Offset = "0x996834", VA = "0x996834")]
	public HitEffector()
	{
	}
}
[Token(Token = "0x2000037")]
public class HitFxController : MonoBehaviour
{
	[Token(Token = "0x40002BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject impactMedFx;

	[Token(Token = "0x40002BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject impactBigFx;

	[Token(Token = "0x40002BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject varietySmalFx;

	[Token(Token = "0x40002C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject varietyMedFx;

	[Token(Token = "0x40002C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject varietyMaxFx;

	[Token(Token = "0x40002C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject perfectFx;

	[Token(Token = "0x40002C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Light light;

	[Token(Token = "0x40002C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float animProgress;

	[Token(Token = "0x40002C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private float timeToDelete;

	[Token(Token = "0x60001DC")]
	[Address(RVA = "0x9968DC", Offset = "0x9968DC", VA = "0x9968DC")]
	public void Play(Vector3 fx_pos, int speed, int timing, int variety)
	{
	}

	[Token(Token = "0x60001DD")]
	[Address(RVA = "0x996C30", Offset = "0x996C30", VA = "0x996C30")]
	private void Update()
	{
	}

	[Token(Token = "0x60001DE")]
	[Address(RVA = "0x996D7C", Offset = "0x996D7C", VA = "0x996D7C")]
	public HitFxController()
	{
	}
}
[Token(Token = "0x2000038")]
public interface IEnemy
{
	[Token(Token = "0x60001DF")]
	void Despawn();

	[Token(Token = "0x60001E0")]
	void Disapear();

	[Token(Token = "0x60001E1")]
	void Activate();

	[Token(Token = "0x60001E2")]
	void Deactivate();

	[Token(Token = "0x60001E3")]
	Enemy GetEnemy();

	[Token(Token = "0x60001E4")]
	bool IsComboSucess();

	[Token(Token = "0x60001E5")]
	void StartCombo(float period);

	[Token(Token = "0x60001E6")]
	bool IsDuringAttack();

	[Token(Token = "0x60001E7")]
	bool IsLeftHandAttack();

	[Token(Token = "0x60001E8")]
	bool IsRightHandAttack();

	[Token(Token = "0x60001E9")]
	bool IsRightLegAttack();

	[Token(Token = "0x60001EA")]
	bool IsLeftLegAttack();

	[Token(Token = "0x60001EB")]
	void OnBlock();

	[Token(Token = "0x60001EC")]
	void OnPlayerDamage();

	[Token(Token = "0x60001ED")]
	void OnBodyPenetraaion(Vector3 avatar_pos);

	[Token(Token = "0x60001EE")]
	void OnEndAttackAfterHit();

	[Token(Token = "0x60001EF")]
	void OnHit(Vector3 pos, Vector3 dir, int damage, XRHandController hand, Game.HitTarget target, Collider collider, ref int body_part_bonus);

	[Token(Token = "0x60001F0")]
	void PlayEmot();

	[Token(Token = "0x60001F1")]
	void PrepareAttack(float time_attack, float max_move_length, Game.EEventType type);

	[Token(Token = "0x60001F2")]
	void Strafe(bool left, float max_move_length);
}
[Token(Token = "0x2000039")]
public class Interactable : MonoBehaviour
{
	[Token(Token = "0x40002C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public XRHandController handOpertating;

	[Token(Token = "0x40002C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Mesh illuminableMesh;

	[Token(Token = "0x40002C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool dragable;

	[Token(Token = "0x40002C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	public bool usable;

	[Token(Token = "0x60001F3")]
	[Address(RVA = "0x996D8C", Offset = "0x996D8C", VA = "0x996D8C", Slot = "4")]
	public virtual void OnStartDragging(XRHandController hand)
	{
	}

	[Token(Token = "0x60001F4")]
	[Address(RVA = "0x996DA0", Offset = "0x996DA0", VA = "0x996DA0", Slot = "5")]
	public virtual void OnFinishDragging(XRHandController hand)
	{
	}

	[Token(Token = "0x60001F5")]
	[Address(RVA = "0x996E2C", Offset = "0x996E2C", VA = "0x996E2C", Slot = "6")]
	public virtual void OnStartUsing(XRHandController hand)
	{
	}

	[Token(Token = "0x60001F6")]
	[Address(RVA = "0x996E40", Offset = "0x996E40", VA = "0x996E40", Slot = "7")]
	public virtual void OnFinishUsing(XRHandController hand)
	{
	}

	[Token(Token = "0x60001F7")]
	[Address(RVA = "0x99550C", Offset = "0x99550C", VA = "0x99550C")]
	public Interactable()
	{
	}
}
[Token(Token = "0x200003A")]
public class Item : MonoBehaviour
{
	[Token(Token = "0x60001F8")]
	[Address(RVA = "0x996ECC", Offset = "0x996ECC", VA = "0x996ECC")]
	public Item()
	{
	}
}
[Token(Token = "0x200003B")]
public class LanguageSetup : ItemsList
{
	[Token(Token = "0x40002CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Sprite[] sprites;

	[Token(Token = "0x60001F9")]
	[Address(RVA = "0x996ED4", Offset = "0x996ED4", VA = "0x996ED4", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60001FA")]
	[Address(RVA = "0x996F54", Offset = "0x996F54", VA = "0x996F54", Slot = "8")]
	public override void FillData(UIItem item, int idx)
	{
	}

	[Token(Token = "0x60001FB")]
	[Address(RVA = "0x996F4C", Offset = "0x996F4C", VA = "0x996F4C")]
	public void SetupLanguage(int lang)
	{
	}

	[Token(Token = "0x60001FC")]
	[Address(RVA = "0x996FAC", Offset = "0x996FAC", VA = "0x996FAC", Slot = "9")]
	public override void OnSelect(int idx)
	{
	}

	[Token(Token = "0x60001FD")]
	[Address(RVA = "0x99701C", Offset = "0x99701C", VA = "0x99701C")]
	public LanguageSetup()
	{
	}
}
[Token(Token = "0x200003C")]
public class LastGameStatistics : MonoBehaviour
{
	[Token(Token = "0x200003D")]
	public class EnemyAttackEvent
	{
		[Token(Token = "0x200003E")]
		public enum Type
		{
			[Token(Token = "0x40002DD")]
			Hit,
			[Token(Token = "0x40002DE")]
			Block,
			[Token(Token = "0x40002DF")]
			Dodge
		}

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Type type;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float time;

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x9978AC", Offset = "0x9978AC", VA = "0x9978AC")]
		public EnemyAttackEvent()
		{
		}
	}

	[Token(Token = "0x40002CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float TIMELINE_SPEED;

	[Token(Token = "0x40002CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float CHART_RANGE;

	[Token(Token = "0x40002CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float CHART_PAUSE;

	[Token(Token = "0x40002CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float CHART_METERS_PER_SEC;

	[Token(Token = "0x40002CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float PAUSE_TIME;

	[Token(Token = "0x40002D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float pause;

	[Token(Token = "0x40002D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static List<EnemyAttackEvent> enemyAttackEvents;

	[Token(Token = "0x40002D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static List<float> bpmMarkers;

	[Token(Token = "0x40002D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ParticleSystem bpmPS;

	[Token(Token = "0x40002D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ParticleSystem enemyAttacksPS;

	[Token(Token = "0x40002D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float currentTime;

	[Token(Token = "0x40002D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float progress;

	[Token(Token = "0x40002D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float maxChartTime;

	[Token(Token = "0x40002D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private int bpmIDX;

	[Token(Token = "0x40002D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private int enemyAttackIDX;

	[Token(Token = "0x60001FE")]
	[Address(RVA = "0x997024", Offset = "0x997024", VA = "0x997024")]
	private void Start()
	{
	}

	[Token(Token = "0x60001FF")]
	[Address(RVA = "0x9973AC", Offset = "0x9973AC", VA = "0x9973AC")]
	private void RestartDrawing()
	{
	}

	[Token(Token = "0x6000200")]
	[Address(RVA = "0x9973C0", Offset = "0x9973C0", VA = "0x9973C0")]
	private void UpdateTimeAndPos()
	{
	}

	[Token(Token = "0x6000201")]
	[Address(RVA = "0x99755C", Offset = "0x99755C", VA = "0x99755C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000202")]
	[Address(RVA = "0x9977F4", Offset = "0x9977F4", VA = "0x9977F4")]
	public static void ClearData()
	{
	}

	[Token(Token = "0x6000203")]
	[Address(RVA = "0x99719C", Offset = "0x99719C", VA = "0x99719C")]
	private void FillFakeData()
	{
	}

	[Token(Token = "0x6000204")]
	[Address(RVA = "0x9978B4", Offset = "0x9978B4", VA = "0x9978B4")]
	public LastGameStatistics()
	{
	}
}
[Token(Token = "0x200003F")]
public class ListCylinder : MonoBehaviour
{
	[Token(Token = "0x40002E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Vector3 entryPos;

	[Token(Token = "0x40002E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ItemsList parentList;

	[Token(Token = "0x40002E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform rotatorTransform;

	[Token(Token = "0x40002E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool inUse;

	[Token(Token = "0x40002E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	private bool canOnTouch;

	[Token(Token = "0x6000207")]
	[Address(RVA = "0x9979C0", Offset = "0x9979C0", VA = "0x9979C0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000208")]
	[Address(RVA = "0x997A1C", Offset = "0x997A1C", VA = "0x997A1C")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6000209")]
	[Address(RVA = "0x997B28", Offset = "0x997B28", VA = "0x997B28")]
	private void Update()
	{
	}

	[Token(Token = "0x600020A")]
	[Address(RVA = "0x997B34", Offset = "0x997B34", VA = "0x997B34")]
	private void OnTriggerStay(Collider other)
	{
	}

	[Token(Token = "0x600020B")]
	[Address(RVA = "0x997E8C", Offset = "0x997E8C", VA = "0x997E8C")]
	public ListCylinder()
	{
	}
}
[Token(Token = "0x2000040")]
public class LiveTutorial : MonoBehaviour
{
	[Token(Token = "0x2000041")]
	public enum TutorialStage
	{
		[Token(Token = "0x4000302")]
		Welcome,
		[Token(Token = "0x4000303")]
		OpponentPresentation,
		[Token(Token = "0x4000304")]
		ScoreIndicator,
		[Token(Token = "0x4000305")]
		PunchingSpeed,
		[Token(Token = "0x4000306")]
		AlternatingHands,
		[Token(Token = "0x4000307")]
		TargetingDifferentParts,
		[Token(Token = "0x4000308")]
		RhythmStriking,
		[Token(Token = "0x4000309")]
		Blocking,
		[Token(Token = "0x400030A")]
		BuildingCombo,
		[Token(Token = "0x400030B")]
		PerformingCombo,
		[Token(Token = "0x400030C")]
		ComboMultiplier,
		[Token(Token = "0x400030D")]
		FinishingMove,
		[Token(Token = "0x400030E")]
		Summary
	}

	[Token(Token = "0x2000042")]
	public enum StagePhase
	{
		[Token(Token = "0x4000310")]
		Presentation,
		[Token(Token = "0x4000311")]
		Task
	}

	[Token(Token = "0x2000043")]
	public delegate void StageSetup();

	[Token(Token = "0x2000044")]
	public delegate bool TaskCompletionCheck();

	[Token(Token = "0x2000045")]
	public struct StageData
	{
		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Dictionary<StagePhase, string> dataIDs;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public TaskCompletionCheck taskCheck;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public StageSetup setupMethod;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public StageSetup setupTaskMethod;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool showProgress;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool useSideConfiguration;

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x999DC8", Offset = "0x999DC8", VA = "0x999DC8")]
		public StageData(Dictionary<StagePhase, string> dataIDs, StageSetup setupMethod, StageSetup setupTaskMethod, TaskCompletionCheck taskCheck, bool showProgress, bool useSideConfiguration)
		{
		}
	}

	[Token(Token = "0x2000046")]
	private sealed class <DespawnEnemy>d__43 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LiveTutorial <>4__this;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <timeToDespawn>5__2;

		[Token(Token = "0x17000022")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000242")]
			[Address(RVA = "0x99AC40", Offset = "0x99AC40", VA = "0x99AC40", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000023")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000244")]
			[Address(RVA = "0x99AC88", Offset = "0x99AC88", VA = "0x99AC88", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x9989D8", Offset = "0x9989D8", VA = "0x9989D8")]
		[DebuggerHidden]
		public <DespawnEnemy>d__43(int <>1__state)
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x99AB9C", Offset = "0x99AB9C", VA = "0x99AB9C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x99ABA0", Offset = "0x99ABA0", VA = "0x99ABA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x99AC48", Offset = "0x99AC48", VA = "0x99AC48", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000047")]
	private sealed class <SetBodyPartsSkinAfter4Sec>d__45 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LiveTutorial <>4__this;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <time_to_change>5__2;

		[Token(Token = "0x17000024")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000248")]
			[Address(RVA = "0x99AD38", Offset = "0x99AD38", VA = "0x99AD38", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000025")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600024A")]
			[Address(RVA = "0x99AD80", Offset = "0x99AD80", VA = "0x99AD80", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x998A04", Offset = "0x998A04", VA = "0x998A04")]
		[DebuggerHidden]
		public <SetBodyPartsSkinAfter4Sec>d__45(int <>1__state)
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x99AC90", Offset = "0x99AC90", VA = "0x99AC90", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x99AC94", Offset = "0x99AC94", VA = "0x99AC94", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x99AD40", Offset = "0x99AD40", VA = "0x99AD40", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000048")]
	private sealed class <ExecuteStage>d__60 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LiveTutorial <>4__this;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TutorialStage stage;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public StagePhase phase;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private StageData <currentData>5__2;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float <pause_time>5__3;

		[Token(Token = "0x17000026")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600024E")]
			[Address(RVA = "0x99B1C8", Offset = "0x99B1C8", VA = "0x99B1C8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000027")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000250")]
			[Address(RVA = "0x99B210", Offset = "0x99B210", VA = "0x99B210", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x999F98", Offset = "0x999F98", VA = "0x999F98")]
		[DebuggerHidden]
		public <ExecuteStage>d__60(int <>1__state)
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x99AD88", Offset = "0x99AD88", VA = "0x99AD88", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x99AD8C", Offset = "0x99AD8C", VA = "0x99AD8C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x99B1D0", Offset = "0x99B1D0", VA = "0x99B1D0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000049")]
	private sealed class <FadeOutAndChangeMusic>d__72 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LiveTutorial <>4__this;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string title;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <startVolume>5__2;

		[Token(Token = "0x17000028")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000254")]
			[Address(RVA = "0x99B438", Offset = "0x99B438", VA = "0x99B438", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000029")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000256")]
			[Address(RVA = "0x99B480", Offset = "0x99B480", VA = "0x99B480", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x99A674", Offset = "0x99A674", VA = "0x99A674")]
		[DebuggerHidden]
		public <FadeOutAndChangeMusic>d__72(int <>1__state)
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x99B218", Offset = "0x99B218", VA = "0x99B218", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x99B21C", Offset = "0x99B21C", VA = "0x99B21C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x99B440", Offset = "0x99B440", VA = "0x99B440", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40002E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public HUD hud;

	[Token(Token = "0x40002E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject progressBar;

	[Token(Token = "0x40002E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Game game;

	[Token(Token = "0x40002E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Enemy enemy;

	[Token(Token = "0x40002E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private AudioSource audioSrc;

	[Token(Token = "0x40002EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Text prompt;

	[Token(Token = "0x40002EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public VideoPlayer videoPlayer;

	[Token(Token = "0x40002EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Material progressMat;

	[Token(Token = "0x40002ED")]
	private const float MAX_TASK_TIME = 12f;

	[Token(Token = "0x40002EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float taskTime;

	[Token(Token = "0x40002EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private int oppPresProgress;

	[Token(Token = "0x40002F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private int alternatingHandsProgress;

	[Token(Token = "0x40002F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private int targetingDifferentPartsProgress;

	[Token(Token = "0x40002F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int rhythmStrikingProgress;

	[Token(Token = "0x40002F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private int blockProgress;

	[Token(Token = "0x40002F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float comboFinished;

	[Token(Token = "0x40002F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private float minPlayTime;

	[Token(Token = "0x40002F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private string lang;

	[Token(Token = "0x40002F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private TutorialStage currentStage;

	[Token(Token = "0x40002F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private StagePhase currentPhase;

	[Token(Token = "0x40002F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Dictionary<TutorialStage, StageData> tutorialData;

	[Token(Token = "0x40002FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public GameObject videoBaseTransform;

	[Token(Token = "0x40002FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public GameObject videoSideTransform;

	[Token(Token = "0x40002FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private bool useSideConfiguration;

	[Token(Token = "0x40002FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private float switchTime;

	[Token(Token = "0x40002FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public GameObject enemyBaseTransform;

	[Token(Token = "0x40002FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public GameObject enemySideTransform;

	[Token(Token = "0x4000300")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private float fadeOutTime;

	[Token(Token = "0x600020C")]
	[Address(RVA = "0x997E9C", Offset = "0x997E9C", VA = "0x997E9C")]
	private void SetProgressMat(float progress)
	{
	}

	[Token(Token = "0x600020D")]
	[Address(RVA = "0x997FA8", Offset = "0x997FA8", VA = "0x997FA8")]
	public void OnHit(float speed, int hit_level, int hand_variety, int body_variety)
	{
	}

	[Token(Token = "0x600020E")]
	[Address(RVA = "0x998238", Offset = "0x998238", VA = "0x998238")]
	private void OpponentPresentationSetup()
	{
	}

	[Token(Token = "0x600020F")]
	[Address(RVA = "0x998440", Offset = "0x998440", VA = "0x998440")]
	private bool OpponentPresentationTaskCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x6000210")]
	[Address(RVA = "0x998470", Offset = "0x998470", VA = "0x998470")]
	private void PunchingSpeedTaskSetup()
	{
	}

	[Token(Token = "0x6000211")]
	[Address(RVA = "0x9984A8", Offset = "0x9984A8", VA = "0x9984A8")]
	private bool PunchingSpeedTaskCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x6000212")]
	[Address(RVA = "0x9984F0", Offset = "0x9984F0", VA = "0x9984F0")]
	private void AlternatingHandsTaskSetup()
	{
	}

	[Token(Token = "0x6000213")]
	[Address(RVA = "0x99855C", Offset = "0x99855C", VA = "0x99855C")]
	private bool AlternatingHandsTaskCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x6000214")]
	[Address(RVA = "0x99858C", Offset = "0x99858C", VA = "0x99858C")]
	private void TargetingDifferentPartsSetup()
	{
	}

	[Token(Token = "0x6000215")]
	[Address(RVA = "0x99868C", Offset = "0x99868C", VA = "0x99868C")]
	private bool TargetingDifferentPartsTaskCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x6000216")]
	[Address(RVA = "0x9986BC", Offset = "0x9986BC", VA = "0x9986BC")]
	private void RhythmStrikingTaskSetup()
	{
	}

	[Token(Token = "0x6000217")]
	[Address(RVA = "0x9986CC", Offset = "0x9986CC", VA = "0x9986CC")]
	private bool RhythmStrikingTaskCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x6000218")]
	[Address(RVA = "0x9986FC", Offset = "0x9986FC", VA = "0x9986FC")]
	private void BlockingTaskSetup()
	{
	}

	[Token(Token = "0x6000219")]
	[Address(RVA = "0x99872C", Offset = "0x99872C", VA = "0x99872C")]
	public void OnBlockDodge()
	{
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0x99873C", Offset = "0x99873C", VA = "0x99873C")]
	private bool BlockingTaskCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x600021B")]
	[Address(RVA = "0x99876C", Offset = "0x99876C", VA = "0x99876C")]
	private void BuildingComboSetup()
	{
	}

	[Token(Token = "0x600021C")]
	[Address(RVA = "0x9987A4", Offset = "0x9987A4", VA = "0x9987A4")]
	private bool BuildingComboCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0x9987D0", Offset = "0x9987D0", VA = "0x9987D0")]
	private void PerformingComboTaskSetup()
	{
	}

	[Token(Token = "0x600021E")]
	[Address(RVA = "0x9987FC", Offset = "0x9987FC", VA = "0x9987FC")]
	public void OnComboFinished()
	{
	}

	[Token(Token = "0x600021F")]
	[Address(RVA = "0x998808", Offset = "0x998808", VA = "0x998808")]
	private bool PerformingComboCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x6000220")]
	[Address(RVA = "0x99883C", Offset = "0x99883C", VA = "0x99883C")]
	private void ComboMultiplierSetup()
	{
	}

	[Token(Token = "0x6000221")]
	[Address(RVA = "0x99885C", Offset = "0x99885C", VA = "0x99885C")]
	private void ComboMultiplierTaskSetup()
	{
	}

	[Token(Token = "0x6000222")]
	[Address(RVA = "0x998890", Offset = "0x998890", VA = "0x998890")]
	private bool ComboMultiplierCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x6000223")]
	[Address(RVA = "0x9988C4", Offset = "0x9988C4", VA = "0x9988C4")]
	private void FinishingMoveSetup()
	{
	}

	[Token(Token = "0x6000224")]
	[Address(RVA = "0x9988E4", Offset = "0x9988E4", VA = "0x9988E4")]
	private void FinishingMoveTaskSetup()
	{
	}

	[Token(Token = "0x6000225")]
	[Address(RVA = "0x998978", Offset = "0x998978", VA = "0x998978")]
	private bool FinishingMoveTaskCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x6000226")]
	[Address(RVA = "0x998904", Offset = "0x998904", VA = "0x998904")]
	private IEnumerator DespawnEnemy()
	{
		return null;
	}

	[Token(Token = "0x6000227")]
	[Address(RVA = "0x998A00", Offset = "0x998A00", VA = "0x998A00")]
	private void WelcomeSetup()
	{
	}

	[Token(Token = "0x6000228")]
	[Address(RVA = "0x9983CC", Offset = "0x9983CC", VA = "0x9983CC")]
	private IEnumerator SetBodyPartsSkinAfter4Sec()
	{
		return null;
	}

	[Token(Token = "0x6000229")]
	[Address(RVA = "0x998A2C", Offset = "0x998A2C", VA = "0x998A2C")]
	private void PlayAudio(string audioFilePath)
	{
	}

	[Token(Token = "0x600022A")]
	[Address(RVA = "0x998B3C", Offset = "0x998B3C", VA = "0x998B3C")]
	private bool IsAudioPlaying()
	{
		return default(bool);
	}

	[Token(Token = "0x600022B")]
	[Address(RVA = "0x998B90", Offset = "0x998B90", VA = "0x998B90")]
	private void DisplayText(string textID)
	{
	}

	[Token(Token = "0x600022C")]
	[Address(RVA = "0x998C18", Offset = "0x998C18", VA = "0x998C18")]
	private void PlayVideo(string videoFilePath)
	{
	}

	[Token(Token = "0x600022D")]
	[Address(RVA = "0x998CFC", Offset = "0x998CFC", VA = "0x998CFC")]
	private void Start()
	{
	}

	[Token(Token = "0x600022E")]
	[Address(RVA = "0x999F10", Offset = "0x999F10", VA = "0x999F10")]
	private IEnumerator ExecuteStage(TutorialStage stage, StagePhase phase)
	{
		return null;
	}

	[Token(Token = "0x600022F")]
	[Address(RVA = "0x999FC0", Offset = "0x999FC0", VA = "0x999FC0")]
	private TutorialStage NextStage(TutorialStage current)
	{
		return default(TutorialStage);
	}

	[Token(Token = "0x6000230")]
	[Address(RVA = "0x999FC8", Offset = "0x999FC8", VA = "0x999FC8")]
	private void ShowHands()
	{
	}

	[Token(Token = "0x6000231")]
	[Address(RVA = "0x99A0EC", Offset = "0x99A0EC", VA = "0x99A0EC")]
	private void HideHands()
	{
	}

	[Token(Token = "0x6000232")]
	[Address(RVA = "0x99A210", Offset = "0x99A210", VA = "0x99A210")]
	private void Update()
	{
	}

	[Token(Token = "0x6000233")]
	[Address(RVA = "0x9985FC", Offset = "0x9985FC", VA = "0x9985FC")]
	private IEnumerator FadeOutAndChangeMusic(string title)
	{
		return null;
	}

	[Token(Token = "0x6000234")]
	[Address(RVA = "0x99A69C", Offset = "0x99A69C", VA = "0x99A69C")]
	private void PlayFX(string fx_name, Vector3 fx_pos)
	{
	}

	[Token(Token = "0x6000235")]
	[Address(RVA = "0x9980C4", Offset = "0x9980C4", VA = "0x9980C4")]
	private void PlayQualityFX(int hit_quality)
	{
	}

	[Token(Token = "0x6000236")]
	[Address(RVA = "0x99A7FC", Offset = "0x99A7FC", VA = "0x99A7FC")]
	private void LoadFirstScene()
	{
	}

	[Token(Token = "0x6000237")]
	[Address(RVA = "0x99AA40", Offset = "0x99AA40", VA = "0x99AA40")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000238")]
	[Address(RVA = "0x999B8C", Offset = "0x999B8C", VA = "0x999B8C")]
	private void SetupLanguage()
	{
	}

	[Token(Token = "0x6000239")]
	[Address(RVA = "0x99AB00", Offset = "0x99AB00", VA = "0x99AB00")]
	public LiveTutorial()
	{
	}
}
[Token(Token = "0x200004A")]
public class MainMenu : MonoBehaviour
{
	[Token(Token = "0x200004B")]
	public enum TypeOfTracks
	{
		[Token(Token = "0x4000369")]
		Unknow,
		[Token(Token = "0x400036A")]
		Official,
		[Token(Token = "0x400036B")]
		Custom,
		[Token(Token = "0x400036C")]
		MP3
	}

	[Token(Token = "0x200004C")]
	private class LocalTrackInfo
	{
		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string id;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string title;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int noSlots;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<List<string>> enemies;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string notes;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int bpm;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int length;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int rate;

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x9A2398", Offset = "0x9A2398", VA = "0x9A2398")]
		public LocalTrackInfo()
		{
		}
	}

	[Token(Token = "0x200004D")]
	private class CachedSprite
	{
		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string path;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Sprite sprite;

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x9A3974", Offset = "0x9A3974", VA = "0x9A3974")]
		public CachedSprite()
		{
		}
	}

	[Token(Token = "0x200004E")]
	public class ProgramTrack
	{
		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string id;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TypeOfTracks track_type;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int official_enemy_slot;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<string> enemies;

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x9A47C0", Offset = "0x9A47C0", VA = "0x9A47C0")]
		public ProgramTrack()
		{
		}
	}

	[Token(Token = "0x200004F")]
	public class Program
	{
		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string title;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string id;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<ProgramTrack> tracks;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int length;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int bpm_min;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int bpm_max;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int rate;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool random_program;

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x9A4738", Offset = "0x9A4738", VA = "0x9A4738")]
		public Program()
		{
		}
	}

	[Token(Token = "0x2000050")]
	private sealed class <LoadLocalClipPrev>d__91 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MainMenu <>4__this;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string <path>5__2;

		[Token(Token = "0x1700002A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002A3")]
			[Address(RVA = "0x9A5C30", Offset = "0x9A5C30", VA = "0x9A5C30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002A5")]
			[Address(RVA = "0x9A5C78", Offset = "0x9A5C78", VA = "0x9A5C78", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x9A40AC", Offset = "0x9A40AC", VA = "0x9A40AC")]
		[DebuggerHidden]
		public <LoadLocalClipPrev>d__91(int <>1__state)
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x9A5A98", Offset = "0x9A5A98", VA = "0x9A5A98", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x9A5A9C", Offset = "0x9A5A9C", VA = "0x9A5A9C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x9A5C38", Offset = "0x9A5C38", VA = "0x9A5C38", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000051")]
	private sealed class <WaitForWebRequest>d__92 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MainMenu <>4__this;

		[Token(Token = "0x1700002C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002A9")]
			[Address(RVA = "0x9A5D48", Offset = "0x9A5D48", VA = "0x9A5D48", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002AB")]
			[Address(RVA = "0x9A5D90", Offset = "0x9A5D90", VA = "0x9A5D90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x9A4148", Offset = "0x9A4148", VA = "0x9A4148")]
		[DebuggerHidden]
		public <WaitForWebRequest>d__92(int <>1__state)
		{
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x9A5C80", Offset = "0x9A5C80", VA = "0x9A5C80", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x9A5C84", Offset = "0x9A5C84", VA = "0x9A5C84", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x9A5D50", Offset = "0x9A5D50", VA = "0x9A5D50", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400032C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private string CALCULATE_STATS_TRACK;

	[Token(Token = "0x400032D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool HUB;

	[Token(Token = "0x400032E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static MainMenu instance;

	[Token(Token = "0x400032F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float timeToRefreshAvatars;

	[Token(Token = "0x4000330")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string selTrackID;

	[Token(Token = "0x4000331")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string selProgramID;

	[Token(Token = "0x4000332")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public TextAsset tracksFile;

	[Token(Token = "0x4000333")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public TrackList trackList;

	[Token(Token = "0x4000334")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Compositor compositor;

	[Token(Token = "0x4000335")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public TrackList programItems;

	[Token(Token = "0x4000336")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public TrackList playLists;

	[Token(Token = "0x4000337")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private TypeOfTracks typeOfTracks;

	[Token(Token = "0x4000338")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Button3D playButton;

	[Token(Token = "0x4000339")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Button3D addToPLButton;

	[Token(Token = "0x400033A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Button3D officialTOTButton;

	[Token(Token = "0x400033B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Button3D customTOTButton;

	[Token(Token = "0x400033C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Button3D mp3TOTButton;

	[Token(Token = "0x400033D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Button3D autostartButton;

	[Token(Token = "0x400033E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Button3D opt1ChaButton;

	[Token(Token = "0x400033F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Button3D opt2ChaButton;

	[Token(Token = "0x4000340")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Button3D opt3ChaButton;

	[Token(Token = "0x4000341")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Image[] pot1ChaIcons;

	[Token(Token = "0x4000342")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Image[] pot2ChaIcons;

	[Token(Token = "0x4000343")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Image[] pot3ChaIcons;

	[Token(Token = "0x4000344")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public Button3D[] customEnemySlot;

	[Token(Token = "0x4000345")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public Image[] customEnemyIcons;

	[Token(Token = "0x4000346")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public Button3D[] enemySelecetion;

	[Token(Token = "0x4000347")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public GameObject enemySelector;

	[Token(Token = "0x4000348")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public GameObject customMP3;

	[Token(Token = "0x4000349")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public Button3D[] customMP3Intensity;

	[Token(Token = "0x400034A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public Button3D[] customMP3CharacterChanges;

	[Token(Token = "0x400034B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public Button3D[] arrenaButtons;

	[Token(Token = "0x400034C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public Transform[] avatarTransforms;

	[Token(Token = "0x400034D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private List<GameObject> avatars;

	[Token(Token = "0x400034E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private int charatersOption;

	[Token(Token = "0x400034F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private StatsSummary statsSummary;

	[Token(Token = "0x4000350")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private GameLeaderboard leaderboard;

	[Token(Token = "0x4000351")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public GameObject mp3HowTo;

	[Token(Token = "0x4000352")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	public Text mp3Path;

	[Token(Token = "0x4000353")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	public bool makeMP3Test;

	[Token(Token = "0x4000354")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
	private int first_request_delay;

	[Token(Token = "0x4000355")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private List<LocalTrackInfo> localInfos;

	[Token(Token = "0x4000356")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	public Text SFXVolText;

	[Token(Token = "0x4000357")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	public Text SFXTypeText;

	[Token(Token = "0x4000358")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private int selectedSlotToSet;

	[Token(Token = "0x4000359")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
	private float slotsAnimProgress;

	[Token(Token = "0x400035A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private List<CachedSprite> cachedSprites;

	[Token(Token = "0x400035B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private UnityWebRequest webRequest;

	[Token(Token = "0x400035C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private AsyncOperation operation;

	[Token(Token = "0x400035D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private AudioSource musicSource;

	[Token(Token = "0x400035E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private float timeToRefreshPreview;

	[Token(Token = "0x400035F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private List<Program> programs;

	[Token(Token = "0x4000360")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	public TextAsset programsFile;

	[Token(Token = "0x4000361")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private int selectedProgramTrackIDX;

	[Token(Token = "0x4000362")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private string sceneToReload;

	[Token(Token = "0x4000363")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	private float timeToReload;

	[Token(Token = "0x4000364")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
	private float currHeight;

	[Token(Token = "0x4000365")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	private float mp3TestTimer;

	[Token(Token = "0x4000366")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
	private int mp3TestStep;

	[Token(Token = "0x4000367")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	public GameObject ToHideWhenHieghtSeupActive;

	[Token(Token = "0x6000257")]
	[Address(RVA = "0x99B488", Offset = "0x99B488", VA = "0x99B488")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000258")]
	[Address(RVA = "0x99B4E0", Offset = "0x99B4E0", VA = "0x99B4E0")]
	private void FirstInit()
	{
	}

	[Token(Token = "0x6000259")]
	[Address(RVA = "0x99B710", Offset = "0x99B710", VA = "0x99B710")]
	private void Start()
	{
	}

	[Token(Token = "0x600025A")]
	[Address(RVA = "0x99DBB8", Offset = "0x99DBB8", VA = "0x99DBB8")]
	private void UpdateAvatars()
	{
	}

	[Token(Token = "0x600025B")]
	[Address(RVA = "0x99E244", Offset = "0x99E244", VA = "0x99E244")]
	private void DelayedRequest()
	{
	}

	[Token(Token = "0x600025C")]
	[Address(RVA = "0x99E324", Offset = "0x99E324", VA = "0x99E324")]
	private void Update()
	{
	}

	[Token(Token = "0x600025D")]
	[Address(RVA = "0x99F27C", Offset = "0x99F27C", VA = "0x99F27C")]
	private void FillOfficialEnemyInfo(TrackList.TrackInfo info, ref string notes)
	{
	}

	[Token(Token = "0x600025E")]
	[Address(RVA = "0x99F3C8", Offset = "0x99F3C8", VA = "0x99F3C8")]
	private void FillCustomEnemyInfo(ref string notes)
	{
	}

	[Token(Token = "0x600025F")]
	[Address(RVA = "0x99F4DC", Offset = "0x99F4DC", VA = "0x99F4DC")]
	private void FillLocalMusicNotes(ref string notes)
	{
	}

	[Token(Token = "0x6000260")]
	[Address(RVA = "0x99F6A8", Offset = "0x99F6A8", VA = "0x99F6A8")]
	private bool FillMP3MusicNotes(ref string notes, string track_id)
	{
		return default(bool);
	}

	[Token(Token = "0x6000261")]
	[Address(RVA = "0x99F8A4", Offset = "0x99F8A4", VA = "0x99F8A4")]
	public void OnPlay()
	{
	}

	[Token(Token = "0x6000262")]
	[Address(RVA = "0x9A0044", Offset = "0x9A0044", VA = "0x9A0044")]
	private void FillOfficialEnemyIcons()
	{
	}

	[Token(Token = "0x6000263")]
	[Address(RVA = "0x9A08C4", Offset = "0x9A08C4", VA = "0x9A08C4")]
	public void OnSelectTrack(string track_id)
	{
	}

	[Token(Token = "0x6000264")]
	[Address(RVA = "0x99D4B0", Offset = "0x99D4B0", VA = "0x99D4B0")]
	public void OnSelectProgram(string program_id)
	{
	}

	[Token(Token = "0x6000265")]
	[Address(RVA = "0x9A1754", Offset = "0x9A1754", VA = "0x9A1754")]
	private void OnSelectIntensity(int data)
	{
	}

	[Token(Token = "0x6000266")]
	[Address(RVA = "0x9A1794", Offset = "0x9A1794", VA = "0x9A1794")]
	public void OnSelectArena(int arena_id)
	{
	}

	[Token(Token = "0x6000267")]
	[Address(RVA = "0x99DA0C", Offset = "0x99DA0C", VA = "0x99DA0C")]
	private void RefreshArenaButtons()
	{
	}

	[Token(Token = "0x6000268")]
	[Address(RVA = "0x9A180C", Offset = "0x9A180C", VA = "0x9A180C")]
	private void OnTimeBtwnSpawns(int data)
	{
	}

	[Token(Token = "0x6000269")]
	[Address(RVA = "0x9A195C", Offset = "0x9A195C", VA = "0x9A195C")]
	public void OnComposeTrack(string track_id, Vector3 pos, Quaternion rot)
	{
	}

	[Token(Token = "0x600026A")]
	[Address(RVA = "0x9A1C14", Offset = "0x9A1C14", VA = "0x9A1C14")]
	public void FillOfficialTracks()
	{
	}

	[Token(Token = "0x600026B")]
	[Address(RVA = "0x9A2178", Offset = "0x9A2178", VA = "0x9A2178")]
	public void FillCustomTracks()
	{
	}

	[Token(Token = "0x600026C")]
	[Address(RVA = "0x99F524", Offset = "0x99F524", VA = "0x99F524")]
	private LocalTrackInfo GetLocalInfoByID(string id)
	{
		return null;
	}

	[Token(Token = "0x600026D")]
	[Address(RVA = "0x99BAD0", Offset = "0x99BAD0", VA = "0x99BAD0")]
	private void ReadTracksInfos()
	{
	}

	[Token(Token = "0x600026E")]
	[Address(RVA = "0x99D598", Offset = "0x99D598", VA = "0x99D598")]
	private void SwitchTypeOfTracks(TypeOfTracks new_type)
	{
	}

	[Token(Token = "0x600026F")]
	[Address(RVA = "0x9A2DB4", Offset = "0x9A2DB4", VA = "0x9A2DB4")]
	private void OnChangeAutoStart()
	{
	}

	[Token(Token = "0x6000270")]
	[Address(RVA = "0x9A2E40", Offset = "0x9A2E40", VA = "0x9A2E40")]
	private void OnChangeSFXVol()
	{
	}

	[Token(Token = "0x6000271")]
	[Address(RVA = "0x9A2F08", Offset = "0x9A2F08", VA = "0x9A2F08")]
	private void OnChangeSFXType()
	{
	}

	[Token(Token = "0x6000272")]
	[Address(RVA = "0x99DABC", Offset = "0x99DABC", VA = "0x99DABC")]
	private void RefreshSetings()
	{
	}

	[Token(Token = "0x6000273")]
	[Address(RVA = "0x9A2428", Offset = "0x9A2428", VA = "0x9A2428")]
	private void SwitchCharactersOption(int option)
	{
	}

	[Token(Token = "0x6000274")]
	[Address(RVA = "0x9A2FC4", Offset = "0x9A2FC4", VA = "0x9A2FC4")]
	public void OnSelectEnemySlot(int slot)
	{
	}

	[Token(Token = "0x6000275")]
	[Address(RVA = "0x9A3238", Offset = "0x9A3238", VA = "0x9A3238")]
	public void OnSelectEnemy(int enemy_id)
	{
	}

	[Token(Token = "0x6000276")]
	[Address(RVA = "0x99D13C", Offset = "0x99D13C", VA = "0x99D13C")]
	private void ResetCustomSlotsButtons()
	{
	}

	[Token(Token = "0x6000277")]
	[Address(RVA = "0x99EB70", Offset = "0x99EB70", VA = "0x99EB70")]
	private void UpdateEnemySlotSelection()
	{
	}

	[Token(Token = "0x6000278")]
	[Address(RVA = "0x9A2594", Offset = "0x9A2594", VA = "0x9A2594")]
	private void RefershEnemySlotsIcons()
	{
	}

	[Token(Token = "0x6000279")]
	[Address(RVA = "0x9A32CC", Offset = "0x9A32CC", VA = "0x9A32CC")]
	public void OnButton(Button3D.Type button_type, int data)
	{
	}

	[Token(Token = "0x600027A")]
	[Address(RVA = "0x99E190", Offset = "0x99E190", VA = "0x99E190")]
	public string EnemyIDToName(int id)
	{
		return null;
	}

	[Token(Token = "0x600027B")]
	[Address(RVA = "0x9A05AC", Offset = "0x9A05AC", VA = "0x9A05AC")]
	public Sprite GetCachedSprite(string path)
	{
		return null;
	}

	[Token(Token = "0x600027C")]
	[Address(RVA = "0x9A272C", Offset = "0x9A272C", VA = "0x9A272C")]
	public void OpenDirectory(string path, int min_index, int max_index)
	{
	}

	[Token(Token = "0x600027D")]
	[Address(RVA = "0x9A3FC0", Offset = "0x9A3FC0", VA = "0x9A3FC0")]
	private bool IsSupportedFile(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x600027E")]
	[Address(RVA = "0x9A397C", Offset = "0x9A397C", VA = "0x9A397C")]
	private int FillFiles(string path, FileInfo[] fileinfo, int no_records)
	{
		return default(int);
	}

	[Token(Token = "0x600027F")]
	[Address(RVA = "0x9A3E08", Offset = "0x9A3E08", VA = "0x9A3E08")]
	private int FillGroupFiles(FileInfo[] fileinfo, int no_records, int min_index, int max_index)
	{
		return default(int);
	}

	[Token(Token = "0x6000280")]
	[Address(RVA = "0x9A4038", Offset = "0x9A4038", VA = "0x9A4038")]
	private IEnumerator LoadLocalClipPrev()
	{
		return null;
	}

	[Token(Token = "0x6000281")]
	[Address(RVA = "0x9A40D4", Offset = "0x9A40D4", VA = "0x9A40D4")]
	private IEnumerator WaitForWebRequest()
	{
		return null;
	}

	[Token(Token = "0x6000282")]
	[Address(RVA = "0x9A4170", Offset = "0x9A4170", VA = "0x9A4170")]
	public void StopPreview()
	{
	}

	[Token(Token = "0x6000283")]
	[Address(RVA = "0x9A41C8", Offset = "0x9A41C8", VA = "0x9A41C8")]
	public void PlayPreview()
	{
	}

	[Token(Token = "0x6000284")]
	[Address(RVA = "0x9A435C", Offset = "0x9A435C", VA = "0x9A435C")]
	public AudioSource GetMusicSource()
	{
		return null;
	}

	[Token(Token = "0x6000285")]
	[Address(RVA = "0x99EDAC", Offset = "0x99EDAC", VA = "0x99EDAC")]
	private void UpdatePreview()
	{
	}

	[Token(Token = "0x6000286")]
	[Address(RVA = "0x9A4364", Offset = "0x9A4364", VA = "0x9A4364")]
	private void ParseEnemiesSection(string section, ref ProgramTrack track)
	{
	}

	[Token(Token = "0x6000287")]
	[Address(RVA = "0x9A44D8", Offset = "0x9A44D8", VA = "0x9A44D8")]
	private void ParseStats(ref Program item, string config)
	{
	}

	[Token(Token = "0x6000288")]
	[Address(RVA = "0x99C844", Offset = "0x99C844", VA = "0x99C844")]
	private void ReadPrograms()
	{
	}

	[Token(Token = "0x6000289")]
	[Address(RVA = "0x9A4848", Offset = "0x9A4848", VA = "0x9A4848")]
	private Program GetProgramByID(string id)
	{
		return null;
	}

	[Token(Token = "0x600028A")]
	[Address(RVA = "0x99D29C", Offset = "0x99D29C", VA = "0x99D29C")]
	public void FillPlayLists()
	{
	}

	[Token(Token = "0x600028B")]
	[Address(RVA = "0x9A0F28", Offset = "0x9A0F28", VA = "0x9A0F28")]
	public void FillPlaylistTracks()
	{
	}

	[Token(Token = "0x600028C")]
	[Address(RVA = "0x9A3454", Offset = "0x9A3454", VA = "0x9A3454")]
	public void AddTrackToProgram()
	{
	}

	[Token(Token = "0x600028D")]
	[Address(RVA = "0x9A4A5C", Offset = "0x9A4A5C", VA = "0x9A4A5C")]
	private void WriteProgram()
	{
	}

	[Token(Token = "0x600028E")]
	[Address(RVA = "0x9A49CC", Offset = "0x9A49CC", VA = "0x9A49CC")]
	private void AfterProgramChanged()
	{
	}

	[Token(Token = "0x600028F")]
	[Address(RVA = "0x9A3730", Offset = "0x9A3730", VA = "0x9A3730")]
	private void OnChangeProgramTrack(int dir)
	{
	}

	[Token(Token = "0x6000290")]
	[Address(RVA = "0x9A5804", Offset = "0x9A5804", VA = "0x9A5804")]
	public void OnSelectProgramItem(int idx)
	{
	}

	[Token(Token = "0x6000291")]
	[Address(RVA = "0x99E5D0", Offset = "0x99E5D0", VA = "0x99E5D0")]
	private bool UpdateHUB()
	{
		return default(bool);
	}

	[Token(Token = "0x6000292")]
	[Address(RVA = "0x99FAE8", Offset = "0x99FAE8", VA = "0x99FAE8")]
	private string RandomScene()
	{
		return null;
	}

	[Token(Token = "0x6000293")]
	[Address(RVA = "0x9A38D0", Offset = "0x9A38D0", VA = "0x9A38D0")]
	private void OnStartPlaylist()
	{
	}

	[Token(Token = "0x6000294")]
	[Address(RVA = "0x9A5878", Offset = "0x9A5878", VA = "0x9A5878")]
	public float GetTimeToReload()
	{
		return default(float);
	}

	[Token(Token = "0x6000295")]
	[Address(RVA = "0x99FF80", Offset = "0x99FF80", VA = "0x99FF80")]
	public void ReloadScene(string scene_name, float time)
	{
	}

	[Token(Token = "0x6000296")]
	[Address(RVA = "0x99EAC8", Offset = "0x99EAC8", VA = "0x99EAC8")]
	private void UpdateReload()
	{
	}

	[Token(Token = "0x6000297")]
	[Address(RVA = "0x99EF9C", Offset = "0x99EF9C", VA = "0x99EF9C")]
	private void UpdateMenuHeight()
	{
	}

	[Token(Token = "0x6000298")]
	[Address(RVA = "0x99F0C4", Offset = "0x99F0C4", VA = "0x99F0C4")]
	private void UpdateMakeMP3Test()
	{
	}

	[Token(Token = "0x6000299")]
	[Address(RVA = "0x9958E8", Offset = "0x9958E8", VA = "0x9958E8")]
	public void OnShowHeightSetup()
	{
	}

	[Token(Token = "0x600029A")]
	[Address(RVA = "0x995868", Offset = "0x995868", VA = "0x995868")]
	public void OnHideHeightSetup()
	{
	}

	[Token(Token = "0x600029B")]
	[Address(RVA = "0x9A5880", Offset = "0x9A5880", VA = "0x9A5880")]
	public MainMenu()
	{
	}
}
[Token(Token = "0x2000052")]
public class MixedRealityCaptureController : MonoBehaviour
{
	[Token(Token = "0x2000053")]
	private enum CameraMode
	{
		[Token(Token = "0x4000392")]
		Normal
	}

	[Token(Token = "0x400038A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool inited;

	[Token(Token = "0x400038B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private CameraMode currentMode;

	[Token(Token = "0x400038C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Camera defaultExternalCamera;

	[Token(Token = "0x400038D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private OVRPlugin.Fovf defaultFov;

	[Token(Token = "0x400038E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector3 camePos;

	[Token(Token = "0x400038F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private Quaternion cameRot;

	[Token(Token = "0x4000390")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject testObj;

	[Token(Token = "0x60002AC")]
	[Address(RVA = "0x9A5D98", Offset = "0x9A5D98", VA = "0x9A5D98")]
	private void Start()
	{
	}

	[Token(Token = "0x60002AD")]
	[Address(RVA = "0x9A5E94", Offset = "0x9A5E94", VA = "0x9A5E94")]
	private void Initialize()
	{
	}

	[Token(Token = "0x60002AE")]
	[Address(RVA = "0x9A60D8", Offset = "0x9A60D8", VA = "0x9A60D8")]
	private void UpdateDefaultExternalCamera()
	{
	}

	[Token(Token = "0x60002AF")]
	[Address(RVA = "0x9A6484", Offset = "0x9A6484", VA = "0x9A6484")]
	private void Update()
	{
	}

	[Token(Token = "0x60002B0")]
	[Address(RVA = "0x9A6524", Offset = "0x9A6524", VA = "0x9A6524")]
	public MixedRealityCaptureController()
	{
	}
}
[Token(Token = "0x2000054")]
public class MRController : MonoBehaviour
{
	[Token(Token = "0x4000393")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool turnOnMR;

	[Token(Token = "0x4000394")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	private bool setupFinished;

	[Token(Token = "0x4000395")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private OVRPassthroughLayer pass_layer;

	[Token(Token = "0x60002B1")]
	[Address(RVA = "0x9A65BC", Offset = "0x9A65BC", VA = "0x9A65BC")]
	private void Update()
	{
	}

	[Token(Token = "0x60002B2")]
	[Address(RVA = "0x9A65CC", Offset = "0x9A65CC", VA = "0x9A65CC")]
	public void SetupMR()
	{
	}

	[Token(Token = "0x60002B3")]
	[Address(RVA = "0x9A6778", Offset = "0x9A6778", VA = "0x9A6778")]
	public MRController()
	{
	}
}
[Token(Token = "0x2000055")]
public class MultiTest : MonoBehaviour
{
	[Token(Token = "0x60002B4")]
	[Address(RVA = "0x9A6788", Offset = "0x9A6788", VA = "0x9A6788")]
	public MultiTest()
	{
	}
}
[Token(Token = "0x2000056")]
public class GameLeaderboard : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000057")]
	private sealed class <>c
	{
		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Pico.Platform.Message<Pico.Platform.PlatformInitializeResult>.Handler <>9__11_0;

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x9A96EC", Offset = "0x9A96EC", VA = "0x9A96EC")]
		public <>c()
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x9A96F4", Offset = "0x9A96F4", VA = "0x9A96F4")]
		internal void <PicoInit>b__11_0(Pico.Platform.Message<Pico.Platform.PlatformInitializeResult> m)
		{
		}
	}

	[Token(Token = "0x4000396")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text debugText;

	[Token(Token = "0x4000397")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Text titleText;

	[Token(Token = "0x4000398")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public UILBEntry[] entries;

	[Token(Token = "0x4000399")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Sprite[] otherBackgrounds;

	[Token(Token = "0x400039A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Sprite userSprite;

	[Token(Token = "0x400039B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private SortedDictionary<int, Pico.Platform.Models.LeaderboardEntry> m_PicoHighScores;

	[Token(Token = "0x400039C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private SortedDictionary<int, Oculus.Platform.Models.LeaderboardEntry> m_OculusHighScores;

	[Token(Token = "0x400039D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private string m_LB_ID;

	[Token(Token = "0x400039E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool m_FriendsMode;

	[Token(Token = "0x400039F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private int request_delay;

	[Token(Token = "0x40003A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private int first_request_delay;

	[Token(Token = "0x40003A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private bool visible;

	[Token(Token = "0x40003A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private float animProgress;

	[Token(Token = "0x40003A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private Vector3 basePos;

	[Token(Token = "0x40003A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Vector3 hidePos;

	[Token(Token = "0x60002B5")]
	[Address(RVA = "0x9A6790", Offset = "0x9A6790", VA = "0x9A6790")]
	public void OnFriends()
	{
	}

	[Token(Token = "0x60002B6")]
	[Address(RVA = "0x9A679C", Offset = "0x9A679C", VA = "0x9A679C")]
	public void OnOverall()
	{
	}

	[Token(Token = "0x60002B7")]
	[Address(RVA = "0x9A67A4", Offset = "0x9A67A4", VA = "0x9A67A4")]
	private void PicoInit()
	{
	}

	[Token(Token = "0x60002B8")]
	[Address(RVA = "0x9A68E0", Offset = "0x9A68E0", VA = "0x9A68E0")]
	private void Start()
	{
	}

	[Token(Token = "0x60002B9")]
	[Address(RVA = "0x9A69D4", Offset = "0x9A69D4", VA = "0x9A69D4")]
	private void Update()
	{
	}

	[Token(Token = "0x60002BA")]
	[Address(RVA = "0x9A0D78", Offset = "0x9A0D78", VA = "0x9A0D78")]
	public void FillEmpty()
	{
	}

	[Token(Token = "0x60002BB")]
	[Address(RVA = "0x9A6DA4", Offset = "0x9A6DA4", VA = "0x9A6DA4")]
	public void OnHighLeaderboardUpdated()
	{
	}

	[Token(Token = "0x60002BC")]
	[Address(RVA = "0x9A7324", Offset = "0x9A7324", VA = "0x9A7324")]
	public void OnNearLeaderboardUpdated()
	{
	}

	[Token(Token = "0x60002BD")]
	[Address(RVA = "0x9A6A20", Offset = "0x9A6A20", VA = "0x9A6A20")]
	private void QueryHighScoreLeaderboard()
	{
	}

	[Token(Token = "0x60002BE")]
	[Address(RVA = "0x9A7940", Offset = "0x9A7940", VA = "0x9A7940")]
	private void MostScoreGetEntriesCallback(Oculus.Platform.Message<Oculus.Platform.Models.LeaderboardEntryList> msg)
	{
	}

	[Token(Token = "0x60002BF")]
	[Address(RVA = "0x9A7CF4", Offset = "0x9A7CF4", VA = "0x9A7CF4")]
	private void MostScoreGetEntriesCallback(Pico.Platform.Message<Pico.Platform.Models.LeaderboardEntryList> msg)
	{
	}

	[Token(Token = "0x60002C0")]
	[Address(RVA = "0x9A7F5C", Offset = "0x9A7F5C", VA = "0x9A7F5C")]
	private void AroundGetEntriesCallback(Oculus.Platform.Message<Oculus.Platform.Models.LeaderboardEntryList> msg)
	{
	}

	[Token(Token = "0x60002C1")]
	[Address(RVA = "0x9A8244", Offset = "0x9A8244", VA = "0x9A8244")]
	private void AroundGetEntriesCallback(Pico.Platform.Message<Pico.Platform.Models.LeaderboardEntryList> msg)
	{
	}

	[Token(Token = "0x60002C2")]
	[Address(RVA = "0x9A0B8C", Offset = "0x9A0B8C", VA = "0x9A0B8C")]
	public void RefreshScore()
	{
	}

	[Token(Token = "0x60002C3")]
	[Address(RVA = "0x9A83E0", Offset = "0x9A83E0", VA = "0x9A83E0")]
	public void WritePlayerScore()
	{
	}

	[Token(Token = "0x60002C4")]
	[Address(RVA = "0x9A0B70", Offset = "0x9A0B70", VA = "0x9A0B70")]
	public void Show()
	{
	}

	[Token(Token = "0x60002C5")]
	[Address(RVA = "0x9A0D44", Offset = "0x9A0D44", VA = "0x9A0D44")]
	public void Hide()
	{
	}

	[Token(Token = "0x60002C6")]
	[Address(RVA = "0x9A6BE0", Offset = "0x9A6BE0", VA = "0x9A6BE0")]
	private void UpdateShowAnim()
	{
	}

	[Token(Token = "0x60002C7")]
	[Address(RVA = "0x9A8578", Offset = "0x9A8578", VA = "0x9A8578")]
	public GameLeaderboard()
	{
	}
}
[Token(Token = "0x2000058")]
public class UILBEntry : MonoBehaviour
{
	[Token(Token = "0x40003A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Image background;

	[Token(Token = "0x40003A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Text m_LP;

	[Token(Token = "0x40003A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Text m_UserName;

	[Token(Token = "0x40003AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Text m_Score;

	[Token(Token = "0x60002CB")]
	[Address(RVA = "0x9A970C", Offset = "0x9A970C", VA = "0x9A970C")]
	public UILBEntry()
	{
	}
}
[Token(Token = "0x2000059")]
public class Plug : MonoBehaviour
{
	[Token(Token = "0x60002CC")]
	[Address(RVA = "0x9A9714", Offset = "0x9A9714", VA = "0x9A9714")]
	public Plug()
	{
	}
}
[Token(Token = "0x200005A")]
public class PosLocker : MonoBehaviour
{
	[Token(Token = "0x40003AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Vector3 basePos;

	[Token(Token = "0x40003AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private Quaternion baseRot;

	[Token(Token = "0x40003AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float lastUpdateTime;

	[Token(Token = "0x60002CD")]
	[Address(RVA = "0x9A971C", Offset = "0x9A971C", VA = "0x9A971C")]
	private void Start()
	{
	}

	[Token(Token = "0x60002CE")]
	[Address(RVA = "0x9A976C", Offset = "0x9A976C", VA = "0x9A976C")]
	private void Update()
	{
	}

	[Token(Token = "0x60002CF")]
	[Address(RVA = "0x9A97EC", Offset = "0x9A97EC", VA = "0x9A97EC")]
	public PosLocker()
	{
	}
}
[Token(Token = "0x200005B")]
public class PuzzleBox : MonoBehaviour
{
	[Token(Token = "0x40003AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private XRRig xrRig;

	[Token(Token = "0x40003AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Quaternion rotationSpeed;

	[Token(Token = "0x40003B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector3 fingerForces;

	[Token(Token = "0x40003B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public Vector3 basePos;

	[Token(Token = "0x40003B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Vector3 currSpeed;

	[Token(Token = "0x40003B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public bool animateTransform;

	[Token(Token = "0x40003B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Vector3 leftHandForce;

	[Token(Token = "0x40003B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public Vector3 righHandForce;

	[Token(Token = "0x60002D0")]
	[Address(RVA = "0x9A97F4", Offset = "0x9A97F4", VA = "0x9A97F4")]
	private void Start()
	{
	}

	[Token(Token = "0x60002D1")]
	[Address(RVA = "0x9A986C", Offset = "0x9A986C", VA = "0x9A986C")]
	private void Update()
	{
	}

	[Token(Token = "0x60002D2")]
	[Address(RVA = "0x9A9A40", Offset = "0x9A9A40", VA = "0x9A9A40")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60002D3")]
	[Address(RVA = "0x9A9870", Offset = "0x9A9870", VA = "0x9A9870")]
	private void AnimateTransform()
	{
	}

	[Token(Token = "0x60002D4")]
	[Address(RVA = "0x9AA200", Offset = "0x9AA200", VA = "0x9AA200")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60002D5")]
	[Address(RVA = "0x9AA288", Offset = "0x9AA288", VA = "0x9AA288")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x60002D6")]
	[Address(RVA = "0x9AA310", Offset = "0x9AA310", VA = "0x9AA310")]
	private void OnTriggerStay(Collider other)
	{
	}

	[Token(Token = "0x60002D7")]
	[Address(RVA = "0x9AA5B8", Offset = "0x9AA5B8", VA = "0x9AA5B8")]
	public PuzzleBox()
	{
	}
}
[Token(Token = "0x200005C")]
public class Socket : Interactable
{
	[Token(Token = "0x40003B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string correctPluginID;

	[Token(Token = "0x40003B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string[] acceptedPluginIDs;

	[Token(Token = "0x40003B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Transform pluginTransform;

	[Token(Token = "0x40003B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Mesh gizmoMesh;

	[Token(Token = "0x60002D8")]
	[Address(RVA = "0x9AA6FC", Offset = "0x9AA6FC", VA = "0x9AA6FC")]
	public Socket()
	{
	}
}
[Token(Token = "0x200005D")]
public class StatsSummary : MonoBehaviour
{
	[Token(Token = "0x40003BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Vector3 basePos;

	[Token(Token = "0x40003BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private Vector3 baseScale;

	[Token(Token = "0x40003BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Quaternion baseRot;

	[Token(Token = "0x40003BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool animated;

	[Token(Token = "0x40003BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Text title;

	[Token(Token = "0x40003BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Text highScoreText;

	[Token(Token = "0x40003C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Text highScore;

	[Token(Token = "0x40003C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Text score;

	[Token(Token = "0x40003C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Text maxSpeedL;

	[Token(Token = "0x40003C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Text maxSpeedR;

	[Token(Token = "0x40003C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Text avgSpeedL;

	[Token(Token = "0x40003C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Text avgSpeedR;

	[Token(Token = "0x40003C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Text timingL;

	[Token(Token = "0x40003C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Text timingR;

	[Token(Token = "0x40003C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Text varietyL;

	[Token(Token = "0x40003C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Text varietyR;

	[Token(Token = "0x40003CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Text hitsL;

	[Token(Token = "0x40003CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Text hitsR;

	[Token(Token = "0x40003CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Text missedL;

	[Token(Token = "0x40003CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Text missedR;

	[Token(Token = "0x40003CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public Text blocks;

	[Token(Token = "0x40003CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public Text dodges;

	[Token(Token = "0x40003D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public Text damages;

	[Token(Token = "0x40003D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public GameObject toHide;

	[Token(Token = "0x40003D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public GameObject toShow;

	[Token(Token = "0x40003D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public bool canAnimHiScore;

	[Token(Token = "0x40003D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public GameObject[] fxes;

	[Token(Token = "0x40003D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private float waitTime;

	[Token(Token = "0x60002D9")]
	[Address(RVA = "0x9AA704", Offset = "0x9AA704", VA = "0x9AA704")]
	public void RefreshStats()
	{
	}

	[Token(Token = "0x60002DA")]
	[Address(RVA = "0x9AB038", Offset = "0x9AB038", VA = "0x9AB038")]
	private void Start()
	{
	}

	[Token(Token = "0x60002DB")]
	[Address(RVA = "0x9AB288", Offset = "0x9AB288", VA = "0x9AB288")]
	private void Update()
	{
	}

	[Token(Token = "0x60002DC")]
	[Address(RVA = "0x9AB5D8", Offset = "0x9AB5D8", VA = "0x9AB5D8")]
	public StatsSummary()
	{
	}
}
[Token(Token = "0x200005E")]
public class TestMove : MonoBehaviour
{
	[Token(Token = "0x40003D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 basePos;

	[Token(Token = "0x40003D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Vector3 destPos;

	[Token(Token = "0x40003D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float movePeriod;

	[Token(Token = "0x40003D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float releasePeriod;

	[Token(Token = "0x40003DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float time;

	[Token(Token = "0x40003DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Game game;

	[Token(Token = "0x60002DD")]
	[Address(RVA = "0x9AB5F0", Offset = "0x9AB5F0", VA = "0x9AB5F0")]
	private void Start()
	{
	}

	[Token(Token = "0x60002DE")]
	[Address(RVA = "0x9AB67C", Offset = "0x9AB67C", VA = "0x9AB67C")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60002DF")]
	[Address(RVA = "0x9AB790", Offset = "0x9AB790", VA = "0x9AB790")]
	public TestMove()
	{
	}
}
[Token(Token = "0x200005F")]
public class TouchMarker : Interactable
{
	[Token(Token = "0x40003DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Activator activator;

	[Token(Token = "0x40003DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public AudioClip touchSound;

	[Token(Token = "0x40003DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private AudioSource audioSource;

	[Token(Token = "0x60002E0")]
	[Address(RVA = "0x9AB7A0", Offset = "0x9AB7A0", VA = "0x9AB7A0")]
	private void Start()
	{
	}

	[Token(Token = "0x60002E1")]
	[Address(RVA = "0x9AB83C", Offset = "0x9AB83C", VA = "0x9AB83C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60002E2")]
	[Address(RVA = "0x9AB934", Offset = "0x9AB934", VA = "0x9AB934", Slot = "6")]
	public override void OnStartUsing(XRHandController hand)
	{
	}

	[Token(Token = "0x60002E3")]
	[Address(RVA = "0x9AB9D4", Offset = "0x9AB9D4", VA = "0x9AB9D4")]
	public TouchMarker()
	{
	}
}
[Token(Token = "0x2000060")]
public class TransformCopier : MonoBehaviour
{
	[Token(Token = "0x40003DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform baseTransform;

	[Token(Token = "0x40003E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool copyPosition;

	[Token(Token = "0x60002E4")]
	[Address(RVA = "0x9AB9DC", Offset = "0x9AB9DC", VA = "0x9AB9DC")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60002E5")]
	[Address(RVA = "0x9ABAD0", Offset = "0x9ABAD0", VA = "0x9ABAD0")]
	public TransformCopier()
	{
	}
}
[Token(Token = "0x2000061")]
public class TranslatorTool : MonoBehaviour
{
	[Token(Token = "0x40003E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static TranslatorTool instance;

	[Token(Token = "0x40003E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text[] m_Text;

	[Token(Token = "0x40003E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string[] m_ID;

	[Token(Token = "0x40003E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TextAsset m_EnTranslateFile;

	[Token(Token = "0x40003E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public TextAsset m_CnTranslateFile;

	[Token(Token = "0x40003E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public TextAsset m_JpTranslateFile;

	[Token(Token = "0x40003E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public TextAsset m_KrTranslateFile;

	[Token(Token = "0x40003E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TextAsset m_FrTranslateFile;

	[Token(Token = "0x40003E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public TextAsset m_DeTranslateFile;

	[Token(Token = "0x40003EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public TextAsset m_SpTranslateFile;

	[Token(Token = "0x40003EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public TextAsset m_PtTranslateFile;

	[Token(Token = "0x40003EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public TextAsset m_ThTranslateFile;

	[Token(Token = "0x40003ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public TextAsset m_ItTranslateFile;

	[Token(Token = "0x40003EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private List<List<string>> m_Translate;

	[Token(Token = "0x40003EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private List<List<string>> m_AllTranslates;

	[Token(Token = "0x40003F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private List<List<string>> m_AllIDs;

	[Token(Token = "0x40003F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private int currLang;

	[Token(Token = "0x60002E6")]
	[Address(RVA = "0x9ABAD8", Offset = "0x9ABAD8", VA = "0x9ABAD8")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002E7")]
	[Address(RVA = "0x9AC68C", Offset = "0x9AC68C", VA = "0x9AC68C")]
	private void Update()
	{
	}

	[Token(Token = "0x60002E8")]
	[Address(RVA = "0x9AC748", Offset = "0x9AC748", VA = "0x9AC748")]
	private void Start()
	{
	}

	[Token(Token = "0x60002E9")]
	[Address(RVA = "0x9AC53C", Offset = "0x9AC53C", VA = "0x9AC53C")]
	private void SelectDefaultLanguage()
	{
	}

	[Token(Token = "0x60002EA")]
	[Address(RVA = "0x9ABFC0", Offset = "0x9ABFC0", VA = "0x9ABFC0")]
	private void ReadTransalte(TextAsset translate_file)
	{
	}

	[Token(Token = "0x60002EB")]
	[Address(RVA = "0x9AC6F4", Offset = "0x9AC6F4", VA = "0x9AC6F4")]
	public void SetupLanguage()
	{
	}

	[Token(Token = "0x60002EC")]
	[Address(RVA = "0x9AC74C", Offset = "0x9AC74C", VA = "0x9AC74C")]
	private void SetupLanguage(int lang_idx)
	{
	}

	[Token(Token = "0x60002ED")]
	[Address(RVA = "0x9AC8AC", Offset = "0x9AC8AC", VA = "0x9AC8AC")]
	public string Translate(string text)
	{
		return null;
	}

	[Token(Token = "0x60002EE")]
	[Address(RVA = "0x9ACA4C", Offset = "0x9ACA4C", VA = "0x9ACA4C")]
	public TranslatorTool()
	{
	}
}
[Token(Token = "0x2000062")]
public class TutorialList : MonoBehaviour
{
	[Token(Token = "0x40003F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject[] chapter0;

	[Token(Token = "0x40003F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject[] chapter1;

	[Token(Token = "0x40003F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject[] chapter2;

	[Token(Token = "0x40003F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject[] chapter3;

	[Token(Token = "0x40003F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject[] chapter4;

	[Token(Token = "0x40003F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private GameObject[][] chapters;

	[Token(Token = "0x40003F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject begining;

	[Token(Token = "0x40003F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private int currChapter;

	[Token(Token = "0x40003FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private int currProgress;

	[Token(Token = "0x40003FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private VideoPlayer videoPlayer;

	[Token(Token = "0x40003FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float scale;

	[Token(Token = "0x60002EF")]
	[Address(RVA = "0x9ACB2C", Offset = "0x9ACB2C", VA = "0x9ACB2C")]
	private void Start()
	{
	}

	[Token(Token = "0x60002F0")]
	[Address(RVA = "0x9ACFE8", Offset = "0x9ACFE8", VA = "0x9ACFE8")]
	private void Update()
	{
	}

	[Token(Token = "0x60002F1")]
	[Address(RVA = "0x9AD1FC", Offset = "0x9AD1FC", VA = "0x9AD1FC")]
	private void StartVideo()
	{
	}

	[Token(Token = "0x60002F2")]
	[Address(RVA = "0x9AD38C", Offset = "0x9AD38C", VA = "0x9AD38C")]
	public void OnSelectChapter(int chapter)
	{
	}

	[Token(Token = "0x60002F3")]
	[Address(RVA = "0x9AD3BC", Offset = "0x9AD3BC", VA = "0x9AD3BC")]
	public TutorialList()
	{
	}
}
[Token(Token = "0x2000063")]
public class UIHeightItem : UIItem
{
	[Token(Token = "0x40003FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public MeshRenderer unitQuad;

	[Token(Token = "0x40003FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public MeshRenderer tensQuad;

	[Token(Token = "0x40003FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public MeshRenderer hundredsQuad;

	[Token(Token = "0x4000400")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public MeshRenderer cmQuad;

	[Token(Token = "0x4000401")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public MeshRenderer backQuad;

	[Token(Token = "0x4000402")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Material normBackMat;

	[Token(Token = "0x4000403")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Material highBackMat;

	[Token(Token = "0x4000404")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Material[] digitsMat;

	[Token(Token = "0x60002F4")]
	[Address(RVA = "0x9AD430", Offset = "0x9AD430", VA = "0x9AD430", Slot = "5")]
	public override bool SetHighlighted(bool val)
	{
		return default(bool);
	}

	[Token(Token = "0x60002F5")]
	[Address(RVA = "0x9AD490", Offset = "0x9AD490", VA = "0x9AD490")]
	public UIHeightItem()
	{
	}
}
[Token(Token = "0x2000064")]
public class CommonVR : MonoBehaviour
{
	[Token(Token = "0x2000065")]
	public enum HDMType
	{
		[Token(Token = "0x4000428")]
		Pico,
		[Token(Token = "0x4000429")]
		Quest,
		[Token(Token = "0x400042A")]
		Steam,
		[Token(Token = "0x400042B")]
		Unknown
	}

	[Serializable]
	[Token(Token = "0x2000066")]
	private sealed class <>c
	{
		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Oculus.Platform.Message.Callback <>9__2_0;

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x9B10A0", Offset = "0x9B10A0", VA = "0x9B10A0")]
		public <>c()
		{
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x9B10A8", Offset = "0x9B10A8", VA = "0x9B10A8")]
		internal void <OculusEntitlementCheck>b__2_0(Oculus.Platform.Message msg)
		{
		}
	}

	[Token(Token = "0x4000405")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool oculusEntitlementCheck;

	[Token(Token = "0x4000406")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public HDMType hdmType;

	[Token(Token = "0x4000407")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float commonParam1;

	[Token(Token = "0x4000408")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float commonParam2;

	[Token(Token = "0x4000409")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public MRController controllerMR;

	[Token(Token = "0x400040A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public XRHandController leftHand;

	[Token(Token = "0x400040B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public XRHandController rightHand;

	[Token(Token = "0x400040C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Camera cameraVR;

	[Token(Token = "0x400040D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool m_VibrationsOff;

	[Token(Token = "0x400040E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	public bool m_Blackout;

	[Token(Token = "0x400040F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject m_BlackoutQuad;

	[Token(Token = "0x4000410")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool m_MenuWasPressed;

	[Token(Token = "0x4000411")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
	private bool m_MenuPressedNow;

	[Token(Token = "0x4000412")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private float m_BlackoutScale;

	[Token(Token = "0x4000413")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static CommonVR instance;

	[Token(Token = "0x4000414")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool wasUpPressedL;

	[Token(Token = "0x4000415")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
	private bool wasDownPressedL;

	[Token(Token = "0x4000416")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
	private bool wasUpPressedR;

	[Token(Token = "0x4000417")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
	private bool wasDownPressedR;

	[Token(Token = "0x4000418")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public bool recordTransforms;

	[Token(Token = "0x4000419")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
	public bool playTransforms;

	[Token(Token = "0x400041A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Vector3[] headPositions;

	[Token(Token = "0x400041B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Quaternion[] headRotations;

	[Token(Token = "0x400041C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Vector3[] leftHandPositions;

	[Token(Token = "0x400041D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Quaternion[] leftHandRotations;

	[Token(Token = "0x400041E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Vector3[] rightHandPositions;

	[Token(Token = "0x400041F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Quaternion[] rightHandRotations;

	[Token(Token = "0x4000420")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private float currRecordTime;

	[Token(Token = "0x4000421")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public string readFilePath;

	[Token(Token = "0x4000422")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public float cameraSmooth;

	[Token(Token = "0x4000423")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	public float handSmooth;

	[Token(Token = "0x4000424")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private int prevFrame;

	[Token(Token = "0x4000425")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public GameObject[] objToHideInDashboard;

	[Token(Token = "0x4000426")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private bool inDashboardMode;

	[Token(Token = "0x1700002E")]
	public bool UpPressed
	{
		[Token(Token = "0x600030D")]
		[Address(RVA = "0x9B0C34", Offset = "0x9B0C34", VA = "0x9B0C34")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700002F")]
	public bool UpPressedL
	{
		[Token(Token = "0x600030E")]
		[Address(RVA = "0x9AE5D8", Offset = "0x9AE5D8", VA = "0x9AE5D8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000030")]
	public bool UpPressedR
	{
		[Token(Token = "0x600030F")]
		[Address(RVA = "0x9AE798", Offset = "0x9AE798", VA = "0x9AE798")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000031")]
	public bool DownPressed
	{
		[Token(Token = "0x6000310")]
		[Address(RVA = "0x9B0D7C", Offset = "0x9B0D7C", VA = "0x9B0D7C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000032")]
	public bool DownPressedL
	{
		[Token(Token = "0x6000311")]
		[Address(RVA = "0x9AE6B8", Offset = "0x9AE6B8", VA = "0x9AE6B8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000033")]
	public bool DownPressedR
	{
		[Token(Token = "0x6000312")]
		[Address(RVA = "0x9AE878", Offset = "0x9AE878", VA = "0x9AE878")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60002F6")]
	[Address(RVA = "0x9AD498", Offset = "0x9AD498", VA = "0x9AD498")]
	private void SetupHDMType()
	{
	}

	[Token(Token = "0x60002F7")]
	[Address(RVA = "0x9AD4A0", Offset = "0x9AD4A0", VA = "0x9AD4A0")]
	private void OculusEntitlementCheck()
	{
	}

	[Token(Token = "0x60002F8")]
	[Address(RVA = "0x9AD5EC", Offset = "0x9AD5EC", VA = "0x9AD5EC")]
	public XRHandController GetAnyHand()
	{
		return null;
	}

	[Token(Token = "0x60002F9")]
	[Address(RVA = "0x9AD660", Offset = "0x9AD660", VA = "0x9AD660")]
	private void Start()
	{
	}

	[Token(Token = "0x60002FA")]
	[Address(RVA = "0x9AD728", Offset = "0x9AD728", VA = "0x9AD728")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60002FB")]
	[Address(RVA = "0x9AD854", Offset = "0x9AD854", VA = "0x9AD854")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002FC")]
	[Address(RVA = "0x9AE508", Offset = "0x9AE508", VA = "0x9AE508")]
	private void UpdateDebugParams()
	{
	}

	[Token(Token = "0x60002FD")]
	[Address(RVA = "0x9AE958", Offset = "0x9AE958", VA = "0x9AE958")]
	private void Update()
	{
	}

	[Token(Token = "0x60002FE")]
	[Address(RVA = "0x9B0218", Offset = "0x9B0218", VA = "0x9B0218")]
	public bool IsMenuPressedNow()
	{
		return default(bool);
	}

	[Token(Token = "0x60002FF")]
	[Address(RVA = "0x9AE9D8", Offset = "0x9AE9D8", VA = "0x9AE9D8")]
	public bool IsMenuPressed()
	{
		return default(bool);
	}

	[Token(Token = "0x6000300")]
	[Address(RVA = "0x9B0220", Offset = "0x9B0220", VA = "0x9B0220")]
	public bool IsSteam()
	{
		return default(bool);
	}

	[Token(Token = "0x6000301")]
	[Address(RVA = "0x9B0228", Offset = "0x9B0228", VA = "0x9B0228")]
	public bool IsPaused()
	{
		return default(bool);
	}

	[Token(Token = "0x6000302")]
	[Address(RVA = "0x9B0358", Offset = "0x9B0358", VA = "0x9B0358")]
	public bool IsTrigger()
	{
		return default(bool);
	}

	[Token(Token = "0x6000303")]
	[Address(RVA = "0x9B044C", Offset = "0x9B044C", VA = "0x9B044C")]
	public Vector3 GetLHandPos()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000304")]
	[Address(RVA = "0x9B052C", Offset = "0x9B052C", VA = "0x9B052C")]
	public Vector3 GetRHandPos()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000305")]
	[Address(RVA = "0x9B060C", Offset = "0x9B060C", VA = "0x9B060C")]
	public Vector3 GetLHandDir()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000306")]
	[Address(RVA = "0x9B06EC", Offset = "0x9B06EC", VA = "0x9B06EC")]
	public Vector3 GetRHandDir()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000307")]
	[Address(RVA = "0x9B07CC", Offset = "0x9B07CC", VA = "0x9B07CC")]
	public Vector3 GetPointerPos()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000308")]
	[Address(RVA = "0x9B092C", Offset = "0x9B092C", VA = "0x9B092C")]
	public Vector3 GetPointerRot()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000309")]
	[Address(RVA = "0x9B0ACC", Offset = "0x9B0ACC", VA = "0x9B0ACC")]
	public Vector3 GetPointerDir()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600030A")]
	[Address(RVA = "0x9B0BC8", Offset = "0x9B0BC8", VA = "0x9B0BC8")]
	public Vector3 GetHeadPos()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600030B")]
	[Address(RVA = "0x9B0BF0", Offset = "0x9B0BF0", VA = "0x9B0BF0")]
	public Vector3 GetHeadDir()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600030C")]
	[Address(RVA = "0x9B0C18", Offset = "0x9B0C18", VA = "0x9B0C18")]
	public bool IsHQVersion()
	{
		return default(bool);
	}

	[Token(Token = "0x6000313")]
	[Address(RVA = "0x9AEAA8", Offset = "0x9AEAA8", VA = "0x9AEAA8")]
	private void RecordTransforms()
	{
	}

	[Token(Token = "0x6000314")]
	[Address(RVA = "0x9B0EC4", Offset = "0x9B0EC4", VA = "0x9B0EC4")]
	private void CreateTransformArrays(int count)
	{
	}

	[Token(Token = "0x6000315")]
	[Address(RVA = "0x9ADA60", Offset = "0x9ADA60", VA = "0x9ADA60")]
	private void ReadTransforms()
	{
	}

	[Token(Token = "0x6000316")]
	[Address(RVA = "0x9AFAFC", Offset = "0x9AFAFC", VA = "0x9AFAFC")]
	private void PlayTransforms()
	{
	}

	[Token(Token = "0x6000317")]
	[Address(RVA = "0x9AFFFC", Offset = "0x9AFFFC", VA = "0x9AFFFC")]
	private void UpdateDashboardMode()
	{
	}

	[Token(Token = "0x6000318")]
	[Address(RVA = "0x9B0FC8", Offset = "0x9B0FC8", VA = "0x9B0FC8")]
	public CommonVR()
	{
	}
}
[Token(Token = "0x2000067")]
public class FingerSensor : MonoBehaviour
{
	[Token(Token = "0x2000068")]
	public enum FingerType
	{
		[Token(Token = "0x4000431")]
		Unknown,
		[Token(Token = "0x4000432")]
		Index,
		[Token(Token = "0x4000433")]
		Middle,
		[Token(Token = "0x4000434")]
		Ring,
		[Token(Token = "0x4000435")]
		Pinky,
		[Token(Token = "0x4000436")]
		Thumb
	}

	[Token(Token = "0x400042E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public FingerType type;

	[Token(Token = "0x400042F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public XRHandController hand;

	[Token(Token = "0x600031C")]
	[Address(RVA = "0x9B10D8", Offset = "0x9B10D8", VA = "0x9B10D8")]
	private void Start()
	{
	}

	[Token(Token = "0x600031D")]
	[Address(RVA = "0x9B1164", Offset = "0x9B1164", VA = "0x9B1164")]
	public FingerSensor()
	{
	}
}
[Token(Token = "0x2000069")]
public enum HandType
{
	[Token(Token = "0x4000438")]
	Left,
	[Token(Token = "0x4000439")]
	Right
}
[Token(Token = "0x200006A")]
public class XRHandController : MonoBehaviour
{
	[Token(Token = "0x200006B")]
	private class CachedAudioClip
	{
		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string path;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioClip clip;

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x9B3A3C", Offset = "0x9B3A3C", VA = "0x9B3A3C")]
		public CachedAudioClip()
		{
		}
	}

	[Token(Token = "0x400043A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool menuHand;

	[Token(Token = "0x400043B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private float hapticPower;

	[Token(Token = "0x400043C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float hapticPeriod;

	[Token(Token = "0x400043D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public FingerSensor indexFinger;

	[Token(Token = "0x400043E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float blockHitTime;

	[Token(Token = "0x400043F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public HandType handType;

	[Token(Token = "0x4000440")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector3 prevPosition;

	[Token(Token = "0x4000441")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public Vector3 avgSpeed;

	[Token(Token = "0x4000442")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float avgSpeedMagnitude;

	[Token(Token = "0x4000443")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Interactable bestInteractable;

	[Token(Token = "0x4000444")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public bool isDragged;

	[Token(Token = "0x4000445")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
	public bool isInUse;

	[Token(Token = "0x4000446")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
	public bool isGrip;

	[Token(Token = "0x4000447")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
	private bool wasGrip;

	[Token(Token = "0x4000448")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public bool isTrigger;

	[Token(Token = "0x4000449")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
	private bool wasTrigger;

	[Token(Token = "0x400044A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Material illuminateMaterial;

	[Token(Token = "0x400044B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private AudioSource audioSource;

	[Token(Token = "0x400044C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public AudioClip[] hitSounds;

	[Token(Token = "0x400044D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public AudioClip missSound;

	[Token(Token = "0x400044E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public GameObject visualisation;

	[Token(Token = "0x400044F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Vector3 enterCollPos;

	[Token(Token = "0x4000450")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private float collisionInfluence;

	[Token(Token = "0x4000451")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public SkinnedMeshRenderer mesh;

	[Token(Token = "0x4000452")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Light light;

	[Token(Token = "0x4000453")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Material[] comboMaterials;

	[Token(Token = "0x4000454")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public int varietyCounter;

	[Token(Token = "0x4000455")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	public int varietyValue;

	[Token(Token = "0x4000456")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private XRHandController otherHand;

	[Token(Token = "0x4000457")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public GameObject sphereMR;

	[Token(Token = "0x4000458")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private Game game;

	[Token(Token = "0x4000459")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private CommonVR vr;

	[Token(Token = "0x400045A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private Game.HitTarget target;

	[Token(Token = "0x400045B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	private float SFXVol;

	[Token(Token = "0x400045C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private int SFXType;

	[Token(Token = "0x400045D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private InputDevice m_InputDevice;

	[Token(Token = "0x400045E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private bool wasCollsionLastTime;

	[Token(Token = "0x400045F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public Text debugText;

	[Token(Token = "0x4000460")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public Canvas debugPanel;

	[Token(Token = "0x4000461")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public LineRenderer debugLine;

	[Token(Token = "0x4000462")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private float indexValue;

	[Token(Token = "0x4000463")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
	private float thumbValue;

	[Token(Token = "0x4000464")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private float threeFingersValue;

	[Token(Token = "0x4000465")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private Animator animator;

	[Token(Token = "0x4000466")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	public GameObject blockEffect;

	[Token(Token = "0x4000467")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	public Material progressMaterial;

	[Token(Token = "0x4000468")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	public RectTransform progressTransform;

	[Token(Token = "0x4000469")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private float progress;

	[Token(Token = "0x400046A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
	private float animProgress;

	[Token(Token = "0x400046B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private List<CachedAudioClip> cachedClips;

	[Token(Token = "0x600031E")]
	[Address(RVA = "0x9B116C", Offset = "0x9B116C", VA = "0x9B116C")]
	public bool IsInBody()
	{
		return default(bool);
	}

	[Token(Token = "0x600031F")]
	[Address(RVA = "0x9B119C", Offset = "0x9B119C", VA = "0x9B119C")]
	private void PlayHitFX(int hit_quality, float hit_speed)
	{
	}

	[Token(Token = "0x6000320")]
	[Address(RVA = "0x9B1370", Offset = "0x9B1370", VA = "0x9B1370")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000321")]
	[Address(RVA = "0x9B2274", Offset = "0x9B2274", VA = "0x9B2274")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000322")]
	[Address(RVA = "0x9AB920", Offset = "0x9AB920", VA = "0x9AB920")]
	public void AddHaptic(float power, float period)
	{
	}

	[Token(Token = "0x6000323")]
	[Address(RVA = "0x9B2328", Offset = "0x9B2328", VA = "0x9B2328")]
	private void Start()
	{
	}

	[Token(Token = "0x6000324")]
	[Address(RVA = "0x9B2730", Offset = "0x9B2730", VA = "0x9B2730")]
	private void Update()
	{
	}

	[Token(Token = "0x6000325")]
	[Address(RVA = "0x9B2D38", Offset = "0x9B2D38", VA = "0x9B2D38")]
	private void UpdateHaptic()
	{
	}

	[Token(Token = "0x6000326")]
	[Address(RVA = "0x9B2FE8", Offset = "0x9B2FE8", VA = "0x9B2FE8")]
	private void UpdateTrigger()
	{
	}

	[Token(Token = "0x6000327")]
	[Address(RVA = "0x9B2DE8", Offset = "0x9B2DE8", VA = "0x9B2DE8")]
	private void UpdateGrip()
	{
	}

	[Token(Token = "0x6000328")]
	[Address(RVA = "0x9B3384", Offset = "0x9B3384", VA = "0x9B3384")]
	private InputDevice GetInputDevice()
	{
		return default(InputDevice);
	}

	[Token(Token = "0x6000329")]
	[Address(RVA = "0x9B33D0", Offset = "0x9B33D0", VA = "0x9B33D0")]
	private void OnTriggerStay(Collider other)
	{
	}

	[Token(Token = "0x600032A")]
	[Address(RVA = "0x9B34A0", Offset = "0x9B34A0", VA = "0x9B34A0")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600032B")]
	[Address(RVA = "0x9B20EC", Offset = "0x9B20EC", VA = "0x9B20EC")]
	public void ChangeVariety(int value)
	{
	}

	[Token(Token = "0x600032C")]
	[Address(RVA = "0x9B34E8", Offset = "0x9B34E8", VA = "0x9B34E8")]
	private void UpdateDebug()
	{
	}

	[Token(Token = "0x600032D")]
	[Address(RVA = "0x9B2AE0", Offset = "0x9B2AE0", VA = "0x9B2AE0")]
	private void AnimateHand()
	{
	}

	[Token(Token = "0x600032E")]
	[Address(RVA = "0x9B1C28", Offset = "0x9B1C28", VA = "0x9B1C28")]
	public void PlayBlockEffect(Collider other)
	{
	}

	[Token(Token = "0x600032F")]
	[Address(RVA = "0x9B3578", Offset = "0x9B3578", VA = "0x9B3578")]
	public bool IncraseProgress(float val)
	{
		return default(bool);
	}

	[Token(Token = "0x6000330")]
	[Address(RVA = "0x9B35B4", Offset = "0x9B35B4", VA = "0x9B35B4")]
	public void ResetProgress()
	{
	}

	[Token(Token = "0x6000331")]
	[Address(RVA = "0x9B31BC", Offset = "0x9B31BC", VA = "0x9B31BC")]
	private void UpdateProgress()
	{
	}

	[Token(Token = "0x6000332")]
	[Address(RVA = "0x9B35BC", Offset = "0x9B35BC", VA = "0x9B35BC")]
	public void PlaySound(string clip_name, float volume = 1f)
	{
	}

	[Token(Token = "0x6000333")]
	[Address(RVA = "0x9B3920", Offset = "0x9B3920", VA = "0x9B3920")]
	public void PlayRandomSound(string clip_name, int no_variants, float volume = 1f)
	{
	}

	[Token(Token = "0x6000334")]
	[Address(RVA = "0x9B3698", Offset = "0x9B3698", VA = "0x9B3698")]
	public AudioClip GetCachedClip(string path)
	{
		return null;
	}

	[Token(Token = "0x6000335")]
	[Address(RVA = "0x9B3A44", Offset = "0x9B3A44", VA = "0x9B3A44")]
	public void PlaySFXSample()
	{
	}

	[Token(Token = "0x6000336")]
	[Address(RVA = "0x9B3B68", Offset = "0x9B3B68", VA = "0x9B3B68")]
	public XRHandController()
	{
	}
}
[Token(Token = "0x200006C")]
public class SciFiBeamStatic : MonoBehaviour
{
	[Token(Token = "0x400046E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject beamLineRendererPrefab;

	[Token(Token = "0x400046F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject beamStartPrefab;

	[Token(Token = "0x4000470")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject beamEndPrefab;

	[Token(Token = "0x4000471")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GameObject beamStart;

	[Token(Token = "0x4000472")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private GameObject beamEnd;

	[Token(Token = "0x4000473")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private GameObject beam;

	[Token(Token = "0x4000474")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private LineRenderer line;

	[Token(Token = "0x4000475")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool alwaysOn;

	[Token(Token = "0x4000476")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
	public bool beamCollides;

	[Token(Token = "0x4000477")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float beamLength;

	[Token(Token = "0x4000478")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public float beamEndOffset;

	[Token(Token = "0x4000479")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public float textureScrollSpeed;

	[Token(Token = "0x400047A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public float textureLengthScale;

	[Token(Token = "0x6000338")]
	[Address(RVA = "0x9B3C7C", Offset = "0x9B3C7C", VA = "0x9B3C7C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000339")]
	[Address(RVA = "0x9B3F5C", Offset = "0x9B3F5C", VA = "0x9B3F5C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600033A")]
	[Address(RVA = "0x9B4074", Offset = "0x9B4074", VA = "0x9B4074")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600033B")]
	[Address(RVA = "0x9B3C8C", Offset = "0x9B3C8C", VA = "0x9B3C8C")]
	public void SpawnBeam()
	{
	}

	[Token(Token = "0x600033C")]
	[Address(RVA = "0x9B3F60", Offset = "0x9B3F60", VA = "0x9B3F60")]
	public void RemoveBeam()
	{
	}

	[Token(Token = "0x600033D")]
	[Address(RVA = "0x9B4478", Offset = "0x9B4478", VA = "0x9B4478")]
	public SciFiBeamStatic()
	{
	}
}
[Token(Token = "0x200006D")]
public class SciFiLightFlicker : MonoBehaviour
{
	[Token(Token = "0x400047B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string waveFunction;

	[Token(Token = "0x400047C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float startValue;

	[Token(Token = "0x400047D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float amplitude;

	[Token(Token = "0x400047E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float phase;

	[Token(Token = "0x400047F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float frequency;

	[Token(Token = "0x4000480")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Color originalColor;

	[Token(Token = "0x600033E")]
	[Address(RVA = "0x9B4498", Offset = "0x9B4498", VA = "0x9B4498")]
	private void Start()
	{
	}

	[Token(Token = "0x600033F")]
	[Address(RVA = "0x9B44FC", Offset = "0x9B44FC", VA = "0x9B44FC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000340")]
	[Address(RVA = "0x9B4590", Offset = "0x9B4590", VA = "0x9B4590")]
	private float EvalWave()
	{
		return default(float);
	}

	[Token(Token = "0x6000341")]
	[Address(RVA = "0x9B475C", Offset = "0x9B475C", VA = "0x9B475C")]
	public SciFiLightFlicker()
	{
	}
}
[Token(Token = "0x200006E")]
public class assetUrl : MonoBehaviour
{
	[Token(Token = "0x4000481")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string link;

	[Token(Token = "0x6000342")]
	[Address(RVA = "0x9B47C4", Offset = "0x9B47C4", VA = "0x9B47C4")]
	public void url()
	{
	}

	[Token(Token = "0x6000343")]
	[Address(RVA = "0x9B47D0", Offset = "0x9B47D0", VA = "0x9B47D0")]
	public assetUrl()
	{
	}
}
[Token(Token = "0x200006F")]
public class camSlider : MonoBehaviour
{
	[Token(Token = "0x4000482")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Slider mainSlider;

	[Token(Token = "0x4000483")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float range;

	[Token(Token = "0x6000344")]
	[Address(RVA = "0x9B47D8", Offset = "0x9B47D8", VA = "0x9B47D8")]
	public void camX()
	{
	}

	[Token(Token = "0x6000345")]
	[Address(RVA = "0x9B4844", Offset = "0x9B4844", VA = "0x9B4844")]
	public void camY()
	{
	}

	[Token(Token = "0x6000346")]
	[Address(RVA = "0x9B48A8", Offset = "0x9B48A8", VA = "0x9B48A8")]
	public camSlider()
	{
	}
}
[Token(Token = "0x2000070")]
public class globalVolumeTuner : MonoBehaviour
{
	[Token(Token = "0x4000484")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Slider mainSlider;

	[Token(Token = "0x6000347")]
	[Address(RVA = "0x9B48B8", Offset = "0x9B48B8", VA = "0x9B48B8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000348")]
	[Address(RVA = "0x9B48C4", Offset = "0x9B48C4", VA = "0x9B48C4")]
	public void slider()
	{
	}

	[Token(Token = "0x6000349")]
	[Address(RVA = "0x9B48F0", Offset = "0x9B48F0", VA = "0x9B48F0")]
	public globalVolumeTuner()
	{
	}
}
[Token(Token = "0x2000071")]
public class HUDFPS : MonoBehaviour
{
	[Token(Token = "0x4000485")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float updateInterval;

	[Token(Token = "0x4000486")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private float accum;

	[Token(Token = "0x4000487")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int frames;

	[Token(Token = "0x4000488")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float timeleft;

	[Token(Token = "0x600034A")]
	[Address(RVA = "0x9B48F8", Offset = "0x9B48F8", VA = "0x9B48F8")]
	private void Start()
	{
	}

	[Token(Token = "0x600034B")]
	[Address(RVA = "0x9B49F0", Offset = "0x9B49F0", VA = "0x9B49F0")]
	private void Update()
	{
	}

	[Token(Token = "0x600034C")]
	[Address(RVA = "0x9B4BEC", Offset = "0x9B4BEC", VA = "0x9B4BEC")]
	public HUDFPS()
	{
	}
}
[Token(Token = "0x2000072")]
public class KeyboardCameraControl : MonoBehaviour
{
	[Token(Token = "0x2000073")]
	public enum KeyboardAxis
	{
		[Token(Token = "0x4000493")]
		Horizontal = 0,
		[Token(Token = "0x4000494")]
		Vertical = 1,
		[Token(Token = "0x4000495")]
		None = 3
	}

	[Serializable]
	[Token(Token = "0x2000074")]
	public class Modifiers
	{
		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool leftAlt;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool leftControl;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		public bool leftShift;

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x9B52B4", Offset = "0x9B52B4", VA = "0x9B52B4")]
		public bool checkModifiers()
		{
			return default(bool);
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x9B52AC", Offset = "0x9B52AC", VA = "0x9B52AC")]
		public Modifiers()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000075")]
	public class KeyboardControlConfiguration
	{
		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool activate;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public KeyboardAxis keyboardAxis;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Modifiers modifiers;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float sensitivity;

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x9B4FBC", Offset = "0x9B4FBC", VA = "0x9B4FBC")]
		public bool isActivated()
		{
			return default(bool);
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x9B52A4", Offset = "0x9B52A4", VA = "0x9B52A4")]
		public KeyboardControlConfiguration()
		{
		}
	}

	[Token(Token = "0x4000489")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public KeyboardControlConfiguration yaw;

	[Token(Token = "0x400048A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public KeyboardControlConfiguration pitch;

	[Token(Token = "0x400048B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public KeyboardControlConfiguration roll;

	[Token(Token = "0x400048C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public KeyboardControlConfiguration verticalTranslation;

	[Token(Token = "0x400048D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public KeyboardControlConfiguration horizontalTranslation;

	[Token(Token = "0x400048E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public KeyboardControlConfiguration depthTranslation;

	[Token(Token = "0x400048F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public string keyboardHorizontalAxisName;

	[Token(Token = "0x4000490")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public string keyboardVerticalAxisName;

	[Token(Token = "0x4000491")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private string[] keyboardAxesNames;

	[Token(Token = "0x600034D")]
	[Address(RVA = "0x9B4BFC", Offset = "0x9B4BFC", VA = "0x9B4BFC")]
	private void Start()
	{
	}

	[Token(Token = "0x600034E")]
	[Address(RVA = "0x9B4CDC", Offset = "0x9B4CDC", VA = "0x9B4CDC")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600034F")]
	[Address(RVA = "0x9B4FF4", Offset = "0x9B4FF4", VA = "0x9B4FF4")]
	public KeyboardCameraControl()
	{
	}
}
[Token(Token = "0x2000076")]
public class limitFramerate : MonoBehaviour
{
	[Token(Token = "0x400049D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int fps;

	[Token(Token = "0x6000354")]
	[Address(RVA = "0x9B5334", Offset = "0x9B5334", VA = "0x9B5334")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000355")]
	[Address(RVA = "0x9B5340", Offset = "0x9B5340", VA = "0x9B5340")]
	public limitFramerate()
	{
	}
}
[Token(Token = "0x2000077")]
public class magicEffectButton : MonoBehaviour
{
	[Token(Token = "0x400049E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string button;

	[Token(Token = "0x400049F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ParticleSystem ps;

	[Token(Token = "0x6000356")]
	[Address(RVA = "0x9B5350", Offset = "0x9B5350", VA = "0x9B5350")]
	private void Start()
	{
	}

	[Token(Token = "0x6000357")]
	[Address(RVA = "0x9B53C4", Offset = "0x9B53C4", VA = "0x9B53C4")]
	public void offOnButton()
	{
	}

	[Token(Token = "0x6000358")]
	[Address(RVA = "0x9B542C", Offset = "0x9B542C", VA = "0x9B542C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000359")]
	[Address(RVA = "0x9B5458", Offset = "0x9B5458", VA = "0x9B5458")]
	public magicEffectButton()
	{
	}
}
[Token(Token = "0x2000078")]
public class materialColor : MonoBehaviour
{
	[Token(Token = "0x40004A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Material[] materials;

	[Token(Token = "0x40004A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Renderer[] rend;

	[Token(Token = "0x40004A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ParticleSystem ps;

	[Token(Token = "0x40004A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public TrailRenderer[] trail;

	[Token(Token = "0x40004A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Text[] text;

	[Token(Token = "0x40004A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Color color2;

	[Token(Token = "0x600035A")]
	[Address(RVA = "0x9B5460", Offset = "0x9B5460", VA = "0x9B5460")]
	public void colorButtonWhite()
	{
	}

	[Token(Token = "0x600035B")]
	[Address(RVA = "0x9B5788", Offset = "0x9B5788", VA = "0x9B5788")]
	public void colorButtonBlack()
	{
	}

	[Token(Token = "0x600035C")]
	[Address(RVA = "0x9B579C", Offset = "0x9B579C", VA = "0x9B579C")]
	public void colorButtonRed()
	{
	}

	[Token(Token = "0x600035D")]
	[Address(RVA = "0x9B57B0", Offset = "0x9B57B0", VA = "0x9B57B0")]
	public void colorButtonYellow()
	{
	}

	[Token(Token = "0x600035E")]
	[Address(RVA = "0x9B57C4", Offset = "0x9B57C4", VA = "0x9B57C4")]
	public void colorButtonGreen()
	{
	}

	[Token(Token = "0x600035F")]
	[Address(RVA = "0x9B57D8", Offset = "0x9B57D8", VA = "0x9B57D8")]
	public void colorButtonCyan()
	{
	}

	[Token(Token = "0x6000360")]
	[Address(RVA = "0x9B57EC", Offset = "0x9B57EC", VA = "0x9B57EC")]
	public void colorButtonBlue()
	{
	}

	[Token(Token = "0x6000361")]
	[Address(RVA = "0x9B5800", Offset = "0x9B5800", VA = "0x9B5800")]
	public void colorButtonPurple()
	{
	}

	[Token(Token = "0x6000362")]
	[Address(RVA = "0x9B5474", Offset = "0x9B5474", VA = "0x9B5474")]
	private void colorSwitch(Color color)
	{
	}

	[Token(Token = "0x6000363")]
	[Address(RVA = "0x9B5814", Offset = "0x9B5814", VA = "0x9B5814")]
	public materialColor()
	{
	}
}
[Token(Token = "0x2000079")]
public class MouseCameraControl : MonoBehaviour
{
	[Token(Token = "0x200007A")]
	public enum MouseButton
	{
		[Token(Token = "0x40004B1")]
		Left,
		[Token(Token = "0x40004B2")]
		Right,
		[Token(Token = "0x40004B3")]
		Middle,
		[Token(Token = "0x40004B4")]
		None
	}

	[Serializable]
	[Token(Token = "0x200007B")]
	public class Modifiers
	{
		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool leftAlt;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool leftControl;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		public bool leftShift;

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x9B5D70", Offset = "0x9B5D70", VA = "0x9B5D70")]
		public bool checkModifiers()
		{
			return default(bool);
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x9B5D60", Offset = "0x9B5D60", VA = "0x9B5D60")]
		public Modifiers()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200007C")]
	public class MouseControlConfiguration
	{
		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool activate;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public MouseButton mouseButton;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Modifiers modifiers;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float sensitivity;

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x9B5A70", Offset = "0x9B5A70", VA = "0x9B5A70")]
		public bool isActivated()
		{
			return default(bool);
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x9B5D58", Offset = "0x9B5D58", VA = "0x9B5D58")]
		public MouseControlConfiguration()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200007D")]
	public class MouseScrollConfiguration
	{
		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool activate;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Modifiers modifiers;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float sensitivity;

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x9B5AB0", Offset = "0x9B5AB0", VA = "0x9B5AB0")]
		public bool isActivated()
		{
			return default(bool);
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x9B5D68", Offset = "0x9B5D68", VA = "0x9B5D68")]
		public MouseScrollConfiguration()
		{
		}
	}

	[Token(Token = "0x40004A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MouseControlConfiguration yaw;

	[Token(Token = "0x40004A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MouseControlConfiguration pitch;

	[Token(Token = "0x40004A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public MouseControlConfiguration roll;

	[Token(Token = "0x40004A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public MouseControlConfiguration verticalTranslation;

	[Token(Token = "0x40004AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public MouseControlConfiguration horizontalTranslation;

	[Token(Token = "0x40004AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public MouseControlConfiguration depthTranslation;

	[Token(Token = "0x40004AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public MouseScrollConfiguration scroll;

	[Token(Token = "0x40004AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public string mouseHorizontalAxisName;

	[Token(Token = "0x40004AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public string mouseVerticalAxisName;

	[Token(Token = "0x40004AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public string scrollAxisName;

	[Token(Token = "0x6000364")]
	[Address(RVA = "0x9B581C", Offset = "0x9B581C", VA = "0x9B581C")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000365")]
	[Address(RVA = "0x9B5ADC", Offset = "0x9B5ADC", VA = "0x9B5ADC")]
	public MouseCameraControl()
	{
	}
}
[Token(Token = "0x200007E")]
public class moveLimit : MonoBehaviour
{
	[Token(Token = "0x40004BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 MinRange;

	[Token(Token = "0x40004C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Vector3 MaxRange;

	[Token(Token = "0x600036C")]
	[Address(RVA = "0x9B5DF0", Offset = "0x9B5DF0", VA = "0x9B5DF0")]
	private void Update()
	{
	}

	[Token(Token = "0x600036D")]
	[Address(RVA = "0x9B5EC4", Offset = "0x9B5EC4", VA = "0x9B5EC4")]
	public moveLimit()
	{
	}
}
[Token(Token = "0x200007F")]
public class PinchMove2 : MonoBehaviour
{
	[Token(Token = "0x40004C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float sensitivityX;

	[Token(Token = "0x40004C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float sensitivityY;

	[Token(Token = "0x40004C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float sensitivityZ;

	[Token(Token = "0x40004C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Touch touchZero;

	[Token(Token = "0x40004C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Touch touchOne;

	[Token(Token = "0x600036E")]
	[Address(RVA = "0x9B5EE4", Offset = "0x9B5EE4", VA = "0x9B5EE4")]
	private void Update()
	{
	}

	[Token(Token = "0x600036F")]
	[Address(RVA = "0x9B6130", Offset = "0x9B6130", VA = "0x9B6130")]
	public PinchMove2()
	{
	}
}
[Token(Token = "0x2000080")]
public class PinchMove3 : MonoBehaviour
{
	[Token(Token = "0x40004C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float sensitivityX;

	[Token(Token = "0x40004C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float sensitivityY;

	[Token(Token = "0x40004C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float sensitivityZ;

	[Token(Token = "0x40004C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Touch touchZero;

	[Token(Token = "0x40004CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Touch touchOne;

	[Token(Token = "0x6000370")]
	[Address(RVA = "0x9B6138", Offset = "0x9B6138", VA = "0x9B6138")]
	private void Update()
	{
	}

	[Token(Token = "0x6000371")]
	[Address(RVA = "0x9B6384", Offset = "0x9B6384", VA = "0x9B6384")]
	public PinchMove3()
	{
	}
}
[Token(Token = "0x2000081")]
public class PinchVerticalTranslation : MonoBehaviour
{
	[Token(Token = "0x40004CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float sensitivity;

	[Token(Token = "0x40004CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Touch touchZero;

	[Token(Token = "0x40004CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Touch touchOne;

	[Token(Token = "0x40004CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public Touch touchTwo;

	[Token(Token = "0x6000372")]
	[Address(RVA = "0x9B638C", Offset = "0x9B638C", VA = "0x9B638C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000373")]
	[Address(RVA = "0x9B6608", Offset = "0x9B6608", VA = "0x9B6608")]
	public PinchVerticalTranslation()
	{
	}
}
[Token(Token = "0x2000082")]
public class quitButton : MonoBehaviour
{
	[Token(Token = "0x6000374")]
	[Address(RVA = "0x9B6618", Offset = "0x9B6618", VA = "0x9B6618")]
	public void quit()
	{
	}

	[Token(Token = "0x6000375")]
	[Address(RVA = "0x9B6620", Offset = "0x9B6620", VA = "0x9B6620")]
	public quitButton()
	{
	}
}
[Token(Token = "0x2000083")]
public class rotateButton : MonoBehaviour
{
	[Token(Token = "0x40004CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform objectTransform;

	[Token(Token = "0x40004D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector3 rotation;

	[Token(Token = "0x6000376")]
	[Address(RVA = "0x9B6628", Offset = "0x9B6628", VA = "0x9B6628")]
	public void onButton()
	{
	}

	[Token(Token = "0x6000377")]
	[Address(RVA = "0x9B6674", Offset = "0x9B6674", VA = "0x9B6674")]
	public rotateButton()
	{
	}
}
[Token(Token = "0x2000084")]
public class rotation : MonoBehaviour
{
	[Token(Token = "0x40004D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float xRotation;

	[Token(Token = "0x40004D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float yRotation;

	[Token(Token = "0x40004D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float zRotation;

	[Token(Token = "0x6000378")]
	[Address(RVA = "0x9B667C", Offset = "0x9B667C", VA = "0x9B667C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000379")]
	[Address(RVA = "0x9B66D4", Offset = "0x9B66D4", VA = "0x9B66D4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600037A")]
	[Address(RVA = "0x9B66DC", Offset = "0x9B66DC", VA = "0x9B66DC")]
	public void clickOn()
	{
	}

	[Token(Token = "0x600037B")]
	[Address(RVA = "0x9B6734", Offset = "0x9B6734", VA = "0x9B6734")]
	public void clickOff()
	{
	}

	[Token(Token = "0x600037C")]
	[Address(RVA = "0x9B673C", Offset = "0x9B673C", VA = "0x9B673C")]
	private void rotate()
	{
	}

	[Token(Token = "0x600037D")]
	[Address(RVA = "0x9B678C", Offset = "0x9B678C", VA = "0x9B678C")]
	public rotation()
	{
	}
}
[Token(Token = "0x2000085")]
public class sunSlider : MonoBehaviour
{
	[Token(Token = "0x40004D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Slider mainSlider;

	[Token(Token = "0x40004D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector3 rotateAxis;

	[Token(Token = "0x600037E")]
	[Address(RVA = "0x9B6794", Offset = "0x9B6794", VA = "0x9B6794")]
	public void sun()
	{
	}

	[Token(Token = "0x600037F")]
	[Address(RVA = "0x9B68E0", Offset = "0x9B68E0", VA = "0x9B68E0")]
	public sunSlider()
	{
	}
}
[Token(Token = "0x2000086")]
public class toggleControl : MonoBehaviour
{
	[Token(Token = "0x2000087")]
	public enum FOM
	{
		[Token(Token = "0x40004ED")]
		none,
		[Token(Token = "0x40004EE")]
		outInstantly,
		[Token(Token = "0x40004EF")]
		outByTransparencyTintColor,
		[Token(Token = "0x40004F0")]
		outByTransparencyColor,
		[Token(Token = "0x40004F1")]
		outByCutoff,
		[Token(Token = "0x40004F2")]
		inInstantly,
		[Token(Token = "0x40004F3")]
		inByTransparencyTintColor,
		[Token(Token = "0x40004F4")]
		inByTransparencyColor,
		[Token(Token = "0x40004F5")]
		inByCutoff,
		[Token(Token = "0x40004F6")]
		outInInstantly,
		[Token(Token = "0x40004F7")]
		outInByTransparencyTintColor,
		[Token(Token = "0x40004F8")]
		outInByTransparencyColor,
		[Token(Token = "0x40004F9")]
		outInByCutoff
	}

	[Token(Token = "0x2000088")]
	private sealed class <outInNewPos>d__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public toggleControl <>4__this;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int i;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <t>5__2;

		[Token(Token = "0x17000034")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600038C")]
			[Address(RVA = "0x9B77E8", Offset = "0x9B77E8", VA = "0x9B77E8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000035")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600038E")]
			[Address(RVA = "0x9B7830", Offset = "0x9B7830", VA = "0x9B7830", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x9B73D4", Offset = "0x9B73D4", VA = "0x9B73D4")]
		[DebuggerHidden]
		public <outInNewPos>d__26(int <>1__state)
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x9B75E0", Offset = "0x9B75E0", VA = "0x9B75E0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x9B75E4", Offset = "0x9B75E4", VA = "0x9B75E4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x9B77F0", Offset = "0x9B77F0", VA = "0x9B77F0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40004D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public dispersePixels disperseScript;

	[Token(Token = "0x40004D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Camera mainCamera;

	[Token(Token = "0x40004D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int count;

	[Token(Token = "0x40004D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float[] executionInterval;

	[Token(Token = "0x40004DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject[] effects;

	[Token(Token = "0x40004DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float[] maxPartilceMultiplier;

	[Token(Token = "0x40004DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public FOM[] fadingMode;

	[Token(Token = "0x40004DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float[] fadingDelay;

	[Token(Token = "0x40004DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public float[] fadingDuration;

	[Token(Token = "0x40004DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public float[] outInDuration;

	[Token(Token = "0x40004E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Material[] materialSubstitute;

	[Token(Token = "0x40004E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public AudioClip[] audioClip;

	[Token(Token = "0x40004E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public string[] label;

	[Token(Token = "0x40004E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Text toggleText;

	[Token(Token = "0x40004E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Toggle toggleButton;

	[Token(Token = "0x40004E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Button prevButton;

	[Token(Token = "0x40004E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Button nextButton;

	[Token(Token = "0x40004E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Animator animator;

	[Token(Token = "0x40004E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Toggle animationToggle;

	[Token(Token = "0x40004E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Vector3 randPos;

	[Token(Token = "0x40004EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private Vector3 mousePos;

	[Token(Token = "0x40004EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public bool mobile;

	[Token(Token = "0x6000380")]
	[Address(RVA = "0x9B68F8", Offset = "0x9B68F8", VA = "0x9B68F8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000381")]
	[Address(RVA = "0x9B6E84", Offset = "0x9B6E84", VA = "0x9B6E84")]
	private void Update()
	{
	}

	[Token(Token = "0x6000382")]
	[Address(RVA = "0x9B70A0", Offset = "0x9B70A0", VA = "0x9B70A0")]
	public void onOff()
	{
	}

	[Token(Token = "0x6000383")]
	[Address(RVA = "0x9B7350", Offset = "0x9B7350", VA = "0x9B7350")]
	private IEnumerator outInNewPos(int i)
	{
		return null;
	}

	[Token(Token = "0x6000384")]
	[Address(RVA = "0x9B700C", Offset = "0x9B700C", VA = "0x9B700C")]
	public void next()
	{
	}

	[Token(Token = "0x6000385")]
	[Address(RVA = "0x9B7058", Offset = "0x9B7058", VA = "0x9B7058")]
	public void prev()
	{
	}

	[Token(Token = "0x6000386")]
	[Address(RVA = "0x9B69FC", Offset = "0x9B69FC", VA = "0x9B69FC")]
	private void nextPrevAction(int i)
	{
	}

	[Token(Token = "0x6000387")]
	[Address(RVA = "0x9B73FC", Offset = "0x9B73FC", VA = "0x9B73FC")]
	private void FOMConvert(int i)
	{
	}

	[Token(Token = "0x6000388")]
	[Address(RVA = "0x9B751C", Offset = "0x9B751C", VA = "0x9B751C")]
	public toggleControl()
	{
	}
}
[Token(Token = "0x2000089")]
public class toggleControlSingle : MonoBehaviour
{
	[Token(Token = "0x40004FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject[] effects;

	[Token(Token = "0x4000500")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ParticleSystem[] ps;

	[Token(Token = "0x4000501")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Toggle toggleButton;

	[Token(Token = "0x4000502")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Text toggleText;

	[Token(Token = "0x4000503")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Button prevButton;

	[Token(Token = "0x4000504")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Button nextButton;

	[Token(Token = "0x4000505")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int count;

	[Token(Token = "0x600038F")]
	[Address(RVA = "0x9B7838", Offset = "0x9B7838", VA = "0x9B7838")]
	private void Start()
	{
	}

	[Token(Token = "0x6000390")]
	[Address(RVA = "0x9B79B8", Offset = "0x9B79B8", VA = "0x9B79B8")]
	public void onOff()
	{
	}

	[Token(Token = "0x6000391")]
	[Address(RVA = "0x9B7A7C", Offset = "0x9B7A7C", VA = "0x9B7A7C")]
	public void next()
	{
	}

	[Token(Token = "0x6000392")]
	[Address(RVA = "0x9B7BCC", Offset = "0x9B7BCC", VA = "0x9B7BCC")]
	public void prev()
	{
	}

	[Token(Token = "0x6000393")]
	[Address(RVA = "0x9B7D2C", Offset = "0x9B7D2C", VA = "0x9B7D2C")]
	public toggleControlSingle()
	{
	}
}
[Token(Token = "0x200008A")]
public class toggleParticleSystem : MonoBehaviour
{
	[Token(Token = "0x4000506")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ParticleSystem ps;

	[Token(Token = "0x4000507")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Toggle toggleButton;

	[Token(Token = "0x6000394")]
	[Address(RVA = "0x9B7D34", Offset = "0x9B7D34", VA = "0x9B7D34")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000395")]
	[Address(RVA = "0x9B7D8C", Offset = "0x9B7D8C", VA = "0x9B7D8C")]
	public void onOff()
	{
	}

	[Token(Token = "0x6000396")]
	[Address(RVA = "0x9B7DCC", Offset = "0x9B7DCC", VA = "0x9B7DCC")]
	public toggleParticleSystem()
	{
	}
}
[Token(Token = "0x200008B")]
public class TouchRotate : MonoBehaviour
{
	[Token(Token = "0x4000508")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float sensitivityX;

	[Token(Token = "0x4000509")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float sensitivityY;

	[Token(Token = "0x400050A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float sensitivityZ;

	[Token(Token = "0x400050B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Touch touchZero;

	[Token(Token = "0x6000397")]
	[Address(RVA = "0x9B7DD4", Offset = "0x9B7DD4", VA = "0x9B7DD4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000398")]
	[Address(RVA = "0x9B7F1C", Offset = "0x9B7F1C", VA = "0x9B7F1C")]
	public TouchRotate()
	{
	}
}
[Token(Token = "0x200008C")]
public class dispersePixels : MonoBehaviour
{
	[Token(Token = "0x200008D")]
	public enum FOM
	{
		[Token(Token = "0x400054A")]
		none,
		[Token(Token = "0x400054B")]
		outInstantly,
		[Token(Token = "0x400054C")]
		outByTransparencyTintColor,
		[Token(Token = "0x400054D")]
		outByTransparencyColor,
		[Token(Token = "0x400054E")]
		outByCutoff,
		[Token(Token = "0x400054F")]
		inInstantly,
		[Token(Token = "0x4000550")]
		inByTransparencyTintColor,
		[Token(Token = "0x4000551")]
		inByTransparencyColor,
		[Token(Token = "0x4000552")]
		inByCutoff,
		[Token(Token = "0x4000553")]
		outInInstantly,
		[Token(Token = "0x4000554")]
		outInByTransparencyTintColor,
		[Token(Token = "0x4000555")]
		outInByTransparencyColor,
		[Token(Token = "0x4000556")]
		outInByCutoff
	}

	[Token(Token = "0x200008E")]
	private sealed class <RestoreOrgTimeScale>d__64 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public dispersePixels <>4__this;

		[Token(Token = "0x17000036")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003AB")]
			[Address(RVA = "0x9BD3E0", Offset = "0x9BD3E0", VA = "0x9BD3E0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000037")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003AD")]
			[Address(RVA = "0x9BD428", Offset = "0x9BD428", VA = "0x9BD428", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x9BD2D0", Offset = "0x9BD2D0", VA = "0x9BD2D0")]
		[DebuggerHidden]
		public <RestoreOrgTimeScale>d__64(int <>1__state)
		{
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x9BD2F8", Offset = "0x9BD2F8", VA = "0x9BD2F8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x9BD2FC", Offset = "0x9BD2FC", VA = "0x9BD2FC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x9BD3E8", Offset = "0x9BD3E8", VA = "0x9BD3E8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200008F")]
	private sealed class <TintParticles>d__68 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public dispersePixels <>4__this;

		[Token(Token = "0x400055D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int i;

		[Token(Token = "0x17000038")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003B1")]
			[Address(RVA = "0x9BDF70", Offset = "0x9BDF70", VA = "0x9BDF70", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000039")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003B3")]
			[Address(RVA = "0x9BDFB8", Offset = "0x9BDFB8", VA = "0x9BDFB8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x9BD430", Offset = "0x9BD430", VA = "0x9BD430")]
		[DebuggerHidden]
		public <TintParticles>d__68(int <>1__state)
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x9BD458", Offset = "0x9BD458", VA = "0x9BD458", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x9BD45C", Offset = "0x9BD45C", VA = "0x9BD45C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x9BDF78", Offset = "0x9BDF78", VA = "0x9BDF78", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000090")]
	private sealed class <FadeTargetObject>d__70 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400055F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public dispersePixels <>4__this;

		[Token(Token = "0x4000561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int i;

		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <t>5__2;

		[Token(Token = "0x1700003A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003B7")]
			[Address(RVA = "0x9C038C", Offset = "0x9C038C", VA = "0x9C038C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003B9")]
			[Address(RVA = "0x9C03D4", Offset = "0x9C03D4", VA = "0x9C03D4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x9BDFC0", Offset = "0x9BDFC0", VA = "0x9BDFC0")]
		[DebuggerHidden]
		public <FadeTargetObject>d__70(int <>1__state)
		{
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x9BDFE8", Offset = "0x9BDFE8", VA = "0x9BDFE8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x9BDFEC", Offset = "0x9BDFEC", VA = "0x9BDFEC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x9C0394", Offset = "0x9C0394", VA = "0x9C0394", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400050C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float executionInterval;

	[Token(Token = "0x400050D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject[] targetObject;

	[Token(Token = "0x400050E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Camera mainCamera;

	[Token(Token = "0x400050F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Camera disperseCamera;

	[Token(Token = "0x4000510")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Range(0f, 31f)]
	public int layerIndex;

	[Token(Token = "0x4000511")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public bool randomizeLayer;

	[Token(Token = "0x4000512")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Range(1f, 32f)]
	public int downsampling;

	[Token(Token = "0x4000513")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public bool transparentTarget;

	[Token(Token = "0x4000514")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Animator animator;

	[Token(Token = "0x4000515")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public ParticleSystem disperseParticle;

	[Token(Token = "0x4000516")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool reinstantiate;

	[Token(Token = "0x4000517")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public float destroyDelay;

	[Token(Token = "0x4000518")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public bool destroyOnDisable;

	[Token(Token = "0x4000519")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public float tintingTime;

	[Token(Token = "0x400051A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public float sizeMultiplier;

	[Token(Token = "0x400051B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public int[] maxParticles;

	[Token(Token = "0x400051C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public float maxParticlesMultiplier;

	[Token(Token = "0x400051D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Vector3[] emitterBoxSize;

	[Token(Token = "0x400051E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Color gizmosColor;

	[Token(Token = "0x400051F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Vector3[] pSystemOffset;

	[Token(Token = "0x4000520")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public FOM fadingMode;

	[Token(Token = "0x4000521")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public float fadingDelay;

	[Token(Token = "0x4000522")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public float fadingDuration;

	[Token(Token = "0x4000523")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	public bool animateAfterFadeIn;

	[Token(Token = "0x4000524")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Vector3 outInNewPosition;

	[Token(Token = "0x4000525")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	public float outInDuration;

	[Token(Token = "0x4000526")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Material[] materialSubstitute;

	[Token(Token = "0x4000527")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public Material[] materialOriginal;

	[Token(Token = "0x4000528")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public bool playSound;

	[Token(Token = "0x4000529")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public AudioSource audioSource;

	[Token(Token = "0x400052A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public AudioClip audioClip;

	[Token(Token = "0x400052B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public int soundOrigin;

	[Token(Token = "0x400052C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	public Vector3 soundOffset;

	[Token(Token = "0x400052D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public float soundDelay;

	[Token(Token = "0x400052E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	private float _orgTimeScale;

	[Token(Token = "0x400052F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private int[] _componentTypes;

	[Token(Token = "0x4000530")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private Renderer[] _renderers;

	[Token(Token = "0x4000531")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private Image[] _UI_images;

	[Token(Token = "0x4000532")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private Text[] _UI_texts;

	[Token(Token = "0x4000533")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private int[] _orgObjectLayers;

	[Token(Token = "0x4000534")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private GameObject _disperseCameraClone;

	[Token(Token = "0x4000535")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private Camera _disperseCamera;

	[Token(Token = "0x4000536")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private Rect _viewRect;

	[Token(Token = "0x4000537")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private Vector2 _viewRectDownsampled;

	[Token(Token = "0x4000538")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private RenderTexture _renderTexture;

	[Token(Token = "0x4000539")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private Texture2D _screenCapture1;

	[Token(Token = "0x400053A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private Texture2D _screenCapture2;

	[Token(Token = "0x400053B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private Canvas[] _UI_canvases;

	[Token(Token = "0x400053C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private GameObject[] _PS_clones;

	[Token(Token = "0x400053D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private ParticleSystem[] _PS_components;

	[Token(Token = "0x400053E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private ParticleSystem.MainModule[] _PSM_mains;

	[Token(Token = "0x400053F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private float _PS_orgGravity;

	[Token(Token = "0x4000540")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private particleHomecoming[] _particleHomecomings;

	[Token(Token = "0x4000541")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private Material[] _materials;

	[Token(Token = "0x4000542")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private Color[] _orgColorRGBA;

	[Token(Token = "0x4000543")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private float[] _orgColorAlpha;

	[Token(Token = "0x4000544")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	private GameObject _audioClone;

	[Token(Token = "0x4000545")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	private AudioSource _audio;

	[Token(Token = "0x4000546")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	private Collider[] _colliders;

	[Token(Token = "0x4000547")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	private int _FOMifGroup;

	[Token(Token = "0x4000548")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	private bool[] _materialChangeCondition;

	[Token(Token = "0x6000399")]
	[Address(RVA = "0x9B7F24", Offset = "0x9B7F24", VA = "0x9B7F24")]
	private void Awake()
	{
	}

	[Token(Token = "0x600039A")]
	[Address(RVA = "0x9B9220", Offset = "0x9B9220", VA = "0x9B9220")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600039B")]
	[Address(RVA = "0x9BB190", Offset = "0x9BB190", VA = "0x9BB190")]
	private IEnumerator RestoreOrgTimeScale()
	{
		return null;
	}

	[Token(Token = "0x600039C")]
	[Address(RVA = "0x9B94A4", Offset = "0x9B94A4", VA = "0x9B94A4")]
	private void DefineIfConditions()
	{
	}

	[Token(Token = "0x600039D")]
	[Address(RVA = "0x9B9600", Offset = "0x9B9600", VA = "0x9B9600")]
	private void ShootScreenCapture()
	{
	}

	[Token(Token = "0x600039E")]
	[Address(RVA = "0x9BA298", Offset = "0x9BA298", VA = "0x9BA298")]
	private void InitiateParticleSystems()
	{
	}

	[Token(Token = "0x600039F")]
	[Address(RVA = "0x9BB204", Offset = "0x9BB204", VA = "0x9BB204")]
	private IEnumerator TintParticles(int i)
	{
		return null;
	}

	[Token(Token = "0x60003A0")]
	[Address(RVA = "0x9BB288", Offset = "0x9BB288", VA = "0x9BB288")]
	private Vector2 ClampDownsampleParticlePos(Vector2 _position)
	{
		return default(Vector2);
	}

	[Token(Token = "0x60003A1")]
	[Address(RVA = "0x9BB10C", Offset = "0x9BB10C", VA = "0x9BB10C")]
	private IEnumerator FadeTargetObject(int i)
	{
		return null;
	}

	[Token(Token = "0x60003A2")]
	[Address(RVA = "0x9BB324", Offset = "0x9BB324", VA = "0x9BB324")]
	private void WarnUnsupportedFOM(string _target, string _mode)
	{
	}

	[Token(Token = "0x60003A3")]
	[Address(RVA = "0x9BB6A8", Offset = "0x9BB6A8", VA = "0x9BB6A8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60003A4")]
	[Address(RVA = "0x9BBE44", Offset = "0x9BBE44", VA = "0x9BBE44")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60003A5")]
	[Address(RVA = "0x9BBC8C", Offset = "0x9BBC8C", VA = "0x9BBC8C")]
	private void Annihilate()
	{
	}

	[Token(Token = "0x60003A6")]
	[Address(RVA = "0x9BBE48", Offset = "0x9BBE48", VA = "0x9BBE48")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x60003A7")]
	[Address(RVA = "0x9BC158", Offset = "0x9BC158", VA = "0x9BC158")]
	public dispersePixels()
	{
	}
}
[Token(Token = "0x2000091")]
public class dispersePixelsInitiator : MonoBehaviour
{
	[Token(Token = "0x2000092")]
	private sealed class <executeDispersePixels>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int i;

		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public dispersePixelsInitiator <>4__this;

		[Token(Token = "0x1700003C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003C1")]
			[Address(RVA = "0x9C0684", Offset = "0x9C0684", VA = "0x9C0684", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003C3")]
			[Address(RVA = "0x9C06CC", Offset = "0x9C06CC", VA = "0x9C06CC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x9C04BC", Offset = "0x9C04BC", VA = "0x9C04BC")]
		[DebuggerHidden]
		public <executeDispersePixels>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x9C055C", Offset = "0x9C055C", VA = "0x9C055C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x9C0560", Offset = "0x9C0560", VA = "0x9C0560", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x9C068C", Offset = "0x9C068C", VA = "0x9C068C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000563")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float executionInterval;

	[Token(Token = "0x4000564")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public dispersePixels[] dispersePixelsObjects;

	[Token(Token = "0x4000565")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private uint seed;

	[Token(Token = "0x60003BA")]
	[Address(RVA = "0x9C03DC", Offset = "0x9C03DC", VA = "0x9C03DC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60003BB")]
	[Address(RVA = "0x9C0438", Offset = "0x9C0438", VA = "0x9C0438")]
	private IEnumerator executeDispersePixels(int i)
	{
		return null;
	}

	[Token(Token = "0x60003BC")]
	[Address(RVA = "0x9C04E4", Offset = "0x9C04E4", VA = "0x9C04E4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60003BD")]
	[Address(RVA = "0x9C0548", Offset = "0x9C0548", VA = "0x9C0548")]
	public dispersePixelsInitiator()
	{
	}
}
[Token(Token = "0x2000093")]
public class particleHomecoming : MonoBehaviour
{
	[Token(Token = "0x2000094")]
	private sealed class <getStartPosition>d__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public particleHomecoming <>4__this;

		[Token(Token = "0x4000577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <t>5__2;

		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 <positionDiff>5__3;

		[Token(Token = "0x1700003E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003CA")]
			[Address(RVA = "0x9C0D10", Offset = "0x9C0D10", VA = "0x9C0D10", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003CC")]
			[Address(RVA = "0x9C0D58", Offset = "0x9C0D58", VA = "0x9C0D58", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x9C0824", Offset = "0x9C0824", VA = "0x9C0824")]
		[DebuggerHidden]
		public <getStartPosition>d__11(int <>1__state)
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x9C0868", Offset = "0x9C0868", VA = "0x9C0868", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x9C086C", Offset = "0x9C086C", VA = "0x9C086C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x9C0D18", Offset = "0x9C0D18", VA = "0x9C0D18", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400056A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float speed;

	[Token(Token = "0x400056B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float maxSpeed;

	[Token(Token = "0x400056C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float homingDelay;

	[Token(Token = "0x400056D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool teleport;

	[Token(Token = "0x400056E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector3 newPositionVector;

	[Token(Token = "0x400056F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform newPositionTransform;

	[Token(Token = "0x4000570")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private ParticleSystem m_System;

	[Token(Token = "0x4000571")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private ParticleSystem.Particle[] m_Particles;

	[Token(Token = "0x4000572")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3[] startPosition;

	[Token(Token = "0x4000573")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private int numParticlesAlive;

	[Token(Token = "0x60003C4")]
	[Address(RVA = "0x9C06D4", Offset = "0x9C06D4", VA = "0x9C06D4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60003C5")]
	[Address(RVA = "0x9C07B0", Offset = "0x9C07B0", VA = "0x9C07B0")]
	private IEnumerator getStartPosition()
	{
		return null;
	}

	[Token(Token = "0x60003C6")]
	[Address(RVA = "0x9C084C", Offset = "0x9C084C", VA = "0x9C084C")]
	public particleHomecoming()
	{
	}
}
[Token(Token = "0x2000095")]
public class selfDestroy : MonoBehaviour
{
	[Token(Token = "0x4000579")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float delayInSecond;

	[Token(Token = "0x400057A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float activateDelay;

	[Token(Token = "0x400057B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject objToActivate;

	[Token(Token = "0x400057C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public MonoBehaviour monoToEnable;

	[Token(Token = "0x400057D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public MeshRenderer monoToDeactiave;

	[Token(Token = "0x60003CD")]
	[Address(RVA = "0x9C0D60", Offset = "0x9C0D60", VA = "0x9C0D60")]
	private void Start()
	{
	}

	[Token(Token = "0x60003CE")]
	[Address(RVA = "0x9C0DDC", Offset = "0x9C0DDC", VA = "0x9C0DDC")]
	private void Update()
	{
	}

	[Token(Token = "0x60003CF")]
	[Address(RVA = "0x9C0F4C", Offset = "0x9C0F4C", VA = "0x9C0F4C")]
	public selfDestroy()
	{
	}
}
[Token(Token = "0x2000096")]
public class HUD : MonoBehaviour
{
	[Token(Token = "0x400057E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Game game;

	[Token(Token = "0x400057F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private CommonVR vr;

	[Token(Token = "0x4000580")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Text fpsText;

	[Token(Token = "0x4000581")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Text heightText;

	[Token(Token = "0x4000582")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Text scoreText;

	[Token(Token = "0x4000583")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Text multiText;

	[Token(Token = "0x4000584")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Text healthText;

	[Token(Token = "0x4000585")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Material comboMat;

	[Token(Token = "0x4000586")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject comboCircle;

	[Token(Token = "0x4000587")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float fpsCount;

	[Token(Token = "0x4000588")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private float[] fpsSamples;

	[Token(Token = "0x4000589")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float heightMeter;

	[Token(Token = "0x400058A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public bool menusereHeight;

	[Token(Token = "0x400058B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private int prevScore;

	[Token(Token = "0x400058C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private int prevMul;

	[Token(Token = "0x400058D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private float comboValueA;

	[Token(Token = "0x400058E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private float comboValueB;

	[Token(Token = "0x400058F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private float time_to_save_height;

	[Token(Token = "0x4000590")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public GameObject comboSucessFX;

	[Token(Token = "0x4000591")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private float comboSucessProgress;

	[Token(Token = "0x4000592")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public GameObject comboSphereBack;

	[Token(Token = "0x4000593")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Material comboSphereMat;

	[Token(Token = "0x60003D0")]
	[Address(RVA = "0x9C0F5C", Offset = "0x9C0F5C", VA = "0x9C0F5C")]
	private void Start()
	{
	}

	[Token(Token = "0x60003D1")]
	[Address(RVA = "0x9C137C", Offset = "0x9C137C", VA = "0x9C137C")]
	public void Show()
	{
	}

	[Token(Token = "0x60003D2")]
	[Address(RVA = "0x9C13A0", Offset = "0x9C13A0", VA = "0x9C13A0")]
	public void OnComboSucess()
	{
	}

	[Token(Token = "0x60003D3")]
	[Address(RVA = "0x9C142C", Offset = "0x9C142C", VA = "0x9C142C")]
	public void Hide()
	{
	}

	[Token(Token = "0x60003D4")]
	[Address(RVA = "0x9C1450", Offset = "0x9C1450", VA = "0x9C1450")]
	private void UpdateDebug()
	{
	}

	[Token(Token = "0x60003D5")]
	[Address(RVA = "0x9C1964", Offset = "0x9C1964", VA = "0x9C1964")]
	private void UpdateComboCircle()
	{
	}

	[Token(Token = "0x60003D6")]
	[Address(RVA = "0x9C1CA4", Offset = "0x9C1CA4", VA = "0x9C1CA4")]
	private bool UpdateComboSucess()
	{
		return default(bool);
	}

	[Token(Token = "0x60003D7")]
	[Address(RVA = "0x9C213C", Offset = "0x9C213C", VA = "0x9C213C")]
	private void Update()
	{
	}

	[Token(Token = "0x60003D8")]
	[Address(RVA = "0x9C27D4", Offset = "0x9C27D4", VA = "0x9C27D4")]
	public void SetHealth(int health, int max_health)
	{
	}

	[Token(Token = "0x60003D9")]
	[Address(RVA = "0x9C240C", Offset = "0x9C240C", VA = "0x9C240C")]
	private void UpdateOrientation(float dt)
	{
	}

	[Token(Token = "0x60003DA")]
	[Address(RVA = "0x9C28D8", Offset = "0x9C28D8", VA = "0x9C28D8")]
	private void AdjustToStandardEnemy(Enemy enemy)
	{
	}

	[Token(Token = "0x60003DB")]
	[Address(RVA = "0x9C2638", Offset = "0x9C2638", VA = "0x9C2638")]
	private void AdjustToEnemy()
	{
	}

	[Token(Token = "0x60003DC")]
	[Address(RVA = "0x9C2F54", Offset = "0x9C2F54", VA = "0x9C2F54")]
	public HUD()
	{
	}
}
[Token(Token = "0x2000097")]
public class LevelCompleted : MonoBehaviour
{
	[Token(Token = "0x4000594")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Game m_Game;

	[Token(Token = "0x4000595")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool m_LoadHUB;

	[Token(Token = "0x4000596")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float m_TimeToHide;

	[Token(Token = "0x60003DD")]
	[Address(RVA = "0x9C2FE4", Offset = "0x9C2FE4", VA = "0x9C2FE4")]
	public void Show()
	{
	}

	[Token(Token = "0x60003DE")]
	[Address(RVA = "0x9C3008", Offset = "0x9C3008", VA = "0x9C3008")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60003DF")]
	[Address(RVA = "0x9C3180", Offset = "0x9C3180", VA = "0x9C3180")]
	public void Hide()
	{
	}

	[Token(Token = "0x60003E0")]
	[Address(RVA = "0x9C3154", Offset = "0x9C3154", VA = "0x9C3154")]
	private void UpdateDebugInputs()
	{
	}

	[Token(Token = "0x60003E1")]
	[Address(RVA = "0x9C3190", Offset = "0x9C3190", VA = "0x9C3190")]
	public LevelCompleted()
	{
	}
}
[Token(Token = "0x2000098")]
public class ScorePanel : MonoBehaviour
{
	[Token(Token = "0x4000597")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Game m_Game;

	[Token(Token = "0x4000598")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public FlatCounter[] m_ScoreMuls;

	[Token(Token = "0x4000599")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public FlatCounter m_Score;

	[Token(Token = "0x400059A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public MeshRenderer m_MulCircle;

	[Token(Token = "0x400059B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Color m_PositiveColor;

	[Token(Token = "0x400059C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Color m_NegativeColor;

	[Token(Token = "0x400059D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Color m_BaseColor;

	[Token(Token = "0x400059E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private float m_PrevMulProgressVal;

	[Token(Token = "0x400059F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private int m_PrevMulCount;

	[Token(Token = "0x40005A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float m_MulImproveEffect;

	[Token(Token = "0x40005A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private float m_LocalScore;

	[Token(Token = "0x60003E2")]
	[Address(RVA = "0x9C31A0", Offset = "0x9C31A0", VA = "0x9C31A0")]
	private void Start()
	{
	}

	[Token(Token = "0x60003E3")]
	[Address(RVA = "0x9C3258", Offset = "0x9C3258", VA = "0x9C3258")]
	private void UpdateScoreCounter(int score)
	{
	}

	[Token(Token = "0x60003E4")]
	[Address(RVA = "0x9C32C8", Offset = "0x9C32C8", VA = "0x9C32C8")]
	private void UpdateScoreMulAnimation()
	{
	}

	[Token(Token = "0x60003E5")]
	[Address(RVA = "0x9C35D8", Offset = "0x9C35D8", VA = "0x9C35D8")]
	private void Update()
	{
	}

	[Token(Token = "0x60003E6")]
	[Address(RVA = "0x9C3668", Offset = "0x9C3668", VA = "0x9C3668")]
	private void UpdateOrientation()
	{
	}

	[Token(Token = "0x60003E7")]
	[Address(RVA = "0x9C3884", Offset = "0x9C3884", VA = "0x9C3884")]
	public ScorePanel()
	{
	}
}
[Token(Token = "0x2000099")]
public class movex : MonoBehaviour
{
	[Token(Token = "0x40005A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float speed;

	[Token(Token = "0x40005A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float yspeed;

	[Token(Token = "0x40005A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float oldY;

	[Token(Token = "0x60003E8")]
	[Address(RVA = "0x9C38BC", Offset = "0x9C38BC", VA = "0x9C38BC")]
	private void Start()
	{
	}

	[Token(Token = "0x60003E9")]
	[Address(RVA = "0x9C38E8", Offset = "0x9C38E8", VA = "0x9C38E8")]
	private void Update()
	{
	}

	[Token(Token = "0x60003EA")]
	[Address(RVA = "0x9C3990", Offset = "0x9C3990", VA = "0x9C3990")]
	public movex()
	{
	}
}
[Token(Token = "0x200009A")]
public class ItemsList : MonoBehaviour
{
	[Token(Token = "0x40005A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private XRHandController <actveHand>k__BackingField;

	[Token(Token = "0x40005A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public UIItem prefab;

	[Token(Token = "0x40005A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int noVisibleItems;

	[Token(Token = "0x40005A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float radius;

	[Token(Token = "0x40005A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float visAngle;

	[Token(Token = "0x40005AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform center;

	[Token(Token = "0x40005AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Transform rotator;

	[Token(Token = "0x40005AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private UIItem[] items;

	[Token(Token = "0x40005AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float rotateSpeed;

	[Token(Token = "0x40005AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private float rotate;

	[Token(Token = "0x40005AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float touchYPos;

	[Token(Token = "0x40005B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public int noItems;

	[Token(Token = "0x40005B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public bool hideWhenInactive;

	[Token(Token = "0x40005B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
	public bool hidden;

	[Token(Token = "0x40005B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
	public bool useProgressEvent;

	[Token(Token = "0x40005B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	protected int selectedIDX;

	[Token(Token = "0x40005B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool waitToHandOut;

	[Token(Token = "0x40005B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
	public bool loopedList;

	[Token(Token = "0x40005B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private float minRotate;

	[Token(Token = "0x40005B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float maxRotate;

	[Token(Token = "0x40005B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private float timeFromTouch;

	[Token(Token = "0x17000040")]
	public XRHandController actveHand
	{
		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x9C39A0", Offset = "0x9C39A0", VA = "0x9C39A0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x9C39A8", Offset = "0x9C39A8", VA = "0x9C39A8")]
		set
		{
		}
	}

	[Token(Token = "0x60003ED")]
	[Address(RVA = "0x9C39B0", Offset = "0x9C39B0", VA = "0x9C39B0")]
	public bool IsHidden()
	{
		return default(bool);
	}

	[Token(Token = "0x60003EE")]
	[Address(RVA = "0x9C39B8", Offset = "0x9C39B8", VA = "0x9C39B8", Slot = "4")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x60003EF")]
	[Address(RVA = "0x9C3CDC", Offset = "0x9C3CDC", VA = "0x9C3CDC")]
	public UIItem GetItemByIDX(int idx)
	{
		return null;
	}

	[Token(Token = "0x60003F0")]
	[Address(RVA = "0x9C3C14", Offset = "0x9C3C14", VA = "0x9C3C14")]
	private float CalculateItemAngle(int i, ref int steps)
	{
		return default(float);
	}

	[Token(Token = "0x60003F1")]
	[Address(RVA = "0x9C3D38", Offset = "0x9C3D38", VA = "0x9C3D38")]
	private void UpdateRotation()
	{
	}

	[Token(Token = "0x60003F2")]
	[Address(RVA = "0x9C3F30", Offset = "0x9C3F30", VA = "0x9C3F30")]
	private void SelectElementAfterRoll()
	{
	}

	[Token(Token = "0x60003F3")]
	[Address(RVA = "0x9C43FC", Offset = "0x9C43FC", VA = "0x9C43FC")]
	private void ShowItems()
	{
	}

	[Token(Token = "0x60003F4")]
	[Address(RVA = "0x9C4484", Offset = "0x9C4484", VA = "0x9C4484", Slot = "5")]
	public virtual void OnShowItems()
	{
	}

	[Token(Token = "0x60003F5")]
	[Address(RVA = "0x9C4488", Offset = "0x9C4488", VA = "0x9C4488", Slot = "6")]
	public virtual void OnHideItems()
	{
	}

	[Token(Token = "0x60003F6")]
	[Address(RVA = "0x9C448C", Offset = "0x9C448C", VA = "0x9C448C")]
	private void HideItems()
	{
	}

	[Token(Token = "0x60003F7")]
	[Address(RVA = "0x9C4544", Offset = "0x9C4544", VA = "0x9C4544")]
	private void Update()
	{
	}

	[Token(Token = "0x60003F8")]
	[Address(RVA = "0x9C45B4", Offset = "0x9C45B4", VA = "0x9C45B4", Slot = "7")]
	public virtual void SpecificUpdate()
	{
	}

	[Token(Token = "0x60003F9")]
	[Address(RVA = "0x9C45B8", Offset = "0x9C45B8", VA = "0x9C45B8")]
	public void SetMoveSpeed(float diff)
	{
	}

	[Token(Token = "0x60003FA")]
	[Address(RVA = "0x9C45EC", Offset = "0x9C45EC", VA = "0x9C45EC")]
	public void SetTouchPos(Vector3 touch_pos)
	{
	}

	[Token(Token = "0x60003FB")]
	[Address(RVA = "0x9C467C", Offset = "0x9C467C", VA = "0x9C467C", Slot = "8")]
	public virtual void FillData(UIItem item, int idx)
	{
	}

	[Token(Token = "0x60003FC")]
	[Address(RVA = "0x9C4680", Offset = "0x9C4680", VA = "0x9C4680", Slot = "9")]
	public virtual void OnSelect(int idx)
	{
	}

	[Token(Token = "0x60003FD")]
	[Address(RVA = "0x9C4714", Offset = "0x9C4714", VA = "0x9C4714", Slot = "10")]
	public virtual void OnFillProgress()
	{
	}

	[Token(Token = "0x60003FE")]
	[Address(RVA = "0x9C47E8", Offset = "0x9C47E8", VA = "0x9C47E8")]
	public void RefreshList()
	{
	}

	[Token(Token = "0x60003FF")]
	[Address(RVA = "0x9C4848", Offset = "0x9C4848", VA = "0x9C4848")]
	public void SetSelected(int idx)
	{
	}

	[Token(Token = "0x6000400")]
	[Address(RVA = "0x9C487C", Offset = "0x9C487C", VA = "0x9C487C")]
	public void OnTouch()
	{
	}

	[Token(Token = "0x6000401")]
	[Address(RVA = "0x9C4948", Offset = "0x9C4948", VA = "0x9C4948")]
	public ItemsList()
	{
	}
}
[Token(Token = "0x200009B")]
public class CircleSlider : MonoBehaviour
{
	[Token(Token = "0x40005BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool b;

	[Token(Token = "0x40005BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Image image;

	[Token(Token = "0x40005BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float speed;

	[Token(Token = "0x40005BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float time;

	[Token(Token = "0x40005BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Text progress;

	[Token(Token = "0x6000402")]
	[Address(RVA = "0x9C497C", Offset = "0x9C497C", VA = "0x9C497C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000403")]
	[Address(RVA = "0x9C4AB8", Offset = "0x9C4AB8", VA = "0x9C4AB8")]
	public CircleSlider()
	{
	}
}
[Token(Token = "0x200009C")]
public class CircleSliderA : MonoBehaviour
{
	[Token(Token = "0x40005BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool b;

	[Token(Token = "0x40005C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Image image;

	[Token(Token = "0x40005C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float speed;

	[Token(Token = "0x40005C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float time;

	[Token(Token = "0x40005C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Text progress;

	[Token(Token = "0x6000404")]
	[Address(RVA = "0x9C4AD0", Offset = "0x9C4AD0", VA = "0x9C4AD0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000405")]
	[Address(RVA = "0x9C4B48", Offset = "0x9C4B48", VA = "0x9C4B48")]
	private void Update()
	{
	}

	[Token(Token = "0x6000406")]
	[Address(RVA = "0x9C4C84", Offset = "0x9C4C84", VA = "0x9C4C84")]
	public CircleSliderA()
	{
	}
}
[Token(Token = "0x200009D")]
public class FourCirclePercent : MonoBehaviour
{
	[Token(Token = "0x40005C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Range(0f, 9999f)]
	public float no1;

	[Token(Token = "0x40005C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Range(0f, 9999f)]
	public float no2;

	[Token(Token = "0x40005C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Range(0f, 9999f)]
	public float no3;

	[Token(Token = "0x40005C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Range(0f, 9999f)]
	public float no4;

	[Token(Token = "0x40005C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Image a;

	[Token(Token = "0x40005C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Image b;

	[Token(Token = "0x40005CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Image c;

	[Token(Token = "0x40005CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Image d;

	[Token(Token = "0x40005CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Text t1;

	[Token(Token = "0x40005CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Text t2;

	[Token(Token = "0x40005CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Text t3;

	[Token(Token = "0x40005CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Text t4;

	[Token(Token = "0x6000407")]
	[Address(RVA = "0x9C4C9C", Offset = "0x9C4C9C", VA = "0x9C4C9C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000408")]
	[Address(RVA = "0x9C4CA8", Offset = "0x9C4CA8", VA = "0x9C4CA8")]
	public void UpdatePercent(float n1, float n2, float n3, float n4)
	{
	}

	[Token(Token = "0x6000409")]
	[Address(RVA = "0x9C4F58", Offset = "0x9C4F58", VA = "0x9C4F58")]
	public FourCirclePercent()
	{
	}
}
[Token(Token = "0x200009E")]
public class FourPercent : MonoBehaviour
{
	[Token(Token = "0x40005D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Range(0f, 100f)]
	public float no1;

	[Token(Token = "0x40005D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Range(0f, 100f)]
	public float no2;

	[Token(Token = "0x40005D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Range(0f, 100f)]
	public float no3;

	[Token(Token = "0x40005D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Range(0f, 100f)]
	public float no4;

	[Token(Token = "0x40005D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public RectTransform a;

	[Token(Token = "0x40005D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public RectTransform b;

	[Token(Token = "0x40005D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public RectTransform c;

	[Token(Token = "0x40005D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public RectTransform d;

	[Token(Token = "0x40005D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Text t1;

	[Token(Token = "0x40005D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Text t2;

	[Token(Token = "0x40005DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Text t3;

	[Token(Token = "0x40005DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Text t4;

	[Token(Token = "0x600040A")]
	[Address(RVA = "0x9C4F60", Offset = "0x9C4F60", VA = "0x9C4F60")]
	private void Update()
	{
	}

	[Token(Token = "0x600040B")]
	[Address(RVA = "0x9C4F6C", Offset = "0x9C4F6C", VA = "0x9C4F6C")]
	public void UpdatePercent(float n1, float n2, float n3, float n4)
	{
	}

	[Token(Token = "0x600040C")]
	[Address(RVA = "0x9C537C", Offset = "0x9C537C", VA = "0x9C537C")]
	public FourPercent()
	{
	}
}
[Token(Token = "0x200009F")]
public class GetTime : MonoBehaviour
{
	[Token(Token = "0x40005DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text text;

	[Token(Token = "0x600040D")]
	[Address(RVA = "0x9C538C", Offset = "0x9C538C", VA = "0x9C538C")]
	private void Update()
	{
	}

	[Token(Token = "0x600040E")]
	[Address(RVA = "0x9C5424", Offset = "0x9C5424", VA = "0x9C5424")]
	public GetTime()
	{
	}
}
[Token(Token = "0x20000A0")]
public class HillPercent : MonoBehaviour
{
	[Token(Token = "0x40005DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Range(0f, 100f)]
	public float no1;

	[Token(Token = "0x40005DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform a;

	[Token(Token = "0x40005DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Text t1;

	[Token(Token = "0x600040F")]
	[Address(RVA = "0x9C542C", Offset = "0x9C542C", VA = "0x9C542C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000410")]
	[Address(RVA = "0x9C5434", Offset = "0x9C5434", VA = "0x9C5434")]
	public void UpdatePercent(float n1)
	{
	}

	[Token(Token = "0x6000411")]
	[Address(RVA = "0x9C5540", Offset = "0x9C5540", VA = "0x9C5540")]
	public HillPercent()
	{
	}
}
[Token(Token = "0x20000A1")]
public class ImageBoard : MonoBehaviour
{
	[Token(Token = "0x6000412")]
	[Address(RVA = "0x9C5550", Offset = "0x9C5550", VA = "0x9C5550")]
	private void Start()
	{
	}

	[Token(Token = "0x6000413")]
	[Address(RVA = "0x9C55D8", Offset = "0x9C55D8", VA = "0x9C55D8")]
	public ImageBoard()
	{
	}
}
[Token(Token = "0x20000A2")]
public class JustRotate : MonoBehaviour
{
	[Token(Token = "0x40005E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool canRotate;

	[Token(Token = "0x40005E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float speed;

	[Token(Token = "0x6000414")]
	[Address(RVA = "0x9C55E0", Offset = "0x9C55E0", VA = "0x9C55E0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000415")]
	[Address(RVA = "0x9C56A0", Offset = "0x9C56A0", VA = "0x9C56A0")]
	public JustRotate()
	{
	}
}
[Token(Token = "0x20000A3")]
public class KeekOrit : MonoBehaviour
{
	[Token(Token = "0x6000416")]
	[Address(RVA = "0x9C56B8", Offset = "0x9C56B8", VA = "0x9C56B8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000417")]
	[Address(RVA = "0x9C5720", Offset = "0x9C5720", VA = "0x9C5720")]
	public KeekOrit()
	{
	}
}
[Token(Token = "0x20000A4")]
public class KeepSize : MonoBehaviour
{
	[Token(Token = "0x40005E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform targetPosition;

	[Token(Token = "0x6000418")]
	[Address(RVA = "0x9C5728", Offset = "0x9C5728", VA = "0x9C5728")]
	private void Update()
	{
	}

	[Token(Token = "0x6000419")]
	[Address(RVA = "0x9C5768", Offset = "0x9C5768", VA = "0x9C5768")]
	public KeepSize()
	{
	}
}
[Token(Token = "0x20000A5")]
public class LineChart : MonoBehaviour
{
	[Token(Token = "0x40005E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<RectTransform> allPoint;

	[Token(Token = "0x40005E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject linePrefab;

	[Token(Token = "0x600041A")]
	[Address(RVA = "0x9C5770", Offset = "0x9C5770", VA = "0x9C5770")]
	private void Start()
	{
	}

	[Token(Token = "0x600041B")]
	[Address(RVA = "0x9C5774", Offset = "0x9C5774", VA = "0x9C5774")]
	private void InitPointAndLine()
	{
	}

	[Token(Token = "0x600041C")]
	[Address(RVA = "0x9C5BEC", Offset = "0x9C5BEC", VA = "0x9C5BEC")]
	private void Update()
	{
	}

	[Token(Token = "0x600041D")]
	[Address(RVA = "0x9C5BF0", Offset = "0x9C5BF0", VA = "0x9C5BF0")]
	public void UpdateLineChart()
	{
	}

	[Token(Token = "0x600041E")]
	[Address(RVA = "0x9C5E30", Offset = "0x9C5E30", VA = "0x9C5E30")]
	public LineChart()
	{
	}
}
[Token(Token = "0x20000A6")]
public class MyUIShape : Graphic
{
	[Token(Token = "0x40005E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public List<Transform> thepoints;

	[Token(Token = "0x600041F")]
	[Address(RVA = "0x9C5EB8", Offset = "0x9C5EB8", VA = "0x9C5EB8", Slot = "6")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000420")]
	[Address(RVA = "0x9C5F28", Offset = "0x9C5F28", VA = "0x9C5F28")]
	public void UpdateShape(List<Transform> theList)
	{
	}

	[Token(Token = "0x6000421")]
	[Address(RVA = "0x9C629C", Offset = "0x9C629C", VA = "0x9C629C", Slot = "43")]
	protected override void OnPopulateMesh(VertexHelper vh)
	{
	}

	[Token(Token = "0x6000422")]
	[Address(RVA = "0x9C6994", Offset = "0x9C6994", VA = "0x9C6994")]
	public MyUIShape()
	{
	}
}
[Token(Token = "0x20000A7")]
public class OilGauge : MonoBehaviour
{
	[Token(Token = "0x40005E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool b;

	[Token(Token = "0x40005E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Image image;

	[Token(Token = "0x40005E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float speed;

	[Token(Token = "0x40005E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float time;

	[Token(Token = "0x40005EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Text progress;

	[Token(Token = "0x40005EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform oilOilGaugePivot;

	[Token(Token = "0x6000423")]
	[Address(RVA = "0x9C6A40", Offset = "0x9C6A40", VA = "0x9C6A40")]
	private void Update()
	{
	}

	[Token(Token = "0x6000424")]
	[Address(RVA = "0x9C6C08", Offset = "0x9C6C08", VA = "0x9C6C08")]
	public OilGauge()
	{
	}
}
[Token(Token = "0x20000A8")]
public class OilGauge1 : MonoBehaviour
{
	[Token(Token = "0x40005EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool b;

	[Token(Token = "0x40005ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Image image;

	[Token(Token = "0x40005EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float speed;

	[Token(Token = "0x40005EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float time;

	[Token(Token = "0x40005F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Text progress;

	[Token(Token = "0x40005F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform oilOilGaugePivot;

	[Token(Token = "0x6000425")]
	[Address(RVA = "0x9C6C20", Offset = "0x9C6C20", VA = "0x9C6C20")]
	private void Update()
	{
	}

	[Token(Token = "0x6000426")]
	[Address(RVA = "0x9C6DB8", Offset = "0x9C6DB8", VA = "0x9C6DB8")]
	public OilGauge1()
	{
	}
}
[Token(Token = "0x20000A9")]
public class PressedBtn : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
	[Token(Token = "0x40005F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Button btn;

	[Token(Token = "0x40005F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Transform myIcon;

	[Token(Token = "0x6000427")]
	[Address(RVA = "0x9C6DD0", Offset = "0x9C6DD0", VA = "0x9C6DD0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000428")]
	[Address(RVA = "0x9C6E84", Offset = "0x9C6E84", VA = "0x9C6E84")]
	public void OnClick()
	{
	}

	[Token(Token = "0x6000429")]
	[Address(RVA = "0x9C6F44", Offset = "0x9C6F44", VA = "0x9C6F44")]
	public void OnPressed()
	{
	}

	[Token(Token = "0x600042A")]
	[Address(RVA = "0x9C7018", Offset = "0x9C7018", VA = "0x9C7018", Slot = "4")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600042B")]
	[Address(RVA = "0x9C701C", Offset = "0x9C701C", VA = "0x9C701C", Slot = "5")]
	public void OnPointerClick(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600042C")]
	[Address(RVA = "0x9C7020", Offset = "0x9C7020", VA = "0x9C7020", Slot = "6")]
	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600042D")]
	[Address(RVA = "0x9C7024", Offset = "0x9C7024", VA = "0x9C7024", Slot = "7")]
	public void OnPointerExit(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600042E")]
	[Address(RVA = "0x9C7028", Offset = "0x9C7028", VA = "0x9C7028")]
	public PressedBtn()
	{
	}
}
[Token(Token = "0x20000AA")]
public class RandomEnableAnimator : MonoBehaviour
{
	[Token(Token = "0x20000AB")]
	private sealed class <Show>d__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40005F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40005F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40005F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float f;

		[Token(Token = "0x40005F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RandomEnableAnimator <>4__this;

		[Token(Token = "0x17000041")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000435")]
			[Address(RVA = "0x9C72C4", Offset = "0x9C72C4", VA = "0x9C72C4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000042")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000437")]
			[Address(RVA = "0x9C730C", Offset = "0x9C730C", VA = "0x9C730C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x9C71C8", Offset = "0x9C71C8", VA = "0x9C71C8")]
		[DebuggerHidden]
		public <Show>d__2(int <>1__state)
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x9C71F8", Offset = "0x9C71F8", VA = "0x9C71F8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x9C71FC", Offset = "0x9C71FC", VA = "0x9C71FC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x9C72CC", Offset = "0x9C72CC", VA = "0x9C72CC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40005F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Animator am;

	[Token(Token = "0x600042F")]
	[Address(RVA = "0x9C7030", Offset = "0x9C7030", VA = "0x9C7030")]
	private void Start()
	{
	}

	[Token(Token = "0x6000430")]
	[Address(RVA = "0x9C7144", Offset = "0x9C7144", VA = "0x9C7144")]
	private IEnumerator Show(float f)
	{
		return null;
	}

	[Token(Token = "0x6000431")]
	[Address(RVA = "0x9C71F0", Offset = "0x9C71F0", VA = "0x9C71F0")]
	public RandomEnableAnimator()
	{
	}
}
[Token(Token = "0x20000AC")]
public class RandomNumber : MonoBehaviour
{
	[Token(Token = "0x40005F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text numText;

	[Token(Token = "0x40005FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float interval;

	[Token(Token = "0x40005FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float initInterval;

	[Token(Token = "0x6000438")]
	[Address(RVA = "0x9C7314", Offset = "0x9C7314", VA = "0x9C7314")]
	private void Start()
	{
	}

	[Token(Token = "0x6000439")]
	[Address(RVA = "0x9C7384", Offset = "0x9C7384", VA = "0x9C7384")]
	private void Update()
	{
	}

	[Token(Token = "0x600043A")]
	[Address(RVA = "0x9C7418", Offset = "0x9C7418", VA = "0x9C7418")]
	public RandomNumber()
	{
	}
}
[Token(Token = "0x20000AD")]
public class RandomNumberPro : MonoBehaviour
{
	[Token(Token = "0x40005FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text numText;

	[Token(Token = "0x40005FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float interval;

	[Token(Token = "0x40005FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float initInterval;

	[Token(Token = "0x40005FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int min;

	[Token(Token = "0x4000600")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int Max;

	[Token(Token = "0x600043B")]
	[Address(RVA = "0x9C7420", Offset = "0x9C7420", VA = "0x9C7420")]
	private void Start()
	{
	}

	[Token(Token = "0x600043C")]
	[Address(RVA = "0x9C7490", Offset = "0x9C7490", VA = "0x9C7490")]
	private void Update()
	{
	}

	[Token(Token = "0x600043D")]
	[Address(RVA = "0x9C7520", Offset = "0x9C7520", VA = "0x9C7520")]
	public RandomNumberPro()
	{
	}
}
[Token(Token = "0x20000AE")]
public class RunningNumber : MonoBehaviour
{
	[Token(Token = "0x4000601")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text progress;

	[Token(Token = "0x4000602")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float time;

	[Token(Token = "0x4000603")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float number;

	[Token(Token = "0x4000604")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float targetNum;

	[Token(Token = "0x4000605")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float timeCost;

	[Token(Token = "0x4000606")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float timer1;

	[Token(Token = "0x600043E")]
	[Address(RVA = "0x9C7534", Offset = "0x9C7534", VA = "0x9C7534")]
	private void Update()
	{
	}

	[Token(Token = "0x600043F")]
	[Address(RVA = "0x9C76BC", Offset = "0x9C76BC", VA = "0x9C76BC")]
	public RunningNumber()
	{
	}
}
[Token(Token = "0x20000AF")]
public class SimpleProgress : MonoBehaviour
{
	[Token(Token = "0x4000607")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool b;

	[Token(Token = "0x4000608")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Image image;

	[Token(Token = "0x4000609")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float speed;

	[Token(Token = "0x400060A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float time;

	[Token(Token = "0x6000440")]
	[Address(RVA = "0x9C76D0", Offset = "0x9C76D0", VA = "0x9C76D0")]
	public void Start()
	{
	}

	[Token(Token = "0x6000441")]
	[Address(RVA = "0x9C7740", Offset = "0x9C7740", VA = "0x9C7740")]
	private void Update()
	{
	}

	[Token(Token = "0x6000442")]
	[Address(RVA = "0x9C77A4", Offset = "0x9C77A4", VA = "0x9C77A4")]
	public SimpleProgress()
	{
	}
}
[Token(Token = "0x20000B0")]
public class SimpleProgress1 : MonoBehaviour
{
	[Token(Token = "0x400060B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool b;

	[Token(Token = "0x400060C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Image image;

	[Token(Token = "0x400060D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float speed;

	[Token(Token = "0x400060E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float time;

	[Token(Token = "0x6000443")]
	[Address(RVA = "0x9C77B4", Offset = "0x9C77B4", VA = "0x9C77B4")]
	public void Start()
	{
	}

	[Token(Token = "0x6000444")]
	[Address(RVA = "0x9C780C", Offset = "0x9C780C", VA = "0x9C780C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000445")]
	[Address(RVA = "0x9C7870", Offset = "0x9C7870", VA = "0x9C7870")]
	public SimpleProgress1()
	{
	}
}
[Token(Token = "0x20000B1")]
public class SliderRunTo1 : MonoBehaviour
{
	[Token(Token = "0x400060F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool b;

	[Token(Token = "0x4000610")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Slider slider;

	[Token(Token = "0x4000611")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float speed;

	[Token(Token = "0x4000612")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float time;

	[Token(Token = "0x6000446")]
	[Address(RVA = "0x9C7880", Offset = "0x9C7880", VA = "0x9C7880")]
	private void Start()
	{
	}

	[Token(Token = "0x6000447")]
	[Address(RVA = "0x9C78D8", Offset = "0x9C78D8", VA = "0x9C78D8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000448")]
	[Address(RVA = "0x9C7948", Offset = "0x9C7948", VA = "0x9C7948")]
	public SliderRunTo1()
	{
	}
}
[Token(Token = "0x20000B2")]
public class SliderRunTo1A : MonoBehaviour
{
	[Token(Token = "0x4000613")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool b;

	[Token(Token = "0x4000614")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Slider slider;

	[Token(Token = "0x4000615")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float speed;

	[Token(Token = "0x4000616")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float time;

	[Token(Token = "0x6000449")]
	[Address(RVA = "0x9C7960", Offset = "0x9C7960", VA = "0x9C7960")]
	private void Start()
	{
	}

	[Token(Token = "0x600044A")]
	[Address(RVA = "0x9C79B8", Offset = "0x9C79B8", VA = "0x9C79B8")]
	private void Update()
	{
	}

	[Token(Token = "0x600044B")]
	[Address(RVA = "0x9C7A24", Offset = "0x9C7A24", VA = "0x9C7A24")]
	public SliderRunTo1A()
	{
	}
}
[Token(Token = "0x20000B3")]
public class SliderValuePass : MonoBehaviour
{
	[Token(Token = "0x4000617")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Text progress;

	[Token(Token = "0x600044C")]
	[Address(RVA = "0x9C7A3C", Offset = "0x9C7A3C", VA = "0x9C7A3C")]
	private void Start()
	{
	}

	[Token(Token = "0x600044D")]
	[Address(RVA = "0x9C7A94", Offset = "0x9C7A94", VA = "0x9C7A94")]
	public void UpdateProgress(float content)
	{
	}

	[Token(Token = "0x600044E")]
	[Address(RVA = "0x9C7BAC", Offset = "0x9C7BAC", VA = "0x9C7BAC")]
	public SliderValuePass()
	{
	}
}
[Token(Token = "0x20000B4")]
public class Spider : MonoBehaviour
{
	[Token(Token = "0x4000618")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject linePrefab;

	[Token(Token = "0x4000619")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject Point;

	[Token(Token = "0x400061A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float radius;

	[Token(Token = "0x400061B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float[] testArray;

	[Token(Token = "0x400061C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float[] testArray1;

	[Token(Token = "0x400061D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool FillPolyGon;

	[Token(Token = "0x400061E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public MyUIShape myUIShape;

	[Token(Token = "0x400061F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public List<Transform> allPoint;

	[Token(Token = "0x4000620")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private GameObject theRoot;

	[Token(Token = "0x4000621")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private List<GameObject> allRoot;

	[Token(Token = "0x600044F")]
	[Address(RVA = "0x9C7BB4", Offset = "0x9C7BB4", VA = "0x9C7BB4")]
	public void GenerateSpider(params float[] values0To1)
	{
	}

	[Token(Token = "0x6000450")]
	[Address(RVA = "0x9C8608", Offset = "0x9C8608", VA = "0x9C8608")]
	private void Start()
	{
	}

	[Token(Token = "0x6000451")]
	[Address(RVA = "0x9C8610", Offset = "0x9C8610", VA = "0x9C8610")]
	private void Update()
	{
	}

	[Token(Token = "0x6000452")]
	[Address(RVA = "0x9C7F90", Offset = "0x9C7F90", VA = "0x9C7F90")]
	private void CreatePointsLines(int attributes)
	{
	}

	[Token(Token = "0x6000453")]
	[Address(RVA = "0x9C83C8", Offset = "0x9C83C8", VA = "0x9C83C8")]
	private void SetDataToSpider(params float[] values0To1)
	{
	}

	[Token(Token = "0x6000454")]
	[Address(RVA = "0x9C8498", Offset = "0x9C8498", VA = "0x9C8498")]
	private void InitPointAndLine()
	{
	}

	[Token(Token = "0x6000455")]
	[Address(RVA = "0x9C7C1C", Offset = "0x9C7C1C", VA = "0x9C7C1C")]
	private void ClearAll()
	{
	}

	[Token(Token = "0x6000456")]
	[Address(RVA = "0x9C8668", Offset = "0x9C8668", VA = "0x9C8668")]
	public void UpdateLineChart()
	{
	}

	[Token(Token = "0x6000457")]
	[Address(RVA = "0x9C8A18", Offset = "0x9C8A18", VA = "0x9C8A18")]
	public Spider()
	{
	}
}
[Token(Token = "0x20000B5")]
[RequireComponent(typeof(Text))]
public class TextChangeMyColor : MonoBehaviour
{
	[Token(Token = "0x4000622")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Color normalColor;

	[Token(Token = "0x4000623")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Color highlightColor;

	[Token(Token = "0x6000458")]
	[Address(RVA = "0x9C8B7C", Offset = "0x9C8B7C", VA = "0x9C8B7C")]
	public void Start()
	{
	}

	[Token(Token = "0x6000459")]
	[Address(RVA = "0x9C8BE8", Offset = "0x9C8BE8", VA = "0x9C8BE8")]
	public void OnEnter()
	{
	}

	[Token(Token = "0x600045A")]
	[Address(RVA = "0x9C8C50", Offset = "0x9C8C50", VA = "0x9C8C50")]
	public void OnExit()
	{
	}

	[Token(Token = "0x600045B")]
	[Address(RVA = "0x9C8CB8", Offset = "0x9C8CB8", VA = "0x9C8CB8")]
	public TextChangeMyColor()
	{
	}
}
[Token(Token = "0x20000B6")]
[RequireComponent(typeof(Text))]
public class TextColorControl : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	[Token(Token = "0x4000624")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Color normalColor;

	[Token(Token = "0x4000625")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Color highlightColor;

	[Token(Token = "0x600045C")]
	[Address(RVA = "0x9C8CC0", Offset = "0x9C8CC0", VA = "0x9C8CC0")]
	public void Start()
	{
	}

	[Token(Token = "0x600045D")]
	[Address(RVA = "0x9C8D2C", Offset = "0x9C8D2C", VA = "0x9C8D2C", Slot = "4")]
	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600045E")]
	[Address(RVA = "0x9C8D94", Offset = "0x9C8D94", VA = "0x9C8D94", Slot = "5")]
	public void OnPointerExit(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600045F")]
	[Address(RVA = "0x9C8DFC", Offset = "0x9C8DFC", VA = "0x9C8DFC")]
	public TextColorControl()
	{
	}
}
[Token(Token = "0x20000B7")]
public class ThreePercent : MonoBehaviour
{
	[Token(Token = "0x4000626")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Range(0f, 9999f)]
	public float no1;

	[Token(Token = "0x4000627")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Range(0f, 9999f)]
	public float no2;

	[Token(Token = "0x4000628")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Range(0f, 9999f)]
	public float no3;

	[Token(Token = "0x4000629")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Image a;

	[Token(Token = "0x400062A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Image b;

	[Token(Token = "0x400062B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Image c;

	[Token(Token = "0x400062C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Text t1;

	[Token(Token = "0x400062D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Text t2;

	[Token(Token = "0x400062E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Text t3;

	[Token(Token = "0x6000460")]
	[Address(RVA = "0x9C8E04", Offset = "0x9C8E04", VA = "0x9C8E04")]
	private void Update()
	{
	}

	[Token(Token = "0x6000461")]
	[Address(RVA = "0x9C8E10", Offset = "0x9C8E10", VA = "0x9C8E10")]
	public void UpdatePercent(float n1, float n2, float n3)
	{
	}

	[Token(Token = "0x6000462")]
	[Address(RVA = "0x9C9014", Offset = "0x9C9014", VA = "0x9C9014")]
	public ThreePercent()
	{
	}
}
[Token(Token = "0x20000B8")]
[RequireComponent(typeof(PolygonCollider2D))]
public class UIPolygon : Image
{
	[Token(Token = "0x400062F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private PolygonCollider2D _polygon;

	[Token(Token = "0x17000043")]
	private PolygonCollider2D polygon
	{
		[Token(Token = "0x6000463")]
		[Address(RVA = "0x9C901C", Offset = "0x9C901C", VA = "0x9C901C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000464")]
	[Address(RVA = "0x9C90BC", Offset = "0x9C90BC", VA = "0x9C90BC")]
	protected UIPolygon()
	{
	}

	[Token(Token = "0x6000465")]
	[Address(RVA = "0x9C9120", Offset = "0x9C9120", VA = "0x9C9120", Slot = "43")]
	protected override void OnPopulateMesh(VertexHelper vh)
	{
	}

	[Token(Token = "0x6000466")]
	[Address(RVA = "0x9C9138", Offset = "0x9C9138", VA = "0x9C9138", Slot = "84")]
	public override bool IsRaycastLocationValid(Vector2 screenPoint, Camera eventCamera)
	{
		return default(bool);
	}
}
[Token(Token = "0x20000B9")]
public class Wavecircle : MonoBehaviour
{
	[Token(Token = "0x4000630")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Range(0f, 100f)]
	public float no1;

	[Token(Token = "0x4000631")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform wave;

	[Token(Token = "0x4000632")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform s;

	[Token(Token = "0x4000633")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform e;

	[Token(Token = "0x4000634")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Text theText;

	[Token(Token = "0x6000467")]
	[Address(RVA = "0x9C9194", Offset = "0x9C9194", VA = "0x9C9194")]
	private void Update()
	{
	}

	[Token(Token = "0x6000468")]
	[Address(RVA = "0x9C919C", Offset = "0x9C919C", VA = "0x9C919C")]
	private void UpdatePercent(float f)
	{
	}

	[Token(Token = "0x6000469")]
	[Address(RVA = "0x9C939C", Offset = "0x9C939C", VA = "0x9C939C")]
	public Wavecircle()
	{
	}
}
[Token(Token = "0x20000BA")]
public class TrackList : ItemsList
{
	[Token(Token = "0x20000BB")]
	public class TrackInfo
	{
		[Token(Token = "0x4000638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string id;

		[Token(Token = "0x4000639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string title;

		[Token(Token = "0x400063A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool directory;

		[Token(Token = "0x400063B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool group;

		[Token(Token = "0x400063C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		public bool file;

		[Token(Token = "0x400063D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int start_group_index;

		[Token(Token = "0x400063E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int end_group_index;

		[Token(Token = "0x400063F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int bpm_min;

		[Token(Token = "0x4000640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int bpm_max;

		[Token(Token = "0x4000641")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int length;

		[Token(Token = "0x4000642")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int rate;

		[Token(Token = "0x4000643")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int slots;

		[Token(Token = "0x4000644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public MainMenu.TypeOfTracks type;

		[Token(Token = "0x4000645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public List<List<string>> enemies;

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x9CA5B8", Offset = "0x9CA5B8", VA = "0x9CA5B8")]
		public bool IsNavigation()
		{
			return default(bool);
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x9CAC38", Offset = "0x9CAC38", VA = "0x9CAC38")]
		public TrackInfo()
		{
		}
	}

	[Token(Token = "0x20000BC")]
	public enum TypeOfList
	{
		[Token(Token = "0x4000647")]
		Tracks,
		[Token(Token = "0x4000648")]
		Programs,
		[Token(Token = "0x4000649")]
		ProgramItems
	}

	[Token(Token = "0x4000635")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private List<TrackInfo> tracks;

	[Token(Token = "0x4000636")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public TypeOfList typeOfList;

	[Token(Token = "0x4000637")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private string prevComposeTrackID;

	[Token(Token = "0x600046A")]
	[Address(RVA = "0x9C93A4", Offset = "0x9C93A4", VA = "0x9C93A4", Slot = "8")]
	public override void FillData(UIItem item, int idx)
	{
	}

	[Token(Token = "0x600046B")]
	[Address(RVA = "0x9CA110", Offset = "0x9CA110", VA = "0x9CA110")]
	public void ClearData()
	{
	}

	[Token(Token = "0x600046C")]
	[Address(RVA = "0x9CA18C", Offset = "0x9CA18C", VA = "0x9CA18C")]
	public void AddData(TrackInfo track)
	{
	}

	[Token(Token = "0x600046D")]
	[Address(RVA = "0x9CA258", Offset = "0x9CA258", VA = "0x9CA258")]
	public TrackInfo GetInfoByID(string id)
	{
		return null;
	}

	[Token(Token = "0x600046E")]
	[Address(RVA = "0x9CA324", Offset = "0x9CA324", VA = "0x9CA324")]
	public TrackInfo GetTrackByIdx(int idx)
	{
		return null;
	}

	[Token(Token = "0x600046F")]
	[Address(RVA = "0x9CA384", Offset = "0x9CA384", VA = "0x9CA384")]
	public void SelectItem(string id)
	{
	}

	[Token(Token = "0x6000470")]
	[Address(RVA = "0x9CA45C", Offset = "0x9CA45C", VA = "0x9CA45C", Slot = "9")]
	public override void OnSelect(int idx)
	{
	}

	[Token(Token = "0x6000471")]
	[Address(RVA = "0x9CA5D8", Offset = "0x9CA5D8", VA = "0x9CA5D8", Slot = "10")]
	public override void OnFillProgress()
	{
	}

	[Token(Token = "0x6000472")]
	[Address(RVA = "0x9CA7F0", Offset = "0x9CA7F0", VA = "0x9CA7F0", Slot = "7")]
	public override void SpecificUpdate()
	{
	}

	[Token(Token = "0x6000473")]
	[Address(RVA = "0x9CAAB0", Offset = "0x9CAAB0", VA = "0x9CAAB0")]
	public void RevertOrder()
	{
	}

	[Token(Token = "0x6000474")]
	[Address(RVA = "0x9CABB4", Offset = "0x9CABB4", VA = "0x9CABB4")]
	public TrackList()
	{
	}
}
[Token(Token = "0x20000BD")]
public class UIItem : MonoBehaviour
{
	[Token(Token = "0x400064A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ItemsList parentList;

	[Token(Token = "0x400064B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool highlighted;

	[Token(Token = "0x400064C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Sprite normalBack;

	[Token(Token = "0x400064D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Sprite highlightBack;

	[Token(Token = "0x400064E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Sprite emptyBack;

	[Token(Token = "0x400064F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Image icon;

	[Token(Token = "0x4000650")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int index;

	[Token(Token = "0x4000651")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Text title;

	[Token(Token = "0x4000652")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public TextMeshPro titlePro;

	[Token(Token = "0x4000653")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Image background;

	[Token(Token = "0x4000654")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	protected float prevDissolve;

	[Token(Token = "0x4000655")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public bool empty;

	[Token(Token = "0x6000477")]
	[Address(RVA = "0x9CACC8", Offset = "0x9CACC8", VA = "0x9CACC8")]
	public int GetIDX()
	{
		return default(int);
	}

	[Token(Token = "0x6000478")]
	[Address(RVA = "0x9C483C", Offset = "0x9C483C", VA = "0x9C483C")]
	public void Refresh()
	{
	}

	[Token(Token = "0x6000479")]
	[Address(RVA = "0x9CACD0", Offset = "0x9CACD0", VA = "0x9CACD0", Slot = "4")]
	public virtual void SetDissolve(float dissolve)
	{
	}

	[Token(Token = "0x600047A")]
	[Address(RVA = "0x9C42B4", Offset = "0x9C42B4", VA = "0x9C42B4")]
	public bool SetVersion(int idx, ItemsList list)
	{
		return default(bool);
	}

	[Token(Token = "0x600047B")]
	[Address(RVA = "0x9CAEB0", Offset = "0x9CAEB0", VA = "0x9CAEB0", Slot = "5")]
	public virtual bool SetHighlighted(bool val)
	{
		return default(bool);
	}

	[Token(Token = "0x600047C")]
	[Address(RVA = "0x9CB0F8", Offset = "0x9CB0F8", VA = "0x9CB0F8")]
	public UIItem()
	{
	}
}
[Token(Token = "0x20000BE")]
public class UITrackItem : UIItem
{
	[Token(Token = "0x4000656")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Image[] infoIcons;

	[Token(Token = "0x4000657")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Image progress;

	[Token(Token = "0x4000658")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public TextMeshPro bpm;

	[Token(Token = "0x4000659")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public TextMeshPro length;

	[Token(Token = "0x400065A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public TextMeshPro rate;

	[Token(Token = "0x400065B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Image folderIcon;

	[Token(Token = "0x400065C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Image fileIcon;

	[Token(Token = "0x400065D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Image groupIcon;

	[Token(Token = "0x400065E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Image processingIcon;

	[Token(Token = "0x400065F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public GameObject processingGroup;

	[Token(Token = "0x4000660")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Image mp3Icon;

	[Token(Token = "0x4000661")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public Image customIcon;

	[Token(Token = "0x4000662")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public Image officialIcon;

	[Token(Token = "0x4000663")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public Image[] enemyIcons;

	[Token(Token = "0x600047D")]
	[Address(RVA = "0x9CB110", Offset = "0x9CB110", VA = "0x9CB110", Slot = "4")]
	public override void SetDissolve(float dissolve)
	{
	}

	[Token(Token = "0x600047E")]
	[Address(RVA = "0x9CB548", Offset = "0x9CB548", VA = "0x9CB548")]
	public UITrackItem()
	{
	}
}
[Token(Token = "0x20000BF")]
public class GameManager : MonoBehaviour
{
	[Token(Token = "0x4000664")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static string currentName;

	[Token(Token = "0x600047F")]
	[Address(RVA = "0x9CB560", Offset = "0x9CB560", VA = "0x9CB560")]
	private void Start()
	{
	}

	[Token(Token = "0x6000480")]
	[Address(RVA = "0x9CB688", Offset = "0x9CB688", VA = "0x9CB688")]
	public static string GetCurrent()
	{
		return null;
	}

	[Token(Token = "0x6000481")]
	[Address(RVA = "0x9CB6D0", Offset = "0x9CB6D0", VA = "0x9CB6D0")]
	public static void SetCurrent(string newCurrentName)
	{
	}

	[Token(Token = "0x6000482")]
	[Address(RVA = "0x9CB728", Offset = "0x9CB728", VA = "0x9CB728")]
	public GameManager()
	{
	}
}
[Token(Token = "0x20000C0")]
public class OrbitCamera2 : MonoBehaviour
{
	[Token(Token = "0x4000665")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform target;

	[Token(Token = "0x4000666")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float maxOffsetDistance;

	[Token(Token = "0x4000667")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float orbitSpeed;

	[Token(Token = "0x4000668")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float panSpeed;

	[Token(Token = "0x4000669")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float zoomSpeed;

	[Token(Token = "0x400066A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Vector3 targetOffset;

	[Token(Token = "0x400066B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private Vector3 startPos;

	[Token(Token = "0x400066C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Vector3 goTo;

	[Token(Token = "0x400066D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private Quaternion startRot;

	[Token(Token = "0x400066E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Renderer rendd;

	[Token(Token = "0x400066F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static bool setReset;

	[Token(Token = "0x4000670")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private bool autoReset;

	[Token(Token = "0x4000671")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private float turnSpeed;

	[Token(Token = "0x4000672")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Slider mainSlider;

	[Token(Token = "0x4000673")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private bool state;

	[Token(Token = "0x4000674")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
	private bool curTabb;

	[Token(Token = "0x6000483")]
	[Address(RVA = "0x9CB730", Offset = "0x9CB730", VA = "0x9CB730")]
	private void Start()
	{
	}

	[Token(Token = "0x6000484")]
	[Address(RVA = "0x9CB870", Offset = "0x9CB870", VA = "0x9CB870")]
	private void Update()
	{
	}

	[Token(Token = "0x6000485")]
	[Address(RVA = "0x9CC1DC", Offset = "0x9CC1DC", VA = "0x9CC1DC")]
	public void changeState(bool activ)
	{
	}

	[Token(Token = "0x6000486")]
	[Address(RVA = "0x9CC1E8", Offset = "0x9CC1E8", VA = "0x9CC1E8")]
	public void setAutoRes(bool activ)
	{
	}

	[Token(Token = "0x6000487")]
	[Address(RVA = "0x9CC1F4", Offset = "0x9CC1F4", VA = "0x9CC1F4")]
	public void turnSpeedf(float speed)
	{
	}

	[Token(Token = "0x6000488")]
	[Address(RVA = "0x9CBEE8", Offset = "0x9CBEE8", VA = "0x9CBEE8")]
	public void TurnTable()
	{
	}

	[Token(Token = "0x6000489")]
	[Address(RVA = "0x9CC29C", Offset = "0x9CC29C", VA = "0x9CC29C")]
	public static void SetNewResetCamPos(bool asd)
	{
	}

	[Token(Token = "0x600048A")]
	[Address(RVA = "0x9CC2E8", Offset = "0x9CC2E8", VA = "0x9CC2E8")]
	public void SetNewResetCamPos2(bool asd)
	{
	}

	[Token(Token = "0x600048B")]
	[Address(RVA = "0x9CC080", Offset = "0x9CC080", VA = "0x9CC080")]
	public void NewResetCamPos()
	{
	}

	[Token(Token = "0x600048C")]
	[Address(RVA = "0x9CB890", Offset = "0x9CB890", VA = "0x9CB890")]
	public void MoveCam()
	{
	}

	[Token(Token = "0x600048D")]
	[Address(RVA = "0x9CC334", Offset = "0x9CC334", VA = "0x9CC334")]
	public OrbitCamera2()
	{
	}
}
[Token(Token = "0x20000C1")]
public class SpawnArmor : MonoBehaviour
{
	[Token(Token = "0x4000675")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Renderer rend;

	[Token(Token = "0x4000676")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject current;

	[Token(Token = "0x4000677")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private string currentAlienName;

	[Token(Token = "0x4000678")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool state;

	[Token(Token = "0x4000679")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Toggle touchToggle;

	[Token(Token = "0x600048E")]
	[Address(RVA = "0x9CC3A0", Offset = "0x9CC3A0", VA = "0x9CC3A0")]
	private void SelectAlien(string name)
	{
	}

	[Token(Token = "0x600048F")]
	[Address(RVA = "0x9CC5F8", Offset = "0x9CC5F8", VA = "0x9CC5F8")]
	public SpawnArmor()
	{
	}
}
[Token(Token = "0x20000C2")]
public class AnimateTiledTexture : MonoBehaviour
{
	[Token(Token = "0x20000C3")]
	public delegate void VoidEvent();

	[Token(Token = "0x20000C4")]
	private sealed class <updateTiling>d__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400068B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400068C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400068D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AnimateTiledTexture <>4__this;

		[Token(Token = "0x400068E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <checkAgainst>5__2;

		[Token(Token = "0x17000044")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004A1")]
			[Address(RVA = "0x9CD0E0", Offset = "0x9CD0E0", VA = "0x9CD0E0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000045")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004A3")]
			[Address(RVA = "0x9CD128", Offset = "0x9CD128", VA = "0x9CD128", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x9CCF34", Offset = "0x9CCF34", VA = "0x9CCF34")]
		[DebuggerHidden]
		public <updateTiling>d__27(int <>1__state)
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x9CCF5C", Offset = "0x9CCF5C", VA = "0x9CCF5C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x9CCF60", Offset = "0x9CCF60", VA = "0x9CCF60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x9CD0E8", Offset = "0x9CD0E8", VA = "0x9CD0E8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400067A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int _columns;

	[Token(Token = "0x400067B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int _rows;

	[Token(Token = "0x400067C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector2 _scale;

	[Token(Token = "0x400067D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector2 _offset;

	[Token(Token = "0x400067E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector2 _buffer;

	[Token(Token = "0x400067F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float _framesPerSecond;

	[Token(Token = "0x4000680")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public bool _playOnce;

	[Token(Token = "0x4000681")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
	public bool _disableUponCompletion;

	[Token(Token = "0x4000682")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3E")]
	public bool _enableEvents;

	[Token(Token = "0x4000683")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3F")]
	public bool _playOnEnable;

	[Token(Token = "0x4000684")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool _newMaterialInstance;

	[Token(Token = "0x4000685")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private int _index;

	[Token(Token = "0x4000686")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Vector2 _textureSize;

	[Token(Token = "0x4000687")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Material _materialInstance;

	[Token(Token = "0x4000688")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool _hasMaterialInstance;

	[Token(Token = "0x4000689")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
	private bool _isPlaying;

	[Token(Token = "0x400068A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private List<VoidEvent> _voidEventCallbackList;

	[Token(Token = "0x6000490")]
	[Address(RVA = "0x9CC600", Offset = "0x9CC600", VA = "0x9CC600")]
	public void RegisterCallback(VoidEvent cbFunction)
	{
	}

	[Token(Token = "0x6000491")]
	[Address(RVA = "0x9CC704", Offset = "0x9CC704", VA = "0x9CC704")]
	public void UnRegisterCallback(VoidEvent cbFunction)
	{
	}

	[Token(Token = "0x6000492")]
	[Address(RVA = "0x9CC7B0", Offset = "0x9CC7B0", VA = "0x9CC7B0")]
	public void Play()
	{
	}

	[Token(Token = "0x6000493")]
	[Address(RVA = "0x9CC8D0", Offset = "0x9CC8D0", VA = "0x9CC8D0")]
	public void ChangeMaterial(Material newMaterial, bool newInstance = false)
	{
	}

	[Token(Token = "0x6000494")]
	[Address(RVA = "0x9CCA84", Offset = "0x9CCA84", VA = "0x9CCA84")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000495")]
	[Address(RVA = "0x9CCB44", Offset = "0x9CCB44", VA = "0x9CCB44")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000496")]
	[Address(RVA = "0x9CCBE4", Offset = "0x9CCBE4", VA = "0x9CCBE4")]
	private void HandleCallbacks(List<VoidEvent> cbList)
	{
	}

	[Token(Token = "0x6000497")]
	[Address(RVA = "0x9CCC80", Offset = "0x9CCC80", VA = "0x9CCC80")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000498")]
	[Address(RVA = "0x9CCA60", Offset = "0x9CCA60", VA = "0x9CCA60")]
	private void CalcTextureSize()
	{
	}

	[Token(Token = "0x6000499")]
	[Address(RVA = "0x9CC85C", Offset = "0x9CC85C", VA = "0x9CC85C")]
	private IEnumerator updateTiling()
	{
		return null;
	}

	[Token(Token = "0x600049A")]
	[Address(RVA = "0x9CCCB0", Offset = "0x9CCCB0", VA = "0x9CCCB0")]
	private void ApplyOffset()
	{
	}

	[Token(Token = "0x600049B")]
	[Address(RVA = "0x9CCDC8", Offset = "0x9CCDC8", VA = "0x9CCDC8")]
	public AnimateTiledTexture()
	{
	}
}
[Token(Token = "0x20000C5")]
public class LiquidAnim : MonoBehaviour
{
	[Token(Token = "0x400068F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Texture2D[] _animationTexture;

	[Token(Token = "0x4000690")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int AnimTileX;

	[Token(Token = "0x4000691")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int AnimTileY;

	[Token(Token = "0x4000692")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int animSpeedFPS;

	[Token(Token = "0x4000693")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int framesCount;

	[Token(Token = "0x4000694")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector2 textureSize;

	[Token(Token = "0x4000695")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Vector2 scrollSpeed;

	[Token(Token = "0x4000696")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float _startTime;

	[Token(Token = "0x4000697")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private Vector2 currentOffset;

	[Token(Token = "0x60004A4")]
	[Address(RVA = "0x9CD130", Offset = "0x9CD130", VA = "0x9CD130")]
	private void Start()
	{
	}

	[Token(Token = "0x60004A5")]
	[Address(RVA = "0x9CD49C", Offset = "0x9CD49C", VA = "0x9CD49C")]
	private void Update()
	{
	}

	[Token(Token = "0x60004A6")]
	[Address(RVA = "0x9CD654", Offset = "0x9CD654", VA = "0x9CD654")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60004A7")]
	[Address(RVA = "0x9CD1A0", Offset = "0x9CD1A0", VA = "0x9CD1A0")]
	public void InitAnimTexture()
	{
	}

	[Token(Token = "0x60004A8")]
	[Address(RVA = "0x9CD73C", Offset = "0x9CD73C", VA = "0x9CD73C")]
	public LiquidAnim()
	{
	}
}
[Token(Token = "0x20000C6")]
public class MouseLook : MonoBehaviour
{
	[Token(Token = "0x4000698")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Vector2 _mouseAbsolute;

	[Token(Token = "0x4000699")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Vector2 _smoothMouse;

	[Token(Token = "0x400069A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector2 clampInDegrees;

	[Token(Token = "0x400069B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public CursorLockMode lockCursor;

	[Token(Token = "0x400069C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public Vector2 sensitivity;

	[Token(Token = "0x400069D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public Vector2 smoothing;

	[Token(Token = "0x400069E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public Vector2 targetDirection;

	[Token(Token = "0x400069F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public Vector2 targetCharacterDirection;

	[Token(Token = "0x40006A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject characterBody;

	[Token(Token = "0x40006A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public float acceleration;

	[Token(Token = "0x40006A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public float maxSpeed;

	[Token(Token = "0x40006A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public float dampingSpeed;

	[Token(Token = "0x40006A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public KeyCode fwdKey;

	[Token(Token = "0x40006A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public KeyCode leftKey;

	[Token(Token = "0x40006A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public KeyCode backKey;

	[Token(Token = "0x40006A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public KeyCode rightKey;

	[Token(Token = "0x40006A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private float speedX;

	[Token(Token = "0x40006A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private float speedZ;

	[Token(Token = "0x60004A9")]
	[Address(RVA = "0x9CD758", Offset = "0x9CD758", VA = "0x9CD758")]
	private void Start()
	{
	}

	[Token(Token = "0x60004AA")]
	[Address(RVA = "0x9CD850", Offset = "0x9CD850", VA = "0x9CD850")]
	private void Update()
	{
	}

	[Token(Token = "0x60004AB")]
	[Address(RVA = "0x9CDDC8", Offset = "0x9CDDC8", VA = "0x9CDDC8")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60004AC")]
	[Address(RVA = "0x9CDFC8", Offset = "0x9CDFC8", VA = "0x9CDFC8")]
	public MouseLook()
	{
	}
}
[Token(Token = "0x20000C7")]
public class DebugUIBuilder : MonoBehaviour
{
	[Token(Token = "0x20000C8")]
	public delegate void OnClick();

	[Token(Token = "0x20000C9")]
	public delegate void OnToggleValueChange(Toggle t);

	[Token(Token = "0x20000CA")]
	public delegate void OnSlider(float f);

	[Token(Token = "0x20000CB")]
	private sealed class <>c__DisplayClass41_0
	{
		[Token(Token = "0x40006C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public OnClick handler;

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x9CF6A0", Offset = "0x9CF6A0", VA = "0x9CF6A0")]
		public <>c__DisplayClass41_0()
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x9D060C", Offset = "0x9D060C", VA = "0x9D060C")]
		internal void <AddButton>b__0()
		{
		}
	}

	[Token(Token = "0x20000CC")]
	private sealed class <>c__DisplayClass43_0
	{
		[Token(Token = "0x40006C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public OnSlider onValueChanged;

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x9CF968", Offset = "0x9CF968", VA = "0x9CF968")]
		public <>c__DisplayClass43_0()
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x9D0630", Offset = "0x9D0630", VA = "0x9D0630")]
		internal void <AddSlider>b__0(float f)
		{
		}
	}

	[Token(Token = "0x20000CD")]
	private sealed class <>c__DisplayClass45_0
	{
		[Token(Token = "0x40006CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public OnToggleValueChange onValueChanged;

		[Token(Token = "0x40006CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Toggle t;

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x9CFBDC", Offset = "0x9CFBDC", VA = "0x9CFBDC")]
		public <>c__DisplayClass45_0()
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x9D0654", Offset = "0x9D0654", VA = "0x9D0654")]
		internal void <AddToggle>b__0(bool <p0>)
		{
		}
	}

	[Token(Token = "0x20000CE")]
	private sealed class <>c__DisplayClass46_0
	{
		[Token(Token = "0x40006CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public OnToggleValueChange onValueChanged;

		[Token(Token = "0x40006CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Toggle t;

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x9CFDD8", Offset = "0x9CFDD8", VA = "0x9CFDD8")]
		public <>c__DisplayClass46_0()
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x9D067C", Offset = "0x9D067C", VA = "0x9D067C")]
		internal void <AddToggle>b__0(bool <p0>)
		{
		}
	}

	[Token(Token = "0x20000CF")]
	private sealed class <>c__DisplayClass47_0
	{
		[Token(Token = "0x40006CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public OnToggleValueChange handler;

		[Token(Token = "0x40006CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Toggle tb;

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x9D00D0", Offset = "0x9D00D0", VA = "0x9D00D0")]
		public <>c__DisplayClass47_0()
		{
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x9D06A4", Offset = "0x9D06A4", VA = "0x9D06A4")]
		internal void <AddRadio>b__0(bool <p0>)
		{
		}
	}

	[Token(Token = "0x40006AA")]
	public const int DEBUG_PANE_CENTER = 0;

	[Token(Token = "0x40006AB")]
	public const int DEBUG_PANE_RIGHT = 1;

	[Token(Token = "0x40006AC")]
	public const int DEBUG_PANE_LEFT = 2;

	[Token(Token = "0x40006AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RectTransform buttonPrefab;

	[Token(Token = "0x40006AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private RectTransform[] additionalButtonPrefab;

	[Token(Token = "0x40006AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private RectTransform labelPrefab;

	[Token(Token = "0x40006B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private RectTransform sliderPrefab;

	[Token(Token = "0x40006B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private RectTransform dividerPrefab;

	[Token(Token = "0x40006B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private RectTransform togglePrefab;

	[Token(Token = "0x40006B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private RectTransform radioPrefab;

	[Token(Token = "0x40006B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private RectTransform textPrefab;

	[Token(Token = "0x40006B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private GameObject uiHelpersToInstantiate;

	[Token(Token = "0x40006B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Transform[] targetContentPanels;

	[Token(Token = "0x40006B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private bool[] reEnable;

	[Token(Token = "0x40006B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private List<GameObject> toEnable;

	[Token(Token = "0x40006B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private List<GameObject> toDisable;

	[Token(Token = "0x40006BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static DebugUIBuilder instance;

	[Token(Token = "0x40006BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float elementSpacing;

	[Token(Token = "0x40006BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public float marginH;

	[Token(Token = "0x40006BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public float marginV;

	[Token(Token = "0x40006BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Vector2[] insertPositions;

	[Token(Token = "0x40006BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private List<RectTransform>[] insertedElements;

	[Token(Token = "0x40006C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Vector3 menuOffset;

	[Token(Token = "0x40006C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private OVRCameraRig rig;

	[Token(Token = "0x40006C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private Dictionary<string, ToggleGroup> radioGroups;

	[Token(Token = "0x40006C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private LaserPointer lp;

	[Token(Token = "0x40006C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private LineRenderer lr;

	[Token(Token = "0x40006C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public LaserPointer.LaserBeamBehavior laserBeamBehavior;

	[Token(Token = "0x40006C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	public bool isHorizontal;

	[Token(Token = "0x40006C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD5")]
	public bool usePanelCentricRelayout;

	[Token(Token = "0x60004AD")]
	[Address(RVA = "0x9CE00C", Offset = "0x9CE00C", VA = "0x9CE00C")]
	public void Awake()
	{
	}

	[Token(Token = "0x60004AE")]
	[Address(RVA = "0x9CE578", Offset = "0x9CE578", VA = "0x9CE578")]
	public void Show()
	{
	}

	[Token(Token = "0x60004AF")]
	[Address(RVA = "0x9CE8F4", Offset = "0x9CE8F4", VA = "0x9CE8F4")]
	public void Hide()
	{
	}

	[Token(Token = "0x60004B0")]
	[Address(RVA = "0x9CEA70", Offset = "0x9CEA70", VA = "0x9CEA70")]
	private void StackedRelayout()
	{
	}

	[Token(Token = "0x60004B1")]
	[Address(RVA = "0x9CEC88", Offset = "0x9CEC88", VA = "0x9CEC88")]
	private void PanelCentricRelayout()
	{
	}

	[Token(Token = "0x60004B2")]
	[Address(RVA = "0x9CE8E4", Offset = "0x9CE8E4", VA = "0x9CE8E4")]
	private void Relayout()
	{
	}

	[Token(Token = "0x60004B3")]
	[Address(RVA = "0x9CEF7C", Offset = "0x9CEF7C", VA = "0x9CEF7C")]
	private void AddRect(RectTransform r, int targetCanvas)
	{
	}

	[Token(Token = "0x60004B4")]
	[Address(RVA = "0x9CF2F8", Offset = "0x9CF2F8", VA = "0x9CF2F8")]
	public RectTransform AddButton(string label, [Optional] OnClick handler, int buttonIndex = -1, int targetCanvas = 0, bool highResolutionText = false)
	{
		return null;
	}

	[Token(Token = "0x60004B5")]
	[Address(RVA = "0x9CF6A8", Offset = "0x9CF6A8", VA = "0x9CF6A8")]
	public RectTransform AddLabel(string label, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x60004B6")]
	[Address(RVA = "0x9CF7A0", Offset = "0x9CF7A0", VA = "0x9CF7A0")]
	public RectTransform AddSlider(string label, float min, float max, OnSlider onValueChanged, bool wholeNumbersOnly = false, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x60004B7")]
	[Address(RVA = "0x9CF970", Offset = "0x9CF970", VA = "0x9CF970")]
	public RectTransform AddDivider(int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x60004B8")]
	[Address(RVA = "0x9CFA08", Offset = "0x9CFA08", VA = "0x9CFA08")]
	public RectTransform AddToggle(string label, OnToggleValueChange onValueChanged, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x60004B9")]
	[Address(RVA = "0x9CFBE4", Offset = "0x9CFBE4", VA = "0x9CFBE4")]
	public RectTransform AddToggle(string label, OnToggleValueChange onValueChanged, bool defaultValue, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x60004BA")]
	[Address(RVA = "0x9CFDE0", Offset = "0x9CFDE0", VA = "0x9CFDE0")]
	public RectTransform AddRadio(string label, string group, OnToggleValueChange handler, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x60004BB")]
	[Address(RVA = "0x9D00D8", Offset = "0x9D00D8", VA = "0x9D00D8")]
	public RectTransform AddTextField(string label, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x60004BC")]
	[Address(RVA = "0x9D01C8", Offset = "0x9D01C8", VA = "0x9D01C8")]
	public void ToggleLaserPointer(bool isOn)
	{
	}

	[Token(Token = "0x60004BD")]
	[Address(RVA = "0x9D025C", Offset = "0x9D025C", VA = "0x9D025C")]
	public DebugUIBuilder()
	{
	}
}
[Token(Token = "0x20000D0")]
public class HandedInputSelector : MonoBehaviour
{
	[Token(Token = "0x40006D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRCameraRig m_CameraRig;

	[Token(Token = "0x40006D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private OVRInputModule m_InputModule;

	[Token(Token = "0x60004CE")]
	[Address(RVA = "0x9D06CC", Offset = "0x9D06CC", VA = "0x9D06CC")]
	private void Start()
	{
	}

	[Token(Token = "0x60004CF")]
	[Address(RVA = "0x9D0770", Offset = "0x9D0770", VA = "0x9D0770")]
	private void Update()
	{
	}

	[Token(Token = "0x60004D0")]
	[Address(RVA = "0x9D080C", Offset = "0x9D080C", VA = "0x9D080C")]
	private void SetActiveController(OVRInput.Controller c)
	{
	}

	[Token(Token = "0x60004D1")]
	[Address(RVA = "0x9D0844", Offset = "0x9D0844", VA = "0x9D0844")]
	public HandedInputSelector()
	{
	}
}
[Token(Token = "0x20000D1")]
public class LaserPointer : OVRCursor
{
	[Token(Token = "0x20000D2")]
	public enum LaserBeamBehavior
	{
		[Token(Token = "0x40006DC")]
		On,
		[Token(Token = "0x40006DD")]
		Off,
		[Token(Token = "0x40006DE")]
		OnWhenHitTarget
	}

	[Token(Token = "0x40006D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject cursorVisual;

	[Token(Token = "0x40006D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float maxLength;

	[Token(Token = "0x40006D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private LaserBeamBehavior _laserBeamBehavior;

	[Token(Token = "0x40006D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool m_restoreOnInputAcquired;

	[Token(Token = "0x40006D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private Vector3 _startPoint;

	[Token(Token = "0x40006D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector3 _forward;

	[Token(Token = "0x40006D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private Vector3 _endPoint;

	[Token(Token = "0x40006D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool _hitTarget;

	[Token(Token = "0x40006DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private LineRenderer lineRenderer;

	[Token(Token = "0x17000046")]
	public LaserBeamBehavior laserBeamBehavior
	{
		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x9D084C", Offset = "0x9D084C", VA = "0x9D084C")]
		get
		{
			return default(LaserBeamBehavior);
		}
		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x9CE538", Offset = "0x9CE538", VA = "0x9CE538")]
		set
		{
		}
	}

	[Token(Token = "0x60004D4")]
	[Address(RVA = "0x9D0854", Offset = "0x9D0854", VA = "0x9D0854")]
	private void Awake()
	{
	}

	[Token(Token = "0x60004D5")]
	[Address(RVA = "0x9D08AC", Offset = "0x9D08AC", VA = "0x9D08AC")]
	private void Start()
	{
	}

	[Token(Token = "0x60004D6")]
	[Address(RVA = "0x9D09E4", Offset = "0x9D09E4", VA = "0x9D09E4", Slot = "5")]
	public override void SetCursorStartDest(Vector3 start, Vector3 dest, Vector3 normal)
	{
	}

	[Token(Token = "0x60004D7")]
	[Address(RVA = "0x9D0A00", Offset = "0x9D0A00", VA = "0x9D0A00", Slot = "4")]
	public override void SetCursorRay(Transform t)
	{
	}

	[Token(Token = "0x60004D8")]
	[Address(RVA = "0x9D0A50", Offset = "0x9D0A50", VA = "0x9D0A50")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60004D9")]
	[Address(RVA = "0x9D0BF0", Offset = "0x9D0BF0", VA = "0x9D0BF0")]
	private void UpdateLaserBeam(Vector3 start, Vector3 end)
	{
	}

	[Token(Token = "0x60004DA")]
	[Address(RVA = "0x9D0D00", Offset = "0x9D0D00", VA = "0x9D0D00")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60004DB")]
	[Address(RVA = "0x9D0D84", Offset = "0x9D0D84", VA = "0x9D0D84")]
	public void OnInputFocusLost()
	{
	}

	[Token(Token = "0x60004DC")]
	[Address(RVA = "0x9D0E44", Offset = "0x9D0E44", VA = "0x9D0E44")]
	public void OnInputFocusAcquired()
	{
	}

	[Token(Token = "0x60004DD")]
	[Address(RVA = "0x9D0EEC", Offset = "0x9D0EEC", VA = "0x9D0EEC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60004DE")]
	[Address(RVA = "0x9D0FD8", Offset = "0x9D0FD8", VA = "0x9D0FD8")]
	public LaserPointer()
	{
	}
}
[Token(Token = "0x20000D3")]
public class CharacterCameraConstraint : MonoBehaviour
{
	[Token(Token = "0x40006DF")]
	private const float FADE_RAY_LENGTH = 0.25f;

	[Token(Token = "0x40006E0")]
	private const float FADE_OVERLAP_MAXIMUM = 0.1f;

	[Token(Token = "0x40006E1")]
	private const float FADE_AMOUNT_MAXIMUM = 1f;

	[Token(Token = "0x40006E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRCameraRig CameraRig;

	[Token(Token = "0x40006E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public LayerMask CollideLayers;

	[Token(Token = "0x40006E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float HeightOffset;

	[Token(Token = "0x40006E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float MinimumHeight;

	[Token(Token = "0x40006E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float MaximumHeight;

	[Token(Token = "0x40006E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private CapsuleCollider _character;

	[Token(Token = "0x40006E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private SimpleCapsuleWithStickMovement _simplePlayerController;

	[Token(Token = "0x60004DF")]
	[Address(RVA = "0x9D0FE8", Offset = "0x9D0FE8", VA = "0x9D0FE8")]
	private CharacterCameraConstraint()
	{
	}

	[Token(Token = "0x60004E0")]
	[Address(RVA = "0x9D0FF0", Offset = "0x9D0FF0", VA = "0x9D0FF0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60004E1")]
	[Address(RVA = "0x9D1080", Offset = "0x9D1080", VA = "0x9D1080")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60004E2")]
	[Address(RVA = "0x9D11A4", Offset = "0x9D11A4", VA = "0x9D11A4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60004E3")]
	[Address(RVA = "0x9D12C8", Offset = "0x9D12C8", VA = "0x9D12C8")]
	private void CameraUpdate()
	{
	}

	[Token(Token = "0x60004E4")]
	[Address(RVA = "0x9D15E8", Offset = "0x9D15E8", VA = "0x9D15E8")]
	private bool CheckCameraOverlapped()
	{
		return default(bool);
	}

	[Token(Token = "0x60004E5")]
	[Address(RVA = "0x9D1848", Offset = "0x9D1848", VA = "0x9D1848")]
	private bool CheckCameraNearClipping(out float result)
	{
		return default(bool);
	}
}
[Token(Token = "0x20000D4")]
public class LocomotionController : MonoBehaviour
{
	[Token(Token = "0x40006E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRCameraRig CameraRig;

	[Token(Token = "0x40006EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public CapsuleCollider CharacterController;

	[Token(Token = "0x40006EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public SimpleCapsuleWithStickMovement PlayerController;

	[Token(Token = "0x60004E6")]
	[Address(RVA = "0x9D1FA0", Offset = "0x9D1FA0", VA = "0x9D1FA0")]
	private void Start()
	{
	}

	[Token(Token = "0x60004E7")]
	[Address(RVA = "0x9D204C", Offset = "0x9D204C", VA = "0x9D204C")]
	public LocomotionController()
	{
	}
}
[Token(Token = "0x20000D5")]
public class LocomotionTeleport : MonoBehaviour
{
	[Token(Token = "0x20000D6")]
	public enum States
	{
		[Token(Token = "0x400070F")]
		Ready,
		[Token(Token = "0x4000710")]
		Aim,
		[Token(Token = "0x4000711")]
		CancelAim,
		[Token(Token = "0x4000712")]
		PreTeleport,
		[Token(Token = "0x4000713")]
		CancelTeleport,
		[Token(Token = "0x4000714")]
		Teleporting,
		[Token(Token = "0x4000715")]
		PostTeleport
	}

	[Token(Token = "0x20000D7")]
	public enum TeleportIntentions
	{
		[Token(Token = "0x4000717")]
		None,
		[Token(Token = "0x4000718")]
		Aim,
		[Token(Token = "0x4000719")]
		PreTeleport,
		[Token(Token = "0x400071A")]
		Teleport
	}

	[Token(Token = "0x20000D8")]
	public enum AimCollisionTypes
	{
		[Token(Token = "0x400071C")]
		Point,
		[Token(Token = "0x400071D")]
		Sphere,
		[Token(Token = "0x400071E")]
		Capsule
	}

	[Token(Token = "0x20000D9")]
	public class AimData
	{
		[Token(Token = "0x400071F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RaycastHit TargetHitInfo;

		[Token(Token = "0x4000720")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool TargetValid;

		[Token(Token = "0x4000721")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3? Destination;

		[Token(Token = "0x4000722")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float Radius;

		[Token(Token = "0x4000723")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<Vector3> <Points>k__BackingField;

		[Token(Token = "0x1700004A")]
		public List<Vector3> Points
		{
			[Token(Token = "0x600051D")]
			[Address(RVA = "0x9D3D8C", Offset = "0x9D3D8C", VA = "0x9D3D8C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600051E")]
			[Address(RVA = "0x9D3D94", Offset = "0x9D3D94", VA = "0x9D3D94")]
			private set
			{
			}
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x9D3D04", Offset = "0x9D3D04", VA = "0x9D3D04")]
		public AimData()
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x9D3D9C", Offset = "0x9D3D9C", VA = "0x9D3D9C")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x20000DA")]
	private sealed class <ReadyStateCoroutine>d__52 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000724")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000725")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000726")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x1700004B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000523")]
			[Address(RVA = "0x9D3F04", Offset = "0x9D3F04", VA = "0x9D3F04", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000525")]
			[Address(RVA = "0x9D3F4C", Offset = "0x9D3F4C", VA = "0x9D3F4C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x9D2A58", Offset = "0x9D2A58", VA = "0x9D2A58")]
		[DebuggerHidden]
		public <ReadyStateCoroutine>d__52(int <>1__state)
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x9D3DF4", Offset = "0x9D3DF4", VA = "0x9D3DF4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x9D3DF8", Offset = "0x9D3DF8", VA = "0x9D3DF8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x9D3F0C", Offset = "0x9D3F0C", VA = "0x9D3F0C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000DB")]
	private sealed class <AimStateCoroutine>d__64 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000727")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000728")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000729")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x1700004D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000529")]
			[Address(RVA = "0x9D40B0", Offset = "0x9D40B0", VA = "0x9D40B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600052B")]
			[Address(RVA = "0x9D40F8", Offset = "0x9D40F8", VA = "0x9D40F8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x9D2EE0", Offset = "0x9D2EE0", VA = "0x9D2EE0")]
		[DebuggerHidden]
		public <AimStateCoroutine>d__64(int <>1__state)
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x9D3F54", Offset = "0x9D3F54", VA = "0x9D3F54", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x9D3F58", Offset = "0x9D3F58", VA = "0x9D3F58", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x9D40B8", Offset = "0x9D40B8", VA = "0x9D40B8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000DC")]
	private sealed class <CancelAimStateCoroutine>d__68 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400072A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400072B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400072C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x1700004F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600052F")]
			[Address(RVA = "0x9D41B0", Offset = "0x9D41B0", VA = "0x9D41B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000050")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000531")]
			[Address(RVA = "0x9D41F8", Offset = "0x9D41F8", VA = "0x9D41F8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x9D30B4", Offset = "0x9D30B4", VA = "0x9D30B4")]
		[DebuggerHidden]
		public <CancelAimStateCoroutine>d__68(int <>1__state)
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x9D4100", Offset = "0x9D4100", VA = "0x9D4100", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x9D4104", Offset = "0x9D4104", VA = "0x9D4104", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x9D41B8", Offset = "0x9D41B8", VA = "0x9D41B8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000DD")]
	private sealed class <PreTeleportStateCoroutine>d__72 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400072D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400072E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400072F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000051")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000535")]
			[Address(RVA = "0x9D42E8", Offset = "0x9D42E8", VA = "0x9D42E8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000052")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000537")]
			[Address(RVA = "0x9D4330", Offset = "0x9D4330", VA = "0x9D4330", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x9D3288", Offset = "0x9D3288", VA = "0x9D3288")]
		[DebuggerHidden]
		public <PreTeleportStateCoroutine>d__72(int <>1__state)
		{
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x9D4200", Offset = "0x9D4200", VA = "0x9D4200", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x9D4204", Offset = "0x9D4204", VA = "0x9D4204", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x9D42F0", Offset = "0x9D42F0", VA = "0x9D42F0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000DE")]
	private sealed class <CancelTeleportStateCoroutine>d__76 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000730")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000053")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600053B")]
			[Address(RVA = "0x9D43E8", Offset = "0x9D43E8", VA = "0x9D43E8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000054")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600053D")]
			[Address(RVA = "0x9D4430", Offset = "0x9D4430", VA = "0x9D4430", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x9D345C", Offset = "0x9D345C", VA = "0x9D345C")]
		[DebuggerHidden]
		public <CancelTeleportStateCoroutine>d__76(int <>1__state)
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x9D4338", Offset = "0x9D4338", VA = "0x9D4338", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x9D433C", Offset = "0x9D433C", VA = "0x9D433C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x9D43F0", Offset = "0x9D43F0", VA = "0x9D43F0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000DF")]
	private sealed class <TeleportingStateCoroutine>d__80 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000733")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000734")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000735")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000055")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000541")]
			[Address(RVA = "0x9D451C", Offset = "0x9D451C", VA = "0x9D451C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000056")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000543")]
			[Address(RVA = "0x9D4564", Offset = "0x9D4564", VA = "0x9D4564", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x9D3630", Offset = "0x9D3630", VA = "0x9D3630")]
		[DebuggerHidden]
		public <TeleportingStateCoroutine>d__80(int <>1__state)
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x9D4438", Offset = "0x9D4438", VA = "0x9D4438", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x9D443C", Offset = "0x9D443C", VA = "0x9D443C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x9D4524", Offset = "0x9D4524", VA = "0x9D4524", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000E0")]
	private sealed class <PostTeleportStateCoroutine>d__84 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000736")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000737")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000738")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000057")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000547")]
			[Address(RVA = "0x9D466C", Offset = "0x9D466C", VA = "0x9D466C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000058")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000549")]
			[Address(RVA = "0x9D46B4", Offset = "0x9D46B4", VA = "0x9D46B4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x9D3804", Offset = "0x9D3804", VA = "0x9D3804")]
		[DebuggerHidden]
		public <PostTeleportStateCoroutine>d__84(int <>1__state)
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x9D456C", Offset = "0x9D456C", VA = "0x9D456C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x9D4570", Offset = "0x9D4570", VA = "0x9D4570", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x9D4674", Offset = "0x9D4674", VA = "0x9D4674", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40006EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool EnableMovementDuringReady;

	[Token(Token = "0x40006ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool EnableMovementDuringAim;

	[Token(Token = "0x40006EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	public bool EnableMovementDuringPreTeleport;

	[Token(Token = "0x40006EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
	public bool EnableMovementDuringPostTeleport;

	[Token(Token = "0x40006F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool EnableRotationDuringReady;

	[Token(Token = "0x40006F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	public bool EnableRotationDuringAim;

	[Token(Token = "0x40006F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
	public bool EnableRotationDuringPreTeleport;

	[Token(Token = "0x40006F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F")]
	public bool EnableRotationDuringPostTeleport;

	[Token(Token = "0x40006F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private States <CurrentState>k__BackingField;

	[NonSerialized]
	[Token(Token = "0x40006F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TeleportAimHandler AimHandler;

	[Token(Token = "0x40006F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public TeleportDestination TeleportDestinationPrefab;

	[Token(Token = "0x40006F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int TeleportDestinationLayer;

	[NonSerialized]
	[Token(Token = "0x40006F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TeleportInputHandler InputHandler;

	[NonSerialized]
	[Token(Token = "0x40006FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public TeleportIntentions CurrentIntention;

	[NonSerialized]
	[Token(Token = "0x40006FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public bool IsPreTeleportRequested;

	[NonSerialized]
	[Token(Token = "0x40006FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
	public bool IsTransitioning;

	[NonSerialized]
	[Token(Token = "0x40006FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x56")]
	public bool IsPostTeleportRequested;

	[Token(Token = "0x40006FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private TeleportDestination _teleportDestination;

	[Token(Token = "0x40006FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private LocomotionController <LocomotionController>k__BackingField;

	[Token(Token = "0x4000700")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public AimCollisionTypes AimCollisionType;

	[Token(Token = "0x4000701")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public bool UseCharacterCollisionData;

	[Token(Token = "0x4000702")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float AimCollisionRadius;

	[Token(Token = "0x4000703")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public float AimCollisionHeight;

	[Token(Token = "0x17000047")]
	public States CurrentState
	{
		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x9D209C", Offset = "0x9D209C", VA = "0x9D209C")]
		get
		{
			return default(States);
		}
		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x9D20A4", Offset = "0x9D20A4", VA = "0x9D20A4")]
		private set
		{
		}
	}

	[Token(Token = "0x17000048")]
	public Quaternion DestinationRotation
	{
		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x9D2274", Offset = "0x9D2274", VA = "0x9D2274")]
		get
		{
			return default(Quaternion);
		}
	}

	[Token(Token = "0x17000049")]
	public LocomotionController LocomotionController
	{
		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x9D2298", Offset = "0x9D2298", VA = "0x9D2298")]
		get
		{
			return null;
		}
		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x9D22A0", Offset = "0x9D22A0", VA = "0x9D22A0")]
		private set
		{
		}
	}

	[Token(Token = "0x14000003")]
	public event Action<bool, Vector3?, Quaternion?, Quaternion?> UpdateTeleportDestination
	{
		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x9D20AC", Offset = "0x9D20AC", VA = "0x9D20AC")]
		add
		{
		}
		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x9D215C", Offset = "0x9D215C", VA = "0x9D215C")]
		remove
		{
		}
	}

	[Token(Token = "0x14000004")]
	public event Action EnterStateReady
	{
		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x9D2920", Offset = "0x9D2920", VA = "0x9D2920")]
		add
		{
		}
		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x9D29BC", Offset = "0x9D29BC", VA = "0x9D29BC")]
		remove
		{
		}
	}

	[Token(Token = "0x14000005")]
	public event Action EnterStateAim
	{
		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x9D2A80", Offset = "0x9D2A80", VA = "0x9D2A80")]
		add
		{
		}
		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x9D2B1C", Offset = "0x9D2B1C", VA = "0x9D2B1C")]
		remove
		{
		}
	}

	[Token(Token = "0x14000006")]
	public event Action<AimData> UpdateAimData
	{
		[Token(Token = "0x6000500")]
		[Address(RVA = "0x9D2BB8", Offset = "0x9D2BB8", VA = "0x9D2BB8")]
		add
		{
		}
		[Token(Token = "0x6000501")]
		[Address(RVA = "0x9D2C68", Offset = "0x9D2C68", VA = "0x9D2C68")]
		remove
		{
		}
	}

	[Token(Token = "0x14000007")]
	public event Action ExitStateAim
	{
		[Token(Token = "0x6000503")]
		[Address(RVA = "0x9D2D34", Offset = "0x9D2D34", VA = "0x9D2D34")]
		add
		{
		}
		[Token(Token = "0x6000504")]
		[Address(RVA = "0x9D2DD0", Offset = "0x9D2DD0", VA = "0x9D2DD0")]
		remove
		{
		}
	}

	[Token(Token = "0x14000008")]
	public event Action EnterStateCancelAim
	{
		[Token(Token = "0x6000506")]
		[Address(RVA = "0x9D2F08", Offset = "0x9D2F08", VA = "0x9D2F08")]
		add
		{
		}
		[Token(Token = "0x6000507")]
		[Address(RVA = "0x9D2FA4", Offset = "0x9D2FA4", VA = "0x9D2FA4")]
		remove
		{
		}
	}

	[Token(Token = "0x14000009")]
	public event Action EnterStatePreTeleport
	{
		[Token(Token = "0x6000509")]
		[Address(RVA = "0x9D30DC", Offset = "0x9D30DC", VA = "0x9D30DC")]
		add
		{
		}
		[Token(Token = "0x600050A")]
		[Address(RVA = "0x9D3178", Offset = "0x9D3178", VA = "0x9D3178")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000A")]
	public event Action EnterStateCancelTeleport
	{
		[Token(Token = "0x600050C")]
		[Address(RVA = "0x9D32B0", Offset = "0x9D32B0", VA = "0x9D32B0")]
		add
		{
		}
		[Token(Token = "0x600050D")]
		[Address(RVA = "0x9D334C", Offset = "0x9D334C", VA = "0x9D334C")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000B")]
	public event Action EnterStateTeleporting
	{
		[Token(Token = "0x600050F")]
		[Address(RVA = "0x9D3484", Offset = "0x9D3484", VA = "0x9D3484")]
		add
		{
		}
		[Token(Token = "0x6000510")]
		[Address(RVA = "0x9D3520", Offset = "0x9D3520", VA = "0x9D3520")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000C")]
	public event Action EnterStatePostTeleport
	{
		[Token(Token = "0x6000512")]
		[Address(RVA = "0x9D3658", Offset = "0x9D3658", VA = "0x9D3658")]
		add
		{
		}
		[Token(Token = "0x6000513")]
		[Address(RVA = "0x9D36F4", Offset = "0x9D36F4", VA = "0x9D36F4")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000D")]
	public event Action<Transform, Vector3, Quaternion> Teleported
	{
		[Token(Token = "0x6000515")]
		[Address(RVA = "0x9D382C", Offset = "0x9D382C", VA = "0x9D382C")]
		add
		{
		}
		[Token(Token = "0x6000516")]
		[Address(RVA = "0x9D38DC", Offset = "0x9D38DC", VA = "0x9D38DC")]
		remove
		{
		}
	}

	[Token(Token = "0x60004E8")]
	[Address(RVA = "0x9D2054", Offset = "0x9D2054", VA = "0x9D2054")]
	public void EnableMovement(bool ready, bool aim, bool pre, bool post)
	{
	}

	[Token(Token = "0x60004E9")]
	[Address(RVA = "0x9D2078", Offset = "0x9D2078", VA = "0x9D2078")]
	public void EnableRotation(bool ready, bool aim, bool pre, bool post)
	{
	}

	[Token(Token = "0x60004EE")]
	[Address(RVA = "0x9D220C", Offset = "0x9D220C", VA = "0x9D220C")]
	public void OnUpdateTeleportDestination(bool isValidDestination, Vector3? position, Quaternion? rotation, Quaternion? landingRotation)
	{
	}

	[Token(Token = "0x60004F2")]
	[Address(RVA = "0x9D22A8", Offset = "0x9D22A8", VA = "0x9D22A8")]
	public bool AimCollisionTest(Vector3 start, Vector3 end, LayerMask aimCollisionLayerMask, out RaycastHit hitInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x60004F3")]
	[Address(RVA = "0x9D2570", Offset = "0x9D2570", VA = "0x9D2570")]
	protected void LogState(string msg)
	{
	}

	[Token(Token = "0x60004F4")]
	[Address(RVA = "0x9D2618", Offset = "0x9D2618", VA = "0x9D2618")]
	protected void CreateNewTeleportDestination()
	{
	}

	[Token(Token = "0x60004F5")]
	[Address(RVA = "0x9D2704", Offset = "0x9D2704", VA = "0x9D2704")]
	private void DeactivateDestination()
	{
	}

	[Token(Token = "0x60004F6")]
	[Address(RVA = "0x9D2740", Offset = "0x9D2740", VA = "0x9D2740")]
	public void RecycleTeleportDestination(TeleportDestination oldDestination)
	{
	}

	[Token(Token = "0x60004F7")]
	[Address(RVA = "0x9D27F0", Offset = "0x9D27F0", VA = "0x9D27F0")]
	private void EnableMotion(bool enableLinear, bool enableRotation)
	{
	}

	[Token(Token = "0x60004F8")]
	[Address(RVA = "0x9D2820", Offset = "0x9D2820", VA = "0x9D2820")]
	private void Awake()
	{
	}

	[Token(Token = "0x60004F9")]
	[Address(RVA = "0x9D2880", Offset = "0x9D2880", VA = "0x9D2880", Slot = "4")]
	public virtual void OnEnable()
	{
	}

	[Token(Token = "0x60004FA")]
	[Address(RVA = "0x9D2918", Offset = "0x9D2918", VA = "0x9D2918", Slot = "5")]
	public virtual void OnDisable()
	{
	}

	[Token(Token = "0x60004FD")]
	[Address(RVA = "0x9D28A4", Offset = "0x9D28A4", VA = "0x9D28A4")]
	protected IEnumerator ReadyStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000502")]
	[Address(RVA = "0x9D2D18", Offset = "0x9D2D18", VA = "0x9D2D18")]
	public void OnUpdateAimData(AimData aimData)
	{
	}

	[Token(Token = "0x6000505")]
	[Address(RVA = "0x9D2E6C", Offset = "0x9D2E6C", VA = "0x9D2E6C")]
	protected IEnumerator AimStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000508")]
	[Address(RVA = "0x9D3040", Offset = "0x9D3040", VA = "0x9D3040")]
	protected IEnumerator CancelAimStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600050B")]
	[Address(RVA = "0x9D3214", Offset = "0x9D3214", VA = "0x9D3214")]
	protected IEnumerator PreTeleportStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600050E")]
	[Address(RVA = "0x9D33E8", Offset = "0x9D33E8", VA = "0x9D33E8")]
	protected IEnumerator CancelTeleportStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000511")]
	[Address(RVA = "0x9D35BC", Offset = "0x9D35BC", VA = "0x9D35BC")]
	protected IEnumerator TeleportingStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000514")]
	[Address(RVA = "0x9D3790", Offset = "0x9D3790", VA = "0x9D3790")]
	protected IEnumerator PostTeleportStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000517")]
	[Address(RVA = "0x9D398C", Offset = "0x9D398C", VA = "0x9D398C")]
	public void DoTeleport()
	{
	}

	[Token(Token = "0x6000518")]
	[Address(RVA = "0x9D3AA0", Offset = "0x9D3AA0", VA = "0x9D3AA0")]
	public Vector3 GetCharacterPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000519")]
	[Address(RVA = "0x9D3AD0", Offset = "0x9D3AD0", VA = "0x9D3AD0")]
	public Quaternion GetHeadRotationY()
	{
		return default(Quaternion);
	}

	[Token(Token = "0x600051A")]
	[Address(RVA = "0x9D3C0C", Offset = "0x9D3C0C", VA = "0x9D3C0C")]
	public void DoWarp(Vector3 startPos, float positionPercent)
	{
	}

	[Token(Token = "0x600051B")]
	[Address(RVA = "0x9D3CF4", Offset = "0x9D3CF4", VA = "0x9D3CF4")]
	public LocomotionTeleport()
	{
	}
}
[Token(Token = "0x20000E1")]
public class SimpleCapsuleWithStickMovement : MonoBehaviour
{
	[Token(Token = "0x4000739")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool EnableLinearMovement;

	[Token(Token = "0x400073A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool EnableRotation;

	[Token(Token = "0x400073B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	public bool HMDRotatesPlayer;

	[Token(Token = "0x400073C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
	public bool RotationEitherThumbstick;

	[Token(Token = "0x400073D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float RotationAngle;

	[Token(Token = "0x400073E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float Speed;

	[Token(Token = "0x400073F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OVRCameraRig CameraRig;

	[Token(Token = "0x4000740")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool ReadyToSnapTurn;

	[Token(Token = "0x4000741")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Rigidbody _rigidbody;

	[Token(Token = "0x1400000E")]
	public event Action CameraUpdated
	{
		[Token(Token = "0x600054A")]
		[Address(RVA = "0x9D1108", Offset = "0x9D1108", VA = "0x9D1108")]
		add
		{
		}
		[Token(Token = "0x600054B")]
		[Address(RVA = "0x9D122C", Offset = "0x9D122C", VA = "0x9D122C")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000F")]
	public event Action PreCharacterMove
	{
		[Token(Token = "0x600054C")]
		[Address(RVA = "0x9D46BC", Offset = "0x9D46BC", VA = "0x9D46BC")]
		add
		{
		}
		[Token(Token = "0x600054D")]
		[Address(RVA = "0x9D4758", Offset = "0x9D4758", VA = "0x9D4758")]
		remove
		{
		}
	}

	[Token(Token = "0x600054E")]
	[Address(RVA = "0x9D47F4", Offset = "0x9D47F4", VA = "0x9D47F4")]
	private void Awake()
	{
	}

	[Token(Token = "0x600054F")]
	[Address(RVA = "0x9D48D4", Offset = "0x9D48D4", VA = "0x9D48D4")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000550")]
	[Address(RVA = "0x9D4948", Offset = "0x9D4948", VA = "0x9D4948")]
	private void RotatePlayerToHMD()
	{
	}

	[Token(Token = "0x6000551")]
	[Address(RVA = "0x9D4A6C", Offset = "0x9D4A6C", VA = "0x9D4A6C")]
	private void StickMovement()
	{
	}

	[Token(Token = "0x6000552")]
	[Address(RVA = "0x9D4CE4", Offset = "0x9D4CE4", VA = "0x9D4CE4")]
	private void SnapTurn()
	{
	}

	[Token(Token = "0x6000553")]
	[Address(RVA = "0x9D4F04", Offset = "0x9D4F04", VA = "0x9D4F04")]
	public SimpleCapsuleWithStickMovement()
	{
	}
}
[Token(Token = "0x20000E2")]
public abstract class TeleportAimHandler : TeleportSupport
{
	[Token(Token = "0x6000554")]
	[Address(RVA = "0x9D4F24", Offset = "0x9D4F24", VA = "0x9D4F24", Slot = "4")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6000555")]
	[Address(RVA = "0x9D4FB4", Offset = "0x9D4FB4", VA = "0x9D4FB4", Slot = "5")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6000556")]
	public abstract void GetPoints(List<Vector3> points);

	[Token(Token = "0x6000557")]
	[Address(RVA = "0x9D5084", Offset = "0x9D5084", VA = "0x9D5084")]
	protected TeleportAimHandler()
	{
	}
}
[Token(Token = "0x20000E3")]
public class TeleportAimHandlerLaser : TeleportAimHandler
{
	[Token(Token = "0x4000744")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float Range;

	[Token(Token = "0x6000558")]
	[Address(RVA = "0x9D5094", Offset = "0x9D5094", VA = "0x9D5094", Slot = "8")]
	public override void GetPoints(List<Vector3> points)
	{
	}

	[Token(Token = "0x6000559")]
	[Address(RVA = "0x9D5224", Offset = "0x9D5224", VA = "0x9D5224")]
	public TeleportAimHandlerLaser()
	{
	}
}
[Token(Token = "0x20000E4")]
public class TeleportAimHandlerParabolic : TeleportAimHandler
{
	[Token(Token = "0x4000745")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float Range;

	[Token(Token = "0x4000746")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float MinimumElevation;

	[Token(Token = "0x4000747")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float Gravity;

	[Token(Token = "0x4000748")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Range(0.001f, 50f)]
	public float AimVelocity;

	[Token(Token = "0x4000749")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[Range(0.001f, 1f)]
	public float AimStep;

	[Token(Token = "0x600055A")]
	[Address(RVA = "0x9D5234", Offset = "0x9D5234", VA = "0x9D5234", Slot = "8")]
	public override void GetPoints(List<Vector3> points)
	{
	}

	[Token(Token = "0x600055B")]
	[Address(RVA = "0x9D5408", Offset = "0x9D5408", VA = "0x9D5408")]
	public TeleportAimHandlerParabolic()
	{
	}
}
[Token(Token = "0x20000E5")]
public class TeleportAimVisualLaser : TeleportSupport
{
	[Token(Token = "0x400074A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public LineRenderer LaserPrefab;

	[Token(Token = "0x400074B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action _enterAimStateAction;

	[Token(Token = "0x400074C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly Action _exitAimStateAction;

	[Token(Token = "0x400074D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly Action<LocomotionTeleport.AimData> _updateAimDataAction;

	[Token(Token = "0x400074E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private LineRenderer _lineRenderer;

	[Token(Token = "0x400074F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3[] _linePoints;

	[Token(Token = "0x600055C")]
	[Address(RVA = "0x9D541C", Offset = "0x9D541C", VA = "0x9D541C")]
	public TeleportAimVisualLaser()
	{
	}

	[Token(Token = "0x600055D")]
	[Address(RVA = "0x9D5548", Offset = "0x9D5548", VA = "0x9D5548")]
	private void EnterAimState()
	{
	}

	[Token(Token = "0x600055E")]
	[Address(RVA = "0x9D5574", Offset = "0x9D5574", VA = "0x9D5574")]
	private void ExitAimState()
	{
	}

	[Token(Token = "0x600055F")]
	[Address(RVA = "0x9D55A0", Offset = "0x9D55A0", VA = "0x9D55A0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000560")]
	[Address(RVA = "0x9D5644", Offset = "0x9D5644", VA = "0x9D5644", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x6000561")]
	[Address(RVA = "0x9D5698", Offset = "0x9D5698", VA = "0x9D5698", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x6000562")]
	[Address(RVA = "0x9D56E8", Offset = "0x9D56E8", VA = "0x9D56E8")]
	private void UpdateAimData(LocomotionTeleport.AimData obj)
	{
	}
}
[Token(Token = "0x20000E6")]
public class TeleportDestination : MonoBehaviour
{
	[Token(Token = "0x4000750")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool <IsValidDestination>k__BackingField;

	[Token(Token = "0x4000751")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform PositionIndicator;

	[Token(Token = "0x4000752")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform OrientationIndicator;

	[Token(Token = "0x4000753")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Quaternion LandingRotation;

	[NonSerialized]
	[Token(Token = "0x4000754")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public LocomotionTeleport LocomotionTeleport;

	[NonSerialized]
	[Token(Token = "0x4000755")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public LocomotionTeleport.States TeleportState;

	[Token(Token = "0x4000756")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly Action<bool, Vector3?, Quaternion?, Quaternion?> _updateTeleportDestinationAction;

	[Token(Token = "0x4000757")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool _eventsActive;

	[Token(Token = "0x17000059")]
	public bool IsValidDestination
	{
		[Token(Token = "0x6000563")]
		[Address(RVA = "0x9D57E4", Offset = "0x9D57E4", VA = "0x9D57E4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000564")]
		[Address(RVA = "0x9D57EC", Offset = "0x9D57EC", VA = "0x9D57EC")]
		private set
		{
		}
	}

	[Token(Token = "0x14000010")]
	public event Action<TeleportDestination> Deactivated
	{
		[Token(Token = "0x6000569")]
		[Address(RVA = "0x9D5974", Offset = "0x9D5974", VA = "0x9D5974")]
		add
		{
		}
		[Token(Token = "0x600056A")]
		[Address(RVA = "0x9D5A24", Offset = "0x9D5A24", VA = "0x9D5A24")]
		remove
		{
		}
	}

	[Token(Token = "0x6000565")]
	[Address(RVA = "0x9D57F8", Offset = "0x9D57F8", VA = "0x9D57F8")]
	private TeleportDestination()
	{
	}

	[Token(Token = "0x6000566")]
	[Address(RVA = "0x9D587C", Offset = "0x9D587C", VA = "0x9D587C")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x6000567")]
	[Address(RVA = "0x9D5940", Offset = "0x9D5940", VA = "0x9D5940")]
	private void TryDisableEventHandlers()
	{
	}

	[Token(Token = "0x6000568")]
	[Address(RVA = "0x9D5970", Offset = "0x9D5970", VA = "0x9D5970")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x600056B")]
	[Address(RVA = "0x9D271C", Offset = "0x9D271C", VA = "0x9D271C")]
	public void OnDeactivated()
	{
	}

	[Token(Token = "0x600056C")]
	[Address(RVA = "0x9D5AD4", Offset = "0x9D5AD4", VA = "0x9D5AD4")]
	public void Recycle()
	{
	}

	[Token(Token = "0x600056D")]
	[Address(RVA = "0x9D5AF0", Offset = "0x9D5AF0", VA = "0x9D5AF0", Slot = "4")]
	public virtual void UpdateTeleportDestination(bool isValidDestination, Vector3? position, Quaternion? rotation, Quaternion? landingRotation)
	{
	}
}
[Token(Token = "0x20000E7")]
public abstract class TeleportInputHandler : TeleportSupport
{
	[Token(Token = "0x20000E8")]
	private sealed class <TeleportReadyCoroutine>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400075B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400075C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400075D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportInputHandler <>4__this;

		[Token(Token = "0x1700005A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600057A")]
			[Address(RVA = "0x9D60B8", Offset = "0x9D60B8", VA = "0x9D60B8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600057C")]
			[Address(RVA = "0x9D6100", Offset = "0x9D6100", VA = "0x9D6100", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x9D5F24", Offset = "0x9D5F24", VA = "0x9D5F24")]
		[DebuggerHidden]
		public <TeleportReadyCoroutine>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x9D6028", Offset = "0x9D6028", VA = "0x9D6028", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x9D602C", Offset = "0x9D602C", VA = "0x9D602C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x9D60C0", Offset = "0x9D60C0", VA = "0x9D60C0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000E9")]
	private sealed class <TeleportAimCoroutine>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400075E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400075F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000760")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportInputHandler <>4__this;

		[Token(Token = "0x1700005C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000580")]
			[Address(RVA = "0x9D61A4", Offset = "0x9D61A4", VA = "0x9D61A4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000582")]
			[Address(RVA = "0x9D61EC", Offset = "0x9D61EC", VA = "0x9D61EC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x9D5FC0", Offset = "0x9D5FC0", VA = "0x9D5FC0")]
		[DebuggerHidden]
		public <TeleportAimCoroutine>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x9D6108", Offset = "0x9D6108", VA = "0x9D6108", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x9D610C", Offset = "0x9D610C", VA = "0x9D610C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x9D61AC", Offset = "0x9D61AC", VA = "0x9D61AC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000759")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly Action _startReadyAction;

	[Token(Token = "0x400075A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action _startAimAction;

	[Token(Token = "0x600056E")]
	[Address(RVA = "0x9D5CE4", Offset = "0x9D5CE4", VA = "0x9D5CE4")]
	protected TeleportInputHandler()
	{
	}

	[Token(Token = "0x600056F")]
	[Address(RVA = "0x9D5DB8", Offset = "0x9D5DB8", VA = "0x9D5DB8", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x6000570")]
	[Address(RVA = "0x9D5E04", Offset = "0x9D5E04", VA = "0x9D5E04", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x6000571")]
	[Address(RVA = "0x9D5EB0", Offset = "0x9D5EB0", VA = "0x9D5EB0")]
	private IEnumerator TeleportReadyCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000572")]
	[Address(RVA = "0x9D5F4C", Offset = "0x9D5F4C", VA = "0x9D5F4C")]
	private IEnumerator TeleportAimCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000573")]
	public abstract LocomotionTeleport.TeleportIntentions GetIntention();

	[Token(Token = "0x6000574")]
	public abstract void GetAimData(out Ray aimRay);

	[Token(Token = "0x6000575")]
	[Address(RVA = "0x9D5FE8", Offset = "0x9D5FE8", VA = "0x9D5FE8")]
	private void <.ctor>b__2_0()
	{
	}

	[Token(Token = "0x6000576")]
	[Address(RVA = "0x9D6008", Offset = "0x9D6008", VA = "0x9D6008")]
	private void <.ctor>b__2_1()
	{
	}
}
[Token(Token = "0x20000EA")]
public class TeleportInputHandlerHMD : TeleportInputHandler
{
	[Token(Token = "0x4000761")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Transform <Pointer>k__BackingField;

	[Token(Token = "0x4000762")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public OVRInput.RawButton AimButton;

	[Token(Token = "0x4000763")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public OVRInput.RawButton TeleportButton;

	[Token(Token = "0x4000764")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool FastTeleport;

	[Token(Token = "0x1700005E")]
	public Transform Pointer
	{
		[Token(Token = "0x6000583")]
		[Address(RVA = "0x9D61F4", Offset = "0x9D61F4", VA = "0x9D61F4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000584")]
		[Address(RVA = "0x9D61FC", Offset = "0x9D61FC", VA = "0x9D61FC")]
		private set
		{
		}
	}

	[Token(Token = "0x6000585")]
	[Address(RVA = "0x9D6204", Offset = "0x9D6204", VA = "0x9D6204", Slot = "8")]
	public override LocomotionTeleport.TeleportIntentions GetIntention()
	{
		return default(LocomotionTeleport.TeleportIntentions);
	}

	[Token(Token = "0x6000586")]
	[Address(RVA = "0x9D6330", Offset = "0x9D6330", VA = "0x9D6330", Slot = "9")]
	public override void GetAimData(out Ray aimRay)
	{
	}

	[Token(Token = "0x6000587")]
	[Address(RVA = "0x9D63E4", Offset = "0x9D63E4", VA = "0x9D63E4")]
	public TeleportInputHandlerHMD()
	{
	}
}
[Token(Token = "0x20000EB")]
public class TeleportInputHandlerTouch : TeleportInputHandlerHMD
{
	[Token(Token = "0x20000EC")]
	public enum InputModes
	{
		[Token(Token = "0x400076F")]
		CapacitiveButtonForAimAndTeleport,
		[Token(Token = "0x4000770")]
		SeparateButtonsForAimAndTeleport,
		[Token(Token = "0x4000771")]
		ThumbstickTeleport,
		[Token(Token = "0x4000772")]
		ThumbstickTeleportForwardBackOnly
	}

	[Token(Token = "0x20000ED")]
	public enum AimCapTouchButtons
	{
		[Token(Token = "0x4000774")]
		A,
		[Token(Token = "0x4000775")]
		B,
		[Token(Token = "0x4000776")]
		LeftTrigger,
		[Token(Token = "0x4000777")]
		LeftThumbstick,
		[Token(Token = "0x4000778")]
		RightTrigger,
		[Token(Token = "0x4000779")]
		RightThumbstick,
		[Token(Token = "0x400077A")]
		X,
		[Token(Token = "0x400077B")]
		Y
	}

	[Token(Token = "0x4000765")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Transform LeftHand;

	[Token(Token = "0x4000766")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Transform RightHand;

	[Token(Token = "0x4000767")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public InputModes InputMode;

	[Token(Token = "0x4000768")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly OVRInput.RawButton[] _rawButtons;

	[Token(Token = "0x4000769")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly OVRInput.RawTouch[] _rawTouch;

	[Token(Token = "0x400076A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public OVRInput.Controller AimingController;

	[Token(Token = "0x400076B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private OVRInput.Controller InitiatingController;

	[Token(Token = "0x400076C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public AimCapTouchButtons CapacitiveAimAndTeleportButton;

	[Token(Token = "0x400076D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public float ThumbstickTeleportThreshold;

	[Token(Token = "0x6000588")]
	[Address(RVA = "0x9D63E8", Offset = "0x9D63E8", VA = "0x9D63E8", Slot = "8")]
	public override LocomotionTeleport.TeleportIntentions GetIntention()
	{
		return default(LocomotionTeleport.TeleportIntentions);
	}

	[Token(Token = "0x6000589")]
	[Address(RVA = "0x9D681C", Offset = "0x9D681C", VA = "0x9D681C", Slot = "9")]
	public override void GetAimData(out Ray aimRay)
	{
	}

	[Token(Token = "0x600058A")]
	[Address(RVA = "0x9D68D8", Offset = "0x9D68D8", VA = "0x9D68D8")]
	public TeleportInputHandlerTouch()
	{
	}
}
[Token(Token = "0x20000EE")]
public abstract class TeleportOrientationHandler : TeleportSupport
{
	[Token(Token = "0x20000EF")]
	public enum OrientationModes
	{
		[Token(Token = "0x4000780")]
		HeadRelative,
		[Token(Token = "0x4000781")]
		ForwardFacing
	}

	[Token(Token = "0x20000F0")]
	private sealed class <UpdateOrientationCoroutine>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000782")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000783")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000784")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportOrientationHandler <>4__this;

		[Token(Token = "0x1700005F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000597")]
			[Address(RVA = "0x9D6D88", Offset = "0x9D6D88", VA = "0x9D6D88", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000060")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000599")]
			[Address(RVA = "0x9D6DD0", Offset = "0x9D6DD0", VA = "0x9D6DD0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x9D6B98", Offset = "0x9D6B98", VA = "0x9D6B98")]
		[DebuggerHidden]
		public <UpdateOrientationCoroutine>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x9D6CD8", Offset = "0x9D6CD8", VA = "0x9D6CD8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x9D6CDC", Offset = "0x9D6CDC", VA = "0x9D6CDC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x9D6D90", Offset = "0x9D6D90", VA = "0x9D6D90", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400077C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly Action _updateOrientationAction;

	[Token(Token = "0x400077D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action<LocomotionTeleport.AimData> _updateAimDataAction;

	[Token(Token = "0x400077E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected LocomotionTeleport.AimData AimData;

	[Token(Token = "0x600058B")]
	[Address(RVA = "0x9D69C8", Offset = "0x9D69C8", VA = "0x9D69C8")]
	protected TeleportOrientationHandler()
	{
	}

	[Token(Token = "0x600058C")]
	[Address(RVA = "0x9D6AB0", Offset = "0x9D6AB0", VA = "0x9D6AB0")]
	private void UpdateAimData(LocomotionTeleport.AimData aimData)
	{
	}

	[Token(Token = "0x600058D")]
	[Address(RVA = "0x9D6AB8", Offset = "0x9D6AB8", VA = "0x9D6AB8", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x600058E")]
	[Address(RVA = "0x9D6AF0", Offset = "0x9D6AF0", VA = "0x9D6AF0", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x600058F")]
	[Address(RVA = "0x9D6B24", Offset = "0x9D6B24", VA = "0x9D6B24")]
	private IEnumerator UpdateOrientationCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000590")]
	protected abstract void InitializeTeleportDestination();

	[Token(Token = "0x6000591")]
	protected abstract void UpdateTeleportDestination();

	[Token(Token = "0x6000592")]
	[Address(RVA = "0x9D6BC0", Offset = "0x9D6BC0", VA = "0x9D6BC0")]
	protected Quaternion GetLandingOrientation(OrientationModes mode, Quaternion rotation)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000593")]
	[Address(RVA = "0x9D6CB8", Offset = "0x9D6CB8", VA = "0x9D6CB8")]
	private void <.ctor>b__3_0()
	{
	}
}
[Token(Token = "0x20000F1")]
public class TeleportOrientationHandler360 : TeleportOrientationHandler
{
	[Token(Token = "0x600059A")]
	[Address(RVA = "0x9D6DD8", Offset = "0x9D6DD8", VA = "0x9D6DD8", Slot = "8")]
	protected override void InitializeTeleportDestination()
	{
	}

	[Token(Token = "0x600059B")]
	[Address(RVA = "0x9D6DDC", Offset = "0x9D6DDC", VA = "0x9D6DDC", Slot = "9")]
	protected override void UpdateTeleportDestination()
	{
	}

	[Token(Token = "0x600059C")]
	[Address(RVA = "0x9D6E84", Offset = "0x9D6E84", VA = "0x9D6E84")]
	public TeleportOrientationHandler360()
	{
	}
}
[Token(Token = "0x20000F2")]
public class TeleportOrientationHandlerHMD : TeleportOrientationHandler
{
	[Token(Token = "0x4000785")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public OrientationModes OrientationMode;

	[Token(Token = "0x4000786")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public bool UpdateOrientationDuringAim;

	[Token(Token = "0x4000787")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float AimDistanceThreshold;

	[Token(Token = "0x4000788")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float AimDistanceMaxRange;

	[Token(Token = "0x4000789")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Quaternion _initialRotation;

	[Token(Token = "0x600059D")]
	[Address(RVA = "0x9D6E88", Offset = "0x9D6E88", VA = "0x9D6E88", Slot = "8")]
	protected override void InitializeTeleportDestination()
	{
	}

	[Token(Token = "0x600059E")]
	[Address(RVA = "0x9D6ED8", Offset = "0x9D6ED8", VA = "0x9D6ED8", Slot = "9")]
	protected override void UpdateTeleportDestination()
	{
	}

	[Token(Token = "0x600059F")]
	[Address(RVA = "0x9D739C", Offset = "0x9D739C", VA = "0x9D739C")]
	public TeleportOrientationHandlerHMD()
	{
	}
}
[Token(Token = "0x20000F3")]
public class TeleportOrientationHandlerThumbstick : TeleportOrientationHandler
{
	[Token(Token = "0x400078A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public OrientationModes OrientationMode;

	[Token(Token = "0x400078B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public OVRInput.Controller Thumbstick;

	[Token(Token = "0x400078C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float RotateStickThreshold;

	[Token(Token = "0x400078D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private Quaternion _initialRotation;

	[Token(Token = "0x400078E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private Quaternion _currentRotation;

	[Token(Token = "0x400078F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private Vector2 _lastValidDirection;

	[Token(Token = "0x60005A0")]
	[Address(RVA = "0x9D73A0", Offset = "0x9D73A0", VA = "0x9D73A0", Slot = "8")]
	protected override void InitializeTeleportDestination()
	{
	}

	[Token(Token = "0x60005A1")]
	[Address(RVA = "0x9D73D4", Offset = "0x9D73D4", VA = "0x9D73D4", Slot = "9")]
	protected override void UpdateTeleportDestination()
	{
	}

	[Token(Token = "0x60005A2")]
	[Address(RVA = "0x9D78D0", Offset = "0x9D78D0", VA = "0x9D78D0")]
	public TeleportOrientationHandlerThumbstick()
	{
	}
}
[Token(Token = "0x20000F4")]
public class TeleportPoint : MonoBehaviour
{
	[Token(Token = "0x4000790")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float dimmingSpeed;

	[Token(Token = "0x4000791")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float fullIntensity;

	[Token(Token = "0x4000792")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float lowIntensity;

	[Token(Token = "0x4000793")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform destTransform;

	[Token(Token = "0x4000794")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float lastLookAtTime;

	[Token(Token = "0x60005A3")]
	[Address(RVA = "0x9D78E0", Offset = "0x9D78E0", VA = "0x9D78E0")]
	public Transform GetDestTransform()
	{
		return null;
	}

	[Token(Token = "0x60005A4")]
	[Address(RVA = "0x9D78E8", Offset = "0x9D78E8", VA = "0x9D78E8")]
	private void Update()
	{
	}

	[Token(Token = "0x60005A5")]
	[Address(RVA = "0x9D79D4", Offset = "0x9D79D4", VA = "0x9D79D4")]
	public void OnLookAt()
	{
	}

	[Token(Token = "0x60005A6")]
	[Address(RVA = "0x9D79F0", Offset = "0x9D79F0", VA = "0x9D79F0")]
	public TeleportPoint()
	{
	}
}
[Token(Token = "0x20000F5")]
public abstract class TeleportSupport : MonoBehaviour
{
	[Token(Token = "0x4000795")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private LocomotionTeleport <LocomotionTeleport>k__BackingField;

	[Token(Token = "0x4000796")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool _eventsActive;

	[Token(Token = "0x17000061")]
	protected LocomotionTeleport LocomotionTeleport
	{
		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x9D7A08", Offset = "0x9D7A08", VA = "0x9D7A08")]
		get
		{
			return null;
		}
		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x9D7A10", Offset = "0x9D7A10", VA = "0x9D7A10")]
		private set
		{
		}
	}

	[Token(Token = "0x60005A9")]
	[Address(RVA = "0x9D4F4C", Offset = "0x9D4F4C", VA = "0x9D4F4C", Slot = "4")]
	protected virtual void OnEnable()
	{
	}

	[Token(Token = "0x60005AA")]
	[Address(RVA = "0x9D505C", Offset = "0x9D505C", VA = "0x9D505C", Slot = "5")]
	protected virtual void OnDisable()
	{
	}

	[Token(Token = "0x60005AB")]
	[Address(RVA = "0x9D7A18", Offset = "0x9D7A18", VA = "0x9D7A18")]
	private void LogEventHandler(string msg)
	{
	}

	[Token(Token = "0x60005AC")]
	[Address(RVA = "0x9D568C", Offset = "0x9D568C", VA = "0x9D568C", Slot = "6")]
	protected virtual void AddEventHandlers()
	{
	}

	[Token(Token = "0x60005AD")]
	[Address(RVA = "0x9D56E0", Offset = "0x9D56E0", VA = "0x9D56E0", Slot = "7")]
	protected virtual void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x60005AE")]
	[Address(RVA = "0x9D508C", Offset = "0x9D508C", VA = "0x9D508C")]
	protected TeleportSupport()
	{
	}
}
[Token(Token = "0x20000F6")]
public abstract class TeleportTargetHandler : TeleportSupport
{
	[Token(Token = "0x20000F7")]
	private sealed class <TargetAimCoroutine>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400079C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400079D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400079E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportTargetHandler <>4__this;

		[Token(Token = "0x17000062")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60005BA")]
			[Address(RVA = "0x9D8108", Offset = "0x9D8108", VA = "0x9D8108", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000063")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60005BC")]
			[Address(RVA = "0x9D8150", Offset = "0x9D8150", VA = "0x9D8150", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x9D7CC0", Offset = "0x9D7CC0", VA = "0x9D7CC0")]
		[DebuggerHidden]
		public <TargetAimCoroutine>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x9D7E3C", Offset = "0x9D7E3C", VA = "0x9D7E3C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x9D7E40", Offset = "0x9D7E40", VA = "0x9D7E40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x9D8110", Offset = "0x9D8110", VA = "0x9D8110", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000797")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public LayerMask AimCollisionLayerMask;

	[Token(Token = "0x4000798")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected readonly LocomotionTeleport.AimData AimData;

	[Token(Token = "0x4000799")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action _startAimAction;

	[Token(Token = "0x400079A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly List<Vector3> _aimPoints;

	[Token(Token = "0x400079B")]
	private const float ERROR_MARGIN = 0.1f;

	[Token(Token = "0x60005AF")]
	[Address(RVA = "0x9D7AE8", Offset = "0x9D7AE8", VA = "0x9D7AE8")]
	protected TeleportTargetHandler()
	{
	}

	[Token(Token = "0x60005B0")]
	[Address(RVA = "0x9D7C00", Offset = "0x9D7C00", VA = "0x9D7C00", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x60005B1")]
	[Address(RVA = "0x9D7C28", Offset = "0x9D7C28", VA = "0x9D7C28", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x60005B2")]
	[Address(RVA = "0x9D7C4C", Offset = "0x9D7C4C", VA = "0x9D7C4C")]
	private IEnumerator TargetAimCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60005B3")]
	[Address(RVA = "0x9D7CE8", Offset = "0x9D7CE8", VA = "0x9D7CE8", Slot = "8")]
	protected virtual void ResetAimData()
	{
	}

	[Token(Token = "0x60005B4")]
	protected abstract bool ConsiderTeleport(Vector3 start, ref Vector3 end);

	[Token(Token = "0x60005B5")]
	[Address(RVA = "0x9D7D00", Offset = "0x9D7D00", VA = "0x9D7D00", Slot = "10")]
	public virtual Vector3? ConsiderDestination(Vector3 location)
	{
		return null;
	}

	[Token(Token = "0x60005B6")]
	[Address(RVA = "0x9D7E1C", Offset = "0x9D7E1C", VA = "0x9D7E1C")]
	private void <.ctor>b__3_0()
	{
	}
}
[Token(Token = "0x20000F8")]
public class TeleportTargetHandlerNavMesh : TeleportTargetHandler
{
	[Token(Token = "0x400079F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int NavMeshAreaMask;

	[Token(Token = "0x40007A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private NavMeshPath _path;

	[Token(Token = "0x60005BD")]
	[Address(RVA = "0x9D8158", Offset = "0x9D8158", VA = "0x9D8158")]
	private void Awake()
	{
	}

	[Token(Token = "0x60005BE")]
	[Address(RVA = "0x9D81C0", Offset = "0x9D81C0", VA = "0x9D81C0", Slot = "9")]
	protected override bool ConsiderTeleport(Vector3 start, ref Vector3 end)
	{
		return default(bool);
	}

	[Token(Token = "0x60005BF")]
	[Address(RVA = "0x9D8328", Offset = "0x9D8328", VA = "0x9D8328", Slot = "10")]
	public override Vector3? ConsiderDestination(Vector3 location)
	{
		return null;
	}

	[Token(Token = "0x60005C0")]
	[Address(RVA = "0x9D8414", Offset = "0x9D8414", VA = "0x9D8414")]
	public TeleportTargetHandlerNavMesh()
	{
	}
}
[Token(Token = "0x20000F9")]
public class TeleportTargetHandlerNode : TeleportTargetHandler
{
	[Token(Token = "0x40007A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float LOSOffset;

	[Token(Token = "0x40007A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public LayerMask TeleportLayerMask;

	[Token(Token = "0x60005C1")]
	[Address(RVA = "0x9D8420", Offset = "0x9D8420", VA = "0x9D8420", Slot = "9")]
	protected override bool ConsiderTeleport(Vector3 start, ref Vector3 end)
	{
		return default(bool);
	}

	[Token(Token = "0x60005C2")]
	[Address(RVA = "0x9D8618", Offset = "0x9D8618", VA = "0x9D8618")]
	public TeleportTargetHandlerNode()
	{
	}
}
[Token(Token = "0x20000FA")]
public class TeleportTargetHandlerPhysical : TeleportTargetHandler
{
	[Token(Token = "0x60005C3")]
	[Address(RVA = "0x9D8624", Offset = "0x9D8624", VA = "0x9D8624", Slot = "9")]
	protected override bool ConsiderTeleport(Vector3 start, ref Vector3 end)
	{
		return default(bool);
	}

	[Token(Token = "0x60005C4")]
	[Address(RVA = "0x9D878C", Offset = "0x9D878C", VA = "0x9D878C")]
	public TeleportTargetHandlerPhysical()
	{
	}
}
[Token(Token = "0x20000FB")]
public abstract class TeleportTransition : TeleportSupport
{
	[Token(Token = "0x60005C5")]
	[Address(RVA = "0x9D8790", Offset = "0x9D8790", VA = "0x9D8790", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x60005C6")]
	[Address(RVA = "0x9D8814", Offset = "0x9D8814", VA = "0x9D8814", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x60005C7")]
	protected abstract void LocomotionTeleportOnEnterStateTeleporting();

	[Token(Token = "0x60005C8")]
	[Address(RVA = "0x9D8894", Offset = "0x9D8894", VA = "0x9D8894")]
	protected TeleportTransition()
	{
	}
}
[Token(Token = "0x20000FC")]
public class TeleportTransitionBlink : TeleportTransition
{
	[Token(Token = "0x20000FD")]
	private sealed class <BlinkCoroutine>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40007A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40007A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40007A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportTransitionBlink <>4__this;

		[Token(Token = "0x40007A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <elapsedTime>5__2;

		[Token(Token = "0x40007AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <teleportTime>5__3;

		[Token(Token = "0x40007AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool <teleported>5__4;

		[Token(Token = "0x17000064")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60005CF")]
			[Address(RVA = "0x9D8BF8", Offset = "0x9D8BF8", VA = "0x9D8BF8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000065")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60005D1")]
			[Address(RVA = "0x9D8C40", Offset = "0x9D8C40", VA = "0x9D8C40", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x9D8930", Offset = "0x9D8930", VA = "0x9D8930")]
		[DebuggerHidden]
		public <BlinkCoroutine>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x9D8AF4", Offset = "0x9D8AF4", VA = "0x9D8AF4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x9D8AF8", Offset = "0x9D8AF8", VA = "0x9D8AF8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x9D8C00", Offset = "0x9D8C00", VA = "0x9D8C00", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40007A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Range(0.01f, 2f)]
	public float TransitionDuration;

	[Token(Token = "0x40007A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Range(0f, 1f)]
	public float TeleportDelay;

	[Token(Token = "0x40007A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public AnimationCurve FadeLevels;

	[Token(Token = "0x60005C9")]
	[Address(RVA = "0x9D889C", Offset = "0x9D889C", VA = "0x9D889C", Slot = "8")]
	protected override void LocomotionTeleportOnEnterStateTeleporting()
	{
	}

	[Token(Token = "0x60005CA")]
	[Address(RVA = "0x9D88BC", Offset = "0x9D88BC", VA = "0x9D88BC")]
	protected IEnumerator BlinkCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60005CB")]
	[Address(RVA = "0x9D8958", Offset = "0x9D8958", VA = "0x9D8958")]
	public TeleportTransitionBlink()
	{
	}
}
[Token(Token = "0x20000FE")]
public class TeleportTransitionInstant : TeleportTransition
{
	[Token(Token = "0x60005D2")]
	[Address(RVA = "0x9D8C48", Offset = "0x9D8C48", VA = "0x9D8C48", Slot = "8")]
	protected override void LocomotionTeleportOnEnterStateTeleporting()
	{
	}

	[Token(Token = "0x60005D3")]
	[Address(RVA = "0x9D8C60", Offset = "0x9D8C60", VA = "0x9D8C60")]
	public TeleportTransitionInstant()
	{
	}
}
[Token(Token = "0x20000FF")]
public class TeleportTransitionWarp : TeleportTransition
{
	[Token(Token = "0x2000100")]
	private sealed class <DoWarp>d__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40007AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40007AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40007B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportTransitionWarp <>4__this;

		[Token(Token = "0x40007B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 <startPosition>5__2;

		[Token(Token = "0x40007B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <elapsedTime>5__3;

		[Token(Token = "0x17000066")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60005DA")]
			[Address(RVA = "0x9D8E84", Offset = "0x9D8E84", VA = "0x9D8E84", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000067")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60005DC")]
			[Address(RVA = "0x9D8ECC", Offset = "0x9D8ECC", VA = "0x9D8ECC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x9D8CFC", Offset = "0x9D8CFC", VA = "0x9D8CFC")]
		[DebuggerHidden]
		public <DoWarp>d__3(int <>1__state)
		{
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x9D8D6C", Offset = "0x9D8D6C", VA = "0x9D8D6C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x9D8D70", Offset = "0x9D8D70", VA = "0x9D8D70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x9D8E8C", Offset = "0x9D8E8C", VA = "0x9D8E8C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40007AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Range(0.01f, 1f)]
	public float TransitionDuration;

	[Token(Token = "0x40007AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AnimationCurve PositionLerp;

	[Token(Token = "0x60005D4")]
	[Address(RVA = "0x9D8C68", Offset = "0x9D8C68", VA = "0x9D8C68", Slot = "8")]
	protected override void LocomotionTeleportOnEnterStateTeleporting()
	{
	}

	[Token(Token = "0x60005D5")]
	[Address(RVA = "0x9D8C88", Offset = "0x9D8C88", VA = "0x9D8C88")]
	private IEnumerator DoWarp()
	{
		return null;
	}

	[Token(Token = "0x60005D6")]
	[Address(RVA = "0x9D8D24", Offset = "0x9D8D24", VA = "0x9D8D24")]
	public TeleportTransitionWarp()
	{
	}
}
[Token(Token = "0x2000101")]
public static class NativeVideoPlayer
{
	[Token(Token = "0x2000102")]
	public enum StereoMode
	{
		[Token(Token = "0x40007CA")]
		Unknown = -1,
		[Token(Token = "0x40007CB")]
		Mono,
		[Token(Token = "0x40007CC")]
		TopBottom,
		[Token(Token = "0x40007CD")]
		LeftRight,
		[Token(Token = "0x40007CE")]
		Mesh
	}

	[Token(Token = "0x40007B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static IntPtr? _Activity;

	[Token(Token = "0x40007B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static IntPtr? _VideoPlayerClass;

	[Token(Token = "0x40007B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static readonly jvalue[] EmptyParams;

	[Token(Token = "0x40007B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static IntPtr getIsPlayingMethodId;

	[Token(Token = "0x40007B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static IntPtr getDurationMethodId;

	[Token(Token = "0x40007B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static IntPtr getStereoModeMethodId;

	[Token(Token = "0x40007B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static IntPtr getWidthMethodId;

	[Token(Token = "0x40007BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static IntPtr getHeightMethodId;

	[Token(Token = "0x40007BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private static IntPtr getPlaybackPositionMethodId;

	[Token(Token = "0x40007BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private static IntPtr setPlaybackPositionMethodId;

	[Token(Token = "0x40007BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static jvalue[] setPlaybackPositionParams;

	[Token(Token = "0x40007BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private static IntPtr playVideoMethodId;

	[Token(Token = "0x40007BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private static jvalue[] playVideoParams;

	[Token(Token = "0x40007C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private static IntPtr stopMethodId;

	[Token(Token = "0x40007C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private static IntPtr resumeMethodId;

	[Token(Token = "0x40007C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private static IntPtr pauseMethodId;

	[Token(Token = "0x40007C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private static IntPtr setPlaybackSpeedMethodId;

	[Token(Token = "0x40007C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private static jvalue[] setPlaybackSpeedParams;

	[Token(Token = "0x40007C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private static IntPtr setLoopingMethodId;

	[Token(Token = "0x40007C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private static jvalue[] setLoopingParams;

	[Token(Token = "0x40007C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private static IntPtr setListenerRotationQuaternionMethodId;

	[Token(Token = "0x40007C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private static jvalue[] setListenerRotationQuaternionParams;

	[Token(Token = "0x17000068")]
	private static IntPtr VideoPlayerClass
	{
		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x9D8ED4", Offset = "0x9D8ED4", VA = "0x9D8ED4")]
		get
		{
			return default(IntPtr);
		}
	}

	[Token(Token = "0x17000069")]
	private static IntPtr Activity
	{
		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x9D91C4", Offset = "0x9D91C4", VA = "0x9D91C4")]
		get
		{
			return default(IntPtr);
		}
	}

	[Token(Token = "0x1700006A")]
	public static bool IsAvailable
	{
		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x9D9444", Offset = "0x9D9444", VA = "0x9D9444")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700006B")]
	public static bool IsPlaying
	{
		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x9D94B8", Offset = "0x9D94B8", VA = "0x9D94B8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700006C")]
	public static long Duration
	{
		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x9D95BC", Offset = "0x9D95BC", VA = "0x9D95BC")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x1700006D")]
	public static StereoMode VideoStereoMode
	{
		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x9D96C4", Offset = "0x9D96C4", VA = "0x9D96C4")]
		get
		{
			return default(StereoMode);
		}
	}

	[Token(Token = "0x1700006E")]
	public static int VideoWidth
	{
		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x9D97CC", Offset = "0x9D97CC", VA = "0x9D97CC")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700006F")]
	public static int VideoHeight
	{
		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x9D98D4", Offset = "0x9D98D4", VA = "0x9D98D4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000070")]
	public static long PlaybackPosition
	{
		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x9D99DC", Offset = "0x9D99DC", VA = "0x9D99DC")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x9D9AE4", Offset = "0x9D9AE4", VA = "0x9D9AE4")]
		set
		{
		}
	}

	[Token(Token = "0x60005E7")]
	[Address(RVA = "0x9D9C4C", Offset = "0x9D9C4C", VA = "0x9D9C4C")]
	public static void PlayVideo(string path, string drmLicenseUrl, IntPtr surfaceObj)
	{
	}

	[Token(Token = "0x60005E8")]
	[Address(RVA = "0x9D9E64", Offset = "0x9D9E64", VA = "0x9D9E64")]
	public static void Stop()
	{
	}

	[Token(Token = "0x60005E9")]
	[Address(RVA = "0x9D9F6C", Offset = "0x9D9F6C", VA = "0x9D9F6C")]
	public static void Play()
	{
	}

	[Token(Token = "0x60005EA")]
	[Address(RVA = "0x9DA074", Offset = "0x9DA074", VA = "0x9DA074")]
	public static void Pause()
	{
	}

	[Token(Token = "0x60005EB")]
	[Address(RVA = "0x9DA17C", Offset = "0x9DA17C", VA = "0x9DA17C")]
	public static void SetPlaybackSpeed(float speed)
	{
	}

	[Token(Token = "0x60005EC")]
	[Address(RVA = "0x9DA2EC", Offset = "0x9DA2EC", VA = "0x9DA2EC")]
	public static void SetLooping(bool looping)
	{
	}

	[Token(Token = "0x60005ED")]
	[Address(RVA = "0x9DA458", Offset = "0x9DA458", VA = "0x9DA458")]
	public static void SetListenerRotation(Quaternion rotation)
	{
	}
}
[Token(Token = "0x2000103")]
public class ButtonDownListener : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
{
	[Token(Token = "0x14000011")]
	public event Action onButtonDown
	{
		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x9DA6AC", Offset = "0x9DA6AC", VA = "0x9DA6AC")]
		add
		{
		}
		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x9DA748", Offset = "0x9DA748", VA = "0x9DA748")]
		remove
		{
		}
	}

	[Token(Token = "0x60005F1")]
	[Address(RVA = "0x9DA7E4", Offset = "0x9DA7E4", VA = "0x9DA7E4", Slot = "4")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60005F2")]
	[Address(RVA = "0x9DA800", Offset = "0x9DA800", VA = "0x9DA800")]
	public ButtonDownListener()
	{
	}
}
[Token(Token = "0x2000104")]
public class MediaPlayerImage : Image
{
	[Token(Token = "0x2000105")]
	public enum ButtonType
	{
		[Token(Token = "0x40007D2")]
		Play,
		[Token(Token = "0x40007D3")]
		Pause,
		[Token(Token = "0x40007D4")]
		FastForward,
		[Token(Token = "0x40007D5")]
		Rewind,
		[Token(Token = "0x40007D6")]
		SkipForward,
		[Token(Token = "0x40007D7")]
		SkipBack,
		[Token(Token = "0x40007D8")]
		Stop
	}

	[Token(Token = "0x40007D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	[SerializeField]
	private ButtonType m_ButtonType;

	[Token(Token = "0x17000071")]
	public ButtonType buttonType
	{
		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x9DA808", Offset = "0x9DA808", VA = "0x9DA808")]
		get
		{
			return default(ButtonType);
		}
		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x9DA810", Offset = "0x9DA810", VA = "0x9DA810")]
		set
		{
		}
	}

	[Token(Token = "0x60005F5")]
	[Address(RVA = "0x9DA834", Offset = "0x9DA834", VA = "0x9DA834", Slot = "43")]
	protected override void OnPopulateMesh(VertexHelper toFill)
	{
	}

	[Token(Token = "0x60005F6")]
	[Address(RVA = "0x9DB688", Offset = "0x9DB688", VA = "0x9DB688")]
	public MediaPlayerImage()
	{
	}
}
[Token(Token = "0x2000106")]
public class MoviePlayerSample : MonoBehaviour
{
	[Token(Token = "0x2000107")]
	public enum VideoShape
	{
		[Token(Token = "0x40007ED")]
		_360,
		[Token(Token = "0x40007EE")]
		_180,
		[Token(Token = "0x40007EF")]
		Quad
	}

	[Token(Token = "0x2000108")]
	public enum VideoStereo
	{
		[Token(Token = "0x40007F1")]
		Mono,
		[Token(Token = "0x40007F2")]
		TopBottom,
		[Token(Token = "0x40007F3")]
		LeftRight,
		[Token(Token = "0x40007F4")]
		BottomTop
	}

	[Token(Token = "0x2000109")]
	private sealed class <Start>d__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40007F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40007F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40007F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MoviePlayerSample <>4__this;

		[Token(Token = "0x17000075")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600060D")]
			[Address(RVA = "0x9DCBB0", Offset = "0x9DCBB0", VA = "0x9DCBB0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000076")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600060F")]
			[Address(RVA = "0x9DCBF8", Offset = "0x9DCBF8", VA = "0x9DCBF8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0x9DBD6C", Offset = "0x9DBD6C", VA = "0x9DBD6C")]
		[DebuggerHidden]
		public <Start>d__33(int <>1__state)
		{
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0x9DCA04", Offset = "0x9DCA04", VA = "0x9DCA04", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0x9DCA08", Offset = "0x9DCA08", VA = "0x9DCA08", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0x9DCBB8", Offset = "0x9DCBB8", VA = "0x9DCBB8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200010A")]
	private sealed class <>c__DisplayClass34_0
	{
		[Token(Token = "0x40007F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string moviePath;

		[Token(Token = "0x40007F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string drmLicencesUrl;

		[Token(Token = "0x40007FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MoviePlayerSample <>4__this;

		[Token(Token = "0x6000610")]
		[Address(RVA = "0x9DC064", Offset = "0x9DC064", VA = "0x9DC064")]
		public <>c__DisplayClass34_0()
		{
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0x9DCC00", Offset = "0x9DCC00", VA = "0x9DCC00")]
		internal void <Play>b__0()
		{
		}
	}

	[Token(Token = "0x40007D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool videoPausedBeforeAppPause;

	[Token(Token = "0x40007DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private VideoPlayer videoPlayer;

	[Token(Token = "0x40007DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private OVROverlay overlay;

	[Token(Token = "0x40007DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Renderer mediaRenderer;

	[Token(Token = "0x40007DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool <IsPlaying>k__BackingField;

	[Token(Token = "0x40007DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private long <Duration>k__BackingField;

	[Token(Token = "0x40007DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private long <PlaybackPosition>k__BackingField;

	[Token(Token = "0x40007E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private RenderTexture copyTexture;

	[Token(Token = "0x40007E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Material externalTex2DMaterial;

	[Token(Token = "0x40007E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public string MovieName;

	[Token(Token = "0x40007E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public string DrmLicenseUrl;

	[Token(Token = "0x40007E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public bool LoopVideo;

	[Token(Token = "0x40007E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public VideoShape Shape;

	[Token(Token = "0x40007E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public VideoStereo Stereo;

	[Token(Token = "0x40007E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public bool AutoDetectStereoLayout;

	[Token(Token = "0x40007E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7D")]
	public bool DisplayMono;

	[Token(Token = "0x40007E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private VideoShape _LastShape;

	[Token(Token = "0x40007EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private VideoStereo _LastStereo;

	[Token(Token = "0x40007EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool _LastDisplayMono;

	[Token(Token = "0x17000072")]
	public bool IsPlaying
	{
		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x9DB6E0", Offset = "0x9DB6E0", VA = "0x9DB6E0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x9DB6E8", Offset = "0x9DB6E8", VA = "0x9DB6E8")]
		private set
		{
		}
	}

	[Token(Token = "0x17000073")]
	public long Duration
	{
		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x9DB6F4", Offset = "0x9DB6F4", VA = "0x9DB6F4")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x9DB6FC", Offset = "0x9DB6FC", VA = "0x9DB6FC")]
		private set
		{
		}
	}

	[Token(Token = "0x17000074")]
	public long PlaybackPosition
	{
		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x9DB704", Offset = "0x9DB704", VA = "0x9DB704")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x9DB70C", Offset = "0x9DB70C", VA = "0x9DB70C")]
		private set
		{
		}
	}

	[Token(Token = "0x60005FD")]
	[Address(RVA = "0x9DB714", Offset = "0x9DB714", VA = "0x9DB714")]
	private void Awake()
	{
	}

	[Token(Token = "0x60005FE")]
	[Address(RVA = "0x9DB998", Offset = "0x9DB998", VA = "0x9DB998")]
	private bool IsLocalVideo(string movieName)
	{
		return default(bool);
	}

	[Token(Token = "0x60005FF")]
	[Address(RVA = "0x9DB9F8", Offset = "0x9DB9F8", VA = "0x9DB9F8")]
	private void UpdateShapeAndStereo()
	{
	}

	[Token(Token = "0x6000600")]
	[Address(RVA = "0x9DBCF8", Offset = "0x9DBCF8", VA = "0x9DBCF8")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6000601")]
	[Address(RVA = "0x9DBD94", Offset = "0x9DBD94", VA = "0x9DBD94")]
	public void Play(string moviePath, string drmLicencesUrl)
	{
	}

	[Token(Token = "0x6000602")]
	[Address(RVA = "0x9DC06C", Offset = "0x9DC06C", VA = "0x9DC06C")]
	public void Play()
	{
	}

	[Token(Token = "0x6000603")]
	[Address(RVA = "0x9DC0F0", Offset = "0x9DC0F0", VA = "0x9DC0F0")]
	public void Pause()
	{
	}

	[Token(Token = "0x6000604")]
	[Address(RVA = "0x9DC170", Offset = "0x9DC170", VA = "0x9DC170")]
	public void SeekTo(long position)
	{
	}

	[Token(Token = "0x6000605")]
	[Address(RVA = "0x9DC25C", Offset = "0x9DC25C", VA = "0x9DC25C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000606")]
	[Address(RVA = "0x9DC7F8", Offset = "0x9DC7F8", VA = "0x9DC7F8")]
	public void SetPlaybackSpeed(float speed)
	{
	}

	[Token(Token = "0x6000607")]
	[Address(RVA = "0x9DC894", Offset = "0x9DC894", VA = "0x9DC894")]
	public void Stop()
	{
	}

	[Token(Token = "0x6000608")]
	[Address(RVA = "0x9DC914", Offset = "0x9DC914", VA = "0x9DC914")]
	private void OnApplicationPause(bool appWasPaused)
	{
	}

	[Token(Token = "0x6000609")]
	[Address(RVA = "0x9DC9F4", Offset = "0x9DC9F4", VA = "0x9DC9F4")]
	public MoviePlayerSample()
	{
	}
}
[Token(Token = "0x200010B")]
public class MoviePlayerSampleControls : MonoBehaviour
{
	[Token(Token = "0x200010C")]
	private enum PlaybackState
	{
		[Token(Token = "0x4000811")]
		Playing,
		[Token(Token = "0x4000812")]
		Paused,
		[Token(Token = "0x4000813")]
		Rewinding,
		[Token(Token = "0x4000814")]
		FastForwarding
	}

	[Token(Token = "0x40007FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MoviePlayerSample Player;

	[Token(Token = "0x40007FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OVRInputModule InputModule;

	[Token(Token = "0x40007FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OVRGazePointer GazePointer;

	[Token(Token = "0x40007FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject LeftHand;

	[Token(Token = "0x40007FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject RightHand;

	[Token(Token = "0x4000800")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Canvas Canvas;

	[Token(Token = "0x4000801")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ButtonDownListener PlayPause;

	[Token(Token = "0x4000802")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public MediaPlayerImage PlayPauseImage;

	[Token(Token = "0x4000803")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Slider ProgressBar;

	[Token(Token = "0x4000804")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public ButtonDownListener FastForward;

	[Token(Token = "0x4000805")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public MediaPlayerImage FastForwardImage;

	[Token(Token = "0x4000806")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public ButtonDownListener Rewind;

	[Token(Token = "0x4000807")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public MediaPlayerImage RewindImage;

	[Token(Token = "0x4000808")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float TimeoutTime;

	[Token(Token = "0x4000809")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private bool _isVisible;

	[Token(Token = "0x400080A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private float _lastButtonTime;

	[Token(Token = "0x400080B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private bool _didSeek;

	[Token(Token = "0x400080C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private long _seekPreviousPosition;

	[Token(Token = "0x400080D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private long _rewindStartPosition;

	[Token(Token = "0x400080E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private float _rewindStartTime;

	[Token(Token = "0x400080F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private PlaybackState _state;

	[Token(Token = "0x6000612")]
	[Address(RVA = "0x9DCCD4", Offset = "0x9DCCD4", VA = "0x9DCCD4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000613")]
	[Address(RVA = "0x9DD000", Offset = "0x9DD000", VA = "0x9DD000")]
	private void OnPlayPauseClicked()
	{
	}

	[Token(Token = "0x6000614")]
	[Address(RVA = "0x9DD1D0", Offset = "0x9DD1D0", VA = "0x9DD1D0")]
	private void OnFastForwardClicked()
	{
	}

	[Token(Token = "0x6000615")]
	[Address(RVA = "0x9DD2F4", Offset = "0x9DD2F4", VA = "0x9DD2F4")]
	private void OnRewindClicked()
	{
	}

	[Token(Token = "0x6000616")]
	[Address(RVA = "0x9DD3F0", Offset = "0x9DD3F0", VA = "0x9DD3F0")]
	private void OnSeekBarMoved(float value)
	{
	}

	[Token(Token = "0x6000617")]
	[Address(RVA = "0x9DD2C8", Offset = "0x9DD2C8", VA = "0x9DD2C8")]
	private void Seek(long pos)
	{
	}

	[Token(Token = "0x6000618")]
	[Address(RVA = "0x9DD450", Offset = "0x9DD450", VA = "0x9DD450")]
	private void Update()
	{
	}

	[Token(Token = "0x6000619")]
	[Address(RVA = "0x9DCF00", Offset = "0x9DCF00", VA = "0x9DCF00")]
	private void SetVisible(bool visible)
	{
	}

	[Token(Token = "0x600061A")]
	[Address(RVA = "0x9DD780", Offset = "0x9DD780", VA = "0x9DD780")]
	public MoviePlayerSampleControls()
	{
	}
}
[Token(Token = "0x200010D")]
public static class VectorUtil
{
	[Token(Token = "0x600061B")]
	[Address(RVA = "0x9DC780", Offset = "0x9DC780", VA = "0x9DC780")]
	public static Vector4 ToVector(this Rect rect)
	{
		return default(Vector4);
	}
}
[Token(Token = "0x200010E")]
public class AppDeeplinkUI : MonoBehaviour
{
	[Token(Token = "0x4000815")]
	private const ulong UNITY_COMPANION_APP_ID = 3535750239844224uL;

	[Token(Token = "0x4000816")]
	private const ulong UNREAL_COMPANION_APP_ID = 4055411724486843uL;

	[Token(Token = "0x4000817")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private RectTransform deeplinkAppId;

	[Token(Token = "0x4000818")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private RectTransform deeplinkMessage;

	[Token(Token = "0x4000819")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private RectTransform uiLaunchType;

	[Token(Token = "0x400081A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private RectTransform uiLaunchSource;

	[Token(Token = "0x400081B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private RectTransform uiDeepLinkMessage;

	[Token(Token = "0x400081C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool inMenu;

	[Token(Token = "0x600061C")]
	[Address(RVA = "0x9DD790", Offset = "0x9DD790", VA = "0x9DD790")]
	private void Start()
	{
	}

	[Token(Token = "0x600061D")]
	[Address(RVA = "0x9DDDB0", Offset = "0x9DDDB0", VA = "0x9DDDB0")]
	private void Update()
	{
	}

	[Token(Token = "0x600061E")]
	[Address(RVA = "0x9DE004", Offset = "0x9DE004", VA = "0x9DE004")]
	private void LaunchUnrealDeeplinkSample()
	{
	}

	[Token(Token = "0x600061F")]
	[Address(RVA = "0x9DE168", Offset = "0x9DE168", VA = "0x9DE168")]
	private void LaunchSelf()
	{
	}

	[Token(Token = "0x6000620")]
	[Address(RVA = "0x9DE2D0", Offset = "0x9DE2D0", VA = "0x9DE2D0")]
	private void LaunchOtherApp()
	{
	}

	[Token(Token = "0x6000621")]
	[Address(RVA = "0x9DE454", Offset = "0x9DE454", VA = "0x9DE454")]
	public AppDeeplinkUI()
	{
	}
}
[Token(Token = "0x200010F")]
public class CustomDebugUI : MonoBehaviour
{
	[Token(Token = "0x400081D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RectTransform textPrefab;

	[Token(Token = "0x400081E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static CustomDebugUI instance;

	[Token(Token = "0x400081F")]
	private const BindingFlags privateFlags = BindingFlags.Instance | BindingFlags.NonPublic;

	[Token(Token = "0x6000622")]
	[Address(RVA = "0x9DE464", Offset = "0x9DE464", VA = "0x9DE464")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000623")]
	[Address(RVA = "0x9DDB58", Offset = "0x9DDB58", VA = "0x9DDB58")]
	public RectTransform AddTextField(string label, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x6000624")]
	[Address(RVA = "0x9DE4BC", Offset = "0x9DE4BC", VA = "0x9DE4BC")]
	public void RemoveFromCanvas(RectTransform element, int targetCanvas = 0)
	{
	}

	[Token(Token = "0x6000625")]
	[Address(RVA = "0x9DE6D8", Offset = "0x9DE6D8", VA = "0x9DE6D8")]
	public CustomDebugUI()
	{
	}
}
[Token(Token = "0x2000110")]
public class DebugUISample : MonoBehaviour
{
	[Token(Token = "0x4000820")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool inMenu;

	[Token(Token = "0x4000821")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Text sliderText;

	[Token(Token = "0x6000626")]
	[Address(RVA = "0x9DE6E0", Offset = "0x9DE6E0", VA = "0x9DE6E0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000627")]
	[Address(RVA = "0x9DEC40", Offset = "0x9DEC40", VA = "0x9DEC40")]
	public void TogglePressed(Toggle t)
	{
	}

	[Token(Token = "0x6000628")]
	[Address(RVA = "0x9DECEC", Offset = "0x9DECEC", VA = "0x9DECEC")]
	public void RadioPressed(string radioLabel, string group, Toggle t)
	{
	}

	[Token(Token = "0x6000629")]
	[Address(RVA = "0x9DEF7C", Offset = "0x9DEF7C", VA = "0x9DEF7C")]
	public void SliderPressed(float f)
	{
	}

	[Token(Token = "0x600062A")]
	[Address(RVA = "0x9DF050", Offset = "0x9DF050", VA = "0x9DF050")]
	private void Update()
	{
	}

	[Token(Token = "0x600062B")]
	[Address(RVA = "0x9DF128", Offset = "0x9DF128", VA = "0x9DF128")]
	private void LogButtonPressed()
	{
	}

	[Token(Token = "0x600062C")]
	[Address(RVA = "0x9DF190", Offset = "0x9DF190", VA = "0x9DF190")]
	public DebugUISample()
	{
	}

	[Token(Token = "0x600062D")]
	[Address(RVA = "0x9DF198", Offset = "0x9DF198", VA = "0x9DF198")]
	private void <Start>b__2_0(Toggle t)
	{
	}

	[Token(Token = "0x600062E")]
	[Address(RVA = "0x9DF200", Offset = "0x9DF200", VA = "0x9DF200")]
	private void <Start>b__2_1(Toggle t)
	{
	}

	[Token(Token = "0x600062F")]
	[Address(RVA = "0x9DF268", Offset = "0x9DF268", VA = "0x9DF268")]
	private void <Start>b__2_2(Toggle t)
	{
	}

	[Token(Token = "0x6000630")]
	[Address(RVA = "0x9DF2D0", Offset = "0x9DF2D0", VA = "0x9DF2D0")]
	private void <Start>b__2_3(Toggle t)
	{
	}
}
[Token(Token = "0x2000111")]
public class AnalyticsUI : MonoBehaviour
{
	[Token(Token = "0x6000631")]
	[Address(RVA = "0x9DF338", Offset = "0x9DF338", VA = "0x9DF338")]
	public AnalyticsUI()
	{
	}
}
[Token(Token = "0x2000112")]
public class SampleUI : MonoBehaviour
{
	[Token(Token = "0x4000822")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private RectTransform collectionButton;

	[Token(Token = "0x4000823")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private RectTransform inputText;

	[Token(Token = "0x4000824")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private RectTransform valueText;

	[Token(Token = "0x4000825")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool inMenu;

	[Token(Token = "0x6000632")]
	[Address(RVA = "0x9DF340", Offset = "0x9DF340", VA = "0x9DF340")]
	private void Start()
	{
	}

	[Token(Token = "0x6000633")]
	[Address(RVA = "0x9DF3D8", Offset = "0x9DF3D8", VA = "0x9DF3D8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000634")]
	[Address(RVA = "0x9DF4B0", Offset = "0x9DF4B0", VA = "0x9DF4B0")]
	private string GetText()
	{
		return null;
	}

	[Token(Token = "0x6000635")]
	[Address(RVA = "0x9DF50C", Offset = "0x9DF50C", VA = "0x9DF50C")]
	public SampleUI()
	{
	}
}
[Token(Token = "0x2000113")]
public class StartCrashlytics : MonoBehaviour
{
	[Token(Token = "0x6000636")]
	[Address(RVA = "0x9DF514", Offset = "0x9DF514", VA = "0x9DF514")]
	public StartCrashlytics()
	{
	}
}
[Token(Token = "0x2000114")]
public class HandsActiveChecker : MonoBehaviour
{
	[Token(Token = "0x2000115")]
	private sealed class <GetCenterEye>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400082A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400082B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400082C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HandsActiveChecker <>4__this;

		[Token(Token = "0x17000077")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600063E")]
			[Address(RVA = "0x9DF924", Offset = "0x9DF924", VA = "0x9DF924", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000078")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000640")]
			[Address(RVA = "0x9DF96C", Offset = "0x9DF96C", VA = "0x9DF96C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0x9DF7C0", Offset = "0x9DF7C0", VA = "0x9DF7C0")]
		[DebuggerHidden]
		public <GetCenterEye>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0x9DF7F0", Offset = "0x9DF7F0", VA = "0x9DF7F0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0x9DF7F4", Offset = "0x9DF7F4", VA = "0x9DF7F4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x9DF92C", Offset = "0x9DF92C", VA = "0x9DF92C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000826")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject _notificationPrefab;

	[Token(Token = "0x4000827")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject _notification;

	[Token(Token = "0x4000828")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private OVRCameraRig _cameraRig;

	[Token(Token = "0x4000829")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Transform _centerEye;

	[Token(Token = "0x6000637")]
	[Address(RVA = "0x9DF51C", Offset = "0x9DF51C", VA = "0x9DF51C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000638")]
	[Address(RVA = "0x9DF628", Offset = "0x9DF628", VA = "0x9DF628")]
	private void Update()
	{
	}

	[Token(Token = "0x6000639")]
	[Address(RVA = "0x9DF5B4", Offset = "0x9DF5B4", VA = "0x9DF5B4")]
	private IEnumerator GetCenterEye()
	{
		return null;
	}

	[Token(Token = "0x600063A")]
	[Address(RVA = "0x9DF7E8", Offset = "0x9DF7E8", VA = "0x9DF7E8")]
	public HandsActiveChecker()
	{
	}
}
[Token(Token = "0x2000116")]
[ExecuteInEditMode]
public class CharacterCapsule : MonoBehaviour
{
	[Token(Token = "0x400082D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private CharacterController _character;

	[Token(Token = "0x400082E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private MeshFilter _meshFilter;

	[Token(Token = "0x400082F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float _height;

	[Token(Token = "0x4000830")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float _radius;

	[Token(Token = "0x4000831")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Range(4f, 32f)]
	public int SubdivisionsU;

	[Token(Token = "0x4000832")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[Range(4f, 32f)]
	public int SubdivisionsV;

	[Token(Token = "0x4000833")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int _subdivisionU;

	[Token(Token = "0x4000834")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private int _subdivisionV;

	[Token(Token = "0x4000835")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Vector3[] _vertices;

	[Token(Token = "0x4000836")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int[] _triangles;

	[Token(Token = "0x6000641")]
	[Address(RVA = "0x9DF974", Offset = "0x9DF974", VA = "0x9DF974")]
	private void Update()
	{
	}

	[Token(Token = "0x6000642")]
	[Address(RVA = "0x9E131C", Offset = "0x9E131C", VA = "0x9E131C")]
	public CharacterCapsule()
	{
	}
}
[Token(Token = "0x2000117")]
public class LocomotionSampleSupport : MonoBehaviour
{
	[Token(Token = "0x4000837")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private LocomotionController lc;

	[Token(Token = "0x4000838")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool inMenu;

	[Token(Token = "0x17000079")]
	private LocomotionTeleport TeleportController
	{
		[Token(Token = "0x6000643")]
		[Address(RVA = "0x9E1324", Offset = "0x9E1324", VA = "0x9E1324")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000644")]
	[Address(RVA = "0x9E1374", Offset = "0x9E1374", VA = "0x9E1374")]
	public void Start()
	{
	}

	[Token(Token = "0x6000645")]
	[Address(RVA = "0x9E17AC", Offset = "0x9E17AC", VA = "0x9E17AC")]
	public void Update()
	{
	}

	[Token(Token = "0x6000646")]
	[Address(RVA = "0x9E1884", Offset = "0x9E1884", VA = "0x9E1884")]
	private static void Log(string msg)
	{
	}

	[Token(Token = "0x6000647")]
	public static TActivate ActivateCategory<TCategory, TActivate>(GameObject target) where TCategory : MonoBehaviour where TActivate : MonoBehaviour
	{
		return null;
	}

	[Token(Token = "0x6000648")]
	protected void ActivateHandlers<TInput, TAim, TTarget, TOrientation, TTransition>() where TInput : TeleportInputHandler where TAim : TeleportAimHandler where TTarget : TeleportTargetHandler where TOrientation : TeleportOrientationHandler where TTransition : TeleportTransition
	{
	}

	[Token(Token = "0x6000649")]
	protected void ActivateInput<TActivate>() where TActivate : TeleportInputHandler
	{
	}

	[Token(Token = "0x600064A")]
	protected void ActivateAim<TActivate>() where TActivate : TeleportAimHandler
	{
	}

	[Token(Token = "0x600064B")]
	protected void ActivateTarget<TActivate>() where TActivate : TeleportTargetHandler
	{
	}

	[Token(Token = "0x600064C")]
	protected void ActivateOrientation<TActivate>() where TActivate : TeleportOrientationHandler
	{
	}

	[Token(Token = "0x600064D")]
	protected void ActivateTransition<TActivate>() where TActivate : TeleportTransition
	{
	}

	[Token(Token = "0x600064E")]
	protected TActivate ActivateCategory<TCategory, TActivate>() where TCategory : MonoBehaviour where TActivate : MonoBehaviour
	{
		return null;
	}

	[Token(Token = "0x600064F")]
	[Address(RVA = "0x9E18DC", Offset = "0x9E18DC", VA = "0x9E18DC")]
	protected void UpdateToggle(Toggle toggle, bool enabled)
	{
	}

	[Token(Token = "0x6000650")]
	[Address(RVA = "0x9E191C", Offset = "0x9E191C", VA = "0x9E191C")]
	private void SetupNonCap()
	{
	}

	[Token(Token = "0x6000651")]
	[Address(RVA = "0x9E1988", Offset = "0x9E1988", VA = "0x9E1988")]
	private void SetupTeleportDefaults()
	{
	}

	[Token(Token = "0x6000652")]
	[Address(RVA = "0x9E1AD4", Offset = "0x9E1AD4", VA = "0x9E1AD4")]
	protected GameObject AddInstance(GameObject template, string label)
	{
		return null;
	}

	[Token(Token = "0x6000653")]
	[Address(RVA = "0x9E1BA4", Offset = "0x9E1BA4", VA = "0x9E1BA4")]
	private void SetupNodeTeleport()
	{
	}

	[Token(Token = "0x6000654")]
	[Address(RVA = "0x9E1688", Offset = "0x9E1688", VA = "0x9E1688")]
	private void SetupTwoStickTeleport()
	{
	}

	[Token(Token = "0x6000655")]
	[Address(RVA = "0x9E1C74", Offset = "0x9E1C74", VA = "0x9E1C74")]
	private void SetupWalkOnly()
	{
	}

	[Token(Token = "0x6000656")]
	[Address(RVA = "0x9E1CC0", Offset = "0x9E1CC0", VA = "0x9E1CC0")]
	private void SetupLeftStrafeRightTeleport()
	{
	}

	[Token(Token = "0x6000657")]
	[Address(RVA = "0x9E1DD0", Offset = "0x9E1DD0", VA = "0x9E1DD0")]
	public LocomotionSampleSupport()
	{
	}
}
[Token(Token = "0x2000118")]
[RequireComponent(typeof(Canvas))]
public class OVROverlayCanvas : MonoBehaviour
{
	[Token(Token = "0x2000119")]
	public enum DrawMode
	{
		[Token(Token = "0x400084E")]
		Opaque,
		[Token(Token = "0x400084F")]
		OpaqueWithClip,
		[Token(Token = "0x4000850")]
		TransparentDefaultAlpha,
		[Token(Token = "0x4000851")]
		TransparentCorrectAlpha
	}

	[Token(Token = "0x4000839")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Shader _transparentShader;

	[Token(Token = "0x400083A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Shader _opaqueShader;

	[Token(Token = "0x400083B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private RectTransform _rectTransform;

	[Token(Token = "0x400083C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Canvas _canvas;

	[Token(Token = "0x400083D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Camera _camera;

	[Token(Token = "0x400083E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private OVROverlay _overlay;

	[Token(Token = "0x400083F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private RenderTexture _renderTexture;

	[Token(Token = "0x4000840")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private MeshRenderer _meshRenderer;

	[Token(Token = "0x4000841")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Mesh _quad;

	[Token(Token = "0x4000842")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Material _defaultMat;

	[Token(Token = "0x4000843")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public int MaxTextureSize;

	[Token(Token = "0x4000844")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public int MinTextureSize;

	[Token(Token = "0x4000845")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float PixelsPerUnit;

	[Token(Token = "0x4000846")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public int DrawRate;

	[Token(Token = "0x4000847")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public int DrawFrameOffset;

	[Token(Token = "0x4000848")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public bool Expensive;

	[Token(Token = "0x4000849")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public int Layer;

	[Token(Token = "0x400084A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public DrawMode Opacity;

	[Token(Token = "0x400084B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool ScaleViewport;

	[Token(Token = "0x400084C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly Plane[] _FrustumPlanes;

	[Token(Token = "0x1700007A")]
	public bool overlayEnabled
	{
		[Token(Token = "0x600065E")]
		[Address(RVA = "0x9E3414", Offset = "0x9E3414", VA = "0x9E3414")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600065F")]
		[Address(RVA = "0x9E3498", Offset = "0x9E3498", VA = "0x9E3498")]
		set
		{
		}
	}

	[Token(Token = "0x6000658")]
	[Address(RVA = "0x9E1DD8", Offset = "0x9E1DD8", VA = "0x9E1DD8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000659")]
	[Address(RVA = "0x9E2A9C", Offset = "0x9E2A9C", VA = "0x9E2A9C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600065A")]
	[Address(RVA = "0x9E2B10", Offset = "0x9E2B10", VA = "0x9E2B10")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600065B")]
	[Address(RVA = "0x9E2BE0", Offset = "0x9E2BE0", VA = "0x9E2BE0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600065C")]
	[Address(RVA = "0x9E2CB0", Offset = "0x9E2CB0", VA = "0x9E2CB0", Slot = "4")]
	protected virtual bool ShouldRender()
	{
		return default(bool);
	}

	[Token(Token = "0x600065D")]
	[Address(RVA = "0x9E2EB4", Offset = "0x9E2EB4", VA = "0x9E2EB4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000660")]
	[Address(RVA = "0x9E3554", Offset = "0x9E3554", VA = "0x9E3554")]
	public OVROverlayCanvas()
	{
	}
}
[Token(Token = "0x200011A")]
public class AugmentedObject : MonoBehaviour
{
	[Token(Token = "0x4000852")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRInput.Controller controllerHand;

	[Token(Token = "0x4000853")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform shadow;

	[Token(Token = "0x4000854")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool groundShadow;

	[Token(Token = "0x6000662")]
	[Address(RVA = "0x9E3610", Offset = "0x9E3610", VA = "0x9E3610")]
	private void Start()
	{
	}

	[Token(Token = "0x6000663")]
	[Address(RVA = "0x9E39B0", Offset = "0x9E39B0", VA = "0x9E39B0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000664")]
	[Address(RVA = "0x9E3B44", Offset = "0x9E3B44", VA = "0x9E3B44")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x6000665")]
	[Address(RVA = "0x9E3B4C", Offset = "0x9E3B4C", VA = "0x9E3B4C")]
	public void Release()
	{
	}

	[Token(Token = "0x6000666")]
	[Address(RVA = "0x9E3B34", Offset = "0x9E3B34", VA = "0x9E3B34")]
	private void ToggleShadowType()
	{
	}

	[Token(Token = "0x6000667")]
	[Address(RVA = "0x9E3B54", Offset = "0x9E3B54", VA = "0x9E3B54")]
	public AugmentedObject()
	{
	}
}
[Token(Token = "0x200011B")]
public class BrushController : MonoBehaviour
{
	[Token(Token = "0x200011C")]
	private sealed class <FadeCameraClearColor>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000859")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400085A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400085B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float fadeTime;

		[Token(Token = "0x400085C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Color newColor;

		[Token(Token = "0x400085D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <timer>5__2;

		[Token(Token = "0x400085E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Color <currentColor>5__3;

		[Token(Token = "0x1700007B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000672")]
			[Address(RVA = "0x9E429C", Offset = "0x9E429C", VA = "0x9E429C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000674")]
			[Address(RVA = "0x9E42E4", Offset = "0x9E42E4", VA = "0x9E42E4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0x9E4140", Offset = "0x9E4140", VA = "0x9E4140")]
		[DebuggerHidden]
		public <FadeCameraClearColor>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x9E4198", Offset = "0x9E4198", VA = "0x9E4198", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0x9E419C", Offset = "0x9E419C", VA = "0x9E419C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0x9E42A4", Offset = "0x9E42A4", VA = "0x9E42A4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200011D")]
	private sealed class <FadeSphere>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400085F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000860")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000861")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BrushController <>4__this;

		[Token(Token = "0x4000862")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fadeTime;

		[Token(Token = "0x4000863")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Color newColor;

		[Token(Token = "0x4000864")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool disableOnFinish;

		[Token(Token = "0x4000865")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float <timer>5__2;

		[Token(Token = "0x4000866")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Color <currentColor>5__3;

		[Token(Token = "0x1700007D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000678")]
			[Address(RVA = "0x9E4468", Offset = "0x9E4468", VA = "0x9E4468", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600067A")]
			[Address(RVA = "0x9E44B0", Offset = "0x9E44B0", VA = "0x9E44B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0x9E4168", Offset = "0x9E4168", VA = "0x9E4168")]
		[DebuggerHidden]
		public <FadeSphere>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0x9E42EC", Offset = "0x9E42EC", VA = "0x9E42EC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0x9E42F0", Offset = "0x9E42F0", VA = "0x9E42F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0x9E4470", Offset = "0x9E4470", VA = "0x9E4470", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000855")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public PassthroughBrush brush;

	[Token(Token = "0x4000856")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshRenderer backgroundSphere;

	[Token(Token = "0x4000857")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private IEnumerator grabRoutine;

	[Token(Token = "0x4000858")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private IEnumerator releaseRoutine;

	[Token(Token = "0x6000668")]
	[Address(RVA = "0x9E3B5C", Offset = "0x9E3B5C", VA = "0x9E3B5C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000669")]
	[Address(RVA = "0x9E3E3C", Offset = "0x9E3E3C", VA = "0x9E3E3C")]
	private void Update()
	{
	}

	[Token(Token = "0x600066A")]
	[Address(RVA = "0x9E3E8C", Offset = "0x9E3E8C", VA = "0x9E3E8C")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x600066B")]
	[Address(RVA = "0x9E4004", Offset = "0x9E4004", VA = "0x9E4004")]
	public void Release()
	{
	}

	[Token(Token = "0x600066C")]
	[Address(RVA = "0x9E40A8", Offset = "0x9E40A8", VA = "0x9E40A8")]
	private IEnumerator FadeCameraClearColor(Color newColor, float fadeTime)
	{
		return null;
	}

	[Token(Token = "0x600066D")]
	[Address(RVA = "0x9E3F44", Offset = "0x9E3F44", VA = "0x9E3F44")]
	private IEnumerator FadeSphere(Color newColor, float fadeTime, bool disableOnFinish = false)
	{
		return null;
	}

	[Token(Token = "0x600066E")]
	[Address(RVA = "0x9E4190", Offset = "0x9E4190", VA = "0x9E4190")]
	public BrushController()
	{
	}
}
[Token(Token = "0x200011E")]
public class EnableUnpremultipliedAlpha : MonoBehaviour
{
	[Token(Token = "0x600067B")]
	[Address(RVA = "0x9E44B8", Offset = "0x9E44B8", VA = "0x9E44B8")]
	private void Start()
	{
	}

	[Token(Token = "0x600067C")]
	[Address(RVA = "0x9E450C", Offset = "0x9E450C", VA = "0x9E450C")]
	public EnableUnpremultipliedAlpha()
	{
	}
}
[Token(Token = "0x200011F")]
public class Flashlight : MonoBehaviour
{
	[Token(Token = "0x4000867")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject lightVolume;

	[Token(Token = "0x4000868")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Light spotlight;

	[Token(Token = "0x4000869")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject bulbGlow;

	[Token(Token = "0x600067D")]
	[Address(RVA = "0x9E4514", Offset = "0x9E4514", VA = "0x9E4514")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600067E")]
	[Address(RVA = "0x9E46E8", Offset = "0x9E46E8", VA = "0x9E46E8")]
	public void ToggleFlashlight()
	{
	}

	[Token(Token = "0x600067F")]
	[Address(RVA = "0x9E4778", Offset = "0x9E4778", VA = "0x9E4778")]
	public void EnableFlashlight(bool doEnable)
	{
	}

	[Token(Token = "0x6000680")]
	[Address(RVA = "0x9E47D4", Offset = "0x9E47D4", VA = "0x9E47D4")]
	public Flashlight()
	{
	}
}
[Token(Token = "0x2000120")]
public class FlashlightController : MonoBehaviour
{
	[Token(Token = "0x2000121")]
	private sealed class <FadeLighting>d__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000874")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000875")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000876")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FlashlightController <>4__this;

		[Token(Token = "0x4000877")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fadeTime;

		[Token(Token = "0x4000878")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Color newColor;

		[Token(Token = "0x4000879")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float sceneLightIntensity;

		[Token(Token = "0x400087A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float <timer>5__2;

		[Token(Token = "0x400087B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Color <currentColor>5__3;

		[Token(Token = "0x400087C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float <currentLight>5__4;

		[Token(Token = "0x1700007F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600068D")]
			[Address(RVA = "0x9E59AC", Offset = "0x9E59AC", VA = "0x9E59AC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000080")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600068F")]
			[Address(RVA = "0x9E59F4", Offset = "0x9E59F4", VA = "0x9E59F4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0x9E5714", Offset = "0x9E5714", VA = "0x9E5714")]
		[DebuggerHidden]
		public <FadeLighting>d__17(int <>1__state)
		{
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0x9E57DC", Offset = "0x9E57DC", VA = "0x9E57DC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0x9E57E0", Offset = "0x9E57E0", VA = "0x9E57E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0x9E59B4", Offset = "0x9E59B4", VA = "0x9E59B4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400086A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Light sceneLight;

	[Token(Token = "0x400086B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform flashlightRoot;

	[Token(Token = "0x400086C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Vector3 localPosition;

	[Token(Token = "0x400086D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Quaternion localRotation;

	[Token(Token = "0x400086E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TextMesh infoText;

	[Token(Token = "0x400086F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private GrabObject externalController;

	[Token(Token = "0x4000870")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private OVRSkeleton[] skeletons;

	[Token(Token = "0x4000871")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private OVRHand[] hands;

	[Token(Token = "0x4000872")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int handIndex;

	[Token(Token = "0x4000873")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private bool pinching;

	[Token(Token = "0x6000681")]
	[Address(RVA = "0x9E47DC", Offset = "0x9E47DC", VA = "0x9E47DC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000682")]
	[Address(RVA = "0x9E4AC4", Offset = "0x9E4AC4", VA = "0x9E4AC4")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000683")]
	[Address(RVA = "0x9E4DB0", Offset = "0x9E4DB0", VA = "0x9E4DB0")]
	private void FindHands()
	{
	}

	[Token(Token = "0x6000684")]
	[Address(RVA = "0x9E50D8", Offset = "0x9E50D8", VA = "0x9E50D8")]
	private void AlignWithHand(OVRHand hand, OVRSkeleton skeleton)
	{
	}

	[Token(Token = "0x6000685")]
	[Address(RVA = "0x9E53B0", Offset = "0x9E53B0", VA = "0x9E53B0")]
	private void AlignWithController(OVRInput.Controller controller)
	{
	}

	[Token(Token = "0x6000686")]
	[Address(RVA = "0x9E5498", Offset = "0x9E5498", VA = "0x9E5498")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x6000687")]
	[Address(RVA = "0x9E5630", Offset = "0x9E5630", VA = "0x9E5630")]
	public void Release()
	{
	}

	[Token(Token = "0x6000688")]
	[Address(RVA = "0x9E5580", Offset = "0x9E5580", VA = "0x9E5580")]
	private IEnumerator FadeLighting(Color newColor, float sceneLightIntensity, float fadeTime)
	{
		return null;
	}

	[Token(Token = "0x6000689")]
	[Address(RVA = "0x9E573C", Offset = "0x9E573C", VA = "0x9E573C")]
	public FlashlightController()
	{
	}
}
[Token(Token = "0x2000122")]
public class GrabObject : MonoBehaviour
{
	[Token(Token = "0x2000123")]
	public enum ManipulationType
	{
		[Token(Token = "0x4000886")]
		Default,
		[Token(Token = "0x4000887")]
		ForcedHand,
		[Token(Token = "0x4000888")]
		DollyHand,
		[Token(Token = "0x4000889")]
		DollyAttached,
		[Token(Token = "0x400088A")]
		HorizontalScaled,
		[Token(Token = "0x400088B")]
		VerticalScaled,
		[Token(Token = "0x400088C")]
		Menu
	}

	[Token(Token = "0x2000124")]
	public delegate void GrabbedObject(OVRInput.Controller grabHand);

	[Token(Token = "0x2000125")]
	public delegate void ReleasedObject();

	[Token(Token = "0x2000126")]
	public delegate void SetCursorPosition(Vector3 cursorPosition);

	[Token(Token = "0x400087D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string ObjectName;

	[Token(Token = "0x400087E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string ObjectInstructions;

	[Token(Token = "0x400087F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ManipulationType objectManipulationType;

	[Token(Token = "0x4000880")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool showLaserWhileGrabbed;

	[Token(Token = "0x4000881")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Quaternion grabbedRotation;

	[Token(Token = "0x4000882")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GrabbedObject GrabbedObjectDelegate;

	[Token(Token = "0x4000883")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ReleasedObject ReleasedObjectDelegate;

	[Token(Token = "0x4000884")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public SetCursorPosition CursorPositionDelegate;

	[Token(Token = "0x6000690")]
	[Address(RVA = "0x9E59FC", Offset = "0x9E59FC", VA = "0x9E59FC")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x6000691")]
	[Address(RVA = "0x9E5A5C", Offset = "0x9E5A5C", VA = "0x9E5A5C")]
	public void Release()
	{
	}

	[Token(Token = "0x6000692")]
	[Address(RVA = "0x9E5A78", Offset = "0x9E5A78", VA = "0x9E5A78")]
	public void CursorPos(Vector3 cursorPos)
	{
	}

	[Token(Token = "0x6000693")]
	[Address(RVA = "0x9E5A94", Offset = "0x9E5A94", VA = "0x9E5A94")]
	public GrabObject()
	{
	}
}
[Token(Token = "0x2000127")]
public class HandMeshMask : MonoBehaviour
{
	[Token(Token = "0x400088D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRSkeleton referenceHand;

	[Token(Token = "0x400088E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Material maskMaterial;

	[Token(Token = "0x400088F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int radialDivisions;

	[Token(Token = "0x4000890")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float borderSize;

	[Token(Token = "0x4000891")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float fingerTaper;

	[Token(Token = "0x4000892")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float fingerTipLength;

	[Token(Token = "0x4000893")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float webOffset;

	[Token(Token = "0x4000894")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float handScale;

	[Token(Token = "0x4000895")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private GameObject maskMeshObject;

	[Token(Token = "0x4000896")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Mesh maskMesh;

	[Token(Token = "0x4000897")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3[] handVertices;

	[Token(Token = "0x4000898")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Vector2[] handUVs;

	[Token(Token = "0x4000899")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Color32[] handColors;

	[Token(Token = "0x400089A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int[] handTriangles;

	[Token(Token = "0x400089B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private int vertCounter;

	[Token(Token = "0x400089C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private int triCounter;

	[Token(Token = "0x600069A")]
	[Address(RVA = "0x9E5BFC", Offset = "0x9E5BFC", VA = "0x9E5BFC")]
	private void Awake()
	{
	}

	[Token(Token = "0x600069B")]
	[Address(RVA = "0x9E5E5C", Offset = "0x9E5E5C", VA = "0x9E5E5C")]
	private void Update()
	{
	}

	[Token(Token = "0x600069C")]
	[Address(RVA = "0x9E6024", Offset = "0x9E6024", VA = "0x9E6024")]
	private void CreateHandMesh()
	{
	}

	[Token(Token = "0x600069D")]
	[Address(RVA = "0x9E6678", Offset = "0x9E6678", VA = "0x9E6678")]
	private void AddKnuckleMesh(int knuckleVerts, float point1scale, float point2scale, Vector3 point1, Vector3 point2)
	{
	}

	[Token(Token = "0x600069E")]
	[Address(RVA = "0x9E6C10", Offset = "0x9E6C10", VA = "0x9E6C10")]
	private void AddPalmMesh(int knuckleVerts)
	{
	}

	[Token(Token = "0x600069F")]
	[Address(RVA = "0x9E8F18", Offset = "0x9E8F18", VA = "0x9E8F18")]
	private void AddVertex(Vector3 position, Vector2 uv, Color color)
	{
	}

	[Token(Token = "0x60006A0")]
	[Address(RVA = "0x9E928C", Offset = "0x9E928C", VA = "0x9E928C")]
	public HandMeshMask()
	{
	}
}
[Token(Token = "0x2000128")]
public class HandMeshUI : MonoBehaviour
{
	[Token(Token = "0x400089D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public SphereCollider[] knobs;

	[Token(Token = "0x400089E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextMesh[] readouts;

	[Token(Token = "0x400089F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int rightHeldKnob;

	[Token(Token = "0x40008A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private int leftHeldKnob;

	[Token(Token = "0x40008A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public OVRSkeleton leftHand;

	[Token(Token = "0x40008A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public OVRSkeleton rightHand;

	[Token(Token = "0x40008A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public HandMeshMask leftMask;

	[Token(Token = "0x40008A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public HandMeshMask rightMask;

	[Token(Token = "0x60006A1")]
	[Address(RVA = "0x9E92B0", Offset = "0x9E92B0", VA = "0x9E92B0")]
	private void Start()
	{
	}

	[Token(Token = "0x60006A2")]
	[Address(RVA = "0x9E9618", Offset = "0x9E9618", VA = "0x9E9618")]
	private void Update()
	{
	}

	[Token(Token = "0x60006A3")]
	[Address(RVA = "0x9E934C", Offset = "0x9E934C", VA = "0x9E934C")]
	private void SetSliderValue(int sliderID, float value, bool isNormalized)
	{
	}

	[Token(Token = "0x60006A4")]
	[Address(RVA = "0x9E9A80", Offset = "0x9E9A80", VA = "0x9E9A80")]
	private void CheckForHands()
	{
	}

	[Token(Token = "0x60006A5")]
	[Address(RVA = "0x9E9FF0", Offset = "0x9E9FF0", VA = "0x9E9FF0")]
	public HandMeshUI()
	{
	}
}
[Token(Token = "0x2000129")]
public class ObjectManipulator : MonoBehaviour
{
	[Token(Token = "0x200012A")]
	private sealed class <StartDemo>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40008B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40008B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40008BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ObjectManipulator <>4__this;

		[Token(Token = "0x40008BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <timer>5__2;

		[Token(Token = "0x40008BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <fadeTime>5__3;

		[Token(Token = "0x17000081")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60006B5")]
			[Address(RVA = "0x9EC898", Offset = "0x9EC898", VA = "0x9EC898", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000082")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006B7")]
			[Address(RVA = "0x9EC8E0", Offset = "0x9EC8E0", VA = "0x9EC8E0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x9EC1D8", Offset = "0x9EC1D8", VA = "0x9EC1D8")]
		[DebuggerHidden]
		public <StartDemo>d__23(int <>1__state)
		{
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x9EC5C0", Offset = "0x9EC5C0", VA = "0x9EC5C0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x9EC5C4", Offset = "0x9EC5C4", VA = "0x9EC5C4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x9EC8A0", Offset = "0x9EC8A0", VA = "0x9EC8A0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40008A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRInput.Controller controller;

	[Token(Token = "0x40008A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject hoverObject;

	[Token(Token = "0x40008A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private GameObject grabObject;

	[Token(Token = "0x40008A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float grabTime;

	[Token(Token = "0x40008A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Vector3 localGrabOffset;

	[Token(Token = "0x40008AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Quaternion localGrabRotation;

	[Token(Token = "0x40008AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3 camGrabPosition;

	[Token(Token = "0x40008AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private Quaternion camGrabRotation;

	[Token(Token = "0x40008AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private Vector3 handGrabPosition;

	[Token(Token = "0x40008AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Quaternion handGrabRotation;

	[Token(Token = "0x40008AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Vector3 cursorPosition;

	[Token(Token = "0x40008B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private float rotationOffset;

	[Token(Token = "0x40008B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public LineRenderer laser;

	[Token(Token = "0x40008B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Transform objectInfo;

	[Token(Token = "0x40008B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public TextMesh objectNameLabel;

	[Token(Token = "0x40008B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public TextMesh objectInstructionsLabel;

	[Token(Token = "0x40008B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Image objectInfoBG;

	[Token(Token = "0x40008B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public GameObject demoObjects;

	[Token(Token = "0x40008B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public OVRPassthroughLayer passthrough;

	[Token(Token = "0x60006A6")]
	[Address(RVA = "0x9EA000", Offset = "0x9EA000", VA = "0x9EA000")]
	private void Start()
	{
	}

	[Token(Token = "0x60006A7")]
	[Address(RVA = "0x9EA1FC", Offset = "0x9EA1FC", VA = "0x9EA1FC")]
	private void Update()
	{
	}

	[Token(Token = "0x60006A8")]
	[Address(RVA = "0x9EB138", Offset = "0x9EB138", VA = "0x9EB138")]
	private void GrabHoverObject(GameObject grbObj, Vector3 controllerPos, Quaternion controllerRot)
	{
	}

	[Token(Token = "0x60006A9")]
	[Address(RVA = "0x9EBECC", Offset = "0x9EBECC", VA = "0x9EBECC")]
	private void ReleaseObject()
	{
	}

	[Token(Token = "0x60006AA")]
	[Address(RVA = "0x9EA188", Offset = "0x9EA188", VA = "0x9EA188")]
	private IEnumerator StartDemo()
	{
		return null;
	}

	[Token(Token = "0x60006AB")]
	[Address(RVA = "0x9EA44C", Offset = "0x9EA44C", VA = "0x9EA44C")]
	private void FindHoverObject(Vector3 controllerPos, Quaternion controllerRot)
	{
	}

	[Token(Token = "0x60006AC")]
	[Address(RVA = "0x9EB42C", Offset = "0x9EB42C", VA = "0x9EB42C")]
	private void ManipulateObject(GameObject obj, Vector3 controllerPos, Quaternion controllerRot)
	{
	}

	[Token(Token = "0x60006AD")]
	[Address(RVA = "0x9EC200", Offset = "0x9EC200", VA = "0x9EC200")]
	private void ClampGrabOffset(ref Vector3 localOffset, float thumbY)
	{
	}

	[Token(Token = "0x60006AE")]
	[Address(RVA = "0x9EC2B4", Offset = "0x9EC2B4", VA = "0x9EC2B4")]
	private Vector3 ClampScale(Vector3 localScale, Vector2 thumb)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60006AF")]
	[Address(RVA = "0x9EC2E4", Offset = "0x9EC2E4", VA = "0x9EC2E4")]
	private void CheckForDominantHand()
	{
	}

	[Token(Token = "0x60006B0")]
	[Address(RVA = "0x9EC0BC", Offset = "0x9EC0BC", VA = "0x9EC0BC")]
	private void AssignInstructions(GrabObject targetObject)
	{
	}

	[Token(Token = "0x60006B1")]
	[Address(RVA = "0x9EC3D4", Offset = "0x9EC3D4", VA = "0x9EC3D4")]
	public ObjectManipulator()
	{
	}
}
[Token(Token = "0x200012B")]
public class OverlayPassthrough : MonoBehaviour
{
	[Token(Token = "0x40008BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x60006B8")]
	[Address(RVA = "0x9EC8E8", Offset = "0x9EC8E8", VA = "0x9EC8E8")]
	private void Start()
	{
	}

	[Token(Token = "0x60006B9")]
	[Address(RVA = "0x9ECA54", Offset = "0x9ECA54", VA = "0x9ECA54")]
	private void Update()
	{
	}

	[Token(Token = "0x60006BA")]
	[Address(RVA = "0x9ECB08", Offset = "0x9ECB08", VA = "0x9ECB08")]
	public OverlayPassthrough()
	{
	}
}
[Token(Token = "0x200012C")]
public class PassthroughBrush : MonoBehaviour
{
	[Token(Token = "0x200012D")]
	public enum BrushState
	{
		[Token(Token = "0x40008C9")]
		Idle,
		[Token(Token = "0x40008CA")]
		Inking
	}

	[Token(Token = "0x40008BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRInput.Controller controllerHand;

	[Token(Token = "0x40008BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject lineSegmentPrefab;

	[Token(Token = "0x40008C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject lineContainer;

	[Token(Token = "0x40008C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool forceActive;

	[Token(Token = "0x40008C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private LineRenderer currentLineSegment;

	[Token(Token = "0x40008C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private List<Vector3> inkPositions;

	[Token(Token = "0x40008C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float minInkDist;

	[Token(Token = "0x40008C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private float strokeWidth;

	[Token(Token = "0x40008C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float strokeLength;

	[Token(Token = "0x40008C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private BrushState brushStatus;

	[Token(Token = "0x60006BB")]
	[Address(RVA = "0x9ECB10", Offset = "0x9ECB10", VA = "0x9ECB10")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60006BC")]
	[Address(RVA = "0x9ECB18", Offset = "0x9ECB18", VA = "0x9ECB18")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60006BD")]
	[Address(RVA = "0x9ECDC8", Offset = "0x9ECDC8", VA = "0x9ECDC8")]
	private void StartLine(Vector3 inkPos)
	{
	}

	[Token(Token = "0x60006BE")]
	[Address(RVA = "0x9ECFFC", Offset = "0x9ECFFC", VA = "0x9ECFFC")]
	private void UpdateLine(Vector3 inkPos)
	{
	}

	[Token(Token = "0x60006BF")]
	[Address(RVA = "0x9ED23C", Offset = "0x9ED23C", VA = "0x9ED23C")]
	public void ClearLines()
	{
	}

	[Token(Token = "0x60006C0")]
	[Address(RVA = "0x9ECCE0", Offset = "0x9ECCE0", VA = "0x9ECCE0")]
	public void UndoInkLine()
	{
	}

	[Token(Token = "0x60006C1")]
	[Address(RVA = "0x9ED30C", Offset = "0x9ED30C", VA = "0x9ED30C")]
	public PassthroughBrush()
	{
	}
}
[Token(Token = "0x200012E")]
public class PassthroughController : MonoBehaviour
{
	[Token(Token = "0x40008CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x60006C2")]
	[Address(RVA = "0x9ED3A8", Offset = "0x9ED3A8", VA = "0x9ED3A8")]
	private void Start()
	{
	}

	[Token(Token = "0x60006C3")]
	[Address(RVA = "0x9ED514", Offset = "0x9ED514", VA = "0x9ED514")]
	private void Update()
	{
	}

	[Token(Token = "0x60006C4")]
	[Address(RVA = "0x9ED700", Offset = "0x9ED700", VA = "0x9ED700")]
	public PassthroughController()
	{
	}
}
[Token(Token = "0x200012F")]
public class PassthroughProjectionSurface : MonoBehaviour
{
	[Token(Token = "0x40008CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x40008CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshFilter projectionObject;

	[Token(Token = "0x40008CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private MeshRenderer quadOutline;

	[Token(Token = "0x60006C5")]
	[Address(RVA = "0x9ED708", Offset = "0x9ED708", VA = "0x9ED708")]
	private void Start()
	{
	}

	[Token(Token = "0x60006C6")]
	[Address(RVA = "0x9ED8F0", Offset = "0x9ED8F0", VA = "0x9ED8F0")]
	private void Update()
	{
	}

	[Token(Token = "0x60006C7")]
	[Address(RVA = "0x9EDA90", Offset = "0x9EDA90", VA = "0x9EDA90")]
	public PassthroughProjectionSurface()
	{
	}
}
[Token(Token = "0x2000130")]
public class PassthroughStyler : MonoBehaviour
{
	[Token(Token = "0x2000131")]
	private sealed class <FadeToCurrentStyle>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40008DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40008DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40008DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PassthroughStyler <>4__this;

		[Token(Token = "0x40008E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fadeTime;

		[Token(Token = "0x40008E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <timer>5__2;

		[Token(Token = "0x40008E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <brightness>5__3;

		[Token(Token = "0x40008E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <contrast>5__4;

		[Token(Token = "0x40008E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Color <edgeCol>5__5;

		[Token(Token = "0x17000083")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60006D9")]
			[Address(RVA = "0x9EE6E8", Offset = "0x9EE6E8", VA = "0x9EE6E8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000084")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006DB")]
			[Address(RVA = "0x9EE730", Offset = "0x9EE730", VA = "0x9EE730", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x9EE450", Offset = "0x9EE450", VA = "0x9EE450")]
		[DebuggerHidden]
		public <FadeToCurrentStyle>d__18(int <>1__state)
		{
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x9EE594", Offset = "0x9EE594", VA = "0x9EE594", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x9EE598", Offset = "0x9EE598", VA = "0x9EE598", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x9EE6F0", Offset = "0x9EE6F0", VA = "0x9EE6F0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000132")]
	private sealed class <FadeToDefaultPassthrough>d__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40008E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40008E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40008E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PassthroughStyler <>4__this;

		[Token(Token = "0x40008E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fadeTime;

		[Token(Token = "0x40008E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <timer>5__2;

		[Token(Token = "0x40008EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <brightness>5__3;

		[Token(Token = "0x40008EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <contrast>5__4;

		[Token(Token = "0x40008EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Color <edgeCol>5__5;

		[Token(Token = "0x17000085")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60006DF")]
			[Address(RVA = "0x9EE8A4", Offset = "0x9EE8A4", VA = "0x9EE8A4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000086")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006E1")]
			[Address(RVA = "0x9EE8EC", Offset = "0x9EE8EC", VA = "0x9EE8EC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x9EE478", Offset = "0x9EE478", VA = "0x9EE478")]
		[DebuggerHidden]
		public <FadeToDefaultPassthrough>d__19(int <>1__state)
		{
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x9EE738", Offset = "0x9EE738", VA = "0x9EE738", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x9EE73C", Offset = "0x9EE73C", VA = "0x9EE73C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x9EE8AC", Offset = "0x9EE8AC", VA = "0x9EE8AC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40008CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRInput.Controller controllerHand;

	[Token(Token = "0x40008D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x40008D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private IEnumerator fadeIn;

	[Token(Token = "0x40008D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private IEnumerator fadeOut;

	[Token(Token = "0x40008D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public RectTransform[] menuOptions;

	[Token(Token = "0x40008D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public RectTransform colorWheel;

	[Token(Token = "0x40008D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Texture2D colorTexture;

	[Token(Token = "0x40008D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3 cursorPosition;

	[Token(Token = "0x40008D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private bool settingColor;

	[Token(Token = "0x40008D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Color savedColor;

	[Token(Token = "0x40008D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float savedBrightness;

	[Token(Token = "0x40008DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private float savedContrast;

	[Token(Token = "0x40008DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public CanvasGroup mainCanvas;

	[Token(Token = "0x40008DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameObject[] compactObjects;

	[Token(Token = "0x60006C8")]
	[Address(RVA = "0x9EDA98", Offset = "0x9EDA98", VA = "0x9EDA98")]
	private void Start()
	{
	}

	[Token(Token = "0x60006C9")]
	[Address(RVA = "0x9EDDD4", Offset = "0x9EDDD4", VA = "0x9EDDD4")]
	private void Update()
	{
	}

	[Token(Token = "0x60006CA")]
	[Address(RVA = "0x9EE174", Offset = "0x9EE174", VA = "0x9EE174")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x60006CB")]
	[Address(RVA = "0x9EE2E8", Offset = "0x9EE2E8", VA = "0x9EE2E8")]
	public void Release()
	{
	}

	[Token(Token = "0x60006CC")]
	[Address(RVA = "0x9EE264", Offset = "0x9EE264", VA = "0x9EE264")]
	private IEnumerator FadeToCurrentStyle(float fadeTime)
	{
		return null;
	}

	[Token(Token = "0x60006CD")]
	[Address(RVA = "0x9EE3CC", Offset = "0x9EE3CC", VA = "0x9EE3CC")]
	private IEnumerator FadeToDefaultPassthrough(float fadeTime)
	{
		return null;
	}

	[Token(Token = "0x60006CE")]
	[Address(RVA = "0x9EE4A0", Offset = "0x9EE4A0", VA = "0x9EE4A0")]
	public void OnBrightnessChanged(float newValue)
	{
	}

	[Token(Token = "0x60006CF")]
	[Address(RVA = "0x9EE4C0", Offset = "0x9EE4C0", VA = "0x9EE4C0")]
	public void OnContrastChanged(float newValue)
	{
	}

	[Token(Token = "0x60006D0")]
	[Address(RVA = "0x9EE4E0", Offset = "0x9EE4E0", VA = "0x9EE4E0")]
	public void OnAlphaChanged(float newValue)
	{
	}

	[Token(Token = "0x60006D1")]
	[Address(RVA = "0x9EDD6C", Offset = "0x9EDD6C", VA = "0x9EDD6C")]
	private void ShowFullMenu(bool doShow)
	{
	}

	[Token(Token = "0x60006D2")]
	[Address(RVA = "0x9EE514", Offset = "0x9EE514", VA = "0x9EE514")]
	public void Cursor(Vector3 cP)
	{
	}

	[Token(Token = "0x60006D3")]
	[Address(RVA = "0x9EE520", Offset = "0x9EE520", VA = "0x9EE520")]
	public void DoColorDrag(bool doDrag)
	{
	}

	[Token(Token = "0x60006D4")]
	[Address(RVA = "0x9EDDEC", Offset = "0x9EDDEC", VA = "0x9EDDEC")]
	public void GetColorFromWheel()
	{
	}

	[Token(Token = "0x60006D5")]
	[Address(RVA = "0x9EE52C", Offset = "0x9EE52C", VA = "0x9EE52C")]
	public PassthroughStyler()
	{
	}
}
[Token(Token = "0x2000133")]
public class PassthroughSurface : MonoBehaviour
{
	[Token(Token = "0x40008ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x40008EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshFilter projectionObject;

	[Token(Token = "0x60006E2")]
	[Address(RVA = "0x9EE8F4", Offset = "0x9EE8F4", VA = "0x9EE8F4")]
	private void Start()
	{
	}

	[Token(Token = "0x60006E3")]
	[Address(RVA = "0x9EE9A8", Offset = "0x9EE9A8", VA = "0x9EE9A8")]
	public PassthroughSurface()
	{
	}
}
[Token(Token = "0x2000134")]
public class SceneSampler : MonoBehaviour
{
	[Token(Token = "0x40008EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int currentSceneIndex;

	[Token(Token = "0x40008F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject displayText;

	[Token(Token = "0x60006E4")]
	[Address(RVA = "0x9EE9B0", Offset = "0x9EE9B0", VA = "0x9EE9B0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60006E5")]
	[Address(RVA = "0x9EEA1C", Offset = "0x9EEA1C", VA = "0x9EEA1C")]
	private void Update()
	{
	}

	[Token(Token = "0x60006E6")]
	[Address(RVA = "0x9EED10", Offset = "0x9EED10", VA = "0x9EED10")]
	public SceneSampler()
	{
	}
}
[Token(Token = "0x2000135")]
public class SelectivePassthroughExperience : MonoBehaviour
{
	[Token(Token = "0x40008F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject leftMaskObject;

	[Token(Token = "0x40008F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject rightMaskObject;

	[Token(Token = "0x60006E7")]
	[Address(RVA = "0x9EED18", Offset = "0x9EED18", VA = "0x9EED18")]
	private void Update()
	{
	}

	[Token(Token = "0x60006E8")]
	[Address(RVA = "0x9EF16C", Offset = "0x9EF16C", VA = "0x9EF16C")]
	public SelectivePassthroughExperience()
	{
	}
}
[Token(Token = "0x2000136")]
public class SPPquad : MonoBehaviour
{
	[Token(Token = "0x40008F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x40008F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshFilter projectionObject;

	[Token(Token = "0x40008F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private OVRInput.Controller controllerHand;

	[Token(Token = "0x60006E9")]
	[Address(RVA = "0x9EF174", Offset = "0x9EF174", VA = "0x9EF174")]
	private void Start()
	{
	}

	[Token(Token = "0x60006EA")]
	[Address(RVA = "0x9EF3D4", Offset = "0x9EF3D4", VA = "0x9EF3D4")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x60006EB")]
	[Address(RVA = "0x9EF420", Offset = "0x9EF420", VA = "0x9EF420")]
	public void Release()
	{
	}

	[Token(Token = "0x60006EC")]
	[Address(RVA = "0x9EF460", Offset = "0x9EF460", VA = "0x9EF460")]
	public SPPquad()
	{
	}
}
[Token(Token = "0x2000137")]
public class BouncingBallLogic : MonoBehaviour
{
	[Token(Token = "0x2000138")]
	private sealed class <PlayPopCallback>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000902")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000903")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000904")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float clipLength;

		[Token(Token = "0x4000905")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public BouncingBallLogic <>4__this;

		[Token(Token = "0x17000087")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60006F8")]
			[Address(RVA = "0x9EFB7C", Offset = "0x9EFB7C", VA = "0x9EFB7C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000088")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006FA")]
			[Address(RVA = "0x9EFBC4", Offset = "0x9EFBC4", VA = "0x9EFBC4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x9EFA44", Offset = "0x9EFA44", VA = "0x9EFA44")]
		[DebuggerHidden]
		public <PlayPopCallback>d__18(int <>1__state)
		{
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x9EFA84", Offset = "0x9EFA84", VA = "0x9EFA84", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x9EFA88", Offset = "0x9EFA88", VA = "0x9EFA88", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x9EFB84", Offset = "0x9EFB84", VA = "0x9EFB84", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40008F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float TTL;

	[Token(Token = "0x40008F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AudioClip pop;

	[Token(Token = "0x40008F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private AudioClip bounce;

	[Token(Token = "0x40008F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private AudioClip loadball;

	[Token(Token = "0x40008FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Material visibleMat;

	[Token(Token = "0x40008FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Material hiddenMat;

	[Token(Token = "0x40008FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private AudioSource audioSource;

	[Token(Token = "0x40008FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Transform centerEyeCamera;

	[Token(Token = "0x40008FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool isVisible;

	[Token(Token = "0x40008FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private float timer;

	[Token(Token = "0x4000900")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool isReleased;

	[Token(Token = "0x4000901")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
	private bool isReadyForDestroy;

	[Token(Token = "0x60006ED")]
	[Address(RVA = "0x9EF468", Offset = "0x9EF468", VA = "0x9EF468")]
	private void OnCollisionEnter()
	{
	}

	[Token(Token = "0x60006EE")]
	[Address(RVA = "0x9EF48C", Offset = "0x9EF48C", VA = "0x9EF48C")]
	private void Start()
	{
	}

	[Token(Token = "0x60006EF")]
	[Address(RVA = "0x9EF594", Offset = "0x9EF594", VA = "0x9EF594")]
	private void Update()
	{
	}

	[Token(Token = "0x60006F0")]
	[Address(RVA = "0x9EF638", Offset = "0x9EF638", VA = "0x9EF638")]
	private void UpdateVisibility()
	{
	}

	[Token(Token = "0x60006F1")]
	[Address(RVA = "0x9EF88C", Offset = "0x9EF88C", VA = "0x9EF88C")]
	private void SetVisible(bool setVisible)
	{
	}

	[Token(Token = "0x60006F2")]
	[Address(RVA = "0x9EF930", Offset = "0x9EF930", VA = "0x9EF930")]
	public void Release(Vector3 pos, Vector3 vel, Vector3 angVel)
	{
	}

	[Token(Token = "0x60006F3")]
	[Address(RVA = "0x9EF808", Offset = "0x9EF808", VA = "0x9EF808")]
	private IEnumerator PlayPopCallback(float clipLength)
	{
		return null;
	}

	[Token(Token = "0x60006F4")]
	[Address(RVA = "0x9EFA6C", Offset = "0x9EFA6C", VA = "0x9EFA6C")]
	public BouncingBallLogic()
	{
	}
}
[Token(Token = "0x2000139")]
public class BouncingBallMgr : MonoBehaviour
{
	[Token(Token = "0x4000906")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform trackingspace;

	[Token(Token = "0x4000907")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject rightControllerPivot;

	[Token(Token = "0x4000908")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private OVRInput.RawButton actionBtn;

	[Token(Token = "0x4000909")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject ball;

	[Token(Token = "0x400090A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private GameObject currentBall;

	[Token(Token = "0x400090B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool ballGrabbed;

	[Token(Token = "0x60006FB")]
	[Address(RVA = "0x9EFBCC", Offset = "0x9EFBCC", VA = "0x9EFBCC")]
	private void Update()
	{
	}

	[Token(Token = "0x60006FC")]
	[Address(RVA = "0x9EFEDC", Offset = "0x9EFEDC", VA = "0x9EFEDC")]
	public BouncingBallMgr()
	{
	}
}
[Token(Token = "0x200013A")]
[DefaultExecutionOrder(30)]
[RequireComponent(typeof(OVRSceneAnchor))]
public class FurnitureSpawner : MonoBehaviour
{
	[Token(Token = "0x400090C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject RoomLightPrefab;

	[Token(Token = "0x400090D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<Spawnable> SpawnablePrefabs;

	[Token(Token = "0x400090E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private OVRSceneAnchor _sceneAnchor;

	[Token(Token = "0x400090F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private OVRSemanticClassification _classification;

	[Token(Token = "0x4000910")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static GameObject _roomLightRef;

	[Token(Token = "0x4000911")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int _frameCounter;

	[Token(Token = "0x60006FD")]
	[Address(RVA = "0x9EFEE4", Offset = "0x9EFEE4", VA = "0x9EFEE4")]
	private void Start()
	{
	}

	[Token(Token = "0x60006FE")]
	[Address(RVA = "0x9F00FC", Offset = "0x9F00FC", VA = "0x9F00FC")]
	private void SpawnSpawnable()
	{
	}

	[Token(Token = "0x60006FF")]
	[Address(RVA = "0x9F056C", Offset = "0x9F056C", VA = "0x9F056C")]
	private bool FindValidSpawnable(out Spawnable currentSpawnable)
	{
		return default(bool);
	}

	[Token(Token = "0x6000700")]
	[Address(RVA = "0x9EFF84", Offset = "0x9EFF84", VA = "0x9EFF84")]
	private void AddRoomLight()
	{
	}

	[Token(Token = "0x6000701")]
	[Address(RVA = "0x9F078C", Offset = "0x9F078C", VA = "0x9F078C")]
	private void GetVolumeFromTopPlane(Transform plane, Vector2 dimensions, float height, out Vector3 position, out Quaternion rotation, out Vector3 localScale)
	{
	}

	[Token(Token = "0x6000702")]
	[Address(RVA = "0x9F0C78", Offset = "0x9F0C78", VA = "0x9F0C78")]
	public FurnitureSpawner()
	{
	}
}
[Token(Token = "0x200013B")]
public class MyCustomSceneModelLoader : OVRSceneModelLoader
{
	[Token(Token = "0x200013C")]
	private sealed class <DelayedLoad>d__0 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000912")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000913")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000914")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MyCustomSceneModelLoader <>4__this;

		[Token(Token = "0x17000089")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600070A")]
			[Address(RVA = "0x9F0EAC", Offset = "0x9F0EAC", VA = "0x9F0EAC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600070C")]
			[Address(RVA = "0x9F0EF4", Offset = "0x9F0EF4", VA = "0x9F0EF4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0x9F0CF4", Offset = "0x9F0CF4", VA = "0x9F0CF4")]
		[DebuggerHidden]
		public <DelayedLoad>d__0(int <>1__state)
		{
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0x9F0DAC", Offset = "0x9F0DAC", VA = "0x9F0DAC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0x9F0DB0", Offset = "0x9F0DB0", VA = "0x9F0DB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0x9F0EB4", Offset = "0x9F0EB4", VA = "0x9F0EB4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x6000703")]
	[Address(RVA = "0x9F0C80", Offset = "0x9F0C80", VA = "0x9F0C80")]
	private IEnumerator DelayedLoad()
	{
		return null;
	}

	[Token(Token = "0x6000704")]
	[Address(RVA = "0x9F0D1C", Offset = "0x9F0D1C", VA = "0x9F0D1C", Slot = "4")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x6000705")]
	[Address(RVA = "0x9F0D3C", Offset = "0x9F0D3C", VA = "0x9F0D3C", Slot = "6")]
	protected override void OnNoSceneModelToLoad()
	{
	}

	[Token(Token = "0x6000706")]
	[Address(RVA = "0x9F0DA4", Offset = "0x9F0DA4", VA = "0x9F0DA4")]
	public MyCustomSceneModelLoader()
	{
	}
}
[Token(Token = "0x200013D")]
[RequireComponent(typeof(OVRManager))]
public class PassthroughPlayInEditor : MonoBehaviour
{
	[Token(Token = "0x600070D")]
	[Address(RVA = "0x9F0EFC", Offset = "0x9F0EFC", VA = "0x9F0EFC")]
	public PassthroughPlayInEditor()
	{
	}
}
[Token(Token = "0x200013E")]
public class RequestCaptureFlow : MonoBehaviour
{
	[Token(Token = "0x4000915")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRInput.Button RequestCaptureBtn;

	[Token(Token = "0x4000916")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private OVRSceneManager _sceneManager;

	[Token(Token = "0x600070E")]
	[Address(RVA = "0x9F0F04", Offset = "0x9F0F04", VA = "0x9F0F04")]
	private void Start()
	{
	}

	[Token(Token = "0x600070F")]
	[Address(RVA = "0x9F0F7C", Offset = "0x9F0F7C", VA = "0x9F0F7C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000710")]
	[Address(RVA = "0x9F1000", Offset = "0x9F1000", VA = "0x9F1000")]
	public RequestCaptureFlow()
	{
	}
}
[Token(Token = "0x200013F")]
[ExecuteInEditMode]
public class SimpleResizable : MonoBehaviour
{
	[Token(Token = "0x2000140")]
	public enum Method
	{
		[Token(Token = "0x4000926")]
		Adapt,
		[Token(Token = "0x4000927")]
		AdaptWithAsymmetricalPadding,
		[Token(Token = "0x4000928")]
		Scale,
		[Token(Token = "0x4000929")]
		None
	}

	[Token(Token = "0x4000917")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Method ScalingX;

	[Token(Token = "0x4000918")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Range(0f, 0.5f)]
	public float PaddingX;

	[Token(Token = "0x4000919")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Range(-0.5f, 0f)]
	public float PaddingXMax;

	[Token(Token = "0x400091A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Method ScalingY;

	[Token(Token = "0x400091B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Range(0f, 0.5f)]
	public float PaddingY;

	[Token(Token = "0x400091C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[Range(-0.5f, 0f)]
	public float PaddingYMax;

	[Token(Token = "0x400091D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Method ScalingZ;

	[Token(Token = "0x400091E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[Range(0f, 0.5f)]
	public float PaddingZ;

	[Token(Token = "0x400091F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Range(-0.5f, 0f)]
	public float PaddingZMax;

	[Token(Token = "0x4000920")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private Vector3 <NewSize>k__BackingField;

	[Token(Token = "0x4000921")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Vector3 <DefaultSize>k__BackingField;

	[Token(Token = "0x4000922")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Mesh <Mesh>k__BackingField;

	[Token(Token = "0x4000923")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Bounds _bounds;

	[Token(Token = "0x4000924")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Transform _pivotTransform;

	[Token(Token = "0x1700008B")]
	public Vector3 PivotPosition
	{
		[Token(Token = "0x6000711")]
		[Address(RVA = "0x9F1010", Offset = "0x9F1010", VA = "0x9F1010")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x1700008C")]
	public Vector3 NewSize
	{
		[Token(Token = "0x6000712")]
		[Address(RVA = "0x9F102C", Offset = "0x9F102C", VA = "0x9F102C")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000713")]
		[Address(RVA = "0x9F1038", Offset = "0x9F1038", VA = "0x9F1038")]
		set
		{
		}
	}

	[Token(Token = "0x1700008D")]
	public Vector3 DefaultSize
	{
		[Token(Token = "0x6000714")]
		[Address(RVA = "0x9F1044", Offset = "0x9F1044", VA = "0x9F1044")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000715")]
		[Address(RVA = "0x9F1050", Offset = "0x9F1050", VA = "0x9F1050")]
		private set
		{
		}
	}

	[Token(Token = "0x1700008E")]
	public Mesh Mesh
	{
		[Token(Token = "0x6000716")]
		[Address(RVA = "0x9F105C", Offset = "0x9F105C", VA = "0x9F105C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000717")]
		[Address(RVA = "0x9F1064", Offset = "0x9F1064", VA = "0x9F1064")]
		private set
		{
		}
	}

	[Token(Token = "0x6000718")]
	[Address(RVA = "0x9F106C", Offset = "0x9F106C", VA = "0x9F106C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000719")]
	[Address(RVA = "0x9F11A8", Offset = "0x9F11A8", VA = "0x9F11A8")]
	public SimpleResizable()
	{
	}
}
[Token(Token = "0x2000141")]
public class SimpleResizer
{
	[Token(Token = "0x600071A")]
	[Address(RVA = "0x9F08E4", Offset = "0x9F08E4", VA = "0x9F08E4")]
	public void CreateResizedObject(Vector3 newSize, GameObject parent, SimpleResizable sourcePrefab)
	{
	}

	[Token(Token = "0x600071B")]
	[Address(RVA = "0x9F11B0", Offset = "0x9F11B0", VA = "0x9F11B0")]
	private Mesh ProcessVertices(SimpleResizable resizable, Vector3 newSize)
	{
		return null;
	}

	[Token(Token = "0x600071C")]
	[Address(RVA = "0x9F1434", Offset = "0x9F1434", VA = "0x9F1434")]
	private float CalculateNewVertexPosition(SimpleResizable.Method resizeMethod, float currentPosition, float currentSize, float newSize, float padding, float paddingMax, float pivot)
	{
		return default(float);
	}

	[Token(Token = "0x600071D")]
	[Address(RVA = "0x9F08DC", Offset = "0x9F08DC", VA = "0x9F08DC")]
	public SimpleResizer()
	{
	}
}
[Serializable]
[Token(Token = "0x2000142")]
public class Spawnable : ISerializationCallbackReceiver
{
	[Token(Token = "0x400092A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public SimpleResizable ResizablePrefab;

	[Token(Token = "0x400092B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string ClassificationLabel;

	[Token(Token = "0x400092C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private int _editorClassificationIndex;

	[Token(Token = "0x600071E")]
	[Address(RVA = "0x9F14DC", Offset = "0x9F14DC", VA = "0x9F14DC", Slot = "4")]
	public void OnBeforeSerialize()
	{
	}

	[Token(Token = "0x600071F")]
	[Address(RVA = "0x9F14E0", Offset = "0x9F14E0", VA = "0x9F14E0", Slot = "5")]
	public void OnAfterDeserialize()
	{
	}

	[Token(Token = "0x6000720")]
	[Address(RVA = "0x9F1948", Offset = "0x9F1948", VA = "0x9F1948")]
	public Spawnable()
	{
	}

	[Token(Token = "0x6000721")]
	[Address(RVA = "0x9F1634", Offset = "0x9F1634", VA = "0x9F1634")]
	internal static int <OnAfterDeserialize>g__IndexOf|4_0(string label, IEnumerable<string> collection)
	{
		return default(int);
	}
}
[Token(Token = "0x2000143")]
[RequireComponent(typeof(OVRSceneAnchor))]
public class VolumeAndPlaneSwitcher : MonoBehaviour
{
	[Token(Token = "0x2000144")]
	public enum GeometryType
	{
		[Token(Token = "0x4000931")]
		Plane,
		[Token(Token = "0x4000932")]
		Volume
	}

	[Serializable]
	[Token(Token = "0x2000145")]
	public struct LabelGeometryPair
	{
		[Token(Token = "0x4000933")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string label;

		[Token(Token = "0x4000934")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public GeometryType desiredGeometryType;
	}

	[Token(Token = "0x400092D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRSceneAnchor planePrefab;

	[Token(Token = "0x400092E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OVRSceneAnchor volumePrefab;

	[Token(Token = "0x400092F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<LabelGeometryPair> desiredSwitches;

	[Token(Token = "0x6000722")]
	[Address(RVA = "0x9F19A0", Offset = "0x9F19A0", VA = "0x9F19A0")]
	private void ReplaceAnchor(OVRSceneAnchor prefab, Vector3 position, Quaternion rotation, Vector3 localScale)
	{
	}

	[Token(Token = "0x6000723")]
	[Address(RVA = "0x9F1DCC", Offset = "0x9F1DCC", VA = "0x9F1DCC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000724")]
	[Address(RVA = "0x9F2704", Offset = "0x9F2704", VA = "0x9F2704")]
	private void GetVolumeFromTopPlane(Transform plane, Vector2 dimensions, float height, out Vector3 position, out Quaternion rotation, out Vector3 localScale)
	{
	}

	[Token(Token = "0x6000725")]
	[Address(RVA = "0x9F25DC", Offset = "0x9F25DC", VA = "0x9F25DC")]
	private void GetTopPlaneFromVolume(Transform volume, Vector3 dimensions, out Vector3 position, out Quaternion rotation, out Vector3 localScale)
	{
	}

	[Token(Token = "0x6000726")]
	[Address(RVA = "0x9F2784", Offset = "0x9F2784", VA = "0x9F2784")]
	public VolumeAndPlaneSwitcher()
	{
	}
}
[Token(Token = "0x2000146")]
[RequireComponent(typeof(OVRSpatialAnchor))]
public class Anchor : MonoBehaviour
{
	[Token(Token = "0x2000147")]
	private sealed class <Start>d__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000948")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000949")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400094A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Anchor <>4__this;

		[Token(Token = "0x17000090")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600073A")]
			[Address(RVA = "0x9F354C", Offset = "0x9F354C", VA = "0x9F354C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000091")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600073C")]
			[Address(RVA = "0x9F3594", Offset = "0x9F3594", VA = "0x9F3594", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0x9F2980", Offset = "0x9F2980", VA = "0x9F2980")]
		[DebuggerHidden]
		public <Start>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0x9F33D0", Offset = "0x9F33D0", VA = "0x9F33D0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0x9F33D4", Offset = "0x9F33D4", VA = "0x9F33D4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0x9F3554", Offset = "0x9F3554", VA = "0x9F3554", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000935")]
	public const string NumUuidsPlayerPref = "numUuids";

	[Token(Token = "0x4000936")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	[FormerlySerializedAs("canvas_")]
	private Canvas _canvas;

	[Token(Token = "0x4000937")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[FormerlySerializedAs("pivot_")]
	[SerializeField]
	private Transform _pivot;

	[Token(Token = "0x4000938")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	[FormerlySerializedAs("anchorMenu_")]
	private GameObject _anchorMenu;

	[Token(Token = "0x4000939")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool _isSelected;

	[Token(Token = "0x400093A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	private bool _isHovered;

	[Token(Token = "0x400093B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	[FormerlySerializedAs("anchorName_")]
	private TextMeshProUGUI _anchorName;

	[Token(Token = "0x400093C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	[FormerlySerializedAs("saveIcon_")]
	private GameObject _saveIcon;

	[Token(Token = "0x400093D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	[FormerlySerializedAs("labelImage_")]
	private Image _labelImage;

	[Token(Token = "0x400093E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	[FormerlySerializedAs("labelBaseColor_")]
	private Color _labelBaseColor;

	[Token(Token = "0x400093F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	[FormerlySerializedAs("labelHighlightColor_")]
	private Color _labelHighlightColor;

	[Token(Token = "0x4000940")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[FormerlySerializedAs("labelSelectedColor_")]
	[SerializeField]
	private Color _labelSelectedColor;

	[Token(Token = "0x4000941")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[FormerlySerializedAs("uiManager_")]
	[SerializeField]
	private AnchorUIManager _uiManager;

	[Token(Token = "0x4000942")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	[FormerlySerializedAs("renderers_")]
	private MeshRenderer[] _renderers;

	[Token(Token = "0x4000943")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private int _menuIndex;

	[Token(Token = "0x4000944")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[SerializeField]
	[FormerlySerializedAs("buttonList_")]
	private List<Button> _buttonList;

	[Token(Token = "0x4000945")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Button _selectedButton;

	[Token(Token = "0x4000946")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private OVRSpatialAnchor _spatialAnchor;

	[Token(Token = "0x4000947")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private GameObject _icon;

	[Token(Token = "0x1700008F")]
	public bool ShowSaveIcon
	{
		[Token(Token = "0x600072D")]
		[Address(RVA = "0x9F2E2C", Offset = "0x9F2E2C", VA = "0x9F2E2C")]
		set
		{
		}
	}

	[Token(Token = "0x6000727")]
	[Address(RVA = "0x9F278C", Offset = "0x9F278C", VA = "0x9F278C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000728")]
	[Address(RVA = "0x9F290C", Offset = "0x9F290C", VA = "0x9F290C")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6000729")]
	[Address(RVA = "0x9F29A8", Offset = "0x9F29A8", VA = "0x9F29A8")]
	private void Update()
	{
	}

	[Token(Token = "0x600072A")]
	[Address(RVA = "0x9F2C20", Offset = "0x9F2C20", VA = "0x9F2C20")]
	public void OnSaveLocalButtonPressed()
	{
	}

	[Token(Token = "0x600072B")]
	[Address(RVA = "0x9F2CF0", Offset = "0x9F2CF0", VA = "0x9F2CF0")]
	public void OnHideButtonPressed()
	{
	}

	[Token(Token = "0x600072C")]
	[Address(RVA = "0x9F2D5C", Offset = "0x9F2D5C", VA = "0x9F2D5C")]
	public void OnEraseButtonPressed()
	{
	}

	[Token(Token = "0x600072E")]
	[Address(RVA = "0x9F2E4C", Offset = "0x9F2E4C", VA = "0x9F2E4C")]
	public void OnHoverStart()
	{
	}

	[Token(Token = "0x600072F")]
	[Address(RVA = "0x9F2F68", Offset = "0x9F2F68", VA = "0x9F2F68")]
	public void OnHoverEnd()
	{
	}

	[Token(Token = "0x6000730")]
	[Address(RVA = "0x9F3070", Offset = "0x9F3070", VA = "0x9F3070")]
	public void OnSelect()
	{
	}

	[Token(Token = "0x6000731")]
	[Address(RVA = "0x9F29F8", Offset = "0x9F29F8", VA = "0x9F29F8")]
	private void BillboardPanel(Transform panel)
	{
	}

	[Token(Token = "0x6000732")]
	[Address(RVA = "0x9F2B2C", Offset = "0x9F2B2C", VA = "0x9F2B2C")]
	private void HandleMenuNavigation()
	{
	}

	[Token(Token = "0x6000733")]
	[Address(RVA = "0x9F3140", Offset = "0x9F3140", VA = "0x9F3140")]
	private void NavigateToIndexInMenu(bool moveNext)
	{
	}

	[Token(Token = "0x6000734")]
	[Address(RVA = "0x9F3278", Offset = "0x9F3278", VA = "0x9F3278")]
	public Anchor()
	{
	}

	[Token(Token = "0x6000735")]
	[Address(RVA = "0x9F3280", Offset = "0x9F3280", VA = "0x9F3280")]
	private void <OnSaveLocalButtonPressed>b__22_0(OVRSpatialAnchor anchor, bool success)
	{
	}

	[Token(Token = "0x6000736")]
	[Address(RVA = "0x9F33A4", Offset = "0x9F33A4", VA = "0x9F33A4")]
	private void <OnEraseButtonPressed>b__24_0(OVRSpatialAnchor anchor, bool success)
	{
	}
}
[Token(Token = "0x2000148")]
[RequireComponent(typeof(SpatialAnchorLoader))]
public class AnchorUIManager : MonoBehaviour
{
	[Token(Token = "0x2000149")]
	public enum AnchorMode
	{
		[Token(Token = "0x400095E")]
		Create,
		[Token(Token = "0x400095F")]
		Select
	}

	[Token(Token = "0x200014A")]
	private delegate void PrimaryPressDelegate();

	[Token(Token = "0x400094B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static AnchorUIManager Instance;

	[Token(Token = "0x400094C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[FormerlySerializedAs("createModeButton_")]
	[SerializeField]
	private GameObject _createModeButton;

	[Token(Token = "0x400094D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[FormerlySerializedAs("selectModeButton_")]
	[SerializeField]
	private GameObject _selectModeButton;

	[Token(Token = "0x400094E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	[FormerlySerializedAs("trackedDevice_")]
	private Transform _trackedDevice;

	[Token(Token = "0x400094F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Transform _raycastOrigin;

	[Token(Token = "0x4000950")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool _drawRaycast;

	[Token(Token = "0x4000951")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	[FormerlySerializedAs("lineRenderer_")]
	private LineRenderer _lineRenderer;

	[Token(Token = "0x4000952")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Anchor _hoveredAnchor;

	[Token(Token = "0x4000953")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Anchor _selectedAnchor;

	[Token(Token = "0x4000954")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private AnchorMode _mode;

	[Token(Token = "0x4000955")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	[FormerlySerializedAs("buttonList_")]
	private List<Button> _buttonList;

	[Token(Token = "0x4000956")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int _menuIndex;

	[Token(Token = "0x4000957")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Button _selectedButton;

	[Token(Token = "0x4000958")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Anchor _anchorPrefab;

	[Token(Token = "0x4000959")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[FormerlySerializedAs("placementPreview_")]
	[SerializeField]
	private GameObject _placementPreview;

	[Token(Token = "0x400095A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[FormerlySerializedAs("anchorPlacementTransform_")]
	[SerializeField]
	private Transform _anchorPlacementTransform;

	[Token(Token = "0x400095B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private PrimaryPressDelegate _primaryPressDelegate;

	[Token(Token = "0x400095C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private bool _isFocused;

	[Token(Token = "0x17000092")]
	public Anchor AnchorPrefab
	{
		[Token(Token = "0x600073D")]
		[Address(RVA = "0x9F359C", Offset = "0x9F359C", VA = "0x9F359C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600073E")]
	[Address(RVA = "0x9F35A4", Offset = "0x9F35A4", VA = "0x9F35A4")]
	private void Awake()
	{
	}

	[Token(Token = "0x600073F")]
	[Address(RVA = "0x9F3670", Offset = "0x9F3670", VA = "0x9F3670")]
	private void Start()
	{
	}

	[Token(Token = "0x6000740")]
	[Address(RVA = "0x9F37C0", Offset = "0x9F37C0", VA = "0x9F37C0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000741")]
	[Address(RVA = "0x9F3C30", Offset = "0x9F3C30", VA = "0x9F3C30")]
	public void OnCreateModeButtonPressed()
	{
	}

	[Token(Token = "0x6000742")]
	[Address(RVA = "0x9F3C9C", Offset = "0x9F3C9C", VA = "0x9F3C9C")]
	public void OnLoadAnchorsButtonPressed()
	{
	}

	[Token(Token = "0x6000743")]
	[Address(RVA = "0x9F3758", Offset = "0x9F3758", VA = "0x9F3758")]
	private void ToggleCreateMode()
	{
	}

	[Token(Token = "0x6000744")]
	[Address(RVA = "0x9F3F1C", Offset = "0x9F3F1C", VA = "0x9F3F1C")]
	private void StartPlacementMode()
	{
	}

	[Token(Token = "0x6000745")]
	[Address(RVA = "0x9F3FA4", Offset = "0x9F3FA4", VA = "0x9F3FA4")]
	private void EndPlacementMode()
	{
	}

	[Token(Token = "0x6000746")]
	[Address(RVA = "0x9F3FC4", Offset = "0x9F3FC4", VA = "0x9F3FC4")]
	private void StartSelectMode()
	{
	}

	[Token(Token = "0x6000747")]
	[Address(RVA = "0x9F3EFC", Offset = "0x9F3EFC", VA = "0x9F3EFC")]
	private void EndSelectMode()
	{
	}

	[Token(Token = "0x6000748")]
	[Address(RVA = "0x9F3B3C", Offset = "0x9F3B3C", VA = "0x9F3B3C")]
	private void HandleMenuNavigation()
	{
	}

	[Token(Token = "0x6000749")]
	[Address(RVA = "0x9F41C4", Offset = "0x9F41C4", VA = "0x9F41C4")]
	private void NavigateToIndexInMenu(bool moveNext)
	{
	}

	[Token(Token = "0x600074A")]
	[Address(RVA = "0x9F404C", Offset = "0x9F404C", VA = "0x9F404C")]
	private void ShowAnchorPreview()
	{
	}

	[Token(Token = "0x600074B")]
	[Address(RVA = "0x9F4138", Offset = "0x9F4138", VA = "0x9F4138")]
	private void HideAnchorPreview()
	{
	}

	[Token(Token = "0x600074C")]
	[Address(RVA = "0x9F42C4", Offset = "0x9F42C4", VA = "0x9F42C4")]
	private void PlaceAnchor()
	{
	}

	[Token(Token = "0x600074D")]
	[Address(RVA = "0x9F4158", Offset = "0x9F4158", VA = "0x9F4158")]
	private void ShowRaycastLine()
	{
	}

	[Token(Token = "0x600074E")]
	[Address(RVA = "0x9F4190", Offset = "0x9F4190", VA = "0x9F4190")]
	private void HideRaycastLine()
	{
	}

	[Token(Token = "0x600074F")]
	[Address(RVA = "0x9F38C0", Offset = "0x9F38C0", VA = "0x9F38C0")]
	private void ControllerRaycast()
	{
	}

	[Token(Token = "0x6000750")]
	[Address(RVA = "0x9F43B0", Offset = "0x9F43B0", VA = "0x9F43B0")]
	private void HoverAnchor(Anchor anchor)
	{
	}

	[Token(Token = "0x6000751")]
	[Address(RVA = "0x9F43D8", Offset = "0x9F43D8", VA = "0x9F43D8")]
	private void UnhoverAnchor()
	{
	}

	[Token(Token = "0x6000752")]
	[Address(RVA = "0x9F4468", Offset = "0x9F4468", VA = "0x9F4468")]
	private void SelectAnchor()
	{
	}

	[Token(Token = "0x6000753")]
	[Address(RVA = "0x9F45B0", Offset = "0x9F45B0", VA = "0x9F45B0")]
	public AnchorUIManager()
	{
	}
}
[Token(Token = "0x200014B")]
public class SpatialAnchorLoader : MonoBehaviour
{
	[Token(Token = "0x4000960")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private OVRSpatialAnchor _anchorPrefab;

	[Token(Token = "0x4000961")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Action<OVRSpatialAnchor.UnboundAnchor, bool> _onLoadAnchor;

	[Token(Token = "0x6000756")]
	[Address(RVA = "0x9F3CF0", Offset = "0x9F3CF0", VA = "0x9F3CF0")]
	public void LoadAnchorsByUuid()
	{
	}

	[Token(Token = "0x6000757")]
	[Address(RVA = "0x9F4740", Offset = "0x9F4740", VA = "0x9F4740")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000758")]
	[Address(RVA = "0x9F4660", Offset = "0x9F4660", VA = "0x9F4660")]
	private void Load(OVRSpatialAnchor.LoadOptions options)
	{
	}

	[Token(Token = "0x6000759")]
	[Address(RVA = "0x9F47C4", Offset = "0x9F47C4", VA = "0x9F47C4")]
	private void OnLocalized(OVRSpatialAnchor.UnboundAnchor unboundAnchor, bool success)
	{
	}

	[Token(Token = "0x600075A")]
	[Address(RVA = "0x9F45D4", Offset = "0x9F45D4", VA = "0x9F45D4")]
	private static void Log(string message)
	{
	}

	[Token(Token = "0x600075B")]
	[Address(RVA = "0x9F4974", Offset = "0x9F4974", VA = "0x9F4974")]
	public SpatialAnchorLoader()
	{
	}

	[Token(Token = "0x600075C")]
	[Address(RVA = "0x9F497C", Offset = "0x9F497C", VA = "0x9F497C")]
	private void <Load>b__4_0(OVRSpatialAnchor.UnboundAnchor[] anchors)
	{
	}
}
[Token(Token = "0x200014C")]
public class StartMenu : MonoBehaviour
{
	[Token(Token = "0x200014D")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x4000965")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int sceneIndex;

		[Token(Token = "0x4000966")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public StartMenu <>4__this;

		[Token(Token = "0x6000760")]
		[Address(RVA = "0x9F4CB8", Offset = "0x9F4CB8", VA = "0x9F4CB8")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0x9F4DCC", Offset = "0x9F4DCC", VA = "0x9F4DCC")]
		internal void <Start>b__0()
		{
		}
	}

	[Token(Token = "0x4000962")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVROverlay overlay;

	[Token(Token = "0x4000963")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OVROverlay text;

	[Token(Token = "0x4000964")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OVRCameraRig vrRig;

	[Token(Token = "0x600075D")]
	[Address(RVA = "0x9F4AAC", Offset = "0x9F4AAC", VA = "0x9F4AAC")]
	private void Start()
	{
	}

	[Token(Token = "0x600075E")]
	[Address(RVA = "0x9F4CC0", Offset = "0x9F4CC0", VA = "0x9F4CC0")]
	private void LoadScene(int idx)
	{
	}

	[Token(Token = "0x600075F")]
	[Address(RVA = "0x9F4DC4", Offset = "0x9F4DC4", VA = "0x9F4DC4")]
	public StartMenu()
	{
	}
}
[Token(Token = "0x200014E")]
public class LocalizedHaptics : MonoBehaviour
{
	[Token(Token = "0x4000967")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private OVRInput.Handedness m_handedness;

	[Token(Token = "0x4000968")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private OVRInput.Controller m_controller;

	[Token(Token = "0x6000762")]
	[Address(RVA = "0x9F4DE8", Offset = "0x9F4DE8", VA = "0x9F4DE8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000763")]
	[Address(RVA = "0x9F4E10", Offset = "0x9F4E10", VA = "0x9F4E10")]
	private void Update()
	{
	}

	[Token(Token = "0x6000764")]
	[Address(RVA = "0x9F4F4C", Offset = "0x9F4F4C", VA = "0x9F4F4C")]
	public LocalizedHaptics()
	{
	}
}
[Token(Token = "0x200014F")]
public class SceneSettings : MonoBehaviour
{
	[Token(Token = "0x4000969")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float m_fixedTimeStep;

	[Token(Token = "0x400096A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float m_gravityScalar;

	[Token(Token = "0x400096B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float m_defaultContactOffset;

	[Token(Token = "0x6000765")]
	[Address(RVA = "0x9F4F5C", Offset = "0x9F4F5C", VA = "0x9F4F5C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000766")]
	[Address(RVA = "0x9F4FF4", Offset = "0x9F4FF4", VA = "0x9F4FF4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000767")]
	[Address(RVA = "0x9F4FFC", Offset = "0x9F4FFC", VA = "0x9F4FFC")]
	private static void CollidersSetContactOffset(float contactOffset)
	{
	}

	[Token(Token = "0x6000768")]
	[Address(RVA = "0x9F50C0", Offset = "0x9F50C0", VA = "0x9F50C0")]
	public SceneSettings()
	{
	}
}
[Token(Token = "0x2000150")]
public class StylusTip : MonoBehaviour
{
	[Token(Token = "0x400096C")]
	private const int MaxBreadCrumbs = 60;

	[Token(Token = "0x400096D")]
	private const float BreadCrumbMinSize = 0.005f;

	[Token(Token = "0x400096E")]
	private const float BreadCrumbMaxSize = 0.02f;

	[Token(Token = "0x400096F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform m_trackingSpace;

	[Token(Token = "0x4000970")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private OVRInput.Handedness m_handedness;

	[Token(Token = "0x4000971")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject m_breadCrumbPf;

	[Token(Token = "0x4000972")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GameObject m_breadCrumbContainer;

	[Token(Token = "0x4000973")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private GameObject[] m_breadCrumbs;

	[Token(Token = "0x4000974")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private int m_breadCrumbIndexPrev;

	[Token(Token = "0x4000975")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private int m_breadCrumbIndexCurr;

	[Token(Token = "0x4000976")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private OVRInput.Controller m_controller;

	[Token(Token = "0x6000769")]
	[Address(RVA = "0x9F50E0", Offset = "0x9F50E0", VA = "0x9F50E0")]
	private void Awake()
	{
	}

	[Token(Token = "0x600076A")]
	[Address(RVA = "0x9F5360", Offset = "0x9F5360", VA = "0x9F5360")]
	private void Update()
	{
	}

	[Token(Token = "0x600076B")]
	[Address(RVA = "0x9F5790", Offset = "0x9F5790", VA = "0x9F5790")]
	private static Pose GetT_Device_StylusTip(OVRInput.Controller controller)
	{
		return default(Pose);
	}

	[Token(Token = "0x600076C")]
	[Address(RVA = "0x9F58BC", Offset = "0x9F58BC", VA = "0x9F58BC")]
	public StylusTip()
	{
	}
}
[Token(Token = "0x2000151")]
public class UiAxis1dInspector : MonoBehaviour
{
	[Token(Token = "0x4000977")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float m_minExtent;

	[Token(Token = "0x4000978")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float m_maxExtent;

	[Token(Token = "0x4000979")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private TextMeshProUGUI m_nameLabel;

	[Token(Token = "0x400097A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private TextMeshProUGUI m_valueLabel;

	[Token(Token = "0x400097B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Slider m_slider;

	[Token(Token = "0x600076D")]
	[Address(RVA = "0x9F58D4", Offset = "0x9F58D4", VA = "0x9F58D4")]
	public void SetExtents(float minExtent, float maxExtent)
	{
	}

	[Token(Token = "0x600076E")]
	[Address(RVA = "0x9F58DC", Offset = "0x9F58DC", VA = "0x9F58DC")]
	public void SetName(string name)
	{
	}

	[Token(Token = "0x600076F")]
	[Address(RVA = "0x9F5900", Offset = "0x9F5900", VA = "0x9F5900")]
	public void SetValue(float value)
	{
	}

	[Token(Token = "0x6000770")]
	[Address(RVA = "0x9F5A04", Offset = "0x9F5A04", VA = "0x9F5A04")]
	public UiAxis1dInspector()
	{
	}
}
[Token(Token = "0x2000152")]
public class UiAxis2dInspector : MonoBehaviour
{
	[Token(Token = "0x400097C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Vector2 m_xExtent;

	[Token(Token = "0x400097D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Vector2 m_yExtent;

	[Token(Token = "0x400097E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private TextMeshProUGUI m_nameLabel;

	[Token(Token = "0x400097F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private TextMeshProUGUI m_valueLabel;

	[Token(Token = "0x4000980")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Image m_handle;

	[Token(Token = "0x6000771")]
	[Address(RVA = "0x9F5A14", Offset = "0x9F5A14", VA = "0x9F5A14")]
	public void SetExtents(Vector2 xExtent, Vector2 yExtent)
	{
	}

	[Token(Token = "0x6000772")]
	[Address(RVA = "0x9F5A20", Offset = "0x9F5A20", VA = "0x9F5A20")]
	public void SetName(string name)
	{
	}

	[Token(Token = "0x6000773")]
	[Address(RVA = "0x9F5A44", Offset = "0x9F5A44", VA = "0x9F5A44")]
	public void SetValue(bool isTouching, Vector2 value)
	{
	}

	[Token(Token = "0x6000774")]
	[Address(RVA = "0x9F5E0C", Offset = "0x9F5E0C", VA = "0x9F5E0C")]
	public UiAxis2dInspector()
	{
	}
}
[Token(Token = "0x2000153")]
public class UiBoolInspector : MonoBehaviour
{
	[Token(Token = "0x4000981")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private TextMeshProUGUI m_nameLabel;

	[Token(Token = "0x4000982")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Toggle m_toggle;

	[Token(Token = "0x6000775")]
	[Address(RVA = "0x9F5E20", Offset = "0x9F5E20", VA = "0x9F5E20")]
	public void SetName(string name)
	{
	}

	[Token(Token = "0x6000776")]
	[Address(RVA = "0x9F5E44", Offset = "0x9F5E44", VA = "0x9F5E44")]
	public void SetValue(bool value)
	{
	}

	[Token(Token = "0x6000777")]
	[Address(RVA = "0x9F5E64", Offset = "0x9F5E64", VA = "0x9F5E64")]
	public UiBoolInspector()
	{
	}
}
[Token(Token = "0x2000154")]
public class UiDeviceInspector : MonoBehaviour
{
	[Token(Token = "0x4000983")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private OVRInput.Handedness m_handedness;

	[Token(Token = "0x4000984")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private TextMeshProUGUI m_title;

	[Token(Token = "0x4000985")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private TextMeshProUGUI m_status;

	[Token(Token = "0x4000986")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private UiBoolInspector m_thumbRestTouch;

	[Token(Token = "0x4000987")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private UiAxis1dInspector m_thumbRestForce;

	[Token(Token = "0x4000988")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private UiAxis1dInspector m_indexTrigger;

	[Token(Token = "0x4000989")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private UiAxis1dInspector m_gripTrigger;

	[Token(Token = "0x400098A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private UiAxis1dInspector m_stylusTipForce;

	[Token(Token = "0x400098B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private UiAxis1dInspector m_indexCurl1d;

	[Token(Token = "0x400098C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private UiAxis1dInspector m_indexSlider1d;

	[Token(Token = "0x400098D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private UiBoolInspector m_ax;

	[Token(Token = "0x400098E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private UiBoolInspector m_axTouch;

	[Token(Token = "0x400098F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private UiBoolInspector m_by;

	[Token(Token = "0x4000990")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private UiBoolInspector m_byTouch;

	[Token(Token = "0x4000991")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private UiBoolInspector m_indexTouch;

	[Token(Token = "0x4000992")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	private UiAxis2dInspector m_thumbstick;

	[Token(Token = "0x4000993")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private OVRInput.Controller m_controller;

	[Token(Token = "0x6000778")]
	[Address(RVA = "0x9F5E6C", Offset = "0x9F5E6C", VA = "0x9F5E6C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000779")]
	[Address(RVA = "0x9F5E94", Offset = "0x9F5E94", VA = "0x9F5E94")]
	private void Update()
	{
	}

	[Token(Token = "0x600077A")]
	[Address(RVA = "0x9F641C", Offset = "0x9F641C", VA = "0x9F641C")]
	private static string ToDeviceModel()
	{
		return null;
	}

	[Token(Token = "0x600077B")]
	[Address(RVA = "0x9F645C", Offset = "0x9F645C", VA = "0x9F645C")]
	private static string ToHandednessString(OVRInput.Handedness handedness)
	{
		return null;
	}

	[Token(Token = "0x600077C")]
	[Address(RVA = "0x9F64E0", Offset = "0x9F64E0", VA = "0x9F64E0")]
	public UiDeviceInspector()
	{
	}
}
[Token(Token = "0x2000155")]
public class UiSceneMenu : MonoBehaviour
{
	[Token(Token = "0x4000994")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private VerticalLayoutGroup m_layoutGroup;

	[Token(Token = "0x4000995")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private TextMeshProUGUI m_labelPf;

	[Token(Token = "0x4000996")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Vector2 s_lastThumbstickL;

	[Token(Token = "0x4000997")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Vector2 s_lastThumbstickR;

	[Token(Token = "0x4000998")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Scene m_activeScene;

	[Token(Token = "0x600077D")]
	[Address(RVA = "0x9F64F0", Offset = "0x9F64F0", VA = "0x9F64F0")]
	private void Awake()
	{
	}

	[Token(Token = "0x600077E")]
	[Address(RVA = "0x9F67BC", Offset = "0x9F67BC", VA = "0x9F67BC")]
	private void Update()
	{
	}

	[Token(Token = "0x600077F")]
	[Address(RVA = "0x9F68D4", Offset = "0x9F68D4", VA = "0x9F68D4")]
	private bool InputPrevScene()
	{
		return default(bool);
	}

	[Token(Token = "0x6000780")]
	[Address(RVA = "0x9F6970", Offset = "0x9F6970", VA = "0x9F6970")]
	private bool InputNextScene()
	{
		return default(bool);
	}

	[Token(Token = "0x6000781")]
	[Address(RVA = "0x9F69B4", Offset = "0x9F69B4", VA = "0x9F69B4")]
	private bool KeyboardPrevScene()
	{
		return default(bool);
	}

	[Token(Token = "0x6000782")]
	[Address(RVA = "0x9F6A50", Offset = "0x9F6A50", VA = "0x9F6A50")]
	private bool KeyboardNextScene()
	{
		return default(bool);
	}

	[Token(Token = "0x6000783")]
	[Address(RVA = "0x9F69C0", Offset = "0x9F69C0", VA = "0x9F69C0")]
	private bool ThumbstickPrevScene(OVRInput.Controller controller)
	{
		return default(bool);
	}

	[Token(Token = "0x6000784")]
	[Address(RVA = "0x9F6A5C", Offset = "0x9F6A5C", VA = "0x9F6A5C")]
	private bool ThumbstickNextScene(OVRInput.Controller controller)
	{
		return default(bool);
	}

	[Token(Token = "0x6000785")]
	[Address(RVA = "0x9F6AEC", Offset = "0x9F6AEC", VA = "0x9F6AEC")]
	private Vector2 GetLastThumbstickValue(OVRInput.Controller controller)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000786")]
	[Address(RVA = "0x9F6918", Offset = "0x9F6918", VA = "0x9F6918")]
	private void ChangeScene(int nextScene)
	{
	}

	[Token(Token = "0x6000787")]
	[Address(RVA = "0x9F6594", Offset = "0x9F6594", VA = "0x9F6594")]
	private void CreateLabel(int sceneIndex, string scenePath)
	{
	}

	[Token(Token = "0x6000788")]
	[Address(RVA = "0x9F6B54", Offset = "0x9F6B54", VA = "0x9F6B54")]
	public UiSceneMenu()
	{
	}
}
[Token(Token = "0x2000156")]
public class UiVectorInspector : MonoBehaviour
{
	[Token(Token = "0x4000999")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private TextMeshProUGUI m_nameLabel;

	[Token(Token = "0x400099A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private TextMeshProUGUI m_valueLabel;

	[Token(Token = "0x6000789")]
	[Address(RVA = "0x9F6B5C", Offset = "0x9F6B5C", VA = "0x9F6B5C")]
	public void SetName(string name)
	{
	}

	[Token(Token = "0x600078A")]
	[Address(RVA = "0x9F6B80", Offset = "0x9F6B80", VA = "0x9F6B80")]
	public void SetValue(bool value)
	{
	}

	[Token(Token = "0x600078B")]
	[Address(RVA = "0x9F6C30", Offset = "0x9F6C30", VA = "0x9F6C30")]
	public UiVectorInspector()
	{
	}
}
[Token(Token = "0x2000157")]
public class Counter : MonoBehaviour
{
	[Token(Token = "0x400099B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Digit[] m_Digits;

	[Token(Token = "0x400099C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int m_Count;

	[Token(Token = "0x400099D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int m_PrevCount;

	[Token(Token = "0x400099E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int m_AlarmValue;

	[Token(Token = "0x400099F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public Color m_OutlineColor;

	[Token(Token = "0x40009A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public Color m_AlarmColor;

	[Token(Token = "0x40009A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private bool m_SetColor;

	[Token(Token = "0x40009A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Material m_Material;

	[Token(Token = "0x40009A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool m_Align;

	[Token(Token = "0x40009A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public string m_PerfName;

	[Token(Token = "0x40009A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool m_RefreshPerfEveryFrame;

	[Token(Token = "0x600078C")]
	[Address(RVA = "0x9F6C38", Offset = "0x9F6C38", VA = "0x9F6C38")]
	private void Start()
	{
	}

	[Token(Token = "0x600078D")]
	[Address(RVA = "0x9F6C9C", Offset = "0x9F6C9C", VA = "0x9F6C9C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600078E")]
	[Address(RVA = "0x9F6EF8", Offset = "0x9F6EF8", VA = "0x9F6EF8")]
	private void UpdateHighlight()
	{
	}

	[Token(Token = "0x600078F")]
	[Address(RVA = "0x9F7024", Offset = "0x9F7024", VA = "0x9F7024")]
	public Counter()
	{
	}
}
[Token(Token = "0x2000158")]
public class Digit : MonoBehaviour
{
	[Token(Token = "0x40009A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int m_Value;

	[Token(Token = "0x40009A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private int m_PrevValue;

	[Token(Token = "0x40009A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject[] m_Digits;

	[Token(Token = "0x6000790")]
	[Address(RVA = "0x9F703C", Offset = "0x9F703C", VA = "0x9F703C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000791")]
	[Address(RVA = "0x9F7118", Offset = "0x9F7118", VA = "0x9F7118")]
	public Digit()
	{
	}
}
[Token(Token = "0x2000159")]
public class FlatCounter : MonoBehaviour
{
	[Token(Token = "0x40009A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MeshRenderer[] m_Digits;

	[Token(Token = "0x40009AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshRenderer[] m_Adds;

	[Token(Token = "0x40009AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int m_Count;

	[Token(Token = "0x40009AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int m_AlarmValue;

	[Token(Token = "0x40009AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Color m_Color;

	[Token(Token = "0x40009AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Color m_AlarmColor;

	[Token(Token = "0x40009AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private int m_PrevCount;

	[Token(Token = "0x40009B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private bool m_SetColor;

	[Token(Token = "0x40009B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
	public bool m_Align;

	[Token(Token = "0x40009B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public string m_PerfName;

	[Token(Token = "0x40009B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public bool m_RefreshPerfEveryFrame;

	[Token(Token = "0x40009B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private Color m_HighlightColor;

	[Token(Token = "0x40009B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private float m_HighlightProgress;

	[Token(Token = "0x6000792")]
	[Address(RVA = "0x9F7128", Offset = "0x9F7128", VA = "0x9F7128")]
	private void Start()
	{
	}

	[Token(Token = "0x6000793")]
	[Address(RVA = "0x9F72C4", Offset = "0x9F72C4", VA = "0x9F72C4")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000794")]
	[Address(RVA = "0x9F7588", Offset = "0x9F7588", VA = "0x9F7588")]
	private void UpdateAlarm()
	{
	}

	[Token(Token = "0x6000795")]
	[Address(RVA = "0x9F7198", Offset = "0x9F7198", VA = "0x9F7198")]
	public void SetColor(Color color)
	{
	}

	[Token(Token = "0x6000796")]
	[Address(RVA = "0x9F7618", Offset = "0x9F7618", VA = "0x9F7618")]
	public FlatCounter()
	{
	}
}
[Token(Token = "0x200015A")]
public class MockupMaker : MonoBehaviour
{
	[Token(Token = "0x40009B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private MeshFilter m_Mesh;

	[Token(Token = "0x40009B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject m_ToTrim;

	[Token(Token = "0x40009B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject m_Decoration;

	[Token(Token = "0x40009B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject m_Mockup;

	[Token(Token = "0x40009BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject m_Bound;

	[Token(Token = "0x40009BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Transform m_VROrientation;

	[Token(Token = "0x6000797")]
	[Address(RVA = "0x9F7634", Offset = "0x9F7634", VA = "0x9F7634")]
	private void Start()
	{
	}

	[Token(Token = "0x6000798")]
	[Address(RVA = "0x9F7E58", Offset = "0x9F7E58", VA = "0x9F7E58")]
	public void Show()
	{
	}

	[Token(Token = "0x6000799")]
	[Address(RVA = "0x9F806C", Offset = "0x9F806C", VA = "0x9F806C")]
	public void Hide()
	{
	}

	[Token(Token = "0x600079A")]
	[Address(RVA = "0x9F773C", Offset = "0x9F773C", VA = "0x9F773C")]
	private void GenerateSegments(MeshFilter[] meshes, MeshFilter[] segments)
	{
	}

	[Token(Token = "0x600079B")]
	[Address(RVA = "0x9F8128", Offset = "0x9F8128", VA = "0x9F8128")]
	private Mesh TrimMesh(MeshFilter mf)
	{
		return null;
	}

	[Token(Token = "0x600079C")]
	[Address(RVA = "0x9F8400", Offset = "0x9F8400", VA = "0x9F8400")]
	public MockupMaker()
	{
	}
}
[Serializable]
[Token(Token = "0x200015B")]
public class GameEvent
{
	[Token(Token = "0x40009BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int source_id;

	[Token(Token = "0x40009BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int frame;

	[Token(Token = "0x40009BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string name;

	[Token(Token = "0x40009BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector3 v3_param;

	[Token(Token = "0x40009C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int i_param;

	[Token(Token = "0x40009C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int i_param2;

	[Token(Token = "0x40009C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public bool was_played;

	[Token(Token = "0x40009C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
	public bool rejcected;

	[Token(Token = "0x600079D")]
	[Address(RVA = "0x9F8408", Offset = "0x9F8408", VA = "0x9F8408")]
	public GameEvent()
	{
	}
}
[Token(Token = "0x200015C")]
public class Recorder : MonoBehaviour
{
	[Token(Token = "0x40009C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Game m_Game;

	[Token(Token = "0x40009C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int m_PrevFrame;

	[Token(Token = "0x40009C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int m_SourceID;

	[Token(Token = "0x40009C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool m_Record;

	[Token(Token = "0x40009C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	public bool m_Smooth;

	[Token(Token = "0x40009C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
	private bool m_Copy;

	[Token(Token = "0x40009CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
	public bool m_RecordTransform;

	[Token(Token = "0x40009CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<GameEvent> m_Events;

	[Token(Token = "0x40009CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Vector3[] m_RecordingPos;

	[Token(Token = "0x40009CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Quaternion[] m_RecordingRot;

	[Token(Token = "0x600079E")]
	[Address(RVA = "0x9F8410", Offset = "0x9F8410", VA = "0x9F8410")]
	public void Copy(ref Recorder reference)
	{
	}

	[Token(Token = "0x600079F")]
	[Address(RVA = "0x9F848C", Offset = "0x9F848C", VA = "0x9F848C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60007A0")]
	[Address(RVA = "0x9F8670", Offset = "0x9F8670", VA = "0x9F8670")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60007A1")]
	[Address(RVA = "0x9F87C8", Offset = "0x9F87C8", VA = "0x9F87C8")]
	public void StartRecord()
	{
	}

	[Token(Token = "0x60007A2")]
	[Address(RVA = "0x9F889C", Offset = "0x9F889C", VA = "0x9F889C")]
	public void Clear()
	{
	}

	[Token(Token = "0x60007A3")]
	[Address(RVA = "0x9F8920", Offset = "0x9F8920", VA = "0x9F8920")]
	public void Play()
	{
	}

	[Token(Token = "0x60007A4")]
	[Address(RVA = "0x9F89AC", Offset = "0x9F89AC", VA = "0x9F89AC")]
	public bool AddEvent(int source_id, string name, Vector3 v3_param, int i_param, int i_param2)
	{
		return default(bool);
	}

	[Token(Token = "0x60007A5")]
	[Address(RVA = "0x9F8C84", Offset = "0x9F8C84", VA = "0x9F8C84")]
	public bool AddEvent(int source_id, string name, Vector3 v3_param, int i_param)
	{
		return default(bool);
	}

	[Token(Token = "0x60007A6")]
	[Address(RVA = "0x9F8C8C", Offset = "0x9F8C8C", VA = "0x9F8C8C")]
	public bool AddEvent(string name, Vector3 v3_param, int i_param, int i_param2)
	{
		return default(bool);
	}

	[Token(Token = "0x60007A7")]
	[Address(RVA = "0x9F8CA4", Offset = "0x9F8CA4", VA = "0x9F8CA4")]
	public bool AddEvent(string name, Vector3 v3_param, int i_param)
	{
		return default(bool);
	}

	[Token(Token = "0x60007A8")]
	[Address(RVA = "0x9F8CBC", Offset = "0x9F8CBC", VA = "0x9F8CBC")]
	public bool GetEvent(ref string name, ref Vector3 v3_param, ref int i_param, ref int i_param2, ref int source_id)
	{
		return default(bool);
	}

	[Token(Token = "0x60007A9")]
	[Address(RVA = "0x9F8EA8", Offset = "0x9F8EA8", VA = "0x9F8EA8")]
	public bool GetEvent(ref string name, ref Vector3 v3_param, ref int i_param, ref int source_id)
	{
		return default(bool);
	}

	[Token(Token = "0x60007AA")]
	[Address(RVA = "0x9F9070", Offset = "0x9F9070", VA = "0x9F9070")]
	public bool GetEvent(ref string name, ref Vector3 v3_param, ref int i_param)
	{
		return default(bool);
	}

	[Token(Token = "0x60007AB")]
	[Address(RVA = "0x9F920C", Offset = "0x9F920C", VA = "0x9F920C")]
	private void Update()
	{
	}

	[Token(Token = "0x60007AC")]
	[Address(RVA = "0x9F8734", Offset = "0x9F8734", VA = "0x9F8734")]
	public int GetCurrFrame()
	{
		return default(int);
	}

	[Token(Token = "0x60007AD")]
	[Address(RVA = "0x9F94F4", Offset = "0x9F94F4", VA = "0x9F94F4")]
	private float GetDeltaTime()
	{
		return default(float);
	}

	[Token(Token = "0x60007AE")]
	[Address(RVA = "0x9F9228", Offset = "0x9F9228", VA = "0x9F9228")]
	private void RecordFrame()
	{
	}

	[Token(Token = "0x60007AF")]
	[Address(RVA = "0x9F92F4", Offset = "0x9F92F4", VA = "0x9F92F4")]
	private void PlayFrame()
	{
	}

	[Token(Token = "0x60007B0")]
	[Address(RVA = "0x9F955C", Offset = "0x9F955C", VA = "0x9F955C")]
	public Recorder()
	{
	}
}
[Token(Token = "0x200015D")]
public class Selector : MonoBehaviour
{
	[Token(Token = "0x40009CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject[] m_Objects;

	[Token(Token = "0x40009CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int m_MinNoSelected;

	[Token(Token = "0x40009D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int m_MaxNoSelected;

	[Token(Token = "0x40009D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int m_NoSelected;

	[Token(Token = "0x60007B1")]
	[Address(RVA = "0x9F95F8", Offset = "0x9F95F8", VA = "0x9F95F8")]
	private void Start()
	{
	}

	[Token(Token = "0x60007B2")]
	[Address(RVA = "0x9F9A0C", Offset = "0x9F9A0C", VA = "0x9F9A0C")]
	public Selector()
	{
	}
}
[Token(Token = "0x200015E")]
public class TActivator : MonoBehaviour
{
	[Token(Token = "0x40009D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject[] m_Objects;

	[Token(Token = "0x60007B3")]
	[Address(RVA = "0x9F9A1C", Offset = "0x9F9A1C", VA = "0x9F9A1C")]
	private void Start()
	{
	}

	[Token(Token = "0x60007B4")]
	[Address(RVA = "0x9F9A80", Offset = "0x9F9A80", VA = "0x9F9A80")]
	public TActivator()
	{
	}
}
[Token(Token = "0x200015F")]
public class Tools
{
	[Token(Token = "0x40009D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static int m_Seed;

	[Token(Token = "0x60007B5")]
	[Address(RVA = "0x9F9A88", Offset = "0x9F9A88", VA = "0x9F9A88")]
	public static float CalculateSectionPos(Vector3 start_pos, Vector3 end_pos, Vector3 pnt)
	{
		return default(float);
	}

	[Token(Token = "0x60007B6")]
	[Address(RVA = "0x9F9920", Offset = "0x9F9920", VA = "0x9F9920")]
	public static float GetRandom(int seed, int idx)
	{
		return default(float);
	}

	[Token(Token = "0x60007B7")]
	[Address(RVA = "0x9F9804", Offset = "0x9F9804", VA = "0x9F9804")]
	public static int GetRandomIDX(int seed, int idx, int max)
	{
		return default(int);
	}

	[Token(Token = "0x60007B8")]
	[Address(RVA = "0x9F9BF4", Offset = "0x9F9BF4", VA = "0x9F9BF4")]
	public static float CosFun(float val)
	{
		return default(float);
	}

	[Token(Token = "0x60007B9")]
	[Address(RVA = "0x9F9C38", Offset = "0x9F9C38", VA = "0x9F9C38")]
	public static float SinSqrtFun(float val)
	{
		return default(float);
	}

	[Token(Token = "0x60007BA")]
	[Address(RVA = "0x9F9C60", Offset = "0x9F9C60", VA = "0x9F9C60")]
	public static float SinPowFun(float val, float pow)
	{
		return default(float);
	}

	[Token(Token = "0x60007BB")]
	[Address(RVA = "0x9F9CA8", Offset = "0x9F9CA8", VA = "0x9F9CA8")]
	public static float FlatSinPowFun(float val, float pow, float flat)
	{
		return default(float);
	}

	[Token(Token = "0x60007BC")]
	[Address(RVA = "0x9F9D00", Offset = "0x9F9D00", VA = "0x9F9D00")]
	public static string GetRandomAudioName(string name, int no_samples = 3)
	{
		return null;
	}

	[Token(Token = "0x60007BD")]
	[Address(RVA = "0x9F9DF0", Offset = "0x9F9DF0", VA = "0x9F9DF0")]
	public static float Mod01(float val)
	{
		return default(float);
	}

	[Token(Token = "0x60007BE")]
	[Address(RVA = "0x9F9DFC", Offset = "0x9F9DFC", VA = "0x9F9DFC")]
	public static float Mod(float val, float mod)
	{
		return default(float);
	}

	[Token(Token = "0x60007BF")]
	[Address(RVA = "0x9F9E10", Offset = "0x9F9E10", VA = "0x9F9E10")]
	public static void DrawArrow(Vector3 start, Vector3 dir, Color color)
	{
	}

	[Token(Token = "0x60007C0")]
	[Address(RVA = "0x9FA2C4", Offset = "0x9FA2C4", VA = "0x9FA2C4")]
	public static void DrawArrow(Color color, Vector3 start, Vector3 end)
	{
	}

	[Token(Token = "0x60007C1")]
	[Address(RVA = "0x9FA39C", Offset = "0x9FA39C", VA = "0x9FA39C")]
	public static int PullNumberFormBrackets(string param)
	{
		return default(int);
	}
}
[Token(Token = "0x2000160")]
public class TurnFaceToCamera : MonoBehaviour
{
	[Token(Token = "0x40009D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool m_StabilizePos;

	[Token(Token = "0x40009D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool m_StabilizeXRot;

	[Token(Token = "0x40009D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float m_StabilizeRot;

	[Token(Token = "0x40009D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float baseRotFactor;

	[Token(Token = "0x40009D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Camera m_Camera;

	[Token(Token = "0x40009D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector3 m_BaseShift;

	[Token(Token = "0x40009DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject m_Parent;

	[Token(Token = "0x40009DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Quaternion baseRotation;

	[Token(Token = "0x60007C3")]
	[Address(RVA = "0x9FA4A4", Offset = "0x9FA4A4", VA = "0x9FA4A4")]
	private void Start()
	{
	}

	[Token(Token = "0x60007C4")]
	[Address(RVA = "0x9FA4F0", Offset = "0x9FA4F0", VA = "0x9FA4F0")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60007C5")]
	[Address(RVA = "0x9FA874", Offset = "0x9FA874", VA = "0x9FA874")]
	public TurnFaceToCamera()
	{
	}
}
[Token(Token = "0x2000161")]
public class UVAnimator : MonoBehaviour
{
	[Token(Token = "0x40009DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Material m_Material;

	[Token(Token = "0x40009DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector2 m_Speed;

	[Token(Token = "0x60007C6")]
	[Address(RVA = "0x9FA8E0", Offset = "0x9FA8E0", VA = "0x9FA8E0")]
	private void Update()
	{
	}

	[Token(Token = "0x60007C7")]
	[Address(RVA = "0x9FA958", Offset = "0x9FA958", VA = "0x9FA958")]
	public UVAnimator()
	{
	}
}
[Token(Token = "0x2000162")]
public class VRKeyboard : MonoBehaviour
{
	[Token(Token = "0x40009DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text[] ButtonLists;

	[Token(Token = "0x40009DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Text Output;

	[Token(Token = "0x40009E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AudioSource m_ClickSFX;

	[Token(Token = "0x40009E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool CapsLock;

	[Token(Token = "0x40009E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private string EditedText;

	[Token(Token = "0x40009E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private string EditedStringName;

	[Token(Token = "0x60007C8")]
	[Address(RVA = "0x9FA960", Offset = "0x9FA960", VA = "0x9FA960")]
	public void Show(string edited_string_name)
	{
	}

	[Token(Token = "0x60007C9")]
	[Address(RVA = "0x9FA9E0", Offset = "0x9FA9E0", VA = "0x9FA9E0")]
	public void OnButtonDown(string letter)
	{
	}

	[Token(Token = "0x60007CA")]
	[Address(RVA = "0x9FAAF8", Offset = "0x9FAAF8", VA = "0x9FAAF8")]
	public void OnCapsLock()
	{
	}

	[Token(Token = "0x60007CB")]
	[Address(RVA = "0x9FABB0", Offset = "0x9FABB0", VA = "0x9FABB0")]
	public void OnClear()
	{
	}

	[Token(Token = "0x60007CC")]
	[Address(RVA = "0x9FAC24", Offset = "0x9FAC24", VA = "0x9FAC24")]
	public void OnBack()
	{
	}

	[Token(Token = "0x60007CD")]
	[Address(RVA = "0x9FAC90", Offset = "0x9FAC90", VA = "0x9FAC90")]
	public void OnEnter()
	{
	}

	[Token(Token = "0x60007CE")]
	[Address(RVA = "0x9FACD0", Offset = "0x9FACD0", VA = "0x9FACD0")]
	public void OnCancel()
	{
	}

	[Token(Token = "0x60007CF")]
	[Address(RVA = "0x9FAA68", Offset = "0x9FAA68", VA = "0x9FAA68")]
	private void PlayClick()
	{
	}

	[Token(Token = "0x60007D0")]
	[Address(RVA = "0x9FAD00", Offset = "0x9FAD00", VA = "0x9FAD00")]
	public VRKeyboard()
	{
	}
}
namespace RhythmTool
{
	[Token(Token = "0x2000163")]
	public abstract class Analysis : MonoBehaviour
	{
		[Token(Token = "0x40009E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int <sampleRate>k__BackingField;

		[Token(Token = "0x40009E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int <frameSize>k__BackingField;

		[Token(Token = "0x40009E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int <hopSize>k__BackingField;

		[Token(Token = "0x40009E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int <frameIndex>k__BackingField;

		[Token(Token = "0x17000093")]
		public Track track
		{
			[Token(Token = "0x60007D1")]
			[Address(RVA = "0x9FAD70", Offset = "0x9FAD70", VA = "0x9FAD70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000094")]
		public int sampleRate
		{
			[Token(Token = "0x60007D2")]
			[Address(RVA = "0x9FAD7C", Offset = "0x9FAD7C", VA = "0x9FAD7C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60007D3")]
			[Address(RVA = "0x9FAD84", Offset = "0x9FAD84", VA = "0x9FAD84")]
			private set
			{
			}
		}

		[Token(Token = "0x17000095")]
		public int frameSize
		{
			[Token(Token = "0x60007D4")]
			[Address(RVA = "0x9FAD8C", Offset = "0x9FAD8C", VA = "0x9FAD8C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60007D5")]
			[Address(RVA = "0x9FAD94", Offset = "0x9FAD94", VA = "0x9FAD94")]
			private set
			{
			}
		}

		[Token(Token = "0x17000096")]
		public int hopSize
		{
			[Token(Token = "0x60007D6")]
			[Address(RVA = "0x9FAD9C", Offset = "0x9FAD9C", VA = "0x9FAD9C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60007D7")]
			[Address(RVA = "0x9FADA4", Offset = "0x9FADA4", VA = "0x9FADA4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000097")]
		public new abstract string name
		{
			[Token(Token = "0x60007D8")]
			get;
		}

		[Token(Token = "0x17000098")]
		protected int frameIndex
		{
			[Token(Token = "0x60007D9")]
			[Address(RVA = "0x9FADAC", Offset = "0x9FADAC", VA = "0x9FADAC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60007DA")]
			[Address(RVA = "0x9FADB4", Offset = "0x9FADB4", VA = "0x9FADB4")]
			private set
			{
			}
		}

		[Token(Token = "0x60007DB")]
		[Address(RVA = "0x9FADBC", Offset = "0x9FADBC", VA = "0x9FADBC", Slot = "5")]
		public virtual void Initialize(int sampleRate, int frameSize, int hopSize)
		{
		}

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x9FADC8", Offset = "0x9FADC8", VA = "0x9FADC8", Slot = "6")]
		public virtual void Process(float[] samples, float[] magnitude, int frameIndex)
		{
		}

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0x9FADD0", Offset = "0x9FADD0", VA = "0x9FADD0")]
		protected float FrameIndexToSeconds(float frameIndex)
		{
			return default(float);
		}

		[Token(Token = "0x60007DE")]
		protected abstract Track GetTrack();

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x9FADEC", Offset = "0x9FADEC", VA = "0x9FADEC")]
		protected Analysis()
		{
		}
	}
	[Token(Token = "0x2000164")]
	[ExecuteInEditMode]
	public abstract class Analysis<T> : Analysis where T : Feature
	{
		[Token(Token = "0x40009E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Track<T> <track>k__BackingField;

		[Token(Token = "0x40009E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Queue<T> toAdd;

		[Token(Token = "0x40009EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Queue<T> toRemove;

		[Token(Token = "0x17000099")]
		public new Track<T> track
		{
			[Token(Token = "0x60007E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007E1")]
			private set
			{
			}
		}

		[Token(Token = "0x60007E2")]
		public override void Initialize(int sampleRate, int frameSize, int hopSize)
		{
		}

		[Token(Token = "0x60007E3")]
		protected sealed override Track GetTrack()
		{
			return null;
		}

		[Token(Token = "0x60007E4")]
		protected void AddFeature(T feature)
		{
		}

		[Token(Token = "0x60007E5")]
		protected void RemoveFeature(T feature)
		{
		}

		[Token(Token = "0x60007E6")]
		private void Update()
		{
		}

		[Token(Token = "0x60007E7")]
		protected Analysis()
		{
		}
	}
	[Token(Token = "0x2000165")]
	public class BeatTrack : Track<Beat>
	{
		[Token(Token = "0x60007E8")]
		[Address(RVA = "0x9FADF4", Offset = "0x9FADF4", VA = "0x9FADF4")]
		public BeatTrack()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000166")]
	public class Beat : Feature
	{
		[Token(Token = "0x40009EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float bpm;

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0x9FAE60", Offset = "0x9FAE60", VA = "0x9FAE60")]
		public Beat()
		{
		}
	}
	[Token(Token = "0x2000167")]
	[DisallowMultipleComponent]
	public class BeatTracker : Analysis<Beat>
	{
		[Token(Token = "0x40009EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float[] signalBuffer;

		[Token(Token = "0x40009ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float[] signal;

		[Token(Token = "0x40009EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float[] smoothedSignal;

		[Token(Token = "0x40009EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float[] autoCorrelation;

		[Token(Token = "0x40009F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float[] combFilter;

		[Token(Token = "0x40009F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float[] lengthScore;

		[Token(Token = "0x40009F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float[] offsetScore;

		[Token(Token = "0x40009F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float[] signalWindow;

		[Token(Token = "0x40009F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float[] offsetWindow;

		[Token(Token = "0x40009F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float[] kernel;

		[Token(Token = "0x40009F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float[] prevMagnitude;

		[Token(Token = "0x40009F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float prevSpectralFlux;

		[Token(Token = "0x40009F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private int maxBeatLength;

		[Token(Token = "0x40009F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private int minBeatLength;

		[Token(Token = "0x40009FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private int beatLength;

		[Token(Token = "0x40009FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int prevBeatLength;

		[Token(Token = "0x40009FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private int beatOffset;

		[Token(Token = "0x40009FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private int updateOffset;

		[Token(Token = "0x40009FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private int bufferSize;

		[Token(Token = "0x40009FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private int resolution;

		[Token(Token = "0x4000A00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int combElements;

		[Token(Token = "0x1700009A")]
		public override string name
		{
			[Token(Token = "0x60007EA")]
			[Address(RVA = "0x9FAE70", Offset = "0x9FAE70", VA = "0x9FAE70", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0x9FAEB0", Offset = "0x9FAEB0", VA = "0x9FAEB0", Slot = "5")]
		public override void Initialize(int sampleRate, int frameSize, int hopSize)
		{
		}

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0x9FB408", Offset = "0x9FB408", VA = "0x9FB408", Slot = "6")]
		public override void Process(float[] samples, float[] magnitude, int frameIndex)
		{
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0x9FB560", Offset = "0x9FB560", VA = "0x9FB560")]
		private float GetSample(float[] magnitude)
		{
			return default(float);
		}

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0x9FB614", Offset = "0x9FB614", VA = "0x9FB614")]
		private void UpdateSignal()
		{
		}

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0x9FB978", Offset = "0x9FB978", VA = "0x9FB978")]
		private void UpdateOffset()
		{
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x9FB78C", Offset = "0x9FB78C", VA = "0x9FB78C")]
		private void UpdateLength()
		{
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0x9FBF8C", Offset = "0x9FBF8C", VA = "0x9FBF8C")]
		private void UpdateAutoCorrelation()
		{
		}

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0x9FC10C", Offset = "0x9FC10C", VA = "0x9FC10C")]
		private void UpdateLengthScore()
		{
		}

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0x9FC364", Offset = "0x9FC364", VA = "0x9FC364")]
		public BeatTracker()
		{
		}
	}
	[Token(Token = "0x2000168")]
	public static class Bindings<T>
	{
		[Token(Token = "0x2000169")]
		private delegate T ObjectActivator(params object[] args);

		[Token(Token = "0x4000A01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<Type, ObjectActivator> bindings;

		[Token(Token = "0x60007F4")]
		public static T GetBinding(params object[] args)
		{
			return (T)null;
		}

		[Token(Token = "0x60007F5")]
		private static ObjectActivator GetCachedActivator(Type type)
		{
			return null;
		}

		[Token(Token = "0x60007F6")]
		private static ObjectActivator GetActivator(ConstructorInfo ctor)
		{
			return null;
		}

		[Token(Token = "0x60007F7")]
		private static Type GetBindingType(Type featureType)
		{
			return null;
		}

		[Token(Token = "0x60007F8")]
		private static ConstructorInfo GetConstructor(Type type)
		{
			return null;
		}
	}
	[Token(Token = "0x200016A")]
	public class Chromagram : Analysis<Chroma>
	{
		[Token(Token = "0x4000A02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int startNote;

		[Token(Token = "0x4000A03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int endNote;

		[Token(Token = "0x4000A04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int bufferSize;

		[Token(Token = "0x4000A05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int downsampleFactor;

		[Token(Token = "0x4000A06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int chromaInterval;

		[Token(Token = "0x4000A07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int[] noteIndices;

		[Token(Token = "0x4000A08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float[] downsampled;

		[Token(Token = "0x4000A09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float[] spectrum;

		[Token(Token = "0x4000A0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float[] magnitude;

		[Token(Token = "0x4000A0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float[] window;

		[Token(Token = "0x4000A0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float[] pitchWindow;

		[Token(Token = "0x4000A0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float[] pitch;

		[Token(Token = "0x4000A0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float[] chroma;

		[Token(Token = "0x4000A0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private int offset;

		[Token(Token = "0x4000A10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private int[] chromaHistory;

		[Token(Token = "0x1700009B")]
		public override string name
		{
			[Token(Token = "0x60007FC")]
			[Address(RVA = "0x9FC3B8", Offset = "0x9FC3B8", VA = "0x9FC3B8", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007FD")]
		[Address(RVA = "0x9FC3F8", Offset = "0x9FC3F8", VA = "0x9FC3F8", Slot = "5")]
		public override void Initialize(int sampleRate, int frameSize, int hopSize)
		{
		}

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0x9FC8BC", Offset = "0x9FC8BC", VA = "0x9FC8BC", Slot = "6")]
		public override void Process(float[] samples, float[] magnitude, int frameIndex)
		{
		}

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0x9FC900", Offset = "0x9FC900", VA = "0x9FC900")]
		private void Downsample(float[] samples)
		{
		}

		[Token(Token = "0x6000800")]
		[Address(RVA = "0x9FCA28", Offset = "0x9FCA28", VA = "0x9FCA28")]
		private void UpdateChroma()
		{
		}

		[Token(Token = "0x6000801")]
		[Address(RVA = "0x9FC748", Offset = "0x9FC748", VA = "0x9FC748")]
		private static int FrequencyToIndex(float frequency, int length, int samplerate)
		{
			return default(int);
		}

		[Token(Token = "0x6000802")]
		[Address(RVA = "0x9FC71C", Offset = "0x9FC71C", VA = "0x9FC71C")]
		private static float GetMidiFrequency(int index)
		{
			return default(float);
		}

		[Token(Token = "0x6000803")]
		[Address(RVA = "0x9FD10C", Offset = "0x9FD10C", VA = "0x9FD10C")]
		public Chromagram()
		{
		}
	}
	[Token(Token = "0x200016B")]
	public class ChromaTrack : Track<Chroma>
	{
		[Token(Token = "0x6000804")]
		[Address(RVA = "0x9FD168", Offset = "0x9FD168", VA = "0x9FD168")]
		public ChromaTrack()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200016C")]
	public class Chroma : Feature
	{
		[Token(Token = "0x4000A11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Note note;

		[Token(Token = "0x6000805")]
		[Address(RVA = "0x9FD104", Offset = "0x9FD104", VA = "0x9FD104")]
		public Chroma()
		{
		}
	}
	[Token(Token = "0x200016D")]
	public enum Note
	{
		[Token(Token = "0x4000A13")]
		A,
		[Token(Token = "0x4000A14")]
		ASharp,
		[Token(Token = "0x4000A15")]
		B,
		[Token(Token = "0x4000A16")]
		C,
		[Token(Token = "0x4000A17")]
		CSHARP,
		[Token(Token = "0x4000A18")]
		D,
		[Token(Token = "0x4000A19")]
		DSHARP,
		[Token(Token = "0x4000A1A")]
		E,
		[Token(Token = "0x4000A1B")]
		F,
		[Token(Token = "0x4000A1C")]
		FSHARP,
		[Token(Token = "0x4000A1D")]
		G,
		[Token(Token = "0x4000A1E")]
		GSHARP
	}
	[Token(Token = "0x200016E")]
	[RequireComponent(typeof(RhythmPlayer))]
	public class DebugDrawer : MonoBehaviour
	{
		[Token(Token = "0x4000A1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private RhythmPlayer <rhythmPlayer>k__BackingField;

		[Token(Token = "0x4000A20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float width;

		[Token(Token = "0x4000A21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float height;

		[Token(Token = "0x4000A22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float padding;

		[Token(Token = "0x1700009C")]
		public RhythmPlayer rhythmPlayer
		{
			[Token(Token = "0x6000806")]
			[Address(RVA = "0x9FD1D4", Offset = "0x9FD1D4", VA = "0x9FD1D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000807")]
			[Address(RVA = "0x9FD1DC", Offset = "0x9FD1DC", VA = "0x9FD1DC")]
			private set
			{
			}
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0x9FD1E4", Offset = "0x9FD1E4", VA = "0x9FD1E4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0x9FD23C", Offset = "0x9FD23C", VA = "0x9FD23C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600080A")]
		[Address(RVA = "0x9FD9E8", Offset = "0x9FD9E8", VA = "0x9FD9E8")]
		public DebugDrawer()
		{
		}
	}
	[Token(Token = "0x200016F")]
	public abstract class TrackDrawer
	{
		[Token(Token = "0x4000A23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<Type, TrackDrawer> trackDrawers;

		[Token(Token = "0x600080B")]
		[Address(RVA = "0x9FD6E0", Offset = "0x9FD6E0", VA = "0x9FD6E0")]
		public static void Draw(Track track, Rect rect, float start, float end)
		{
		}

		[Token(Token = "0x600080C")]
		protected abstract void DrawTrack(Track track, Rect rect, float start, float end);

		[Token(Token = "0x600080D")]
		[Address(RVA = "0x9FDA04", Offset = "0x9FDA04", VA = "0x9FDA04")]
		public static TrackDrawer GetTrackDrawer(Track track)
		{
			return null;
		}
	}
	[Token(Token = "0x2000170")]
	public class Feature
	{
		[Token(Token = "0x4000A24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float timestamp;

		[Token(Token = "0x4000A25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float length;

		[Token(Token = "0x600080F")]
		[Address(RVA = "0x9FAE68", Offset = "0x9FAE68", VA = "0x9FAE68")]
		public Feature()
		{
		}
	}
	[Token(Token = "0x2000171")]
	public class LomontFFT
	{
		[Token(Token = "0x4000A26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private float[] cosTable;

		[Token(Token = "0x4000A27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float[] sinTable;

		[Token(Token = "0x6000810")]
		[Address(RVA = "0x9FDC4C", Offset = "0x9FDC4C", VA = "0x9FDC4C")]
		public void FFT(float[] data, bool forward)
		{
		}

		[Token(Token = "0x6000811")]
		[Address(RVA = "0x9FE0CC", Offset = "0x9FE0CC", VA = "0x9FE0CC")]
		public void RealFFT(float[] data, bool forward)
		{
		}

		[Token(Token = "0x6000812")]
		[Address(RVA = "0x9FE178", Offset = "0x9FE178", VA = "0x9FE178")]
		private void Reconstruct(float[] data, bool forward)
		{
		}

		[Token(Token = "0x6000813")]
		[Address(RVA = "0x9FDF38", Offset = "0x9FDF38", VA = "0x9FDF38")]
		private void InitializeTables(int length)
		{
		}

		[Token(Token = "0x6000814")]
		[Address(RVA = "0x9FDEA8", Offset = "0x9FDEA8", VA = "0x9FDEA8")]
		private static void BitReverse(float[] data)
		{
		}

		[Token(Token = "0x6000815")]
		[Address(RVA = "0x9FE31C", Offset = "0x9FE31C", VA = "0x9FE31C")]
		private static void Swap(float[] data, int a, int b)
		{
		}

		[Token(Token = "0x6000816")]
		[Address(RVA = "0x9FE35C", Offset = "0x9FE35C", VA = "0x9FE35C")]
		public LomontFFT()
		{
		}
	}
	[Token(Token = "0x2000172")]
	public class OnsetDetector : Analysis<Onset>
	{
		[Token(Token = "0x4000A28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Range(0f, 1f)]
		public float normalization;

		[Token(Token = "0x4000A29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Range(0f, 1f)]
		public float threshold;

		[Token(Token = "0x4000A2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Range(2f, 32f)]
		public int bufferSize;

		[Token(Token = "0x4000A2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int start;

		[Token(Token = "0x4000A2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int end;

		[Token(Token = "0x4000A2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float[] buffer;

		[Token(Token = "0x4000A2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float mean;

		[Token(Token = "0x4000A2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float m2;

		[Token(Token = "0x4000A30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float[] prevMagnitude;

		[Token(Token = "0x1700009D")]
		public override string name
		{
			[Token(Token = "0x6000817")]
			[Address(RVA = "0x9FE364", Offset = "0x9FE364", VA = "0x9FE364", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000818")]
		[Address(RVA = "0x9FE3A4", Offset = "0x9FE3A4", VA = "0x9FE3A4", Slot = "5")]
		public override void Initialize(int sampleRate, int frameSize, int hopSize)
		{
		}

		[Token(Token = "0x6000819")]
		[Address(RVA = "0x9FE478", Offset = "0x9FE478", VA = "0x9FE478", Slot = "6")]
		public override void Process(float[] samples, float[] magnitude, int frameIndex)
		{
		}

		[Token(Token = "0x600081A")]
		[Address(RVA = "0x9FE63C", Offset = "0x9FE63C", VA = "0x9FE63C")]
		private float SpectralDifference(float[] magnitude)
		{
			return default(float);
		}

		[Token(Token = "0x600081B")]
		[Address(RVA = "0x9FE6F0", Offset = "0x9FE6F0", VA = "0x9FE6F0")]
		private float Normalize(float sample)
		{
			return default(float);
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0x9FE76C", Offset = "0x9FE76C", VA = "0x9FE76C")]
		public OnsetDetector()
		{
		}
	}
	[Token(Token = "0x2000173")]
	public class OnsetTrack : Track<Onset>
	{
		[Token(Token = "0x600081D")]
		[Address(RVA = "0x9FE7D0", Offset = "0x9FE7D0", VA = "0x9FE7D0")]
		public OnsetTrack()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000174")]
	public class Onset : Feature
	{
		[Token(Token = "0x4000A31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float strength;

		[Token(Token = "0x600081E")]
		[Address(RVA = "0x9FE764", Offset = "0x9FE764", VA = "0x9FE764")]
		public Onset()
		{
		}
	}
	[Token(Token = "0x2000175")]
	[ExecuteInEditMode]
	public class RhythmAnalyzer : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000176")]
		private sealed class <>c
		{
			[Token(Token = "0x4000A4B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000A4C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<Analysis> <>9__41_0;

			[Token(Token = "0x4000A4D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<Analysis, Track> <>9__41_1;

			[Token(Token = "0x6000835")]
			[Address(RVA = "0x9FF8A8", Offset = "0x9FF8A8", VA = "0x9FF8A8")]
			public <>c()
			{
			}

			[Token(Token = "0x6000836")]
			[Address(RVA = "0x9FF8B0", Offset = "0x9FF8B0", VA = "0x9FF8B0")]
			internal bool <Initialize>b__41_0(Analysis a)
			{
				return default(bool);
			}

			[Token(Token = "0x6000837")]
			[Address(RVA = "0x9FF8D8", Offset = "0x9FF8D8", VA = "0x9FF8D8")]
			internal Track <Initialize>b__41_1(Analysis a)
			{
				return null;
			}
		}

		[Token(Token = "0x4000A33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private RhythmData <rhythmData>k__BackingField;

		[Token(Token = "0x4000A34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <progress>k__BackingField;

		[Token(Token = "0x4000A35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private bool <isDone>k__BackingField;

		[Token(Token = "0x4000A36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		private bool <initialized>k__BackingField;

		[Token(Token = "0x4000A37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AudioClip audioClip;

		[Token(Token = "0x4000A38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int hopSize;

		[Token(Token = "0x4000A39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int frameSize;

		[Token(Token = "0x4000A3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int bufferCount;

		[Token(Token = "0x4000A3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int channels;

		[Token(Token = "0x4000A3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int sampleRate;

		[Token(Token = "0x4000A3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int totalFrames;

		[Token(Token = "0x4000A3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int lastFrame;

		[Token(Token = "0x4000A3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float[] buffer;

		[Token(Token = "0x4000A40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float[] window;

		[Token(Token = "0x4000A41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float[] samples;

		[Token(Token = "0x4000A42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float[] monoSamples;

		[Token(Token = "0x4000A43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float[] spectrum;

		[Token(Token = "0x4000A44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float[] magnitude;

		[Token(Token = "0x4000A45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Thread analyze;

		[Token(Token = "0x4000A46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private AutoResetEvent waitForMainThread;

		[Token(Token = "0x4000A47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool getData;

		[Token(Token = "0x4000A48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
		private bool abort;

		[Token(Token = "0x4000A49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private int initialLength;

		[Token(Token = "0x4000A4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private List<Analysis> analyses;

		[Token(Token = "0x1700009E")]
		public RhythmData rhythmData
		{
			[Token(Token = "0x6000821")]
			[Address(RVA = "0x9FE99C", Offset = "0x9FE99C", VA = "0x9FE99C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000822")]
			[Address(RVA = "0x9FE9A4", Offset = "0x9FE9A4", VA = "0x9FE9A4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700009F")]
		public float progress
		{
			[Token(Token = "0x6000823")]
			[Address(RVA = "0x9FE9AC", Offset = "0x9FE9AC", VA = "0x9FE9AC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000824")]
			[Address(RVA = "0x9FE9B4", Offset = "0x9FE9B4", VA = "0x9FE9B4")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A0")]
		public bool isDone
		{
			[Token(Token = "0x6000825")]
			[Address(RVA = "0x9FE9BC", Offset = "0x9FE9BC", VA = "0x9FE9BC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000826")]
			[Address(RVA = "0x9FE9C4", Offset = "0x9FE9C4", VA = "0x9FE9C4")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A1")]
		public bool initialized
		{
			[Token(Token = "0x6000827")]
			[Address(RVA = "0x9FE9D0", Offset = "0x9FE9D0", VA = "0x9FE9D0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000828")]
			[Address(RVA = "0x9FE9D8", Offset = "0x9FE9D8", VA = "0x9FE9D8")]
			private set
			{
			}
		}

		[Token(Token = "0x14000012")]
		public event Action<RhythmData> Initialized
		{
			[Token(Token = "0x600081F")]
			[Address(RVA = "0x9FE83C", Offset = "0x9FE83C", VA = "0x9FE83C")]
			add
			{
			}
			[Token(Token = "0x6000820")]
			[Address(RVA = "0x9FE8EC", Offset = "0x9FE8EC", VA = "0x9FE8EC")]
			remove
			{
			}
		}

		[Token(Token = "0x6000829")]
		[Address(RVA = "0x9FE9E4", Offset = "0x9FE9E4", VA = "0x9FE9E4")]
		public RhythmData Analyze(AudioClip audioClip, float initialLength = 5f)
		{
			return null;
		}

		[Token(Token = "0x600082A")]
		[Address(RVA = "0x9FEB18", Offset = "0x9FEB18", VA = "0x9FEB18")]
		public void Abort()
		{
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0x9FEB74", Offset = "0x9FEB74", VA = "0x9FEB74")]
		private void Initialize()
		{
		}

		[Token(Token = "0x600082C")]
		[Address(RVA = "0x9FEFFC", Offset = "0x9FEFFC", VA = "0x9FEFFC")]
		private void StartAnalyze()
		{
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0x9FF20C", Offset = "0x9FF20C", VA = "0x9FF20C")]
		private void Analyze()
		{
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0x9FF4B8", Offset = "0x9FF4B8", VA = "0x9FF4B8")]
		private void OnAnalysisDone()
		{
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0x9FF2F8", Offset = "0x9FF2F8", VA = "0x9FF2F8")]
		private void ProcessFrame(float[] samples)
		{
		}

		[Token(Token = "0x6000830")]
		[Address(RVA = "0x9FF2CC", Offset = "0x9FF2CC", VA = "0x9FF2CC")]
		private void FillBuffer()
		{
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0x9FF690", Offset = "0x9FF690", VA = "0x9FF690")]
		private void GetData()
		{
		}

		[Token(Token = "0x6000832")]
		[Address(RVA = "0x9FF73C", Offset = "0x9FF73C", VA = "0x9FF73C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0x9FF79C", Offset = "0x9FF79C", VA = "0x9FF79C")]
		public RhythmAnalyzer()
		{
		}
	}
	[Token(Token = "0x2000177")]
	public class RhythmData : ScriptableObject, IEnumerable<Track>, IEnumerable
	{
		[Token(Token = "0x2000178")]
		private sealed class <GetEnumerator>d__12 : IEnumerator<Track>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A50")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000A51")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Track <>2__current;

			[Token(Token = "0x4000A52")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RhythmData <>4__this;

			[Token(Token = "0x4000A53")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private List<Track>.Enumerator <>7__wrap1;

			[Token(Token = "0x170000A3")]
			private Track System.Collections.Generic.IEnumerator<RhythmTool.Track>.Current
			{
				[Token(Token = "0x600084B")]
				[Address(RVA = "0x9FFF64", Offset = "0x9FFF64", VA = "0x9FFF64", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A4")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600084D")]
				[Address(RVA = "0x9FFFAC", Offset = "0x9FFFAC", VA = "0x9FFFAC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000847")]
			[Address(RVA = "0x9FF974", Offset = "0x9FF974", VA = "0x9FF974")]
			[DebuggerHidden]
			public <GetEnumerator>d__12(int <>1__state)
			{
			}

			[Token(Token = "0x6000848")]
			[Address(RVA = "0x9FFD50", Offset = "0x9FFD50", VA = "0x9FFD50", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000849")]
			[Address(RVA = "0x9FFD6C", Offset = "0x9FFD6C", VA = "0x9FFD6C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600084A")]
			[Address(RVA = "0x9FFF14", Offset = "0x9FFF14", VA = "0x9FFF14")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x600084C")]
			[Address(RVA = "0x9FFF6C", Offset = "0x9FFF6C", VA = "0x9FFF6C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000179")]
		private sealed class <>c
		{
			[Token(Token = "0x4000A54")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000A55")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<Track> <>9__14_0;

			[Token(Token = "0x600084F")]
			[Address(RVA = "0xA00024", Offset = "0xA00024", VA = "0xA00024")]
			public <>c()
			{
			}

			[Token(Token = "0x6000850")]
			[Address(RVA = "0xA0002C", Offset = "0xA0002C", VA = "0xA0002C")]
			internal bool <OnEnable>b__14_0(Track t)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000A4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioClip audioClip;

		[Token(Token = "0x4000A4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<Track> _tracks;

		[Token(Token = "0x170000A2")]
		public List<Track> tracks
		{
			[Token(Token = "0x6000838")]
			[Address(RVA = "0x9FF8F8", Offset = "0x9FF8F8", VA = "0x9FF8F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000839")]
		public Track<T> GetTrack<T>() where T : Feature
		{
			return null;
		}

		[Token(Token = "0x600083A")]
		public Track<T> GetTrack<T>(string trackName) where T : Feature
		{
			return null;
		}

		[Token(Token = "0x600083B")]
		public void GetTracks<T>(List<Track<T>> tracks) where T : Feature
		{
		}

		[Token(Token = "0x600083C")]
		public void GetTracks<T>(List<Track<T>> tracks, string trackName) where T : Feature
		{
		}

		[Token(Token = "0x600083D")]
		public void GetFeatures<T>(List<T> features, float start, float end) where T : Feature
		{
		}

		[Token(Token = "0x600083E")]
		public void GetFeatures<T>(List<T> features, float start, float end, string trackName) where T : Feature
		{
		}

		[Token(Token = "0x600083F")]
		public void GetIntersectingFeatures<T>(List<T> features, float start, float end) where T : Feature
		{
		}

		[Token(Token = "0x6000840")]
		public void GetIntersectingFeatures<T>(List<T> features, float start, float end, string trackName) where T : Feature
		{
		}

		[Token(Token = "0x6000841")]
		[Address(RVA = "0x9FF900", Offset = "0x9FF900", VA = "0x9FF900", Slot = "4")]
		public IEnumerator<Track> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000842")]
		[Address(RVA = "0x9FF99C", Offset = "0x9FF99C", VA = "0x9FF99C", Slot = "5")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000843")]
		[Address(RVA = "0x9FFA2C", Offset = "0x9FFA2C", VA = "0x9FFA2C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000844")]
		[Address(RVA = "0x9FFB34", Offset = "0x9FFB34", VA = "0x9FFB34")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000845")]
		[Address(RVA = "0x9FEF38", Offset = "0x9FEF38", VA = "0x9FEF38")]
		public static RhythmData Create(AudioClip audioClip, IEnumerable<Track> tracks)
		{
			return null;
		}

		[Token(Token = "0x6000846")]
		[Address(RVA = "0x9FFCC8", Offset = "0x9FFCC8", VA = "0x9FFCC8")]
		public RhythmData()
		{
		}
	}
	[Token(Token = "0x200017A")]
	public class RhythmEventProvider : RhythmTarget
	{
		[Token(Token = "0x200017B")]
		private abstract class RhythmEvent : IDisposable
		{
			[Token(Token = "0x600085B")]
			public abstract void Process(RhythmData rhythmData, float start, float end);

			[Token(Token = "0x600085C")]
			public abstract void Dispose();

			[Token(Token = "0x600085D")]
			[Address(RVA = "0xA004C0", Offset = "0xA004C0", VA = "0xA004C0")]
			protected RhythmEvent()
			{
			}
		}

		[Token(Token = "0x200017C")]
		private class RhythmEvent<T> : RhythmEvent where T : Feature
		{
			[Token(Token = "0x4000A58")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Action<T> _action;

			[Token(Token = "0x4000A59")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private List<T> _features;

			[Token(Token = "0x4000A5A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private string trackName;

			[Token(Token = "0x600085E")]
			public RhythmEvent(string trackName)
			{
			}

			[Token(Token = "0x600085F")]
			public override void Process(RhythmData rhythmData, float start, float end)
			{
			}

			[Token(Token = "0x6000860")]
			public void Register(Action<T> action)
			{
			}

			[Token(Token = "0x6000861")]
			public void Unregister(Action<T> action)
			{
			}

			[Token(Token = "0x6000862")]
			public override void Dispose()
			{
			}
		}

		[Token(Token = "0x4000A56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(-10f, 10f)]
		public float offset;

		[Token(Token = "0x4000A57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<int, RhythmEvent> _events;

		[Token(Token = "0x6000851")]
		[Address(RVA = "0xA00088", Offset = "0xA00088", VA = "0xA00088", Slot = "4")]
		public override void Process(RhythmData rhythmData, float start, float end)
		{
		}

		[Token(Token = "0x6000852")]
		[Address(RVA = "0xA00204", Offset = "0xA00204", VA = "0xA00204", Slot = "5")]
		public override void Reset(RhythmData rhythmData, float time)
		{
		}

		[Token(Token = "0x6000853")]
		public void Register<T>(Action<T> action) where T : Feature
		{
		}

		[Token(Token = "0x6000854")]
		public void Unregister<T>(Action<T> action) where T : Feature
		{
		}

		[Token(Token = "0x6000855")]
		public void Register<T>(Action<T> action, string trackName) where T : Feature
		{
		}

		[Token(Token = "0x6000856")]
		public void Unregister<T>(Action<T> action, string trackName) where T : Feature
		{
		}

		[Token(Token = "0x6000857")]
		[Address(RVA = "0xA00228", Offset = "0xA00228", VA = "0xA00228")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000858")]
		[Address(RVA = "0xA003C4", Offset = "0xA003C4", VA = "0xA003C4")]
		private static int GetHashCode(Type type, string trackName)
		{
			return default(int);
		}

		[Token(Token = "0x6000859")]
		[Address(RVA = "0xA00424", Offset = "0xA00424", VA = "0xA00424")]
		private static int CombineHashCodes(int h1, int h2)
		{
			return default(int);
		}

		[Token(Token = "0x600085A")]
		[Address(RVA = "0xA00430", Offset = "0xA00430", VA = "0xA00430")]
		public RhythmEventProvider()
		{
		}
	}
	[Token(Token = "0x200017D")]
	[RequireComponent(typeof(AudioSource))]
	public class RhythmPlayer : MonoBehaviour
	{
		[Token(Token = "0x4000A5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AudioSource <audioSource>k__BackingField;

		[Token(Token = "0x4000A5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <prevTime>k__BackingField;

		[Token(Token = "0x4000A5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public RhythmData rhythmData;

		[Token(Token = "0x4000A60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public List<RhythmTarget> targets;

		[Token(Token = "0x4000A61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float _time;

		[Token(Token = "0x170000A5")]
		public AudioSource audioSource
		{
			[Token(Token = "0x6000867")]
			[Address(RVA = "0xA00738", Offset = "0xA00738", VA = "0xA00738")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000868")]
			[Address(RVA = "0xA00740", Offset = "0xA00740", VA = "0xA00740")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A6")]
		public AudioClip audioClip
		{
			[Token(Token = "0x6000869")]
			[Address(RVA = "0xA00748", Offset = "0xA00748", VA = "0xA00748")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A7")]
		public float time
		{
			[Token(Token = "0x600086A")]
			[Address(RVA = "0xA007C8", Offset = "0xA007C8", VA = "0xA007C8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600086B")]
			[Address(RVA = "0xA007D0", Offset = "0xA007D0", VA = "0xA007D0")]
			set
			{
			}
		}

		[Token(Token = "0x170000A8")]
		public float volume
		{
			[Token(Token = "0x600086C")]
			[Address(RVA = "0xA007F4", Offset = "0xA007F4", VA = "0xA007F4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600086D")]
			[Address(RVA = "0xA00810", Offset = "0xA00810", VA = "0xA00810")]
			set
			{
			}
		}

		[Token(Token = "0x170000A9")]
		public float pitch
		{
			[Token(Token = "0x600086E")]
			[Address(RVA = "0xA0082C", Offset = "0xA0082C", VA = "0xA0082C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600086F")]
			[Address(RVA = "0xA00848", Offset = "0xA00848", VA = "0xA00848")]
			set
			{
			}
		}

		[Token(Token = "0x170000AA")]
		public bool isPlaying
		{
			[Token(Token = "0x6000870")]
			[Address(RVA = "0xA00864", Offset = "0xA00864", VA = "0xA00864")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000AB")]
		public float prevTime
		{
			[Token(Token = "0x6000871")]
			[Address(RVA = "0xA00880", Offset = "0xA00880", VA = "0xA00880")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000872")]
			[Address(RVA = "0xA00888", Offset = "0xA00888", VA = "0xA00888")]
			private set
			{
			}
		}

		[Token(Token = "0x14000013")]
		public event Action SongEnded
		{
			[Token(Token = "0x6000863")]
			[Address(RVA = "0xA004C8", Offset = "0xA004C8", VA = "0xA004C8")]
			add
			{
			}
			[Token(Token = "0x6000864")]
			[Address(RVA = "0xA00564", Offset = "0xA00564", VA = "0xA00564")]
			remove
			{
			}
		}

		[Token(Token = "0x14000014")]
		public event Action Reset
		{
			[Token(Token = "0x6000865")]
			[Address(RVA = "0xA00600", Offset = "0xA00600", VA = "0xA00600")]
			add
			{
			}
			[Token(Token = "0x6000866")]
			[Address(RVA = "0xA0069C", Offset = "0xA0069C", VA = "0xA0069C")]
			remove
			{
			}
		}

		[Token(Token = "0x6000873")]
		[Address(RVA = "0xA00890", Offset = "0xA00890", VA = "0xA00890")]
		public void Play()
		{
		}

		[Token(Token = "0x6000874")]
		[Address(RVA = "0xA00B24", Offset = "0xA00B24", VA = "0xA00B24")]
		public void Stop()
		{
		}

		[Token(Token = "0x6000875")]
		[Address(RVA = "0xA00B40", Offset = "0xA00B40", VA = "0xA00B40")]
		public void Pause()
		{
		}

		[Token(Token = "0x6000876")]
		[Address(RVA = "0xA00B5C", Offset = "0xA00B5C", VA = "0xA00B5C")]
		public void UnPause()
		{
		}

		[Token(Token = "0x6000877")]
		[Address(RVA = "0xA00B78", Offset = "0xA00B78", VA = "0xA00B78")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000878")]
		[Address(RVA = "0xA00BD0", Offset = "0xA00BD0", VA = "0xA00BD0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000879")]
		[Address(RVA = "0xA00EE0", Offset = "0xA00EE0", VA = "0xA00EE0")]
		private void OnSongEnded()
		{
		}

		[Token(Token = "0x600087A")]
		[Address(RVA = "0xA00960", Offset = "0xA00960", VA = "0xA00960")]
		private void OnReset()
		{
		}

		[Token(Token = "0x600087B")]
		[Address(RVA = "0xA00EFC", Offset = "0xA00EFC", VA = "0xA00EFC")]
		public RhythmPlayer()
		{
		}
	}
	[Token(Token = "0x200017E")]
	public abstract class RhythmTarget : ScriptableObject
	{
		[Token(Token = "0x600087C")]
		public abstract void Process(RhythmData rhythmData, float start, float end);

		[Token(Token = "0x600087D")]
		public abstract void Reset(RhythmData rhythmData, float time);

		[Token(Token = "0x600087E")]
		[Address(RVA = "0xA004B8", Offset = "0xA004B8", VA = "0xA004B8")]
		protected RhythmTarget()
		{
		}
	}
	[Token(Token = "0x200017F")]
	public class Segmenter : Analysis<Value>
	{
		[Token(Token = "0x4000A62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Range(0f, 64f)]
		public float threshold;

		[Token(Token = "0x4000A63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Range(1f, 16f)]
		public int smoothing;

		[Token(Token = "0x4000A64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector2 changeWeight;

		[Token(Token = "0x4000A65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float changeStartSlope;

		[Token(Token = "0x4000A66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float changeEndSlope;

		[Token(Token = "0x4000A67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int iterations;

		[Token(Token = "0x4000A68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int bufferSize;

		[Token(Token = "0x4000A69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float[][] buffer;

		[Token(Token = "0x4000A6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float[] kernel;

		[Token(Token = "0x4000A6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float w;

		[Token(Token = "0x4000A6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float current;

		[Token(Token = "0x4000A6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float next;

		[Token(Token = "0x4000A6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private bool change;

		[Token(Token = "0x4000A6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float changeSign;

		[Token(Token = "0x4000A70")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector2 changeStart;

		[Token(Token = "0x4000A71")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float maxSlope;

		[Token(Token = "0x4000A72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int maxSlopeIndex;

		[Token(Token = "0x170000AC")]
		public override string name
		{
			[Token(Token = "0x600087F")]
			[Address(RVA = "0xA00F04", Offset = "0xA00F04", VA = "0xA00F04", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000880")]
		[Address(RVA = "0xA00F44", Offset = "0xA00F44", VA = "0xA00F44", Slot = "5")]
		public override void Initialize(int sampleRate, int frameSize, int hopSize)
		{
		}

		[Token(Token = "0x6000881")]
		[Address(RVA = "0xA01120", Offset = "0xA01120", VA = "0xA01120", Slot = "6")]
		public override void Process(float[] samples, float[] magnitude, int frameIndex)
		{
		}

		[Token(Token = "0x6000882")]
		[Address(RVA = "0xA013E0", Offset = "0xA013E0", VA = "0xA013E0")]
		private void FindSegments()
		{
		}

		[Token(Token = "0x6000883")]
		[Address(RVA = "0xA01440", Offset = "0xA01440", VA = "0xA01440")]
		private void FindChangeEnd(float slope)
		{
		}

		[Token(Token = "0x6000884")]
		[Address(RVA = "0xA015BC", Offset = "0xA015BC", VA = "0xA015BC")]
		private void FindChangeStart(float slope)
		{
		}

		[Token(Token = "0x6000885")]
		[Address(RVA = "0xA01628", Offset = "0xA01628", VA = "0xA01628")]
		public Segmenter()
		{
		}
	}
	[Token(Token = "0x2000180")]
	public abstract class Track : ScriptableObject
	{
		[Token(Token = "0x4000A73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected string _name;

		[Token(Token = "0x170000AD")]
		public new string name
		{
			[Token(Token = "0x6000886")]
			[Address(RVA = "0xA016A0", Offset = "0xA016A0", VA = "0xA016A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000887")]
		[Address(RVA = "0xA016A8", Offset = "0xA016A8", VA = "0xA016A8")]
		protected Track()
		{
		}
	}
	[Token(Token = "0x2000181")]
	public abstract class Track<T> : Track where T : Feature
	{
		[Serializable]
		[Token(Token = "0x2000182")]
		private sealed class <>c
		{
			[Token(Token = "0x4000A78")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000A79")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static Comparison<T> <>9__11_0;

			[Token(Token = "0x6000899")]
			public <>c()
			{
			}

			[Token(Token = "0x600089A")]
			internal int <Sort>b__11_0(T a, T b)
			{
				return default(int);
			}
		}

		[Token(Token = "0x4000A74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private List<T> _features;

		[NonSerialized]
		[Token(Token = "0x4000A75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private List<int> cachedTimestamps;

		[Token(Token = "0x4000A76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Dictionary<int, int> cachedIndices;

		[Token(Token = "0x4000A77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Type concreteType;

		[Token(Token = "0x170000AE")]
		public T this[int index]
		{
			[Token(Token = "0x6000888")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AF")]
		public int count
		{
			[Token(Token = "0x6000889")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600088A")]
		static Track()
		{
		}

		[Token(Token = "0x600088B")]
		public void Add(T feature)
		{
		}

		[Token(Token = "0x600088C")]
		public void Remove(T feature)
		{
		}

		[Token(Token = "0x600088D")]
		public void Sort()
		{
		}

		[Token(Token = "0x600088E")]
		public void GetFeatures(List<T> features, float start, float end)
		{
		}

		[Token(Token = "0x600088F")]
		public void GetIntersectingFeatures(List<T> features, float start, float end)
		{
		}

		[Token(Token = "0x6000890")]
		public int GetIndex(float timestamp)
		{
			return default(int);
		}

		[Token(Token = "0x6000891")]
		public int GetIndex(T feature)
		{
			return default(int);
		}

		[Token(Token = "0x6000892")]
		public int GetIntersectingIndex(float timestamp)
		{
			return default(int);
		}

		[Token(Token = "0x6000893")]
		private int BinarySearch(float timestamp)
		{
			return default(int);
		}

		[Token(Token = "0x6000894")]
		private int GetCacheIndex(float timestamp)
		{
			return default(int);
		}

		[Token(Token = "0x6000895")]
		private void ClearCache(float timestamp)
		{
		}

		[Token(Token = "0x6000896")]
		public static Track<T> Create(string name)
		{
			return null;
		}

		[Token(Token = "0x6000897")]
		protected Track()
		{
		}
	}
	[Token(Token = "0x2000183")]
	public class Util
	{
		[Token(Token = "0x4000A7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static LomontFFT fft;

		[Token(Token = "0x600089B")]
		[Address(RVA = "0x9FF4C4", Offset = "0x9FF4C4", VA = "0x9FF4C4")]
		public static void GetMono(float[] samples, float[] monoSamples, int channels = 0)
		{
		}

		[Token(Token = "0x600089C")]
		[Address(RVA = "0x9FCEEC", Offset = "0x9FCEEC", VA = "0x9FCEEC")]
		public static void GetSpectrum(float[] samples)
		{
		}

		[Token(Token = "0x600089D")]
		[Address(RVA = "0x9FCF58", Offset = "0x9FCF58", VA = "0x9FCF58")]
		public static void GetSpectrumMagnitude(float[] spectrum, float[] magnitude)
		{
		}

		[Token(Token = "0x600089E")]
		[Address(RVA = "0x9FCE80", Offset = "0x9FCE80", VA = "0x9FCE80")]
		internal static void ApplyWindow(float[] array, float[] window)
		{
		}

		[Token(Token = "0x600089F")]
		[Address(RVA = "0x9FD098", Offset = "0x9FD098", VA = "0x9FD098")]
		public static float Mean(float[] array, int start = 0, int end = 0)
		{
			return default(float);
		}

		[Token(Token = "0x60008A0")]
		[Address(RVA = "0xA0133C", Offset = "0xA0133C", VA = "0xA0133C")]
		public static float WeightedSum(float[] array, float[] kernel, int index)
		{
			return default(float);
		}

		[Token(Token = "0x60008A1")]
		[Address(RVA = "0x9FBF0C", Offset = "0x9FBF0C", VA = "0x9FBF0C")]
		public static int MaxIndex(float[] array, int start = 0, int end = 0)
		{
			return default(int);
		}

		[Token(Token = "0x60008A2")]
		[Address(RVA = "0x9FC2D4", Offset = "0x9FC2D4", VA = "0x9FC2D4")]
		public static float Max(float[] array, int start = 0, int end = 0)
		{
			return default(float);
		}

		[Token(Token = "0x60008A3")]
		[Address(RVA = "0x9FBDB8", Offset = "0x9FBDB8", VA = "0x9FBDB8")]
		public static void Smooth(float[] array, float[] smoothedArray, float[] kernel)
		{
		}

		[Token(Token = "0x60008A4")]
		[Address(RVA = "0x9FBE84", Offset = "0x9FBE84", VA = "0x9FBE84")]
		public static float Interpolate(float[] array, float index)
		{
			return default(float);
		}

		[Token(Token = "0x60008A5")]
		[Address(RVA = "0xA016B0", Offset = "0xA016B0", VA = "0xA016B0")]
		public static void HannWindow(float[] array)
		{
		}

		[Token(Token = "0x60008A6")]
		[Address(RVA = "0x9FC830", Offset = "0x9FC830", VA = "0x9FC830")]
		public static float[] HannWindow(int length)
		{
			return null;
		}

		[Token(Token = "0x60008A7")]
		[Address(RVA = "0x9FB3CC", Offset = "0x9FB3CC", VA = "0x9FB3CC")]
		public static float HannWindow(int n, int windowSize)
		{
			return default(float);
		}
	}
	[Token(Token = "0x2000184")]
	public class ValueTrack : Track<Value>
	{
		[Token(Token = "0x60008A9")]
		[Address(RVA = "0xA0180C", Offset = "0xA0180C", VA = "0xA0180C")]
		public ValueTrack()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000185")]
	public class Value : Feature
	{
		[Token(Token = "0x4000A7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float value;

		[Token(Token = "0x60008AA")]
		[Address(RVA = "0xA01620", Offset = "0xA01620", VA = "0xA01620")]
		public Value()
		{
		}
	}
	[Token(Token = "0x2000186")]
	public class VolumeSampler : Analysis<Value>
	{
		[Token(Token = "0x4000A7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Range(1f, 64f)]
		private int _interval;

		[Token(Token = "0x4000A7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Range(0f, 16f)]
		[SerializeField]
		private int _smoothing;

		[Token(Token = "0x4000A7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int bufferSize;

		[Token(Token = "0x4000A7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int smoothingBufferSize;

		[Token(Token = "0x4000A80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float[] buffer;

		[Token(Token = "0x4000A81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float[] smoothingBuffer;

		[Token(Token = "0x4000A82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float[] smoothingKernel;

		[Token(Token = "0x4000A83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float w;

		[Token(Token = "0x170000B0")]
		public override string name
		{
			[Token(Token = "0x60008AB")]
			[Address(RVA = "0xA01878", Offset = "0xA01878", VA = "0xA01878", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B1")]
		public int interval
		{
			[Token(Token = "0x60008AC")]
			[Address(RVA = "0xA018B8", Offset = "0xA018B8", VA = "0xA018B8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60008AD")]
			[Address(RVA = "0xA018C0", Offset = "0xA018C0", VA = "0xA018C0")]
			set
			{
			}
		}

		[Token(Token = "0x170000B2")]
		public int smoothing
		{
			[Token(Token = "0x60008AE")]
			[Address(RVA = "0xA018DC", Offset = "0xA018DC", VA = "0xA018DC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60008AF")]
			[Address(RVA = "0xA018E4", Offset = "0xA018E4", VA = "0xA018E4")]
			set
			{
			}
		}

		[Token(Token = "0x60008B0")]
		[Address(RVA = "0xA018FC", Offset = "0xA018FC", VA = "0xA018FC", Slot = "5")]
		public override void Initialize(int sampleRate, int frameSize, int hopSize)
		{
		}

		[Token(Token = "0x60008B1")]
		[Address(RVA = "0xA01A70", Offset = "0xA01A70", VA = "0xA01A70", Slot = "6")]
		public override void Process(float[] samples, float[] magnitude, int frameIndex)
		{
		}

		[Token(Token = "0x60008B2")]
		[Address(RVA = "0xA01C88", Offset = "0xA01C88", VA = "0xA01C88")]
		public VolumeSampler()
		{
		}
	}
}
namespace RhythmTool.Examples
{
	[Token(Token = "0x2000187")]
	public abstract class SongSelector : MonoBehaviour
	{
		[Token(Token = "0x4000A84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RhythmAnalyzer analyzer;

		[Token(Token = "0x4000A85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RhythmPlayer player;

		[Token(Token = "0x60008B3")]
		[Address(RVA = "0xA01CDC", Offset = "0xA01CDC", VA = "0xA01CDC", Slot = "4")]
		public virtual void NextSong()
		{
		}

		[Token(Token = "0x60008B4")]
		[Address(RVA = "0xA01D00", Offset = "0xA01D00", VA = "0xA01D00")]
		protected SongSelector()
		{
		}
	}
	[Token(Token = "0x2000188")]
	public class AudioClipSelector : SongSelector
	{
		[Token(Token = "0x4000A86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<AudioClip> songs;

		[Token(Token = "0x4000A87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int currentSong;

		[Token(Token = "0x60008B5")]
		[Address(RVA = "0xA01D08", Offset = "0xA01D08", VA = "0xA01D08")]
		private void Start()
		{
		}

		[Token(Token = "0x60008B6")]
		[Address(RVA = "0xA01D14", Offset = "0xA01D14", VA = "0xA01D14", Slot = "4")]
		public override void NextSong()
		{
		}

		[Token(Token = "0x60008B7")]
		[Address(RVA = "0xA01E04", Offset = "0xA01E04", VA = "0xA01E04")]
		public AudioClipSelector()
		{
		}
	}
	[Token(Token = "0x2000189")]
	public class Line : MonoBehaviour
	{
		[Token(Token = "0x4000A88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float <timestamp>k__BackingField;

		[Token(Token = "0x170000B3")]
		public float timestamp
		{
			[Token(Token = "0x60008B8")]
			[Address(RVA = "0xA01E14", Offset = "0xA01E14", VA = "0xA01E14")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60008B9")]
			[Address(RVA = "0xA01E1C", Offset = "0xA01E1C", VA = "0xA01E1C")]
			private set
			{
			}
		}

		[Token(Token = "0x60008BA")]
		[Address(RVA = "0xA01E24", Offset = "0xA01E24", VA = "0xA01E24")]
		public void Init(Color color, float opacity, float timestamp)
		{
		}

		[Token(Token = "0x60008BB")]
		[Address(RVA = "0xA01F08", Offset = "0xA01F08", VA = "0xA01F08")]
		public Line()
		{
		}
	}
	[Token(Token = "0x200018A")]
	public class Visualizer : MonoBehaviour
	{
		[Token(Token = "0x4000A89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RhythmAnalyzer analyzer;

		[Token(Token = "0x4000A8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RhythmPlayer player;

		[Token(Token = "0x4000A8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RhythmEventProvider eventProvider;

		[Token(Token = "0x4000A8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Text textBPM;

		[Token(Token = "0x4000A8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Line linePrefab;

		[Token(Token = "0x4000A8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<Line> lines;

		[Token(Token = "0x4000A8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<Chroma> chromaFeatures;

		[Token(Token = "0x4000A90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Note lastNote;

		[Token(Token = "0x60008BC")]
		[Address(RVA = "0xA01F10", Offset = "0xA01F10", VA = "0xA01F10")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008BD")]
		[Address(RVA = "0xA02210", Offset = "0xA02210", VA = "0xA02210")]
		private void Update()
		{
		}

		[Token(Token = "0x60008BE")]
		[Address(RVA = "0xA0224C", Offset = "0xA0224C", VA = "0xA0224C")]
		private void UpdateLines()
		{
		}

		[Token(Token = "0x60008BF")]
		[Address(RVA = "0xA026D8", Offset = "0xA026D8", VA = "0xA026D8")]
		private void OnInitialized(RhythmData rhythmData)
		{
		}

		[Token(Token = "0x60008C0")]
		[Address(RVA = "0xA026F0", Offset = "0xA026F0", VA = "0xA026F0")]
		private void OnReset()
		{
		}

		[Token(Token = "0x60008C1")]
		[Address(RVA = "0xA028A8", Offset = "0xA028A8", VA = "0xA028A8")]
		private void OnBeat(Beat beat)
		{
		}

		[Token(Token = "0x60008C2")]
		[Address(RVA = "0xA02BE4", Offset = "0xA02BE4", VA = "0xA02BE4")]
		private void OnOnset(Onset onset)
		{
		}

		[Token(Token = "0x60008C3")]
		[Address(RVA = "0xA02EB8", Offset = "0xA02EB8", VA = "0xA02EB8")]
		private void OnSegment(Value segment)
		{
		}

		[Token(Token = "0x60008C4")]
		[Address(RVA = "0xA02A2C", Offset = "0xA02A2C", VA = "0xA02A2C")]
		private void CreateLine(float timestamp, float position, float scale, Color color, float opacity)
		{
		}

		[Token(Token = "0x60008C5")]
		[Address(RVA = "0xA02EF4", Offset = "0xA02EF4", VA = "0xA02EF4")]
		public Visualizer()
		{
		}
	}
}
namespace OculusSampleFramework
{
	[Token(Token = "0x200018B")]
	public class ColorGrabbable : OVRGrabbable
	{
		[Token(Token = "0x4000A91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Color COLOR_GRAB;

		[Token(Token = "0x4000A92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly Color COLOR_HIGHLIGHT;

		[Token(Token = "0x4000A93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Color m_color;

		[Token(Token = "0x4000A94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private MeshRenderer[] m_meshRenderers;

		[Token(Token = "0x4000A95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool m_highlight;

		[Token(Token = "0x170000B4")]
		public bool Highlight
		{
			[Token(Token = "0x60008C6")]
			[Address(RVA = "0xA02F04", Offset = "0xA02F04", VA = "0xA02F04")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008C7")]
			[Address(RVA = "0xA02F0C", Offset = "0xA02F0C", VA = "0xA02F0C")]
			set
			{
			}
		}

		[Token(Token = "0x60008C8")]
		[Address(RVA = "0xA02F18", Offset = "0xA02F18", VA = "0xA02F18")]
		protected void UpdateColor()
		{
		}

		[Token(Token = "0x60008C9")]
		[Address(RVA = "0xA030B8", Offset = "0xA030B8", VA = "0xA030B8", Slot = "4")]
		public override void GrabBegin(OVRGrabber hand, Collider grabPoint)
		{
		}

		[Token(Token = "0x60008CA")]
		[Address(RVA = "0xA030D4", Offset = "0xA030D4", VA = "0xA030D4", Slot = "5")]
		public override void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
		{
		}

		[Token(Token = "0x60008CB")]
		[Address(RVA = "0xA030F0", Offset = "0xA030F0", VA = "0xA030F0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008CC")]
		[Address(RVA = "0xA02FC4", Offset = "0xA02FC4", VA = "0xA02FC4")]
		private void SetColor(Color color)
		{
		}

		[Token(Token = "0x60008CD")]
		[Address(RVA = "0xA033A4", Offset = "0xA033A4", VA = "0xA033A4")]
		public ColorGrabbable()
		{
		}
	}
	[Token(Token = "0x200018C")]
	public class DistanceGrabbable : OVRGrabbable
	{
		[Token(Token = "0x4000A96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string m_materialColorField;

		[Token(Token = "0x4000A97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private GrabbableCrosshair m_crosshair;

		[Token(Token = "0x4000A98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private GrabManager m_crosshairManager;

		[Token(Token = "0x4000A99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Renderer m_renderer;

		[Token(Token = "0x4000A9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private MaterialPropertyBlock m_mpb;

		[Token(Token = "0x4000A9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool m_inRange;

		[Token(Token = "0x4000A9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		private bool m_targeted;

		[Token(Token = "0x170000B5")]
		public bool InRange
		{
			[Token(Token = "0x60008CF")]
			[Address(RVA = "0xA0341C", Offset = "0xA0341C", VA = "0xA0341C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008D0")]
			[Address(RVA = "0xA03424", Offset = "0xA03424", VA = "0xA03424")]
			set
			{
			}
		}

		[Token(Token = "0x170000B6")]
		public bool Targeted
		{
			[Token(Token = "0x60008D1")]
			[Address(RVA = "0xA03594", Offset = "0xA03594", VA = "0xA03594")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008D2")]
			[Address(RVA = "0xA0359C", Offset = "0xA0359C", VA = "0xA0359C")]
			set
			{
			}
		}

		[Token(Token = "0x60008D3")]
		[Address(RVA = "0xA035A8", Offset = "0xA035A8", VA = "0xA035A8", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60008D4")]
		[Address(RVA = "0xA03430", Offset = "0xA03430", VA = "0xA03430")]
		private void RefreshCrosshair()
		{
		}

		[Token(Token = "0x60008D5")]
		[Address(RVA = "0xA0370C", Offset = "0xA0370C", VA = "0xA0370C")]
		public DistanceGrabbable()
		{
		}
	}
	[Token(Token = "0x200018D")]
	[RequireComponent(typeof(Rigidbody))]
	public class DistanceGrabber : OVRGrabber
	{
		[Token(Token = "0x4000A9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[SerializeField]
		private float m_spherecastRadius;

		[Token(Token = "0x4000A9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private float m_noSnapThreshhold;

		[Token(Token = "0x4000A9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[SerializeField]
		private bool m_useSpherecast;

		[Token(Token = "0x4000AA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCD")]
		[SerializeField]
		public bool m_preventGrabThroughWalls;

		[Token(Token = "0x4000AA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private float m_objectPullVelocity;

		[Token(Token = "0x4000AA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private float m_objectPullMaxRotationRate;

		[Token(Token = "0x4000AA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool m_movingObjectToHand;

		[Token(Token = "0x4000AA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[SerializeField]
		private float m_maxGrabDistance;

		[Token(Token = "0x4000AA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private int m_grabObjectsInLayer;

		[Token(Token = "0x4000AA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[SerializeField]
		private int m_obstructionLayer;

		[Token(Token = "0x4000AA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private DistanceGrabber m_otherHand;

		[Token(Token = "0x4000AA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		protected DistanceGrabbable m_target;

		[Token(Token = "0x4000AA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		protected Collider m_targetCollider;

		[Token(Token = "0x170000B7")]
		public bool UseSpherecast
		{
			[Token(Token = "0x60008D6")]
			[Address(RVA = "0xA03714", Offset = "0xA03714", VA = "0xA03714")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008D7")]
			[Address(RVA = "0xA0371C", Offset = "0xA0371C", VA = "0xA0371C")]
			set
			{
			}
		}

		[Token(Token = "0x60008D8")]
		[Address(RVA = "0xA03738", Offset = "0xA03738", VA = "0xA03738", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60008D9")]
		[Address(RVA = "0xA03944", Offset = "0xA03944", VA = "0xA03944", Slot = "6")]
		public override void Update()
		{
		}

		[Token(Token = "0x60008DA")]
		[Address(RVA = "0xA04230", Offset = "0xA04230", VA = "0xA04230", Slot = "7")]
		protected override void GrabBegin()
		{
		}

		[Token(Token = "0x60008DB")]
		[Address(RVA = "0xA04798", Offset = "0xA04798", VA = "0xA04798", Slot = "8")]
		protected override void MoveGrabbedObject(Vector3 pos, Quaternion rot, bool forceTeleport = false)
		{
		}

		[Token(Token = "0x60008DC")]
		[Address(RVA = "0xA04BA8", Offset = "0xA04BA8", VA = "0xA04BA8")]
		private static DistanceGrabbable HitInfoToGrabbable(RaycastHit hitInfo)
		{
			return null;
		}

		[Token(Token = "0x60008DD")]
		[Address(RVA = "0xA03B6C", Offset = "0xA03B6C", VA = "0xA03B6C")]
		protected bool FindTarget(out DistanceGrabbable dgOut, out Collider collOut)
		{
			return default(bool);
		}

		[Token(Token = "0x60008DE")]
		[Address(RVA = "0xA04C94", Offset = "0xA04C94", VA = "0xA04C94")]
		protected bool FindTargetWithSpherecast(out DistanceGrabbable dgOut, out Collider collOut)
		{
			return default(bool);
		}

		[Token(Token = "0x60008DF")]
		[Address(RVA = "0xA05094", Offset = "0xA05094", VA = "0xA05094", Slot = "9")]
		protected override void GrabVolumeEnable(bool enabled)
		{
		}

		[Token(Token = "0x60008E0")]
		[Address(RVA = "0xA050AC", Offset = "0xA050AC", VA = "0xA050AC", Slot = "10")]
		protected override void OffhandGrabbed(OVRGrabbable grabbable)
		{
		}

		[Token(Token = "0x60008E1")]
		[Address(RVA = "0xA050B4", Offset = "0xA050B4", VA = "0xA050B4")]
		public DistanceGrabber()
		{
		}
	}
	[Token(Token = "0x200018E")]
	public class GrabbableCrosshair : MonoBehaviour
	{
		[Token(Token = "0x200018F")]
		public enum CrosshairState
		{
			[Token(Token = "0x4000AAF")]
			Disabled,
			[Token(Token = "0x4000AB0")]
			Enabled,
			[Token(Token = "0x4000AB1")]
			Targeted
		}

		[Token(Token = "0x4000AAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CrosshairState m_state;

		[Token(Token = "0x4000AAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform m_centerEyeAnchor;

		[Token(Token = "0x4000AAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject m_targetedCrosshair;

		[Token(Token = "0x4000AAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject m_enabledCrosshair;

		[Token(Token = "0x60008E2")]
		[Address(RVA = "0xA050D4", Offset = "0xA050D4", VA = "0xA050D4")]
		private void Start()
		{
		}

		[Token(Token = "0x60008E3")]
		[Address(RVA = "0xA0513C", Offset = "0xA0513C", VA = "0xA0513C")]
		public void SetState(CrosshairState cs)
		{
		}

		[Token(Token = "0x60008E4")]
		[Address(RVA = "0xA051C8", Offset = "0xA051C8", VA = "0xA051C8")]
		private void Update()
		{
		}

		[Token(Token = "0x60008E5")]
		[Address(RVA = "0xA05200", Offset = "0xA05200", VA = "0xA05200")]
		public GrabbableCrosshair()
		{
		}
	}
	[Token(Token = "0x2000190")]
	public class GrabManager : MonoBehaviour
	{
		[Token(Token = "0x4000AB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Collider m_grabVolume;

		[Token(Token = "0x4000AB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color OutlineColorInRange;

		[Token(Token = "0x4000AB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Color OutlineColorHighlighted;

		[Token(Token = "0x4000AB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Color OutlineColorOutOfRange;

		[Token(Token = "0x60008E6")]
		[Address(RVA = "0xA05208", Offset = "0xA05208", VA = "0xA05208")]
		private void OnTriggerEnter(Collider otherCollider)
		{
		}

		[Token(Token = "0x60008E7")]
		[Address(RVA = "0xA052B4", Offset = "0xA052B4", VA = "0xA052B4")]
		private void OnTriggerExit(Collider otherCollider)
		{
		}

		[Token(Token = "0x60008E8")]
		[Address(RVA = "0xA05360", Offset = "0xA05360", VA = "0xA05360")]
		public GrabManager()
		{
		}
	}
	[Token(Token = "0x2000191")]
	public class PauseOnInputLoss : MonoBehaviour
	{
		[Token(Token = "0x60008E9")]
		[Address(RVA = "0xA05368", Offset = "0xA05368", VA = "0xA05368")]
		private void Start()
		{
		}

		[Token(Token = "0x60008EA")]
		[Address(RVA = "0xA05454", Offset = "0xA05454", VA = "0xA05454")]
		private void OnInputFocusLost()
		{
		}

		[Token(Token = "0x60008EB")]
		[Address(RVA = "0xA05460", Offset = "0xA05460", VA = "0xA05460")]
		private void OnInputFocusAcquired()
		{
		}

		[Token(Token = "0x60008EC")]
		[Address(RVA = "0xA0546C", Offset = "0xA0546C", VA = "0xA0546C")]
		public PauseOnInputLoss()
		{
		}
	}
	[Token(Token = "0x2000192")]
	public class BoneCapsuleTriggerLogic : MonoBehaviour
	{
		[Token(Token = "0x4000AB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractableToolTags ToolTags;

		[Token(Token = "0x4000AB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HashSet<ColliderZone> CollidersTouchingUs;

		[Token(Token = "0x4000AB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<ColliderZone> _elementsToCleanUp;

		[Token(Token = "0x60008ED")]
		[Address(RVA = "0xA05474", Offset = "0xA05474", VA = "0xA05474")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60008EE")]
		[Address(RVA = "0xA054C4", Offset = "0xA054C4", VA = "0xA054C4")]
		private void Update()
		{
		}

		[Token(Token = "0x60008EF")]
		[Address(RVA = "0xA0589C", Offset = "0xA0589C", VA = "0xA0589C")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60008F0")]
		[Address(RVA = "0xA05988", Offset = "0xA05988", VA = "0xA05988")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x60008F1")]
		[Address(RVA = "0xA054C8", Offset = "0xA054C8", VA = "0xA054C8")]
		private void CleanUpDeadColliders()
		{
		}

		[Token(Token = "0x60008F2")]
		[Address(RVA = "0xA05A74", Offset = "0xA05A74", VA = "0xA05A74")]
		public BoneCapsuleTriggerLogic()
		{
		}
	}
	[Token(Token = "0x2000193")]
	public class ButtonController : Interactable
	{
		[Token(Token = "0x2000194")]
		public enum ContactTest
		{
			[Token(Token = "0x4000AC8")]
			PerpenTest,
			[Token(Token = "0x4000AC9")]
			BackwardsPress
		}

		[Token(Token = "0x4000AB9")]
		private const float ENTRY_DOT_THRESHOLD = 0.8f;

		[Token(Token = "0x4000ABA")]
		private const float PERP_DOT_THRESHOLD = 0.5f;

		[Token(Token = "0x4000ABB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _proximityZone;

		[Token(Token = "0x4000ABC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _contactZone;

		[Token(Token = "0x4000ABD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _actionZone;

		[Token(Token = "0x4000ABE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private ContactTest[] _contactTests;

		[Token(Token = "0x4000ABF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform _buttonPlaneCenter;

		[Token(Token = "0x4000AC0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private bool _makeSureToolIsOnPositiveSide;

		[Token(Token = "0x4000AC1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private Vector3 _localButtonDirection;

		[Token(Token = "0x4000AC2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private InteractableToolTags[] _allValidToolsTags;

		[Token(Token = "0x4000AC3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int _toolTagsMask;

		[Token(Token = "0x4000AC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[SerializeField]
		private bool _allowMultipleNearFieldInteraction;

		[Token(Token = "0x4000AC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private InteractableState <CurrentButtonState>k__BackingField;

		[Token(Token = "0x4000AC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Dictionary<InteractableTool, InteractableState> _toolToState;

		[Token(Token = "0x170000B8")]
		public override int ValidToolTagsMask
		{
			[Token(Token = "0x60008F3")]
			[Address(RVA = "0xA05B4C", Offset = "0xA05B4C", VA = "0xA05B4C", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000B9")]
		public Vector3 LocalButtonDirection
		{
			[Token(Token = "0x60008F4")]
			[Address(RVA = "0xA05B54", Offset = "0xA05B54", VA = "0xA05B54")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000BA")]
		public InteractableState CurrentButtonState
		{
			[Token(Token = "0x60008F5")]
			[Address(RVA = "0xA05B60", Offset = "0xA05B60", VA = "0xA05B60")]
			get
			{
				return default(InteractableState);
			}
			[Token(Token = "0x60008F6")]
			[Address(RVA = "0xA05B68", Offset = "0xA05B68", VA = "0xA05B68")]
			private set
			{
			}
		}

		[Token(Token = "0x60008F7")]
		[Address(RVA = "0xA05B70", Offset = "0xA05B70", VA = "0xA05B70", Slot = "9")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60008F8")]
		[Address(RVA = "0xA05CC0", Offset = "0xA05CC0", VA = "0xA05CC0")]
		private void FireInteractionEventsOnDepth(InteractableCollisionDepth oldDepth, InteractableTool collidingTool, InteractionType interactionType)
		{
		}

		[Token(Token = "0x60008F9")]
		[Address(RVA = "0xA05EC8", Offset = "0xA05EC8", VA = "0xA05EC8", Slot = "8")]
		public override void UpdateCollisionDepth(InteractableTool interactableTool, InteractableCollisionDepth oldCollisionDepth, InteractableCollisionDepth newCollisionDepth)
		{
		}

		[Token(Token = "0x60008FA")]
		[Address(RVA = "0xA0648C", Offset = "0xA0648C", VA = "0xA0648C")]
		private InteractableState GetUpcomingStateNearField(InteractableState oldState, InteractableCollisionDepth newCollisionDepth, bool toolIsInActionZone, bool toolIsInContactZone, bool toolIsInProximity, bool validContact, bool onPositiveSideOfInteractable)
		{
			return default(InteractableState);
		}

		[Token(Token = "0x60008FB")]
		[Address(RVA = "0xA065F4", Offset = "0xA065F4", VA = "0xA065F4")]
		public void ForceResetButton()
		{
		}

		[Token(Token = "0x60008FC")]
		[Address(RVA = "0xA063B0", Offset = "0xA063B0", VA = "0xA063B0")]
		private bool IsValidContact(InteractableTool collidingTool, Vector3 buttonDirection)
		{
			return default(bool);
		}

		[Token(Token = "0x60008FD")]
		[Address(RVA = "0xA06700", Offset = "0xA06700", VA = "0xA06700")]
		private bool PassEntryTest(InteractableTool collidingTool, Vector3 buttonDirection)
		{
			return default(bool);
		}

		[Token(Token = "0x60008FE")]
		[Address(RVA = "0xA0680C", Offset = "0xA0680C", VA = "0xA0680C")]
		private bool PassPerpTest(InteractableTool collidingTool, Vector3 buttonDirection)
		{
			return default(bool);
		}

		[Token(Token = "0x60008FF")]
		[Address(RVA = "0xA06894", Offset = "0xA06894", VA = "0xA06894")]
		public ButtonController()
		{
		}
	}
	[Token(Token = "0x2000195")]
	public class ButtonTriggerZone : MonoBehaviour, ColliderZone
	{
		[Token(Token = "0x4000ACA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _parentInteractableObj;

		[Token(Token = "0x4000ACB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Collider <Collider>k__BackingField;

		[Token(Token = "0x4000ACC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Interactable <ParentInteractable>k__BackingField;

		[Token(Token = "0x170000BB")]
		public Collider Collider
		{
			[Token(Token = "0x6000900")]
			[Address(RVA = "0xA069B8", Offset = "0xA069B8", VA = "0xA069B8", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000901")]
			[Address(RVA = "0xA069C0", Offset = "0xA069C0", VA = "0xA069C0")]
			private set
			{
			}
		}

		[Token(Token = "0x170000BC")]
		public Interactable ParentInteractable
		{
			[Token(Token = "0x6000902")]
			[Address(RVA = "0xA069C8", Offset = "0xA069C8", VA = "0xA069C8", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000903")]
			[Address(RVA = "0xA069D0", Offset = "0xA069D0", VA = "0xA069D0")]
			private set
			{
			}
		}

		[Token(Token = "0x170000BD")]
		public InteractableCollisionDepth CollisionDepth
		{
			[Token(Token = "0x6000904")]
			[Address(RVA = "0xA069D8", Offset = "0xA069D8", VA = "0xA069D8", Slot = "6")]
			get
			{
				return default(InteractableCollisionDepth);
			}
		}

		[Token(Token = "0x6000905")]
		[Address(RVA = "0xA06A28", Offset = "0xA06A28", VA = "0xA06A28")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000906")]
		[Address(RVA = "0xA06ABC", Offset = "0xA06ABC", VA = "0xA06ABC")]
		public ButtonTriggerZone()
		{
		}
	}
	[Token(Token = "0x2000196")]
	public interface ColliderZone
	{
		[Token(Token = "0x170000BE")]
		Collider Collider
		{
			[Token(Token = "0x6000907")]
			get;
		}

		[Token(Token = "0x170000BF")]
		Interactable ParentInteractable
		{
			[Token(Token = "0x6000908")]
			get;
		}

		[Token(Token = "0x170000C0")]
		InteractableCollisionDepth CollisionDepth
		{
			[Token(Token = "0x6000909")]
			get;
		}
	}
	[Token(Token = "0x2000197")]
	public class ColliderZoneArgs : EventArgs
	{
		[Token(Token = "0x4000ACD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly ColliderZone Collider;

		[Token(Token = "0x4000ACE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly float FrameTime;

		[Token(Token = "0x4000ACF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly InteractableTool CollidingTool;

		[Token(Token = "0x4000AD0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly InteractionType InteractionT;

		[Token(Token = "0x600090A")]
		[Address(RVA = "0xA05E1C", Offset = "0xA05E1C", VA = "0xA05E1C")]
		public ColliderZoneArgs(ColliderZone collider, float frameTime, InteractableTool collidingTool, InteractionType interactionType)
		{
		}
	}
	[Token(Token = "0x2000198")]
	public enum InteractionType
	{
		[Token(Token = "0x4000AD2")]
		Enter,
		[Token(Token = "0x4000AD3")]
		Stay,
		[Token(Token = "0x4000AD4")]
		Exit
	}
	[Token(Token = "0x2000199")]
	public class HandsManager : MonoBehaviour
	{
		[Token(Token = "0x200019A")]
		public enum HandsVisualMode
		{
			[Token(Token = "0x4000AE6")]
			Mesh,
			[Token(Token = "0x4000AE7")]
			Skeleton,
			[Token(Token = "0x4000AE8")]
			Both
		}

		[Token(Token = "0x200019B")]
		private sealed class <FindSkeletonVisualGameObjects>d__52 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000AE9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000AEA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000AEB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public HandsManager <>4__this;

			[Token(Token = "0x170000CC")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600092C")]
				[Address(RVA = "0xA07F1C", Offset = "0xA07F1C", VA = "0xA07F1C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CD")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600092E")]
				[Address(RVA = "0xA07F64", Offset = "0xA07F64", VA = "0xA07F64", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000929")]
			[Address(RVA = "0xA07514", Offset = "0xA07514", VA = "0xA07514")]
			[DebuggerHidden]
			public <FindSkeletonVisualGameObjects>d__52(int <>1__state)
			{
			}

			[Token(Token = "0x600092A")]
			[Address(RVA = "0xA07CFC", Offset = "0xA07CFC", VA = "0xA07CFC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600092B")]
			[Address(RVA = "0xA07D00", Offset = "0xA07D00", VA = "0xA07D00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600092D")]
			[Address(RVA = "0xA07F24", Offset = "0xA07F24", VA = "0xA07F24", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000AD5")]
		private const string SKELETON_VISUALIZER_NAME = "SkeletonRenderer";

		[Token(Token = "0x4000AD6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _leftHand;

		[Token(Token = "0x4000AD7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _rightHand;

		[Token(Token = "0x4000AD8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public HandsVisualMode VisualMode;

		[Token(Token = "0x4000AD9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private OVRHand[] _hand;

		[Token(Token = "0x4000ADA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private OVRSkeleton[] _handSkeleton;

		[Token(Token = "0x4000ADB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private OVRSkeletonRenderer[] _handSkeletonRenderer;

		[Token(Token = "0x4000ADC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private OVRMesh[] _handMesh;

		[Token(Token = "0x4000ADD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private OVRMeshRenderer[] _handMeshRenderer;

		[Token(Token = "0x4000ADE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private SkinnedMeshRenderer _leftMeshRenderer;

		[Token(Token = "0x4000ADF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private SkinnedMeshRenderer _rightMeshRenderer;

		[Token(Token = "0x4000AE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject _leftSkeletonVisual;

		[Token(Token = "0x4000AE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private GameObject _rightSkeletonVisual;

		[Token(Token = "0x4000AE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float _currentHandAlpha;

		[Token(Token = "0x4000AE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int HandAlphaId;

		[Token(Token = "0x4000AE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static HandsManager <Instance>k__BackingField;

		[Token(Token = "0x170000C1")]
		public OVRHand RightHand
		{
			[Token(Token = "0x600090B")]
			[Address(RVA = "0xA06AC4", Offset = "0xA06AC4", VA = "0xA06AC4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600090C")]
			[Address(RVA = "0xA06AF0", Offset = "0xA06AF0", VA = "0xA06AF0")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C2")]
		public OVRSkeleton RightHandSkeleton
		{
			[Token(Token = "0x600090D")]
			[Address(RVA = "0xA06B54", Offset = "0xA06B54", VA = "0xA06B54")]
			get
			{
				return null;
			}
			[Token(Token = "0x600090E")]
			[Address(RVA = "0xA06B80", Offset = "0xA06B80", VA = "0xA06B80")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C3")]
		public OVRSkeletonRenderer RightHandSkeletonRenderer
		{
			[Token(Token = "0x600090F")]
			[Address(RVA = "0xA06BE4", Offset = "0xA06BE4", VA = "0xA06BE4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000910")]
			[Address(RVA = "0xA06C10", Offset = "0xA06C10", VA = "0xA06C10")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C4")]
		public OVRMesh RightHandMesh
		{
			[Token(Token = "0x6000911")]
			[Address(RVA = "0xA06C74", Offset = "0xA06C74", VA = "0xA06C74")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000912")]
			[Address(RVA = "0xA06CA0", Offset = "0xA06CA0", VA = "0xA06CA0")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C5")]
		public OVRMeshRenderer RightHandMeshRenderer
		{
			[Token(Token = "0x6000913")]
			[Address(RVA = "0xA06D04", Offset = "0xA06D04", VA = "0xA06D04")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000914")]
			[Address(RVA = "0xA06D30", Offset = "0xA06D30", VA = "0xA06D30")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C6")]
		public OVRHand LeftHand
		{
			[Token(Token = "0x6000915")]
			[Address(RVA = "0xA06D94", Offset = "0xA06D94", VA = "0xA06D94")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000916")]
			[Address(RVA = "0xA06DBC", Offset = "0xA06DBC", VA = "0xA06DBC")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C7")]
		public OVRSkeleton LeftHandSkeleton
		{
			[Token(Token = "0x6000917")]
			[Address(RVA = "0xA06E1C", Offset = "0xA06E1C", VA = "0xA06E1C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000918")]
			[Address(RVA = "0xA06E44", Offset = "0xA06E44", VA = "0xA06E44")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C8")]
		public OVRSkeletonRenderer LeftHandSkeletonRenderer
		{
			[Token(Token = "0x6000919")]
			[Address(RVA = "0xA06EA4", Offset = "0xA06EA4", VA = "0xA06EA4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600091A")]
			[Address(RVA = "0xA06ECC", Offset = "0xA06ECC", VA = "0xA06ECC")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C9")]
		public OVRMesh LeftHandMesh
		{
			[Token(Token = "0x600091B")]
			[Address(RVA = "0xA06F2C", Offset = "0xA06F2C", VA = "0xA06F2C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600091C")]
			[Address(RVA = "0xA06F54", Offset = "0xA06F54", VA = "0xA06F54")]
			private set
			{
			}
		}

		[Token(Token = "0x170000CA")]
		public OVRMeshRenderer LeftHandMeshRenderer
		{
			[Token(Token = "0x600091D")]
			[Address(RVA = "0xA06FB4", Offset = "0xA06FB4", VA = "0xA06FB4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600091E")]
			[Address(RVA = "0xA06FDC", Offset = "0xA06FDC", VA = "0xA06FDC")]
			private set
			{
			}
		}

		[Token(Token = "0x170000CB")]
		public static HandsManager Instance
		{
			[Token(Token = "0x600091F")]
			[Address(RVA = "0xA0703C", Offset = "0xA0703C", VA = "0xA0703C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000920")]
			[Address(RVA = "0xA07084", Offset = "0xA07084", VA = "0xA07084")]
			private set
			{
			}
		}

		[Token(Token = "0x6000921")]
		[Address(RVA = "0xA070DC", Offset = "0xA070DC", VA = "0xA070DC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000922")]
		[Address(RVA = "0xA07498", Offset = "0xA07498", VA = "0xA07498")]
		private void Update()
		{
		}

		[Token(Token = "0x6000923")]
		[Address(RVA = "0xA07424", Offset = "0xA07424", VA = "0xA07424")]
		private IEnumerator FindSkeletonVisualGameObjects()
		{
			return null;
		}

		[Token(Token = "0x6000924")]
		[Address(RVA = "0xA0753C", Offset = "0xA0753C", VA = "0xA0753C")]
		public void SwitchVisualization()
		{
		}

		[Token(Token = "0x6000925")]
		[Address(RVA = "0xA07600", Offset = "0xA07600", VA = "0xA07600")]
		private void SetToCurrentVisualMode()
		{
		}

		[Token(Token = "0x6000926")]
		[Address(RVA = "0xA077D0", Offset = "0xA077D0", VA = "0xA077D0")]
		public static List<OVRBoneCapsule> GetCapsulesPerBone(OVRSkeleton skeleton, OVRSkeleton.BoneId boneId)
		{
			return null;
		}

		[Token(Token = "0x6000927")]
		[Address(RVA = "0xA07A34", Offset = "0xA07A34", VA = "0xA07A34")]
		public bool IsInitialized()
		{
			return default(bool);
		}

		[Token(Token = "0x6000928")]
		[Address(RVA = "0xA07B94", Offset = "0xA07B94", VA = "0xA07B94")]
		public HandsManager()
		{
		}
	}
	[Token(Token = "0x200019C")]
	public abstract class Interactable : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200019D")]
		public class InteractableStateArgsEvent : UnityEvent<InteractableStateArgs>
		{
			[Token(Token = "0x6000940")]
			[Address(RVA = "0xA085B4", Offset = "0xA085B4", VA = "0xA085B4")]
			public InteractableStateArgsEvent()
			{
			}
		}

		[Token(Token = "0x4000AEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected ColliderZone _proximityZoneCollider;

		[Token(Token = "0x4000AED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected ColliderZone _contactZoneCollider;

		[Token(Token = "0x4000AEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected ColliderZone _actionZoneCollider;

		[Token(Token = "0x4000AF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public InteractableStateArgsEvent InteractableStateChanged;

		[Token(Token = "0x170000CE")]
		public ColliderZone ProximityCollider
		{
			[Token(Token = "0x600092F")]
			[Address(RVA = "0xA07F6C", Offset = "0xA07F6C", VA = "0xA07F6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CF")]
		public ColliderZone ContactCollider
		{
			[Token(Token = "0x6000930")]
			[Address(RVA = "0xA07F74", Offset = "0xA07F74", VA = "0xA07F74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D0")]
		public ColliderZone ActionCollider
		{
			[Token(Token = "0x6000931")]
			[Address(RVA = "0xA07F7C", Offset = "0xA07F7C", VA = "0xA07F7C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D1")]
		public virtual int ValidToolTagsMask
		{
			[Token(Token = "0x6000932")]
			[Address(RVA = "0xA07F84", Offset = "0xA07F84", VA = "0xA07F84", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x14000015")]
		public event Action<ColliderZoneArgs> ProximityZoneEvent
		{
			[Token(Token = "0x6000933")]
			[Address(RVA = "0xA07F8C", Offset = "0xA07F8C", VA = "0xA07F8C")]
			add
			{
			}
			[Token(Token = "0x6000934")]
			[Address(RVA = "0xA0803C", Offset = "0xA0803C", VA = "0xA0803C")]
			remove
			{
			}
		}

		[Token(Token = "0x14000016")]
		public event Action<ColliderZoneArgs> ContactZoneEvent
		{
			[Token(Token = "0x6000936")]
			[Address(RVA = "0xA08108", Offset = "0xA08108", VA = "0xA08108")]
			add
			{
			}
			[Token(Token = "0x6000937")]
			[Address(RVA = "0xA081B8", Offset = "0xA081B8", VA = "0xA081B8")]
			remove
			{
			}
		}

		[Token(Token = "0x14000017")]
		public event Action<ColliderZoneArgs> ActionZoneEvent
		{
			[Token(Token = "0x6000939")]
			[Address(RVA = "0xA08284", Offset = "0xA08284", VA = "0xA08284")]
			add
			{
			}
			[Token(Token = "0x600093A")]
			[Address(RVA = "0xA08334", Offset = "0xA08334", VA = "0xA08334")]
			remove
			{
			}
		}

		[Token(Token = "0x6000935")]
		[Address(RVA = "0xA080EC", Offset = "0xA080EC", VA = "0xA080EC", Slot = "5")]
		protected virtual void OnProximityZoneEvent(ColliderZoneArgs args)
		{
		}

		[Token(Token = "0x6000938")]
		[Address(RVA = "0xA08268", Offset = "0xA08268", VA = "0xA08268", Slot = "6")]
		protected virtual void OnContactZoneEvent(ColliderZoneArgs args)
		{
		}

		[Token(Token = "0x600093B")]
		[Address(RVA = "0xA083E4", Offset = "0xA083E4", VA = "0xA083E4", Slot = "7")]
		protected virtual void OnActionZoneEvent(ColliderZoneArgs args)
		{
		}

		[Token(Token = "0x600093C")]
		public abstract void UpdateCollisionDepth(InteractableTool interactableTool, InteractableCollisionDepth oldCollisionDepth, InteractableCollisionDepth newCollisionDepth);

		[Token(Token = "0x600093D")]
		[Address(RVA = "0xA05C6C", Offset = "0xA05C6C", VA = "0xA05C6C", Slot = "9")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600093E")]
		[Address(RVA = "0xA084B0", Offset = "0xA084B0", VA = "0xA084B0", Slot = "10")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600093F")]
		[Address(RVA = "0xA069B0", Offset = "0xA069B0", VA = "0xA069B0")]
		protected Interactable()
		{
		}
	}
	[Token(Token = "0x200019E")]
	public enum InteractableCollisionDepth
	{
		[Token(Token = "0x4000AF4")]
		None,
		[Token(Token = "0x4000AF5")]
		Proximity,
		[Token(Token = "0x4000AF6")]
		Contact,
		[Token(Token = "0x4000AF7")]
		Action
	}
	[Token(Token = "0x200019F")]
	public enum InteractableState
	{
		[Token(Token = "0x4000AF9")]
		Default,
		[Token(Token = "0x4000AFA")]
		ProximityState,
		[Token(Token = "0x4000AFB")]
		ContactState,
		[Token(Token = "0x4000AFC")]
		ActionState
	}
	[Token(Token = "0x20001A0")]
	public class InteractableStateArgs : EventArgs
	{
		[Token(Token = "0x4000AFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly Interactable Interactable;

		[Token(Token = "0x4000AFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly InteractableTool Tool;

		[Token(Token = "0x4000AFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly InteractableState OldInteractableState;

		[Token(Token = "0x4000B00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public readonly InteractableState NewInteractableState;

		[Token(Token = "0x4000B01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly ColliderZoneArgs ColliderArgs;

		[Token(Token = "0x6000941")]
		[Address(RVA = "0xA0653C", Offset = "0xA0653C", VA = "0xA0653C")]
		public InteractableStateArgs(Interactable interactable, InteractableTool tool, InteractableState newInteractableState, InteractableState oldState, ColliderZoneArgs colliderArgs)
		{
		}
	}
	[Token(Token = "0x20001A1")]
	public class InteractableRegistry : MonoBehaviour
	{
		[Token(Token = "0x4000B02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static HashSet<Interactable> _interactables;

		[Token(Token = "0x170000D2")]
		public static HashSet<Interactable> Interactables
		{
			[Token(Token = "0x6000942")]
			[Address(RVA = "0xA085FC", Offset = "0xA085FC", VA = "0xA085FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000943")]
		[Address(RVA = "0xA08400", Offset = "0xA08400", VA = "0xA08400")]
		public static void RegisterInteractable(Interactable interactable)
		{
		}

		[Token(Token = "0x6000944")]
		[Address(RVA = "0xA08504", Offset = "0xA08504", VA = "0xA08504")]
		public static void UnregisterInteractable(Interactable interactable)
		{
		}

		[Token(Token = "0x6000945")]
		[Address(RVA = "0xA08654", Offset = "0xA08654", VA = "0xA08654")]
		public InteractableRegistry()
		{
		}
	}
	[Token(Token = "0x20001A2")]
	public class InteractableToolsCreator : MonoBehaviour
	{
		[Token(Token = "0x20001A3")]
		private sealed class <AttachToolsToHands>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000B05")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000B06")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000B07")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform[] toolObjects;

			[Token(Token = "0x4000B08")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool isRightHand;

			[Token(Token = "0x4000B09")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public InteractableToolsCreator <>4__this;

			[Token(Token = "0x4000B0A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private HandsManager <handsManagerObj>5__2;

			[Token(Token = "0x4000B0B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private HashSet<Transform>.Enumerator <>7__wrap2;

			[Token(Token = "0x4000B0C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Transform <toolObject>5__4;

			[Token(Token = "0x4000B0D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private OVRSkeleton <handSkeletonToAttachTo>5__5;

			[Token(Token = "0x170000D3")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600094F")]
				[Address(RVA = "0xA08E14", Offset = "0xA08E14", VA = "0xA08E14", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D4")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000951")]
				[Address(RVA = "0xA08E5C", Offset = "0xA08E5C", VA = "0xA08E5C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600094B")]
			[Address(RVA = "0xA087FC", Offset = "0xA087FC", VA = "0xA087FC")]
			[DebuggerHidden]
			public <AttachToolsToHands>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x600094C")]
			[Address(RVA = "0xA08938", Offset = "0xA08938", VA = "0xA08938", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600094D")]
			[Address(RVA = "0xA08954", Offset = "0xA08954", VA = "0xA08954", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600094E")]
			[Address(RVA = "0xA08DC4", Offset = "0xA08DC4", VA = "0xA08DC4")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000950")]
			[Address(RVA = "0xA08E1C", Offset = "0xA08E1C", VA = "0xA08E1C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000B03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform[] LeftHandTools;

		[Token(Token = "0x4000B04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform[] RightHandTools;

		[Token(Token = "0x6000947")]
		[Address(RVA = "0xA086F4", Offset = "0xA086F4", VA = "0xA086F4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000948")]
		[Address(RVA = "0xA08760", Offset = "0xA08760", VA = "0xA08760")]
		private IEnumerator AttachToolsToHands(Transform[] toolObjects, bool isRightHand)
		{
			return null;
		}

		[Token(Token = "0x6000949")]
		[Address(RVA = "0xA08824", Offset = "0xA08824", VA = "0xA08824")]
		private void AttachToolToHandTransform(Transform tool, bool isRightHanded)
		{
		}

		[Token(Token = "0x600094A")]
		[Address(RVA = "0xA08930", Offset = "0xA08930", VA = "0xA08930")]
		public InteractableToolsCreator()
		{
		}
	}
	[Token(Token = "0x20001A4")]
	public class InteractableToolsInputRouter : MonoBehaviour
	{
		[Token(Token = "0x4000B0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static InteractableToolsInputRouter _instance;

		[Token(Token = "0x4000B0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool _leftPinch;

		[Token(Token = "0x4000B10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool _rightPinch;

		[Token(Token = "0x4000B11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private HashSet<InteractableTool> _leftHandNearTools;

		[Token(Token = "0x4000B12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private HashSet<InteractableTool> _leftHandFarTools;

		[Token(Token = "0x4000B13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private HashSet<InteractableTool> _rightHandNearTools;

		[Token(Token = "0x4000B14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private HashSet<InteractableTool> _rightHandFarTools;

		[Token(Token = "0x170000D5")]
		public static InteractableToolsInputRouter Instance
		{
			[Token(Token = "0x6000952")]
			[Address(RVA = "0xA08E64", Offset = "0xA08E64", VA = "0xA08E64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000953")]
		[Address(RVA = "0xA08FC0", Offset = "0xA08FC0", VA = "0xA08FC0")]
		public void RegisterInteractableTool(InteractableTool interactableTool)
		{
		}

		[Token(Token = "0x6000954")]
		[Address(RVA = "0xA0905C", Offset = "0xA0905C", VA = "0xA0905C")]
		public void UnregisterInteractableTool(InteractableTool interactableTool)
		{
		}

		[Token(Token = "0x6000955")]
		[Address(RVA = "0xA090F8", Offset = "0xA090F8", VA = "0xA090F8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000956")]
		[Address(RVA = "0xA09394", Offset = "0xA09394", VA = "0xA09394")]
		private bool UpdateToolsAndEnableState(HashSet<InteractableTool> tools, bool toolsAreEnabledThisFrame)
		{
			return default(bool);
		}

		[Token(Token = "0x6000957")]
		[Address(RVA = "0xA093D0", Offset = "0xA093D0", VA = "0xA093D0")]
		private bool UpdateTools(HashSet<InteractableTool> tools, bool resetCollisionData = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000958")]
		[Address(RVA = "0xA096A8", Offset = "0xA096A8", VA = "0xA096A8")]
		private void ToggleToolsEnableState(HashSet<InteractableTool> tools, bool enableState)
		{
		}

		[Token(Token = "0x6000959")]
		[Address(RVA = "0xA098B0", Offset = "0xA098B0", VA = "0xA098B0")]
		public InteractableToolsInputRouter()
		{
		}
	}
	[Token(Token = "0x20001A5")]
	public class FingerTipPokeTool : InteractableTool
	{
		[Token(Token = "0x20001A6")]
		private sealed class <AttachTriggerLogic>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000B20")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000B21")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000B22")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FingerTipPokeTool <>4__this;

			[Token(Token = "0x170000DA")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600096B")]
				[Address(RVA = "0xA0AA80", Offset = "0xA0AA80", VA = "0xA0AA80", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DB")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600096D")]
				[Address(RVA = "0xA0AAC8", Offset = "0xA0AAC8", VA = "0xA0AAC8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000968")]
			[Address(RVA = "0xA09B4C", Offset = "0xA09B4C", VA = "0xA09B4C")]
			[DebuggerHidden]
			public <AttachTriggerLogic>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x6000969")]
			[Address(RVA = "0xA0A5F0", Offset = "0xA0A5F0", VA = "0xA0A5F0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600096A")]
			[Address(RVA = "0xA0A5F4", Offset = "0xA0A5F4", VA = "0xA0A5F4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600096C")]
			[Address(RVA = "0xA0AA88", Offset = "0xA0AA88", VA = "0xA0AA88", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000B15")]
		private const int NUM_VELOCITY_FRAMES = 10;

		[Token(Token = "0x4000B16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private FingerTipPokeToolView _fingerTipPokeToolView;

		[Token(Token = "0x4000B17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private OVRPlugin.HandFinger _fingerToFollow;

		[Token(Token = "0x4000B18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3[] _velocityFrames;

		[Token(Token = "0x4000B19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int _currVelocityFrame;

		[Token(Token = "0x4000B1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private bool _sampledMaxFramesAlready;

		[Token(Token = "0x4000B1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 _position;

		[Token(Token = "0x4000B1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private BoneCapsuleTriggerLogic[] _boneCapsuleTriggerLogic;

		[Token(Token = "0x4000B1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float _lastScale;

		[Token(Token = "0x4000B1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool _isInitialized;

		[Token(Token = "0x4000B1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private OVRBoneCapsule _capsuleToTrack;

		[Token(Token = "0x170000D6")]
		public override InteractableToolTags ToolTags
		{
			[Token(Token = "0x600095A")]
			[Address(RVA = "0xA099B8", Offset = "0xA099B8", VA = "0xA099B8", Slot = "4")]
			get
			{
				return default(InteractableToolTags);
			}
		}

		[Token(Token = "0x170000D7")]
		public override ToolInputState ToolInputState
		{
			[Token(Token = "0x600095B")]
			[Address(RVA = "0xA099C0", Offset = "0xA099C0", VA = "0xA099C0", Slot = "5")]
			get
			{
				return default(ToolInputState);
			}
		}

		[Token(Token = "0x170000D8")]
		public override bool IsFarFieldTool
		{
			[Token(Token = "0x600095C")]
			[Address(RVA = "0xA099C8", Offset = "0xA099C8", VA = "0xA099C8", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000D9")]
		public override bool EnableState
		{
			[Token(Token = "0x600095D")]
			[Address(RVA = "0xA099D0", Offset = "0xA099D0", VA = "0xA099D0", Slot = "10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600095E")]
			[Address(RVA = "0xA099F8", Offset = "0xA099F8", VA = "0xA099F8", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x600095F")]
		[Address(RVA = "0xA09A28", Offset = "0xA09A28", VA = "0xA09A28", Slot = "12")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x6000960")]
		[Address(RVA = "0xA09AD8", Offset = "0xA09AD8", VA = "0xA09AD8")]
		private IEnumerator AttachTriggerLogic()
		{
			return null;
		}

		[Token(Token = "0x6000961")]
		[Address(RVA = "0xA09B74", Offset = "0xA09B74", VA = "0xA09B74")]
		private void Update()
		{
		}

		[Token(Token = "0x6000962")]
		[Address(RVA = "0xA09DF4", Offset = "0xA09DF4", VA = "0xA09DF4")]
		private void UpdateAverageVelocity()
		{
		}

		[Token(Token = "0x6000963")]
		[Address(RVA = "0xA09FB0", Offset = "0xA09FB0", VA = "0xA09FB0")]
		private void CheckAndUpdateScale()
		{
		}

		[Token(Token = "0x6000964")]
		[Address(RVA = "0xA0A098", Offset = "0xA0A098", VA = "0xA0A098", Slot = "7")]
		public override List<InteractableCollisionInfo> GetNextIntersectingObjects()
		{
			return null;
		}

		[Token(Token = "0x6000965")]
		[Address(RVA = "0xA0A42C", Offset = "0xA0A42C", VA = "0xA0A42C", Slot = "8")]
		public override void FocusOnInteractable(Interactable focusedInteractable, ColliderZone colliderZone)
		{
		}

		[Token(Token = "0x6000966")]
		[Address(RVA = "0xA0A430", Offset = "0xA0A430", VA = "0xA0A430", Slot = "9")]
		public override void DeFocus()
		{
		}

		[Token(Token = "0x6000967")]
		[Address(RVA = "0xA0A434", Offset = "0xA0A434", VA = "0xA0A434")]
		public FingerTipPokeTool()
		{
		}
	}
	[Token(Token = "0x20001A7")]
	public class FingerTipPokeToolView : MonoBehaviour
	{
		[Token(Token = "0x4000B23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MeshRenderer _sphereMeshRenderer;

		[Token(Token = "0x4000B24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private InteractableTool <InteractableTool>k__BackingField;

		[Token(Token = "0x4000B25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool <ToolActivateState>k__BackingField;

		[Token(Token = "0x4000B26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <SphereRadius>k__BackingField;

		[Token(Token = "0x170000DC")]
		public InteractableTool InteractableTool
		{
			[Token(Token = "0x600096E")]
			[Address(RVA = "0xA0AAD0", Offset = "0xA0AAD0", VA = "0xA0AAD0", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600096F")]
			[Address(RVA = "0xA0AAD8", Offset = "0xA0AAD8", VA = "0xA0AAD8")]
			set
			{
			}
		}

		[Token(Token = "0x170000DD")]
		public bool EnableState
		{
			[Token(Token = "0x6000970")]
			[Address(RVA = "0xA0AAE0", Offset = "0xA0AAE0", VA = "0xA0AAE0", Slot = "5")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000971")]
			[Address(RVA = "0xA0AAFC", Offset = "0xA0AAFC", VA = "0xA0AAFC", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x170000DE")]
		public bool ToolActivateState
		{
			[Token(Token = "0x6000972")]
			[Address(RVA = "0xA0AB1C", Offset = "0xA0AB1C", VA = "0xA0AB1C", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000973")]
			[Address(RVA = "0xA0AB24", Offset = "0xA0AB24", VA = "0xA0AB24", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x170000DF")]
		public float SphereRadius
		{
			[Token(Token = "0x6000974")]
			[Address(RVA = "0xA0AB30", Offset = "0xA0AB30", VA = "0xA0AB30")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000975")]
			[Address(RVA = "0xA0AB38", Offset = "0xA0AB38", VA = "0xA0AB38")]
			private set
			{
			}
		}

		[Token(Token = "0x6000976")]
		[Address(RVA = "0xA0AB40", Offset = "0xA0AB40", VA = "0xA0AB40")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000977")]
		[Address(RVA = "0xA0AB7C", Offset = "0xA0AB7C", VA = "0xA0AB7C")]
		public FingerTipPokeToolView()
		{
		}
	}
	[Token(Token = "0x20001A8")]
	[Flags]
	public enum InteractableToolTags
	{
		[Token(Token = "0x4000B28")]
		None = 0,
		[Token(Token = "0x4000B29")]
		Ray = 1,
		[Token(Token = "0x4000B2A")]
		Poke = 4,
		[Token(Token = "0x4000B2B")]
		All = -1
	}
	[Token(Token = "0x20001A9")]
	public enum ToolInputState
	{
		[Token(Token = "0x4000B2D")]
		Inactive,
		[Token(Token = "0x4000B2E")]
		PrimaryInputDown,
		[Token(Token = "0x4000B2F")]
		PrimaryInputDownStay,
		[Token(Token = "0x4000B30")]
		PrimaryInputUp
	}
	[Token(Token = "0x20001AA")]
	public class InteractableCollisionInfo
	{
		[Token(Token = "0x4000B31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ColliderZone InteractableCollider;

		[Token(Token = "0x4000B32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractableCollisionDepth CollisionDepth;

		[Token(Token = "0x4000B33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractableTool CollidingTool;

		[Token(Token = "0x6000978")]
		[Address(RVA = "0xA0A3D8", Offset = "0xA0A3D8", VA = "0xA0A3D8")]
		public InteractableCollisionInfo(ColliderZone collider, InteractableCollisionDepth collisionDepth, InteractableTool collidingTool)
		{
		}
	}
	[Token(Token = "0x20001AB")]
	public abstract class InteractableTool : MonoBehaviour
	{
		[Token(Token = "0x4000B34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool <IsRightHandedTool>k__BackingField;

		[Token(Token = "0x4000B35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector3 <Velocity>k__BackingField;

		[Token(Token = "0x4000B36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 <InteractionPosition>k__BackingField;

		[Token(Token = "0x4000B37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected List<InteractableCollisionInfo> _currentIntersectingObjects;

		[Token(Token = "0x4000B38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<Interactable> _addedInteractables;

		[Token(Token = "0x4000B39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<Interactable> _removedInteractables;

		[Token(Token = "0x4000B3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<Interactable> _remainingInteractables;

		[Token(Token = "0x4000B3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Dictionary<Interactable, InteractableCollisionInfo> _currInteractableToCollisionInfos;

		[Token(Token = "0x4000B3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Dictionary<Interactable, InteractableCollisionInfo> _prevInteractableToCollisionInfos;

		[Token(Token = "0x170000E0")]
		public Transform ToolTransform
		{
			[Token(Token = "0x6000979")]
			[Address(RVA = "0xA0688C", Offset = "0xA0688C", VA = "0xA0688C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E1")]
		public bool IsRightHandedTool
		{
			[Token(Token = "0x600097A")]
			[Address(RVA = "0xA0AB84", Offset = "0xA0AB84", VA = "0xA0AB84")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600097B")]
			[Address(RVA = "0xA0AB8C", Offset = "0xA0AB8C", VA = "0xA0AB8C")]
			set
			{
			}
		}

		[Token(Token = "0x170000E2")]
		public abstract InteractableToolTags ToolTags
		{
			[Token(Token = "0x600097C")]
			get;
		}

		[Token(Token = "0x170000E3")]
		public abstract ToolInputState ToolInputState
		{
			[Token(Token = "0x600097D")]
			get;
		}

		[Token(Token = "0x170000E4")]
		public abstract bool IsFarFieldTool
		{
			[Token(Token = "0x600097E")]
			get;
		}

		[Token(Token = "0x170000E5")]
		public Vector3 Velocity
		{
			[Token(Token = "0x600097F")]
			[Address(RVA = "0xA0AB98", Offset = "0xA0AB98", VA = "0xA0AB98")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000980")]
			[Address(RVA = "0xA0ABA4", Offset = "0xA0ABA4", VA = "0xA0ABA4")]
			protected set
			{
			}
		}

		[Token(Token = "0x170000E6")]
		public Vector3 InteractionPosition
		{
			[Token(Token = "0x6000981")]
			[Address(RVA = "0xA0ABB0", Offset = "0xA0ABB0", VA = "0xA0ABB0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000982")]
			[Address(RVA = "0xA0ABBC", Offset = "0xA0ABBC", VA = "0xA0ABBC")]
			protected set
			{
			}
		}

		[Token(Token = "0x170000E7")]
		public abstract bool EnableState
		{
			[Token(Token = "0x6000987")]
			get;
			[Token(Token = "0x6000988")]
			set;
		}

		[Token(Token = "0x6000983")]
		[Address(RVA = "0xA0ABC8", Offset = "0xA0ABC8", VA = "0xA0ABC8")]
		public List<InteractableCollisionInfo> GetCurrentIntersectingObjects()
		{
			return null;
		}

		[Token(Token = "0x6000984")]
		public abstract List<InteractableCollisionInfo> GetNextIntersectingObjects();

		[Token(Token = "0x6000985")]
		public abstract void FocusOnInteractable(Interactable focusedInteractable, ColliderZone colliderZone);

		[Token(Token = "0x6000986")]
		public abstract void DeFocus();

		[Token(Token = "0x6000989")]
		public abstract void Initialize();

		[Token(Token = "0x600098A")]
		[Address(RVA = "0xA09818", Offset = "0xA09818", VA = "0xA09818")]
		public KeyValuePair<Interactable, InteractableCollisionInfo> GetFirstCurrentCollisionInfo()
		{
			return default(KeyValuePair<Interactable, InteractableCollisionInfo>);
		}

		[Token(Token = "0x600098B")]
		[Address(RVA = "0xA09860", Offset = "0xA09860", VA = "0xA09860")]
		public void ClearAllCurrentCollisionInfos()
		{
		}

		[Token(Token = "0x600098C")]
		[Address(RVA = "0xA0ABD0", Offset = "0xA0ABD0", VA = "0xA0ABD0", Slot = "13")]
		public virtual void UpdateCurrentCollisionsBasedOnDepth()
		{
		}

		[Token(Token = "0x600098D")]
		[Address(RVA = "0xA0AE98", Offset = "0xA0AE98", VA = "0xA0AE98", Slot = "14")]
		public virtual void UpdateLatestCollisionData()
		{
		}

		[Token(Token = "0x600098E")]
		[Address(RVA = "0xA0A448", Offset = "0xA0A448", VA = "0xA0A448")]
		protected InteractableTool()
		{
		}
	}
	[Token(Token = "0x20001AC")]
	public class PinchStateModule
	{
		[Token(Token = "0x20001AD")]
		private enum PinchState
		{
			[Token(Token = "0x4000B41")]
			None,
			[Token(Token = "0x4000B42")]
			PinchDown,
			[Token(Token = "0x4000B43")]
			PinchStay,
			[Token(Token = "0x4000B44")]
			PinchUp
		}

		[Token(Token = "0x4000B3D")]
		private const float PINCH_STRENGTH_THRESHOLD = 1f;

		[Token(Token = "0x4000B3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private PinchState _currPinchState;

		[Token(Token = "0x4000B3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Interactable _firstFocusedInteractable;

		[Token(Token = "0x170000E8")]
		public bool PinchUpAndDownOnFocusedObject
		{
			[Token(Token = "0x600098F")]
			[Address(RVA = "0xA0B734", Offset = "0xA0B734", VA = "0xA0B734")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000E9")]
		public bool PinchSteadyOnFocusedObject
		{
			[Token(Token = "0x6000990")]
			[Address(RVA = "0xA0B7B0", Offset = "0xA0B7B0", VA = "0xA0B7B0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000EA")]
		public bool PinchDownOnFocusedObject
		{
			[Token(Token = "0x6000991")]
			[Address(RVA = "0xA0B82C", Offset = "0xA0B82C", VA = "0xA0B82C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000992")]
		[Address(RVA = "0xA0B8A8", Offset = "0xA0B8A8", VA = "0xA0B8A8")]
		public PinchStateModule()
		{
		}

		[Token(Token = "0x6000993")]
		[Address(RVA = "0xA0B8D0", Offset = "0xA0B8D0", VA = "0xA0B8D0")]
		public void UpdateState(OVRHand hand, Interactable currFocusedInteractable)
		{
		}
	}
	[Token(Token = "0x20001AE")]
	public class RayTool : InteractableTool
	{
		[Token(Token = "0x4000B45")]
		private const float MINIMUM_RAY_CAST_DISTANCE = 0.8f;

		[Token(Token = "0x4000B46")]
		private const float COLLIDER_RADIUS = 0.01f;

		[Token(Token = "0x4000B47")]
		private const int NUM_MAX_PRIMARY_HITS = 10;

		[Token(Token = "0x4000B48")]
		private const int NUM_MAX_SECONDARY_HITS = 25;

		[Token(Token = "0x4000B49")]
		private const int NUM_COLLIDERS_TO_TEST = 20;

		[Token(Token = "0x4000B4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RayToolView _rayToolView;

		[Token(Token = "0x4000B4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Range(0f, 45f)]
		[SerializeField]
		private float _coneAngleDegrees;

		[Token(Token = "0x4000B4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		private float _farFieldMaxDistance;

		[Token(Token = "0x4000B4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private PinchStateModule _pinchStateModule;

		[Token(Token = "0x4000B4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Interactable _focusedInteractable;

		[Token(Token = "0x4000B4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Collider[] _collidersOverlapped;

		[Token(Token = "0x4000B50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Interactable _currInteractableCastedAgainst;

		[Token(Token = "0x4000B51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float _coneAngleReleaseDegrees;

		[Token(Token = "0x4000B52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private RaycastHit[] _primaryHits;

		[Token(Token = "0x4000B53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Collider[] _secondaryOverlapResults;

		[Token(Token = "0x4000B54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private bool _initialized;

		[Token(Token = "0x170000EB")]
		public override InteractableToolTags ToolTags
		{
			[Token(Token = "0x6000994")]
			[Address(RVA = "0xA0BA48", Offset = "0xA0BA48", VA = "0xA0BA48", Slot = "4")]
			get
			{
				return default(InteractableToolTags);
			}
		}

		[Token(Token = "0x170000EC")]
		public override ToolInputState ToolInputState
		{
			[Token(Token = "0x6000995")]
			[Address(RVA = "0xA0BA50", Offset = "0xA0BA50", VA = "0xA0BA50", Slot = "5")]
			get
			{
				return default(ToolInputState);
			}
		}

		[Token(Token = "0x170000ED")]
		public override bool IsFarFieldTool
		{
			[Token(Token = "0x6000996")]
			[Address(RVA = "0xA0BAAC", Offset = "0xA0BAAC", VA = "0xA0BAAC", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000EE")]
		public override bool EnableState
		{
			[Token(Token = "0x6000997")]
			[Address(RVA = "0xA0BAB4", Offset = "0xA0BAB4", VA = "0xA0BAB4", Slot = "10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000998")]
			[Address(RVA = "0xA0BAF4", Offset = "0xA0BAF4", VA = "0xA0BAF4", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x6000999")]
		[Address(RVA = "0xA0BB64", Offset = "0xA0BB64", VA = "0xA0BB64", Slot = "12")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x600099A")]
		[Address(RVA = "0xA0BBB8", Offset = "0xA0BBB8", VA = "0xA0BBB8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600099B")]
		[Address(RVA = "0xA0BC44", Offset = "0xA0BC44", VA = "0xA0BC44")]
		private void Update()
		{
		}

		[Token(Token = "0x600099C")]
		[Address(RVA = "0xA0BEE8", Offset = "0xA0BEE8", VA = "0xA0BEE8")]
		private Vector3 GetRayCastOrigin()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600099D")]
		[Address(RVA = "0xA0BF64", Offset = "0xA0BF64", VA = "0xA0BF64", Slot = "7")]
		public override List<InteractableCollisionInfo> GetNextIntersectingObjects()
		{
			return null;
		}

		[Token(Token = "0x600099E")]
		[Address(RVA = "0xA0C358", Offset = "0xA0C358", VA = "0xA0C358")]
		private bool HasRayReleasedInteractable(Interactable focusedInteractable)
		{
			return default(bool);
		}

		[Token(Token = "0x600099F")]
		[Address(RVA = "0xA0C4F4", Offset = "0xA0C4F4", VA = "0xA0C4F4")]
		private Interactable FindTargetInteractable()
		{
			return null;
		}

		[Token(Token = "0x60009A0")]
		[Address(RVA = "0xA0C60C", Offset = "0xA0C60C", VA = "0xA0C60C")]
		private Interactable FindPrimaryRaycastHit(Vector3 rayOrigin, Vector3 rayDirection)
		{
			return null;
		}

		[Token(Token = "0x60009A1")]
		[Address(RVA = "0xA0C930", Offset = "0xA0C930", VA = "0xA0C930")]
		private Interactable FindInteractableViaConeTest(Vector3 rayOrigin, Vector3 rayDirection)
		{
			return null;
		}

		[Token(Token = "0x60009A2")]
		[Address(RVA = "0xA0CCAC", Offset = "0xA0CCAC", VA = "0xA0CCAC", Slot = "8")]
		public override void FocusOnInteractable(Interactable focusedInteractable, ColliderZone colliderZone)
		{
		}

		[Token(Token = "0x60009A3")]
		[Address(RVA = "0xA0CD84", Offset = "0xA0CD84", VA = "0xA0CD84", Slot = "9")]
		public override void DeFocus()
		{
		}

		[Token(Token = "0x60009A4")]
		[Address(RVA = "0xA0CDB4", Offset = "0xA0CDB4", VA = "0xA0CDB4")]
		public RayTool()
		{
		}
	}
	[Token(Token = "0x20001AF")]
	public class RayToolView : MonoBehaviour
	{
		[Token(Token = "0x4000B55")]
		private const int NUM_RAY_LINE_POSITIONS = 25;

		[Token(Token = "0x4000B56")]
		private const float DEFAULT_RAY_CAST_DISTANCE = 3f;

		[Token(Token = "0x4000B57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _targetTransform;

		[Token(Token = "0x4000B58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LineRenderer _lineRenderer;

		[Token(Token = "0x4000B59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _toolActivateState;

		[Token(Token = "0x4000B5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform _focusedTransform;

		[Token(Token = "0x4000B5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3[] linePositions;

		[Token(Token = "0x4000B5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Gradient _oldColorGradient;

		[Token(Token = "0x4000B5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Gradient _highLightColorGradient;

		[Token(Token = "0x4000B5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private InteractableTool <InteractableTool>k__BackingField;

		[Token(Token = "0x170000EF")]
		public bool EnableState
		{
			[Token(Token = "0x60009A5")]
			[Address(RVA = "0xA0BAD8", Offset = "0xA0BAD8", VA = "0xA0BAD8", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009A6")]
			[Address(RVA = "0xA0BB10", Offset = "0xA0BB10", VA = "0xA0BB10", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x170000F0")]
		public bool ToolActivateState
		{
			[Token(Token = "0x60009A7")]
			[Address(RVA = "0xA0CEC8", Offset = "0xA0CEC8", VA = "0xA0CEC8", Slot = "6")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009A8")]
			[Address(RVA = "0xA0BEAC", Offset = "0xA0BEAC", VA = "0xA0BEAC", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x170000F1")]
		public InteractableTool InteractableTool
		{
			[Token(Token = "0x60009AA")]
			[Address(RVA = "0xA0D0F0", Offset = "0xA0D0F0", VA = "0xA0D0F0", Slot = "8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009AB")]
			[Address(RVA = "0xA0D0F8", Offset = "0xA0D0F8", VA = "0xA0D0F8")]
			set
			{
			}
		}

		[Token(Token = "0x60009A9")]
		[Address(RVA = "0xA0CED0", Offset = "0xA0CED0", VA = "0xA0CED0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60009AC")]
		[Address(RVA = "0xA0CCE4", Offset = "0xA0CCE4", VA = "0xA0CCE4", Slot = "9")]
		public void SetFocusedInteractable(Interactable interactable)
		{
		}

		[Token(Token = "0x60009AD")]
		[Address(RVA = "0xA0D100", Offset = "0xA0D100", VA = "0xA0D100")]
		private void Update()
		{
		}

		[Token(Token = "0x60009AE")]
		[Address(RVA = "0xA0D3AC", Offset = "0xA0D3AC", VA = "0xA0D3AC")]
		public static Vector3 GetPointOnBezierCurve(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60009AF")]
		[Address(RVA = "0xA0D454", Offset = "0xA0D454", VA = "0xA0D454")]
		public RayToolView()
		{
		}
	}
	[Token(Token = "0x20001B0")]
	public class DistanceGrabberSample : MonoBehaviour
	{
		[Token(Token = "0x4000B5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool useSpherecast;

		[Token(Token = "0x4000B60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool allowGrabThroughWalls;

		[Token(Token = "0x4000B61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private DistanceGrabber[] m_grabbers;

		[Token(Token = "0x170000F2")]
		public bool UseSpherecast
		{
			[Token(Token = "0x60009B0")]
			[Address(RVA = "0xA0D4B8", Offset = "0xA0D4B8", VA = "0xA0D4B8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009B1")]
			[Address(RVA = "0xA0D4C0", Offset = "0xA0D4C0", VA = "0xA0D4C0")]
			set
			{
			}
		}

		[Token(Token = "0x170000F3")]
		public bool AllowGrabThroughWalls
		{
			[Token(Token = "0x60009B2")]
			[Address(RVA = "0xA0D52C", Offset = "0xA0D52C", VA = "0xA0D52C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009B3")]
			[Address(RVA = "0xA0D534", Offset = "0xA0D534", VA = "0xA0D534")]
			set
			{
			}
		}

		[Token(Token = "0x60009B4")]
		[Address(RVA = "0xA0D590", Offset = "0xA0D590", VA = "0xA0D590")]
		private void Start()
		{
		}

		[Token(Token = "0x60009B5")]
		[Address(RVA = "0xA0D830", Offset = "0xA0D830", VA = "0xA0D830")]
		public void ToggleSphereCasting(Toggle t)
		{
		}

		[Token(Token = "0x60009B6")]
		[Address(RVA = "0xA0D840", Offset = "0xA0D840", VA = "0xA0D840")]
		public void ToggleGrabThroughWalls(Toggle t)
		{
		}

		[Token(Token = "0x60009B7")]
		[Address(RVA = "0xA0D850", Offset = "0xA0D850", VA = "0xA0D850")]
		public DistanceGrabberSample()
		{
		}
	}
	[Token(Token = "0x20001B1")]
	public class ControllerBoxController : MonoBehaviour
	{
		[Token(Token = "0x4000B62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TrainLocomotive _locomotive;

		[Token(Token = "0x4000B63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CowController _cowController;

		[Token(Token = "0x60009B8")]
		[Address(RVA = "0xA0D858", Offset = "0xA0D858", VA = "0xA0D858")]
		public void StartStopStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60009B9")]
		[Address(RVA = "0xA0D8E4", Offset = "0xA0D8E4", VA = "0xA0D8E4")]
		public void DecreaseSpeedStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60009BA")]
		[Address(RVA = "0xA0D974", Offset = "0xA0D974", VA = "0xA0D974")]
		public void IncreaseSpeedStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60009BB")]
		[Address(RVA = "0xA0DA04", Offset = "0xA0DA04", VA = "0xA0DA04")]
		public void SmokeButtonStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60009BC")]
		[Address(RVA = "0xA0DAB0", Offset = "0xA0DAB0", VA = "0xA0DAB0")]
		public void WhistleButtonStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60009BD")]
		[Address(RVA = "0xA0DB8C", Offset = "0xA0DB8C", VA = "0xA0DB8C")]
		public void ReverseButtonStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60009BE")]
		[Address(RVA = "0xA0DBD0", Offset = "0xA0DBD0", VA = "0xA0DBD0")]
		public void SwitchVisualization(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60009BF")]
		[Address(RVA = "0xA0DC30", Offset = "0xA0DC30", VA = "0xA0DC30")]
		public void GoMoo(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60009C0")]
		[Address(RVA = "0xA0DC90", Offset = "0xA0DC90", VA = "0xA0DC90")]
		public ControllerBoxController()
		{
		}
	}
	[Token(Token = "0x20001B2")]
	public class CowController : MonoBehaviour
	{
		[Token(Token = "0x4000B64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Animation _cowAnimation;

		[Token(Token = "0x4000B65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioSource _mooCowAudioSource;

		[Token(Token = "0x60009C1")]
		[Address(RVA = "0xA0DC98", Offset = "0xA0DC98", VA = "0xA0DC98")]
		public void PlayMooSound()
		{
		}

		[Token(Token = "0x60009C2")]
		[Address(RVA = "0xA0DC60", Offset = "0xA0DC60", VA = "0xA0DC60")]
		public void GoMooCowGo()
		{
		}

		[Token(Token = "0x60009C3")]
		[Address(RVA = "0xA0DCCC", Offset = "0xA0DCCC", VA = "0xA0DCCC")]
		public CowController()
		{
		}
	}
	[Token(Token = "0x20001B3")]
	public class PanelHMDFollower : MonoBehaviour
	{
		[Token(Token = "0x20001B4")]
		private sealed class <LerpToHMD>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000B70")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000B71")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000B72")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PanelHMDFollower <>4__this;

			[Token(Token = "0x4000B73")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 <newPanelPosition>5__2;

			[Token(Token = "0x4000B74")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <startTime>5__3;

			[Token(Token = "0x4000B75")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float <endTime>5__4;

			[Token(Token = "0x170000F4")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009CC")]
				[Address(RVA = "0xA0E34C", Offset = "0xA0E34C", VA = "0xA0E34C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F5")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009CE")]
				[Address(RVA = "0xA0E394", Offset = "0xA0E394", VA = "0xA0E394", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009C9")]
			[Address(RVA = "0xA0E0C4", Offset = "0xA0E0C4", VA = "0xA0E0C4")]
			[DebuggerHidden]
			public <LerpToHMD>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x60009CA")]
			[Address(RVA = "0xA0E18C", Offset = "0xA0E18C", VA = "0xA0E18C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009CB")]
			[Address(RVA = "0xA0E190", Offset = "0xA0E190", VA = "0xA0E190", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009CD")]
			[Address(RVA = "0xA0E354", Offset = "0xA0E354", VA = "0xA0E354", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000B66")]
		private const float TOTAL_DURATION = 3f;

		[Token(Token = "0x4000B67")]
		private const float HMD_MOVEMENT_THRESHOLD = 0.3f;

		[Token(Token = "0x4000B68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _maxDistance;

		[Token(Token = "0x4000B69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _minDistance;

		[Token(Token = "0x4000B6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _minZDistance;

		[Token(Token = "0x4000B6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private OVRCameraRig _cameraRig;

		[Token(Token = "0x4000B6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 _panelInitialPosition;

		[Token(Token = "0x4000B6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Coroutine _coroutine;

		[Token(Token = "0x4000B6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 _prevPos;

		[Token(Token = "0x4000B6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 _lastMovedToPos;

		[Token(Token = "0x60009C4")]
		[Address(RVA = "0xA0DCD4", Offset = "0xA0DCD4", VA = "0xA0DCD4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60009C5")]
		[Address(RVA = "0xA0DD74", Offset = "0xA0DD74", VA = "0xA0DD74")]
		private void Update()
		{
		}

		[Token(Token = "0x60009C6")]
		[Address(RVA = "0xA0E084", Offset = "0xA0E084", VA = "0xA0E084")]
		private Vector3 CalculateIdealAnchorPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60009C7")]
		[Address(RVA = "0xA0E010", Offset = "0xA0E010", VA = "0xA0E010")]
		private IEnumerator LerpToHMD()
		{
			return null;
		}

		[Token(Token = "0x60009C8")]
		[Address(RVA = "0xA0E0EC", Offset = "0xA0E0EC", VA = "0xA0E0EC")]
		public PanelHMDFollower()
		{
		}
	}
	[Token(Token = "0x20001B5")]
	public class SelectionCylinder : MonoBehaviour
	{
		[Token(Token = "0x20001B6")]
		public enum SelectionState
		{
			[Token(Token = "0x4000B7D")]
			Off,
			[Token(Token = "0x4000B7E")]
			Selected,
			[Token(Token = "0x4000B7F")]
			Highlighted
		}

		[Token(Token = "0x4000B76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MeshRenderer _selectionMeshRenderer;

		[Token(Token = "0x4000B77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int _colorId;

		[Token(Token = "0x4000B78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material[] _selectionMaterials;

		[Token(Token = "0x4000B79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Color[] _defaultSelectionColors;

		[Token(Token = "0x4000B7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Color[] _highlightColors;

		[Token(Token = "0x4000B7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private SelectionState _currSelectionState;

		[Token(Token = "0x170000F6")]
		public SelectionState CurrSelectionState
		{
			[Token(Token = "0x60009CF")]
			[Address(RVA = "0xA0E39C", Offset = "0xA0E39C", VA = "0xA0E39C")]
			get
			{
				return default(SelectionState);
			}
			[Token(Token = "0x60009D0")]
			[Address(RVA = "0xA0E3A4", Offset = "0xA0E3A4", VA = "0xA0E3A4")]
			set
			{
			}
		}

		[Token(Token = "0x60009D1")]
		[Address(RVA = "0xA0E4F8", Offset = "0xA0E4F8", VA = "0xA0E4F8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60009D2")]
		[Address(RVA = "0xA0E6BC", Offset = "0xA0E6BC", VA = "0xA0E6BC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60009D3")]
		[Address(RVA = "0xA0E418", Offset = "0xA0E418", VA = "0xA0E418")]
		private void AffectSelectionColor(Color[] newColors)
		{
		}

		[Token(Token = "0x60009D4")]
		[Address(RVA = "0xA0E784", Offset = "0xA0E784", VA = "0xA0E784")]
		public SelectionCylinder()
		{
		}
	}
	[Token(Token = "0x20001B7")]
	public class TrackSegment : MonoBehaviour
	{
		[Token(Token = "0x20001B8")]
		public enum SegmentType
		{
			[Token(Token = "0x4000B8E")]
			Straight,
			[Token(Token = "0x4000B8F")]
			LeftTurn,
			[Token(Token = "0x4000B90")]
			RightTurn,
			[Token(Token = "0x4000B91")]
			Switch
		}

		[Token(Token = "0x4000B80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SegmentType _segmentType;

		[Token(Token = "0x4000B81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MeshFilter _straight;

		[Token(Token = "0x4000B82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MeshFilter _leftTurn;

		[Token(Token = "0x4000B83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private MeshFilter _rightTurn;

		[Token(Token = "0x4000B84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float _gridSize;

		[Token(Token = "0x4000B85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int _subDivCount;

		[Token(Token = "0x4000B86")]
		private const float _originalGridSize = 0.8f;

		[Token(Token = "0x4000B87")]
		private const float _trackWidth = 0.15f;

		[Token(Token = "0x4000B88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private GameObject _mesh;

		[Token(Token = "0x4000B89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float <StartDistance>k__BackingField;

		[Token(Token = "0x4000B8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Pose _p1;

		[Token(Token = "0x4000B8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Pose _p2;

		[Token(Token = "0x4000B8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Pose _endPose;

		[Token(Token = "0x170000F7")]
		public float StartDistance
		{
			[Token(Token = "0x60009D6")]
			[Address(RVA = "0xA0E7F4", Offset = "0xA0E7F4", VA = "0xA0E7F4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60009D7")]
			[Address(RVA = "0xA0E7FC", Offset = "0xA0E7FC", VA = "0xA0E7FC")]
			set
			{
			}
		}

		[Token(Token = "0x170000F8")]
		public float GridSize
		{
			[Token(Token = "0x60009D8")]
			[Address(RVA = "0xA0E804", Offset = "0xA0E804", VA = "0xA0E804")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60009D9")]
			[Address(RVA = "0xA0E80C", Offset = "0xA0E80C", VA = "0xA0E80C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000F9")]
		public int SubDivCount
		{
			[Token(Token = "0x60009DA")]
			[Address(RVA = "0xA0E814", Offset = "0xA0E814", VA = "0xA0E814")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60009DB")]
			[Address(RVA = "0xA0E81C", Offset = "0xA0E81C", VA = "0xA0E81C")]
			set
			{
			}
		}

		[Token(Token = "0x170000FA")]
		public SegmentType Type
		{
			[Token(Token = "0x60009DC")]
			[Address(RVA = "0xA0E824", Offset = "0xA0E824", VA = "0xA0E824")]
			get
			{
				return default(SegmentType);
			}
		}

		[Token(Token = "0x170000FB")]
		public Pose EndPose
		{
			[Token(Token = "0x60009DD")]
			[Address(RVA = "0xA0E82C", Offset = "0xA0E82C", VA = "0xA0E82C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FC")]
		public float Radius
		{
			[Token(Token = "0x60009DE")]
			[Address(RVA = "0xA0EC00", Offset = "0xA0EC00", VA = "0xA0EC00")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000FD")]
		public float SegmentLength
		{
			[Token(Token = "0x60009E0")]
			[Address(RVA = "0xA0E888", Offset = "0xA0E888", VA = "0xA0E888")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60009DF")]
		[Address(RVA = "0xA0EC10", Offset = "0xA0EC10", VA = "0xA0EC10")]
		public float setGridSize(float size)
		{
			return default(float);
		}

		[Token(Token = "0x60009E1")]
		[Address(RVA = "0xA0E8C8", Offset = "0xA0E8C8", VA = "0xA0E8C8")]
		public void UpdatePose(float distanceIntoSegment, Pose pose)
		{
		}

		[Token(Token = "0x60009E2")]
		[Address(RVA = "0xA0EC28", Offset = "0xA0EC28", VA = "0xA0EC28")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60009E3")]
		[Address(RVA = "0xA0EC84", Offset = "0xA0EC84", VA = "0xA0EC84")]
		private void DrawDebugLines()
		{
		}

		[Token(Token = "0x60009E4")]
		[Address(RVA = "0xA0F5B8", Offset = "0xA0F5B8", VA = "0xA0F5B8")]
		public void RegenerateTrackAndMesh()
		{
		}

		[Token(Token = "0x60009E5")]
		[Address(RVA = "0xA0F83C", Offset = "0xA0F83C", VA = "0xA0F83C")]
		public TrackSegment()
		{
		}
	}
	[Token(Token = "0x20001B9")]
	public class TrainButtonVisualController : MonoBehaviour
	{
		[Token(Token = "0x20001BA")]
		private sealed class <ResetPosition>d__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000BA3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000BA4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000BA5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TrainButtonVisualController <>4__this;

			[Token(Token = "0x4000BA6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <startTime>5__2;

			[Token(Token = "0x4000BA7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <endTime>5__3;

			[Token(Token = "0x170000FE")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009F4")]
				[Address(RVA = "0xA10360", Offset = "0xA10360", VA = "0xA10360", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000FF")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009F6")]
				[Address(RVA = "0xA103A8", Offset = "0xA103A8", VA = "0xA103A8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009F1")]
			[Address(RVA = "0xA10194", Offset = "0xA10194", VA = "0xA10194")]
			[DebuggerHidden]
			public <ResetPosition>d__26(int <>1__state)
			{
			}

			[Token(Token = "0x60009F2")]
			[Address(RVA = "0xA101E4", Offset = "0xA101E4", VA = "0xA101E4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009F3")]
			[Address(RVA = "0xA101E8", Offset = "0xA101E8", VA = "0xA101E8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009F5")]
			[Address(RVA = "0xA10368", Offset = "0xA10368", VA = "0xA10368", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000B92")]
		private const float LERP_TO_OLD_POS_DURATION = 1f;

		[Token(Token = "0x4000B93")]
		private const float LOCAL_SIZE_HALVED = 0.5f;

		[Token(Token = "0x4000B94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MeshRenderer _meshRenderer;

		[Token(Token = "0x4000B95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MeshRenderer _glowRenderer;

		[Token(Token = "0x4000B96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ButtonController _buttonController;

		[Token(Token = "0x4000B97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _buttonContactColor;

		[Token(Token = "0x4000B98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Color _buttonActionColor;

		[Token(Token = "0x4000B99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private AudioSource _audioSource;

		[Token(Token = "0x4000B9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private AudioClip _actionSoundEffect;

		[Token(Token = "0x4000B9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform _buttonContactTransform;

		[Token(Token = "0x4000B9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _contactMaxDisplacementDistance;

		[Token(Token = "0x4000B9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material _buttonMaterial;

		[Token(Token = "0x4000B9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Color _buttonDefaultColor;

		[Token(Token = "0x4000B9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int _materialColorId;

		[Token(Token = "0x4000BA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private bool _buttonInContactOrActionStates;

		[Token(Token = "0x4000BA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Coroutine _lerpToOldPositionCr;

		[Token(Token = "0x4000BA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 _oldPosition;

		[Token(Token = "0x60009E6")]
		[Address(RVA = "0xA0F99C", Offset = "0xA0F99C", VA = "0xA0F99C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60009E7")]
		[Address(RVA = "0xA0FA54", Offset = "0xA0FA54", VA = "0xA0FA54")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60009E8")]
		[Address(RVA = "0xA0FAE4", Offset = "0xA0FAE4", VA = "0xA0FAE4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60009E9")]
		[Address(RVA = "0xA0FC2C", Offset = "0xA0FC2C", VA = "0xA0FC2C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60009EA")]
		[Address(RVA = "0xA0FDB8", Offset = "0xA0FDB8", VA = "0xA0FDB8")]
		private void ActionOrInContactZoneStayEvent(ColliderZoneArgs collisionArgs)
		{
		}

		[Token(Token = "0x60009EB")]
		[Address(RVA = "0xA0FEC8", Offset = "0xA0FEC8", VA = "0xA0FEC8")]
		private void InteractableStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60009EC")]
		[Address(RVA = "0xA100CC", Offset = "0xA100CC", VA = "0xA100CC")]
		private void PlaySound(AudioClip clip)
		{
		}

		[Token(Token = "0x60009ED")]
		[Address(RVA = "0xA0FFD8", Offset = "0xA0FFD8", VA = "0xA0FFD8")]
		private void StopResetLerping()
		{
		}

		[Token(Token = "0x60009EE")]
		[Address(RVA = "0xA0FFEC", Offset = "0xA0FFEC", VA = "0xA0FFEC")]
		private void LerpToOldPosition()
		{
		}

		[Token(Token = "0x60009EF")]
		[Address(RVA = "0xA10120", Offset = "0xA10120", VA = "0xA10120")]
		private IEnumerator ResetPosition()
		{
			return null;
		}

		[Token(Token = "0x60009F0")]
		[Address(RVA = "0xA101BC", Offset = "0xA101BC", VA = "0xA101BC")]
		public TrainButtonVisualController()
		{
		}
	}
	[Token(Token = "0x20001BB")]
	public class TrainCar : TrainCarBase
	{
		[Token(Token = "0x4000BA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TrainCarBase _parentLocomotive;

		[Token(Token = "0x4000BA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		protected float _distanceBehindParent;

		[Token(Token = "0x17000100")]
		public float DistanceBehindParentScaled
		{
			[Token(Token = "0x60009F7")]
			[Address(RVA = "0xA103B0", Offset = "0xA103B0", VA = "0xA103B0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60009F8")]
		[Address(RVA = "0xA103C0", Offset = "0xA103C0", VA = "0xA103C0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60009F9")]
		[Address(RVA = "0xA103C8", Offset = "0xA103C8", VA = "0xA103C8", Slot = "5")]
		public override void UpdatePosition()
		{
		}

		[Token(Token = "0x60009FA")]
		[Address(RVA = "0xA106F8", Offset = "0xA106F8", VA = "0xA106F8")]
		public TrainCar()
		{
		}
	}
	[Token(Token = "0x20001BC")]
	public abstract class TrainCarBase : MonoBehaviour
	{
		[Token(Token = "0x4000BAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Vector3 OFFSET;

		[Token(Token = "0x4000BAB")]
		private const float WHEEL_RADIUS = 0.027f;

		[Token(Token = "0x4000BAC")]
		private const float TWO_PI = (float)Math.PI * 2f;

		[Token(Token = "0x4000BAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected Transform _frontWheels;

		[Token(Token = "0x4000BAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected Transform _rearWheels;

		[Token(Token = "0x4000BAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected TrainTrack _trainTrack;

		[Token(Token = "0x4000BB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected Transform[] _individualWheels;

		[Token(Token = "0x4000BB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <Distance>k__BackingField;

		[Token(Token = "0x4000BB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		protected float scale;

		[Token(Token = "0x4000BB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Pose _frontPose;

		[Token(Token = "0x4000BB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Pose _rearPose;

		[Token(Token = "0x17000101")]
		public float Distance
		{
			[Token(Token = "0x60009FB")]
			[Address(RVA = "0xA107F4", Offset = "0xA107F4", VA = "0xA107F4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60009FC")]
			[Address(RVA = "0xA107FC", Offset = "0xA107FC", VA = "0xA107FC")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000102")]
		public float Scale
		{
			[Token(Token = "0x60009FD")]
			[Address(RVA = "0xA10804", Offset = "0xA10804", VA = "0xA10804")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60009FE")]
			[Address(RVA = "0xA1080C", Offset = "0xA1080C", VA = "0xA1080C")]
			set
			{
			}
		}

		[Token(Token = "0x60009FF")]
		[Address(RVA = "0xA103C4", Offset = "0xA103C4", VA = "0xA103C4", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000A00")]
		[Address(RVA = "0xA10814", Offset = "0xA10814", VA = "0xA10814")]
		public void UpdatePose(float distance, TrainCarBase train, Pose pose)
		{
		}

		[Token(Token = "0x6000A01")]
		[Address(RVA = "0xA10404", Offset = "0xA10404", VA = "0xA10404")]
		protected void UpdateCarPosition()
		{
		}

		[Token(Token = "0x6000A02")]
		[Address(RVA = "0xA10614", Offset = "0xA10614", VA = "0xA10614")]
		protected void RotateCarWheels()
		{
		}

		[Token(Token = "0x6000A03")]
		public abstract void UpdatePosition();

		[Token(Token = "0x6000A04")]
		[Address(RVA = "0xA10758", Offset = "0xA10758", VA = "0xA10758")]
		protected TrainCarBase()
		{
		}
	}
	[Token(Token = "0x20001BD")]
	public class TrainCrossingController : MonoBehaviour
	{
		[Token(Token = "0x20001BE")]
		private sealed class <AnimateCrossing>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000BBF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000BC0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000BC1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TrainCrossingController <>4__this;

			[Token(Token = "0x4000BC2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float animationLength;

			[Token(Token = "0x4000BC3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <animationEndTime>5__2;

			[Token(Token = "0x4000BC4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <lightBlinkDuration>5__3;

			[Token(Token = "0x4000BC5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <lightBlinkStartTime>5__4;

			[Token(Token = "0x4000BC6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float <lightBlinkEndTime>5__5;

			[Token(Token = "0x4000BC7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Material <lightToBlinkOn>5__6;

			[Token(Token = "0x4000BC8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Material <lightToBlinkOff>5__7;

			[Token(Token = "0x4000BC9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private Color <onColor>5__8;

			[Token(Token = "0x4000BCA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Color <offColor>5__9;

			[Token(Token = "0x17000103")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A12")]
				[Address(RVA = "0xA110E4", Offset = "0xA110E4", VA = "0xA110E4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000104")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A14")]
				[Address(RVA = "0xA1112C", Offset = "0xA1112C", VA = "0xA1112C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A0F")]
			[Address(RVA = "0xA10D58", Offset = "0xA10D58", VA = "0xA10D58")]
			[DebuggerHidden]
			public <AnimateCrossing>d__15(int <>1__state)
			{
			}

			[Token(Token = "0x6000A10")]
			[Address(RVA = "0xA10ECC", Offset = "0xA10ECC", VA = "0xA10ECC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A11")]
			[Address(RVA = "0xA10ED0", Offset = "0xA10ED0", VA = "0xA10ED0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A13")]
			[Address(RVA = "0xA110EC", Offset = "0xA110EC", VA = "0xA110EC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000BB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AudioSource _audioSource;

		[Token(Token = "0x4000BB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioClip[] _crossingSounds;

		[Token(Token = "0x4000BB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MeshRenderer _lightSide1Renderer;

		[Token(Token = "0x4000BB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private MeshRenderer _lightSide2Renderer;

		[Token(Token = "0x4000BB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SelectionCylinder _selectionCylinder;

		[Token(Token = "0x4000BBA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material _lightsSide1Mat;

		[Token(Token = "0x4000BBB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Material _lightsSide2Mat;

		[Token(Token = "0x4000BBC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int _colorId;

		[Token(Token = "0x4000BBD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Coroutine _xingAnimationCr;

		[Token(Token = "0x4000BBE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private InteractableTool _toolInteractingWithMe;

		[Token(Token = "0x6000A06")]
		[Address(RVA = "0xA10984", Offset = "0xA10984", VA = "0xA10984")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000A07")]
		[Address(RVA = "0xA109E0", Offset = "0xA109E0", VA = "0xA109E0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000A08")]
		[Address(RVA = "0xA10AB8", Offset = "0xA10AB8", VA = "0xA10AB8")]
		public void CrossingButtonStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x6000A09")]
		[Address(RVA = "0xA10C0C", Offset = "0xA10C0C", VA = "0xA10C0C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A0A")]
		[Address(RVA = "0xA10B14", Offset = "0xA10B14", VA = "0xA10B14")]
		private void ActivateTrainCrossing()
		{
		}

		[Token(Token = "0x6000A0B")]
		[Address(RVA = "0xA10CD4", Offset = "0xA10CD4", VA = "0xA10CD4")]
		private IEnumerator AnimateCrossing(float animationLength)
		{
			return null;
		}

		[Token(Token = "0x6000A0C")]
		[Address(RVA = "0xA10D80", Offset = "0xA10D80", VA = "0xA10D80")]
		private void AffectMaterials(Material[] materials, Color newColor)
		{
		}

		[Token(Token = "0x6000A0D")]
		[Address(RVA = "0xA10E18", Offset = "0xA10E18", VA = "0xA10E18")]
		private void ToggleLightObjects(bool enableState)
		{
		}

		[Token(Token = "0x6000A0E")]
		[Address(RVA = "0xA10E74", Offset = "0xA10E74", VA = "0xA10E74")]
		public TrainCrossingController()
		{
		}
	}
	[Token(Token = "0x20001BF")]
	public class TrainLocomotive : TrainCarBase
	{
		[Token(Token = "0x20001C0")]
		private enum EngineSoundState
		{
			[Token(Token = "0x4000BE9")]
			Start,
			[Token(Token = "0x4000BEA")]
			AccelerateOrSetProperSpeed,
			[Token(Token = "0x4000BEB")]
			Stop
		}

		[Token(Token = "0x20001C1")]
		private sealed class <StartStopTrain>d__34 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000BEC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000BED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000BEE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool startTrain;

			[Token(Token = "0x4000BEF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public TrainLocomotive <>4__this;

			[Token(Token = "0x4000BF0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <endSpeed>5__2;

			[Token(Token = "0x4000BF1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <timePeriodForSpeedChange>5__3;

			[Token(Token = "0x4000BF2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float <startTime>5__4;

			[Token(Token = "0x4000BF3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float <endTime>5__5;

			[Token(Token = "0x4000BF4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private float <startSpeed>5__6;

			[Token(Token = "0x17000105")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A27")]
				[Address(RVA = "0xA119C4", Offset = "0xA119C4", VA = "0xA119C4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000106")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A29")]
				[Address(RVA = "0xA11A0C", Offset = "0xA11A0C", VA = "0xA11A0C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A24")]
			[Address(RVA = "0xA113D4", Offset = "0xA113D4", VA = "0xA113D4")]
			[DebuggerHidden]
			public <StartStopTrain>d__34(int <>1__state)
			{
			}

			[Token(Token = "0x6000A25")]
			[Address(RVA = "0xA1179C", Offset = "0xA1179C", VA = "0xA1179C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A26")]
			[Address(RVA = "0xA117A0", Offset = "0xA117A0", VA = "0xA117A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A28")]
			[Address(RVA = "0xA119CC", Offset = "0xA119CC", VA = "0xA119CC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000BCB")]
		private const float MIN_SPEED = 0.2f;

		[Token(Token = "0x4000BCC")]
		private const float MAX_SPEED = 2.7f;

		[Token(Token = "0x4000BCD")]
		private const float SMOKE_SPEED_MULTIPLIER = 8f;

		[Token(Token = "0x4000BCE")]
		private const int MAX_PARTICLES_MULTIPLIER = 3;

		[Token(Token = "0x4000BCF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Range(0.2f, 2.7f)]
		[SerializeField]
		protected float _initialSpeed;

		[Token(Token = "0x4000BD0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _startStopButton;

		[Token(Token = "0x4000BD1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _decreaseSpeedButton;

		[Token(Token = "0x4000BD2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _increaseSpeedButton;

		[Token(Token = "0x4000BD3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _smokeButton;

		[Token(Token = "0x4000BD4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _whistleButton;

		[Token(Token = "0x4000BD5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _reverseButton;

		[Token(Token = "0x4000BD6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private AudioSource _whistleAudioSource;

		[Token(Token = "0x4000BD7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private AudioClip _whistleSound;

		[Token(Token = "0x4000BD8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private AudioSource _engineAudioSource;

		[Token(Token = "0x4000BD9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private AudioClip[] _accelerationSounds;

		[Token(Token = "0x4000BDA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private AudioClip[] _decelerationSounds;

		[Token(Token = "0x4000BDB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private AudioClip _startUpSound;

		[Token(Token = "0x4000BDC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private AudioSource _smokeStackAudioSource;

		[Token(Token = "0x4000BDD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private AudioClip _smokeSound;

		[Token(Token = "0x4000BDE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private ParticleSystem _smoke1;

		[Token(Token = "0x4000BDF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private ParticleSystem _smoke2;

		[Token(Token = "0x4000BE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private TrainCarBase[] _childCars;

		[Token(Token = "0x4000BE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool _isMoving;

		[Token(Token = "0x4000BE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE1")]
		private bool _reverse;

		[Token(Token = "0x4000BE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private float _currentSpeed;

		[Token(Token = "0x4000BE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float _speedDiv;

		[Token(Token = "0x4000BE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float _standardRateOverTimeMultiplier;

		[Token(Token = "0x4000BE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private int _standardMaxParticles;

		[Token(Token = "0x4000BE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Coroutine _startStopTrainCr;

		[Token(Token = "0x6000A15")]
		[Address(RVA = "0xA11134", Offset = "0xA11134", VA = "0xA11134")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A16")]
		[Address(RVA = "0xA11290", Offset = "0xA11290", VA = "0xA11290")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A17")]
		[Address(RVA = "0xA1129C", Offset = "0xA1129C", VA = "0xA1129C", Slot = "5")]
		public override void UpdatePosition()
		{
		}

		[Token(Token = "0x6000A18")]
		[Address(RVA = "0xA0D888", Offset = "0xA0D888", VA = "0xA0D888")]
		public void StartStopStateChanged()
		{
		}

		[Token(Token = "0x6000A19")]
		[Address(RVA = "0xA11208", Offset = "0xA11208", VA = "0xA11208")]
		private IEnumerator StartStopTrain(bool startTrain)
		{
			return null;
		}

		[Token(Token = "0x6000A1A")]
		[Address(RVA = "0xA113FC", Offset = "0xA113FC", VA = "0xA113FC")]
		private float PlayEngineSound(EngineSoundState engineSoundState)
		{
			return default(float);
		}

		[Token(Token = "0x6000A1B")]
		[Address(RVA = "0xA11374", Offset = "0xA11374", VA = "0xA11374")]
		private void UpdateDistance()
		{
		}

		[Token(Token = "0x6000A1C")]
		[Address(RVA = "0xA0D914", Offset = "0xA0D914", VA = "0xA0D914")]
		public void DecreaseSpeedStateChanged()
		{
		}

		[Token(Token = "0x6000A1D")]
		[Address(RVA = "0xA0D9A4", Offset = "0xA0D9A4", VA = "0xA0D9A4")]
		public void IncreaseSpeedStateChanged()
		{
		}

		[Token(Token = "0x6000A1E")]
		[Address(RVA = "0xA11610", Offset = "0xA11610", VA = "0xA11610")]
		private void UpdateSmokeEmissionBasedOnSpeed()
		{
		}

		[Token(Token = "0x6000A1F")]
		[Address(RVA = "0xA11704", Offset = "0xA11704", VA = "0xA11704")]
		private float GetCurrentSmokeEmission()
		{
			return default(float);
		}

		[Token(Token = "0x6000A20")]
		[Address(RVA = "0xA0DA34", Offset = "0xA0DA34", VA = "0xA0DA34")]
		public void SmokeButtonStateChanged()
		{
		}

		[Token(Token = "0x6000A21")]
		[Address(RVA = "0xA0DAE0", Offset = "0xA0DAE0", VA = "0xA0DAE0")]
		public void WhistleButtonStateChanged()
		{
		}

		[Token(Token = "0x6000A22")]
		[Address(RVA = "0xA0DBC0", Offset = "0xA0DBC0", VA = "0xA0DBC0")]
		public void ReverseButtonStateChanged()
		{
		}

		[Token(Token = "0x6000A23")]
		[Address(RVA = "0xA11740", Offset = "0xA11740", VA = "0xA11740")]
		public TrainLocomotive()
		{
		}
	}
	[Token(Token = "0x20001C2")]
	public class TrainTrack : MonoBehaviour
	{
		[Token(Token = "0x4000BF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _gridSize;

		[Token(Token = "0x4000BF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private int _subDivCount;

		[Token(Token = "0x4000BF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _segmentParent;

		[Token(Token = "0x4000BF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _trainParent;

		[Token(Token = "0x4000BF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _regnerateTrackMeshOnAwake;

		[Token(Token = "0x4000BFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float _trainLength;

		[Token(Token = "0x4000BFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TrackSegment[] _trackSegments;

		[Token(Token = "0x17000107")]
		public float TrackLength
		{
			[Token(Token = "0x6000A2A")]
			[Address(RVA = "0xA11A14", Offset = "0xA11A14", VA = "0xA11A14")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A2B")]
			[Address(RVA = "0xA11A1C", Offset = "0xA11A1C", VA = "0xA11A1C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000A2C")]
		[Address(RVA = "0xA11A24", Offset = "0xA11A24", VA = "0xA11A24")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000A2D")]
		[Address(RVA = "0xA1087C", Offset = "0xA1087C", VA = "0xA1087C")]
		public TrackSegment GetSegment(float distance)
		{
			return null;
		}

		[Token(Token = "0x6000A2E")]
		[Address(RVA = "0xA11A28", Offset = "0xA11A28", VA = "0xA11A28")]
		public void Regenerate()
		{
		}

		[Token(Token = "0x6000A2F")]
		[Address(RVA = "0xA11C20", Offset = "0xA11C20", VA = "0xA11C20")]
		private void SetScale(float ratio)
		{
		}

		[Token(Token = "0x6000A30")]
		[Address(RVA = "0xA11D00", Offset = "0xA11D00", VA = "0xA11D00")]
		public TrainTrack()
		{
		}
	}
	[Token(Token = "0x20001C3")]
	public class Pose
	{
		[Token(Token = "0x4000BFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 Position;

		[Token(Token = "0x4000BFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion Rotation;

		[Token(Token = "0x6000A31")]
		[Address(RVA = "0xA0F904", Offset = "0xA0F904", VA = "0xA0F904")]
		public Pose()
		{
		}
	}
	[Token(Token = "0x20001C4")]
	public class WindmillBladesController : MonoBehaviour
	{
		[Token(Token = "0x20001C5")]
		private sealed class <LerpToSpeed>d__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000C09")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000C0A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000C0B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WindmillBladesController <>4__this;

			[Token(Token = "0x4000C0C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float goalSpeed;

			[Token(Token = "0x4000C0D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <totalTime>5__2;

			[Token(Token = "0x4000C0E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <startSpeed>5__3;

			[Token(Token = "0x17000109")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A3E")]
				[Address(RVA = "0xA122AC", Offset = "0xA122AC", VA = "0xA122AC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700010A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A40")]
				[Address(RVA = "0xA122F4", Offset = "0xA122F4", VA = "0xA122F4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A3B")]
			[Address(RVA = "0xA11F94", Offset = "0xA11F94", VA = "0xA11F94")]
			[DebuggerHidden]
			public <LerpToSpeed>d__17(int <>1__state)
			{
			}

			[Token(Token = "0x6000A3C")]
			[Address(RVA = "0xA12108", Offset = "0xA12108", VA = "0xA12108", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A3D")]
			[Address(RVA = "0xA1210C", Offset = "0xA1210C", VA = "0xA1210C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A3F")]
			[Address(RVA = "0xA122B4", Offset = "0xA122B4", VA = "0xA122B4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20001C6")]
		private sealed class <PlaySoundDelayed>d__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000C0F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000C10")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000C11")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WindmillBladesController <>4__this;

			[Token(Token = "0x4000C12")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public AudioClip initial;

			[Token(Token = "0x4000C13")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float timeDelayAfterInitial;

			[Token(Token = "0x4000C14")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public AudioClip clip;

			[Token(Token = "0x1700010B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A44")]
				[Address(RVA = "0xA123D0", Offset = "0xA123D0", VA = "0xA123D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700010C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A46")]
				[Address(RVA = "0xA12418", Offset = "0xA12418", VA = "0xA12418", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A41")]
			[Address(RVA = "0xA12070", Offset = "0xA12070", VA = "0xA12070")]
			[DebuggerHidden]
			public <PlaySoundDelayed>d__18(int <>1__state)
			{
			}

			[Token(Token = "0x6000A42")]
			[Address(RVA = "0xA122FC", Offset = "0xA122FC", VA = "0xA122FC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A43")]
			[Address(RVA = "0xA12300", Offset = "0xA12300", VA = "0xA12300", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A45")]
			[Address(RVA = "0xA123D8", Offset = "0xA123D8", VA = "0xA123D8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000BFE")]
		private const float MAX_TIME = 1f;

		[Token(Token = "0x4000BFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AudioSource _audioSource;

		[Token(Token = "0x4000C00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioClip _windMillRotationSound;

		[Token(Token = "0x4000C01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AudioClip _windMillStartSound;

		[Token(Token = "0x4000C02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AudioClip _windMillStopSound;

		[Token(Token = "0x4000C03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool <IsMoving>k__BackingField;

		[Token(Token = "0x4000C04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float _currentSpeed;

		[Token(Token = "0x4000C05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Coroutine _lerpSpeedCoroutine;

		[Token(Token = "0x4000C06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Coroutine _audioChangeCr;

		[Token(Token = "0x4000C07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion _originalRotation;

		[Token(Token = "0x4000C08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float _rotAngle;

		[Token(Token = "0x17000108")]
		public bool IsMoving
		{
			[Token(Token = "0x6000A32")]
			[Address(RVA = "0xA11D1C", Offset = "0xA11D1C", VA = "0xA11D1C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A33")]
			[Address(RVA = "0xA11D24", Offset = "0xA11D24", VA = "0xA11D24")]
			private set
			{
			}
		}

		[Token(Token = "0x6000A34")]
		[Address(RVA = "0xA11D30", Offset = "0xA11D30", VA = "0xA11D30")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A35")]
		[Address(RVA = "0xA11D60", Offset = "0xA11D60", VA = "0xA11D60")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A36")]
		[Address(RVA = "0xA11EA0", Offset = "0xA11EA0", VA = "0xA11EA0")]
		public void SetMoveState(bool newMoveState, float goalSpeed)
		{
		}

		[Token(Token = "0x6000A37")]
		[Address(RVA = "0xA11F10", Offset = "0xA11F10", VA = "0xA11F10")]
		private IEnumerator LerpToSpeed(float goalSpeed)
		{
			return null;
		}

		[Token(Token = "0x6000A38")]
		[Address(RVA = "0xA11FBC", Offset = "0xA11FBC", VA = "0xA11FBC")]
		private IEnumerator PlaySoundDelayed(AudioClip initial, AudioClip clip, float timeDelayAfterInitial)
		{
			return null;
		}

		[Token(Token = "0x6000A39")]
		[Address(RVA = "0xA12098", Offset = "0xA12098", VA = "0xA12098")]
		private void PlaySound(AudioClip clip, bool loop = false)
		{
		}

		[Token(Token = "0x6000A3A")]
		[Address(RVA = "0xA12100", Offset = "0xA12100", VA = "0xA12100")]
		public WindmillBladesController()
		{
		}
	}
	[Token(Token = "0x20001C7")]
	public class WindmillController : MonoBehaviour
	{
		[Token(Token = "0x4000C15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _startStopButton;

		[Token(Token = "0x4000C16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _maxSpeed;

		[Token(Token = "0x4000C17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SelectionCylinder _selectionCylinder;

		[Token(Token = "0x4000C18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WindmillBladesController _bladesRotation;

		[Token(Token = "0x4000C19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private InteractableTool _toolInteractingWithMe;

		[Token(Token = "0x6000A47")]
		[Address(RVA = "0xA12420", Offset = "0xA12420", VA = "0xA12420")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000A48")]
		[Address(RVA = "0xA12494", Offset = "0xA12494", VA = "0xA12494")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000A49")]
		[Address(RVA = "0xA1255C", Offset = "0xA1255C", VA = "0xA1255C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000A4A")]
		[Address(RVA = "0xA1266C", Offset = "0xA1266C", VA = "0xA1266C")]
		private void StartStopStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x6000A4B")]
		[Address(RVA = "0xA126E8", Offset = "0xA126E8", VA = "0xA126E8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A4C")]
		[Address(RVA = "0xA127B0", Offset = "0xA127B0", VA = "0xA127B0")]
		public WindmillController()
		{
		}
	}
	[Token(Token = "0x20001C8")]
	public class OVROverlaySample : MonoBehaviour
	{
		[Token(Token = "0x20001C9")]
		private sealed class <WaitforOVROverlay>d__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000C32")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000C33")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000C34")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OVROverlaySample <>4__this;

			[Token(Token = "0x1700010D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A60")]
				[Address(RVA = "0xA13E40", Offset = "0xA13E40", VA = "0xA13E40", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700010E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A62")]
				[Address(RVA = "0xA13E88", Offset = "0xA13E88", VA = "0xA13E88", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A5D")]
			[Address(RVA = "0xA134D0", Offset = "0xA134D0", VA = "0xA134D0")]
			[DebuggerHidden]
			public <WaitforOVROverlay>d__30(int <>1__state)
			{
			}

			[Token(Token = "0x6000A5E")]
			[Address(RVA = "0xA13C44", Offset = "0xA13C44", VA = "0xA13C44", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A5F")]
			[Address(RVA = "0xA13C48", Offset = "0xA13C48", VA = "0xA13C48", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A61")]
			[Address(RVA = "0xA13E48", Offset = "0xA13E48", VA = "0xA13E48", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000C1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool inMenu;

		[Token(Token = "0x4000C1B")]
		private const string ovrOverlayID = "OVROverlayID";

		[Token(Token = "0x4000C1C")]
		private const string applicationID = "ApplicationID";

		[Token(Token = "0x4000C1D")]
		private const string noneID = "NoneID";

		[Token(Token = "0x4000C1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Toggle applicationRadioButton;

		[Token(Token = "0x4000C1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Toggle noneRadioButton;

		[Token(Token = "0x4000C20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject mainCamera;

		[Token(Token = "0x4000C21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject uiCamera;

		[Token(Token = "0x4000C22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public GameObject uiGeoParent;

		[Token(Token = "0x4000C23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public GameObject worldspaceGeoParent;

		[Token(Token = "0x4000C24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public OVROverlay cameraRenderOverlay;

		[Token(Token = "0x4000C25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public OVROverlay renderingLabelOverlay;

		[Token(Token = "0x4000C26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Texture applicationLabelTexture;

		[Token(Token = "0x4000C27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Texture compositorLabelTexture;

		[Token(Token = "0x4000C28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public GameObject prefabForLevelLoadSim;

		[Token(Token = "0x4000C29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public OVROverlay cubemapOverlay;

		[Token(Token = "0x4000C2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public OVROverlay loadingTextQuadOverlay;

		[Token(Token = "0x4000C2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float distanceFromCamToLoadText;

		[Token(Token = "0x4000C2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float cubeSpawnRadius;

		[Token(Token = "0x4000C2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float heightBetweenItems;

		[Token(Token = "0x4000C2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public int numObjectsPerLevel;

		[Token(Token = "0x4000C2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public int numLevels;

		[Token(Token = "0x4000C30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public int numLoopsTrigger;

		[Token(Token = "0x4000C31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private List<GameObject> spawnedCubes;

		[Token(Token = "0x6000A4D")]
		[Address(RVA = "0xA127C0", Offset = "0xA127C0", VA = "0xA127C0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A4E")]
		[Address(RVA = "0xA13000", Offset = "0xA13000", VA = "0xA13000")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A4F")]
		[Address(RVA = "0xA13128", Offset = "0xA13128", VA = "0xA13128")]
		private void ActivateWorldGeo()
		{
		}

		[Token(Token = "0x6000A50")]
		[Address(RVA = "0xA13258", Offset = "0xA13258", VA = "0xA13258")]
		private void ActivateOVROverlay()
		{
		}

		[Token(Token = "0x6000A51")]
		[Address(RVA = "0xA13388", Offset = "0xA13388", VA = "0xA13388")]
		private void ActivateNone()
		{
		}

		[Token(Token = "0x6000A52")]
		[Address(RVA = "0xA13108", Offset = "0xA13108", VA = "0xA13108")]
		private void TriggerLoad()
		{
		}

		[Token(Token = "0x6000A53")]
		[Address(RVA = "0xA1345C", Offset = "0xA1345C", VA = "0xA1345C")]
		private IEnumerator WaitforOVROverlay()
		{
			return null;
		}

		[Token(Token = "0x6000A54")]
		[Address(RVA = "0xA134F8", Offset = "0xA134F8", VA = "0xA134F8")]
		private void TriggerUnload()
		{
		}

		[Token(Token = "0x6000A55")]
		[Address(RVA = "0xA12C30", Offset = "0xA12C30", VA = "0xA12C30")]
		private void CameraAndRenderTargetSetup()
		{
		}

		[Token(Token = "0x6000A56")]
		[Address(RVA = "0xA13640", Offset = "0xA13640", VA = "0xA13640")]
		private void SimulateLevelLoad()
		{
		}

		[Token(Token = "0x6000A57")]
		[Address(RVA = "0xA13520", Offset = "0xA13520", VA = "0xA13520")]
		private void ClearObjects()
		{
		}

		[Token(Token = "0x6000A58")]
		[Address(RVA = "0xA139C8", Offset = "0xA139C8", VA = "0xA139C8")]
		public void RadioPressed(string radioLabel, string group, Toggle t)
		{
		}

		[Token(Token = "0x6000A59")]
		[Address(RVA = "0xA13AB4", Offset = "0xA13AB4", VA = "0xA13AB4")]
		public OVROverlaySample()
		{
		}

		[Token(Token = "0x6000A5A")]
		[Address(RVA = "0xA13B48", Offset = "0xA13B48", VA = "0xA13B48")]
		private void <Start>b__24_0(Toggle t)
		{
		}

		[Token(Token = "0x6000A5B")]
		[Address(RVA = "0xA13B9C", Offset = "0xA13B9C", VA = "0xA13B9C")]
		private void <Start>b__24_1(Toggle t)
		{
		}

		[Token(Token = "0x6000A5C")]
		[Address(RVA = "0xA13BF0", Offset = "0xA13BF0", VA = "0xA13BF0")]
		private void <Start>b__24_2(Toggle t)
		{
		}
	}
}
namespace OVRTouchSample
{
	[Token(Token = "0x20001CA")]
	[RequireComponent(typeof(OVRGrabber))]
	public class Hand : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20001CB")]
		private sealed class <>c
		{
			[Token(Token = "0x4000C51")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000C52")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<Collider, bool> <>9__28_0;

			[Token(Token = "0x6000A70")]
			[Address(RVA = "0xA14C98", Offset = "0xA14C98", VA = "0xA14C98")]
			public <>c()
			{
			}

			[Token(Token = "0x6000A71")]
			[Address(RVA = "0xA14CA0", Offset = "0xA14CA0", VA = "0xA14CA0")]
			internal bool <Start>b__28_0(Collider childCollider)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000C35")]
		public const string ANIM_LAYER_NAME_POINT = "Point Layer";

		[Token(Token = "0x4000C36")]
		public const string ANIM_LAYER_NAME_THUMB = "Thumb Layer";

		[Token(Token = "0x4000C37")]
		public const string ANIM_PARAM_NAME_FLEX = "Flex";

		[Token(Token = "0x4000C38")]
		public const string ANIM_PARAM_NAME_POSE = "Pose";

		[Token(Token = "0x4000C39")]
		public const float THRESH_COLLISION_FLEX = 0.9f;

		[Token(Token = "0x4000C3A")]
		public const float INPUT_RATE_CHANGE = 20f;

		[Token(Token = "0x4000C3B")]
		public const float COLLIDER_SCALE_MIN = 0.01f;

		[Token(Token = "0x4000C3C")]
		public const float COLLIDER_SCALE_MAX = 1f;

		[Token(Token = "0x4000C3D")]
		public const float COLLIDER_SCALE_PER_SECOND = 1f;

		[Token(Token = "0x4000C3E")]
		public const float TRIGGER_DEBOUNCE_TIME = 0.05f;

		[Token(Token = "0x4000C3F")]
		public const float THUMB_DEBOUNCE_TIME = 0.15f;

		[Token(Token = "0x4000C40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private OVRInput.Controller m_controller;

		[Token(Token = "0x4000C41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Animator m_animator;

		[Token(Token = "0x4000C42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private HandPose m_defaultGrabPose;

		[Token(Token = "0x4000C43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Collider[] m_colliders;

		[Token(Token = "0x4000C44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool m_collisionEnabled;

		[Token(Token = "0x4000C45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private OVRGrabber m_grabber;

		[Token(Token = "0x4000C46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<Renderer> m_showAfterInputFocusAcquired;

		[Token(Token = "0x4000C47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int m_animLayerIndexThumb;

		[Token(Token = "0x4000C48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int m_animLayerIndexPoint;

		[Token(Token = "0x4000C49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int m_animParamIndexFlex;

		[Token(Token = "0x4000C4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int m_animParamIndexPose;

		[Token(Token = "0x4000C4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool m_isPointing;

		[Token(Token = "0x4000C4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool m_isGivingThumbsUp;

		[Token(Token = "0x4000C4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float m_pointBlend;

		[Token(Token = "0x4000C4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float m_thumbsUpBlend;

		[Token(Token = "0x4000C4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool m_restoreOnInputAcquired;

		[Token(Token = "0x4000C50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float m_collisionScaleCurrent;

		[Token(Token = "0x6000A63")]
		[Address(RVA = "0xA13E90", Offset = "0xA13E90", VA = "0xA13E90")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000A64")]
		[Address(RVA = "0xA13EE8", Offset = "0xA13EE8", VA = "0xA13EE8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A65")]
		[Address(RVA = "0xA14338", Offset = "0xA14338", VA = "0xA14338")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000A66")]
		[Address(RVA = "0xA14424", Offset = "0xA14424", VA = "0xA14424")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A67")]
		[Address(RVA = "0xA14588", Offset = "0xA14588", VA = "0xA14588")]
		private void UpdateCapTouchStates()
		{
		}

		[Token(Token = "0x6000A68")]
		[Address(RVA = "0xA14858", Offset = "0xA14858", VA = "0xA14858")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000A69")]
		[Address(RVA = "0xA1493C", Offset = "0xA1493C", VA = "0xA1493C")]
		private void OnInputFocusLost()
		{
		}

		[Token(Token = "0x6000A6A")]
		[Address(RVA = "0xA14AEC", Offset = "0xA14AEC", VA = "0xA14AEC")]
		private void OnInputFocusAcquired()
		{
		}

		[Token(Token = "0x6000A6B")]
		[Address(RVA = "0xA14614", Offset = "0xA14614", VA = "0xA14614")]
		private float InputValueRateChange(bool isDown, float value)
		{
			return default(float);
		}

		[Token(Token = "0x6000A6C")]
		[Address(RVA = "0xA14668", Offset = "0xA14668", VA = "0xA14668")]
		private void UpdateAnimStates()
		{
		}

		[Token(Token = "0x6000A6D")]
		[Address(RVA = "0xA141F8", Offset = "0xA141F8", VA = "0xA141F8")]
		private void CollisionEnable(bool enabled)
		{
		}

		[Token(Token = "0x6000A6E")]
		[Address(RVA = "0xA14C10", Offset = "0xA14C10", VA = "0xA14C10")]
		public Hand()
		{
		}
	}
	[Token(Token = "0x20001CC")]
	public enum HandPoseId
	{
		[Token(Token = "0x4000C54")]
		Default,
		[Token(Token = "0x4000C55")]
		Generic,
		[Token(Token = "0x4000C56")]
		PingPongBall,
		[Token(Token = "0x4000C57")]
		Controller
	}
	[Token(Token = "0x20001CD")]
	public class HandPose : MonoBehaviour
	{
		[Token(Token = "0x4000C58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_allowPointing;

		[Token(Token = "0x4000C59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[SerializeField]
		private bool m_allowThumbsUp;

		[Token(Token = "0x4000C5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private HandPoseId m_poseId;

		[Token(Token = "0x1700010F")]
		public bool AllowPointing
		{
			[Token(Token = "0x6000A72")]
			[Address(RVA = "0xA14CC8", Offset = "0xA14CC8", VA = "0xA14CC8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000110")]
		public bool AllowThumbsUp
		{
			[Token(Token = "0x6000A73")]
			[Address(RVA = "0xA14CD0", Offset = "0xA14CD0", VA = "0xA14CD0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000111")]
		public HandPoseId PoseId
		{
			[Token(Token = "0x6000A74")]
			[Address(RVA = "0xA14CD8", Offset = "0xA14CD8", VA = "0xA14CD8")]
			get
			{
				return default(HandPoseId);
			}
		}

		[Token(Token = "0x6000A75")]
		[Address(RVA = "0xA14CE0", Offset = "0xA14CE0", VA = "0xA14CE0")]
		public HandPose()
		{
		}
	}
	[Token(Token = "0x20001CE")]
	public class TouchController : MonoBehaviour
	{
		[Token(Token = "0x4000C5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private OVRInput.Controller m_controller;

		[Token(Token = "0x4000C5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Animator m_animator;

		[Token(Token = "0x4000C5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool m_restoreOnInputAcquired;

		[Token(Token = "0x6000A76")]
		[Address(RVA = "0xA14CE8", Offset = "0xA14CE8", VA = "0xA14CE8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A77")]
		[Address(RVA = "0xA14FB4", Offset = "0xA14FB4", VA = "0xA14FB4")]
		private void OnInputFocusLost()
		{
		}

		[Token(Token = "0x6000A78")]
		[Address(RVA = "0xA15004", Offset = "0xA15004", VA = "0xA15004")]
		private void OnInputFocusAcquired()
		{
		}

		[Token(Token = "0x6000A79")]
		[Address(RVA = "0xA1503C", Offset = "0xA1503C", VA = "0xA1503C")]
		public TouchController()
		{
		}
	}
}
namespace MRCHelpers
{
	[Token(Token = "0x20001CF")]
	public class CopyTransform : MonoBehaviour
	{
		[Token(Token = "0x4000C5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform m_originalTransform;

		[Token(Token = "0x6000A7A")]
		[Address(RVA = "0xA15044", Offset = "0xA15044", VA = "0xA15044")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A7B")]
		[Address(RVA = "0xA150C0", Offset = "0xA150C0", VA = "0xA150C0")]
		public CopyTransform()
		{
		}
	}
	[Token(Token = "0x20001D0")]
	public class OVRMixedRealityCaptureTestMod : MonoBehaviour
	{
		[Token(Token = "0x4000C5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool inited;

		[Token(Token = "0x4000C60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Camera defaultExternalCamera;

		[Token(Token = "0x6000A7C")]
		[Address(RVA = "0xA150C8", Offset = "0xA150C8", VA = "0xA150C8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A7D")]
		[Address(RVA = "0xA15178", Offset = "0xA15178", VA = "0xA15178")]
		private void Initialize()
		{
		}

		[Token(Token = "0x6000A7E")]
		[Address(RVA = "0xA153A8", Offset = "0xA153A8", VA = "0xA153A8")]
		private void UpdateDefaultExternalCamera()
		{
		}

		[Token(Token = "0x6000A7F")]
		[Address(RVA = "0xA15728", Offset = "0xA15728", VA = "0xA15728")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A80")]
		[Address(RVA = "0xA15860", Offset = "0xA15860", VA = "0xA15860")]
		public OVRMixedRealityCaptureTestMod()
		{
		}
	}
	[Token(Token = "0x20001D1")]
	public class RemoveMRCamerasTracking : MonoBehaviour
	{
		[Token(Token = "0x4000C61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int frames;

		[Token(Token = "0x4000C62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Text debugText;

		[Token(Token = "0x6000A81")]
		[Address(RVA = "0xA15868", Offset = "0xA15868", VA = "0xA15868")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A82")]
		[Address(RVA = "0xA15880", Offset = "0xA15880", VA = "0xA15880")]
		private void RemoveCamerasTracking()
		{
		}

		[Token(Token = "0x6000A83")]
		[Address(RVA = "0xA159C0", Offset = "0xA159C0", VA = "0xA159C0")]
		public RemoveMRCamerasTracking()
		{
		}
	}
}
namespace creepycat.scifikitvol3
{
	[Token(Token = "0x20001D2")]
	public class ScrollTexture : MonoBehaviour
	{
		[Token(Token = "0x4000C63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float scrollSpeed;

		[Token(Token = "0x4000C64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Renderer rend;

		[Token(Token = "0x6000A84")]
		[Address(RVA = "0xA159D0", Offset = "0xA159D0", VA = "0xA159D0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A85")]
		[Address(RVA = "0xA15A28", Offset = "0xA15A28", VA = "0xA15A28")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A86")]
		[Address(RVA = "0xA15AA8", Offset = "0xA15AA8", VA = "0xA15AA8")]
		public ScrollTexture()
		{
		}
	}
	[Token(Token = "0x20001D3")]
	public class Turn_Move : MonoBehaviour
	{
		[Token(Token = "0x4000C65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float TurnX;

		[Token(Token = "0x4000C66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float TurnY;

		[Token(Token = "0x4000C67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float TurnZ;

		[Token(Token = "0x4000C68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float MoveX;

		[Token(Token = "0x4000C69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float MoveY;

		[Token(Token = "0x4000C6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float MoveZ;

		[Token(Token = "0x4000C6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool World;

		[Token(Token = "0x6000A87")]
		[Address(RVA = "0xA15AB8", Offset = "0xA15AB8", VA = "0xA15AB8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A88")]
		[Address(RVA = "0xA15B48", Offset = "0xA15B48", VA = "0xA15B48")]
		public Turn_Move()
		{
		}
	}
}
namespace UnityTemplateProject
{
	[Token(Token = "0x20001D4")]
	public class SimpleCameraController : MonoBehaviour
	{
		[Token(Token = "0x20001D5")]
		private class CameraState
		{
			[Token(Token = "0x4000C73")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float yaw;

			[Token(Token = "0x4000C74")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pitch;

			[Token(Token = "0x4000C75")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float roll;

			[Token(Token = "0x4000C76")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float x;

			[Token(Token = "0x4000C77")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float y;

			[Token(Token = "0x4000C78")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float z;

			[Token(Token = "0x6000A8D")]
			[Address(RVA = "0xA15BA4", Offset = "0xA15BA4", VA = "0xA15BA4")]
			public void SetFromTransform(Transform t)
			{
			}

			[Token(Token = "0x6000A8E")]
			[Address(RVA = "0xA160FC", Offset = "0xA160FC", VA = "0xA160FC")]
			public void Translate(Vector3 translation)
			{
			}

			[Token(Token = "0x6000A8F")]
			[Address(RVA = "0xA1617C", Offset = "0xA1617C", VA = "0xA1617C")]
			public void LerpTowards(CameraState target, float positionLerpPct, float rotationLerpPct)
			{
			}

			[Token(Token = "0x6000A90")]
			[Address(RVA = "0xA16204", Offset = "0xA16204", VA = "0xA16204")]
			public void UpdateTransform(Transform t)
			{
			}

			[Token(Token = "0x6000A91")]
			[Address(RVA = "0xA16428", Offset = "0xA16428", VA = "0xA16428")]
			public CameraState()
			{
			}
		}

		[Token(Token = "0x4000C6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CameraState m_TargetCameraState;

		[Token(Token = "0x4000C6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private CameraState m_InterpolatingCameraState;

		[Token(Token = "0x4000C6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float boost;

		[Token(Token = "0x4000C6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0.001f, 1f)]
		public float positionLerpTime;

		[Token(Token = "0x4000C70")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve mouseSensitivityCurve;

		[Token(Token = "0x4000C71")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0.001f, 1f)]
		public float rotationLerpTime;

		[Token(Token = "0x4000C72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool invertY;

		[Token(Token = "0x6000A89")]
		[Address(RVA = "0xA15B50", Offset = "0xA15B50", VA = "0xA15B50")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000A8A")]
		[Address(RVA = "0xA15C28", Offset = "0xA15C28", VA = "0xA15C28")]
		private Vector3 GetInputTranslationDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000A8B")]
		[Address(RVA = "0xA15E58", Offset = "0xA15E58", VA = "0xA15E58")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A8C")]
		[Address(RVA = "0xA1624C", Offset = "0xA1624C", VA = "0xA1624C")]
		public SimpleCameraController()
		{
		}
	}
}
namespace AmazingAssets.AdvancedDissolve
{
	[Token(Token = "0x20001D6")]
	[ExecuteAlways]
	public abstract class AdvancedDissolveController : MonoBehaviour
	{
		[Token(Token = "0x4000C79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AdvancedDissolveKeywords.GlobalControlID globalControlID;

		[Token(Token = "0x4000C7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Material[] materials;

		[Token(Token = "0x6000A92")]
		[Address(RVA = "0xA16430", Offset = "0xA16430", VA = "0xA16430", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000A93")]
		[Address(RVA = "0xA1643C", Offset = "0xA1643C", VA = "0xA1643C", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000A94")]
		public abstract void ForceUpdateShaderData();

		[Token(Token = "0x6000A95")]
		public abstract void ResetShaderData();

		[Token(Token = "0x6000A96")]
		[Address(RVA = "0xA16440", Offset = "0xA16440", VA = "0xA16440")]
		public void AddMaterialsFromSelection(GameObject[] selection)
		{
		}

		[Token(Token = "0x6000A97")]
		[Address(RVA = "0xA167AC", Offset = "0xA167AC", VA = "0xA167AC")]
		protected AdvancedDissolveController()
		{
		}
	}
	[Token(Token = "0x20001D7")]
	[ExecuteAlways]
	public class AdvancedDissolveGeometricCutoutController : AdvancedDissolveController
	{
		[Token(Token = "0x20001D8")]
		public enum UpdateMode
		{
			[Token(Token = "0x4000CA8")]
			OnFixedUpdate,
			[Token(Token = "0x4000CA9")]
			EveryFrame,
			[Token(Token = "0x4000CAA")]
			Manual
		}

		[Token(Token = "0x4000C7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateMode updateMode;

		[Token(Token = "0x4000C7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool drawGizmos;

		[Token(Token = "0x4000C7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AdvancedDissolveKeywords.CutoutGeometricType type;

		[Token(Token = "0x4000C7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public AdvancedDissolveKeywords.CutoutGeometricCount count;

		[Token(Token = "0x4000C7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AdvancedDissolveProperties.Cutout.Geometric.XYZAxis xyzAxis;

		[Token(Token = "0x4000C80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public AdvancedDissolveProperties.Cutout.Geometric.XYZStyle xyzStyle;

		[Token(Token = "0x4000C81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AdvancedDissolveProperties.Cutout.Geometric.XYZSpace xyzSpace;

		[Token(Token = "0x4000C82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float xyzRollout;

		[Token(Token = "0x4000C83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform xyzPivotPointTransform;

		[Token(Token = "0x4000C84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector3 xyzPivotPointPosition;

		[Token(Token = "0x4000C85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform target1StartPointTransform;

		[Token(Token = "0x4000C86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform target1EndPointTransform;

		[Token(Token = "0x4000C87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Vector3 target1StartPointPosition;

		[Token(Token = "0x4000C88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public Vector3 target1EndPointPosition;

		[Token(Token = "0x4000C89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float target1Radius;

		[Token(Token = "0x4000C8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public Vector3 target1Normal;

		[Token(Token = "0x4000C8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Vector3 target1Rotation;

		[Token(Token = "0x4000C8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public Vector3 target1Size;

		[Token(Token = "0x4000C8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Transform target2StartPointTransform;

		[Token(Token = "0x4000C8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform target2EndPointTransform;

		[Token(Token = "0x4000C8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Vector3 target2StartPointPosition;

		[Token(Token = "0x4000C90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public Vector3 target2EndPointPosition;

		[Token(Token = "0x4000C91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public float target2Radius;

		[Token(Token = "0x4000C92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public Vector3 target2Normal;

		[Token(Token = "0x4000C93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public Vector3 target2Rotation;

		[Token(Token = "0x4000C94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		public Vector3 target2Size;

		[Token(Token = "0x4000C95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public Transform target3StartPointTransform;

		[Token(Token = "0x4000C96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public Transform target3EndPointTransform;

		[Token(Token = "0x4000C97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public Vector3 target3StartPointPosition;

		[Token(Token = "0x4000C98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		public Vector3 target3EndPointPosition;

		[Token(Token = "0x4000C99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public float target3Radius;

		[Token(Token = "0x4000C9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		public Vector3 target3Normal;

		[Token(Token = "0x4000C9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public Vector3 target3Rotation;

		[Token(Token = "0x4000C9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		public Vector3 target3Size;

		[Token(Token = "0x4000C9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public Transform target4StartPointTransform;

		[Token(Token = "0x4000C9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public Transform target4EndPointTransform;

		[Token(Token = "0x4000C9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public Vector3 target4StartPointPosition;

		[Token(Token = "0x4000CA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		public Vector3 target4EndPointPosition;

		[Token(Token = "0x4000CA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		public float target4Radius;

		[Token(Token = "0x4000CA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		public Vector3 target4Normal;

		[Token(Token = "0x4000CA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public Vector3 target4Rotation;

		[Token(Token = "0x4000CA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
		public Vector3 target4Size;

		[Token(Token = "0x4000CA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		public bool invert;

		[Token(Token = "0x4000CA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
		public float noise;

		[Token(Token = "0x6000A98")]
		[Address(RVA = "0xA167B4", Offset = "0xA167B4", VA = "0xA167B4", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000A99")]
		[Address(RVA = "0xA167C0", Offset = "0xA167C0", VA = "0xA167C0", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000A9A")]
		[Address(RVA = "0xA17118", Offset = "0xA17118", VA = "0xA17118")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000A9B")]
		[Address(RVA = "0xA17128", Offset = "0xA17128", VA = "0xA17128", Slot = "6")]
		[ContextMenu("Force Update Geometric Cutout Controller")]
		public override void ForceUpdateShaderData()
		{
		}

		[Token(Token = "0x6000A9C")]
		[Address(RVA = "0xA1712C", Offset = "0xA1712C", VA = "0xA1712C", Slot = "7")]
		[ContextMenu("Reset Geometric Cutout Controller")]
		public override void ResetShaderData()
		{
		}

		[Token(Token = "0x6000A9D")]
		[Address(RVA = "0xA167F8", Offset = "0xA167F8", VA = "0xA167F8")]
		private void UpdateShaderData()
		{
		}

		[Token(Token = "0x6000A9E")]
		[Address(RVA = "0xA177BC", Offset = "0xA177BC", VA = "0xA177BC")]
		public Transform GetTargetStartPointTransform(AdvancedDissolveKeywords.CutoutGeometricCount countID)
		{
			return null;
		}

		[Token(Token = "0x6000A9F")]
		[Address(RVA = "0xA1780C", Offset = "0xA1780C", VA = "0xA1780C")]
		public Transform GetTargetEndPointTransform(AdvancedDissolveKeywords.CutoutGeometricCount countID)
		{
			return null;
		}

		[Token(Token = "0x6000AA0")]
		[Address(RVA = "0xA1785C", Offset = "0xA1785C", VA = "0xA1785C")]
		public Vector3 GetTargetStartPointPosition(AdvancedDissolveKeywords.CutoutGeometricCount countID)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000AA1")]
		[Address(RVA = "0xA17A0C", Offset = "0xA17A0C", VA = "0xA17A0C")]
		public Vector3 GetTargetEndPointPosition(AdvancedDissolveKeywords.CutoutGeometricCount countID)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000AA2")]
		[Address(RVA = "0xA17BBC", Offset = "0xA17BBC", VA = "0xA17BBC")]
		public float GetTargetRadius(AdvancedDissolveKeywords.CutoutGeometricCount countID)
		{
			return default(float);
		}

		[Token(Token = "0x6000AA3")]
		[Address(RVA = "0xA17C38", Offset = "0xA17C38", VA = "0xA17C38")]
		public Vector3 GetTargetNormal(AdvancedDissolveKeywords.CutoutGeometricCount countID)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000AA4")]
		[Address(RVA = "0xA17E88", Offset = "0xA17E88", VA = "0xA17E88")]
		public Vector3 GetTargetRotation(AdvancedDissolveKeywords.CutoutGeometricCount countID)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000AA5")]
		[Address(RVA = "0xA1805C", Offset = "0xA1805C", VA = "0xA1805C")]
		public Vector3 GetTargetSize(AdvancedDissolveKeywords.CutoutGeometricCount countID)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000AA6")]
		[Address(RVA = "0xA1820C", Offset = "0xA1820C", VA = "0xA1820C")]
		public void SetTargetStartPointTransform(AdvancedDissolveKeywords.CutoutGeometricCount countID, Transform transform)
		{
		}

		[Token(Token = "0x6000AA7")]
		[Address(RVA = "0xA1825C", Offset = "0xA1825C", VA = "0xA1825C")]
		public void SetTargetEndPointTransform(AdvancedDissolveKeywords.CutoutGeometricCount countID, Transform transform)
		{
		}

		[Token(Token = "0x6000AA8")]
		[Address(RVA = "0xA182AC", Offset = "0xA182AC", VA = "0xA182AC")]
		public void SetTargetStartPointPosition(AdvancedDissolveKeywords.CutoutGeometricCount countID, Vector3 position)
		{
		}

		[Token(Token = "0x6000AA9")]
		[Address(RVA = "0xA1830C", Offset = "0xA1830C", VA = "0xA1830C")]
		public void SetTargetEndPointPosition(AdvancedDissolveKeywords.CutoutGeometricCount countID, Vector3 position)
		{
		}

		[Token(Token = "0x6000AAA")]
		[Address(RVA = "0xA1836C", Offset = "0xA1836C", VA = "0xA1836C")]
		public void SetTargetRadius(AdvancedDissolveKeywords.CutoutGeometricCount countID, float radius)
		{
		}

		[Token(Token = "0x6000AAB")]
		[Address(RVA = "0xA183B4", Offset = "0xA183B4", VA = "0xA183B4")]
		public void SetTargetNormal(AdvancedDissolveKeywords.CutoutGeometricCount countID, Vector3 normal)
		{
		}

		[Token(Token = "0x6000AAC")]
		[Address(RVA = "0xA18414", Offset = "0xA18414", VA = "0xA18414")]
		public void SetTargetRotation(AdvancedDissolveKeywords.CutoutGeometricCount countID, Vector3 rotation)
		{
		}

		[Token(Token = "0x6000AAD")]
		[Address(RVA = "0xA18474", Offset = "0xA18474", VA = "0xA18474")]
		public void SetTargetSize(AdvancedDissolveKeywords.CutoutGeometricCount countID, Vector3 size)
		{
		}

		[Token(Token = "0x6000AAE")]
		[Address(RVA = "0xA17604", Offset = "0xA17604", VA = "0xA17604")]
		public void GetPlaneData(AdvancedDissolveKeywords.CutoutGeometricCount countID, out Vector3 position, out Vector3 normal)
		{
		}

		[Token(Token = "0x6000AAF")]
		[Address(RVA = "0xA17650", Offset = "0xA17650", VA = "0xA17650")]
		public void GetSphereData(AdvancedDissolveKeywords.CutoutGeometricCount countID, out Vector3 position, out float radius)
		{
		}

		[Token(Token = "0x6000AB0")]
		[Address(RVA = "0xA17698", Offset = "0xA17698", VA = "0xA17698")]
		public void GetCubeData(AdvancedDissolveKeywords.CutoutGeometricCount countID, out Vector3 position, out Vector3 rotation, out Vector3 size)
		{
		}

		[Token(Token = "0x6000AB1")]
		[Address(RVA = "0xA176FC", Offset = "0xA176FC", VA = "0xA176FC")]
		public void GetCapsuleData(AdvancedDissolveKeywords.CutoutGeometricCount countID, out Vector3 startPosition, out Vector3 endPosition, out float radius)
		{
		}

		[Token(Token = "0x6000AB2")]
		[Address(RVA = "0xA1775C", Offset = "0xA1775C", VA = "0xA1775C")]
		public void GetConeSmoothData(AdvancedDissolveKeywords.CutoutGeometricCount countID, out Vector3 startPosition, out Vector3 endPosition, out float radius)
		{
		}

		[Token(Token = "0x6000AB3")]
		[Address(RVA = "0xA184D4", Offset = "0xA184D4", VA = "0xA184D4")]
		public AdvancedDissolveGeometricCutoutController()
		{
		}
	}
	[Token(Token = "0x20001D9")]
	[ExecuteAlways]
	public class AdvancedDissolveKeywordsController : AdvancedDissolveController
	{
		[Token(Token = "0x4000CAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AdvancedDissolveKeywords.State state;

		[Token(Token = "0x4000CAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int previousState;

		[Token(Token = "0x4000CAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AdvancedDissolveKeywords.CutoutStandardSource cutoutStandardSource;

		[Token(Token = "0x4000CAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int previousCutoutStandardSource;

		[Token(Token = "0x4000CAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AdvancedDissolveKeywords.CutoutStandardSourceMapsMappingType cutoutStandardSourceMapsMappingType;

		[Token(Token = "0x4000CB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int previousCutoutStandardSourceMapsMappingType;

		[Token(Token = "0x4000CB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AdvancedDissolveKeywords.CutoutGeometricType cutoutGeometricType;

		[Token(Token = "0x4000CB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int previousCutoutGeometricType;

		[Token(Token = "0x4000CB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AdvancedDissolveKeywords.CutoutGeometricCount cutoutGeometricCount;

		[Token(Token = "0x4000CB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int previousCutoutGeometricCount;

		[Token(Token = "0x4000CB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AdvancedDissolveKeywords.EdgeBaseSource edgeBaseSource;

		[Token(Token = "0x4000CB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int previousEdgeBaseSource;

		[Token(Token = "0x4000CB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AdvancedDissolveKeywords.EdgeAdditionalColorSource edgeAdditionalColorSource;

		[Token(Token = "0x4000CB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int previousEdgeAdditionalColorSource;

		[Token(Token = "0x4000CB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AdvancedDissolveKeywords.EdgeUVDistortionSource edgeUVDistortionSource;

		[Token(Token = "0x4000CBA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private int previousEdgeUVDistortionSource;

		[Token(Token = "0x4000CBB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int previousGlobalControlID;

		[Token(Token = "0x6000AB4")]
		[Address(RVA = "0xA19768", Offset = "0xA19768", VA = "0xA19768", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000AB5")]
		[Address(RVA = "0xA1978C", Offset = "0xA1978C", VA = "0xA1978C", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000AB6")]
		[Address(RVA = "0xA1A064", Offset = "0xA1A064", VA = "0xA1A064", Slot = "6")]
		[ContextMenu("Force Update Keywords Controller")]
		public override void ForceUpdateShaderData()
		{
		}

		[Token(Token = "0x6000AB7")]
		[Address(RVA = "0xA1A090", Offset = "0xA1A090", VA = "0xA1A090", Slot = "7")]
		[ContextMenu("Reset Keywords Controller")]
		public override void ResetShaderData()
		{
		}

		[Token(Token = "0x6000AB8")]
		[Address(RVA = "0xA1A0BC", Offset = "0xA1A0BC", VA = "0xA1A0BC")]
		public AdvancedDissolveKeywordsController()
		{
		}
	}
	[Token(Token = "0x20001DA")]
	[ExecuteAlways]
	public class AdvancedDissolvePropertiesController : AdvancedDissolveController
	{
		[Token(Token = "0x20001DB")]
		public enum UpdateMode
		{
			[Token(Token = "0x4000CC4")]
			OnAwake,
			[Token(Token = "0x4000CC5")]
			OnFixedUpdate,
			[Token(Token = "0x4000CC6")]
			EveryFrame,
			[Token(Token = "0x4000CC7")]
			Manual
		}

		[Token(Token = "0x4000CBC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateMode updateMode;

		[Token(Token = "0x4000CBD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AdvancedDissolveProperties.Cutout.Standard cutoutStandard;

		[Token(Token = "0x4000CBE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AdvancedDissolveProperties.Cutout.Geometric cutoutGeometric;

		[Token(Token = "0x4000CBF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AdvancedDissolveProperties.Edge.Base edgeBase;

		[Token(Token = "0x4000CC0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AdvancedDissolveProperties.Edge.AdditionalColor edgeAdditionalColor;

		[Token(Token = "0x4000CC1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AdvancedDissolveProperties.Edge.UVDistortion edgeUVDistortion;

		[Token(Token = "0x4000CC2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AdvancedDissolveProperties.Edge.GlobalIllumination edgeGlobalIllumination;

		[Token(Token = "0x6000AB9")]
		[Address(RVA = "0xA1A0EC", Offset = "0xA1A0EC", VA = "0xA1A0EC", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000ABA")]
		[Address(RVA = "0xA1A1DC", Offset = "0xA1A1DC", VA = "0xA1A1DC", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000ABB")]
		[Address(RVA = "0xA1A220", Offset = "0xA1A220", VA = "0xA1A220")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000ABC")]
		[Address(RVA = "0xA1A234", Offset = "0xA1A234", VA = "0xA1A234", Slot = "6")]
		[ContextMenu("Force Update Properties Controller")]
		public override void ForceUpdateShaderData()
		{
		}

		[Token(Token = "0x6000ABD")]
		[Address(RVA = "0xA1A118", Offset = "0xA1A118", VA = "0xA1A118")]
		private void UpdateShaderData()
		{
		}

		[Token(Token = "0x6000ABE")]
		[Address(RVA = "0xA1AEAC", Offset = "0xA1AEAC", VA = "0xA1AEAC", Slot = "7")]
		[ContextMenu("Reset Properties Controller")]
		public override void ResetShaderData()
		{
		}

		[Token(Token = "0x6000ABF")]
		[Address(RVA = "0xA1B368", Offset = "0xA1B368", VA = "0xA1B368")]
		public AdvancedDissolvePropertiesController()
		{
		}
	}
	[Token(Token = "0x20001DC")]
	public static class AdvancedDissolveKeywords
	{
		[Token(Token = "0x20001DD")]
		public enum State
		{
			[Token(Token = "0x4000CCB")]
			Disabled,
			[Token(Token = "0x4000CCC")]
			Enabled
		}

		[Token(Token = "0x20001DE")]
		public enum CutoutStandardSource
		{
			[Token(Token = "0x4000CCE")]
			None,
			[Token(Token = "0x4000CCF")]
			BaseAlpha,
			[Token(Token = "0x4000CD0")]
			CustomMap,
			[Token(Token = "0x4000CD1")]
			TwoCustomMaps,
			[Token(Token = "0x4000CD2")]
			ThreeCustomMaps,
			[Token(Token = "0x4000CD3")]
			UserDefined
		}

		[Token(Token = "0x20001DF")]
		public enum CutoutStandardSourceMapsMappingType
		{
			[Token(Token = "0x4000CD5")]
			Default,
			[Token(Token = "0x4000CD6")]
			Triplanar,
			[Token(Token = "0x4000CD7")]
			ScreenSpace
		}

		[Token(Token = "0x20001E0")]
		public enum CutoutGeometricType
		{
			[Token(Token = "0x4000CD9")]
			None,
			[Token(Token = "0x4000CDA")]
			XYZAxis,
			[Token(Token = "0x4000CDB")]
			Plane,
			[Token(Token = "0x4000CDC")]
			Sphere,
			[Token(Token = "0x4000CDD")]
			Cube,
			[Token(Token = "0x4000CDE")]
			Capsule,
			[Token(Token = "0x4000CDF")]
			ConeSmooth
		}

		[Token(Token = "0x20001E1")]
		public enum CutoutGeometricCount
		{
			[Token(Token = "0x4000CE1")]
			One,
			[Token(Token = "0x4000CE2")]
			Two,
			[Token(Token = "0x4000CE3")]
			Three,
			[Token(Token = "0x4000CE4")]
			Four
		}

		[Token(Token = "0x20001E2")]
		public enum EdgeBaseSource
		{
			[Token(Token = "0x4000CE6")]
			None,
			[Token(Token = "0x4000CE7")]
			CutoutStandard,
			[Token(Token = "0x4000CE8")]
			CutoutGeometric,
			[Token(Token = "0x4000CE9")]
			All
		}

		[Token(Token = "0x20001E3")]
		public enum EdgeAdditionalColorSource
		{
			[Token(Token = "0x4000CEB")]
			None,
			[Token(Token = "0x4000CEC")]
			BaseColor,
			[Token(Token = "0x4000CED")]
			CustomMap,
			[Token(Token = "0x4000CEE")]
			GradientMap,
			[Token(Token = "0x4000CEF")]
			GradientColor,
			[Token(Token = "0x4000CF0")]
			UserDefined
		}

		[Token(Token = "0x20001E4")]
		public enum EdgeUVDistortionSource
		{
			[Token(Token = "0x4000CF2")]
			Default,
			[Token(Token = "0x4000CF3")]
			CustomMap
		}

		[Token(Token = "0x20001E5")]
		public enum GlobalControlID
		{
			[Token(Token = "0x4000CF5")]
			None,
			[Token(Token = "0x4000CF6")]
			One,
			[Token(Token = "0x4000CF7")]
			Two,
			[Token(Token = "0x4000CF8")]
			Three,
			[Token(Token = "0x4000CF9")]
			Four
		}

		[Token(Token = "0x4000CC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static string[][] enumNames;

		[Token(Token = "0x4000CC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int[] materialKeywordVariables;

		[Token(Token = "0x6000AC0")]
		[Address(RVA = "0xA199C8", Offset = "0xA199C8", VA = "0xA199C8")]
		public static void SetKeyword(Material[] materials, State keyword, bool enable)
		{
		}

		[Token(Token = "0x6000AC1")]
		[Address(RVA = "0xA19A84", Offset = "0xA19A84", VA = "0xA19A84")]
		public static void SetKeyword(Material[] materials, CutoutStandardSource keyword, bool enable)
		{
		}

		[Token(Token = "0x6000AC2")]
		[Address(RVA = "0xA19B40", Offset = "0xA19B40", VA = "0xA19B40")]
		public static void SetKeyword(Material[] materials, CutoutStandardSourceMapsMappingType keyword, bool enable)
		{
		}

		[Token(Token = "0x6000AC3")]
		[Address(RVA = "0xA19BFC", Offset = "0xA19BFC", VA = "0xA19BFC")]
		public static void SetKeyword(Material[] materials, CutoutGeometricType keyword, bool enable)
		{
		}

		[Token(Token = "0x6000AC4")]
		[Address(RVA = "0xA19CB8", Offset = "0xA19CB8", VA = "0xA19CB8")]
		public static void SetKeyword(Material[] materials, CutoutGeometricCount keyword, bool enable)
		{
		}

		[Token(Token = "0x6000AC5")]
		[Address(RVA = "0xA19D74", Offset = "0xA19D74", VA = "0xA19D74")]
		public static void SetKeyword(Material[] materials, EdgeBaseSource keyword, bool enable)
		{
		}

		[Token(Token = "0x6000AC6")]
		[Address(RVA = "0xA19E30", Offset = "0xA19E30", VA = "0xA19E30")]
		public static void SetKeyword(Material[] materials, EdgeAdditionalColorSource keyword, bool enable)
		{
		}

		[Token(Token = "0x6000AC7")]
		[Address(RVA = "0xA19EEC", Offset = "0xA19EEC", VA = "0xA19EEC")]
		public static void SetKeyword(Material[] materials, EdgeUVDistortionSource keyword, bool enable)
		{
		}

		[Token(Token = "0x6000AC8")]
		[Address(RVA = "0xA19FA8", Offset = "0xA19FA8", VA = "0xA19FA8")]
		public static void SetKeyword(Material[] materials, GlobalControlID keyword, bool enable)
		{
		}

		[Token(Token = "0x6000AC9")]
		[Address(RVA = "0xA1B530", Offset = "0xA1B530", VA = "0xA1B530")]
		private static void SetKeyword(Material material, int enumID, int enumValue, bool enable)
		{
		}
	}
	[Token(Token = "0x20001E6")]
	public static class AdvancedDissolveProperties
	{
		[Serializable]
		[Token(Token = "0x20001E7")]
		public class Cutout
		{
			[Serializable]
			[Token(Token = "0x20001E8")]
			public class Standard
			{
				[Token(Token = "0x20001E9")]
				private class IDs
				{
					[Token(Token = "0x4000D15")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
					public int clip;

					[Token(Token = "0x4000D16")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
					public int map1;

					[Token(Token = "0x4000D17")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
					public int map1Tiling;

					[Token(Token = "0x4000D18")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
					public int map1Offset;

					[Token(Token = "0x4000D19")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
					public int map1Scroll;

					[Token(Token = "0x4000D1A")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
					public int map1Intensity;

					[Token(Token = "0x4000D1B")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
					public int map1Channel;

					[Token(Token = "0x4000D1C")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
					public int map1Invert;

					[Token(Token = "0x4000D1D")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
					public int map2;

					[Token(Token = "0x4000D1E")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
					public int map2Tiling;

					[Token(Token = "0x4000D1F")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
					public int map2Offset;

					[Token(Token = "0x4000D20")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
					public int map2Scroll;

					[Token(Token = "0x4000D21")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
					public int map2Intensity;

					[Token(Token = "0x4000D22")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
					public int map2Channel;

					[Token(Token = "0x4000D23")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
					public int map2Invert;

					[Token(Token = "0x4000D24")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
					public int map3;

					[Token(Token = "0x4000D25")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
					public int map3Tiling;

					[Token(Token = "0x4000D26")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
					public int map3Offset;

					[Token(Token = "0x4000D27")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
					public int map3Scroll;

					[Token(Token = "0x4000D28")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
					public int map3Intensity;

					[Token(Token = "0x4000D29")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
					public int map3Channel;

					[Token(Token = "0x4000D2A")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
					public int map3Invert;

					[Token(Token = "0x4000D2B")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
					public int mapsBlendType;

					[Token(Token = "0x4000D2C")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
					public int mapsTriplanarMappingSpace;

					[Token(Token = "0x4000D2D")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
					public int mapsScreenSpaceUVScale;

					[Token(Token = "0x4000D2E")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
					public int baseInvert;

					[Token(Token = "0x6000AD3")]
					[Address(RVA = "0xA1F9B0", Offset = "0xA1F9B0", VA = "0xA1F9B0")]
					public IDs(int ID)
					{
					}
				}

				[Token(Token = "0x20001EA")]
				public enum Property
				{
					[Token(Token = "0x4000D30")]
					Clip,
					[Token(Token = "0x4000D31")]
					Map1,
					[Token(Token = "0x4000D32")]
					Map1Tiling,
					[Token(Token = "0x4000D33")]
					Map1Offset,
					[Token(Token = "0x4000D34")]
					Map1Scroll,
					[Token(Token = "0x4000D35")]
					Map1Intensity,
					[Token(Token = "0x4000D36")]
					Map1Channel,
					[Token(Token = "0x4000D37")]
					Map1Invert,
					[Token(Token = "0x4000D38")]
					Map2,
					[Token(Token = "0x4000D39")]
					Map2Tiling,
					[Token(Token = "0x4000D3A")]
					Map2Offset,
					[Token(Token = "0x4000D3B")]
					Map2Scroll,
					[Token(Token = "0x4000D3C")]
					Map2Intensity,
					[Token(Token = "0x4000D3D")]
					Map2Channel,
					[Token(Token = "0x4000D3E")]
					Map2Invert,
					[Token(Token = "0x4000D3F")]
					Map3,
					[Token(Token = "0x4000D40")]
					Map3Tiling,
					[Token(Token = "0x4000D41")]
					Map3Offset,
					[Token(Token = "0x4000D42")]
					Map3Scroll,
					[Token(Token = "0x4000D43")]
					Map3Intensity,
					[Token(Token = "0x4000D44")]
					Map3Channel,
					[Token(Token = "0x4000D45")]
					Map3Invert,
					[Token(Token = "0x4000D46")]
					MapsBlendType,
					[Token(Token = "0x4000D47")]
					TriplanarMappingSpace,
					[Token(Token = "0x4000D48")]
					ScreenSpaceUVScale,
					[Token(Token = "0x4000D49")]
					BaseInvert
				}

				[Token(Token = "0x20001EB")]
				public enum MapsBlendType
				{
					[Token(Token = "0x4000D4B")]
					Multiply,
					[Token(Token = "0x4000D4C")]
					Add
				}

				[Token(Token = "0x20001EC")]
				public enum TriplanarMappingSpace
				{
					[Token(Token = "0x4000D4E")]
					World,
					[Token(Token = "0x4000D4F")]
					Local
				}

				[Token(Token = "0x20001ED")]
				public enum ScreenSpaceUVScale
				{
					[Token(Token = "0x4000D51")]
					Constant,
					[Token(Token = "0x4000D52")]
					CameraRelative
				}

				[Token(Token = "0x20001EE")]
				public enum MapChannel
				{
					[Token(Token = "0x4000D54")]
					Red,
					[Token(Token = "0x4000D55")]
					Green,
					[Token(Token = "0x4000D56")]
					Blue,
					[Token(Token = "0x4000D57")]
					Alpha
				}

				[Token(Token = "0x4000CFA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static IDs[] ids;

				[Token(Token = "0x4000CFB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Range(0f, 1f)]
				public float clip;

				[Token(Token = "0x4000CFC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public Texture2D map1;

				[Token(Token = "0x4000CFD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public Vector3 map1Tiling;

				[Token(Token = "0x4000CFE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				public Vector3 map1Offset;

				[Token(Token = "0x4000CFF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				public Vector3 map1Scroll;

				[Token(Token = "0x4000D00")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
				[Range(0f, 1f)]
				public float map1Intensity;

				[Token(Token = "0x4000D01")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
				public MapChannel map1Channel;

				[Token(Token = "0x4000D02")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
				public bool map1Invert;

				[Token(Token = "0x4000D03")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
				public Texture2D map2;

				[Token(Token = "0x4000D04")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
				public Vector3 map2Tiling;

				[Token(Token = "0x4000D05")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
				public Vector3 map2Offset;

				[Token(Token = "0x4000D06")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
				public Vector3 map2Scroll;

				[Token(Token = "0x4000D07")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
				[Range(0f, 1f)]
				public float map2Intensity;

				[Token(Token = "0x4000D08")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
				public MapChannel map2Channel;

				[Token(Token = "0x4000D09")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
				public bool map2Invert;

				[Token(Token = "0x4000D0A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
				public Texture2D map3;

				[Token(Token = "0x4000D0B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
				public Vector3 map3Tiling;

				[Token(Token = "0x4000D0C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
				public Vector3 map3Offset;

				[Token(Token = "0x4000D0D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
				public Vector3 map3Scroll;

				[Token(Token = "0x4000D0E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
				[Range(0f, 1f)]
				public float map3Intensity;

				[Token(Token = "0x4000D0F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
				public MapChannel map3Channel;

				[Token(Token = "0x4000D10")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
				public bool map3Invert;

				[Token(Token = "0x4000D11")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
				public MapsBlendType mapsBlendType;

				[Token(Token = "0x4000D12")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
				public TriplanarMappingSpace triplanarMappingSpace;

				[Token(Token = "0x4000D13")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
				public ScreenSpaceUVScale screenSpaceUVScale;

				[Token(Token = "0x4000D14")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
				public bool baseInvert;

				[Token(Token = "0x6000ACC")]
				[Address(RVA = "0xA1A238", Offset = "0xA1A238", VA = "0xA1A238")]
				public void UpdateLocal(Material[] materials)
				{
				}

				[Token(Token = "0x6000ACD")]
				[Address(RVA = "0xA1CA10", Offset = "0xA1CA10", VA = "0xA1CA10")]
				public void UpdateLocal(Material material)
				{
				}

				[Token(Token = "0x6000ACE")]
				[Address(RVA = "0xA1A440", Offset = "0xA1A440", VA = "0xA1A440")]
				public void UpdateGlobal(AdvancedDissolveKeywords.GlobalControlID globalControlID)
				{
				}

				[Token(Token = "0x6000ACF")]
				[Address(RVA = "0xA1CF10", Offset = "0xA1CF10", VA = "0xA1CF10")]
				public static void UpdateLocalProperty(Material material, Property property, object value)
				{
				}

				[Token(Token = "0x6000AD0")]
				[Address(RVA = "0xA1E2B8", Offset = "0xA1E2B8", VA = "0xA1E2B8")]
				public static void UpdateGlobalProperty(AdvancedDissolveKeywords.GlobalControlID globalControlID, Property property, object value)
				{
				}

				[Token(Token = "0x6000AD1")]
				[Address(RVA = "0xA1B024", Offset = "0xA1B024", VA = "0xA1B024")]
				public Standard()
				{
				}
			}

			[Serializable]
			[Token(Token = "0x20001EF")]
			public class Geometric
			{
				[Token(Token = "0x20001F0")]
				private class IDs
				{
					[Token(Token = "0x4000D59")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
					public int invert;

					[Token(Token = "0x4000D5A")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
					public int noise;

					[Token(Token = "0x4000D5B")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
					public int xyzAxis;

					[Token(Token = "0x4000D5C")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
					public int xyzStyle;

					[Token(Token = "0x4000D5D")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
					public int xyzSpace;

					[Token(Token = "0x4000D5E")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
					public int xyzRollout;

					[Token(Token = "0x4000D5F")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
					public int xyzPivotPointPosition;

					[Token(Token = "0x4000D60")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
					public int position1;

					[Token(Token = "0x4000D61")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
					public int normal1;

					[Token(Token = "0x4000D62")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
					public int radius1;

					[Token(Token = "0x4000D63")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
					public int height1;

					[Token(Token = "0x4000D64")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
					public int size1;

					[Token(Token = "0x4000D65")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
					public int matrixTRS1;

					[Token(Token = "0x4000D66")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
					public int position2;

					[Token(Token = "0x4000D67")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
					public int normal2;

					[Token(Token = "0x4000D68")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
					public int radius2;

					[Token(Token = "0x4000D69")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
					public int height2;

					[Token(Token = "0x4000D6A")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
					public int size2;

					[Token(Token = "0x4000D6B")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
					public int matrixTRS2;

					[Token(Token = "0x4000D6C")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
					public int position3;

					[Token(Token = "0x4000D6D")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
					public int normal3;

					[Token(Token = "0x4000D6E")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
					public int radius3;

					[Token(Token = "0x4000D6F")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
					public int height3;

					[Token(Token = "0x4000D70")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
					public int size3;

					[Token(Token = "0x4000D71")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
					public int matrixTRS3;

					[Token(Token = "0x4000D72")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
					public int position4;

					[Token(Token = "0x4000D73")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
					public int normal4;

					[Token(Token = "0x4000D74")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
					public int radius4;

					[Token(Token = "0x4000D75")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
					public int height4;

					[Token(Token = "0x4000D76")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
					public int size4;

					[Token(Token = "0x4000D77")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
					public int matrixTRS4;

					[Token(Token = "0x6000AD8")]
					[Address(RVA = "0xA228C0", Offset = "0xA228C0", VA = "0xA228C0")]
					public IDs(int ID)
					{
					}
				}

				[Token(Token = "0x20001F1")]
				public enum Property
				{
					[Token(Token = "0x4000D79")]
					XYZAxis,
					[Token(Token = "0x4000D7A")]
					XYZStyle,
					[Token(Token = "0x4000D7B")]
					XYZSpace,
					[Token(Token = "0x4000D7C")]
					XYZRollout,
					[Token(Token = "0x4000D7D")]
					XYZPosition,
					[Token(Token = "0x4000D7E")]
					Position1,
					[Token(Token = "0x4000D7F")]
					Normal1,
					[Token(Token = "0x4000D80")]
					Radius1,
					[Token(Token = "0x4000D81")]
					Height1,
					[Token(Token = "0x4000D82")]
					Size1,
					[Token(Token = "0x4000D83")]
					MatrixTRS1,
					[Token(Token = "0x4000D84")]
					Position2,
					[Token(Token = "0x4000D85")]
					Normal2,
					[Token(Token = "0x4000D86")]
					Radius2,
					[Token(Token = "0x4000D87")]
					Height2,
					[Token(Token = "0x4000D88")]
					Size2,
					[Token(Token = "0x4000D89")]
					MatrixTRS2,
					[Token(Token = "0x4000D8A")]
					Position3,
					[Token(Token = "0x4000D8B")]
					Normal3,
					[Token(Token = "0x4000D8C")]
					Radius3,
					[Token(Token = "0x4000D8D")]
					Height3,
					[Token(Token = "0x4000D8E")]
					Size3,
					[Token(Token = "0x4000D8F")]
					MatrixTRS3,
					[Token(Token = "0x4000D90")]
					Position4,
					[Token(Token = "0x4000D91")]
					Normal4,
					[Token(Token = "0x4000D92")]
					Radius4,
					[Token(Token = "0x4000D93")]
					Height4,
					[Token(Token = "0x4000D94")]
					Size4,
					[Token(Token = "0x4000D95")]
					MatrixTRS4,
					[Token(Token = "0x4000D96")]
					Invert,
					[Token(Token = "0x4000D97")]
					Noise
				}

				[Token(Token = "0x20001F2")]
				public enum XYZAxis
				{
					[Token(Token = "0x4000D99")]
					X,
					[Token(Token = "0x4000D9A")]
					Y,
					[Token(Token = "0x4000D9B")]
					Z
				}

				[Token(Token = "0x20001F3")]
				public enum XYZStyle
				{
					[Token(Token = "0x4000D9D")]
					Linear,
					[Token(Token = "0x4000D9E")]
					Rollout
				}

				[Token(Token = "0x20001F4")]
				public enum XYZSpace
				{
					[Token(Token = "0x4000DA0")]
					World,
					[Token(Token = "0x4000DA1")]
					Local
				}

				[Token(Token = "0x20001F5")]
				public static class UpdateLocalProperty
				{
					[Token(Token = "0x6000AD9")]
					[Address(RVA = "0xA22F58", Offset = "0xA22F58", VA = "0xA22F58")]
					public static void XYZAxis(Material material, XYZAxis xyzAxis, XYZStyle xyzStyle, XYZSpace xyzSpace, float axisRollout, Vector3 axisPosition)
					{
					}

					[Token(Token = "0x6000ADA")]
					[Address(RVA = "0xA23104", Offset = "0xA23104", VA = "0xA23104")]
					public static void Plane(Material material, AdvancedDissolveKeywords.CutoutGeometricCount countID, Vector3 position, Vector3 normal)
					{
					}

					[Token(Token = "0x6000ADB")]
					[Address(RVA = "0xA232F4", Offset = "0xA232F4", VA = "0xA232F4")]
					public static void Sphere(Material material, AdvancedDissolveKeywords.CutoutGeometricCount countID, Vector3 position, float radius)
					{
					}

					[Token(Token = "0x6000ADC")]
					[Address(RVA = "0xA234F8", Offset = "0xA234F8", VA = "0xA234F8")]
					public static void Cube(Material material, AdvancedDissolveKeywords.CutoutGeometricCount countID, Vector3 position, Quaternion rotation, Vector3 size)
					{
					}

					[Token(Token = "0x6000ADD")]
					[Address(RVA = "0xA237F0", Offset = "0xA237F0", VA = "0xA237F0")]
					public static void Capsule(Material material, AdvancedDissolveKeywords.CutoutGeometricCount countID, Vector3 startPosition, Vector3 endPosition, float radius)
					{
					}

					[Token(Token = "0x6000ADE")]
					[Address(RVA = "0xA23C58", Offset = "0xA23C58", VA = "0xA23C58")]
					public static void ConeSmooth(Material material, AdvancedDissolveKeywords.CutoutGeometricCount countID, Vector3 startPosition, Vector3 endPosition, float radius)
					{
					}

					[Token(Token = "0x6000ADF")]
					[Address(RVA = "0xA23C5C", Offset = "0xA23C5C", VA = "0xA23C5C")]
					public static void Invert(Material material, bool invert)
					{
					}

					[Token(Token = "0x6000AE0")]
					[Address(RVA = "0xA23CFC", Offset = "0xA23CFC", VA = "0xA23CFC")]
					public static void Noise(Material material, float noise)
					{
					}
				}

				[Token(Token = "0x20001F6")]
				public static class UpdateGlobalProperty
				{
					[Token(Token = "0x6000AE1")]
					[Address(RVA = "0xA23DA4", Offset = "0xA23DA4", VA = "0xA23DA4")]
					public static void XYZAxis(AdvancedDissolveKeywords.GlobalControlID globalControlID, XYZAxis xyzAxis, XYZStyle xyzStyle, XYZSpace xyzSpace, float axisRollout, Vector3 position)
					{
					}

					[Token(Token = "0x6000AE2")]
					[Address(RVA = "0xA23F50", Offset = "0xA23F50", VA = "0xA23F50")]
					public static void Plane(AdvancedDissolveKeywords.GlobalControlID globalControlID, AdvancedDissolveKeywords.CutoutGeometricCount countID, Vector3 position, Vector3 normal)
					{
					}

					[Token(Token = "0x6000AE3")]
					[Address(RVA = "0xA24140", Offset = "0xA24140", VA = "0xA24140")]
					public static void Sphere(AdvancedDissolveKeywords.GlobalControlID globalControlID, AdvancedDissolveKeywords.CutoutGeometricCount countID, Vector3 position, float radius)
					{
					}

					[Token(Token = "0x6000AE4")]
					[Address(RVA = "0xA24344", Offset = "0xA24344", VA = "0xA24344")]
					public static void Cube(AdvancedDissolveKeywords.GlobalControlID globalControlID, AdvancedDissolveKeywords.CutoutGeometricCount countID, Vector3 position, Quaternion rotation, Vector3 size)
					{
					}

					[Token(Token = "0x6000AE5")]
					[Address(RVA = "0xA2463C", Offset = "0xA2463C", VA = "0xA2463C")]
					public static void Capsule(AdvancedDissolveKeywords.GlobalControlID globalControlID, AdvancedDissolveKeywords.CutoutGeometricCount countID, Vector3 startPosition, Vector3 endPosition, float radius)
					{
					}

					[Token(Token = "0x6000AE6")]
					[Address(RVA = "0xA24AA4", Offset = "0xA24AA4", VA = "0xA24AA4")]
					public static void ConeSmooth(AdvancedDissolveKeywords.GlobalControlID globalControlID, AdvancedDissolveKeywords.CutoutGeometricCount countID, Vector3 startPosition, Vector3 endPosition, float radius)
					{
					}

					[Token(Token = "0x6000AE7")]
					[Address(RVA = "0xA24AA8", Offset = "0xA24AA8", VA = "0xA24AA8")]
					public static void Invert(AdvancedDissolveKeywords.GlobalControlID globalControlID, bool invert)
					{
					}

					[Token(Token = "0x6000AE8")]
					[Address(RVA = "0xA24B48", Offset = "0xA24B48", VA = "0xA24B48")]
					public static void Noise(AdvancedDissolveKeywords.GlobalControlID globalControlID, float noise)
					{
					}
				}

				[Token(Token = "0x4000D58")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static IDs[] ids;

				[Token(Token = "0x6000AD4")]
				[Address(RVA = "0xA1FF58", Offset = "0xA1FF58", VA = "0xA1FF58")]
				private static void UpdateLocal(Material material, Property property, object value)
				{
				}

				[Token(Token = "0x6000AD5")]
				[Address(RVA = "0xA212D4", Offset = "0xA212D4", VA = "0xA212D4")]
				private static void UpdateGlobal(AdvancedDissolveKeywords.GlobalControlID globalControlID, Property property, object value)
				{
				}

				[Token(Token = "0x6000AD6")]
				[Address(RVA = "0xA1B528", Offset = "0xA1B528", VA = "0xA1B528")]
				public Geometric()
				{
				}
			}

			[Token(Token = "0x6000ACB")]
			[Address(RVA = "0xA1CA08", Offset = "0xA1CA08", VA = "0xA1CA08")]
			public Cutout()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001F7")]
		public class Edge
		{
			[Serializable]
			[Token(Token = "0x20001F8")]
			public class Base
			{
				[Token(Token = "0x20001F9")]
				private class IDs
				{
					[Token(Token = "0x4000DA9")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
					public int widthStandard;

					[Token(Token = "0x4000DAA")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
					public int widthGeometric;

					[Token(Token = "0x4000DAB")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
					public int shape;

					[Token(Token = "0x4000DAC")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
					public int color;

					[Token(Token = "0x4000DAD")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
					public int colorTransparency;

					[Token(Token = "0x4000DAE")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
					public int colorIntensity;

					[Token(Token = "0x6000AF1")]
					[Address(RVA = "0xA25B68", Offset = "0xA25B68", VA = "0xA25B68")]
					public IDs(int ID)
					{
					}
				}

				[Token(Token = "0x20001FA")]
				public enum Property
				{
					[Token(Token = "0x4000DB0")]
					WidthStandard,
					[Token(Token = "0x4000DB1")]
					WidthGeometric,
					[Token(Token = "0x4000DB2")]
					Shape,
					[Token(Token = "0x4000DB3")]
					Color,
					[Token(Token = "0x4000DB4")]
					ColorTransparency,
					[Token(Token = "0x4000DB5")]
					ColorIntensity
				}

				[Token(Token = "0x20001FB")]
				public enum Shape
				{
					[Token(Token = "0x4000DB7")]
					Solid,
					[Token(Token = "0x4000DB8")]
					Smooth,
					[Token(Token = "0x4000DB9")]
					Smoother
				}

				[Token(Token = "0x4000DA2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static IDs[] ids;

				[Token(Token = "0x4000DA3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Range(0f, 1f)]
				public float widthCutoutStandard;

				[Token(Token = "0x4000DA4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Range(0f, 1f)]
				public float widthCutoutGeometric;

				[Token(Token = "0x4000DA5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public Shape shape;

				[Token(Token = "0x4000DA6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				public Color color;

				[Token(Token = "0x4000DA7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				[Range(0f, 1f)]
				public float colorTransparency;

				[Token(Token = "0x4000DA8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				public float colorIntensity;

				[Token(Token = "0x6000AEA")]
				[Address(RVA = "0xA1A2A0", Offset = "0xA1A2A0", VA = "0xA1A2A0")]
				public void UpdateLocal(Material[] materials)
				{
				}

				[Token(Token = "0x6000AEB")]
				[Address(RVA = "0xA24BF8", Offset = "0xA24BF8", VA = "0xA24BF8")]
				public void UpdateLocal(Material materia)
				{
				}

				[Token(Token = "0x6000AEC")]
				[Address(RVA = "0xA1A90C", Offset = "0xA1A90C", VA = "0xA1A90C")]
				public void UpdateGlobal(AdvancedDissolveKeywords.GlobalControlID globalControlID)
				{
				}

				[Token(Token = "0x6000AED")]
				[Address(RVA = "0xA24D80", Offset = "0xA24D80", VA = "0xA24D80")]
				public static void UpdateLocalProperty(Material material, Property property, object value)
				{
				}

				[Token(Token = "0x6000AEE")]
				[Address(RVA = "0xA25384", Offset = "0xA25384", VA = "0xA25384")]
				public static void UpdateGlobalProperty(AdvancedDissolveKeywords.GlobalControlID globalControlID, Property property, object value)
				{
				}

				[Token(Token = "0x6000AEF")]
				[Address(RVA = "0xA1B200", Offset = "0xA1B200", VA = "0xA1B200")]
				public Base()
				{
				}
			}

			[Serializable]
			[Token(Token = "0x20001FC")]
			public class AdditionalColor
			{
				[Token(Token = "0x20001FD")]
				private class IDs
				{
					[Token(Token = "0x4000DC7")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
					public int color;

					[Token(Token = "0x4000DC8")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
					public int colorTransparency;

					[Token(Token = "0x4000DC9")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
					public int colorIntensity;

					[Token(Token = "0x4000DCA")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
					public int clipInterpolation;

					[Token(Token = "0x4000DCB")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
					public int map;

					[Token(Token = "0x4000DCC")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
					public int mapTiling;

					[Token(Token = "0x4000DCD")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
					public int mapOffset;

					[Token(Token = "0x4000DCE")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
					public int mapScroll;

					[Token(Token = "0x4000DCF")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
					public int mapReverse;

					[Token(Token = "0x4000DD0")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
					public int mapMipMap;

					[Token(Token = "0x4000DD1")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
					public int phaseOffset;

					[Token(Token = "0x4000DD2")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
					public int alphaOffset;

					[Token(Token = "0x6000AF9")]
					[Address(RVA = "0xA27AF4", Offset = "0xA27AF4", VA = "0xA27AF4")]
					public IDs(int ID)
					{
					}
				}

				[Token(Token = "0x20001FE")]
				public enum Property
				{
					[Token(Token = "0x4000DD4")]
					Map,
					[Token(Token = "0x4000DD5")]
					MapTiling,
					[Token(Token = "0x4000DD6")]
					MapOffset,
					[Token(Token = "0x4000DD7")]
					MapScroll,
					[Token(Token = "0x4000DD8")]
					MapReverse,
					[Token(Token = "0x4000DD9")]
					MapMipmap,
					[Token(Token = "0x4000DDA")]
					PhaseOffset,
					[Token(Token = "0x4000DDB")]
					AlphaOffset,
					[Token(Token = "0x4000DDC")]
					Color,
					[Token(Token = "0x4000DDD")]
					ColorTransparency,
					[Token(Token = "0x4000DDE")]
					ColorIntensity,
					[Token(Token = "0x4000DDF")]
					ClipInterpolation
				}

				[Token(Token = "0x4000DBA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static IDs[] ids;

				[Token(Token = "0x4000DBB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public Texture2D map;

				[Token(Token = "0x4000DBC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public Vector2 mapTiling;

				[Token(Token = "0x4000DBD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public Vector2 mapOffset;

				[Token(Token = "0x4000DBE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				public Vector2 mapScroll;

				[Token(Token = "0x4000DBF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				public bool mapReverse;

				[Token(Token = "0x4000DC0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
				[Range(0f, 10f)]
				public int mapMipmap;

				[Token(Token = "0x4000DC1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				public float phaseOffset;

				[Token(Token = "0x4000DC2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
				[Range(-1f, 1f)]
				public float alphaOffset;

				[Token(Token = "0x4000DC3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
				public Color color;

				[Token(Token = "0x4000DC4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
				[Range(0f, 1f)]
				public float colorTransparency;

				[Token(Token = "0x4000DC5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
				public float colorIntensity;

				[Token(Token = "0x4000DC6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
				public bool clipInterpolation;

				[Token(Token = "0x6000AF2")]
				[Address(RVA = "0xA1A308", Offset = "0xA1A308", VA = "0xA1A308")]
				public void UpdateLocal(Material[] materials)
				{
				}

				[Token(Token = "0x6000AF3")]
				[Address(RVA = "0xA25D40", Offset = "0xA25D40", VA = "0xA25D40")]
				public void UpdateLocal(Material materia)
				{
				}

				[Token(Token = "0x6000AF4")]
				[Address(RVA = "0xA1AA94", Offset = "0xA1AA94", VA = "0xA1AA94")]
				public void UpdateGlobal(AdvancedDissolveKeywords.GlobalControlID globalControlID)
				{
				}

				[Token(Token = "0x6000AF5")]
				[Address(RVA = "0xA25FB8", Offset = "0xA25FB8", VA = "0xA25FB8")]
				public static void UpdateLocalProperty(Material material, Property property, object value)
				{
				}

				[Token(Token = "0x6000AF6")]
				[Address(RVA = "0xA26C4C", Offset = "0xA26C4C", VA = "0xA26C4C")]
				public static void UpdateGlobalProperty(AdvancedDissolveKeywords.GlobalControlID globalControlID, Property property, object value)
				{
				}

				[Token(Token = "0x6000AF7")]
				[Address(RVA = "0xA1B22C", Offset = "0xA1B22C", VA = "0xA1B22C")]
				public AdditionalColor()
				{
				}
			}

			[Serializable]
			[Token(Token = "0x20001FF")]
			public class UVDistortion
			{
				[Token(Token = "0x2000200")]
				private class IDs
				{
					[Token(Token = "0x4000DE6")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
					public int map;

					[Token(Token = "0x4000DE7")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
					public int mapTiling;

					[Token(Token = "0x4000DE8")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
					public int mapOffset;

					[Token(Token = "0x4000DE9")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
					public int mapScroll;

					[Token(Token = "0x4000DEA")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
					public int strength;

					[Token(Token = "0x6000B01")]
					[Address(RVA = "0xA28BF8", Offset = "0xA28BF8", VA = "0xA28BF8")]
					public IDs(int ID)
					{
					}
				}

				[Token(Token = "0x2000201")]
				public enum Property
				{
					[Token(Token = "0x4000DEC")]
					Map,
					[Token(Token = "0x4000DED")]
					MapTiling,
					[Token(Token = "0x4000DEE")]
					MapOffset,
					[Token(Token = "0x4000DEF")]
					MapScroll,
					[Token(Token = "0x4000DF0")]
					Strength
				}

				[Token(Token = "0x4000DE0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static IDs[] ids;

				[Token(Token = "0x4000DE1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public Texture2D map;

				[Token(Token = "0x4000DE2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public Vector2 mapTiling;

				[Token(Token = "0x4000DE3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public Vector2 mapOffset;

				[Token(Token = "0x4000DE4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				public Vector2 mapScroll;

				[Token(Token = "0x4000DE5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				public float strength;

				[Token(Token = "0x6000AFA")]
				[Address(RVA = "0xA1A370", Offset = "0xA1A370", VA = "0xA1A370")]
				public void UpdateLocal(Material[] materials)
				{
				}

				[Token(Token = "0x6000AFB")]
				[Address(RVA = "0xA27DFC", Offset = "0xA27DFC", VA = "0xA27DFC")]
				public void UpdateLocal(Material materia)
				{
				}

				[Token(Token = "0x6000AFC")]
				[Address(RVA = "0xA1AD0C", Offset = "0xA1AD0C", VA = "0xA1AD0C")]
				public void UpdateGlobal(AdvancedDissolveKeywords.GlobalControlID globalControlID)
				{
				}

				[Token(Token = "0x6000AFD")]
				[Address(RVA = "0xA27F2C", Offset = "0xA27F2C", VA = "0xA27F2C")]
				public static void UpdateLocalProperty(Material material, Property property, object value)
				{
				}

				[Token(Token = "0x6000AFE")]
				[Address(RVA = "0xA2849C", Offset = "0xA2849C", VA = "0xA2849C")]
				public static void UpdateGlobalProperty(AdvancedDissolveKeywords.GlobalControlID globalControlID, Property property, object value)
				{
				}

				[Token(Token = "0x6000AFF")]
				[Address(RVA = "0xA1B2D0", Offset = "0xA1B2D0", VA = "0xA1B2D0")]
				public UVDistortion()
				{
				}
			}

			[Serializable]
			[Token(Token = "0x2000202")]
			public class GlobalIllumination
			{
				[Token(Token = "0x2000203")]
				private class IDs
				{
					[Token(Token = "0x4000DF3")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
					public int metaPassMultiplier;

					[Token(Token = "0x6000B09")]
					[Address(RVA = "0xA291A8", Offset = "0xA291A8", VA = "0xA291A8")]
					public IDs(int ID)
					{
					}
				}

				[Token(Token = "0x4000DF1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static IDs[] ids;

				[Token(Token = "0x4000DF2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public float metaPassMultiplier;

				[Token(Token = "0x6000B02")]
				[Address(RVA = "0xA1A3D8", Offset = "0xA1A3D8", VA = "0xA1A3D8")]
				public void UpdateLocal(Material[] materials)
				{
				}

				[Token(Token = "0x6000B03")]
				[Address(RVA = "0xA28DA0", Offset = "0xA28DA0", VA = "0xA28DA0")]
				public void UpdateLocal(Material materia)
				{
				}

				[Token(Token = "0x6000B04")]
				[Address(RVA = "0xA1AE3C", Offset = "0xA1AE3C", VA = "0xA1AE3C")]
				public void UpdateGlobal(AdvancedDissolveKeywords.GlobalControlID globalControlID)
				{
				}

				[Token(Token = "0x6000B05")]
				[Address(RVA = "0xA28E10", Offset = "0xA28E10", VA = "0xA28E10")]
				public static void UpdateLocalProperty(Material material, float value)
				{
				}

				[Token(Token = "0x6000B06")]
				[Address(RVA = "0xA28EF0", Offset = "0xA28EF0", VA = "0xA28EF0")]
				public static void UpdateGlobalProperty(AdvancedDissolveKeywords.GlobalControlID globalControlID, float value)
				{
				}

				[Token(Token = "0x6000B07")]
				[Address(RVA = "0xA1B360", Offset = "0xA1B360", VA = "0xA1B360")]
				public GlobalIllumination()
				{
				}
			}

			[Token(Token = "0x6000AE9")]
			[Address(RVA = "0xA24BF0", Offset = "0xA24BF0", VA = "0xA24BF0")]
			public Edge()
			{
			}
		}
	}
	[Token(Token = "0x2000204")]
	[ExecuteAlways]
	[RequireComponent(typeof(Light))]
	public class AdvancedDissolveSpotLightToConeSmooth : MonoBehaviour
	{
		[Token(Token = "0x4000DF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AdvancedDissolveGeometricCutoutController geometricCutoutController;

		[Token(Token = "0x4000DF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AdvancedDissolveKeywords.CutoutGeometricCount countID;

		[Token(Token = "0x4000DF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float radiusOffset;

		[Token(Token = "0x4000DF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Light spotLight;

		[Token(Token = "0x6000B0A")]
		[Address(RVA = "0xA29274", Offset = "0xA29274", VA = "0xA29274")]
		private void Start()
		{
		}

		[Token(Token = "0x6000B0B")]
		[Address(RVA = "0xA292CC", Offset = "0xA292CC", VA = "0xA292CC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000B0C")]
		[Address(RVA = "0xA29438", Offset = "0xA29438", VA = "0xA29438")]
		public AdvancedDissolveSpotLightToConeSmooth()
		{
		}
	}
	[Token(Token = "0x2000205")]
	[ExecuteAlways]
	public class AdvancedDissolveTransformScaleToRadius : MonoBehaviour
	{
		[Token(Token = "0x4000DF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AdvancedDissolveGeometricCutoutController geometricCutoutController;

		[Token(Token = "0x4000DF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AdvancedDissolveKeywords.CutoutGeometricCount countID;

		[Token(Token = "0x6000B0D")]
		[Address(RVA = "0xA29440", Offset = "0xA29440", VA = "0xA29440")]
		private void Update()
		{
		}

		[Token(Token = "0x6000B0E")]
		[Address(RVA = "0xA29524", Offset = "0xA29524", VA = "0xA29524")]
		public AdvancedDissolveTransformScaleToRadius()
		{
		}
	}
}
namespace AmazingAssets.AdvancedDissolve.ExampleScripts
{
	[Token(Token = "0x2000206")]
	public class AnimateCutout : MonoBehaviour
	{
		[Token(Token = "0x4000DFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Material material;

		[Token(Token = "0x4000DFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float offset;

		[Token(Token = "0x4000DFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float speed;

		[Token(Token = "0x6000B0F")]
		[Address(RVA = "0xA2952C", Offset = "0xA2952C", VA = "0xA2952C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000B10")]
		[Address(RVA = "0xA295CC", Offset = "0xA295CC", VA = "0xA295CC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000B11")]
		[Address(RVA = "0xA296C4", Offset = "0xA296C4", VA = "0xA296C4")]
		public AnimateCutout()
		{
		}
	}
	[Token(Token = "0x2000207")]
	public class AnimateGI : MonoBehaviour
	{
		[Token(Token = "0x4000DFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Renderer mRenderer;

		[Token(Token = "0x6000B12")]
		[Address(RVA = "0xA296CC", Offset = "0xA296CC", VA = "0xA296CC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000B13")]
		[Address(RVA = "0xA29724", Offset = "0xA29724", VA = "0xA29724")]
		private void Update()
		{
		}

		[Token(Token = "0x6000B14")]
		[Address(RVA = "0xA29730", Offset = "0xA29730", VA = "0xA29730")]
		public AnimateGI()
		{
		}
	}
	[Token(Token = "0x2000208")]
	public class CameraOrbitalMove : MonoBehaviour
	{
		[Token(Token = "0x4000DFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000DFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float distance;

		[Token(Token = "0x4000E00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float xSpeed;

		[Token(Token = "0x4000E01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float ySpeed;

		[Token(Token = "0x4000E02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float yMinLimit;

		[Token(Token = "0x4000E03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float yMaxLimit;

		[Token(Token = "0x4000E04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float distanceMin;

		[Token(Token = "0x4000E05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float distanceMax;

		[Token(Token = "0x4000E06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float x;

		[Token(Token = "0x4000E07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float y;

		[Token(Token = "0x6000B15")]
		[Address(RVA = "0xA29738", Offset = "0xA29738", VA = "0xA29738")]
		private void Start()
		{
		}

		[Token(Token = "0x6000B16")]
		[Address(RVA = "0xA29764", Offset = "0xA29764", VA = "0xA29764")]
		private void Update()
		{
		}

		[Token(Token = "0x6000B17")]
		[Address(RVA = "0xA299F8", Offset = "0xA299F8", VA = "0xA299F8")]
		public static float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000B18")]
		[Address(RVA = "0xA29A34", Offset = "0xA29A34", VA = "0xA29A34")]
		public CameraOrbitalMove()
		{
		}
	}
	[Token(Token = "0x2000209")]
	[ExecuteAlways]
	[RequireComponent(typeof(LineRenderer))]
	public class CapsuleFromLineRenderer : MonoBehaviour
	{
		[Token(Token = "0x4000E08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AdvancedDissolveGeometricCutoutController geometricCutoutController;

		[Token(Token = "0x4000E09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AdvancedDissolveKeywords.CutoutGeometricCount countID;

		[Token(Token = "0x4000E0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private LineRenderer lineRenderer;

		[Token(Token = "0x6000B19")]
		[Address(RVA = "0xA29A5C", Offset = "0xA29A5C", VA = "0xA29A5C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000B1A")]
		[Address(RVA = "0xA29C94", Offset = "0xA29C94", VA = "0xA29C94")]
		public CapsuleFromLineRenderer()
		{
		}
	}
}
namespace RengeGames.HealthBars
{
	[Token(Token = "0x200020A")]
	[DisallowMultipleComponent]
	[ExecuteAlways]
	public class CompoundHealthBar : MonoBehaviour, ISegmentedHealthBar
	{
		[Serializable]
		[Token(Token = "0x200020B")]
		private sealed class <>c
		{
			[Token(Token = "0x4000E17")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000E18")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<int, ISegmentedHealthBar, int> <>9__29_0;

			[Token(Token = "0x6000B33")]
			[Address(RVA = "0xA2AE68", Offset = "0xA2AE68", VA = "0xA2AE68")]
			public <>c()
			{
			}

			[Token(Token = "0x6000B34")]
			[Address(RVA = "0xA2AE70", Offset = "0xA2AE70", VA = "0xA2AE70")]
			internal int <TotalSegmentCount>b__29_0(int sum, ISegmentedHealthBar next)
			{
				return default(int);
			}
		}

		[Token(Token = "0x4000E0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string oldParentName;

		[Token(Token = "0x4000E0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string parentName;

		[Token(Token = "0x4000E0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string oldHbName;

		[Token(Token = "0x4000E0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string hbName;

		[Token(Token = "0x4000E0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<ISegmentedHealthBar> healthBars;

		[Token(Token = "0x4000E10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool segmentsToggle;

		[Token(Token = "0x4000E11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Range(0f, 1f)]
		[SerializeField]
		private float value;

		[Token(Token = "0x4000E12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private int removedSegments;

		[Token(Token = "0x4000E13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private bool fillFrontToBack;

		[Token(Token = "0x4000E14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		[SerializeField]
		private bool useGradient;

		[Token(Token = "0x4000E15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Gradient gradient;

		[Token(Token = "0x4000E16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private List<string> healthBarNames;

		[Token(Token = "0x17000112")]
		public string ParentName
		{
			[Token(Token = "0x6000B1B")]
			[Address(RVA = "0xA29C9C", Offset = "0xA29C9C", VA = "0xA29C9C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B1C")]
			[Address(RVA = "0xA29CA4", Offset = "0xA29CA4", VA = "0xA29CA4")]
			set
			{
			}
		}

		[Token(Token = "0x17000113")]
		public string Name
		{
			[Token(Token = "0x6000B1D")]
			[Address(RVA = "0xA29D0C", Offset = "0xA29D0C", VA = "0xA29D0C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B1E")]
			[Address(RVA = "0xA29D14", Offset = "0xA29D14", VA = "0xA29D14")]
			set
			{
			}
		}

		[Token(Token = "0x6000B1F")]
		[Address(RVA = "0xA29D7C", Offset = "0xA29D7C", VA = "0xA29D7C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000B20")]
		[Address(RVA = "0xA29DA8", Offset = "0xA29DA8", VA = "0xA29DA8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000B21")]
		[Address(RVA = "0xA2A360", Offset = "0xA2A360", VA = "0xA2A360")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000B22")]
		[Address(RVA = "0xA29DAC", Offset = "0xA29DAC", VA = "0xA29DAC")]
		private void Populate()
		{
		}

		[Token(Token = "0x6000B23")]
		[Address(RVA = "0xA2AAE4", Offset = "0xA2AAE4", VA = "0xA2AAE4", Slot = "9")]
		public void AddRemovePercent(float value)
		{
		}

		[Token(Token = "0x6000B24")]
		[Address(RVA = "0xA2AB08", Offset = "0xA2AB08", VA = "0xA2AB08", Slot = "5")]
		public string GetName()
		{
			return null;
		}

		[Token(Token = "0x6000B25")]
		[Address(RVA = "0xA2AB10", Offset = "0xA2AB10", VA = "0xA2AB10", Slot = "4")]
		public string GetParentName()
		{
			return null;
		}

		[Token(Token = "0x6000B26")]
		[Address(RVA = "0xA2A590", Offset = "0xA2A590", VA = "0xA2A590", Slot = "7")]
		public void SetPercent(float value)
		{
		}

		[Token(Token = "0x6000B27")]
		[Address(RVA = "0xA2AB18", Offset = "0xA2AB18", VA = "0xA2AB18", Slot = "10")]
		public void AddRemoveSegments(float value)
		{
		}

		[Token(Token = "0x6000B28")]
		[Address(RVA = "0xA2A3A8", Offset = "0xA2A3A8", VA = "0xA2A3A8", Slot = "6")]
		public void SetRemovedSegments(float value)
		{
		}

		[Token(Token = "0x6000B29")]
		[Address(RVA = "0xA2AB74", Offset = "0xA2AB74", VA = "0xA2AB74")]
		private float TotalSegmentCount()
		{
			return default(float);
		}

		[Token(Token = "0x6000B2A")]
		[Address(RVA = "0xA2AC84", Offset = "0xA2AC84", VA = "0xA2AC84")]
		private float SegmentCount(ISegmentedHealthBar hb)
		{
			return default(float);
		}

		[Token(Token = "0x6000B2B")]
		[Address(RVA = "0xA2AD10", Offset = "0xA2AD10", VA = "0xA2AD10", Slot = "11")]
		public bool SetShaderKeywordValue(string propertyName, bool value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B2C")]
		public bool SetShaderPropertyValue<T>(string propertyName, T value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B2D")]
		[Address(RVA = "0xA2AD18", Offset = "0xA2AD18", VA = "0xA2AD18", Slot = "12")]
		public bool GetShaderKeyword(string propertyName, out ShaderKeyword shaderKeyword)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B2E")]
		[Address(RVA = "0xA2AD38", Offset = "0xA2AD38", VA = "0xA2AD38", Slot = "13")]
		public bool GetShaderKeywordValue(string propertyName, out bool value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B2F")]
		public bool GetShaderProperty<T>(string propertyName, out ShaderProperty<T> shaderProperty)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B30")]
		public bool GetShaderPropertyValue<T>(string propertyName, out T value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B31")]
		[Address(RVA = "0xA2AD44", Offset = "0xA2AD44", VA = "0xA2AD44")]
		public CompoundHealthBar()
		{
		}
	}
	[Token(Token = "0x200020C")]
	public interface ISegmentedHealthBar
	{
		[Token(Token = "0x6000B35")]
		string GetParentName();

		[Token(Token = "0x6000B36")]
		string GetName();

		[Token(Token = "0x6000B37")]
		void SetRemovedSegments(float value);

		[Token(Token = "0x6000B38")]
		void SetPercent(float value);

		[Token(Token = "0x6000B39")]
		bool SetShaderPropertyValue<T>(string propertyName, T value);
	}
	[Token(Token = "0x200020D")]
	[ExecuteAlways]
	[DisallowMultipleComponent]
	public class RadialSegmentedHealthBar : MonoBehaviour, ISegmentedHealthBar
	{
		[Token(Token = "0x4000E19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string oldParentName;

		[Token(Token = "0x4000E1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string parentName;

		[Token(Token = "0x4000E1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string oldHbName;

		[Token(Token = "0x4000E1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string hbName;

		[Token(Token = "0x4000E1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool usingSpriteRenderer;

		[Token(Token = "0x4000E1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		[SerializeField]
		private bool forceBuiltInShader;

		[Token(Token = "0x4000E1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ShaderPropertyColor <OverlayColor>k__BackingField;

		[Token(Token = "0x4000E20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ShaderPropertyColor <InnerColor>k__BackingField;

		[Token(Token = "0x4000E21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ShaderPropertyColor <BorderColor>k__BackingField;

		[Token(Token = "0x4000E22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private ShaderPropertyColor <EmptyColor>k__BackingField;

		[Token(Token = "0x4000E23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private ShaderPropertyColor <SpaceColor>k__BackingField;

		[Token(Token = "0x4000E24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private ShaderPropertyFloat <SegmentCount>k__BackingField;

		[Token(Token = "0x4000E25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ShaderPropertyFloat <RemoveSegments>k__BackingField;

		[Token(Token = "0x4000E26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ShaderPropertyFloat <SegmentSpacing>k__BackingField;

		[Token(Token = "0x4000E27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private ShaderPropertyFloat <Arc>k__BackingField;

		[Token(Token = "0x4000E28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private ShaderPropertyFloat <Radius>k__BackingField;

		[Token(Token = "0x4000E29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private ShaderPropertyFloat <LineWidth>k__BackingField;

		[Token(Token = "0x4000E2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private ShaderPropertyFloat <Rotation>k__BackingField;

		[Token(Token = "0x4000E2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private ShaderPropertyVector2 <Offset>k__BackingField;

		[Token(Token = "0x4000E2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private ShaderPropertyFloat <BorderWidth>k__BackingField;

		[Token(Token = "0x4000E2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private ShaderPropertyFloat <BorderSpacing>k__BackingField;

		[Token(Token = "0x4000E2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private ShaderPropertyFloat <RemoveBorder>k__BackingField;

		[Token(Token = "0x4000E2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private ShaderPropertyBool <OverlayNoiseEnabled>k__BackingField;

		[Token(Token = "0x4000E30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private ShaderPropertyFloat <OverlayNoiseScale>k__BackingField;

		[Token(Token = "0x4000E31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private ShaderPropertyFloat <OverlayNoiseStrength>k__BackingField;

		[Token(Token = "0x4000E32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private ShaderPropertyVector2 <OverlayNoiseOffset>k__BackingField;

		[Token(Token = "0x4000E33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private ShaderPropertyBool <EmptyNoiseEnabled>k__BackingField;

		[Token(Token = "0x4000E34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private ShaderPropertyFloat <EmptyNoiseScale>k__BackingField;

		[Token(Token = "0x4000E35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private ShaderPropertyFloat <EmptyNoiseStrength>k__BackingField;

		[Token(Token = "0x4000E36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private ShaderPropertyVector2 <EmptyNoiseOffset>k__BackingField;

		[Token(Token = "0x4000E37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[SerializeField]
		private ShaderPropertyBool <ContentNoiseEnabled>k__BackingField;

		[Token(Token = "0x4000E38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[SerializeField]
		private ShaderPropertyFloat <ContentNoiseScale>k__BackingField;

		[Token(Token = "0x4000E39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[SerializeField]
		private ShaderPropertyFloat <ContentNoiseStrength>k__BackingField;

		[Token(Token = "0x4000E3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[SerializeField]
		private ShaderPropertyVector2 <ContentNoiseOffset>k__BackingField;

		[Token(Token = "0x4000E3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[SerializeField]
		private ShaderPropertyBool <PulsateWhenLow>k__BackingField;

		[Token(Token = "0x4000E3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[SerializeField]
		private ShaderPropertyColor <PulseColor>k__BackingField;

		[Token(Token = "0x4000E3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[SerializeField]
		private ShaderPropertyFloat <PulseSpeed>k__BackingField;

		[Token(Token = "0x4000E3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[SerializeField]
		private ShaderPropertyFloat <PulseActivationThreshold>k__BackingField;

		[Token(Token = "0x4000E3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		[SerializeField]
		private ShaderKeyword <OverlayTextureEnabled>k__BackingField;

		[Token(Token = "0x4000E40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		[SerializeField]
		private ShaderPropertyTexture2D <OverlayTexture>k__BackingField;

		[Token(Token = "0x4000E41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		[SerializeField]
		private ShaderPropertyFloat <OverlayTextureOpacity>k__BackingField;

		[Token(Token = "0x4000E42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		[SerializeField]
		private ShaderPropertyVector2 <OverlayTextureTiling>k__BackingField;

		[Token(Token = "0x4000E43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		[SerializeField]
		private ShaderPropertyVector2 <OverlayTextureOffset>k__BackingField;

		[Token(Token = "0x4000E44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		[SerializeField]
		private ShaderKeyword <InnerTextureEnabled>k__BackingField;

		[Token(Token = "0x4000E45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		[SerializeField]
		private ShaderPropertyTexture2D <InnerTexture>k__BackingField;

		[Token(Token = "0x4000E46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		[SerializeField]
		private ShaderPropertyBool <AlignInnerTexture>k__BackingField;

		[Token(Token = "0x4000E47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		[SerializeField]
		private ShaderPropertyBool <InnerTextureScaleWithSegments>k__BackingField;

		[Token(Token = "0x4000E48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		[SerializeField]
		private ShaderPropertyFloat <InnerTextureOpacity>k__BackingField;

		[Token(Token = "0x4000E49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		[SerializeField]
		private ShaderPropertyVector2 <InnerTextureTiling>k__BackingField;

		[Token(Token = "0x4000E4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		[SerializeField]
		private ShaderPropertyVector2 <InnerTextureOffset>k__BackingField;

		[Token(Token = "0x4000E4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		[SerializeField]
		private ShaderKeyword <BorderTextureEnabled>k__BackingField;

		[Token(Token = "0x4000E4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		[SerializeField]
		private ShaderPropertyTexture2D <BorderTexture>k__BackingField;

		[Token(Token = "0x4000E4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		[SerializeField]
		private ShaderPropertyBool <AlignBorderTexture>k__BackingField;

		[Token(Token = "0x4000E4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		[SerializeField]
		private ShaderPropertyBool <BorderTextureScaleWithSegments>k__BackingField;

		[Token(Token = "0x4000E4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		[SerializeField]
		private ShaderPropertyFloat <BorderTextureOpacity>k__BackingField;

		[Token(Token = "0x4000E50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		[SerializeField]
		private ShaderPropertyVector2 <BorderTextureTiling>k__BackingField;

		[Token(Token = "0x4000E51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		[SerializeField]
		private ShaderPropertyVector2 <BorderTextureOffset>k__BackingField;

		[Token(Token = "0x4000E52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		[SerializeField]
		private ShaderKeyword <EmptyTextureEnabled>k__BackingField;

		[Token(Token = "0x4000E53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		[SerializeField]
		private ShaderPropertyTexture2D <EmptyTexture>k__BackingField;

		[Token(Token = "0x4000E54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		[SerializeField]
		private ShaderPropertyBool <AlignEmptyTexture>k__BackingField;

		[Token(Token = "0x4000E55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		[SerializeField]
		private ShaderPropertyBool <EmptyTextureScaleWithSegments>k__BackingField;

		[Token(Token = "0x4000E56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		[SerializeField]
		private ShaderPropertyFloat <EmptyTextureOpacity>k__BackingField;

		[Token(Token = "0x4000E57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		[SerializeField]
		private ShaderPropertyVector2 <EmptyTextureTiling>k__BackingField;

		[Token(Token = "0x4000E58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		[SerializeField]
		private ShaderPropertyVector2 <EmptyTextureOffset>k__BackingField;

		[Token(Token = "0x4000E59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		[SerializeField]
		private ShaderKeyword <SpaceTextureEnabled>k__BackingField;

		[Token(Token = "0x4000E5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		[SerializeField]
		private ShaderPropertyTexture2D <SpaceTexture>k__BackingField;

		[Token(Token = "0x4000E5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		[SerializeField]
		private ShaderPropertyBool <AlignSpaceTexture>k__BackingField;

		[Token(Token = "0x4000E5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		[SerializeField]
		private ShaderPropertyFloat <SpaceTextureOpacity>k__BackingField;

		[Token(Token = "0x4000E5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		[SerializeField]
		private ShaderPropertyVector2 <SpaceTextureTiling>k__BackingField;

		[Token(Token = "0x4000E5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		[SerializeField]
		private ShaderPropertyVector2 <SpaceTextureOffset>k__BackingField;

		[Token(Token = "0x4000E5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		[SerializeField]
		private ShaderPropertyGradient <InnerGradient>k__BackingField;

		[Token(Token = "0x4000E60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		[SerializeField]
		private ShaderPropertyBool <InnerGradientEnabled>k__BackingField;

		[Token(Token = "0x4000E61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		[SerializeField]
		private ShaderPropertyBool <ValueAsGradientTimeInner>k__BackingField;

		[Token(Token = "0x4000E62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		[SerializeField]
		private ShaderPropertyGradient <EmptyGradient>k__BackingField;

		[Token(Token = "0x4000E63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		[SerializeField]
		private ShaderPropertyBool <EmptyGradientEnabled>k__BackingField;

		[Token(Token = "0x4000E64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		[SerializeField]
		private ShaderPropertyBool <ValueAsGradientTimeEmpty>k__BackingField;

		[Token(Token = "0x4000E65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		[SerializeField]
		private ShaderPropertyAnimationCurve <VariableWidthCurve>k__BackingField;

		[Token(Token = "0x4000E66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		[SerializeField]
		private ShaderPropertyBool <FillClockwise>k__BackingField;

		[Token(Token = "0x4000E67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		private Material currentMaterial;

		[Token(Token = "0x4000E68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		private SpriteRenderer spriteRenderer;

		[Token(Token = "0x4000E69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		private Image image;

		[Token(Token = "0x4000E6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		private bool materialAssigned;

		[Token(Token = "0x4000E6B")]
		private const string MaterialName = "radialSegmentedHealthBarInstance";

		[Token(Token = "0x4000E6C")]
		private const string PlaceholderSpriteName = "rshb_placeholderSprite";

		[Token(Token = "0x4000E6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		private SortedDictionary<string, IShaderProperty> properties;

		[Token(Token = "0x17000114")]
		public string ParentName
		{
			[Token(Token = "0x6000B3A")]
			[Address(RVA = "0xA2AF1C", Offset = "0xA2AF1C", VA = "0xA2AF1C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B3B")]
			[Address(RVA = "0xA2AA14", Offset = "0xA2AA14", VA = "0xA2AA14")]
			set
			{
			}
		}

		[Token(Token = "0x17000115")]
		public string Name
		{
			[Token(Token = "0x6000B3C")]
			[Address(RVA = "0xA2AF24", Offset = "0xA2AF24", VA = "0xA2AF24")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B3D")]
			[Address(RVA = "0xA2AA7C", Offset = "0xA2AA7C", VA = "0xA2AA7C")]
			set
			{
			}
		}

		[Token(Token = "0x17000116")]
		public bool UsingSpriteRenderer
		{
			[Token(Token = "0x6000B3E")]
			[Address(RVA = "0xA2AF2C", Offset = "0xA2AF2C", VA = "0xA2AF2C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000B3F")]
			[Address(RVA = "0xA2AF34", Offset = "0xA2AF34", VA = "0xA2AF34")]
			set
			{
			}
		}

		[Token(Token = "0x17000117")]
		public bool ForceBuiltInShader
		{
			[Token(Token = "0x6000B40")]
			[Address(RVA = "0xA2B34C", Offset = "0xA2B34C", VA = "0xA2B34C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000B41")]
			[Address(RVA = "0xA2B354", Offset = "0xA2B354", VA = "0xA2B354")]
			set
			{
			}
		}

		[Token(Token = "0x17000118")]
		public ShaderPropertyColor OverlayColor
		{
			[Token(Token = "0x6000B42")]
			[Address(RVA = "0xA2B364", Offset = "0xA2B364", VA = "0xA2B364")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B43")]
			[Address(RVA = "0xA2B36C", Offset = "0xA2B36C", VA = "0xA2B36C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000119")]
		public ShaderPropertyColor InnerColor
		{
			[Token(Token = "0x6000B44")]
			[Address(RVA = "0xA2B374", Offset = "0xA2B374", VA = "0xA2B374")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B45")]
			[Address(RVA = "0xA2B37C", Offset = "0xA2B37C", VA = "0xA2B37C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700011A")]
		public ShaderPropertyColor BorderColor
		{
			[Token(Token = "0x6000B46")]
			[Address(RVA = "0xA2B384", Offset = "0xA2B384", VA = "0xA2B384")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B47")]
			[Address(RVA = "0xA2B38C", Offset = "0xA2B38C", VA = "0xA2B38C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700011B")]
		public ShaderPropertyColor EmptyColor
		{
			[Token(Token = "0x6000B48")]
			[Address(RVA = "0xA2B394", Offset = "0xA2B394", VA = "0xA2B394")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B49")]
			[Address(RVA = "0xA2B39C", Offset = "0xA2B39C", VA = "0xA2B39C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700011C")]
		public ShaderPropertyColor SpaceColor
		{
			[Token(Token = "0x6000B4A")]
			[Address(RVA = "0xA2B3A4", Offset = "0xA2B3A4", VA = "0xA2B3A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B4B")]
			[Address(RVA = "0xA2B3AC", Offset = "0xA2B3AC", VA = "0xA2B3AC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700011D")]
		public ShaderPropertyFloat SegmentCount
		{
			[Token(Token = "0x6000B4C")]
			[Address(RVA = "0xA2B3B4", Offset = "0xA2B3B4", VA = "0xA2B3B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B4D")]
			[Address(RVA = "0xA2B3BC", Offset = "0xA2B3BC", VA = "0xA2B3BC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700011E")]
		public ShaderPropertyFloat RemoveSegments
		{
			[Token(Token = "0x6000B4E")]
			[Address(RVA = "0xA2B3C4", Offset = "0xA2B3C4", VA = "0xA2B3C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B4F")]
			[Address(RVA = "0xA2B3CC", Offset = "0xA2B3CC", VA = "0xA2B3CC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700011F")]
		public ShaderPropertyFloat SegmentSpacing
		{
			[Token(Token = "0x6000B50")]
			[Address(RVA = "0xA2B3D4", Offset = "0xA2B3D4", VA = "0xA2B3D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B51")]
			[Address(RVA = "0xA2B3DC", Offset = "0xA2B3DC", VA = "0xA2B3DC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000120")]
		public ShaderPropertyFloat Arc
		{
			[Token(Token = "0x6000B52")]
			[Address(RVA = "0xA2B3E4", Offset = "0xA2B3E4", VA = "0xA2B3E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B53")]
			[Address(RVA = "0xA2B3EC", Offset = "0xA2B3EC", VA = "0xA2B3EC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000121")]
		public ShaderPropertyFloat Radius
		{
			[Token(Token = "0x6000B54")]
			[Address(RVA = "0xA2B3F4", Offset = "0xA2B3F4", VA = "0xA2B3F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B55")]
			[Address(RVA = "0xA2B3FC", Offset = "0xA2B3FC", VA = "0xA2B3FC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000122")]
		public ShaderPropertyFloat LineWidth
		{
			[Token(Token = "0x6000B56")]
			[Address(RVA = "0xA2B404", Offset = "0xA2B404", VA = "0xA2B404")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B57")]
			[Address(RVA = "0xA2B40C", Offset = "0xA2B40C", VA = "0xA2B40C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000123")]
		public ShaderPropertyFloat Rotation
		{
			[Token(Token = "0x6000B58")]
			[Address(RVA = "0xA2B414", Offset = "0xA2B414", VA = "0xA2B414")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B59")]
			[Address(RVA = "0xA2B41C", Offset = "0xA2B41C", VA = "0xA2B41C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000124")]
		public ShaderPropertyVector2 Offset
		{
			[Token(Token = "0x6000B5A")]
			[Address(RVA = "0xA2B424", Offset = "0xA2B424", VA = "0xA2B424")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B5B")]
			[Address(RVA = "0xA2B42C", Offset = "0xA2B42C", VA = "0xA2B42C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000125")]
		public ShaderPropertyFloat BorderWidth
		{
			[Token(Token = "0x6000B5C")]
			[Address(RVA = "0xA2B434", Offset = "0xA2B434", VA = "0xA2B434")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B5D")]
			[Address(RVA = "0xA2B43C", Offset = "0xA2B43C", VA = "0xA2B43C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000126")]
		public ShaderPropertyFloat BorderSpacing
		{
			[Token(Token = "0x6000B5E")]
			[Address(RVA = "0xA2B444", Offset = "0xA2B444", VA = "0xA2B444")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B5F")]
			[Address(RVA = "0xA2B44C", Offset = "0xA2B44C", VA = "0xA2B44C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000127")]
		public ShaderPropertyFloat RemoveBorder
		{
			[Token(Token = "0x6000B60")]
			[Address(RVA = "0xA2B454", Offset = "0xA2B454", VA = "0xA2B454")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B61")]
			[Address(RVA = "0xA2B45C", Offset = "0xA2B45C", VA = "0xA2B45C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000128")]
		public ShaderPropertyBool OverlayNoiseEnabled
		{
			[Token(Token = "0x6000B62")]
			[Address(RVA = "0xA2B464", Offset = "0xA2B464", VA = "0xA2B464")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B63")]
			[Address(RVA = "0xA2B46C", Offset = "0xA2B46C", VA = "0xA2B46C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000129")]
		public ShaderPropertyFloat OverlayNoiseScale
		{
			[Token(Token = "0x6000B64")]
			[Address(RVA = "0xA2B474", Offset = "0xA2B474", VA = "0xA2B474")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B65")]
			[Address(RVA = "0xA2B47C", Offset = "0xA2B47C", VA = "0xA2B47C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700012A")]
		public ShaderPropertyFloat OverlayNoiseStrength
		{
			[Token(Token = "0x6000B66")]
			[Address(RVA = "0xA2B484", Offset = "0xA2B484", VA = "0xA2B484")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B67")]
			[Address(RVA = "0xA2B48C", Offset = "0xA2B48C", VA = "0xA2B48C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700012B")]
		public ShaderPropertyVector2 OverlayNoiseOffset
		{
			[Token(Token = "0x6000B68")]
			[Address(RVA = "0xA2B494", Offset = "0xA2B494", VA = "0xA2B494")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B69")]
			[Address(RVA = "0xA2B49C", Offset = "0xA2B49C", VA = "0xA2B49C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700012C")]
		public ShaderPropertyBool EmptyNoiseEnabled
		{
			[Token(Token = "0x6000B6A")]
			[Address(RVA = "0xA2B4A4", Offset = "0xA2B4A4", VA = "0xA2B4A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B6B")]
			[Address(RVA = "0xA2B4AC", Offset = "0xA2B4AC", VA = "0xA2B4AC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700012D")]
		public ShaderPropertyFloat EmptyNoiseScale
		{
			[Token(Token = "0x6000B6C")]
			[Address(RVA = "0xA2B4B4", Offset = "0xA2B4B4", VA = "0xA2B4B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B6D")]
			[Address(RVA = "0xA2B4BC", Offset = "0xA2B4BC", VA = "0xA2B4BC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700012E")]
		public ShaderPropertyFloat EmptyNoiseStrength
		{
			[Token(Token = "0x6000B6E")]
			[Address(RVA = "0xA2B4C4", Offset = "0xA2B4C4", VA = "0xA2B4C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B6F")]
			[Address(RVA = "0xA2B4CC", Offset = "0xA2B4CC", VA = "0xA2B4CC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700012F")]
		public ShaderPropertyVector2 EmptyNoiseOffset
		{
			[Token(Token = "0x6000B70")]
			[Address(RVA = "0xA2B4D4", Offset = "0xA2B4D4", VA = "0xA2B4D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B71")]
			[Address(RVA = "0xA2B4DC", Offset = "0xA2B4DC", VA = "0xA2B4DC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000130")]
		public ShaderPropertyBool ContentNoiseEnabled
		{
			[Token(Token = "0x6000B72")]
			[Address(RVA = "0xA2B4E4", Offset = "0xA2B4E4", VA = "0xA2B4E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B73")]
			[Address(RVA = "0xA2B4EC", Offset = "0xA2B4EC", VA = "0xA2B4EC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000131")]
		public ShaderPropertyFloat ContentNoiseScale
		{
			[Token(Token = "0x6000B74")]
			[Address(RVA = "0xA2B4FC", Offset = "0xA2B4FC", VA = "0xA2B4FC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B75")]
			[Address(RVA = "0xA2B504", Offset = "0xA2B504", VA = "0xA2B504")]
			private set
			{
			}
		}

		[Token(Token = "0x17000132")]
		public ShaderPropertyFloat ContentNoiseStrength
		{
			[Token(Token = "0x6000B76")]
			[Address(RVA = "0xA2B514", Offset = "0xA2B514", VA = "0xA2B514")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B77")]
			[Address(RVA = "0xA2B51C", Offset = "0xA2B51C", VA = "0xA2B51C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000133")]
		public ShaderPropertyVector2 ContentNoiseOffset
		{
			[Token(Token = "0x6000B78")]
			[Address(RVA = "0xA2B52C", Offset = "0xA2B52C", VA = "0xA2B52C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B79")]
			[Address(RVA = "0xA2B534", Offset = "0xA2B534", VA = "0xA2B534")]
			private set
			{
			}
		}

		[Token(Token = "0x17000134")]
		public ShaderPropertyBool PulsateWhenLow
		{
			[Token(Token = "0x6000B7A")]
			[Address(RVA = "0xA2B544", Offset = "0xA2B544", VA = "0xA2B544")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B7B")]
			[Address(RVA = "0xA2B54C", Offset = "0xA2B54C", VA = "0xA2B54C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000135")]
		public ShaderPropertyColor PulseColor
		{
			[Token(Token = "0x6000B7C")]
			[Address(RVA = "0xA2B55C", Offset = "0xA2B55C", VA = "0xA2B55C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B7D")]
			[Address(RVA = "0xA2B564", Offset = "0xA2B564", VA = "0xA2B564")]
			private set
			{
			}
		}

		[Token(Token = "0x17000136")]
		public ShaderPropertyFloat PulseSpeed
		{
			[Token(Token = "0x6000B7E")]
			[Address(RVA = "0xA2B574", Offset = "0xA2B574", VA = "0xA2B574")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B7F")]
			[Address(RVA = "0xA2B57C", Offset = "0xA2B57C", VA = "0xA2B57C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000137")]
		public ShaderPropertyFloat PulseActivationThreshold
		{
			[Token(Token = "0x6000B80")]
			[Address(RVA = "0xA2B58C", Offset = "0xA2B58C", VA = "0xA2B58C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B81")]
			[Address(RVA = "0xA2B594", Offset = "0xA2B594", VA = "0xA2B594")]
			private set
			{
			}
		}

		[Token(Token = "0x17000138")]
		public ShaderKeyword OverlayTextureEnabled
		{
			[Token(Token = "0x6000B82")]
			[Address(RVA = "0xA2B5A4", Offset = "0xA2B5A4", VA = "0xA2B5A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B83")]
			[Address(RVA = "0xA2B5AC", Offset = "0xA2B5AC", VA = "0xA2B5AC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000139")]
		public ShaderPropertyTexture2D OverlayTexture
		{
			[Token(Token = "0x6000B84")]
			[Address(RVA = "0xA2B5BC", Offset = "0xA2B5BC", VA = "0xA2B5BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B85")]
			[Address(RVA = "0xA2B5C4", Offset = "0xA2B5C4", VA = "0xA2B5C4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700013A")]
		public ShaderPropertyFloat OverlayTextureOpacity
		{
			[Token(Token = "0x6000B86")]
			[Address(RVA = "0xA2B5D4", Offset = "0xA2B5D4", VA = "0xA2B5D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B87")]
			[Address(RVA = "0xA2B5DC", Offset = "0xA2B5DC", VA = "0xA2B5DC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700013B")]
		public ShaderPropertyVector2 OverlayTextureTiling
		{
			[Token(Token = "0x6000B88")]
			[Address(RVA = "0xA2B5EC", Offset = "0xA2B5EC", VA = "0xA2B5EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B89")]
			[Address(RVA = "0xA2B5F4", Offset = "0xA2B5F4", VA = "0xA2B5F4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700013C")]
		public ShaderPropertyVector2 OverlayTextureOffset
		{
			[Token(Token = "0x6000B8A")]
			[Address(RVA = "0xA2B604", Offset = "0xA2B604", VA = "0xA2B604")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B8B")]
			[Address(RVA = "0xA2B60C", Offset = "0xA2B60C", VA = "0xA2B60C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700013D")]
		public ShaderKeyword InnerTextureEnabled
		{
			[Token(Token = "0x6000B8C")]
			[Address(RVA = "0xA2B61C", Offset = "0xA2B61C", VA = "0xA2B61C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B8D")]
			[Address(RVA = "0xA2B624", Offset = "0xA2B624", VA = "0xA2B624")]
			private set
			{
			}
		}

		[Token(Token = "0x1700013E")]
		public ShaderPropertyTexture2D InnerTexture
		{
			[Token(Token = "0x6000B8E")]
			[Address(RVA = "0xA2B634", Offset = "0xA2B634", VA = "0xA2B634")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B8F")]
			[Address(RVA = "0xA2B63C", Offset = "0xA2B63C", VA = "0xA2B63C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700013F")]
		public ShaderPropertyBool AlignInnerTexture
		{
			[Token(Token = "0x6000B90")]
			[Address(RVA = "0xA2B64C", Offset = "0xA2B64C", VA = "0xA2B64C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B91")]
			[Address(RVA = "0xA2B654", Offset = "0xA2B654", VA = "0xA2B654")]
			private set
			{
			}
		}

		[Token(Token = "0x17000140")]
		public ShaderPropertyBool InnerTextureScaleWithSegments
		{
			[Token(Token = "0x6000B92")]
			[Address(RVA = "0xA2B664", Offset = "0xA2B664", VA = "0xA2B664")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B93")]
			[Address(RVA = "0xA2B66C", Offset = "0xA2B66C", VA = "0xA2B66C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000141")]
		public ShaderPropertyFloat InnerTextureOpacity
		{
			[Token(Token = "0x6000B94")]
			[Address(RVA = "0xA2B67C", Offset = "0xA2B67C", VA = "0xA2B67C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B95")]
			[Address(RVA = "0xA2B684", Offset = "0xA2B684", VA = "0xA2B684")]
			private set
			{
			}
		}

		[Token(Token = "0x17000142")]
		public ShaderPropertyVector2 InnerTextureTiling
		{
			[Token(Token = "0x6000B96")]
			[Address(RVA = "0xA2B694", Offset = "0xA2B694", VA = "0xA2B694")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B97")]
			[Address(RVA = "0xA2B69C", Offset = "0xA2B69C", VA = "0xA2B69C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000143")]
		public ShaderPropertyVector2 InnerTextureOffset
		{
			[Token(Token = "0x6000B98")]
			[Address(RVA = "0xA2B6AC", Offset = "0xA2B6AC", VA = "0xA2B6AC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B99")]
			[Address(RVA = "0xA2B6B4", Offset = "0xA2B6B4", VA = "0xA2B6B4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000144")]
		public ShaderKeyword BorderTextureEnabled
		{
			[Token(Token = "0x6000B9A")]
			[Address(RVA = "0xA2B6C4", Offset = "0xA2B6C4", VA = "0xA2B6C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B9B")]
			[Address(RVA = "0xA2B6CC", Offset = "0xA2B6CC", VA = "0xA2B6CC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000145")]
		public ShaderPropertyTexture2D BorderTexture
		{
			[Token(Token = "0x6000B9C")]
			[Address(RVA = "0xA2B6DC", Offset = "0xA2B6DC", VA = "0xA2B6DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B9D")]
			[Address(RVA = "0xA2B6E4", Offset = "0xA2B6E4", VA = "0xA2B6E4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000146")]
		public ShaderPropertyBool AlignBorderTexture
		{
			[Token(Token = "0x6000B9E")]
			[Address(RVA = "0xA2B6F4", Offset = "0xA2B6F4", VA = "0xA2B6F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B9F")]
			[Address(RVA = "0xA2B6FC", Offset = "0xA2B6FC", VA = "0xA2B6FC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000147")]
		public ShaderPropertyBool BorderTextureScaleWithSegments
		{
			[Token(Token = "0x6000BA0")]
			[Address(RVA = "0xA2B70C", Offset = "0xA2B70C", VA = "0xA2B70C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BA1")]
			[Address(RVA = "0xA2B714", Offset = "0xA2B714", VA = "0xA2B714")]
			private set
			{
			}
		}

		[Token(Token = "0x17000148")]
		public ShaderPropertyFloat BorderTextureOpacity
		{
			[Token(Token = "0x6000BA2")]
			[Address(RVA = "0xA2B724", Offset = "0xA2B724", VA = "0xA2B724")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BA3")]
			[Address(RVA = "0xA2B72C", Offset = "0xA2B72C", VA = "0xA2B72C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000149")]
		public ShaderPropertyVector2 BorderTextureTiling
		{
			[Token(Token = "0x6000BA4")]
			[Address(RVA = "0xA2B73C", Offset = "0xA2B73C", VA = "0xA2B73C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BA5")]
			[Address(RVA = "0xA2B744", Offset = "0xA2B744", VA = "0xA2B744")]
			private set
			{
			}
		}

		[Token(Token = "0x1700014A")]
		public ShaderPropertyVector2 BorderTextureOffset
		{
			[Token(Token = "0x6000BA6")]
			[Address(RVA = "0xA2B754", Offset = "0xA2B754", VA = "0xA2B754")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BA7")]
			[Address(RVA = "0xA2B75C", Offset = "0xA2B75C", VA = "0xA2B75C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700014B")]
		public ShaderKeyword EmptyTextureEnabled
		{
			[Token(Token = "0x6000BA8")]
			[Address(RVA = "0xA2B76C", Offset = "0xA2B76C", VA = "0xA2B76C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BA9")]
			[Address(RVA = "0xA2B774", Offset = "0xA2B774", VA = "0xA2B774")]
			private set
			{
			}
		}

		[Token(Token = "0x1700014C")]
		public ShaderPropertyTexture2D EmptyTexture
		{
			[Token(Token = "0x6000BAA")]
			[Address(RVA = "0xA2B784", Offset = "0xA2B784", VA = "0xA2B784")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BAB")]
			[Address(RVA = "0xA2B78C", Offset = "0xA2B78C", VA = "0xA2B78C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700014D")]
		public ShaderPropertyBool AlignEmptyTexture
		{
			[Token(Token = "0x6000BAC")]
			[Address(RVA = "0xA2B79C", Offset = "0xA2B79C", VA = "0xA2B79C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BAD")]
			[Address(RVA = "0xA2B7A4", Offset = "0xA2B7A4", VA = "0xA2B7A4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700014E")]
		public ShaderPropertyBool EmptyTextureScaleWithSegments
		{
			[Token(Token = "0x6000BAE")]
			[Address(RVA = "0xA2B7B4", Offset = "0xA2B7B4", VA = "0xA2B7B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BAF")]
			[Address(RVA = "0xA2B7BC", Offset = "0xA2B7BC", VA = "0xA2B7BC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700014F")]
		public ShaderPropertyFloat EmptyTextureOpacity
		{
			[Token(Token = "0x6000BB0")]
			[Address(RVA = "0xA2B7CC", Offset = "0xA2B7CC", VA = "0xA2B7CC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BB1")]
			[Address(RVA = "0xA2B7D4", Offset = "0xA2B7D4", VA = "0xA2B7D4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000150")]
		public ShaderPropertyVector2 EmptyTextureTiling
		{
			[Token(Token = "0x6000BB2")]
			[Address(RVA = "0xA2B7E4", Offset = "0xA2B7E4", VA = "0xA2B7E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BB3")]
			[Address(RVA = "0xA2B7EC", Offset = "0xA2B7EC", VA = "0xA2B7EC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000151")]
		public ShaderPropertyVector2 EmptyTextureOffset
		{
			[Token(Token = "0x6000BB4")]
			[Address(RVA = "0xA2B7FC", Offset = "0xA2B7FC", VA = "0xA2B7FC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BB5")]
			[Address(RVA = "0xA2B804", Offset = "0xA2B804", VA = "0xA2B804")]
			private set
			{
			}
		}

		[Token(Token = "0x17000152")]
		public ShaderKeyword SpaceTextureEnabled
		{
			[Token(Token = "0x6000BB6")]
			[Address(RVA = "0xA2B814", Offset = "0xA2B814", VA = "0xA2B814")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BB7")]
			[Address(RVA = "0xA2B81C", Offset = "0xA2B81C", VA = "0xA2B81C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000153")]
		public ShaderPropertyTexture2D SpaceTexture
		{
			[Token(Token = "0x6000BB8")]
			[Address(RVA = "0xA2B82C", Offset = "0xA2B82C", VA = "0xA2B82C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BB9")]
			[Address(RVA = "0xA2B834", Offset = "0xA2B834", VA = "0xA2B834")]
			private set
			{
			}
		}

		[Token(Token = "0x17000154")]
		public ShaderPropertyBool AlignSpaceTexture
		{
			[Token(Token = "0x6000BBA")]
			[Address(RVA = "0xA2B844", Offset = "0xA2B844", VA = "0xA2B844")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BBB")]
			[Address(RVA = "0xA2B84C", Offset = "0xA2B84C", VA = "0xA2B84C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000155")]
		public ShaderPropertyFloat SpaceTextureOpacity
		{
			[Token(Token = "0x6000BBC")]
			[Address(RVA = "0xA2B85C", Offset = "0xA2B85C", VA = "0xA2B85C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BBD")]
			[Address(RVA = "0xA2B864", Offset = "0xA2B864", VA = "0xA2B864")]
			private set
			{
			}
		}

		[Token(Token = "0x17000156")]
		public ShaderPropertyVector2 SpaceTextureTiling
		{
			[Token(Token = "0x6000BBE")]
			[Address(RVA = "0xA2B874", Offset = "0xA2B874", VA = "0xA2B874")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BBF")]
			[Address(RVA = "0xA2B87C", Offset = "0xA2B87C", VA = "0xA2B87C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000157")]
		public ShaderPropertyVector2 SpaceTextureOffset
		{
			[Token(Token = "0x6000BC0")]
			[Address(RVA = "0xA2B88C", Offset = "0xA2B88C", VA = "0xA2B88C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BC1")]
			[Address(RVA = "0xA2B894", Offset = "0xA2B894", VA = "0xA2B894")]
			private set
			{
			}
		}

		[Token(Token = "0x17000158")]
		public ShaderPropertyGradient InnerGradient
		{
			[Token(Token = "0x6000BC2")]
			[Address(RVA = "0xA2B8A4", Offset = "0xA2B8A4", VA = "0xA2B8A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BC3")]
			[Address(RVA = "0xA2B8AC", Offset = "0xA2B8AC", VA = "0xA2B8AC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000159")]
		public ShaderPropertyBool InnerGradientEnabled
		{
			[Token(Token = "0x6000BC4")]
			[Address(RVA = "0xA2B8BC", Offset = "0xA2B8BC", VA = "0xA2B8BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BC5")]
			[Address(RVA = "0xA2B8C4", Offset = "0xA2B8C4", VA = "0xA2B8C4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700015A")]
		public ShaderPropertyBool ValueAsGradientTimeInner
		{
			[Token(Token = "0x6000BC6")]
			[Address(RVA = "0xA2B8D4", Offset = "0xA2B8D4", VA = "0xA2B8D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BC7")]
			[Address(RVA = "0xA2B8DC", Offset = "0xA2B8DC", VA = "0xA2B8DC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700015B")]
		public ShaderPropertyGradient EmptyGradient
		{
			[Token(Token = "0x6000BC8")]
			[Address(RVA = "0xA2B8EC", Offset = "0xA2B8EC", VA = "0xA2B8EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BC9")]
			[Address(RVA = "0xA2B8F4", Offset = "0xA2B8F4", VA = "0xA2B8F4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700015C")]
		public ShaderPropertyBool EmptyGradientEnabled
		{
			[Token(Token = "0x6000BCA")]
			[Address(RVA = "0xA2B904", Offset = "0xA2B904", VA = "0xA2B904")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BCB")]
			[Address(RVA = "0xA2B90C", Offset = "0xA2B90C", VA = "0xA2B90C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700015D")]
		public ShaderPropertyBool ValueAsGradientTimeEmpty
		{
			[Token(Token = "0x6000BCC")]
			[Address(RVA = "0xA2B91C", Offset = "0xA2B91C", VA = "0xA2B91C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BCD")]
			[Address(RVA = "0xA2B924", Offset = "0xA2B924", VA = "0xA2B924")]
			private set
			{
			}
		}

		[Token(Token = "0x1700015E")]
		public ShaderPropertyAnimationCurve VariableWidthCurve
		{
			[Token(Token = "0x6000BCE")]
			[Address(RVA = "0xA2B934", Offset = "0xA2B934", VA = "0xA2B934")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BCF")]
			[Address(RVA = "0xA2B93C", Offset = "0xA2B93C", VA = "0xA2B93C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700015F")]
		public ShaderPropertyBool FillClockwise
		{
			[Token(Token = "0x6000BD0")]
			[Address(RVA = "0xA2B94C", Offset = "0xA2B94C", VA = "0xA2B94C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BD1")]
			[Address(RVA = "0xA2B954", Offset = "0xA2B954", VA = "0xA2B954")]
			private set
			{
			}
		}

		[Token(Token = "0x17000160")]
		private Material ActiveMaterial
		{
			[Token(Token = "0x6000BD2")]
			[Address(RVA = "0xA2B964", Offset = "0xA2B964", VA = "0xA2B964")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000161")]
		private string BaseMaterialName
		{
			[Token(Token = "0x6000BD3")]
			[Address(RVA = "0xA2B99C", Offset = "0xA2B99C", VA = "0xA2B99C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000BD4")]
		[Address(RVA = "0xA2BA88", Offset = "0xA2BA88", VA = "0xA2BA88")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000BD5")]
		[Address(RVA = "0xA2F418", Offset = "0xA2F418", VA = "0xA2F418")]
		private void Update()
		{
		}

		[Token(Token = "0x6000BD6")]
		[Address(RVA = "0xA2F820", Offset = "0xA2F820", VA = "0xA2F820")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000BD7")]
		[Address(RVA = "0xA2AF44", Offset = "0xA2AF44", VA = "0xA2AF44")]
		private void GenerateRequiredComponents(bool useExisting)
		{
		}

		[Token(Token = "0x6000BD8")]
		[Address(RVA = "0xA2BAC0", Offset = "0xA2BAC0", VA = "0xA2BAC0")]
		private void InitProperties()
		{
		}

		[Token(Token = "0x6000BD9")]
		public bool GetShaderProperty<T>(string propertyName, out ShaderProperty<T> shaderProperty)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BDA")]
		[Address(RVA = "0xA2FCCC", Offset = "0xA2FCCC", VA = "0xA2FCCC", Slot = "10")]
		public bool GetShaderKeyword(string propertyName, out ShaderKeyword shaderKeyword)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BDB")]
		public bool GetShaderPropertyValue<T>(string propertyName, out T value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BDC")]
		public bool SetShaderPropertyValue<T>(string propertyName, T value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BDD")]
		[Address(RVA = "0xA2FDA4", Offset = "0xA2FDA4", VA = "0xA2FDA4", Slot = "12")]
		public bool GetShaderKeywordValue(string propertyName, out bool value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BDE")]
		[Address(RVA = "0xA2FE70", Offset = "0xA2FE70", VA = "0xA2FE70", Slot = "13")]
		public bool SetShaderKeywordValue(string propertyName, bool value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BDF")]
		[Address(RVA = "0xA2FF3C", Offset = "0xA2FF3C", VA = "0xA2FF3C")]
		private bool BoolPropertyFunc(int id, bool setInShader, bool value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BE0")]
		[Address(RVA = "0xA30024", Offset = "0xA30024", VA = "0xA30024")]
		private float FloatPropertyFunc(int id, bool setInShader, float value)
		{
			return default(float);
		}

		[Token(Token = "0x6000BE1")]
		[Address(RVA = "0xA30090", Offset = "0xA30090", VA = "0xA30090")]
		private Color ColorPropertyFunc(int id, bool setInShader, Color value)
		{
			return default(Color);
		}

		[Token(Token = "0x6000BE2")]
		[Address(RVA = "0xA30134", Offset = "0xA30134", VA = "0xA30134")]
		private Vector2 VectorPropertyFunc(int id, bool setInShader, Vector2 value)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000BE3")]
		[Address(RVA = "0xA301C8", Offset = "0xA301C8", VA = "0xA301C8")]
		private Texture2D TexturePropertyFunc(int id, bool setInShader, Texture2D value)
		{
			return null;
		}

		[Token(Token = "0x6000BE4")]
		[Address(RVA = "0xA30284", Offset = "0xA30284", VA = "0xA30284")]
		private Gradient GradientPropertyFunc(int id, bool setInShader, Gradient value)
		{
			return null;
		}

		[Token(Token = "0x6000BE5")]
		[Address(RVA = "0xA302F4", Offset = "0xA302F4", VA = "0xA302F4")]
		private AnimationCurve CurvePropertyFunc(int id, bool setInShader, AnimationCurve value)
		{
			return null;
		}

		[Token(Token = "0x6000BE6")]
		[Address(RVA = "0xA30364", Offset = "0xA30364", VA = "0xA30364")]
		private bool KeywordFunc(string id, bool setInShader, bool value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BE7")]
		[Address(RVA = "0xA2F888", Offset = "0xA2F888", VA = "0xA2F888")]
		private void AssignMaterial(Image r)
		{
		}

		[Token(Token = "0x6000BE8")]
		[Address(RVA = "0xA2FA4C", Offset = "0xA2FA4C", VA = "0xA2FA4C")]
		private void AssignMaterial(SpriteRenderer r)
		{
		}

		[Token(Token = "0x6000BE9")]
		[Address(RVA = "0xA2F638", Offset = "0xA2F638", VA = "0xA2F638")]
		private void ApplyToShader(bool ignoreDirty)
		{
		}

		[Token(Token = "0x6000BEA")]
		[Address(RVA = "0xA303E4", Offset = "0xA303E4", VA = "0xA303E4")]
		private void ResetPublicFields()
		{
		}

		[Token(Token = "0x6000BEB")]
		[Address(RVA = "0xA305CC", Offset = "0xA305CC", VA = "0xA305CC")]
		public void ResetPropertiesToDefault()
		{
		}

		[Token(Token = "0x6000BEC")]
		[Address(RVA = "0xA307CC", Offset = "0xA307CC", VA = "0xA307CC", Slot = "14")]
		public void SetSegmentCount(float value)
		{
		}

		[Token(Token = "0x6000BED")]
		[Address(RVA = "0xA30830", Offset = "0xA30830", VA = "0xA30830", Slot = "6")]
		public void SetRemovedSegments(float value)
		{
		}

		[Token(Token = "0x6000BEE")]
		[Address(RVA = "0xA308B8", Offset = "0xA308B8", VA = "0xA308B8", Slot = "7")]
		public void SetPercent(float value)
		{
		}

		[Token(Token = "0x6000BEF")]
		[Address(RVA = "0xA30944", Offset = "0xA30944", VA = "0xA30944", Slot = "15")]
		public void AddRemoveSegments(float value)
		{
		}

		[Token(Token = "0x6000BF0")]
		[Address(RVA = "0xA309E8", Offset = "0xA309E8", VA = "0xA309E8", Slot = "16")]
		public void AddRemovePercent(float value)
		{
		}

		[Token(Token = "0x6000BF1")]
		[Address(RVA = "0xA30A9C", Offset = "0xA30A9C", VA = "0xA30A9C", Slot = "4")]
		public string GetParentName()
		{
			return null;
		}

		[Token(Token = "0x6000BF2")]
		[Address(RVA = "0xA30AA4", Offset = "0xA30AA4", VA = "0xA30AA4", Slot = "5")]
		public string GetName()
		{
			return null;
		}

		[Token(Token = "0x6000BF3")]
		[Address(RVA = "0xA30AAC", Offset = "0xA30AAC", VA = "0xA30AAC")]
		public RadialSegmentedHealthBar()
		{
		}
	}
	[Token(Token = "0x200020E")]
	public interface IShaderProperty
	{
		[Token(Token = "0x6000BF4")]
		void Reset();

		[Token(Token = "0x6000BF5")]
		void ResetToDefault();

		[Token(Token = "0x6000BF6")]
		bool ApplyToShader(bool ignoreDirty);
	}
	[Serializable]
	[Token(Token = "0x200020F")]
	public class ShaderKeyword : IShaderProperty
	{
		[Token(Token = "0x4000E6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private bool _value;

		[Token(Token = "0x4000E6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		private bool <IsDirty>k__BackingField;

		[Token(Token = "0x4000E70")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly string _keywordId;

		[Token(Token = "0x4000E71")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Func<string, bool, bool, bool> _keywordFunc;

		[Token(Token = "0x4000E72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _defaultValue;

		[Token(Token = "0x17000162")]
		public bool Value
		{
			[Token(Token = "0x6000BF7")]
			[Address(RVA = "0x9897F4", Offset = "0x9897F4", VA = "0x9897F4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000BF8")]
			[Address(RVA = "0x9897FC", Offset = "0x9897FC", VA = "0x9897FC")]
			set
			{
			}
		}

		[Token(Token = "0x17000163")]
		public bool IsDirty
		{
			[Token(Token = "0x6000BF9")]
			[Address(RVA = "0x989810", Offset = "0x989810", VA = "0x989810")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000BFA")]
			[Address(RVA = "0x989818", Offset = "0x989818", VA = "0x989818")]
			set
			{
			}
		}

		[Token(Token = "0x6000BFB")]
		[Address(RVA = "0x989824", Offset = "0x989824", VA = "0x989824")]
		public ShaderKeyword(string keywordId, Func<string, bool, bool, bool> keywordFunc, bool value = false, [Optional] ShaderKeyword ancestor)
		{
		}

		[Token(Token = "0x6000BFC")]
		[Address(RVA = "0x989894", Offset = "0x989894", VA = "0x989894", Slot = "4")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000BFD")]
		[Address(RVA = "0x9898D4", Offset = "0x9898D4", VA = "0x9898D4", Slot = "5")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x6000BFE")]
		[Address(RVA = "0x9898E8", Offset = "0x9898E8", VA = "0x9898E8", Slot = "6")]
		public bool ApplyToShader(bool ignoreDirty)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Token(Token = "0x2000210")]
	public class ShaderProperty<T> : IShaderProperty
	{
		[Token(Token = "0x4000E73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected T _value;

		[Token(Token = "0x4000E74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool <IsDirty>k__BackingField;

		[Token(Token = "0x4000E75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected readonly int _propertyId;

		[Token(Token = "0x4000E76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected Func<int, bool, T, T> _propertyFunc;

		[Token(Token = "0x4000E77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected T _defaultValue;

		[Token(Token = "0x17000164")]
		public T Value
		{
			[Token(Token = "0x6000BFF")]
			get
			{
				return (T)null;
			}
			[Token(Token = "0x6000C00")]
			set
			{
			}
		}

		[Token(Token = "0x17000165")]
		public bool IsDirty
		{
			[Token(Token = "0x6000C01")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000C02")]
			set
			{
			}
		}

		[Token(Token = "0x6000C03")]
		public ShaderProperty(string propertyName, Func<int, bool, T, T> propertyFunc, [Optional] T value, [Optional] ShaderProperty<T> ancestor)
		{
		}

		[Token(Token = "0x6000C04")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000C05")]
		public virtual void ResetToDefault()
		{
		}

		[Token(Token = "0x6000C06")]
		public bool ApplyToShader(bool ignoreDirty)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Token(Token = "0x2000211")]
	public class ShaderPropertyFloat : ShaderProperty<float>
	{
		[Token(Token = "0x6000C07")]
		[Address(RVA = "0x989948", Offset = "0x989948", VA = "0x989948")]
		public ShaderPropertyFloat(string propertyName, Func<int, bool, float, float> propertyFunc, float value = 0f, [Optional] ShaderPropertyFloat ancestor)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000212")]
	public class ShaderPropertyBool : ShaderProperty<bool>
	{
		[Token(Token = "0x6000C08")]
		[Address(RVA = "0x9899C8", Offset = "0x9899C8", VA = "0x9899C8")]
		public ShaderPropertyBool(string propertyName, Func<int, bool, bool, bool> propertyFunc, bool value = false, [Optional] ShaderPropertyBool ancestor)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000213")]
	public class ShaderPropertyVector2 : ShaderProperty<Vector2>
	{
		[Token(Token = "0x6000C09")]
		[Address(RVA = "0x989A40", Offset = "0x989A40", VA = "0x989A40")]
		public ShaderPropertyVector2(string propertyName, Func<int, bool, Vector2, Vector2> propertyFunc, [Optional] Vector2 value, [Optional] ShaderPropertyVector2 ancestor)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000214")]
	public class ShaderPropertyColor : ShaderProperty<Color>
	{
		[Token(Token = "0x6000C0A")]
		[Address(RVA = "0x989AC8", Offset = "0x989AC8", VA = "0x989AC8")]
		public ShaderPropertyColor(string propertyName, Func<int, bool, Color, Color> propertyFunc, [Optional] Color value, [Optional] ShaderPropertyColor ancestor)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000215")]
	public class ShaderPropertyTexture2D : ShaderProperty<Texture2D>
	{
		[Token(Token = "0x6000C0B")]
		[Address(RVA = "0x989B68", Offset = "0x989B68", VA = "0x989B68")]
		public ShaderPropertyTexture2D(string propertyName, Func<int, bool, Texture2D, Texture2D> propertyFunc, [Optional] Texture2D value, [Optional] ShaderPropertyTexture2D ancestor)
		{
		}

		[Token(Token = "0x6000C0C")]
		[Address(RVA = "0x989C14", Offset = "0x989C14", VA = "0x989C14", Slot = "7")]
		public override void ResetToDefault()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000216")]
	public class ShaderPropertyGradient : ShaderProperty<Gradient>
	{
		[Token(Token = "0x6000C0D")]
		[Address(RVA = "0x989C18", Offset = "0x989C18", VA = "0x989C18")]
		public ShaderPropertyGradient(string propertyName, Func<int, bool, Gradient, Gradient> propertyFunc, [Optional] Gradient value, [Optional] ShaderPropertyGradient ancestor)
		{
		}

		[Token(Token = "0x6000C0E")]
		[Address(RVA = "0x989E3C", Offset = "0x989E3C", VA = "0x989E3C", Slot = "7")]
		public override void ResetToDefault()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000217")]
	public class ShaderPropertyAnimationCurve : ShaderProperty<AnimationCurve>
	{
		[Token(Token = "0x6000C0F")]
		[Address(RVA = "0x989E40", Offset = "0x989E40", VA = "0x989E40")]
		public ShaderPropertyAnimationCurve(string propertyName, Func<int, bool, AnimationCurve, AnimationCurve> propertyFunc, [Optional] AnimationCurve value, [Optional] ShaderPropertyAnimationCurve ancestor)
		{
		}

		[Token(Token = "0x6000C10")]
		[Address(RVA = "0x989FF4", Offset = "0x989FF4", VA = "0x989FF4", Slot = "7")]
		public override void ResetToDefault()
		{
		}
	}
	[Token(Token = "0x2000218")]
	public class StatusBarsManager
	{
		[Token(Token = "0x2000219")]
		private sealed class <>c__DisplayClass21_0
		{
			[Token(Token = "0x4000E7B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float value;

			[Token(Token = "0x6000C17")]
			[Address(RVA = "0x98AC9C", Offset = "0x98AC9C", VA = "0x98AC9C")]
			public <>c__DisplayClass21_0()
			{
			}

			[Token(Token = "0x6000C18")]
			[Address(RVA = "0x98ACA4", Offset = "0x98ACA4", VA = "0x98ACA4")]
			internal void <SetPercent>b__0(ISegmentedHealthBar hb)
			{
			}
		}

		[Token(Token = "0x200021A")]
		private sealed class <>c__DisplayClass29_0<T>
		{
			[Token(Token = "0x4000E7C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string propertyName;

			[Token(Token = "0x4000E7D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T value;

			[Token(Token = "0x6000C19")]
			public <>c__DisplayClass29_0()
			{
			}

			[Token(Token = "0x6000C1A")]
			internal void <SetShaderPropertyValue>b__0(ISegmentedHealthBar hb)
			{
			}
		}

		[Token(Token = "0x4000E78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static StatusBarsManager _instance;

		[Token(Token = "0x4000E79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool enabled;

		[Token(Token = "0x4000E7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Dictionary<string, Dictionary<string, List<ISegmentedHealthBar>>> _healthBars;

		[Token(Token = "0x17000166")]
		private static StatusBarsManager InternalInstance
		{
			[Token(Token = "0x6000C11")]
			[Address(RVA = "0x98A048", Offset = "0x98A048", VA = "0x98A048")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000C12")]
		[Address(RVA = "0x98A0C8", Offset = "0x98A0C8", VA = "0x98A0C8")]
		private StatusBarsManager()
		{
		}

		[Token(Token = "0x6000C13")]
		[Address(RVA = "0x98A158", Offset = "0x98A158", VA = "0x98A158")]
		public static void AddHealthBar(ISegmentedHealthBar healthBar)
		{
		}

		[Token(Token = "0x6000C14")]
		[Address(RVA = "0x98A72C", Offset = "0x98A72C", VA = "0x98A72C")]
		public static void RemoveHealthBar(ISegmentedHealthBar healthBar, bool removeAll)
		{
		}

		[Token(Token = "0x6000C15")]
		[Address(RVA = "0x98AB2C", Offset = "0x98AB2C", VA = "0x98AB2C")]
		public static void SetPercent(string parentName, string healthBarName, float value)
		{
		}

		[Token(Token = "0x6000C16")]
		public static bool SetShaderPropertyValue<T>(string parentName, string healthBarName, string propertyName, T value)
		{
			return default(bool);
		}
	}
}
namespace RengeGames.HealthBars.Extensions
{
	[Token(Token = "0x200021B")]
	public static class UCHBExtensions
	{
		[Token(Token = "0x6000C1B")]
		[Address(RVA = "0x98AD58", Offset = "0x98AD58", VA = "0x98AD58")]
		public static Texture2D ToTexture2D(this AnimationCurve curve, int width = 500, int height = 1)
		{
			return null;
		}

		[Token(Token = "0x6000C1C")]
		[Address(RVA = "0x98AE94", Offset = "0x98AE94", VA = "0x98AE94")]
		public static Texture2D ToTexture2D(this Gradient gradient, int width = 250, int height = 1)
		{
			return null;
		}

		[Token(Token = "0x6000C1D")]
		[Address(RVA = "0x989CEC", Offset = "0x989CEC", VA = "0x989CEC")]
		public static Gradient Clone(this Gradient gradient)
		{
			return null;
		}

		[Token(Token = "0x6000C1E")]
		[Address(RVA = "0x989F2C", Offset = "0x989F2C", VA = "0x989F2C")]
		public static AnimationCurve Clone(this AnimationCurve curve)
		{
			return null;
		}
	}
}
namespace RengeGames.HealthBars.Demo
{
	[Token(Token = "0x200021C")]
	public class DemoHealthController : MonoBehaviour
	{
		[Token(Token = "0x4000E7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string parentName;

		[Token(Token = "0x4000E7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string healthBarName;

		[Token(Token = "0x4000E80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool updateFromScript;

		[Token(Token = "0x4000E81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float value;

		[Token(Token = "0x4000E82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public RadialSegmentedHealthBar exampleHealthBar;

		[Token(Token = "0x6000C1F")]
		[Address(RVA = "0x98B010", Offset = "0x98B010", VA = "0x98B010")]
		private void Start()
		{
		}

		[Token(Token = "0x6000C20")]
		[Address(RVA = "0x98B078", Offset = "0x98B078", VA = "0x98B078")]
		private void Update()
		{
		}

		[Token(Token = "0x6000C21")]
		[Address(RVA = "0x98B094", Offset = "0x98B094", VA = "0x98B094")]
		public void SetHealthPercent(float value)
		{
		}

		[Token(Token = "0x6000C22")]
		[Address(RVA = "0x98B0FC", Offset = "0x98B0FC", VA = "0x98B0FC")]
		public void ToggleNoise(bool toggle)
		{
		}

		[Token(Token = "0x6000C23")]
		[Address(RVA = "0x98B16C", Offset = "0x98B16C", VA = "0x98B16C")]
		public void Instantiate()
		{
		}

		[Token(Token = "0x6000C24")]
		[Address(RVA = "0x98B3EC", Offset = "0x98B3EC", VA = "0x98B3EC")]
		public DemoHealthController()
		{
		}
	}
}
namespace SciFiArsenal
{
	[Token(Token = "0x200021D")]
	public class SciFiBeamScript : MonoBehaviour
	{
		[Token(Token = "0x4000E83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject[] beamLineRendererPrefab;

		[Token(Token = "0x4000E84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject[] beamStartPrefab;

		[Token(Token = "0x4000E85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject[] beamEndPrefab;

		[Token(Token = "0x4000E86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int currentBeam;

		[Token(Token = "0x4000E87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private GameObject beamStart;

		[Token(Token = "0x4000E88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private GameObject beamEnd;

		[Token(Token = "0x4000E89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private GameObject beam;

		[Token(Token = "0x4000E8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private LineRenderer line;

		[Token(Token = "0x4000E8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float beamEndOffset;

		[Token(Token = "0x4000E8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float textureScrollSpeed;

		[Token(Token = "0x4000E8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float textureLengthScale;

		[Token(Token = "0x4000E8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Slider endOffSetSlider;

		[Token(Token = "0x4000E8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Slider scrollSpeedSlider;

		[Token(Token = "0x4000E90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Text textBeamName;

		[Token(Token = "0x6000C25")]
		[Address(RVA = "0x98B480", Offset = "0x98B480", VA = "0x98B480")]
		private void Start()
		{
		}

		[Token(Token = "0x6000C26")]
		[Address(RVA = "0x98B5C0", Offset = "0x98B5C0", VA = "0x98B5C0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000C27")]
		[Address(RVA = "0x98BE1C", Offset = "0x98BE1C", VA = "0x98BE1C")]
		public void nextBeam()
		{
		}

		[Token(Token = "0x6000C28")]
		[Address(RVA = "0x98BEFC", Offset = "0x98BEFC", VA = "0x98BEFC")]
		public void previousBeam()
		{
		}

		[Token(Token = "0x6000C29")]
		[Address(RVA = "0x98BFDC", Offset = "0x98BFDC", VA = "0x98BFDC")]
		public void UpdateEndOffset()
		{
		}

		[Token(Token = "0x6000C2A")]
		[Address(RVA = "0x98C00C", Offset = "0x98C00C", VA = "0x98C00C")]
		public void UpdateScrollSpeed()
		{
		}

		[Token(Token = "0x6000C2B")]
		[Address(RVA = "0x98B9F8", Offset = "0x98B9F8", VA = "0x98B9F8")]
		private void ShootBeamInDir(Vector3 start, Vector3 dir)
		{
		}

		[Token(Token = "0x6000C2C")]
		[Address(RVA = "0x98C03C", Offset = "0x98C03C", VA = "0x98C03C")]
		public SciFiBeamScript()
		{
		}
	}
	[Token(Token = "0x200021E")]
	public class SciFiButtonScript : MonoBehaviour
	{
		[Token(Token = "0x4000E91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject Button;

		[Token(Token = "0x4000E92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Text MyButtonText;

		[Token(Token = "0x4000E93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string projectileParticleName;

		[Token(Token = "0x4000E94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private SciFiFireProjectile effectScript;

		[Token(Token = "0x4000E95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private SciFiProjectileScript projectileScript;

		[Token(Token = "0x4000E96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float buttonsX;

		[Token(Token = "0x4000E97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float buttonsY;

		[Token(Token = "0x4000E98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float buttonsSizeX;

		[Token(Token = "0x4000E99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float buttonsSizeY;

		[Token(Token = "0x4000E9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float buttonsDistance;

		[Token(Token = "0x6000C2D")]
		[Address(RVA = "0x98C058", Offset = "0x98C058", VA = "0x98C058")]
		private void Start()
		{
		}

		[Token(Token = "0x6000C2E")]
		[Address(RVA = "0x98C214", Offset = "0x98C214", VA = "0x98C214")]
		private void Update()
		{
		}

		[Token(Token = "0x6000C2F")]
		[Address(RVA = "0x98C160", Offset = "0x98C160", VA = "0x98C160")]
		public void getProjectileNames()
		{
		}

		[Token(Token = "0x6000C30")]
		[Address(RVA = "0x98C240", Offset = "0x98C240", VA = "0x98C240")]
		public bool overButton()
		{
			return default(bool);
		}

		[Token(Token = "0x6000C31")]
		[Address(RVA = "0x98C318", Offset = "0x98C318", VA = "0x98C318")]
		public SciFiButtonScript()
		{
		}
	}
	[Token(Token = "0x200021F")]
	public class SciFiDragMouseOrbit : MonoBehaviour
	{
		[Token(Token = "0x4000E9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000E9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float distance;

		[Token(Token = "0x4000E9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float xSpeed;

		[Token(Token = "0x4000E9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float ySpeed;

		[Token(Token = "0x4000E9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float yMinLimit;

		[Token(Token = "0x4000EA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float yMaxLimit;

		[Token(Token = "0x4000EA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float distanceMin;

		[Token(Token = "0x4000EA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float distanceMax;

		[Token(Token = "0x4000EA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float smoothTime;

		[Token(Token = "0x4000EA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float rotationYAxis;

		[Token(Token = "0x4000EA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float rotationXAxis;

		[Token(Token = "0x4000EA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float velocityX;

		[Token(Token = "0x4000EA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float velocityY;

		[Token(Token = "0x6000C32")]
		[Address(RVA = "0x98C320", Offset = "0x98C320", VA = "0x98C320")]
		private void Start()
		{
		}

		[Token(Token = "0x6000C33")]
		[Address(RVA = "0x98C3EC", Offset = "0x98C3EC", VA = "0x98C3EC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000C34")]
		[Address(RVA = "0x98C768", Offset = "0x98C768", VA = "0x98C768")]
		public static float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000C35")]
		[Address(RVA = "0x98C7A4", Offset = "0x98C7A4", VA = "0x98C7A4")]
		public SciFiDragMouseOrbit()
		{
		}
	}
	[Token(Token = "0x2000220")]
	public class SciFiFireProjectile : MonoBehaviour
	{
		[Token(Token = "0x4000EA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		public GameObject[] projectiles;

		[Token(Token = "0x4000EA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform spawnPosition;

		[Token(Token = "0x4000EAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int currentProjectile;

		[Token(Token = "0x4000EAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float speed;

		[Token(Token = "0x4000EAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private SciFiButtonScript selectedProjectileButton;

		[Token(Token = "0x4000EAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private RaycastHit hit;

		[Token(Token = "0x6000C36")]
		[Address(RVA = "0x98C7C0", Offset = "0x98C7C0", VA = "0x98C7C0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000C37")]
		[Address(RVA = "0x98C83C", Offset = "0x98C83C", VA = "0x98C83C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000C38")]
		[Address(RVA = "0x98CC0C", Offset = "0x98CC0C", VA = "0x98CC0C")]
		public void nextEffect()
		{
		}

		[Token(Token = "0x6000C39")]
		[Address(RVA = "0x98CC48", Offset = "0x98CC48", VA = "0x98CC48")]
		public void previousEffect()
		{
		}

		[Token(Token = "0x6000C3A")]
		[Address(RVA = "0x98CC84", Offset = "0x98CC84", VA = "0x98CC84")]
		public void AdjustSpeed(float newSpeed)
		{
		}

		[Token(Token = "0x6000C3B")]
		[Address(RVA = "0x98CC8C", Offset = "0x98CC8C", VA = "0x98CC8C")]
		public SciFiFireProjectile()
		{
		}
	}
	[Token(Token = "0x2000221")]
	public class SciFiLoadSceneOnClick : MonoBehaviour
	{
		[Token(Token = "0x4000EAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool GUIHide;

		[Token(Token = "0x4000EAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool GUIHide2;

		[Token(Token = "0x4000EB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool GUIHide3;

		[Token(Token = "0x4000EB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		public bool GUIHide4;

		[Token(Token = "0x6000C3C")]
		[Address(RVA = "0x98CC9C", Offset = "0x98CC9C", VA = "0x98CC9C")]
		public void LoadSceneSciFiProjectiles()
		{
		}

		[Token(Token = "0x6000C3D")]
		[Address(RVA = "0x98CD04", Offset = "0x98CD04", VA = "0x98CD04")]
		public void LoadSceneSciFiBeamup()
		{
		}

		[Token(Token = "0x6000C3E")]
		[Address(RVA = "0x98CD6C", Offset = "0x98CD6C", VA = "0x98CD6C")]
		public void LoadSceneSciFiBuff()
		{
		}

		[Token(Token = "0x6000C3F")]
		[Address(RVA = "0x98CDD4", Offset = "0x98CDD4", VA = "0x98CDD4")]
		public void LoadSceneSciFiFlamethrowers2()
		{
		}

		[Token(Token = "0x6000C40")]
		[Address(RVA = "0x98CE3C", Offset = "0x98CE3C", VA = "0x98CE3C")]
		public void LoadSceneSciFiQuestZone()
		{
		}

		[Token(Token = "0x6000C41")]
		[Address(RVA = "0x98CEA4", Offset = "0x98CEA4", VA = "0x98CEA4")]
		public void LoadSceneSciFiLightjump()
		{
		}

		[Token(Token = "0x6000C42")]
		[Address(RVA = "0x98CF0C", Offset = "0x98CF0C", VA = "0x98CF0C")]
		public void LoadSceneSciFiLoot()
		{
		}

		[Token(Token = "0x6000C43")]
		[Address(RVA = "0x98CF74", Offset = "0x98CF74", VA = "0x98CF74")]
		public void LoadSceneSciFiBeams()
		{
		}

		[Token(Token = "0x6000C44")]
		[Address(RVA = "0x98CFDC", Offset = "0x98CFDC", VA = "0x98CFDC")]
		public void LoadSceneSciFiPortals()
		{
		}

		[Token(Token = "0x6000C45")]
		[Address(RVA = "0x98D044", Offset = "0x98D044", VA = "0x98D044")]
		public void LoadSceneSciFiRegenerate()
		{
		}

		[Token(Token = "0x6000C46")]
		[Address(RVA = "0x98D0AC", Offset = "0x98D0AC", VA = "0x98D0AC")]
		public void LoadSceneSciFiShields()
		{
		}

		[Token(Token = "0x6000C47")]
		[Address(RVA = "0x98D114", Offset = "0x98D114", VA = "0x98D114")]
		public void LoadSceneSciFiSwirlyAura()
		{
		}

		[Token(Token = "0x6000C48")]
		[Address(RVA = "0x98D17C", Offset = "0x98D17C", VA = "0x98D17C")]
		public void LoadSceneSciFiWarpgates()
		{
		}

		[Token(Token = "0x6000C49")]
		[Address(RVA = "0x98D1E4", Offset = "0x98D1E4", VA = "0x98D1E4")]
		public void LoadSceneSciFiJetflame()
		{
		}

		[Token(Token = "0x6000C4A")]
		[Address(RVA = "0x98D24C", Offset = "0x98D24C", VA = "0x98D24C")]
		public void LoadSceneSciFiUltimateNova()
		{
		}

		[Token(Token = "0x6000C4B")]
		[Address(RVA = "0x98D2B4", Offset = "0x98D2B4", VA = "0x98D2B4")]
		public void LoadSceneSciFiFire()
		{
		}

		[Token(Token = "0x6000C4C")]
		[Address(RVA = "0x98D31C", Offset = "0x98D31C", VA = "0x98D31C")]
		public void LoadSceneSciFiUpdate6()
		{
		}

		[Token(Token = "0x6000C4D")]
		[Address(RVA = "0x98D384", Offset = "0x98D384", VA = "0x98D384")]
		public void LoadSceneSciFiUpdate7()
		{
		}

		[Token(Token = "0x6000C4E")]
		[Address(RVA = "0x98D3EC", Offset = "0x98D3EC", VA = "0x98D3EC")]
		public void LoadSceneSciFiUpdate8()
		{
		}

		[Token(Token = "0x6000C4F")]
		[Address(RVA = "0x98D454", Offset = "0x98D454", VA = "0x98D454")]
		public void LoadSceneSciFiUpdate9()
		{
		}

		[Token(Token = "0x6000C50")]
		[Address(RVA = "0x98D4BC", Offset = "0x98D4BC", VA = "0x98D4BC")]
		public void LoadSceneSciFiUpdate10()
		{
		}

		[Token(Token = "0x6000C51")]
		[Address(RVA = "0x98D524", Offset = "0x98D524", VA = "0x98D524")]
		public void LoadSceneSciFiUpdate11()
		{
		}

		[Token(Token = "0x6000C52")]
		[Address(RVA = "0x98D58C", Offset = "0x98D58C", VA = "0x98D58C")]
		public void LoadSceneSciFiUpdate12()
		{
		}

		[Token(Token = "0x6000C53")]
		[Address(RVA = "0x98D5F4", Offset = "0x98D5F4", VA = "0x98D5F4")]
		public void LoadSceneSciFiBlood()
		{
		}

		[Token(Token = "0x6000C54")]
		[Address(RVA = "0x98D65C", Offset = "0x98D65C", VA = "0x98D65C")]
		public void LoadSceneSciFiRoundZone()
		{
		}

		[Token(Token = "0x6000C55")]
		[Address(RVA = "0x98D6C4", Offset = "0x98D6C4", VA = "0x98D6C4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000C56")]
		[Address(RVA = "0x98D884", Offset = "0x98D884", VA = "0x98D884")]
		public SciFiLoadSceneOnClick()
		{
		}
	}
	[Token(Token = "0x2000222")]
	public class SciFiLoopScript : MonoBehaviour
	{
		[Token(Token = "0x2000223")]
		private sealed class <EffectLoop>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000EB4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000EB5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000EB6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SciFiLoopScript <>4__this;

			[Token(Token = "0x4000EB7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private GameObject <effectPlayer>5__2;

			[Token(Token = "0x17000167")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000C5E")]
				[Address(RVA = "0x98DB54", Offset = "0x98DB54", VA = "0x98DB54", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000168")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000C60")]
				[Address(RVA = "0x98DB9C", Offset = "0x98DB9C", VA = "0x98DB9C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000C5B")]
			[Address(RVA = "0x98D950", Offset = "0x98D950", VA = "0x98D950")]
			[DebuggerHidden]
			public <EffectLoop>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000C5C")]
			[Address(RVA = "0x98D988", Offset = "0x98D988", VA = "0x98D988", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000C5D")]
			[Address(RVA = "0x98D98C", Offset = "0x98D98C", VA = "0x98D98C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000C5F")]
			[Address(RVA = "0x98DB5C", Offset = "0x98DB5C", VA = "0x98DB5C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000EB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject chosenEffect;

		[Token(Token = "0x4000EB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float loopTimeLimit;

		[Token(Token = "0x6000C57")]
		[Address(RVA = "0x98D88C", Offset = "0x98D88C", VA = "0x98D88C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000C58")]
		[Address(RVA = "0x98D890", Offset = "0x98D890", VA = "0x98D890")]
		public void PlayEffect()
		{
		}

		[Token(Token = "0x6000C59")]
		[Address(RVA = "0x98D8DC", Offset = "0x98D8DC", VA = "0x98D8DC")]
		private IEnumerator EffectLoop()
		{
			return null;
		}

		[Token(Token = "0x6000C5A")]
		[Address(RVA = "0x98D978", Offset = "0x98D978", VA = "0x98D978")]
		public SciFiLoopScript()
		{
		}
	}
	[Token(Token = "0x2000224")]
	public class SciFiProjectileScript : MonoBehaviour
	{
		[Token(Token = "0x4000EB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject impactParticle;

		[Token(Token = "0x4000EB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject projectileParticle;

		[Token(Token = "0x4000EBA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject muzzleParticle;

		[Token(Token = "0x4000EBB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject[] trailParticles;

		[Token(Token = "0x4000EBC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 impactNormal;

		[Token(Token = "0x4000EBD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool hasCollided;

		[Token(Token = "0x6000C61")]
		[Address(RVA = "0x98DBA4", Offset = "0x98DBA4", VA = "0x98DBA4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000C62")]
		[Address(RVA = "0x98DEA0", Offset = "0x98DEA0", VA = "0x98DEA0")]
		private void OnCollisionEnter(Collision hit)
		{
		}

		[Token(Token = "0x6000C63")]
		[Address(RVA = "0x98E2B8", Offset = "0x98E2B8", VA = "0x98E2B8")]
		public SciFiProjectileScript()
		{
		}
	}
	[Token(Token = "0x2000225")]
	public class SciFiLightFade : MonoBehaviour
	{
		[Token(Token = "0x4000EBE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float life;

		[Token(Token = "0x4000EBF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool killAfterLife;

		[Token(Token = "0x4000EC0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Light li;

		[Token(Token = "0x4000EC1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float initIntensity;

		[Token(Token = "0x6000C64")]
		[Address(RVA = "0x98E2C0", Offset = "0x98E2C0", VA = "0x98E2C0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000C65")]
		[Address(RVA = "0x98E3DC", Offset = "0x98E3DC", VA = "0x98E3DC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000C66")]
		[Address(RVA = "0x98E518", Offset = "0x98E518", VA = "0x98E518")]
		public SciFiLightFade()
		{
		}
	}
	[Token(Token = "0x2000226")]
	public class SciFiPitchRandomizer : MonoBehaviour
	{
		[Token(Token = "0x4000EC2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float randomPercent;

		[Token(Token = "0x6000C67")]
		[Address(RVA = "0x98E534", Offset = "0x98E534", VA = "0x98E534")]
		private void Start()
		{
		}

		[Token(Token = "0x6000C68")]
		[Address(RVA = "0x98E5E4", Offset = "0x98E5E4", VA = "0x98E5E4")]
		public SciFiPitchRandomizer()
		{
		}
	}
	[Token(Token = "0x2000227")]
	public class SciFiRotation : MonoBehaviour
	{
		[Token(Token = "0x2000228")]
		public enum spaceEnum
		{
			[Token(Token = "0x4000EC6")]
			Local,
			[Token(Token = "0x4000EC7")]
			World
		}

		[Token(Token = "0x4000EC3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 rotateVector;

		[Token(Token = "0x4000EC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public spaceEnum rotateSpace;

		[Token(Token = "0x6000C69")]
		[Address(RVA = "0x98E5F4", Offset = "0x98E5F4", VA = "0x98E5F4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000C6A")]
		[Address(RVA = "0x98E6C8", Offset = "0x98E6C8", VA = "0x98E6C8")]
		public SciFiRotation()
		{
		}
	}
}
namespace UnityTemplateProjects
{
	[Token(Token = "0x2000229")]
	public class SimpleCameraController : MonoBehaviour
	{
		[Token(Token = "0x200022A")]
		private class CameraState
		{
			[Token(Token = "0x4000ECF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float yaw;

			[Token(Token = "0x4000ED0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pitch;

			[Token(Token = "0x4000ED1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float roll;

			[Token(Token = "0x4000ED2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float x;

			[Token(Token = "0x4000ED3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float y;

			[Token(Token = "0x4000ED4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float z;

			[Token(Token = "0x6000C6F")]
			[Address(RVA = "0x98E77C", Offset = "0x98E77C", VA = "0x98E77C")]
			public void SetFromTransform(Transform t)
			{
			}

			[Token(Token = "0x6000C70")]
			[Address(RVA = "0x98ECD4", Offset = "0x98ECD4", VA = "0x98ECD4")]
			public void Translate(Vector3 translation)
			{
			}

			[Token(Token = "0x6000C71")]
			[Address(RVA = "0x98ED54", Offset = "0x98ED54", VA = "0x98ED54")]
			public void LerpTowards(CameraState target, float positionLerpPct, float rotationLerpPct)
			{
			}

			[Token(Token = "0x6000C72")]
			[Address(RVA = "0x98EDDC", Offset = "0x98EDDC", VA = "0x98EDDC")]
			public void UpdateTransform(Transform t)
			{
			}

			[Token(Token = "0x6000C73")]
			[Address(RVA = "0x98F000", Offset = "0x98F000", VA = "0x98F000")]
			public CameraState()
			{
			}
		}

		[Token(Token = "0x4000EC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CameraState m_TargetCameraState;

		[Token(Token = "0x4000EC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private CameraState m_InterpolatingCameraState;

		[Token(Token = "0x4000ECA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float boost;

		[Token(Token = "0x4000ECB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0.001f, 1f)]
		public float positionLerpTime;

		[Token(Token = "0x4000ECC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve mouseSensitivityCurve;

		[Token(Token = "0x4000ECD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0.001f, 1f)]
		public float rotationLerpTime;

		[Token(Token = "0x4000ECE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool invertY;

		[Token(Token = "0x6000C6B")]
		[Address(RVA = "0x98E728", Offset = "0x98E728", VA = "0x98E728")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000C6C")]
		[Address(RVA = "0x98E800", Offset = "0x98E800", VA = "0x98E800")]
		private Vector3 GetInputTranslationDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000C6D")]
		[Address(RVA = "0x98EA30", Offset = "0x98EA30", VA = "0x98EA30")]
		private void Update()
		{
		}

		[Token(Token = "0x6000C6E")]
		[Address(RVA = "0x98EE24", Offset = "0x98EE24", VA = "0x98EE24")]
		public SimpleCameraController()
		{
		}
	}
}
namespace KevinIglesias
{
	[Token(Token = "0x200022B")]
	public class BowLoadScript : MonoBehaviour
	{
		[Token(Token = "0x4000ED5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bow;

		[Token(Token = "0x4000ED6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform arrowHandRetargeter;

		[Token(Token = "0x4000ED7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bowHandRetargeter;

		[Token(Token = "0x4000ED8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private SkinnedMeshRenderer bowSkinnedMeshRenderer;

		[Token(Token = "0x4000ED9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool arrowOnHand;

		[Token(Token = "0x4000EDA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform arrowToDraw;

		[Token(Token = "0x4000EDB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform arrowToShoot;

		[Token(Token = "0x6000C74")]
		[Address(RVA = "0x98F008", Offset = "0x98F008", VA = "0x98F008")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000C75")]
		[Address(RVA = "0x98F140", Offset = "0x98F140", VA = "0x98F140")]
		private void Update()
		{
		}

		[Token(Token = "0x6000C76")]
		[Address(RVA = "0x98F458", Offset = "0x98F458", VA = "0x98F458")]
		public BowLoadScript()
		{
		}
	}
	[Token(Token = "0x200022C")]
	public class AddCastEffect : StateMachineBehaviour
	{
		[Token(Token = "0x4000EDC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CastSpells cS;

		[Token(Token = "0x4000EDD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CastHand castHand;

		[Token(Token = "0x6000C77")]
		[Address(RVA = "0x98F460", Offset = "0x98F460", VA = "0x98F460", Slot = "4")]
		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x6000C78")]
		[Address(RVA = "0x98F680", Offset = "0x98F680", VA = "0x98F680")]
		public AddCastEffect()
		{
		}
	}
	[Token(Token = "0x200022D")]
	public enum CastHand
	{
		[Token(Token = "0x4000EDF")]
		RightHand,
		[Token(Token = "0x4000EE0")]
		LeftHand
	}
	[Token(Token = "0x200022E")]
	public class CastSpells : MonoBehaviour
	{
		[Token(Token = "0x200022F")]
		private sealed class <SpawnFireball>d__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000EE9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000EEA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000EEB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CastHand hand;

			[Token(Token = "0x4000EEC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public CastSpells <>4__this;

			[Token(Token = "0x4000EED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float delay;

			[Token(Token = "0x4000EEE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Transform <handT>5__2;

			[Token(Token = "0x17000169")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000C88")]
				[Address(RVA = "0x98FF10", Offset = "0x98FF10", VA = "0x98FF10", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700016A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000C8A")]
				[Address(RVA = "0x98FF58", Offset = "0x98FF58", VA = "0x98FF58", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000C85")]
			[Address(RVA = "0x98F948", Offset = "0x98F948", VA = "0x98F948")]
			[DebuggerHidden]
			public <SpawnFireball>d__12(int <>1__state)
			{
			}

			[Token(Token = "0x6000C86")]
			[Address(RVA = "0x98FB28", Offset = "0x98FB28", VA = "0x98FB28", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000C87")]
			[Address(RVA = "0x98FB2C", Offset = "0x98FB2C", VA = "0x98FB2C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000C89")]
			[Address(RVA = "0x98FF18", Offset = "0x98FF18", VA = "0x98FF18", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000230")]
		private sealed class <SpawnHealing>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000EEF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000EF0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000EF1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CastHand hand;

			[Token(Token = "0x4000EF2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public CastSpells <>4__this;

			[Token(Token = "0x4000EF3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float delay;

			[Token(Token = "0x4000EF4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Transform <handT>5__2;

			[Token(Token = "0x4000EF5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Transform <t>5__3;

			[Token(Token = "0x4000EF6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 <startSize>5__4;

			[Token(Token = "0x4000EF7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private float <i>5__5;

			[Token(Token = "0x1700016B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000C8E")]
				[Address(RVA = "0x990480", Offset = "0x990480", VA = "0x990480", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700016C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000C90")]
				[Address(RVA = "0x9904C8", Offset = "0x9904C8", VA = "0x9904C8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000C8B")]
			[Address(RVA = "0x98F970", Offset = "0x98F970", VA = "0x98F970")]
			[DebuggerHidden]
			public <SpawnHealing>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x6000C8C")]
			[Address(RVA = "0x98FF60", Offset = "0x98FF60", VA = "0x98FF60", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000C8D")]
			[Address(RVA = "0x98FF64", Offset = "0x98FF64", VA = "0x98FF64", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000C8F")]
			[Address(RVA = "0x990488", Offset = "0x990488", VA = "0x990488", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000231")]
		private sealed class <SpawnNova>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000EF8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000EF9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000EFA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float delay;

			[Token(Token = "0x4000EFB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public CastSpells <>4__this;

			[Token(Token = "0x4000EFC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private GameObject <newNova>5__2;

			[Token(Token = "0x4000EFD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Transform <t>5__3;

			[Token(Token = "0x4000EFE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Vector3 <startSize>5__4;

			[Token(Token = "0x4000EFF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float <i>5__5;

			[Token(Token = "0x4000F00")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private Renderer <r>5__6;

			[Token(Token = "0x4000F01")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Color <initColor>5__7;

			[Token(Token = "0x4000F02")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private Color <endColor>5__8;

			[Token(Token = "0x1700016D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000C94")]
				[Address(RVA = "0x990A50", Offset = "0x990A50", VA = "0x990A50", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700016E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000C96")]
				[Address(RVA = "0x990A98", Offset = "0x990A98", VA = "0x990A98", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000C91")]
			[Address(RVA = "0x98F998", Offset = "0x98F998", VA = "0x98F998")]
			[DebuggerHidden]
			public <SpawnNova>d__15(int <>1__state)
			{
			}

			[Token(Token = "0x6000C92")]
			[Address(RVA = "0x9904D0", Offset = "0x9904D0", VA = "0x9904D0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000C93")]
			[Address(RVA = "0x9904D4", Offset = "0x9904D4", VA = "0x9904D4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000C95")]
			[Address(RVA = "0x990A58", Offset = "0x990A58", VA = "0x990A58", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000232")]
		private sealed class <SpawnShockwave>d__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000F03")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000F04")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000F05")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CastHand hand;

			[Token(Token = "0x4000F06")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public CastSpells <>4__this;

			[Token(Token = "0x4000F07")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float delay;

			[Token(Token = "0x4000F08")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Transform <handT>5__2;

			[Token(Token = "0x4000F09")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private GameObject <newShockwave>5__3;

			[Token(Token = "0x4000F0A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Transform <t>5__4;

			[Token(Token = "0x4000F0B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private Renderer <r>5__5;

			[Token(Token = "0x4000F0C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Color <initColor>5__6;

			[Token(Token = "0x4000F0D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private Color <endColor>5__7;

			[Token(Token = "0x4000F0E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private float <i>5__8;

			[Token(Token = "0x1700016F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000C9A")]
				[Address(RVA = "0x990F3C", Offset = "0x990F3C", VA = "0x990F3C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000170")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000C9C")]
				[Address(RVA = "0x990F84", Offset = "0x990F84", VA = "0x990F84", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000C97")]
			[Address(RVA = "0x98F9C0", Offset = "0x98F9C0", VA = "0x98F9C0")]
			[DebuggerHidden]
			public <SpawnShockwave>d__16(int <>1__state)
			{
			}

			[Token(Token = "0x6000C98")]
			[Address(RVA = "0x990AA0", Offset = "0x990AA0", VA = "0x990AA0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000C99")]
			[Address(RVA = "0x990AA4", Offset = "0x990AA4", VA = "0x990AA4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000C9B")]
			[Address(RVA = "0x990F44", Offset = "0x990F44", VA = "0x990F44", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000233")]
		private sealed class <AppearFireball>d__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000F0F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000F10")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000F11")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform t;

			[Token(Token = "0x4000F12")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 <startSize>5__2;

			[Token(Token = "0x4000F13")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <i>5__3;

			[Token(Token = "0x17000171")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000CA0")]
				[Address(RVA = "0x991104", Offset = "0x991104", VA = "0x991104", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000172")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000CA2")]
				[Address(RVA = "0x99114C", Offset = "0x99114C", VA = "0x99114C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000C9D")]
			[Address(RVA = "0x98FA5C", Offset = "0x98FA5C", VA = "0x98FA5C")]
			[DebuggerHidden]
			public <AppearFireball>d__17(int <>1__state)
			{
			}

			[Token(Token = "0x6000C9E")]
			[Address(RVA = "0x990F8C", Offset = "0x990F8C", VA = "0x990F8C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000C9F")]
			[Address(RVA = "0x990F90", Offset = "0x990F90", VA = "0x990F90", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000CA1")]
			[Address(RVA = "0x99110C", Offset = "0x99110C", VA = "0x99110C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000234")]
		private sealed class <MoveFireball>d__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000F14")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000F15")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000F16")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform t;

			[Token(Token = "0x4000F17")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 <initPosition>5__2;

			[Token(Token = "0x4000F18")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <i>5__3;

			[Token(Token = "0x17000173")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000CA6")]
				[Address(RVA = "0x9912D8", Offset = "0x9912D8", VA = "0x9912D8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000174")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000CA8")]
				[Address(RVA = "0x991320", Offset = "0x991320", VA = "0x991320", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000CA3")]
			[Address(RVA = "0x98FAF8", Offset = "0x98FAF8", VA = "0x98FAF8")]
			[DebuggerHidden]
			public <MoveFireball>d__18(int <>1__state)
			{
			}

			[Token(Token = "0x6000CA4")]
			[Address(RVA = "0x991154", Offset = "0x991154", VA = "0x991154", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000CA5")]
			[Address(RVA = "0x991158", Offset = "0x991158", VA = "0x991158", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000CA7")]
			[Address(RVA = "0x9912E0", Offset = "0x9912E0", VA = "0x9912E0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000EE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform rightHand;

		[Token(Token = "0x4000EE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform leftHand;

		[Token(Token = "0x4000EE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 handOffset;

		[Token(Token = "0x4000EE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float spellOffset;

		[Token(Token = "0x4000EE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject spellPrefab;

		[Token(Token = "0x4000EE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public GameObject castEffectPrefab;

		[Token(Token = "0x4000EE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public GameObject castEffectR;

		[Token(Token = "0x4000EE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public GameObject castEffectL;

		[Token(Token = "0x6000C79")]
		[Address(RVA = "0x98F688", Offset = "0x98F688", VA = "0x98F688")]
		public void ThrowFireball(CastHand hand, float delay)
		{
		}

		[Token(Token = "0x6000C7A")]
		[Address(RVA = "0x98F73C", Offset = "0x98F73C", VA = "0x98F73C")]
		public void ThrowNova(float delay)
		{
		}

		[Token(Token = "0x6000C7B")]
		[Address(RVA = "0x98F7E0", Offset = "0x98F7E0", VA = "0x98F7E0")]
		public void ThrowHealing(CastHand hand, float delay)
		{
		}

		[Token(Token = "0x6000C7C")]
		[Address(RVA = "0x98F894", Offset = "0x98F894", VA = "0x98F894")]
		public void ThrowShockwave(CastHand hand, float delay)
		{
		}

		[Token(Token = "0x6000C7D")]
		[Address(RVA = "0x98F6A8", Offset = "0x98F6A8", VA = "0x98F6A8")]
		public IEnumerator SpawnFireball(CastHand hand, float delay)
		{
			return null;
		}

		[Token(Token = "0x6000C7E")]
		[Address(RVA = "0x98F800", Offset = "0x98F800", VA = "0x98F800")]
		public IEnumerator SpawnHealing(CastHand hand, float delay)
		{
			return null;
		}

		[Token(Token = "0x6000C7F")]
		[Address(RVA = "0x98F554", Offset = "0x98F554", VA = "0x98F554")]
		public void SpawnEffect(CastHand hand)
		{
		}

		[Token(Token = "0x6000C80")]
		[Address(RVA = "0x98F75C", Offset = "0x98F75C", VA = "0x98F75C")]
		public IEnumerator SpawnNova(float delay)
		{
			return null;
		}

		[Token(Token = "0x6000C81")]
		[Address(RVA = "0x98F8B4", Offset = "0x98F8B4", VA = "0x98F8B4")]
		public IEnumerator SpawnShockwave(CastHand hand, float delay)
		{
			return null;
		}

		[Token(Token = "0x6000C82")]
		[Address(RVA = "0x98F9E8", Offset = "0x98F9E8", VA = "0x98F9E8")]
		private IEnumerator AppearFireball(Transform t)
		{
			return null;
		}

		[Token(Token = "0x6000C83")]
		[Address(RVA = "0x98FA84", Offset = "0x98FA84", VA = "0x98FA84")]
		private IEnumerator MoveFireball(Transform t)
		{
			return null;
		}

		[Token(Token = "0x6000C84")]
		[Address(RVA = "0x98FB20", Offset = "0x98FB20", VA = "0x98FB20")]
		public CastSpells()
		{
		}
	}
	[Token(Token = "0x2000235")]
	public class ThrowFireball : StateMachineBehaviour
	{
		[Token(Token = "0x4000F19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CastSpells cS;

		[Token(Token = "0x4000F1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CastHand castHand;

		[Token(Token = "0x4000F1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float spawnDelay;

		[Token(Token = "0x6000CA9")]
		[Address(RVA = "0x991328", Offset = "0x991328", VA = "0x991328", Slot = "4")]
		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x6000CAA")]
		[Address(RVA = "0x991434", Offset = "0x991434", VA = "0x991434")]
		public ThrowFireball()
		{
		}
	}
	[Token(Token = "0x2000236")]
	public class ThrowHealing : StateMachineBehaviour
	{
		[Token(Token = "0x4000F1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CastSpells cS;

		[Token(Token = "0x4000F1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CastHand castHand;

		[Token(Token = "0x4000F1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float spawnDelay;

		[Token(Token = "0x6000CAB")]
		[Address(RVA = "0x99143C", Offset = "0x99143C", VA = "0x99143C", Slot = "4")]
		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x6000CAC")]
		[Address(RVA = "0x991548", Offset = "0x991548", VA = "0x991548")]
		public ThrowHealing()
		{
		}
	}
	[Token(Token = "0x2000237")]
	public class ThrowNova : StateMachineBehaviour
	{
		[Token(Token = "0x4000F1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CastSpells cS;

		[Token(Token = "0x4000F20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float spawnDelay;

		[Token(Token = "0x6000CAD")]
		[Address(RVA = "0x991550", Offset = "0x991550", VA = "0x991550", Slot = "4")]
		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x6000CAE")]
		[Address(RVA = "0x991658", Offset = "0x991658", VA = "0x991658")]
		public ThrowNova()
		{
		}
	}
	[Token(Token = "0x2000238")]
	public class ThrowShockwave : StateMachineBehaviour
	{
		[Token(Token = "0x4000F21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CastSpells cS;

		[Token(Token = "0x4000F22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CastHand castHand;

		[Token(Token = "0x4000F23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float spawnDelay;

		[Token(Token = "0x6000CAF")]
		[Address(RVA = "0x991660", Offset = "0x991660", VA = "0x991660", Slot = "4")]
		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x6000CB0")]
		[Address(RVA = "0x99176C", Offset = "0x99176C", VA = "0x99176C")]
		public ThrowShockwave()
		{
		}
	}
	[Token(Token = "0x2000239")]
	public enum SoldierIKGoal
	{
		[Token(Token = "0x4000F25")]
		LeftHand,
		[Token(Token = "0x4000F26")]
		RightHand
	}
	[Token(Token = "0x200023A")]
	public class SoldierHandsIK : MonoBehaviour
	{
		[Token(Token = "0x4000F27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform retargeter;

		[Token(Token = "0x4000F28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform handEffector;

		[Token(Token = "0x4000F29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SoldierIKGoal hand;

		[Token(Token = "0x4000F2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animator animator;

		[Token(Token = "0x4000F2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float weight;

		[Token(Token = "0x6000CB1")]
		[Address(RVA = "0x991774", Offset = "0x991774", VA = "0x991774")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000CB2")]
		[Address(RVA = "0x9917D4", Offset = "0x9917D4", VA = "0x9917D4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000CB3")]
		[Address(RVA = "0x991830", Offset = "0x991830", VA = "0x991830")]
		private void OnAnimatorIK(int layerIndex)
		{
		}

		[Token(Token = "0x6000CB4")]
		[Address(RVA = "0x99193C", Offset = "0x99193C", VA = "0x99193C")]
		public SoldierHandsIK()
		{
		}
	}
	[Token(Token = "0x200023B")]
	public class ChangeSpear : MonoBehaviour
	{
		[Token(Token = "0x200023C")]
		private sealed class <StartChange>d__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000F39")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000F3A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000F3B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ChangeSpear <>4__this;

			[Token(Token = "0x4000F3C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <yRotation>5__2;

			[Token(Token = "0x4000F3D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <i>5__3;

			[Token(Token = "0x17000175")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000CBD")]
				[Address(RVA = "0x991F04", Offset = "0x991F04", VA = "0x991F04", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000176")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000CBF")]
				[Address(RVA = "0x991F4C", Offset = "0x991F4C", VA = "0x991F4C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000CBA")]
			[Address(RVA = "0x991AC0", Offset = "0x991AC0", VA = "0x991AC0")]
			[DebuggerHidden]
			public <StartChange>d__16(int <>1__state)
			{
			}

			[Token(Token = "0x6000CBB")]
			[Address(RVA = "0x991AF0", Offset = "0x991AF0", VA = "0x991AF0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000CBC")]
			[Address(RVA = "0x991AF4", Offset = "0x991AF4", VA = "0x991AF4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000CBE")]
			[Address(RVA = "0x991F0C", Offset = "0x991F0C", VA = "0x991F0C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000F2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform retargeter;

		[Token(Token = "0x4000F2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform spear;

		[Token(Token = "0x4000F2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform hand;

		[Token(Token = "0x4000F2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool changeActive;

		[Token(Token = "0x4000F30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool secondTime;

		[Token(Token = "0x4000F31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform characterRoot;

		[Token(Token = "0x4000F32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 zeroPosition;

		[Token(Token = "0x4000F33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 zeroRotation;

		[Token(Token = "0x4000F34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 startPosition;

		[Token(Token = "0x4000F35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private Quaternion startRotation;

		[Token(Token = "0x4000F36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3 endPosition;

		[Token(Token = "0x4000F37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Quaternion endRotation;

		[Token(Token = "0x4000F38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private IEnumerator changeCO;

		[Token(Token = "0x6000CB5")]
		[Address(RVA = "0x991944", Offset = "0x991944", VA = "0x991944")]
		public void Start()
		{
		}

		[Token(Token = "0x6000CB6")]
		[Address(RVA = "0x9919AC", Offset = "0x9919AC", VA = "0x9919AC")]
		public void Update()
		{
		}

		[Token(Token = "0x6000CB7")]
		[Address(RVA = "0x9919F8", Offset = "0x9919F8", VA = "0x9919F8")]
		public void DoChangeSpear()
		{
		}

		[Token(Token = "0x6000CB8")]
		[Address(RVA = "0x991A4C", Offset = "0x991A4C", VA = "0x991A4C")]
		private IEnumerator StartChange()
		{
			return null;
		}

		[Token(Token = "0x6000CB9")]
		[Address(RVA = "0x991AE8", Offset = "0x991AE8", VA = "0x991AE8")]
		public ChangeSpear()
		{
		}
	}
	[Token(Token = "0x200023D")]
	public class IdleThrowTrick : MonoBehaviour
	{
		[Token(Token = "0x200023E")]
		private sealed class <StartSpin>d__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000F4D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000F4E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000F4F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public IdleThrowTrick <>4__this;

			[Token(Token = "0x4000F50")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <i>5__2;

			[Token(Token = "0x17000177")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000CC8")]
				[Address(RVA = "0x9924B0", Offset = "0x9924B0", VA = "0x9924B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000178")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000CCA")]
				[Address(RVA = "0x9924F8", Offset = "0x9924F8", VA = "0x9924F8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000CC5")]
			[Address(RVA = "0x99212C", Offset = "0x99212C", VA = "0x99212C")]
			[DebuggerHidden]
			public <StartSpin>d__18(int <>1__state)
			{
			}

			[Token(Token = "0x6000CC6")]
			[Address(RVA = "0x99215C", Offset = "0x99215C", VA = "0x99215C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000CC7")]
			[Address(RVA = "0x992160", Offset = "0x992160", VA = "0x992160", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000CC9")]
			[Address(RVA = "0x9924B8", Offset = "0x9924B8", VA = "0x9924B8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000F3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform retargeter;

		[Token(Token = "0x4000F3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform propToThrow;

		[Token(Token = "0x4000F40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform hand;

		[Token(Token = "0x4000F41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float trickDistance;

		[Token(Token = "0x4000F42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float trickTranslationSpeed;

		[Token(Token = "0x4000F43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float trickRotationSpeed;

		[Token(Token = "0x4000F44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool trickActive;

		[Token(Token = "0x4000F45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform characterRoot;

		[Token(Token = "0x4000F46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 zeroPosition;

		[Token(Token = "0x4000F47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Quaternion zeroRotation;

		[Token(Token = "0x4000F48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private Vector3 startPosition;

		[Token(Token = "0x4000F49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion startRotation;

		[Token(Token = "0x4000F4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 endPosition;

		[Token(Token = "0x4000F4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Quaternion endRotation;

		[Token(Token = "0x4000F4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private IEnumerator spinCO;

		[Token(Token = "0x6000CC0")]
		[Address(RVA = "0x991F54", Offset = "0x991F54", VA = "0x991F54")]
		public void Start()
		{
		}

		[Token(Token = "0x6000CC1")]
		[Address(RVA = "0x991FBC", Offset = "0x991FBC", VA = "0x991FBC")]
		public void Update()
		{
		}

		[Token(Token = "0x6000CC2")]
		[Address(RVA = "0x992064", Offset = "0x992064", VA = "0x992064")]
		public void SpinProp()
		{
		}

		[Token(Token = "0x6000CC3")]
		[Address(RVA = "0x9920B8", Offset = "0x9920B8", VA = "0x9920B8")]
		private IEnumerator StartSpin()
		{
			return null;
		}

		[Token(Token = "0x6000CC4")]
		[Address(RVA = "0x992154", Offset = "0x992154", VA = "0x992154")]
		public IdleThrowTrick()
		{
		}
	}
	[Token(Token = "0x200023F")]
	public class ThrowBigAxe : MonoBehaviour
	{
		[Token(Token = "0x2000240")]
		private sealed class <StartSpin>d__20 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000F62")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000F63")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000F64")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ThrowBigAxe <>4__this;

			[Token(Token = "0x4000F65")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <i>5__2;

			[Token(Token = "0x17000179")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000CD3")]
				[Address(RVA = "0x992A68", Offset = "0x992A68", VA = "0x992A68", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700017A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000CD5")]
				[Address(RVA = "0x992AB0", Offset = "0x992AB0", VA = "0x992AB0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000CD0")]
			[Address(RVA = "0x9926D8", Offset = "0x9926D8", VA = "0x9926D8")]
			[DebuggerHidden]
			public <StartSpin>d__20(int <>1__state)
			{
			}

			[Token(Token = "0x6000CD1")]
			[Address(RVA = "0x992708", Offset = "0x992708", VA = "0x992708", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000CD2")]
			[Address(RVA = "0x99270C", Offset = "0x99270C", VA = "0x99270C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000CD4")]
			[Address(RVA = "0x992A70", Offset = "0x992A70", VA = "0x992A70", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000F51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform retargeter;

		[Token(Token = "0x4000F52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform propToSpin;

		[Token(Token = "0x4000F53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform hand;

		[Token(Token = "0x4000F54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float spinDistance;

		[Token(Token = "0x4000F55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float translationSpeed;

		[Token(Token = "0x4000F56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float spinSpeed;

		[Token(Token = "0x4000F57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool spinActive;

		[Token(Token = "0x4000F58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3 endPositionOffset;

		[Token(Token = "0x4000F59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Vector3 returningPositionOffset;

		[Token(Token = "0x4000F5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform characterRoot;

		[Token(Token = "0x4000F5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 zeroPosition;

		[Token(Token = "0x4000F5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Quaternion zeroRotation;

		[Token(Token = "0x4000F5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Vector3 startPosition;

		[Token(Token = "0x4000F5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion startRotation;

		[Token(Token = "0x4000F5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 endPosition;

		[Token(Token = "0x4000F60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Quaternion endRotation;

		[Token(Token = "0x4000F61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private IEnumerator spinCO;

		[Token(Token = "0x6000CCB")]
		[Address(RVA = "0x992500", Offset = "0x992500", VA = "0x992500")]
		public void Awake()
		{
		}

		[Token(Token = "0x6000CCC")]
		[Address(RVA = "0x992568", Offset = "0x992568", VA = "0x992568")]
		public void Update()
		{
		}

		[Token(Token = "0x6000CCD")]
		[Address(RVA = "0x992610", Offset = "0x992610", VA = "0x992610")]
		public void SpinProp()
		{
		}

		[Token(Token = "0x6000CCE")]
		[Address(RVA = "0x992664", Offset = "0x992664", VA = "0x992664")]
		private IEnumerator StartSpin()
		{
			return null;
		}

		[Token(Token = "0x6000CCF")]
		[Address(RVA = "0x992700", Offset = "0x992700", VA = "0x992700")]
		public ThrowBigAxe()
		{
		}
	}
	[Token(Token = "0x2000241")]
	public class ThrowMultipleProps : MonoBehaviour
	{
		[Token(Token = "0x4000F66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform retargeter1;

		[Token(Token = "0x4000F67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform retargeter2;

		[Token(Token = "0x4000F68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform propToThrow1;

		[Token(Token = "0x4000F69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform propToThrow2;

		[Token(Token = "0x4000F6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform hand1;

		[Token(Token = "0x4000F6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform hand2;

		[Token(Token = "0x4000F6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform targetPos;

		[Token(Token = "0x4000F6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float speed;

		[Token(Token = "0x4000F6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float arcHeight;

		[Token(Token = "0x4000F6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool launched1;

		[Token(Token = "0x4000F70")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		public bool launched2;

		[Token(Token = "0x4000F71")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		public bool recoverProp1;

		[Token(Token = "0x4000F72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5B")]
		public bool recoverProp2;

		[Token(Token = "0x4000F73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public bool propLanded1;

		[Token(Token = "0x4000F74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
		public bool propLanded2;

		[Token(Token = "0x4000F75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform characterRoot;

		[Token(Token = "0x4000F76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 startPos1;

		[Token(Token = "0x4000F77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3 startPos2;

		[Token(Token = "0x4000F78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 zeroPosition1;

		[Token(Token = "0x4000F79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Quaternion zeroRotation1;

		[Token(Token = "0x4000F7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 zeroPosition2;

		[Token(Token = "0x4000F7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Quaternion zeroRotation2;

		[Token(Token = "0x4000F7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 nextPos;

		[Token(Token = "0x6000CD6")]
		[Address(RVA = "0x992AB8", Offset = "0x992AB8", VA = "0x992AB8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000CD7")]
		[Address(RVA = "0x992B50", Offset = "0x992B50", VA = "0x992B50")]
		private void Update()
		{
		}

		[Token(Token = "0x6000CD8")]
		[Address(RVA = "0x992FE4", Offset = "0x992FE4", VA = "0x992FE4")]
		private static Quaternion LookAt2D(Vector3 forward)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000CD9")]
		[Address(RVA = "0x993034", Offset = "0x993034", VA = "0x993034")]
		public void Throw1()
		{
		}

		[Token(Token = "0x6000CDA")]
		[Address(RVA = "0x9930D8", Offset = "0x9930D8", VA = "0x9930D8")]
		public void Throw2()
		{
		}

		[Token(Token = "0x6000CDB")]
		[Address(RVA = "0x99307C", Offset = "0x99307C", VA = "0x99307C")]
		public void RecoverProp1()
		{
		}

		[Token(Token = "0x6000CDC")]
		[Address(RVA = "0x993120", Offset = "0x993120", VA = "0x993120")]
		public void RecoverProp2()
		{
		}

		[Token(Token = "0x6000CDD")]
		[Address(RVA = "0x99317C", Offset = "0x99317C", VA = "0x99317C")]
		public ThrowMultipleProps()
		{
		}
	}
	[Token(Token = "0x2000242")]
	public enum PropType
	{
		[Token(Token = "0x4000F7E")]
		Spear,
		[Token(Token = "0x4000F7F")]
		Knife,
		[Token(Token = "0x4000F80")]
		Tomahawk
	}
	[Token(Token = "0x2000243")]
	public class ThrowProp : MonoBehaviour
	{
		[Token(Token = "0x4000F81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform retargeter;

		[Token(Token = "0x4000F82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PropType propType;

		[Token(Token = "0x4000F83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform propToThrow;

		[Token(Token = "0x4000F84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform hand;

		[Token(Token = "0x4000F85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform targetPos;

		[Token(Token = "0x4000F86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float speed;

		[Token(Token = "0x4000F87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float arcHeight;

		[Token(Token = "0x4000F88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool launched;

		[Token(Token = "0x4000F89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		public bool recoverProp;

		[Token(Token = "0x4000F8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
		public bool propLanded;

		[Token(Token = "0x4000F8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform characterRoot;

		[Token(Token = "0x4000F8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 startPos;

		[Token(Token = "0x4000F8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private Vector3 zeroPosition;

		[Token(Token = "0x4000F8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion zeroRotation;

		[Token(Token = "0x4000F8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 nextPos;

		[Token(Token = "0x6000CDE")]
		[Address(RVA = "0x993190", Offset = "0x993190", VA = "0x993190")]
		private void Start()
		{
		}

		[Token(Token = "0x6000CDF")]
		[Address(RVA = "0x9931F8", Offset = "0x9931F8", VA = "0x9931F8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000CE0")]
		[Address(RVA = "0x9935F8", Offset = "0x9935F8", VA = "0x9935F8")]
		private static Quaternion LookAt2D(Vector3 forward)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000CE1")]
		[Address(RVA = "0x993648", Offset = "0x993648", VA = "0x993648")]
		public void Throw()
		{
		}

		[Token(Token = "0x6000CE2")]
		[Address(RVA = "0x99368C", Offset = "0x99368C", VA = "0x99368C")]
		public void RecoverProp()
		{
		}

		[Token(Token = "0x6000CE3")]
		[Address(RVA = "0x9936E8", Offset = "0x9936E8", VA = "0x9936E8")]
		public ThrowProp()
		{
		}
	}
	[Token(Token = "0x2000244")]
	public enum VillagerIKGoal
	{
		[Token(Token = "0x4000F91")]
		LeftHand,
		[Token(Token = "0x4000F92")]
		RightHand
	}
	[Token(Token = "0x2000245")]
	public class VillagerHandsIK : MonoBehaviour
	{
		[Token(Token = "0x4000F93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform retargeter;

		[Token(Token = "0x4000F94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform handEffector;

		[Token(Token = "0x4000F95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public VillagerIKGoal hand;

		[Token(Token = "0x4000F96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animator animator;

		[Token(Token = "0x4000F97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float weight;

		[Token(Token = "0x6000CE4")]
		[Address(RVA = "0x9936FC", Offset = "0x9936FC", VA = "0x9936FC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000CE5")]
		[Address(RVA = "0x99375C", Offset = "0x99375C", VA = "0x99375C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000CE6")]
		[Address(RVA = "0x9937B8", Offset = "0x9937B8", VA = "0x9937B8")]
		private void OnAnimatorIK(int layerIndex)
		{
		}

		[Token(Token = "0x6000CE7")]
		[Address(RVA = "0x9938C4", Offset = "0x9938C4", VA = "0x9938C4")]
		public VillagerHandsIK()
		{
		}
	}
}
