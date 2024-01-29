using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using CurvedUI;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using Headjack;
using Headjack.Cinema.Messages;
using HeadjackTemplate;
using HeadjackTemplate.Activations;
using HeadjackTemplate.Gaze;
using HeadjackTemplate.Managers.Audio;
using HeadjackTemplate.Managers.UI;
using HeadjackTemplate.UI;
using HeadjackTemplate.UI.Menu.Page;
using HeadjackTemplate.UI.Menu.Page.LogIn;
using HeadjackTemplate.UI.Menu.Page.Projects.Hollywood;
using HeadjackTemplate.UI.Menu.Page.Projects.Hollywood.ProjectVisual;
using HeadjackTemplate.UI.Menu.Page.Video;
using Il2CppDummyDll;
using Internet;
using JetBrains.Annotations;
using LiteNetLib;
using SimpleJSON;
using TBE;
using TMPro;
using TalesFromTheRift;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class CheckInternet : ConnectionWhile
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private bool debug;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	[SerializeField]
	private bool connected;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject _internetRequired;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x82A918", Offset = "0x82A918", VA = "0x82A918", Slot = "4")]
	protected override void OnInternetConnection(NetStatus connection)
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x82AA90", Offset = "0x82AA90", VA = "0x82AA90")]
	public CheckInternet()
	{
	}
}
[Token(Token = "0x2000003")]
public class ImageHighlight : MonoBehaviour
{
	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Image targetHighlight;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private SpriteRenderer targetRenderer;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Sequence highlightSequence;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private bool _spriteRenderer;

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x7CB408", Offset = "0x7CB408", VA = "0x7CB408")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x7CB484", Offset = "0x7CB484", VA = "0x7CB484")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x7CB4E0", Offset = "0x7CB4E0", VA = "0x7CB4E0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x7CB544", Offset = "0x7CB544", VA = "0x7CB544")]
	private void HighLight()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x7CB6B4", Offset = "0x7CB6B4", VA = "0x7CB6B4")]
	public ImageHighlight()
	{
	}
}
[Token(Token = "0x2000004")]
public class OculusGoController : MonoBehaviour
{
	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject oculus_menuButton;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static OculusGoController Instance;

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x7D0AA4", Offset = "0x7D0AA4", VA = "0x7D0AA4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x7D0AF8", Offset = "0x7D0AF8", VA = "0x7D0AF8")]
	public void ShowMenuButtonHighlight()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x7D0B48", Offset = "0x7D0B48", VA = "0x7D0B48")]
	public void HideMenuButtonHighlight()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x7D0B98", Offset = "0x7D0B98", VA = "0x7D0B98")]
	public OculusGoController()
	{
	}
}
[Token(Token = "0x2000005")]
public class SimpleSceneLoader : MonoBehaviour
{
	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5FB954", Offset = "0x5FB954")]
	[SerializeField]
	private int targetSceneIndex;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private string targetSceneName;

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x7E59FC", Offset = "0x7E59FC", VA = "0x7E59FC")]
	public void LoadScene()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x7E5B08", Offset = "0x7E5B08", VA = "0x7E5B08")]
	public SimpleSceneLoader()
	{
	}
}
[Token(Token = "0x2000006")]
public class TestDiskUtils : MonoBehaviour
{
	[Token(Token = "0x200013B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FAFC4", Offset = "0x5FAFC4")]
	private sealed class <Tests>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400062A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TestDiskUtils <>4__this;

		[Token(Token = "0x170000B8")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60008BF")]
			[Address(RVA = "0x7E9F1C", Offset = "0x7E9F1C", VA = "0x7E9F1C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B9")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60008C1")]
			[Address(RVA = "0x7E9F84", Offset = "0x7E9F84", VA = "0x7E9F84", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008BC")]
		[Address(RVA = "0x7E9CE8", Offset = "0x7E9CE8", VA = "0x7E9CE8")]
		[DebuggerHidden]
		public <Tests>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x60008BD")]
		[Address(RVA = "0x7E9D6C", Offset = "0x7E9D6C", VA = "0x7E9D6C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60008BE")]
		[Address(RVA = "0x7E9D70", Offset = "0x7E9D70", VA = "0x7E9D70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60008C0")]
		[Address(RVA = "0x7E9F24", Offset = "0x7E9F24", VA = "0x7E9F24", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private TextMesh text;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private string obj;

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x7E9974", Offset = "0x7E9974", VA = "0x7E9974")]
	private void PrintDebug(string str)
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x7E9A54", Offset = "0x7E9A54", VA = "0x7E9A54")]
	private void PrintDebugLn(string str = "")
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x7E9AC0", Offset = "0x7E9AC0", VA = "0x7E9AC0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x7E9BB0", Offset = "0x7E9BB0", VA = "0x7E9BB0")]
	private void PrintStorageStats()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x7E9B40", Offset = "0x7E9B40", VA = "0x7E9B40")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5FD744", Offset = "0x5FD744")]
	private IEnumerator Tests()
	{
		return null;
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x7E9D14", Offset = "0x7E9D14", VA = "0x7E9D14")]
	public TestDiskUtils()
	{
	}
}
[Token(Token = "0x2000007")]
public class TextMover : MonoBehaviour
{
	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float speed;

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x7EAAD8", Offset = "0x7EAAD8", VA = "0x7EAAD8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x7EAC2C", Offset = "0x7EAC2C", VA = "0x7EAC2C")]
	private void GetMobile(out float h, out float v)
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x7EACE8", Offset = "0x7EACE8", VA = "0x7EACE8")]
	private void GetDesktop(out float h, out float v)
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x7EAD64", Offset = "0x7EAD64", VA = "0x7EAD64")]
	public TextMover()
	{
	}
}
[Token(Token = "0x2000008")]
internal enum IsolatedArabicLetters
{
	[Token(Token = "0x4000010")]
	Hamza = 65152,
	[Token(Token = "0x4000011")]
	Alef = 65165,
	[Token(Token = "0x4000012")]
	AlefHamza = 65155,
	[Token(Token = "0x4000013")]
	WawHamza = 65157,
	[Token(Token = "0x4000014")]
	AlefMaksoor = 65159,
	[Token(Token = "0x4000015")]
	AlefMaksora = 64508,
	[Token(Token = "0x4000016")]
	HamzaNabera = 65161,
	[Token(Token = "0x4000017")]
	Ba = 65167,
	[Token(Token = "0x4000018")]
	Ta = 65173,
	[Token(Token = "0x4000019")]
	Tha2 = 65177,
	[Token(Token = "0x400001A")]
	Jeem = 65181,
	[Token(Token = "0x400001B")]
	H7aa = 65185,
	[Token(Token = "0x400001C")]
	Khaa2 = 65189,
	[Token(Token = "0x400001D")]
	Dal = 65193,
	[Token(Token = "0x400001E")]
	Thal = 65195,
	[Token(Token = "0x400001F")]
	Ra2 = 65197,
	[Token(Token = "0x4000020")]
	Zeen = 65199,
	[Token(Token = "0x4000021")]
	Seen = 65201,
	[Token(Token = "0x4000022")]
	Sheen = 65205,
	[Token(Token = "0x4000023")]
	S9a = 65209,
	[Token(Token = "0x4000024")]
	Dha = 65213,
	[Token(Token = "0x4000025")]
	T6a = 65217,
	[Token(Token = "0x4000026")]
	T6ha = 65221,
	[Token(Token = "0x4000027")]
	Ain = 65225,
	[Token(Token = "0x4000028")]
	Gain = 65229,
	[Token(Token = "0x4000029")]
	Fa = 65233,
	[Token(Token = "0x400002A")]
	Gaf = 65237,
	[Token(Token = "0x400002B")]
	Kaf = 65241,
	[Token(Token = "0x400002C")]
	Lam = 65245,
	[Token(Token = "0x400002D")]
	Meem = 65249,
	[Token(Token = "0x400002E")]
	Noon = 65253,
	[Token(Token = "0x400002F")]
	Ha = 65257,
	[Token(Token = "0x4000030")]
	Waw = 65261,
	[Token(Token = "0x4000031")]
	Ya = 65265,
	[Token(Token = "0x4000032")]
	AlefMad = 65153,
	[Token(Token = "0x4000033")]
	TaMarboota = 65171,
	[Token(Token = "0x4000034")]
	PersianPe = 64342,
	[Token(Token = "0x4000035")]
	PersianChe = 64378,
	[Token(Token = "0x4000036")]
	PersianZe = 64394,
	[Token(Token = "0x4000037")]
	PersianGaf = 64402,
	[Token(Token = "0x4000038")]
	PersianGaf2 = 64398,
	[Token(Token = "0x4000039")]
	PersianYeh = 64508
}
[Token(Token = "0x2000009")]
internal enum GeneralArabicLetters
{
	[Token(Token = "0x400003B")]
	Hamza = 1569,
	[Token(Token = "0x400003C")]
	Alef = 1575,
	[Token(Token = "0x400003D")]
	AlefHamza = 1571,
	[Token(Token = "0x400003E")]
	WawHamza = 1572,
	[Token(Token = "0x400003F")]
	AlefMaksoor = 1573,
	[Token(Token = "0x4000040")]
	AlefMagsora = 1609,
	[Token(Token = "0x4000041")]
	HamzaNabera = 1574,
	[Token(Token = "0x4000042")]
	Ba = 1576,
	[Token(Token = "0x4000043")]
	Ta = 1578,
	[Token(Token = "0x4000044")]
	Tha2 = 1579,
	[Token(Token = "0x4000045")]
	Jeem = 1580,
	[Token(Token = "0x4000046")]
	H7aa = 1581,
	[Token(Token = "0x4000047")]
	Khaa2 = 1582,
	[Token(Token = "0x4000048")]
	Dal = 1583,
	[Token(Token = "0x4000049")]
	Thal = 1584,
	[Token(Token = "0x400004A")]
	Ra2 = 1585,
	[Token(Token = "0x400004B")]
	Zeen = 1586,
	[Token(Token = "0x400004C")]
	Seen = 1587,
	[Token(Token = "0x400004D")]
	Sheen = 1588,
	[Token(Token = "0x400004E")]
	S9a = 1589,
	[Token(Token = "0x400004F")]
	Dha = 1590,
	[Token(Token = "0x4000050")]
	T6a = 1591,
	[Token(Token = "0x4000051")]
	T6ha = 1592,
	[Token(Token = "0x4000052")]
	Ain = 1593,
	[Token(Token = "0x4000053")]
	Gain = 1594,
	[Token(Token = "0x4000054")]
	Fa = 1601,
	[Token(Token = "0x4000055")]
	Gaf = 1602,
	[Token(Token = "0x4000056")]
	Kaf = 1603,
	[Token(Token = "0x4000057")]
	Lam = 1604,
	[Token(Token = "0x4000058")]
	Meem = 1605,
	[Token(Token = "0x4000059")]
	Noon = 1606,
	[Token(Token = "0x400005A")]
	Ha = 1607,
	[Token(Token = "0x400005B")]
	Waw = 1608,
	[Token(Token = "0x400005C")]
	Ya = 1610,
	[Token(Token = "0x400005D")]
	AlefMad = 1570,
	[Token(Token = "0x400005E")]
	TaMarboota = 1577,
	[Token(Token = "0x400005F")]
	PersianPe = 1662,
	[Token(Token = "0x4000060")]
	PersianChe = 1670,
	[Token(Token = "0x4000061")]
	PersianZe = 1688,
	[Token(Token = "0x4000062")]
	PersianGaf = 1711,
	[Token(Token = "0x4000063")]
	PersianGaf2 = 1705,
	[Token(Token = "0x4000064")]
	PersianYeh = 1740
}
[Token(Token = "0x200000A")]
internal class ArabicMapping
{
	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int from;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int to;

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x827358", Offset = "0x827358", VA = "0x827358")]
	public ArabicMapping(int from, int to)
	{
	}
}
[Token(Token = "0x200000B")]
internal class ArabicTable
{
	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static List<ArabicMapping> mapList;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static ArabicTable arabicMapper;

	[Token(Token = "0x17000001")]
	internal static ArabicTable ArabicMapper
	{
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x826378", Offset = "0x826378", VA = "0x826378")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x827670", Offset = "0x827670", VA = "0x827670")]
	private ArabicTable()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x8263F0", Offset = "0x8263F0", VA = "0x8263F0")]
	internal int Convert(int toBeConverted)
	{
		return default(int);
	}
}
[Token(Token = "0x200000C")]
internal class TashkeelLocation
{
	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public char tashkeel;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int position;

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x7E9938", Offset = "0x7E9938", VA = "0x7E9938")]
	public TashkeelLocation(char tashkeel, int position)
	{
	}
}
[Token(Token = "0x200000D")]
internal class ArabicFixerTool
{
	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	internal static bool showTashkeel;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
	internal static bool combineTashkeel;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
	internal static bool useHinduNumbers;

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x824E18", Offset = "0x824E18", VA = "0x824E18")]
	internal static string RemoveTashkeel(string str, out List<TashkeelLocation> tashkeelLocation)
	{
		return null;
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x825478", Offset = "0x825478", VA = "0x825478")]
	internal static char[] ReturnTashkeel(char[] letters, List<TashkeelLocation> tashkeelLocation)
	{
		return null;
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x825674", Offset = "0x825674", VA = "0x825674")]
	internal static string FixLine(string str)
	{
		return null;
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x8264FC", Offset = "0x8264FC", VA = "0x8264FC")]
	internal static bool IsIgnoredCharacter(char ch)
	{
		return default(bool);
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x826B94", Offset = "0x826B94", VA = "0x826B94")]
	internal static bool IsLeadingLetter(char[] letters, int index)
	{
		return default(bool);
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x8269F8", Offset = "0x8269F8", VA = "0x8269F8")]
	internal static bool IsFinishingLetter(char[] letters, int index)
	{
		return default(bool);
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x826678", Offset = "0x826678", VA = "0x826678")]
	internal static bool IsMiddleLetter(char[] letters, int index)
	{
		return default(bool);
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x826ED0", Offset = "0x826ED0", VA = "0x826ED0")]
	public ArabicFixerTool()
	{
	}
}
[Token(Token = "0x200000E")]
public class CUI_CameraRotationOnButtonHeld : MonoBehaviour
{
	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float Sensitivity;

	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private Vector3 oldMousePos;

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool move;

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x828AB4", Offset = "0x828AB4", VA = "0x828AB4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x828AE0", Offset = "0x828AE0", VA = "0x828AE0")]
	public CUI_CameraRotationOnButtonHeld()
	{
	}
}
[Token(Token = "0x200000F")]
public class CUI_MoveAlong : MonoBehaviour
{
	[Token(Token = "0x6000028")]
	[Address(RVA = "0x828AF8", Offset = "0x828AF8", VA = "0x828AF8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x828AFC", Offset = "0x828AFC", VA = "0x828AFC")]
	private void Update()
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x828D50", Offset = "0x828D50", VA = "0x828D50")]
	public CUI_MoveAlong()
	{
	}
}
[Token(Token = "0x2000010")]
public class CUI_MoveHeartbeat : MonoBehaviour
{
	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float speed;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool wrapAroundParent;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private RectTransform rectie;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private RectTransform parentRectie;

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x828D58", Offset = "0x828D58", VA = "0x828D58")]
	private void Start()
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x828E10", Offset = "0x828E10", VA = "0x828E10")]
	private void Update()
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x828F5C", Offset = "0x828F5C", VA = "0x828F5C")]
	public CUI_MoveHeartbeat()
	{
	}
}
[Token(Token = "0x2000011")]
public class CUI_ShowParentCoordinates : MonoBehaviour
{
	[Token(Token = "0x600002E")]
	[Address(RVA = "0x828F6C", Offset = "0x828F6C", VA = "0x828F6C")]
	private void Start()
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x829038", Offset = "0x829038", VA = "0x829038")]
	private void Update()
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x82903C", Offset = "0x82903C", VA = "0x82903C")]
	public CUI_ShowParentCoordinates()
	{
	}
}
[Token(Token = "0x2000012")]
public class CUI_rotation_anim : MonoBehaviour
{
	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 Rotation;

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x829044", Offset = "0x829044", VA = "0x829044")]
	private void Start()
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x829048", Offset = "0x829048", VA = "0x829048")]
	private void Update()
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x829230", Offset = "0x829230", VA = "0x829230")]
	public CUI_rotation_anim()
	{
	}
}
[Token(Token = "0x2000013")]
public class CUI_touchpad : MonoBehaviour
{
	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private RectTransform container;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private RectTransform dot;

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x829238", Offset = "0x829238", VA = "0x829238")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x8292AC", Offset = "0x8292AC", VA = "0x8292AC")]
	private void MoveDotOnTouchpadAxisChanged(object o, ViveInputArgs args)
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x829388", Offset = "0x829388", VA = "0x829388")]
	public CUI_touchpad()
	{
	}
}
[Token(Token = "0x2000014")]
[ExecuteInEditMode]
public class CurvedUIInputModule : StandaloneInputModule
{
	[Token(Token = "0x200013C")]
	public enum CUIControlMethod
	{
		[Token(Token = "0x400062C")]
		MOUSE = 0,
		[Token(Token = "0x400062D")]
		GAZE = 1,
		[Token(Token = "0x400062E")]
		WORLD_MOUSE = 2,
		[Token(Token = "0x400062F")]
		CUSTOM_RAY = 3,
		[Token(Token = "0x4000630")]
		STEAMVR_LEGACY = 4,
		[Token(Token = "0x4000631")]
		OCULUSVR = 5,
		[Token(Token = "0x4000632")]
		GOOGLEVR = 7,
		[Token(Token = "0x4000633")]
		STEAMVR_2 = 8
	}

	[Token(Token = "0x200013D")]
	public enum Hand
	{
		[Token(Token = "0x4000635")]
		Both,
		[Token(Token = "0x4000636")]
		Right,
		[Token(Token = "0x4000637")]
		Left
	}

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	[SerializeField]
	private CUIControlMethod controlMethod;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	[SerializeField]
	private string submitButtonName;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private bool gazeUseTimedClick;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	[SerializeField]
	private float gazeClickTimer;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	[SerializeField]
	private float gazeClickTimerDelay;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private Image gazeTimedClickProgressImage;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	[SerializeField]
	private float worldSpaceMouseSensitivity;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	[SerializeField]
	private Hand usedHand;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	[SerializeField]
	private Transform controllerTransformOverride;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static bool disableOtherInputModulesOnStart;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static CurvedUIInputModule instance;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private GameObject currentDragging;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private GameObject currentPointedAt;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private GameObject m_rightController;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private GameObject m_leftController;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private float gazeTimerProgress;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
	private Ray customControllerRay;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
	private float dragThreshold;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private bool pressedDown;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x129")]
	private bool pressedLastFrame;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
	private Vector3 lastMouseOnScreenPos;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private Vector2 worldSpaceMouseInCanvasSpace;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private Vector2 lastWorldSpaceMouseOnCanvas;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private Vector2 worldSpaceMouseOnCanvasDelta;

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private PointerEventData pointerData;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private Vector2 lastPose;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static bool forceGaze;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private static Vector2 sphericalCoordinatesResult;

	[Token(Token = "0x17000002")]
	public static CurvedUIInputModule Instance
	{
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x8A6A48", Offset = "0x8A6A48", VA = "0x8A6A48")]
		get
		{
			return null;
		}
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x8B8E34", Offset = "0x8B8E34", VA = "0x8B8E34")]
		private set
		{
		}
	}

	[Token(Token = "0x17000003")]
	public static CUIControlMethod ControlMethod
	{
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x8A69DC", Offset = "0x8A69DC", VA = "0x8A69DC")]
		get
		{
			return default(CUIControlMethod);
		}
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x8B0760", Offset = "0x8B0760", VA = "0x8B0760")]
		set
		{
		}
	}

	[Token(Token = "0x17000004")]
	public Hand UsedHand
	{
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x8B8EA0", Offset = "0x8B8EA0", VA = "0x8B8EA0")]
		get
		{
			return default(Hand);
		}
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x8B8EA8", Offset = "0x8B8EA8", VA = "0x8B8EA8")]
		set
		{
		}
	}

	[Token(Token = "0x17000005")]
	public Transform ControllerTransform
	{
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x8B8EB0", Offset = "0x8B8EB0", VA = "0x8B8EB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000006")]
	public Vector3 ControllerPointingDirection
	{
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x8A8368", Offset = "0x8A8368", VA = "0x8A8368")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x17000007")]
	public Vector3 ControllerPointingOrigin
	{
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x8A82D4", Offset = "0x8A82D4", VA = "0x8A82D4")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x17000008")]
	public Transform ControllerTransformOverride
	{
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x8B8F70", Offset = "0x8B8F70", VA = "0x8B8F70")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x8B8FE4", Offset = "0x8B8FE4", VA = "0x8B8FE4")]
		set
		{
		}
	}

	[Token(Token = "0x17000009")]
	public GameObject CurrentPointedAt
	{
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x8B905C", Offset = "0x8B905C", VA = "0x8B905C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000A")]
	public static Ray CustomControllerRay
	{
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x8A83FC", Offset = "0x8A83FC", VA = "0x8A83FC")]
		get
		{
			return default(Ray);
		}
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x8B9064", Offset = "0x8B9064", VA = "0x8B9064")]
		set
		{
		}
	}

	[Token(Token = "0x1700000B")]
	public static bool CustomControllerButtonState
	{
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x8B9100", Offset = "0x8B9100", VA = "0x8B9100")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x8B916C", Offset = "0x8B916C", VA = "0x8B916C")]
		set
		{
		}
	}

	[Token(Token = "0x1700000C")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x6008D0", Offset = "0x6008D0")]
	public static bool CustomControllerButtonDown
	{
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x8B91E0", Offset = "0x8B91E0", VA = "0x8B91E0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x8B924C", Offset = "0x8B924C", VA = "0x8B924C")]
		set
		{
		}
	}

	[Token(Token = "0x1700000D")]
	public Vector2 WorldSpaceMouseInCanvasSpace
	{
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x8B92C0", Offset = "0x8B92C0", VA = "0x8B92C0")]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x8B92CC", Offset = "0x8B92CC", VA = "0x8B92CC")]
		set
		{
		}
	}

	[Token(Token = "0x1700000E")]
	public Vector2 WorldSpaceMouseInCanvasSpaceDelta
	{
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x8B92E0", Offset = "0x8B92E0", VA = "0x8B92E0")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x1700000F")]
	public float WorldSpaceMouseSensitivity
	{
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x8B9374", Offset = "0x8B9374", VA = "0x8B9374")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x8B937C", Offset = "0x8B937C", VA = "0x8B937C")]
		set
		{
		}
	}

	[Token(Token = "0x17000010")]
	public bool GazeUseTimedClick
	{
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x8B9384", Offset = "0x8B9384", VA = "0x8B9384")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x8B938C", Offset = "0x8B938C", VA = "0x8B938C")]
		set
		{
		}
	}

	[Token(Token = "0x17000011")]
	public float GazeClickTimer
	{
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x8B9398", Offset = "0x8B9398", VA = "0x8B9398")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x8B0CFC", Offset = "0x8B0CFC", VA = "0x8B0CFC")]
		set
		{
		}
	}

	[Token(Token = "0x17000012")]
	public float GazeClickTimerDelay
	{
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x8B93A0", Offset = "0x8B93A0", VA = "0x8B93A0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x8B0E60", Offset = "0x8B0E60", VA = "0x8B0E60")]
		set
		{
		}
	}

	[Token(Token = "0x17000013")]
	public float GazeTimerProgress
	{
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x8B93A8", Offset = "0x8B93A8", VA = "0x8B93A8")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000014")]
	public Image GazeTimedClickProgressImage
	{
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x8B93B0", Offset = "0x8B93B0", VA = "0x8B93B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x8B93B8", Offset = "0x8B93B8", VA = "0x8B93B8")]
		set
		{
		}
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x8B6DD8", Offset = "0x8B6DD8", VA = "0x8B6DD8", Slot = "4")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x8B6EFC", Offset = "0x8B6EFC", VA = "0x8B6EFC", Slot = "31")]
	protected virtual void Update()
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x8B70C4", Offset = "0x8B70C4", VA = "0x8B70C4")]
	protected void LateUpdate()
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x8B70D0", Offset = "0x8B70D0", VA = "0x8B70D0", Slot = "6")]
	protected override void Start()
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x8B710C", Offset = "0x8B710C", VA = "0x8B710C", Slot = "17")]
	public override void Process()
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x8B8744", Offset = "0x8B8744", VA = "0x8B8744")]
	private void HandlePendingClick()
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x8B8460", Offset = "0x8B8460", VA = "0x8B8460")]
	private void HandleTriggerDown()
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x8B8A68", Offset = "0x8B8A68", VA = "0x8B8A68")]
	private static bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold)
	{
		return default(bool);
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x8B80B0", Offset = "0x8B80B0", VA = "0x8B80B0")]
	private void HandleDrag()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x8B7F00", Offset = "0x8B7F00", VA = "0x8B7F00")]
	private void UpdateCurrentObject(GameObject previousObject)
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x8B8B38", Offset = "0x8B8B38", VA = "0x8B8B38")]
	public static Vector2 NormalizedCartesianToSpherical(Vector3 cartCoords)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x8B74D8", Offset = "0x8B74D8", VA = "0x8B74D8")]
	private void CastRay()
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x8B74C0", Offset = "0x8B74C0", VA = "0x8B74C0")]
	private GameObject GetCurrentGameObject()
	{
		return null;
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x8B8C70", Offset = "0x8B8C70", VA = "0x8B8C70", Slot = "32")]
	protected virtual void ProcessGaze()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x8B8CD8", Offset = "0x8B8CD8", VA = "0x8B8CD8", Slot = "33")]
	protected virtual void ProcessCustomRayController()
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x8B8CE0", Offset = "0x8B8CE0", VA = "0x8B8CE0", Slot = "27")]
	protected override MouseState GetMousePointerEventData(int id)
	{
		return null;
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x8B8E00", Offset = "0x8B8E00", VA = "0x8B8E00")]
	private PointerEventData.FramePressState CustomRayFramePressedState()
	{
		return default(PointerEventData.FramePressState);
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x8B8E2C", Offset = "0x8B8E2C", VA = "0x8B8E2C", Slot = "34")]
	protected virtual void ProcessViveControllers()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x8B8E30", Offset = "0x8B8E30", VA = "0x8B8E30", Slot = "35")]
	protected virtual void ProcessOculusVRController()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x8B8A64", Offset = "0x8B8A64", VA = "0x8B8A64")]
	private void ProcessSteamVR2Controllers()
	{
	}

	[Token(Token = "0x600004B")]
	private static T EnableInputModule<T>() where T : BaseInputModule
	{
		return null;
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x8B93C0", Offset = "0x8B93C0", VA = "0x8B93C0")]
	public CurvedUIInputModule()
	{
	}
}
[Token(Token = "0x2000015")]
[ExecuteInEditMode]
public class CurvedUIInputModuleVideo : StandaloneInputModule
{
	[Token(Token = "0x200013E")]
	public enum CUIControlMethod
	{
		[Token(Token = "0x4000639")]
		MOUSE = 0,
		[Token(Token = "0x400063A")]
		GAZE = 1,
		[Token(Token = "0x400063B")]
		WORLD_MOUSE = 2,
		[Token(Token = "0x400063C")]
		CUSTOM_RAY = 3,
		[Token(Token = "0x400063D")]
		STEAMVR_LEGACY = 4,
		[Token(Token = "0x400063E")]
		OCULUSVR = 5,
		[Token(Token = "0x400063F")]
		GOOGLEVR = 7,
		[Token(Token = "0x4000640")]
		STEAMVR_2 = 8
	}

	[Token(Token = "0x200013F")]
	public enum Hand
	{
		[Token(Token = "0x4000642")]
		Both,
		[Token(Token = "0x4000643")]
		Right,
		[Token(Token = "0x4000644")]
		Left
	}

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	[SerializeField]
	private CUIControlMethod controlMethod;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	[SerializeField]
	private string submitButtonName;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private bool gazeUseTimedClick;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	[SerializeField]
	private float gazeClickTimer;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	[SerializeField]
	private float gazeClickTimerDelay;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private Image gazeTimedClickProgressImage;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	[SerializeField]
	private float worldSpaceMouseSensitivity;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	[SerializeField]
	private Hand usedHand;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	[SerializeField]
	private Transform controllerTransformOverride;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static bool disableOtherInputModulesOnStart;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static CurvedUIInputModuleVideo instance;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private GameObject currentDragging;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private GameObject currentPointedAt;

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private GameObject m_rightController;

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private GameObject m_leftController;

	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private float gazeTimerProgress;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
	private Ray customControllerRay;

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
	private float dragThreshold;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private bool pressedDown;

	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x129")]
	private bool pressedLastFrame;

	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
	private Vector3 lastMouseOnScreenPos;

	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private Vector2 worldSpaceMouseInCanvasSpace;

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private Vector2 lastWorldSpaceMouseOnCanvas;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private Vector2 worldSpaceMouseOnCanvasDelta;

	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private PointerEventData pointerData;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private Vector2 lastPose;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static bool forceGaze;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private static Vector2 sphericalCoordinatesResult;

	[Token(Token = "0x17000015")]
	public static CurvedUIInputModuleVideo Instance
	{
		[Token(Token = "0x6000083")]
		[Address(RVA = "0x8BB4CC", Offset = "0x8BB4CC", VA = "0x8BB4CC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000084")]
		[Address(RVA = "0x8BB5C8", Offset = "0x8BB5C8", VA = "0x8BB5C8")]
		private set
		{
		}
	}

	[Token(Token = "0x17000016")]
	public static CUIControlMethod ControlMethod
	{
		[Token(Token = "0x6000085")]
		[Address(RVA = "0x8BB42C", Offset = "0x8BB42C", VA = "0x8BB42C")]
		get
		{
			return default(CUIControlMethod);
		}
		[Token(Token = "0x6000086")]
		[Address(RVA = "0x8BB634", Offset = "0x8BB634", VA = "0x8BB634")]
		set
		{
		}
	}

	[Token(Token = "0x17000017")]
	public Hand UsedHand
	{
		[Token(Token = "0x6000087")]
		[Address(RVA = "0x8BB6D0", Offset = "0x8BB6D0", VA = "0x8BB6D0")]
		get
		{
			return default(Hand);
		}
		[Token(Token = "0x6000088")]
		[Address(RVA = "0x8BB6D8", Offset = "0x8BB6D8", VA = "0x8BB6D8")]
		set
		{
		}
	}

	[Token(Token = "0x17000018")]
	public Transform ControllerTransform
	{
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x8BB6E0", Offset = "0x8BB6E0", VA = "0x8BB6E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000019")]
	public Vector3 ControllerPointingDirection
	{
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x8BB814", Offset = "0x8BB814", VA = "0x8BB814")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x1700001A")]
	public Vector3 ControllerPointingOrigin
	{
		[Token(Token = "0x600008B")]
		[Address(RVA = "0x8BB8A8", Offset = "0x8BB8A8", VA = "0x8BB8A8")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x1700001B")]
	public Transform ControllerTransformOverride
	{
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x8BB7A0", Offset = "0x8BB7A0", VA = "0x8BB7A0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600008D")]
		[Address(RVA = "0x8BB93C", Offset = "0x8BB93C", VA = "0x8BB93C")]
		set
		{
		}
	}

	[Token(Token = "0x1700001C")]
	public GameObject CurrentPointedAt
	{
		[Token(Token = "0x600008E")]
		[Address(RVA = "0x8BB9B4", Offset = "0x8BB9B4", VA = "0x8BB9B4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700001D")]
	public static Ray CustomControllerRay
	{
		[Token(Token = "0x600008F")]
		[Address(RVA = "0x8BB9BC", Offset = "0x8BB9BC", VA = "0x8BB9BC")]
		get
		{
			return default(Ray);
		}
		[Token(Token = "0x6000090")]
		[Address(RVA = "0x8BBA40", Offset = "0x8BBA40", VA = "0x8BBA40")]
		set
		{
		}
	}

	[Token(Token = "0x1700001E")]
	public static bool CustomControllerButtonState
	{
		[Token(Token = "0x6000091")]
		[Address(RVA = "0x8BBADC", Offset = "0x8BBADC", VA = "0x8BBADC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x8BBB48", Offset = "0x8BBB48", VA = "0x8BBB48")]
		set
		{
		}
	}

	[Token(Token = "0x1700001F")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x600908", Offset = "0x600908")]
	public static bool CustomControllerButtonDown
	{
		[Token(Token = "0x6000093")]
		[Address(RVA = "0x8BBBBC", Offset = "0x8BBBBC", VA = "0x8BBBBC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000094")]
		[Address(RVA = "0x8BBC28", Offset = "0x8BBC28", VA = "0x8BBC28")]
		set
		{
		}
	}

	[Token(Token = "0x17000020")]
	public Vector2 WorldSpaceMouseInCanvasSpace
	{
		[Token(Token = "0x6000095")]
		[Address(RVA = "0x8BBC9C", Offset = "0x8BBC9C", VA = "0x8BBC9C")]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x6000096")]
		[Address(RVA = "0x8BBCA8", Offset = "0x8BBCA8", VA = "0x8BBCA8")]
		set
		{
		}
	}

	[Token(Token = "0x17000021")]
	public Vector2 WorldSpaceMouseInCanvasSpaceDelta
	{
		[Token(Token = "0x6000097")]
		[Address(RVA = "0x8BBCBC", Offset = "0x8BBCBC", VA = "0x8BBCBC")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x17000022")]
	public float WorldSpaceMouseSensitivity
	{
		[Token(Token = "0x6000098")]
		[Address(RVA = "0x8BBD50", Offset = "0x8BBD50", VA = "0x8BBD50")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000099")]
		[Address(RVA = "0x8BBD58", Offset = "0x8BBD58", VA = "0x8BBD58")]
		set
		{
		}
	}

	[Token(Token = "0x17000023")]
	public bool GazeUseTimedClick
	{
		[Token(Token = "0x600009A")]
		[Address(RVA = "0x8BBD60", Offset = "0x8BBD60", VA = "0x8BBD60")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600009B")]
		[Address(RVA = "0x8BBD68", Offset = "0x8BBD68", VA = "0x8BBD68")]
		set
		{
		}
	}

	[Token(Token = "0x17000024")]
	public float GazeClickTimer
	{
		[Token(Token = "0x600009C")]
		[Address(RVA = "0x8BBD74", Offset = "0x8BBD74", VA = "0x8BBD74")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600009D")]
		[Address(RVA = "0x8BBD7C", Offset = "0x8BBD7C", VA = "0x8BBD7C")]
		set
		{
		}
	}

	[Token(Token = "0x17000025")]
	public float GazeClickTimerDelay
	{
		[Token(Token = "0x600009E")]
		[Address(RVA = "0x8BBDFC", Offset = "0x8BBDFC", VA = "0x8BBDFC")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x8BBE04", Offset = "0x8BBE04", VA = "0x8BBE04")]
		set
		{
		}
	}

	[Token(Token = "0x17000026")]
	public float GazeTimerProgress
	{
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x8BBE84", Offset = "0x8BBE84", VA = "0x8BBE84")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000027")]
	public Image GazeTimedClickProgressImage
	{
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x8BBE8C", Offset = "0x8BBE8C", VA = "0x8BBE8C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x8BBE94", Offset = "0x8BBE94", VA = "0x8BBE94")]
		set
		{
		}
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x8B9504", Offset = "0x8B9504", VA = "0x8B9504", Slot = "4")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x8B9628", Offset = "0x8B9628", VA = "0x8B9628", Slot = "31")]
	protected virtual void Update()
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x8B97F0", Offset = "0x8B97F0", VA = "0x8B97F0")]
	protected void LateUpdate()
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x8B97FC", Offset = "0x8B97FC", VA = "0x8B97FC", Slot = "6")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x8B9838", Offset = "0x8B9838", VA = "0x8B9838", Slot = "17")]
	public override void Process()
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x8B9AF0", Offset = "0x8B9AF0", VA = "0x8B9AF0")]
	private void HandlePendingClick()
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x8B9E10", Offset = "0x8B9E10", VA = "0x8B9E10")]
	private void HandleTriggerDown()
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x8BA0F4", Offset = "0x8BA0F4", VA = "0x8BA0F4")]
	private static bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold)
	{
		return default(bool);
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x8BA1C4", Offset = "0x8BA1C4", VA = "0x8BA1C4")]
	private void HandleDrag()
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x8BA574", Offset = "0x8BA574", VA = "0x8BA574")]
	private void UpdateCurrentObject(GameObject previousObject)
	{
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x8BA73C", Offset = "0x8BA73C", VA = "0x8BA73C")]
	public static Vector2 NormalizedCartesianToSpherical(Vector3 cartCoords)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x8BA874", Offset = "0x8BA874", VA = "0x8BA874")]
	private void CastRay()
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x8BA724", Offset = "0x8BA724", VA = "0x8BA724")]
	private GameObject GetCurrentGameObject()
	{
		return null;
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x8BB29C", Offset = "0x8BB29C", VA = "0x8BB29C", Slot = "32")]
	protected virtual void ProcessGaze()
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x8BB304", Offset = "0x8BB304", VA = "0x8BB304", Slot = "33")]
	protected virtual void ProcessCustomRayController()
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x8BB30C", Offset = "0x8BB30C", VA = "0x8BB30C", Slot = "27")]
	protected override MouseState GetMousePointerEventData(int id)
	{
		return null;
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x8BB498", Offset = "0x8BB498", VA = "0x8BB498")]
	private PointerEventData.FramePressState CustomRayFramePressedState()
	{
		return default(PointerEventData.FramePressState);
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x8BB4C4", Offset = "0x8BB4C4", VA = "0x8BB4C4", Slot = "34")]
	protected virtual void ProcessViveControllers()
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x8BB4C8", Offset = "0x8BB4C8", VA = "0x8BB4C8", Slot = "35")]
	protected virtual void ProcessOculusVRController()
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x8B9AEC", Offset = "0x8B9AEC", VA = "0x8B9AEC")]
	private void ProcessSteamVR2Controllers()
	{
	}

	[Token(Token = "0x6000082")]
	private static T EnableInputModule<T>() where T : BaseInputModule
	{
		return null;
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x8BBE9C", Offset = "0x8BBE9C", VA = "0x8BBE9C")]
	public CurvedUIInputModuleVideo()
	{
	}
}
[Token(Token = "0x2000016")]
public class CurvedCanvasInputModule : BaseInputModule
{
	[Token(Token = "0x40000B0")]
	private const float CLICK_TIME = 0.1f;

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Vector2 sphericalCoordinatesResult;

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private PointerEventData pointerData;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector2 lastPose;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static bool forceGaze;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool rayCasterSet;

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x8312F0", Offset = "0x8312F0", VA = "0x8312F0", Slot = "21")]
	public override bool ShouldActivateModule()
	{
		return default(bool);
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x8312F8", Offset = "0x8312F8", VA = "0x8312F8", Slot = "22")]
	public override void DeactivateModule()
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x831694", Offset = "0x831694", VA = "0x831694", Slot = "17")]
	public override void Process()
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x832A5C", Offset = "0x832A5C", VA = "0x832A5C", Slot = "20")]
	public override bool IsPointerOverGameObject(int pointerId)
	{
		return default(bool);
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x832AE8", Offset = "0x832AE8", VA = "0x832AE8")]
	public RaycastResult GetCurrentRaycast()
	{
		return default(RaycastResult);
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x8317FC", Offset = "0x8317FC", VA = "0x8317FC")]
	private void CastRay()
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x832218", Offset = "0x832218", VA = "0x832218")]
	private void UpdateCurrentObject(GameObject previousObject)
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x832C5C", Offset = "0x832C5C", VA = "0x832C5C")]
	private static bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold)
	{
		return default(bool);
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x8323C8", Offset = "0x8323C8", VA = "0x8323C8")]
	private void HandleDrag()
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x831374", Offset = "0x831374", VA = "0x831374")]
	private void HandlePendingClick()
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x832778", Offset = "0x832778", VA = "0x832778")]
	private void HandleTriggerDown()
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x8317E4", Offset = "0x8317E4", VA = "0x8317E4")]
	private GameObject GetCurrentGameObject()
	{
		return null;
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x832D2C", Offset = "0x832D2C", VA = "0x832D2C")]
	public void Update()
	{
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x832B1C", Offset = "0x832B1C", VA = "0x832B1C")]
	public static Vector2 NormalizedCartesianToSpherical(Vector3 cartCoords)
	{
		return default(Vector2);
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x832DF4", Offset = "0x832DF4", VA = "0x832DF4")]
	public CurvedCanvasInputModule()
	{
	}
}
[Token(Token = "0x2000017")]
public class PreRenderCallback : MonoBehaviour
{
	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x7D1D70", Offset = "0x7D1D70", VA = "0x7D1D70")]
	public PreRenderCallback()
	{
	}
}
[Token(Token = "0x2000018")]
public class VrPhysicsRaycaster : BaseRaycaster
{
	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public App.RaycastSource inputRaySource;

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Camera _eventCam;

	[Token(Token = "0x17000028")]
	public override Camera eventCamera
	{
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x107AAAC", Offset = "0x107AAAC", VA = "0x107AAAC", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x107AB90", Offset = "0x107AB90", VA = "0x107AB90", Slot = "17")]
	public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x107AE34", Offset = "0x107AE34", VA = "0x107AE34")]
	public VrPhysicsRaycaster()
	{
	}
}
[Token(Token = "0x2000019")]
public class LaserPointerDot : MonoBehaviour
{
	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool show;

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform laserMesh;

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform laserStart;

	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform laserDot;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private RaycastHit hitInfo;

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x7CDF9C", Offset = "0x7CDF9C", VA = "0x7CDF9C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x7CE18C", Offset = "0x7CE18C", VA = "0x7CE18C")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x7CDFA0", Offset = "0x7CDFA0", VA = "0x7CDFA0")]
	private void DisableAllMeshOnLaser()
	{
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x7CE888", Offset = "0x7CE888", VA = "0x7CE888")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x7CE88C", Offset = "0x7CE88C", VA = "0x7CE88C")]
	public LaserPointerDot()
	{
	}
}
[Token(Token = "0x200001A")]
public class AccoutSettings : MonoBehaviour
{
	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject projectsPage;

	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Text username;

	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Text userEmail;

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x822C0C", Offset = "0x822C0C", VA = "0x822C0C")]
	public void SignOut()
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x822D40", Offset = "0x822D40", VA = "0x822D40")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x822FF0", Offset = "0x822FF0", VA = "0x822FF0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x8230E8", Offset = "0x8230E8", VA = "0x8230E8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x823160", Offset = "0x823160", VA = "0x823160")]
	public void BackToMenu()
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x822DB8", Offset = "0x822DB8", VA = "0x822DB8")]
	private void SetEmailAndName()
	{
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x823068", Offset = "0x823068", VA = "0x823068")]
	private void ResetTexts()
	{
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x8231A8", Offset = "0x8231A8", VA = "0x8231A8")]
	public AccoutSettings()
	{
	}
}
[Token(Token = "0x200001B")]
public class ActivateDefaultToggles : MonoBehaviour
{
	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private ToggleG[] groupToActivate;

	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private ToggleG[] groupToDeactivate;

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x8231B0", Offset = "0x8231B0", VA = "0x8231B0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x8232C4", Offset = "0x8232C4", VA = "0x8232C4")]
	private void Start()
	{
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x8231B4", Offset = "0x8231B4", VA = "0x8231B4")]
	private void Turn()
	{
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x8232C8", Offset = "0x8232C8", VA = "0x8232C8")]
	public ActivateDefaultToggles()
	{
	}
}
[Token(Token = "0x200001C")]
public class ActivateObjectOnEnable : MonoBehaviour
{
	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject sub;

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject notSub;

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x8232D0", Offset = "0x8232D0", VA = "0x8232D0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x823388", Offset = "0x823388", VA = "0x823388")]
	public ActivateObjectOnEnable()
	{
	}
}
[Token(Token = "0x200001D")]
public class ActivateRaycasterOnEnable : MonoBehaviour
{
	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject canvas;

	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private CurvedUIRaycaster _curvedUiRaycaster;

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x823390", Offset = "0x823390", VA = "0x823390")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x823394", Offset = "0x823394", VA = "0x823394")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x823474", Offset = "0x823474", VA = "0x823474")]
	private void DisableRayCaster()
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x8235A0", Offset = "0x8235A0", VA = "0x8235A0")]
	private void EnableRayCaster()
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x8236EC", Offset = "0x8236EC", VA = "0x8236EC")]
	public ActivateRaycasterOnEnable()
	{
	}
}
[Token(Token = "0x200001E")]
public class ReEnableMBOnEnable : MonoBehaviour
{
	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MonoBehaviour[] monoBehaviours;

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x7D5168", Offset = "0x7D5168", VA = "0x7D5168")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x7D52D0", Offset = "0x7D52D0", VA = "0x7D52D0")]
	public ReEnableMBOnEnable()
	{
	}
}
[Serializable]
[Token(Token = "0x200001F")]
public class MeditationComponent
{
	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public AppManager.MeditationProgram meditationProgram;

	[Token(Token = "0x40000C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float nature;

	[Token(Token = "0x40000C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float drumming;

	[Token(Token = "0x40000CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float music;

	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float voice;

	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float environment;

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x7D0814", Offset = "0x7D0814", VA = "0x7D0814")]
	public MeditationComponent()
	{
	}
}
[Token(Token = "0x2000020")]
public class AllAudiosValues : MonoBehaviour
{
	[Token(Token = "0x40000CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static AllAudiosValues instance;

	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private MeditationComponent[] mComponents;

	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private string meditationComponentsKey;

	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static string natureKey;

	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static string drummingKey;

	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static string musicKey;

	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static string voiceKey;

	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static string environmentKey;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static string meditationKey;

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public static string wisdomKey;

	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public static string breathingKey;

	[Token(Token = "0x17000029")]
	public static AllAudiosValues Instance
	{
		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x8236F4", Offset = "0x8236F4", VA = "0x8236F4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x82375C", Offset = "0x82375C", VA = "0x82375C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x823E30", Offset = "0x823E30", VA = "0x823E30")]
	public void SetSpecificSound(AppManager.MeditationProgram meditationProgram, float value, string key)
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x824490", Offset = "0x824490", VA = "0x824490")]
	private void SetComponentsFromPrefs()
	{
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x824834", Offset = "0x824834", VA = "0x824834")]
	public float[] GetFloatsByProgramType(AppManager.MeditationProgram programType)
	{
		return null;
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x824954", Offset = "0x824954", VA = "0x824954")]
	public void SetFloatsByProgramType(AppManager.MeditationProgram programType, float[] targetFloatArray)
	{
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x8238E0", Offset = "0x8238E0", VA = "0x8238E0")]
	private void SaveComponentsToPrefs()
	{
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x824A78", Offset = "0x824A78", VA = "0x824A78")]
	public void PrintFloatsByProgramType(AppManager.MeditationProgram programType)
	{
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x823BE4", Offset = "0x823BE4", VA = "0x823BE4")]
	private void PrintAllAudioInfo()
	{
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x824CD0", Offset = "0x824CD0", VA = "0x824CD0")]
	public AllAudiosValues()
	{
	}
}
[Token(Token = "0x2000021")]
public class AutoDisabling : MonoBehaviour
{
	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x8283D0", Offset = "0x8283D0", VA = "0x8283D0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x828428", Offset = "0x828428", VA = "0x828428")]
	private void DisableObject()
	{
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x828450", Offset = "0x828450", VA = "0x828450")]
	public AutoDisabling()
	{
	}
}
[Token(Token = "0x2000022")]
public class BreathSpinner : MonoBehaviour
{
	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static BreathSpinner instance;

	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool shouldDisable;

	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject SpinnerCanvas;

	[Token(Token = "0x1700002A")]
	public static BreathSpinner Instance
	{
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x828458", Offset = "0x828458", VA = "0x828458")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x8284A8", Offset = "0x8284A8", VA = "0x8284A8")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x8284FC", Offset = "0x8284FC", VA = "0x8284FC")]
	private void Start()
	{
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x828504", Offset = "0x828504", VA = "0x828504")]
	public void CheckIfShouldDisable()
	{
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x828534", Offset = "0x828534", VA = "0x828534")]
	public void SetDisable()
	{
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x828514", Offset = "0x828514", VA = "0x828514")]
	private void DisableSpinner()
	{
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x828540", Offset = "0x828540", VA = "0x828540")]
	private void ActivateSpinner()
	{
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x828560", Offset = "0x828560", VA = "0x828560")]
	public BreathSpinner()
	{
	}
}
[Token(Token = "0x2000023")]
public class ChangeGraphicsRaycasterState : MonoBehaviour
{
	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private bool _onEnable;

	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	[SerializeField]
	private bool _onStart;

	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	[SerializeField]
	private bool bool_timeDelay;

	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
	[SerializeField]
	private bool targetState;

	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float float_delayTime;

	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GraphicRaycaster _graphicRaycaster;

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x82A2E4", Offset = "0x82A2E4", VA = "0x82A2E4")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x82A33C", Offset = "0x82A33C", VA = "0x82A33C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x82A3E4", Offset = "0x82A3E4", VA = "0x82A3E4")]
	private void Start()
	{
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x82A3C0", Offset = "0x82A3C0", VA = "0x82A3C0")]
	private void MainFunction()
	{
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x82A468", Offset = "0x82A468", VA = "0x82A468")]
	public ChangeGraphicsRaycasterState()
	{
	}
}
[Token(Token = "0x2000024")]
public class ChangePressedState : MonoBehaviour
{
	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject toggleIsSelect;

	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject toggleIsDeselect;

	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private bool pressed;

	[Token(Token = "0x1700002B")]
	public bool Pressed
	{
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x82A478", Offset = "0x82A478", VA = "0x82A478")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x82A480", Offset = "0x82A480", VA = "0x82A480")]
		set
		{
		}
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x82A48C", Offset = "0x82A48C", VA = "0x82A48C")]
	public void ActivatedState()
	{
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x82A674", Offset = "0x82A674", VA = "0x82A674")]
	public void DisabledState()
	{
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x82A494", Offset = "0x82A494", VA = "0x82A494")]
	public void SetActive(bool active)
	{
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x82A67C", Offset = "0x82A67C", VA = "0x82A67C")]
	public ChangePressedState()
	{
	}
}
[Token(Token = "0x2000025")]
public class ChangeTextColor : MonoBehaviour
{
	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Text highlightedText;

	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private InputField inputField;

	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Color inactiveColor;

	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Color activeColor;

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x82A684", Offset = "0x82A684", VA = "0x82A684")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x82A6C0", Offset = "0x82A6C0", VA = "0x82A6C0")]
	private void Start()
	{
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x82A688", Offset = "0x82A688", VA = "0x82A688")]
	private void EnableDefaultStateIfAnySymbol()
	{
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x82A738", Offset = "0x82A738", VA = "0x82A738")]
	public void SetInactiveText()
	{
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x82A6C4", Offset = "0x82A6C4", VA = "0x82A6C4")]
	public void SetActiveText()
	{
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x82A7AC", Offset = "0x82A7AC", VA = "0x82A7AC")]
	public ChangeTextColor()
	{
	}
}
[Token(Token = "0x2000026")]
public class ChangeUIRaycasterState : MonoBehaviour
{
	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private bool _onEnable;

	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	[SerializeField]
	private bool _onStart;

	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	[SerializeField]
	private bool bool_timeDelay;

	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
	[SerializeField]
	private bool targetState;

	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float float_delayTime;

	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private CurvedUIRaycaster _graphicRaycaster;

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x82A7B4", Offset = "0x82A7B4", VA = "0x82A7B4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x82A884", Offset = "0x82A884", VA = "0x82A884")]
	private void Start()
	{
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x82A838", Offset = "0x82A838", VA = "0x82A838")]
	private void MainFunction()
	{
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x82A908", Offset = "0x82A908", VA = "0x82A908")]
	public ChangeUIRaycasterState()
	{
	}
}
[Token(Token = "0x2000027")]
public class CheckSubscription : MonoBehaviour
{
	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject hopeYouEnjoyedScreen;

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x82AA98", Offset = "0x82AA98", VA = "0x82AA98")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x82AB38", Offset = "0x82AB38", VA = "0x82AB38")]
	public CheckSubscription()
	{
	}
}
[Token(Token = "0x2000028")]
public class DeviceStorage
{
	[Token(Token = "0x6000101")]
	[Address(RVA = "0x7B1600", Offset = "0x7B1600", VA = "0x7B1600")]
	public static bool EnoughStorage(float requiredSpace)
	{
		return default(bool);
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0x7B17B4", Offset = "0x7B17B4", VA = "0x7B17B4")]
	public static bool EnoughStorageFalse(float requiredSpace)
	{
		return default(bool);
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x7B197C", Offset = "0x7B197C", VA = "0x7B197C")]
	public DeviceStorage()
	{
	}
}
[Token(Token = "0x2000029")]
public class DisableOnType : MonoBehaviour
{
	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private AppManager.MeditationProgram meditationProgram;

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x7B19FC", Offset = "0x7B19FC", VA = "0x7B19FC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0x7B1A9C", Offset = "0x7B1A9C", VA = "0x7B1A9C")]
	public DisableOnType()
	{
	}
}
[Token(Token = "0x200002A")]
public class EmailSubscriptionErrorsState : MonoBehaviour
{
	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static EmailSubscriptionErrorsState instance;

	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject[] wrongEmailObjects;

	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject[] defaultStateEmailObjects;

	[Token(Token = "0x1700002C")]
	public static EmailSubscriptionErrorsState Instance
	{
		[Token(Token = "0x6000106")]
		[Address(RVA = "0x7B1D08", Offset = "0x7B1D08", VA = "0x7B1D08")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x7B1D58", Offset = "0x7B1D58", VA = "0x7B1D58")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x7B1DAC", Offset = "0x7B1DAC", VA = "0x7B1DAC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x7B1DB4", Offset = "0x7B1DB4", VA = "0x7B1DB4")]
	public void SubscriptionSuccessful(bool value)
	{
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x7B1E84", Offset = "0x7B1E84", VA = "0x7B1E84")]
	public EmailSubscriptionErrorsState()
	{
	}
}
[Token(Token = "0x200002B")]
public class EnableOnType : MonoBehaviour
{
	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private AppManager.MeditationProgram meditationProgram;

	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x5FBD30", Offset = "0x5FBD30")]
	[SerializeField]
	private GameObject[] defaultObjects;

	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject[] thickObjects;

	[Token(Token = "0x600010B")]
	[Address(RVA = "0x7B1E8C", Offset = "0x7B1E8C", VA = "0x7B1E8C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0x7B1F64", Offset = "0x7B1F64", VA = "0x7B1F64")]
	private void ShowThickLayout(bool value)
	{
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0x7B1FE0", Offset = "0x7B1FE0", VA = "0x7B1FE0")]
	private void ShowDefaultLayout(bool value)
	{
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0x7B205C", Offset = "0x7B205C", VA = "0x7B205C")]
	public EnableOnType()
	{
	}
}
[Token(Token = "0x200002C")]
public class EnableRaycasterIfExists : MonoBehaviour
{
	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private CurvedUIRaycaster _curvedUiRaycaster;

	[Token(Token = "0x600010F")]
	[Address(RVA = "0x7B2064", Offset = "0x7B2064", VA = "0x7B2064")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0x7B2190", Offset = "0x7B2190", VA = "0x7B2190")]
	private void DisableRayCaster()
	{
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0x7B22BC", Offset = "0x7B22BC", VA = "0x7B22BC")]
	private void EnableRayCaster()
	{
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0x7B2408", Offset = "0x7B2408", VA = "0x7B2408")]
	public EnableRaycasterIfExists()
	{
	}
}
[Token(Token = "0x200002D")]
public class EntitlementCheck : MonoBehaviour
{
	[Token(Token = "0x6000113")]
	[Address(RVA = "0x7B2410", Offset = "0x7B2410", VA = "0x7B2410")]
	private void Start()
	{
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0x7B2414", Offset = "0x7B2414", VA = "0x7B2414")]
	public EntitlementCheck()
	{
	}
}
[Token(Token = "0x200002E")]
public class FaceControl : MonoBehaviour
{
	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static FaceControl instance;

	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool isHeadjackLoaded;

	[Token(Token = "0x1700002D")]
	public static FaceControl Instance
	{
		[Token(Token = "0x6000115")]
		[Address(RVA = "0x7B36FC", Offset = "0x7B36FC", VA = "0x7B36FC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0x7B374C", Offset = "0x7B374C", VA = "0x7B374C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x7B3860", Offset = "0x7B3860", VA = "0x7B3860")]
	public void HeadjackLoaded()
	{
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x7B38DC", Offset = "0x7B38DC", VA = "0x7B38DC")]
	public bool IfHeadjackLoaded()
	{
		return default(bool);
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0x7B39A4", Offset = "0x7B39A4", VA = "0x7B39A4")]
	public FaceControl()
	{
	}
}
[Token(Token = "0x200002F")]
public class FadeBetweenTextures : MonoBehaviour
{
	[Token(Token = "0x2000140")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FAFD4", Offset = "0x5FAFD4")]
	private sealed class <FadeOutTextureAndSetCurrent>d__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Material targetMat;

		[Token(Token = "0x4000648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public FadeBetweenTextures <>4__this;

		[Token(Token = "0x4000649")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float fromVal;

		[Token(Token = "0x400064A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float toVal;

		[Token(Token = "0x400064B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float duration;

		[Token(Token = "0x400064C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Material currentMat;

		[Token(Token = "0x400064D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float <counter>5__2;

		[Token(Token = "0x170000BA")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60008C5")]
			[Address(RVA = "0x7B4238", Offset = "0x7B4238", VA = "0x7B4238", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BB")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60008C7")]
			[Address(RVA = "0x7B42A0", Offset = "0x7B42A0", VA = "0x7B42A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008C2")]
		[Address(RVA = "0x7B3EEC", Offset = "0x7B3EEC", VA = "0x7B3EEC")]
		[DebuggerHidden]
		public <FadeOutTextureAndSetCurrent>d__14(int <>1__state)
		{
		}

		[Token(Token = "0x60008C3")]
		[Address(RVA = "0x7B4034", Offset = "0x7B4034", VA = "0x7B4034", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60008C4")]
		[Address(RVA = "0x7B4038", Offset = "0x7B4038", VA = "0x7B4038", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60008C6")]
		[Address(RVA = "0x7B4240", Offset = "0x7B4240", VA = "0x7B4240", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static FadeBetweenTextures instance;

	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private List<Texture> textures;

	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Material currentCardMat;

	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Material targetCardMat;

	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private string mainTexture;

	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private string fadingAlpha;

	[Token(Token = "0x1700002E")]
	public static FadeBetweenTextures Instance
	{
		[Token(Token = "0x600011A")]
		[Address(RVA = "0x7B39AC", Offset = "0x7B39AC", VA = "0x7B39AC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0x7B39FC", Offset = "0x7B39FC", VA = "0x7B39FC")]
	private void Awake()
	{
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0x7B3A50", Offset = "0x7B3A50", VA = "0x7B3A50")]
	public void Change360Preview(HollywoodProjectVisual hollywoodProject)
	{
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0x7B3AEC", Offset = "0x7B3AEC", VA = "0x7B3AEC")]
	private void CheckCard(string cardName)
	{
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x7B3BE4", Offset = "0x7B3BE4", VA = "0x7B3BE4")]
	private Texture TextureWithCardName(string cardName)
	{
		return null;
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0x7B3E84", Offset = "0x7B3E84", VA = "0x7B3E84")]
	public void AddTextureToList(Texture2D texture2D)
	{
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0x7B3DB8", Offset = "0x7B3DB8", VA = "0x7B3DB8")]
	private void ChangeAlpha(Material material, float alphaValue)
	{
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0x7B3DDC", Offset = "0x7B3DDC", VA = "0x7B3DDC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5FD7A8", Offset = "0x5FD7A8")]
	private IEnumerator FadeOutTextureAndSetCurrent(float fromVal, float toVal, float duration, Material currentMat, Material targetMat)
	{
		return null;
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0x7B3F18", Offset = "0x7B3F18", VA = "0x7B3F18")]
	private void ChangeTargetTexture(Material material, Texture targetTexture)
	{
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0x7B3F3C", Offset = "0x7B3F3C", VA = "0x7B3F3C")]
	private void ChangeTargetTexture(Material material, int textureIndex)
	{
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0x7B3FCC", Offset = "0x7B3FCC", VA = "0x7B3FCC")]
	public FadeBetweenTextures()
	{
	}
}
[Token(Token = "0x2000030")]
public class Startup : MonoBehaviour
{
	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static Startup instance;

	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject menuItemPrefab;

	[Token(Token = "0x4000101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool playing;

	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float LoadingProgress;

	[Token(Token = "0x6000125")]
	[Address(RVA = "0x7E7580", Offset = "0x7E7580", VA = "0x7E7580")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0x7E75D4", Offset = "0x7E75D4", VA = "0x7E75D4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0x7E7678", Offset = "0x7E7678", VA = "0x7E7678")]
	private void ProgressListener(ImageLoadingState imageloadingstate, float processed, float total)
	{
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0x7E7680", Offset = "0x7E7680", VA = "0x7E7680")]
	private void Initialized(bool success, string error)
	{
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0x7E778C", Offset = "0x7E778C", VA = "0x7E778C")]
	public Startup()
	{
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0x7E7794", Offset = "0x7E7794", VA = "0x7E7794")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FD80C", Offset = "0x5FD80C")]
	private void <Start>b__5_0(bool succ, string e)
	{
	}
}
[Token(Token = "0x2000031")]
public class GazesProgressBar : MonoBehaviour
{
	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static GazesProgressBar instance;

	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private GameObject mainCameraObject;

	[Token(Token = "0x1700002F")]
	public static GazesProgressBar Instance
	{
		[Token(Token = "0x600012B")]
		[Address(RVA = "0x7B5234", Offset = "0x7B5234", VA = "0x7B5234")]
		get
		{
			return null;
		}
		[Token(Token = "0x600012C")]
		[Address(RVA = "0x7B5284", Offset = "0x7B5284", VA = "0x7B5284")]
		set
		{
		}
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0x7B52D8", Offset = "0x7B52D8", VA = "0x7B52D8")]
	private void Awake()
	{
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0x7B53E8", Offset = "0x7B53E8", VA = "0x7B53E8")]
	private void Start()
	{
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0x7B5424", Offset = "0x7B5424", VA = "0x7B5424")]
	public void ResetAllProgressBars()
	{
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0x7B5824", Offset = "0x7B5824", VA = "0x7B5824")]
	public void DisableAllExceptCurrent(string targetObjName)
	{
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0x7B53EC", Offset = "0x7B53EC", VA = "0x7B53EC")]
	private void SetMainCamObject()
	{
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0x7B5B50", Offset = "0x7B5B50", VA = "0x7B5B50")]
	public GazesProgressBar()
	{
	}
}
[Token(Token = "0x2000032")]
public class HeadPointerWithCheck : HeadPointer
{
	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool alreadyActivated;

	[Token(Token = "0x6000133")]
	[Address(RVA = "0x7EC7B0", Offset = "0x7EC7B0", VA = "0x7EC7B0")]
	public new void OnEnable()
	{
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0x7EC98C", Offset = "0x7EC98C", VA = "0x7EC98C")]
	private bool ContainsCurrent(GameObject targetGameObject)
	{
		return default(bool);
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0x7ECC9C", Offset = "0x7ECC9C", VA = "0x7ECC9C")]
	private void ReparentCurrent(GameObject mainCam)
	{
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0x7ECE18", Offset = "0x7ECE18", VA = "0x7ECE18")]
	public HeadPointerWithCheck()
	{
	}
}
[Token(Token = "0x2000033")]
public class AnimatedDot : MonoBehaviour
{
	[Token(Token = "0x4000106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform innerPrefab;

	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform outerPrefab;

	[Token(Token = "0x6000137")]
	[Address(RVA = "0x824E10", Offset = "0x824E10", VA = "0x824E10")]
	public AnimatedDot()
	{
	}
}
[Token(Token = "0x2000034")]
public class Easing
{
	[Token(Token = "0x6000138")]
	[Address(RVA = "0x7B1AA4", Offset = "0x7B1AA4", VA = "0x7B1AA4")]
	public static double ElasticIn(double value)
	{
		return default(double);
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0x7B1B40", Offset = "0x7B1B40", VA = "0x7B1B40")]
	public static double ElasticOut(double value)
	{
		return default(double);
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0x7B1BE8", Offset = "0x7B1BE8", VA = "0x7B1BE8")]
	public static double ElasticInOut(double value)
	{
		return default(double);
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0x7B1D00", Offset = "0x7B1D00", VA = "0x7B1D00")]
	public Easing()
	{
	}
}
[Token(Token = "0x2000035")]
public class ArabicHelper
{
	[Token(Token = "0x4000108")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Regex arabicRanges;

	[Token(Token = "0x600013C")]
	[Address(RVA = "0x826F44", Offset = "0x826F44", VA = "0x826F44")]
	public static bool ContainsArabic(string str)
	{
		return default(bool);
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0x826FE0", Offset = "0x826FE0", VA = "0x826FE0")]
	public static string CorrectText(string str)
	{
		return null;
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0x8272D8", Offset = "0x8272D8", VA = "0x8272D8")]
	public ArabicHelper()
	{
	}
}
[Token(Token = "0x2000036")]
public class BufferingPosition : MonoBehaviour
{
	[Token(Token = "0x6000140")]
	[Address(RVA = "0x828568", Offset = "0x828568", VA = "0x828568")]
	private void Update()
	{
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0x8286EC", Offset = "0x8286EC", VA = "0x8286EC")]
	public BufferingPosition()
	{
	}
}
[Token(Token = "0x2000037")]
public class CategoryProject : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	[Token(Token = "0x4000109")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string id;

	[Token(Token = "0x400010A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public RawImage rawImage;

	[Token(Token = "0x400010B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public RawImage outline;

	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool selected;

	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	private bool highlighted;

	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public CategoryProjects categoryProjects;

	[Token(Token = "0x6000142")]
	[Address(RVA = "0x8294B4", Offset = "0x8294B4", VA = "0x8294B4")]
	public void Initialize(string id)
	{
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0x82954C", Offset = "0x82954C", VA = "0x82954C", Slot = "4")]
	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0x829558", Offset = "0x829558", VA = "0x829558", Slot = "5")]
	public void OnPointerExit(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0x829560", Offset = "0x829560", VA = "0x829560")]
	private void Update()
	{
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0x8296DC", Offset = "0x8296DC", VA = "0x8296DC")]
	public void SwitchProject()
	{
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0x8297CC", Offset = "0x8297CC", VA = "0x8297CC")]
	public CategoryProject()
	{
	}
}
[Token(Token = "0x2000038")]
public class CategoryProjects : MonoBehaviour
{
	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string currentProject;

	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string category;

	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public CategoryProject categoryProjectPrefab;

	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<CategoryProject> categoryProjects;

	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public RectTransform rightEmpty;

	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Dictionary<string, CategoryProject> cache;

	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ProjectPage projectPage;

	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public RectTransform contentRect;

	[Token(Token = "0x4000117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Transform middleLocation;

	[Token(Token = "0x6000148")]
	[Address(RVA = "0x8297D4", Offset = "0x8297D4", VA = "0x8297D4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0x8298E4", Offset = "0x8298E4", VA = "0x8298E4")]
	public void Initialize(string id)
	{
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0x8296FC", Offset = "0x8296FC", VA = "0x8296FC")]
	public void SwitchInCategory(string id)
	{
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0x829D34", Offset = "0x829D34", VA = "0x829D34")]
	private void CenterCurrentProject(CategoryProject currentProject)
	{
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0x829E48", Offset = "0x829E48", VA = "0x829E48")]
	public CategoryProjects()
	{
	}
}
[Token(Token = "0x2000039")]
public class CategoryRow : MonoBehaviour
{
	[Token(Token = "0x4000118")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public RectTransform scrollViewRect;

	[Token(Token = "0x4000119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public RectTransform contentRect;

	[Token(Token = "0x400011A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public EssentialsManager essentialsManager;

	[Token(Token = "0x400011B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string id;

	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<ProjectInstance> projects;

	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ProjectInstance projectInstanceTemplate;

	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TextMeshProUGUI categoryTitle;

	[Token(Token = "0x600014D")]
	[Address(RVA = "0x829E50", Offset = "0x829E50", VA = "0x829E50")]
	public void Initialize(EssentialsManager.ProjectCollection category)
	{
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0x82A2DC", Offset = "0x82A2DC", VA = "0x82A2DC")]
	public CategoryRow()
	{
	}
}
[Token(Token = "0x200003A")]
public class CinemaHandler : MonoBehaviour
{
	[Token(Token = "0x2000141")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FAFE4", Offset = "0x5FAFE4")]
	private sealed class <>c__DisplayClass54_0
	{
		[Token(Token = "0x400064E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string[] allProjects;

		[Token(Token = "0x400064F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CinemaHandler <>4__this;

		[Token(Token = "0x60008C8")]
		[Address(RVA = "0x82CB98", Offset = "0x82CB98", VA = "0x82CB98")]
		public <>c__DisplayClass54_0()
		{
		}
	}

	[Token(Token = "0x2000142")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FAFF4", Offset = "0x5FAFF4")]
	private sealed class <>c__DisplayClass54_1
	{
		[Token(Token = "0x4000650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int currentI;

		[Token(Token = "0x4000651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public <>c__DisplayClass54_0 CS$<>8__locals1;

		[Token(Token = "0x60008C9")]
		[Address(RVA = "0x82CBA0", Offset = "0x82CBA0", VA = "0x82CBA0")]
		public <>c__DisplayClass54_1()
		{
		}

		[Token(Token = "0x60008CA")]
		[Address(RVA = "0x82CBA8", Offset = "0x82CBA8", VA = "0x82CBA8")]
		internal void <SetCinema>b__0(bool downloadSuccess, string downloadError)
		{
		}
	}

	[Token(Token = "0x2000143")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB004", Offset = "0x5FB004")]
	private sealed class <SetCinema>d__54 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MessageSetCinema startMessage;

		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public CinemaHandler <>4__this;

		[Token(Token = "0x4000656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public NetPeer peer;

		[Token(Token = "0x170000BC")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60008CE")]
			[Address(RVA = "0x82D3E0", Offset = "0x82D3E0", VA = "0x82D3E0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BD")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60008D0")]
			[Address(RVA = "0x82D448", Offset = "0x82D448", VA = "0x82D448", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008CB")]
		[Address(RVA = "0x82C174", Offset = "0x82C174", VA = "0x82C174")]
		[DebuggerHidden]
		public <SetCinema>d__54(int <>1__state)
		{
		}

		[Token(Token = "0x60008CC")]
		[Address(RVA = "0x82D0BC", Offset = "0x82D0BC", VA = "0x82D0BC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60008CD")]
		[Address(RVA = "0x82D0C0", Offset = "0x82D0C0", VA = "0x82D0C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60008CF")]
		[Address(RVA = "0x82D3E8", Offset = "0x82D3E8", VA = "0x82D3E8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000144")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB014", Offset = "0x5FB014")]
	private sealed class <>c__DisplayClass55_0
	{
		[Token(Token = "0x4000657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MessagePrepareVideo prepareMessage;

		[Token(Token = "0x4000658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CinemaHandler <>4__this;

		[Token(Token = "0x60008D1")]
		[Address(RVA = "0x82C1A0", Offset = "0x82C1A0", VA = "0x82C1A0")]
		public <>c__DisplayClass55_0()
		{
		}

		[Token(Token = "0x60008D2")]
		[Address(RVA = "0x82CCC0", Offset = "0x82CCC0", VA = "0x82CCC0")]
		internal void <PrepareVideo>b__0(bool s, string e)
		{
		}

		[Token(Token = "0x60008D3")]
		[Address(RVA = "0x82CDF8", Offset = "0x82CDF8", VA = "0x82CDF8")]
		internal void <PrepareVideo>b__1(bool playSuccess, string playError)
		{
		}
	}

	[Token(Token = "0x2000145")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB024", Offset = "0x5FB024")]
	private sealed class <StopPlayback>d__59 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400065A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400065B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MessageStopPlayback stopMessage;

		[Token(Token = "0x400065C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public NetPeer server;

		[Token(Token = "0x400065D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public CinemaHandler <>4__this;

		[Token(Token = "0x170000BE")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60008D7")]
			[Address(RVA = "0x82D5E4", Offset = "0x82D5E4", VA = "0x82D5E4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BF")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60008D9")]
			[Address(RVA = "0x82D64C", Offset = "0x82D64C", VA = "0x82D64C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008D4")]
		[Address(RVA = "0x82C1A8", Offset = "0x82C1A8", VA = "0x82C1A8")]
		[DebuggerHidden]
		public <StopPlayback>d__59(int <>1__state)
		{
		}

		[Token(Token = "0x60008D5")]
		[Address(RVA = "0x82D450", Offset = "0x82D450", VA = "0x82D450", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60008D6")]
		[Address(RVA = "0x82D454", Offset = "0x82D454", VA = "0x82D454", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60008D8")]
		[Address(RVA = "0x82D5EC", Offset = "0x82D5EC", VA = "0x82D5EC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000146")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB034", Offset = "0x5FB034")]
	private sealed class <>c__DisplayClass61_0
	{
		[Token(Token = "0x400065E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CinemaHandler <>4__this;

		[Token(Token = "0x400065F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string projectId;

		[Token(Token = "0x60008DA")]
		[Address(RVA = "0x82C2CC", Offset = "0x82C2CC", VA = "0x82C2CC")]
		public <>c__DisplayClass61_0()
		{
		}

		[Token(Token = "0x60008DB")]
		[Address(RVA = "0x82CF94", Offset = "0x82CF94", VA = "0x82CF94")]
		internal void <StartDownload>b__0(bool downloadSuccess, string downloadError)
		{
		}
	}

	[Token(Token = "0x2000147")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB044", Offset = "0x5FB044")]
	private sealed class <UpdateDeviceHealth>d__62 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000660")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000661")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000662")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CinemaHandler <>4__this;

		[Token(Token = "0x4000663")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <currentTemp>5__2;

		[Token(Token = "0x170000C0")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60008DF")]
			[Address(RVA = "0x82D7D0", Offset = "0x82D7D0", VA = "0x82D7D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C1")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60008E1")]
			[Address(RVA = "0x82D838", Offset = "0x82D838", VA = "0x82D838", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008DC")]
		[Address(RVA = "0x82C2D4", Offset = "0x82C2D4", VA = "0x82C2D4")]
		[DebuggerHidden]
		public <UpdateDeviceHealth>d__62(int <>1__state)
		{
		}

		[Token(Token = "0x60008DD")]
		[Address(RVA = "0x82D654", Offset = "0x82D654", VA = "0x82D654", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60008DE")]
		[Address(RVA = "0x82D658", Offset = "0x82D658", VA = "0x82D658", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60008E0")]
		[Address(RVA = "0x82D7D8", Offset = "0x82D7D8", VA = "0x82D7D8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000148")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB054", Offset = "0x5FB054")]
	private sealed class <UpdateDownloadProgress>d__63 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000664")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000665")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000666")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string projectId;

		[Token(Token = "0x4000667")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public NetPeer peer;

		[Token(Token = "0x4000668")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private MessageDownloadProgress <progressMessage>5__2;

		[Token(Token = "0x170000C2")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60008E5")]
			[Address(RVA = "0x82DC1C", Offset = "0x82DC1C", VA = "0x82DC1C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C3")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60008E7")]
			[Address(RVA = "0x82DC84", Offset = "0x82DC84", VA = "0x82DC84", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008E2")]
		[Address(RVA = "0x82C300", Offset = "0x82C300", VA = "0x82C300")]
		[DebuggerHidden]
		public <UpdateDownloadProgress>d__63(int <>1__state)
		{
		}

		[Token(Token = "0x60008E3")]
		[Address(RVA = "0x82D840", Offset = "0x82D840", VA = "0x82D840", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60008E4")]
		[Address(RVA = "0x82D844", Offset = "0x82D844", VA = "0x82D844", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60008E6")]
		[Address(RVA = "0x82DC24", Offset = "0x82DC24", VA = "0x82DC24", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000149")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB064", Offset = "0x5FB064")]
	private sealed class <UpdatePlaybackState>d__65 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000669")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400066A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400066B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CinemaHandler <>4__this;

		[Token(Token = "0x170000C4")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60008EB")]
			[Address(RVA = "0x82DD60", Offset = "0x82DD60", VA = "0x82DD60", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C5")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60008ED")]
			[Address(RVA = "0x82DDC8", Offset = "0x82DDC8", VA = "0x82DDC8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008E8")]
		[Address(RVA = "0x82C32C", Offset = "0x82C32C", VA = "0x82C32C")]
		[DebuggerHidden]
		public <UpdatePlaybackState>d__65(int <>1__state)
		{
		}

		[Token(Token = "0x60008E9")]
		[Address(RVA = "0x82DC8C", Offset = "0x82DC8C", VA = "0x82DC8C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60008EA")]
		[Address(RVA = "0x82DC90", Offset = "0x82DC90", VA = "0x82DC90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60008EC")]
		[Address(RVA = "0x82DD68", Offset = "0x82DD68", VA = "0x82DD68", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200014A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB074", Offset = "0x5FB074")]
	private sealed class <UpdateViewDirection>d__67 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400066C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400066D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400066E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CinemaHandler <>4__this;

		[Token(Token = "0x170000C6")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60008F1")]
			[Address(RVA = "0x82E288", Offset = "0x82E288", VA = "0x82E288", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C7")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60008F3")]
			[Address(RVA = "0x82E2F0", Offset = "0x82E2F0", VA = "0x82E2F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008EE")]
		[Address(RVA = "0x82C898", Offset = "0x82C898", VA = "0x82C898")]
		[DebuggerHidden]
		public <UpdateViewDirection>d__67(int <>1__state)
		{
		}

		[Token(Token = "0x60008EF")]
		[Address(RVA = "0x82DDD0", Offset = "0x82DDD0", VA = "0x82DDD0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60008F0")]
		[Address(RVA = "0x82DDD4", Offset = "0x82DDD4", VA = "0x82DDD4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60008F2")]
		[Address(RVA = "0x82E290", Offset = "0x82E290", VA = "0x82E290", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400011F")]
	private const string NAME_PREFERENCE_KEY = "headjack_cinema_name";

	[Token(Token = "0x4000120")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static CinemaHandler instance;

	[Token(Token = "0x4000121")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FBDB8", Offset = "0x5FBDB8")]
	private bool <CinemaStarted>k__BackingField;

	[Token(Token = "0x4000122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FBDC8", Offset = "0x5FBDC8")]
	private bool <IsPlaying>k__BackingField;

	[Token(Token = "0x4000123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FBDD8", Offset = "0x5FBDD8")]
	private bool <IsPaused>k__BackingField;

	[Token(Token = "0x4000124")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FBDE8", Offset = "0x5FBDE8")]
	private bool <IsConnected>k__BackingField;

	[Token(Token = "0x4000125")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FBDF8", Offset = "0x5FBDF8")]
	private bool <IsDownloading>k__BackingField;

	[Token(Token = "0x4000126")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FBE08", Offset = "0x5FBE08")]
	private List<string> <DownloadQueue>k__BackingField;

	[Token(Token = "0x4000127")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FBE18", Offset = "0x5FBE18")]
	private string <DeviceName>k__BackingField;

	[Token(Token = "0x4000128")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FBE28", Offset = "0x5FBE28")]
	private string <LatestMessage>k__BackingField;

	[Token(Token = "0x4000129")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private MessageStatus statusMessage;

	[Token(Token = "0x400012A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private MessageLog logMessage;

	[Token(Token = "0x400012B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private MessageDeviceHealth healthMessage;

	[Token(Token = "0x400012C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private MessagePlayback playbackMessage;

	[Token(Token = "0x400012D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private MessageViewDirection directionMessage;

	[Token(Token = "0x400012E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Coroutine deviceHealthUpdate;

	[Token(Token = "0x400012F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Coroutine playbackUpdate;

	[Token(Token = "0x4000130")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Coroutine viewDirectionUpdate;

	[Token(Token = "0x4000131")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private string previousActiveProject;

	[Token(Token = "0x4000132")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private bool wasPaused;

	[Token(Token = "0x4000133")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private long previousPlayTimestamp;

	[Token(Token = "0x4000134")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private long previousVideoTime;

	[Token(Token = "0x4000135")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private long previousDuration;

	[Token(Token = "0x4000136")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private bool previousPaused;

	[Token(Token = "0x4000137")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
	private bool HMDLost;

	[Token(Token = "0x17000030")]
	public bool CinemaStarted
	{
		[Token(Token = "0x600014F")]
		[Address(RVA = "0x82AB40", Offset = "0x82AB40", VA = "0x82AB40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FD81C", Offset = "0x5FD81C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000150")]
		[Address(RVA = "0x82AB48", Offset = "0x82AB48", VA = "0x82AB48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FD82C", Offset = "0x5FD82C")]
		private set
		{
		}
	}

	[Token(Token = "0x17000031")]
	public bool IsPlaying
	{
		[Token(Token = "0x6000151")]
		[Address(RVA = "0x82AB54", Offset = "0x82AB54", VA = "0x82AB54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FD83C", Offset = "0x5FD83C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000152")]
		[Address(RVA = "0x82AB5C", Offset = "0x82AB5C", VA = "0x82AB5C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FD84C", Offset = "0x5FD84C")]
		private set
		{
		}
	}

	[Token(Token = "0x17000032")]
	public bool IsPaused
	{
		[Token(Token = "0x6000153")]
		[Address(RVA = "0x82AB68", Offset = "0x82AB68", VA = "0x82AB68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FD85C", Offset = "0x5FD85C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000154")]
		[Address(RVA = "0x82AB70", Offset = "0x82AB70", VA = "0x82AB70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FD86C", Offset = "0x5FD86C")]
		private set
		{
		}
	}

	[Token(Token = "0x17000033")]
	public bool IsConnected
	{
		[Token(Token = "0x6000155")]
		[Address(RVA = "0x82AB7C", Offset = "0x82AB7C", VA = "0x82AB7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FD87C", Offset = "0x5FD87C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000156")]
		[Address(RVA = "0x82AB84", Offset = "0x82AB84", VA = "0x82AB84")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FD88C", Offset = "0x5FD88C")]
		private set
		{
		}
	}

	[Token(Token = "0x17000034")]
	public bool IsDownloading
	{
		[Token(Token = "0x6000157")]
		[Address(RVA = "0x82AB90", Offset = "0x82AB90", VA = "0x82AB90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FD89C", Offset = "0x5FD89C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000158")]
		[Address(RVA = "0x82AB98", Offset = "0x82AB98", VA = "0x82AB98")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FD8AC", Offset = "0x5FD8AC")]
		private set
		{
		}
	}

	[Token(Token = "0x17000035")]
	public List<string> DownloadQueue
	{
		[Token(Token = "0x6000159")]
		[Address(RVA = "0x82ABA4", Offset = "0x82ABA4", VA = "0x82ABA4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FD8BC", Offset = "0x5FD8BC")]
		get
		{
			return null;
		}
		[Token(Token = "0x600015A")]
		[Address(RVA = "0x82ABAC", Offset = "0x82ABAC", VA = "0x82ABAC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FD8CC", Offset = "0x5FD8CC")]
		private set
		{
		}
	}

	[Token(Token = "0x17000036")]
	public string DeviceName
	{
		[Token(Token = "0x600015B")]
		[Address(RVA = "0x82ABB4", Offset = "0x82ABB4", VA = "0x82ABB4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FD8DC", Offset = "0x5FD8DC")]
		get
		{
			return null;
		}
		[Token(Token = "0x600015C")]
		[Address(RVA = "0x82ABBC", Offset = "0x82ABBC", VA = "0x82ABBC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FD8EC", Offset = "0x5FD8EC")]
		private set
		{
		}
	}

	[Token(Token = "0x17000037")]
	public string LatestMessage
	{
		[Token(Token = "0x600015D")]
		[Address(RVA = "0x82ABC4", Offset = "0x82ABC4", VA = "0x82ABC4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FD8FC", Offset = "0x5FD8FC")]
		get
		{
			return null;
		}
		[Token(Token = "0x600015E")]
		[Address(RVA = "0x82ABCC", Offset = "0x82ABCC", VA = "0x82ABCC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FD90C", Offset = "0x5FD90C")]
		private set
		{
		}
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0x82ABD4", Offset = "0x82ABD4", VA = "0x82ABD4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0x82ADF4", Offset = "0x82ADF4", VA = "0x82ADF4")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000161")]
	[Address(RVA = "0x82AEE4", Offset = "0x82AEE4", VA = "0x82AEE4")]
	private void OnMessage(NetPeer peer, MessageBase message)
	{
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0x82B4A4", Offset = "0x82B4A4", VA = "0x82B4A4")]
	private void SendDeviceInfo(NetPeer peer)
	{
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0x82B5C0", Offset = "0x82B5C0", VA = "0x82B5C0")]
	private void SendSavedName(NetPeer peer)
	{
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0x82B8B8", Offset = "0x82B8B8", VA = "0x82B8B8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5FD91C", Offset = "0x5FD91C")]
	private IEnumerator SetCinema(NetPeer peer, MessageSetCinema startMessage)
	{
		return null;
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0x82B93C", Offset = "0x82B93C", VA = "0x82B93C")]
	private void PrepareVideo(MessagePrepareVideo prepareMessage)
	{
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0x82BAB0", Offset = "0x82BAB0", VA = "0x82BAB0")]
	private void SeekTo(NetPeer server, MessageSeekTo seekMessage)
	{
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0x82BC5C", Offset = "0x82BC5C", VA = "0x82BC5C")]
	private void PlayAt(NetPeer server, MessagePlayAt playMessage)
	{
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0x82BE04", Offset = "0x82BE04", VA = "0x82BE04")]
	private void PauseAt(NetPeer server, MessagePauseAt pauseMessage)
	{
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0x82BFAC", Offset = "0x82BFAC", VA = "0x82BFAC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5FD980", Offset = "0x5FD980")]
	private IEnumerator StopPlayback(NetPeer server, MessageStopPlayback stopMessage)
	{
		return null;
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0x82C030", Offset = "0x82C030", VA = "0x82C030")]
	private void DownloadProject(MessageDownloadProject downloadMessage)
	{
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0x82C1D4", Offset = "0x82C1D4", VA = "0x82C1D4")]
	private void StartDownload(string projectId)
	{
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0x82B768", Offset = "0x82B768", VA = "0x82B768")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5FD9E4", Offset = "0x5FD9E4")]
	private IEnumerator UpdateDeviceHealth()
	{
		return null;
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0x82C0F8", Offset = "0x82C0F8", VA = "0x82C0F8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5FDA48", Offset = "0x5FDA48")]
	private IEnumerator UpdateDownloadProgress(string projectId, [Optional] NetPeer peer)
	{
		return null;
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0x82B67C", Offset = "0x82B67C", VA = "0x82B67C")]
	private void SendAllDownloadProgress([Optional] NetPeer peer)
	{
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0x82B7D8", Offset = "0x82B7D8", VA = "0x82B7D8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5FDAAC", Offset = "0x5FDAAC")]
	private IEnumerator UpdatePlaybackState()
	{
		return null;
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0x82C358", Offset = "0x82C358", VA = "0x82C358")]
	private void SendPlaybackState()
	{
	}

	[Token(Token = "0x6000171")]
	[Address(RVA = "0x82B848", Offset = "0x82B848", VA = "0x82B848")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5FDB10", Offset = "0x5FDB10")]
	private IEnumerator UpdateViewDirection()
	{
		return null;
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0x82C8C4", Offset = "0x82C8C4", VA = "0x82C8C4")]
	private void OnPauseStateChange(bool paused)
	{
	}

	[Token(Token = "0x6000173")]
	[Address(RVA = "0x82CB28", Offset = "0x82CB28", VA = "0x82CB28")]
	private void Update()
	{
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0x82CB88", Offset = "0x82CB88", VA = "0x82CB88")]
	private void OnApplicationPause(bool paused)
	{
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0x82CB90", Offset = "0x82CB90", VA = "0x82CB90")]
	public CinemaHandler()
	{
	}
}
[Token(Token = "0x200003B")]
public class CinemaListenerExample : MonoBehaviour
{
	[Token(Token = "0x200014B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB084", Offset = "0x5FB084")]
	private sealed class <>c__DisplayClass13_0
	{
		[Token(Token = "0x400066F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string projectId;

		[Token(Token = "0x4000670")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CinemaListenerExample <>4__this;

		[Token(Token = "0x60008F4")]
		[Address(RVA = "0x82F264", Offset = "0x82F264", VA = "0x82F264")]
		public <>c__DisplayClass13_0()
		{
		}

		[Token(Token = "0x60008F5")]
		[Address(RVA = "0x82FCF4", Offset = "0x82FCF4", VA = "0x82FCF4")]
		internal void <OnEnable>b__10(bool succ, string err)
		{
		}
	}

	[Token(Token = "0x200014C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB094", Offset = "0x5FB094")]
	private sealed class <>c__DisplayClass13_1
	{
		[Token(Token = "0x4000671")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string projectId;

		[Token(Token = "0x4000672")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CinemaListenerExample <>4__this;

		[Token(Token = "0x60008F6")]
		[Address(RVA = "0x82F684", Offset = "0x82F684", VA = "0x82F684")]
		public <>c__DisplayClass13_1()
		{
		}

		[Token(Token = "0x60008F7")]
		[Address(RVA = "0x82FF04", Offset = "0x82FF04", VA = "0x82FF04")]
		internal void <OnEnable>b__11(bool s, string e)
		{
		}

		[Token(Token = "0x60008F8")]
		[Address(RVA = "0x83002C", Offset = "0x83002C", VA = "0x83002C")]
		internal void <OnEnable>b__12(bool succ, string err)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200014D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB0A4", Offset = "0x5FB0A4")]
	private sealed class <>c
	{
		[Token(Token = "0x4000673")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000674")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static PushEvent <>9__13_8;

		[Token(Token = "0x60008FA")]
		[Address(RVA = "0x82FCE8", Offset = "0x82FCE8", VA = "0x82FCE8")]
		public <>c()
		{
		}

		[Token(Token = "0x60008FB")]
		[Address(RVA = "0x82FCF0", Offset = "0x82FCF0", VA = "0x82FCF0")]
		internal void <OnEnable>b__13_8(JSONArray args)
		{
		}
	}

	[Token(Token = "0x200014E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB0B4", Offset = "0x5FB0B4")]
	private sealed class <UpdateDownloadProgress>d__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000675")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CinemaListenerExample <>4__this;

		[Token(Token = "0x170000C8")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60008FF")]
			[Address(RVA = "0x8304A0", Offset = "0x8304A0", VA = "0x8304A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C9")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000901")]
			[Address(RVA = "0x830508", Offset = "0x830508", VA = "0x830508", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008FC")]
		[Address(RVA = "0x82ED54", Offset = "0x82ED54", VA = "0x82ED54")]
		[DebuggerHidden]
		public <UpdateDownloadProgress>d__19(int <>1__state)
		{
		}

		[Token(Token = "0x60008FD")]
		[Address(RVA = "0x8301B4", Offset = "0x8301B4", VA = "0x8301B4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60008FE")]
		[Address(RVA = "0x8301B8", Offset = "0x8301B8", VA = "0x8301B8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000900")]
		[Address(RVA = "0x8304A8", Offset = "0x8304A8", VA = "0x8304A8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200014F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB0C4", Offset = "0x5FB0C4")]
	private sealed class <UpdatePlaybackPosition>d__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400067A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CinemaListenerExample <>4__this;

		[Token(Token = "0x170000CA")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000905")]
			[Address(RVA = "0x830768", Offset = "0x830768", VA = "0x830768", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CB")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000907")]
			[Address(RVA = "0x8307D0", Offset = "0x8307D0", VA = "0x8307D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000902")]
		[Address(RVA = "0x82EDF0", Offset = "0x82EDF0", VA = "0x82EDF0")]
		[DebuggerHidden]
		public <UpdatePlaybackPosition>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x6000903")]
		[Address(RVA = "0x830510", Offset = "0x830510", VA = "0x830510", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000904")]
		[Address(RVA = "0x830514", Offset = "0x830514", VA = "0x830514", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000906")]
		[Address(RVA = "0x830770", Offset = "0x830770", VA = "0x830770", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000138")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static CinemaListenerExample instance;

	[Token(Token = "0x4000139")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool playing;

	[Token(Token = "0x400013A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool cinemaConnected;

	[Token(Token = "0x400013B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private long currentVideoLength;

	[Token(Token = "0x400013C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private string playingProjectId;

	[Token(Token = "0x400013D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<string> downloadingProjects;

	[Token(Token = "0x400013E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private List<float> projectSize;

	[Token(Token = "0x400013F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float finishedDownloadingSize;

	[Token(Token = "0x4000140")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Coroutine updatingDownloadProgress;

	[Token(Token = "0x4000141")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Coroutine updatingPlaybackPosition;

	[Token(Token = "0x4000142")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public List<string> downloadQueue;

	[Token(Token = "0x4000143")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public string deviceName;

	[Token(Token = "0x4000144")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public string message;

	[Token(Token = "0x6000176")]
	[Address(RVA = "0x82E2F8", Offset = "0x82E2F8", VA = "0x82E2F8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0x82E778", Offset = "0x82E778", VA = "0x82E778")]
	private string GetCurrentStatus()
	{
		return null;
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0x82E8D0", Offset = "0x82E8D0", VA = "0x82E8D0")]
	private string GetProjectTitle(string projectId)
	{
		return null;
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0x82E9A8", Offset = "0x82E9A8", VA = "0x82E9A8")]
	private void Update()
	{
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0x82EABC", Offset = "0x82EABC", VA = "0x82EABC")]
	private void TrackDownloadProgress(string projectId)
	{
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0x82EC48", Offset = "0x82EC48", VA = "0x82EC48")]
	private void UntrackDownloadProgress(string projectId, bool countDownloaded = true)
	{
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0x82EBD8", Offset = "0x82EBD8", VA = "0x82EBD8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5FDB74", Offset = "0x5FDB74")]
	private IEnumerator UpdateDownloadProgress()
	{
		return null;
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0x82ED80", Offset = "0x82ED80", VA = "0x82ED80")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5FDBD8", Offset = "0x5FDBD8")]
	private IEnumerator UpdatePlaybackPosition()
	{
		return null;
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0x82EE1C", Offset = "0x82EE1C", VA = "0x82EE1C")]
	public CinemaListenerExample()
	{
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0x82EEC4", Offset = "0x82EEC4", VA = "0x82EEC4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FDC3C", Offset = "0x5FDC3C")]
	private void <OnEnable>b__13_0(JSONArray args)
	{
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0x82EFD0", Offset = "0x82EFD0", VA = "0x82EFD0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FDC4C", Offset = "0x5FDC4C")]
	private void <OnEnable>b__13_1(JSONArray args)
	{
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0x82F26C", Offset = "0x82F26C", VA = "0x82F26C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FDC5C", Offset = "0x5FDC5C")]
	private void <OnEnable>b__13_2(JSONArray args)
	{
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0x82F434", Offset = "0x82F434", VA = "0x82F434")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FDC6C", Offset = "0x5FDC6C")]
	private void <OnEnable>b__13_3(JSONArray args)
	{
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0x82F68C", Offset = "0x82F68C", VA = "0x82F68C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FDC7C", Offset = "0x5FDC7C")]
	private void <OnEnable>b__13_4(JSONArray args)
	{
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0x82F7AC", Offset = "0x82F7AC", VA = "0x82F7AC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FDC8C", Offset = "0x5FDC8C")]
	private void <OnEnable>b__13_5(JSONArray <p0>)
	{
	}

	[Token(Token = "0x6000185")]
	[Address(RVA = "0x82F924", Offset = "0x82F924", VA = "0x82F924")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FDC9C", Offset = "0x5FDC9C")]
	private void <OnEnable>b__13_6(JSONArray <p0>)
	{
	}

	[Token(Token = "0x6000186")]
	[Address(RVA = "0x82FA84", Offset = "0x82FA84", VA = "0x82FA84")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FDCAC", Offset = "0x5FDCAC")]
	private void <OnEnable>b__13_7(JSONArray <p0>)
	{
	}

	[Token(Token = "0x6000187")]
	[Address(RVA = "0x82FBE4", Offset = "0x82FBE4", VA = "0x82FBE4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FDCBC", Offset = "0x5FDCBC")]
	private void <OnEnable>b__13_9(JSONArray args)
	{
	}
}
[Token(Token = "0x200003C")]
public class CinemaMenuText : MonoBehaviour
{
	[Token(Token = "0x4000145")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TextMeshProUGUI message;

	[Token(Token = "0x4000146")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI deviceName;

	[Token(Token = "0x4000147")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI sizeText;

	[Token(Token = "0x4000148")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public TextMeshProUGUI projectsText;

	[Token(Token = "0x4000149")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private CinemaListenerExample cinemaListener;

	[Token(Token = "0x400014A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private CinemaHandler cinemaHandler;

	[Token(Token = "0x400014B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject progressObject;

	[Token(Token = "0x400014C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public RawImage bar;

	[Token(Token = "0x400014D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Material barMaterial;

	[Token(Token = "0x6000188")]
	[Address(RVA = "0x8307D8", Offset = "0x8307D8", VA = "0x8307D8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000189")]
	[Address(RVA = "0x830868", Offset = "0x830868", VA = "0x830868")]
	private void Update()
	{
	}

	[Token(Token = "0x600018A")]
	[Address(RVA = "0x830E40", Offset = "0x830E40", VA = "0x830E40")]
	public CinemaMenuText()
	{
	}
}
[Token(Token = "0x200003D")]
public class CloseButton : MonoBehaviour
{
	[Token(Token = "0x400014E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public RawImage closeImage;

	[Token(Token = "0x400014F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Button button;

	[Token(Token = "0x600018B")]
	[Address(RVA = "0x830E48", Offset = "0x830E48", VA = "0x830E48")]
	private void Start()
	{
	}

	[Token(Token = "0x600018C")]
	[Address(RVA = "0x830EE0", Offset = "0x830EE0", VA = "0x830EE0")]
	private void Update()
	{
	}

	[Token(Token = "0x600018D")]
	[Address(RVA = "0x830F90", Offset = "0x830F90", VA = "0x830F90")]
	public CloseButton()
	{
	}
}
[Token(Token = "0x200003E")]
public class CreateCamera : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000150")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB0D4", Offset = "0x5FB0D4")]
	private sealed class <>c
	{
		[Token(Token = "0x400067B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x400067C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static OnEnd <>9__0_0;

		[Token(Token = "0x6000909")]
		[Address(RVA = "0x83110C", Offset = "0x83110C", VA = "0x83110C")]
		public <>c()
		{
		}

		[Token(Token = "0x600090A")]
		[Address(RVA = "0x831114", Offset = "0x831114", VA = "0x831114")]
		internal void <Start>b__0_0(bool s, string e)
		{
		}
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0x830F98", Offset = "0x830F98", VA = "0x830F98")]
	private void Start()
	{
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0x83109C", Offset = "0x83109C", VA = "0x83109C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000190")]
	[Address(RVA = "0x8310A0", Offset = "0x8310A0", VA = "0x8310A0")]
	public CreateCamera()
	{
	}
}
[Token(Token = "0x200003F")]
public class CustomSubtitles : MonoBehaviour
{
	[Token(Token = "0x2000151")]
	public delegate void OnSRTLoaded();

	[Serializable]
	[Token(Token = "0x2000152")]
	public struct TextBlock
	{
		[Token(Token = "0x400067D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string text;

		[Token(Token = "0x400067E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int start;

		[Token(Token = "0x400067F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int end;
	}

	[Token(Token = "0x2000153")]
	public enum SRTLoadMode
	{
		[Token(Token = "0x4000681")]
		FullPath,
		[Token(Token = "0x4000682")]
		StreamingAssets,
		[Token(Token = "0x4000683")]
		Resources
	}

	[Token(Token = "0x2000154")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB0E4", Offset = "0x5FB0E4")]
	private sealed class <LoadSrt>d__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CustomSubtitles <>4__this;

		[Token(Token = "0x4000687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SRTLoadMode LoadMode;

		[Token(Token = "0x4000688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string filename;

		[Token(Token = "0x4000689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string[] <splitter>5__2;

		[Token(Token = "0x400068A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string[] <allText>5__3;

		[Token(Token = "0x400068B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool <ready>5__4;

		[Token(Token = "0x400068C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int <currentLine>5__5;

		[Token(Token = "0x400068D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int <currentBlock>5__6;

		[Token(Token = "0x170000CC")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000912")]
			[Address(RVA = "0x7A51C8", Offset = "0x7A51C8", VA = "0x7A51C8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CD")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000914")]
			[Address(RVA = "0x7A5230", Offset = "0x7A5230", VA = "0x7A5230", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600090F")]
		[Address(RVA = "0x7A4C94", Offset = "0x7A4C94", VA = "0x7A4C94")]
		[DebuggerHidden]
		public <LoadSrt>d__28(int <>1__state)
		{
		}

		[Token(Token = "0x6000910")]
		[Address(RVA = "0x7A4CC0", Offset = "0x7A4CC0", VA = "0x7A4CC0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000911")]
		[Address(RVA = "0x7A4CC4", Offset = "0x7A4CC4", VA = "0x7A4CC4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000913")]
		[Address(RVA = "0x7A51D0", Offset = "0x7A51D0", VA = "0x7A51D0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000150")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static CustomSubtitles Instance;

	[Token(Token = "0x4000151")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Font font;

	[Token(Token = "0x4000152")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Color FontColor;

	[Token(Token = "0x4000153")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Color OutlineColor;

	[Token(Token = "0x4000154")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Vector3 camForward;

	[Token(Token = "0x4000155")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public bool Ready;

	[Token(Token = "0x4000156")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
	public bool disableRendering;

	[Token(Token = "0x4000157")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Text targetMesh;

	[Token(Token = "0x4000158")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public RawImage block;

	[Token(Token = "0x4000159")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public int currentTime;

	[Token(Token = "0x400015A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public int currentSubId;

	[Token(Token = "0x400015B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public int previousSubId;

	[Token(Token = "0x400015C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private bool UpdateRotation;

	[Token(Token = "0x400015D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public List<TextBlock> list;

	[Token(Token = "0x400015E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private int blockSize;

	[Token(Token = "0x400015F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private int SeekAt;

	[Token(Token = "0x4000160")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private int TimeOut;

	[Token(Token = "0x4000161")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private int m;

	[Token(Token = "0x4000162")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private string returnString;

	[Token(Token = "0x6000191")]
	[Address(RVA = "0x8BBFE0", Offset = "0x8BBFE0", VA = "0x8BBFE0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000192")]
	[Address(RVA = "0x8BC078", Offset = "0x8BC078", VA = "0x8BC078")]
	public void Load(string filename, SRTLoadMode loadMode = SRTLoadMode.FullPath, [Optional] OnSRTLoaded onLoaded)
	{
	}

	[Token(Token = "0x6000193")]
	[Address(RVA = "0x8BC054", Offset = "0x8BC054", VA = "0x8BC054")]
	public void SetColor(Color inner)
	{
	}

	[Token(Token = "0x6000194")]
	[Address(RVA = "0x8BC1C4", Offset = "0x8BC1C4", VA = "0x8BC1C4")]
	public void UpdateSubtitles(int timeMS)
	{
	}

	[Token(Token = "0x6000195")]
	[Address(RVA = "0x8BC354", Offset = "0x8BC354", VA = "0x8BC354")]
	public string getSubtitle(int seek)
	{
		return null;
	}

	[Token(Token = "0x6000196")]
	[Address(RVA = "0x8BC4D4", Offset = "0x8BC4D4", VA = "0x8BC4D4")]
	private int match(int block, int seek)
	{
		return default(int);
	}

	[Token(Token = "0x6000197")]
	[Address(RVA = "0x8BC13C", Offset = "0x8BC13C", VA = "0x8BC13C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5FDCCC", Offset = "0x5FDCCC")]
	private IEnumerator LoadSrt(string filename, SRTLoadMode LoadMode = SRTLoadMode.FullPath, [Optional] OnSRTLoaded onLoaded)
	{
		return null;
	}

	[Token(Token = "0x6000198")]
	[Address(RVA = "0x8BC594", Offset = "0x8BC594", VA = "0x8BC594")]
	private int timeStampToMilliseconds(string timeStamp)
	{
		return default(int);
	}

	[Token(Token = "0x6000199")]
	[Address(RVA = "0x8BC65C", Offset = "0x8BC65C", VA = "0x8BC65C")]
	public CustomSubtitles()
	{
	}
}
[Token(Token = "0x2000040")]
public class DaydreamQuit : MonoBehaviour
{
	[Token(Token = "0x4000163")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static DaydreamQuit instance;

	[Token(Token = "0x17000038")]
	public static DaydreamQuit Instance
	{
		[Token(Token = "0x600019A")]
		[Address(RVA = "0x7B0E28", Offset = "0x7B0E28", VA = "0x7B0E28")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600019B")]
	[Address(RVA = "0x7B0E78", Offset = "0x7B0E78", VA = "0x7B0E78")]
	private void Awake()
	{
	}

	[Token(Token = "0x600019C")]
	[Address(RVA = "0x7B0F7C", Offset = "0x7B0F7C", VA = "0x7B0F7C")]
	private void Update()
	{
	}

	[Token(Token = "0x600019D")]
	[Address(RVA = "0x7B1064", Offset = "0x7B1064", VA = "0x7B1064")]
	public DaydreamQuit()
	{
	}
}
[Token(Token = "0x2000041")]
public class DebugFrameCount : MonoBehaviour
{
	[Token(Token = "0x4000164")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TextMeshProUGUI debugFrameCount;

	[Token(Token = "0x4000165")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int counter;

	[Token(Token = "0x4000166")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private long averageTotal;

	[Token(Token = "0x4000167")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private long averageCount;

	[Token(Token = "0x600019E")]
	[Address(RVA = "0x7B106C", Offset = "0x7B106C", VA = "0x7B106C")]
	private void Start()
	{
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0x7B11A0", Offset = "0x7B11A0", VA = "0x7B11A0")]
	private void Update()
	{
	}

	[Token(Token = "0x60001A0")]
	[Address(RVA = "0x7B15F8", Offset = "0x7B15F8", VA = "0x7B15F8")]
	public DebugFrameCount()
	{
	}
}
[Token(Token = "0x2000042")]
public class EssentialsManager : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000155")]
	public class ProjectCollection
	{
		[Token(Token = "0x400068E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string categoryId;

		[Token(Token = "0x400068F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string[] projects;

		[Token(Token = "0x6000915")]
		[Address(RVA = "0x7B3000", Offset = "0x7B3000", VA = "0x7B3000")]
		public ProjectCollection(string categoryId, string[] projects)
		{
		}
	}

	[Token(Token = "0x2000156")]
	public enum Template
	{
		[Token(Token = "0x4000691")]
		AllInOne,
		[Token(Token = "0x4000692")]
		Grid,
		[Token(Token = "0x4000693")]
		Cinema,
		[Token(Token = "0x4000694")]
		Kiosk
	}

	[Serializable]
	[Token(Token = "0x2000157")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB0F4", Offset = "0x5FB0F4")]
	private sealed class <>c
	{
		[Token(Token = "0x4000695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static OnEnd <>9__18_0;

		[Token(Token = "0x6000917")]
		[Address(RVA = "0x7B359C", Offset = "0x7B359C", VA = "0x7B359C")]
		public <>c()
		{
		}

		[Token(Token = "0x6000918")]
		[Address(RVA = "0x7B35A4", Offset = "0x7B35A4", VA = "0x7B35A4")]
		internal void <Start>b__18_0(bool s, string e)
		{
		}
	}

	[Token(Token = "0x4000168")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static EssentialsVariables variables;

	[Token(Token = "0x4000169")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Template template;

	[Token(Token = "0x400016A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public EssentialsVariables loadedVariables;

	[Token(Token = "0x400016B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public LandingPage landingPage;

	[Token(Token = "0x400016C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ProjectPage projectPage;

	[Token(Token = "0x400016D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Animator landingPageAnimator;

	[Token(Token = "0x400016E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Animator projectPageAnimator;

	[Token(Token = "0x400016F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public List<ProjectCollection> categories;

	[Token(Token = "0x4000170")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public ProjectCollection uncategorized;

	[Token(Token = "0x4000171")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Headjack.CurvedUI curvedUI;

	[Token(Token = "0x4000172")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public MeshRenderer backgroundPanoLeft;

	[Token(Token = "0x4000173")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public MeshRenderer backgroundPanoRight;

	[Token(Token = "0x4000174")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public RawImage logoOnTop;

	[Token(Token = "0x4000175")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public KioskSelect kioskSelect;

	[Token(Token = "0x4000176")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public MeshRenderer environment;

	[Token(Token = "0x4000177")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public AudioSource audioSource;

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0x7B241C", Offset = "0x7B241C", VA = "0x7B241C")]
	private void Start()
	{
	}

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0x7B3038", Offset = "0x7B3038", VA = "0x7B3038")]
	public void ShowProject(string id)
	{
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0x7B311C", Offset = "0x7B311C", VA = "0x7B311C")]
	public void DownloadSubtitles(string projectId)
	{
	}

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0x7B31D0", Offset = "0x7B31D0", VA = "0x7B31D0")]
	private void DownloadSubtitle(string var, string project)
	{
	}

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0x7B32F0", Offset = "0x7B32F0", VA = "0x7B32F0")]
	public void ShowLandingPage()
	{
	}

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0x7B33BC", Offset = "0x7B33BC", VA = "0x7B33BC")]
	private void Update()
	{
	}

	[Token(Token = "0x60001A7")]
	[Address(RVA = "0x7B3530", Offset = "0x7B3530", VA = "0x7B3530")]
	public EssentialsManager()
	{
	}
}
[Serializable]
[Token(Token = "0x2000043")]
public class EssentialsVariables
{
	[Token(Token = "0x4000178")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool disableMediaControls;

	[Token(Token = "0x4000179")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	public bool kioskGazeMenu;

	[Token(Token = "0x400017A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string backgroundPano;

	[Token(Token = "0x400017B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool backgroundStereo;

	[Token(Token = "0x400017C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string logoOnTop;

	[Token(Token = "0x400017D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Color color1;

	[Token(Token = "0x400017E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Color color2;

	[Token(Token = "0x400017F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Color color3;

	[Token(Token = "0x4000180")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public bool kioskAutoPlay;

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0x7B36EC", Offset = "0x7B36EC", VA = "0x7B36EC")]
	public EssentialsVariables()
	{
	}
}
[Token(Token = "0x2000044")]
public class GazeFill : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	[Serializable]
	[Token(Token = "0x2000158")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB104", Offset = "0x5FB104")]
	private sealed class <>c
	{
		[Token(Token = "0x4000697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static OnEnd <>9__9_1;

		[Token(Token = "0x600091A")]
		[Address(RVA = "0x7B4E98", Offset = "0x7B4E98", VA = "0x7B4E98")]
		public <>c()
		{
		}

		[Token(Token = "0x600091B")]
		[Address(RVA = "0x7B4EA0", Offset = "0x7B4EA0", VA = "0x7B4EA0")]
		internal void <Update>b__9_1(bool ss, string ee)
		{
		}
	}

	[Token(Token = "0x4000181")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ProjectInstance projectInstance;

	[Token(Token = "0x4000182")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool highlight;

	[Token(Token = "0x4000183")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public RawImage rawImage;

	[Token(Token = "0x4000184")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float fill;

	[Token(Token = "0x4000185")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Material mat;

	[Token(Token = "0x60001A9")]
	[Address(RVA = "0x7B4A24", Offset = "0x7B4A24", VA = "0x7B4A24")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0x7B4AD0", Offset = "0x7B4AD0", VA = "0x7B4AD0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60001AB")]
	[Address(RVA = "0x7B4AD8", Offset = "0x7B4AD8", VA = "0x7B4AD8", Slot = "4")]
	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0x7B4AE4", Offset = "0x7B4AE4", VA = "0x7B4AE4", Slot = "5")]
	public void OnPointerExit(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0x7B4AEC", Offset = "0x7B4AEC", VA = "0x7B4AEC")]
	private void Update()
	{
	}

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0x7B4CD8", Offset = "0x7B4CD8", VA = "0x7B4CD8")]
	public GazeFill()
	{
	}

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0x7B4CE0", Offset = "0x7B4CE0", VA = "0x7B4CE0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FDD30", Offset = "0x5FDD30")]
	private void <Update>b__9_0(bool s, string e)
	{
	}
}
[Token(Token = "0x2000045")]
public class GazeScroll : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	[Token(Token = "0x2000159")]
	public enum ScrollDirection
	{
		[Token(Token = "0x400069A")]
		None,
		[Token(Token = "0x400069B")]
		Up,
		[Token(Token = "0x400069C")]
		Down
	}

	[Token(Token = "0x4000186")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ScrollDirection scrollDirection;

	[Token(Token = "0x4000187")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Button scrollButton;

	[Token(Token = "0x4000188")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public KioskSelect kioskSelect;

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0x7B51C8", Offset = "0x7B51C8", VA = "0x7B51C8", Slot = "4")]
	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60001B1")]
	[Address(RVA = "0x7B520C", Offset = "0x7B520C", VA = "0x7B520C", Slot = "5")]
	public void OnPointerExit(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60001B2")]
	[Address(RVA = "0x7B522C", Offset = "0x7B522C", VA = "0x7B522C")]
	public GazeScroll()
	{
	}
}
[Token(Token = "0x2000046")]
public class GridCellSize : MonoBehaviour
{
	[Token(Token = "0x4000189")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GridLayoutGroup grid;

	[Token(Token = "0x400018A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public RectTransform targetSize;

	[Token(Token = "0x400018B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public RectTransform scrollViewRect;

	[Token(Token = "0x400018C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public RectTransform verticalLayoutRect;

	[Token(Token = "0x60001B3")]
	[Address(RVA = "0x7B5B58", Offset = "0x7B5B58", VA = "0x7B5B58")]
	public void UpdateGrid(bool noCategories = true)
	{
	}

	[Token(Token = "0x60001B4")]
	[Address(RVA = "0x7B6014", Offset = "0x7B6014", VA = "0x7B6014")]
	public GridCellSize()
	{
	}
}
[Token(Token = "0x2000047")]
public class Kiosk : MonoBehaviour
{
	[Token(Token = "0x200015A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB114", Offset = "0x5FB114")]
	private sealed class <>c__DisplayClass17_0
	{
		[Token(Token = "0x400069D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Kiosk <>4__this;

		[Token(Token = "0x400069E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string[] projectsList;

		[Token(Token = "0x600091C")]
		[Address(RVA = "0x7CC398", Offset = "0x7CC398", VA = "0x7CC398")]
		public <>c__DisplayClass17_0()
		{
		}

		[Token(Token = "0x600091D")]
		[Address(RVA = "0x7CCB74", Offset = "0x7CCB74", VA = "0x7CCB74")]
		internal void <DownloadSingleProject>b__0(bool downloadSuccess, string downloadError)
		{
		}

		[Token(Token = "0x600091E")]
		[Address(RVA = "0x7CCCA0", Offset = "0x7CCCA0", VA = "0x7CCCA0")]
		internal void <DownloadSingleProject>b__1(bool confirm)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200015B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB124", Offset = "0x5FB124")]
	private sealed class <>c
	{
		[Token(Token = "0x400069F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x40006A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static OnEnd <>9__18_0;

		[Token(Token = "0x6000920")]
		[Address(RVA = "0x7CCB0C", Offset = "0x7CCB0C", VA = "0x7CCB0C")]
		public <>c()
		{
		}

		[Token(Token = "0x6000921")]
		[Address(RVA = "0x7CCB14", Offset = "0x7CCB14", VA = "0x7CCB14")]
		internal void <Play>b__18_0(bool s, string e)
		{
		}
	}

	[Token(Token = "0x400018D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool canSelect;

	[Token(Token = "0x400018E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public EssentialsManager essentialsManager;

	[Token(Token = "0x400018F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string[] projects;

	[Token(Token = "0x4000190")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<string> projectsToDownload;

	[Token(Token = "0x4000191")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool downloading;

	[Token(Token = "0x4000192")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public int projectsFinished;

	[Token(Token = "0x4000193")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private double totalSize;

	[Token(Token = "0x4000194")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TextMeshProUGUI progressA;

	[Token(Token = "0x4000195")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public TextMeshProUGUI progressB;

	[Token(Token = "0x4000196")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public TextMeshProUGUI notReadyText;

	[Token(Token = "0x4000197")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Animator animator;

	[Token(Token = "0x4000198")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public RawImage progressBar;

	[Token(Token = "0x4000199")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public KioskSelect kioskSelect;

	[Token(Token = "0x400019A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Dictionary<string, App.ProjectMetadata> projectMetadataCache;

	[Token(Token = "0x60001B5")]
	[Address(RVA = "0x7CB940", Offset = "0x7CB940", VA = "0x7CB940")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001B6")]
	[Address(RVA = "0x7CBAD8", Offset = "0x7CBAD8", VA = "0x7CBAD8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60001B7")]
	[Address(RVA = "0x7CC098", Offset = "0x7CC098", VA = "0x7CC098")]
	public void Download()
	{
	}

	[Token(Token = "0x60001B8")]
	[Address(RVA = "0x7CC128", Offset = "0x7CC128", VA = "0x7CC128")]
	private void DownloadSingleProject(string[] projectsList)
	{
	}

	[Token(Token = "0x60001B9")]
	[Address(RVA = "0x7CBF9C", Offset = "0x7CBF9C", VA = "0x7CBF9C")]
	public void Play()
	{
	}

	[Token(Token = "0x60001BA")]
	[Address(RVA = "0x7CC3A0", Offset = "0x7CC3A0", VA = "0x7CC3A0")]
	public void Cancel()
	{
	}

	[Token(Token = "0x60001BB")]
	[Address(RVA = "0x7CC59C", Offset = "0x7CC59C", VA = "0x7CC59C")]
	private void Update()
	{
	}

	[Token(Token = "0x60001BC")]
	[Address(RVA = "0x7CC964", Offset = "0x7CC964", VA = "0x7CC964")]
	public Kiosk()
	{
	}

	[Token(Token = "0x60001BD")]
	[Address(RVA = "0x7CC97C", Offset = "0x7CC97C", VA = "0x7CC97C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FDD40", Offset = "0x5FDD40")]
	private void <Cancel>b__19_0(bool confirm)
	{
	}
}
[Token(Token = "0x2000048")]
public class KioskSelect : MonoBehaviour
{
	[Token(Token = "0x400019B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GridCellSize gridCellSize;

	[Token(Token = "0x400019C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ProjectInstance projectInstancePrefab;

	[Token(Token = "0x400019D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<ProjectInstance> projectInstances;

	[Token(Token = "0x400019E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Button scrollUp;

	[Token(Token = "0x400019F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Button scrollDown;

	[Token(Token = "0x40001A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public RectTransform gridRect;

	[Token(Token = "0x40001A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float scrollRate;

	[Token(Token = "0x40001A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private float minScrollPos;

	[Token(Token = "0x40001A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float preferredHeight;

	[Token(Token = "0x40001A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private float maxScrollPos;

	[Token(Token = "0x40001A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private int projectCount;

	[Token(Token = "0x40001A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private GazeScroll.ScrollDirection previousScrollDirection;

	[Token(Token = "0x40001A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private GazeScroll.ScrollDirection currentScrollDirection;

	[Token(Token = "0x40001A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private float scrollTarget;

	[Token(Token = "0x60001BE")]
	[Address(RVA = "0x7CCCB8", Offset = "0x7CCCB8", VA = "0x7CCCB8")]
	public void Initialize(EssentialsManager essentialsManager)
	{
	}

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0x7CD0C0", Offset = "0x7CD0C0", VA = "0x7CD0C0")]
	public void SetScrollDirection(GazeScroll.ScrollDirection newScrollDirection)
	{
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0x7CD210", Offset = "0x7CD210", VA = "0x7CD210")]
	public void ScrollUp()
	{
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0x7CD2E4", Offset = "0x7CD2E4", VA = "0x7CD2E4")]
	public void ScrollDown()
	{
	}

	[Token(Token = "0x60001C2")]
	[Address(RVA = "0x7CD3BC", Offset = "0x7CD3BC", VA = "0x7CD3BC")]
	private void Update()
	{
	}

	[Token(Token = "0x60001C3")]
	[Address(RVA = "0x7CD78C", Offset = "0x7CD78C", VA = "0x7CD78C")]
	public KioskSelect()
	{
	}
}
[Token(Token = "0x2000049")]
public class LandingPage : MonoBehaviour
{
	[Token(Token = "0x40001A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public EssentialsManager essentialsManager;

	[Token(Token = "0x40001AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Canvas canvas;

	[Token(Token = "0x40001AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public RectTransform allContent;

	[Token(Token = "0x40001AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GridCellSize gridCellSize;

	[Token(Token = "0x40001AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ProjectInstance projectInstanceTemplate;

	[Token(Token = "0x40001AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public CategoryRow categoryRowTemplate;

	[Token(Token = "0x40001AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public List<ProjectInstance> projects;

	[Token(Token = "0x40001B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public ScrollRect scrollRect;

	[Token(Token = "0x40001B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public VerticalLayoutGroup scrollVerticalLayoutGroup;

	[Token(Token = "0x40001B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public MeshCollider curvedCollider;

	[Token(Token = "0x40001B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public ScrollBarEssentials scrollBarEssentials;

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0x7CD7A4", Offset = "0x7CD7A4", VA = "0x7CD7A4")]
	public void Initialize()
	{
	}

	[Token(Token = "0x60001C5")]
	[Address(RVA = "0x7CDF54", Offset = "0x7CDF54", VA = "0x7CDF54")]
	public void BlockInput()
	{
	}

	[Token(Token = "0x60001C6")]
	[Address(RVA = "0x7CDF74", Offset = "0x7CDF74", VA = "0x7CDF74")]
	public void AllowInput()
	{
	}

	[Token(Token = "0x60001C7")]
	[Address(RVA = "0x7CDF94", Offset = "0x7CDF94", VA = "0x7CDF94")]
	public LandingPage()
	{
	}
}
[Token(Token = "0x200004A")]
public class MetaData : MonoBehaviour
{
	[Token(Token = "0x40001B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TextMeshProUGUI duration;

	[Token(Token = "0x40001B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI stereo;

	[Token(Token = "0x40001B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI ambisonics;

	[Token(Token = "0x40001B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ProjectButton downloadButton;

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0x7D0830", Offset = "0x7D0830", VA = "0x7D0830")]
	public void Initialize(string projectId)
	{
	}

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0x7D0A9C", Offset = "0x7D0A9C", VA = "0x7D0A9C")]
	public MetaData()
	{
	}
}
[Token(Token = "0x200004B")]
public class PlaySoundHighlight : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerClickHandler
{
	[Token(Token = "0x40001B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioClip highlightSound;

	[Token(Token = "0x40001B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AudioClip clickSound;

	[Token(Token = "0x40001BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public EssentialsManager essentialsManager;

	[Token(Token = "0x40001BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public AudioSource overrideAudioSource;

	[Token(Token = "0x60001CA")]
	[Address(RVA = "0x7D0CD0", Offset = "0x7D0CD0", VA = "0x7D0CD0", Slot = "5")]
	public void OnPointerClick(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0x7D0DF0", Offset = "0x7D0DF0", VA = "0x7D0DF0", Slot = "4")]
	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0x7D0CD8", Offset = "0x7D0CD8", VA = "0x7D0CD8")]
	private void PlaySound(AudioClip clip)
	{
	}

	[Token(Token = "0x60001CD")]
	[Address(RVA = "0x7D0DF8", Offset = "0x7D0DF8", VA = "0x7D0DF8")]
	public PlaySoundHighlight()
	{
	}
}
[Token(Token = "0x200004C")]
public class PopupMessage : MonoBehaviour
{
	[Token(Token = "0x200015C")]
	public delegate void Callback(bool playerConfirmed);

	[Token(Token = "0x200015D")]
	public enum ButtonMode
	{
		[Token(Token = "0x40006A2")]
		None,
		[Token(Token = "0x40006A3")]
		Confirm,
		[Token(Token = "0x40006A4")]
		YesNo
	}

	[Token(Token = "0x200015E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB134", Offset = "0x5FB134")]
	private sealed class <ShowMessage>d__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40006A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40006A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40006A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ButtonMode buttonMode;

		[Token(Token = "0x40006A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public PopupMessage <>4__this;

		[Token(Token = "0x40006A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Callback callback;

		[Token(Token = "0x170000CE")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000929")]
			[Address(RVA = "0x7D1C64", Offset = "0x7D1C64", VA = "0x7D1C64", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CF")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600092B")]
			[Address(RVA = "0x7D1CCC", Offset = "0x7D1CCC", VA = "0x7D1CCC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000926")]
		[Address(RVA = "0x7D17D4", Offset = "0x7D17D4", VA = "0x7D17D4")]
		[DebuggerHidden]
		public <ShowMessage>d__16(int <>1__state)
		{
		}

		[Token(Token = "0x6000927")]
		[Address(RVA = "0x7D1808", Offset = "0x7D1808", VA = "0x7D1808", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000928")]
		[Address(RVA = "0x7D180C", Offset = "0x7D180C", VA = "0x7D180C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600092A")]
		[Address(RVA = "0x7D1C6C", Offset = "0x7D1C6C", VA = "0x7D1C6C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40001BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static PopupMessage instance;

	[Token(Token = "0x40001BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject buttonConfirm;

	[Token(Token = "0x40001BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject buttonLeft;

	[Token(Token = "0x40001BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject buttonRight;

	[Token(Token = "0x40001C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Animator canvasAnimator;

	[Token(Token = "0x40001C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool waitForConfirm;

	[Token(Token = "0x40001C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	private bool waitForYes;

	[Token(Token = "0x40001C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
	private bool waitForNo;

	[Token(Token = "0x40001C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public TextMeshProUGUI messageText;

	[Token(Token = "0x60001CE")]
	[Address(RVA = "0x7D16E4", Offset = "0x7D16E4", VA = "0x7D16E4")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001CF")]
	[Address(RVA = "0x7D1738", Offset = "0x7D1738", VA = "0x7D1738")]
	public void Confirm()
	{
	}

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0x7D1740", Offset = "0x7D1740", VA = "0x7D1740")]
	public void Yes()
	{
	}

	[Token(Token = "0x60001D1")]
	[Address(RVA = "0x7D1748", Offset = "0x7D1748", VA = "0x7D1748")]
	public void No()
	{
	}

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0x7CC44C", Offset = "0x7CC44C", VA = "0x7CC44C")]
	public void Show(string message, ButtonMode buttonMode, Callback callback)
	{
	}

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0x7D1750", Offset = "0x7D1750", VA = "0x7D1750")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5FDD50", Offset = "0x5FDD50")]
	private IEnumerator ShowMessage(string message, ButtonMode buttonMode, Callback callback)
	{
		return null;
	}

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0x7D1800", Offset = "0x7D1800", VA = "0x7D1800")]
	public PopupMessage()
	{
	}
}
[Token(Token = "0x200004D")]
public class ProjectButton : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
{
	[Token(Token = "0x40001C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Button button;

	[Token(Token = "0x40001C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Texture normalTexture;

	[Token(Token = "0x40001C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Texture highlightTexture;

	[Token(Token = "0x40001C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Texture pressedTexture;

	[Token(Token = "0x40001C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Color normalColorText;

	[Token(Token = "0x40001CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Color highlightColorText;

	[Token(Token = "0x40001CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Color pressedColorText;

	[Token(Token = "0x40001CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public string normalText;

	[Token(Token = "0x40001CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public string highlightedText;

	[Token(Token = "0x40001CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public bool highlighted;

	[Token(Token = "0x40001CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
	public bool pressed;

	[Token(Token = "0x40001D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public RawImage rawImage;

	[Token(Token = "0x40001D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public TextMeshProUGUI text;

	[Token(Token = "0x40001D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public bool stayHighlighted;

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0x7D1D78", Offset = "0x7D1D78", VA = "0x7D1D78", Slot = "4")]
	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0x7D1E90", Offset = "0x7D1E90", VA = "0x7D1E90", Slot = "5")]
	public void OnPointerExit(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0x7D1FB8", Offset = "0x7D1FB8", VA = "0x7D1FB8", Slot = "6")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0x7D20D0", Offset = "0x7D20D0", VA = "0x7D20D0", Slot = "7")]
	public void OnPointerUp(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0x7D21F8", Offset = "0x7D21F8", VA = "0x7D21F8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0x7D233C", Offset = "0x7D233C", VA = "0x7D233C")]
	private void Update()
	{
	}

	[Token(Token = "0x60001DB")]
	[Address(RVA = "0x7D2418", Offset = "0x7D2418", VA = "0x7D2418")]
	public ProjectButton()
	{
	}
}
[Token(Token = "0x200004E")]
public class ProjectButtonManager : MonoBehaviour
{
	[Token(Token = "0x200015F")]
	public enum State
	{
		[Token(Token = "0x40006AB")]
		BigPlay,
		[Token(Token = "0x40006AC")]
		GotFiles,
		[Token(Token = "0x40006AD")]
		NoFiles,
		[Token(Token = "0x40006AE")]
		Downloading
	}

	[Serializable]
	[Token(Token = "0x2000160")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB144", Offset = "0x5FB144")]
	private sealed class <>c
	{
		[Token(Token = "0x40006AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x40006B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static PopupMessage.Callback <>9__21_2;

		[Token(Token = "0x40006B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static OnEnd <>9__21_1;

		[Token(Token = "0x40006B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static PopupMessage.Callback <>9__22_2;

		[Token(Token = "0x40006B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static OnEnd <>9__22_1;

		[Token(Token = "0x600092D")]
		[Address(RVA = "0x7D436C", Offset = "0x7D436C", VA = "0x7D436C")]
		public <>c()
		{
		}

		[Token(Token = "0x600092E")]
		[Address(RVA = "0x7D4374", Offset = "0x7D4374", VA = "0x7D4374")]
		internal void <Play>b__21_1(bool ss, string ee)
		{
		}

		[Token(Token = "0x600092F")]
		[Address(RVA = "0x7D44FC", Offset = "0x7D44FC", VA = "0x7D44FC")]
		internal void <Play>b__21_2(bool confirm)
		{
		}

		[Token(Token = "0x6000930")]
		[Address(RVA = "0x7D4500", Offset = "0x7D4500", VA = "0x7D4500")]
		internal void <Stream>b__22_1(bool ss, string ee)
		{
		}

		[Token(Token = "0x6000931")]
		[Address(RVA = "0x7D4688", Offset = "0x7D4688", VA = "0x7D4688")]
		internal void <Stream>b__22_2(bool confirm)
		{
		}
	}

	[Token(Token = "0x40001D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject play;

	[Token(Token = "0x40001D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject playSmall;

	[Token(Token = "0x40001D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject download;

	[Token(Token = "0x40001D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject stream;

	[Token(Token = "0x40001D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject delete;

	[Token(Token = "0x40001D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject cancel;

	[Token(Token = "0x40001D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject progress;

	[Token(Token = "0x40001DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public string projectId;

	[Token(Token = "0x40001DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public State state;

	[Token(Token = "0x40001DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public RawImage progressGraphic;

	[Token(Token = "0x40001DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public TextMeshProUGUI progressText;

	[Token(Token = "0x40001DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Animator animator;

	[Token(Token = "0x40001DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private EssentialsManager essentialsManager;

	[Token(Token = "0x40001E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Material progressMaterial;

	[Token(Token = "0x40001E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private long fileSize;

	[Token(Token = "0x60001DC")]
	[Address(RVA = "0x7D3420", Offset = "0x7D3420", VA = "0x7D3420")]
	public void Initialize(string projectId, EssentialsManager essentialsManager)
	{
	}

	[Token(Token = "0x60001DD")]
	[Address(RVA = "0x7D37D4", Offset = "0x7D37D4", VA = "0x7D37D4")]
	public void BigPlayButton()
	{
	}

	[Token(Token = "0x60001DE")]
	[Address(RVA = "0x7D3894", Offset = "0x7D3894", VA = "0x7D3894")]
	public void Download()
	{
	}

	[Token(Token = "0x60001DF")]
	[Address(RVA = "0x7D3960", Offset = "0x7D3960", VA = "0x7D3960")]
	public void Cancel()
	{
	}

	[Token(Token = "0x60001E0")]
	[Address(RVA = "0x7D3A0C", Offset = "0x7D3A0C", VA = "0x7D3A0C")]
	public void Delete()
	{
	}

	[Token(Token = "0x60001E1")]
	[Address(RVA = "0x7D3AB8", Offset = "0x7D3AB8", VA = "0x7D3AB8")]
	public void Play()
	{
	}

	[Token(Token = "0x60001E2")]
	[Address(RVA = "0x7D3B54", Offset = "0x7D3B54", VA = "0x7D3B54")]
	public void Stream()
	{
	}

	[Token(Token = "0x60001E3")]
	[Address(RVA = "0x7D3594", Offset = "0x7D3594", VA = "0x7D3594")]
	public void SetState(State state)
	{
	}

	[Token(Token = "0x60001E4")]
	[Address(RVA = "0x7D3C98", Offset = "0x7D3C98", VA = "0x7D3C98")]
	private void Update()
	{
	}

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0x7D3BF0", Offset = "0x7D3BF0", VA = "0x7D3BF0")]
	public void DeactivateAllButtons()
	{
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0x7D3E0C", Offset = "0x7D3E0C", VA = "0x7D3E0C")]
	public ProjectButtonManager()
	{
	}

	[Token(Token = "0x60001E7")]
	[Address(RVA = "0x7D3E14", Offset = "0x7D3E14", VA = "0x7D3E14")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FDDB4", Offset = "0x5FDDB4")]
	private void <Download>b__18_0(bool s, string e)
	{
	}

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0x7D3EEC", Offset = "0x7D3EEC", VA = "0x7D3EEC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FDDC4", Offset = "0x5FDDC4")]
	private void <Cancel>b__19_0(bool confirm)
	{
	}

	[Token(Token = "0x60001E9")]
	[Address(RVA = "0x7D3FD8", Offset = "0x7D3FD8", VA = "0x7D3FD8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FDDD4", Offset = "0x5FDDD4")]
	private void <Delete>b__20_0(bool confirm)
	{
	}

	[Token(Token = "0x60001EA")]
	[Address(RVA = "0x7D4070", Offset = "0x7D4070", VA = "0x7D4070")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FDDE4", Offset = "0x5FDDE4")]
	private void <Play>b__21_0(bool s, string e)
	{
	}

	[Token(Token = "0x60001EB")]
	[Address(RVA = "0x7D41BC", Offset = "0x7D41BC", VA = "0x7D41BC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FDDF4", Offset = "0x5FDDF4")]
	private void <Stream>b__22_0(bool s, string e)
	{
	}
}
[Token(Token = "0x200004F")]
public class ProjectInstance : MonoBehaviour
{
	[Token(Token = "0x40001E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string id;

	[Token(Token = "0x40001E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public RawImage rawImage;

	[Token(Token = "0x40001E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI title;

	[Token(Token = "0x40001E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public TextMeshProUGUI duration;

	[Token(Token = "0x40001E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Texture texture;

	[Token(Token = "0x40001E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private EssentialsManager essentialsManager;

	[Token(Token = "0x40001E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private App.ProjectMetadata projectMetadata;

	[Token(Token = "0x40001E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private App.VideoMetadata videoMetadata;

	[Token(Token = "0x60001EC")]
	[Address(RVA = "0x7D468C", Offset = "0x7D468C", VA = "0x7D468C")]
	public void Load(string id, EssentialsManager essentialsManager)
	{
	}

	[Token(Token = "0x60001ED")]
	[Address(RVA = "0x7D48DC", Offset = "0x7D48DC", VA = "0x7D48DC")]
	public void Show()
	{
	}

	[Token(Token = "0x60001EE")]
	[Address(RVA = "0x7D4900", Offset = "0x7D4900", VA = "0x7D4900")]
	public ProjectInstance()
	{
	}
}
[Token(Token = "0x2000050")]
public class ProjectPage : MonoBehaviour
{
	[Token(Token = "0x40001EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string currentId;

	[Token(Token = "0x40001EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public EssentialsManager essentialsManager;

	[Token(Token = "0x40001EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public LandingPage landingPage;

	[Token(Token = "0x40001ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public RectTransform myRect;

	[Token(Token = "0x40001EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Canvas canvas;

	[Token(Token = "0x40001EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public RawImage thumbnail;

	[Token(Token = "0x40001F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TextMeshProUGUI title;

	[Token(Token = "0x40001F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public TextMeshProUGUI description;

	[Token(Token = "0x40001F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public ProjectButtonManager buttonManager;

	[Token(Token = "0x40001F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public CategoryProjects categoryProjects;

	[Token(Token = "0x40001F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public float categoryHeight;

	[Token(Token = "0x40001F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject otherVideos;

	[Token(Token = "0x40001F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public GameObject projectArea;

	[Token(Token = "0x40001F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public MetaData metaData;

	[Token(Token = "0x60001EF")]
	[Address(RVA = "0x7D4D8C", Offset = "0x7D4D8C", VA = "0x7D4D8C")]
	public void ShowProject(string id)
	{
	}

	[Token(Token = "0x60001F0")]
	[Address(RVA = "0x7D5000", Offset = "0x7D5000", VA = "0x7D5000")]
	public void SwitchInCategory(string id)
	{
	}

	[Token(Token = "0x60001F1")]
	[Address(RVA = "0x7D5154", Offset = "0x7D5154", VA = "0x7D5154")]
	public ProjectPage()
	{
	}
}
[Token(Token = "0x2000051")]
public class ScrollBarEssentials : MonoBehaviour
{
	[Token(Token = "0x40001F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public EssentialsManager essentialsManager;

	[Token(Token = "0x40001F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform top;

	[Token(Token = "0x40001FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform bottom;

	[Token(Token = "0x40001FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform allContent;

	[Token(Token = "0x40001FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public RawImage scrollBarSprite1;

	[Token(Token = "0x40001FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public RawImage scrollBarSprite2;

	[Token(Token = "0x40001FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float size;

	[Token(Token = "0x60001F2")]
	[Address(RVA = "0x7E3328", Offset = "0x7E3328", VA = "0x7E3328")]
	private void Start()
	{
	}

	[Token(Token = "0x60001F3")]
	[Address(RVA = "0x7E3404", Offset = "0x7E3404", VA = "0x7E3404")]
	private void Update()
	{
	}

	[Token(Token = "0x60001F4")]
	[Address(RVA = "0x7E3550", Offset = "0x7E3550", VA = "0x7E3550")]
	public ScrollBarEssentials()
	{
	}
}
[Token(Token = "0x2000052")]
public class ScrollRectNoDrag : ScrollRect
{
	[Token(Token = "0x60001F5")]
	[Address(RVA = "0x7E3558", Offset = "0x7E3558", VA = "0x7E3558", Slot = "44")]
	public override void OnBeginDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60001F6")]
	[Address(RVA = "0x7E355C", Offset = "0x7E355C", VA = "0x7E355C", Slot = "46")]
	public override void OnDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60001F7")]
	[Address(RVA = "0x7E3560", Offset = "0x7E3560", VA = "0x7E3560", Slot = "45")]
	public override void OnEndDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60001F8")]
	[Address(RVA = "0x7E3564", Offset = "0x7E3564", VA = "0x7E3564")]
	public ScrollRectNoDrag()
	{
	}
}
[Token(Token = "0x2000053")]
public class Splash : MonoBehaviour
{
	[Token(Token = "0x2000161")]
	public enum SplashAnimationType
	{
		[Token(Token = "0x40006B5")]
		Show,
		[Token(Token = "0x40006B6")]
		Hide
	}

	[Token(Token = "0x2000162")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB154", Offset = "0x5FB154")]
	private sealed class <WaitLoadNextScene>d__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40006B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40006B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40006B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Splash <>4__this;

		[Token(Token = "0x170000D0")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000935")]
			[Address(RVA = "0x7E73B8", Offset = "0x7E73B8", VA = "0x7E73B8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D1")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000937")]
			[Address(RVA = "0x7E7420", Offset = "0x7E7420", VA = "0x7E7420", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000932")]
		[Address(RVA = "0x7E5F40", Offset = "0x7E5F40", VA = "0x7E5F40")]
		[DebuggerHidden]
		public <WaitLoadNextScene>d__15(int <>1__state)
		{
		}

		[Token(Token = "0x6000933")]
		[Address(RVA = "0x7E6E84", Offset = "0x7E6E84", VA = "0x7E6E84", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000934")]
		[Address(RVA = "0x7E6E88", Offset = "0x7E6E88", VA = "0x7E6E88", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000936")]
		[Address(RVA = "0x7E73C0", Offset = "0x7E73C0", VA = "0x7E73C0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000163")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB164", Offset = "0x5FB164")]
	private sealed class <waitTime>d__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40006BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40006BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40006BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float time;

		[Token(Token = "0x40006BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action callBack;

		[Token(Token = "0x170000D2")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600093B")]
			[Address(RVA = "0x7E7510", Offset = "0x7E7510", VA = "0x7E7510", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D3")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600093D")]
			[Address(RVA = "0x7E7578", Offset = "0x7E7578", VA = "0x7E7578", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000938")]
		[Address(RVA = "0x7E6528", Offset = "0x7E6528", VA = "0x7E6528")]
		[DebuggerHidden]
		public <waitTime>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x6000939")]
		[Address(RVA = "0x7E7428", Offset = "0x7E7428", VA = "0x7E7428", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600093A")]
		[Address(RVA = "0x7E742C", Offset = "0x7E742C", VA = "0x7E742C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600093C")]
		[Address(RVA = "0x7E7518", Offset = "0x7E7518", VA = "0x7E7518", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000164")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB174", Offset = "0x5FB174")]
	private sealed class <>c__DisplayClass21_0
	{
		[Token(Token = "0x40006BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool wait;

		[Token(Token = "0x600093E")]
		[Address(RVA = "0x7E6A00", Offset = "0x7E6A00", VA = "0x7E6A00")]
		public <>c__DisplayClass21_0()
		{
		}

		[Token(Token = "0x600093F")]
		[Address(RVA = "0x7E6A08", Offset = "0x7E6A08", VA = "0x7E6A08")]
		internal void <DownloadMediaCoroutine>b__0(bool s, string e)
		{
		}

		[Token(Token = "0x6000940")]
		[Address(RVA = "0x7E6A10", Offset = "0x7E6A10", VA = "0x7E6A10")]
		internal void <DownloadMediaCoroutine>b__1(bool s, string e)
		{
		}
	}

	[Token(Token = "0x2000165")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB184", Offset = "0x5FB184")]
	private sealed class <DownloadMediaCoroutine>d__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40006BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40006C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40006C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Splash <>4__this;

		[Token(Token = "0x40006C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private <>c__DisplayClass21_0 <>8__1;

		[Token(Token = "0x170000D4")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000944")]
			[Address(RVA = "0x7E6D6C", Offset = "0x7E6D6C", VA = "0x7E6D6C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D5")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000946")]
			[Address(RVA = "0x7E6DD4", Offset = "0x7E6DD4", VA = "0x7E6DD4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000941")]
		[Address(RVA = "0x7E65C4", Offset = "0x7E65C4", VA = "0x7E65C4")]
		[DebuggerHidden]
		public <DownloadMediaCoroutine>d__21(int <>1__state)
		{
		}

		[Token(Token = "0x6000942")]
		[Address(RVA = "0x7E6A18", Offset = "0x7E6A18", VA = "0x7E6A18", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000943")]
		[Address(RVA = "0x7E6A1C", Offset = "0x7E6A1C", VA = "0x7E6A1C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000945")]
		[Address(RVA = "0x7E6D74", Offset = "0x7E6D74", VA = "0x7E6D74", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000166")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB194", Offset = "0x5FB194")]
	private sealed class <SplashAnimation>d__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40006C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40006C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x170000D6")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600094A")]
			[Address(RVA = "0x7E6E14", Offset = "0x7E6E14", VA = "0x7E6E14", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D7")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600094C")]
			[Address(RVA = "0x7E6E7C", Offset = "0x7E6E7C", VA = "0x7E6E7C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000947")]
		[Address(RVA = "0x7E67BC", Offset = "0x7E67BC", VA = "0x7E67BC")]
		[DebuggerHidden]
		public <SplashAnimation>d__25(int <>1__state)
		{
		}

		[Token(Token = "0x6000948")]
		[Address(RVA = "0x7E6DDC", Offset = "0x7E6DDC", VA = "0x7E6DDC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000949")]
		[Address(RVA = "0x7E6DE0", Offset = "0x7E6DE0", VA = "0x7E6DE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600094B")]
		[Address(RVA = "0x7E6E1C", Offset = "0x7E6E1C", VA = "0x7E6E1C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40001FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float waitTimeBeforeLoadNextScene;

	[Token(Token = "0x4000200")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public LogIn logIn;

	[Token(Token = "0x4000201")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Animator playAfterInit;

	[Token(Token = "0x4000202")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public MeshFadeDisable blackSphere;

	[Token(Token = "0x4000203")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ProgressBar ProgressBar;

	[Token(Token = "0x4000204")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject cinemaListener;

	[Token(Token = "0x4000205")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float waitBeforeEnable;

	[Token(Token = "0x4000206")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private GameObject[] disableOnLoadingEnd;

	[Token(Token = "0x4000207")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private GameObject[] enableOnLoadingEnd;

	[Token(Token = "0x4000208")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool alreadyGotTextures;

	[Token(Token = "0x4000209")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
	private bool trackingOriginWasSet;

	[Token(Token = "0x400020A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
	private bool isInited;

	[Token(Token = "0x400020B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private float progressValue;

	[Token(Token = "0x400020C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool willShowError;

	[Token(Token = "0x400020D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
	public static bool willShowMessage;

	[Token(Token = "0x400020E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static string messageToShow;

	[Token(Token = "0x60001F9")]
	[Address(RVA = "0x7E5B68", Offset = "0x7E5B68", VA = "0x7E5B68")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001FA")]
	[Address(RVA = "0x7E5DD0", Offset = "0x7E5DD0", VA = "0x7E5DD0")]
	private void Start()
	{
	}

	[Token(Token = "0x60001FB")]
	[Address(RVA = "0x7E5ED0", Offset = "0x7E5ED0", VA = "0x7E5ED0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5FDE04", Offset = "0x5FDE04")]
	public IEnumerator WaitLoadNextScene()
	{
		return null;
	}

	[Token(Token = "0x60001FC")]
	[Address(RVA = "0x7E5F6C", Offset = "0x7E5F6C", VA = "0x7E5F6C")]
	private void OnHeadjackInitialized(bool succes, string error)
	{
	}

	[Token(Token = "0x60001FD")]
	[Address(RVA = "0x7E64A8", Offset = "0x7E64A8", VA = "0x7E64A8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5FDE68", Offset = "0x5FDE68")]
	private IEnumerator waitTime(float time, Action callBack)
	{
		return null;
	}

	[Token(Token = "0x60001FE")]
	[Address(RVA = "0x7E6554", Offset = "0x7E6554", VA = "0x7E6554")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5FDECC", Offset = "0x5FDECC")]
	private IEnumerator DownloadMediaCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60001FF")]
	[Address(RVA = "0x7E65F0", Offset = "0x7E65F0", VA = "0x7E65F0")]
	private void OnDownloadProgress(ImageLoadingState loadingState, float processed, float total)
	{
	}

	[Token(Token = "0x6000200")]
	[Address(RVA = "0x7E649C", Offset = "0x7E649C", VA = "0x7E649C")]
	private void OnAllTexturesDownloaded(bool succes, string error)
	{
	}

	[Token(Token = "0x6000201")]
	[Address(RVA = "0x7E643C", Offset = "0x7E643C", VA = "0x7E643C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5FDF30", Offset = "0x5FDF30")]
	private IEnumerator SplashAnimation(SplashAnimationType animationType)
	{
		return null;
	}

	[Token(Token = "0x6000202")]
	[Address(RVA = "0x7E67E8", Offset = "0x7E67E8", VA = "0x7E67E8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000203")]
	[Address(RVA = "0x7E691C", Offset = "0x7E691C", VA = "0x7E691C")]
	public Splash()
	{
	}

	[Token(Token = "0x6000205")]
	[Address(RVA = "0x7E6940", Offset = "0x7E6940", VA = "0x7E6940")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FDF94", Offset = "0x5FDF94")]
	private void <OnHeadjackInitialized>b__19_0()
	{
	}
}
[Token(Token = "0x2000054")]
public class SubtitleMenu : MonoBehaviour
{
	[Token(Token = "0x400020F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MainVideoControls videoControls;

	[Token(Token = "0x4000210")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public SubtitleOption subtitleOptionPrefab;

	[Token(Token = "0x4000211")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<SubtitleOption> subtitleOptions;

	[Token(Token = "0x6000206")]
	[Address(RVA = "0x7E78DC", Offset = "0x7E78DC", VA = "0x7E78DC")]
	public void Initialize(string[] options)
	{
	}

	[Token(Token = "0x6000207")]
	[Address(RVA = "0x7E7D10", Offset = "0x7E7D10", VA = "0x7E7D10")]
	public void SetActive(int subIndex)
	{
	}

	[Token(Token = "0x6000208")]
	[Address(RVA = "0x7E7E60", Offset = "0x7E7E60", VA = "0x7E7E60")]
	public SubtitleMenu()
	{
	}
}
[Token(Token = "0x2000055")]
public class SubtitleOption : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
{
	[Token(Token = "0x4000212")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text text;

	[Token(Token = "0x4000213")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int index;

	[Token(Token = "0x4000214")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public MainVideoControls mainVideoControls;

	[Token(Token = "0x4000215")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public VideoControls videoControls;

	[Token(Token = "0x4000216")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject currentSubtitleCheck;

	[Token(Token = "0x4000217")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public RawImage block;

	[Token(Token = "0x6000209")]
	[Address(RVA = "0x7E7CDC", Offset = "0x7E7CDC", VA = "0x7E7CDC")]
	public void Initialize(int index, string text)
	{
	}

	[Token(Token = "0x600020A")]
	[Address(RVA = "0x7E7E68", Offset = "0x7E7E68", VA = "0x7E7E68")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600020B")]
	[Address(RVA = "0x7E7E70", Offset = "0x7E7E70", VA = "0x7E7E70")]
	public void OnClick()
	{
	}

	[Token(Token = "0x600020C")]
	[Address(RVA = "0x7E7F34", Offset = "0x7E7F34", VA = "0x7E7F34", Slot = "4")]
	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600020D")]
	[Address(RVA = "0x7E7FA0", Offset = "0x7E7FA0", VA = "0x7E7FA0", Slot = "5")]
	public void OnPointerExit(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600020E")]
	[Address(RVA = "0x7E800C", Offset = "0x7E800C", VA = "0x7E800C", Slot = "6")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600020F")]
	[Address(RVA = "0x7E8078", Offset = "0x7E8078", VA = "0x7E8078", Slot = "7")]
	public void OnPointerUp(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000210")]
	[Address(RVA = "0x7E8158", Offset = "0x7E8158", VA = "0x7E8158")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000211")]
	[Address(RVA = "0x7E81C4", Offset = "0x7E81C4", VA = "0x7E81C4")]
	public SubtitleOption()
	{
	}
}
[Token(Token = "0x2000056")]
public class TabSwitcher : MonoBehaviour
{
	[Token(Token = "0x2000167")]
	public enum Tab
	{
		[Token(Token = "0x40006C6")]
		Grid,
		[Token(Token = "0x40006C7")]
		Cinema,
		[Token(Token = "0x40006C8")]
		Kiosk
	}

	[Token(Token = "0x4000218")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public EssentialsManager essentialsManager;

	[Token(Token = "0x4000219")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Animator animator;

	[Token(Token = "0x400021A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static Tab currentTab;

	[Token(Token = "0x400021B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ProjectButton grid;

	[Token(Token = "0x400021C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ProjectButton cinema;

	[Token(Token = "0x400021D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ProjectButton kiosk;

	[Token(Token = "0x6000212")]
	[Address(RVA = "0x7E81CC", Offset = "0x7E81CC", VA = "0x7E81CC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000213")]
	[Address(RVA = "0x7E84F4", Offset = "0x7E84F4", VA = "0x7E84F4")]
	public void ShowGrid()
	{
	}

	[Token(Token = "0x6000214")]
	[Address(RVA = "0x7E84FC", Offset = "0x7E84FC", VA = "0x7E84FC")]
	public void ShowCinema()
	{
	}

	[Token(Token = "0x6000215")]
	[Address(RVA = "0x7E8504", Offset = "0x7E8504", VA = "0x7E8504")]
	public void ShowKiosk()
	{
	}

	[Token(Token = "0x6000216")]
	[Address(RVA = "0x7E82D8", Offset = "0x7E82D8", VA = "0x7E82D8")]
	public void ShowTab(Tab tab)
	{
	}

	[Token(Token = "0x6000217")]
	[Address(RVA = "0x7E850C", Offset = "0x7E850C", VA = "0x7E850C")]
	public TabSwitcher()
	{
	}
}
[Token(Token = "0x2000057")]
public class Thumbnail : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	[Token(Token = "0x400021E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool highlighted;

	[Token(Token = "0x400021F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public RawImage rawImage;

	[Token(Token = "0x4000220")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public RawImage highlight;

	[Token(Token = "0x4000221")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Material mat;

	[Token(Token = "0x4000222")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float zoom;

	[Token(Token = "0x6000219")]
	[Address(RVA = "0x7EAD74", Offset = "0x7EAD74", VA = "0x7EAD74", Slot = "4")]
	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0x7EADB0", Offset = "0x7EADB0", VA = "0x7EADB0", Slot = "5")]
	public void OnPointerExit(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600021B")]
	[Address(RVA = "0x7EADE8", Offset = "0x7EADE8", VA = "0x7EADE8")]
	private void Start()
	{
	}

	[Token(Token = "0x600021C")]
	[Address(RVA = "0x7EAEAC", Offset = "0x7EAEAC", VA = "0x7EAEAC")]
	private void Update()
	{
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0x7EAF8C", Offset = "0x7EAF8C", VA = "0x7EAF8C")]
	public Thumbnail()
	{
	}
}
[Token(Token = "0x2000058")]
public class VideoPlayerManager : MonoBehaviour
{
	[Token(Token = "0x2000168")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB1A4", Offset = "0x5FB1A4")]
	private sealed class <>c__DisplayClass14_0
	{
		[Token(Token = "0x40006C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool prepareOnly;

		[Token(Token = "0x40006CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string projectId;

		[Token(Token = "0x40006CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool stream;

		[Token(Token = "0x40006CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public VideoPlayerManager <>4__this;

		[Token(Token = "0x40006CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public long videoTime;

		[Token(Token = "0x600094D")]
		[Address(RVA = "0x107858C", Offset = "0x107858C", VA = "0x107858C")]
		public <>c__DisplayClass14_0()
		{
		}

		[Token(Token = "0x600094E")]
		[Address(RVA = "0x107918C", Offset = "0x107918C", VA = "0x107918C")]
		internal void <Initialize>b__0(bool s, string e)
		{
		}
	}

	[Token(Token = "0x2000169")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB1B4", Offset = "0x5FB1B4")]
	private sealed class <>c__DisplayClass18_0
	{
		[Token(Token = "0x40006CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool increment;

		[Token(Token = "0x40006CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VideoPlayerManager <>4__this;

		[Token(Token = "0x600094F")]
		[Address(RVA = "0x1078D58", Offset = "0x1078D58", VA = "0x1078D58")]
		public <>c__DisplayClass18_0()
		{
		}

		[Token(Token = "0x6000950")]
		[Address(RVA = "0x1079338", Offset = "0x1079338", VA = "0x1079338")]
		internal void <PlayNextKiosk>b__0(bool s, string e)
		{
		}

		[Token(Token = "0x6000951")]
		[Address(RVA = "0x10793FC", Offset = "0x10793FC", VA = "0x10793FC")]
		internal void <PlayNextKiosk>b__1(bool s2, string e2)
		{
		}
	}

	[Token(Token = "0x4000223")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static VideoPlayerManager _instance;

	[Token(Token = "0x4000224")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OnEnd onVideoEnd;

	[Token(Token = "0x4000225")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int kioskCurrentVideo;

	[Token(Token = "0x4000226")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool isKiosk;

	[Token(Token = "0x4000227")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
	public bool isStream;

	[Token(Token = "0x4000228")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
	public bool resetOnHmdPause;

	[Token(Token = "0x4000229")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float HMDOffTime;

	[Token(Token = "0x400022A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float onPauseTime;

	[Token(Token = "0x400022B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string[] projects;

	[Token(Token = "0x400022C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Action hmdUnmount;

	[Token(Token = "0x400022D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Action hmdMount;

	[Token(Token = "0x17000039")]
	public static VideoPlayerManager Instance
	{
		[Token(Token = "0x600021E")]
		[Address(RVA = "0x1078284", Offset = "0x1078284", VA = "0x1078284")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600021F")]
	[Address(RVA = "0x10782D4", Offset = "0x10782D4", VA = "0x10782D4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000220")]
	[Address(RVA = "0x10783BC", Offset = "0x10783BC", VA = "0x10783BC")]
	public void Initialize(string projectId, bool stream, OnEnd onVideoEnd, bool resetOnPause = false, bool prepareOnly = false, long videoTime = 0L, bool loop = true)
	{
	}

	[Token(Token = "0x6000221")]
	[Address(RVA = "0x1078594", Offset = "0x1078594", VA = "0x1078594")]
	public void Initialize(bool resetOnPause = false)
	{
	}

	[Token(Token = "0x6000222")]
	[Address(RVA = "0x1078620", Offset = "0x1078620", VA = "0x1078620")]
	public void Initialize(string[] playlist, bool resetOnPause = false)
	{
	}

	[Token(Token = "0x6000223")]
	[Address(RVA = "0x107883C", Offset = "0x107883C", VA = "0x107883C")]
	private void OnApplicationPause(bool pause)
	{
	}

	[Token(Token = "0x6000224")]
	[Address(RVA = "0x1078B34", Offset = "0x1078B34", VA = "0x1078B34")]
	public void PlayNextKiosk(bool increment = true)
	{
	}

	[Token(Token = "0x6000225")]
	[Address(RVA = "0x1078A5C", Offset = "0x1078A5C", VA = "0x1078A5C")]
	public void StopVideo()
	{
	}

	[Token(Token = "0x6000226")]
	[Address(RVA = "0x1078D60", Offset = "0x1078D60", VA = "0x1078D60")]
	public void OnVideoEnd(bool succes, string error)
	{
	}

	[Token(Token = "0x6000227")]
	[Address(RVA = "0x1078D64", Offset = "0x1078D64", VA = "0x1078D64")]
	public VideoPlayerManager()
	{
	}

	[Token(Token = "0x6000228")]
	[Address(RVA = "0x1078D6C", Offset = "0x1078D6C", VA = "0x1078D6C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FDFA4", Offset = "0x5FDFA4")]
	private void <Initialize>b__16_0(bool s, string e)
	{
	}

	[Token(Token = "0x6000229")]
	[Address(RVA = "0x1078DF4", Offset = "0x1078DF4", VA = "0x1078DF4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FDFB4", Offset = "0x5FDFB4")]
	private void <Initialize>b__16_1()
	{
	}

	[Token(Token = "0x600022A")]
	[Address(RVA = "0x1078ED8", Offset = "0x1078ED8", VA = "0x1078ED8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FDFC4", Offset = "0x5FDFC4")]
	private void <Initialize>b__16_2()
	{
	}

	[Token(Token = "0x600022B")]
	[Address(RVA = "0x107908C", Offset = "0x107908C", VA = "0x107908C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FDFD4", Offset = "0x5FDFD4")]
	private void <Initialize>b__16_3(bool s2, string e2)
	{
	}

	[Token(Token = "0x600022C")]
	[Address(RVA = "0x107910C", Offset = "0x107910C", VA = "0x107910C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FDFE4", Offset = "0x5FDFE4")]
	private void <OnApplicationPause>b__17_0(bool s2, string e2)
	{
	}
}
[Token(Token = "0x2000059")]
public class VrInputModule : BaseInputModule
{
	[Token(Token = "0x400022E")]
	private const float CLICK_TIME = 0.1f;

	[Token(Token = "0x400022F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Vector2 sphericalCoordinatesResult;

	[Token(Token = "0x4000230")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private PointerEventData pointerData;

	[Token(Token = "0x4000231")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector2 lastPose;

	[Token(Token = "0x4000232")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool rayCasterSet;

	[Token(Token = "0x600022D")]
	[Address(RVA = "0x1079480", Offset = "0x1079480", VA = "0x1079480", Slot = "21")]
	public override bool ShouldActivateModule()
	{
		return default(bool);
	}

	[Token(Token = "0x600022E")]
	[Address(RVA = "0x1079488", Offset = "0x1079488", VA = "0x1079488", Slot = "22")]
	public override void DeactivateModule()
	{
	}

	[Token(Token = "0x600022F")]
	[Address(RVA = "0x1079824", Offset = "0x1079824", VA = "0x1079824", Slot = "17")]
	public override void Process()
	{
	}

	[Token(Token = "0x6000230")]
	[Address(RVA = "0x107A75C", Offset = "0x107A75C", VA = "0x107A75C", Slot = "20")]
	public override bool IsPointerOverGameObject(int pointerId)
	{
		return default(bool);
	}

	[Token(Token = "0x6000231")]
	[Address(RVA = "0x107998C", Offset = "0x107998C", VA = "0x107998C")]
	private void CastRay()
	{
	}

	[Token(Token = "0x6000232")]
	[Address(RVA = "0x1079F68", Offset = "0x1079F68", VA = "0x1079F68")]
	private void UpdateCurrentObject(GameObject previousObject)
	{
	}

	[Token(Token = "0x6000233")]
	[Address(RVA = "0x107A90C", Offset = "0x107A90C", VA = "0x107A90C")]
	private static bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold)
	{
		return default(bool);
	}

	[Token(Token = "0x6000234")]
	[Address(RVA = "0x107A118", Offset = "0x107A118", VA = "0x107A118")]
	private void HandleDrag()
	{
	}

	[Token(Token = "0x6000235")]
	[Address(RVA = "0x1079504", Offset = "0x1079504", VA = "0x1079504")]
	private void HandlePendingClick()
	{
	}

	[Token(Token = "0x6000236")]
	[Address(RVA = "0x107A478", Offset = "0x107A478", VA = "0x107A478")]
	private void HandleTriggerDown()
	{
	}

	[Token(Token = "0x6000237")]
	[Address(RVA = "0x1079974", Offset = "0x1079974", VA = "0x1079974")]
	private GameObject GetCurrentGameObject()
	{
		return null;
	}

	[Token(Token = "0x6000238")]
	[Address(RVA = "0x107A9DC", Offset = "0x107A9DC", VA = "0x107A9DC")]
	public void Update()
	{
	}

	[Token(Token = "0x6000239")]
	[Address(RVA = "0x107A7E8", Offset = "0x107A7E8", VA = "0x107A7E8")]
	public static Vector2 NormalizedCartesianToSpherical(Vector3 cartCoords)
	{
		return default(Vector2);
	}

	[Token(Token = "0x600023A")]
	[Address(RVA = "0x107AAA4", Offset = "0x107AAA4", VA = "0x107AAA4")]
	public VrInputModule()
	{
	}
}
[Token(Token = "0x200005A")]
public class LoginErrorsState : MonoBehaviour
{
	[Token(Token = "0x4000233")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static LoginErrorsState instance;

	[Token(Token = "0x4000234")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject[] wrongEmailObjects;

	[Token(Token = "0x4000235")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject[] defaultStateEmailObjects;

	[Token(Token = "0x4000236")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject[] wrongPassObjects;

	[Token(Token = "0x4000237")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject[] defaultStatePassObjects;

	[Token(Token = "0x1700003A")]
	public static LoginErrorsState Instance
	{
		[Token(Token = "0x600023B")]
		[Address(RVA = "0x7CE89C", Offset = "0x7CE89C", VA = "0x7CE89C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600023C")]
	[Address(RVA = "0x7CE8EC", Offset = "0x7CE8EC", VA = "0x7CE8EC")]
	private void Awake()
	{
	}

	[Token(Token = "0x600023D")]
	[Address(RVA = "0x7CE940", Offset = "0x7CE940", VA = "0x7CE940")]
	private void Start()
	{
	}

	[Token(Token = "0x600023E")]
	[Address(RVA = "0x7CE948", Offset = "0x7CE948", VA = "0x7CE948")]
	public void SignedIn(bool value)
	{
	}

	[Token(Token = "0x600023F")]
	[Address(RVA = "0x7CEAF4", Offset = "0x7CEAF4", VA = "0x7CEAF4")]
	private void ResetState()
	{
	}

	[Token(Token = "0x6000240")]
	[Address(RVA = "0x7CEAFC", Offset = "0x7CEAFC", VA = "0x7CEAFC")]
	public LoginErrorsState()
	{
	}
}
[Token(Token = "0x200005B")]
[PublicAPI]
public class MailChimpSubscriber : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200016A")]
	public class MailChimpEvent : UnityEvent<string>
	{
		[Token(Token = "0x6000952")]
		[Address(RVA = "0x7CEF04", Offset = "0x7CEF04", VA = "0x7CEF04")]
		public MailChimpEvent()
		{
		}
	}

	[Token(Token = "0x200016B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB1C4", Offset = "0x5FB1C4")]
	private sealed class <SendToMailChimp>d__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40006D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40006D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40006D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string url;

		[Token(Token = "0x40006D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MailChimpSubscriber <>4__this;

		[Token(Token = "0x40006D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string email;

		[Token(Token = "0x40006D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private UnityWebRequest <request>5__2;

		[Token(Token = "0x170000D8")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000956")]
			[Address(RVA = "0x7CF190", Offset = "0x7CF190", VA = "0x7CF190", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D9")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000958")]
			[Address(RVA = "0x7CF1F8", Offset = "0x7CF1F8", VA = "0x7CF1F8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000953")]
		[Address(RVA = "0x7CEE34", Offset = "0x7CEE34", VA = "0x7CEE34")]
		[DebuggerHidden]
		public <SendToMailChimp>d__11(int <>1__state)
		{
		}

		[Token(Token = "0x6000954")]
		[Address(RVA = "0x7CEF54", Offset = "0x7CEF54", VA = "0x7CEF54", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000955")]
		[Address(RVA = "0x7CEF58", Offset = "0x7CEF58", VA = "0x7CEF58", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000957")]
		[Address(RVA = "0x7CF198", Offset = "0x7CF198", VA = "0x7CF198", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000238")]
	private const string UrlFormat = "https://{0}.api.mailchimp.com/3.0/lists/{1}/members";

	[Token(Token = "0x4000239")]
	private const string JsonFormat = "{{\"email_address\":\"{0}\", \"status\":\"subscribed\"}}";

	[Token(Token = "0x400023A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MailChimpEvent SubscribeSuccess;

	[Token(Token = "0x400023B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MailChimpEvent SubscribeError;

	[Token(Token = "0x400023C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private string _apiKey;

	[Token(Token = "0x400023D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private string _listId;

	[Token(Token = "0x400023E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private InputFieldG emailField;

	[Token(Token = "0x6000241")]
	[Address(RVA = "0x7CEB04", Offset = "0x7CEB04", VA = "0x7CEB04")]
	public void Subscribe()
	{
	}

	[Token(Token = "0x6000242")]
	[Address(RVA = "0x7CEB80", Offset = "0x7CEB80", VA = "0x7CEB80")]
	private bool IsValidEmail()
	{
		return default(bool);
	}

	[Token(Token = "0x6000243")]
	[Address(RVA = "0x7CEB88", Offset = "0x7CEB88", VA = "0x7CEB88")]
	public void Subscribe(string email)
	{
	}

	[Token(Token = "0x6000244")]
	[Address(RVA = "0x7CED04", Offset = "0x7CED04", VA = "0x7CED04")]
	private string BuildUrl()
	{
		return null;
	}

	[Token(Token = "0x6000245")]
	[Address(RVA = "0x7CEDB0", Offset = "0x7CEDB0", VA = "0x7CEDB0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5FDFF4", Offset = "0x5FDFF4")]
	private IEnumerator SendToMailChimp(string url, string email)
	{
		return null;
	}

	[Token(Token = "0x6000246")]
	[Address(RVA = "0x7CEE60", Offset = "0x7CEE60", VA = "0x7CEE60")]
	public MailChimpSubscriber()
	{
	}
}
[Token(Token = "0x200005C")]
public class OpenLink : MonoBehaviour
{
	[Token(Token = "0x400023F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private string link;

	[Token(Token = "0x6000247")]
	[Address(RVA = "0x7D0BA0", Offset = "0x7D0BA0", VA = "0x7D0BA0")]
	public void Open()
	{
	}

	[Token(Token = "0x6000248")]
	[Address(RVA = "0x7D0BAC", Offset = "0x7D0BAC", VA = "0x7D0BAC")]
	public OpenLink()
	{
	}
}
[Token(Token = "0x200005D")]
public class PanelsWarning : MonoBehaviour
{
	[Token(Token = "0x4000240")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static PanelsWarning instance;

	[Token(Token = "0x4000241")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject notEnoughSpace;

	[Token(Token = "0x1700003B")]
	public static PanelsWarning Instance
	{
		[Token(Token = "0x6000249")]
		[Address(RVA = "0x7D0C04", Offset = "0x7D0C04", VA = "0x7D0C04")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600024A")]
	[Address(RVA = "0x7D0C54", Offset = "0x7D0C54", VA = "0x7D0C54")]
	private void Awake()
	{
	}

	[Token(Token = "0x600024B")]
	[Address(RVA = "0x7C7100", Offset = "0x7C7100", VA = "0x7C7100")]
	public void ShowNotEnoughSpace()
	{
	}

	[Token(Token = "0x600024C")]
	[Address(RVA = "0x7D0CA8", Offset = "0x7D0CA8", VA = "0x7D0CA8")]
	public void HideNotEnoughSpace()
	{
	}

	[Token(Token = "0x600024D")]
	[Address(RVA = "0x7D0CC8", Offset = "0x7D0CC8", VA = "0x7D0CC8")]
	public PanelsWarning()
	{
	}
}
[Token(Token = "0x200005E")]
public class SPlayerPrefs
{
	[Token(Token = "0x4000242")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static string secretKey;

	[Token(Token = "0x4000243")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static byte[] key;

	[Token(Token = "0x4000244")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static byte[] iv;

	[Token(Token = "0x600024E")]
	[Address(RVA = "0x7E1DB0", Offset = "0x7E1DB0", VA = "0x7E1DB0")]
	public static void SetString(string key, string value)
	{
	}

	[Token(Token = "0x600024F")]
	[Address(RVA = "0x7E21A0", Offset = "0x7E21A0", VA = "0x7E21A0")]
	public static string GetString(string key, string defaultValue)
	{
		return null;
	}

	[Token(Token = "0x6000250")]
	[Address(RVA = "0x7E24D0", Offset = "0x7E24D0", VA = "0x7E24D0")]
	public static string GetString(string key)
	{
		return null;
	}

	[Token(Token = "0x6000251")]
	[Address(RVA = "0x7E2540", Offset = "0x7E2540", VA = "0x7E2540")]
	public static void SetInt(string key, int value)
	{
	}

	[Token(Token = "0x6000252")]
	[Address(RVA = "0x7E25D8", Offset = "0x7E25D8", VA = "0x7E25D8")]
	public static int GetInt(string key, int defaultValue)
	{
		return default(int);
	}

	[Token(Token = "0x6000253")]
	[Address(RVA = "0x7E270C", Offset = "0x7E270C", VA = "0x7E270C")]
	public static int GetInt(string key)
	{
		return default(int);
	}

	[Token(Token = "0x6000254")]
	[Address(RVA = "0x7E2774", Offset = "0x7E2774", VA = "0x7E2774")]
	public static void SetFloat(string key, float value)
	{
	}

	[Token(Token = "0x6000255")]
	[Address(RVA = "0x7E280C", Offset = "0x7E280C", VA = "0x7E280C")]
	public static float GetFloat(string key, float defaultValue)
	{
		return default(float);
	}

	[Token(Token = "0x6000256")]
	[Address(RVA = "0x7E2978", Offset = "0x7E2978", VA = "0x7E2978")]
	public static float GetFloat(string key)
	{
		return default(float);
	}

	[Token(Token = "0x6000257")]
	[Address(RVA = "0x7E22C8", Offset = "0x7E22C8", VA = "0x7E22C8")]
	public static bool HasKey(string key)
	{
		return default(bool);
	}

	[Token(Token = "0x6000258")]
	[Address(RVA = "0x7E29E0", Offset = "0x7E29E0", VA = "0x7E29E0")]
	public static void DeleteAll()
	{
	}

	[Token(Token = "0x6000259")]
	[Address(RVA = "0x7E29E8", Offset = "0x7E29E8", VA = "0x7E29E8")]
	public static void DeleteKey(string key)
	{
	}

	[Token(Token = "0x600025A")]
	[Address(RVA = "0x7E2A54", Offset = "0x7E2A54", VA = "0x7E2A54")]
	public static void Save()
	{
	}

	[Token(Token = "0x600025B")]
	[Address(RVA = "0x7E2000", Offset = "0x7E2000", VA = "0x7E2000")]
	private static string encrypt(string s)
	{
		return null;
	}

	[Token(Token = "0x600025C")]
	[Address(RVA = "0x7E2334", Offset = "0x7E2334", VA = "0x7E2334")]
	private static string decrypt(string s)
	{
		return null;
	}

	[Token(Token = "0x600025D")]
	[Address(RVA = "0x7E1E3C", Offset = "0x7E1E3C", VA = "0x7E1E3C")]
	private static string md5(string s)
	{
		return null;
	}

	[Token(Token = "0x600025E")]
	[Address(RVA = "0x7E2A5C", Offset = "0x7E2A5C", VA = "0x7E2A5C")]
	public SPlayerPrefs()
	{
	}
}
[Token(Token = "0x200005F")]
public class PlayerPrefsSubscription : MonoBehaviour
{
	[Token(Token = "0x4000245")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private string SubscriptionKey;

	[Token(Token = "0x4000246")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool alreadySubscribed;

	[Token(Token = "0x4000247")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static PlayerPrefsSubscription instance;

	[Token(Token = "0x1700003C")]
	public static PlayerPrefsSubscription Instance
	{
		[Token(Token = "0x6000260")]
		[Address(RVA = "0x7D14D0", Offset = "0x7D14D0", VA = "0x7D14D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000261")]
	[Address(RVA = "0x7D1520", Offset = "0x7D1520", VA = "0x7D1520")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000262")]
	[Address(RVA = "0x7D159C", Offset = "0x7D159C", VA = "0x7D159C")]
	public bool IsAlreadySubscribed()
	{
		return default(bool);
	}

	[Token(Token = "0x6000263")]
	[Address(RVA = "0x7D1658", Offset = "0x7D1658", VA = "0x7D1658")]
	public void SetSubscription()
	{
	}

	[Token(Token = "0x6000264")]
	[Address(RVA = "0x7D1674", Offset = "0x7D1674", VA = "0x7D1674")]
	public void ResetSubscription()
	{
	}

	[Token(Token = "0x6000265")]
	[Address(RVA = "0x7D168C", Offset = "0x7D168C", VA = "0x7D168C")]
	public PlayerPrefsSubscription()
	{
	}
}
[Token(Token = "0x2000060")]
public class RecenterUIPanel : MonoBehaviour
{
	[Token(Token = "0x4000248")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject canvas_Center_RecenterHint;

	[Token(Token = "0x4000249")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject canvas_RecenterHint;

	[Token(Token = "0x400024A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject hintPico;

	[Token(Token = "0x400024B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject hintOculusGo;

	[Token(Token = "0x400024C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private GameObject hintOculusQuest;

	[Token(Token = "0x400024D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float borderAngle;

	[Token(Token = "0x6000266")]
	[Address(RVA = "0x7D52D8", Offset = "0x7D52D8", VA = "0x7D52D8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000267")]
	[Address(RVA = "0x7D561C", Offset = "0x7D561C", VA = "0x7D561C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000268")]
	[Address(RVA = "0x7D541C", Offset = "0x7D541C", VA = "0x7D541C")]
	private void RepositionCanvasHint()
	{
	}

	[Token(Token = "0x6000269")]
	[Address(RVA = "0x7D5594", Offset = "0x7D5594", VA = "0x7D5594")]
	private void DeactivateHint()
	{
	}

	[Token(Token = "0x600026A")]
	[Address(RVA = "0x7D58DC", Offset = "0x7D58DC", VA = "0x7D58DC")]
	private void ControllerButtonHighlightState(bool active)
	{
	}

	[Token(Token = "0x600026B")]
	[Address(RVA = "0x7D5744", Offset = "0x7D5744", VA = "0x7D5744")]
	private void ActivateHint()
	{
	}

	[Token(Token = "0x600026C")]
	[Address(RVA = "0x7D59B8", Offset = "0x7D59B8", VA = "0x7D59B8")]
	public RecenterUIPanel()
	{
	}
}
[Token(Token = "0x2000061")]
public class ResetPositionIfPurchased : MonoBehaviour
{
	[Token(Token = "0x400024E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private bool x_Axis;

	[Token(Token = "0x400024F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private RectTransform rectTransform;

	[Token(Token = "0x600026D")]
	[Address(RVA = "0x7E1A94", Offset = "0x7E1A94", VA = "0x7E1A94")]
	private void Awake()
	{
	}

	[Token(Token = "0x600026E")]
	[Address(RVA = "0x7E1AFC", Offset = "0x7E1AFC", VA = "0x7E1AFC")]
	private void Start()
	{
	}

	[Token(Token = "0x600026F")]
	[Address(RVA = "0x7E1BB8", Offset = "0x7E1BB8", VA = "0x7E1BB8")]
	public ResetPositionIfPurchased()
	{
	}
}
[Token(Token = "0x2000062")]
public class ResetPositionOnType : MonoBehaviour
{
	[Token(Token = "0x4000250")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private AppManager.MeditationProgram meditationProgram;

	[Token(Token = "0x4000251")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private bool x_Axis;

	[Token(Token = "0x4000252")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private RectTransform rectTransform;

	[Token(Token = "0x6000270")]
	[Address(RVA = "0x7E1BC8", Offset = "0x7E1BC8", VA = "0x7E1BC8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000271")]
	[Address(RVA = "0x7E1C30", Offset = "0x7E1C30", VA = "0x7E1C30")]
	private void Start()
	{
	}

	[Token(Token = "0x6000272")]
	[Address(RVA = "0x7E1CF8", Offset = "0x7E1CF8", VA = "0x7E1CF8")]
	public ResetPositionOnType()
	{
	}
}
[Token(Token = "0x2000063")]
public class SceneMinder : MonoBehaviour
{
	[Token(Token = "0x4000253")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static SceneMinder instance;

	[Token(Token = "0x4000254")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool firstLook;

	[Token(Token = "0x4000255")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private string projectId;

	[Token(Token = "0x4000256")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private AppManager.AudioVariableNames targetStory;

	[Token(Token = "0x4000257")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private bool fromMenu;

	[Token(Token = "0x1700003D")]
	public static SceneMinder Instance
	{
		[Token(Token = "0x6000273")]
		[Address(RVA = "0x7E2B30", Offset = "0x7E2B30", VA = "0x7E2B30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000274")]
	[Address(RVA = "0x7E2B80", Offset = "0x7E2B80", VA = "0x7E2B80")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000275")]
	[Address(RVA = "0x7E2CCC", Offset = "0x7E2CCC", VA = "0x7E2CCC")]
	public void ReturnCheck()
	{
	}

	[Token(Token = "0x6000276")]
	[Address(RVA = "0x7E2D74", Offset = "0x7E2D74", VA = "0x7E2D74")]
	private void ReturnToWatchedVideo()
	{
	}

	[Token(Token = "0x6000277")]
	[Address(RVA = "0x7E2D14", Offset = "0x7E2D14", VA = "0x7E2D14")]
	private void ReturnToMeditationMenu()
	{
	}

	[Token(Token = "0x6000278")]
	[Address(RVA = "0x7E2E78", Offset = "0x7E2E78", VA = "0x7E2E78")]
	private void SetMainFromMinder()
	{
	}

	[Token(Token = "0x6000279")]
	[Address(RVA = "0x7E3054", Offset = "0x7E3054", VA = "0x7E3054")]
	public void SetMinderFromMain()
	{
	}

	[Token(Token = "0x600027A")]
	[Address(RVA = "0x7E3270", Offset = "0x7E3270", VA = "0x7E3270")]
	public void SetMenuCheck()
	{
	}

	[Token(Token = "0x600027B")]
	[Address(RVA = "0x7E32D0", Offset = "0x7E32D0", VA = "0x7E32D0")]
	public SceneMinder()
	{
	}
}
[Token(Token = "0x2000064")]
public class SelectStory : MonoBehaviour
{
	[Token(Token = "0x600027C")]
	[Address(RVA = "0x7E3844", Offset = "0x7E3844", VA = "0x7E3844")]
	public void ChooseStory(int storyIndex)
	{
	}

	[Token(Token = "0x600027D")]
	[Address(RVA = "0x7E38F4", Offset = "0x7E38F4", VA = "0x7E38F4")]
	public SelectStory()
	{
	}
}
[Token(Token = "0x2000065")]
public class SetAdditionalSounds : MonoBehaviour
{
	[Token(Token = "0x600027E")]
	[Address(RVA = "0x7E38FC", Offset = "0x7E38FC", VA = "0x7E38FC")]
	private void SetNatureSound(bool value)
	{
	}

	[Token(Token = "0x600027F")]
	[Address(RVA = "0x7E39D0", Offset = "0x7E39D0", VA = "0x7E39D0")]
	private void SetDrummingSound(bool value)
	{
	}

	[Token(Token = "0x6000280")]
	[Address(RVA = "0x7E3AA4", Offset = "0x7E3AA4", VA = "0x7E3AA4")]
	private void SetMusicSound(bool value)
	{
	}

	[Token(Token = "0x6000281")]
	[Address(RVA = "0x7E3B78", Offset = "0x7E3B78", VA = "0x7E3B78")]
	public void CheckAndSet()
	{
	}

	[Token(Token = "0x6000282")]
	[Address(RVA = "0x7E3BF4", Offset = "0x7E3BF4", VA = "0x7E3BF4")]
	private void SetAllTo(bool value)
	{
	}

	[Token(Token = "0x6000283")]
	[Address(RVA = "0x7E3C24", Offset = "0x7E3C24", VA = "0x7E3C24")]
	private void ShowBools()
	{
	}

	[Token(Token = "0x6000284")]
	[Address(RVA = "0x7E3D58", Offset = "0x7E3D58", VA = "0x7E3D58")]
	public SetAdditionalSounds()
	{
	}
}
[Token(Token = "0x2000066")]
public class SetCentralCardPreview : MonoBehaviour
{
	[Token(Token = "0x4000258")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static SetCentralCardPreview instance;

	[Token(Token = "0x4000259")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject parentContainer;

	[Token(Token = "0x1700003E")]
	public static SetCentralCardPreview Instance
	{
		[Token(Token = "0x6000285")]
		[Address(RVA = "0x7E3D60", Offset = "0x7E3D60", VA = "0x7E3D60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000286")]
	[Address(RVA = "0x7E3DB0", Offset = "0x7E3DB0", VA = "0x7E3DB0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000287")]
	[Address(RVA = "0x7E3E04", Offset = "0x7E3E04", VA = "0x7E3E04")]
	public void Change360Preview()
	{
	}

	[Token(Token = "0x6000288")]
	[Address(RVA = "0x7E3EEC", Offset = "0x7E3EEC", VA = "0x7E3EEC")]
	public SetCentralCardPreview()
	{
	}
}
[Token(Token = "0x2000067")]
public class SetControlFourUI : MonoBehaviour
{
	[Token(Token = "0x400025A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private CurvedUISettings[] CurvedUiSettings;

	[Token(Token = "0x400025B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private CurvedUIInputModule.CUIControlMethod controlMethod;

	[Token(Token = "0x400025C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float timeForCLick;

	[Token(Token = "0x6000289")]
	[Address(RVA = "0x7E3EF4", Offset = "0x7E3EF4", VA = "0x7E3EF4")]
	private void Start()
	{
	}

	[Token(Token = "0x600028A")]
	[Address(RVA = "0x7E3EF8", Offset = "0x7E3EF8", VA = "0x7E3EF8")]
	private void SetControlMethod()
	{
	}

	[Token(Token = "0x600028B")]
	[Address(RVA = "0x7E3FA0", Offset = "0x7E3FA0", VA = "0x7E3FA0")]
	private void SetProgressBarImage()
	{
	}

	[Token(Token = "0x600028C")]
	[Address(RVA = "0x7E3FEC", Offset = "0x7E3FEC", VA = "0x7E3FEC")]
	public SetControlFourUI()
	{
	}
}
[Token(Token = "0x2000068")]
public class SetControlOnEnable : MonoBehaviour
{
	[Token(Token = "0x400025D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private CurvedUISettings curvedUiSettings;

	[Token(Token = "0x400025E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private CurvedUIInputModule.CUIControlMethod controlMethod;

	[Token(Token = "0x400025F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[SerializeField]
	private bool childCanvas;

	[Token(Token = "0x4000260")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private GameObject childObject;

	[Token(Token = "0x600028D")]
	[Address(RVA = "0x7E3FFC", Offset = "0x7E3FFC", VA = "0x7E3FFC")]
	private void Awake()
	{
	}

	[Token(Token = "0x600028E")]
	[Address(RVA = "0x7E40A0", Offset = "0x7E40A0", VA = "0x7E40A0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600028F")]
	[Address(RVA = "0x7E40FC", Offset = "0x7E40FC", VA = "0x7E40FC")]
	private void SetControlMethod()
	{
	}

	[Token(Token = "0x6000290")]
	[Address(RVA = "0x7E432C", Offset = "0x7E432C", VA = "0x7E432C")]
	private void EnableGraphicRaycaster(GameObject targetObject)
	{
	}

	[Token(Token = "0x6000291")]
	[Address(RVA = "0x7E4238", Offset = "0x7E4238", VA = "0x7E4238")]
	private void DisableCurvedUIRaycaster(GameObject targetObject)
	{
	}

	[Token(Token = "0x6000292")]
	[Address(RVA = "0x7E4474", Offset = "0x7E4474", VA = "0x7E4474")]
	public SetControlOnEnable()
	{
	}
}
[Token(Token = "0x2000069")]
public class SetControlOnStart : MonoBehaviour
{
	[Token(Token = "0x4000261")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private CurvedUISettings curvedUiSettings;

	[Token(Token = "0x4000262")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private CurvedUIInputModule.CUIControlMethod controlMethod;

	[Token(Token = "0x4000263")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[SerializeField]
	private bool childCanvas;

	[Token(Token = "0x4000264")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private GameObject childObject;

	[Token(Token = "0x6000293")]
	[Address(RVA = "0x7E447C", Offset = "0x7E447C", VA = "0x7E447C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000294")]
	[Address(RVA = "0x7E4520", Offset = "0x7E4520", VA = "0x7E4520")]
	private void Start()
	{
	}

	[Token(Token = "0x6000295")]
	[Address(RVA = "0x7E457C", Offset = "0x7E457C", VA = "0x7E457C")]
	private void SetControlMethod()
	{
	}

	[Token(Token = "0x6000296")]
	[Address(RVA = "0x7E47E8", Offset = "0x7E47E8", VA = "0x7E47E8")]
	private void EnableGraphicRaycaster(GameObject targetObject)
	{
	}

	[Token(Token = "0x6000297")]
	[Address(RVA = "0x7E46B8", Offset = "0x7E46B8", VA = "0x7E46B8")]
	private void DisableCurvedUIRaycaster(GameObject targetObject)
	{
	}

	[Token(Token = "0x6000298")]
	[Address(RVA = "0x7E4930", Offset = "0x7E4930", VA = "0x7E4930")]
	public SetControlOnStart()
	{
	}
}
[Token(Token = "0x200006A")]
public class SetGlobalPosition : MonoBehaviour
{
	[Token(Token = "0x4000265")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5FBFD8", Offset = "0x5FBFD8")]
	[SerializeField]
	private GameObject[] objectsToSet;

	[Token(Token = "0x4000266")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private bool setXPos;

	[Token(Token = "0x4000267")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	[SerializeField]
	private bool setYPos;

	[Token(Token = "0x4000268")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
	[SerializeField]
	private bool setZPos;

	[Token(Token = "0x4000269")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
	[SerializeField]
	private bool instantSet;

	[Token(Token = "0x400026A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private int tries;

	[Token(Token = "0x400026B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int targetTries;

	[Token(Token = "0x6000299")]
	[Address(RVA = "0x7E4938", Offset = "0x7E4938", VA = "0x7E4938")]
	private void Awake()
	{
	}

	[Token(Token = "0x600029A")]
	[Address(RVA = "0x7E4B40", Offset = "0x7E4B40", VA = "0x7E4B40")]
	private void Start()
	{
	}

	[Token(Token = "0x600029B")]
	[Address(RVA = "0x7E4BB8", Offset = "0x7E4BB8", VA = "0x7E4BB8")]
	private void Set()
	{
	}

	[Token(Token = "0x600029C")]
	[Address(RVA = "0x7E4948", Offset = "0x7E4948", VA = "0x7E4948")]
	private void SetCamAndPositions()
	{
	}

	[Token(Token = "0x600029D")]
	[Address(RVA = "0x7E4C70", Offset = "0x7E4C70", VA = "0x7E4C70")]
	private void SetPos(GameObject targetObj, Vector3 camPos)
	{
	}

	[Token(Token = "0x600029E")]
	[Address(RVA = "0x7E4D9C", Offset = "0x7E4D9C", VA = "0x7E4D9C")]
	public SetGlobalPosition()
	{
	}
}
[Token(Token = "0x200006B")]
public class SetMainDescription : MonoBehaviour
{
	[Token(Token = "0x400026C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Text text;

	[Token(Token = "0x600029F")]
	[Address(RVA = "0x7E4DAC", Offset = "0x7E4DAC", VA = "0x7E4DAC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60002A0")]
	[Address(RVA = "0x7E4E3C", Offset = "0x7E4E3C", VA = "0x7E4E3C")]
	public SetMainDescription()
	{
	}
}
[Token(Token = "0x200006C")]
public class SetText : MonoBehaviour
{
	[Token(Token = "0x400026D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Text targetText;

	[Token(Token = "0x400026E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private string[] textValues;

	[Token(Token = "0x60002A1")]
	[Address(RVA = "0x7E4E44", Offset = "0x7E4E44", VA = "0x7E4E44")]
	public void ChangeText(int index)
	{
	}

	[Token(Token = "0x60002A2")]
	[Address(RVA = "0x7E4E94", Offset = "0x7E4E94", VA = "0x7E4E94")]
	public SetText()
	{
	}
}
[Token(Token = "0x200006D")]
public class SetToggleByProgram : MonoBehaviour
{
	[Token(Token = "0x400026F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private TogglesSwitch _togglesSwitch;

	[Token(Token = "0x60002A3")]
	[Address(RVA = "0x7E4E9C", Offset = "0x7E4E9C", VA = "0x7E4E9C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002A4")]
	[Address(RVA = "0x7E4F1C", Offset = "0x7E4F1C", VA = "0x7E4F1C")]
	private void Start()
	{
	}

	[Token(Token = "0x60002A5")]
	[Address(RVA = "0x7E4F9C", Offset = "0x7E4F9C", VA = "0x7E4F9C")]
	public SetToggleByProgram()
	{
	}
}
[Token(Token = "0x200006E")]
public class SetUIControlMethod : MonoBehaviour
{
	[Token(Token = "0x4000270")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private bool _onAwake;

	[Token(Token = "0x4000271")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	[SerializeField]
	private bool _onEnable;

	[Token(Token = "0x4000272")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	[SerializeField]
	private bool _onStart;

	[Token(Token = "0x4000273")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private CurvedUISettings curvedUiSettings;

	[Token(Token = "0x4000274")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private CurvedUIInputModule.CUIControlMethod controlMethod;

	[Token(Token = "0x60002A6")]
	[Address(RVA = "0x7E4FA4", Offset = "0x7E4FA4", VA = "0x7E4FA4")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002A7")]
	[Address(RVA = "0x7E5008", Offset = "0x7E5008", VA = "0x7E5008")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60002A8")]
	[Address(RVA = "0x7E5018", Offset = "0x7E5018", VA = "0x7E5018")]
	private void Start()
	{
	}

	[Token(Token = "0x60002A9")]
	[Address(RVA = "0x7E4FB4", Offset = "0x7E4FB4", VA = "0x7E4FB4")]
	private void SetControlMethod()
	{
	}

	[Token(Token = "0x60002AA")]
	[Address(RVA = "0x7E5028", Offset = "0x7E5028", VA = "0x7E5028")]
	public SetUIControlMethod()
	{
	}
}
[Token(Token = "0x200006F")]
public class DisableObjectOnEnable : MonoBehaviour
{
	[Token(Token = "0x4000275")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject[] disable;

	[Token(Token = "0x60002AB")]
	[Address(RVA = "0x7B1984", Offset = "0x7B1984", VA = "0x7B1984")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60002AC")]
	[Address(RVA = "0x7B19F4", Offset = "0x7B19F4", VA = "0x7B19F4")]
	public DisableObjectOnEnable()
	{
	}
}
[Token(Token = "0x2000070")]
public class PlayVideoAsset : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200016C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB1D4", Offset = "0x5FB1D4")]
	private sealed class <>c
	{
		[Token(Token = "0x40006D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x40006D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static OnEnd <>9__1_0;

		[Token(Token = "0x600095A")]
		[Address(RVA = "0x7D1454", Offset = "0x7D1454", VA = "0x7D1454")]
		public <>c()
		{
		}

		[Token(Token = "0x600095B")]
		[Address(RVA = "0x7D145C", Offset = "0x7D145C", VA = "0x7D145C")]
		internal void <Initialized>b__1_0(bool vidSuc, string vidErr)
		{
		}
	}

	[Token(Token = "0x60002AD")]
	[Address(RVA = "0x7D114C", Offset = "0x7D114C", VA = "0x7D114C")]
	private void Start()
	{
	}

	[Token(Token = "0x60002AE")]
	[Address(RVA = "0x7D11F0", Offset = "0x7D11F0", VA = "0x7D11F0")]
	private void Initialized(bool success, string error)
	{
	}

	[Token(Token = "0x60002AF")]
	[Address(RVA = "0x7D13E8", Offset = "0x7D13E8", VA = "0x7D13E8")]
	public PlayVideoAsset()
	{
	}
}
[Token(Token = "0x2000071")]
public class ProjectMenu : MonoBehaviour
{
	[Token(Token = "0x200016D")]
	private enum DownloadState
	{
		[Token(Token = "0x40006D9")]
		Available,
		[Token(Token = "0x40006DA")]
		Downloaded,
		[Token(Token = "0x40006DB")]
		Downloading
	}

	[Token(Token = "0x4000276")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TextMesh titleText;

	[Token(Token = "0x4000277")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshRenderer thumbnailRenderer;

	[Token(Token = "0x4000278")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public MeshCollider downloadButtonCollider;

	[Token(Token = "0x4000279")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public MeshCollider playButtonCollider;

	[Token(Token = "0x400027A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public TextMesh downloadButtonText;

	[Token(Token = "0x400027B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private string projectId;

	[Token(Token = "0x60002B0")]
	[Address(RVA = "0x7D4908", Offset = "0x7D4908", VA = "0x7D4908")]
	public void SetProjectId(string pID)
	{
	}

	[Token(Token = "0x60002B1")]
	[Address(RVA = "0x7D49E0", Offset = "0x7D49E0", VA = "0x7D49E0")]
	private DownloadState UpdateDownloadState()
	{
		return default(DownloadState);
	}

	[Token(Token = "0x60002B2")]
	[Address(RVA = "0x7D4AF4", Offset = "0x7D4AF4", VA = "0x7D4AF4")]
	private void Update()
	{
	}

	[Token(Token = "0x60002B3")]
	[Address(RVA = "0x7D4CC8", Offset = "0x7D4CC8", VA = "0x7D4CC8")]
	public ProjectMenu()
	{
	}

	[Token(Token = "0x60002B4")]
	[Address(RVA = "0x7D4CD0", Offset = "0x7D4CD0", VA = "0x7D4CD0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FE058", Offset = "0x5FE058")]
	private void <Update>b__9_0(bool succ, string e)
	{
	}
}
[Token(Token = "0x2000072")]
public class TestInputField : MonoBehaviour
{
	[Token(Token = "0x400027C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public InputField inputField;

	[Token(Token = "0x60002B5")]
	[Address(RVA = "0x7E9F8C", Offset = "0x7E9F8C", VA = "0x7E9F8C")]
	public void AddLetter()
	{
	}

	[Token(Token = "0x60002B6")]
	[Address(RVA = "0x7E9FFC", Offset = "0x7E9FFC", VA = "0x7E9FFC")]
	public TestInputField()
	{
	}
}
[Token(Token = "0x2000073")]
public class TogglesSwitch : MonoBehaviour
{
	[Token(Token = "0x400027D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private ChangePressedState[] toggles;

	[Token(Token = "0x60002B7")]
	[Address(RVA = "0x1075E30", Offset = "0x1075E30", VA = "0x1075E30")]
	public void Activate(int index)
	{
	}

	[Token(Token = "0x60002B8")]
	[Address(RVA = "0x1075EE4", Offset = "0x1075EE4", VA = "0x1075EE4")]
	public TogglesSwitch()
	{
	}
}
[Token(Token = "0x2000074")]
public class MainMenu : MonoBehaviour
{
	[Token(Token = "0x400027E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FC114", Offset = "0x5FC114")]
	private static MainMenu <Instance>k__BackingField;

	[Token(Token = "0x400027F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static bool IsOpenHomePage;

	[Token(Token = "0x4000280")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private BasePage settingsPage;

	[Token(Token = "0x4000281")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private BasePage storySettingsPage;

	[Token(Token = "0x4000282")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private UIMainManager uiMainManager;

	[Token(Token = "0x4000283")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool showCrosshair;

	[Token(Token = "0x1700003F")]
	public static MainMenu Instance
	{
		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x7CF200", Offset = "0x7CF200", VA = "0x7CF200")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FE068", Offset = "0x5FE068")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x7CF268", Offset = "0x7CF268", VA = "0x7CF268")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FE078", Offset = "0x5FE078")]
		private set
		{
		}
	}

	[Token(Token = "0x60002BB")]
	[Address(RVA = "0x7CF2D4", Offset = "0x7CF2D4", VA = "0x7CF2D4")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002BC")]
	[Address(RVA = "0x7CF508", Offset = "0x7CF508", VA = "0x7CF508")]
	private void Start()
	{
	}

	[Token(Token = "0x60002BD")]
	[Address(RVA = "0x7CF50C", Offset = "0x7CF50C", VA = "0x7CF50C")]
	public void CloseAllPages()
	{
	}

	[Token(Token = "0x60002BE")]
	[Address(RVA = "0x7CF47C", Offset = "0x7CF47C", VA = "0x7CF47C")]
	public void OpenHomePage()
	{
	}

	[Token(Token = "0x60002BF")]
	[Address(RVA = "0x7CF5C0", Offset = "0x7CF5C0", VA = "0x7CF5C0")]
	public void OpenStartPage()
	{
	}

	[Token(Token = "0x60002C0")]
	[Address(RVA = "0x7C8FF4", Offset = "0x7C8FF4", VA = "0x7C8FF4")]
	public void OpenPremiumPage()
	{
	}

	[Token(Token = "0x60002C1")]
	[Address(RVA = "0x7CF68C", Offset = "0x7CF68C", VA = "0x7CF68C")]
	private void InitUIMainManager()
	{
	}

	[Token(Token = "0x60002C2")]
	[Address(RVA = "0x7BEA88", Offset = "0x7BEA88", VA = "0x7BEA88")]
	public void OpenProjectPage()
	{
	}

	[Token(Token = "0x60002C3")]
	[Address(RVA = "0x7C387C", Offset = "0x7C387C", VA = "0x7C387C")]
	public void OpenSettingsPage()
	{
	}

	[Token(Token = "0x60002C4")]
	[Address(RVA = "0x7CF71C", Offset = "0x7CF71C", VA = "0x7CF71C")]
	public void PlayVideoCurrentVideo()
	{
	}

	[Token(Token = "0x60002C5")]
	[Address(RVA = "0x7CF88C", Offset = "0x7CF88C", VA = "0x7CF88C")]
	public MainMenu()
	{
	}
}
[Token(Token = "0x2000075")]
public class UnlockPremiumProgram : MonoBehaviour
{
	[Token(Token = "0x4000284")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Button[] toggleGroup;

	[Token(Token = "0x60002C7")]
	[Address(RVA = "0x1076F64", Offset = "0x1076F64", VA = "0x1076F64")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002C8")]
	[Address(RVA = "0x1077138", Offset = "0x1077138", VA = "0x1077138")]
	private void Start()
	{
	}

	[Token(Token = "0x60002C9")]
	[Address(RVA = "0x1076FE4", Offset = "0x1076FE4", VA = "0x1076FE4")]
	private void UnlockPremium()
	{
	}

	[Token(Token = "0x60002CA")]
	[Address(RVA = "0x1077054", Offset = "0x1077054", VA = "0x1077054")]
	private void LockPremium()
	{
	}

	[Token(Token = "0x60002CB")]
	[Address(RVA = "0x10771B8", Offset = "0x10771B8", VA = "0x10771B8")]
	public UnlockPremiumProgram()
	{
	}
}
[Token(Token = "0x2000076")]
public class WavAudioPostManager : MonoBehaviour
{
	[Token(Token = "0x4000285")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FC154", Offset = "0x5FC154")]
	private static WavAudioPostManager <Instance>k__BackingField;

	[Token(Token = "0x4000286")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private AudioSource voiceAudioSource;

	[Token(Token = "0x4000287")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private AudioSource backgroundNatureAudioSource;

	[Token(Token = "0x4000288")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private AudioSource backgroundMusicAudioSource;

	[Token(Token = "0x4000289")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private AudioSource backgroundDrummingAudioSource;

	[Token(Token = "0x400028A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float minThreshold;

	[Token(Token = "0x17000040")]
	public static WavAudioPostManager Instance
	{
		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x107AE44", Offset = "0x107AE44", VA = "0x107AE44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FE088", Offset = "0x5FE088")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x107AEAC", Offset = "0x107AEAC", VA = "0x107AEAC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FE098", Offset = "0x5FE098")]
		private set
		{
		}
	}

	[Token(Token = "0x17000041")]
	public float BackgroundNatureVolume
	{
		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x107B3A0", Offset = "0x107B3A0", VA = "0x107B3A0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x107B2F8", Offset = "0x107B2F8", VA = "0x107B2F8")]
		set
		{
		}
	}

	[Token(Token = "0x17000042")]
	public float BackgroundMusicVolume
	{
		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x107B4E0", Offset = "0x107B4E0", VA = "0x107B4E0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x107B438", Offset = "0x107B438", VA = "0x107B438")]
		set
		{
		}
	}

	[Token(Token = "0x17000043")]
	public float BackgroundDrummingVolume
	{
		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x107B620", Offset = "0x107B620", VA = "0x107B620")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x107B578", Offset = "0x107B578", VA = "0x107B578")]
		set
		{
		}
	}

	[Token(Token = "0x17000044")]
	public float VoiceVolume
	{
		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x107B760", Offset = "0x107B760", VA = "0x107B760")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x107B6B8", Offset = "0x107B6B8", VA = "0x107B6B8")]
		set
		{
		}
	}

	[Token(Token = "0x60002CE")]
	[Address(RVA = "0x107AF18", Offset = "0x107AF18", VA = "0x107AF18")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002CF")]
	[Address(RVA = "0x107B0D4", Offset = "0x107B0D4", VA = "0x107B0D4")]
	private void Start()
	{
	}

	[Token(Token = "0x60002D0")]
	[Address(RVA = "0x107B0D8", Offset = "0x107B0D8", VA = "0x107B0D8")]
	private void InitAudioSources()
	{
	}

	[Token(Token = "0x60002D9")]
	[Address(RVA = "0x107B7F8", Offset = "0x107B7F8", VA = "0x107B7F8")]
	public void SetFromMain()
	{
	}

	[Token(Token = "0x60002DA")]
	[Address(RVA = "0x107C3B8", Offset = "0x107C3B8", VA = "0x107C3B8")]
	public void SetFromAllAudios()
	{
	}

	[Token(Token = "0x60002DB")]
	[Address(RVA = "0x107C188", Offset = "0x107C188", VA = "0x107C188")]
	private void ShowInfo()
	{
	}

	[Token(Token = "0x60002DC")]
	[Address(RVA = "0x107C008", Offset = "0x107C008", VA = "0x107C008")]
	private void ShowBools()
	{
	}

	[Token(Token = "0x60002DD")]
	[Address(RVA = "0x107C92C", Offset = "0x107C92C", VA = "0x107C92C")]
	public WavAudioPostManager()
	{
	}
}
[Token(Token = "0x2000077")]
public class CanvasKeyboardEditableButton : MonoBehaviour
{
	[Token(Token = "0x400028B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Canvas CanvasKeyboardObject;

	[Token(Token = "0x17000045")]
	public string text
	{
		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x829390", Offset = "0x829390", VA = "0x829390")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x8293F8", Offset = "0x8293F8", VA = "0x8293F8")]
		set
		{
		}
	}

	[Token(Token = "0x60002E1")]
	[Address(RVA = "0x829470", Offset = "0x829470", VA = "0x829470")]
	public void Open()
	{
	}

	[Token(Token = "0x60002E2")]
	[Address(RVA = "0x8294A4", Offset = "0x8294A4", VA = "0x8294A4")]
	public void Close()
	{
	}

	[Token(Token = "0x60002E3")]
	[Address(RVA = "0x8294AC", Offset = "0x8294AC", VA = "0x8294AC")]
	public CanvasKeyboardEditableButton()
	{
	}
}
[Token(Token = "0x2000078")]
public class ToggleKeyboard : MonoBehaviour
{
	[Token(Token = "0x60002E4")]
	[Address(RVA = "0x1075D90", Offset = "0x1075D90", VA = "0x1075D90")]
	private void Update()
	{
	}

	[Token(Token = "0x60002E5")]
	[Address(RVA = "0x1075E28", Offset = "0x1075E28", VA = "0x1075E28")]
	public ToggleKeyboard()
	{
	}
}
[Token(Token = "0x2000079")]
public class ButtonListener : MonoBehaviour
{
	[Token(Token = "0x400028C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text textSelected;

	[Token(Token = "0x60002E6")]
	[Address(RVA = "0x8286F4", Offset = "0x8286F4", VA = "0x8286F4")]
	public void MyClick(GameObject obj)
	{
	}

	[Token(Token = "0x60002E7")]
	[Address(RVA = "0x828978", Offset = "0x828978", VA = "0x828978")]
	private void Update()
	{
	}

	[Token(Token = "0x60002E8")]
	[Address(RVA = "0x828AAC", Offset = "0x828AAC", VA = "0x828AAC")]
	public ButtonListener()
	{
	}
}
[Token(Token = "0x200007A")]
public class CubeListener : MonoBehaviour
{
	[Token(Token = "0x60002E9")]
	[Address(RVA = "0x831178", Offset = "0x831178", VA = "0x831178")]
	public void MyPointerEnter()
	{
	}

	[Token(Token = "0x60002EA")]
	[Address(RVA = "0x83126C", Offset = "0x83126C", VA = "0x83126C")]
	public void MyPointerLeave()
	{
	}

	[Token(Token = "0x60002EB")]
	[Address(RVA = "0x8312E8", Offset = "0x8312E8", VA = "0x8312E8")]
	public CubeListener()
	{
	}
}
[Token(Token = "0x200007B")]
public class GazeCrosshairOnOff : MonoBehaviour
{
	[Token(Token = "0x60002EC")]
	[Address(RVA = "0x7B499C", Offset = "0x7B499C", VA = "0x7B499C")]
	private void Update()
	{
	}

	[Token(Token = "0x60002ED")]
	[Address(RVA = "0x7B4A1C", Offset = "0x7B4A1C", VA = "0x7B4A1C")]
	public GazeCrosshairOnOff()
	{
	}
}
[Token(Token = "0x200007C")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x5FA878", Offset = "0x5FA878")]
public class GazeInputModuleCrosshair : MonoBehaviour
{
	[Token(Token = "0x400028D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool DisplayCrosshair;

	[Token(Token = "0x400028E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5FC164", Offset = "0x5FC164")]
	public Transform Crosshair;

	[Token(Token = "0x400028F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GazeInputModule gazeInputModule;

	[Token(Token = "0x4000290")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Vector3 CrosshairOriginalScale;

	[Token(Token = "0x4000291")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float CrosshairOriginalDistance;

	[Token(Token = "0x60002EE")]
	[Address(RVA = "0x7B4EA4", Offset = "0x7B4EA4", VA = "0x7B4EA4")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002EF")]
	[Address(RVA = "0x7B4EFC", Offset = "0x7B4EFC", VA = "0x7B4EFC")]
	private void Start()
	{
	}

	[Token(Token = "0x60002F0")]
	[Address(RVA = "0x7B4F64", Offset = "0x7B4F64", VA = "0x7B4F64")]
	private void Update()
	{
	}

	[Token(Token = "0x60002F1")]
	[Address(RVA = "0x7B5074", Offset = "0x7B5074", VA = "0x7B5074")]
	private void SetCrossHairAtDistance(float dist)
	{
	}

	[Token(Token = "0x60002F2")]
	[Address(RVA = "0x7B516C", Offset = "0x7B516C", VA = "0x7B516C")]
	public GazeInputModuleCrosshair()
	{
	}
}
[Token(Token = "0x200007D")]
[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x5FA8DC", Offset = "0x5FA8DC")]
public class MultiKeyDictionary<T1, T2, T3> : Dictionary<T1, Dictionary<T2, T3>>
{
	[Token(Token = "0x17000046")]
	public new Dictionary<T2, T3> Item
	{
		[Token(Token = "0x60002F4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60002F5")]
	public bool ContainsKey(T1 key1, T2 key2)
	{
		return default(bool);
	}

	[Token(Token = "0x60002F6")]
	public MultiKeyDictionary()
	{
	}
}
[Serializable]
[Token(Token = "0x200007E")]
public class Images
{
	[Token(Token = "0x4000292")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Texture2D clearImage;

	[Token(Token = "0x4000293")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Texture2D collapseImage;

	[Token(Token = "0x4000294")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Texture2D clearOnNewSceneImage;

	[Token(Token = "0x4000295")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Texture2D showTimeImage;

	[Token(Token = "0x4000296")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Texture2D showSceneImage;

	[Token(Token = "0x4000297")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Texture2D userImage;

	[Token(Token = "0x4000298")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Texture2D showMemoryImage;

	[Token(Token = "0x4000299")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Texture2D softwareImage;

	[Token(Token = "0x400029A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Texture2D dateImage;

	[Token(Token = "0x400029B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Texture2D showFpsImage;

	[Token(Token = "0x400029C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Texture2D infoImage;

	[Token(Token = "0x400029D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Texture2D saveLogsImage;

	[Token(Token = "0x400029E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Texture2D searchImage;

	[Token(Token = "0x400029F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Texture2D copyImage;

	[Token(Token = "0x40002A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Texture2D closeImage;

	[Token(Token = "0x40002A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Texture2D buildFromImage;

	[Token(Token = "0x40002A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Texture2D systemInfoImage;

	[Token(Token = "0x40002A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Texture2D graphicsInfoImage;

	[Token(Token = "0x40002A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Texture2D backImage;

	[Token(Token = "0x40002A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Texture2D logImage;

	[Token(Token = "0x40002A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Texture2D warningImage;

	[Token(Token = "0x40002A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Texture2D errorImage;

	[Token(Token = "0x40002A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Texture2D barImage;

	[Token(Token = "0x40002A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public Texture2D button_activeImage;

	[Token(Token = "0x40002AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public Texture2D even_logImage;

	[Token(Token = "0x40002AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public Texture2D odd_logImage;

	[Token(Token = "0x40002AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public Texture2D selectedImage;

	[Token(Token = "0x40002AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public GUISkin reporterScrollerSkin;

	[Token(Token = "0x60002F7")]
	[Address(RVA = "0x7CB6BC", Offset = "0x7CB6BC", VA = "0x7CB6BC")]
	public Images()
	{
	}
}
[Token(Token = "0x200007F")]
public class Reporter : MonoBehaviour
{
	[Token(Token = "0x200016E")]
	public enum _LogType
	{
		[Token(Token = "0x40006DD")]
		Assert = 1,
		[Token(Token = "0x40006DE")]
		Error = 0,
		[Token(Token = "0x40006DF")]
		Exception = 4,
		[Token(Token = "0x40006E0")]
		Log = 3,
		[Token(Token = "0x40006E1")]
		Warning = 2
	}

	[Token(Token = "0x200016F")]
	public class Sample
	{
		[Token(Token = "0x40006E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float time;

		[Token(Token = "0x40006E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public byte loadedScene;

		[Token(Token = "0x40006E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float memory;

		[Token(Token = "0x40006E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float fps;

		[Token(Token = "0x40006E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string fpsText;

		[Token(Token = "0x600095C")]
		[Address(RVA = "0x7D6934", Offset = "0x7D6934", VA = "0x7D6934")]
		public static float MemSize()
		{
			return default(float);
		}

		[Token(Token = "0x600095D")]
		[Address(RVA = "0x7DD9A4", Offset = "0x7DD9A4", VA = "0x7DD9A4")]
		public string GetSceneName()
		{
			return null;
		}

		[Token(Token = "0x600095E")]
		[Address(RVA = "0x7D692C", Offset = "0x7D692C", VA = "0x7D692C")]
		public Sample()
		{
		}
	}

	[Token(Token = "0x2000170")]
	public class Log
	{
		[Token(Token = "0x40006E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int count;

		[Token(Token = "0x40006E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public _LogType logType;

		[Token(Token = "0x40006E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string condition;

		[Token(Token = "0x40006EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string stacktrace;

		[Token(Token = "0x40006EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int sampleId;

		[Token(Token = "0x600095F")]
		[Address(RVA = "0x7E1800", Offset = "0x7E1800", VA = "0x7E1800")]
		public Log CreateCopy()
		{
			return null;
		}

		[Token(Token = "0x6000960")]
		[Address(RVA = "0x7E0C80", Offset = "0x7E0C80", VA = "0x7E0C80")]
		public float GetMemoryUsage()
		{
			return default(float);
		}

		[Token(Token = "0x6000961")]
		[Address(RVA = "0x7E0C70", Offset = "0x7E0C70", VA = "0x7E0C70")]
		public Log()
		{
		}
	}

	[Token(Token = "0x2000171")]
	private enum ReportView
	{
		[Token(Token = "0x40006ED")]
		None,
		[Token(Token = "0x40006EE")]
		Logs,
		[Token(Token = "0x40006EF")]
		Info,
		[Token(Token = "0x40006F0")]
		Snapshot
	}

	[Token(Token = "0x2000172")]
	private enum DetailView
	{
		[Token(Token = "0x40006F2")]
		None,
		[Token(Token = "0x40006F3")]
		StackTrace,
		[Token(Token = "0x40006F4")]
		Graph
	}

	[Token(Token = "0x2000173")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB1E4", Offset = "0x5FB1E4")]
	private sealed class <readInfo>d__188 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40006F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40006F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40006F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Reporter <>4__this;

		[Token(Token = "0x40006F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private UnityWebRequest <www>5__2;

		[Token(Token = "0x170000DA")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000965")]
			[Address(RVA = "0x7E1790", Offset = "0x7E1790", VA = "0x7E1790", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DB")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000967")]
			[Address(RVA = "0x7E17F8", Offset = "0x7E17F8", VA = "0x7E17F8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000962")]
		[Address(RVA = "0x7E1170", Offset = "0x7E1170", VA = "0x7E1170")]
		[DebuggerHidden]
		public <readInfo>d__188(int <>1__state)
		{
		}

		[Token(Token = "0x6000963")]
		[Address(RVA = "0x7E1584", Offset = "0x7E1584", VA = "0x7E1584", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000964")]
		[Address(RVA = "0x7E1588", Offset = "0x7E1588", VA = "0x7E1588", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000966")]
		[Address(RVA = "0x7E1798", Offset = "0x7E1798", VA = "0x7E1798", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40002AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private List<Sample> samples;

	[Token(Token = "0x40002AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<Log> logs;

	[Token(Token = "0x40002B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private List<Log> collapsedLogs;

	[Token(Token = "0x40002B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<Log> currentLog;

	[Token(Token = "0x40002B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private MultiKeyDictionary<string, string, Log> logsDic;

	[Token(Token = "0x40002B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Dictionary<string, string> cachedString;

	[Token(Token = "0x40002B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[HideInInspector]
	public bool show;

	[Token(Token = "0x40002B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	private bool collapse;

	[Token(Token = "0x40002B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
	private bool clearOnNewSceneLoaded;

	[Token(Token = "0x40002B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4B")]
	private bool showTime;

	[Token(Token = "0x40002B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private bool showScene;

	[Token(Token = "0x40002B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
	private bool showMemory;

	[Token(Token = "0x40002BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4E")]
	private bool showFps;

	[Token(Token = "0x40002BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4F")]
	private bool showGraph;

	[Token(Token = "0x40002BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool showLog;

	[Token(Token = "0x40002BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
	private bool showWarning;

	[Token(Token = "0x40002BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
	private bool showError;

	[Token(Token = "0x40002BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private int numOfLogs;

	[Token(Token = "0x40002C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private int numOfLogsWarning;

	[Token(Token = "0x40002C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private int numOfLogsError;

	[Token(Token = "0x40002C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private int numOfCollapsedLogs;

	[Token(Token = "0x40002C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private int numOfCollapsedLogsWarning;

	[Token(Token = "0x40002C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int numOfCollapsedLogsError;

	[Token(Token = "0x40002C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private bool showClearOnNewSceneLoadedButton;

	[Token(Token = "0x40002C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6D")]
	private bool showTimeButton;

	[Token(Token = "0x40002C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6E")]
	private bool showSceneButton;

	[Token(Token = "0x40002C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6F")]
	private bool showMemButton;

	[Token(Token = "0x40002C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private bool showFpsButton;

	[Token(Token = "0x40002CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
	private bool showSearchText;

	[Token(Token = "0x40002CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x72")]
	private bool showCopyButton;

	[Token(Token = "0x40002CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x73")]
	private bool showSaveButton;

	[Token(Token = "0x40002CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private string buildDate;

	[Token(Token = "0x40002CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private string logDate;

	[Token(Token = "0x40002CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private float logsMemUsage;

	[Token(Token = "0x40002D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private float graphMemUsage;

	[Token(Token = "0x40002D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private float gcTotalMemory;

	[Token(Token = "0x40002D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public string UserData;

	[Token(Token = "0x40002D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public float fps;

	[Token(Token = "0x40002D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public string fpsText;

	[Token(Token = "0x40002D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private ReportView currentView;

	[Token(Token = "0x40002D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static bool created;

	[Token(Token = "0x40002D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Images images;

	[Token(Token = "0x40002D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private GUIContent clearContent;

	[Token(Token = "0x40002D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private GUIContent collapseContent;

	[Token(Token = "0x40002DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private GUIContent clearOnNewSceneContent;

	[Token(Token = "0x40002DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private GUIContent showTimeContent;

	[Token(Token = "0x40002DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private GUIContent showSceneContent;

	[Token(Token = "0x40002DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private GUIContent userContent;

	[Token(Token = "0x40002DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private GUIContent showMemoryContent;

	[Token(Token = "0x40002DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private GUIContent softwareContent;

	[Token(Token = "0x40002E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private GUIContent dateContent;

	[Token(Token = "0x40002E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private GUIContent showFpsContent;

	[Token(Token = "0x40002E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private GUIContent infoContent;

	[Token(Token = "0x40002E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private GUIContent saveLogsContent;

	[Token(Token = "0x40002E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private GUIContent searchContent;

	[Token(Token = "0x40002E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private GUIContent copyContent;

	[Token(Token = "0x40002E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private GUIContent closeContent;

	[Token(Token = "0x40002E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private GUIContent buildFromContent;

	[Token(Token = "0x40002E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private GUIContent systemInfoContent;

	[Token(Token = "0x40002E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private GUIContent graphicsInfoContent;

	[Token(Token = "0x40002EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private GUIContent backContent;

	[Token(Token = "0x40002EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private GUIContent logContent;

	[Token(Token = "0x40002EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private GUIContent warningContent;

	[Token(Token = "0x40002ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private GUIContent errorContent;

	[Token(Token = "0x40002EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private GUIStyle barStyle;

	[Token(Token = "0x40002EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private GUIStyle buttonActiveStyle;

	[Token(Token = "0x40002F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private GUIStyle nonStyle;

	[Token(Token = "0x40002F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private GUIStyle lowerLeftFontStyle;

	[Token(Token = "0x40002F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private GUIStyle backStyle;

	[Token(Token = "0x40002F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private GUIStyle evenLogStyle;

	[Token(Token = "0x40002F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private GUIStyle oddLogStyle;

	[Token(Token = "0x40002F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private GUIStyle logButtonStyle;

	[Token(Token = "0x40002F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	private GUIStyle selectedLogStyle;

	[Token(Token = "0x40002F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	private GUIStyle selectedLogFontStyle;

	[Token(Token = "0x40002F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	private GUIStyle stackLabelStyle;

	[Token(Token = "0x40002F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	private GUIStyle scrollerStyle;

	[Token(Token = "0x40002FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	private GUIStyle searchStyle;

	[Token(Token = "0x40002FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	private GUIStyle sliderBackStyle;

	[Token(Token = "0x40002FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	private GUIStyle sliderThumbStyle;

	[Token(Token = "0x40002FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	private GUISkin toolbarScrollerSkin;

	[Token(Token = "0x40002FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	private GUISkin logScrollerSkin;

	[Token(Token = "0x40002FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	private GUISkin graphScrollerSkin;

	[Token(Token = "0x4000300")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	public Vector2 size;

	[Token(Token = "0x4000301")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	public float maxSize;

	[Token(Token = "0x4000302")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
	public int numOfCircleToShow;

	[Token(Token = "0x4000303")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static string[] scenes;

	[Token(Token = "0x4000304")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
	private string currentScene;

	[Token(Token = "0x4000305")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
	private string filterText;

	[Token(Token = "0x4000306")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
	private string deviceModel;

	[Token(Token = "0x4000307")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
	private string deviceType;

	[Token(Token = "0x4000308")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
	private string deviceName;

	[Token(Token = "0x4000309")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
	private string graphicsMemorySize;

	[Token(Token = "0x400030A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
	private string maxTextureSize;

	[Token(Token = "0x400030B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
	private string systemMemorySize;

	[Token(Token = "0x400030C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
	public bool Initialized;

	[Token(Token = "0x400030D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x254")]
	private Rect screenRect;

	[Token(Token = "0x400030E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x264")]
	private Rect toolBarRect;

	[Token(Token = "0x400030F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x274")]
	private Rect logsRect;

	[Token(Token = "0x4000310")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x284")]
	private Rect stackRect;

	[Token(Token = "0x4000311")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x294")]
	private Rect graphRect;

	[Token(Token = "0x4000312")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A4")]
	private Rect graphMinRect;

	[Token(Token = "0x4000313")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B4")]
	private Rect graphMaxRect;

	[Token(Token = "0x4000314")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C4")]
	private Rect buttomRect;

	[Token(Token = "0x4000315")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D4")]
	private Vector2 stackRectTopLeft;

	[Token(Token = "0x4000316")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2DC")]
	private Rect detailRect;

	[Token(Token = "0x4000317")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2EC")]
	private Vector2 scrollPosition;

	[Token(Token = "0x4000318")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2F4")]
	private Vector2 scrollPosition2;

	[Token(Token = "0x4000319")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2FC")]
	private Vector2 toolbarScrollPosition;

	[Token(Token = "0x400031A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
	private Log selectedLog;

	[Token(Token = "0x400031B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
	private float toolbarOldDrag;

	[Token(Token = "0x400031C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x314")]
	private float oldDrag;

	[Token(Token = "0x400031D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
	private float oldDrag2;

	[Token(Token = "0x400031E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31C")]
	private float oldDrag3;

	[Token(Token = "0x400031F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
	private int startIndex;

	[Token(Token = "0x4000320")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x324")]
	private Rect countRect;

	[Token(Token = "0x4000321")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x334")]
	private Rect timeRect;

	[Token(Token = "0x4000322")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x344")]
	private Rect timeLabelRect;

	[Token(Token = "0x4000323")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x354")]
	private Rect sceneRect;

	[Token(Token = "0x4000324")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x364")]
	private Rect sceneLabelRect;

	[Token(Token = "0x4000325")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x374")]
	private Rect memoryRect;

	[Token(Token = "0x4000326")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x384")]
	private Rect memoryLabelRect;

	[Token(Token = "0x4000327")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x394")]
	private Rect fpsRect;

	[Token(Token = "0x4000328")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3A4")]
	private Rect fpsLabelRect;

	[Token(Token = "0x4000329")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3B8")]
	private GUIContent tempContent;

	[Token(Token = "0x400032A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C0")]
	private Vector2 infoScrollPosition;

	[Token(Token = "0x400032B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C8")]
	private Vector2 oldInfoDrag;

	[Token(Token = "0x400032C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D0")]
	private Rect tempRect;

	[Token(Token = "0x400032D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3E0")]
	private float graphSize;

	[Token(Token = "0x400032E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3E4")]
	private int startFrame;

	[Token(Token = "0x400032F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3E8")]
	private int currentFrame;

	[Token(Token = "0x4000330")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3EC")]
	private Vector3 tempVector1;

	[Token(Token = "0x4000331")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3F8")]
	private Vector3 tempVector2;

	[Token(Token = "0x4000332")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x404")]
	private Vector2 graphScrollerPos;

	[Token(Token = "0x4000333")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40C")]
	private float maxFpsValue;

	[Token(Token = "0x4000334")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x410")]
	private float minFpsValue;

	[Token(Token = "0x4000335")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x414")]
	private float maxMemoryValue;

	[Token(Token = "0x4000336")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x418")]
	private float minMemoryValue;

	[Token(Token = "0x4000337")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x420")]
	private List<Vector2> gestureDetector;

	[Token(Token = "0x4000338")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x428")]
	private Vector2 gestureSum;

	[Token(Token = "0x4000339")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x430")]
	private float gestureLength;

	[Token(Token = "0x400033A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x434")]
	private int gestureCount;

	[Token(Token = "0x400033B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x438")]
	private float lastClickTime;

	[Token(Token = "0x400033C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x43C")]
	private Vector2 startPos;

	[Token(Token = "0x400033D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x444")]
	private Vector2 downPos;

	[Token(Token = "0x400033E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44C")]
	private Vector2 mousePosition;

	[Token(Token = "0x400033F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x454")]
	private int frames;

	[Token(Token = "0x4000340")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x458")]
	private bool firstTime;

	[Token(Token = "0x4000341")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x45C")]
	private float lastUpdate;

	[Token(Token = "0x4000342")]
	private const int requiredFrames = 10;

	[Token(Token = "0x4000343")]
	private const float updateInterval = 0.25f;

	[Token(Token = "0x4000344")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x460")]
	private List<Log> threadedLogs;

	[Token(Token = "0x17000047")]
	public float TotalMemUsage
	{
		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x7D59C8", Offset = "0x7D59C8", VA = "0x7D59C8")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x60002F9")]
	[Address(RVA = "0x7D59D4", Offset = "0x7D59D4", VA = "0x7D59D4")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002FA")]
	[Address(RVA = "0x7D6624", Offset = "0x7D6624", VA = "0x7D6624")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60002FB")]
	[Address(RVA = "0x7D66C0", Offset = "0x7D66C0", VA = "0x7D66C0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60002FC")]
	[Address(RVA = "0x7D6810", Offset = "0x7D6810", VA = "0x7D6810")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60002FD")]
	[Address(RVA = "0x7D6814", Offset = "0x7D6814", VA = "0x7D6814")]
	private void addSample()
	{
	}

	[Token(Token = "0x60002FE")]
	[Address(RVA = "0x7D5A80", Offset = "0x7D5A80", VA = "0x7D5A80")]
	public void Initialize()
	{
	}

	[Token(Token = "0x60002FF")]
	[Address(RVA = "0x7D693C", Offset = "0x7D693C", VA = "0x7D693C")]
	private void initializeStyle()
	{
	}

	[Token(Token = "0x6000300")]
	[Address(RVA = "0x7D77B8", Offset = "0x7D77B8", VA = "0x7D77B8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000301")]
	[Address(RVA = "0x7D6724", Offset = "0x7D6724", VA = "0x7D6724")]
	private void clear()
	{
	}

	[Token(Token = "0x6000302")]
	[Address(RVA = "0x7D7858", Offset = "0x7D7858", VA = "0x7D7858")]
	private void calculateCurrentLog()
	{
	}

	[Token(Token = "0x6000303")]
	[Address(RVA = "0x7D7B40", Offset = "0x7D7B40", VA = "0x7D7B40")]
	private void DrawInfo()
	{
	}

	[Token(Token = "0x6000304")]
	[Address(RVA = "0x7D9CB8", Offset = "0x7D9CB8", VA = "0x7D9CB8")]
	private void drawInfo_enableDisableToolBarButtons()
	{
	}

	[Token(Token = "0x6000305")]
	[Address(RVA = "0x7DA828", Offset = "0x7DA828", VA = "0x7DA828")]
	private void DrawReport()
	{
	}

	[Token(Token = "0x6000306")]
	[Address(RVA = "0x7DAD10", Offset = "0x7DAD10", VA = "0x7DAD10")]
	private void drawToolBar()
	{
	}

	[Token(Token = "0x6000307")]
	[Address(RVA = "0x7DC82C", Offset = "0x7DC82C", VA = "0x7DC82C")]
	private void DrawLogs()
	{
	}

	[Token(Token = "0x6000308")]
	[Address(RVA = "0x7DDA58", Offset = "0x7DDA58", VA = "0x7DDA58")]
	private void drawGraph()
	{
	}

	[Token(Token = "0x6000309")]
	[Address(RVA = "0x7DECD4", Offset = "0x7DECD4", VA = "0x7DECD4")]
	private void drawStack()
	{
	}

	[Token(Token = "0x600030A")]
	[Address(RVA = "0x7DF880", Offset = "0x7DF880", VA = "0x7DF880")]
	public void OnGUIDraw()
	{
	}

	[Token(Token = "0x600030B")]
	[Address(RVA = "0x7DFBD4", Offset = "0x7DFBD4", VA = "0x7DFBD4")]
	private bool isGestureDone()
	{
		return default(bool);
	}

	[Token(Token = "0x600030C")]
	[Address(RVA = "0x7E0114", Offset = "0x7E0114", VA = "0x7E0114")]
	private bool isDoubleClickDone()
	{
		return default(bool);
	}

	[Token(Token = "0x600030D")]
	[Address(RVA = "0x7DFAA8", Offset = "0x7DFAA8", VA = "0x7DFAA8")]
	private Vector2 getDownPos()
	{
		return default(Vector2);
	}

	[Token(Token = "0x600030E")]
	[Address(RVA = "0x7D9B18", Offset = "0x7D9B18", VA = "0x7D9B18")]
	private Vector2 getDrag()
	{
		return default(Vector2);
	}

	[Token(Token = "0x600030F")]
	[Address(RVA = "0x7E0224", Offset = "0x7E0224", VA = "0x7E0224")]
	private void calculateStartIndex()
	{
	}

	[Token(Token = "0x6000310")]
	[Address(RVA = "0x7D7680", Offset = "0x7D7680", VA = "0x7D7680")]
	private void doShow()
	{
	}

	[Token(Token = "0x6000311")]
	[Address(RVA = "0x7E02E0", Offset = "0x7E02E0", VA = "0x7E02E0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000312")]
	[Address(RVA = "0x7E0C6C", Offset = "0x7E0C6C", VA = "0x7E0C6C")]
	private void CaptureLog(string condition, string stacktrace, LogType type)
	{
	}

	[Token(Token = "0x6000313")]
	[Address(RVA = "0x7E0668", Offset = "0x7E0668", VA = "0x7E0668")]
	private void AddLog(string condition, string stacktrace, LogType type)
	{
	}

	[Token(Token = "0x6000314")]
	[Address(RVA = "0x7E0CBC", Offset = "0x7E0CBC", VA = "0x7E0CBC")]
	private void CaptureLogThread(string condition, string stacktrace, LogType type)
	{
	}

	[Token(Token = "0x6000315")]
	[Address(RVA = "0x7E0DD0", Offset = "0x7E0DD0", VA = "0x7E0DD0")]
	private void _OnLevelWasLoaded(Scene _null1, LoadSceneMode _null2)
	{
	}

	[Token(Token = "0x6000316")]
	[Address(RVA = "0x7E0EDC", Offset = "0x7E0EDC", VA = "0x7E0EDC")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x6000317")]
	[Address(RVA = "0x7E1100", Offset = "0x7E1100", VA = "0x7E1100")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5FE0A8", Offset = "0x5FE0A8")]
	private IEnumerator readInfo()
	{
		return null;
	}

	[Token(Token = "0x6000318")]
	[Address(RVA = "0x7DC4F8", Offset = "0x7DC4F8", VA = "0x7DC4F8")]
	private void SaveLogsToDevice()
	{
	}

	[Token(Token = "0x6000319")]
	[Address(RVA = "0x7E119C", Offset = "0x7E119C", VA = "0x7E119C")]
	public Reporter()
	{
	}
}
[Token(Token = "0x2000080")]
public class ReporterGUI : MonoBehaviour
{
	[Token(Token = "0x4000345")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Reporter reporter;

	[Token(Token = "0x600031B")]
	[Address(RVA = "0x7E1888", Offset = "0x7E1888", VA = "0x7E1888")]
	private void Awake()
	{
	}

	[Token(Token = "0x600031C")]
	[Address(RVA = "0x7E18F0", Offset = "0x7E18F0", VA = "0x7E18F0")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600031D")]
	[Address(RVA = "0x7E1908", Offset = "0x7E1908", VA = "0x7E1908")]
	public ReporterGUI()
	{
	}
}
[Token(Token = "0x2000081")]
public class ReporterMessageReceiver : MonoBehaviour
{
	[Token(Token = "0x4000346")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Reporter reporter;

	[Token(Token = "0x600031E")]
	[Address(RVA = "0x7E1910", Offset = "0x7E1910", VA = "0x7E1910")]
	private void Start()
	{
	}

	[Token(Token = "0x600031F")]
	[Address(RVA = "0x7E1978", Offset = "0x7E1978", VA = "0x7E1978")]
	private void OnPreStart()
	{
	}

	[Token(Token = "0x6000320")]
	[Address(RVA = "0x7E1A80", Offset = "0x7E1A80", VA = "0x7E1A80")]
	private void OnHideReporter()
	{
	}

	[Token(Token = "0x6000321")]
	[Address(RVA = "0x7E1A84", Offset = "0x7E1A84", VA = "0x7E1A84")]
	private void OnShowReporter()
	{
	}

	[Token(Token = "0x6000322")]
	[Address(RVA = "0x7E1A88", Offset = "0x7E1A88", VA = "0x7E1A88")]
	private void OnLog(Reporter.Log log)
	{
	}

	[Token(Token = "0x6000323")]
	[Address(RVA = "0x7E1A8C", Offset = "0x7E1A8C", VA = "0x7E1A8C")]
	public ReporterMessageReceiver()
	{
	}
}
[Token(Token = "0x2000082")]
public class Rotate : MonoBehaviour
{
	[Token(Token = "0x4000347")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Vector3 angle;

	[Token(Token = "0x6000324")]
	[Address(RVA = "0x7E1D08", Offset = "0x7E1D08", VA = "0x7E1D08")]
	private void Start()
	{
	}

	[Token(Token = "0x6000325")]
	[Address(RVA = "0x7E1D44", Offset = "0x7E1D44", VA = "0x7E1D44")]
	private void Update()
	{
	}

	[Token(Token = "0x6000326")]
	[Address(RVA = "0x7E1DA8", Offset = "0x7E1DA8", VA = "0x7E1DA8")]
	public Rotate()
	{
	}
}
[Token(Token = "0x2000083")]
public class TestReporter : MonoBehaviour
{
	[Token(Token = "0x4000348")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int logTestCount;

	[Token(Token = "0x4000349")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int threadLogTestCount;

	[Token(Token = "0x400034A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool logEverySecond;

	[Token(Token = "0x400034B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private int currentLogTestCount;

	[Token(Token = "0x400034C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Reporter reporter;

	[Token(Token = "0x400034D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GUIStyle style;

	[Token(Token = "0x400034E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Rect rect1;

	[Token(Token = "0x400034F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Rect rect2;

	[Token(Token = "0x4000350")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Rect rect3;

	[Token(Token = "0x4000351")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Rect rect4;

	[Token(Token = "0x4000352")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Rect rect5;

	[Token(Token = "0x4000353")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Rect rect6;

	[Token(Token = "0x4000354")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private Thread thread;

	[Token(Token = "0x4000355")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private float elapsed;

	[Token(Token = "0x6000327")]
	[Address(RVA = "0x7EA004", Offset = "0x7EA004", VA = "0x7EA004")]
	private void Start()
	{
	}

	[Token(Token = "0x6000328")]
	[Address(RVA = "0x7EA50C", Offset = "0x7EA50C", VA = "0x7EA50C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000329")]
	[Address(RVA = "0x7EA528", Offset = "0x7EA528", VA = "0x7EA528")]
	private void threadLogTest()
	{
	}

	[Token(Token = "0x600032A")]
	[Address(RVA = "0x7EA5F4", Offset = "0x7EA5F4", VA = "0x7EA5F4")]
	private void Update()
	{
	}

	[Token(Token = "0x600032B")]
	[Address(RVA = "0x7EA7C4", Offset = "0x7EA7C4", VA = "0x7EA7C4")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600032C")]
	[Address(RVA = "0x7EAAC0", Offset = "0x7EAAC0", VA = "0x7EAAC0")]
	public TestReporter()
	{
	}
}
[Token(Token = "0x2000084")]
public class AtlasAnimation : MonoBehaviour
{
	[Token(Token = "0x4000356")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int elements;

	[Token(Token = "0x4000357")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int rows;

	[Token(Token = "0x4000358")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float fps;

	[Token(Token = "0x4000359")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float t;

	[Token(Token = "0x400035A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int i;

	[Token(Token = "0x400035B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private RawImage target;

	[Token(Token = "0x600032D")]
	[Address(RVA = "0x828194", Offset = "0x828194", VA = "0x828194")]
	private void Start()
	{
	}

	[Token(Token = "0x600032E")]
	[Address(RVA = "0x8281EC", Offset = "0x8281EC", VA = "0x8281EC")]
	private void Update()
	{
	}

	[Token(Token = "0x600032F")]
	[Address(RVA = "0x8283B8", Offset = "0x8283B8", VA = "0x8283B8")]
	public AtlasAnimation()
	{
	}
}
[Token(Token = "0x2000085")]
public class FadeChilds : MonoBehaviour
{
	[Token(Token = "0x400035C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float value;

	[Token(Token = "0x400035D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<Image> imageElements;

	[Token(Token = "0x400035E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<Text> textElements;

	[Token(Token = "0x6000330")]
	[Address(RVA = "0x7B42A8", Offset = "0x7B42A8", VA = "0x7B42A8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000331")]
	[Address(RVA = "0x7B4674", Offset = "0x7B4674", VA = "0x7B4674")]
	private void Update()
	{
	}

	[Token(Token = "0x6000332")]
	[Address(RVA = "0x7B4354", Offset = "0x7B4354", VA = "0x7B4354")]
	private void AddElementsFromChildren(Transform t)
	{
	}

	[Token(Token = "0x6000333")]
	[Address(RVA = "0x7B4994", Offset = "0x7B4994", VA = "0x7B4994")]
	public FadeChilds()
	{
	}
}
[Token(Token = "0x2000086")]
public class MainVideoControls : MonoBehaviour
{
	[Token(Token = "0x2000174")]
	public enum State
	{
		[Token(Token = "0x40006FA")]
		HideAll,
		[Token(Token = "0x40006FB")]
		ShowSlider,
		[Token(Token = "0x40006FC")]
		ShowSounds,
		[Token(Token = "0x40006FD")]
		ShowEndPage
	}

	[Token(Token = "0x400035F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static MainVideoControls instance;

	[Token(Token = "0x4000360")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float fadeAfter;

	[Token(Token = "0x4000361")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject videoControlsGraphics;

	[Token(Token = "0x4000362")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public HeadjackTemplate.UI.Menu.Page.Video.VideoControls videoControls;

	[Token(Token = "0x4000363")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject soundsControls;

	[Token(Token = "0x4000364")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject miniSoundsControls;

	[Token(Token = "0x4000365")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject endScrean;

	[Token(Token = "0x4000366")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float angleDiffReset;

	[Token(Token = "0x4000367")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float menuCameraHeightDiff;

	[Token(Token = "0x4000368")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float menuHeightDiffReset;

	[Token(Token = "0x4000369")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float menuPositionDiffReset;

	[Token(Token = "0x400036A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool isBlockVideoControlPanel;

	[Token(Token = "0x400036B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject controller;

	[Token(Token = "0x400036C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GameObject laserHeadjeck;

	[Token(Token = "0x400036D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject laserCurved;

	[Token(Token = "0x400036E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private bool cardboard_Build;

	[Token(Token = "0x400036F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private State _state;

	[Token(Token = "0x4000370")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private Text textTime;

	[Token(Token = "0x4000371")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool _menuWasClicked;

	[Token(Token = "0x4000372")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
	private bool paused;

	[Token(Token = "0x4000373")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private float videoTimer;

	[Token(Token = "0x4000374")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private float min5;

	[Token(Token = "0x4000375")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private float min10;

	[Token(Token = "0x17000048")]
	public State Page
	{
		[Token(Token = "0x6000334")]
		[Address(RVA = "0x7CF898", Offset = "0x7CF898", VA = "0x7CF898")]
		get
		{
			return default(State);
		}
		[Token(Token = "0x6000335")]
		[Address(RVA = "0x7CF8A0", Offset = "0x7CF8A0", VA = "0x7CF8A0")]
		private set
		{
		}
	}

	[Token(Token = "0x17000049")]
	public float VideoTimer
	{
		[Token(Token = "0x6000344")]
		[Address(RVA = "0x7D0734", Offset = "0x7D0734", VA = "0x7D0734")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700004A")]
	public bool Paused
	{
		[Token(Token = "0x6000345")]
		[Address(RVA = "0x7D073C", Offset = "0x7D073C", VA = "0x7D073C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700004B")]
	public float MIN5
	{
		[Token(Token = "0x6000346")]
		[Address(RVA = "0x7D0744", Offset = "0x7D0744", VA = "0x7D0744")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700004C")]
	public float MIN10
	{
		[Token(Token = "0x6000347")]
		[Address(RVA = "0x7D074C", Offset = "0x7D074C", VA = "0x7D074C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6000336")]
	[Address(RVA = "0x7CF910", Offset = "0x7CF910", VA = "0x7CF910")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000337")]
	[Address(RVA = "0x7CFAA8", Offset = "0x7CFAA8", VA = "0x7CFAA8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000338")]
	[Address(RVA = "0x7CFD1C", Offset = "0x7CFD1C", VA = "0x7CFD1C")]
	private void OculusRecenter()
	{
	}

	[Token(Token = "0x6000339")]
	[Address(RVA = "0x7D0110", Offset = "0x7D0110", VA = "0x7D0110")]
	private void SetVideoControlsHeight()
	{
	}

	[Token(Token = "0x600033A")]
	[Address(RVA = "0x7D0400", Offset = "0x7D0400", VA = "0x7D0400")]
	private void ControllersSetActive(bool active)
	{
	}

	[Token(Token = "0x600033B")]
	[Address(RVA = "0x7CA398", Offset = "0x7CA398", VA = "0x7CA398")]
	public void OpenPageAudioSettings()
	{
	}

	[Token(Token = "0x600033C")]
	[Address(RVA = "0x7D0480", Offset = "0x7D0480", VA = "0x7D0480")]
	private void OpenSmallAudioSettings()
	{
	}

	[Token(Token = "0x600033D")]
	[Address(RVA = "0x7D0544", Offset = "0x7D0544", VA = "0x7D0544")]
	private void OpenExplicitAudioSettings()
	{
	}

	[Token(Token = "0x600033E")]
	[Address(RVA = "0x7D0608", Offset = "0x7D0608", VA = "0x7D0608")]
	public void OpenPageVideoSlider()
	{
	}

	[Token(Token = "0x600033F")]
	[Address(RVA = "0x7BD3D0", Offset = "0x7BD3D0", VA = "0x7BD3D0")]
	public void OpenPageVideoEnd()
	{
	}

	[Token(Token = "0x6000340")]
	[Address(RVA = "0x7CF980", Offset = "0x7CF980", VA = "0x7CF980")]
	public void CloseAllPages()
	{
	}

	[Token(Token = "0x6000341")]
	[Address(RVA = "0x7CFF98", Offset = "0x7CFF98", VA = "0x7CFF98")]
	private void ClickListenerUpdate()
	{
	}

	[Token(Token = "0x6000342")]
	[Address(RVA = "0x7CF8DC", Offset = "0x7CF8DC", VA = "0x7CF8DC")]
	private void OpenPageByState(State state)
	{
	}

	[Token(Token = "0x6000343")]
	[Address(RVA = "0x7CA2C0", Offset = "0x7CA2C0", VA = "0x7CA2C0")]
	public void ToMenu()
	{
	}

	[Token(Token = "0x6000348")]
	[Address(RVA = "0x7C9C10", Offset = "0x7C9C10", VA = "0x7C9C10")]
	public void OnSliderValueChanged(float sliderValue)
	{
	}

	[Token(Token = "0x6000349")]
	[Address(RVA = "0x7CFD7C", Offset = "0x7CFD7C", VA = "0x7CFD7C")]
	private void SetStaticVideoTime(float value)
	{
	}

	[Token(Token = "0x600034A")]
	[Address(RVA = "0x7D0754", Offset = "0x7D0754", VA = "0x7D0754")]
	private string FormatTime(long milliseconds = 0L, long seconds = 0L)
	{
		return null;
	}

	[Token(Token = "0x600034B")]
	[Address(RVA = "0x7BDCD0", Offset = "0x7BDCD0", VA = "0x7BDCD0")]
	public void SetPageStatus(State hideAll)
	{
	}

	[Token(Token = "0x600034C")]
	[Address(RVA = "0x7C9B64", Offset = "0x7C9B64", VA = "0x7C9B64")]
	public void Pause()
	{
	}

	[Token(Token = "0x600034D")]
	[Address(RVA = "0x7C9E0C", Offset = "0x7C9E0C", VA = "0x7C9E0C")]
	public void Resume()
	{
	}

	[Token(Token = "0x600034E")]
	[Address(RVA = "0x7C9F08", Offset = "0x7C9F08", VA = "0x7C9F08")]
	public void Seek(int seconds)
	{
	}

	[Token(Token = "0x600034F")]
	[Address(RVA = "0x7BDFD0", Offset = "0x7BDFD0", VA = "0x7BDFD0")]
	public void ResetVideoControls()
	{
	}

	[Token(Token = "0x6000350")]
	[Address(RVA = "0x7D07EC", Offset = "0x7D07EC", VA = "0x7D07EC")]
	public MainVideoControls()
	{
	}
}
[Token(Token = "0x2000087")]
public class PlayVideo : MonoBehaviour
{
	[Token(Token = "0x2000175")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB1F4", Offset = "0x5FB1F4")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x40006FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string p;

		[Token(Token = "0x6000968")]
		[Address(RVA = "0x7D10CC", Offset = "0x7D10CC", VA = "0x7D10CC")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x6000969")]
		[Address(RVA = "0x7D10D4", Offset = "0x7D10D4", VA = "0x7D10D4")]
		internal void <Start>b__1(bool ss, string ee)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000176")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB204", Offset = "0x5FB204")]
	private sealed class <>c
	{
		[Token(Token = "0x40006FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000700")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static OnEnd <>9__0_0;

		[Token(Token = "0x600096B")]
		[Address(RVA = "0x7D0F74", Offset = "0x7D0F74", VA = "0x7D0F74")]
		public <>c()
		{
		}

		[Token(Token = "0x600096C")]
		[Address(RVA = "0x7D0F7C", Offset = "0x7D0F7C", VA = "0x7D0F7C")]
		internal void <Start>b__0_0(bool s, string e)
		{
		}
	}

	[Token(Token = "0x6000351")]
	[Address(RVA = "0x7D0E00", Offset = "0x7D0E00", VA = "0x7D0E00")]
	private void Start()
	{
	}

	[Token(Token = "0x6000352")]
	[Address(RVA = "0x7D0F04", Offset = "0x7D0F04", VA = "0x7D0F04")]
	private void Update()
	{
	}

	[Token(Token = "0x6000353")]
	[Address(RVA = "0x7D0F08", Offset = "0x7D0F08", VA = "0x7D0F08")]
	public PlayVideo()
	{
	}
}
[Token(Token = "0x2000088")]
public class SeekSlider : Slider
{
	[Token(Token = "0x4000376")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15A")]
	public bool holdingDown;

	[Token(Token = "0x4000377")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15B")]
	public bool hover;

	[Token(Token = "0x4000378")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	public GameObject sliderHandle;

	[Token(Token = "0x4000379")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private bool updateToCurrentSeek;

	[Token(Token = "0x6000354")]
	[Address(RVA = "0x7E356C", Offset = "0x7E356C", VA = "0x7E356C", Slot = "32")]
	public override void OnPointerDown(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000355")]
	[Address(RVA = "0x7E359C", Offset = "0x7E359C", VA = "0x7E359C", Slot = "33")]
	public override void OnPointerUp(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000356")]
	[Address(RVA = "0x7E36B4", Offset = "0x7E36B4", VA = "0x7E36B4", Slot = "34")]
	public override void OnPointerEnter(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000357")]
	[Address(RVA = "0x7E36C4", Offset = "0x7E36C4", VA = "0x7E36C4", Slot = "35")]
	public override void OnPointerExit(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000358")]
	[Address(RVA = "0x7E36D0", Offset = "0x7E36D0", VA = "0x7E36D0")]
	private new void Update()
	{
	}

	[Token(Token = "0x6000359")]
	[Address(RVA = "0x7E3834", Offset = "0x7E3834", VA = "0x7E3834")]
	public SeekSlider()
	{
	}
}
[Token(Token = "0x2000089")]
[ExecuteInEditMode]
public class UpdatePhysicsColliderSize : MonoBehaviour
{
	[Token(Token = "0x400037A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float widthExpand;

	[Token(Token = "0x400037B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float heightExpand;

	[Token(Token = "0x400037C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public RectTransform parent;

	[Token(Token = "0x400037D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private BoxCollider physicsCollider;

	[Token(Token = "0x600035A")]
	[Address(RVA = "0x10771C0", Offset = "0x10771C0", VA = "0x10771C0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600035B")]
	[Address(RVA = "0x1077268", Offset = "0x1077268", VA = "0x1077268")]
	private void Update()
	{
	}

	[Token(Token = "0x600035C")]
	[Address(RVA = "0x10773C0", Offset = "0x10773C0", VA = "0x10773C0")]
	public void ShowMessage()
	{
	}

	[Token(Token = "0x600035D")]
	[Address(RVA = "0x107742C", Offset = "0x107742C", VA = "0x107742C")]
	public UpdatePhysicsColliderSize()
	{
	}
}
[Token(Token = "0x200008A")]
public class VideoButton : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler
{
	[Token(Token = "0x400037E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool isToggle;

	[Token(Token = "0x400037F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool activated;

	[Token(Token = "0x4000380")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Image block;

	[Token(Token = "0x4000381")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Image graphic;

	[Token(Token = "0x4000382")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Sprite originalGraphic;

	[Token(Token = "0x4000383")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Sprite onGraphic;

	[Token(Token = "0x4000384")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Sprite offGraphic;

	[Token(Token = "0x4000385")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private VideoControls videoControls;

	[Token(Token = "0x600035E")]
	[Address(RVA = "0x1077434", Offset = "0x1077434", VA = "0x1077434")]
	private void Start()
	{
	}

	[Token(Token = "0x600035F")]
	[Address(RVA = "0x1077510", Offset = "0x1077510", VA = "0x1077510", Slot = "8")]
	public void OnPointerClick(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000360")]
	[Address(RVA = "0x107755C", Offset = "0x107755C", VA = "0x107755C", Slot = "4")]
	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000361")]
	[Address(RVA = "0x1077624", Offset = "0x1077624", VA = "0x1077624", Slot = "5")]
	public void OnPointerExit(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000362")]
	[Address(RVA = "0x10776EC", Offset = "0x10776EC", VA = "0x10776EC", Slot = "6")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000363")]
	[Address(RVA = "0x10777B4", Offset = "0x10777B4", VA = "0x10777B4", Slot = "7")]
	public void OnPointerUp(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000364")]
	[Address(RVA = "0x10778F4", Offset = "0x10778F4", VA = "0x10778F4")]
	public void SetIsToggle(bool newIsToggle)
	{
	}

	[Token(Token = "0x6000365")]
	[Address(RVA = "0x107793C", Offset = "0x107793C", VA = "0x107793C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000366")]
	[Address(RVA = "0x1077A7C", Offset = "0x1077A7C", VA = "0x1077A7C")]
	public VideoButton()
	{
	}
}
[Token(Token = "0x200008B")]
public class VideoControls : MonoBehaviour
{
	[Token(Token = "0x2000177")]
	public enum Menu
	{
		[Token(Token = "0x4000702")]
		Main,
		[Token(Token = "0x4000703")]
		Subtitle
	}

	[Token(Token = "0x4000386")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static VideoControls instance;

	[Token(Token = "0x4000387")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool show;

	[Token(Token = "0x4000388")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Color blockNormal;

	[Token(Token = "0x4000389")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public Color blockHighlight;

	[Token(Token = "0x400038A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public Color blockPressed;

	[Token(Token = "0x400038B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public Color graphicNormal;

	[Token(Token = "0x400038C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public Color graphicHighlight;

	[Token(Token = "0x400038D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public Color graphicPressed;

	[Token(Token = "0x400038E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public bool showNextPrevious;

	[Token(Token = "0x400038F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Transform posX0Y1;

	[Token(Token = "0x4000390")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Transform posX1Y1;

	[Token(Token = "0x4000391")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Transform posX4Y1;

	[Token(Token = "0x4000392")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Transform posX5Y1;

	[Token(Token = "0x4000393")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public GameObject home;

	[Token(Token = "0x4000394")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public GameObject previous;

	[Token(Token = "0x4000395")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public GameObject next;

	[Token(Token = "0x4000396")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public VideoButton subtitles;

	[Token(Token = "0x4000397")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Image seekBarGraphic;

	[Token(Token = "0x4000398")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public Slider slider;

	[Token(Token = "0x4000399")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public CanvasGroup canvasGroup;

	[Token(Token = "0x400039A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public MainVideoControls mainVideoControls;

	[Token(Token = "0x400039B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public TextMeshProUGUI timeText;

	[Token(Token = "0x400039C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public TextMeshProUGUI projectTitle;

	[Token(Token = "0x400039D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public Animator animator;

	[Token(Token = "0x400039E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public Menu currentMenu;

	[Token(Token = "0x6000367")]
	[Address(RVA = "0x1077A84", Offset = "0x1077A84", VA = "0x1077A84")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000368")]
	[Address(RVA = "0x1077AD8", Offset = "0x1077AD8", VA = "0x1077AD8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000369")]
	[Address(RVA = "0x1077F5C", Offset = "0x1077F5C", VA = "0x1077F5C")]
	public void ShowSubtitleMenu()
	{
	}

	[Token(Token = "0x600036A")]
	[Address(RVA = "0x1077DC0", Offset = "0x1077DC0", VA = "0x1077DC0")]
	public string MS2HHMMSS(long timestamp)
	{
		return null;
	}

	[Token(Token = "0x600036B")]
	[Address(RVA = "0x1077F60", Offset = "0x1077F60", VA = "0x1077F60")]
	public VideoControls()
	{
	}
}
namespace HTC.UnityPlugin.Multimedia
{
	[Token(Token = "0x200008C")]
	public class FileSeeker
	{
		[Token(Token = "0x400039F")]
		private const string LOG_TAG = "[FileSeeker]";

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<FileInfo> contentInfo;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FC1CC", Offset = "0x5FC1CC")]
		private int <contentIndex>k__BackingField;

		[Token(Token = "0x1700004D")]
		public int contentIndex
		{
			[Token(Token = "0x600036C")]
			[Address(RVA = "0x7B601C", Offset = "0x7B601C", VA = "0x7B601C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FE10C", Offset = "0x5FE10C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600036D")]
			[Address(RVA = "0x7B6024", Offset = "0x7B6024", VA = "0x7B6024")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FE11C", Offset = "0x5FE11C")]
			private set
			{
			}
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x7B602C", Offset = "0x7B602C", VA = "0x7B602C")]
		public bool loadFolder(string path, string filter)
		{
			return default(bool);
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x7B6260", Offset = "0x7B6260", VA = "0x7B6260")]
		public string getPath()
		{
			return null;
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x7B6384", Offset = "0x7B6384", VA = "0x7B6384")]
		public string[] getPathAll()
		{
			return null;
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x7B6494", Offset = "0x7B6494", VA = "0x7B6494")]
		public int getFileNum()
		{
			return default(int);
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x7B64E4", Offset = "0x7B64E4", VA = "0x7B64E4")]
		public int toNext()
		{
			return default(int);
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x7B65C4", Offset = "0x7B65C4", VA = "0x7B65C4")]
		public int toPrev()
		{
			return default(int);
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x7B66A8", Offset = "0x7B66A8", VA = "0x7B66A8")]
		public void setIndex(int index)
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x7B6780", Offset = "0x7B6780", VA = "0x7B6780")]
		public FileSeeker()
		{
		}
	}
	[Token(Token = "0x200008D")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5FA924", Offset = "0x5FA924")]
	public class ImageSourceController : MonoBehaviour
	{
		[Token(Token = "0x2000178")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB214", Offset = "0x5FB214")]
		private sealed class <loadImageCoroutine>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000704")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000705")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000706")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string imagePath;

			[Token(Token = "0x4000707")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ImageSourceController <>4__this;

			[Token(Token = "0x4000708")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private WWW <www>5__2;

			[Token(Token = "0x170000DC")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000970")]
				[Address(RVA = "0x7B6EE8", Offset = "0x7B6EE8", VA = "0x7B6EE8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DD")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000972")]
				[Address(RVA = "0x7B6F50", Offset = "0x7B6F50", VA = "0x7B6F50", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600096D")]
			[Address(RVA = "0x7B6CC8", Offset = "0x7B6CC8", VA = "0x7B6CC8")]
			[DebuggerHidden]
			public <loadImageCoroutine>d__15(int <>1__state)
			{
			}

			[Token(Token = "0x600096E")]
			[Address(RVA = "0x7B6DEC", Offset = "0x7B6DEC", VA = "0x7B6DEC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600096F")]
			[Address(RVA = "0x7B6DF0", Offset = "0x7B6DF0", VA = "0x7B6DF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000971")]
			[Address(RVA = "0x7B6EF0", Offset = "0x7B6EF0", VA = "0x7B6EF0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected string LOG_TAG;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string folderPath;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string filter;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool isAdaptToResolution;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UnityEvent onInitComplete;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UnityEvent onChangeImage;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected bool isInitialized;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected FileSeeker fileSeeker;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected Texture2D texture;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected Vector3 oriScale;

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x7B67F0", Offset = "0x7B67F0", VA = "0x7B67F0", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x7B68B4", Offset = "0x7B68B4", VA = "0x7B68B4")]
		public void initFileSeeker()
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x7B6A18", Offset = "0x7B6A18", VA = "0x7B6A18")]
		public void loadImage()
		{
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x7B6B58", Offset = "0x7B6B58", VA = "0x7B6B58")]
		public void nextImage()
		{
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x7B6C10", Offset = "0x7B6C10", VA = "0x7B6C10")]
		public void prevImage()
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x7B6ADC", Offset = "0x7B6ADC", VA = "0x7B6ADC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5FE12C", Offset = "0x5FE12C")]
		protected IEnumerator loadImageCoroutine(string imagePath)
		{
			return null;
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x7B6CF4", Offset = "0x7B6CF4", VA = "0x7B6CF4", Slot = "5")]
		protected virtual void adaptResolution()
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x7B6D94", Offset = "0x7B6D94", VA = "0x7B6D94")]
		public ImageSourceController()
		{
		}
	}
	[Token(Token = "0x200008E")]
	public static class StereoHandler
	{
		[Token(Token = "0x2000179")]
		public enum StereoType
		{
			[Token(Token = "0x400070A")]
			SIDE_BY_SIDE,
			[Token(Token = "0x400070B")]
			TOP_DOWN
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x7B6F58", Offset = "0x7B6F58", VA = "0x7B6F58")]
		public static void SetStereoPair(StereoProperty stereoProperty, Material material)
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x7B6F80", Offset = "0x7B6F80", VA = "0x7B6F80")]
		public static void SetStereoPair(GameObject left, GameObject right, Material material, StereoType stereoType, bool isLeftFirst)
		{
		}
	}
	[Token(Token = "0x200008F")]
	public class StereoImageSourceController : ImageSourceController
	{
		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public StereoProperty stereoProperty;

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x7B72E4", Offset = "0x7B72E4", VA = "0x7B72E4", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x7B736C", Offset = "0x7B736C", VA = "0x7B736C", Slot = "5")]
		protected override void adaptResolution()
		{
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x7B743C", Offset = "0x7B743C", VA = "0x7B743C")]
		public StereoImageSourceController()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000090")]
	public class StereoProperty
	{
		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool isLeftFirst;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public StereoHandler.StereoType stereoType;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject left;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject right;

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x7B7440", Offset = "0x7B7440", VA = "0x7B7440")]
		public StereoProperty()
		{
		}
	}
	[Token(Token = "0x2000091")]
	public class StereoVideoSourceController : VideoSourceController
	{
		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public StereoProperty stereoProperty;

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x7B7450", Offset = "0x7B7450", VA = "0x7B7450", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x7B7534", Offset = "0x7B7534", VA = "0x7B7534", Slot = "5")]
		protected override void adaptResolution()
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x7B75E0", Offset = "0x7B75E0", VA = "0x7B75E0")]
		public StereoVideoSourceController()
		{
		}
	}
	[Token(Token = "0x2000092")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5FA988", Offset = "0x5FA988")]
	public class VideoSourceController : MonoBehaviour
	{
		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected string LOG_TAG;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string folderPath;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string filter;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool isAdaptToResolution;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UnityEvent onInitComplete;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UnityEvent onChangeVideo;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected bool isInitialized;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected FileSeeker fileSeeker;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected ViveMediaDecoder decoder;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected Vector3 oriScale;

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x7B74D8", Offset = "0x7B74D8", VA = "0x7B74D8", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x7B7C84", Offset = "0x7B7C84", VA = "0x7B7C84")]
		public void initFileSeeker()
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x7B7DE8", Offset = "0x7B7DE8", VA = "0x7B7DE8")]
		public void startVideoPlay()
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x7B8084", Offset = "0x7B8084", VA = "0x7B8084")]
		public void nextVideo()
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x7B8324", Offset = "0x7B8324", VA = "0x7B8324")]
		public void prevVideo()
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x7B83E8", Offset = "0x7B83E8", VA = "0x7B83E8")]
		public void stopVideo()
		{
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x7B8490", Offset = "0x7B8490", VA = "0x7B8490", Slot = "5")]
		protected virtual void adaptResolution()
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x7B75E4", Offset = "0x7B75E4", VA = "0x7B75E4")]
		public VideoSourceController()
		{
		}
	}
	[Token(Token = "0x2000093")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5FA9EC", Offset = "0x5FA9EC")]
	public class UVSphere : MonoBehaviour
	{
		[Token(Token = "0x200017A")]
		public enum FrontFaceType
		{
			[Token(Token = "0x400070D")]
			Inside,
			[Token(Token = "0x400070E")]
			Outside
		}

		[Token(Token = "0x200017B")]
		public enum TextureOrigin
		{
			[Token(Token = "0x4000710")]
			BottomLeft,
			[Token(Token = "0x4000711")]
			TopLeft
		}

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int Latitude;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int Longitude;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float Radius;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public FrontFaceType frontFaceType;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TextureOrigin textureOrigin;

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x7B763C", Offset = "0x7B763C", VA = "0x7B763C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x7B7648", Offset = "0x7B7648", VA = "0x7B7648")]
		private void GenerateUVSphere(int latNum, int longNum, float radius)
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x7B7C68", Offset = "0x7B7C68", VA = "0x7B7C68")]
		public UVSphere()
		{
		}
	}
	[Token(Token = "0x2000094")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5FAA6C", Offset = "0x5FAA6C")]
	public class ViveMediaDecoder : MonoBehaviour
	{
		[Token(Token = "0x200017C")]
		public enum DecoderState
		{
			[Token(Token = "0x4000713")]
			INIT_FAIL = -2,
			[Token(Token = "0x4000714")]
			STOP,
			[Token(Token = "0x4000715")]
			NOT_INITIALIZED,
			[Token(Token = "0x4000716")]
			INITIALIZING,
			[Token(Token = "0x4000717")]
			INITIALIZED,
			[Token(Token = "0x4000718")]
			START,
			[Token(Token = "0x4000719")]
			PAUSE,
			[Token(Token = "0x400071A")]
			SEEK_FRAME,
			[Token(Token = "0x400071B")]
			BUFFERING,
			[Token(Token = "0x400071C")]
			EOF
		}

		[Token(Token = "0x200017D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB224", Offset = "0x5FB224")]
		private sealed class <initDecoderAsync>d__88 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400071D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400071E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400071F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ViveMediaDecoder <>4__this;

			[Token(Token = "0x4000720")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string path;

			[Token(Token = "0x170000DE")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000976")]
				[Address(RVA = "0x7EC740", Offset = "0x7EC740", VA = "0x7EC740", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DF")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000978")]
				[Address(RVA = "0x7EC7A8", Offset = "0x7EC7A8", VA = "0x7EC7A8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000973")]
			[Address(RVA = "0x7EC538", Offset = "0x7EC538", VA = "0x7EC538")]
			[DebuggerHidden]
			public <initDecoderAsync>d__88(int <>1__state)
			{
			}

			[Token(Token = "0x6000974")]
			[Address(RVA = "0x7EC564", Offset = "0x7EC564", VA = "0x7EC564", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000975")]
			[Address(RVA = "0x7EC568", Offset = "0x7EC568", VA = "0x7EC568", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000977")]
			[Address(RVA = "0x7EC748", Offset = "0x7EC748", VA = "0x7EC748", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200017E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB234", Offset = "0x5FB234")]
		private sealed class <audioPlay>d__98 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000721")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000722")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000723")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ViveMediaDecoder <>4__this;

			[Token(Token = "0x4000724")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <swapIndex>5__2;

			[Token(Token = "0x4000725")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private double <audioDataTime>5__3;

			[Token(Token = "0x4000726")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int <playedAudioDataLength>5__4;

			[Token(Token = "0x4000727")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private float[] <audioDataSwap>5__5;

			[Token(Token = "0x170000E0")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600097C")]
				[Address(RVA = "0x7EC4C8", Offset = "0x7EC4C8", VA = "0x7EC4C8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E1")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600097E")]
				[Address(RVA = "0x7EC530", Offset = "0x7EC530", VA = "0x7EC530", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000979")]
			[Address(RVA = "0x7EBF9C", Offset = "0x7EBF9C", VA = "0x7EBF9C")]
			[DebuggerHidden]
			public <audioPlay>d__98(int <>1__state)
			{
			}

			[Token(Token = "0x600097A")]
			[Address(RVA = "0x7EBFC8", Offset = "0x7EBFC8", VA = "0x7EBFC8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600097B")]
			[Address(RVA = "0x7EBFCC", Offset = "0x7EBFCC", VA = "0x7EBFCC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600097D")]
			[Address(RVA = "0x7EC4D0", Offset = "0x7EC4D0", VA = "0x7EC4D0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003C1")]
		private const string NATIVE_LIBRARY_NAME = "ViveMediaDecoder";

		[Token(Token = "0x40003C2")]
		private const string VERSION = "1.1.6.180306";

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool playOnAwake;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string mediaPath;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UnityEvent onInitComplete;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UnityEvent onVideoEnd;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private DecoderState lastState;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private DecoderState decoderState;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int decoderID;

		[Token(Token = "0x40003CA")]
		private const string LOG_TAG = "[ViveMediaDecoder]";

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FC1DC", Offset = "0x5FC1DC")]
		private bool <isVideoEnabled>k__BackingField;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FC1EC", Offset = "0x5FC1EC")]
		private bool <isAudioEnabled>k__BackingField;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x46")]
		private bool isAllAudioChEnabled;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x47")]
		private bool useDefault;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool seekPreview;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Texture2D videoTexYch;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Texture2D videoTexUch;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Texture2D videoTexVch;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int videoWidth;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int videoHeight;

		[Token(Token = "0x40003D5")]
		private const int AUDIO_FRAME_SIZE = 2048;

		[Token(Token = "0x40003D6")]
		private const int SWAP_BUFFER_NUM = 4;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private AudioSource[] audioSource;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private List<float> audioDataBuff;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FC1FC", Offset = "0x5FC1FC")]
		private int <audioFrequency>k__BackingField;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FC20C", Offset = "0x5FC20C")]
		private int <audioChannels>k__BackingField;

		[Token(Token = "0x40003DB")]
		private const double OVERLAP_TIME = 0.02;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int audioOverlapLength;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private int audioDataLength;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float volume;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private double globalStartTime;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private bool isVideoReadyToReplay;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		private bool isAudioReadyToReplay;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private double audioProgressTime;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private double hangTime;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private double firstAudioFrameTime;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FC21C", Offset = "0x5FC21C")]
		private float <videoTotalTime>k__BackingField;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FC22C", Offset = "0x5FC22C")]
		private float <audioTotalTime>k__BackingField;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private BackgroundWorker backgroundWorker;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private object _lock;

		[Token(Token = "0x1700004E")]
		public bool isVideoEnabled
		{
			[Token(Token = "0x60003AC")]
			[Address(RVA = "0x7B93B8", Offset = "0x7B93B8", VA = "0x7B93B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FE190", Offset = "0x5FE190")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003AD")]
			[Address(RVA = "0x7B93C0", Offset = "0x7B93C0", VA = "0x7B93C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FE1A0", Offset = "0x5FE1A0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004F")]
		public bool isAudioEnabled
		{
			[Token(Token = "0x60003AE")]
			[Address(RVA = "0x7B93CC", Offset = "0x7B93CC", VA = "0x7B93CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FE1B0", Offset = "0x5FE1B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003AF")]
			[Address(RVA = "0x7B93D4", Offset = "0x7B93D4", VA = "0x7B93D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FE1C0", Offset = "0x5FE1C0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000050")]
		public int audioFrequency
		{
			[Token(Token = "0x60003B0")]
			[Address(RVA = "0x7B93E0", Offset = "0x7B93E0", VA = "0x7B93E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FE1D0", Offset = "0x5FE1D0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60003B1")]
			[Address(RVA = "0x7B93E8", Offset = "0x7B93E8", VA = "0x7B93E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FE1E0", Offset = "0x5FE1E0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000051")]
		public int audioChannels
		{
			[Token(Token = "0x60003B2")]
			[Address(RVA = "0x7B93F0", Offset = "0x7B93F0", VA = "0x7B93F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FE1F0", Offset = "0x5FE1F0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60003B3")]
			[Address(RVA = "0x7B93F8", Offset = "0x7B93F8", VA = "0x7B93F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FE200", Offset = "0x5FE200")]
			private set
			{
			}
		}

		[Token(Token = "0x17000052")]
		public float videoTotalTime
		{
			[Token(Token = "0x60003B4")]
			[Address(RVA = "0x7B9400", Offset = "0x7B9400", VA = "0x7B9400")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FE210", Offset = "0x5FE210")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003B5")]
			[Address(RVA = "0x7B9408", Offset = "0x7B9408", VA = "0x7B9408")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FE220", Offset = "0x5FE220")]
			private set
			{
			}
		}

		[Token(Token = "0x17000053")]
		public float audioTotalTime
		{
			[Token(Token = "0x60003B6")]
			[Address(RVA = "0x7B9410", Offset = "0x7B9410", VA = "0x7B9410")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FE230", Offset = "0x5FE230")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003B7")]
			[Address(RVA = "0x7B9418", Offset = "0x7B9418", VA = "0x7B9418")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FE240", Offset = "0x5FE240")]
			private set
			{
			}
		}

		[PreserveSig]
		[Token(Token = "0x6000392")]
		[Address(RVA = "0x7B84F8", Offset = "0x7B84F8", VA = "0x7B84F8")]
		private static extern int nativeCreateDecoder(string filePath, ref int id);

		[PreserveSig]
		[Token(Token = "0x6000393")]
		[Address(RVA = "0x7B859C", Offset = "0x7B859C", VA = "0x7B859C")]
		private static extern int nativeCreateDecoderAsync(string filePath, ref int id);

		[PreserveSig]
		[Token(Token = "0x6000394")]
		[Address(RVA = "0x7B8640", Offset = "0x7B8640", VA = "0x7B8640")]
		private static extern int nativeGetDecoderState(int id);

		[PreserveSig]
		[Token(Token = "0x6000395")]
		[Address(RVA = "0x7B86C0", Offset = "0x7B86C0", VA = "0x7B86C0")]
		private static extern void nativeCreateTexture(int id, ref IntPtr tex0, ref IntPtr tex1, ref IntPtr tex2);

		[PreserveSig]
		[Token(Token = "0x6000396")]
		[Address(RVA = "0x7B8768", Offset = "0x7B8768", VA = "0x7B8768")]
		private static extern bool nativeStartDecoding(int id);

		[PreserveSig]
		[Token(Token = "0x6000397")]
		[Address(RVA = "0x7B87F0", Offset = "0x7B87F0", VA = "0x7B87F0")]
		private static extern void nativeDestroyDecoder(int id);

		[PreserveSig]
		[Token(Token = "0x6000398")]
		[Address(RVA = "0x7B8870", Offset = "0x7B8870", VA = "0x7B8870")]
		private static extern bool nativeIsVideoBufferFull(int id);

		[PreserveSig]
		[Token(Token = "0x6000399")]
		[Address(RVA = "0x7B88F8", Offset = "0x7B88F8", VA = "0x7B88F8")]
		private static extern bool nativeIsVideoBufferEmpty(int id);

		[PreserveSig]
		[Token(Token = "0x600039A")]
		[Address(RVA = "0x7B8980", Offset = "0x7B8980", VA = "0x7B8980")]
		private static extern bool nativeIsEOF(int id);

		[PreserveSig]
		[Token(Token = "0x600039B")]
		[Address(RVA = "0x7B8A08", Offset = "0x7B8A08", VA = "0x7B8A08")]
		private static extern bool nativeIsVideoEnabled(int id);

		[PreserveSig]
		[Token(Token = "0x600039C")]
		[Address(RVA = "0x7B8A90", Offset = "0x7B8A90", VA = "0x7B8A90")]
		private static extern void nativeSetVideoEnable(int id, bool isEnable);

		[PreserveSig]
		[Token(Token = "0x600039D")]
		[Address(RVA = "0x7B8B20", Offset = "0x7B8B20", VA = "0x7B8B20")]
		private static extern void nativeGetVideoFormat(int id, ref int width, ref int height, ref float totalTime);

		[PreserveSig]
		[Token(Token = "0x600039E")]
		[Address(RVA = "0x7B8BC8", Offset = "0x7B8BC8", VA = "0x7B8BC8")]
		private static extern void nativeSetVideoTime(int id, float currentTime);

		[PreserveSig]
		[Token(Token = "0x600039F")]
		[Address(RVA = "0x7B8C58", Offset = "0x7B8C58", VA = "0x7B8C58")]
		private static extern bool nativeIsContentReady(int id);

		[PreserveSig]
		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x7B8CE0", Offset = "0x7B8CE0", VA = "0x7B8CE0")]
		private static extern double nativeGetVideoFrameTimestamp(int id);

		[PreserveSig]
		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x7B8D60", Offset = "0x7B8D60", VA = "0x7B8D60")]
		private static extern bool nativeIsAudioEnabled(int id);

		[PreserveSig]
		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x7B8DE8", Offset = "0x7B8DE8", VA = "0x7B8DE8")]
		private static extern void nativeSetAudioEnable(int id, bool isEnable);

		[PreserveSig]
		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x7B8E78", Offset = "0x7B8E78", VA = "0x7B8E78")]
		private static extern void nativeSetAudioAllChDataEnable(int id, bool isEnable);

		[PreserveSig]
		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x7B8F08", Offset = "0x7B8F08", VA = "0x7B8F08")]
		private static extern void nativeGetAudioFormat(int id, ref int channel, ref int frequency, ref float totalTime);

		[PreserveSig]
		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x7B8FB0", Offset = "0x7B8FB0", VA = "0x7B8FB0")]
		private static extern float nativeGetAudioData(int id, ref IntPtr output, ref int lengthPerChannel);

		[PreserveSig]
		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x7B9048", Offset = "0x7B9048", VA = "0x7B9048")]
		private static extern void nativeFreeAudioData(int id);

		[PreserveSig]
		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x7B90C8", Offset = "0x7B90C8", VA = "0x7B90C8")]
		private static extern void nativeSetSeekTime(int id, float sec);

		[PreserveSig]
		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x7B9158", Offset = "0x7B9158", VA = "0x7B9158")]
		private static extern bool nativeIsSeekOver(int id);

		[PreserveSig]
		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x7B91DC", Offset = "0x7B91DC", VA = "0x7B91DC")]
		private static extern int nativeGetMetaData(string filePath, out IntPtr key, out IntPtr value);

		[PreserveSig]
		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x7B928C", Offset = "0x7B928C", VA = "0x7B928C")]
		private static extern void nativeLoadThumbnail(int id, float time, IntPtr texY, IntPtr texU, IntPtr texV);

		[PreserveSig]
		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x7B9344", Offset = "0x7B9344", VA = "0x7B9344")]
		private static extern IntPtr GetRenderEventFunc();

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x7B9420", Offset = "0x7B9420", VA = "0x7B9420")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x7B94D4", Offset = "0x7B94D4", VA = "0x7B94D4")]
		private void Update()
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x7B7FA0", Offset = "0x7B7FA0", VA = "0x7B7FA0")]
		public void initDecoder(string path, bool enableAllAudioCh = false)
		{
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x7B998C", Offset = "0x7B998C", VA = "0x7B998C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5FE250", Offset = "0x5FE250")]
		private IEnumerator initDecoderAsync(string path)
		{
			return null;
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x7B9A08", Offset = "0x7B9A08", VA = "0x7B9A08")]
		private void getAudioFormat()
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x7B9A74", Offset = "0x7B9A74", VA = "0x7B9A74")]
		private void initAudioSource()
		{
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x7B9CEC", Offset = "0x7B9CEC", VA = "0x7B9CEC")]
		public void startDecoding()
		{
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x7B9E30", Offset = "0x7B9E30", VA = "0x7B9E30")]
		private void pullAudioData(object sender, DoWorkEventArgs e)
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x7B96EC", Offset = "0x7B96EC", VA = "0x7B96EC")]
		private void getTextureFromNative()
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x7BA144", Offset = "0x7BA144", VA = "0x7BA144")]
		private void ReleaseTexture()
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x7B97DC", Offset = "0x7B97DC", VA = "0x7B97DC")]
		private void setTextures(Texture ytex, Texture utex, Texture vtex)
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x7BA180", Offset = "0x7BA180", VA = "0x7BA180")]
		public void replay()
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x7BA39C", Offset = "0x7BA39C", VA = "0x7BA39C")]
		public void getAllAudioChannelData(out float[] data, out double time, out int samplesPerChannel)
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x7BA4DC", Offset = "0x7BA4DC", VA = "0x7BA4DC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5FE2B4", Offset = "0x5FE2B4")]
		private IEnumerator audioPlay()
		{
			return null;
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x7B8148", Offset = "0x7B8148", VA = "0x7B8148")]
		public void stopDecoding()
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x7BA1B8", Offset = "0x7BA1B8", VA = "0x7BA1B8")]
		public bool setSeekTime(float seekTime)
		{
			return default(bool);
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x7BA54C", Offset = "0x7BA54C", VA = "0x7BA54C")]
		public bool isSeeking()
		{
			return default(bool);
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x7BA590", Offset = "0x7BA590", VA = "0x7BA590")]
		public bool isVideoEOF()
		{
			return default(bool);
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x7BA5A0", Offset = "0x7BA5A0", VA = "0x7BA5A0")]
		public void setStepForward(float sec)
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x7BA5E8", Offset = "0x7BA5E8", VA = "0x7BA5E8")]
		public void setStepBackward(float sec)
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x7B75CC", Offset = "0x7B75CC", VA = "0x7B75CC")]
		public void getVideoResolution(ref int width, ref int height)
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x7BA630", Offset = "0x7BA630", VA = "0x7BA630")]
		public float getVideoCurrentTime()
		{
			return default(float);
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x7BA678", Offset = "0x7BA678", VA = "0x7BA678")]
		public double getVideoCurrentFrameTime()
		{
			return default(double);
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x7BA680", Offset = "0x7BA680", VA = "0x7BA680")]
		public DecoderState getDecoderState()
		{
			return default(DecoderState);
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x7B98B0", Offset = "0x7B98B0", VA = "0x7B98B0")]
		public void setPause()
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x7BA688", Offset = "0x7BA688", VA = "0x7BA688")]
		public void setResume()
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x7BA730", Offset = "0x7BA730", VA = "0x7BA730")]
		public void setVolume(float vol)
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x7BA858", Offset = "0x7BA858", VA = "0x7BA858")]
		public float getVolume()
		{
			return default(float);
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x7B9960", Offset = "0x7B9960", VA = "0x7B9960")]
		public void mute()
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x7B9958", Offset = "0x7B9958", VA = "0x7B9958")]
		public void unmute()
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x7BA860", Offset = "0x7BA860", VA = "0x7BA860")]
		public static void getMetaData(string filePath, out string[] key, out string[] value)
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x7BAB20", Offset = "0x7BAB20", VA = "0x7BAB20")]
		public static void loadVideoThumb(GameObject obj, string filePath, float time)
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x7BAD94", Offset = "0x7BAD94", VA = "0x7BAD94")]
		public void setAudioEnable(bool isEnable)
		{
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x7BAE00", Offset = "0x7BAE00", VA = "0x7BAE00")]
		public void setVideoEnable(bool isEnable)
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x7BAE6C", Offset = "0x7BAE6C", VA = "0x7BAE6C")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x7BAE70", Offset = "0x7BAE70", VA = "0x7BAE70")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x7BAE74", Offset = "0x7BAE74", VA = "0x7BAE74")]
		public ViveMediaDecoder()
		{
		}
	}
}
namespace TalesFromTheRift
{
	[Token(Token = "0x2000095")]
	public class CanvasKeyboard : MonoBehaviour
	{
		[Token(Token = "0x200017F")]
		public enum CanvasKeyboardType
		{
			[Token(Token = "0x4000729")]
			ASCIICapable
		}

		[Token(Token = "0x2000180")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB244", Offset = "0x5FB244")]
		private sealed class <ActivateInputFieldWithoutSelection>d__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400072A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400072B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x170000E2")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000982")]
				[Address(RVA = "0x7E9060", Offset = "0x7E9060", VA = "0x7E9060", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E3")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000984")]
				[Address(RVA = "0x7E90C8", Offset = "0x7E90C8", VA = "0x7E90C8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600097F")]
			[Address(RVA = "0x7E8F6C", Offset = "0x7E8F6C", VA = "0x7E8F6C")]
			[DebuggerHidden]
			public <ActivateInputFieldWithoutSelection>d__16(int <>1__state)
			{
			}

			[Token(Token = "0x6000980")]
			[Address(RVA = "0x7E8FCC", Offset = "0x7E8FCC", VA = "0x7E8FCC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000981")]
			[Address(RVA = "0x7E8FD0", Offset = "0x7E8FD0", VA = "0x7E8FD0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000983")]
			[Address(RVA = "0x7E9068", Offset = "0x7E9068", VA = "0x7E9068", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000181")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB254", Offset = "0x5FB254")]
		private sealed class <ActivateInputFieldWithoutSelection>d__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400072C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400072D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x170000E4")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000988")]
				[Address(RVA = "0x7E9164", Offset = "0x7E9164", VA = "0x7E9164", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E5")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600098A")]
				[Address(RVA = "0x7E91CC", Offset = "0x7E91CC", VA = "0x7E91CC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000985")]
			[Address(RVA = "0x7E8F98", Offset = "0x7E8F98", VA = "0x7E8F98")]
			[DebuggerHidden]
			public <ActivateInputFieldWithoutSelection>d__17(int <>1__state)
			{
			}

			[Token(Token = "0x6000986")]
			[Address(RVA = "0x7E90D0", Offset = "0x7E90D0", VA = "0x7E90D0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000987")]
			[Address(RVA = "0x7E90D4", Offset = "0x7E90D4", VA = "0x7E90D4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000989")]
			[Address(RVA = "0x7E916C", Offset = "0x7E916C", VA = "0x7E916C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject inputObject;

		[Token(Token = "0x17000054")]
		public static bool IsOpen
		{
			[Token(Token = "0x60003E1")]
			[Address(RVA = "0x7E8814", Offset = "0x7E8814", VA = "0x7E8814")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000055")]
		public string text
		{
			[Token(Token = "0x60003E3")]
			[Address(RVA = "0x7E88BC", Offset = "0x7E88BC", VA = "0x7E88BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003E4")]
			[Address(RVA = "0x7E8A88", Offset = "0x7E8A88", VA = "0x7E8A88")]
			set
			{
			}
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x7E8518", Offset = "0x7E8518", VA = "0x7E8518")]
		public static CanvasKeyboard Open(Canvas canvas, [Optional] GameObject inputObject, CanvasKeyboardType keyboardType = CanvasKeyboardType.ASCIICapable)
		{
			return null;
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x7E8778", Offset = "0x7E8778", VA = "0x7E8778")]
		public static CanvasKeyboard Open(CanvasKeyboard keyboard, [Optional] GameObject inputObject, CanvasKeyboardType keyboardType = CanvasKeyboardType.ASCIICapable)
		{
			return null;
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x7E86BC", Offset = "0x7E86BC", VA = "0x7E86BC")]
		public static void Close()
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x7E87E4", Offset = "0x7E87E4", VA = "0x7E87E4")]
		public static void Close(CanvasKeyboard keyboard)
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x7E8894", Offset = "0x7E8894", VA = "0x7E8894")]
		private void Start()
		{
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x7E8C54", Offset = "0x7E8C54", VA = "0x7E8C54")]
		public void SendKeyString(string keyString)
		{
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x7E87BC", Offset = "0x7E87BC", VA = "0x7E87BC")]
		public void CloseKeyboard()
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x7E8D6C", Offset = "0x7E8D6C", VA = "0x7E8D6C")]
		private void ReactivateInputField(TMP_InputField inputField)
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x7E8E6C", Offset = "0x7E8E6C", VA = "0x7E8E6C")]
		private void ReactivateInputField(InputField inputField)
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x7E8E0C", Offset = "0x7E8E0C", VA = "0x7E8E0C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5FE318", Offset = "0x5FE318")]
		private IEnumerator ActivateInputFieldWithoutSelection(TMP_InputField inputField)
		{
			return null;
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x7E8F0C", Offset = "0x7E8F0C", VA = "0x7E8F0C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5FE37C", Offset = "0x5FE37C")]
		private IEnumerator ActivateInputFieldWithoutSelection(InputField inputField)
		{
			return null;
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x7E8FC4", Offset = "0x7E8FC4", VA = "0x7E8FC4")]
		public CanvasKeyboard()
		{
		}
	}
	[Token(Token = "0x2000096")]
	public class CanvasKeyboardASCII : MonoBehaviour
	{
		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CanvasKeyboard canvasKeyboard;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool ShiftDown;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		private bool AltDown;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject alphaBoardUnsfhifted;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject alphaBoardSfhifted;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject numberBoardUnshifted;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public GameObject numberBoardShifted;

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x7E91D4", Offset = "0x7E91D4", VA = "0x7E91D4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x7E91D8", Offset = "0x7E91D8", VA = "0x7E91D8")]
		private void Refresh()
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x7E92B0", Offset = "0x7E92B0", VA = "0x7E92B0")]
		public void OnKeyDown(GameObject kb)
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x7E9488", Offset = "0x7E9488", VA = "0x7E9488")]
		public CanvasKeyboardASCII()
		{
		}
	}
	[Token(Token = "0x2000097")]
	public class DeactivateParentCollider : MonoBehaviour
	{
		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Collider col;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private CurvedUIRaycaster raycaster;

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x7E9490", Offset = "0x7E9490", VA = "0x7E9490")]
		private void Start()
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x7E95C0", Offset = "0x7E95C0", VA = "0x7E95C0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x7E9750", Offset = "0x7E9750", VA = "0x7E9750")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x7E9838", Offset = "0x7E9838", VA = "0x7E9838")]
		public DeactivateParentCollider()
		{
		}
	}
	[Token(Token = "0x2000098")]
	public class OpenCanvasKeyboard : MonoBehaviour
	{
		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CanvasKeyboard keyboard;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject keyboardParent;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject inputObject;

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x7E9840", Offset = "0x7E9840", VA = "0x7E9840")]
		public void OpenKeyboard()
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x7E98F8", Offset = "0x7E98F8", VA = "0x7E98F8")]
		public void CloseKeyboard()
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x7E9930", Offset = "0x7E9930", VA = "0x7E9930")]
		public OpenCanvasKeyboard()
		{
		}
	}
}
namespace UnityEngine.UI
{
	[Token(Token = "0x2000099")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5FAAD0", Offset = "0x5FAAD0")]
	public class LetterSpacing : BaseMeshEffect
	{
		[Token(Token = "0x40003F6")]
		private const string SupportedTagRegexPattersn = "<b>|</b>|<i>|</i>|<size=.*?>|</size>|<color=.*?>|</color>|<material=.*?>|</material>";

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool useRichText;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float m_spacing;

		[Token(Token = "0x17000056")]
		public float spacing
		{
			[Token(Token = "0x60003F8")]
			[Address(RVA = "0x1075EF4", Offset = "0x1075EF4", VA = "0x1075EF4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003F9")]
			[Address(RVA = "0x1075EFC", Offset = "0x1075EFC", VA = "0x1075EFC")]
			set
			{
			}
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x1075EEC", Offset = "0x1075EEC", VA = "0x1075EEC")]
		protected LetterSpacing()
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x1075FD0", Offset = "0x1075FD0", VA = "0x1075FD0", Slot = "20")]
		public override void ModifyMesh(VertexHelper vh)
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x10760A0", Offset = "0x10760A0", VA = "0x10760A0")]
		public void ModifyVertices(List<UIVertex> verts)
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x1076C94", Offset = "0x1076C94", VA = "0x1076C94")]
		private IEnumerator GetRegexMatchedTagCollection(string line, out int lineLengthWithoutTags)
		{
			return null;
		}
	}
}
namespace HeadjackTemplate
{
	[Token(Token = "0x200009A")]
	public class GBAwakeCollect : MonoBehaviour
	{
		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x7F8078", Offset = "0x7F8078", VA = "0x7F8078")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x7F80E0", Offset = "0x7F80E0", VA = "0x7F80E0")]
		public GBAwakeCollect()
		{
		}
	}
	[Token(Token = "0x200009B")]
	public class AppStart : MonoBehaviour
	{
		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x7F76C0", Offset = "0x7F76C0", VA = "0x7F76C0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x7F76C4", Offset = "0x7F76C4", VA = "0x7F76C4")]
		private void VrCamReposition()
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x7F77AC", Offset = "0x7F77AC", VA = "0x7F77AC")]
		public AppStart()
		{
		}
	}
	[Token(Token = "0x200009C")]
	public class EditorEventSystem : MonoBehaviour
	{
		[Token(Token = "0x6000402")]
		[Address(RVA = "0x7F8070", Offset = "0x7F8070", VA = "0x7F8070")]
		public EditorEventSystem()
		{
		}
	}
	[Token(Token = "0x200009D")]
	public class InputEditorSettings : MonoBehaviour
	{
		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public StandaloneInputModule standaloneInputModule;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CurvedCanvasInputModule curvedCanvasInputModule;

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x7F87B8", Offset = "0x7F87B8", VA = "0x7F87B8")]
		public InputEditorSettings()
		{
		}
	}
	[Token(Token = "0x200009E")]
	public static class AppManager
	{
		[Token(Token = "0x2000182")]
		public enum MeditationTime
		{
			[Token(Token = "0x400072F")]
			Min5,
			[Token(Token = "0x4000730")]
			Min10
		}

		[Token(Token = "0x2000183")]
		public enum MeditationProgram
		{
			[Token(Token = "0x4000732")]
			Meditation = 0,
			[Token(Token = "0x4000733")]
			WeeklyWisdom = 1,
			[Token(Token = "0x4000734")]
			BreathingSpace = 2,
			[Token(Token = "0x4000735")]
			None = -1
		}

		[Token(Token = "0x2000184")]
		public enum AudioVariableNames
		{
			[Token(Token = "0x4000737")]
			voice_5min_male,
			[Token(Token = "0x4000738")]
			voice_5min_female,
			[Token(Token = "0x4000739")]
			voice_10min_male,
			[Token(Token = "0x400073A")]
			voice_10min_female,
			[Token(Token = "0x400073B")]
			background_sound_nature,
			[Token(Token = "0x400073C")]
			background_sound_music,
			[Token(Token = "0x400073D")]
			background_sound_drumming,
			[Token(Token = "0x400073E")]
			noAudio
		}

		[Token(Token = "0x2000185")]
		public enum VoiceSex
		{
			[Token(Token = "0x4000740")]
			Female,
			[Token(Token = "0x4000741")]
			Male,
			[Token(Token = "0x4000742")]
			NoSound
		}

		[Token(Token = "0x2000186")]
		public enum BackgroundSound
		{
			[Token(Token = "0x4000744")]
			Nature,
			[Token(Token = "0x4000745")]
			Music,
			[Token(Token = "0x4000746")]
			Drumming,
			[Token(Token = "0x4000747")]
			NoSound
		}

		[Token(Token = "0x2000187")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB264", Offset = "0x5FB264")]
		private sealed class <>c__DisplayClass63_0
		{
			[Token(Token = "0x4000748")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action callBackEndFade;

			[Token(Token = "0x600098B")]
			[Address(RVA = "0x7F620C", Offset = "0x7F620C", VA = "0x7F620C")]
			public <>c__DisplayClass63_0()
			{
			}

			[Token(Token = "0x600098C")]
			[Address(RVA = "0x7F74AC", Offset = "0x7F74AC", VA = "0x7F74AC")]
			internal void <PlayCurrentVideo>b__0(bool s, string e)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000188")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB274", Offset = "0x5FB274")]
		private sealed class <>c
		{
			[Token(Token = "0x4000749")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400074A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static PopupMessage.Callback <>9__63_2;

			[Token(Token = "0x400074B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static OnEnd <>9__63_1;

			[Token(Token = "0x400074C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static OnEnd <>9__64_1;

			[Token(Token = "0x400074D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static OnEnd <>9__64_0;

			[Token(Token = "0x400074E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static OnEnd <>9__65_1;

			[Token(Token = "0x400074F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public static OnEnd <>9__65_0;

			[Token(Token = "0x4000750")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public static OnEnd <>9__66_0;

			[Token(Token = "0x4000751")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public static OnEnd <>9__67_1;

			[Token(Token = "0x4000752")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public static OnEnd <>9__67_0;

			[Token(Token = "0x600098E")]
			[Address(RVA = "0x7F6E04", Offset = "0x7F6E04", VA = "0x7F6E04")]
			public <>c()
			{
			}

			[Token(Token = "0x600098F")]
			[Address(RVA = "0x7F6E0C", Offset = "0x7F6E0C", VA = "0x7F6E0C")]
			internal void <PlayCurrentVideo>b__63_1(bool ss, string ee)
			{
			}

			[Token(Token = "0x6000990")]
			[Address(RVA = "0x7F6F94", Offset = "0x7F6F94", VA = "0x7F6F94")]
			internal void <PlayCurrentVideo>b__63_2(bool confirm)
			{
			}

			[Token(Token = "0x6000991")]
			[Address(RVA = "0x7F6F98", Offset = "0x7F6F98", VA = "0x7F6F98")]
			internal void <OpenHomePage>b__64_0(bool s, string e)
			{
			}

			[Token(Token = "0x6000992")]
			[Address(RVA = "0x7F70CC", Offset = "0x7F70CC", VA = "0x7F70CC")]
			internal void <OpenHomePage>b__64_1(bool fadeOutSuccess, string fadeOutError)
			{
			}

			[Token(Token = "0x6000993")]
			[Address(RVA = "0x7F70D0", Offset = "0x7F70D0", VA = "0x7F70D0")]
			internal void <OpenLogInPage>b__65_0(bool s, string e)
			{
			}

			[Token(Token = "0x6000994")]
			[Address(RVA = "0x7F7204", Offset = "0x7F7204", VA = "0x7F7204")]
			internal void <OpenLogInPage>b__65_1(bool fadeOutSuccess, string fadeOutError)
			{
			}

			[Token(Token = "0x6000995")]
			[Address(RVA = "0x7F7208", Offset = "0x7F7208", VA = "0x7F7208")]
			internal void <OpenMeditationProgramAfterStartApp>b__66_0(bool s, string e)
			{
			}

			[Token(Token = "0x6000996")]
			[Address(RVA = "0x7F7374", Offset = "0x7F7374", VA = "0x7F7374")]
			internal void <OpenMeditationProgramPage>b__67_0(bool s, string e)
			{
			}

			[Token(Token = "0x6000997")]
			[Address(RVA = "0x7F74A8", Offset = "0x7F74A8", VA = "0x7F74A8")]
			internal void <OpenMeditationProgramPage>b__67_1(bool fadeOutSuccess, string fadeOutError)
			{
			}
		}

		[Token(Token = "0x40003FB")]
		public const int AntiAliasing = 8;

		[Token(Token = "0x40003FC")]
		public const float MuteSoundSliderVolume = 0.1f;

		[Token(Token = "0x40003FD")]
		public const string HeadjackHDRIName = "hdri_360_image";

		[Token(Token = "0x40003FE")]
		public const string LoginPrefs = "LoginPrefs";

		[Token(Token = "0x40003FF")]
		public const string PasswordPrefs = "PasswordPrefs";

		[Token(Token = "0x4000400")]
		public const string CurrentMeditationProgramPrefs = "CurrentMeditationProgramPrefs";

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string CurrentDescription;

		[Token(Token = "0x4000402")]
		public const string MainMenuSceneName = "Menu";

		[Token(Token = "0x4000403")]
		public const string MainMenuSceneFullName = "Template/Menu";

		[Token(Token = "0x4000404")]
		public const string VideoPlayerScene = "Template/VideoPlayer";

		[Token(Token = "0x4000405")]
		public const string InitScene = "Template/App";

		[Token(Token = "0x4000406")]
		public const string MeditationProgramScene = "Template/MeditationProgram";

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static MeditationTime _meditationTimeValue;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static BackgroundSound MeditationBackgroundSoundValue;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static VoiceSex _voiceSexValue;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static bool IsPlayBackgroundSoundNature;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
		public static bool IsPlayBackgroundSoundMusic;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16")]
		public static bool IsPlayBackgroundSoundDrumming;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static string _currentProjectID;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static bool IsHeadjackInitialised;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FC25C", Offset = "0x5FC25C")]
		private static bool <Stream>k__BackingField;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static Action OnVideoInitComplete;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static Action OnVideoEnd;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static Action OnSexValueChanged;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static Action OnDurationChanged;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static Action OnHoolywoodAnimationStart;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static Action OnHoolywoodAnimationEnd;

		[Token(Token = "0x4000416")]
		private const string MeditationTimePrefs = "MeditationTime";

		[Token(Token = "0x4000417")]
		private const string MeditationProgramPrefs = "MeditationProgram";

		[Token(Token = "0x4000418")]
		private const string VoiceSexPrefs = "VoiceSex";

		[Token(Token = "0x4000419")]
		private const string BackgroundSoundPrefs = "BackgroundSound";

		[Token(Token = "0x400041A")]
		private const string IsPlayBackgroundSoundNaturePrefs = "IsPlayBackgroundSoundNature";

		[Token(Token = "0x400041B")]
		private const string IsPlayBackgroundSoundMusicPrefs = "IsPlayBackgroundSoundMusic";

		[Token(Token = "0x400041C")]
		private const string IsPlayBackgroundSoundDrummingPrefs = "IsPlayBackgroundSoundDrumming";

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static MeditationProgram CurrentMeditationProgram;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public static MeditationProgram LastMeditationProgram;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static AudioVariableNames _currentStory;

		[Token(Token = "0x17000057")]
		public static MeditationTime MeditationTimeValue
		{
			[Token(Token = "0x6000404")]
			[Address(RVA = "0x7F56B4", Offset = "0x7F56B4", VA = "0x7F56B4")]
			get
			{
				return default(MeditationTime);
			}
			[Token(Token = "0x6000405")]
			[Address(RVA = "0x7F571C", Offset = "0x7F571C", VA = "0x7F571C")]
			set
			{
			}
		}

		[Token(Token = "0x17000058")]
		public static VoiceSex VoiceSexValue
		{
			[Token(Token = "0x6000406")]
			[Address(RVA = "0x7F57A4", Offset = "0x7F57A4", VA = "0x7F57A4")]
			get
			{
				return default(VoiceSex);
			}
			[Token(Token = "0x6000407")]
			[Address(RVA = "0x7F580C", Offset = "0x7F580C", VA = "0x7F580C")]
			set
			{
			}
		}

		[Token(Token = "0x17000059")]
		public static string CurrentProjectID
		{
			[Token(Token = "0x6000408")]
			[Address(RVA = "0x7F5894", Offset = "0x7F5894", VA = "0x7F5894")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000409")]
			[Address(RVA = "0x7F0B84", Offset = "0x7F0B84", VA = "0x7F0B84")]
			set
			{
			}
		}

		[Token(Token = "0x1700005A")]
		public static bool Stream
		{
			[Token(Token = "0x600040A")]
			[Address(RVA = "0x7F58FC", Offset = "0x7F58FC", VA = "0x7F58FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FE3E0", Offset = "0x5FE3E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600040B")]
			[Address(RVA = "0x7F5964", Offset = "0x7F5964", VA = "0x7F5964")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FE3F0", Offset = "0x5FE3F0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005B")]
		public static AudioVariableNames CurrentBackgroundAudio
		{
			[Token(Token = "0x600040D")]
			[Address(RVA = "0x7F5B14", Offset = "0x7F5B14", VA = "0x7F5B14")]
			get
			{
				return default(AudioVariableNames);
			}
		}

		[Token(Token = "0x1700005C")]
		public static AudioVariableNames CurrentVoiceAudio
		{
			[Token(Token = "0x600040F")]
			[Address(RVA = "0x7F3650", Offset = "0x7F3650", VA = "0x7F3650")]
			get
			{
				return default(AudioVariableNames);
			}
		}

		[Token(Token = "0x1700005D")]
		public static AudioVariableNames CurrentStory
		{
			[Token(Token = "0x6000411")]
			[Address(RVA = "0x7F5D7C", Offset = "0x7F5D7C", VA = "0x7F5D7C")]
			get
			{
				return default(AudioVariableNames);
			}
			[Token(Token = "0x6000410")]
			[Address(RVA = "0x7F5D10", Offset = "0x7F5D10", VA = "0x7F5D10")]
			set
			{
			}
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x7F59D4", Offset = "0x7F59D4", VA = "0x7F59D4")]
		public static string[] GetProjectIdsByMeditationProgram()
		{
			return null;
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x7F5B90", Offset = "0x7F5B90", VA = "0x7F5B90")]
		public static AudioVariableNames VoiceAudioBySexAndDuration(VoiceSex voiceSex)
		{
			return default(AudioVariableNames);
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x7F5DE4", Offset = "0x7F5DE4", VA = "0x7F5DE4")]
		public static void PlayCurrentVideo([Optional] Action callBackEndFade)
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x7F62E4", Offset = "0x7F62E4", VA = "0x7F62E4")]
		public static void OpenHomePage()
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x7F6410", Offset = "0x7F6410", VA = "0x7F6410")]
		public static void OpenLogInPage()
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x7F653C", Offset = "0x7F653C", VA = "0x7F653C")]
		public static void OpenMeditationProgramAfterStartApp()
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x7F6638", Offset = "0x7F6638", VA = "0x7F6638")]
		public static void OpenMeditationProgramPage()
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x7F6734", Offset = "0x7F6734", VA = "0x7F6734")]
		private static void LoadBackgroundSounds()
		{
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x7F681C", Offset = "0x7F681C", VA = "0x7F681C")]
		private static void SaveBackgroundSounds()
		{
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x7F6904", Offset = "0x7F6904", VA = "0x7F6904")]
		public static void LoadPrefs()
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x7F6B70", Offset = "0x7F6B70", VA = "0x7F6B70")]
		public static void SavePrefs()
		{
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x7F08C4", Offset = "0x7F08C4", VA = "0x7F08C4")]
		public static void Init()
		{
		}
	}
	[Token(Token = "0x200009F")]
	public class PlayAudio : MonoBehaviour
	{
		[Token(Token = "0x2000189")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB284", Offset = "0x5FB284")]
		private sealed class <WaitAppPlayerInit>d__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000753")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000754")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000755")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PlayAudio <>4__this;

			[Token(Token = "0x170000E6")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600099B")]
				[Address(RVA = "0x803DEC", Offset = "0x803DEC", VA = "0x803DEC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E7")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600099D")]
				[Address(RVA = "0x803E54", Offset = "0x803E54", VA = "0x803E54", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000998")]
			[Address(RVA = "0x803B54", Offset = "0x803B54", VA = "0x803B54")]
			[DebuggerHidden]
			public <WaitAppPlayerInit>d__1(int <>1__state)
			{
			}

			[Token(Token = "0x6000999")]
			[Address(RVA = "0x803CA8", Offset = "0x803CA8", VA = "0x803CA8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600099A")]
			[Address(RVA = "0x803CAC", Offset = "0x803CAC", VA = "0x803CAC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600099C")]
			[Address(RVA = "0x803DF4", Offset = "0x803DF4", VA = "0x803DF4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x803AB8", Offset = "0x803AB8", VA = "0x803AB8")]
		private void Start()
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x803AE4", Offset = "0x803AE4", VA = "0x803AE4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5FE400", Offset = "0x5FE400")]
		private IEnumerator WaitAppPlayerInit()
		{
			return null;
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x803B80", Offset = "0x803B80", VA = "0x803B80")]
		private void OnVideoInit()
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x803CA0", Offset = "0x803CA0", VA = "0x803CA0")]
		public PlayAudio()
		{
		}
	}
}
namespace HeadjackTemplate.Gaze
{
	[Token(Token = "0x20000A0")]
	public class HeadPointer : MonoBehaviour
	{
		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image progress;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float timeSelect;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GameObject lastLookObject;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float selectionCountTime;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private GameObject canvas;

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x7F80E8", Offset = "0x7F80E8", VA = "0x7F80E8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x7F8134", Offset = "0x7F8134", VA = "0x7F8134")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x7F82C0", Offset = "0x7F82C0", VA = "0x7F82C0")]
		private void ShowGaze(bool value)
		{
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x7F8318", Offset = "0x7F8318", VA = "0x7F8318")]
		private void CastRay()
		{
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x7F8534", Offset = "0x7F8534", VA = "0x7F8534")]
		private void SelectingProgress()
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x7F8584", Offset = "0x7F8584", VA = "0x7F8584")]
		private void OnSelection()
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x7F871C", Offset = "0x7F871C", VA = "0x7F871C")]
		private void SetSelectionProgressToUI()
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x7F852C", Offset = "0x7F852C", VA = "0x7F852C")]
		private void Deselect()
		{
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x7F87B4", Offset = "0x7F87B4", VA = "0x7F87B4")]
		private void Update()
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x7ECE28", Offset = "0x7ECE28", VA = "0x7ECE28")]
		public HeadPointer()
		{
		}
	}
	[Token(Token = "0x20000A1")]
	public interface IGaze
	{
		[Token(Token = "0x600042B")]
		void OnGazSelect();
	}
}
namespace HeadjackTemplate.Managers.UI
{
	[Token(Token = "0x20000A2")]
	public class UIMainManager : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200018A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB294", Offset = "0x5FB294")]
		private sealed class <>c
		{
			[Token(Token = "0x4000756")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000757")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static OnEnd <>9__2_0;

			[Token(Token = "0x600099F")]
			[Address(RVA = "0x803868", Offset = "0x803868", VA = "0x803868")]
			public <>c()
			{
			}

			[Token(Token = "0x60009A0")]
			[Address(RVA = "0x803870", Offset = "0x803870", VA = "0x803870")]
			internal void <Start>b__2_0(bool s, string e)
			{
			}
		}

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MainMenu mainMenu;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AllHollywoodMenus videosHoolywood;

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x803648", Offset = "0x803648", VA = "0x803648")]
		private void Start()
		{
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x803744", Offset = "0x803744", VA = "0x803744")]
		public void OpenMainMenu()
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x8037A0", Offset = "0x8037A0", VA = "0x8037A0")]
		public void OpenVideoProjects()
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x8037FC", Offset = "0x8037FC", VA = "0x8037FC")]
		public UIMainManager()
		{
		}
	}
}
namespace HeadjackTemplate.Managers.Video
{
	[Token(Token = "0x20000A3")]
	public class VideoDownloader : MonoBehaviour
	{
		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FC2AC", Offset = "0x5FC2AC")]
		private static VideoDownloader <Instance>k__BackingField;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool isDownloding;

		[Token(Token = "0x1700005E")]
		public static VideoDownloader Instance
		{
			[Token(Token = "0x6000430")]
			[Address(RVA = "0x8039B8", Offset = "0x8039B8", VA = "0x8039B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FE464", Offset = "0x5FE464")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000431")]
			[Address(RVA = "0x803A08", Offset = "0x803A08", VA = "0x803A08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FE474", Offset = "0x5FE474")]
			private set
			{
			}
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x803A5C", Offset = "0x803A5C", VA = "0x803A5C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x803AB0", Offset = "0x803AB0", VA = "0x803AB0")]
		public VideoDownloader()
		{
		}
	}
}
namespace HeadjackTemplate.Managers.Audio
{
	[Token(Token = "0x20000A4")]
	public interface IAudio
	{
		[Token(Token = "0x6000434")]
		void Prepare();

		[Token(Token = "0x6000435")]
		void StartPlaying();

		[Token(Token = "0x6000436")]
		void Pause();

		[Token(Token = "0x6000437")]
		void UnPause();

		[Token(Token = "0x6000438")]
		void SeekAddMs(float seek);

		[Token(Token = "0x6000439")]
		void SeekSetMs(float seek);

		[Token(Token = "0x600043A")]
		void CancelDownload(string projectId);

		[Token(Token = "0x600043B")]
		bool IsDownloaded();
	}
	[Token(Token = "0x20000A5")]
	public static class MainAudioManager
	{
		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly List<IAudio> Audios;

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x7F87C0", Offset = "0x7F87C0", VA = "0x7F87C0")]
		static MainAudioManager()
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x7F88F8", Offset = "0x7F88F8", VA = "0x7F88F8")]
		public static void StartPlayingAudios()
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x7F8A80", Offset = "0x7F8A80", VA = "0x7F8A80")]
		public static void PrepareAudios()
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x7F8C04", Offset = "0x7F8C04", VA = "0x7F8C04")]
		public static void PauseAudios()
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x7F8D8C", Offset = "0x7F8D8C", VA = "0x7F8D8C")]
		public static void UnPauseAudios()
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x7F8F14", Offset = "0x7F8F14", VA = "0x7F8F14")]
		public static void SeekAddMsAudios(float seek)
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x7F90AC", Offset = "0x7F90AC", VA = "0x7F90AC")]
		public static void SeekSetMsAudios(float seek)
		{
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x7F9244", Offset = "0x7F9244", VA = "0x7F9244")]
		public static void CancelDownload(string projectId)
		{
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x7F93D4", Offset = "0x7F93D4", VA = "0x7F93D4")]
		public static bool IsAllAudioDownloaded()
		{
			return default(bool);
		}
	}
}
namespace HeadjackTemplate.Managers.Download
{
	[Token(Token = "0x20000A6")]
	public class AudioCleanMemoryOnUnloadScene : MonoBehaviour
	{
		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Scene activeScene;

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x7FD4E8", Offset = "0x7FD4E8", VA = "0x7FD4E8")]
		public void Start()
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x7FD594", Offset = "0x7FD594", VA = "0x7FD594")]
		private void OnSceneUnloaded(Scene current)
		{
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x7FD674", Offset = "0x7FD674", VA = "0x7FD674")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x7FD710", Offset = "0x7FD710", VA = "0x7FD710")]
		public AudioCleanMemoryOnUnloadScene()
		{
		}
	}
	[Token(Token = "0x20000A7")]
	public class TBEAudioManager : MonoBehaviour, IAudio
	{
		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static TBEAudioManager Instance;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5FC2BC", Offset = "0x5FC2BC")]
		[SerializeField]
		private int objectPoolSize;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private int spatFilePoolSize;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int queuePoolSize;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private SampleRate sampleRate;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AudioDeviceType audioDeviceType;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5FC348", Offset = "0x5FC348")]
		private SpatDecoderFile videoPlayer;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string _projectID;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string _TBEAudioID;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float _globalVolume;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float _localVolume;

		[Token(Token = "0x1700005F")]
		public float Volume
		{
			[Token(Token = "0x600044B")]
			[Address(RVA = "0x802784", Offset = "0x802784", VA = "0x802784")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600044C")]
			[Address(RVA = "0x8027C4", Offset = "0x8027C4", VA = "0x8027C4")]
			set
			{
			}
		}

		[Token(Token = "0x17000060")]
		public float LocalVolume
		{
			[Token(Token = "0x600044D")]
			[Address(RVA = "0x8027E8", Offset = "0x8027E8", VA = "0x8027E8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600044E")]
			[Address(RVA = "0x802828", Offset = "0x802828", VA = "0x802828")]
			set
			{
			}
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x8024A4", Offset = "0x8024A4", VA = "0x8024A4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x8026F4", Offset = "0x8026F4", VA = "0x8026F4")]
		private void Start()
		{
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x80284C", Offset = "0x80284C", VA = "0x80284C", Slot = "8")]
		public void SeekAddMs(float seek)
		{
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x802898", Offset = "0x802898", VA = "0x802898", Slot = "9")]
		public void SeekSetMs(float seek)
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x8028F4", Offset = "0x8028F4", VA = "0x8028F4", Slot = "10")]
		public void CancelDownload(string projectId)
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x8029E8", Offset = "0x8029E8", VA = "0x8029E8", Slot = "11")]
		public bool IsDownloaded()
		{
			return default(bool);
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x802A10", Offset = "0x802A10", VA = "0x802A10", Slot = "4")]
		public void Prepare()
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x802AFC", Offset = "0x802AFC", VA = "0x802AFC", Slot = "5")]
		public void StartPlaying()
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x802D28", Offset = "0x802D28", VA = "0x802D28", Slot = "6")]
		public void Pause()
		{
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x802DB0", Offset = "0x802DB0", VA = "0x802DB0", Slot = "7")]
		public void UnPause()
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x80289C", Offset = "0x80289C", VA = "0x80289C")]
		private void SeekSetMsTBE(float timeMs)
		{
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x802DB4", Offset = "0x802DB4", VA = "0x802DB4")]
		private void UnPauseTBE()
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x802850", Offset = "0x802850", VA = "0x802850")]
		private void SeekAddMsTBE(float timeMs)
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x802A14", Offset = "0x802A14", VA = "0x802A14")]
		private void PrepareCurrentTBE()
		{
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x802DB8", Offset = "0x802DB8", VA = "0x802DB8")]
		private void PrepareTBE(string projectID)
		{
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x802D2C", Offset = "0x802D2C", VA = "0x802D2C")]
		private void PauseTBE()
		{
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x802B00", Offset = "0x802B00", VA = "0x802B00")]
		private void PlayTBE()
		{
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x8006C0", Offset = "0x8006C0", VA = "0x8006C0")]
		public float GetDownloadProgress(string projectID)
		{
			return default(float);
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x8028F8", Offset = "0x8028F8", VA = "0x8028F8")]
		private void StopDownloadTBE(string projectID)
		{
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x803388", Offset = "0x803388", VA = "0x803388")]
		private void StopDownloadCurrentTBE()
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x8033FC", Offset = "0x8033FC", VA = "0x8033FC")]
		public float GetCurrentDownloadProgress()
		{
			return default(float);
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x8034A4", Offset = "0x8034A4", VA = "0x8034A4")]
		public void DownloadCurrentTBEAudioCurrentVideo()
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x8005B8", Offset = "0x8005B8", VA = "0x8005B8")]
		public void DownloadTBEAudioCurrentVideo(string projectID)
		{
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x7FF5E8", Offset = "0x7FF5E8", VA = "0x7FF5E8")]
		public bool IsCurrentTBEDownloaded()
		{
			return default(bool);
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x800744", Offset = "0x800744", VA = "0x800744")]
		public bool IsTBEDownloaded(string projectID)
		{
			return default(bool);
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x803558", Offset = "0x803558", VA = "0x803558")]
		private void DownloadEnd(bool success, string error)
		{
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x8031A0", Offset = "0x8031A0", VA = "0x8031A0")]
		private string GetTBEAudioPath(string projectID)
		{
			return null;
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x8032D4", Offset = "0x8032D4", VA = "0x8032D4")]
		private void SetCurrentVideoAndTBEAudioID()
		{
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x8030A8", Offset = "0x8030A8", VA = "0x8030A8")]
		private void SetVideoAndTBEAudioID(string projectID)
		{
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x8035C4", Offset = "0x8035C4", VA = "0x8035C4")]
		public TBEAudioManager()
		{
		}
	}
	[Token(Token = "0x20000A8")]
	public class DownloadProgressManagerSoundsAndVideo : MonoBehaviour
	{
		[Token(Token = "0x200018B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB2A4", Offset = "0x5FB2A4")]
		private sealed class <CountVideoProgress>d__69 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000758")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000759")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400075A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DownloadProgressManagerSoundsAndVideo <>4__this;

			[Token(Token = "0x400075B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action<string> callBack;

			[Token(Token = "0x400075C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private string <id>5__2;

			[Token(Token = "0x170000E8")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009A4")]
				[Address(RVA = "0x800FA8", Offset = "0x800FA8", VA = "0x800FA8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E9")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009A6")]
				[Address(RVA = "0x801010", Offset = "0x801010", VA = "0x801010", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009A1")]
			[Address(RVA = "0x800100", Offset = "0x800100", VA = "0x800100")]
			[DebuggerHidden]
			public <CountVideoProgress>d__69(int <>1__state)
			{
			}

			[Token(Token = "0x60009A2")]
			[Address(RVA = "0x80085C", Offset = "0x80085C", VA = "0x80085C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009A3")]
			[Address(RVA = "0x800860", Offset = "0x800860", VA = "0x800860", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009A5")]
			[Address(RVA = "0x800FB0", Offset = "0x800FB0", VA = "0x800FB0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200018C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB2B4", Offset = "0x5FB2B4")]
		private sealed class <CountTBEAudioProgress>d__70 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400075D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400075E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400075F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action<string> callBack;

			[Token(Token = "0x4000760")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private string <projectID>5__2;

			[Token(Token = "0x170000EA")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009AA")]
				[Address(RVA = "0x8007EC", Offset = "0x8007EC", VA = "0x8007EC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000EB")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009AC")]
				[Address(RVA = "0x800854", Offset = "0x800854", VA = "0x800854", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009A7")]
			[Address(RVA = "0x80012C", Offset = "0x80012C", VA = "0x80012C")]
			[DebuggerHidden]
			public <CountTBEAudioProgress>d__70(int <>1__state)
			{
			}

			[Token(Token = "0x60009A8")]
			[Address(RVA = "0x800190", Offset = "0x800190", VA = "0x800190", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009A9")]
			[Address(RVA = "0x800194", Offset = "0x800194", VA = "0x800194", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009AB")]
			[Address(RVA = "0x8007F4", Offset = "0x8007F4", VA = "0x8007F4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200018D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB2C4", Offset = "0x5FB2C4")]
		private sealed class <CountWavAudioProgress>d__71 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000761")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000762")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000763")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action<string> callBack;

			[Token(Token = "0x4000764")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private string <id>5__2;

			[Token(Token = "0x170000EC")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009B0")]
				[Address(RVA = "0x8016C8", Offset = "0x8016C8", VA = "0x8016C8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000ED")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009B2")]
				[Address(RVA = "0x801730", Offset = "0x801730", VA = "0x801730", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009AD")]
			[Address(RVA = "0x800158", Offset = "0x800158", VA = "0x800158")]
			[DebuggerHidden]
			public <CountWavAudioProgress>d__71(int <>1__state)
			{
			}

			[Token(Token = "0x60009AE")]
			[Address(RVA = "0x801018", Offset = "0x801018", VA = "0x801018", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009AF")]
			[Address(RVA = "0x80101C", Offset = "0x80101C", VA = "0x80101C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009B1")]
			[Address(RVA = "0x8016D0", Offset = "0x8016D0", VA = "0x8016D0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FC380", Offset = "0x5FC380")]
		private static DownloadProgressManagerSoundsAndVideo <Instance>k__BackingField;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static string currentDownloadingPorjectId;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FC390", Offset = "0x5FC390")]
		private static bool <IsDownloadingWavAudio>k__BackingField;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FC3A0", Offset = "0x5FC3A0")]
		private static long <DownloadWavTotalBytes>k__BackingField;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FC3B0", Offset = "0x5FC3B0")]
		private static long <WavDownloadedBytes>k__BackingField;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FC3C0", Offset = "0x5FC3C0")]
		private static bool <IsDownloadingTBEAudio>k__BackingField;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FC3D0", Offset = "0x5FC3D0")]
		private static float <DownloadAudioWavProgress>k__BackingField;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FC3E0", Offset = "0x5FC3E0")]
		private static float <DownloadAudioTBEProgress>k__BackingField;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FC3F0", Offset = "0x5FC3F0")]
		private static bool <IsDownloadingVideo>k__BackingField;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FC400", Offset = "0x5FC400")]
		private static float <DownloadVideoProgress>k__BackingField;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FC410", Offset = "0x5FC410")]
		private static long <DownloadVideoTotalBytes>k__BackingField;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FC420", Offset = "0x5FC420")]
		private static long <VideoDownloadedBytes>k__BackingField;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static Action OnEndDownloadingVideoAndAudio;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static bool IsDownloadingWavOnGetTotalSize;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private static bool IsDownloadingVideoOnGetTotalSize;

		[Token(Token = "0x17000061")]
		public static DownloadProgressManagerSoundsAndVideo Instance
		{
			[Token(Token = "0x600046C")]
			[Address(RVA = "0x7FD718", Offset = "0x7FD718", VA = "0x7FD718")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FE484", Offset = "0x5FE484")]
			get
			{
				return null;
			}
			[Token(Token = "0x600046D")]
			[Address(RVA = "0x7FD780", Offset = "0x7FD780", VA = "0x7FD780")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FE494", Offset = "0x5FE494")]
			private set
			{
			}
		}

		[Token(Token = "0x17000062")]
		public static bool IsDownloadingWavAudio
		{
			[Token(Token = "0x600046E")]
			[Address(RVA = "0x7FD7EC", Offset = "0x7FD7EC", VA = "0x7FD7EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FE4A4", Offset = "0x5FE4A4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600046F")]
			[Address(RVA = "0x7FD854", Offset = "0x7FD854", VA = "0x7FD854")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FE4B4", Offset = "0x5FE4B4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000063")]
		public static long DownloadWavTotalBytes
		{
			[Token(Token = "0x6000470")]
			[Address(RVA = "0x7FD8C4", Offset = "0x7FD8C4", VA = "0x7FD8C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FE4C4", Offset = "0x5FE4C4")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6000471")]
			[Address(RVA = "0x7FD92C", Offset = "0x7FD92C", VA = "0x7FD92C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FE4D4", Offset = "0x5FE4D4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000064")]
		public static long WavDownloadedBytes
		{
			[Token(Token = "0x6000472")]
			[Address(RVA = "0x7FD998", Offset = "0x7FD998", VA = "0x7FD998")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FE4E4", Offset = "0x5FE4E4")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6000473")]
			[Address(RVA = "0x7FDA00", Offset = "0x7FDA00", VA = "0x7FDA00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FE4F4", Offset = "0x5FE4F4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000065")]
		public static bool IsDownloadingTBEAudio
		{
			[Token(Token = "0x6000474")]
			[Address(RVA = "0x7FDA6C", Offset = "0x7FDA6C", VA = "0x7FDA6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FE504", Offset = "0x5FE504")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000475")]
			[Address(RVA = "0x7FDAD4", Offset = "0x7FDAD4", VA = "0x7FDAD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FE514", Offset = "0x5FE514")]
			private set
			{
			}
		}

		[Token(Token = "0x17000066")]
		public static float DownloadAudioWavProgress
		{
			[Token(Token = "0x6000476")]
			[Address(RVA = "0x7FDB44", Offset = "0x7FDB44", VA = "0x7FDB44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FE524", Offset = "0x5FE524")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000477")]
			[Address(RVA = "0x7FDBAC", Offset = "0x7FDBAC", VA = "0x7FDBAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FE534", Offset = "0x5FE534")]
			private set
			{
			}
		}

		[Token(Token = "0x17000067")]
		public static float DownloadAudioTBEProgress
		{
			[Token(Token = "0x6000478")]
			[Address(RVA = "0x7FDC20", Offset = "0x7FDC20", VA = "0x7FDC20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FE544", Offset = "0x5FE544")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000479")]
			[Address(RVA = "0x7FDC88", Offset = "0x7FDC88", VA = "0x7FDC88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FE554", Offset = "0x5FE554")]
			private set
			{
			}
		}

		[Token(Token = "0x17000068")]
		public static bool IsDownloadingVideo
		{
			[Token(Token = "0x600047A")]
			[Address(RVA = "0x7FDCFC", Offset = "0x7FDCFC", VA = "0x7FDCFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FE564", Offset = "0x5FE564")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600047B")]
			[Address(RVA = "0x7FDD64", Offset = "0x7FDD64", VA = "0x7FDD64")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FE574", Offset = "0x5FE574")]
			private set
			{
			}
		}

		[Token(Token = "0x17000069")]
		public static float DownloadVideoProgress
		{
			[Token(Token = "0x600047C")]
			[Address(RVA = "0x7FDDD4", Offset = "0x7FDDD4", VA = "0x7FDDD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FE584", Offset = "0x5FE584")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600047D")]
			[Address(RVA = "0x7FDE3C", Offset = "0x7FDE3C", VA = "0x7FDE3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FE594", Offset = "0x5FE594")]
			private set
			{
			}
		}

		[Token(Token = "0x1700006A")]
		public static long DownloadVideoTotalBytes
		{
			[Token(Token = "0x600047E")]
			[Address(RVA = "0x7FDEB0", Offset = "0x7FDEB0", VA = "0x7FDEB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FE5A4", Offset = "0x5FE5A4")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x600047F")]
			[Address(RVA = "0x7FDF18", Offset = "0x7FDF18", VA = "0x7FDF18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FE5B4", Offset = "0x5FE5B4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700006B")]
		public static long VideoDownloadedBytes
		{
			[Token(Token = "0x6000480")]
			[Address(RVA = "0x7FDF84", Offset = "0x7FDF84", VA = "0x7FDF84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FE5C4", Offset = "0x5FE5C4")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6000481")]
			[Address(RVA = "0x7FDFEC", Offset = "0x7FDFEC", VA = "0x7FDFEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FE5D4", Offset = "0x5FE5D4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700006C")]
		public static bool IsVideoDownloaded
		{
			[Token(Token = "0x6000483")]
			[Address(RVA = "0x7F6214", Offset = "0x7F6214", VA = "0x7F6214")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006D")]
		public static bool IsDownloadingAudioAndVideo
		{
			[Token(Token = "0x6000484")]
			[Address(RVA = "0x7FE108", Offset = "0x7FE108", VA = "0x7FE108")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006E")]
		public static bool IsDownloadedAudioAndVideo
		{
			[Token(Token = "0x6000485")]
			[Address(RVA = "0x7FE27C", Offset = "0x7FE27C", VA = "0x7FE27C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006F")]
		public static int DownloadManagersCount
		{
			[Token(Token = "0x6000486")]
			[Address(RVA = "0x7FE384", Offset = "0x7FE384", VA = "0x7FE384")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000070")]
		public static long DownloadedBytes
		{
			[Token(Token = "0x6000487")]
			[Address(RVA = "0x7FE528", Offset = "0x7FE528", VA = "0x7FE528")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x17000071")]
		public static long TotalBytes
		{
			[Token(Token = "0x6000488")]
			[Address(RVA = "0x7FE780", Offset = "0x7FE780", VA = "0x7FE780")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x17000072")]
		public static float DownloadAudioAndVideoProgress
		{
			[Token(Token = "0x6000489")]
			[Address(RVA = "0x7FEB50", Offset = "0x7FEB50", VA = "0x7FEB50")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x7FE058", Offset = "0x7FE058", VA = "0x7FE058")]
		private void Awake()
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x7FF3A8", Offset = "0x7FF3A8", VA = "0x7FF3A8")]
		public void StartDownloadAllSounds()
		{
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x7FF6F0", Offset = "0x7FF6F0", VA = "0x7FF6F0")]
		public void StartDownloadTBESounds()
		{
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x7FF83C", Offset = "0x7FF83C", VA = "0x7FF83C")]
		public void StartDownloadWavSounds()
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x7FF978", Offset = "0x7FF978", VA = "0x7FF978")]
		public void StartDownloadVideo()
		{
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x7FFC1C", Offset = "0x7FFC1C", VA = "0x7FFC1C")]
		public void StartDownloadingVideoAndWavSounds()
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x7FFC40", Offset = "0x7FFC40", VA = "0x7FFC40")]
		public void StopDownloadingAudioAndVideo()
		{
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x7FFBA0", Offset = "0x7FFBA0", VA = "0x7FFBA0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5FE5E4", Offset = "0x5FE5E4")]
		private IEnumerator CountVideoProgress([Optional] Action<string> callBack)
		{
			return null;
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x7FF610", Offset = "0x7FF610", VA = "0x7FF610")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5FE648", Offset = "0x5FE648")]
		private IEnumerator CountTBEAudioProgress([Optional] Action<string> callBack)
		{
			return null;
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x7FF680", Offset = "0x7FF680", VA = "0x7FF680")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5FE6AC", Offset = "0x5FE6AC")]
		private IEnumerator CountWavAudioProgress([Optional] Action<string> callBack)
		{
			return null;
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x7FFE40", Offset = "0x7FFE40", VA = "0x7FFE40")]
		private void OnEndDownloading([Optional] string projectIdOpen)
		{
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x800184", Offset = "0x800184", VA = "0x800184")]
		public DownloadProgressManagerSoundsAndVideo()
		{
		}
	}
}
namespace HeadjackTemplate.Managers.Download.HDRI
{
	[Token(Token = "0x20000A9")]
	public class ProjectsHDRIDownloader : MonoBehaviour
	{
		[Token(Token = "0x200018E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB2D4", Offset = "0x5FB2D4")]
		private sealed class <switchTexture>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000765")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000766")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000767")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Texture2D texture2d;

			[Token(Token = "0x170000EE")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009B6")]
				[Address(RVA = "0x802434", Offset = "0x802434", VA = "0x802434", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000EF")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009B8")]
				[Address(RVA = "0x80249C", Offset = "0x80249C", VA = "0x80249C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009B3")]
			[Address(RVA = "0x801FE0", Offset = "0x801FE0", VA = "0x801FE0")]
			[DebuggerHidden]
			public <switchTexture>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x60009B4")]
			[Address(RVA = "0x80237C", Offset = "0x80237C", VA = "0x80237C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009B5")]
			[Address(RVA = "0x802380", Offset = "0x802380", VA = "0x802380", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009B7")]
			[Address(RVA = "0x80243C", Offset = "0x80243C", VA = "0x80243C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Texture2D defaultTexture;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Renderer sphere;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ProjectsHDRIDownloader Instance;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FC450", Offset = "0x5FC450")]
		private bool <IsDownloading>k__BackingField;

		[Token(Token = "0x17000073")]
		public bool IsDownloading
		{
			[Token(Token = "0x6000496")]
			[Address(RVA = "0x801738", Offset = "0x801738", VA = "0x801738")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FE710", Offset = "0x5FE710")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000497")]
			[Address(RVA = "0x801740", Offset = "0x801740", VA = "0x801740")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FE720", Offset = "0x5FE720")]
			private set
			{
			}
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x80174C", Offset = "0x80174C", VA = "0x80174C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x80198C", Offset = "0x80198C", VA = "0x80198C")]
		private void SceneManagerOnSceneLoaded(Scene arg0, LoadSceneMode arg1)
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x801A68", Offset = "0x801A68", VA = "0x801A68")]
		private void OnHoolywoodAnimationEnd()
		{
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x801AE0", Offset = "0x801AE0", VA = "0x801AE0")]
		private void PlayAnimationSwitchTextureOrDownload()
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x801F08", Offset = "0x801F08", VA = "0x801F08")]
		private void OnEndDownloadingHDRI(bool success, string message)
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x801DD4", Offset = "0x801DD4", VA = "0x801DD4")]
		private void StartDownloadingHDRI(string projectId)
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x801D64", Offset = "0x801D64", VA = "0x801D64")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5FE730", Offset = "0x5FE730")]
		private IEnumerator switchTexture(Texture2D texture2d)
		{
			return null;
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x80200C", Offset = "0x80200C", VA = "0x80200C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x801C80", Offset = "0x801C80", VA = "0x801C80")]
		private bool isCurrentHDRIDownloaded()
		{
			return default(bool);
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x80216C", Offset = "0x80216C", VA = "0x80216C")]
		private bool isHDRIDownloaded(string projectId)
		{
			return default(bool);
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x8021F0", Offset = "0x8021F0", VA = "0x8021F0")]
		private static Texture2D Load(string filePath)
		{
			return null;
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x801D24", Offset = "0x801D24", VA = "0x801D24")]
		private Texture2D GetDownloadedHDRITextureByProjectId(string projectId)
		{
			return null;
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x802290", Offset = "0x802290", VA = "0x802290")]
		private Texture2D GetDownloadedHDRITextureByMediaId(string mediaId)
		{
			return null;
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x801F10", Offset = "0x801F10", VA = "0x801F10")]
		private string GetHDRIMediaID(string projectId)
		{
			return null;
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x802370", Offset = "0x802370", VA = "0x802370")]
		public ProjectsHDRIDownloader()
		{
		}
	}
}
namespace HeadjackTemplate.Managers.Controller
{
	[Token(Token = "0x20000AA")]
	public class MoveToController : MonoBehaviour
	{
		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x7FD2EC", Offset = "0x7FD2EC", VA = "0x7FD2EC")]
		private void Update()
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x7FD3B8", Offset = "0x7FD3B8", VA = "0x7FD3B8")]
		public MoveToController()
		{
		}
	}
	[Token(Token = "0x20000AB")]
	public class SetCanvasRay : MonoBehaviour
	{
		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x7FD3C0", Offset = "0x7FD3C0", VA = "0x7FD3C0")]
		private void Update()
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x7FD4E0", Offset = "0x7FD4E0", VA = "0x7FD4E0")]
		public SetCanvasRay()
		{
		}
	}
}
namespace HeadjackTemplate.Managers.Controller.Keyboard
{
	[Token(Token = "0x20000AC")]
	public class TextMeshProInputFieldKeyboardType : MonoBehaviour
	{
		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TMP_InputField inputField;

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x7FD234", Offset = "0x7FD234", VA = "0x7FD234")]
		private void Start()
		{
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x7FD2E4", Offset = "0x7FD2E4", VA = "0x7FD2E4")]
		public TextMeshProInputFieldKeyboardType()
		{
		}
	}
}
namespace HeadjackTemplate.Managers.Authorization
{
	[Token(Token = "0x20000AD")]
	public class DisableIfPurchased : MonoBehaviour
	{
		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x7F9574", Offset = "0x7F9574", VA = "0x7F9574")]
		private void Start()
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x7F971C", Offset = "0x7F971C", VA = "0x7F971C")]
		public DisableIfPurchased()
		{
		}
	}
	[Token(Token = "0x20000AE")]
	public class PurchasedManager : MonoBehaviour
	{
		[Token(Token = "0x200018F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB2E4", Offset = "0x5FB2E4")]
		private sealed class <>c__DisplayClass39_0
		{
			[Token(Token = "0x4000768")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool useAuthorizationCallBack;

			[Token(Token = "0x4000769")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public PurchasedManager <>4__this;

			[Token(Token = "0x60009B9")]
			[Address(RVA = "0x7FAC20", Offset = "0x7FAC20", VA = "0x7FAC20")]
			public <>c__DisplayClass39_0()
			{
			}

			[Token(Token = "0x60009BA")]
			[Address(RVA = "0x7FB2AC", Offset = "0x7FB2AC", VA = "0x7FB2AC")]
			internal void <GetToken>b__0(string token)
			{
			}
		}

		[Token(Token = "0x2000190")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB2F4", Offset = "0x5FB2F4")]
		private sealed class <GetToken>d__40 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400076A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400076B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400076C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PurchasedManager <>4__this;

			[Token(Token = "0x400076D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string userName;

			[Token(Token = "0x400076E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string password;

			[Token(Token = "0x400076F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Action<string> callBack;

			[Token(Token = "0x4000770")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UnityWebRequest <webRequest>5__2;

			[Token(Token = "0x170000F0")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009BF")]
				[Address(RVA = "0x7FBE18", Offset = "0x7FBE18", VA = "0x7FBE18", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F1")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009C1")]
				[Address(RVA = "0x7FBE80", Offset = "0x7FBE80", VA = "0x7FBE80", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009BB")]
			[Address(RVA = "0x7FACB8", Offset = "0x7FACB8", VA = "0x7FACB8")]
			[DebuggerHidden]
			public <GetToken>d__40(int <>1__state)
			{
			}

			[Token(Token = "0x60009BC")]
			[Address(RVA = "0x7FB730", Offset = "0x7FB730", VA = "0x7FB730", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009BD")]
			[Address(RVA = "0x7FB80C", Offset = "0x7FB80C", VA = "0x7FB80C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009BE")]
			[Address(RVA = "0x7FB74C", Offset = "0x7FB74C", VA = "0x7FB74C")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60009C0")]
			[Address(RVA = "0x7FBE20", Offset = "0x7FBE20", VA = "0x7FBE20", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000191")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB304", Offset = "0x5FB304")]
		private sealed class <>c__DisplayClass41_0
		{
			[Token(Token = "0x4000771")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool useLogInCallback;

			[Token(Token = "0x60009C2")]
			[Address(RVA = "0x7FAEE0", Offset = "0x7FAEE0", VA = "0x7FAEE0")]
			public <>c__DisplayClass41_0()
			{
			}

			[Token(Token = "0x60009C3")]
			[Address(RVA = "0x7FB488", Offset = "0x7FB488", VA = "0x7FB488")]
			internal void <OnTokenPreset>b__0(UserJsonData userJsonData)
			{
			}
		}

		[Token(Token = "0x2000192")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB314", Offset = "0x5FB314")]
		private sealed class <GetUserData>d__42 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000772")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000773")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000774")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PurchasedManager <>4__this;

			[Token(Token = "0x4000775")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string token;

			[Token(Token = "0x4000776")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action<UserJsonData> callBack;

			[Token(Token = "0x4000777")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UnityWebRequest <webRequest>5__2;

			[Token(Token = "0x170000F2")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009C8")]
				[Address(RVA = "0x7FCD30", Offset = "0x7FCD30", VA = "0x7FCD30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F3")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009CA")]
				[Address(RVA = "0x7FCD98", Offset = "0x7FCD98", VA = "0x7FCD98", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009C4")]
			[Address(RVA = "0x7FAF6C", Offset = "0x7FAF6C", VA = "0x7FAF6C")]
			[DebuggerHidden]
			public <GetUserData>d__42(int <>1__state)
			{
			}

			[Token(Token = "0x60009C5")]
			[Address(RVA = "0x7FBE88", Offset = "0x7FBE88", VA = "0x7FBE88", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009C6")]
			[Address(RVA = "0x7FBF64", Offset = "0x7FBF64", VA = "0x7FBF64", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009C7")]
			[Address(RVA = "0x7FBEA4", Offset = "0x7FBEA4", VA = "0x7FBEA4")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60009C9")]
			[Address(RVA = "0x7FCD38", Offset = "0x7FCD38", VA = "0x7FCD38", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FC460", Offset = "0x5FC460")]
		private static PurchasedManager <Instance>k__BackingField;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FC470", Offset = "0x5FC470")]
		private static bool <IsUserLogIn>k__BackingField;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FC480", Offset = "0x5FC480")]
		private static bool <IsAuthorizationProgress>k__BackingField;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FC490", Offset = "0x5FC490")]
		private static UserJsonData <UserData>k__BackingField;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Action OnAuthorizationEnd;

		[Token(Token = "0x400044F")]
		private const string Authorization = "https://www.solasvr.com/wp-json/jwt-auth/v1/token";

		[Token(Token = "0x4000450")]
		private const string TokenValidate = "https://www.solasvr.com/wp-json/jwt-auth/v1/token/validate";

		[Token(Token = "0x4000451")]
		private const string Subscriptions = "https://www.solasvr.com/wp-json/tw/v1/subscriptions";

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly string UserNameTag;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly string PasswordTag;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly string TokenTag;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly string UserJsonDataPrefsName;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly string IsUserLogInPrefsName;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static string Token;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static bool IsRequestInProgress;

		[Token(Token = "0x17000074")]
		public static PurchasedManager Instance
		{
			[Token(Token = "0x60004B0")]
			[Address(RVA = "0x7F9724", Offset = "0x7F9724", VA = "0x7F9724")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FE794", Offset = "0x5FE794")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004B1")]
			[Address(RVA = "0x7F978C", Offset = "0x7F978C", VA = "0x7F978C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FE7A4", Offset = "0x5FE7A4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000075")]
		public static bool IsUserLogIn
		{
			[Token(Token = "0x60004B2")]
			[Address(RVA = "0x7F97F8", Offset = "0x7F97F8", VA = "0x7F97F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FE7B4", Offset = "0x5FE7B4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004B3")]
			[Address(RVA = "0x7F9860", Offset = "0x7F9860", VA = "0x7F9860")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FE7C4", Offset = "0x5FE7C4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000076")]
		public static bool IsContentPurchased
		{
			[Token(Token = "0x60004B4")]
			[Address(RVA = "0x7F9604", Offset = "0x7F9604", VA = "0x7F9604")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000077")]
		public static bool IsAuthorizationProgress
		{
			[Token(Token = "0x60004B5")]
			[Address(RVA = "0x7F995C", Offset = "0x7F995C", VA = "0x7F995C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FE7D4", Offset = "0x5FE7D4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004B6")]
			[Address(RVA = "0x7F99C4", Offset = "0x7F99C4", VA = "0x7F99C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FE7E4", Offset = "0x5FE7E4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000078")]
		public static UserJsonData UserData
		{
			[Token(Token = "0x60004B7")]
			[Address(RVA = "0x7F9A34", Offset = "0x7F9A34", VA = "0x7F9A34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FE7F4", Offset = "0x5FE7F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004B8")]
			[Address(RVA = "0x7F9A9C", Offset = "0x7F9A9C", VA = "0x7F9A9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FE804", Offset = "0x5FE804")]
			private set
			{
			}
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x7F9B08", Offset = "0x7F9B08", VA = "0x7F9B08")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x7F9F58", Offset = "0x7F9F58", VA = "0x7F9F58")]
		private void Start()
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x7F9F5C", Offset = "0x7F9F5C", VA = "0x7F9F5C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x7FA1A8", Offset = "0x7FA1A8", VA = "0x7FA1A8")]
		private void onAuthorizationEnd()
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x7FA064", Offset = "0x7FA064", VA = "0x7FA064")]
		private void SaveToUnityPrefs()
		{
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x7FA400", Offset = "0x7FA400", VA = "0x7FA400")]
		public void ResetPrefsUserData()
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x7FA500", Offset = "0x7FA500", VA = "0x7FA500")]
		public void LogOut()
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x7FA738", Offset = "0x7FA738", VA = "0x7FA738")]
		public void AuthorizationWithCallBack(string userName, string password)
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x7FA9D4", Offset = "0x7FA9D4", VA = "0x7FA9D4")]
		public void AuthorizationWithoutCallBack(string userName, string password)
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x7F9D38", Offset = "0x7F9D38", VA = "0x7F9D38")]
		private void LoadFromUnityPrefs()
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x7FA820", Offset = "0x7FA820", VA = "0x7FA820")]
		private void GetToken(string userName, string password, bool useAuthorizationCallBack = true)
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x7FAC28", Offset = "0x7FAC28", VA = "0x7FAC28")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5FE814", Offset = "0x5FE814")]
		private IEnumerator GetToken(string userName, string password, [Optional] Action<string> callBack)
		{
			return null;
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x7FACE4", Offset = "0x7FACE4", VA = "0x7FACE4")]
		private void OnTokenPreset(string token, bool useLogInCallback = true)
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x7FAEE8", Offset = "0x7FAEE8", VA = "0x7FAEE8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5FE878", Offset = "0x5FE878")]
		private IEnumerator GetUserData(string token, [Optional] Action<UserJsonData> callBack)
		{
			return null;
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x7FAF98", Offset = "0x7FAF98", VA = "0x7FAF98")]
		private bool IsLoadedPurchasedTimeAvailable()
		{
			return default(bool);
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x7FB184", Offset = "0x7FB184", VA = "0x7FB184")]
		public PurchasedManager()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AF")]
	public class UserJsonData
	{
		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int id;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string end;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string next_payment;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int trial_end;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string code;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string token;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string message;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string user_email;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string user_nicename;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public string resttest;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string user_display_name;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public string status;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public string start_date;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public string last_order_date_created;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private readonly string TrueStatus;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private readonly string DataTimeFormat;

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x7FA3F8", Offset = "0x7FA3F8", VA = "0x7FA3F8")]
		public string ToJson()
		{
			return null;
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x7FA654", Offset = "0x7FA654", VA = "0x7FA654")]
		public void ResetUserData()
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x7FAB3C", Offset = "0x7FAB3C", VA = "0x7FAB3C")]
		public void LoadFromJson(string json)
		{
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x7FCDB4", Offset = "0x7FCDB4", VA = "0x7FCDB4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x7F98D0", Offset = "0x7F98D0", VA = "0x7F98D0")]
		public bool IsPurchased()
		{
			return default(bool);
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x7FD0D8", Offset = "0x7FD0D8", VA = "0x7FD0D8")]
		private DateTime GetDateTimeFromStringDate(string time)
		{
			return default(DateTime);
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x7FD158", Offset = "0x7FD158", VA = "0x7FD158")]
		public DateTime GetStartDate()
		{
			return default(DateTime);
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x7FD160", Offset = "0x7FD160", VA = "0x7FD160")]
		public DateTime GetLastOrderDate()
		{
			return default(DateTime);
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x7FD168", Offset = "0x7FD168", VA = "0x7FD168")]
		public DateTime GetNextPaymentDate()
		{
			return default(DateTime);
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x7FB0B0", Offset = "0x7FB0B0", VA = "0x7FB0B0")]
		public bool IsPurchasedTimeAvailable()
		{
			return default(bool);
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x7FAABC", Offset = "0x7FAABC", VA = "0x7FAABC")]
		public UserJsonData()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B0")]
	public class StatusData
	{
		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int status;

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x7FCDA0", Offset = "0x7FCDA0", VA = "0x7FCDA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x7FCDAC", Offset = "0x7FCDAC", VA = "0x7FCDAC")]
		public StatusData()
		{
		}
	}
}
namespace HeadjackTemplate.Audio
{
	[Token(Token = "0x20000B1")]
	public class PlayAudioFromStreamingAssets : MonoBehaviour
	{
		[Token(Token = "0x2000193")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB324", Offset = "0x5FB324")]
		private sealed class <LoadClipCoroutine>d__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000778")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000779")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400077A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string file;

			[Token(Token = "0x400077B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action<AudioClip> onLoadingCompleted;

			[Token(Token = "0x400077C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private WWW <request>5__2;

			[Token(Token = "0x170000F4")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009CF")]
				[Address(RVA = "0x7F7C30", Offset = "0x7F7C30", VA = "0x7F7C30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F5")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009D1")]
				[Address(RVA = "0x7F7C98", Offset = "0x7F7C98", VA = "0x7F7C98", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009CB")]
			[Address(RVA = "0x7F796C", Offset = "0x7F796C", VA = "0x7F796C")]
			[DebuggerHidden]
			public <LoadClipCoroutine>d__5(int <>1__state)
			{
			}

			[Token(Token = "0x60009CC")]
			[Address(RVA = "0x7F79DC", Offset = "0x7F79DC", VA = "0x7F79DC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009CD")]
			[Address(RVA = "0x7F7AB8", Offset = "0x7F7AB8", VA = "0x7F7AB8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009CE")]
			[Address(RVA = "0x7F79F8", Offset = "0x7F79F8", VA = "0x7F79F8")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60009D0")]
			[Address(RVA = "0x7F7C38", Offset = "0x7F7C38", VA = "0x7F7C38", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AudioSource audioSource;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string audioName;

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x7F77B4", Offset = "0x7F77B4", VA = "0x7F77B4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x7F77BC", Offset = "0x7F77BC", VA = "0x7F77BC")]
		private void Play(string fileName)
		{
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x7F7848", Offset = "0x7F7848", VA = "0x7F7848")]
		private void LoadClip(string fileName, Action<AudioClip> onLoadingCompleted)
		{
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x7F78F0", Offset = "0x7F78F0", VA = "0x7F78F0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5FE8DC", Offset = "0x5FE8DC")]
		private IEnumerator LoadClipCoroutine(string file, Action<AudioClip> onLoadingCompleted)
		{
			return null;
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x7F7998", Offset = "0x7F7998", VA = "0x7F7998")]
		public PlayAudioFromStreamingAssets()
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x7F79A0", Offset = "0x7F79A0", VA = "0x7F79A0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FE940", Offset = "0x5FE940")]
		private void <Play>b__3_0(AudioClip clip)
		{
		}
	}
}
namespace HeadjackTemplate.EditorButtons
{
	[Token(Token = "0x20000B2")]
	public class CurvedUIEditorMouse : MonoBehaviour
	{
		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x7F7CA0", Offset = "0x7F7CA0", VA = "0x7F7CA0")]
		public CurvedUIEditorMouse()
		{
		}
	}
	[Token(Token = "0x20000B3")]
	public class DisableColliderAndCanvasFromParent : MonoBehaviour
	{
		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Canvas canvas;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private MeshCollider coll;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CurvedUIRaycaster сurvedUiRaycaster;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private GameObject parentObj;

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x7F7CA8", Offset = "0x7F7CA8", VA = "0x7F7CA8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x7F7CAC", Offset = "0x7F7CAC", VA = "0x7F7CAC")]
		private void Find()
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x7F7E00", Offset = "0x7F7E00", VA = "0x7F7E00")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x7F7F2C", Offset = "0x7F7F2C", VA = "0x7F7F2C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x7F8060", Offset = "0x7F8060", VA = "0x7F8060")]
		public DisableColliderAndCanvasFromParent()
		{
		}
	}
	[Token(Token = "0x20000B4")]
	public class SwitchKeyboardButtons : MonoBehaviour
	{
		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject newButtonPrefab;

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x7F8068", Offset = "0x7F8068", VA = "0x7F8068")]
		public SwitchKeyboardButtons()
		{
		}
	}
}
namespace HeadjackTemplate.UI
{
	[Token(Token = "0x20000B5")]
	public class ToggleG2 : Toggle, IGaze
	{
		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[SerializeField]
		private GameObject toggleIsSelect;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[SerializeField]
		private GameObject toggleIsDeselect;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[SerializeField]
		private GameObject noSound;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[SerializeField]
		private bool usePassedColor;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private IGaze gazeImplementation;

		[Token(Token = "0x17000079")]
		public new bool isOn
		{
			[Token(Token = "0x60004E4")]
			[Address(RVA = "0x7CA7F8", Offset = "0x7CA7F8", VA = "0x7CA7F8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004E5")]
			[Address(RVA = "0x7CA800", Offset = "0x7CA800", VA = "0x7CA800")]
			set
			{
			}
		}

		[Token(Token = "0x1700007A")]
		public new bool enabled
		{
			[Token(Token = "0x60004E6")]
			[Address(RVA = "0x7CA86C", Offset = "0x7CA86C", VA = "0x7CA86C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004E7")]
			[Address(RVA = "0x7CA880", Offset = "0x7CA880", VA = "0x7CA880")]
			set
			{
			}
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x7CA940", Offset = "0x7CA940", VA = "0x7CA940")]
		private void SetGraphicSelect()
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x7CAA50", Offset = "0x7CAA50", VA = "0x7CAA50")]
		private void SetGraphicDeselected()
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x7CAB60", Offset = "0x7CAB60", VA = "0x7CAB60", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x7CAC08", Offset = "0x7CAC08", VA = "0x7CAC08")]
		private new void OnEnable()
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x7CAC48", Offset = "0x7CAC48", VA = "0x7CAC48", Slot = "46")]
		public override void Rebuild(CanvasUpdate executing)
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x7CA874", Offset = "0x7CA874", VA = "0x7CA874")]
		public void OnValueChanged(bool value)
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x7CACCC", Offset = "0x7CACCC", VA = "0x7CACCC")]
		public void Selected()
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x7CACD0", Offset = "0x7CACD0", VA = "0x7CACD0")]
		public void Deselected()
		{
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x7CACD4", Offset = "0x7CACD4", VA = "0x7CACD4", Slot = "51")]
		public void OnGazSelect()
		{
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x7CAD14", Offset = "0x7CAD14", VA = "0x7CAD14")]
		public ToggleG2()
		{
		}
	}
	[Token(Token = "0x20000B6")]
	public class ProgressBar : MonoBehaviour
	{
		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image image;

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x7C0320", Offset = "0x7C0320", VA = "0x7C0320")]
		public void SetProgress(float value)
		{
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x7CA470", Offset = "0x7CA470", VA = "0x7CA470")]
		public ProgressBar()
		{
		}
	}
	[Token(Token = "0x20000B7")]
	public class HeadjeckUINormalize : MonoBehaviour
	{
		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float angleDiffReset;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float menuCameraHeightDiff;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float menuHeightDiffReset;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float menuPositionDiffReset;

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x804130", Offset = "0x804130", VA = "0x804130")]
		private void Start()
		{
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x80424C", Offset = "0x80424C", VA = "0x80424C")]
		private void Update()
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x804430", Offset = "0x804430", VA = "0x804430")]
		public HeadjeckUINormalize()
		{
		}
	}
	[Token(Token = "0x20000B8")]
	public class AllHollywoodMenus : MonoBehaviour
	{
		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject projects;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject sounds;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject miniSounds;

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x803F4C", Offset = "0x803F4C", VA = "0x803F4C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x803F50", Offset = "0x803F50", VA = "0x803F50")]
		public void OpenProjectsMenu()
		{
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x80401C", Offset = "0x80401C", VA = "0x80401C")]
		public void OpenSoundsMenu()
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x8040E8", Offset = "0x8040E8", VA = "0x8040E8")]
		public void DisableProjects()
		{
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x804108", Offset = "0x804108", VA = "0x804108")]
		public void EnableProjects()
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x804128", Offset = "0x804128", VA = "0x804128")]
		public AllHollywoodMenus()
		{
		}
	}
	[Token(Token = "0x20000B9")]
	public static class UIRay
	{
		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x7CB168", Offset = "0x7CB168", VA = "0x7CB168")]
		public static bool IsMousePointerOverUIElement()
		{
			return default(bool);
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x7CB2B0", Offset = "0x7CB2B0", VA = "0x7CB2B0")]
		public static bool IsPointerOverUIElement(List<RaycastResult> eventSystemRaysastResults)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x7CB17C", Offset = "0x7CB17C", VA = "0x7CB17C")]
		private static List<RaycastResult> GetMouseEventSystemRaycastResults()
		{
			return null;
		}
	}
	[Token(Token = "0x20000BA")]
	public class InputFieldG : InputField, IPointerClickHandler, IEventSystemHandler
	{
		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private OpenCanvasKeyboard openCanvasKeyboard;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private int _caretWidth;

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x804444", Offset = "0x804444", VA = "0x804444", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x8045C0", Offset = "0x8045C0", VA = "0x8045C0")]
		private void OnValueChanged(string arg0)
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x80464C", Offset = "0x80464C", VA = "0x80464C", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x804744", Offset = "0x804744", VA = "0x804744", Slot = "43")]
		public new void OnPointerClick(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x804870", Offset = "0x804870", VA = "0x804870")]
		private void ChangeHintTextColor()
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x8048DC", Offset = "0x8048DC", VA = "0x8048DC")]
		public InputFieldG()
		{
		}
	}
	[Token(Token = "0x20000BB")]
	public class ToggleG : Toggle, IGaze
	{
		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[SerializeField]
		private GameObject toggleIsSelect;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[SerializeField]
		private GameObject toggleIsDeselect;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[SerializeField]
		private GameObject noSound;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[SerializeField]
		private bool usePassedColor;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private IGaze gazeImplementation;

		[Token(Token = "0x1700007B")]
		public new bool isOn
		{
			[Token(Token = "0x6000506")]
			[Address(RVA = "0x7C7750", Offset = "0x7C7750", VA = "0x7C7750")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000507")]
			[Address(RVA = "0x7BD00C", Offset = "0x7BD00C", VA = "0x7BD00C")]
			set
			{
			}
		}

		[Token(Token = "0x1700007C")]
		public new bool enabled
		{
			[Token(Token = "0x6000508")]
			[Address(RVA = "0x7C8A38", Offset = "0x7C8A38", VA = "0x7C8A38")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000509")]
			[Address(RVA = "0x7BE67C", Offset = "0x7BE67C", VA = "0x7BE67C")]
			set
			{
			}
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x7CA484", Offset = "0x7CA484", VA = "0x7CA484")]
		private void SetGraphicSelect()
		{
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x7CA594", Offset = "0x7CA594", VA = "0x7CA594")]
		private void SetGraphicDeselected()
		{
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x7CA6A4", Offset = "0x7CA6A4", VA = "0x7CA6A4", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x7CA74C", Offset = "0x7CA74C", VA = "0x7CA74C")]
		private new void OnEnable()
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x7CA78C", Offset = "0x7CA78C", VA = "0x7CA78C", Slot = "46")]
		public override void Rebuild(CanvasUpdate executing)
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x7CA478", Offset = "0x7CA478", VA = "0x7CA478")]
		public void OnValueChanged(bool value)
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x7CA7A0", Offset = "0x7CA7A0", VA = "0x7CA7A0")]
		public void Selected()
		{
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x7CA7A4", Offset = "0x7CA7A4", VA = "0x7CA7A4")]
		public void Deselected()
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x7CA7A8", Offset = "0x7CA7A8", VA = "0x7CA7A8", Slot = "51")]
		public void OnGazSelect()
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x7CA7E8", Offset = "0x7CA7E8", VA = "0x7CA7E8")]
		public ToggleG()
		{
		}
	}
	[Token(Token = "0x20000BC")]
	public class ToggleSwitchObject : Toggle
	{
		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x119")]
		[SerializeField]
		private bool useAsNormalToggle;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11A")]
		[SerializeField]
		private bool deactivateToggleOnTrue;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[SerializeField]
		private GameObject toggleIsSelect;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[SerializeField]
		private GameObject toggleIsDeselect;

		[Token(Token = "0x1700007D")]
		public new bool isOn
		{
			[Token(Token = "0x6000515")]
			[Address(RVA = "0x7CAE0C", Offset = "0x7CAE0C", VA = "0x7CAE0C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000516")]
			[Address(RVA = "0x7C7758", Offset = "0x7C7758", VA = "0x7C7758")]
			set
			{
			}
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x7CAD24", Offset = "0x7CAD24", VA = "0x7CAD24")]
		private void SetGraphicSelect()
		{
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x7CAF2C", Offset = "0x7CAF2C", VA = "0x7CAF2C", Slot = "46")]
		public override void Rebuild(CanvasUpdate executing)
		{
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x7CAFD0", Offset = "0x7CAFD0", VA = "0x7CAFD0")]
		private void SetGraphicDeselected()
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x7CB0B8", Offset = "0x7CB0B8", VA = "0x7CB0B8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x7CAE14", Offset = "0x7CAE14", VA = "0x7CAE14")]
		private void OnValueChanged(bool value)
		{
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x7CB160", Offset = "0x7CB160", VA = "0x7CB160")]
		public ToggleSwitchObject()
		{
		}
	}
	[Token(Token = "0x20000BD")]
	public class VideoSlider : Slider
	{
		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FC5C0", Offset = "0x5FC5C0")]
		private bool <IsDrag>k__BackingField;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public Action actionOnPointerUp;

		[Token(Token = "0x1700007E")]
		public bool IsDrag
		{
			[Token(Token = "0x600051C")]
			[Address(RVA = "0x7CB388", Offset = "0x7CB388", VA = "0x7CB388")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FE950", Offset = "0x5FE950")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600051D")]
			[Address(RVA = "0x7CB390", Offset = "0x7CB390", VA = "0x7CB390")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FE960", Offset = "0x5FE960")]
			private set
			{
			}
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x7CB39C", Offset = "0x7CB39C", VA = "0x7CB39C", Slot = "32")]
		public override void OnPointerDown(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x7CB3C8", Offset = "0x7CB3C8", VA = "0x7CB3C8", Slot = "33")]
		public override void OnPointerUp(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x7C9B40", Offset = "0x7C9B40", VA = "0x7C9B40")]
		public void SetValueWithoutInvoke(float val)
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x7CB400", Offset = "0x7CB400", VA = "0x7CB400")]
		public VideoSlider()
		{
		}
	}
}
namespace HeadjackTemplate.UI.Activations
{
	[Token(Token = "0x20000BE")]
	public class InputFieldPasswordSwitcher : MonoBehaviour
	{
		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x5FC5D0", Offset = "0x5FC5D0")]
		[SerializeField]
		private InputField passwordField;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5FC61C", Offset = "0x5FC61C")]
		[SerializeField]
		private GameObject show;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private InputField.InputType showType;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5FC678", Offset = "0x5FC678")]
		[SerializeField]
		private GameObject hide;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private InputField.InputType hideType;

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x803E5C", Offset = "0x803E5C", VA = "0x803E5C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x803E60", Offset = "0x803E60", VA = "0x803E60")]
		private void SetUiAsType()
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x803ED8", Offset = "0x803ED8", VA = "0x803ED8")]
		public void PressButtonSwitchShowPassword()
		{
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x803F20", Offset = "0x803F20", VA = "0x803F20")]
		public InputFieldPasswordSwitcher()
		{
		}
	}
	[Token(Token = "0x20000BF")]
	public class UIOnPointerClick : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
	{
		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UnityEvent onInputFieldClick;

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x803F30", Offset = "0x803F30", VA = "0x803F30", Slot = "4")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x803F44", Offset = "0x803F44", VA = "0x803F44")]
		public UIOnPointerClick()
		{
		}
	}
}
namespace HeadjackTemplate.UI.Menu.Page
{
	[Token(Token = "0x20000C0")]
	public class BasePage : MonoBehaviour
	{
		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected MainMenu MainMenu;

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x7BC23C", Offset = "0x7BC23C", VA = "0x7BC23C")]
		protected void Awake()
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x7BC294", Offset = "0x7BC294", VA = "0x7BC294")]
		public BasePage()
		{
		}
	}
	[Token(Token = "0x20000C1")]
	public class PremiumPage : BasePage
	{
		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TMP_InputField code;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject premiumOrDemo;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject activateCode;

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x7BE910", Offset = "0x7BE910", VA = "0x7BE910")]
		public void PressButtonBack()
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x7BEA28", Offset = "0x7BEA28", VA = "0x7BEA28")]
		public void PressButtonActiveCode()
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x7BE9E4", Offset = "0x7BE9E4", VA = "0x7BE9E4")]
		public void OpenPremiumOrDemoPage()
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x7BEA2C", Offset = "0x7BEA2C", VA = "0x7BEA2C")]
		public void OpenActivateCodePage()
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x7BEA70", Offset = "0x7BEA70", VA = "0x7BEA70")]
		public void PressButtonDemo()
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x7BEB44", Offset = "0x7BEB44", VA = "0x7BEB44")]
		public void PressButtonPremium()
		{
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x7BE934", Offset = "0x7BE934", VA = "0x7BE934")]
		private void CloseKeyboard()
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x7BEB5C", Offset = "0x7BEB5C", VA = "0x7BEB5C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x7BEB60", Offset = "0x7BEB60", VA = "0x7BEB60")]
		public PremiumPage()
		{
		}
	}
	[Token(Token = "0x20000C2")]
	public class StartPage : BasePage
	{
		[Token(Token = "0x6000533")]
		[Address(RVA = "0x7C8FDC", Offset = "0x7C8FDC", VA = "0x7C8FDC")]
		public void PressButtonStart()
		{
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x7C90C0", Offset = "0x7C90C0", VA = "0x7C90C0")]
		public StartPage()
		{
		}
	}
	[Token(Token = "0x20000C3")]
	public class MeditationsComplete : MonoBehaviour
	{
		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject canvas;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject cleanAudioMemory;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x5FC734", Offset = "0x5FC734")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5FC734", Offset = "0x5FC734")]
		[SerializeField]
		private GameObject pageMeditationsCompleteNotPurchased;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject pageMeditationsCompletePurchased;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject pageUpgradeToPremium;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject pageWriteCode;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject keyboard;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject buttonResume;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject buttonPause;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private HeadjackTemplate.UI.Menu.Page.Video.VideoControls videoControls;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool _isTimeMoreThenDuration;

		[Token(Token = "0x1700007F")]
		private bool IsVideoTimeMoreThenDuration
		{
			[Token(Token = "0x6000535")]
			[Address(RVA = "0x7BD1C4", Offset = "0x7BD1C4", VA = "0x7BD1C4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000536")]
			[Address(RVA = "0x7BD1CC", Offset = "0x7BD1CC", VA = "0x7BD1CC")]
			set
			{
			}
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x7BD230", Offset = "0x7BD230", VA = "0x7BD230")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x7BD250", Offset = "0x7BD250", VA = "0x7BD250")]
		private void Start()
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x7BD32C", Offset = "0x7BD32C", VA = "0x7BD32C")]
		private void OnVideoEnd()
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x7BD4FC", Offset = "0x7BD4FC", VA = "0x7BD4FC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x7BD5E0", Offset = "0x7BD5E0", VA = "0x7BD5E0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x7BD6E4", Offset = "0x7BD6E4", VA = "0x7BD6E4")]
		private void Update()
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x7BD218", Offset = "0x7BD218", VA = "0x7BD218")]
		private void OnVideoEnd(bool isEnd)
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x7BD8F8", Offset = "0x7BD8F8", VA = "0x7BD8F8")]
		private void Delay()
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x7BD6E8", Offset = "0x7BD6E8", VA = "0x7BD6E8")]
		private void CheckVideoTime()
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x7BD98C", Offset = "0x7BD98C", VA = "0x7BD98C")]
		public void ReturnHome()
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x7BD9EC", Offset = "0x7BD9EC", VA = "0x7BD9EC")]
		public void PlayAgain()
		{
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x7BDD0C", Offset = "0x7BDD0C", VA = "0x7BDD0C")]
		private void AutoResume()
		{
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x7BDBF8", Offset = "0x7BDBF8", VA = "0x7BDBF8")]
		private void CloseAllPages()
		{
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x7BD500", Offset = "0x7BD500", VA = "0x7BD500")]
		public void OpenPageMeditationsComplete()
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x7BDFE0", Offset = "0x7BDFE0", VA = "0x7BDFE0")]
		public void OpenPageUpgradeToPremium()
		{
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x7BE04C", Offset = "0x7BE04C", VA = "0x7BE04C")]
		public void OpenPageWriteCode()
		{
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x7BE0B8", Offset = "0x7BE0B8", VA = "0x7BE0B8")]
		public void PressButtonUnlockPremium()
		{
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x7BE160", Offset = "0x7BE160", VA = "0x7BE160")]
		public MeditationsComplete()
		{
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x7BE170", Offset = "0x7BE170", VA = "0x7BE170")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FE970", Offset = "0x5FE970")]
		private void <PlayAgain>b__24_0(bool s, string e)
		{
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x7BE20C", Offset = "0x7BE20C", VA = "0x7BE20C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FE980", Offset = "0x5FE980")]
		private void <PlayAgain>b__24_1(bool ss, string ee)
		{
		}
	}
}
namespace HeadjackTemplate.UI.Menu.Page.Video
{
	[Token(Token = "0x20000C4")]
	public class ButtonPlay : MonoBehaviour
	{
		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject play;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject pause;

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x7C90C8", Offset = "0x7C90C8", VA = "0x7C90C8")]
		public void SwitchPlayPause()
		{
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x7C9200", Offset = "0x7C9200", VA = "0x7C9200")]
		private void Update()
		{
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0x7C9204", Offset = "0x7C9204", VA = "0x7C9204")]
		public ButtonPlay()
		{
		}
	}
	[Token(Token = "0x20000C5")]
	public class VideoControls : MonoBehaviour
	{
		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private MainVideoControls mainVideoControls;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private VideoSlider slider;

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x7C9718", Offset = "0x7C9718", VA = "0x7C9718")]
		private void Awake()
		{
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0x7C9770", Offset = "0x7C9770", VA = "0x7C9770")]
		private void Start()
		{
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0x7C9828", Offset = "0x7C9828", VA = "0x7C9828")]
		private void ActionOnPointerUp()
		{
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x7C9884", Offset = "0x7C9884", VA = "0x7C9884")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x7C9978", Offset = "0x7C9978", VA = "0x7C9978")]
		private void Update()
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x7C997C", Offset = "0x7C997C", VA = "0x7C997C")]
		private void UpdateSlider()
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x7C9B4C", Offset = "0x7C9B4C", VA = "0x7C9B4C")]
		public void Pause()
		{
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x7C982C", Offset = "0x7C982C", VA = "0x7C982C")]
		public void OnSliderValueChanged()
		{
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x7C9DF4", Offset = "0x7C9DF4", VA = "0x7C9DF4")]
		public void Resume()
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x7C9EEC", Offset = "0x7C9EEC", VA = "0x7C9EEC")]
		public void SeekLeft()
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x7CA28C", Offset = "0x7CA28C", VA = "0x7CA28C")]
		public void SeekRight()
		{
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x7CA2A8", Offset = "0x7CA2A8", VA = "0x7CA2A8")]
		public void ToMenu()
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x7CA380", Offset = "0x7CA380", VA = "0x7CA380")]
		public void OpenSettingPage()
		{
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x7CA448", Offset = "0x7CA448", VA = "0x7CA448")]
		public void SetSliderValueWithoutInvoke(float value)
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x7BD838", Offset = "0x7BD838", VA = "0x7BD838")]
		public void ResetSliderWithoutCallback()
		{
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x7CA468", Offset = "0x7CA468", VA = "0x7CA468")]
		public VideoControls()
		{
		}
	}
}
namespace HeadjackTemplate.UI.Menu.Page.Video.Time
{
	[Token(Token = "0x20000C6")]
	public class ShowVideoTimeUI : MonoBehaviour
	{
		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text textTime;

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x7C920C", Offset = "0x7C920C", VA = "0x7C920C")]
		private void Start()
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x7C9268", Offset = "0x7C9268", VA = "0x7C9268")]
		private void SetVideoUITime()
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x7C9490", Offset = "0x7C9490", VA = "0x7C9490")]
		private string FormatTime(long milliseconds)
		{
			return null;
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x7C951C", Offset = "0x7C951C", VA = "0x7C951C")]
		private void SetStaticVideoTime()
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x7C9710", Offset = "0x7C9710", VA = "0x7C9710")]
		public ShowVideoTimeUI()
		{
		}
	}
}
namespace HeadjackTemplate.UI.Menu.Page.Audio
{
	[Token(Token = "0x20000C7")]
	public class AudioSettings : MonoBehaviour
	{
		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5FC854", Offset = "0x5FC854")]
		[SerializeField]
		private bool useBlockSliders;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SliderWithBlocker ambisonic;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SliderWithBlocker voice;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SliderWithBlocker backgroundNatureSounds;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SliderWithBlocker backgroundMusic;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SliderWithBlocker backgroundDrumming;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5FC8F0", Offset = "0x5FC8F0")]
		[SerializeField]
		private AudioVolumeTemplate equilibrium;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private AudioVolumeTemplate atmosphere;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private AudioVolumeTemplate pureVoice;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private AudioVolumeTemplate onEnableSoundsSettings;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool _buttonSaveWasPressed;

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x804944", Offset = "0x804944", VA = "0x804944")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x804A74", Offset = "0x804A74", VA = "0x804A74")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x805258", Offset = "0x805258", VA = "0x805258")]
		private void Start()
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x80525C", Offset = "0x80525C", VA = "0x80525C")]
		private void MainVolumeSettingsToAllAudios(AudioVolumeTemplate settings)
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x804B84", Offset = "0x804B84", VA = "0x804B84")]
		private void MainVolumeSettingsFromAllAudios()
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x805A58", Offset = "0x805A58", VA = "0x805A58")]
		private void MainVolumeSettings()
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x804E14", Offset = "0x804E14", VA = "0x804E14")]
		private void PostVolumeSettings()
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x8057C4", Offset = "0x8057C4", VA = "0x8057C4")]
		private void BlockSlidersUnlessSounds()
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x805E48", Offset = "0x805E48", VA = "0x805E48")]
		private void DisableSlidersIfNoSound()
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x804958", Offset = "0x804958", VA = "0x804958")]
		private void SetSoundsSettings(AudioVolumeTemplate settings)
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x805E4C", Offset = "0x805E4C", VA = "0x805E4C")]
		private void SetLocal(AudioVolumeTemplate settings)
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x8061D4", Offset = "0x8061D4", VA = "0x8061D4")]
		private void SetGlobal(AudioVolumeTemplate settings)
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x80654C", Offset = "0x80654C", VA = "0x80654C")]
		public void PressButtonBack()
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x806720", Offset = "0x806720", VA = "0x806720")]
		public void PressButtonSave()
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x806798", Offset = "0x806798", VA = "0x806798")]
		private void Save()
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x807C84", Offset = "0x807C84", VA = "0x807C84")]
		private void ShowMainAudioSettings()
		{
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x807F2C", Offset = "0x807F2C", VA = "0x807F2C")]
		public void OpenSliderPage()
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x807F88", Offset = "0x807F88", VA = "0x807F88")]
		public void PressButtonEquilibrium()
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x807F90", Offset = "0x807F90", VA = "0x807F90")]
		public void PressButtonAtmosphere()
		{
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x807F98", Offset = "0x807F98", VA = "0x807F98")]
		public void PressButtonPureVoice()
		{
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x807FA0", Offset = "0x807FA0", VA = "0x807FA0")]
		public void ResetTheAmbisonicSoundToZero()
		{
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x808200", Offset = "0x808200", VA = "0x808200")]
		public void ResetTheNatureSoundsToZero()
		{
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x8084D4", Offset = "0x8084D4", VA = "0x8084D4")]
		public void ResetTheMusicSoundToZero()
		{
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0x8087A8", Offset = "0x8087A8", VA = "0x8087A8")]
		public void ResetTheVoiceSoundToZero()
		{
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x808A7C", Offset = "0x808A7C", VA = "0x808A7C")]
		public void ResetTheDrummingSoundToZero()
		{
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x806838", Offset = "0x806838", VA = "0x806838")]
		public void SetAmbisonicSounds()
		{
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x80740C", Offset = "0x80740C", VA = "0x80740C")]
		public void SetBackgroundNatureSounds()
		{
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x807848", Offset = "0x807848", VA = "0x807848")]
		public void SetBackgroundMusic()
		{
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x806FD0", Offset = "0x806FD0", VA = "0x806FD0")]
		public void SetBackgroundDrumming()
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x806B94", Offset = "0x806B94", VA = "0x806B94")]
		public void SetVoiceSound()
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x808D50", Offset = "0x808D50", VA = "0x808D50")]
		public AudioSettings()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000C8")]
	public class AudioVolumeTemplate
	{
		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5FC95C", Offset = "0x5FC95C")]
		public float sound3D;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5FC974", Offset = "0x5FC974")]
		public float voice;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5FC98C", Offset = "0x5FC98C")]
		public float natureSounds;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5FC9A4", Offset = "0x5FC9A4")]
		public float music;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5FC9BC", Offset = "0x5FC9BC")]
		public float drumming;

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x7BBF24", Offset = "0x7BBF24", VA = "0x7BBF24")]
		public AudioVolumeTemplate()
		{
		}
	}
	[Token(Token = "0x20000C9")]
	public class MainMenuAudioVolumeSettings : MonoBehaviour
	{
		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AllHollywoodMenus hollywoodMenus;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioSettings audioSettings;

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x7BBF3C", Offset = "0x7BBF3C", VA = "0x7BBF3C")]
		public void PressButtonSave()
		{
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x7BBFD0", Offset = "0x7BBFD0", VA = "0x7BBFD0")]
		public void PressButtonBack()
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x7BC064", Offset = "0x7BC064", VA = "0x7BC064")]
		public MainMenuAudioVolumeSettings()
		{
		}
	}
	[Token(Token = "0x20000CA")]
	public class SliderWithBlocker : Slider
	{
		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public GameObject muteButton;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public GameObject onBlockEnable;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private bool _isBlocked;

		[Token(Token = "0x17000080")]
		public override float value
		{
			[Token(Token = "0x6000587")]
			[Address(RVA = "0x7BC078", Offset = "0x7BC078", VA = "0x7BC078", Slot = "46")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000588")]
			[Address(RVA = "0x7BC080", Offset = "0x7BC080", VA = "0x7BC080", Slot = "47")]
			set
			{
			}
		}

		[Token(Token = "0x17000081")]
		public bool IsBlocked
		{
			[Token(Token = "0x6000589")]
			[Address(RVA = "0x7BC094", Offset = "0x7BC094", VA = "0x7BC094")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600058A")]
			[Address(RVA = "0x7BC074", Offset = "0x7BC074", VA = "0x7BC074")]
			set
			{
			}
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x7BC06C", Offset = "0x7BC06C", VA = "0x7BC06C")]
		private new void Start()
		{
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x7BC09C", Offset = "0x7BC09C", VA = "0x7BC09C")]
		private void Block(bool isBlock)
		{
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x7BC234", Offset = "0x7BC234", VA = "0x7BC234")]
		public SliderWithBlocker()
		{
		}
	}
}
namespace HeadjackTemplate.UI.Menu.Page.Settings
{
	[Token(Token = "0x20000CB")]
	public class ButtonsSwitchSoundPage : MonoBehaviour
	{
		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private SoundSettingsPage soundSettingsPage;

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x7C7CA8", Offset = "0x7C7CA8", VA = "0x7C7CA8")]
		private void Start()
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x7C7D00", Offset = "0x7C7D00", VA = "0x7C7D00")]
		public void OpenMeditationPage()
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x7C7D70", Offset = "0x7C7D70", VA = "0x7C7D70")]
		public void OpenVoicePage()
		{
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x7C7DE0", Offset = "0x7C7DE0", VA = "0x7C7DE0")]
		public void OpenSoundsPage()
		{
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x7C7E50", Offset = "0x7C7E50", VA = "0x7C7E50")]
		public ButtonsSwitchSoundPage()
		{
		}
	}
	[Token(Token = "0x20000CC")]
	public class SettingsButtons : MonoBehaviour
	{
		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5FC9F4", Offset = "0x5FC9F4")]
		[SerializeField]
		private GameObject meditation;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject voice;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject sounds;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5FCA60", Offset = "0x5FCA60")]
		[SerializeField]
		private Toggle meditationToggle;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Toggle voiceToggle;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Toggle soundsToggle;

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x7C8DD4", Offset = "0x7C8DD4", VA = "0x7C8DD4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x7C8F00", Offset = "0x7C8F00", VA = "0x7C8F00")]
		private void OnToggle(bool active)
		{
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x7C8FA0", Offset = "0x7C8FA0", VA = "0x7C8FA0")]
		public SettingsButtons()
		{
		}
	}
	[Token(Token = "0x20000CD")]
	public class SoundSettingsPage : BasePage
	{
		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject meditation;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject voice;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject sounds;

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x7C8FA8", Offset = "0x7C8FA8", VA = "0x7C8FA8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x7C7D18", Offset = "0x7C7D18", VA = "0x7C7D18")]
		public void OpenMeditationPage()
		{
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x7C7D88", Offset = "0x7C7D88", VA = "0x7C7D88")]
		public void OpenVoicePage()
		{
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x7C7DF8", Offset = "0x7C7DF8", VA = "0x7C7DF8")]
		public void OpenSoundsPage()
		{
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x7C8FAC", Offset = "0x7C8FAC", VA = "0x7C8FAC")]
		public SoundSettingsPage()
		{
		}
	}
	[Token(Token = "0x20000CE")]
	public class SoundSettingsShortPage : BasePage
	{
		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject buttonContinue;

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x7C8FB4", Offset = "0x7C8FB4", VA = "0x7C8FB4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x7C8FD4", Offset = "0x7C8FD4", VA = "0x7C8FD4")]
		public SoundSettingsShortPage()
		{
		}
	}
}
namespace HeadjackTemplate.UI.Menu.Page.Settings.LoadPrefs
{
	[Token(Token = "0x20000CF")]
	public class BackgroundDifferentNoSound : MonoBehaviour
	{
		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ToggleG[] toggles;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Toggle toggle;

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x7C7E58", Offset = "0x7C7E58", VA = "0x7C7E58")]
		private void Start()
		{
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x7C7FA4", Offset = "0x7C7FA4", VA = "0x7C7FA4")]
		public void ToggleNoSoundSetValue(bool value)
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x7C8100", Offset = "0x7C8100", VA = "0x7C8100")]
		public BackgroundDifferentNoSound()
		{
		}
	}
	[Token(Token = "0x20000D0")]
	public class BackgroundDifferentSounds : MonoBehaviour
	{
		[Token(Token = "0x2000194")]
		private enum SoundsType
		{
			[Token(Token = "0x400077E")]
			Nature,
			[Token(Token = "0x400077F")]
			Music,
			[Token(Token = "0x4000780")]
			Drumming,
			[Token(Token = "0x4000781")]
			NoSounds
		}

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SoundsType soundsType;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Toggle noSound;

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x7C8108", Offset = "0x7C8108", VA = "0x7C8108")]
		private void Start()
		{
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x7C810C", Offset = "0x7C810C", VA = "0x7C810C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x7C8110", Offset = "0x7C8110", VA = "0x7C8110")]
		public void SaveSoundPrefs()
		{
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x7C8384", Offset = "0x7C8384", VA = "0x7C8384")]
		private void SetToggleBySoundsType()
		{
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x7C8574", Offset = "0x7C8574", VA = "0x7C8574")]
		private bool IsMute(SoundsType soundsType)
		{
			return default(bool);
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x7C8598", Offset = "0x7C8598", VA = "0x7C8598")]
		private float GetVolumeBySoundType(SoundsType soundsType)
		{
			return default(float);
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x7C8768", Offset = "0x7C8768", VA = "0x7C8768")]
		public BackgroundDifferentSounds()
		{
		}
	}
	[Token(Token = "0x20000D1")]
	public class BackgroundSound : MonoBehaviour
	{
		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AppManager.BackgroundSound backgroundSound;

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x7C8770", Offset = "0x7C8770", VA = "0x7C8770")]
		private void Start()
		{
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x7C886C", Offset = "0x7C886C", VA = "0x7C886C")]
		public void SetBackgroundSound()
		{
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x7C88E0", Offset = "0x7C88E0", VA = "0x7C88E0")]
		public BackgroundSound()
		{
		}
	}
	[Token(Token = "0x20000D2")]
	public class MeditationProgram : MonoBehaviour
	{
		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x7C88E8", Offset = "0x7C88E8", VA = "0x7C88E8")]
		public MeditationProgram()
		{
		}
	}
	[Token(Token = "0x20000D3")]
	public class MeditationTime : MonoBehaviour
	{
		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AppManager.MeditationTime time;

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x7C88F0", Offset = "0x7C88F0", VA = "0x7C88F0")]
		private void Start()
		{
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x7C8A40", Offset = "0x7C8A40", VA = "0x7C8A40")]
		public void SetMeditationTime()
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x7C8AB4", Offset = "0x7C8AB4", VA = "0x7C8AB4")]
		public MeditationTime()
		{
		}
	}
	[Token(Token = "0x20000D4")]
	public class SoundSelect : MonoBehaviour
	{
		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x7C8ABC", Offset = "0x7C8ABC", VA = "0x7C8ABC")]
		public SoundSelect()
		{
		}
	}
	[Token(Token = "0x20000D5")]
	public class VoiceSex : MonoBehaviour
	{
		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AppManager.VoiceSex sex;

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x7C8AC4", Offset = "0x7C8AC4", VA = "0x7C8AC4")]
		private void Start()
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x7C8AC8", Offset = "0x7C8AC8", VA = "0x7C8AC8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x7C8ACC", Offset = "0x7C8ACC", VA = "0x7C8ACC")]
		private void SetToggleByType()
		{
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x7C8C04", Offset = "0x7C8C04", VA = "0x7C8C04")]
		private bool IsMute()
		{
			return default(bool);
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x7C8C28", Offset = "0x7C8C28", VA = "0x7C8C28")]
		private float GetSexVolume()
		{
			return default(float);
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x7C8D58", Offset = "0x7C8D58", VA = "0x7C8D58")]
		public void SetVoiceSex()
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x7C8DCC", Offset = "0x7C8DCC", VA = "0x7C8DCC")]
		public VoiceSex()
		{
		}
	}
}
namespace HeadjackTemplate.UI.Menu.Page.Settings.Block
{
	[Token(Token = "0x20000D6")]
	public class BlockNoSound10min : BlockNoSoundFileBase
	{
		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x7C72E8", Offset = "0x7C72E8", VA = "0x7C72E8", Slot = "4")]
		public override bool IsBlock()
		{
			return default(bool);
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x7C746C", Offset = "0x7C746C", VA = "0x7C746C")]
		public BlockNoSound10min()
		{
		}
	}
	[Token(Token = "0x20000D7")]
	public class BlockNoSoundBackground : BlockNoSoundFileBase
	{
		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AppManager.BackgroundSound backgroundSound;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		protected ToggleSwitchObject selectToggleSwitchIfBlockSelected;

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x7C747C", Offset = "0x7C747C", VA = "0x7C747C", Slot = "4")]
		public override bool IsBlock()
		{
			return default(bool);
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x7C7648", Offset = "0x7C7648", VA = "0x7C7648")]
		protected new void OnEnable()
		{
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x7C77B8", Offset = "0x7C77B8", VA = "0x7C77B8")]
		public BlockNoSoundBackground()
		{
		}
	}
	[Token(Token = "0x20000D8")]
	public abstract class BlockNoSoundFileBase : MonoBehaviour
	{
		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected GameObject blockUiObject;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected ToggleG blockToggle;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected ToggleG selectIfBlockSelected;

		[Token(Token = "0x60005BA")]
		public abstract bool IsBlock();

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x7C77C0", Offset = "0x7C77C0", VA = "0x7C77C0")]
		protected void OnEnable()
		{
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x7C77CC", Offset = "0x7C77CC", VA = "0x7C77CC", Slot = "5")]
		protected virtual void ReEnableBlockUi()
		{
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x7C7474", Offset = "0x7C7474", VA = "0x7C7474")]
		protected BlockNoSoundFileBase()
		{
		}
	}
	[Token(Token = "0x20000D9")]
	public class BlockNoSoundVoice : BlockNoSoundFileBase
	{
		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AppManager.VoiceSex voiceSex;

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x7C7840", Offset = "0x7C7840", VA = "0x7C7840")]
		protected new void OnEnable()
		{
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x7C7928", Offset = "0x7C7928", VA = "0x7C7928")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x7C7A30", Offset = "0x7C7A30", VA = "0x7C7A30", Slot = "4")]
		public override bool IsBlock()
		{
			return default(bool);
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x7C7C94", Offset = "0x7C7C94", VA = "0x7C7C94")]
		public BlockNoSoundVoice()
		{
		}
	}
	[Token(Token = "0x20000DA")]
	public class NoVoiceOverToggleOn : MonoBehaviour
	{
		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x7C7C9C", Offset = "0x7C7C9C", VA = "0x7C7C9C")]
		private void Start()
		{
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x7C7CA0", Offset = "0x7C7CA0", VA = "0x7C7CA0")]
		public NoVoiceOverToggleOn()
		{
		}
	}
}
namespace HeadjackTemplate.UI.Menu.Page.Premium
{
	[Token(Token = "0x20000DB")]
	public class BlockPremiumBase : MonoBehaviour
	{
		[Token(Token = "0x2000195")]
		protected enum LockStatus
		{
			[Token(Token = "0x4000783")]
			Lock,
			[Token(Token = "0x4000784")]
			Unlock
		}

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected GameObject blockContent;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected MonoBehaviour blockScript;

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x7BE210", Offset = "0x7BE210", VA = "0x7BE210")]
		protected void Start()
		{
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x7BE214", Offset = "0x7BE214", VA = "0x7BE214", Slot = "4")]
		protected virtual void LockContent()
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x7BE300", Offset = "0x7BE300", VA = "0x7BE300", Slot = "5")]
		protected virtual void UnlockContent()
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x7BE3EC", Offset = "0x7BE3EC", VA = "0x7BE3EC", Slot = "6")]
		protected virtual void OnLockOrUnlock(LockStatus lockStatus)
		{
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x7BE3F0", Offset = "0x7BE3F0", VA = "0x7BE3F0")]
		public BlockPremiumBase()
		{
		}
	}
	[Token(Token = "0x20000DC")]
	public class BlockPremiumToggle : BlockPremiumBase
	{
		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Toggle selectOnLock;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Toggle thisToggle;

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x7BE3F8", Offset = "0x7BE3F8", VA = "0x7BE3F8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x7BE450", Offset = "0x7BE450", VA = "0x7BE450", Slot = "6")]
		protected override void OnLockOrUnlock(LockStatus lockStatus)
		{
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x7BE534", Offset = "0x7BE534", VA = "0x7BE534")]
		public BlockPremiumToggle()
		{
		}
	}
	[Token(Token = "0x20000DD")]
	public class BlockPremiumToggleG : BlockPremiumBase
	{
		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Toggle selectOnLock;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected ToggleG blockToggleG;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Toggle thisToggleG;

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x7BE53C", Offset = "0x7BE53C", VA = "0x7BE53C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x7BE594", Offset = "0x7BE594", VA = "0x7BE594", Slot = "4")]
		protected override void LockContent()
		{
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x7BE73C", Offset = "0x7BE73C", VA = "0x7BE73C", Slot = "5")]
		protected override void UnlockContent()
		{
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x7BE824", Offset = "0x7BE824", VA = "0x7BE824", Slot = "6")]
		protected override void OnLockOrUnlock(LockStatus lockStatus)
		{
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x7BE908", Offset = "0x7BE908", VA = "0x7BE908")]
		public BlockPremiumToggleG()
		{
		}
	}
}
namespace HeadjackTemplate.UI.Menu.Page.MeditationPage
{
	[Token(Token = "0x20000DE")]
	public class MeditationProgramPage : BasePage
	{
		[Serializable]
		[Token(Token = "0x2000196")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB334", Offset = "0x5FB334")]
		private sealed class <>c
		{
			[Token(Token = "0x4000785")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000786")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static OnEnd <>9__0_0;

			[Token(Token = "0x60009D3")]
			[Address(RVA = "0x7BCF50", Offset = "0x7BCF50", VA = "0x7BCF50")]
			public <>c()
			{
			}

			[Token(Token = "0x60009D4")]
			[Address(RVA = "0x7BCF58", Offset = "0x7BCF58", VA = "0x7BCF58")]
			internal void <Start>b__0_0(bool s, string e)
			{
			}
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x7BCD84", Offset = "0x7BCD84", VA = "0x7BCD84")]
		private void Start()
		{
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x7BCE80", Offset = "0x7BCE80", VA = "0x7BCE80")]
		public void PressButtonHowItWorks()
		{
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x7BCE84", Offset = "0x7BCE84", VA = "0x7BCE84")]
		public void PressButtonBegin()
		{
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x7BCEE4", Offset = "0x7BCEE4", VA = "0x7BCEE4")]
		public MeditationProgramPage()
		{
		}
	}
	[Token(Token = "0x20000DF")]
	public class ToggleMeditationProgramSetter : MonoBehaviour
	{
		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AppManager.MeditationProgram meditationProgram;

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x7BCF5C", Offset = "0x7BCF5C", VA = "0x7BCF5C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x7BCF60", Offset = "0x7BCF60", VA = "0x7BCF60")]
		private void SetToggleByType()
		{
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x7BD0D0", Offset = "0x7BD0D0", VA = "0x7BD0D0")]
		public void SetMeditationProgram()
		{
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x7BD1BC", Offset = "0x7BD1BC", VA = "0x7BD1BC")]
		public ToggleMeditationProgramSetter()
		{
		}
	}
}
namespace HeadjackTemplate.UI.Menu.Page.LogIn
{
	[Token(Token = "0x20000E0")]
	public class LogIn : BasePage
	{
		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject buttons;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject inputFields;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private InputField logIn;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private InputField password;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject buttonLogIn;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject Text_FindYourselft;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject Text_LoginExplanation;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private string _userName;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private string _userPassword;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool IsLogInPage;

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x7BC29C", Offset = "0x7BC29C", VA = "0x7BC29C")]
		public bool IsUserNameAndLoginExist()
		{
			return default(bool);
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x7BC2E4", Offset = "0x7BC2E4", VA = "0x7BC2E4")]
		private new void Awake()
		{
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x7BC5A0", Offset = "0x7BC5A0", VA = "0x7BC5A0")]
		private void Start()
		{
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x7BC478", Offset = "0x7BC478", VA = "0x7BC478")]
		private void ButtonsActivation()
		{
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x7BC5A4", Offset = "0x7BC5A4", VA = "0x7BC5A4")]
		private void OnAuthorizationEnd()
		{
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x7BC6DC", Offset = "0x7BC6DC", VA = "0x7BC6DC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x7BC3D8", Offset = "0x7BC3D8", VA = "0x7BC3D8")]
		private void LoadLoginAndPass()
		{
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x7BC7E4", Offset = "0x7BC7E4", VA = "0x7BC7E4")]
		private void SaveLoginAndPass()
		{
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x7BC89C", Offset = "0x7BC89C", VA = "0x7BC89C")]
		public void OpenLogInButtonsMenu()
		{
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x7BC908", Offset = "0x7BC908", VA = "0x7BC908")]
		public void LogInRegistrationWithoutCallBack()
		{
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x7BCA38", Offset = "0x7BCA38", VA = "0x7BCA38")]
		public void PressButtonOpenLogInPage()
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x7BCAA4", Offset = "0x7BCAA4", VA = "0x7BCAA4")]
		public void PressButtonBack()
		{
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x7BCB54", Offset = "0x7BCB54", VA = "0x7BCB54")]
		public void PressButtonTryFreeDemo()
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x7BC67C", Offset = "0x7BC67C", VA = "0x7BC67C")]
		private void LoadMainScene()
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x7BCBB0", Offset = "0x7BCBB0", VA = "0x7BCBB0")]
		public void PressButtonLogIn()
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x7BCD14", Offset = "0x7BCD14", VA = "0x7BCD14")]
		public LogIn()
		{
		}
	}
}
namespace HeadjackTemplate.UI.Menu.Page.Projects
{
	[Token(Token = "0x20000E1")]
	public class DownloadAndPlayVideo : MonoBehaviour
	{
		[Token(Token = "0x2000197")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB344", Offset = "0x5FB344")]
		private sealed class <CountVideoProgress>d__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000787")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000788")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000789")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DownloadAndPlayVideo <>4__this;

			[Token(Token = "0x400078A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private string <projectId>5__2;

			[Token(Token = "0x170000F6")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009D8")]
				[Address(RVA = "0x7BF83C", Offset = "0x7BF83C", VA = "0x7BF83C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F7")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009DA")]
				[Address(RVA = "0x7BF8A4", Offset = "0x7BF8A4", VA = "0x7BF8A4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009D5")]
			[Address(RVA = "0x7BF2A4", Offset = "0x7BF2A4", VA = "0x7BF2A4")]
			[DebuggerHidden]
			public <CountVideoProgress>d__17(int <>1__state)
			{
			}

			[Token(Token = "0x60009D6")]
			[Address(RVA = "0x7BF5AC", Offset = "0x7BF5AC", VA = "0x7BF5AC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009D7")]
			[Address(RVA = "0x7BF5B0", Offset = "0x7BF5B0", VA = "0x7BF5B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009D9")]
			[Address(RVA = "0x7BF844", Offset = "0x7BF844", VA = "0x7BF844", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static DownloadAndPlayVideo Instance;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Coroutine progressCor;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FCC9C", Offset = "0x5FCC9C")]
		private bool <IsDownloading>k__BackingField;

		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FCCAC", Offset = "0x5FCCAC")]
		private float <DownloadVideoProgress>k__BackingField;

		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string downloadingId;

		[Token(Token = "0x17000082")]
		public bool IsDownloading
		{
			[Token(Token = "0x60005EA")]
			[Address(RVA = "0x7BEB68", Offset = "0x7BEB68", VA = "0x7BEB68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FE990", Offset = "0x5FE990")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005EB")]
			[Address(RVA = "0x7BEB70", Offset = "0x7BEB70", VA = "0x7BEB70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FE9A0", Offset = "0x5FE9A0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000083")]
		public float DownloadVideoProgress
		{
			[Token(Token = "0x60005EC")]
			[Address(RVA = "0x7BEB7C", Offset = "0x7BEB7C", VA = "0x7BEB7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FE9B0", Offset = "0x5FE9B0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005ED")]
			[Address(RVA = "0x7BEB84", Offset = "0x7BEB84", VA = "0x7BEB84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FE9C0", Offset = "0x5FE9C0")]
			private set
			{
			}
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x7BEB8C", Offset = "0x7BEB8C", VA = "0x7BEB8C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x7BEBF8", Offset = "0x7BEBF8", VA = "0x7BEBF8")]
		private void Start()
		{
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x7BECD4", Offset = "0x7BECD4", VA = "0x7BECD4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x7BEDD8", Offset = "0x7BEDD8", VA = "0x7BEDD8")]
		private void OnVideoSelectionAnimationEnd()
		{
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x7BEE7C", Offset = "0x7BEE7C", VA = "0x7BEE7C")]
		private void ReEnableButtons()
		{
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x7BF100", Offset = "0x7BF100", VA = "0x7BF100")]
		public void PressButtonDownloadVideo()
		{
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x7BF234", Offset = "0x7BF234", VA = "0x7BF234")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5FE9D0", Offset = "0x5FE9D0")]
		private IEnumerator CountVideoProgress()
		{
			return null;
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x7BF2D0", Offset = "0x7BF2D0", VA = "0x7BF2D0")]
		public void PressButtonPlayVideo()
		{
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x7BF394", Offset = "0x7BF394", VA = "0x7BF394")]
		public void PressButtonDelete()
		{
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x7BF488", Offset = "0x7BF488", VA = "0x7BF488")]
		public DownloadAndPlayVideo()
		{
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x7BF4EC", Offset = "0x7BF4EC", VA = "0x7BF4EC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FEA34", Offset = "0x5FEA34")]
		private void <PressButtonDownloadVideo>b__16_0(bool s, string e)
		{
		}
	}
}
namespace HeadjackTemplate.UI.Menu.Page.Projects.Hollywood
{
	[Token(Token = "0x20000E2")]
	public class FadeTextMeshColor : FadeBase
	{
		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI _tmpGui;

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _currentColor;

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x7C2494", Offset = "0x7C2494", VA = "0x7C2494", Slot = "6")]
		protected override void FadePerFrame(float progress, Status status)
		{
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x7C2590", Offset = "0x7C2590", VA = "0x7C2590")]
		public FadeTextMeshColor()
		{
		}
	}
	[Token(Token = "0x20000E3")]
	public class BottomMenu : MonoBehaviour
	{
		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AllHollywoodMenus hollywoodMenus;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject buttonMeditation;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject buttonUnlockPremium;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject accountPage;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject becomeproPage;

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x7BF954", Offset = "0x7BF954", VA = "0x7BF954")]
		public void PressButtonSettings()
		{
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x7BF970", Offset = "0x7BF970", VA = "0x7BF970")]
		public void PressButtonAccount()
		{
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x7BFAFC", Offset = "0x7BFAFC", VA = "0x7BFAFC")]
		public void BecomePro()
		{
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x7BFB1C", Offset = "0x7BFB1C", VA = "0x7BFB1C")]
		public void PressButtonFaves()
		{
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x7BFB20", Offset = "0x7BFB20", VA = "0x7BFB20")]
		public void PressButtonUnlockPremium()
		{
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0x7BFCA4", Offset = "0x7BFCA4", VA = "0x7BFCA4")]
		public void PressButtonBackToMeditationProgram()
		{
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0x7BFD58", Offset = "0x7BFD58", VA = "0x7BFD58")]
		public void PressButtonLogOut()
		{
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0x7BFE08", Offset = "0x7BFE08", VA = "0x7BFE08")]
		public BottomMenu()
		{
		}
	}
	[Token(Token = "0x20000E4")]
	public class Buffering : MonoBehaviour
	{
		[Token(Token = "0x2000198")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB354", Offset = "0x5FB354")]
		private sealed class <waitDownloadEnd>d__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400078B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400078C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400078D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Buffering <>4__this;

			[Token(Token = "0x400078E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <maxProgress>5__2;

			[Token(Token = "0x400078F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private long <totalSize>5__3;

			[Token(Token = "0x170000F8")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009DE")]
				[Address(RVA = "0x7C0350", Offset = "0x7C0350", VA = "0x7C0350", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F9")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009E0")]
				[Address(RVA = "0x7C03B8", Offset = "0x7C03B8", VA = "0x7C03B8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009DB")]
			[Address(RVA = "0x7C00D0", Offset = "0x7C00D0", VA = "0x7C00D0")]
			[DebuggerHidden]
			public <waitDownloadEnd>d__5(int <>1__state)
			{
			}

			[Token(Token = "0x60009DC")]
			[Address(RVA = "0x7C0104", Offset = "0x7C0104", VA = "0x7C0104", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009DD")]
			[Address(RVA = "0x7C0108", Offset = "0x7C0108", VA = "0x7C0108", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009DF")]
			[Address(RVA = "0x7C0358", Offset = "0x7C0358", VA = "0x7C0358", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ProgressBar progressBar;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private HollywoodProjectVisual _hollywoodProjectVisual;

		[Token(Token = "0x6000604")]
		[Address(RVA = "0x7BFE10", Offset = "0x7BFE10", VA = "0x7BFE10")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x7BFE68", Offset = "0x7BFE68", VA = "0x7BFE68")]
		public void PressButtonCancelDownload()
		{
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x7C0034", Offset = "0x7C0034", VA = "0x7C0034")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0x7C0060", Offset = "0x7C0060", VA = "0x7C0060")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5FEA44", Offset = "0x5FEA44")]
		private IEnumerator waitDownloadEnd()
		{
			return null;
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0x7C00FC", Offset = "0x7C00FC", VA = "0x7C00FC")]
		public Buffering()
		{
		}
	}
	[Token(Token = "0x20000E5")]
	public abstract class FadeBase : MonoBehaviour, IFadeUi
	{
		[Token(Token = "0x2000199")]
		protected enum Status
		{
			[Token(Token = "0x4000791")]
			In,
			[Token(Token = "0x4000792")]
			Out
		}

		[Token(Token = "0x200019A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB364", Offset = "0x5FB364")]
		private sealed class <Fade>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000793")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000794")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000795")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FadeBase <>4__this;

			[Token(Token = "0x4000796")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float fadeTime;

			[Token(Token = "0x4000797")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Status status;

			[Token(Token = "0x4000798")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <countTime>5__2;

			[Token(Token = "0x170000FA")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009E4")]
				[Address(RVA = "0x7C061C", Offset = "0x7C061C", VA = "0x7C061C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000FB")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009E6")]
				[Address(RVA = "0x7C0684", Offset = "0x7C0684", VA = "0x7C0684", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009E1")]
			[Address(RVA = "0x7C0488", Offset = "0x7C0488", VA = "0x7C0488")]
			[DebuggerHidden]
			public <Fade>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x60009E2")]
			[Address(RVA = "0x7C0534", Offset = "0x7C0534", VA = "0x7C0534", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009E3")]
			[Address(RVA = "0x7C0538", Offset = "0x7C0538", VA = "0x7C0538", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009E5")]
			[Address(RVA = "0x7C0624", Offset = "0x7C0624", VA = "0x7C0624", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IFadeUi fadeUiImplementation;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FCD3C", Offset = "0x5FCD3C")]
		private bool <BlockAutoFade>k__BackingField;

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FCD4C", Offset = "0x5FCD4C")]
		private bool <IsProgress>k__BackingField;

		[Token(Token = "0x17000084")]
		public bool BlockAutoFade
		{
			[Token(Token = "0x600060A")]
			[Address(RVA = "0x7C03C0", Offset = "0x7C03C0", VA = "0x7C03C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FEAA8", Offset = "0x5FEAA8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600060B")]
			[Address(RVA = "0x7C03C8", Offset = "0x7C03C8", VA = "0x7C03C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FEAB8", Offset = "0x5FEAB8")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000085")]
		public bool IsProgress
		{
			[Token(Token = "0x600060C")]
			[Address(RVA = "0x7C03D4", Offset = "0x7C03D4", VA = "0x7C03D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FEAC8", Offset = "0x5FEAC8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600060D")]
			[Address(RVA = "0x7C03DC", Offset = "0x7C03DC", VA = "0x7C03DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FEAD8", Offset = "0x5FEAD8")]
			protected set
			{
			}
		}

		[Token(Token = "0x6000609")]
		protected abstract void FadePerFrame(float progress, Status status);

		[Token(Token = "0x600060E")]
		[Address(RVA = "0x7C03E8", Offset = "0x7C03E8", VA = "0x7C03E8", Slot = "7")]
		protected virtual void FadeEnd(Status status)
		{
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0x7C03EC", Offset = "0x7C03EC", VA = "0x7C03EC")]
		protected void OnDisable()
		{
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0x7C03F8", Offset = "0x7C03F8", VA = "0x7C03F8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5FEAE8", Offset = "0x5FEAE8")]
		private IEnumerator Fade(float fadeTime, Status status)
		{
			return null;
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0x7BF8CC", Offset = "0x7BF8CC", VA = "0x7BF8CC", Slot = "4")]
		public void FadeIn(float fadeTime)
		{
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x7C04B4", Offset = "0x7C04B4", VA = "0x7C04B4", Slot = "5")]
		public void FadeOut(float fadeTime)
		{
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x7C052C", Offset = "0x7C052C", VA = "0x7C052C")]
		protected FadeBase()
		{
		}
	}
	[Token(Token = "0x20000E6")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5FAB0C", Offset = "0x5FAB0C")]
	public class FadeBlurRawImage : FadeBase
	{
		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private RawImage _renderer;

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int Size;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly int ColorMul;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private HollywoodProjectVisual _hollywoodProjectVisual;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Color colorTo;

		[Token(Token = "0x6000614")]
		[Address(RVA = "0x7C0768", Offset = "0x7C0768", VA = "0x7C0768")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0x7C084C", Offset = "0x7C084C", VA = "0x7C084C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0x7C090C", Offset = "0x7C090C", VA = "0x7C090C")]
		private void OnMiddleAnimation(HollywoodProjectVisual.StatePosition prev, HollywoodProjectVisual.StatePosition next)
		{
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0x7C0940", Offset = "0x7C0940", VA = "0x7C0940")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x7C0A04", Offset = "0x7C0A04", VA = "0x7C0A04", Slot = "6")]
		protected override void FadePerFrame(float progress, Status status)
		{
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x7C0C0C", Offset = "0x7C0C0C", VA = "0x7C0C0C")]
		public FadeBlurRawImage()
		{
		}
	}
	[Token(Token = "0x20000E7")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5FAB70", Offset = "0x5FAB70")]
	public class FadeImage : FadeBase
	{
		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Image _image;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Color _startColor;

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x7C0C98", Offset = "0x7C0C98", VA = "0x7C0C98")]
		private void Awake()
		{
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x7C0D48", Offset = "0x7C0D48", VA = "0x7C0D48", Slot = "6")]
		protected override void FadePerFrame(float progress, Status status)
		{
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x7C0E44", Offset = "0x7C0E44", VA = "0x7C0E44")]
		public FadeImage()
		{
		}
	}
	[Token(Token = "0x20000E8")]
	public class FadeImageColor : FadeBase
	{
		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _image;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x5FCD6C", Offset = "0x5FCD6C")]
		[SerializeField]
		private Color _currentColor;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Outline _outline;

		[Token(Token = "0x600061E")]
		[Address(RVA = "0x7C0E4C", Offset = "0x7C0E4C", VA = "0x7C0E4C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0x7C0EA4", Offset = "0x7C0EA4", VA = "0x7C0EA4", Slot = "6")]
		protected override void FadePerFrame(float progress, Status status)
		{
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0x7C0FF4", Offset = "0x7C0FF4", VA = "0x7C0FF4")]
		public FadeImageColor()
		{
		}
	}
	[Token(Token = "0x20000E9")]
	public class FadeInOutOnProjectInOut : MonoBehaviour
	{
		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private HollywoodProjectVisual _hollywoodProjectVisual;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private IFadeUi _fadeUi;

		[Token(Token = "0x6000621")]
		[Address(RVA = "0x7C1028", Offset = "0x7C1028", VA = "0x7C1028")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0x7C1098", Offset = "0x7C1098", VA = "0x7C1098")]
		private void FadeOutStart()
		{
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0x7C1158", Offset = "0x7C1158", VA = "0x7C1158")]
		private void FadeInStart()
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0x7C1214", Offset = "0x7C1214", VA = "0x7C1214")]
		private void Start()
		{
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0x7C12D4", Offset = "0x7C12D4", VA = "0x7C12D4")]
		private void OnStartAnimation(HollywoodProjectVisual.StatePosition arg1, HollywoodProjectVisual.StatePosition arg2)
		{
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0x7C12D8", Offset = "0x7C12D8", VA = "0x7C12D8")]
		private void OnMiddleAnimation(HollywoodProjectVisual.StatePosition cur, HollywoodProjectVisual.StatePosition next)
		{
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0x7C1330", Offset = "0x7C1330", VA = "0x7C1330")]
		private void OnEndAnimation(HollywoodProjectVisual.StatePosition pos)
		{
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0x7C1334", Offset = "0x7C1334", VA = "0x7C1334")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0x7C155C", Offset = "0x7C155C", VA = "0x7C155C")]
		public FadeInOutOnProjectInOut()
		{
		}
	}
	[Token(Token = "0x20000EA")]
	public class FadeInOutOnProjectInOutUseFadeBase : MonoBehaviour
	{
		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private HollywoodProjectVisual _hollywoodProjectVisual;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FadeBase _fadeUi;

		[Token(Token = "0x600062A")]
		[Address(RVA = "0x7C1564", Offset = "0x7C1564", VA = "0x7C1564")]
		private void Awake()
		{
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0x7C15D4", Offset = "0x7C15D4", VA = "0x7C15D4")]
		private void FadeOutStart()
		{
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0x7C1670", Offset = "0x7C1670", VA = "0x7C1670")]
		private void FadeInStart()
		{
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0x7C170C", Offset = "0x7C170C", VA = "0x7C170C")]
		private void Start()
		{
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0x7C17CC", Offset = "0x7C17CC", VA = "0x7C17CC")]
		private void OnMiddleAnimation(HollywoodProjectVisual.StatePosition cur, HollywoodProjectVisual.StatePosition next)
		{
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0x7C1838", Offset = "0x7C1838", VA = "0x7C1838")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0x7C1930", Offset = "0x7C1930", VA = "0x7C1930")]
		public FadeInOutOnProjectInOutUseFadeBase()
		{
		}
	}
	[Token(Token = "0x20000EB")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5FABD4", Offset = "0x5FABD4")]
	public class FadeMeshRenderer : FadeBase
	{
		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Renderer _renderer;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private MaterialPropertyBlock _materialPropertyBlock;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int Color;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Color defColor;

		[Token(Token = "0x6000631")]
		[Address(RVA = "0x7C1938", Offset = "0x7C1938", VA = "0x7C1938")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0x7C1A18", Offset = "0x7C1A18", VA = "0x7C1A18", Slot = "6")]
		protected override void FadePerFrame(float progress, Status status)
		{
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0x7C1B84", Offset = "0x7C1B84", VA = "0x7C1B84")]
		public FadeMeshRenderer()
		{
		}
	}
	[Token(Token = "0x20000EC")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5FAC38", Offset = "0x5FAC38")]
	public class FadeRawImage : FadeBase
	{
		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private RawImage _image;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Color _startColor;

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x7C1BF0", Offset = "0x7C1BF0", VA = "0x7C1BF0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x7C1C68", Offset = "0x7C1C68", VA = "0x7C1C68", Slot = "6")]
		protected override void FadePerFrame(float progress, Status status)
		{
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x7C1D64", Offset = "0x7C1D64", VA = "0x7C1D64")]
		public FadeRawImage()
		{
		}
	}
	[Token(Token = "0x20000ED")]
	public class FadeScriptDeactivate : FadeBase
	{
		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MonoBehaviour script;

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x7C1D6C", Offset = "0x7C1D6C", VA = "0x7C1D6C", Slot = "6")]
		protected override void FadePerFrame(float progress, Status status)
		{
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0x7C1DBC", Offset = "0x7C1DBC", VA = "0x7C1DBC")]
		public FadeScriptDeactivate()
		{
		}
	}
	[Token(Token = "0x20000EE")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5FAC9C", Offset = "0x5FAC9C")]
	public class FadeSprite : FadeBase
	{
		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private SpriteRenderer _sprite;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Color _startColor;

		[Token(Token = "0x600063A")]
		[Address(RVA = "0x7C1DC4", Offset = "0x7C1DC4", VA = "0x7C1DC4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0x7C1E6C", Offset = "0x7C1E6C", VA = "0x7C1E6C", Slot = "6")]
		protected override void FadePerFrame(float progress, Status status)
		{
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0x7C1F60", Offset = "0x7C1F60", VA = "0x7C1F60")]
		public FadeSprite()
		{
		}
	}
	[Token(Token = "0x20000EF")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5FAD00", Offset = "0x5FAD00")]
	public class FadeTMPUI : FadeBase
	{
		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TextMeshProUGUI _tmpGui;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _startColor;

		[Token(Token = "0x600063D")]
		[Address(RVA = "0x7C1F68", Offset = "0x7C1F68", VA = "0x7C1F68")]
		private void Awake()
		{
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x7C1FDC", Offset = "0x7C1FDC", VA = "0x7C1FDC")]
		public void ResetColor()
		{
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x7C200C", Offset = "0x7C200C", VA = "0x7C200C", Slot = "6")]
		protected override void FadePerFrame(float progress, Status status)
		{
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0x7C2108", Offset = "0x7C2108", VA = "0x7C2108")]
		public FadeTMPUI()
		{
		}
	}
	[Token(Token = "0x20000F0")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5FAD64", Offset = "0x5FAD64")]
	public class FadeText : FadeBase
	{
		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Text _tmpGui;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Color _startColor;

		[Token(Token = "0x6000641")]
		[Address(RVA = "0x7C213C", Offset = "0x7C213C", VA = "0x7C213C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0x7C21B4", Offset = "0x7C21B4", VA = "0x7C21B4")]
		public void ResetColor()
		{
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x7C21E4", Offset = "0x7C21E4", VA = "0x7C21E4", Slot = "6")]
		protected override void FadePerFrame(float progress, Status status)
		{
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x7C2330", Offset = "0x7C2330", VA = "0x7C2330")]
		public FadeText()
		{
		}
	}
	[Token(Token = "0x20000F1")]
	public class FadeTextColor : FadeBase
	{
		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _tmpGui;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _currentColor;

		[Token(Token = "0x6000645")]
		[Address(RVA = "0x7C2364", Offset = "0x7C2364", VA = "0x7C2364", Slot = "6")]
		protected override void FadePerFrame(float progress, Status status)
		{
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0x7C2460", Offset = "0x7C2460", VA = "0x7C2460")]
		public FadeTextColor()
		{
		}
	}
	[Token(Token = "0x20000F2")]
	public interface IFadeUi
	{
		[Token(Token = "0x6000647")]
		void FadeIn(float fadeTime);

		[Token(Token = "0x6000648")]
		void FadeOut(float fadeTime);
	}
	[Token(Token = "0x20000F3")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5FADC8", Offset = "0x5FADC8")]
	public class OnMiddleAnimationFade : MonoBehaviour
	{
		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private FadeBase _fadeBase;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private HollywoodProjectVisual _hollywoodProjectVisual;

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x7C6118", Offset = "0x7C6118", VA = "0x7C6118")]
		private void Awake()
		{
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x7C6188", Offset = "0x7C6188", VA = "0x7C6188")]
		private void Start()
		{
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x7C6248", Offset = "0x7C6248", VA = "0x7C6248")]
		private void OnMiddleAnimation(HollywoodProjectVisual.StatePosition prev, HollywoodProjectVisual.StatePosition next)
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x7C62A4", Offset = "0x7C62A4", VA = "0x7C62A4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x7C6368", Offset = "0x7C6368", VA = "0x7C6368")]
		public OnMiddleAnimationFade()
		{
		}
	}
	[Token(Token = "0x20000F4")]
	public class HollywoodProjectVisual : MonoBehaviour
	{
		[Token(Token = "0x200019B")]
		public enum StatePosition
		{
			[Token(Token = "0x400079A")]
			LeftOut = 1,
			[Token(Token = "0x400079B")]
			Left2,
			[Token(Token = "0x400079C")]
			Left1,
			[Token(Token = "0x400079D")]
			Middle,
			[Token(Token = "0x400079E")]
			Right1,
			[Token(Token = "0x400079F")]
			Right2,
			[Token(Token = "0x40007A0")]
			RightOut
		}

		[Token(Token = "0x200019C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB374", Offset = "0x5FB374")]
		private sealed class <RotateBack>d__56 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public HollywoodProjectVisual <>4__this;

			[Token(Token = "0x40007A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <countTime>5__2;

			[Token(Token = "0x40007A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private bool <isMiddle>5__3;

			[Token(Token = "0x40007A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Quaternion <to>5__4;

			[Token(Token = "0x170000FC")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009EA")]
				[Address(RVA = "0x7C4630", Offset = "0x7C4630", VA = "0x7C4630", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000FD")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009EC")]
				[Address(RVA = "0x7C4698", Offset = "0x7C4698", VA = "0x7C4698", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009E7")]
			[Address(RVA = "0x7C28B0", Offset = "0x7C28B0", VA = "0x7C28B0")]
			[DebuggerHidden]
			public <RotateBack>d__56(int <>1__state)
			{
			}

			[Token(Token = "0x60009E8")]
			[Address(RVA = "0x7C4478", Offset = "0x7C4478", VA = "0x7C4478", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009E9")]
			[Address(RVA = "0x7C447C", Offset = "0x7C447C", VA = "0x7C447C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009EB")]
			[Address(RVA = "0x7C4638", Offset = "0x7C4638", VA = "0x7C4638", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200019D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB384", Offset = "0x5FB384")]
		private sealed class <RotateFront>d__57 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public HollywoodProjectVisual <>4__this;

			[Token(Token = "0x40007AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <countTime>5__2;

			[Token(Token = "0x40007AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private bool <isMiddle>5__3;

			[Token(Token = "0x40007AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Quaternion <to>5__4;

			[Token(Token = "0x170000FE")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009F0")]
				[Address(RVA = "0x7C4898", Offset = "0x7C4898", VA = "0x7C4898", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000FF")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009F2")]
				[Address(RVA = "0x7C4900", Offset = "0x7C4900", VA = "0x7C4900", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009ED")]
			[Address(RVA = "0x7C28DC", Offset = "0x7C28DC", VA = "0x7C28DC")]
			[DebuggerHidden]
			public <RotateFront>d__57(int <>1__state)
			{
			}

			[Token(Token = "0x60009EE")]
			[Address(RVA = "0x7C46A0", Offset = "0x7C46A0", VA = "0x7C46A0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009EF")]
			[Address(RVA = "0x7C46A4", Offset = "0x7C46A4", VA = "0x7C46A4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009F1")]
			[Address(RVA = "0x7C48A0", Offset = "0x7C48A0", VA = "0x7C48A0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200019E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB394", Offset = "0x5FB394")]
		private sealed class <MoveToNewWorldPos>d__69 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public HollywoodProjectVisual <>4__this;

			[Token(Token = "0x40007B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public StatePosition nextPos;

			[Token(Token = "0x40007B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Transform tran;

			[Token(Token = "0x40007B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Vector3 <worldStartPos>5__2;

			[Token(Token = "0x40007B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private Quaternion <worldStartRotation>5__3;

			[Token(Token = "0x40007B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 <worldEndPos>5__4;

			[Token(Token = "0x40007B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Quaternion <worldEndRotation>5__5;

			[Token(Token = "0x40007B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private float <countTime>5__6;

			[Token(Token = "0x40007B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private bool <isMiddle>5__7;

			[Token(Token = "0x17000100")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009F6")]
				[Address(RVA = "0x7C4408", Offset = "0x7C4408", VA = "0x7C4408", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000101")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009F8")]
				[Address(RVA = "0x7C4470", Offset = "0x7C4470", VA = "0x7C4470", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009F3")]
			[Address(RVA = "0x7C3D54", Offset = "0x7C3D54", VA = "0x7C3D54")]
			[DebuggerHidden]
			public <MoveToNewWorldPos>d__69(int <>1__state)
			{
			}

			[Token(Token = "0x60009F4")]
			[Address(RVA = "0x7C410C", Offset = "0x7C410C", VA = "0x7C410C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009F5")]
			[Address(RVA = "0x7C4110", Offset = "0x7C4110", VA = "0x7C4110", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009F7")]
			[Address(RVA = "0x7C4410", Offset = "0x7C4410", VA = "0x7C4410", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool isLocked;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text projectName;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text projectNameThick;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text projectDescription;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Renderer projectNoBlur;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5FCE48", Offset = "0x5FCE48")]
		[SerializeField]
		private Material blurMaterial;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Renderer[] setBlurTextureToRenderers;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5FCEA4", Offset = "0x5FCEA4")]
		[SerializeField]
		private GameObject frontPage;

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject backPage;

		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject lockedPage;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private BottomPanel buttonsPage;

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x5FCF20", Offset = "0x5FCF20")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5FCF20", Offset = "0x5FCF20")]
		[SerializeField]
		private GameObject bufferingPage;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5FCF90", Offset = "0x5FCF90")]
		public StatePosition statePos;

		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private AppManager.MeditationProgram meditationProgram;

		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private HollywoodProjectsManager _hollywoodProjectsManager;

		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private string _projectId;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private App.ProjectMetadata _projectMetadata;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool _isBackSade;

		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Texture2D _projectTexture2D;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Texture _project360Image;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private RenderTexture blurTexture;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Action<StatePosition, StatePosition> OnStartAnimation;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Action<StatePosition, StatePosition> OnMiddleAnimation;

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public Action<StatePosition> OnEndAnimation;

		[Token(Token = "0x400052C")]
		public const float RotationMoveTime = 0.5f;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FCFD8", Offset = "0x5FCFD8")]
		private bool <CanBeDownloaded>k__BackingField;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FCFE8", Offset = "0x5FCFE8")]
		private bool <IsVideoExist>k__BackingField;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FCFF8", Offset = "0x5FCFF8")]
		private bool <IsThumbnailExist>k__BackingField;

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FD008", Offset = "0x5FD008")]
		private bool <IsInAnimation>k__BackingField;

		[Token(Token = "0x17000086")]
		public bool CanBeDownloaded
		{
			[Token(Token = "0x600064E")]
			[Address(RVA = "0x7C25C4", Offset = "0x7C25C4", VA = "0x7C25C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FEB4C", Offset = "0x5FEB4C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600064F")]
			[Address(RVA = "0x7C25CC", Offset = "0x7C25CC", VA = "0x7C25CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FEB5C", Offset = "0x5FEB5C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000087")]
		public bool IsVideoExist
		{
			[Token(Token = "0x6000650")]
			[Address(RVA = "0x7C25D8", Offset = "0x7C25D8", VA = "0x7C25D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FEB6C", Offset = "0x5FEB6C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000651")]
			[Address(RVA = "0x7C25E0", Offset = "0x7C25E0", VA = "0x7C25E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FEB7C", Offset = "0x5FEB7C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000088")]
		public bool IsThumbnailExist
		{
			[Token(Token = "0x6000652")]
			[Address(RVA = "0x7C25EC", Offset = "0x7C25EC", VA = "0x7C25EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FEB8C", Offset = "0x5FEB8C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000653")]
			[Address(RVA = "0x7C25F4", Offset = "0x7C25F4", VA = "0x7C25F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FEB9C", Offset = "0x5FEB9C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000089")]
		public bool IsInAnimation
		{
			[Token(Token = "0x6000654")]
			[Address(RVA = "0x7C2600", Offset = "0x7C2600", VA = "0x7C2600")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FEBAC", Offset = "0x5FEBAC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000655")]
			[Address(RVA = "0x7C2608", Offset = "0x7C2608", VA = "0x7C2608")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FEBBC", Offset = "0x5FEBBC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700008A")]
		public bool IsLocked
		{
			[Token(Token = "0x6000656")]
			[Address(RVA = "0x7C2614", Offset = "0x7C2614", VA = "0x7C2614")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008B")]
		public string ProjectName
		{
			[Token(Token = "0x6000657")]
			[Address(RVA = "0x7C261C", Offset = "0x7C261C", VA = "0x7C261C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008C")]
		public string ProjectDescription
		{
			[Token(Token = "0x6000658")]
			[Address(RVA = "0x7C26B4", Offset = "0x7C26B4", VA = "0x7C26B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008D")]
		public bool IsBackSade
		{
			[Token(Token = "0x600065B")]
			[Address(RVA = "0x7C26E8", Offset = "0x7C26E8", VA = "0x7C26E8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600065C")]
			[Address(RVA = "0x7C26F0", Offset = "0x7C26F0", VA = "0x7C26F0")]
			private set
			{
			}
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x7C26D8", Offset = "0x7C26D8", VA = "0x7C26D8")]
		public Texture2D GetProjectTexture2D()
		{
			return null;
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x7C26E0", Offset = "0x7C26E0", VA = "0x7C26E0")]
		public RenderTexture GetBlurRenderTexture()
		{
			return null;
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0x7C2748", Offset = "0x7C2748", VA = "0x7C2748")]
		private void SetActiveFront()
		{
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0x7C2704", Offset = "0x7C2704", VA = "0x7C2704")]
		private void SetActiveBack()
		{
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0x7C278C", Offset = "0x7C278C", VA = "0x7C278C")]
		public void RotateToSide()
		{
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0x7C2840", Offset = "0x7C2840", VA = "0x7C2840")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5FEBCC", Offset = "0x5FEBCC")]
		private IEnumerator RotateBack()
		{
			return null;
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0x7C27D0", Offset = "0x7C27D0", VA = "0x7C27D0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5FEC30", Offset = "0x5FEC30")]
		private IEnumerator RotateFront()
		{
			return null;
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0x7C2908", Offset = "0x7C2908", VA = "0x7C2908")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0x7C2994", Offset = "0x7C2994", VA = "0x7C2994")]
		public void SetTransformImmediately(StatePosition pos, Transform parentPosRot)
		{
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0x7C2DA0", Offset = "0x7C2DA0", VA = "0x7C2DA0")]
		public void SetProjectLocked(bool isLocked)
		{
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0x7C2DAC", Offset = "0x7C2DAC", VA = "0x7C2DAC")]
		public void Init(StatePosition pos, string projectId, bool isLocked = false)
		{
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0x7BFF5C", Offset = "0x7BFF5C", VA = "0x7BFF5C")]
		public void SetActiveButtonsPage(bool active)
		{
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0x7C3244", Offset = "0x7C3244", VA = "0x7C3244")]
		public void PressButtonDownload()
		{
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0x7C327C", Offset = "0x7C327C", VA = "0x7C327C")]
		public void PressButtonMove()
		{
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0x7C3598", Offset = "0x7C3598", VA = "0x7C3598")]
		public void ChangeCard360Preview()
		{
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0x7C3688", Offset = "0x7C3688", VA = "0x7C3688")]
		public void PressButtonStreamVideo()
		{
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0x7C3B50", Offset = "0x7C3B50", VA = "0x7C3B50")]
		public void PressButtonPlayVideo()
		{
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0x7C3C68", Offset = "0x7C3C68", VA = "0x7C3C68")]
		public void MoveTo(Transform tran, StatePosition nextPosInEnd)
		{
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0x7C3CCC", Offset = "0x7C3CCC", VA = "0x7C3CCC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5FEC94", Offset = "0x5FEC94")]
		private IEnumerator MoveToNewWorldPos(Transform tran, StatePosition nextPos)
		{
			return null;
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0x7C3D80", Offset = "0x7C3D80", VA = "0x7C3D80")]
		private void OnMiddleMoveAnimation(StatePosition nextPos)
		{
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0x7C3F90", Offset = "0x7C3F90", VA = "0x7C3F90")]
		private void OnStartMoveAnimation(StatePosition nextPos)
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x7C4004", Offset = "0x7C4004", VA = "0x7C4004")]
		private void OnEndMoveAnimation(StatePosition nextPos)
		{
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0x7C2C64", Offset = "0x7C2C64", VA = "0x7C2C64")]
		private void ReEnablePages()
		{
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0x7C034C", Offset = "0x7C034C", VA = "0x7C034C")]
		public void RebuildPanels()
		{
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0x7C2BB0", Offset = "0x7C2BB0", VA = "0x7C2BB0")]
		public bool IsOutPos()
		{
			return default(bool);
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x7C40DC", Offset = "0x7C40DC", VA = "0x7C40DC")]
		public bool IsThisPosOut(StatePosition pos)
		{
			return default(bool);
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0x7C40F8", Offset = "0x7C40F8", VA = "0x7C40F8")]
		public HollywoodProjectVisual()
		{
		}
	}
	[Token(Token = "0x20000F5")]
	public class HollywoodProjectsManager : BasePage
	{
		[Token(Token = "0x200019F")]
		private enum RotationSide
		{
			[Token(Token = "0x40007B9")]
			Left,
			[Token(Token = "0x40007BA")]
			Right
		}

		[Token(Token = "0x20001A0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB3A4", Offset = "0x5FB3A4")]
		private sealed class <WaitEndRotation>d__25 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public HollywoodProjectsManager <>4__this;

			[Token(Token = "0x17000102")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009FC")]
				[Address(RVA = "0x7C5F3C", Offset = "0x7C5F3C", VA = "0x7C5F3C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000103")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009FE")]
				[Address(RVA = "0x7C5FA4", Offset = "0x7C5FA4", VA = "0x7C5FA4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009F9")]
			[Address(RVA = "0x7C53F8", Offset = "0x7C53F8", VA = "0x7C53F8")]
			[DebuggerHidden]
			public <WaitEndRotation>d__25(int <>1__state)
			{
			}

			[Token(Token = "0x60009FA")]
			[Address(RVA = "0x7C5E94", Offset = "0x7C5E94", VA = "0x7C5E94", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009FB")]
			[Address(RVA = "0x7C5E98", Offset = "0x7C5E98", VA = "0x7C5E98", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009FD")]
			[Address(RVA = "0x7C5F44", Offset = "0x7C5F44", VA = "0x7C5F44", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private HollywoodProjectVisual prefab;

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5FD028", Offset = "0x5FD028")]
		[SerializeField]
		private Transform leftOut;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform left2;

		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform left1;

		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform middle;

		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform right1;

		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform right2;

		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform rightOut;

		[Token(Token = "0x4000539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private List<HollywoodProjectVisual> hollywoodProjects;

		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool _isRotateAgaine;

		[Token(Token = "0x400053B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private RotationSide _rotationSide;

		[Token(Token = "0x400053C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int MiddleIndex;

		[Token(Token = "0x6000676")]
		[Address(RVA = "0x7C4908", Offset = "0x7C4908", VA = "0x7C4908")]
		protected new void Awake()
		{
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0x7C4978", Offset = "0x7C4978", VA = "0x7C4978")]
		private void Start()
		{
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0x7C4994", Offset = "0x7C4994", VA = "0x7C4994")]
		private void InitProjects()
		{
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0x7C4EC8", Offset = "0x7C4EC8", VA = "0x7C4EC8")]
		private void BlockUnlessContentPurchased()
		{
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0x7C4CC4", Offset = "0x7C4CC4", VA = "0x7C4CC4")]
		private void SetMiddleProjectAsLast()
		{
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0x7C5078", Offset = "0x7C5078", VA = "0x7C5078")]
		private bool isHollywoodProjectWithIndexExist(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0x7C50EC", Offset = "0x7C50EC", VA = "0x7C50EC")]
		private void checkIndexWithMiddleAndSetHollywoodProjectToPos(int index, int middleIndex)
		{
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0x7C4FAC", Offset = "0x7C4FAC", VA = "0x7C4FAC")]
		private void SetMiddleIndex(int middleIndex)
		{
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0x7C4C4C", Offset = "0x7C4C4C", VA = "0x7C4C4C")]
		private HollywoodProjectVisual.StatePosition GetTransformByIndex(int index)
		{
			return default(HollywoodProjectVisual.StatePosition);
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0x7C4C64", Offset = "0x7C4C64", VA = "0x7C4C64")]
		public Transform GetTransformByStatePos(HollywoodProjectVisual.StatePosition statePosition)
		{
			return null;
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0x7C353C", Offset = "0x7C353C", VA = "0x7C353C")]
		public Transform GetParentByStatePosition(HollywoodProjectVisual.StatePosition statePosition)
		{
			return null;
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0x7C3654", Offset = "0x7C3654", VA = "0x7C3654")]
		public void RotateToProject(HollywoodProjectVisual hollywoodProjectVisual)
		{
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0x7C5388", Offset = "0x7C5388", VA = "0x7C5388")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5FECF8", Offset = "0x5FECF8")]
		private IEnumerator WaitEndRotation()
		{
			return null;
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0x7C5424", Offset = "0x7C5424", VA = "0x7C5424")]
		private void RotateCircleAgain()
		{
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0x7C5314", Offset = "0x7C5314", VA = "0x7C5314")]
		private void RotateCircle(int rotateCount)
		{
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0x7C5444", Offset = "0x7C5444", VA = "0x7C5444")]
		private void RotateToRight()
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0x7C5954", Offset = "0x7C5954", VA = "0x7C5954")]
		private void FindMiddleIndexByState()
		{
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0x7C588C", Offset = "0x7C588C", VA = "0x7C588C")]
		private HollywoodProjectVisual.StatePosition GetRightStatePosition(HollywoodProjectVisual.StatePosition statePosition)
		{
			return default(HollywoodProjectVisual.StatePosition);
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0x7C5A1C", Offset = "0x7C5A1C", VA = "0x7C5A1C")]
		private HollywoodProjectVisual.StatePosition GetLeftStatePosition(HollywoodProjectVisual.StatePosition statePosition)
		{
			return default(HollywoodProjectVisual.StatePosition);
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0x7C55B4", Offset = "0x7C55B4", VA = "0x7C55B4")]
		private void RotateToLeft()
		{
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0x7C5720", Offset = "0x7C5720", VA = "0x7C5720")]
		private List<HollywoodProjectVisual> GetMoveProjectsRight()
		{
			return null;
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0x7C5A28", Offset = "0x7C5A28", VA = "0x7C5A28")]
		private List<HollywoodProjectVisual> GetMoveProjectsLeft()
		{
			return null;
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0x7C5B94", Offset = "0x7C5B94", VA = "0x7C5B94")]
		private HollywoodProjectVisual GetLastLeftOut()
		{
			return null;
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0x7C5C9C", Offset = "0x7C5C9C", VA = "0x7C5C9C")]
		private HollywoodProjectVisual GetLastRightOut()
		{
			return null;
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0x7C5DA8", Offset = "0x7C5DA8", VA = "0x7C5DA8")]
		private void RotationEnd()
		{
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0x7C5E38", Offset = "0x7C5E38", VA = "0x7C5E38")]
		public HollywoodProjectsManager()
		{
		}
	}
	[Token(Token = "0x20000F6")]
	public class FadeBaseUiOnEnableFadeIn : MonoBehaviour
	{
		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool useDefaultFadeTime;

		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float notDefaultFadeTime;

		[Token(Token = "0x6000691")]
		[Address(RVA = "0x7C068C", Offset = "0x7C068C", VA = "0x7C068C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0x7C0750", Offset = "0x7C0750", VA = "0x7C0750")]
		public FadeBaseUiOnEnableFadeIn()
		{
		}
	}
	[Token(Token = "0x20000F7")]
	public class IFadeUiOnEnableFadeIn : MonoBehaviour
	{
		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool useDefaultFadeTime;

		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float notDefaultFadeTime;

		[Token(Token = "0x6000693")]
		[Address(RVA = "0x7C5FAC", Offset = "0x7C5FAC", VA = "0x7C5FAC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0x7C6100", Offset = "0x7C6100", VA = "0x7C6100")]
		public IFadeUiOnEnableFadeIn()
		{
		}
	}
}
namespace HeadjackTemplate.UI.Menu.Page.Projects.Hollywood.ProjectVisual
{
	[Token(Token = "0x20000F8")]
	public class Back : MonoBehaviour
	{
		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject buttonDelete;

		[Token(Token = "0x6000695")]
		[Address(RVA = "0x7C6370", Offset = "0x7C6370", VA = "0x7C6370")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0x7C6400", Offset = "0x7C6400", VA = "0x7C6400")]
		public void PressButtonDeleteVideo()
		{
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0x7C64F4", Offset = "0x7C64F4", VA = "0x7C64F4")]
		public Back()
		{
		}
	}
	[Token(Token = "0x20000F9")]
	public class BottomPanel : MonoBehaviour, IFadeUi
	{
		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private FadeBase[] fadeBases;

		[Token(Token = "0x6000698")]
		[Address(RVA = "0x7C64FC", Offset = "0x7C64FC", VA = "0x7C64FC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0x7C2BD0", Offset = "0x7C2BD0", VA = "0x7C2BD0", Slot = "4")]
		public void FadeIn(float fadeTime = 0.25f)
		{
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0x7C3EFC", Offset = "0x7C3EFC", VA = "0x7C3EFC", Slot = "5")]
		public void FadeOut(float fadeTime = 0.25f)
		{
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0x7C6554", Offset = "0x7C6554", VA = "0x7C6554")]
		public BottomPanel()
		{
		}
	}
	[Token(Token = "0x20000FA")]
	public class Locked : MonoBehaviour
	{
		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text textUnlock;

		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Renderer rend;

		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private HollywoodProjectVisual _hollywoodProjectVisual;

		[Token(Token = "0x600069C")]
		[Address(RVA = "0x7C655C", Offset = "0x7C655C", VA = "0x7C655C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0x7C6608", Offset = "0x7C6608", VA = "0x7C6608")]
		private void Start()
		{
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0x7C6754", Offset = "0x7C6754", VA = "0x7C6754")]
		private void OnMiddleAnimation(HollywoodProjectVisual.StatePosition cur, HollywoodProjectVisual.StatePosition next)
		{
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0x7C6794", Offset = "0x7C6794", VA = "0x7C6794")]
		private void OnEndAnimation(HollywoodProjectVisual.StatePosition pos)
		{
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x7C67D4", Offset = "0x7C67D4", VA = "0x7C67D4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x7C6964", Offset = "0x7C6964", VA = "0x7C6964")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x7C6A04", Offset = "0x7C6A04", VA = "0x7C6A04")]
		public Locked()
		{
		}
	}
	[Token(Token = "0x20000FB")]
	public class PlayOrDownload : MonoBehaviour
	{
		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private HollywoodProjectVisual hollywoodProjectVisual;

		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject buttonPlay;

		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject buttonCancel;

		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject buttonDownload;

		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject buttonDelete;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ProgressBar progressBar;

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x7C6A0C", Offset = "0x7C6A0C", VA = "0x7C6A0C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x7C6A14", Offset = "0x7C6A14", VA = "0x7C6A14")]
		private void Start()
		{
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x7C6A18", Offset = "0x7C6A18", VA = "0x7C6A18")]
		private void EnablePlayButtonAndDelete()
		{
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x7C6A84", Offset = "0x7C6A84", VA = "0x7C6A84")]
		private void EnableDownloadButtonAndStream()
		{
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x7C6B08", Offset = "0x7C6B08", VA = "0x7C6B08")]
		private void EnableProgress()
		{
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x7C6B74", Offset = "0x7C6B74", VA = "0x7C6B74")]
		private void EnableButtons()
		{
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x7C6A10", Offset = "0x7C6A10", VA = "0x7C6A10")]
		public void UpdateButtons()
		{
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x7C6C24", Offset = "0x7C6C24", VA = "0x7C6C24")]
		private void SetProgressBar()
		{
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x7C6C9C", Offset = "0x7C6C9C", VA = "0x7C6C9C")]
		public void PressButtonDownload()
		{
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x7C6E60", Offset = "0x7C6E60", VA = "0x7C6E60")]
		private bool AvailableSpace()
		{
			return default(bool);
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x7C7120", Offset = "0x7C7120", VA = "0x7C7120")]
		public void PressButtonCancelDownloading()
		{
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x7C71D0", Offset = "0x7C71D0", VA = "0x7C71D0")]
		public void PressButtonDelete()
		{
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x7C72E0", Offset = "0x7C72E0", VA = "0x7C72E0")]
		public PlayOrDownload()
		{
		}
	}
}
namespace HeadjackTemplate.UI.Menu.Page.Projects.Hollywood.Animation
{
	[Token(Token = "0x20000FC")]
	public class BufferingAriseAnimation : MonoBehaviour
	{
		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float ariseTime;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private FadeBase fade;

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x7BF8AC", Offset = "0x7BF8AC", VA = "0x7BF8AC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x7BF944", Offset = "0x7BF944", VA = "0x7BF944")]
		public BufferingAriseAnimation()
		{
		}
	}
}
namespace HeadjackTemplate.Activations
{
	[Token(Token = "0x20000FD")]
	public class TestCategory : MonoBehaviour
	{
		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x7F5264", Offset = "0x7F5264", VA = "0x7F5264")]
		private void Start()
		{
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x7F5308", Offset = "0x7F5308", VA = "0x7F5308")]
		private void OnInitEnd(bool b, string s)
		{
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x7F562C", Offset = "0x7F562C", VA = "0x7F562C")]
		public TestCategory()
		{
		}
	}
	[Token(Token = "0x20000FE")]
	public class AntiAliasing : MonoBehaviour
	{
		[Token(Token = "0x20001A1")]
		public enum Aliasing
		{
			[Token(Token = "0x40007BF")]
			A_0 = 0,
			[Token(Token = "0x40007C0")]
			A_2 = 2,
			[Token(Token = "0x40007C1")]
			A_4 = 4,
			[Token(Token = "0x40007C2")]
			A_8 = 8
		}

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Aliasing aliasingOnEnable;

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<AntiAliasing> _list;

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x7F49C4", Offset = "0x7F49C4", VA = "0x7F49C4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x7F4A54", Offset = "0x7F4A54", VA = "0x7F4A54")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x7F4B08", Offset = "0x7F4B08", VA = "0x7F4B08")]
		public AntiAliasing()
		{
		}
	}
	[Token(Token = "0x20000FF")]
	public class HeadjackCategotys
	{
		[Token(Token = "0x20001A2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB3B4", Offset = "0x5FB3B4")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x40007C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AppManager.MeditationProgram category;

			[Token(Token = "0x60009FF")]
			[Address(RVA = "0x7F4E04", Offset = "0x7F4E04", VA = "0x7F4E04")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6000A00")]
			[Address(RVA = "0x7F4E0C", Offset = "0x7F4E0C", VA = "0x7F4E0C")]
			internal bool <GetProjectIDsByCategoty>b__0(App.CategoryMetadata c)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<App.CategoryMetadata> categoryMetadata;

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x7F4B8C", Offset = "0x7F4B8C", VA = "0x7F4B8C")]
		public HeadjackCategotys(string[] allCategorys)
		{
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x7F4CB0", Offset = "0x7F4CB0", VA = "0x7F4CB0")]
		public string[] GetProjectIDsByCategoty(AppManager.MeditationProgram category)
		{
			return null;
		}
	}
	[Token(Token = "0x2000100")]
	public class MeshFadeDisable : MonoBehaviour
	{
		[Token(Token = "0x20001A3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB3C4", Offset = "0x5FB3C4")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x40007C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action callBack;

			[Token(Token = "0x40007C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MeshFadeDisable <>4__this;

			[Token(Token = "0x6000A01")]
			[Address(RVA = "0x7F5028", Offset = "0x7F5028", VA = "0x7F5028")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x6000A02")]
			[Address(RVA = "0x7F50E8", Offset = "0x7F50E8", VA = "0x7F50E8")]
			internal void <StartFade>b__0()
			{
			}
		}

		[Token(Token = "0x20001A4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB3D4", Offset = "0x5FB3D4")]
		private sealed class <waitTime>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MeshFadeDisable <>4__this;

			[Token(Token = "0x40007C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action callBack;

			[Token(Token = "0x17000104")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A06")]
				[Address(RVA = "0x7F51F4", Offset = "0x7F51F4", VA = "0x7F51F4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000105")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A08")]
				[Address(RVA = "0x7F525C", Offset = "0x7F525C", VA = "0x7F525C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A03")]
			[Address(RVA = "0x7F50AC", Offset = "0x7F50AC", VA = "0x7F50AC")]
			[DebuggerHidden]
			public <waitTime>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000A04")]
			[Address(RVA = "0x7F5134", Offset = "0x7F5134", VA = "0x7F5134", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A05")]
			[Address(RVA = "0x7F5138", Offset = "0x7F5138", VA = "0x7F5138", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A07")]
			[Address(RVA = "0x7F51FC", Offset = "0x7F51FC", VA = "0x7F51FC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float FadeTime;

		[Token(Token = "0x4000552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FadeBase _fade;

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x7F4EB4", Offset = "0x7F4EB4", VA = "0x7F4EB4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x7F4F0C", Offset = "0x7F4F0C", VA = "0x7F4F0C")]
		public void StartFade([Optional] Action callBack)
		{
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x7F5030", Offset = "0x7F5030", VA = "0x7F5030")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5FED5C", Offset = "0x5FED5C")]
		private IEnumerator waitTime(Action callBack)
		{
			return null;
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x7F50D8", Offset = "0x7F50D8", VA = "0x7F50D8")]
		public MeshFadeDisable()
		{
		}
	}
	[Token(Token = "0x2000101")]
	public class VRInputMotionControllerLaser : MonoBehaviour
	{
		[Token(Token = "0x4000553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5FD184", Offset = "0x5FD184")]
		[SerializeField]
		private bool isActive;

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x7F5634", Offset = "0x7F5634", VA = "0x7F5634")]
		private void Start()
		{
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x7F56A4", Offset = "0x7F56A4", VA = "0x7F56A4")]
		public VRInputMotionControllerLaser()
		{
		}
	}
}
namespace VideoLoop
{
	[Token(Token = "0x2000102")]
	public class LoopTest : MonoBehaviour
	{
		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SpatDecoderFile videoPlayer;

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x1077F70", Offset = "0x1077F70", VA = "0x1077F70")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x107800C", Offset = "0x107800C", VA = "0x107800C")]
		private void Start()
		{
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x10780B0", Offset = "0x10780B0", VA = "0x10780B0")]
		public LoopTest()
		{
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x10780B8", Offset = "0x10780B8", VA = "0x10780B8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FEDC0", Offset = "0x5FEDC0")]
		private void <Start>b__2_0(bool b, string e)
		{
		}
	}
}
namespace Headjack
{
	[Token(Token = "0x2000103")]
	public class CurvedUI : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20001A5")]
		public class UIElement
		{
			[Token(Token = "0x40007CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Graphic graphic;

			[Token(Token = "0x40007CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Mesh mesh;

			[Token(Token = "0x6000A09")]
			[Address(RVA = "0x7EE348", Offset = "0x7EE348", VA = "0x7EE348")]
			public UIElement(Graphic _graphic, Mesh _mesh)
			{
			}
		}

		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<UIElement> uiElements;

		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<Graphic, Mesh> uiElementsDictionary;

		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Shader tmproShader;

		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Shader tmproShaderNoFade;

		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int facetsPerMeter;

		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public MeshCollider meshCollider;

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x7ECE38", Offset = "0x7ECE38", VA = "0x7ECE38")]
		public void Initialize()
		{
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x7EDC68", Offset = "0x7EDC68", VA = "0x7EDC68")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x7ECFD8", Offset = "0x7ECFD8", VA = "0x7ECFD8")]
		public void ScanForGraphics(Transform parent)
		{
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x7EE380", Offset = "0x7EE380", VA = "0x7EE380")]
		public void SetMeshColor(Graphic graphic, Color color)
		{
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x7EE47C", Offset = "0x7EE47C", VA = "0x7EE47C")]
		public Mesh GetMesh(Graphic graphic)
		{
			return null;
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x7EDD50", Offset = "0x7EDD50", VA = "0x7EDD50")]
		public Mesh GeneratePlane(int xRes, int yRes, Vector2 scale, Vector2 pivot, Color color)
		{
			return null;
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x7ED6E4", Offset = "0x7ED6E4", VA = "0x7ED6E4")]
		public Mesh GenerateCurved(Canvas canvas, int subdivisions, float depth)
		{
			return null;
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x7EE4E4", Offset = "0x7EE4E4", VA = "0x7EE4E4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x7EE544", Offset = "0x7EE544", VA = "0x7EE544")]
		public CurvedUI()
		{
		}
	}
	[Token(Token = "0x2000104")]
	public class TrackedController : MonoBehaviour
	{
		[Token(Token = "0x20001A6")]
		public enum Controller
		{
			[Token(Token = "0x40007CD")]
			None = -1,
			[Token(Token = "0x40007CE")]
			OculusCV,
			[Token(Token = "0x40007CF")]
			HTCVive,
			[Token(Token = "0x40007D0")]
			Wave,
			[Token(Token = "0x40007D1")]
			OculusGo,
			[Token(Token = "0x40007D2")]
			GearVR,
			[Token(Token = "0x40007D3")]
			QuestRiftS,
			[Token(Token = "0x40007D4")]
			OculusQuest
		}

		[Serializable]
		[Token(Token = "0x20001A7")]
		public class Mapping
		{
			[Token(Token = "0x40007D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Controller controllerType;

			[Token(Token = "0x40007D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GameObject gameObject;

			[Token(Token = "0x40007D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GameObject optionalLeftController;

			[Token(Token = "0x6000A0A")]
			[Address(RVA = "0x7F0328", Offset = "0x7F0328", VA = "0x7F0328")]
			public Mapping()
			{
			}
		}

		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Controller controllerType;

		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<Mapping> mapping;

		[Token(Token = "0x400055D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool isShowControllerAuto;

		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private GameObject controller;

		[Token(Token = "0x400055F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private GameObject optionalLeft;

		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool initialized;

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x7EFDD0", Offset = "0x7EFDD0", VA = "0x7EFDD0")]
		public void Start()
		{
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x7F0060", Offset = "0x7F0060", VA = "0x7F0060")]
		private void Update()
		{
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x7EFF58", Offset = "0x7EFF58", VA = "0x7EFF58")]
		public Controller GetControllerType()
		{
			return default(Controller);
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x7F0318", Offset = "0x7F0318", VA = "0x7F0318")]
		public TrackedController()
		{
		}
	}
	[Token(Token = "0x2000105")]
	public class ImageSphere : MonoBehaviour
	{
		[Token(Token = "0x4000561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static ImageSphere instance;

		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string image360;

		[Token(Token = "0x1700008E")]
		public static ImageSphere Instance
		{
			[Token(Token = "0x60006D2")]
			[Address(RVA = "0x7EF9A4", Offset = "0x7EF9A4", VA = "0x7EF9A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x7EF9F4", Offset = "0x7EF9F4", VA = "0x7EF9F4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x7EFA48", Offset = "0x7EFA48", VA = "0x7EFA48")]
		public void Download360Image(string projectID, string projectName)
		{
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x7EFB20", Offset = "0x7EFB20", VA = "0x7EFB20")]
		private void DownloadImage(string projectId, string projectName)
		{
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x7EFD78", Offset = "0x7EFD78", VA = "0x7EFD78")]
		public ImageSphere()
		{
		}
	}
	[Token(Token = "0x2000106")]
	public class DownloadAudioVisualizer : MonoBehaviour
	{
		[Token(Token = "0x20001A8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB3E4", Offset = "0x5FB3E4")]
		private sealed class <CountAudioProgress>d__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DownloadAudioVisualizer <>4__this;

			[Token(Token = "0x40007DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private string <id>5__2;

			[Token(Token = "0x17000106")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A0E")]
				[Address(RVA = "0x7EF340", Offset = "0x7EF340", VA = "0x7EF340", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000107")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A10")]
				[Address(RVA = "0x7EF3A8", Offset = "0x7EF3A8", VA = "0x7EF3A8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A0B")]
			[Address(RVA = "0x7EEB04", Offset = "0x7EEB04", VA = "0x7EEB04")]
			[DebuggerHidden]
			public <CountAudioProgress>d__16(int <>1__state)
			{
			}

			[Token(Token = "0x6000A0C")]
			[Address(RVA = "0x7EEF14", Offset = "0x7EEF14", VA = "0x7EEF14", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A0D")]
			[Address(RVA = "0x7EEF18", Offset = "0x7EEF18", VA = "0x7EEF18", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A0F")]
			[Address(RVA = "0x7EF348", Offset = "0x7EF348", VA = "0x7EF348", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FD1E0", Offset = "0x5FD1E0")]
		private static DownloadAudioVisualizer <Instance>k__BackingField;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool isDownloadedAllAudio;

		[Token(Token = "0x4000565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FD1F0", Offset = "0x5FD1F0")]
		private bool <IsDownloadProcess>k__BackingField;

		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FD200", Offset = "0x5FD200")]
		private float <DownloadAudioProgress>k__BackingField;

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string buttonPressProjectId;

		[Token(Token = "0x1700008F")]
		public static DownloadAudioVisualizer Instance
		{
			[Token(Token = "0x60006D7")]
			[Address(RVA = "0x7EE554", Offset = "0x7EE554", VA = "0x7EE554")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FEDD0", Offset = "0x5FEDD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006D8")]
			[Address(RVA = "0x7EE5A4", Offset = "0x7EE5A4", VA = "0x7EE5A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FEDE0", Offset = "0x5FEDE0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000090")]
		public bool IsDownloadProcess
		{
			[Token(Token = "0x60006D9")]
			[Address(RVA = "0x7EE5F8", Offset = "0x7EE5F8", VA = "0x7EE5F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FEDF0", Offset = "0x5FEDF0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006DA")]
			[Address(RVA = "0x7EE600", Offset = "0x7EE600", VA = "0x7EE600")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FEE00", Offset = "0x5FEE00")]
			private set
			{
			}
		}

		[Token(Token = "0x17000091")]
		public float DownloadAudioProgress
		{
			[Token(Token = "0x60006DB")]
			[Address(RVA = "0x7EE60C", Offset = "0x7EE60C", VA = "0x7EE60C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FEE10", Offset = "0x5FEE10")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006DC")]
			[Address(RVA = "0x7EE614", Offset = "0x7EE614", VA = "0x7EE614")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FEE20", Offset = "0x5FEE20")]
			private set
			{
			}
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x7EE61C", Offset = "0x7EE61C", VA = "0x7EE61C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x7EE670", Offset = "0x7EE670", VA = "0x7EE670")]
		public void StartDownloadAudio()
		{
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x7EEA94", Offset = "0x7EEA94", VA = "0x7EEA94")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5FEE30", Offset = "0x5FEE30")]
		private IEnumerator CountAudioProgress()
		{
			return null;
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x7EEB30", Offset = "0x7EEB30", VA = "0x7EEB30")]
		private void CheckCurrentProjectAudioDownloaded()
		{
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x7EEEB4", Offset = "0x7EEEB4", VA = "0x7EEEB4")]
		public DownloadAudioVisualizer()
		{
		}
	}
	[Token(Token = "0x2000107")]
	public class WavAudioManager : MonoBehaviour, IAudio
	{
		[Token(Token = "0x20001A9")]
		public enum AudioSourceName
		{
			[Token(Token = "0x40007DD")]
			Voice,
			[Token(Token = "0x40007DE")]
			Nature,
			[Token(Token = "0x40007DF")]
			Music,
			[Token(Token = "0x40007E0")]
			Drumming
		}

		[Token(Token = "0x20001AA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB3F4", Offset = "0x5FB3F4")]
		private sealed class <WaitAndPlay>d__78 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AudioSource source;

			[Token(Token = "0x17000108")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A14")]
				[Address(RVA = "0x7F4954", Offset = "0x7F4954", VA = "0x7F4954", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000109")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A16")]
				[Address(RVA = "0x7F49BC", Offset = "0x7F49BC", VA = "0x7F49BC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A11")]
			[Address(RVA = "0x7F3A8C", Offset = "0x7F3A8C", VA = "0x7F3A8C")]
			[DebuggerHidden]
			public <WaitAndPlay>d__78(int <>1__state)
			{
			}

			[Token(Token = "0x6000A12")]
			[Address(RVA = "0x7F4840", Offset = "0x7F4840", VA = "0x7F4840", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A13")]
			[Address(RVA = "0x7F4844", Offset = "0x7F4844", VA = "0x7F4844", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A15")]
			[Address(RVA = "0x7F495C", Offset = "0x7F495C", VA = "0x7F495C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20001AB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB404", Offset = "0x5FB404")]
		private sealed class <PrepareAndPlayAudioClip>d__79 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AudioSource source;

			[Token(Token = "0x40007E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string fullPath;

			[Token(Token = "0x40007E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UnityWebRequest <www>5__2;

			[Token(Token = "0x1700010A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A1B")]
				[Address(RVA = "0x7F4150", Offset = "0x7F4150", VA = "0x7F4150", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700010B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A1D")]
				[Address(RVA = "0x7F41B8", Offset = "0x7F41B8", VA = "0x7F41B8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A17")]
			[Address(RVA = "0x7F3AB8", Offset = "0x7F3AB8", VA = "0x7F3AB8")]
			[DebuggerHidden]
			public <PrepareAndPlayAudioClip>d__79(int <>1__state)
			{
			}

			[Token(Token = "0x6000A18")]
			[Address(RVA = "0x7F3EB8", Offset = "0x7F3EB8", VA = "0x7F3EB8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A19")]
			[Address(RVA = "0x7F3F94", Offset = "0x7F3F94", VA = "0x7F3F94", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A1A")]
			[Address(RVA = "0x7F3ED4", Offset = "0x7F3ED4", VA = "0x7F3ED4")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000A1C")]
			[Address(RVA = "0x7F4158", Offset = "0x7F4158", VA = "0x7F4158", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20001AC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB414", Offset = "0x5FB414")]
		private sealed class <PrepareAudioClip>d__80 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AudioSource source;

			[Token(Token = "0x40007EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string fullPath;

			[Token(Token = "0x40007ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private string <path>5__2;

			[Token(Token = "0x40007EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UnityWebRequest <www>5__3;

			[Token(Token = "0x1700010C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A22")]
				[Address(RVA = "0x7F47D0", Offset = "0x7F47D0", VA = "0x7F47D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700010D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A24")]
				[Address(RVA = "0x7F4838", Offset = "0x7F4838", VA = "0x7F4838", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A1E")]
			[Address(RVA = "0x7F3AE4", Offset = "0x7F3AE4", VA = "0x7F3AE4")]
			[DebuggerHidden]
			public <PrepareAudioClip>d__80(int <>1__state)
			{
			}

			[Token(Token = "0x6000A1F")]
			[Address(RVA = "0x7F41C0", Offset = "0x7F41C0", VA = "0x7F41C0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A20")]
			[Address(RVA = "0x7F429C", Offset = "0x7F429C", VA = "0x7F429C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A21")]
			[Address(RVA = "0x7F41DC", Offset = "0x7F41DC", VA = "0x7F41DC")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000A23")]
			[Address(RVA = "0x7F47D8", Offset = "0x7F47D8", VA = "0x7F47D8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20001AD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB424", Offset = "0x5FB424")]
		private sealed class <>c__DisplayClass84_0
		{
			[Token(Token = "0x40007EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string fullPath;

			[Token(Token = "0x40007F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string mediaID;

			[Token(Token = "0x6000A25")]
			[Address(RVA = "0x7F3C94", Offset = "0x7F3C94", VA = "0x7F3C94")]
			public <>c__DisplayClass84_0()
			{
			}

			[Token(Token = "0x6000A26")]
			[Address(RVA = "0x7F3E34", Offset = "0x7F3E34", VA = "0x7F3E34")]
			internal void <GetAudioPath>b__0(bool success, string error)
			{
			}
		}

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FD210", Offset = "0x5FD210")]
		private static WavAudioManager <Instance>k__BackingField;

		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AudioSource voiceAudioSource;

		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioSource backgroundNatureAudioSource;

		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AudioSource backgroundMusicAudioSource;

		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AudioSource backgroundDrummingAudioSource;

		[Token(Token = "0x400056D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<string> downloadingInThatMomentMediaIds;

		[Token(Token = "0x400056E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<string> onPressButtonDownload;

		[Token(Token = "0x400056F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float _voiceVolume;

		[Token(Token = "0x4000570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float _backgroundNatureVolume;

		[Token(Token = "0x4000571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float _backgroundMusicVolume;

		[Token(Token = "0x4000572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float _backgroundDrummingVolume;

		[Token(Token = "0x4000573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool voiceOverEnd;

		[Token(Token = "0x17000092")]
		public static WavAudioManager Instance
		{
			[Token(Token = "0x60006E2")]
			[Address(RVA = "0x7F0330", Offset = "0x7F0330", VA = "0x7F0330")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FEE94", Offset = "0x5FEE94")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006E3")]
			[Address(RVA = "0x7F0398", Offset = "0x7F0398", VA = "0x7F0398")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FEEA4", Offset = "0x5FEEA4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000093")]
		public float BackgroundNatureVolume
		{
			[Token(Token = "0x60006F5")]
			[Address(RVA = "0x7F1838", Offset = "0x7F1838", VA = "0x7F1838")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006F4")]
			[Address(RVA = "0x7F177C", Offset = "0x7F177C", VA = "0x7F177C")]
			set
			{
			}
		}

		[Token(Token = "0x17000094")]
		public float BackgroundMusicVolume
		{
			[Token(Token = "0x60006F7")]
			[Address(RVA = "0x7F1974", Offset = "0x7F1974", VA = "0x7F1974")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006F6")]
			[Address(RVA = "0x7F18B8", Offset = "0x7F18B8", VA = "0x7F18B8")]
			set
			{
			}
		}

		[Token(Token = "0x17000095")]
		public float BackgroundDrummingVolume
		{
			[Token(Token = "0x60006F9")]
			[Address(RVA = "0x7F1AB0", Offset = "0x7F1AB0", VA = "0x7F1AB0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006F8")]
			[Address(RVA = "0x7F19F4", Offset = "0x7F19F4", VA = "0x7F19F4")]
			set
			{
			}
		}

		[Token(Token = "0x17000096")]
		public float VoiceVolume
		{
			[Token(Token = "0x60006FB")]
			[Address(RVA = "0x7F1BEC", Offset = "0x7F1BEC", VA = "0x7F1BEC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006FA")]
			[Address(RVA = "0x7F1B30", Offset = "0x7F1B30", VA = "0x7F1B30")]
			set
			{
			}
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x7F0404", Offset = "0x7F0404", VA = "0x7F0404")]
		public AudioSource GetVoiceSource()
		{
			return null;
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x7F0544", Offset = "0x7F0544", VA = "0x7F0544")]
		public AudioSource GetNatureSource()
		{
			return null;
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x7F054C", Offset = "0x7F054C", VA = "0x7F054C")]
		public AudioSource GetMusicSource()
		{
			return null;
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x7F0554", Offset = "0x7F0554", VA = "0x7F0554")]
		public AudioSource GetDrummingSource()
		{
			return null;
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x7F0694", Offset = "0x7F0694", VA = "0x7F0694")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x7F0920", Offset = "0x7F0920", VA = "0x7F0920")]
		private void Start()
		{
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x7F0C8C", Offset = "0x7F0C8C", VA = "0x7F0C8C")]
		private void OnVideoEnd()
		{
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x7F0CEC", Offset = "0x7F0CEC", VA = "0x7F0CEC")]
		private void OnVideoInitComplete()
		{
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x7F0E44", Offset = "0x7F0E44", VA = "0x7F0E44")]
		private void SceneManagerOnSceneLoaded(Scene arg0, LoadSceneMode arg1)
		{
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x7F0E48", Offset = "0x7F0E48", VA = "0x7F0E48")]
		private void SceneManagerOnSceneUnloaded(Scene arg0)
		{
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x7F0E4C", Offset = "0x7F0E4C", VA = "0x7F0E4C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x7F0FEC", Offset = "0x7F0FEC", VA = "0x7F0FEC")]
		public bool IsAudioAssignment(AudioSourceName audioSourceName)
		{
			return default(bool);
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x7F10D4", Offset = "0x7F10D4", VA = "0x7F10D4")]
		public void CleanSoundsMemory()
		{
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x7F11A0", Offset = "0x7F11A0", VA = "0x7F11A0")]
		private void StopDownloadingAllMedia()
		{
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x7EE7EC", Offset = "0x7EE7EC", VA = "0x7EE7EC")]
		public void DownloadAllAudios(string projectID)
		{
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x7F15AC", Offset = "0x7F15AC", VA = "0x7F15AC")]
		public void AudioPlayScheduled(double time)
		{
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x7F1C6C", Offset = "0x7F1C6C", VA = "0x7F1C6C")]
		private void SeekSetMsOne(AudioSource audioSource, double timeMs)
		{
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x7F1D7C", Offset = "0x7F1D7C", VA = "0x7F1D7C")]
		private void SeekSetMsOneVO(AudioSource audioSource, double timeMs)
		{
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x7F1F2C", Offset = "0x7F1F2C", VA = "0x7F1F2C")]
		private void SeekSetMsAll(double timeMs)
		{
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x7F1F7C", Offset = "0x7F1F7C", VA = "0x7F1F7C")]
		private void SeekAddMsOne(AudioSource audioSource, double timeMs)
		{
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0x7F20B4", Offset = "0x7F20B4", VA = "0x7F20B4")]
		private void SeekAddMsVO(AudioSource audioSource, double timeMs)
		{
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0x7F2218", Offset = "0x7F2218", VA = "0x7F2218")]
		private void SeekAddMsAll(double timeMs)
		{
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0x7F2268", Offset = "0x7F2268", VA = "0x7F2268")]
		public void DownloadAllAudios()
		{
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0x7F231C", Offset = "0x7F231C", VA = "0x7F231C")]
		public bool IsOneAudioDownloaded(AppManager.AudioVariableNames variableNames, string projectId)
		{
			return default(bool);
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0x7F24B0", Offset = "0x7F24B0", VA = "0x7F24B0")]
		private void DeleteFileIfItExist(string mediaId)
		{
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0x7F24B4", Offset = "0x7F24B4", VA = "0x7F24B4")]
		public bool IsOneAudioDownloaded(AppManager.AudioVariableNames variableNames)
		{
			return default(bool);
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0x7F0CF0", Offset = "0x7F0CF0", VA = "0x7F0CF0")]
		private void PrepareAudios()
		{
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0x7F2A98", Offset = "0x7F2A98", VA = "0x7F2A98")]
		public void PrepareAndPlayAudios()
		{
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0x7F2E20", Offset = "0x7F2E20", VA = "0x7F2E20")]
		private void StartPlayingAllAudios()
		{
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0x7F0C90", Offset = "0x7F0C90", VA = "0x7F0C90")]
		private void PauseAudios()
		{
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0x7F2F08", Offset = "0x7F2F08", VA = "0x7F2F08")]
		public float GetDownloadProgress()
		{
			return default(float);
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0x7EF1E0", Offset = "0x7EF1E0", VA = "0x7EF1E0")]
		public float GetDownloadProgress(string projectID)
		{
			return default(float);
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0x7F3148", Offset = "0x7F3148", VA = "0x7F3148")]
		public long GetDownloadBytes()
		{
			return default(long);
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0x7F32E8", Offset = "0x7F32E8", VA = "0x7F32E8")]
		public long GetTotalBytes()
		{
			return default(long);
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0x7F3424", Offset = "0x7F3424", VA = "0x7F3424")]
		private void UnPauseAudios()
		{
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0x7EECF4", Offset = "0x7EECF4", VA = "0x7EECF4")]
		public bool IsAllSetInVideoMediaDownloaded()
		{
			return default(bool);
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0x7F3480", Offset = "0x7F3480", VA = "0x7F3480")]
		public bool IsAllDownloaded()
		{
			return default(bool);
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0x7EEDA8", Offset = "0x7EEDA8", VA = "0x7EEDA8")]
		public bool IsAllSetInVideoMediaDownloaded(string projectId)
		{
			return default(bool);
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0x7F2908", Offset = "0x7F2908", VA = "0x7F2908")]
		private void SetAudioVolumesBySettings()
		{
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0x7F28B0", Offset = "0x7F28B0", VA = "0x7F28B0")]
		private void SetAudioVolumesForImplicitSettings()
		{
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0x7F2FBC", Offset = "0x7F2FBC", VA = "0x7F2FBC")]
		private List<string> GetAllNotEmptyProjectMediaIds(string projectId)
		{
			return null;
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0x7F2568", Offset = "0x7F2568", VA = "0x7F2568")]
		private void PrepareAudioVoice()
		{
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0x7F2AD8", Offset = "0x7F2AD8", VA = "0x7F2AD8")]
		private void PrepareAndPlayAudioVoice()
		{
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0x7F2640", Offset = "0x7F2640", VA = "0x7F2640")]
		private void PrepareAudioBackgroundNature()
		{
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0x7F2BB0", Offset = "0x7F2BB0", VA = "0x7F2BB0")]
		private void PrepareAndPlayAudioBackgroundNature()
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0x7F2710", Offset = "0x7F2710", VA = "0x7F2710")]
		private void PrepareAudioBackgroundMusic()
		{
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0x7F2C80", Offset = "0x7F2C80", VA = "0x7F2C80")]
		private void PrepareAndPlayAudioBackgroundMusic()
		{
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0x7F27E0", Offset = "0x7F27E0", VA = "0x7F27E0")]
		private void PrepareAudioBackgroundDrumming()
		{
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0x7F2D50", Offset = "0x7F2D50", VA = "0x7F2D50")]
		private void PrepareAndPlayAudioBackgroundDrumming()
		{
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0x7F12D0", Offset = "0x7F12D0", VA = "0x7F12D0")]
		private bool IsMediaFileEmpty(AppManager.AudioVariableNames variableNames, string projectId)
		{
			return default(bool);
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0x7F2E98", Offset = "0x7F2E98", VA = "0x7F2E98")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5FEEB4", Offset = "0x5FEEB4")]
		private IEnumerator WaitAndPlay(AudioSource source)
		{
			return null;
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0x7F3A10", Offset = "0x7F3A10", VA = "0x7F3A10")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5FEF18", Offset = "0x5FEF18")]
		private IEnumerator PrepareAndPlayAudioClip(string fullPath, AudioSource source)
		{
			return null;
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0x7F3994", Offset = "0x7F3994", VA = "0x7F3994")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5FEF7C", Offset = "0x5FEF7C")]
		private IEnumerator PrepareAudioClip(string fullPath, AudioSource source)
		{
			return null;
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0x7F146C", Offset = "0x7F146C", VA = "0x7F146C")]
		private void DownloadAudio(AppManager.AudioVariableNames audioVariableNames, string projectId)
		{
		}

		[Token(Token = "0x6000722")]
		[Address(RVA = "0x7F3B10", Offset = "0x7F3B10", VA = "0x7F3B10")]
		private void AddMediaIdToDownloadingLists(string mediaId)
		{
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0x7F3B8C", Offset = "0x7F3B8C", VA = "0x7F3B8C")]
		private void OnEndMediaDownload(bool s, string error)
		{
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0x7F383C", Offset = "0x7F383C", VA = "0x7F383C")]
		private string GetAudioPath(AppManager.AudioVariableNames audioVariableNames, string projectId)
		{
			return null;
		}

		[Token(Token = "0x6000725")]
		[Address(RVA = "0x7F1358", Offset = "0x7F1358", VA = "0x7F1358")]
		private string GetAudioID(AppManager.AudioVariableNames audioVariableName, string projectId)
		{
			return null;
		}

		[Token(Token = "0x6000726")]
		[Address(RVA = "0x7F3C9C", Offset = "0x7F3C9C", VA = "0x7F3C9C", Slot = "4")]
		public void Prepare()
		{
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0x7F3CC0", Offset = "0x7F3CC0", VA = "0x7F3CC0", Slot = "5")]
		public void StartPlaying()
		{
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0x7F3CC4", Offset = "0x7F3CC4", VA = "0x7F3CC4", Slot = "6")]
		public void Pause()
		{
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0x7F3CC8", Offset = "0x7F3CC8", VA = "0x7F3CC8", Slot = "7")]
		public void UnPause()
		{
		}

		[Token(Token = "0x600072A")]
		[Address(RVA = "0x7F3CCC", Offset = "0x7F3CCC", VA = "0x7F3CCC", Slot = "8")]
		public void SeekAddMs(float seek)
		{
		}

		[Token(Token = "0x600072B")]
		[Address(RVA = "0x7F3CD4", Offset = "0x7F3CD4", VA = "0x7F3CD4", Slot = "9")]
		public void SeekSetMs(float seek)
		{
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0x7F3CDC", Offset = "0x7F3CDC", VA = "0x7F3CDC", Slot = "10")]
		public void CancelDownload(string projectId)
		{
		}

		[Token(Token = "0x600072D")]
		[Address(RVA = "0x7F3CE0", Offset = "0x7F3CE0", VA = "0x7F3CE0", Slot = "11")]
		public bool IsDownloaded()
		{
			return default(bool);
		}

		[Token(Token = "0x600072E")]
		[Address(RVA = "0x7F3D94", Offset = "0x7F3D94", VA = "0x7F3D94")]
		public void StartDownload(string projectId)
		{
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0x7F3D98", Offset = "0x7F3D98", VA = "0x7F3D98")]
		public WavAudioManager()
		{
		}
	}
	[Token(Token = "0x2000108")]
	public class GazeInputModule : PointerInputModule
	{
		[Token(Token = "0x20001AE")]
		public enum Mode
		{
			[Token(Token = "0x40007F2")]
			Click,
			[Token(Token = "0x40007F3")]
			Gaze
		}

		[Token(Token = "0x4000574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Mode mode;

		[Token(Token = "0x4000575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5FD260", Offset = "0x5FD260")]
		public string ClickInputName;

		[Token(Token = "0x4000576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5FD298", Offset = "0x5FD298")]
		public float GazeTimeInSeconds;

		[Token(Token = "0x4000577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public RaycastResult CurrentRaycast;

		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private PointerEventData pointerEventData;

		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private GameObject currentLookAtHandler;

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float currentLookAtHandlerClickTime;

		[Token(Token = "0x6000731")]
		[Address(RVA = "0x7EF3B0", Offset = "0x7EF3B0", VA = "0x7EF3B0", Slot = "17")]
		public override void Process()
		{
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0x7EF3D4", Offset = "0x7EF3D4", VA = "0x7EF3D4")]
		private void HandleLook()
		{
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0x7EF598", Offset = "0x7EF598", VA = "0x7EF598")]
		private void HandleSelection()
		{
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0x7EF944", Offset = "0x7EF944", VA = "0x7EF944")]
		public GazeInputModule()
		{
		}
	}
}
namespace CurvedUI
{
	[Token(Token = "0x2000109")]
	public class CUI_AnimateCurvedFillOnStart : MonoBehaviour
	{
		[Token(Token = "0x6000735")]
		[Address(RVA = "0x832E00", Offset = "0x832E00", VA = "0x832E00")]
		private void Update()
		{
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0x832FB4", Offset = "0x832FB4", VA = "0x832FB4")]
		public CUI_AnimateCurvedFillOnStart()
		{
		}
	}
	[Token(Token = "0x200010A")]
	public class CUI_CameraController : MonoBehaviour
	{
		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static CUI_CameraController instance;

		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform CameraObject;

		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float rotationMargin;

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool runInEditorOnly;

		[Token(Token = "0x6000737")]
		[Address(RVA = "0x832FBC", Offset = "0x832FBC", VA = "0x832FBC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0x833010", Offset = "0x833010", VA = "0x833010")]
		public CUI_CameraController()
		{
		}
	}
	[Token(Token = "0x200010B")]
	public class CUI_ChangeValueOnHold : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool pressed;

		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool selected;

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image bg;

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color SelectedColor;

		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Color NormalColor;

		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CanvasGroup IntroCG;

		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CanvasGroup MenuCG;

		[Token(Token = "0x6000739")]
		[Address(RVA = "0x833028", Offset = "0x833028", VA = "0x833028")]
		private void Update()
		{
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0x8330AC", Offset = "0x8330AC", VA = "0x8330AC")]
		private void ChangeVal()
		{
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0x833214", Offset = "0x833214", VA = "0x833214", Slot = "4")]
		public void OnPointerEnter(PointerEventData data)
		{
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0x8332A8", Offset = "0x8332A8", VA = "0x8332A8", Slot = "5")]
		public void OnPointerExit(PointerEventData data)
		{
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0x833338", Offset = "0x833338", VA = "0x833338")]
		public CUI_ChangeValueOnHold()
		{
		}
	}
	[Token(Token = "0x200010C")]
	public class CUI_DragBetweenCanvases : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler, IDragHandler
	{
		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vector2 dragPoint;

		[Token(Token = "0x600073E")]
		[Address(RVA = "0x833340", Offset = "0x833340", VA = "0x833340", Slot = "4")]
		public void OnBeginDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0x833684", Offset = "0x833684", VA = "0x833684", Slot = "6")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0x833BA0", Offset = "0x833BA0", VA = "0x833BA0", Slot = "5")]
		public void OnEndDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0x833488", Offset = "0x833488", VA = "0x833488")]
		private void RaycastPosition(out Vector2 newPos)
		{
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0x833C0C", Offset = "0x833C0C", VA = "0x833C0C")]
		public CUI_DragBetweenCanvases()
		{
		}
	}
	[Token(Token = "0x200010D")]
	public class CUI_GunController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20001AF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB434", Offset = "0x5FB434")]
		private sealed class <>c
		{
			[Token(Token = "0x40007F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40007F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<GameObject> <>9__2_0;

			[Token(Token = "0x6000A28")]
			[Address(RVA = "0x834104", Offset = "0x834104", VA = "0x834104")]
			public <>c()
			{
			}

			[Token(Token = "0x6000A29")]
			[Address(RVA = "0x83410C", Offset = "0x83410C", VA = "0x83410C")]
			internal bool <Update>b__2_0(GameObject x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CurvedUISettings ControlledCanvas;

		[Token(Token = "0x4000588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform LaserBeamTransform;

		[Token(Token = "0x6000743")]
		[Address(RVA = "0x833C14", Offset = "0x833C14", VA = "0x833C14")]
		private void Update()
		{
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0x834098", Offset = "0x834098", VA = "0x834098")]
		public CUI_GunController()
		{
		}
	}
	[Token(Token = "0x200010E")]
	public class CUI_GunMovement : MonoBehaviour
	{
		[Token(Token = "0x4000589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CurvedUISettings mySettings;

		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform pivot;

		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float sensitivity;

		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 lastMouse;

		[Token(Token = "0x6000745")]
		[Address(RVA = "0x8341D4", Offset = "0x8341D4", VA = "0x8341D4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0x834200", Offset = "0x834200", VA = "0x834200")]
		private void Update()
		{
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0x83441C", Offset = "0x83441C", VA = "0x83441C")]
		public CUI_GunMovement()
		{
		}
	}
	[Token(Token = "0x200010F")]
	public class CUI_OrientOnCurvedSpace : MonoBehaviour
	{
		[Token(Token = "0x400058D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CurvedUISettings mySettings;

		[Token(Token = "0x6000748")]
		[Address(RVA = "0x834430", Offset = "0x834430", VA = "0x834430")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0x834488", Offset = "0x834488", VA = "0x834488")]
		private void Update()
		{
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0x834680", Offset = "0x834680", VA = "0x834680")]
		public CUI_OrientOnCurvedSpace()
		{
		}
	}
	[Token(Token = "0x2000110")]
	public class CUI_PerlinNoisePosition : MonoBehaviour
	{
		[Token(Token = "0x400058E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float samplingSpeed;

		[Token(Token = "0x400058F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector2 Range;

		[Token(Token = "0x4000590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private RectTransform rectie;

		[Token(Token = "0x600074B")]
		[Address(RVA = "0x834688", Offset = "0x834688", VA = "0x834688")]
		private void Start()
		{
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0x8346FC", Offset = "0x8346FC", VA = "0x8346FC")]
		private void Update()
		{
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0x834854", Offset = "0x834854", VA = "0x834854")]
		public CUI_PerlinNoisePosition()
		{
		}
	}
	[Token(Token = "0x2000111")]
	public class CUI_PerlinNoiseRotation : MonoBehaviour
	{
		[Token(Token = "0x4000591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float samplingSpeed;

		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float maxrotation;

		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private RectTransform rectie;

		[Token(Token = "0x600074E")]
		[Address(RVA = "0x834864", Offset = "0x834864", VA = "0x834864")]
		private void Start()
		{
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0x8348D8", Offset = "0x8348D8", VA = "0x8348D8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0x8349CC", Offset = "0x8349CC", VA = "0x8349CC")]
		public CUI_PerlinNoiseRotation()
		{
		}
	}
	[Token(Token = "0x2000112")]
	public class CUI_PickImageFromSet : MonoBehaviour
	{
		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static CUI_PickImageFromSet picked;

		[Token(Token = "0x6000751")]
		[Address(RVA = "0x8349E0", Offset = "0x8349E0", VA = "0x8349E0")]
		public void PickThis()
		{
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0x834BA4", Offset = "0x834BA4", VA = "0x834BA4")]
		public CUI_PickImageFromSet()
		{
		}
	}
	[Token(Token = "0x2000113")]
	public class CUI_RaycastToCanvas : MonoBehaviour
	{
		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CurvedUISettings mySettings;

		[Token(Token = "0x6000754")]
		[Address(RVA = "0x834BB0", Offset = "0x834BB0", VA = "0x834BB0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0x834C08", Offset = "0x834C08", VA = "0x834C08")]
		private void Update()
		{
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0x834D0C", Offset = "0x834D0C", VA = "0x834D0C")]
		public CUI_RaycastToCanvas()
		{
		}
	}
	[Token(Token = "0x2000114")]
	public class CUI_RiseChildrenOverTime : MonoBehaviour
	{
		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float current;

		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float Speed;

		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float RiseBy;

		[Token(Token = "0x6000757")]
		[Address(RVA = "0x834D14", Offset = "0x834D14", VA = "0x834D14")]
		private void Start()
		{
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0x834D18", Offset = "0x834D18", VA = "0x834D18")]
		private void Update()
		{
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0x834F10", Offset = "0x834F10", VA = "0x834F10")]
		public CUI_RiseChildrenOverTime()
		{
		}
	}
	[Token(Token = "0x2000115")]
	public class CUI_TMPChecker : MonoBehaviour
	{
		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject testMsg;

		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject enabledMsg;

		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject disabledMsg;

		[Token(Token = "0x600075A")]
		[Address(RVA = "0x834F24", Offset = "0x834F24", VA = "0x834F24")]
		private void Start()
		{
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0x834FA0", Offset = "0x834FA0", VA = "0x834FA0")]
		public CUI_TMPChecker()
		{
		}
	}
	[Token(Token = "0x2000116")]
	public class CUI_ViveButtonState : MonoBehaviour
	{
		[Token(Token = "0x20001B0")]
		private enum ViveButton
		{
			[Token(Token = "0x40007F7")]
			Trigger,
			[Token(Token = "0x40007F8")]
			TouchpadTouch,
			[Token(Token = "0x40007F9")]
			TouchpadPress,
			[Token(Token = "0x40007FA")]
			Grip,
			[Token(Token = "0x40007FB")]
			Menu
		}

		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Color ActiveColor;

		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color InActiveColor;

		[Token(Token = "0x400059E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ViveButton ShowStateFor;

		[Token(Token = "0x600075C")]
		[Address(RVA = "0x834FA8", Offset = "0x834FA8", VA = "0x834FA8")]
		public CUI_ViveButtonState()
		{
		}
	}
	[Token(Token = "0x2000117")]
	public class CUI_ViveHapticPulse : MonoBehaviour
	{
		[Token(Token = "0x400059F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float PulseStrength;

		[Token(Token = "0x600075D")]
		[Address(RVA = "0x834FEC", Offset = "0x834FEC", VA = "0x834FEC")]
		private void Start()
		{
		}

		[Token(Token = "0x600075E")]
		[Address(RVA = "0x834FF8", Offset = "0x834FF8", VA = "0x834FF8")]
		public void SetPulseStrength(float newStr)
		{
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0x83507C", Offset = "0x83507C", VA = "0x83507C")]
		public void TriggerPulse()
		{
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0x835080", Offset = "0x835080", VA = "0x835080")]
		public CUI_ViveHapticPulse()
		{
		}
	}
	[Token(Token = "0x2000118")]
	public class CUI_WorldSpaceCursorFollow : MonoBehaviour
	{
		[Token(Token = "0x40005A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CurvedUISettings mySettings;

		[Token(Token = "0x6000761")]
		[Address(RVA = "0x835088", Offset = "0x835088", VA = "0x835088")]
		private void Start()
		{
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0x8351E0", Offset = "0x8351E0", VA = "0x8351E0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0x8352B4", Offset = "0x8352B4", VA = "0x8352B4")]
		public CUI_WorldSpaceCursorFollow()
		{
		}
	}
	[Token(Token = "0x2000119")]
	public class CUI_WorldSpaceMouseMultipleCanvases : MonoBehaviour
	{
		[Token(Token = "0x40005A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<CurvedUISettings> ControlledCanvases;

		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform WorldSpaceMouse;

		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CurvedUISettings MouseCanvas;

		[Token(Token = "0x6000764")]
		[Address(RVA = "0x8352BC", Offset = "0x8352BC", VA = "0x8352BC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0x83565C", Offset = "0x83565C", VA = "0x83565C")]
		public CUI_WorldSpaceMouseMultipleCanvases()
		{
		}
	}
	[Token(Token = "0x200011A")]
	public class CUI_draggable : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler, IDragHandler
	{
		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vector2 savedVector;

		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool isDragged;

		[Token(Token = "0x6000766")]
		[Address(RVA = "0x835664", Offset = "0x835664", VA = "0x835664", Slot = "4")]
		public void OnBeginDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0x8359B0", Offset = "0x8359B0", VA = "0x8359B0", Slot = "6")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0x8359B4", Offset = "0x8359B4", VA = "0x8359B4", Slot = "5")]
		public void OnEndDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0x835A2C", Offset = "0x835A2C", VA = "0x835A2C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0x8357B4", Offset = "0x8357B4", VA = "0x8357B4")]
		private void RaycastPosition(out Vector2 newPos)
		{
		}

		[Token(Token = "0x600076B")]
		[Address(RVA = "0x835B40", Offset = "0x835B40", VA = "0x835B40")]
		public CUI_draggable()
		{
		}
	}
	[Token(Token = "0x200011B")]
	public class CUI_inventory_paralax : MonoBehaviour
	{
		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform front;

		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform back;

		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 initFG;

		[Token(Token = "0x40005A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 initBG;

		[Token(Token = "0x40005AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float change;

		[Token(Token = "0x600076C")]
		[Address(RVA = "0x835B48", Offset = "0x835B48", VA = "0x835B48")]
		private void Start()
		{
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0x835B98", Offset = "0x835B98", VA = "0x835B98")]
		private void Update()
		{
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0x835DD4", Offset = "0x835DD4", VA = "0x835DD4")]
		public CUI_inventory_paralax()
		{
		}
	}
	[Token(Token = "0x200011C")]
	public class CurvedUIEventSystem : EventSystem
	{
		[Token(Token = "0x40005AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static CurvedUIEventSystem instance;

		[Token(Token = "0x600076F")]
		[Address(RVA = "0x835DE4", Offset = "0x835DE4", VA = "0x835DE4", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0x835E44", Offset = "0x835E44", VA = "0x835E44", Slot = "17")]
		protected override void OnApplicationFocus(bool hasFocus)
		{
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0x835E50", Offset = "0x835E50", VA = "0x835E50")]
		public CurvedUIEventSystem()
		{
		}
	}
	[Token(Token = "0x200011D")]
	public static class CurvedUIExtensionMethods
	{
		[Token(Token = "0x6000772")]
		[Address(RVA = "0x835EB8", Offset = "0x835EB8", VA = "0x835EB8")]
		public static bool AlmostEqual(this Vector3 a, Vector3 b, double accuracy = 0.01)
		{
			return default(bool);
		}

		[Token(Token = "0x6000773")]
		[Address(RVA = "0x834838", Offset = "0x834838", VA = "0x834838")]
		public static float Remap(this float value, float from1, float to1, float from2, float to2)
		{
			return default(float);
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0x835F84", Offset = "0x835F84", VA = "0x835F84")]
		public static float RemapAndClamp(this float value, float from1, float to1, float from2, float to2)
		{
			return default(float);
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0x836030", Offset = "0x836030", VA = "0x836030")]
		public static float Remap(this int value, float from1, float to1, float from2, float to2)
		{
			return default(float);
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0x836050", Offset = "0x836050", VA = "0x836050")]
		public static double Remap(this double value, double from1, double to1, double from2, double to2)
		{
			return default(double);
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0x835FA8", Offset = "0x835FA8", VA = "0x835FA8")]
		public static float Clamp(this float value, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0x83606C", Offset = "0x83606C", VA = "0x83606C")]
		public static float Clamp(this int value, int min, int max)
		{
			return default(float);
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0x8360F4", Offset = "0x8360F4", VA = "0x8360F4")]
		public static int Abs(this int value)
		{
			return default(int);
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0x83615C", Offset = "0x83615C", VA = "0x83615C")]
		public static float Abs(this float value)
		{
			return default(float);
		}

		[Token(Token = "0x600077B")]
		[Address(RVA = "0x8361C8", Offset = "0x8361C8", VA = "0x8361C8")]
		public static int ToInt(this float value)
		{
			return default(int);
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0x836238", Offset = "0x836238", VA = "0x836238")]
		public static int FloorToInt(this float value)
		{
			return default(int);
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0x8362A8", Offset = "0x8362A8", VA = "0x8362A8")]
		public static int CeilToInt(this float value)
		{
			return default(int);
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0x834028", Offset = "0x834028", VA = "0x834028")]
		public static Vector3 ModifyX(this Vector3 trans, float newVal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0x834060", Offset = "0x834060", VA = "0x834060")]
		public static Vector3 ModifyY(this Vector3 trans, float newVal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0x833FF0", Offset = "0x833FF0", VA = "0x833FF0")]
		public static Vector3 ModifyZ(this Vector3 trans, float newVal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0x836318", Offset = "0x836318", VA = "0x836318")]
		public static Vector2 ModifyVectorX(this Vector2 trans, float newVal)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0x8363B8", Offset = "0x8363B8", VA = "0x8363B8")]
		public static Vector2 ModifyVectorY(this Vector2 trans, float newVal)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0x833AE0", Offset = "0x833AE0", VA = "0x833AE0")]
		public static void ResetTransform(this Transform trans)
		{
		}

		[Token(Token = "0x6000784")]
		public static T AddComponentIfMissing<T>(this GameObject go) where T : UnityEngine.Component
		{
			return null;
		}

		[Token(Token = "0x6000785")]
		public static T AddComponentIfMissing<T>(this UnityEngine.Component go) where T : UnityEngine.Component
		{
			return null;
		}
	}
	[Token(Token = "0x200011E")]
	public class CurvedUIHandSwitcher : MonoBehaviour
	{
		[Token(Token = "0x40005AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject LaserBeam;

		[Token(Token = "0x40005AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5FD460", Offset = "0x5FD460")]
		private bool autoSwitchHands;

		[Token(Token = "0x6000786")]
		[Address(RVA = "0x836458", Offset = "0x836458", VA = "0x836458")]
		private void SwitchHandTo(CurvedUIInputModule.Hand newHand)
		{
		}

		[Token(Token = "0x6000787")]
		[Address(RVA = "0x8366A0", Offset = "0x8366A0", VA = "0x8366A0")]
		public CurvedUIHandSwitcher()
		{
		}
	}
	[Token(Token = "0x200011F")]
	public class CurvedUIInputFieldCaret : MonoBehaviour, ISelectHandler, IEventSystemHandler, IDeselectHandler
	{
		[Token(Token = "0x20001B1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB444", Offset = "0x5FB444")]
		private sealed class <CaretBlinker>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CurvedUIInputFieldCaret <>4__this;

			[Token(Token = "0x1700010E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A2D")]
				[Address(RVA = "0x837310", Offset = "0x837310", VA = "0x837310", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700010F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A2F")]
				[Address(RVA = "0x837378", Offset = "0x837378", VA = "0x837378", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A2A")]
			[Address(RVA = "0x836EC8", Offset = "0x836EC8", VA = "0x836EC8")]
			[DebuggerHidden]
			public <CaretBlinker>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x6000A2B")]
			[Address(RVA = "0x8371F4", Offset = "0x8371F4", VA = "0x8371F4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A2C")]
			[Address(RVA = "0x8371F8", Offset = "0x8371F8", VA = "0x8371F8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A2E")]
			[Address(RVA = "0x837318", Offset = "0x837318", VA = "0x837318", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40005AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private InputField myField;

		[Token(Token = "0x40005AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private RectTransform myCaret;

		[Token(Token = "0x40005B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Color origCaretColor;

		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Color origSelectionColor;

		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool selected;

		[Token(Token = "0x40005B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		private bool selectingText;

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int lastCharDist;

		[Token(Token = "0x17000097")]
		public Color CaretColor
		{
			[Token(Token = "0x6000790")]
			[Address(RVA = "0x83717C", Offset = "0x83717C", VA = "0x83717C")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000791")]
			[Address(RVA = "0x837188", Offset = "0x837188", VA = "0x837188")]
			set
			{
			}
		}

		[Token(Token = "0x17000098")]
		public Color SelectionColor
		{
			[Token(Token = "0x6000792")]
			[Address(RVA = "0x837194", Offset = "0x837194", VA = "0x837194")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000793")]
			[Address(RVA = "0x8371A0", Offset = "0x8371A0", VA = "0x8371A0")]
			set
			{
			}
		}

		[Token(Token = "0x17000099")]
		public float CaretBlinkRate
		{
			[Token(Token = "0x6000794")]
			[Address(RVA = "0x8371AC", Offset = "0x8371AC", VA = "0x8371AC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000795")]
			[Address(RVA = "0x8371C8", Offset = "0x8371C8", VA = "0x8371C8")]
			set
			{
			}
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0x8366B0", Offset = "0x8366B0", VA = "0x8366B0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0x836708", Offset = "0x836708", VA = "0x836708")]
		private void Update()
		{
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0x836A48", Offset = "0x836A48", VA = "0x836A48", Slot = "4")]
		public void OnSelect(BaseEventData eventData)
		{
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0x836E90", Offset = "0x836E90", VA = "0x836E90", Slot = "5")]
		public void OnDeselect(BaseEventData eventData)
		{
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0x836E20", Offset = "0x836E20", VA = "0x836E20")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5FF120", Offset = "0x5FF120")]
		private IEnumerator CaretBlinker()
		{
			return null;
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0x836B08", Offset = "0x836B08", VA = "0x836B08")]
		private void CreateCaret()
		{
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0x836718", Offset = "0x836718", VA = "0x836718")]
		private void UpdateCaret()
		{
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0x836EF4", Offset = "0x836EF4", VA = "0x836EF4")]
		private Vector2 GetLocalPositionInText(int charNo)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0x8371E4", Offset = "0x8371E4", VA = "0x8371E4")]
		public CurvedUIInputFieldCaret()
		{
		}
	}
	[Token(Token = "0x2000120")]
	public class CurvedUILaserBeam : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20001B2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB454", Offset = "0x5FB454")]
		private sealed class <>c
		{
			[Token(Token = "0x40007FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000800")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<GameObject> <>9__4_0;

			[Token(Token = "0x6000A31")]
			[Address(RVA = "0x837814", Offset = "0x837814", VA = "0x837814")]
			public <>c()
			{
			}

			[Token(Token = "0x6000A32")]
			[Address(RVA = "0x83781C", Offset = "0x83781C", VA = "0x83781C")]
			internal bool <Update>b__4_0(GameObject x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform LaserBeamTransform;

		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform LaserBeamDot;

		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool CollideWithMyLayerOnly;

		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		[SerializeField]
		private bool hideWhenNotAimingAtCanvas;

		[Token(Token = "0x6000797")]
		[Address(RVA = "0x837380", Offset = "0x837380", VA = "0x837380")]
		protected void Update()
		{
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0x8377A8", Offset = "0x8377A8", VA = "0x8377A8")]
		public CurvedUILaserBeam()
		{
		}
	}
	[Token(Token = "0x2000121")]
	public class CurvedUIPointerEventData : PointerEventData
	{
		[Token(Token = "0x20001B3")]
		public enum ControllerType
		{
			[Token(Token = "0x4000802")]
			NONE = -1,
			[Token(Token = "0x4000803")]
			VIVE
		}

		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public GameObject Controller;

		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public Vector2 TouchPadAxis;

		[Token(Token = "0x6000799")]
		[Address(RVA = "0x837910", Offset = "0x837910", VA = "0x837910")]
		public CurvedUIPointerEventData(EventSystem eventSystem)
		{
		}
	}
	[Token(Token = "0x2000122")]
	public class CurvedUIRaycaster : GraphicRaycaster
	{
		[Serializable]
		[Token(Token = "0x20001B4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB464", Offset = "0x5FB464")]
		private sealed class <>c
		{
			[Token(Token = "0x4000804")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000805")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<GameObject> <>9__22_0;

			[Token(Token = "0x4000806")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Comparison<Graphic> <>9__33_0;

			[Token(Token = "0x4000807")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Comparison<Graphic> <>9__55_0;

			[Token(Token = "0x6000A34")]
			[Address(RVA = "0x8AE6F4", Offset = "0x8AE6F4", VA = "0x8AE6F4")]
			public <>c()
			{
			}

			[Token(Token = "0x6000A35")]
			[Address(RVA = "0x8AE6FC", Offset = "0x8AE6FC", VA = "0x8AE6FC")]
			internal bool <Update>b__22_0(GameObject obj)
			{
				return default(bool);
			}

			[Token(Token = "0x6000A36")]
			[Address(RVA = "0x8AE7C0", Offset = "0x8AE7C0", VA = "0x8AE7C0")]
			internal int <FlatRaycastAndSort>b__33_0(Graphic g1, Graphic g2)
			{
				return default(int);
			}

			[Token(Token = "0x6000A37")]
			[Address(RVA = "0x8AE818", Offset = "0x8AE818", VA = "0x8AE818")]
			internal int <GetObjectsHitByRay>b__55_0(Graphic g1, Graphic g2)
			{
				return default(int);
			}
		}

		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool showDebug;

		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		private bool overrideEventData;

		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Canvas myCanvas;

		[Token(Token = "0x40005BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private CurvedUISettings mySettings;

		[Token(Token = "0x40005BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 cyllinderMidPoint;

		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private List<GameObject> objectsUnderPointer;

		[Token(Token = "0x40005C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector2 lastCanvasPos;

		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private GameObject colliderContainer;

		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private PointerEventData lastFrameEventData;

		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private PointerEventData curEventData;

		[Token(Token = "0x40005C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private PointerEventData eventDataToUse;

		[Token(Token = "0x40005C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Camera cachedWorldCamera;

		[Token(Token = "0x40005C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Ray cachedRay;

		[Token(Token = "0x40005C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Graphic gph;

		[Token(Token = "0x40005C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private List<GameObject> selectablesUnderGaze;

		[Token(Token = "0x40005CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private List<GameObject> selectablesUnderGazeLastFrame;

		[Token(Token = "0x40005CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float objectsUnderGazeLastChangeTime;

		[Token(Token = "0x40005CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private bool gazeClickExecuted;

		[Token(Token = "0x40005CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD5")]
		private bool pointingAtCanvas;

		[Token(Token = "0x40005CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD6")]
		private bool pointingAtCanvasLastFrame;

		[NonSerialized]
		[Token(Token = "0x40005CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private List<Graphic> m_RaycastResults;

		[NonSerialized]
		[Token(Token = "0x40005D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly List<Graphic> s_SortedGraphics;

		[Token(Token = "0x1700009A")]
		private Image GazeProgressImage
		{
			[Token(Token = "0x60007AD")]
			[Address(RVA = "0x8A6D20", Offset = "0x8A6D20", VA = "0x8A6D20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009B")]
		public bool PointingAtCanvas
		{
			[Token(Token = "0x60007B5")]
			[Address(RVA = "0x8ADCE8", Offset = "0x8ADCE8", VA = "0x8ADCE8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0x8A5DB8", Offset = "0x8A5DB8", VA = "0x8A5DB8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0x8A60E4", Offset = "0x8A60E4", VA = "0x8A60E4", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0x8A6674", Offset = "0x8A6674", VA = "0x8A6674", Slot = "22")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0x8A6B70", Offset = "0x8A6B70", VA = "0x8A6B70")]
		private void ProcessGazeTimedClick()
		{
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0x8A6B44", Offset = "0x8A6B44", VA = "0x8A6B44")]
		private void ResetGazeTimedClick()
		{
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0x8A7318", Offset = "0x8A7318", VA = "0x8A7318", Slot = "17")]
		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x8A8B08", Offset = "0x8A8B08", VA = "0x8A8B08", Slot = "23")]
		public virtual bool RaycastToCyllinderCanvas(Ray ray3D, out Vector2 o_canvasPos, bool OutputInCanvasSpace = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x8A93B8", Offset = "0x8A93B8", VA = "0x8A93B8", Slot = "24")]
		public virtual bool RaycastToCyllinderVerticalCanvas(Ray ray3D, out Vector2 o_canvasPos, bool OutputInCanvasSpace = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x8A9AD0", Offset = "0x8A9AD0", VA = "0x8A9AD0", Slot = "25")]
		public virtual bool RaycastToRingCanvas(Ray ray3D, out Vector2 o_canvasPos, bool OutputInCanvasSpace = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x8AA050", Offset = "0x8AA050", VA = "0x8AA050", Slot = "26")]
		public virtual bool RaycastToSphereCanvas(Ray ray3D, out Vector2 o_canvasPos, bool OutputInCanvasSpace = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x8A8480", Offset = "0x8A8480", VA = "0x8A8480")]
		private void FlatRaycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x8AAB80", Offset = "0x8AAB80", VA = "0x8AAB80")]
		private static void FlatRaycastAndSort(Canvas canvas, Camera eventCamera, Vector2 pointerPosition, IList<Graphic> foundGraphics, List<Graphic> results)
		{
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x8A616C", Offset = "0x8A616C", VA = "0x8A616C")]
		protected void CreateCollider()
		{
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x8AC634", Offset = "0x8AC634", VA = "0x8AC634")]
		private void SetupMeshColliderUsingMesh(Mesh meshie)
		{
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x8AB038", Offset = "0x8AB038", VA = "0x8AB038")]
		private GameObject CreateConvexCyllinderCollider(bool vertical = false)
		{
			return null;
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x8ABCC4", Offset = "0x8ABCC4", VA = "0x8ABCC4")]
		private Mesh CreateCyllinderColliderMesh(bool vertical = false)
		{
			return null;
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x8AC6E4", Offset = "0x8AC6E4", VA = "0x8AC6E4")]
		private Mesh CreateSphereColliderMesh()
		{
			return null;
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x8AD248", Offset = "0x8AD248", VA = "0x8AD248")]
		private bool IsInLayerMask(int layer, LayerMask layermask)
		{
			return default(bool);
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x8A9220", Offset = "0x8A9220", VA = "0x8A9220")]
		private LayerMask GetLayerMaskForMyLayer()
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x8A9274", Offset = "0x8A9274", VA = "0x8A9274")]
		private float AngleSigned(Vector3 v1, Vector3 v2, Vector3 n)
		{
			return default(float);
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x8AD2A0", Offset = "0x8AD2A0", VA = "0x8AD2A0")]
		private bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold)
		{
			return default(bool);
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x8AD370", Offset = "0x8AD370", VA = "0x8AD370", Slot = "27")]
		protected virtual void ProcessMove(PointerEventData pointerEvent)
		{
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x8A7CE0", Offset = "0x8A7CE0", VA = "0x8A7CE0")]
		protected void UpdateSelectedObjects(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x8AD388", Offset = "0x8AD388", VA = "0x8AD388")]
		protected void HandlePointerExitAndEnter(PointerEventData currentPointerData, GameObject newEnterTarget)
		{
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x8AD9B4", Offset = "0x8AD9B4", VA = "0x8AD9B4")]
		protected static GameObject FindCommonRoot(GameObject g1, GameObject g2)
		{
			return null;
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x8ADB5C", Offset = "0x8ADB5C", VA = "0x8ADB5C")]
		private bool GetScreenSpacePointByRay(Ray ray, out Vector2 o_positionOnCanvas)
		{
			return default(bool);
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x8ADCF0", Offset = "0x8ADCF0", VA = "0x8ADCF0")]
		public void RebuildCollider()
		{
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x8ADD5C", Offset = "0x8ADD5C", VA = "0x8ADD5C")]
		public List<GameObject> GetObjectsUnderPointer()
		{
			return null;
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x8ADDD0", Offset = "0x8ADDD0", VA = "0x8ADDD0")]
		public List<GameObject> GetObjectsUnderScreenPos(Vector2 screenPos, [Optional] Camera eventCamera)
		{
			return null;
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x8ADEE0", Offset = "0x8ADEE0", VA = "0x8ADEE0")]
		public List<GameObject> GetObjectsHitByRay(Ray ray)
		{
			return null;
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x8A6D8C", Offset = "0x8A6D8C", VA = "0x8A6D8C")]
		public void Click()
		{
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x8ACEE4", Offset = "0x8ACEE4", VA = "0x8ACEE4")]
		private void ModifyQuad(List<Vector3> verts, int vertexIndex, Vector2 requiredSize)
		{
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x8AE304", Offset = "0x8AE304", VA = "0x8AE304")]
		private Vector3 TesselateQuad(List<Vector3> quad, float x, float y)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x8AE4F8", Offset = "0x8AE4F8", VA = "0x8AE4F8")]
		public CurvedUIRaycaster()
		{
		}
	}
	[Token(Token = "0x2000123")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5FAE3C", Offset = "0x5FAE3C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5FAE3C", Offset = "0x5FAE3C")]
	public class CurvedUISettings : MonoBehaviour
	{
		[Token(Token = "0x20001B5")]
		public enum CurvedUIShape
		{
			[Token(Token = "0x4000809")]
			CYLINDER,
			[Token(Token = "0x400080A")]
			RING,
			[Token(Token = "0x400080B")]
			SPHERE,
			[Token(Token = "0x400080C")]
			CYLINDER_VERTICAL
		}

		[Token(Token = "0x40005D1")]
		public const string Version = "2.8p2";

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CurvedUIShape shape;

		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float quality;

		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool interactable;

		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[SerializeField]
		private bool blocksRaycasts;

		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		[SerializeField]
		private bool raycastMyLayerOnly;

		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
		[SerializeField]
		private bool forceUseBoxCollider;

		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private int angle;

		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool preserveAspect;

		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private int vertAngle;

		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float ringFill;

		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private int ringExternalDiamater;

		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool ringFlipVertical;

		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int baseCircleSegments;

		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector2 savedRectSize;

		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float savedRadius;

		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Canvas myCanvas;

		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private RectTransform m_rectTransform;

		[Token(Token = "0x1700009C")]
		private RectTransform RectTransform
		{
			[Token(Token = "0x60007C9")]
			[Address(RVA = "0x8AE908", Offset = "0x8AE908", VA = "0x8AE908")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009D")]
		public int BaseCircleSegments
		{
			[Token(Token = "0x60007D2")]
			[Address(RVA = "0x8B0218", Offset = "0x8B0218", VA = "0x8B0218")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700009E")]
		public int Angle
		{
			[Token(Token = "0x60007D3")]
			[Address(RVA = "0x8B0220", Offset = "0x8B0220", VA = "0x8B0220")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60007D4")]
			[Address(RVA = "0x8B0228", Offset = "0x8B0228", VA = "0x8B0228")]
			set
			{
			}
		}

		[Token(Token = "0x1700009F")]
		public float Quality
		{
			[Token(Token = "0x60007D5")]
			[Address(RVA = "0x8B023C", Offset = "0x8B023C", VA = "0x8B023C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60007D6")]
			[Address(RVA = "0x8B0244", Offset = "0x8B0244", VA = "0x8B0244")]
			set
			{
			}
		}

		[Token(Token = "0x170000A0")]
		public CurvedUIShape Shape
		{
			[Token(Token = "0x60007D7")]
			[Address(RVA = "0x8B0260", Offset = "0x8B0260", VA = "0x8B0260")]
			get
			{
				return default(CurvedUIShape);
			}
			[Token(Token = "0x60007D8")]
			[Address(RVA = "0x8B0268", Offset = "0x8B0268", VA = "0x8B0268")]
			set
			{
			}
		}

		[Token(Token = "0x170000A1")]
		public int VerticalAngle
		{
			[Token(Token = "0x60007D9")]
			[Address(RVA = "0x8B0288", Offset = "0x8B0288", VA = "0x8B0288")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60007DA")]
			[Address(RVA = "0x8B0290", Offset = "0x8B0290", VA = "0x8B0290")]
			set
			{
			}
		}

		[Token(Token = "0x170000A2")]
		public float RingFill
		{
			[Token(Token = "0x60007DB")]
			[Address(RVA = "0x8B02B0", Offset = "0x8B02B0", VA = "0x8B02B0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60007DC")]
			[Address(RVA = "0x8B02B8", Offset = "0x8B02B8", VA = "0x8B02B8")]
			set
			{
			}
		}

		[Token(Token = "0x170000A3")]
		public float SavedRadius
		{
			[Token(Token = "0x60007DD")]
			[Address(RVA = "0x8AF2D4", Offset = "0x8AF2D4", VA = "0x8AF2D4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000A4")]
		public int RingExternalDiameter
		{
			[Token(Token = "0x60007DE")]
			[Address(RVA = "0x8B02D4", Offset = "0x8B02D4", VA = "0x8B02D4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60007DF")]
			[Address(RVA = "0x8B02DC", Offset = "0x8B02DC", VA = "0x8B02DC")]
			set
			{
			}
		}

		[Token(Token = "0x170000A5")]
		public bool RingFlipVertical
		{
			[Token(Token = "0x60007E0")]
			[Address(RVA = "0x8B02FC", Offset = "0x8B02FC", VA = "0x8B02FC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007E1")]
			[Address(RVA = "0x8B0304", Offset = "0x8B0304", VA = "0x8B0304")]
			set
			{
			}
		}

		[Token(Token = "0x170000A6")]
		public bool PreserveAspect
		{
			[Token(Token = "0x60007E2")]
			[Address(RVA = "0x8B0330", Offset = "0x8B0330", VA = "0x8B0330")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007E3")]
			[Address(RVA = "0x8B0338", Offset = "0x8B0338", VA = "0x8B0338")]
			set
			{
			}
		}

		[Token(Token = "0x170000A7")]
		public bool Interactable
		{
			[Token(Token = "0x60007E4")]
			[Address(RVA = "0x8B0364", Offset = "0x8B0364", VA = "0x8B0364")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007E5")]
			[Address(RVA = "0x8B036C", Offset = "0x8B036C", VA = "0x8B036C")]
			set
			{
			}
		}

		[Token(Token = "0x170000A8")]
		public bool ForceUseBoxCollider
		{
			[Token(Token = "0x60007E6")]
			[Address(RVA = "0x8B0378", Offset = "0x8B0378", VA = "0x8B0378")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007E7")]
			[Address(RVA = "0x8B0380", Offset = "0x8B0380", VA = "0x8B0380")]
			set
			{
			}
		}

		[Token(Token = "0x170000A9")]
		public bool BlocksRaycasts
		{
			[Token(Token = "0x60007E8")]
			[Address(RVA = "0x8B038C", Offset = "0x8B038C", VA = "0x8B038C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007E9")]
			[Address(RVA = "0x8B0394", Offset = "0x8B0394", VA = "0x8B0394")]
			set
			{
			}
		}

		[Token(Token = "0x170000AA")]
		public bool RaycastMyLayerOnly
		{
			[Token(Token = "0x60007EA")]
			[Address(RVA = "0x8B047C", Offset = "0x8B047C", VA = "0x8B047C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007EB")]
			[Address(RVA = "0x8B0484", Offset = "0x8B0484", VA = "0x8B0484")]
			set
			{
			}
		}

		[Token(Token = "0x170000AB")]
		public bool PointingAtCanvas
		{
			[Token(Token = "0x60007ED")]
			[Address(RVA = "0x8B054C", Offset = "0x8B054C", VA = "0x8B054C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000AC")]
		public CurvedUIInputModule.CUIControlMethod ControlMethod
		{
			[Token(Token = "0x60007EF")]
			[Address(RVA = "0x8AD958", Offset = "0x8AD958", VA = "0x8AD958")]
			get
			{
				return default(CurvedUIInputModule.CUIControlMethod);
			}
			[Token(Token = "0x60007F0")]
			[Address(RVA = "0x8B06FC", Offset = "0x8B06FC", VA = "0x8B06FC")]
			set
			{
			}
		}

		[Token(Token = "0x170000AD")]
		public bool GazeUseTimedClick
		{
			[Token(Token = "0x60007F4")]
			[Address(RVA = "0x8B0B38", Offset = "0x8B0B38", VA = "0x8B0B38")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007F5")]
			[Address(RVA = "0x8B0BA4", Offset = "0x8B0BA4", VA = "0x8B0BA4")]
			set
			{
			}
		}

		[Token(Token = "0x170000AE")]
		public float GazeClickTimer
		{
			[Token(Token = "0x60007F6")]
			[Address(RVA = "0x8B0C18", Offset = "0x8B0C18", VA = "0x8B0C18")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60007F7")]
			[Address(RVA = "0x8B0C84", Offset = "0x8B0C84", VA = "0x8B0C84")]
			set
			{
			}
		}

		[Token(Token = "0x170000AF")]
		public float GazeClickTimerDelay
		{
			[Token(Token = "0x60007F8")]
			[Address(RVA = "0x8B0D7C", Offset = "0x8B0D7C", VA = "0x8B0D7C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60007F9")]
			[Address(RVA = "0x8B0DE8", Offset = "0x8B0DE8", VA = "0x8B0DE8")]
			set
			{
			}
		}

		[Token(Token = "0x170000B0")]
		public float GazeTimerProgress
		{
			[Token(Token = "0x60007FA")]
			[Address(RVA = "0x8B0EE0", Offset = "0x8B0EE0", VA = "0x8B0EE0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x8AE870", Offset = "0x8AE870", VA = "0x8AE870")]
		private void Awake()
		{
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x8AE9B4", Offset = "0x8AE9B4", VA = "0x8AE9B4")]
		private void Start()
		{
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x8AECF8", Offset = "0x8AECF8", VA = "0x8AECF8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x8AEDA8", Offset = "0x8AEDA8", VA = "0x8AEDA8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x8AEE58", Offset = "0x8AEE58", VA = "0x8AEE58")]
		private void Update()
		{
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x8AEFAC", Offset = "0x8AEFAC", VA = "0x8AEFAC")]
		private void SetUIAngle(int newAngle)
		{
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x8AF1A4", Offset = "0x8AF1A4", VA = "0x8AF1A4")]
		private Vector3 CanvasToCyllinder(Vector3 pos)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x8AF304", Offset = "0x8AF304", VA = "0x8AF304")]
		private Vector3 CanvasToCyllinderVertical(Vector3 pos)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x8AF434", Offset = "0x8AF434", VA = "0x8AF434")]
		private Vector3 CanvasToRing(Vector3 pos)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x8AF56C", Offset = "0x8AF56C", VA = "0x8AF56C")]
		private Vector3 CanvasToSphere(Vector3 pos)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x8AF774", Offset = "0x8AF774", VA = "0x8AF774")]
		public void AddEffectToChildren()
		{
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x8AFAB4", Offset = "0x8AFAB4", VA = "0x8AFAB4")]
		public Vector3 VertexPositionToCurvedCanvas(Vector3 pos)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x8A81B4", Offset = "0x8A81B4", VA = "0x8A81B4")]
		public Vector3 CanvasToCurvedCanvas(Vector3 pos)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x8AFBE4", Offset = "0x8AFBE4", VA = "0x8AFBE4")]
		public Vector3 CanvasToCurvedCanvasNormal(Vector3 pos)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x8AFF6C", Offset = "0x8AFF6C", VA = "0x8AFF6C")]
		public bool RaycastToCanvasSpace(Ray ray, out Vector2 o_positionOnCanvas)
		{
			return default(bool);
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x8A5F68", Offset = "0x8A5F68", VA = "0x8A5F68")]
		public float GetCyllinderRadiusInCanvasSpace()
		{
			return default(float);
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x8ACCB0", Offset = "0x8ACCB0", VA = "0x8ACCB0")]
		public Vector2 GetTesslationSize(bool modifiedByQuality = true)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0x8B011C", Offset = "0x8B011C", VA = "0x8B011C")]
		private float GetSegmentsByAngle(float angle)
		{
			return default(float);
		}

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0x8B0490", Offset = "0x8B0490", VA = "0x8B0490")]
		public void SetAllChildrenDirty(bool recalculateCurveOnly = false)
		{
		}

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0x8B0640", Offset = "0x8B0640", VA = "0x8B0640")]
		public void Click()
		{
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0x8B07FC", Offset = "0x8B07FC", VA = "0x8B07FC")]
		public List<GameObject> GetObjectsUnderPointer()
		{
			return null;
		}

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0x8B08E0", Offset = "0x8B08E0", VA = "0x8B08E0")]
		public List<GameObject> GetObjectsUnderScreenPos(Vector2 pos, [Optional] Camera eventCamera)
		{
			return null;
		}

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0x8B0A28", Offset = "0x8B0A28", VA = "0x8B0A28")]
		public List<GameObject> GetObjectsHitByRay(Ray ray)
		{
			return null;
		}

		[Token(Token = "0x60007FB")]
		[Address(RVA = "0x8B0F4C", Offset = "0x8B0F4C", VA = "0x8B0F4C")]
		public CurvedUISettings()
		{
		}
	}
	[Token(Token = "0x2000124")]
	public class CurvedUIVertexEffect : BaseMeshEffect
	{
		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5FD5BC", Offset = "0x5FD5BC")]
		public bool DoNotTesselate;

		[Token(Token = "0x40005E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool DoNotVertexEffect;

		[Token(Token = "0x40005E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Canvas myCanvas;

		[Token(Token = "0x40005E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private CurvedUISettings mySettings;

		[Token(Token = "0x40005E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Graphic myGraphic;

		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Text myText;

		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TextMeshProUGUI myTMP;

		[Token(Token = "0x40005EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private CurvedUITMPSubmesh myTMPSubMesh;

		[Token(Token = "0x40005EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool m_tesselationRequired;

		[Token(Token = "0x40005EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private bool curvingRequired;

		[Token(Token = "0x40005ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		private bool TransformMisaligned;

		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Matrix4x4 CanvasToWorld;

		[Token(Token = "0x40005EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Matrix4x4 CanvasToLocal;

		[Token(Token = "0x40005F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Matrix4x4 MyToWorld;

		[Token(Token = "0x40005F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private Matrix4x4 MyToLocal;

		[Token(Token = "0x40005F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private List<UIVertex> m_tesselatedVerts;

		[Token(Token = "0x40005F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private List<UIVertex> m_curvedVerts;

		[Token(Token = "0x40005F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private List<UIVertex> m_vertsInQuads;

		[Token(Token = "0x40005F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private UIVertex m_ret;

		[Token(Token = "0x40005F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private UIVertex[] m_quad;

		[Token(Token = "0x40005F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private float[] m_weights;

		[Token(Token = "0x40005F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		[SerializeField]
		[HideInInspector]
		private Vector3 savedPos;

		[Token(Token = "0x40005F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
		[SerializeField]
		[HideInInspector]
		private Vector3 savedUp;

		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		[SerializeField]
		[HideInInspector]
		private Vector2 savedRectSize;

		[Token(Token = "0x40005FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		[SerializeField]
		[HideInInspector]
		private Color savedColor;

		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		[SerializeField]
		[HideInInspector]
		private Vector2 savedTextUV0;

		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		[SerializeField]
		[HideInInspector]
		private float savedFill;

		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x214")]
		private Vector2 _uv0;

		[Token(Token = "0x40005FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21C")]
		private Vector2 _uv1;

		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x224")]
		private Vector3 _pos;

		[Token(Token = "0x170000B1")]
		private bool tesselationRequired
		{
			[Token(Token = "0x60007FC")]
			[Address(RVA = "0x8B35E8", Offset = "0x8B35E8", VA = "0x8B35E8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007FD")]
			[Address(RVA = "0x8B35F0", Offset = "0x8B35F0", VA = "0x8B35F0")]
			set
			{
			}
		}

		[Token(Token = "0x170000B2")]
		public bool TesselationRequired
		{
			[Token(Token = "0x6000810")]
			[Address(RVA = "0x8B6334", Offset = "0x8B6334", VA = "0x8B6334")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000811")]
			[Address(RVA = "0x8B6328", Offset = "0x8B6328", VA = "0x8B6328")]
			set
			{
			}
		}

		[Token(Token = "0x170000B3")]
		public bool CurvingRequired
		{
			[Token(Token = "0x6000812")]
			[Address(RVA = "0x8B633C", Offset = "0x8B633C", VA = "0x8B633C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000813")]
			[Address(RVA = "0x8B6344", Offset = "0x8B6344", VA = "0x8B6344")]
			set
			{
			}
		}

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0x8B35FC", Offset = "0x8B35FC", VA = "0x8B35FC", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0x8B36A8", Offset = "0x8B36A8", VA = "0x8B36A8", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000800")]
		[Address(RVA = "0x8B3948", Offset = "0x8B3948", VA = "0x8B3948", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000801")]
		[Address(RVA = "0x8B3ED0", Offset = "0x8B3ED0", VA = "0x8B3ED0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000802")]
		[Address(RVA = "0x8B4050", Offset = "0x8B4050", VA = "0x8B4050")]
		private void TesselationRequiredCallback()
		{
		}

		[Token(Token = "0x6000803")]
		[Address(RVA = "0x8B405C", Offset = "0x8B405C", VA = "0x8B405C")]
		private void FontTextureRebuiltCallback(Font fontie)
		{
		}

		[Token(Token = "0x6000804")]
		[Address(RVA = "0x8B4100", Offset = "0x8B4100", VA = "0x8B4100")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000805")]
		[Address(RVA = "0x8B46C0", Offset = "0x8B46C0", VA = "0x8B46C0", Slot = "20")]
		public override void ModifyMesh(VertexHelper vh)
		{
		}

		[Token(Token = "0x6000806")]
		[Address(RVA = "0x8B1E64", Offset = "0x8B1E64", VA = "0x8B1E64")]
		public void ModifyTMPMesh(ref List<UIVertex> vertexList)
		{
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0x8B4D3C", Offset = "0x8B4D3C", VA = "0x8B4D3C")]
		private bool ShouldModify()
		{
			return default(bool);
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0x8B4E40", Offset = "0x8B4E40", VA = "0x8B4E40")]
		private void CheckTextFontMaterial()
		{
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0x8B384C", Offset = "0x8B384C", VA = "0x8B384C")]
		public CurvedUISettings FindParentSettings(bool forceNew = false)
		{
			return null;
		}

		[Token(Token = "0x600080A")]
		[Address(RVA = "0x8B52C0", Offset = "0x8B52C0", VA = "0x8B52C0")]
		private UIVertex CurveVertex(UIVertex input, float cylinder_angle, float radius, Vector2 canvasSize)
		{
			return default(UIVertex);
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0x8B50E4", Offset = "0x8B50E4", VA = "0x8B50E4")]
		private void TesselateGeometry(List<UIVertex> verts)
		{
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0x8B5900", Offset = "0x8B5900", VA = "0x8B5900")]
		private void ModifyQuad(List<UIVertex> verts, int vertexIndex, Vector2 requiredSize)
		{
		}

		[Token(Token = "0x600080D")]
		[Address(RVA = "0x8B56A0", Offset = "0x8B56A0", VA = "0x8B56A0")]
		private void TrisToQuads(List<UIVertex> verts)
		{
		}

		[Token(Token = "0x600080E")]
		[Address(RVA = "0x8B5F9C", Offset = "0x8B5F9C", VA = "0x8B5F9C")]
		private UIVertex TesselateQuad(float x, float y)
		{
			return default(UIVertex);
		}

		[Token(Token = "0x600080F")]
		[Address(RVA = "0x8AF198", Offset = "0x8AF198", VA = "0x8AF198")]
		public void SetDirty()
		{
		}

		[Token(Token = "0x6000814")]
		[Address(RVA = "0x8B6350", Offset = "0x8B6350", VA = "0x8B6350")]
		public CurvedUIVertexEffect()
		{
		}
	}
	[Token(Token = "0x2000125")]
	public class CurvedUIViveController : MonoBehaviour
	{
		[Token(Token = "0x6000815")]
		[Address(RVA = "0x8B6430", Offset = "0x8B6430", VA = "0x8B6430")]
		public CurvedUIViveController()
		{
		}
	}
	[Token(Token = "0x2000126")]
	public struct ViveInputArgs
	{
		[Token(Token = "0x4000601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint controllerIndex;

		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float buttonPressure;

		[Token(Token = "0x4000603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Vector2 touchpadAxis;
	}
	[Token(Token = "0x2000127")]
	public delegate void ViveInputEvent(object sender, ViveInputArgs e);
	[Token(Token = "0x2000128")]
	public delegate void ViveEvent(object sender);
	[Token(Token = "0x2000129")]
	public class DisableAllMeshRenderers : MonoBehaviour
	{
		[Token(Token = "0x600081E")]
		[Address(RVA = "0x8B6438", Offset = "0x8B6438", VA = "0x8B6438")]
		private void Start()
		{
		}

		[Token(Token = "0x600081F")]
		[Address(RVA = "0x8B64EC", Offset = "0x8B64EC", VA = "0x8B64EC")]
		public DisableAllMeshRenderers()
		{
		}
	}
	[Token(Token = "0x200012A")]
	[ExecuteInEditMode]
	public class CurvedUITMP : MonoBehaviour
	{
		[Token(Token = "0x4000604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CurvedUIVertexEffect crvdVE;

		[Token(Token = "0x4000605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TextMeshProUGUI tmpText;

		[Token(Token = "0x4000606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CurvedUISettings mySettings;

		[Token(Token = "0x4000607")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<UIVertex> m_UIVerts;

		[Token(Token = "0x4000608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private UIVertex m_tempVertex;

		[Token(Token = "0x4000609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private CurvedUITMPSubmesh m_tempSubMsh;

		[Token(Token = "0x400060A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector2 savedSize;

		[Token(Token = "0x400060B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 savedUp;

		[Token(Token = "0x400060C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 savedPos;

		[Token(Token = "0x400060D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 savedLocalScale;

		[Token(Token = "0x400060E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Vector3 savedGlobalScale;

		[Token(Token = "0x400060F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private List<CurvedUITMPSubmesh> subMeshes;

		[Token(Token = "0x4000610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public bool Dirty;

		[Token(Token = "0x4000611")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD1")]
		private bool curvingRequired;

		[Token(Token = "0x4000612")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD2")]
		private bool tesselationRequired;

		[Token(Token = "0x4000613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD3")]
		private bool quitting;

		[Token(Token = "0x4000614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Vector3[] vertices;

		[Token(Token = "0x6000820")]
		[Address(RVA = "0x8B0F94", Offset = "0x8B0F94", VA = "0x8B0F94")]
		private void Start()
		{
		}

		[Token(Token = "0x6000821")]
		[Address(RVA = "0x8B1024", Offset = "0x8B1024", VA = "0x8B1024")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000822")]
		[Address(RVA = "0x8B12C8", Offset = "0x8B12C8", VA = "0x8B12C8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0x8B1414", Offset = "0x8B1414", VA = "0x8B1414")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000824")]
		[Address(RVA = "0x8B1420", Offset = "0x8B1420", VA = "0x8B1420")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000825")]
		[Address(RVA = "0x8B1C44", Offset = "0x8B1C44", VA = "0x8B1C44")]
		private void CreateUIVertexList(Mesh mesh)
		{
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0x8B2630", Offset = "0x8B2630", VA = "0x8B2630")]
		private void GetUIVertexFromMesh(ref UIVertex vert, int i)
		{
		}

		[Token(Token = "0x6000827")]
		[Address(RVA = "0x8B2118", Offset = "0x8B2118", VA = "0x8B2118")]
		private void FillMeshWithUIVertexList(Mesh mesh, List<UIVertex> list)
		{
		}

		[Token(Token = "0x6000828")]
		[Address(RVA = "0x8B11A8", Offset = "0x8B11A8", VA = "0x8B11A8")]
		private void FindTMP()
		{
		}

		[Token(Token = "0x6000829")]
		[Address(RVA = "0x8B226C", Offset = "0x8B226C", VA = "0x8B226C")]
		private void FindSubmeshes()
		{
		}

		[Token(Token = "0x600082A")]
		[Address(RVA = "0x8B18BC", Offset = "0x8B18BC", VA = "0x8B18BC")]
		private bool ShouldTesselate()
		{
			return default(bool);
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0x8B2680", Offset = "0x8B2680", VA = "0x8B2680")]
		private void TMPTextChangedCallback(object obj)
		{
		}

		[Token(Token = "0x600082C")]
		[Address(RVA = "0x8B269C", Offset = "0x8B269C", VA = "0x8B269C")]
		private void TesselationRequiredCallback()
		{
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0x8B26A8", Offset = "0x8B26A8", VA = "0x8B26A8")]
		public CurvedUITMP()
		{
		}
	}
	[Token(Token = "0x200012B")]
	[ExecuteInEditMode]
	public class CurvedUITMPInputFieldCaret : MonoBehaviour, ISelectHandler, IEventSystemHandler, IDeselectHandler
	{
		[Token(Token = "0x20001B6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB474", Offset = "0x5FB474")]
		private sealed class <CaretBlinker>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400080D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400080E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400080F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CurvedUITMPInputFieldCaret <>4__this;

			[Token(Token = "0x17000110")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A3B")]
				[Address(RVA = "0x8B3570", Offset = "0x8B3570", VA = "0x8B3570", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000111")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A3D")]
				[Address(RVA = "0x8B35D8", Offset = "0x8B35D8", VA = "0x8B35D8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A38")]
			[Address(RVA = "0x8B32C4", Offset = "0x8B32C4", VA = "0x8B32C4")]
			[DebuggerHidden]
			public <CaretBlinker>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x6000A39")]
			[Address(RVA = "0x8B3454", Offset = "0x8B3454", VA = "0x8B3454", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A3A")]
			[Address(RVA = "0x8B3458", Offset = "0x8B3458", VA = "0x8B3458", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A3C")]
			[Address(RVA = "0x8B3578", Offset = "0x8B3578", VA = "0x8B3578", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TMP_InputField myField;

		[Token(Token = "0x4000616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private RectTransform myCaret;

		[Token(Token = "0x4000617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Color origCaretColor;

		[Token(Token = "0x4000618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Color origSelectionColor;

		[Token(Token = "0x4000619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool selected;

		[Token(Token = "0x400061A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		private bool selectingText;

		[Token(Token = "0x170000B4")]
		public Color CaretColor
		{
			[Token(Token = "0x6000837")]
			[Address(RVA = "0x8B33E4", Offset = "0x8B33E4", VA = "0x8B33E4")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000838")]
			[Address(RVA = "0x8B33F0", Offset = "0x8B33F0", VA = "0x8B33F0")]
			set
			{
			}
		}

		[Token(Token = "0x170000B5")]
		public Color SelectionColor
		{
			[Token(Token = "0x6000839")]
			[Address(RVA = "0x8B33FC", Offset = "0x8B33FC", VA = "0x8B33FC")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600083A")]
			[Address(RVA = "0x8B3408", Offset = "0x8B3408", VA = "0x8B3408")]
			set
			{
			}
		}

		[Token(Token = "0x170000B6")]
		public float CaretBlinkRate
		{
			[Token(Token = "0x600083B")]
			[Address(RVA = "0x8B3414", Offset = "0x8B3414", VA = "0x8B3414")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600083C")]
			[Address(RVA = "0x8B3430", Offset = "0x8B3430", VA = "0x8B3430")]
			set
			{
			}
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0x8B2740", Offset = "0x8B2740", VA = "0x8B2740")]
		private void Awake()
		{
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0x8B2AF8", Offset = "0x8B2AF8", VA = "0x8B2AF8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000830")]
		[Address(RVA = "0x8B2E24", Offset = "0x8B2E24", VA = "0x8B2E24", Slot = "4")]
		public void OnSelect(BaseEventData eventData)
		{
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0x8B328C", Offset = "0x8B328C", VA = "0x8B328C", Slot = "5")]
		public void OnDeselect(BaseEventData eventData)
		{
		}

		[Token(Token = "0x6000832")]
		[Address(RVA = "0x8B321C", Offset = "0x8B321C", VA = "0x8B321C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5FF184", Offset = "0x5FF184")]
		private IEnumerator CaretBlinker()
		{
			return null;
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0x8B2EE4", Offset = "0x8B2EE4", VA = "0x8B2EE4")]
		private void CreateCaret()
		{
		}

		[Token(Token = "0x6000834")]
		[Address(RVA = "0x8B2B08", Offset = "0x8B2B08", VA = "0x8B2B08")]
		private void UpdateCaret()
		{
		}

		[Token(Token = "0x6000835")]
		[Address(RVA = "0x8B32F0", Offset = "0x8B32F0", VA = "0x8B32F0")]
		private Vector2 GetLocalPositionInText(int charNo)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000836")]
		[Address(RVA = "0x8B27DC", Offset = "0x8B27DC", VA = "0x8B27DC")]
		private void CheckAndConvertMask()
		{
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0x8B344C", Offset = "0x8B344C", VA = "0x8B344C")]
		public CurvedUITMPInputFieldCaret()
		{
		}
	}
	[Token(Token = "0x200012C")]
	[ExecuteInEditMode]
	public class CurvedUITMPSubmesh : MonoBehaviour
	{
		[Token(Token = "0x400061B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private VertexHelper vh;

		[Token(Token = "0x400061C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Mesh straightMesh;

		[Token(Token = "0x400061D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Mesh curvedMesh;

		[Token(Token = "0x400061E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private CurvedUIVertexEffect crvdVE;

		[Token(Token = "0x400061F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TMP_SubMeshUI TMPsub;

		[Token(Token = "0x600083E")]
		[Address(RVA = "0x8B2378", Offset = "0x8B2378", VA = "0x8B2378")]
		public void UpdateSubmesh(bool tesselate, bool curve)
		{
		}

		[Token(Token = "0x600083F")]
		[Address(RVA = "0x8B35E0", Offset = "0x8B35E0", VA = "0x8B35E0")]
		public CurvedUITMPSubmesh()
		{
		}
	}
	[Token(Token = "0x200012D")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x5FAEF4", Offset = "0x5FAEF4")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x5FAEF4", Offset = "0x5FAEF4")]
	public class OptionalDependencyAttribute : Attribute
	{
		[Token(Token = "0x4000620")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string dependentClass;

		[Token(Token = "0x4000621")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string define;

		[Token(Token = "0x6000840")]
		[Address(RVA = "0x8B64F4", Offset = "0x8B64F4", VA = "0x8B64F4")]
		public OptionalDependencyAttribute(string dependentClass, string define)
		{
		}
	}
}
namespace ArabicSupport
{
	[Token(Token = "0x200012E")]
	public class ArabicFixer
	{
		[Token(Token = "0x6000841")]
		[Address(RVA = "0x827390", Offset = "0x827390", VA = "0x827390")]
		public static string Fix(string str)
		{
			return null;
		}

		[Token(Token = "0x6000842")]
		[Address(RVA = "0x82739C", Offset = "0x82739C", VA = "0x82739C")]
		public static string Fix(string str, bool rtl)
		{
			return null;
		}

		[Token(Token = "0x6000843")]
		[Address(RVA = "0x827068", Offset = "0x827068", VA = "0x827068")]
		public static string Fix(string str, bool showTashkeel, bool useHinduNumbers)
		{
			return null;
		}

		[Token(Token = "0x6000844")]
		[Address(RVA = "0x8275D0", Offset = "0x8275D0", VA = "0x8275D0")]
		public static string Fix(string str, bool showTashkeel, bool combineTashkeel, bool useHinduNumbers)
		{
			return null;
		}

		[Token(Token = "0x6000845")]
		[Address(RVA = "0x827668", Offset = "0x827668", VA = "0x827668")]
		public ArabicFixer()
		{
		}
	}
}
namespace SimpleDiskUtils
{
	[Token(Token = "0x200012F")]
	public class DiskUtils
	{
		[Token(Token = "0x6000846")]
		[Address(RVA = "0x7E5038", Offset = "0x7E5038", VA = "0x7E5038")]
		public static int CheckAvailableSpace(bool isExternalStorage = true)
		{
			return default(int);
		}

		[Token(Token = "0x6000847")]
		[Address(RVA = "0x7E5148", Offset = "0x7E5148", VA = "0x7E5148")]
		public static int CheckTotalSpace(bool isExternalStorage = true)
		{
			return default(int);
		}

		[Token(Token = "0x6000848")]
		[Address(RVA = "0x7E5258", Offset = "0x7E5258", VA = "0x7E5258")]
		public static int CheckBusySpace(bool isExternalStorage = true)
		{
			return default(int);
		}

		[Token(Token = "0x6000849")]
		[Address(RVA = "0x7E5368", Offset = "0x7E5368", VA = "0x7E5368")]
		public static void DeleteFile(string filePath)
		{
		}

		[Token(Token = "0x600084A")]
		[Address(RVA = "0x7E53A4", Offset = "0x7E53A4", VA = "0x7E53A4")]
		public static void SaveFile(object obj, string filePath)
		{
		}

		[Token(Token = "0x600084B")]
		[Address(RVA = "0x7E54E0", Offset = "0x7E54E0", VA = "0x7E54E0")]
		public static void SaveFile(object obj, string dirPath, string fileName)
		{
		}

		[Token(Token = "0x600084C")]
		public static T LoadFile<T>(string filePath)
		{
			return (T)null;
		}

		[Token(Token = "0x600084D")]
		[Address(RVA = "0x7E5808", Offset = "0x7E5808", VA = "0x7E5808")]
		public static void SaveTextFile(string str, string filePath)
		{
		}

		[Token(Token = "0x600084E")]
		[Address(RVA = "0x7E58D4", Offset = "0x7E58D4", VA = "0x7E58D4")]
		public static void SaveTextFile(string str, string dirPath, string fileName)
		{
		}

		[Token(Token = "0x600084F")]
		public static string LoadTextFile<T>(string filePath)
		{
			return null;
		}

		[Token(Token = "0x6000850")]
		[Address(RVA = "0x7E563C", Offset = "0x7E563C", VA = "0x7E563C")]
		public static byte[] ObjectToByteArray(object obj)
		{
			return null;
		}

		[Token(Token = "0x6000851")]
		public static T ByteArrayToObject<T>(byte[] bytes)
		{
			return (T)null;
		}

		[Token(Token = "0x6000852")]
		[Address(RVA = "0x7E59F4", Offset = "0x7E59F4", VA = "0x7E59F4")]
		public DiskUtils()
		{
		}
	}
}
namespace Internet
{
	[Token(Token = "0x2000130")]
	public class Connection : MonoBehaviour
	{
		[Token(Token = "0x6000853")]
		[Address(RVA = "0x7CB6C4", Offset = "0x7CB6C4", VA = "0x7CB6C4")]
		protected void CheckInternet(Action<bool> isConnect)
		{
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0x7CB72C", Offset = "0x7CB72C", VA = "0x7CB72C")]
		public static bool IsAccessNet()
		{
			return default(bool);
		}

		[Token(Token = "0x6000855")]
		[Address(RVA = "0x7CB74C", Offset = "0x7CB74C", VA = "0x7CB74C")]
		public Connection()
		{
		}
	}
	[Token(Token = "0x2000131")]
	public class ConnectionWhile : Connection
	{
		[Token(Token = "0x20001B7")]
		protected enum NetStatus
		{
			[Token(Token = "0x4000811")]
			Ok,
			[Token(Token = "0x4000812")]
			Fail
		}

		[Token(Token = "0x4000622")]
		private const float WhileTime = 2f;

		[Token(Token = "0x4000623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private NetStatus _status;

		[Token(Token = "0x170000B7")]
		private NetStatus Status
		{
			[Token(Token = "0x6000856")]
			[Address(RVA = "0x7CB754", Offset = "0x7CB754", VA = "0x7CB754")]
			get
			{
				return default(NetStatus);
			}
			[Token(Token = "0x6000857")]
			[Address(RVA = "0x7CB75C", Offset = "0x7CB75C", VA = "0x7CB75C")]
			set
			{
			}
		}

		[Token(Token = "0x6000858")]
		[Address(RVA = "0x7CB77C", Offset = "0x7CB77C", VA = "0x7CB77C")]
		protected void Start()
		{
		}

		[Token(Token = "0x6000859")]
		[Address(RVA = "0x7CB830", Offset = "0x7CB830", VA = "0x7CB830", Slot = "4")]
		protected virtual void OnInternetConnection(NetStatus connection)
		{
		}

		[Token(Token = "0x600085A")]
		[Address(RVA = "0x7CB8C4", Offset = "0x7CB8C4", VA = "0x7CB8C4")]
		private void CheckInternetWhile()
		{
		}

		[Token(Token = "0x600085B")]
		[Address(RVA = "0x7CB938", Offset = "0x7CB938", VA = "0x7CB938")]
		public ConnectionWhile()
		{
		}
	}
}
namespace DG.Tweening
{
	[Token(Token = "0x2000132")]
	public static class DOTweenModuleAudio
	{
		[Token(Token = "0x20001B8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB484", Offset = "0x5FB484")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x4000813")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioSource target;

			[Token(Token = "0x6000A3E")]
			[Address(RVA = "0x7A58B0", Offset = "0x7A58B0", VA = "0x7A58B0")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x6000A3F")]
			[Address(RVA = "0x7A6070", Offset = "0x7A6070", VA = "0x7A6070")]
			internal float <DOFade>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000A40")]
			[Address(RVA = "0x7A608C", Offset = "0x7A608C", VA = "0x7A608C")]
			internal void <DOFade>b__1(float x)
			{
			}
		}

		[Token(Token = "0x20001B9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB494", Offset = "0x5FB494")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000814")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioSource target;

			[Token(Token = "0x6000A41")]
			[Address(RVA = "0x7A59F4", Offset = "0x7A59F4", VA = "0x7A59F4")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x6000A42")]
			[Address(RVA = "0x7A60A8", Offset = "0x7A60A8", VA = "0x7A60A8")]
			internal float <DOPitch>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000A43")]
			[Address(RVA = "0x7A60C4", Offset = "0x7A60C4", VA = "0x7A60C4")]
			internal void <DOPitch>b__1(float x)
			{
			}
		}

		[Token(Token = "0x20001BA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB4A4", Offset = "0x5FB4A4")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x4000815")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioMixer target;

			[Token(Token = "0x4000816")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string floatName;

			[Token(Token = "0x6000A44")]
			[Address(RVA = "0x7A5B3C", Offset = "0x7A5B3C", VA = "0x7A5B3C")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6000A45")]
			[Address(RVA = "0x7A60E0", Offset = "0x7A60E0", VA = "0x7A60E0")]
			internal float <DOSetFloat>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000A46")]
			[Address(RVA = "0x7A6120", Offset = "0x7A6120", VA = "0x7A6120")]
			internal void <DOSetFloat>b__1(float x)
			{
			}
		}

		[Token(Token = "0x600085C")]
		[Address(RVA = "0x7A574C", Offset = "0x7A574C", VA = "0x7A574C")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600085D")]
		[Address(RVA = "0x7A58B8", Offset = "0x7A58B8", VA = "0x7A58B8")]
		public static TweenerCore<float, float, FloatOptions> DOPitch(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600085E")]
		[Address(RVA = "0x7A59FC", Offset = "0x7A59FC", VA = "0x7A59FC")]
		public static TweenerCore<float, float, FloatOptions> DOSetFloat(this AudioMixer target, string floatName, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600085F")]
		[Address(RVA = "0x7A5B44", Offset = "0x7A5B44", VA = "0x7A5B44")]
		public static int DOComplete(this AudioMixer target, bool withCallbacks = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000860")]
		[Address(RVA = "0x7A5BBC", Offset = "0x7A5BBC", VA = "0x7A5BBC")]
		public static int DOKill(this AudioMixer target, bool complete = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000861")]
		[Address(RVA = "0x7A5C34", Offset = "0x7A5C34", VA = "0x7A5C34")]
		public static int DOFlip(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000862")]
		[Address(RVA = "0x7A5C9C", Offset = "0x7A5C9C", VA = "0x7A5C9C")]
		public static int DOGoto(this AudioMixer target, float to, bool andPlay = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000863")]
		[Address(RVA = "0x7A5D24", Offset = "0x7A5D24", VA = "0x7A5D24")]
		public static int DOPause(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000864")]
		[Address(RVA = "0x7A5D8C", Offset = "0x7A5D8C", VA = "0x7A5D8C")]
		public static int DOPlay(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000865")]
		[Address(RVA = "0x7A5DF4", Offset = "0x7A5DF4", VA = "0x7A5DF4")]
		public static int DOPlayBackwards(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000866")]
		[Address(RVA = "0x7A5E5C", Offset = "0x7A5E5C", VA = "0x7A5E5C")]
		public static int DOPlayForward(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000867")]
		[Address(RVA = "0x7A5EC4", Offset = "0x7A5EC4", VA = "0x7A5EC4")]
		public static int DORestart(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000868")]
		[Address(RVA = "0x7A5F34", Offset = "0x7A5F34", VA = "0x7A5F34")]
		public static int DORewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000869")]
		[Address(RVA = "0x7A5FA0", Offset = "0x7A5FA0", VA = "0x7A5FA0")]
		public static int DOSmoothRewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600086A")]
		[Address(RVA = "0x7A6008", Offset = "0x7A6008", VA = "0x7A6008")]
		public static int DOTogglePause(this AudioMixer target)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000133")]
	public static class DOTweenModulePhysics
	{
		[Token(Token = "0x20001BB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB4B4", Offset = "0x5FB4B4")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x4000817")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000A47")]
			[Address(RVA = "0x7A62B4", Offset = "0x7A62B4", VA = "0x7A62B4")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x6000A48")]
			[Address(RVA = "0x7A7650", Offset = "0x7A7650", VA = "0x7A7650")]
			internal Vector3 <DOMove>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x20001BC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB4C4", Offset = "0x5FB4C4")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000818")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000A49")]
			[Address(RVA = "0x7A6444", Offset = "0x7A6444", VA = "0x7A6444")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x6000A4A")]
			[Address(RVA = "0x7A778C", Offset = "0x7A778C", VA = "0x7A778C")]
			internal Vector3 <DOMoveX>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x20001BD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB4D4", Offset = "0x5FB4D4")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x4000819")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000A4B")]
			[Address(RVA = "0x7A65D4", Offset = "0x7A65D4", VA = "0x7A65D4")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6000A4C")]
			[Address(RVA = "0x7A77A8", Offset = "0x7A77A8", VA = "0x7A77A8")]
			internal Vector3 <DOMoveY>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x20001BE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB4E4", Offset = "0x5FB4E4")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x400081A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000A4D")]
			[Address(RVA = "0x7A6764", Offset = "0x7A6764", VA = "0x7A6764")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x6000A4E")]
			[Address(RVA = "0x7A77C4", Offset = "0x7A77C4", VA = "0x7A77C4")]
			internal Vector3 <DOMoveZ>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x20001BF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB4F4", Offset = "0x5FB4F4")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x400081B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000A4F")]
			[Address(RVA = "0x7A68D8", Offset = "0x7A68D8", VA = "0x7A68D8")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x6000A50")]
			[Address(RVA = "0x7A77E0", Offset = "0x7A77E0", VA = "0x7A77E0")]
			internal Quaternion <DORotate>b__0()
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x20001C0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB504", Offset = "0x5FB504")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x400081C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000A51")]
			[Address(RVA = "0x7A6AC4", Offset = "0x7A6AC4", VA = "0x7A6AC4")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x6000A52")]
			[Address(RVA = "0x7A77FC", Offset = "0x7A77FC", VA = "0x7A77FC")]
			internal Quaternion <DOLookAt>b__0()
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x20001C1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB514", Offset = "0x5FB514")]
		private sealed class <>c__DisplayClass6_0
		{
			[Token(Token = "0x400081D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x400081E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float startPosY;

			[Token(Token = "0x400081F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool offsetYSet;

			[Token(Token = "0x4000820")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float offsetY;

			[Token(Token = "0x4000821")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Sequence s;

			[Token(Token = "0x4000822")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector3 endValue;

			[Token(Token = "0x4000823")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Tween yTween;

			[Token(Token = "0x6000A53")]
			[Address(RVA = "0x7A6F40", Offset = "0x7A6F40", VA = "0x7A6F40")]
			public <>c__DisplayClass6_0()
			{
			}

			[Token(Token = "0x6000A54")]
			[Address(RVA = "0x7A7818", Offset = "0x7A7818", VA = "0x7A7818")]
			internal Vector3 <DOJump>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000A55")]
			[Address(RVA = "0x7A7834", Offset = "0x7A7834", VA = "0x7A7834")]
			internal void <DOJump>b__1()
			{
			}

			[Token(Token = "0x6000A56")]
			[Address(RVA = "0x7A7868", Offset = "0x7A7868", VA = "0x7A7868")]
			internal Vector3 <DOJump>b__2()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000A57")]
			[Address(RVA = "0x7A7884", Offset = "0x7A7884", VA = "0x7A7884")]
			internal Vector3 <DOJump>b__3()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000A58")]
			[Address(RVA = "0x7A78A0", Offset = "0x7A78A0", VA = "0x7A78A0")]
			internal void <DOJump>b__4()
			{
			}
		}

		[Token(Token = "0x20001C2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB524", Offset = "0x5FB524")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x4000824")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000A59")]
			[Address(RVA = "0x7A7134", Offset = "0x7A7134", VA = "0x7A7134")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x6000A5A")]
			[Address(RVA = "0x7A7960", Offset = "0x7A7960", VA = "0x7A7960")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x20001C3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB534", Offset = "0x5FB534")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x4000825")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			[Token(Token = "0x4000826")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody target;

			[Token(Token = "0x6000A5B")]
			[Address(RVA = "0x7A733C", Offset = "0x7A733C", VA = "0x7A733C")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x6000A5C")]
			[Address(RVA = "0x7A797C", Offset = "0x7A797C", VA = "0x7A797C")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000A5D")]
			[Address(RVA = "0x7A7998", Offset = "0x7A7998", VA = "0x7A7998")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20001C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB544", Offset = "0x5FB544")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x4000827")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000A5E")]
			[Address(RVA = "0x7A74BC", Offset = "0x7A74BC", VA = "0x7A74BC")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x6000A5F")]
			[Address(RVA = "0x7A7A9C", Offset = "0x7A7A9C", VA = "0x7A7A9C")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x20001C5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB554", Offset = "0x5FB554")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x4000828")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			[Token(Token = "0x4000829")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody target;

			[Token(Token = "0x6000A60")]
			[Address(RVA = "0x7A7648", Offset = "0x7A7648", VA = "0x7A7648")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x6000A61")]
			[Address(RVA = "0x7A766C", Offset = "0x7A766C", VA = "0x7A766C")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000A62")]
			[Address(RVA = "0x7A7688", Offset = "0x7A7688", VA = "0x7A7688")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x600086B")]
		[Address(RVA = "0x7A6144", Offset = "0x7A6144", VA = "0x7A6144")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMove(this Rigidbody target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600086C")]
		[Address(RVA = "0x7A62BC", Offset = "0x7A62BC", VA = "0x7A62BC")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveX(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600086D")]
		[Address(RVA = "0x7A644C", Offset = "0x7A644C", VA = "0x7A644C")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveY(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600086E")]
		[Address(RVA = "0x7A65DC", Offset = "0x7A65DC", VA = "0x7A65DC")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveZ(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600086F")]
		[Address(RVA = "0x7A676C", Offset = "0x7A676C", VA = "0x7A676C")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate(this Rigidbody target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			return null;
		}

		[Token(Token = "0x6000870")]
		[Address(RVA = "0x7A68E0", Offset = "0x7A68E0", VA = "0x7A68E0")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLookAt(this Rigidbody target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, [Optional] Vector3? up)
		{
			return null;
		}

		[Token(Token = "0x6000871")]
		[Address(RVA = "0x7A6ACC", Offset = "0x7A6ACC", VA = "0x7A6ACC")]
		public static Sequence DOJump(this Rigidbody target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000872")]
		[Address(RVA = "0x7A6F48", Offset = "0x7A6F48", VA = "0x7A6F48")]
		public static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x6000873")]
		[Address(RVA = "0x7A713C", Offset = "0x7A713C", VA = "0x7A713C")]
		public static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOLocalPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x6000874")]
		[Address(RVA = "0x7A7344", Offset = "0x7A7344", VA = "0x7A7344")]
		internal static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOPath(this Rigidbody target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}

		[Token(Token = "0x6000875")]
		[Address(RVA = "0x7A74C4", Offset = "0x7A74C4", VA = "0x7A74C4")]
		internal static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOLocalPath(this Rigidbody target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}
	}
	[Token(Token = "0x2000134")]
	public static class DOTweenModulePhysics2D
	{
		[Token(Token = "0x20001C6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB564", Offset = "0x5FB564")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x400082A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x6000A63")]
			[Address(RVA = "0x7A7C20", Offset = "0x7A7C20", VA = "0x7A7C20")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x6000A64")]
			[Address(RVA = "0x7A8960", Offset = "0x7A8960", VA = "0x7A8960")]
			internal Vector2 <DOMove>b__0()
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x20001C7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB574", Offset = "0x5FB574")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x400082B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x6000A65")]
			[Address(RVA = "0x7A7D9C", Offset = "0x7A7D9C", VA = "0x7A7D9C")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x6000A66")]
			[Address(RVA = "0x7A897C", Offset = "0x7A897C", VA = "0x7A897C")]
			internal Vector2 <DOMoveX>b__0()
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x20001C8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB584", Offset = "0x5FB584")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x400082C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x6000A67")]
			[Address(RVA = "0x7A7F18", Offset = "0x7A7F18", VA = "0x7A7F18")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6000A68")]
			[Address(RVA = "0x7A8998", Offset = "0x7A8998", VA = "0x7A8998")]
			internal Vector2 <DOMoveY>b__0()
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x20001C9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB594", Offset = "0x5FB594")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x400082D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x6000A69")]
			[Address(RVA = "0x7A8060", Offset = "0x7A8060", VA = "0x7A8060")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x6000A6A")]
			[Address(RVA = "0x7A89B4", Offset = "0x7A89B4", VA = "0x7A89B4")]
			internal float <DORotate>b__0()
			{
				return default(float);
			}
		}

		[Token(Token = "0x20001CA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB5A4", Offset = "0x5FB5A4")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x400082E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x400082F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float startPosY;

			[Token(Token = "0x4000830")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool offsetYSet;

			[Token(Token = "0x4000831")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float offsetY;

			[Token(Token = "0x4000832")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Sequence s;

			[Token(Token = "0x4000833")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector2 endValue;

			[Token(Token = "0x4000834")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Tween yTween;

			[Token(Token = "0x6000A6B")]
			[Address(RVA = "0x7A83E0", Offset = "0x7A83E0", VA = "0x7A83E0")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x6000A6C")]
			[Address(RVA = "0x7A89D0", Offset = "0x7A89D0", VA = "0x7A89D0")]
			internal Vector2 <DOJump>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000A6D")]
			[Address(RVA = "0x7A89EC", Offset = "0x7A89EC", VA = "0x7A89EC")]
			internal void <DOJump>b__1(Vector2 x)
			{
			}

			[Token(Token = "0x6000A6E")]
			[Address(RVA = "0x7A8A08", Offset = "0x7A8A08", VA = "0x7A8A08")]
			internal void <DOJump>b__2()
			{
			}

			[Token(Token = "0x6000A6F")]
			[Address(RVA = "0x7A8A3C", Offset = "0x7A8A3C", VA = "0x7A8A3C")]
			internal Vector2 <DOJump>b__3()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000A70")]
			[Address(RVA = "0x7A8A58", Offset = "0x7A8A58", VA = "0x7A8A58")]
			internal void <DOJump>b__4(Vector2 x)
			{
			}

			[Token(Token = "0x6000A71")]
			[Address(RVA = "0x7A8A74", Offset = "0x7A8A74", VA = "0x7A8A74")]
			internal void <DOJump>b__5()
			{
			}
		}

		[Token(Token = "0x20001CB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB5B4", Offset = "0x5FB5B4")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x4000835")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x6000A72")]
			[Address(RVA = "0x7A8694", Offset = "0x7A8694", VA = "0x7A8694")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x6000A73")]
			[Address(RVA = "0x7A8B9C", Offset = "0x7A8B9C", VA = "0x7A8B9C")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000A74")]
			[Address(RVA = "0x7A8C2C", Offset = "0x7A8C2C", VA = "0x7A8C2C")]
			internal void <DOPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20001CC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB5C4", Offset = "0x5FB5C4")]
		private sealed class <>c__DisplayClass6_0
		{
			[Token(Token = "0x4000836")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			[Token(Token = "0x4000837")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody2D target;

			[Token(Token = "0x6000A75")]
			[Address(RVA = "0x7A8958", Offset = "0x7A8958", VA = "0x7A8958")]
			public <>c__DisplayClass6_0()
			{
			}

			[Token(Token = "0x6000A76")]
			[Address(RVA = "0x7A8CD0", Offset = "0x7A8CD0", VA = "0x7A8CD0")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000A77")]
			[Address(RVA = "0x7A8CEC", Offset = "0x7A8CEC", VA = "0x7A8CEC")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x6000876")]
		[Address(RVA = "0x7A7AB8", Offset = "0x7A7AB8", VA = "0x7A7AB8")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMove(this Rigidbody2D target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000877")]
		[Address(RVA = "0x7A7C28", Offset = "0x7A7C28", VA = "0x7A7C28")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveX(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000878")]
		[Address(RVA = "0x7A7DA4", Offset = "0x7A7DA4", VA = "0x7A7DA4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveY(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000879")]
		[Address(RVA = "0x7A7F20", Offset = "0x7A7F20", VA = "0x7A7F20")]
		public static TweenerCore<float, float, FloatOptions> DORotate(this Rigidbody2D target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600087A")]
		[Address(RVA = "0x7A8068", Offset = "0x7A8068", VA = "0x7A8068")]
		public static Sequence DOJump(this Rigidbody2D target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600087B")]
		[Address(RVA = "0x7A83E8", Offset = "0x7A83E8", VA = "0x7A83E8")]
		public static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x600087C")]
		[Address(RVA = "0x7A869C", Offset = "0x7A869C", VA = "0x7A869C")]
		public static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOLocalPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}
	}
	[Token(Token = "0x2000135")]
	public static class DOTweenModuleSprite
	{
		[Token(Token = "0x20001CD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB5D4", Offset = "0x5FB5D4")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x4000838")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SpriteRenderer target;

			[Token(Token = "0x6000A78")]
			[Address(RVA = "0x7A8F7C", Offset = "0x7A8F7C", VA = "0x7A8F7C")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x6000A79")]
			[Address(RVA = "0x7A948C", Offset = "0x7A948C", VA = "0x7A948C")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000A7A")]
			[Address(RVA = "0x7A94A8", Offset = "0x7A94A8", VA = "0x7A94A8")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20001CE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB5E4", Offset = "0x5FB5E4")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000839")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SpriteRenderer target;

			[Token(Token = "0x6000A7B")]
			[Address(RVA = "0x7A90C0", Offset = "0x7A90C0", VA = "0x7A90C0")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x6000A7C")]
			[Address(RVA = "0x7A94C4", Offset = "0x7A94C4", VA = "0x7A94C4")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000A7D")]
			[Address(RVA = "0x7A94E0", Offset = "0x7A94E0", VA = "0x7A94E0")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20001CF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB5F4", Offset = "0x5FB5F4")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x400083A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x400083B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SpriteRenderer target;

			[Token(Token = "0x6000A7E")]
			[Address(RVA = "0x7A9484", Offset = "0x7A9484", VA = "0x7A9484")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x6000A7F")]
			[Address(RVA = "0x7A94FC", Offset = "0x7A94FC", VA = "0x7A94FC")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000A80")]
			[Address(RVA = "0x7A9508", Offset = "0x7A9508", VA = "0x7A9508")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x600087D")]
		[Address(RVA = "0x7A8E18", Offset = "0x7A8E18", VA = "0x7A8E18")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this SpriteRenderer target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600087E")]
		[Address(RVA = "0x7A8F84", Offset = "0x7A8F84", VA = "0x7A8F84")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this SpriteRenderer target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600087F")]
		[Address(RVA = "0x7A90C8", Offset = "0x7A90C8", VA = "0x7A90C8")]
		public static Sequence DOGradientColor(this SpriteRenderer target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000880")]
		[Address(RVA = "0x7A92A0", Offset = "0x7A92A0", VA = "0x7A92A0")]
		public static Tweener DOBlendableColor(this SpriteRenderer target, Color endValue, float duration)
		{
			return null;
		}
	}
	[Token(Token = "0x2000136")]
	public static class DOTweenModuleUI
	{
		[Token(Token = "0x20001D0")]
		public static class Utils
		{
			[Token(Token = "0x6000A81")]
			[Address(RVA = "0x7AE640", Offset = "0x7AE640", VA = "0x7AE640")]
			public static Vector2 SwitchToRectTransform(RectTransform from, RectTransform to)
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x20001D1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB604", Offset = "0x5FB604")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x400083C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CanvasGroup target;

			[Token(Token = "0x6000A82")]
			[Address(RVA = "0x7A96F0", Offset = "0x7A96F0", VA = "0x7A96F0")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x6000A83")]
			[Address(RVA = "0x7AD454", Offset = "0x7AD454", VA = "0x7AD454")]
			internal float <DOFade>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000A84")]
			[Address(RVA = "0x7AD470", Offset = "0x7AD470", VA = "0x7AD470")]
			internal void <DOFade>b__1(float x)
			{
			}
		}

		[Token(Token = "0x20001D2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB614", Offset = "0x5FB614")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x400083D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Graphic target;

			[Token(Token = "0x6000A85")]
			[Address(RVA = "0x7A985C", Offset = "0x7A985C", VA = "0x7A985C")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x6000A86")]
			[Address(RVA = "0x7AD6C4", Offset = "0x7AD6C4", VA = "0x7AD6C4")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000A87")]
			[Address(RVA = "0x7AD6E8", Offset = "0x7AD6E8", VA = "0x7AD6E8")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20001D3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB624", Offset = "0x5FB624")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x400083E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Graphic target;

			[Token(Token = "0x6000A88")]
			[Address(RVA = "0x7A99A0", Offset = "0x7A99A0", VA = "0x7A99A0")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6000A89")]
			[Address(RVA = "0x7ADD50", Offset = "0x7ADD50", VA = "0x7ADD50")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000A8A")]
			[Address(RVA = "0x7ADD74", Offset = "0x7ADD74", VA = "0x7ADD74")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20001D4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB634", Offset = "0x5FB634")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x400083F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x6000A8B")]
			[Address(RVA = "0x7A9B0C", Offset = "0x7A9B0C", VA = "0x7A9B0C")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x6000A8C")]
			[Address(RVA = "0x7AE21C", Offset = "0x7AE21C", VA = "0x7AE21C")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000A8D")]
			[Address(RVA = "0x7AE240", Offset = "0x7AE240", VA = "0x7AE240")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20001D5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB644", Offset = "0x5FB644")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x4000840")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x6000A8E")]
			[Address(RVA = "0x7A9C50", Offset = "0x7A9C50", VA = "0x7A9C50")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x6000A8F")]
			[Address(RVA = "0x7AE32C", Offset = "0x7AE32C", VA = "0x7AE32C")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000A90")]
			[Address(RVA = "0x7AE350", Offset = "0x7AE350", VA = "0x7AE350")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20001D6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB654", Offset = "0x5FB654")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x4000841")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x6000A91")]
			[Address(RVA = "0x7A9DB8", Offset = "0x7A9DB8", VA = "0x7A9DB8")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x6000A92")]
			[Address(RVA = "0x7AE374", Offset = "0x7AE374", VA = "0x7AE374")]
			internal float <DOFillAmount>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000A93")]
			[Address(RVA = "0x7AE390", Offset = "0x7AE390", VA = "0x7AE390")]
			internal void <DOFillAmount>b__1(float x)
			{
			}
		}

		[Token(Token = "0x20001D7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB664", Offset = "0x5FB664")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x4000842")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x6000A94")]
			[Address(RVA = "0x7AA0FC", Offset = "0x7AA0FC", VA = "0x7AA0FC")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x6000A95")]
			[Address(RVA = "0x7AE3AC", Offset = "0x7AE3AC", VA = "0x7AE3AC")]
			internal Vector2 <DOFlexibleSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000A96")]
			[Address(RVA = "0x7AE42C", Offset = "0x7AE42C", VA = "0x7AE42C")]
			internal void <DOFlexibleSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20001D8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB674", Offset = "0x5FB674")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x4000843")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x6000A97")]
			[Address(RVA = "0x7AA260", Offset = "0x7AA260", VA = "0x7AA260")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x6000A98")]
			[Address(RVA = "0x7AE488", Offset = "0x7AE488", VA = "0x7AE488")]
			internal Vector2 <DOMinSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000A99")]
			[Address(RVA = "0x7AE508", Offset = "0x7AE508", VA = "0x7AE508")]
			internal void <DOMinSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20001D9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB684", Offset = "0x5FB684")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x4000844")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x6000A9A")]
			[Address(RVA = "0x7AA3C4", Offset = "0x7AA3C4", VA = "0x7AA3C4")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x6000A9B")]
			[Address(RVA = "0x7AE564", Offset = "0x7AE564", VA = "0x7AE564")]
			internal Vector2 <DOPreferredSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000A9C")]
			[Address(RVA = "0x7AE5E4", Offset = "0x7AE5E4", VA = "0x7AE5E4")]
			internal void <DOPreferredSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20001DA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB694", Offset = "0x5FB694")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x4000845")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x6000A9D")]
			[Address(RVA = "0x7AA530", Offset = "0x7AA530", VA = "0x7AA530")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x6000A9E")]
			[Address(RVA = "0x7AD48C", Offset = "0x7AD48C", VA = "0x7AD48C")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000A9F")]
			[Address(RVA = "0x7AD4AC", Offset = "0x7AD4AC", VA = "0x7AD4AC")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20001DB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB6A4", Offset = "0x5FB6A4")]
		private sealed class <>c__DisplayClass11_0
		{
			[Token(Token = "0x4000846")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x6000AA0")]
			[Address(RVA = "0x7AA674", Offset = "0x7AA674", VA = "0x7AA674")]
			public <>c__DisplayClass11_0()
			{
			}

			[Token(Token = "0x6000AA1")]
			[Address(RVA = "0x7AD4C8", Offset = "0x7AD4C8", VA = "0x7AD4C8")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000AA2")]
			[Address(RVA = "0x7AD4E8", Offset = "0x7AD4E8", VA = "0x7AD4E8")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20001DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB6B4", Offset = "0x5FB6B4")]
		private sealed class <>c__DisplayClass12_0
		{
			[Token(Token = "0x4000847")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x6000AA3")]
			[Address(RVA = "0x7AA7C8", Offset = "0x7AA7C8", VA = "0x7AA7C8")]
			public <>c__DisplayClass12_0()
			{
			}

			[Token(Token = "0x6000AA4")]
			[Address(RVA = "0x7AD504", Offset = "0x7AD504", VA = "0x7AD504")]
			internal Vector2 <DOScale>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000AA5")]
			[Address(RVA = "0x7AD520", Offset = "0x7AD520", VA = "0x7AD520")]
			internal void <DOScale>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20001DD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB6C4", Offset = "0x5FB6C4")]
		private sealed class <>c__DisplayClass13_0
		{
			[Token(Token = "0x4000848")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000AA6")]
			[Address(RVA = "0x7AA92C", Offset = "0x7AA92C", VA = "0x7AA92C")]
			public <>c__DisplayClass13_0()
			{
			}

			[Token(Token = "0x6000AA7")]
			[Address(RVA = "0x7AD53C", Offset = "0x7AD53C", VA = "0x7AD53C")]
			internal Vector2 <DOAnchorPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000AA8")]
			[Address(RVA = "0x7AD558", Offset = "0x7AD558", VA = "0x7AD558")]
			internal void <DOAnchorPos>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20001DE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB6D4", Offset = "0x5FB6D4")]
		private sealed class <>c__DisplayClass14_0
		{
			[Token(Token = "0x4000849")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000AA9")]
			[Address(RVA = "0x7AAAA4", Offset = "0x7AAAA4", VA = "0x7AAAA4")]
			public <>c__DisplayClass14_0()
			{
			}

			[Token(Token = "0x6000AAA")]
			[Address(RVA = "0x7AD574", Offset = "0x7AD574", VA = "0x7AD574")]
			internal Vector2 <DOAnchorPosX>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000AAB")]
			[Address(RVA = "0x7AD590", Offset = "0x7AD590", VA = "0x7AD590")]
			internal void <DOAnchorPosX>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20001DF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB6E4", Offset = "0x5FB6E4")]
		private sealed class <>c__DisplayClass15_0
		{
			[Token(Token = "0x400084A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000AAC")]
			[Address(RVA = "0x7AAC1C", Offset = "0x7AAC1C", VA = "0x7AAC1C")]
			public <>c__DisplayClass15_0()
			{
			}

			[Token(Token = "0x6000AAD")]
			[Address(RVA = "0x7AD5AC", Offset = "0x7AD5AC", VA = "0x7AD5AC")]
			internal Vector2 <DOAnchorPosY>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000AAE")]
			[Address(RVA = "0x7AD5C8", Offset = "0x7AD5C8", VA = "0x7AD5C8")]
			internal void <DOAnchorPosY>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20001E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB6F4", Offset = "0x5FB6F4")]
		private sealed class <>c__DisplayClass16_0
		{
			[Token(Token = "0x400084B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000AAF")]
			[Address(RVA = "0x7AAD88", Offset = "0x7AAD88", VA = "0x7AAD88")]
			public <>c__DisplayClass16_0()
			{
			}

			[Token(Token = "0x6000AB0")]
			[Address(RVA = "0x7AD5E4", Offset = "0x7AD5E4", VA = "0x7AD5E4")]
			internal Vector3 <DOAnchorPos3D>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000AB1")]
			[Address(RVA = "0x7AD600", Offset = "0x7AD600", VA = "0x7AD600")]
			internal void <DOAnchorPos3D>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20001E1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB704", Offset = "0x5FB704")]
		private sealed class <>c__DisplayClass17_0
		{
			[Token(Token = "0x400084C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000AB2")]
			[Address(RVA = "0x7AAF0C", Offset = "0x7AAF0C", VA = "0x7AAF0C")]
			public <>c__DisplayClass17_0()
			{
			}

			[Token(Token = "0x6000AB3")]
			[Address(RVA = "0x7AD61C", Offset = "0x7AD61C", VA = "0x7AD61C")]
			internal Vector3 <DOAnchorPos3DX>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000AB4")]
			[Address(RVA = "0x7AD638", Offset = "0x7AD638", VA = "0x7AD638")]
			internal void <DOAnchorPos3DX>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20001E2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB714", Offset = "0x5FB714")]
		private sealed class <>c__DisplayClass18_0
		{
			[Token(Token = "0x400084D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000AB5")]
			[Address(RVA = "0x7AB090", Offset = "0x7AB090", VA = "0x7AB090")]
			public <>c__DisplayClass18_0()
			{
			}

			[Token(Token = "0x6000AB6")]
			[Address(RVA = "0x7AD654", Offset = "0x7AD654", VA = "0x7AD654")]
			internal Vector3 <DOAnchorPos3DY>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000AB7")]
			[Address(RVA = "0x7AD670", Offset = "0x7AD670", VA = "0x7AD670")]
			internal void <DOAnchorPos3DY>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20001E3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB724", Offset = "0x5FB724")]
		private sealed class <>c__DisplayClass19_0
		{
			[Token(Token = "0x400084E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000AB8")]
			[Address(RVA = "0x7AB214", Offset = "0x7AB214", VA = "0x7AB214")]
			public <>c__DisplayClass19_0()
			{
			}

			[Token(Token = "0x6000AB9")]
			[Address(RVA = "0x7AD68C", Offset = "0x7AD68C", VA = "0x7AD68C")]
			internal Vector3 <DOAnchorPos3DZ>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000ABA")]
			[Address(RVA = "0x7AD6A8", Offset = "0x7AD6A8", VA = "0x7AD6A8")]
			internal void <DOAnchorPos3DZ>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20001E4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB734", Offset = "0x5FB734")]
		private sealed class <>c__DisplayClass20_0
		{
			[Token(Token = "0x400084F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000ABB")]
			[Address(RVA = "0x7AB378", Offset = "0x7AB378", VA = "0x7AB378")]
			public <>c__DisplayClass20_0()
			{
			}

			[Token(Token = "0x6000ABC")]
			[Address(RVA = "0x7AD70C", Offset = "0x7AD70C", VA = "0x7AD70C")]
			internal Vector2 <DOAnchorMax>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000ABD")]
			[Address(RVA = "0x7AD728", Offset = "0x7AD728", VA = "0x7AD728")]
			internal void <DOAnchorMax>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20001E5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB744", Offset = "0x5FB744")]
		private sealed class <>c__DisplayClass21_0
		{
			[Token(Token = "0x4000850")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000ABE")]
			[Address(RVA = "0x7AB4DC", Offset = "0x7AB4DC", VA = "0x7AB4DC")]
			public <>c__DisplayClass21_0()
			{
			}

			[Token(Token = "0x6000ABF")]
			[Address(RVA = "0x7AD744", Offset = "0x7AD744", VA = "0x7AD744")]
			internal Vector2 <DOAnchorMin>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000AC0")]
			[Address(RVA = "0x7AD760", Offset = "0x7AD760", VA = "0x7AD760")]
			internal void <DOAnchorMin>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20001E6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB754", Offset = "0x5FB754")]
		private sealed class <>c__DisplayClass22_0
		{
			[Token(Token = "0x4000851")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000AC1")]
			[Address(RVA = "0x7AB630", Offset = "0x7AB630", VA = "0x7AB630")]
			public <>c__DisplayClass22_0()
			{
			}

			[Token(Token = "0x6000AC2")]
			[Address(RVA = "0x7AD77C", Offset = "0x7AD77C", VA = "0x7AD77C")]
			internal Vector2 <DOPivot>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000AC3")]
			[Address(RVA = "0x7AD798", Offset = "0x7AD798", VA = "0x7AD798")]
			internal void <DOPivot>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20001E7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB764", Offset = "0x5FB764")]
		private sealed class <>c__DisplayClass23_0
		{
			[Token(Token = "0x4000852")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000AC4")]
			[Address(RVA = "0x7AB79C", Offset = "0x7AB79C", VA = "0x7AB79C")]
			public <>c__DisplayClass23_0()
			{
			}

			[Token(Token = "0x6000AC5")]
			[Address(RVA = "0x7AD7B4", Offset = "0x7AD7B4", VA = "0x7AD7B4")]
			internal Vector2 <DOPivotX>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000AC6")]
			[Address(RVA = "0x7AD7D0", Offset = "0x7AD7D0", VA = "0x7AD7D0")]
			internal void <DOPivotX>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20001E8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB774", Offset = "0x5FB774")]
		private sealed class <>c__DisplayClass24_0
		{
			[Token(Token = "0x4000853")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000AC7")]
			[Address(RVA = "0x7AB908", Offset = "0x7AB908", VA = "0x7AB908")]
			public <>c__DisplayClass24_0()
			{
			}

			[Token(Token = "0x6000AC8")]
			[Address(RVA = "0x7AD7EC", Offset = "0x7AD7EC", VA = "0x7AD7EC")]
			internal Vector2 <DOPivotY>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000AC9")]
			[Address(RVA = "0x7AD808", Offset = "0x7AD808", VA = "0x7AD808")]
			internal void <DOPivotY>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20001E9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB784", Offset = "0x5FB784")]
		private sealed class <>c__DisplayClass25_0
		{
			[Token(Token = "0x4000854")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000ACA")]
			[Address(RVA = "0x7ABA6C", Offset = "0x7ABA6C", VA = "0x7ABA6C")]
			public <>c__DisplayClass25_0()
			{
			}

			[Token(Token = "0x6000ACB")]
			[Address(RVA = "0x7AD824", Offset = "0x7AD824", VA = "0x7AD824")]
			internal Vector2 <DOSizeDelta>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000ACC")]
			[Address(RVA = "0x7AD840", Offset = "0x7AD840", VA = "0x7AD840")]
			internal void <DOSizeDelta>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20001EA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB794", Offset = "0x5FB794")]
		private sealed class <>c__DisplayClass26_0
		{
			[Token(Token = "0x4000855")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000ACD")]
			[Address(RVA = "0x7ABC24", Offset = "0x7ABC24", VA = "0x7ABC24")]
			public <>c__DisplayClass26_0()
			{
			}

			[Token(Token = "0x6000ACE")]
			[Address(RVA = "0x7AD85C", Offset = "0x7AD85C", VA = "0x7AD85C")]
			internal Vector3 <DOPunchAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000ACF")]
			[Address(RVA = "0x7AD8EC", Offset = "0x7AD8EC", VA = "0x7AD8EC")]
			internal void <DOPunchAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20001EB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB7A4", Offset = "0x5FB7A4")]
		private sealed class <>c__DisplayClass27_0
		{
			[Token(Token = "0x4000856")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000AD0")]
			[Address(RVA = "0x7ABDAC", Offset = "0x7ABDAC", VA = "0x7ABDAC")]
			public <>c__DisplayClass27_0()
			{
			}

			[Token(Token = "0x6000AD1")]
			[Address(RVA = "0x7AD990", Offset = "0x7AD990", VA = "0x7AD990")]
			internal Vector3 <DOShakeAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000AD2")]
			[Address(RVA = "0x7ADA20", Offset = "0x7ADA20", VA = "0x7ADA20")]
			internal void <DOShakeAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20001EC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB7B4", Offset = "0x5FB7B4")]
		private sealed class <>c__DisplayClass28_0
		{
			[Token(Token = "0x4000857")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000AD3")]
			[Address(RVA = "0x7ABF80", Offset = "0x7ABF80", VA = "0x7ABF80")]
			public <>c__DisplayClass28_0()
			{
			}

			[Token(Token = "0x6000AD4")]
			[Address(RVA = "0x7ADAC4", Offset = "0x7ADAC4", VA = "0x7ADAC4")]
			internal Vector3 <DOShakeAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000AD5")]
			[Address(RVA = "0x7ADB54", Offset = "0x7ADB54", VA = "0x7ADB54")]
			internal void <DOShakeAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20001ED")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB7C4", Offset = "0x5FB7C4")]
		private sealed class <>c__DisplayClass29_0
		{
			[Token(Token = "0x4000858")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x4000859")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float startPosY;

			[Token(Token = "0x400085A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool offsetYSet;

			[Token(Token = "0x400085B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float offsetY;

			[Token(Token = "0x400085C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Sequence s;

			[Token(Token = "0x400085D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector2 endValue;

			[Token(Token = "0x6000AD6")]
			[Address(RVA = "0x7AC304", Offset = "0x7AC304", VA = "0x7AC304")]
			public <>c__DisplayClass29_0()
			{
			}

			[Token(Token = "0x6000AD7")]
			[Address(RVA = "0x7ADBF8", Offset = "0x7ADBF8", VA = "0x7ADBF8")]
			internal Vector2 <DOJumpAnchorPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000AD8")]
			[Address(RVA = "0x7ADC14", Offset = "0x7ADC14", VA = "0x7ADC14")]
			internal void <DOJumpAnchorPos>b__1(Vector2 x)
			{
			}

			[Token(Token = "0x6000AD9")]
			[Address(RVA = "0x7ADC30", Offset = "0x7ADC30", VA = "0x7ADC30")]
			internal void <DOJumpAnchorPos>b__2()
			{
			}

			[Token(Token = "0x6000ADA")]
			[Address(RVA = "0x7ADC64", Offset = "0x7ADC64", VA = "0x7ADC64")]
			internal Vector2 <DOJumpAnchorPos>b__3()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000ADB")]
			[Address(RVA = "0x7ADC80", Offset = "0x7ADC80", VA = "0x7ADC80")]
			internal void <DOJumpAnchorPos>b__4(Vector2 x)
			{
			}

			[Token(Token = "0x6000ADC")]
			[Address(RVA = "0x7ADC9C", Offset = "0x7ADC9C", VA = "0x7ADC9C")]
			internal void <DOJumpAnchorPos>b__5()
			{
			}
		}

		[Token(Token = "0x20001EE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB7D4", Offset = "0x5FB7D4")]
		private sealed class <>c__DisplayClass30_0
		{
			[Token(Token = "0x400085E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x6000ADD")]
			[Address(RVA = "0x7AC45C", Offset = "0x7AC45C", VA = "0x7AC45C")]
			public <>c__DisplayClass30_0()
			{
			}

			[Token(Token = "0x6000ADE")]
			[Address(RVA = "0x7ADD98", Offset = "0x7ADD98", VA = "0x7ADD98")]
			internal Vector2 <DONormalizedPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000ADF")]
			[Address(RVA = "0x7ADE08", Offset = "0x7ADE08", VA = "0x7ADE08")]
			internal void <DONormalizedPos>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20001EF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB7E4", Offset = "0x5FB7E4")]
		private sealed class <>c__DisplayClass31_0
		{
			[Token(Token = "0x400085F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x6000AE0")]
			[Address(RVA = "0x7AC5A4", Offset = "0x7AC5A4", VA = "0x7AC5A4")]
			public <>c__DisplayClass31_0()
			{
			}

			[Token(Token = "0x6000AE1")]
			[Address(RVA = "0x7ADE54", Offset = "0x7ADE54", VA = "0x7ADE54")]
			internal float <DOHorizontalNormalizedPos>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000AE2")]
			[Address(RVA = "0x7ADE70", Offset = "0x7ADE70", VA = "0x7ADE70")]
			internal void <DOHorizontalNormalizedPos>b__1(float x)
			{
			}
		}

		[Token(Token = "0x20001F0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB7F4", Offset = "0x5FB7F4")]
		private sealed class <>c__DisplayClass32_0
		{
			[Token(Token = "0x4000860")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x6000AE3")]
			[Address(RVA = "0x7AC6EC", Offset = "0x7AC6EC", VA = "0x7AC6EC")]
			public <>c__DisplayClass32_0()
			{
			}

			[Token(Token = "0x6000AE4")]
			[Address(RVA = "0x7ADE8C", Offset = "0x7ADE8C", VA = "0x7ADE8C")]
			internal float <DOVerticalNormalizedPos>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000AE5")]
			[Address(RVA = "0x7ADEA8", Offset = "0x7ADEA8", VA = "0x7ADEA8")]
			internal void <DOVerticalNormalizedPos>b__1(float x)
			{
			}
		}

		[Token(Token = "0x20001F1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB804", Offset = "0x5FB804")]
		private sealed class <>c__DisplayClass33_0
		{
			[Token(Token = "0x4000861")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Slider target;

			[Token(Token = "0x6000AE6")]
			[Address(RVA = "0x7AC840", Offset = "0x7AC840", VA = "0x7AC840")]
			public <>c__DisplayClass33_0()
			{
			}

			[Token(Token = "0x6000AE7")]
			[Address(RVA = "0x7ADEC4", Offset = "0x7ADEC4", VA = "0x7ADEC4")]
			internal float <DOValue>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000AE8")]
			[Address(RVA = "0x7ADEE8", Offset = "0x7ADEE8", VA = "0x7ADEE8")]
			internal void <DOValue>b__1(float x)
			{
			}
		}

		[Token(Token = "0x20001F2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB814", Offset = "0x5FB814")]
		private sealed class <>c__DisplayClass34_0
		{
			[Token(Token = "0x4000862")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x6000AE9")]
			[Address(RVA = "0x7AC9AC", Offset = "0x7AC9AC", VA = "0x7AC9AC")]
			public <>c__DisplayClass34_0()
			{
			}

			[Token(Token = "0x6000AEA")]
			[Address(RVA = "0x7ADF0C", Offset = "0x7ADF0C", VA = "0x7ADF0C")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000AEB")]
			[Address(RVA = "0x7ADF30", Offset = "0x7ADF30", VA = "0x7ADF30")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20001F3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB824", Offset = "0x5FB824")]
		private sealed class <>c__DisplayClass35_0
		{
			[Token(Token = "0x4000863")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int v;

			[Token(Token = "0x4000864")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Text target;

			[Token(Token = "0x4000865")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool addThousandsSeparator;

			[Token(Token = "0x4000866")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public CultureInfo cInfo;

			[Token(Token = "0x6000AEC")]
			[Address(RVA = "0x7ACB50", Offset = "0x7ACB50", VA = "0x7ACB50")]
			public <>c__DisplayClass35_0()
			{
			}

			[Token(Token = "0x6000AED")]
			[Address(RVA = "0x7ADF54", Offset = "0x7ADF54", VA = "0x7ADF54")]
			internal int <DOCounter>b__0()
			{
				return default(int);
			}

			[Token(Token = "0x6000AEE")]
			[Address(RVA = "0x7ADF5C", Offset = "0x7ADF5C", VA = "0x7ADF5C")]
			internal void <DOCounter>b__1(int x)
			{
			}
		}

		[Token(Token = "0x20001F4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB834", Offset = "0x5FB834")]
		private sealed class <>c__DisplayClass36_0
		{
			[Token(Token = "0x4000867")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x6000AEF")]
			[Address(RVA = "0x7ACC94", Offset = "0x7ACC94", VA = "0x7ACC94")]
			public <>c__DisplayClass36_0()
			{
			}

			[Token(Token = "0x6000AF0")]
			[Address(RVA = "0x7ADFFC", Offset = "0x7ADFFC", VA = "0x7ADFFC")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000AF1")]
			[Address(RVA = "0x7AE020", Offset = "0x7AE020", VA = "0x7AE020")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20001F5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB844", Offset = "0x5FB844")]
		private sealed class <>c__DisplayClass37_0
		{
			[Token(Token = "0x4000868")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x6000AF2")]
			[Address(RVA = "0x7ACE70", Offset = "0x7ACE70", VA = "0x7ACE70")]
			public <>c__DisplayClass37_0()
			{
			}

			[Token(Token = "0x6000AF3")]
			[Address(RVA = "0x7AE044", Offset = "0x7AE044", VA = "0x7AE044")]
			internal string <DOText>b__0()
			{
				return null;
			}

			[Token(Token = "0x6000AF4")]
			[Address(RVA = "0x7AE068", Offset = "0x7AE068", VA = "0x7AE068")]
			internal void <DOText>b__1(string x)
			{
			}
		}

		[Token(Token = "0x20001F6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB854", Offset = "0x5FB854")]
		private sealed class <>c__DisplayClass38_0
		{
			[Token(Token = "0x4000869")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x400086A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Graphic target;

			[Token(Token = "0x6000AF5")]
			[Address(RVA = "0x7AD064", Offset = "0x7AD064", VA = "0x7AD064")]
			public <>c__DisplayClass38_0()
			{
			}

			[Token(Token = "0x6000AF6")]
			[Address(RVA = "0x7AE08C", Offset = "0x7AE08C", VA = "0x7AE08C")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000AF7")]
			[Address(RVA = "0x7AE098", Offset = "0x7AE098", VA = "0x7AE098")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20001F7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB864", Offset = "0x5FB864")]
		private sealed class <>c__DisplayClass39_0
		{
			[Token(Token = "0x400086B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x400086C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Image target;

			[Token(Token = "0x6000AF8")]
			[Address(RVA = "0x7AD258", Offset = "0x7AD258", VA = "0x7AD258")]
			public <>c__DisplayClass39_0()
			{
			}

			[Token(Token = "0x6000AF9")]
			[Address(RVA = "0x7AE154", Offset = "0x7AE154", VA = "0x7AE154")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000AFA")]
			[Address(RVA = "0x7AE160", Offset = "0x7AE160", VA = "0x7AE160")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20001F8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB874", Offset = "0x5FB874")]
		private sealed class <>c__DisplayClass40_0
		{
			[Token(Token = "0x400086D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x400086E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Text target;

			[Token(Token = "0x6000AFB")]
			[Address(RVA = "0x7AD44C", Offset = "0x7AD44C", VA = "0x7AD44C")]
			public <>c__DisplayClass40_0()
			{
			}

			[Token(Token = "0x6000AFC")]
			[Address(RVA = "0x7AE264", Offset = "0x7AE264", VA = "0x7AE264")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000AFD")]
			[Address(RVA = "0x7AE270", Offset = "0x7AE270", VA = "0x7AE270")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x6000881")]
		[Address(RVA = "0x7A95B4", Offset = "0x7A95B4", VA = "0x7A95B4")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this CanvasGroup target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000882")]
		[Address(RVA = "0x7A96F8", Offset = "0x7A96F8", VA = "0x7A96F8")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000883")]
		[Address(RVA = "0x7A9864", Offset = "0x7A9864", VA = "0x7A9864")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Graphic target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000884")]
		[Address(RVA = "0x7A99A8", Offset = "0x7A99A8", VA = "0x7A99A8")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000885")]
		[Address(RVA = "0x7A9B14", Offset = "0x7A9B14", VA = "0x7A9B14")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000886")]
		[Address(RVA = "0x7A9C58", Offset = "0x7A9C58", VA = "0x7A9C58")]
		public static TweenerCore<float, float, FloatOptions> DOFillAmount(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000887")]
		[Address(RVA = "0x7A9DC0", Offset = "0x7A9DC0", VA = "0x7A9DC0")]
		public static Sequence DOGradientColor(this Image target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000888")]
		[Address(RVA = "0x7A9FA0", Offset = "0x7A9FA0", VA = "0x7A9FA0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOFlexibleSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000889")]
		[Address(RVA = "0x7AA104", Offset = "0x7AA104", VA = "0x7AA104")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMinSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600088A")]
		[Address(RVA = "0x7AA268", Offset = "0x7AA268", VA = "0x7AA268")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPreferredSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600088B")]
		[Address(RVA = "0x7AA3CC", Offset = "0x7AA3CC", VA = "0x7AA3CC")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Outline target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600088C")]
		[Address(RVA = "0x7AA538", Offset = "0x7AA538", VA = "0x7AA538")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Outline target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600088D")]
		[Address(RVA = "0x7AA67C", Offset = "0x7AA67C", VA = "0x7AA67C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOScale(this Outline target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600088E")]
		[Address(RVA = "0x7AA7D0", Offset = "0x7AA7D0", VA = "0x7AA7D0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPos(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600088F")]
		[Address(RVA = "0x7AA934", Offset = "0x7AA934", VA = "0x7AA934")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000890")]
		[Address(RVA = "0x7AAAAC", Offset = "0x7AAAAC", VA = "0x7AAAAC")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000891")]
		[Address(RVA = "0x7AAC24", Offset = "0x7AAC24", VA = "0x7AAC24")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3D(this RectTransform target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000892")]
		[Address(RVA = "0x7AAD90", Offset = "0x7AAD90", VA = "0x7AAD90")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000893")]
		[Address(RVA = "0x7AAF14", Offset = "0x7AAF14", VA = "0x7AAF14")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000894")]
		[Address(RVA = "0x7AB098", Offset = "0x7AB098", VA = "0x7AB098")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DZ(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000895")]
		[Address(RVA = "0x7AB21C", Offset = "0x7AB21C", VA = "0x7AB21C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMax(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000896")]
		[Address(RVA = "0x7AB380", Offset = "0x7AB380", VA = "0x7AB380")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMin(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000897")]
		[Address(RVA = "0x7AB4E4", Offset = "0x7AB4E4", VA = "0x7AB4E4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivot(this RectTransform target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000898")]
		[Address(RVA = "0x7AB638", Offset = "0x7AB638", VA = "0x7AB638")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotX(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000899")]
		[Address(RVA = "0x7AB7A4", Offset = "0x7AB7A4", VA = "0x7AB7A4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotY(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600089A")]
		[Address(RVA = "0x7AB910", Offset = "0x7AB910", VA = "0x7AB910")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOSizeDelta(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600089B")]
		[Address(RVA = "0x7ABA74", Offset = "0x7ABA74", VA = "0x7ABA74")]
		public static Tweener DOPunchAnchorPos(this RectTransform target, Vector2 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600089C")]
		[Address(RVA = "0x7ABC2C", Offset = "0x7ABC2C", VA = "0x7ABC2C")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, float strength = 100f, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x600089D")]
		[Address(RVA = "0x7ABDB4", Offset = "0x7ABDB4", VA = "0x7ABDB4")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, Vector2 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x600089E")]
		[Address(RVA = "0x7ABF88", Offset = "0x7ABF88", VA = "0x7ABF88")]
		public static Sequence DOJumpAnchorPos(this RectTransform target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600089F")]
		[Address(RVA = "0x7AC30C", Offset = "0x7AC30C", VA = "0x7AC30C")]
		public static Tweener DONormalizedPos(this ScrollRect target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60008A0")]
		[Address(RVA = "0x7AC464", Offset = "0x7AC464", VA = "0x7AC464")]
		public static Tweener DOHorizontalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60008A1")]
		[Address(RVA = "0x7AC5AC", Offset = "0x7AC5AC", VA = "0x7AC5AC")]
		public static Tweener DOVerticalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60008A2")]
		[Address(RVA = "0x7AC6F4", Offset = "0x7AC6F4", VA = "0x7AC6F4")]
		public static TweenerCore<float, float, FloatOptions> DOValue(this Slider target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60008A3")]
		[Address(RVA = "0x7AC848", Offset = "0x7AC848", VA = "0x7AC848")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Text target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60008A4")]
		[Address(RVA = "0x7AC9B4", Offset = "0x7AC9B4", VA = "0x7AC9B4")]
		public static TweenerCore<int, int, NoOptions> DOCounter(this Text target, int fromValue, int endValue, float duration, bool addThousandsSeparator = true, [Optional] CultureInfo culture)
		{
			return null;
		}

		[Token(Token = "0x60008A5")]
		[Address(RVA = "0x7ACB58", Offset = "0x7ACB58", VA = "0x7ACB58")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Text target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60008A6")]
		[Address(RVA = "0x7ACC9C", Offset = "0x7ACC9C", VA = "0x7ACC9C")]
		public static TweenerCore<string, string, StringOptions> DOText(this Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
		{
			return null;
		}

		[Token(Token = "0x60008A7")]
		[Address(RVA = "0x7ACE78", Offset = "0x7ACE78", VA = "0x7ACE78")]
		public static Tweener DOBlendableColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60008A8")]
		[Address(RVA = "0x7AD06C", Offset = "0x7AD06C", VA = "0x7AD06C")]
		public static Tweener DOBlendableColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60008A9")]
		[Address(RVA = "0x7AD260", Offset = "0x7AD260", VA = "0x7AD260")]
		public static Tweener DOBlendableColor(this Text target, Color endValue, float duration)
		{
			return null;
		}
	}
	[Token(Token = "0x2000137")]
	public static class DOTweenModuleUnityVersion
	{
		[Token(Token = "0x20001F9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB884", Offset = "0x5FB884")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x400086F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Material target;

			[Token(Token = "0x4000870")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int propertyID;

			[Token(Token = "0x6000AFE")]
			[Address(RVA = "0x7AF348", Offset = "0x7AF348", VA = "0x7AF348")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x6000AFF")]
			[Address(RVA = "0x7AFAD8", Offset = "0x7AFAD8", VA = "0x7AFAD8")]
			internal Vector2 <DOOffset>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000B00")]
			[Address(RVA = "0x7AFAFC", Offset = "0x7AFAFC", VA = "0x7AFAFC")]
			internal void <DOOffset>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20001FA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB894", Offset = "0x5FB894")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x4000871")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Material target;

			[Token(Token = "0x4000872")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int propertyID;

			[Token(Token = "0x6000B01")]
			[Address(RVA = "0x7AF510", Offset = "0x7AF510", VA = "0x7AF510")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x6000B02")]
			[Address(RVA = "0x7AFB20", Offset = "0x7AFB20", VA = "0x7AFB20")]
			internal Vector2 <DOTiling>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000B03")]
			[Address(RVA = "0x7AFB44", Offset = "0x7AFB44", VA = "0x7AFB44")]
			internal void <DOTiling>b__1(Vector2 x)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20001FB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB8A4", Offset = "0x5FB8A4")]
		private struct <AsyncWaitForCompletion>d__10 : IAsyncStateMachine
		{
			[Token(Token = "0x4000873")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000874")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000875")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x4000876")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x6000B04")]
			[Address(RVA = "0x7AFB68", Offset = "0x7AFB68", VA = "0x7AFB68", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000B05")]
			[Address(RVA = "0x7AFDAC", Offset = "0x7AFDAC", VA = "0x7AFDAC", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20001FC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB8B4", Offset = "0x5FB8B4")]
		private struct <AsyncWaitForRewind>d__11 : IAsyncStateMachine
		{
			[Token(Token = "0x4000877")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000878")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000879")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x400087A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x6000B06")]
			[Address(RVA = "0x7B04BC", Offset = "0x7B04BC", VA = "0x7B04BC", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000B07")]
			[Address(RVA = "0x7B0724", Offset = "0x7B0724", VA = "0x7B0724", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20001FD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB8C4", Offset = "0x5FB8C4")]
		private struct <AsyncWaitForKill>d__12 : IAsyncStateMachine
		{
			[Token(Token = "0x400087B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400087C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x400087D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x400087E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x6000B08")]
			[Address(RVA = "0x7B0010", Offset = "0x7B0010", VA = "0x7B0010", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000B09")]
			[Address(RVA = "0x7B0240", Offset = "0x7B0240", VA = "0x7B0240", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20001FE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB8D4", Offset = "0x5FB8D4")]
		private struct <AsyncWaitForElapsedLoops>d__13 : IAsyncStateMachine
		{
			[Token(Token = "0x400087F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000880")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000881")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x4000882")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int elapsedLoops;

			[Token(Token = "0x4000883")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x6000B0A")]
			[Address(RVA = "0x7AFDB8", Offset = "0x7AFDB8", VA = "0x7AFDB8", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000B0B")]
			[Address(RVA = "0x7B0004", Offset = "0x7B0004", VA = "0x7B0004", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20001FF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB8E4", Offset = "0x5FB8E4")]
		private struct <AsyncWaitForPosition>d__14 : IAsyncStateMachine
		{
			[Token(Token = "0x4000884")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000885")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000886")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x4000887")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float position;

			[Token(Token = "0x4000888")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x6000B0C")]
			[Address(RVA = "0x7B024C", Offset = "0x7B024C", VA = "0x7B024C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000B0D")]
			[Address(RVA = "0x7B04B0", Offset = "0x7B04B0", VA = "0x7B04B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000200")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FB8F4", Offset = "0x5FB8F4")]
		private struct <AsyncWaitForStart>d__15 : IAsyncStateMachine
		{
			[Token(Token = "0x4000889")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400088A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x400088B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x400088C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x6000B0E")]
			[Address(RVA = "0x7B0730", Offset = "0x7B0730", VA = "0x7B0730", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000B0F")]
			[Address(RVA = "0x7B0968", Offset = "0x7B0968", VA = "0x7B0968", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x60008AA")]
		[Address(RVA = "0x7AE8EC", Offset = "0x7AE8EC", VA = "0x7AE8EC")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x60008AB")]
		[Address(RVA = "0x7AEAC8", Offset = "0x7AEAC8", VA = "0x7AEAC8")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, string property, float duration)
		{
			return null;
		}

		[Token(Token = "0x60008AC")]
		[Address(RVA = "0x7AECB8", Offset = "0x7AECB8", VA = "0x7AECB8")]
		public static CustomYieldInstruction WaitForCompletion(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60008AD")]
		[Address(RVA = "0x7AED80", Offset = "0x7AED80", VA = "0x7AED80")]
		public static CustomYieldInstruction WaitForRewind(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60008AE")]
		[Address(RVA = "0x7AEE48", Offset = "0x7AEE48", VA = "0x7AEE48")]
		public static CustomYieldInstruction WaitForKill(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60008AF")]
		[Address(RVA = "0x7AEF10", Offset = "0x7AEF10", VA = "0x7AEF10")]
		public static CustomYieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60008B0")]
		[Address(RVA = "0x7AEFE8", Offset = "0x7AEFE8", VA = "0x7AEFE8")]
		public static CustomYieldInstruction WaitForPosition(this Tween t, float position, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60008B1")]
		[Address(RVA = "0x7AF0C0", Offset = "0x7AF0C0", VA = "0x7AF0C0")]
		public static CustomYieldInstruction WaitForStart(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60008B2")]
		[Address(RVA = "0x7AF188", Offset = "0x7AF188", VA = "0x7AF188")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}

		[Token(Token = "0x60008B3")]
		[Address(RVA = "0x7AF350", Offset = "0x7AF350", VA = "0x7AF350")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}

		[Token(Token = "0x60008B4")]
		[Address(RVA = "0x7AF518", Offset = "0x7AF518", VA = "0x7AF518")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x5FF768", Offset = "0x5FF768")]
		public static Task AsyncWaitForCompletion(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x60008B5")]
		[Address(RVA = "0x7AF608", Offset = "0x7AF608", VA = "0x7AF608")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x5FF7DC", Offset = "0x5FF7DC")]
		public static Task AsyncWaitForRewind(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x60008B6")]
		[Address(RVA = "0x7AF6F8", Offset = "0x7AF6F8", VA = "0x7AF6F8")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x5FF850", Offset = "0x5FF850")]
		public static Task AsyncWaitForKill(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x60008B7")]
		[Address(RVA = "0x7AF7E8", Offset = "0x7AF7E8", VA = "0x7AF7E8")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x5FF8C4", Offset = "0x5FF8C4")]
		public static Task AsyncWaitForElapsedLoops(this Tween t, int elapsedLoops)
		{
			return null;
		}

		[Token(Token = "0x60008B8")]
		[Address(RVA = "0x7AF8E8", Offset = "0x7AF8E8", VA = "0x7AF8E8")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x5FF938", Offset = "0x5FF938")]
		public static Task AsyncWaitForPosition(this Tween t, float position)
		{
			return null;
		}

		[Token(Token = "0x60008B9")]
		[Address(RVA = "0x7AF9E8", Offset = "0x7AF9E8", VA = "0x7AF9E8")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x5FF9AC", Offset = "0x5FF9AC")]
		public static Task AsyncWaitForStart(this Tween t)
		{
			return null;
		}
	}
	[Token(Token = "0x2000138")]
	public static class DOTweenCYInstruction
	{
		[Token(Token = "0x2000201")]
		public class WaitForCompletion : CustomYieldInstruction
		{
			[Token(Token = "0x400088D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x17000112")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000B10")]
				[Address(RVA = "0x7A548C", Offset = "0x7A548C", VA = "0x7A548C", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000B11")]
			[Address(RVA = "0x7A54C0", Offset = "0x7A54C0", VA = "0x7A54C0")]
			public WaitForCompletion(Tween tween)
			{
			}
		}

		[Token(Token = "0x2000202")]
		public class WaitForRewind : CustomYieldInstruction
		{
			[Token(Token = "0x400088E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x17000113")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000B12")]
				[Address(RVA = "0x7A565C", Offset = "0x7A565C", VA = "0x7A565C", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000B13")]
			[Address(RVA = "0x7A56C0", Offset = "0x7A56C0", VA = "0x7A56C0")]
			public WaitForRewind(Tween tween)
			{
			}
		}

		[Token(Token = "0x2000203")]
		public class WaitForKill : CustomYieldInstruction
		{
			[Token(Token = "0x400088F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x17000114")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000B14")]
				[Address(RVA = "0x7A5574", Offset = "0x7A5574", VA = "0x7A5574", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000B15")]
			[Address(RVA = "0x7A5590", Offset = "0x7A5590", VA = "0x7A5590")]
			public WaitForKill(Tween tween)
			{
			}
		}

		[Token(Token = "0x2000204")]
		public class WaitForElapsedLoops : CustomYieldInstruction
		{
			[Token(Token = "0x4000890")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x4000891")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly int elapsedLoops;

			[Token(Token = "0x17000115")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000B16")]
				[Address(RVA = "0x7A54EC", Offset = "0x7A54EC", VA = "0x7A54EC", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000B17")]
			[Address(RVA = "0x7A5538", Offset = "0x7A5538", VA = "0x7A5538")]
			public WaitForElapsedLoops(Tween tween, int elapsedLoops)
			{
			}
		}

		[Token(Token = "0x2000205")]
		public class WaitForPosition : CustomYieldInstruction
		{
			[Token(Token = "0x4000892")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x4000893")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly float position;

			[Token(Token = "0x17000116")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000B18")]
				[Address(RVA = "0x7A55BC", Offset = "0x7A55BC", VA = "0x7A55BC", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000B19")]
			[Address(RVA = "0x7A5620", Offset = "0x7A5620", VA = "0x7A5620")]
			public WaitForPosition(Tween tween, float position)
			{
			}
		}

		[Token(Token = "0x2000206")]
		public class WaitForStart : CustomYieldInstruction
		{
			[Token(Token = "0x4000894")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x17000117")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000B1A")]
				[Address(RVA = "0x7A56EC", Offset = "0x7A56EC", VA = "0x7A56EC", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000B1B")]
			[Address(RVA = "0x7A5720", Offset = "0x7A5720", VA = "0x7A5720")]
			public WaitForStart(Tween tween)
			{
			}
		}
	}
	[Token(Token = "0x2000139")]
	public static class DOTweenModuleUtils
	{
		[Token(Token = "0x2000207")]
		public static class Physics
		{
			[Token(Token = "0x6000B1C")]
			[Address(RVA = "0x7B0AB8", Offset = "0x7B0AB8", VA = "0x7B0AB8")]
			public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
			{
			}

			[Token(Token = "0x6000B1D")]
			[Address(RVA = "0x7B0BC0", Offset = "0x7B0BC0", VA = "0x7B0BC0")]
			public static bool HasRigidbody2D(UnityEngine.Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x6000B1E")]
			[Address(RVA = "0x7B0C50", Offset = "0x7B0C50", VA = "0x7B0C50")]
			[Preserve]
			public static bool HasRigidbody(UnityEngine.Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x6000B1F")]
			[Address(RVA = "0x7B0CE0", Offset = "0x7B0CE0", VA = "0x7B0CE0")]
			[Preserve]
			public static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> CreateDOTweenPathTween(MonoBehaviour target, bool tweenRigidbody, bool isLocal, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, PathMode pathMode)
			{
				return null;
			}
		}

		[Token(Token = "0x4000624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool _initialized;

		[Token(Token = "0x60008BA")]
		[Address(RVA = "0x7B0974", Offset = "0x7B0974", VA = "0x7B0974")]
		[Preserve]
		public static void Init()
		{
		}

		[Token(Token = "0x60008BB")]
		[Address(RVA = "0x7B0A18", Offset = "0x7B0A18", VA = "0x7B0A18")]
		[Preserve]
		private static void Preserver()
		{
		}
	}
}
