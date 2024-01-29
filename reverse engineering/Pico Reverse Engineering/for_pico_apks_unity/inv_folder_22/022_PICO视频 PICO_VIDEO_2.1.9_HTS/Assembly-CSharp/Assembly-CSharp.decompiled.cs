using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using DG.Tweening;
using DesignerTool.Comment;
using EmojiDanma;
using Il2CppDummyDll;
using MainModel;
using Matrix.EcosystemSimulate;
using MirzaBeig.Scripting.Effects;
using Model.PicoClient.LiveNav.LiveSettings;
using Oasis.Unity;
using PICOVR;
using PICOVR.EventTrackParam;
using PICOVR.Live;
using PicoLiveAKB48;
using TMPro;
using Unity.XR.PXR;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.Playables;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;
using UnityEngine.XR;
using VRTV.Base.DebugTools;
using VRTV.Framework.GlobalData;
using VRTV.MusicGame.Dance;
using VRTV.OGC.Interaction.Sei;
using VRTV.OGC.Interaction.Wristband;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class UIScrollUV : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector2 scrollSpeed;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private RawImage image;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Vector2 size;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x2B56C18", Offset = "0x2B56C18", VA = "0x2B56C18")]
	private void Start()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x2B56C74", Offset = "0x2B56C74", VA = "0x2B56C74")]
	private void Update()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x2B56DA8", Offset = "0x2B56DA8", VA = "0x2B56DA8")]
	public UIScrollUV()
	{
	}
}
[Token(Token = "0x2000003")]
public class DebugScripts : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000004")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124CF08", Offset = "0x124CF08")]
	private sealed class <>c
	{
		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action<Camera> <>9__4_0;

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x310C134", Offset = "0x310C134", VA = "0x310C134")]
		public <>c()
		{
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x310C13C", Offset = "0x310C13C", VA = "0x310C13C")]
		internal void <FuncX>b__4_0(Camera cam)
		{
		}
	}

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject tipOverlayOn;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject tipOverlayOff;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool debgOverlayOn;

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x2C7DF78", Offset = "0x2C7DF78", VA = "0x2C7DF78")]
	private void Start()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x2C7E03C", Offset = "0x2C7E03C", VA = "0x2C7E03C")]
	private void FuncX()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x2C7E490", Offset = "0x2C7E490", VA = "0x2C7E490")]
	private void FuncY()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x2C7E504", Offset = "0x2C7E504", VA = "0x2C7E504")]
	private void FuncA()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x2C7E578", Offset = "0x2C7E578", VA = "0x2C7E578")]
	private void FuncB()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x2C7E294", Offset = "0x2C7E294", VA = "0x2C7E294")]
	private Camera[] SearchCamera(Action<Camera> foreachFunc)
	{
		return null;
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x2C7E5EC", Offset = "0x2C7E5EC", VA = "0x2C7E5EC")]
	private string GameObjectRouteToString(GameObject obj)
	{
		return null;
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x2C7E738", Offset = "0x2C7E738", VA = "0x2C7E738")]
	public DebugScripts()
	{
	}
}
[Token(Token = "0x2000005")]
public class AutoDestroy : MonoBehaviour
{
	[Token(Token = "0x2000006")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124CF18", Offset = "0x124CF18")]
	private sealed class <Start>d__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AutoDestroy <>4__this;

		[Token(Token = "0x17000001")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000014")]
			[Address(RVA = "0x310A854", Offset = "0x310A854", VA = "0x310A854", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000016")]
			[Address(RVA = "0x310A89C", Offset = "0x310A89C", VA = "0x310A89C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x310A724", Offset = "0x310A724", VA = "0x310A724")]
		[DebuggerHidden]
		public <Start>d__1(int <>1__state)
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x310A750", Offset = "0x310A750", VA = "0x310A750", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x310A754", Offset = "0x310A754", VA = "0x310A754", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x310A85C", Offset = "0x310A85C", VA = "0x310A85C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float lifeTime;

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x2C78B90", Offset = "0x2C78B90", VA = "0x2C78B90")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x124FD38", Offset = "0x124FD38")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x2C78C08", Offset = "0x2C78C08", VA = "0x2C78C08")]
	public AutoDestroy()
	{
	}
}
[Token(Token = "0x2000007")]
public class CardEvent : MonoBehaviour
{
	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject inPositionEffect;

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x2C7AF70", Offset = "0x2C7AF70", VA = "0x2C7AF70")]
	public void InPosition()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x2C7B078", Offset = "0x2C7B078", VA = "0x2C7B078")]
	public CardEvent()
	{
	}
}
[Token(Token = "0x2000008")]
public class EffectController : MonoBehaviour
{
	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ShowCard _showCard;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private FenWeiController _fenWeiController;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x124DE0C", Offset = "0x124DE0C")]
	public GameObject objGoalEffect;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector3 objGoalEffectOffsetPos;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x124DE44", Offset = "0x124DE44")]
	public GameObject objCardEffect;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Vector3 objCardEffectOffsetPos;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float cardMoveUpDistance;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public List<GameObject> existCards;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private List<GameObject> inGoalObjs;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int CardHeight;

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x2C80CDC", Offset = "0x2C80CDC", VA = "0x2C80CDC")]
	private void Start()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x2C80D60", Offset = "0x2C80D60", VA = "0x2C80D60")]
	public void ShowRedCard()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x2C81090", Offset = "0x2C81090", VA = "0x2C81090")]
	public void ShowYellowCard()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x2C810C0", Offset = "0x2C810C0", VA = "0x2C810C0")]
	private void Update()
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x2C80D90", Offset = "0x2C80D90", VA = "0x2C80D90")]
	private void SpawnCard()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x2C81188", Offset = "0x2C81188", VA = "0x2C81188")]
	public void SpawnLiHua()
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x2C81308", Offset = "0x2C81308", VA = "0x2C81308")]
	public void EnableEmoji()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x2C81320", Offset = "0x2C81320", VA = "0x2C81320")]
	public void DisableEmoji()
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x2C81410", Offset = "0x2C81410", VA = "0x2C81410")]
	public EffectController()
	{
	}
}
[Token(Token = "0x2000009")]
public class FenWeiController : MonoBehaviour
{
	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool playEffect;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private ParticleSystem[] FenWei;

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x2C81BFC", Offset = "0x2C81BFC", VA = "0x2C81BFC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x2C81338", Offset = "0x2C81338", VA = "0x2C81338")]
	public void PlayFenWei()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x2C813A4", Offset = "0x2C813A4", VA = "0x2C813A4")]
	public void StopFenWei()
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x2C81D78", Offset = "0x2C81D78", VA = "0x2C81D78")]
	public FenWeiController()
	{
	}
}
[Token(Token = "0x200000A")]
public class InGoal : MonoBehaviour
{
	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public EffectController effectController;

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x3F60DA4", Offset = "0x3F60DA4", VA = "0x3F60DA4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x3F60DC0", Offset = "0x3F60DC0", VA = "0x3F60DC0")]
	public InGoal()
	{
	}
}
[Token(Token = "0x200000B")]
public class NationalFlagDetect : MonoBehaviour
{
	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Material mNationalFlag;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Texture texNationalFlag;

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x3F66BF0", Offset = "0x3F66BF0", VA = "0x3F66BF0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x3F66C78", Offset = "0x3F66C78", VA = "0x3F66C78")]
	public NationalFlagDetect()
	{
	}
}
[Token(Token = "0x200000C")]
public class PositionDetect : MonoBehaviour
{
	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 trOffsetPos;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform trXRRig;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform trEffect;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform trHuDongChang;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool _forTest;

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x2B49910", Offset = "0x2B49910", VA = "0x2B49910")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x2B49980", Offset = "0x2B49980", VA = "0x2B49980")]
	public PositionDetect()
	{
	}
}
[Token(Token = "0x200000D")]
public class RedCard : MonoBehaviour
{
	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public EffectController effectController;

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x2B499BC", Offset = "0x2B499BC", VA = "0x2B499BC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x2B499D8", Offset = "0x2B499D8", VA = "0x2B499D8")]
	public RedCard()
	{
	}
}
[Serializable]
[Token(Token = "0x200000E")]
public struct CardInfo
{
	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Material cardMat;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public GameObject objTrail;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public GameObject objExplosion;
}
[Token(Token = "0x200000F")]
public class ShowCard : MonoBehaviour
{
	[Token(Token = "0x2000010")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124CF28", Offset = "0x124CF28")]
	private sealed class <AutoDestroy>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ShowCard <>4__this;

		[Token(Token = "0x17000003")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000037")]
			[Address(RVA = "0x310E688", Offset = "0x310E688", VA = "0x310E688", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000004")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000039")]
			[Address(RVA = "0x310E6D0", Offset = "0x310E6D0", VA = "0x310E6D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x310E37C", Offset = "0x310E37C", VA = "0x310E37C")]
		[DebuggerHidden]
		public <AutoDestroy>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x310E3A8", Offset = "0x310E3A8", VA = "0x310E3A8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x310E3AC", Offset = "0x310E3AC", VA = "0x310E3AC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x310E690", Offset = "0x310E690", VA = "0x310E690", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public CardInfo redCard;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public CardInfo yellowCard;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private WarmingFream[] _freams;

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x2B4C3DC", Offset = "0x2B4C3DC", VA = "0x2B4C3DC")]
	private void Start()
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x2B4C520", Offset = "0x2B4C520", VA = "0x2B4C520")]
	public void showRed()
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x2B4C868", Offset = "0x2B4C868", VA = "0x2B4C868")]
	public void ShowYellow()
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x2B4C618", Offset = "0x2B4C618", VA = "0x2B4C618")]
	private void CardConfig(CardInfo cardInfo)
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x2B4C4A8", Offset = "0x2B4C4A8", VA = "0x2B4C4A8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x124FDE8", Offset = "0x124FDE8")]
	private IEnumerator AutoDestroy()
	{
		return null;
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x2B4CA08", Offset = "0x2B4CA08", VA = "0x2B4CA08")]
	public ShowCard()
	{
	}
}
[Token(Token = "0x2000011")]
public class ShowLogic : MonoBehaviour
{
	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int _huDongChangID;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject[] objFIFAHuDongChang;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool _primaryButtonIsDown;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	private bool _primaryButtonIsDone;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
	private bool _secondButtonIsDown;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
	private bool _secondButtonIsDone;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private EffectController _effectController;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool effect;

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x2B4CA10", Offset = "0x2B4CA10", VA = "0x2B4CA10")]
	private void Start()
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x2B4CA94", Offset = "0x2B4CA94", VA = "0x2B4CA94")]
	private void Update()
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x2B4CC90", Offset = "0x2B4CC90", VA = "0x2B4CC90")]
	private void SwitchHuDongChang(int huDongChangID)
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x2B4CD1C", Offset = "0x2B4CD1C", VA = "0x2B4CD1C")]
	public ShowLogic()
	{
	}
}
[Token(Token = "0x2000012")]
public class WarmingFream : MonoBehaviour
{
	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Color _colorInit;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Color _colorRed;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Color _colorYellow;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Material _matMain;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Tweener _tween;

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x2B59284", Offset = "0x2B59284", VA = "0x2B59284")]
	private void Start()
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x2B4C7C0", Offset = "0x2B4C7C0", VA = "0x2B4C7C0")]
	public void ShowRedCard()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x2B4C960", Offset = "0x2B4C960", VA = "0x2B4C960")]
	public void ShowYellowCard()
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x2B59328", Offset = "0x2B59328", VA = "0x2B59328")]
	public void BackToInit()
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x2B593AC", Offset = "0x2B593AC", VA = "0x2B593AC")]
	public WarmingFream()
	{
	}
}
[Token(Token = "0x2000013")]
public class YellowCard : MonoBehaviour
{
	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public EffectController effectController;

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x2B5AE14", Offset = "0x2B5AE14", VA = "0x2B5AE14")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x2B5AE30", Offset = "0x2B5AE30", VA = "0x2B5AE30")]
	public YellowCard()
	{
	}
}
[Token(Token = "0x2000014")]
public class YuReDoorAnim : MonoBehaviour
{
	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool forTest;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject objYuReMainScreen;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Animator _animator;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private string OpenTrigger;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private string CloseTrigger;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private string triggerName;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float _screenScaleSpeed;

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x2B5B114", Offset = "0x2B5B114", VA = "0x2B5B114")]
	private void Start()
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x2B5B2CC", Offset = "0x2B5B2CC", VA = "0x2B5B2CC")]
	private void RefreshDoor(bool open)
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x2B5B360", Offset = "0x2B5B360", VA = "0x2B5B360")]
	public void OpenDoorMainScreenLogic()
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x2B5B46C", Offset = "0x2B5B46C", VA = "0x2B5B46C")]
	public void CloseDoorMainScreenLogic()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x2B5B2D8", Offset = "0x2B5B2D8", VA = "0x2B5B2D8")]
	public void OpenDoor()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x2B5B31C", Offset = "0x2B5B31C", VA = "0x2B5B31C")]
	public void CloseDoor()
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x2B5B578", Offset = "0x2B5B578", VA = "0x2B5B578")]
	public void SetOpenState()
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x2B5B5FC", Offset = "0x2B5B5FC", VA = "0x2B5B5FC")]
	public void SetCloseState()
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x2B5B5A8", Offset = "0x2B5B5A8", VA = "0x2B5B5A8")]
	public void ReSetState()
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x2B5B62C", Offset = "0x2B5B62C", VA = "0x2B5B62C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x2B5B630", Offset = "0x2B5B630", VA = "0x2B5B630")]
	private void DisableThis()
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x2B5B658", Offset = "0x2B5B658", VA = "0x2B5B658")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x2B5B798", Offset = "0x2B5B798", VA = "0x2B5B798")]
	public YuReDoorAnim()
	{
	}
}
[Token(Token = "0x2000015")]
public class Comments : MonoBehaviour
{
	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x124DE7C", Offset = "0x124DE7C")]
	public Transform FirstInitTransform;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform FirstEndTrans;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x124DEB4", Offset = "0x124DEB4")]
	public float depthOffset;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x124DECC", Offset = "0x124DECC")]
	public float heightOffset;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x124DEE4", Offset = "0x124DEE4")]
	public Style _style;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float UniversalSpeed;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float commentDistance;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x124DF1C", Offset = "0x124DF1C")]
	public float rotation_X;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x124DF3C", Offset = "0x124DF3C")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x124DF3C", Offset = "0x124DF3C")]
	public float gradientDistance;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x124DF90", Offset = "0x124DF90")]
	public float gradientRadius;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private float gradientMin_X;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float gradientMax_X;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Shader gradientShader;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public List<row> rows;

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x2C7B150", Offset = "0x2C7B150", VA = "0x2C7B150")]
	private void Start()
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x2C7B340", Offset = "0x2C7B340", VA = "0x2C7B340")]
	private void Update()
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x2C7B4AC", Offset = "0x2C7B4AC", VA = "0x2C7B4AC")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x2C7B728", Offset = "0x2C7B728", VA = "0x2C7B728")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0x124FE98", Offset = "0x124FE98")]
	public void add()
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x2C7B2A0", Offset = "0x2C7B2A0", VA = "0x2C7B2A0")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0x124FED0", Offset = "0x124FED0")]
	private void setUniversalSpeed()
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x2C7B4D0", Offset = "0x2C7B4D0", VA = "0x2C7B4D0")]
	private void initRowPos()
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x2C7B850", Offset = "0x2C7B850", VA = "0x2C7B850")]
	private void gradientPos()
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x2C7B8A8", Offset = "0x2C7B8A8", VA = "0x2C7B8A8")]
	public Comments()
	{
	}
}
[Token(Token = "0x2000016")]
public class StormVFXTerrainDemoCamera : MonoBehaviour
{
	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float moveSpeed;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float height;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x124DFAC", Offset = "0x124DFAC")]
	public float acceleration;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float deceleration;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Vector3 velocity;

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x2B4F6F0", Offset = "0x2B4F6F0", VA = "0x2B4F6F0")]
	private void Start()
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x2B4F6F4", Offset = "0x2B4F6F4", VA = "0x2B4F6F4")]
	private void Update()
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x2B4FA14", Offset = "0x2B4FA14", VA = "0x2B4FA14")]
	public StormVFXTerrainDemoCamera()
	{
	}
}
[Token(Token = "0x2000017")]
public class StormVFXTerrainDemoFollowTargetPosition : MonoBehaviour
{
	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform target;

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x2B4FA28", Offset = "0x2B4FA28", VA = "0x2B4FA28")]
	private void Start()
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x2B4FA2C", Offset = "0x2B4FA2C", VA = "0x2B4FA2C")]
	private void Update()
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x2B4FA30", Offset = "0x2B4FA30", VA = "0x2B4FA30")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x2B4FA7C", Offset = "0x2B4FA7C", VA = "0x2B4FA7C")]
	public StormVFXTerrainDemoFollowTargetPosition()
	{
	}
}
[Token(Token = "0x2000018")]
public class ParticleSystemTimeRemap : MonoBehaviour
{
	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ParticleSystem[] particleSystems;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float[] startTimes;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float[] simulationTimes;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float startTime;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float simulationSpeedScale;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool useFixedDeltaTime;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	private bool gameObjectDeactivated;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
	public bool reverseSimulation;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float elapsedTime;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public AnimationCurve simulationSpeedOverTime;

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x3F77228", Offset = "0x3F77228", VA = "0x3F77228")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x3F7745C", Offset = "0x3F7745C", VA = "0x3F7745C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x3F774D0", Offset = "0x3F774D0", VA = "0x3F774D0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x3F77864", Offset = "0x3F77864", VA = "0x3F77864")]
	public ParticleSystemTimeRemap()
	{
	}
}
[Token(Token = "0x2000019")]
public class RewindParticleSystem : MonoBehaviour
{
	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ParticleSystem[] particleSystems;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float[] startTimes;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float[] simulationTimes;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float startTime;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float simulationSpeedScale;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool useFixedDeltaTime;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	private bool gameObjectDeactivated;

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x2B49A50", Offset = "0x2B49A50", VA = "0x2B49A50")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x2B49C48", Offset = "0x2B49C48", VA = "0x2B49C48")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x2B49CBC", Offset = "0x2B49CBC", VA = "0x2B49CBC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x2B49FBC", Offset = "0x2B49FBC", VA = "0x2B49FBC")]
	public RewindParticleSystem()
	{
	}
}
[Token(Token = "0x200001A")]
public class RewindParticleSystemSimple : MonoBehaviour
{
	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ParticleSystem[] particleSystems;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float simulationTime;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float startTime;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float internalStartTime;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private bool gameObjectDeactivated;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float simulationSpeed;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public bool useFixedDeltaTime;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
	public bool rewind;

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x2B49FD8", Offset = "0x2B49FD8", VA = "0x2B49FD8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x2B4A0F4", Offset = "0x2B4A0F4", VA = "0x2B4A0F4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x2B4A168", Offset = "0x2B4A168", VA = "0x2B4A168")]
	private void Update()
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x2B4A380", Offset = "0x2B4A380", VA = "0x2B4A380")]
	public RewindParticleSystemSimple()
	{
	}
}
[Token(Token = "0x200001B")]
public class RewindParticleSystemSuperSimple : MonoBehaviour
{
	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ParticleSystem[] particleSystems;

	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float[] simulationTimes;

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float startTime;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float simulationSpeedScale;

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x2B4A3A0", Offset = "0x2B4A3A0", VA = "0x2B4A3A0")]
	private void Initialize()
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x2B4A43C", Offset = "0x2B4A43C", VA = "0x2B4A43C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x2B4A4D8", Offset = "0x2B4A4D8", VA = "0x2B4A4D8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x2B4A7C0", Offset = "0x2B4A7C0", VA = "0x2B4A7C0")]
	public RewindParticleSystemSuperSimple()
	{
	}
}
[Token(Token = "0x200001C")]
public class ParticleForceFieldsDemo : MonoBehaviour
{
	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x124DFBC", Offset = "0x124DFBC")]
	public Text FPSText;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Text particleCountText;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Toggle postProcessingToggle;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public MonoBehaviour postProcessing;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x124DFF4", Offset = "0x124DFF4")]
	public ParticleSystem particleSystem;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private ParticleSystem.MainModule particleSystemMainModule;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private ParticleSystem.EmissionModule particleSystemEmissionModule;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Text maxParticlesText;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Text particlesPerSecondText;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Slider maxParticlesSlider;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Slider particlesPerSecondSlider;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x124E02C", Offset = "0x124E02C")]
	public AttractionParticleForceField attractionParticleForceField;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Text attractionParticleForceFieldRadiusText;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Text attractionParticleForceFieldMaxForceText;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Text attractionParticleForceFieldArrivalRadiusText;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Text attractionParticleForceFieldArrivedRadiusText;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Text attractionParticleForceFieldPositionTextX;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Text attractionParticleForceFieldPositionTextY;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Text attractionParticleForceFieldPositionTextZ;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Slider attractionParticleForceFieldRadiusSlider;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Slider attractionParticleForceFieldMaxForceSlider;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Slider attractionParticleForceFieldArrivalRadiusSlider;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public Slider attractionParticleForceFieldArrivedRadiusSlider;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public Slider attractionParticleForceFieldPositionSliderX;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public Slider attractionParticleForceFieldPositionSliderY;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public Slider attractionParticleForceFieldPositionSliderZ;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x124E064", Offset = "0x124E064")]
	public VortexParticleForceField vortexParticleForceField;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public Text vortexParticleForceFieldRadiusText;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public Text vortexParticleForceFieldMaxForceText;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public Text vortexParticleForceFieldRotationTextX;

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public Text vortexParticleForceFieldRotationTextY;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public Text vortexParticleForceFieldRotationTextZ;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public Text vortexParticleForceFieldPositionTextX;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public Text vortexParticleForceFieldPositionTextY;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public Text vortexParticleForceFieldPositionTextZ;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public Slider vortexParticleForceFieldRadiusSlider;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	public Slider vortexParticleForceFieldMaxForceSlider;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	public Slider vortexParticleForceFieldRotationSliderX;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	public Slider vortexParticleForceFieldRotationSliderY;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	public Slider vortexParticleForceFieldRotationSliderZ;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	public Slider vortexParticleForceFieldPositionSliderX;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	public Slider vortexParticleForceFieldPositionSliderY;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	public Slider vortexParticleForceFieldPositionSliderZ;

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x3F728FC", Offset = "0x3F728FC", VA = "0x3F728FC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x3F733C0", Offset = "0x3F733C0", VA = "0x3F733C0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x3F734D0", Offset = "0x3F734D0", VA = "0x3F734D0")]
	public void ReloadScene()
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x3F7354C", Offset = "0x3F7354C", VA = "0x3F7354C")]
	public void SetMaxParticles(float value)
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x3F7360C", Offset = "0x3F7360C", VA = "0x3F7360C")]
	public void SetParticleEmissionPerSecond(float value)
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x3F736D8", Offset = "0x3F736D8", VA = "0x3F736D8")]
	public void SetAttractionParticleForceFieldRadius(float value)
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x3F7377C", Offset = "0x3F7377C", VA = "0x3F7377C")]
	public void SetAttractionParticleForceFieldMaxForce(float value)
	{
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x3F73820", Offset = "0x3F73820", VA = "0x3F73820")]
	public void SetAttractionParticleForceFieldArrivalRadius(float value)
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x3F738C4", Offset = "0x3F738C4", VA = "0x3F738C4")]
	public void SetAttractionParticleForceFieldArrivedRadius(float value)
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x3F73968", Offset = "0x3F73968", VA = "0x3F73968")]
	public void SetAttractionParticleForceFieldPositionX(float value)
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x3F73A54", Offset = "0x3F73A54", VA = "0x3F73A54")]
	public void SetAttractionParticleForceFieldPositionY(float value)
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x3F73B40", Offset = "0x3F73B40", VA = "0x3F73B40")]
	public void SetAttractionParticleForceFieldPositionZ(float value)
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x3F73C2C", Offset = "0x3F73C2C", VA = "0x3F73C2C")]
	public void SetVortexParticleForceFieldRadius(float value)
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x3F73CD0", Offset = "0x3F73CD0", VA = "0x3F73CD0")]
	public void SetVortexParticleForceFieldMaxForce(float value)
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x3F73D74", Offset = "0x3F73D74", VA = "0x3F73D74")]
	public void SetVortexParticleForceFieldRotationX(float value)
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x3F73E60", Offset = "0x3F73E60", VA = "0x3F73E60")]
	public void SetVortexParticleForceFieldRotationY(float value)
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x3F73F4C", Offset = "0x3F73F4C", VA = "0x3F73F4C")]
	public void SetVortexParticleForceFieldRotationZ(float value)
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x3F74038", Offset = "0x3F74038", VA = "0x3F74038")]
	public void SetVortexParticleForceFieldPositionX(float value)
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x3F74124", Offset = "0x3F74124", VA = "0x3F74124")]
	public void SetVortexParticleForceFieldPositionY(float value)
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x3F74210", Offset = "0x3F74210", VA = "0x3F74210")]
	public void SetVortexParticleForceFieldPositionZ(float value)
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x3F742FC", Offset = "0x3F742FC", VA = "0x3F742FC")]
	public ParticleForceFieldsDemo()
	{
	}
}
[Token(Token = "0x200001D")]
public class ParticleForceFieldsDemo_CameraRig : MonoBehaviour
{
	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform pivot;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Vector3 targetRotation;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x124E09C", Offset = "0x124E09C")]
	public float rotationLimit;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float rotationSpeed;

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float rotationLerpSpeed;

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector3 startRotation;

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x3F74304", Offset = "0x3F74304", VA = "0x3F74304")]
	private void Start()
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x3F74344", Offset = "0x3F74344", VA = "0x3F74344")]
	private void Update()
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x3F744C0", Offset = "0x3F744C0", VA = "0x3F744C0")]
	public ParticleForceFieldsDemo_CameraRig()
	{
	}
}
[Token(Token = "0x200001E")]
public class ParticlePlexusDemo_CameraRig : MonoBehaviour
{
	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform pivot;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Vector3 targetRotation;

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x124E0B8", Offset = "0x124E0B8")]
	public float rotationLimit;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float rotationSpeed;

	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float rotationLerpSpeed;

	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector3 startRotation;

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x3F76E90", Offset = "0x3F76E90", VA = "0x3F76E90")]
	private void Start()
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x3F76ED0", Offset = "0x3F76ED0", VA = "0x3F76ED0")]
	private void Update()
	{
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x3F7704C", Offset = "0x3F7704C", VA = "0x3F7704C")]
	public ParticlePlexusDemo_CameraRig()
	{
	}
}
[Token(Token = "0x200001F")]
public class FollowTarget : MonoBehaviour
{
	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform target;

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool enable;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private Vector3 playerOffset;

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x2C8442C", Offset = "0x2C8442C", VA = "0x2C8442C")]
	private void Start()
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x2C845D0", Offset = "0x2C845D0", VA = "0x2C845D0")]
	private void Update()
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x2C84644", Offset = "0x2C84644", VA = "0x2C84644")]
	public FollowTarget()
	{
	}
}
[Token(Token = "0x2000020")]
public class LogoAutoPos : MonoBehaviour
{
	[Token(Token = "0x600008F")]
	[Address(RVA = "0x3F6396C", Offset = "0x3F6396C", VA = "0x3F6396C")]
	public LogoAutoPos()
	{
	}
}
[Token(Token = "0x2000021")]
public class WESkybox : MonoBehaviour
{
	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x124E0D4", Offset = "0x124E0D4")]
	public VolumeProfile vp;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Volume _volume;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x124E10C", Offset = "0x124E10C")]
	public Material skyboxMat;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Cubemap curCubemap;

	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Color skyColor;

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float skyColorIntensity;

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public Color equatorColor;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public float equatorColorIntensity;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Color groundColor;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float groundColorIntensity;

	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public float reflectionIntensityMultiplier;

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x2B57EC4", Offset = "0x2B57EC4", VA = "0x2B57EC4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x2B57ED0", Offset = "0x2B57ED0", VA = "0x2B57ED0", Slot = "4")]
	protected virtual void InitTL()
	{
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x2B57EDC", Offset = "0x2B57EDC", VA = "0x2B57EDC")]
	private Color CalHDRIntensity(Color ambientColor, float intensitySet)
	{
		return default(Color);
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x2B57F40", Offset = "0x2B57F40", VA = "0x2B57F40")]
	public WESkybox()
	{
	}
}
[Token(Token = "0x2000022")]
public class Twinkle : MonoBehaviour
{
	[Token(Token = "0x2000023")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124CF38", Offset = "0x124CF38")]
	private sealed class <AutoDetactive>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Twinkle <>4__this;

		[Token(Token = "0x17000005")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600009F")]
			[Address(RVA = "0x3110390", Offset = "0x3110390", VA = "0x3110390", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000006")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000A1")]
			[Address(RVA = "0x31103D8", Offset = "0x31103D8", VA = "0x31103D8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x31102B0", Offset = "0x31102B0", VA = "0x31102B0")]
		[DebuggerHidden]
		public <AutoDetactive>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x31102DC", Offset = "0x31102DC", VA = "0x31102DC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x31102E0", Offset = "0x31102E0", VA = "0x31102E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x3110398", Offset = "0x3110398", VA = "0x3110398", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject[] f_Lamp;

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject[] l_Lamp;

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float timer;

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private bool isShine;

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x2B560D0", Offset = "0x2B560D0", VA = "0x2B560D0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x2B560D4", Offset = "0x2B560D4", VA = "0x2B560D4")]
	public void StartTwinkleIcecream()
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x2B5612C", Offset = "0x2B5612C", VA = "0x2B5612C")]
	public void StopTwinkleIcecream()
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x2B5617C", Offset = "0x2B5617C", VA = "0x2B5617C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x124FF08", Offset = "0x124FF08")]
	private IEnumerator AutoDetactive()
	{
		return null;
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x2B561F4", Offset = "0x2B561F4", VA = "0x2B561F4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x2B561F8", Offset = "0x2B561F8", VA = "0x2B561F8")]
	private void ExchangeLamp()
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x2B56324", Offset = "0x2B56324", VA = "0x2B56324")]
	private void LastLampBright()
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x2B56464", Offset = "0x2B56464", VA = "0x2B56464")]
	public Twinkle()
	{
	}
}
[Token(Token = "0x2000024")]
public class GIdleCrystalHotFix : MonoBehaviour
{
	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float cVibrationMinTime;

	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float cVibrationMaxTime;

	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float cVibrationMin;

	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float cVibrationMax;

	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float cShakeMaxDis;

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float cShakeMinDis;

	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float cAlphaDefault;

	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float cCheckTime;

	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float cBestTime;

	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float cStopTime;

	[Token(Token = "0x40000C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool mStopCourse;

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x2C85A50", Offset = "0x2C85A50", VA = "0x2C85A50")]
	private void Start()
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x2C85A54", Offset = "0x2C85A54", VA = "0x2C85A54")]
	public GIdleCrystalHotFix()
	{
	}
}
[Token(Token = "0x2000025")]
public class Readme : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x2000026")]
	public class Section
	{
		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string heading;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string text;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string linkText;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string url;

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x310E374", Offset = "0x310E374", VA = "0x310E374")]
		public Section()
		{
		}
	}

	[Token(Token = "0x40000C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Texture2D icon;

	[Token(Token = "0x40000CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string title;

	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Section[] sections;

	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool loadedLayout;

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x2B499B4", Offset = "0x2B499B4", VA = "0x2B499B4")]
	public Readme()
	{
	}
}
[Token(Token = "0x2000027")]
[ExecuteAlways]
public class AutoRotate : MonoBehaviour
{
	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool active;

	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject obj;

	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float speed;

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x2C78C18", Offset = "0x2C78C18", VA = "0x2C78C18")]
	private void Start()
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x2C78C1C", Offset = "0x2C78C1C", VA = "0x2C78C1C")]
	private void Update()
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x2C78CE4", Offset = "0x2C78CE4", VA = "0x2C78CE4")]
	public AutoRotate()
	{
	}
}
[Token(Token = "0x2000028")]
public class AudioWaveVisualizeManager : MonoBehaviour
{
	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x2C78B80", Offset = "0x2C78B80", VA = "0x2C78B80")]
	private void Start()
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x2C78B84", Offset = "0x2C78B84", VA = "0x2C78B84")]
	private void Update()
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x2C78B88", Offset = "0x2C78B88", VA = "0x2C78B88")]
	public AudioWaveVisualizeManager()
	{
	}
}
[Token(Token = "0x2000029")]
[ExecuteAlways]
public class FastRotateObjs : MonoBehaviour
{
	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject[] objs;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject target;

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float heightFalloffStart;

	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float heightFalloffSpeed;

	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float overAllOffset;

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x2C81A2C", Offset = "0x2C81A2C", VA = "0x2C81A2C")]
	private void Start()
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x2C81A30", Offset = "0x2C81A30", VA = "0x2C81A30")]
	private void Update()
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x2C81A98", Offset = "0x2C81A98", VA = "0x2C81A98")]
	private void RotateObj(GameObject obj)
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x2C81BF4", Offset = "0x2C81BF4", VA = "0x2C81BF4")]
	public FastRotateObjs()
	{
	}
}
[Token(Token = "0x200002A")]
public class GuerEnvManager : MonoBehaviour
{
	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject obj;

	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float rotateSpeed;

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x2C8701C", Offset = "0x2C8701C", VA = "0x2C8701C")]
	private void Start()
	{
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x2C87020", Offset = "0x2C87020", VA = "0x2C87020")]
	private void Update()
	{
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x2C870B8", Offset = "0x2C870B8", VA = "0x2C870B8")]
	public GuerEnvManager()
	{
	}
}
[Token(Token = "0x200002B")]
public class XRRigCollisionHandler
{
	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static List<GameObject> _triggeredGo;

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x2B4D614", Offset = "0x2B4D614", VA = "0x2B4D614")]
	public static void Start()
	{
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x2B4E010", Offset = "0x2B4E010", VA = "0x2B4E010")]
	public static void Stop()
	{
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x2B5A89C", Offset = "0x2B5A89C", VA = "0x2B5A89C")]
	private static void CollisionHandler(GameObject cc, Action<string> callBack)
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x2B5AA64", Offset = "0x2B5AA64", VA = "0x2B5AA64")]
	public XRRigCollisionHandler()
	{
	}
}
[Token(Token = "0x200002C")]
public class AvatarSceneLightEnvData : MonoBehaviour
{
	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float additiveGI;

	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static float g_curAdditiveGI;

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x2C79420", Offset = "0x2C79420", VA = "0x2C79420")]
	public void Start()
	{
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x2C7948C", Offset = "0x2C7948C", VA = "0x2C7948C")]
	public AvatarSceneLightEnvData()
	{
	}
}
[Token(Token = "0x200002D")]
public class LevelChange : MonoBehaviour
{
	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Animator _animator;

	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int _levelToLoad;

	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private int _currentLevelIndex;

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x3F614B0", Offset = "0x3F614B0", VA = "0x3F614B0")]
	private void Start()
	{
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x3F61588", Offset = "0x3F61588", VA = "0x3F61588")]
	private void Update()
	{
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x3F615DC", Offset = "0x3F615DC", VA = "0x3F615DC")]
	private void FadeToNextLevel()
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x3F6165C", Offset = "0x3F6165C", VA = "0x3F6165C")]
	private void FadeToPreviousLevel()
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x3F615F4", Offset = "0x3F615F4", VA = "0x3F615F4")]
	private void FadeToLevel(int levelIndex)
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x3F61674", Offset = "0x3F61674", VA = "0x3F61674")]
	public void OnFadeComplete()
	{
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x3F61734", Offset = "0x3F61734", VA = "0x3F61734")]
	public LevelChange()
	{
	}
}
[Token(Token = "0x200002E")]
public class PicoInteractiveProp : MonoBehaviour
{
	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ParticleSystem psTouchEffect;

	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject objTouchEffect;

	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected Vector3 TRInteractiveStartPosition;

	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	protected Vector3 _initTouchEffectPos;

	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Vector3 _startPosOffset;

	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	protected Vector3[] TRInteractiveEndPositions;

	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	protected int CurEndPosID;

	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public float MoveMinTime;

	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public float MoveMaxTime;

	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x124E144", Offset = "0x124E144")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x124E144", Offset = "0x124E144")]
	public Vector2 startOffsetX;

	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public Vector2 startOffsetY;

	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public Vector2 startOffsetZ;

	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public Vector2 endOffsetX;

	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public Vector2 endOffsetY;

	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public Vector2 endOffsetZ;

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x3F78850", Offset = "0x3F78850", VA = "0x3F78850")]
	private void Start()
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x3F7885C", Offset = "0x3F7885C", VA = "0x3F7885C", Slot = "4")]
	protected virtual void InitProp()
	{
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x3F78898", Offset = "0x3F78898", VA = "0x3F78898", Slot = "5")]
	public virtual void TouchThis()
	{
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x3F789A4", Offset = "0x3F789A4", VA = "0x3F789A4")]
	public void Spawn(GameObject obj)
	{
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x3F78BE0", Offset = "0x3F78BE0", VA = "0x3F78BE0", Slot = "6")]
	public virtual Vector3 GetPropPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x3F78C04", Offset = "0x3F78C04", VA = "0x3F78C04")]
	protected void InitFlyFromStage()
	{
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x3F78E68", Offset = "0x3F78E68", VA = "0x3F78E68")]
	public PicoInteractiveProp()
	{
	}
}
[Token(Token = "0x200002F")]
public class PipBird : PicoInteractiveProp
{
	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x3F795AC", Offset = "0x3F795AC", VA = "0x3F795AC", Slot = "4")]
	protected override void InitProp()
	{
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x3F79628", Offset = "0x3F79628", VA = "0x3F79628", Slot = "5")]
	public override void TouchThis()
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x3F7962C", Offset = "0x3F7962C", VA = "0x3F7962C", Slot = "6")]
	public override Vector3 GetPropPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x3F79630", Offset = "0x3F79630", VA = "0x3F79630")]
	public PipBird()
	{
	}
}
[Token(Token = "0x2000030")]
public class PipBrassGong : PicoInteractiveProp
{
	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public float[] Angel;

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x3F79634", Offset = "0x3F79634", VA = "0x3F79634", Slot = "4")]
	protected override void InitProp()
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x3F79804", Offset = "0x3F79804", VA = "0x3F79804", Slot = "5")]
	public override void TouchThis()
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x3F79808", Offset = "0x3F79808", VA = "0x3F79808")]
	public PipBrassGong()
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x3F79890", Offset = "0x3F79890", VA = "0x3F79890")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124FFB8", Offset = "0x124FFB8")]
	private void <InitProp>b__1_0()
	{
	}
}
[Token(Token = "0x2000031")]
public class PipDandelion : PicoInteractiveProp
{
	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public float delayGrowUp;

	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Vector2 ScaleSize;

	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Vector3 _initPos;

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x3F79C3C", Offset = "0x3F79C3C", VA = "0x3F79C3C", Slot = "4")]
	protected override void InitProp()
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x3F79C8C", Offset = "0x3F79C8C", VA = "0x3F79C8C", Slot = "5")]
	public override void TouchThis()
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x3F79E40", Offset = "0x3F79E40", VA = "0x3F79E40")]
	public void GrowUp()
	{
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x3F79F4C", Offset = "0x3F79F4C", VA = "0x3F79F4C")]
	public PipDandelion()
	{
	}
}
[Token(Token = "0x2000032")]
public class PipDriftingBottle : PicoInteractiveProp
{
	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public float[] Angel;

	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public ParticleSystem[] fireworks;

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x3F79F68", Offset = "0x3F79F68", VA = "0x3F79F68", Slot = "4")]
	protected override void InitProp()
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x3F7A138", Offset = "0x3F7A138", VA = "0x3F7A138", Slot = "5")]
	public override void TouchThis()
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x3F7A358", Offset = "0x3F7A358", VA = "0x3F7A358")]
	public PipDriftingBottle()
	{
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x3F7A3E0", Offset = "0x3F7A3E0", VA = "0x3F7A3E0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124FFC8", Offset = "0x124FFC8")]
	private void <InitProp>b__2_0()
	{
	}
}
[Token(Token = "0x2000033")]
public class PipEmoji : PicoInteractiveProp
{
	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x3F7A4B0", Offset = "0x3F7A4B0", VA = "0x3F7A4B0", Slot = "4")]
	protected override void InitProp()
	{
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x3F7A658", Offset = "0x3F7A658", VA = "0x3F7A658", Slot = "5")]
	public override void TouchThis()
	{
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x3F7A65C", Offset = "0x3F7A65C", VA = "0x3F7A65C")]
	public PipEmoji()
	{
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x3F7A660", Offset = "0x3F7A660", VA = "0x3F7A660")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124FFD8", Offset = "0x124FFD8")]
	private void <InitProp>b__0_0()
	{
	}
}
[Token(Token = "0x2000034")]
public class PipSardine : PicoInteractiveProp
{
	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public ParticleSystem[] fireworks;

	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Transform[] _fishPath;

	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private GameObject _objShadinePS;

	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private ParticleSystem.Particle[] _psParticle;

	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private int _currentAmount;

	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private Vector3[] fishPathPoints;

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x3F7AAE4", Offset = "0x3F7AAE4", VA = "0x3F7AAE4", Slot = "4")]
	protected override void InitProp()
	{
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x3F7AE34", Offset = "0x3F7AE34", VA = "0x3F7AE34", Slot = "5")]
	public override void TouchThis()
	{
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x3F7B054", Offset = "0x3F7B054", VA = "0x3F7B054")]
	private void ResetByShadinPS()
	{
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x3F7B33C", Offset = "0x3F7B33C", VA = "0x3F7B33C")]
	public PipSardine()
	{
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x3F7B340", Offset = "0x3F7B340", VA = "0x3F7B340")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124FFE8", Offset = "0x124FFE8")]
	private void <InitProp>b__6_0()
	{
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x3F7B410", Offset = "0x3F7B410", VA = "0x3F7B410")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124FFF8", Offset = "0x124FFF8")]
	private void <ResetByShadinPS>b__8_0()
	{
	}
}
[Token(Token = "0x2000035")]
public class Piplyric : PicoInteractiveProp
{
	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private TextMeshPro _textMeshPro;

	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public string[] lyrics;

	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private int _curTime;

	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Transform[] lyricsEndPos;

	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private int _tempPosID;

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x3F7B7C0", Offset = "0x3F7B7C0", VA = "0x3F7B7C0", Slot = "4")]
	protected override void InitProp()
	{
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x3F7B7FC", Offset = "0x3F7B7FC", VA = "0x3F7B7FC")]
	private void MoveThis()
	{
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x3F7B9F4", Offset = "0x3F7B9F4", VA = "0x3F7B9F4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x3F7BA08", Offset = "0x3F7BA08", VA = "0x3F7BA08", Slot = "5")]
	public override void TouchThis()
	{
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x3F7BB24", Offset = "0x3F7BB24", VA = "0x3F7BB24")]
	private void HiddenThis()
	{
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x3F7BBE0", Offset = "0x3F7BBE0", VA = "0x3F7BBE0")]
	public Piplyric()
	{
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x3F7BBE4", Offset = "0x3F7BBE4", VA = "0x3F7BBE4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1250008", Offset = "0x1250008")]
	private void <MoveThis>b__6_0()
	{
	}
}
[Token(Token = "0x2000036")]
public class PositionChange : MonoBehaviour
{
	[Token(Token = "0x4000101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int _curPosID;

	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private bool _primaryButtonIsDown;

	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	private bool _primaryButtonIsDone;

	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
	private bool _secondButtonIsDown;

	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F")]
	private bool _secondButtonIsDone;

	[Token(Token = "0x4000106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Transform _xrRig;

	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x124E1A4", Offset = "0x124E1A4")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x124E1A4", Offset = "0x124E1A4")]
	public Transform[] trPositions;

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x2B493A8", Offset = "0x2B493A8", VA = "0x2B493A8")]
	private void Start()
	{
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x2B49414", Offset = "0x2B49414", VA = "0x2B49414")]
	private void Update()
	{
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x2B49418", Offset = "0x2B49418", VA = "0x2B49418")]
	private void SwitchLevelDetect()
	{
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x2B495B8", Offset = "0x2B495B8", VA = "0x2B495B8")]
	private void GoToNextPos()
	{
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x2B49580", Offset = "0x2B49580", VA = "0x2B49580")]
	private void GoToPreviousPos()
	{
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x2B495F0", Offset = "0x2B495F0", VA = "0x2B495F0")]
	private void SwitchPos(int posID)
	{
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x2B49654", Offset = "0x2B49654", VA = "0x2B49654")]
	public PositionChange()
	{
	}
}
[Token(Token = "0x2000037")]
public class ShadineMovePath : MonoBehaviour
{
	[Token(Token = "0x4000108")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform[] _fishPath;

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x2B4C3BC", Offset = "0x2B4C3BC", VA = "0x2B4C3BC")]
	public ShadineMovePath()
	{
	}
}
[Token(Token = "0x2000038")]
public class PDLBeiJingBeiJing : PlayableDirectorLogic
{
	[Token(Token = "0x4000109")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public AutoSwarpTexture[] autoSwarpTexture;

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x3F6C028", Offset = "0x3F6C028", VA = "0x3F6C028", Slot = "4")]
	protected override void InitTL()
	{
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x3F6C030", Offset = "0x3F6C030", VA = "0x3F6C030")]
	public void SwarpToLastTexture()
	{
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x3F6C09C", Offset = "0x3F6C09C", VA = "0x3F6C09C")]
	public PDLBeiJingBeiJing()
	{
	}
}
[Token(Token = "0x2000039")]
public class PDLCanLanDeNi : PlayableDirectorLogic
{
	[Token(Token = "0x400010A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public GameObject[] fireworks;

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x3F6C0A4", Offset = "0x3F6C0A4", VA = "0x3F6C0A4", Slot = "6")]
	public override void StartDirector()
	{
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x3F6C11C", Offset = "0x3F6C11C", VA = "0x3F6C11C", Slot = "7")]
	public override void SpawnInteractiveProp()
	{
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x3F6C1B0", Offset = "0x3F6C1B0", VA = "0x3F6C1B0", Slot = "8")]
	public override void FinishDirector()
	{
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x3F6C1B8", Offset = "0x3F6C1B8", VA = "0x3F6C1B8")]
	public PDLCanLanDeNi()
	{
	}
}
[Token(Token = "0x200003A")]
public class PDLChunTianLi : PlayableDirectorLogic
{
	[Token(Token = "0x400010B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public GameObject objWuXianPu;

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x3F6C1C0", Offset = "0x3F6C1C0", VA = "0x3F6C1C0", Slot = "6")]
	public override void StartDirector()
	{
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x3F6C1F8", Offset = "0x3F6C1F8", VA = "0x3F6C1F8", Slot = "7")]
	public override void SpawnInteractiveProp()
	{
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x3F6C298", Offset = "0x3F6C298", VA = "0x3F6C298")]
	public PDLChunTianLi()
	{
	}
}
[Token(Token = "0x200003B")]
public class PDLDangWoXiangNiDeShiHou : PlayableDirectorLogic
{
	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Animator animBigMoGuiYu;

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x3F6C2A0", Offset = "0x3F6C2A0", VA = "0x3F6C2A0", Slot = "7")]
	public override void SpawnInteractiveProp()
	{
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x3F6C340", Offset = "0x3F6C340", VA = "0x3F6C340")]
	public void MoGuiYuFly()
	{
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x3F6C398", Offset = "0x3F6C398", VA = "0x3F6C398")]
	public PDLDangWoXiangNiDeShiHou()
	{
	}
}
[Token(Token = "0x200003C")]
public class PDLFeiNiao : PlayableDirectorLogic
{
	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private PipDandelion[] _pipDandelions;

	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public ParticleSystem puGongYinAround;

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x3F6C3A0", Offset = "0x3F6C3A0", VA = "0x3F6C3A0", Slot = "4")]
	protected override void InitTL()
	{
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x3F6C430", Offset = "0x3F6C430", VA = "0x3F6C430", Slot = "6")]
	public override void StartDirector()
	{
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x3F6C514", Offset = "0x3F6C514", VA = "0x3F6C514", Slot = "8")]
	public override void FinishDirector()
	{
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0x3F6C5B4", Offset = "0x3F6C5B4", VA = "0x3F6C5B4")]
	private void EnableDandelions(bool enableDL)
	{
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x3F6C6C8", Offset = "0x3F6C6C8", VA = "0x3F6C6C8")]
	public PDLFeiNiao()
	{
	}
}
[Token(Token = "0x200003D")]
public class PDLHeLiu : PlayableDirectorLogic
{
	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private int _curLyricsID;

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x3F6C6D0", Offset = "0x3F6C6D0", VA = "0x3F6C6D0", Slot = "7")]
	public override void SpawnInteractiveProp()
	{
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0x3F6C730", Offset = "0x3F6C730", VA = "0x3F6C730")]
	private void UpdateShaderGlobalVector()
	{
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0x3F6C734", Offset = "0x3F6C734", VA = "0x3F6C734")]
	public PDLHeLiu()
	{
	}
}
[Token(Token = "0x200003E")]
public class PDLMeiLiShiJieDeGuEr : PlayableDirectorLogic
{
	[Token(Token = "0x6000107")]
	[Address(RVA = "0x3F6C73C", Offset = "0x3F6C73C", VA = "0x3F6C73C", Slot = "7")]
	public override void SpawnInteractiveProp()
	{
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x3F6C7DC", Offset = "0x3F6C7DC", VA = "0x3F6C7DC")]
	public PDLMeiLiShiJieDeGuEr()
	{
	}
}
[Token(Token = "0x200003F")]
public class PDLYiQiYaoBai : PlayableDirectorLogic
{
	[Token(Token = "0x6000109")]
	[Address(RVA = "0x3F6C7E4", Offset = "0x3F6C7E4", VA = "0x3F6C7E4", Slot = "7")]
	public override void SpawnInteractiveProp()
	{
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x3F6C894", Offset = "0x3F6C894", VA = "0x3F6C894")]
	public PDLYiQiYaoBai()
	{
	}
}
[Token(Token = "0x2000040")]
public class PlayableDirectorLogic : MonoBehaviour
{
	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private PlayableDirector _playableDirector;

	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float _speedUpTime;

	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x124E204", Offset = "0x124E204")]
	public float spawnDelayTime;

	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float spawnInvertTime;

	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x124E23C", Offset = "0x124E23C")]
	public Material skyboxMat;

	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Cubemap curCubemap;

	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Color skyColor;

	[Token(Token = "0x4000117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float skyColorIntensity;

	[Token(Token = "0x4000118")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public Color equatorColor;

	[Token(Token = "0x4000119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public float equatorColorIntensity;

	[Token(Token = "0x400011A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Color groundColor;

	[Token(Token = "0x400011B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public float groundColorIntensity;

	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public float reflectionIntensityMultiplier;

	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x124E274", Offset = "0x124E274")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x124E274", Offset = "0x124E274")]
	public bool bEnableOffset;

	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public float initStartTime;

	[Token(Token = "0x400011F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public GameObject[] interactiveProps;

	[Token(Token = "0x4000120")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private bool _spawning;

	[Token(Token = "0x600010B")]
	[Address(RVA = "0x2B4848C", Offset = "0x2B4848C", VA = "0x2B4848C")]
	private void Start()
	{
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0x2B48560", Offset = "0x2B48560", VA = "0x2B48560")]
	private void TestPlayPD()
	{
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0x2B48704", Offset = "0x2B48704", VA = "0x2B48704")]
	private void Update()
	{
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0x2B48710", Offset = "0x2B48710", VA = "0x2B48710", Slot = "4")]
	protected virtual void InitTL()
	{
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0x2B487EC", Offset = "0x2B487EC", VA = "0x2B487EC")]
	private Color CalHDRIntensity(Color ambientColor, float intensitySet)
	{
		return default(Color);
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0x2B48850", Offset = "0x2B48850", VA = "0x2B48850", Slot = "5")]
	protected virtual void UpdateTL()
	{
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0x2B48568", Offset = "0x2B48568", VA = "0x2B48568")]
	public void OffsetPlayableDirector(float offset)
	{
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0x2B48854", Offset = "0x2B48854", VA = "0x2B48854")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0x2B48860", Offset = "0x2B48860", VA = "0x2B48860")]
	public void PlayPlayableDirector()
	{
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0x2B4887C", Offset = "0x2B4887C", VA = "0x2B4887C", Slot = "6")]
	public virtual void StartDirector()
	{
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0x2B489CC", Offset = "0x2B489CC", VA = "0x2B489CC", Slot = "7")]
	public virtual void SpawnInteractiveProp()
	{
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0x2B489D0", Offset = "0x2B489D0", VA = "0x2B489D0", Slot = "8")]
	public virtual void FinishDirector()
	{
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x2B48CC0", Offset = "0x2B48CC0", VA = "0x2B48CC0")]
	public PlayableDirectorLogic()
	{
	}
}
[Token(Token = "0x2000041")]
public class AudioLoudnessTrack : MonoBehaviour
{
	[Token(Token = "0x4000121")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioSource audioSource;

	[Token(Token = "0x4000122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float updateStep;

	[Token(Token = "0x4000123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int sampleDataLength;

	[Token(Token = "0x4000124")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float _currentUpdateTime;

	[Token(Token = "0x4000125")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float _currentClipLoudness;

	[Token(Token = "0x4000126")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float _lerpCurClipLoudness;

	[Token(Token = "0x4000127")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Vector3 _currentLocalScale;

	[Token(Token = "0x4000128")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x124E2D4", Offset = "0x124E2D4")]
	public float clipLoudness;

	[Token(Token = "0x4000129")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float[] _clipSampleData;

	[Token(Token = "0x400012A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject obj;

	[Token(Token = "0x400012B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public float sizeFactor;

	[Token(Token = "0x400012C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public float minSize;

	[Token(Token = "0x400012D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public float maxSize;

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x2C78968", Offset = "0x2C78968", VA = "0x2C78968")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0x2C789C4", Offset = "0x2C789C4", VA = "0x2C789C4")]
	private void Update()
	{
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0x2C78B58", Offset = "0x2C78B58", VA = "0x2C78B58")]
	public AudioLoudnessTrack()
	{
	}
}
[Token(Token = "0x2000042")]
public class AutoSwarpTexture : MonoBehaviour
{
	[Token(Token = "0x400012E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int startID;

	[Token(Token = "0x400012F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float delayTime;

	[Token(Token = "0x4000130")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject frontScreen;

	[Token(Token = "0x4000131")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Texture lastTexture;

	[Token(Token = "0x4000132")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Texture[] mainTextures;

	[Token(Token = "0x4000133")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Color _initColor;

	[Token(Token = "0x4000134")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Color _targetColor;

	[Token(Token = "0x4000135")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Material _mainMat;

	[Token(Token = "0x4000136")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Material _frontMeshMat;

	[Token(Token = "0x600011B")]
	[Address(RVA = "0x2C78CF4", Offset = "0x2C78CF4", VA = "0x2C78CF4")]
	private void Start()
	{
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0x2C78EA0", Offset = "0x2C78EA0", VA = "0x2C78EA0")]
	private void SwarpTexture()
	{
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0x2C78FD0", Offset = "0x2C78FD0", VA = "0x2C78FD0")]
	public void SwarpTheLastTextue()
	{
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x2C790E8", Offset = "0x2C790E8", VA = "0x2C790E8")]
	public AutoSwarpTexture()
	{
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0x2C790F0", Offset = "0x2C790F0", VA = "0x2C790F0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1250018", Offset = "0x1250018")]
	private void <SwarpTexture>b__10_0()
	{
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0x2C7917C", Offset = "0x2C7917C", VA = "0x2C7917C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1250028", Offset = "0x1250028")]
	private void <SwarpTheLastTextue>b__11_0()
	{
	}
}
[Token(Token = "0x2000043")]
public class AvataDetect : MonoBehaviour
{
	[Token(Token = "0x4000137")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public RuntimeAnimatorController[] animControllers;

	[Token(Token = "0x6000121")]
	[Address(RVA = "0x2C791E8", Offset = "0x2C791E8", VA = "0x2C791E8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0x2C79324", Offset = "0x2C79324", VA = "0x2C79324")]
	public void UpdateAnimControllerByLevel(int LevelID)
	{
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0x2C79418", Offset = "0x2C79418", VA = "0x2C79418")]
	public AvataDetect()
	{
	}
}
[Token(Token = "0x2000044")]
public class Flock : MonoBehaviour
{
	[Token(Token = "0x4000138")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float speed;

	[Token(Token = "0x4000139")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private float _rotationSpeed;

	[Token(Token = "0x400013A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Vector3 _averageHeading;

	[Token(Token = "0x400013B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private Vector3 _averagePosition;

	[Token(Token = "0x400013C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float neighourDistance;

	[Token(Token = "0x400013D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private bool _turning;

	[Token(Token = "0x6000124")]
	[Address(RVA = "0x2C82634", Offset = "0x2C82634", VA = "0x2C82634")]
	private void Start()
	{
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0x2C82668", Offset = "0x2C82668", VA = "0x2C82668")]
	private void Update()
	{
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0x2C828BC", Offset = "0x2C828BC", VA = "0x2C828BC")]
	private void ApplyRules()
	{
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0x2C82D8C", Offset = "0x2C82D8C", VA = "0x2C82D8C")]
	public Flock()
	{
	}
}
[Token(Token = "0x2000045")]
public class GlobalFlock : MonoBehaviour
{
	[Token(Token = "0x400013E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject fishPrefab;

	[Token(Token = "0x400013F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject goalPrefabe;

	[Token(Token = "0x4000140")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static Vector3 tankSize;

	[Token(Token = "0x4000141")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int numFish;

	[Token(Token = "0x4000142")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static GameObject[] allFish;

	[Token(Token = "0x4000143")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static Vector3 goalPos;

	[Token(Token = "0x6000128")]
	[Address(RVA = "0x2C85CAC", Offset = "0x2C85CAC", VA = "0x2C85CAC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0x2C85F5C", Offset = "0x2C85F5C", VA = "0x2C85F5C")]
	private void Update()
	{
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0x2C86004", Offset = "0x2C86004", VA = "0x2C86004")]
	private void ResetGoalPos()
	{
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0x2C860FC", Offset = "0x2C860FC", VA = "0x2C860FC")]
	public GlobalFlock()
	{
	}
}
[Token(Token = "0x2000046")]
public class ParticleAudioCtr : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000047")]
	public class Pool
	{
		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string tag;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject prefab;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int size;

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x310E0E0", Offset = "0x310E0E0", VA = "0x310E0E0")]
		public Pool()
		{
		}
	}

	[Token(Token = "0x2000048")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124CF68", Offset = "0x124CF68")]
	private sealed class <LateCall>d__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ParticleAudioCtr <>4__this;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject soundInstance;

		[Token(Token = "0x17000007")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000137")]
			[Address(RVA = "0x310E090", Offset = "0x310E090", VA = "0x310E090", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000008")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000139")]
			[Address(RVA = "0x310E0D8", Offset = "0x310E0D8", VA = "0x310E0D8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x310DF98", Offset = "0x310DF98", VA = "0x310DF98")]
		[DebuggerHidden]
		public <LateCall>d__21(int <>1__state)
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x310DFC4", Offset = "0x310DFC4", VA = "0x310DFC4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x310DFC8", Offset = "0x310DFC8", VA = "0x310DFC8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x310E098", Offset = "0x310E098", VA = "0x310E098", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000144")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float poolReturnTimer;

	[Token(Token = "0x4000145")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float explosionMinVolume;

	[Token(Token = "0x4000146")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float explosionMaxVolume;

	[Token(Token = "0x4000147")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float explosionPitchMin;

	[Token(Token = "0x4000148")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float explosionPitchMax;

	[Token(Token = "0x4000149")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float shootMinVolume;

	[Token(Token = "0x400014A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float shootMaxVolume;

	[Token(Token = "0x400014B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float shootPitchMin;

	[Token(Token = "0x400014C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float shootPitchMax;

	[Token(Token = "0x400014D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public AudioClip[] audioShot;

	[Token(Token = "0x400014E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public AudioClip[] audioExplosion;

	[Token(Token = "0x400014F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static ParticleAudioCtr SharedInstance;

	[Token(Token = "0x4000150")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private string _shotAudioTag;

	[Token(Token = "0x4000151")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private string _explosionAudioTag;

	[Token(Token = "0x4000152")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public List<Pool> pools;

	[Token(Token = "0x4000153")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Dictionary<string, Queue<GameObject>> poolDictionary;

	[Token(Token = "0x600012D")]
	[Address(RVA = "0x3F6EE64", Offset = "0x3F6EE64", VA = "0x3F6EE64")]
	private void Awake()
	{
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0x3F6EEB8", Offset = "0x3F6EEB8", VA = "0x3F6EEB8")]
	private void Start()
	{
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0x3F6F388", Offset = "0x3F6F388", VA = "0x3F6F388")]
	public GameObject SpawnFromPool(string tag, Vector3 position)
	{
		return null;
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0x3F6F550", Offset = "0x3F6F550", VA = "0x3F6F550")]
	public void LateUpdate()
	{
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0x3F6F844", Offset = "0x3F6F844", VA = "0x3F6F844")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1250038", Offset = "0x1250038")]
	private IEnumerator LateCall(GameObject soundInstance)
	{
		return null;
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0x3F6F8D8", Offset = "0x3F6F8D8", VA = "0x3F6F8D8")]
	public ParticleAudioCtr()
	{
	}
}
[Token(Token = "0x2000049")]
public class ParticlePosCtr : MonoBehaviour
{
	[Token(Token = "0x400015B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform[] randomPos;

	[Token(Token = "0x400015C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private ParticleSystem _particleSystem;

	[Token(Token = "0x400015D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool finishedDirector;

	[Token(Token = "0x600013A")]
	[Address(RVA = "0x3F77068", Offset = "0x3F77068", VA = "0x3F77068")]
	private void Start()
	{
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0x3F770FC", Offset = "0x3F770FC", VA = "0x3F770FC")]
	private void OnParticleSystemStopped()
	{
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0x3F77220", Offset = "0x3F77220", VA = "0x3F77220")]
	public ParticlePosCtr()
	{
	}
}
[Token(Token = "0x200004A")]
public class PropSound : MonoBehaviour
{
	[Token(Token = "0x600013D")]
	[Address(RVA = "0x2B49988", Offset = "0x2B49988", VA = "0x2B49988")]
	public Vector3 GetSoundLocation()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0x2B499AC", Offset = "0x2B499AC", VA = "0x2B499AC")]
	public PropSound()
	{
	}
}
[Token(Token = "0x200004B")]
public class SpotLightLogic : MonoBehaviour
{
	[Token(Token = "0x400015E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector2 rotateRangeX;

	[Token(Token = "0x400015F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector2 rotateRangeY;

	[Token(Token = "0x4000160")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector2 rotateRangeZ;

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x2B4F4CC", Offset = "0x2B4F4CC", VA = "0x2B4F4CC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x2B4F4D0", Offset = "0x2B4F4D0", VA = "0x2B4F4D0")]
	private void AutoRotate()
	{
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0x2B4F61C", Offset = "0x2B4F61C", VA = "0x2B4F61C")]
	public SpotLightLogic()
	{
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0x2B4F624", Offset = "0x2B4F624", VA = "0x2B4F624")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x12500E8", Offset = "0x12500E8")]
	private void <AutoRotate>b__4_0()
	{
	}
}
[Token(Token = "0x200004C")]
public class TempObjectCollection : MonoBehaviour
{
	[Token(Token = "0x4000161")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static TempObjectCollection Instance;

	[Token(Token = "0x4000162")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static List<GameObject> tempSpawnObjects;

	[Token(Token = "0x6000143")]
	[Address(RVA = "0x2B522D4", Offset = "0x2B522D4", VA = "0x2B522D4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0x2B52340", Offset = "0x2B52340", VA = "0x2B52340")]
	public GameObject CusSpawnGameObject(GameObject objToSpawn, Vector3 pos, Quaternion rot)
	{
		return null;
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0x2B52480", Offset = "0x2B52480", VA = "0x2B52480")]
	public GameObject CusSpawnGameObject(GameObject objToSpawn)
	{
		return null;
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0x2B48AEC", Offset = "0x2B48AEC", VA = "0x2B48AEC")]
	public void DestroyTempObjects()
	{
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0x2B52568", Offset = "0x2B52568", VA = "0x2B52568")]
	public TempObjectCollection()
	{
	}
}
[Token(Token = "0x200004D")]
public class TestParticlePosition : MonoBehaviour
{
	[Token(Token = "0x4000163")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ParticleSystem.Particle[] _psParticle;

	[Token(Token = "0x4000164")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int _currentAmount;

	[Token(Token = "0x4000165")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private Vector3 _pos;

	[Token(Token = "0x4000166")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject objTest;

	[Token(Token = "0x6000149")]
	[Address(RVA = "0x2B539FC", Offset = "0x2B539FC", VA = "0x2B539FC")]
	private void Start()
	{
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0x2B53A00", Offset = "0x2B53A00", VA = "0x2B53A00")]
	private void Update()
	{
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0x2B53C3C", Offset = "0x2B53C3C", VA = "0x2B53C3C")]
	public TestParticlePosition()
	{
	}
}
[Token(Token = "0x200004E")]
public class YinFuAnim : MonoBehaviour
{
	[Token(Token = "0x4000167")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Animation _animation;

	[Token(Token = "0x600014C")]
	[Address(RVA = "0x2B5AE38", Offset = "0x2B5AE38", VA = "0x2B5AE38")]
	private void Start()
	{
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0x2B5B10C", Offset = "0x2B5B10C", VA = "0x2B5B10C")]
	public YinFuAnim()
	{
	}
}
[Token(Token = "0x200004F")]
public class WangFeng : MonoBehaviour
{
	[Token(Token = "0x4000168")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private string[] levelName;

	[Token(Token = "0x4000169")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int _curLevelID;

	[Token(Token = "0x400016A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private bool _primaryButtonIsDown;

	[Token(Token = "0x400016B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
	private bool _primaryButtonIsDone;

	[Token(Token = "0x400016C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
	private bool _secondButtonIsDown;

	[Token(Token = "0x400016D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x27")]
	private bool _secondButtonIsDone;

	[Token(Token = "0x600014E")]
	[Address(RVA = "0x2B57F54", Offset = "0x2B57F54", VA = "0x2B57F54")]
	private void Start()
	{
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0x2B57F58", Offset = "0x2B57F58", VA = "0x2B57F58")]
	private void Update()
	{
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0x2B57F5C", Offset = "0x2B57F5C", VA = "0x2B57F5C")]
	private void SwitchLevelDetect()
	{
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0x2B581E0", Offset = "0x2B581E0", VA = "0x2B581E0")]
	private void LoadNextLevel()
	{
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0x2B580C4", Offset = "0x2B580C4", VA = "0x2B580C4")]
	private void LoadPreviusLevel()
	{
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0x2B58418", Offset = "0x2B58418", VA = "0x2B58418")]
	private void SwitchLevel(int levelID)
	{
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0x2B584F0", Offset = "0x2B584F0", VA = "0x2B584F0")]
	public WangFeng()
	{
	}
}
[Token(Token = "0x2000050")]
public class WangFengRoot : MonoBehaviour
{
	[Token(Token = "0x2000051")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124CF78", Offset = "0x124CF78")]
	private sealed class <AsyncLoadScene>d__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public WangFengRoot <>4__this;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int index;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <time>5__2;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private UniversalAdditionalCameraData <camData>5__3;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string <sceneName>5__4;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private LoadingInfo <loadingInfo>5__5;

		[Token(Token = "0x17000009")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000164")]
			[Address(RVA = "0x3110C70", Offset = "0x3110C70", VA = "0x3110C70", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000166")]
			[Address(RVA = "0x3110CB8", Offset = "0x3110CB8", VA = "0x3110CB8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x31103E0", Offset = "0x31103E0", VA = "0x31103E0")]
		[DebuggerHidden]
		public <AsyncLoadScene>d__10(int <>1__state)
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x311040C", Offset = "0x311040C", VA = "0x311040C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x3110410", Offset = "0x3110410", VA = "0x3110410", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x3110C78", Offset = "0x3110C78", VA = "0x3110C78", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000052")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124CF88", Offset = "0x124CF88")]
	private sealed class <AsyncUnLoadScene>d__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public WangFengRoot <>4__this;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int index;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string <sceneName>5__2;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private LoadingInfo <unloadingInfo>5__3;

		[Token(Token = "0x1700000B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600016A")]
			[Address(RVA = "0x3110FA0", Offset = "0x3110FA0", VA = "0x3110FA0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600016C")]
			[Address(RVA = "0x3110FE8", Offset = "0x3110FE8", VA = "0x3110FE8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x3110CC0", Offset = "0x3110CC0", VA = "0x3110CC0")]
		[DebuggerHidden]
		public <AsyncUnLoadScene>d__11(int <>1__state)
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x3110CEC", Offset = "0x3110CEC", VA = "0x3110CEC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x3110CF0", Offset = "0x3110CF0", VA = "0x3110CF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x3110FA8", Offset = "0x3110FA8", VA = "0x3110FA8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400016E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private string[] levelName;

	[Token(Token = "0x400016F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int _curLevelIndex;

	[Token(Token = "0x4000170")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private bool _isChanging;

	[Token(Token = "0x4000171")]
	private const string SCENE_BASE_PATH = "Standard/WangFeng/Scenes";

	[Token(Token = "0x4000172")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Volume blendVolume;

	[Token(Token = "0x4000173")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float blendTime;

	[Token(Token = "0x4000174")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private int _testIndex;

	[Token(Token = "0x4000175")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool _isForTest;

	[Token(Token = "0x4000176")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	private bool secondaryButtonDown;

	[Token(Token = "0x6000155")]
	[Address(RVA = "0x2B58800", Offset = "0x2B58800", VA = "0x2B58800")]
	public int GetLevelIndex()
	{
		return default(int);
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0x2B58808", Offset = "0x2B58808", VA = "0x2B58808")]
	private void Start()
	{
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0x2B588E0", Offset = "0x2B588E0", VA = "0x2B588E0")]
	private void InitMainScene()
	{
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0x2B58300", Offset = "0x2B58300", VA = "0x2B58300")]
	public void OnSwitchLevel(int index)
	{
	}

	[Token(Token = "0x6000159")]
	[Address(RVA = "0x2B58B24", Offset = "0x2B58B24", VA = "0x2B58B24")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x12500F8", Offset = "0x12500F8")]
	private IEnumerator AsyncLoadScene(int index)
	{
		return null;
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0x2B58BAC", Offset = "0x2B58BAC", VA = "0x2B58BAC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1250158", Offset = "0x1250158")]
	private IEnumerator AsyncUnLoadScene(int index)
	{
		return null;
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0x2B589E4", Offset = "0x2B589E4", VA = "0x2B589E4")]
	private bool IsLegalIndex(int id)
	{
		return default(bool);
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0x2B58C34", Offset = "0x2B58C34", VA = "0x2B58C34")]
	private bool IsNotRepeat(int id)
	{
		return default(bool);
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0x2B58C68", Offset = "0x2B58C68", VA = "0x2B58C68")]
	private void Update()
	{
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x2B58C78", Offset = "0x2B58C78", VA = "0x2B58C78")]
	private void SwarpSceneDetect()
	{
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0x2B58D7C", Offset = "0x2B58D7C", VA = "0x2B58D7C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0x2B58F6C", Offset = "0x2B58F6C", VA = "0x2B58F6C")]
	public WangFengRoot()
	{
	}
}
[Token(Token = "0x2000053")]
public class CameraHolder : MonoBehaviour
{
	[Token(Token = "0x4000185")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float windowDpi;

	[Token(Token = "0x4000186")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GUIStyle screenGUI;

	[Token(Token = "0x4000187")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject[] Prefabs;

	[Token(Token = "0x4000188")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int Prefab;

	[Token(Token = "0x4000189")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private GameObject Instance;

	[Token(Token = "0x600016D")]
	[Address(RVA = "0x2C7A1BC", Offset = "0x2C7A1BC", VA = "0x2C7A1BC")]
	private void Start()
	{
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0x2C7A40C", Offset = "0x2C7A40C", VA = "0x2C7A40C")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0x2C7A2B8", Offset = "0x2C7A2B8", VA = "0x2C7A2B8")]
	private void Counter(int count)
	{
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0x2C7A568", Offset = "0x2C7A568", VA = "0x2C7A568")]
	public CameraHolder()
	{
	}
}
[Token(Token = "0x2000054")]
public class ParticleEndSound : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000055")]
	public class Pool
	{
		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string tag;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject prefab;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int size;

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x310E230", Offset = "0x310E230", VA = "0x310E230")]
		public Pool()
		{
		}
	}

	[Token(Token = "0x2000056")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124CF98", Offset = "0x124CF98")]
	private sealed class <LateCall>d__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ParticleEndSound <>4__this;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject soundInstance;

		[Token(Token = "0x1700000D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600017B")]
			[Address(RVA = "0x310E1E0", Offset = "0x310E1E0", VA = "0x310E1E0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600017D")]
			[Address(RVA = "0x310E228", Offset = "0x310E228", VA = "0x310E228", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x310E0E8", Offset = "0x310E0E8", VA = "0x310E0E8")]
		[DebuggerHidden]
		public <LateCall>d__19(int <>1__state)
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x310E114", Offset = "0x310E114", VA = "0x310E114", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x310E118", Offset = "0x310E118", VA = "0x310E118", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x310E1E8", Offset = "0x310E1E8", VA = "0x310E1E8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400018A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float poolReturnTimer;

	[Token(Token = "0x400018B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float explosionMinVolume;

	[Token(Token = "0x400018C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float explosionMaxVolume;

	[Token(Token = "0x400018D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float explosionPitchMin;

	[Token(Token = "0x400018E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float explosionPitchMax;

	[Token(Token = "0x400018F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float shootMinVolume;

	[Token(Token = "0x4000190")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float shootMaxVolume;

	[Token(Token = "0x4000191")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float shootPitchMin;

	[Token(Token = "0x4000192")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float shootPitchMax;

	[Token(Token = "0x4000193")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public AudioClip[] audioExplosion;

	[Token(Token = "0x4000194")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public AudioClip[] audioShot;

	[Token(Token = "0x4000195")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static ParticleEndSound SharedInstance;

	[Token(Token = "0x4000196")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public List<Pool> pools;

	[Token(Token = "0x4000197")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Dictionary<string, Queue<GameObject>> poolDictionary;

	[Token(Token = "0x6000171")]
	[Address(RVA = "0x3F6FFE0", Offset = "0x3F6FFE0", VA = "0x3F6FFE0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0x3F70034", Offset = "0x3F70034", VA = "0x3F70034")]
	private void Start()
	{
	}

	[Token(Token = "0x6000173")]
	[Address(RVA = "0x3F7052C", Offset = "0x3F7052C", VA = "0x3F7052C")]
	public GameObject SpawnFromPool(string tag, Vector3 position)
	{
		return null;
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0x3F706F4", Offset = "0x3F706F4", VA = "0x3F706F4")]
	public void LateUpdate()
	{
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0x3F709E8", Offset = "0x3F709E8", VA = "0x3F709E8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1250258", Offset = "0x1250258")]
	private IEnumerator LateCall(GameObject soundInstance)
	{
		return null;
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0x3F70A7C", Offset = "0x3F70A7C", VA = "0x3F70A7C")]
	public ParticleEndSound()
	{
	}
}
[Token(Token = "0x2000057")]
public class HouseWireFrameSetting : MonoBehaviour
{
	[Token(Token = "0x400019F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Texture2D wireTex;

	[Token(Token = "0x600017E")]
	[Address(RVA = "0x2C870CC", Offset = "0x2C870CC", VA = "0x2C870CC")]
	public HouseWireFrameSetting()
	{
	}
}
[Token(Token = "0x2000058")]
public class HouseWireframeGrowup : MonoBehaviour
{
	[Token(Token = "0x40001A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject obj;

	[Token(Token = "0x40001A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject tempObj;

	[Token(Token = "0x40001A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Color LineColor;

	[Token(Token = "0x40001A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float LineColorIntensity;

	[Token(Token = "0x40001A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Material wireMat;

	[Token(Token = "0x40001A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float stage1Time;

	[Token(Token = "0x40001A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float stage2Time;

	[Token(Token = "0x40001A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float stage3Time;

	[Token(Token = "0x40001A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public bool animStart;

	[Token(Token = "0x40001A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
	public bool breakPause;

	[Token(Token = "0x40001AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Shader extendLitShader;

	[Token(Token = "0x40001AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float stagePauseTime;

	[Token(Token = "0x40001AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private float animStartTime;

	[Token(Token = "0x40001AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private bool doonce;

	[Token(Token = "0x40001AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
	private bool stage2DoOnce;

	[Token(Token = "0x40001AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
	private bool stage3DoOnce;

	[Token(Token = "0x40001B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private Vector4 emissionColor;

	[Token(Token = "0x40001B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private Color newCol;

	[Token(Token = "0x600017F")]
	[Address(RVA = "0x2C870D4", Offset = "0x2C870D4", VA = "0x2C870D4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0x2C87178", Offset = "0x2C87178", VA = "0x2C87178")]
	private void Update()
	{
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0x2C877B4", Offset = "0x2C877B4", VA = "0x2C877B4")]
	private void DoStage1()
	{
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0x2C87AB8", Offset = "0x2C87AB8", VA = "0x2C87AB8")]
	private void DoStage2()
	{
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0x2C87F3C", Offset = "0x2C87F3C", VA = "0x2C87F3C")]
	private void DoStage3()
	{
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0x2C881A0", Offset = "0x2C881A0", VA = "0x2C881A0")]
	private void DoStagePause()
	{
	}

	[Token(Token = "0x6000185")]
	[Address(RVA = "0x2C87504", Offset = "0x2C87504", VA = "0x2C87504")]
	private void MatAnimation()
	{
	}

	[Token(Token = "0x6000186")]
	[Address(RVA = "0x2C881E4", Offset = "0x2C881E4", VA = "0x2C881E4")]
	public void ContinueAnimation()
	{
	}

	[Token(Token = "0x6000187")]
	[Address(RVA = "0x2C871B8", Offset = "0x2C871B8", VA = "0x2C871B8")]
	public void StartAnimation()
	{
	}

	[Token(Token = "0x6000188")]
	[Address(RVA = "0x2C881F0", Offset = "0x2C881F0", VA = "0x2C881F0")]
	public HouseWireframeGrowup()
	{
	}
}
[Token(Token = "0x2000059")]
public class FreeCam : MonoBehaviour
{
	[Token(Token = "0x40001B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float movementSpeed;

	[Token(Token = "0x40001B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float fastMovementSpeed;

	[Token(Token = "0x40001B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float freeLookSensitivity;

	[Token(Token = "0x40001B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float zoomSensitivity;

	[Token(Token = "0x40001B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float fastZoomSensitivity;

	[Token(Token = "0x40001B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private bool looking;

	[Token(Token = "0x6000189")]
	[Address(RVA = "0x2C84B88", Offset = "0x2C84B88", VA = "0x2C84B88")]
	private void Update()
	{
	}

	[Token(Token = "0x600018A")]
	[Address(RVA = "0x2C853C0", Offset = "0x2C853C0", VA = "0x2C853C0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600018B")]
	[Address(RVA = "0x2C8536C", Offset = "0x2C8536C", VA = "0x2C8536C")]
	public void StartLooking()
	{
	}

	[Token(Token = "0x600018C")]
	[Address(RVA = "0x2C85398", Offset = "0x2C85398", VA = "0x2C85398")]
	public void StopLooking()
	{
	}

	[Token(Token = "0x600018D")]
	[Address(RVA = "0x2C853E8", Offset = "0x2C853E8", VA = "0x2C853E8")]
	public FreeCam()
	{
	}
}
[Token(Token = "0x200005A")]
public class FreeCamera : MonoBehaviour
{
	[Token(Token = "0x40001B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool enableInputCapture;

	[Token(Token = "0x40001B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool holdRightMouseCapture;

	[Token(Token = "0x40001BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float lookSpeed;

	[Token(Token = "0x40001BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float moveSpeed;

	[Token(Token = "0x40001BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float sprintSpeed;

	[Token(Token = "0x40001BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool m_inputCaptured;

	[Token(Token = "0x40001BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float m_yaw;

	[Token(Token = "0x40001BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float m_pitch;

	[Token(Token = "0x600018E")]
	[Address(RVA = "0x2C85404", Offset = "0x2C85404", VA = "0x2C85404")]
	private void Awake()
	{
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0x2C85410", Offset = "0x2C85410", VA = "0x2C85410")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6000190")]
	[Address(RVA = "0x2C85490", Offset = "0x2C85490", VA = "0x2C85490")]
	private void CaptureInput()
	{
	}

	[Token(Token = "0x6000191")]
	[Address(RVA = "0x2C854EC", Offset = "0x2C854EC", VA = "0x2C854EC")]
	private void ReleaseInput()
	{
	}

	[Token(Token = "0x6000192")]
	[Address(RVA = "0x2C85524", Offset = "0x2C85524", VA = "0x2C85524")]
	private void OnApplicationFocus(bool focus)
	{
	}

	[Token(Token = "0x6000193")]
	[Address(RVA = "0x2C85568", Offset = "0x2C85568", VA = "0x2C85568")]
	private void Update()
	{
	}

	[Token(Token = "0x6000194")]
	[Address(RVA = "0x2C85954", Offset = "0x2C85954", VA = "0x2C85954")]
	public FreeCamera()
	{
	}
}
[Token(Token = "0x200005B")]
public class SuperCamera : MonoBehaviour
{
	[Token(Token = "0x40001C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject pivot;

	[Token(Token = "0x40001C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public KeyCode resetShortcut;

	[Token(Token = "0x40001C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x124E30C", Offset = "0x124E30C")]
	public float rotationSensibility;

	[Token(Token = "0x40001C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool invertRotationX;

	[Token(Token = "0x40001C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	public bool invertRotationY;

	[Token(Token = "0x40001C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x124E328", Offset = "0x124E328")]
	public float translationSensibility;

	[Token(Token = "0x40001C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool invertTranslationX;

	[Token(Token = "0x40001C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	public bool invertTranslationY;

	[Token(Token = "0x40001C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float zoomMax;

	[Token(Token = "0x40001C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float zoomMin;

	[Token(Token = "0x40001CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x124E344", Offset = "0x124E344")]
	public float wheelSensibility;

	[Token(Token = "0x40001CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float delayDoubleClic;

	[Token(Token = "0x40001CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private Vector3 oldCamPos;

	[Token(Token = "0x40001CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Quaternion oldCamRot;

	[Token(Token = "0x40001CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Vector3 oldMousePos;

	[Token(Token = "0x40001CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private float timeDoubleClic;

	[Token(Token = "0x40001D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private bool firstClic;

	[Token(Token = "0x40001D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private Vector3 pivotPos;

	[Token(Token = "0x6000195")]
	[Address(RVA = "0x2B4FC10", Offset = "0x2B4FC10", VA = "0x2B4FC10")]
	private void Start()
	{
	}

	[Token(Token = "0x6000196")]
	[Address(RVA = "0x2B4FCA4", Offset = "0x2B4FCA4", VA = "0x2B4FCA4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000197")]
	[Address(RVA = "0x2B503B0", Offset = "0x2B503B0", VA = "0x2B503B0")]
	public SuperCamera()
	{
	}
}
[Token(Token = "0x200005C")]
public class UIButton_ShowNext : MonoBehaviour
{
	[Token(Token = "0x40001D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject[] GameObjectsList;

	[Token(Token = "0x40001D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int shownGameObjectIndex;

	[Token(Token = "0x6000198")]
	[Address(RVA = "0x2B564D4", Offset = "0x2B564D4", VA = "0x2B564D4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000199")]
	[Address(RVA = "0x2B56548", Offset = "0x2B56548", VA = "0x2B56548")]
	public void SelectNextGameObject()
	{
	}

	[Token(Token = "0x600019A")]
	[Address(RVA = "0x2B56604", Offset = "0x2B56604", VA = "0x2B56604")]
	public void SelectPreviousGameObject()
	{
	}

	[Token(Token = "0x600019B")]
	[Address(RVA = "0x2B56574", Offset = "0x2B56574", VA = "0x2B56574")]
	public void SelectGameObject(int index)
	{
	}

	[Token(Token = "0x600019C")]
	[Address(RVA = "0x2B56630", Offset = "0x2B56630", VA = "0x2B56630")]
	public UIButton_ShowNext()
	{
	}
}
[Token(Token = "0x200005D")]
public class LightbeamSettings : ScriptableObject
{
	[Token(Token = "0x40001D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float RadiusTop;

	[Token(Token = "0x40001D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float RadiusBottom;

	[Token(Token = "0x40001D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float Length;

	[Token(Token = "0x40001D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int Subdivisions;

	[Token(Token = "0x40001D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int SubdivisionsHeight;

	[Token(Token = "0x600019D")]
	[Address(RVA = "0x3F62408", Offset = "0x3F62408", VA = "0x3F62408")]
	public LightbeamSettings()
	{
	}
}
[Token(Token = "0x200005E")]
public class PlanarReflection : MonoBehaviour
{
	[Token(Token = "0x40001D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool VR;

	[Token(Token = "0x40001DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int ReflectionTexResolution;

	[Token(Token = "0x40001DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float Offset;

	[Token(Token = "0x40001DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x124E360", Offset = "0x124E360")]
	public float ReflectionAlpha;

	[Token(Token = "0x40001DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool BlurredReflection;

	[Token(Token = "0x40001DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public LayerMask LayersToReflect;

	[Token(Token = "0x40001DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Camera reflectionCamera;

	[Token(Token = "0x40001E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private RenderTexture reflectionTexture;

	[Token(Token = "0x40001E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private RenderTexture reflectionTextureRight;

	[Token(Token = "0x40001E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static bool isRendering;

	[Token(Token = "0x40001E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Material material;

	[Token(Token = "0x40001E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Camera cam;

	[Token(Token = "0x40001E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static readonly int reflectionTexString;

	[Token(Token = "0x40001E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static readonly int reflectionTexRString;

	[Token(Token = "0x40001E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private static readonly int reflectionAlphaString;

	[Token(Token = "0x40001E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static readonly string blurString;

	[Token(Token = "0x40001E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static readonly string vrString;

	[Token(Token = "0x40001EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Matrix4x4 reflectionMatrix;

	[Token(Token = "0x40001EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private Vector4 reflectionPlane;

	[Token(Token = "0x40001EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private Vector3 posistion;

	[Token(Token = "0x40001ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	private Vector3 normal;

	[Token(Token = "0x40001EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private Vector4 oblique;

	[Token(Token = "0x40001EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private Matrix4x4 worldToCameraMatrix;

	[Token(Token = "0x40001F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private Vector3 clipNormal;

	[Token(Token = "0x40001F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
	private Vector4 clipPlane;

	[Token(Token = "0x40001F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
	private Vector3 oldPosition;

	[Token(Token = "0x40001F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private Vector3 eulerAngles;

	[Token(Token = "0x600019E")]
	[Address(RVA = "0x3F7BC78", Offset = "0x3F7BC78", VA = "0x3F7BC78")]
	public void Start()
	{
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0x3F7C32C", Offset = "0x3F7C32C", VA = "0x3F7C32C")]
	public void OnWillRenderObject()
	{
	}

	[Token(Token = "0x60001A0")]
	[Address(RVA = "0x3F7CF60", Offset = "0x3F7CF60", VA = "0x3F7CF60")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0x3F7CC04", Offset = "0x3F7CC04", VA = "0x3F7CC04")]
	private void RenderObjectCamera(Matrix4x4 projection, bool right)
	{
	}

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0x3F7D104", Offset = "0x3F7D104", VA = "0x3F7D104")]
	private static float sgn(float a)
	{
		return default(float);
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0x3F7D124", Offset = "0x3F7D124", VA = "0x3F7D124")]
	public PlanarReflection()
	{
	}
}
[Token(Token = "0x200005F")]
public class CameraMovement : MonoBehaviour
{
	[Token(Token = "0x60001A5")]
	[Address(RVA = "0x2C7A5D8", Offset = "0x2C7A5D8", VA = "0x2C7A5D8")]
	private void Update()
	{
	}

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0x2C7A6AC", Offset = "0x2C7A6AC", VA = "0x2C7A6AC")]
	public CameraMovement()
	{
	}
}
[Token(Token = "0x2000060")]
[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x124CFA8", Offset = "0x124CFA8")]
public class LetterProfile : ScriptableObject
{
	[Token(Token = "0x40001F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static LetterProfile _instance;

	[Token(Token = "0x40001F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private List<Texture2D> letterTexs;

	[Token(Token = "0x40001F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<Texture2D> remainingLetters;

	[Token(Token = "0x1700000F")]
	public static LetterProfile Instance
	{
		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x3F6124C", Offset = "0x3F6124C", VA = "0x3F6124C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0x3F61368", Offset = "0x3F61368", VA = "0x3F61368")]
	public Texture2D GetRandomTex()
	{
		return null;
	}

	[Token(Token = "0x60001A9")]
	[Address(RVA = "0x3F614A8", Offset = "0x3F614A8", VA = "0x3F614A8")]
	public LetterProfile()
	{
	}
}
[Token(Token = "0x2000061")]
public class LoveLetter : MonoBehaviour
{
	[Token(Token = "0x2000062")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124CFEC", Offset = "0x124CFEC")]
	private sealed class <IOpenLetter>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LoveLetter <>4__this;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <speed>5__2;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <alpha>5__3;

		[Token(Token = "0x17000010")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001B3")]
			[Address(RVA = "0x310DA94", Offset = "0x310DA94", VA = "0x310DA94", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000011")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001B5")]
			[Address(RVA = "0x310DADC", Offset = "0x310DADC", VA = "0x310DADC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x310D844", Offset = "0x310D844", VA = "0x310D844")]
		[DebuggerHidden]
		public <IOpenLetter>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x310D870", Offset = "0x310D870", VA = "0x310D870", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x310D874", Offset = "0x310D874", VA = "0x310D874", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x310DA9C", Offset = "0x310DA9C", VA = "0x310DA9C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000063")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124CFFC", Offset = "0x124CFFC")]
	private sealed class <ICloseLetter>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LoveLetter <>4__this;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <speed>5__2;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <alpha>5__3;

		[Token(Token = "0x17000012")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0x310D7F4", Offset = "0x310D7F4", VA = "0x310D7F4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000013")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001BB")]
			[Address(RVA = "0x310D83C", Offset = "0x310D83C", VA = "0x310D83C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x310D660", Offset = "0x310D660", VA = "0x310D660")]
		[DebuggerHidden]
		public <ICloseLetter>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x310D68C", Offset = "0x310D68C", VA = "0x310D68C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x310D690", Offset = "0x310D690", VA = "0x310D690", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x310D7FC", Offset = "0x310D7FC", VA = "0x310D7FC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40001F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x124E388", Offset = "0x124E388")]
	public float fadeTime;

	[Token(Token = "0x40001F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Renderer letterRenderer;

	[Token(Token = "0x40001F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Material letterMat;

	[Token(Token = "0x40001FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool isShowing;

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0x3F63D24", Offset = "0x3F63D24", VA = "0x3F63D24")]
	private void Start()
	{
	}

	[Token(Token = "0x60001AB")]
	[Address(RVA = "0x3F63D60", Offset = "0x3F63D60", VA = "0x3F63D60")]
	public void ShowRandomLetter()
	{
	}

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0x3F63E1C", Offset = "0x3F63E1C", VA = "0x3F63E1C")]
	public void CloseLetter()
	{
	}

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0x3F63DA4", Offset = "0x3F63DA4", VA = "0x3F63DA4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1250308", Offset = "0x1250308")]
	private IEnumerator IOpenLetter()
	{
		return null;
	}

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0x3F63E6C", Offset = "0x3F63E6C", VA = "0x3F63E6C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1250368", Offset = "0x1250368")]
	private IEnumerator ICloseLetter()
	{
		return null;
	}

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0x3F63EE4", Offset = "0x3F63EE4", VA = "0x3F63EE4")]
	public LoveLetter()
	{
	}
}
[Token(Token = "0x2000064")]
public class SetRotate : MonoBehaviour
{
	[Token(Token = "0x4000205")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform centerTarget;

	[Token(Token = "0x4000206")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform beginTarget;

	[Token(Token = "0x4000207")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform endTarget;

	[Token(Token = "0x4000208")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<Transform> words;

	[Token(Token = "0x4000209")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Vector2 scaleRange;

	[Token(Token = "0x400020A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Vector2 radiusRange;

	[Token(Token = "0x400020B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Vector2 angleEmptyRange;

	[Token(Token = "0x60001BC")]
	[Address(RVA = "0x2B4BB3C", Offset = "0x2B4BB3C", VA = "0x2B4BB3C")]
	[AttributeAttribute(Name = "ButtonAttribute", RVA = "0x1250468", Offset = "0x1250468")]
	public void Look()
	{
	}

	[Token(Token = "0x60001BD")]
	[Address(RVA = "0x2B4BCD0", Offset = "0x2B4BCD0", VA = "0x2B4BCD0")]
	[AttributeAttribute(Name = "ButtonAttribute", RVA = "0x1250478", Offset = "0x1250478")]
	public void SetFalseActive()
	{
	}

	[Token(Token = "0x60001BE")]
	[Address(RVA = "0x2B4BE8C", Offset = "0x2B4BE8C", VA = "0x2B4BE8C")]
	[AttributeAttribute(Name = "ButtonAttribute", RVA = "0x1250488", Offset = "0x1250488")]
	public void SetScale()
	{
	}

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0x2B4BFF8", Offset = "0x2B4BFF8", VA = "0x2B4BFF8")]
	[AttributeAttribute(Name = "ButtonAttribute", RVA = "0x1250498", Offset = "0x1250498")]
	public void SetPosi()
	{
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0x2B4C30C", Offset = "0x2B4C30C", VA = "0x2B4C30C")]
	[AttributeAttribute(Name = "ButtonAttribute", RVA = "0x12504A8", Offset = "0x12504A8")]
	public void TotalWork()
	{
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0x2B4C338", Offset = "0x2B4C338", VA = "0x2B4C338")]
	public SetRotate()
	{
	}
}
[Token(Token = "0x2000065")]
public class TestLoveLetter : MonoBehaviour
{
	[Token(Token = "0x400020C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public LoveLetter loveLetter;

	[Token(Token = "0x60001C2")]
	[Address(RVA = "0x2B5392C", Offset = "0x2B5392C", VA = "0x2B5392C")]
	private void Update()
	{
	}

	[Token(Token = "0x60001C3")]
	[Address(RVA = "0x2B539F4", Offset = "0x2B539F4", VA = "0x2B539F4")]
	public TestLoveLetter()
	{
	}
}
[Token(Token = "0x2000066")]
public class DemoSceneControler : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000067")]
	public class DemoScene
	{
		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject _objSceneBaseObject;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Color _colDaytimeCameraColour;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Color _colNightimeCameraColour;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool _bEnableFlairsAtNight;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float _fDaySunBrightness;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float _fNightSunBrightness;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool _bEnableDescription;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string _strSceneDescription;

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x310C2B8", Offset = "0x310C2B8", VA = "0x310C2B8")]
		public DemoScene()
		{
		}
	}

	[Token(Token = "0x400020D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public DemoScene[] _dscDemoScenes;

	[Token(Token = "0x400020E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int _iSelectedScene;

	[Token(Token = "0x400020F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float _fSettingChangeRate;

	[Token(Token = "0x4000210")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool _bIsDay;

	[Token(Token = "0x4000211")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject _objFlareMaster;

	[Token(Token = "0x4000212")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Light _lhtSun;

	[Token(Token = "0x4000213")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Camera _camMainCam;

	[Token(Token = "0x4000214")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Text _txtDayNightText;

	[Token(Token = "0x4000215")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Text _txtDescriptionText;

	[Token(Token = "0x4000216")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject _objDescriptionBox;

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0x2C7FB70", Offset = "0x2C7FB70", VA = "0x2C7FB70")]
	public void UpdateFlareState()
	{
	}

	[Token(Token = "0x60001C5")]
	[Address(RVA = "0x2C7FC54", Offset = "0x2C7FC54", VA = "0x2C7FC54")]
	public void UpdateSunBrightness()
	{
	}

	[Token(Token = "0x60001C6")]
	[Address(RVA = "0x2C7FD18", Offset = "0x2C7FD18", VA = "0x2C7FD18")]
	public void FadeCamera()
	{
	}

	[Token(Token = "0x60001C7")]
	[Address(RVA = "0x2C7FE40", Offset = "0x2C7FE40", VA = "0x2C7FE40")]
	public void UpdateSceneEnabledState()
	{
	}

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0x2C7FECC", Offset = "0x2C7FECC", VA = "0x2C7FECC")]
	public void UpdateDayNightText()
	{
	}

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0x2C7FF50", Offset = "0x2C7FF50", VA = "0x2C7FF50")]
	public void UpdateDescriptionText()
	{
	}

	[Token(Token = "0x60001CA")]
	[Address(RVA = "0x2C7FFF0", Offset = "0x2C7FFF0", VA = "0x2C7FFF0")]
	public void NextScene()
	{
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0x2C80020", Offset = "0x2C80020", VA = "0x2C80020")]
	public void LastScene()
	{
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0x2C80058", Offset = "0x2C80058", VA = "0x2C80058")]
	public void TogleDayNight()
	{
	}

	[Token(Token = "0x60001CD")]
	[Address(RVA = "0x2C80068", Offset = "0x2C80068", VA = "0x2C80068")]
	public void ChackForInputs()
	{
	}

	[Token(Token = "0x60001CE")]
	[Address(RVA = "0x2C80108", Offset = "0x2C80108", VA = "0x2C80108")]
	private void Update()
	{
	}

	[Token(Token = "0x60001CF")]
	[Address(RVA = "0x2C80154", Offset = "0x2C80154", VA = "0x2C80154")]
	public DemoSceneControler()
	{
	}
}
[Token(Token = "0x2000068")]
public class FlareControler : MonoBehaviour
{
	[Token(Token = "0x2000069")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124D00C", Offset = "0x124D00C")]
	private sealed class <DeathCoolDown>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FlareControler <>4__this;

		[Token(Token = "0x17000014")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001DD")]
			[Address(RVA = "0x310CE74", Offset = "0x310CE74", VA = "0x310CE74", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000015")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001DF")]
			[Address(RVA = "0x310CEBC", Offset = "0x310CEBC", VA = "0x310CEBC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x310CCA4", Offset = "0x310CCA4", VA = "0x310CCA4")]
		[DebuggerHidden]
		public <DeathCoolDown>d__23(int <>1__state)
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x310CCD0", Offset = "0x310CCD0", VA = "0x310CCD0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x310CCD4", Offset = "0x310CCD4", VA = "0x310CCD4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x310CE7C", Offset = "0x310CE7C", VA = "0x310CE7C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400021F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ParticleSystem _parFlareEmitter;

	[Token(Token = "0x4000220")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Light _lhtFlareLight;

	[Token(Token = "0x4000221")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float _fMaxLifeTime;

	[Token(Token = "0x4000222")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float _fMinLifeTime;

	[Token(Token = "0x4000223")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float _fSetLifeTime;

	[Token(Token = "0x4000224")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float _fLifeRemaining;

	[Token(Token = "0x4000225")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float _fLightBrightness;

	[Token(Token = "0x4000226")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public AnimationCurve _amcBrightnessOverLife;

	[Token(Token = "0x4000227")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Color[] _colPossibleColours;

	[Token(Token = "0x4000228")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Color _colSetColour;

	[Token(Token = "0x4000229")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public AnimationCurve _amcEmitColourBrightnessOverLife;

	[Token(Token = "0x400022A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public float _fFallRate;

	[Token(Token = "0x400022B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public AnimationCurve _amcFallRateOverLife;

	[Token(Token = "0x400022C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public float _fDeathCoolDown;

	[Token(Token = "0x400022D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public bool _bDestroying;

	[Token(Token = "0x400022E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public AnimationCurve _amcParticleAlpha;

	[Token(Token = "0x60001D1")]
	[Address(RVA = "0x2C820A4", Offset = "0x2C820A4", VA = "0x2C820A4")]
	private void Start()
	{
	}

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0x2C8212C", Offset = "0x2C8212C", VA = "0x2C8212C")]
	private void Update()
	{
	}

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0x2C820A8", Offset = "0x2C820A8", VA = "0x2C820A8")]
	public void Setup()
	{
	}

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0x2C82370", Offset = "0x2C82370", VA = "0x2C82370")]
	public void UpdatePosittion()
	{
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0x2C82434", Offset = "0x2C82434", VA = "0x2C82434")]
	public float GetPercentThroughLife()
	{
		return default(float);
	}

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0x2C8223C", Offset = "0x2C8223C", VA = "0x2C8223C")]
	public void UpdateParticleColor()
	{
	}

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0x2C82314", Offset = "0x2C82314", VA = "0x2C82314")]
	public void UpdateLightBrightness()
	{
	}

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0x2C821C4", Offset = "0x2C821C4", VA = "0x2C821C4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x12504B8", Offset = "0x12504B8")]
	public IEnumerator DeathCoolDown()
	{
		return null;
	}

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0x2C82448", Offset = "0x2C82448", VA = "0x2C82448")]
	public FlareControler()
	{
	}
}
[Token(Token = "0x200006A")]
public class FlareSpawner : MonoBehaviour
{
	[Token(Token = "0x4000232")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject _objFlare;

	[Token(Token = "0x4000233")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform[] _trnFlareSpawnPoints;

	[Token(Token = "0x4000234")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float _fMinTimeBetweenFlareSpawns;

	[Token(Token = "0x4000235")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float _fMaxTimeBetweenFlareSpawns;

	[Token(Token = "0x4000236")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float _fTimeUntilNextSpawn;

	[Token(Token = "0x4000237")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float _fRandomSpawnVariation;

	[Token(Token = "0x60001E0")]
	[Address(RVA = "0x2C82450", Offset = "0x2C82450", VA = "0x2C82450")]
	private void Update()
	{
	}

	[Token(Token = "0x60001E1")]
	[Address(RVA = "0x2C824B8", Offset = "0x2C824B8", VA = "0x2C824B8")]
	public void SpawnFlare()
	{
	}

	[Token(Token = "0x60001E2")]
	[Address(RVA = "0x2C8262C", Offset = "0x2C8262C", VA = "0x2C8262C")]
	public FlareSpawner()
	{
	}
}
[Token(Token = "0x200006B")]
public class CannonBallManager : MonoBehaviour
{
	[Token(Token = "0x4000238")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform _objExplosion;

	[Token(Token = "0x60001E3")]
	[Address(RVA = "0x2C7AC6C", Offset = "0x2C7AC6C", VA = "0x2C7AC6C")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x60001E4")]
	[Address(RVA = "0x2C7AD2C", Offset = "0x2C7AD2C", VA = "0x2C7AD2C")]
	public CannonBallManager()
	{
	}
}
[Token(Token = "0x200006C")]
public class CannonManager : MonoBehaviour
{
	[Token(Token = "0x4000239")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform _trnFireFromPoint;

	[Token(Token = "0x400023A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x124E3A0", Offset = "0x124E3A0")]
	public float _fAimVariation;

	[Token(Token = "0x400023B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float _fFireSpeed;

	[Token(Token = "0x400023C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float _fMinTimeBetweenShots;

	[Token(Token = "0x400023D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float _fMaxTimeBetweenShots;

	[Token(Token = "0x400023E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float _fTimeUntillNextShot;

	[Token(Token = "0x400023F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Rigidbody _rgbCannonBall;

	[Token(Token = "0x4000240")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ParticleSystem _psyCannonFireEffect;

	[Token(Token = "0x4000241")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public int _iNumberOfParticlesToSpawn;

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0x2C7AD34", Offset = "0x2C7AD34", VA = "0x2C7AD34")]
	private void Start()
	{
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0x2C7AD60", Offset = "0x2C7AD60", VA = "0x2C7AD60")]
	private void Update()
	{
	}

	[Token(Token = "0x60001E7")]
	[Address(RVA = "0x2C7ADB8", Offset = "0x2C7ADB8", VA = "0x2C7ADB8")]
	public void FireCannon()
	{
	}

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0x2C7AF68", Offset = "0x2C7AF68", VA = "0x2C7AF68")]
	public CannonManager()
	{
	}
}
[Token(Token = "0x200006D")]
public class DigitalBoxDamager : MonoBehaviour
{
	[Token(Token = "0x60001E9")]
	[Address(RVA = "0x2C803C0", Offset = "0x2C803C0", VA = "0x2C803C0")]
	public void OnCollisionEnter(Collision colCollision)
	{
	}

	[Token(Token = "0x60001EA")]
	[Address(RVA = "0x2C804E0", Offset = "0x2C804E0", VA = "0x2C804E0")]
	public DigitalBoxDamager()
	{
	}
}
[Token(Token = "0x200006E")]
public class DigitalBoxParticleSubEmitter : MonoBehaviour
{
	[Token(Token = "0x200006F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124D01C", Offset = "0x124D01C")]
	private sealed class <TriggerParticleSpawn>d__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DigitalBoxParticleSubEmitter <>4__this;

		[Token(Token = "0x17000016")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001F7")]
			[Address(RVA = "0x310C960", Offset = "0x310C960", VA = "0x310C960", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000017")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001F9")]
			[Address(RVA = "0x310C9A8", Offset = "0x310C9A8", VA = "0x310C9A8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x310C7FC", Offset = "0x310C7FC", VA = "0x310C7FC")]
		[DebuggerHidden]
		public <TriggerParticleSpawn>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x310C828", Offset = "0x310C828", VA = "0x310C828", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x310C82C", Offset = "0x310C82C", VA = "0x310C82C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x310C968", Offset = "0x310C968", VA = "0x310C968", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000070")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124D02C", Offset = "0x124D02C")]
	private sealed class <RespawnBox>d__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DigitalBoxParticleSubEmitter <>4__this;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <fCurrentRespawnTime>5__2;

		[Token(Token = "0x17000018")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001FD")]
			[Address(RVA = "0x310C7AC", Offset = "0x310C7AC", VA = "0x310C7AC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000019")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001FF")]
			[Address(RVA = "0x310C7F4", Offset = "0x310C7F4", VA = "0x310C7F4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x310C538", Offset = "0x310C538", VA = "0x310C538")]
		[DebuggerHidden]
		public <RespawnBox>d__21(int <>1__state)
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x310C564", Offset = "0x310C564", VA = "0x310C564", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x310C568", Offset = "0x310C568", VA = "0x310C568", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x310C7B4", Offset = "0x310C7B4", VA = "0x310C7B4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000071")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124D03C", Offset = "0x124D03C")]
	private sealed class <BlowUpBox>d__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DigitalBoxParticleSubEmitter <>4__this;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <fcurrentDestroyTime>5__2;

		[Token(Token = "0x1700001A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000203")]
			[Address(RVA = "0x310C4E8", Offset = "0x310C4E8", VA = "0x310C4E8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000205")]
			[Address(RVA = "0x310C530", Offset = "0x310C530", VA = "0x310C530", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x310C2C0", Offset = "0x310C2C0", VA = "0x310C2C0")]
		[DebuggerHidden]
		public <BlowUpBox>d__22(int <>1__state)
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x310C2EC", Offset = "0x310C2EC", VA = "0x310C2EC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x310C2F0", Offset = "0x310C2F0", VA = "0x310C2F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x310C4F0", Offset = "0x310C4F0", VA = "0x310C4F0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000072")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124D04C", Offset = "0x124D04C")]
	private sealed class <WaitForRespawn>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DigitalBoxParticleSubEmitter <>4__this;

		[Token(Token = "0x1700001C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000209")]
			[Address(RVA = "0x310CAE0", Offset = "0x310CAE0", VA = "0x310CAE0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600020B")]
			[Address(RVA = "0x310CB28", Offset = "0x310CB28", VA = "0x310CB28", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x310C9B0", Offset = "0x310C9B0", VA = "0x310C9B0")]
		[DebuggerHidden]
		public <WaitForRespawn>d__23(int <>1__state)
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x310C9DC", Offset = "0x310C9DC", VA = "0x310C9DC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x310C9E0", Offset = "0x310C9E0", VA = "0x310C9E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x310CAE8", Offset = "0x310CAE8", VA = "0x310CAE8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000242")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject _objDigitalBox;

	[Token(Token = "0x4000243")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Material _matCubeMaterial;

	[Token(Token = "0x4000244")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Color _colActionEmissive;

	[Token(Token = "0x4000245")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Collider _colBulletColider;

	[Token(Token = "0x4000246")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	protected Vector3 _vecScale;

	[Token(Token = "0x4000247")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float _fDestroyTime;

	[Token(Token = "0x4000248")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float _fRespawnTime;

	[Token(Token = "0x4000249")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float _fSpawnInLerpTime;

	[Token(Token = "0x400024A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public ParticleSystem _psyBoxParticelSystem;

	[Token(Token = "0x400024B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Transform _trnSpawnBox;

	[Token(Token = "0x400024C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public float _fColissionRadious;

	[Token(Token = "0x400024D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public float _fParticleSize;

	[Token(Token = "0x400024E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float _fMinSizeToSpawn;

	[Token(Token = "0x400024F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public Vector2 _vecLifetime;

	[Token(Token = "0x4000250")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public Vector2 _vecStartRotation;

	[Token(Token = "0x4000251")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public Color _colColour;

	[Token(Token = "0x4000252")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public Vector3 _vecSpawnVolume;

	[Token(Token = "0x4000253")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Vector3 _vecSpawnDevisionsPerAxis;

	[Token(Token = "0x4000254")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	public float _fTimeBetweenSpawns;

	[Token(Token = "0x60001EB")]
	[Address(RVA = "0x2C804E8", Offset = "0x2C804E8", VA = "0x2C804E8")]
	public void SpawnInitalParticles()
	{
	}

	[Token(Token = "0x60001EC")]
	[Address(RVA = "0x2C807D8", Offset = "0x2C807D8", VA = "0x2C807D8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1250568", Offset = "0x1250568")]
	public IEnumerator TriggerParticleSpawn()
	{
		return null;
	}

	[Token(Token = "0x60001ED")]
	[Address(RVA = "0x2C80850", Offset = "0x2C80850", VA = "0x2C80850")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x12505C8", Offset = "0x12505C8")]
	public IEnumerator RespawnBox()
	{
		return null;
	}

	[Token(Token = "0x60001EE")]
	[Address(RVA = "0x2C808C8", Offset = "0x2C808C8", VA = "0x2C808C8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1250628", Offset = "0x1250628")]
	public IEnumerator BlowUpBox()
	{
		return null;
	}

	[Token(Token = "0x60001EF")]
	[Address(RVA = "0x2C80940", Offset = "0x2C80940", VA = "0x2C80940")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1250688", Offset = "0x1250688")]
	public IEnumerator WaitForRespawn()
	{
		return null;
	}

	[Token(Token = "0x60001F0")]
	[Address(RVA = "0x2C809B8", Offset = "0x2C809B8", VA = "0x2C809B8")]
	private void Start()
	{
	}

	[Token(Token = "0x60001F1")]
	[Address(RVA = "0x2C80A10", Offset = "0x2C80A10", VA = "0x2C80A10")]
	private void Update()
	{
	}

	[Token(Token = "0x60001F2")]
	[Address(RVA = "0x2C804B4", Offset = "0x2C804B4", VA = "0x2C804B4")]
	public void DestroyBox()
	{
	}

	[Token(Token = "0x60001F3")]
	[Address(RVA = "0x2C80A14", Offset = "0x2C80A14", VA = "0x2C80A14")]
	public DigitalBoxParticleSubEmitter()
	{
	}
}
[Token(Token = "0x2000073")]
public class ExplosionLightManager : MonoBehaviour
{
	[Token(Token = "0x2000074")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124D05C", Offset = "0x124D05C")]
	private sealed class <ManageLight>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ExplosionLightManager <>4__this;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <fLifeRemaining>5__2;

		[Token(Token = "0x1700001E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000213")]
			[Address(RVA = "0x310CC54", Offset = "0x310CC54", VA = "0x310CC54", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000215")]
			[Address(RVA = "0x310CC9C", Offset = "0x310CC9C", VA = "0x310CC9C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x310CB30", Offset = "0x310CB30", VA = "0x310CB30")]
		[DebuggerHidden]
		public <ManageLight>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x310CB5C", Offset = "0x310CB5C", VA = "0x310CB5C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x310CB60", Offset = "0x310CB60", VA = "0x310CB60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x310CC5C", Offset = "0x310CC5C", VA = "0x310CC5C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000263")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Light _lhtLight;

	[Token(Token = "0x4000264")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float _fBrightness;

	[Token(Token = "0x4000265")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float _fLife;

	[Token(Token = "0x4000266")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AnimationCurve _amcLightLifeBrightness;

	[Token(Token = "0x600020C")]
	[Address(RVA = "0x2C814B0", Offset = "0x2C814B0", VA = "0x2C814B0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1250828", Offset = "0x1250828")]
	public IEnumerator ManageLight()
	{
		return null;
	}

	[Token(Token = "0x600020D")]
	[Address(RVA = "0x2C81528", Offset = "0x2C81528", VA = "0x2C81528")]
	private void Start()
	{
	}

	[Token(Token = "0x600020E")]
	[Address(RVA = "0x2C81554", Offset = "0x2C81554", VA = "0x2C81554")]
	private void Update()
	{
	}

	[Token(Token = "0x600020F")]
	[Address(RVA = "0x2C81558", Offset = "0x2C81558", VA = "0x2C81558")]
	public ExplosionLightManager()
	{
	}
}
[Token(Token = "0x2000075")]
public class ExplosionManager : MonoBehaviour
{
	[Token(Token = "0x400026B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool _bFireOnce;

	[Token(Token = "0x400026C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool _bDestroyAfterTime;

	[Token(Token = "0x400026D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float _fLifetime;

	[Token(Token = "0x400026E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float _fMinFrequency;

	[Token(Token = "0x400026F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float _fMaxFrequency;

	[Token(Token = "0x4000270")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float _fTimeUntillNext;

	[Token(Token = "0x4000271")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float _fWindZoneActiveTime;

	[Token(Token = "0x4000272")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float _fCurrentActiveTime;

	[Token(Token = "0x4000273")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float _fWindZoneMaxForce;

	[Token(Token = "0x4000274")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public AnimationCurve _amcWindForceOverTime;

	[Token(Token = "0x4000275")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public WindZone _wznExplosionWindZone;

	[Token(Token = "0x4000276")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ParticleSystem _prsParticleSystem;

	[Token(Token = "0x4000277")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public int _iParticlesToEmmit;

	[Token(Token = "0x6000216")]
	[Address(RVA = "0x2C81560", Offset = "0x2C81560", VA = "0x2C81560")]
	public void UpdateWindZone()
	{
	}

	[Token(Token = "0x6000217")]
	[Address(RVA = "0x2C81630", Offset = "0x2C81630", VA = "0x2C81630")]
	public void SpawnParticleEffect()
	{
	}

	[Token(Token = "0x6000218")]
	[Address(RVA = "0x2C81654", Offset = "0x2C81654", VA = "0x2C81654")]
	public void TriggerExplosion()
	{
	}

	[Token(Token = "0x6000219")]
	[Address(RVA = "0x2C816AC", Offset = "0x2C816AC", VA = "0x2C816AC")]
	private void Start()
	{
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0x2C816C0", Offset = "0x2C816C0", VA = "0x2C816C0")]
	private void Update()
	{
	}

	[Token(Token = "0x600021B")]
	[Address(RVA = "0x2C817A8", Offset = "0x2C817A8", VA = "0x2C817A8")]
	public ExplosionManager()
	{
	}
}
[Token(Token = "0x2000076")]
public class LightningLightAnimator : MonoBehaviour
{
	[Token(Token = "0x2000077")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124D06C", Offset = "0x124D06C")]
	private sealed class <Flash>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LightningLightAnimator <>4__this;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <flashLength>5__2;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <fFlashBrightness>5__3;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <flerpTimeLeft>5__4;

		[Token(Token = "0x17000020")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000224")]
			[Address(RVA = "0x310D290", Offset = "0x310D290", VA = "0x310D290", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000021")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000226")]
			[Address(RVA = "0x310D2D8", Offset = "0x310D2D8", VA = "0x310D2D8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x310D034", Offset = "0x310D034", VA = "0x310D034")]
		[DebuggerHidden]
		public <Flash>d__13(int <>1__state)
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x310D060", Offset = "0x310D060", VA = "0x310D060", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x310D064", Offset = "0x310D064", VA = "0x310D064", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x310D298", Offset = "0x310D298", VA = "0x310D298", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000078")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124D07C", Offset = "0x124D07C")]
	private sealed class <FlashSequence>d__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LightningLightAnimator <>4__this;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <iFlashesInSequence>5__2;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int <i>5__3;

		[Token(Token = "0x17000022")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600022A")]
			[Address(RVA = "0x310D450", Offset = "0x310D450", VA = "0x310D450", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000023")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600022C")]
			[Address(RVA = "0x310D498", Offset = "0x310D498", VA = "0x310D498", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x310D2E0", Offset = "0x310D2E0", VA = "0x310D2E0")]
		[DebuggerHidden]
		public <FlashSequence>d__14(int <>1__state)
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x310D30C", Offset = "0x310D30C", VA = "0x310D30C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x310D310", Offset = "0x310D310", VA = "0x310D310", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x310D458", Offset = "0x310D458", VA = "0x310D458", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000079")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124D08C", Offset = "0x124D08C")]
	private sealed class <LightningManager>d__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LightningLightAnimator <>4__this;

		[Token(Token = "0x17000024")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000230")]
			[Address(RVA = "0x310D610", Offset = "0x310D610", VA = "0x310D610", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000025")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000232")]
			[Address(RVA = "0x310D658", Offset = "0x310D658", VA = "0x310D658", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x310D4A0", Offset = "0x310D4A0", VA = "0x310D4A0")]
		[DebuggerHidden]
		public <LightningManager>d__15(int <>1__state)
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x310D4CC", Offset = "0x310D4CC", VA = "0x310D4CC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x310D4D0", Offset = "0x310D4D0", VA = "0x310D4D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x310D618", Offset = "0x310D618", VA = "0x310D618", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000278")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Light _lhtLightingLight;

	[Token(Token = "0x4000279")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float _fMaxFlashLight;

	[Token(Token = "0x400027A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float _fMinFlashLight;

	[Token(Token = "0x400027B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float _fNonFlashLight;

	[Token(Token = "0x400027C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int _iMaxFlashes;

	[Token(Token = "0x400027D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int _iMinFlashes;

	[Token(Token = "0x400027E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float _fMinTimeBetweenLighting;

	[Token(Token = "0x400027F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float _fMaxTimeBetweenLightning;

	[Token(Token = "0x4000280")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float _fMinTimeBetweenLightningFlashes;

	[Token(Token = "0x4000281")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float _fMaxTimeBetweenLightningFlashes;

	[Token(Token = "0x4000282")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float _fMinFlashLength;

	[Token(Token = "0x4000283")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float _fMaxFlashLength;

	[Token(Token = "0x4000284")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float _fFlashLerpTime;

	[Token(Token = "0x600021C")]
	[Address(RVA = "0x3F62E1C", Offset = "0x3F62E1C", VA = "0x3F62E1C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x12508D8", Offset = "0x12508D8")]
	public IEnumerator Flash()
	{
		return null;
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0x3F62E94", Offset = "0x3F62E94", VA = "0x3F62E94")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1250938", Offset = "0x1250938")]
	public IEnumerator FlashSequence()
	{
		return null;
	}

	[Token(Token = "0x600021E")]
	[Address(RVA = "0x3F62F0C", Offset = "0x3F62F0C", VA = "0x3F62F0C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1250998", Offset = "0x1250998")]
	public IEnumerator LightningManager()
	{
		return null;
	}

	[Token(Token = "0x600021F")]
	[Address(RVA = "0x3F62F84", Offset = "0x3F62F84", VA = "0x3F62F84")]
	private void Start()
	{
	}

	[Token(Token = "0x6000220")]
	[Address(RVA = "0x3F62FB0", Offset = "0x3F62FB0", VA = "0x3F62FB0")]
	public LightningLightAnimator()
	{
	}
}
[Token(Token = "0x200007A")]
public class ParticleEarlyKill : MonoBehaviour
{
	[Token(Token = "0x4000293")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ParticleSystem.Particle[] _parParticleList;

	[Token(Token = "0x4000294")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AnimationCurve _amcParticleLifeTime;

	[Token(Token = "0x4000295")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float _fParticleFadeOutRate;

	[Token(Token = "0x4000296")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected ParticleSystem _parTargetParticleSystem;

	[Token(Token = "0x17000026")]
	protected ParticleSystem TargetParticleSystem
	{
		[Token(Token = "0x6000233")]
		[Address(RVA = "0x3F6FC30", Offset = "0x3F6FC30", VA = "0x3F6FC30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000234")]
	[Address(RVA = "0x3F6FCE4", Offset = "0x3F6FCE4", VA = "0x3F6FCE4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000235")]
	[Address(RVA = "0x3F6FFD8", Offset = "0x3F6FFD8", VA = "0x3F6FFD8")]
	public ParticleEarlyKill()
	{
	}
}
[Token(Token = "0x200007B")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x124D09C", Offset = "0x124D09C")]
public class MouseLook : MonoBehaviour
{
	[Token(Token = "0x200007C")]
	public enum RotationAxes
	{
		[Token(Token = "0x40002A0")]
		MouseXAndY,
		[Token(Token = "0x40002A1")]
		MouseX,
		[Token(Token = "0x40002A2")]
		MouseY
	}

	[Token(Token = "0x4000297")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public RotationAxes axes;

	[Token(Token = "0x4000298")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float sensitivityX;

	[Token(Token = "0x4000299")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float sensitivityY;

	[Token(Token = "0x400029A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float minimumX;

	[Token(Token = "0x400029B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float maximumX;

	[Token(Token = "0x400029C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float minimumY;

	[Token(Token = "0x400029D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float maximumY;

	[Token(Token = "0x400029E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float rotationY;

	[Token(Token = "0x6000236")]
	[Address(RVA = "0x3F66488", Offset = "0x3F66488", VA = "0x3F66488")]
	private void Update()
	{
	}

	[Token(Token = "0x6000237")]
	[Address(RVA = "0x3F66660", Offset = "0x3F66660", VA = "0x3F66660")]
	private void Start()
	{
	}

	[Token(Token = "0x6000238")]
	[Address(RVA = "0x3F66728", Offset = "0x3F66728", VA = "0x3F66728")]
	public MouseLook()
	{
	}
}
[Token(Token = "0x200007D")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x124D0D4", Offset = "0x124D0D4")]
public class BlurEffect : MonoBehaviour
{
	[Token(Token = "0x40002A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int iterations;

	[Token(Token = "0x40002A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float blurSpread;

	[Token(Token = "0x40002A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Shader blurShader;

	[Token(Token = "0x40002A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Material m_Material;

	[Token(Token = "0x17000027")]
	protected Material material
	{
		[Token(Token = "0x6000239")]
		[Address(RVA = "0x2C795A4", Offset = "0x2C795A4", VA = "0x2C795A4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600023A")]
	[Address(RVA = "0x2C796F8", Offset = "0x2C796F8", VA = "0x2C796F8")]
	protected void OnDisable()
	{
	}

	[Token(Token = "0x600023B")]
	[Address(RVA = "0x2C797FC", Offset = "0x2C797FC", VA = "0x2C797FC")]
	protected void Start()
	{
	}

	[Token(Token = "0x600023C")]
	[Address(RVA = "0x2C798B8", Offset = "0x2C798B8", VA = "0x2C798B8")]
	public void FourTapCone(RenderTexture source, RenderTexture dest, int iteration)
	{
	}

	[Token(Token = "0x600023D")]
	[Address(RVA = "0x2C799DC", Offset = "0x2C799DC", VA = "0x2C799DC")]
	private void DownSample4x(RenderTexture source, RenderTexture dest)
	{
	}

	[Token(Token = "0x600023E")]
	[Address(RVA = "0x2C79AEC", Offset = "0x2C79AEC", VA = "0x2C79AEC")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x600023F")]
	[Address(RVA = "0x2C79CD0", Offset = "0x2C79CD0", VA = "0x2C79CD0")]
	public BlurEffect()
	{
	}
}
[Token(Token = "0x200007E")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x124D120", Offset = "0x124D120")]
public class ColorCorrectionEffect : ImageEffectBase
{
	[Token(Token = "0x40002A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Texture textureRamp;

	[Token(Token = "0x6000241")]
	[Address(RVA = "0x2C7B080", Offset = "0x2C7B080", VA = "0x2C7B080")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000242")]
	[Address(RVA = "0x2C7B148", Offset = "0x2C7B148", VA = "0x2C7B148")]
	public ColorCorrectionEffect()
	{
	}
}
[Token(Token = "0x200007F")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x124D16C", Offset = "0x124D16C")]
[ExecuteInEditMode]
public class ContrastStretchEffect : MonoBehaviour
{
	[Token(Token = "0x40002A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float adaptationSpeed;

	[Token(Token = "0x40002A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float limitMinimum;

	[Token(Token = "0x40002AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float limitMaximum;

	[Token(Token = "0x40002AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private RenderTexture[] adaptRenderTex;

	[Token(Token = "0x40002AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int curAdaptIndex;

	[Token(Token = "0x40002AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Shader shaderLum;

	[Token(Token = "0x40002AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Material m_materialLum;

	[Token(Token = "0x40002AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Shader shaderReduce;

	[Token(Token = "0x40002B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Material m_materialReduce;

	[Token(Token = "0x40002B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Shader shaderAdapt;

	[Token(Token = "0x40002B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Material m_materialAdapt;

	[Token(Token = "0x40002B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Shader shaderApply;

	[Token(Token = "0x40002B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Material m_materialApply;

	[Token(Token = "0x17000028")]
	protected Material materialLum
	{
		[Token(Token = "0x6000243")]
		[Address(RVA = "0x2C7BA50", Offset = "0x2C7BA50", VA = "0x2C7BA50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000029")]
	protected Material materialReduce
	{
		[Token(Token = "0x6000244")]
		[Address(RVA = "0x2C7BB2C", Offset = "0x2C7BB2C", VA = "0x2C7BB2C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700002A")]
	protected Material materialAdapt
	{
		[Token(Token = "0x6000245")]
		[Address(RVA = "0x2C7BC08", Offset = "0x2C7BC08", VA = "0x2C7BC08")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700002B")]
	protected Material materialApply
	{
		[Token(Token = "0x6000246")]
		[Address(RVA = "0x2C7BCE4", Offset = "0x2C7BCE4", VA = "0x2C7BCE4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000247")]
	[Address(RVA = "0x2C7BDC0", Offset = "0x2C7BDC0", VA = "0x2C7BDC0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000248")]
	[Address(RVA = "0x2C7BE54", Offset = "0x2C7BE54", VA = "0x2C7BE54")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000249")]
	[Address(RVA = "0x2C7BFB4", Offset = "0x2C7BFB4", VA = "0x2C7BFB4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600024A")]
	[Address(RVA = "0x2C7C1E0", Offset = "0x2C7C1E0", VA = "0x2C7C1E0")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x600024B")]
	[Address(RVA = "0x2C7C444", Offset = "0x2C7C444", VA = "0x2C7C444")]
	private void CalculateAdaptation(Texture curTexture)
	{
	}

	[Token(Token = "0x600024C")]
	[Address(RVA = "0x2C7C608", Offset = "0x2C7C608", VA = "0x2C7C608")]
	public ContrastStretchEffect()
	{
	}
}
[Token(Token = "0x2000080")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x124D1B8", Offset = "0x124D1B8")]
public class EdgeDetectEffect : ImageEffectBase
{
	[Token(Token = "0x40002B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float threshold;

	[Token(Token = "0x600024D")]
	[Address(RVA = "0x2C80BFC", Offset = "0x2C80BFC", VA = "0x2C80BFC")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x600024E")]
	[Address(RVA = "0x2C80CC8", Offset = "0x2C80CC8", VA = "0x2C80CC8")]
	public EdgeDetectEffect()
	{
	}
}
[Token(Token = "0x2000081")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x124D204", Offset = "0x124D204")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x124D204", Offset = "0x124D204")]
public class GlowEffect : MonoBehaviour
{
	[Token(Token = "0x40002B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float glowIntensity;

	[Token(Token = "0x40002B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int blurIterations;

	[Token(Token = "0x40002B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float blurSpread;

	[Token(Token = "0x40002B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Color glowTint;

	[Token(Token = "0x40002BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Shader compositeShader;

	[Token(Token = "0x40002BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Material m_CompositeMaterial;

	[Token(Token = "0x40002BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Shader blurShader;

	[Token(Token = "0x40002BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Material m_BlurMaterial;

	[Token(Token = "0x40002BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Shader downsampleShader;

	[Token(Token = "0x40002BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Material m_DownsampleMaterial;

	[Token(Token = "0x1700002C")]
	protected Material compositeMaterial
	{
		[Token(Token = "0x600024F")]
		[Address(RVA = "0x2C86184", Offset = "0x2C86184", VA = "0x2C86184")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700002D")]
	protected Material blurMaterial
	{
		[Token(Token = "0x6000250")]
		[Address(RVA = "0x2C86260", Offset = "0x2C86260", VA = "0x2C86260")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700002E")]
	protected Material downsampleMaterial
	{
		[Token(Token = "0x6000251")]
		[Address(RVA = "0x2C8633C", Offset = "0x2C8633C", VA = "0x2C8633C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000252")]
	[Address(RVA = "0x2C86418", Offset = "0x2C86418", VA = "0x2C86418")]
	protected void OnDisable()
	{
	}

	[Token(Token = "0x6000253")]
	[Address(RVA = "0x2C8656C", Offset = "0x2C8656C", VA = "0x2C8656C")]
	protected void Start()
	{
	}

	[Token(Token = "0x6000254")]
	[Address(RVA = "0x2C866E4", Offset = "0x2C866E4", VA = "0x2C866E4")]
	public void FourTapCone(RenderTexture source, RenderTexture dest, int iteration)
	{
	}

	[Token(Token = "0x6000255")]
	[Address(RVA = "0x2C86808", Offset = "0x2C86808", VA = "0x2C86808")]
	private void DownSample4x(RenderTexture source, RenderTexture dest)
	{
	}

	[Token(Token = "0x6000256")]
	[Address(RVA = "0x2C868E8", Offset = "0x2C868E8", VA = "0x2C868E8")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000257")]
	[Address(RVA = "0x2C86B80", Offset = "0x2C86B80", VA = "0x2C86B80")]
	public void BlitGlow(RenderTexture source, RenderTexture dest)
	{
	}

	[Token(Token = "0x6000258")]
	[Address(RVA = "0x2C86C6C", Offset = "0x2C86C6C", VA = "0x2C86C6C")]
	public GlowEffect()
	{
	}
}
[Token(Token = "0x2000082")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x124D298", Offset = "0x124D298")]
public class GrayscaleEffect : ImageEffectBase
{
	[Token(Token = "0x40002C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Texture textureRamp;

	[Token(Token = "0x40002C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float rampOffset;

	[Token(Token = "0x6000259")]
	[Address(RVA = "0x2C86F18", Offset = "0x2C86F18", VA = "0x2C86F18")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x600025A")]
	[Address(RVA = "0x2C87014", Offset = "0x2C87014", VA = "0x2C87014")]
	public GrayscaleEffect()
	{
	}
}
[Token(Token = "0x2000083")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x124D2E4", Offset = "0x124D2E4")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x124D2E4", Offset = "0x124D2E4")]
public class ImageEffectBase : MonoBehaviour
{
	[Token(Token = "0x40002C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Shader shader;

	[Token(Token = "0x40002C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Material m_Material;

	[Token(Token = "0x1700002F")]
	protected Material material
	{
		[Token(Token = "0x600025C")]
		[Address(RVA = "0x3F608D0", Offset = "0x3F608D0", VA = "0x3F608D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600025B")]
	[Address(RVA = "0x3F60824", Offset = "0x3F60824", VA = "0x3F60824", Slot = "4")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x600025D")]
	[Address(RVA = "0x3F609AC", Offset = "0x3F609AC", VA = "0x3F609AC", Slot = "5")]
	protected virtual void OnDisable()
	{
	}

	[Token(Token = "0x600025E")]
	[Address(RVA = "0x3F60A58", Offset = "0x3F60A58", VA = "0x3F60A58")]
	public ImageEffectBase()
	{
	}
}
[Token(Token = "0x2000084")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x124D368", Offset = "0x124D368")]
public class ImageEffects
{
	[Token(Token = "0x600025F")]
	[Address(RVA = "0x3F60A60", Offset = "0x3F60A60", VA = "0x3F60A60")]
	public static void RenderDistortion(Material material, RenderTexture source, RenderTexture destination, float angle, Vector2 center, Vector2 radius)
	{
	}

	[Token(Token = "0x6000260")]
	[Address(RVA = "0x3F60CAC", Offset = "0x3F60CAC", VA = "0x3F60CAC")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1250AE8", Offset = "0x1250AE8")]
	public static void Blit(RenderTexture source, RenderTexture dest)
	{
	}

	[Token(Token = "0x6000261")]
	[Address(RVA = "0x3F60D20", Offset = "0x3F60D20", VA = "0x3F60D20")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1250B20", Offset = "0x1250B20")]
	public static void BlitWithMaterial(Material material, RenderTexture source, RenderTexture dest)
	{
	}

	[Token(Token = "0x6000262")]
	[Address(RVA = "0x3F60D9C", Offset = "0x3F60D9C", VA = "0x3F60D9C")]
	public ImageEffects()
	{
	}
}
[Token(Token = "0x2000085")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x124D3A0", Offset = "0x124D3A0")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x124D3A0", Offset = "0x124D3A0")]
[ExecuteInEditMode]
public class MotionBlur : ImageEffectBase
{
	[Token(Token = "0x40002C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float blurAmount;

	[Token(Token = "0x40002C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool extraBlur;

	[Token(Token = "0x40002C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private RenderTexture accumTexture;

	[Token(Token = "0x6000263")]
	[Address(RVA = "0x3F65F0C", Offset = "0x3F65F0C", VA = "0x3F65F0C", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000264")]
	[Address(RVA = "0x3F65F50", Offset = "0x3F65F50", VA = "0x3F65F50", Slot = "5")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6000265")]
	[Address(RVA = "0x3F65FC0", Offset = "0x3F65FC0", VA = "0x3F65FC0")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000266")]
	[Address(RVA = "0x3F6633C", Offset = "0x3F6633C", VA = "0x3F6633C")]
	public MotionBlur()
	{
	}
}
[Token(Token = "0x2000086")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x124D434", Offset = "0x124D434")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x124D434", Offset = "0x124D434")]
public class NoiseEffect : MonoBehaviour
{
	[Token(Token = "0x40002C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool monochrome;

	[Token(Token = "0x40002C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	private bool rgbFallback;

	[Token(Token = "0x40002C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float grainIntensityMin;

	[Token(Token = "0x40002CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float grainIntensityMax;

	[Token(Token = "0x40002CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float grainSize;

	[Token(Token = "0x40002CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float scratchIntensityMin;

	[Token(Token = "0x40002CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float scratchIntensityMax;

	[Token(Token = "0x40002CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float scratchFPS;

	[Token(Token = "0x40002CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float scratchJitter;

	[Token(Token = "0x40002D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Texture grainTexture;

	[Token(Token = "0x40002D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Texture scratchTexture;

	[Token(Token = "0x40002D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Shader shaderRGB;

	[Token(Token = "0x40002D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Shader shaderYUV;

	[Token(Token = "0x40002D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Material m_MaterialRGB;

	[Token(Token = "0x40002D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Material m_MaterialYUV;

	[Token(Token = "0x40002D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private float scratchTimeLeft;

	[Token(Token = "0x40002D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private float scratchX;

	[Token(Token = "0x40002D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float scratchY;

	[Token(Token = "0x17000030")]
	protected Material material
	{
		[Token(Token = "0x6000268")]
		[Address(RVA = "0x3F6AF24", Offset = "0x3F6AF24", VA = "0x3F6AF24")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000267")]
	[Address(RVA = "0x3F6ADD0", Offset = "0x3F6ADD0", VA = "0x3F6ADD0")]
	protected void Start()
	{
	}

	[Token(Token = "0x6000269")]
	[Address(RVA = "0x3F6B0A0", Offset = "0x3F6B0A0", VA = "0x3F6B0A0")]
	protected void OnDisable()
	{
	}

	[Token(Token = "0x600026A")]
	[Address(RVA = "0x3F6B1A0", Offset = "0x3F6B1A0", VA = "0x3F6B1A0")]
	private void SanitizeParameters()
	{
	}

	[Token(Token = "0x600026B")]
	[Address(RVA = "0x3F6B294", Offset = "0x3F6B294", VA = "0x3F6B294")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x600026C")]
	[Address(RVA = "0x3F6B614", Offset = "0x3F6B614", VA = "0x3F6B614")]
	public NoiseEffect()
	{
	}
}
[Token(Token = "0x2000087")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x124D4C8", Offset = "0x124D4C8")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x124D4C8", Offset = "0x124D4C8")]
public class SSAOEffect : MonoBehaviour
{
	[Token(Token = "0x2000088")]
	public enum SSAOSamples
	{
		[Token(Token = "0x40002E5")]
		Low,
		[Token(Token = "0x40002E6")]
		Medium,
		[Token(Token = "0x40002E7")]
		High
	}

	[Token(Token = "0x40002D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float m_Radius;

	[Token(Token = "0x40002DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public SSAOSamples m_SampleCount;

	[Token(Token = "0x40002DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float m_OcclusionIntensity;

	[Token(Token = "0x40002DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int m_Blur;

	[Token(Token = "0x40002DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int m_Downsampling;

	[Token(Token = "0x40002DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float m_OcclusionAttenuation;

	[Token(Token = "0x40002DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float m_MinZ;

	[Token(Token = "0x40002E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Shader m_SSAOShader;

	[Token(Token = "0x40002E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Material m_SSAOMaterial;

	[Token(Token = "0x40002E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Texture2D m_RandomTexture;

	[Token(Token = "0x40002E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool m_Supported;

	[Token(Token = "0x600026D")]
	[Address(RVA = "0x2B4ABB8", Offset = "0x2B4ABB8", VA = "0x2B4ABB8")]
	private static Material CreateMaterial(Shader shader)
	{
		return null;
	}

	[Token(Token = "0x600026E")]
	[Address(RVA = "0x2B4AC70", Offset = "0x2B4AC70", VA = "0x2B4AC70")]
	private static void DestroyMaterial(Material mat)
	{
	}

	[Token(Token = "0x600026F")]
	[Address(RVA = "0x2B4AD08", Offset = "0x2B4AD08", VA = "0x2B4AD08")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000270")]
	[Address(RVA = "0x2B4AD10", Offset = "0x2B4AD10", VA = "0x2B4AD10")]
	private void Start()
	{
	}

	[Token(Token = "0x6000271")]
	[Address(RVA = "0x2B4AEC8", Offset = "0x2B4AEC8", VA = "0x2B4AEC8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000272")]
	[Address(RVA = "0x2B4ADE4", Offset = "0x2B4ADE4", VA = "0x2B4ADE4")]
	private void CreateMaterials()
	{
	}

	[Token(Token = "0x6000273")]
	[Address(RVA = "0x2B4AF38", Offset = "0x2B4AF38", VA = "0x2B4AF38")]
	[ImageEffectOpaque]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000274")]
	[Address(RVA = "0x2B4B5B0", Offset = "0x2B4B5B0", VA = "0x2B4B5B0")]
	public SSAOEffect()
	{
	}
}
[Token(Token = "0x2000089")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x124D55C", Offset = "0x124D55C")]
[ExecuteInEditMode]
public class SepiaToneEffect : ImageEffectBase
{
	[Token(Token = "0x6000275")]
	[Address(RVA = "0x2B4BAA4", Offset = "0x2B4BAA4", VA = "0x2B4BAA4")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000276")]
	[Address(RVA = "0x2B4BB34", Offset = "0x2B4BB34", VA = "0x2B4BB34")]
	public SepiaToneEffect()
	{
	}
}
[Token(Token = "0x200008A")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x124D5A8", Offset = "0x124D5A8")]
[ExecuteInEditMode]
public class TwirlEffect : ImageEffectBase
{
	[Token(Token = "0x40002E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector2 radius;

	[Token(Token = "0x40002E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float angle;

	[Token(Token = "0x40002EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public Vector2 center;

	[Token(Token = "0x6000277")]
	[Address(RVA = "0x2B5646C", Offset = "0x2B5646C", VA = "0x2B5646C")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000278")]
	[Address(RVA = "0x2B564B8", Offset = "0x2B564B8", VA = "0x2B564B8")]
	public TwirlEffect()
	{
	}
}
[Token(Token = "0x200008B")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x124D5F4", Offset = "0x124D5F4")]
[ExecuteInEditMode]
public class VortexEffect : ImageEffectBase
{
	[Token(Token = "0x40002EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector2 radius;

	[Token(Token = "0x40002EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float angle;

	[Token(Token = "0x40002ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public Vector2 center;

	[Token(Token = "0x6000279")]
	[Address(RVA = "0x2B57870", Offset = "0x2B57870", VA = "0x2B57870")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x600027A")]
	[Address(RVA = "0x2B578BC", Offset = "0x2B578BC", VA = "0x2B578BC")]
	public VortexEffect()
	{
	}
}
[Token(Token = "0x200008C")]
public class Floor_ReflectionScriptCamera : MonoBehaviour
{
	[Token(Token = "0x40002EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform[] reflectiveObjects;

	[Token(Token = "0x40002EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public LayerMask reflectionMask;

	[Token(Token = "0x40002F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Material[] reflectiveMaterials;

	[Token(Token = "0x40002F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Transform reflectiveSurfaceHeight;

	[Token(Token = "0x40002F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Shader replacementShader;

	[Token(Token = "0x40002F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool highQuality;

	[Token(Token = "0x40002F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public Color clearColor;

	[Token(Token = "0x40002F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public string reflectionSampler;

	[Token(Token = "0x40002F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public float clipPlaneOffset;

	[Token(Token = "0x40002F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private Vector3 oldpos;

	[Token(Token = "0x40002F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Camera reflectionCamera;

	[Token(Token = "0x40002F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Dictionary<Camera, bool> helperCameras;

	[Token(Token = "0x40002FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Texture[] initialReflectionTextures;

	[Token(Token = "0x600027B")]
	[Address(RVA = "0x2C82DA8", Offset = "0x2C82DA8", VA = "0x2C82DA8")]
	public void Start()
	{
	}

	[Token(Token = "0x600027C")]
	[Address(RVA = "0x2C82EC4", Offset = "0x2C82EC4", VA = "0x2C82EC4")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x600027D")]
	[Address(RVA = "0x2C82F54", Offset = "0x2C82F54", VA = "0x2C82F54")]
	private Camera CreateReflectionCameraFor(Camera cam)
	{
		return null;
	}

	[Token(Token = "0x600027E")]
	[Address(RVA = "0x2C83484", Offset = "0x2C83484", VA = "0x2C83484")]
	public void HighQuality()
	{
	}

	[Token(Token = "0x600027F")]
	[Address(RVA = "0x2C83310", Offset = "0x2C83310", VA = "0x2C83310")]
	private void SetStandardCameraParameter(Camera cam, LayerMask mask)
	{
	}

	[Token(Token = "0x6000280")]
	[Address(RVA = "0x2C83374", Offset = "0x2C83374", VA = "0x2C83374")]
	private RenderTexture CreateTextureFor(Camera cam)
	{
		return null;
	}

	[Token(Token = "0x6000281")]
	[Address(RVA = "0x2C83490", Offset = "0x2C83490", VA = "0x2C83490")]
	public void RenderHelpCameras(Camera currentCam)
	{
	}

	[Token(Token = "0x6000282")]
	[Address(RVA = "0x2C83B00", Offset = "0x2C83B00", VA = "0x2C83B00")]
	public void LateUpdate()
	{
	}

	[Token(Token = "0x6000283")]
	[Address(RVA = "0x2C83CD0", Offset = "0x2C83CD0", VA = "0x2C83CD0")]
	private void ObjectBeingRendered(Transform tr, Camera currentCam)
	{
	}

	[Token(Token = "0x6000284")]
	[Address(RVA = "0x2C836D0", Offset = "0x2C836D0", VA = "0x2C836D0")]
	private void RenderReflectionFor(Camera cam, Camera reflectCamera)
	{
	}

	[Token(Token = "0x6000285")]
	[Address(RVA = "0x2C83D78", Offset = "0x2C83D78", VA = "0x2C83D78")]
	private void SaneCameraSettings(Camera helperCam)
	{
	}

	[Token(Token = "0x6000286")]
	[Address(RVA = "0x2C841C0", Offset = "0x2C841C0", VA = "0x2C841C0")]
	private static Matrix4x4 CalculateObliqueMatrix(Matrix4x4 projection, Vector4 clipPlane)
	{
		return default(Matrix4x4);
	}

	[Token(Token = "0x6000287")]
	[Address(RVA = "0x2C83DDC", Offset = "0x2C83DDC", VA = "0x2C83DDC")]
	private static Matrix4x4 CalculateReflectionMatrix(Matrix4x4 reflectionMat, Vector4 plane)
	{
		return default(Matrix4x4);
	}

	[Token(Token = "0x6000288")]
	[Address(RVA = "0x2C84384", Offset = "0x2C84384", VA = "0x2C84384")]
	private static float sgn(float a)
	{
		return default(float);
	}

	[Token(Token = "0x6000289")]
	[Address(RVA = "0x2C84094", Offset = "0x2C84094", VA = "0x2C84094")]
	private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
	{
		return default(Vector4);
	}

	[Token(Token = "0x600028A")]
	[Address(RVA = "0x2C843A4", Offset = "0x2C843A4", VA = "0x2C843A4")]
	public Floor_ReflectionScriptCamera()
	{
	}
}
[Token(Token = "0x200008D")]
[ExecuteInEditMode]
public class MirrorReflection : MonoBehaviour
{
	[Token(Token = "0x40002FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool m_DisablePixelLights;

	[Token(Token = "0x40002FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int m_TextureSize;

	[Token(Token = "0x40002FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float m_ClipPlaneOffset;

	[Token(Token = "0x40002FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public LayerMask m_ReflectLayers;

	[Token(Token = "0x40002FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Hashtable m_ReflectionCameras;

	[Token(Token = "0x4000300")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private RenderTexture m_ReflectionTexture;

	[Token(Token = "0x4000301")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int m_OldReflectionTextureSize;

	[Token(Token = "0x4000302")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static bool s_InsideRendering;

	[Token(Token = "0x600028B")]
	[Address(RVA = "0x3F64288", Offset = "0x3F64288", VA = "0x3F64288")]
	public void beginCameraRendering()
	{
	}

	[Token(Token = "0x600028C")]
	[Address(RVA = "0x3F65A04", Offset = "0x3F65A04", VA = "0x3F65A04")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600028D")]
	[Address(RVA = "0x3F65148", Offset = "0x3F65148", VA = "0x3F65148")]
	private void UpdateCameraModes(Camera src, Camera dest)
	{
	}

	[Token(Token = "0x600028E")]
	[Address(RVA = "0x3F64BD0", Offset = "0x3F64BD0", VA = "0x3F64BD0")]
	private void CreateMirrorObjects(Camera currentCamera, out Camera reflectionCamera)
	{
	}

	[Token(Token = "0x600028F")]
	[Address(RVA = "0x3F65D88", Offset = "0x3F65D88", VA = "0x3F65D88")]
	private static float sgn(float a)
	{
		return default(float);
	}

	[Token(Token = "0x6000290")]
	[Address(RVA = "0x3F656E8", Offset = "0x3F656E8", VA = "0x3F656E8")]
	private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
	{
		return default(Vector4);
	}

	[Token(Token = "0x6000291")]
	[Address(RVA = "0x3F65814", Offset = "0x3F65814", VA = "0x3F65814")]
	private static void CalculateObliqueMatrix(ref Matrix4x4 projection, Vector4 clipPlane)
	{
	}

	[Token(Token = "0x6000292")]
	[Address(RVA = "0x3F65444", Offset = "0x3F65444", VA = "0x3F65444")]
	private static void CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane)
	{
	}

	[Token(Token = "0x6000293")]
	[Address(RVA = "0x3F65DA8", Offset = "0x3F65DA8", VA = "0x3F65DA8")]
	public MirrorReflection()
	{
	}
}
[Token(Token = "0x200008E")]
public class LightMapData : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200008F")]
	public struct RendererInfo
	{
		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Renderer renderer;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int lightmapIndex;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Vector4 lightmapOffsetScale;
	}

	[Token(Token = "0x4000303")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	public RendererInfo m_RendererInfo;

	[Token(Token = "0x6000295")]
	[Address(RVA = "0x3F619C8", Offset = "0x3F619C8", VA = "0x3F619C8")]
	public void GetInfo()
	{
	}

	[Token(Token = "0x6000296")]
	[Address(RVA = "0x3F61AA8", Offset = "0x3F61AA8", VA = "0x3F61AA8")]
	public LightMapData()
	{
	}
}
[Serializable]
[Token(Token = "0x2000090")]
public class LightMapDataContainerObject : ScriptableObject
{
	[Token(Token = "0x4000307")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int[] lightmapIndexes;

	[Token(Token = "0x4000308")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector4[] lightmapOffsetScales;

	[Token(Token = "0x6000297")]
	[Address(RVA = "0x3F61AB0", Offset = "0x3F61AB0", VA = "0x3F61AB0")]
	public LightMapDataContainerObject()
	{
	}
}
[Token(Token = "0x2000091")]
[ExecuteInEditMode]
public class LightmappingManager : MonoBehaviour
{
	[Token(Token = "0x4000309")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	public Renderer[] sceneRenderers;

	[Token(Token = "0x400030A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public LightMapDataContainerObject lighmapDataContainer;

	[Token(Token = "0x400030B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	public Texture2D[] lightMapTexturesFar;

	[Token(Token = "0x6000298")]
	[Address(RVA = "0x3F62B14", Offset = "0x3F62B14", VA = "0x3F62B14")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000299")]
	[Address(RVA = "0x3F62CAC", Offset = "0x3F62CAC", VA = "0x3F62CAC")]
	public void SetLightMapTextures()
	{
	}

	[Token(Token = "0x600029A")]
	[Address(RVA = "0x3F62B38", Offset = "0x3F62B38", VA = "0x3F62B38")]
	public void SetLightMapData()
	{
	}

	[Token(Token = "0x600029B")]
	[Address(RVA = "0x3F62E14", Offset = "0x3F62E14", VA = "0x3F62E14")]
	public LightmappingManager()
	{
	}
}
[Token(Token = "0x2000092")]
public class AirplaneFly : MonoBehaviour
{
	[Token(Token = "0x2000093")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124D660", Offset = "0x124D660")]
	private sealed class <DisableWord>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AirplaneFly <>4__this;

		[Token(Token = "0x17000031")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002A7")]
			[Address(RVA = "0x3108734", Offset = "0x3108734", VA = "0x3108734", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000032")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002A9")]
			[Address(RVA = "0x310877C", Offset = "0x310877C", VA = "0x310877C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x3108598", Offset = "0x3108598", VA = "0x3108598")]
		[DebuggerHidden]
		public <DisableWord>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x31085C4", Offset = "0x31085C4", VA = "0x31085C4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x31085C8", Offset = "0x31085C8", VA = "0x31085C8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x310873C", Offset = "0x310873C", VA = "0x310873C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400030C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int animFream;

	[Token(Token = "0x400030D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject loveLetter;

	[Token(Token = "0x400030E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool recordFream;

	[Token(Token = "0x400030F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private Vector3 vecPrePos;

	[Token(Token = "0x4000310")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Vector3 vecOffsetPos;

	[Token(Token = "0x600029C")]
	[Address(RVA = "0x1A49FF0", Offset = "0x1A49FF0", VA = "0x1A49FF0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600029D")]
	[Address(RVA = "0x1A4A05C", Offset = "0x1A4A05C", VA = "0x1A4A05C")]
	public void StartRecordFream()
	{
	}

	[Token(Token = "0x600029E")]
	[Address(RVA = "0x1A4A0D0", Offset = "0x1A4A0D0", VA = "0x1A4A0D0")]
	private void Update()
	{
	}

	[Token(Token = "0x600029F")]
	[Address(RVA = "0x1A4A174", Offset = "0x1A4A174", VA = "0x1A4A174")]
	private void FlyOver()
	{
	}

	[Token(Token = "0x60002A0")]
	[Address(RVA = "0x1A4A320", Offset = "0x1A4A320", VA = "0x1A4A320")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1250B68", Offset = "0x1250B68")]
	private IEnumerator DisableWord()
	{
		return null;
	}

	[Token(Token = "0x60002A1")]
	[Address(RVA = "0x1A4A398", Offset = "0x1A4A398", VA = "0x1A4A398")]
	public AirplaneFly()
	{
	}

	[Token(Token = "0x60002A2")]
	[Address(RVA = "0x1A4A3A8", Offset = "0x1A4A3A8", VA = "0x1A4A3A8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1250BC8", Offset = "0x1250BC8")]
	private void <FlyOver>b__8_0()
	{
	}

	[Token(Token = "0x60002A3")]
	[Address(RVA = "0x1A4A3D4", Offset = "0x1A4A3D4", VA = "0x1A4A3D4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1250BD8", Offset = "0x1250BD8")]
	private void <DisableWord>b__9_0()
	{
	}
}
[Token(Token = "0x2000094")]
public class AirplaneLogic : MonoBehaviour
{
	[Token(Token = "0x4000314")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject[] objLoveLetters;

	[Token(Token = "0x60002AA")]
	[Address(RVA = "0x1A4A3F4", Offset = "0x1A4A3F4", VA = "0x1A4A3F4")]
	private void Start()
	{
	}

	[Token(Token = "0x60002AB")]
	[Address(RVA = "0x1A4A58C", Offset = "0x1A4A58C", VA = "0x1A4A58C")]
	public void TouchThis()
	{
	}

	[Token(Token = "0x60002AC")]
	[Address(RVA = "0x1A4A6D8", Offset = "0x1A4A6D8", VA = "0x1A4A6D8")]
	public AirplaneLogic()
	{
	}

	[Token(Token = "0x60002AD")]
	[Address(RVA = "0x1A4A6E0", Offset = "0x1A4A6E0", VA = "0x1A4A6E0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1250C38", Offset = "0x1250C38")]
	private void <Start>b__1_0()
	{
	}
}
[Token(Token = "0x2000095")]
public class ControlCubeEffect : MonoBehaviour
{
	[Token(Token = "0x2000096")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124D670", Offset = "0x124D670")]
	private sealed class <ShowAlpha>d__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float totalTime;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ControlCubeEffect <>4__this;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <timer>5__2;

		[Token(Token = "0x17000033")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002BC")]
			[Address(RVA = "0x310B3D8", Offset = "0x310B3D8", VA = "0x310B3D8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002BE")]
			[Address(RVA = "0x310B420", Offset = "0x310B420", VA = "0x310B420", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x310B20C", Offset = "0x310B20C", VA = "0x310B20C")]
		[DebuggerHidden]
		public <ShowAlpha>d__21(int <>1__state)
		{
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x310B238", Offset = "0x310B238", VA = "0x310B238", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x310B23C", Offset = "0x310B23C", VA = "0x310B23C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x310B3E0", Offset = "0x310B3E0", VA = "0x310B3E0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000097")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124D680", Offset = "0x124D680")]
	private sealed class <ShowColor>d__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ControlCubeEffect <>4__this;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float totalTime;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Color targetColor;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float <timer>5__2;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Color <initColor>5__3;

		[Token(Token = "0x17000035")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002C2")]
			[Address(RVA = "0x310B5BC", Offset = "0x310B5BC", VA = "0x310B5BC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000036")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002C4")]
			[Address(RVA = "0x310B604", Offset = "0x310B604", VA = "0x310B604", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x310B428", Offset = "0x310B428", VA = "0x310B428")]
		[DebuggerHidden]
		public <ShowColor>d__22(int <>1__state)
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x310B454", Offset = "0x310B454", VA = "0x310B454", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x310B458", Offset = "0x310B458", VA = "0x310B458", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x310B5C4", Offset = "0x310B5C4", VA = "0x310B5C4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000315")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float alphaShowTime;

	[Token(Token = "0x4000316")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float colorShowTime;

	[Token(Token = "0x4000317")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Color targetColor;

	[Token(Token = "0x4000318")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Color initColor;

	[Token(Token = "0x4000319")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Coroutine colorCoroutine;

	[Token(Token = "0x400031A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Coroutine alphaCoroutine;

	[Token(Token = "0x400031B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Material mat;

	[Token(Token = "0x400031C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool alphaStart;

	[Token(Token = "0x400031D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private float alphaDuration;

	[Token(Token = "0x400031E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float alphaStartTimer;

	[Token(Token = "0x400031F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private bool colorStart;

	[Token(Token = "0x4000320")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private float colorDuration;

	[Token(Token = "0x4000321")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private float colorStartTimer;

	[Token(Token = "0x60002AE")]
	[Address(RVA = "0x2C7C688", Offset = "0x2C7C688", VA = "0x2C7C688")]
	private void Start()
	{
	}

	[Token(Token = "0x60002AF")]
	[Address(RVA = "0x2C7C758", Offset = "0x2C7C758", VA = "0x2C7C758")]
	public void ShowAlphaEffect()
	{
	}

	[Token(Token = "0x60002B0")]
	[Address(RVA = "0x2C7C83C", Offset = "0x2C7C83C", VA = "0x2C7C83C")]
	public void ShowAlphaEffect(float t)
	{
	}

	[Token(Token = "0x60002B1")]
	[Address(RVA = "0x2C7C870", Offset = "0x2C7C870", VA = "0x2C7C870")]
	public void ShowColorEffect()
	{
	}

	[Token(Token = "0x60002B2")]
	[Address(RVA = "0x2C7C9D8", Offset = "0x2C7C9D8", VA = "0x2C7C9D8")]
	private void Update()
	{
	}

	[Token(Token = "0x60002B3")]
	[Address(RVA = "0x2C7CAB8", Offset = "0x2C7CAB8", VA = "0x2C7CAB8")]
	private void UpdateAlphaEffect()
	{
	}

	[Token(Token = "0x60002B4")]
	[Address(RVA = "0x2C7CB58", Offset = "0x2C7CB58", VA = "0x2C7CB58")]
	public void ShowColorEffect(float t)
	{
	}

	[Token(Token = "0x60002B5")]
	[Address(RVA = "0x2C7C9DC", Offset = "0x2C7C9DC", VA = "0x2C7C9DC")]
	private void UpdateColorEffect()
	{
	}

	[Token(Token = "0x60002B6")]
	[Address(RVA = "0x2C7C7B4", Offset = "0x2C7C7B4", VA = "0x2C7C7B4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1250C48", Offset = "0x1250C48")]
	private IEnumerator ShowAlpha(float totalTime)
	{
		return null;
	}

	[Token(Token = "0x60002B7")]
	[Address(RVA = "0x2C7C928", Offset = "0x2C7C928", VA = "0x2C7C928")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1250CA8", Offset = "0x1250CA8")]
	private IEnumerator ShowColor(Color targetColor, float totalTime)
	{
		return null;
	}

	[Token(Token = "0x60002B8")]
	[Address(RVA = "0x2C7CB8C", Offset = "0x2C7CB8C", VA = "0x2C7CB8C")]
	public ControlCubeEffect()
	{
	}
}
[Token(Token = "0x2000098")]
public class ControlDoorEffect : MonoBehaviour
{
	[Token(Token = "0x2000099")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124D690", Offset = "0x124D690")]
	private sealed class <Run>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ControlDoorEffect <>4__this;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float WireTime;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float interval;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float colorTime;

		[Token(Token = "0x17000037")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002CE")]
			[Address(RVA = "0x310B76C", Offset = "0x310B76C", VA = "0x310B76C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000038")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002D0")]
			[Address(RVA = "0x310B7B4", Offset = "0x310B7B4", VA = "0x310B7B4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x310B60C", Offset = "0x310B60C", VA = "0x310B60C")]
		[DebuggerHidden]
		public <Run>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x310B638", Offset = "0x310B638", VA = "0x310B638", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x310B63C", Offset = "0x310B63C", VA = "0x310B63C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x310B774", Offset = "0x310B774", VA = "0x310B774", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200009A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124D6A0", Offset = "0x124D6A0")]
	private sealed class <ShowColor>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ControlDoorEffect <>4__this;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float totalTime;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <timer>5__2;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Material <mat>5__3;

		[Token(Token = "0x17000039")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002D4")]
			[Address(RVA = "0x310B944", Offset = "0x310B944", VA = "0x310B944", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002D6")]
			[Address(RVA = "0x310B98C", Offset = "0x310B98C", VA = "0x310B98C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x310B7BC", Offset = "0x310B7BC", VA = "0x310B7BC")]
		[DebuggerHidden]
		public <ShowColor>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x310B7E8", Offset = "0x310B7E8", VA = "0x310B7E8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x310B7EC", Offset = "0x310B7EC", VA = "0x310B7EC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x310B94C", Offset = "0x310B94C", VA = "0x310B94C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200009B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124D6B0", Offset = "0x124D6B0")]
	private sealed class <ShowWire>d__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ControlDoorEffect <>4__this;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float totalTime;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <timer>5__2;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Material <mat>5__3;

		[Token(Token = "0x1700003B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002DA")]
			[Address(RVA = "0x310BB34", Offset = "0x310BB34", VA = "0x310BB34", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002DC")]
			[Address(RVA = "0x310BB7C", Offset = "0x310BB7C", VA = "0x310BB7C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x310B994", Offset = "0x310B994", VA = "0x310B994")]
		[DebuggerHidden]
		public <ShowWire>d__10(int <>1__state)
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x310B9C0", Offset = "0x310B9C0", VA = "0x310B9C0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x310B9C4", Offset = "0x310B9C4", VA = "0x310B9C4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x310BB3C", Offset = "0x310BB3C", VA = "0x310BB3C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400032E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Renderer colorRender;

	[Token(Token = "0x400032F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Renderer wireRender;

	[Token(Token = "0x4000330")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AnimationCurve curve;

	[Token(Token = "0x4000331")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float interval;

	[Token(Token = "0x4000332")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float colorTime;

	[Token(Token = "0x4000333")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float wireTime;

	[Token(Token = "0x60002C5")]
	[Address(RVA = "0x2C7CBC8", Offset = "0x2C7CBC8", VA = "0x2C7CBC8")]
	public void ShowEffect()
	{
	}

	[Token(Token = "0x60002C6")]
	[Address(RVA = "0x2C7CCA4", Offset = "0x2C7CCA4", VA = "0x2C7CCA4")]
	public void ShowEffect(float wireT, float colorT, float intervalT)
	{
	}

	[Token(Token = "0x60002C7")]
	[Address(RVA = "0x2C7CC08", Offset = "0x2C7CC08", VA = "0x2C7CC08")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1250DA8", Offset = "0x1250DA8")]
	private IEnumerator Run(float WireTime, float colorTime, float interval)
	{
		return null;
	}

	[Token(Token = "0x60002C8")]
	[Address(RVA = "0x2C7CD04", Offset = "0x2C7CD04", VA = "0x2C7CD04")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1250E08", Offset = "0x1250E08")]
	private IEnumerator ShowColor(float totalTime)
	{
		return null;
	}

	[Token(Token = "0x60002C9")]
	[Address(RVA = "0x2C7CD8C", Offset = "0x2C7CD8C", VA = "0x2C7CD8C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1250E68", Offset = "0x1250E68")]
	private IEnumerator ShowWire(float totalTime)
	{
		return null;
	}

	[Token(Token = "0x60002CA")]
	[Address(RVA = "0x2C7CE14", Offset = "0x2C7CE14", VA = "0x2C7CE14")]
	public ControlDoorEffect()
	{
	}
}
[Token(Token = "0x200009C")]
public class ControlZiMuEffect : MonoBehaviour
{
	[Token(Token = "0x200009D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124D6C0", Offset = "0x124D6C0")]
	private sealed class <AlphaTo>d__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ControlZiMuEffect <>4__this;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float target;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float time;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<float> <initVal>5__2;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <timer>5__3;

		[Token(Token = "0x1700003D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002E3")]
			[Address(RVA = "0x310BF38", Offset = "0x310BF38", VA = "0x310BF38", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002E5")]
			[Address(RVA = "0x310BF80", Offset = "0x310BF80", VA = "0x310BF80", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x310BB84", Offset = "0x310BB84", VA = "0x310BB84")]
		[DebuggerHidden]
		public <AlphaTo>d__2(int <>1__state)
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x310BBB0", Offset = "0x310BBB0", VA = "0x310BBB0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x310BBB4", Offset = "0x310BBB4", VA = "0x310BBB4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x310BF40", Offset = "0x310BF40", VA = "0x310BF40", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000346")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<Material> matList;

	[Token(Token = "0x60002DD")]
	[Address(RVA = "0x2C7CE2C", Offset = "0x2C7CE2C", VA = "0x2C7CE2C")]
	public void SetAlphaTo(float target, float time)
	{
	}

	[Token(Token = "0x60002DE")]
	[Address(RVA = "0x2C7CE7C", Offset = "0x2C7CE7C", VA = "0x2C7CE7C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1250FB8", Offset = "0x1250FB8")]
	private IEnumerator AlphaTo(float target, float time)
	{
		return null;
	}

	[Token(Token = "0x60002DF")]
	[Address(RVA = "0x2C7CF08", Offset = "0x2C7CF08", VA = "0x2C7CF08")]
	public ControlZiMuEffect()
	{
	}
}
[Token(Token = "0x200009E")]
public class CubeLogic : MonoBehaviour
{
	[Token(Token = "0x200009F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124D6D0", Offset = "0x124D6D0")]
	private sealed class <LightOffCube>d__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CubeLogic <>4__this;

		[Token(Token = "0x1700003F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002F2")]
			[Address(RVA = "0x310C080", Offset = "0x310C080", VA = "0x310C080", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000040")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002F4")]
			[Address(RVA = "0x310C0C8", Offset = "0x310C0C8", VA = "0x310C0C8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x310BF88", Offset = "0x310BF88", VA = "0x310BF88")]
		[DebuggerHidden]
		public <LightOffCube>d__14(int <>1__state)
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x310BFB4", Offset = "0x310BFB4", VA = "0x310BFB4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x310BFB8", Offset = "0x310BFB8", VA = "0x310BFB8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x310C088", Offset = "0x310C088", VA = "0x310C088", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400034E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Color cubeSparkColorInit;

	[Token(Token = "0x400034F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Color cubeSparkColorTemp;

	[Token(Token = "0x4000350")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Material cubeMat;

	[Token(Token = "0x4000351")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float sparkDuration;

	[Token(Token = "0x4000352")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float firstDuration;

	[Token(Token = "0x4000353")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float secondDuration;

	[Token(Token = "0x4000354")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Color[] cubeSparkColor;

	[Token(Token = "0x4000355")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private int sparkColorID;

	[Token(Token = "0x4000356")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private bool bSparkStart;

	[Token(Token = "0x4000357")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float sparkStartTime;

	[Token(Token = "0x4000358")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static int maincolorshderid;

	[Token(Token = "0x60002E6")]
	[Address(RVA = "0x2C7D6B8", Offset = "0x2C7D6B8", VA = "0x2C7D6B8")]
	private void Start()
	{
	}

	[Token(Token = "0x60002E7")]
	[Address(RVA = "0x2C7D6BC", Offset = "0x2C7D6BC", VA = "0x2C7D6BC")]
	private void InitCube()
	{
	}

	[Token(Token = "0x60002E8")]
	[Address(RVA = "0x2C7D794", Offset = "0x2C7D794", VA = "0x2C7D794")]
	public void LightOnCube()
	{
	}

	[Token(Token = "0x60002E9")]
	[Address(RVA = "0x2C7D7D8", Offset = "0x2C7D7D8", VA = "0x2C7D7D8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1251068", Offset = "0x1251068")]
	private IEnumerator LightOffCube()
	{
		return null;
	}

	[Token(Token = "0x60002EA")]
	[Address(RVA = "0x2C7D850", Offset = "0x2C7D850", VA = "0x2C7D850")]
	public void SparkCube()
	{
	}

	[Token(Token = "0x60002EB")]
	[Address(RVA = "0x2C7D908", Offset = "0x2C7D908", VA = "0x2C7D908")]
	private void UpdateCubeColor()
	{
	}

	[Token(Token = "0x60002EC")]
	[Address(RVA = "0x2C7DAAC", Offset = "0x2C7DAAC", VA = "0x2C7DAAC")]
	private void Update()
	{
	}

	[Token(Token = "0x60002ED")]
	[Address(RVA = "0x2C7DAB0", Offset = "0x2C7DAB0", VA = "0x2C7DAB0")]
	public CubeLogic()
	{
	}
}
[Token(Token = "0x20000A0")]
public class FontLogic : MonoBehaviour
{
	[Token(Token = "0x400035C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool bShowFont;

	[Token(Token = "0x400035D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Material font_Mat;

	[Token(Token = "0x400035E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Color tempColorA;

	[Token(Token = "0x400035F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float startTimer;

	[Token(Token = "0x4000360")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float durationTimer;

	[Token(Token = "0x4000361")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Color initColor;

	[Token(Token = "0x4000362")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Color targetColor;

	[Token(Token = "0x60002F5")]
	[Address(RVA = "0x2C849D0", Offset = "0x2C849D0", VA = "0x2C849D0")]
	private void Start()
	{
	}

	[Token(Token = "0x60002F6")]
	[Address(RVA = "0x2C84A7C", Offset = "0x2C84A7C", VA = "0x2C84A7C")]
	public void WrongFontShow()
	{
	}

	[Token(Token = "0x60002F7")]
	[Address(RVA = "0x2C84AAC", Offset = "0x2C84AAC", VA = "0x2C84AAC")]
	private void Update()
	{
	}

	[Token(Token = "0x60002F8")]
	[Address(RVA = "0x2C84B78", Offset = "0x2C84B78", VA = "0x2C84B78")]
	public FontLogic()
	{
	}
}
[Token(Token = "0x20000A1")]
public class HousesWireframeGrowup : MonoBehaviour
{
	[Token(Token = "0x4000363")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private GameObject[] obj;

	[Token(Token = "0x4000364")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string objTag;

	[Token(Token = "0x4000365")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private GameObject[] tempObj;

	[Token(Token = "0x4000366")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<GameObject> tempBuildings;

	[Token(Token = "0x4000367")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Color LineColor;

	[Token(Token = "0x4000368")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float LineColorIntensity;

	[Token(Token = "0x4000369")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Material wireMat;

	[Token(Token = "0x400036A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public float stage1Time;

	[Token(Token = "0x400036B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public float stage2Time;

	[Token(Token = "0x400036C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public float stage3Time;

	[Token(Token = "0x400036D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public bool animStart;

	[Token(Token = "0x400036E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
	public bool breakPause;

	[Token(Token = "0x400036F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Shader extendLitShader;

	[Token(Token = "0x4000370")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float stagePauseTime;

	[Token(Token = "0x4000371")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private float animStartTime;

	[Token(Token = "0x4000372")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private bool doonce;

	[Token(Token = "0x4000373")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
	private bool stage2DoOnce;

	[Token(Token = "0x4000374")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7A")]
	private bool stage3DoOnce;

	[Token(Token = "0x4000375")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private Vector4 emissionColor;

	[Token(Token = "0x4000376")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private Color newCol;

	[Token(Token = "0x4000377")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Material objFinalMat;

	[Token(Token = "0x60002F9")]
	[Address(RVA = "0x3F5F198", Offset = "0x3F5F198", VA = "0x3F5F198")]
	private void Start()
	{
	}

	[Token(Token = "0x60002FA")]
	[Address(RVA = "0x3F5F2F0", Offset = "0x3F5F2F0", VA = "0x3F5F2F0")]
	private void Update()
	{
	}

	[Token(Token = "0x60002FB")]
	[Address(RVA = "0x3F5FA54", Offset = "0x3F5FA54", VA = "0x3F5FA54")]
	private void DoStage1()
	{
	}

	[Token(Token = "0x60002FC")]
	[Address(RVA = "0x3F5FD70", Offset = "0x3F5FD70", VA = "0x3F5FD70")]
	private void DoStage2()
	{
	}

	[Token(Token = "0x60002FD")]
	[Address(RVA = "0x3F6022C", Offset = "0x3F6022C", VA = "0x3F6022C")]
	private void DoStage3()
	{
	}

	[Token(Token = "0x60002FE")]
	[Address(RVA = "0x3F604C8", Offset = "0x3F604C8", VA = "0x3F604C8")]
	private void DoStagePause()
	{
	}

	[Token(Token = "0x60002FF")]
	[Address(RVA = "0x3F5F5F8", Offset = "0x3F5F5F8", VA = "0x3F5F5F8")]
	private void MatAnimation()
	{
	}

	[Token(Token = "0x6000300")]
	[Address(RVA = "0x3F6050C", Offset = "0x3F6050C", VA = "0x3F6050C")]
	public void ContinueAnimation()
	{
	}

	[Token(Token = "0x6000301")]
	[Address(RVA = "0x3F5F330", Offset = "0x3F5F330", VA = "0x3F5F330")]
	public void StartAnimation()
	{
	}

	[Token(Token = "0x6000302")]
	[Address(RVA = "0x3F60518", Offset = "0x3F60518", VA = "0x3F60518")]
	public HousesWireframeGrowup()
	{
	}
}
[Token(Token = "0x20000A2")]
public class KongMingDengLogic : MonoBehaviour
{
	[Token(Token = "0x4000378")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 vecTargetSize;

	[Token(Token = "0x4000379")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Vector3 vecMoveTarget;

	[Token(Token = "0x6000303")]
	[Address(RVA = "0x3F60DC8", Offset = "0x3F60DC8", VA = "0x3F60DC8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000304")]
	[Address(RVA = "0x3F60DCC", Offset = "0x3F60DCC", VA = "0x3F60DCC")]
	public void DengLongShow()
	{
	}

	[Token(Token = "0x6000305")]
	[Address(RVA = "0x3F60E38", Offset = "0x3F60E38", VA = "0x3F60E38")]
	public void TouchThis()
	{
	}

	[Token(Token = "0x6000306")]
	[Address(RVA = "0x3F60F20", Offset = "0x3F60F20", VA = "0x3F60F20")]
	private void DestroyDengLong()
	{
	}

	[Token(Token = "0x6000307")]
	[Address(RVA = "0x3F6100C", Offset = "0x3F6100C", VA = "0x3F6100C")]
	public KongMingDengLogic()
	{
	}

	[Token(Token = "0x6000308")]
	[Address(RVA = "0x3F61050", Offset = "0x3F61050", VA = "0x3F61050")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1251118", Offset = "0x1251118")]
	private void <TouchThis>b__4_0()
	{
	}

	[Token(Token = "0x6000309")]
	[Address(RVA = "0x3F61054", Offset = "0x3F61054", VA = "0x3F61054")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1251128", Offset = "0x1251128")]
	private void <DestroyDengLong>b__5_0()
	{
	}
}
[Token(Token = "0x20000A3")]
public class LastCameraPosLogic : MonoBehaviour
{
	[Token(Token = "0x600030A")]
	[Address(RVA = "0x3F610CC", Offset = "0x3F610CC", VA = "0x3F610CC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600030B")]
	[Address(RVA = "0x3F61188", Offset = "0x3F61188", VA = "0x3F61188")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600030C")]
	[Address(RVA = "0x3F61244", Offset = "0x3F61244", VA = "0x3F61244")]
	public LastCameraPosLogic()
	{
	}
}
[Token(Token = "0x20000A4")]
public class LiveInteractiveEffectController
{
	[Token(Token = "0x400037A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static List<GameObject> _triggeredGo;

	[Token(Token = "0x600030D")]
	[Address(RVA = "0x3F62FB8", Offset = "0x3F62FB8", VA = "0x3F62FB8")]
	public static void Start()
	{
	}

	[Token(Token = "0x600030E")]
	[Address(RVA = "0x3F630C0", Offset = "0x3F630C0", VA = "0x3F630C0")]
	public static void CleanUp()
	{
	}

	[Token(Token = "0x600030F")]
	[Address(RVA = "0x3F63224", Offset = "0x3F63224", VA = "0x3F63224")]
	private static void ColliderTriggerEnterHandler(GameObject targetGo, Collider cc)
	{
	}

	[Token(Token = "0x6000310")]
	[Address(RVA = "0x3F638D8", Offset = "0x3F638D8", VA = "0x3F638D8")]
	public LiveInteractiveEffectController()
	{
	}
}
[Token(Token = "0x20000A5")]
public class LoveLetterLogic : MonoBehaviour
{
	[Token(Token = "0x20000A6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124D6E0", Offset = "0x124D6E0")]
	private sealed class <DisableWord>d__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LoveLetterLogic <>4__this;

		[Token(Token = "0x17000041")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000319")]
			[Address(RVA = "0x310DC7C", Offset = "0x310DC7C", VA = "0x310DC7C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000042")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600031B")]
			[Address(RVA = "0x310DCC4", Offset = "0x310DCC4", VA = "0x310DCC4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x310DAE4", Offset = "0x310DAE4", VA = "0x310DAE4")]
		[DebuggerHidden]
		public <DisableWord>d__2(int <>1__state)
		{
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x310DB10", Offset = "0x310DB10", VA = "0x310DB10", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x310DB14", Offset = "0x310DB14", VA = "0x310DB14", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x310DC84", Offset = "0x310DC84", VA = "0x310DC84", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400037B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 loveLetterSize;

	[Token(Token = "0x6000312")]
	[Address(RVA = "0x3F63EF4", Offset = "0x3F63EF4", VA = "0x3F63EF4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000313")]
	[Address(RVA = "0x3F63F78", Offset = "0x3F63F78", VA = "0x3F63F78")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1251138", Offset = "0x1251138")]
	private IEnumerator DisableWord()
	{
		return null;
	}

	[Token(Token = "0x6000314")]
	[Address(RVA = "0x3F63FF0", Offset = "0x3F63FF0", VA = "0x3F63FF0")]
	public LoveLetterLogic()
	{
	}

	[Token(Token = "0x6000315")]
	[Address(RVA = "0x3F6400C", Offset = "0x3F6400C", VA = "0x3F6400C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1251198", Offset = "0x1251198")]
	private void <DisableWord>b__2_0()
	{
	}
}
[Token(Token = "0x20000A7")]
public class MoonLogic : MonoBehaviour
{
	[Token(Token = "0x400037F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform tr_Target;

	[Token(Token = "0x600031C")]
	[Address(RVA = "0x3F65ECC", Offset = "0x3F65ECC", VA = "0x3F65ECC")]
	private void Start()
	{
	}

	[Token(Token = "0x600031D")]
	[Address(RVA = "0x3F65ED0", Offset = "0x3F65ED0", VA = "0x3F65ED0")]
	private void Update()
	{
	}

	[Token(Token = "0x600031E")]
	[Address(RVA = "0x3F65F04", Offset = "0x3F65F04", VA = "0x3F65F04")]
	public MoonLogic()
	{
	}
}
[Token(Token = "0x20000A8")]
public class NuFangFlower : MonoBehaviour
{
	[Token(Token = "0x20000A9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124D6F0", Offset = "0x124D6F0")]
	private sealed class <PauseAnim>d__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public NuFangFlower <>4__this;

		[Token(Token = "0x17000043")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000329")]
			[Address(RVA = "0x310DDEC", Offset = "0x310DDEC", VA = "0x310DDEC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000044")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600032B")]
			[Address(RVA = "0x310DE34", Offset = "0x310DE34", VA = "0x310DE34", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x310DCDC", Offset = "0x310DCDC", VA = "0x310DCDC")]
		[DebuggerHidden]
		public <PauseAnim>d__3(int <>1__state)
		{
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x310DD08", Offset = "0x310DD08", VA = "0x310DD08", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x310DD0C", Offset = "0x310DD0C", VA = "0x310DD0C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x310DDF4", Offset = "0x310DDF4", VA = "0x310DDF4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000380")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ParticleSystem psFlowerExplosion;

	[Token(Token = "0x4000381")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Vector3 endScale;

	[Token(Token = "0x600031F")]
	[Address(RVA = "0x3F6B648", Offset = "0x3F6B648", VA = "0x3F6B648")]
	private void Start()
	{
	}

	[Token(Token = "0x6000320")]
	[Address(RVA = "0x3F6B6B8", Offset = "0x3F6B6B8", VA = "0x3F6B6B8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x12511F8", Offset = "0x12511F8")]
	private IEnumerator PauseAnim()
	{
		return null;
	}

	[Token(Token = "0x6000321")]
	[Address(RVA = "0x3F63868", Offset = "0x3F63868", VA = "0x3F63868")]
	public void TouchThis()
	{
	}

	[Token(Token = "0x6000322")]
	[Address(RVA = "0x3F6B7A4", Offset = "0x3F6B7A4", VA = "0x3F6B7A4")]
	private void DestroyFlower()
	{
	}

	[Token(Token = "0x6000323")]
	[Address(RVA = "0x3F6B64C", Offset = "0x3F6B64C", VA = "0x3F6B64C")]
	private void FlowerGrowUp()
	{
	}

	[Token(Token = "0x6000324")]
	[Address(RVA = "0x3F6B730", Offset = "0x3F6B730", VA = "0x3F6B730")]
	private void FlowerGrowDown()
	{
	}

	[Token(Token = "0x6000325")]
	[Address(RVA = "0x3F6B81C", Offset = "0x3F6B81C", VA = "0x3F6B81C")]
	public NuFangFlower()
	{
	}
}
[Token(Token = "0x20000AA")]
public class PaperPlane : MonoBehaviour
{
	[Token(Token = "0x20000AB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124D700", Offset = "0x124D700")]
	private sealed class <DestroyLoveLetter>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PaperPlane <>4__this;

		[Token(Token = "0x17000045")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000335")]
			[Address(RVA = "0x310DF48", Offset = "0x310DF48", VA = "0x310DF48", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000046")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000337")]
			[Address(RVA = "0x310DF90", Offset = "0x310DF90", VA = "0x310DF90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x310DE3C", Offset = "0x310DE3C", VA = "0x310DE3C")]
		[DebuggerHidden]
		public <DestroyLoveLetter>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x310DE68", Offset = "0x310DE68", VA = "0x310DE68", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x310DE6C", Offset = "0x310DE6C", VA = "0x310DE6C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x310DF50", Offset = "0x310DF50", VA = "0x310DF50", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000385")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject objQingShu;

	[Token(Token = "0x4000386")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Vector3[] vecPlaneEndPoints;

	[Token(Token = "0x4000387")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private GameObject objLoveLetter;

	[Token(Token = "0x600032C")]
	[Address(RVA = "0x3F6C89C", Offset = "0x3F6C89C", VA = "0x3F6C89C")]
	private void Start()
	{
	}

	[Token(Token = "0x600032D")]
	[Address(RVA = "0x3F6C8A0", Offset = "0x3F6C8A0", VA = "0x3F6C8A0")]
	public void FlyIn()
	{
	}

	[Token(Token = "0x600032E")]
	[Address(RVA = "0x3F6CB34", Offset = "0x3F6CB34", VA = "0x3F6CB34")]
	public void FlyToUser(Vector3 endPos)
	{
	}

	[Token(Token = "0x600032F")]
	[Address(RVA = "0x3F6CBCC", Offset = "0x3F6CBCC", VA = "0x3F6CBCC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x12512A8", Offset = "0x12512A8")]
	private IEnumerator DestroyLoveLetter()
	{
		return null;
	}

	[Token(Token = "0x6000330")]
	[Address(RVA = "0x3F6CC44", Offset = "0x3F6CC44", VA = "0x3F6CC44")]
	public PaperPlane()
	{
	}

	[Token(Token = "0x6000331")]
	[Address(RVA = "0x3F6CCAC", Offset = "0x3F6CCAC", VA = "0x3F6CCAC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1251308", Offset = "0x1251308")]
	private void <FlyIn>b__3_0()
	{
	}
}
[Token(Token = "0x20000AC")]
public class RotObject : MonoBehaviour
{
	[Token(Token = "0x400038B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector2 rotSpeedRange;

	[Token(Token = "0x400038C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Vector3 rotVec;

	[Token(Token = "0x400038D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private Vector3 curRot;

	[Token(Token = "0x400038E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float rotSpeed;

	[Token(Token = "0x400038F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public bool autoRot;

	[Token(Token = "0x6000338")]
	[Address(RVA = "0x2B4A7D4", Offset = "0x2B4A7D4", VA = "0x2B4A7D4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000339")]
	[Address(RVA = "0x2B4A860", Offset = "0x2B4A860", VA = "0x2B4A860")]
	private void Update()
	{
	}

	[Token(Token = "0x600033A")]
	[Address(RVA = "0x2B4A908", Offset = "0x2B4A908", VA = "0x2B4A908")]
	public RotObject()
	{
	}
}
[Token(Token = "0x20000AD")]
public class TestControlCubeEffect : MonoBehaviour
{
	[Token(Token = "0x4000390")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ControlCubeEffect cubeEffect;

	[Token(Token = "0x600033B")]
	[Address(RVA = "0x2B52B9C", Offset = "0x2B52B9C", VA = "0x2B52B9C")]
	private void Update()
	{
	}

	[Token(Token = "0x600033C")]
	[Address(RVA = "0x2B52C28", Offset = "0x2B52C28", VA = "0x2B52C28")]
	public TestControlCubeEffect()
	{
	}
}
[Token(Token = "0x20000AE")]
public class TestControlDoorEffect : MonoBehaviour
{
	[Token(Token = "0x4000391")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ControlDoorEffect doorEffect;

	[Token(Token = "0x600033D")]
	[Address(RVA = "0x2B52C30", Offset = "0x2B52C30", VA = "0x2B52C30")]
	private void Update()
	{
	}

	[Token(Token = "0x600033E")]
	[Address(RVA = "0x2B52CFC", Offset = "0x2B52CFC", VA = "0x2B52CFC")]
	public TestControlDoorEffect()
	{
	}
}
[Token(Token = "0x20000AF")]
public class TestControlZiMuEffect : MonoBehaviour
{
	[Token(Token = "0x4000392")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ControlZiMuEffect zimuEffect;

	[Token(Token = "0x600033F")]
	[Address(RVA = "0x2B52D04", Offset = "0x2B52D04", VA = "0x2B52D04")]
	private void Update()
	{
	}

	[Token(Token = "0x6000340")]
	[Address(RVA = "0x2B52D7C", Offset = "0x2B52D7C", VA = "0x2B52D7C")]
	public TestControlZiMuEffect()
	{
	}
}
[Token(Token = "0x20000B0")]
public class TLLAiMaHuo : TimelineLogic
{
	[Token(Token = "0x4000393")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private List<GameObject> doorEffects;

	[Token(Token = "0x6000341")]
	[Address(RVA = "0x2B506A4", Offset = "0x2B506A4", VA = "0x2B506A4", Slot = "5")]
	public override void InitTLLBasic()
	{
	}

	[Token(Token = "0x6000342")]
	[Address(RVA = "0x2B507E8", Offset = "0x2B507E8", VA = "0x2B507E8")]
	public void DoorShow()
	{
	}

	[Token(Token = "0x6000343")]
	[Address(RVA = "0x2B50910", Offset = "0x2B50910", VA = "0x2B50910")]
	public TLLAiMaHuo()
	{
	}
}
[Token(Token = "0x20000B1")]
public class TLLChangAnChangAn : TimelineLogic
{
	[Token(Token = "0x4000394")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ParticleSystem psFireWorksEffect;

	[Token(Token = "0x4000395")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public HousesWireframeGrowup[] housesWireframeGrowups;

	[Token(Token = "0x4000396")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public KongMingDengLogic[] kongMingDeng;

	[Token(Token = "0x6000344")]
	[Address(RVA = "0x2B50920", Offset = "0x2B50920", VA = "0x2B50920")]
	public void PlayFireWorksEffect()
	{
	}

	[Token(Token = "0x6000345")]
	[Address(RVA = "0x2B5093C", Offset = "0x2B5093C", VA = "0x2B5093C")]
	public void DengLongShow()
	{
	}

	[Token(Token = "0x6000346")]
	[Address(RVA = "0x2B50A1C", Offset = "0x2B50A1C", VA = "0x2B50A1C")]
	public void DengLongFly()
	{
	}

	[Token(Token = "0x6000347")]
	[Address(RVA = "0x2B50AFC", Offset = "0x2B50AFC", VA = "0x2B50AFC")]
	public void DestroyDengLong()
	{
	}

	[Token(Token = "0x6000348")]
	[Address(RVA = "0x2B50C04", Offset = "0x2B50C04", VA = "0x2B50C04")]
	public void ShowBuildingToWirefream(int AreaID)
	{
	}

	[Token(Token = "0x6000349")]
	[Address(RVA = "0x2B50C4C", Offset = "0x2B50C4C", VA = "0x2B50C4C")]
	public void ShowBuildingToBase(int AreaID)
	{
	}

	[Token(Token = "0x600034A")]
	[Address(RVA = "0x2B50C94", Offset = "0x2B50C94", VA = "0x2B50C94")]
	public TLLChangAnChangAn()
	{
	}
}
[Token(Token = "0x20000B2")]
public class TLLChiLuoLuo : TimelineLogic
{
	[Token(Token = "0x20000B3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124D710", Offset = "0x124D710")]
	private sealed class <>c__DisplayClass13_0
	{
		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color tempColor;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Material material;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TLLChiLuoLuo <>4__this;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float toValue;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float fromValue;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float duration;

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x310F758", Offset = "0x310F758", VA = "0x310F758")]
		public <>c__DisplayClass13_0()
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x310F760", Offset = "0x310F760", VA = "0x310F760")]
		internal Color <SparkRedColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x310F76C", Offset = "0x310F76C", VA = "0x310F76C")]
		internal void <SparkRedColor>b__1(Color x)
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x310F778", Offset = "0x310F778", VA = "0x310F778")]
		internal void <SparkRedColor>b__2()
		{
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x310F7D8", Offset = "0x310F7D8", VA = "0x310F7D8")]
		internal void <SparkRedColor>b__3()
		{
		}
	}

	[Token(Token = "0x20000B4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124D720", Offset = "0x124D720")]
	private sealed class <>c__DisplayClass14_0
	{
		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color tempColor;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Material material;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TLLChiLuoLuo <>4__this;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float toValue;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float fromValue;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float duration;

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x310F804", Offset = "0x310F804", VA = "0x310F804")]
		public <>c__DisplayClass14_0()
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x310F80C", Offset = "0x310F80C", VA = "0x310F80C")]
		internal Color <SparkWhiteColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x310F818", Offset = "0x310F818", VA = "0x310F818")]
		internal void <SparkWhiteColor>b__1(Color x)
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x310F824", Offset = "0x310F824", VA = "0x310F824")]
		internal void <SparkWhiteColor>b__2()
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x310F884", Offset = "0x310F884", VA = "0x310F884")]
		internal void <SparkWhiteColor>b__3()
		{
		}
	}

	[Token(Token = "0x4000397")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ParticleSystem psFireWorksEffect;

	[Token(Token = "0x4000398")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private CubeLogic[] cubeEffects;

	[Token(Token = "0x4000399")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private GameObject[] tempCubes;

	[Token(Token = "0x400039A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Vector3[] explosionPos;

	[Token(Token = "0x400039B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float showCubeDuration;

	[Token(Token = "0x600034B")]
	[Address(RVA = "0x2B50C9C", Offset = "0x2B50C9C", VA = "0x2B50C9C", Slot = "5")]
	public override void InitTLLBasic()
	{
	}

	[Token(Token = "0x600034C")]
	[Address(RVA = "0x2B50E30", Offset = "0x2B50E30", VA = "0x2B50E30")]
	public void PlayFireWorksEffect()
	{
	}

	[Token(Token = "0x600034D")]
	[Address(RVA = "0x2B50E4C", Offset = "0x2B50E4C", VA = "0x2B50E4C")]
	public void ShowCube()
	{
	}

	[Token(Token = "0x600034E")]
	[Address(RVA = "0x2B50EB8", Offset = "0x2B50EB8", VA = "0x2B50EB8")]
	public void WhiteCubeSpark()
	{
	}

	[Token(Token = "0x600034F")]
	[Address(RVA = "0x2B50F24", Offset = "0x2B50F24", VA = "0x2B50F24")]
	public void WhiteCubeSparkToRed()
	{
	}

	[Token(Token = "0x6000350")]
	[Address(RVA = "0x2B50F50", Offset = "0x2B50F50", VA = "0x2B50F50")]
	public void RedCubeSpark()
	{
	}

	[Token(Token = "0x6000351")]
	[Address(RVA = "0x2B512C8", Offset = "0x2B512C8", VA = "0x2B512C8")]
	public void CubeExplosion()
	{
	}

	[Token(Token = "0x6000352")]
	[Address(RVA = "0x2B51404", Offset = "0x2B51404", VA = "0x2B51404")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000353")]
	[Address(RVA = "0x2B514C4", Offset = "0x2B514C4", VA = "0x2B514C4")]
	public void SparkRedColor(float fromValue, float toValue, float duration, Material material)
	{
	}

	[Token(Token = "0x6000354")]
	[Address(RVA = "0x2B51040", Offset = "0x2B51040", VA = "0x2B51040")]
	public void SparkWhiteColor(float fromValue, float toValue, float duration, Material material)
	{
	}

	[Token(Token = "0x6000355")]
	[Address(RVA = "0x2B5174C", Offset = "0x2B5174C", VA = "0x2B5174C")]
	public TLLChiLuoLuo()
	{
	}
}
[Token(Token = "0x20000B5")]
public class TLLDiKongFeiXing : TimelineLogic
{
	[Token(Token = "0x40003A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject objWord;

	[Token(Token = "0x6000360")]
	[Address(RVA = "0x2B5175C", Offset = "0x2B5175C", VA = "0x2B5175C", Slot = "5")]
	public override void InitTLLBasic()
	{
	}

	[Token(Token = "0x6000361")]
	[Address(RVA = "0x2B51760", Offset = "0x2B51760", VA = "0x2B51760")]
	public void FlyStart()
	{
	}

	[Token(Token = "0x6000362")]
	[Address(RVA = "0x2B51780", Offset = "0x2B51780", VA = "0x2B51780")]
	public void FlySlow()
	{
	}

	[Token(Token = "0x6000363")]
	[Address(RVA = "0x2B517A0", Offset = "0x2B517A0", VA = "0x2B517A0")]
	public TLLDiKongFeiXing()
	{
	}
}
[Token(Token = "0x20000B6")]
public class TLLHuiGuiNiang : TimelineLogic
{
	[Token(Token = "0x40003A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject[] objFontsLeft;

	[Token(Token = "0x40003AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject[] objFontsRight;

	[Token(Token = "0x40003AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject[] objFontsBack;

	[Token(Token = "0x6000364")]
	[Address(RVA = "0x2B517A8", Offset = "0x2B517A8", VA = "0x2B517A8")]
	public void WrongFontShow()
	{
	}

	[Token(Token = "0x6000365")]
	[Address(RVA = "0x2B517AC", Offset = "0x2B517AC", VA = "0x2B517AC")]
	public void ShowLeftFonts()
	{
	}

	[Token(Token = "0x6000366")]
	[Address(RVA = "0x2B51854", Offset = "0x2B51854", VA = "0x2B51854")]
	public void ShowRightFonts()
	{
	}

	[Token(Token = "0x6000367")]
	[Address(RVA = "0x2B518FC", Offset = "0x2B518FC", VA = "0x2B518FC")]
	public void WrongFontCombine()
	{
	}

	[Token(Token = "0x6000368")]
	[Address(RVA = "0x2B519A4", Offset = "0x2B519A4", VA = "0x2B519A4")]
	public void HeartWrongFont()
	{
	}

	[Token(Token = "0x6000369")]
	[Address(RVA = "0x2B519A8", Offset = "0x2B519A8", VA = "0x2B519A8")]
	public TLLHuiGuiNiang()
	{
	}
}
[Token(Token = "0x20000B7")]
public class TLLJiXuHuiWu : TimelineLogic
{
	[Token(Token = "0x40003AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ParticleSystem[] psFireWorksEffect;

	[Token(Token = "0x40003AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ParticleSystem ps_KongMingDeng;

	[Token(Token = "0x40003AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private ParticleSystem.MainModule psKongMingDengMain;

	[Token(Token = "0x40003AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private ParticleSystem.EmissionModule psKongMingDengEmission;

	[Token(Token = "0x40003B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private int reduceNum;

	[Token(Token = "0x600036A")]
	[Address(RVA = "0x2B519B0", Offset = "0x2B519B0", VA = "0x2B519B0", Slot = "5")]
	public override void InitTLLBasic()
	{
	}

	[Token(Token = "0x600036B")]
	[Address(RVA = "0x2B51A10", Offset = "0x2B51A10", VA = "0x2B51A10")]
	public void EnableKongMingDeng()
	{
	}

	[Token(Token = "0x600036C")]
	[Address(RVA = "0x2B51A2C", Offset = "0x2B51A2C", VA = "0x2B51A2C")]
	public void KongMingDengReduce()
	{
	}

	[Token(Token = "0x600036D")]
	[Address(RVA = "0x2B51AAC", Offset = "0x2B51AAC", VA = "0x2B51AAC")]
	public void DisableKongMingDeng()
	{
	}

	[Token(Token = "0x600036E")]
	[Address(RVA = "0x2B51AC8", Offset = "0x2B51AC8", VA = "0x2B51AC8")]
	public void RotateCircle()
	{
	}

	[Token(Token = "0x600036F")]
	[Address(RVA = "0x2B51ACC", Offset = "0x2B51ACC", VA = "0x2B51ACC")]
	public void PlayFireWorksEffect()
	{
	}

	[Token(Token = "0x6000370")]
	[Address(RVA = "0x2B51B38", Offset = "0x2B51B38", VA = "0x2B51B38")]
	public TLLJiXuHuiWu()
	{
	}
}
[Token(Token = "0x20000B8")]
public class TLLMeteor : TimelineLogic
{
	[Token(Token = "0x40003B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject objMeteor;

	[Token(Token = "0x40003B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ParticleSystem.EmissionModule psMeteorMain;

	[Token(Token = "0x6000371")]
	[Address(RVA = "0x2B51B48", Offset = "0x2B51B48", VA = "0x2B51B48")]
	public void PlayMeteorEffect()
	{
	}

	[Token(Token = "0x6000372")]
	[Address(RVA = "0x2B51CA4", Offset = "0x2B51CA4", VA = "0x2B51CA4")]
	public void MeteorAdd()
	{
	}

	[Token(Token = "0x6000373")]
	[Address(RVA = "0x2B51CF0", Offset = "0x2B51CF0", VA = "0x2B51CF0")]
	public void MeteorRain()
	{
	}

	[Token(Token = "0x6000374")]
	[Address(RVA = "0x2B51D3C", Offset = "0x2B51D3C", VA = "0x2B51D3C")]
	public void MeteorReduce()
	{
	}

	[Token(Token = "0x6000375")]
	[Address(RVA = "0x2B51D88", Offset = "0x2B51D88", VA = "0x2B51D88")]
	public void StopMeteorEffect()
	{
	}

	[Token(Token = "0x6000376")]
	[Address(RVA = "0x2B51DD4", Offset = "0x2B51DD4", VA = "0x2B51DD4")]
	public TLLMeteor()
	{
	}
}
[Token(Token = "0x20000B9")]
public class TLLNuFang : TimelineLogic
{
	[Token(Token = "0x40003B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject[] objFlowers;

	[Token(Token = "0x6000377")]
	[Address(RVA = "0x2B51DDC", Offset = "0x2B51DDC", VA = "0x2B51DDC", Slot = "5")]
	public override void InitTLLBasic()
	{
	}

	[Token(Token = "0x6000378")]
	[Address(RVA = "0x2B51DE0", Offset = "0x2B51DE0", VA = "0x2B51DE0")]
	public void SpawnFlower()
	{
	}

	[Token(Token = "0x6000379")]
	[Address(RVA = "0x2B51E50", Offset = "0x2B51E50", VA = "0x2B51E50")]
	public void FlowerGone()
	{
	}

	[Token(Token = "0x600037A")]
	[Address(RVA = "0x2B51F50", Offset = "0x2B51F50", VA = "0x2B51F50")]
	public TLLNuFang()
	{
	}
}
[Token(Token = "0x20000BA")]
public class TLLQingChunDeZangLi : TimelineLogic
{
	[Token(Token = "0x40003B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject objPaplePlane;

	[Token(Token = "0x40003B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public int lessPlaneNum;

	[Token(Token = "0x40003B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public int morePlaneNum;

	[Token(Token = "0x40003B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private GameObject[] objQingShu;

	[Token(Token = "0x40003B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public ParticleSystem ps_PaperPlane;

	[Token(Token = "0x40003B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private int curPlaneID;

	[Token(Token = "0x600037B")]
	[Address(RVA = "0x2B51F58", Offset = "0x2B51F58", VA = "0x2B51F58", Slot = "4")]
	public override void InitTLL()
	{
	}

	[Token(Token = "0x600037C")]
	[Address(RVA = "0x2B52084", Offset = "0x2B52084", VA = "0x2B52084")]
	public void FlyIn()
	{
	}

	[Token(Token = "0x600037D")]
	[Address(RVA = "0x2B520DC", Offset = "0x2B520DC", VA = "0x2B520DC")]
	public void FlyInMore(int airplaneNum)
	{
	}

	[Token(Token = "0x600037E")]
	[Address(RVA = "0x2B52180", Offset = "0x2B52180", VA = "0x2B52180")]
	public void FlyToUser()
	{
	}

	[Token(Token = "0x600037F")]
	[Address(RVA = "0x2B52224", Offset = "0x2B52224", VA = "0x2B52224")]
	private void AirplaneAutoFly()
	{
	}

	[Token(Token = "0x6000380")]
	[Address(RVA = "0x2B522A0", Offset = "0x2B522A0", VA = "0x2B522A0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000381")]
	[Address(RVA = "0x2B522B0", Offset = "0x2B522B0", VA = "0x2B522B0")]
	public TLLQingChunDeZangLi()
	{
	}
}
[Token(Token = "0x20000BB")]
public class TLL_Begine : TimelineLogic
{
	[Token(Token = "0x6000382")]
	[Address(RVA = "0x2B522C4", Offset = "0x2B522C4", VA = "0x2B522C4")]
	public TLL_Begine()
	{
	}
}
[Token(Token = "0x20000BC")]
public class TLL_SiBen : TimelineLogic
{
	[Token(Token = "0x6000383")]
	[Address(RVA = "0x2B522CC", Offset = "0x2B522CC", VA = "0x2B522CC")]
	public TLL_SiBen()
	{
	}
}
[Token(Token = "0x20000BD")]
public class TimelineLogic : MonoBehaviour
{
	[Token(Token = "0x40003BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private GameObject Camera4PosObject;

	[Token(Token = "0x40003BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private PlayableDirector playableDirector;

	[Token(Token = "0x40003BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private GameObject[] objCircles;

	[Token(Token = "0x40003BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected GameObject[] objPicoPos;

	[Token(Token = "0x40003BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private RotObject[] AllRotCircles;

	[Token(Token = "0x6000384")]
	[Address(RVA = "0x2B53C44", Offset = "0x2B53C44", VA = "0x2B53C44")]
	private void Start()
	{
	}

	[Token(Token = "0x6000385")]
	[Address(RVA = "0x2B53D88", Offset = "0x2B53D88", VA = "0x2B53D88")]
	private void InitCamera4PosObject()
	{
	}

	[Token(Token = "0x6000386")]
	[Address(RVA = "0x2B53EA8", Offset = "0x2B53EA8", VA = "0x2B53EA8")]
	public void EnableCamera4PosObject(bool enableCamera4PosObject)
	{
	}

	[Token(Token = "0x6000387")]
	[Address(RVA = "0x2B53EC8", Offset = "0x2B53EC8", VA = "0x2B53EC8")]
	public void OffsetPlayableDirector(float offset)
	{
	}

	[Token(Token = "0x6000388")]
	[Address(RVA = "0x2B5403C", Offset = "0x2B5403C", VA = "0x2B5403C")]
	private void DetectOffsetEvent()
	{
	}

	[Token(Token = "0x6000389")]
	[Address(RVA = "0x2B54150", Offset = "0x2B54150", VA = "0x2B54150")]
	private void GetAllRotCircle()
	{
	}

	[Token(Token = "0x600038A")]
	[Address(RVA = "0x2B541E8", Offset = "0x2B541E8", VA = "0x2B541E8")]
	public void StartRotateCircle()
	{
	}

	[Token(Token = "0x600038B")]
	[Address(RVA = "0x2B54258", Offset = "0x2B54258", VA = "0x2B54258")]
	public void StopRotateCircle()
	{
	}

	[Token(Token = "0x600038C")]
	[Address(RVA = "0x2B542C4", Offset = "0x2B542C4", VA = "0x2B542C4")]
	public void CircleRot()
	{
	}

	[Token(Token = "0x600038D")]
	[Address(RVA = "0x2B54440", Offset = "0x2B54440", VA = "0x2B54440")]
	public void CircleRotStop()
	{
	}

	[Token(Token = "0x600038E")]
	[Address(RVA = "0x2B52080", Offset = "0x2B52080", VA = "0x2B52080", Slot = "4")]
	public virtual void InitTLL()
	{
	}

	[Token(Token = "0x600038F")]
	[Address(RVA = "0x2B507E4", Offset = "0x2B507E4", VA = "0x2B507E4", Slot = "5")]
	public virtual void InitTLLBasic()
	{
	}

	[Token(Token = "0x6000390")]
	[Address(RVA = "0x2B50918", Offset = "0x2B50918", VA = "0x2B50918")]
	public TimelineLogic()
	{
	}
}
[Token(Token = "0x20000BE")]
public class WireframeGrowUp : MonoBehaviour
{
	[Token(Token = "0x40003BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject obj;

	[Token(Token = "0x40003C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Texture2D uv_Tex;

	[Token(Token = "0x40003C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private GameObject tempObj;

	[Token(Token = "0x40003C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Color LineColor;

	[Token(Token = "0x40003C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float LineColorIntensity;

	[Token(Token = "0x40003C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Material wireMat;

	[Token(Token = "0x40003C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float stage1Time;

	[Token(Token = "0x40003C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float stage2Time;

	[Token(Token = "0x40003C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public float stage3Time;

	[Token(Token = "0x40003C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public bool animStart;

	[Token(Token = "0x40003C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
	public bool breakPause;

	[Token(Token = "0x40003CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Shader extendLitShader;

	[Token(Token = "0x40003CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private float stagePauseTime;

	[Token(Token = "0x40003CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private float animStartTime;

	[Token(Token = "0x40003CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private bool doonce;

	[Token(Token = "0x40003CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
	private bool stage2DoOnce;

	[Token(Token = "0x40003CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x72")]
	private bool stage3DoOnce;

	[Token(Token = "0x40003D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private Vector4 emissionColor;

	[Token(Token = "0x40003D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private Color newCol;

	[Token(Token = "0x6000391")]
	[Address(RVA = "0x2B597FC", Offset = "0x2B597FC", VA = "0x2B597FC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000392")]
	[Address(RVA = "0x2B598A0", Offset = "0x2B598A0", VA = "0x2B598A0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000393")]
	[Address(RVA = "0x2B59F1C", Offset = "0x2B59F1C", VA = "0x2B59F1C")]
	private void DoStage1()
	{
	}

	[Token(Token = "0x6000394")]
	[Address(RVA = "0x2B5A14C", Offset = "0x2B5A14C", VA = "0x2B5A14C")]
	private void DoStage2()
	{
	}

	[Token(Token = "0x6000395")]
	[Address(RVA = "0x2B5A534", Offset = "0x2B5A534", VA = "0x2B5A534")]
	private void DoStage3()
	{
	}

	[Token(Token = "0x6000396")]
	[Address(RVA = "0x2B5A710", Offset = "0x2B5A710", VA = "0x2B5A710")]
	private void DoStagePause()
	{
	}

	[Token(Token = "0x6000397")]
	[Address(RVA = "0x2B59B60", Offset = "0x2B59B60", VA = "0x2B59B60")]
	private void MatAnimation()
	{
	}

	[Token(Token = "0x6000398")]
	[Address(RVA = "0x2B5A754", Offset = "0x2B5A754", VA = "0x2B5A754")]
	public void ContinueAnimation()
	{
	}

	[Token(Token = "0x6000399")]
	[Address(RVA = "0x2B598E0", Offset = "0x2B598E0", VA = "0x2B598E0")]
	public void StartAnimation()
	{
	}

	[Token(Token = "0x600039A")]
	[Address(RVA = "0x2B5A878", Offset = "0x2B5A878", VA = "0x2B5A878")]
	public WireframeGrowUp()
	{
	}
}
[Token(Token = "0x20000BF")]
public class ZimuControl : MonoBehaviour
{
	[Token(Token = "0x40003D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Vector3 startPos;

	[Token(Token = "0x40003D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private Vector3 endPos;

	[Token(Token = "0x40003D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float duration;

	[Token(Token = "0x40003D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private TextMeshProUGUI textPlane;

	[Token(Token = "0x40003D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float nowTime;

	[Token(Token = "0x40003D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private ZimuManager mgr;

	[Token(Token = "0x600039B")]
	[Address(RVA = "0x3106D84", Offset = "0x3106D84", VA = "0x3106D84")]
	private void Awake()
	{
	}

	[Token(Token = "0x600039C")]
	[Address(RVA = "0x3106E08", Offset = "0x3106E08", VA = "0x3106E08")]
	public void SetText(string text)
	{
	}

	[Token(Token = "0x600039D")]
	[Address(RVA = "0x3106E2C", Offset = "0x3106E2C", VA = "0x3106E2C")]
	public void Play(Vector3 start, Vector3 end, float d, ZimuManager mgr)
	{
	}

	[Token(Token = "0x600039E")]
	[Address(RVA = "0x3106F38", Offset = "0x3106F38", VA = "0x3106F38")]
	public void Play(float d, ZimuManager mgr)
	{
	}

	[Token(Token = "0x600039F")]
	[Address(RVA = "0x3106F9C", Offset = "0x3106F9C", VA = "0x3106F9C")]
	private void Update()
	{
	}

	[Token(Token = "0x60003A0")]
	[Address(RVA = "0x3107100", Offset = "0x3107100", VA = "0x3107100")]
	public ZimuControl()
	{
	}
}
[Token(Token = "0x20000C0")]
public class ZimuManager : MonoBehaviour
{
	[Token(Token = "0x40003D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject ZimuPrefab;

	[Token(Token = "0x40003D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector3 startCenter;

	[Token(Token = "0x40003DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float startRadius;

	[Token(Token = "0x40003DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector3 endCenter;

	[Token(Token = "0x40003DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float endRadius;

	[Token(Token = "0x40003DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float emitTime;

	[Token(Token = "0x40003DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public int emitCount;

	[Token(Token = "0x40003DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float Speed;

	[Token(Token = "0x40003E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public string[] zimuTextList;

	[Token(Token = "0x40003E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float nowTime;

	[Token(Token = "0x40003E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Queue<ZimuControl> zimuPool;

	[Token(Token = "0x40003E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static int InitPoolCount;

	[Token(Token = "0x40003E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private GameObject[] objZiMuPos;

	[Token(Token = "0x40003E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private List<Transform> TempRandomPos;

	[Token(Token = "0x40003E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private List<GameObject> tempPosArray;

	[Token(Token = "0x60003A1")]
	[Address(RVA = "0x3107110", Offset = "0x3107110", VA = "0x3107110")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003A2")]
	[Address(RVA = "0x310734C", Offset = "0x310734C", VA = "0x310734C")]
	private GameObject[] GetZiMuPos()
	{
		return null;
	}

	[Token(Token = "0x60003A3")]
	[Address(RVA = "0x31072F8", Offset = "0x31072F8", VA = "0x31072F8")]
	private string GetText()
	{
		return null;
	}

	[Token(Token = "0x60003A4")]
	[Address(RVA = "0x31073B8", Offset = "0x31073B8", VA = "0x31073B8")]
	private ZimuControl GetZimu()
	{
		return null;
	}

	[Token(Token = "0x60003A5")]
	[Address(RVA = "0x310709C", Offset = "0x310709C", VA = "0x310709C")]
	public void RecycleZimu(ZimuControl zimu)
	{
	}

	[Token(Token = "0x60003A6")]
	[Address(RVA = "0x3107510", Offset = "0x3107510", VA = "0x3107510")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60003A7")]
	[Address(RVA = "0x310751C", Offset = "0x310751C", VA = "0x310751C")]
	private void ResetTempRandomPos()
	{
	}

	[Token(Token = "0x60003A8")]
	[Address(RVA = "0x3107714", Offset = "0x3107714", VA = "0x3107714")]
	public void StopEmit()
	{
	}

	[Token(Token = "0x60003A9")]
	[Address(RVA = "0x3107774", Offset = "0x3107774", VA = "0x3107774")]
	private void DisableZiMu()
	{
	}

	[Token(Token = "0x60003AA")]
	[Address(RVA = "0x310779C", Offset = "0x310779C", VA = "0x310779C")]
	private void Update()
	{
	}

	[Token(Token = "0x60003AB")]
	[Address(RVA = "0x3107938", Offset = "0x3107938", VA = "0x3107938")]
	public ZimuManager()
	{
	}
}
[Token(Token = "0x20000C1")]
public class SwarpPosition : MonoBehaviour
{
	[Token(Token = "0x40003E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private GameObject obj_XR_Rig;

	[Token(Token = "0x40003E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject[] obj_Positions;

	[Token(Token = "0x40003E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string[] str_MediaPlayerPath;

	[Token(Token = "0x40003EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int curPosID;

	[Token(Token = "0x40003EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private bool primaryButtonDown;

	[Token(Token = "0x60003AD")]
	[Address(RVA = "0x2B503D8", Offset = "0x2B503D8", VA = "0x2B503D8")]
	private void Start()
	{
	}

	[Token(Token = "0x60003AE")]
	[Address(RVA = "0x2B50464", Offset = "0x2B50464", VA = "0x2B50464")]
	private void Update()
	{
	}

	[Token(Token = "0x60003AF")]
	[Address(RVA = "0x2B50468", Offset = "0x2B50468", VA = "0x2B50468")]
	private void SwarpAreaDetect()
	{
	}

	[Token(Token = "0x60003B0")]
	[Address(RVA = "0x2B505B4", Offset = "0x2B505B4", VA = "0x2B505B4")]
	private void SwarpArea()
	{
	}

	[Token(Token = "0x60003B1")]
	[Address(RVA = "0x2B50618", Offset = "0x2B50618", VA = "0x2B50618")]
	private void SwarpXRRigPos()
	{
	}

	[Token(Token = "0x60003B2")]
	[Address(RVA = "0x2B50614", Offset = "0x2B50614", VA = "0x2B50614")]
	private void SwarpMedia()
	{
	}

	[Token(Token = "0x60003B3")]
	[Address(RVA = "0x2B5069C", Offset = "0x2B5069C", VA = "0x2B5069C")]
	public SwarpPosition()
	{
	}
}
[Token(Token = "0x20000C2")]
public class ZJVRMain : MonoBehaviour
{
	[Token(Token = "0x20000C3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124D730", Offset = "0x124D730")]
	private sealed class <processChangeScene>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int level;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ZJVRMain <>4__this;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <time>5__2;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private UniversalAdditionalCameraData <camData>5__3;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private LoadingInfo <loadingInfo>5__4;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private LoadingInfo <info>5__5;

		[Token(Token = "0x17000047")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003C7")]
			[Address(RVA = "0x3111AB0", Offset = "0x3111AB0", VA = "0x3111AB0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000048")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003C9")]
			[Address(RVA = "0x3111AF8", Offset = "0x3111AF8", VA = "0x3111AF8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x3111210", Offset = "0x3111210", VA = "0x3111210")]
		[DebuggerHidden]
		public <processChangeScene>d__23(int <>1__state)
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x311123C", Offset = "0x311123C", VA = "0x311123C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x3111240", Offset = "0x3111240", VA = "0x3111240", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x3111AB8", Offset = "0x3111AB8", VA = "0x3111AB8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40003EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static ZJVRMain instance;

	[Token(Token = "0x40003ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string[] LevelName;

	[Token(Token = "0x40003EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Material[] mat_SkyBoxs;

	[Token(Token = "0x40003EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int curLevelID;

	[Token(Token = "0x40003F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private bool secondaryButtonDown;

	[Token(Token = "0x40003F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Material _cacheSkyBox;

	[Token(Token = "0x40003F2")]
	private const string SCENE_BASE_PATH = "Standard/Zhengjun/Scenes";

	[Token(Token = "0x40003F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private GameObject[] objStageFloors;

	[Token(Token = "0x40003F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private List<GameObject> _cacheEffectsGo;

	[Token(Token = "0x40003F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool _isForTest;

	[Token(Token = "0x40003F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private int _myTest;

	[Token(Token = "0x40003F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private string nowScene;

	[Token(Token = "0x40003F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private AsyncOperation op;

	[Token(Token = "0x40003F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool sceneChanging;

	[Token(Token = "0x40003FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Volume blendVolume;

	[Token(Token = "0x40003FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float blendTime;

	[Token(Token = "0x40003FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private List<GameObject> tempSpawnObjects;

	[Token(Token = "0x60003B4")]
	[Address(RVA = "0x2B5B820", Offset = "0x2B5B820", VA = "0x2B5B820")]
	public void OnPushEffectsGo(GameObject go)
	{
	}

	[Token(Token = "0x60003B5")]
	[Address(RVA = "0x2B5B8C0", Offset = "0x2B5B8C0", VA = "0x2B5B8C0")]
	private void DestroyEffectsGo()
	{
	}

	[Token(Token = "0x60003B6")]
	[Address(RVA = "0x2B50610", Offset = "0x2B50610", VA = "0x2B50610")]
	public void SwarpLed(int id)
	{
	}

	[Token(Token = "0x60003B7")]
	[Address(RVA = "0x2B5BA14", Offset = "0x2B5BA14", VA = "0x2B5BA14")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003B8")]
	[Address(RVA = "0x2B5BA68", Offset = "0x2B5BA68", VA = "0x2B5BA68")]
	private void Start()
	{
	}

	[Token(Token = "0x60003B9")]
	[Address(RVA = "0x2B5BD5C", Offset = "0x2B5BD5C", VA = "0x2B5BD5C")]
	private void Update()
	{
	}

	[Token(Token = "0x60003BA")]
	[Address(RVA = "0x2B5BD6C", Offset = "0x2B5BD6C", VA = "0x2B5BD6C")]
	private void SwarpSceneDetect()
	{
	}

	[Token(Token = "0x60003BB")]
	[Address(RVA = "0x2B5BE48", Offset = "0x2B5BE48", VA = "0x2B5BE48")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1251368", Offset = "0x1251368")]
	private IEnumerator processChangeScene(int level)
	{
		return null;
	}

	[Token(Token = "0x60003BC")]
	[Address(RVA = "0x2B5BBD8", Offset = "0x2B5BBD8", VA = "0x2B5BBD8")]
	public void SwarpLevel(int level = -1)
	{
	}

	[Token(Token = "0x60003BD")]
	[Address(RVA = "0x2B5BED0", Offset = "0x2B5BED0", VA = "0x2B5BED0")]
	private void SwarpSkybox()
	{
	}

	[Token(Token = "0x60003BE")]
	[Address(RVA = "0x2B5BF18", Offset = "0x2B5BF18", VA = "0x2B5BF18")]
	private void SwarpStageFloorMat()
	{
	}

	[Token(Token = "0x60003BF")]
	[Address(RVA = "0x2B5A760", Offset = "0x2B5A760", VA = "0x2B5A760")]
	public GameObject CusSpawnGameObject(GameObject objToSpawn, Vector3 pos, Quaternion rot)
	{
		return null;
	}

	[Token(Token = "0x60003C0")]
	[Address(RVA = "0x2B5BF1C", Offset = "0x2B5BF1C", VA = "0x2B5BF1C")]
	public GameObject CusSpawnGameObject(GameObject objToSpawn)
	{
		return null;
	}

	[Token(Token = "0x60003C1")]
	[Address(RVA = "0x2B5BFE8", Offset = "0x2B5BFE8", VA = "0x2B5BFE8")]
	private void DestroyAllTempGameobject()
	{
	}

	[Token(Token = "0x60003C2")]
	[Address(RVA = "0x2B5C110", Offset = "0x2B5C110", VA = "0x2B5C110")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60003C3")]
	[Address(RVA = "0x2B5C1B4", Offset = "0x2B5C1B4", VA = "0x2B5C1B4")]
	public ZJVRMain()
	{
	}
}
[Token(Token = "0x20000C4")]
public class ZhengjunDefine
{
	[Token(Token = "0x4000405")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static string ZhengjunLiveBasePath;

	[Token(Token = "0x60003CA")]
	[Address(RVA = "0x3106D18", Offset = "0x3106D18", VA = "0x3106D18")]
	public ZhengjunDefine()
	{
	}
}
[Token(Token = "0x20000C5")]
public class XiaohunerBehavior : MonoBehaviour
{
	[Token(Token = "0x20000C6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124D740", Offset = "0x124D740")]
	private sealed class <UpdateTexture>d__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public XiaohunerBehavior <>4__this;

		[Token(Token = "0x17000049")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003D5")]
			[Address(RVA = "0x31111C0", Offset = "0x31111C0", VA = "0x31111C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003D7")]
			[Address(RVA = "0x3111208", Offset = "0x3111208", VA = "0x3111208", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x3110FF0", Offset = "0x3110FF0", VA = "0x3110FF0")]
		[DebuggerHidden]
		public <UpdateTexture>d__11(int <>1__state)
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x311101C", Offset = "0x311101C", VA = "0x311101C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x3111020", Offset = "0x3111020", VA = "0x3111020", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x31111C8", Offset = "0x31111C8", VA = "0x31111C8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000406")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Texture2D TextureZY;

	[Token(Token = "0x4000407")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Texture2D TextureBY;

	[Token(Token = "0x4000408")]
	private const string BASEMAP = "_BaseMap";

	[Token(Token = "0x4000409")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Material m_bodyMaterial;

	[Token(Token = "0x400040A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool m_flag;

	[Token(Token = "0x400040B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private WaitForSeconds m_intervalBY;

	[Token(Token = "0x400040C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Coroutine m_CRUpdateTexture;

	[Token(Token = "0x60003CC")]
	[Address(RVA = "0x2B5AAF8", Offset = "0x2B5AAF8", VA = "0x2B5AAF8")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003CD")]
	[Address(RVA = "0x2B5AC30", Offset = "0x2B5AC30", VA = "0x2B5AC30")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60003CE")]
	[Address(RVA = "0x2B5AD10", Offset = "0x2B5AD10", VA = "0x2B5AD10")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60003CF")]
	[Address(RVA = "0x2B5AD58", Offset = "0x2B5AD58", VA = "0x2B5AD58")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60003D0")]
	[Address(RVA = "0x2B5AC98", Offset = "0x2B5AC98", VA = "0x2B5AC98")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1251418", Offset = "0x1251418")]
	private IEnumerator UpdateTexture()
	{
		return null;
	}

	[Token(Token = "0x60003D1")]
	[Address(RVA = "0x2B5ADA0", Offset = "0x2B5ADA0", VA = "0x2B5ADA0")]
	public XiaohunerBehavior()
	{
	}
}
[Token(Token = "0x20000C7")]
public class Test : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20000C8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124D750", Offset = "0x124D750")]
	private sealed class <>c
	{
		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action <>9__7_0;

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x310F914", Offset = "0x310F914", VA = "0x310F914")]
		public <>c()
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x310F91C", Offset = "0x310F91C", VA = "0x310F91C")]
		internal void <Update>b__7_0()
		{
		}
	}

	[Token(Token = "0x4000410")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TextAsset data;

	[Token(Token = "0x4000411")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private AppLiveStartParam _liveStartParam;

	[Token(Token = "0x4000412")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool _primaryButtonIsDown;

	[Token(Token = "0x4000413")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	private bool _primaryButtonIsDone;

	[Token(Token = "0x4000414")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
	private bool _secondButtonIsDown;

	[Token(Token = "0x4000415")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
	private bool _secondButtonIsDone;

	[Token(Token = "0x60003D8")]
	[Address(RVA = "0x2B525FC", Offset = "0x2B525FC", VA = "0x2B525FC")]
	private void Start()
	{
	}

	[Token(Token = "0x60003D9")]
	[Address(RVA = "0x2B526A0", Offset = "0x2B526A0", VA = "0x2B526A0")]
	private void Update()
	{
	}

	[Token(Token = "0x60003DA")]
	[Address(RVA = "0x2B52B94", Offset = "0x2B52B94", VA = "0x2B52B94")]
	public Test()
	{
	}
}
[Token(Token = "0x20000C9")]
public class DissolveAnimationHelper : MonoBehaviour
{
	[Token(Token = "0x4000418")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x124E3E8", Offset = "0x124E3E8")]
	public float process;

	[Token(Token = "0x4000419")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x124E400", Offset = "0x124E400")]
	public float width;

	[Token(Token = "0x400041A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool hardEdge;

	[Token(Token = "0x400041B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	public bool invert;

	[Token(Token = "0x400041C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x124E418", Offset = "0x124E418")]
	public float lensDistortionStrength;

	[Token(Token = "0x400041D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x124E430", Offset = "0x124E430")]
	public float lensDistortionIntensity;

	[Token(Token = "0x400041E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x124E448", Offset = "0x124E448")]
	public float lensDistortionRange;

	[Token(Token = "0x400041F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private PostEffectManager m_PostEffectManager;

	[Token(Token = "0x60003DE")]
	[Address(RVA = "0x2C80A1C", Offset = "0x2C80A1C", VA = "0x2C80A1C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60003DF")]
	[Address(RVA = "0x2C80AF8", Offset = "0x2C80AF8", VA = "0x2C80AF8")]
	private void Update()
	{
	}

	[Token(Token = "0x60003E0")]
	[Address(RVA = "0x2C80BE0", Offset = "0x2C80BE0", VA = "0x2C80BE0")]
	public DissolveAnimationHelper()
	{
	}
}
[Token(Token = "0x20000CA")]
public class TestDissolve : MonoBehaviour
{
	[Token(Token = "0x20000CB")]
	public class InputeTest
	{
		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool _LastState;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private XRNode _xrNode;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private InputFeatureUsage<bool> _commonUsages;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Action _action;

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x310FD34", Offset = "0x310FD34", VA = "0x310FD34")]
		public InputeTest(XRNode xrNode, InputFeatureUsage<bool> commonUsages, Action action)
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x310FD8C", Offset = "0x310FD8C", VA = "0x310FD8C")]
		public void PicoInputAction()
		{
		}
	}

	[Token(Token = "0x20000CC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124D760", Offset = "0x124D760")]
	private sealed class <StartPost>d__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TestDissolve <>4__this;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <time>5__2;

		[Token(Token = "0x1700004B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003F7")]
			[Address(RVA = "0x310FB20", Offset = "0x310FB20", VA = "0x310FB20", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003F9")]
			[Address(RVA = "0x310FB68", Offset = "0x310FB68", VA = "0x310FB68", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x310F9A4", Offset = "0x310F9A4", VA = "0x310F9A4")]
		[DebuggerHidden]
		public <StartPost>d__15(int <>1__state)
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x310F9D0", Offset = "0x310F9D0", VA = "0x310F9D0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x310F9D4", Offset = "0x310F9D4", VA = "0x310F9D4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x310FB28", Offset = "0x310FB28", VA = "0x310FB28", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000CD")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124D770", Offset = "0x124D770")]
	private sealed class <StopPost>d__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TestDissolve <>4__this;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <time>5__2;

		[Token(Token = "0x1700004D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003FD")]
			[Address(RVA = "0x310FCE4", Offset = "0x310FCE4", VA = "0x310FCE4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003FF")]
			[Address(RVA = "0x310FD2C", Offset = "0x310FD2C", VA = "0x310FD2C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x310FB70", Offset = "0x310FB70", VA = "0x310FB70")]
		[DebuggerHidden]
		public <StopPost>d__17(int <>1__state)
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x310FB9C", Offset = "0x310FB9C", VA = "0x310FB9C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x310FBA0", Offset = "0x310FBA0", VA = "0x310FBA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x310FCEC", Offset = "0x310FCEC", VA = "0x310FCEC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000420")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public DissolveAnimationHelper m_TestPost;

	[Token(Token = "0x4000421")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public PostEffectManager m_PostEffectManager;

	[Token(Token = "0x4000422")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private EcosystemManager m_TempManager;

	[Token(Token = "0x4000423")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "MinAttribute", RVA = "0x124E460", Offset = "0x124E460")]
	public float m_DissolveTime;

	[Token(Token = "0x4000424")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public bool m_Invert;

	[Token(Token = "0x4000425")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
	public bool m_StartDissolve;

	[Token(Token = "0x4000426")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
	public bool m_StartUnDissolve;

	[Token(Token = "0x4000427")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private InputeTest _RightHandFirstBotton;

	[Token(Token = "0x4000428")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private InputeTest _RightHandSecondaryBotton;

	[Token(Token = "0x4000429")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private InputeTest _RightHandGripBotton;

	[Token(Token = "0x60003E1")]
	[Address(RVA = "0x2B52D84", Offset = "0x2B52D84", VA = "0x2B52D84")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60003E2")]
	[Address(RVA = "0x2B53170", Offset = "0x2B53170", VA = "0x2B53170")]
	private void Start()
	{
	}

	[Token(Token = "0x60003E3")]
	[Address(RVA = "0x2B52DDC", Offset = "0x2B52DDC", VA = "0x2B52DDC")]
	private void Log(string info)
	{
	}

	[Token(Token = "0x60003E4")]
	[Address(RVA = "0x2B53368", Offset = "0x2B53368", VA = "0x2B53368")]
	private void PlayDissolve()
	{
	}

	[Token(Token = "0x60003E5")]
	[Address(RVA = "0x2B53434", Offset = "0x2B53434", VA = "0x2B53434")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x12514C8", Offset = "0x12514C8")]
	private IEnumerator StartPost()
	{
		return null;
	}

	[Token(Token = "0x60003E6")]
	[Address(RVA = "0x2B534AC", Offset = "0x2B534AC", VA = "0x2B534AC")]
	private void PlayUnDissolve()
	{
	}

	[Token(Token = "0x60003E7")]
	[Address(RVA = "0x2B5357C", Offset = "0x2B5357C", VA = "0x2B5357C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1251528", Offset = "0x1251528")]
	private IEnumerator StopPost()
	{
		return null;
	}

	[Token(Token = "0x60003E8")]
	[Address(RVA = "0x2B535F4", Offset = "0x2B535F4", VA = "0x2B535F4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60003E9")]
	[Address(RVA = "0x2B53854", Offset = "0x2B53854", VA = "0x2B53854")]
	private void Update()
	{
	}

	[Token(Token = "0x60003EA")]
	[Address(RVA = "0x2B538C8", Offset = "0x2B538C8", VA = "0x2B538C8")]
	private void OnApplicationPause(bool pause)
	{
	}

	[Token(Token = "0x60003EB")]
	[Address(RVA = "0x2B53044", Offset = "0x2B53044", VA = "0x2B53044")]
	private void AddPostEffect()
	{
	}

	[Token(Token = "0x60003EC")]
	[Address(RVA = "0x2B536D4", Offset = "0x2B536D4", VA = "0x2B536D4")]
	private void RemovePostEffect()
	{
	}

	[Token(Token = "0x60003ED")]
	[Address(RVA = "0x2B52E6C", Offset = "0x2B52E6C", VA = "0x2B52E6C")]
	private void CheckESS()
	{
	}

	[Token(Token = "0x60003EE")]
	[Address(RVA = "0x2B538CC", Offset = "0x2B538CC", VA = "0x2B538CC")]
	public TestDissolve()
	{
	}

	[Token(Token = "0x60003EF")]
	[Address(RVA = "0x2B538DC", Offset = "0x2B538DC", VA = "0x2B538DC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1251588", Offset = "0x1251588")]
	private void <Start>b__12_0()
	{
	}

	[Token(Token = "0x60003F0")]
	[Address(RVA = "0x2B538E0", Offset = "0x2B538E0", VA = "0x2B538E0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1251598", Offset = "0x1251598")]
	private void <Start>b__12_1()
	{
	}

	[Token(Token = "0x60003F1")]
	[Address(RVA = "0x2B538E4", Offset = "0x2B538E4", VA = "0x2B538E4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x12515A8", Offset = "0x12515A8")]
	private void <Start>b__12_2()
	{
	}
}
namespace Oasis.Unity
{
	[Token(Token = "0x20000CE")]
	public class CustomLightMapDataMap : ScriptableObject
	{
		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MeshLightmapData[] LightMapDatas;

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x2C7DB38", Offset = "0x2C7DB38", VA = "0x2C7DB38")]
		public CustomLightMapDataMap()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000CF")]
	public class CustomLightmapData
	{
		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Texture2D LightmapColor;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Texture2D LightmapDir;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Texture2D ShadowMask;

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x2C7DB40", Offset = "0x2C7DB40", VA = "0x2C7DB40")]
		public CustomLightmapData(LightmapData data)
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x2C7DBC0", Offset = "0x2C7DBC0", VA = "0x2C7DBC0")]
		public bool IsA(LightmapData data)
		{
			return default(bool);
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x2C7DCFC", Offset = "0x2C7DCFC", VA = "0x2C7DCFC")]
		public LightmapData GetLightmapData()
		{
			return null;
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x2C7DD90", Offset = "0x2C7DD90", VA = "0x2C7DD90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x20000D0")]
	public class MeshLightmapData
	{
		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector4 LightmapScaleOffset;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CustomLightmapData LightmapData;

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x3F64130", Offset = "0x3F64130", VA = "0x3F64130", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x3F64234", Offset = "0x3F64234", VA = "0x3F64234", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x3F64280", Offset = "0x3F64280", VA = "0x3F64280")]
		public MeshLightmapData()
		{
		}
	}
	[Token(Token = "0x20000D1")]
	[ExecuteInEditMode]
	public class LightMapDataLoader : MonoBehaviour
	{
		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<CustomLightmapData, int> lightmapDataRefenceCount;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CustomLightMapDataMap asset;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private HashSet<CustomLightmapData> lightmapDatas;

		[Token(Token = "0x1700004F")]
		public CustomLightMapDataMap Asset
		{
			[Token(Token = "0x6000408")]
			[Address(RVA = "0x3F61AB8", Offset = "0x3F61AB8", VA = "0x3F61AB8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000409")]
			[Address(RVA = "0x3F61AC0", Offset = "0x3F61AC0", VA = "0x3F61AC0")]
			set
			{
			}
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x3F61AC8", Offset = "0x3F61AC8", VA = "0x3F61AC8")]
		public static void Clear()
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x3F61B4C", Offset = "0x3F61B4C", VA = "0x3F61B4C")]
		private void Start()
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x3F62260", Offset = "0x3F62260", VA = "0x3F62260")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x3F622F0", Offset = "0x3F622F0", VA = "0x3F622F0")]
		public LightMapDataLoader()
		{
		}
	}
	[Token(Token = "0x20000D2")]
	public class LightMapDataMap : ScriptableObject
	{
		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LightMapData[] lightMapDatas;

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x3F62400", Offset = "0x3F62400", VA = "0x3F62400")]
		public LightMapDataMap()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000D3")]
	public struct LightMapData
	{
		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int lightmapIndex;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public Vector4 lightmapScaleOffset;
	}
	[Token(Token = "0x20000D4")]
	public class LightmapMatMgr
	{
		[Token(Token = "0x20000D5")]
		public class LightmapInfo
		{
			[Token(Token = "0x4000444")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Material mat;

			[Token(Token = "0x4000445")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MeshLightmapData data;

			[Token(Token = "0x6000414")]
			[Address(RVA = "0x310CEC4", Offset = "0x310CEC4", VA = "0x310CEC4", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Token(Token = "0x6000415")]
			[Address(RVA = "0x310CFD8", Offset = "0x310CFD8", VA = "0x310CFD8", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6000416")]
			[Address(RVA = "0x310D02C", Offset = "0x310D02C", VA = "0x310D02C")]
			public LightmapInfo()
			{
			}
		}

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Dictionary<LightmapInfo, Material> matDir;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Dictionary<LightmapInfo, int> matRefCount;

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x3F62430", Offset = "0x3F62430", VA = "0x3F62430")]
		public Material GetMat(LightmapInfo info)
		{
			return null;
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x3F62764", Offset = "0x3F62764", VA = "0x3F62764")]
		public void ReleaseInfo(LightmapInfo info)
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x3F628BC", Offset = "0x3F628BC", VA = "0x3F628BC")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x3F62A44", Offset = "0x3F62A44", VA = "0x3F62A44")]
		public LightmapMatMgr()
		{
		}
	}
}
namespace UnityTemplateProjects
{
	[Token(Token = "0x20000D6")]
	public class SimpleCameraController : MonoBehaviour
	{
		[Token(Token = "0x20000D7")]
		private class CameraState
		{
			[Token(Token = "0x4000454")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float yaw;

			[Token(Token = "0x4000455")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pitch;

			[Token(Token = "0x4000456")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float roll;

			[Token(Token = "0x4000457")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float x;

			[Token(Token = "0x4000458")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float y;

			[Token(Token = "0x4000459")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float z;

			[Token(Token = "0x6000423")]
			[Address(RVA = "0x310F538", Offset = "0x310F538", VA = "0x310F538")]
			public void SetFromTransform(Transform t)
			{
			}

			[Token(Token = "0x6000424")]
			[Address(RVA = "0x310F5C0", Offset = "0x310F5C0", VA = "0x310F5C0")]
			public void Translate(Vector3 translation)
			{
			}

			[Token(Token = "0x6000425")]
			[Address(RVA = "0x310F63C", Offset = "0x310F63C", VA = "0x310F63C")]
			public void LerpTowards(CameraState target, float positionLerpPct, float rotationLerpPct)
			{
			}

			[Token(Token = "0x6000426")]
			[Address(RVA = "0x310F704", Offset = "0x310F704", VA = "0x310F704")]
			public void UpdateTransform(Transform t)
			{
			}

			[Token(Token = "0x6000427")]
			[Address(RVA = "0x310F750", Offset = "0x310F750", VA = "0x310F750")]
			public CameraState()
			{
			}
		}

		[Token(Token = "0x4000446")]
		private const float k_MouseSensitivityMultiplier = 0.01f;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CameraState m_TargetCameraState;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private CameraState m_InterpolatingCameraState;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x124E488", Offset = "0x124E488")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x124E488", Offset = "0x124E488")]
		public float boost;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x124E4E8", Offset = "0x124E4E8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x124E4E8", Offset = "0x124E4E8")]
		public float positionLerpTime;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x124E540", Offset = "0x124E540")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x124E540", Offset = "0x124E540")]
		public float mouseSensitivity;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x124E5A0", Offset = "0x124E5A0")]
		public AnimationCurve mouseSensitivityCurve;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x124E5D8", Offset = "0x124E5D8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x124E5D8", Offset = "0x124E5D8")]
		public float rotationLerpTime;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x124E630", Offset = "0x124E630")]
		public bool invertY;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private InputAction movementAction;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private InputAction verticalMovementAction;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InputAction lookAction;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private InputAction boostFactorAction;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool mouseRightButtonPressed;

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x2B4E370", Offset = "0x2B4E370", VA = "0x2B4E370")]
		private void Start()
		{
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x2B4EAF4", Offset = "0x2B4EAF4", VA = "0x2B4EAF4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x2B4EB54", Offset = "0x2B4EB54", VA = "0x2B4EB54")]
		private Vector3 GetInputTranslationDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x2B4EBDC", Offset = "0x2B4EBDC", VA = "0x2B4EBDC")]
		private void Update()
		{
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x2B4F1C4", Offset = "0x2B4F1C4", VA = "0x2B4F1C4")]
		private float GetBoostFactor()
		{
			return default(float);
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x2B4F080", Offset = "0x2B4F080", VA = "0x2B4F080")]
		private Vector2 GetInputLookRotation()
		{
			return default(Vector2);
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x2B4F0F4", Offset = "0x2B4F0F4", VA = "0x2B4F0F4")]
		private bool IsBoostPressed()
		{
			return default(bool);
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x2B4EE2C", Offset = "0x2B4EE2C", VA = "0x2B4EE2C")]
		private bool IsEscapePressed()
		{
			return default(bool);
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x2B4EF78", Offset = "0x2B4EF78", VA = "0x2B4EF78")]
		private bool IsCameraRotationAllowed()
		{
			return default(bool);
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x2B4EE9C", Offset = "0x2B4EE9C", VA = "0x2B4EE9C")]
		private bool IsRightMouseButtonDown()
		{
			return default(bool);
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x2B4EF0C", Offset = "0x2B4EF0C", VA = "0x2B4EF0C")]
		private bool IsRightMouseButtonUp()
		{
			return default(bool);
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x2B4F228", Offset = "0x2B4F228", VA = "0x2B4F228")]
		public SimpleCameraController()
		{
		}
	}
}
namespace UnityEngine.Rendering.Universal
{
	[Token(Token = "0x20000D8")]
	public class PlanarURP : MonoBehaviour
	{
		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool VR;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int ReflectionTexResolution;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float Offset;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x124E668", Offset = "0x124E668")]
		public float ReflectionAlpha;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool BlurredReflection;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public LayerMask LayersToReflect;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Camera reflectionCamera;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private RenderTexture reflectionTexture;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RenderTexture reflectionTextureRight;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool isRendering;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Material material;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly int reflectionTexString;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly int reflectionTexRString;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static readonly int reflectionAlphaString;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly string blurString;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly string vrString;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Matrix4x4 reflectionMatrix;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector4 reflectionPlane;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector3 posistion;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 normal;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Matrix4x4 projection;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Vector4 oblique;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Matrix4x4 worldToCameraMatrix;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Vector3 clipNormal;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		private Vector4 clipPlane;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private Vector3 oldPosition;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private Vector3 eulerAngles;

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x3F7D280", Offset = "0x3F7D280", VA = "0x3F7D280")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x3F7D33C", Offset = "0x3F7D33C", VA = "0x3F7D33C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x3F7D5D4", Offset = "0x3F7D5D4", VA = "0x3F7D5D4")]
		public void Start()
		{
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x3F7DAC0", Offset = "0x3F7DAC0", VA = "0x3F7DAC0")]
		private void RenderObject(ScriptableRenderContext context, Camera cam)
		{
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x3F7D50C", Offset = "0x3F7D50C", VA = "0x3F7D50C")]
		private void RemoveObject(Object obj)
		{
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x3F7E814", Offset = "0x3F7E814", VA = "0x3F7E814")]
		private void RenderObjectCamera(Matrix4x4 projection, bool right)
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x3F7EA94", Offset = "0x3F7EA94", VA = "0x3F7EA94")]
		private static float sgn(float a)
		{
			return default(float);
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x3F7EAB4", Offset = "0x3F7EAB4", VA = "0x3F7EAB4")]
		public PlanarURP()
		{
		}
	}
}
namespace PicoLiveGIdle
{
	[Token(Token = "0x20000D9")]
	public class GIdleAvatarHotFix : MonoBehaviour
	{
		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 mHeadVec3;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 mHeadRot3;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 mLeftHandVec3;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 mLeftHandRot3;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 mRightHandVec3;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 mRightHandRot3;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 mLeftLegVec3;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 mLeftLegRot3;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Vector3 mRightLegVec3;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Vector3 mRightLegRot3;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Transform mRootAvatar;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool mSetIK;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
		public bool mHotFix;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float mNearPlane;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public float mFov;

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x2C85974", Offset = "0x2C85974", VA = "0x2C85974")]
		public GIdleAvatarHotFix()
		{
		}
	}
}
namespace AnycolorConcert
{
	[Token(Token = "0x20000DA")]
	public class AnyColorDanmakuModifier : MonoBehaviour
	{
		[Token(Token = "0x4000484")]
		private const string ExtraKey = "AnyColor.Icon";

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x1A4AE80", Offset = "0x1A4AE80", VA = "0x1A4AE80")]
		private string GetIconId()
		{
			return null;
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x1A4B300", Offset = "0x1A4B300", VA = "0x1A4B300")]
		private Sprite GetIcon(string id)
		{
			return null;
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x1A4B554", Offset = "0x1A4B554", VA = "0x1A4B554")]
		private void Start()
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x1A4B7A8", Offset = "0x1A4B7A8", VA = "0x1A4B7A8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x1A4B9FC", Offset = "0x1A4B9FC", VA = "0x1A4B9FC")]
		private void OnSend(Dictionary<string, object> postData)
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x1A4BA70", Offset = "0x1A4BA70", VA = "0x1A4BA70")]
		private void OnRec(IDanmaData rsp, ref LiveDanmakuData data)
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x1A4BC04", Offset = "0x1A4BC04", VA = "0x1A4BC04")]
		private void OnRecLocal(IDanmaData rsp, ref LiveDanmakuData data)
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x1A4BD34", Offset = "0x1A4BD34", VA = "0x1A4BD34")]
		public AnyColorDanmakuModifier()
		{
		}
	}
	[Token(Token = "0x20000DB")]
	public class ACBackItemForSelf
	{
		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LiveItemType BackLiveItemType;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int GlowstickColorIndex;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string FireworksColorModelName;

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x1A494F4", Offset = "0x1A494F4", VA = "0x1A494F4")]
		public ACBackItemForSelf()
		{
		}
	}
	[Token(Token = "0x20000DC")]
	public class Anycolor : MonoBehaviour
	{
		[Token(Token = "0x20000DD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124D790", Offset = "0x124D790")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x40004B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Anycolor <>4__this;

			[Token(Token = "0x40004B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public AnycolorActor anycolorActor;

			[Token(Token = "0x600048C")]
			[Address(RVA = "0x31087B0", Offset = "0x31087B0", VA = "0x31087B0")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x600048D")]
			[Address(RVA = "0x31087B8", Offset = "0x31087B8", VA = "0x31087B8")]
			internal void <UseGlowStick>b__0(LiveItemEntity entity)
			{
			}
		}

		[Token(Token = "0x20000DE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124D7A0", Offset = "0x124D7A0")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x40004B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Anycolor <>4__this;

			[Token(Token = "0x40004B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public AnycolorActor anycolorActor;

			[Token(Token = "0x600048E")]
			[Address(RVA = "0x3108784", Offset = "0x3108784", VA = "0x3108784")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x600048F")]
			[Address(RVA = "0x310878C", Offset = "0x310878C", VA = "0x310878C")]
			internal void <UseFireworks>b__0(LiveItemEntity entity)
			{
			}
		}

		[Token(Token = "0x20000DF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124D7B0", Offset = "0x124D7B0")]
		private sealed class <DelayShowSelfNo>d__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Anycolor <>4__this;

			[Token(Token = "0x17000055")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000493")]
				[Address(RVA = "0x3108B10", Offset = "0x3108B10", VA = "0x3108B10", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000056")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000495")]
				[Address(RVA = "0x3108B58", Offset = "0x3108B58", VA = "0x3108B58", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000490")]
			[Address(RVA = "0x3108A04", Offset = "0x3108A04", VA = "0x3108A04")]
			[DebuggerHidden]
			public <DelayShowSelfNo>d__16(int <>1__state)
			{
			}

			[Token(Token = "0x6000491")]
			[Address(RVA = "0x3108A30", Offset = "0x3108A30", VA = "0x3108A30", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000492")]
			[Address(RVA = "0x3108A34", Offset = "0x3108A34", VA = "0x3108A34", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000494")]
			[Address(RVA = "0x3108B18", Offset = "0x3108B18", VA = "0x3108B18", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124D7C0", Offset = "0x124D7C0")]
		private sealed class <DelayStart>d__97 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Anycolor <>4__this;

			[Token(Token = "0x17000057")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000499")]
				[Address(RVA = "0x3108C78", Offset = "0x3108C78", VA = "0x3108C78", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000058")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600049B")]
				[Address(RVA = "0x3108CC0", Offset = "0x3108CC0", VA = "0x3108CC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000496")]
			[Address(RVA = "0x3108B60", Offset = "0x3108B60", VA = "0x3108B60")]
			[DebuggerHidden]
			public <DelayStart>d__97(int <>1__state)
			{
			}

			[Token(Token = "0x6000497")]
			[Address(RVA = "0x3108B8C", Offset = "0x3108B8C", VA = "0x3108B8C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000498")]
			[Address(RVA = "0x3108B90", Offset = "0x3108B90", VA = "0x3108B90", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600049A")]
			[Address(RVA = "0x3108C80", Offset = "0x3108C80", VA = "0x3108C80", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000E1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124D7D0", Offset = "0x124D7D0")]
		private sealed class <DoStart>d__98 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Anycolor <>4__this;

			[Token(Token = "0x17000059")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600049F")]
				[Address(RVA = "0x3108F30", Offset = "0x3108F30", VA = "0x3108F30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700005A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004A1")]
				[Address(RVA = "0x3108F78", Offset = "0x3108F78", VA = "0x3108F78", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600049C")]
			[Address(RVA = "0x3108CC8", Offset = "0x3108CC8", VA = "0x3108CC8")]
			[DebuggerHidden]
			public <DoStart>d__98(int <>1__state)
			{
			}

			[Token(Token = "0x600049D")]
			[Address(RVA = "0x3108CF4", Offset = "0x3108CF4", VA = "0x3108CF4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600049E")]
			[Address(RVA = "0x3108CF8", Offset = "0x3108CF8", VA = "0x3108CF8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004A0")]
			[Address(RVA = "0x3108F38", Offset = "0x3108F38", VA = "0x3108F38", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000E2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124D7E0", Offset = "0x124D7E0")]
		private sealed class <MgrStart>d__102 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Anycolor <>4__this;

			[Token(Token = "0x40004C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Dictionary<AnycolorMgrType, AnycolorIMgr>.Enumerator <enumerator>5__2;

			[Token(Token = "0x1700005B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004A6")]
				[Address(RVA = "0x3109258", Offset = "0x3109258", VA = "0x3109258", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700005C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004A8")]
				[Address(RVA = "0x31092A0", Offset = "0x31092A0", VA = "0x31092A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004A2")]
			[Address(RVA = "0x3108F80", Offset = "0x3108F80", VA = "0x3108F80")]
			[DebuggerHidden]
			public <MgrStart>d__102(int <>1__state)
			{
			}

			[Token(Token = "0x60004A3")]
			[Address(RVA = "0x3108FAC", Offset = "0x3108FAC", VA = "0x3108FAC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004A4")]
			[Address(RVA = "0x310901C", Offset = "0x310901C", VA = "0x310901C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004A5")]
			[Address(RVA = "0x3108FC8", Offset = "0x3108FC8", VA = "0x3108FC8")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60004A7")]
			[Address(RVA = "0x3109260", Offset = "0x3109260", VA = "0x3109260", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000E3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124D7F0", Offset = "0x124D7F0")]
		private sealed class <DelayChangeColorTips>d__105 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Anycolor <>4__this;

			[Token(Token = "0x1700005D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004AC")]
				[Address(RVA = "0x31089B4", Offset = "0x31089B4", VA = "0x31089B4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700005E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004AE")]
				[Address(RVA = "0x31089FC", Offset = "0x31089FC", VA = "0x31089FC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004A9")]
			[Address(RVA = "0x31087DC", Offset = "0x31087DC", VA = "0x31087DC")]
			[DebuggerHidden]
			public <DelayChangeColorTips>d__105(int <>1__state)
			{
			}

			[Token(Token = "0x60004AA")]
			[Address(RVA = "0x3108808", Offset = "0x3108808", VA = "0x3108808", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004AB")]
			[Address(RVA = "0x310880C", Offset = "0x310880C", VA = "0x310880C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004AD")]
			[Address(RVA = "0x31089BC", Offset = "0x31089BC", VA = "0x31089BC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int AnycolorWristbandItemIndex;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static int AnycolorWristbandSelfIndex;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject _firePointGo;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ACBackItemForSelf _acBackItemForSelf;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<CustomColorInfo> _curSceneCustomColorInfoList;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string CourseDefaultEnterScene;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string CourseDefaultToast;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string CourseStrategyInput;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string CourseStrategyOutsight;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static string EMOJI;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static string SELF;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static string EXIT;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static string SETTINGS;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static string KEYBOARD;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static Dictionary<string, string> WristbandFunOnDict;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static Dictionary<string, string> WristbandFunOffDict;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Dictionary<string, bool> _wristbandFunSwitchDict;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool _isWristbandPanelOn;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		private bool _isWristbandWristbandUIShow;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
		private bool _isReveivedCourseEnd;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B")]
		private bool _isNewPlayer;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool _isInitItemFinished;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected static Anycolor _instance;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _seiSelector;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Dictionary<AnycolorActor, int> _anycolorActor2ColorIndexDict;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<AnycolorActor> _curSceneActorList;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private string _serverSceneName;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool _isSceneA;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private AnycolorConfig _anycolorConfig;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private AnycolorUIConfig _uiConfig;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Camera _mainCamera;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool _renderPPOnBackup;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float _eyeBufferBackup;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float _cameraPosEyeBufferBackup;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private int _msaaSampleCountBackup;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool _ffrOnBackUp;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private TextureFoveatedFeatureQuality _ffrQualityBackUp;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float defaultFixedDeltaTime;

		[Token(Token = "0x40004AE")]
		private const float TargetFixedDeltaTime = 0.02f;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private int _selfCameraMaskValue;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private bool _isInitFinished;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Dictionary<AnycolorMgrType, AnycolorIMgr> _mgrDict;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Coroutine _changeColorCor;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool _isRegWristbandCourse;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB9")]
		private bool _liveDialogView1Show;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBA")]
		private bool _liveDialogView2Show;

		[Token(Token = "0x17000050")]
		public bool IsWristbandModalUIShow
		{
			[Token(Token = "0x600044B")]
			[Address(RVA = "0x1A4E234", Offset = "0x1A4E234", VA = "0x1A4E234")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600044C")]
			[Address(RVA = "0x1A4E23C", Offset = "0x1A4E23C", VA = "0x1A4E23C")]
			set
			{
			}
		}

		[Token(Token = "0x17000051")]
		public static Anycolor Instance
		{
			[Token(Token = "0x600045C")]
			[Address(RVA = "0x1A4FF04", Offset = "0x1A4FF04", VA = "0x1A4FF04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000052")]
		public bool IsSceneA
		{
			[Token(Token = "0x600045D")]
			[Address(RVA = "0x1A4B164", Offset = "0x1A4B164", VA = "0x1A4B164")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000053")]
		public AnycolorConfig CurAnycolorConfig
		{
			[Token(Token = "0x600045E")]
			[Address(RVA = "0x1A4CB64", Offset = "0x1A4CB64", VA = "0x1A4CB64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000054")]
		public AnycolorUIConfig UIConfig
		{
			[Token(Token = "0x600045F")]
			[Address(RVA = "0x1A4FE0C", Offset = "0x1A4FE0C", VA = "0x1A4FE0C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x1A4BD3C", Offset = "0x1A4BD3C", VA = "0x1A4BD3C")]
		private void InitGlowStickColor()
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x1A4C170", Offset = "0x1A4C170", VA = "0x1A4C170")]
		private void StartInitItem()
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x1A4C574", Offset = "0x1A4C574", VA = "0x1A4C574")]
		private void BeforeUseGlowStick(LiveItemEntity entity, AnycolorActor anycolorActor)
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x1A4CF1C", Offset = "0x1A4CF1C", VA = "0x1A4CF1C")]
		public void UseGlowStick(AnycolorActor anycolorActor)
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x1A4D208", Offset = "0x1A4D208", VA = "0x1A4D208")]
		public void UseGlowStickWithStr(string str)
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x1A4D2A8", Offset = "0x1A4D2A8", VA = "0x1A4D2A8")]
		private void BeforeUseFireworks(LiveItemEntity entity, AnycolorActor anycolorActor)
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x1A4D65C", Offset = "0x1A4D65C", VA = "0x1A4D65C")]
		public void UseFireworks(AnycolorActor anycolorActor)
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x1A4D7D8", Offset = "0x1A4D7D8", VA = "0x1A4D7D8")]
		public void UseFireworksWithStr(string str)
		{
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x1A4D878", Offset = "0x1A4D878", VA = "0x1A4D878")]
		public void ChangeGlowStickColor(AnycolorActor anycolorActor)
		{
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x1A4D9F4", Offset = "0x1A4D9F4", VA = "0x1A4D9F4")]
		public AnycolorActor GetAnycolorActorByIndex(int index)
		{
			return default(AnycolorActor);
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x1A4DB40", Offset = "0x1A4DB40", VA = "0x1A4DB40")]
		public void UseGlowStickByMsg(bool b)
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x1A4DD34", Offset = "0x1A4DD34", VA = "0x1A4DD34")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1251658", Offset = "0x1251658")]
		private IEnumerator DelayShowSelfNo()
		{
			return null;
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x1A4DDAC", Offset = "0x1A4DDAC", VA = "0x1A4DDAC")]
		public void UseSelf(bool b)
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x1A4DF74", Offset = "0x1A4DF74", VA = "0x1A4DF74")]
		private void InitFakeFirework()
		{
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x1A4E008", Offset = "0x1A4E008", VA = "0x1A4E008")]
		public void SetFakeFireworksOn(bool isOn)
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x1A4E0AC", Offset = "0x1A4E0AC", VA = "0x1A4E0AC")]
		private void LoadAKBnk()
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x1A4E248", Offset = "0x1A4E248", VA = "0x1A4E248")]
		private void SetWristbandDebug()
		{
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x1A4E8E4", Offset = "0x1A4E8E4", VA = "0x1A4E8E4")]
		private void RegUnRegWristbandCourse(bool reg)
		{
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x1A4EE68", Offset = "0x1A4EE68", VA = "0x1A4EE68")]
		private void OnWristbandCourseBegin(WristbandCourse course)
		{
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x1A4F0FC", Offset = "0x1A4F0FC", VA = "0x1A4F0FC")]
		private void OnWristbandCourseEnd(WristbandCourse course)
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x1A4F43C", Offset = "0x1A4F43C", VA = "0x1A4F43C")]
		private void OnWristbandOpenEvent()
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x1A4F448", Offset = "0x1A4F448", VA = "0x1A4F448")]
		private void OnWristbandCloseEvent()
		{
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x1A4F450", Offset = "0x1A4F450", VA = "0x1A4F450")]
		private void OnWristbandModalShowEvent(GameObject uiObj)
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x1A4F454", Offset = "0x1A4F454", VA = "0x1A4F454")]
		private void OnWristbandModalHideEvent(GameObject uiObj)
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x1A4F458", Offset = "0x1A4F458", VA = "0x1A4F458")]
		private void OnWristbandCustomEvent(string customEvent)
		{
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x1A4F650", Offset = "0x1A4F650", VA = "0x1A4F650")]
		private void OnWristbandInputEvent(string inputEvent)
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x1A4F550", Offset = "0x1A4F550", VA = "0x1A4F550")]
		private void SetWristbandFunSwitch(string funName, bool v)
		{
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x1A4F748", Offset = "0x1A4F748", VA = "0x1A4F748")]
		private bool GetCurWristbandFunOn()
		{
			return default(bool);
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x1A4F8F4", Offset = "0x1A4F8F4", VA = "0x1A4F8F4")]
		public bool IsWristbandOnUsed()
		{
			return default(bool);
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x1A4F914", Offset = "0x1A4F914", VA = "0x1A4F914")]
		public void GetFixOffsetAngle(out Vector3 offset, out Vector3 angle)
		{
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x1A4D098", Offset = "0x1A4D098", VA = "0x1A4D098")]
		public void CloseWristbandInputOutsightCourse()
		{
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x1A4FF68", Offset = "0x1A4FF68", VA = "0x1A4FF68")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x1A4FFFC", Offset = "0x1A4FFFC", VA = "0x1A4FFFC")]
		private void AwakeInitMgr()
		{
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x1A50A70", Offset = "0x1A50A70", VA = "0x1A50A70")]
		private void Start()
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x1A50A78", Offset = "0x1A50A78", VA = "0x1A50A78")]
		private void Update()
		{
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x1A50A7C", Offset = "0x1A50A7C", VA = "0x1A50A7C")]
		private void MgrUpdate()
		{
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x1A50A74", Offset = "0x1A50A74", VA = "0x1A50A74")]
		private void StartInit()
		{
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x1A502B0", Offset = "0x1A502B0", VA = "0x1A502B0")]
		private void RegUnRegMsg(bool reg)
		{
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x1A50C40", Offset = "0x1A50C40", VA = "0x1A50C40")]
		private void LiveOnEntered()
		{
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x1A50CE4", Offset = "0x1A50CE4", VA = "0x1A50CE4")]
		private void LiveOnWillExit()
		{
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x1A50C6C", Offset = "0x1A50C6C", VA = "0x1A50C6C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x12516B8", Offset = "0x12516B8")]
		private IEnumerator DelayStart()
		{
			return null;
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x1A512F8", Offset = "0x1A512F8", VA = "0x1A512F8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1251718", Offset = "0x1251718")]
		private IEnumerator DoStart()
		{
			return null;
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x1A51370", Offset = "0x1A51370", VA = "0x1A51370")]
		private void InitCoroutineUtil()
		{
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x1A513F8", Offset = "0x1A513F8", VA = "0x1A513F8")]
		private void InitSEIHandler()
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x1A5169C", Offset = "0x1A5169C", VA = "0x1A5169C")]
		private void DisposeSEIHandler()
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x1A517C0", Offset = "0x1A517C0", VA = "0x1A517C0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1251778", Offset = "0x1251778")]
		public IEnumerator MgrStart()
		{
			return null;
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x1A51838", Offset = "0x1A51838", VA = "0x1A51838")]
		private void ReleaseChangeColorCor()
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x1A5187C", Offset = "0x1A5187C", VA = "0x1A5187C")]
		private void SetDelayChangeColorTips()
		{
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x1A518B8", Offset = "0x1A518B8", VA = "0x1A518B8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x12517D8", Offset = "0x12517D8")]
		private IEnumerator DelayChangeColorTips()
		{
			return null;
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x1A51930", Offset = "0x1A51930", VA = "0x1A51930")]
		private void CheckEquipItem()
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x1A51620", Offset = "0x1A51620", VA = "0x1A51620")]
		public AnycolorIMgr GetMgr(AnycolorMgrType mgrType)
		{
			return null;
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x1A51A50", Offset = "0x1A51A50", VA = "0x1A51A50")]
		public AnycolorDance Dance()
		{
			return null;
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x1A51AD8", Offset = "0x1A51AD8", VA = "0x1A51AD8")]
		public AnycolorUI UI()
		{
			return null;
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x1A4CC5C", Offset = "0x1A4CC5C", VA = "0x1A4CC5C")]
		public AnycolorInteraction Interaction()
		{
			return null;
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x1A4F86C", Offset = "0x1A4F86C", VA = "0x1A4F86C")]
		public TouchEffectMgr TouchEffect()
		{
			return null;
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x1A51B60", Offset = "0x1A51B60", VA = "0x1A51B60")]
		private void InitRenderPostProcessingOn()
		{
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x1A51DD4", Offset = "0x1A51DD4", VA = "0x1A51DD4")]
		private void SetEyeBufferFFR()
		{
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x1A52960", Offset = "0x1A52960", VA = "0x1A52960")]
		private void BackupEyeBuffer()
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x1A52554", Offset = "0x1A52554", VA = "0x1A52554")]
		private void SetEyeBufferFFRValue(int msaaSampleCount, float renderScale, float cameraPosScale, bool isEnableFFR, TextureFoveatedFeatureQuality ffrQuality)
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x1A51574", Offset = "0x1A51574", VA = "0x1A51574")]
		private void AnycolorLogError(string s)
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x1A5297C", Offset = "0x1A5297C", VA = "0x1A5297C")]
		public AnycolorActor GetCurSceneActorRandom()
		{
			return default(AnycolorActor);
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x1A52A18", Offset = "0x1A52A18", VA = "0x1A52A18")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x1A52A80", Offset = "0x1A52A80", VA = "0x1A52A80")]
		private void RemoveLiveItem()
		{
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x1A52B90", Offset = "0x1A52B90", VA = "0x1A52B90")]
		public void SetFixedDeltaTime()
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x1A52BC8", Offset = "0x1A52BC8", VA = "0x1A52BC8")]
		public void ResetFixedDeltaTime()
		{
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x1A52C00", Offset = "0x1A52C00", VA = "0x1A52C00")]
		private void SetSelfCameraHiddenAvatar()
		{
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x1A52E40", Offset = "0x1A52E40", VA = "0x1A52E40")]
		private void BackSelfCamera()
		{
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x1A53020", Offset = "0x1A53020", VA = "0x1A53020")]
		private void UpdateLiveDialogView1Show(bool v)
		{
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x1A530F4", Offset = "0x1A530F4", VA = "0x1A530F4")]
		private void UpdateLiveDialogView2Show(bool v)
		{
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x1A51A30", Offset = "0x1A51A30", VA = "0x1A51A30")]
		public bool IsLiveDialogViewShow()
		{
			return default(bool);
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x1A50CE8", Offset = "0x1A50CE8", VA = "0x1A50CE8")]
		private void Dispose()
		{
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x1A535B8", Offset = "0x1A535B8", VA = "0x1A535B8")]
		private void OpenDebug()
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x1A536D0", Offset = "0x1A536D0", VA = "0x1A536D0")]
		public Anycolor()
		{
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x1A53D7C", Offset = "0x1A53D7C", VA = "0x1A53D7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1251838", Offset = "0x1251838")]
		private void <StartInitItem>b__5_0(LiveItemEntity entity)
		{
		}
	}
	[Token(Token = "0x20000E4")]
	public enum AnycolorActor
	{
		[Token(Token = "0x40004CB")]
		None,
		[Token(Token = "0x40004CC")]
		kagami,
		[Token(Token = "0x40004CD")]
		ryushen,
		[Token(Token = "0x40004CE")]
		hoshikawa,
		[Token(Token = "0x40004CF")]
		higuchi
	}
	[Token(Token = "0x20000E5")]
	public class AnycolorConfigLoader : MonoBehaviour
	{
		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AnycolorConfig AnycolorConfig;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AnycolorDanceConfig DanceConfig;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnycolorUIConfig UIConfig;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnycolorVibrateConfig VibrateConfig;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected static AnycolorConfigLoader _instance;

		[Token(Token = "0x1700005F")]
		public static AnycolorConfigLoader Instance
		{
			[Token(Token = "0x60004AF")]
			[Address(RVA = "0x1A5439C", Offset = "0x1A5439C", VA = "0x1A5439C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x1A543E8", Offset = "0x1A543E8", VA = "0x1A543E8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x1A5443C", Offset = "0x1A5443C", VA = "0x1A5443C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x1A5448C", Offset = "0x1A5448C", VA = "0x1A5448C")]
		public AnycolorConfigLoader()
		{
		}
	}
	[Token(Token = "0x20000E6")]
	public class AnycolorDebugInput : MonoBehaviour
	{
		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x124E690", Offset = "0x124E690")]
		public InputAction leftAction;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x124E6C8", Offset = "0x124E6C8")]
		public InputAction rightAction;

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x1A5A36C", Offset = "0x1A5A36C", VA = "0x1A5A36C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x1A5A534", Offset = "0x1A5A534", VA = "0x1A5A534")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x1A5A3B0", Offset = "0x1A5A3B0", VA = "0x1A5A3B0")]
		private void ActivateInput()
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x1A5A578", Offset = "0x1A5A578", VA = "0x1A5A578")]
		private void DeactivateInput()
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x1A5A6FC", Offset = "0x1A5A6FC", VA = "0x1A5A6FC")]
		private void OnLeftGripEvent(InputAction.CallbackContext e)
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x1A5A8F8", Offset = "0x1A5A8F8", VA = "0x1A5A8F8")]
		private void OnRightGripEvent(InputAction.CallbackContext e)
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x1A5AA24", Offset = "0x1A5AA24", VA = "0x1A5AA24")]
		public AnycolorDebugInput()
		{
		}
	}
	[Token(Token = "0x20000E7")]
	public enum AnycolorMgrType
	{
		[Token(Token = "0x40004D8")]
		None,
		[Token(Token = "0x40004D9")]
		UI,
		[Token(Token = "0x40004DA")]
		Dance,
		[Token(Token = "0x40004DB")]
		Interaction,
		[Token(Token = "0x40004DC")]
		SEI,
		[Token(Token = "0x40004DD")]
		Tracking,
		[Token(Token = "0x40004DE")]
		TouchEffect,
		[Token(Token = "0x40004DF")]
		Vibrate
	}
	[Token(Token = "0x20000E8")]
	public interface AnycolorIMgr
	{
		[Token(Token = "0x60004BA")]
		IEnumerator StartInit(AnycolorConfig anycolorConfig);

		[Token(Token = "0x60004BB")]
		void Update(float deltaTime);

		[Token(Token = "0x60004BC")]
		void Dispose();

		[Token(Token = "0x60004BD")]
		void OnSeiSignal(string name, bool isOn, int offset);
	}
	[Token(Token = "0x20000E9")]
	public class AnycolorSEISelector : MonoBehaviour
	{
		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _sceneA;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _sceneB;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AnycolorSEI _anycolorSEIMgr;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private SeiSignalDispatcher _signalDispatcher;

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x2C749D8", Offset = "0x2C749D8", VA = "0x2C749D8")]
		public void SelectSEITransition(AnycolorSEI sei)
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x2C74DD8", Offset = "0x2C74DD8", VA = "0x2C74DD8")]
		private void HandleSeiSignal(string group, string seiName, bool isOn, int offset)
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x2C74D2C", Offset = "0x2C74D2C", VA = "0x2C74D2C")]
		private void AnycolorLogError(string s)
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x2C7501C", Offset = "0x2C7501C", VA = "0x2C7501C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x2C75020", Offset = "0x2C75020", VA = "0x2C75020")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x2C75128", Offset = "0x2C75128", VA = "0x2C75128")]
		public AnycolorSEISelector()
		{
		}
	}
	[Token(Token = "0x20000EA")]
	public class ACEnterGameInteraction : BaseInteraction
	{
		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string game_title;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string session;

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x1A494FC", Offset = "0x1A494FC", VA = "0x1A494FC")]
		public ACEnterGameInteraction()
		{
		}
	}
	[Token(Token = "0x20000EB")]
	public class ACStayGameInteraction : BaseInteraction
	{
		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string game_title;

		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string session;

		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int miss;

		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public int success;

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int finish_amount;

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x1A4950C", Offset = "0x1A4950C", VA = "0x1A4950C")]
		public ACStayGameInteraction()
		{
		}
	}
	[Token(Token = "0x20000EC")]
	public class ACSceneEffectsInteraction : BaseInteraction
	{
		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string scene_effects;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string effects_type;

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x1A49504", Offset = "0x1A49504", VA = "0x1A49504")]
		public ACSceneEffectsInteraction()
		{
		}
	}
	[Token(Token = "0x20000ED")]
	public class AnycolorTracking : AnycolorIMgr
	{
		[Token(Token = "0x20000EE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124D800", Offset = "0x124D800")]
		private sealed class <StartInit>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AnycolorTracking <>4__this;

			[Token(Token = "0x40004F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public AnycolorConfig anycolorConfig;

			[Token(Token = "0x17000060")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004D4")]
				[Address(RVA = "0x310A530", Offset = "0x310A530", VA = "0x310A530", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000061")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004D6")]
				[Address(RVA = "0x310A578", Offset = "0x310A578", VA = "0x310A578", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004D1")]
			[Address(RVA = "0x310A4C0", Offset = "0x310A4C0", VA = "0x310A4C0")]
			[DebuggerHidden]
			public <StartInit>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x60004D2")]
			[Address(RVA = "0x310A4EC", Offset = "0x310A4EC", VA = "0x310A4EC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004D3")]
			[Address(RVA = "0x310A4F0", Offset = "0x310A4F0", VA = "0x310A4F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004D5")]
			[Address(RVA = "0x310A538", Offset = "0x310A538", VA = "0x310A538", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private AnycolorConfig _anycolorConfig;

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x2C75C60", Offset = "0x2C75C60", VA = "0x2C75C60")]
		public void InitTracking(AnycolorConfig anycolorConfig)
		{
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x2C75C64", Offset = "0x2C75C64", VA = "0x2C75C64")]
		public void DisposeTracking()
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x2C75C68", Offset = "0x2C75C68", VA = "0x2C75C68", Slot = "4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x12519D8", Offset = "0x12519D8")]
		public IEnumerator StartInit(AnycolorConfig anycolorConfig)
		{
			return null;
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x2C75CFC", Offset = "0x2C75CFC", VA = "0x2C75CFC", Slot = "5")]
		public void Update(float deltaTime)
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x2C75D00", Offset = "0x2C75D00", VA = "0x2C75D00")]
		public void EnterGameTracking(string game_title, string session)
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x2C75FD4", Offset = "0x2C75FD4", VA = "0x2C75FD4")]
		public void StayGameTracking(string game_title, string session, int miss, int success, int finish_amount)
		{
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x2C762F0", Offset = "0x2C762F0", VA = "0x2C762F0")]
		public void TriggerSceneEffectsTracking(string scene_effects, string effects_type)
		{
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x2C765C4", Offset = "0x2C765C4", VA = "0x2C765C4", Slot = "6")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x2C765C8", Offset = "0x2C765C8", VA = "0x2C765C8", Slot = "7")]
		public void OnSeiSignal(string name, bool isOn, int offset)
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x2C765CC", Offset = "0x2C765CC", VA = "0x2C765CC")]
		public AnycolorTracking()
		{
		}
	}
	[Token(Token = "0x20000EF")]
	public class AnycolorPool<T> where T : class
	{
		[Token(Token = "0x40004F2")]
		private const int k_UnsetCapacityValue = -1;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected Stack<T> m_PoolStack;

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly Func<T> m_ActionCreate;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly Action<T> m_ActionOnGet;

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly Action<T> m_ActionOnRelease;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124E720", Offset = "0x124E720")]
		private int <CountAll>k__BackingField;

		[Token(Token = "0x17000062")]
		public int CountAll
		{
			[Token(Token = "0x60004D7")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1251A88", Offset = "0x1251A88")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60004D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1251A98", Offset = "0x1251A98")]
			private set
			{
			}
		}

		[Token(Token = "0x17000063")]
		public int CountActive
		{
			[Token(Token = "0x60004D9")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000064")]
		public int CountInactive
		{
			[Token(Token = "0x60004DA")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60004DB")]
		public AnycolorPool(Func<T> actionCreate, [Optional] Action<T> actionOnGet, [Optional] Action<T> actionOnRelease, int defaultCapacity = -1)
		{
		}

		[Token(Token = "0x60004DC")]
		public T Get()
		{
			return null;
		}

		[Token(Token = "0x60004DD")]
		public virtual bool Release(T element)
		{
			return default(bool);
		}

		[Token(Token = "0x60004DE")]
		public virtual void Clear()
		{
		}
	}
	[Token(Token = "0x20000F0")]
	public class AnycolorPrefabMgr : Oasis.Unity.Singleton<AnycolorPrefabMgr>
	{
		[Token(Token = "0x20000F1")]
		private class GameObjectKeyComparer : IEqualityComparer<GameObject>
		{
			[Token(Token = "0x60004E7")]
			[Address(RVA = "0x3109E2C", Offset = "0x3109E2C", VA = "0x3109E2C", Slot = "4")]
			public bool Equals(GameObject x, GameObject y)
			{
				return default(bool);
			}

			[Token(Token = "0x60004E8")]
			[Address(RVA = "0x3109F6C", Offset = "0x3109F6C", VA = "0x3109F6C", Slot = "5")]
			public int GetHashCode(GameObject obj)
			{
				return default(int);
			}

			[Token(Token = "0x60004E9")]
			[Address(RVA = "0x3109F88", Offset = "0x3109F88", VA = "0x3109F88")]
			public GameObjectKeyComparer()
			{
			}
		}

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Dictionary<int, AnycolorPrefabPool> _pools;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Dictionary<GameObject, AnycolorPrefabPool> _instanceLookup;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GameObject _poolGoRoot;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _isDisposing;

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x1A63D24", Offset = "0x1A63D24", VA = "0x1A63D24")]
		public void Init()
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x1A63E74", Offset = "0x1A63E74", VA = "0x1A63E74")]
		public void WarmAnycolorPrefabPool(GameObject prefab, int size)
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x1A61C88", Offset = "0x1A61C88", VA = "0x1A61C88")]
		public GameObject SpawnObject(GameObject prefab)
		{
			return null;
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x1A642C8", Offset = "0x1A642C8", VA = "0x1A642C8")]
		public GameObject SpawnObject(GameObject prefab, Vector3 position, Quaternion rotation)
		{
			return null;
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x1A5C64C", Offset = "0x1A5C64C", VA = "0x1A5C64C")]
		public bool TryReturn(GameObject clone)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x1A531C8", Offset = "0x1A531C8", VA = "0x1A531C8")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x1A6441C", Offset = "0x1A6441C", VA = "0x1A6441C")]
		public void PrintStatus()
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x1A64688", Offset = "0x1A64688", VA = "0x1A64688")]
		public AnycolorPrefabMgr()
		{
		}
	}
	[Token(Token = "0x20000F2")]
	public class AnycolorPrefabPool : AnycolorPool<GameObject>
	{
		[Token(Token = "0x20000F3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124D810", Offset = "0x124D810")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x40004FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GameObject prefabLink;

			[Token(Token = "0x40004FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GameObject parent;

			[Token(Token = "0x60004F1")]
			[Address(RVA = "0x310A03C", Offset = "0x310A03C", VA = "0x310A03C")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x60004F2")]
			[Address(RVA = "0x310A044", Offset = "0x310A044", VA = "0x310A044")]
			internal GameObject <.ctor>b__0()
			{
				return null;
			}
		}

		[Serializable]
		[Token(Token = "0x20000F4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124D820", Offset = "0x124D820")]
		private sealed class <>c
		{
			[Token(Token = "0x4000500")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000501")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Action<GameObject> <>9__8_1;

			[Token(Token = "0x4000502")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Action<GameObject> <>9__8_2;

			[Token(Token = "0x60004F4")]
			[Address(RVA = "0x3109FF4", Offset = "0x3109FF4", VA = "0x3109FF4")]
			public <>c()
			{
			}

			[Token(Token = "0x60004F5")]
			[Address(RVA = "0x3109FFC", Offset = "0x3109FFC", VA = "0x3109FFC")]
			internal void <.ctor>b__8_1(GameObject gameObject)
			{
			}

			[Token(Token = "0x60004F6")]
			[Address(RVA = "0x310A01C", Offset = "0x310A01C", VA = "0x310A01C")]
			internal void <.ctor>b__8_2(GameObject gameObject)
			{
			}
		}

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124E730", Offset = "0x124E730")]
		private GameObject <PrefabLink>k__BackingField;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124E740", Offset = "0x124E740")]
		private GameObject <Parent>k__BackingField;

		[Token(Token = "0x17000065")]
		public GameObject PrefabLink
		{
			[Token(Token = "0x60004EA")]
			[Address(RVA = "0x1A646D4", Offset = "0x1A646D4", VA = "0x1A646D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1251AA8", Offset = "0x1251AA8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004EB")]
			[Address(RVA = "0x1A646DC", Offset = "0x1A646DC", VA = "0x1A646DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1251AB8", Offset = "0x1251AB8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000066")]
		public GameObject Parent
		{
			[Token(Token = "0x60004EC")]
			[Address(RVA = "0x1A646E4", Offset = "0x1A646E4", VA = "0x1A646E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1251AC8", Offset = "0x1251AC8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004ED")]
			[Address(RVA = "0x1A646EC", Offset = "0x1A646EC", VA = "0x1A646EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1251AD8", Offset = "0x1251AD8")]
			private set
			{
			}
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x1A64008", Offset = "0x1A64008", VA = "0x1A64008")]
		public AnycolorPrefabPool(GameObject prefabLink, int capacity, GameObject parent)
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x1A646F4", Offset = "0x1A646F4", VA = "0x1A646F4", Slot = "4")]
		public override bool Release(GameObject element)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x1A64798", Offset = "0x1A64798", VA = "0x1A64798", Slot = "5")]
		public override void Clear()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000F5")]
	public class AnycolorActorConfig
	{
		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CustomColorInfo ActorCustomColorInfo;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string TriggerEffect;

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x1A53D84", Offset = "0x1A53D84", VA = "0x1A53D84")]
		public AnycolorActorConfig()
		{
		}
	}
	[Token(Token = "0x20000F6")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x124D830", Offset = "0x124D830")]
	public class AnycolorConfig : ScriptableObject
	{
		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject testPrefab;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x124E750", Offset = "0x124E750")]
		public AnycolorActorConfig ActorConfigJiaHeMei;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnycolorActorConfig ActorConfigLvXian;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnycolorActorConfig ActorConfigXingChuan;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnycolorActorConfig ActorConfigTongKou;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x124E788", Offset = "0x124E788")]
		public bool PostProcessingOn;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x124E7C0", Offset = "0x124E7C0")]
		public GameObject DebugWnd;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public GameObject MusicGameWnd;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public GameObject ToastWnd;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public GameObject TipsWnd;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public GameObject ImgTipsWnd;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public GameObject TouchEffect;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public GameObject VirtualHand;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public GameObject Fireworks;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public GameObject GlowStick;

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public GameObject GlowStickTouchNum;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public GameObject FireworksBullet;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public GameObject FireworksDispersal;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public GameObject OpenStageEffect;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public GameObject TimePrefab;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public GameObject AkBankLoader;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public GameObject FireworksBulletNoSound;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x124E7F8", Offset = "0x124E7F8")]
		public GameConfigAsset DanceGameConfigAsset;

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x124E830", Offset = "0x124E830")]
		public GameObject LeftColliderPrefab;

		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public GameObject RightColliderPrefab;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public GameObject FrameTriggerPrefab;

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public GameObject DanceEffectPrefab;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public float DanceEffectOffsetY;

		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		public float DanceEffectScale;

		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x124E868", Offset = "0x124E868")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x124E868", Offset = "0x124E868")]
		public float CollisionInterval;

		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x124E8C8", Offset = "0x124E8C8")]
		public int CollisionCount;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x124E900", Offset = "0x124E900")]
		public float FireworksMoveDistance;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x124E938", Offset = "0x124E938")]
		public float FireworksMoveTime;

		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x124E970", Offset = "0x124E970")]
		public float FireworksAngleLimit;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x124E9A8", Offset = "0x124E9A8")]
		public float FireworksAngleMaxLimit;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x124E9E0", Offset = "0x124E9E0")]
		public float FireworksFanAngleLimit;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x124EA18", Offset = "0x124EA18")]
		public float FireworksGuestInterMin;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x124EA50", Offset = "0x124EA50")]
		public float FireworksGuestInterMax;

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x124EA88", Offset = "0x124EA88")]
		public float FireworksGuestAngleMin;

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x124EAC0", Offset = "0x124EAC0")]
		public float FireworksGuestAngleMax;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x124EAF8", Offset = "0x124EAF8")]
		public float FakeFireworksCheckInterval;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x124EB30", Offset = "0x124EB30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x124EB30", Offset = "0x124EB30")]
		public float OpenStageHeadHandDistance;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x124EB90", Offset = "0x124EB90")]
		public float OpenStageCheckInterval;

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x124EBC8", Offset = "0x124EBC8")]
		public float ClientWaitTime;

		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x124EC00", Offset = "0x124EC00")]
		public float MinRandom;

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x124EC38", Offset = "0x124EC38")]
		public float MaxRandom;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x124EC70", Offset = "0x124EC70")]
		public float FlyTime;

		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x124ECA8", Offset = "0x124ECA8")]
		public float ClientEffectScale;

		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x124ECE0", Offset = "0x124ECE0")]
		public float OwnerEffectScale;

		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x124ED18", Offset = "0x124ED18")]
		public Vector3 TargetPositionLeft;

		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x124ED50", Offset = "0x124ED50")]
		public Vector3 TargetPositionRight;

		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x124ED88", Offset = "0x124ED88")]
		public Vector3 OwnerPosition;

		[Token(Token = "0x4000539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x124EDC0", Offset = "0x124EDC0")]
		public Vector3[] ClientPosition;

		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x124EDF8", Offset = "0x124EDF8")]
		public float EyeBuffer;

		[Token(Token = "0x400053B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		public int MsaaSampleCount;

		[Token(Token = "0x400053C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		public bool EnableFFR;

		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
		public TextureFoveatedFeatureQuality FFRQuality;

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x1A54330", Offset = "0x1A54330", VA = "0x1A54330")]
		public AnycolorConfig()
		{
		}
	}
	[Token(Token = "0x20000F7")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x124D89C", Offset = "0x124D89C")]
	public class AnycolorDanceConfig : ScriptableObject
	{
		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<AnycolorDanceDataConfig> DanceDataList;

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x1A575F0", Offset = "0x1A575F0", VA = "0x1A575F0")]
		public AnycolorDanceConfig()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000F8")]
	public class AnycolorDanceDataConfig
	{
		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AnycolorDanceFlag DanceFlag;

		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x124EE30", Offset = "0x124EE30")]
		public int MagicNum;

		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TextAsset JsonTextAsset;

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x1A575F8", Offset = "0x1A575F8", VA = "0x1A575F8")]
		public AnycolorDanceDataConfig()
		{
		}
	}
	[Token(Token = "0x20000F9")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x124D908", Offset = "0x124D908")]
	public class AnycolorUIConfig : ScriptableObject
	{
		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float OffsetY;

		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Sprite Kagami;

		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Sprite Higuchi;

		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Sprite Hoshikawa;

		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Sprite Ryushen;

		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3 DefaultOffset;

		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Vector3 DefaultAngle;

		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x124EE68", Offset = "0x124EE68")]
		public Vector3 WristbandOffset;

		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Vector3 WristbandAngle;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x124EEA0", Offset = "0x124EEA0")]
		public Vector3 EmojOffset;

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public Vector3 EmojAngle;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x124EED8", Offset = "0x124EED8")]
		public Vector3 InputOffset;

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public Vector3 InputAngle;

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x124EF10", Offset = "0x124EF10")]
		public Vector3 SettingOffset;

		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public Vector3 SettingAngle;

		[Token(Token = "0x4000551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x124EF48", Offset = "0x124EF48")]
		public Vector3 ExitOffset;

		[Token(Token = "0x4000552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public Vector3 ExitAngle;

		[Token(Token = "0x4000553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x124EF80", Offset = "0x124EF80")]
		public Vector3 SelfOffset;

		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public Vector3 SelfAngle;

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x2C783B8", Offset = "0x2C783B8", VA = "0x2C783B8")]
		public AnycolorUIConfig()
		{
		}
	}
	[Token(Token = "0x20000FA")]
	public class CoroutineUtil : MainModel.Singleton<CoroutineUtil>
	{
		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static MonoBehaviour _handler;

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x2C7CF10", Offset = "0x2C7CF10", VA = "0x2C7CF10")]
		public void SetHandler(MonoBehaviour handler)
		{
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x2C7CF64", Offset = "0x2C7CF64", VA = "0x2C7CF64")]
		public static Coroutine StartCoroutine(IEnumerator routine)
		{
			return null;
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x2C7CFC4", Offset = "0x2C7CFC4", VA = "0x2C7CFC4")]
		public static void StopCoroutine(Coroutine routine)
		{
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x2C7D034", Offset = "0x2C7D034", VA = "0x2C7D034")]
		public static void StopAll()
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x2C7D08C", Offset = "0x2C7D08C", VA = "0x2C7D08C")]
		public void Init()
		{
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x2C7D090", Offset = "0x2C7D090", VA = "0x2C7D090")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x2C7D0FC", Offset = "0x2C7D0FC", VA = "0x2C7D0FC")]
		public CoroutineUtil()
		{
		}
	}
	[Token(Token = "0x20000FB")]
	public enum AnycolorDanceFlag
	{
		[Token(Token = "0x4000557")]
		None = 0,
		[Token(Token = "0x4000558")]
		kagami_1 = 1,
		[Token(Token = "0x4000559")]
		kagami_2 = 2,
		[Token(Token = "0x400055A")]
		kagami_3 = 3,
		[Token(Token = "0x400055B")]
		kagami_4 = 4,
		[Token(Token = "0x400055C")]
		ryushen_1 = 10,
		[Token(Token = "0x400055D")]
		ryushen_2 = 11,
		[Token(Token = "0x400055E")]
		ryushen_3 = 12,
		[Token(Token = "0x400055F")]
		ryushen_4 = 13,
		[Token(Token = "0x4000560")]
		higuchi_1 = 20,
		[Token(Token = "0x4000561")]
		higuchi_2 = 21,
		[Token(Token = "0x4000562")]
		higuchi_3 = 22,
		[Token(Token = "0x4000563")]
		higuchi_4 = 23,
		[Token(Token = "0x4000564")]
		hoshi_1 = 30,
		[Token(Token = "0x4000565")]
		hoshi_2 = 31,
		[Token(Token = "0x4000566")]
		hoshi_3 = 32,
		[Token(Token = "0x4000567")]
		hoshi_4 = 33
	}
	[Token(Token = "0x20000FC")]
	public enum AnycolorActionUnitResult
	{
		[Token(Token = "0x4000569")]
		Miss,
		[Token(Token = "0x400056A")]
		Hit,
		[Token(Token = "0x400056B")]
		Perfect
	}
	[Token(Token = "0x20000FD")]
	public class AnycolorDance : AnycolorIMgr
	{
		[Token(Token = "0x20000FE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124D974", Offset = "0x124D974")]
		private sealed class <StartInit>d__57 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000586")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000587")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000588")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AnycolorDance <>4__this;

			[Token(Token = "0x4000589")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public AnycolorConfig anycolorConfig;

			[Token(Token = "0x1700006A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600052A")]
				[Address(RVA = "0x31095B4", Offset = "0x31095B4", VA = "0x31095B4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700006B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600052C")]
				[Address(RVA = "0x31095FC", Offset = "0x31095FC", VA = "0x31095FC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000527")]
			[Address(RVA = "0x3109544", Offset = "0x3109544", VA = "0x3109544")]
			[DebuggerHidden]
			public <StartInit>d__57(int <>1__state)
			{
			}

			[Token(Token = "0x6000528")]
			[Address(RVA = "0x3109570", Offset = "0x3109570", VA = "0x3109570", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000529")]
			[Address(RVA = "0x3109574", Offset = "0x3109574", VA = "0x3109574", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600052B")]
			[Address(RVA = "0x31095BC", Offset = "0x31095BC", VA = "0x31095BC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private AnycolorConfig _anycolorConfig;

		[Token(Token = "0x400056D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private AnycolorDanceConfig _danceConfig;

		[Token(Token = "0x400056E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AnycolorTracking _tracking;

		[Token(Token = "0x400056F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static string TrackingTitle;

		[Token(Token = "0x4000570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string _trackingSession;

		[Token(Token = "0x4000571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private MusicGameDance _danceGame;

		[Token(Token = "0x4000572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private VRTV.MusicGame.Dance.Environment _danceEnv;

		[Token(Token = "0x4000573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Dictionary<AnycolorDanceFlag, AnycolorDanceDataConfig> _danceCfgDict;

		[Token(Token = "0x4000574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Dictionary<AnycolorDanceFlag, AnycolorActor> _danceFlag2ActorDict;

		[Token(Token = "0x4000575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private GameObject _leftColliderPrefab;

		[Token(Token = "0x4000576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private GameObject _rightColliderPrefab;

		[Token(Token = "0x4000577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GameObject _frameTriggerPrefab;

		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameConfigAsset _danceGameConfigAsset;

		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private AnycolorDanceUIBehaviour _danceUI;

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int _curMagicNum;

		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly int MagicNumDefalt;

		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Dictionary<PXR_Input.VibrateController, bool> _curUnitStartFrameResult;

		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Dictionary<PXR_Input.VibrateController, bool> _curUnitKeyFrameResult;

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool _curUnitFrameSuc;

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private int _curDanceUnitCount;

		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private int _curDanceSucUnitCount;

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private AnycolorDanceFlag _curDanceFlag;

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private bool _IsDanceOn;

		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124EFB8", Offset = "0x124EFB8")]
		private int <Combo>k__BackingField;

		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124EFC8", Offset = "0x124EFC8")]
		private int <MaxCombo>k__BackingField;

		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private VibrateMgr _vibrateMgr;

		[Token(Token = "0x17000067")]
		public AnycolorTracking Tracking
		{
			[Token(Token = "0x6000503")]
			[Address(RVA = "0x1A54494", Offset = "0x1A54494", VA = "0x1A54494")]
			set
			{
			}
		}

		[Token(Token = "0x17000068")]
		public int Combo
		{
			[Token(Token = "0x6000504")]
			[Address(RVA = "0x1A5449C", Offset = "0x1A5449C", VA = "0x1A5449C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1251AE8", Offset = "0x1251AE8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000505")]
			[Address(RVA = "0x1A544A4", Offset = "0x1A544A4", VA = "0x1A544A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1251AF8", Offset = "0x1251AF8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000069")]
		public int MaxCombo
		{
			[Token(Token = "0x6000506")]
			[Address(RVA = "0x1A544AC", Offset = "0x1A544AC", VA = "0x1A544AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1251B08", Offset = "0x1251B08")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000507")]
			[Address(RVA = "0x1A544B4", Offset = "0x1A544B4", VA = "0x1A544B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1251B18", Offset = "0x1251B18")]
			private set
			{
			}
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x1A544BC", Offset = "0x1A544BC", VA = "0x1A544BC")]
		public void StartDance(AnycolorDanceFlag danceFlag, float offset)
		{
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x1A55300", Offset = "0x1A55300", VA = "0x1A55300")]
		public void DanceSwitch(bool isOn, AnycolorDanceFlag danceFlag, int offset)
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x1A556C0", Offset = "0x1A556C0", VA = "0x1A556C0")]
		private void DanceOn(AnycolorDanceFlag danceFlag, int offset)
		{
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x1A558A0", Offset = "0x1A558A0", VA = "0x1A558A0")]
		private void DanceOff(AnycolorDanceFlag danceFlag, float offset)
		{
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x1A548C4", Offset = "0x1A548C4", VA = "0x1A548C4")]
		private string GetDanceJson(AnycolorDanceFlag danceFlag)
		{
			return null;
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x1A54C84", Offset = "0x1A54C84", VA = "0x1A54C84")]
		private void DoDance(string jsonStr, float offset)
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x1A55988", Offset = "0x1A55988", VA = "0x1A55988")]
		public void InitDance(AnycolorConfig anycolorConfig)
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x1A55B38", Offset = "0x1A55B38", VA = "0x1A55B38")]
		private void InitDanceFlag2ActorDict()
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x1A55F20", Offset = "0x1A55F20", VA = "0x1A55F20")]
		private void OnActionUnitResult(int actionUnitId, ActionUnitResult actionUnitResult)
		{
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x1A561B8", Offset = "0x1A561B8", VA = "0x1A561B8")]
		public void SetCombo(int num)
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x1A561C0", Offset = "0x1A561C0", VA = "0x1A561C0")]
		public void AddCombo()
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x1A561D0", Offset = "0x1A561D0", VA = "0x1A561D0")]
		public void ShowDanceUI()
		{
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x1A56000", Offset = "0x1A56000", VA = "0x1A56000")]
		private AnycolorDanceUIBehaviour GetDanceUI()
		{
			return null;
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x1A561E4", Offset = "0x1A561E4", VA = "0x1A561E4")]
		private void onActionUnitBegin(int actionUnitId, ActionUnitData actionUnitData)
		{
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x1A56408", Offset = "0x1A56408", VA = "0x1A56408")]
		private void OnFrameBegin(int actionUnitId, VRTV.MusicGame.Dance.FrameData frameData)
		{
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x1A564F0", Offset = "0x1A564F0", VA = "0x1A564F0")]
		private void OnFrameResult(int actionUnitId, FrameResult frameResult)
		{
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x1A56EE0", Offset = "0x1A56EE0", VA = "0x1A56EE0")]
		private void ReleaseDanceUI()
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x1A57000", Offset = "0x1A57000", VA = "0x1A57000")]
		private void OnGameCompleted()
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x1A54760", Offset = "0x1A54760", VA = "0x1A54760")]
		private void ReleaseGame()
		{
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x1A5707C", Offset = "0x1A5707C", VA = "0x1A5707C")]
		private void RelaseGameObj()
		{
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x1A56AE4", Offset = "0x1A56AE4", VA = "0x1A56AE4")]
		private VibrateMgr GetVibrateMgr()
		{
			return null;
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x1A574B0", Offset = "0x1A574B0", VA = "0x1A574B0")]
		public void OnUpdateDance()
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x1A574C4", Offset = "0x1A574C4", VA = "0x1A574C4")]
		public void DisposeDance()
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x1A574C8", Offset = "0x1A574C8", VA = "0x1A574C8", Slot = "4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1251B28", Offset = "0x1251B28")]
		public IEnumerator StartInit(AnycolorConfig anycolorConfig)
		{
			return null;
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x1A5755C", Offset = "0x1A5755C", VA = "0x1A5755C", Slot = "5")]
		public void Update(float deltaTime)
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x1A57570", Offset = "0x1A57570", VA = "0x1A57570", Slot = "6")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x1A57574", Offset = "0x1A57574", VA = "0x1A57574", Slot = "7")]
		public void OnSeiSignal(string name, bool isOn, int offset)
		{
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x1A554A4", Offset = "0x1A554A4", VA = "0x1A554A4")]
		public void EnterGameTracking(AnycolorDanceFlag danceFlag)
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x1A55588", Offset = "0x1A55588", VA = "0x1A55588")]
		public void StayGameTracking(AnycolorDanceFlag danceFlag)
		{
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x1A507A8", Offset = "0x1A507A8", VA = "0x1A507A8")]
		public AnycolorDance()
		{
		}
	}
	[Token(Token = "0x20000FF")]
	public class AnycolorDanceEffect : MonoBehaviour
	{
		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<GameObject> GoList;

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x1A57600", Offset = "0x1A57600", VA = "0x1A57600")]
		public void ShowEffect(string str)
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x1A5777C", Offset = "0x1A5777C", VA = "0x1A5777C")]
		public AnycolorDanceEffect()
		{
		}
	}
	[Token(Token = "0x2000100")]
	public class AnycolorDanceUIBehaviour : MonoBehaviour
	{
		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static float DanceActionMoveTime;

		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<Sprite> NumList1;

		[Token(Token = "0x400058D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<Sprite> NumList2;

		[Token(Token = "0x400058E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Animator MoveAnimator;

		[Token(Token = "0x400058F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Animator ResultAnimator0;

		[Token(Token = "0x4000590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Animator ResultAnimator1;

		[Token(Token = "0x4000591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Animator ResultAnimator2;

		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Animator ComboAnimator1;

		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Animator ComboAnimator2;

		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public List<Image> ComboNumList1;

		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public List<Image> ComboNumList2;

		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public List<Image> ComboNumValueList2;

		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public GameObject FrameBeginGo;

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x1A561E0", Offset = "0x1A561E0", VA = "0x1A561E0")]
		public void Init()
		{
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x1A57784", Offset = "0x1A57784", VA = "0x1A57784")]
		private void HideAllNode()
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x1A57A74", Offset = "0x1A57A74", VA = "0x1A57A74")]
		private void HideMoveAnimator()
		{
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x1A578D8", Offset = "0x1A578D8", VA = "0x1A578D8")]
		private void HideResultCombo()
		{
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x1A563D4", Offset = "0x1A563D4", VA = "0x1A563D4")]
		public void BeginAction(float duration)
		{
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x1A57B14", Offset = "0x1A57B14", VA = "0x1A57B14")]
		private void ShowDanceAction(float duration = 0f)
		{
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x1A561B4", Offset = "0x1A561B4", VA = "0x1A561B4")]
		public void SetFrameBeginShow(bool b)
		{
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x1A564C8", Offset = "0x1A564C8", VA = "0x1A564C8")]
		public void OnKeyFrameBegin()
		{
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x1A57828", Offset = "0x1A57828", VA = "0x1A57828")]
		public void SetResultMissShow(bool show)
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x1A56948", Offset = "0x1A56948", VA = "0x1A56948")]
		public void ShowFrameResult(AnycolorActionUnitResult actionUnitResult, int combo)
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x1A57C48", Offset = "0x1A57C48", VA = "0x1A57C48")]
		private void ShowCombo(AnycolorActionUnitResult actionUnitResult, int combo)
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x1A57DB4", Offset = "0x1A57DB4", VA = "0x1A57DB4")]
		private List<Image> GetComboNumImgList(AnycolorActionUnitResult actionUnitResult)
		{
			return null;
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x1A57DD8", Offset = "0x1A57DD8", VA = "0x1A57DD8")]
		private Sprite GetNumSprite(AnycolorActionUnitResult actionUnitResult, char num)
		{
			return null;
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x1A57D28", Offset = "0x1A57D28", VA = "0x1A57D28")]
		private void SetComboNum(AnycolorActionUnitResult actionUnitResult, int combo)
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x1A57EB0", Offset = "0x1A57EB0", VA = "0x1A57EB0")]
		private void SetComboNum(List<Image> comboNumImgList, AnycolorActionUnitResult actionUnitResult, int combo)
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x1A58060", Offset = "0x1A58060", VA = "0x1A58060")]
		private void DebugMove()
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x1A58068", Offset = "0x1A58068", VA = "0x1A58068")]
		private void Start()
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x1A58124", Offset = "0x1A58124", VA = "0x1A58124")]
		private void Update()
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x1A58128", Offset = "0x1A58128", VA = "0x1A58128")]
		public AnycolorDanceUIBehaviour()
		{
		}
	}
	[Token(Token = "0x2000101")]
	public class AnycolorFireworksBullet : MonoBehaviour
	{
		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AnycolorFireworksModelSelector _fireworksModelSelector;

		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AnycolorActor _actor;

		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 _fakeTargetPos;

		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool _isMyFireworks;

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x1A5AA2C", Offset = "0x1A5AA2C", VA = "0x1A5AA2C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x1A5AA30", Offset = "0x1A5AA30", VA = "0x1A5AA30")]
		private void DO()
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x1A5AB90", Offset = "0x1A5AB90", VA = "0x1A5AB90")]
		public static Vector3 RotateRound(Vector3 position, Vector3 center, Vector3 axis, float angle)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x1A5AC08", Offset = "0x1A5AC08", VA = "0x1A5AC08")]
		public void Init(AnycolorActor actor, Vector3 position, Quaternion rota, Vector3 scale, bool isMyFireworks = false)
		{
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x1A5B024", Offset = "0x1A5B024", VA = "0x1A5B024")]
		public void InitForFake(AnycolorActor actor, Vector3 position, Vector3 targetPos)
		{
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x1A5B0F0", Offset = "0x1A5B0F0", VA = "0x1A5B0F0")]
		public void SetModel(string modelName)
		{
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x1A5AD0C", Offset = "0x1A5AD0C", VA = "0x1A5AD0C")]
		private Vector3 GetRealFireDir(Vector3 transformUpDir)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x1A5B2CC", Offset = "0x1A5B2CC", VA = "0x1A5B2CC")]
		private float Get2DirAngle(Vector3 v1, Vector3 v2)
		{
			return default(float);
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x1A5B348", Offset = "0x1A5B348", VA = "0x1A5B348")]
		private Vector3 GetFireDir(Vector3 transformUpDir, Vector3 transformRightDir)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x1A5B7A8", Offset = "0x1A5B7A8", VA = "0x1A5B7A8")]
		public void FakeMove()
		{
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0x1A5BA64", Offset = "0x1A5BA64", VA = "0x1A5BA64")]
		public void DoMove()
		{
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x1A5BE08", Offset = "0x1A5BE08", VA = "0x1A5BE08")]
		public AnycolorFireworksBullet()
		{
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0x1A5BE10", Offset = "0x1A5BE10", VA = "0x1A5BE10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1251BD8", Offset = "0x1251BD8")]
		private void <FakeMove>b__13_0()
		{
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0x1A5C254", Offset = "0x1A5C254", VA = "0x1A5C254")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1251BE8", Offset = "0x1251BE8")]
		private void <DoMove>b__14_0()
		{
		}
	}
	[Token(Token = "0x2000102")]
	public class AnycolorFireworksDispersal : MonoBehaviour
	{
		[Token(Token = "0x2000103")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124D984", Offset = "0x124D984")]
		private sealed class <DelayRelease>d__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400059F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AnycolorFireworksDispersal <>4__this;

			[Token(Token = "0x1700006C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000558")]
				[Address(RVA = "0x310972C", Offset = "0x310972C", VA = "0x310972C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700006D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600055A")]
				[Address(RVA = "0x3109774", Offset = "0x3109774", VA = "0x3109774", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000555")]
			[Address(RVA = "0x3109604", Offset = "0x3109604", VA = "0x3109604")]
			[DebuggerHidden]
			public <DelayRelease>d__5(int <>1__state)
			{
			}

			[Token(Token = "0x6000556")]
			[Address(RVA = "0x3109630", Offset = "0x3109630", VA = "0x3109630", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000557")]
			[Address(RVA = "0x3109634", Offset = "0x3109634", VA = "0x3109634", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000559")]
			[Address(RVA = "0x3109734", Offset = "0x3109734", VA = "0x3109734", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<GameObject> GoList;

		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float DelayDestorySec;

		[Token(Token = "0x400059E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject EffectRoot;

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x1A5C760", Offset = "0x1A5C760", VA = "0x1A5C760")]
		public void Fire(AnycolorActor actor, int index)
		{
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x1A5C914", Offset = "0x1A5C914", VA = "0x1A5C914")]
		private void DoFire(string str)
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x1A5CB14", Offset = "0x1A5CB14", VA = "0x1A5CB14")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1251BF8", Offset = "0x1251BF8")]
		private IEnumerator DelayRelease()
		{
			return null;
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x1A5CB8C", Offset = "0x1A5CB8C", VA = "0x1A5CB8C")]
		public AnycolorFireworksDispersal()
		{
		}
	}
	[Token(Token = "0x2000104")]
	public class AnycolorFireworksFake : MonoBehaviour
	{
		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float _fakeFireworksTimeAccumulate;

		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float _fakeFireworkCheckInterval;

		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float _intervalMin;

		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float _intervalMax;

		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float _angleMin;

		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float _angleMax;

		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool _isOn;

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x1A5CB9C", Offset = "0x1A5CB9C", VA = "0x1A5CB9C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x1A5CCBC", Offset = "0x1A5CCBC", VA = "0x1A5CCBC")]
		private void RandomGenerateInterval()
		{
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x1A5CCE8", Offset = "0x1A5CCE8", VA = "0x1A5CCE8")]
		private float GetRandomXRotate()
		{
			return default(float);
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x1A5CCF4", Offset = "0x1A5CCF4", VA = "0x1A5CCF4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x1A5CCFC", Offset = "0x1A5CCFC", VA = "0x1A5CCFC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x1A5CEF8", Offset = "0x1A5CEF8", VA = "0x1A5CEF8")]
		private void Fireworks()
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x1A5D3F0", Offset = "0x1A5D3F0", VA = "0x1A5D3F0")]
		public AnycolorFireworksFake()
		{
		}
	}
	[Token(Token = "0x2000105")]
	public class AnycolorFireworksItem : LiveItemSubComponentBase
	{
		[Token(Token = "0x40005A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AnycolorFireworksModelSelector _fireworksModelSelector;

		[Token(Token = "0x40005AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x124EFD8", Offset = "0x124EFD8")]
		public InputAction leftAction;

		[Token(Token = "0x40005AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x124F010", Offset = "0x124F010")]
		public InputAction rightAction;

		[Token(Token = "0x40005AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string _fireworksModeName;

		[Token(Token = "0x1700006E")]
		public string FireworksModeName
		{
			[Token(Token = "0x6000562")]
			[Address(RVA = "0x1A4D62C", Offset = "0x1A4D62C", VA = "0x1A4D62C")]
			set
			{
			}
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x1A5D40C", Offset = "0x1A5D40C", VA = "0x1A5D40C")]
		public void SetModel(string modelName)
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x1A5D4AC", Offset = "0x1A5D4AC", VA = "0x1A5D4AC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x1A5D634", Offset = "0x1A5D634", VA = "0x1A5D634")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x1A5D4B0", Offset = "0x1A5D4B0", VA = "0x1A5D4B0")]
		private void ActivateInput()
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x1A5D638", Offset = "0x1A5D638", VA = "0x1A5D638")]
		private void DeactivateInput()
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x1A5D7BC", Offset = "0x1A5D7BC", VA = "0x1A5D7BC")]
		private void OnLeftTriggerEvent(InputAction.CallbackContext e)
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x1A5D838", Offset = "0x1A5D838", VA = "0x1A5D838")]
		private void OnRightTriggerEvent(InputAction.CallbackContext e)
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x1A5DA60", Offset = "0x1A5DA60", VA = "0x1A5DA60")]
		private void FireInTheHole()
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x1A5E074", Offset = "0x1A5E074", VA = "0x1A5E074")]
		public AnycolorFireworksItem()
		{
		}
	}
	[Token(Token = "0x2000106")]
	public class AnycolorFireworksModelSelector : MonoBehaviour
	{
		[Token(Token = "0x40005AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<GameObject> ModelList;

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x1A5B190", Offset = "0x1A5B190", VA = "0x1A5B190")]
		public void SetModel(string modelName)
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x1A5E07C", Offset = "0x1A5E07C", VA = "0x1A5E07C")]
		public AnycolorFireworksModelSelector()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000107")]
	public class CustomColorInfo
	{
		[Token(Token = "0x40005AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "ColorUsageAttribute", RVA = "0x124F048", Offset = "0x124F048")]
		public Color CustomColor;

		[Token(Token = "0x40005AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string ColorTrackingKey;

		[Token(Token = "0x40005B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnycolorActor Actor;

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x2C7DB30", Offset = "0x2C7DB30", VA = "0x2C7DB30")]
		public CustomColorInfo()
		{
		}
	}
	[Token(Token = "0x2000108")]
	public class AnycolorGlowStickComponent : LiveItemSubComponentBase
	{
		[Token(Token = "0x2000109")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124D994", Offset = "0x124D994")]
		private sealed class <DelaySetTouchEnable>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AnycolorGlowStickComponent <>4__this;

			[Token(Token = "0x17000071")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000595")]
				[Address(RVA = "0x3109870", Offset = "0x3109870", VA = "0x3109870", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000072")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000597")]
				[Address(RVA = "0x31098B8", Offset = "0x31098B8", VA = "0x31098B8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000592")]
			[Address(RVA = "0x310977C", Offset = "0x310977C", VA = "0x310977C")]
			[DebuggerHidden]
			public <DelaySetTouchEnable>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x6000593")]
			[Address(RVA = "0x31097A8", Offset = "0x31097A8", VA = "0x31097A8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000594")]
			[Address(RVA = "0x31097AC", Offset = "0x31097AC", VA = "0x31097AC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000596")]
			[Address(RVA = "0x3109878", Offset = "0x3109878", VA = "0x3109878", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<CustomColorInfo> CustomColorList;

		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int _initColorIndex;

		[Token(Token = "0x40005B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public List<GameObject> LightMaterialGoList;

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<Material> _lightMaterialList;

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public GameObject kagamiGo;

		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public GameObject ryushenGo;

		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public GameObject hoshikawaGo;

		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public GameObject higuchiGo;

		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Dictionary<AnycolorActor, GameObject> _actor2TouchEffectParent;

		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Dictionary<AnycolorActor, List<ParticleSystem>> _actor2TouchEffectList;

		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int _colorIndex;

		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public InputAction TriggerPressedAction;

		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public InputAction SecondaryButtonAction;

		[Token(Token = "0x40005BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool _isInitFinished;

		[Token(Token = "0x40005BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		private bool _isCanTouch;

		[Token(Token = "0x1700006F")]
		public int InitColorIndex
		{
			[Token(Token = "0x600056F")]
			[Address(RVA = "0x1A5E084", Offset = "0x1A5E084", VA = "0x1A5E084")]
			set
			{
			}
		}

		[Token(Token = "0x17000070")]
		public int ColorIndex
		{
			[Token(Token = "0x6000570")]
			[Address(RVA = "0x1A5E08C", Offset = "0x1A5E08C", VA = "0x1A5E08C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x1A5E094", Offset = "0x1A5E094", VA = "0x1A5E094")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x1A5E2F8", Offset = "0x1A5E2F8", VA = "0x1A5E2F8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x1A5E280", Offset = "0x1A5E280", VA = "0x1A5E280")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1251CA8", Offset = "0x1251CA8")]
		private IEnumerator DelaySetTouchEnable()
		{
			return null;
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x1A5E660", Offset = "0x1A5E660", VA = "0x1A5E660")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x1A5E664", Offset = "0x1A5E664", VA = "0x1A5E664", Slot = "8")]
		public override void OnReleased()
		{
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x1A5E6C8", Offset = "0x1A5E6C8", VA = "0x1A5E6C8", Slot = "4")]
		public override void Init()
		{
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x1A5ED38", Offset = "0x1A5ED38", VA = "0x1A5ED38", Slot = "6")]
		public override void OnActivated()
		{
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x1A5EE48", Offset = "0x1A5EE48", VA = "0x1A5EE48", Slot = "7")]
		public override void OnDeactivated()
		{
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x1A5EE5C", Offset = "0x1A5EE5C", VA = "0x1A5EE5C", Slot = "5")]
		public override void OnParentItemTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0x1A5E6EC", Offset = "0x1A5E6EC", VA = "0x1A5E6EC")]
		private void InitMaterials()
		{
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x1A5E96C", Offset = "0x1A5E96C", VA = "0x1A5E96C")]
		private void InitTouchEffect()
		{
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x1A5E0C8", Offset = "0x1A5E0C8", VA = "0x1A5E0C8")]
		private void ActivateInput()
		{
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x1A5E328", Offset = "0x1A5E328", VA = "0x1A5E328")]
		private void DeactivateInput()
		{
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x1A5F0F0", Offset = "0x1A5F0F0", VA = "0x1A5F0F0")]
		private void PlayVibration()
		{
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x1A5F2EC", Offset = "0x1A5F2EC", VA = "0x1A5F2EC")]
		private void PlayParticles()
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x1A5F3C8", Offset = "0x1A5F3C8", VA = "0x1A5F3C8")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x1A5EE6C", Offset = "0x1A5EE6C", VA = "0x1A5EE6C")]
		private void OnTriggerEnterByParentItem()
		{
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x1A5F468", Offset = "0x1A5F468", VA = "0x1A5F468")]
		private void GetFireworksLogic()
		{
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x1A5F8B8", Offset = "0x1A5F8B8", VA = "0x1A5F8B8")]
		private void OnItemEffectEvent(InputAction.CallbackContext e)
		{
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x1A5F954", Offset = "0x1A5F954", VA = "0x1A5F954")]
		private void OnCloseItemEvent(InputAction.CallbackContext e)
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x1A5F948", Offset = "0x1A5F948", VA = "0x1A5F948")]
		private void SwitchNextColor()
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x1A5ED68", Offset = "0x1A5ED68", VA = "0x1A5ED68")]
		public void SetColorByIndex(int index)
		{
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x1A5FD2C", Offset = "0x1A5FD2C", VA = "0x1A5FD2C")]
		private void SendPropSettingTrack(string fromColor, string toColor)
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x1A5FAA0", Offset = "0x1A5FAA0", VA = "0x1A5FAA0")]
		private void SetColor(int index)
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x1A5E4E0", Offset = "0x1A5E4E0", VA = "0x1A5E4E0")]
		private void SetParticleSystems(AnycolorActor anycolorActor)
		{
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x1A5FEBC", Offset = "0x1A5FEBC", VA = "0x1A5FEBC")]
		private string GetColorStrByIndex(int colorIndex)
		{
			return null;
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x1A5F9D0", Offset = "0x1A5F9D0", VA = "0x1A5F9D0")]
		private bool IsHaveColors()
		{
			return default(bool);
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x1A5F328", Offset = "0x1A5F328", VA = "0x1A5F328")]
		private CustomColorInfo GetColorInfoByIndex(int colorIndex)
		{
			return null;
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x1A5FA28", Offset = "0x1A5FA28", VA = "0x1A5FA28")]
		private int GetColorsCount()
		{
			return default(int);
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x1A5FF30", Offset = "0x1A5FF30", VA = "0x1A5FF30")]
		private List<CustomColorInfo> GetColorInfoList()
		{
			return null;
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x1A5EE98", Offset = "0x1A5EE98", VA = "0x1A5EE98")]
		private void RegUnregMsg(bool reg)
		{
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x1A5FF38", Offset = "0x1A5FF38", VA = "0x1A5FF38")]
		private void ChangeColorByMsg(int index)
		{
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x1A60044", Offset = "0x1A60044", VA = "0x1A60044")]
		public AnycolorGlowStickComponent()
		{
		}
	}
	[Token(Token = "0x200010A")]
	public class AnycolorInteraction : AnycolorIMgr
	{
		[Token(Token = "0x200010B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124D9A4", Offset = "0x124D9A4")]
		private sealed class <StartInit>d__31 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AnycolorInteraction <>4__this;

			[Token(Token = "0x40005DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public AnycolorConfig anycolorConfig;

			[Token(Token = "0x17000076")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005C1")]
				[Address(RVA = "0x3109CE8", Offset = "0x3109CE8", VA = "0x3109CE8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000077")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005C3")]
				[Address(RVA = "0x3109D30", Offset = "0x3109D30", VA = "0x3109D30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005BE")]
			[Address(RVA = "0x3109C78", Offset = "0x3109C78", VA = "0x3109C78")]
			[DebuggerHidden]
			public <StartInit>d__31(int <>1__state)
			{
			}

			[Token(Token = "0x60005BF")]
			[Address(RVA = "0x3109CA4", Offset = "0x3109CA4", VA = "0x3109CA4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005C0")]
			[Address(RVA = "0x3109CA8", Offset = "0x3109CA8", VA = "0x3109CA8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005C2")]
			[Address(RVA = "0x3109CF0", Offset = "0x3109CF0", VA = "0x3109CF0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200010C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124D9B4", Offset = "0x124D9B4")]
		private sealed class <DelayUseFireworksTips>d__42 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AnycolorInteraction <>4__this;

			[Token(Token = "0x17000078")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005C7")]
				[Address(RVA = "0x3109C28", Offset = "0x3109C28", VA = "0x3109C28", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000079")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005C9")]
				[Address(RVA = "0x3109C70", Offset = "0x3109C70", VA = "0x3109C70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005C4")]
			[Address(RVA = "0x3109A1C", Offset = "0x3109A1C", VA = "0x3109A1C")]
			[DebuggerHidden]
			public <DelayUseFireworksTips>d__42(int <>1__state)
			{
			}

			[Token(Token = "0x60005C5")]
			[Address(RVA = "0x3109A48", Offset = "0x3109A48", VA = "0x3109A48", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005C6")]
			[Address(RVA = "0x3109A4C", Offset = "0x3109A4C", VA = "0x3109A4C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005C8")]
			[Address(RVA = "0x3109C30", Offset = "0x3109C30", VA = "0x3109C30", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200010D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124D9C4", Offset = "0x124D9C4")]
		private sealed class <DelayCloseCollisionCount>d__45 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AnycolorInteraction <>4__this;

			[Token(Token = "0x1700007A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005CD")]
				[Address(RVA = "0x31099CC", Offset = "0x31099CC", VA = "0x31099CC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005CF")]
				[Address(RVA = "0x3109A14", Offset = "0x3109A14", VA = "0x3109A14", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005CA")]
			[Address(RVA = "0x31098C0", Offset = "0x31098C0", VA = "0x31098C0")]
			[DebuggerHidden]
			public <DelayCloseCollisionCount>d__45(int <>1__state)
			{
			}

			[Token(Token = "0x60005CB")]
			[Address(RVA = "0x31098EC", Offset = "0x31098EC", VA = "0x31098EC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005CC")]
			[Address(RVA = "0x31098F0", Offset = "0x31098F0", VA = "0x31098F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005CE")]
			[Address(RVA = "0x31099D4", Offset = "0x31099D4", VA = "0x31099D4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string GET_FIREWORK_LANG_KEY;

		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string FIREWORK_SHOT_LANG_KEY;

		[Token(Token = "0x40005C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static bool CollisionModeSwitch;

		[Token(Token = "0x40005C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private AnycolorConfig _anycolorConfig;

		[Token(Token = "0x40005C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private AnycolorTracking _tracking;

		[Token(Token = "0x40005C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GameObject _interactionRootGo;

		[Token(Token = "0x40005C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GameObject _OpenStageEffectObj;

		[Token(Token = "0x40005CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float _openStageTimeAccumulate;

		[Token(Token = "0x40005CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static string FireworksGameTrackingTitle;

		[Token(Token = "0x40005CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static string FireworksEffectTracking;

		[Token(Token = "0x40005CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int _fireworksCount;

		[Token(Token = "0x40005CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool _isGetFireworksOn;

		[Token(Token = "0x40005CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		private bool _isShowGetFireworksTips;

		[Token(Token = "0x40005D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int _collisionCount;

		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float _lastCollisionTime;

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float _collisionInterval;

		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int _collisionCountThreshold;

		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Coroutine _fireworksUseTipsCor;

		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Coroutine _collisionCountCor;

		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool _isOpenStageOn;

		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject _danceEffectGo;

		[Token(Token = "0x17000073")]
		public AnycolorTracking Tracking
		{
			[Token(Token = "0x6000598")]
			[Address(RVA = "0x1A60818", Offset = "0x1A60818", VA = "0x1A60818")]
			set
			{
			}
		}

		[Token(Token = "0x17000074")]
		public bool IsGetFireworksOn
		{
			[Token(Token = "0x6000599")]
			[Address(RVA = "0x1A60820", Offset = "0x1A60820", VA = "0x1A60820")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600059A")]
			[Address(RVA = "0x1A59934", Offset = "0x1A59934", VA = "0x1A59934")]
			set
			{
			}
		}

		[Token(Token = "0x17000075")]
		public bool IsOpenStageOn
		{
			[Token(Token = "0x600059B")]
			[Address(RVA = "0x1A60D70", Offset = "0x1A60D70", VA = "0x1A60D70")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600059C")]
			[Address(RVA = "0x1A60D78", Offset = "0x1A60D78", VA = "0x1A60D78")]
			set
			{
			}
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x1A610F8", Offset = "0x1A610F8", VA = "0x1A610F8")]
		public void InitInteraction(AnycolorConfig anycolorConfig)
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x1A61264", Offset = "0x1A61264", VA = "0x1A61264")]
		public void DisposeInteraction()
		{
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x1A613C0", Offset = "0x1A613C0", VA = "0x1A613C0", Slot = "4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1251D58", Offset = "0x1251D58")]
		public IEnumerator StartInit(AnycolorConfig anycolorConfig)
		{
			return null;
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x1A61454", Offset = "0x1A61454", VA = "0x1A61454", Slot = "5")]
		public void Update(float deltaTime)
		{
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x1A60F34", Offset = "0x1A60F34", VA = "0x1A60F34")]
		private void ShowOpenStageEffect()
		{
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x1A61038", Offset = "0x1A61038", VA = "0x1A61038")]
		private void ReleaseOpenStageEffect()
		{
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x1A5DE2C", Offset = "0x1A5DE2C", VA = "0x1A5DE2C")]
		public void FireworksRightTriggerPressed(string modelStr)
		{
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x1A614F0", Offset = "0x1A614F0", VA = "0x1A614F0")]
		private void LiveItemLocalUnUsed(LiveItemType type)
		{
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x1A61500", Offset = "0x1A61500", VA = "0x1A61500")]
		private string GetFireworksModelName(int actorColorIndex)
		{
			return null;
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x1A5F630", Offset = "0x1A5F630", VA = "0x1A5F630")]
		public void GlowStickTriggerEnter(AnycolorActor actor)
		{
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x1A619E8", Offset = "0x1A619E8", VA = "0x1A619E8")]
		public void UseFireworks(int actorColorIndex)
		{
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x1A61848", Offset = "0x1A61848", VA = "0x1A61848")]
		private void UseFireworksTips()
		{
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x1A6137C", Offset = "0x1A6137C", VA = "0x1A6137C")]
		public void ReleaseFireworksUseTimer()
		{
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x1A61B98", Offset = "0x1A61B98", VA = "0x1A61B98")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1251DB8", Offset = "0x1251DB8")]
		private IEnumerator DelayUseFireworksTips()
		{
			return null;
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x1A61608", Offset = "0x1A61608", VA = "0x1A61608")]
		private void SetGlowStickTouchNum(int num)
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x1A61338", Offset = "0x1A61338", VA = "0x1A61338")]
		private void ReleaseCollisionCount()
		{
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x1A61C10", Offset = "0x1A61C10", VA = "0x1A61C10")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1251E18", Offset = "0x1251E18")]
		private IEnumerator DelayCloseCollisionCount()
		{
			return null;
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x1A61884", Offset = "0x1A61884", VA = "0x1A61884")]
		private void CloseGlowStickTouchNum()
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x1A5D124", Offset = "0x1A5D124", VA = "0x1A5D124")]
		public void BeginFireworks(AnycolorActor actor, Vector3 position, Quaternion rota, Vector3 scale, bool isMyFirework = false)
		{
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x1A5BFF4", Offset = "0x1A5BFF4", VA = "0x1A5BFF4")]
		public void BeginFireworksDispersal(AnycolorActor actor, int index, Vector3 position)
		{
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x1A56C00", Offset = "0x1A56C00", VA = "0x1A56C00")]
		public void AddDanceEffect(AnycolorActor actor)
		{
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x1A56A24", Offset = "0x1A56A24", VA = "0x1A56A24")]
		public void ReleaseDanceEffect()
		{
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x1A61E54", Offset = "0x1A61E54", VA = "0x1A61E54", Slot = "6")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x1A61E58", Offset = "0x1A61E58", VA = "0x1A61E58", Slot = "7")]
		public void OnSeiSignal(string name, bool isOn, int offset)
		{
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x1A60828", Offset = "0x1A60828", VA = "0x1A60828")]
		public void EnterGetFireworksGameTracking()
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x1A60B30", Offset = "0x1A60B30", VA = "0x1A60B30")]
		public void StayGetFireworksGameTracking()
		{
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x1A61458", Offset = "0x1A61458", VA = "0x1A61458")]
		public void TriggerFireworksEffectsTracking(string effects_type)
		{
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x1A608C4", Offset = "0x1A608C4", VA = "0x1A608C4")]
		public void ForceUseGlowStick()
		{
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x1A60BE4", Offset = "0x1A60BE4", VA = "0x1A60BE4")]
		private void ForceReleaseFireworks()
		{
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x1A4CCE4", Offset = "0x1A4CCE4", VA = "0x1A4CCE4")]
		public void UpdateGlowStickCollisionDetection([Optional] LiveItemEntity entity)
		{
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x1A61E5C", Offset = "0x1A61E5C", VA = "0x1A61E5C")]
		private void SetItemCollisionDetectionMode(GameObject go, CollisionDetectionMode collisionDetectionMode)
		{
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x1A508F8", Offset = "0x1A508F8", VA = "0x1A508F8")]
		public AnycolorInteraction()
		{
		}
	}
	[Token(Token = "0x200010E")]
	public class AnycolorOpenStageEffect : MonoBehaviour
	{
		[Token(Token = "0x200010F")]
		private enum EmitDirection
		{
			[Token(Token = "0x40005F6")]
			ALeft,
			[Token(Token = "0x40005F7")]
			ARight,
			[Token(Token = "0x40005F8")]
			BLeft,
			[Token(Token = "0x40005F9")]
			BRight
		}

		[Token(Token = "0x2000110")]
		private class FlyingBullet
		{
			[Token(Token = "0x40005FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GameObject bullet;

			[Token(Token = "0x40005FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 p1;

			[Token(Token = "0x40005FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Vector3 p2;

			[Token(Token = "0x40005FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector3 p3;

			[Token(Token = "0x40005FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float flyingTime;

			[Token(Token = "0x60005D9")]
			[Address(RVA = "0x3109D38", Offset = "0x3109D38", VA = "0x3109D38")]
			public FlyingBullet(GameObject bullet, Vector3 p1, Vector3 p2, Vector3 p3, float flyingTime)
			{
			}
		}

		[Token(Token = "0x2000111")]
		private class OtherUserEmitter
		{
			[Token(Token = "0x40005FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float timeTick;

			[Token(Token = "0x4000600")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float emitTime;

			[Token(Token = "0x4000601")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 pos;

			[Token(Token = "0x60005DA")]
			[Address(RVA = "0x3109DD0", Offset = "0x3109DD0", VA = "0x3109DD0")]
			public OtherUserEmitter(float timeTick, float emitTime, Vector3 pos)
			{
			}
		}

		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private AnycolorTracking _tracking;

		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject BulletALeft;

		[Token(Token = "0x40005E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject BulletARight;

		[Token(Token = "0x40005E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject BulletBLeft;

		[Token(Token = "0x40005E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject BulletBRight;

		[Token(Token = "0x40005E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public GameObject StandEffect;

		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AnycolorConfig _anycolorConfig;

		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Dictionary<EmitDirection, Queue<GameObject>> _bulletPool;

		[Token(Token = "0x40005EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Dictionary<EmitDirection, GameObject> _bulletTemplate;

		[Token(Token = "0x40005EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private List<OtherUserEmitter> OtherUserTimeTick;

		[Token(Token = "0x40005EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private List<FlyingBullet> FlyingBullets;

		[Token(Token = "0x40005ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float FlyTime;

		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float EmitWaitTime;

		[Token(Token = "0x40005EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float _handHeadOffset;

		[Token(Token = "0x40005F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float HandOnHeadEmitInterval;

		[Token(Token = "0x40005F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 LeftTargetPos;

		[Token(Token = "0x40005F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Vector3 RightTargetPos;

		[Token(Token = "0x40005F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool _handOnHead;

		[Token(Token = "0x40005F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private float _handOnHeadTime;

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x1A620B0", Offset = "0x1A620B0", VA = "0x1A620B0")]
		private void ShowStandEffect()
		{
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x1A620F4", Offset = "0x1A620F4", VA = "0x1A620F4")]
		private void Emit()
		{
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x1A628E8", Offset = "0x1A628E8", VA = "0x1A628E8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x1A62E80", Offset = "0x1A62E80", VA = "0x1A62E80")]
		private void Update()
		{
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x1A63580", Offset = "0x1A63580", VA = "0x1A63580")]
		private void EmitOtherUser(OtherUserEmitter otherEmitter)
		{
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x1A625E0", Offset = "0x1A625E0", VA = "0x1A625E0")]
		private GameObject GetBullet(EmitDirection direction)
		{
			return null;
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x1A6383C", Offset = "0x1A6383C", VA = "0x1A6383C")]
		private void RecycleBullet(GameObject bullet)
		{
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x1A62568", Offset = "0x1A62568", VA = "0x1A62568")]
		private void TriggerOpenStageEffectsTracking()
		{
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x1A63B00", Offset = "0x1A63B00", VA = "0x1A63B00")]
		public AnycolorOpenStageEffect()
		{
		}
	}
	[Token(Token = "0x2000112")]
	public enum AnycolorSEIEventName
	{
		[Token(Token = "0x4000603")]
		None,
		[Token(Token = "0x4000604")]
		glowstick_jhm,
		[Token(Token = "0x4000605")]
		glowstick_lx,
		[Token(Token = "0x4000606")]
		glowstick_xc,
		[Token(Token = "0x4000607")]
		glowstick_tk,
		[Token(Token = "0x4000608")]
		touch_snow,
		[Token(Token = "0x4000609")]
		fireworks,
		[Token(Token = "0x400060A")]
		open_stage,
		[Token(Token = "0x400060B")]
		dance_jhm_1,
		[Token(Token = "0x400060C")]
		dance_jhm_2,
		[Token(Token = "0x400060D")]
		dance_jhm_3,
		[Token(Token = "0x400060E")]
		dance_jhm_4,
		[Token(Token = "0x400060F")]
		dance_lx_1,
		[Token(Token = "0x4000610")]
		dance_lx_2,
		[Token(Token = "0x4000611")]
		dance_lx_3,
		[Token(Token = "0x4000612")]
		dance_lx_4,
		[Token(Token = "0x4000613")]
		dance_xc_1,
		[Token(Token = "0x4000614")]
		dance_xc_2,
		[Token(Token = "0x4000615")]
		dance_xc_3,
		[Token(Token = "0x4000616")]
		dance_xc_4,
		[Token(Token = "0x4000617")]
		dance_tk_1,
		[Token(Token = "0x4000618")]
		dance_tk_2,
		[Token(Token = "0x4000619")]
		dance_tk_3,
		[Token(Token = "0x400061A")]
		dance_tk_4,
		[Token(Token = "0x400061B")]
		change_color_tips
	}
	[Token(Token = "0x2000113")]
	public class AnycolorSEIInfo
	{
		[Token(Token = "0x400061C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AnycolorSEIEventName SEIEventName;

		[Token(Token = "0x400061D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public bool IsOn;

		[Token(Token = "0x400061E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float LastOnTime;

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x2C74994", Offset = "0x2C74994", VA = "0x2C74994")]
		public AnycolorSEIInfo(AnycolorSEIEventName seiEventName, bool isOn)
		{
		}
	}
	[Token(Token = "0x2000114")]
	public class AnycolorSEI : AnycolorIMgr
	{
		[Token(Token = "0x2000115")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124D9D4", Offset = "0x124D9D4")]
		private sealed class <StartInit>d__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000626")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000627")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000628")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AnycolorSEI <>4__this;

			[Token(Token = "0x4000629")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public AnycolorConfig anycolorConfig;

			[Token(Token = "0x1700007E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000602")]
				[Address(RVA = "0x310A194", Offset = "0x310A194", VA = "0x310A194", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000604")]
				[Address(RVA = "0x310A1DC", Offset = "0x310A1DC", VA = "0x310A1DC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005FF")]
			[Address(RVA = "0x310A124", Offset = "0x310A124", VA = "0x310A124")]
			[DebuggerHidden]
			public <StartInit>d__16(int <>1__state)
			{
			}

			[Token(Token = "0x6000600")]
			[Address(RVA = "0x310A150", Offset = "0x310A150", VA = "0x310A150", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000601")]
			[Address(RVA = "0x310A154", Offset = "0x310A154", VA = "0x310A154", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000603")]
			[Address(RVA = "0x310A19C", Offset = "0x310A19C", VA = "0x310A19C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400061F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private AnycolorInteraction _interaction;

		[Token(Token = "0x4000620")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static float SeiOffset;

		[Token(Token = "0x4000621")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private AnycolorConfig _anycolorConfig;

		[Token(Token = "0x4000622")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<string, Action<string, bool, int>> _seiActionDict;

		[Token(Token = "0x4000623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Dictionary<string, AnycolorDanceFlag> _dance2FlagDict;

		[Token(Token = "0x4000624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Dictionary<AnycolorSEIEventName, AnycolorSEIInfo> _switchDict;

		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Dictionary<string, AnycolorSEIEventName> _seiEventStr2Enum;

		[Token(Token = "0x1700007C")]
		public AnycolorInteraction Interaction
		{
			[Token(Token = "0x60005DC")]
			[Address(RVA = "0x1A648C8", Offset = "0x1A648C8", VA = "0x1A648C8")]
			set
			{
			}
		}

		[Token(Token = "0x1700007D")]
		public bool GetFireworksOn
		{
			[Token(Token = "0x60005DD")]
			[Address(RVA = "0x1A648D0", Offset = "0x1A648D0", VA = "0x1A648D0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x1A6495C", Offset = "0x1A6495C", VA = "0x1A6495C")]
		public void InitSEI(AnycolorConfig anycolorConfig)
		{
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x1A64984", Offset = "0x1A64984", VA = "0x1A64984")]
		private void InitSEIEvent()
		{
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x1A64E8C", Offset = "0x1A64E8C", VA = "0x1A64E8C")]
		private void SEIStr2Action(AnycolorSEIEventName seiEnum)
		{
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x1A65124", Offset = "0x1A65124", VA = "0x1A65124")]
		private void SEI2DanceFlag(AnycolorSEIEventName seiEnum)
		{
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x1A6521C", Offset = "0x1A6521C", VA = "0x1A6521C")]
		public void DisposeSEI()
		{
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x1A65220", Offset = "0x1A65220", VA = "0x1A65220", Slot = "4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1251F68", Offset = "0x1251F68")]
		public IEnumerator StartInit(AnycolorConfig anycolorConfig)
		{
			return null;
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x1A652B4", Offset = "0x1A652B4", VA = "0x1A652B4", Slot = "5")]
		public void Update(float deltaTime)
		{
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x1A652B8", Offset = "0x1A652B8", VA = "0x1A652B8")]
		private void UpdateCheckSwitch()
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x1A6548C", Offset = "0x1A6548C", VA = "0x1A6548C", Slot = "6")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x1A65490", Offset = "0x1A65490", VA = "0x1A65490", Slot = "7")]
		public void OnSeiSignal(string name, bool isOn, int offset)
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x1A65450", Offset = "0x1A65450", VA = "0x1A65450")]
		private void SetSEIInfo(AnycolorSEIInfo seiInfo, bool isOn)
		{
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x1A65690", Offset = "0x1A65690", VA = "0x1A65690")]
		public void OnSeiSignalSyncTime(string name, bool isOn, int offset)
		{
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x1A65694", Offset = "0x1A65694", VA = "0x1A65694")]
		public void OnSeiSignalJHM(string name, bool isOn, int offset)
		{
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x1A65984", Offset = "0x1A65984", VA = "0x1A65984")]
		public void OnChangeColorLX(string name, bool isOn, int offset)
		{
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x1A65C74", Offset = "0x1A65C74", VA = "0x1A65C74")]
		public void OnChangeColorXC(string name, bool isOn, int offset)
		{
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x1A65F64", Offset = "0x1A65F64", VA = "0x1A65F64")]
		public void OnChangeColorTK(string name, bool isOn, int offset)
		{
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x1A66254", Offset = "0x1A66254", VA = "0x1A66254")]
		public void OnOpenStage(string name, bool isOn, int offset)
		{
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x1A66638", Offset = "0x1A66638", VA = "0x1A66638")]
		public void OnGetFireworks(string name, bool isOn, int offset)
		{
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x1A66A5C", Offset = "0x1A66A5C", VA = "0x1A66A5C")]
		public void OnTouchSnow(string name, bool isOn, int offset)
		{
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x1A66E48", Offset = "0x1A66E48", VA = "0x1A66E48")]
		public void OnDance(string name, bool isOn, int offset)
		{
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x1A67308", Offset = "0x1A67308", VA = "0x1A67308")]
		public void OnChangeColorTips(string name, bool isOn, int offset)
		{
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x1A65828", Offset = "0x1A65828", VA = "0x1A65828")]
		private void ChangcolorJHMLogic(AnycolorSEIInfo info)
		{
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x1A65B18", Offset = "0x1A65B18", VA = "0x1A65B18")]
		private void ChangcolorLXLogic(AnycolorSEIInfo info)
		{
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x1A65E08", Offset = "0x1A65E08", VA = "0x1A65E08")]
		private void ChangcolorXCLogic(AnycolorSEIInfo info)
		{
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x1A660F8", Offset = "0x1A660F8", VA = "0x1A660F8")]
		private void ChangcolorTKLogic(AnycolorSEIInfo info)
		{
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x1A667D0", Offset = "0x1A667D0", VA = "0x1A667D0")]
		private void GetFireworksOnLogic(AnycolorSEIInfo info)
		{
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x1A66BF0", Offset = "0x1A66BF0", VA = "0x1A66BF0")]
		private void TouchSnowOnLogic(AnycolorSEIInfo info)
		{
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x1A663E8", Offset = "0x1A663E8", VA = "0x1A663E8")]
		private void OpenStageOnLogic(AnycolorSEIInfo info)
		{
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x1A67004", Offset = "0x1A67004", VA = "0x1A67004")]
		public void DanceOnLogic(bool isOn, AnycolorSEIInfo info, int offset)
		{
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x1A6749C", Offset = "0x1A6749C", VA = "0x1A6749C")]
		private void OnChangeColorTips(AnycolorSEIInfo info)
		{
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x1A59C1C", Offset = "0x1A59C1C", VA = "0x1A59C1C")]
		public void OnSeiSignal4Debug(string name)
		{
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x1A50908", Offset = "0x1A50908", VA = "0x1A50908")]
		public AnycolorSEI()
		{
		}
	}
	[Token(Token = "0x2000116")]
	public class ActorEffectPlayer : MonoBehaviour
	{
		[Token(Token = "0x400062A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject AShowEffect;

		[Token(Token = "0x400062B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject BShowEffect;

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x1A49F84", Offset = "0x1A49F84", VA = "0x1A49F84")]
		public void ShowActorEffect(bool showIsA)
		{
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x1A49FE8", Offset = "0x1A49FE8", VA = "0x1A49FE8")]
		public ActorEffectPlayer()
		{
		}
	}
	[Token(Token = "0x2000117")]
	[ExecuteInEditMode]
	public class FollowTargetPos : MonoBehaviour
	{
		[Token(Token = "0x400062C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x400062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 PosOffset;

		[Token(Token = "0x400062E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool UseInitOffset;

		[Token(Token = "0x400062F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		public bool FollowRot;

		[Token(Token = "0x6000607")]
		[Address(RVA = "0x2C8464C", Offset = "0x2C8464C", VA = "0x2C8464C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0x2C84790", Offset = "0x2C84790", VA = "0x2C84790")]
		private void TrySetTarget()
		{
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x2C8487C", Offset = "0x2C8487C", VA = "0x2C8487C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0x2C849C0", Offset = "0x2C849C0", VA = "0x2C849C0")]
		public FollowTargetPos()
		{
		}
	}
	[Token(Token = "0x2000118")]
	public class ParticleCollider : MonoBehaviour
	{
		[Token(Token = "0x4000630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private PXR_Input.VibrateController _hand;

		[Token(Token = "0x4000631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TouchEffectMgr _touchEffectMgr;

		[Token(Token = "0x4000632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private VibrateMgr _vibrateMgr;

		[Token(Token = "0x600060B")]
		[Address(RVA = "0x3F6F978", Offset = "0x3F6F978", VA = "0x3F6F978")]
		public void SetHand(PXR_Input.VibrateController hand)
		{
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0x3F6F980", Offset = "0x3F6F980", VA = "0x3F6F980")]
		private void OnParticleCollision(GameObject other)
		{
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0x3F6FAD0", Offset = "0x3F6FAD0", VA = "0x3F6FAD0")]
		private void StartVibrate()
		{
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0x3F6FB08", Offset = "0x3F6FB08", VA = "0x3F6FB08")]
		private VibrateMgr GetVibrateMgr()
		{
			return null;
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0x3F6F9B0", Offset = "0x3F6F9B0", VA = "0x3F6F9B0")]
		private TouchEffectMgr GetTouchEffectMgr()
		{
			return null;
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0x3F6FC28", Offset = "0x3F6FC28", VA = "0x3F6FC28")]
		public ParticleCollider()
		{
		}
	}
	[Token(Token = "0x2000119")]
	public class TouchEffectMgr : AnycolorIMgr
	{
		[Token(Token = "0x200011A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124D9F4", Offset = "0x124D9F4")]
		private sealed class <StartInit>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400063A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400063B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400063C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TouchEffectMgr <>4__this;

			[Token(Token = "0x17000081")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600061E")]
				[Address(RVA = "0x3110260", Offset = "0x3110260", VA = "0x3110260", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000082")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000620")]
				[Address(RVA = "0x31102A8", Offset = "0x31102A8", VA = "0x31102A8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600061B")]
			[Address(RVA = "0x310FE08", Offset = "0x310FE08", VA = "0x310FE08")]
			[DebuggerHidden]
			public <StartInit>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x600061C")]
			[Address(RVA = "0x310FE34", Offset = "0x310FE34", VA = "0x310FE34", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600061D")]
			[Address(RVA = "0x310FE38", Offset = "0x310FE38", VA = "0x310FE38", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600061F")]
			[Address(RVA = "0x3110268", Offset = "0x3110268", VA = "0x3110268", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AnycolorTracking Tracking;

		[Token(Token = "0x4000634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private AnycolorConfig _anycolorConfig;

		[Token(Token = "0x4000635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GameObject _effectRootGo;

		[Token(Token = "0x4000636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GameObject _effectObj;

		[Token(Token = "0x4000637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private GameObject _virtualLeftHand;

		[Token(Token = "0x4000638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private GameObject _virtualRightHand;

		[Token(Token = "0x4000639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool _isTouchVibrateOpen;

		[Token(Token = "0x17000080")]
		public bool VibrateTouchVibrateOpen
		{
			[Token(Token = "0x6000611")]
			[Address(RVA = "0x2B54DA8", Offset = "0x2B54DA8", VA = "0x2B54DA8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000612")]
			[Address(RVA = "0x2B54DB0", Offset = "0x2B54DB0", VA = "0x2B54DB0")]
			set
			{
			}
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x2B54F0C", Offset = "0x2B54F0C", VA = "0x2B54F0C", Slot = "4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1252018", Offset = "0x1252018")]
		public IEnumerator StartInit(AnycolorConfig anycolorConfig)
		{
			return null;
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0x2B54F84", Offset = "0x2B54F84", VA = "0x2B54F84", Slot = "5")]
		public void Update(float deltaTime)
		{
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0x2B54F88", Offset = "0x2B54F88", VA = "0x2B54F88", Slot = "6")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0x2B5518C", Offset = "0x2B5518C", VA = "0x2B5518C", Slot = "7")]
		public void OnSeiSignal(string name, bool isOn, int offset)
		{
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0x2B55190", Offset = "0x2B55190", VA = "0x2B55190")]
		public void StartEffectShow()
		{
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x2B55394", Offset = "0x2B55394", VA = "0x2B55394")]
		public void StopEffectShow()
		{
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x2B55428", Offset = "0x2B55428", VA = "0x2B55428")]
		public void PostTouchTracking()
		{
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x2B55498", Offset = "0x2B55498", VA = "0x2B55498")]
		public TouchEffectMgr()
		{
		}
	}
	[Token(Token = "0x200011B")]
	public class AnycolorBaseWnd : MonoBehaviour
	{
		[Token(Token = "0x200011C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124DA04", Offset = "0x124DA04")]
		private sealed class <DelayClose>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000644")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000645")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000646")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AnycolorBaseWnd <>4__this;

			[Token(Token = "0x17000084")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600062C")]
				[Address(RVA = "0x31094F4", Offset = "0x31094F4", VA = "0x31094F4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000085")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600062E")]
				[Address(RVA = "0x310953C", Offset = "0x310953C", VA = "0x310953C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000629")]
			[Address(RVA = "0x31092A8", Offset = "0x31092A8", VA = "0x31092A8")]
			[DebuggerHidden]
			public <DelayClose>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x600062A")]
			[Address(RVA = "0x31092D4", Offset = "0x31092D4", VA = "0x31092D4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600062B")]
			[Address(RVA = "0x31092D8", Offset = "0x31092D8", VA = "0x31092D8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600062D")]
			[Address(RVA = "0x31094FC", Offset = "0x31094FC", VA = "0x31094FC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400063D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject TextGo;

		[Token(Token = "0x400063E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject PositionGo;

		[Token(Token = "0x400063F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject RotationGo;

		[Token(Token = "0x4000640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float DelayCloseSec;

		[Token(Token = "0x4000641")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public AnycolorWnd WndType;

		[Token(Token = "0x4000642")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float DefaultPosY;

		[Token(Token = "0x4000643")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private AnycolorTipsType _acTipsType;

		[Token(Token = "0x17000083")]
		public AnycolorTipsType AcTipsType
		{
			[Token(Token = "0x6000621")]
			[Address(RVA = "0x1A53D8C", Offset = "0x1A53D8C", VA = "0x1A53D8C")]
			set
			{
			}
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0x1A53D94", Offset = "0x1A53D94", VA = "0x1A53D94")]
		private void Start()
		{
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0x1A53E50", Offset = "0x1A53E50", VA = "0x1A53E50")]
		public void SetFixPositionAngle(Vector3 offset, Vector3 angle)
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0x1A54024", Offset = "0x1A54024", VA = "0x1A54024")]
		public void SetTextI18n(string langKey, params string[] variables)
		{
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0x1A54128", Offset = "0x1A54128", VA = "0x1A54128")]
		public void SetText(string str)
		{
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0x1A54138", Offset = "0x1A54138", VA = "0x1A54138")]
		public void SetGoText(GameObject go, string str)
		{
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0x1A542A8", Offset = "0x1A542A8", VA = "0x1A542A8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x12520C8", Offset = "0x12520C8")]
		protected IEnumerator DelayClose()
		{
			return null;
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0x1A54320", Offset = "0x1A54320", VA = "0x1A54320")]
		public AnycolorBaseWnd()
		{
		}
	}
	[Token(Token = "0x200011D")]
	public class AnycolorDebugController : MonoBehaviour
	{
		[Token(Token = "0x4000647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TMP_Dropdown DanceDropDown;

		[Token(Token = "0x4000648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<AnycolorDanceFlag> _danceFlagList;

		[Token(Token = "0x4000649")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Text PosForwardTxt;

		[Token(Token = "0x400064A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Text PosHeightTxt;

		[Token(Token = "0x400064B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Text HeightTxt;

		[Token(Token = "0x400064C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Text ScaleTxt;

		[Token(Token = "0x400064D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Text AngleTxt;

		[Token(Token = "0x400064E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static float PosHeight;

		[Token(Token = "0x400064F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static float PosForward;

		[Token(Token = "0x4000650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static float FireworkHeight;

		[Token(Token = "0x4000651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static float FireworkScale;

		[Token(Token = "0x4000652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static float FireworkAngle;

		[Token(Token = "0x600062F")]
		[Address(RVA = "0x1A58180", Offset = "0x1A58180", VA = "0x1A58180")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0x1A58780", Offset = "0x1A58780", VA = "0x1A58780")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0x1A58940", Offset = "0x1A58940", VA = "0x1A58940")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0x1A5849C", Offset = "0x1A5849C", VA = "0x1A5849C")]
		private void InitDanceDropDown()
		{
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0x1A58788", Offset = "0x1A58788", VA = "0x1A58788")]
		private void RegUnreg(bool reg)
		{
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0x1A58948", Offset = "0x1A58948", VA = "0x1A58948")]
		private void OnDanceDropdownValueChanged(int choose)
		{
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x1A58B20", Offset = "0x1A58B20", VA = "0x1A58B20")]
		public void OnOpenDebugBtn()
		{
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x1A58DAC", Offset = "0x1A58DAC", VA = "0x1A58DAC")]
		public void OnCloseBtn()
		{
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x1A58E6C", Offset = "0x1A58E6C", VA = "0x1A58E6C")]
		public void OnBtnWithString(string param)
		{
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x1A59AC0", Offset = "0x1A59AC0", VA = "0x1A59AC0")]
		public void OnBtn4SEI(string seiName)
		{
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0x1A581A4", Offset = "0x1A581A4", VA = "0x1A581A4")]
		private void UpdateTextShow()
		{
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0x1A59DAC", Offset = "0x1A59DAC", VA = "0x1A59DAC")]
		public void OnHeightAddBtn()
		{
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0x1A59E24", Offset = "0x1A59E24", VA = "0x1A59E24")]
		public void OnHeightSubBtn()
		{
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0x1A59E9C", Offset = "0x1A59E9C", VA = "0x1A59E9C")]
		public void OnScaleAddBtn()
		{
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0x1A59F18", Offset = "0x1A59F18", VA = "0x1A59F18")]
		public void OnScaleSubBtn()
		{
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x1A59F94", Offset = "0x1A59F94", VA = "0x1A59F94")]
		public void OnPosAddBtn()
		{
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x1A5A00C", Offset = "0x1A5A00C", VA = "0x1A5A00C")]
		public void OnPosSubBtn()
		{
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0x1A5A084", Offset = "0x1A5A084", VA = "0x1A5A084")]
		public void OnPosForwardAddBtn()
		{
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0x1A5A0FC", Offset = "0x1A5A0FC", VA = "0x1A5A0FC")]
		public void OnPosForwardSubBtn()
		{
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0x1A5A174", Offset = "0x1A5A174", VA = "0x1A5A174")]
		public void OnAngleAddBtn()
		{
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x1A5A1EC", Offset = "0x1A5A1EC", VA = "0x1A5A1EC")]
		public void OnAngleSubBtn()
		{
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x1A5A264", Offset = "0x1A5A264", VA = "0x1A5A264")]
		public AnycolorDebugController()
		{
		}
	}
	[Token(Token = "0x200011E")]
	public class AnycolorGlowStickTouchNum : MonoBehaviour
	{
		[Token(Token = "0x4000653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject NumGo;

		[Token(Token = "0x4000654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject MaxNumGo;

		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int _maxCount;

		[Token(Token = "0x6000646")]
		[Address(RVA = "0x1A60168", Offset = "0x1A60168", VA = "0x1A60168")]
		private void Start()
		{
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x1A60224", Offset = "0x1A60224", VA = "0x1A60224")]
		public void SetNum(int num)
		{
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x1A60264", Offset = "0x1A60264", VA = "0x1A60264")]
		private void SetMaxNum()
		{
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x1A604C0", Offset = "0x1A604C0", VA = "0x1A604C0")]
		private void SetTextNum(GameObject go, string str)
		{
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x1A604C4", Offset = "0x1A604C4", VA = "0x1A604C4")]
		public void SetGoText(GameObject go, string str)
		{
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x1A60634", Offset = "0x1A60634", VA = "0x1A60634")]
		public AnycolorGlowStickTouchNum()
		{
		}
	}
	[Token(Token = "0x200011F")]
	public enum AnycolorTipsType
	{
		[Token(Token = "0x4000657")]
		None,
		[Token(Token = "0x4000658")]
		Dance,
		[Token(Token = "0x4000659")]
		OpenStage,
		[Token(Token = "0x400065A")]
		GetFirework,
		[Token(Token = "0x400065B")]
		GlowstickChangeColor
	}
	[Serializable]
	[Token(Token = "0x2000120")]
	public class AnycolorTipsTypeInfo
	{
		[Token(Token = "0x400065C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AnycolorTipsType TipsType;

		[Token(Token = "0x400065D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject ImgGo;

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x2C75824", Offset = "0x2C75824", VA = "0x2C75824")]
		public AnycolorTipsTypeInfo()
		{
		}
	}
	[Token(Token = "0x2000121")]
	public class AnycolorImgTipsWnd : AnycolorTipsWnd
	{
		[Token(Token = "0x400065E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public List<AnycolorTipsTypeInfo> TipsTypeInfoList;

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x1A60644", Offset = "0x1A60644", VA = "0x1A60644")]
		public void SetTipsType(AnycolorTipsType anycolorTipsType)
		{
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x1A60794", Offset = "0x1A60794", VA = "0x1A60794")]
		public AnycolorImgTipsWnd()
		{
		}
	}
	[Token(Token = "0x2000122")]
	public class AnycolorSettingsController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000123")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124DA14", Offset = "0x124DA14")]
		private sealed class <>c
		{
			[Token(Token = "0x4000660")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000661")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static UnityAction<bool> <>9__1_0;

			[Token(Token = "0x6000652")]
			[Address(RVA = "0x310A248", Offset = "0x310A248", VA = "0x310A248")]
			public <>c()
			{
			}

			[Token(Token = "0x6000653")]
			[Address(RVA = "0x310A250", Offset = "0x310A250", VA = "0x310A250")]
			internal void <Awake>b__1_0(bool isOn)
			{
			}
		}

		[Token(Token = "0x400065F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SwitchToggleEx danmukuSwitch;

		[Token(Token = "0x600064F")]
		[Address(RVA = "0x2C75130", Offset = "0x2C75130", VA = "0x2C75130")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x2C75264", Offset = "0x2C75264", VA = "0x2C75264")]
		public AnycolorSettingsController()
		{
		}
	}
	[Token(Token = "0x2000124")]
	public class AnycolorSwitchToggleOffHover : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000654")]
		[Address(RVA = "0x2C7526C", Offset = "0x2C7526C", VA = "0x2C7526C", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0x2C754C4", Offset = "0x2C754C4", VA = "0x2C754C4")]
		public AnycolorSwitchToggleOffHover()
		{
		}
	}
	[Token(Token = "0x2000125")]
	public class AnycolorTime : AnycolorBaseWnd
	{
		[Token(Token = "0x4000662")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public GameObject NumGo;

		[Token(Token = "0x4000663")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float _openStageTimeAccumulate;

		[Token(Token = "0x4000664")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float _beginTime;

		[Token(Token = "0x6000656")]
		[Address(RVA = "0x2C754CC", Offset = "0x2C754CC", VA = "0x2C754CC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0x2C754F4", Offset = "0x2C754F4", VA = "0x2C754F4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0x2C7581C", Offset = "0x2C7581C", VA = "0x2C7581C")]
		public AnycolorTime()
		{
		}
	}
	[Token(Token = "0x2000126")]
	public class AnycolorTipsWnd : AnycolorBaseWnd
	{
		[Token(Token = "0x2000127")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124DA24", Offset = "0x124DA24")]
		private sealed class <CustomLayout>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000667")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000668")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000669")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AnycolorTipsWnd <>4__this;

			[Token(Token = "0x17000086")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000664")]
				[Address(RVA = "0x310A470", Offset = "0x310A470", VA = "0x310A470", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000087")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000666")]
				[Address(RVA = "0x310A4B8", Offset = "0x310A4B8", VA = "0x310A4B8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000661")]
			[Address(RVA = "0x310A3A0", Offset = "0x310A3A0", VA = "0x310A3A0")]
			[DebuggerHidden]
			public <CustomLayout>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000662")]
			[Address(RVA = "0x310A3CC", Offset = "0x310A3CC", VA = "0x310A3CC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000663")]
			[Address(RVA = "0x310A3D0", Offset = "0x310A3D0", VA = "0x310A3D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000665")]
			[Address(RVA = "0x310A478", Offset = "0x310A478", VA = "0x310A478", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000665")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public RectTransform Target;

		[Token(Token = "0x4000666")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public RectTransform Follow;

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x2C7582C", Offset = "0x2C7582C", VA = "0x2C7582C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x2C758D0", Offset = "0x2C758D0", VA = "0x2C758D0")]
		private void CloneSizeAndPos()
		{
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0x2C75858", Offset = "0x2C75858", VA = "0x2C75858")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1252178", Offset = "0x1252178")]
		private IEnumerator CustomLayout()
		{
			return null;
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0x2C759D4", Offset = "0x2C759D4", VA = "0x2C759D4")]
		private void SetTipsText(string s, float delaySec = -1f)
		{
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0x2C75A38", Offset = "0x2C75A38", VA = "0x2C75A38")]
		public void SetTipsI18n(string langKey, float delaySec = -1f, params string[] variables)
		{
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0x2C75A9C", Offset = "0x2C75A9C", VA = "0x2C75A9C")]
		private void SetText1()
		{
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0x2C75AEC", Offset = "0x2C75AEC", VA = "0x2C75AEC")]
		private void SetText2()
		{
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0x2C75B3C", Offset = "0x2C75B3C", VA = "0x2C75B3C")]
		public AnycolorTipsWnd()
		{
		}
	}
	[Token(Token = "0x2000128")]
	public class AnycolorToastWnd : AnycolorBaseWnd
	{
		[Token(Token = "0x6000667")]
		[Address(RVA = "0x2C75B44", Offset = "0x2C75B44", VA = "0x2C75B44")]
		public void SetToastI18n(string langKey, float delaySec = -1f)
		{
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0x2C75C58", Offset = "0x2C75C58", VA = "0x2C75C58")]
		public AnycolorToastWnd()
		{
		}
	}
	[Token(Token = "0x2000129")]
	public enum AnycolorWnd
	{
		[Token(Token = "0x400066B")]
		None,
		[Token(Token = "0x400066C")]
		Debug,
		[Token(Token = "0x400066D")]
		MusicGame,
		[Token(Token = "0x400066E")]
		Toast,
		[Token(Token = "0x400066F")]
		Tips,
		[Token(Token = "0x4000670")]
		ImgTips,
		[Token(Token = "0x4000671")]
		GlowStickTouchNum,
		[Token(Token = "0x4000672")]
		Time
	}
	[Token(Token = "0x200012A")]
	public class AnycolorUIParam
	{
		[Token(Token = "0x4000673")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject WndGo;

		[Token(Token = "0x4000674")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AnycolorWnd Wnd;

		[Token(Token = "0x4000675")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public AnycolorTipsType TipsType;

		[Token(Token = "0x4000676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string LangKey;

		[Token(Token = "0x4000677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float Delay;

		[Token(Token = "0x4000678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string[] Variables;

		[Token(Token = "0x6000669")]
		[Address(RVA = "0x2C78148", Offset = "0x2C78148", VA = "0x2C78148")]
		public AnycolorUIParam()
		{
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0x2C773F8", Offset = "0x2C773F8", VA = "0x2C773F8")]
		public AnycolorUIParam(AnycolorWnd wnd, AnycolorTipsType anycolorTipsType, string langKey, float delay, params string[] variables)
		{
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0x2C77B50", Offset = "0x2C77B50", VA = "0x2C77B50")]
		public bool IsEqual(AnycolorUIParam other)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200012B")]
	public class AnycolorUI : AnycolorIMgr
	{
		[Token(Token = "0x200012C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124DA34", Offset = "0x124DA34")]
		private sealed class <>c__DisplayClass45_0
		{
			[Token(Token = "0x4000687")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AnycolorUIParam anycolorUIParam;

			[Token(Token = "0x6000692")]
			[Address(RVA = "0x310A580", Offset = "0x310A580", VA = "0x310A580")]
			public <>c__DisplayClass45_0()
			{
			}

			[Token(Token = "0x6000693")]
			[Address(RVA = "0x310A588", Offset = "0x310A588", VA = "0x310A588")]
			internal bool <CloseWndFromQueue>b__0(AnycolorUIParam th)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200012D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124DA44", Offset = "0x124DA44")]
		private sealed class <StartInit>d__48 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000688")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000689")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400068A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AnycolorUI <>4__this;

			[Token(Token = "0x17000089")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000697")]
				[Address(RVA = "0x310A6D4", Offset = "0x310A6D4", VA = "0x310A6D4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000699")]
				[Address(RVA = "0x310A71C", Offset = "0x310A71C", VA = "0x310A71C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000694")]
			[Address(RVA = "0x310A5BC", Offset = "0x310A5BC", VA = "0x310A5BC")]
			[DebuggerHidden]
			public <StartInit>d__48(int <>1__state)
			{
			}

			[Token(Token = "0x6000695")]
			[Address(RVA = "0x310A5E8", Offset = "0x310A5E8", VA = "0x310A5E8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000696")]
			[Address(RVA = "0x310A5EC", Offset = "0x310A5EC", VA = "0x310A5EC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000698")]
			[Address(RVA = "0x310A6DC", Offset = "0x310A6DC", VA = "0x310A6DC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private AnycolorConfig _anycolorConfig;

		[Token(Token = "0x400067A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private AnycolorUIConfig _uiConfig;

		[Token(Token = "0x400067B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GameObject _uiRootGo;

		[Token(Token = "0x400067C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GameObject _debugWnd;

		[Token(Token = "0x400067D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private GameObject _musicGameWnd;

		[Token(Token = "0x400067E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private GameObject _toastWnd;

		[Token(Token = "0x400067F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private GameObject _tipsWnd;

		[Token(Token = "0x4000680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private GameObject _imgTipsWnd;

		[Token(Token = "0x4000681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private GameObject _GlowStickNumWnd;

		[Token(Token = "0x4000682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Dictionary<AnycolorWnd, GameObject> _wndDict;

		[Token(Token = "0x4000683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Dictionary<AnycolorWnd, GameObject> _singleWndDict;

		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Queue<AnycolorUIParam> _wndQueue;

		[Token(Token = "0x4000685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private AnycolorUIParam _blockingQueueWnd;

		[Token(Token = "0x4000686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private AnycolorUIParam _openStageUIParam;

		[Token(Token = "0x17000088")]
		public Transform UIRoot
		{
			[Token(Token = "0x600066C")]
			[Address(RVA = "0x2C765D4", Offset = "0x2C765D4", VA = "0x2C765D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0x2C7671C", Offset = "0x2C7671C", VA = "0x2C7671C")]
		public bool IsSingleWndOpen(AnycolorWnd wndType)
		{
			return default(bool);
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0x2C76790", Offset = "0x2C76790", VA = "0x2C76790")]
		public void OpenDebug()
		{
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0x2C76990", Offset = "0x2C76990", VA = "0x2C76990")]
		public void OpenTime()
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x2C76A3C", Offset = "0x2C76A3C", VA = "0x2C76A3C")]
		public GameObject OpenMusicGameWnd()
		{
			return null;
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0x2C76AEC", Offset = "0x2C76AEC", VA = "0x2C76AEC")]
		public void CloseMusicGameWnd()
		{
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0x2C76BCC", Offset = "0x2C76BCC", VA = "0x2C76BCC")]
		public GameObject OpenToastWndSingle(string langKey, float delaySec = -1f)
		{
			return null;
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0x2C76DAC", Offset = "0x2C76DAC", VA = "0x2C76DAC")]
		public GameObject OpenTipsWndSingle(string langKey, float delaySec = -1f)
		{
			return null;
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x2C77020", Offset = "0x2C77020", VA = "0x2C77020")]
		public AnycolorUIParam OpenToastWnd(string langKey, float delaySec = -1f)
		{
			return null;
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0x2C7717C", Offset = "0x2C7717C", VA = "0x2C7717C")]
		public AnycolorUIParam OpenTipsWnd(string langKey, float delaySec = -1f)
		{
			return null;
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0x2C77190", Offset = "0x2C77190", VA = "0x2C77190")]
		public AnycolorUIParam OpenImgTipsWnd(string langKey, AnycolorTipsType anycolorTipsType, float delaySec = -1f, params string[] variables)
		{
			return null;
		}

		[Token(Token = "0x6000677")]
		private GameObject OpenWndImmediateWithType<T>(AnycolorWnd anycolorWnd, string langKey, AnycolorTipsType anycolorTipsType, float delaySec = -1f, params string[] variables)
		{
			return null;
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0x2C77034", Offset = "0x2C77034", VA = "0x2C77034")]
		public AnycolorUIParam OpenWndInternal(AnycolorWnd anycolorWnd, string langKey, AnycolorTipsType anycolorTipsType, float delaySec = -1f, params string[] variables)
		{
			return null;
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0x2C771A4", Offset = "0x2C771A4", VA = "0x2C771A4")]
		private AnycolorUIParam GetAnycolorUIParam(AnycolorWnd wnd, string langKey, AnycolorTipsType anycolorTipsType, float delaySec = -1f, params string[] variables)
		{
			return null;
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0x2C773B8", Offset = "0x2C773B8", VA = "0x2C773B8")]
		private GameObject OpenWndImmediate4Queue(AnycolorWnd wnd, string langKey, AnycolorTipsType anycolorTipsType, float delaySec = -1f, params string[] variables)
		{
			return null;
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0x2C76C60", Offset = "0x2C76C60", VA = "0x2C76C60")]
		private GameObject OpenToastWndImmediate(string langKey, float delaySec = -1f)
		{
			return null;
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0x2C76E40", Offset = "0x2C76E40", VA = "0x2C76E40")]
		private GameObject OpenTipsWndImmediate(string langKey, float delaySec = -1f)
		{
			return null;
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0x2C7746C", Offset = "0x2C7746C", VA = "0x2C7746C")]
		private GameObject OpenImgTipsWndImmediate(string langKey, AnycolorTipsType anycolorTipsType, float delaySec = -1f, params string[] variables)
		{
			return null;
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0x2C7754C", Offset = "0x2C7754C", VA = "0x2C7754C")]
		public GameObject OpenGlowStickTouchNumWnd()
		{
			return null;
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0x2C775FC", Offset = "0x2C775FC", VA = "0x2C775FC")]
		public void CloseGlowStickTouchNumWnd()
		{
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0x2C77604", Offset = "0x2C77604", VA = "0x2C77604")]
		private void FixPosition(GameObject go)
		{
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0x2C7683C", Offset = "0x2C7683C", VA = "0x2C7683C")]
		private GameObject OpenWndImmediate(AnycolorWnd wndType)
		{
			return null;
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0x2C76AF4", Offset = "0x2C76AF4", VA = "0x2C76AF4")]
		public void CloseWndFromSingle(AnycolorWnd wndType)
		{
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0x2C77960", Offset = "0x2C77960", VA = "0x2C77960")]
		public bool CloseBlockingQueueWnd(int instanceId)
		{
			return default(bool);
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0x2C77B9C", Offset = "0x2C77B9C", VA = "0x2C77B9C")]
		private void ShowWndOnQueue()
		{
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0x2C77C7C", Offset = "0x2C77C7C", VA = "0x2C77C7C")]
		private void CloseAllWnd(AnycolorWnd wndType)
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0x2C7783C", Offset = "0x2C7783C", VA = "0x2C7783C")]
		private GameObject GetWndSpawn(AnycolorWnd wndType)
		{
			return null;
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0x2C77D54", Offset = "0x2C77D54", VA = "0x2C77D54")]
		public void ShowOpenStageTips()
		{
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0x2C77E5C", Offset = "0x2C77E5C", VA = "0x2C77E5C")]
		public void CloseOpenStageTips()
		{
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0x2C780AC", Offset = "0x2C780AC", VA = "0x2C780AC")]
		public void CloseWndFromQueue(AnycolorWnd wndType, AnycolorTipsType tipsType, string langKey)
		{
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0x2C77EA0", Offset = "0x2C77EA0", VA = "0x2C77EA0")]
		public void CloseWndFromQueue(AnycolorUIParam anycolorUIParam)
		{
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0x2C78150", Offset = "0x2C78150", VA = "0x2C78150")]
		private bool IsUIUseQueue(AnycolorWnd anycolorWnd)
		{
			return default(bool);
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0x2C78178", Offset = "0x2C78178", VA = "0x2C78178")]
		private void DisposeUI()
		{
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0x2C78238", Offset = "0x2C78238", VA = "0x2C78238", Slot = "4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1252228", Offset = "0x1252228")]
		public IEnumerator StartInit(AnycolorConfig anycolorConfig)
		{
			return null;
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0x2C782B0", Offset = "0x2C782B0", VA = "0x2C782B0", Slot = "5")]
		public void Update(float deltaTime)
		{
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0x2C782B4", Offset = "0x2C782B4", VA = "0x2C782B4", Slot = "6")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0x2C782B8", Offset = "0x2C782B8", VA = "0x2C782B8", Slot = "7")]
		public void OnSeiSignal(string name, bool isOn, int offset)
		{
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0x2C782BC", Offset = "0x2C782BC", VA = "0x2C782BC")]
		public AnycolorUI()
		{
		}
	}
	[Token(Token = "0x200012E")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x124DA54", Offset = "0x124DA54")]
	public class AnycolorVibrateConfig : ScriptableObject
	{
		[Token(Token = "0x400068B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TextAsset FireworkOpenStagePHF;

		[Token(Token = "0x400068C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextAsset DanceGamePHF;

		[Token(Token = "0x400068D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TextAsset GlowStickPHF;

		[Token(Token = "0x400068E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public TextAsset ConfettiPHF;

		[Token(Token = "0x400068F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public TextAsset FireworkPHF;

		[Token(Token = "0x600069A")]
		[Address(RVA = "0x2C783DC", Offset = "0x2C783DC", VA = "0x2C783DC")]
		public AnycolorVibrateConfig()
		{
		}
	}
	[Token(Token = "0x200012F")]
	public class VibrateMgr : AnycolorIMgr
	{
		[Token(Token = "0x4000690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private AnycolorVibrateConfig _anycolorVibrateConfig;

		[Token(Token = "0x4000691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int sourceId;

		[Token(Token = "0x4000692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private bool _phfAvailable;

		[Token(Token = "0x4000693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Version TargetVersion;

		[Token(Token = "0x600069B")]
		[Address(RVA = "0x2B56DD8", Offset = "0x2B56DD8", VA = "0x2B56DD8")]
		public void FireworkOpenStageVibrate()
		{
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0x2B56EC8", Offset = "0x2B56EC8", VA = "0x2B56EC8")]
		public void DanceGameVibrate(PXR_Input.VibrateController leftOrRight)
		{
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0x2B56FA8", Offset = "0x2B56FA8", VA = "0x2B56FA8")]
		public void GlowStickVibrate()
		{
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0x2B57098", Offset = "0x2B57098", VA = "0x2B57098")]
		public void FireworkVibrate()
		{
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0x2B57188", Offset = "0x2B57188", VA = "0x2B57188")]
		public void ConfettiVibrate(PXR_Input.VibrateController leftOrRight)
		{
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x2B57268", Offset = "0x2B57268", VA = "0x2B57268")]
		public void NormalVibrate(PXR_Input.Controller hand)
		{
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x2B57278", Offset = "0x2B57278", VA = "0x2B57278")]
		public static bool CheckPhfAvailable()
		{
			return default(bool);
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x2B576CC", Offset = "0x2B576CC", VA = "0x2B576CC", Slot = "4")]
		public IEnumerator StartInit(AnycolorConfig anycolorConfig)
		{
			return null;
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x2B577C4", Offset = "0x2B577C4", VA = "0x2B577C4", Slot = "5")]
		public void Update(float deltaTime)
		{
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x2B577C8", Offset = "0x2B577C8", VA = "0x2B577C8", Slot = "6")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x2B577CC", Offset = "0x2B577CC", VA = "0x2B577CC", Slot = "7")]
		public void OnSeiSignal(string name, bool isOn, int offset)
		{
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x2B577D0", Offset = "0x2B577D0", VA = "0x2B577D0")]
		public VibrateMgr()
		{
		}
	}
}
namespace PicoLiveAKB48
{
	[Token(Token = "0x2000130")]
	public class AvatarSceneLightEnvData : MonoBehaviour
	{
		[Token(Token = "0x4000694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float additiveGI;

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x2C79498", Offset = "0x2C79498", VA = "0x2C79498")]
		public AvatarSceneLightEnvData()
		{
		}
	}
	[Token(Token = "0x2000131")]
	public class LevelChange : MonoBehaviour
	{
		[Token(Token = "0x4000695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Animator _animator;

		[Token(Token = "0x4000696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int _levelToLoad;

		[Token(Token = "0x4000697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int _currentLevelIndex;

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x3F6173C", Offset = "0x3F6173C", VA = "0x3F6173C")]
		private void Start()
		{
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x3F61814", Offset = "0x3F61814", VA = "0x3F61814")]
		private void Update()
		{
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x3F61868", Offset = "0x3F61868", VA = "0x3F61868")]
		private void FadeToNextLevel()
		{
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x3F618E8", Offset = "0x3F618E8", VA = "0x3F618E8")]
		private void FadeToPreviousLevel()
		{
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x3F61880", Offset = "0x3F61880", VA = "0x3F61880")]
		private void FadeToLevel(int levelIndex)
		{
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x3F61900", Offset = "0x3F61900", VA = "0x3F61900")]
		public void OnFadeComplete()
		{
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x3F619C0", Offset = "0x3F619C0", VA = "0x3F619C0")]
		public LevelChange()
		{
		}
	}
	[Token(Token = "0x2000132")]
	public class PipBalloon : PicoInteractiveProp
	{
		[Token(Token = "0x4000698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Material[] mBalloons;

		[Token(Token = "0x4000699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool bScale;

		[Token(Token = "0x400069A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public Vector2 moveTime;

		[Token(Token = "0x400069B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public Vector3 _endOffsetPos;

		[Token(Token = "0x400069C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 _offsetXYZ;

		[Token(Token = "0x400069D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private MeshRenderer _meshRenderer;

		[Token(Token = "0x400069E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Vector3 _initPos;

		[Token(Token = "0x400069F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 _endPos;

		[Token(Token = "0x40006A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float _randomScale;

		[Token(Token = "0x40006A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float _randomSpeed;

		[Token(Token = "0x40006A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Tween _moveTween;

		[Token(Token = "0x40006A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private WaveFloating _waveFloating;

		[Token(Token = "0x40006A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Vector3 _tempAddPos;

		[Token(Token = "0x40006A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		public bool _finisedMove;

		[Token(Token = "0x40006A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private float curTime;

		[Token(Token = "0x40006A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public GameObject WaveObj;

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x3F78EFC", Offset = "0x3F78EFC", VA = "0x3F78EFC", Slot = "4")]
		protected override void InitProp()
		{
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x3F7901C", Offset = "0x3F7901C", VA = "0x3F7901C")]
		private void ResetBalloon()
		{
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x3F79110", Offset = "0x3F79110", VA = "0x3F79110")]
		private void BalloonMove()
		{
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x3F7928C", Offset = "0x3F7928C", VA = "0x3F7928C")]
		private void Update()
		{
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x3F79320", Offset = "0x3F79320", VA = "0x3F79320", Slot = "5")]
		public override void TouchThis()
		{
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x3F79548", Offset = "0x3F79548", VA = "0x3F79548")]
		public PipBalloon()
		{
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x3F79558", Offset = "0x3F79558", VA = "0x3F79558")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x12522D8", Offset = "0x12522D8")]
		private void <BalloonMove>b__18_0()
		{
		}
	}
	[Token(Token = "0x2000133")]
	public class PipButterfly : PicoInteractiveProp
	{
		[Token(Token = "0x2000134")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124DAC0", Offset = "0x124DAC0")]
		private sealed class <AutoDetactive>d__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PipButterfly <>4__this;

			[Token(Token = "0x1700008B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006BF")]
				[Address(RVA = "0x310E324", Offset = "0x310E324", VA = "0x310E324", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006C1")]
				[Address(RVA = "0x310E36C", Offset = "0x310E36C", VA = "0x310E36C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006BC")]
			[Address(RVA = "0x310E238", Offset = "0x310E238", VA = "0x310E238")]
			[DebuggerHidden]
			public <AutoDetactive>d__5(int <>1__state)
			{
			}

			[Token(Token = "0x60006BD")]
			[Address(RVA = "0x310E264", Offset = "0x310E264", VA = "0x310E264", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006BE")]
			[Address(RVA = "0x310E268", Offset = "0x310E268", VA = "0x310E268", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006C0")]
			[Address(RVA = "0x310E32C", Offset = "0x310E32C", VA = "0x310E32C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40006A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public bool simulateAnimSpeed;

		[Token(Token = "0x40006A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float _animSpeed;

		[Token(Token = "0x40006AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Animation _animation;

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x3F79960", Offset = "0x3F79960", VA = "0x3F79960", Slot = "4")]
		protected override void InitProp()
		{
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x3F79A00", Offset = "0x3F79A00", VA = "0x3F79A00", Slot = "5")]
		public override void TouchThis()
		{
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x3F79AB0", Offset = "0x3F79AB0", VA = "0x3F79AB0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x12522E8", Offset = "0x12522E8")]
		private IEnumerator AutoDetactive()
		{
			return null;
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x3F79B28", Offset = "0x3F79B28", VA = "0x3F79B28")]
		private void Update()
		{
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x3F79BA4", Offset = "0x3F79BA4", VA = "0x3F79BA4")]
		public PipButterfly()
		{
		}
	}
	[Token(Token = "0x2000135")]
	public class PipCloud : PicoInteractiveProp
	{
		[Token(Token = "0x40006AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private ParticleSystem psEffect;

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x3F79BB0", Offset = "0x3F79BB0", VA = "0x3F79BB0", Slot = "4")]
		protected override void InitProp()
		{
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x3F79C1C", Offset = "0x3F79C1C", VA = "0x3F79C1C", Slot = "5")]
		public override void TouchThis()
		{
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x3F79C38", Offset = "0x3F79C38", VA = "0x3F79C38")]
		public PipCloud()
		{
		}
	}
	[Token(Token = "0x2000136")]
	public class PipFlower : PicoInteractiveProp
	{
		[Token(Token = "0x40006AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Animator FlowerAni;

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x3F7A730", Offset = "0x3F7A730", VA = "0x3F7A730", Slot = "4")]
		protected override void InitProp()
		{
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x3F7A860", Offset = "0x3F7A860", VA = "0x3F7A860", Slot = "5")]
		public override void TouchThis()
		{
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x3F7A90C", Offset = "0x3F7A90C", VA = "0x3F7A90C")]
		public PipFlower()
		{
		}
	}
	[Token(Token = "0x2000137")]
	public class PipLove : PicoInteractiveProp
	{
		[Token(Token = "0x40006B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Animation _animation;

		[Token(Token = "0x40006B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool simulateAnimSpeed;

		[Token(Token = "0x40006B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float _animSpeed;

		[Token(Token = "0x40006B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float _triggerTime;

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x3F7A910", Offset = "0x3F7A910", VA = "0x3F7A910", Slot = "4")]
		protected override void InitProp()
		{
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x3F7A9B0", Offset = "0x3F7A9B0", VA = "0x3F7A9B0", Slot = "5")]
		public override void TouchThis()
		{
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x3F7AA5C", Offset = "0x3F7AA5C", VA = "0x3F7AA5C")]
		private void Update()
		{
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x3F7AAD8", Offset = "0x3F7AAD8", VA = "0x3F7AAD8")]
		public PipLove()
		{
		}
	}
	[Token(Token = "0x2000138")]
	public class PipSquirrel : PicoInteractiveProp
	{
		[Token(Token = "0x40006B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Animator _animRainbow;

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x3F7B4E0", Offset = "0x3F7B4E0", VA = "0x3F7B4E0", Slot = "4")]
		protected override void InitProp()
		{
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x3F7B54C", Offset = "0x3F7B54C", VA = "0x3F7B54C", Slot = "5")]
		public override void TouchThis()
		{
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x3F7B5A4", Offset = "0x3F7B5A4", VA = "0x3F7B5A4")]
		public PipSquirrel()
		{
		}
	}
	[Token(Token = "0x2000139")]
	public class PipSunflower : PicoInteractiveProp
	{
		[Token(Token = "0x40006B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Animator SunflowerAni;

		[Token(Token = "0x40006B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Transform offsetSpawnPos;

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x3F7B5A8", Offset = "0x3F7B5A8", VA = "0x3F7B5A8", Slot = "4")]
		protected override void InitProp()
		{
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x3F7B6A4", Offset = "0x3F7B6A4", VA = "0x3F7B6A4", Slot = "5")]
		public override void TouchThis()
		{
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x3F7B770", Offset = "0x3F7B770", VA = "0x3F7B770")]
		private void Update()
		{
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x3F7B7BC", Offset = "0x3F7B7BC", VA = "0x3F7B7BC")]
		public PipSunflower()
		{
		}
	}
	[Token(Token = "0x200013A")]
	public class PositionChange : MonoBehaviour
	{
		[Token(Token = "0x40006B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int _curPosID;

		[Token(Token = "0x40006B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private bool _primaryButtonIsDown;

		[Token(Token = "0x40006B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		private bool _primaryButtonIsDone;

		[Token(Token = "0x40006BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
		private bool _secondButtonIsDown;

		[Token(Token = "0x40006BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F")]
		private bool _secondButtonIsDone;

		[Token(Token = "0x40006BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform _xrRig;

		[Token(Token = "0x40006BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x124F090", Offset = "0x124F090")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x124F090", Offset = "0x124F090")]
		public Transform[] trPositions;

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x2B4965C", Offset = "0x2B4965C", VA = "0x2B4965C")]
		private void Start()
		{
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x2B496C8", Offset = "0x2B496C8", VA = "0x2B496C8")]
		private void Update()
		{
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x2B496CC", Offset = "0x2B496CC", VA = "0x2B496CC")]
		private void SwitchLevelDetect()
		{
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x2B4986C", Offset = "0x2B4986C", VA = "0x2B4986C")]
		private void GoToNextPos()
		{
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x2B49834", Offset = "0x2B49834", VA = "0x2B49834")]
		private void GoToPreviousPos()
		{
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x2B498A4", Offset = "0x2B498A4", VA = "0x2B498A4")]
		private void SwitchPos(int posID)
		{
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x2B49908", Offset = "0x2B49908", VA = "0x2B49908")]
		public PositionChange()
		{
		}
	}
	[Token(Token = "0x200013B")]
	public class ScreenTexControl : MonoBehaviour
	{
		[Token(Token = "0x40006BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int ScreenId;

		[Token(Token = "0x40006BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int _ScreenTypeShaderId;

		[Token(Token = "0x40006C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static int _ScreenTexShaderId;

		[Token(Token = "0x40006C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material mat;

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x2B4B5E4", Offset = "0x2B4B5E4", VA = "0x2B4B5E4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x2B4B754", Offset = "0x2B4B754", VA = "0x2B4B754")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x2B4B884", Offset = "0x2B4B884", VA = "0x2B4B884")]
		private void OnScreenUpdate(Texture tex, ScreenTextureMsg.VRType t, int id)
		{
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x2B4B978", Offset = "0x2B4B978", VA = "0x2B4B978")]
		public ScreenTexControl()
		{
		}
	}
	[Token(Token = "0x200013C")]
	public static class ScreenTextureMsg
	{
		[Token(Token = "0x200013D")]
		public enum VRType
		{
			[Token(Token = "0x40006C4")]
			Single,
			[Token(Token = "0x40006C5")]
			LR,
			[Token(Token = "0x40006C6")]
			UD
		}

		[Token(Token = "0x40006C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Action<Texture, VRType, int> ScreenUpdate;

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x2B4BA18", Offset = "0x2B4BA18", VA = "0x2B4BA18")]
		public static void UpdateScreen(Texture tex, VRType t = VRType.Single, int id = 0)
		{
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x2B4B6B0", Offset = "0x2B4B6B0", VA = "0x2B4B6B0")]
		public static void ListenScreenUpdate(Action<Texture, VRType, int> action)
		{
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x2B4B7E0", Offset = "0x2B4B7E0", VA = "0x2B4B7E0")]
		public static void UnListenScreenUpdate(Action<Texture, VRType, int> action)
		{
		}
	}
	[Token(Token = "0x200013E")]
	public class Shine : MonoBehaviour
	{
		[Token(Token = "0x40006C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x124F0F0", Offset = "0x124F0F0")]
		private float intensity;

		[Token(Token = "0x40006C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Color c;

		[Token(Token = "0x40006C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Material _Material;

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x2B4C3CC", Offset = "0x2B4C3CC", VA = "0x2B4C3CC")]
		private void Start()
		{
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x2B4C3D0", Offset = "0x2B4C3D0", VA = "0x2B4C3D0")]
		private void Update()
		{
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x2B4C3D4", Offset = "0x2B4C3D4", VA = "0x2B4C3D4")]
		public Shine()
		{
		}
	}
	[Token(Token = "0x200013F")]
	public class ShadineMovePath : MonoBehaviour
	{
		[Token(Token = "0x40006CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform[] _fishPath;

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x2B4C3C4", Offset = "0x2B4C3C4", VA = "0x2B4C3C4")]
		public ShadineMovePath()
		{
		}
	}
	[Token(Token = "0x2000140")]
	public class ShowLogic : MonoBehaviour
	{
		[Token(Token = "0x40006CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string[] levelName;

		[Token(Token = "0x40006CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int _curLevelID;

		[Token(Token = "0x40006CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private bool _primaryButtonIsDown;

		[Token(Token = "0x40006CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		private bool _primaryButtonIsDone;

		[Token(Token = "0x40006CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
		private bool _secondButtonIsDown;

		[Token(Token = "0x40006D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x27")]
		private bool _secondButtonIsDone;

		[Token(Token = "0x40006D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform tr_XrRegion;

		[Token(Token = "0x40006D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform[] tr_CamPos;

		[Token(Token = "0x40006D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject objStage;

		[Token(Token = "0x40006D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public GameObject[] objStages;

		[Token(Token = "0x40006D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int camPosID;

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x2B4CD24", Offset = "0x2B4CD24", VA = "0x2B4CD24")]
		private void Start()
		{
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x2B4CE20", Offset = "0x2B4CE20", VA = "0x2B4CE20")]
		private void Update()
		{
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x2B4CE24", Offset = "0x2B4CE24", VA = "0x2B4CE24")]
		private void SwitchLevelDetect()
		{
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x2B4CD2C", Offset = "0x2B4CD2C", VA = "0x2B4CD2C")]
		private void SwitchZone(int add)
		{
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x2B4CFE0", Offset = "0x2B4CFE0", VA = "0x2B4CFE0")]
		private void LoadNextLevel()
		{
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x2B4D208", Offset = "0x2B4D208", VA = "0x2B4D208")]
		private void LoadPreviusLevel()
		{
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x2B4D328", Offset = "0x2B4D328", VA = "0x2B4D328")]
		private void SwitchLevel(int levelID)
		{
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x2B4D400", Offset = "0x2B4D400", VA = "0x2B4D400")]
		public ShowLogic()
		{
		}
	}
	[Token(Token = "0x2000141")]
	public class ShowLogicRoot : MonoBehaviour
	{
		[Token(Token = "0x2000142")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124DAD0", Offset = "0x124DAD0")]
		private sealed class <Start>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ShowLogicRoot <>4__this;

			[Token(Token = "0x40006E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private WaitForEndOfFrame <frame>5__2;

			[Token(Token = "0x1700008D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000700")]
				[Address(RVA = "0x310F4E8", Offset = "0x310F4E8", VA = "0x310F4E8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000702")]
				[Address(RVA = "0x310F530", Offset = "0x310F530", VA = "0x310F530", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006FD")]
			[Address(RVA = "0x310F210", Offset = "0x310F210", VA = "0x310F210")]
			[DebuggerHidden]
			public <Start>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x60006FE")]
			[Address(RVA = "0x310F23C", Offset = "0x310F23C", VA = "0x310F23C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006FF")]
			[Address(RVA = "0x310F240", Offset = "0x310F240", VA = "0x310F240", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000701")]
			[Address(RVA = "0x310F4F0", Offset = "0x310F4F0", VA = "0x310F4F0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000143")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124DAE0", Offset = "0x124DAE0")]
		private sealed class <AsyncLoadScene>d__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ShowLogicRoot <>4__this;

			[Token(Token = "0x40006EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string sceneName;

			[Token(Token = "0x40006EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int index;

			[Token(Token = "0x40006EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <time>5__2;

			[Token(Token = "0x40006ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniversalAdditionalCameraData <camData>5__3;

			[Token(Token = "0x40006EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private LoadingInfo <loadingInfo>5__4;

			[Token(Token = "0x1700008F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000706")]
				[Address(RVA = "0x310EF5C", Offset = "0x310EF5C", VA = "0x310EF5C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000090")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000708")]
				[Address(RVA = "0x310EFA4", Offset = "0x310EFA4", VA = "0x310EFA4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000703")]
			[Address(RVA = "0x310E6D8", Offset = "0x310E6D8", VA = "0x310E6D8")]
			[DebuggerHidden]
			public <AsyncLoadScene>d__16(int <>1__state)
			{
			}

			[Token(Token = "0x6000704")]
			[Address(RVA = "0x310E704", Offset = "0x310E704", VA = "0x310E704", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000705")]
			[Address(RVA = "0x310E708", Offset = "0x310E708", VA = "0x310E708", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000707")]
			[Address(RVA = "0x310EF64", Offset = "0x310EF64", VA = "0x310EF64", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000144")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124DAF0", Offset = "0x124DAF0")]
		private sealed class <AsyncUnLoadScene>d__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string sceneName;

			[Token(Token = "0x40006F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private LoadingInfo <unloadingInfo>5__2;

			[Token(Token = "0x17000091")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600070C")]
				[Address(RVA = "0x310F1C0", Offset = "0x310F1C0", VA = "0x310F1C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000092")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600070E")]
				[Address(RVA = "0x310F208", Offset = "0x310F208", VA = "0x310F208", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000709")]
			[Address(RVA = "0x310EFAC", Offset = "0x310EFAC", VA = "0x310EFAC")]
			[DebuggerHidden]
			public <AsyncUnLoadScene>d__17(int <>1__state)
			{
			}

			[Token(Token = "0x600070A")]
			[Address(RVA = "0x310EFD8", Offset = "0x310EFD8", VA = "0x310EFD8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600070B")]
			[Address(RVA = "0x310EFDC", Offset = "0x310EFDC", VA = "0x310EFDC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600070D")]
			[Address(RVA = "0x310F1C8", Offset = "0x310F1C8", VA = "0x310F1C8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40006D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string[] levelName;

		[Token(Token = "0x40006D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int defaultScene;

		[Token(Token = "0x40006D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int _curLevelIndex;

		[Token(Token = "0x40006D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string _curLevelName;

		[Token(Token = "0x40006DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool _isChanging;

		[Token(Token = "0x40006DB")]
		private const string SCENE_PARENT = "PicoLiveAKB48";

		[Token(Token = "0x40006DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly string SCENE_BASE_PATH;

		[Token(Token = "0x40006DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Volume blendVolume;

		[Token(Token = "0x40006DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float blendTime;

		[Token(Token = "0x40006DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int _testIndex;

		[Token(Token = "0x40006E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool _isForTest;

		[Token(Token = "0x40006E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		private bool _primaryButtonIsDown;

		[Token(Token = "0x40006E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
		private bool _secondaryButtonDown;

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x2B4D530", Offset = "0x2B4D530", VA = "0x2B4D530")]
		public int GetLevelIndex()
		{
			return default(int);
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x2B4D538", Offset = "0x2B4D538", VA = "0x2B4D538")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1252398", Offset = "0x1252398")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x2B4D5B0", Offset = "0x2B4D5B0", VA = "0x2B4D5B0")]
		private void InitMainScene()
		{
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x2B4D100", Offset = "0x2B4D100", VA = "0x2B4D100")]
		public void OnSwitchLevelByIndex(int index)
		{
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x2B4D9A0", Offset = "0x2B4D9A0", VA = "0x2B4D9A0")]
		private int GetLevelNameIndex(string name)
		{
			return default(int);
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x2B4DA28", Offset = "0x2B4DA28", VA = "0x2B4DA28")]
		public void OnSwitchLevel(string name)
		{
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x2B4D85C", Offset = "0x2B4D85C", VA = "0x2B4D85C")]
		private void LoadSceneByIndex(int index)
		{
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x2B4DB54", Offset = "0x2B4DB54", VA = "0x2B4DB54")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x12523F8", Offset = "0x12523F8")]
		private IEnumerator AsyncLoadScene(int index, string sceneName)
		{
			return null;
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x2B4DC24", Offset = "0x2B4DC24", VA = "0x2B4DC24")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1252458", Offset = "0x1252458")]
		private IEnumerator AsyncUnLoadScene(string sceneName)
		{
			return null;
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x2B4D71C", Offset = "0x2B4D71C", VA = "0x2B4D71C")]
		private bool IsLegalIndex(int id)
		{
			return default(bool);
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x2B4DBF0", Offset = "0x2B4DBF0", VA = "0x2B4DBF0")]
		private bool IsNotRepeat(int id)
		{
			return default(bool);
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x2B4DC9C", Offset = "0x2B4DC9C", VA = "0x2B4DC9C")]
		private void Update()
		{
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x2B4DCAC", Offset = "0x2B4DCAC", VA = "0x2B4DCAC")]
		private void SwarpSceneDetect()
		{
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x2B4DE4C", Offset = "0x2B4DE4C", VA = "0x2B4DE4C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x2B4E174", Offset = "0x2B4E174", VA = "0x2B4E174")]
		public ShowLogicRoot()
		{
		}
	}
	[Token(Token = "0x2000145")]
	public class StageDetect : MonoBehaviour
	{
		[Token(Token = "0x600070F")]
		[Address(RVA = "0x2B4F6E0", Offset = "0x2B4F6E0", VA = "0x2B4F6E0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0x2B4F6E4", Offset = "0x2B4F6E4", VA = "0x2B4F6E4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0x2B4F6E8", Offset = "0x2B4F6E8", VA = "0x2B4F6E8")]
		public StageDetect()
		{
		}
	}
	[Token(Token = "0x2000146")]
	public class AnimRandomSpeed : MonoBehaviour
	{
		[Token(Token = "0x40006F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Animator _animator;

		[Token(Token = "0x40006F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector2 randomSpeed;

		[Token(Token = "0x6000712")]
		[Address(RVA = "0x1A4A7B0", Offset = "0x1A4A7B0", VA = "0x1A4A7B0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0x1A4A8D4", Offset = "0x1A4A8D4", VA = "0x1A4A8D4")]
		public AnimRandomSpeed()
		{
		}
	}
	[Token(Token = "0x2000147")]
	public class Rotate : MonoBehaviour
	{
		[Token(Token = "0x40006F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float speed;

		[Token(Token = "0x6000714")]
		[Address(RVA = "0x2B4A924", Offset = "0x2B4A924", VA = "0x2B4A924")]
		private void Start()
		{
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0x2B4A928", Offset = "0x2B4A928", VA = "0x2B4A928")]
		private void Update()
		{
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0x2B4A92C", Offset = "0x2B4A92C", VA = "0x2B4A92C")]
		private void ObjRotate()
		{
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0x2B4A980", Offset = "0x2B4A980", VA = "0x2B4A980")]
		public Rotate()
		{
		}
	}
	[Token(Token = "0x2000148")]
	public class Speed : MonoBehaviour
	{
		[Token(Token = "0x40006F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float _animSpeed;

		[Token(Token = "0x40006F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animation _animation;

		[Token(Token = "0x6000718")]
		[Address(RVA = "0x2B4F40C", Offset = "0x2B4F40C", VA = "0x2B4F40C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0x2B4F4B8", Offset = "0x2B4F4B8", VA = "0x2B4F4B8")]
		private void Update()
		{
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0x2B4F4BC", Offset = "0x2B4F4BC", VA = "0x2B4F4BC")]
		public Speed()
		{
		}
	}
	[Token(Token = "0x2000149")]
	public class WaveFloating : MonoBehaviour
	{
		[Token(Token = "0x40006F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 offsetXYZ;

		[Token(Token = "0x40006F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 originalPos;

		[Token(Token = "0x40006FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float Wavespeed;

		[Token(Token = "0x40006FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float RiseSpeed;

		[Token(Token = "0x40006FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool Rising;

		[Token(Token = "0x40006FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 tempAdd;

		[Token(Token = "0x600071B")]
		[Address(RVA = "0x2B593F0", Offset = "0x2B593F0", VA = "0x2B593F0")]
		private void Start()
		{
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0x2B593F4", Offset = "0x2B593F4", VA = "0x2B593F4")]
		public void ObjRasing()
		{
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0x2B59524", Offset = "0x2B59524", VA = "0x2B59524")]
		public void Wave()
		{
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0x2B59530", Offset = "0x2B59530", VA = "0x2B59530")]
		private void Update()
		{
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0x2B5965C", Offset = "0x2B5965C", VA = "0x2B5965C")]
		public WaveFloating()
		{
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0x2B59680", Offset = "0x2B59680", VA = "0x2B59680")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x12525A8", Offset = "0x12525A8")]
		private void <ObjRasing>b__7_0()
		{
		}
	}
	[Token(Token = "0x200014A")]
	public class CustomSpeed : MonoBehaviour
	{
		[Token(Token = "0x40006FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float animSpeed;

		[Token(Token = "0x40006FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animation _animation;

		[Token(Token = "0x6000721")]
		[Address(RVA = "0x2C7DEC4", Offset = "0x2C7DEC4", VA = "0x2C7DEC4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000722")]
		[Address(RVA = "0x2C7DF64", Offset = "0x2C7DF64", VA = "0x2C7DF64")]
		private void Update()
		{
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0x2C7DF68", Offset = "0x2C7DF68", VA = "0x2C7DF68")]
		public CustomSpeed()
		{
		}
	}
	[Token(Token = "0x200014B")]
	public class WingSpeed : MonoBehaviour
	{
		[Token(Token = "0x4000700")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float animSpeed;

		[Token(Token = "0x4000701")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animation _animation;

		[Token(Token = "0x6000724")]
		[Address(RVA = "0x2B59750", Offset = "0x2B59750", VA = "0x2B59750")]
		private void Start()
		{
		}

		[Token(Token = "0x6000725")]
		[Address(RVA = "0x2B597E8", Offset = "0x2B597E8", VA = "0x2B597E8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000726")]
		[Address(RVA = "0x2B597EC", Offset = "0x2B597EC", VA = "0x2B597EC")]
		public WingSpeed()
		{
		}
	}
	[Token(Token = "0x200014C")]
	public class PdlSingleRecive : MonoBehaviour
	{
		[Token(Token = "0x6000727")]
		[Address(RVA = "0x3F77F5C", Offset = "0x3F77F5C", VA = "0x3F77F5C")]
		public void StartDirector()
		{
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0x3F77FBC", Offset = "0x3F77FBC", VA = "0x3F77FBC")]
		public void StopDirector()
		{
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0x3F7801C", Offset = "0x3F7801C", VA = "0x3F7801C")]
		public void ShowTouchTip(string TipName)
		{
		}

		[Token(Token = "0x600072A")]
		[Address(RVA = "0x3F780A4", Offset = "0x3F780A4", VA = "0x3F780A4")]
		public void HiddenTouchTip()
		{
		}

		[Token(Token = "0x600072B")]
		[Address(RVA = "0x3F78124", Offset = "0x3F78124", VA = "0x3F78124")]
		public PdlSingleRecive()
		{
		}
	}
	[Token(Token = "0x200014D")]
	public class PlayableDirectorLogic : MonoBehaviour
	{
		[Token(Token = "0x4000702")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private PlayableDirector _playableDirector;

		[Token(Token = "0x4000703")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float _speedUpTime;

		[Token(Token = "0x4000704")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x124F118", Offset = "0x124F118")]
		public bool autoPlay;

		[Token(Token = "0x4000705")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x124F150", Offset = "0x124F150")]
		public float spawnDelayTime;

		[Token(Token = "0x4000706")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float spawnInvertTime;

		[Token(Token = "0x4000707")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x124F188", Offset = "0x124F188")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x124F188", Offset = "0x124F188")]
		public bool bEnableOffset;

		[Token(Token = "0x4000708")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float initStartTime;

		[Token(Token = "0x4000709")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject[] interactiveProps;

		[Token(Token = "0x400070A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float lastSEITime;

		[Token(Token = "0x400070B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float resumeTime;

		[Token(Token = "0x17000093")]
		public float CurrTime
		{
			[Token(Token = "0x600072C")]
			[Address(RVA = "0x2B48CE8", Offset = "0x2B48CE8", VA = "0x2B48CE8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600072D")]
		[Address(RVA = "0x2B48CF0", Offset = "0x2B48CF0", VA = "0x2B48CF0")]
		private void Start()
		{
		}

		[Token(Token = "0x600072E")]
		[Address(RVA = "0x2B48EC0", Offset = "0x2B48EC0", VA = "0x2B48EC0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0x2B48F50", Offset = "0x2B48F50", VA = "0x2B48F50")]
		private void TestPlayPD()
		{
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0x2B48FBC", Offset = "0x2B48FBC", VA = "0x2B48FBC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0x2B48FC8", Offset = "0x2B48FC8", VA = "0x2B48FC8", Slot = "4")]
		protected virtual void InitTL()
		{
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0x2B49048", Offset = "0x2B49048", VA = "0x2B49048", Slot = "5")]
		protected virtual void UpdateTL()
		{
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0x2B48F80", Offset = "0x2B48F80", VA = "0x2B48F80")]
		public void OffsetPlayableDirector(float offset)
		{
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0x2B48DEC", Offset = "0x2B48DEC", VA = "0x2B48DEC")]
		public void PlayPlayableDirector()
		{
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0x2B490F0", Offset = "0x2B490F0", VA = "0x2B490F0")]
		public void ResumePlay()
		{
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0x2B49194", Offset = "0x2B49194", VA = "0x2B49194")]
		public void UpdateOffset(float time)
		{
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0x2B4919C", Offset = "0x2B4919C", VA = "0x2B4919C", Slot = "6")]
		public virtual void StartDirector()
		{
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0x2B49274", Offset = "0x2B49274", VA = "0x2B49274", Slot = "7")]
		public virtual void SpawnInteractiveProp()
		{
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0x2B49278", Offset = "0x2B49278", VA = "0x2B49278", Slot = "8")]
		public virtual void FinishDirector()
		{
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0x2B4938C", Offset = "0x2B4938C", VA = "0x2B4938C")]
		public PlayableDirectorLogic()
		{
		}
	}
	[Token(Token = "0x200014E")]
	public class PdlSlDaShengZuanShi : PlayableDirectorLogic
	{
		[Token(Token = "0x600073B")]
		[Address(RVA = "0x3F7812C", Offset = "0x3F7812C", VA = "0x3F7812C")]
		public PdlSlDaShengZuanShi()
		{
		}
	}
	[Token(Token = "0x200014F")]
	public class PdlSlEverydayFaGu : PlayableDirectorLogic
	{
		[Token(Token = "0x600073C")]
		[Address(RVA = "0x3F78134", Offset = "0x3F78134", VA = "0x3F78134")]
		public PdlSlEverydayFaGu()
		{
		}
	}
	[Token(Token = "0x2000150")]
	public class PdlSlMaWeiYuFaQuan : PlayableDirectorLogic
	{
		[Token(Token = "0x400070C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public ParticleSystem psGlowWorm;

		[Token(Token = "0x600073D")]
		[Address(RVA = "0x3F7813C", Offset = "0x3F7813C", VA = "0x3F7813C", Slot = "6")]
		public override void StartDirector()
		{
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0x3F78140", Offset = "0x3F78140", VA = "0x3F78140")]
		private void ActiveGlowWorm()
		{
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0x3F78144", Offset = "0x3F78144", VA = "0x3F78144")]
		public PdlSlMaWeiYuFaQuan()
		{
		}
	}
	[Token(Token = "0x2000151")]
	public class PdlSlRiver : PlayableDirectorLogic
	{
		[Token(Token = "0x6000740")]
		[Address(RVA = "0x3F7814C", Offset = "0x3F7814C", VA = "0x3F7814C")]
		public PdlSlRiver()
		{
		}
	}
	[Token(Token = "0x2000152")]
	public class PdlSlXiWangDeFuGe : PlayableDirectorLogic
	{
		[Token(Token = "0x6000741")]
		[Address(RVA = "0x3F78154", Offset = "0x3F78154", VA = "0x3F78154")]
		public PdlSlXiWangDeFuGe()
		{
		}
	}
	[Token(Token = "0x2000153")]
	public class PdlSlYinWeiXiHuanNi : PlayableDirectorLogic
	{
		[Token(Token = "0x6000742")]
		[Address(RVA = "0x3F7815C", Offset = "0x3F7815C", VA = "0x3F7815C")]
		public PdlSlYinWeiXiHuanNi()
		{
		}
	}
	[Token(Token = "0x2000154")]
	public class PdlTgwFeiXiangRuShou : PlayableDirectorLogic
	{
		[Token(Token = "0x400070D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public GameObject[] MianHuaTang;

		[Token(Token = "0x6000743")]
		[Address(RVA = "0x3F78164", Offset = "0x3F78164", VA = "0x3F78164", Slot = "6")]
		public override void StartDirector()
		{
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0x3F7825C", Offset = "0x3F7825C", VA = "0x3F7825C")]
		public PdlTgwFeiXiangRuShou()
		{
		}
	}
	[Token(Token = "0x2000155")]
	public class PdlTgwHaoXiangJianNi : PlayableDirectorLogic
	{
		[Token(Token = "0x400070E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public GameObject[] LovePath;

		[Token(Token = "0x6000745")]
		[Address(RVA = "0x3F78264", Offset = "0x3F78264", VA = "0x3F78264", Slot = "6")]
		public override void StartDirector()
		{
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0x3F78268", Offset = "0x3F78268", VA = "0x3F78268")]
		private void ActiveLovePath()
		{
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0x3F78314", Offset = "0x3F78314", VA = "0x3F78314")]
		public PdlTgwHaoXiangJianNi()
		{
		}
	}
	[Token(Token = "0x2000156")]
	public class PdlTgwLianAiXinYunQuQi : PlayableDirectorLogic
	{
		[Token(Token = "0x6000748")]
		[Address(RVA = "0x3F7831C", Offset = "0x3F7831C", VA = "0x3F7831C")]
		public PdlTgwLianAiXinYunQuQi()
		{
		}
	}
	[Token(Token = "0x2000157")]
	public class PdlTgwOverture : PlayableDirectorLogic
	{
		[Token(Token = "0x400070F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public GameObject[] balloon;

		[Token(Token = "0x6000749")]
		[Address(RVA = "0x3F78324", Offset = "0x3F78324", VA = "0x3F78324", Slot = "6")]
		public override void StartDirector()
		{
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0x3F78328", Offset = "0x3F78328", VA = "0x3F78328")]
		private void ActiveBalloon()
		{
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0x3F783D0", Offset = "0x3F783D0", VA = "0x3F783D0")]
		public PdlTgwOverture()
		{
		}
	}
	[Token(Token = "0x2000158")]
	public class PdlTgwWuXianXunHuan : PlayableDirectorLogic
	{
		[Token(Token = "0x4000710")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Animator acBingJiLing;

		[Token(Token = "0x600074C")]
		[Address(RVA = "0x3F783D8", Offset = "0x3F783D8", VA = "0x3F783D8", Slot = "6")]
		public override void StartDirector()
		{
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0x3F783DC", Offset = "0x3F783DC", VA = "0x3F783DC")]
		public PdlTgwWuXianXunHuan()
		{
		}
	}
	[Token(Token = "0x2000159")]
	public class PdlTkzcJiuWeiDeChunMi : PlayableDirectorLogic
	{
		[Token(Token = "0x4000711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public GameObject[] Cloud;

		[Token(Token = "0x4000712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public GameObject[] TouchCloud;

		[Token(Token = "0x600074E")]
		[Address(RVA = "0x3F783E4", Offset = "0x3F783E4", VA = "0x3F783E4", Slot = "6")]
		public override void StartDirector()
		{
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0x3F783E8", Offset = "0x3F783E8", VA = "0x3F783E8")]
		private void ActiveCloud()
		{
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0x3F784E0", Offset = "0x3F784E0", VA = "0x3F784E0")]
		public PdlTkzcJiuWeiDeChunMi()
		{
		}
	}
	[Token(Token = "0x200015A")]
	public class PdlYlyBagusttde : PlayableDirectorLogic
	{
		[Token(Token = "0x4000713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private FerrisWheel _FerrisWheel;

		[Token(Token = "0x6000751")]
		[Address(RVA = "0x3F784E8", Offset = "0x3F784E8", VA = "0x3F784E8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0x3F7856C", Offset = "0x3F7856C", VA = "0x3F7856C", Slot = "6")]
		public override void StartDirector()
		{
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0x3F78574", Offset = "0x3F78574", VA = "0x3F78574", Slot = "8")]
		public override void FinishDirector()
		{
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0x3F7857C", Offset = "0x3F7857C", VA = "0x3F7857C")]
		public void FerrisWheelLights()
		{
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0x3F78598", Offset = "0x3F78598", VA = "0x3F78598")]
		public void StopTwinkle()
		{
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0x3F785B4", Offset = "0x3F785B4", VA = "0x3F785B4")]
		public PdlYlyBagusttde()
		{
		}
	}
	[Token(Token = "0x200015B")]
	public class PdlYlyRuGuoNiYongBaoWo : PlayableDirectorLogic
	{
		[Token(Token = "0x6000757")]
		[Address(RVA = "0x3F785BC", Offset = "0x3F785BC", VA = "0x3F785BC")]
		public PdlYlyRuGuoNiYongBaoWo()
		{
		}
	}
	[Token(Token = "0x200015C")]
	public class PdlYlyXiangRiKui : PlayableDirectorLogic
	{
		[Token(Token = "0x6000758")]
		[Address(RVA = "0x3F785C4", Offset = "0x3F785C4", VA = "0x3F785C4")]
		public PdlYlyXiangRiKui()
		{
		}
	}
	[Token(Token = "0x200015D")]
	public class PdlYlyXinAiDeNaTaSha : PlayableDirectorLogic
	{
		[Token(Token = "0x6000759")]
		[Address(RVA = "0x3F785CC", Offset = "0x3F785CC", VA = "0x3F785CC")]
		public PdlYlyXinAiDeNaTaSha()
		{
		}
	}
	[Token(Token = "0x200015E")]
	public class PdlYlyYuNiDeCW : PlayableDirectorLogic
	{
		[Token(Token = "0x600075A")]
		[Address(RVA = "0x3F785D4", Offset = "0x3F785D4", VA = "0x3F785D4")]
		public PdlYlyYuNiDeCW()
		{
		}
	}
	[Token(Token = "0x200015F")]
	public class TimelineLogic : MonoBehaviour
	{
		[Token(Token = "0x4000714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<ShowConfig> pdl_Shows;

		[Token(Token = "0x4000715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ShowConfig curShow;

		[Token(Token = "0x4000716")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int curShowNameID;

		[Token(Token = "0x4000717")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool _rightTriggerButtonIsDone;

		[Token(Token = "0x4000718")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		private bool _leftTriggerButtonIsDone;

		[Token(Token = "0x4000719")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string lastShowName;

		[Token(Token = "0x600075B")]
		[Address(RVA = "0x2B54500", Offset = "0x2B54500", VA = "0x2B54500")]
		private void Awake()
		{
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0x2B545FC", Offset = "0x2B545FC", VA = "0x2B545FC")]
		private void Update()
		{
		}

		[Token(Token = "0x600075D")]
		[Address(RVA = "0x2B54600", Offset = "0x2B54600", VA = "0x2B54600")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600075E")]
		[Address(RVA = "0x2B546FC", Offset = "0x2B546FC", VA = "0x2B546FC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0x2B54784", Offset = "0x2B54784", VA = "0x2B54784")]
		private void SwitchLevelShow(string name)
		{
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0x2B5478C", Offset = "0x2B5478C", VA = "0x2B5478C")]
		public void SwitchLevelShow(string showName, float offsetTime)
		{
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0x2B54CD0", Offset = "0x2B54CD0", VA = "0x2B54CD0")]
		public void StopLevelShow()
		{
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0x2B54D3C", Offset = "0x2B54D3C", VA = "0x2B54D3C")]
		public TimelineLogic()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000160")]
	public struct ShowConfig
	{
		[Token(Token = "0x400071A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string sceneName;

		[Token(Token = "0x400071B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string showName;

		[Token(Token = "0x400071C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject objShowPdl;

		[Token(Token = "0x400071D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float offset;

		[Token(Token = "0x400071E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float end;

		[Token(Token = "0x400071F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public PlayableDirectorLogic playable;
	}
	[Serializable]
	[Token(Token = "0x2000161")]
	public struct PropTipConfig
	{
		[Token(Token = "0x4000720")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string propName;

		[Token(Token = "0x4000721")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Sprite propSprite;
	}
	[Token(Token = "0x2000162")]
	public class Sunflower : MonoBehaviour
	{
		[Token(Token = "0x4000722")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Animator _SunflowerAni;

		[Token(Token = "0x6000763")]
		[Address(RVA = "0x2B4FAE0", Offset = "0x2B4FAE0", VA = "0x2B4FAE0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0x2B4FC08", Offset = "0x2B4FC08", VA = "0x2B4FC08")]
		public Sunflower()
		{
		}
	}
	[Token(Token = "0x2000163")]
	public class UIPipTip : MonoBehaviour
	{
		[Token(Token = "0x4000723")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x124F1F8", Offset = "0x124F1F8")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x124F1F8", Offset = "0x124F1F8")]
		[SerializeField]
		private float offsetForwardDistance;

		[Token(Token = "0x4000724")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x124F268", Offset = "0x124F268")]
		public Image imgPropTip;

		[Token(Token = "0x4000725")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x124F2A0", Offset = "0x124F2A0")]
		private Transform uiTipPanel;

		[Token(Token = "0x4000726")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform objCharacterEye;

		[Token(Token = "0x4000727")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x124F2EC", Offset = "0x124F2EC")]
		public List<PropTipConfig> propTip;

		[Token(Token = "0x4000728")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float autoHide;

		[Token(Token = "0x4000729")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool showStatus;

		[Token(Token = "0x400072A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 _startPos;

		[Token(Token = "0x400072B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 _endPos;

		[Token(Token = "0x6000765")]
		[Address(RVA = "0x2B56640", Offset = "0x2B56640", VA = "0x2B56640")]
		private void Start()
		{
		}

		[Token(Token = "0x6000766")]
		[Address(RVA = "0x2B566AC", Offset = "0x2B566AC", VA = "0x2B566AC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0x2B566DC", Offset = "0x2B566DC", VA = "0x2B566DC")]
		public void ShowInteractivePropTipBoard(string propName)
		{
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0x2B56914", Offset = "0x2B56914", VA = "0x2B56914")]
		private void UpdatePropTipBoard(string propName)
		{
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0x2B56A0C", Offset = "0x2B56A0C", VA = "0x2B56A0C")]
		public void AfterMove()
		{
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0x2B56AAC", Offset = "0x2B56AAC", VA = "0x2B56AAC")]
		private void Update()
		{
		}

		[Token(Token = "0x600076B")]
		[Address(RVA = "0x2B56830", Offset = "0x2B56830", VA = "0x2B56830")]
		private void ResetMovePos()
		{
		}

		[Token(Token = "0x600076C")]
		[Address(RVA = "0x2B56B1C", Offset = "0x2B56B1C", VA = "0x2B56B1C")]
		private void LocalTest()
		{
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0x2B56B74", Offset = "0x2B56B74", VA = "0x2B56B74")]
		private void LocalPropTipUpdate()
		{
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0x2B56C08", Offset = "0x2B56C08", VA = "0x2B56C08")]
		public UIPipTip()
		{
		}
	}
	[Token(Token = "0x2000164")]
	public class AppearAni : MonoBehaviour
	{
		[Token(Token = "0x400072C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3[] Position;

		[Token(Token = "0x400072D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int Mark;

		[Token(Token = "0x600076F")]
		[Address(RVA = "0x2C783E4", Offset = "0x2C783E4", VA = "0x2C783E4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0x2C78564", Offset = "0x2C78564", VA = "0x2C78564")]
		private void Update()
		{
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0x2C7842C", Offset = "0x2C7842C", VA = "0x2C7842C")]
		private void playAni()
		{
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0x2C78568", Offset = "0x2C78568", VA = "0x2C78568")]
		public AppearAni()
		{
		}
	}
	[Token(Token = "0x2000165")]
	public class CubeFlashing : MonoBehaviour
	{
		[Token(Token = "0x400072E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Material haloMaterial;

		[Token(Token = "0x400072F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color _emissionColorValue;

		[Token(Token = "0x4000730")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float desiredValue;

		[Token(Token = "0x4000731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float _intensity;

		[Token(Token = "0x4000732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float decrease;

		[Token(Token = "0x4000733")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int dir;

		[Token(Token = "0x6000773")]
		[Address(RVA = "0x2C7D55C", Offset = "0x2C7D55C", VA = "0x2C7D55C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0x2C7D5D4", Offset = "0x2C7D5D4", VA = "0x2C7D5D4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0x2C7D6A0", Offset = "0x2C7D6A0", VA = "0x2C7D6A0")]
		public CubeFlashing()
		{
		}
	}
	[Token(Token = "0x2000166")]
	public class FerrisWheel : MonoBehaviour
	{
		[Token(Token = "0x4000734")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float _rotateSpeed;

		[Token(Token = "0x4000735")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform[] tr_ChildGang;

		[Token(Token = "0x4000736")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform[] tr_ChildZuo;

		[Token(Token = "0x4000737")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform _transformChild;

		[Token(Token = "0x4000738")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform _transform;

		[Token(Token = "0x6000776")]
		[Address(RVA = "0x2C81D80", Offset = "0x2C81D80", VA = "0x2C81D80")]
		private void Start()
		{
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0x2C81DD8", Offset = "0x2C81DD8", VA = "0x2C81DD8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0x2C81EC0", Offset = "0x2C81EC0", VA = "0x2C81EC0")]
		public void LightsUp()
		{
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0x2C81FA8", Offset = "0x2C81FA8", VA = "0x2C81FA8")]
		public void LightsOut()
		{
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0x2C82094", Offset = "0x2C82094", VA = "0x2C82094")]
		public FerrisWheel()
		{
		}
	}
	[Token(Token = "0x2000167")]
	public class MacheSpeed : MonoBehaviour
	{
		[Token(Token = "0x4000739")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float _animSpeed;

		[Token(Token = "0x400073A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animation _animation;

		[Token(Token = "0x600077B")]
		[Address(RVA = "0x3F64084", Offset = "0x3F64084", VA = "0x3F64084")]
		private void Start()
		{
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0x3F6411C", Offset = "0x3F6411C", VA = "0x3F6411C")]
		private void Update()
		{
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0x3F64120", Offset = "0x3F64120", VA = "0x3F64120")]
		public MacheSpeed()
		{
		}
	}
	[Token(Token = "0x2000168")]
	public class SpriteFlashing : MonoBehaviour
	{
		[Token(Token = "0x400073B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform FlashingObj;

		[Token(Token = "0x400073C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Color HintColor;

		[Token(Token = "0x600077E")]
		[Address(RVA = "0x2B4F628", Offset = "0x2B4F628", VA = "0x2B4F628")]
		private void Start()
		{
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0x2B4F654", Offset = "0x2B4F654", VA = "0x2B4F654")]
		private void Update()
		{
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0x2B4F6D8", Offset = "0x2B4F6D8", VA = "0x2B4F6D8")]
		public SpriteFlashing()
		{
		}
	}
	[Token(Token = "0x2000169")]
	public class WindMill : MonoBehaviour
	{
		[Token(Token = "0x400073D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float speed;

		[Token(Token = "0x400073E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform _transform;

		[Token(Token = "0x400073F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 _rotateTest;

		[Token(Token = "0x6000781")]
		[Address(RVA = "0x2B596C4", Offset = "0x2B596C4", VA = "0x2B596C4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0x2B596F4", Offset = "0x2B596F4", VA = "0x2B596F4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0x2B59748", Offset = "0x2B59748", VA = "0x2B59748")]
		public WindMill()
		{
		}
	}
}
namespace AKB48
{
	[Token(Token = "0x200016A")]
	public class AKB48Root : MonoBehaviour
	{
		[Token(Token = "0x200016B")]
		private class AKB48TimelineDebugPanel : IDebugPanelInterface
		{
			[Token(Token = "0x200016C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124DB00", Offset = "0x124DB00")]
			private sealed class <>c__DisplayClass6_0
			{
				[Token(Token = "0x400074B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public string showname;

				[Token(Token = "0x400074C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public AKB48TimelineDebugPanel <>4__this;

				[Token(Token = "0x6000790")]
				[Address(RVA = "0x3108584", Offset = "0x3108584", VA = "0x3108584")]
				public <>c__DisplayClass6_0()
				{
				}

				[Token(Token = "0x6000791")]
				[Address(RVA = "0x3111B00", Offset = "0x3111B00", VA = "0x3111B00")]
				internal void <OnDpInit>b__0()
				{
				}
			}

			[Token(Token = "0x400074A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public PicoLiveAKB48.TimelineLogic logic;

			[Token(Token = "0x17000094")]
			public string DpName
			{
				[Token(Token = "0x600078A")]
				[Address(RVA = "0x3108268", Offset = "0x3108268", VA = "0x3108268", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000095")]
			public bool DpEnable
			{
				[Token(Token = "0x600078B")]
				[Address(RVA = "0x31082AC", Offset = "0x31082AC", VA = "0x31082AC", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000096")]
			public string DpTitle
			{
				[Token(Token = "0x600078C")]
				[Address(RVA = "0x31082B4", Offset = "0x31082B4", VA = "0x31082B4", Slot = "6")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600078D")]
			[Address(RVA = "0x31082F8", Offset = "0x31082F8", VA = "0x31082F8", Slot = "7")]
			public void OnDpInit(DebugPanelDrawContext ctx)
			{
			}

			[Token(Token = "0x600078E")]
			[Address(RVA = "0x310858C", Offset = "0x310858C", VA = "0x310858C", Slot = "8")]
			public void OnDpRelease()
			{
			}

			[Token(Token = "0x600078F")]
			[Address(RVA = "0x3108590", Offset = "0x3108590", VA = "0x3108590")]
			public AKB48TimelineDebugPanel()
			{
			}
		}

		[Token(Token = "0x4000740")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private AKB48TimelineDebugPanel timelineDebugPanel;

		[Token(Token = "0x4000741")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool FFREnable;

		[Token(Token = "0x4000742")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x124F324", Offset = "0x124F324")]
		public float eyeBuff;

		[Token(Token = "0x4000743")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TextureFoveatedFeatureQuality FFRQuality;

		[Token(Token = "0x4000744")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public PicoLiveAKB48.TimelineLogic timelineLogic;

		[Token(Token = "0x4000745")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool livePlayerReady;

		[Token(Token = "0x4000746")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		private bool lastFFREnable;

		[Token(Token = "0x4000747")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float lastEyeBuff;

		[Token(Token = "0x4000748")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float lastCameraEyeBuff;

		[Token(Token = "0x4000749")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private TextureFoveatedFeatureQuality lastFFRQuality;

		[Token(Token = "0x6000784")]
		[Address(RVA = "0x1A49514", Offset = "0x1A49514", VA = "0x1A49514")]
		private void Start()
		{
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0x1A49888", Offset = "0x1A49888", VA = "0x1A49888")]
		private void Update()
		{
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0x1A49D98", Offset = "0x1A49D98", VA = "0x1A49D98")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000787")]
		[Address(RVA = "0x1A49EE8", Offset = "0x1A49EE8", VA = "0x1A49EE8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0x1A49984", Offset = "0x1A49984", VA = "0x1A49984")]
		private void InstallHandCollider()
		{
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0x1A49F60", Offset = "0x1A49F60", VA = "0x1A49F60")]
		public AKB48Root()
		{
		}
	}
}
namespace MirzaBeig.Shaders.ImageEffects
{
	[Serializable]
	[Token(Token = "0x200016D")]
	[ExecuteInEditMode]
	public class IEBase : MonoBehaviour
	{
		[Token(Token = "0x400074D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Material _material;

		[Token(Token = "0x400074E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124F340", Offset = "0x124F340")]
		private Shader <shader>k__BackingField;

		[Token(Token = "0x400074F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Camera _camera;

		[Token(Token = "0x17000097")]
		protected Material material
		{
			[Token(Token = "0x6000792")]
			[Address(RVA = "0x3F6053C", Offset = "0x3F6053C", VA = "0x3F6053C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000098")]
		protected Shader shader
		{
			[Token(Token = "0x6000793")]
			[Address(RVA = "0x3F60614", Offset = "0x3F60614", VA = "0x3F60614")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x12525B8", Offset = "0x12525B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000794")]
			[Address(RVA = "0x3F6061C", Offset = "0x3F6061C", VA = "0x3F6061C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x12525C8", Offset = "0x12525C8")]
			set
			{
			}
		}

		[Token(Token = "0x17000099")]
		protected Camera camera
		{
			[Token(Token = "0x6000795")]
			[Address(RVA = "0x3F60624", Offset = "0x3F60624", VA = "0x3F60624")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0x3F606D4", Offset = "0x3F606D4", VA = "0x3F606D4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0x3F606D8", Offset = "0x3F606D8", VA = "0x3F606D8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0x3F606DC", Offset = "0x3F606DC", VA = "0x3F606DC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0x3F606E0", Offset = "0x3F606E0", VA = "0x3F606E0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0x3F606E4", Offset = "0x3F606E4", VA = "0x3F606E4")]
		protected void blit(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0x3F60770", Offset = "0x3F60770", VA = "0x3F60770")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0x3F6081C", Offset = "0x3F6081C", VA = "0x3F6081C")]
		public IEBase()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200016E")]
	[ExecuteInEditMode]
	public class MirzaPostProcessing : MonoBehaviour
	{
		[Token(Token = "0x4000750")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Material material;

		[Token(Token = "0x600079D")]
		[Address(RVA = "0x3F65E44", Offset = "0x3F65E44", VA = "0x3F65E44")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0x3F65EC4", Offset = "0x3F65EC4", VA = "0x3F65EC4")]
		public MirzaPostProcessing()
		{
		}
	}
}
namespace MirzaBeig.Scripting.Effects
{
	[Token(Token = "0x200016F")]
	public class AttractionParticleAffector : ParticleAffector
	{
		[Token(Token = "0x4000751")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x124F350", Offset = "0x124F350")]
		public float arrivalRadius;

		[Token(Token = "0x4000752")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public float arrivedRadius;

		[Token(Token = "0x4000753")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float arrivalRadiusSqr;

		[Token(Token = "0x4000754")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float arrivedRadiusSqr;

		[Token(Token = "0x600079F")]
		[Address(RVA = "0x2C78570", Offset = "0x2C78570", VA = "0x2C78570", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x2C78578", Offset = "0x2C78578", VA = "0x2C78578", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x2C78580", Offset = "0x2C78580", VA = "0x2C78580", Slot = "8")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x2C78588", Offset = "0x2C78588", VA = "0x2C78588", Slot = "9")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x2C785D4", Offset = "0x2C785D4", VA = "0x2C785D4", Slot = "7")]
		protected override Vector3 GetForce()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x2C78650", Offset = "0x2C78650", VA = "0x2C78650", Slot = "10")]
		protected override void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x2C78758", Offset = "0x2C78758", VA = "0x2C78758")]
		public AttractionParticleAffector()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000170")]
	public static class Noise
	{
		[Token(Token = "0x4000755")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static float F3;

		[Token(Token = "0x4000756")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static float G3;

		[Token(Token = "0x4000757")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static byte[] perm;

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x3F66C80", Offset = "0x3F66C80", VA = "0x3F66C80")]
		private static float smooth(float t)
		{
			return default(float);
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x3F66C98", Offset = "0x3F66C98", VA = "0x3F66C98")]
		private static float fade(float t)
		{
			return default(float);
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x3F66CC4", Offset = "0x3F66CC4", VA = "0x3F66CC4")]
		private static int floor(float x)
		{
			return default(int);
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x3F66CF0", Offset = "0x3F66CF0", VA = "0x3F66CF0")]
		private static float lerp(float from, float to, float t)
		{
			return default(float);
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x3F66D00", Offset = "0x3F66D00", VA = "0x3F66D00")]
		private static float grad(int hash, float x, float y, float z)
		{
			return default(float);
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x3F66D70", Offset = "0x3F66D70", VA = "0x3F66D70")]
		public static float perlin(float x, float y, float z)
		{
			return default(float);
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x3F677F8", Offset = "0x3F677F8", VA = "0x3F677F8")]
		public static float simplex(float x, float y, float z)
		{
			return default(float);
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x3F67FE8", Offset = "0x3F67FE8", VA = "0x3F67FE8")]
		public static float octavePerlin(float x, float y, float z, float frequency, int octaves, float lacunarity, float persistence)
		{
			return default(float);
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x3F6811C", Offset = "0x3F6811C", VA = "0x3F6811C")]
		public static float octaveSimplex(float x, float y, float z, float frequency, int octaves, float lacunarity, float persistence)
		{
			return default(float);
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x3F68250", Offset = "0x3F68250", VA = "0x3F68250")]
		public static float perlinUnoptimized(float x, float y, float z)
		{
			return default(float);
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x3F68654", Offset = "0x3F68654", VA = "0x3F68654")]
		public static float simplexUnoptimized(float x, float y, float z)
		{
			return default(float);
		}
	}
	[Token(Token = "0x2000171")]
	public abstract class ParticleAffector : MonoBehaviour
	{
		[Token(Token = "0x2000172")]
		protected struct GetForceParameters
		{
			[Token(Token = "0x400076B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float distanceToAffectorCenterSqr;

			[Token(Token = "0x400076C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public Vector3 scaledDirectionToAffectorCenter;

			[Token(Token = "0x400076D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 particlePosition;
		}

		[Token(Token = "0x4000758")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x124F388", Offset = "0x124F388")]
		public float radius;

		[Token(Token = "0x4000759")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float force;

		[Token(Token = "0x400075A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 offset;

		[Token(Token = "0x400075B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float _radius;

		[Token(Token = "0x400075C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float radiusSqr;

		[Token(Token = "0x400075D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float forceDeltaTime;

		[Token(Token = "0x400075E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 transformPosition;

		[Token(Token = "0x400075F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float[] particleSystemExternalForcesMultipliers;

		[Token(Token = "0x4000760")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve scaleForceByDistance;

		[Token(Token = "0x4000761")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private ParticleSystem particleSystem;

		[Token(Token = "0x4000762")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public List<ParticleSystem> _particleSystems;

		[Token(Token = "0x4000763")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int particleSystemsCount;

		[Token(Token = "0x4000764")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private List<ParticleSystem> particleSystems;

		[Token(Token = "0x4000765")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private ParticleSystem.Particle[][] particleSystemParticles;

		[Token(Token = "0x4000766")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private ParticleSystem.MainModule[] particleSystemMainModules;

		[Token(Token = "0x4000767")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Renderer[] particleSystemRenderers;

		[Token(Token = "0x4000768")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		protected ParticleSystem currentParticleSystem;

		[Token(Token = "0x4000769")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected GetForceParameters parameters;

		[Token(Token = "0x400076A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public bool alwaysUpdate;

		[Token(Token = "0x1700009A")]
		public float scaledRadius
		{
			[Token(Token = "0x60007B2")]
			[Address(RVA = "0x3F6CD24", Offset = "0x3F6CD24", VA = "0x3F6CD24")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x3F6CD5C", Offset = "0x3F6CD5C", VA = "0x3F6CD5C", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x3F6CD60", Offset = "0x3F6CD60", VA = "0x3F6CD60", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x3F6CDBC", Offset = "0x3F6CDBC", VA = "0x3F6CDBC", Slot = "6")]
		protected virtual void PerParticleSystemSetup()
		{
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x3F6CDC0", Offset = "0x3F6CDC0", VA = "0x3F6CDC0", Slot = "7")]
		protected virtual Vector3 GetForce()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x3F6CDC8", Offset = "0x3F6CDC8", VA = "0x3F6CDC8", Slot = "8")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x3F6CDCC", Offset = "0x3F6CDCC", VA = "0x3F6CDCC")]
		public void AddParticleSystem(ParticleSystem particleSystem)
		{
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x3F6CE30", Offset = "0x3F6CE30", VA = "0x3F6CE30")]
		public void RemoveParticleSystem(ParticleSystem particleSystem)
		{
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x3F6CE94", Offset = "0x3F6CE94", VA = "0x3F6CE94", Slot = "9")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x3F6DC1C", Offset = "0x3F6DC1C", VA = "0x3F6DC1C")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x3F6DC20", Offset = "0x3F6DC20", VA = "0x3F6DC20", Slot = "10")]
		protected virtual void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x3F6DCA8", Offset = "0x3F6DCA8", VA = "0x3F6DCA8")]
		protected ParticleAffector()
		{
		}
	}
	[Token(Token = "0x2000173")]
	public class TurbulenceParticleAffector : ParticleAffector
	{
		[Token(Token = "0x2000174")]
		public enum NoiseType
		{
			[Token(Token = "0x400077C")]
			PseudoPerlin,
			[Token(Token = "0x400077D")]
			Perlin,
			[Token(Token = "0x400077E")]
			Simplex,
			[Token(Token = "0x400077F")]
			OctavePerlin,
			[Token(Token = "0x4000780")]
			OctaveSimplex
		}

		[Token(Token = "0x400076E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x124F3C0", Offset = "0x124F3C0")]
		public float speed;

		[Token(Token = "0x400076F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x124F3F8", Offset = "0x124F3F8")]
		public float frequency;

		[Token(Token = "0x4000770")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public NoiseType noiseType;

		[Token(Token = "0x4000771")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x124F410", Offset = "0x124F410")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x124F410", Offset = "0x124F410")]
		public int octaves;

		[Token(Token = "0x4000772")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x124F464", Offset = "0x124F464")]
		public float lacunarity;

		[Token(Token = "0x4000773")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x124F47C", Offset = "0x124F47C")]
		public float persistence;

		[Token(Token = "0x4000774")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float time;

		[Token(Token = "0x4000775")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private float randomX;

		[Token(Token = "0x4000776")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private float randomY;

		[Token(Token = "0x4000777")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private float randomZ;

		[Token(Token = "0x4000778")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private float offsetX;

		[Token(Token = "0x4000779")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private float offsetY;

		[Token(Token = "0x400077A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float offsetZ;

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x2B55678", Offset = "0x2B55678", VA = "0x2B55678", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x2B55680", Offset = "0x2B55680", VA = "0x2B55680", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x2B556F8", Offset = "0x2B556F8", VA = "0x2B556F8", Slot = "8")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x2B55728", Offset = "0x2B55728", VA = "0x2B55728", Slot = "9")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x2B55758", Offset = "0x2B55758", VA = "0x2B55758", Slot = "7")]
		protected override Vector3 GetForce()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x2B55B48", Offset = "0x2B55B48", VA = "0x2B55B48", Slot = "10")]
		protected override void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x2B55B84", Offset = "0x2B55B84", VA = "0x2B55B84")]
		public TurbulenceParticleAffector()
		{
		}
	}
	[Token(Token = "0x2000175")]
	public class VortexParticleAffector : ParticleAffector
	{
		[Token(Token = "0x4000781")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 axisOfRotation;

		[Token(Token = "0x4000782")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x124F494", Offset = "0x124F494")]
		public Vector3 axisOfRotationOffset;

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x2B578D8", Offset = "0x2B578D8", VA = "0x2B578D8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x2B578E0", Offset = "0x2B578E0", VA = "0x2B578E0", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x2B578E8", Offset = "0x2B578E8", VA = "0x2B578E8", Slot = "8")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x2B578F0", Offset = "0x2B578F0", VA = "0x2B578F0", Slot = "9")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x2B578F8", Offset = "0x2B578F8", VA = "0x2B578F8")]
		private void UpdateAxisOfRotation()
		{
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x2B5798C", Offset = "0x2B5798C", VA = "0x2B5798C", Slot = "6")]
		protected override void PerParticleSystemSetup()
		{
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x2B57990", Offset = "0x2B57990", VA = "0x2B57990", Slot = "7")]
		protected override Vector3 GetForce()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x2B579BC", Offset = "0x2B579BC", VA = "0x2B579BC", Slot = "10")]
		protected override void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x2B57BC4", Offset = "0x2B57BC4", VA = "0x2B57BC4")]
		public VortexParticleAffector()
		{
		}
	}
	[Token(Token = "0x2000176")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x124DB30", Offset = "0x124DB30")]
	public class ParticleFlocking : MonoBehaviour
	{
		[Token(Token = "0x2000177")]
		public struct Voxel
		{
			[Token(Token = "0x4000794")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Bounds bounds;

			[Token(Token = "0x4000795")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int[] particles;

			[Token(Token = "0x4000796")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int particleCount;
		}

		[Token(Token = "0x4000783")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x124F4CC", Offset = "0x124F4CC")]
		public float maxDistance;

		[Token(Token = "0x4000784")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x124F504", Offset = "0x124F504")]
		public float cohesion;

		[Token(Token = "0x4000785")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float separation;

		[Token(Token = "0x4000786")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x124F53C", Offset = "0x124F53C")]
		public bool useVoxels;

		[Token(Token = "0x4000787")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public bool voxelLocalCenterFromBounds;

		[Token(Token = "0x4000788")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float voxelVolume;

		[Token(Token = "0x4000789")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int voxelsPerAxis;

		[Token(Token = "0x400078A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int previousVoxelsPerAxisValue;

		[Token(Token = "0x400078B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Voxel[] voxels;

		[Token(Token = "0x400078C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ParticleSystem particleSystem;

		[Token(Token = "0x400078D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private ParticleSystem.Particle[] particles;

		[Token(Token = "0x400078E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector3[] particlePositions;

		[Token(Token = "0x400078F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private ParticleSystem.MainModule particleSystemMainModule;

		[Token(Token = "0x4000790")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x124F574", Offset = "0x124F574")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x124F574", Offset = "0x124F574")]
		public float delay;

		[Token(Token = "0x4000791")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float timer;

		[Token(Token = "0x4000792")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool alwaysUpdate;

		[Token(Token = "0x4000793")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool visible;

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x3F70AA4", Offset = "0x3F70AA4", VA = "0x3F70AA4")]
		private void Start()
		{
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x3F70B24", Offset = "0x3F70B24", VA = "0x3F70B24")]
		private void OnBecameVisible()
		{
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x3F70B30", Offset = "0x3F70B30", VA = "0x3F70B30")]
		private void OnBecameInvisible()
		{
		}

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0x3F70B38", Offset = "0x3F70B38", VA = "0x3F70B38")]
		private void buildVoxelGrid()
		{
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x3F70D50", Offset = "0x3F70D50", VA = "0x3F70D50")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x3F715E0", Offset = "0x3F715E0", VA = "0x3F715E0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x3F7175C", Offset = "0x3F7175C", VA = "0x3F7175C")]
		public ParticleFlocking()
		{
		}
	}
	[Token(Token = "0x2000178")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x124DB90", Offset = "0x124DB90")]
	public class AttractionParticleForceField : ParticleForceField
	{
		[Token(Token = "0x4000797")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x124F5C8", Offset = "0x124F5C8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x124F5C8", Offset = "0x124F5C8")]
		public float arrivalRadius;

		[Token(Token = "0x4000798")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x124F628", Offset = "0x124F628")]
		public float arrivedRadius;

		[Token(Token = "0x4000799")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private float arrivalRadiusSqr;

		[Token(Token = "0x400079A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private float arrivedRadiusSqr;

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0x2C7876C", Offset = "0x2C7876C", VA = "0x2C7876C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0x2C78774", Offset = "0x2C78774", VA = "0x2C78774", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0x2C7877C", Offset = "0x2C7877C", VA = "0x2C7877C", Slot = "8")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0x2C78784", Offset = "0x2C78784", VA = "0x2C78784", Slot = "9")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x60007D9")]
		[Address(RVA = "0x2C787D0", Offset = "0x2C787D0", VA = "0x2C787D0", Slot = "7")]
		protected override Vector3 GetForce()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0x2C7884C", Offset = "0x2C7884C", VA = "0x2C7884C", Slot = "10")]
		protected override void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60007DB")]
		[Address(RVA = "0x2C78954", Offset = "0x2C78954", VA = "0x2C78954")]
		public AttractionParticleForceField()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000179")]
	public static class Noise2
	{
		[Token(Token = "0x400079B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static float F3;

		[Token(Token = "0x400079C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static float G3;

		[Token(Token = "0x400079D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static byte[] perm;

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x3F68D28", Offset = "0x3F68D28", VA = "0x3F68D28")]
		private static float smooth(float t)
		{
			return default(float);
		}

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0x3F68D40", Offset = "0x3F68D40", VA = "0x3F68D40")]
		private static float fade(float t)
		{
			return default(float);
		}

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0x3F68D6C", Offset = "0x3F68D6C", VA = "0x3F68D6C")]
		private static int floor(float x)
		{
			return default(int);
		}

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x3F68D98", Offset = "0x3F68D98", VA = "0x3F68D98")]
		private static float lerp(float from, float to, float t)
		{
			return default(float);
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x3F68DA8", Offset = "0x3F68DA8", VA = "0x3F68DA8")]
		private static float grad(int hash, float x, float y, float z)
		{
			return default(float);
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0x3F68E18", Offset = "0x3F68E18", VA = "0x3F68E18")]
		public static float perlin(float x, float y, float z)
		{
			return default(float);
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x3F698A0", Offset = "0x3F698A0", VA = "0x3F698A0")]
		public static float simplex(float x, float y, float z)
		{
			return default(float);
		}

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x3F6A090", Offset = "0x3F6A090", VA = "0x3F6A090")]
		public static float octavePerlin(float x, float y, float z, float frequency, int octaves, float lacunarity, float persistence)
		{
			return default(float);
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x3F6A1C4", Offset = "0x3F6A1C4", VA = "0x3F6A1C4")]
		public static float octaveSimplex(float x, float y, float z, float frequency, int octaves, float lacunarity, float persistence)
		{
			return default(float);
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x3F6A2F8", Offset = "0x3F6A2F8", VA = "0x3F6A2F8")]
		public static float perlinUnoptimized(float x, float y, float z)
		{
			return default(float);
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0x3F6A6FC", Offset = "0x3F6A6FC", VA = "0x3F6A6FC")]
		public static float simplexUnoptimized(float x, float y, float z)
		{
			return default(float);
		}
	}
	[Token(Token = "0x200017A")]
	public abstract class ParticleForceField : MonoBehaviour
	{
		[Token(Token = "0x200017B")]
		protected struct GetForceParameters
		{
			[Token(Token = "0x40007B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float distanceToForceFieldCenterSqr;

			[Token(Token = "0x40007B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public Vector3 scaledDirectionToForceFieldCenter;

			[Token(Token = "0x40007B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 particlePosition;
		}

		[Token(Token = "0x400079E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x124F660", Offset = "0x124F660")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x124F660", Offset = "0x124F660")]
		public float radius;

		[Token(Token = "0x400079F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x124F6C0", Offset = "0x124F6C0")]
		public float force;

		[Token(Token = "0x40007A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x124F6F8", Offset = "0x124F6F8")]
		public Vector3 center;

		[Token(Token = "0x40007A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float _radius;

		[Token(Token = "0x40007A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float radiusSqr;

		[Token(Token = "0x40007A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 transformPosition;

		[Token(Token = "0x40007A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float[] particleSystemExternalForcesMultipliers;

		[Token(Token = "0x40007A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x124F730", Offset = "0x124F730")]
		public AnimationCurve forceOverDistance;

		[Token(Token = "0x40007A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private ParticleSystem particleSystem;

		[Token(Token = "0x40007A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x124F768", Offset = "0x124F768")]
		public List<ParticleSystem> _particleSystems;

		[Token(Token = "0x40007A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int particleSystemsCount;

		[Token(Token = "0x40007A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private List<ParticleSystem> particleSystems;

		[Token(Token = "0x40007AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private ParticleSystem.Particle[][] particleSystemParticles;

		[Token(Token = "0x40007AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private ParticleSystem.MainModule[] particleSystemMainModules;

		[Token(Token = "0x40007AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Renderer[] particleSystemRenderers;

		[Token(Token = "0x40007AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		protected ParticleSystem currentParticleSystem;

		[Token(Token = "0x40007AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		protected GetForceParameters parameters;

		[Token(Token = "0x40007AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x124F7A0", Offset = "0x124F7A0")]
		public bool alwaysUpdate;

		[Token(Token = "0x1700009B")]
		public float scaledRadius
		{
			[Token(Token = "0x60007E8")]
			[Address(RVA = "0x3F71788", Offset = "0x3F71788", VA = "0x3F71788")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0x3F717C0", Offset = "0x3F717C0", VA = "0x3F717C0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0x3F717C4", Offset = "0x3F717C4", VA = "0x3F717C4", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0x3F71820", Offset = "0x3F71820", VA = "0x3F71820", Slot = "6")]
		protected virtual void PerParticleSystemSetup()
		{
		}

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0x3F71824", Offset = "0x3F71824", VA = "0x3F71824", Slot = "7")]
		protected virtual Vector3 GetForce()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0x3F7182C", Offset = "0x3F7182C", VA = "0x3F7182C", Slot = "8")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0x3F71830", Offset = "0x3F71830", VA = "0x3F71830")]
		public void AddParticleSystem(ParticleSystem particleSystem)
		{
		}

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0x3F71894", Offset = "0x3F71894", VA = "0x3F71894")]
		public void RemoveParticleSystem(ParticleSystem particleSystem)
		{
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x3F718F8", Offset = "0x3F718F8", VA = "0x3F718F8", Slot = "9")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0x3F726B4", Offset = "0x3F726B4", VA = "0x3F726B4")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0x3F726B8", Offset = "0x3F726B8", VA = "0x3F726B8", Slot = "10")]
		protected virtual void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0x3F72740", Offset = "0x3F72740", VA = "0x3F72740")]
		protected ParticleForceField()
		{
		}
	}
	[Token(Token = "0x200017C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x124DBC8", Offset = "0x124DBC8")]
	public class TurbulenceParticleForceField : ParticleForceField
	{
		[Token(Token = "0x200017D")]
		public enum NoiseType
		{
			[Token(Token = "0x40007C1")]
			PseudoPerlin,
			[Token(Token = "0x40007C2")]
			Perlin,
			[Token(Token = "0x40007C3")]
			Simplex,
			[Token(Token = "0x40007C4")]
			OctavePerlin,
			[Token(Token = "0x40007C5")]
			OctaveSimplex
		}

		[Token(Token = "0x40007B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x124F7D8", Offset = "0x124F7D8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x124F7D8", Offset = "0x124F7D8")]
		public float scrollSpeed;

		[Token(Token = "0x40007B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x124F838", Offset = "0x124F838")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x124F838", Offset = "0x124F838")]
		public float frequency;

		[Token(Token = "0x40007B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public NoiseType noiseType;

		[Token(Token = "0x40007B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x124F88C", Offset = "0x124F88C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x124F88C", Offset = "0x124F88C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x124F88C", Offset = "0x124F88C")]
		public int octaves;

		[Token(Token = "0x40007B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x124F904", Offset = "0x124F904")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x124F904", Offset = "0x124F904")]
		public float octaveMultiplier;

		[Token(Token = "0x40007B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x124F958", Offset = "0x124F958")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x124F958", Offset = "0x124F958")]
		public float octaveScale;

		[Token(Token = "0x40007B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float time;

		[Token(Token = "0x40007BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float randomX;

		[Token(Token = "0x40007BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float randomY;

		[Token(Token = "0x40007BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private float randomZ;

		[Token(Token = "0x40007BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private float offsetX;

		[Token(Token = "0x40007BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private float offsetY;

		[Token(Token = "0x40007BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private float offsetZ;

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0x2B55BA4", Offset = "0x2B55BA4", VA = "0x2B55BA4", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0x2B55BAC", Offset = "0x2B55BAC", VA = "0x2B55BAC", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0x2B55C24", Offset = "0x2B55C24", VA = "0x2B55C24", Slot = "8")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60007F7")]
		[Address(RVA = "0x2B55C54", Offset = "0x2B55C54", VA = "0x2B55C54", Slot = "9")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x60007F8")]
		[Address(RVA = "0x2B55C84", Offset = "0x2B55C84", VA = "0x2B55C84", Slot = "7")]
		protected override Vector3 GetForce()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007F9")]
		[Address(RVA = "0x2B56074", Offset = "0x2B56074", VA = "0x2B56074", Slot = "10")]
		protected override void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0x2B560B0", Offset = "0x2B560B0", VA = "0x2B560B0")]
		public TurbulenceParticleForceField()
		{
		}
	}
	[Token(Token = "0x200017E")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x124DC00", Offset = "0x124DC00")]
	public class VortexParticleForceField : ParticleForceField
	{
		[Token(Token = "0x40007C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 axisOfRotation;

		[Token(Token = "0x40007C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x124F9AC", Offset = "0x124F9AC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x124F9AC", Offset = "0x124F9AC")]
		public Vector3 axisOfRotationOffset;

		[Token(Token = "0x60007FB")]
		[Address(RVA = "0x2B57BF8", Offset = "0x2B57BF8", VA = "0x2B57BF8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60007FC")]
		[Address(RVA = "0x2B57C00", Offset = "0x2B57C00", VA = "0x2B57C00", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60007FD")]
		[Address(RVA = "0x2B57C08", Offset = "0x2B57C08", VA = "0x2B57C08", Slot = "8")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0x2B57C10", Offset = "0x2B57C10", VA = "0x2B57C10", Slot = "9")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0x2B57C18", Offset = "0x2B57C18", VA = "0x2B57C18")]
		private void UpdateAxisOfRotation()
		{
		}

		[Token(Token = "0x6000800")]
		[Address(RVA = "0x2B57CAC", Offset = "0x2B57CAC", VA = "0x2B57CAC", Slot = "6")]
		protected override void PerParticleSystemSetup()
		{
		}

		[Token(Token = "0x6000801")]
		[Address(RVA = "0x2B57CB0", Offset = "0x2B57CB0", VA = "0x2B57CB0", Slot = "7")]
		protected override Vector3 GetForce()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000802")]
		[Address(RVA = "0x2B57CDC", Offset = "0x2B57CDC", VA = "0x2B57CDC", Slot = "10")]
		protected override void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000803")]
		[Address(RVA = "0x2B57E90", Offset = "0x2B57E90", VA = "0x2B57E90")]
		public VortexParticleForceField()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200017F")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x124DC38", Offset = "0x124DC38")]
	public class ParticleLights : MonoBehaviour
	{
		[Token(Token = "0x40007C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private ParticleSystem ps;

		[Token(Token = "0x40007C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<Light> lights;

		[Token(Token = "0x40007CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float scale;

		[Token(Token = "0x40007CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x124FA0C", Offset = "0x124FA0C")]
		public float intensity;

		[Token(Token = "0x40007CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Color colour;

		[Token(Token = "0x40007CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x124FA24", Offset = "0x124FA24")]
		public float colourFromParticle;

		[Token(Token = "0x40007CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public LightShadows shadows;

		[Token(Token = "0x40007CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private GameObject template;

		[Token(Token = "0x6000804")]
		[Address(RVA = "0x3F744DC", Offset = "0x3F744DC", VA = "0x3F744DC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000805")]
		[Address(RVA = "0x3F744E0", Offset = "0x3F744E0", VA = "0x3F744E0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000806")]
		[Address(RVA = "0x3F745E0", Offset = "0x3F745E0", VA = "0x3F745E0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0x3F745E4", Offset = "0x3F745E4", VA = "0x3F745E4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0x3F74A50", Offset = "0x3F74A50", VA = "0x3F74A50")]
		public ParticleLights()
		{
		}
	}
	[Token(Token = "0x2000180")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x124DC98", Offset = "0x124DC98")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x124DC98", Offset = "0x124DC98")]
	public class ParticlePlexus : MonoBehaviour
	{
		[Token(Token = "0x40007D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxDistance;

		[Token(Token = "0x40007D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int maxConnections;

		[Token(Token = "0x40007D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int maxLineRenderers;

		[Token(Token = "0x40007D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x124FA3C", Offset = "0x124FA3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x124FA3C", Offset = "0x124FA3C")]
		public float widthFromParticle;

		[Token(Token = "0x40007D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x124FA7C", Offset = "0x124FA7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x124FA7C", Offset = "0x124FA7C")]
		public float colourFromParticle;

		[Token(Token = "0x40007D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x124FABC", Offset = "0x124FABC")]
		public float alphaFromParticle;

		[Token(Token = "0x40007D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x124FAD4", Offset = "0x124FAD4")]
		public AnimationCurve alphaOverNormalizedDistance;

		[Token(Token = "0x40007D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ParticleSystem particleSystem;

		[Token(Token = "0x40007D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ParticleSystem.Particle[] particles;

		[Token(Token = "0x40007D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3[] particlePositions;

		[Token(Token = "0x40007DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Color[] particleColours;

		[Token(Token = "0x40007DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float[] particleSizes;

		[Token(Token = "0x40007DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ParticleSystem.MainModule particleSystemMainModule;

		[Token(Token = "0x40007DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x124FAE4", Offset = "0x124FAE4")]
		public LineRenderer lineRendererTemplate;

		[Token(Token = "0x40007DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private List<LineRenderer> lineRenderers;

		[Token(Token = "0x40007DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Transform _transform;

		[Token(Token = "0x40007E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x124FAF4", Offset = "0x124FAF4")]
		public MeshFilter trianglesMeshFilter;

		[Token(Token = "0x40007E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Mesh trianglesMesh;

		[Token(Token = "0x40007E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private List<int[]> allConnectedParticles;

		[Token(Token = "0x40007E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x124FB2C", Offset = "0x124FB2C")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x124FB2C", Offset = "0x124FB2C")]
		public float maxDistanceTriangleBias;

		[Token(Token = "0x40007E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x124FB6C", Offset = "0x124FB6C")]
		public bool trianglesDistanceCheck;

		[Token(Token = "0x40007E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x124FB7C", Offset = "0x124FB7C")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x124FB7C", Offset = "0x124FB7C")]
		public float triangleColourFromParticle;

		[Token(Token = "0x40007E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x124FBBC", Offset = "0x124FBBC")]
		public float triangleAlphaFromParticle;

		[Token(Token = "0x40007E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x124FBD4", Offset = "0x124FBD4")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x124FBD4", Offset = "0x124FBD4")]
		public float delay;

		[Token(Token = "0x40007E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private float timer;

		[Token(Token = "0x40007E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public bool alwaysUpdate;

		[Token(Token = "0x40007EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
		private bool visible;

		[Token(Token = "0x6000809")]
		[Address(RVA = "0x3F751A4", Offset = "0x3F751A4", VA = "0x3F751A4")]
		private void Start()
		{
		}

		[Token(Token = "0x600080A")]
		[Address(RVA = "0x3F752DC", Offset = "0x3F752DC", VA = "0x3F752DC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0x3F75380", Offset = "0x3F75380", VA = "0x3F75380")]
		private void OnBecameVisible()
		{
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0x3F7538C", Offset = "0x3F7538C", VA = "0x3F7538C")]
		private void OnBecameInvisible()
		{
		}

		[Token(Token = "0x600080D")]
		[Address(RVA = "0x3F75394", Offset = "0x3F75394", VA = "0x3F75394")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600080E")]
		[Address(RVA = "0x3F76D60", Offset = "0x3F76D60", VA = "0x3F76D60")]
		public ParticlePlexus()
		{
		}
	}
	[Token(Token = "0x2000181")]
	public static class CreateLUT
	{
		[Token(Token = "0x600080F")]
		[Address(RVA = "0x2C7D174", Offset = "0x2C7D174", VA = "0x2C7D174")]
		public static void fromGradient(int steps, Gradient gradient, ref Texture2D texture)
		{
		}

		[Token(Token = "0x6000810")]
		[Address(RVA = "0x2C7D324", Offset = "0x2C7D324", VA = "0x2C7D324")]
		public static void fromAnimationCurve(int steps, AnimationCurve curve, ref Texture2D texture)
		{
		}
	}
}
namespace MirzaBeig.ParticleSystems
{
	[Token(Token = "0x2000182")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x124DD1C", Offset = "0x124DD1C")]
	public class AnimatedLight : MonoBehaviour
	{
		[Token(Token = "0x40007EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Light light;

		[Token(Token = "0x40007EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124FC28", Offset = "0x124FC28")]
		private float <time>k__BackingField;

		[Token(Token = "0x40007ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float duration;

		[Token(Token = "0x40007EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool evaluating;

		[Token(Token = "0x40007EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Gradient colourOverLifetime;

		[Token(Token = "0x40007F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve intensityOverLifetime;

		[Token(Token = "0x40007F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool loop;

		[Token(Token = "0x40007F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		public bool autoDestruct;

		[Token(Token = "0x40007F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Color startColour;

		[Token(Token = "0x40007F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float startIntensity;

		[Token(Token = "0x1700009C")]
		public float time
		{
			[Token(Token = "0x6000811")]
			[Address(RVA = "0x1A4A8E8", Offset = "0x1A4A8E8", VA = "0x1A4A8E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x12525D8", Offset = "0x12525D8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000812")]
			[Address(RVA = "0x1A4A8F0", Offset = "0x1A4A8F0", VA = "0x1A4A8F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x12525E8", Offset = "0x12525E8")]
			set
			{
			}
		}

		[Token(Token = "0x6000813")]
		[Address(RVA = "0x1A4A8F8", Offset = "0x1A4A8F8", VA = "0x1A4A8F8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000814")]
		[Address(RVA = "0x1A4A954", Offset = "0x1A4A954", VA = "0x1A4A954")]
		private void Start()
		{
		}

		[Token(Token = "0x6000815")]
		[Address(RVA = "0x1A4AA34", Offset = "0x1A4AA34", VA = "0x1A4AA34")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000816")]
		[Address(RVA = "0x1A4AA38", Offset = "0x1A4AA38", VA = "0x1A4AA38")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000817")]
		[Address(RVA = "0x1A4AB24", Offset = "0x1A4AB24", VA = "0x1A4AB24")]
		private void Update()
		{
		}

		[Token(Token = "0x6000818")]
		[Address(RVA = "0x1A4ACC4", Offset = "0x1A4ACC4", VA = "0x1A4ACC4")]
		public AnimatedLight()
		{
		}
	}
	[Token(Token = "0x2000183")]
	public class Billboard : MonoBehaviour
	{
		[Token(Token = "0x6000819")]
		[Address(RVA = "0x2C794A0", Offset = "0x2C794A0", VA = "0x2C794A0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600081A")]
		[Address(RVA = "0x2C794F4", Offset = "0x2C794F4", VA = "0x2C794F4")]
		public Billboard()
		{
		}
	}
	[Token(Token = "0x2000184")]
	public class DestroyAfterTime : MonoBehaviour
	{
		[Token(Token = "0x40007F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float time;

		[Token(Token = "0x600081B")]
		[Address(RVA = "0x2C80164", Offset = "0x2C80164", VA = "0x2C80164")]
		private void Start()
		{
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0x2C801EC", Offset = "0x2C801EC", VA = "0x2C801EC")]
		public DestroyAfterTime()
		{
		}
	}
	[Token(Token = "0x2000185")]
	public class DestroyOnParticlesDead : ParticleSystems
	{
		[Token(Token = "0x600081D")]
		[Address(RVA = "0x2C801FC", Offset = "0x2C801FC", VA = "0x2C801FC", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0x2C80204", Offset = "0x2C80204", VA = "0x2C80204", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600081F")]
		[Address(RVA = "0x2C8020C", Offset = "0x2C8020C", VA = "0x2C8020C")]
		private void onParticleSystemsDead()
		{
		}

		[Token(Token = "0x6000820")]
		[Address(RVA = "0x2C80284", Offset = "0x2C80284", VA = "0x2C80284", Slot = "6")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000821")]
		[Address(RVA = "0x2C8028C", Offset = "0x2C8028C", VA = "0x2C8028C", Slot = "7")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x6000822")]
		[Address(RVA = "0x2C80294", Offset = "0x2C80294", VA = "0x2C80294")]
		public DestroyOnParticlesDead()
		{
		}
	}
	[Token(Token = "0x2000186")]
	public class DestroyOnTrailsDestroyed : TrailRenderers
	{
		[Token(Token = "0x6000823")]
		[Address(RVA = "0x2C8029C", Offset = "0x2C8029C", VA = "0x2C8029C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000824")]
		[Address(RVA = "0x2C802A4", Offset = "0x2C802A4", VA = "0x2C802A4", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000825")]
		[Address(RVA = "0x2C802AC", Offset = "0x2C802AC", VA = "0x2C802AC", Slot = "6")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0x2C803B8", Offset = "0x2C803B8", VA = "0x2C803B8")]
		public DestroyOnTrailsDestroyed()
		{
		}
	}
	[Token(Token = "0x2000187")]
	public class ParticleSystems : MonoBehaviour
	{
		[Token(Token = "0x40007F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124FC38", Offset = "0x124FC38")]
		private ParticleSystem[] <particleSystems>k__BackingField;

		[Token(Token = "0x1700009D")]
		public ParticleSystem[] particleSystems
		{
			[Token(Token = "0x6000827")]
			[Address(RVA = "0x3F778C4", Offset = "0x3F778C4", VA = "0x3F778C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x12525F8", Offset = "0x12525F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000828")]
			[Address(RVA = "0x3F778CC", Offset = "0x3F778CC", VA = "0x3F778CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1252608", Offset = "0x1252608")]
			set
			{
			}
		}

		[Token(Token = "0x6000829")]
		[Address(RVA = "0x3F778D4", Offset = "0x3F778D4", VA = "0x3F778D4", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600082A")]
		[Address(RVA = "0x3F77930", Offset = "0x3F77930", VA = "0x3F77930", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0x3F77934", Offset = "0x3F77934", VA = "0x3F77934", Slot = "6")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600082C")]
		[Address(RVA = "0x3F77938", Offset = "0x3F77938", VA = "0x3F77938", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0x3F7793C", Offset = "0x3F7793C", VA = "0x3F7793C")]
		public void Reset()
		{
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0x3F779AC", Offset = "0x3F779AC", VA = "0x3F779AC")]
		public void Play()
		{
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0x3F77A1C", Offset = "0x3F77A1C", VA = "0x3F77A1C")]
		public void Pause()
		{
		}

		[Token(Token = "0x6000830")]
		[Address(RVA = "0x3F77A8C", Offset = "0x3F77A8C", VA = "0x3F77A8C")]
		public void Stop()
		{
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0x3F77AFC", Offset = "0x3F77AFC", VA = "0x3F77AFC")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000832")]
		[Address(RVA = "0x3F77B6C", Offset = "0x3F77B6C", VA = "0x3F77B6C")]
		public void SetLoop(bool loop)
		{
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0x3F77BFC", Offset = "0x3F77BFC", VA = "0x3F77BFC")]
		public void SetPlaybackSpeed(float speed)
		{
		}

		[Token(Token = "0x6000834")]
		[Address(RVA = "0x3F77C8C", Offset = "0x3F77C8C", VA = "0x3F77C8C")]
		public void Simulate(float time, bool reset = false)
		{
		}

		[Token(Token = "0x6000835")]
		[Address(RVA = "0x3F77D1C", Offset = "0x3F77D1C", VA = "0x3F77D1C")]
		public bool IsAlive()
		{
			return default(bool);
		}

		[Token(Token = "0x6000836")]
		[Address(RVA = "0x3F77E10", Offset = "0x3F77E10", VA = "0x3F77E10")]
		public bool IsPlaying(bool checkAll = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000837")]
		[Address(RVA = "0x3F77E64", Offset = "0x3F77E64", VA = "0x3F77E64")]
		public int GetParticleCount()
		{
			return default(int);
		}

		[Token(Token = "0x6000838")]
		[Address(RVA = "0x3F77F54", Offset = "0x3F77F54", VA = "0x3F77F54")]
		public ParticleSystems()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000188")]
	public class PerlinNoise
	{
		[Token(Token = "0x40007F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Vector2 offset;

		[Token(Token = "0x40007F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float amplitude;

		[Token(Token = "0x40007F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float frequency;

		[Token(Token = "0x40007FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool unscaledTime;

		[Token(Token = "0x6000839")]
		[Address(RVA = "0x3F785DC", Offset = "0x3F785DC", VA = "0x3F785DC")]
		public void init()
		{
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0x3F78638", Offset = "0x3F78638", VA = "0x3F78638")]
		public float GetValue(float time)
		{
			return default(float);
		}

		[Token(Token = "0x600083B")]
		[Address(RVA = "0x3F78680", Offset = "0x3F78680", VA = "0x3F78680")]
		public PerlinNoise()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000189")]
	public class PerlinNoiseXYZ
	{
		[Token(Token = "0x40007FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PerlinNoise x;

		[Token(Token = "0x40007FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PerlinNoise y;

		[Token(Token = "0x40007FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PerlinNoise z;

		[Token(Token = "0x40007FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool unscaledTime;

		[Token(Token = "0x40007FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float amplitudeScale;

		[Token(Token = "0x4000800")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float frequencyScale;

		[Token(Token = "0x600083C")]
		[Address(RVA = "0x3F78690", Offset = "0x3F78690", VA = "0x3F78690")]
		public void init()
		{
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0x3F78758", Offset = "0x3F78758", VA = "0x3F78758")]
		public Vector3 GetXYZ(float time)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600083E")]
		[Address(RVA = "0x3F78840", Offset = "0x3F78840", VA = "0x3F78840")]
		public PerlinNoiseXYZ()
		{
		}
	}
	[Token(Token = "0x200018A")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x124DD7C", Offset = "0x124DD7C")]
	[ExecuteInEditMode]
	public class RendererSortingOrder : MonoBehaviour
	{
		[Token(Token = "0x4000801")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int sortingOrder;

		[Token(Token = "0x600083F")]
		[Address(RVA = "0x2B499E0", Offset = "0x2B499E0", VA = "0x2B499E0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000840")]
		[Address(RVA = "0x2B499E4", Offset = "0x2B499E4", VA = "0x2B499E4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000841")]
		[Address(RVA = "0x2B49A44", Offset = "0x2B49A44", VA = "0x2B49A44")]
		private void Update()
		{
		}

		[Token(Token = "0x6000842")]
		[Address(RVA = "0x2B49A48", Offset = "0x2B49A48", VA = "0x2B49A48")]
		public RendererSortingOrder()
		{
		}
	}
	[Token(Token = "0x200018B")]
	public class Rotator : MonoBehaviour
	{
		[Token(Token = "0x4000802")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 localRotationSpeed;

		[Token(Token = "0x4000803")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 worldRotationSpeed;

		[Token(Token = "0x4000804")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool executeInEditMode;

		[Token(Token = "0x4000805")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool unscaledTime;

		[Token(Token = "0x6000843")]
		[Address(RVA = "0x2B4A988", Offset = "0x2B4A988", VA = "0x2B4A988")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000844")]
		[Address(RVA = "0x2B4A98C", Offset = "0x2B4A98C", VA = "0x2B4A98C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000845")]
		[Address(RVA = "0x2B4A990", Offset = "0x2B4A990", VA = "0x2B4A990")]
		private void OnRenderObject()
		{
		}

		[Token(Token = "0x6000846")]
		[Address(RVA = "0x2B4AB38", Offset = "0x2B4AB38", VA = "0x2B4AB38")]
		private void Update()
		{
		}

		[Token(Token = "0x6000847")]
		[Address(RVA = "0x2B4AA10", Offset = "0x2B4AA10", VA = "0x2B4AA10")]
		private void rotate()
		{
		}

		[Token(Token = "0x6000848")]
		[Address(RVA = "0x2B4ABB0", Offset = "0x2B4ABB0", VA = "0x2B4ABB0")]
		public Rotator()
		{
		}
	}
	[Token(Token = "0x200018C")]
	public class TrailRenderers : MonoBehaviour
	{
		[Token(Token = "0x4000806")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public TrailRenderer[] trailRenderers;

		[Token(Token = "0x6000849")]
		[Address(RVA = "0x2B554A0", Offset = "0x2B554A0", VA = "0x2B554A0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600084A")]
		[Address(RVA = "0x2B554A4", Offset = "0x2B554A4", VA = "0x2B554A4", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600084B")]
		[Address(RVA = "0x2B55500", Offset = "0x2B55500", VA = "0x2B55500", Slot = "6")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600084C")]
		[Address(RVA = "0x2B55504", Offset = "0x2B55504", VA = "0x2B55504")]
		public void setAutoDestruct(bool value)
		{
		}

		[Token(Token = "0x600084D")]
		[Address(RVA = "0x2B55580", Offset = "0x2B55580", VA = "0x2B55580")]
		public TrailRenderers()
		{
		}
	}
	[Token(Token = "0x200018D")]
	public class TransformNoise : MonoBehaviour
	{
		[Token(Token = "0x4000807")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PerlinNoiseXYZ positionNoise;

		[Token(Token = "0x4000808")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PerlinNoiseXYZ rotationNoise;

		[Token(Token = "0x4000809")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool unscaledTime;

		[Token(Token = "0x400080A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float time;

		[Token(Token = "0x600084E")]
		[Address(RVA = "0x2B55588", Offset = "0x2B55588", VA = "0x2B55588")]
		private void Start()
		{
		}

		[Token(Token = "0x600084F")]
		[Address(RVA = "0x2B555C4", Offset = "0x2B555C4", VA = "0x2B555C4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000850")]
		[Address(RVA = "0x2B55670", Offset = "0x2B55670", VA = "0x2B55670")]
		public TransformNoise()
		{
		}
	}
}
namespace MirzaBeig.ParticleSystems.Demos
{
	[Serializable]
	[Token(Token = "0x200018E")]
	public class DemoManager_XPTitles : MonoBehaviour
	{
		[Token(Token = "0x400080B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private LoopingParticleSystemsManager list;

		[Token(Token = "0x400080C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Text particleCountText;

		[Token(Token = "0x400080D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Text currentParticleSystemText;

		[Token(Token = "0x400080E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Rotator cameraRotator;

		[Token(Token = "0x6000851")]
		[Address(RVA = "0x2C7F734", Offset = "0x2C7F734", VA = "0x2C7F734")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000852")]
		[Address(RVA = "0x2C7F7A8", Offset = "0x2C7F7A8", VA = "0x2C7F7A8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000853")]
		[Address(RVA = "0x2C7F8C8", Offset = "0x2C7F8C8", VA = "0x2C7F8C8")]
		public void ToggleRotation()
		{
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0x2C7F908", Offset = "0x2C7F908", VA = "0x2C7F908")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x6000855")]
		[Address(RVA = "0x2C7F94C", Offset = "0x2C7F94C", VA = "0x2C7F94C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000856")]
		[Address(RVA = "0x2C7FA48", Offset = "0x2C7FA48", VA = "0x2C7FA48")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000857")]
		[Address(RVA = "0x2C7F9D8", Offset = "0x2C7F9D8", VA = "0x2C7F9D8")]
		public void Next()
		{
		}

		[Token(Token = "0x6000858")]
		[Address(RVA = "0x2C7FA10", Offset = "0x2C7FA10", VA = "0x2C7FA10")]
		public void previous()
		{
		}

		[Token(Token = "0x6000859")]
		[Address(RVA = "0x2C7F818", Offset = "0x2C7F818", VA = "0x2C7F818")]
		private void updateCurrentParticleSystemNameText()
		{
		}

		[Token(Token = "0x600085A")]
		[Address(RVA = "0x2C7FB68", Offset = "0x2C7FB68", VA = "0x2C7FB68")]
		public DemoManager_XPTitles()
		{
		}
	}
	[Token(Token = "0x200018F")]
	public enum CameraShakeTarget
	{
		[Token(Token = "0x4000810")]
		Position,
		[Token(Token = "0x4000811")]
		Rotation
	}
	[Token(Token = "0x2000190")]
	public enum CameraShakeAmplitudeCurve
	{
		[Token(Token = "0x4000813")]
		Constant,
		[Token(Token = "0x4000814")]
		FadeInOut25,
		[Token(Token = "0x4000815")]
		FadeInOut50,
		[Token(Token = "0x4000816")]
		FadeInOut75
	}
	[Token(Token = "0x2000191")]
	public enum CameraShakeAmplitudeOverDistanceCurve
	{
		[Token(Token = "0x4000818")]
		Constant,
		[Token(Token = "0x4000819")]
		LinearFadeIn,
		[Token(Token = "0x400081A")]
		LinearFadeOut
	}
	[Token(Token = "0x2000192")]
	public class CameraShake : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000193")]
		public class Shake
		{
			[Token(Token = "0x4000821")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float amplitude;

			[Token(Token = "0x4000822")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float frequency;

			[Token(Token = "0x4000823")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float duration;

			[Token(Token = "0x4000824")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[HideInInspector]
			public CameraShakeTarget target;

			[Token(Token = "0x4000825")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private float timeRemaining;

			[Token(Token = "0x4000826")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private Vector2 perlinNoiseX;

			[Token(Token = "0x4000827")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Vector2 perlinNoiseY;

			[Token(Token = "0x4000828")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector2 perlinNoiseZ;

			[Token(Token = "0x4000829")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			[HideInInspector]
			public Vector3 noise;

			[Token(Token = "0x400082A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public AnimationCurve amplitudeOverLifetimeCurve;

			[Token(Token = "0x6000860")]
			[Address(RVA = "0x310A940", Offset = "0x310A940", VA = "0x310A940")]
			public void Init()
			{
			}

			[Token(Token = "0x6000861")]
			[Address(RVA = "0x310A9F8", Offset = "0x310A9F8", VA = "0x310A9F8")]
			private void Init(float amplitude, float frequency, float duration, CameraShakeTarget target)
			{
			}

			[Token(Token = "0x6000862")]
			[Address(RVA = "0x310A94C", Offset = "0x310A94C", VA = "0x310A94C")]
			public void ApplyRandomSeed()
			{
			}

			[Token(Token = "0x6000863")]
			[Address(RVA = "0x310AA0C", Offset = "0x310AA0C", VA = "0x310AA0C")]
			public Shake(float amplitude, float frequency, float duration, CameraShakeTarget target, AnimationCurve amplitudeOverLifetimeCurve)
			{
			}

			[Token(Token = "0x6000864")]
			[Address(RVA = "0x310ABC0", Offset = "0x310ABC0", VA = "0x310ABC0")]
			public Shake(float amplitude, float frequency, float duration, CameraShakeTarget target, CameraShakeAmplitudeCurve amplitudeOverLifetimeCurve)
			{
			}

			[Token(Token = "0x6000865")]
			[Address(RVA = "0x310A930", Offset = "0x310A930", VA = "0x310A930")]
			public bool IsAlive()
			{
				return default(bool);
			}

			[Token(Token = "0x6000866")]
			[Address(RVA = "0x310B108", Offset = "0x310B108", VA = "0x310B108")]
			public void Update()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000194")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124DDEC", Offset = "0x124DDEC")]
		private sealed class <>c
		{
			[Token(Token = "0x400082B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400082C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<Shake> <>9__10_0;

			[Token(Token = "0x6000868")]
			[Address(RVA = "0x310A908", Offset = "0x310A908", VA = "0x310A908")]
			public <>c()
			{
			}

			[Token(Token = "0x6000869")]
			[Address(RVA = "0x310A910", Offset = "0x310A910", VA = "0x310A910")]
			internal bool <Update>b__10_0(Shake x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400081B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float smoothDampTime;

		[Token(Token = "0x400081C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector3 smoothDampPositionVelocity;

		[Token(Token = "0x400081D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float smoothDampRotationVelocityX;

		[Token(Token = "0x400081E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float smoothDampRotationVelocityY;

		[Token(Token = "0x400081F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float smoothDampRotationVelocityZ;

		[Token(Token = "0x4000820")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<Shake> shakes;

		[Token(Token = "0x600085B")]
		[Address(RVA = "0x2C7A6B4", Offset = "0x2C7A6B4", VA = "0x2C7A6B4")]
		private void Start()
		{
		}

		[Token(Token = "0x600085C")]
		[Address(RVA = "0x2C7A6B8", Offset = "0x2C7A6B8", VA = "0x2C7A6B8")]
		public void Add(float amplitude, float frequency, float duration, CameraShakeTarget target, AnimationCurve amplitudeOverLifetimeCurve)
		{
		}

		[Token(Token = "0x600085D")]
		[Address(RVA = "0x2C7A77C", Offset = "0x2C7A77C", VA = "0x2C7A77C")]
		public void Add(float amplitude, float frequency, float duration, CameraShakeTarget target, CameraShakeAmplitudeCurve amplitudeOverLifetimeCurve)
		{
		}

		[Token(Token = "0x600085E")]
		[Address(RVA = "0x2C7A840", Offset = "0x2C7A840", VA = "0x2C7A840")]
		private void Update()
		{
		}

		[Token(Token = "0x600085F")]
		[Address(RVA = "0x2C7ABDC", Offset = "0x2C7ABDC", VA = "0x2C7ABDC")]
		public CameraShake()
		{
		}
	}
	[Token(Token = "0x2000195")]
	public class DemoManager : MonoBehaviour
	{
		[Token(Token = "0x2000196")]
		public enum ParticleMode
		{
			[Token(Token = "0x4000853")]
			looping,
			[Token(Token = "0x4000854")]
			oneshot
		}

		[Token(Token = "0x2000197")]
		public enum Level
		{
			[Token(Token = "0x4000856")]
			none,
			[Token(Token = "0x4000857")]
			basic
		}

		[Token(Token = "0x400082D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform cameraRotationTransform;

		[Token(Token = "0x400082E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform cameraTranslationTransform;

		[Token(Token = "0x400082F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 cameraLookAtPosition;

		[Token(Token = "0x4000830")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public MouseFollow mouse;

		[Token(Token = "0x4000831")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 targetCameraPosition;

		[Token(Token = "0x4000832")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 targetCameraRotation;

		[Token(Token = "0x4000833")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 cameraPositionStart;

		[Token(Token = "0x4000834")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private Vector3 cameraRotationStart;

		[Token(Token = "0x4000835")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector2 input;

		[Token(Token = "0x4000836")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 cameraRotation;

		[Token(Token = "0x4000837")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public float cameraMoveAmount;

		[Token(Token = "0x4000838")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float cameraRotateAmount;

		[Token(Token = "0x4000839")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float cameraMoveSpeed;

		[Token(Token = "0x400083A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float cameraRotationSpeed;

		[Token(Token = "0x400083B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public Vector2 cameraAngleLimits;

		[Token(Token = "0x400083C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public GameObject[] levels;

		[Token(Token = "0x400083D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Level currentLevel;

		[Token(Token = "0x400083E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public ParticleMode particleMode;

		[Token(Token = "0x400083F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public bool advancedRendering;

		[Token(Token = "0x4000840")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Toggle loopingParticleModeToggle;

		[Token(Token = "0x4000841")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Toggle oneshotParticleModeToggle;

		[Token(Token = "0x4000842")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public Toggle advancedRenderingToggle;

		[Token(Token = "0x4000843")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Toggle mouseParticlesToggle;

		[Token(Token = "0x4000844")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Toggle[] levelToggles;

		[Token(Token = "0x4000845")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public ToggleGroup levelTogglesContainer;

		[Token(Token = "0x4000846")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private LoopingParticleSystemsManager loopingParticleSystems;

		[Token(Token = "0x4000847")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private OneshotParticleSystemsManager oneshotParticleSystems;

		[Token(Token = "0x4000848")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public GameObject ui;

		[Token(Token = "0x4000849")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public Text particleCountText;

		[Token(Token = "0x400084A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public Text currentParticleSystemText;

		[Token(Token = "0x400084B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public Text particleSpawnInstructionText;

		[Token(Token = "0x400084C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public Slider timeScaleSlider;

		[Token(Token = "0x400084D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public Text timeScaleSliderValueText;

		[Token(Token = "0x400084E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public Camera mainCamera;

		[Token(Token = "0x400084F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public MonoBehaviour[] mainCameraPostEffects;

		[Token(Token = "0x4000850")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Vector3 cameraPositionSmoothDampVelocity;

		[Token(Token = "0x4000851")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		private Vector3 cameraRotationSmoothDampVelocity;

		[Token(Token = "0x600086A")]
		[Address(RVA = "0x2C7E748", Offset = "0x2C7E748", VA = "0x2C7E748")]
		private void Awake()
		{
		}

		[Token(Token = "0x600086B")]
		[Address(RVA = "0x2C7E820", Offset = "0x2C7E820", VA = "0x2C7E820")]
		private void Start()
		{
		}

		[Token(Token = "0x600086C")]
		[Address(RVA = "0x2C7EE08", Offset = "0x2C7EE08", VA = "0x2C7EE08")]
		public void OnTimeScaleSliderValueChanged(float value)
		{
		}

		[Token(Token = "0x600086D")]
		[Address(RVA = "0x2C7EB48", Offset = "0x2C7EB48", VA = "0x2C7EB48")]
		public void SetToLoopingParticleMode(bool set)
		{
		}

		[Token(Token = "0x600086E")]
		[Address(RVA = "0x2C7EBF0", Offset = "0x2C7EBF0", VA = "0x2C7EBF0")]
		public void SetToOneshotParticleMode(bool set)
		{
		}

		[Token(Token = "0x600086F")]
		[Address(RVA = "0x2C7EE9C", Offset = "0x2C7EE9C", VA = "0x2C7EE9C")]
		public void SetLevel(Level level)
		{
		}

		[Token(Token = "0x6000870")]
		[Address(RVA = "0x2C7EF2C", Offset = "0x2C7EF2C", VA = "0x2C7EF2C")]
		public void SetLevelFromToggle(Toggle toggle)
		{
		}

		[Token(Token = "0x6000871")]
		[Address(RVA = "0x2C7EC8C", Offset = "0x2C7EC8C", VA = "0x2C7EC8C")]
		public void SetAdvancedRendering(bool value)
		{
		}

		[Token(Token = "0x6000872")]
		[Address(RVA = "0x2C7EFB4", Offset = "0x2C7EFB4", VA = "0x2C7EFB4")]
		public void SetMouseParticlesRendering(bool value)
		{
		}

		[Token(Token = "0x6000873")]
		[Address(RVA = "0x2C7EFF0", Offset = "0x2C7EFF0", VA = "0x2C7EFF0")]
		public static Vector3 DampVector3(Vector3 from, Vector3 to, float speed, float dt)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000874")]
		[Address(RVA = "0x2C7F06C", Offset = "0x2C7F06C", VA = "0x2C7F06C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000875")]
		[Address(RVA = "0x2C7F5E0", Offset = "0x2C7F5E0", VA = "0x2C7F5E0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000876")]
		[Address(RVA = "0x2C7EB34", Offset = "0x2C7EB34", VA = "0x2C7EB34")]
		private void ResetCameraTransformTargets()
		{
		}

		[Token(Token = "0x6000877")]
		[Address(RVA = "0x2C7ED90", Offset = "0x2C7ED90", VA = "0x2C7ED90")]
		private void UpdateCurrentParticleSystemNameText()
		{
		}

		[Token(Token = "0x6000878")]
		[Address(RVA = "0x2C7F540", Offset = "0x2C7F540", VA = "0x2C7F540")]
		public void Next()
		{
		}

		[Token(Token = "0x6000879")]
		[Address(RVA = "0x2C7F590", Offset = "0x2C7F590", VA = "0x2C7F590")]
		public void Previous()
		{
		}

		[Token(Token = "0x600087A")]
		[Address(RVA = "0x2C7F6F8", Offset = "0x2C7F6F8", VA = "0x2C7F6F8")]
		public DemoManager()
		{
		}
	}
	[Token(Token = "0x2000198")]
	public class FPSDisplay : MonoBehaviour
	{
		[Token(Token = "0x4000858")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float timer;

		[Token(Token = "0x4000859")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float updateTime;

		[Token(Token = "0x400085A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int frameCount;

		[Token(Token = "0x400085B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float fpsAccum;

		[Token(Token = "0x400085C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Text fpsText;

		[Token(Token = "0x600087B")]
		[Address(RVA = "0x2C817B8", Offset = "0x2C817B8", VA = "0x2C817B8")]
		private void Awake()
		{
		}

		[Token(Token = "0x600087C")]
		[Address(RVA = "0x2C817BC", Offset = "0x2C817BC", VA = "0x2C817BC")]
		private void Start()
		{
		}

		[Token(Token = "0x600087D")]
		[Address(RVA = "0x2C81818", Offset = "0x2C81818", VA = "0x2C81818")]
		private void Update()
		{
		}

		[Token(Token = "0x600087E")]
		[Address(RVA = "0x2C8191C", Offset = "0x2C8191C", VA = "0x2C8191C")]
		public FPSDisplay()
		{
		}
	}
	[Token(Token = "0x2000199")]
	public class FPSTest : MonoBehaviour
	{
		[Token(Token = "0x400085D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int targetFPS1;

		[Token(Token = "0x400085E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int targetFPS2;

		[Token(Token = "0x400085F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int previousVSyncCount;

		[Token(Token = "0x600087F")]
		[Address(RVA = "0x2C8192C", Offset = "0x2C8192C", VA = "0x2C8192C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000880")]
		[Address(RVA = "0x2C81930", Offset = "0x2C81930", VA = "0x2C81930")]
		private void Start()
		{
		}

		[Token(Token = "0x6000881")]
		[Address(RVA = "0x2C81934", Offset = "0x2C81934", VA = "0x2C81934")]
		private void Update()
		{
		}

		[Token(Token = "0x6000882")]
		[Address(RVA = "0x2C81A18", Offset = "0x2C81A18", VA = "0x2C81A18")]
		public FPSTest()
		{
		}
	}
	[Token(Token = "0x200019A")]
	public class LoopingParticleSystemsManager : ParticleManager
	{
		[Token(Token = "0x6000883")]
		[Address(RVA = "0x3F63974", Offset = "0x3F63974", VA = "0x3F63974", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000884")]
		[Address(RVA = "0x3F6397C", Offset = "0x3F6397C", VA = "0x3F6397C", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000885")]
		[Address(RVA = "0x3F63A28", Offset = "0x3F63A28", VA = "0x3F63A28", Slot = "6")]
		public override void Next()
		{
		}

		[Token(Token = "0x6000886")]
		[Address(RVA = "0x3F63B34", Offset = "0x3F63B34", VA = "0x3F63B34", Slot = "7")]
		public override void Previous()
		{
		}

		[Token(Token = "0x6000887")]
		[Address(RVA = "0x3F63C40", Offset = "0x3F63C40", VA = "0x3F63C40", Slot = "9")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000888")]
		[Address(RVA = "0x3F63C48", Offset = "0x3F63C48", VA = "0x3F63C48", Slot = "8")]
		public override int GetParticleCount()
		{
			return default(int);
		}

		[Token(Token = "0x6000889")]
		[Address(RVA = "0x3F63D1C", Offset = "0x3F63D1C", VA = "0x3F63D1C")]
		public LoopingParticleSystemsManager()
		{
		}
	}
	[Token(Token = "0x200019B")]
	public class MouseFollow : MonoBehaviour
	{
		[Token(Token = "0x4000860")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float speed;

		[Token(Token = "0x4000861")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float distanceFromCamera;

		[Token(Token = "0x4000862")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool ignoreTimeScale;

		[Token(Token = "0x600088A")]
		[Address(RVA = "0x3F66350", Offset = "0x3F66350", VA = "0x3F66350")]
		private void Awake()
		{
		}

		[Token(Token = "0x600088B")]
		[Address(RVA = "0x3F66354", Offset = "0x3F66354", VA = "0x3F66354")]
		private void Start()
		{
		}

		[Token(Token = "0x600088C")]
		[Address(RVA = "0x3F66358", Offset = "0x3F66358", VA = "0x3F66358")]
		private void Update()
		{
		}

		[Token(Token = "0x600088D")]
		[Address(RVA = "0x3F66470", Offset = "0x3F66470", VA = "0x3F66470")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600088E")]
		[Address(RVA = "0x3F66474", Offset = "0x3F66474", VA = "0x3F66474")]
		public MouseFollow()
		{
		}
	}
	[Token(Token = "0x200019C")]
	public class OneshotParticleSystemsManager : ParticleManager
	{
		[Token(Token = "0x4000863")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public LayerMask mouseRaycastLayerMask;

		[Token(Token = "0x4000864")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<ParticleSystem[]> spawnedPrefabs;

		[Token(Token = "0x4000865")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124FC78", Offset = "0x124FC78")]
		private bool <disableSpawn>k__BackingField;

		[Token(Token = "0x1700009E")]
		public bool disableSpawn
		{
			[Token(Token = "0x600088F")]
			[Address(RVA = "0x3F6B838", Offset = "0x3F6B838", VA = "0x3F6B838")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1252618", Offset = "0x1252618")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000890")]
			[Address(RVA = "0x3F6B840", Offset = "0x3F6B840", VA = "0x3F6B840")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1252628", Offset = "0x1252628")]
			set
			{
			}
		}

		[Token(Token = "0x6000891")]
		[Address(RVA = "0x3F6B84C", Offset = "0x3F6B84C", VA = "0x3F6B84C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000892")]
		[Address(RVA = "0x3F6B854", Offset = "0x3F6B854", VA = "0x3F6B854", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000893")]
		[Address(RVA = "0x3F6B8DC", Offset = "0x3F6B8DC", VA = "0x3F6B8DC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000894")]
		[Address(RVA = "0x3F6B8E0", Offset = "0x3F6B8E0", VA = "0x3F6B8E0")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000895")]
		[Address(RVA = "0x3F6BA70", Offset = "0x3F6BA70", VA = "0x3F6BA70", Slot = "9")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000896")]
		[Address(RVA = "0x3F6BA78", Offset = "0x3F6BA78", VA = "0x3F6BA78")]
		public void InstantiateParticlePrefab(Vector2 mousePosition, float maxDistance)
		{
		}

		[Token(Token = "0x6000897")]
		[Address(RVA = "0x3F6BDC8", Offset = "0x3F6BDC8", VA = "0x3F6BDC8")]
		public void Randomize()
		{
		}

		[Token(Token = "0x6000898")]
		[Address(RVA = "0x3F6BE24", Offset = "0x3F6BE24", VA = "0x3F6BE24", Slot = "8")]
		public override int GetParticleCount()
		{
			return default(int);
		}

		[Token(Token = "0x6000899")]
		[Address(RVA = "0x3F6BFF4", Offset = "0x3F6BFF4", VA = "0x3F6BFF4")]
		public OneshotParticleSystemsManager()
		{
		}
	}
	[Token(Token = "0x200019D")]
	public class ParticleManager : MonoBehaviour
	{
		[Token(Token = "0x4000866")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected List<ParticleSystem[]> particlePrefabs;

		[Token(Token = "0x4000867")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int currentParticlePrefabIndex;

		[Token(Token = "0x4000868")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int prefabNameUnderscoreCountCutoff;

		[Token(Token = "0x4000869")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool disableChildrenAtStart;

		[Token(Token = "0x400086A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		private bool initialized;

		[Token(Token = "0x600089A")]
		[Address(RVA = "0x3F74AF8", Offset = "0x3F74AF8", VA = "0x3F74AF8")]
		public void Init()
		{
		}

		[Token(Token = "0x600089B")]
		[Address(RVA = "0x3F74CD0", Offset = "0x3F74CD0", VA = "0x3F74CD0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600089C")]
		[Address(RVA = "0x3F74CD4", Offset = "0x3F74CD4", VA = "0x3F74CD4", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600089D")]
		[Address(RVA = "0x3F74CE4", Offset = "0x3F74CE4", VA = "0x3F74CE4", Slot = "6")]
		public virtual void Next()
		{
		}

		[Token(Token = "0x600089E")]
		[Address(RVA = "0x3F74D4C", Offset = "0x3F74D4C", VA = "0x3F74D4C", Slot = "7")]
		public virtual void Previous()
		{
		}

		[Token(Token = "0x600089F")]
		[Address(RVA = "0x3F74DB0", Offset = "0x3F74DB0", VA = "0x3F74DB0")]
		public string GetCurrentPrefabName(bool shorten = false)
		{
			return null;
		}

		[Token(Token = "0x60008A0")]
		[Address(RVA = "0x3F75180", Offset = "0x3F75180", VA = "0x3F75180", Slot = "8")]
		public virtual int GetParticleCount()
		{
			return default(int);
		}

		[Token(Token = "0x60008A1")]
		[Address(RVA = "0x3F75188", Offset = "0x3F75188", VA = "0x3F75188", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60008A2")]
		[Address(RVA = "0x3F7518C", Offset = "0x3F7518C", VA = "0x3F7518C")]
		public ParticleManager()
		{
		}
	}
}
namespace MirzaBeig.Demos
{
	[Token(Token = "0x200019E")]
	public class MouseRotateCamera : MonoBehaviour
	{
		[Token(Token = "0x400086B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxRotation;

		[Token(Token = "0x400086C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float speed;

		[Token(Token = "0x400086D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool unscaledTime;

		[Token(Token = "0x60008A3")]
		[Address(RVA = "0x3F66748", Offset = "0x3F66748", VA = "0x3F66748")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008A4")]
		[Address(RVA = "0x3F6674C", Offset = "0x3F6674C", VA = "0x3F6674C")]
		private void Start()
		{
		}

		[Token(Token = "0x60008A5")]
		[Address(RVA = "0x3F66750", Offset = "0x3F66750", VA = "0x3F66750")]
		private void Update()
		{
		}

		[Token(Token = "0x60008A6")]
		[Address(RVA = "0x3F66754", Offset = "0x3F66754", VA = "0x3F66754")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60008A7")]
		[Address(RVA = "0x3F668B0", Offset = "0x3F668B0", VA = "0x3F668B0")]
		public MouseRotateCamera()
		{
		}
	}
}
namespace MirzaBeig.Demos.Wallpapers
{
	[Token(Token = "0x200019F")]
	public class GravityClockInteractivityUVFX : MonoBehaviour
	{
		[Token(Token = "0x400086E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject forceAffectors;

		[Token(Token = "0x400086F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject forceAffectors2;

		[Token(Token = "0x4000870")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ParticleSystem gravityClockPrefab;

		[Token(Token = "0x4000871")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ParticleSystem gravityClock;

		[Token(Token = "0x4000872")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool enableGravityClockVisualEffects;

		[Token(Token = "0x4000873")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool enableGravityClockAttractionForce;

		[Token(Token = "0x60008A8")]
		[Address(RVA = "0x2C86CDC", Offset = "0x2C86CDC", VA = "0x2C86CDC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008A9")]
		[Address(RVA = "0x2C86CE0", Offset = "0x2C86CE0", VA = "0x2C86CE0")]
		private void Start()
		{
		}

		[Token(Token = "0x60008AA")]
		[Address(RVA = "0x2C86CE4", Offset = "0x2C86CE4", VA = "0x2C86CE4")]
		private void Update()
		{
		}

		[Token(Token = "0x60008AB")]
		[Address(RVA = "0x2C86CE8", Offset = "0x2C86CE8", VA = "0x2C86CE8")]
		public void SetGravityClockVisualEffectsActive(bool value)
		{
		}

		[Token(Token = "0x60008AC")]
		[Address(RVA = "0x2C86E58", Offset = "0x2C86E58", VA = "0x2C86E58")]
		public void SetGravityClockAttractionForceActive(bool value)
		{
		}

		[Token(Token = "0x60008AD")]
		[Address(RVA = "0x2C86F08", Offset = "0x2C86F08", VA = "0x2C86F08")]
		public GravityClockInteractivityUVFX()
		{
		}
	}
}
namespace MirzaBeig.Demos.ParticlePlayground
{
	[Token(Token = "0x20001A0")]
	public class BillboardCameraPlaneUVFX : MonoBehaviour
	{
		[Token(Token = "0x4000874")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Transform cameraTransform;

		[Token(Token = "0x60008AE")]
		[Address(RVA = "0x2C794FC", Offset = "0x2C794FC", VA = "0x2C794FC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008AF")]
		[Address(RVA = "0x2C79500", Offset = "0x2C79500", VA = "0x2C79500")]
		private void Start()
		{
		}

		[Token(Token = "0x60008B0")]
		[Address(RVA = "0x2C79540", Offset = "0x2C79540", VA = "0x2C79540")]
		private void Update()
		{
		}

		[Token(Token = "0x60008B1")]
		[Address(RVA = "0x2C79544", Offset = "0x2C79544", VA = "0x2C79544")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60008B2")]
		[Address(RVA = "0x2C7959C", Offset = "0x2C7959C", VA = "0x2C7959C")]
		public BillboardCameraPlaneUVFX()
		{
		}
	}
}
namespace DesignerTool.Comment
{
	[Token(Token = "0x20001A1")]
	public class Comments_Tools : MonoBehaviour
	{
		[Token(Token = "0x60008B3")]
		[Address(RVA = "0x2C7B8C8", Offset = "0x2C7B8C8", VA = "0x2C7B8C8")]
		public static void listChanged(ref List<GameObject> list, int num)
		{
		}

		[Token(Token = "0x60008B4")]
		[Address(RVA = "0x2C7B978", Offset = "0x2C7B978", VA = "0x2C7B978")]
		public static GameObject createGameObject(GameObject obj, Vector3 pos, Quaternion rot)
		{
			return null;
		}

		[Token(Token = "0x60008B5")]
		[Address(RVA = "0x2C7BA48", Offset = "0x2C7BA48", VA = "0x2C7BA48")]
		public Comments_Tools()
		{
		}
	}
	[Token(Token = "0x20001A2")]
	public class Style : MonoBehaviour
	{
		[Token(Token = "0x4000875")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject[] objs;

		[Token(Token = "0x60008B6")]
		[Address(RVA = "0x2B4FA84", Offset = "0x2B4FA84", VA = "0x2B4FA84")]
		public GameObject getRandomGameObject()
		{
			return null;
		}

		[Token(Token = "0x60008B7")]
		[Address(RVA = "0x2B4FAD8", Offset = "0x2B4FAD8", VA = "0x2B4FAD8")]
		public Style()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20001A3")]
	public class row
	{
		[Token(Token = "0x4000876")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public Vector3 initPos;

		[Token(Token = "0x4000877")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[HideInInspector]
		public Vector3 endPos;

		[Token(Token = "0x4000878")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 posOffset;

		[Token(Token = "0x4000879")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float speed;

		[Token(Token = "0x400087A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float Rotation_X;

		[Token(Token = "0x400087B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public List<GameObject> comments;

		[Token(Token = "0x400087C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[HideInInspector]
		public float distToInitPos;

		[Token(Token = "0x400087D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[HideInInspector]
		public float distToEndPos;

		[Token(Token = "0x400087E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[HideInInspector]
		public GameObject waitGameObject;

		[Token(Token = "0x400087F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[HideInInspector]
		public float waitObjLength_X;

		[Token(Token = "0x4000880")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float mat_Transparent;

		[Token(Token = "0x60008B8")]
		[Address(RVA = "0x3107A6C", Offset = "0x3107A6C", VA = "0x3107A6C")]
		public void _start(Style style)
		{
		}

		[Token(Token = "0x60008B9")]
		[Address(RVA = "0x3107C0C", Offset = "0x3107C0C", VA = "0x3107C0C")]
		public void _update()
		{
		}

		[Token(Token = "0x60008BA")]
		[Address(RVA = "0x3107E10", Offset = "0x3107E10", VA = "0x3107E10")]
		public void move()
		{
		}

		[Token(Token = "0x60008BB")]
		[Address(RVA = "0x3107C30", Offset = "0x3107C30", VA = "0x3107C30")]
		public void distanceUpdate()
		{
		}

		[Token(Token = "0x60008BC")]
		[Address(RVA = "0x3107AFC", Offset = "0x3107AFC", VA = "0x3107AFC")]
		public void updateWaitGameObject(Style style)
		{
		}

		[Token(Token = "0x60008BD")]
		[Address(RVA = "0x310802C", Offset = "0x310802C", VA = "0x310802C")]
		public void addUI(Style style, Shader shader, float radius, float gradientMin_X, float gradientMax_X)
		{
		}

		[Token(Token = "0x60008BE")]
		[Address(RVA = "0x3108250", Offset = "0x3108250", VA = "0x3108250")]
		public row()
		{
		}
	}
}
namespace Art
{
	[Token(Token = "0x20001A4")]
	public class CameraClipSetting : MonoBehaviour
	{
		[Token(Token = "0x4000881")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float Near;

		[Token(Token = "0x4000882")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float Far;

		[Token(Token = "0x4000883")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float _oldNear;

		[Token(Token = "0x4000884")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float _oldFar;

		[Token(Token = "0x60008BF")]
		[Address(RVA = "0x2C79CEC", Offset = "0x2C79CEC", VA = "0x2C79CEC")]
		private void Start()
		{
		}

		[Token(Token = "0x60008C0")]
		[Address(RVA = "0x2C79F5C", Offset = "0x2C79F5C", VA = "0x2C79F5C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60008C1")]
		[Address(RVA = "0x2C7A1A8", Offset = "0x2C7A1A8", VA = "0x2C7A1A8")]
		public CameraClipSetting()
		{
		}
	}
	[Token(Token = "0x20001A5")]
	public class GizmoHint : MonoBehaviour
	{
		[Token(Token = "0x20001A6")]
		public enum GizmoType
		{
			[Token(Token = "0x400088B")]
			Sphere,
			[Token(Token = "0x400088C")]
			Cube
		}

		[Token(Token = "0x4000885")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Color GimzoColor;

		[Token(Token = "0x4000886")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Color GimzoSelectColor;

		[Token(Token = "0x4000887")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GizmoType Type;

		[Token(Token = "0x4000888")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float SphereRadius;

		[Token(Token = "0x4000889")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3 CubeSize;

		[Token(Token = "0x60008C2")]
		[Address(RVA = "0x2C85A64", Offset = "0x2C85A64", VA = "0x2C85A64")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x60008C3")]
		[Address(RVA = "0x2C85B34", Offset = "0x2C85B34", VA = "0x2C85B34")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60008C4")]
		[Address(RVA = "0x2C85C04", Offset = "0x2C85C04", VA = "0x2C85C04")]
		public GizmoHint()
		{
		}
	}
	[Token(Token = "0x20001A7")]
	public class NPCAnimRandom : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20001A8")]
		public class TriggerItem
		{
			[Token(Token = "0x4000898")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string Name;

			[Token(Token = "0x4000899")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int Value;

			[Token(Token = "0x400089A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int Weight;

			[NonSerialized]
			[Token(Token = "0x400089B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int Id;

			[NonSerialized]
			[Token(Token = "0x400089C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float Rate;

			[Token(Token = "0x60008CB")]
			[Address(RVA = "0x310DCCC", Offset = "0x310DCCC", VA = "0x310DCCC")]
			public TriggerItem()
			{
			}
		}

		[Token(Token = "0x400088D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Animator Anim;

		[Token(Token = "0x400088E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string MainStateName;

		[Token(Token = "0x400088F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int MainStateId;

		[Token(Token = "0x4000890")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private int DefaultValue;

		[Token(Token = "0x4000891")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector2 WaitRange;

		[Token(Token = "0x4000892")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float _currWaitMax;

		[Token(Token = "0x4000893")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float _currWait;

		[Token(Token = "0x4000894")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TriggerItem[] Items;

		[Token(Token = "0x4000895")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool _preIsMain;

		[Token(Token = "0x4000896")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int _lastId;

		[Token(Token = "0x4000897")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int _lastVal;

		[Token(Token = "0x60008C5")]
		[Address(RVA = "0x3F668C4", Offset = "0x3F668C4", VA = "0x3F668C4")]
		private void Start()
		{
		}

		[Token(Token = "0x60008C6")]
		[Address(RVA = "0x3F669EC", Offset = "0x3F669EC", VA = "0x3F669EC")]
		private void Update()
		{
		}

		[Token(Token = "0x60008C7")]
		[Address(RVA = "0x3F668C8", Offset = "0x3F668C8", VA = "0x3F668C8")]
		private void Init()
		{
		}

		[Token(Token = "0x60008C8")]
		[Address(RVA = "0x3F66A54", Offset = "0x3F66A54", VA = "0x3F66A54")]
		private bool IsInMainState()
		{
			return default(bool);
		}

		[Token(Token = "0x60008C9")]
		[Address(RVA = "0x3F66B38", Offset = "0x3F66B38", VA = "0x3F66B38")]
		private void RandomPlay()
		{
		}

		[Token(Token = "0x60008CA")]
		[Address(RVA = "0x3F66BE0", Offset = "0x3F66BE0", VA = "0x3F66BE0")]
		public NPCAnimRandom()
		{
		}
	}
}
