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
	[Address(RVA = "0x299A2A4", Offset = "0x299A2A4", VA = "0x299A2A4")]
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
	[Address(RVA = "0x299A3CC", Offset = "0x299A3CC", VA = "0x299A3CC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x299A474", Offset = "0x299A474", VA = "0x299A474", Slot = "4")]
	public override void Init()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x299A6A4", Offset = "0x299A6A4", VA = "0x299A6A4")]
	public void SetKeyText(string value, bool ignoreIcon = false)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x299A774", Offset = "0x299A774", VA = "0x299A774")]
	private void HandleClick()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x299A7C0", Offset = "0x299A7C0", VA = "0x299A7C0")]
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
	[Address(RVA = "0x299A2FC", Offset = "0x299A2FC", VA = "0x299A2FC")]
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
	[Address(RVA = "0x299FA88", Offset = "0x299FA88", VA = "0x299FA88")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x299FE90", Offset = "0x299FE90", VA = "0x299FE90", Slot = "4")]
	public override void Init()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x29A0874", Offset = "0x29A0874", VA = "0x29A0874")]
	private void HandleClick(string value)
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x29A0518", Offset = "0x29A0518", VA = "0x29A0518")]
	private void ChangeSpecialLetters()
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x29A0718", Offset = "0x29A0718", VA = "0x29A0718")]
	private void LowerUpperKeys()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x29A0990", Offset = "0x29A0990", VA = "0x29A0990")]
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
	[Address(RVA = "0x29A0994", Offset = "0x29A0994", VA = "0x29A0994")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x29A0AC0", Offset = "0x29A0AC0", VA = "0x29A0AC0", Slot = "4")]
	public override void Init()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x29A0CC4", Offset = "0x29A0CC4", VA = "0x29A0CC4")]
	private void HandleClick(string value)
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x29A0DE0", Offset = "0x29A0DE0", VA = "0x29A0DE0")]
	private void ChangeSpecialLetters()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x29A0F3C", Offset = "0x29A0F3C", VA = "0x29A0F3C")]
	private void LowerUpperKeys()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x29A100C", Offset = "0x29A100C", VA = "0x29A100C")]
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
	[Address(RVA = "0x29A1018", Offset = "0x29A1018", VA = "0x29A1018")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x29A1144", Offset = "0x29A1144", VA = "0x29A1144", Slot = "4")]
	public override void Init()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x29A1348", Offset = "0x29A1348", VA = "0x29A1348")]
	private void HandleClick(string value)
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x29A1364", Offset = "0x29A1364", VA = "0x29A1364")]
	public VRKeyboardLite()
	{
	}
}
