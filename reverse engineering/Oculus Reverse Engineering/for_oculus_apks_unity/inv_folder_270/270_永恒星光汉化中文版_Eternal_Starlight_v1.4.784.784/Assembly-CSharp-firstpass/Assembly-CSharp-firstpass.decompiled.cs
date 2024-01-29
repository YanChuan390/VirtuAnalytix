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
	[Address(RVA = "0x114F2A8", Offset = "0x114F2A8", VA = "0x114F2A8")]
	public NodeCanvasSceneSave()
	{
	}
}
[Token(Token = "0x2000003")]
[AttributeAttribute(Name = "NodeCanvasTypeAttribute", RVA = "0x69BC50", Offset = "0x69BC50")]
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
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x69E7B0", Offset = "0x69E7B0")]
	public string title;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string subTitle;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "TextAreaAttribute", RVA = "0x69E7E8", Offset = "0x69E7E8")]
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
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x69E800", Offset = "0x69E800")]
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
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x69E838", Offset = "0x69E838")]
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
	[Address(RVA = "0x1503964", Offset = "0x1503964", VA = "0x1503964")]
	public void InitScenario()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x15040E8", Offset = "0x15040E8", VA = "0x15040E8")]
	public ScenarioCanvas()
	{
	}
}
[Token(Token = "0x2000006")]
[AttributeAttribute(Name = "NodeAttribute", RVA = "0x69BC88", Offset = "0x69BC88")]
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
		[Address(RVA = "0x15DCDB0", Offset = "0x15DCDB0", VA = "0x15DCDB0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000002")]
	public override Type GetObjectType
	{
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x15DCDF4", Offset = "0x15DCDF4", VA = "0x15DCDF4", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x15DCE6C", Offset = "0x15DCE6C", VA = "0x15DCE6C", Slot = "5")]
	public override Node Create(Vector2 pos)
	{
		return null;
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x15DCFA8", Offset = "0x15DCFA8", VA = "0x15DCFA8")]
	public AchievementNode()
	{
	}
}
[Token(Token = "0x2000007")]
[AttributeAttribute(Name = "NodeAttribute", RVA = "0x69BD34", Offset = "0x69BD34")]
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
		[Address(RVA = "0x15DE084", Offset = "0x15DE084", VA = "0x15DE084", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000004")]
	public override Type GetObjectType
	{
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x15DE0C8", Offset = "0x15DE0C8", VA = "0x15DE0C8", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x15DE140", Offset = "0x15DE140", VA = "0x15DE140", Slot = "9")]
	public override void CheckSize()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x15DE1F4", Offset = "0x15DE1F4", VA = "0x15DE1F4", Slot = "5")]
	public override Node Create(Vector2 pos)
	{
		return null;
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x15DE360", Offset = "0x15DE360", VA = "0x15DE360")]
	public ScenarioNodeBase GetSuccessNode()
	{
		return null;
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x15DE49C", Offset = "0x15DE49C", VA = "0x15DE49C")]
	public ScenarioNodeBase GetFailureNode()
	{
		return null;
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x15DE5E0", Offset = "0x15DE5E0", VA = "0x15DE5E0", Slot = "6")]
	protected internal override void NodeGUI()
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x15DE5E4", Offset = "0x15DE5E4", VA = "0x15DE5E4")]
	public BeginCombat()
	{
	}
}
[Token(Token = "0x2000009")]
[AttributeAttribute(Name = "NodeAttribute", RVA = "0x69BDE0", Offset = "0x69BDE0")]
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
		[Address(RVA = "0x15E224C", Offset = "0x15E224C", VA = "0x15E224C", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000006")]
	public override Type GetObjectType
	{
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x15E2290", Offset = "0x15E2290", VA = "0x15E2290", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x15E2308", Offset = "0x15E2308", VA = "0x15E2308", Slot = "5")]
	public override Node Create(Vector2 pos)
	{
		return null;
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x15E2444", Offset = "0x15E2444", VA = "0x15E2444")]
	public BridgeLightsNode()
	{
	}
}
[Token(Token = "0x200000A")]
[AttributeAttribute(Name = "NodeAttribute", RVA = "0x69BE8C", Offset = "0x69BE8C")]
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
		[Address(RVA = "0x17E60F0", Offset = "0x17E60F0", VA = "0x17E60F0")]
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
		[Address(RVA = "0x15E4EB4", Offset = "0x15E4EB4", VA = "0x15E4EB4", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000008")]
	public override Type GetObjectType
	{
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x15E4EF8", Offset = "0x15E4EF8", VA = "0x15E4EF8", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x15E4F70", Offset = "0x15E4F70", VA = "0x15E4F70", Slot = "9")]
	public override void CheckSize()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x15E4FEC", Offset = "0x15E4FEC", VA = "0x15E4FEC", Slot = "5")]
	public override Node Create(Vector2 pos)
	{
		return null;
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x15E537C", Offset = "0x15E537C", VA = "0x15E537C", Slot = "6")]
	protected internal override void NodeGUI()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x15E5380", Offset = "0x15E5380", VA = "0x15E5380")]
	public void RemoveLastOption()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x15E51C0", Offset = "0x15E51C0", VA = "0x15E51C0")]
	private void AddNewOption()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x15E54F4", Offset = "0x15E54F4", VA = "0x15E54F4")]
	public NodeOutput AddOption(OptionData option)
	{
		return null;
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x15E55F0", Offset = "0x15E55F0", VA = "0x15E55F0")]
	private void IssueEditorCallBacks()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x15E56B4", Offset = "0x15E56B4", VA = "0x15E56B4")]
	public ScenarioNodeBase GetNodeForChoice(int num)
	{
		return null;
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x15E587C", Offset = "0x15E587C", VA = "0x15E587C")]
	public List<OptionData> GetAllOptions()
	{
		return null;
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x15E58F4", Offset = "0x15E58F4", VA = "0x15E58F4")]
	public List<OptionData> GetRawOptions()
	{
		return null;
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x15E58FC", Offset = "0x15E58FC", VA = "0x15E58FC")]
	public ChoiceNode()
	{
	}
}
[Token(Token = "0x200000D")]
[AttributeAttribute(Name = "NodeAttribute", RVA = "0x69BF38", Offset = "0x69BF38")]
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
		[Address(RVA = "0x1140F40", Offset = "0x1140F40", VA = "0x1140F40", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000A")]
	public override Type GetObjectType
	{
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x1140F84", Offset = "0x1140F84", VA = "0x1140F84", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x1140FFC", Offset = "0x1140FFC", VA = "0x1140FFC", Slot = "9")]
	public override void CheckSize()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x1141078", Offset = "0x1141078", VA = "0x1141078", Slot = "5")]
	public override Node Create(Vector2 pos)
	{
		return null;
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x114113C", Offset = "0x114113C", VA = "0x114113C", Slot = "22")]
	public override bool IsEntity()
	{
		return default(bool);
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x1141144", Offset = "0x1141144", VA = "0x1141144")]
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
[AttributeAttribute(Name = "NodeAttribute", RVA = "0x69BFE4", Offset = "0x69BFE4")]
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
		[Address(RVA = "0x17E7128", Offset = "0x17E7128", VA = "0x17E7128")]
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
		[Address(RVA = "0x1142648", Offset = "0x1142648", VA = "0x1142648", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000C")]
	public override Type GetObjectType
	{
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x114268C", Offset = "0x114268C", VA = "0x114268C", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x1142704", Offset = "0x1142704", VA = "0x1142704", Slot = "5")]
	public override Node Create(Vector2 pos)
	{
		return null;
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x1142A50", Offset = "0x1142A50", VA = "0x1142A50", Slot = "22")]
	public override bool IsEntity()
	{
		return default(bool);
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x1142A58", Offset = "0x1142A58", VA = "0x1142A58")]
	private void RemoveLastShip()
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x11428C0", Offset = "0x11428C0", VA = "0x11428C0")]
	private void AddNewShip()
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x1142B78", Offset = "0x1142B78", VA = "0x1142B78")]
	public List<ShipData> GetShips()
	{
		return null;
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x1142BF0", Offset = "0x1142BF0", VA = "0x1142BF0")]
	public FleetNode()
	{
	}
}
[Token(Token = "0x2000012")]
[AttributeAttribute(Name = "NodeAttribute", RVA = "0x69C090", Offset = "0x69C090")]
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
		[Address(RVA = "0x1144ED0", Offset = "0x1144ED0", VA = "0x1144ED0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000E")]
	public override Type GetObjectType
	{
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x1144F14", Offset = "0x1144F14", VA = "0x1144F14", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x1144F8C", Offset = "0x1144F8C", VA = "0x1144F8C", Slot = "9")]
	public override void CheckSize()
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x1145040", Offset = "0x1145040", VA = "0x1145040", Slot = "5")]
	public override Node Create(Vector2 pos)
	{
		return null;
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x1145178", Offset = "0x1145178", VA = "0x1145178")]
	public GameUnlockNode()
	{
	}
}
[Token(Token = "0x2000013")]
[AttributeAttribute(Name = "NodeAttribute", RVA = "0x69C13C", Offset = "0x69C13C")]
public class JoinFleetNode : ScenarioNodeBase
{
	[Token(Token = "0x4000095")]
	private const string Id = "JoinFleetNode";

	[Token(Token = "0x1700000F")]
	public override string GetID
	{
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x1146E4C", Offset = "0x1146E4C", VA = "0x1146E4C", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000010")]
	public override Type GetObjectType
	{
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x1146E90", Offset = "0x1146E90", VA = "0x1146E90", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x1146F08", Offset = "0x1146F08", VA = "0x1146F08", Slot = "5")]
	public override Node Create(Vector2 pos)
	{
		return null;
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x1147040", Offset = "0x1147040", VA = "0x1147040")]
	public JoinFleetNode()
	{
	}
}
[Token(Token = "0x2000014")]
[AttributeAttribute(Name = "NodeAttribute", RVA = "0x69C1E8", Offset = "0x69C1E8")]
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
		[Address(RVA = "0x1147048", Offset = "0x1147048", VA = "0x1147048", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000012")]
	public override Type GetObjectType
	{
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x114708C", Offset = "0x114708C", VA = "0x114708C", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x1147104", Offset = "0x1147104", VA = "0x1147104", Slot = "5")]
	public override Node Create(Vector2 pos)
	{
		return null;
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x1147270", Offset = "0x1147270", VA = "0x1147270")]
	public KeyConditionNode()
	{
	}
}
[Token(Token = "0x2000016")]
[AttributeAttribute(Name = "NodeAttribute", RVA = "0x69C294", Offset = "0x69C294")]
public class MergeNode : ScenarioNodeBase
{
	[Token(Token = "0x400009F")]
	private const string Id = "MergeNode";

	[Token(Token = "0x17000013")]
	public override string GetID
	{
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x11472CC", Offset = "0x11472CC", VA = "0x11472CC", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000014")]
	public override Type GetObjectType
	{
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x1147310", Offset = "0x1147310", VA = "0x1147310", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x1147388", Offset = "0x1147388", VA = "0x1147388", Slot = "5")]
	public override Node Create(Vector2 pos)
	{
		return null;
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x114754C", Offset = "0x114754C", VA = "0x114754C")]
	public MergeNode()
	{
	}
}
[Token(Token = "0x2000017")]
[AttributeAttribute(Name = "NodeAttribute", RVA = "0x69C340", Offset = "0x69C340")]
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
		[Address(RVA = "0x1147588", Offset = "0x1147588", VA = "0x1147588", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000016")]
	public override Type GetObjectType
	{
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x11475CC", Offset = "0x11475CC", VA = "0x11475CC", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x1147644", Offset = "0x1147644", VA = "0x1147644", Slot = "5")]
	public override Node Create(Vector2 pos)
	{
		return null;
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x114777C", Offset = "0x114777C", VA = "0x114777C", Slot = "22")]
	public override bool IsEntity()
	{
		return default(bool);
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x1147784", Offset = "0x1147784", VA = "0x1147784")]
	public MissionEffect()
	{
	}
}
[Token(Token = "0x2000018")]
[AttributeAttribute(Name = "NodeAttribute", RVA = "0x69C3EC", Offset = "0x69C3EC")]
public class MissionFailTrigger : ScenarioNodeBase
{
	[Token(Token = "0x40000A6")]
	private const string Id = "MissionFailTrigger";

	[Token(Token = "0x17000017")]
	public override string GetID
	{
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x1147A9C", Offset = "0x1147A9C", VA = "0x1147A9C", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000018")]
	public override Type GetObjectType
	{
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x1147AE0", Offset = "0x1147AE0", VA = "0x1147AE0", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x1147B58", Offset = "0x1147B58", VA = "0x1147B58", Slot = "5")]
	public override Node Create(Vector2 pos)
	{
		return null;
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x1147C60", Offset = "0x1147C60", VA = "0x1147C60", Slot = "22")]
	public override bool IsEntity()
	{
		return default(bool);
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x1147C68", Offset = "0x1147C68", VA = "0x1147C68")]
	public MissionFailTrigger()
	{
	}
}
[Token(Token = "0x2000019")]
[AttributeAttribute(Name = "NodeAttribute", RVA = "0x69C498", Offset = "0x69C498")]
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
		[Address(RVA = "0x1147C70", Offset = "0x1147C70", VA = "0x1147C70", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700001A")]
	public override Type GetObjectType
	{
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x1147CB4", Offset = "0x1147CB4", VA = "0x1147CB4", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x1147D2C", Offset = "0x1147D2C", VA = "0x1147D2C", Slot = "5")]
	public override Node Create(Vector2 pos)
	{
		return null;
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x1147E64", Offset = "0x1147E64", VA = "0x1147E64")]
	public MissionKeyConditionNode()
	{
	}
}
[Token(Token = "0x200001B")]
[AttributeAttribute(Name = "NodeAttribute", RVA = "0x69C544", Offset = "0x69C544")]
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
		[Address(RVA = "0x1147EC0", Offset = "0x1147EC0", VA = "0x1147EC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700001C")]
	public override Type GetObjectType
	{
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x1147F04", Offset = "0x1147F04", VA = "0x1147F04", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x1147F7C", Offset = "0x1147F7C", VA = "0x1147F7C", Slot = "5")]
	public override Node Create(Vector2 pos)
	{
		return null;
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x11480B0", Offset = "0x11480B0", VA = "0x11480B0", Slot = "22")]
	public override bool IsEntity()
	{
		return default(bool);
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x11480B8", Offset = "0x11480B8", VA = "0x11480B8")]
	public MissionMessageNode()
	{
	}
}
[Token(Token = "0x200001C")]
[AttributeAttribute(Name = "NodeAttribute", RVA = "0x69C5F0", Offset = "0x69C5F0")]
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
		[Address(RVA = "0x1148144", Offset = "0x1148144", VA = "0x1148144", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700001E")]
	public override Type GetObjectType
	{
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x1148188", Offset = "0x1148188", VA = "0x1148188", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x1148200", Offset = "0x1148200", VA = "0x1148200", Slot = "5")]
	public override Node Create(Vector2 pos)
	{
		return null;
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x1148338", Offset = "0x1148338", VA = "0x1148338")]
	public MissionModifyKeyNode()
	{
	}
}
[Token(Token = "0x200001D")]
[AttributeAttribute(Name = "NodeAttribute", RVA = "0x69C69C", Offset = "0x69C69C")]
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
		[Address(RVA = "0x1148394", Offset = "0x1148394", VA = "0x1148394", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000020")]
	public override Type GetObjectType
	{
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x11483D8", Offset = "0x11483D8", VA = "0x11483D8", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x1148450", Offset = "0x1148450", VA = "0x1148450", Slot = "5")]
	public override Node Create(Vector2 pos)
	{
		return null;
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x114859C", Offset = "0x114859C", VA = "0x114859C", Slot = "22")]
	public override bool IsEntity()
	{
		return default(bool);
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x11485A4", Offset = "0x11485A4", VA = "0x11485A4")]
	public MissionTriggerNode()
	{
	}
}
[Token(Token = "0x200001E")]
[AttributeAttribute(Name = "NodeAttribute", RVA = "0x69C748", Offset = "0x69C748")]
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
		[Address(RVA = "0x114886C", Offset = "0x114886C", VA = "0x114886C", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000022")]
	public override Type GetObjectType
	{
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x11488B0", Offset = "0x11488B0", VA = "0x11488B0", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x1148928", Offset = "0x1148928", VA = "0x1148928", Slot = "5")]
	public override Node Create(Vector2 pos)
	{
		return null;
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x1148AA0", Offset = "0x1148AA0", VA = "0x1148AA0")]
	public ModifyFleet()
	{
	}
}
[Token(Token = "0x200001F")]
[AttributeAttribute(Name = "NodeAttribute", RVA = "0x69C7F4", Offset = "0x69C7F4")]
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
		[Address(RVA = "0x1148C04", Offset = "0x1148C04", VA = "0x1148C04", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000024")]
	public override Type GetObjectType
	{
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x1148C48", Offset = "0x1148C48", VA = "0x1148C48", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x1148CC0", Offset = "0x1148CC0", VA = "0x1148CC0", Slot = "5")]
	public override Node Create(Vector2 pos)
	{
		return null;
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x1148DF8", Offset = "0x1148DF8", VA = "0x1148DF8")]
	public ModifyKeyNode()
	{
	}
}
[Token(Token = "0x2000020")]
[AttributeAttribute(Name = "NodeAttribute", RVA = "0x69C8A0", Offset = "0x69C8A0")]
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
		[Address(RVA = "0x1148E60", Offset = "0x1148E60", VA = "0x1148E60", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000026")]
	public override Type GetObjectType
	{
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x1148EA4", Offset = "0x1148EA4", VA = "0x1148EA4", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x1148F1C", Offset = "0x1148F1C", VA = "0x1148F1C", Slot = "5")]
	public override Node Create(Vector2 pos)
	{
		return null;
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x1149054", Offset = "0x1149054", VA = "0x1149054")]
	public ModifyResources()
	{
	}
}
[Token(Token = "0x2000021")]
[AttributeAttribute(Name = "NodeAttribute", RVA = "0x69C94C", Offset = "0x69C94C")]
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
		[Address(RVA = "0x1149064", Offset = "0x1149064", VA = "0x1149064", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000028")]
	public override Type GetObjectType
	{
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x11490A8", Offset = "0x11490A8", VA = "0x11490A8", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x1149120", Offset = "0x1149120", VA = "0x1149120", Slot = "5")]
	public override Node Create(Vector2 pos)
	{
		return null;
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x1149258", Offset = "0x1149258", VA = "0x1149258")]
	public ModifyRunNode()
	{
	}
}
[Token(Token = "0x2000023")]
[AttributeAttribute(Name = "NodeAttribute", RVA = "0x69C9F8", Offset = "0x69C9F8")]
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
		[Address(RVA = "0x1149268", Offset = "0x1149268", VA = "0x1149268", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700002A")]
	public override Type GetObjectType
	{
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x11492AC", Offset = "0x11492AC", VA = "0x11492AC", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x1149324", Offset = "0x1149324", VA = "0x1149324", Slot = "5")]
	public override Node Create(Vector2 pos)
	{
		return null;
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x114945C", Offset = "0x114945C", VA = "0x114945C")]
	public ModifyScore()
	{
	}
}
[Token(Token = "0x2000024")]
[AttributeAttribute(Name = "NodeAttribute", RVA = "0x69CAA4", Offset = "0x69CAA4")]
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
		[Address(RVA = "0x1149EA0", Offset = "0x1149EA0", VA = "0x1149EA0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700002C")]
	public override Type GetObjectType
	{
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x1149EE4", Offset = "0x1149EE4", VA = "0x1149EE4", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x1149F5C", Offset = "0x1149F5C", VA = "0x1149F5C", Slot = "5")]
	public override Node Create(Vector2 pos)
	{
		return null;
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x114A1CC", Offset = "0x114A1CC", VA = "0x114A1CC", Slot = "22")]
	public override bool IsEntity()
	{
		return default(bool);
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x114A1D4", Offset = "0x114A1D4", VA = "0x114A1D4")]
	public NavPointNode()
	{
	}
}
[Token(Token = "0x2000025")]
[AttributeAttribute(Name = "NodeAttribute", RVA = "0x69CB50", Offset = "0x69CB50")]
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
		[Address(RVA = "0x14F78A8", Offset = "0x14F78A8", VA = "0x14F78A8", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700002E")]
	public override Type GetObjectType
	{
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x14F78EC", Offset = "0x14F78EC", VA = "0x14F78EC", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x14F7964", Offset = "0x14F7964", VA = "0x14F7964", Slot = "5")]
	public override Node Create(Vector2 pos)
	{
		return null;
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x14F7AA0", Offset = "0x14F7AA0", VA = "0x14F7AA0")]
	public PlayMusicNode()
	{
	}
}
[Token(Token = "0x2000026")]
[AttributeAttribute(Name = "NodeAttribute", RVA = "0x69CBFC", Offset = "0x69CBFC")]
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
		[Address(RVA = "0x1500C24", Offset = "0x1500C24", VA = "0x1500C24", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000030")]
	public override Type GetObjectType
	{
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x1500C68", Offset = "0x1500C68", VA = "0x1500C68", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x1500CE0", Offset = "0x1500CE0", VA = "0x1500CE0", Slot = "5")]
	public override Node Create(Vector2 pos)
	{
		return null;
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x1500E4C", Offset = "0x1500E4C", VA = "0x1500E4C", Slot = "23")]
	public new virtual ScenarioNodeBase GetNextNode()
	{
		return null;
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x1501034", Offset = "0x1501034", VA = "0x1501034")]
	public RandomChance()
	{
	}
}
[Token(Token = "0x2000027")]
[AttributeAttribute(Name = "NodeAttribute", RVA = "0x69CCA8", Offset = "0x69CCA8")]
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
		[Address(RVA = "0x15021E0", Offset = "0x15021E0", VA = "0x15021E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000032")]
	public override Type GetObjectType
	{
		[Token(Token = "0x6000083")]
		[Address(RVA = "0x1502224", Offset = "0x1502224", VA = "0x1502224", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x150229C", Offset = "0x150229C", VA = "0x150229C", Slot = "5")]
	public override Node Create(Vector2 pos)
	{
		return null;
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x15023D8", Offset = "0x15023D8", VA = "0x15023D8")]
	public RewardNode()
	{
	}
}
[Token(Token = "0x2000029")]
[AttributeAttribute(Name = "NodeAttribute", RVA = "0x69CD54", Offset = "0x69CD54")]
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
		[Address(RVA = "0x150A0EC", Offset = "0x150A0EC", VA = "0x150A0EC", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000034")]
	public override Type GetObjectType
	{
		[Token(Token = "0x6000087")]
		[Address(RVA = "0x150A130", Offset = "0x150A130", VA = "0x150A130", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x150A1A8", Offset = "0x150A1A8", VA = "0x150A1A8", Slot = "5")]
	public override Node Create(Vector2 pos)
	{
		return null;
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x150A2B0", Offset = "0x150A2B0", VA = "0x150A2B0")]
	public ScenarioEndNode()
	{
	}
}
[Token(Token = "0x200002A")]
[AttributeAttribute(Name = "NodeAttribute", RVA = "0x69CE00", Offset = "0x69CE00")]
public abstract class ScenarioNodeBase : Node
{
	[Token(Token = "0x40000F4")]
	private const string Id = "Base";

	[Token(Token = "0x17000035")]
	public override bool AllowRecursion
	{
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x150A710", Offset = "0x150A710", VA = "0x150A710", Slot = "10")]
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
		[Address(RVA = "0x150A718", Offset = "0x150A718", VA = "0x150A718", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x150A75C", Offset = "0x150A75C", VA = "0x150A75C", Slot = "21")]
	public virtual ScenarioNodeBase GetNextNode()
	{
		return null;
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x150A898", Offset = "0x150A898", VA = "0x150A898", Slot = "22")]
	public virtual bool IsEntity()
	{
		return default(bool);
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x150A8A0", Offset = "0x150A8A0", VA = "0x150A8A0", Slot = "6")]
	protected internal override void NodeGUI()
	{
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x14F7AA8", Offset = "0x14F7AA8", VA = "0x14F7AA8")]
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
		[Address(RVA = "0x150A5BC", Offset = "0x150A5BC", VA = "0x150A5BC", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000039")]
	public Type Type
	{
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x150A600", Offset = "0x150A600", VA = "0x150A600", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700003A")]
	public Color Color
	{
		[Token(Token = "0x6000093")]
		[Address(RVA = "0x150A678", Offset = "0x150A678", VA = "0x150A678", Slot = "6")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x1700003B")]
	public string InKnobTex
	{
		[Token(Token = "0x6000094")]
		[Address(RVA = "0x150A680", Offset = "0x150A680", VA = "0x150A680", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700003C")]
	public string OutKnobTex
	{
		[Token(Token = "0x6000095")]
		[Address(RVA = "0x150A6C4", Offset = "0x150A6C4", VA = "0x150A6C4", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x150A708", Offset = "0x150A708", VA = "0x150A708")]
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
		[Address(RVA = "0x150A8A4", Offset = "0x150A8A4", VA = "0x150A8A4", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700003E")]
	public Type Type
	{
		[Token(Token = "0x6000098")]
		[Address(RVA = "0x150A8E8", Offset = "0x150A8E8", VA = "0x150A8E8", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700003F")]
	public Color Color
	{
		[Token(Token = "0x6000099")]
		[Address(RVA = "0x150A960", Offset = "0x150A960", VA = "0x150A960", Slot = "6")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x17000040")]
	public string InKnobTex
	{
		[Token(Token = "0x600009A")]
		[Address(RVA = "0x150A968", Offset = "0x150A968", VA = "0x150A968", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000041")]
	public string OutKnobTex
	{
		[Token(Token = "0x600009B")]
		[Address(RVA = "0x150A9AC", Offset = "0x150A9AC", VA = "0x150A9AC", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x150A9F0", Offset = "0x150A9F0", VA = "0x150A9F0")]
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
		[Address(RVA = "0x150A314", Offset = "0x150A314", VA = "0x150A314", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000043")]
	public Type Type
	{
		[Token(Token = "0x600009E")]
		[Address(RVA = "0x150A358", Offset = "0x150A358", VA = "0x150A358", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000044")]
	public Color Color
	{
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x150A3D0", Offset = "0x150A3D0", VA = "0x150A3D0", Slot = "6")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x17000045")]
	public string InKnobTex
	{
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x150A3D8", Offset = "0x150A3D8", VA = "0x150A3D8", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000046")]
	public string OutKnobTex
	{
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x150A41C", Offset = "0x150A41C", VA = "0x150A41C", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x150A460", Offset = "0x150A460", VA = "0x150A460")]
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
		[Address(RVA = "0x150A468", Offset = "0x150A468", VA = "0x150A468", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000048")]
	public Type Type
	{
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x150A4AC", Offset = "0x150A4AC", VA = "0x150A4AC", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000049")]
	public Color Color
	{
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x150A524", Offset = "0x150A524", VA = "0x150A524", Slot = "6")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x1700004A")]
	public string InKnobTex
	{
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x150A52C", Offset = "0x150A52C", VA = "0x150A52C", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700004B")]
	public string OutKnobTex
	{
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x150A570", Offset = "0x150A570", VA = "0x150A570", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x150A5B4", Offset = "0x150A5B4", VA = "0x150A5B4")]
	public ScenarioMissionEffectType()
	{
	}
}
[Token(Token = "0x200002F")]
[AttributeAttribute(Name = "NodeAttribute", RVA = "0x69CEAC", Offset = "0x69CEAC")]
public class ScenarioStartNode : ScenarioNodeBase
{
	[Token(Token = "0x40000F5")]
	private const string Id = "ScenarioStartNode";

	[Token(Token = "0x1700004C")]
	public override string GetID
	{
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x150A9F8", Offset = "0x150A9F8", VA = "0x150A9F8", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700004D")]
	public override Type GetObjectType
	{
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x150AA3C", Offset = "0x150AA3C", VA = "0x150AA3C", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x150AAB4", Offset = "0x150AAB4", VA = "0x150AAB4", Slot = "5")]
	public override Node Create(Vector2 pos)
	{
		return null;
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x150ABB8", Offset = "0x150ABB8", VA = "0x150ABB8")]
	public ScenarioStartNode()
	{
	}
}
[Token(Token = "0x2000030")]
[AttributeAttribute(Name = "NodeAttribute", RVA = "0x69CF58", Offset = "0x69CF58")]
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
		[Address(RVA = "0x150AE5C", Offset = "0x150AE5C", VA = "0x150AE5C", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700004F")]
	public override Type GetObjectType
	{
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x150AEA0", Offset = "0x150AEA0", VA = "0x150AEA0", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x150AF18", Offset = "0x150AF18", VA = "0x150AF18", Slot = "5")]
	public override Node Create(Vector2 pos)
	{
		return null;
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x150B050", Offset = "0x150B050", VA = "0x150B050")]
	public ShipInfoNode()
	{
	}
}
[Token(Token = "0x2000031")]
[AttributeAttribute(Name = "NodeAttribute", RVA = "0x69D004", Offset = "0x69D004")]
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
		[Address(RVA = "0x150B058", Offset = "0x150B058", VA = "0x150B058", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000051")]
	public override Type GetObjectType
	{
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x150B09C", Offset = "0x150B09C", VA = "0x150B09C", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x150B114", Offset = "0x150B114", VA = "0x150B114", Slot = "5")]
	public override Node Create(Vector2 pos)
	{
		return null;
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x150B24C", Offset = "0x150B24C", VA = "0x150B24C")]
	public ShipRewardNode()
	{
	}
}
[Token(Token = "0x2000032")]
[AttributeAttribute(Name = "NodeAttribute", RVA = "0x69D0B0", Offset = "0x69D0B0")]
public class ShipSlotUnlockNode : ScenarioNodeBase
{
	[Token(Token = "0x4000100")]
	private const string Id = "ShipSlotUnlockNode";

	[Token(Token = "0x17000052")]
	public override string GetID
	{
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x150B254", Offset = "0x150B254", VA = "0x150B254", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000053")]
	public override Type GetObjectType
	{
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x150B298", Offset = "0x150B298", VA = "0x150B298", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x150B310", Offset = "0x150B310", VA = "0x150B310", Slot = "5")]
	public override Node Create(Vector2 pos)
	{
		return null;
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x150B44C", Offset = "0x150B44C", VA = "0x150B44C")]
	public ShipSlotUnlockNode()
	{
	}
}
[Token(Token = "0x2000033")]
[AttributeAttribute(Name = "NodeAttribute", RVA = "0x69D15C", Offset = "0x69D15C")]
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
		[Address(RVA = "0x150B5F8", Offset = "0x150B5F8", VA = "0x150B5F8", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000055")]
	public override Type GetObjectType
	{
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x150B63C", Offset = "0x150B63C", VA = "0x150B63C", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x150B6B4", Offset = "0x150B6B4", VA = "0x150B6B4", Slot = "5")]
	public override Node Create(Vector2 pos)
	{
		return null;
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x150B7F0", Offset = "0x150B7F0", VA = "0x150B7F0")]
	public SpecificRewardNode()
	{
	}
}
[Token(Token = "0x2000034")]
[AttributeAttribute(Name = "NodeAttribute", RVA = "0x69D208", Offset = "0x69D208")]
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
		[Address(RVA = "0x150B8B0", Offset = "0x150B8B0", VA = "0x150B8B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000057")]
	public override Type GetObjectType
	{
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x150B8F4", Offset = "0x150B8F4", VA = "0x150B8F4", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x150B96C", Offset = "0x150B96C", VA = "0x150B96C", Slot = "5")]
	public override Node Create(Vector2 pos)
	{
		return null;
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x150BAA8", Offset = "0x150BAA8", VA = "0x150BAA8")]
	public StoreNode()
	{
	}
}
[Token(Token = "0x2000036")]
[AttributeAttribute(Name = "NodeAttribute", RVA = "0x69D2B4", Offset = "0x69D2B4")]
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
		[Address(RVA = "0x150BAB8", Offset = "0x150BAB8", VA = "0x150BAB8", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000059")]
	public override Type GetObjectType
	{
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x150BAFC", Offset = "0x150BAFC", VA = "0x150BAFC", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x150BB74", Offset = "0x150BB74", VA = "0x150BB74", Slot = "5")]
	public override Node Create(Vector2 pos)
	{
		return null;
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x150BCB0", Offset = "0x150BCB0", VA = "0x150BCB0")]
	public StoreShipUnlockNode()
	{
	}
}
[Token(Token = "0x2000037")]
[ExecuteInEditMode]
public class VDColorHandler : VDColorHandlerBase
{
	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x17E3148", Offset = "0x17E3148", VA = "0x17E3148")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x17E34F4", Offset = "0x17E34F4", VA = "0x17E34F4")]
	private void Update()
	{
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x17E3538", Offset = "0x17E3538", VA = "0x17E3538")]
	public void SetColors()
	{
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x17E321C", Offset = "0x17E321C", VA = "0x17E321C")]
	public void SetMesh()
	{
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x17E3604", Offset = "0x17E3604", VA = "0x17E3604")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x17E3670", Offset = "0x17E3670", VA = "0x17E3670")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x17E379C", Offset = "0x17E379C", VA = "0x17E379C")]
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
	[Address(RVA = "0x17E37A0", Offset = "0x17E37A0", VA = "0x17E37A0")]
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
	[Address(RVA = "0x17E3824", Offset = "0x17E3824", VA = "0x17E3824")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x17E38D8", Offset = "0x17E38D8", VA = "0x17E38D8")]
	private void OnPostRender()
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x17E3AC4", Offset = "0x17E3AC4", VA = "0x17E3AC4")]
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
	[Address(RVA = "0x17E5578", Offset = "0x17E5578", VA = "0x17E5578")]
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
	[Address(RVA = "0x17E3ACC", Offset = "0x17E3ACC", VA = "0x17E3ACC")]
	public static void Dirt(Transform[] sels)
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x17E420C", Offset = "0x17E420C", VA = "0x17E420C")]
	public static void UpdateShaderVariables()
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x17E43B0", Offset = "0x17E43B0", VA = "0x17E43B0")]
	private static void PrepareVertices(Transform go)
	{
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x17E4828", Offset = "0x17E4828", VA = "0x17E4828")]
	public static void PrepareColors()
	{
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x17E48C8", Offset = "0x17E48C8", VA = "0x17E48C8")]
	private static void SmoothVertices()
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x17E4CE0", Offset = "0x17E4CE0", VA = "0x17E4CE0")]
	private static void CalcColors(GameObject camGO, Camera cam)
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x17E39F0", Offset = "0x17E39F0", VA = "0x17E39F0")]
	public static void SetColorSample(Color32 c)
	{
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x17E5400", Offset = "0x17E5400", VA = "0x17E5400")]
	public static Color ColorAndLuminance(Color c)
	{
		return default(Color);
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x17E5430", Offset = "0x17E5430", VA = "0x17E5430")]
	public static Color32 MultiplyColor32(Color c0, Color c1)
	{
		return default(Color32);
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x17E5088", Offset = "0x17E5088", VA = "0x17E5088")]
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
	[Address(RVA = "0x17E5528", Offset = "0x17E5528", VA = "0x17E5528")]
	public VertexSample()
	{
	}
}
namespace UnityStandardAssets.Utility
{
	[Token(Token = "0x200003D")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x69D380", Offset = "0x69D380")]
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
		[Address(RVA = "0x114205C", Offset = "0x114205C", VA = "0x114205C")]
		private void Start()
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x11420CC", Offset = "0x11420CC", VA = "0x11420CC")]
		private void Update()
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x11421D0", Offset = "0x11421D0", VA = "0x11421D0")]
		public FPSCounter()
		{
		}
	}
}
namespace UnityStandardAssets.Effects
{
	[Token(Token = "0x200003E")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x69D3E0", Offset = "0x69D3E0")]
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
		[Address(RVA = "0x15DCFB0", Offset = "0x15DCFB0", VA = "0x15DCFB0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x15DD054", Offset = "0x15DD054", VA = "0x15DD054")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x15DD460", Offset = "0x15DD460", VA = "0x15DD460")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x15DD8E8", Offset = "0x15DD8E8", VA = "0x15DD8E8")]
		public AfterburnerPhysicsForce()
		{
		}
	}
	[Token(Token = "0x200003F")]
	public class ExplosionFireAndDebris : MonoBehaviour
	{
		[Token(Token = "0x2000040")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69D440", Offset = "0x69D440")]
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
				[Address(RVA = "0x17E69D4", Offset = "0x17E69D4", VA = "0x17E69D4", Slot = "4")]
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
				[Address(RVA = "0x17E6A1C", Offset = "0x17E6A1C", VA = "0x17E6A1C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000E7")]
			[Address(RVA = "0x17E647C", Offset = "0x17E647C", VA = "0x17E647C")]
			[DebuggerHidden]
			public <Start>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x60000E8")]
			[Address(RVA = "0x17E64A8", Offset = "0x17E64A8", VA = "0x17E64A8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000E9")]
			[Address(RVA = "0x17E64AC", Offset = "0x17E64AC", VA = "0x17E64AC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000EB")]
			[Address(RVA = "0x17E69DC", Offset = "0x17E69DC", VA = "0x17E69DC", Slot = "8")]
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
		[Address(RVA = "0x1141C74", Offset = "0x1141C74", VA = "0x1141C74")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x69EF64", Offset = "0x69EF64")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x1141CEC", Offset = "0x1141CEC", VA = "0x1141CEC")]
		private void AddFire(Transform t, Vector3 pos, Vector3 normal)
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x1141E10", Offset = "0x1141E10", VA = "0x1141E10")]
		public ExplosionFireAndDebris()
		{
		}
	}
	[Token(Token = "0x2000041")]
	public class ExplosionPhysicsForce : MonoBehaviour
	{
		[Token(Token = "0x2000042")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69D450", Offset = "0x69D450")]
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
				[Address(RVA = "0x17E6DD4", Offset = "0x17E6DD4", VA = "0x17E6DD4", Slot = "4")]
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
				[Address(RVA = "0x17E6E1C", Offset = "0x17E6E1C", VA = "0x17E6E1C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000EF")]
			[Address(RVA = "0x17E6A24", Offset = "0x17E6A24", VA = "0x17E6A24")]
			[DebuggerHidden]
			public <Start>d__1(int <>1__state)
			{
			}

			[Token(Token = "0x60000F0")]
			[Address(RVA = "0x17E6A50", Offset = "0x17E6A50", VA = "0x17E6A50", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000F1")]
			[Address(RVA = "0x17E6A54", Offset = "0x17E6A54", VA = "0x17E6A54", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000F3")]
			[Address(RVA = "0x17E6DDC", Offset = "0x17E6DDC", VA = "0x17E6DDC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float explosionForce;

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x1141E18", Offset = "0x1141E18", VA = "0x1141E18")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x69F014", Offset = "0x69F014")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x1141E90", Offset = "0x1141E90", VA = "0x1141E90")]
		public ExplosionPhysicsForce()
		{
		}
	}
	[Token(Token = "0x2000043")]
	public class Explosive : MonoBehaviour
	{
		[Token(Token = "0x2000044")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69D460", Offset = "0x69D460")]
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
				[Address(RVA = "0x17E70D8", Offset = "0x17E70D8", VA = "0x17E70D8", Slot = "4")]
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
				[Address(RVA = "0x17E7120", Offset = "0x17E7120", VA = "0x17E7120", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000F9")]
			[Address(RVA = "0x17E6E24", Offset = "0x17E6E24", VA = "0x17E6E24")]
			[DebuggerHidden]
			public <OnCollisionEnter>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x60000FA")]
			[Address(RVA = "0x17E6E50", Offset = "0x17E6E50", VA = "0x17E6E50", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000FB")]
			[Address(RVA = "0x17E6E54", Offset = "0x17E6E54", VA = "0x17E6E54", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000FD")]
			[Address(RVA = "0x17E70E0", Offset = "0x17E70E0", VA = "0x17E70E0", Slot = "8")]
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
		[Address(RVA = "0x1141EA0", Offset = "0x1141EA0", VA = "0x1141EA0")]
		private void Start()
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x1141EA4", Offset = "0x1141EA4", VA = "0x1141EA4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x69F0C4", Offset = "0x69F0C4")]
		private IEnumerator OnCollisionEnter(Collision col)
		{
			return null;
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x1141F38", Offset = "0x1141F38", VA = "0x1141F38")]
		public void Reset()
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x1141F40", Offset = "0x1141F40", VA = "0x1141F40")]
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
		[Address(RVA = "0x1141F64", Offset = "0x1141F64", VA = "0x1141F64")]
		private void Start()
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x1141FC0", Offset = "0x1141FC0", VA = "0x1141FC0")]
		public void Extinguish()
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x114204C", Offset = "0x114204C", VA = "0x114204C")]
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
		[Address(RVA = "0x11421D8", Offset = "0x11421D8", VA = "0x11421D8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x114224C", Offset = "0x114224C", VA = "0x114224C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x1142408", Offset = "0x1142408", VA = "0x1142408")]
		public void Extinguish()
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x1142430", Offset = "0x1142430", VA = "0x1142430")]
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
		[Address(RVA = "0x1145D9C", Offset = "0x1145D9C", VA = "0x1145D9C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x1145F18", Offset = "0x1145F18", VA = "0x1145F18")]
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
		[Address(RVA = "0x14F7770", Offset = "0x14F7770", VA = "0x14F7770")]
		private void Start()
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x14F7898", Offset = "0x14F7898", VA = "0x14F7898")]
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
		[Address(RVA = "0x150B534", Offset = "0x150B534", VA = "0x150B534")]
		private void Start()
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x150B5F0", Offset = "0x150B5F0", VA = "0x150B5F0")]
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
		[Address(RVA = "0x17E5D94", Offset = "0x17E5D94", VA = "0x17E5D94")]
		private void Start()
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x17E5DF0", Offset = "0x17E5DF0", VA = "0x17E5DF0")]
		private void OnParticleCollision(GameObject other)
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x17E6064", Offset = "0x17E6064", VA = "0x17E6064")]
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
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x69D470", Offset = "0x69D470")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x69D470", Offset = "0x69D470")]
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
		[Address(RVA = "0x15DD8FC", Offset = "0x15DD8FC", VA = "0x15DD8FC")]
		public Material CurrentAAMaterial()
		{
			return null;
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x15DD960", Offset = "0x15DD960", VA = "0x15DD960", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x15DDAD4", Offset = "0x15DDAD4", VA = "0x15DDAD4")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x15DE060", Offset = "0x15DE060", VA = "0x15DE060")]
		public Antialiasing()
		{
		}
	}
	[Token(Token = "0x200004D")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x69D504", Offset = "0x69D504")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x69D504", Offset = "0x69D504")]
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
		[Address(RVA = "0x15DE604", Offset = "0x15DE604", VA = "0x15DE604", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x15DE6F4", Offset = "0x15DE6F4", VA = "0x15DE6F4")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x15DFBA4", Offset = "0x15DFBA4", VA = "0x15DFBA4")]
		private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x15DF924", Offset = "0x15DF924", VA = "0x15DF924")]
		private void BlendFlares(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x15DF610", Offset = "0x15DF610", VA = "0x15DF610")]
		private void BrightFilter(float thresh, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x15DF524", Offset = "0x15DF524", VA = "0x15DF524")]
		private void BrightFilter(Color threshColor, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x15DF704", Offset = "0x15DF704", VA = "0x15DF704")]
		private void Vignette(float amount, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x15DFC74", Offset = "0x15DFC74", VA = "0x15DFC74")]
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
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x69D598", Offset = "0x69D598")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x69D598", Offset = "0x69D598")]
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
		[Address(RVA = "0x15DFDB4", Offset = "0x15DFDB4", VA = "0x15DFDB4", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x15DFF14", Offset = "0x15DFF14", VA = "0x15DFF14")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x15E0F80", Offset = "0x15E0F80", VA = "0x15E0F80")]
		private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x15E0D10", Offset = "0x15E0D10", VA = "0x15E0D10")]
		private void BlendFlares(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x15E0A60", Offset = "0x15E0A60", VA = "0x15E0A60")]
		private void BrightFilter(float thresh, float useAlphaAsMask, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x15E0B9C", Offset = "0x15E0B9C", VA = "0x15E0B9C")]
		private void Vignette(float amount, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x15E103C", Offset = "0x15E103C", VA = "0x15E103C")]
		public BloomAndFlares()
		{
		}
	}
	[Token(Token = "0x2000058")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x69D62C", Offset = "0x69D62C")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x69D62C", Offset = "0x69D62C")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x69E8C0", Offset = "0x69E8C0")]
		public float threshold;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x69E8D8", Offset = "0x69E8D8")]
		public float intensity;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x69E8F0", Offset = "0x69E8F0")]
		public float blurSize;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Resolution resolution;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x69E908", Offset = "0x69E908")]
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
		[Address(RVA = "0x15E116C", Offset = "0x15E116C", VA = "0x15E116C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x15E11E4", Offset = "0x15E11E4", VA = "0x15E11E4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x15E1290", Offset = "0x15E1290", VA = "0x15E1290")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x15E1670", Offset = "0x15E1670", VA = "0x15E1670")]
		public BloomOptimized()
		{
		}
	}
	[Token(Token = "0x200005B")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x69D6C0", Offset = "0x69D6C0")]
	[ExecuteInEditMode]
	public class Blur : MonoBehaviour
	{
		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x69E920", Offset = "0x69E920")]
		public int iterations;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x69E938", Offset = "0x69E938")]
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
			[Address(RVA = "0x15E1694", Offset = "0x15E1694", VA = "0x15E1694")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x15E17E8", Offset = "0x15E17E8", VA = "0x15E17E8")]
		protected void OnDisable()
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x15E18EC", Offset = "0x15E18EC", VA = "0x15E18EC")]
		protected void Start()
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x15E19A8", Offset = "0x15E19A8", VA = "0x15E19A8")]
		public void FourTapCone(RenderTexture source, RenderTexture dest, int iteration)
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x15E1ACC", Offset = "0x15E1ACC", VA = "0x15E1ACC")]
		private void DownSample4x(RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x15E1BDC", Offset = "0x15E1BDC", VA = "0x15E1BDC")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x15E1D44", Offset = "0x15E1D44", VA = "0x15E1D44")]
		public Blur()
		{
		}
	}
	[Token(Token = "0x200005C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x69D70C", Offset = "0x69D70C")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x69D70C", Offset = "0x69D70C")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x69E950", Offset = "0x69E950")]
		public int downsample;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x69E968", Offset = "0x69E968")]
		public float blurSize;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x69E980", Offset = "0x69E980")]
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
		[Address(RVA = "0x15E1D60", Offset = "0x15E1D60", VA = "0x15E1D60", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x15E1DD8", Offset = "0x15E1DD8", VA = "0x15E1DD8")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x15E1E84", Offset = "0x15E1E84", VA = "0x15E1E84")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x15E2230", Offset = "0x15E2230", VA = "0x15E2230")]
		public BlurOptimized()
		{
		}
	}
	[Token(Token = "0x200005E")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x69D7A0", Offset = "0x69D7A0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x69D7A0", Offset = "0x69D7A0")]
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
		[Address(RVA = "0x15E2860", Offset = "0x15E2860", VA = "0x15E2860")]
		private void CalculateViewProjection()
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x15E2ABC", Offset = "0x15E2ABC", VA = "0x15E2ABC")]
		private new void Start()
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x15E2D54", Offset = "0x15E2D54", VA = "0x15E2D54")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x15E2E28", Offset = "0x15E2E28", VA = "0x15E2E28")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x15E2FC0", Offset = "0x15E2FC0", VA = "0x15E2FC0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x15E3078", Offset = "0x15E3078", VA = "0x15E3078")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x15E2BF8", Offset = "0x15E2BF8", VA = "0x15E2BF8")]
		private void Remember()
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x15E49F8", Offset = "0x15E49F8", VA = "0x15E49F8")]
		private Camera GetTmpCam()
		{
			return null;
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x15E4968", Offset = "0x15E4968", VA = "0x15E4968")]
		private void StartFrame()
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x15E49E8", Offset = "0x15E49E8", VA = "0x15E49E8")]
		private static int divRoundUp(int x, int d)
		{
			return default(int);
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x15E4DAC", Offset = "0x15E4DAC", VA = "0x15E4DAC")]
		public CameraMotionBlur()
		{
		}
	}
	[Token(Token = "0x2000060")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x69D834", Offset = "0x69D834")]
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
		[Address(RVA = "0x15E59E4", Offset = "0x15E59E4", VA = "0x15E59E4")]
		private new void Start()
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x15E5A10", Offset = "0x15E5A10", VA = "0x15E5A10")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x15E5A14", Offset = "0x15E5A14", VA = "0x15E5A14", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x15E5CF8", Offset = "0x15E5CF8", VA = "0x15E5CF8")]
		public void UpdateParameters()
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x15E60B8", Offset = "0x15E60B8", VA = "0x15E60B8")]
		private void UpdateTextures()
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x15E60BC", Offset = "0x15E60BC", VA = "0x15E60BC")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x15E6408", Offset = "0x15E6408", VA = "0x15E6408")]
		public ColorCorrectionCurves()
		{
		}
	}
	[Token(Token = "0x2000062")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x69D880", Offset = "0x69D880")]
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
		[Address(RVA = "0x15E6A98", Offset = "0x15E6A98", VA = "0x15E6A98", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x15E6B0C", Offset = "0x15E6B0C", VA = "0x15E6B0C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x15E6BC8", Offset = "0x15E6BC8", VA = "0x15E6BC8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x15E6C74", Offset = "0x15E6C74", VA = "0x15E6C74")]
		public void SetIdentityLut()
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x15E6EA8", Offset = "0x15E6EA8", VA = "0x15E6EA8")]
		public bool ValidDimensions(Texture2D tex2d)
		{
			return default(bool);
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x15E6F70", Offset = "0x15E6F70", VA = "0x15E6F70")]
		public void Convert(Texture2D temp2DTex, string path)
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x15E72F4", Offset = "0x15E72F4", VA = "0x15E72F4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x15E750C", Offset = "0x15E750C", VA = "0x15E750C")]
		public ColorCorrectionLookup()
		{
		}
	}
	[Token(Token = "0x2000063")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x69D8CC", Offset = "0x69D8CC")]
	[ExecuteInEditMode]
	public class ColorCorrectionRamp : ImageEffectBase
	{
		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Texture textureRamp;

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x15E7568", Offset = "0x15E7568", VA = "0x15E7568")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x15E7630", Offset = "0x15E7630", VA = "0x15E7630")]
		public ColorCorrectionRamp()
		{
		}
	}
	[Token(Token = "0x2000064")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x69D918", Offset = "0x69D918")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x69D918", Offset = "0x69D918")]
	public class ContrastEnhance : PostEffectsBase
	{
		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x69E998", Offset = "0x69E998")]
		public float intensity;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x69E9B0", Offset = "0x69E9B0")]
		public float threshold;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Material separableBlurMaterial;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Material contrastCompositeMaterial;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x69E9CC", Offset = "0x69E9CC")]
		public float blurSpread;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader separableBlurShader;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Shader contrastCompositeShader;

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x15E8D84", Offset = "0x15E8D84", VA = "0x15E8D84", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x15E8E24", Offset = "0x15E8E24", VA = "0x15E8E24")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x15E91B8", Offset = "0x15E91B8", VA = "0x15E91B8")]
		public ContrastEnhance()
		{
		}
	}
	[Token(Token = "0x2000065")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x69D9AC", Offset = "0x69D9AC")]
	public class ContrastStretch : MonoBehaviour
	{
		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x69E9E4", Offset = "0x69E9E4")]
		public float adaptationSpeed;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x69EA00", Offset = "0x69EA00")]
		public float limitMinimum;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x69EA18", Offset = "0x69EA18")]
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
			[Address(RVA = "0x15E91D0", Offset = "0x15E91D0", VA = "0x15E91D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000062")]
		protected Material materialReduce
		{
			[Token(Token = "0x6000153")]
			[Address(RVA = "0x15E92AC", Offset = "0x15E92AC", VA = "0x15E92AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000063")]
		protected Material materialAdapt
		{
			[Token(Token = "0x6000154")]
			[Address(RVA = "0x15E9388", Offset = "0x15E9388", VA = "0x15E9388")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000064")]
		protected Material materialApply
		{
			[Token(Token = "0x6000155")]
			[Address(RVA = "0x15E9464", Offset = "0x15E9464", VA = "0x15E9464")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x15E9540", Offset = "0x15E9540", VA = "0x15E9540")]
		private void Start()
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x15E95D4", Offset = "0x15E95D4", VA = "0x15E95D4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x15E9734", Offset = "0x15E9734", VA = "0x15E9734")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x15E9960", Offset = "0x15E9960", VA = "0x15E9960")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x15E9BC4", Offset = "0x15E9BC4", VA = "0x15E9BC4")]
		private void CalculateAdaptation(Texture curTexture)
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x15E9DC0", Offset = "0x15E9DC0", VA = "0x15E9DC0")]
		public ContrastStretch()
		{
		}
	}
	[Token(Token = "0x2000066")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x69D9F8", Offset = "0x69D9F8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x69D9F8", Offset = "0x69D9F8")]
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
		[Address(RVA = "0x15E9E40", Offset = "0x15E9E40", VA = "0x15E9E40", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x15E9F10", Offset = "0x15E9F10", VA = "0x15E9F10")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x15EA2E4", Offset = "0x15EA2E4", VA = "0x15EA2E4")]
		public CreaseShading()
		{
		}
	}
	[Token(Token = "0x2000067")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x69DA8C", Offset = "0x69DA8C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x69DA8C", Offset = "0x69DA8C")]
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
		[Address(RVA = "0x15EA3AC", Offset = "0x15EA3AC", VA = "0x15EA3AC", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x15EA5BC", Offset = "0x15EA5BC", VA = "0x15EA5BC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x15EA640", Offset = "0x15EA640", VA = "0x15EA640")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x15EA75C", Offset = "0x15EA75C", VA = "0x15EA75C")]
		private void ReleaseComputeResources()
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x15EA468", Offset = "0x15EA468", VA = "0x15EA468")]
		private void CreateComputeResources()
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x15EA7B8", Offset = "0x15EA7B8", VA = "0x15EA7B8")]
		private float FocalDistance01(float worldDist)
		{
			return default(float);
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x15EA8A8", Offset = "0x15EA8A8", VA = "0x15EA8A8")]
		private void WriteCoc(RenderTexture fromTo, bool fgDilate)
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x15EABDC", Offset = "0x15EABDC", VA = "0x15EABDC")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x15EC1FC", Offset = "0x15EC1FC", VA = "0x15EC1FC")]
		public DepthOfField()
		{
		}
	}
	[Token(Token = "0x200006A")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x69DB20", Offset = "0x69DB20")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x69DB20", Offset = "0x69DB20")]
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
		[Address(RVA = "0x15EC254", Offset = "0x15EC254", VA = "0x15EC254")]
		private void CreateMaterials()
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x15EC36C", Offset = "0x15EC36C", VA = "0x15EC36C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x15EC4B4", Offset = "0x15EC4B4", VA = "0x15EC4B4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x15EC510", Offset = "0x15EC510", VA = "0x15EC510")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x15EC594", Offset = "0x15EC594", VA = "0x15EC594")]
		private float FocalDistance01(float worldDist)
		{
			return default(float);
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x15EC684", Offset = "0x15EC684", VA = "0x15EC684")]
		private int GetDividerBasedOnQuality()
		{
			return default(int);
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x15EC6A8", Offset = "0x15EC6A8", VA = "0x15EC6A8")]
		private int GetLowResolutionDividerBasedOnQuality(int baseDivider)
		{
			return default(int);
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x15EC6CC", Offset = "0x15EC6CC", VA = "0x15EC6CC")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x15ED5A4", Offset = "0x15ED5A4", VA = "0x15ED5A4")]
		private void Blur(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x15EDC98", Offset = "0x15EDC98", VA = "0x15EDC98")]
		private void BlurFg(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x15EE110", Offset = "0x15EE110", VA = "0x15EE110")]
		private void BlurHex(RenderTexture from, RenderTexture to, int blurPass, float spread, RenderTexture tmp)
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x15ED444", Offset = "0x15ED444", VA = "0x15ED444")]
		private void Downsample(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x15ED848", Offset = "0x15ED848", VA = "0x15ED848")]
		private void AddBokeh(RenderTexture bokehInfo, RenderTexture tempTex, RenderTexture finalTarget)
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x15EDF68", Offset = "0x15EDF68", VA = "0x15EDF68")]
		private void ReleaseTextures()
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x15ED078", Offset = "0x15ED078", VA = "0x15ED078")]
		private void AllocateTextures(bool blurForeground, RenderTexture source, int divider, int lowTexDivider)
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x15EE340", Offset = "0x15EE340", VA = "0x15EE340")]
		public DepthOfFieldDeprecated()
		{
		}
	}
	[Token(Token = "0x200006F")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x69DBB4", Offset = "0x69DBB4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x69DBB4", Offset = "0x69DBB4")]
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
		[Address(RVA = "0x1140B60", Offset = "0x1140B60", VA = "0x1140B60", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x1140CB4", Offset = "0x1140CB4", VA = "0x1140CB4")]
		private new void Start()
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x1140BF8", Offset = "0x1140BF8", VA = "0x1140BF8")]
		private void SetCameraFlag()
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x1140CC0", Offset = "0x1140CC0", VA = "0x1140CC0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x1140CC4", Offset = "0x1140CC4", VA = "0x1140CC4")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x1140EEC", Offset = "0x1140EEC", VA = "0x1140EEC")]
		public EdgeDetection()
		{
		}
	}
	[Token(Token = "0x2000071")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x69DC48", Offset = "0x69DC48")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x69DC48", Offset = "0x69DC48")]
	public class Fisheye : PostEffectsBase
	{
		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x69EA30", Offset = "0x69EA30")]
		public float strengthX;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x69EA48", Offset = "0x69EA48")]
		public float strengthY;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Shader fishEyeShader;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Material fisheyeMaterial;

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x1142440", Offset = "0x1142440", VA = "0x1142440", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x11424B8", Offset = "0x11424B8", VA = "0x11424B8")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x1142630", Offset = "0x1142630", VA = "0x1142630")]
		public Fisheye()
		{
		}
	}
	[Token(Token = "0x2000072")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x69DCDC", Offset = "0x69DCDC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x69DCDC", Offset = "0x69DCDC")]
	internal class GlobalFog : PostEffectsBase
	{
		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x69EA60", Offset = "0x69EA60")]
		public bool distanceFog;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x69EA98", Offset = "0x69EA98")]
		public bool excludeFarPixels;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x69EAD0", Offset = "0x69EAD0")]
		public bool useRadialDistance;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x69EB08", Offset = "0x69EB08")]
		public bool heightFog;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x69EB40", Offset = "0x69EB40")]
		public float height;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x69EB78", Offset = "0x69EB78")]
		public float heightDensity;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x69EB94", Offset = "0x69EB94")]
		public float startDistance;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader fogShader;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material fogMaterial;

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x1145520", Offset = "0x1145520", VA = "0x1145520", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x11455A0", Offset = "0x11455A0", VA = "0x11455A0")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x1145B9C", Offset = "0x1145B9C", VA = "0x1145B9C")]
		public GlobalFog()
		{
		}
	}
	[Token(Token = "0x2000073")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x69DD70", Offset = "0x69DD70")]
	public class Grayscale : ImageEffectBase
	{
		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Texture textureRamp;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x69EBCC", Offset = "0x69EBCC")]
		public float rampOffset;

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x1145BC0", Offset = "0x1145BC0", VA = "0x1145BC0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x1145D8C", Offset = "0x1145D8C", VA = "0x1145D8C")]
		public Grayscale()
		{
		}
	}
	[Token(Token = "0x2000074")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x69DDBC", Offset = "0x69DDBC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x69DDBC", Offset = "0x69DDBC")]
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
			[Address(RVA = "0x1145CB0", Offset = "0x1145CB0", VA = "0x1145CB0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x1146570", Offset = "0x1146570", VA = "0x1146570", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x114661C", Offset = "0x114661C", VA = "0x114661C", Slot = "5")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x1145D94", Offset = "0x1145D94", VA = "0x1145D94")]
		public ImageEffectBase()
		{
		}
	}
	[Token(Token = "0x2000075")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x69DE40", Offset = "0x69DE40")]
	public class ImageEffects
	{
		[Token(Token = "0x600018B")]
		[Address(RVA = "0x1146B08", Offset = "0x1146B08", VA = "0x1146B08")]
		public static void RenderDistortion(Material material, RenderTexture source, RenderTexture destination, float angle, Vector2 center, Vector2 radius)
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x1146D54", Offset = "0x1146D54", VA = "0x1146D54")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x69F194", Offset = "0x69F194")]
		public static void Blit(RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x1146DC8", Offset = "0x1146DC8", VA = "0x1146DC8")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x69F1CC", Offset = "0x69F1CC")]
		public static void BlitWithMaterial(Material material, RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x1146E44", Offset = "0x1146E44", VA = "0x1146E44")]
		public ImageEffects()
		{
		}
	}
	[Token(Token = "0x2000076")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x69DE78", Offset = "0x69DE78")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x69DE78", Offset = "0x69DE78")]
	[ExecuteInEditMode]
	public class MotionBlur : ImageEffectBase
	{
		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x69EBE4", Offset = "0x69EBE4")]
		public float blurAmount;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool extraBlur;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private RenderTexture accumTexture;

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x114946C", Offset = "0x114946C", VA = "0x114946C", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x1149470", Offset = "0x1149470", VA = "0x1149470", Slot = "5")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x11494E0", Offset = "0x11494E0", VA = "0x11494E0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x114987C", Offset = "0x114987C", VA = "0x114987C")]
		public MotionBlur()
		{
		}
	}
	[Token(Token = "0x2000077")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x69DF0C", Offset = "0x69DF0C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x69DF0C", Offset = "0x69DF0C")]
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
		[Address(RVA = "0x14F58F8", Offset = "0x14F58F8", VA = "0x14F58F8", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x14F5F78", Offset = "0x14F5F78", VA = "0x14F5F78")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x14F677C", Offset = "0x14F677C", VA = "0x14F677C")]
		private static void DrawNoiseQuadGrid(RenderTexture source, RenderTexture dest, Material fxMaterial, Texture2D noise, int passNr)
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x14F6AD0", Offset = "0x14F6AD0", VA = "0x14F6AD0")]
		public NoiseAndGrain()
		{
		}
	}
	[Token(Token = "0x2000078")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x69DFA0", Offset = "0x69DFA0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x69DFA0", Offset = "0x69DFA0")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x69EC00", Offset = "0x69EC00")]
		public float grainIntensityMin;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x69EC18", Offset = "0x69EC18")]
		public float grainIntensityMax;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x69EC30", Offset = "0x69EC30")]
		public float grainSize;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x69EC50", Offset = "0x69EC50")]
		public float scratchIntensityMin;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x69EC68", Offset = "0x69EC68")]
		public float scratchIntensityMax;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x69EC80", Offset = "0x69EC80")]
		public float scratchFPS;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x69EC98", Offset = "0x69EC98")]
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
			[Address(RVA = "0x14F6D40", Offset = "0x14F6D40", VA = "0x14F6D40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x14F6BEC", Offset = "0x14F6BEC", VA = "0x14F6BEC")]
		protected void Start()
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x14F6EBC", Offset = "0x14F6EBC", VA = "0x14F6EBC")]
		protected void OnDisable()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x14F6FBC", Offset = "0x14F6FBC", VA = "0x14F6FBC")]
		private void SanitizeParameters()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x14F70B0", Offset = "0x14F70B0", VA = "0x14F70B0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x14F7430", Offset = "0x14F7430", VA = "0x14F7430")]
		public NoiseAndScratches()
		{
		}
	}
	[Token(Token = "0x2000079")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x69E034", Offset = "0x69E034")]
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
		[Address(RVA = "0x14F5A9C", Offset = "0x14F5A9C", VA = "0x14F5A9C")]
		protected Material CheckShaderAndCreateMaterial(Shader s, Material m2Create)
		{
			return null;
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x14F979C", Offset = "0x14F979C", VA = "0x14F979C")]
		protected Material CreateMaterial(Shader s, Material m2Create)
		{
			return null;
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x14F99A4", Offset = "0x14F99A4", VA = "0x14F99A4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x14F99B0", Offset = "0x14F99B0", VA = "0x14F99B0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x14F99B4", Offset = "0x14F99B4", VA = "0x14F99B4")]
		private void RemoveCreatedMaterials()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x14F9A84", Offset = "0x14F9A84", VA = "0x14F9A84")]
		protected bool CheckSupport()
		{
			return default(bool);
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x14F9A8C", Offset = "0x14F9A8C", VA = "0x14F9A8C", Slot = "4")]
		public virtual bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x14F9B50", Offset = "0x14F9B50", VA = "0x14F9B50")]
		protected void Start()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x14F5998", Offset = "0x14F5998", VA = "0x14F5998")]
		protected bool CheckSupport(bool needDepth)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x14F9B5C", Offset = "0x14F9B5C", VA = "0x14F9B5C")]
		protected bool CheckSupport(bool needDepth, bool needHdr)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x14F9BB8", Offset = "0x14F9BB8", VA = "0x14F9BB8")]
		public bool Dx11Support()
		{
			return default(bool);
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x14F5EBC", Offset = "0x14F5EBC", VA = "0x14F5EBC")]
		protected void ReportAutoDisable()
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x14F9BC0", Offset = "0x14F9BC0", VA = "0x14F9BC0")]
		private bool CheckShader(Shader s)
		{
			return default(bool);
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x14F9770", Offset = "0x14F9770", VA = "0x14F9770")]
		protected void NotSupported()
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x14F9E34", Offset = "0x14F9E34", VA = "0x14F9E34")]
		protected void DrawBorder(RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x14F6B0C", Offset = "0x14F6B0C", VA = "0x14F6B0C")]
		public PostEffectsBase()
		{
		}
	}
	[Token(Token = "0x200007A")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x69E0A4", Offset = "0x69E0A4")]
	[ExecuteInEditMode]
	internal class PostEffectsHelper : MonoBehaviour
	{
		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x14FA1B0", Offset = "0x14FA1B0", VA = "0x14FA1B0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x14FA224", Offset = "0x14FA224", VA = "0x14FA224")]
		private static void DrawLowLevelPlaneAlignedWithCamera(float dist, RenderTexture source, RenderTexture dest, Material material, Camera cameraForProjectionMatrix)
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x14FA47C", Offset = "0x14FA47C", VA = "0x14FA47C")]
		private static void DrawBorder(RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x14FA7F4", Offset = "0x14FA7F4", VA = "0x14FA7F4")]
		private static void DrawLowLevelQuad(float x1, float x2, float y1, float y2, RenderTexture source, RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x14FA99C", Offset = "0x14FA99C", VA = "0x14FA99C")]
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
		[Address(RVA = "0x14FADD0", Offset = "0x14FADD0", VA = "0x14FADD0")]
		private static bool HasMeshes()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x14FAEFC", Offset = "0x14FAEFC", VA = "0x14FAEFC")]
		public static void Cleanup()
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x14FB0F4", Offset = "0x14FB0F4", VA = "0x14FB0F4")]
		public static Mesh[] GetMeshes(int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x14FB390", Offset = "0x14FB390", VA = "0x14FB390")]
		private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x14FB750", Offset = "0x14FB750", VA = "0x14FB750")]
		public Quads()
		{
		}
	}
	[Token(Token = "0x200007C")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x69E114", Offset = "0x69E114")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x69E114", Offset = "0x69E114")]
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
		[Address(RVA = "0x150ABC0", Offset = "0x150ABC0", VA = "0x150ABC0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x150AC2C", Offset = "0x150AC2C", VA = "0x150AC2C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x150ADB4", Offset = "0x150ADB4", VA = "0x150ADB4")]
		public ScreenOverlay()
		{
		}
	}
	[Token(Token = "0x200007E")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x69E1A8", Offset = "0x69E1A8")]
	[ExecuteInEditMode]
	public class SepiaTone : ImageEffectBase
	{
		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x150ADC4", Offset = "0x150ADC4", VA = "0x150ADC4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x150AE54", Offset = "0x150AE54", VA = "0x150AE54")]
		public SepiaTone()
		{
		}
	}
	[Token(Token = "0x200007F")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x69E1F4", Offset = "0x69E1F4")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x69E1F4", Offset = "0x69E1F4")]
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
		[Address(RVA = "0x150BD18", Offset = "0x150BD18", VA = "0x150BD18", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x150BDA8", Offset = "0x150BDA8", VA = "0x150BDA8")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x150C588", Offset = "0x150C588", VA = "0x150C588")]
		public SunShafts()
		{
		}
	}
	[Token(Token = "0x2000082")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x69E288", Offset = "0x69E288")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x69E288", Offset = "0x69E288")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x69ECB0", Offset = "0x69ECB0")]
		public float blurArea;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x69ECC8", Offset = "0x69ECC8")]
		public float maxBlurSize;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x69ECE0", Offset = "0x69ECE0")]
		public int downsample;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Shader tiltShiftShader;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Material tiltShiftMaterial;

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x150C61C", Offset = "0x150C61C", VA = "0x150C61C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x150C688", Offset = "0x150C688", VA = "0x150C688")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x150C944", Offset = "0x150C944", VA = "0x150C944")]
		public TiltShift()
		{
		}
	}
	[Token(Token = "0x2000085")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x69E30C", Offset = "0x69E30C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x69E30C", Offset = "0x69E30C")]
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
		[Address(RVA = "0x150CA14", Offset = "0x150CA14", VA = "0x150CA14", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x150CB80", Offset = "0x150CB80", VA = "0x150CB80")]
		public float UpdateCurve()
		{
			return default(float);
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x150CE34", Offset = "0x150CE34", VA = "0x150CE34")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x150CFC0", Offset = "0x150CFC0", VA = "0x150CFC0")]
		private bool CreateInternalRenderTexture()
		{
			return default(bool);
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x150D0C8", Offset = "0x150D0C8", VA = "0x150D0C8")]
		[ImageEffectTransformsToLDR]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x150D92C", Offset = "0x150D92C", VA = "0x150D92C")]
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
		[Address(RVA = "0x17E1C3C", Offset = "0x17E1C3C", VA = "0x17E1C3C")]
		private static bool HasMeshes()
		{
			return default(bool);
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x17E1D80", Offset = "0x17E1D80", VA = "0x17E1D80")]
		private static void Cleanup()
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x17E1F78", Offset = "0x17E1F78", VA = "0x17E1F78")]
		private static Mesh[] GetMeshes(int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x17E2214", Offset = "0x17E2214", VA = "0x17E2214")]
		private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x17E2530", Offset = "0x17E2530", VA = "0x17E2530")]
		public Triangles()
		{
		}
	}
	[Token(Token = "0x2000089")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x69E3A0", Offset = "0x69E3A0")]
	public class Twirl : ImageEffectBase
	{
		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector2 radius;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x69ECF8", Offset = "0x69ECF8")]
		public float angle;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector2 center;

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x17E2720", Offset = "0x17E2720", VA = "0x17E2720")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x17E276C", Offset = "0x17E276C", VA = "0x17E276C")]
		public Twirl()
		{
		}
	}
	[Token(Token = "0x200008A")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x69E3EC", Offset = "0x69E3EC")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x69E3EC", Offset = "0x69E3EC")]
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
		[Address(RVA = "0x17E5644", Offset = "0x17E5644", VA = "0x17E5644", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x17E570C", Offset = "0x17E570C", VA = "0x17E570C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x17E5CFC", Offset = "0x17E5CFC", VA = "0x17E5CFC")]
		public VignetteAndChromaticAberration()
		{
		}
	}
	[Token(Token = "0x200008C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x69E480", Offset = "0x69E480")]
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
		[Address(RVA = "0x17E5D2C", Offset = "0x17E5D2C", VA = "0x17E5D2C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x17E5D78", Offset = "0x17E5D78", VA = "0x17E5D78")]
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
			[Address(RVA = "0x1146AD8", Offset = "0x1146AD8", VA = "0x1146AD8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x11466C8", Offset = "0x11466C8", VA = "0x11466C8")]
		public static bool IsSupported(Shader s, bool needDepth, bool needHdr, MonoBehaviour effect)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x1146A04", Offset = "0x1146A04", VA = "0x1146A04")]
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
		[Address(RVA = "0x1147554", Offset = "0x1147554", VA = "0x1147554")]
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
		[Address(RVA = "0x1501044", Offset = "0x1501044", VA = "0x1501044")]
		public RenderTexture GetTemporaryRenderTexture(int width, int height, int depthBuffer = 0, RenderTextureFormat format = RenderTextureFormat.ARGBHalf, FilterMode filterMode = FilterMode.Bilinear)
		{
			return null;
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x1501130", Offset = "0x1501130", VA = "0x1501130")]
		public void ReleaseTemporaryRenderTexture(RenderTexture rt)
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x15012E8", Offset = "0x15012E8", VA = "0x15012E8")]
		public void ReleaseAllTemporaryRenderTextures()
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x15013A4", Offset = "0x15013A4", VA = "0x15013A4")]
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
		[Address(RVA = "0x1141A2C", Offset = "0x1141A2C", VA = "0x1141A2C")]
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
		[Address(RVA = "0x11499E4", Offset = "0x11499E4", VA = "0x11499E4")]
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
		[Address(RVA = "0x1149D84", Offset = "0x1149D84", VA = "0x1149D84")]
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
		[Address(RVA = "0x150B454", Offset = "0x150B454", VA = "0x150B454")]
		public SmartGCHandle(GCHandle handle)
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x150B480", Offset = "0x150B480", VA = "0x150B480", Slot = "1")]
		~SmartGCHandle()
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x150B4F4", Offset = "0x150B4F4", VA = "0x150B4F4")]
		public IntPtr AddrOfPinnedObject()
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x150B500", Offset = "0x150B500", VA = "0x150B500", Slot = "5")]
		public virtual void Dispose()
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x150B510", Offset = "0x150B510", VA = "0x150B510", Slot = "6")]
		protected virtual void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x150B51C", Offset = "0x150B51C", VA = "0x150B51C")]
		public static implicit operator GCHandle(SmartGCHandle other)
		{
			return default(GCHandle);
		}
	}
	[Token(Token = "0x2000096")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x69E4CC", Offset = "0x69E4CC")]
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
			[Address(RVA = "0x14FA9A4", Offset = "0x14FA9A4", VA = "0x14FA9A4", Slot = "4")]
			get
			{
				return default(IntPtr);
			}
		}

		[Token(Token = "0x1700006B")]
		public string PropertyName
		{
			[Token(Token = "0x60001FE")]
			[Address(RVA = "0x14FACD8", Offset = "0x14FACD8", VA = "0x14FACD8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x14FA9AC", Offset = "0x14FA9AC", VA = "0x14FA9AC")]
		internal PropertyChangedEventArgs(IntPtr pNative)
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x14FAAAC", Offset = "0x14FAAAC", VA = "0x14FAAAC", Slot = "1")]
		~PropertyChangedEventArgs()
		{
		}

		[PreserveSig]
		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x14FABC4", Offset = "0x14FABC4", VA = "0x14FABC4")]
		private static extern void Windows_Data_PropertyChangedEventArgs_ReleaseObject(ref IntPtr pNative);

		[PreserveSig]
		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x14FAA28", Offset = "0x14FAA28", VA = "0x14FAA28")]
		private static extern void Windows_Data_PropertyChangedEventArgs_AddRefObject(ref IntPtr pNative);

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x14FAB18", Offset = "0x14FAB18", VA = "0x14FAB18")]
		private void Dispose(bool disposing)
		{
		}

		[PreserveSig]
		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x14FAC4C", Offset = "0x14FAC4C", VA = "0x14FAC4C")]
		private static extern IntPtr Windows_Data_PropertyChangedEventArgs_get_PropertyName(IntPtr pNative);

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x14FAC48", Offset = "0x14FAC48", VA = "0x14FAC48")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69ED14", Offset = "0x69ED14")]
		private float <FocalLengthX>k__BackingField;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69ED24", Offset = "0x69ED24")]
		private float <FocalLengthY>k__BackingField;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69ED34", Offset = "0x69ED34")]
		private float <PrincipalPointX>k__BackingField;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69ED44", Offset = "0x69ED44")]
		private float <PrincipalPointY>k__BackingField;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69ED54", Offset = "0x69ED54")]
		private float <RadialDistortionSecondOrder>k__BackingField;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69ED64", Offset = "0x69ED64")]
		private float <RadialDistortionFourthOrder>k__BackingField;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69ED74", Offset = "0x69ED74")]
		private float <RadialDistortionSixthOrder>k__BackingField;

		[Token(Token = "0x1700006C")]
		public float FocalLengthX
		{
			[Token(Token = "0x6000200")]
			[Address(RVA = "0x15E2504", Offset = "0x15E2504", VA = "0x15E2504")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69F214", Offset = "0x69F214")]
			readonly get
			{
				return default(float);
			}
			[Token(Token = "0x6000201")]
			[Address(RVA = "0x15E250C", Offset = "0x15E250C", VA = "0x15E250C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69F24C", Offset = "0x69F24C")]
			set
			{
			}
		}

		[Token(Token = "0x1700006D")]
		public float FocalLengthY
		{
			[Token(Token = "0x6000202")]
			[Address(RVA = "0x15E2514", Offset = "0x15E2514", VA = "0x15E2514")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69F25C", Offset = "0x69F25C")]
			readonly get
			{
				return default(float);
			}
			[Token(Token = "0x6000203")]
			[Address(RVA = "0x15E251C", Offset = "0x15E251C", VA = "0x15E251C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69F294", Offset = "0x69F294")]
			set
			{
			}
		}

		[Token(Token = "0x1700006E")]
		public float PrincipalPointX
		{
			[Token(Token = "0x6000204")]
			[Address(RVA = "0x15E2524", Offset = "0x15E2524", VA = "0x15E2524")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69F2A4", Offset = "0x69F2A4")]
			readonly get
			{
				return default(float);
			}
			[Token(Token = "0x6000205")]
			[Address(RVA = "0x15E252C", Offset = "0x15E252C", VA = "0x15E252C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69F2DC", Offset = "0x69F2DC")]
			set
			{
			}
		}

		[Token(Token = "0x1700006F")]
		public float PrincipalPointY
		{
			[Token(Token = "0x6000206")]
			[Address(RVA = "0x15E2534", Offset = "0x15E2534", VA = "0x15E2534")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69F2EC", Offset = "0x69F2EC")]
			readonly get
			{
				return default(float);
			}
			[Token(Token = "0x6000207")]
			[Address(RVA = "0x15E253C", Offset = "0x15E253C", VA = "0x15E253C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69F324", Offset = "0x69F324")]
			set
			{
			}
		}

		[Token(Token = "0x17000070")]
		public float RadialDistortionSecondOrder
		{
			[Token(Token = "0x6000208")]
			[Address(RVA = "0x15E2544", Offset = "0x15E2544", VA = "0x15E2544")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69F334", Offset = "0x69F334")]
			readonly get
			{
				return default(float);
			}
			[Token(Token = "0x6000209")]
			[Address(RVA = "0x15E254C", Offset = "0x15E254C", VA = "0x15E254C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69F36C", Offset = "0x69F36C")]
			set
			{
			}
		}

		[Token(Token = "0x17000071")]
		public float RadialDistortionFourthOrder
		{
			[Token(Token = "0x600020A")]
			[Address(RVA = "0x15E2554", Offset = "0x15E2554", VA = "0x15E2554")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69F37C", Offset = "0x69F37C")]
			readonly get
			{
				return default(float);
			}
			[Token(Token = "0x600020B")]
			[Address(RVA = "0x15E255C", Offset = "0x15E255C", VA = "0x15E255C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69F3B4", Offset = "0x69F3B4")]
			set
			{
			}
		}

		[Token(Token = "0x17000072")]
		public float RadialDistortionSixthOrder
		{
			[Token(Token = "0x600020C")]
			[Address(RVA = "0x15E2564", Offset = "0x15E2564", VA = "0x15E2564")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69F3C4", Offset = "0x69F3C4")]
			readonly get
			{
				return default(float);
			}
			[Token(Token = "0x600020D")]
			[Address(RVA = "0x15E256C", Offset = "0x15E256C", VA = "0x15E256C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69F3FC", Offset = "0x69F3FC")]
			set
			{
			}
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x15E2574", Offset = "0x15E2574", VA = "0x15E2574", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x15E2664", Offset = "0x15E2664", VA = "0x15E2664", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x15E2700", Offset = "0x15E2700", VA = "0x15E2700")]
		public bool Equals(CameraIntrinsics obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x15E27F4", Offset = "0x15E27F4", VA = "0x15E27F4")]
		public static bool operator ==(CameraIntrinsics a, CameraIntrinsics b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x15E2828", Offset = "0x15E2828", VA = "0x15E2828")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69E504", Offset = "0x69E504")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x4000387")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Type type;

			[Token(Token = "0x6000218")]
			[Address(RVA = "0x17E6324", Offset = "0x17E6324", VA = "0x17E6324")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x6000219")]
			[Address(RVA = "0x17E632C", Offset = "0x17E632C", VA = "0x17E632C")]
			internal bool <GetTypeData>b__0(TypeData data)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200009C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69E514", Offset = "0x69E514")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x4000388")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Type type;

			[Token(Token = "0x600021A")]
			[Address(RVA = "0x17E63D0", Offset = "0x17E63D0", VA = "0x17E63D0")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x600021B")]
			[Address(RVA = "0x17E63D8", Offset = "0x17E63D8", VA = "0x17E63D8")]
			internal bool <GetTypeData>b__0(TypeData data)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x200009D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69E524", Offset = "0x69E524")]
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
			[Address(RVA = "0x17E61C0", Offset = "0x17E61C0", VA = "0x17E61C0")]
			public <>c()
			{
			}

			[Token(Token = "0x600021E")]
			[Address(RVA = "0x17E61C8", Offset = "0x17E61C8", VA = "0x17E61C8")]
			internal bool <FetchTypes>b__6_0(Assembly assembly)
			{
				return default(bool);
			}

			[Token(Token = "0x600021F")]
			[Address(RVA = "0x17E6230", Offset = "0x17E6230", VA = "0x17E6230")]
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
			[Address(RVA = "0x15E7638", Offset = "0x15E7638", VA = "0x15E7638")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x15E76B0", Offset = "0x15E76B0", VA = "0x15E76B0")]
		public static Type GetType(string typeName)
		{
			return null;
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x15E76DC", Offset = "0x15E76DC", VA = "0x15E76DC")]
		public static TypeData GetTypeData(string typeName)
		{
			return null;
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x15E8540", Offset = "0x15E8540", VA = "0x15E8540")]
		public static TypeData GetTypeData(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x15E7A88", Offset = "0x15E7A88", VA = "0x15E7A88")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69ED84", Offset = "0x69ED84")]
		private string <Identifier>k__BackingField;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69ED94", Offset = "0x69ED94")]
		private Type <Type>k__BackingField;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69EDA4", Offset = "0x69EDA4")]
		private Color <Color>k__BackingField;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69EDB4", Offset = "0x69EDB4")]
		private Texture2D <InKnobTex>k__BackingField;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69EDC4", Offset = "0x69EDC4")]
		private Texture2D <OutKnobTex>k__BackingField;

		[Token(Token = "0x17000074")]
		public string Identifier
		{
			[Token(Token = "0x6000220")]
			[Address(RVA = "0x17E2788", Offset = "0x17E2788", VA = "0x17E2788")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69F40C", Offset = "0x69F40C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000221")]
			[Address(RVA = "0x17E2790", Offset = "0x17E2790", VA = "0x17E2790")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69F41C", Offset = "0x69F41C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000075")]
		public Type Type
		{
			[Token(Token = "0x6000222")]
			[Address(RVA = "0x17E2798", Offset = "0x17E2798", VA = "0x17E2798")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69F42C", Offset = "0x69F42C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000223")]
			[Address(RVA = "0x17E27A0", Offset = "0x17E27A0", VA = "0x17E27A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69F43C", Offset = "0x69F43C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000076")]
		public Color Color
		{
			[Token(Token = "0x6000224")]
			[Address(RVA = "0x17E27A8", Offset = "0x17E27A8", VA = "0x17E27A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69F44C", Offset = "0x69F44C")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000225")]
			[Address(RVA = "0x17E27B4", Offset = "0x17E27B4", VA = "0x17E27B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69F45C", Offset = "0x69F45C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000077")]
		public Texture2D InKnobTex
		{
			[Token(Token = "0x6000226")]
			[Address(RVA = "0x17E27C0", Offset = "0x17E27C0", VA = "0x17E27C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69F46C", Offset = "0x69F46C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000227")]
			[Address(RVA = "0x17E27C8", Offset = "0x17E27C8", VA = "0x17E27C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69F47C", Offset = "0x69F47C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000078")]
		public Texture2D OutKnobTex
		{
			[Token(Token = "0x6000228")]
			[Address(RVA = "0x17E27D0", Offset = "0x17E27D0", VA = "0x17E27D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69F48C", Offset = "0x69F48C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000229")]
			[Address(RVA = "0x17E27D8", Offset = "0x17E27D8", VA = "0x17E27D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69F49C", Offset = "0x69F49C")]
			private set
			{
			}
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x17E27E0", Offset = "0x17E27E0", VA = "0x17E27E0")]
		internal TypeData(IConnectionTypeDeclaration typeDecl)
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x17E2CE0", Offset = "0x17E2CE0", VA = "0x17E2CE0")]
		public TypeData(Type type)
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x17E2BD0", Offset = "0x17E2BD0", VA = "0x17E2BD0")]
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
			[Address(RVA = "0x1142C4C", Offset = "0x1142C4C", VA = "0x1142C4C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007F")]
		public Type Type
		{
			[Token(Token = "0x6000233")]
			[Address(RVA = "0x1142C90", Offset = "0x1142C90", VA = "0x1142C90", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000080")]
		public Color Color
		{
			[Token(Token = "0x6000234")]
			[Address(RVA = "0x1142D08", Offset = "0x1142D08", VA = "0x1142D08", Slot = "6")]
			get
			{
				return default(Color);
			}
		}

		[Token(Token = "0x17000081")]
		public string InKnobTex
		{
			[Token(Token = "0x6000235")]
			[Address(RVA = "0x1142D10", Offset = "0x1142D10", VA = "0x1142D10", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000082")]
		public string OutKnobTex
		{
			[Token(Token = "0x6000236")]
			[Address(RVA = "0x1142D54", Offset = "0x1142D54", VA = "0x1142D54", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x1142D98", Offset = "0x1142D98", VA = "0x1142D98")]
		public FloatType()
		{
		}
	}
	[Token(Token = "0x20000A1")]
	public abstract class Node : ScriptableObject
	{
		[Token(Token = "0x20000A2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69E534", Offset = "0x69E534")]
		private sealed class <>c__DisplayClass44_0
		{
			[Token(Token = "0x400039B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Type newOutputType;

			[Token(Token = "0x6000264")]
			[Address(RVA = "0x17E7184", Offset = "0x17E7184", VA = "0x17E7184")]
			public <>c__DisplayClass44_0()
			{
			}

			[Token(Token = "0x6000265")]
			[Address(RVA = "0x17E718C", Offset = "0x17E718C", VA = "0x17E718C")]
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
			[Address(RVA = "0x114B414", Offset = "0x114B414", VA = "0x114B414", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000085")]
		public virtual bool ContinueCalculation
		{
			[Token(Token = "0x6000244")]
			[Address(RVA = "0x114B41C", Offset = "0x114B41C", VA = "0x114B41C", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x114A1E4", Offset = "0x114A1E4", VA = "0x114A1E4")]
		protected internal void InitBase()
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x114A478", Offset = "0x114A478", VA = "0x114A478")]
		public void Delete()
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x114ADF0", Offset = "0x114ADF0", VA = "0x114ADF0")]
		public static Node Create(string nodeID, Vector2 position)
		{
			return null;
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x114ADF8", Offset = "0x114ADF8", VA = "0x114ADF8")]
		public static Node Create(string nodeID, Vector2 position, NodeOutput connectingOutput)
		{
			return null;
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x114B304", Offset = "0x114B304", VA = "0x114B304")]
		internal void CheckNodeKnobMigration()
		{
		}

		[Token(Token = "0x600023E")]
		public abstract Node Create(Vector2 pos);

		[Token(Token = "0x600023F")]
		protected internal abstract void NodeGUI();

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x114B404", Offset = "0x114B404", VA = "0x114B404", Slot = "7")]
		public virtual void DrawNodePropertyEditor()
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x114B408", Offset = "0x114B408", VA = "0x114B408", Slot = "8")]
		public virtual bool Calculate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x114B410", Offset = "0x114B410", VA = "0x114B410", Slot = "9")]
		public virtual void CheckSize()
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x114B424", Offset = "0x114B424", VA = "0x114B424", Slot = "12")]
		protected internal virtual void OnDelete()
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x114B428", Offset = "0x114B428", VA = "0x114B428", Slot = "13")]
		protected internal virtual void OnAddInputConnection(NodeInput input)
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x114B42C", Offset = "0x114B42C", VA = "0x114B42C", Slot = "14")]
		protected internal virtual void OnAddOutputConnection(NodeOutput output)
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x114B430", Offset = "0x114B430", VA = "0x114B430", Slot = "15")]
		public virtual ScriptableObject[] GetScriptableObjects()
		{
			return null;
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x114B478", Offset = "0x114B478", VA = "0x114B478", Slot = "16")]
		protected internal virtual void CopyScriptableObjects(Func<ScriptableObject, ScriptableObject> replaceSerializableObject)
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x114B47C", Offset = "0x114B47C", VA = "0x114B47C")]
		public void SerializeInputsAndOutputs(Func<ScriptableObject, ScriptableObject> replaceSerializableObject)
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x114B480", Offset = "0x114B480", VA = "0x114B480", Slot = "17")]
		protected internal virtual void DrawNode()
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x114B968", Offset = "0x114B968", VA = "0x114B968", Slot = "18")]
		protected internal virtual void DrawKnobs()
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x114BA14", Offset = "0x114BA14", VA = "0x114BA14", Slot = "19")]
		protected internal virtual void DrawConnections()
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x114BE58", Offset = "0x114BE58", VA = "0x114BE58")]
		protected internal bool allInputsReady()
		{
			return default(bool);
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x114BF84", Offset = "0x114BF84", VA = "0x114BF84")]
		protected internal bool hasUnassignedInputs()
		{
			return default(bool);
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x114C06C", Offset = "0x114C06C", VA = "0x114C06C")]
		protected internal bool descendantsCalculated()
		{
			return default(bool);
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x114C19C", Offset = "0x114C19C", VA = "0x114C19C")]
		protected internal bool isInput()
		{
			return default(bool);
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x114C284", Offset = "0x114C284", VA = "0x114C284")]
		public NodeOutput CreateOutput(string outputName, string outputType)
		{
			return null;
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x114C28C", Offset = "0x114C28C", VA = "0x114C28C")]
		public NodeOutput CreateOutput(string outputName, string outputType, NodeSide nodeSide)
		{
			return null;
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x11428B8", Offset = "0x11428B8", VA = "0x11428B8")]
		public NodeOutput CreateOutput(string outputName, string outputType, NodeSide nodeSide, float sidePosition)
		{
			return null;
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x114C294", Offset = "0x114C294", VA = "0x114C294")]
		protected void OutputKnob(int outputIdx)
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x114C3F4", Offset = "0x114C3F4", VA = "0x114C3F4")]
		public NodeInput CreateInput(string inputName, string inputType)
		{
			return null;
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x114C40C", Offset = "0x114C40C", VA = "0x114C40C")]
		public NodeInput CreateInput(string inputName, string inputType, NodeSide nodeSide)
		{
			return null;
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x11428B4", Offset = "0x11428B4", VA = "0x11428B4")]
		public NodeInput CreateInput(string inputName, string inputType, NodeSide nodeSide, float sidePosition)
		{
			return null;
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x114C4F0", Offset = "0x114C4F0", VA = "0x114C4F0")]
		protected void InputKnob(int inputIdx)
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x114C594", Offset = "0x114C594", VA = "0x114C594")]
		protected static void ReassignOutputType(ref NodeOutput output, Type newOutputType)
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x114CE78", Offset = "0x114CE78", VA = "0x114CE78")]
		protected static void ReassignInputType(ref NodeInput input, Type newInputType)
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x114D090", Offset = "0x114D090", VA = "0x114D090")]
		public bool isChildOf(Node otherNode)
		{
			return default(bool);
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x114D4C4", Offset = "0x114D4C4", VA = "0x114D4C4")]
		internal bool isInLoop()
		{
			return default(bool);
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x114D634", Offset = "0x114D634", VA = "0x114D634")]
		internal bool allowsLoopRecursion(Node otherNode)
		{
			return default(bool);
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x114D7B8", Offset = "0x114D7B8", VA = "0x114D7B8")]
		public void ClearCalculation()
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x114D298", Offset = "0x114D298", VA = "0x114D298")]
		internal bool BeginRecursiveSearchLoop()
		{
			return default(bool);
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x114D418", Offset = "0x114D418", VA = "0x114D418")]
		internal void EndRecursiveSearchLoop()
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x114D3E4", Offset = "0x114D3E4", VA = "0x114D3E4")]
		internal void StopRecursiveSearchLoop()
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x114D8EC", Offset = "0x114D8EC", VA = "0x114D8EC")]
		protected Node()
		{
		}
	}
	[Token(Token = "0x20000A3")]
	[AttributeAttribute(Name = "NodeCanvasTypeAttribute", RVA = "0x69E544", Offset = "0x69E544")]
	public class NodeCanvas : ScriptableObject
	{
		[Serializable]
		[Token(Token = "0x20000A4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69E57C", Offset = "0x69E57C")]
		private sealed class <>c
		{
			[Token(Token = "0x400039F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40003A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<NodeEditorState, bool> <>9__6_0;

			[Token(Token = "0x600026B")]
			[Address(RVA = "0x17E723C", Offset = "0x17E723C", VA = "0x17E723C")]
			public <>c()
			{
			}

			[Token(Token = "0x600026C")]
			[Address(RVA = "0x17E7244", Offset = "0x17E7244", VA = "0x17E7244")]
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
			[Address(RVA = "0x114DB04", Offset = "0x114DB04", VA = "0x114DB04", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x114DB48", Offset = "0x114DB48", VA = "0x114DB48", Slot = "5")]
		public virtual void BeforeSavingCanvas()
		{
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x114DB4C", Offset = "0x114DB4C", VA = "0x114DB4C")]
		public void Validate()
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x114E4B8", Offset = "0x114E4B8", VA = "0x114E4B8")]
		public NodeCanvas()
		{
		}
	}
	[Token(Token = "0x20000A5")]
	public class NodeCanvasManager
	{
		[Serializable]
		[Token(Token = "0x20000A6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69E58C", Offset = "0x69E58C")]
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
			[Address(RVA = "0x17E7310", Offset = "0x17E7310", VA = "0x17E7310")]
			public <>c()
			{
			}

			[Token(Token = "0x6000274")]
			[Address(RVA = "0x17E7318", Offset = "0x17E7318", VA = "0x17E7318")]
			internal bool <GetAllCanvasTypes>b__2_0(Assembly assembly)
			{
				return default(bool);
			}

			[Token(Token = "0x6000275")]
			[Address(RVA = "0x17E7380", Offset = "0x17E7380", VA = "0x17E7380")]
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
		[Address(RVA = "0x114E56C", Offset = "0x114E56C", VA = "0x114E56C")]
		public static void GetAllCanvasTypes()
		{
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x114EF34", Offset = "0x114EF34", VA = "0x114EF34")]
		private static void CreateNewCanvas(object userdata)
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x114EFE8", Offset = "0x114EFE8", VA = "0x114EFE8")]
		public static void FillCanvasTypeMenu(ref GenericMenu menu, Action<Type> newNodeCanvas)
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x114F218", Offset = "0x114F218", VA = "0x114F218")]
		public static bool CheckCanvasCompability(Node node, Type canvasType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x114F2A0", Offset = "0x114F2A0", VA = "0x114F2A0")]
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
		[Address(RVA = "0x114F2B0", Offset = "0x114F2B0", VA = "0x114F2B0")]
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
		[Address(RVA = "0x114F318", Offset = "0x114F318", VA = "0x114F318")]
		public static void Update()
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x114A3D4", Offset = "0x114A3D4", VA = "0x114A3D4")]
		public static void RepaintClients()
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x114F3BC", Offset = "0x114F3BC", VA = "0x114F3BC")]
		public static void checkInit(bool GUIFunction)
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x114F750", Offset = "0x114F750", VA = "0x114F750")]
		public static void ReInit(bool GUIFunction)
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x114F4B8", Offset = "0x114F4B8", VA = "0x114F4B8")]
		private static void setupBaseFramework()
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x114F620", Offset = "0x114F620", VA = "0x114F620")]
		private static void setupGUI()
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x114F7F4", Offset = "0x114F7F4", VA = "0x114F7F4")]
		public static void CheckEditorPath()
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x1151298", Offset = "0x1151298", VA = "0x1151298")]
		public static void DrawCanvas(NodeCanvas nodeCanvas, NodeEditorState editorState)
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x1151388", Offset = "0x1151388", VA = "0x1151388")]
		private static void DrawSubCanvas(NodeCanvas nodeCanvas, NodeEditorState editorState)
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x1151F8C", Offset = "0x1151F8C", VA = "0x1151F8C")]
		public static Node NodeAtPosition(Vector2 canvasPos)
		{
			return null;
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x115222C", Offset = "0x115222C", VA = "0x115222C")]
		public static Node NodeAtPosition(Vector2 canvasPos, out NodeKnob focusedKnob)
		{
			return null;
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x1152014", Offset = "0x1152014", VA = "0x1152014")]
		public static Node NodeAtPosition(NodeEditorState editorState, Vector2 canvasPos, out NodeKnob focusedKnob)
		{
			return null;
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x1152524", Offset = "0x1152524", VA = "0x1152524")]
		public static Vector2 ScreenToCanvasSpace(Vector2 screenPos)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x11525A0", Offset = "0x11525A0", VA = "0x11525A0")]
		public static Vector2 ScreenToCanvasSpace(NodeEditorState editorState, Vector2 screenPos)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x1152624", Offset = "0x1152624", VA = "0x1152624")]
		public static void RecalculateAll(NodeCanvas nodeCanvas)
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x114A2F0", Offset = "0x114A2F0", VA = "0x114A2F0")]
		public static void RecalculateFrom(Node node)
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x1152854", Offset = "0x1152854", VA = "0x1152854")]
		public static void StartCalculation()
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x1152A04", Offset = "0x1152A04", VA = "0x1152A04")]
		private static bool ContinueCalculation(Node node)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000AA")]
	public abstract class NodeEditorCallbackReceiver : MonoBehaviour
	{
		[Token(Token = "0x600028A")]
		[Address(RVA = "0x1152DAC", Offset = "0x1152DAC", VA = "0x1152DAC", Slot = "4")]
		public virtual void OnEditorStartUp()
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x1152DB0", Offset = "0x1152DB0", VA = "0x1152DB0", Slot = "5")]
		public virtual void OnLoadCanvas(NodeCanvas canvas)
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x1152DB4", Offset = "0x1152DB4", VA = "0x1152DB4", Slot = "6")]
		public virtual void OnLoadEditorState(NodeEditorState editorState)
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x1152DB8", Offset = "0x1152DB8", VA = "0x1152DB8", Slot = "7")]
		public virtual void OnSaveCanvas(NodeCanvas canvas)
		{
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x1152DBC", Offset = "0x1152DBC", VA = "0x1152DBC", Slot = "8")]
		public virtual void OnSaveEditorState(NodeEditorState editorState)
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x1152DC0", Offset = "0x1152DC0", VA = "0x1152DC0", Slot = "9")]
		public virtual void OnAddNode(Node node)
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x1152DC4", Offset = "0x1152DC4", VA = "0x1152DC4", Slot = "10")]
		public virtual void OnDeleteNode(Node node)
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x1152DC8", Offset = "0x1152DC8", VA = "0x1152DC8", Slot = "11")]
		public virtual void OnMoveNode(Node node)
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x1152DCC", Offset = "0x1152DCC", VA = "0x1152DCC", Slot = "12")]
		public virtual void OnAddNodeKnob(NodeKnob knob)
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x1152DD0", Offset = "0x1152DD0", VA = "0x1152DD0", Slot = "13")]
		public virtual void OnAddConnection(NodeInput input)
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x1152DD4", Offset = "0x1152DD4", VA = "0x1152DD4", Slot = "14")]
		public virtual void OnRemoveConnection(NodeInput input)
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x1152DD8", Offset = "0x1152DD8", VA = "0x1152DD8")]
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
		[Address(RVA = "0x114F7F8", Offset = "0x114F7F8", VA = "0x114F7F8")]
		public static void SetupReceivers()
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x114F91C", Offset = "0x114F91C", VA = "0x114F91C")]
		public static void IssueOnEditorStartUp()
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x1152DE0", Offset = "0x1152DE0", VA = "0x1152DE0")]
		public static void IssueOnLoadCanvas(NodeCanvas canvas)
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x115302C", Offset = "0x115302C", VA = "0x115302C")]
		public static void IssueOnLoadEditorState(NodeEditorState editorState)
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x1153278", Offset = "0x1153278", VA = "0x1153278")]
		public static void IssueOnSaveCanvas(NodeCanvas canvas)
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x11534C4", Offset = "0x11534C4", VA = "0x11534C4")]
		public static void IssueOnSaveEditorState(NodeEditorState editorState)
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x114B0B8", Offset = "0x114B0B8", VA = "0x114B0B8")]
		public static void IssueOnAddNode(Node node)
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x114AA58", Offset = "0x114AA58", VA = "0x114AA58")]
		public static void IssueOnDeleteNode(Node node)
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x1153710", Offset = "0x1153710", VA = "0x1153710")]
		public static void IssueOnMoveNode(Node node)
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x114CA0C", Offset = "0x114CA0C", VA = "0x114CA0C")]
		public static void IssueOnAddNodeKnob(NodeKnob nodeKnob)
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x115395C", Offset = "0x115395C", VA = "0x115395C")]
		public static void IssueOnAddConnection(NodeInput input)
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x1153BAC", Offset = "0x1153BAC", VA = "0x1153BAC")]
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
		[Address(RVA = "0x1150B5C", Offset = "0x1150B5C", VA = "0x1150B5C")]
		public static bool Init()
		{
			return default(bool);
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x1153E00", Offset = "0x1153E00", VA = "0x1153E00")]
		public static void StartNodeGUI()
		{
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x1153F80", Offset = "0x1153F80", VA = "0x1153F80")]
		public static void EndNodeGUI()
		{
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x1154024", Offset = "0x1154024", VA = "0x1154024")]
		public static void DrawConnection(Vector2 startPos, Vector2 endPos, Color col)
		{
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x114BD3C", Offset = "0x114BD3C", VA = "0x114BD3C")]
		public static void DrawConnection(Vector2 startPos, Vector2 startDir, Vector2 endPos, Vector2 endDir, Color col)
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x1154124", Offset = "0x1154124", VA = "0x1154124")]
		public static void DrawConnection(Vector2 startPos, Vector2 startDir, Vector2 endPos, Vector2 endDir, ConnectionDrawMethod drawMethod, Color col)
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x1151ECC", Offset = "0x1151ECC", VA = "0x1151ECC")]
		internal static Vector2 GetSecondConnectionVector(Vector2 startPos, Vector2 endPos, Vector2 firstVector)
		{
			return default(Vector2);
		}
	}
	[Token(Token = "0x20000AD")]
	public static class NodeEditorInputControls
	{
		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x11543EC", Offset = "0x11543EC", VA = "0x11543EC")]
		[AttributeAttribute(Name = "ContextFillerAttribute", RVA = "0x69F4AC", Offset = "0x69F4AC")]
		private static void FillAddNodes(NodeEditorInputInfo inputInfo, GenericMenu canvasContextMenu)
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x1154800", Offset = "0x1154800", VA = "0x1154800")]
		private static void CreateNodeCallback(object infoObj)
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x11549D0", Offset = "0x11549D0", VA = "0x11549D0")]
		[AttributeAttribute(Name = "ContextEntryAttribute", RVA = "0x69F4C0", Offset = "0x69F4C0")]
		private static void DeleteNode(NodeEditorInputInfo inputInfo)
		{
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x1154A88", Offset = "0x1154A88", VA = "0x1154A88")]
		[AttributeAttribute(Name = "ContextEntryAttribute", RVA = "0x69F4FC", Offset = "0x69F4FC")]
		private static void DuplicateNode(NodeEditorInputInfo inputInfo)
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x1154BE0", Offset = "0x1154BE0", VA = "0x1154BE0")]
		[AttributeAttribute(Name = "HotkeyAttribute", RVA = "0x69F538", Offset = "0x69F538")]
		[AttributeAttribute(Name = "HotkeyAttribute", RVA = "0x69F538", Offset = "0x69F538")]
		[AttributeAttribute(Name = "HotkeyAttribute", RVA = "0x69F538", Offset = "0x69F538")]
		[AttributeAttribute(Name = "HotkeyAttribute", RVA = "0x69F538", Offset = "0x69F538")]
		private static void KB_MoveNode(NodeEditorInputInfo inputInfo)
		{
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x1154D94", Offset = "0x1154D94", VA = "0x1154D94")]
		[AttributeAttribute(Name = "EventHandlerAttribute", RVA = "0x69F5B0", Offset = "0x69F5B0")]
		private static void HandleNodeDraggingStart(NodeEditorInputInfo inputInfo)
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x1154F38", Offset = "0x1154F38", VA = "0x1154F38")]
		[AttributeAttribute(Name = "EventHandlerAttribute", RVA = "0x69F5C8", Offset = "0x69F5C8")]
		private static void HandleNodeDragging(NodeEditorInputInfo inputInfo)
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x11550B4", Offset = "0x11550B4", VA = "0x11550B4")]
		[AttributeAttribute(Name = "EventHandlerAttribute", RVA = "0x69F5DC", Offset = "0x69F5DC")]
		[AttributeAttribute(Name = "EventHandlerAttribute", RVA = "0x69F5DC", Offset = "0x69F5DC")]
		private static void HandleNodeDraggingEnd(NodeEditorInputInfo inputInfo)
		{
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x11550D8", Offset = "0x11550D8", VA = "0x11550D8")]
		[AttributeAttribute(Name = "EventHandlerAttribute", RVA = "0x69F61C", Offset = "0x69F61C")]
		private static void HandleWindowPanningStart(NodeEditorInputInfo inputInfo)
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x11551EC", Offset = "0x11551EC", VA = "0x11551EC")]
		[AttributeAttribute(Name = "EventHandlerAttribute", RVA = "0x69F634", Offset = "0x69F634")]
		private static void HandleWindowPanning(NodeEditorInputInfo inputInfo)
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x1155298", Offset = "0x1155298", VA = "0x1155298")]
		[AttributeAttribute(Name = "EventHandlerAttribute", RVA = "0x69F648", Offset = "0x69F648")]
		[AttributeAttribute(Name = "EventHandlerAttribute", RVA = "0x69F648", Offset = "0x69F648")]
		private static void HandleWindowPanningEnd(NodeEditorInputInfo inputInfo)
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x11552BC", Offset = "0x11552BC", VA = "0x11552BC")]
		[AttributeAttribute(Name = "EventHandlerAttribute", RVA = "0x69F688", Offset = "0x69F688")]
		private static void HandleConnectionDrawing(NodeEditorInputInfo inputInfo)
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x1155454", Offset = "0x1155454", VA = "0x1155454")]
		[AttributeAttribute(Name = "EventHandlerAttribute", RVA = "0x69F69C", Offset = "0x69F69C")]
		private static void HandleApplyConnection(NodeEditorInputInfo inputInfo)
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x11555C8", Offset = "0x11555C8", VA = "0x11555C8")]
		[AttributeAttribute(Name = "EventHandlerAttribute", RVA = "0x69F6B0", Offset = "0x69F6B0")]
		private static void HandleZooming(NodeEditorInputInfo inputInfo)
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x11556C4", Offset = "0x11556C4", VA = "0x11556C4")]
		[AttributeAttribute(Name = "HotkeyAttribute", RVA = "0x69F6C4", Offset = "0x69F6C4")]
		private static void HandleStartNavigating(NodeEditorInputInfo inputInfo)
		{
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x11556EC", Offset = "0x11556EC", VA = "0x11556EC")]
		[AttributeAttribute(Name = "HotkeyAttribute", RVA = "0x69F6DC", Offset = "0x69F6DC")]
		private static void HandleEndNavigating(NodeEditorInputInfo inputInfo)
		{
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x1155710", Offset = "0x1155710", VA = "0x1155710")]
		[AttributeAttribute(Name = "HotkeyAttribute", RVA = "0x69F6F4", Offset = "0x69F6F4")]
		[AttributeAttribute(Name = "HotkeyAttribute", RVA = "0x69F6F4", Offset = "0x69F6F4")]
		private static void HandleNodeSnap(NodeEditorInputInfo inputInfo)
		{
		}
	}
	[Token(Token = "0x20000AE")]
	public static class NodeEditorInputSystem
	{
		[Token(Token = "0x20000AF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69E59C", Offset = "0x69E59C")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x40003D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Delegate actionDelegate;

			[Token(Token = "0x40003D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public PopupMenu.MenuFunctionData <>9__3;

			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x17E760C", Offset = "0x17E760C", VA = "0x17E760C")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x60002C7")]
			[Address(RVA = "0x17E7614", Offset = "0x17E7614", VA = "0x17E7614")]
			internal void <SetupInput>b__3(object callbackObj)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69E5AC", Offset = "0x69E5AC")]
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
			[Address(RVA = "0x17E74BC", Offset = "0x17E74BC", VA = "0x17E74BC")]
			public <>c()
			{
			}

			[Token(Token = "0x60002CA")]
			[Address(RVA = "0x17E74C4", Offset = "0x17E74C4", VA = "0x17E74C4")]
			internal bool <SetupInput>b__4_0(Assembly assembly)
			{
				return default(bool);
			}

			[Token(Token = "0x60002CB")]
			[Address(RVA = "0x17E752C", Offset = "0x17E752C", VA = "0x17E752C")]
			internal int <SetupInput>b__4_1(KeyValuePair<EventHandlerAttribute, Delegate> handlerA, KeyValuePair<EventHandlerAttribute, Delegate> handlerB)
			{
				return default(int);
			}

			[Token(Token = "0x60002CC")]
			[Address(RVA = "0x17E759C", Offset = "0x17E759C", VA = "0x17E759C")]
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
		[Address(RVA = "0x114FB40", Offset = "0x114FB40", VA = "0x114FB40")]
		public static void SetupInput()
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x11558C8", Offset = "0x11558C8", VA = "0x11558C8")]
		private static void CallEventHandlers(NodeEditorInputInfo inputInfo, bool late)
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x1155B58", Offset = "0x1155B58", VA = "0x1155B58")]
		private static void CallHotkeys(NodeEditorInputInfo inputInfo, KeyCode keyCode, EventModifiers mods)
		{
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x1155E0C", Offset = "0x1155E0C", VA = "0x1155E0C")]
		private static void FillContextMenu(NodeEditorInputInfo inputInfo, GenericMenu contextMenu, ContextType contextType)
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x1151E14", Offset = "0x1151E14", VA = "0x1151E14")]
		public static void HandleInputEvents(NodeEditorState state)
		{
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x1151F14", Offset = "0x1151F14", VA = "0x1151F14")]
		public static void HandleLateInputEvents(NodeEditorState state)
		{
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x11522B0", Offset = "0x11522B0", VA = "0x11522B0")]
		internal static bool shouldIgnoreInput(NodeEditorState state)
		{
			return default(bool);
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x11561E4", Offset = "0x11561E4", VA = "0x11561E4")]
		[AttributeAttribute(Name = "EventHandlerAttribute", RVA = "0x69F744", Offset = "0x69F744")]
		private static void HandleFocussing(NodeEditorInputInfo inputInfo)
		{
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x115636C", Offset = "0x115636C", VA = "0x115636C")]
		[AttributeAttribute(Name = "EventHandlerAttribute", RVA = "0x69F758", Offset = "0x69F758")]
		private static void HandleSelecting(NodeEditorInputInfo inputInfo)
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x1156488", Offset = "0x1156488", VA = "0x1156488")]
		[AttributeAttribute(Name = "EventHandlerAttribute", RVA = "0x69F770", Offset = "0x69F770")]
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
		[Address(RVA = "0x1155844", Offset = "0x1155844", VA = "0x1155844")]
		public NodeEditorInputInfo(NodeEditorState EditorState)
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x1154778", Offset = "0x1154778", VA = "0x1154778")]
		public NodeEditorInputInfo(string Message, NodeEditorState EditorState)
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x1154938", Offset = "0x1154938", VA = "0x1154938")]
		public void SetAsCurrentEnvironment()
		{
		}
	}
	[Token(Token = "0x20000B2")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x69E5BC", Offset = "0x69E5BC")]
	public class EventHandlerAttribute : Attribute
	{
		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69EE14", Offset = "0x69EE14")]
		private EventType? <handledEvent>k__BackingField;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69EE24", Offset = "0x69EE24")]
		private int <priority>k__BackingField;

		[Token(Token = "0x17000087")]
		public EventType? handledEvent
		{
			[Token(Token = "0x60002D0")]
			[Address(RVA = "0x1141648", Offset = "0x1141648", VA = "0x1141648")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69F788", Offset = "0x69F788")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002D1")]
			[Address(RVA = "0x1141650", Offset = "0x1141650", VA = "0x1141650")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69F798", Offset = "0x69F798")]
			private set
			{
			}
		}

		[Token(Token = "0x17000088")]
		public int priority
		{
			[Token(Token = "0x60002D2")]
			[Address(RVA = "0x1141658", Offset = "0x1141658", VA = "0x1141658")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69F7A8", Offset = "0x69F7A8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002D3")]
			[Address(RVA = "0x1141660", Offset = "0x1141660", VA = "0x1141660")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69F7B8", Offset = "0x69F7B8")]
			private set
			{
			}
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x1141668", Offset = "0x1141668", VA = "0x1141668")]
		public EventHandlerAttribute(EventType eventType, int priorityValue)
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x11416F0", Offset = "0x11416F0", VA = "0x11416F0")]
		public EventHandlerAttribute(int priorityValue)
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x1141720", Offset = "0x1141720", VA = "0x1141720")]
		public EventHandlerAttribute(EventType eventType)
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x11417A0", Offset = "0x11417A0", VA = "0x11417A0")]
		public EventHandlerAttribute()
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x11417C8", Offset = "0x11417C8", VA = "0x11417C8")]
		internal static bool AssureValidity(MethodInfo method, EventHandlerAttribute attr)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000B3")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x69E5F4", Offset = "0x69E5F4")]
	public class HotkeyAttribute : Attribute
	{
		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69EE34", Offset = "0x69EE34")]
		private KeyCode <handledHotKey>k__BackingField;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69EE44", Offset = "0x69EE44")]
		private EventModifiers? <modifiers>k__BackingField;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69EE54", Offset = "0x69EE54")]
		private EventType? <limitingEventType>k__BackingField;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69EE64", Offset = "0x69EE64")]
		private int <priority>k__BackingField;

		[Token(Token = "0x17000089")]
		public KeyCode handledHotKey
		{
			[Token(Token = "0x60002D9")]
			[Address(RVA = "0x1145F34", Offset = "0x1145F34", VA = "0x1145F34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69F7C8", Offset = "0x69F7C8")]
			get
			{
				return default(KeyCode);
			}
			[Token(Token = "0x60002DA")]
			[Address(RVA = "0x1145F3C", Offset = "0x1145F3C", VA = "0x1145F3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69F7D8", Offset = "0x69F7D8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700008A")]
		public EventModifiers? modifiers
		{
			[Token(Token = "0x60002DB")]
			[Address(RVA = "0x1145F44", Offset = "0x1145F44", VA = "0x1145F44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69F7E8", Offset = "0x69F7E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002DC")]
			[Address(RVA = "0x1145F4C", Offset = "0x1145F4C", VA = "0x1145F4C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69F7F8", Offset = "0x69F7F8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700008B")]
		public EventType? limitingEventType
		{
			[Token(Token = "0x60002DD")]
			[Address(RVA = "0x1145F54", Offset = "0x1145F54", VA = "0x1145F54")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69F808", Offset = "0x69F808")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002DE")]
			[Address(RVA = "0x1145F5C", Offset = "0x1145F5C", VA = "0x1145F5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69F818", Offset = "0x69F818")]
			private set
			{
			}
		}

		[Token(Token = "0x1700008C")]
		public int priority
		{
			[Token(Token = "0x60002DF")]
			[Address(RVA = "0x1145F64", Offset = "0x1145F64", VA = "0x1145F64")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69F828", Offset = "0x69F828")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002E0")]
			[Address(RVA = "0x1145F6C", Offset = "0x1145F6C", VA = "0x1145F6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69F838", Offset = "0x69F838")]
			private set
			{
			}
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x1145F74", Offset = "0x1145F74", VA = "0x1145F74")]
		public HotkeyAttribute(KeyCode handledKey)
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x1145FB0", Offset = "0x1145FB0", VA = "0x1145FB0")]
		public HotkeyAttribute(KeyCode handledKey, EventModifiers eventModifiers)
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x1146044", Offset = "0x1146044", VA = "0x1146044")]
		public HotkeyAttribute(KeyCode handledKey, EventType LimitEventType)
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x11460D8", Offset = "0x11460D8", VA = "0x11460D8")]
		public HotkeyAttribute(KeyCode handledKey, EventType LimitEventType, int priorityValue)
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x114616C", Offset = "0x114616C", VA = "0x114616C")]
		public HotkeyAttribute(KeyCode handledKey, EventModifiers eventModifiers, EventType LimitEventType)
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x1146234", Offset = "0x1146234", VA = "0x1146234")]
		public HotkeyAttribute(KeyCode handledKey, EventModifiers eventModifiers, EventType LimitEventType, int priorityValue)
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x1146300", Offset = "0x1146300", VA = "0x1146300")]
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
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x69E62C", Offset = "0x69E62C")]
	public class ContextEntryAttribute : Attribute
	{
		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69EE74", Offset = "0x69EE74")]
		private ContextType <contextType>k__BackingField;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69EE84", Offset = "0x69EE84")]
		private string <contextPath>k__BackingField;

		[Token(Token = "0x1700008D")]
		public ContextType contextType
		{
			[Token(Token = "0x60002E8")]
			[Address(RVA = "0x15E878C", Offset = "0x15E878C", VA = "0x15E878C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69F848", Offset = "0x69F848")]
			get
			{
				return default(ContextType);
			}
			[Token(Token = "0x60002E9")]
			[Address(RVA = "0x15E8794", Offset = "0x15E8794", VA = "0x15E8794")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69F858", Offset = "0x69F858")]
			private set
			{
			}
		}

		[Token(Token = "0x1700008E")]
		public string contextPath
		{
			[Token(Token = "0x60002EA")]
			[Address(RVA = "0x15E879C", Offset = "0x15E879C", VA = "0x15E879C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69F868", Offset = "0x69F868")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002EB")]
			[Address(RVA = "0x15E87A4", Offset = "0x15E87A4", VA = "0x15E87A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69F878", Offset = "0x69F878")]
			private set
			{
			}
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x15E87AC", Offset = "0x15E87AC", VA = "0x15E87AC")]
		public ContextEntryAttribute(ContextType type, string path)
		{
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x15E87F0", Offset = "0x15E87F0", VA = "0x15E87F0")]
		internal static bool AssureValidity(MethodInfo method, ContextEntryAttribute attr)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000B6")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x69E640", Offset = "0x69E640")]
	public class ContextFillerAttribute : Attribute
	{
		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69EE94", Offset = "0x69EE94")]
		private ContextType <contextType>k__BackingField;

		[Token(Token = "0x1700008F")]
		public ContextType contextType
		{
			[Token(Token = "0x60002EE")]
			[Address(RVA = "0x15E8A54", Offset = "0x15E8A54", VA = "0x15E8A54")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69F888", Offset = "0x69F888")]
			get
			{
				return default(ContextType);
			}
			[Token(Token = "0x60002EF")]
			[Address(RVA = "0x15E8A5C", Offset = "0x15E8A5C", VA = "0x15E8A5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69F898", Offset = "0x69F898")]
			private set
			{
			}
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x15E8A64", Offset = "0x15E8A64", VA = "0x15E8A64")]
		public ContextFillerAttribute(ContextType type)
		{
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x15E8A90", Offset = "0x15E8A90", VA = "0x15E8A90")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69E654", Offset = "0x69E654")]
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
			[Address(RVA = "0x17E7820", Offset = "0x17E7820", VA = "0x17E7820")]
			public <>c()
			{
			}

			[Token(Token = "0x6000303")]
			[Address(RVA = "0x17E7828", Offset = "0x17E7828", VA = "0x17E7828")]
			internal string <GetSceneSaves>b__2_0(NodeCanvasSceneSave save)
			{
				return null;
			}

			[Token(Token = "0x6000304")]
			[Address(RVA = "0x17E784C", Offset = "0x17E784C", VA = "0x17E784C")]
			internal ScriptableObject <AddClonedSOs>b__12_0(ScriptableObject so)
			{
				return null;
			}
		}

		[Token(Token = "0x20000B9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69E664", Offset = "0x69E664")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x40003EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string saveName;

			[Token(Token = "0x6000305")]
			[Address(RVA = "0x17E78D8", Offset = "0x17E78D8", VA = "0x17E78D8")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x6000306")]
			[Address(RVA = "0x17E78E0", Offset = "0x17E78E0", VA = "0x17E78E0")]
			internal bool <FindSceneSave>b__0(NodeCanvasSceneSave save)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000BA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69E674", Offset = "0x69E674")]
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
			[Address(RVA = "0x17E791C", Offset = "0x17E791C", VA = "0x17E791C")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x6000308")]
			[Address(RVA = "0x17E7924", Offset = "0x17E7924", VA = "0x17E7924")]
			internal ScriptableObject <CreateWorkingCopy>b__0(ScriptableObject so)
			{
				return null;
			}

			[Token(Token = "0x6000309")]
			[Address(RVA = "0x17E7980", Offset = "0x17E7980", VA = "0x17E7980")]
			internal ScriptableObject <CreateWorkingCopy>b__1(ScriptableObject so)
			{
				return null;
			}
		}

		[Token(Token = "0x20000BB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69E684", Offset = "0x69E684")]
		private sealed class <>c__DisplayClass15_0
		{
			[Token(Token = "0x40003F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string stateName;

			[Token(Token = "0x600030A")]
			[Address(RVA = "0x17E7898", Offset = "0x17E7898", VA = "0x17E7898")]
			public <>c__DisplayClass15_0()
			{
			}

			[Token(Token = "0x600030B")]
			[Address(RVA = "0x17E78A0", Offset = "0x17E78A0", VA = "0x17E78A0")]
			internal bool <ExtractEditorState>b__0(NodeEditorState s)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static GameObject sceneSaveHolder;

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x11565A8", Offset = "0x11565A8", VA = "0x11565A8")]
		private static void FetchSceneSaveHolder()
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x1156718", Offset = "0x1156718", VA = "0x1156718")]
		public static string[] GetSceneSaves()
		{
			return null;
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x11568A4", Offset = "0x11568A4", VA = "0x11568A4")]
		private static NodeCanvasSceneSave FindSceneSave(string saveName)
		{
			return null;
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x1156A00", Offset = "0x1156A00", VA = "0x1156A00")]
		public static void SaveSceneNodeCanvas(string saveName, ref NodeCanvas nodeCanvas, bool createWorkingCopy)
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x1157408", Offset = "0x1157408", VA = "0x1157408")]
		public static NodeCanvas LoadSceneNodeCanvas(string saveName, bool createWorkingCopy)
		{
			return null;
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x115750C", Offset = "0x115750C", VA = "0x115750C")]
		public static void SaveNodeCanvas(string path, NodeCanvas nodeCanvas, bool createWorkingCopy, bool forceNew = false)
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x1157598", Offset = "0x1157598", VA = "0x1157598")]
		public static NodeCanvas LoadNodeCanvas(string path, bool createWorkingCopy)
		{
			return null;
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x1157734", Offset = "0x1157734", VA = "0x1157734")]
		public static void Uncompress(ref NodeCanvas nodeCanvas)
		{
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x1156BA4", Offset = "0x1156BA4", VA = "0x1156BA4")]
		public static NodeCanvas CreateWorkingCopy(NodeCanvas nodeCanvas, bool editorStates)
		{
			return null;
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x1157B30", Offset = "0x1157B30", VA = "0x1157B30")]
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
		[Address(RVA = "0x11579C0", Offset = "0x11579C0", VA = "0x11579C0")]
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
		[Address(RVA = "0x1157DD4", Offset = "0x1157DD4", VA = "0x1157DD4")]
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
			[Address(RVA = "0x1151DEC", Offset = "0x1151DEC", VA = "0x1151DEC")]
			get
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x1158050", Offset = "0x1158050", VA = "0x1158050")]
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
			[Address(RVA = "0x11584C8", Offset = "0x11584C8", VA = "0x11584C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x11580E4", Offset = "0x11580E4", VA = "0x11580E4")]
		public void AssureCanvas()
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x1158578", Offset = "0x1158578", VA = "0x1158578")]
		public NodeEditorUserCache(NodeCanvas loadedCanvas)
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x1158698", Offset = "0x1158698", VA = "0x1158698")]
		public NodeEditorUserCache()
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x11585F0", Offset = "0x11585F0", VA = "0x11585F0")]
		public void SetCanvas(NodeCanvas canvas)
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x11586FC", Offset = "0x11586FC", VA = "0x11586FC")]
		public void SaveSceneNodeCanvas(string path)
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x1158840", Offset = "0x1158840", VA = "0x1158840")]
		public void LoadSceneNodeCanvas(string path)
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x115896C", Offset = "0x115896C", VA = "0x115896C")]
		public void SaveNodeCanvas(string path)
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x1158A0C", Offset = "0x1158A0C", VA = "0x1158A0C")]
		public void LoadNodeCanvas(string path)
		{
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x11581B0", Offset = "0x11581B0", VA = "0x11581B0")]
		public void NewNodeCanvas([Optional] Type canvasType)
		{
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x1158398", Offset = "0x1158398", VA = "0x1158398")]
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
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x69EEA4", Offset = "0x69EEA4")]
		public string typeID;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TypeData _typeData;

		[Token(Token = "0x17000092")]
		protected override NodeSide defaultSide
		{
			[Token(Token = "0x6000319")]
			[Address(RVA = "0x1158B48", Offset = "0x1158B48", VA = "0x1158B48", Slot = "5")]
			get
			{
				return default(NodeSide);
			}
		}

		[Token(Token = "0x17000093")]
		internal TypeData typeData
		{
			[Token(Token = "0x600031A")]
			[Address(RVA = "0x1158B50", Offset = "0x1158B50", VA = "0x1158B50")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000094")]
		public bool IsValueNull
		{
			[Token(Token = "0x6000322")]
			[Address(RVA = "0x1158F60", Offset = "0x1158F60", VA = "0x1158F60")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x114C400", Offset = "0x114C400", VA = "0x114C400")]
		public static NodeInput Create(Node nodeBody, string inputName, string inputType)
		{
			return null;
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x114C414", Offset = "0x114C414", VA = "0x114C414")]
		public static NodeInput Create(Node nodeBody, string inputName, string inputType, NodeSide nodeSide)
		{
			return null;
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x114C41C", Offset = "0x114C41C", VA = "0x114C41C")]
		public static NodeInput Create(Node nodeBody, string inputName, string inputType, NodeSide nodeSide, float sidePosition)
		{
			return null;
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x1158D58", Offset = "0x1158D58", VA = "0x1158D58", Slot = "6")]
		public override void Delete()
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x1158E64", Offset = "0x1158E64", VA = "0x1158E64", Slot = "9")]
		protected internal override void CopyScriptableObjects(Func<ScriptableObject, ScriptableObject> replaceSerializableObject)
		{
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x1158F20", Offset = "0x1158F20", VA = "0x1158F20", Slot = "7")]
		protected override void ReloadTexture()
		{
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x1158B74", Offset = "0x1158B74", VA = "0x1158B74")]
		private void CheckType()
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x1158FF4", Offset = "0x1158FF4", VA = "0x1158FF4")]
		public object GetValue()
		{
			return null;
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x1159080", Offset = "0x1159080", VA = "0x1159080")]
		public object GetValue(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x1159128", Offset = "0x1159128", VA = "0x1159128")]
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
		[Address(RVA = "0x114B078", Offset = "0x114B078", VA = "0x114B078")]
		public bool TryApplyConnection(NodeOutput output)
		{
			return default(bool);
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x11591CC", Offset = "0x11591CC", VA = "0x11591CC")]
		public bool CanApplyConnection(NodeOutput output)
		{
			return default(bool);
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x114CC58", Offset = "0x114CC58", VA = "0x114CC58")]
		public void ApplyConnection(NodeOutput output)
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x114ACB4", Offset = "0x114ACB4", VA = "0x114ACB4")]
		public void RemoveConnection()
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x1159380", Offset = "0x1159380", VA = "0x1159380", Slot = "11")]
		public override Node GetNodeAcrossConnection()
		{
			return null;
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x115940C", Offset = "0x115940C", VA = "0x115940C")]
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
			[Address(RVA = "0x115941C", Offset = "0x115941C", VA = "0x115941C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000096")]
		protected virtual NodeSide defaultSide
		{
			[Token(Token = "0x600032F")]
			[Address(RVA = "0x1159488", Offset = "0x1159488", VA = "0x1159488", Slot = "5")]
			get
			{
				return default(NodeSide);
			}
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x1158C80", Offset = "0x1158C80", VA = "0x1158C80")]
		protected void InitBase(Node nodeBody, NodeSide nodeSide, float nodeSidePosition, string knobName)
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x1158DC8", Offset = "0x1158DC8", VA = "0x1158DC8", Slot = "6")]
		public virtual void Delete()
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x1159920", Offset = "0x1159920", VA = "0x1159920")]
		internal void Check()
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x1159490", Offset = "0x1159490", VA = "0x1159490")]
		protected void ReloadKnobTexture()
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x11599D0", Offset = "0x11599D0", VA = "0x11599D0", Slot = "7")]
		protected virtual void ReloadTexture()
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x1159A7C", Offset = "0x1159A7C", VA = "0x1159A7C", Slot = "8")]
		public virtual ScriptableObject[] GetScriptableObjects()
		{
			return null;
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x1159AC4", Offset = "0x1159AC4", VA = "0x1159AC4", Slot = "9")]
		protected internal virtual void CopyScriptableObjects(Func<ScriptableObject, ScriptableObject> replaceSerializableObject)
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x1159AC8", Offset = "0x1159AC8", VA = "0x1159AC8", Slot = "10")]
		public virtual void DrawKnob()
		{
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x1159B68", Offset = "0x1159B68", VA = "0x1159B68")]
		public void DisplayLayout()
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x1159D24", Offset = "0x1159D24", VA = "0x1159D24")]
		public void DisplayLayout(GUIStyle style)
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x1159DAC", Offset = "0x1159DAC", VA = "0x1159DAC")]
		public void DisplayLayout(GUIContent content)
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x1159BFC", Offset = "0x1159BFC", VA = "0x1159BFC")]
		public void DisplayLayout(GUIContent content, GUIStyle style)
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x1159DE8", Offset = "0x1159DE8", VA = "0x1159DE8")]
		public void SetPosition(float position, NodeSide nodeSide)
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x1159E2C", Offset = "0x1159E2C", VA = "0x1159E2C")]
		public void SetPosition(float position)
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x114C338", Offset = "0x114C338", VA = "0x114C338")]
		public void SetPosition()
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x114BC30", Offset = "0x114BC30", VA = "0x114BC30")]
		public Rect GetGUIKnob()
		{
			return default(Rect);
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x11523C0", Offset = "0x11523C0", VA = "0x11523C0")]
		public Rect GetCanvasSpaceKnob()
		{
			return default(Rect);
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x1159E34", Offset = "0x1159E34", VA = "0x1159E34")]
		private Vector2 GetKnobCenter(Vector2 knobSize)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x114BD00", Offset = "0x114BD00", VA = "0x114BD00")]
		public Vector2 GetDirection()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x11599C0", Offset = "0x11599C0", VA = "0x11599C0")]
		private static int getRotationStepsAntiCW(NodeSide sideA, NodeSide sideB)
		{
			return default(int);
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x1159F6C", Offset = "0x1159F6C", VA = "0x1159F6C", Slot = "11")]
		public virtual Node GetNodeAcrossConnection()
		{
			return null;
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x1159414", Offset = "0x1159414", VA = "0x1159414")]
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
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x69EEDC", Offset = "0x69EEDC")]
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
			[Address(RVA = "0x14F3D2C", Offset = "0x14F3D2C", VA = "0x14F3D2C", Slot = "5")]
			get
			{
				return default(NodeSide);
			}
		}

		[Token(Token = "0x17000098")]
		protected override GUIStyle defaultLabelStyle
		{
			[Token(Token = "0x6000347")]
			[Address(RVA = "0x14F3D34", Offset = "0x14F3D34", VA = "0x14F3D34", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000099")]
		internal TypeData typeData
		{
			[Token(Token = "0x6000348")]
			[Address(RVA = "0x14F3E40", Offset = "0x14F3E40", VA = "0x14F3E40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009A")]
		public bool IsValueNull
		{
			[Token(Token = "0x6000350")]
			[Address(RVA = "0x14F428C", Offset = "0x14F428C", VA = "0x14F428C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x14F3F70", Offset = "0x14F3F70", VA = "0x14F3F70")]
		public static NodeOutput Create(Node nodeBody, string outputName, string outputType)
		{
			return null;
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x14F4054", Offset = "0x14F4054", VA = "0x14F4054")]
		public static NodeOutput Create(Node nodeBody, string outputName, string outputType, NodeSide nodeSide)
		{
			return null;
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x14F3F7C", Offset = "0x14F3F7C", VA = "0x14F3F7C")]
		public static NodeOutput Create(Node nodeBody, string outputName, string outputType, NodeSide nodeSide, float sidePosition)
		{
			return null;
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x14F405C", Offset = "0x14F405C", VA = "0x14F405C", Slot = "6")]
		public override void Delete()
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x14F410C", Offset = "0x14F410C", VA = "0x14F410C", Slot = "9")]
		protected internal override void CopyScriptableObjects(Func<ScriptableObject, ScriptableObject> replaceSerializableObject)
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x14F424C", Offset = "0x14F424C", VA = "0x14F424C", Slot = "7")]
		protected override void ReloadTexture()
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x14F3E64", Offset = "0x14F3E64", VA = "0x14F3E64")]
		private void CheckType()
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x14F429C", Offset = "0x14F429C", VA = "0x14F429C")]
		public object GetValue()
		{
			return null;
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x14F42A4", Offset = "0x14F42A4", VA = "0x14F42A4")]
		public object GetValue(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x14F44A8", Offset = "0x14F44A8", VA = "0x14F44A8")]
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
		[Address(RVA = "0x14F461C", Offset = "0x14F461C", VA = "0x14F461C")]
		public void ResetValue()
		{
		}

		[Token(Token = "0x6000357")]
		public static T GetDefault<T>()
		{
			return (T)null;
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x14F4628", Offset = "0x14F4628", VA = "0x14F4628")]
		public static object GetDefault(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x14F4704", Offset = "0x14F4704", VA = "0x14F4704", Slot = "11")]
		public override Node GetNodeAcrossConnection()
		{
			return null;
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x14F477C", Offset = "0x14F477C", VA = "0x14F477C")]
		public NodeOutput()
		{
		}
	}
	[Token(Token = "0x20000C2")]
	public static class NodeTypes
	{
		[Serializable]
		[Token(Token = "0x20000C3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69E694", Offset = "0x69E694")]
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
			[Address(RVA = "0x17E7A40", Offset = "0x17E7A40", VA = "0x17E7A40")]
			public <>c()
			{
			}

			[Token(Token = "0x6000362")]
			[Address(RVA = "0x17E7A48", Offset = "0x17E7A48", VA = "0x17E7A48")]
			internal bool <FetchNodes>b__1_0(Assembly assembly)
			{
				return default(bool);
			}

			[Token(Token = "0x6000363")]
			[Address(RVA = "0x17E7AB0", Offset = "0x17E7AB0", VA = "0x17E7AB0")]
			internal bool <FetchNodes>b__1_1(Type T)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69E6A4", Offset = "0x69E6A4")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x4000424")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string nodeID;

			[Token(Token = "0x6000364")]
			[Address(RVA = "0x17E7B7C", Offset = "0x17E7B7C", VA = "0x17E7B7C")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x6000365")]
			[Address(RVA = "0x17E7B84", Offset = "0x17E7B84", VA = "0x17E7B84")]
			internal bool <getDefaultNode>b__0(Node node)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x20000C5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69E6B4", Offset = "0x69E6B4")]
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
		[Address(RVA = "0x14F4800", Offset = "0x14F4800", VA = "0x14F4800")]
		public static void FetchNodes()
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x14F52E8", Offset = "0x14F52E8", VA = "0x14F52E8")]
		public static NodeData getNodeData(Node node)
		{
			return default(NodeData);
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x14F5378", Offset = "0x14F5378", VA = "0x14F5378")]
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
		[Address(RVA = "0x14F54B0", Offset = "0x14F54B0", VA = "0x14F54B0")]
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
		[Address(RVA = "0x114F2E4", Offset = "0x114F2E4", VA = "0x114F2E4")]
		public NodeData(string name, Type[] limitedCanvasTypes)
		{
		}
	}
	[Token(Token = "0x20000C7")]
	public class NodeAttribute : Attribute
	{
		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69EF14", Offset = "0x69EF14")]
		private bool <hide>k__BackingField;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69EF24", Offset = "0x69EF24")]
		private string <contextText>k__BackingField;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69EF34", Offset = "0x69EF34")]
		private Type[] <limitToCanvasTypes>k__BackingField;

		[Token(Token = "0x1700009B")]
		public bool hide
		{
			[Token(Token = "0x600036A")]
			[Address(RVA = "0x114DA1C", Offset = "0x114DA1C", VA = "0x114DA1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69F8A8", Offset = "0x69F8A8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600036B")]
			[Address(RVA = "0x114DA24", Offset = "0x114DA24", VA = "0x114DA24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69F8B8", Offset = "0x69F8B8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700009C")]
		public string contextText
		{
			[Token(Token = "0x600036C")]
			[Address(RVA = "0x114DA30", Offset = "0x114DA30", VA = "0x114DA30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69F8C8", Offset = "0x69F8C8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600036D")]
			[Address(RVA = "0x114DA38", Offset = "0x114DA38", VA = "0x114DA38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69F8D8", Offset = "0x69F8D8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700009D")]
		public Type[] limitToCanvasTypes
		{
			[Token(Token = "0x600036E")]
			[Address(RVA = "0x114DA40", Offset = "0x114DA40", VA = "0x114DA40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69F8E8", Offset = "0x69F8E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600036F")]
			[Address(RVA = "0x114DA48", Offset = "0x114DA48", VA = "0x114DA48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69F8F8", Offset = "0x69F8F8")]
			private set
			{
			}
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x114DA50", Offset = "0x114DA50", VA = "0x114DA50")]
		public NodeAttribute(bool HideNode, string ReplacedContextText)
		{
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x114DAA8", Offset = "0x114DAA8", VA = "0x114DAA8")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69EF44", Offset = "0x69EF44")]
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
			[Address(RVA = "0x1142DA0", Offset = "0x1142DA0", VA = "0x1142DA0")]
			get
			{
				return default(Rect);
			}
		}

		[Token(Token = "0x1700009F")]
		public static Rect getTopRectScreenSpace
		{
			[Token(Token = "0x6000373")]
			[Address(RVA = "0x1142E0C", Offset = "0x1142E0C", VA = "0x1142E0C")]
			get
			{
				return default(Rect);
			}
		}

		[Token(Token = "0x170000A0")]
		public static List<Rect> currentRectStack
		{
			[Token(Token = "0x6000374")]
			[Address(RVA = "0x1142E78", Offset = "0x1142E78", VA = "0x1142E78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69F908", Offset = "0x69F908")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000375")]
			[Address(RVA = "0x1142EC4", Offset = "0x1142EC4", VA = "0x1142EC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69F918", Offset = "0x69F918")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A1")]
		public static Vector2 getCurrentScale
		{
			[Token(Token = "0x6000378")]
			[Address(RVA = "0x114366C", Offset = "0x114366C", VA = "0x114366C")]
			get
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x1142F18", Offset = "0x1142F18", VA = "0x1142F18")]
		public static void CheckInit()
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x1142F74", Offset = "0x1142F74", VA = "0x1142F74")]
		public static void Init()
		{
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x1143778", Offset = "0x1143778", VA = "0x1143778")]
		public static Vector2 BeginScale(ref Rect rect, Vector2 zoomPivot, float zoom, bool adjustGUILayout)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x1143FAC", Offset = "0x1143FAC", VA = "0x1143FAC")]
		public static void EndScale()
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x1143C1C", Offset = "0x1143C1C", VA = "0x1143C1C")]
		public static void BeginNoClip()
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x11444B4", Offset = "0x11444B4", VA = "0x11444B4")]
		public static void MoveClipsUp(int count)
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x1144278", Offset = "0x1144278", VA = "0x1144278")]
		public static void RestoreClips()
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x11446F4", Offset = "0x11446F4", VA = "0x11446F4")]
		public static void BeginNewLayout()
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x1144844", Offset = "0x1144844", VA = "0x1144844")]
		public static void EndNewLayout()
		{
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x11448A4", Offset = "0x11448A4", VA = "0x11448A4")]
		public static void BeginIgnoreMatrix()
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x11449A4", Offset = "0x11449A4", VA = "0x11449A4")]
		public static void EndIgnoreMatrix()
		{
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x1144B04", Offset = "0x1144B04", VA = "0x1144B04")]
		public static Vector2 Scale(Vector2 pos, Vector2 pivot, Vector2 scale)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x1143F14", Offset = "0x1143F14", VA = "0x1143F14")]
		public static Rect Scale(Rect rect, Vector2 pivot, Vector2 scale)
		{
			return default(Rect);
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x1144B20", Offset = "0x1144B20", VA = "0x1144B20")]
		public static Vector2 ScaledToGUISpace(Vector2 scaledPosition)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x1144C38", Offset = "0x1144C38", VA = "0x1144C38")]
		public static Rect ScaledToGUISpace(Rect scaledRect)
		{
			return default(Rect);
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x1144D00", Offset = "0x1144D00", VA = "0x1144D00")]
		public static Vector2 GUIToScaledSpace(Vector2 guiPosition)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x1143E4C", Offset = "0x1143E4C", VA = "0x1143E4C")]
		public static Rect GUIToScaledSpace(Rect guiRect)
		{
			return default(Rect);
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x1144E18", Offset = "0x1144E18", VA = "0x1144E18")]
		public static Vector2 GUIToScreenSpace(Vector2 guiPosition)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x1144E60", Offset = "0x1144E60", VA = "0x1144E60")]
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
		[Address(RVA = "0x14F7464", Offset = "0x14F7464", VA = "0x14F7464")]
		public static bool HasPopupControl()
		{
			return default(bool);
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x14F74B8", Offset = "0x14F74B8", VA = "0x14F74B8")]
		public static void StartOverlayGUI()
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x14F76C8", Offset = "0x14F76C8", VA = "0x14F76C8")]
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
			[Address(RVA = "0x17E8350", Offset = "0x17E8350", VA = "0x17E8350")]
			public MenuItem()
			{
			}

			[Token(Token = "0x60003A3")]
			[Address(RVA = "0x17E837C", Offset = "0x17E837C", VA = "0x17E837C")]
			public MenuItem(string _path, GUIContent _content, bool _group)
			{
			}

			[Token(Token = "0x60003A4")]
			[Address(RVA = "0x17E8460", Offset = "0x17E8460", VA = "0x17E8460")]
			public MenuItem(string _path, GUIContent _content, MenuFunction _func)
			{
			}

			[Token(Token = "0x60003A5")]
			[Address(RVA = "0x17E84C4", Offset = "0x17E84C4", VA = "0x17E84C4")]
			public MenuItem(string _path, GUIContent _content, MenuFunctionData _func, object _userData)
			{
			}

			[Token(Token = "0x60003A6")]
			[Address(RVA = "0x17E8544", Offset = "0x17E8544", VA = "0x17E8544")]
			public void Execute()
			{
			}
		}

		[Token(Token = "0x20000CE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69E6C4", Offset = "0x69E6C4")]
		private sealed class <>c__DisplayClass21_0
		{
			[Token(Token = "0x400044B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string folderPath;

			[Token(Token = "0x60003A7")]
			[Address(RVA = "0x17E7BC4", Offset = "0x17E7BC4", VA = "0x17E7BC4")]
			public <>c__DisplayClass21_0()
			{
			}

			[Token(Token = "0x60003A8")]
			[Address(RVA = "0x17E7BCC", Offset = "0x17E7BCC", VA = "0x17E7BCC")]
			internal bool <AddHierarchy>b__0(MenuItem item)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000CF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69E6D4", Offset = "0x69E6D4")]
		private sealed class <>c__DisplayClass21_1
		{
			[Token(Token = "0x400044C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string folder;

			[Token(Token = "0x60003A9")]
			[Address(RVA = "0x17E7C28", Offset = "0x17E7C28", VA = "0x17E7C28")]
			public <>c__DisplayClass21_1()
			{
			}

			[Token(Token = "0x60003AA")]
			[Address(RVA = "0x17E7C30", Offset = "0x17E7C30", VA = "0x17E7C30")]
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
			[Address(RVA = "0x14F85A0", Offset = "0x14F85A0", VA = "0x14F85A0")]
			get
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x14F7AB0", Offset = "0x14F7AB0", VA = "0x14F7AB0")]
		public PopupMenu()
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x14F7B38", Offset = "0x14F7B38", VA = "0x14F7B38")]
		public void SetupGUI()
		{
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x14F8318", Offset = "0x14F8318", VA = "0x14F8318")]
		public void Show(Vector2 pos, float MinWidth = 40f)
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x14F85AC", Offset = "0x14F85AC", VA = "0x14F85AC")]
		public void AddItem(GUIContent content, bool on, MenuFunctionData func, object userData)
		{
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x14F8C04", Offset = "0x14F8C04", VA = "0x14F8C04")]
		public void AddItem(GUIContent content, bool on, MenuFunction func)
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x14F8CDC", Offset = "0x14F8CDC", VA = "0x14F8CDC")]
		public void AddSeparator(string path)
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x14F868C", Offset = "0x14F868C", VA = "0x14F868C")]
		private MenuItem AddHierarchy(ref GUIContent content, out string path)
		{
			return null;
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x14F7560", Offset = "0x14F7560", VA = "0x14F7560")]
		public void Draw()
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x14F8DC4", Offset = "0x14F8DC4", VA = "0x14F8DC4")]
		private bool DrawGroup(Rect pos, List<MenuItem> menuItems)
		{
			return default(bool);
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x14F9164", Offset = "0x14F9164", VA = "0x14F9164")]
		private void DrawItem(MenuItem item, Rect groupRect)
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x14F90B4", Offset = "0x14F90B4", VA = "0x14F90B4")]
		private static Rect extendRect(Rect rect, Vector2 extendValue)
		{
			return default(Rect);
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x14F83CC", Offset = "0x14F83CC", VA = "0x14F83CC")]
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
			[Address(RVA = "0x11451DC", Offset = "0x11451DC", VA = "0x11451DC")]
			get
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x1145234", Offset = "0x1145234", VA = "0x1145234")]
		public GenericMenu()
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x11452BC", Offset = "0x11452BC", VA = "0x11452BC")]
		public void ShowAsContext()
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x1145338", Offset = "0x1145338", VA = "0x1145338")]
		public void Show(Vector2 pos, float MinWidth = 40f)
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x11453C0", Offset = "0x11453C0", VA = "0x11453C0")]
		public void AddItem(GUIContent content, bool on, PopupMenu.MenuFunctionData func, object userData)
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x1145448", Offset = "0x1145448", VA = "0x1145448")]
		public void AddItem(GUIContent content, bool on, PopupMenu.MenuFunction func)
		{
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x11454C0", Offset = "0x11454C0", VA = "0x11454C0")]
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
			[Address(RVA = "0x14FB75C", Offset = "0x14FB75C", VA = "0x14FB75C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x14FB828", Offset = "0x14FB828", VA = "0x14FB828")]
		public static Rect PrefixLabel(Rect totalPos, GUIContent label, GUIStyle style)
		{
			return default(Rect);
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x14FBAE8", Offset = "0x14FBAE8", VA = "0x14FBAE8")]
		public static Rect PrefixLabel(Rect totalPos, float percentage, GUIContent label, GUIStyle style)
		{
			return default(Rect);
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x14FBCF4", Offset = "0x14FBCF4", VA = "0x14FBCF4")]
		private static Rect IndentedRect(Rect source)
		{
			return default(Rect);
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x14FBA50", Offset = "0x14FBA50", VA = "0x14FBA50")]
		private static float getLabelWidth()
		{
			return default(float);
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x14FBDF0", Offset = "0x14FBDF0", VA = "0x14FBDF0")]
		private static float getFieldWidth()
		{
			return default(float);
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x14FBE88", Offset = "0x14FBE88", VA = "0x14FBE88")]
		private static Rect GetFieldRect(GUIContent label, GUIStyle style, params GUILayoutOption[] options)
		{
			return default(Rect);
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x14FBFF4", Offset = "0x14FBFF4", VA = "0x14FBFF4")]
		private static Rect GetSliderRect(GUIContent label, GUIStyle style, params GUILayoutOption[] options)
		{
			return default(Rect);
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x14FC16C", Offset = "0x14FC16C", VA = "0x14FC16C")]
		private static Rect GetSliderRect(Rect sliderRect)
		{
			return default(Rect);
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x14FC258", Offset = "0x14FC258", VA = "0x14FC258")]
		private static Rect GetSliderFieldRect(Rect sliderRect)
		{
			return default(Rect);
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x14FC350", Offset = "0x14FC350", VA = "0x14FC350")]
		public static void Space()
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x14FC3AC", Offset = "0x14FC3AC", VA = "0x14FC3AC")]
		public static void Space(float pixels)
		{
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x14FC41C", Offset = "0x14FC41C", VA = "0x14FC41C")]
		public static void Seperator()
		{
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x14F9628", Offset = "0x14F9628", VA = "0x14F9628")]
		public static void Seperator(Rect rect)
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x14FC558", Offset = "0x14FC558", VA = "0x14FC558")]
		private static void setupSeperator()
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x14FC6F4", Offset = "0x14FC6F4", VA = "0x14FC6F4")]
		public static void BeginChangeCheck()
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x14FC7C4", Offset = "0x14FC7C4", VA = "0x14FC7C4")]
		public static bool EndChangeCheck()
		{
			return default(bool);
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x14FCA30", Offset = "0x14FCA30", VA = "0x14FCA30")]
		public static bool Foldout(bool foldout, string content, params GUILayoutOption[] options)
		{
			return default(bool);
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x14FCBA0", Offset = "0x14FCBA0", VA = "0x14FCBA0")]
		public static bool Foldout(bool foldout, string content, GUIStyle style, params GUILayoutOption[] options)
		{
			return default(bool);
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x14FCAD4", Offset = "0x14FCAD4", VA = "0x14FCAD4")]
		public static bool Foldout(bool foldout, GUIContent content, params GUILayoutOption[] options)
		{
			return default(bool);
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x14FCC58", Offset = "0x14FCC58", VA = "0x14FCC58")]
		public static bool Foldout(bool foldout, GUIContent content, GUIStyle style, params GUILayoutOption[] options)
		{
			return default(bool);
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x14FCC64", Offset = "0x14FCC64", VA = "0x14FCC64")]
		public static bool Toggle(bool toggle, string content, params GUILayoutOption[] options)
		{
			return default(bool);
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x14FCDD4", Offset = "0x14FCDD4", VA = "0x14FCDD4")]
		public static bool Toggle(bool toggle, string content, GUIStyle style, params GUILayoutOption[] options)
		{
			return default(bool);
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x14FCD08", Offset = "0x14FCD08", VA = "0x14FCD08")]
		public static bool Toggle(bool toggle, GUIContent content, params GUILayoutOption[] options)
		{
			return default(bool);
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x14FCE8C", Offset = "0x14FCE8C", VA = "0x14FCE8C")]
		public static bool Toggle(bool toggle, GUIContent content, GUIStyle style, params GUILayoutOption[] options)
		{
			return default(bool);
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x14FCE98", Offset = "0x14FCE98", VA = "0x14FCE98")]
		public static string TextField(GUIContent label, string text, GUIStyle style, params GUILayoutOption[] options)
		{
			return null;
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x14FCFD4", Offset = "0x14FCFD4", VA = "0x14FCFD4")]
		public static int OptionSlider(GUIContent label, int selected, string[] selectableOptions, params GUILayoutOption[] options)
		{
			return default(int);
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x14FD0AC", Offset = "0x14FD0AC", VA = "0x14FD0AC")]
		public static int OptionSlider(GUIContent label, int selected, string[] selectableOptions, GUIStyle style, params GUILayoutOption[] options)
		{
			return default(int);
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x14FD274", Offset = "0x14FD274", VA = "0x14FD274")]
		public static int MathPowerSlider(GUIContent label, int baseValue, int value, int minPow, int maxPow, params GUILayoutOption[] options)
		{
			return default(int);
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x14FD3A4", Offset = "0x14FD3A4", VA = "0x14FD3A4")]
		public static int MathPowerSliderRaw(GUIContent label, int baseValue, int power, int minPow, int maxPow, params GUILayoutOption[] options)
		{
			return default(int);
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x14FD570", Offset = "0x14FD570", VA = "0x14FD570")]
		public static int IntSlider(string label, int value, int minValue, int maxValue, params GUILayoutOption[] options)
		{
			return default(int);
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x14FD888", Offset = "0x14FD888", VA = "0x14FD888")]
		public static int IntSlider(GUIContent label, int value, int minValue, int maxValue, params GUILayoutOption[] options)
		{
			return default(int);
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x14FD938", Offset = "0x14FD938", VA = "0x14FD938")]
		public static int IntSlider(int value, int minValue, int maxValue, params GUILayoutOption[] options)
		{
			return default(int);
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x14FDA20", Offset = "0x14FDA20", VA = "0x14FDA20")]
		public static int IntField(string label, int value, params GUILayoutOption[] options)
		{
			return default(int);
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x14FDC0C", Offset = "0x14FDC0C", VA = "0x14FDC0C")]
		public static int IntField(GUIContent label, int value, params GUILayoutOption[] options)
		{
			return default(int);
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x14FDCA4", Offset = "0x14FDCA4", VA = "0x14FDCA4")]
		public static int IntField(int value, params GUILayoutOption[] options)
		{
			return default(int);
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x14FDDEC", Offset = "0x14FDDEC", VA = "0x14FDDEC")]
		public static float Slider(float value, float minValue, float maxValue, params GUILayoutOption[] options)
		{
			return default(float);
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x14FDEB4", Offset = "0x14FDEB4", VA = "0x14FDEB4")]
		public static float Slider(string label, float value, float minValue, float maxValue, params GUILayoutOption[] options)
		{
			return default(float);
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x14FD64C", Offset = "0x14FD64C", VA = "0x14FD64C")]
		public static float Slider(GUIContent label, float value, float minValue, float maxValue, params GUILayoutOption[] options)
		{
			return default(float);
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x14FE394", Offset = "0x14FE394", VA = "0x14FE394")]
		public static float FloatField(string label, float value, params GUILayoutOption[] fieldOptions)
		{
			return default(float);
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x14FDAE4", Offset = "0x14FDAE4", VA = "0x14FDAE4")]
		public static float FloatField(GUIContent label, float value, params GUILayoutOption[] options)
		{
			return default(float);
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x14FDD34", Offset = "0x14FDD34", VA = "0x14FDD34")]
		public static float FloatField(float value, params GUILayoutOption[] options)
		{
			return default(float);
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x14FDF78", Offset = "0x14FDF78", VA = "0x14FDF78")]
		public static float FloatField(Rect pos, float value, params GUILayoutOption[] options)
		{
			return default(float);
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x14FE440", Offset = "0x14FE440", VA = "0x14FE440")]
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
		[Address(RVA = "0x14FE690", Offset = "0x14FE690", VA = "0x14FE690")]
		public static Enum EnumPopup(Enum selected)
		{
			return null;
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x14FE878", Offset = "0x14FE878", VA = "0x14FE878")]
		public static Enum EnumPopup(string label, Enum selected)
		{
			return null;
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x14FE730", Offset = "0x14FE730", VA = "0x14FE730")]
		public static Enum EnumPopup(GUIContent label, Enum selected)
		{
			return null;
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x14FE914", Offset = "0x14FE914", VA = "0x14FE914")]
		public static int Popup(GUIContent label, int selected, string[] displayedOptions)
		{
			return default(int);
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x14FEAF0", Offset = "0x14FEAF0", VA = "0x14FEAF0")]
		public static int Popup(string label, int selected, string[] displayedOptions)
		{
			return default(int);
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x14FEC0C", Offset = "0x14FEC0C", VA = "0x14FEC0C")]
		public static int Popup(int selected, string[] displayedOptions)
		{
			return default(int);
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x14FEC84", Offset = "0x14FEC84", VA = "0x14FEC84")]
		public static void DrawTexture(Texture texture, int texSize, GUIStyle style, params GUILayoutOption[] options)
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x14FED28", Offset = "0x14FED28", VA = "0x14FED28")]
		public static void DrawTexture(Texture texture, int texSize, GUIStyle style, int shuffleRed, int shuffleGreen, int shuffleBlue, int shuffleAlpha, params GUILayoutOption[] options)
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x14FF198", Offset = "0x14FF198", VA = "0x14FF198")]
		private static void SetupLineMat(Texture tex, Color col)
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x14FF4C0", Offset = "0x14FF4C0", VA = "0x14FF4C0")]
		public static void DrawBezier(Vector2 startPos, Vector2 endPos, Vector2 startTan, Vector2 endTan, Color col, Texture2D tex, float width = 1f)
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x14FF914", Offset = "0x14FF914", VA = "0x14FF914")]
		public static void DrawBezier(Vector2 startPos, Vector2 endPos, Vector2 startTan, Vector2 endTan, Color col, Texture2D tex, int segmentCount, float width)
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x14FFB8C", Offset = "0x14FFB8C", VA = "0x14FFB8C")]
		public static void DrawPolygonLine(Vector2[] points, Color col, Texture2D tex, float width = 1f)
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x14FF640", Offset = "0x14FF640", VA = "0x14FF640")]
		private static int CalculateBezierSegmentCount(Vector2 startPos, Vector2 endPos, Vector2 startTan, Vector2 endTan)
		{
			return default(int);
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x1500588", Offset = "0x1500588", VA = "0x1500588")]
		private static Vector2 CalculateLinePerpendicular(Vector2 startPos, Vector2 endPos)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x15004D8", Offset = "0x15004D8", VA = "0x15004D8")]
		private static Vector2 CalculatePointPerpendicular(Vector2 prevPos, Vector2 pointPos, Vector2 nextPos)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x14FFB20", Offset = "0x14FFB20", VA = "0x14FFB20")]
		private static Vector2 GetBezierPoint(float t, Vector2 startPos, Vector2 endPos, Vector2 startTan, Vector2 endTan)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x15005B8", Offset = "0x15005B8", VA = "0x15005B8")]
		private static void DrawLineSegment(Vector2 point, Vector2 perpendicular)
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x14FFFE4", Offset = "0x14FFFE4", VA = "0x14FFFE4")]
		public static void DrawLine(Vector2 startPos, Vector2 endPos, Color col, Texture2D tex, float width = 1f)
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x150062C", Offset = "0x150062C", VA = "0x150062C")]
		private static bool SegmentRectIntersection(Rect bounds, ref Vector2 p0, ref Vector2 p1)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x1500198", Offset = "0x1500198", VA = "0x1500198")]
		private static bool SegmentRectIntersection(Rect bounds, ref Vector2 p0, ref Vector2 p1, out bool clippedP0, out bool clippedP1)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x15006E4", Offset = "0x15006E4", VA = "0x15006E4")]
		private static bool ClipTest(float p, float q, ref float t0, ref float t1)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x14F7EA4", Offset = "0x14F7EA4", VA = "0x14F7EA4")]
		public static Texture2D ColorToTex(int pxSize, Color col)
		{
			return null;
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x150074C", Offset = "0x150074C", VA = "0x150074C")]
		public static Texture2D Tint(Texture2D tex, Color color)
		{
			return null;
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x15008F4", Offset = "0x15008F4", VA = "0x15008F4")]
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
			[Address(RVA = "0x17E8800", Offset = "0x17E8800", VA = "0x17E8800")]
			public MemoryTexture(string texPath, Texture2D tex, params string[] mods)
			{
			}
		}

		[Token(Token = "0x20000D4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69E6F4", Offset = "0x69E6F4")]
		private sealed class <>c__DisplayClass6_0
		{
			[Token(Token = "0x400045E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string texPath;

			[Token(Token = "0x6000408")]
			[Address(RVA = "0x17E8748", Offset = "0x17E8748", VA = "0x17E8748")]
			public <>c__DisplayClass6_0()
			{
			}

			[Token(Token = "0x6000409")]
			[Address(RVA = "0x17E8750", Offset = "0x17E8750", VA = "0x17E8750")]
			internal bool <LoadTexture>b__0(MemoryTexture memTex)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000D5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69E704", Offset = "0x69E704")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x400045F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Texture2D tex;

			[Token(Token = "0x600040A")]
			[Address(RVA = "0x17E8774", Offset = "0x17E8774", VA = "0x17E8774")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x600040B")]
			[Address(RVA = "0x17E877C", Offset = "0x17E877C", VA = "0x17E877C")]
			internal bool <FindInMemory>b__0(MemoryTexture memTex)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000D6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69E714", Offset = "0x69E714")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x4000460")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string texturePath;

			[Token(Token = "0x600040C")]
			[Address(RVA = "0x17E8568", Offset = "0x17E8568", VA = "0x17E8568")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x600040D")]
			[Address(RVA = "0x17E8570", Offset = "0x17E8570", VA = "0x17E8570")]
			internal bool <HasInMemory>b__0(MemoryTexture memTex)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000D7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69E724", Offset = "0x69E724")]
		private sealed class <>c__DisplayClass11_0
		{
			[Token(Token = "0x4000461")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string texturePath;

			[Token(Token = "0x600040E")]
			[Address(RVA = "0x17E8594", Offset = "0x17E8594", VA = "0x17E8594")]
			public <>c__DisplayClass11_0()
			{
			}

			[Token(Token = "0x600040F")]
			[Address(RVA = "0x17E859C", Offset = "0x17E859C", VA = "0x17E859C")]
			internal bool <GetMemoryTexture>b__0(MemoryTexture memTex)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000D8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69E734", Offset = "0x69E734")]
		private sealed class <>c__DisplayClass13_0
		{
			[Token(Token = "0x4000462")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string[] modsB;

			[Token(Token = "0x4000463")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string[] modsA;

			[Token(Token = "0x6000410")]
			[Address(RVA = "0x17E85C0", Offset = "0x17E85C0", VA = "0x17E85C0")]
			public <>c__DisplayClass13_0()
			{
			}

			[Token(Token = "0x6000411")]
			[Address(RVA = "0x17E85C8", Offset = "0x17E85C8", VA = "0x17E85C8")]
			internal bool <EqualModifications>b__0(string mod)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000D9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69E744", Offset = "0x69E744")]
		private sealed class <>c__DisplayClass13_1
		{
			[Token(Token = "0x4000464")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string mod;

			[Token(Token = "0x6000412")]
			[Address(RVA = "0x17E8728", Offset = "0x17E8728", VA = "0x17E8728")]
			public <>c__DisplayClass13_1()
			{
			}

			[Token(Token = "0x6000413")]
			[Address(RVA = "0x17E8730", Offset = "0x17E8730", VA = "0x17E8730")]
			internal bool <EqualModifications>b__1(string oMod)
			{
				return default(bool);
			}

			[Token(Token = "0x6000414")]
			[Address(RVA = "0x17E873C", Offset = "0x17E873C", VA = "0x17E873C")]
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
		[Address(RVA = "0x1501428", Offset = "0x1501428", VA = "0x1501428")]
		public static void SetDefaultResourcePath(string defaultResourcePath)
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x1501494", Offset = "0x1501494", VA = "0x1501494")]
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
		[Address(RVA = "0x14F7F94", Offset = "0x14F7F94", VA = "0x14F7F94")]
		public static Texture2D LoadTexture(string texPath)
		{
			return null;
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x15016A0", Offset = "0x15016A0", VA = "0x15016A0")]
		public static Texture2D GetTintedTexture(string texPath, Color col)
		{
			return null;
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x1501570", Offset = "0x1501570", VA = "0x1501570")]
		public static void AddTextureToMemory(string texturePath, Texture2D texture, params string[] modifications)
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x1501A20", Offset = "0x1501A20", VA = "0x1501A20")]
		public static MemoryTexture FindInMemory(Texture2D tex)
		{
			return null;
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x1501BB8", Offset = "0x1501BB8", VA = "0x1501BB8")]
		public static bool HasInMemory(string texturePath, params string[] modifications)
		{
			return default(bool);
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x1501EB8", Offset = "0x1501EB8", VA = "0x1501EB8")]
		public static MemoryTexture GetMemoryTexture(string texturePath, params string[] modifications)
		{
			return null;
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x15019A4", Offset = "0x15019A4", VA = "0x15019A4")]
		public static Texture2D GetTexture(string texturePath, params string[] modifications)
		{
			return null;
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x1501D78", Offset = "0x1501D78", VA = "0x1501D78")]
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
			[Address(RVA = "0x17E8864", Offset = "0x17E8864", VA = "0x17E8864")]
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
		[Address(RVA = "0x1502450", Offset = "0x1502450", VA = "0x1502450")]
		public static void Generate(Texture2D source, Texture2D destination, float maxInside, float maxOutside, float postProcessDistance, RGBFillMode rgbMode)
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x1502C2C", Offset = "0x1502C2C", VA = "0x1502C2C")]
		private static void ComputeEdgeGradients()
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x15036E4", Offset = "0x15036E4", VA = "0x15036E4")]
		private static float ApproximateEdgeDelta(float gx, float gy, float a)
		{
			return default(float);
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x15037FC", Offset = "0x15037FC", VA = "0x15037FC")]
		private static void UpdateDistance(Pixel p, int x, int y, int oX, int oY)
		{
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x1502EC0", Offset = "0x1502EC0", VA = "0x1502EC0")]
		private static void GenerateDistanceTransform()
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x15034FC", Offset = "0x15034FC", VA = "0x15034FC")]
		private static void PostProcess(float maxDistance)
		{
		}
	}
	[Token(Token = "0x20000DD")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x69E754", Offset = "0x69E754")]
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
			[Address(RVA = "0x17E2F64", Offset = "0x17E2F64", VA = "0x17E2F64")]
			get
			{
				return null;
			}
			[Token(Token = "0x600041D")]
			[Address(RVA = "0x17E2F6C", Offset = "0x17E2F6C", VA = "0x17E2F6C")]
			set
			{
			}
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x17E301C", Offset = "0x17E301C", VA = "0x17E301C")]
		public Material GetModifiedMaterial(Material baseMaterial)
		{
			return null;
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x17E3140", Offset = "0x17E3140", VA = "0x17E3140")]
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
			[Address(RVA = "0x15E2454", Offset = "0x15E2454", VA = "0x15E2454")]
			set
			{
			}
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x15E24FC", Offset = "0x15E24FC", VA = "0x15E24FC")]
		public CameraDistance()
		{
		}
	}
	[Token(Token = "0x20000DF")]
	public class CursorSpotlight : MonoBehaviour
	{
		[Token(Token = "0x6000422")]
		[Address(RVA = "0x15EA300", Offset = "0x15EA300", VA = "0x15EA300")]
		private void Update()
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x15EA3A4", Offset = "0x15EA3A4", VA = "0x15EA3A4")]
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
		[Address(RVA = "0x1149890", Offset = "0x1149890", VA = "0x1149890")]
		private void Start()
		{
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x11498CC", Offset = "0x11498CC", VA = "0x11498CC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x11499DC", Offset = "0x11499DC", VA = "0x11499DC")]
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
			[Address(RVA = "0x15023E0", Offset = "0x15023E0", VA = "0x15023E0")]
			set
			{
			}
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x15023E8", Offset = "0x15023E8", VA = "0x15023E8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x1502440", Offset = "0x1502440", VA = "0x1502440")]
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
			[Address(RVA = "0x150B84C", Offset = "0x150B84C", VA = "0x150B84C")]
			set
			{
			}
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x150B8A8", Offset = "0x150B8A8", VA = "0x150B8A8")]
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
			[Address(RVA = "0x150BCB8", Offset = "0x150BCB8", VA = "0x150BCB8")]
			set
			{
			}
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x150BD10", Offset = "0x150BD10", VA = "0x150BD10")]
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
		[Address(RVA = "0x150C95C", Offset = "0x150C95C", VA = "0x150C95C")]
		private void Start()
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x150C9AC", Offset = "0x150C9AC", VA = "0x150C9AC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x150CA0C", Offset = "0x150CA0C", VA = "0x150CA0C")]
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
		[Address(RVA = "0x17E253C", Offset = "0x17E253C", VA = "0x17E253C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x17E25C8", Offset = "0x17E25C8", VA = "0x17E25C8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x17E2690", Offset = "0x17E2690", VA = "0x17E2690")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x17E2718", Offset = "0x17E2718", VA = "0x17E2718")]
		public Twinkle()
		{
		}
	}
}
