using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using Helper;
using Il2CppDummyDll;
using NodeEditorFramework;
using NodeEditorFramework.Utilities;
using UnityEngine;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class NodeCanvasSceneSave : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public NodeCanvas savedNodeCanvas;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x127449C", Offset = "0x127449C", VA = "0x127449C")]
	public NodeCanvasSceneSave()
	{
	}
}
[Token(Token = "0x2000003")]
[AttributeAttribute(Name = "NodeCanvasTypeAttribute", RVA = "0x73E0AC", Offset = "0x73E0AC")]
public class ScenarioCanvas : NodeCanvas
{
	[Token(Token = "0x2000004")]
	public enum MissionTier
	{
		[Token(Token = "0x400002A")]
		Easy,
		[Token(Token = "0x400002B")]
		Medium,
		[Token(Token = "0x400002C")]
		Hard,
		[Token(Token = "0x400002D")]
		Impossible
	}

	[Token(Token = "0x2000005")]
	public enum MapRegion
	{
		[Token(Token = "0x400002F")]
		Terran,
		[Token(Token = "0x4000030")]
		Entirrizi,
		[Token(Token = "0x4000031")]
		Grethon,
		[Token(Token = "0x4000032")]
		Kakko,
		[Token(Token = "0x4000033")]
		Vistian,
		[Token(Token = "0x4000034")]
		AkudatDow,
		[Token(Token = "0x4000035")]
		Feluusi,
		[Token(Token = "0x4000036")]
		Finchuri,
		[Token(Token = "0x4000037")]
		Boix,
		[Token(Token = "0x4000038")]
		Rift,
		[Token(Token = "0x4000039")]
		Watchers
	}

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static string[] shipList;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static string[] speakerList;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static string[] allItemNames;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static string[] allKeys;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static string[] allAchievements;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static string[] allUnlocks;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x741C0C", Offset = "0x741C0C")]
	public string title;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string subTitle;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "TextAreaAttribute", RVA = "0x741C44", Offset = "0x741C44")]
	public string desc;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public string guid;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool priorityMission;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
	public bool countsTowardsTierEnd;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x741C5C", Offset = "0x741C5C")]
	public bool rewardRes;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public int rewardResAmount;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool rewardShip;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public string rewardShipName;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool rewardItem;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public string rewardItemName;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public bool rewardRepair;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
	public bool rewardScrap;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public int rewardScrapAmount;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public bool rewardProc;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public string specialRewardText;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public bool starbase;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
	public bool hasStore;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public int timeLimit;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public int minimumOrder;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public string requiredKey;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public string requiredNotKey;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public string requiredGuid;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public int minimumTier;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public List<string> effects;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public string faction;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public MapRegion mapRegion;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	public MissionTier difficulty;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x741C94", Offset = "0x741C94")]
	public GameObject premadeScene;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public GameObject curiosity;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public bool excludeFromTranslation;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public string scenarioTextKey;

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x1717134", Offset = "0x1717134", VA = "0x1717134")]
	public void InitScenario()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x17178B8", Offset = "0x17178B8", VA = "0x17178B8")]
	public ScenarioCanvas()
	{
	}
}
[Token(Token = "0x2000006")]
[AttributeAttribute(Name = "NodeAttribute", RVA = "0x73E0E4", Offset = "0x73E0E4")]
public class AchievementNode : ScenarioNodeBase
{
	[Token(Token = "0x400003A")]
	private const string Id = "AchievementNode";

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public int achievementId;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public string achievementName;

	[Token(Token = "0x17000001")]
	public override string GetID
	{
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x187424C", Offset = "0x187424C", VA = "0x187424C", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000002")]
	public override Type GetObjectType
	{
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x1874290", Offset = "0x1874290", VA = "0x1874290", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x1874308", Offset = "0x1874308", VA = "0x1874308", Slot = "5")]
	public override Node Create(Vector2 pos)
	{
		return null;
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x1874444", Offset = "0x1874444", VA = "0x1874444")]
	public AchievementNode()
	{
	}
}
[Token(Token = "0x2000007")]
[AttributeAttribute(Name = "NodeAttribute", RVA = "0x73E190", Offset = "0x73E190")]
public class BeginCombat : ScenarioNodeBase
{
	[Token(Token = "0x2000008")]
	public enum GoalTypes
	{
		[Token(Token = "0x4000045")]
		Victory,
		[Token(Token = "0x4000046")]
		Escape,
		[Token(Token = "0x4000047")]
		Capture,
		[Token(Token = "0x4000048")]
		VictoryAndCapture,
		[Token(Token = "0x4000049")]
		Survive,
		[Token(Token = "0x400004A")]
		Protect
	}

	[Token(Token = "0x400003D")]
	private const string Id = "BeginCombat";

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GoalTypes goal;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public float initialScale;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public int musicTrackOverride;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public int failMusicOverride;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public int successMusicOverride;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public bool resourceIntensive;

	[Token(Token = "0x17000003")]
	public override string GetID
	{
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x1875520", Offset = "0x1875520", VA = "0x1875520", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000004")]
	public override Type GetObjectType
	{
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x1875564", Offset = "0x1875564", VA = "0x1875564", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x18755DC", Offset = "0x18755DC", VA = "0x18755DC", Slot = "9")]
	public override void CheckSize()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x1875690", Offset = "0x1875690", VA = "0x1875690", Slot = "5")]
	public override Node Create(Vector2 pos)
	{
		return null;
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x18757FC", Offset = "0x18757FC", VA = "0x18757FC")]
	public ScenarioNodeBase GetSuccessNode()
	{
		return null;
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x1875938", Offset = "0x1875938", VA = "0x1875938")]
	public ScenarioNodeBase GetFailureNode()
	{
		return null;
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x1875A7C", Offset = "0x1875A7C", VA = "0x1875A7C", Slot = "6")]
	protected internal override void NodeGUI()
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x1875A80", Offset = "0x1875A80", VA = "0x1875A80")]
	public BeginCombat()
	{
	}
}
[Token(Token = "0x2000009")]
[AttributeAttribute(Name = "NodeAttribute", RVA = "0x73E23C", Offset = "0x73E23C")]
public class BridgeLightsNode : ScenarioNodeBase
{
	[Token(Token = "0x400004B")]
	private const string Id = "BridgeLightsNode";

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public int colorIndex;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public int styleIndex;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float rate;

	[Token(Token = "0x17000005")]
	public override string GetID
	{
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x18796E8", Offset = "0x18796E8", VA = "0x18796E8", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000006")]
	public override Type GetObjectType
	{
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x187972C", Offset = "0x187972C", VA = "0x187972C", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x18797A4", Offset = "0x18797A4", VA = "0x18797A4", Slot = "5")]
	public override Node Create(Vector2 pos)
	{
		return null;
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x18798E0", Offset = "0x18798E0", VA = "0x18798E0")]
	public BridgeLightsNode()
	{
	}
}
[Token(Token = "0x200000A")]
[AttributeAttribute(Name = "NodeAttribute", RVA = "0x73E2E8", Offset = "0x73E2E8")]
public class ChoiceNode : ScenarioNodeBase
{
	[Token(Token = "0x200000B")]
	public enum ChoiceRequirements
	{
		[Token(Token = "0x400005C")]
		None,
		[Token(Token = "0x400005D")]
		PayMoney,
		[Token(Token = "0x400005E")]
		HasShip,
		[Token(Token = "0x400005F")]
		HasItem
	}

	[Serializable]
	[Token(Token = "0x200000C")]
	public class OptionData
	{
		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string optionText;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int NodeOutputIndex;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public ChoiceRequirements requirementType;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string requirementValue;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string stringKey;

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x1A7D2A4", Offset = "0x1A7D2A4", VA = "0x1A7D2A4")]
		public OptionData()
		{
		}
	}

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public string mainText;

	[Token(Token = "0x4000050")]
	private const string Id = "ChoiceNode";

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public string speakerTitleCaption;

	[Token(Token = "0x4000052")]
	private const int StartValue = 137;

	[Token(Token = "0x4000053")]
	private const int SizeValue = 44;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public int speakerId;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public string speakerName;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public string animationName;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public bool glitched;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
	public bool factionSpecfic;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public string stringKey;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private List<OptionData> _options;

	[Token(Token = "0x17000007")]
	public override string GetID
	{
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x187C350", Offset = "0x187C350", VA = "0x187C350", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000008")]
	public override Type GetObjectType
	{
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x187C394", Offset = "0x187C394", VA = "0x187C394", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x187C40C", Offset = "0x187C40C", VA = "0x187C40C", Slot = "9")]
	public override void CheckSize()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x187C488", Offset = "0x187C488", VA = "0x187C488", Slot = "5")]
	public override Node Create(Vector2 pos)
	{
		return null;
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x187C818", Offset = "0x187C818", VA = "0x187C818", Slot = "6")]
	protected internal override void NodeGUI()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x187C81C", Offset = "0x187C81C", VA = "0x187C81C")]
	public void RemoveLastOption()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x187C65C", Offset = "0x187C65C", VA = "0x187C65C")]
	private void AddNewOption()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x187C990", Offset = "0x187C990", VA = "0x187C990")]
	public NodeOutput AddOption(OptionData option)
	{
		return null;
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x187CA8C", Offset = "0x187CA8C", VA = "0x187CA8C")]
	private void IssueEditorCallBacks()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x187CB50", Offset = "0x187CB50", VA = "0x187CB50")]
	public ScenarioNodeBase GetNodeForChoice(int num)
	{
		return null;
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x187CD18", Offset = "0x187CD18", VA = "0x187CD18")]
	public List<OptionData> GetAllOptions()
	{
		return null;
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x187CD90", Offset = "0x187CD90", VA = "0x187CD90")]
	public List<OptionData> GetRawOptions()
	{
		return null;
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x187CD98", Offset = "0x187CD98", VA = "0x187CD98")]
	public ChoiceNode()
	{
	}
}
[Token(Token = "0x200000D")]
[AttributeAttribute(Name = "NodeAttribute", RVA = "0x73E394", Offset = "0x73E394")]
public class EnvironmentNode : ScenarioNodeBase
{
	[Token(Token = "0x4000065")]
	private const string Id = "EnvironmentNode";

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static string[] environmentsList;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static int[] environmentsValues;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public int environmentType;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public bool hasHazard;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6D")]
	public bool ionStorms;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6E")]
	public bool spaceMines;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6F")]
	public bool fireballs;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public bool startPlayerClose;

	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public string missionNotes;

	[Token(Token = "0x17000009")]
	public override string GetID
	{
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x1266134", Offset = "0x1266134", VA = "0x1266134", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000A")]
	public override Type GetObjectType
	{
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x1266178", Offset = "0x1266178", VA = "0x1266178", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x12661F0", Offset = "0x12661F0", VA = "0x12661F0", Slot = "9")]
	public override void CheckSize()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x126626C", Offset = "0x126626C", VA = "0x126626C", Slot = "5")]
	public override Node Create(Vector2 pos)
	{
		return null;
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x1266330", Offset = "0x1266330", VA = "0x1266330", Slot = "22")]
	public override bool IsEntity()
	{
		return default(bool);
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x1266338", Offset = "0x1266338", VA = "0x1266338")]
	public EnvironmentNode()
	{
	}
}
[Serializable]
[Token(Token = "0x200000E")]
public struct FleetData
{
	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public int team;

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public float startDistFactor;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float startAngle;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public bool isAsset;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
	public bool captureRequired;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
	public bool isBounty;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
	public bool ambush;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public FleetNode.FormationType formation;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public bool respawns;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int forceTechLevel;
}
[Token(Token = "0x200000F")]
[AttributeAttribute(Name = "NodeAttribute", RVA = "0x73E440", Offset = "0x73E440")]
public class FleetNode : ScenarioNodeBase
{
	[Token(Token = "0x2000010")]
	public enum FormationType
	{
		[Token(Token = "0x4000084")]
		Line,
		[Token(Token = "0x4000085")]
		Delta,
		[Token(Token = "0x4000086")]
		Random,
		[Token(Token = "0x4000087")]
		InvertedDelta,
		[Token(Token = "0x4000088")]
		Starbase,
		[Token(Token = "0x4000089")]
		RandomCluster
	}

	[Serializable]
	[Token(Token = "0x2000011")]
	public class ShipData
	{
		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string shipName;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int shipId;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool isDamaged;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		public bool needsRescue;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
		public bool mediumDifficulty;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F")]
		public bool hardDifficulty;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool invulnerable;

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x1A7E2DC", Offset = "0x1A7E2DC", VA = "0x1A7E2DC")]
		public ShipData()
		{
		}
	}

	[Token(Token = "0x4000079")]
	private const string Id = "FleetNode";

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public FleetData fleetData;

	[Token(Token = "0x400007B")]
	private const int StartValue = 40;

	[Token(Token = "0x400007C")]
	private const int SizeValue = 25;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public bool useKey;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public string keyName;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public int keyId;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public bool isProcedural;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x95")]
	public bool isFriendlyFleet;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[SerializeField]
	private List<ShipData> _ships;

	[Token(Token = "0x1700000B")]
	public override string GetID
	{
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x126783C", Offset = "0x126783C", VA = "0x126783C", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000C")]
	public override Type GetObjectType
	{
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x1267880", Offset = "0x1267880", VA = "0x1267880", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x12678F8", Offset = "0x12678F8", VA = "0x12678F8", Slot = "5")]
	public override Node Create(Vector2 pos)
	{
		return null;
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x1267C44", Offset = "0x1267C44", VA = "0x1267C44", Slot = "22")]
	public override bool IsEntity()
	{
		return default(bool);
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x1267C4C", Offset = "0x1267C4C", VA = "0x1267C4C")]
	private void RemoveLastShip()
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x1267AB4", Offset = "0x1267AB4", VA = "0x1267AB4")]
	private void AddNewShip()
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x1267D6C", Offset = "0x1267D6C", VA = "0x1267D6C")]
	public List<ShipData> GetShips()
	{
		return null;
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x1267DE4", Offset = "0x1267DE4", VA = "0x1267DE4")]
	public FleetNode()
	{
	}
}
[Token(Token = "0x2000012")]
[AttributeAttribute(Name = "NodeAttribute", RVA = "0x73E4EC", Offset = "0x73E4EC")]
public class GameUnlockNode : ScenarioNodeBase
{
	[Token(Token = "0x4000091")]
	private const string Id = "GameUnlockNode";

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public string keyName;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public int keyId;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public bool infopediaNotify;

	[Token(Token = "0x1700000D")]
	public override string GetID
	{
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x126A0C4", Offset = "0x126A0C4", VA = "0x126A0C4", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000E")]
	public override Type GetObjectType
	{
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x126A108", Offset = "0x126A108", VA = "0x126A108", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x126A180", Offset = "0x126A180", VA = "0x126A180", Slot = "9")]
	public override void CheckSize()
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x126A234", Offset = "0x126A234", VA = "0x126A234", Slot = "5")]
	public override Node Create(Vector2 pos)
	{
		return null;
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x126A36C", Offset = "0x126A36C", VA = "0x126A36C")]
	public GameUnlockNode()
	{
	}
}
[Token(Token = "0x2000013")]
[AttributeAttribute(Name = "NodeAttribute", RVA = "0x73E598", Offset = "0x73E598")]
public class JoinFleetNode : ScenarioNodeBase
{
	[Token(Token = "0x4000095")]
	private const string Id = "JoinFleetNode";

	[Token(Token = "0x1700000F")]
	public override string GetID
	{
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x126C040", Offset = "0x126C040", VA = "0x126C040", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000010")]
	public override Type GetObjectType
	{
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x126C084", Offset = "0x126C084", VA = "0x126C084", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x126C0FC", Offset = "0x126C0FC", VA = "0x126C0FC", Slot = "5")]
	public override Node Create(Vector2 pos)
	{
		return null;
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x126C234", Offset = "0x126C234", VA = "0x126C234")]
	public JoinFleetNode()
	{
	}
}
[Token(Token = "0x2000014")]
[AttributeAttribute(Name = "NodeAttribute", RVA = "0x73E644", Offset = "0x73E644")]
public class KeyConditionNode : ScenarioNodeBase
{
	[Token(Token = "0x2000015")]
	public enum ConditionalEnum
	{
		[Token(Token = "0x400009C")]
		GTE,
		[Token(Token = "0x400009D")]
		LTE,
		[Token(Token = "0x400009E")]
		EQ
	}

	[Token(Token = "0x4000096")]
	private const string Id = "KeyConditionNode";

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public ConditionalEnum condition;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public int amount;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public string keyName;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public int keyId;

	[Token(Token = "0x17000011")]
	public override string GetID
	{
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x126C23C", Offset = "0x126C23C", VA = "0x126C23C", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000012")]
	public override Type GetObjectType
	{
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x126C280", Offset = "0x126C280", VA = "0x126C280", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x126C2F8", Offset = "0x126C2F8", VA = "0x126C2F8", Slot = "5")]
	public override Node Create(Vector2 pos)
	{
		return null;
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x126C464", Offset = "0x126C464", VA = "0x126C464")]
	public KeyConditionNode()
	{
	}
}
[Token(Token = "0x2000016")]
[AttributeAttribute(Name = "NodeAttribute", RVA = "0x73E6F0", Offset = "0x73E6F0")]
public class MergeNode : ScenarioNodeBase
{
	[Token(Token = "0x400009F")]
	private const string Id = "MergeNode";

	[Token(Token = "0x17000013")]
	public override string GetID
	{
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x126C4C0", Offset = "0x126C4C0", VA = "0x126C4C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000014")]
	public override Type GetObjectType
	{
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x126C504", Offset = "0x126C504", VA = "0x126C504", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x126C57C", Offset = "0x126C57C", VA = "0x126C57C", Slot = "5")]
	public override Node Create(Vector2 pos)
	{
		return null;
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x126C740", Offset = "0x126C740", VA = "0x126C740")]
	public MergeNode()
	{
	}
}
[Token(Token = "0x2000017")]
[AttributeAttribute(Name = "NodeAttribute", RVA = "0x73E79C", Offset = "0x73E79C")]
public class MissionEffect : ScenarioNodeBase
{
	[Token(Token = "0x40000A0")]
	private const string Id = "MissionEffect";

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private string[] effectNames;

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public int effectId;

	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public string effectName;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public string achievementName;

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public float val;

	[Token(Token = "0x17000015")]
	public override string GetID
	{
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x126C77C", Offset = "0x126C77C", VA = "0x126C77C", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000016")]
	public override Type GetObjectType
	{
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x126C7C0", Offset = "0x126C7C0", VA = "0x126C7C0", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x126C838", Offset = "0x126C838", VA = "0x126C838", Slot = "5")]
	public override Node Create(Vector2 pos)
	{
		return null;
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x126C970", Offset = "0x126C970", VA = "0x126C970", Slot = "22")]
	public override bool IsEntity()
	{
		return default(bool);
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x126C978", Offset = "0x126C978", VA = "0x126C978")]
	public MissionEffect()
	{
	}
}
[Token(Token = "0x2000018")]
[AttributeAttribute(Name = "NodeAttribute", RVA = "0x73E848", Offset = "0x73E848")]
public class MissionFailTrigger : ScenarioNodeBase
{
	[Token(Token = "0x40000A6")]
	private const string Id = "MissionFailTrigger";

	[Token(Token = "0x17000017")]
	public override string GetID
	{
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x126CC90", Offset = "0x126CC90", VA = "0x126CC90", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000018")]
	public override Type GetObjectType
	{
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x126CCD4", Offset = "0x126CCD4", VA = "0x126CCD4", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x126CD4C", Offset = "0x126CD4C", VA = "0x126CD4C", Slot = "5")]
	public override Node Create(Vector2 pos)
	{
		return null;
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x126CE54", Offset = "0x126CE54", VA = "0x126CE54", Slot = "22")]
	public override bool IsEntity()
	{
		return default(bool);
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x126CE5C", Offset = "0x126CE5C", VA = "0x126CE5C")]
	public MissionFailTrigger()
	{
	}
}
[Token(Token = "0x2000019")]
[AttributeAttribute(Name = "NodeAttribute", RVA = "0x73E8F4", Offset = "0x73E8F4")]
public class MissionKeyConditionNode : ScenarioNodeBase
{
	[Token(Token = "0x200001A")]
	public enum ConditionalEnum
	{
		[Token(Token = "0x40000AD")]
		GTE,
		[Token(Token = "0x40000AE")]
		LTE,
		[Token(Token = "0x40000AF")]
		EQ
	}

	[Token(Token = "0x40000A7")]
	private const string Id = "MissionKeyConditionNode";

	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public ConditionalEnum condition;

	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public int amount;

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public string keyName;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public int keyId;

	[Token(Token = "0x17000019")]
	public override string GetID
	{
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x126CE64", Offset = "0x126CE64", VA = "0x126CE64", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700001A")]
	public override Type GetObjectType
	{
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x126CEA8", Offset = "0x126CEA8", VA = "0x126CEA8", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x126CF20", Offset = "0x126CF20", VA = "0x126CF20", Slot = "5")]
	public override Node Create(Vector2 pos)
	{
		return null;
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x126D058", Offset = "0x126D058", VA = "0x126D058")]
	public MissionKeyConditionNode()
	{
	}
}
[Token(Token = "0x200001B")]
[AttributeAttribute(Name = "NodeAttribute", RVA = "0x73E9A0", Offset = "0x73E9A0")]
public class MissionMessageNode : ScenarioNodeBase
{
	[Token(Token = "0x40000B0")]
	private const string Id = "MissionMessageNode";

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public string mainText;

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public int speakerId;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public string speakerName;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public string animationName;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public string stringKey;

	[Token(Token = "0x1700001B")]
	public override string GetID
	{
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x126D0B4", Offset = "0x126D0B4", VA = "0x126D0B4", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700001C")]
	public override Type GetObjectType
	{
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x126D0F8", Offset = "0x126D0F8", VA = "0x126D0F8", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x126D170", Offset = "0x126D170", VA = "0x126D170", Slot = "5")]
	public override Node Create(Vector2 pos)
	{
		return null;
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x126D2A4", Offset = "0x126D2A4", VA = "0x126D2A4", Slot = "22")]
	public override bool IsEntity()
	{
		return default(bool);
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x126D2AC", Offset = "0x126D2AC", VA = "0x126D2AC")]
	public MissionMessageNode()
	{
	}
}
[Token(Token = "0x200001C")]
[AttributeAttribute(Name = "NodeAttribute", RVA = "0x73EA4C", Offset = "0x73EA4C")]
public class MissionModifyKeyNode : ScenarioNodeBase
{
	[Token(Token = "0x40000B6")]
	private const string Id = "MissionModifyKeyNode";

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public string keyName;

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public int keyId;

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public int amount;

	[Token(Token = "0x1700001D")]
	public override string GetID
	{
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x126D338", Offset = "0x126D338", VA = "0x126D338", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700001E")]
	public override Type GetObjectType
	{
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x126D37C", Offset = "0x126D37C", VA = "0x126D37C", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x126D3F4", Offset = "0x126D3F4", VA = "0x126D3F4", Slot = "5")]
	public override Node Create(Vector2 pos)
	{
		return null;
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x126D52C", Offset = "0x126D52C", VA = "0x126D52C")]
	public MissionModifyKeyNode()
	{
	}
}
[Token(Token = "0x200001D")]
[AttributeAttribute(Name = "NodeAttribute", RVA = "0x73EAF8", Offset = "0x73EAF8")]
public class MissionTriggerNode : ScenarioNodeBase
{
	[Token(Token = "0x40000BA")]
	private const string Id = "MissionTriggerNode";

	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private string[] triggerNames;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public int triggerId;

	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public string triggerName;

	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public bool tickRequiresEngines;

	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public float val;

	[Token(Token = "0x1700001F")]
	public override string GetID
	{
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x126D588", Offset = "0x126D588", VA = "0x126D588", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000020")]
	public override Type GetObjectType
	{
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x126D5CC", Offset = "0x126D5CC", VA = "0x126D5CC", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x126D644", Offset = "0x126D644", VA = "0x126D644", Slot = "5")]
	public override Node Create(Vector2 pos)
	{
		return null;
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x126D790", Offset = "0x126D790", VA = "0x126D790", Slot = "22")]
	public override bool IsEntity()
	{
		return default(bool);
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x126D798", Offset = "0x126D798", VA = "0x126D798")]
	public MissionTriggerNode()
	{
	}
}
[Token(Token = "0x200001E")]
[AttributeAttribute(Name = "NodeAttribute", RVA = "0x73EBA4", Offset = "0x73EBA4")]
public class ModifyFleet : ScenarioNodeBase
{
	[Token(Token = "0x40000C0")]
	private const string Id = "ModifyFleet";

	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private string[] actions;

	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private string action;

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private int actionIndex;

	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private string actionValue;

	[Token(Token = "0x17000021")]
	public override string GetID
	{
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x126DA60", Offset = "0x126DA60", VA = "0x126DA60", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000022")]
	public override Type GetObjectType
	{
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x126DAA4", Offset = "0x126DAA4", VA = "0x126DAA4", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x126DB1C", Offset = "0x126DB1C", VA = "0x126DB1C", Slot = "5")]
	public override Node Create(Vector2 pos)
	{
		return null;
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x126DC94", Offset = "0x126DC94", VA = "0x126DC94")]
	public ModifyFleet()
	{
	}
}
[Token(Token = "0x200001F")]
[AttributeAttribute(Name = "NodeAttribute", RVA = "0x73EC50", Offset = "0x73EC50")]
public class ModifyKeyNode : ScenarioNodeBase
{
	[Token(Token = "0x40000C5")]
	private const string Id = "ModifyKeyNode";

	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public string keyName;

	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public int keyId;

	[Token(Token = "0x40000C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public int amount;

	[Token(Token = "0x40000C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public bool conveyEffects;

	[Token(Token = "0x17000023")]
	public override string GetID
	{
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x126DDF8", Offset = "0x126DDF8", VA = "0x126DDF8", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000024")]
	public override Type GetObjectType
	{
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x126DE3C", Offset = "0x126DE3C", VA = "0x126DE3C", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x126DEB4", Offset = "0x126DEB4", VA = "0x126DEB4", Slot = "5")]
	public override Node Create(Vector2 pos)
	{
		return null;
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x126DFEC", Offset = "0x126DFEC", VA = "0x126DFEC")]
	public ModifyKeyNode()
	{
	}
}
[Token(Token = "0x2000020")]
[AttributeAttribute(Name = "NodeAttribute", RVA = "0x73ECFC", Offset = "0x73ECFC")]
public class ModifyResources : ScenarioNodeBase
{
	[Token(Token = "0x40000CA")]
	private const string Id = "ModifyResources";

	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public int amount;

	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public int scrapAmount;

	[Token(Token = "0x17000025")]
	public override string GetID
	{
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x126E054", Offset = "0x126E054", VA = "0x126E054", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000026")]
	public override Type GetObjectType
	{
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x126E098", Offset = "0x126E098", VA = "0x126E098", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x126E110", Offset = "0x126E110", VA = "0x126E110", Slot = "5")]
	public override Node Create(Vector2 pos)
	{
		return null;
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x126E248", Offset = "0x126E248", VA = "0x126E248")]
	public ModifyResources()
	{
	}
}
[Token(Token = "0x2000021")]
[AttributeAttribute(Name = "NodeAttribute", RVA = "0x73EDA8", Offset = "0x73EDA8")]
public class ModifyRunNode : ScenarioNodeBase
{
	[Token(Token = "0x2000022")]
	public enum RunModificationType
	{
		[Token(Token = "0x40000D1")]
		HardBattleLater,
		[Token(Token = "0x40000D2")]
		RespiteLater
	}

	[Token(Token = "0x40000CD")]
	private const string Id = "ModifyRunNode";

	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public RunModificationType runModification;

	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public int numTurns;

	[Token(Token = "0x17000027")]
	public override string GetID
	{
		[Token(Token = "0x600006C")]
		[Address(RVA = "0x126E258", Offset = "0x126E258", VA = "0x126E258", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000028")]
	public override Type GetObjectType
	{
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x126E29C", Offset = "0x126E29C", VA = "0x126E29C", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x126E314", Offset = "0x126E314", VA = "0x126E314", Slot = "5")]
	public override Node Create(Vector2 pos)
	{
		return null;
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x126E44C", Offset = "0x126E44C", VA = "0x126E44C")]
	public ModifyRunNode()
	{
	}
}
[Token(Token = "0x2000023")]
[AttributeAttribute(Name = "NodeAttribute", RVA = "0x73EE54", Offset = "0x73EE54")]
public class ModifyScore : ScenarioNodeBase
{
	[Token(Token = "0x40000D3")]
	private const string Id = "ModifyScore";

	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public int amount;

	[Token(Token = "0x17000029")]
	public override string GetID
	{
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x126E45C", Offset = "0x126E45C", VA = "0x126E45C", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700002A")]
	public override Type GetObjectType
	{
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x126E4A0", Offset = "0x126E4A0", VA = "0x126E4A0", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x126E518", Offset = "0x126E518", VA = "0x126E518", Slot = "5")]
	public override Node Create(Vector2 pos)
	{
		return null;
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x126E650", Offset = "0x126E650", VA = "0x126E650")]
	public ModifyScore()
	{
	}
}
[Token(Token = "0x2000024")]
[AttributeAttribute(Name = "NodeAttribute", RVA = "0x73EF00", Offset = "0x73EF00")]
public class NavPointNode : ScenarioNodeBase
{
	[Token(Token = "0x40000D5")]
	private const string Id = "NavPointNode";

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool scanGoal;

	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
	public bool procedural;

	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public int asteroidLevel;

	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public int resources;

	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public int energyRes;

	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public int crates;

	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public int itemCrates;

	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public int dustClouds;

	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public int dangerClouds;

	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public int shieldCloud;

	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public int debrisFields;

	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public int turrets;

	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public int rifts;

	[Token(Token = "0x1700002B")]
	public override string GetID
	{
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x126F094", Offset = "0x126F094", VA = "0x126F094", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700002C")]
	public override Type GetObjectType
	{
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x126F0D8", Offset = "0x126F0D8", VA = "0x126F0D8", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x126F150", Offset = "0x126F150", VA = "0x126F150", Slot = "5")]
	public override Node Create(Vector2 pos)
	{
		return null;
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x126F3C0", Offset = "0x126F3C0", VA = "0x126F3C0", Slot = "22")]
	public override bool IsEntity()
	{
		return default(bool);
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x126F3C8", Offset = "0x126F3C8", VA = "0x126F3C8")]
	public NavPointNode()
	{
	}
}
[Token(Token = "0x2000025")]
[AttributeAttribute(Name = "NodeAttribute", RVA = "0x73EFAC", Offset = "0x73EFAC")]
public class PlayMusicNode : ScenarioNodeBase
{
	[Token(Token = "0x40000E3")]
	private const string Id = "PlayMusicNode";

	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public int musicNum;

	[Token(Token = "0x1700002D")]
	public override string GetID
	{
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x170B078", Offset = "0x170B078", VA = "0x170B078", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700002E")]
	public override Type GetObjectType
	{
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x170B0BC", Offset = "0x170B0BC", VA = "0x170B0BC", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x170B134", Offset = "0x170B134", VA = "0x170B134", Slot = "5")]
	public override Node Create(Vector2 pos)
	{
		return null;
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x170B270", Offset = "0x170B270", VA = "0x170B270")]
	public PlayMusicNode()
	{
	}
}
[Token(Token = "0x2000026")]
[AttributeAttribute(Name = "NodeAttribute", RVA = "0x740058", Offset = "0x740058")]
public class RandomChance : ScenarioNodeBase
{
	[Token(Token = "0x40000E5")]
	private const string Id = "RandomChance";

	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public float chanceA;

	[Token(Token = "0x1700002F")]
	public override string GetID
	{
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x17143F4", Offset = "0x17143F4", VA = "0x17143F4", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000030")]
	public override Type GetObjectType
	{
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x1714438", Offset = "0x1714438", VA = "0x1714438", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x17144B0", Offset = "0x17144B0", VA = "0x17144B0", Slot = "5")]
	public override Node Create(Vector2 pos)
	{
		return null;
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x171461C", Offset = "0x171461C", VA = "0x171461C", Slot = "23")]
	public new virtual ScenarioNodeBase GetNextNode()
	{
		return null;
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x1714804", Offset = "0x1714804", VA = "0x1714804")]
	public RandomChance()
	{
	}
}
[Token(Token = "0x2000027")]
[AttributeAttribute(Name = "NodeAttribute", RVA = "0x740104", Offset = "0x740104")]
public class RewardNode : ScenarioNodeBase
{
	[Token(Token = "0x2000028")]
	public enum RewardNodeTypes
	{
		[Token(Token = "0x40000EA")]
		Small,
		[Token(Token = "0x40000EB")]
		Medium,
		[Token(Token = "0x40000EC")]
		Large,
		[Token(Token = "0x40000ED")]
		Repair,
		[Token(Token = "0x40000EE")]
		Resources,
		[Token(Token = "0x40000EF")]
		Procedural,
		[Token(Token = "0x40000F0")]
		Scrap
	}

	[Token(Token = "0x40000E7")]
	private const string Id = "RewardNode";

	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public int rewardId;

	[Token(Token = "0x17000031")]
	public override string GetID
	{
		[Token(Token = "0x6000082")]
		[Address(RVA = "0x17159B0", Offset = "0x17159B0", VA = "0x17159B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000032")]
	public override Type GetObjectType
	{
		[Token(Token = "0x6000083")]
		[Address(RVA = "0x17159F4", Offset = "0x17159F4", VA = "0x17159F4", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x1715A6C", Offset = "0x1715A6C", VA = "0x1715A6C", Slot = "5")]
	public override Node Create(Vector2 pos)
	{
		return null;
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x1715BA8", Offset = "0x1715BA8", VA = "0x1715BA8")]
	public RewardNode()
	{
	}
}
[Token(Token = "0x2000029")]
[AttributeAttribute(Name = "NodeAttribute", RVA = "0x7401B0", Offset = "0x7401B0")]
public class ScenarioEndNode : ScenarioNodeBase
{
	[Token(Token = "0x40000F1")]
	private const string Id = "ScenarioEndNode";

	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool completeScenario;

	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public string endpoint;

	[Token(Token = "0x17000033")]
	public override string GetID
	{
		[Token(Token = "0x6000086")]
		[Address(RVA = "0x171D8BC", Offset = "0x171D8BC", VA = "0x171D8BC", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000034")]
	public override Type GetObjectType
	{
		[Token(Token = "0x6000087")]
		[Address(RVA = "0x171D900", Offset = "0x171D900", VA = "0x171D900", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x171D978", Offset = "0x171D978", VA = "0x171D978", Slot = "5")]
	public override Node Create(Vector2 pos)
	{
		return null;
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x171DA80", Offset = "0x171DA80", VA = "0x171DA80")]
	public ScenarioEndNode()
	{
	}
}
[Token(Token = "0x200002A")]
[AttributeAttribute(Name = "NodeAttribute", RVA = "0x74025C", Offset = "0x74025C")]
public abstract class ScenarioNodeBase : Node
{
	[Token(Token = "0x40000F4")]
	private const string Id = "Base";

	[Token(Token = "0x17000035")]
	public override bool AllowRecursion
	{
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x171DEE0", Offset = "0x171DEE0", VA = "0x171DEE0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000036")]
	public abstract Type GetObjectType
	{
		[Token(Token = "0x600008B")]
		get;
	}

	[Token(Token = "0x17000037")]
	public override string GetID
	{
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x171DEE8", Offset = "0x171DEE8", VA = "0x171DEE8", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x171DF2C", Offset = "0x171DF2C", VA = "0x171DF2C", Slot = "21")]
	public virtual ScenarioNodeBase GetNextNode()
	{
		return null;
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x171E068", Offset = "0x171E068", VA = "0x171E068", Slot = "22")]
	public virtual bool IsEntity()
	{
		return default(bool);
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x171E070", Offset = "0x171E070", VA = "0x171E070", Slot = "6")]
	protected internal override void NodeGUI()
	{
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x170B278", Offset = "0x170B278", VA = "0x170B278")]
	protected ScenarioNodeBase()
	{
	}
}
[Token(Token = "0x200002B")]
public class ScenarioNextType : IConnectionTypeDeclaration
{
	[Token(Token = "0x17000038")]
	public string Identifier
	{
		[Token(Token = "0x6000091")]
		[Address(RVA = "0x171DD8C", Offset = "0x171DD8C", VA = "0x171DD8C", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000039")]
	public Type Type
	{
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x171DDD0", Offset = "0x171DDD0", VA = "0x171DDD0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700003A")]
	public Color Color
	{
		[Token(Token = "0x6000093")]
		[Address(RVA = "0x171DE48", Offset = "0x171DE48", VA = "0x171DE48", Slot = "6")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x1700003B")]
	public string InKnobTex
	{
		[Token(Token = "0x6000094")]
		[Address(RVA = "0x171DE50", Offset = "0x171DE50", VA = "0x171DE50", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700003C")]
	public string OutKnobTex
	{
		[Token(Token = "0x6000095")]
		[Address(RVA = "0x171DE94", Offset = "0x171DE94", VA = "0x171DE94", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x171DED8", Offset = "0x171DED8", VA = "0x171DED8")]
	public ScenarioNextType()
	{
	}
}
[Token(Token = "0x200002C")]
public class ScenarioSpeakerType : IConnectionTypeDeclaration
{
	[Token(Token = "0x1700003D")]
	public string Identifier
	{
		[Token(Token = "0x6000097")]
		[Address(RVA = "0x171E074", Offset = "0x171E074", VA = "0x171E074", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700003E")]
	public Type Type
	{
		[Token(Token = "0x6000098")]
		[Address(RVA = "0x171E0B8", Offset = "0x171E0B8", VA = "0x171E0B8", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700003F")]
	public Color Color
	{
		[Token(Token = "0x6000099")]
		[Address(RVA = "0x171E130", Offset = "0x171E130", VA = "0x171E130", Slot = "6")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x17000040")]
	public string InKnobTex
	{
		[Token(Token = "0x600009A")]
		[Address(RVA = "0x171E138", Offset = "0x171E138", VA = "0x171E138", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000041")]
	public string OutKnobTex
	{
		[Token(Token = "0x600009B")]
		[Address(RVA = "0x171E17C", Offset = "0x171E17C", VA = "0x171E17C", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x171E1C0", Offset = "0x171E1C0", VA = "0x171E1C0")]
	public ScenarioSpeakerType()
	{
	}
}
[Token(Token = "0x200002D")]
public class ScenarioFleetType : IConnectionTypeDeclaration
{
	[Token(Token = "0x17000042")]
	public string Identifier
	{
		[Token(Token = "0x600009D")]
		[Address(RVA = "0x171DAE4", Offset = "0x171DAE4", VA = "0x171DAE4", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000043")]
	public Type Type
	{
		[Token(Token = "0x600009E")]
		[Address(RVA = "0x171DB28", Offset = "0x171DB28", VA = "0x171DB28", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000044")]
	public Color Color
	{
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x171DBA0", Offset = "0x171DBA0", VA = "0x171DBA0", Slot = "6")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x17000045")]
	public string InKnobTex
	{
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x171DBA8", Offset = "0x171DBA8", VA = "0x171DBA8", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000046")]
	public string OutKnobTex
	{
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x171DBEC", Offset = "0x171DBEC", VA = "0x171DBEC", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x171DC30", Offset = "0x171DC30", VA = "0x171DC30")]
	public ScenarioFleetType()
	{
	}
}
[Token(Token = "0x200002E")]
public class ScenarioMissionEffectType : IConnectionTypeDeclaration
{
	[Token(Token = "0x17000047")]
	public string Identifier
	{
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x171DC38", Offset = "0x171DC38", VA = "0x171DC38", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000048")]
	public Type Type
	{
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x171DC7C", Offset = "0x171DC7C", VA = "0x171DC7C", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000049")]
	public Color Color
	{
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x171DCF4", Offset = "0x171DCF4", VA = "0x171DCF4", Slot = "6")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x1700004A")]
	public string InKnobTex
	{
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x171DCFC", Offset = "0x171DCFC", VA = "0x171DCFC", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700004B")]
	public string OutKnobTex
	{
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x171DD40", Offset = "0x171DD40", VA = "0x171DD40", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x171DD84", Offset = "0x171DD84", VA = "0x171DD84")]
	public ScenarioMissionEffectType()
	{
	}
}
[Token(Token = "0x200002F")]
[AttributeAttribute(Name = "NodeAttribute", RVA = "0x740308", Offset = "0x740308")]
public class ScenarioStartNode : ScenarioNodeBase
{
	[Token(Token = "0x40000F5")]
	private const string Id = "ScenarioStartNode";

	[Token(Token = "0x1700004C")]
	public override string GetID
	{
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x171E1C8", Offset = "0x171E1C8", VA = "0x171E1C8", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700004D")]
	public override Type GetObjectType
	{
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x171E20C", Offset = "0x171E20C", VA = "0x171E20C", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x171E284", Offset = "0x171E284", VA = "0x171E284", Slot = "5")]
	public override Node Create(Vector2 pos)
	{
		return null;
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x171E388", Offset = "0x171E388", VA = "0x171E388")]
	public ScenarioStartNode()
	{
	}
}
[Token(Token = "0x2000030")]
[AttributeAttribute(Name = "NodeAttribute", RVA = "0x7403B4", Offset = "0x7403B4")]
public class ShipInfoNode : ScenarioNodeBase
{
	[Token(Token = "0x40000F6")]
	private const string Id = "ShipInfoNode";

	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public int shipRewardId;

	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public string shipName;

	[Token(Token = "0x1700004E")]
	public override string GetID
	{
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x171E62C", Offset = "0x171E62C", VA = "0x171E62C", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700004F")]
	public override Type GetObjectType
	{
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x171E670", Offset = "0x171E670", VA = "0x171E670", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x171E6E8", Offset = "0x171E6E8", VA = "0x171E6E8", Slot = "5")]
	public override Node Create(Vector2 pos)
	{
		return null;
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x171E820", Offset = "0x171E820", VA = "0x171E820")]
	public ShipInfoNode()
	{
	}
}
[Token(Token = "0x2000031")]
[AttributeAttribute(Name = "NodeAttribute", RVA = "0x740460", Offset = "0x740460")]
public class ShipRewardNode : ScenarioNodeBase
{
	[Token(Token = "0x40000F9")]
	private const string Id = "ShipRewardNode";

	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public int shipRewardId;

	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public string shipName;

	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public bool loadoutIsCurrentTier;

	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
	public bool loadoutIsEmpty;

	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7A")]
	public bool isMercenary;

	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7B")]
	public bool isEscortTarget;

	[Token(Token = "0x17000050")]
	public override string GetID
	{
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x171E828", Offset = "0x171E828", VA = "0x171E828", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000051")]
	public override Type GetObjectType
	{
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x171E86C", Offset = "0x171E86C", VA = "0x171E86C", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x171E8E4", Offset = "0x171E8E4", VA = "0x171E8E4", Slot = "5")]
	public override Node Create(Vector2 pos)
	{
		return null;
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x171EA1C", Offset = "0x171EA1C", VA = "0x171EA1C")]
	public ShipRewardNode()
	{
	}
}
[Token(Token = "0x2000032")]
[AttributeAttribute(Name = "NodeAttribute", RVA = "0x74050C", Offset = "0x74050C")]
public class ShipSlotUnlockNode : ScenarioNodeBase
{
	[Token(Token = "0x4000100")]
	private const string Id = "ShipSlotUnlockNode";

	[Token(Token = "0x17000052")]
	public override string GetID
	{
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x171EA24", Offset = "0x171EA24", VA = "0x171EA24", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000053")]
	public override Type GetObjectType
	{
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x171EA68", Offset = "0x171EA68", VA = "0x171EA68", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x171EAE0", Offset = "0x171EAE0", VA = "0x171EAE0", Slot = "5")]
	public override Node Create(Vector2 pos)
	{
		return null;
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x171EC1C", Offset = "0x171EC1C", VA = "0x171EC1C")]
	public ShipSlotUnlockNode()
	{
	}
}
[Token(Token = "0x2000033")]
[AttributeAttribute(Name = "NodeAttribute", RVA = "0x7405B8", Offset = "0x7405B8")]
public class SpecificRewardNode : ScenarioNodeBase
{
	[Token(Token = "0x4000101")]
	private const string Id = "SpecificRewardNode";

	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public string itemName;

	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public int itemId;

	[Token(Token = "0x17000054")]
	public override string GetID
	{
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x171EDC8", Offset = "0x171EDC8", VA = "0x171EDC8", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000055")]
	public override Type GetObjectType
	{
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x171EE0C", Offset = "0x171EE0C", VA = "0x171EE0C", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x171EE84", Offset = "0x171EE84", VA = "0x171EE84", Slot = "5")]
	public override Node Create(Vector2 pos)
	{
		return null;
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x171EFC0", Offset = "0x171EFC0", VA = "0x171EFC0")]
	public SpecificRewardNode()
	{
	}
}
[Token(Token = "0x2000034")]
[AttributeAttribute(Name = "NodeAttribute", RVA = "0x740664", Offset = "0x740664")]
public class StoreNode : ScenarioNodeBase
{
	[Token(Token = "0x2000035")]
	public enum StoreNodeType
	{
		[Token(Token = "0x4000107")]
		NoStore,
		[Token(Token = "0x4000108")]
		Standard,
		[Token(Token = "0x4000109")]
		EndlessStore,
		[Token(Token = "0x400010A")]
		TradeForItem,
		[Token(Token = "0x400010B")]
		UpgradeItem
	}

	[Token(Token = "0x4000104")]
	private const string Id = "StoreNode";

	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public StoreNodeType storeType;

	[Token(Token = "0x17000056")]
	public override string GetID
	{
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x171F080", Offset = "0x171F080", VA = "0x171F080", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000057")]
	public override Type GetObjectType
	{
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x171F0C4", Offset = "0x171F0C4", VA = "0x171F0C4", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x171F13C", Offset = "0x171F13C", VA = "0x171F13C", Slot = "5")]
	public override Node Create(Vector2 pos)
	{
		return null;
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x171F278", Offset = "0x171F278", VA = "0x171F278")]
	public StoreNode()
	{
	}
}
[Token(Token = "0x2000036")]
[AttributeAttribute(Name = "NodeAttribute", RVA = "0x740710", Offset = "0x740710")]
public class StoreShipUnlockNode : ScenarioNodeBase
{
	[Token(Token = "0x400010C")]
	private const string Id = "StoreShipUnlockNode";

	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public string shipName;

	[Token(Token = "0x17000058")]
	public override string GetID
	{
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x171F288", Offset = "0x171F288", VA = "0x171F288", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000059")]
	public override Type GetObjectType
	{
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x171F2CC", Offset = "0x171F2CC", VA = "0x171F2CC", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x171F344", Offset = "0x171F344", VA = "0x171F344", Slot = "5")]
	public override Node Create(Vector2 pos)
	{
		return null;
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x171F480", Offset = "0x171F480", VA = "0x171F480")]
	public StoreShipUnlockNode()
	{
	}
}
[Token(Token = "0x2000037")]
[ExecuteInEditMode]
public class VDColorHandler : VDColorHandlerBase
{
	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x1A7A2FC", Offset = "0x1A7A2FC", VA = "0x1A7A2FC")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x1A7A6A8", Offset = "0x1A7A6A8", VA = "0x1A7A6A8")]
	private void Update()
	{
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x1A7A6EC", Offset = "0x1A7A6EC", VA = "0x1A7A6EC")]
	public void SetColors()
	{
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x1A7A3D0", Offset = "0x1A7A3D0", VA = "0x1A7A3D0")]
	public void SetMesh()
	{
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x1A7A7B8", Offset = "0x1A7A7B8", VA = "0x1A7A7B8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x1A7A824", Offset = "0x1A7A824", VA = "0x1A7A824")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x1A7A950", Offset = "0x1A7A950", VA = "0x1A7A950")]
	public VDColorHandler()
	{
	}
}
[Token(Token = "0x2000038")]
public class VDColorHandlerBase : MonoBehaviour
{
	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public Color32[] colors;

	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public Color32[] tempColors;

	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public Mesh coloredMesh;

	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Mesh originalMesh;

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x1A7A954", Offset = "0x1A7A954", VA = "0x1A7A954")]
	public VDColorHandlerBase()
	{
	}
}
[Token(Token = "0x2000039")]
[ExecuteInEditMode]
public class VDSampler : MonoBehaviour
{
	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Texture2D tex;

	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Color32[] lum;

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x1A7A9D8", Offset = "0x1A7A9D8", VA = "0x1A7A9D8")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x1A7AA8C", Offset = "0x1A7AA8C", VA = "0x1A7AA8C")]
	private void OnPostRender()
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x1A7AC78", Offset = "0x1A7AC78", VA = "0x1A7AC78")]
	public VDSampler()
	{
	}
}
[Token(Token = "0x200003A")]
public class VertexDirtSettingsStruct
{
	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string occluderShader;

	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float samplingBias;

	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float samplingDistance;

	[Token(Token = "0x4000117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float samplingAngle;

	[Token(Token = "0x4000118")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool edgeSmooth;

	[Token(Token = "0x4000119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
	public bool invertNormals;

	[Token(Token = "0x400011A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float edgeSmoothBias;

	[Token(Token = "0x400011B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public CameraClearFlags skyMode;

	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool disableOccluders;

	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public Color customSkyColor;

	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public Color customShadowColor;

	[Token(Token = "0x400011F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public bool useCustomSkyColor;

	[Token(Token = "0x4000120")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
	public bool useCustomShadowColor;

	[Token(Token = "0x4000121")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x56")]
	public bool useSkyCube;

	[Token(Token = "0x4000122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Material skyCube;

	[Token(Token = "0x4000123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public int blendModeIndex;

	[Token(Token = "0x4000124")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public int colorOutputIndex;

	[Token(Token = "0x4000125")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public int luminanceOutputIndex;

	[Token(Token = "0x4000126")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public int bakeLayerMask;

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x1A7C72C", Offset = "0x1A7C72C", VA = "0x1A7C72C")]
	public VertexDirtSettingsStruct()
	{
	}
}
[Token(Token = "0x200003B")]
public static class VertexDirt
{
	[Token(Token = "0x4000127")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Vector3[] v;

	[Token(Token = "0x4000128")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Vector3[] n;

	[Token(Token = "0x4000129")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static Color32[] c;

	[Token(Token = "0x400012A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static VertexSample vertexSample;

	[Token(Token = "0x400012B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static int sampleWidth;

	[Token(Token = "0x400012C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public static int sampleHeight;

	[Token(Token = "0x400012D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static int rgbBakingMode;

	[Token(Token = "0x400012E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public static int alphaBakingMode;

	[Token(Token = "0x400012F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static VertexDirtSettingsStruct settings;

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x1A7AC80", Offset = "0x1A7AC80", VA = "0x1A7AC80")]
	public static void Dirt(Transform[] sels)
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x1A7B3C0", Offset = "0x1A7B3C0", VA = "0x1A7B3C0")]
	public static void UpdateShaderVariables()
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x1A7B564", Offset = "0x1A7B564", VA = "0x1A7B564")]
	private static void PrepareVertices(Transform go)
	{
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x1A7B9DC", Offset = "0x1A7B9DC", VA = "0x1A7B9DC")]
	public static void PrepareColors()
	{
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x1A7BA7C", Offset = "0x1A7BA7C", VA = "0x1A7BA7C")]
	private static void SmoothVertices()
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x1A7BE94", Offset = "0x1A7BE94", VA = "0x1A7BE94")]
	private static void CalcColors(GameObject camGO, Camera cam)
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x1A7ABA4", Offset = "0x1A7ABA4", VA = "0x1A7ABA4")]
	public static void SetColorSample(Color32 c)
	{
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x1A7C5B4", Offset = "0x1A7C5B4", VA = "0x1A7C5B4")]
	public static Color ColorAndLuminance(Color c)
	{
		return default(Color);
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x1A7C5E4", Offset = "0x1A7C5E4", VA = "0x1A7C5E4")]
	public static Color32 MultiplyColor32(Color c0, Color c1)
	{
		return default(Color32);
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x1A7C23C", Offset = "0x1A7C23C", VA = "0x1A7C23C")]
	private static void ApplyColors(Transform go)
	{
	}
}
[Token(Token = "0x200003C")]
public class VertexSample
{
	[Token(Token = "0x4000130")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Color32 color;

	[Token(Token = "0x4000131")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int index;

	[Token(Token = "0x4000132")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool isCalulated;

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x1A7C6DC", Offset = "0x1A7C6DC", VA = "0x1A7C6DC")]
	public VertexSample()
	{
	}
}
namespace UnityStandardAssets.Utility
{
	[Token(Token = "0x200003D")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7407DC", Offset = "0x7407DC")]
	public class FPSCounter : MonoBehaviour
	{
		[Token(Token = "0x4000133")]
		private const float fpsMeasurePeriod = 0.5f;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int m_FpsAccumulator;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float m_FpsNextPeriod;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int m_CurrentFps;

		[Token(Token = "0x4000137")]
		private const string display = "{0} FPS";

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Text m_Text;

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x1267250", Offset = "0x1267250", VA = "0x1267250")]
		private void Start()
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x12672C0", Offset = "0x12672C0", VA = "0x12672C0")]
		private void Update()
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x12673C4", Offset = "0x12673C4", VA = "0x12673C4")]
		public FPSCounter()
		{
		}
	}
}
namespace UnityStandardAssets.Effects
{
	[Token(Token = "0x200003E")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x74083C", Offset = "0x74083C")]
	public class AfterburnerPhysicsForce : MonoBehaviour
	{
		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float effectAngle;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float effectWidth;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float effectDistance;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float force;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Collider[] m_Cols;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private SphereCollider m_Sphere;

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x187444C", Offset = "0x187444C", VA = "0x187444C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x18744F0", Offset = "0x18744F0", VA = "0x18744F0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x18748FC", Offset = "0x18748FC", VA = "0x18748FC")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x1874D84", Offset = "0x1874D84", VA = "0x1874D84")]
		public AfterburnerPhysicsForce()
		{
		}
	}
	[Token(Token = "0x200003F")]
	public class ExplosionFireAndDebris : MonoBehaviour
	{
		[Token(Token = "0x2000040")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74089C", Offset = "0x74089C")]
		private sealed class <Start>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000143")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000144")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000145")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ExplosionFireAndDebris <>4__this;

			[Token(Token = "0x4000146")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <multiplier>5__2;

			[Token(Token = "0x1700005A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000EA")]
				[Address(RVA = "0x1A7DB88", Offset = "0x1A7DB88", VA = "0x1A7DB88", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700005B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000EC")]
				[Address(RVA = "0x1A7DBD0", Offset = "0x1A7DBD0", VA = "0x1A7DBD0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000E7")]
			[Address(RVA = "0x1A7D630", Offset = "0x1A7D630", VA = "0x1A7D630")]
			[DebuggerHidden]
			public <Start>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x60000E8")]
			[Address(RVA = "0x1A7D65C", Offset = "0x1A7D65C", VA = "0x1A7D65C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000E9")]
			[Address(RVA = "0x1A7D660", Offset = "0x1A7D660", VA = "0x1A7D660", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000EB")]
			[Address(RVA = "0x1A7DB90", Offset = "0x1A7DB90", VA = "0x1A7DB90", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform[] debrisPrefabs;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform firePrefab;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int numDebrisPieces;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int numFires;

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x1266E68", Offset = "0x1266E68", VA = "0x1266E68")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7423C0", Offset = "0x7423C0")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x1266EE0", Offset = "0x1266EE0", VA = "0x1266EE0")]
		private void AddFire(Transform t, Vector3 pos, Vector3 normal)
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x1267004", Offset = "0x1267004", VA = "0x1267004")]
		public ExplosionFireAndDebris()
		{
		}
	}
	[Token(Token = "0x2000041")]
	public class ExplosionPhysicsForce : MonoBehaviour
	{
		[Token(Token = "0x2000042")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7408AC", Offset = "0x7408AC")]
		private sealed class <Start>d__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000148")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000149")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400014A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ExplosionPhysicsForce <>4__this;

			[Token(Token = "0x1700005C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000F2")]
				[Address(RVA = "0x1A7DF88", Offset = "0x1A7DF88", VA = "0x1A7DF88", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700005D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000F4")]
				[Address(RVA = "0x1A7DFD0", Offset = "0x1A7DFD0", VA = "0x1A7DFD0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000EF")]
			[Address(RVA = "0x1A7DBD8", Offset = "0x1A7DBD8", VA = "0x1A7DBD8")]
			[DebuggerHidden]
			public <Start>d__1(int <>1__state)
			{
			}

			[Token(Token = "0x60000F0")]
			[Address(RVA = "0x1A7DC04", Offset = "0x1A7DC04", VA = "0x1A7DC04", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000F1")]
			[Address(RVA = "0x1A7DC08", Offset = "0x1A7DC08", VA = "0x1A7DC08", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000F3")]
			[Address(RVA = "0x1A7DF90", Offset = "0x1A7DF90", VA = "0x1A7DF90", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float explosionForce;

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x126700C", Offset = "0x126700C", VA = "0x126700C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x742470", Offset = "0x742470")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x1267084", Offset = "0x1267084", VA = "0x1267084")]
		public ExplosionPhysicsForce()
		{
		}
	}
	[Token(Token = "0x2000043")]
	public class Explosive : MonoBehaviour
	{
		[Token(Token = "0x2000044")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7408BC", Offset = "0x7408BC")]
		private sealed class <OnCollisionEnter>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000151")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000152")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000153")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Explosive <>4__this;

			[Token(Token = "0x4000154")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Collision col;

			[Token(Token = "0x1700005E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000FC")]
				[Address(RVA = "0x1A7E28C", Offset = "0x1A7E28C", VA = "0x1A7E28C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700005F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000FE")]
				[Address(RVA = "0x1A7E2D4", Offset = "0x1A7E2D4", VA = "0x1A7E2D4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000F9")]
			[Address(RVA = "0x1A7DFD8", Offset = "0x1A7DFD8", VA = "0x1A7DFD8")]
			[DebuggerHidden]
			public <OnCollisionEnter>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x60000FA")]
			[Address(RVA = "0x1A7E004", Offset = "0x1A7E004", VA = "0x1A7E004", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000FB")]
			[Address(RVA = "0x1A7E008", Offset = "0x1A7E008", VA = "0x1A7E008", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000FD")]
			[Address(RVA = "0x1A7E294", Offset = "0x1A7E294", VA = "0x1A7E294", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform explosionPrefab;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float detonationImpactVelocity;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float sizeMultiplier;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool reset;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float resetTimeDelay;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool m_Exploded;

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x1267094", Offset = "0x1267094", VA = "0x1267094")]
		private void Start()
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x1267098", Offset = "0x1267098", VA = "0x1267098")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x742520", Offset = "0x742520")]
		private IEnumerator OnCollisionEnter(Collision col)
		{
			return null;
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x126712C", Offset = "0x126712C", VA = "0x126712C")]
		public void Reset()
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x1267134", Offset = "0x1267134", VA = "0x1267134")]
		public Explosive()
		{
		}
	}
	[Token(Token = "0x2000045")]
	public class ExtinguishableParticleSystem : MonoBehaviour
	{
		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float multiplier;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ParticleSystem[] m_Systems;

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x1267158", Offset = "0x1267158", VA = "0x1267158")]
		private void Start()
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x12671B4", Offset = "0x12671B4", VA = "0x12671B4")]
		public void Extinguish()
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x1267240", Offset = "0x1267240", VA = "0x1267240")]
		public ExtinguishableParticleSystem()
		{
		}
	}
	[Token(Token = "0x2000046")]
	public class FireLight : MonoBehaviour
	{
		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float m_Rnd;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private bool m_Burning;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Light m_Light;

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x12673CC", Offset = "0x12673CC", VA = "0x12673CC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x1267440", Offset = "0x1267440", VA = "0x1267440")]
		private void Update()
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x12675FC", Offset = "0x12675FC", VA = "0x12675FC")]
		public void Extinguish()
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x1267624", Offset = "0x1267624", VA = "0x1267624")]
		public FireLight()
		{
		}
	}
	[Token(Token = "0x2000047")]
	public class Hose : MonoBehaviour
	{
		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxPower;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float minPower;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float changeSpeed;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ParticleSystem[] hoseWaterSystems;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Renderer systemRenderer;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float m_Power;

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x126AF90", Offset = "0x126AF90", VA = "0x126AF90")]
		private void Update()
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x126B10C", Offset = "0x126B10C", VA = "0x126B10C")]
		public Hose()
		{
		}
	}
	[Token(Token = "0x2000048")]
	public class ParticleSystemMultiplier : MonoBehaviour
	{
		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float multiplier;

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x170AF40", Offset = "0x170AF40", VA = "0x170AF40")]
		private void Start()
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x170B068", Offset = "0x170B068", VA = "0x170B068")]
		public ParticleSystemMultiplier()
		{
		}
	}
	[Token(Token = "0x2000049")]
	public class SmokeParticles : MonoBehaviour
	{
		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioClip[] extinguishSounds;

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x171ED04", Offset = "0x171ED04", VA = "0x171ED04")]
		private void Start()
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x171EDC0", Offset = "0x171EDC0", VA = "0x171EDC0")]
		public SmokeParticles()
		{
		}
	}
	[Token(Token = "0x200004A")]
	public class WaterHoseParticles : MonoBehaviour
	{
		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static float lastSoundTime;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float force;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<ParticleCollisionEvent> m_CollisionEvents;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ParticleSystem m_ParticleSystem;

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x1A7CF48", Offset = "0x1A7CF48", VA = "0x1A7CF48")]
		private void Start()
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x1A7CFA4", Offset = "0x1A7CFA4", VA = "0x1A7CFA4")]
		private void OnParticleCollision(GameObject other)
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x1A7D218", Offset = "0x1A7D218", VA = "0x1A7D218")]
		public WaterHoseParticles()
		{
		}
	}
}
namespace UnityStandardAssets.ImageEffects
{
	[Token(Token = "0x200004B")]
	public enum AAMode
	{
		[Token(Token = "0x4000167")]
		FXAA2,
		[Token(Token = "0x4000168")]
		FXAA3Console,
		[Token(Token = "0x4000169")]
		FXAA1PresetA,
		[Token(Token = "0x400016A")]
		FXAA1PresetB,
		[Token(Token = "0x400016B")]
		NFAA,
		[Token(Token = "0x400016C")]
		SSAA,
		[Token(Token = "0x400016D")]
		DLAA
	}
	[Token(Token = "0x200004C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7408CC", Offset = "0x7408CC")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7408CC", Offset = "0x7408CC")]
	public class Antialiasing : PostEffectsBase
	{
		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AAMode mode;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool showGeneratedNormals;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float offsetScale;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float blurRadius;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float edgeThresholdMin;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float edgeThreshold;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float edgeSharpness;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool dlaaSharp;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader ssaaShader;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material ssaa;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader dlaaShader;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material dlaa;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Shader nfaaShader;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material nfaa;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Shader shaderFXAAPreset2;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Material materialFXAAPreset2;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Shader shaderFXAAPreset3;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Material materialFXAAPreset3;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Shader shaderFXAAII;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Material materialFXAAII;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Shader shaderFXAAIII;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Material materialFXAAIII;

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x1874D98", Offset = "0x1874D98", VA = "0x1874D98")]
		public Material CurrentAAMaterial()
		{
			return null;
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x1874DFC", Offset = "0x1874DFC", VA = "0x1874DFC", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x1874F70", Offset = "0x1874F70", VA = "0x1874F70")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x18754FC", Offset = "0x18754FC", VA = "0x18754FC")]
		public Antialiasing()
		{
		}
	}
	[Token(Token = "0x200004D")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x740960", Offset = "0x740960")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x740960", Offset = "0x740960")]
	[ExecuteInEditMode]
	public class Bloom : PostEffectsBase
	{
		[Token(Token = "0x200004E")]
		public enum LensFlareStyle
		{
			[Token(Token = "0x40001A3")]
			Ghosting,
			[Token(Token = "0x40001A4")]
			Anamorphic,
			[Token(Token = "0x40001A5")]
			Combined
		}

		[Token(Token = "0x200004F")]
		public enum TweakMode
		{
			[Token(Token = "0x40001A7")]
			Basic,
			[Token(Token = "0x40001A8")]
			Complex
		}

		[Token(Token = "0x2000050")]
		public enum HDRBloomMode
		{
			[Token(Token = "0x40001AA")]
			Auto,
			[Token(Token = "0x40001AB")]
			On,
			[Token(Token = "0x40001AC")]
			Off
		}

		[Token(Token = "0x2000051")]
		public enum BloomScreenBlendMode
		{
			[Token(Token = "0x40001AE")]
			Screen,
			[Token(Token = "0x40001AF")]
			Add
		}

		[Token(Token = "0x2000052")]
		public enum BloomQuality
		{
			[Token(Token = "0x40001B1")]
			Cheap,
			[Token(Token = "0x40001B2")]
			High
		}

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TweakMode tweakMode;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public BloomScreenBlendMode screenBlendMode;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public HDRBloomMode hdr;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool doHdr;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float sepBlurSpread;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public BloomQuality quality;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float bloomIntensity;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float bloomThreshold;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Color bloomThresholdColor;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int bloomBlurIterations;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public int hollywoodFlareBlurIterations;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float flareRotation;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public LensFlareStyle lensflareMode;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float hollyStretchWidth;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float lensflareIntensity;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float lensflareThreshold;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float lensFlareSaturation;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Color flareColorA;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Color flareColorB;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Color flareColorC;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Color flareColorD;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Texture2D lensFlareVignetteMask;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Shader lensFlareShader;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Material lensFlareMaterial;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Shader screenBlendShader;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Material screenBlend;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public Shader blurAndFlaresShader;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Material blurAndFlaresMaterial;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public Shader brightPassFilterShader;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Material brightPassFilterMaterial;

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x1875AA0", Offset = "0x1875AA0", VA = "0x1875AA0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x1875B90", Offset = "0x1875B90", VA = "0x1875B90")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x1877040", Offset = "0x1877040", VA = "0x1877040")]
		private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x1876DC0", Offset = "0x1876DC0", VA = "0x1876DC0")]
		private void BlendFlares(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x1876AAC", Offset = "0x1876AAC", VA = "0x1876AAC")]
		private void BrightFilter(float thresh, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x18769C0", Offset = "0x18769C0", VA = "0x18769C0")]
		private void BrightFilter(Color threshColor, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x1876BA0", Offset = "0x1876BA0", VA = "0x1876BA0")]
		private void Vignette(float amount, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x1877110", Offset = "0x1877110", VA = "0x1877110")]
		public Bloom()
		{
		}
	}
	[Token(Token = "0x2000053")]
	public enum LensflareStyle34
	{
		[Token(Token = "0x40001B4")]
		Ghosting,
		[Token(Token = "0x40001B5")]
		Anamorphic,
		[Token(Token = "0x40001B6")]
		Combined
	}
	[Token(Token = "0x2000054")]
	public enum TweakMode34
	{
		[Token(Token = "0x40001B8")]
		Basic,
		[Token(Token = "0x40001B9")]
		Complex
	}
	[Token(Token = "0x2000055")]
	public enum HDRBloomMode
	{
		[Token(Token = "0x40001BB")]
		Auto,
		[Token(Token = "0x40001BC")]
		On,
		[Token(Token = "0x40001BD")]
		Off
	}
	[Token(Token = "0x2000056")]
	public enum BloomScreenBlendMode
	{
		[Token(Token = "0x40001BF")]
		Screen,
		[Token(Token = "0x40001C0")]
		Add
	}
	[Token(Token = "0x2000057")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7409F4", Offset = "0x7409F4")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7409F4", Offset = "0x7409F4")]
	[ExecuteInEditMode]
	public class BloomAndFlares : PostEffectsBase
	{
		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TweakMode34 tweakMode;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public BloomScreenBlendMode screenBlendMode;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public HDRBloomMode hdr;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool doHdr;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float sepBlurSpread;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float useSrcAlphaAsMask;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float bloomIntensity;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float bloomThreshold;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public int bloomBlurIterations;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool lensflares;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int hollywoodFlareBlurIterations;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public LensflareStyle34 lensflareMode;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float hollyStretchWidth;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float lensflareIntensity;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float lensflareThreshold;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Color flareColorA;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Color flareColorB;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Color flareColorC;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public Color flareColorD;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Texture2D lensFlareVignetteMask;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Shader lensFlareShader;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Material lensFlareMaterial;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Shader vignetteShader;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Material vignetteMaterial;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Shader separableBlurShader;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Material separableBlurMaterial;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public Shader addBrightStuffOneOneShader;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Material addBrightStuffBlendOneOneMaterial;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public Shader screenBlendShader;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Material screenBlend;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public Shader hollywoodFlaresShader;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Material hollywoodFlaresMaterial;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public Shader brightPassFilterShader;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Material brightPassFilterMaterial;

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x1877250", Offset = "0x1877250", VA = "0x1877250", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x18773B0", Offset = "0x18773B0", VA = "0x18773B0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x187841C", Offset = "0x187841C", VA = "0x187841C")]
		private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x18781AC", Offset = "0x18781AC", VA = "0x18781AC")]
		private void BlendFlares(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x1877EFC", Offset = "0x1877EFC", VA = "0x1877EFC")]
		private void BrightFilter(float thresh, float useAlphaAsMask, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x1878038", Offset = "0x1878038", VA = "0x1878038")]
		private void Vignette(float amount, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x18784D8", Offset = "0x18784D8", VA = "0x18784D8")]
		public BloomAndFlares()
		{
		}
	}
	[Token(Token = "0x2000058")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x740A88", Offset = "0x740A88")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x740A88", Offset = "0x740A88")]
	public class BloomOptimized : PostEffectsBase
	{
		[Token(Token = "0x2000059")]
		public enum Resolution
		{
			[Token(Token = "0x40001EC")]
			Low,
			[Token(Token = "0x40001ED")]
			High
		}

		[Token(Token = "0x200005A")]
		public enum BlurType
		{
			[Token(Token = "0x40001EF")]
			Standard,
			[Token(Token = "0x40001F0")]
			Sgx
		}

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x741D1C", Offset = "0x741D1C")]
		public float threshold;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x741D34", Offset = "0x741D34")]
		public float intensity;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x741D4C", Offset = "0x741D4C")]
		public float blurSize;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Resolution resolution;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x741D64", Offset = "0x741D64")]
		public int blurIterations;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public BlurType blurType;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Shader fastBloomShader;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Material fastBloomMaterial;

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x1878608", Offset = "0x1878608", VA = "0x1878608", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x1878680", Offset = "0x1878680", VA = "0x1878680")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x187872C", Offset = "0x187872C", VA = "0x187872C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x1878B0C", Offset = "0x1878B0C", VA = "0x1878B0C")]
		public BloomOptimized()
		{
		}
	}
	[Token(Token = "0x200005B")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x740B1C", Offset = "0x740B1C")]
	[ExecuteInEditMode]
	public class Blur : MonoBehaviour
	{
		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x741D7C", Offset = "0x741D7C")]
		public int iterations;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x741D94", Offset = "0x741D94")]
		public float blurSpread;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Shader blurShader;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Material m_Material;

		[Token(Token = "0x17000060")]
		protected Material material
		{
			[Token(Token = "0x6000126")]
			[Address(RVA = "0x1878B30", Offset = "0x1878B30", VA = "0x1878B30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x1878C84", Offset = "0x1878C84", VA = "0x1878C84")]
		protected void OnDisable()
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x1878D88", Offset = "0x1878D88", VA = "0x1878D88")]
		protected void Start()
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x1878E44", Offset = "0x1878E44", VA = "0x1878E44")]
		public void FourTapCone(RenderTexture source, RenderTexture dest, int iteration)
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x1878F68", Offset = "0x1878F68", VA = "0x1878F68")]
		private void DownSample4x(RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x1879078", Offset = "0x1879078", VA = "0x1879078")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x18791E0", Offset = "0x18791E0", VA = "0x18791E0")]
		public Blur()
		{
		}
	}
	[Token(Token = "0x200005C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x740B68", Offset = "0x740B68")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x740B68", Offset = "0x740B68")]
	public class BlurOptimized : PostEffectsBase
	{
		[Token(Token = "0x200005D")]
		public enum BlurType
		{
			[Token(Token = "0x40001FC")]
			StandardGauss,
			[Token(Token = "0x40001FD")]
			SgxGauss
		}

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x741DAC", Offset = "0x741DAC")]
		public int downsample;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x741DC4", Offset = "0x741DC4")]
		public float blurSize;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x741DDC", Offset = "0x741DDC")]
		public int blurIterations;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public BlurType blurType;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader blurShader;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material blurMaterial;

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x18791FC", Offset = "0x18791FC", VA = "0x18791FC", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x1879274", Offset = "0x1879274", VA = "0x1879274")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x1879320", Offset = "0x1879320", VA = "0x1879320")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x18796CC", Offset = "0x18796CC", VA = "0x18796CC")]
		public BlurOptimized()
		{
		}
	}
	[Token(Token = "0x200005E")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x740BFC", Offset = "0x740BFC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x740BFC", Offset = "0x740BFC")]
	public class CameraMotionBlur : PostEffectsBase
	{
		[Token(Token = "0x200005F")]
		public enum MotionBlurFilter
		{
			[Token(Token = "0x400021F")]
			CameraMotion,
			[Token(Token = "0x4000220")]
			LocalBlur,
			[Token(Token = "0x4000221")]
			Reconstruction,
			[Token(Token = "0x4000222")]
			ReconstructionDX11,
			[Token(Token = "0x4000223")]
			ReconstructionDisc
		}

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static float MAX_RADIUS;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MotionBlurFilter filterType;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool preview;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 previewScale;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float movementScale;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float rotationScale;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float maxVelocity;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float minVelocity;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float velocityScale;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float softZDistance;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public int velocityDownsample;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public LayerMask excludeLayers;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GameObject tmpCam;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Shader shader;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Shader dx11MotionBlurShader;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Shader replacementClear;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Material motionBlurMaterial;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Material dx11MotionBlurMaterial;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Texture2D noiseTexture;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float jitter;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public bool showVelocity;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public float showVelocityScale;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Matrix4x4 currentViewProjMat;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Matrix4x4[] currentStereoViewProjMat;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Matrix4x4 prevViewProjMat;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Matrix4x4[] prevStereoViewProjMat;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private int prevFrameCount;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private bool wasActive;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3 prevFrameForward;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		private Vector3 prevFrameUp;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Vector3 prevFramePos;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private Camera _camera;

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x1879CFC", Offset = "0x1879CFC", VA = "0x1879CFC")]
		private void CalculateViewProjection()
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x1879F58", Offset = "0x1879F58", VA = "0x1879F58")]
		private new void Start()
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x187A1F0", Offset = "0x187A1F0", VA = "0x187A1F0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x187A2C4", Offset = "0x187A2C4", VA = "0x187A2C4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x187A45C", Offset = "0x187A45C", VA = "0x187A45C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x187A514", Offset = "0x187A514", VA = "0x187A514")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x187A094", Offset = "0x187A094", VA = "0x187A094")]
		private void Remember()
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x187BE94", Offset = "0x187BE94", VA = "0x187BE94")]
		private Camera GetTmpCam()
		{
			return null;
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x187BE04", Offset = "0x187BE04", VA = "0x187BE04")]
		private void StartFrame()
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x187BE84", Offset = "0x187BE84", VA = "0x187BE84")]
		private static int divRoundUp(int x, int d)
		{
			return default(int);
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x187C248", Offset = "0x187C248", VA = "0x187C248")]
		public CameraMotionBlur()
		{
		}
	}
	[Token(Token = "0x2000060")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x740C90", Offset = "0x740C90")]
	public class ColorCorrectionCurves : PostEffectsBase
	{
		[Token(Token = "0x2000061")]
		public enum ColorCorrectionMode
		{
			[Token(Token = "0x400023D")]
			Simple,
			[Token(Token = "0x400023E")]
			Advanced
		}

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationCurve redChannel;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve greenChannel;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve blueChannel;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool useDepthCorrection;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AnimationCurve zCurve;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve depthRedChannel;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AnimationCurve depthGreenChannel;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AnimationCurve depthBlueChannel;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Material ccMaterial;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material ccDepthMaterial;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Material selectiveCcMaterial;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Texture2D rgbChannelTex;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Texture2D rgbDepthChannelTex;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Texture2D zCurveTex;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float saturation;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public bool selectiveCc;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Color selectiveFromColor;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Color selectiveToColor;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public ColorCorrectionMode mode;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public bool updateTextures;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public Shader colorCorrectionCurvesShader;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Shader simpleColorCorrectionCurvesShader;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Shader colorCorrectionSelectiveShader;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool updateTexturesOnStartup;

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x187CE80", Offset = "0x187CE80", VA = "0x187CE80")]
		private new void Start()
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x187CEAC", Offset = "0x187CEAC", VA = "0x187CEAC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x187CEB0", Offset = "0x187CEB0", VA = "0x187CEB0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x187D194", Offset = "0x187D194", VA = "0x187D194")]
		public void UpdateParameters()
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x187D554", Offset = "0x187D554", VA = "0x187D554")]
		private void UpdateTextures()
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x187D558", Offset = "0x187D558", VA = "0x187D558")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x187D8A4", Offset = "0x187D8A4", VA = "0x187D8A4")]
		public ColorCorrectionCurves()
		{
		}
	}
	[Token(Token = "0x2000062")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x740CDC", Offset = "0x740CDC")]
	public class ColorCorrectionLookup : PostEffectsBase
	{
		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Shader shader;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Material material;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Texture3D converted3DLut;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string basedOnTempTex;

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x187DF34", Offset = "0x187DF34", VA = "0x187DF34", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x187DFA8", Offset = "0x187DFA8", VA = "0x187DFA8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x187E064", Offset = "0x187E064", VA = "0x187E064")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x187E110", Offset = "0x187E110", VA = "0x187E110")]
		public void SetIdentityLut()
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x187E344", Offset = "0x187E344", VA = "0x187E344")]
		public bool ValidDimensions(Texture2D tex2d)
		{
			return default(bool);
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x187E40C", Offset = "0x187E40C", VA = "0x187E40C")]
		public void Convert(Texture2D temp2DTex, string path)
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x187E790", Offset = "0x187E790", VA = "0x187E790")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x187E9A8", Offset = "0x187E9A8", VA = "0x187E9A8")]
		public ColorCorrectionLookup()
		{
		}
	}
	[Token(Token = "0x2000063")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x740D28", Offset = "0x740D28")]
	[ExecuteInEditMode]
	public class ColorCorrectionRamp : ImageEffectBase
	{
		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Texture textureRamp;

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x187EA04", Offset = "0x187EA04", VA = "0x187EA04")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x187EACC", Offset = "0x187EACC", VA = "0x187EACC")]
		public ColorCorrectionRamp()
		{
		}
	}
	[Token(Token = "0x2000064")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x740D74", Offset = "0x740D74")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x740D74", Offset = "0x740D74")]
	public class ContrastEnhance : PostEffectsBase
	{
		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x741DF4", Offset = "0x741DF4")]
		public float intensity;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x741E0C", Offset = "0x741E0C")]
		public float threshold;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Material separableBlurMaterial;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Material contrastCompositeMaterial;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x741E28", Offset = "0x741E28")]
		public float blurSpread;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader separableBlurShader;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Shader contrastCompositeShader;

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x1880220", Offset = "0x1880220", VA = "0x1880220", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x18802C0", Offset = "0x18802C0", VA = "0x18802C0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x1880654", Offset = "0x1880654", VA = "0x1880654")]
		public ContrastEnhance()
		{
		}
	}
	[Token(Token = "0x2000065")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x740E08", Offset = "0x740E08")]
	public class ContrastStretch : MonoBehaviour
	{
		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x741E40", Offset = "0x741E40")]
		public float adaptationSpeed;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x741E5C", Offset = "0x741E5C")]
		public float limitMinimum;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x741E74", Offset = "0x741E74")]
		public float limitMaximum;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private RenderTexture[] adaptRenderTex;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int curAdaptIndex;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader shaderLum;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material m_materialLum;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader shaderReduce;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material m_materialReduce;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader shaderAdapt;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material m_materialAdapt;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Shader shaderApply;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material m_materialApply;

		[Token(Token = "0x17000061")]
		protected Material materialLum
		{
			[Token(Token = "0x6000152")]
			[Address(RVA = "0x188066C", Offset = "0x188066C", VA = "0x188066C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000062")]
		protected Material materialReduce
		{
			[Token(Token = "0x6000153")]
			[Address(RVA = "0x1880748", Offset = "0x1880748", VA = "0x1880748")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000063")]
		protected Material materialAdapt
		{
			[Token(Token = "0x6000154")]
			[Address(RVA = "0x1880824", Offset = "0x1880824", VA = "0x1880824")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000064")]
		protected Material materialApply
		{
			[Token(Token = "0x6000155")]
			[Address(RVA = "0x1880900", Offset = "0x1880900", VA = "0x1880900")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x18809DC", Offset = "0x18809DC", VA = "0x18809DC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x1880A70", Offset = "0x1880A70", VA = "0x1880A70")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x1880BD0", Offset = "0x1880BD0", VA = "0x1880BD0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x1880DFC", Offset = "0x1880DFC", VA = "0x1880DFC")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x1881060", Offset = "0x1881060", VA = "0x1881060")]
		private void CalculateAdaptation(Texture curTexture)
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x188125C", Offset = "0x188125C", VA = "0x188125C")]
		public ContrastStretch()
		{
		}
	}
	[Token(Token = "0x2000066")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x740E54", Offset = "0x740E54")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x740E54", Offset = "0x740E54")]
	public class CreaseShading : PostEffectsBase
	{
		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float intensity;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int softness;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float spread;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader blurShader;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material blurMaterial;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader depthFetchShader;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material depthFetchMaterial;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader creaseApplyShader;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material creaseApplyMaterial;

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x18812DC", Offset = "0x18812DC", VA = "0x18812DC", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x18813AC", Offset = "0x18813AC", VA = "0x18813AC")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x1881780", Offset = "0x1881780", VA = "0x1881780")]
		public CreaseShading()
		{
		}
	}
	[Token(Token = "0x2000067")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x740EE8", Offset = "0x740EE8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x740EE8", Offset = "0x740EE8")]
	public class DepthOfField : PostEffectsBase
	{
		[Token(Token = "0x2000068")]
		public enum BlurType
		{
			[Token(Token = "0x400027B")]
			DiscBlur,
			[Token(Token = "0x400027C")]
			DX11
		}

		[Token(Token = "0x2000069")]
		public enum BlurSampleCount
		{
			[Token(Token = "0x400027E")]
			Low,
			[Token(Token = "0x400027F")]
			Medium,
			[Token(Token = "0x4000280")]
			High
		}

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool visualizeFocus;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float focalLength;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float focalSize;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float aperture;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform focalTransform;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float maxBlurSize;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool highResolution;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public BlurType blurType;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public BlurSampleCount blurSampleCount;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool nearBlur;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float foregroundOverlap;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader dofHdrShader;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material dofHdrMaterial;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Shader dx11BokehShader;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material dx11bokehMaterial;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float dx11BokehThreshold;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float dx11SpawnHeuristic;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Texture2D dx11BokehTexture;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float dx11BokehScale;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float dx11BokehIntensity;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float focalDistance01;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private ComputeBuffer cbDrawArgs;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private ComputeBuffer cbPoints;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private float internalBlurWidth;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Camera cachedCamera;

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x1881848", Offset = "0x1881848", VA = "0x1881848", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x1881A58", Offset = "0x1881A58", VA = "0x1881A58")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x1881ADC", Offset = "0x1881ADC", VA = "0x1881ADC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x1881BF8", Offset = "0x1881BF8", VA = "0x1881BF8")]
		private void ReleaseComputeResources()
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x1881904", Offset = "0x1881904", VA = "0x1881904")]
		private void CreateComputeResources()
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x1881C54", Offset = "0x1881C54", VA = "0x1881C54")]
		private float FocalDistance01(float worldDist)
		{
			return default(float);
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x1881D44", Offset = "0x1881D44", VA = "0x1881D44")]
		private void WriteCoc(RenderTexture fromTo, bool fgDilate)
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x1882078", Offset = "0x1882078", VA = "0x1882078")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x1883698", Offset = "0x1883698", VA = "0x1883698")]
		public DepthOfField()
		{
		}
	}
	[Token(Token = "0x200006A")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x740F7C", Offset = "0x740F7C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x740F7C", Offset = "0x740F7C")]
	public class DepthOfFieldDeprecated : PostEffectsBase
	{
		[Token(Token = "0x200006B")]
		public enum Dof34QualitySetting
		{
			[Token(Token = "0x40002AD")]
			OnlyBackground = 1,
			[Token(Token = "0x40002AE")]
			BackgroundAndForeground
		}

		[Token(Token = "0x200006C")]
		public enum DofResolution
		{
			[Token(Token = "0x40002B0")]
			High = 2,
			[Token(Token = "0x40002B1")]
			Medium,
			[Token(Token = "0x40002B2")]
			Low
		}

		[Token(Token = "0x200006D")]
		public enum DofBlurriness
		{
			[Token(Token = "0x40002B4")]
			Low = 1,
			[Token(Token = "0x40002B5")]
			High = 2,
			[Token(Token = "0x40002B6")]
			VeryHigh = 4
		}

		[Token(Token = "0x200006E")]
		public enum BokehDestination
		{
			[Token(Token = "0x40002B8")]
			Background = 1,
			[Token(Token = "0x40002B9")]
			Foreground,
			[Token(Token = "0x40002BA")]
			BackgroundAndForeground
		}

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int SMOOTH_DOWNSAMPLE_PASS;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static float BOKEH_EXTRA_BLUR;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Dof34QualitySetting quality;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public DofResolution resolution;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool simpleTweakMode;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float focalPoint;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float smoothness;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float focalZDistance;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float focalZStartCurve;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float focalZEndCurve;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float focalStartCurve;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float focalEndCurve;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float focalDistance01;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform objectFocus;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float focalSize;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public DofBlurriness bluriness;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float maxBlurSpread;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float foregroundBlurExtrude;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Shader dofBlurShader;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Material dofBlurMaterial;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Shader dofShader;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Material dofMaterial;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public bool visualize;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public BokehDestination bokehDestination;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float widthOverHeight;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private float oneOverBaseSize;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool bokeh;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		public bool bokehSupport;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Shader bokehShader;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Texture2D bokehTexture;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float bokehScale;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public float bokehIntensity;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public float bokehThresholdContrast;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float bokehThresholdLuminance;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public int bokehDownsample;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Material bokehMaterial;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Camera _camera;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RenderTexture foregroundTexture;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private RenderTexture mediumRezWorkTexture;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private RenderTexture finalDefocus;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private RenderTexture lowRezWorkTexture;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private RenderTexture bokehSource;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private RenderTexture bokehSource2;

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x18836F0", Offset = "0x18836F0", VA = "0x18836F0")]
		private void CreateMaterials()
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x1883808", Offset = "0x1883808", VA = "0x1883808", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x1883950", Offset = "0x1883950", VA = "0x1883950")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x18839AC", Offset = "0x18839AC", VA = "0x18839AC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x1883A30", Offset = "0x1883A30", VA = "0x1883A30")]
		private float FocalDistance01(float worldDist)
		{
			return default(float);
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x1883B20", Offset = "0x1883B20", VA = "0x1883B20")]
		private int GetDividerBasedOnQuality()
		{
			return default(int);
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x1883B44", Offset = "0x1883B44", VA = "0x1883B44")]
		private int GetLowResolutionDividerBasedOnQuality(int baseDivider)
		{
			return default(int);
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x1883B68", Offset = "0x1883B68", VA = "0x1883B68")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x1884A40", Offset = "0x1884A40", VA = "0x1884A40")]
		private void Blur(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x1885134", Offset = "0x1885134", VA = "0x1885134")]
		private void BlurFg(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x18855AC", Offset = "0x18855AC", VA = "0x18855AC")]
		private void BlurHex(RenderTexture from, RenderTexture to, int blurPass, float spread, RenderTexture tmp)
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x18848E0", Offset = "0x18848E0", VA = "0x18848E0")]
		private void Downsample(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x1884CE4", Offset = "0x1884CE4", VA = "0x1884CE4")]
		private void AddBokeh(RenderTexture bokehInfo, RenderTexture tempTex, RenderTexture finalTarget)
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x1885404", Offset = "0x1885404", VA = "0x1885404")]
		private void ReleaseTextures()
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x1884514", Offset = "0x1884514", VA = "0x1884514")]
		private void AllocateTextures(bool blurForeground, RenderTexture source, int divider, int lowTexDivider)
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x18857DC", Offset = "0x18857DC", VA = "0x18857DC")]
		public DepthOfFieldDeprecated()
		{
		}
	}
	[Token(Token = "0x200006F")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x741010", Offset = "0x741010")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x741010", Offset = "0x741010")]
	public class EdgeDetection : PostEffectsBase
	{
		[Token(Token = "0x2000070")]
		public enum EdgeDetectMode
		{
			[Token(Token = "0x40002C7")]
			TriangleDepthNormals,
			[Token(Token = "0x40002C8")]
			RobertsCrossDepthNormals,
			[Token(Token = "0x40002C9")]
			SobelDepth,
			[Token(Token = "0x40002CA")]
			SobelDepthThin,
			[Token(Token = "0x40002CB")]
			TriangleLuminance
		}

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EdgeDetectMode mode;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float sensitivityDepth;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float sensitivityNormals;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float lumThreshold;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float edgeExp;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float sampleDist;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float edgesOnly;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Color edgesOnlyBgColor;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader edgeDetectShader;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material edgeDetectMaterial;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private EdgeDetectMode oldMode;

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x1265D54", Offset = "0x1265D54", VA = "0x1265D54", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x1265EA8", Offset = "0x1265EA8", VA = "0x1265EA8")]
		private new void Start()
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x1265DEC", Offset = "0x1265DEC", VA = "0x1265DEC")]
		private void SetCameraFlag()
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x1265EB4", Offset = "0x1265EB4", VA = "0x1265EB4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x1265EB8", Offset = "0x1265EB8", VA = "0x1265EB8")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x12660E0", Offset = "0x12660E0", VA = "0x12660E0")]
		public EdgeDetection()
		{
		}
	}
	[Token(Token = "0x2000071")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7410A4", Offset = "0x7410A4")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7410A4", Offset = "0x7410A4")]
	public class Fisheye : PostEffectsBase
	{
		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x741E8C", Offset = "0x741E8C")]
		public float strengthX;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x741EA4", Offset = "0x741EA4")]
		public float strengthY;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Shader fishEyeShader;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Material fisheyeMaterial;

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x1267634", Offset = "0x1267634", VA = "0x1267634", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x12676AC", Offset = "0x12676AC", VA = "0x12676AC")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x1267824", Offset = "0x1267824", VA = "0x1267824")]
		public Fisheye()
		{
		}
	}
	[Token(Token = "0x2000072")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x741138", Offset = "0x741138")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x741138", Offset = "0x741138")]
	internal class GlobalFog : PostEffectsBase
	{
		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x741EBC", Offset = "0x741EBC")]
		public bool distanceFog;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x741EF4", Offset = "0x741EF4")]
		public bool excludeFarPixels;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x741F2C", Offset = "0x741F2C")]
		public bool useRadialDistance;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x741F64", Offset = "0x741F64")]
		public bool heightFog;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x741F9C", Offset = "0x741F9C")]
		public float height;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x741FD4", Offset = "0x741FD4")]
		public float heightDensity;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x741FF0", Offset = "0x741FF0")]
		public float startDistance;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader fogShader;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material fogMaterial;

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x126A714", Offset = "0x126A714", VA = "0x126A714", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x126A794", Offset = "0x126A794", VA = "0x126A794")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x126AD90", Offset = "0x126AD90", VA = "0x126AD90")]
		public GlobalFog()
		{
		}
	}
	[Token(Token = "0x2000073")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7411CC", Offset = "0x7411CC")]
	public class Grayscale : ImageEffectBase
	{
		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Texture textureRamp;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x742028", Offset = "0x742028")]
		public float rampOffset;

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x126ADB4", Offset = "0x126ADB4", VA = "0x126ADB4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x126AF80", Offset = "0x126AF80", VA = "0x126AF80")]
		public Grayscale()
		{
		}
	}
	[Token(Token = "0x2000074")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x741218", Offset = "0x741218")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x741218", Offset = "0x741218")]
	public class ImageEffectBase : MonoBehaviour
	{
		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Shader shader;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material m_Material;

		[Token(Token = "0x17000065")]
		protected Material material
		{
			[Token(Token = "0x6000188")]
			[Address(RVA = "0x126AEA4", Offset = "0x126AEA4", VA = "0x126AEA4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x126B764", Offset = "0x126B764", VA = "0x126B764", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x126B810", Offset = "0x126B810", VA = "0x126B810", Slot = "5")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x126AF88", Offset = "0x126AF88", VA = "0x126AF88")]
		public ImageEffectBase()
		{
		}
	}
	[Token(Token = "0x2000075")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x74129C", Offset = "0x74129C")]
	public class ImageEffects
	{
		[Token(Token = "0x600018B")]
		[Address(RVA = "0x126BCFC", Offset = "0x126BCFC", VA = "0x126BCFC")]
		public static void RenderDistortion(Material material, RenderTexture source, RenderTexture destination, float angle, Vector2 center, Vector2 radius)
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x126BF48", Offset = "0x126BF48", VA = "0x126BF48")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x7425F0", Offset = "0x7425F0")]
		public static void Blit(RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x126BFBC", Offset = "0x126BFBC", VA = "0x126BFBC")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x742628", Offset = "0x742628")]
		public static void BlitWithMaterial(Material material, RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x126C038", Offset = "0x126C038", VA = "0x126C038")]
		public ImageEffects()
		{
		}
	}
	[Token(Token = "0x2000076")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7412D4", Offset = "0x7412D4")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7412D4", Offset = "0x7412D4")]
	[ExecuteInEditMode]
	public class MotionBlur : ImageEffectBase
	{
		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x742040", Offset = "0x742040")]
		public float blurAmount;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool extraBlur;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private RenderTexture accumTexture;

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x126E660", Offset = "0x126E660", VA = "0x126E660", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x126E664", Offset = "0x126E664", VA = "0x126E664", Slot = "5")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x126E6D4", Offset = "0x126E6D4", VA = "0x126E6D4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x126EA70", Offset = "0x126EA70", VA = "0x126EA70")]
		public MotionBlur()
		{
		}
	}
	[Token(Token = "0x2000077")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x741368", Offset = "0x741368")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x741368", Offset = "0x741368")]
	[ExecuteInEditMode]
	public class NoiseAndGrain : PostEffectsBase
	{
		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float intensityMultiplier;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float generalIntensity;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float blackIntensity;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float whiteIntensity;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float midGrey;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool dx11Grain;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float softness;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool monochrome;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 intensities;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 tiling;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float monochromeTiling;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public FilterMode filterMode;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Texture2D noiseTexture;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Shader noiseShader;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Material noiseMaterial;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Shader dx11NoiseShader;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Material dx11NoiseMaterial;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static float TILE_AMOUNT;

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x17090C8", Offset = "0x17090C8", VA = "0x17090C8", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x1709748", Offset = "0x1709748", VA = "0x1709748")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x1709F4C", Offset = "0x1709F4C", VA = "0x1709F4C")]
		private static void DrawNoiseQuadGrid(RenderTexture source, RenderTexture dest, Material fxMaterial, Texture2D noise, int passNr)
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x170A2A0", Offset = "0x170A2A0", VA = "0x170A2A0")]
		public NoiseAndGrain()
		{
		}
	}
	[Token(Token = "0x2000078")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7413FC", Offset = "0x7413FC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7413FC", Offset = "0x7413FC")]
	[ExecuteInEditMode]
	public class NoiseAndScratches : MonoBehaviour
	{
		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool monochrome;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool rgbFallback;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74205C", Offset = "0x74205C")]
		public float grainIntensityMin;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x742074", Offset = "0x742074")]
		public float grainIntensityMax;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74208C", Offset = "0x74208C")]
		public float grainSize;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7420AC", Offset = "0x7420AC")]
		public float scratchIntensityMin;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7420C4", Offset = "0x7420C4")]
		public float scratchIntensityMax;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7420DC", Offset = "0x7420DC")]
		public float scratchFPS;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7420F4", Offset = "0x7420F4")]
		public float scratchJitter;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Texture grainTexture;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Texture scratchTexture;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader shaderRGB;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Shader shaderYUV;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Material m_MaterialRGB;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material m_MaterialYUV;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float scratchTimeLeft;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float scratchX;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float scratchY;

		[Token(Token = "0x17000066")]
		protected Material material
		{
			[Token(Token = "0x6000199")]
			[Address(RVA = "0x170A510", Offset = "0x170A510", VA = "0x170A510")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x170A3BC", Offset = "0x170A3BC", VA = "0x170A3BC")]
		protected void Start()
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x170A68C", Offset = "0x170A68C", VA = "0x170A68C")]
		protected void OnDisable()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x170A78C", Offset = "0x170A78C", VA = "0x170A78C")]
		private void SanitizeParameters()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x170A880", Offset = "0x170A880", VA = "0x170A880")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x170AC00", Offset = "0x170AC00", VA = "0x170AC00")]
		public NoiseAndScratches()
		{
		}
	}
	[Token(Token = "0x2000079")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x741490", Offset = "0x741490")]
	public class PostEffectsBase : MonoBehaviour
	{
		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected bool supportHDRTextures;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		protected bool supportDX11;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		protected bool isSupported;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<Material> createdMaterials;

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x170926C", Offset = "0x170926C", VA = "0x170926C")]
		protected Material CheckShaderAndCreateMaterial(Shader s, Material m2Create)
		{
			return null;
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x170CF6C", Offset = "0x170CF6C", VA = "0x170CF6C")]
		protected Material CreateMaterial(Shader s, Material m2Create)
		{
			return null;
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x170D174", Offset = "0x170D174", VA = "0x170D174")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x170D180", Offset = "0x170D180", VA = "0x170D180")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x170D184", Offset = "0x170D184", VA = "0x170D184")]
		private void RemoveCreatedMaterials()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x170D254", Offset = "0x170D254", VA = "0x170D254")]
		protected bool CheckSupport()
		{
			return default(bool);
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x170D25C", Offset = "0x170D25C", VA = "0x170D25C", Slot = "4")]
		public virtual bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x170D320", Offset = "0x170D320", VA = "0x170D320")]
		protected void Start()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x1709168", Offset = "0x1709168", VA = "0x1709168")]
		protected bool CheckSupport(bool needDepth)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x170D32C", Offset = "0x170D32C", VA = "0x170D32C")]
		protected bool CheckSupport(bool needDepth, bool needHdr)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x170D388", Offset = "0x170D388", VA = "0x170D388")]
		public bool Dx11Support()
		{
			return default(bool);
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x170968C", Offset = "0x170968C", VA = "0x170968C")]
		protected void ReportAutoDisable()
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x170D390", Offset = "0x170D390", VA = "0x170D390")]
		private bool CheckShader(Shader s)
		{
			return default(bool);
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x170CF40", Offset = "0x170CF40", VA = "0x170CF40")]
		protected void NotSupported()
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x170D604", Offset = "0x170D604", VA = "0x170D604")]
		protected void DrawBorder(RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x170A2DC", Offset = "0x170A2DC", VA = "0x170A2DC")]
		public PostEffectsBase()
		{
		}
	}
	[Token(Token = "0x200007A")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x741500", Offset = "0x741500")]
	[ExecuteInEditMode]
	internal class PostEffectsHelper : MonoBehaviour
	{
		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x170D980", Offset = "0x170D980", VA = "0x170D980")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x170D9F4", Offset = "0x170D9F4", VA = "0x170D9F4")]
		private static void DrawLowLevelPlaneAlignedWithCamera(float dist, RenderTexture source, RenderTexture dest, Material material, Camera cameraForProjectionMatrix)
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x170DC4C", Offset = "0x170DC4C", VA = "0x170DC4C")]
		private static void DrawBorder(RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x170DFC4", Offset = "0x170DFC4", VA = "0x170DFC4")]
		private static void DrawLowLevelQuad(float x1, float x2, float y1, float y2, RenderTexture source, RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x170E16C", Offset = "0x170E16C", VA = "0x170E16C")]
		public PostEffectsHelper()
		{
		}
	}
	[Token(Token = "0x200007B")]
	internal class Quads
	{
		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Mesh[] meshes;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int currentQuads;

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x170E5A0", Offset = "0x170E5A0", VA = "0x170E5A0")]
		private static bool HasMeshes()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x170E6CC", Offset = "0x170E6CC", VA = "0x170E6CC")]
		public static void Cleanup()
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x170E8C4", Offset = "0x170E8C4", VA = "0x170E8C4")]
		public static Mesh[] GetMeshes(int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x170EB60", Offset = "0x170EB60", VA = "0x170EB60")]
		private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x170EF20", Offset = "0x170EF20", VA = "0x170EF20")]
		public Quads()
		{
		}
	}
	[Token(Token = "0x200007C")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x741570", Offset = "0x741570")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x741570", Offset = "0x741570")]
	public class ScreenOverlay : PostEffectsBase
	{
		[Token(Token = "0x200007D")]
		public enum OverlayBlendMode
		{
			[Token(Token = "0x4000310")]
			Additive,
			[Token(Token = "0x4000311")]
			ScreenBlend,
			[Token(Token = "0x4000312")]
			Multiply,
			[Token(Token = "0x4000313")]
			Overlay,
			[Token(Token = "0x4000314")]
			AlphaBlend
		}

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public OverlayBlendMode blendMode;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float intensity;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Texture2D texture;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader overlayShader;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material overlayMaterial;

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x171E390", Offset = "0x171E390", VA = "0x171E390", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x171E3FC", Offset = "0x171E3FC", VA = "0x171E3FC")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x171E584", Offset = "0x171E584", VA = "0x171E584")]
		public ScreenOverlay()
		{
		}
	}
	[Token(Token = "0x200007E")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x741604", Offset = "0x741604")]
	[ExecuteInEditMode]
	public class SepiaTone : ImageEffectBase
	{
		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x171E594", Offset = "0x171E594", VA = "0x171E594")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x171E624", Offset = "0x171E624", VA = "0x171E624")]
		public SepiaTone()
		{
		}
	}
	[Token(Token = "0x200007F")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x741650", Offset = "0x741650")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x741650", Offset = "0x741650")]
	public class SunShafts : PostEffectsBase
	{
		[Token(Token = "0x2000080")]
		public enum SunShaftsResolution
		{
			[Token(Token = "0x4000324")]
			Low,
			[Token(Token = "0x4000325")]
			Normal,
			[Token(Token = "0x4000326")]
			High
		}

		[Token(Token = "0x2000081")]
		public enum ShaftsScreenBlendMode
		{
			[Token(Token = "0x4000328")]
			Screen,
			[Token(Token = "0x4000329")]
			Add
		}

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SunShaftsResolution resolution;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public ShaftsScreenBlendMode screenBlendMode;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform sunTransform;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int radialBlurIterations;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Color sunColor;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Color sunThreshold;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float sunShaftBlurRadius;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float sunShaftIntensity;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float maxRadius;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useDepthTexture;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Shader sunShaftsShader;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Material sunShaftsMaterial;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Shader simpleClearShader;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Material simpleClearMaterial;

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x171F4E8", Offset = "0x171F4E8", VA = "0x171F4E8", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x171F578", Offset = "0x171F578", VA = "0x171F578")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x171FD58", Offset = "0x171FD58", VA = "0x171FD58")]
		public SunShafts()
		{
		}
	}
	[Token(Token = "0x2000082")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7416E4", Offset = "0x7416E4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7416E4", Offset = "0x7416E4")]
	internal class TiltShift : PostEffectsBase
	{
		[Token(Token = "0x2000083")]
		public enum TiltShiftMode
		{
			[Token(Token = "0x4000332")]
			TiltShiftMode,
			[Token(Token = "0x4000333")]
			IrisMode
		}

		[Token(Token = "0x2000084")]
		public enum TiltShiftQuality
		{
			[Token(Token = "0x4000335")]
			Preview,
			[Token(Token = "0x4000336")]
			Low,
			[Token(Token = "0x4000337")]
			Normal,
			[Token(Token = "0x4000338")]
			High
		}

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TiltShiftMode mode;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public TiltShiftQuality quality;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74210C", Offset = "0x74210C")]
		public float blurArea;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x742124", Offset = "0x742124")]
		public float maxBlurSize;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74213C", Offset = "0x74213C")]
		public int downsample;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Shader tiltShiftShader;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Material tiltShiftMaterial;

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x171FDEC", Offset = "0x171FDEC", VA = "0x171FDEC", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x171FE58", Offset = "0x171FE58", VA = "0x171FE58")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x1720114", Offset = "0x1720114", VA = "0x1720114")]
		public TiltShift()
		{
		}
	}
	[Token(Token = "0x2000085")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x741768", Offset = "0x741768")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x741768", Offset = "0x741768")]
	public class Tonemapping : PostEffectsBase
	{
		[Token(Token = "0x2000086")]
		public enum TonemapperType
		{
			[Token(Token = "0x4000347")]
			SimpleReinhard,
			[Token(Token = "0x4000348")]
			UserCurve,
			[Token(Token = "0x4000349")]
			Hable,
			[Token(Token = "0x400034A")]
			Photographic,
			[Token(Token = "0x400034B")]
			OptimizedHejiDawson,
			[Token(Token = "0x400034C")]
			AdaptiveReinhard,
			[Token(Token = "0x400034D")]
			AdaptiveReinhardAutoWhite
		}

		[Token(Token = "0x2000087")]
		public enum AdaptiveTexSize
		{
			[Token(Token = "0x400034F")]
			Square16 = 0x10,
			[Token(Token = "0x4000350")]
			Square32 = 0x20,
			[Token(Token = "0x4000351")]
			Square64 = 0x40,
			[Token(Token = "0x4000352")]
			Square128 = 0x80,
			[Token(Token = "0x4000353")]
			Square256 = 0x100,
			[Token(Token = "0x4000354")]
			Square512 = 0x200,
			[Token(Token = "0x4000355")]
			Square1024 = 0x400
		}

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TonemapperType type;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public AdaptiveTexSize adaptiveTextureSize;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve remapCurve;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Texture2D curveTex;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float exposureAdjustment;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float middleGrey;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float white;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float adaptionSpeed;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Shader tonemapper;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool validRenderTextureFormat;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material tonemapMaterial;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private RenderTexture rt;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RenderTextureFormat rtFormat;

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x17201E4", Offset = "0x17201E4", VA = "0x17201E4", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x1720350", Offset = "0x1720350", VA = "0x1720350")]
		public float UpdateCurve()
		{
			return default(float);
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x1720604", Offset = "0x1720604", VA = "0x1720604")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x1720790", Offset = "0x1720790", VA = "0x1720790")]
		private bool CreateInternalRenderTexture()
		{
			return default(bool);
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x1720898", Offset = "0x1720898", VA = "0x1720898")]
		[ImageEffectTransformsToLDR]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x17210FC", Offset = "0x17210FC", VA = "0x17210FC")]
		public Tonemapping()
		{
		}
	}
	[Token(Token = "0x2000088")]
	internal class Triangles
	{
		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Mesh[] meshes;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int currentTris;

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x1A78DF0", Offset = "0x1A78DF0", VA = "0x1A78DF0")]
		private static bool HasMeshes()
		{
			return default(bool);
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x1A78F34", Offset = "0x1A78F34", VA = "0x1A78F34")]
		private static void Cleanup()
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x1A7912C", Offset = "0x1A7912C", VA = "0x1A7912C")]
		private static Mesh[] GetMeshes(int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x1A793C8", Offset = "0x1A793C8", VA = "0x1A793C8")]
		private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x1A796E4", Offset = "0x1A796E4", VA = "0x1A796E4")]
		public Triangles()
		{
		}
	}
	[Token(Token = "0x2000089")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7417FC", Offset = "0x7417FC")]
	public class Twirl : ImageEffectBase
	{
		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector2 radius;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x742154", Offset = "0x742154")]
		public float angle;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector2 center;

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x1A798D4", Offset = "0x1A798D4", VA = "0x1A798D4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x1A79920", Offset = "0x1A79920", VA = "0x1A79920")]
		public Twirl()
		{
		}
	}
	[Token(Token = "0x200008A")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x741848", Offset = "0x741848")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x741848", Offset = "0x741848")]
	public class VignetteAndChromaticAberration : PostEffectsBase
	{
		[Token(Token = "0x200008B")]
		public enum AberrationMode
		{
			[Token(Token = "0x400036A")]
			Simple,
			[Token(Token = "0x400036B")]
			Advanced
		}

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AberrationMode mode;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float intensity;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float chromaticAberration;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float axialAberration;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float blur;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float blurSpread;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float luminanceDependency;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float blurDistance;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader vignetteShader;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Shader separableBlurShader;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader chromAberrationShader;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material m_VignetteMaterial;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Material m_SeparableBlurMaterial;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material m_ChromAberrationMaterial;

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x1A7C7F8", Offset = "0x1A7C7F8", VA = "0x1A7C7F8", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x1A7C8C0", Offset = "0x1A7C8C0", VA = "0x1A7C8C0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x1A7CEB0", Offset = "0x1A7CEB0", VA = "0x1A7CEB0")]
		public VignetteAndChromaticAberration()
		{
		}
	}
	[Token(Token = "0x200008C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7418DC", Offset = "0x7418DC")]
	[ExecuteInEditMode]
	public class Vortex : ImageEffectBase
	{
		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector2 radius;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float angle;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector2 center;

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x1A7CEE0", Offset = "0x1A7CEE0", VA = "0x1A7CEE0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x1A7CF2C", Offset = "0x1A7CF2C", VA = "0x1A7CF2C")]
		public Vortex()
		{
		}
	}
}
namespace UnityStandardAssets.CinematicEffects
{
	[Token(Token = "0x200008D")]
	public static class ImageEffectHelper
	{
		[Token(Token = "0x17000067")]
		public static bool supportsDX11
		{
			[Token(Token = "0x60001D9")]
			[Address(RVA = "0x126BCCC", Offset = "0x126BCCC", VA = "0x126BCCC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x126B8BC", Offset = "0x126B8BC", VA = "0x126B8BC")]
		public static bool IsSupported(Shader s, bool needDepth, bool needHdr, MonoBehaviour effect)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x126BBF8", Offset = "0x126BBF8", VA = "0x126BBF8")]
		public static Material CheckShaderAndCreateMaterial(Shader s)
		{
			return null;
		}
	}
	[Token(Token = "0x200008E")]
	public sealed class MinAttribute : PropertyAttribute
	{
		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly float min;

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x126C748", Offset = "0x126C748", VA = "0x126C748")]
		public MinAttribute(float min)
		{
		}
	}
	[Token(Token = "0x200008F")]
	public class RenderTextureUtility
	{
		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<RenderTexture> m_TemporaryRTs;

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x1714814", Offset = "0x1714814", VA = "0x1714814")]
		public RenderTexture GetTemporaryRenderTexture(int width, int height, int depthBuffer = 0, RenderTextureFormat format = RenderTextureFormat.ARGBHalf, FilterMode filterMode = FilterMode.Bilinear)
		{
			return null;
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x1714900", Offset = "0x1714900", VA = "0x1714900")]
		public void ReleaseTemporaryRenderTexture(RenderTexture rt)
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x1714AB8", Offset = "0x1714AB8", VA = "0x1714AB8")]
		public void ReleaseAllTemporaryRenderTextures()
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x1714B74", Offset = "0x1714B74", VA = "0x1714B74")]
		public RenderTextureUtility()
		{
		}
	}
}
namespace Helper
{
	[Token(Token = "0x2000090")]
	internal class CollectionMap<TKey, TValue> : ThreadSafeDictionary<TKey, TValue> where TValue : new()
	{
		[Token(Token = "0x60001DF")]
		public bool TryAddDefault(TKey key)
		{
			return default(bool);
		}

		[Token(Token = "0x60001E0")]
		public CollectionMap()
		{
		}
	}
	[Token(Token = "0x2000091")]
	public static class ExceptionHelper
	{
		[Token(Token = "0x4000371")]
		private const int E_NOTIMPL = -2147467263;

		[Token(Token = "0x4000372")]
		private const int E_OUTOFMEMORY = -2147024882;

		[Token(Token = "0x4000373")]
		private const int E_INVALIDARG = -2147024809;

		[Token(Token = "0x4000374")]
		private const int E_POINTER = -2147467261;

		[Token(Token = "0x4000375")]
		private const int E_PENDING = -2147483638;

		[Token(Token = "0x4000376")]
		private const int E_FAIL = -2147467259;

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x1266C20", Offset = "0x1266C20", VA = "0x1266C20")]
		public static void CheckLastError()
		{
		}
	}
	[Token(Token = "0x2000092")]
	internal interface INativeWrapper
	{
		[Token(Token = "0x17000068")]
		IntPtr nativePtr
		{
			[Token(Token = "0x60001E2")]
			get;
		}
	}
	[Token(Token = "0x2000093")]
	public static class NativeObjectCache
	{
		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static object _lock;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Dictionary<Type, Dictionary<IntPtr, WeakReference>> _objectCache;

		[Token(Token = "0x60001E3")]
		public static void AddObject<T>(IntPtr nativePtr, T obj) where T : class
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x126EBD8", Offset = "0x126EBD8", VA = "0x126EBD8")]
		public static void Flush()
		{
		}

		[Token(Token = "0x60001E5")]
		public static void RemoveObject<T>(IntPtr nativePtr)
		{
		}

		[Token(Token = "0x60001E6")]
		public static T GetObject<T>(IntPtr nativePtr) where T : class
		{
			return null;
		}

		[Token(Token = "0x60001E7")]
		public static T CreateOrGetObject<T>(IntPtr nativePtr, Func<IntPtr, T> create) where T : class
		{
			return null;
		}
	}
	[Token(Token = "0x2000094")]
	public static class NativeWrapper
	{
		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x126EF78", Offset = "0x126EF78", VA = "0x126EF78")]
		public static IntPtr GetNativePtr(object obj)
		{
			return default(IntPtr);
		}
	}
	[Token(Token = "0x2000095")]
	public class SmartGCHandle : IDisposable
	{
		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private GCHandle handle;

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x171EC24", Offset = "0x171EC24", VA = "0x171EC24")]
		public SmartGCHandle(GCHandle handle)
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x171EC50", Offset = "0x171EC50", VA = "0x171EC50", Slot = "1")]
		~SmartGCHandle()
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x171ECC4", Offset = "0x171ECC4", VA = "0x171ECC4")]
		public IntPtr AddrOfPinnedObject()
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x171ECD0", Offset = "0x171ECD0", VA = "0x171ECD0", Slot = "5")]
		public virtual void Dispose()
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x171ECE0", Offset = "0x171ECE0", VA = "0x171ECE0", Slot = "6")]
		protected virtual void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x171ECEC", Offset = "0x171ECEC", VA = "0x171ECEC")]
		public static implicit operator GCHandle(SmartGCHandle other)
		{
			return default(GCHandle);
		}
	}
	[Token(Token = "0x2000096")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x741928", Offset = "0x741928")]
	public class ThreadSafeDictionary<TKey, TValue>
	{
		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected readonly Dictionary<TKey, TValue> _impl;

		[Token(Token = "0x17000069")]
		public TValue Item
		{
			[Token(Token = "0x60001F0")]
			get
			{
				return (TValue)null;
			}
			[Token(Token = "0x60001F1")]
			set
			{
			}
		}

		[Token(Token = "0x60001F2")]
		public void Add(TKey key, TValue value)
		{
		}

		[Token(Token = "0x60001F3")]
		public bool TryGetValue(TKey key, out TValue value)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F4")]
		public bool Remove(TKey key)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F5")]
		public void Clear()
		{
		}

		[Token(Token = "0x60001F6")]
		public ThreadSafeDictionary()
		{
		}
	}
}
namespace Windows.Data
{
	[Token(Token = "0x2000097")]
	public sealed class PropertyChangedEventArgs : EventArgs, INativeWrapper
	{
		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal IntPtr _pNative;

		[Token(Token = "0x1700006A")]
		private IntPtr Helper.INativeWrapper.nativePtr
		{
			[Token(Token = "0x60001F7")]
			[Address(RVA = "0x170E174", Offset = "0x170E174", VA = "0x170E174", Slot = "4")]
			get
			{
				return default(IntPtr);
			}
		}

		[Token(Token = "0x1700006B")]
		public string PropertyName
		{
			[Token(Token = "0x60001FE")]
			[Address(RVA = "0x170E4A8", Offset = "0x170E4A8", VA = "0x170E4A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x170E17C", Offset = "0x170E17C", VA = "0x170E17C")]
		internal PropertyChangedEventArgs(IntPtr pNative)
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x170E27C", Offset = "0x170E27C", VA = "0x170E27C", Slot = "1")]
		~PropertyChangedEventArgs()
		{
		}

		[PreserveSig]
		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x170E394", Offset = "0x170E394", VA = "0x170E394")]
		private static extern void Windows_Data_PropertyChangedEventArgs_ReleaseObject(ref IntPtr pNative);

		[PreserveSig]
		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x170E1F8", Offset = "0x170E1F8", VA = "0x170E1F8")]
		private static extern void Windows_Data_PropertyChangedEventArgs_AddRefObject(ref IntPtr pNative);

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x170E2E8", Offset = "0x170E2E8", VA = "0x170E2E8")]
		private void Dispose(bool disposing)
		{
		}

		[PreserveSig]
		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x170E41C", Offset = "0x170E41C", VA = "0x170E41C")]
		private static extern IntPtr Windows_Data_PropertyChangedEventArgs_get_PropertyName(IntPtr pNative);

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x170E418", Offset = "0x170E418", VA = "0x170E418")]
		private void __EventCleanup()
		{
		}
	}
}
namespace Windows.Kinect
{
	[Token(Token = "0x2000098")]
	public struct CameraIntrinsics
	{
		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x742170", Offset = "0x742170")]
		private float <FocalLengthX>k__BackingField;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x742180", Offset = "0x742180")]
		private float <FocalLengthY>k__BackingField;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x742190", Offset = "0x742190")]
		private float <PrincipalPointX>k__BackingField;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7421A0", Offset = "0x7421A0")]
		private float <PrincipalPointY>k__BackingField;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7421B0", Offset = "0x7421B0")]
		private float <RadialDistortionSecondOrder>k__BackingField;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7421C0", Offset = "0x7421C0")]
		private float <RadialDistortionFourthOrder>k__BackingField;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7421D0", Offset = "0x7421D0")]
		private float <RadialDistortionSixthOrder>k__BackingField;

		[Token(Token = "0x1700006C")]
		public float FocalLengthX
		{
			[Token(Token = "0x6000200")]
			[Address(RVA = "0x18799A0", Offset = "0x18799A0", VA = "0x18799A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x742670", Offset = "0x742670")]
			readonly get
			{
				return default(float);
			}
			[Token(Token = "0x6000201")]
			[Address(RVA = "0x18799A8", Offset = "0x18799A8", VA = "0x18799A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7426A8", Offset = "0x7426A8")]
			set
			{
			}
		}

		[Token(Token = "0x1700006D")]
		public float FocalLengthY
		{
			[Token(Token = "0x6000202")]
			[Address(RVA = "0x18799B0", Offset = "0x18799B0", VA = "0x18799B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7426B8", Offset = "0x7426B8")]
			readonly get
			{
				return default(float);
			}
			[Token(Token = "0x6000203")]
			[Address(RVA = "0x18799B8", Offset = "0x18799B8", VA = "0x18799B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7426F0", Offset = "0x7426F0")]
			set
			{
			}
		}

		[Token(Token = "0x1700006E")]
		public float PrincipalPointX
		{
			[Token(Token = "0x6000204")]
			[Address(RVA = "0x18799C0", Offset = "0x18799C0", VA = "0x18799C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x742700", Offset = "0x742700")]
			readonly get
			{
				return default(float);
			}
			[Token(Token = "0x6000205")]
			[Address(RVA = "0x18799C8", Offset = "0x18799C8", VA = "0x18799C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x742738", Offset = "0x742738")]
			set
			{
			}
		}

		[Token(Token = "0x1700006F")]
		public float PrincipalPointY
		{
			[Token(Token = "0x6000206")]
			[Address(RVA = "0x18799D0", Offset = "0x18799D0", VA = "0x18799D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x742748", Offset = "0x742748")]
			readonly get
			{
				return default(float);
			}
			[Token(Token = "0x6000207")]
			[Address(RVA = "0x18799D8", Offset = "0x18799D8", VA = "0x18799D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x742780", Offset = "0x742780")]
			set
			{
			}
		}

		[Token(Token = "0x17000070")]
		public float RadialDistortionSecondOrder
		{
			[Token(Token = "0x6000208")]
			[Address(RVA = "0x18799E0", Offset = "0x18799E0", VA = "0x18799E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x742790", Offset = "0x742790")]
			readonly get
			{
				return default(float);
			}
			[Token(Token = "0x6000209")]
			[Address(RVA = "0x18799E8", Offset = "0x18799E8", VA = "0x18799E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7427C8", Offset = "0x7427C8")]
			set
			{
			}
		}

		[Token(Token = "0x17000071")]
		public float RadialDistortionFourthOrder
		{
			[Token(Token = "0x600020A")]
			[Address(RVA = "0x18799F0", Offset = "0x18799F0", VA = "0x18799F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7427D8", Offset = "0x7427D8")]
			readonly get
			{
				return default(float);
			}
			[Token(Token = "0x600020B")]
			[Address(RVA = "0x18799F8", Offset = "0x18799F8", VA = "0x18799F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x742810", Offset = "0x742810")]
			set
			{
			}
		}

		[Token(Token = "0x17000072")]
		public float RadialDistortionSixthOrder
		{
			[Token(Token = "0x600020C")]
			[Address(RVA = "0x1879A00", Offset = "0x1879A00", VA = "0x1879A00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x742820", Offset = "0x742820")]
			readonly get
			{
				return default(float);
			}
			[Token(Token = "0x600020D")]
			[Address(RVA = "0x1879A08", Offset = "0x1879A08", VA = "0x1879A08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x742858", Offset = "0x742858")]
			set
			{
			}
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x1879A10", Offset = "0x1879A10", VA = "0x1879A10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x1879B00", Offset = "0x1879B00", VA = "0x1879B00", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x1879B9C", Offset = "0x1879B9C", VA = "0x1879B9C")]
		public bool Equals(CameraIntrinsics obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x1879C90", Offset = "0x1879C90", VA = "0x1879C90")]
		public static bool operator ==(CameraIntrinsics a, CameraIntrinsics b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x1879CC4", Offset = "0x1879CC4", VA = "0x1879CC4")]
		public static bool operator !=(CameraIntrinsics a, CameraIntrinsics b)
		{
			return default(bool);
		}
	}
}
namespace NodeEditorFramework
{
	[Token(Token = "0x2000099")]
	public enum ConnectionDrawMethod
	{
		[Token(Token = "0x4000384")]
		Bezier,
		[Token(Token = "0x4000385")]
		StraightLine
	}
	[Token(Token = "0x200009A")]
	public static class ConnectionTypes
	{
		[Token(Token = "0x200009B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x741960", Offset = "0x741960")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x4000387")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Type type;

			[Token(Token = "0x6000218")]
			[Address(RVA = "0x1A7D4D8", Offset = "0x1A7D4D8", VA = "0x1A7D4D8")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x6000219")]
			[Address(RVA = "0x1A7D4E0", Offset = "0x1A7D4E0", VA = "0x1A7D4E0")]
			internal bool <GetTypeData>b__0(TypeData data)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200009C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x741970", Offset = "0x741970")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x4000388")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Type type;

			[Token(Token = "0x600021A")]
			[Address(RVA = "0x1A7D584", Offset = "0x1A7D584", VA = "0x1A7D584")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x600021B")]
			[Address(RVA = "0x1A7D58C", Offset = "0x1A7D58C", VA = "0x1A7D58C")]
			internal bool <GetTypeData>b__0(TypeData data)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x200009D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x741980", Offset = "0x741980")]
		private sealed class <>c
		{
			[Token(Token = "0x4000389")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400038A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<Assembly, bool> <>9__6_0;

			[Token(Token = "0x400038B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<Type, bool> <>9__6_1;

			[Token(Token = "0x600021D")]
			[Address(RVA = "0x1A7D374", Offset = "0x1A7D374", VA = "0x1A7D374")]
			public <>c()
			{
			}

			[Token(Token = "0x600021E")]
			[Address(RVA = "0x1A7D37C", Offset = "0x1A7D37C", VA = "0x1A7D37C")]
			internal bool <FetchTypes>b__6_0(Assembly assembly)
			{
				return default(bool);
			}

			[Token(Token = "0x600021F")]
			[Address(RVA = "0x1A7D3E4", Offset = "0x1A7D3E4", VA = "0x1A7D3E4")]
			internal bool <FetchTypes>b__6_1(Type T)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<string, TypeData> types;

		[Token(Token = "0x17000073")]
		private static Type NullType
		{
			[Token(Token = "0x6000213")]
			[Address(RVA = "0x187EAD4", Offset = "0x187EAD4", VA = "0x187EAD4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x187EB4C", Offset = "0x187EB4C", VA = "0x187EB4C")]
		public static Type GetType(string typeName)
		{
			return null;
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x187EB78", Offset = "0x187EB78", VA = "0x187EB78")]
		public static TypeData GetTypeData(string typeName)
		{
			return null;
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x187F9DC", Offset = "0x187F9DC", VA = "0x187F9DC")]
		public static TypeData GetTypeData(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x187EF24", Offset = "0x187EF24", VA = "0x187EF24")]
		internal static void FetchTypes()
		{
		}
	}
	[Token(Token = "0x200009E")]
	public class TypeData
	{
		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IConnectionTypeDeclaration declaration;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7421E0", Offset = "0x7421E0")]
		private string <Identifier>k__BackingField;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7421F0", Offset = "0x7421F0")]
		private Type <Type>k__BackingField;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x742200", Offset = "0x742200")]
		private Color <Color>k__BackingField;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x742210", Offset = "0x742210")]
		private Texture2D <InKnobTex>k__BackingField;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x742220", Offset = "0x742220")]
		private Texture2D <OutKnobTex>k__BackingField;

		[Token(Token = "0x17000074")]
		public string Identifier
		{
			[Token(Token = "0x6000220")]
			[Address(RVA = "0x1A7993C", Offset = "0x1A7993C", VA = "0x1A7993C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x742868", Offset = "0x742868")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000221")]
			[Address(RVA = "0x1A79944", Offset = "0x1A79944", VA = "0x1A79944")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x742878", Offset = "0x742878")]
			private set
			{
			}
		}

		[Token(Token = "0x17000075")]
		public Type Type
		{
			[Token(Token = "0x6000222")]
			[Address(RVA = "0x1A7994C", Offset = "0x1A7994C", VA = "0x1A7994C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x742888", Offset = "0x742888")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000223")]
			[Address(RVA = "0x1A79954", Offset = "0x1A79954", VA = "0x1A79954")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x742898", Offset = "0x742898")]
			private set
			{
			}
		}

		[Token(Token = "0x17000076")]
		public Color Color
		{
			[Token(Token = "0x6000224")]
			[Address(RVA = "0x1A7995C", Offset = "0x1A7995C", VA = "0x1A7995C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7428A8", Offset = "0x7428A8")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000225")]
			[Address(RVA = "0x1A79968", Offset = "0x1A79968", VA = "0x1A79968")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7428B8", Offset = "0x7428B8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000077")]
		public Texture2D InKnobTex
		{
			[Token(Token = "0x6000226")]
			[Address(RVA = "0x1A79974", Offset = "0x1A79974", VA = "0x1A79974")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7428C8", Offset = "0x7428C8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000227")]
			[Address(RVA = "0x1A7997C", Offset = "0x1A7997C", VA = "0x1A7997C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7428D8", Offset = "0x7428D8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000078")]
		public Texture2D OutKnobTex
		{
			[Token(Token = "0x6000228")]
			[Address(RVA = "0x1A79984", Offset = "0x1A79984", VA = "0x1A79984")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7428E8", Offset = "0x7428E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000229")]
			[Address(RVA = "0x1A7998C", Offset = "0x1A7998C", VA = "0x1A7998C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7428F8", Offset = "0x7428F8")]
			private set
			{
			}
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x1A79994", Offset = "0x1A79994", VA = "0x1A79994")]
		internal TypeData(IConnectionTypeDeclaration typeDecl)
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x1A79E94", Offset = "0x1A79E94", VA = "0x1A79E94")]
		public TypeData(Type type)
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x1A79D84", Offset = "0x1A79D84", VA = "0x1A79D84")]
		public bool isValid()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200009F")]
	public interface IConnectionTypeDeclaration
	{
		[Token(Token = "0x17000079")]
		string Identifier
		{
			[Token(Token = "0x600022D")]
			get;
		}

		[Token(Token = "0x1700007A")]
		Type Type
		{
			[Token(Token = "0x600022E")]
			get;
		}

		[Token(Token = "0x1700007B")]
		Color Color
		{
			[Token(Token = "0x600022F")]
			get;
		}

		[Token(Token = "0x1700007C")]
		string InKnobTex
		{
			[Token(Token = "0x6000230")]
			get;
		}

		[Token(Token = "0x1700007D")]
		string OutKnobTex
		{
			[Token(Token = "0x6000231")]
			get;
		}
	}
	[Token(Token = "0x20000A0")]
	public class FloatType : IConnectionTypeDeclaration
	{
		[Token(Token = "0x1700007E")]
		public string Identifier
		{
			[Token(Token = "0x6000232")]
			[Address(RVA = "0x1267E40", Offset = "0x1267E40", VA = "0x1267E40", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007F")]
		public Type Type
		{
			[Token(Token = "0x6000233")]
			[Address(RVA = "0x1267E84", Offset = "0x1267E84", VA = "0x1267E84", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000080")]
		public Color Color
		{
			[Token(Token = "0x6000234")]
			[Address(RVA = "0x1267EFC", Offset = "0x1267EFC", VA = "0x1267EFC", Slot = "6")]
			get
			{
				return default(Color);
			}
		}

		[Token(Token = "0x17000081")]
		public string InKnobTex
		{
			[Token(Token = "0x6000235")]
			[Address(RVA = "0x1267F04", Offset = "0x1267F04", VA = "0x1267F04", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000082")]
		public string OutKnobTex
		{
			[Token(Token = "0x6000236")]
			[Address(RVA = "0x1267F48", Offset = "0x1267F48", VA = "0x1267F48", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x1267F8C", Offset = "0x1267F8C", VA = "0x1267F8C")]
		public FloatType()
		{
		}
	}
	[Token(Token = "0x20000A1")]
	public abstract class Node : ScriptableObject
	{
		[Token(Token = "0x20000A2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x741990", Offset = "0x741990")]
		private sealed class <>c__DisplayClass44_0
		{
			[Token(Token = "0x400039B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Type newOutputType;

			[Token(Token = "0x6000264")]
			[Address(RVA = "0x1A7E338", Offset = "0x1A7E338", VA = "0x1A7E338")]
			public <>c__DisplayClass44_0()
			{
			}

			[Token(Token = "0x6000265")]
			[Address(RVA = "0x1A7E340", Offset = "0x1A7E340", VA = "0x1A7E340")]
			internal bool <ReassignOutputType>b__0(NodeInput connection)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Rect rect;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal Vector2 contentOffset;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		public List<NodeKnob> nodeKnobs;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		public List<NodeInput> Inputs;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		public List<NodeOutput> Outputs;

		[NonSerialized]
		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[HideInInspector]
		internal bool calculated;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private GUIStyle backgroundStyle;

		[NonSerialized]
		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<Node> recursiveSearchSurpassed;

		[NonSerialized]
		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Node startRecursiveSearchNode;

		[Token(Token = "0x17000083")]
		public abstract string GetID
		{
			[Token(Token = "0x600023D")]
			get;
		}

		[Token(Token = "0x17000084")]
		public virtual bool AllowRecursion
		{
			[Token(Token = "0x6000243")]
			[Address(RVA = "0x1270608", Offset = "0x1270608", VA = "0x1270608", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000085")]
		public virtual bool ContinueCalculation
		{
			[Token(Token = "0x6000244")]
			[Address(RVA = "0x1270610", Offset = "0x1270610", VA = "0x1270610", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x126F3D8", Offset = "0x126F3D8", VA = "0x126F3D8")]
		protected internal void InitBase()
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x126F66C", Offset = "0x126F66C", VA = "0x126F66C")]
		public void Delete()
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x126FFE4", Offset = "0x126FFE4", VA = "0x126FFE4")]
		public static Node Create(string nodeID, Vector2 position)
		{
			return null;
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x126FFEC", Offset = "0x126FFEC", VA = "0x126FFEC")]
		public static Node Create(string nodeID, Vector2 position, NodeOutput connectingOutput)
		{
			return null;
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x12704F8", Offset = "0x12704F8", VA = "0x12704F8")]
		internal void CheckNodeKnobMigration()
		{
		}

		[Token(Token = "0x600023E")]
		public abstract Node Create(Vector2 pos);

		[Token(Token = "0x600023F")]
		protected internal abstract void NodeGUI();

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x12705F8", Offset = "0x12705F8", VA = "0x12705F8", Slot = "7")]
		public virtual void DrawNodePropertyEditor()
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x12705FC", Offset = "0x12705FC", VA = "0x12705FC", Slot = "8")]
		public virtual bool Calculate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x1270604", Offset = "0x1270604", VA = "0x1270604", Slot = "9")]
		public virtual void CheckSize()
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x1270618", Offset = "0x1270618", VA = "0x1270618", Slot = "12")]
		protected internal virtual void OnDelete()
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x127061C", Offset = "0x127061C", VA = "0x127061C", Slot = "13")]
		protected internal virtual void OnAddInputConnection(NodeInput input)
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x1270620", Offset = "0x1270620", VA = "0x1270620", Slot = "14")]
		protected internal virtual void OnAddOutputConnection(NodeOutput output)
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x1270624", Offset = "0x1270624", VA = "0x1270624", Slot = "15")]
		public virtual ScriptableObject[] GetScriptableObjects()
		{
			return null;
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x127066C", Offset = "0x127066C", VA = "0x127066C", Slot = "16")]
		protected internal virtual void CopyScriptableObjects(Func<ScriptableObject, ScriptableObject> replaceSerializableObject)
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x1270670", Offset = "0x1270670", VA = "0x1270670")]
		public void SerializeInputsAndOutputs(Func<ScriptableObject, ScriptableObject> replaceSerializableObject)
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x1270674", Offset = "0x1270674", VA = "0x1270674", Slot = "17")]
		protected internal virtual void DrawNode()
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x1270B5C", Offset = "0x1270B5C", VA = "0x1270B5C", Slot = "18")]
		protected internal virtual void DrawKnobs()
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x1270C08", Offset = "0x1270C08", VA = "0x1270C08", Slot = "19")]
		protected internal virtual void DrawConnections()
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x127104C", Offset = "0x127104C", VA = "0x127104C")]
		protected internal bool allInputsReady()
		{
			return default(bool);
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x1271178", Offset = "0x1271178", VA = "0x1271178")]
		protected internal bool hasUnassignedInputs()
		{
			return default(bool);
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x1271260", Offset = "0x1271260", VA = "0x1271260")]
		protected internal bool descendantsCalculated()
		{
			return default(bool);
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x1271390", Offset = "0x1271390", VA = "0x1271390")]
		protected internal bool isInput()
		{
			return default(bool);
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x1271478", Offset = "0x1271478", VA = "0x1271478")]
		public NodeOutput CreateOutput(string outputName, string outputType)
		{
			return null;
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x1271480", Offset = "0x1271480", VA = "0x1271480")]
		public NodeOutput CreateOutput(string outputName, string outputType, NodeSide nodeSide)
		{
			return null;
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x1267AAC", Offset = "0x1267AAC", VA = "0x1267AAC")]
		public NodeOutput CreateOutput(string outputName, string outputType, NodeSide nodeSide, float sidePosition)
		{
			return null;
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x1271488", Offset = "0x1271488", VA = "0x1271488")]
		protected void OutputKnob(int outputIdx)
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x12715E8", Offset = "0x12715E8", VA = "0x12715E8")]
		public NodeInput CreateInput(string inputName, string inputType)
		{
			return null;
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x1271600", Offset = "0x1271600", VA = "0x1271600")]
		public NodeInput CreateInput(string inputName, string inputType, NodeSide nodeSide)
		{
			return null;
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x1267AA8", Offset = "0x1267AA8", VA = "0x1267AA8")]
		public NodeInput CreateInput(string inputName, string inputType, NodeSide nodeSide, float sidePosition)
		{
			return null;
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x12716E4", Offset = "0x12716E4", VA = "0x12716E4")]
		protected void InputKnob(int inputIdx)
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x1271788", Offset = "0x1271788", VA = "0x1271788")]
		protected static void ReassignOutputType(ref NodeOutput output, Type newOutputType)
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x127206C", Offset = "0x127206C", VA = "0x127206C")]
		protected static void ReassignInputType(ref NodeInput input, Type newInputType)
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x1272284", Offset = "0x1272284", VA = "0x1272284")]
		public bool isChildOf(Node otherNode)
		{
			return default(bool);
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x12726B8", Offset = "0x12726B8", VA = "0x12726B8")]
		internal bool isInLoop()
		{
			return default(bool);
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x1272828", Offset = "0x1272828", VA = "0x1272828")]
		internal bool allowsLoopRecursion(Node otherNode)
		{
			return default(bool);
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x12729AC", Offset = "0x12729AC", VA = "0x12729AC")]
		public void ClearCalculation()
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x127248C", Offset = "0x127248C", VA = "0x127248C")]
		internal bool BeginRecursiveSearchLoop()
		{
			return default(bool);
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x127260C", Offset = "0x127260C", VA = "0x127260C")]
		internal void EndRecursiveSearchLoop()
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x12725D8", Offset = "0x12725D8", VA = "0x12725D8")]
		internal void StopRecursiveSearchLoop()
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x1272AE0", Offset = "0x1272AE0", VA = "0x1272AE0")]
		protected Node()
		{
		}
	}
	[Token(Token = "0x20000A3")]
	[AttributeAttribute(Name = "NodeCanvasTypeAttribute", RVA = "0x7419A0", Offset = "0x7419A0")]
	public class NodeCanvas : ScriptableObject
	{
		[Serializable]
		[Token(Token = "0x20000A4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7419D8", Offset = "0x7419D8")]
		private sealed class <>c
		{
			[Token(Token = "0x400039F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40003A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<NodeEditorState, bool> <>9__6_0;

			[Token(Token = "0x600026B")]
			[Address(RVA = "0x1A7E3F0", Offset = "0x1A7E3F0", VA = "0x1A7E3F0")]
			public <>c()
			{
			}

			[Token(Token = "0x600026C")]
			[Address(RVA = "0x1A7E3F8", Offset = "0x1A7E3F8", VA = "0x1A7E3F8")]
			internal bool <Validate>b__6_0(NodeEditorState state)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<Node> nodes;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public NodeEditorState[] editorStates;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool livesInScene;

		[Token(Token = "0x17000086")]
		public virtual string canvasName
		{
			[Token(Token = "0x6000266")]
			[Address(RVA = "0x1272CF8", Offset = "0x1272CF8", VA = "0x1272CF8", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x1272D3C", Offset = "0x1272D3C", VA = "0x1272D3C", Slot = "5")]
		public virtual void BeforeSavingCanvas()
		{
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x1272D40", Offset = "0x1272D40", VA = "0x1272D40")]
		public void Validate()
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x12736AC", Offset = "0x12736AC", VA = "0x12736AC")]
		public NodeCanvas()
		{
		}
	}
	[Token(Token = "0x20000A5")]
	public class NodeCanvasManager
	{
		[Serializable]
		[Token(Token = "0x20000A6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7419E8", Offset = "0x7419E8")]
		private sealed class <>c
		{
			[Token(Token = "0x40003A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40003A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<Assembly, bool> <>9__2_0;

			[Token(Token = "0x40003A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<Type, bool> <>9__2_1;

			[Token(Token = "0x6000273")]
			[Address(RVA = "0x1A7E4C4", Offset = "0x1A7E4C4", VA = "0x1A7E4C4")]
			public <>c()
			{
			}

			[Token(Token = "0x6000274")]
			[Address(RVA = "0x1A7E4CC", Offset = "0x1A7E4CC", VA = "0x1A7E4CC")]
			internal bool <GetAllCanvasTypes>b__2_0(Assembly assembly)
			{
				return default(bool);
			}

			[Token(Token = "0x6000275")]
			[Address(RVA = "0x1A7E534", Offset = "0x1A7E534", VA = "0x1A7E534")]
			internal bool <GetAllCanvasTypes>b__2_1(Type T)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Dictionary<Type, NodeCanvasTypeData> CanvasTypes;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Action<Type> _callBack;

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x1273760", Offset = "0x1273760", VA = "0x1273760")]
		public static void GetAllCanvasTypes()
		{
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x1274128", Offset = "0x1274128", VA = "0x1274128")]
		private static void CreateNewCanvas(object userdata)
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x12741DC", Offset = "0x12741DC", VA = "0x12741DC")]
		public static void FillCanvasTypeMenu(ref GenericMenu menu, Action<Type> newNodeCanvas)
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x127440C", Offset = "0x127440C", VA = "0x127440C")]
		public static bool CheckCanvasCompability(Node node, Type canvasType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x1274494", Offset = "0x1274494", VA = "0x1274494")]
		public NodeCanvasManager()
		{
		}
	}
	[Token(Token = "0x20000A7")]
	public struct NodeCanvasTypeData
	{
		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string DisplayString;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Type CanvasType;
	}
	[Token(Token = "0x20000A8")]
	public class NodeCanvasTypeAttribute : Attribute
	{
		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x12744A4", Offset = "0x12744A4", VA = "0x12744A4")]
		public NodeCanvasTypeAttribute(string displayName)
		{
		}
	}
	[Token(Token = "0x20000A9")]
	public static class NodeEditor
	{
		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string editorPath;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static NodeCanvas curNodeCanvas;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static NodeEditorState curEditorState;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal static Action NEUpdate;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Action ClientRepaints;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static bool initiatedBase;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		private static bool initiatedGUI;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		public static bool InitiationError;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static List<Node> workList;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static int calculationCount;

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x127450C", Offset = "0x127450C", VA = "0x127450C")]
		public static void Update()
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x126F5C8", Offset = "0x126F5C8", VA = "0x126F5C8")]
		public static void RepaintClients()
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x12745B0", Offset = "0x12745B0", VA = "0x12745B0")]
		public static void checkInit(bool GUIFunction)
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x1274944", Offset = "0x1274944", VA = "0x1274944")]
		public static void ReInit(bool GUIFunction)
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x12746AC", Offset = "0x12746AC", VA = "0x12746AC")]
		private static void setupBaseFramework()
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x1274814", Offset = "0x1274814", VA = "0x1274814")]
		private static void setupGUI()
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x12749E8", Offset = "0x12749E8", VA = "0x12749E8")]
		public static void CheckEditorPath()
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x127648C", Offset = "0x127648C", VA = "0x127648C")]
		public static void DrawCanvas(NodeCanvas nodeCanvas, NodeEditorState editorState)
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x127657C", Offset = "0x127657C", VA = "0x127657C")]
		private static void DrawSubCanvas(NodeCanvas nodeCanvas, NodeEditorState editorState)
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x1277180", Offset = "0x1277180", VA = "0x1277180")]
		public static Node NodeAtPosition(Vector2 canvasPos)
		{
			return null;
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x1277420", Offset = "0x1277420", VA = "0x1277420")]
		public static Node NodeAtPosition(Vector2 canvasPos, out NodeKnob focusedKnob)
		{
			return null;
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x1277208", Offset = "0x1277208", VA = "0x1277208")]
		public static Node NodeAtPosition(NodeEditorState editorState, Vector2 canvasPos, out NodeKnob focusedKnob)
		{
			return null;
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x1277718", Offset = "0x1277718", VA = "0x1277718")]
		public static Vector2 ScreenToCanvasSpace(Vector2 screenPos)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x1277794", Offset = "0x1277794", VA = "0x1277794")]
		public static Vector2 ScreenToCanvasSpace(NodeEditorState editorState, Vector2 screenPos)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x1277818", Offset = "0x1277818", VA = "0x1277818")]
		public static void RecalculateAll(NodeCanvas nodeCanvas)
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x126F4E4", Offset = "0x126F4E4", VA = "0x126F4E4")]
		public static void RecalculateFrom(Node node)
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x1277A48", Offset = "0x1277A48", VA = "0x1277A48")]
		public static void StartCalculation()
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x1277BF8", Offset = "0x1277BF8", VA = "0x1277BF8")]
		private static bool ContinueCalculation(Node node)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000AA")]
	public abstract class NodeEditorCallbackReceiver : MonoBehaviour
	{
		[Token(Token = "0x600028A")]
		[Address(RVA = "0x1277FA0", Offset = "0x1277FA0", VA = "0x1277FA0", Slot = "4")]
		public virtual void OnEditorStartUp()
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x1277FA4", Offset = "0x1277FA4", VA = "0x1277FA4", Slot = "5")]
		public virtual void OnLoadCanvas(NodeCanvas canvas)
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x1277FA8", Offset = "0x1277FA8", VA = "0x1277FA8", Slot = "6")]
		public virtual void OnLoadEditorState(NodeEditorState editorState)
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x1277FAC", Offset = "0x1277FAC", VA = "0x1277FAC", Slot = "7")]
		public virtual void OnSaveCanvas(NodeCanvas canvas)
		{
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x1277FB0", Offset = "0x1277FB0", VA = "0x1277FB0", Slot = "8")]
		public virtual void OnSaveEditorState(NodeEditorState editorState)
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x1277FB4", Offset = "0x1277FB4", VA = "0x1277FB4", Slot = "9")]
		public virtual void OnAddNode(Node node)
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x1277FB8", Offset = "0x1277FB8", VA = "0x1277FB8", Slot = "10")]
		public virtual void OnDeleteNode(Node node)
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x1277FBC", Offset = "0x1277FBC", VA = "0x1277FBC", Slot = "11")]
		public virtual void OnMoveNode(Node node)
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x1277FC0", Offset = "0x1277FC0", VA = "0x1277FC0", Slot = "12")]
		public virtual void OnAddNodeKnob(NodeKnob knob)
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x1277FC4", Offset = "0x1277FC4", VA = "0x1277FC4", Slot = "13")]
		public virtual void OnAddConnection(NodeInput input)
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x1277FC8", Offset = "0x1277FC8", VA = "0x1277FC8", Slot = "14")]
		public virtual void OnRemoveConnection(NodeInput input)
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x1277FCC", Offset = "0x1277FCC", VA = "0x1277FCC")]
		protected NodeEditorCallbackReceiver()
		{
		}
	}
	[Token(Token = "0x20000AB")]
	public static class NodeEditorCallbacks
	{
		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int receiverCount;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static List<NodeEditorCallbackReceiver> callbackReceiver;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Action OnEditorStartUp;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Action<NodeCanvas> OnLoadCanvas;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Action<NodeEditorState> OnLoadEditorState;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static Action<NodeCanvas> OnSaveCanvas;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static Action<NodeEditorState> OnSaveEditorState;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static Action<Node> OnAddNode;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static Action<Node> OnDeleteNode;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static Action<Node> OnMoveNode;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static Action<NodeKnob> OnAddNodeKnob;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static Action<NodeInput> OnAddConnection;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static Action<NodeInput> OnRemoveConnection;

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x12749EC", Offset = "0x12749EC", VA = "0x12749EC")]
		public static void SetupReceivers()
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x1274B10", Offset = "0x1274B10", VA = "0x1274B10")]
		public static void IssueOnEditorStartUp()
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x1277FD4", Offset = "0x1277FD4", VA = "0x1277FD4")]
		public static void IssueOnLoadCanvas(NodeCanvas canvas)
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x1278220", Offset = "0x1278220", VA = "0x1278220")]
		public static void IssueOnLoadEditorState(NodeEditorState editorState)
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x127846C", Offset = "0x127846C", VA = "0x127846C")]
		public static void IssueOnSaveCanvas(NodeCanvas canvas)
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x12786B8", Offset = "0x12786B8", VA = "0x12786B8")]
		public static void IssueOnSaveEditorState(NodeEditorState editorState)
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x12702AC", Offset = "0x12702AC", VA = "0x12702AC")]
		public static void IssueOnAddNode(Node node)
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x126FC4C", Offset = "0x126FC4C", VA = "0x126FC4C")]
		public static void IssueOnDeleteNode(Node node)
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x1278904", Offset = "0x1278904", VA = "0x1278904")]
		public static void IssueOnMoveNode(Node node)
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x1271C00", Offset = "0x1271C00", VA = "0x1271C00")]
		public static void IssueOnAddNodeKnob(NodeKnob nodeKnob)
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x1278B50", Offset = "0x1278B50", VA = "0x1278B50")]
		public static void IssueOnAddConnection(NodeInput input)
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x1278DA0", Offset = "0x1278DA0", VA = "0x1278DA0")]
		public static void IssueOnRemoveConnection(NodeInput input)
		{
		}
	}
	[Token(Token = "0x20000AC")]
	public static class NodeEditorGUI
	{
		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static int knobSize;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static Color NE_LightColor;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static Color NE_TextColor;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static Texture2D Background;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static Texture2D AALineTex;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static Texture2D GUIBox;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static Texture2D GUIButton;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static Texture2D GUIBoxSelection;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static GUISkin nodeSkin;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static GUISkin defaultSkin;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static GUIStyle nodeLabel;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static GUIStyle nodeLabelBold;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static GUIStyle nodeLabelSelected;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static GUIStyle nodeBox;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static GUIStyle nodeBoxBold;

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x1275D50", Offset = "0x1275D50", VA = "0x1275D50")]
		public static bool Init()
		{
			return default(bool);
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x1278FF4", Offset = "0x1278FF4", VA = "0x1278FF4")]
		public static void StartNodeGUI()
		{
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x1279174", Offset = "0x1279174", VA = "0x1279174")]
		public static void EndNodeGUI()
		{
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x1279218", Offset = "0x1279218", VA = "0x1279218")]
		public static void DrawConnection(Vector2 startPos, Vector2 endPos, Color col)
		{
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x1270F30", Offset = "0x1270F30", VA = "0x1270F30")]
		public static void DrawConnection(Vector2 startPos, Vector2 startDir, Vector2 endPos, Vector2 endDir, Color col)
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x1279318", Offset = "0x1279318", VA = "0x1279318")]
		public static void DrawConnection(Vector2 startPos, Vector2 startDir, Vector2 endPos, Vector2 endDir, ConnectionDrawMethod drawMethod, Color col)
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x12770C0", Offset = "0x12770C0", VA = "0x12770C0")]
		internal static Vector2 GetSecondConnectionVector(Vector2 startPos, Vector2 endPos, Vector2 firstVector)
		{
			return default(Vector2);
		}
	}
	[Token(Token = "0x20000AD")]
	public static class NodeEditorInputControls
	{
		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x12795E0", Offset = "0x12795E0", VA = "0x12795E0")]
		[AttributeAttribute(Name = "ContextFillerAttribute", RVA = "0x742908", Offset = "0x742908")]
		private static void FillAddNodes(NodeEditorInputInfo inputInfo, GenericMenu canvasContextMenu)
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x12799F4", Offset = "0x12799F4", VA = "0x12799F4")]
		private static void CreateNodeCallback(object infoObj)
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x1279BC4", Offset = "0x1279BC4", VA = "0x1279BC4")]
		[AttributeAttribute(Name = "ContextEntryAttribute", RVA = "0x74291C", Offset = "0x74291C")]
		private static void DeleteNode(NodeEditorInputInfo inputInfo)
		{
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x1279C7C", Offset = "0x1279C7C", VA = "0x1279C7C")]
		[AttributeAttribute(Name = "ContextEntryAttribute", RVA = "0x742958", Offset = "0x742958")]
		private static void DuplicateNode(NodeEditorInputInfo inputInfo)
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x1279DD4", Offset = "0x1279DD4", VA = "0x1279DD4")]
		[AttributeAttribute(Name = "HotkeyAttribute", RVA = "0x742994", Offset = "0x742994")]
		[AttributeAttribute(Name = "HotkeyAttribute", RVA = "0x742994", Offset = "0x742994")]
		[AttributeAttribute(Name = "HotkeyAttribute", RVA = "0x742994", Offset = "0x742994")]
		[AttributeAttribute(Name = "HotkeyAttribute", RVA = "0x742994", Offset = "0x742994")]
		private static void KB_MoveNode(NodeEditorInputInfo inputInfo)
		{
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x1279F88", Offset = "0x1279F88", VA = "0x1279F88")]
		[AttributeAttribute(Name = "EventHandlerAttribute", RVA = "0x742A0C", Offset = "0x742A0C")]
		private static void HandleNodeDraggingStart(NodeEditorInputInfo inputInfo)
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x127A12C", Offset = "0x127A12C", VA = "0x127A12C")]
		[AttributeAttribute(Name = "EventHandlerAttribute", RVA = "0x742A24", Offset = "0x742A24")]
		private static void HandleNodeDragging(NodeEditorInputInfo inputInfo)
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x127A2A8", Offset = "0x127A2A8", VA = "0x127A2A8")]
		[AttributeAttribute(Name = "EventHandlerAttribute", RVA = "0x742A38", Offset = "0x742A38")]
		[AttributeAttribute(Name = "EventHandlerAttribute", RVA = "0x742A38", Offset = "0x742A38")]
		private static void HandleNodeDraggingEnd(NodeEditorInputInfo inputInfo)
		{
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x127A2CC", Offset = "0x127A2CC", VA = "0x127A2CC")]
		[AttributeAttribute(Name = "EventHandlerAttribute", RVA = "0x742A78", Offset = "0x742A78")]
		private static void HandleWindowPanningStart(NodeEditorInputInfo inputInfo)
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x127A3E0", Offset = "0x127A3E0", VA = "0x127A3E0")]
		[AttributeAttribute(Name = "EventHandlerAttribute", RVA = "0x742A90", Offset = "0x742A90")]
		private static void HandleWindowPanning(NodeEditorInputInfo inputInfo)
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x127A48C", Offset = "0x127A48C", VA = "0x127A48C")]
		[AttributeAttribute(Name = "EventHandlerAttribute", RVA = "0x742AA4", Offset = "0x742AA4")]
		[AttributeAttribute(Name = "EventHandlerAttribute", RVA = "0x742AA4", Offset = "0x742AA4")]
		private static void HandleWindowPanningEnd(NodeEditorInputInfo inputInfo)
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x127A4B0", Offset = "0x127A4B0", VA = "0x127A4B0")]
		[AttributeAttribute(Name = "EventHandlerAttribute", RVA = "0x742AE4", Offset = "0x742AE4")]
		private static void HandleConnectionDrawing(NodeEditorInputInfo inputInfo)
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x127A648", Offset = "0x127A648", VA = "0x127A648")]
		[AttributeAttribute(Name = "EventHandlerAttribute", RVA = "0x742AF8", Offset = "0x742AF8")]
		private static void HandleApplyConnection(NodeEditorInputInfo inputInfo)
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x127A7BC", Offset = "0x127A7BC", VA = "0x127A7BC")]
		[AttributeAttribute(Name = "EventHandlerAttribute", RVA = "0x742B0C", Offset = "0x742B0C")]
		private static void HandleZooming(NodeEditorInputInfo inputInfo)
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x127A8B8", Offset = "0x127A8B8", VA = "0x127A8B8")]
		[AttributeAttribute(Name = "HotkeyAttribute", RVA = "0x742B20", Offset = "0x742B20")]
		private static void HandleStartNavigating(NodeEditorInputInfo inputInfo)
		{
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x127A8E0", Offset = "0x127A8E0", VA = "0x127A8E0")]
		[AttributeAttribute(Name = "HotkeyAttribute", RVA = "0x742B38", Offset = "0x742B38")]
		private static void HandleEndNavigating(NodeEditorInputInfo inputInfo)
		{
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x127A904", Offset = "0x127A904", VA = "0x127A904")]
		[AttributeAttribute(Name = "HotkeyAttribute", RVA = "0x742B50", Offset = "0x742B50")]
		[AttributeAttribute(Name = "HotkeyAttribute", RVA = "0x742B50", Offset = "0x742B50")]
		private static void HandleNodeSnap(NodeEditorInputInfo inputInfo)
		{
		}
	}
	[Token(Token = "0x20000AE")]
	public static class NodeEditorInputSystem
	{
		[Token(Token = "0x20000AF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7419F8", Offset = "0x7419F8")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x40003D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Delegate actionDelegate;

			[Token(Token = "0x40003D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public PopupMenu.MenuFunctionData <>9__3;

			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x1A7E7C0", Offset = "0x1A7E7C0", VA = "0x1A7E7C0")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x60002C7")]
			[Address(RVA = "0x1A7E7C8", Offset = "0x1A7E7C8", VA = "0x1A7E7C8")]
			internal void <SetupInput>b__3(object callbackObj)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x741A08", Offset = "0x741A08")]
		private sealed class <>c
		{
			[Token(Token = "0x40003D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40003D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<Assembly, bool> <>9__4_0;

			[Token(Token = "0x40003D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Comparison<KeyValuePair<EventHandlerAttribute, Delegate>> <>9__4_1;

			[Token(Token = "0x40003D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Comparison<KeyValuePair<HotkeyAttribute, Delegate>> <>9__4_2;

			[Token(Token = "0x60002C9")]
			[Address(RVA = "0x1A7E670", Offset = "0x1A7E670", VA = "0x1A7E670")]
			public <>c()
			{
			}

			[Token(Token = "0x60002CA")]
			[Address(RVA = "0x1A7E678", Offset = "0x1A7E678", VA = "0x1A7E678")]
			internal bool <SetupInput>b__4_0(Assembly assembly)
			{
				return default(bool);
			}

			[Token(Token = "0x60002CB")]
			[Address(RVA = "0x1A7E6E0", Offset = "0x1A7E6E0", VA = "0x1A7E6E0")]
			internal int <SetupInput>b__4_1(KeyValuePair<EventHandlerAttribute, Delegate> handlerA, KeyValuePair<EventHandlerAttribute, Delegate> handlerB)
			{
				return default(int);
			}

			[Token(Token = "0x60002CC")]
			[Address(RVA = "0x1A7E750", Offset = "0x1A7E750", VA = "0x1A7E750")]
			internal int <SetupInput>b__4_2(KeyValuePair<HotkeyAttribute, Delegate> handlerA, KeyValuePair<HotkeyAttribute, Delegate> handlerB)
			{
				return default(int);
			}
		}

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<KeyValuePair<EventHandlerAttribute, Delegate>> eventHandlers;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static List<KeyValuePair<HotkeyAttribute, Delegate>> hotkeyHandlers;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static List<KeyValuePair<ContextEntryAttribute, PopupMenu.MenuFunctionData>> contextEntries;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static List<KeyValuePair<ContextFillerAttribute, Delegate>> contextFillers;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static NodeEditorState unfocusControlsForState;

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x1274D34", Offset = "0x1274D34", VA = "0x1274D34")]
		public static void SetupInput()
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x127AABC", Offset = "0x127AABC", VA = "0x127AABC")]
		private static void CallEventHandlers(NodeEditorInputInfo inputInfo, bool late)
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x127AD4C", Offset = "0x127AD4C", VA = "0x127AD4C")]
		private static void CallHotkeys(NodeEditorInputInfo inputInfo, KeyCode keyCode, EventModifiers mods)
		{
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x127B000", Offset = "0x127B000", VA = "0x127B000")]
		private static void FillContextMenu(NodeEditorInputInfo inputInfo, GenericMenu contextMenu, ContextType contextType)
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x1277008", Offset = "0x1277008", VA = "0x1277008")]
		public static void HandleInputEvents(NodeEditorState state)
		{
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x1277108", Offset = "0x1277108", VA = "0x1277108")]
		public static void HandleLateInputEvents(NodeEditorState state)
		{
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x12774A4", Offset = "0x12774A4", VA = "0x12774A4")]
		internal static bool shouldIgnoreInput(NodeEditorState state)
		{
			return default(bool);
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x127B3D8", Offset = "0x127B3D8", VA = "0x127B3D8")]
		[AttributeAttribute(Name = "EventHandlerAttribute", RVA = "0x742BA0", Offset = "0x742BA0")]
		private static void HandleFocussing(NodeEditorInputInfo inputInfo)
		{
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x127B560", Offset = "0x127B560", VA = "0x127B560")]
		[AttributeAttribute(Name = "EventHandlerAttribute", RVA = "0x742BB4", Offset = "0x742BB4")]
		private static void HandleSelecting(NodeEditorInputInfo inputInfo)
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x127B67C", Offset = "0x127B67C", VA = "0x127B67C")]
		[AttributeAttribute(Name = "EventHandlerAttribute", RVA = "0x742BCC", Offset = "0x742BCC")]
		private static void HandleContextClicks(NodeEditorInputInfo inputInfo)
		{
		}
	}
	[Token(Token = "0x20000B1")]
	public class NodeEditorInputInfo
	{
		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string message;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public NodeEditorState editorState;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Event inputEvent;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector2 inputPos;

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x127AA38", Offset = "0x127AA38", VA = "0x127AA38")]
		public NodeEditorInputInfo(NodeEditorState EditorState)
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x127996C", Offset = "0x127996C", VA = "0x127996C")]
		public NodeEditorInputInfo(string Message, NodeEditorState EditorState)
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x1279B2C", Offset = "0x1279B2C", VA = "0x1279B2C")]
		public void SetAsCurrentEnvironment()
		{
		}
	}
	[Token(Token = "0x20000B2")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x741A18", Offset = "0x741A18")]
	public class EventHandlerAttribute : Attribute
	{
		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x742270", Offset = "0x742270")]
		private EventType? <handledEvent>k__BackingField;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x742280", Offset = "0x742280")]
		private int <priority>k__BackingField;

		[Token(Token = "0x17000087")]
		public EventType? handledEvent
		{
			[Token(Token = "0x60002D0")]
			[Address(RVA = "0x126683C", Offset = "0x126683C", VA = "0x126683C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x742BE4", Offset = "0x742BE4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002D1")]
			[Address(RVA = "0x1266844", Offset = "0x1266844", VA = "0x1266844")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x742BF4", Offset = "0x742BF4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000088")]
		public int priority
		{
			[Token(Token = "0x60002D2")]
			[Address(RVA = "0x126684C", Offset = "0x126684C", VA = "0x126684C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x742C04", Offset = "0x742C04")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002D3")]
			[Address(RVA = "0x1266854", Offset = "0x1266854", VA = "0x1266854")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x742C14", Offset = "0x742C14")]
			private set
			{
			}
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x126685C", Offset = "0x126685C", VA = "0x126685C")]
		public EventHandlerAttribute(EventType eventType, int priorityValue)
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x12668E4", Offset = "0x12668E4", VA = "0x12668E4")]
		public EventHandlerAttribute(int priorityValue)
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x1266914", Offset = "0x1266914", VA = "0x1266914")]
		public EventHandlerAttribute(EventType eventType)
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x1266994", Offset = "0x1266994", VA = "0x1266994")]
		public EventHandlerAttribute()
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x12669BC", Offset = "0x12669BC", VA = "0x12669BC")]
		internal static bool AssureValidity(MethodInfo method, EventHandlerAttribute attr)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000B3")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x741A50", Offset = "0x741A50")]
	public class HotkeyAttribute : Attribute
	{
		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x742290", Offset = "0x742290")]
		private KeyCode <handledHotKey>k__BackingField;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7422A0", Offset = "0x7422A0")]
		private EventModifiers? <modifiers>k__BackingField;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7422B0", Offset = "0x7422B0")]
		private EventType? <limitingEventType>k__BackingField;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7422C0", Offset = "0x7422C0")]
		private int <priority>k__BackingField;

		[Token(Token = "0x17000089")]
		public KeyCode handledHotKey
		{
			[Token(Token = "0x60002D9")]
			[Address(RVA = "0x126B128", Offset = "0x126B128", VA = "0x126B128")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x742C24", Offset = "0x742C24")]
			get
			{
				return default(KeyCode);
			}
			[Token(Token = "0x60002DA")]
			[Address(RVA = "0x126B130", Offset = "0x126B130", VA = "0x126B130")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x742C34", Offset = "0x742C34")]
			private set
			{
			}
		}

		[Token(Token = "0x1700008A")]
		public EventModifiers? modifiers
		{
			[Token(Token = "0x60002DB")]
			[Address(RVA = "0x126B138", Offset = "0x126B138", VA = "0x126B138")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x742C44", Offset = "0x742C44")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002DC")]
			[Address(RVA = "0x126B140", Offset = "0x126B140", VA = "0x126B140")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x742C54", Offset = "0x742C54")]
			private set
			{
			}
		}

		[Token(Token = "0x1700008B")]
		public EventType? limitingEventType
		{
			[Token(Token = "0x60002DD")]
			[Address(RVA = "0x126B148", Offset = "0x126B148", VA = "0x126B148")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x742C64", Offset = "0x742C64")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002DE")]
			[Address(RVA = "0x126B150", Offset = "0x126B150", VA = "0x126B150")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x742C74", Offset = "0x742C74")]
			private set
			{
			}
		}

		[Token(Token = "0x1700008C")]
		public int priority
		{
			[Token(Token = "0x60002DF")]
			[Address(RVA = "0x126B158", Offset = "0x126B158", VA = "0x126B158")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x742C84", Offset = "0x742C84")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002E0")]
			[Address(RVA = "0x126B160", Offset = "0x126B160", VA = "0x126B160")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x742C94", Offset = "0x742C94")]
			private set
			{
			}
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x126B168", Offset = "0x126B168", VA = "0x126B168")]
		public HotkeyAttribute(KeyCode handledKey)
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x126B1A4", Offset = "0x126B1A4", VA = "0x126B1A4")]
		public HotkeyAttribute(KeyCode handledKey, EventModifiers eventModifiers)
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x126B238", Offset = "0x126B238", VA = "0x126B238")]
		public HotkeyAttribute(KeyCode handledKey, EventType LimitEventType)
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x126B2CC", Offset = "0x126B2CC", VA = "0x126B2CC")]
		public HotkeyAttribute(KeyCode handledKey, EventType LimitEventType, int priorityValue)
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x126B360", Offset = "0x126B360", VA = "0x126B360")]
		public HotkeyAttribute(KeyCode handledKey, EventModifiers eventModifiers, EventType LimitEventType)
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x126B428", Offset = "0x126B428", VA = "0x126B428")]
		public HotkeyAttribute(KeyCode handledKey, EventModifiers eventModifiers, EventType LimitEventType, int priorityValue)
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x126B4F4", Offset = "0x126B4F4", VA = "0x126B4F4")]
		internal static bool AssureValidity(MethodInfo method, HotkeyAttribute attr)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000B4")]
	public enum ContextType
	{
		[Token(Token = "0x40003E5")]
		Node,
		[Token(Token = "0x40003E6")]
		Canvas,
		[Token(Token = "0x40003E7")]
		Toolbar
	}
	[Token(Token = "0x20000B5")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x741A88", Offset = "0x741A88")]
	public class ContextEntryAttribute : Attribute
	{
		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7422D0", Offset = "0x7422D0")]
		private ContextType <contextType>k__BackingField;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7422E0", Offset = "0x7422E0")]
		private string <contextPath>k__BackingField;

		[Token(Token = "0x1700008D")]
		public ContextType contextType
		{
			[Token(Token = "0x60002E8")]
			[Address(RVA = "0x187FC28", Offset = "0x187FC28", VA = "0x187FC28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x742CA4", Offset = "0x742CA4")]
			get
			{
				return default(ContextType);
			}
			[Token(Token = "0x60002E9")]
			[Address(RVA = "0x187FC30", Offset = "0x187FC30", VA = "0x187FC30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x742CB4", Offset = "0x742CB4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700008E")]
		public string contextPath
		{
			[Token(Token = "0x60002EA")]
			[Address(RVA = "0x187FC38", Offset = "0x187FC38", VA = "0x187FC38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x742CC4", Offset = "0x742CC4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002EB")]
			[Address(RVA = "0x187FC40", Offset = "0x187FC40", VA = "0x187FC40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x742CD4", Offset = "0x742CD4")]
			private set
			{
			}
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x187FC48", Offset = "0x187FC48", VA = "0x187FC48")]
		public ContextEntryAttribute(ContextType type, string path)
		{
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x187FC8C", Offset = "0x187FC8C", VA = "0x187FC8C")]
		internal static bool AssureValidity(MethodInfo method, ContextEntryAttribute attr)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000B6")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x741A9C", Offset = "0x741A9C")]
	public class ContextFillerAttribute : Attribute
	{
		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7422F0", Offset = "0x7422F0")]
		private ContextType <contextType>k__BackingField;

		[Token(Token = "0x1700008F")]
		public ContextType contextType
		{
			[Token(Token = "0x60002EE")]
			[Address(RVA = "0x187FEF0", Offset = "0x187FEF0", VA = "0x187FEF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x742CE4", Offset = "0x742CE4")]
			get
			{
				return default(ContextType);
			}
			[Token(Token = "0x60002EF")]
			[Address(RVA = "0x187FEF8", Offset = "0x187FEF8", VA = "0x187FEF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x742CF4", Offset = "0x742CF4")]
			private set
			{
			}
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x187FF00", Offset = "0x187FF00", VA = "0x187FF00")]
		public ContextFillerAttribute(ContextType type)
		{
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x187FF2C", Offset = "0x187FF2C", VA = "0x187FF2C")]
		internal static bool AssureValidity(MethodInfo method, ContextFillerAttribute attr)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000B7")]
	public static class NodeEditorSaveManager
	{
		[Serializable]
		[Token(Token = "0x20000B8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x741AB0", Offset = "0x741AB0")]
		private sealed class <>c
		{
			[Token(Token = "0x40003EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40003ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<NodeCanvasSceneSave, string> <>9__2_0;

			[Token(Token = "0x40003EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<ScriptableObject, ScriptableObject> <>9__12_0;

			[Token(Token = "0x6000302")]
			[Address(RVA = "0x1A7E9D4", Offset = "0x1A7E9D4", VA = "0x1A7E9D4")]
			public <>c()
			{
			}

			[Token(Token = "0x6000303")]
			[Address(RVA = "0x1A7E9DC", Offset = "0x1A7E9DC", VA = "0x1A7E9DC")]
			internal string <GetSceneSaves>b__2_0(NodeCanvasSceneSave save)
			{
				return null;
			}

			[Token(Token = "0x6000304")]
			[Address(RVA = "0x1A7EA00", Offset = "0x1A7EA00", VA = "0x1A7EA00")]
			internal ScriptableObject <AddClonedSOs>b__12_0(ScriptableObject so)
			{
				return null;
			}
		}

		[Token(Token = "0x20000B9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x741AC0", Offset = "0x741AC0")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x40003EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string saveName;

			[Token(Token = "0x6000305")]
			[Address(RVA = "0x1A7EA8C", Offset = "0x1A7EA8C", VA = "0x1A7EA8C")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x6000306")]
			[Address(RVA = "0x1A7EA94", Offset = "0x1A7EA94", VA = "0x1A7EA94")]
			internal bool <FindSceneSave>b__0(NodeCanvasSceneSave save)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000BA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x741AD0", Offset = "0x741AD0")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x40003F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<ScriptableObject> allSOs;

			[Token(Token = "0x40003F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public List<ScriptableObject> clonedSOs;

			[Token(Token = "0x40003F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Func<ScriptableObject, ScriptableObject> <>9__0;

			[Token(Token = "0x40003F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Func<ScriptableObject, ScriptableObject> <>9__1;

			[Token(Token = "0x6000307")]
			[Address(RVA = "0x1A7EAD0", Offset = "0x1A7EAD0", VA = "0x1A7EAD0")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x6000308")]
			[Address(RVA = "0x1A7EAD8", Offset = "0x1A7EAD8", VA = "0x1A7EAD8")]
			internal ScriptableObject <CreateWorkingCopy>b__0(ScriptableObject so)
			{
				return null;
			}

			[Token(Token = "0x6000309")]
			[Address(RVA = "0x1A7EB34", Offset = "0x1A7EB34", VA = "0x1A7EB34")]
			internal ScriptableObject <CreateWorkingCopy>b__1(ScriptableObject so)
			{
				return null;
			}
		}

		[Token(Token = "0x20000BB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x741AE0", Offset = "0x741AE0")]
		private sealed class <>c__DisplayClass15_0
		{
			[Token(Token = "0x40003F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string stateName;

			[Token(Token = "0x600030A")]
			[Address(RVA = "0x1A7EA4C", Offset = "0x1A7EA4C", VA = "0x1A7EA4C")]
			public <>c__DisplayClass15_0()
			{
			}

			[Token(Token = "0x600030B")]
			[Address(RVA = "0x1A7EA54", Offset = "0x1A7EA54", VA = "0x1A7EA54")]
			internal bool <ExtractEditorState>b__0(NodeEditorState s)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static GameObject sceneSaveHolder;

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x127B79C", Offset = "0x127B79C", VA = "0x127B79C")]
		private static void FetchSceneSaveHolder()
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x127B90C", Offset = "0x127B90C", VA = "0x127B90C")]
		public static string[] GetSceneSaves()
		{
			return null;
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x127BA98", Offset = "0x127BA98", VA = "0x127BA98")]
		private static NodeCanvasSceneSave FindSceneSave(string saveName)
		{
			return null;
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x127BBF4", Offset = "0x127BBF4", VA = "0x127BBF4")]
		public static void SaveSceneNodeCanvas(string saveName, ref NodeCanvas nodeCanvas, bool createWorkingCopy)
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x127C5FC", Offset = "0x127C5FC", VA = "0x127C5FC")]
		public static NodeCanvas LoadSceneNodeCanvas(string saveName, bool createWorkingCopy)
		{
			return null;
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x127C700", Offset = "0x127C700", VA = "0x127C700")]
		public static void SaveNodeCanvas(string path, NodeCanvas nodeCanvas, bool createWorkingCopy, bool forceNew = false)
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x127C78C", Offset = "0x127C78C", VA = "0x127C78C")]
		public static NodeCanvas LoadNodeCanvas(string path, bool createWorkingCopy)
		{
			return null;
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x127C928", Offset = "0x127C928", VA = "0x127C928")]
		public static void Uncompress(ref NodeCanvas nodeCanvas)
		{
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x127BD98", Offset = "0x127BD98", VA = "0x127BD98")]
		public static NodeCanvas CreateWorkingCopy(NodeCanvas nodeCanvas, bool editorStates)
		{
			return null;
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x127CD24", Offset = "0x127CD24", VA = "0x127CD24")]
		private static NodeEditorState[] CreateWorkingCopy(NodeEditorState[] editorStates, NodeCanvas associatedNodeCanvas)
		{
			return null;
		}

		[Token(Token = "0x60002FC")]
		private static T Clone<T>(T SO) where T : ScriptableObject
		{
			return null;
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x127CBB4", Offset = "0x127CBB4", VA = "0x127CBB4")]
		private static void AddClonedSOs(List<ScriptableObject> scriptableObjects, List<ScriptableObject> clonedScriptableObjects, ScriptableObject[] initialSOs)
		{
		}

		[Token(Token = "0x60002FE")]
		private static T AddClonedSO<T>(List<ScriptableObject> scriptableObjects, List<ScriptableObject> clonedScriptableObjects, T initialSO) where T : ScriptableObject
		{
			return null;
		}

		[Token(Token = "0x60002FF")]
		private static T ReplaceSO<T>(List<ScriptableObject> scriptableObjects, List<ScriptableObject> clonedScriptableObjects, T initialSO) where T : ScriptableObject
		{
			return null;
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x127CFC8", Offset = "0x127CFC8", VA = "0x127CFC8")]
		public static NodeEditorState ExtractEditorState(NodeCanvas canvas, string stateName)
		{
			return null;
		}
	}
	[Token(Token = "0x20000BC")]
	public class NodeEditorState : ScriptableObject
	{
		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public NodeCanvas canvas;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public NodeEditorState parentEditor;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool drawing;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Node selectedNode;

		[NonSerialized]
		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Node focusedNode;

		[NonSerialized]
		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public NodeKnob focusedNodeKnob;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector2 panOffset;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float zoom;

		[NonSerialized]
		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public NodeOutput connectOutput;

		[NonSerialized]
		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool dragNode;

		[NonSerialized]
		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		public bool panWindow;

		[NonSerialized]
		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Vector2 dragStart;

		[NonSerialized]
		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector2 dragPos;

		[NonSerialized]
		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Vector2 dragOffset;

		[NonSerialized]
		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public bool navigate;

		[NonSerialized]
		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Rect canvasRect;

		[NonSerialized]
		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector2 zoomPanAdjust;

		[NonSerialized]
		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public List<Rect> ignoreInput;

		[Token(Token = "0x17000090")]
		public Vector2 zoomPos
		{
			[Token(Token = "0x600030C")]
			[Address(RVA = "0x1276FE0", Offset = "0x1276FE0", VA = "0x1276FE0")]
			get
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x127D244", Offset = "0x127D244", VA = "0x127D244")]
		public NodeEditorState()
		{
		}
	}
	[Token(Token = "0x20000BD")]
	public class NodeEditorUserCache
	{
		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public NodeCanvas nodeCanvas;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public NodeEditorState editorState;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string cachePath;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool useCache;

		[Token(Token = "0x400040B")]
		private const string MainEditorStateIdentifier = "MainEditorState";

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string openedCanvasPath;

		[Token(Token = "0x17000091")]
		private string lastSessionPath
		{
			[Token(Token = "0x600030F")]
			[Address(RVA = "0x127D6BC", Offset = "0x127D6BC", VA = "0x127D6BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x127D2D8", Offset = "0x127D2D8", VA = "0x127D2D8")]
		public void AssureCanvas()
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x127D76C", Offset = "0x127D76C", VA = "0x127D76C")]
		public NodeEditorUserCache(NodeCanvas loadedCanvas)
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x127D88C", Offset = "0x127D88C", VA = "0x127D88C")]
		public NodeEditorUserCache()
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x127D7E4", Offset = "0x127D7E4", VA = "0x127D7E4")]
		public void SetCanvas(NodeCanvas canvas)
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x127D8F0", Offset = "0x127D8F0", VA = "0x127D8F0")]
		public void SaveSceneNodeCanvas(string path)
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x127DA34", Offset = "0x127DA34", VA = "0x127DA34")]
		public void LoadSceneNodeCanvas(string path)
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x127DB60", Offset = "0x127DB60", VA = "0x127DB60")]
		public void SaveNodeCanvas(string path)
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x127DC00", Offset = "0x127DC00", VA = "0x127DC00")]
		public void LoadNodeCanvas(string path)
		{
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x127D3A4", Offset = "0x127D3A4", VA = "0x127D3A4")]
		public void NewNodeCanvas([Optional] Type canvasType)
		{
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x127D58C", Offset = "0x127D58C", VA = "0x127D58C")]
		public void NewEditorState()
		{
		}
	}
	[Token(Token = "0x20000BE")]
	public class NodeInput : NodeKnob
	{
		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public NodeOutput connection;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x742300", Offset = "0x742300")]
		public string typeID;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TypeData _typeData;

		[Token(Token = "0x17000092")]
		protected override NodeSide defaultSide
		{
			[Token(Token = "0x6000319")]
			[Address(RVA = "0x127DD3C", Offset = "0x127DD3C", VA = "0x127DD3C", Slot = "5")]
			get
			{
				return default(NodeSide);
			}
		}

		[Token(Token = "0x17000093")]
		internal TypeData typeData
		{
			[Token(Token = "0x600031A")]
			[Address(RVA = "0x127DD44", Offset = "0x127DD44", VA = "0x127DD44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000094")]
		public bool IsValueNull
		{
			[Token(Token = "0x6000322")]
			[Address(RVA = "0x127E154", Offset = "0x127E154", VA = "0x127E154")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x12715F4", Offset = "0x12715F4", VA = "0x12715F4")]
		public static NodeInput Create(Node nodeBody, string inputName, string inputType)
		{
			return null;
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x1271608", Offset = "0x1271608", VA = "0x1271608")]
		public static NodeInput Create(Node nodeBody, string inputName, string inputType, NodeSide nodeSide)
		{
			return null;
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x1271610", Offset = "0x1271610", VA = "0x1271610")]
		public static NodeInput Create(Node nodeBody, string inputName, string inputType, NodeSide nodeSide, float sidePosition)
		{
			return null;
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x127DF4C", Offset = "0x127DF4C", VA = "0x127DF4C", Slot = "6")]
		public override void Delete()
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x127E058", Offset = "0x127E058", VA = "0x127E058", Slot = "9")]
		protected internal override void CopyScriptableObjects(Func<ScriptableObject, ScriptableObject> replaceSerializableObject)
		{
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x127E114", Offset = "0x127E114", VA = "0x127E114", Slot = "7")]
		protected override void ReloadTexture()
		{
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x127DD68", Offset = "0x127DD68", VA = "0x127DD68")]
		private void CheckType()
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x127E1E8", Offset = "0x127E1E8", VA = "0x127E1E8")]
		public object GetValue()
		{
			return null;
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x127E274", Offset = "0x127E274", VA = "0x127E274")]
		public object GetValue(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x127E31C", Offset = "0x127E31C", VA = "0x127E31C")]
		public void SetValue(object value)
		{
		}

		[Token(Token = "0x6000326")]
		public T GetValue<T>()
		{
			return (T)null;
		}

		[Token(Token = "0x6000327")]
		public void SetValue<T>(T value)
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x127026C", Offset = "0x127026C", VA = "0x127026C")]
		public bool TryApplyConnection(NodeOutput output)
		{
			return default(bool);
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x127E3C0", Offset = "0x127E3C0", VA = "0x127E3C0")]
		public bool CanApplyConnection(NodeOutput output)
		{
			return default(bool);
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x1271E4C", Offset = "0x1271E4C", VA = "0x1271E4C")]
		public void ApplyConnection(NodeOutput output)
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x126FEA8", Offset = "0x126FEA8", VA = "0x126FEA8")]
		public void RemoveConnection()
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x127E574", Offset = "0x127E574", VA = "0x127E574", Slot = "11")]
		public override Node GetNodeAcrossConnection()
		{
			return null;
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x127E600", Offset = "0x127E600", VA = "0x127E600")]
		public NodeInput()
		{
		}
	}
	[Token(Token = "0x20000BF")]
	public enum NodeSide
	{
		[Token(Token = "0x4000411")]
		Left = 4,
		[Token(Token = "0x4000412")]
		Top = 3,
		[Token(Token = "0x4000413")]
		Right = 2,
		[Token(Token = "0x4000414")]
		Bottom = 1
	}
	[Serializable]
	[Token(Token = "0x20000C0")]
	public class NodeKnob : ScriptableObject
	{
		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Node body;

		[NonSerialized]
		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected internal Texture2D knobTexture;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public NodeSide side;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float sidePosition;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float sideOffset;

		[Token(Token = "0x17000095")]
		protected virtual GUIStyle defaultLabelStyle
		{
			[Token(Token = "0x600032E")]
			[Address(RVA = "0x127E610", Offset = "0x127E610", VA = "0x127E610", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000096")]
		protected virtual NodeSide defaultSide
		{
			[Token(Token = "0x600032F")]
			[Address(RVA = "0x127E67C", Offset = "0x127E67C", VA = "0x127E67C", Slot = "5")]
			get
			{
				return default(NodeSide);
			}
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x127DE74", Offset = "0x127DE74", VA = "0x127DE74")]
		protected void InitBase(Node nodeBody, NodeSide nodeSide, float nodeSidePosition, string knobName)
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x127DFBC", Offset = "0x127DFBC", VA = "0x127DFBC", Slot = "6")]
		public virtual void Delete()
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x127EB14", Offset = "0x127EB14", VA = "0x127EB14")]
		internal void Check()
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x127E684", Offset = "0x127E684", VA = "0x127E684")]
		protected void ReloadKnobTexture()
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x127EBC4", Offset = "0x127EBC4", VA = "0x127EBC4", Slot = "7")]
		protected virtual void ReloadTexture()
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x127EC70", Offset = "0x127EC70", VA = "0x127EC70", Slot = "8")]
		public virtual ScriptableObject[] GetScriptableObjects()
		{
			return null;
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x127ECB8", Offset = "0x127ECB8", VA = "0x127ECB8", Slot = "9")]
		protected internal virtual void CopyScriptableObjects(Func<ScriptableObject, ScriptableObject> replaceSerializableObject)
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x127ECBC", Offset = "0x127ECBC", VA = "0x127ECBC", Slot = "10")]
		public virtual void DrawKnob()
		{
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x127ED5C", Offset = "0x127ED5C", VA = "0x127ED5C")]
		public void DisplayLayout()
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x127EF18", Offset = "0x127EF18", VA = "0x127EF18")]
		public void DisplayLayout(GUIStyle style)
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x127EFA0", Offset = "0x127EFA0", VA = "0x127EFA0")]
		public void DisplayLayout(GUIContent content)
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x127EDF0", Offset = "0x127EDF0", VA = "0x127EDF0")]
		public void DisplayLayout(GUIContent content, GUIStyle style)
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x127EFDC", Offset = "0x127EFDC", VA = "0x127EFDC")]
		public void SetPosition(float position, NodeSide nodeSide)
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x127F020", Offset = "0x127F020", VA = "0x127F020")]
		public void SetPosition(float position)
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x127152C", Offset = "0x127152C", VA = "0x127152C")]
		public void SetPosition()
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x1270E24", Offset = "0x1270E24", VA = "0x1270E24")]
		public Rect GetGUIKnob()
		{
			return default(Rect);
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x12775B4", Offset = "0x12775B4", VA = "0x12775B4")]
		public Rect GetCanvasSpaceKnob()
		{
			return default(Rect);
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x127F028", Offset = "0x127F028", VA = "0x127F028")]
		private Vector2 GetKnobCenter(Vector2 knobSize)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x1270EF4", Offset = "0x1270EF4", VA = "0x1270EF4")]
		public Vector2 GetDirection()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x127EBB4", Offset = "0x127EBB4", VA = "0x127EBB4")]
		private static int getRotationStepsAntiCW(NodeSide sideA, NodeSide sideB)
		{
			return default(int);
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x127F160", Offset = "0x127F160", VA = "0x127F160", Slot = "11")]
		public virtual Node GetNodeAcrossConnection()
		{
			return null;
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x127E608", Offset = "0x127E608", VA = "0x127E608")]
		public NodeKnob()
		{
		}
	}
	[Token(Token = "0x20000C1")]
	public class NodeOutput : NodeKnob
	{
		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static GUIStyle _defaultStyle;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public List<NodeInput> connections;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x742338", Offset = "0x742338")]
		public string typeID;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TypeData _typeData;

		[NonSerialized]
		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private object value;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool calculationBlockade;

		[Token(Token = "0x17000097")]
		protected override NodeSide defaultSide
		{
			[Token(Token = "0x6000346")]
			[Address(RVA = "0x17074FC", Offset = "0x17074FC", VA = "0x17074FC", Slot = "5")]
			get
			{
				return default(NodeSide);
			}
		}

		[Token(Token = "0x17000098")]
		protected override GUIStyle defaultLabelStyle
		{
			[Token(Token = "0x6000347")]
			[Address(RVA = "0x1707504", Offset = "0x1707504", VA = "0x1707504", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000099")]
		internal TypeData typeData
		{
			[Token(Token = "0x6000348")]
			[Address(RVA = "0x1707610", Offset = "0x1707610", VA = "0x1707610")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009A")]
		public bool IsValueNull
		{
			[Token(Token = "0x6000350")]
			[Address(RVA = "0x1707A5C", Offset = "0x1707A5C", VA = "0x1707A5C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x1707740", Offset = "0x1707740", VA = "0x1707740")]
		public static NodeOutput Create(Node nodeBody, string outputName, string outputType)
		{
			return null;
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x1707824", Offset = "0x1707824", VA = "0x1707824")]
		public static NodeOutput Create(Node nodeBody, string outputName, string outputType, NodeSide nodeSide)
		{
			return null;
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x170774C", Offset = "0x170774C", VA = "0x170774C")]
		public static NodeOutput Create(Node nodeBody, string outputName, string outputType, NodeSide nodeSide, float sidePosition)
		{
			return null;
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x170782C", Offset = "0x170782C", VA = "0x170782C", Slot = "6")]
		public override void Delete()
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x17078DC", Offset = "0x17078DC", VA = "0x17078DC", Slot = "9")]
		protected internal override void CopyScriptableObjects(Func<ScriptableObject, ScriptableObject> replaceSerializableObject)
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x1707A1C", Offset = "0x1707A1C", VA = "0x1707A1C", Slot = "7")]
		protected override void ReloadTexture()
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x1707634", Offset = "0x1707634", VA = "0x1707634")]
		private void CheckType()
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x1707A6C", Offset = "0x1707A6C", VA = "0x1707A6C")]
		public object GetValue()
		{
			return null;
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x1707A74", Offset = "0x1707A74", VA = "0x1707A74")]
		public object GetValue(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x1707C78", Offset = "0x1707C78", VA = "0x1707C78")]
		public void SetValue(object Value)
		{
		}

		[Token(Token = "0x6000354")]
		public T GetValue<T>()
		{
			return (T)null;
		}

		[Token(Token = "0x6000355")]
		public void SetValue<T>(T Value)
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x1707DEC", Offset = "0x1707DEC", VA = "0x1707DEC")]
		public void ResetValue()
		{
		}

		[Token(Token = "0x6000357")]
		public static T GetDefault<T>()
		{
			return (T)null;
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x1707DF8", Offset = "0x1707DF8", VA = "0x1707DF8")]
		public static object GetDefault(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x1707ED4", Offset = "0x1707ED4", VA = "0x1707ED4", Slot = "11")]
		public override Node GetNodeAcrossConnection()
		{
			return null;
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x1707F4C", Offset = "0x1707F4C", VA = "0x1707F4C")]
		public NodeOutput()
		{
		}
	}
	[Token(Token = "0x20000C2")]
	public static class NodeTypes
	{
		[Serializable]
		[Token(Token = "0x20000C3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x741AF0", Offset = "0x741AF0")]
		private sealed class <>c
		{
			[Token(Token = "0x4000421")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000422")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<Assembly, bool> <>9__1_0;

			[Token(Token = "0x4000423")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<Type, bool> <>9__1_1;

			[Token(Token = "0x6000361")]
			[Address(RVA = "0x1A7EBF4", Offset = "0x1A7EBF4", VA = "0x1A7EBF4")]
			public <>c()
			{
			}

			[Token(Token = "0x6000362")]
			[Address(RVA = "0x1A7EBFC", Offset = "0x1A7EBFC", VA = "0x1A7EBFC")]
			internal bool <FetchNodes>b__1_0(Assembly assembly)
			{
				return default(bool);
			}

			[Token(Token = "0x6000363")]
			[Address(RVA = "0x1A7EC64", Offset = "0x1A7EC64", VA = "0x1A7EC64")]
			internal bool <FetchNodes>b__1_1(Type T)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x741B00", Offset = "0x741B00")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x4000424")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string nodeID;

			[Token(Token = "0x6000364")]
			[Address(RVA = "0x1A7ED30", Offset = "0x1A7ED30", VA = "0x1A7ED30")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x6000365")]
			[Address(RVA = "0x1A7ED38", Offset = "0x1A7ED38", VA = "0x1A7ED38")]
			internal bool <getDefaultNode>b__0(Node node)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x20000C5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x741B10", Offset = "0x741B10")]
		private sealed class <>c__4<T> where T : Node
		{
			[Token(Token = "0x4000425")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c__4<T> <>9;

			[Token(Token = "0x4000426")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static Func<Node, bool> <>9__4_0;

			[Token(Token = "0x6000367")]
			public <>c__4()
			{
			}

			[Token(Token = "0x6000368")]
			internal bool <getDefaultNode>b__4_0(Node node)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Dictionary<Node, NodeData> nodes;

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x1707FD0", Offset = "0x1707FD0", VA = "0x1707FD0")]
		public static void FetchNodes()
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x1708AB8", Offset = "0x1708AB8", VA = "0x1708AB8")]
		public static NodeData getNodeData(Node node)
		{
			return default(NodeData);
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x1708B48", Offset = "0x1708B48", VA = "0x1708B48")]
		public static Node getDefaultNode(string nodeID)
		{
			return null;
		}

		[Token(Token = "0x600035E")]
		public static T getDefaultNode<T>() where T : Node
		{
			return null;
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x1708C80", Offset = "0x1708C80", VA = "0x1708C80")]
		public static List<Node> getCompatibleNodes(NodeOutput nodeOutput)
		{
			return null;
		}
	}
	[Token(Token = "0x20000C6")]
	public struct NodeData
	{
		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string adress;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Type[] limitToCanvasTypes;

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x12744D8", Offset = "0x12744D8", VA = "0x12744D8")]
		public NodeData(string name, Type[] limitedCanvasTypes)
		{
		}
	}
	[Token(Token = "0x20000C7")]
	public class NodeAttribute : Attribute
	{
		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x742370", Offset = "0x742370")]
		private bool <hide>k__BackingField;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x742380", Offset = "0x742380")]
		private string <contextText>k__BackingField;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x742390", Offset = "0x742390")]
		private Type[] <limitToCanvasTypes>k__BackingField;

		[Token(Token = "0x1700009B")]
		public bool hide
		{
			[Token(Token = "0x600036A")]
			[Address(RVA = "0x1272C10", Offset = "0x1272C10", VA = "0x1272C10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x742D04", Offset = "0x742D04")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600036B")]
			[Address(RVA = "0x1272C18", Offset = "0x1272C18", VA = "0x1272C18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x742D14", Offset = "0x742D14")]
			private set
			{
			}
		}

		[Token(Token = "0x1700009C")]
		public string contextText
		{
			[Token(Token = "0x600036C")]
			[Address(RVA = "0x1272C24", Offset = "0x1272C24", VA = "0x1272C24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x742D24", Offset = "0x742D24")]
			get
			{
				return null;
			}
			[Token(Token = "0x600036D")]
			[Address(RVA = "0x1272C2C", Offset = "0x1272C2C", VA = "0x1272C2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x742D34", Offset = "0x742D34")]
			private set
			{
			}
		}

		[Token(Token = "0x1700009D")]
		public Type[] limitToCanvasTypes
		{
			[Token(Token = "0x600036E")]
			[Address(RVA = "0x1272C34", Offset = "0x1272C34", VA = "0x1272C34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x742D44", Offset = "0x742D44")]
			get
			{
				return null;
			}
			[Token(Token = "0x600036F")]
			[Address(RVA = "0x1272C3C", Offset = "0x1272C3C", VA = "0x1272C3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x742D54", Offset = "0x742D54")]
			private set
			{
			}
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x1272C44", Offset = "0x1272C44", VA = "0x1272C44")]
		public NodeAttribute(bool HideNode, string ReplacedContextText)
		{
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x1272C9C", Offset = "0x1272C9C", VA = "0x1272C9C")]
		public NodeAttribute(bool HideNode, string ReplacedContextText, Type[] limitedCanvasTypes)
		{
		}
	}
}
namespace NodeEditorFramework.Utilities
{
	[Token(Token = "0x20000C8")]
	public static class GUIScaleUtility
	{
		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool compabilityMode;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		private static bool initiated;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static FieldInfo currentGUILayoutCache;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static FieldInfo currentTopLevelGroup;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static Func<Rect> GetTopRectDelegate;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static Func<Rect> topmostRectDelegate;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7423A0", Offset = "0x7423A0")]
		private static List<Rect> <currentRectStack>k__BackingField;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static List<List<Rect>> rectStackGroups;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static List<Matrix4x4> GUIMatrices;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static List<bool> adjustedGUILayout;

		[Token(Token = "0x1700009E")]
		public static Rect getTopRect
		{
			[Token(Token = "0x6000372")]
			[Address(RVA = "0x1267F94", Offset = "0x1267F94", VA = "0x1267F94")]
			get
			{
				return default(Rect);
			}
		}

		[Token(Token = "0x1700009F")]
		public static Rect getTopRectScreenSpace
		{
			[Token(Token = "0x6000373")]
			[Address(RVA = "0x1268000", Offset = "0x1268000", VA = "0x1268000")]
			get
			{
				return default(Rect);
			}
		}

		[Token(Token = "0x170000A0")]
		public static List<Rect> currentRectStack
		{
			[Token(Token = "0x6000374")]
			[Address(RVA = "0x126806C", Offset = "0x126806C", VA = "0x126806C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x742D64", Offset = "0x742D64")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000375")]
			[Address(RVA = "0x12680B8", Offset = "0x12680B8", VA = "0x12680B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x742D74", Offset = "0x742D74")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A1")]
		public static Vector2 getCurrentScale
		{
			[Token(Token = "0x6000378")]
			[Address(RVA = "0x1268860", Offset = "0x1268860", VA = "0x1268860")]
			get
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x126810C", Offset = "0x126810C", VA = "0x126810C")]
		public static void CheckInit()
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x1268168", Offset = "0x1268168", VA = "0x1268168")]
		public static void Init()
		{
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x126896C", Offset = "0x126896C", VA = "0x126896C")]
		public static Vector2 BeginScale(ref Rect rect, Vector2 zoomPivot, float zoom, bool adjustGUILayout)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x12691A0", Offset = "0x12691A0", VA = "0x12691A0")]
		public static void EndScale()
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x1268E10", Offset = "0x1268E10", VA = "0x1268E10")]
		public static void BeginNoClip()
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x12696A8", Offset = "0x12696A8", VA = "0x12696A8")]
		public static void MoveClipsUp(int count)
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x126946C", Offset = "0x126946C", VA = "0x126946C")]
		public static void RestoreClips()
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x12698E8", Offset = "0x12698E8", VA = "0x12698E8")]
		public static void BeginNewLayout()
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x1269A38", Offset = "0x1269A38", VA = "0x1269A38")]
		public static void EndNewLayout()
		{
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x1269A98", Offset = "0x1269A98", VA = "0x1269A98")]
		public static void BeginIgnoreMatrix()
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x1269B98", Offset = "0x1269B98", VA = "0x1269B98")]
		public static void EndIgnoreMatrix()
		{
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x1269CF8", Offset = "0x1269CF8", VA = "0x1269CF8")]
		public static Vector2 Scale(Vector2 pos, Vector2 pivot, Vector2 scale)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x1269108", Offset = "0x1269108", VA = "0x1269108")]
		public static Rect Scale(Rect rect, Vector2 pivot, Vector2 scale)
		{
			return default(Rect);
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x1269D14", Offset = "0x1269D14", VA = "0x1269D14")]
		public static Vector2 ScaledToGUISpace(Vector2 scaledPosition)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x1269E2C", Offset = "0x1269E2C", VA = "0x1269E2C")]
		public static Rect ScaledToGUISpace(Rect scaledRect)
		{
			return default(Rect);
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x1269EF4", Offset = "0x1269EF4", VA = "0x1269EF4")]
		public static Vector2 GUIToScaledSpace(Vector2 guiPosition)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x1269040", Offset = "0x1269040", VA = "0x1269040")]
		public static Rect GUIToScaledSpace(Rect guiRect)
		{
			return default(Rect);
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x126A00C", Offset = "0x126A00C", VA = "0x126A00C")]
		public static Vector2 GUIToScreenSpace(Vector2 guiPosition)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x126A054", Offset = "0x126A054", VA = "0x126A054")]
		public static Rect GUIToScreenSpace(Rect guiRect)
		{
			return default(Rect);
		}
	}
	[Token(Token = "0x20000C9")]
	public static class OverlayGUI
	{
		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static PopupMenu currentPopup;

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x170AC34", Offset = "0x170AC34", VA = "0x170AC34")]
		public static bool HasPopupControl()
		{
			return default(bool);
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x170AC88", Offset = "0x170AC88", VA = "0x170AC88")]
		public static void StartOverlayGUI()
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x170AE98", Offset = "0x170AE98", VA = "0x170AE98")]
		public static void EndOverlayGUI()
		{
		}
	}
	[Token(Token = "0x20000CA")]
	public class PopupMenu
	{
		[Token(Token = "0x20000CB")]
		public delegate void MenuFunction();

		[Token(Token = "0x20000CC")]
		public delegate void MenuFunctionData(object userData);

		[Token(Token = "0x20000CD")]
		public class MenuItem
		{
			[Token(Token = "0x4000442")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string path;

			[Token(Token = "0x4000443")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GUIContent content;

			[Token(Token = "0x4000444")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MenuFunction func;

			[Token(Token = "0x4000445")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MenuFunctionData funcData;

			[Token(Token = "0x4000446")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public object userData;

			[Token(Token = "0x4000447")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool separator;

			[Token(Token = "0x4000448")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
			public bool group;

			[Token(Token = "0x4000449")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Rect groupPos;

			[Token(Token = "0x400044A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public List<MenuItem> subItems;

			[Token(Token = "0x60003A2")]
			[Address(RVA = "0x1A7F504", Offset = "0x1A7F504", VA = "0x1A7F504")]
			public MenuItem()
			{
			}

			[Token(Token = "0x60003A3")]
			[Address(RVA = "0x1A7F530", Offset = "0x1A7F530", VA = "0x1A7F530")]
			public MenuItem(string _path, GUIContent _content, bool _group)
			{
			}

			[Token(Token = "0x60003A4")]
			[Address(RVA = "0x1A7F614", Offset = "0x1A7F614", VA = "0x1A7F614")]
			public MenuItem(string _path, GUIContent _content, MenuFunction _func)
			{
			}

			[Token(Token = "0x60003A5")]
			[Address(RVA = "0x1A7F678", Offset = "0x1A7F678", VA = "0x1A7F678")]
			public MenuItem(string _path, GUIContent _content, MenuFunctionData _func, object _userData)
			{
			}

			[Token(Token = "0x60003A6")]
			[Address(RVA = "0x1A7F6F8", Offset = "0x1A7F6F8", VA = "0x1A7F6F8")]
			public void Execute()
			{
			}
		}

		[Token(Token = "0x20000CE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x741B20", Offset = "0x741B20")]
		private sealed class <>c__DisplayClass21_0
		{
			[Token(Token = "0x400044B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string folderPath;

			[Token(Token = "0x60003A7")]
			[Address(RVA = "0x1A7ED78", Offset = "0x1A7ED78", VA = "0x1A7ED78")]
			public <>c__DisplayClass21_0()
			{
			}

			[Token(Token = "0x60003A8")]
			[Address(RVA = "0x1A7ED80", Offset = "0x1A7ED80", VA = "0x1A7ED80")]
			internal bool <AddHierarchy>b__0(MenuItem item)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000CF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x741B30", Offset = "0x741B30")]
		private sealed class <>c__DisplayClass21_1
		{
			[Token(Token = "0x400044C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string folder;

			[Token(Token = "0x60003A9")]
			[Address(RVA = "0x1A7EDDC", Offset = "0x1A7EDDC", VA = "0x1A7EDDC")]
			public <>c__DisplayClass21_1()
			{
			}

			[Token(Token = "0x60003AA")]
			[Address(RVA = "0x1A7EDE4", Offset = "0x1A7EDE4", VA = "0x1A7EDE4")]
			internal bool <AddHierarchy>b__1(MenuItem item)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<MenuItem> menuItems;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Rect position;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string selectedPath;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private MenuItem groupToDraw;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float currentItemHeight;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool close;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static GUIStyle backgroundStyle;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Texture2D expandRight;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static float itemHeight;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static GUIStyle selectedLabel;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float minWidth;

		[Token(Token = "0x170000A2")]
		public Vector2 Position
		{
			[Token(Token = "0x6000390")]
			[Address(RVA = "0x170BD70", Offset = "0x170BD70", VA = "0x170BD70")]
			get
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x170B280", Offset = "0x170B280", VA = "0x170B280")]
		public PopupMenu()
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x170B308", Offset = "0x170B308", VA = "0x170B308")]
		public void SetupGUI()
		{
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x170BAE8", Offset = "0x170BAE8", VA = "0x170BAE8")]
		public void Show(Vector2 pos, float MinWidth = 40f)
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x170BD7C", Offset = "0x170BD7C", VA = "0x170BD7C")]
		public void AddItem(GUIContent content, bool on, MenuFunctionData func, object userData)
		{
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x170C3D4", Offset = "0x170C3D4", VA = "0x170C3D4")]
		public void AddItem(GUIContent content, bool on, MenuFunction func)
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x170C4AC", Offset = "0x170C4AC", VA = "0x170C4AC")]
		public void AddSeparator(string path)
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x170BE5C", Offset = "0x170BE5C", VA = "0x170BE5C")]
		private MenuItem AddHierarchy(ref GUIContent content, out string path)
		{
			return null;
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x170AD30", Offset = "0x170AD30", VA = "0x170AD30")]
		public void Draw()
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x170C594", Offset = "0x170C594", VA = "0x170C594")]
		private bool DrawGroup(Rect pos, List<MenuItem> menuItems)
		{
			return default(bool);
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x170C934", Offset = "0x170C934", VA = "0x170C934")]
		private void DrawItem(MenuItem item, Rect groupRect)
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x170C884", Offset = "0x170C884", VA = "0x170C884")]
		private static Rect extendRect(Rect rect, Vector2 extendValue)
		{
			return default(Rect);
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x170BB9C", Offset = "0x170BB9C", VA = "0x170BB9C")]
		private static Rect calculateRect(Vector2 position, List<MenuItem> menuItems, float minWidth)
		{
			return default(Rect);
		}
	}
	[Token(Token = "0x20000D0")]
	public class GenericMenu
	{
		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static PopupMenu popup;

		[Token(Token = "0x170000A3")]
		public Vector2 Position
		{
			[Token(Token = "0x60003AB")]
			[Address(RVA = "0x126A3D0", Offset = "0x126A3D0", VA = "0x126A3D0")]
			get
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x126A428", Offset = "0x126A428", VA = "0x126A428")]
		public GenericMenu()
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x126A4B0", Offset = "0x126A4B0", VA = "0x126A4B0")]
		public void ShowAsContext()
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x126A52C", Offset = "0x126A52C", VA = "0x126A52C")]
		public void Show(Vector2 pos, float MinWidth = 40f)
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x126A5B4", Offset = "0x126A5B4", VA = "0x126A5B4")]
		public void AddItem(GUIContent content, bool on, PopupMenu.MenuFunctionData func, object userData)
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x126A63C", Offset = "0x126A63C", VA = "0x126A63C")]
		public void AddItem(GUIContent content, bool on, PopupMenu.MenuFunction func)
		{
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x126A6B4", Offset = "0x126A6B4", VA = "0x126A6B4")]
		public void AddSeparator(string path)
		{
		}
	}
	[Token(Token = "0x20000D1")]
	public static class RTEditorGUI
	{
		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static float labelWidth;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static float fieldWidth;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static float indent;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static GUIStyle seperator;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static Stack<bool> changeStack;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static int activeFloatField;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private static float activeFloatFieldLastValue;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static string activeFloatFieldString;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static Material texVizMat;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static Material lineMaterial;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static Texture2D lineTexture;

		[Token(Token = "0x170000A4")]
		private static float textFieldHeight
		{
			[Token(Token = "0x60003B2")]
			[Address(RVA = "0x170EF2C", Offset = "0x170EF2C", VA = "0x170EF2C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x170EFF8", Offset = "0x170EFF8", VA = "0x170EFF8")]
		public static Rect PrefixLabel(Rect totalPos, GUIContent label, GUIStyle style)
		{
			return default(Rect);
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x170F2B8", Offset = "0x170F2B8", VA = "0x170F2B8")]
		public static Rect PrefixLabel(Rect totalPos, float percentage, GUIContent label, GUIStyle style)
		{
			return default(Rect);
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x170F4C4", Offset = "0x170F4C4", VA = "0x170F4C4")]
		private static Rect IndentedRect(Rect source)
		{
			return default(Rect);
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x170F220", Offset = "0x170F220", VA = "0x170F220")]
		private static float getLabelWidth()
		{
			return default(float);
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x170F5C0", Offset = "0x170F5C0", VA = "0x170F5C0")]
		private static float getFieldWidth()
		{
			return default(float);
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x170F658", Offset = "0x170F658", VA = "0x170F658")]
		private static Rect GetFieldRect(GUIContent label, GUIStyle style, params GUILayoutOption[] options)
		{
			return default(Rect);
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x170F7C4", Offset = "0x170F7C4", VA = "0x170F7C4")]
		private static Rect GetSliderRect(GUIContent label, GUIStyle style, params GUILayoutOption[] options)
		{
			return default(Rect);
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x170F93C", Offset = "0x170F93C", VA = "0x170F93C")]
		private static Rect GetSliderRect(Rect sliderRect)
		{
			return default(Rect);
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x170FA28", Offset = "0x170FA28", VA = "0x170FA28")]
		private static Rect GetSliderFieldRect(Rect sliderRect)
		{
			return default(Rect);
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x170FB20", Offset = "0x170FB20", VA = "0x170FB20")]
		public static void Space()
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x170FB7C", Offset = "0x170FB7C", VA = "0x170FB7C")]
		public static void Space(float pixels)
		{
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x170FBEC", Offset = "0x170FBEC", VA = "0x170FBEC")]
		public static void Seperator()
		{
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x170CDF8", Offset = "0x170CDF8", VA = "0x170CDF8")]
		public static void Seperator(Rect rect)
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x170FD28", Offset = "0x170FD28", VA = "0x170FD28")]
		private static void setupSeperator()
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x170FEC4", Offset = "0x170FEC4", VA = "0x170FEC4")]
		public static void BeginChangeCheck()
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x170FF94", Offset = "0x170FF94", VA = "0x170FF94")]
		public static bool EndChangeCheck()
		{
			return default(bool);
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x1710200", Offset = "0x1710200", VA = "0x1710200")]
		public static bool Foldout(bool foldout, string content, params GUILayoutOption[] options)
		{
			return default(bool);
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x1710370", Offset = "0x1710370", VA = "0x1710370")]
		public static bool Foldout(bool foldout, string content, GUIStyle style, params GUILayoutOption[] options)
		{
			return default(bool);
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x17102A4", Offset = "0x17102A4", VA = "0x17102A4")]
		public static bool Foldout(bool foldout, GUIContent content, params GUILayoutOption[] options)
		{
			return default(bool);
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x1710428", Offset = "0x1710428", VA = "0x1710428")]
		public static bool Foldout(bool foldout, GUIContent content, GUIStyle style, params GUILayoutOption[] options)
		{
			return default(bool);
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x1710434", Offset = "0x1710434", VA = "0x1710434")]
		public static bool Toggle(bool toggle, string content, params GUILayoutOption[] options)
		{
			return default(bool);
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x17105A4", Offset = "0x17105A4", VA = "0x17105A4")]
		public static bool Toggle(bool toggle, string content, GUIStyle style, params GUILayoutOption[] options)
		{
			return default(bool);
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x17104D8", Offset = "0x17104D8", VA = "0x17104D8")]
		public static bool Toggle(bool toggle, GUIContent content, params GUILayoutOption[] options)
		{
			return default(bool);
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x171065C", Offset = "0x171065C", VA = "0x171065C")]
		public static bool Toggle(bool toggle, GUIContent content, GUIStyle style, params GUILayoutOption[] options)
		{
			return default(bool);
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x1710668", Offset = "0x1710668", VA = "0x1710668")]
		public static string TextField(GUIContent label, string text, GUIStyle style, params GUILayoutOption[] options)
		{
			return null;
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x17107A4", Offset = "0x17107A4", VA = "0x17107A4")]
		public static int OptionSlider(GUIContent label, int selected, string[] selectableOptions, params GUILayoutOption[] options)
		{
			return default(int);
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x171087C", Offset = "0x171087C", VA = "0x171087C")]
		public static int OptionSlider(GUIContent label, int selected, string[] selectableOptions, GUIStyle style, params GUILayoutOption[] options)
		{
			return default(int);
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x1710A44", Offset = "0x1710A44", VA = "0x1710A44")]
		public static int MathPowerSlider(GUIContent label, int baseValue, int value, int minPow, int maxPow, params GUILayoutOption[] options)
		{
			return default(int);
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x1710B74", Offset = "0x1710B74", VA = "0x1710B74")]
		public static int MathPowerSliderRaw(GUIContent label, int baseValue, int power, int minPow, int maxPow, params GUILayoutOption[] options)
		{
			return default(int);
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x1710D40", Offset = "0x1710D40", VA = "0x1710D40")]
		public static int IntSlider(string label, int value, int minValue, int maxValue, params GUILayoutOption[] options)
		{
			return default(int);
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x1711058", Offset = "0x1711058", VA = "0x1711058")]
		public static int IntSlider(GUIContent label, int value, int minValue, int maxValue, params GUILayoutOption[] options)
		{
			return default(int);
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x1711108", Offset = "0x1711108", VA = "0x1711108")]
		public static int IntSlider(int value, int minValue, int maxValue, params GUILayoutOption[] options)
		{
			return default(int);
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x17111F0", Offset = "0x17111F0", VA = "0x17111F0")]
		public static int IntField(string label, int value, params GUILayoutOption[] options)
		{
			return default(int);
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x17113DC", Offset = "0x17113DC", VA = "0x17113DC")]
		public static int IntField(GUIContent label, int value, params GUILayoutOption[] options)
		{
			return default(int);
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x1711474", Offset = "0x1711474", VA = "0x1711474")]
		public static int IntField(int value, params GUILayoutOption[] options)
		{
			return default(int);
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x17115BC", Offset = "0x17115BC", VA = "0x17115BC")]
		public static float Slider(float value, float minValue, float maxValue, params GUILayoutOption[] options)
		{
			return default(float);
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x1711684", Offset = "0x1711684", VA = "0x1711684")]
		public static float Slider(string label, float value, float minValue, float maxValue, params GUILayoutOption[] options)
		{
			return default(float);
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x1710E1C", Offset = "0x1710E1C", VA = "0x1710E1C")]
		public static float Slider(GUIContent label, float value, float minValue, float maxValue, params GUILayoutOption[] options)
		{
			return default(float);
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x1711B64", Offset = "0x1711B64", VA = "0x1711B64")]
		public static float FloatField(string label, float value, params GUILayoutOption[] fieldOptions)
		{
			return default(float);
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x17112B4", Offset = "0x17112B4", VA = "0x17112B4")]
		public static float FloatField(GUIContent label, float value, params GUILayoutOption[] options)
		{
			return default(float);
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x1711504", Offset = "0x1711504", VA = "0x1711504")]
		public static float FloatField(float value, params GUILayoutOption[] options)
		{
			return default(float);
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x1711748", Offset = "0x1711748", VA = "0x1711748")]
		public static float FloatField(Rect pos, float value, params GUILayoutOption[] options)
		{
			return default(float);
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x1711C10", Offset = "0x1711C10", VA = "0x1711C10")]
		public static float ForceParse(this string str)
		{
			return default(float);
		}

		[Token(Token = "0x60003DE")]
		public static T ObjectField<T>(T obj, bool allowSceneObjects) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x60003DF")]
		public static T ObjectField<T>(string label, T obj, bool allowSceneObjects) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x60003E0")]
		public static T ObjectField<T>(GUIContent label, T obj, bool allowSceneObjects, params GUILayoutOption[] options) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x1711E60", Offset = "0x1711E60", VA = "0x1711E60")]
		public static Enum EnumPopup(Enum selected)
		{
			return null;
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x1712048", Offset = "0x1712048", VA = "0x1712048")]
		public static Enum EnumPopup(string label, Enum selected)
		{
			return null;
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x1711F00", Offset = "0x1711F00", VA = "0x1711F00")]
		public static Enum EnumPopup(GUIContent label, Enum selected)
		{
			return null;
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x17120E4", Offset = "0x17120E4", VA = "0x17120E4")]
		public static int Popup(GUIContent label, int selected, string[] displayedOptions)
		{
			return default(int);
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x17122C0", Offset = "0x17122C0", VA = "0x17122C0")]
		public static int Popup(string label, int selected, string[] displayedOptions)
		{
			return default(int);
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x17123DC", Offset = "0x17123DC", VA = "0x17123DC")]
		public static int Popup(int selected, string[] displayedOptions)
		{
			return default(int);
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x1712454", Offset = "0x1712454", VA = "0x1712454")]
		public static void DrawTexture(Texture texture, int texSize, GUIStyle style, params GUILayoutOption[] options)
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x17124F8", Offset = "0x17124F8", VA = "0x17124F8")]
		public static void DrawTexture(Texture texture, int texSize, GUIStyle style, int shuffleRed, int shuffleGreen, int shuffleBlue, int shuffleAlpha, params GUILayoutOption[] options)
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x1712968", Offset = "0x1712968", VA = "0x1712968")]
		private static void SetupLineMat(Texture tex, Color col)
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x1712C90", Offset = "0x1712C90", VA = "0x1712C90")]
		public static void DrawBezier(Vector2 startPos, Vector2 endPos, Vector2 startTan, Vector2 endTan, Color col, Texture2D tex, float width = 1f)
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x17130E4", Offset = "0x17130E4", VA = "0x17130E4")]
		public static void DrawBezier(Vector2 startPos, Vector2 endPos, Vector2 startTan, Vector2 endTan, Color col, Texture2D tex, int segmentCount, float width)
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x171335C", Offset = "0x171335C", VA = "0x171335C")]
		public static void DrawPolygonLine(Vector2[] points, Color col, Texture2D tex, float width = 1f)
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x1712E10", Offset = "0x1712E10", VA = "0x1712E10")]
		private static int CalculateBezierSegmentCount(Vector2 startPos, Vector2 endPos, Vector2 startTan, Vector2 endTan)
		{
			return default(int);
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x1713D58", Offset = "0x1713D58", VA = "0x1713D58")]
		private static Vector2 CalculateLinePerpendicular(Vector2 startPos, Vector2 endPos)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x1713CA8", Offset = "0x1713CA8", VA = "0x1713CA8")]
		private static Vector2 CalculatePointPerpendicular(Vector2 prevPos, Vector2 pointPos, Vector2 nextPos)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x17132F0", Offset = "0x17132F0", VA = "0x17132F0")]
		private static Vector2 GetBezierPoint(float t, Vector2 startPos, Vector2 endPos, Vector2 startTan, Vector2 endTan)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x1713D88", Offset = "0x1713D88", VA = "0x1713D88")]
		private static void DrawLineSegment(Vector2 point, Vector2 perpendicular)
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x17137B4", Offset = "0x17137B4", VA = "0x17137B4")]
		public static void DrawLine(Vector2 startPos, Vector2 endPos, Color col, Texture2D tex, float width = 1f)
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x1713DFC", Offset = "0x1713DFC", VA = "0x1713DFC")]
		private static bool SegmentRectIntersection(Rect bounds, ref Vector2 p0, ref Vector2 p1)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x1713968", Offset = "0x1713968", VA = "0x1713968")]
		private static bool SegmentRectIntersection(Rect bounds, ref Vector2 p0, ref Vector2 p1, out bool clippedP0, out bool clippedP1)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x1713EB4", Offset = "0x1713EB4", VA = "0x1713EB4")]
		private static bool ClipTest(float p, float q, ref float t0, ref float t1)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x170B674", Offset = "0x170B674", VA = "0x170B674")]
		public static Texture2D ColorToTex(int pxSize, Color col)
		{
			return null;
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x1713F1C", Offset = "0x1713F1C", VA = "0x1713F1C")]
		public static Texture2D Tint(Texture2D tex, Color color)
		{
			return null;
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x17140C4", Offset = "0x17140C4", VA = "0x17140C4")]
		public static Texture2D RotateTextureCCW(Texture2D tex, int quarterSteps)
		{
			return null;
		}
	}
	[Token(Token = "0x20000D2")]
	public static class ResourceManager
	{
		[Token(Token = "0x20000D3")]
		public class MemoryTexture
		{
			[Token(Token = "0x400045B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string path;

			[Token(Token = "0x400045C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Texture2D texture;

			[Token(Token = "0x400045D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string[] modifications;

			[Token(Token = "0x6000407")]
			[Address(RVA = "0x1A7F9B4", Offset = "0x1A7F9B4", VA = "0x1A7F9B4")]
			public MemoryTexture(string texPath, Texture2D tex, params string[] mods)
			{
			}
		}

		[Token(Token = "0x20000D4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x741B50", Offset = "0x741B50")]
		private sealed class <>c__DisplayClass6_0
		{
			[Token(Token = "0x400045E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string texPath;

			[Token(Token = "0x6000408")]
			[Address(RVA = "0x1A7F8FC", Offset = "0x1A7F8FC", VA = "0x1A7F8FC")]
			public <>c__DisplayClass6_0()
			{
			}

			[Token(Token = "0x6000409")]
			[Address(RVA = "0x1A7F904", Offset = "0x1A7F904", VA = "0x1A7F904")]
			internal bool <LoadTexture>b__0(MemoryTexture memTex)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000D5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x741B60", Offset = "0x741B60")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x400045F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Texture2D tex;

			[Token(Token = "0x600040A")]
			[Address(RVA = "0x1A7F928", Offset = "0x1A7F928", VA = "0x1A7F928")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x600040B")]
			[Address(RVA = "0x1A7F930", Offset = "0x1A7F930", VA = "0x1A7F930")]
			internal bool <FindInMemory>b__0(MemoryTexture memTex)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000D6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x741B70", Offset = "0x741B70")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x4000460")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string texturePath;

			[Token(Token = "0x600040C")]
			[Address(RVA = "0x1A7F71C", Offset = "0x1A7F71C", VA = "0x1A7F71C")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x600040D")]
			[Address(RVA = "0x1A7F724", Offset = "0x1A7F724", VA = "0x1A7F724")]
			internal bool <HasInMemory>b__0(MemoryTexture memTex)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000D7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x741B80", Offset = "0x741B80")]
		private sealed class <>c__DisplayClass11_0
		{
			[Token(Token = "0x4000461")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string texturePath;

			[Token(Token = "0x600040E")]
			[Address(RVA = "0x1A7F748", Offset = "0x1A7F748", VA = "0x1A7F748")]
			public <>c__DisplayClass11_0()
			{
			}

			[Token(Token = "0x600040F")]
			[Address(RVA = "0x1A7F750", Offset = "0x1A7F750", VA = "0x1A7F750")]
			internal bool <GetMemoryTexture>b__0(MemoryTexture memTex)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000D8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x741B90", Offset = "0x741B90")]
		private sealed class <>c__DisplayClass13_0
		{
			[Token(Token = "0x4000462")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string[] modsB;

			[Token(Token = "0x4000463")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string[] modsA;

			[Token(Token = "0x6000410")]
			[Address(RVA = "0x1A7F774", Offset = "0x1A7F774", VA = "0x1A7F774")]
			public <>c__DisplayClass13_0()
			{
			}

			[Token(Token = "0x6000411")]
			[Address(RVA = "0x1A7F77C", Offset = "0x1A7F77C", VA = "0x1A7F77C")]
			internal bool <EqualModifications>b__0(string mod)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000D9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x741BA0", Offset = "0x741BA0")]
		private sealed class <>c__DisplayClass13_1
		{
			[Token(Token = "0x4000464")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string mod;

			[Token(Token = "0x6000412")]
			[Address(RVA = "0x1A7F8DC", Offset = "0x1A7F8DC", VA = "0x1A7F8DC")]
			public <>c__DisplayClass13_1()
			{
			}

			[Token(Token = "0x6000413")]
			[Address(RVA = "0x1A7F8E4", Offset = "0x1A7F8E4", VA = "0x1A7F8E4")]
			internal bool <EqualModifications>b__1(string oMod)
			{
				return default(bool);
			}

			[Token(Token = "0x6000414")]
			[Address(RVA = "0x1A7F8F0", Offset = "0x1A7F8F0", VA = "0x1A7F8F0")]
			internal bool <EqualModifications>b__2(string oMod)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static string _ResourcePath;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static List<MemoryTexture> loadedTextures;

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x1714BF8", Offset = "0x1714BF8", VA = "0x1714BF8")]
		public static void SetDefaultResourcePath(string defaultResourcePath)
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x1714C64", Offset = "0x1714C64", VA = "0x1714C64")]
		public static string PreparePath(string path)
		{
			return null;
		}

		[Token(Token = "0x60003FC")]
		public static T[] LoadResources<T>(string path) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x60003FD")]
		public static T LoadResource<T>(string path) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x170B764", Offset = "0x170B764", VA = "0x170B764")]
		public static Texture2D LoadTexture(string texPath)
		{
			return null;
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x1714E70", Offset = "0x1714E70", VA = "0x1714E70")]
		public static Texture2D GetTintedTexture(string texPath, Color col)
		{
			return null;
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x1714D40", Offset = "0x1714D40", VA = "0x1714D40")]
		public static void AddTextureToMemory(string texturePath, Texture2D texture, params string[] modifications)
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x17151F0", Offset = "0x17151F0", VA = "0x17151F0")]
		public static MemoryTexture FindInMemory(Texture2D tex)
		{
			return null;
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x1715388", Offset = "0x1715388", VA = "0x1715388")]
		public static bool HasInMemory(string texturePath, params string[] modifications)
		{
			return default(bool);
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x1715688", Offset = "0x1715688", VA = "0x1715688")]
		public static MemoryTexture GetMemoryTexture(string texturePath, params string[] modifications)
		{
			return null;
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x1715174", Offset = "0x1715174", VA = "0x1715174")]
		public static Texture2D GetTexture(string texturePath, params string[] modifications)
		{
			return null;
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x1715548", Offset = "0x1715548", VA = "0x1715548")]
		private static bool EqualModifications(string[] modsA, string[] modsB)
		{
			return default(bool);
		}
	}
}
namespace CatlikeCoding.SDFToolkit
{
	[Token(Token = "0x20000DA")]
	public enum RGBFillMode
	{
		[Token(Token = "0x4000466")]
		White,
		[Token(Token = "0x4000467")]
		Black,
		[Token(Token = "0x4000468")]
		Distance,
		[Token(Token = "0x4000469")]
		Source
	}
	[Token(Token = "0x20000DB")]
	public static class SDFTextureGenerator
	{
		[Token(Token = "0x20000DC")]
		private class Pixel
		{
			[Token(Token = "0x400046D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float alpha;

			[Token(Token = "0x400046E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float distance;

			[Token(Token = "0x400046F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector2 gradient;

			[Token(Token = "0x4000470")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int dX;

			[Token(Token = "0x4000471")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public int dY;

			[Token(Token = "0x600041B")]
			[Address(RVA = "0x1A7FA18", Offset = "0x1A7FA18", VA = "0x1A7FA18")]
			public Pixel()
			{
			}
		}

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int width;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static int height;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Pixel[,] pixels;

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x1715C20", Offset = "0x1715C20", VA = "0x1715C20")]
		public static void Generate(Texture2D source, Texture2D destination, float maxInside, float maxOutside, float postProcessDistance, RGBFillMode rgbMode)
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x17163FC", Offset = "0x17163FC", VA = "0x17163FC")]
		private static void ComputeEdgeGradients()
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x1716EB4", Offset = "0x1716EB4", VA = "0x1716EB4")]
		private static float ApproximateEdgeDelta(float gx, float gy, float a)
		{
			return default(float);
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x1716FCC", Offset = "0x1716FCC", VA = "0x1716FCC")]
		private static void UpdateDistance(Pixel p, int x, int y, int oX, int oY)
		{
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x1716690", Offset = "0x1716690", VA = "0x1716690")]
		private static void GenerateDistanceTransform()
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x1716CCC", Offset = "0x1716CCC", VA = "0x1716CCC")]
		private static void PostProcess(float maxDistance)
		{
		}
	}
	[Token(Token = "0x20000DD")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x741BB0", Offset = "0x741BB0")]
	[ExecuteInEditMode]
	public class UIMaterialLink : MonoBehaviour
	{
		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Material sourceMaterial;

		[NonSerialized]
		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string[] shaderKeywords;

		[Token(Token = "0x170000A5")]
		public Material SourceMaterial
		{
			[Token(Token = "0x600041C")]
			[Address(RVA = "0x1A7A118", Offset = "0x1A7A118", VA = "0x1A7A118")]
			get
			{
				return null;
			}
			[Token(Token = "0x600041D")]
			[Address(RVA = "0x1A7A120", Offset = "0x1A7A120", VA = "0x1A7A120")]
			set
			{
			}
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x1A7A1D0", Offset = "0x1A7A1D0", VA = "0x1A7A1D0")]
		public Material GetModifiedMaterial(Material baseMaterial)
		{
			return null;
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x1A7A2F4", Offset = "0x1A7A2F4", VA = "0x1A7A2F4")]
		public UIMaterialLink()
		{
		}
	}
}
namespace CatlikeCoding.SDFToolkit.Examples
{
	[Token(Token = "0x20000DE")]
	public class CameraDistance : MonoBehaviour
	{
		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float min;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float max;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 lookAt;

		[Token(Token = "0x170000A6")]
		public float DistanceFactor
		{
			[Token(Token = "0x6000420")]
			[Address(RVA = "0x18798F0", Offset = "0x18798F0", VA = "0x18798F0")]
			set
			{
			}
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x1879998", Offset = "0x1879998", VA = "0x1879998")]
		public CameraDistance()
		{
		}
	}
	[Token(Token = "0x20000DF")]
	public class CursorSpotlight : MonoBehaviour
	{
		[Token(Token = "0x6000422")]
		[Address(RVA = "0x188179C", Offset = "0x188179C", VA = "0x188179C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x1881840", Offset = "0x1881840", VA = "0x1881840")]
		public CursorSpotlight()
		{
		}
	}
	[Token(Token = "0x20000E0")]
	public class MovingLight : MonoBehaviour
	{
		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 amplitudes;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 frequencies;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 offsets;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 startPosition;

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x126EA84", Offset = "0x126EA84", VA = "0x126EA84")]
		private void Start()
		{
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x126EAC0", Offset = "0x126EAC0", VA = "0x126EAC0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x126EBD0", Offset = "0x126EBD0", VA = "0x126EBD0")]
		public MovingLight()
		{
		}
	}
	[Token(Token = "0x20000E1")]
	public class Rotater : MonoBehaviour
	{
		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float degreesPerSecond;

		[Token(Token = "0x170000A7")]
		public float DegreesPerSecond
		{
			[Token(Token = "0x6000427")]
			[Address(RVA = "0x1715BB0", Offset = "0x1715BB0", VA = "0x1715BB0")]
			set
			{
			}
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x1715BB8", Offset = "0x1715BB8", VA = "0x1715BB8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x1715C10", Offset = "0x1715C10", VA = "0x1715C10")]
		public Rotater()
		{
		}
	}
	[Token(Token = "0x20000E2")]
	public class SpotSwitch : MonoBehaviour
	{
		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject spot1;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject spot2;

		[Token(Token = "0x170000A8")]
		public float SpotCount
		{
			[Token(Token = "0x600042A")]
			[Address(RVA = "0x171F01C", Offset = "0x171F01C", VA = "0x171F01C")]
			set
			{
			}
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x171F078", Offset = "0x171F078", VA = "0x171F078")]
		public SpotSwitch()
		{
		}
	}
	[Token(Token = "0x20000E3")]
	public class Sun : MonoBehaviour
	{
		[Token(Token = "0x170000A9")]
		public float Angle
		{
			[Token(Token = "0x600042C")]
			[Address(RVA = "0x171F488", Offset = "0x171F488", VA = "0x171F488")]
			set
			{
			}
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x171F4E0", Offset = "0x171F4E0", VA = "0x171F4E0")]
		public Sun()
		{
		}
	}
	[Token(Token = "0x20000E4")]
	public class ToggleUI : MonoBehaviour
	{
		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private GameObject panel;

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x172012C", Offset = "0x172012C", VA = "0x172012C")]
		private void Start()
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x172017C", Offset = "0x172017C", VA = "0x172017C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x17201DC", Offset = "0x17201DC", VA = "0x17201DC")]
		public ToggleUI()
		{
		}
	}
	[Token(Token = "0x20000E5")]
	public class Twinkle : MonoBehaviour
	{
		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float frequency;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float offset;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float amplitude;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Material material;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float c1;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float c2;

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x1A796F0", Offset = "0x1A796F0", VA = "0x1A796F0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x1A7977C", Offset = "0x1A7977C", VA = "0x1A7977C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x1A79844", Offset = "0x1A79844", VA = "0x1A79844")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x1A798CC", Offset = "0x1A798CC", VA = "0x1A798CC")]
		public Twinkle()
		{
		}
	}
}
