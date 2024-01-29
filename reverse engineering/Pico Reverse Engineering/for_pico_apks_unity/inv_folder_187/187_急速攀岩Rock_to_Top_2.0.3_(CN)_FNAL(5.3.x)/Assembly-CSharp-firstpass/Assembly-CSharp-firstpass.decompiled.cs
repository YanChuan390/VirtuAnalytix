using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class QueryGameClass : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x0")]
	public static QueryGameClass instance;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x10019F4", Offset = "0x10019F4", VA = "0x10019F4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000002")]
	public string UserDataToJson<T>(T data)
	{
		return null;
	}

	[Token(Token = "0x6000003")]
	public T JsonToData<T>(string jsondata)
	{
		return (T)null;
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x1001A48", Offset = "0x1001A48", VA = "0x1001A48")]
	public QueryGameClass()
	{
	}
}
[Serializable]
[Token(Token = "0x2000003")]
public class ListItem
{
	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x10")]
	public int page;

	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x14")]
	public int rows;

	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x18")]
	public int id;

	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x1C")]
	public int userId;

	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x20")]
	public int gameId;

	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x28")]
	public string gameName;

	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x30")]
	public int shopId;

	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x38")]
	public string shopName;

	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x40")]
	public int barrier;

	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x44")]
	public int score;

	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x48")]
	public string gameProgress;

	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x50")]
	public string gameStoreDt;

	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0x58")]
	public string createDt;

	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x60")]
	public string reqId;

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x10019EC", Offset = "0x10019EC", VA = "0x10019EC")]
	public ListItem()
	{
	}
}
[Serializable]
[Token(Token = "0x2000004")]
public class Data
{
	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x10")]
	public int total;

	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x18")]
	public List<ListItem> list;

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x100197C", Offset = "0x100197C", VA = "0x100197C")]
	public Data()
	{
	}
}
[Serializable]
[Token(Token = "0x2000005")]
public class Root
{
	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0x10")]
	public int retCode;

	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0x18")]
	public Data data;

	[Token(Token = "0x4000014")]
	[FieldOffset(Offset = "0x20")]
	public string reqId;

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x1001A50", Offset = "0x1001A50", VA = "0x1001A50")]
	public Root()
	{
	}
}
[Token(Token = "0x2000006")]
public class TeachPanel : MonoBehaviour
{
	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0x18")]
	public Button EnterButton;

	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0x20")]
	public Text TeachText;

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x1001AB4", Offset = "0x1001AB4", VA = "0x1001AB4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x1001B48", Offset = "0x1001B48", VA = "0x1001B48")]
	private void OnEnterButton()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x1001B50", Offset = "0x1001B50", VA = "0x1001B50")]
	public void InitTeachPanel(string str)
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x1001B74", Offset = "0x1001B74", VA = "0x1001B74")]
	public TeachPanel()
	{
	}
}
