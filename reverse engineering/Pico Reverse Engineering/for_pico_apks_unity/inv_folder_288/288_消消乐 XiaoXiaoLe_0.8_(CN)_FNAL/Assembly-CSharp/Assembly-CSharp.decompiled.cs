using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Networking;
using UnityEngine.UI;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class CaoZuoUI : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject[] uis;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject tiShi;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x885DD8", Offset = "0x885DD8", VA = "0x885DD8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x885DDC", Offset = "0x885DDC", VA = "0x885DDC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x885E78", Offset = "0x885E78", VA = "0x885E78")]
	public CaoZuoUI()
	{
	}
}
[Token(Token = "0x2000003")]
public class DataStatistics : MonoBehaviour
{
	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static DataStatistics initialize;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float totalTime;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int gateNumber;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float fen;

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x8862C8", Offset = "0x8862C8", VA = "0x8862C8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x88631C", Offset = "0x88631C", VA = "0x88631C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x886320", Offset = "0x886320", VA = "0x886320")]
	public void StartJilV()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x88632C", Offset = "0x88632C", VA = "0x88632C")]
	public void AddData(int deFen)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x88634C", Offset = "0x88634C", VA = "0x88634C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x886384", Offset = "0x886384", VA = "0x886384")]
	public DataStatistics()
	{
	}
}
[Token(Token = "0x2000004")]
public class AnimatedButton : UIBehaviour, IPointerDownHandler, IEventSystemHandler
{
	[Serializable]
	[Token(Token = "0x2000050")]
	public class ButtonClickedEvent : UnityEvent
	{
		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x8855D4", Offset = "0x8855D4", VA = "0x8855D4")]
		public ButtonClickedEvent()
		{
		}
	}

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool interactable;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private ButtonClickedEvent m_OnClick;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Animator m_animator;

	[Token(Token = "0x17000001")]
	public ButtonClickedEvent onClick
	{
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x885358", Offset = "0x885358", VA = "0x885358")]
		get
		{
			return null;
		}
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x885360", Offset = "0x885360", VA = "0x885360")]
		set
		{
		}
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x8852F4", Offset = "0x8852F4", VA = "0x8852F4", Slot = "5")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x885368", Offset = "0x885368", VA = "0x885368", Slot = "18")]
	public virtual void OnPointerDown(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x885390", Offset = "0x885390", VA = "0x885390")]
	private void Press()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x88542C", Offset = "0x88542C", VA = "0x88542C")]
	public void Exit()
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x8854A8", Offset = "0x8854A8", VA = "0x8854A8")]
	public bool CheckPlayExit()
	{
		return default(bool);
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x885548", Offset = "0x885548", VA = "0x885548")]
	private void InvokeOnClickAction()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x885564", Offset = "0x885564", VA = "0x885564")]
	public AnimatedButton()
	{
	}
}
[Token(Token = "0x2000005")]
public class BackgroundMusic : MonoBehaviour
{
	[Token(Token = "0x2000051")]
	private enum Fade
	{
		[Token(Token = "0x400014A")]
		In,
		[Token(Token = "0x400014B")]
		Out
	}

	[Token(Token = "0x2000052")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x550FBC", Offset = "0x550FBC")]
	private sealed class <FadeAudio>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Fade fadeType;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float time;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public BackgroundMusic <>4__this;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <start>5__2;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <end>5__3;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <i>5__4;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float <step>5__5;

		[Token(Token = "0x17000006")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001B8")]
			[Address(RVA = "0x885D68", Offset = "0x885D68", VA = "0x885D68", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000007")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001BA")]
			[Address(RVA = "0x885DD0", Offset = "0x885DD0", VA = "0x885DD0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x885BCC", Offset = "0x885BCC", VA = "0x885BCC")]
		[DebuggerHidden]
		public <FadeAudio>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x885C00", Offset = "0x885C00", VA = "0x885C00", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x885C04", Offset = "0x885C04", VA = "0x885C04", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x885D70", Offset = "0x885D70", VA = "0x885D70", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static BackgroundMusic Instance;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private AudioSource m_audioSource;

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x8858B0", Offset = "0x8858B0", VA = "0x8858B0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x885A34", Offset = "0x885A34", VA = "0x885A34")]
	public void FadeIn()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x885B48", Offset = "0x885B48", VA = "0x885B48")]
	public void FadeOut()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x885AB8", Offset = "0x885AB8", VA = "0x885AB8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x551444", Offset = "0x551444")]
	private IEnumerator FadeAudio(float time, Fade fadeType)
	{
		return null;
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x885BF8", Offset = "0x885BF8", VA = "0x885BF8")]
	public BackgroundMusic()
	{
	}
}
[Token(Token = "0x2000006")]
public class ColorSwapper : MonoBehaviour
{
	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Color enabledColor;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Color disabledColor;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool m_swapped;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Image m_image;

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x885F08", Offset = "0x885F08", VA = "0x885F08")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x885F60", Offset = "0x885F60", VA = "0x885F60")]
	public void SwapColor()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x885FC0", Offset = "0x885FC0", VA = "0x885FC0")]
	public ColorSwapper()
	{
	}
}
[Token(Token = "0x2000007")]
public class Fader : MonoBehaviour
{
	[Token(Token = "0x2000053")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x550FCC", Offset = "0x550FCC")]
	private sealed class <RunFadeIn>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Fader <>4__this;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <time>5__2;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <initialAlpha>5__3;

		[Token(Token = "0x17000008")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001BE")]
			[Address(RVA = "0x886E8C", Offset = "0x886E8C", VA = "0x886E8C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000009")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001C0")]
			[Address(RVA = "0x886EF4", Offset = "0x886EF4", VA = "0x886EF4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x886CAC", Offset = "0x886CAC", VA = "0x886CAC")]
		[DebuggerHidden]
		public <RunFadeIn>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x886D14", Offset = "0x886D14", VA = "0x886D14", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x886D18", Offset = "0x886D18", VA = "0x886D18", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x886E94", Offset = "0x886E94", VA = "0x886E94", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000054")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x550FDC", Offset = "0x550FDC")]
	private sealed class <RunFadeOut>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Fader <>4__this;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <time>5__2;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <initialAlpha>5__3;

		[Token(Token = "0x1700000A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001C4")]
			[Address(RVA = "0x887074", Offset = "0x887074", VA = "0x887074", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001C6")]
			[Address(RVA = "0x8870DC", Offset = "0x8870DC", VA = "0x8870DC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x886CD8", Offset = "0x886CD8", VA = "0x886CD8")]
		[DebuggerHidden]
		public <RunFadeOut>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x886EFC", Offset = "0x886EFC", VA = "0x886EFC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x886F00", Offset = "0x886F00", VA = "0x886F00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x88707C", Offset = "0x88707C", VA = "0x88707C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float duration;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private CanvasGroup m_canvasGroup;

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x886B1C", Offset = "0x886B1C", VA = "0x886B1C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x886B74", Offset = "0x886B74", VA = "0x886B74")]
	public void FadeIn()
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x886C10", Offset = "0x886C10", VA = "0x886C10")]
	public void FadeOut()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x886BA0", Offset = "0x886BA0", VA = "0x886BA0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5514A8", Offset = "0x5514A8")]
	private IEnumerator RunFadeIn()
	{
		return null;
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x886C3C", Offset = "0x886C3C", VA = "0x886C3C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x55150C", Offset = "0x55150C")]
	private IEnumerator RunFadeOut()
	{
		return null;
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x886D04", Offset = "0x886D04", VA = "0x886D04")]
	public Fader()
	{
	}
}
[Token(Token = "0x2000008")]
public class InitialPlayerPrefs : MonoBehaviour
{
	[Token(Token = "0x6000021")]
	[Address(RVA = "0x88F844", Offset = "0x88F844", VA = "0x88F844")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x88F8D8", Offset = "0x88F8D8", VA = "0x88F8D8")]
	public InitialPlayerPrefs()
	{
	}
}
[Token(Token = "0x2000009")]
public class LevelScene : MonoBehaviour
{
	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject prevLevelButton;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject nextLevelButton;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject levelGroup;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Text levelText;

	[Token(Token = "0x4000016")]
	private const int numLevelIndexes = 3;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int m_currentLevelIndex;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Animator m_animator;

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x8903B8", Offset = "0x8903B8", VA = "0x8903B8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x890418", Offset = "0x890418", VA = "0x890418")]
	public void ShowPreviousLevels()
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x890978", Offset = "0x890978", VA = "0x890978")]
	public void ShowNextLevels()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x890728", Offset = "0x890728", VA = "0x890728")]
	public void EnablePrevLevelButton()
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x890600", Offset = "0x890600", VA = "0x890600")]
	public void DisablePrevLevelButton()
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x890850", Offset = "0x890850", VA = "0x890850")]
	public void EnableNextLevelButton()
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x890ADC", Offset = "0x890ADC", VA = "0x890ADC")]
	public void DisableNextLevelButton()
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x890570", Offset = "0x890570", VA = "0x890570")]
	private void SetLevelText(int level)
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x890C04", Offset = "0x890C04", VA = "0x890C04")]
	public LevelScene()
	{
	}
}
[Token(Token = "0x200000A")]
public class MusicButton : MonoBehaviour
{
	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private SpriteSwapper m_spriteSwapper;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool m_on;

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x893178", Offset = "0x893178", VA = "0x893178")]
	private void Start()
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x893258", Offset = "0x893258", VA = "0x893258")]
	public void Toggle()
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x893304", Offset = "0x893304", VA = "0x893304")]
	public void ToggleSprite()
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x89332C", Offset = "0x89332C", VA = "0x89332C")]
	public MusicButton()
	{
	}
}
[Token(Token = "0x200000B")]
public class MusicManager : MonoBehaviour
{
	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Slider m_musicSlider;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject m_musicButton;

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x894304", Offset = "0x894304", VA = "0x894304")]
	private void Start()
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x8943AC", Offset = "0x8943AC", VA = "0x8943AC")]
	public void SwitchMusic()
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x8944F0", Offset = "0x8944F0", VA = "0x8944F0")]
	public MusicManager()
	{
	}
}
[Token(Token = "0x200000C")]
public class MuteBackgroundMusic : MonoBehaviour
{
	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private BackgroundMusic m_bgMusic;

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x8944F8", Offset = "0x8944F8", VA = "0x8944F8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x8945F8", Offset = "0x8945F8", VA = "0x8945F8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x894688", Offset = "0x894688", VA = "0x894688")]
	public MuteBackgroundMusic()
	{
	}
}
[Token(Token = "0x200000D")]
public class PlayPopup : Popup
{
	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Color enabledColor;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Color disabledColor;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Image leftStarImage;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Image middleStarImage;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Image rightStarImage;

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x89472C", Offset = "0x89472C", VA = "0x89472C")]
	public void SetAchievedStars(int starsObtained)
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x89487C", Offset = "0x89487C", VA = "0x89487C")]
	public PlayPopup()
	{
	}
}
[Token(Token = "0x200000E")]
public class PlayPopupOpener : PopupOpener
{
	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int starsObtained;

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x8948E0", Offset = "0x8948E0", VA = "0x8948E0", Slot = "4")]
	public override void OpenPopup()
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x894A2C", Offset = "0x894A2C", VA = "0x894A2C")]
	public PlayPopupOpener()
	{
	}
}
[Token(Token = "0x200000F")]
public class Popup : MonoBehaviour
{
	[Token(Token = "0x2000055")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x550FEC", Offset = "0x550FEC")]
	private sealed class <RunPopupDestroy>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Popup <>4__this;

		[Token(Token = "0x1700000C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001CA")]
			[Address(RVA = "0x8950C4", Offset = "0x8950C4", VA = "0x8950C4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001CC")]
			[Address(RVA = "0x89512C", Offset = "0x89512C", VA = "0x89512C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x894FB0", Offset = "0x894FB0", VA = "0x894FB0")]
		[DebuggerHidden]
		public <RunPopupDestroy>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x894FDC", Offset = "0x894FDC", VA = "0x894FDC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x894FE0", Offset = "0x894FE0", VA = "0x894FE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x8950CC", Offset = "0x8950CC", VA = "0x8950CC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Color backgroundColor;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private GameObject m_background;

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x894A28", Offset = "0x894A28", VA = "0x894A28")]
	public void Open()
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x894D8C", Offset = "0x894D8C", VA = "0x894D8C")]
	public void Close()
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x894F40", Offset = "0x894F40", VA = "0x894F40")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x551570", Offset = "0x551570")]
	private IEnumerator RunPopupDestroy()
	{
		return null;
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x894A3C", Offset = "0x894A3C", VA = "0x894A3C")]
	private void AddBackground()
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x894E78", Offset = "0x894E78", VA = "0x894E78")]
	private void RemoveBackground()
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x894880", Offset = "0x894880", VA = "0x894880")]
	public Popup()
	{
	}
}
[Token(Token = "0x2000010")]
public class PopupOpener : MonoBehaviour
{
	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject popupPrefab;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected Canvas m_canvas;

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x895134", Offset = "0x895134", VA = "0x895134")]
	protected void Start()
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x8951A4", Offset = "0x8951A4", VA = "0x8951A4", Slot = "4")]
	public virtual void OpenPopup()
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x894A34", Offset = "0x894A34", VA = "0x894A34")]
	public PopupOpener()
	{
	}
}
[Token(Token = "0x2000011")]
public class SceneTransition : MonoBehaviour
{
	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string scene;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float duration;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Color color;

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x896A80", Offset = "0x896A80", VA = "0x896A80")]
	public void PerformTransition()
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x896C24", Offset = "0x896C24", VA = "0x896C24")]
	public SceneTransition()
	{
	}
}
[Token(Token = "0x2000012")]
public class SoundButton : MonoBehaviour
{
	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private SpriteSwapper m_spriteSwapper;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool m_on;

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x897288", Offset = "0x897288", VA = "0x897288")]
	private void Start()
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x89731C", Offset = "0x89731C", VA = "0x89731C")]
	public void Toggle()
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x897394", Offset = "0x897394", VA = "0x897394")]
	public void ToggleSprite()
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x8973BC", Offset = "0x8973BC", VA = "0x8973BC")]
	public SoundButton()
	{
	}
}
[Token(Token = "0x2000013")]
public class SoundManager : MonoBehaviour
{
	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Slider m_soundSlider;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject m_soundButton;

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x8973C4", Offset = "0x8973C4", VA = "0x8973C4")]
	private void Start()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x89746C", Offset = "0x89746C", VA = "0x89746C")]
	public void SwitchSound()
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x897578", Offset = "0x897578", VA = "0x897578")]
	public SoundManager()
	{
	}
}
[Token(Token = "0x2000014")]
public class SpinWheel : MonoBehaviour
{
	[Token(Token = "0x2000056")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x550FFC", Offset = "0x550FFC")]
	private sealed class <DoSpin>d__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SpinWheel <>4__this;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <timer>5__2;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <startAngle>5__3;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <time>5__4;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <maxAngle>5__5;

		[Token(Token = "0x1700000E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001D0")]
			[Address(RVA = "0x897844", Offset = "0x897844", VA = "0x897844", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001D2")]
			[Address(RVA = "0x8978AC", Offset = "0x8978AC", VA = "0x8978AC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x897628", Offset = "0x897628", VA = "0x897628")]
		[DebuggerHidden]
		public <DoSpin>d__3(int <>1__state)
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x89765C", Offset = "0x89765C", VA = "0x89765C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x897660", Offset = "0x897660", VA = "0x897660", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x89784C", Offset = "0x89784C", VA = "0x89784C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AnimationCurve AnimationCurve;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool m_spinning;

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x897580", Offset = "0x897580", VA = "0x897580")]
	public void Spin()
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x8975B8", Offset = "0x8975B8", VA = "0x8975B8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5515D4", Offset = "0x5515D4")]
	private IEnumerator DoSpin()
	{
		return null;
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x897654", Offset = "0x897654", VA = "0x897654")]
	public SpinWheel()
	{
	}
}
[Token(Token = "0x2000015")]
public class SpriteSwapper : MonoBehaviour
{
	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Sprite enabledSprite;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Sprite disabledSprite;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool m_swapped;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Image m_image;

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x8978B4", Offset = "0x8978B4", VA = "0x8978B4")]
	public void Awake()
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x89320C", Offset = "0x89320C", VA = "0x89320C")]
	public void SwapSprite()
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x89790C", Offset = "0x89790C", VA = "0x89790C")]
	public SpriteSwapper()
	{
	}
}
[Token(Token = "0x2000016")]
public class TintedButton : UIBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerUpHandler, IPointerDownHandler
{
	[Serializable]
	[Token(Token = "0x2000057")]
	public class ButtonClickedEvent : UnityEvent
	{
		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x8988E4", Offset = "0x8988E4", VA = "0x8988E4")]
		public ButtonClickedEvent()
		{
		}
	}

	[Token(Token = "0x2000058")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x55100C", Offset = "0x55100C")]
	private sealed class <DarkenColor>d__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Image image;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <i>5__2;

		[Token(Token = "0x17000010")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001D7")]
			[Address(RVA = "0x898B60", Offset = "0x898B60", VA = "0x898B60", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000011")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001D9")]
			[Address(RVA = "0x898BC8", Offset = "0x898BC8", VA = "0x898BC8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x898824", Offset = "0x898824", VA = "0x898824")]
		[DebuggerHidden]
		public <DarkenColor>d__16(int <>1__state)
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x898A60", Offset = "0x898A60", VA = "0x898A60", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x898A64", Offset = "0x898A64", VA = "0x898A64", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x898B68", Offset = "0x898B68", VA = "0x898B68", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000059")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x55101C", Offset = "0x55101C")]
	private sealed class <BrightenColor>d__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Image image;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <i>5__2;

		[Token(Token = "0x17000012")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001DD")]
			[Address(RVA = "0x8989F0", Offset = "0x8989F0", VA = "0x8989F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000013")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001DF")]
			[Address(RVA = "0x898A58", Offset = "0x898A58", VA = "0x898A58", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x898850", Offset = "0x898850", VA = "0x898850")]
		[DebuggerHidden]
		public <BrightenColor>d__17(int <>1__state)
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x8988EC", Offset = "0x8988EC", VA = "0x8988EC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x8988F0", Offset = "0x8988F0", VA = "0x8988F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x8989F8", Offset = "0x8989F8", VA = "0x8989F8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private ButtonClickedEvent m_OnClick;

	[Token(Token = "0x4000036")]
	private const float m_colorOffset = 0.2f;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool m_pointerInside;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	private bool m_pointerPressed;

	[Token(Token = "0x17000002")]
	public ButtonClickedEvent onClick
	{
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x8983BC", Offset = "0x8983BC", VA = "0x8983BC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x8983C4", Offset = "0x8983C4", VA = "0x8983C4")]
		set
		{
		}
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x8983CC", Offset = "0x8983CC", VA = "0x8983CC", Slot = "21")]
	public virtual void OnPointerEnter(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x898468", Offset = "0x898468", VA = "0x898468", Slot = "22")]
	public virtual void OnPointerExit(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x898500", Offset = "0x898500", VA = "0x898500", Slot = "23")]
	public virtual void OnPointerUp(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x89856C", Offset = "0x89856C", VA = "0x89856C", Slot = "24")]
	public virtual void OnPointerDown(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x89842C", Offset = "0x89842C", VA = "0x89842C")]
	private void Press()
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x8984C4", Offset = "0x8984C4", VA = "0x8984C4")]
	private void Unpress()
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x8985CC", Offset = "0x8985CC", VA = "0x8985CC")]
	private void Darken()
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x898688", Offset = "0x898688", VA = "0x898688")]
	private void Brighten()
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x898744", Offset = "0x898744", VA = "0x898744")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x551638", Offset = "0x551638")]
	private IEnumerator DarkenColor(Image image)
	{
		return null;
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x8987B4", Offset = "0x8987B4", VA = "0x8987B4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x55169C", Offset = "0x55169C")]
	private IEnumerator BrightenColor(Image image)
	{
		return null;
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x89887C", Offset = "0x89887C", VA = "0x89887C")]
	public TintedButton()
	{
	}
}
[Token(Token = "0x2000017")]
public class Transition : MonoBehaviour
{
	[Token(Token = "0x200005A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x55102C", Offset = "0x55102C")]
	private sealed class <RunFade>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color fadeColor;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transition <>4__this;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float duration;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string level;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Image <image>5__2;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float <time>5__3;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float <halfDuration>5__4;

		[Token(Token = "0x17000014")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001E3")]
			[Address(RVA = "0x899570", Offset = "0x899570", VA = "0x899570", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000015")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001E5")]
			[Address(RVA = "0x8995D8", Offset = "0x8995D8", VA = "0x8995D8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x898F48", Offset = "0x898F48", VA = "0x898F48")]
		[DebuggerHidden]
		public <RunFade>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x898F7C", Offset = "0x898F7C", VA = "0x898F7C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x898F80", Offset = "0x898F80", VA = "0x898F80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x899578", Offset = "0x899578", VA = "0x899578", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static GameObject m_canvas;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private GameObject m_overlay;

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x898D84", Offset = "0x898D84", VA = "0x898D84")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x896A98", Offset = "0x896A98", VA = "0x896A98")]
	public static void LoadLevel(string level, float duration, Color color)
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x898E64", Offset = "0x898E64", VA = "0x898E64")]
	private void StartFade(string level, float duration, Color fadeColor)
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x898E90", Offset = "0x898E90", VA = "0x898E90")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x551700", Offset = "0x551700")]
	private IEnumerator RunFade(string level, float duration, Color fadeColor)
	{
		return null;
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x898F74", Offset = "0x898F74", VA = "0x898F74")]
	public Transition()
	{
	}
}
[Token(Token = "0x2000018")]
public class GameLevelData : MonoBehaviour
{
	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public int leve;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[HideInInspector]
	public int score;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public int gameTime;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5511FC", Offset = "0x5511FC")]
	public int maxTime;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x551234", Offset = "0x551234")]
	public int[] gather;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x55126C", Offset = "0x55126C")]
	public GameObject[] gatherUI;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5512A4", Offset = "0x5512A4")]
	public Text jiShiText;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5512DC", Offset = "0x5512DC")]
	public GameObject hintUI;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int[] jiLvGather;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool isJiShi;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private int jiLvTime;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x551314", Offset = "0x551314")]
	public GameObject winUI;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x55134C", Offset = "0x55134C")]
	public GameObject loseUI;

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x889B7C", Offset = "0x889B7C", VA = "0x889B7C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x889C44", Offset = "0x889C44", VA = "0x889C44")]
	public void DaoJiShi()
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x8897D0", Offset = "0x8897D0", VA = "0x8897D0")]
	public void AddDada(int id, int data)
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x88A0B8", Offset = "0x88A0B8", VA = "0x88A0B8")]
	public void ChengGong()
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x889D1C", Offset = "0x889D1C", VA = "0x889D1C")]
	public void ShiBai()
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x88A5E0", Offset = "0x88A5E0", VA = "0x88A5E0")]
	public void JieShuBuShangChuan()
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x88A6D0", Offset = "0x88A6D0", VA = "0x88A6D0")]
	private void Update()
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x88A854", Offset = "0x88A854", VA = "0x88A854")]
	public GameLevelData()
	{
	}
}
[Token(Token = "0x2000019")]
public class GameMaster : MonoBehaviour
{
	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static GameMaster initialize;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject guanKaUI;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<GameObject> jiLvGuanKaButton;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<GameObject> designs;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int idDesign;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private GameObject jiLvDesign;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Text v_Text;

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x88A86C", Offset = "0x88A86C", VA = "0x88A86C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x88A8C0", Offset = "0x88A8C0", VA = "0x88A8C0")]
	private void Start()
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x88A4C4", Offset = "0x88A4C4", VA = "0x88A4C4")]
	public void UpdateGuanKaUI(int data)
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x88AAB4", Offset = "0x88AAB4", VA = "0x88AAB4")]
	public void StartGame()
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x88AAC0", Offset = "0x88AAC0", VA = "0x88AAC0")]
	public void NextLevel()
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x88ABCC", Offset = "0x88ABCC", VA = "0x88ABCC")]
	public void Replay()
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x88ABD0", Offset = "0x88ABD0", VA = "0x88ABD0")]
	public void LoadingLevel(int data)
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x88ACD4", Offset = "0x88ACD4", VA = "0x88ACD4")]
	public void SetRadius(float v)
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x88AE7C", Offset = "0x88AE7C", VA = "0x88AE7C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x88AE80", Offset = "0x88AE80", VA = "0x88AE80")]
	public GameMaster()
	{
	}
}
[Token(Token = "0x200001A")]
public class GuanKaButton : MonoBehaviour
{
	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int id;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool isClick;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject xuanZheUI;

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x88AF28", Offset = "0x88AF28", VA = "0x88AF28")]
	private void Start()
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x88AFCC", Offset = "0x88AFCC", VA = "0x88AFCC")]
	public void OnClick()
	{
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x88B054", Offset = "0x88B054", VA = "0x88B054")]
	private void Update()
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x88B0C4", Offset = "0x88B0C4", VA = "0x88B0C4")]
	public GuanKaButton()
	{
	}
}
[Token(Token = "0x200001B")]
public class HTTPRequest : MonoBehaviour
{
	[Token(Token = "0x200005B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x55103C", Offset = "0x55103C")]
	private sealed class <ZhuChe_Send>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string password;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string phone;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string userName;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public HTTPRequest <>4__this;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Action failure;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Action<string> win;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private WWW <getData>5__2;

		[Token(Token = "0x17000016")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001E9")]
			[Address(RVA = "0x88D534", Offset = "0x88D534", VA = "0x88D534", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000017")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001EB")]
			[Address(RVA = "0x88D59C", Offset = "0x88D59C", VA = "0x88D59C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x88B1F0", Offset = "0x88B1F0", VA = "0x88B1F0")]
		[DebuggerHidden]
		public <ZhuChe_Send>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x88D328", Offset = "0x88D328", VA = "0x88D328", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x88D32C", Offset = "0x88D32C", VA = "0x88D32C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x88D53C", Offset = "0x88D53C", VA = "0x88D53C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200005C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x55104C", Offset = "0x55104C")]
	private sealed class <DengLu_Send>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string equipmentSystem;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string loginEquipment;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string password;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string userName;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public HTTPRequest <>4__this;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Action failure;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Action<string> win;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private WWW <getData>5__2;

		[Token(Token = "0x17000018")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001EF")]
			[Address(RVA = "0x88C0B0", Offset = "0x88C0B0", VA = "0x88C0B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000019")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001F1")]
			[Address(RVA = "0x88C118", Offset = "0x88C118", VA = "0x88C118", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x88B364", Offset = "0x88B364", VA = "0x88B364")]
		[DebuggerHidden]
		public <DengLu_Send>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x88BE88", Offset = "0x88BE88", VA = "0x88BE88", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x88BE8C", Offset = "0x88BE8C", VA = "0x88BE8C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x88C0B8", Offset = "0x88C0B8", VA = "0x88C0B8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200005D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x55105C", Offset = "0x55105C")]
	private sealed class <GetYouXiType_Send>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HTTPRequest <>4__this;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action failure;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action<string> win;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private WWW <getData>5__2;

		[Token(Token = "0x1700001A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001F5")]
			[Address(RVA = "0x88D058", Offset = "0x88D058", VA = "0x88D058", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001F7")]
			[Address(RVA = "0x88D0C0", Offset = "0x88D0C0", VA = "0x88D0C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x88B440", Offset = "0x88B440", VA = "0x88B440")]
		[DebuggerHidden]
		public <GetYouXiType_Send>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x88CEA4", Offset = "0x88CEA4", VA = "0x88CEA4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x88CEA8", Offset = "0x88CEA8", VA = "0x88CEA8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x88D060", Offset = "0x88D060", VA = "0x88D060", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200005E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x55106C", Offset = "0x55106C")]
	private sealed class <AddXunLian_Send>d__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string gameId;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int isConnectSuccess;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int level;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int score;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int timeSpent;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string userId;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public HTTPRequest <>4__this;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Action failure;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Action<string> win;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private WWW <getData>5__2;

		[Token(Token = "0x1700001C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001FB")]
			[Address(RVA = "0x88BE18", Offset = "0x88BE18", VA = "0x88BE18", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001FD")]
			[Address(RVA = "0x88BE80", Offset = "0x88BE80", VA = "0x88BE80", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x88B52C", Offset = "0x88B52C", VA = "0x88B52C")]
		[DebuggerHidden]
		public <AddXunLian_Send>d__10(int <>1__state)
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x88BBB8", Offset = "0x88BBB8", VA = "0x88BBB8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x88BBBC", Offset = "0x88BBBC", VA = "0x88BBBC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x88BE20", Offset = "0x88BE20", VA = "0x88BE20", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200005F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x55107C", Offset = "0x55107C")]
	private sealed class <GetGameData_Send>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string day;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string userId;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public HTTPRequest <>4__this;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action failure;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Action<string> win;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private WWW <getData>5__2;

		[Token(Token = "0x1700001E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000201")]
			[Address(RVA = "0x88C310", Offset = "0x88C310", VA = "0x88C310", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000203")]
			[Address(RVA = "0x88C378", Offset = "0x88C378", VA = "0x88C378", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x88B61C", Offset = "0x88B61C", VA = "0x88B61C")]
		[DebuggerHidden]
		public <GetGameData_Send>d__12(int <>1__state)
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x88C120", Offset = "0x88C120", VA = "0x88C120", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x88C124", Offset = "0x88C124", VA = "0x88C124", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x88C318", Offset = "0x88C318", VA = "0x88C318", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000060")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x55108C", Offset = "0x55108C")]
	private sealed class <GetMaxLevel_Send>d__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string userId;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public HTTPRequest <>4__this;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action failure;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action<string> win;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private WWW <getData>5__2;

		[Token(Token = "0x17000020")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000207")]
			[Address(RVA = "0x88C9BC", Offset = "0x88C9BC", VA = "0x88C9BC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000021")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000209")]
			[Address(RVA = "0x88CA24", Offset = "0x88CA24", VA = "0x88CA24", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x88B704", Offset = "0x88B704", VA = "0x88B704")]
		[DebuggerHidden]
		public <GetMaxLevel_Send>d__14(int <>1__state)
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x88C7E8", Offset = "0x88C7E8", VA = "0x88C7E8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x88C7EC", Offset = "0x88C7EC", VA = "0x88C7EC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x88C9C4", Offset = "0x88C9C4", VA = "0x88C9C4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000061")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x55109C", Offset = "0x55109C")]
	private sealed class <GetGetrankList_Send>d__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HTTPRequest <>4__this;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action failure;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action<string> win;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private WWW <getData>5__2;

		[Token(Token = "0x17000022")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600020D")]
			[Address(RVA = "0x88C534", Offset = "0x88C534", VA = "0x88C534", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000023")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600020F")]
			[Address(RVA = "0x88C59C", Offset = "0x88C59C", VA = "0x88C59C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x88B7E0", Offset = "0x88B7E0", VA = "0x88B7E0")]
		[DebuggerHidden]
		public <GetGetrankList_Send>d__16(int <>1__state)
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x88C380", Offset = "0x88C380", VA = "0x88C380", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x88C384", Offset = "0x88C384", VA = "0x88C384", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x88C53C", Offset = "0x88C53C", VA = "0x88C53C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000062")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5510AC", Offset = "0x5510AC")]
	private sealed class <GetGetrankTimeSpent_Send>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string userId;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public HTTPRequest <>4__this;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action failure;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action<string> win;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private WWW <getData>5__2;

		[Token(Token = "0x17000024")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000213")]
			[Address(RVA = "0x88C778", Offset = "0x88C778", VA = "0x88C778", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000025")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000215")]
			[Address(RVA = "0x88C7E0", Offset = "0x88C7E0", VA = "0x88C7E0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x88B8C8", Offset = "0x88B8C8", VA = "0x88B8C8")]
		[DebuggerHidden]
		public <GetGetrankTimeSpent_Send>d__18(int <>1__state)
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x88C5A4", Offset = "0x88C5A4", VA = "0x88C5A4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x88C5A8", Offset = "0x88C5A8", VA = "0x88C5A8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x88C780", Offset = "0x88C780", VA = "0x88C780", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000063")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5510BC", Offset = "0x5510BC")]
	private sealed class <UpdateUserName_Send>d__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string userId;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string data;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public HTTPRequest <>4__this;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action failure;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Action<string> win;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private WWW <getData>5__2;

		[Token(Token = "0x17000026")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000219")]
			[Address(RVA = "0x88D2B8", Offset = "0x88D2B8", VA = "0x88D2B8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000027")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600021B")]
			[Address(RVA = "0x88D320", Offset = "0x88D320", VA = "0x88D320", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x88B9B8", Offset = "0x88B9B8", VA = "0x88B9B8")]
		[DebuggerHidden]
		public <UpdateUserName_Send>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x88D0C8", Offset = "0x88D0C8", VA = "0x88D0C8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x88D0CC", Offset = "0x88D0CC", VA = "0x88D0CC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x88D2C0", Offset = "0x88D2C0", VA = "0x88D2C0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000064")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5510CC", Offset = "0x5510CC")]
	private sealed class <GetSendPhoneCode>d__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string code;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string phone;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public HTTPRequest <>4__this;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action Fail;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Action Success;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private UnityWebRequest <www>5__2;

		[Token(Token = "0x17000028")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000220")]
			[Address(RVA = "0x88CE34", Offset = "0x88CE34", VA = "0x88CE34", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000029")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000222")]
			[Address(RVA = "0x88CE9C", Offset = "0x88CE9C", VA = "0x88CE9C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x88BB34", Offset = "0x88BB34", VA = "0x88BB34")]
		[DebuggerHidden]
		public <GetSendPhoneCode>d__22(int <>1__state)
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x88CA2C", Offset = "0x88CA2C", VA = "0x88CA2C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x88CB08", Offset = "0x88CB08", VA = "0x88CB08", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x88CA48", Offset = "0x88CA48", VA = "0x88CA48")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x88CE3C", Offset = "0x88CE3C", VA = "0x88CE3C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static HTTPRequest Initialize;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private string url;

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x88B0CC", Offset = "0x88B0CC", VA = "0x88B0CC")]
	private void Awake()
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x88B120", Offset = "0x88B120", VA = "0x88B120")]
	public void ZhuChe(string password, string phone, string userName, Action<string> win, Action failure)
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x88B14C", Offset = "0x88B14C", VA = "0x88B14C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x551764", Offset = "0x551764")]
	private IEnumerator ZhuChe_Send(string password, string phone, string userName, Action<string> win, Action failure)
	{
		return null;
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x88B21C", Offset = "0x88B21C", VA = "0x88B21C")]
	public void DengLu(string password, string userName, Action<string> win, Action failure)
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x88B2B8", Offset = "0x88B2B8", VA = "0x88B2B8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5517C8", Offset = "0x5517C8")]
	private IEnumerator DengLu_Send(string password, string userName, string loginEquipment, string equipmentSystem, Action<string> win, Action failure)
	{
		return null;
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x88B390", Offset = "0x88B390", VA = "0x88B390")]
	public void GetYouXiType(Action<string> win, Action failure)
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x88B3BC", Offset = "0x88B3BC", VA = "0x88B3BC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x55182C", Offset = "0x55182C")]
	private IEnumerator GetYouXiType_Send(Action<string> win, Action failure)
	{
		return null;
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x88A488", Offset = "0x88A488", VA = "0x88A488")]
	public void AddXunLian(string gameId, int isConnectSuccess, int level, int score, int timeSpent, string userId, Action<string> win, Action failure)
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x88B46C", Offset = "0x88B46C", VA = "0x88B46C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x551890", Offset = "0x551890")]
	private IEnumerator AddXunLian_Send(string gameId, int isConnectSuccess, int level, int score, int timeSpent, string userId, Action<string> win, Action failure)
	{
		return null;
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x88B558", Offset = "0x88B558", VA = "0x88B558")]
	public void GetGameData(string day, string userId, Action<string> win, Action failure)
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x88B584", Offset = "0x88B584", VA = "0x88B584")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5518F4", Offset = "0x5518F4")]
	private IEnumerator GetGameData_Send(string day, string userId, Action<string> win, Action failure)
	{
		return null;
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x88B648", Offset = "0x88B648", VA = "0x88B648")]
	public void GetMaxLevel(string userId, Action<string> win, Action failure)
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x88B674", Offset = "0x88B674", VA = "0x88B674")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x551958", Offset = "0x551958")]
	private IEnumerator GetMaxLevel_Send(string userId, Action<string> win, Action failure)
	{
		return null;
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x88B730", Offset = "0x88B730", VA = "0x88B730")]
	public void GetGetrankList(Action<string> win, Action failure)
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x88B75C", Offset = "0x88B75C", VA = "0x88B75C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5519BC", Offset = "0x5519BC")]
	private IEnumerator GetGetrankList_Send(Action<string> win, Action failure)
	{
		return null;
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x88B80C", Offset = "0x88B80C", VA = "0x88B80C")]
	public void GetGetrankTimeSpent(string userId, Action<string> win, Action failure)
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x88B838", Offset = "0x88B838", VA = "0x88B838")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x551A20", Offset = "0x551A20")]
	private IEnumerator GetGetrankTimeSpent_Send(string userId, Action<string> win, Action failure)
	{
		return null;
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x88B8F4", Offset = "0x88B8F4", VA = "0x88B8F4")]
	public void UpdateUserName(string userId, string data, Action<string> win, Action failure)
	{
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x88B920", Offset = "0x88B920", VA = "0x88B920")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x551A84", Offset = "0x551A84")]
	private IEnumerator UpdateUserName_Send(string userId, string data, Action<string> win, Action failure)
	{
		return null;
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x88B9E4", Offset = "0x88B9E4", VA = "0x88B9E4")]
	public void SendPhoneCode(string phone, string code, Action Success, Action Fail)
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x88BA9C", Offset = "0x88BA9C", VA = "0x88BA9C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x551AE8", Offset = "0x551AE8")]
	private IEnumerator GetSendPhoneCode(string phone, string code, Action Success, Action Fail)
	{
		return null;
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x88BB60", Offset = "0x88BB60", VA = "0x88BB60")]
	public HTTPRequest()
	{
	}
}
[Token(Token = "0x200001C")]
public class ExampleValue
{
	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int code;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string data;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string msg;

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x886B14", Offset = "0x886B14", VA = "0x886B14")]
	public ExampleValue()
	{
	}
}
[Token(Token = "0x200001D")]
public class GameList
{
	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int gameId;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string gameName;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float score;

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x88A864", Offset = "0x88A864", VA = "0x88A864")]
	public GameList()
	{
	}
}
[Token(Token = "0x200001E")]
public class GetGameLevel
{
	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string gameId;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string gameName;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int level;

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x88AF10", Offset = "0x88AF10", VA = "0x88AF10")]
	public GetGameLevel()
	{
	}
}
[Token(Token = "0x200001F")]
public class GetrankListData
{
	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string userId;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string userName;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int level;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int rank;

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x88AF20", Offset = "0x88AF20", VA = "0x88AF20")]
	public GetrankListData()
	{
	}
}
[Token(Token = "0x2000020")]
public class GetGetrankTimeSpentData
{
	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string day;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int timeSpent;

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x88AF18", Offset = "0x88AF18", VA = "0x88AF18")]
	public GetGetrankTimeSpentData()
	{
	}
}
[Token(Token = "0x2000021")]
public class HandAnimator : MonoBehaviour
{
	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool isL;

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x88D5A4", Offset = "0x88D5A4", VA = "0x88D5A4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x88D5A8", Offset = "0x88D5A8", VA = "0x88D5A8")]
	public void WoQuan()
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x88D618", Offset = "0x88D618", VA = "0x88D618")]
	public void ZhangKai()
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x88D688", Offset = "0x88D688", VA = "0x88D688")]
	private void Update()
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x88D764", Offset = "0x88D764", VA = "0x88D764")]
	public HandAnimator()
	{
	}
}
[Token(Token = "0x2000022")]
public class LineShow : MonoBehaviour
{
	[Token(Token = "0x2000065")]
	private enum ShowState
	{
		[Token(Token = "0x40001CC")]
		show,
		[Token(Token = "0x40001CD")]
		wait,
		[Token(Token = "0x40001CE")]
		Hide
	}

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Image img;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float a;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private ShowState state;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float showSpeed;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float hideSpeed;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float waitTime;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float stateTimer;

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x890C0C", Offset = "0x890C0C", VA = "0x890C0C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x890C64", Offset = "0x890C64", VA = "0x890C64")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x890C68", Offset = "0x890C68", VA = "0x890C68")]
	public void ResetThis()
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x890CDC", Offset = "0x890CDC", VA = "0x890CDC")]
	private void Start()
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x890CE0", Offset = "0x890CE0", VA = "0x890CE0")]
	private void Update()
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x890DFC", Offset = "0x890DFC", VA = "0x890DFC")]
	public LineShow()
	{
	}
}
[Token(Token = "0x2000023")]
public class ModelShows : MonoBehaviour
{
	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject[] model;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Image image;

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x893030", Offset = "0x893030", VA = "0x893030")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x893034", Offset = "0x893034", VA = "0x893034")]
	private void Start()
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x893038", Offset = "0x893038", VA = "0x893038")]
	private void Update()
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x893170", Offset = "0x893170", VA = "0x893170")]
	public ModelShows()
	{
	}
}
[Token(Token = "0x2000024")]
public class QuitGame : MonoBehaviour
{
	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x8952DC", Offset = "0x8952DC", VA = "0x8952DC")]
	private void Start()
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x8952E0", Offset = "0x8952E0", VA = "0x8952E0")]
	public void Quit()
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x8952E8", Offset = "0x8952E8", VA = "0x8952E8")]
	private void Update()
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x8952EC", Offset = "0x8952EC", VA = "0x8952EC")]
	public QuitGame()
	{
	}
}
[Token(Token = "0x2000025")]
public class SHowTimetext : MonoBehaviour
{
	[Token(Token = "0x2000066")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5510DC", Offset = "0x5510DC")]
	private sealed class <openIE>d__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SHowTimetext <>4__this;

		[Token(Token = "0x1700002A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000226")]
			[Address(RVA = "0x896A10", Offset = "0x896A10", VA = "0x896A10", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000228")]
			[Address(RVA = "0x896A78", Offset = "0x896A78", VA = "0x896A78", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x896914", Offset = "0x896914", VA = "0x896914")]
		[DebuggerHidden]
		public <openIE>d__3(int <>1__state)
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x896954", Offset = "0x896954", VA = "0x896954", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x896958", Offset = "0x896958", VA = "0x896958", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x896A18", Offset = "0x896A18", VA = "0x896A18", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Coroutine cor;

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x8967B8", Offset = "0x8967B8", VA = "0x8967B8")]
	public void Open()
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x896894", Offset = "0x896894", VA = "0x896894")]
	public void SetText(string text)
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x896824", Offset = "0x896824", VA = "0x896824")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x551B4C", Offset = "0x551B4C")]
	private IEnumerator openIE()
	{
		return null;
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x896940", Offset = "0x896940", VA = "0x896940")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x896944", Offset = "0x896944", VA = "0x896944")]
	private void Start()
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x896948", Offset = "0x896948", VA = "0x896948")]
	private void Update()
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x89694C", Offset = "0x89694C", VA = "0x89694C")]
	public SHowTimetext()
	{
	}
}
[Token(Token = "0x2000026")]
public class AudioManager : MonoBehaviour
{
	[Token(Token = "0x2000067")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5510EC", Offset = "0x5510EC")]
	private sealed class <PlayAudio>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioManager <>4__this;

		[Token(Token = "0x1700002C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600022C")]
			[Address(RVA = "0x885804", Offset = "0x885804", VA = "0x885804", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600022E")]
			[Address(RVA = "0x88586C", Offset = "0x88586C", VA = "0x88586C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x8856E4", Offset = "0x8856E4", VA = "0x8856E4")]
		[DebuggerHidden]
		public <PlayAudio>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x885718", Offset = "0x885718", VA = "0x885718", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x88571C", Offset = "0x88571C", VA = "0x88571C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x88580C", Offset = "0x88580C", VA = "0x88580C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static AudioManager instance;

	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private AudioSource aud;

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x8855DC", Offset = "0x8855DC", VA = "0x8855DC")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x885648", Offset = "0x885648", VA = "0x885648")]
	public void PlayMagicalAudio()
	{
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x885674", Offset = "0x885674", VA = "0x885674")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x551BB0", Offset = "0x551BB0")]
	private IEnumerator PlayAudio()
	{
		return null;
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x885710", Offset = "0x885710", VA = "0x885710")]
	public AudioManager()
	{
	}
}
[Token(Token = "0x2000027")]
public class GameController : MonoBehaviour
{
	[Token(Token = "0x2000068")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5510FC", Offset = "0x5510FC")]
	private sealed class <ManipulateBoomList>d__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<Item> tempBoomList;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameController <>4__this;

		[Token(Token = "0x1700002E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000232")]
			[Address(RVA = "0x889B0C", Offset = "0x889B0C", VA = "0x889B0C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000234")]
			[Address(RVA = "0x889B74", Offset = "0x889B74", VA = "0x889B74", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x888554", Offset = "0x888554", VA = "0x888554")]
		[DebuggerHidden]
		public <ManipulateBoomList>d__24(int <>1__state)
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x8892E0", Offset = "0x8892E0", VA = "0x8892E0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x8892E4", Offset = "0x8892E4", VA = "0x8892E4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x889B14", Offset = "0x889B14", VA = "0x889B14", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000069")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x55110C", Offset = "0x55110C")]
	private sealed class <ItemsDrop>d__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameController <>4__this;

		[Token(Token = "0x17000030")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000238")]
			[Address(RVA = "0x889270", Offset = "0x889270", VA = "0x889270", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000031")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600023A")]
			[Address(RVA = "0x8892D8", Offset = "0x8892D8", VA = "0x8892D8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x8885F0", Offset = "0x8885F0", VA = "0x8885F0")]
		[DebuggerHidden]
		public <ItemsDrop>d__25(int <>1__state)
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x888E68", Offset = "0x888E68", VA = "0x888E68", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x888E6C", Offset = "0x888E6C", VA = "0x888E6C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x889278", Offset = "0x889278", VA = "0x889278", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200006A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x55111C", Offset = "0x55111C")]
	private sealed class <CreateNewItem>d__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameController <>4__this;

		[Token(Token = "0x17000032")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600023E")]
			[Address(RVA = "0x888DF8", Offset = "0x888DF8", VA = "0x888DF8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000033")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000240")]
			[Address(RVA = "0x888E60", Offset = "0x888E60", VA = "0x888E60", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x88868C", Offset = "0x88868C", VA = "0x88868C")]
		[DebuggerHidden]
		public <CreateNewItem>d__26(int <>1__state)
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x888964", Offset = "0x888964", VA = "0x888964", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x888968", Offset = "0x888968", VA = "0x888968", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x888E00", Offset = "0x888E00", VA = "0x888E00", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static GameController instance;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Sprite[] randomSprites;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int tableRow;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int tableColumn;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector2 offset;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Item[,] allItems;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Vector3[,] allPos;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public List<Item> sameItemsList;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public List<Item> boomList;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Color randomColor;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public bool isOperation;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
	public bool allBoom;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private float itemSize;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public float radius;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public float gao;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private List<Vector3> quans;

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x8870E4", Offset = "0x8870E4", VA = "0x8870E4")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x8871D8", Offset = "0x8871D8", VA = "0x8871D8")]
	public void CalculateQuan()
	{
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x887590", Offset = "0x887590", VA = "0x887590")]
	private float GetItemSize()
	{
		return default(float);
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x88762C", Offset = "0x88762C", VA = "0x88762C")]
	private void InitGame()
	{
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x887AC8", Offset = "0x887AC8", VA = "0x887AC8")]
	private void Start()
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x887AEC", Offset = "0x887AEC", VA = "0x887AEC")]
	private void AllBoom()
	{
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x887D44", Offset = "0x887D44", VA = "0x887D44")]
	public void FillSameItemsList(Item current)
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x888224", Offset = "0x888224", VA = "0x888224")]
	public void FillBoomList(Item current)
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x8884D8", Offset = "0x8884D8", VA = "0x8884D8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x551C14", Offset = "0x551C14")]
	private IEnumerator ManipulateBoomList(List<Item> tempBoomList)
	{
		return null;
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x888580", Offset = "0x888580", VA = "0x888580")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x551C78", Offset = "0x551C78")]
	private IEnumerator ItemsDrop()
	{
		return null;
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x88861C", Offset = "0x88861C", VA = "0x88861C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x551CDC", Offset = "0x551CDC")]
	public IEnumerator CreateNewItem()
	{
		return null;
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x8886B8", Offset = "0x8886B8", VA = "0x8886B8")]
	private bool CheckItemsInterval(bool isHorizontal, Item begin, Item end)
	{
		return default(bool);
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x887FB8", Offset = "0x887FB8", VA = "0x887FB8")]
	private Item GetUpItem(Item current)
	{
		return null;
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x88804C", Offset = "0x88804C", VA = "0x88804C")]
	private Item GetDownItem(Item current)
	{
		return null;
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x8880E0", Offset = "0x8880E0", VA = "0x8880E0")]
	private Item GetLeftItem(Item current)
	{
		return null;
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x888188", Offset = "0x888188", VA = "0x888188")]
	private Item GetRightItem(Item current)
	{
		return null;
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x8888E0", Offset = "0x8888E0", VA = "0x8888E0")]
	public bool CheckRCLegal(int itemRow, int itemColumn)
	{
		return default(bool);
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x888910", Offset = "0x888910", VA = "0x888910")]
	private void Update()
	{
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x888914", Offset = "0x888914", VA = "0x888914")]
	public GameController()
	{
	}
}
[Token(Token = "0x2000028")]
public class Item : MonoBehaviour
{
	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int itemRow;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int itemColumn;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Sprite currentSpr;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Image currentImg;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GameController controller;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool hasCheck;

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x88F8E0", Offset = "0x88F8E0", VA = "0x88F8E0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x88F958", Offset = "0x88F958", VA = "0x88F958")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x88F9B0", Offset = "0x88F9B0", VA = "0x88F9B0")]
	public void Update()
	{
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x887C94", Offset = "0x887C94", VA = "0x887C94")]
	public void CheckAroundBoom()
	{
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x88FB18", Offset = "0x88FB18", VA = "0x88FB18")]
	public Item()
	{
	}
}
[Token(Token = "0x2000029")]
public class ItemOperation : MonoBehaviour
{
	[Token(Token = "0x200006B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x55112C", Offset = "0x55112C")]
	private sealed class <ItemExchange>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ItemOperation <>4__this;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector2 dir;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Item <target>5__2;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Item <myItem>5__3;

		[Token(Token = "0x17000034")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000244")]
			[Address(RVA = "0x8902D0", Offset = "0x8902D0", VA = "0x8902D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000035")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000246")]
			[Address(RVA = "0x890338", Offset = "0x890338", VA = "0x890338", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x88FE3C", Offset = "0x88FE3C", VA = "0x88FE3C")]
		[DebuggerHidden]
		public <ItemExchange>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x88FE70", Offset = "0x88FE70", VA = "0x88FE70", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x88FE74", Offset = "0x88FE74", VA = "0x88FE74", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x8902D8", Offset = "0x8902D8", VA = "0x8902D8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Item item;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Vector3 downPos;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private Vector3 upPos;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool isJiSuan;

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x88FB20", Offset = "0x88FB20", VA = "0x88FB20")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x88FB78", Offset = "0x88FB78", VA = "0x88FB78")]
	public void OnPointerDown()
	{
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x88FB84", Offset = "0x88FB84", VA = "0x88FB84")]
	public void OnPointerUp()
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x88FDB8", Offset = "0x88FDB8", VA = "0x88FDB8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x551D40", Offset = "0x551D40")]
	private IEnumerator ItemExchange(Vector2 dir)
	{
		return null;
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x888CE8", Offset = "0x888CE8", VA = "0x888CE8")]
	public void ItemMove(int targetRow, int targetColumn, Vector3 pos)
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x88FC60", Offset = "0x88FC60", VA = "0x88FC60")]
	public Vector2 GetDirection()
	{
		return default(Vector2);
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x889220", Offset = "0x889220", VA = "0x889220")]
	public void CurrentItemDrop(Vector3 pos)
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x88FE68", Offset = "0x88FE68", VA = "0x88FE68")]
	public ItemOperation()
	{
	}
}
[Token(Token = "0x200002A")]
public class ObjectPool : MonoBehaviour
{
	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static ObjectPool instance;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Dictionary<string, List<GameObject>> pool;

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x894690", Offset = "0x894690", VA = "0x894690")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x8899C4", Offset = "0x8899C4", VA = "0x8899C4")]
	public void SetGameObject(GameObject current)
	{
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x887900", Offset = "0x887900", VA = "0x887900")]
	public GameObject GetGameObject(string objName, [Optional] Transform parent)
	{
		return null;
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x89470C", Offset = "0x89470C", VA = "0x89470C")]
	public ObjectPool()
	{
	}
}
[Token(Token = "0x200002B")]
public class Util
{
	[Token(Token = "0x400008C")]
	public const string ResourcesPrefab = "Prefabs/";

	[Token(Token = "0x400008D")]
	public const string Item = "Item";

	[Token(Token = "0x400008E")]
	public const string Pressed = "Pressed";

	[Token(Token = "0x400008F")]
	public const string Exit = "Exit";

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x8995E0", Offset = "0x8995E0", VA = "0x8995E0")]
	public Util()
	{
	}
}
[Token(Token = "0x200002C")]
public class ChangeTiShi : MonoBehaviour
{
	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Sprite pico3TipLeft;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Sprite pico3TipRight;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Sprite pico4TipLeft;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Sprite pico4TipRight;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private SpriteRenderer leftTipSpr;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private SpriteRenderer rightTipSpr;

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x885E80", Offset = "0x885E80", VA = "0x885E80")]
	private void Start()
	{
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x885E84", Offset = "0x885E84", VA = "0x885E84")]
	private void UpdateTip()
	{
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x885F00", Offset = "0x885F00", VA = "0x885F00")]
	public ChangeTiShi()
	{
	}
}
[Token(Token = "0x200002D")]
public class LevelCheckTrigger : MonoBehaviour
{
	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private bool isThisFinishLevel;

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x890340", Offset = "0x890340", VA = "0x890340")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x8903B0", Offset = "0x8903B0", VA = "0x8903B0")]
	public LevelCheckTrigger()
	{
	}
}
[Token(Token = "0x200002E")]
public class LoadFade : MonoBehaviour
{
	[Token(Token = "0x200006C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x55113C", Offset = "0x55113C")]
	private sealed class <WaitTimeToFade>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LoadFade <>4__this;

		[Token(Token = "0x17000036")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600024A")]
			[Address(RVA = "0x891048", Offset = "0x891048", VA = "0x891048", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000037")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600024C")]
			[Address(RVA = "0x8910B0", Offset = "0x8910B0", VA = "0x8910B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x890EB4", Offset = "0x890EB4", VA = "0x890EB4")]
		[DebuggerHidden]
		public <WaitTimeToFade>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x890F84", Offset = "0x890F84", VA = "0x890F84", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x890F88", Offset = "0x890F88", VA = "0x890F88", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x891050", Offset = "0x891050", VA = "0x891050", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200006D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x55114C", Offset = "0x55114C")]
	private sealed class <WaitTimeToFadeLogo2>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LoadFade <>4__this;

		[Token(Token = "0x17000038")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000250")]
			[Address(RVA = "0x89118C", Offset = "0x89118C", VA = "0x89118C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000039")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000252")]
			[Address(RVA = "0x8911F4", Offset = "0x8911F4", VA = "0x8911F4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x890F50", Offset = "0x890F50", VA = "0x890F50")]
		[DebuggerHidden]
		public <WaitTimeToFadeLogo2>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x8910B8", Offset = "0x8910B8", VA = "0x8910B8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x8910BC", Offset = "0x8910BC", VA = "0x8910BC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x891194", Offset = "0x891194", VA = "0x891194", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Image logo1;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Image logo2;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string sceneName;

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x890E18", Offset = "0x890E18", VA = "0x890E18")]
	private void Start()
	{
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x890E44", Offset = "0x890E44", VA = "0x890E44")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x551DA4", Offset = "0x551DA4")]
	private IEnumerator WaitTimeToFade()
	{
		return null;
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x890EE0", Offset = "0x890EE0", VA = "0x890EE0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x551E08", Offset = "0x551E08")]
	private IEnumerator WaitTimeToFadeLogo2()
	{
		return null;
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x890F7C", Offset = "0x890F7C", VA = "0x890F7C")]
	public LoadFade()
	{
	}
}
[Token(Token = "0x200002F")]
public class OpenMenu : MonoBehaviour
{
	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject menu;

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x894714", Offset = "0x894714", VA = "0x894714")]
	private void Start()
	{
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x894718", Offset = "0x894718", VA = "0x894718")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x89471C", Offset = "0x89471C", VA = "0x89471C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x894720", Offset = "0x894720", VA = "0x894720")]
	private void Update()
	{
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x894724", Offset = "0x894724", VA = "0x894724")]
	public OpenMenu()
	{
	}
}
[Token(Token = "0x2000030")]
public class DebugHelper : MonoBehaviour
{
	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	public Text DebugText;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static DebugHelper instance;

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x88638C", Offset = "0x88638C", VA = "0x88638C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x88646C", Offset = "0x88646C", VA = "0x88646C")]
	private void Start()
	{
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x886470", Offset = "0x886470", VA = "0x886470")]
	public void Log(string MSG)
	{
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x886568", Offset = "0x886568", VA = "0x886568")]
	public DebugHelper()
	{
	}
}
[Token(Token = "0x2000031")]
public class ImeDelegateImpl : ImeDelegateBase, IDragHandler, IEventSystemHandler, IPointerDownHandler, IPointerUpHandler
{
	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text mText;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject mPanel;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ImeManager mManager;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Texture2D mTexture;

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector2 mTextureSize;

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x88D774", Offset = "0x88D774", VA = "0x88D774", Slot = "4")]
	public override void OnIMEShow(Vector2 vSize)
	{
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x88D8E4", Offset = "0x88D8E4", VA = "0x88D8E4", Slot = "5")]
	public override void OnIMEHide()
	{
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x88D96C", Offset = "0x88D96C", VA = "0x88D96C", Slot = "6")]
	public override void OnIMECommit(string strCommit)
	{
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x88D9C8", Offset = "0x88D9C8", VA = "0x88D9C8", Slot = "7")]
	public override void OnIMEKey(SGImeKey key)
	{
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x88DAA0", Offset = "0x88DAA0", VA = "0x88DAA0", Slot = "8")]
	public override void OnIMEError(SGImeError nType, string strErr)
	{
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x88DAA4", Offset = "0x88DAA4", VA = "0x88DAA4")]
	private void Start()
	{
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x88DC38", Offset = "0x88DC38", VA = "0x88DC38")]
	private void Update()
	{
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x88DAA8", Offset = "0x88DAA8", VA = "0x88DAA8")]
	private void CreateTexture()
	{
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x88DCBC", Offset = "0x88DCBC", VA = "0x88DCBC")]
	private void CorrectPos(ref float x, ref float y)
	{
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x88DD60", Offset = "0x88DD60", VA = "0x88DD60")]
	private void DispatchMessageToAndroid(SGImeMotionEventType type, PointerEventData eventData)
	{
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x88DF04", Offset = "0x88DF04", VA = "0x88DF04")]
	private void LogEvent(string prefix, PointerEventData eventData)
	{
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x88E158", Offset = "0x88E158", VA = "0x88E158")]
	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x88E1A8", Offset = "0x88E1A8", VA = "0x88E1A8", Slot = "9")]
	public void OnDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x88E214", Offset = "0x88E214", VA = "0x88E214")]
	public void OnEndDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x88E264", Offset = "0x88E264", VA = "0x88E264")]
	public void OnPointerClick(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x88E2B4", Offset = "0x88E2B4", VA = "0x88E2B4", Slot = "10")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x88E320", Offset = "0x88E320", VA = "0x88E320")]
	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x88E370", Offset = "0x88E370", VA = "0x88E370")]
	public void OnPointerExit(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x88E3DC", Offset = "0x88E3DC", VA = "0x88E3DC", Slot = "11")]
	public void OnPointerUp(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x88E448", Offset = "0x88E448", VA = "0x88E448")]
	public ImeDelegateImpl()
	{
	}
}
[Token(Token = "0x2000032")]
public class SGViewGather
{
	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private GameObject[] mViews;

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x88E964", Offset = "0x88E964", VA = "0x88E964")]
	public SGViewGather(GameObject[] param)
	{
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x88E6A4", Offset = "0x88E6A4", VA = "0x88E6A4")]
	public void SetActive(bool bActive)
	{
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x88F2E8", Offset = "0x88F2E8", VA = "0x88F2E8")]
	public bool FindName(string name)
	{
		return default(bool);
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x88EBC4", Offset = "0x88EBC4", VA = "0x88EBC4")]
	public void SetTexture(Texture2D tex)
	{
	}
}
[Token(Token = "0x2000033")]
public class SGMouseTracker
{
	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private bool mDownOld;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private Vector2 mPtOld;

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private SGImeMotionEventType mEvent;

	[Token(Token = "0x40000A6")]
	private const float mTrackRadius = 10f;

	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private long mTimeDown;

	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool mLongPressed;

	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private long mIntervelLongPress;

	[Token(Token = "0x6000102")]
	[Address(RVA = "0x88F11C", Offset = "0x88F11C", VA = "0x88F11C")]
	public bool Track(Vector2 pt, bool bDown)
	{
		return default(bool);
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x88F2CC", Offset = "0x88F2CC", VA = "0x88F2CC")]
	public bool TrackOuter()
	{
		return default(bool);
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x8967A8", Offset = "0x8967A8", VA = "0x8967A8")]
	public Vector2 GetPoint()
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0x8967B0", Offset = "0x8967B0", VA = "0x8967B0")]
	public SGImeMotionEventType GetEvent()
	{
		return default(SGImeMotionEventType);
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0x8966DC", Offset = "0x8966DC", VA = "0x8966DC")]
	private float PointDist(Vector2 ptNew, Vector2 ptOld)
	{
		return default(float);
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x88F428", Offset = "0x88F428", VA = "0x88F428")]
	public SGMouseTracker()
	{
	}
}
[Token(Token = "0x2000034")]
public class ImeDelegateImpl_kbd : ImeDelegateBase
{
	[Token(Token = "0x200006E")]
	public enum HandControl
	{
		[Token(Token = "0x40001EC")]
		LeftHand,
		[Token(Token = "0x40001ED")]
		RightHand
	}

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public HandControl m_DomainHand;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public XRRayInteractor LeftHandInteractor;

	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public XRRayInteractor RightHandInteractor;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private XRRayInteractor CurrentRayInteractor;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private XRNode currentnode;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Text mText;

	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject[] mKbdViews;

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public SGViewGather mKbdView;

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public ImeManager mManager;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Texture2D mTexture;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Vector2 mTextureSize;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Vector2 mPtKbd;

	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private SGMouseTracker mTracker;

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x88E498", Offset = "0x88E498", VA = "0x88E498", Slot = "4")]
	public override void OnIMEShow(Vector2 vSize)
	{
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x88E720", Offset = "0x88E720", VA = "0x88E720", Slot = "5")]
	public override void OnIMEHide()
	{
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x88E7A4", Offset = "0x88E7A4", VA = "0x88E7A4", Slot = "6")]
	public override void OnIMECommit(string strCommit)
	{
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0x88E800", Offset = "0x88E800", VA = "0x88E800", Slot = "7")]
	public override void OnIMEKey(SGImeKey key)
	{
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0x88E8D8", Offset = "0x88E8D8", VA = "0x88E8D8", Slot = "8")]
	public override void OnIMEError(SGImeError nType, string strErr)
	{
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0x88E8DC", Offset = "0x88E8DC", VA = "0x88E8DC")]
	private void Start()
	{
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0x88E990", Offset = "0x88E990", VA = "0x88E990")]
	private void GetCurrentNode()
	{
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0x88EA78", Offset = "0x88EA78", VA = "0x88EA78")]
	private void OnApplicationFocus(bool focus)
	{
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0x88EA84", Offset = "0x88EA84", VA = "0x88EA84")]
	private void Update()
	{
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0x88E550", Offset = "0x88E550", VA = "0x88E550")]
	private void CreateTexture(Vector2 vSize)
	{
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0x88EC88", Offset = "0x88EC88", VA = "0x88EC88")]
	private void DispatchMessageToAndroid(SGImeMotionEventType type, Vector2 pt)
	{
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0x88ED48", Offset = "0x88ED48", VA = "0x88ED48")]
	private void LogEvent(string prefix, PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0x88EAB8", Offset = "0x88EAB8", VA = "0x88EAB8")]
	private void CheckMouseEvent()
	{
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0x88EF9C", Offset = "0x88EF9C", VA = "0x88EF9C")]
	private bool Point2UV(Vector3 ptScreen, ref Vector2 ptUV)
	{
		return default(bool);
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0x88F37C", Offset = "0x88F37C", VA = "0x88F37C")]
	private void ServiceStartSuccess()
	{
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x88F380", Offset = "0x88F380", VA = "0x88F380")]
	private void ControllerStateListener(string data)
	{
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x88F384", Offset = "0x88F384", VA = "0x88F384")]
	public ImeDelegateImpl_kbd()
	{
	}
}
[Token(Token = "0x2000035")]
public class TextHandler : MonoBehaviour, IPointerUpHandler, IEventSystemHandler, IPointerDownHandler
{
	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ImeManager mManager;

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public SGImeInputType mInputType;

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public SGImeTextType mTextType;

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Text Debugtext;

	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private ShowLinePage page;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform lineParent;

	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float add;

	[Token(Token = "0x6000119")]
	[Address(RVA = "0x89791C", Offset = "0x89791C", VA = "0x89791C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0x897974", Offset = "0x897974", VA = "0x897974")]
	private void Update()
	{
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0x897BEC", Offset = "0x897BEC", VA = "0x897BEC", Slot = "5")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0x897BF0", Offset = "0x897BF0", VA = "0x897BF0", Slot = "4")]
	public void OnPointerUp(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0x897DD0", Offset = "0x897DD0", VA = "0x897DD0")]
	private void LogEvent(string prefix, PointerEventData eventData)
	{
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x897B48", Offset = "0x897B48", VA = "0x897B48")]
	private int CalculateLengthOfText(string message, Text tex)
	{
		return default(int);
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0x891A90", Offset = "0x891A90", VA = "0x891A90")]
	public Text getText()
	{
		return null;
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0x898024", Offset = "0x898024", VA = "0x898024")]
	public TextHandler()
	{
	}
}
[Token(Token = "0x2000036")]
internal interface ImeBase
{
	[Token(Token = "0x6000121")]
	bool Create(ImeDelegateBase pDelegate);

	[Token(Token = "0x6000122")]
	void GetSize(ref Vector2 size);

	[Token(Token = "0x6000123")]
	void Draw(Texture2D tex);

	[Token(Token = "0x6000124")]
	void OnTouch(float x, float y, SGImeMotionEventType type);

	[Token(Token = "0x6000125")]
	void UpdateData();

	[Token(Token = "0x6000126")]
	void Show(SGImeInputType typeInput, SGImeTextType typeText);

	[Token(Token = "0x6000127")]
	void Hide();
}
[Token(Token = "0x2000037")]
public enum SGImeError
{
	[Token(Token = "0x40000BF")]
	UNKNOWN,
	[Token(Token = "0x40000C0")]
	SERVICE_NOT_CONNECTED
}
[Token(Token = "0x2000038")]
public enum SGImeKey
{
	[Token(Token = "0x40000C2")]
	KEYCODE_COMMIT = -1,
	[Token(Token = "0x40000C3")]
	KEYCODE_UNKNOWN = 0,
	[Token(Token = "0x40000C4")]
	KEYCODE_ENTER = 66,
	[Token(Token = "0x40000C5")]
	KEYCODE_DEL = 67
}
[Token(Token = "0x2000039")]
public enum SGImeInputType
{
	[Token(Token = "0x40000C7")]
	TYPE_CLASS_TEXT = 1,
	[Token(Token = "0x40000C8")]
	TYPE_CLASS_NUMBER,
	[Token(Token = "0x40000C9")]
	TYPE_CLASS_PHONE,
	[Token(Token = "0x40000CA")]
	TYPE_CLASS_DATETIME
}
[Token(Token = "0x200003A")]
public enum SGImeTextType
{
	[Token(Token = "0x40000CC")]
	TYPE_TEXT_VARIATION_NORMAL = 0,
	[Token(Token = "0x40000CD")]
	TYPE_TEXT_VARIATION_URI = 16,
	[Token(Token = "0x40000CE")]
	TYPE_TEXT_VARIATION_EMAIL_ADDRESS = 32,
	[Token(Token = "0x40000CF")]
	TYPE_TEXT_VARIATION_EMAIL_SUBJECT = 48,
	[Token(Token = "0x40000D0")]
	TYPE_TEXT_VARIATION_SHORT_MESSAGE = 64,
	[Token(Token = "0x40000D1")]
	TYPE_TEXT_VARIATION_LONG_MESSAGE = 80,
	[Token(Token = "0x40000D2")]
	TYPE_TEXT_VARIATION_PERSON_NAME = 96,
	[Token(Token = "0x40000D3")]
	TYPE_TEXT_VARIATION_POSTAL_ADDRESS = 112,
	[Token(Token = "0x40000D4")]
	TYPE_TEXT_VARIATION_PASSWORD = 128,
	[Token(Token = "0x40000D5")]
	TYPE_TEXT_VARIATION_VISIBLE_PASSWORD = 144,
	[Token(Token = "0x40000D6")]
	TYPE_TEXT_VARIATION_WEB_EDIT_TEXT = 160,
	[Token(Token = "0x40000D7")]
	TYPE_TEXT_VARIATION_FILTER = 176,
	[Token(Token = "0x40000D8")]
	TYPE_TEXT_VARIATION_PHONETIC = 192,
	[Token(Token = "0x40000D9")]
	TYPE_TEXT_VARIATION_WEB_EMAIL_ADDRESS = 208,
	[Token(Token = "0x40000DA")]
	TYPE_TEXT_VARIATION_WEB_PASSWORD = 224
}
[Token(Token = "0x200003B")]
public enum SGImeMotionEventType
{
	[Token(Token = "0x40000DC")]
	ACTION_DOWN = 0,
	[Token(Token = "0x40000DD")]
	ACTION_UP = 1,
	[Token(Token = "0x40000DE")]
	ACTION_MOVE = 2,
	[Token(Token = "0x40000DF")]
	ACTION_CANCEL = 3,
	[Token(Token = "0x40000E0")]
	ACTION_OUTSIDE = 4,
	[Token(Token = "0x40000E1")]
	ACTION_POINTER_DOWN = 5,
	[Token(Token = "0x40000E2")]
	ACTION_POINTER_UP = 6,
	[Token(Token = "0x40000E3")]
	ACTION_HOVER_MOVE = 7,
	[Token(Token = "0x40000E4")]
	ACTION_SCROLL = 8,
	[Token(Token = "0x40000E5")]
	ACTION_HOVER_ENTER = 9,
	[Token(Token = "0x40000E6")]
	ACTION_HOVER_EXIT = 10,
	[Token(Token = "0x40000E7")]
	ACTION_BUTTON_PRESS = 11,
	[Token(Token = "0x40000E8")]
	ACTION_BUTTON_RELEASE = 12,
	[Token(Token = "0x40000E9")]
	ACTION_LONGPRESS = 100
}
[Token(Token = "0x200003C")]
public abstract class ImeDelegateBase : MonoBehaviour
{
	[Token(Token = "0x6000128")]
	public abstract void OnIMEShow(Vector2 vSize);

	[Token(Token = "0x6000129")]
	public abstract void OnIMEHide();

	[Token(Token = "0x600012A")]
	public abstract void OnIMECommit(string strCommit);

	[Token(Token = "0x600012B")]
	public abstract void OnIMEKey(SGImeKey key);

	[Token(Token = "0x600012C")]
	public abstract void OnIMEError(SGImeError nType, string strErr);

	[Token(Token = "0x600012D")]
	[Address(RVA = "0x88D76C", Offset = "0x88D76C", VA = "0x88D76C")]
	protected ImeDelegateBase()
	{
	}
}
[Token(Token = "0x200003D")]
public class DummyIme : ImeBase
{
	[Token(Token = "0x600012E")]
	[Address(RVA = "0x886570", Offset = "0x886570", VA = "0x886570", Slot = "4")]
	public bool Create(ImeDelegateBase pDelegate)
	{
		return default(bool);
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0x8865E4", Offset = "0x8865E4", VA = "0x8865E4", Slot = "5")]
	public void GetSize(ref Vector2 size)
	{
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0x886684", Offset = "0x886684", VA = "0x886684", Slot = "6")]
	public void Draw(Texture2D tex)
	{
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0x886688", Offset = "0x886688", VA = "0x886688", Slot = "7")]
	public void OnTouch(float x, float y, SGImeMotionEventType type)
	{
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0x8868BC", Offset = "0x8868BC", VA = "0x8868BC", Slot = "8")]
	public void UpdateData()
	{
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0x8868C0", Offset = "0x8868C0", VA = "0x8868C0", Slot = "9")]
	public void Show(SGImeInputType typeInput, SGImeTextType typeText)
	{
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0x886AA0", Offset = "0x886AA0", VA = "0x886AA0", Slot = "10")]
	public void Hide()
	{
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0x886B0C", Offset = "0x886B0C", VA = "0x886B0C")]
	public DummyIme()
	{
	}
}
[Token(Token = "0x200003E")]
public class SGIme : ImeBase
{
	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private bool mUseAndroid;

	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private AndroidJavaObject javaIme;

	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private ImeDelegateBase mDelegate;

	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Vector2 mTextureSize;

	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private string mStrCommit;

	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool mShow;

	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	private bool isFirstTime;

	[Token(Token = "0x6000136")]
	[Address(RVA = "0x8952F4", Offset = "0x8952F4", VA = "0x8952F4", Slot = "4")]
	public bool Create(ImeDelegateBase pDelegate)
	{
		return default(bool);
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0x8955A4", Offset = "0x8955A4", VA = "0x8955A4", Slot = "5")]
	public void GetSize(ref Vector2 size)
	{
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0x89577C", Offset = "0x89577C", VA = "0x89577C", Slot = "6")]
	public void Draw(Texture2D tex)
	{
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0x895B04", Offset = "0x895B04", VA = "0x895B04", Slot = "9")]
	public void Show(SGImeInputType typeInput, SGImeTextType typeText)
	{
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0x895D94", Offset = "0x895D94", VA = "0x895D94", Slot = "10")]
	public void Hide()
	{
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0x895EE4", Offset = "0x895EE4", VA = "0x895EE4", Slot = "7")]
	public void OnTouch(float x, float y, SGImeMotionEventType type)
	{
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0x89622C", Offset = "0x89622C", VA = "0x89622C", Slot = "8")]
	public void UpdateData()
	{
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0x895384", Offset = "0x895384", VA = "0x895384")]
	private void JavaInit()
	{
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0x8959E8", Offset = "0x8959E8", VA = "0x8959E8")]
	private bool IsInited()
	{
		return default(bool);
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x895A08", Offset = "0x895A08", VA = "0x895A08")]
	private bool IsNeedUpdate()
	{
		return default(bool);
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x8963E8", Offset = "0x8963E8", VA = "0x8963E8")]
	private int GetCommitCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0x8964E4", Offset = "0x8964E4", VA = "0x8964E4")]
	private string GetCommitString()
	{
		return null;
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0x8965E0", Offset = "0x8965E0", VA = "0x8965E0")]
	private bool IsShow()
	{
		return default(bool);
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0x88F55C", Offset = "0x88F55C", VA = "0x88F55C")]
	public SGIme()
	{
	}
}
[Token(Token = "0x200003F")]
public class ImeManager : MonoBehaviour
{
	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ImeDelegateBase mDelegate;

	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private ImeBase mIme;

	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Vector2 mSize;

	[Token(Token = "0x6000144")]
	[Address(RVA = "0x88F438", Offset = "0x88F438", VA = "0x88F438")]
	private void Start()
	{
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0x88F570", Offset = "0x88F570", VA = "0x88F570")]
	private void Update()
	{
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0x88F62C", Offset = "0x88F62C", VA = "0x88F62C")]
	public void Show(SGImeInputType typeInput, SGImeTextType typeText)
	{
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0x88F774", Offset = "0x88F774", VA = "0x88F774")]
	public void Hide()
	{
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0x88D820", Offset = "0x88D820", VA = "0x88D820")]
	public void Draw(Texture2D tex)
	{
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0x88DE28", Offset = "0x88DE28", VA = "0x88DE28")]
	public void OnTouch(float x, float y, SGImeMotionEventType type)
	{
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0x88F83C", Offset = "0x88F83C", VA = "0x88F83C")]
	public ImeManager()
	{
	}
}
[Token(Token = "0x2000040")]
public class testClick : MonoBehaviour
{
	[Token(Token = "0x600014B")]
	[Address(RVA = "0x89AF84", Offset = "0x89AF84", VA = "0x89AF84")]
	private void Start()
	{
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0x89AF88", Offset = "0x89AF88", VA = "0x89AF88")]
	private void Update()
	{
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0x89B4E4", Offset = "0x89B4E4", VA = "0x89B4E4")]
	public void Click()
	{
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0x89B550", Offset = "0x89B550", VA = "0x89B550")]
	private void LogEvent(string prefix, PointerEventData eventData)
	{
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0x89B7A4", Offset = "0x89B7A4", VA = "0x89B7A4")]
	public testClick()
	{
	}
}
[Token(Token = "0x2000041")]
public class TongGuanPanelController : MonoBehaviour
{
	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool isReachFinishLevel;

	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject[] unReachFinishLevelShowButton;

	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject[] reachFinishLevelNeedShowButton;

	[Token(Token = "0x6000150")]
	[Address(RVA = "0x898BD0", Offset = "0x898BD0", VA = "0x898BD0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0x898D78", Offset = "0x898D78", VA = "0x898D78")]
	public TongGuanPanelController()
	{
	}
}
[Token(Token = "0x2000042")]
public class WaiTimeToHide : MonoBehaviour
{
	[Token(Token = "0x200006F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x55115C", Offset = "0x55115C")]
	private sealed class <WaitTimeToHide>d__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public WaiTimeToHide <>4__this;

		[Token(Token = "0x1700003A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000256")]
			[Address(RVA = "0x8997A4", Offset = "0x8997A4", VA = "0x8997A4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000258")]
			[Address(RVA = "0x89980C", Offset = "0x89980C", VA = "0x89980C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x89969C", Offset = "0x89969C", VA = "0x89969C")]
		[DebuggerHidden]
		public <WaitTimeToHide>d__2(int <>1__state)
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x8996D8", Offset = "0x8996D8", VA = "0x8996D8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x8996DC", Offset = "0x8996DC", VA = "0x8996DC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x8997AC", Offset = "0x8997AC", VA = "0x8997AC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float waitTime;

	[Token(Token = "0x6000153")]
	[Address(RVA = "0x8995E8", Offset = "0x8995E8", VA = "0x8995E8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0x89962C", Offset = "0x89962C", VA = "0x89962C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x551E6C", Offset = "0x551E6C")]
	private IEnumerator WaitTimeToHide()
	{
		return null;
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0x8996C8", Offset = "0x8996C8", VA = "0x8996C8")]
	public WaiTimeToHide()
	{
	}
}
[Token(Token = "0x2000043")]
public class SetIcon : MonoBehaviour
{
	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Sprite[] sprites;

	[Token(Token = "0x6000156")]
	[Address(RVA = "0x896C94", Offset = "0x896C94", VA = "0x896C94")]
	private void Start()
	{
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0x896E60", Offset = "0x896E60", VA = "0x896E60")]
	private void Update()
	{
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0x896E64", Offset = "0x896E64", VA = "0x896E64")]
	public SetIcon()
	{
	}
}
[Token(Token = "0x2000044")]
public class ShowLinePage : MonoBehaviour
{
	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject lineShow;

	[Token(Token = "0x6000159")]
	[Address(RVA = "0x896E6C", Offset = "0x896E6C", VA = "0x896E6C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0x896E8C", Offset = "0x896E8C", VA = "0x896E8C")]
	public void SetLine(Transform parnet, Vector3 targetLocalPos)
	{
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0x896FCC", Offset = "0x896FCC", VA = "0x896FCC")]
	private void Start()
	{
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0x896FD0", Offset = "0x896FD0", VA = "0x896FD0")]
	private void Update()
	{
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0x896FD4", Offset = "0x896FD4", VA = "0x896FD4")]
	public ShowLinePage()
	{
	}
}
[Token(Token = "0x2000045")]
public class ShuRu : MonoBehaviour
{
	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static ShuRu initialize;

	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject you;

	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject zuo;

	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector3 dian;

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x896FDC", Offset = "0x896FDC", VA = "0x896FDC")]
	private void Awake()
	{
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0x897030", Offset = "0x897030", VA = "0x897030")]
	private void Start()
	{
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0x897034", Offset = "0x897034", VA = "0x897034")]
	private void Update()
	{
	}

	[Token(Token = "0x6000161")]
	[Address(RVA = "0x897280", Offset = "0x897280", VA = "0x897280")]
	public ShuRu()
	{
	}
}
[Token(Token = "0x2000046")]
public class TextTest : MonoBehaviour
{
	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform line;

	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Text text;

	[Token(Token = "0x6000162")]
	[Address(RVA = "0x898034", Offset = "0x898034", VA = "0x898034")]
	private int CalculateLengthOfText(string message, Text tex)
	{
		return default(int);
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0x898188", Offset = "0x898188", VA = "0x898188")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0x89828C", Offset = "0x89828C", VA = "0x89828C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0x8983B4", Offset = "0x8983B4", VA = "0x8983B4")]
	public TextTest()
	{
	}
}
[Serializable]
[Token(Token = "0x2000047")]
public enum InputFeature
{
	[Token(Token = "0x4000101")]
	primaryButton,
	[Token(Token = "0x4000102")]
	primaryTouch,
	[Token(Token = "0x4000103")]
	secondaryButton,
	[Token(Token = "0x4000104")]
	secondaryTouch,
	[Token(Token = "0x4000105")]
	gripButton,
	[Token(Token = "0x4000106")]
	triggerButton,
	[Token(Token = "0x4000107")]
	menuButton,
	[Token(Token = "0x4000108")]
	primary2DAxisClick,
	[Token(Token = "0x4000109")]
	primary2DAxisTouch,
	[Token(Token = "0x400010A")]
	secondary2DAxisClick,
	[Token(Token = "0x400010B")]
	secondary2DAxisTouch,
	[Token(Token = "0x400010C")]
	userPresence
}
[Token(Token = "0x2000048")]
public class XRControllerButtonWatcher : MonoBehaviour
{
	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Dictionary<InputFeature, InputFeatureUsage<bool>> inputFeatureUsageMap;

	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	public InputFeature ButtonInputFeature;

	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[SerializeField]
	public InputDeviceCharacteristics inputDeviceType;

	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	public UnityEvent OnInputDown;

	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	public UnityEvent OnInputUp;

	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private InputFeatureUsage<bool> buttonInputFeatureUsage;

	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool lastButtonState;

	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private List<InputDevice> devicesButton;

	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private ZhanTingUI menuObject;

	[Token(Token = "0x6000166")]
	[Address(RVA = "0x899814", Offset = "0x899814", VA = "0x899814")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0x899968", Offset = "0x899968", VA = "0x899968")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0x899B20", Offset = "0x899B20", VA = "0x899B20")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0x899BF0", Offset = "0x899BF0", VA = "0x899BF0")]
	private void InputDevices_deviceConnected(InputDevice device)
	{
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0x899CD4", Offset = "0x899CD4", VA = "0x899CD4")]
	private void InputDevices_deviceDisconnected(InputDevice device)
	{
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0x899D78", Offset = "0x899D78", VA = "0x899D78")]
	private void Update()
	{
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0x89996C", Offset = "0x89996C", VA = "0x89996C")]
	public void Init()
	{
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0x899EE0", Offset = "0x899EE0", VA = "0x899EE0")]
	public XRControllerButtonWatcher()
	{
	}
}
[Token(Token = "0x2000049")]
public class Xr_input_Record : MonoBehaviour
{
	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public InputDevice leftHand_device;

	[Token(Token = "0x4000117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float 振幅;

	[Token(Token = "0x4000118")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public uint 频道;

	[Token(Token = "0x4000119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float 持续时长;

	[Token(Token = "0x400011A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject game;

	[Token(Token = "0x600016E")]
	[Address(RVA = "0x89A0D8", Offset = "0x89A0D8", VA = "0x89A0D8")]
	private void Start()
	{
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0x89A0DC", Offset = "0x89A0DC", VA = "0x89A0DC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0x89A3E4", Offset = "0x89A3E4", VA = "0x89A3E4")]
	public void Allinput_device_record()
	{
	}

	[Token(Token = "0x6000171")]
	[Address(RVA = "0x89A100", Offset = "0x89A100", VA = "0x89A100")]
	public void get_left_hand()
	{
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0x89A5E8", Offset = "0x89A5E8", VA = "0x89A5E8")]
	public void display_device_featureName()
	{
	}

	[Token(Token = "0x6000173")]
	[Address(RVA = "0x89A84C", Offset = "0x89A84C", VA = "0x89A84C")]
	public void update_inputDynamic_record()
	{
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0x89A318", Offset = "0x89A318", VA = "0x89A318")]
	public void 控制器振动功能()
	{
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0x89ACB4", Offset = "0x89ACB4", VA = "0x89ACB4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0x89ACB8", Offset = "0x89ACB8", VA = "0x89ACB8")]
	public Xr_input_Record()
	{
	}
}
[Token(Token = "0x200004A")]
public class ZhanTingUI : MonoBehaviour
{
	[Token(Token = "0x6000177")]
	[Address(RVA = "0x89AD60", Offset = "0x89AD60", VA = "0x89AD60")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0x89ADB0", Offset = "0x89ADB0", VA = "0x89ADB0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0x89ADB4", Offset = "0x89ADB4", VA = "0x89ADB4")]
	private void Update()
	{
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0x89ADB8", Offset = "0x89ADB8", VA = "0x89ADB8")]
	public void OnClick()
	{
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0x89AE8C", Offset = "0x89AE8C", VA = "0x89AE8C")]
	public void TuiChu()
	{
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0x89AF28", Offset = "0x89AF28", VA = "0x89AF28")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0x89AF7C", Offset = "0x89AF7C", VA = "0x89AF7C")]
	public ZhanTingUI()
	{
	}
}
[Token(Token = "0x200004B")]
public class CountDown : MonoBehaviour
{
	[Token(Token = "0x2000070")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x55116C", Offset = "0x55116C")]
	private sealed class <CountDownAsync>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CountDown <>4__this;

		[Token(Token = "0x1700003C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600025C")]
			[Address(RVA = "0x886258", Offset = "0x886258", VA = "0x886258", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600025E")]
			[Address(RVA = "0x8862C0", Offset = "0x8862C0", VA = "0x8862C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x8860AC", Offset = "0x8860AC", VA = "0x8860AC")]
		[DebuggerHidden]
		public <CountDownAsync>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x886154", Offset = "0x886154", VA = "0x886154", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x886158", Offset = "0x886158", VA = "0x886158", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x886260", Offset = "0x886260", VA = "0x886260", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400011B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public UnityEvent entEvent;

	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int maxTime;

	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Text text;

	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int time;

	[Token(Token = "0x600017E")]
	[Address(RVA = "0x885FD0", Offset = "0x885FD0", VA = "0x885FD0")]
	private void Start()
	{
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0x885FD4", Offset = "0x885FD4", VA = "0x885FD4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0x88603C", Offset = "0x88603C", VA = "0x88603C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x551ED0", Offset = "0x551ED0")]
	private IEnumerator CountDownAsync()
	{
		return null;
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0x8860D8", Offset = "0x8860D8", VA = "0x8860D8")]
	public void JiShi()
	{
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0x886148", Offset = "0x886148", VA = "0x886148")]
	private void Update()
	{
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0x88614C", Offset = "0x88614C", VA = "0x88614C")]
	public CountDown()
	{
	}
}
[Token(Token = "0x200004C")]
public class Member : MonoBehaviour
{
	[Token(Token = "0x2000071")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x55117C", Offset = "0x55117C")]
	private sealed class <HideIE>d__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Member <>4__this;

		[Token(Token = "0x1700003E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000262")]
			[Address(RVA = "0x892FC0", Offset = "0x892FC0", VA = "0x892FC0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000264")]
			[Address(RVA = "0x893028", Offset = "0x893028", VA = "0x893028", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x891B70", Offset = "0x891B70", VA = "0x891B70")]
		[DebuggerHidden]
		public <HideIE>d__30(int <>1__state)
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x892EDC", Offset = "0x892EDC", VA = "0x892EDC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x892EE0", Offset = "0x892EE0", VA = "0x892EE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x892FC8", Offset = "0x892FC8", VA = "0x892FC8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000072")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x55118C", Offset = "0x55118C")]
	private sealed class <>c
	{
		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action<string> <>9__42_0;

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x892D28", Offset = "0x892D28", VA = "0x892D28")]
		public <>c()
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x892D30", Offset = "0x892D30", VA = "0x892D30")]
		internal void <UpdateLevel>b__42_0(string b)
		{
		}
	}

	[Token(Token = "0x400011F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static Member initialize;

	[Token(Token = "0x4000120")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static string userID;

	[Token(Token = "0x4000121")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text tiaoShi;

	[Token(Token = "0x4000122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Text shouji;

	[Token(Token = "0x4000123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Text yanzheng;

	[Token(Token = "0x4000124")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Text userName;

	[Token(Token = "0x4000125")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Text userName_DenLv;

	[Token(Token = "0x4000126")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Text cipher;

	[Token(Token = "0x4000127")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Text cipher_DenLv;

	[Token(Token = "0x4000128")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject jianPan;

	[Token(Token = "0x4000129")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject yanZhenButton;

	[Token(Token = "0x400012A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject yanZhenEnt;

	[Token(Token = "0x400012B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private string spawnCode;

	[Token(Token = "0x400012C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private bool isZhuChe;

	[Token(Token = "0x400012D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public GameObject denglvPage;

	[Token(Token = "0x400012E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameObject zhucePage;

	[Token(Token = "0x400012F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public GameObject startPage;

	[Token(Token = "0x4000130")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public TextHandler[] denglv_all;

	[Token(Token = "0x4000131")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public TextHandler[] zhuce_all;

	[Token(Token = "0x4000132")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public GameObject resetLogIn;

	[Token(Token = "0x4000133")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public GameObject replaceUser;

	[Token(Token = "0x4000134")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public GameObject[] back_hide;

	[Token(Token = "0x4000135")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public AudioClip errorAudio;

	[Token(Token = "0x4000136")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public SHowTimetext show;

	[Token(Token = "0x4000137")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public GameObject dengLvUI;

	[Token(Token = "0x4000138")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public GameObject youXi;

	[Token(Token = "0x4000139")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public GameObject zhuChe_shiJi;

	[Token(Token = "0x400013A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public GameObject denglu_shiJI;

	[Token(Token = "0x6000184")]
	[Address(RVA = "0x8911FC", Offset = "0x8911FC", VA = "0x8911FC")]
	public void onComplete(int action, object resp)
	{
	}

	[Token(Token = "0x6000185")]
	[Address(RVA = "0x8913F0", Offset = "0x8913F0", VA = "0x8913F0")]
	public void onError(int action, object resp)
	{
	}

	[Token(Token = "0x6000186")]
	[Address(RVA = "0x8914E8", Offset = "0x8914E8", VA = "0x8914E8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000187")]
	[Address(RVA = "0x89157C", Offset = "0x89157C", VA = "0x89157C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000188")]
	[Address(RVA = "0x89159C", Offset = "0x89159C", VA = "0x89159C")]
	public void GetCode()
	{
	}

	[Token(Token = "0x6000189")]
	[Address(RVA = "0x8917BC", Offset = "0x8917BC", VA = "0x8917BC")]
	public void ZhuChe()
	{
	}

	[Token(Token = "0x600018A")]
	[Address(RVA = "0x891858", Offset = "0x891858", VA = "0x891858")]
	public void EntZhuChe()
	{
	}

	[Token(Token = "0x600018B")]
	[Address(RVA = "0x891860", Offset = "0x891860", VA = "0x891860")]
	public void backDenglu()
	{
	}

	[Token(Token = "0x600018C")]
	[Address(RVA = "0x891B00", Offset = "0x891B00", VA = "0x891B00")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x551F34", Offset = "0x551F34")]
	private IEnumerator HideIE()
	{
		return null;
	}

	[Token(Token = "0x600018D")]
	[Address(RVA = "0x891B9C", Offset = "0x891B9C", VA = "0x891B9C")]
	public void backStart()
	{
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0x891294", Offset = "0x891294", VA = "0x891294")]
	public void SendZhuCheData()
	{
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0x891DCC", Offset = "0x891DCC", VA = "0x891DCC")]
	public void SendDengLv()
	{
	}

	[Token(Token = "0x6000190")]
	[Address(RVA = "0x89148C", Offset = "0x89148C", VA = "0x89148C")]
	public void SetTiShi(string data)
	{
	}

	[Token(Token = "0x6000191")]
	[Address(RVA = "0x891EEC", Offset = "0x891EEC", VA = "0x891EEC")]
	public void FinishDengLu()
	{
	}

	[Token(Token = "0x6000192")]
	[Address(RVA = "0x891FE0", Offset = "0x891FE0", VA = "0x891FE0")]
	public void UpdateLevel()
	{
	}

	[Token(Token = "0x6000193")]
	[Address(RVA = "0x89210C", Offset = "0x89210C", VA = "0x89210C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000194")]
	[Address(RVA = "0x892110", Offset = "0x892110", VA = "0x892110")]
	public Member()
	{
	}

	[Token(Token = "0x6000195")]
	[Address(RVA = "0x892118", Offset = "0x892118", VA = "0x892118")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x551F98", Offset = "0x551F98")]
	private void <GetCode>b__17_0()
	{
	}

	[Token(Token = "0x6000196")]
	[Address(RVA = "0x892194", Offset = "0x892194", VA = "0x892194")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x551FA8", Offset = "0x551FA8")]
	private void <GetCode>b__17_1()
	{
	}

	[Token(Token = "0x6000197")]
	[Address(RVA = "0x89223C", Offset = "0x89223C", VA = "0x89223C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x551FB8", Offset = "0x551FB8")]
	private void <SendZhuCheData>b__32_0(string a)
	{
	}

	[Token(Token = "0x6000198")]
	[Address(RVA = "0x8923DC", Offset = "0x8923DC", VA = "0x8923DC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x551FC8", Offset = "0x551FC8")]
	private void <SendZhuCheData>b__32_2(string b)
	{
	}

	[Token(Token = "0x6000199")]
	[Address(RVA = "0x892500", Offset = "0x892500", VA = "0x892500")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x551FD8", Offset = "0x551FD8")]
	private void <SendZhuCheData>b__32_3()
	{
	}

	[Token(Token = "0x600019A")]
	[Address(RVA = "0x892550", Offset = "0x892550", VA = "0x892550")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x551FE8", Offset = "0x551FE8")]
	private void <SendZhuCheData>b__32_1()
	{
	}

	[Token(Token = "0x600019B")]
	[Address(RVA = "0x8925A0", Offset = "0x8925A0", VA = "0x8925A0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x551FF8", Offset = "0x551FF8")]
	private void <SendDengLv>b__35_0(string b)
	{
	}

	[Token(Token = "0x600019C")]
	[Address(RVA = "0x892C74", Offset = "0x892C74", VA = "0x892C74")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x552008", Offset = "0x552008")]
	private void <SendDengLv>b__35_1()
	{
	}
}
[Token(Token = "0x200004D")]
public class MusicController : MonoBehaviour
{
	[Token(Token = "0x2000073")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x55119C", Offset = "0x55119C")]
	private sealed class <EffectMassageIE>d__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MusicController <>4__this;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AudioMassage audioMassage;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float? volume;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool isjumpScene;

		[Token(Token = "0x17000040")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600026B")]
			[Address(RVA = "0x894294", Offset = "0x894294", VA = "0x894294", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000041")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600026D")]
			[Address(RVA = "0x8942FC", Offset = "0x8942FC", VA = "0x8942FC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x893BF8", Offset = "0x893BF8", VA = "0x893BF8")]
		[DebuggerHidden]
		public <EffectMassageIE>d__24(int <>1__state)
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x893DD8", Offset = "0x893DD8", VA = "0x893DD8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x893DDC", Offset = "0x893DDC", VA = "0x893DDC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x89429C", Offset = "0x89429C", VA = "0x89429C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400013B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static List<AudioSource> effectList;

	[Token(Token = "0x400013C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static MusicController instance;

	[Token(Token = "0x400013D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static AudioSource myAudio;

	[Token(Token = "0x400013E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float bgVolume;

	[Token(Token = "0x400013F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private bool isOpenBG;

	[Token(Token = "0x4000140")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float effectVolume;

	[Token(Token = "0x4000141")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool isOpenEF;

	[Token(Token = "0x4000142")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<AudioClip> efClipList;

	[Token(Token = "0x4000143")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<AudioClip> audioMassageList;

	[Token(Token = "0x4000144")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool isCanVibration;

	[Token(Token = "0x4000145")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	public bool isVibration;

	[Token(Token = "0x17000003")]
	public static MusicController Instance
	{
		[Token(Token = "0x600019D")]
		[Address(RVA = "0x8926CC", Offset = "0x8926CC", VA = "0x8926CC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000004")]
	public float BgVolume
	{
		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x89384C", Offset = "0x89384C", VA = "0x89384C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x893854", Offset = "0x893854", VA = "0x893854")]
		set
		{
		}
	}

	[Token(Token = "0x17000005")]
	public bool IsOpenBG
	{
		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x8938F0", Offset = "0x8938F0", VA = "0x8938F0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x8938F8", Offset = "0x8938F8", VA = "0x8938F8")]
		set
		{
		}
	}

	[Token(Token = "0x600019E")]
	[Address(RVA = "0x893334", Offset = "0x893334", VA = "0x893334")]
	private void Awake()
	{
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0x8934E4", Offset = "0x8934E4", VA = "0x8934E4")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x60001A0")]
	[Address(RVA = "0x89361C", Offset = "0x89361C", VA = "0x89361C")]
	public void SetBGClip(AudioClip clip, bool isReset = false)
	{
	}

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0x8937D8", Offset = "0x8937D8", VA = "0x8937D8")]
	public void StopBG()
	{
	}

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0x893998", Offset = "0x893998", VA = "0x893998")]
	private void Start()
	{
	}

	[Token(Token = "0x60001A7")]
	[Address(RVA = "0x89289C", Offset = "0x89289C", VA = "0x89289C")]
	public void PlayEffectByFrame(AudioClip clip, bool isJumpScene = true, [Optional] float? volume)
	{
	}

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0x893AA8", Offset = "0x893AA8", VA = "0x893AA8")]
	public void PlayEffectByMassage(AudioMassage audioMassage, bool isJumpScene = false, [Optional] float? volume)
	{
	}

	[Token(Token = "0x60001A9")]
	[Address(RVA = "0x893B60", Offset = "0x893B60", VA = "0x893B60")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x552018", Offset = "0x552018")]
	private IEnumerator EffectMassageIE(AudioMassage audioMassage, bool isjumpScene, float? volume)
	{
		return null;
	}

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0x893C24", Offset = "0x893C24", VA = "0x893C24")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60001AB")]
	[Address(RVA = "0x893C84", Offset = "0x893C84", VA = "0x893C84")]
	public void PlayVibration()
	{
	}

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0x893CA4", Offset = "0x893CA4", VA = "0x893CA4")]
	public MusicController()
	{
	}
}
[Token(Token = "0x200004E")]
public class AudioMassage
{
	[Token(Token = "0x4000146")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public AudioClip clip;

	[Token(Token = "0x4000147")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float time;

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0x885874", Offset = "0x885874", VA = "0x885874")]
	public AudioMassage(AudioClip clip, float time)
	{
	}
}
[Token(Token = "0x200004F")]
public class YanChi : MonoBehaviour
{
	[Token(Token = "0x4000148")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float time;

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0x89ACD0", Offset = "0x89ACD0", VA = "0x89ACD0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0x89AD28", Offset = "0x89AD28", VA = "0x89AD28")]
	public void Ent()
	{
	}

	[Token(Token = "0x60001B1")]
	[Address(RVA = "0x89AD50", Offset = "0x89AD50", VA = "0x89AD50")]
	private void Start()
	{
	}

	[Token(Token = "0x60001B2")]
	[Address(RVA = "0x89AD54", Offset = "0x89AD54", VA = "0x89AD54")]
	private void Update()
	{
	}

	[Token(Token = "0x60001B3")]
	[Address(RVA = "0x89AD58", Offset = "0x89AD58", VA = "0x89AD58")]
	public YanChi()
	{
	}
}
