using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Weelco.VRKeyboard;

[Token(Token = "0x2000002")]
public abstract class VRKeyboardBase : VRKeyboardData
{
	[Token(Token = "0x2000003")]
	public delegate void VRKeyboardBtnClick(string value);

	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x18")]
	public VRKeyboardBtnClick OnVRKeyboardBtnClick;

	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x20")]
	protected bool Initialized;

	[Token(Token = "0x6000001")]
	public abstract void Init();

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x288449C", Offset = "0x288449C", VA = "0x288449C")]
	protected VRKeyboardBase()
	{
	}
}
[Token(Token = "0x2000004")]
public class VRKeyboardButton : VRKeyboardBase
{
	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x28")]
	private Button button;

	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x30")]
	private Text label;

	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x38")]
	private Image icon;

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x28845F4", Offset = "0x28845F4", VA = "0x28845F4")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x288469C", Offset = "0x288469C", VA = "0x288469C", Slot = "4")]
	public override void Init()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x28848CC", Offset = "0x28848CC", VA = "0x28848CC")]
	public void SetKeyText(string value, bool ignoreIcon = false)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x288499C", Offset = "0x288499C", VA = "0x288499C")]
	private void HandleClick()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x28849E8", Offset = "0x28849E8", VA = "0x28849E8")]
	public VRKeyboardButton()
	{
	}
}
[Token(Token = "0x2000005")]
public abstract class VRKeyboardData : MonoBehaviour
{
	[Token(Token = "0x4000006")]
	public const string ABC = "abc";

	[Token(Token = "0x4000007")]
	public const string SYM = "sym";

	[Token(Token = "0x4000008")]
	public const string NUM = "123";

	[Token(Token = "0x4000009")]
	public const string BACK = "BACK";

	[Token(Token = "0x400000A")]
	public const string ENTER = "ENTER";

	[Token(Token = "0x400000B")]
	public const string UP = "UP";

	[Token(Token = "0x400000C")]
	public const string LOW = "LOW";

	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string[] allLettersLowercase;

	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0x8")]
	public static readonly string[] allLettersUppercase;

	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x10")]
	public static readonly string[] allSpecials;

	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x18")]
	public static readonly string[] extraLettersLowercase;

	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x20")]
	public static readonly string[] extraLettersUppercase;

	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0x28")]
	public static readonly string[] extraSpecials;

	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0x30")]
	public static readonly string[] liteSpecials;

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x28844F4", Offset = "0x28844F4", VA = "0x28844F4")]
	protected VRKeyboardData()
	{
	}
}
[Token(Token = "0x2000006")]
public class VRKeyboardExtra : VRKeyboardBase
{
	[Token(Token = "0x4000014")]
	[FieldOffset(Offset = "0x28")]
	private GameObject keysLetters;

	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0x30")]
	private GameObject keysSpecials;

	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0x38")]
	private IDictionary<GameObject, VRKeyboardButton[]> keysDict;

	[Token(Token = "0x4000017")]
	[FieldOffset(Offset = "0x40")]
	private bool areLettersActive;

	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0x41")]
	private bool isLowercase;

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x2889CB0", Offset = "0x2889CB0", VA = "0x2889CB0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x288A0B8", Offset = "0x288A0B8", VA = "0x288A0B8", Slot = "4")]
	public override void Init()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x288AA9C", Offset = "0x288AA9C", VA = "0x288AA9C")]
	private void HandleClick(string value)
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x288A740", Offset = "0x288A740", VA = "0x288A740")]
	private void ChangeSpecialLetters()
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x288A940", Offset = "0x288A940", VA = "0x288A940")]
	private void LowerUpperKeys()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x288ABB8", Offset = "0x288ABB8", VA = "0x288ABB8")]
	public VRKeyboardExtra()
	{
	}
}
[Token(Token = "0x2000007")]
public class VRKeyboardFull : VRKeyboardBase
{
	[Token(Token = "0x4000019")]
	[FieldOffset(Offset = "0x28")]
	private VRKeyboardButton[] keys;

	[Token(Token = "0x400001A")]
	[FieldOffset(Offset = "0x30")]
	private bool areLettersActive;

	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0x31")]
	private bool isLowercase;

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x288ABBC", Offset = "0x288ABBC", VA = "0x288ABBC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x288ACE8", Offset = "0x288ACE8", VA = "0x288ACE8", Slot = "4")]
	public override void Init()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x288AEEC", Offset = "0x288AEEC", VA = "0x288AEEC")]
	private void HandleClick(string value)
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x288B008", Offset = "0x288B008", VA = "0x288B008")]
	private void ChangeSpecialLetters()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x288B164", Offset = "0x288B164", VA = "0x288B164")]
	private void LowerUpperKeys()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x288B234", Offset = "0x288B234", VA = "0x288B234")]
	public VRKeyboardFull()
	{
	}
}
[Token(Token = "0x2000008")]
public class VRKeyboardLite : VRKeyboardBase
{
	[Token(Token = "0x400001C")]
	[FieldOffset(Offset = "0x28")]
	private VRKeyboardButton[] keys;

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x288B240", Offset = "0x288B240", VA = "0x288B240")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x288B36C", Offset = "0x288B36C", VA = "0x288B36C", Slot = "4")]
	public override void Init()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x288B570", Offset = "0x288B570", VA = "0x288B570")]
	private void HandleClick(string value)
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x288B58C", Offset = "0x288B58C", VA = "0x288B58C")]
	public VRKeyboardLite()
	{
	}
}
