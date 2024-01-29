using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using AOT;
using Cinemachine;
using DG.Tweening;
using FMOD;
using FMOD.Studio;
using FMODUnity;
using Il2CppDummyDll;
using Melanchall.DryWetMidi.Interaction;
using Oculus.Interaction;
using Oculus.Interaction.HandGrab;
using Oculus.Interaction.Input;
using Oculus.Platform;
using Oculus.Platform.Models;
using TMPro;
using TaikoFrenzy.Audio;
using TaikoFrenzy.Gameplay;
using TaikoFrenzy.Gameplay.Track;
using TaikoFrenzy.Managers;
using TaikoFrenzy.UI;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Localization.Components;
using UnityEngine.Localization.SmartFormat.PersistentVariables;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
using UnityEngine.UI;
using UnityEngine.UI.ProceduralImage;
using UnityEngine.Video;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class DRMManager : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static Action OnInitialized;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static DRMManager _instance;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private DRMPlatform _platform;

	[Token(Token = "0x17000001")]
	public static bool Initialized
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0xE4E30C", Offset = "0xE4E30C", VA = "0xE4E30C")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000002")]
		[Address(RVA = "0xE4E354", Offset = "0xE4E354", VA = "0xE4E354")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xE4E3A0", Offset = "0xE4E3A0", VA = "0xE4E3A0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xE4E7E8", Offset = "0xE4E7E8", VA = "0xE4E7E8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0xE4E800", Offset = "0xE4E800", VA = "0xE4E800")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xE4E870", Offset = "0xE4E870", VA = "0xE4E870")]
	private void Update()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xE4E8A0", Offset = "0xE4E8A0", VA = "0xE4E8A0")]
	public static void Ready()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0xE4E92C", Offset = "0xE4E92C", VA = "0xE4E92C")]
	public DRMManager()
	{
	}
}
[Token(Token = "0x2000003")]
public class DRMOculus : DRMPlatform
{
	[Token(Token = "0x4000007")]
	private const string CHECK_IV_PREF_KEY = "CheckIV";

	[Token(Token = "0x4000008")]
	private const string INSTALL_PREF_KEY = "Install";

	[Token(Token = "0x17000002")]
	public static User User
	{
		[Token(Token = "0x6000009")]
		[Address(RVA = "0xE4E934", Offset = "0xE4E934", VA = "0xE4E934")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600000A")]
		[Address(RVA = "0xE4E97C", Offset = "0xE4E97C", VA = "0xE4E97C")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000003")]
	public static InstallInfo FirstInstallInfo
	{
		[Token(Token = "0x600000B")]
		[Address(RVA = "0xE4E9D4", Offset = "0xE4E9D4", VA = "0xE4E9D4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600000C")]
		[Address(RVA = "0xE4EA1C", Offset = "0xE4EA1C", VA = "0xE4EA1C")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xE4E638", Offset = "0xE4E638", VA = "0xE4E638")]
	public DRMOculus()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xE4EA74", Offset = "0xE4EA74", VA = "0xE4EA74", Slot = "4")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xE4EA78", Offset = "0xE4EA78", VA = "0xE4EA78")]
	private void UserReceived(Message<User> msg)
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0xE4EC08", Offset = "0xE4EC08", VA = "0xE4EC08")]
	private InstallInfo GetInstallInfo()
	{
		return null;
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xE4EF34", Offset = "0xE4EF34", VA = "0xE4EF34", Slot = "6")]
	public override void Shutdown()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xE4EF38", Offset = "0xE4EF38", VA = "0xE4EF38", Slot = "5")]
	public override void Update(float deltaTime)
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0xE4EF3C", Offset = "0xE4EF3C", VA = "0xE4EF3C")]
	private void EntitlementCallback(Message msg)
	{
	}
}
[Token(Token = "0x2000004")]
public abstract class DRMPlatform
{
	[Token(Token = "0x17000004")]
	public bool Initialized
	{
		[Token(Token = "0x6000014")]
		[Address(RVA = "0xE4F060", Offset = "0xE4F060", VA = "0xE4F060")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000015")]
		[Address(RVA = "0xE4F068", Offset = "0xE4F068", VA = "0xE4F068")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x6000016")]
	public abstract void Initialize();

	[Token(Token = "0x6000017")]
	public abstract void Update(float deltaTime);

	[Token(Token = "0x6000018")]
	public abstract void Shutdown();

	[Token(Token = "0x6000019")]
	[Address(RVA = "0xE4EA6C", Offset = "0xE4EA6C", VA = "0xE4EA6C")]
	protected DRMPlatform()
	{
	}
}
[Token(Token = "0x2000005")]
public class IAPManager : MonoBehaviour
{
	[Token(Token = "0x17000005")]
	public static IAPPlatform Current
	{
		[Token(Token = "0x600001A")]
		[Address(RVA = "0xE4F074", Offset = "0xE4F074", VA = "0xE4F074")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600001B")]
		[Address(RVA = "0xE4F0BC", Offset = "0xE4F0BC", VA = "0xE4F0BC")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0xE4F114", Offset = "0xE4F114", VA = "0xE4F114")]
	private void Awake()
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0xE4F1B4", Offset = "0xE4F1B4", VA = "0xE4F1B4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0xE4F434", Offset = "0xE4F434", VA = "0xE4F434")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0xE4F2EC", Offset = "0xE4F2EC", VA = "0xE4F2EC")]
	private void InitPlatform()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0xE4F5A8", Offset = "0xE4F5A8", VA = "0xE4F5A8")]
	private void ConnectionStatusChanged()
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0xE4F6EC", Offset = "0xE4F6EC", VA = "0xE4F6EC")]
	public IAPManager()
	{
	}
}
[Token(Token = "0x2000006")]
public class IAPOculus : IAPPlatform
{
	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	private bool _checkingPurchaseCache;

	[Token(Token = "0x6000022")]
	[Address(RVA = "0xE4F6F4", Offset = "0xE4F6F4", VA = "0xE4F6F4", Slot = "4")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0xE4F7D0", Offset = "0xE4F7D0", VA = "0xE4F7D0", Slot = "6")]
	protected override void FetchPurchases()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0xE4F884", Offset = "0xE4F884", VA = "0xE4F884")]
	private void GetViewerPurchasesCallback(Message<PurchaseList> msg)
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0xE4FDA8", Offset = "0xE4FDA8", VA = "0xE4FDA8", Slot = "5")]
	protected override void FetchProducts()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0xE4FFEC", Offset = "0xE4FFEC", VA = "0xE4FFEC")]
	private void GetProductsBySKUCallback(Message<ProductList> msg)
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0xE50518", Offset = "0xE50518", VA = "0xE50518", Slot = "7")]
	public override void PurchaseProduct(IAPType type)
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0xE5070C", Offset = "0xE5070C", VA = "0xE5070C")]
	private void LaunchCheckoutFlowCallback(Message<Purchase> msg)
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0xE4F1AC", Offset = "0xE4F1AC", VA = "0xE4F1AC")]
	public IAPOculus()
	{
	}
}
[Token(Token = "0x2000007")]
public abstract class IAPPlatform
{
	[Token(Token = "0x2000008")]
	public class IAPProduct
	{
		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Sku;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Name;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string Description;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string FormattedPrice;

		[Token(Token = "0x6000039")]
		[Address(RVA = "0xE504A4", Offset = "0xE504A4", VA = "0xE504A4")]
		public IAPProduct(string sku, string name, string description, string formattedPrice)
		{
		}
	}

	[Token(Token = "0x2000009")]
	public enum IAPType
	{
		[Token(Token = "0x4000016")]
		FOUNDER_PACK
	}

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	protected Dictionary<IAPType, IAPProduct> _availableProductsDictionary;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected List<IAPType> _purschasedTypes;

	[Token(Token = "0x17000006")]
	public bool Initialized
	{
		[Token(Token = "0x600002E")]
		[Address(RVA = "0xE50BBC", Offset = "0xE50BBC", VA = "0xE50BBC")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600002F")]
		[Address(RVA = "0xE50BC4", Offset = "0xE50BC4", VA = "0xE50BC4")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x14000001")]
	public event Action OnInitialized
	{
		[Token(Token = "0x600002A")]
		[Address(RVA = "0xE50924", Offset = "0xE50924", VA = "0xE50924")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600002B")]
		[Address(RVA = "0xE509C0", Offset = "0xE509C0", VA = "0xE509C0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000002")]
	public event Action<IAPType, bool> OnPurchaseComplete
	{
		[Token(Token = "0x600002C")]
		[Address(RVA = "0xE50A5C", Offset = "0xE50A5C", VA = "0xE50A5C")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600002D")]
		[Address(RVA = "0xE50B0C", Offset = "0xE50B0C", VA = "0xE50B0C")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6000030")]
	public abstract void Initialize();

	[Token(Token = "0x6000031")]
	protected abstract void FetchProducts();

	[Token(Token = "0x6000032")]
	protected abstract void FetchPurchases();

	[Token(Token = "0x6000033")]
	public abstract void PurchaseProduct(IAPType type);

	[Token(Token = "0x6000034")]
	[Address(RVA = "0xE50BD0", Offset = "0xE50BD0", VA = "0xE50BD0")]
	public IAPProduct GetProductFromType(IAPType type)
	{
		return null;
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0xE506B4", Offset = "0xE506B4", VA = "0xE506B4")]
	public bool IsPurchased(IAPType type)
	{
		return default(bool);
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0xE50480", Offset = "0xE50480", VA = "0xE50480")]
	protected void Ready()
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0xE508FC", Offset = "0xE508FC", VA = "0xE508FC")]
	protected void PurchaseCompleted(IAPType type, bool success)
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0xE5091C", Offset = "0xE5091C", VA = "0xE5091C")]
	protected IAPPlatform()
	{
	}
}
[Serializable]
[Token(Token = "0x200000A")]
public class InstallInfo : ISerializationCallbackReceiver
{
	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string launchDate;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string version;

	[Token(Token = "0x17000007")]
	public DateTime LaunchDate
	{
		[Token(Token = "0x600003A")]
		[Address(RVA = "0xE50C64", Offset = "0xE50C64", VA = "0xE50C64")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Token(Token = "0x600003B")]
		[Address(RVA = "0xE50C6C", Offset = "0xE50C6C", VA = "0xE50C6C")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0xE4EE80", Offset = "0xE4EE80", VA = "0xE4EE80")]
	public InstallInfo()
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0xE50C74", Offset = "0xE50C74", VA = "0xE50C74")]
	public int GetVersionCode()
	{
		return default(int);
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0xE4EF2C", Offset = "0xE4EF2C", VA = "0xE4EF2C")]
	public string ToJson()
	{
		return null;
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0xE50D00", Offset = "0xE50D00", VA = "0xE50D00", Slot = "4")]
	public void OnBeforeSerialize()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0xE50D04", Offset = "0xE50D04", VA = "0xE50D04", Slot = "5")]
	public void OnAfterDeserialize()
	{
	}
}
[Token(Token = "0x200000B")]
public class LeaderboardManager : MonoBehaviour
{
	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private List<string> _leaderboardKeys;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Dictionary<string, LeaderboardPlatform> _leaderboardsDictionary;

	[Token(Token = "0x17000008")]
	public static LeaderboardManager Instance
	{
		[Token(Token = "0x6000041")]
		[Address(RVA = "0xE50D78", Offset = "0xE50D78", VA = "0xE50D78")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000042")]
		[Address(RVA = "0xE50DC0", Offset = "0xE50DC0", VA = "0xE50DC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0xE50E18", Offset = "0xE50E18", VA = "0xE50E18")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0xE50ED8", Offset = "0xE50ED8", VA = "0xE50ED8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0xE50EDC", Offset = "0xE50EDC", VA = "0xE50EDC")]
	public void InitLeaderboards()
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0xE5100C", Offset = "0xE5100C", VA = "0xE5100C")]
	public LeaderboardPlatform GetLeaderboard(string key)
	{
		return null;
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0xE51250", Offset = "0xE51250", VA = "0xE51250")]
	public LeaderboardManager()
	{
	}
}
[Token(Token = "0x200000C")]
public class LeaderboardOculus : LeaderboardPlatform
{
	[Token(Token = "0x6000048")]
	[Address(RVA = "0xE510FC", Offset = "0xE510FC", VA = "0xE510FC")]
	public LeaderboardOculus(string name, int minRank = 0, int maxRank = 10)
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0xE5137C", Offset = "0xE5137C", VA = "0xE5137C", Slot = "4")]
	public override void Update(float deltaTime)
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0xE51380", Offset = "0xE51380", VA = "0xE51380", Slot = "5")]
	public override void UpdateScore(int score)
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0xE51450", Offset = "0xE51450", VA = "0xE51450")]
	private void OnLeaderboardUploadResult(Message<bool> msg)
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0xE51578", Offset = "0xE51578", VA = "0xE51578", Slot = "6")]
	public override void RetrieveScores()
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0xE51928", Offset = "0xE51928", VA = "0xE51928")]
	private void OnLeaderboardScoresDownloaded(Message<LeaderboardEntryList> msg)
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0xE51EA0", Offset = "0xE51EA0", VA = "0xE51EA0")]
	private void OnLeaderboardFriendsScoresDownloaded(Message<LeaderboardEntryList> msg)
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0xE51EA8", Offset = "0xE51EA8", VA = "0xE51EA8")]
	private void OnLeaderboardRelativeScoresDownloaded(Message<LeaderboardEntryList> msg)
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0xE51930", Offset = "0xE51930", VA = "0xE51930")]
	private void EntriesDownloaded(Message<LeaderboardEntryList> msg, EntryType type)
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0xE51EB0", Offset = "0xE51EB0", VA = "0xE51EB0")]
	private LeaderboardEntry BuildEntry(Oculus.Platform.Models.LeaderboardEntry oculusEntry)
	{
		return null;
	}
}
[Token(Token = "0x200000D")]
public abstract class LeaderboardPlatform
{
	[Serializable]
	[Token(Token = "0x200000E")]
	public class LeaderboardEntry
	{
		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string UserId;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Name;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int Rank;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int Score;

		[Token(Token = "0x600005E")]
		[Address(RVA = "0xE52038", Offset = "0xE52038", VA = "0xE52038", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0xE51FE8", Offset = "0xE51FE8", VA = "0xE51FE8")]
		public LeaderboardEntry()
		{
		}
	}

	[Token(Token = "0x200000F")]
	public enum EntryType
	{
		[Token(Token = "0x4000030")]
		Global,
		[Token(Token = "0x4000031")]
		Relative,
		[Token(Token = "0x4000032")]
		Friends
	}

	[Token(Token = "0x2000010")]
	public enum LeaderboardState
	{
		[Token(Token = "0x4000034")]
		WaitForInit,
		[Token(Token = "0x4000035")]
		WaitForGlobal,
		[Token(Token = "0x4000036")]
		GlobalReady,
		[Token(Token = "0x4000037")]
		WaitForRelative,
		[Token(Token = "0x4000038")]
		RelativeReady,
		[Token(Token = "0x4000039")]
		WaitForFriends,
		[Token(Token = "0x400003A")]
		FriendsReady,
		[Token(Token = "0x400003B")]
		Initialized
	}

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Action OnInitialized;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Action OnUpdated;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Action OnScoreUpdated;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<LeaderboardEntry> Entries;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<LeaderboardEntry> RelativeEntries;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<LeaderboardEntry> FriendsEntries;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public LeaderboardEntry PersonalEntry;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	protected int _minRank;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	protected int _maxRank;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	protected int _retrieveCount;

	[Token(Token = "0x17000009")]
	public bool Initialized
	{
		[Token(Token = "0x6000052")]
		[Address(RVA = "0xE51FF0", Offset = "0xE51FF0", VA = "0xE51FF0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000053")]
		[Address(RVA = "0xE51FF8", Offset = "0xE51FF8", VA = "0xE51FF8")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x1700000A")]
	public bool Loading
	{
		[Token(Token = "0x6000054")]
		[Address(RVA = "0xE52004", Offset = "0xE52004", VA = "0xE52004")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000055")]
		[Address(RVA = "0xE5200C", Offset = "0xE5200C", VA = "0xE5200C")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x1700000B")]
	public string Name
	{
		[Token(Token = "0x6000056")]
		[Address(RVA = "0xE52018", Offset = "0xE52018", VA = "0xE52018")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000057")]
		[Address(RVA = "0xE52020", Offset = "0xE52020", VA = "0xE52020")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x1700000C")]
	public LeaderboardState State
	{
		[Token(Token = "0x6000058")]
		[Address(RVA = "0xE52028", Offset = "0xE52028", VA = "0xE52028")]
		[CompilerGenerated]
		get
		{
			return default(LeaderboardState);
		}
		[Token(Token = "0x6000059")]
		[Address(RVA = "0xE52030", Offset = "0xE52030", VA = "0xE52030")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0xE51258", Offset = "0xE51258", VA = "0xE51258")]
	public LeaderboardPlatform(string name, int minRank = 1, int maxRank = 10)
	{
	}

	[Token(Token = "0x600005B")]
	public abstract void Update(float deltaTime);

	[Token(Token = "0x600005C")]
	public abstract void UpdateScore(int score);

	[Token(Token = "0x600005D")]
	[Address(RVA = "0xE5184C", Offset = "0xE5184C", VA = "0xE5184C", Slot = "6")]
	public virtual void RetrieveScores()
	{
	}
}
[Token(Token = "0x2000011")]
public class LeaderboardTest : MonoBehaviour
{
	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private LeaderboardPlatform _leaderboard;

	[Token(Token = "0x6000060")]
	[Address(RVA = "0xE522C8", Offset = "0xE522C8", VA = "0xE522C8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0xE52604", Offset = "0xE52604", VA = "0xE52604")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0xE52400", Offset = "0xE52400", VA = "0xE52400")]
	private void Init()
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0xE52770", Offset = "0xE52770", VA = "0xE52770")]
	private void PrintEntries()
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0xE52DB4", Offset = "0xE52DB4", VA = "0xE52DB4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0xE52E44", Offset = "0xE52E44", VA = "0xE52E44")]
	public LeaderboardTest()
	{
	}
}
[Token(Token = "0x2000012")]
public interface ITakeDamage
{
	[Token(Token = "0x6000066")]
	void TakeDamage(float damage, GameObject instigator, Vector3 position);
}
[Token(Token = "0x2000013")]
public class RayInteractorsActivation : MonoBehaviour
{
	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Interface(typeof(IHand), new Type[] { })]
	private MonoBehaviour _leftHand;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Interface(typeof(IHand), new Type[] { })]
	[SerializeField]
	private MonoBehaviour _rightHand;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private RayInteractor _leftInteractor;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private RayInteractor _rightInteractor;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool _isRight;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	private bool _rayEnabled;

	[Token(Token = "0x1700000D")]
	public IHand LeftHand
	{
		[Token(Token = "0x6000067")]
		[Address(RVA = "0xE52E4C", Offset = "0xE52E4C", VA = "0xE52E4C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000068")]
		[Address(RVA = "0xE52E54", Offset = "0xE52E54", VA = "0xE52E54")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700000E")]
	public IHand RightHand
	{
		[Token(Token = "0x6000069")]
		[Address(RVA = "0xE52E5C", Offset = "0xE52E5C", VA = "0xE52E5C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600006A")]
		[Address(RVA = "0xE52E64", Offset = "0xE52E64", VA = "0xE52E64")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700000F")]
	public bool IsRight
	{
		[Token(Token = "0x600006B")]
		[Address(RVA = "0xE52E6C", Offset = "0xE52E6C", VA = "0xE52E6C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000010")]
	public bool RayEnabled
	{
		[Token(Token = "0x600006C")]
		[Address(RVA = "0xE52E74", Offset = "0xE52E74", VA = "0xE52E74")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0xE52E7C", Offset = "0xE52E7C", VA = "0xE52E7C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0xE52EF0", Offset = "0xE52EF0", VA = "0xE52EF0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0xE53084", Offset = "0xE53084", VA = "0xE53084")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0xE53218", Offset = "0xE53218", VA = "0xE53218")]
	private void Start()
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0xE53228", Offset = "0xE53228", VA = "0xE53228")]
	public void EnableRayInteractor(bool enable)
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0xE53294", Offset = "0xE53294", VA = "0xE53294")]
	private void EnableRay(bool right)
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0xE53338", Offset = "0xE53338", VA = "0xE53338")]
	private void HandleLeftHandUpdated()
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0xE53470", Offset = "0xE53470", VA = "0xE53470")]
	private void HandleRightHandUpdated()
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0xE535A8", Offset = "0xE535A8", VA = "0xE535A8")]
	public RayInteractorsActivation()
	{
	}
}
[Token(Token = "0x2000014")]
[RequireComponent(typeof(Renderer))]
public class SocleHighlight : MonoBehaviour
{
	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[ColorUsage(false, true)]
	[Header("Colors")]
	public Color IdleColor1;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[ColorUsage(false, true)]
	public Color IdleColor2;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[ColorUsage(false, true)]
	public Color HighlightColor1;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[ColorUsage(false, true)]
	public Color HighlightColor2;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[Header("Animation times")]
	public float BlinkTime;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public float ToggleTime;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Renderer _renderer;

	[Token(Token = "0x400004C")]
	private const string EMISSION_PROPERTY = "_EmissionColor";

	[Token(Token = "0x6000076")]
	[Address(RVA = "0xE535B8", Offset = "0xE535B8", VA = "0xE535B8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0xE53610", Offset = "0xE53610", VA = "0xE53610")]
	private void Start()
	{
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0xE536F8", Offset = "0xE536F8", VA = "0xE536F8")]
	private void PlayerExited(Collider other)
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0xE53864", Offset = "0xE53864", VA = "0xE53864")]
	private void PlayerEntered(Collider other)
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0xE539D0", Offset = "0xE539D0", VA = "0xE539D0")]
	public SocleHighlight()
	{
	}
}
[Token(Token = "0x2000015")]
public class StaticActiveState : MonoBehaviour, IActiveState
{
	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private bool _defaultState;

	[Token(Token = "0x17000011")]
	public bool Active
	{
		[Token(Token = "0x600007D")]
		[Address(RVA = "0xE53C4C", Offset = "0xE53C4C", VA = "0xE53C4C", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0xE53C54", Offset = "0xE53C54", VA = "0xE53C54")]
	public void SetState(bool active = false)
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0xE53C60", Offset = "0xE53C60", VA = "0xE53C60")]
	public StaticActiveState()
	{
	}
}
[Serializable]
[Token(Token = "0x2000016")]
public class SheetSave : SaveData
{
	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<TaikoNoteInfo> Sheet;

	[Token(Token = "0x400004F")]
	private const int SAVE_VERSION = 2;

	[Token(Token = "0x6000080")]
	[Address(RVA = "0xE53C68", Offset = "0xE53C68", VA = "0xE53C68")]
	public SheetSave()
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0xE53D00", Offset = "0xE53D00", VA = "0xE53D00", Slot = "4")]
	public override bool CheckIntegrity()
	{
		return default(bool);
	}
}
[Serializable]
[Token(Token = "0x2000017")]
public sealed class TaikoNoteInfo
{
	[Token(Token = "0x2000018")]
	public enum Type
	{
		[Token(Token = "0x4000055")]
		RightCenter,
		[Token(Token = "0x4000056")]
		LeftCenter,
		[Token(Token = "0x4000057")]
		DoubleCenter,
		[Token(Token = "0x4000058")]
		Rumble,
		[Token(Token = "0x4000059")]
		RightSide,
		[Token(Token = "0x400005A")]
		LeftSide,
		[Token(Token = "0x400005B")]
		DoubleSide,
		[Token(Token = "0x400005C")]
		LeftCenterRim,
		[Token(Token = "0x400005D")]
		RightCenterRim
	}

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Type NoteType;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int TimeInMillisec;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int LengthInMillisec;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool Accented;

	[Token(Token = "0x6000082")]
	[Address(RVA = "0xE53D10", Offset = "0xE53D10", VA = "0xE53D10")]
	public TaikoNoteInfo()
	{
	}
}
[Token(Token = "0x2000019")]
public class EffectManager : GenericPoolGroup<Effect, EffectManager.EEffectsType>
{
	[Token(Token = "0x200001A")]
	public enum EEffectsType
	{
		[Token(Token = "0x4000060")]
		TaikoCenterHitFx,
		[Token(Token = "0x4000061")]
		TaikoSideHitFx,
		[Token(Token = "0x4000062")]
		NoteHitOkFx,
		[Token(Token = "0x4000063")]
		NoteHitSuperFx,
		[Token(Token = "0x4000064")]
		NoteHitPerfectFx,
		[Token(Token = "0x4000065")]
		NoteHitRumbleFx,
		[Token(Token = "0x4000066")]
		TaikoCenterHitAccentedFx,
		[Token(Token = "0x4000067")]
		TaikoSideHitAccentedFx,
		[Token(Token = "0x4000068")]
		NoteHitAccentedSuccessFx,
		[Token(Token = "0x4000069")]
		NoteHitAccentedFailFx,
		[Token(Token = "0x400006A")]
		RumbleSuccessFx
	}

	[Token(Token = "0x17000012")]
	public static EffectManager Instance
	{
		[Token(Token = "0x6000083")]
		[Address(RVA = "0xE53D18", Offset = "0xE53D18", VA = "0xE53D18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000084")]
		[Address(RVA = "0xE53D60", Offset = "0xE53D60", VA = "0xE53D60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0xE53DB8", Offset = "0xE53DB8", VA = "0xE53DB8", Slot = "4")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0xE53E44", Offset = "0xE53E44", VA = "0xE53E44")]
	public void Play(EEffectsType type, [System.Runtime.InteropServices.Optional] Vector3 position, [System.Runtime.InteropServices.Optional] Quaternion rotation, [System.Runtime.InteropServices.Optional] Transform parentToFollow)
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0xE541F8", Offset = "0xE541F8", VA = "0xE541F8")]
	public EffectManager()
	{
	}
}
[Token(Token = "0x200001B")]
public class FloatingTextManager : GenericPoolGroup<FloatingText, FloatingTextManager.EFloatingTextType>
{
	[Token(Token = "0x200001C")]
	public enum EFloatingTextType
	{
		[Token(Token = "0x4000072")]
		FloatingText
	}

	[Token(Token = "0x200001D")]
	public enum TextType
	{
		[Token(Token = "0x4000074")]
		OverdoseCountdown,
		[Token(Token = "0x4000075")]
		OverdoseRumbleBonus,
		[Token(Token = "0x4000076")]
		OverdosePerfectHit,
		[Token(Token = "0x4000077")]
		OverdoseSuperHit,
		[Token(Token = "0x4000078")]
		OverdoseOKHit,
		[Token(Token = "0x4000079")]
		OverdoseMissHit,
		[Token(Token = "0x400007A")]
		MarkerCountdown,
		[Token(Token = "0x400007B")]
		MarkerRumbleBonus,
		[Token(Token = "0x400007C")]
		MarkerPerfectHit,
		[Token(Token = "0x400007D")]
		MarkerSuperHit,
		[Token(Token = "0x400007E")]
		MarkerOKHit,
		[Token(Token = "0x400007F")]
		MarkerMissHit,
		[Token(Token = "0x4000080")]
		MarkerMultiplier1,
		[Token(Token = "0x4000081")]
		MarkerMultiplier2,
		[Token(Token = "0x4000082")]
		MarkerMultiplier3,
		[Token(Token = "0x4000083")]
		MarkerMultiplier4,
		[Token(Token = "0x4000084")]
		MarkerMultiplier5,
		[Token(Token = "0x4000085")]
		MarkerSakura
	}

	[Serializable]
	[Token(Token = "0x200001E")]
	public struct FloatingTextDataType
	{
		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public TextType Type;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public FloatingTextData Data;
	}

	[Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class <TestDelayed>d__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextType[] typesToTest;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public FloatingTextManager <>4__this;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string text;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 position;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TextType[] <>7__wrap1;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int <>7__wrap2;

		[Token(Token = "0x17000014")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000098")]
			[Address(RVA = "0xE551C8", Offset = "0xE551C8", VA = "0xE551C8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000015")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600009A")]
			[Address(RVA = "0xE55210", Offset = "0xE55210", VA = "0xE55210", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0xE54E3C", Offset = "0xE54E3C", VA = "0xE54E3C")]
		[DebuggerHidden]
		public <TestDelayed>d__16(int <>1__state)
		{
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0xE55020", Offset = "0xE55020", VA = "0xE55020", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0xE55024", Offset = "0xE55024", VA = "0xE55024", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0xE551D0", Offset = "0xE551D0", VA = "0xE551D0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform FloatingTextsParent;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float MaxDistanceFromPlayer;

	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Transform _previewTransform;

	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Header("Text Styles")]
	public List<FloatingTextDataType> TextStyles;

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Dictionary<TextType, FloatingTextData> _textStylesDictionary;

	[Token(Token = "0x17000013")]
	public static FloatingTextManager Instance
	{
		[Token(Token = "0x6000088")]
		[Address(RVA = "0xE54240", Offset = "0xE54240", VA = "0xE54240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000089")]
		[Address(RVA = "0xE54288", Offset = "0xE54288", VA = "0xE54288")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0xE542E0", Offset = "0xE542E0", VA = "0xE542E0", Slot = "4")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0xE544F8", Offset = "0xE544F8", VA = "0xE544F8")]
	public void CreateFloatingText(string text, Vector3 position, Quaternion rootRotation, TextType type, FloatingText.RotationFollow follow = FloatingText.RotationFollow.WithoutY, float distanceToRemove = 0.1f, float randomizeRadius = 0f)
	{
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0xE54C58", Offset = "0xE54C58", VA = "0xE54C58")]
	public void Preview()
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0xE54D54", Offset = "0xE54D54", VA = "0xE54D54")]
	public void Test(string text, Vector3 position, TextType[] typesToTest)
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0xE54D74", Offset = "0xE54D74", VA = "0xE54D74")]
	[IteratorStateMachine(typeof(<TestDelayed>d__16))]
	private IEnumerator TestDelayed(string text, Vector3 position, TextType[] typesToTest)
	{
		return null;
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0xE54E64", Offset = "0xE54E64", VA = "0xE54E64")]
	public void Depop(FloatingText floating)
	{
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0xE54F48", Offset = "0xE54F48", VA = "0xE54F48")]
	public FloatingTextManager()
	{
	}
}
[Token(Token = "0x2000021")]
public class LevelManager : MonoBehaviour
{
	[Token(Token = "0x2000022")]
	public enum MusicTheme
	{
		[Token(Token = "0x4000096")]
		Main,
		[Token(Token = "0x4000097")]
		None
	}

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private StudioEventEmitter _mainMusicEmitter;

	[Token(Token = "0x17000016")]
	public static LevelManager Instance
	{
		[Token(Token = "0x600009B")]
		[Address(RVA = "0xE55218", Offset = "0xE55218", VA = "0xE55218")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600009C")]
		[Address(RVA = "0xE55260", Offset = "0xE55260", VA = "0xE55260")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0xE552B8", Offset = "0xE552B8", VA = "0xE552B8")]
	private void Awake()
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0xE55358", Offset = "0xE55358", VA = "0xE55358")]
	public void ChangeMusic(MusicTheme theme)
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0xE553B4", Offset = "0xE553B4", VA = "0xE553B4")]
	public LevelManager()
	{
	}
}
[Token(Token = "0x2000023")]
public class NotesManager : GenericPoolGroup<TaikoNote, NotesManager.ENotesType>
{
	[Token(Token = "0x2000024")]
	public enum ENotesType
	{
		[Token(Token = "0x400009A")]
		NewCenterRight,
		[Token(Token = "0x400009B")]
		NewCenterLeft,
		[Token(Token = "0x400009C")]
		NewSideRight,
		[Token(Token = "0x400009D")]
		NewSideLeft
	}

	[Token(Token = "0x17000017")]
	public static NotesManager Instance
	{
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0xE553BC", Offset = "0xE553BC", VA = "0xE553BC")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0xE55404", Offset = "0xE55404", VA = "0xE55404")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0xE5545C", Offset = "0xE5545C", VA = "0xE5545C", Slot = "4")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0xE554E8", Offset = "0xE554E8", VA = "0xE554E8")]
	public TaikoNote Spawn(ENotesType type, [System.Runtime.InteropServices.Optional] Vector3 position, [System.Runtime.InteropServices.Optional] Quaternion rotation)
	{
		return null;
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0xE557E8", Offset = "0xE557E8", VA = "0xE557E8")]
	public NotesManager()
	{
	}
}
[Token(Token = "0x2000025")]
public class QualitySettingsManager : MonoBehaviour
{
	[Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class <InitCo>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public QualitySettingsManager <>4__this;

		[Token(Token = "0x17000019")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000B1")]
			[Address(RVA = "0xE55D6C", Offset = "0xE55D6C", VA = "0xE55D6C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000B3")]
			[Address(RVA = "0xE55DB4", Offset = "0xE55DB4", VA = "0xE55DB4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0xE55AF0", Offset = "0xE55AF0", VA = "0xE55AF0")]
		[DebuggerHidden]
		public <InitCo>d__13(int <>1__state)
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0xE55CBC", Offset = "0xE55CBC", VA = "0xE55CBC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0xE55CC0", Offset = "0xE55CC0", VA = "0xE55CC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0xE55D74", Offset = "0xE55D74", VA = "0xE55D74", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float _defaultSceneFOV;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private float _defaultSceneBias;

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float _calculatedBias;

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[SerializeField]
	private int _quest1SettingsIndex;

	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Renderer[] _hands;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Material _quest1HandMaterial;

	[Token(Token = "0x17000018")]
	public static QualitySettingsManager Instance
	{
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0xE55830", Offset = "0xE55830", VA = "0xE55830")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0xE55878", Offset = "0xE55878", VA = "0xE55878")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0xE558D0", Offset = "0xE558D0", VA = "0xE558D0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0xE559F8", Offset = "0xE559F8", VA = "0xE559F8")]
	private void Start()
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0xE55A90", Offset = "0xE55A90", VA = "0xE55A90")]
	private void SetupFoveatedRenderingLevel()
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0xE55A1C", Offset = "0xE55A1C", VA = "0xE55A1C")]
	[IteratorStateMachine(typeof(<InitCo>d__13))]
	private IEnumerator InitCo()
	{
		return null;
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0xE5599C", Offset = "0xE5599C", VA = "0xE5599C")]
	public bool IsQuest1()
	{
		return default(bool);
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0xE55B18", Offset = "0xE55B18", VA = "0xE55B18")]
	public void UpdateLodBias()
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0xE55CA0", Offset = "0xE55CA0", VA = "0xE55CA0")]
	public QualitySettingsManager()
	{
	}
}
[Token(Token = "0x2000027")]
public class SaveManager : MonoBehaviour
{
	[Token(Token = "0x40000AA")]
	private const string USER_PROGRESS_SAVE_NAME = "Progress";

	[Token(Token = "0x1700001B")]
	public static UserProgressSave UserProgress
	{
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0xE55F2C", Offset = "0xE55F2C", VA = "0xE55F2C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0xE55F74", Offset = "0xE55F74", VA = "0xE55F74")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x14000003")]
	public static event Action OnSaved
	{
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0xE55DBC", Offset = "0xE55DBC", VA = "0xE55DBC")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0xE55E74", Offset = "0xE55E74", VA = "0xE55E74")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0xE55FC4", Offset = "0xE55FC4", VA = "0xE55FC4")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0xE567A4", Offset = "0xE567A4", VA = "0xE567A4")]
	public static void ResetAll()
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0xE56884", Offset = "0xE56884", VA = "0xE56884")]
	public static void Save()
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0xE56178", Offset = "0xE56178", VA = "0xE56178")]
	private static string GetPath(string name)
	{
		return null;
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0xE5693C", Offset = "0xE5693C", VA = "0xE5693C")]
	public SaveManager()
	{
	}
}
[Token(Token = "0x2000028")]
public class TextStyleManager : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000029")]
	public struct LanguageTextStyle
	{
		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public SystemLanguage Language;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public TextStyle TextStyle;
	}

	[Serializable]
	[Token(Token = "0x200002A")]
	public struct StyleTextStyle
	{
		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public TextStyle.Style Style;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public TextStyle DefaultTextStyle;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<LanguageTextStyle> LanguageTextStyles;
	}

	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<StyleTextStyle> Styles;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Dictionary<TextStyle.Style, Dictionary<SystemLanguage, TextStyle>> _styleDictionary;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Dictionary<TextStyle.Style, TextStyle> _defaultStyleDictionary;

	[Token(Token = "0x1700001C")]
	public static TextStyleManager Instance
	{
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0xE56944", Offset = "0xE56944", VA = "0xE56944")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0xE5698C", Offset = "0xE5698C", VA = "0xE5698C")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0xE569E4", Offset = "0xE569E4", VA = "0xE569E4")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0xE56D30", Offset = "0xE56D30", VA = "0xE56D30")]
	public TextStyle GetTextStyle(TextStyle.Style style)
	{
		return null;
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0xE56D38", Offset = "0xE56D38", VA = "0xE56D38")]
	public TextStyleManager()
	{
	}
}
[Token(Token = "0x200002C")]
public static class BinaryLoader
{
	[Token(Token = "0x60000CA")]
	[Address(RVA = "0xE56544", Offset = "0xE56544", VA = "0xE56544")]
	public static bool Save(SaveData saveData, string name)
	{
		return default(bool);
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0xE56214", Offset = "0xE56214", VA = "0xE56214")]
	public static SaveData Load(string name)
	{
		return null;
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0xE56F7C", Offset = "0xE56F7C", VA = "0xE56F7C")]
	public static bool Delete(string name)
	{
		return default(bool);
	}
}
[Serializable]
[Token(Token = "0x200002D")]
public abstract class SaveData
{
	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int VersionCode;

	[Token(Token = "0x60000CD")]
	public abstract bool CheckIntegrity();

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0xE53CF8", Offset = "0xE53CF8", VA = "0xE53CF8")]
	protected SaveData()
	{
	}
}
[Serializable]
[Token(Token = "0x200002E")]
public class StatsSave : SaveData
{
	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Dictionary<string, Dictionary<GameManager.Difficulty, int>> TracksBest;

	[Token(Token = "0x40000BD")]
	private const int SAVE_VERSION = 3;

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0xE57008", Offset = "0xE57008", VA = "0xE57008")]
	public StatsSave()
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0xE57098", Offset = "0xE57098", VA = "0xE57098", Slot = "4")]
	public override bool CheckIntegrity()
	{
		return default(bool);
	}
}
[Serializable]
[Token(Token = "0x200002F")]
public class UserProgressSave : SaveData
{
	[Serializable]
	[Token(Token = "0x2000030")]
	public struct DifficultyProgress
	{
		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int BestScore;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int BestCombo;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int BestCompletion;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<TaikoTrack.MedalType> UnlockedMedals;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool Rated;
	}

	[Serializable]
	[Token(Token = "0x2000031")]
	public struct TrackProgress
	{
		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Dictionary<GameManager.Difficulty, DifficultyProgress> Progress;
	}

	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Dictionary<string, TrackProgress> TracksProgress;

	[Token(Token = "0x40000BF")]
	private const int SAVE_VERSION = 2;

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0xE564B4", Offset = "0xE564B4", VA = "0xE564B4")]
	public UserProgressSave()
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0xE570A8", Offset = "0xE570A8", VA = "0xE570A8", Slot = "4")]
	public override bool CheckIntegrity()
	{
		return default(bool);
	}
}
[Token(Token = "0x2000032")]
[RequireComponent(typeof(TextMeshProUGUI))]
public class ApplyTextStyle : MonoBehaviour
{
	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TextStyle.Style Style;

	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private TextMeshProUGUI _textComponent;

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0xE570B8", Offset = "0xE570B8", VA = "0xE570B8")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0xE57110", Offset = "0xE57110", VA = "0xE57110")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0xE57114", Offset = "0xE57114", VA = "0xE57114")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0xE57118", Offset = "0xE57118", VA = "0xE57118")]
	private void CheckLanguage(SystemLanguage lang)
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0xE57208", Offset = "0xE57208", VA = "0xE57208")]
	private void Apply(TextStyle textStyle)
	{
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0xE572D8", Offset = "0xE572D8", VA = "0xE572D8")]
	public ApplyTextStyle()
	{
	}
}
[Token(Token = "0x2000033")]
public class DeselectButton : Button, IBeginDragHandler, IEventSystemHandler
{
	[Token(Token = "0x40000C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private bool _clearStateOnDrag;

	[Token(Token = "0x1700001D")]
	public bool ClearStateOnDrag
	{
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0xE572E0", Offset = "0xE572E0", VA = "0xE572E0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000DA")]
		[Address(RVA = "0xE572E8", Offset = "0xE572E8", VA = "0xE572E8")]
		set
		{
		}
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0xE572F4", Offset = "0xE572F4", VA = "0xE572F4", Slot = "41")]
	public override void OnPointerClick(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0xE57350", Offset = "0xE57350", VA = "0xE57350", Slot = "32")]
	public override void OnPointerDown(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0xE573AC", Offset = "0xE573AC", VA = "0xE573AC", Slot = "43")]
	public void OnBeginDrag(PointerEventData pointerEventData)
	{
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0xE574DC", Offset = "0xE574DC", VA = "0xE574DC")]
	public DeselectButton()
	{
	}
}
[Token(Token = "0x2000034")]
public class FloatingText : MonoBehaviour, IPooled<FloatingText>
{
	[Token(Token = "0x2000035")]
	public enum RotationFollow
	{
		[Token(Token = "0x40000D5")]
		Complete,
		[Token(Token = "0x40000D6")]
		WithoutY,
		[Token(Token = "0x40000D7")]
		None
	}

	[Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class <End>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FloatingText <>4__this;

		[Token(Token = "0x17000021")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000EF")]
			[Address(RVA = "0xE579A4", Offset = "0xE579A4", VA = "0xE579A4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000022")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000F1")]
			[Address(RVA = "0xE579EC", Offset = "0xE579EC", VA = "0xE579EC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0xE575E8", Offset = "0xE575E8", VA = "0xE575E8")]
		[DebuggerHidden]
		public <End>d__23(int <>1__state)
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0xE578CC", Offset = "0xE578CC", VA = "0xE578CC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0xE578D0", Offset = "0xE578D0", VA = "0xE578D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0xE579AC", Offset = "0xE579AC", VA = "0xE579AC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI FloatText;

	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public TextMeshProUGUI OutlineText;

	[Token(Token = "0x40000CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Transform _positionAlignmentHolder;

	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Transform _rotationAlignmentHolder;

	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Animator _animator;

	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Transform _target;

	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private FloatingTextData _currentData;

	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private RotationFollow _rotFollow;

	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public bool isParentPoolableDependant;

	[Token(Token = "0x1700001E")]
	public int PoolID
	{
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0xE574EC", Offset = "0xE574EC", VA = "0xE574EC", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60000E0")]
		[Address(RVA = "0xE574F4", Offset = "0xE574F4", VA = "0xE574F4", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700001F")]
	public ObjectPooler<FloatingText> Pool
	{
		[Token(Token = "0x60000E1")]
		[Address(RVA = "0xE574FC", Offset = "0xE574FC", VA = "0xE574FC", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0xE57504", Offset = "0xE57504", VA = "0xE57504", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000020")]
	public bool IsParentPoolableDependant
	{
		[Token(Token = "0x60000E3")]
		[Address(RVA = "0xE5750C", Offset = "0xE5750C", VA = "0xE5750C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0xE57514", Offset = "0xE57514", VA = "0xE57514")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0xE5756C", Offset = "0xE5756C", VA = "0xE5756C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0xE54A0C", Offset = "0xE54A0C", VA = "0xE54A0C")]
	public void SetText(string text, Transform target, FloatingTextData data, RotationFollow follow = RotationFollow.WithoutY)
	{
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0xE57574", Offset = "0xE57574", VA = "0xE57574")]
	[IteratorStateMachine(typeof(<End>d__23))]
	private IEnumerator End()
	{
		return null;
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0xE57610", Offset = "0xE57610", VA = "0xE57610")]
	private void Depop()
	{
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0xE576AC", Offset = "0xE576AC", VA = "0xE576AC")]
	public void Update()
	{
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0xE576B0", Offset = "0xE576B0", VA = "0xE576B0")]
	private void UpdateRotation()
	{
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0xE578C4", Offset = "0xE578C4", VA = "0xE578C4")]
	public FloatingText()
	{
	}
}
[Token(Token = "0x2000037")]
public class FloatingTextData : ScriptableObject
{
	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AnimationClip Clip;

	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string AnimationName;

	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TMP_FontAsset Font;

	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Material FontMaterial;

	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Color OutlineColor;

	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public int FontSize;

	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float LetterSpacing;

	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float LineSpacing;

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0xE579F4", Offset = "0xE579F4", VA = "0xE579F4")]
	public FloatingTextData()
	{
	}
}
[Token(Token = "0x2000038")]
[RequireComponent(typeof(Canvas))]
public class LanguageConditionalCanvas : MonoBehaviour
{
	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<SystemLanguage> EnabledLanguages;

	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float ToggleDistance;

	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float _lastCheck;

	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float _toggleDistanceSqr;

	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private bool _shouldEnableCanvas;

	[Token(Token = "0x40000E8")]
	private const float CHECK_INTERVAL = 0.25f;

	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Canvas _canvas;

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0xE579FC", Offset = "0xE579FC", VA = "0xE579FC")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0xE57A64", Offset = "0xE57A64", VA = "0xE57A64")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0xE57A68", Offset = "0xE57A68", VA = "0xE57A68")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0xE57A6C", Offset = "0xE57A6C", VA = "0xE57A6C")]
	private void Update()
	{
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0xE57C1C", Offset = "0xE57C1C", VA = "0xE57C1C")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0xE57C68", Offset = "0xE57C68", VA = "0xE57C68")]
	private void CheckLanguage(SystemLanguage lang)
	{
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0xE57CCC", Offset = "0xE57CCC", VA = "0xE57CCC")]
	public LanguageConditionalCanvas()
	{
	}
}
[Token(Token = "0x2000039")]
public class TextStyle : ScriptableObject
{
	[Token(Token = "0x200003A")]
	public enum Style
	{
		[Token(Token = "0x40000F3")]
		AltarTitle,
		[Token(Token = "0x40000F4")]
		GameUIMemorize,
		[Token(Token = "0x40000F5")]
		GameUISecondary,
		[Token(Token = "0x40000F6")]
		HeaderBlue,
		[Token(Token = "0x40000F7")]
		HeaderGreen,
		[Token(Token = "0x40000F8")]
		HeaderOrange,
		[Token(Token = "0x40000F9")]
		HeaderRed,
		[Token(Token = "0x40000FA")]
		HeaderYellow,
		[Token(Token = "0x40000FB")]
		GameUIEnd,
		[Token(Token = "0x40000FC")]
		KyudoTarget
	}

	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TMP_FontAsset Font;

	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Material FontMaterial;

	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public FontStyles FontStyle;

	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public Color TextColor;

	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public int FontSize;

	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public TextAlignmentOptions Alignment;

	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float LetterSpacing;

	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float LineSpacing;

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0xE57CDC", Offset = "0xE57CDC", VA = "0xE57CDC")]
	public TextStyle()
	{
	}
}
[Token(Token = "0x200003B")]
public class AttachedBehaviour : MonoBehaviour
{
	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected Transform _fakeParent;

	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected Vector3 _followPos;

	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	protected Vector3 _followForward;

	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected Vector3 _followUp;

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0xE57CE4", Offset = "0xE57CE4", VA = "0xE57CE4", Slot = "4")]
	protected virtual void Update()
	{
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0xE57E28", Offset = "0xE57E28", VA = "0xE57E28", Slot = "5")]
	public virtual void SetParentToFollow(Transform parent)
	{
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0xE57F48", Offset = "0xE57F48", VA = "0xE57F48")]
	public AttachedBehaviour()
	{
	}
}
[Token(Token = "0x200003C")]
[RequireComponent(typeof(Collider))]
public class ColliderEventHandler : MonoBehaviour
{
	[Token(Token = "0x200003D")]
	public delegate void ColliderEvent(Collider other);

	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public LayerMask CollideWithLayers;

	[Token(Token = "0x17000023")]
	public bool Entered
	{
		[Token(Token = "0x6000102")]
		[Address(RVA = "0xE581C0", Offset = "0xE581C0", VA = "0xE581C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000103")]
		[Address(RVA = "0xE581C8", Offset = "0xE581C8", VA = "0xE581C8")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x14000004")]
	public event ColliderEvent ColliderEntered
	{
		[Token(Token = "0x60000FE")]
		[Address(RVA = "0xE57F50", Offset = "0xE57F50", VA = "0xE57F50")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60000FF")]
		[Address(RVA = "0xE57FEC", Offset = "0xE57FEC", VA = "0xE57FEC")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000005")]
	public event ColliderEvent ColliderExited
	{
		[Token(Token = "0x6000100")]
		[Address(RVA = "0xE58088", Offset = "0xE58088", VA = "0xE58088")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000101")]
		[Address(RVA = "0xE58124", Offset = "0xE58124", VA = "0xE58124")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0xE581D4", Offset = "0xE581D4", VA = "0xE581D4")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0xE58258", Offset = "0xE58258", VA = "0xE58258")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0xE582DC", Offset = "0xE582DC", VA = "0xE582DC")]
	public ColliderEventHandler()
	{
	}
}
[Token(Token = "0x200003E")]
public class CustomDistanceRealTimeLightCulling : MonoBehaviour
{
	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float CullingDistance;

	[Token(Token = "0x4000106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private CullingGroup _cullingGroup;

	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Light _light;

	[Token(Token = "0x4000108")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float _cullingRadius;

	[Token(Token = "0x600010B")]
	[Address(RVA = "0xE58460", Offset = "0xE58460", VA = "0xE58460")]
	private void Awake()
	{
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0xE584D8", Offset = "0xE584D8", VA = "0xE584D8")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0xE58568", Offset = "0xE58568", VA = "0xE58568")]
	public CustomDistanceRealTimeLightCulling()
	{
	}
}
[Token(Token = "0x200003F")]
public class CustomParticleCulling : MonoBehaviour
{
	[Token(Token = "0x4000109")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float CullingRadius;

	[Token(Token = "0x400010A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float CullingDistance;

	[Token(Token = "0x400010B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float FastForwardTime;

	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private CullingGroup _cullingGroup;

	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private ParticleSystem _target;

	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private ParticleSystemRenderer _renderer;

	[Token(Token = "0x600010E")]
	[Address(RVA = "0xE58578", Offset = "0xE58578", VA = "0xE58578")]
	private void Awake()
	{
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0xE58608", Offset = "0xE58608", VA = "0xE58608")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0xE58698", Offset = "0xE58698", VA = "0xE58698")]
	public CustomParticleCulling()
	{
	}
}
[Token(Token = "0x2000040")]
public class Effect : AttachedBehaviour, IPooled<Effect>
{
	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float EffectLength;

	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public bool DestroyOnCompletion;

	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
	private bool _isFollower;

	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private ParticleSystem[] _emitters;

	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool _played;

	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private float _startTime;

	[Token(Token = "0x17000024")]
	public int PoolID
	{
		[Token(Token = "0x6000111")]
		[Address(RVA = "0xE586B4", Offset = "0xE586B4", VA = "0xE586B4", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000112")]
		[Address(RVA = "0xE586BC", Offset = "0xE586BC", VA = "0xE586BC", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000025")]
	public ObjectPooler<Effect> Pool
	{
		[Token(Token = "0x6000113")]
		[Address(RVA = "0xE586C4", Offset = "0xE586C4", VA = "0xE586C4", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000114")]
		[Address(RVA = "0xE586CC", Offset = "0xE586CC", VA = "0xE586CC", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0xE586D4", Offset = "0xE586D4", VA = "0xE586D4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0xE5872C", Offset = "0xE5872C", VA = "0xE5872C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0xE5873C", Offset = "0xE5873C", VA = "0xE5873C")]
	public void ResetEffect()
	{
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0xE54180", Offset = "0xE54180", VA = "0xE54180")]
	public void StartEffect()
	{
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0xE587B8", Offset = "0xE587B8", VA = "0xE587B8", Slot = "4")]
	protected override void Update()
	{
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0xE58914", Offset = "0xE58914", VA = "0xE58914", Slot = "5")]
	public override void SetParentToFollow(Transform parent)
	{
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0xE58878", Offset = "0xE58878", VA = "0xE58878")]
	private void Depop()
	{
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0xE58994", Offset = "0xE58994", VA = "0xE58994")]
	public Effect()
	{
	}
}
[Token(Token = "0x2000041")]
public class FSM<TEnum, TStateType> where TEnum : struct, IConvertible, IComparable where TStateType : FSMState<TEnum>
{
	[Token(Token = "0x4000117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private Dictionary<TEnum, TStateType> _statesDictionary;

	[Token(Token = "0x4000118")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private Stack<TEnum> _statesStack;

	[Token(Token = "0x4000119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private TStateType _currentState;

	[Token(Token = "0x17000026")]
	public TStateType CurrentState
	{
		[Token(Token = "0x600011D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600011E")]
	public FSM()
	{
	}

	[Token(Token = "0x600011F")]
	public void AddState(TStateType state)
	{
	}

	[Token(Token = "0x6000120")]
	public void DeleteState(TEnum id)
	{
	}

	[Token(Token = "0x6000121")]
	public void ChangeToState(TEnum nextStateId, bool pushCurrentState = false)
	{
	}

	[Token(Token = "0x6000122")]
	public void PopPreviousState()
	{
	}

	[Token(Token = "0x6000123")]
	public void Update(float deltaTime)
	{
	}
}
[Token(Token = "0x2000042")]
public abstract class FSMState<TEnum> where TEnum : struct, IConvertible, IComparable
{
	[Token(Token = "0x400011A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	protected TEnum _stateID;

	[Token(Token = "0x17000027")]
	public TEnum ID
	{
		[Token(Token = "0x6000124")]
		get
		{
			return (TEnum)null;
		}
	}

	[Token(Token = "0x6000125")]
	public FSMState()
	{
	}

	[Token(Token = "0x6000126")]
	protected abstract void SetEnum();

	[Token(Token = "0x6000127")]
	public virtual void EnterState(TEnum previousStateID)
	{
	}

	[Token(Token = "0x6000128")]
	public virtual void ExitState(TEnum nextStateID)
	{
	}

	[Token(Token = "0x6000129")]
	public abstract void Update(float deltaTime);
}
[Token(Token = "0x2000043")]
public class FXActivator2 : MonoBehaviour
{
	[Token(Token = "0x600012A")]
	[Address(RVA = "0xE589AC", Offset = "0xE589AC", VA = "0xE589AC")]
	public FXActivator2()
	{
	}
}
[Serializable]
[Token(Token = "0x2000044")]
public abstract class GenericPoolGroup<T, U> : MonoBehaviour where T : MonoBehaviour, IPooled<T> where U : Enum
{
	[Serializable]
	[Token(Token = "0x2000045")]
	protected struct PoolOptions
	{
		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public U Type;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T Prefab;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int Count;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool AllowRecycle;
	}

	[Token(Token = "0x400011B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[SerializeField]
	protected List<PoolOptions> _poolsList;

	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	protected Dictionary<U, ObjectPooler<T>> _pools;

	[Token(Token = "0x600012B")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x600012C")]
	public void Initialize()
	{
	}

	[Token(Token = "0x600012D")]
	protected GenericPoolGroup()
	{
	}
}
[Token(Token = "0x2000046")]
public class HiResScreenShots : MonoBehaviour
{
	[Token(Token = "0x4000121")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int ResWidth;

	[Token(Token = "0x4000122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int ResHeight;

	[Token(Token = "0x4000123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool _takeHiResShot;

	[Token(Token = "0x4000124")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Camera _camera;

	[Token(Token = "0x600012E")]
	[Address(RVA = "0xE589B4", Offset = "0xE589B4", VA = "0xE589B4")]
	private void Awake()
	{
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0xE58A1C", Offset = "0xE58A1C", VA = "0xE58A1C")]
	public static string ScreenShotName(int width, int height)
	{
		return null;
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0xE58C2C", Offset = "0xE58C2C", VA = "0xE58C2C")]
	public void TakeHiResShot()
	{
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0xE58C38", Offset = "0xE58C38", VA = "0xE58C38")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0xE58E90", Offset = "0xE58E90", VA = "0xE58E90")]
	public HiResScreenShots()
	{
	}
}
[Token(Token = "0x2000047")]
public class IgnoreMutualColliders : MonoBehaviour
{
	[Token(Token = "0x4000125")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Collider[] CollidersGroup1;

	[Token(Token = "0x4000126")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Collider[] CollidersGroup2;

	[Token(Token = "0x6000133")]
	[Address(RVA = "0xE58EA4", Offset = "0xE58EA4", VA = "0xE58EA4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0xE58F58", Offset = "0xE58F58", VA = "0xE58F58")]
	public IgnoreMutualColliders()
	{
	}
}
[Token(Token = "0x2000048")]
public class MidiRead : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000049")]
	public sealed class NoteInfo
	{
		[Token(Token = "0x17000028")]
		public MetricTimeSpan Time
		{
			[Token(Token = "0x6000139")]
			[Address(RVA = "0xE5971C", Offset = "0xE5971C", VA = "0xE5971C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600013A")]
			[Address(RVA = "0xE59724", Offset = "0xE59724", VA = "0xE59724")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000029")]
		public MetricTimeSpan Length
		{
			[Token(Token = "0x600013B")]
			[Address(RVA = "0xE5972C", Offset = "0xE5972C", VA = "0xE5972C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600013C")]
			[Address(RVA = "0xE59734", Offset = "0xE59734", VA = "0xE59734")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public int NoteNumber
		{
			[Token(Token = "0x600013D")]
			[Address(RVA = "0xE5973C", Offset = "0xE5973C", VA = "0xE5973C")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600013E")]
			[Address(RVA = "0xE59744", Offset = "0xE59744", VA = "0xE59744")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public int Velocity
		{
			[Token(Token = "0x600013F")]
			[Address(RVA = "0xE5974C", Offset = "0xE5974C", VA = "0xE5974C")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000140")]
			[Address(RVA = "0xE59754", Offset = "0xE59754", VA = "0xE59754")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0xE5975C", Offset = "0xE5975C", VA = "0xE5975C")]
		public NoteInfo()
		{
		}
	}

	[Token(Token = "0x4000127")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static IEnumerable<NoteInfo> notes;

	[Token(Token = "0x4000128")]
	private const int ACCENTED_VELOCITY_THRESHOLD = 120;

	[Token(Token = "0x4000129")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static readonly Dictionary<int, TaikoNoteInfo.Type> NOTE_TYPE_DICTIONARY;

	[Token(Token = "0x400012A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static readonly Dictionary<int, TaikoNoteInfo.Type> FORCE_CENTER_NOTE_DICTIONARY;

	[Token(Token = "0x6000135")]
	[Address(RVA = "0xE58F60", Offset = "0xE58F60", VA = "0xE58F60")]
	private static IEnumerable<NoteInfo> GetNotesInfo(string filePath, int bpm)
	{
		return null;
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0xE590E0", Offset = "0xE590E0", VA = "0xE590E0")]
	public static List<TaikoNoteInfo> GetNoteInfos(string filePath, int bpm = 130, bool forceCenter = false)
	{
		return null;
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0xE594D4", Offset = "0xE594D4", VA = "0xE594D4")]
	public MidiRead()
	{
	}
}
[Token(Token = "0x200004B")]
public class ObbExtractor : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200004C")]
	private class CopyManifest
	{
		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int Version;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string[] Paths;

		[Token(Token = "0x6000148")]
		[Address(RVA = "0xE59A4C", Offset = "0xE59A4C", VA = "0xE59A4C")]
		public string ToJSON()
		{
			return null;
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0xE59A54", Offset = "0xE59A54", VA = "0xE59A54")]
		public CopyManifest()
		{
		}
	}

	[Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class <CopyObbFiles>d__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ObbExtractor <>4__this;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string <manifestPath>5__2;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool <shouldCopy>5__3;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private UnityWebRequest <manifestRequest>5__4;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool <failedCopy>5__5;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string[] <>7__wrap5;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int <>7__wrap6;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private string <destPath>5__8;

		[Token(Token = "0x1700002C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600014D")]
			[Address(RVA = "0xE59EEC", Offset = "0xE59EEC", VA = "0xE59EEC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600014F")]
			[Address(RVA = "0xE59F34", Offset = "0xE59F34", VA = "0xE59F34", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0xE59924", Offset = "0xE59924", VA = "0xE59924")]
		[DebuggerHidden]
		public <CopyObbFiles>d__3(int <>1__state)
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0xE59A5C", Offset = "0xE59A5C", VA = "0xE59A5C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0xE59A60", Offset = "0xE59A60", VA = "0xE59A60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0xE59EF4", Offset = "0xE59EF4", VA = "0xE59EF4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000130")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private CopyManifest _copyManifest;

	[Token(Token = "0x4000131")]
	private const string MANIFEST_FILE = "copy_manifest.json";

	[Token(Token = "0x6000144")]
	[Address(RVA = "0xE59890", Offset = "0xE59890", VA = "0xE59890")]
	private void Start()
	{
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0xE598B0", Offset = "0xE598B0", VA = "0xE598B0")]
	[IteratorStateMachine(typeof(<CopyObbFiles>d__3))]
	private IEnumerator CopyObbFiles()
	{
		return null;
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0xE5994C", Offset = "0xE5994C", VA = "0xE5994C")]
	private bool Save(byte[] data, string outputPath)
	{
		return default(bool);
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0xE59A44", Offset = "0xE59A44", VA = "0xE59A44")]
	public ObbExtractor()
	{
	}
}
[Token(Token = "0x200004E")]
public class ObjectPooler<T> where T : MonoBehaviour, IPooled<T>
{
	[Token(Token = "0x400013E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public T[] Instances;

	[Token(Token = "0x400013F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	protected Stack<int> _freeIdx;

	[Token(Token = "0x4000140")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	protected List<int> _activeIdx;

	[Token(Token = "0x4000141")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	protected bool _allowRecycle;

	[Token(Token = "0x4000142")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	protected string _prefabName;

	[Token(Token = "0x1700002E")]
	public bool AllowRecycle
	{
		[Token(Token = "0x6000150")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000151")]
	public void Initialize(int count, T prefab, bool allowRecycle = false)
	{
	}

	[Token(Token = "0x6000152")]
	public T GetNew(bool activate = true)
	{
		return null;
	}

	[Token(Token = "0x6000153")]
	public void Free(T obj)
	{
	}

	[Token(Token = "0x6000154")]
	public ObjectPooler()
	{
	}
}
[Token(Token = "0x200004F")]
public interface IPooled<T> where T : MonoBehaviour, IPooled<T>
{
	[Token(Token = "0x1700002F")]
	int PoolID
	{
		[Token(Token = "0x6000155")]
		get;
		[Token(Token = "0x6000156")]
		set;
	}

	[Token(Token = "0x17000030")]
	ObjectPooler<T> Pool
	{
		[Token(Token = "0x6000157")]
		get;
		[Token(Token = "0x6000158")]
		set;
	}
}
[Token(Token = "0x2000050")]
public class StartAnimRandomTime : MonoBehaviour
{
	[Token(Token = "0x4000143")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string AnimationName;

	[Token(Token = "0x4000144")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool ExecuteOnEnable;

	[Token(Token = "0x6000159")]
	[Address(RVA = "0xE59F3C", Offset = "0xE59F3C", VA = "0xE59F3C")]
	private void Start()
	{
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0xE5A014", Offset = "0xE5A014", VA = "0xE5A014")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0xE59F4C", Offset = "0xE59F4C", VA = "0xE59F4C")]
	private void StartDelayedAnimation()
	{
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0xE5A024", Offset = "0xE5A024", VA = "0xE5A024")]
	public StartAnimRandomTime()
	{
	}
}
[Serializable]
[Token(Token = "0x2000051")]
public class Timer
{
	[Token(Token = "0x4000145")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float TimerTime;

	[Token(Token = "0x4000148")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected float _elapsedTime;

	[Token(Token = "0x4000149")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	protected bool _started;

	[Token(Token = "0x17000031")]
	public float ElapsedTime
	{
		[Token(Token = "0x6000161")]
		[Address(RVA = "0xE5A29C", Offset = "0xE5A29C", VA = "0xE5A29C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000162")]
		[Address(RVA = "0xE5A2A4", Offset = "0xE5A2A4", VA = "0xE5A2A4")]
		set
		{
		}
	}

	[Token(Token = "0x14000006")]
	public event Action OnTimerEnd
	{
		[Token(Token = "0x600015D")]
		[Address(RVA = "0xE5A02C", Offset = "0xE5A02C", VA = "0xE5A02C")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600015E")]
		[Address(RVA = "0xE5A0C8", Offset = "0xE5A0C8", VA = "0xE5A0C8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000007")]
	public event Action OnTimerStart
	{
		[Token(Token = "0x600015F")]
		[Address(RVA = "0xE5A164", Offset = "0xE5A164", VA = "0xE5A164")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000160")]
		[Address(RVA = "0xE5A200", Offset = "0xE5A200", VA = "0xE5A200")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0xE5A2AC", Offset = "0xE5A2AC", VA = "0xE5A2AC")]
	public Timer(float timerTime)
	{
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0xE5A2D4", Offset = "0xE5A2D4", VA = "0xE5A2D4")]
	public void Start()
	{
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0xE5A2F8", Offset = "0xE5A2F8", VA = "0xE5A2F8")]
	protected void StartEvent()
	{
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0xE5A314", Offset = "0xE5A314", VA = "0xE5A314")]
	public void Pause()
	{
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0xE5A31C", Offset = "0xE5A31C", VA = "0xE5A31C")]
	public void Resume()
	{
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0xE5A328", Offset = "0xE5A328", VA = "0xE5A328")]
	public void Reset()
	{
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0xE5A334", Offset = "0xE5A334", VA = "0xE5A334")]
	public bool Update(float deltaTime)
	{
		return default(bool);
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0xE5A3BC", Offset = "0xE5A3BC", VA = "0xE5A3BC", Slot = "4")]
	protected virtual void TimerEnd()
	{
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0xE5A3E0", Offset = "0xE5A3E0", VA = "0xE5A3E0")]
	protected void EndEvent()
	{
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0xE5A380", Offset = "0xE5A380", VA = "0xE5A380")]
	public bool Check()
	{
		return default(bool);
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0xE5A3FC", Offset = "0xE5A3FC", VA = "0xE5A3FC")]
	public bool IsRunning()
	{
		return default(bool);
	}
}
[Serializable]
[Token(Token = "0x2000052")]
public class TimerLoop : Timer
{
	[Token(Token = "0x600016E")]
	[Address(RVA = "0xE5A404", Offset = "0xE5A404", VA = "0xE5A404")]
	public TimerLoop(float timerLoopTime)
	{
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0xE5A42C", Offset = "0xE5A42C", VA = "0xE5A42C")]
	protected void Loop()
	{
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0xE5A454", Offset = "0xE5A454", VA = "0xE5A454", Slot = "4")]
	protected override void TimerEnd()
	{
	}
}
[Serializable]
[Token(Token = "0x2000053")]
public class TimerTic : TimerLoop
{
	[Token(Token = "0x400014A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int TicNumber;

	[Token(Token = "0x6000171")]
	[Address(RVA = "0xE5A4A4", Offset = "0xE5A4A4", VA = "0xE5A4A4")]
	public TimerTic(float timerTicTime, int ticNumber)
	{
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0xE5A4DC", Offset = "0xE5A4DC", VA = "0xE5A4DC", Slot = "4")]
	protected override void TimerEnd()
	{
	}
}
[Token(Token = "0x2000054")]
public class FLFillAmount : MonoBehaviour
{
	[Token(Token = "0x400014B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Image targetImage;

	[Token(Token = "0x6000173")]
	[Address(RVA = "0xE5A548", Offset = "0xE5A548", VA = "0xE5A548")]
	private void Start()
	{
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0xE5A5A0", Offset = "0xE5A5A0", VA = "0xE5A5A0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0xE5A5EC", Offset = "0xE5A5EC", VA = "0xE5A5EC")]
	public FLFillAmount()
	{
	}
}
[Token(Token = "0x2000055")]
public class FLRotate : MonoBehaviour
{
	[Token(Token = "0x400014C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float rotateSpeed;

	[Token(Token = "0x6000176")]
	[Address(RVA = "0xE5A5F4", Offset = "0xE5A5F4", VA = "0xE5A5F4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0xE5A5F8", Offset = "0xE5A5F8", VA = "0xE5A5F8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0xE5A6A4", Offset = "0xE5A6A4", VA = "0xE5A6A4")]
	public FLRotate()
	{
	}
}
[Token(Token = "0x2000056")]
public class FLRotateSkip : MonoBehaviour
{
	[Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class <Start>d__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FLRotateSkip <>4__this;

		[Token(Token = "0x17000032")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600017E")]
			[Address(RVA = "0xE5A898", Offset = "0xE5A898", VA = "0xE5A898", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000033")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000180")]
			[Address(RVA = "0xE5A8E0", Offset = "0xE5A8E0", VA = "0xE5A8E0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0xE5A728", Offset = "0xE5A728", VA = "0xE5A728")]
		[DebuggerHidden]
		public <Start>d__2(int <>1__state)
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0xE5A764", Offset = "0xE5A764", VA = "0xE5A764", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0xE5A768", Offset = "0xE5A768", VA = "0xE5A768", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0xE5A8A0", Offset = "0xE5A8A0", VA = "0xE5A8A0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400014D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float skipTime;

	[Token(Token = "0x400014E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float skipAngle;

	[Token(Token = "0x6000179")]
	[Address(RVA = "0xE5A6B4", Offset = "0xE5A6B4", VA = "0xE5A6B4")]
	[IteratorStateMachine(typeof(<Start>d__2))]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0xE5A750", Offset = "0xE5A750", VA = "0xE5A750")]
	public FLRotateSkip()
	{
	}
}
[Token(Token = "0x2000058")]
public class FLScaleTween : MonoBehaviour
{
	[Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class <Start>d__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FLScaleTween <>4__this;

		[Token(Token = "0x17000034")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000187")]
			[Address(RVA = "0xE5AA50", Offset = "0xE5AA50", VA = "0xE5AA50", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000035")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000189")]
			[Address(RVA = "0xE5AA98", Offset = "0xE5AA98", VA = "0xE5AA98", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0xE5A95C", Offset = "0xE5A95C", VA = "0xE5A95C")]
		[DebuggerHidden]
		public <Start>d__3(int <>1__state)
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0xE5A998", Offset = "0xE5A998", VA = "0xE5A998", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0xE5A99C", Offset = "0xE5A99C", VA = "0xE5A99C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0xE5AA58", Offset = "0xE5AA58", VA = "0xE5AA58", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000152")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float delay;

	[Token(Token = "0x4000153")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Vector3 scaleSize;

	[Token(Token = "0x4000154")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float animatTime;

	[Token(Token = "0x6000181")]
	[Address(RVA = "0xE5A8E8", Offset = "0xE5A8E8", VA = "0xE5A8E8")]
	[IteratorStateMachine(typeof(<Start>d__3))]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0xE5A984", Offset = "0xE5A984", VA = "0xE5A984")]
	private void Update()
	{
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0xE5A988", Offset = "0xE5A988", VA = "0xE5A988")]
	public FLScaleTween()
	{
	}
}
[Token(Token = "0x200005A")]
public class DemoSceneController : MonoBehaviour
{
	[Token(Token = "0x4000158")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Image statusImg;

	[Token(Token = "0x4000159")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Text statusText;

	[Token(Token = "0x400015A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Text reachabilityText;

	[Token(Token = "0x400015B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Text descriptionText;

	[Token(Token = "0x600018A")]
	[Address(RVA = "0xE5AAA0", Offset = "0xE5AAA0", VA = "0xE5AAA0")]
	private void Awake()
	{
	}

	[Token(Token = "0x600018B")]
	[Address(RVA = "0xE5ABDC", Offset = "0xE5ABDC", VA = "0xE5ABDC")]
	private void Update()
	{
	}

	[Token(Token = "0x600018C")]
	[Address(RVA = "0xE5AB4C", Offset = "0xE5AB4C", VA = "0xE5AB4C")]
	public void CheckNow()
	{
	}

	[Token(Token = "0x600018D")]
	[Address(RVA = "0xE5ADC8", Offset = "0xE5ADC8", VA = "0xE5ADC8")]
	private void OnNetStatusChanged()
	{
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0xE5AFE4", Offset = "0xE5AFE4", VA = "0xE5AFE4")]
	public DemoSceneController()
	{
	}
}
[Token(Token = "0x200005B")]
[RequireComponent(typeof(Light))]
public class CFX_LightIntensityFade : MonoBehaviour
{
	[Token(Token = "0x400015C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float duration;

	[Token(Token = "0x400015D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float delay;

	[Token(Token = "0x400015E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float finalIntensity;

	[Token(Token = "0x400015F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float baseIntensity;

	[Token(Token = "0x4000160")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool autodestruct;

	[Token(Token = "0x4000161")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float p_lifetime;

	[Token(Token = "0x4000162")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float p_delay;

	[Token(Token = "0x4000163")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Light _light;

	[Token(Token = "0x600018F")]
	[Address(RVA = "0xE5AFEC", Offset = "0xE5AFEC", VA = "0xE5AFEC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000190")]
	[Address(RVA = "0xE5B064", Offset = "0xE5B064", VA = "0xE5B064")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000191")]
	[Address(RVA = "0xE5B0AC", Offset = "0xE5B0AC", VA = "0xE5B0AC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000192")]
	[Address(RVA = "0xE5B1EC", Offset = "0xE5B1EC", VA = "0xE5B1EC")]
	public CFX_LightIntensityFade()
	{
	}
}
[Token(Token = "0x200005C")]
public class DebugUIBuilder : MonoBehaviour
{
	[Token(Token = "0x200005D")]
	public delegate void OnClick();

	[Token(Token = "0x200005E")]
	public delegate void OnToggleValueChange(Toggle t);

	[Token(Token = "0x200005F")]
	public delegate void OnSlider(float f);

	[Token(Token = "0x2000060")]
	public delegate bool ActiveUpdate();

	[Token(Token = "0x4000164")]
	public const int DEBUG_PANE_CENTER = 0;

	[Token(Token = "0x4000165")]
	public const int DEBUG_PANE_RIGHT = 1;

	[Token(Token = "0x4000166")]
	public const int DEBUG_PANE_LEFT = 2;

	[Token(Token = "0x4000167")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RectTransform buttonPrefab;

	[Token(Token = "0x4000168")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private RectTransform[] additionalButtonPrefab;

	[Token(Token = "0x4000169")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private RectTransform labelPrefab;

	[Token(Token = "0x400016A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private RectTransform sliderPrefab;

	[Token(Token = "0x400016B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private RectTransform dividerPrefab;

	[Token(Token = "0x400016C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private RectTransform togglePrefab;

	[Token(Token = "0x400016D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private RectTransform radioPrefab;

	[Token(Token = "0x400016E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private RectTransform textPrefab;

	[Token(Token = "0x400016F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private GameObject uiHelpersToInstantiate;

	[Token(Token = "0x4000170")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Transform[] targetContentPanels;

	[Token(Token = "0x4000171")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private bool[] reEnable;

	[Token(Token = "0x4000172")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private List<GameObject> toEnable;

	[Token(Token = "0x4000173")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private List<GameObject> toDisable;

	[Token(Token = "0x4000174")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static DebugUIBuilder instance;

	[Token(Token = "0x4000175")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float elementSpacing;

	[Token(Token = "0x4000176")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public float marginH;

	[Token(Token = "0x4000177")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public float marginV;

	[Token(Token = "0x4000178")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Vector2[] insertPositions;

	[Token(Token = "0x4000179")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private List<RectTransform>[] insertedElements;

	[Token(Token = "0x400017A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Vector3 menuOffset;

	[Token(Token = "0x400017B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private OVRCameraRig rig;

	[Token(Token = "0x400017C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private Dictionary<string, ToggleGroup> radioGroups;

	[Token(Token = "0x400017D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private LaserPointer lp;

	[Token(Token = "0x400017E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private LineRenderer lr;

	[Token(Token = "0x400017F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public LaserPointer.LaserBeamBehavior laserBeamBehavior;

	[Token(Token = "0x4000180")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	public bool isHorizontal;

	[Token(Token = "0x4000181")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD5")]
	public bool usePanelCentricRelayout;

	[Token(Token = "0x6000193")]
	[Address(RVA = "0xE5B1FC", Offset = "0xE5B1FC", VA = "0xE5B1FC")]
	public void Awake()
	{
	}

	[Token(Token = "0x6000194")]
	[Address(RVA = "0xE5B768", Offset = "0xE5B768", VA = "0xE5B768")]
	public void Show()
	{
	}

	[Token(Token = "0x6000195")]
	[Address(RVA = "0xE5BAE4", Offset = "0xE5BAE4", VA = "0xE5BAE4")]
	public void Hide()
	{
	}

	[Token(Token = "0x6000196")]
	[Address(RVA = "0xE5BC60", Offset = "0xE5BC60", VA = "0xE5BC60")]
	private void StackedRelayout()
	{
	}

	[Token(Token = "0x6000197")]
	[Address(RVA = "0xE5BE78", Offset = "0xE5BE78", VA = "0xE5BE78")]
	private void PanelCentricRelayout()
	{
	}

	[Token(Token = "0x6000198")]
	[Address(RVA = "0xE5BAD4", Offset = "0xE5BAD4", VA = "0xE5BAD4")]
	private void Relayout()
	{
	}

	[Token(Token = "0x6000199")]
	[Address(RVA = "0xE5C16C", Offset = "0xE5C16C", VA = "0xE5C16C")]
	private void AddRect(RectTransform r, int targetCanvas)
	{
	}

	[Token(Token = "0x600019A")]
	[Address(RVA = "0xE5C4E8", Offset = "0xE5C4E8", VA = "0xE5C4E8")]
	public RectTransform AddButton(string label, [System.Runtime.InteropServices.Optional] OnClick handler, int buttonIndex = -1, int targetCanvas = 0, bool highResolutionText = false)
	{
		return null;
	}

	[Token(Token = "0x600019B")]
	[Address(RVA = "0xE5C898", Offset = "0xE5C898", VA = "0xE5C898")]
	public RectTransform AddLabel(string label, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x600019C")]
	[Address(RVA = "0xE5C990", Offset = "0xE5C990", VA = "0xE5C990")]
	public RectTransform AddSlider(string label, float min, float max, OnSlider onValueChanged, bool wholeNumbersOnly = false, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x600019D")]
	[Address(RVA = "0xE5CB60", Offset = "0xE5CB60", VA = "0xE5CB60")]
	public RectTransform AddDivider(int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x600019E")]
	[Address(RVA = "0xE5CBF8", Offset = "0xE5CBF8", VA = "0xE5CBF8")]
	public RectTransform AddToggle(string label, OnToggleValueChange onValueChanged, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0xE5CDD4", Offset = "0xE5CDD4", VA = "0xE5CDD4")]
	public RectTransform AddToggle(string label, OnToggleValueChange onValueChanged, bool defaultValue, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x60001A0")]
	[Address(RVA = "0xE5CFD0", Offset = "0xE5CFD0", VA = "0xE5CFD0")]
	public RectTransform AddRadio(string label, string group, OnToggleValueChange handler, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0xE5D2C8", Offset = "0xE5D2C8", VA = "0xE5D2C8")]
	public RectTransform AddTextField(string label, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0xE5D3B8", Offset = "0xE5D3B8", VA = "0xE5D3B8")]
	public void ToggleLaserPointer(bool isOn)
	{
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0xE5D44C", Offset = "0xE5D44C", VA = "0xE5D44C")]
	public DebugUIBuilder()
	{
	}
}
[Token(Token = "0x2000066")]
public class HandedInputSelector : MonoBehaviour
{
	[Token(Token = "0x400018A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRCameraRig m_CameraRig;

	[Token(Token = "0x400018B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private OVRInputModule m_InputModule;

	[Token(Token = "0x60001BE")]
	[Address(RVA = "0xE5DACC", Offset = "0xE5DACC", VA = "0xE5DACC")]
	private void Start()
	{
	}

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0xE5DB70", Offset = "0xE5DB70", VA = "0xE5DB70")]
	private void Update()
	{
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0xE5DC0C", Offset = "0xE5DC0C", VA = "0xE5DC0C")]
	private void SetActiveController(OVRInput.Controller c)
	{
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0xE5DC44", Offset = "0xE5DC44", VA = "0xE5DC44")]
	public HandedInputSelector()
	{
	}
}
[Token(Token = "0x2000067")]
public class LaserPointer : OVRCursor
{
	[Token(Token = "0x2000068")]
	public enum LaserBeamBehavior
	{
		[Token(Token = "0x4000196")]
		On,
		[Token(Token = "0x4000197")]
		Off,
		[Token(Token = "0x4000198")]
		OnWhenHitTarget
	}

	[Token(Token = "0x400018C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject cursorVisual;

	[Token(Token = "0x400018D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float maxLength;

	[Token(Token = "0x400018E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private LaserBeamBehavior _laserBeamBehavior;

	[Token(Token = "0x400018F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool m_restoreOnInputAcquired;

	[Token(Token = "0x4000190")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private Vector3 _startPoint;

	[Token(Token = "0x4000191")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector3 _forward;

	[Token(Token = "0x4000192")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private Vector3 _endPoint;

	[Token(Token = "0x4000193")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool _hitTarget;

	[Token(Token = "0x4000194")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private LineRenderer lineRenderer;

	[Token(Token = "0x17000036")]
	public LaserBeamBehavior laserBeamBehavior
	{
		[Token(Token = "0x60001C3")]
		[Address(RVA = "0xE5DC4C", Offset = "0xE5DC4C", VA = "0xE5DC4C")]
		get
		{
			return default(LaserBeamBehavior);
		}
		[Token(Token = "0x60001C2")]
		[Address(RVA = "0xE5B728", Offset = "0xE5B728", VA = "0xE5B728")]
		set
		{
		}
	}

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0xE5DC54", Offset = "0xE5DC54", VA = "0xE5DC54")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001C5")]
	[Address(RVA = "0xE5DCAC", Offset = "0xE5DCAC", VA = "0xE5DCAC")]
	private void Start()
	{
	}

	[Token(Token = "0x60001C6")]
	[Address(RVA = "0xE5DDE4", Offset = "0xE5DDE4", VA = "0xE5DDE4", Slot = "5")]
	public override void SetCursorStartDest(Vector3 start, Vector3 dest, Vector3 normal)
	{
	}

	[Token(Token = "0x60001C7")]
	[Address(RVA = "0xE5DE00", Offset = "0xE5DE00", VA = "0xE5DE00", Slot = "4")]
	public override void SetCursorRay(Transform t)
	{
	}

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0xE5DE50", Offset = "0xE5DE50", VA = "0xE5DE50")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0xE5DFF0", Offset = "0xE5DFF0", VA = "0xE5DFF0")]
	private void UpdateLaserBeam(Vector3 start, Vector3 end)
	{
	}

	[Token(Token = "0x60001CA")]
	[Address(RVA = "0xE5E100", Offset = "0xE5E100", VA = "0xE5E100")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0xE5E184", Offset = "0xE5E184", VA = "0xE5E184")]
	public void OnInputFocusLost()
	{
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0xE5E244", Offset = "0xE5E244", VA = "0xE5E244")]
	public void OnInputFocusAcquired()
	{
	}

	[Token(Token = "0x60001CD")]
	[Address(RVA = "0xE5E2EC", Offset = "0xE5E2EC", VA = "0xE5E2EC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60001CE")]
	[Address(RVA = "0xE5E3D8", Offset = "0xE5E3D8", VA = "0xE5E3D8")]
	public LaserPointer()
	{
	}
}
[Token(Token = "0x2000069")]
public class CharacterCameraConstraint : MonoBehaviour
{
	[Token(Token = "0x4000199")]
	private const float FADE_RAY_LENGTH = 0.25f;

	[Token(Token = "0x400019A")]
	private const float FADE_OVERLAP_MAXIMUM = 0.1f;

	[Token(Token = "0x400019B")]
	private const float FADE_AMOUNT_MAXIMUM = 1f;

	[Token(Token = "0x400019C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Tooltip("This should be a reference to the OVRCameraRig that is usually a child of the PlayerController.")]
	public OVRCameraRig CameraRig;

	[Token(Token = "0x400019D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Tooltip("Collision layers to be used for the purposes of fading out the screen when the HMD is inside world geometry and adjusting the capsule height.")]
	public LayerMask CollideLayers;

	[Token(Token = "0x400019E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Tooltip("Offset is added to camera's real world height, effectively treating it as though the player was taller/standing higher.")]
	public float HeightOffset;

	[Token(Token = "0x400019F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Tooltip("Minimum height that the character capsule can shrink to.  To disable, set to capsule's height.")]
	public float MinimumHeight;

	[Token(Token = "0x40001A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[Tooltip("Maximum height that the character capsule can grow to.  To disable, set to capsule's height.")]
	public float MaximumHeight;

	[Token(Token = "0x40001A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private CapsuleCollider _character;

	[Token(Token = "0x40001A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private SimpleCapsuleWithStickMovement _simplePlayerController;

	[Token(Token = "0x60001CF")]
	[Address(RVA = "0xE5E3E8", Offset = "0xE5E3E8", VA = "0xE5E3E8")]
	private CharacterCameraConstraint()
	{
	}

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0xE5E3F0", Offset = "0xE5E3F0", VA = "0xE5E3F0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001D1")]
	[Address(RVA = "0xE5E480", Offset = "0xE5E480", VA = "0xE5E480")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0xE5E5A4", Offset = "0xE5E5A4", VA = "0xE5E5A4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0xE5E6C8", Offset = "0xE5E6C8", VA = "0xE5E6C8")]
	private void CameraUpdate()
	{
	}

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0xE5E9E8", Offset = "0xE5E9E8", VA = "0xE5E9E8")]
	private bool CheckCameraOverlapped()
	{
		return default(bool);
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0xE5EC48", Offset = "0xE5EC48", VA = "0xE5EC48")]
	private bool CheckCameraNearClipping(out float result)
	{
		return default(bool);
	}
}
[Token(Token = "0x200006A")]
public class LocomotionController : MonoBehaviour
{
	[Token(Token = "0x40001A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRCameraRig CameraRig;

	[Token(Token = "0x40001A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public CapsuleCollider CharacterController;

	[Token(Token = "0x40001A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public SimpleCapsuleWithStickMovement PlayerController;

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0xE5F3A0", Offset = "0xE5F3A0", VA = "0xE5F3A0")]
	private void Start()
	{
	}

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0xE5F44C", Offset = "0xE5F44C", VA = "0xE5F44C")]
	public LocomotionController()
	{
	}
}
[Token(Token = "0x200006B")]
public class LocomotionTeleport : MonoBehaviour
{
	[Token(Token = "0x200006C")]
	public enum States
	{
		[Token(Token = "0x40001C9")]
		Ready,
		[Token(Token = "0x40001CA")]
		Aim,
		[Token(Token = "0x40001CB")]
		CancelAim,
		[Token(Token = "0x40001CC")]
		PreTeleport,
		[Token(Token = "0x40001CD")]
		CancelTeleport,
		[Token(Token = "0x40001CE")]
		Teleporting,
		[Token(Token = "0x40001CF")]
		PostTeleport
	}

	[Token(Token = "0x200006D")]
	public enum TeleportIntentions
	{
		[Token(Token = "0x40001D1")]
		None,
		[Token(Token = "0x40001D2")]
		Aim,
		[Token(Token = "0x40001D3")]
		PreTeleport,
		[Token(Token = "0x40001D4")]
		Teleport
	}

	[Token(Token = "0x200006E")]
	public enum AimCollisionTypes
	{
		[Token(Token = "0x40001D6")]
		Point,
		[Token(Token = "0x40001D7")]
		Sphere,
		[Token(Token = "0x40001D8")]
		Capsule
	}

	[Token(Token = "0x200006F")]
	public class AimData
	{
		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RaycastHit TargetHitInfo;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool TargetValid;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3? Destination;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float Radius;

		[Token(Token = "0x1700003A")]
		public List<Vector3> Points
		{
			[Token(Token = "0x600020D")]
			[Address(RVA = "0xE6118C", Offset = "0xE6118C", VA = "0xE6118C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600020E")]
			[Address(RVA = "0xE61194", Offset = "0xE61194", VA = "0xE61194")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0xE61104", Offset = "0xE61104", VA = "0xE61104")]
		public AimData()
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0xE6119C", Offset = "0xE6119C", VA = "0xE6119C")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class <ReadyStateCoroutine>d__52 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x1700003B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000213")]
			[Address(RVA = "0xE61304", Offset = "0xE61304", VA = "0xE61304", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000215")]
			[Address(RVA = "0xE6134C", Offset = "0xE6134C", VA = "0xE6134C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0xE5FE58", Offset = "0xE5FE58", VA = "0xE5FE58")]
		[DebuggerHidden]
		public <ReadyStateCoroutine>d__52(int <>1__state)
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0xE611F4", Offset = "0xE611F4", VA = "0xE611F4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0xE611F8", Offset = "0xE611F8", VA = "0xE611F8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0xE6130C", Offset = "0xE6130C", VA = "0xE6130C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000071")]
	[CompilerGenerated]
	private sealed class <AimStateCoroutine>d__64 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x1700003D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000219")]
			[Address(RVA = "0xE614B0", Offset = "0xE614B0", VA = "0xE614B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600021B")]
			[Address(RVA = "0xE614F8", Offset = "0xE614F8", VA = "0xE614F8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0xE602E0", Offset = "0xE602E0", VA = "0xE602E0")]
		[DebuggerHidden]
		public <AimStateCoroutine>d__64(int <>1__state)
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0xE61354", Offset = "0xE61354", VA = "0xE61354", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0xE61358", Offset = "0xE61358", VA = "0xE61358", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0xE614B8", Offset = "0xE614B8", VA = "0xE614B8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000072")]
	[CompilerGenerated]
	private sealed class <CancelAimStateCoroutine>d__68 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x1700003F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600021F")]
			[Address(RVA = "0xE615B0", Offset = "0xE615B0", VA = "0xE615B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000040")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000221")]
			[Address(RVA = "0xE615F8", Offset = "0xE615F8", VA = "0xE615F8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0xE604B4", Offset = "0xE604B4", VA = "0xE604B4")]
		[DebuggerHidden]
		public <CancelAimStateCoroutine>d__68(int <>1__state)
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0xE61500", Offset = "0xE61500", VA = "0xE61500", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0xE61504", Offset = "0xE61504", VA = "0xE61504", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0xE615B8", Offset = "0xE615B8", VA = "0xE615B8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000073")]
	[CompilerGenerated]
	private sealed class <PreTeleportStateCoroutine>d__72 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000041")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000225")]
			[Address(RVA = "0xE616E8", Offset = "0xE616E8", VA = "0xE616E8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000042")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000227")]
			[Address(RVA = "0xE61730", Offset = "0xE61730", VA = "0xE61730", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0xE60688", Offset = "0xE60688", VA = "0xE60688")]
		[DebuggerHidden]
		public <PreTeleportStateCoroutine>d__72(int <>1__state)
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0xE61600", Offset = "0xE61600", VA = "0xE61600", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0xE61604", Offset = "0xE61604", VA = "0xE61604", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0xE616F0", Offset = "0xE616F0", VA = "0xE616F0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000074")]
	[CompilerGenerated]
	private sealed class <CancelTeleportStateCoroutine>d__76 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000043")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600022B")]
			[Address(RVA = "0xE617E8", Offset = "0xE617E8", VA = "0xE617E8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000044")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600022D")]
			[Address(RVA = "0xE61830", Offset = "0xE61830", VA = "0xE61830", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0xE6085C", Offset = "0xE6085C", VA = "0xE6085C")]
		[DebuggerHidden]
		public <CancelTeleportStateCoroutine>d__76(int <>1__state)
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0xE61738", Offset = "0xE61738", VA = "0xE61738", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0xE6173C", Offset = "0xE6173C", VA = "0xE6173C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0xE617F0", Offset = "0xE617F0", VA = "0xE617F0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000075")]
	[CompilerGenerated]
	private sealed class <TeleportingStateCoroutine>d__80 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000045")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000231")]
			[Address(RVA = "0xE6191C", Offset = "0xE6191C", VA = "0xE6191C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000046")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000233")]
			[Address(RVA = "0xE61964", Offset = "0xE61964", VA = "0xE61964", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0xE60A30", Offset = "0xE60A30", VA = "0xE60A30")]
		[DebuggerHidden]
		public <TeleportingStateCoroutine>d__80(int <>1__state)
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0xE61838", Offset = "0xE61838", VA = "0xE61838", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0xE6183C", Offset = "0xE6183C", VA = "0xE6183C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0xE61924", Offset = "0xE61924", VA = "0xE61924", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000076")]
	[CompilerGenerated]
	private sealed class <PostTeleportStateCoroutine>d__84 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000047")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000237")]
			[Address(RVA = "0xE61A6C", Offset = "0xE61A6C", VA = "0xE61A6C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000048")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000239")]
			[Address(RVA = "0xE61AB4", Offset = "0xE61AB4", VA = "0xE61AB4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0xE60C04", Offset = "0xE60C04", VA = "0xE60C04")]
		[DebuggerHidden]
		public <PostTeleportStateCoroutine>d__84(int <>1__state)
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0xE6196C", Offset = "0xE6196C", VA = "0xE6196C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0xE61970", Offset = "0xE61970", VA = "0xE61970", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0xE61A74", Offset = "0xE61A74", VA = "0xE61A74", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40001A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Tooltip("Allow linear movement prior to the teleport system being activated.")]
	public bool EnableMovementDuringReady;

	[Token(Token = "0x40001A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	[Tooltip("Allow linear movement while the teleport system is in the process of aiming for a teleport target.")]
	public bool EnableMovementDuringAim;

	[Token(Token = "0x40001A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	[Tooltip("Allow linear movement while the teleport system is in the process of configuring the landing orientation.")]
	public bool EnableMovementDuringPreTeleport;

	[Token(Token = "0x40001A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
	[Tooltip("Allow linear movement after the teleport has occurred but before the system has returned to the ready state.")]
	public bool EnableMovementDuringPostTeleport;

	[Token(Token = "0x40001AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Tooltip("Allow rotation prior to the teleport system being activated.")]
	public bool EnableRotationDuringReady;

	[Token(Token = "0x40001AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	[Tooltip("Allow rotation while the teleport system is in the process of aiming for a teleport target.")]
	public bool EnableRotationDuringAim;

	[Token(Token = "0x40001AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
	[Tooltip("Allow rotation while the teleport system is in the process of configuring the landing orientation.")]
	public bool EnableRotationDuringPreTeleport;

	[Token(Token = "0x40001AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F")]
	[Tooltip("Allow rotation after the teleport has occurred but before the system has returned to the ready state.")]
	public bool EnableRotationDuringPostTeleport;

	[NonSerialized]
	[Token(Token = "0x40001AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TeleportAimHandler AimHandler;

	[Token(Token = "0x40001B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Tooltip("This prefab will be instantiated as needed and updated to match the current aim target.")]
	public TeleportDestination TeleportDestinationPrefab;

	[Token(Token = "0x40001B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Tooltip("TeleportDestinationPrefab will be instantiated into this layer.")]
	public int TeleportDestinationLayer;

	[NonSerialized]
	[Token(Token = "0x40001B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TeleportInputHandler InputHandler;

	[NonSerialized]
	[Token(Token = "0x40001B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public TeleportIntentions CurrentIntention;

	[NonSerialized]
	[Token(Token = "0x40001B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public bool IsPreTeleportRequested;

	[NonSerialized]
	[Token(Token = "0x40001B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
	public bool IsTransitioning;

	[NonSerialized]
	[Token(Token = "0x40001B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x56")]
	public bool IsPostTeleportRequested;

	[Token(Token = "0x40001B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private TeleportDestination _teleportDestination;

	[Token(Token = "0x40001BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[Tooltip("When aiming at possible destinations, the aim collision type determines which shape to use for collision tests.")]
	public AimCollisionTypes AimCollisionType;

	[Token(Token = "0x40001BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	[Tooltip("Use the character collision radius/height/skinwidth for sphere/capsule collision tests.")]
	public bool UseCharacterCollisionData;

	[Token(Token = "0x40001BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[Tooltip("Radius of the sphere or capsule used for collision testing when aiming to possible teleport destinations. Ignored if UseCharacterCollisionData is true.")]
	public float AimCollisionRadius;

	[Token(Token = "0x40001BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	[Tooltip("Height of the capsule used for collision testing when aiming to possible teleport destinations. Ignored if UseCharacterCollisionData is true.")]
	public float AimCollisionHeight;

	[Token(Token = "0x17000037")]
	public States CurrentState
	{
		[Token(Token = "0x60001DA")]
		[Address(RVA = "0xE5F49C", Offset = "0xE5F49C", VA = "0xE5F49C")]
		[CompilerGenerated]
		get
		{
			return default(States);
		}
		[Token(Token = "0x60001DB")]
		[Address(RVA = "0xE5F4A4", Offset = "0xE5F4A4", VA = "0xE5F4A4")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000038")]
	public Quaternion DestinationRotation
	{
		[Token(Token = "0x60001DF")]
		[Address(RVA = "0xE5F674", Offset = "0xE5F674", VA = "0xE5F674")]
		get
		{
			return default(Quaternion);
		}
	}

	[Token(Token = "0x17000039")]
	public LocomotionController LocomotionController
	{
		[Token(Token = "0x60001E0")]
		[Address(RVA = "0xE5F698", Offset = "0xE5F698", VA = "0xE5F698")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60001E1")]
		[Address(RVA = "0xE5F6A0", Offset = "0xE5F6A0", VA = "0xE5F6A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x14000008")]
	public event Action<bool, Vector3?, Quaternion?, Quaternion?> UpdateTeleportDestination
	{
		[Token(Token = "0x60001DC")]
		[Address(RVA = "0xE5F4AC", Offset = "0xE5F4AC", VA = "0xE5F4AC")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60001DD")]
		[Address(RVA = "0xE5F55C", Offset = "0xE5F55C", VA = "0xE5F55C")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000009")]
	public event Action EnterStateReady
	{
		[Token(Token = "0x60001EB")]
		[Address(RVA = "0xE5FD20", Offset = "0xE5FD20", VA = "0xE5FD20")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60001EC")]
		[Address(RVA = "0xE5FDBC", Offset = "0xE5FDBC", VA = "0xE5FDBC")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400000A")]
	public event Action EnterStateAim
	{
		[Token(Token = "0x60001EE")]
		[Address(RVA = "0xE5FE80", Offset = "0xE5FE80", VA = "0xE5FE80")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60001EF")]
		[Address(RVA = "0xE5FF1C", Offset = "0xE5FF1C", VA = "0xE5FF1C")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400000B")]
	public event Action<AimData> UpdateAimData
	{
		[Token(Token = "0x60001F0")]
		[Address(RVA = "0xE5FFB8", Offset = "0xE5FFB8", VA = "0xE5FFB8")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60001F1")]
		[Address(RVA = "0xE60068", Offset = "0xE60068", VA = "0xE60068")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400000C")]
	public event Action ExitStateAim
	{
		[Token(Token = "0x60001F3")]
		[Address(RVA = "0xE60134", Offset = "0xE60134", VA = "0xE60134")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60001F4")]
		[Address(RVA = "0xE601D0", Offset = "0xE601D0", VA = "0xE601D0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400000D")]
	public event Action EnterStateCancelAim
	{
		[Token(Token = "0x60001F6")]
		[Address(RVA = "0xE60308", Offset = "0xE60308", VA = "0xE60308")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60001F7")]
		[Address(RVA = "0xE603A4", Offset = "0xE603A4", VA = "0xE603A4")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400000E")]
	public event Action EnterStatePreTeleport
	{
		[Token(Token = "0x60001F9")]
		[Address(RVA = "0xE604DC", Offset = "0xE604DC", VA = "0xE604DC")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60001FA")]
		[Address(RVA = "0xE60578", Offset = "0xE60578", VA = "0xE60578")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400000F")]
	public event Action EnterStateCancelTeleport
	{
		[Token(Token = "0x60001FC")]
		[Address(RVA = "0xE606B0", Offset = "0xE606B0", VA = "0xE606B0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60001FD")]
		[Address(RVA = "0xE6074C", Offset = "0xE6074C", VA = "0xE6074C")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000010")]
	public event Action EnterStateTeleporting
	{
		[Token(Token = "0x60001FF")]
		[Address(RVA = "0xE60884", Offset = "0xE60884", VA = "0xE60884")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000200")]
		[Address(RVA = "0xE60920", Offset = "0xE60920", VA = "0xE60920")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000011")]
	public event Action EnterStatePostTeleport
	{
		[Token(Token = "0x6000202")]
		[Address(RVA = "0xE60A58", Offset = "0xE60A58", VA = "0xE60A58")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000203")]
		[Address(RVA = "0xE60AF4", Offset = "0xE60AF4", VA = "0xE60AF4")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000012")]
	public event Action<Transform, Vector3, Quaternion> Teleported
	{
		[Token(Token = "0x6000205")]
		[Address(RVA = "0xE60C2C", Offset = "0xE60C2C", VA = "0xE60C2C")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000206")]
		[Address(RVA = "0xE60CDC", Offset = "0xE60CDC", VA = "0xE60CDC")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0xE5F454", Offset = "0xE5F454", VA = "0xE5F454")]
	public void EnableMovement(bool ready, bool aim, bool pre, bool post)
	{
	}

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0xE5F478", Offset = "0xE5F478", VA = "0xE5F478")]
	public void EnableRotation(bool ready, bool aim, bool pre, bool post)
	{
	}

	[Token(Token = "0x60001DE")]
	[Address(RVA = "0xE5F60C", Offset = "0xE5F60C", VA = "0xE5F60C")]
	public void OnUpdateTeleportDestination(bool isValidDestination, Vector3? position, Quaternion? rotation, Quaternion? landingRotation)
	{
	}

	[Token(Token = "0x60001E2")]
	[Address(RVA = "0xE5F6A8", Offset = "0xE5F6A8", VA = "0xE5F6A8")]
	public bool AimCollisionTest(Vector3 start, Vector3 end, LayerMask aimCollisionLayerMask, out RaycastHit hitInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x60001E3")]
	[Address(RVA = "0xE5F970", Offset = "0xE5F970", VA = "0xE5F970")]
	[Conditional("DEBUG_TELEPORT_STATES")]
	protected void LogState(string msg)
	{
	}

	[Token(Token = "0x60001E4")]
	[Address(RVA = "0xE5FA18", Offset = "0xE5FA18", VA = "0xE5FA18")]
	protected void CreateNewTeleportDestination()
	{
	}

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0xE5FB04", Offset = "0xE5FB04", VA = "0xE5FB04")]
	private void DeactivateDestination()
	{
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0xE5FB40", Offset = "0xE5FB40", VA = "0xE5FB40")]
	public void RecycleTeleportDestination(TeleportDestination oldDestination)
	{
	}

	[Token(Token = "0x60001E7")]
	[Address(RVA = "0xE5FBF0", Offset = "0xE5FBF0", VA = "0xE5FBF0")]
	private void EnableMotion(bool enableLinear, bool enableRotation)
	{
	}

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0xE5FC20", Offset = "0xE5FC20", VA = "0xE5FC20")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001E9")]
	[Address(RVA = "0xE5FC80", Offset = "0xE5FC80", VA = "0xE5FC80", Slot = "4")]
	public virtual void OnEnable()
	{
	}

	[Token(Token = "0x60001EA")]
	[Address(RVA = "0xE5FD18", Offset = "0xE5FD18", VA = "0xE5FD18", Slot = "5")]
	public virtual void OnDisable()
	{
	}

	[Token(Token = "0x60001ED")]
	[Address(RVA = "0xE5FCA4", Offset = "0xE5FCA4", VA = "0xE5FCA4")]
	[IteratorStateMachine(typeof(<ReadyStateCoroutine>d__52))]
	protected IEnumerator ReadyStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60001F2")]
	[Address(RVA = "0xE60118", Offset = "0xE60118", VA = "0xE60118")]
	public void OnUpdateAimData(AimData aimData)
	{
	}

	[Token(Token = "0x60001F5")]
	[Address(RVA = "0xE6026C", Offset = "0xE6026C", VA = "0xE6026C")]
	[IteratorStateMachine(typeof(<AimStateCoroutine>d__64))]
	protected IEnumerator AimStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60001F8")]
	[Address(RVA = "0xE60440", Offset = "0xE60440", VA = "0xE60440")]
	[IteratorStateMachine(typeof(<CancelAimStateCoroutine>d__68))]
	protected IEnumerator CancelAimStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60001FB")]
	[Address(RVA = "0xE60614", Offset = "0xE60614", VA = "0xE60614")]
	[IteratorStateMachine(typeof(<PreTeleportStateCoroutine>d__72))]
	protected IEnumerator PreTeleportStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60001FE")]
	[Address(RVA = "0xE607E8", Offset = "0xE607E8", VA = "0xE607E8")]
	[IteratorStateMachine(typeof(<CancelTeleportStateCoroutine>d__76))]
	protected IEnumerator CancelTeleportStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000201")]
	[Address(RVA = "0xE609BC", Offset = "0xE609BC", VA = "0xE609BC")]
	[IteratorStateMachine(typeof(<TeleportingStateCoroutine>d__80))]
	protected IEnumerator TeleportingStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000204")]
	[Address(RVA = "0xE60B90", Offset = "0xE60B90", VA = "0xE60B90")]
	[IteratorStateMachine(typeof(<PostTeleportStateCoroutine>d__84))]
	protected IEnumerator PostTeleportStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000207")]
	[Address(RVA = "0xE60D8C", Offset = "0xE60D8C", VA = "0xE60D8C")]
	public void DoTeleport()
	{
	}

	[Token(Token = "0x6000208")]
	[Address(RVA = "0xE60EA0", Offset = "0xE60EA0", VA = "0xE60EA0")]
	public Vector3 GetCharacterPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000209")]
	[Address(RVA = "0xE60ED0", Offset = "0xE60ED0", VA = "0xE60ED0")]
	public Quaternion GetHeadRotationY()
	{
		return default(Quaternion);
	}

	[Token(Token = "0x600020A")]
	[Address(RVA = "0xE6100C", Offset = "0xE6100C", VA = "0xE6100C")]
	public void DoWarp(Vector3 startPos, float positionPercent)
	{
	}

	[Token(Token = "0x600020B")]
	[Address(RVA = "0xE610F4", Offset = "0xE610F4", VA = "0xE610F4")]
	public LocomotionTeleport()
	{
	}
}
[Token(Token = "0x2000077")]
public class SimpleCapsuleWithStickMovement : MonoBehaviour
{
	[Token(Token = "0x40001F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool EnableLinearMovement;

	[Token(Token = "0x40001F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool EnableRotation;

	[Token(Token = "0x40001F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	public bool HMDRotatesPlayer;

	[Token(Token = "0x40001F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
	public bool RotationEitherThumbstick;

	[Token(Token = "0x40001F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float RotationAngle;

	[Token(Token = "0x40001F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float Speed;

	[Token(Token = "0x40001F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OVRCameraRig CameraRig;

	[Token(Token = "0x40001FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool ReadyToSnapTurn;

	[Token(Token = "0x40001FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Rigidbody _rigidbody;

	[Token(Token = "0x14000013")]
	public event Action CameraUpdated
	{
		[Token(Token = "0x600023A")]
		[Address(RVA = "0xE5E508", Offset = "0xE5E508", VA = "0xE5E508")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600023B")]
		[Address(RVA = "0xE5E62C", Offset = "0xE5E62C", VA = "0xE5E62C")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000014")]
	public event Action PreCharacterMove
	{
		[Token(Token = "0x600023C")]
		[Address(RVA = "0xE61ABC", Offset = "0xE61ABC", VA = "0xE61ABC")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600023D")]
		[Address(RVA = "0xE61B58", Offset = "0xE61B58", VA = "0xE61B58")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x600023E")]
	[Address(RVA = "0xE61BF4", Offset = "0xE61BF4", VA = "0xE61BF4")]
	private void Awake()
	{
	}

	[Token(Token = "0x600023F")]
	[Address(RVA = "0xE61CD4", Offset = "0xE61CD4", VA = "0xE61CD4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000240")]
	[Address(RVA = "0xE61CD8", Offset = "0xE61CD8", VA = "0xE61CD8")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000241")]
	[Address(RVA = "0xE61D4C", Offset = "0xE61D4C", VA = "0xE61D4C")]
	private void RotatePlayerToHMD()
	{
	}

	[Token(Token = "0x6000242")]
	[Address(RVA = "0xE61E70", Offset = "0xE61E70", VA = "0xE61E70")]
	private void StickMovement()
	{
	}

	[Token(Token = "0x6000243")]
	[Address(RVA = "0xE620E8", Offset = "0xE620E8", VA = "0xE620E8")]
	private void SnapTurn()
	{
	}

	[Token(Token = "0x6000244")]
	[Address(RVA = "0xE62308", Offset = "0xE62308", VA = "0xE62308")]
	public SimpleCapsuleWithStickMovement()
	{
	}
}
[Token(Token = "0x2000078")]
public abstract class TeleportAimHandler : TeleportSupport
{
	[Token(Token = "0x6000245")]
	[Address(RVA = "0xE62328", Offset = "0xE62328", VA = "0xE62328", Slot = "4")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6000246")]
	[Address(RVA = "0xE62354", Offset = "0xE62354", VA = "0xE62354", Slot = "5")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6000247")]
	public abstract void GetPoints(List<Vector3> points);

	[Token(Token = "0x6000248")]
	[Address(RVA = "0xE623E4", Offset = "0xE623E4", VA = "0xE623E4")]
	protected TeleportAimHandler()
	{
	}
}
[Token(Token = "0x2000079")]
public class TeleportAimHandlerLaser : TeleportAimHandler
{
	[Token(Token = "0x40001FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Tooltip("Maximum range for aiming.")]
	public float Range;

	[Token(Token = "0x6000249")]
	[Address(RVA = "0xE623EC", Offset = "0xE623EC", VA = "0xE623EC", Slot = "8")]
	public override void GetPoints(List<Vector3> points)
	{
	}

	[Token(Token = "0x600024A")]
	[Address(RVA = "0xE6257C", Offset = "0xE6257C", VA = "0xE6257C")]
	public TeleportAimHandlerLaser()
	{
	}
}
[Token(Token = "0x200007A")]
public class TeleportAimHandlerParabolic : TeleportAimHandler
{
	[Token(Token = "0x40001FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Tooltip("Maximum range for aiming.")]
	public float Range;

	[Token(Token = "0x4000200")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Tooltip("The MinimumElevation is relative to the AimPosition.")]
	public float MinimumElevation;

	[Token(Token = "0x4000201")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[Tooltip("The Gravity is used in conjunction with AimVelocity and the aim direction to simulate a projectile.")]
	public float Gravity;

	[Token(Token = "0x4000202")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Range(0.001f, 50f)]
	[Tooltip("The AimVelocity is the initial speed of the faked projectile.")]
	public float AimVelocity;

	[Token(Token = "0x4000203")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[Range(0.001f, 1f)]
	[Tooltip("The AimStep is the how much to subdivide the iteration.")]
	public float AimStep;

	[Token(Token = "0x600024B")]
	[Address(RVA = "0xE6258C", Offset = "0xE6258C", VA = "0xE6258C", Slot = "8")]
	public override void GetPoints(List<Vector3> points)
	{
	}

	[Token(Token = "0x600024C")]
	[Address(RVA = "0xE62760", Offset = "0xE62760", VA = "0xE62760")]
	public TeleportAimHandlerParabolic()
	{
	}
}
[Token(Token = "0x200007B")]
public class TeleportAimVisualLaser : TeleportSupport
{
	[Token(Token = "0x4000204")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Tooltip("This prefab will be instantiated when the aim visual is awakened, and will be set active when the user is aiming, and deactivated when they are done aiming.")]
	public LineRenderer LaserPrefab;

	[Token(Token = "0x4000205")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action _enterAimStateAction;

	[Token(Token = "0x4000206")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly Action _exitAimStateAction;

	[Token(Token = "0x4000207")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly Action<LocomotionTeleport.AimData> _updateAimDataAction;

	[Token(Token = "0x4000208")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private LineRenderer _lineRenderer;

	[Token(Token = "0x4000209")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3[] _linePoints;

	[Token(Token = "0x600024D")]
	[Address(RVA = "0xE62774", Offset = "0xE62774", VA = "0xE62774")]
	public TeleportAimVisualLaser()
	{
	}

	[Token(Token = "0x600024E")]
	[Address(RVA = "0xE628A0", Offset = "0xE628A0", VA = "0xE628A0")]
	private void EnterAimState()
	{
	}

	[Token(Token = "0x600024F")]
	[Address(RVA = "0xE628CC", Offset = "0xE628CC", VA = "0xE628CC")]
	private void ExitAimState()
	{
	}

	[Token(Token = "0x6000250")]
	[Address(RVA = "0xE628F8", Offset = "0xE628F8", VA = "0xE628F8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000251")]
	[Address(RVA = "0xE6299C", Offset = "0xE6299C", VA = "0xE6299C", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x6000252")]
	[Address(RVA = "0xE629E4", Offset = "0xE629E4", VA = "0xE629E4", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x6000253")]
	[Address(RVA = "0xE62A30", Offset = "0xE62A30", VA = "0xE62A30")]
	private void UpdateAimData(LocomotionTeleport.AimData obj)
	{
	}
}
[Token(Token = "0x200007C")]
public class TeleportDestination : MonoBehaviour
{
	[Token(Token = "0x400020B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Tooltip("If the target handler provides a target position, this transform will be moved to that position and it's game object enabled. A target position being provided does not mean the position is valid, only that the aim handler found something to test as a destination.")]
	public Transform PositionIndicator;

	[Token(Token = "0x400020C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Tooltip("This transform will be rotated to match the rotation of the aiming target. Simple teleport destinations should assign this to the object containing this component. More complex teleport destinations might assign this to a sub-object that is used to indicate the landing orientation independently from the rest of the destination indicator, such as when world space effects are required. This will typically be a child of the PositionIndicator.")]
	public Transform OrientationIndicator;

	[Token(Token = "0x400020D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Tooltip("After the player teleports, the character controller will have it's rotation set to this value. It is different from the OrientationIndicator transform.rotation in order to support both head-relative and forward-facing teleport modes (See TeleportOrientationHandlerThumbstick.cs).")]
	public Quaternion LandingRotation;

	[NonSerialized]
	[Token(Token = "0x400020E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public LocomotionTeleport LocomotionTeleport;

	[NonSerialized]
	[Token(Token = "0x400020F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public LocomotionTeleport.States TeleportState;

	[Token(Token = "0x4000210")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly Action<bool, Vector3?, Quaternion?, Quaternion?> _updateTeleportDestinationAction;

	[Token(Token = "0x4000211")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool _eventsActive;

	[Token(Token = "0x17000049")]
	public bool IsValidDestination
	{
		[Token(Token = "0x6000254")]
		[Address(RVA = "0xE62B2C", Offset = "0xE62B2C", VA = "0xE62B2C")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000255")]
		[Address(RVA = "0xE62B34", Offset = "0xE62B34", VA = "0xE62B34")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x14000015")]
	public event Action<TeleportDestination> Deactivated
	{
		[Token(Token = "0x600025A")]
		[Address(RVA = "0xE62CBC", Offset = "0xE62CBC", VA = "0xE62CBC")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600025B")]
		[Address(RVA = "0xE62D6C", Offset = "0xE62D6C", VA = "0xE62D6C")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6000256")]
	[Address(RVA = "0xE62B40", Offset = "0xE62B40", VA = "0xE62B40")]
	private TeleportDestination()
	{
	}

	[Token(Token = "0x6000257")]
	[Address(RVA = "0xE62BC4", Offset = "0xE62BC4", VA = "0xE62BC4")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x6000258")]
	[Address(RVA = "0xE62C88", Offset = "0xE62C88", VA = "0xE62C88")]
	private void TryDisableEventHandlers()
	{
	}

	[Token(Token = "0x6000259")]
	[Address(RVA = "0xE62CB8", Offset = "0xE62CB8", VA = "0xE62CB8")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x600025C")]
	[Address(RVA = "0xE5FB1C", Offset = "0xE5FB1C", VA = "0xE5FB1C")]
	public void OnDeactivated()
	{
	}

	[Token(Token = "0x600025D")]
	[Address(RVA = "0xE62E1C", Offset = "0xE62E1C", VA = "0xE62E1C")]
	public void Recycle()
	{
	}

	[Token(Token = "0x600025E")]
	[Address(RVA = "0xE62E38", Offset = "0xE62E38", VA = "0xE62E38", Slot = "4")]
	public virtual void UpdateTeleportDestination(bool isValidDestination, Vector3? position, Quaternion? rotation, Quaternion? landingRotation)
	{
	}
}
[Token(Token = "0x200007D")]
public abstract class TeleportInputHandler : TeleportSupport
{
	[Token(Token = "0x200007E")]
	[CompilerGenerated]
	private sealed class <TeleportReadyCoroutine>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportInputHandler <>4__this;

		[Token(Token = "0x1700004A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600026B")]
			[Address(RVA = "0xE63408", Offset = "0xE63408", VA = "0xE63408", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600026D")]
			[Address(RVA = "0xE63450", Offset = "0xE63450", VA = "0xE63450", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0xE63274", Offset = "0xE63274", VA = "0xE63274")]
		[DebuggerHidden]
		public <TeleportReadyCoroutine>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0xE63378", Offset = "0xE63378", VA = "0xE63378", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0xE6337C", Offset = "0xE6337C", VA = "0xE6337C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0xE63410", Offset = "0xE63410", VA = "0xE63410", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200007F")]
	[CompilerGenerated]
	private sealed class <TeleportAimCoroutine>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportInputHandler <>4__this;

		[Token(Token = "0x1700004C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000271")]
			[Address(RVA = "0xE634F4", Offset = "0xE634F4", VA = "0xE634F4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000273")]
			[Address(RVA = "0xE6353C", Offset = "0xE6353C", VA = "0xE6353C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0xE63310", Offset = "0xE63310", VA = "0xE63310")]
		[DebuggerHidden]
		public <TeleportAimCoroutine>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0xE63458", Offset = "0xE63458", VA = "0xE63458", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0xE6345C", Offset = "0xE6345C", VA = "0xE6345C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0xE634FC", Offset = "0xE634FC", VA = "0xE634FC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000213")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly Action _startReadyAction;

	[Token(Token = "0x4000214")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action _startAimAction;

	[Token(Token = "0x600025F")]
	[Address(RVA = "0xE6302C", Offset = "0xE6302C", VA = "0xE6302C")]
	protected TeleportInputHandler()
	{
	}

	[Token(Token = "0x6000260")]
	[Address(RVA = "0xE63100", Offset = "0xE63100", VA = "0xE63100", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x6000261")]
	[Address(RVA = "0xE63150", Offset = "0xE63150", VA = "0xE63150", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x6000262")]
	[Address(RVA = "0xE63200", Offset = "0xE63200", VA = "0xE63200")]
	[IteratorStateMachine(typeof(<TeleportReadyCoroutine>d__5))]
	private IEnumerator TeleportReadyCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000263")]
	[Address(RVA = "0xE6329C", Offset = "0xE6329C", VA = "0xE6329C")]
	[IteratorStateMachine(typeof(<TeleportAimCoroutine>d__6))]
	private IEnumerator TeleportAimCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000264")]
	public abstract LocomotionTeleport.TeleportIntentions GetIntention();

	[Token(Token = "0x6000265")]
	public abstract void GetAimData(out Ray aimRay);
}
[Token(Token = "0x2000080")]
public class TeleportInputHandlerHMD : TeleportInputHandler
{
	[Token(Token = "0x400021C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Tooltip("The button used to begin aiming for a teleport.")]
	public OVRInput.RawButton AimButton;

	[Token(Token = "0x400021D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[Tooltip("The button used to trigger the teleport after aiming. It can be the same button as the AimButton, however you cannot abort a teleport if it is.")]
	public OVRInput.RawButton TeleportButton;

	[Token(Token = "0x400021E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[Tooltip("When true, the system will not use the PreTeleport intention which will allow a teleport to occur on a button downpress. When false, the button downpress will trigger the PreTeleport intention and the Teleport intention when the button is released.")]
	public bool FastTeleport;

	[Token(Token = "0x1700004E")]
	public Transform Pointer
	{
		[Token(Token = "0x6000274")]
		[Address(RVA = "0xE63544", Offset = "0xE63544", VA = "0xE63544")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000275")]
		[Address(RVA = "0xE6354C", Offset = "0xE6354C", VA = "0xE6354C")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6000276")]
	[Address(RVA = "0xE63554", Offset = "0xE63554", VA = "0xE63554", Slot = "8")]
	public override LocomotionTeleport.TeleportIntentions GetIntention()
	{
		return default(LocomotionTeleport.TeleportIntentions);
	}

	[Token(Token = "0x6000277")]
	[Address(RVA = "0xE63680", Offset = "0xE63680", VA = "0xE63680", Slot = "9")]
	public override void GetAimData(out Ray aimRay)
	{
	}

	[Token(Token = "0x6000278")]
	[Address(RVA = "0xE63734", Offset = "0xE63734", VA = "0xE63734")]
	public TeleportInputHandlerHMD()
	{
	}
}
[Token(Token = "0x2000081")]
public class TeleportInputHandlerTouch : TeleportInputHandlerHMD
{
	[Token(Token = "0x2000082")]
	public enum InputModes
	{
		[Token(Token = "0x4000229")]
		CapacitiveButtonForAimAndTeleport,
		[Token(Token = "0x400022A")]
		SeparateButtonsForAimAndTeleport,
		[Token(Token = "0x400022B")]
		ThumbstickTeleport,
		[Token(Token = "0x400022C")]
		ThumbstickTeleportForwardBackOnly
	}

	[Token(Token = "0x2000083")]
	public enum AimCapTouchButtons
	{
		[Token(Token = "0x400022E")]
		A,
		[Token(Token = "0x400022F")]
		B,
		[Token(Token = "0x4000230")]
		LeftTrigger,
		[Token(Token = "0x4000231")]
		LeftThumbstick,
		[Token(Token = "0x4000232")]
		RightTrigger,
		[Token(Token = "0x4000233")]
		RightThumbstick,
		[Token(Token = "0x4000234")]
		X,
		[Token(Token = "0x4000235")]
		Y
	}

	[Token(Token = "0x400021F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Transform LeftHand;

	[Token(Token = "0x4000220")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Transform RightHand;

	[Token(Token = "0x4000221")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[Tooltip("CapacitiveButtonForAimAndTeleport=Activate aiming via cap touch detection, press the same button to teleport.\nSeparateButtonsForAimAndTeleport=Use one button to begin aiming, and another to trigger the teleport.\nThumbstickTeleport=Push a thumbstick to begin aiming, release to teleport.")]
	public InputModes InputMode;

	[Token(Token = "0x4000222")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly OVRInput.RawButton[] _rawButtons;

	[Token(Token = "0x4000223")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly OVRInput.RawTouch[] _rawTouch;

	[Token(Token = "0x4000224")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[Tooltip("Select the controller to be used for aiming. Supports LTouch, RTouch, or Touch for either.")]
	public OVRInput.Controller AimingController;

	[Token(Token = "0x4000225")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private OVRInput.Controller InitiatingController;

	[Token(Token = "0x4000226")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[Tooltip("Select the button to use for triggering aim and teleport when InputMode==CapacitiveButtonForAimAndTeleport")]
	public AimCapTouchButtons CapacitiveAimAndTeleportButton;

	[Token(Token = "0x4000227")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	[Tooltip("The thumbstick magnitude required to trigger aiming and teleports when InputMode==InputModes.ThumbstickTeleport")]
	public float ThumbstickTeleportThreshold;

	[Token(Token = "0x6000279")]
	[Address(RVA = "0xE63738", Offset = "0xE63738", VA = "0xE63738")]
	private void Start()
	{
	}

	[Token(Token = "0x600027A")]
	[Address(RVA = "0xE6373C", Offset = "0xE6373C", VA = "0xE6373C", Slot = "8")]
	public override LocomotionTeleport.TeleportIntentions GetIntention()
	{
		return default(LocomotionTeleport.TeleportIntentions);
	}

	[Token(Token = "0x600027B")]
	[Address(RVA = "0xE63B70", Offset = "0xE63B70", VA = "0xE63B70", Slot = "9")]
	public override void GetAimData(out Ray aimRay)
	{
	}

	[Token(Token = "0x600027C")]
	[Address(RVA = "0xE63C2C", Offset = "0xE63C2C", VA = "0xE63C2C")]
	public TeleportInputHandlerTouch()
	{
	}
}
[Token(Token = "0x2000084")]
public abstract class TeleportOrientationHandler : TeleportSupport
{
	[Token(Token = "0x2000085")]
	public enum OrientationModes
	{
		[Token(Token = "0x400023A")]
		HeadRelative,
		[Token(Token = "0x400023B")]
		ForwardFacing
	}

	[Token(Token = "0x2000086")]
	[CompilerGenerated]
	private sealed class <UpdateOrientationCoroutine>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportOrientationHandler <>4__this;

		[Token(Token = "0x1700004F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000289")]
			[Address(RVA = "0xE640E0", Offset = "0xE640E0", VA = "0xE640E0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000050")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600028B")]
			[Address(RVA = "0xE64128", Offset = "0xE64128", VA = "0xE64128", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0xE63EF0", Offset = "0xE63EF0", VA = "0xE63EF0")]
		[DebuggerHidden]
		public <UpdateOrientationCoroutine>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0xE64030", Offset = "0xE64030", VA = "0xE64030", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0xE64034", Offset = "0xE64034", VA = "0xE64034", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0xE640E8", Offset = "0xE640E8", VA = "0xE640E8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000236")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly Action _updateOrientationAction;

	[Token(Token = "0x4000237")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action<LocomotionTeleport.AimData> _updateAimDataAction;

	[Token(Token = "0x4000238")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected LocomotionTeleport.AimData AimData;

	[Token(Token = "0x600027D")]
	[Address(RVA = "0xE63D1C", Offset = "0xE63D1C", VA = "0xE63D1C")]
	protected TeleportOrientationHandler()
	{
	}

	[Token(Token = "0x600027E")]
	[Address(RVA = "0xE63E04", Offset = "0xE63E04", VA = "0xE63E04")]
	private void UpdateAimData(LocomotionTeleport.AimData aimData)
	{
	}

	[Token(Token = "0x600027F")]
	[Address(RVA = "0xE63E0C", Offset = "0xE63E0C", VA = "0xE63E0C", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x6000280")]
	[Address(RVA = "0xE63E44", Offset = "0xE63E44", VA = "0xE63E44", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x6000281")]
	[Address(RVA = "0xE63E7C", Offset = "0xE63E7C", VA = "0xE63E7C")]
	[IteratorStateMachine(typeof(<UpdateOrientationCoroutine>d__7))]
	private IEnumerator UpdateOrientationCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000282")]
	protected abstract void InitializeTeleportDestination();

	[Token(Token = "0x6000283")]
	protected abstract void UpdateTeleportDestination();

	[Token(Token = "0x6000284")]
	[Address(RVA = "0xE63F18", Offset = "0xE63F18", VA = "0xE63F18")]
	protected Quaternion GetLandingOrientation(OrientationModes mode, Quaternion rotation)
	{
		return default(Quaternion);
	}
}
[Token(Token = "0x2000087")]
public class TeleportOrientationHandler360 : TeleportOrientationHandler
{
	[Token(Token = "0x600028C")]
	[Address(RVA = "0xE64130", Offset = "0xE64130", VA = "0xE64130", Slot = "8")]
	protected override void InitializeTeleportDestination()
	{
	}

	[Token(Token = "0x600028D")]
	[Address(RVA = "0xE64134", Offset = "0xE64134", VA = "0xE64134", Slot = "9")]
	protected override void UpdateTeleportDestination()
	{
	}

	[Token(Token = "0x600028E")]
	[Address(RVA = "0xE641DC", Offset = "0xE641DC", VA = "0xE641DC")]
	public TeleportOrientationHandler360()
	{
	}
}
[Token(Token = "0x2000088")]
public class TeleportOrientationHandlerHMD : TeleportOrientationHandler
{
	[Token(Token = "0x400023F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Tooltip("HeadRelative=Character will orient to match the arrow. ForwardFacing=When user orients to match the arrow, they will be facing the sensors.")]
	public OrientationModes OrientationMode;

	[Token(Token = "0x4000240")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[Tooltip("Should the destination orientation be updated during the aim state in addition to the PreTeleport state?")]
	public bool UpdateOrientationDuringAim;

	[Token(Token = "0x4000241")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[Tooltip("How far from the destination must the HMD be pointing before using it for orientation")]
	public float AimDistanceThreshold;

	[Token(Token = "0x4000242")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[Tooltip("How far from the destination must the HMD be pointing before rejecting the teleport")]
	public float AimDistanceMaxRange;

	[Token(Token = "0x4000243")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Quaternion _initialRotation;

	[Token(Token = "0x600028F")]
	[Address(RVA = "0xE641E0", Offset = "0xE641E0", VA = "0xE641E0", Slot = "8")]
	protected override void InitializeTeleportDestination()
	{
	}

	[Token(Token = "0x6000290")]
	[Address(RVA = "0xE64230", Offset = "0xE64230", VA = "0xE64230", Slot = "9")]
	protected override void UpdateTeleportDestination()
	{
	}

	[Token(Token = "0x6000291")]
	[Address(RVA = "0xE646F4", Offset = "0xE646F4", VA = "0xE646F4")]
	public TeleportOrientationHandlerHMD()
	{
	}
}
[Token(Token = "0x2000089")]
public class TeleportOrientationHandlerThumbstick : TeleportOrientationHandler
{
	[Token(Token = "0x4000244")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Tooltip("HeadRelative=Character will orient to match the arrow. ForwardFacing=When user orients to match the arrow, they will be facing the sensors.")]
	public OrientationModes OrientationMode;

	[Token(Token = "0x4000245")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[Tooltip("Which thumbstick is to be used for adjusting the teleport orientation. Supports LTouch, RTouch, or Touch for either.")]
	public OVRInput.Controller Thumbstick;

	[Token(Token = "0x4000246")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[Tooltip("The orientation will only change if the thumbstick magnitude is above this value. This will usually be larger than the TeleportInputHandlerTouch.ThumbstickTeleportThreshold.")]
	public float RotateStickThreshold;

	[Token(Token = "0x4000247")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private Quaternion _initialRotation;

	[Token(Token = "0x4000248")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private Quaternion _currentRotation;

	[Token(Token = "0x4000249")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private Vector2 _lastValidDirection;

	[Token(Token = "0x6000292")]
	[Address(RVA = "0xE646F8", Offset = "0xE646F8", VA = "0xE646F8", Slot = "8")]
	protected override void InitializeTeleportDestination()
	{
	}

	[Token(Token = "0x6000293")]
	[Address(RVA = "0xE6472C", Offset = "0xE6472C", VA = "0xE6472C", Slot = "9")]
	protected override void UpdateTeleportDestination()
	{
	}

	[Token(Token = "0x6000294")]
	[Address(RVA = "0xE64C28", Offset = "0xE64C28", VA = "0xE64C28")]
	public TeleportOrientationHandlerThumbstick()
	{
	}
}
[Token(Token = "0x200008A")]
public class TeleportPoint : MonoBehaviour
{
	[Token(Token = "0x400024A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float dimmingSpeed;

	[Token(Token = "0x400024B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float fullIntensity;

	[Token(Token = "0x400024C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float lowIntensity;

	[Token(Token = "0x400024D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform destTransform;

	[Token(Token = "0x400024E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float lastLookAtTime;

	[Token(Token = "0x6000295")]
	[Address(RVA = "0xE65C38", Offset = "0xE65C38", VA = "0xE65C38")]
	private void Start()
	{
	}

	[Token(Token = "0x6000296")]
	[Address(RVA = "0xE65C3C", Offset = "0xE65C3C", VA = "0xE65C3C")]
	public Transform GetDestTransform()
	{
		return null;
	}

	[Token(Token = "0x6000297")]
	[Address(RVA = "0xE65C44", Offset = "0xE65C44", VA = "0xE65C44")]
	private void Update()
	{
	}

	[Token(Token = "0x6000298")]
	[Address(RVA = "0xE65D30", Offset = "0xE65D30", VA = "0xE65D30")]
	public void OnLookAt()
	{
	}

	[Token(Token = "0x6000299")]
	[Address(RVA = "0xE65D4C", Offset = "0xE65D4C", VA = "0xE65D4C")]
	public TeleportPoint()
	{
	}
}
[Token(Token = "0x200008B")]
public abstract class TeleportSupport : MonoBehaviour
{
	[Token(Token = "0x4000250")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool _eventsActive;

	[Token(Token = "0x17000051")]
	protected LocomotionTeleport LocomotionTeleport
	{
		[Token(Token = "0x600029A")]
		[Address(RVA = "0xE65D64", Offset = "0xE65D64", VA = "0xE65D64")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600029B")]
		[Address(RVA = "0xE65D6C", Offset = "0xE65D6C", VA = "0xE65D6C")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x600029C")]
	[Address(RVA = "0xE65D74", Offset = "0xE65D74", VA = "0xE65D74", Slot = "4")]
	protected virtual void OnEnable()
	{
	}

	[Token(Token = "0x600029D")]
	[Address(RVA = "0xE65DDC", Offset = "0xE65DDC", VA = "0xE65DDC", Slot = "5")]
	protected virtual void OnDisable()
	{
	}

	[Token(Token = "0x600029E")]
	[Address(RVA = "0xE65E04", Offset = "0xE65E04", VA = "0xE65E04")]
	[Conditional("DEBUG_TELEPORT_EVENT_HANDLERS")]
	private void LogEventHandler(string msg)
	{
	}

	[Token(Token = "0x600029F")]
	[Address(RVA = "0xE65ED4", Offset = "0xE65ED4", VA = "0xE65ED4", Slot = "6")]
	protected virtual void AddEventHandlers()
	{
	}

	[Token(Token = "0x60002A0")]
	[Address(RVA = "0xE65EE0", Offset = "0xE65EE0", VA = "0xE65EE0", Slot = "7")]
	protected virtual void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x60002A1")]
	[Address(RVA = "0xE65EE8", Offset = "0xE65EE8", VA = "0xE65EE8")]
	protected TeleportSupport()
	{
	}
}
[Token(Token = "0x200008C")]
public abstract class TeleportTargetHandler : TeleportSupport
{
	[Token(Token = "0x200008D")]
	[CompilerGenerated]
	private sealed class <TargetAimCoroutine>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportTargetHandler <>4__this;

		[Token(Token = "0x17000052")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002AD")]
			[Address(RVA = "0xE6650C", Offset = "0xE6650C", VA = "0xE6650C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000053")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002AF")]
			[Address(RVA = "0xE66554", Offset = "0xE66554", VA = "0xE66554", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0xE660D4", Offset = "0xE660D4", VA = "0xE660D4")]
		[DebuggerHidden]
		public <TargetAimCoroutine>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0xE66254", Offset = "0xE66254", VA = "0xE66254", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0xE66258", Offset = "0xE66258", VA = "0xE66258", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0xE66514", Offset = "0xE66514", VA = "0xE66514", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000251")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Tooltip("This bitmask controls which game object layers will be included in the targeting collision tests.")]
	public LayerMask AimCollisionLayerMask;

	[Token(Token = "0x4000252")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected readonly LocomotionTeleport.AimData AimData;

	[Token(Token = "0x4000253")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action _startAimAction;

	[Token(Token = "0x4000254")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly List<Vector3> _aimPoints;

	[Token(Token = "0x4000255")]
	private const float ERROR_MARGIN = 0.1f;

	[Token(Token = "0x60002A2")]
	[Address(RVA = "0xE65EF0", Offset = "0xE65EF0", VA = "0xE65EF0")]
	protected TeleportTargetHandler()
	{
	}

	[Token(Token = "0x60002A3")]
	[Address(RVA = "0xE6600C", Offset = "0xE6600C", VA = "0xE6600C", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x60002A4")]
	[Address(RVA = "0xE66038", Offset = "0xE66038", VA = "0xE66038", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x60002A5")]
	[Address(RVA = "0xE66060", Offset = "0xE66060", VA = "0xE66060")]
	[IteratorStateMachine(typeof(<TargetAimCoroutine>d__7))]
	private IEnumerator TargetAimCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60002A6")]
	[Address(RVA = "0xE660FC", Offset = "0xE660FC", VA = "0xE660FC", Slot = "8")]
	protected virtual void ResetAimData()
	{
	}

	[Token(Token = "0x60002A7")]
	protected abstract bool ConsiderTeleport(Vector3 start, ref Vector3 end);

	[Token(Token = "0x60002A8")]
	[Address(RVA = "0xE66118", Offset = "0xE66118", VA = "0xE66118", Slot = "10")]
	public virtual Vector3? ConsiderDestination(Vector3 location)
	{
		return null;
	}
}
[Token(Token = "0x200008E")]
public class TeleportTargetHandlerNavMesh : TeleportTargetHandler
{
	[Token(Token = "0x4000259")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int NavMeshAreaMask;

	[Token(Token = "0x400025A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private NavMeshPath _path;

	[Token(Token = "0x60002B0")]
	[Address(RVA = "0xE6655C", Offset = "0xE6655C", VA = "0xE6655C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002B1")]
	[Address(RVA = "0xE665C4", Offset = "0xE665C4", VA = "0xE665C4", Slot = "9")]
	protected override bool ConsiderTeleport(Vector3 start, ref Vector3 end)
	{
		return default(bool);
	}

	[Token(Token = "0x60002B2")]
	[Address(RVA = "0xE66730", Offset = "0xE66730", VA = "0xE66730", Slot = "10")]
	public override Vector3? ConsiderDestination(Vector3 location)
	{
		return null;
	}

	[Token(Token = "0x60002B3")]
	[Address(RVA = "0xE66820", Offset = "0xE66820", VA = "0xE66820")]
	[Conditional("SHOW_PATH_RESULT")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x60002B4")]
	[Address(RVA = "0xE66824", Offset = "0xE66824", VA = "0xE66824")]
	public TeleportTargetHandlerNavMesh()
	{
	}
}
[Token(Token = "0x200008F")]
public class TeleportTargetHandlerNode : TeleportTargetHandler
{
	[Token(Token = "0x400025B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Tooltip("When checking line of sight to the destination, add this value to the vertical offset for targeting collision checks.")]
	public float LOSOffset;

	[Token(Token = "0x400025C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[Tooltip("Teleport logic will only work with TeleportPoint components that exist in the layers specified by this mask.")]
	public LayerMask TeleportLayerMask;

	[Token(Token = "0x60002B5")]
	[Address(RVA = "0xE66830", Offset = "0xE66830", VA = "0xE66830", Slot = "9")]
	protected override bool ConsiderTeleport(Vector3 start, ref Vector3 end)
	{
		return default(bool);
	}

	[Token(Token = "0x60002B6")]
	[Address(RVA = "0xE66A30", Offset = "0xE66A30", VA = "0xE66A30")]
	public TeleportTargetHandlerNode()
	{
	}
}
[Token(Token = "0x2000090")]
public class TeleportTargetHandlerPhysical : TeleportTargetHandler
{
	[Token(Token = "0x60002B7")]
	[Address(RVA = "0xE66A3C", Offset = "0xE66A3C", VA = "0xE66A3C", Slot = "9")]
	protected override bool ConsiderTeleport(Vector3 start, ref Vector3 end)
	{
		return default(bool);
	}

	[Token(Token = "0x60002B8")]
	[Address(RVA = "0xE66BA8", Offset = "0xE66BA8", VA = "0xE66BA8")]
	public TeleportTargetHandlerPhysical()
	{
	}
}
[Token(Token = "0x2000091")]
public abstract class TeleportTransition : TeleportSupport
{
	[Token(Token = "0x60002B9")]
	[Address(RVA = "0xE66BAC", Offset = "0xE66BAC", VA = "0xE66BAC", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x60002BA")]
	[Address(RVA = "0xE66C34", Offset = "0xE66C34", VA = "0xE66C34", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x60002BB")]
	protected abstract void LocomotionTeleportOnEnterStateTeleporting();

	[Token(Token = "0x60002BC")]
	[Address(RVA = "0xE66CB8", Offset = "0xE66CB8", VA = "0xE66CB8")]
	protected TeleportTransition()
	{
	}
}
[Token(Token = "0x2000092")]
public class TeleportTransitionBlink : TeleportTransition
{
	[Token(Token = "0x2000093")]
	[CompilerGenerated]
	private sealed class <BlinkCoroutine>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportTransitionBlink <>4__this;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <elapsedTime>5__2;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <teleportTime>5__3;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool <teleported>5__4;

		[Token(Token = "0x17000054")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002C3")]
			[Address(RVA = "0xE67020", Offset = "0xE67020", VA = "0xE67020", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000055")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002C5")]
			[Address(RVA = "0xE67068", Offset = "0xE67068", VA = "0xE67068", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0xE66D54", Offset = "0xE66D54", VA = "0xE66D54")]
		[DebuggerHidden]
		public <BlinkCoroutine>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0xE66F18", Offset = "0xE66F18", VA = "0xE66F18", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0xE66F1C", Offset = "0xE66F1C", VA = "0xE66F1C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0xE67028", Offset = "0xE67028", VA = "0xE67028", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400025D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Range(0.01f, 2f)]
	[Tooltip("How long the transition takes. Usually this is greater than Teleport Delay.")]
	public float TransitionDuration;

	[Token(Token = "0x400025E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Range(0f, 1f)]
	[Tooltip("At what percentage of the elapsed transition time does the teleport occur?")]
	public float TeleportDelay;

	[Token(Token = "0x400025F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Tooltip("Fade to black over the duration of the transition")]
	public AnimationCurve FadeLevels;

	[Token(Token = "0x60002BD")]
	[Address(RVA = "0xE66CC0", Offset = "0xE66CC0", VA = "0xE66CC0", Slot = "8")]
	protected override void LocomotionTeleportOnEnterStateTeleporting()
	{
	}

	[Token(Token = "0x60002BE")]
	[Address(RVA = "0xE66CE0", Offset = "0xE66CE0", VA = "0xE66CE0")]
	[IteratorStateMachine(typeof(<BlinkCoroutine>d__4))]
	protected IEnumerator BlinkCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60002BF")]
	[Address(RVA = "0xE66D7C", Offset = "0xE66D7C", VA = "0xE66D7C")]
	public TeleportTransitionBlink()
	{
	}
}
[Token(Token = "0x2000094")]
public class TeleportTransitionInstant : TeleportTransition
{
	[Token(Token = "0x60002C6")]
	[Address(RVA = "0xE67070", Offset = "0xE67070", VA = "0xE67070", Slot = "8")]
	protected override void LocomotionTeleportOnEnterStateTeleporting()
	{
	}

	[Token(Token = "0x60002C7")]
	[Address(RVA = "0xE6708C", Offset = "0xE6708C", VA = "0xE6708C")]
	public TeleportTransitionInstant()
	{
	}
}
[Token(Token = "0x2000095")]
public class TeleportTransitionWarp : TeleportTransition
{
	[Token(Token = "0x2000096")]
	[CompilerGenerated]
	private sealed class <DoWarp>d__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportTransitionWarp <>4__this;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 <startPosition>5__2;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <elapsedTime>5__3;

		[Token(Token = "0x17000056")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002CE")]
			[Address(RVA = "0xE672BC", Offset = "0xE672BC", VA = "0xE672BC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000057")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002D0")]
			[Address(RVA = "0xE67304", Offset = "0xE67304", VA = "0xE67304", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0xE67128", Offset = "0xE67128", VA = "0xE67128")]
		[DebuggerHidden]
		public <DoWarp>d__3(int <>1__state)
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0xE67198", Offset = "0xE67198", VA = "0xE67198", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0xE6719C", Offset = "0xE6719C", VA = "0xE6719C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0xE672C4", Offset = "0xE672C4", VA = "0xE672C4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000266")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Range(0.01f, 1f)]
	[Tooltip("How much time the warp transition takes to complete.")]
	public float TransitionDuration;

	[Token(Token = "0x4000267")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public AnimationCurve PositionLerp;

	[Token(Token = "0x60002C8")]
	[Address(RVA = "0xE67094", Offset = "0xE67094", VA = "0xE67094", Slot = "8")]
	protected override void LocomotionTeleportOnEnterStateTeleporting()
	{
	}

	[Token(Token = "0x60002C9")]
	[Address(RVA = "0xE670B4", Offset = "0xE670B4", VA = "0xE670B4")]
	[IteratorStateMachine(typeof(<DoWarp>d__3))]
	private IEnumerator DoWarp()
	{
		return null;
	}

	[Token(Token = "0x60002CA")]
	[Address(RVA = "0xE67150", Offset = "0xE67150", VA = "0xE67150")]
	public TeleportTransitionWarp()
	{
	}
}
[Token(Token = "0x2000097")]
public static class NativeVideoPlayer
{
	[Token(Token = "0x2000098")]
	public enum PlabackState
	{
		[Token(Token = "0x4000285")]
		Idle = 1,
		[Token(Token = "0x4000286")]
		Preparing,
		[Token(Token = "0x4000287")]
		Buffering,
		[Token(Token = "0x4000288")]
		Ready,
		[Token(Token = "0x4000289")]
		Ended
	}

	[Token(Token = "0x2000099")]
	public enum StereoMode
	{
		[Token(Token = "0x400028B")]
		Unknown = -1,
		[Token(Token = "0x400028C")]
		Mono,
		[Token(Token = "0x400028D")]
		TopBottom,
		[Token(Token = "0x400028E")]
		LeftRight,
		[Token(Token = "0x400028F")]
		Mesh
	}

	[Token(Token = "0x400026D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static IntPtr? _Activity;

	[Token(Token = "0x400026E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static IntPtr? _VideoPlayerClass;

	[Token(Token = "0x400026F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static readonly jvalue[] EmptyParams;

	[Token(Token = "0x4000270")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static IntPtr getIsPlayingMethodId;

	[Token(Token = "0x4000271")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static IntPtr getCurrentPlaybackStateMethodId;

	[Token(Token = "0x4000272")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static IntPtr getDurationMethodId;

	[Token(Token = "0x4000273")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static IntPtr getStereoModeMethodId;

	[Token(Token = "0x4000274")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static IntPtr getWidthMethodId;

	[Token(Token = "0x4000275")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private static IntPtr getHeightMethodId;

	[Token(Token = "0x4000276")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private static IntPtr getPlaybackPositionMethodId;

	[Token(Token = "0x4000277")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static IntPtr setPlaybackPositionMethodId;

	[Token(Token = "0x4000278")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private static jvalue[] setPlaybackPositionParams;

	[Token(Token = "0x4000279")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private static IntPtr playVideoMethodId;

	[Token(Token = "0x400027A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private static jvalue[] playVideoParams;

	[Token(Token = "0x400027B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private static IntPtr stopMethodId;

	[Token(Token = "0x400027C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private static IntPtr resumeMethodId;

	[Token(Token = "0x400027D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private static IntPtr pauseMethodId;

	[Token(Token = "0x400027E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private static IntPtr setPlaybackSpeedMethodId;

	[Token(Token = "0x400027F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private static jvalue[] setPlaybackSpeedParams;

	[Token(Token = "0x4000280")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private static IntPtr setLoopingMethodId;

	[Token(Token = "0x4000281")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private static jvalue[] setLoopingParams;

	[Token(Token = "0x4000282")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private static IntPtr setListenerRotationQuaternionMethodId;

	[Token(Token = "0x4000283")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private static jvalue[] setListenerRotationQuaternionParams;

	[Token(Token = "0x17000058")]
	private static IntPtr VideoPlayerClass
	{
		[Token(Token = "0x60002D1")]
		[Address(RVA = "0xE6730C", Offset = "0xE6730C", VA = "0xE6730C")]
		get
		{
			return default(IntPtr);
		}
	}

	[Token(Token = "0x17000059")]
	private static IntPtr Activity
	{
		[Token(Token = "0x60002D2")]
		[Address(RVA = "0xE675FC", Offset = "0xE675FC", VA = "0xE675FC")]
		get
		{
			return default(IntPtr);
		}
	}

	[Token(Token = "0x1700005A")]
	public static bool IsAvailable
	{
		[Token(Token = "0x60002D3")]
		[Address(RVA = "0xE6787C", Offset = "0xE6787C", VA = "0xE6787C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700005B")]
	public static bool IsPlaying
	{
		[Token(Token = "0x60002D4")]
		[Address(RVA = "0xE678F0", Offset = "0xE678F0", VA = "0xE678F0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700005C")]
	public static PlabackState CurrentPlaybackState
	{
		[Token(Token = "0x60002D5")]
		[Address(RVA = "0xE679F4", Offset = "0xE679F4", VA = "0xE679F4")]
		get
		{
			return default(PlabackState);
		}
	}

	[Token(Token = "0x1700005D")]
	public static long Duration
	{
		[Token(Token = "0x60002D6")]
		[Address(RVA = "0xE67AFC", Offset = "0xE67AFC", VA = "0xE67AFC")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x1700005E")]
	public static StereoMode VideoStereoMode
	{
		[Token(Token = "0x60002D7")]
		[Address(RVA = "0xE67C04", Offset = "0xE67C04", VA = "0xE67C04")]
		get
		{
			return default(StereoMode);
		}
	}

	[Token(Token = "0x1700005F")]
	public static int VideoWidth
	{
		[Token(Token = "0x60002D8")]
		[Address(RVA = "0xE67D0C", Offset = "0xE67D0C", VA = "0xE67D0C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000060")]
	public static int VideoHeight
	{
		[Token(Token = "0x60002D9")]
		[Address(RVA = "0xE67E14", Offset = "0xE67E14", VA = "0xE67E14")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000061")]
	public static long PlaybackPosition
	{
		[Token(Token = "0x60002DA")]
		[Address(RVA = "0xE67F1C", Offset = "0xE67F1C", VA = "0xE67F1C")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60002DB")]
		[Address(RVA = "0xE68024", Offset = "0xE68024", VA = "0xE68024")]
		set
		{
		}
	}

	[Token(Token = "0x60002DC")]
	[Address(RVA = "0xE6818C", Offset = "0xE6818C", VA = "0xE6818C")]
	public static void PlayVideo(string path, string drmLicenseUrl, IntPtr surfaceObj)
	{
	}

	[Token(Token = "0x60002DD")]
	[Address(RVA = "0xE683A4", Offset = "0xE683A4", VA = "0xE683A4")]
	public static void Stop()
	{
	}

	[Token(Token = "0x60002DE")]
	[Address(RVA = "0xE684AC", Offset = "0xE684AC", VA = "0xE684AC")]
	public static void Play()
	{
	}

	[Token(Token = "0x60002DF")]
	[Address(RVA = "0xE685B4", Offset = "0xE685B4", VA = "0xE685B4")]
	public static void Pause()
	{
	}

	[Token(Token = "0x60002E0")]
	[Address(RVA = "0xE686BC", Offset = "0xE686BC", VA = "0xE686BC")]
	public static void SetPlaybackSpeed(float speed)
	{
	}

	[Token(Token = "0x60002E1")]
	[Address(RVA = "0xE6882C", Offset = "0xE6882C", VA = "0xE6882C")]
	public static void SetLooping(bool looping)
	{
	}

	[Token(Token = "0x60002E2")]
	[Address(RVA = "0xE68998", Offset = "0xE68998", VA = "0xE68998")]
	public static void SetListenerRotation(Quaternion rotation)
	{
	}
}
[Token(Token = "0x200009A")]
public class ButtonDownListener : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
{
	[Token(Token = "0x14000016")]
	public event Action onButtonDown
	{
		[Token(Token = "0x60002E4")]
		[Address(RVA = "0xE68BEC", Offset = "0xE68BEC", VA = "0xE68BEC")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60002E5")]
		[Address(RVA = "0xE68C88", Offset = "0xE68C88", VA = "0xE68C88")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x60002E6")]
	[Address(RVA = "0xE68D24", Offset = "0xE68D24", VA = "0xE68D24", Slot = "4")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60002E7")]
	[Address(RVA = "0xE68D40", Offset = "0xE68D40", VA = "0xE68D40")]
	public ButtonDownListener()
	{
	}
}
[Token(Token = "0x200009B")]
public class MediaPlayerImage : Image
{
	[Token(Token = "0x200009C")]
	public enum ButtonType
	{
		[Token(Token = "0x4000293")]
		Play,
		[Token(Token = "0x4000294")]
		Pause,
		[Token(Token = "0x4000295")]
		FastForward,
		[Token(Token = "0x4000296")]
		Rewind,
		[Token(Token = "0x4000297")]
		SkipForward,
		[Token(Token = "0x4000298")]
		SkipBack,
		[Token(Token = "0x4000299")]
		Stop
	}

	[Token(Token = "0x4000291")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	[SerializeField]
	private ButtonType m_ButtonType;

	[Token(Token = "0x17000062")]
	public ButtonType buttonType
	{
		[Token(Token = "0x60002E8")]
		[Address(RVA = "0xE68D48", Offset = "0xE68D48", VA = "0xE68D48")]
		get
		{
			return default(ButtonType);
		}
		[Token(Token = "0x60002E9")]
		[Address(RVA = "0xE68D50", Offset = "0xE68D50", VA = "0xE68D50")]
		set
		{
		}
	}

	[Token(Token = "0x60002EA")]
	[Address(RVA = "0xE68D74", Offset = "0xE68D74", VA = "0xE68D74", Slot = "44")]
	protected override void OnPopulateMesh(VertexHelper toFill)
	{
	}

	[Token(Token = "0x60002EB")]
	[Address(RVA = "0xE69BC8", Offset = "0xE69BC8", VA = "0xE69BC8")]
	public MediaPlayerImage()
	{
	}
}
[Token(Token = "0x200009D")]
public class MoviePlayerSample : MonoBehaviour
{
	[Token(Token = "0x200009E")]
	public enum VideoShape
	{
		[Token(Token = "0x40002AE")]
		_360,
		[Token(Token = "0x40002AF")]
		_180,
		[Token(Token = "0x40002B0")]
		Quad
	}

	[Token(Token = "0x200009F")]
	public enum VideoStereo
	{
		[Token(Token = "0x40002B2")]
		Mono,
		[Token(Token = "0x40002B3")]
		TopBottom,
		[Token(Token = "0x40002B4")]
		LeftRight,
		[Token(Token = "0x40002B5")]
		BottomTop
	}

	[Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private sealed class <Start>d__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MoviePlayerSample <>4__this;

		[Token(Token = "0x17000066")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000302")]
			[Address(RVA = "0xE6B0F0", Offset = "0xE6B0F0", VA = "0xE6B0F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000067")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000304")]
			[Address(RVA = "0xE6B138", Offset = "0xE6B138", VA = "0xE6B138", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0xE6A2AC", Offset = "0xE6A2AC", VA = "0xE6A2AC")]
		[DebuggerHidden]
		public <Start>d__33(int <>1__state)
		{
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0xE6AF44", Offset = "0xE6AF44", VA = "0xE6AF44", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0xE6AF48", Offset = "0xE6AF48", VA = "0xE6AF48", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0xE6B0F8", Offset = "0xE6B0F8", VA = "0xE6B0F8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400029A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool videoPausedBeforeAppPause;

	[Token(Token = "0x400029B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private VideoPlayer videoPlayer;

	[Token(Token = "0x400029C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private OVROverlay overlay;

	[Token(Token = "0x400029D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Renderer mediaRenderer;

	[Token(Token = "0x40002A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private RenderTexture copyTexture;

	[Token(Token = "0x40002A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Material externalTex2DMaterial;

	[Token(Token = "0x40002A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public string MovieName;

	[Token(Token = "0x40002A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public string DrmLicenseUrl;

	[Token(Token = "0x40002A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public bool LoopVideo;

	[Token(Token = "0x40002A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public VideoShape Shape;

	[Token(Token = "0x40002A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public VideoStereo Stereo;

	[Token(Token = "0x40002A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public bool AutoDetectStereoLayout;

	[Token(Token = "0x40002A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7D")]
	public bool DisplayMono;

	[Token(Token = "0x40002AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private VideoShape _LastShape;

	[Token(Token = "0x40002AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private VideoStereo _LastStereo;

	[Token(Token = "0x40002AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool _LastDisplayMono;

	[Token(Token = "0x17000063")]
	public bool IsPlaying
	{
		[Token(Token = "0x60002EC")]
		[Address(RVA = "0xE69C20", Offset = "0xE69C20", VA = "0xE69C20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60002ED")]
		[Address(RVA = "0xE69C28", Offset = "0xE69C28", VA = "0xE69C28")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000064")]
	public long Duration
	{
		[Token(Token = "0x60002EE")]
		[Address(RVA = "0xE69C34", Offset = "0xE69C34", VA = "0xE69C34")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60002EF")]
		[Address(RVA = "0xE69C3C", Offset = "0xE69C3C", VA = "0xE69C3C")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000065")]
	public long PlaybackPosition
	{
		[Token(Token = "0x60002F0")]
		[Address(RVA = "0xE69C44", Offset = "0xE69C44", VA = "0xE69C44")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60002F1")]
		[Address(RVA = "0xE69C4C", Offset = "0xE69C4C", VA = "0xE69C4C")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x60002F2")]
	[Address(RVA = "0xE69C54", Offset = "0xE69C54", VA = "0xE69C54")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002F3")]
	[Address(RVA = "0xE69ED8", Offset = "0xE69ED8", VA = "0xE69ED8")]
	private bool IsLocalVideo(string movieName)
	{
		return default(bool);
	}

	[Token(Token = "0x60002F4")]
	[Address(RVA = "0xE69F38", Offset = "0xE69F38", VA = "0xE69F38")]
	private void UpdateShapeAndStereo()
	{
	}

	[Token(Token = "0x60002F5")]
	[Address(RVA = "0xE6A238", Offset = "0xE6A238", VA = "0xE6A238")]
	[IteratorStateMachine(typeof(<Start>d__33))]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x60002F6")]
	[Address(RVA = "0xE6A2D4", Offset = "0xE6A2D4", VA = "0xE6A2D4")]
	public void Play(string moviePath, string drmLicencesUrl)
	{
	}

	[Token(Token = "0x60002F7")]
	[Address(RVA = "0xE6A5AC", Offset = "0xE6A5AC", VA = "0xE6A5AC")]
	public void Play()
	{
	}

	[Token(Token = "0x60002F8")]
	[Address(RVA = "0xE6A630", Offset = "0xE6A630", VA = "0xE6A630")]
	public void Pause()
	{
	}

	[Token(Token = "0x60002F9")]
	[Address(RVA = "0xE6A6B0", Offset = "0xE6A6B0", VA = "0xE6A6B0")]
	public void SeekTo(long position)
	{
	}

	[Token(Token = "0x60002FA")]
	[Address(RVA = "0xE6A79C", Offset = "0xE6A79C", VA = "0xE6A79C")]
	private void Update()
	{
	}

	[Token(Token = "0x60002FB")]
	[Address(RVA = "0xE6AD38", Offset = "0xE6AD38", VA = "0xE6AD38")]
	public void SetPlaybackSpeed(float speed)
	{
	}

	[Token(Token = "0x60002FC")]
	[Address(RVA = "0xE6ADD4", Offset = "0xE6ADD4", VA = "0xE6ADD4")]
	public void Stop()
	{
	}

	[Token(Token = "0x60002FD")]
	[Address(RVA = "0xE6AE54", Offset = "0xE6AE54", VA = "0xE6AE54")]
	private void OnApplicationPause(bool appWasPaused)
	{
	}

	[Token(Token = "0x60002FE")]
	[Address(RVA = "0xE6AF34", Offset = "0xE6AF34", VA = "0xE6AF34")]
	public MoviePlayerSample()
	{
	}
}
[Token(Token = "0x20000A2")]
public class MoviePlayerSampleControls : MonoBehaviour
{
	[Token(Token = "0x20000A3")]
	private enum PlaybackState
	{
		[Token(Token = "0x40002D2")]
		Playing,
		[Token(Token = "0x40002D3")]
		Paused,
		[Token(Token = "0x40002D4")]
		Rewinding,
		[Token(Token = "0x40002D5")]
		FastForwarding
	}

	[Token(Token = "0x40002BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MoviePlayerSample Player;

	[Token(Token = "0x40002BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OVRInputModule InputModule;

	[Token(Token = "0x40002BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OVRGazePointer GazePointer;

	[Token(Token = "0x40002BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject LeftHand;

	[Token(Token = "0x40002C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject RightHand;

	[Token(Token = "0x40002C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Canvas Canvas;

	[Token(Token = "0x40002C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ButtonDownListener PlayPause;

	[Token(Token = "0x40002C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public MediaPlayerImage PlayPauseImage;

	[Token(Token = "0x40002C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Slider ProgressBar;

	[Token(Token = "0x40002C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public ButtonDownListener FastForward;

	[Token(Token = "0x40002C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public MediaPlayerImage FastForwardImage;

	[Token(Token = "0x40002C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public ButtonDownListener Rewind;

	[Token(Token = "0x40002C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public MediaPlayerImage RewindImage;

	[Token(Token = "0x40002C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float TimeoutTime;

	[Token(Token = "0x40002CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private bool _isVisible;

	[Token(Token = "0x40002CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private float _lastButtonTime;

	[Token(Token = "0x40002CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private bool _didSeek;

	[Token(Token = "0x40002CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private long _seekPreviousPosition;

	[Token(Token = "0x40002CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private long _rewindStartPosition;

	[Token(Token = "0x40002CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private float _rewindStartTime;

	[Token(Token = "0x40002D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private PlaybackState _state;

	[Token(Token = "0x6000307")]
	[Address(RVA = "0xE6B214", Offset = "0xE6B214", VA = "0xE6B214")]
	private void Start()
	{
	}

	[Token(Token = "0x6000308")]
	[Address(RVA = "0xE6B540", Offset = "0xE6B540", VA = "0xE6B540")]
	private void OnPlayPauseClicked()
	{
	}

	[Token(Token = "0x6000309")]
	[Address(RVA = "0xE6B710", Offset = "0xE6B710", VA = "0xE6B710")]
	private void OnFastForwardClicked()
	{
	}

	[Token(Token = "0x600030A")]
	[Address(RVA = "0xE6B834", Offset = "0xE6B834", VA = "0xE6B834")]
	private void OnRewindClicked()
	{
	}

	[Token(Token = "0x600030B")]
	[Address(RVA = "0xE6B930", Offset = "0xE6B930", VA = "0xE6B930")]
	private void OnSeekBarMoved(float value)
	{
	}

	[Token(Token = "0x600030C")]
	[Address(RVA = "0xE6B808", Offset = "0xE6B808", VA = "0xE6B808")]
	private void Seek(long pos)
	{
	}

	[Token(Token = "0x600030D")]
	[Address(RVA = "0xE6B990", Offset = "0xE6B990", VA = "0xE6B990")]
	private void Update()
	{
	}

	[Token(Token = "0x600030E")]
	[Address(RVA = "0xE6B440", Offset = "0xE6B440", VA = "0xE6B440")]
	private void SetVisible(bool visible)
	{
	}

	[Token(Token = "0x600030F")]
	[Address(RVA = "0xE6BCC0", Offset = "0xE6BCC0", VA = "0xE6BCC0")]
	public MoviePlayerSampleControls()
	{
	}
}
[Token(Token = "0x20000A4")]
public static class VectorUtil
{
	[Token(Token = "0x6000310")]
	[Address(RVA = "0xE6ACC0", Offset = "0xE6ACC0", VA = "0xE6ACC0")]
	public static Vector4 ToVector(this Rect rect)
	{
		return default(Vector4);
	}
}
[Token(Token = "0x20000A5")]
public class AppDeeplinkUI : MonoBehaviour
{
	[Token(Token = "0x40002D6")]
	private const ulong UNITY_COMPANION_APP_ID = 3535750239844224uL;

	[Token(Token = "0x40002D7")]
	private const ulong UNREAL_COMPANION_APP_ID = 4055411724486843uL;

	[Token(Token = "0x40002D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private RectTransform deeplinkAppId;

	[Token(Token = "0x40002D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private RectTransform deeplinkMessage;

	[Token(Token = "0x40002DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private RectTransform uiLaunchType;

	[Token(Token = "0x40002DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private RectTransform uiLaunchSource;

	[Token(Token = "0x40002DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private RectTransform uiDeepLinkMessage;

	[Token(Token = "0x40002DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool inMenu;

	[Token(Token = "0x6000311")]
	[Address(RVA = "0xE6BCD0", Offset = "0xE6BCD0", VA = "0xE6BCD0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000312")]
	[Address(RVA = "0xE6C324", Offset = "0xE6C324", VA = "0xE6C324")]
	private void Update()
	{
	}

	[Token(Token = "0x6000313")]
	[Address(RVA = "0xE6C580", Offset = "0xE6C580", VA = "0xE6C580")]
	private void LaunchUnrealDeeplinkSample()
	{
	}

	[Token(Token = "0x6000314")]
	[Address(RVA = "0xE6C6E4", Offset = "0xE6C6E4", VA = "0xE6C6E4")]
	private void LaunchSelf()
	{
	}

	[Token(Token = "0x6000315")]
	[Address(RVA = "0xE6C84C", Offset = "0xE6C84C", VA = "0xE6C84C")]
	private void LaunchOtherApp()
	{
	}

	[Token(Token = "0x6000316")]
	[Address(RVA = "0xE6C9D0", Offset = "0xE6C9D0", VA = "0xE6C9D0")]
	public AppDeeplinkUI()
	{
	}
}
[Token(Token = "0x20000A6")]
public class CustomDebugUI : MonoBehaviour
{
	[Token(Token = "0x40002DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RectTransform textPrefab;

	[Token(Token = "0x40002DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static CustomDebugUI instance;

	[Token(Token = "0x40002E0")]
	private const BindingFlags privateFlags = BindingFlags.Instance | BindingFlags.NonPublic;

	[Token(Token = "0x6000317")]
	[Address(RVA = "0xE6C9E0", Offset = "0xE6C9E0", VA = "0xE6C9E0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000318")]
	[Address(RVA = "0xE6CA38", Offset = "0xE6CA38", VA = "0xE6CA38")]
	private void Start()
	{
	}

	[Token(Token = "0x6000319")]
	[Address(RVA = "0xE6CA3C", Offset = "0xE6CA3C", VA = "0xE6CA3C")]
	private void Update()
	{
	}

	[Token(Token = "0x600031A")]
	[Address(RVA = "0xE6C0CC", Offset = "0xE6C0CC", VA = "0xE6C0CC")]
	public RectTransform AddTextField(string label, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x600031B")]
	[Address(RVA = "0xE6CA40", Offset = "0xE6CA40", VA = "0xE6CA40")]
	public void RemoveFromCanvas(RectTransform element, int targetCanvas = 0)
	{
	}

	[Token(Token = "0x600031C")]
	[Address(RVA = "0xE6CC5C", Offset = "0xE6CC5C", VA = "0xE6CC5C")]
	public CustomDebugUI()
	{
	}
}
[Token(Token = "0x20000A7")]
public class DebugUISample : MonoBehaviour
{
	[Token(Token = "0x40002E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool inMenu;

	[Token(Token = "0x40002E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Text sliderText;

	[Token(Token = "0x600031D")]
	[Address(RVA = "0xE6CC64", Offset = "0xE6CC64", VA = "0xE6CC64")]
	private void Start()
	{
	}

	[Token(Token = "0x600031E")]
	[Address(RVA = "0xE6D1C4", Offset = "0xE6D1C4", VA = "0xE6D1C4")]
	public void TogglePressed(Toggle t)
	{
	}

	[Token(Token = "0x600031F")]
	[Address(RVA = "0xE6D270", Offset = "0xE6D270", VA = "0xE6D270")]
	public void RadioPressed(string radioLabel, string group, Toggle t)
	{
	}

	[Token(Token = "0x6000320")]
	[Address(RVA = "0xE6D500", Offset = "0xE6D500", VA = "0xE6D500")]
	public void SliderPressed(float f)
	{
	}

	[Token(Token = "0x6000321")]
	[Address(RVA = "0xE6D5D4", Offset = "0xE6D5D4", VA = "0xE6D5D4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000322")]
	[Address(RVA = "0xE6D6AC", Offset = "0xE6D6AC", VA = "0xE6D6AC")]
	private void LogButtonPressed()
	{
	}

	[Token(Token = "0x6000323")]
	[Address(RVA = "0xE6D714", Offset = "0xE6D714", VA = "0xE6D714")]
	public DebugUISample()
	{
	}
}
[Token(Token = "0x20000A8")]
public class AnalyticsUI : MonoBehaviour
{
	[Token(Token = "0x6000328")]
	[Address(RVA = "0xE6D8BC", Offset = "0xE6D8BC", VA = "0xE6D8BC")]
	public AnalyticsUI()
	{
	}
}
[Token(Token = "0x20000A9")]
public class SampleUI : MonoBehaviour
{
	[Token(Token = "0x40002E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private RectTransform collectionButton;

	[Token(Token = "0x40002E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private RectTransform inputText;

	[Token(Token = "0x40002E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private RectTransform valueText;

	[Token(Token = "0x40002E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool inMenu;

	[Token(Token = "0x6000329")]
	[Address(RVA = "0xE6D8C4", Offset = "0xE6D8C4", VA = "0xE6D8C4")]
	private void Start()
	{
	}

	[Token(Token = "0x600032A")]
	[Address(RVA = "0xE6D95C", Offset = "0xE6D95C", VA = "0xE6D95C")]
	private void Update()
	{
	}

	[Token(Token = "0x600032B")]
	[Address(RVA = "0xE6DA34", Offset = "0xE6DA34", VA = "0xE6DA34")]
	private string GetText()
	{
		return null;
	}

	[Token(Token = "0x600032C")]
	[Address(RVA = "0xE6DA90", Offset = "0xE6DA90", VA = "0xE6DA90")]
	public SampleUI()
	{
	}
}
[Token(Token = "0x20000AA")]
public class StartCrashlytics : MonoBehaviour
{
	[Token(Token = "0x600032D")]
	[Address(RVA = "0xE6DA98", Offset = "0xE6DA98", VA = "0xE6DA98")]
	public StartCrashlytics()
	{
	}
}
[Token(Token = "0x20000AB")]
public class HandsActiveChecker : MonoBehaviour
{
	[Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private sealed class <GetCenterEye>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HandsActiveChecker <>4__this;

		[Token(Token = "0x17000068")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000335")]
			[Address(RVA = "0xE6DEA8", Offset = "0xE6DEA8", VA = "0xE6DEA8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000069")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000337")]
			[Address(RVA = "0xE6DEF0", Offset = "0xE6DEF0", VA = "0xE6DEF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0xE6DD44", Offset = "0xE6DD44", VA = "0xE6DD44")]
		[DebuggerHidden]
		public <GetCenterEye>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0xE6DD74", Offset = "0xE6DD74", VA = "0xE6DD74", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0xE6DD78", Offset = "0xE6DD78", VA = "0xE6DD78", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0xE6DEB0", Offset = "0xE6DEB0", VA = "0xE6DEB0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40002E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject _notificationPrefab;

	[Token(Token = "0x40002E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject _notification;

	[Token(Token = "0x40002E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private OVRCameraRig _cameraRig;

	[Token(Token = "0x40002EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Transform _centerEye;

	[Token(Token = "0x600032E")]
	[Address(RVA = "0xE6DAA0", Offset = "0xE6DAA0", VA = "0xE6DAA0")]
	private void Awake()
	{
	}

	[Token(Token = "0x600032F")]
	[Address(RVA = "0xE6DBAC", Offset = "0xE6DBAC", VA = "0xE6DBAC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000330")]
	[Address(RVA = "0xE6DB38", Offset = "0xE6DB38", VA = "0xE6DB38")]
	[IteratorStateMachine(typeof(<GetCenterEye>d__6))]
	private IEnumerator GetCenterEye()
	{
		return null;
	}

	[Token(Token = "0x6000331")]
	[Address(RVA = "0xE6DD6C", Offset = "0xE6DD6C", VA = "0xE6DD6C")]
	public HandsActiveChecker()
	{
	}
}
[Token(Token = "0x20000AD")]
[ExecuteInEditMode]
public class CharacterCapsule : MonoBehaviour
{
	[Token(Token = "0x40002EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private CharacterController _character;

	[Token(Token = "0x40002EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private MeshFilter _meshFilter;

	[Token(Token = "0x40002F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float _height;

	[Token(Token = "0x40002F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float _radius;

	[Token(Token = "0x40002F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Range(4f, 32f)]
	public int SubdivisionsU;

	[Token(Token = "0x40002F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[Range(4f, 32f)]
	public int SubdivisionsV;

	[Token(Token = "0x40002F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int _subdivisionU;

	[Token(Token = "0x40002F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private int _subdivisionV;

	[Token(Token = "0x40002F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Vector3[] _vertices;

	[Token(Token = "0x40002F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int[] _triangles;

	[Token(Token = "0x6000338")]
	[Address(RVA = "0xE6DEF8", Offset = "0xE6DEF8", VA = "0xE6DEF8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000339")]
	[Address(RVA = "0xE6F8A0", Offset = "0xE6F8A0", VA = "0xE6F8A0")]
	public CharacterCapsule()
	{
	}
}
[Token(Token = "0x20000AE")]
public class LocomotionSampleSupport : MonoBehaviour
{
	[Token(Token = "0x40002F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private LocomotionController lc;

	[Token(Token = "0x40002F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool inMenu;

	[Token(Token = "0x1700006A")]
	private LocomotionTeleport TeleportController
	{
		[Token(Token = "0x600033A")]
		[Address(RVA = "0xE6F8A8", Offset = "0xE6F8A8", VA = "0xE6F8A8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600033B")]
	[Address(RVA = "0xE6F8F8", Offset = "0xE6F8F8", VA = "0xE6F8F8")]
	public void Start()
	{
	}

	[Token(Token = "0x600033C")]
	[Address(RVA = "0xE6FD30", Offset = "0xE6FD30", VA = "0xE6FD30")]
	public void Update()
	{
	}

	[Token(Token = "0x600033D")]
	[Address(RVA = "0xE6FE08", Offset = "0xE6FE08", VA = "0xE6FE08")]
	[Conditional("DEBUG_LOCOMOTION_PANEL")]
	private static void Log(string msg)
	{
	}

	[Token(Token = "0x600033E")]
	public static TActivate ActivateCategory<TCategory, TActivate>(GameObject target) where TCategory : MonoBehaviour where TActivate : MonoBehaviour
	{
		return null;
	}

	[Token(Token = "0x600033F")]
	protected void ActivateHandlers<TInput, TAim, TTarget, TOrientation, TTransition>() where TInput : TeleportInputHandler where TAim : TeleportAimHandler where TTarget : TeleportTargetHandler where TOrientation : TeleportOrientationHandler where TTransition : TeleportTransition
	{
	}

	[Token(Token = "0x6000340")]
	protected void ActivateInput<TActivate>() where TActivate : TeleportInputHandler
	{
	}

	[Token(Token = "0x6000341")]
	protected void ActivateAim<TActivate>() where TActivate : TeleportAimHandler
	{
	}

	[Token(Token = "0x6000342")]
	protected void ActivateTarget<TActivate>() where TActivate : TeleportTargetHandler
	{
	}

	[Token(Token = "0x6000343")]
	protected void ActivateOrientation<TActivate>() where TActivate : TeleportOrientationHandler
	{
	}

	[Token(Token = "0x6000344")]
	protected void ActivateTransition<TActivate>() where TActivate : TeleportTransition
	{
	}

	[Token(Token = "0x6000345")]
	protected TActivate ActivateCategory<TCategory, TActivate>() where TCategory : MonoBehaviour where TActivate : MonoBehaviour
	{
		return null;
	}

	[Token(Token = "0x6000346")]
	[Address(RVA = "0xE6FE60", Offset = "0xE6FE60", VA = "0xE6FE60")]
	protected void UpdateToggle(Toggle toggle, bool enabled)
	{
	}

	[Token(Token = "0x6000347")]
	[Address(RVA = "0xE6FEA0", Offset = "0xE6FEA0", VA = "0xE6FEA0")]
	private void SetupNonCap()
	{
	}

	[Token(Token = "0x6000348")]
	[Address(RVA = "0xE6FF0C", Offset = "0xE6FF0C", VA = "0xE6FF0C")]
	private void SetupTeleportDefaults()
	{
	}

	[Token(Token = "0x6000349")]
	[Address(RVA = "0xE70058", Offset = "0xE70058", VA = "0xE70058")]
	protected GameObject AddInstance(GameObject template, string label)
	{
		return null;
	}

	[Token(Token = "0x600034A")]
	[Address(RVA = "0xE70128", Offset = "0xE70128", VA = "0xE70128")]
	private void SetupNodeTeleport()
	{
	}

	[Token(Token = "0x600034B")]
	[Address(RVA = "0xE6FC0C", Offset = "0xE6FC0C", VA = "0xE6FC0C")]
	private void SetupTwoStickTeleport()
	{
	}

	[Token(Token = "0x600034C")]
	[Address(RVA = "0xE701F8", Offset = "0xE701F8", VA = "0xE701F8")]
	private void SetupWalkOnly()
	{
	}

	[Token(Token = "0x600034D")]
	[Address(RVA = "0xE70244", Offset = "0xE70244", VA = "0xE70244")]
	private void SetupLeftStrafeRightTeleport()
	{
	}

	[Token(Token = "0x600034E")]
	[Address(RVA = "0xE70354", Offset = "0xE70354", VA = "0xE70354")]
	public LocomotionSampleSupport()
	{
	}
}
[Token(Token = "0x20000AF")]
[RequireComponent(typeof(Canvas))]
public class OVROverlayCanvas : MonoBehaviour
{
	[Token(Token = "0x20000B0")]
	public enum DrawMode
	{
		[Token(Token = "0x400030F")]
		Opaque,
		[Token(Token = "0x4000310")]
		OpaqueWithClip,
		[Token(Token = "0x4000311")]
		TransparentDefaultAlpha,
		[Token(Token = "0x4000312")]
		TransparentCorrectAlpha
	}

	[Token(Token = "0x40002FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	[SerializeField]
	private Shader _transparentShader;

	[Token(Token = "0x40002FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	[HideInInspector]
	private Shader _opaqueShader;

	[Token(Token = "0x40002FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private RectTransform _rectTransform;

	[Token(Token = "0x40002FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Canvas _canvas;

	[Token(Token = "0x40002FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Camera _camera;

	[Token(Token = "0x40002FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private OVROverlay _overlay;

	[Token(Token = "0x4000300")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private RenderTexture _renderTexture;

	[Token(Token = "0x4000301")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private MeshRenderer _meshRenderer;

	[Token(Token = "0x4000302")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Mesh _quad;

	[Token(Token = "0x4000303")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Material _defaultMat;

	[Token(Token = "0x4000304")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public int MaxTextureSize;

	[Token(Token = "0x4000305")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public int MinTextureSize;

	[Token(Token = "0x4000306")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float PixelsPerUnit;

	[Token(Token = "0x4000307")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public int DrawRate;

	[Token(Token = "0x4000308")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public int DrawFrameOffset;

	[Token(Token = "0x4000309")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public bool Expensive;

	[Token(Token = "0x400030A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public int Layer;

	[Token(Token = "0x400030B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public DrawMode Opacity;

	[Token(Token = "0x400030C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool ScaleViewport;

	[Token(Token = "0x400030D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly Plane[] _FrustumPlanes;

	[Token(Token = "0x1700006B")]
	public bool overlayEnabled
	{
		[Token(Token = "0x6000355")]
		[Address(RVA = "0xE71998", Offset = "0xE71998", VA = "0xE71998")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000356")]
		[Address(RVA = "0xE71A1C", Offset = "0xE71A1C", VA = "0xE71A1C")]
		set
		{
		}
	}

	[Token(Token = "0x600034F")]
	[Address(RVA = "0xE7035C", Offset = "0xE7035C", VA = "0xE7035C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000350")]
	[Address(RVA = "0xE71020", Offset = "0xE71020", VA = "0xE71020")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000351")]
	[Address(RVA = "0xE71094", Offset = "0xE71094", VA = "0xE71094")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000352")]
	[Address(RVA = "0xE71164", Offset = "0xE71164", VA = "0xE71164")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000353")]
	[Address(RVA = "0xE71234", Offset = "0xE71234", VA = "0xE71234", Slot = "4")]
	protected virtual bool ShouldRender()
	{
		return default(bool);
	}

	[Token(Token = "0x6000354")]
	[Address(RVA = "0xE71438", Offset = "0xE71438", VA = "0xE71438")]
	private void Update()
	{
	}

	[Token(Token = "0x6000357")]
	[Address(RVA = "0xE71AD8", Offset = "0xE71AD8", VA = "0xE71AD8")]
	public OVROverlayCanvas()
	{
	}
}
[Token(Token = "0x20000B1")]
public class AugmentedObject : MonoBehaviour
{
	[Token(Token = "0x4000313")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRInput.Controller controllerHand;

	[Token(Token = "0x4000314")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform shadow;

	[Token(Token = "0x4000315")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool groundShadow;

	[Token(Token = "0x6000359")]
	[Address(RVA = "0xE71B94", Offset = "0xE71B94", VA = "0xE71B94")]
	private void Start()
	{
	}

	[Token(Token = "0x600035A")]
	[Address(RVA = "0xE71F34", Offset = "0xE71F34", VA = "0xE71F34")]
	private void Update()
	{
	}

	[Token(Token = "0x600035B")]
	[Address(RVA = "0xE720C8", Offset = "0xE720C8", VA = "0xE720C8")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x600035C")]
	[Address(RVA = "0xE720D0", Offset = "0xE720D0", VA = "0xE720D0")]
	public void Release()
	{
	}

	[Token(Token = "0x600035D")]
	[Address(RVA = "0xE720B8", Offset = "0xE720B8", VA = "0xE720B8")]
	private void ToggleShadowType()
	{
	}

	[Token(Token = "0x600035E")]
	[Address(RVA = "0xE720D8", Offset = "0xE720D8", VA = "0xE720D8")]
	public AugmentedObject()
	{
	}
}
[Token(Token = "0x20000B2")]
public class BrushController : MonoBehaviour
{
	[Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private sealed class <FadeCameraClearColor>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float fadeTime;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Color newColor;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <timer>5__2;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Color <currentColor>5__3;

		[Token(Token = "0x1700006C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000369")]
			[Address(RVA = "0xE72820", Offset = "0xE72820", VA = "0xE72820", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600036B")]
			[Address(RVA = "0xE72868", Offset = "0xE72868", VA = "0xE72868", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0xE726C4", Offset = "0xE726C4", VA = "0xE726C4")]
		[DebuggerHidden]
		public <FadeCameraClearColor>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0xE7271C", Offset = "0xE7271C", VA = "0xE7271C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0xE72720", Offset = "0xE72720", VA = "0xE72720", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0xE72828", Offset = "0xE72828", VA = "0xE72828", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000B4")]
	[CompilerGenerated]
	private sealed class <FadeSphere>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BrushController <>4__this;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fadeTime;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Color newColor;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool disableOnFinish;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float <timer>5__2;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Color <currentColor>5__3;

		[Token(Token = "0x1700006E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600036F")]
			[Address(RVA = "0xE729EC", Offset = "0xE729EC", VA = "0xE729EC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000371")]
			[Address(RVA = "0xE72A34", Offset = "0xE72A34", VA = "0xE72A34", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0xE726EC", Offset = "0xE726EC", VA = "0xE726EC")]
		[DebuggerHidden]
		public <FadeSphere>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0xE72870", Offset = "0xE72870", VA = "0xE72870", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0xE72874", Offset = "0xE72874", VA = "0xE72874", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0xE729F4", Offset = "0xE729F4", VA = "0xE729F4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000316")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public PassthroughBrush brush;

	[Token(Token = "0x4000317")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshRenderer backgroundSphere;

	[Token(Token = "0x4000318")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private IEnumerator grabRoutine;

	[Token(Token = "0x4000319")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private IEnumerator releaseRoutine;

	[Token(Token = "0x600035F")]
	[Address(RVA = "0xE720E0", Offset = "0xE720E0", VA = "0xE720E0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000360")]
	[Address(RVA = "0xE723C0", Offset = "0xE723C0", VA = "0xE723C0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000361")]
	[Address(RVA = "0xE72410", Offset = "0xE72410", VA = "0xE72410")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x6000362")]
	[Address(RVA = "0xE72588", Offset = "0xE72588", VA = "0xE72588")]
	public void Release()
	{
	}

	[Token(Token = "0x6000363")]
	[Address(RVA = "0xE7262C", Offset = "0xE7262C", VA = "0xE7262C")]
	[IteratorStateMachine(typeof(<FadeCameraClearColor>d__8))]
	private IEnumerator FadeCameraClearColor(Color newColor, float fadeTime)
	{
		return null;
	}

	[Token(Token = "0x6000364")]
	[Address(RVA = "0xE724C8", Offset = "0xE724C8", VA = "0xE724C8")]
	[IteratorStateMachine(typeof(<FadeSphere>d__9))]
	private IEnumerator FadeSphere(Color newColor, float fadeTime, bool disableOnFinish = false)
	{
		return null;
	}

	[Token(Token = "0x6000365")]
	[Address(RVA = "0xE72714", Offset = "0xE72714", VA = "0xE72714")]
	public BrushController()
	{
	}
}
[Token(Token = "0x20000B5")]
public class EnableUnpremultipliedAlpha : MonoBehaviour
{
	[Token(Token = "0x6000372")]
	[Address(RVA = "0xE72A3C", Offset = "0xE72A3C", VA = "0xE72A3C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000373")]
	[Address(RVA = "0xE72A90", Offset = "0xE72A90", VA = "0xE72A90")]
	public EnableUnpremultipliedAlpha()
	{
	}
}
[Token(Token = "0x20000B6")]
public class Flashlight : MonoBehaviour
{
	[Token(Token = "0x4000328")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject lightVolume;

	[Token(Token = "0x4000329")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Light spotlight;

	[Token(Token = "0x400032A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject bulbGlow;

	[Token(Token = "0x6000374")]
	[Address(RVA = "0xE72A98", Offset = "0xE72A98", VA = "0xE72A98")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000375")]
	[Address(RVA = "0xE72C6C", Offset = "0xE72C6C", VA = "0xE72C6C")]
	public void ToggleFlashlight()
	{
	}

	[Token(Token = "0x6000376")]
	[Address(RVA = "0xE72CFC", Offset = "0xE72CFC", VA = "0xE72CFC")]
	public void EnableFlashlight(bool doEnable)
	{
	}

	[Token(Token = "0x6000377")]
	[Address(RVA = "0xE72D58", Offset = "0xE72D58", VA = "0xE72D58")]
	public Flashlight()
	{
	}
}
[Token(Token = "0x20000B7")]
public class FlashlightController : MonoBehaviour
{
	[Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private sealed class <FadeLighting>d__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FlashlightController <>4__this;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fadeTime;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Color newColor;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float sceneLightIntensity;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float <timer>5__2;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Color <currentColor>5__3;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float <currentLight>5__4;

		[Token(Token = "0x17000070")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000384")]
			[Address(RVA = "0xE73F30", Offset = "0xE73F30", VA = "0xE73F30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000071")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000386")]
			[Address(RVA = "0xE73F78", Offset = "0xE73F78", VA = "0xE73F78", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0xE73C98", Offset = "0xE73C98", VA = "0xE73C98")]
		[DebuggerHidden]
		public <FadeLighting>d__17(int <>1__state)
		{
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0xE73D60", Offset = "0xE73D60", VA = "0xE73D60", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0xE73D64", Offset = "0xE73D64", VA = "0xE73D64", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0xE73F38", Offset = "0xE73F38", VA = "0xE73F38", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400032B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Light sceneLight;

	[Token(Token = "0x400032C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform flashlightRoot;

	[Token(Token = "0x400032D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Vector3 localPosition;

	[Token(Token = "0x400032E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Quaternion localRotation;

	[Token(Token = "0x400032F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TextMesh infoText;

	[Token(Token = "0x4000330")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private GrabObject externalController;

	[Token(Token = "0x4000331")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private OVRSkeleton[] skeletons;

	[Token(Token = "0x4000332")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private OVRHand[] hands;

	[Token(Token = "0x4000333")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int handIndex;

	[Token(Token = "0x4000334")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private bool pinching;

	[Token(Token = "0x6000378")]
	[Address(RVA = "0xE72D60", Offset = "0xE72D60", VA = "0xE72D60")]
	private void Start()
	{
	}

	[Token(Token = "0x6000379")]
	[Address(RVA = "0xE73048", Offset = "0xE73048", VA = "0xE73048")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600037A")]
	[Address(RVA = "0xE73334", Offset = "0xE73334", VA = "0xE73334")]
	private void FindHands()
	{
	}

	[Token(Token = "0x600037B")]
	[Address(RVA = "0xE7365C", Offset = "0xE7365C", VA = "0xE7365C")]
	private void AlignWithHand(OVRHand hand, OVRSkeleton skeleton)
	{
	}

	[Token(Token = "0x600037C")]
	[Address(RVA = "0xE73934", Offset = "0xE73934", VA = "0xE73934")]
	private void AlignWithController(OVRInput.Controller controller)
	{
	}

	[Token(Token = "0x600037D")]
	[Address(RVA = "0xE73A1C", Offset = "0xE73A1C", VA = "0xE73A1C")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x600037E")]
	[Address(RVA = "0xE73BB4", Offset = "0xE73BB4", VA = "0xE73BB4")]
	public void Release()
	{
	}

	[Token(Token = "0x600037F")]
	[Address(RVA = "0xE73B04", Offset = "0xE73B04", VA = "0xE73B04")]
	[IteratorStateMachine(typeof(<FadeLighting>d__17))]
	private IEnumerator FadeLighting(Color newColor, float sceneLightIntensity, float fadeTime)
	{
		return null;
	}

	[Token(Token = "0x6000380")]
	[Address(RVA = "0xE73CC0", Offset = "0xE73CC0", VA = "0xE73CC0")]
	public FlashlightController()
	{
	}
}
[Token(Token = "0x20000B9")]
public class GrabObject : MonoBehaviour
{
	[Token(Token = "0x20000BA")]
	public enum ManipulationType
	{
		[Token(Token = "0x4000347")]
		Default,
		[Token(Token = "0x4000348")]
		ForcedHand,
		[Token(Token = "0x4000349")]
		DollyHand,
		[Token(Token = "0x400034A")]
		DollyAttached,
		[Token(Token = "0x400034B")]
		HorizontalScaled,
		[Token(Token = "0x400034C")]
		VerticalScaled,
		[Token(Token = "0x400034D")]
		Menu
	}

	[Token(Token = "0x20000BB")]
	public delegate void GrabbedObject(OVRInput.Controller grabHand);

	[Token(Token = "0x20000BC")]
	public delegate void ReleasedObject();

	[Token(Token = "0x20000BD")]
	public delegate void SetCursorPosition(Vector3 cursorPosition);

	[Token(Token = "0x400033E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[TextArea]
	public string ObjectName;

	[Token(Token = "0x400033F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[TextArea]
	public string ObjectInstructions;

	[Token(Token = "0x4000340")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ManipulationType objectManipulationType;

	[Token(Token = "0x4000341")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool showLaserWhileGrabbed;

	[Token(Token = "0x4000342")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public Quaternion grabbedRotation;

	[Token(Token = "0x4000343")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GrabbedObject GrabbedObjectDelegate;

	[Token(Token = "0x4000344")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ReleasedObject ReleasedObjectDelegate;

	[Token(Token = "0x4000345")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public SetCursorPosition CursorPositionDelegate;

	[Token(Token = "0x6000387")]
	[Address(RVA = "0xE73F80", Offset = "0xE73F80", VA = "0xE73F80")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x6000388")]
	[Address(RVA = "0xE73FE0", Offset = "0xE73FE0", VA = "0xE73FE0")]
	public void Release()
	{
	}

	[Token(Token = "0x6000389")]
	[Address(RVA = "0xE73FFC", Offset = "0xE73FFC", VA = "0xE73FFC")]
	public void CursorPos(Vector3 cursorPos)
	{
	}

	[Token(Token = "0x600038A")]
	[Address(RVA = "0xE74018", Offset = "0xE74018", VA = "0xE74018")]
	public GrabObject()
	{
	}
}
[Token(Token = "0x20000BE")]
public class HandMeshMask : MonoBehaviour
{
	[Token(Token = "0x400034E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRSkeleton referenceHand;

	[Token(Token = "0x400034F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Material maskMaterial;

	[Token(Token = "0x4000350")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Tooltip("The segments around the tip of a finger")]
	public int radialDivisions;

	[Token(Token = "0x4000351")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[Tooltip("The fade range (finger width is 2x this)")]
	public float borderSize;

	[Token(Token = "0x4000352")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Tooltip("Along the fingers, each knuckle scales down by this amount.  Default is zero for uniform width along entire finger.")]
	public float fingerTaper;

	[Token(Token = "0x4000353")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[Tooltip("Shorten the last bone of each finger; need this to account for bone structure (end bone is at finger tip instead of center). Default is 1.")]
	public float fingerTipLength;

	[Token(Token = "0x4000354")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Tooltip("Move the base of the 4 main fingers towards the tips, to avoid a visible mesh crack between finger webbing. Default is 0.")]
	public float webOffset;

	[Token(Token = "0x4000355")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float handScale;

	[Token(Token = "0x4000356")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private GameObject maskMeshObject;

	[Token(Token = "0x4000357")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Mesh maskMesh;

	[Token(Token = "0x4000358")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3[] handVertices;

	[Token(Token = "0x4000359")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Vector2[] handUVs;

	[Token(Token = "0x400035A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Color32[] handColors;

	[Token(Token = "0x400035B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int[] handTriangles;

	[Token(Token = "0x400035C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private int vertCounter;

	[Token(Token = "0x400035D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private int triCounter;

	[Token(Token = "0x6000397")]
	[Address(RVA = "0xE742D0", Offset = "0xE742D0", VA = "0xE742D0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000398")]
	[Address(RVA = "0xE74530", Offset = "0xE74530", VA = "0xE74530")]
	private void Update()
	{
	}

	[Token(Token = "0x6000399")]
	[Address(RVA = "0xE746F8", Offset = "0xE746F8", VA = "0xE746F8")]
	private void CreateHandMesh()
	{
	}

	[Token(Token = "0x600039A")]
	[Address(RVA = "0xE74D4C", Offset = "0xE74D4C", VA = "0xE74D4C")]
	private void AddKnuckleMesh(int knuckleVerts, float point1scale, float point2scale, Vector3 point1, Vector3 point2)
	{
	}

	[Token(Token = "0x600039B")]
	[Address(RVA = "0xE752E4", Offset = "0xE752E4", VA = "0xE752E4")]
	private void AddPalmMesh(int knuckleVerts)
	{
	}

	[Token(Token = "0x600039C")]
	[Address(RVA = "0xE775EC", Offset = "0xE775EC", VA = "0xE775EC")]
	private void AddVertex(Vector3 position, Vector2 uv, Color color)
	{
	}

	[Token(Token = "0x600039D")]
	[Address(RVA = "0xE77960", Offset = "0xE77960", VA = "0xE77960")]
	public HandMeshMask()
	{
	}
}
[Token(Token = "0x20000BF")]
public class HandMeshUI : MonoBehaviour
{
	[Token(Token = "0x400035E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public SphereCollider[] knobs;

	[Token(Token = "0x400035F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextMesh[] readouts;

	[Token(Token = "0x4000360")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int rightHeldKnob;

	[Token(Token = "0x4000361")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private int leftHeldKnob;

	[Token(Token = "0x4000362")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public OVRSkeleton leftHand;

	[Token(Token = "0x4000363")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public OVRSkeleton rightHand;

	[Token(Token = "0x4000364")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public HandMeshMask leftMask;

	[Token(Token = "0x4000365")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public HandMeshMask rightMask;

	[Token(Token = "0x600039E")]
	[Address(RVA = "0xE77984", Offset = "0xE77984", VA = "0xE77984")]
	private void Start()
	{
	}

	[Token(Token = "0x600039F")]
	[Address(RVA = "0xE77CEC", Offset = "0xE77CEC", VA = "0xE77CEC")]
	private void Update()
	{
	}

	[Token(Token = "0x60003A0")]
	[Address(RVA = "0xE77A20", Offset = "0xE77A20", VA = "0xE77A20")]
	private void SetSliderValue(int sliderID, float value, bool isNormalized)
	{
	}

	[Token(Token = "0x60003A1")]
	[Address(RVA = "0xE78154", Offset = "0xE78154", VA = "0xE78154")]
	private void CheckForHands()
	{
	}

	[Token(Token = "0x60003A2")]
	[Address(RVA = "0xE786C4", Offset = "0xE786C4", VA = "0xE786C4")]
	public HandMeshUI()
	{
	}
}
[Token(Token = "0x20000C0")]
public class ObjectManipulator : MonoBehaviour
{
	[Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private sealed class <StartDemo>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ObjectManipulator <>4__this;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <timer>5__2;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <fadeTime>5__3;

		[Token(Token = "0x17000072")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003B2")]
			[Address(RVA = "0xE7AF50", Offset = "0xE7AF50", VA = "0xE7AF50", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000073")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003B4")]
			[Address(RVA = "0xE7AF98", Offset = "0xE7AF98", VA = "0xE7AF98", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0xE7A890", Offset = "0xE7A890", VA = "0xE7A890")]
		[DebuggerHidden]
		public <StartDemo>d__23(int <>1__state)
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0xE7AC78", Offset = "0xE7AC78", VA = "0xE7AC78", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0xE7AC7C", Offset = "0xE7AC7C", VA = "0xE7AC7C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0xE7AF58", Offset = "0xE7AF58", VA = "0xE7AF58", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000366")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRInput.Controller controller;

	[Token(Token = "0x4000367")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject hoverObject;

	[Token(Token = "0x4000368")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private GameObject grabObject;

	[Token(Token = "0x4000369")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float grabTime;

	[Token(Token = "0x400036A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Vector3 localGrabOffset;

	[Token(Token = "0x400036B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Quaternion localGrabRotation;

	[Token(Token = "0x400036C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3 camGrabPosition;

	[Token(Token = "0x400036D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private Quaternion camGrabRotation;

	[Token(Token = "0x400036E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private Vector3 handGrabPosition;

	[Token(Token = "0x400036F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Quaternion handGrabRotation;

	[Token(Token = "0x4000370")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Vector3 cursorPosition;

	[Token(Token = "0x4000371")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private float rotationOffset;

	[Token(Token = "0x4000372")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public LineRenderer laser;

	[Token(Token = "0x4000373")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Transform objectInfo;

	[Token(Token = "0x4000374")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public TextMesh objectNameLabel;

	[Token(Token = "0x4000375")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public TextMesh objectInstructionsLabel;

	[Token(Token = "0x4000376")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Image objectInfoBG;

	[Token(Token = "0x4000377")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public GameObject demoObjects;

	[Token(Token = "0x4000378")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public OVRPassthroughLayer passthrough;

	[Token(Token = "0x60003A3")]
	[Address(RVA = "0xE786D4", Offset = "0xE786D4", VA = "0xE786D4")]
	private void Start()
	{
	}

	[Token(Token = "0x60003A4")]
	[Address(RVA = "0xE788D0", Offset = "0xE788D0", VA = "0xE788D0")]
	private void Update()
	{
	}

	[Token(Token = "0x60003A5")]
	[Address(RVA = "0xE797FC", Offset = "0xE797FC", VA = "0xE797FC")]
	private void GrabHoverObject(GameObject grbObj, Vector3 controllerPos, Quaternion controllerRot)
	{
	}

	[Token(Token = "0x60003A6")]
	[Address(RVA = "0xE7A594", Offset = "0xE7A594", VA = "0xE7A594")]
	private void ReleaseObject()
	{
	}

	[Token(Token = "0x60003A7")]
	[Address(RVA = "0xE7885C", Offset = "0xE7885C", VA = "0xE7885C")]
	[IteratorStateMachine(typeof(<StartDemo>d__23))]
	private IEnumerator StartDemo()
	{
		return null;
	}

	[Token(Token = "0x60003A8")]
	[Address(RVA = "0xE78B20", Offset = "0xE78B20", VA = "0xE78B20")]
	private void FindHoverObject(Vector3 controllerPos, Quaternion controllerRot)
	{
	}

	[Token(Token = "0x60003A9")]
	[Address(RVA = "0xE79AF4", Offset = "0xE79AF4", VA = "0xE79AF4")]
	private void ManipulateObject(GameObject obj, Vector3 controllerPos, Quaternion controllerRot)
	{
	}

	[Token(Token = "0x60003AA")]
	[Address(RVA = "0xE7A8B8", Offset = "0xE7A8B8", VA = "0xE7A8B8")]
	private void ClampGrabOffset(ref Vector3 localOffset, float thumbY)
	{
	}

	[Token(Token = "0x60003AB")]
	[Address(RVA = "0xE7A96C", Offset = "0xE7A96C", VA = "0xE7A96C")]
	private Vector3 ClampScale(Vector3 localScale, Vector2 thumb)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60003AC")]
	[Address(RVA = "0xE7A99C", Offset = "0xE7A99C", VA = "0xE7A99C")]
	private void CheckForDominantHand()
	{
	}

	[Token(Token = "0x60003AD")]
	[Address(RVA = "0xE7A774", Offset = "0xE7A774", VA = "0xE7A774")]
	private void AssignInstructions(GrabObject targetObject)
	{
	}

	[Token(Token = "0x60003AE")]
	[Address(RVA = "0xE7AA8C", Offset = "0xE7AA8C", VA = "0xE7AA8C")]
	public ObjectManipulator()
	{
	}
}
[Token(Token = "0x20000C2")]
public class OverlayPassthrough : MonoBehaviour
{
	[Token(Token = "0x400037E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x60003B5")]
	[Address(RVA = "0xE7AFA0", Offset = "0xE7AFA0", VA = "0xE7AFA0")]
	private void Start()
	{
	}

	[Token(Token = "0x60003B6")]
	[Address(RVA = "0xE7B10C", Offset = "0xE7B10C", VA = "0xE7B10C")]
	private void Update()
	{
	}

	[Token(Token = "0x60003B7")]
	[Address(RVA = "0xE7B1C0", Offset = "0xE7B1C0", VA = "0xE7B1C0")]
	public OverlayPassthrough()
	{
	}
}
[Token(Token = "0x20000C3")]
public class PassthroughBrush : MonoBehaviour
{
	[Token(Token = "0x20000C4")]
	public enum BrushState
	{
		[Token(Token = "0x400038A")]
		Idle,
		[Token(Token = "0x400038B")]
		Inking
	}

	[Token(Token = "0x400037F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRInput.Controller controllerHand;

	[Token(Token = "0x4000380")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject lineSegmentPrefab;

	[Token(Token = "0x4000381")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject lineContainer;

	[Token(Token = "0x4000382")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool forceActive;

	[Token(Token = "0x4000383")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private LineRenderer currentLineSegment;

	[Token(Token = "0x4000384")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private List<Vector3> inkPositions;

	[Token(Token = "0x4000385")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float minInkDist;

	[Token(Token = "0x4000386")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private float strokeWidth;

	[Token(Token = "0x4000387")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float strokeLength;

	[Token(Token = "0x4000388")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private BrushState brushStatus;

	[Token(Token = "0x60003B8")]
	[Address(RVA = "0xE7B1C8", Offset = "0xE7B1C8", VA = "0xE7B1C8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60003B9")]
	[Address(RVA = "0xE7B1D0", Offset = "0xE7B1D0", VA = "0xE7B1D0")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60003BA")]
	[Address(RVA = "0xE7B480", Offset = "0xE7B480", VA = "0xE7B480")]
	private void StartLine(Vector3 inkPos)
	{
	}

	[Token(Token = "0x60003BB")]
	[Address(RVA = "0xE7B6B4", Offset = "0xE7B6B4", VA = "0xE7B6B4")]
	private void UpdateLine(Vector3 inkPos)
	{
	}

	[Token(Token = "0x60003BC")]
	[Address(RVA = "0xE7B8F4", Offset = "0xE7B8F4", VA = "0xE7B8F4")]
	public void ClearLines()
	{
	}

	[Token(Token = "0x60003BD")]
	[Address(RVA = "0xE7B398", Offset = "0xE7B398", VA = "0xE7B398")]
	public void UndoInkLine()
	{
	}

	[Token(Token = "0x60003BE")]
	[Address(RVA = "0xE7B9C4", Offset = "0xE7B9C4", VA = "0xE7B9C4")]
	public PassthroughBrush()
	{
	}
}
[Token(Token = "0x20000C5")]
public class PassthroughController : MonoBehaviour
{
	[Token(Token = "0x400038C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x60003BF")]
	[Address(RVA = "0xE7BA60", Offset = "0xE7BA60", VA = "0xE7BA60")]
	private void Start()
	{
	}

	[Token(Token = "0x60003C0")]
	[Address(RVA = "0xE7BBCC", Offset = "0xE7BBCC", VA = "0xE7BBCC")]
	private void Update()
	{
	}

	[Token(Token = "0x60003C1")]
	[Address(RVA = "0xE7BDB8", Offset = "0xE7BDB8", VA = "0xE7BDB8")]
	public PassthroughController()
	{
	}
}
[Token(Token = "0x20000C6")]
public class PassthroughProjectionSurface : MonoBehaviour
{
	[Token(Token = "0x400038D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x400038E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshFilter projectionObject;

	[Token(Token = "0x400038F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private MeshRenderer quadOutline;

	[Token(Token = "0x60003C2")]
	[Address(RVA = "0xE7BDC0", Offset = "0xE7BDC0", VA = "0xE7BDC0")]
	private void Start()
	{
	}

	[Token(Token = "0x60003C3")]
	[Address(RVA = "0xE7BFA8", Offset = "0xE7BFA8", VA = "0xE7BFA8")]
	private void Update()
	{
	}

	[Token(Token = "0x60003C4")]
	[Address(RVA = "0xE7C148", Offset = "0xE7C148", VA = "0xE7C148")]
	public PassthroughProjectionSurface()
	{
	}
}
[Token(Token = "0x20000C7")]
public class PassthroughStyler : MonoBehaviour
{
	[Token(Token = "0x20000C8")]
	[CompilerGenerated]
	private sealed class <FadeToCurrentStyle>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PassthroughStyler <>4__this;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fadeTime;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <timer>5__2;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <brightness>5__3;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <contrast>5__4;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Color <edgeCol>5__5;

		[Token(Token = "0x17000074")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003D6")]
			[Address(RVA = "0xE7CDAC", Offset = "0xE7CDAC", VA = "0xE7CDAC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000075")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003D8")]
			[Address(RVA = "0xE7CDF4", Offset = "0xE7CDF4", VA = "0xE7CDF4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0xE7CB14", Offset = "0xE7CB14", VA = "0xE7CB14")]
		[DebuggerHidden]
		public <FadeToCurrentStyle>d__18(int <>1__state)
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0xE7CC58", Offset = "0xE7CC58", VA = "0xE7CC58", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0xE7CC5C", Offset = "0xE7CC5C", VA = "0xE7CC5C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0xE7CDB4", Offset = "0xE7CDB4", VA = "0xE7CDB4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private sealed class <FadeToDefaultPassthrough>d__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PassthroughStyler <>4__this;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fadeTime;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <timer>5__2;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <brightness>5__3;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <contrast>5__4;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Color <edgeCol>5__5;

		[Token(Token = "0x17000076")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003DC")]
			[Address(RVA = "0xE7CF68", Offset = "0xE7CF68", VA = "0xE7CF68", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000077")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003DE")]
			[Address(RVA = "0xE7CFB0", Offset = "0xE7CFB0", VA = "0xE7CFB0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0xE7CB3C", Offset = "0xE7CB3C", VA = "0xE7CB3C")]
		[DebuggerHidden]
		public <FadeToDefaultPassthrough>d__19(int <>1__state)
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0xE7CDFC", Offset = "0xE7CDFC", VA = "0xE7CDFC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0xE7CE00", Offset = "0xE7CE00", VA = "0xE7CE00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0xE7CF70", Offset = "0xE7CF70", VA = "0xE7CF70", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000390")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRInput.Controller controllerHand;

	[Token(Token = "0x4000391")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x4000392")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private IEnumerator fadeIn;

	[Token(Token = "0x4000393")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private IEnumerator fadeOut;

	[Token(Token = "0x4000394")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public RectTransform[] menuOptions;

	[Token(Token = "0x4000395")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public RectTransform colorWheel;

	[Token(Token = "0x4000396")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Texture2D colorTexture;

	[Token(Token = "0x4000397")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3 cursorPosition;

	[Token(Token = "0x4000398")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private bool settingColor;

	[Token(Token = "0x4000399")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Color savedColor;

	[Token(Token = "0x400039A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float savedBrightness;

	[Token(Token = "0x400039B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private float savedContrast;

	[Token(Token = "0x400039C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public CanvasGroup mainCanvas;

	[Token(Token = "0x400039D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameObject[] compactObjects;

	[Token(Token = "0x60003C5")]
	[Address(RVA = "0xE7C150", Offset = "0xE7C150", VA = "0xE7C150")]
	private void Start()
	{
	}

	[Token(Token = "0x60003C6")]
	[Address(RVA = "0xE7C498", Offset = "0xE7C498", VA = "0xE7C498")]
	private void Update()
	{
	}

	[Token(Token = "0x60003C7")]
	[Address(RVA = "0xE7C838", Offset = "0xE7C838", VA = "0xE7C838")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x60003C8")]
	[Address(RVA = "0xE7C9AC", Offset = "0xE7C9AC", VA = "0xE7C9AC")]
	public void Release()
	{
	}

	[Token(Token = "0x60003C9")]
	[Address(RVA = "0xE7C928", Offset = "0xE7C928", VA = "0xE7C928")]
	[IteratorStateMachine(typeof(<FadeToCurrentStyle>d__18))]
	private IEnumerator FadeToCurrentStyle(float fadeTime)
	{
		return null;
	}

	[Token(Token = "0x60003CA")]
	[Address(RVA = "0xE7CA90", Offset = "0xE7CA90", VA = "0xE7CA90")]
	[IteratorStateMachine(typeof(<FadeToDefaultPassthrough>d__19))]
	private IEnumerator FadeToDefaultPassthrough(float fadeTime)
	{
		return null;
	}

	[Token(Token = "0x60003CB")]
	[Address(RVA = "0xE7CB64", Offset = "0xE7CB64", VA = "0xE7CB64")]
	public void OnBrightnessChanged(float newValue)
	{
	}

	[Token(Token = "0x60003CC")]
	[Address(RVA = "0xE7CB84", Offset = "0xE7CB84", VA = "0xE7CB84")]
	public void OnContrastChanged(float newValue)
	{
	}

	[Token(Token = "0x60003CD")]
	[Address(RVA = "0xE7CBA4", Offset = "0xE7CBA4", VA = "0xE7CBA4")]
	public void OnAlphaChanged(float newValue)
	{
	}

	[Token(Token = "0x60003CE")]
	[Address(RVA = "0xE7C430", Offset = "0xE7C430", VA = "0xE7C430")]
	private void ShowFullMenu(bool doShow)
	{
	}

	[Token(Token = "0x60003CF")]
	[Address(RVA = "0xE7CBD8", Offset = "0xE7CBD8", VA = "0xE7CBD8")]
	public void Cursor(Vector3 cP)
	{
	}

	[Token(Token = "0x60003D0")]
	[Address(RVA = "0xE7CBE4", Offset = "0xE7CBE4", VA = "0xE7CBE4")]
	public void DoColorDrag(bool doDrag)
	{
	}

	[Token(Token = "0x60003D1")]
	[Address(RVA = "0xE7C4B0", Offset = "0xE7C4B0", VA = "0xE7C4B0")]
	public void GetColorFromWheel()
	{
	}

	[Token(Token = "0x60003D2")]
	[Address(RVA = "0xE7CBF0", Offset = "0xE7CBF0", VA = "0xE7CBF0")]
	public PassthroughStyler()
	{
	}
}
[Token(Token = "0x20000CA")]
public class PassthroughSurface : MonoBehaviour
{
	[Token(Token = "0x40003AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x40003AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshFilter projectionObject;

	[Token(Token = "0x60003DF")]
	[Address(RVA = "0xE7CFB8", Offset = "0xE7CFB8", VA = "0xE7CFB8")]
	private void Start()
	{
	}

	[Token(Token = "0x60003E0")]
	[Address(RVA = "0xE7D06C", Offset = "0xE7D06C", VA = "0xE7D06C")]
	public PassthroughSurface()
	{
	}
}
[Token(Token = "0x20000CB")]
public class SceneSampler : MonoBehaviour
{
	[Token(Token = "0x40003B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int currentSceneIndex;

	[Token(Token = "0x40003B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject displayText;

	[Token(Token = "0x60003E1")]
	[Address(RVA = "0xE7D074", Offset = "0xE7D074", VA = "0xE7D074")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003E2")]
	[Address(RVA = "0xE7D0E0", Offset = "0xE7D0E0", VA = "0xE7D0E0")]
	private void Update()
	{
	}

	[Token(Token = "0x60003E3")]
	[Address(RVA = "0xE7D3D4", Offset = "0xE7D3D4", VA = "0xE7D3D4")]
	public SceneSampler()
	{
	}
}
[Token(Token = "0x20000CC")]
public class SelectivePassthroughExperience : MonoBehaviour
{
	[Token(Token = "0x40003B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject leftMaskObject;

	[Token(Token = "0x40003B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject rightMaskObject;

	[Token(Token = "0x60003E4")]
	[Address(RVA = "0xE7D3DC", Offset = "0xE7D3DC", VA = "0xE7D3DC")]
	private void Update()
	{
	}

	[Token(Token = "0x60003E5")]
	[Address(RVA = "0xE7D830", Offset = "0xE7D830", VA = "0xE7D830")]
	public SelectivePassthroughExperience()
	{
	}
}
[Token(Token = "0x20000CD")]
public class SPPquad : MonoBehaviour
{
	[Token(Token = "0x40003B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x40003B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshFilter projectionObject;

	[Token(Token = "0x40003B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private OVRInput.Controller controllerHand;

	[Token(Token = "0x60003E6")]
	[Address(RVA = "0xE7D838", Offset = "0xE7D838", VA = "0xE7D838")]
	private void Start()
	{
	}

	[Token(Token = "0x60003E7")]
	[Address(RVA = "0xE7DAA0", Offset = "0xE7DAA0", VA = "0xE7DAA0")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x60003E8")]
	[Address(RVA = "0xE7DAEC", Offset = "0xE7DAEC", VA = "0xE7DAEC")]
	public void Release()
	{
	}

	[Token(Token = "0x60003E9")]
	[Address(RVA = "0xE7DB2C", Offset = "0xE7DB2C", VA = "0xE7DB2C")]
	public SPPquad()
	{
	}
}
[Token(Token = "0x20000CE")]
public class BouncingBallLogic : MonoBehaviour
{
	[Token(Token = "0x20000CF")]
	[CompilerGenerated]
	private sealed class <PlayPopCallback>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float clipLength;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public BouncingBallLogic <>4__this;

		[Token(Token = "0x17000078")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003F5")]
			[Address(RVA = "0xE7E248", Offset = "0xE7E248", VA = "0xE7E248", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000079")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003F7")]
			[Address(RVA = "0xE7E290", Offset = "0xE7E290", VA = "0xE7E290", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0xE7E110", Offset = "0xE7E110", VA = "0xE7E110")]
		[DebuggerHidden]
		public <PlayPopCallback>d__18(int <>1__state)
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0xE7E150", Offset = "0xE7E150", VA = "0xE7E150", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0xE7E154", Offset = "0xE7E154", VA = "0xE7E154", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0xE7E250", Offset = "0xE7E250", VA = "0xE7E250", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40003B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float TTL;

	[Token(Token = "0x40003B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AudioClip pop;

	[Token(Token = "0x40003B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private AudioClip bounce;

	[Token(Token = "0x40003BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private AudioClip loadball;

	[Token(Token = "0x40003BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Material visibleMat;

	[Token(Token = "0x40003BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Material hiddenMat;

	[Token(Token = "0x40003BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private AudioSource audioSource;

	[Token(Token = "0x40003BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Transform centerEyeCamera;

	[Token(Token = "0x40003BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool isVisible;

	[Token(Token = "0x40003C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private float timer;

	[Token(Token = "0x40003C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool isReleased;

	[Token(Token = "0x40003C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
	private bool isReadyForDestroy;

	[Token(Token = "0x60003EA")]
	[Address(RVA = "0xE7DB34", Offset = "0xE7DB34", VA = "0xE7DB34")]
	private void OnCollisionEnter()
	{
	}

	[Token(Token = "0x60003EB")]
	[Address(RVA = "0xE7DB58", Offset = "0xE7DB58", VA = "0xE7DB58")]
	private void Start()
	{
	}

	[Token(Token = "0x60003EC")]
	[Address(RVA = "0xE7DC60", Offset = "0xE7DC60", VA = "0xE7DC60")]
	private void Update()
	{
	}

	[Token(Token = "0x60003ED")]
	[Address(RVA = "0xE7DD04", Offset = "0xE7DD04", VA = "0xE7DD04")]
	private void UpdateVisibility()
	{
	}

	[Token(Token = "0x60003EE")]
	[Address(RVA = "0xE7DF58", Offset = "0xE7DF58", VA = "0xE7DF58")]
	private void SetVisible(bool setVisible)
	{
	}

	[Token(Token = "0x60003EF")]
	[Address(RVA = "0xE7DFFC", Offset = "0xE7DFFC", VA = "0xE7DFFC")]
	public void Release(Vector3 pos, Vector3 vel, Vector3 angVel)
	{
	}

	[Token(Token = "0x60003F0")]
	[Address(RVA = "0xE7DED4", Offset = "0xE7DED4", VA = "0xE7DED4")]
	[IteratorStateMachine(typeof(<PlayPopCallback>d__18))]
	private IEnumerator PlayPopCallback(float clipLength)
	{
		return null;
	}

	[Token(Token = "0x60003F1")]
	[Address(RVA = "0xE7E138", Offset = "0xE7E138", VA = "0xE7E138")]
	public BouncingBallLogic()
	{
	}
}
[Token(Token = "0x20000D0")]
public class BouncingBallMgr : MonoBehaviour
{
	[Token(Token = "0x40003C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform trackingspace;

	[Token(Token = "0x40003C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject rightControllerPivot;

	[Token(Token = "0x40003C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private OVRInput.RawButton actionBtn;

	[Token(Token = "0x40003CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject ball;

	[Token(Token = "0x40003CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private GameObject currentBall;

	[Token(Token = "0x40003CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool ballGrabbed;

	[Token(Token = "0x60003F8")]
	[Address(RVA = "0xE7E298", Offset = "0xE7E298", VA = "0xE7E298")]
	private void Update()
	{
	}

	[Token(Token = "0x60003F9")]
	[Address(RVA = "0xE7E5A8", Offset = "0xE7E5A8", VA = "0xE7E5A8")]
	public BouncingBallMgr()
	{
	}
}
[Token(Token = "0x20000D1")]
[DefaultExecutionOrder(30)]
[RequireComponent(typeof(OVRSceneAnchor))]
public class FurnitureSpawner : MonoBehaviour
{
	[Token(Token = "0x40003CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Tooltip("Add a point at ceiling.")]
	public GameObject RoomLightPrefab;

	[Token(Token = "0x40003CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<Spawnable> SpawnablePrefabs;

	[Token(Token = "0x40003CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private OVRSceneAnchor _sceneAnchor;

	[Token(Token = "0x40003D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private OVRSemanticClassification _classification;

	[Token(Token = "0x40003D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static GameObject _roomLightRef;

	[Token(Token = "0x40003D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int _frameCounter;

	[Token(Token = "0x60003FA")]
	[Address(RVA = "0xE7E5B0", Offset = "0xE7E5B0", VA = "0xE7E5B0")]
	private void Start()
	{
	}

	[Token(Token = "0x60003FB")]
	[Address(RVA = "0xE7E7C8", Offset = "0xE7E7C8", VA = "0xE7E7C8")]
	private void SpawnSpawnable()
	{
	}

	[Token(Token = "0x60003FC")]
	[Address(RVA = "0xE7EC38", Offset = "0xE7EC38", VA = "0xE7EC38")]
	private bool FindValidSpawnable(out Spawnable currentSpawnable)
	{
		return default(bool);
	}

	[Token(Token = "0x60003FD")]
	[Address(RVA = "0xE7E650", Offset = "0xE7E650", VA = "0xE7E650")]
	private void AddRoomLight()
	{
	}

	[Token(Token = "0x60003FE")]
	[Address(RVA = "0xE7EE58", Offset = "0xE7EE58", VA = "0xE7EE58")]
	private void GetVolumeFromTopPlane(Transform plane, Vector2 dimensions, float height, out Vector3 position, out Quaternion rotation, out Vector3 localScale)
	{
	}

	[Token(Token = "0x60003FF")]
	[Address(RVA = "0xE7F344", Offset = "0xE7F344", VA = "0xE7F344")]
	public FurnitureSpawner()
	{
	}
}
[Token(Token = "0x20000D2")]
public class MyCustomSceneModelLoader : OVRSceneModelLoader
{
	[Token(Token = "0x20000D3")]
	[CompilerGenerated]
	private sealed class <DelayedLoad>d__0 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MyCustomSceneModelLoader <>4__this;

		[Token(Token = "0x1700007A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000407")]
			[Address(RVA = "0xE7F578", Offset = "0xE7F578", VA = "0xE7F578", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000409")]
			[Address(RVA = "0xE7F5C0", Offset = "0xE7F5C0", VA = "0xE7F5C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0xE7F3C0", Offset = "0xE7F3C0", VA = "0xE7F3C0")]
		[DebuggerHidden]
		public <DelayedLoad>d__0(int <>1__state)
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0xE7F478", Offset = "0xE7F478", VA = "0xE7F478", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0xE7F47C", Offset = "0xE7F47C", VA = "0xE7F47C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0xE7F580", Offset = "0xE7F580", VA = "0xE7F580", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x6000400")]
	[Address(RVA = "0xE7F34C", Offset = "0xE7F34C", VA = "0xE7F34C")]
	[IteratorStateMachine(typeof(<DelayedLoad>d__0))]
	private IEnumerator DelayedLoad()
	{
		return null;
	}

	[Token(Token = "0x6000401")]
	[Address(RVA = "0xE7F3E8", Offset = "0xE7F3E8", VA = "0xE7F3E8", Slot = "4")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x6000402")]
	[Address(RVA = "0xE7F408", Offset = "0xE7F408", VA = "0xE7F408", Slot = "6")]
	protected override void OnNoSceneModelToLoad()
	{
	}

	[Token(Token = "0x6000403")]
	[Address(RVA = "0xE7F470", Offset = "0xE7F470", VA = "0xE7F470")]
	public MyCustomSceneModelLoader()
	{
	}
}
[Token(Token = "0x20000D4")]
[RequireComponent(typeof(OVRManager))]
public class PassthroughPlayInEditor : MonoBehaviour
{
	[Token(Token = "0x600040A")]
	[Address(RVA = "0xE7F5C8", Offset = "0xE7F5C8", VA = "0xE7F5C8")]
	private void Awake()
	{
	}

	[Token(Token = "0x600040B")]
	[Address(RVA = "0xE7F5CC", Offset = "0xE7F5CC", VA = "0xE7F5CC")]
	public PassthroughPlayInEditor()
	{
	}
}
[Token(Token = "0x20000D5")]
public class RequestCaptureFlow : MonoBehaviour
{
	[Token(Token = "0x40003D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRInput.Button RequestCaptureBtn;

	[Token(Token = "0x40003D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private OVRSceneManager _sceneManager;

	[Token(Token = "0x600040C")]
	[Address(RVA = "0xE7F5D4", Offset = "0xE7F5D4", VA = "0xE7F5D4")]
	private void Start()
	{
	}

	[Token(Token = "0x600040D")]
	[Address(RVA = "0xE7F64C", Offset = "0xE7F64C", VA = "0xE7F64C")]
	private void Update()
	{
	}

	[Token(Token = "0x600040E")]
	[Address(RVA = "0xE7F6D0", Offset = "0xE7F6D0", VA = "0xE7F6D0")]
	public RequestCaptureFlow()
	{
	}
}
[Token(Token = "0x20000D6")]
[ExecuteInEditMode]
public class SimpleResizable : MonoBehaviour
{
	[Token(Token = "0x20000D7")]
	public enum Method
	{
		[Token(Token = "0x40003E7")]
		Adapt,
		[Token(Token = "0x40003E8")]
		AdaptWithAsymmetricalPadding,
		[Token(Token = "0x40003E9")]
		Scale,
		[Token(Token = "0x40003EA")]
		None
	}

	[Token(Token = "0x40003D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Space(15f)]
	public Method ScalingX;

	[Token(Token = "0x40003D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Range(0f, 0.5f)]
	public float PaddingX;

	[Token(Token = "0x40003DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Range(-0.5f, 0f)]
	public float PaddingXMax;

	[Token(Token = "0x40003DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Space(15f)]
	public Method ScalingY;

	[Token(Token = "0x40003DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Range(0f, 0.5f)]
	public float PaddingY;

	[Token(Token = "0x40003DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[Range(-0.5f, 0f)]
	public float PaddingYMax;

	[Token(Token = "0x40003DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Space(15f)]
	public Method ScalingZ;

	[Token(Token = "0x40003DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[Range(0f, 0.5f)]
	public float PaddingZ;

	[Token(Token = "0x40003E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Range(-0.5f, 0f)]
	public float PaddingZMax;

	[Token(Token = "0x40003E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Bounds _bounds;

	[Token(Token = "0x40003E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Transform _pivotTransform;

	[Token(Token = "0x1700007C")]
	public Vector3 PivotPosition
	{
		[Token(Token = "0x600040F")]
		[Address(RVA = "0xE7F6E0", Offset = "0xE7F6E0", VA = "0xE7F6E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x1700007D")]
	public Vector3 NewSize
	{
		[Token(Token = "0x6000410")]
		[Address(RVA = "0xE7F6FC", Offset = "0xE7F6FC", VA = "0xE7F6FC")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000411")]
		[Address(RVA = "0xE7F708", Offset = "0xE7F708", VA = "0xE7F708")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700007E")]
	public Vector3 DefaultSize
	{
		[Token(Token = "0x6000412")]
		[Address(RVA = "0xE7F714", Offset = "0xE7F714", VA = "0xE7F714")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000413")]
		[Address(RVA = "0xE7F720", Offset = "0xE7F720", VA = "0xE7F720")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700007F")]
	public Mesh Mesh
	{
		[Token(Token = "0x6000414")]
		[Address(RVA = "0xE7F72C", Offset = "0xE7F72C", VA = "0xE7F72C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000415")]
		[Address(RVA = "0xE7F734", Offset = "0xE7F734", VA = "0xE7F734")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6000416")]
	[Address(RVA = "0xE7F73C", Offset = "0xE7F73C", VA = "0xE7F73C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000417")]
	[Address(RVA = "0xE7F878", Offset = "0xE7F878", VA = "0xE7F878")]
	public SimpleResizable()
	{
	}
}
[Token(Token = "0x20000D8")]
public class SimpleResizer
{
	[Token(Token = "0x6000418")]
	[Address(RVA = "0xE7EFB0", Offset = "0xE7EFB0", VA = "0xE7EFB0")]
	public void CreateResizedObject(Vector3 newSize, GameObject parent, SimpleResizable sourcePrefab)
	{
	}

	[Token(Token = "0x6000419")]
	[Address(RVA = "0xE7F880", Offset = "0xE7F880", VA = "0xE7F880")]
	private Mesh ProcessVertices(SimpleResizable resizable, Vector3 newSize)
	{
		return null;
	}

	[Token(Token = "0x600041A")]
	[Address(RVA = "0xE7FB04", Offset = "0xE7FB04", VA = "0xE7FB04")]
	private float CalculateNewVertexPosition(SimpleResizable.Method resizeMethod, float currentPosition, float currentSize, float newSize, float padding, float paddingMax, float pivot)
	{
		return default(float);
	}

	[Token(Token = "0x600041B")]
	[Address(RVA = "0xE7EFA8", Offset = "0xE7EFA8", VA = "0xE7EFA8")]
	public SimpleResizer()
	{
	}
}
[Serializable]
[Token(Token = "0x20000D9")]
public class Spawnable : ISerializationCallbackReceiver
{
	[Token(Token = "0x40003EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public SimpleResizable ResizablePrefab;

	[Token(Token = "0x40003EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string ClassificationLabel;

	[Token(Token = "0x40003ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private int _editorClassificationIndex;

	[Token(Token = "0x600041C")]
	[Address(RVA = "0xE7FBAC", Offset = "0xE7FBAC", VA = "0xE7FBAC", Slot = "4")]
	public void OnBeforeSerialize()
	{
	}

	[Token(Token = "0x600041D")]
	[Address(RVA = "0xE7FBB0", Offset = "0xE7FBB0", VA = "0xE7FBB0", Slot = "5")]
	public void OnAfterDeserialize()
	{
	}

	[Token(Token = "0x600041E")]
	[Address(RVA = "0xE80018", Offset = "0xE80018", VA = "0xE80018")]
	public Spawnable()
	{
	}
}
[Token(Token = "0x20000DA")]
[RequireComponent(typeof(OVRSceneAnchor))]
public class VolumeAndPlaneSwitcher : MonoBehaviour
{
	[Token(Token = "0x20000DB")]
	public enum GeometryType
	{
		[Token(Token = "0x40003F2")]
		Plane,
		[Token(Token = "0x40003F3")]
		Volume
	}

	[Serializable]
	[Token(Token = "0x20000DC")]
	public struct LabelGeometryPair
	{
		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string label;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public GeometryType desiredGeometryType;
	}

	[Token(Token = "0x40003EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRSceneAnchor planePrefab;

	[Token(Token = "0x40003EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OVRSceneAnchor volumePrefab;

	[Token(Token = "0x40003F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<LabelGeometryPair> desiredSwitches;

	[Token(Token = "0x6000420")]
	[Address(RVA = "0xE80070", Offset = "0xE80070", VA = "0xE80070")]
	private void ReplaceAnchor(OVRSceneAnchor prefab, Vector3 position, Quaternion rotation, Vector3 localScale)
	{
	}

	[Token(Token = "0x6000421")]
	[Address(RVA = "0xE8049C", Offset = "0xE8049C", VA = "0xE8049C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000422")]
	[Address(RVA = "0xE80DD4", Offset = "0xE80DD4", VA = "0xE80DD4")]
	private void GetVolumeFromTopPlane(Transform plane, Vector2 dimensions, float height, out Vector3 position, out Quaternion rotation, out Vector3 localScale)
	{
	}

	[Token(Token = "0x6000423")]
	[Address(RVA = "0xE80CAC", Offset = "0xE80CAC", VA = "0xE80CAC")]
	private void GetTopPlaneFromVolume(Transform volume, Vector3 dimensions, out Vector3 position, out Quaternion rotation, out Vector3 localScale)
	{
	}

	[Token(Token = "0x6000424")]
	[Address(RVA = "0xE80E54", Offset = "0xE80E54", VA = "0xE80E54")]
	public VolumeAndPlaneSwitcher()
	{
	}
}
[Token(Token = "0x20000DD")]
[RequireComponent(typeof(OVRSpatialAnchor))]
public class Anchor : MonoBehaviour
{
	[Token(Token = "0x20000DE")]
	[CompilerGenerated]
	private sealed class <Start>d__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Anchor <>4__this;

		[Token(Token = "0x17000081")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000438")]
			[Address(RVA = "0xE81C1C", Offset = "0xE81C1C", VA = "0xE81C1C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000082")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600043A")]
			[Address(RVA = "0xE81C64", Offset = "0xE81C64", VA = "0xE81C64", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0xE81050", Offset = "0xE81050", VA = "0xE81050")]
		[DebuggerHidden]
		public <Start>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0xE81AA0", Offset = "0xE81AA0", VA = "0xE81AA0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0xE81AA4", Offset = "0xE81AA4", VA = "0xE81AA4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0xE81C24", Offset = "0xE81C24", VA = "0xE81C24", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40003F6")]
	public const string NumUuidsPlayerPref = "numUuids";

	[Token(Token = "0x40003F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[FormerlySerializedAs("canvas_")]
	[SerializeField]
	private Canvas _canvas;

	[Token(Token = "0x40003F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[FormerlySerializedAs("pivot_")]
	[SerializeField]
	private Transform _pivot;

	[Token(Token = "0x40003F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	[FormerlySerializedAs("anchorMenu_")]
	private GameObject _anchorMenu;

	[Token(Token = "0x40003FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool _isSelected;

	[Token(Token = "0x40003FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	private bool _isHovered;

	[Token(Token = "0x40003FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[FormerlySerializedAs("anchorName_")]
	[SerializeField]
	private TextMeshProUGUI _anchorName;

	[Token(Token = "0x40003FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[FormerlySerializedAs("saveIcon_")]
	[SerializeField]
	private GameObject _saveIcon;

	[Token(Token = "0x40003FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[FormerlySerializedAs("labelImage_")]
	[SerializeField]
	private Image _labelImage;

	[Token(Token = "0x40003FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	[FormerlySerializedAs("labelBaseColor_")]
	private Color _labelBaseColor;

	[Token(Token = "0x4000400")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	[FormerlySerializedAs("labelHighlightColor_")]
	private Color _labelHighlightColor;

	[Token(Token = "0x4000401")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	[FormerlySerializedAs("labelSelectedColor_")]
	private Color _labelSelectedColor;

	[Token(Token = "0x4000402")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	[FormerlySerializedAs("uiManager_")]
	private AnchorUIManager _uiManager;

	[Token(Token = "0x4000403")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	[FormerlySerializedAs("renderers_")]
	private MeshRenderer[] _renderers;

	[Token(Token = "0x4000404")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private int _menuIndex;

	[Token(Token = "0x4000405")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[SerializeField]
	[FormerlySerializedAs("buttonList_")]
	private List<Button> _buttonList;

	[Token(Token = "0x4000406")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Button _selectedButton;

	[Token(Token = "0x4000407")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private OVRSpatialAnchor _spatialAnchor;

	[Token(Token = "0x4000408")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private GameObject _icon;

	[Token(Token = "0x17000080")]
	public bool ShowSaveIcon
	{
		[Token(Token = "0x600042B")]
		[Address(RVA = "0xE814FC", Offset = "0xE814FC", VA = "0xE814FC")]
		set
		{
		}
	}

	[Token(Token = "0x6000425")]
	[Address(RVA = "0xE80E5C", Offset = "0xE80E5C", VA = "0xE80E5C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000426")]
	[Address(RVA = "0xE80FDC", Offset = "0xE80FDC", VA = "0xE80FDC")]
	[IteratorStateMachine(typeof(<Start>d__20))]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6000427")]
	[Address(RVA = "0xE81078", Offset = "0xE81078", VA = "0xE81078")]
	private void Update()
	{
	}

	[Token(Token = "0x6000428")]
	[Address(RVA = "0xE812F0", Offset = "0xE812F0", VA = "0xE812F0")]
	public void OnSaveLocalButtonPressed()
	{
	}

	[Token(Token = "0x6000429")]
	[Address(RVA = "0xE813C0", Offset = "0xE813C0", VA = "0xE813C0")]
	public void OnHideButtonPressed()
	{
	}

	[Token(Token = "0x600042A")]
	[Address(RVA = "0xE8142C", Offset = "0xE8142C", VA = "0xE8142C")]
	public void OnEraseButtonPressed()
	{
	}

	[Token(Token = "0x600042C")]
	[Address(RVA = "0xE8151C", Offset = "0xE8151C", VA = "0xE8151C")]
	public void OnHoverStart()
	{
	}

	[Token(Token = "0x600042D")]
	[Address(RVA = "0xE81638", Offset = "0xE81638", VA = "0xE81638")]
	public void OnHoverEnd()
	{
	}

	[Token(Token = "0x600042E")]
	[Address(RVA = "0xE81740", Offset = "0xE81740", VA = "0xE81740")]
	public void OnSelect()
	{
	}

	[Token(Token = "0x600042F")]
	[Address(RVA = "0xE810C8", Offset = "0xE810C8", VA = "0xE810C8")]
	private void BillboardPanel(Transform panel)
	{
	}

	[Token(Token = "0x6000430")]
	[Address(RVA = "0xE811FC", Offset = "0xE811FC", VA = "0xE811FC")]
	private void HandleMenuNavigation()
	{
	}

	[Token(Token = "0x6000431")]
	[Address(RVA = "0xE81810", Offset = "0xE81810", VA = "0xE81810")]
	private void NavigateToIndexInMenu(bool moveNext)
	{
	}

	[Token(Token = "0x6000432")]
	[Address(RVA = "0xE81948", Offset = "0xE81948", VA = "0xE81948")]
	public Anchor()
	{
	}
}
[Token(Token = "0x20000DF")]
[RequireComponent(typeof(SpatialAnchorLoader))]
public class AnchorUIManager : MonoBehaviour
{
	[Token(Token = "0x20000E0")]
	public enum AnchorMode
	{
		[Token(Token = "0x400041F")]
		Create,
		[Token(Token = "0x4000420")]
		Select
	}

	[Token(Token = "0x20000E1")]
	private delegate void PrimaryPressDelegate();

	[Token(Token = "0x400040C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static AnchorUIManager Instance;

	[Token(Token = "0x400040D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	[FormerlySerializedAs("createModeButton_")]
	private GameObject _createModeButton;

	[Token(Token = "0x400040E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	[FormerlySerializedAs("selectModeButton_")]
	private GameObject _selectModeButton;

	[Token(Token = "0x400040F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[FormerlySerializedAs("trackedDevice_")]
	[SerializeField]
	private Transform _trackedDevice;

	[Token(Token = "0x4000410")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Transform _raycastOrigin;

	[Token(Token = "0x4000411")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool _drawRaycast;

	[Token(Token = "0x4000412")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	[FormerlySerializedAs("lineRenderer_")]
	private LineRenderer _lineRenderer;

	[Token(Token = "0x4000413")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Anchor _hoveredAnchor;

	[Token(Token = "0x4000414")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Anchor _selectedAnchor;

	[Token(Token = "0x4000415")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private AnchorMode _mode;

	[Token(Token = "0x4000416")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	[FormerlySerializedAs("buttonList_")]
	private List<Button> _buttonList;

	[Token(Token = "0x4000417")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int _menuIndex;

	[Token(Token = "0x4000418")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Button _selectedButton;

	[Token(Token = "0x4000419")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Anchor _anchorPrefab;

	[Token(Token = "0x400041A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[FormerlySerializedAs("placementPreview_")]
	[SerializeField]
	private GameObject _placementPreview;

	[Token(Token = "0x400041B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[FormerlySerializedAs("anchorPlacementTransform_")]
	[SerializeField]
	private Transform _anchorPlacementTransform;

	[Token(Token = "0x400041C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private PrimaryPressDelegate _primaryPressDelegate;

	[Token(Token = "0x400041D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private bool _isFocused;

	[Token(Token = "0x17000083")]
	public Anchor AnchorPrefab
	{
		[Token(Token = "0x600043B")]
		[Address(RVA = "0xE81C6C", Offset = "0xE81C6C", VA = "0xE81C6C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600043C")]
	[Address(RVA = "0xE81C74", Offset = "0xE81C74", VA = "0xE81C74")]
	private void Awake()
	{
	}

	[Token(Token = "0x600043D")]
	[Address(RVA = "0xE81D40", Offset = "0xE81D40", VA = "0xE81D40")]
	private void Start()
	{
	}

	[Token(Token = "0x600043E")]
	[Address(RVA = "0xE81E90", Offset = "0xE81E90", VA = "0xE81E90")]
	private void Update()
	{
	}

	[Token(Token = "0x600043F")]
	[Address(RVA = "0xE82300", Offset = "0xE82300", VA = "0xE82300")]
	public void OnCreateModeButtonPressed()
	{
	}

	[Token(Token = "0x6000440")]
	[Address(RVA = "0xE8236C", Offset = "0xE8236C", VA = "0xE8236C")]
	public void OnLoadAnchorsButtonPressed()
	{
	}

	[Token(Token = "0x6000441")]
	[Address(RVA = "0xE81E28", Offset = "0xE81E28", VA = "0xE81E28")]
	private void ToggleCreateMode()
	{
	}

	[Token(Token = "0x6000442")]
	[Address(RVA = "0xE825F4", Offset = "0xE825F4", VA = "0xE825F4")]
	private void StartPlacementMode()
	{
	}

	[Token(Token = "0x6000443")]
	[Address(RVA = "0xE8267C", Offset = "0xE8267C", VA = "0xE8267C")]
	private void EndPlacementMode()
	{
	}

	[Token(Token = "0x6000444")]
	[Address(RVA = "0xE8269C", Offset = "0xE8269C", VA = "0xE8269C")]
	private void StartSelectMode()
	{
	}

	[Token(Token = "0x6000445")]
	[Address(RVA = "0xE825D4", Offset = "0xE825D4", VA = "0xE825D4")]
	private void EndSelectMode()
	{
	}

	[Token(Token = "0x6000446")]
	[Address(RVA = "0xE8220C", Offset = "0xE8220C", VA = "0xE8220C")]
	private void HandleMenuNavigation()
	{
	}

	[Token(Token = "0x6000447")]
	[Address(RVA = "0xE8289C", Offset = "0xE8289C", VA = "0xE8289C")]
	private void NavigateToIndexInMenu(bool moveNext)
	{
	}

	[Token(Token = "0x6000448")]
	[Address(RVA = "0xE82724", Offset = "0xE82724", VA = "0xE82724")]
	private void ShowAnchorPreview()
	{
	}

	[Token(Token = "0x6000449")]
	[Address(RVA = "0xE82810", Offset = "0xE82810", VA = "0xE82810")]
	private void HideAnchorPreview()
	{
	}

	[Token(Token = "0x600044A")]
	[Address(RVA = "0xE8299C", Offset = "0xE8299C", VA = "0xE8299C")]
	private void PlaceAnchor()
	{
	}

	[Token(Token = "0x600044B")]
	[Address(RVA = "0xE82830", Offset = "0xE82830", VA = "0xE82830")]
	private void ShowRaycastLine()
	{
	}

	[Token(Token = "0x600044C")]
	[Address(RVA = "0xE82868", Offset = "0xE82868", VA = "0xE82868")]
	private void HideRaycastLine()
	{
	}

	[Token(Token = "0x600044D")]
	[Address(RVA = "0xE81F90", Offset = "0xE81F90", VA = "0xE81F90")]
	private void ControllerRaycast()
	{
	}

	[Token(Token = "0x600044E")]
	[Address(RVA = "0xE82A88", Offset = "0xE82A88", VA = "0xE82A88")]
	private void HoverAnchor(Anchor anchor)
	{
	}

	[Token(Token = "0x600044F")]
	[Address(RVA = "0xE82AB0", Offset = "0xE82AB0", VA = "0xE82AB0")]
	private void UnhoverAnchor()
	{
	}

	[Token(Token = "0x6000450")]
	[Address(RVA = "0xE82B40", Offset = "0xE82B40", VA = "0xE82B40")]
	private void SelectAnchor()
	{
	}

	[Token(Token = "0x6000451")]
	[Address(RVA = "0xE82C88", Offset = "0xE82C88", VA = "0xE82C88")]
	public AnchorUIManager()
	{
	}
}
[Token(Token = "0x20000E2")]
public class SpatialAnchorLoader : MonoBehaviour
{
	[Token(Token = "0x4000421")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private OVRSpatialAnchor _anchorPrefab;

	[Token(Token = "0x4000422")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Action<OVRSpatialAnchor.UnboundAnchor, bool> _onLoadAnchor;

	[Token(Token = "0x6000456")]
	[Address(RVA = "0xE823C0", Offset = "0xE823C0", VA = "0xE823C0")]
	public void LoadAnchorsByUuid()
	{
	}

	[Token(Token = "0x6000457")]
	[Address(RVA = "0xE82E44", Offset = "0xE82E44", VA = "0xE82E44")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000458")]
	[Address(RVA = "0xE82D64", Offset = "0xE82D64", VA = "0xE82D64")]
	private void Load(OVRSpatialAnchor.LoadOptions options)
	{
	}

	[Token(Token = "0x6000459")]
	[Address(RVA = "0xE82EC8", Offset = "0xE82EC8", VA = "0xE82EC8")]
	private void OnLocalized(OVRSpatialAnchor.UnboundAnchor unboundAnchor, bool success)
	{
	}

	[Token(Token = "0x600045A")]
	[Address(RVA = "0xE82CD8", Offset = "0xE82CD8", VA = "0xE82CD8")]
	private static void Log(string message)
	{
	}

	[Token(Token = "0x600045B")]
	[Address(RVA = "0xE83078", Offset = "0xE83078", VA = "0xE83078")]
	public SpatialAnchorLoader()
	{
	}
}
[Token(Token = "0x20000E3")]
public class StartMenu : MonoBehaviour
{
	[Token(Token = "0x4000423")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVROverlay overlay;

	[Token(Token = "0x4000424")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OVROverlay text;

	[Token(Token = "0x4000425")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OVRCameraRig vrRig;

	[Token(Token = "0x600045D")]
	[Address(RVA = "0xE831B0", Offset = "0xE831B0", VA = "0xE831B0")]
	private void Start()
	{
	}

	[Token(Token = "0x600045E")]
	[Address(RVA = "0xE833C4", Offset = "0xE833C4", VA = "0xE833C4")]
	private void LoadScene(int idx)
	{
	}

	[Token(Token = "0x600045F")]
	[Address(RVA = "0xE834C8", Offset = "0xE834C8", VA = "0xE834C8")]
	public StartMenu()
	{
	}
}
[Token(Token = "0x20000E5")]
public class LocalizedHaptics : MonoBehaviour
{
	[Token(Token = "0x4000428")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("Settings")]
	[SerializeField]
	private OVRInput.Handedness m_handedness;

	[Token(Token = "0x4000429")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private OVRInput.Controller m_controller;

	[Token(Token = "0x6000462")]
	[Address(RVA = "0xE834EC", Offset = "0xE834EC", VA = "0xE834EC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000463")]
	[Address(RVA = "0xE83514", Offset = "0xE83514", VA = "0xE83514")]
	private void Update()
	{
	}

	[Token(Token = "0x6000464")]
	[Address(RVA = "0xE83650", Offset = "0xE83650", VA = "0xE83650")]
	public LocalizedHaptics()
	{
	}
}
[Token(Token = "0x20000E6")]
public class SceneSettings : MonoBehaviour
{
	[Token(Token = "0x400042A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Header("Time")]
	private float m_fixedTimeStep;

	[Token(Token = "0x400042B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Header("Physics")]
	[SerializeField]
	private float m_gravityScalar;

	[Token(Token = "0x400042C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float m_defaultContactOffset;

	[Token(Token = "0x6000465")]
	[Address(RVA = "0xE83660", Offset = "0xE83660", VA = "0xE83660")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000466")]
	[Address(RVA = "0xE836F8", Offset = "0xE836F8", VA = "0xE836F8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000467")]
	[Address(RVA = "0xE83700", Offset = "0xE83700", VA = "0xE83700")]
	private static void CollidersSetContactOffset(float contactOffset)
	{
	}

	[Token(Token = "0x6000468")]
	[Address(RVA = "0xE837C4", Offset = "0xE837C4", VA = "0xE837C4")]
	public SceneSettings()
	{
	}
}
[Token(Token = "0x20000E7")]
public class StylusTip : MonoBehaviour
{
	[Token(Token = "0x400042D")]
	private const int MaxBreadCrumbs = 60;

	[Token(Token = "0x400042E")]
	private const float BreadCrumbMinSize = 0.005f;

	[Token(Token = "0x400042F")]
	private const float BreadCrumbMaxSize = 0.02f;

	[Token(Token = "0x4000430")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("External")]
	[SerializeField]
	private Transform m_trackingSpace;

	[Token(Token = "0x4000431")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Header("Settings")]
	[SerializeField]
	private OVRInput.Handedness m_handedness;

	[Token(Token = "0x4000432")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject m_breadCrumbPf;

	[Token(Token = "0x4000433")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GameObject m_breadCrumbContainer;

	[Token(Token = "0x4000434")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private GameObject[] m_breadCrumbs;

	[Token(Token = "0x4000435")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private int m_breadCrumbIndexPrev;

	[Token(Token = "0x4000436")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private int m_breadCrumbIndexCurr;

	[Token(Token = "0x4000437")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private OVRInput.Controller m_controller;

	[Token(Token = "0x6000469")]
	[Address(RVA = "0xE837E4", Offset = "0xE837E4", VA = "0xE837E4")]
	private void Awake()
	{
	}

	[Token(Token = "0x600046A")]
	[Address(RVA = "0xE83A64", Offset = "0xE83A64", VA = "0xE83A64")]
	private void Update()
	{
	}

	[Token(Token = "0x600046B")]
	[Address(RVA = "0xE83E94", Offset = "0xE83E94", VA = "0xE83E94")]
	private static Pose GetT_Device_StylusTip(OVRInput.Controller controller)
	{
		return default(Pose);
	}

	[Token(Token = "0x600046C")]
	[Address(RVA = "0xE83FC0", Offset = "0xE83FC0", VA = "0xE83FC0")]
	public StylusTip()
	{
	}
}
[Token(Token = "0x20000E8")]
public class UiAxis1dInspector : MonoBehaviour
{
	[Token(Token = "0x4000438")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("Settings")]
	[SerializeField]
	private float m_minExtent;

	[Token(Token = "0x4000439")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float m_maxExtent;

	[Token(Token = "0x400043A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Header("Components")]
	private TextMeshProUGUI m_nameLabel;

	[Token(Token = "0x400043B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private TextMeshProUGUI m_valueLabel;

	[Token(Token = "0x400043C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Slider m_slider;

	[Token(Token = "0x600046D")]
	[Address(RVA = "0xE83FD8", Offset = "0xE83FD8", VA = "0xE83FD8")]
	public void SetExtents(float minExtent, float maxExtent)
	{
	}

	[Token(Token = "0x600046E")]
	[Address(RVA = "0xE83FE0", Offset = "0xE83FE0", VA = "0xE83FE0")]
	public void SetName(string name)
	{
	}

	[Token(Token = "0x600046F")]
	[Address(RVA = "0xE84004", Offset = "0xE84004", VA = "0xE84004")]
	public void SetValue(float value)
	{
	}

	[Token(Token = "0x6000470")]
	[Address(RVA = "0xE84108", Offset = "0xE84108", VA = "0xE84108")]
	public UiAxis1dInspector()
	{
	}
}
[Token(Token = "0x20000E9")]
public class UiAxis2dInspector : MonoBehaviour
{
	[Token(Token = "0x400043D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("Settings")]
	[SerializeField]
	private Vector2 m_xExtent;

	[Token(Token = "0x400043E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Vector2 m_yExtent;

	[Token(Token = "0x400043F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Header("Components")]
	[SerializeField]
	private TextMeshProUGUI m_nameLabel;

	[Token(Token = "0x4000440")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private TextMeshProUGUI m_valueLabel;

	[Token(Token = "0x4000441")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Image m_handle;

	[Token(Token = "0x6000471")]
	[Address(RVA = "0xE84118", Offset = "0xE84118", VA = "0xE84118")]
	public void SetExtents(Vector2 xExtent, Vector2 yExtent)
	{
	}

	[Token(Token = "0x6000472")]
	[Address(RVA = "0xE84124", Offset = "0xE84124", VA = "0xE84124")]
	public void SetName(string name)
	{
	}

	[Token(Token = "0x6000473")]
	[Address(RVA = "0xE84148", Offset = "0xE84148", VA = "0xE84148")]
	public void SetValue(bool isTouching, Vector2 value)
	{
	}

	[Token(Token = "0x6000474")]
	[Address(RVA = "0xE84510", Offset = "0xE84510", VA = "0xE84510")]
	public UiAxis2dInspector()
	{
	}
}
[Token(Token = "0x20000EA")]
public class UiBoolInspector : MonoBehaviour
{
	[Token(Token = "0x4000442")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("Components")]
	[SerializeField]
	private TextMeshProUGUI m_nameLabel;

	[Token(Token = "0x4000443")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Toggle m_toggle;

	[Token(Token = "0x6000475")]
	[Address(RVA = "0xE84524", Offset = "0xE84524", VA = "0xE84524")]
	public void SetName(string name)
	{
	}

	[Token(Token = "0x6000476")]
	[Address(RVA = "0xE84548", Offset = "0xE84548", VA = "0xE84548")]
	public void SetValue(bool value)
	{
	}

	[Token(Token = "0x6000477")]
	[Address(RVA = "0xE84568", Offset = "0xE84568", VA = "0xE84568")]
	public UiBoolInspector()
	{
	}
}
[Token(Token = "0x20000EB")]
public class UiDeviceInspector : MonoBehaviour
{
	[Token(Token = "0x4000444")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("Settings")]
	[SerializeField]
	private OVRInput.Handedness m_handedness;

	[Token(Token = "0x4000445")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Header("Left Column Components")]
	private TextMeshProUGUI m_title;

	[Token(Token = "0x4000446")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private TextMeshProUGUI m_status;

	[Token(Token = "0x4000447")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private UiBoolInspector m_thumbRestTouch;

	[Token(Token = "0x4000448")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private UiAxis1dInspector m_thumbRestForce;

	[Token(Token = "0x4000449")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private UiAxis1dInspector m_indexTrigger;

	[Token(Token = "0x400044A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private UiAxis1dInspector m_gripTrigger;

	[Token(Token = "0x400044B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private UiAxis1dInspector m_stylusTipForce;

	[Token(Token = "0x400044C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private UiAxis1dInspector m_indexCurl1d;

	[Token(Token = "0x400044D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private UiAxis1dInspector m_indexSlider1d;

	[Token(Token = "0x400044E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[Header("Right Column Components")]
	[SerializeField]
	private UiBoolInspector m_ax;

	[Token(Token = "0x400044F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private UiBoolInspector m_axTouch;

	[Token(Token = "0x4000450")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private UiBoolInspector m_by;

	[Token(Token = "0x4000451")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private UiBoolInspector m_byTouch;

	[Token(Token = "0x4000452")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private UiBoolInspector m_indexTouch;

	[Token(Token = "0x4000453")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	private UiAxis2dInspector m_thumbstick;

	[Token(Token = "0x4000454")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private OVRInput.Controller m_controller;

	[Token(Token = "0x6000478")]
	[Address(RVA = "0xE84570", Offset = "0xE84570", VA = "0xE84570")]
	private void Start()
	{
	}

	[Token(Token = "0x6000479")]
	[Address(RVA = "0xE84598", Offset = "0xE84598", VA = "0xE84598")]
	private void Update()
	{
	}

	[Token(Token = "0x600047A")]
	[Address(RVA = "0xE84B20", Offset = "0xE84B20", VA = "0xE84B20")]
	private static string ToDeviceModel()
	{
		return null;
	}

	[Token(Token = "0x600047B")]
	[Address(RVA = "0xE84B60", Offset = "0xE84B60", VA = "0xE84B60")]
	private static string ToHandednessString(OVRInput.Handedness handedness)
	{
		return null;
	}

	[Token(Token = "0x600047C")]
	[Address(RVA = "0xE84BE4", Offset = "0xE84BE4", VA = "0xE84BE4")]
	public UiDeviceInspector()
	{
	}
}
[Token(Token = "0x20000EC")]
public class UiSceneMenu : MonoBehaviour
{
	[Token(Token = "0x4000455")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("Settings")]
	[SerializeField]
	private VerticalLayoutGroup m_layoutGroup;

	[Token(Token = "0x4000456")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private TextMeshProUGUI m_labelPf;

	[Token(Token = "0x4000457")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Vector2 s_lastThumbstickL;

	[Token(Token = "0x4000458")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Vector2 s_lastThumbstickR;

	[Token(Token = "0x4000459")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Scene m_activeScene;

	[Token(Token = "0x600047D")]
	[Address(RVA = "0xE84BF4", Offset = "0xE84BF4", VA = "0xE84BF4")]
	private void Awake()
	{
	}

	[Token(Token = "0x600047E")]
	[Address(RVA = "0xE84EC0", Offset = "0xE84EC0", VA = "0xE84EC0")]
	private void Update()
	{
	}

	[Token(Token = "0x600047F")]
	[Address(RVA = "0xE84FD8", Offset = "0xE84FD8", VA = "0xE84FD8")]
	private bool InputPrevScene()
	{
		return default(bool);
	}

	[Token(Token = "0x6000480")]
	[Address(RVA = "0xE85074", Offset = "0xE85074", VA = "0xE85074")]
	private bool InputNextScene()
	{
		return default(bool);
	}

	[Token(Token = "0x6000481")]
	[Address(RVA = "0xE850B8", Offset = "0xE850B8", VA = "0xE850B8")]
	private bool KeyboardPrevScene()
	{
		return default(bool);
	}

	[Token(Token = "0x6000482")]
	[Address(RVA = "0xE85154", Offset = "0xE85154", VA = "0xE85154")]
	private bool KeyboardNextScene()
	{
		return default(bool);
	}

	[Token(Token = "0x6000483")]
	[Address(RVA = "0xE850C4", Offset = "0xE850C4", VA = "0xE850C4")]
	private bool ThumbstickPrevScene(OVRInput.Controller controller)
	{
		return default(bool);
	}

	[Token(Token = "0x6000484")]
	[Address(RVA = "0xE85160", Offset = "0xE85160", VA = "0xE85160")]
	private bool ThumbstickNextScene(OVRInput.Controller controller)
	{
		return default(bool);
	}

	[Token(Token = "0x6000485")]
	[Address(RVA = "0xE851F0", Offset = "0xE851F0", VA = "0xE851F0")]
	private Vector2 GetLastThumbstickValue(OVRInput.Controller controller)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000486")]
	[Address(RVA = "0xE8501C", Offset = "0xE8501C", VA = "0xE8501C")]
	private void ChangeScene(int nextScene)
	{
	}

	[Token(Token = "0x6000487")]
	[Address(RVA = "0xE84C98", Offset = "0xE84C98", VA = "0xE84C98")]
	private void CreateLabel(int sceneIndex, string scenePath)
	{
	}

	[Token(Token = "0x6000488")]
	[Address(RVA = "0xE85258", Offset = "0xE85258", VA = "0xE85258")]
	public UiSceneMenu()
	{
	}
}
[Token(Token = "0x20000ED")]
public class UiVectorInspector : MonoBehaviour
{
	[Token(Token = "0x400045A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("Components")]
	[SerializeField]
	private TextMeshProUGUI m_nameLabel;

	[Token(Token = "0x400045B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private TextMeshProUGUI m_valueLabel;

	[Token(Token = "0x6000489")]
	[Address(RVA = "0xE85260", Offset = "0xE85260", VA = "0xE85260")]
	public void SetName(string name)
	{
	}

	[Token(Token = "0x600048A")]
	[Address(RVA = "0xE85284", Offset = "0xE85284", VA = "0xE85284")]
	public void SetValue(bool value)
	{
	}

	[Token(Token = "0x600048B")]
	[Address(RVA = "0xE85334", Offset = "0xE85334", VA = "0xE85334")]
	public UiVectorInspector()
	{
	}
}
[Token(Token = "0x20000EE")]
public class OculusSpatializerFMOD : MonoBehaviour
{
	[Token(Token = "0x20000EF")]
	public delegate void AudioRaycastCallback(Vector3 origin, Vector3 direction, out Vector3 point, out Vector3 normal, IntPtr data);

	[Token(Token = "0x400045C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public LayerMask layerMask;

	[Token(Token = "0x400045D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool visualizeRoom;

	[Token(Token = "0x400045E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	private bool roomVisualizationInitialized;

	[Token(Token = "0x400045F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int raysPerSecond;

	[Token(Token = "0x4000460")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float roomInterpSpeed;

	[Token(Token = "0x4000461")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float maxWallDistance;

	[Token(Token = "0x4000462")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int rayCacheSize;

	[Token(Token = "0x4000463")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool dynamicReflectionsEnabled;

	[Token(Token = "0x4000464")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private AudioRaycastCallback _raycastCallback;

	[Token(Token = "0x4000465")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float particleSize;

	[Token(Token = "0x4000466")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float particleOffset;

	[Token(Token = "0x4000467")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private GameObject room;

	[Token(Token = "0x4000468")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Renderer[] wallRenderer;

	[Token(Token = "0x4000469")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float[] dims;

	[Token(Token = "0x400046A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float[] coefs;

	[Token(Token = "0x400046B")]
	private const int HIT_COUNT = 2048;

	[Token(Token = "0x400046C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Vector3[] points;

	[Token(Token = "0x400046D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Vector3[] normals;

	[Token(Token = "0x400046E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private ParticleSystem sys;

	[Token(Token = "0x400046F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private ParticleSystem.Particle[] particles;

	[Token(Token = "0x4000470")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static LayerMask gLayerMask;

	[Token(Token = "0x4000471")]
	private const string strOSP = "OculusSpatializerFMOD";

	[Token(Token = "0x600048C")]
	[Address(RVA = "0xE8533C", Offset = "0xE8533C", VA = "0xE8533C")]
	private static Vector3 swapHandedness(Vector3 vec)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600048D")]
	[Address(RVA = "0xE85344", Offset = "0xE85344", VA = "0xE85344")]
	private static void AudioRaycast(Vector3 origin, Vector3 direction, out Vector3 point, out Vector3 normal, IntPtr data)
	{
	}

	[Token(Token = "0x600048E")]
	[Address(RVA = "0xE854D4", Offset = "0xE854D4", VA = "0xE854D4")]
	private void Start()
	{
	}

	[Token(Token = "0x600048F")]
	[Address(RVA = "0xE85628", Offset = "0xE85628", VA = "0xE85628")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000490")]
	[Address(RVA = "0xE85720", Offset = "0xE85720", VA = "0xE85720")]
	private void Update()
	{
	}

	[Token(Token = "0x6000491")]
	[Address(RVA = "0xE8608C", Offset = "0xE8608C", VA = "0xE8608C")]
	private void inititalizeRoomVisualization()
	{
	}

	[PreserveSig]
	[Token(Token = "0x6000492")]
	[Address(RVA = "0xE8569C", Offset = "0xE8569C", VA = "0xE8569C")]
	private static extern int OSP_FMOD_AssignRayCastCallback(IntPtr callback, IntPtr data);

	[PreserveSig]
	[Token(Token = "0x6000493")]
	[Address(RVA = "0xE85E20", Offset = "0xE85E20", VA = "0xE85E20")]
	private static extern int OSP_FMOD_SetDynamicRoomRaysPerSecond(int RaysPerSecond);

	[PreserveSig]
	[Token(Token = "0x6000494")]
	[Address(RVA = "0xE85E9C", Offset = "0xE85E9C", VA = "0xE85E9C")]
	private static extern int OSP_FMOD_SetDynamicRoomInterpSpeed(float InterpSpeed);

	[PreserveSig]
	[Token(Token = "0x6000495")]
	[Address(RVA = "0xE85F18", Offset = "0xE85F18", VA = "0xE85F18")]
	private static extern int OSP_FMOD_SetDynamicRoomMaxWallDistance(float MaxWallDistance);

	[PreserveSig]
	[Token(Token = "0x6000496")]
	[Address(RVA = "0xE85F94", Offset = "0xE85F94", VA = "0xE85F94")]
	private static extern int OSP_FMOD_SetDynamicRoomRaysRayCacheSize(int RayCacheSize);

	[PreserveSig]
	[Token(Token = "0x6000497")]
	[Address(RVA = "0xE86010", Offset = "0xE86010", VA = "0xE86010")]
	private static extern int OSP_FMOD_UpdateRoomModel(float wetLevel);

	[PreserveSig]
	[Token(Token = "0x6000498")]
	[Address(RVA = "0xE86E14", Offset = "0xE86E14", VA = "0xE86E14")]
	private static extern int OSP_FMOD_GetRoomDimensions(float[] roomDimensions, float[] reflectionsCoefs, out Vector3 position);

	[PreserveSig]
	[Token(Token = "0x6000499")]
	[Address(RVA = "0xE86EB8", Offset = "0xE86EB8", VA = "0xE86EB8")]
	private static extern int OSP_FMOD_GetRaycastHits(Vector3[] points, Vector3[] normals, int length);

	[Token(Token = "0x600049A")]
	[Address(RVA = "0xE86F5C", Offset = "0xE86F5C", VA = "0xE86F5C")]
	public OculusSpatializerFMOD()
	{
	}
}
[Token(Token = "0x20000F0")]
public static class EmptySprite
{
	[Token(Token = "0x4000472")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Sprite instance;

	[Token(Token = "0x60004A0")]
	[Address(RVA = "0xE87298", Offset = "0xE87298", VA = "0xE87298")]
	public static Sprite Get()
	{
		return null;
	}

	[Token(Token = "0x60004A1")]
	[Address(RVA = "0xE87374", Offset = "0xE87374", VA = "0xE87374")]
	public static bool IsEmptySprite(Sprite s)
	{
		return default(bool);
	}
}
[Token(Token = "0x20000F1")]
[ModifierID("Free")]
public class FreeModifier : ProceduralImageModifier
{
	[Token(Token = "0x4000473")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Vector4 radius;

	[Token(Token = "0x17000084")]
	public Vector4 Radius
	{
		[Token(Token = "0x60004A2")]
		[Address(RVA = "0xE873DC", Offset = "0xE873DC", VA = "0xE873DC")]
		get
		{
			return default(Vector4);
		}
		[Token(Token = "0x60004A3")]
		[Address(RVA = "0xE873E8", Offset = "0xE873E8", VA = "0xE873E8")]
		set
		{
		}
	}

	[Token(Token = "0x60004A4")]
	[Address(RVA = "0xE874BC", Offset = "0xE874BC", VA = "0xE874BC", Slot = "4")]
	public override Vector4 CalculateRadius(Rect imageRect)
	{
		return default(Vector4);
	}

	[Token(Token = "0x60004A5")]
	[Address(RVA = "0xE874C8", Offset = "0xE874C8", VA = "0xE874C8")]
	protected void OnValidate()
	{
	}

	[Token(Token = "0x60004A6")]
	[Address(RVA = "0xE874F0", Offset = "0xE874F0", VA = "0xE874F0")]
	public FreeModifier()
	{
	}
}
[Token(Token = "0x20000F2")]
[ModifierID("Only One Edge")]
public class OnlyOneEdgeModifier : ProceduralImageModifier
{
	[Token(Token = "0x20000F3")]
	public enum ProceduralImageEdge
	{
		[Token(Token = "0x4000477")]
		Top,
		[Token(Token = "0x4000478")]
		Bottom,
		[Token(Token = "0x4000479")]
		Left,
		[Token(Token = "0x400047A")]
		Right
	}

	[Token(Token = "0x4000474")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float radius;

	[Token(Token = "0x4000475")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[SerializeField]
	private ProceduralImageEdge side;

	[Token(Token = "0x17000085")]
	public float Radius
	{
		[Token(Token = "0x60004A7")]
		[Address(RVA = "0xE87500", Offset = "0xE87500", VA = "0xE87500")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60004A8")]
		[Address(RVA = "0xE87508", Offset = "0xE87508", VA = "0xE87508")]
		set
		{
		}
	}

	[Token(Token = "0x17000086")]
	public ProceduralImageEdge Side
	{
		[Token(Token = "0x60004A9")]
		[Address(RVA = "0xE87530", Offset = "0xE87530", VA = "0xE87530")]
		get
		{
			return default(ProceduralImageEdge);
		}
		[Token(Token = "0x60004AA")]
		[Address(RVA = "0xE87538", Offset = "0xE87538", VA = "0xE87538")]
		set
		{
		}
	}

	[Token(Token = "0x60004AB")]
	[Address(RVA = "0xE87540", Offset = "0xE87540", VA = "0xE87540", Slot = "4")]
	public override Vector4 CalculateRadius(Rect imageRect)
	{
		return default(Vector4);
	}

	[Token(Token = "0x60004AC")]
	[Address(RVA = "0xE875C0", Offset = "0xE875C0", VA = "0xE875C0")]
	public OnlyOneEdgeModifier()
	{
	}
}
[Token(Token = "0x20000F4")]
[ModifierID("Round")]
public class RoundModifier : ProceduralImageModifier
{
	[Token(Token = "0x60004AD")]
	[Address(RVA = "0xE875C8", Offset = "0xE875C8", VA = "0xE875C8", Slot = "4")]
	public override Vector4 CalculateRadius(Rect imageRect)
	{
		return default(Vector4);
	}

	[Token(Token = "0x60004AE")]
	[Address(RVA = "0xE87624", Offset = "0xE87624", VA = "0xE87624")]
	public RoundModifier()
	{
	}
}
[Token(Token = "0x20000F5")]
[ModifierID("Uniform")]
public class UniformModifier : ProceduralImageModifier
{
	[Token(Token = "0x400047B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float radius;

	[Token(Token = "0x17000087")]
	public float Radius
	{
		[Token(Token = "0x60004AF")]
		[Address(RVA = "0xE8762C", Offset = "0xE8762C", VA = "0xE8762C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60004B0")]
		[Address(RVA = "0xE87634", Offset = "0xE87634", VA = "0xE87634")]
		set
		{
		}
	}

	[Token(Token = "0x60004B1")]
	[Address(RVA = "0xE8765C", Offset = "0xE8765C", VA = "0xE8765C", Slot = "4")]
	public override Vector4 CalculateRadius(Rect imageRect)
	{
		return default(Vector4);
	}

	[Token(Token = "0x60004B2")]
	[Address(RVA = "0xE87670", Offset = "0xE87670", VA = "0xE87670")]
	public UniformModifier()
	{
	}
}
[Token(Token = "0x20000F6")]
public class Readme : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x20000F7")]
	public class Section
	{
		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string heading;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string text;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string linkText;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string url;

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0xE87680", Offset = "0xE87680", VA = "0xE87680")]
		public Section()
		{
		}
	}

	[Token(Token = "0x400047C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Texture2D icon;

	[Token(Token = "0x400047D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string title;

	[Token(Token = "0x400047E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Section[] sections;

	[Token(Token = "0x400047F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool loadedLayout;

	[Token(Token = "0x60004B3")]
	[Address(RVA = "0xE87678", Offset = "0xE87678", VA = "0xE87678")]
	public Readme()
	{
	}
}
namespace UnityEngine.UI.ProceduralImage
{
	[Token(Token = "0x20000F8")]
	[AttributeUsage(AttributeTargets.Class)]
	public class ModifierID : Attribute
	{
		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string name;

		[Token(Token = "0x17000088")]
		public string Name
		{
			[Token(Token = "0x60004B6")]
			[Address(RVA = "0xE876B8", Offset = "0xE876B8", VA = "0xE876B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0xE87688", Offset = "0xE87688", VA = "0xE87688")]
		public ModifierID(string name)
		{
		}
	}
	[Token(Token = "0x20000F9")]
	[ExecuteInEditMode]
	[AddComponentMenu("UI/Procedural Image")]
	public class ProceduralImage : Image
	{
		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[SerializeField]
		private float borderWidth;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private ProceduralImageModifier modifier;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Material materialInstance;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[SerializeField]
		private float falloffDistance;

		[Token(Token = "0x17000089")]
		private static Material DefaultProceduralImageMaterial
		{
			[Token(Token = "0x60004B7")]
			[Address(RVA = "0xE876C0", Offset = "0xE876C0", VA = "0xE876C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004B8")]
			[Address(RVA = "0xE877C4", Offset = "0xE877C4", VA = "0xE877C4")]
			set
			{
			}
		}

		[Token(Token = "0x1700008A")]
		public float BorderWidth
		{
			[Token(Token = "0x60004B9")]
			[Address(RVA = "0xE8781C", Offset = "0xE8781C", VA = "0xE8781C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004BA")]
			[Address(RVA = "0xE87824", Offset = "0xE87824", VA = "0xE87824")]
			set
			{
			}
		}

		[Token(Token = "0x1700008B")]
		public float FalloffDistance
		{
			[Token(Token = "0x60004BB")]
			[Address(RVA = "0xE87838", Offset = "0xE87838", VA = "0xE87838")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004BC")]
			[Address(RVA = "0xE87840", Offset = "0xE87840", VA = "0xE87840")]
			set
			{
			}
		}

		[Token(Token = "0x1700008C")]
		protected ProceduralImageModifier Modifier
		{
			[Token(Token = "0x60004BD")]
			[Address(RVA = "0xE87854", Offset = "0xE87854", VA = "0xE87854")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004BE")]
			[Address(RVA = "0xE87B50", Offset = "0xE87B50", VA = "0xE87B50")]
			set
			{
			}
		}

		[Token(Token = "0x1700008D")]
		public System.Type ModifierType
		{
			[Token(Token = "0x60004BF")]
			[Address(RVA = "0xE87B60", Offset = "0xE87B60", VA = "0xE87B60")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004C0")]
			[Address(RVA = "0xE87978", Offset = "0xE87978", VA = "0xE87978")]
			set
			{
			}
		}

		[Token(Token = "0x1700008E")]
		public override Material material
		{
			[Token(Token = "0x60004CD")]
			[Address(RVA = "0xE88418", Offset = "0xE88418", VA = "0xE88418", Slot = "32")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004CE")]
			[Address(RVA = "0xE88494", Offset = "0xE88494", VA = "0xE88494", Slot = "33")]
			set
			{
			}
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0xE87B7C", Offset = "0xE87B7C", VA = "0xE87B7C", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0xE87CFC", Offset = "0xE87CFC", VA = "0xE87CFC", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0xE87B98", Offset = "0xE87B98", VA = "0xE87B98")]
		private void Init()
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0xE87E84", Offset = "0xE87E84", VA = "0xE87E84")]
		protected void OnVerticesDirty()
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0xE87DDC", Offset = "0xE87DDC", VA = "0xE87DDC")]
		protected void FixTexCoordsInCanvas()
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0xE87F08", Offset = "0xE87F08", VA = "0xE87F08")]
		protected void FixTexCoordsInCanvas(Canvas c)
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0xE87F38", Offset = "0xE87F38", VA = "0xE87F38")]
		private Vector4 FixRadius(Vector4 vec)
		{
			return default(Vector4);
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0xE88030", Offset = "0xE88030", VA = "0xE88030", Slot = "44")]
		protected override void OnPopulateMesh(VertexHelper toFill)
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0xE8838C", Offset = "0xE8838C", VA = "0xE8838C", Slot = "12")]
		protected override void OnTransformParentChanged()
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0xE88078", Offset = "0xE88078", VA = "0xE88078")]
		private ProceduralImageInfo CalculateInfo()
		{
			return default(ProceduralImageInfo);
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0xE881D0", Offset = "0xE881D0", VA = "0xE881D0")]
		private void EncodeAllInfoIntoVertices(VertexHelper vh, ProceduralImageInfo info)
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0xE883DC", Offset = "0xE883DC", VA = "0xE883DC")]
		private float EncodeFloats_0_1_16_16(float a, float b)
		{
			return default(float);
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0xE8849C", Offset = "0xE8849C", VA = "0xE8849C")]
		public ProceduralImage()
		{
		}
	}
	[Token(Token = "0x20000FA")]
	public struct ProceduralImageInfo
	{
		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float width;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float height;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float fallOffDistance;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Vector4 radius;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float borderWidth;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float pixelSize;

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0xE883A8", Offset = "0xE883A8", VA = "0xE883A8")]
		public ProceduralImageInfo(float width, float height, float fallOffDistance, float pixelSize, Vector4 radius, float borderWidth)
		{
		}
	}
	[Token(Token = "0x20000FB")]
	[DisallowMultipleComponent]
	public abstract class ProceduralImageModifier : MonoBehaviour
	{
		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected Graphic graphic;

		[Token(Token = "0x1700008F")]
		protected Graphic _Graphic
		{
			[Token(Token = "0x60004D1")]
			[Address(RVA = "0xE87414", Offset = "0xE87414", VA = "0xE87414")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004D2")]
		public abstract Vector4 CalculateRadius(Rect imageRect);

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0xE874F8", Offset = "0xE874F8", VA = "0xE874F8")]
		protected ProceduralImageModifier()
		{
		}
	}
}
namespace OculusSampleFramework
{
	[Token(Token = "0x20000FC")]
	public class ColorGrabbable : OVRGrabbable
	{
		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Color COLOR_GRAB;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly Color COLOR_HIGHLIGHT;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Color m_color;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private MeshRenderer[] m_meshRenderers;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool m_highlight;

		[Token(Token = "0x17000090")]
		public bool Highlight
		{
			[Token(Token = "0x60004D4")]
			[Address(RVA = "0xE884FC", Offset = "0xE884FC", VA = "0xE884FC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004D5")]
			[Address(RVA = "0xE88504", Offset = "0xE88504", VA = "0xE88504")]
			set
			{
			}
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0xE88510", Offset = "0xE88510", VA = "0xE88510")]
		protected void UpdateColor()
		{
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0xE886B0", Offset = "0xE886B0", VA = "0xE886B0", Slot = "4")]
		public override void GrabBegin(OVRGrabber hand, Collider grabPoint)
		{
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0xE886CC", Offset = "0xE886CC", VA = "0xE886CC", Slot = "5")]
		public override void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
		{
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0xE886E8", Offset = "0xE886E8", VA = "0xE886E8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0xE885BC", Offset = "0xE885BC", VA = "0xE885BC")]
		private void SetColor(Color color)
		{
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0xE8899C", Offset = "0xE8899C", VA = "0xE8899C")]
		public ColorGrabbable()
		{
		}
	}
	[Token(Token = "0x20000FD")]
	public class DistanceGrabbable : OVRGrabbable
	{
		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string m_materialColorField;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private GrabbableCrosshair m_crosshair;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private GrabManager m_crosshairManager;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Renderer m_renderer;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private MaterialPropertyBlock m_mpb;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool m_inRange;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		private bool m_targeted;

		[Token(Token = "0x17000091")]
		public bool InRange
		{
			[Token(Token = "0x60004DD")]
			[Address(RVA = "0xE88A14", Offset = "0xE88A14", VA = "0xE88A14")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004DE")]
			[Address(RVA = "0xE88A1C", Offset = "0xE88A1C", VA = "0xE88A1C")]
			set
			{
			}
		}

		[Token(Token = "0x17000092")]
		public bool Targeted
		{
			[Token(Token = "0x60004DF")]
			[Address(RVA = "0xE88B88", Offset = "0xE88B88", VA = "0xE88B88")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004E0")]
			[Address(RVA = "0xE88B90", Offset = "0xE88B90", VA = "0xE88B90")]
			set
			{
			}
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0xE88B9C", Offset = "0xE88B9C", VA = "0xE88B9C", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0xE88A28", Offset = "0xE88A28", VA = "0xE88A28")]
		private void RefreshCrosshair()
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0xE88D8C", Offset = "0xE88D8C", VA = "0xE88D8C")]
		public DistanceGrabbable()
		{
		}
	}
	[Token(Token = "0x20000FE")]
	[RequireComponent(typeof(Rigidbody))]
	public class DistanceGrabber : OVRGrabber
	{
		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[SerializeField]
		private float m_spherecastRadius;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private float m_noSnapThreshhold;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[SerializeField]
		private bool m_useSpherecast;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCD")]
		[SerializeField]
		public bool m_preventGrabThroughWalls;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private float m_objectPullVelocity;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private float m_objectPullMaxRotationRate;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool m_movingObjectToHand;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[SerializeField]
		private float m_maxGrabDistance;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private int m_grabObjectsInLayer;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[SerializeField]
		private int m_obstructionLayer;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private DistanceGrabber m_otherHand;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		protected DistanceGrabbable m_target;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		protected Collider m_targetCollider;

		[Token(Token = "0x17000093")]
		public bool UseSpherecast
		{
			[Token(Token = "0x60004E4")]
			[Address(RVA = "0xE88D94", Offset = "0xE88D94", VA = "0xE88D94")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004E5")]
			[Address(RVA = "0xE88D9C", Offset = "0xE88D9C", VA = "0xE88D9C")]
			set
			{
			}
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0xE88DB8", Offset = "0xE88DB8", VA = "0xE88DB8", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0xE88FC4", Offset = "0xE88FC4", VA = "0xE88FC4", Slot = "6")]
		public override void Update()
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0xE898B0", Offset = "0xE898B0", VA = "0xE898B0", Slot = "7")]
		protected override void GrabBegin()
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0xE89E18", Offset = "0xE89E18", VA = "0xE89E18", Slot = "8")]
		protected override void MoveGrabbedObject(Vector3 pos, Quaternion rot, bool forceTeleport = false)
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0xE8A228", Offset = "0xE8A228", VA = "0xE8A228")]
		private static DistanceGrabbable HitInfoToGrabbable(RaycastHit hitInfo)
		{
			return null;
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0xE891EC", Offset = "0xE891EC", VA = "0xE891EC")]
		protected bool FindTarget(out DistanceGrabbable dgOut, out Collider collOut)
		{
			return default(bool);
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0xE8A314", Offset = "0xE8A314", VA = "0xE8A314")]
		protected bool FindTargetWithSpherecast(out DistanceGrabbable dgOut, out Collider collOut)
		{
			return default(bool);
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0xE8A714", Offset = "0xE8A714", VA = "0xE8A714", Slot = "9")]
		protected override void GrabVolumeEnable(bool enabled)
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0xE8A72C", Offset = "0xE8A72C", VA = "0xE8A72C", Slot = "10")]
		protected override void OffhandGrabbed(OVRGrabbable grabbable)
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0xE8A734", Offset = "0xE8A734", VA = "0xE8A734")]
		public DistanceGrabber()
		{
		}
	}
	[Token(Token = "0x20000FF")]
	public class GrabbableCrosshair : MonoBehaviour
	{
		[Token(Token = "0x2000100")]
		public enum CrosshairState
		{
			[Token(Token = "0x40004AE")]
			Disabled,
			[Token(Token = "0x40004AF")]
			Enabled,
			[Token(Token = "0x40004B0")]
			Targeted
		}

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CrosshairState m_state;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform m_centerEyeAnchor;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject m_targetedCrosshair;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject m_enabledCrosshair;

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0xE8A754", Offset = "0xE8A754", VA = "0xE8A754")]
		private void Start()
		{
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0xE88D00", Offset = "0xE88D00", VA = "0xE88D00")]
		public void SetState(CrosshairState cs)
		{
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0xE8A7BC", Offset = "0xE8A7BC", VA = "0xE8A7BC")]
		private void Update()
		{
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0xE8A7F4", Offset = "0xE8A7F4", VA = "0xE8A7F4")]
		public GrabbableCrosshair()
		{
		}
	}
	[Token(Token = "0x2000101")]
	public class GrabManager : MonoBehaviour
	{
		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Collider m_grabVolume;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color OutlineColorInRange;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Color OutlineColorHighlighted;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Color OutlineColorOutOfRange;

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0xE8A7FC", Offset = "0xE8A7FC", VA = "0xE8A7FC")]
		private void OnTriggerEnter(Collider otherCollider)
		{
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0xE8A8A8", Offset = "0xE8A8A8", VA = "0xE8A8A8")]
		private void OnTriggerExit(Collider otherCollider)
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0xE8A950", Offset = "0xE8A950", VA = "0xE8A950")]
		public GrabManager()
		{
		}
	}
	[Token(Token = "0x2000102")]
	public class PauseOnInputLoss : MonoBehaviour
	{
		[Token(Token = "0x60004F7")]
		[Address(RVA = "0xE8A958", Offset = "0xE8A958", VA = "0xE8A958")]
		private void Start()
		{
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0xE8AA44", Offset = "0xE8AA44", VA = "0xE8AA44")]
		private void OnInputFocusLost()
		{
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0xE8AA50", Offset = "0xE8AA50", VA = "0xE8AA50")]
		private void OnInputFocusAcquired()
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0xE8AA5C", Offset = "0xE8AA5C", VA = "0xE8AA5C")]
		public PauseOnInputLoss()
		{
		}
	}
	[Token(Token = "0x2000103")]
	public class BoneCapsuleTriggerLogic : MonoBehaviour
	{
		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractableToolTags ToolTags;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HashSet<ColliderZone> CollidersTouchingUs;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<ColliderZone> _elementsToCleanUp;

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0xE8AA64", Offset = "0xE8AA64", VA = "0xE8AA64")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0xE8AAB4", Offset = "0xE8AAB4", VA = "0xE8AAB4")]
		private void Update()
		{
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0xE8AE8C", Offset = "0xE8AE8C", VA = "0xE8AE8C")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0xE8AF78", Offset = "0xE8AF78", VA = "0xE8AF78")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0xE8AAB8", Offset = "0xE8AAB8", VA = "0xE8AAB8")]
		private void CleanUpDeadColliders()
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0xE8B064", Offset = "0xE8B064", VA = "0xE8B064")]
		public BoneCapsuleTriggerLogic()
		{
		}
	}
	[Token(Token = "0x2000104")]
	public class ButtonController : Interactable
	{
		[Token(Token = "0x2000105")]
		public enum ContactTest
		{
			[Token(Token = "0x40004C7")]
			PerpenTest,
			[Token(Token = "0x40004C8")]
			BackwardsPress
		}

		[Token(Token = "0x40004B8")]
		private const float ENTRY_DOT_THRESHOLD = 0.8f;

		[Token(Token = "0x40004B9")]
		private const float PERP_DOT_THRESHOLD = 0.5f;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _proximityZone;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _contactZone;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _actionZone;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private ContactTest[] _contactTests;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform _buttonPlaneCenter;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private bool _makeSureToolIsOnPositiveSide;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private Vector3 _localButtonDirection;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private InteractableToolTags[] _allValidToolsTags;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int _toolTagsMask;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[SerializeField]
		private bool _allowMultipleNearFieldInteraction;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Dictionary<InteractableTool, InteractableState> _toolToState;

		[Token(Token = "0x17000094")]
		public override int ValidToolTagsMask
		{
			[Token(Token = "0x6000501")]
			[Address(RVA = "0xE8B13C", Offset = "0xE8B13C", VA = "0xE8B13C", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000095")]
		public Vector3 LocalButtonDirection
		{
			[Token(Token = "0x6000502")]
			[Address(RVA = "0xE8B144", Offset = "0xE8B144", VA = "0xE8B144")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000096")]
		public InteractableState CurrentButtonState
		{
			[Token(Token = "0x6000503")]
			[Address(RVA = "0xE8B150", Offset = "0xE8B150", VA = "0xE8B150")]
			[CompilerGenerated]
			get
			{
				return default(InteractableState);
			}
			[Token(Token = "0x6000504")]
			[Address(RVA = "0xE8B158", Offset = "0xE8B158", VA = "0xE8B158")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0xE8B160", Offset = "0xE8B160", VA = "0xE8B160", Slot = "9")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0xE8B260", Offset = "0xE8B260", VA = "0xE8B260")]
		private void FireInteractionEventsOnDepth(InteractableCollisionDepth oldDepth, InteractableTool collidingTool, InteractionType interactionType)
		{
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0xE8B468", Offset = "0xE8B468", VA = "0xE8B468", Slot = "8")]
		public override void UpdateCollisionDepth(InteractableTool interactableTool, InteractableCollisionDepth oldCollisionDepth, InteractableCollisionDepth newCollisionDepth)
		{
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0xE8BA30", Offset = "0xE8BA30", VA = "0xE8BA30")]
		private InteractableState GetUpcomingStateNearField(InteractableState oldState, InteractableCollisionDepth newCollisionDepth, bool toolIsInActionZone, bool toolIsInContactZone, bool toolIsInProximity, bool validContact, bool onPositiveSideOfInteractable)
		{
			return default(InteractableState);
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0xE8BAE0", Offset = "0xE8BAE0", VA = "0xE8BAE0")]
		public void ForceResetButton()
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0xE8B954", Offset = "0xE8B954", VA = "0xE8B954")]
		private bool IsValidContact(InteractableTool collidingTool, Vector3 buttonDirection)
		{
			return default(bool);
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0xE8BBF0", Offset = "0xE8BBF0", VA = "0xE8BBF0")]
		private bool PassEntryTest(InteractableTool collidingTool, Vector3 buttonDirection)
		{
			return default(bool);
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0xE8BCFC", Offset = "0xE8BCFC", VA = "0xE8BCFC")]
		private bool PassPerpTest(InteractableTool collidingTool, Vector3 buttonDirection)
		{
			return default(bool);
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0xE8BD7C", Offset = "0xE8BD7C", VA = "0xE8BD7C")]
		public ButtonController()
		{
		}
	}
	[Token(Token = "0x2000106")]
	public class ButtonTriggerZone : MonoBehaviour, ColliderZone
	{
		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _parentInteractableObj;

		[Token(Token = "0x17000097")]
		public Collider Collider
		{
			[Token(Token = "0x600050E")]
			[Address(RVA = "0xE8BE98", Offset = "0xE8BE98", VA = "0xE8BE98", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600050F")]
			[Address(RVA = "0xE8BEA0", Offset = "0xE8BEA0", VA = "0xE8BEA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000098")]
		public Interactable ParentInteractable
		{
			[Token(Token = "0x6000510")]
			[Address(RVA = "0xE8BEA8", Offset = "0xE8BEA8", VA = "0xE8BEA8", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000511")]
			[Address(RVA = "0xE8BEB0", Offset = "0xE8BEB0", VA = "0xE8BEB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000099")]
		public InteractableCollisionDepth CollisionDepth
		{
			[Token(Token = "0x6000512")]
			[Address(RVA = "0xE8BEB8", Offset = "0xE8BEB8", VA = "0xE8BEB8", Slot = "6")]
			get
			{
				return default(InteractableCollisionDepth);
			}
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0xE8BF08", Offset = "0xE8BF08", VA = "0xE8BF08")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0xE8BF9C", Offset = "0xE8BF9C", VA = "0xE8BF9C")]
		public ButtonTriggerZone()
		{
		}
	}
	[Token(Token = "0x2000107")]
	public interface ColliderZone
	{
		[Token(Token = "0x1700009A")]
		Collider Collider
		{
			[Token(Token = "0x6000515")]
			get;
		}

		[Token(Token = "0x1700009B")]
		Interactable ParentInteractable
		{
			[Token(Token = "0x6000516")]
			get;
		}

		[Token(Token = "0x1700009C")]
		InteractableCollisionDepth CollisionDepth
		{
			[Token(Token = "0x6000517")]
			get;
		}
	}
	[Token(Token = "0x2000108")]
	public class ColliderZoneArgs : EventArgs
	{
		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly ColliderZone Collider;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly float FrameTime;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly InteractableTool CollidingTool;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly InteractionType InteractionT;

		[Token(Token = "0x6000518")]
		[Address(RVA = "0xE8B3BC", Offset = "0xE8B3BC", VA = "0xE8B3BC")]
		public ColliderZoneArgs(ColliderZone collider, float frameTime, InteractableTool collidingTool, InteractionType interactionType)
		{
		}
	}
	[Token(Token = "0x2000109")]
	public enum InteractionType
	{
		[Token(Token = "0x40004D1")]
		Enter,
		[Token(Token = "0x40004D2")]
		Stay,
		[Token(Token = "0x40004D3")]
		Exit
	}
	[Token(Token = "0x200010A")]
	public class HandsManager : MonoBehaviour
	{
		[Token(Token = "0x200010B")]
		public enum HandsVisualMode
		{
			[Token(Token = "0x40004E5")]
			Mesh,
			[Token(Token = "0x40004E6")]
			Skeleton,
			[Token(Token = "0x40004E7")]
			Both
		}

		[Token(Token = "0x200010C")]
		[CompilerGenerated]
		private sealed class <FindSkeletonVisualGameObjects>d__52 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public HandsManager <>4__this;

			[Token(Token = "0x170000A8")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600053A")]
				[Address(RVA = "0xE8E408", Offset = "0xE8E408", VA = "0xE8E408", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A9")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600053C")]
				[Address(RVA = "0xE8E450", Offset = "0xE8E450", VA = "0xE8E450", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000537")]
			[Address(RVA = "0xE8E1B4", Offset = "0xE8E1B4", VA = "0xE8E1B4")]
			[DebuggerHidden]
			public <FindSkeletonVisualGameObjects>d__52(int <>1__state)
			{
			}

			[Token(Token = "0x6000538")]
			[Address(RVA = "0xE8E1DC", Offset = "0xE8E1DC", VA = "0xE8E1DC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000539")]
			[Address(RVA = "0xE8E1E0", Offset = "0xE8E1E0", VA = "0xE8E1E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600053B")]
			[Address(RVA = "0xE8E410", Offset = "0xE8E410", VA = "0xE8E410", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004D4")]
		private const string SKELETON_VISUALIZER_NAME = "SkeletonRenderer";

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _leftHand;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _rightHand;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public HandsVisualMode VisualMode;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private OVRHand[] _hand;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private OVRSkeleton[] _handSkeleton;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private OVRSkeletonRenderer[] _handSkeletonRenderer;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private OVRMesh[] _handMesh;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private OVRMeshRenderer[] _handMeshRenderer;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private SkinnedMeshRenderer _leftMeshRenderer;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private SkinnedMeshRenderer _rightMeshRenderer;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject _leftSkeletonVisual;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private GameObject _rightSkeletonVisual;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float _currentHandAlpha;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int HandAlphaId;

		[Token(Token = "0x1700009D")]
		public OVRHand RightHand
		{
			[Token(Token = "0x6000519")]
			[Address(RVA = "0xE8BFA4", Offset = "0xE8BFA4", VA = "0xE8BFA4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600051A")]
			[Address(RVA = "0xE8BFD0", Offset = "0xE8BFD0", VA = "0xE8BFD0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700009E")]
		public OVRSkeleton RightHandSkeleton
		{
			[Token(Token = "0x600051B")]
			[Address(RVA = "0xE8C034", Offset = "0xE8C034", VA = "0xE8C034")]
			get
			{
				return null;
			}
			[Token(Token = "0x600051C")]
			[Address(RVA = "0xE8C060", Offset = "0xE8C060", VA = "0xE8C060")]
			private set
			{
			}
		}

		[Token(Token = "0x1700009F")]
		public OVRSkeletonRenderer RightHandSkeletonRenderer
		{
			[Token(Token = "0x600051D")]
			[Address(RVA = "0xE8C0C4", Offset = "0xE8C0C4", VA = "0xE8C0C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600051E")]
			[Address(RVA = "0xE8C0F0", Offset = "0xE8C0F0", VA = "0xE8C0F0")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A0")]
		public OVRMesh RightHandMesh
		{
			[Token(Token = "0x600051F")]
			[Address(RVA = "0xE8C154", Offset = "0xE8C154", VA = "0xE8C154")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000520")]
			[Address(RVA = "0xE8C180", Offset = "0xE8C180", VA = "0xE8C180")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A1")]
		public OVRMeshRenderer RightHandMeshRenderer
		{
			[Token(Token = "0x6000521")]
			[Address(RVA = "0xE8C1E4", Offset = "0xE8C1E4", VA = "0xE8C1E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000522")]
			[Address(RVA = "0xE8C210", Offset = "0xE8C210", VA = "0xE8C210")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A2")]
		public OVRHand LeftHand
		{
			[Token(Token = "0x6000523")]
			[Address(RVA = "0xE8C274", Offset = "0xE8C274", VA = "0xE8C274")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000524")]
			[Address(RVA = "0xE8C29C", Offset = "0xE8C29C", VA = "0xE8C29C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A3")]
		public OVRSkeleton LeftHandSkeleton
		{
			[Token(Token = "0x6000525")]
			[Address(RVA = "0xE8C2FC", Offset = "0xE8C2FC", VA = "0xE8C2FC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000526")]
			[Address(RVA = "0xE8C324", Offset = "0xE8C324", VA = "0xE8C324")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A4")]
		public OVRSkeletonRenderer LeftHandSkeletonRenderer
		{
			[Token(Token = "0x6000527")]
			[Address(RVA = "0xE8C384", Offset = "0xE8C384", VA = "0xE8C384")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000528")]
			[Address(RVA = "0xE8C3AC", Offset = "0xE8C3AC", VA = "0xE8C3AC")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A5")]
		public OVRMesh LeftHandMesh
		{
			[Token(Token = "0x6000529")]
			[Address(RVA = "0xE8C40C", Offset = "0xE8C40C", VA = "0xE8C40C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600052A")]
			[Address(RVA = "0xE8C434", Offset = "0xE8C434", VA = "0xE8C434")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A6")]
		public OVRMeshRenderer LeftHandMeshRenderer
		{
			[Token(Token = "0x600052B")]
			[Address(RVA = "0xE8C494", Offset = "0xE8C494", VA = "0xE8C494")]
			get
			{
				return null;
			}
			[Token(Token = "0x600052C")]
			[Address(RVA = "0xE8C4BC", Offset = "0xE8C4BC", VA = "0xE8C4BC")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A7")]
		public static HandsManager Instance
		{
			[Token(Token = "0x600052D")]
			[Address(RVA = "0xE8C51C", Offset = "0xE8C51C", VA = "0xE8C51C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600052E")]
			[Address(RVA = "0xE8C564", Offset = "0xE8C564", VA = "0xE8C564")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0xE8C5BC", Offset = "0xE8C5BC", VA = "0xE8C5BC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0xE8C978", Offset = "0xE8C978", VA = "0xE8C978")]
		private void Update()
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0xE8C904", Offset = "0xE8C904", VA = "0xE8C904")]
		[IteratorStateMachine(typeof(<FindSkeletonVisualGameObjects>d__52))]
		private IEnumerator FindSkeletonVisualGameObjects()
		{
			return null;
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0xE8C9F4", Offset = "0xE8C9F4", VA = "0xE8C9F4")]
		public void SwitchVisualization()
		{
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0xE8CAB8", Offset = "0xE8CAB8", VA = "0xE8CAB8")]
		private void SetToCurrentVisualMode()
		{
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0xE8CC88", Offset = "0xE8CC88", VA = "0xE8CC88")]
		public static List<OVRBoneCapsule> GetCapsulesPerBone(OVRSkeleton skeleton, OVRSkeleton.BoneId boneId)
		{
			return null;
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0xE8CEEC", Offset = "0xE8CEEC", VA = "0xE8CEEC")]
		public bool IsInitialized()
		{
			return default(bool);
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0xE8D04C", Offset = "0xE8D04C", VA = "0xE8D04C")]
		public HandsManager()
		{
		}
	}
	[Token(Token = "0x200010D")]
	public abstract class Interactable : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200010E")]
		public class InteractableStateArgsEvent : UnityEvent<InteractableStateArgs>
		{
			[Token(Token = "0x600054E")]
			[Address(RVA = "0xE8EAFC", Offset = "0xE8EAFC", VA = "0xE8EAFC")]
			public InteractableStateArgsEvent()
			{
			}
		}

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected ColliderZone _proximityZoneCollider;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected ColliderZone _contactZoneCollider;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected ColliderZone _actionZoneCollider;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public InteractableStateArgsEvent InteractableStateChanged;

		[Token(Token = "0x170000AA")]
		public ColliderZone ProximityCollider
		{
			[Token(Token = "0x600053D")]
			[Address(RVA = "0xE8E458", Offset = "0xE8E458", VA = "0xE8E458")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AB")]
		public ColliderZone ContactCollider
		{
			[Token(Token = "0x600053E")]
			[Address(RVA = "0xE8E460", Offset = "0xE8E460", VA = "0xE8E460")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AC")]
		public ColliderZone ActionCollider
		{
			[Token(Token = "0x600053F")]
			[Address(RVA = "0xE8E468", Offset = "0xE8E468", VA = "0xE8E468")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AD")]
		public virtual int ValidToolTagsMask
		{
			[Token(Token = "0x6000540")]
			[Address(RVA = "0xE8E470", Offset = "0xE8E470", VA = "0xE8E470", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x14000017")]
		public event Action<ColliderZoneArgs> ProximityZoneEvent
		{
			[Token(Token = "0x6000541")]
			[Address(RVA = "0xE8E478", Offset = "0xE8E478", VA = "0xE8E478")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000542")]
			[Address(RVA = "0xE8E528", Offset = "0xE8E528", VA = "0xE8E528")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000018")]
		public event Action<ColliderZoneArgs> ContactZoneEvent
		{
			[Token(Token = "0x6000544")]
			[Address(RVA = "0xE8E5F4", Offset = "0xE8E5F4", VA = "0xE8E5F4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000545")]
			[Address(RVA = "0xE8E6A4", Offset = "0xE8E6A4", VA = "0xE8E6A4")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000019")]
		public event Action<ColliderZoneArgs> ActionZoneEvent
		{
			[Token(Token = "0x6000547")]
			[Address(RVA = "0xE8E770", Offset = "0xE8E770", VA = "0xE8E770")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000548")]
			[Address(RVA = "0xE8E820", Offset = "0xE8E820", VA = "0xE8E820")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0xE8E5D8", Offset = "0xE8E5D8", VA = "0xE8E5D8", Slot = "5")]
		protected virtual void OnProximityZoneEvent(ColliderZoneArgs args)
		{
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0xE8E754", Offset = "0xE8E754", VA = "0xE8E754", Slot = "6")]
		protected virtual void OnContactZoneEvent(ColliderZoneArgs args)
		{
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0xE8E8D0", Offset = "0xE8E8D0", VA = "0xE8E8D0", Slot = "7")]
		protected virtual void OnActionZoneEvent(ColliderZoneArgs args)
		{
		}

		[Token(Token = "0x600054A")]
		public abstract void UpdateCollisionDepth(InteractableTool interactableTool, InteractableCollisionDepth oldCollisionDepth, InteractableCollisionDepth newCollisionDepth);

		[Token(Token = "0x600054B")]
		[Address(RVA = "0xE8E8EC", Offset = "0xE8E8EC", VA = "0xE8E8EC", Slot = "9")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0xE8E9F0", Offset = "0xE8E9F0", VA = "0xE8E9F0", Slot = "10")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0xE8EAF4", Offset = "0xE8EAF4", VA = "0xE8EAF4")]
		protected Interactable()
		{
		}
	}
	[Token(Token = "0x200010F")]
	public enum InteractableCollisionDepth
	{
		[Token(Token = "0x40004F3")]
		None,
		[Token(Token = "0x40004F4")]
		Proximity,
		[Token(Token = "0x40004F5")]
		Contact,
		[Token(Token = "0x40004F6")]
		Action
	}
	[Token(Token = "0x2000110")]
	public enum InteractableState
	{
		[Token(Token = "0x40004F8")]
		Default,
		[Token(Token = "0x40004F9")]
		ProximityState,
		[Token(Token = "0x40004FA")]
		ContactState,
		[Token(Token = "0x40004FB")]
		ActionState
	}
	[Token(Token = "0x2000111")]
	public class InteractableStateArgs : EventArgs
	{
		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly Interactable Interactable;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly InteractableTool Tool;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly InteractableState OldInteractableState;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public readonly InteractableState NewInteractableState;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly ColliderZoneArgs ColliderArgs;

		[Token(Token = "0x600054F")]
		[Address(RVA = "0xE8EB44", Offset = "0xE8EB44", VA = "0xE8EB44")]
		public InteractableStateArgs(Interactable interactable, InteractableTool tool, InteractableState newInteractableState, InteractableState oldState, ColliderZoneArgs colliderArgs)
		{
		}
	}
	[Token(Token = "0x2000112")]
	public class InteractableRegistry : MonoBehaviour
	{
		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static HashSet<Interactable> _interactables;

		[Token(Token = "0x170000AE")]
		public static HashSet<Interactable> Interactables
		{
			[Token(Token = "0x6000550")]
			[Address(RVA = "0xE8EBFC", Offset = "0xE8EBFC", VA = "0xE8EBFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0xE8E940", Offset = "0xE8E940", VA = "0xE8E940")]
		public static void RegisterInteractable(Interactable interactable)
		{
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0xE8EA44", Offset = "0xE8EA44", VA = "0xE8EA44")]
		public static void UnregisterInteractable(Interactable interactable)
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0xE8EC54", Offset = "0xE8EC54", VA = "0xE8EC54")]
		public InteractableRegistry()
		{
		}
	}
	[Token(Token = "0x2000113")]
	public class InteractableToolsCreator : MonoBehaviour
	{
		[Token(Token = "0x2000114")]
		[CompilerGenerated]
		private sealed class <AttachToolsToHands>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000504")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000505")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000506")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform[] toolObjects;

			[Token(Token = "0x4000507")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool isRightHand;

			[Token(Token = "0x4000508")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public InteractableToolsCreator <>4__this;

			[Token(Token = "0x4000509")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private HandsManager <handsManagerObj>5__2;

			[Token(Token = "0x400050A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private HashSet<Transform>.Enumerator <>7__wrap2;

			[Token(Token = "0x400050B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Transform <toolObject>5__4;

			[Token(Token = "0x400050C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private OVRSkeleton <handSkeletonToAttachTo>5__5;

			[Token(Token = "0x170000AF")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600055D")]
				[Address(RVA = "0xE8F420", Offset = "0xE8F420", VA = "0xE8F420", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B0")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600055F")]
				[Address(RVA = "0xE8F468", Offset = "0xE8F468", VA = "0xE8F468", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000559")]
			[Address(RVA = "0xE8EDFC", Offset = "0xE8EDFC", VA = "0xE8EDFC")]
			[DebuggerHidden]
			public <AttachToolsToHands>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x600055A")]
			[Address(RVA = "0xE8EF38", Offset = "0xE8EF38", VA = "0xE8EF38", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600055B")]
			[Address(RVA = "0xE8EF54", Offset = "0xE8EF54", VA = "0xE8EF54", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600055C")]
			[Address(RVA = "0xE8F3D0", Offset = "0xE8F3D0", VA = "0xE8F3D0")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x600055E")]
			[Address(RVA = "0xE8F428", Offset = "0xE8F428", VA = "0xE8F428", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform[] LeftHandTools;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform[] RightHandTools;

		[Token(Token = "0x6000555")]
		[Address(RVA = "0xE8ECF4", Offset = "0xE8ECF4", VA = "0xE8ECF4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0xE8ED60", Offset = "0xE8ED60", VA = "0xE8ED60")]
		[IteratorStateMachine(typeof(<AttachToolsToHands>d__3))]
		private IEnumerator AttachToolsToHands(Transform[] toolObjects, bool isRightHand)
		{
			return null;
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0xE8EE24", Offset = "0xE8EE24", VA = "0xE8EE24")]
		private void AttachToolToHandTransform(Transform tool, bool isRightHanded)
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0xE8EF30", Offset = "0xE8EF30", VA = "0xE8EF30")]
		public InteractableToolsCreator()
		{
		}
	}
	[Token(Token = "0x2000115")]
	public class InteractableToolsInputRouter : MonoBehaviour
	{
		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static InteractableToolsInputRouter _instance;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool _leftPinch;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool _rightPinch;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private HashSet<InteractableTool> _leftHandNearTools;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private HashSet<InteractableTool> _leftHandFarTools;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private HashSet<InteractableTool> _rightHandNearTools;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private HashSet<InteractableTool> _rightHandFarTools;

		[Token(Token = "0x170000B1")]
		public static InteractableToolsInputRouter Instance
		{
			[Token(Token = "0x6000560")]
			[Address(RVA = "0xE8F470", Offset = "0xE8F470", VA = "0xE8F470")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0xE8F5CC", Offset = "0xE8F5CC", VA = "0xE8F5CC")]
		public void RegisterInteractableTool(InteractableTool interactableTool)
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0xE8F668", Offset = "0xE8F668", VA = "0xE8F668")]
		public void UnregisterInteractableTool(InteractableTool interactableTool)
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0xE8F704", Offset = "0xE8F704", VA = "0xE8F704")]
		private void Update()
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0xE8F9BC", Offset = "0xE8F9BC", VA = "0xE8F9BC")]
		private bool UpdateToolsAndEnableState(HashSet<InteractableTool> tools, bool toolsAreEnabledThisFrame)
		{
			return default(bool);
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0xE8F9F8", Offset = "0xE8F9F8", VA = "0xE8F9F8")]
		private bool UpdateTools(HashSet<InteractableTool> tools, bool resetCollisionData = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0xE8FCD0", Offset = "0xE8FCD0", VA = "0xE8FCD0")]
		private void ToggleToolsEnableState(HashSet<InteractableTool> tools, bool enableState)
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0xE8FED8", Offset = "0xE8FED8", VA = "0xE8FED8")]
		public InteractableToolsInputRouter()
		{
		}
	}
	[Token(Token = "0x2000116")]
	public class FingerTipPokeTool : InteractableTool
	{
		[Token(Token = "0x2000117")]
		[CompilerGenerated]
		private sealed class <AttachTriggerLogic>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400051F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000520")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000521")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FingerTipPokeTool <>4__this;

			[Token(Token = "0x170000B6")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000579")]
				[Address(RVA = "0xE910C0", Offset = "0xE910C0", VA = "0xE910C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B7")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600057B")]
				[Address(RVA = "0xE91108", Offset = "0xE91108", VA = "0xE91108", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000576")]
			[Address(RVA = "0xE90174", Offset = "0xE90174", VA = "0xE90174")]
			[DebuggerHidden]
			public <AttachTriggerLogic>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x6000577")]
			[Address(RVA = "0xE90C24", Offset = "0xE90C24", VA = "0xE90C24", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000578")]
			[Address(RVA = "0xE90C28", Offset = "0xE90C28", VA = "0xE90C28", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600057A")]
			[Address(RVA = "0xE910C8", Offset = "0xE910C8", VA = "0xE910C8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000514")]
		private const int NUM_VELOCITY_FRAMES = 10;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private FingerTipPokeToolView _fingerTipPokeToolView;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private OVRPlugin.HandFinger _fingerToFollow;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3[] _velocityFrames;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int _currVelocityFrame;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private bool _sampledMaxFramesAlready;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 _position;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private BoneCapsuleTriggerLogic[] _boneCapsuleTriggerLogic;

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float _lastScale;

		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool _isInitialized;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private OVRBoneCapsule _capsuleToTrack;

		[Token(Token = "0x170000B2")]
		public override InteractableToolTags ToolTags
		{
			[Token(Token = "0x6000568")]
			[Address(RVA = "0xE8FFE0", Offset = "0xE8FFE0", VA = "0xE8FFE0", Slot = "4")]
			get
			{
				return default(InteractableToolTags);
			}
		}

		[Token(Token = "0x170000B3")]
		public override ToolInputState ToolInputState
		{
			[Token(Token = "0x6000569")]
			[Address(RVA = "0xE8FFE8", Offset = "0xE8FFE8", VA = "0xE8FFE8", Slot = "5")]
			get
			{
				return default(ToolInputState);
			}
		}

		[Token(Token = "0x170000B4")]
		public override bool IsFarFieldTool
		{
			[Token(Token = "0x600056A")]
			[Address(RVA = "0xE8FFF0", Offset = "0xE8FFF0", VA = "0xE8FFF0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B5")]
		public override bool EnableState
		{
			[Token(Token = "0x600056B")]
			[Address(RVA = "0xE8FFF8", Offset = "0xE8FFF8", VA = "0xE8FFF8", Slot = "10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600056C")]
			[Address(RVA = "0xE90020", Offset = "0xE90020", VA = "0xE90020", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0xE90050", Offset = "0xE90050", VA = "0xE90050", Slot = "12")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0xE90100", Offset = "0xE90100", VA = "0xE90100")]
		[IteratorStateMachine(typeof(<AttachTriggerLogic>d__21))]
		private IEnumerator AttachTriggerLogic()
		{
			return null;
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0xE9019C", Offset = "0xE9019C", VA = "0xE9019C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0xE90424", Offset = "0xE90424", VA = "0xE90424")]
		private void UpdateAverageVelocity()
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0xE905E0", Offset = "0xE905E0", VA = "0xE905E0")]
		private void CheckAndUpdateScale()
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0xE906CC", Offset = "0xE906CC", VA = "0xE906CC", Slot = "7")]
		public override List<InteractableCollisionInfo> GetNextIntersectingObjects()
		{
			return null;
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0xE90A60", Offset = "0xE90A60", VA = "0xE90A60", Slot = "8")]
		public override void FocusOnInteractable(Interactable focusedInteractable, ColliderZone colliderZone)
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0xE90A64", Offset = "0xE90A64", VA = "0xE90A64", Slot = "9")]
		public override void DeFocus()
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0xE90A68", Offset = "0xE90A68", VA = "0xE90A68")]
		public FingerTipPokeTool()
		{
		}
	}
	[Token(Token = "0x2000118")]
	public class FingerTipPokeToolView : MonoBehaviour, InteractableToolView
	{
		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MeshRenderer _sphereMeshRenderer;

		[Token(Token = "0x170000B8")]
		public InteractableTool InteractableTool
		{
			[Token(Token = "0x600057C")]
			[Address(RVA = "0xE91110", Offset = "0xE91110", VA = "0xE91110", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600057D")]
			[Address(RVA = "0xE91118", Offset = "0xE91118", VA = "0xE91118")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000B9")]
		public bool EnableState
		{
			[Token(Token = "0x600057E")]
			[Address(RVA = "0xE91120", Offset = "0xE91120", VA = "0xE91120", Slot = "6")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600057F")]
			[Address(RVA = "0xE9113C", Offset = "0xE9113C", VA = "0xE9113C", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x170000BA")]
		public bool ToolActivateState
		{
			[Token(Token = "0x6000580")]
			[Address(RVA = "0xE9115C", Offset = "0xE9115C", VA = "0xE9115C", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000581")]
			[Address(RVA = "0xE91164", Offset = "0xE91164", VA = "0xE91164", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000BB")]
		public float SphereRadius
		{
			[Token(Token = "0x6000582")]
			[Address(RVA = "0xE91170", Offset = "0xE91170", VA = "0xE91170")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000583")]
			[Address(RVA = "0xE91178", Offset = "0xE91178", VA = "0xE91178")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0xE91180", Offset = "0xE91180", VA = "0xE91180")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0xE911BC", Offset = "0xE911BC", VA = "0xE911BC", Slot = "5")]
		public void SetFocusedInteractable(Interactable interactable)
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0xE911C0", Offset = "0xE911C0", VA = "0xE911C0")]
		public FingerTipPokeToolView()
		{
		}
	}
	[Token(Token = "0x2000119")]
	[Flags]
	public enum InteractableToolTags
	{
		[Token(Token = "0x4000527")]
		None = 0,
		[Token(Token = "0x4000528")]
		Ray = 1,
		[Token(Token = "0x4000529")]
		Poke = 4,
		[Token(Token = "0x400052A")]
		All = -1
	}
	[Token(Token = "0x200011A")]
	public enum ToolInputState
	{
		[Token(Token = "0x400052C")]
		Inactive,
		[Token(Token = "0x400052D")]
		PrimaryInputDown,
		[Token(Token = "0x400052E")]
		PrimaryInputDownStay,
		[Token(Token = "0x400052F")]
		PrimaryInputUp
	}
	[Token(Token = "0x200011B")]
	public class InteractableCollisionInfo
	{
		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ColliderZone InteractableCollider;

		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractableCollisionDepth CollisionDepth;

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractableTool CollidingTool;

		[Token(Token = "0x6000587")]
		[Address(RVA = "0xE90A0C", Offset = "0xE90A0C", VA = "0xE90A0C")]
		public InteractableCollisionInfo(ColliderZone collider, InteractableCollisionDepth collisionDepth, InteractableTool collidingTool)
		{
		}
	}
	[Token(Token = "0x200011C")]
	public abstract class InteractableTool : MonoBehaviour
	{
		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected List<InteractableCollisionInfo> _currentIntersectingObjects;

		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<Interactable> _addedInteractables;

		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<Interactable> _removedInteractables;

		[Token(Token = "0x4000539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<Interactable> _remainingInteractables;

		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Dictionary<Interactable, InteractableCollisionInfo> _currInteractableToCollisionInfos;

		[Token(Token = "0x400053B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Dictionary<Interactable, InteractableCollisionInfo> _prevInteractableToCollisionInfos;

		[Token(Token = "0x170000BC")]
		public Transform ToolTransform
		{
			[Token(Token = "0x6000588")]
			[Address(RVA = "0xE911C8", Offset = "0xE911C8", VA = "0xE911C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BD")]
		public bool IsRightHandedTool
		{
			[Token(Token = "0x6000589")]
			[Address(RVA = "0xE911D0", Offset = "0xE911D0", VA = "0xE911D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600058A")]
			[Address(RVA = "0xE911D8", Offset = "0xE911D8", VA = "0xE911D8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000BE")]
		public abstract InteractableToolTags ToolTags
		{
			[Token(Token = "0x600058B")]
			get;
		}

		[Token(Token = "0x170000BF")]
		public abstract ToolInputState ToolInputState
		{
			[Token(Token = "0x600058C")]
			get;
		}

		[Token(Token = "0x170000C0")]
		public abstract bool IsFarFieldTool
		{
			[Token(Token = "0x600058D")]
			get;
		}

		[Token(Token = "0x170000C1")]
		public Vector3 Velocity
		{
			[Token(Token = "0x600058E")]
			[Address(RVA = "0xE911E4", Offset = "0xE911E4", VA = "0xE911E4")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600058F")]
			[Address(RVA = "0xE911F0", Offset = "0xE911F0", VA = "0xE911F0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x170000C2")]
		public Vector3 InteractionPosition
		{
			[Token(Token = "0x6000590")]
			[Address(RVA = "0xE911FC", Offset = "0xE911FC", VA = "0xE911FC")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000591")]
			[Address(RVA = "0xE91208", Offset = "0xE91208", VA = "0xE91208")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x170000C3")]
		public abstract bool EnableState
		{
			[Token(Token = "0x6000596")]
			get;
			[Token(Token = "0x6000597")]
			set;
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0xE91214", Offset = "0xE91214", VA = "0xE91214")]
		public List<InteractableCollisionInfo> GetCurrentIntersectingObjects()
		{
			return null;
		}

		[Token(Token = "0x6000593")]
		public abstract List<InteractableCollisionInfo> GetNextIntersectingObjects();

		[Token(Token = "0x6000594")]
		public abstract void FocusOnInteractable(Interactable focusedInteractable, ColliderZone colliderZone);

		[Token(Token = "0x6000595")]
		public abstract void DeFocus();

		[Token(Token = "0x6000598")]
		public abstract void Initialize();

		[Token(Token = "0x6000599")]
		[Address(RVA = "0xE8FE40", Offset = "0xE8FE40", VA = "0xE8FE40")]
		public KeyValuePair<Interactable, InteractableCollisionInfo> GetFirstCurrentCollisionInfo()
		{
			return default(KeyValuePair<Interactable, InteractableCollisionInfo>);
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0xE8FE88", Offset = "0xE8FE88", VA = "0xE8FE88")]
		public void ClearAllCurrentCollisionInfos()
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0xE9121C", Offset = "0xE9121C", VA = "0xE9121C", Slot = "13")]
		public virtual void UpdateCurrentCollisionsBasedOnDepth()
		{
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0xE914E4", Offset = "0xE914E4", VA = "0xE914E4", Slot = "14")]
		public virtual void UpdateLatestCollisionData()
		{
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0xE90A7C", Offset = "0xE90A7C", VA = "0xE90A7C")]
		protected InteractableTool()
		{
		}
	}
	[Token(Token = "0x200011D")]
	public interface InteractableToolView
	{
		[Token(Token = "0x170000C4")]
		InteractableTool InteractableTool
		{
			[Token(Token = "0x600059E")]
			get;
		}

		[Token(Token = "0x170000C5")]
		bool EnableState
		{
			[Token(Token = "0x60005A0")]
			get;
			[Token(Token = "0x60005A1")]
			set;
		}

		[Token(Token = "0x170000C6")]
		bool ToolActivateState
		{
			[Token(Token = "0x60005A2")]
			get;
			[Token(Token = "0x60005A3")]
			set;
		}

		[Token(Token = "0x600059F")]
		void SetFocusedInteractable(Interactable interactable);
	}
	[Token(Token = "0x200011E")]
	public class PinchStateModule
	{
		[Token(Token = "0x200011F")]
		private enum PinchState
		{
			[Token(Token = "0x4000540")]
			None,
			[Token(Token = "0x4000541")]
			PinchDown,
			[Token(Token = "0x4000542")]
			PinchStay,
			[Token(Token = "0x4000543")]
			PinchUp
		}

		[Token(Token = "0x400053C")]
		private const float PINCH_STRENGTH_THRESHOLD = 1f;

		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private PinchState _currPinchState;

		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Interactable _firstFocusedInteractable;

		[Token(Token = "0x170000C7")]
		public bool PinchUpAndDownOnFocusedObject
		{
			[Token(Token = "0x60005A4")]
			[Address(RVA = "0xE91D80", Offset = "0xE91D80", VA = "0xE91D80")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C8")]
		public bool PinchSteadyOnFocusedObject
		{
			[Token(Token = "0x60005A5")]
			[Address(RVA = "0xE91DFC", Offset = "0xE91DFC", VA = "0xE91DFC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C9")]
		public bool PinchDownOnFocusedObject
		{
			[Token(Token = "0x60005A6")]
			[Address(RVA = "0xE91E78", Offset = "0xE91E78", VA = "0xE91E78")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0xE91EF4", Offset = "0xE91EF4", VA = "0xE91EF4")]
		public PinchStateModule()
		{
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0xE91F1C", Offset = "0xE91F1C", VA = "0xE91F1C")]
		public void UpdateState(OVRHand hand, Interactable currFocusedInteractable)
		{
		}
	}
	[Token(Token = "0x2000120")]
	public class RayTool : InteractableTool
	{
		[Token(Token = "0x4000544")]
		private const float MINIMUM_RAY_CAST_DISTANCE = 0.8f;

		[Token(Token = "0x4000545")]
		private const float COLLIDER_RADIUS = 0.01f;

		[Token(Token = "0x4000546")]
		private const int NUM_MAX_PRIMARY_HITS = 10;

		[Token(Token = "0x4000547")]
		private const int NUM_MAX_SECONDARY_HITS = 25;

		[Token(Token = "0x4000548")]
		private const int NUM_COLLIDERS_TO_TEST = 20;

		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RayToolView _rayToolView;

		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Range(0f, 45f)]
		[SerializeField]
		private float _coneAngleDegrees;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		private float _farFieldMaxDistance;

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private PinchStateModule _pinchStateModule;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Interactable _focusedInteractable;

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Collider[] _collidersOverlapped;

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Interactable _currInteractableCastedAgainst;

		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float _coneAngleReleaseDegrees;

		[Token(Token = "0x4000551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private RaycastHit[] _primaryHits;

		[Token(Token = "0x4000552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Collider[] _secondaryOverlapResults;

		[Token(Token = "0x4000553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private bool _initialized;

		[Token(Token = "0x170000CA")]
		public override InteractableToolTags ToolTags
		{
			[Token(Token = "0x60005A9")]
			[Address(RVA = "0xE92094", Offset = "0xE92094", VA = "0xE92094", Slot = "4")]
			get
			{
				return default(InteractableToolTags);
			}
		}

		[Token(Token = "0x170000CB")]
		public override ToolInputState ToolInputState
		{
			[Token(Token = "0x60005AA")]
			[Address(RVA = "0xE9209C", Offset = "0xE9209C", VA = "0xE9209C", Slot = "5")]
			get
			{
				return default(ToolInputState);
			}
		}

		[Token(Token = "0x170000CC")]
		public override bool IsFarFieldTool
		{
			[Token(Token = "0x60005AB")]
			[Address(RVA = "0xE920F8", Offset = "0xE920F8", VA = "0xE920F8", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CD")]
		public override bool EnableState
		{
			[Token(Token = "0x60005AC")]
			[Address(RVA = "0xE92100", Offset = "0xE92100", VA = "0xE92100", Slot = "10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005AD")]
			[Address(RVA = "0xE92140", Offset = "0xE92140", VA = "0xE92140", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0xE921B0", Offset = "0xE921B0", VA = "0xE921B0", Slot = "12")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0xE92204", Offset = "0xE92204", VA = "0xE92204")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0xE92290", Offset = "0xE92290", VA = "0xE92290")]
		private void Update()
		{
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0xE9253C", Offset = "0xE9253C", VA = "0xE9253C")]
		private Vector3 GetRayCastOrigin()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0xE925B8", Offset = "0xE925B8", VA = "0xE925B8", Slot = "7")]
		public override List<InteractableCollisionInfo> GetNextIntersectingObjects()
		{
			return null;
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0xE929AC", Offset = "0xE929AC", VA = "0xE929AC")]
		private bool HasRayReleasedInteractable(Interactable focusedInteractable)
		{
			return default(bool);
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0xE92B48", Offset = "0xE92B48", VA = "0xE92B48")]
		private Interactable FindTargetInteractable()
		{
			return null;
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0xE92C60", Offset = "0xE92C60", VA = "0xE92C60")]
		private Interactable FindPrimaryRaycastHit(Vector3 rayOrigin, Vector3 rayDirection)
		{
			return null;
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0xE92F84", Offset = "0xE92F84", VA = "0xE92F84")]
		private Interactable FindInteractableViaConeTest(Vector3 rayOrigin, Vector3 rayDirection)
		{
			return null;
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0xE93300", Offset = "0xE93300", VA = "0xE93300", Slot = "8")]
		public override void FocusOnInteractable(Interactable focusedInteractable, ColliderZone colliderZone)
		{
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0xE933D8", Offset = "0xE933D8", VA = "0xE933D8", Slot = "9")]
		public override void DeFocus()
		{
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0xE93408", Offset = "0xE93408", VA = "0xE93408")]
		public RayTool()
		{
		}
	}
	[Token(Token = "0x2000121")]
	public class RayToolView : MonoBehaviour, InteractableToolView
	{
		[Token(Token = "0x4000554")]
		private const int NUM_RAY_LINE_POSITIONS = 25;

		[Token(Token = "0x4000555")]
		private const float DEFAULT_RAY_CAST_DISTANCE = 3f;

		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _targetTransform;

		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LineRenderer _lineRenderer;

		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _toolActivateState;

		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform _focusedTransform;

		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3[] linePositions;

		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Gradient _oldColorGradient;

		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Gradient _highLightColorGradient;

		[Token(Token = "0x170000CE")]
		public bool EnableState
		{
			[Token(Token = "0x60005BA")]
			[Address(RVA = "0xE92124", Offset = "0xE92124", VA = "0xE92124", Slot = "6")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005BB")]
			[Address(RVA = "0xE9215C", Offset = "0xE9215C", VA = "0xE9215C", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x170000CF")]
		public bool ToolActivateState
		{
			[Token(Token = "0x60005BC")]
			[Address(RVA = "0xE9351C", Offset = "0xE9351C", VA = "0xE9351C", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005BD")]
			[Address(RVA = "0xE92500", Offset = "0xE92500", VA = "0xE92500", Slot = "9")]
			set
			{
			}
		}

		[Token(Token = "0x170000D0")]
		public InteractableTool InteractableTool
		{
			[Token(Token = "0x60005BF")]
			[Address(RVA = "0xE93744", Offset = "0xE93744", VA = "0xE93744", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60005C0")]
			[Address(RVA = "0xE9374C", Offset = "0xE9374C", VA = "0xE9374C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0xE93524", Offset = "0xE93524", VA = "0xE93524")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0xE93338", Offset = "0xE93338", VA = "0xE93338", Slot = "5")]
		public void SetFocusedInteractable(Interactable interactable)
		{
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0xE93754", Offset = "0xE93754", VA = "0xE93754")]
		private void Update()
		{
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0xE93A00", Offset = "0xE93A00", VA = "0xE93A00")]
		public static Vector3 GetPointOnBezierCurve(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0xE93AA8", Offset = "0xE93AA8", VA = "0xE93AA8")]
		public RayToolView()
		{
		}
	}
	[Token(Token = "0x2000122")]
	public class DistanceGrabberSample : MonoBehaviour
	{
		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool useSpherecast;

		[Token(Token = "0x400055F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool allowGrabThroughWalls;

		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private DistanceGrabber[] m_grabbers;

		[Token(Token = "0x170000D1")]
		public bool UseSpherecast
		{
			[Token(Token = "0x60005C5")]
			[Address(RVA = "0xE93B0C", Offset = "0xE93B0C", VA = "0xE93B0C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005C6")]
			[Address(RVA = "0xE93B14", Offset = "0xE93B14", VA = "0xE93B14")]
			set
			{
			}
		}

		[Token(Token = "0x170000D2")]
		public bool AllowGrabThroughWalls
		{
			[Token(Token = "0x60005C7")]
			[Address(RVA = "0xE93B80", Offset = "0xE93B80", VA = "0xE93B80")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005C8")]
			[Address(RVA = "0xE93B88", Offset = "0xE93B88", VA = "0xE93B88")]
			set
			{
			}
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0xE93BE4", Offset = "0xE93BE4", VA = "0xE93BE4")]
		private void Start()
		{
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0xE93E84", Offset = "0xE93E84", VA = "0xE93E84")]
		public void ToggleSphereCasting(Toggle t)
		{
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0xE93E94", Offset = "0xE93E94", VA = "0xE93E94")]
		public void ToggleGrabThroughWalls(Toggle t)
		{
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0xE93EA4", Offset = "0xE93EA4", VA = "0xE93EA4")]
		public DistanceGrabberSample()
		{
		}
	}
	[Token(Token = "0x2000123")]
	public class ControllerBoxController : MonoBehaviour
	{
		[Token(Token = "0x4000561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TrainLocomotive _locomotive;

		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CowController _cowController;

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0xE93EAC", Offset = "0xE93EAC", VA = "0xE93EAC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0xE93EB0", Offset = "0xE93EB0", VA = "0xE93EB0")]
		public void StartStopStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0xE93F3C", Offset = "0xE93F3C", VA = "0xE93F3C")]
		public void DecreaseSpeedStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0xE93FCC", Offset = "0xE93FCC", VA = "0xE93FCC")]
		public void IncreaseSpeedStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0xE9405C", Offset = "0xE9405C", VA = "0xE9405C")]
		public void SmokeButtonStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0xE94108", Offset = "0xE94108", VA = "0xE94108")]
		public void WhistleButtonStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0xE941E4", Offset = "0xE941E4", VA = "0xE941E4")]
		public void ReverseButtonStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0xE94228", Offset = "0xE94228", VA = "0xE94228")]
		public void SwitchVisualization(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0xE9428C", Offset = "0xE9428C", VA = "0xE9428C")]
		public void GoMoo(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0xE942EC", Offset = "0xE942EC", VA = "0xE942EC")]
		public ControllerBoxController()
		{
		}
	}
	[Token(Token = "0x2000124")]
	public class CowController : MonoBehaviour
	{
		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Animation _cowAnimation;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioSource _mooCowAudioSource;

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0xE942F4", Offset = "0xE942F4", VA = "0xE942F4")]
		private void Start()
		{
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0xE942F8", Offset = "0xE942F8", VA = "0xE942F8")]
		public void PlayMooSound()
		{
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0xE942BC", Offset = "0xE942BC", VA = "0xE942BC")]
		public void GoMooCowGo()
		{
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0xE9432C", Offset = "0xE9432C", VA = "0xE9432C")]
		public CowController()
		{
		}
	}
	[Token(Token = "0x2000125")]
	public class PanelHMDFollower : MonoBehaviour
	{
		[Token(Token = "0x2000126")]
		[CompilerGenerated]
		private sealed class <LerpToHMD>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400056F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000570")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000571")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PanelHMDFollower <>4__this;

			[Token(Token = "0x4000572")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 <newPanelPosition>5__2;

			[Token(Token = "0x4000573")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <startTime>5__3;

			[Token(Token = "0x4000574")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float <endTime>5__4;

			[Token(Token = "0x170000D3")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005E3")]
				[Address(RVA = "0xE949AC", Offset = "0xE949AC", VA = "0xE949AC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D4")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005E5")]
				[Address(RVA = "0xE949F4", Offset = "0xE949F4", VA = "0xE949F4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005E0")]
			[Address(RVA = "0xE94724", Offset = "0xE94724", VA = "0xE94724")]
			[DebuggerHidden]
			public <LerpToHMD>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x60005E1")]
			[Address(RVA = "0xE947EC", Offset = "0xE947EC", VA = "0xE947EC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005E2")]
			[Address(RVA = "0xE947F0", Offset = "0xE947F0", VA = "0xE947F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005E4")]
			[Address(RVA = "0xE949B4", Offset = "0xE949B4", VA = "0xE949B4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000565")]
		private const float TOTAL_DURATION = 3f;

		[Token(Token = "0x4000566")]
		private const float HMD_MOVEMENT_THRESHOLD = 0.3f;

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _maxDistance;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _minDistance;

		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _minZDistance;

		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private OVRCameraRig _cameraRig;

		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 _panelInitialPosition;

		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Coroutine _coroutine;

		[Token(Token = "0x400056D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 _prevPos;

		[Token(Token = "0x400056E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 _lastMovedToPos;

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0xE94334", Offset = "0xE94334", VA = "0xE94334")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0xE943D4", Offset = "0xE943D4", VA = "0xE943D4")]
		private void Update()
		{
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0xE946E4", Offset = "0xE946E4", VA = "0xE946E4")]
		private Vector3 CalculateIdealAnchorPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0xE94670", Offset = "0xE94670", VA = "0xE94670")]
		[IteratorStateMachine(typeof(<LerpToHMD>d__13))]
		private IEnumerator LerpToHMD()
		{
			return null;
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0xE9474C", Offset = "0xE9474C", VA = "0xE9474C")]
		public PanelHMDFollower()
		{
		}
	}
	[Token(Token = "0x2000127")]
	public class SelectionCylinder : MonoBehaviour
	{
		[Token(Token = "0x2000128")]
		public enum SelectionState
		{
			[Token(Token = "0x400057C")]
			Off,
			[Token(Token = "0x400057D")]
			Selected,
			[Token(Token = "0x400057E")]
			Highlighted
		}

		[Token(Token = "0x4000575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MeshRenderer _selectionMeshRenderer;

		[Token(Token = "0x4000576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int _colorId;

		[Token(Token = "0x4000577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material[] _selectionMaterials;

		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Color[] _defaultSelectionColors;

		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Color[] _highlightColors;

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private SelectionState _currSelectionState;

		[Token(Token = "0x170000D5")]
		public SelectionState CurrSelectionState
		{
			[Token(Token = "0x60005E6")]
			[Address(RVA = "0xE949FC", Offset = "0xE949FC", VA = "0xE949FC")]
			get
			{
				return default(SelectionState);
			}
			[Token(Token = "0x60005E7")]
			[Address(RVA = "0xE94A04", Offset = "0xE94A04", VA = "0xE94A04")]
			set
			{
			}
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0xE94B58", Offset = "0xE94B58", VA = "0xE94B58")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0xE94D1C", Offset = "0xE94D1C", VA = "0xE94D1C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0xE94A78", Offset = "0xE94A78", VA = "0xE94A78")]
		private void AffectSelectionColor(Color[] newColors)
		{
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0xE94DE4", Offset = "0xE94DE4", VA = "0xE94DE4")]
		public SelectionCylinder()
		{
		}
	}
	[Token(Token = "0x2000129")]
	public class TrackSegment : MonoBehaviour
	{
		[Token(Token = "0x200012A")]
		public enum SegmentType
		{
			[Token(Token = "0x400058D")]
			Straight,
			[Token(Token = "0x400058E")]
			LeftTurn,
			[Token(Token = "0x400058F")]
			RightTurn,
			[Token(Token = "0x4000590")]
			Switch
		}

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SegmentType _segmentType;

		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MeshFilter _straight;

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MeshFilter _leftTurn;

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private MeshFilter _rightTurn;

		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float _gridSize;

		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int _subDivCount;

		[Token(Token = "0x4000585")]
		private const float _originalGridSize = 0.8f;

		[Token(Token = "0x4000586")]
		private const float _trackWidth = 0.15f;

		[Token(Token = "0x4000587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private GameObject _mesh;

		[Token(Token = "0x4000589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Pose _p1;

		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Pose _p2;

		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Pose _endPose;

		[Token(Token = "0x170000D6")]
		public float StartDistance
		{
			[Token(Token = "0x60005ED")]
			[Address(RVA = "0xE94E54", Offset = "0xE94E54", VA = "0xE94E54")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005EE")]
			[Address(RVA = "0xE94E5C", Offset = "0xE94E5C", VA = "0xE94E5C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000D7")]
		public float GridSize
		{
			[Token(Token = "0x60005EF")]
			[Address(RVA = "0xE94E64", Offset = "0xE94E64", VA = "0xE94E64")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005F0")]
			[Address(RVA = "0xE94E6C", Offset = "0xE94E6C", VA = "0xE94E6C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000D8")]
		public int SubDivCount
		{
			[Token(Token = "0x60005F1")]
			[Address(RVA = "0xE94E74", Offset = "0xE94E74", VA = "0xE94E74")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60005F2")]
			[Address(RVA = "0xE94E7C", Offset = "0xE94E7C", VA = "0xE94E7C")]
			set
			{
			}
		}

		[Token(Token = "0x170000D9")]
		public SegmentType Type
		{
			[Token(Token = "0x60005F3")]
			[Address(RVA = "0xE94E84", Offset = "0xE94E84", VA = "0xE94E84")]
			get
			{
				return default(SegmentType);
			}
		}

		[Token(Token = "0x170000DA")]
		public Pose EndPose
		{
			[Token(Token = "0x60005F4")]
			[Address(RVA = "0xE94E8C", Offset = "0xE94E8C", VA = "0xE94E8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DB")]
		public float Radius
		{
			[Token(Token = "0x60005F5")]
			[Address(RVA = "0xE95260", Offset = "0xE95260", VA = "0xE95260")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000DC")]
		public float SegmentLength
		{
			[Token(Token = "0x60005F7")]
			[Address(RVA = "0xE94EE8", Offset = "0xE94EE8", VA = "0xE94EE8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0xE95270", Offset = "0xE95270", VA = "0xE95270")]
		public float setGridSize(float size)
		{
			return default(float);
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0xE95288", Offset = "0xE95288", VA = "0xE95288")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0xE94F28", Offset = "0xE94F28", VA = "0xE94F28")]
		public void UpdatePose(float distanceIntoSegment, Pose pose)
		{
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0xE9528C", Offset = "0xE9528C", VA = "0xE9528C")]
		private void Update()
		{
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0xE95290", Offset = "0xE95290", VA = "0xE95290")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0xE952EC", Offset = "0xE952EC", VA = "0xE952EC")]
		private void DrawDebugLines()
		{
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0xE95C20", Offset = "0xE95C20", VA = "0xE95C20")]
		public void RegenerateTrackAndMesh()
		{
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0xE95EA4", Offset = "0xE95EA4", VA = "0xE95EA4")]
		public TrackSegment()
		{
		}
	}
	[Token(Token = "0x200012B")]
	public class TrainButtonVisualController : MonoBehaviour
	{
		[Token(Token = "0x200012C")]
		[CompilerGenerated]
		private sealed class <ResetPosition>d__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TrainButtonVisualController <>4__this;

			[Token(Token = "0x40005A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <startTime>5__2;

			[Token(Token = "0x40005A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <endTime>5__3;

			[Token(Token = "0x170000DD")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600060D")]
				[Address(RVA = "0xE969C8", Offset = "0xE969C8", VA = "0xE969C8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DE")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600060F")]
				[Address(RVA = "0xE96A10", Offset = "0xE96A10", VA = "0xE96A10", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600060A")]
			[Address(RVA = "0xE967FC", Offset = "0xE967FC", VA = "0xE967FC")]
			[DebuggerHidden]
			public <ResetPosition>d__26(int <>1__state)
			{
			}

			[Token(Token = "0x600060B")]
			[Address(RVA = "0xE9684C", Offset = "0xE9684C", VA = "0xE9684C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600060C")]
			[Address(RVA = "0xE96850", Offset = "0xE96850", VA = "0xE96850", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600060E")]
			[Address(RVA = "0xE969D0", Offset = "0xE969D0", VA = "0xE969D0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000591")]
		private const float LERP_TO_OLD_POS_DURATION = 1f;

		[Token(Token = "0x4000592")]
		private const float LOCAL_SIZE_HALVED = 0.5f;

		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MeshRenderer _meshRenderer;

		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MeshRenderer _glowRenderer;

		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ButtonController _buttonController;

		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _buttonContactColor;

		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Color _buttonActionColor;

		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private AudioSource _audioSource;

		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private AudioClip _actionSoundEffect;

		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform _buttonContactTransform;

		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _contactMaxDisplacementDistance;

		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material _buttonMaterial;

		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Color _buttonDefaultColor;

		[Token(Token = "0x400059E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int _materialColorId;

		[Token(Token = "0x400059F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private bool _buttonInContactOrActionStates;

		[Token(Token = "0x40005A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Coroutine _lerpToOldPositionCr;

		[Token(Token = "0x40005A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 _oldPosition;

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0xE96004", Offset = "0xE96004", VA = "0xE96004")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0xE960BC", Offset = "0xE960BC", VA = "0xE960BC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0xE9614C", Offset = "0xE9614C", VA = "0xE9614C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0xE96294", Offset = "0xE96294", VA = "0xE96294")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0xE96420", Offset = "0xE96420", VA = "0xE96420")]
		private void ActionOrInContactZoneStayEvent(ColliderZoneArgs collisionArgs)
		{
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0xE96530", Offset = "0xE96530", VA = "0xE96530")]
		private void InteractableStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0xE96734", Offset = "0xE96734", VA = "0xE96734")]
		private void PlaySound(AudioClip clip)
		{
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0xE96640", Offset = "0xE96640", VA = "0xE96640")]
		private void StopResetLerping()
		{
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0xE96654", Offset = "0xE96654", VA = "0xE96654")]
		private void LerpToOldPosition()
		{
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0xE96788", Offset = "0xE96788", VA = "0xE96788")]
		[IteratorStateMachine(typeof(<ResetPosition>d__26))]
		private IEnumerator ResetPosition()
		{
			return null;
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0xE96824", Offset = "0xE96824", VA = "0xE96824")]
		public TrainButtonVisualController()
		{
		}
	}
	[Token(Token = "0x200012D")]
	public class TrainCar : TrainCarBase
	{
		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TrainCarBase _parentLocomotive;

		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		protected float _distanceBehindParent;

		[Token(Token = "0x170000DF")]
		public float DistanceBehindParentScaled
		{
			[Token(Token = "0x6000610")]
			[Address(RVA = "0xE96A18", Offset = "0xE96A18", VA = "0xE96A18")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0xE96A28", Offset = "0xE96A28", VA = "0xE96A28", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0xE96A30", Offset = "0xE96A30", VA = "0xE96A30", Slot = "5")]
		public override void UpdatePosition()
		{
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0xE96D60", Offset = "0xE96D60", VA = "0xE96D60")]
		public TrainCar()
		{
		}
	}
	[Token(Token = "0x200012E")]
	public abstract class TrainCarBase : MonoBehaviour
	{
		[Token(Token = "0x40005A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Vector3 OFFSET;

		[Token(Token = "0x40005AA")]
		private const float WHEEL_RADIUS = 0.027f;

		[Token(Token = "0x40005AB")]
		private const float TWO_PI = (float)Math.PI * 2f;

		[Token(Token = "0x40005AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected Transform _frontWheels;

		[Token(Token = "0x40005AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected Transform _rearWheels;

		[Token(Token = "0x40005AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected TrainTrack _trainTrack;

		[Token(Token = "0x40005AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected Transform[] _individualWheels;

		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		protected float scale;

		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Pose _frontPose;

		[Token(Token = "0x40005B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Pose _rearPose;

		[Token(Token = "0x170000E0")]
		public float Distance
		{
			[Token(Token = "0x6000614")]
			[Address(RVA = "0xE96E5C", Offset = "0xE96E5C", VA = "0xE96E5C")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000615")]
			[Address(RVA = "0xE96E64", Offset = "0xE96E64", VA = "0xE96E64")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x170000E1")]
		public float Scale
		{
			[Token(Token = "0x6000616")]
			[Address(RVA = "0xE96E6C", Offset = "0xE96E6C", VA = "0xE96E6C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000617")]
			[Address(RVA = "0xE96E74", Offset = "0xE96E74", VA = "0xE96E74")]
			set
			{
			}
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0xE96A2C", Offset = "0xE96A2C", VA = "0xE96A2C", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0xE96E7C", Offset = "0xE96E7C", VA = "0xE96E7C")]
		public void UpdatePose(float distance, TrainCarBase train, Pose pose)
		{
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0xE96A6C", Offset = "0xE96A6C", VA = "0xE96A6C")]
		protected void UpdateCarPosition()
		{
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0xE96C7C", Offset = "0xE96C7C", VA = "0xE96C7C")]
		protected void RotateCarWheels()
		{
		}

		[Token(Token = "0x600061C")]
		public abstract void UpdatePosition();

		[Token(Token = "0x600061D")]
		[Address(RVA = "0xE96DC0", Offset = "0xE96DC0", VA = "0xE96DC0")]
		protected TrainCarBase()
		{
		}
	}
	[Token(Token = "0x200012F")]
	public class TrainCrossingController : MonoBehaviour
	{
		[Token(Token = "0x2000130")]
		[CompilerGenerated]
		private sealed class <AnimateCrossing>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TrainCrossingController <>4__this;

			[Token(Token = "0x40005C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float animationLength;

			[Token(Token = "0x40005C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <animationEndTime>5__2;

			[Token(Token = "0x40005C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <lightBlinkDuration>5__3;

			[Token(Token = "0x40005C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <lightBlinkStartTime>5__4;

			[Token(Token = "0x40005C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float <lightBlinkEndTime>5__5;

			[Token(Token = "0x40005C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Material <lightToBlinkOn>5__6;

			[Token(Token = "0x40005C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Material <lightToBlinkOff>5__7;

			[Token(Token = "0x40005C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private Color <onColor>5__8;

			[Token(Token = "0x40005C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Color <offColor>5__9;

			[Token(Token = "0x170000E2")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600062B")]
				[Address(RVA = "0xE9774C", Offset = "0xE9774C", VA = "0xE9774C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E3")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600062D")]
				[Address(RVA = "0xE97794", Offset = "0xE97794", VA = "0xE97794", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000628")]
			[Address(RVA = "0xE973C0", Offset = "0xE973C0", VA = "0xE973C0")]
			[DebuggerHidden]
			public <AnimateCrossing>d__15(int <>1__state)
			{
			}

			[Token(Token = "0x6000629")]
			[Address(RVA = "0xE97534", Offset = "0xE97534", VA = "0xE97534", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600062A")]
			[Address(RVA = "0xE97538", Offset = "0xE97538", VA = "0xE97538", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600062C")]
			[Address(RVA = "0xE97754", Offset = "0xE97754", VA = "0xE97754", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AudioSource _audioSource;

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioClip[] _crossingSounds;

		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MeshRenderer _lightSide1Renderer;

		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private MeshRenderer _lightSide2Renderer;

		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SelectionCylinder _selectionCylinder;

		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material _lightsSide1Mat;

		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Material _lightsSide2Mat;

		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int _colorId;

		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Coroutine _xingAnimationCr;

		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private InteractableTool _toolInteractingWithMe;

		[Token(Token = "0x600061F")]
		[Address(RVA = "0xE96FEC", Offset = "0xE96FEC", VA = "0xE96FEC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0xE97048", Offset = "0xE97048", VA = "0xE97048")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0xE97120", Offset = "0xE97120", VA = "0xE97120")]
		public void CrossingButtonStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0xE97274", Offset = "0xE97274", VA = "0xE97274")]
		private void Update()
		{
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0xE9717C", Offset = "0xE9717C", VA = "0xE9717C")]
		private void ActivateTrainCrossing()
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0xE9733C", Offset = "0xE9733C", VA = "0xE9733C")]
		[IteratorStateMachine(typeof(<AnimateCrossing>d__15))]
		private IEnumerator AnimateCrossing(float animationLength)
		{
			return null;
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0xE973E8", Offset = "0xE973E8", VA = "0xE973E8")]
		private void AffectMaterials(Material[] materials, Color newColor)
		{
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0xE97480", Offset = "0xE97480", VA = "0xE97480")]
		private void ToggleLightObjects(bool enableState)
		{
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0xE974DC", Offset = "0xE974DC", VA = "0xE974DC")]
		public TrainCrossingController()
		{
		}
	}
	[Token(Token = "0x2000131")]
	public class TrainLocomotive : TrainCarBase
	{
		[Token(Token = "0x2000132")]
		private enum EngineSoundState
		{
			[Token(Token = "0x40005E8")]
			Start,
			[Token(Token = "0x40005E9")]
			AccelerateOrSetProperSpeed,
			[Token(Token = "0x40005EA")]
			Stop
		}

		[Token(Token = "0x2000133")]
		[CompilerGenerated]
		private sealed class <StartStopTrain>d__34 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool startTrain;

			[Token(Token = "0x40005EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public TrainLocomotive <>4__this;

			[Token(Token = "0x40005EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <endSpeed>5__2;

			[Token(Token = "0x40005F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <timePeriodForSpeedChange>5__3;

			[Token(Token = "0x40005F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float <startTime>5__4;

			[Token(Token = "0x40005F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float <endTime>5__5;

			[Token(Token = "0x40005F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private float <startSpeed>5__6;

			[Token(Token = "0x170000E4")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000640")]
				[Address(RVA = "0xE9802C", Offset = "0xE9802C", VA = "0xE9802C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E5")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000642")]
				[Address(RVA = "0xE98074", Offset = "0xE98074", VA = "0xE98074", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600063D")]
			[Address(RVA = "0xE97A3C", Offset = "0xE97A3C", VA = "0xE97A3C")]
			[DebuggerHidden]
			public <StartStopTrain>d__34(int <>1__state)
			{
			}

			[Token(Token = "0x600063E")]
			[Address(RVA = "0xE97E04", Offset = "0xE97E04", VA = "0xE97E04", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600063F")]
			[Address(RVA = "0xE97E08", Offset = "0xE97E08", VA = "0xE97E08", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000641")]
			[Address(RVA = "0xE98034", Offset = "0xE98034", VA = "0xE98034", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40005CA")]
		private const float MIN_SPEED = 0.2f;

		[Token(Token = "0x40005CB")]
		private const float MAX_SPEED = 2.7f;

		[Token(Token = "0x40005CC")]
		private const float SMOKE_SPEED_MULTIPLIER = 8f;

		[Token(Token = "0x40005CD")]
		private const int MAX_PARTICLES_MULTIPLIER = 3;

		[Token(Token = "0x40005CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Range(0.2f, 2.7f)]
		protected float _initialSpeed;

		[Token(Token = "0x40005CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _startStopButton;

		[Token(Token = "0x40005D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _decreaseSpeedButton;

		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _increaseSpeedButton;

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _smokeButton;

		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _whistleButton;

		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _reverseButton;

		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private AudioSource _whistleAudioSource;

		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private AudioClip _whistleSound;

		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private AudioSource _engineAudioSource;

		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private AudioClip[] _accelerationSounds;

		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private AudioClip[] _decelerationSounds;

		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private AudioClip _startUpSound;

		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private AudioSource _smokeStackAudioSource;

		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private AudioClip _smokeSound;

		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private ParticleSystem _smoke1;

		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private ParticleSystem _smoke2;

		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private TrainCarBase[] _childCars;

		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool _isMoving;

		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE1")]
		private bool _reverse;

		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private float _currentSpeed;

		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float _speedDiv;

		[Token(Token = "0x40005E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float _standardRateOverTimeMultiplier;

		[Token(Token = "0x40005E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private int _standardMaxParticles;

		[Token(Token = "0x40005E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Coroutine _startStopTrainCr;

		[Token(Token = "0x600062E")]
		[Address(RVA = "0xE9779C", Offset = "0xE9779C", VA = "0xE9779C")]
		private void Start()
		{
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0xE978F8", Offset = "0xE978F8", VA = "0xE978F8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0xE97904", Offset = "0xE97904", VA = "0xE97904", Slot = "5")]
		public override void UpdatePosition()
		{
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0xE93EE0", Offset = "0xE93EE0", VA = "0xE93EE0")]
		public void StartStopStateChanged()
		{
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0xE97870", Offset = "0xE97870", VA = "0xE97870")]
		[IteratorStateMachine(typeof(<StartStopTrain>d__34))]
		private IEnumerator StartStopTrain(bool startTrain)
		{
			return null;
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0xE97A64", Offset = "0xE97A64", VA = "0xE97A64")]
		private float PlayEngineSound(EngineSoundState engineSoundState)
		{
			return default(float);
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0xE979DC", Offset = "0xE979DC", VA = "0xE979DC")]
		private void UpdateDistance()
		{
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0xE93F6C", Offset = "0xE93F6C", VA = "0xE93F6C")]
		public void DecreaseSpeedStateChanged()
		{
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0xE93FFC", Offset = "0xE93FFC", VA = "0xE93FFC")]
		public void IncreaseSpeedStateChanged()
		{
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0xE97C78", Offset = "0xE97C78", VA = "0xE97C78")]
		private void UpdateSmokeEmissionBasedOnSpeed()
		{
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0xE97D6C", Offset = "0xE97D6C", VA = "0xE97D6C")]
		private float GetCurrentSmokeEmission()
		{
			return default(float);
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0xE9408C", Offset = "0xE9408C", VA = "0xE9408C")]
		public void SmokeButtonStateChanged()
		{
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0xE94138", Offset = "0xE94138", VA = "0xE94138")]
		public void WhistleButtonStateChanged()
		{
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0xE94218", Offset = "0xE94218", VA = "0xE94218")]
		public void ReverseButtonStateChanged()
		{
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0xE97DA8", Offset = "0xE97DA8", VA = "0xE97DA8")]
		public TrainLocomotive()
		{
		}
	}
	[Token(Token = "0x2000134")]
	public class TrainTrack : MonoBehaviour
	{
		[Token(Token = "0x40005F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _gridSize;

		[Token(Token = "0x40005F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private int _subDivCount;

		[Token(Token = "0x40005F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _segmentParent;

		[Token(Token = "0x40005F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _trainParent;

		[Token(Token = "0x40005F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _regnerateTrackMeshOnAwake;

		[Token(Token = "0x40005F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float _trainLength;

		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TrackSegment[] _trackSegments;

		[Token(Token = "0x170000E6")]
		public float TrackLength
		{
			[Token(Token = "0x6000643")]
			[Address(RVA = "0xE9807C", Offset = "0xE9807C", VA = "0xE9807C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000644")]
			[Address(RVA = "0xE98084", Offset = "0xE98084", VA = "0xE98084")]
			private set
			{
			}
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0xE9808C", Offset = "0xE9808C", VA = "0xE9808C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0xE96EE4", Offset = "0xE96EE4", VA = "0xE96EE4")]
		public TrackSegment GetSegment(float distance)
		{
			return null;
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0xE98090", Offset = "0xE98090", VA = "0xE98090")]
		public void Regenerate()
		{
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0xE98288", Offset = "0xE98288", VA = "0xE98288")]
		private void SetScale(float ratio)
		{
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0xE98368", Offset = "0xE98368", VA = "0xE98368")]
		public TrainTrack()
		{
		}
	}
	[Token(Token = "0x2000135")]
	public class Pose
	{
		[Token(Token = "0x40005FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 Position;

		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion Rotation;

		[Token(Token = "0x600064A")]
		[Address(RVA = "0xE95F6C", Offset = "0xE95F6C", VA = "0xE95F6C")]
		public Pose()
		{
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0xE98384", Offset = "0xE98384", VA = "0xE98384")]
		public Pose(Vector3 position, Quaternion rotation)
		{
		}
	}
	[Token(Token = "0x2000136")]
	public class WindmillBladesController : MonoBehaviour
	{
		[Token(Token = "0x2000137")]
		[CompilerGenerated]
		private sealed class <LerpToSpeed>d__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000608")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000609")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400060A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WindmillBladesController <>4__this;

			[Token(Token = "0x400060B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float goalSpeed;

			[Token(Token = "0x400060C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <totalTime>5__2;

			[Token(Token = "0x400060D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <startSpeed>5__3;

			[Token(Token = "0x170000E8")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000658")]
				[Address(RVA = "0xE98978", Offset = "0xE98978", VA = "0xE98978", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E9")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600065A")]
				[Address(RVA = "0xE989C0", Offset = "0xE989C0", VA = "0xE989C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000655")]
			[Address(RVA = "0xE98660", Offset = "0xE98660", VA = "0xE98660")]
			[DebuggerHidden]
			public <LerpToSpeed>d__17(int <>1__state)
			{
			}

			[Token(Token = "0x6000656")]
			[Address(RVA = "0xE987D4", Offset = "0xE987D4", VA = "0xE987D4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000657")]
			[Address(RVA = "0xE987D8", Offset = "0xE987D8", VA = "0xE987D8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000659")]
			[Address(RVA = "0xE98980", Offset = "0xE98980", VA = "0xE98980", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000138")]
		[CompilerGenerated]
		private sealed class <PlaySoundDelayed>d__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400060E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400060F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000610")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WindmillBladesController <>4__this;

			[Token(Token = "0x4000611")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public AudioClip initial;

			[Token(Token = "0x4000612")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float timeDelayAfterInitial;

			[Token(Token = "0x4000613")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public AudioClip clip;

			[Token(Token = "0x170000EA")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600065E")]
				[Address(RVA = "0xE98A9C", Offset = "0xE98A9C", VA = "0xE98A9C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000EB")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000660")]
				[Address(RVA = "0xE98AE4", Offset = "0xE98AE4", VA = "0xE98AE4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600065B")]
			[Address(RVA = "0xE9873C", Offset = "0xE9873C", VA = "0xE9873C")]
			[DebuggerHidden]
			public <PlaySoundDelayed>d__18(int <>1__state)
			{
			}

			[Token(Token = "0x600065C")]
			[Address(RVA = "0xE989C8", Offset = "0xE989C8", VA = "0xE989C8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600065D")]
			[Address(RVA = "0xE989CC", Offset = "0xE989CC", VA = "0xE989CC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600065F")]
			[Address(RVA = "0xE98AA4", Offset = "0xE98AA4", VA = "0xE98AA4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40005FD")]
		private const float MAX_TIME = 1f;

		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AudioSource _audioSource;

		[Token(Token = "0x40005FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioClip _windMillRotationSound;

		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AudioClip _windMillStartSound;

		[Token(Token = "0x4000601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AudioClip _windMillStopSound;

		[Token(Token = "0x4000603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float _currentSpeed;

		[Token(Token = "0x4000604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Coroutine _lerpSpeedCoroutine;

		[Token(Token = "0x4000605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Coroutine _audioChangeCr;

		[Token(Token = "0x4000606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion _originalRotation;

		[Token(Token = "0x4000607")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float _rotAngle;

		[Token(Token = "0x170000E7")]
		public bool IsMoving
		{
			[Token(Token = "0x600064C")]
			[Address(RVA = "0xE983E8", Offset = "0xE983E8", VA = "0xE983E8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600064D")]
			[Address(RVA = "0xE983F0", Offset = "0xE983F0", VA = "0xE983F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0xE983FC", Offset = "0xE983FC", VA = "0xE983FC")]
		private void Start()
		{
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0xE9842C", Offset = "0xE9842C", VA = "0xE9842C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0xE9856C", Offset = "0xE9856C", VA = "0xE9856C")]
		public void SetMoveState(bool newMoveState, float goalSpeed)
		{
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0xE985DC", Offset = "0xE985DC", VA = "0xE985DC")]
		[IteratorStateMachine(typeof(<LerpToSpeed>d__17))]
		private IEnumerator LerpToSpeed(float goalSpeed)
		{
			return null;
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0xE98688", Offset = "0xE98688", VA = "0xE98688")]
		[IteratorStateMachine(typeof(<PlaySoundDelayed>d__18))]
		private IEnumerator PlaySoundDelayed(AudioClip initial, AudioClip clip, float timeDelayAfterInitial)
		{
			return null;
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0xE98764", Offset = "0xE98764", VA = "0xE98764")]
		private void PlaySound(AudioClip clip, bool loop = false)
		{
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0xE987CC", Offset = "0xE987CC", VA = "0xE987CC")]
		public WindmillBladesController()
		{
		}
	}
	[Token(Token = "0x2000139")]
	public class WindmillController : MonoBehaviour
	{
		[Token(Token = "0x4000614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _startStopButton;

		[Token(Token = "0x4000615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _maxSpeed;

		[Token(Token = "0x4000616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SelectionCylinder _selectionCylinder;

		[Token(Token = "0x4000617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WindmillBladesController _bladesRotation;

		[Token(Token = "0x4000618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private InteractableTool _toolInteractingWithMe;

		[Token(Token = "0x6000661")]
		[Address(RVA = "0xE98AEC", Offset = "0xE98AEC", VA = "0xE98AEC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0xE98B60", Offset = "0xE98B60", VA = "0xE98B60")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0xE98C28", Offset = "0xE98C28", VA = "0xE98C28")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0xE98D38", Offset = "0xE98D38", VA = "0xE98D38")]
		private void StartStopStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0xE98DB4", Offset = "0xE98DB4", VA = "0xE98DB4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0xE98E7C", Offset = "0xE98E7C", VA = "0xE98E7C")]
		public WindmillController()
		{
		}
	}
	[Token(Token = "0x200013A")]
	public enum EUiDisplayType
	{
		[Token(Token = "0x400061A")]
		EUDT_WorldGeoQuad,
		[Token(Token = "0x400061B")]
		EUDT_OverlayQuad,
		[Token(Token = "0x400061C")]
		EUDT_None,
		[Token(Token = "0x400061D")]
		EUDT_MaxDislayTypes
	}
	[Token(Token = "0x200013B")]
	public class OVROverlaySample : MonoBehaviour
	{
		[Token(Token = "0x200013C")]
		[CompilerGenerated]
		private sealed class <WaitforOVROverlay>d__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000636")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000637")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000638")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OVROverlaySample <>4__this;

			[Token(Token = "0x170000EC")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600067A")]
				[Address(RVA = "0xE9A50C", Offset = "0xE9A50C", VA = "0xE9A50C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000ED")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600067C")]
				[Address(RVA = "0xE9A554", Offset = "0xE9A554", VA = "0xE9A554", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000677")]
			[Address(RVA = "0xE99B9C", Offset = "0xE99B9C", VA = "0xE99B9C")]
			[DebuggerHidden]
			public <WaitforOVROverlay>d__30(int <>1__state)
			{
			}

			[Token(Token = "0x6000678")]
			[Address(RVA = "0xE9A310", Offset = "0xE9A310", VA = "0xE9A310", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000679")]
			[Address(RVA = "0xE9A314", Offset = "0xE9A314", VA = "0xE9A314", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600067B")]
			[Address(RVA = "0xE9A514", Offset = "0xE9A514", VA = "0xE9A514", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400061E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool inMenu;

		[Token(Token = "0x400061F")]
		private const string ovrOverlayID = "OVROverlayID";

		[Token(Token = "0x4000620")]
		private const string applicationID = "ApplicationID";

		[Token(Token = "0x4000621")]
		private const string noneID = "NoneID";

		[Token(Token = "0x4000622")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Toggle applicationRadioButton;

		[Token(Token = "0x4000623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Toggle noneRadioButton;

		[Token(Token = "0x4000624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Header("App vs Compositor Comparison Settings")]
		public GameObject mainCamera;

		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject uiCamera;

		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public GameObject uiGeoParent;

		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public GameObject worldspaceGeoParent;

		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public OVROverlay cameraRenderOverlay;

		[Token(Token = "0x4000629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public OVROverlay renderingLabelOverlay;

		[Token(Token = "0x400062A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Texture applicationLabelTexture;

		[Token(Token = "0x400062B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Texture compositorLabelTexture;

		[Token(Token = "0x400062C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Header("Level Loading Sim Settings")]
		public GameObject prefabForLevelLoadSim;

		[Token(Token = "0x400062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public OVROverlay cubemapOverlay;

		[Token(Token = "0x400062E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public OVROverlay loadingTextQuadOverlay;

		[Token(Token = "0x400062F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float distanceFromCamToLoadText;

		[Token(Token = "0x4000630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float cubeSpawnRadius;

		[Token(Token = "0x4000631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float heightBetweenItems;

		[Token(Token = "0x4000632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public int numObjectsPerLevel;

		[Token(Token = "0x4000633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public int numLevels;

		[Token(Token = "0x4000634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public int numLoopsTrigger;

		[Token(Token = "0x4000635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private List<GameObject> spawnedCubes;

		[Token(Token = "0x6000667")]
		[Address(RVA = "0xE98E8C", Offset = "0xE98E8C", VA = "0xE98E8C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0xE996CC", Offset = "0xE996CC", VA = "0xE996CC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0xE997F4", Offset = "0xE997F4", VA = "0xE997F4")]
		private void ActivateWorldGeo()
		{
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0xE99924", Offset = "0xE99924", VA = "0xE99924")]
		private void ActivateOVROverlay()
		{
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0xE99A54", Offset = "0xE99A54", VA = "0xE99A54")]
		private void ActivateNone()
		{
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0xE997D4", Offset = "0xE997D4", VA = "0xE997D4")]
		private void TriggerLoad()
		{
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0xE99B28", Offset = "0xE99B28", VA = "0xE99B28")]
		[IteratorStateMachine(typeof(<WaitforOVROverlay>d__30))]
		private IEnumerator WaitforOVROverlay()
		{
			return null;
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0xE99BC4", Offset = "0xE99BC4", VA = "0xE99BC4")]
		private void TriggerUnload()
		{
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0xE992FC", Offset = "0xE992FC", VA = "0xE992FC")]
		private void CameraAndRenderTargetSetup()
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0xE99D0C", Offset = "0xE99D0C", VA = "0xE99D0C")]
		private void SimulateLevelLoad()
		{
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0xE99BEC", Offset = "0xE99BEC", VA = "0xE99BEC")]
		private void ClearObjects()
		{
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0xE9A094", Offset = "0xE9A094", VA = "0xE9A094")]
		public void RadioPressed(string radioLabel, string group, Toggle t)
		{
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0xE9A180", Offset = "0xE9A180", VA = "0xE9A180")]
		public OVROverlaySample()
		{
		}
	}
}
namespace OVRTouchSample
{
	[Token(Token = "0x200013D")]
	[RequireComponent(typeof(OVRGrabber))]
	public class Hand : MonoBehaviour
	{
		[Token(Token = "0x4000639")]
		public const string ANIM_LAYER_NAME_POINT = "Point Layer";

		[Token(Token = "0x400063A")]
		public const string ANIM_LAYER_NAME_THUMB = "Thumb Layer";

		[Token(Token = "0x400063B")]
		public const string ANIM_PARAM_NAME_FLEX = "Flex";

		[Token(Token = "0x400063C")]
		public const string ANIM_PARAM_NAME_POSE = "Pose";

		[Token(Token = "0x400063D")]
		public const float THRESH_COLLISION_FLEX = 0.9f;

		[Token(Token = "0x400063E")]
		public const float INPUT_RATE_CHANGE = 20f;

		[Token(Token = "0x400063F")]
		public const float COLLIDER_SCALE_MIN = 0.01f;

		[Token(Token = "0x4000640")]
		public const float COLLIDER_SCALE_MAX = 1f;

		[Token(Token = "0x4000641")]
		public const float COLLIDER_SCALE_PER_SECOND = 1f;

		[Token(Token = "0x4000642")]
		public const float TRIGGER_DEBOUNCE_TIME = 0.05f;

		[Token(Token = "0x4000643")]
		public const float THUMB_DEBOUNCE_TIME = 0.15f;

		[Token(Token = "0x4000644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private OVRInput.Controller m_controller;

		[Token(Token = "0x4000645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Animator m_animator;

		[Token(Token = "0x4000646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private HandPose m_defaultGrabPose;

		[Token(Token = "0x4000647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Collider[] m_colliders;

		[Token(Token = "0x4000648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool m_collisionEnabled;

		[Token(Token = "0x4000649")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private OVRGrabber m_grabber;

		[Token(Token = "0x400064A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<Renderer> m_showAfterInputFocusAcquired;

		[Token(Token = "0x400064B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int m_animLayerIndexThumb;

		[Token(Token = "0x400064C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int m_animLayerIndexPoint;

		[Token(Token = "0x400064D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int m_animParamIndexFlex;

		[Token(Token = "0x400064E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int m_animParamIndexPose;

		[Token(Token = "0x400064F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool m_isPointing;

		[Token(Token = "0x4000650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool m_isGivingThumbsUp;

		[Token(Token = "0x4000651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float m_pointBlend;

		[Token(Token = "0x4000652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float m_thumbsUpBlend;

		[Token(Token = "0x4000653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool m_restoreOnInputAcquired;

		[Token(Token = "0x4000654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float m_collisionScaleCurrent;

		[Token(Token = "0x600067D")]
		[Address(RVA = "0xE9A55C", Offset = "0xE9A55C", VA = "0xE9A55C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0xE9A5B4", Offset = "0xE9A5B4", VA = "0xE9A5B4")]
		private void Start()
		{
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0xE9AA04", Offset = "0xE9AA04", VA = "0xE9AA04")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0xE9AAF0", Offset = "0xE9AAF0", VA = "0xE9AAF0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0xE9AC54", Offset = "0xE9AC54", VA = "0xE9AC54")]
		private void UpdateCapTouchStates()
		{
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0xE9AF24", Offset = "0xE9AF24", VA = "0xE9AF24")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0xE9B008", Offset = "0xE9B008", VA = "0xE9B008")]
		private void OnInputFocusLost()
		{
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0xE9B1B8", Offset = "0xE9B1B8", VA = "0xE9B1B8")]
		private void OnInputFocusAcquired()
		{
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0xE9ACE0", Offset = "0xE9ACE0", VA = "0xE9ACE0")]
		private float InputValueRateChange(bool isDown, float value)
		{
			return default(float);
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0xE9AD34", Offset = "0xE9AD34", VA = "0xE9AD34")]
		private void UpdateAnimStates()
		{
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0xE9A8C4", Offset = "0xE9A8C4", VA = "0xE9A8C4")]
		private void CollisionEnable(bool enabled)
		{
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0xE9B2DC", Offset = "0xE9B2DC", VA = "0xE9B2DC")]
		public Hand()
		{
		}
	}
	[Token(Token = "0x200013F")]
	public enum HandPoseId
	{
		[Token(Token = "0x4000658")]
		Default,
		[Token(Token = "0x4000659")]
		Generic,
		[Token(Token = "0x400065A")]
		PingPongBall,
		[Token(Token = "0x400065B")]
		Controller
	}
	[Token(Token = "0x2000140")]
	public class HandPose : MonoBehaviour
	{
		[Token(Token = "0x400065C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_allowPointing;

		[Token(Token = "0x400065D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[SerializeField]
		private bool m_allowThumbsUp;

		[Token(Token = "0x400065E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private HandPoseId m_poseId;

		[Token(Token = "0x170000EE")]
		public bool AllowPointing
		{
			[Token(Token = "0x600068C")]
			[Address(RVA = "0xE9B394", Offset = "0xE9B394", VA = "0xE9B394")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000EF")]
		public bool AllowThumbsUp
		{
			[Token(Token = "0x600068D")]
			[Address(RVA = "0xE9B39C", Offset = "0xE9B39C", VA = "0xE9B39C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000F0")]
		public HandPoseId PoseId
		{
			[Token(Token = "0x600068E")]
			[Address(RVA = "0xE9B3A4", Offset = "0xE9B3A4", VA = "0xE9B3A4")]
			get
			{
				return default(HandPoseId);
			}
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0xE9B3AC", Offset = "0xE9B3AC", VA = "0xE9B3AC")]
		public HandPose()
		{
		}
	}
	[Token(Token = "0x2000141")]
	public class TouchController : MonoBehaviour
	{
		[Token(Token = "0x400065F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private OVRInput.Controller m_controller;

		[Token(Token = "0x4000660")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Animator m_animator;

		[Token(Token = "0x4000661")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool m_restoreOnInputAcquired;

		[Token(Token = "0x6000690")]
		[Address(RVA = "0xE9B3B4", Offset = "0xE9B3B4", VA = "0xE9B3B4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0xE9B680", Offset = "0xE9B680", VA = "0xE9B680")]
		private void OnInputFocusLost()
		{
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0xE9B6D0", Offset = "0xE9B6D0", VA = "0xE9B6D0")]
		private void OnInputFocusAcquired()
		{
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0xE9B708", Offset = "0xE9B708", VA = "0xE9B708")]
		public TouchController()
		{
		}
	}
}
namespace Hellmade.Net
{
	[Token(Token = "0x2000142")]
	public enum NetCheckResponseType
	{
		[Token(Token = "0x4000663")]
		HTTPStatusCode,
		[Token(Token = "0x4000664")]
		ResponseContent,
		[Token(Token = "0x4000665")]
		ResponseContainContent
	}
	[Token(Token = "0x2000143")]
	public enum NetStatus
	{
		[Token(Token = "0x4000667")]
		PendingCheck,
		[Token(Token = "0x4000668")]
		NoDNSConnection,
		[Token(Token = "0x4000669")]
		WalledGarden,
		[Token(Token = "0x400066A")]
		Connected
	}
	[Token(Token = "0x2000144")]
	public class ErrorInfo
	{
		[Token(Token = "0x170000F1")]
		public bool IsError
		{
			[Token(Token = "0x6000694")]
			[Address(RVA = "0xE9B710", Offset = "0xE9B710", VA = "0xE9B710")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000695")]
			[Address(RVA = "0xE9B718", Offset = "0xE9B718", VA = "0xE9B718")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000F2")]
		public bool IsNetworkError
		{
			[Token(Token = "0x6000696")]
			[Address(RVA = "0xE9B724", Offset = "0xE9B724", VA = "0xE9B724")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000697")]
			[Address(RVA = "0xE9B72C", Offset = "0xE9B72C", VA = "0xE9B72C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000F3")]
		public bool IsHTTPError
		{
			[Token(Token = "0x6000698")]
			[Address(RVA = "0xE9B738", Offset = "0xE9B738", VA = "0xE9B738")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000699")]
			[Address(RVA = "0xE9B740", Offset = "0xE9B740", VA = "0xE9B740")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000F4")]
		public string ErrorMsg
		{
			[Token(Token = "0x600069A")]
			[Address(RVA = "0xE9B74C", Offset = "0xE9B74C", VA = "0xE9B74C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600069B")]
			[Address(RVA = "0xE9B754", Offset = "0xE9B754", VA = "0xE9B754")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0xE9B75C", Offset = "0xE9B75C", VA = "0xE9B75C")]
		public ErrorInfo()
		{
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0xE9B7BC", Offset = "0xE9B7BC", VA = "0xE9B7BC")]
		public ErrorInfo(bool isNetworkError, bool isHTTPError, string errorMsg)
		{
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0xE9B820", Offset = "0xE9B820", VA = "0xE9B820", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000145")]
	[HelpURL("http://www.hellmadegames.com/Projects/eazy-netchecker/docs/manual/Manual.pdf")]
	[DisallowMultipleComponent]
	public class EazyNetChecker : MonoBehaviour
	{
		[Token(Token = "0x2000146")]
		public delegate void Event();

		[Token(Token = "0x2000147")]
		[CompilerGenerated]
		private sealed class <CheckConnectionCoroutine>d__101 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000689")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400068A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x17000105")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006E3")]
				[Address(RVA = "0xE9F264", Offset = "0xE9F264", VA = "0xE9F264", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000106")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006E5")]
				[Address(RVA = "0xE9F2AC", Offset = "0xE9F2AC", VA = "0xE9F2AC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006E0")]
			[Address(RVA = "0xE9E974", Offset = "0xE9E974", VA = "0xE9E974")]
			[DebuggerHidden]
			public <CheckConnectionCoroutine>d__101(int <>1__state)
			{
			}

			[Token(Token = "0x60006E1")]
			[Address(RVA = "0xE9EB78", Offset = "0xE9EB78", VA = "0xE9EB78", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006E2")]
			[Address(RVA = "0xE9EB7C", Offset = "0xE9EB7C", VA = "0xE9EB7C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006E4")]
			[Address(RVA = "0xE9F26C", Offset = "0xE9F26C", VA = "0xE9F26C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static EazyNetChecker instance;

		[Token(Token = "0x400067A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<NetCheckMethod> methods;

		[Token(Token = "0x400067B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<NetCheckMethod> customMethods;

		[Token(Token = "0x400067C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool initialized;

		[Token(Token = "0x400067D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private NetCheckMethod selectedMethod;

		[Token(Token = "0x400067E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		public bool platformDefaultSelected;

		[Token(Token = "0x400067F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static Coroutine checkerCoroutine;

		[Token(Token = "0x4000680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static bool keepChecking;

		[Token(Token = "0x4000681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private static float checkStartedTime;

		[Token(Token = "0x4000682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static float nextCheckTime;

		[Token(Token = "0x4000683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private static bool stopOnSuccess;

		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float timeout;

		[Token(Token = "0x4000685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool continueCheckAfterTimeout;

		[Token(Token = "0x4000686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float checkIntervalNormal;

		[Token(Token = "0x4000687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float checkIntervalOnNoConnection;

		[Token(Token = "0x4000688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private bool showDebug;

		[Token(Token = "0x170000F5")]
		public static float CheckInterval
		{
			[Token(Token = "0x60006A7")]
			[Address(RVA = "0xE9BF88", Offset = "0xE9BF88", VA = "0xE9BF88")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000F6")]
		public static float CheckIntervalNormal
		{
			[Token(Token = "0x60006A8")]
			[Address(RVA = "0xE9C09C", Offset = "0xE9C09C", VA = "0xE9C09C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006A9")]
			[Address(RVA = "0xE9C2C8", Offset = "0xE9C2C8", VA = "0xE9C2C8")]
			set
			{
			}
		}

		[Token(Token = "0x170000F7")]
		public static float CheckIntervalOnNoConnection
		{
			[Token(Token = "0x60006AA")]
			[Address(RVA = "0xE9C040", Offset = "0xE9C040", VA = "0xE9C040")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006AB")]
			[Address(RVA = "0xE9C338", Offset = "0xE9C338", VA = "0xE9C338")]
			set
			{
			}
		}

		[Token(Token = "0x170000F8")]
		public static float Timeout
		{
			[Token(Token = "0x60006AC")]
			[Address(RVA = "0xE9C3A8", Offset = "0xE9C3A8", VA = "0xE9C3A8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006AD")]
			[Address(RVA = "0xE9C404", Offset = "0xE9C404", VA = "0xE9C404")]
			set
			{
			}
		}

		[Token(Token = "0x170000F9")]
		public static bool ContinueCheckAfterTimeout
		{
			[Token(Token = "0x60006AE")]
			[Address(RVA = "0xE9C46C", Offset = "0xE9C46C", VA = "0xE9C46C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006AF")]
			[Address(RVA = "0xE9C4C8", Offset = "0xE9C4C8", VA = "0xE9C4C8")]
			set
			{
			}
		}

		[Token(Token = "0x170000FA")]
		public static bool ShowDebug
		{
			[Token(Token = "0x60006B0")]
			[Address(RVA = "0xE9C52C", Offset = "0xE9C52C", VA = "0xE9C52C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006B1")]
			[Address(RVA = "0xE9C588", Offset = "0xE9C588", VA = "0xE9C588")]
			set
			{
			}
		}

		[Token(Token = "0x170000FB")]
		public static bool PlatformDefaultSelected
		{
			[Token(Token = "0x60006B2")]
			[Address(RVA = "0xE9C5EC", Offset = "0xE9C5EC", VA = "0xE9C5EC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000FC")]
		public static NetStatus Status
		{
			[Token(Token = "0x60006B3")]
			[Address(RVA = "0xE9C648", Offset = "0xE9C648", VA = "0xE9C648")]
			[CompilerGenerated]
			get
			{
				return default(NetStatus);
			}
			[Token(Token = "0x60006B4")]
			[Address(RVA = "0xE9C6A0", Offset = "0xE9C6A0", VA = "0xE9C6A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000FD")]
		public static ErrorInfo ErrorInfo
		{
			[Token(Token = "0x60006B5")]
			[Address(RVA = "0xE9C6FC", Offset = "0xE9C6FC", VA = "0xE9C6FC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60006B6")]
			[Address(RVA = "0xE9C754", Offset = "0xE9C754", VA = "0xE9C754")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000FE")]
		public static NetworkReachability ReachabilityType
		{
			[Token(Token = "0x60006B7")]
			[Address(RVA = "0xE9C7B4", Offset = "0xE9C7B4", VA = "0xE9C7B4")]
			get
			{
				return default(NetworkReachability);
			}
		}

		[Token(Token = "0x170000FF")]
		public static bool IsChecking
		{
			[Token(Token = "0x60006B8")]
			[Address(RVA = "0xE9C7BC", Offset = "0xE9C7BC", VA = "0xE9C7BC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006B9")]
			[Address(RVA = "0xE9C814", Offset = "0xE9C814", VA = "0xE9C814")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000100")]
		public static float NextCheckRemaingSeconds
		{
			[Token(Token = "0x60006BA")]
			[Address(RVA = "0xE9C870", Offset = "0xE9C870", VA = "0xE9C870")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000101")]
		public static float Runtime
		{
			[Token(Token = "0x60006BB")]
			[Address(RVA = "0xE9C954", Offset = "0xE9C954", VA = "0xE9C954")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006BC")]
			[Address(RVA = "0xE9C9AC", Offset = "0xE9C9AC", VA = "0xE9C9AC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000102")]
		public static float Uptime
		{
			[Token(Token = "0x60006BD")]
			[Address(RVA = "0xE9CA10", Offset = "0xE9CA10", VA = "0xE9CA10")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006BE")]
			[Address(RVA = "0xE9CA68", Offset = "0xE9CA68", VA = "0xE9CA68")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000103")]
		public static float Downtime
		{
			[Token(Token = "0x60006BF")]
			[Address(RVA = "0xE9CACC", Offset = "0xE9CACC", VA = "0xE9CACC")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006C0")]
			[Address(RVA = "0xE9CB24", Offset = "0xE9CB24", VA = "0xE9CB24")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000104")]
		public static EazyNetChecker Instance
		{
			[Token(Token = "0x60006C1")]
			[Address(RVA = "0xE9C0F8", Offset = "0xE9C0F8", VA = "0xE9C0F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1400001A")]
		public static event Event OnCheckStarted
		{
			[Token(Token = "0x600069F")]
			[Address(RVA = "0xE9B8B0", Offset = "0xE9B8B0", VA = "0xE9B8B0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60006A0")]
			[Address(RVA = "0xE9B988", Offset = "0xE9B988", VA = "0xE9B988")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400001B")]
		public static event Event OnCheckFinished
		{
			[Token(Token = "0x60006A1")]
			[Address(RVA = "0xE9BA60", Offset = "0xE9BA60", VA = "0xE9BA60")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60006A2")]
			[Address(RVA = "0xE9BB3C", Offset = "0xE9BB3C", VA = "0xE9BB3C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400001C")]
		public static event Event OnConnectionStatusChanged
		{
			[Token(Token = "0x60006A3")]
			[Address(RVA = "0xE9BC18", Offset = "0xE9BC18", VA = "0xE9BC18")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60006A4")]
			[Address(RVA = "0xE9BCF4", Offset = "0xE9BCF4", VA = "0xE9BCF4")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400001D")]
		public static event Event OnCheckTimeout
		{
			[Token(Token = "0x60006A5")]
			[Address(RVA = "0xE9BDD0", Offset = "0xE9BDD0", VA = "0xE9BDD0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60006A6")]
			[Address(RVA = "0xE9BEAC", Offset = "0xE9BEAC", VA = "0xE9BEAC")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0xE9CCC0", Offset = "0xE9CCC0", VA = "0xE9CCC0", Slot = "4")]
		public virtual void Awake()
		{
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0xE9CE34", Offset = "0xE9CE34", VA = "0xE9CE34")]
		private void Update()
		{
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0xE9CB88", Offset = "0xE9CB88", VA = "0xE9CB88")]
		public static void Init()
		{
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0xE9D404", Offset = "0xE9D404", VA = "0xE9D404")]
		public static void SetStandardCheckMethods()
		{
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0xE9DF1C", Offset = "0xE9DF1C", VA = "0xE9DF1C")]
		public static List<NetCheckMethod> GetStandardMethods()
		{
			return null;
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0xE9DF78", Offset = "0xE9DF78", VA = "0xE9DF78")]
		public static NetCheckMethod GetGoogle204Method()
		{
			return null;
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0xE9DFF4", Offset = "0xE9DFF4", VA = "0xE9DFF4")]
		public static NetCheckMethod GetMicrosoftConnectTestMethod()
		{
			return null;
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0xE9E070", Offset = "0xE9E070", VA = "0xE9E070")]
		public static NetCheckMethod GetAppleHotspotMethod()
		{
			return null;
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0xE9E0EC", Offset = "0xE9E0EC", VA = "0xE9E0EC")]
		public static List<NetCheckMethod> GetCustomMethods()
		{
			return null;
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0xE9E148", Offset = "0xE9E148", VA = "0xE9E148")]
		public static NetCheckMethod GetCustomMethod(string methodID)
		{
			return null;
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0xE9E318", Offset = "0xE9E318", VA = "0xE9E318")]
		public static NetCheckMethod GetDefaultMethod()
		{
			return null;
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0xE9DC00", Offset = "0xE9DC00", VA = "0xE9DC00")]
		public static NetCheckMethod GetSelectedMethod()
		{
			return null;
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0xE9E46C", Offset = "0xE9E46C", VA = "0xE9E46C")]
		public static void AddCustomMethod(NetCheckMethod method)
		{
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0xE9E4C4", Offset = "0xE9E4C4", VA = "0xE9E4C4")]
		public static void AddCustomMethod(NetCheckMethod method, bool use)
		{
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0xE9E678", Offset = "0xE9E678", VA = "0xE9E678")]
		public static void UseMethod(NetCheckMethod method)
		{
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0xE9E3CC", Offset = "0xE9E3CC", VA = "0xE9E3CC")]
		public static void UseDefaultMethod()
		{
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0xE9DD1C", Offset = "0xE9DD1C", VA = "0xE9DD1C")]
		public static void UseGoogle204Method()
		{
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0xE9DE1C", Offset = "0xE9DE1C", VA = "0xE9DE1C")]
		public static void UseMicrosoftConnectTestMethod()
		{
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0xE9DE9C", Offset = "0xE9DE9C", VA = "0xE9DE9C")]
		public static void UseAppleHotspotMethod()
		{
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0xE9E7D4", Offset = "0xE9E7D4", VA = "0xE9E7D4")]
		public static void StartConnectionCheck()
		{
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0xE9D2D0", Offset = "0xE9D2D0", VA = "0xE9D2D0")]
		public static void StartConnectionCheck(bool stopOnSuccess, bool interruptActiveChecks)
		{
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0xE9D354", Offset = "0xE9D354", VA = "0xE9D354")]
		public static void StopConnectionCheck()
		{
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0xE9E828", Offset = "0xE9E828", VA = "0xE9E828")]
		public static void CheckConnection()
		{
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0xE9E914", Offset = "0xE9E914", VA = "0xE9E914")]
		[IteratorStateMachine(typeof(<CheckConnectionCoroutine>d__101))]
		private static IEnumerator CheckConnectionCoroutine()
		{
			return null;
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0xE9E99C", Offset = "0xE9E99C", VA = "0xE9E99C")]
		public EazyNetChecker()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000148")]
	public class NetCheckMethod
	{
		[Token(Token = "0x2000149")]
		[CompilerGenerated]
		private sealed class <Check>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000693")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000694")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000695")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public NetCheckMethod <>4__this;

			[Token(Token = "0x4000696")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <startMillisecondsTime>5__2;

			[Token(Token = "0x4000697")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UnityWebRequest <www>5__3;

			[Token(Token = "0x17000107")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006F3")]
				[Address(RVA = "0xE9F954", Offset = "0xE9F954", VA = "0xE9F954", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000108")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006F5")]
				[Address(RVA = "0xE9F99C", Offset = "0xE9F99C", VA = "0xE9F99C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006F0")]
			[Address(RVA = "0xE9F328", Offset = "0xE9F328", VA = "0xE9F328")]
			[DebuggerHidden]
			public <Check>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x60006F1")]
			[Address(RVA = "0xE9F5C8", Offset = "0xE9F5C8", VA = "0xE9F5C8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006F2")]
			[Address(RVA = "0xE9F5CC", Offset = "0xE9F5CC", VA = "0xE9F5CC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006F4")]
			[Address(RVA = "0xE9F95C", Offset = "0xE9F95C", VA = "0xE9F95C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400068B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string id;

		[Token(Token = "0x400068C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string link;

		[Token(Token = "0x400068D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public NetCheckResponseType responseType;

		[Token(Token = "0x400068E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public HttpStatusCode expectedHttpStatusCode;

		[Token(Token = "0x400068F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string expectedContent;

		[Token(Token = "0x4000690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private NetStatus status;

		[Token(Token = "0x4000691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ErrorInfo errorInfo;

		[Token(Token = "0x4000692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float responseTime;

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0xE9DB68", Offset = "0xE9DB68", VA = "0xE9DB68")]
		public NetCheckMethod(string id, string link, HttpStatusCode expectedHttpStatusCode)
		{
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0xE9DD9C", Offset = "0xE9DD9C", VA = "0xE9DD9C")]
		public NetCheckMethod(string id, string link, string expectedContent, bool contentContain = false)
		{
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0xE9F2B4", Offset = "0xE9F2B4", VA = "0xE9F2B4")]
		public NetCheckMethod(string id, string link, NetCheckResponseType responseType, HttpStatusCode expectedHttpStatusCode, string expectedContent)
		{
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0xE9F1F0", Offset = "0xE9F1F0", VA = "0xE9F1F0")]
		[IteratorStateMachine(typeof(<Check>d__11))]
		public IEnumerator Check()
		{
			return null;
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0xE9F350", Offset = "0xE9F350", VA = "0xE9F350")]
		public NetStatus GetCheckStatus()
		{
			return default(NetStatus);
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0xE9F358", Offset = "0xE9F358", VA = "0xE9F358")]
		public ErrorInfo GetErrorInfo()
		{
			return null;
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0xE9F360", Offset = "0xE9F360", VA = "0xE9F360")]
		public float GetResponseTime()
		{
			return default(float);
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0xE9F368", Offset = "0xE9F368", VA = "0xE9F368", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0xE9F3B4", Offset = "0xE9F3B4", VA = "0xE9F3B4", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0xE9F454", Offset = "0xE9F454", VA = "0xE9F454", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}
	}
}
namespace GlitchrUtils
{
	[Token(Token = "0x200014A")]
	public static class UnityExtensionMethods
	{
		[Token(Token = "0x200014B")]
		[CompilerGenerated]
		private sealed class <DistinctBy>d__1<TSource, TKey> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000698")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x4000699")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private TSource <>2__current;

			[Token(Token = "0x400069A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>l__initialThreadId;

			[Token(Token = "0x400069B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private IEnumerable<TSource> source;

			[Token(Token = "0x400069C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IEnumerable<TSource> <>3__source;

			[Token(Token = "0x400069D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Func<TSource, TKey> keySelector;

			[Token(Token = "0x400069E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Func<TSource, TKey> <>3__keySelector;

			[Token(Token = "0x400069F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private HashSet<TKey> <seenKeys>5__2;

			[Token(Token = "0x40006A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private IEnumerator<TSource> <>7__wrap2;

			[Token(Token = "0x17000109")]
			private TSource System.Collections.Generic.IEnumerator<TSource>.Current
			{
				[Token(Token = "0x60006FC")]
				[DebuggerHidden]
				get
				{
					return (TSource)null;
				}
			}

			[Token(Token = "0x1700010A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006FE")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006F8")]
			[DebuggerHidden]
			public <DistinctBy>d__1(int <>1__state)
			{
			}

			[Token(Token = "0x60006F9")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006FA")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006FB")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60006FD")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60006FF")]
			[DebuggerHidden]
			private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000700")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0xE9F9A4", Offset = "0xE9F9A4", VA = "0xE9F9A4")]
		public static bool IsValid(this Quaternion quaternion)
		{
			return default(bool);
		}

		[Token(Token = "0x60006F7")]
		[IteratorStateMachine(typeof(<DistinctBy>d__1<, >))]
		public static IEnumerable<TSource> DistinctBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
		{
			return null;
		}
	}
	[Token(Token = "0x200014C")]
	public static class Utils
	{
		[Token(Token = "0x40006A1")]
		public const float fEpsilon = 1E-06f;

		[Token(Token = "0x40006A2")]
		public const float SpeedSqrThresholdForImpactSounds = 12.25f;

		[Token(Token = "0x40006A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static System.Random rng;

		[Token(Token = "0x40006A4")]
		private const string HTML_TAG_PATTERN = "<.*?>";

		[Token(Token = "0x40006A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly Vector4[] s_UnitSphere;

		[Token(Token = "0x6000701")]
		public static T[] RemoveAt<T>(this T[] source, int index)
		{
			return null;
		}

		[Token(Token = "0x6000702")]
		public static T[] Resize<T>(this T[] source, int newSize)
		{
			return null;
		}

		[Token(Token = "0x6000703")]
		public static void Shuffle<T>(this IList<T> list)
		{
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0xE9FA64", Offset = "0xE9FA64", VA = "0xE9FA64")]
		public static int RandomSeed()
		{
			return default(int);
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0xE9FACC", Offset = "0xE9FACC", VA = "0xE9FACC")]
		public static bool CheckInSight(Camera cam, GameObject obj, float frameOffsetFromBorders = 0f)
		{
			return default(bool);
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0xE9FB54", Offset = "0xE9FB54", VA = "0xE9FB54")]
		public static bool CheckInSight(Camera cam, Transform transform, float frameOffsetFromBorders = 0f)
		{
			return default(bool);
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0xE9FBDC", Offset = "0xE9FBDC", VA = "0xE9FBDC")]
		public static bool CheckInSight(Camera cam, Renderer rend)
		{
			return default(bool);
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0xE9FC44", Offset = "0xE9FC44", VA = "0xE9FC44")]
		public static int CountWords(string s)
		{
			return default(int);
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0xE9FCC4", Offset = "0xE9FCC4", VA = "0xE9FCC4")]
		public static float SignedVolumeOfTriangle(Vector3 p1, Vector3 p2, Vector3 p3)
		{
			return default(float);
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0xE9FD20", Offset = "0xE9FD20", VA = "0xE9FD20")]
		public static float VolumeOfMesh(Mesh mesh)
		{
			return default(float);
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0xE9FEC8", Offset = "0xE9FEC8", VA = "0xE9FEC8")]
		public static string RemoveDuplicateCharsFast(string key)
		{
			return null;
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0xEA0008", Offset = "0xEA0008", VA = "0xEA0008")]
		public static string StripHTML(string inputString)
		{
			return null;
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0xEA00A4", Offset = "0xEA00A4", VA = "0xEA00A4")]
		public static float StandardDeviation(float[] t)
		{
			return default(float);
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0xEA0124", Offset = "0xEA0124", VA = "0xEA0124")]
		public static bool SuggestProjectileVelocity(ref Vector3 OutTossVelocity, Vector3 Start, Vector3 End, float TossSpeed, bool bFavorHighArc, float CollisionRadius, float OverrideGravityY, bool bDrawDebug)
		{
			return default(bool);
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0xEA0558", Offset = "0xEA0558", VA = "0xEA0558")]
		public static void DrawSphere(Vector4 pos, float radius, Color color)
		{
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0xEA08A0", Offset = "0xEA08A0", VA = "0xEA08A0")]
		private static Vector4[] MakeUnitSphere(int len)
		{
			return null;
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0xEA09F4", Offset = "0xEA09F4", VA = "0xEA09F4")]
		public static float TriangleWave(float input, float minValue = -1f, float maxValue = 1f, float period = 360f, float phase = -90f)
		{
			return default(float);
		}
	}
}
namespace DUCK.Crypto
{
	[Token(Token = "0x200014D")]
	public static class SimpleAESEncryption
	{
		[Token(Token = "0x200014E")]
		public struct AESEncryptedText
		{
			[Token(Token = "0x40006A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string IV;

			[Token(Token = "0x40006A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string EncryptedText;
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0xEA0B1C", Offset = "0xEA0B1C", VA = "0xEA0B1C")]
		public static AESEncryptedText Encrypt(string plainText, string password)
		{
			return default(AESEncryptedText);
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0xEA0F74", Offset = "0xEA0F74", VA = "0xEA0F74")]
		public static string Decrypt(AESEncryptedText encryptedText, string password)
		{
			return null;
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0xEA0F84", Offset = "0xEA0F84", VA = "0xEA0F84")]
		public static string Decrypt(string encryptedText, string iv, string password)
		{
			return null;
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0xEA0E68", Offset = "0xEA0E68", VA = "0xEA0E68")]
		private static byte[] ConvertToKeyBytes(SymmetricAlgorithm algorithm, string password)
		{
			return null;
		}
	}
}
namespace Oculus.Interaction
{
	[Token(Token = "0x200014F")]
	public class OneGrabChildOfControllerTransformer : MonoBehaviour, ITransformer
	{
		[Token(Token = "0x40006A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IGrabbable _grabbable;

		[Token(Token = "0x40006A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Pose _grabDeltaInLocalSpace;

		[Token(Token = "0x40006AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody _rigidbody;

		[Token(Token = "0x6000717")]
		[Address(RVA = "0xEA1280", Offset = "0xEA1280", VA = "0xEA1280", Slot = "4")]
		public void Initialize(IGrabbable grabbable)
		{
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0xEA12F4", Offset = "0xEA12F4", VA = "0xEA12F4", Slot = "5")]
		public void BeginTransform()
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0xEA1568", Offset = "0xEA1568", VA = "0xEA1568", Slot = "6")]
		public void UpdateTransform()
		{
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0xEA184C", Offset = "0xEA184C", VA = "0xEA184C", Slot = "7")]
		public void EndTransform()
		{
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0xEA1850", Offset = "0xEA1850", VA = "0xEA1850")]
		public OneGrabChildOfControllerTransformer()
		{
		}
	}
}
namespace TaikoFrenzy.Utils
{
	[Token(Token = "0x2000150")]
	public class TransformRotator : MonoBehaviour
	{
		[Token(Token = "0x40006AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Vector3 _axisSpeed;

		[Token(Token = "0x600071C")]
		[Address(RVA = "0xEA1858", Offset = "0xEA1858", VA = "0xEA1858")]
		private void Update()
		{
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0xEA18E0", Offset = "0xEA18E0", VA = "0xEA18E0")]
		public TransformRotator()
		{
		}
	}
}
namespace TaikoFrenzy.UI
{
	[Token(Token = "0x2000151")]
	public class AchievementsDisplay : MonoBehaviour
	{
		[Token(Token = "0x40006AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Header("General")]
		private RectTransform _blockTransform;

		[Token(Token = "0x40006AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _blockCG;

		[Token(Token = "0x40006AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private LocalizeStringEvent _labelText;

		[Token(Token = "0x40006AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _resetOnEnable;

		[Token(Token = "0x40006B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Header("Animation")]
		[SerializeField]
		private float _appearTime;

		[Token(Token = "0x40006B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _stayTime;

		[Token(Token = "0x40006B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _disappearTime;

		[Token(Token = "0x40006B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Sequence _animationSequence;

		[Token(Token = "0x40006B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<string> _keysList;

		[Token(Token = "0x40006B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int _keyIndex;

		[Token(Token = "0x600071E")]
		[Address(RVA = "0xEA18E8", Offset = "0xEA18E8", VA = "0xEA18E8")]
		private void Awake()
		{
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0xEA18EC", Offset = "0xEA18EC", VA = "0xEA18EC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0xEA1988", Offset = "0xEA1988", VA = "0xEA1988")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0xEA18FC", Offset = "0xEA18FC", VA = "0xEA18FC")]
		private void KillTweens()
		{
		}

		[Token(Token = "0x6000722")]
		[Address(RVA = "0xEA198C", Offset = "0xEA198C", VA = "0xEA198C")]
		public void Display(List<string> achievementKeys)
		{
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0xEA1A0C", Offset = "0xEA1A0C", VA = "0xEA1A0C")]
		private void BuildSequence()
		{
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0xEA1CB4", Offset = "0xEA1CB4", VA = "0xEA1CB4")]
		public AchievementsDisplay()
		{
		}
	}
	[Token(Token = "0x2000152")]
	public class FloatingCountdown : MonoBehaviour
	{
		[Token(Token = "0x40006B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string[] _countdownStrings;

		[Token(Token = "0x40006B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private FloatingTextManager.TextType _textType;

		[Token(Token = "0x40006B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private EventReference _tickSoundEvent;

		[Token(Token = "0x40006BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TimerLoop _coundownTimer;

		[Token(Token = "0x40006BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int _countdownIndex;

		[Token(Token = "0x1400001E")]
		public event Action OnFinished
		{
			[Token(Token = "0x6000726")]
			[Address(RVA = "0xEA1D3C", Offset = "0xEA1D3C", VA = "0xEA1D3C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000727")]
			[Address(RVA = "0xEA1DD8", Offset = "0xEA1DD8", VA = "0xEA1DD8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0xEA1E74", Offset = "0xEA1E74", VA = "0xEA1E74")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0xEA1EE0", Offset = "0xEA1EE0", VA = "0xEA1EE0")]
		public void StartCountdown()
		{
		}

		[Token(Token = "0x600072A")]
		[Address(RVA = "0xEA1F8C", Offset = "0xEA1F8C", VA = "0xEA1F8C")]
		public void StopCountdown()
		{
		}

		[Token(Token = "0x600072B")]
		[Address(RVA = "0xEA2030", Offset = "0xEA2030", VA = "0xEA2030")]
		private void CountdownTick()
		{
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0xEA21F4", Offset = "0xEA21F4", VA = "0xEA21F4")]
		private void Update()
		{
		}

		[Token(Token = "0x600072D")]
		[Address(RVA = "0xEA221C", Offset = "0xEA221C", VA = "0xEA221C")]
		public FloatingCountdown()
		{
		}
	}
	[Token(Token = "0x2000153")]
	public class GameplaySettingSlider : MonoBehaviour
	{
		[Token(Token = "0x40006BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		public GameplaySettings.SettingType Setting;

		[Token(Token = "0x40006BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Slider _slider;

		[Token(Token = "0x40006BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _valueStep;

		[Token(Token = "0x40006C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TextMeshProUGUI _valueText;

		[Token(Token = "0x40006C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private string _valueFormat;

		[Token(Token = "0x1400001F")]
		public event Action<GameplaySettings.SettingType, float> OnSettingChanged
		{
			[Token(Token = "0x600072E")]
			[Address(RVA = "0xEA2224", Offset = "0xEA2224", VA = "0xEA2224")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600072F")]
			[Address(RVA = "0xEA22D4", Offset = "0xEA22D4", VA = "0xEA22D4")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0xEA2384", Offset = "0xEA2384", VA = "0xEA2384")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0xEA2388", Offset = "0xEA2388", VA = "0xEA2388")]
		public void ValueChanged(float value)
		{
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0xEA2448", Offset = "0xEA2448", VA = "0xEA2448")]
		public void SetSliderValue(float value)
		{
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0xEA24F4", Offset = "0xEA24F4", VA = "0xEA24F4")]
		public void Decrement()
		{
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0xEA254C", Offset = "0xEA254C", VA = "0xEA254C")]
		public void Increment()
		{
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0xEA25A4", Offset = "0xEA25A4", VA = "0xEA25A4")]
		public GameplaySettingSlider()
		{
		}
	}
	[Token(Token = "0x2000154")]
	public class GameplaySettingToggle : MonoBehaviour
	{
		[Token(Token = "0x40006C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		public GameplaySettings.SettingType Setting;

		[Token(Token = "0x40006C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Toggle _toggle;

		[Token(Token = "0x14000020")]
		public event Action<GameplaySettings.SettingType, bool> OnSettingChanged
		{
			[Token(Token = "0x6000736")]
			[Address(RVA = "0xEA2608", Offset = "0xEA2608", VA = "0xEA2608")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000737")]
			[Address(RVA = "0xEA26B8", Offset = "0xEA26B8", VA = "0xEA26B8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0xEA2768", Offset = "0xEA2768", VA = "0xEA2768")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0xEA276C", Offset = "0xEA276C", VA = "0xEA276C")]
		public void ValueChanged(bool value)
		{
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0xEA2794", Offset = "0xEA2794", VA = "0xEA2794")]
		public void SetToggleValue(bool value)
		{
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0xEA27B4", Offset = "0xEA27B4", VA = "0xEA27B4")]
		public GameplaySettingToggle()
		{
		}
	}
	[Token(Token = "0x2000155")]
	public class HorizontalAutoSizedIconText : MonoBehaviour
	{
		[Token(Token = "0x40006C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MarkUIForRebuild _uiRebuild;

		[Token(Token = "0x40006C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _text;

		[Token(Token = "0x600073C")]
		[Address(RVA = "0xEA27BC", Offset = "0xEA27BC", VA = "0xEA27BC")]
		private void Awake()
		{
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0xEA27C0", Offset = "0xEA27C0", VA = "0xEA27C0")]
		public void SetText(string value)
		{
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0xEA27F8", Offset = "0xEA27F8", VA = "0xEA27F8")]
		public HorizontalAutoSizedIconText()
		{
		}
	}
	[Token(Token = "0x2000156")]
	public class LatencyCalibrator : MonoBehaviour
	{
		[Token(Token = "0x2000157")]
		[CompilerGenerated]
		private sealed class <DelayedCalibration>d__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LatencyCalibrator <>4__this;

			[Token(Token = "0x1700010B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600074E")]
				[Address(RVA = "0xEA2E88", Offset = "0xEA2E88", VA = "0xEA2E88", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700010C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000750")]
				[Address(RVA = "0xEA2ED0", Offset = "0xEA2ED0", VA = "0xEA2ED0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600074B")]
			[Address(RVA = "0xEA2DAC", Offset = "0xEA2DAC", VA = "0xEA2DAC")]
			[DebuggerHidden]
			public <DelayedCalibration>d__19(int <>1__state)
			{
			}

			[Token(Token = "0x600074C")]
			[Address(RVA = "0xEA2DD4", Offset = "0xEA2DD4", VA = "0xEA2DD4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600074D")]
			[Address(RVA = "0xEA2DD8", Offset = "0xEA2DD8", VA = "0xEA2DD8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600074F")]
			[Address(RVA = "0xEA2E90", Offset = "0xEA2E90", VA = "0xEA2E90", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40006C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("General")]
		[SerializeField]
		private Slider _slider;

		[Token(Token = "0x40006C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Slider _latencySlider;

		[Token(Token = "0x40006C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _indicatorTransform;

		[Token(Token = "0x40006CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _travelTime;

		[Token(Token = "0x40006CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Range(-1f, 1f)]
		[SerializeField]
		private int _initialPosition;

		[Token(Token = "0x40006CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private EventReference _tickRef;

		[Token(Token = "0x40006CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Header("Animation")]
		[SerializeField]
		private Vector2 _centerSize;

		[Token(Token = "0x40006CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Vector2 _boundarySize;

		[Token(Token = "0x40006CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _animationTime;

		[Token(Token = "0x40006D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private Ease _animationEase;

		[Token(Token = "0x40006D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private EventInstance _tickInstance;

		[Token(Token = "0x40006D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float _angleOffset;

		[Token(Token = "0x40006D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool _isPlaying;

		[Token(Token = "0x40006D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float _previousValue;

		[Token(Token = "0x40006D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private bool _isAdding;

		[Token(Token = "0x40006D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector2 _indicatorIdleSize;

		[Token(Token = "0x600073F")]
		[Address(RVA = "0xEA2800", Offset = "0xEA2800", VA = "0xEA2800")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0xEA2828", Offset = "0xEA2828", VA = "0xEA2828")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0xEA28BC", Offset = "0xEA28BC", VA = "0xEA28BC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0xEA2848", Offset = "0xEA2848", VA = "0xEA2848")]
		[IteratorStateMachine(typeof(<DelayedCalibration>d__19))]
		private IEnumerator DelayedCalibration()
		{
			return null;
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0xEA294C", Offset = "0xEA294C", VA = "0xEA294C")]
		private float GetAngleFromTimeMs(float time)
		{
			return default(float);
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0xEA2970", Offset = "0xEA2970", VA = "0xEA2970")]
		public void StartCalibration()
		{
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0xEA2C3C", Offset = "0xEA2C3C", VA = "0xEA2C3C")]
		public void LatencyUpdated(float value)
		{
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0xEA28D8", Offset = "0xEA28D8", VA = "0xEA28D8")]
		public void StopCalibration()
		{
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0xEA2C7C", Offset = "0xEA2C7C", VA = "0xEA2C7C")]
		private void AnimateIndicatorSize(Vector2 indicatorSize)
		{
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0xEA2A5C", Offset = "0xEA2A5C", VA = "0xEA2A5C")]
		private void SetSliderValue(float angle, bool animate = true)
		{
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0xEA2D18", Offset = "0xEA2D18", VA = "0xEA2D18")]
		private void Update()
		{
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0xEA2D9C", Offset = "0xEA2D9C", VA = "0xEA2D9C")]
		public LatencyCalibrator()
		{
		}
	}
	[Token(Token = "0x2000158")]
	public class LeaderboardEntryHandler : MonoBehaviour
	{
		[Token(Token = "0x40006DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _rankText;

		[Token(Token = "0x40006DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _nameText;

		[Token(Token = "0x40006DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI _scoreText;

		[Token(Token = "0x40006DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _spacerImage;

		[Token(Token = "0x40006DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Color _playerColor1;

		[Token(Token = "0x40006DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color _playerColor2;

		[Token(Token = "0x6000751")]
		[Address(RVA = "0xEA2ED8", Offset = "0xEA2ED8", VA = "0xEA2ED8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0xEA2EDC", Offset = "0xEA2EDC", VA = "0xEA2EDC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0xEA2EE0", Offset = "0xEA2EE0", VA = "0xEA2EE0")]
		private void CleanTweens()
		{
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0xEA2F1C", Offset = "0xEA2F1C", VA = "0xEA2F1C")]
		public void InitEntry(LeaderboardPlatform.LeaderboardEntry entry, bool isPlayer, bool spacer = true)
		{
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0xEA3130", Offset = "0xEA3130", VA = "0xEA3130")]
		public LeaderboardEntryHandler()
		{
		}
	}
	[Token(Token = "0x2000159")]
	public class LeaderboardHandler : MonoBehaviour
	{
		[Token(Token = "0x40006E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Header("Leaderboard")]
		private RectTransform _entriesTransform;

		[Token(Token = "0x40006E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LeaderboardEntryHandler _entryPrefab;

		[Token(Token = "0x40006E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private LeaderboardPlatform.EntryType _entryType;

		[Token(Token = "0x40006E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Header("UI Elements")]
		[SerializeField]
		private GameObject _loadingIndicator;

		[Token(Token = "0x40006E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _noLeaderboardText;

		[Token(Token = "0x40006E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _noEntriesText;

		[Token(Token = "0x40006E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _noInternetText;

		[Token(Token = "0x40006E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private LeaderboardPlatform _leaderboard;

		[Token(Token = "0x40006E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private string _pendingKey;

		[Token(Token = "0x40006E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int _score;

		[Token(Token = "0x1700010D")]
		public LeaderboardPlatform.EntryType EntryType
		{
			[Token(Token = "0x6000756")]
			[Address(RVA = "0xEA3138", Offset = "0xEA3138", VA = "0xEA3138")]
			get
			{
				return default(LeaderboardPlatform.EntryType);
			}
			[Token(Token = "0x6000757")]
			[Address(RVA = "0xEA3140", Offset = "0xEA3140", VA = "0xEA3140")]
			set
			{
			}
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0xEA3400", Offset = "0xEA3400", VA = "0xEA3400")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0xEA3404", Offset = "0xEA3404", VA = "0xEA3404")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600075A")]
		[Address(RVA = "0xEA34A8", Offset = "0xEA34A8", VA = "0xEA34A8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0xEA355C", Offset = "0xEA355C", VA = "0xEA355C")]
		private void ConnectionStatusChanged()
		{
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0xEA3618", Offset = "0xEA3618", VA = "0xEA3618")]
		public void Init(string leaderboardKey, int score = 0)
		{
		}

		[Token(Token = "0x600075D")]
		[Address(RVA = "0xEA39B8", Offset = "0xEA39B8", VA = "0xEA39B8")]
		private void Clean(bool flush = false)
		{
		}

		[Token(Token = "0x600075E")]
		[Address(RVA = "0xEA3E20", Offset = "0xEA3E20", VA = "0xEA3E20")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0xEA3E28", Offset = "0xEA3E28", VA = "0xEA3E28")]
		private void InitLeaderboard()
		{
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0xEA315C", Offset = "0xEA315C", VA = "0xEA315C")]
		private void InitEntries()
		{
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0xEA3E5C", Offset = "0xEA3E5C", VA = "0xEA3E5C")]
		private void AddLeaderboardLine(LeaderboardPlatform.LeaderboardEntry entry, bool isPlayer, bool spacer)
		{
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0xEA3F04", Offset = "0xEA3F04", VA = "0xEA3F04")]
		public LeaderboardHandler()
		{
		}
	}
	[Token(Token = "0x200015A")]
	[RequireComponent(typeof(RectTransform))]
	public class MarkUIForRebuild : MonoBehaviour
	{
		[Token(Token = "0x200015B")]
		[CompilerGenerated]
		private sealed class <DelayedRebuild>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MarkUIForRebuild <>4__this;

			[Token(Token = "0x1700010E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600076B")]
				[Address(RVA = "0xEA4200", Offset = "0xEA4200", VA = "0xEA4200", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700010F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600076D")]
				[Address(RVA = "0xEA4248", Offset = "0xEA4248", VA = "0xEA4248", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000768")]
			[Address(RVA = "0xEA4070", Offset = "0xEA4070", VA = "0xEA4070")]
			[DebuggerHidden]
			public <DelayedRebuild>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000769")]
			[Address(RVA = "0xEA40A0", Offset = "0xEA40A0", VA = "0xEA40A0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600076A")]
			[Address(RVA = "0xEA40A4", Offset = "0xEA40A4", VA = "0xEA40A4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600076C")]
			[Address(RVA = "0xEA4208", Offset = "0xEA4208", VA = "0xEA4208", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40006EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool _marked;

		[Token(Token = "0x6000763")]
		[Address(RVA = "0xEA3F0C", Offset = "0xEA3F0C", VA = "0xEA3F0C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0xEA3FE0", Offset = "0xEA3FE0", VA = "0xEA3FE0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0xEA3F10", Offset = "0xEA3F10", VA = "0xEA3F10")]
		public void ForceRebuild()
		{
		}

		[Token(Token = "0x6000766")]
		[Address(RVA = "0xEA3FFC", Offset = "0xEA3FFC", VA = "0xEA3FFC")]
		[IteratorStateMachine(typeof(<DelayedRebuild>d__4))]
		private IEnumerator DelayedRebuild()
		{
			return null;
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0xEA4098", Offset = "0xEA4098", VA = "0xEA4098")]
		public MarkUIForRebuild()
		{
		}
	}
	[Token(Token = "0x200015C")]
	public class MedalProgressHandler : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200015D")]
		private struct MedalCursor
		{
			[Token(Token = "0x40006F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public RectTransform CursorTransform;

			[Token(Token = "0x40006FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public SakuraMedal Medal;
		}

		[Token(Token = "0x40006EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Header("General")]
		private RectTransform _progressContainerTransform;

		[Token(Token = "0x40006EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _progressFillImage;

		[Token(Token = "0x40006F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _bestScoreCursor;

		[Token(Token = "0x40006F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private MedalCursor[] _medalCursors;

		[Token(Token = "0x40006F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Header("Animation")]
		[SerializeField]
		private float _unlockAnimationTime;

		[Token(Token = "0x40006F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _unlockPunchScale;

		[Token(Token = "0x40006F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Ease _unlockAnimationEase;

		[Token(Token = "0x40006F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int _bestScore;

		[Token(Token = "0x40006F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int _maxMedalScore;

		[Token(Token = "0x40006F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<int> _medalScores;

		[Token(Token = "0x40006F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int _medalCheckIndex;

		[Token(Token = "0x600076E")]
		[Address(RVA = "0xEA4250", Offset = "0xEA4250", VA = "0xEA4250")]
		private void Awake()
		{
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0xEA427C", Offset = "0xEA427C", VA = "0xEA427C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0xEA4338", Offset = "0xEA4338", VA = "0xEA4338")]
		public void Init(int bestScore, TaikoTrack track, GameManager.Difficulty difficulty, List<TaikoTrack.MedalType> alreadyUnlocked)
		{
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0xEA46E8", Offset = "0xEA46E8", VA = "0xEA46E8")]
		public void UpdateScore(int score)
		{
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0xEA4280", Offset = "0xEA4280", VA = "0xEA4280")]
		private void KillTweens()
		{
		}

		[Token(Token = "0x6000773")]
		[Address(RVA = "0xEA4920", Offset = "0xEA4920", VA = "0xEA4920")]
		public MedalProgressHandler()
		{
		}
	}
	[Token(Token = "0x200015E")]
	[SelectionBase]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(RectTransform))]
	[ExecuteAlways]
	public class NonDraggableScrollRect : UIBehaviour, IScrollHandler, IEventSystemHandler, ICanvasElement, ILayoutElement, ILayoutGroup, ILayoutController
	{
		[Token(Token = "0x200015F")]
		public enum MovementType
		{
			[Token(Token = "0x4000720")]
			Unrestricted,
			[Token(Token = "0x4000721")]
			Elastic,
			[Token(Token = "0x4000722")]
			Clamped
		}

		[Token(Token = "0x2000160")]
		public enum ScrollbarVisibility
		{
			[Token(Token = "0x4000724")]
			Permanent,
			[Token(Token = "0x4000725")]
			AutoHide,
			[Token(Token = "0x4000726")]
			AutoHideAndExpandViewport
		}

		[Serializable]
		[Token(Token = "0x2000161")]
		public class ScrollRectEvent : UnityEvent<Vector2>
		{
			[Token(Token = "0x60007CB")]
			[Address(RVA = "0xEA51A0", Offset = "0xEA51A0", VA = "0xEA51A0")]
			public ScrollRectEvent()
			{
			}
		}

		[Token(Token = "0x40006FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform m_Content;

		[Token(Token = "0x40006FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool m_Horizontal;

		[Token(Token = "0x40006FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[SerializeField]
		private bool m_Vertical;

		[Token(Token = "0x40006FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private MovementType m_MovementType;

		[Token(Token = "0x40006FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_Elasticity;

		[Token(Token = "0x4000700")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private bool m_Inertia;

		[Token(Token = "0x4000701")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_DecelerationRate;

		[Token(Token = "0x4000702")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float m_ScrollSensitivity;

		[Token(Token = "0x4000703")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform m_Viewport;

		[Token(Token = "0x4000704")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Scrollbar m_HorizontalScrollbar;

		[Token(Token = "0x4000705")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Scrollbar m_VerticalScrollbar;

		[Token(Token = "0x4000706")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ScrollbarVisibility m_HorizontalScrollbarVisibility;

		[Token(Token = "0x4000707")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		private ScrollbarVisibility m_VerticalScrollbarVisibility;

		[Token(Token = "0x4000708")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float m_HorizontalScrollbarSpacing;

		[Token(Token = "0x4000709")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float m_VerticalScrollbarSpacing;

		[Token(Token = "0x400070A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private ScrollRectEvent m_OnValueChanged;

		[Token(Token = "0x400070B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector2 m_PointerStartLocalCursor;

		[Token(Token = "0x400070C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		protected Vector2 m_ContentStartPosition;

		[Token(Token = "0x400070D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private RectTransform m_ViewRect;

		[Token(Token = "0x400070E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		protected Bounds m_ContentBounds;

		[Token(Token = "0x400070F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Bounds m_ViewBounds;

		[Token(Token = "0x4000710")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector2 m_Velocity;

		[Token(Token = "0x4000711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool m_Scrolling;

		[Token(Token = "0x4000712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Vector2 m_PrevPosition;

		[Token(Token = "0x4000713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Bounds m_PrevContentBounds;

		[Token(Token = "0x4000714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Bounds m_PrevViewBounds;

		[NonSerialized]
		[Token(Token = "0x4000715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private bool m_HasRebuiltLayout;

		[Token(Token = "0x4000716")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF5")]
		private bool m_HSliderExpand;

		[Token(Token = "0x4000717")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF6")]
		private bool m_VSliderExpand;

		[Token(Token = "0x4000718")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private float m_HSliderHeight;

		[Token(Token = "0x4000719")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		private float m_VSliderWidth;

		[NonSerialized]
		[Token(Token = "0x400071A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private RectTransform m_Rect;

		[Token(Token = "0x400071B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private RectTransform m_HorizontalScrollbarRect;

		[Token(Token = "0x400071C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private RectTransform m_VerticalScrollbarRect;

		[Token(Token = "0x400071D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private DrivenRectTransformTracker m_Tracker;

		[Token(Token = "0x400071E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private readonly Vector3[] m_Corners;

		[Token(Token = "0x17000110")]
		public RectTransform content
		{
			[Token(Token = "0x6000774")]
			[Address(RVA = "0xEA4944", Offset = "0xEA4944", VA = "0xEA4944")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000775")]
			[Address(RVA = "0xEA494C", Offset = "0xEA494C", VA = "0xEA494C")]
			set
			{
			}
		}

		[Token(Token = "0x17000111")]
		public bool horizontal
		{
			[Token(Token = "0x6000776")]
			[Address(RVA = "0xEA4954", Offset = "0xEA4954", VA = "0xEA4954")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000777")]
			[Address(RVA = "0xEA495C", Offset = "0xEA495C", VA = "0xEA495C")]
			set
			{
			}
		}

		[Token(Token = "0x17000112")]
		public bool vertical
		{
			[Token(Token = "0x6000778")]
			[Address(RVA = "0xEA4968", Offset = "0xEA4968", VA = "0xEA4968")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000779")]
			[Address(RVA = "0xEA4970", Offset = "0xEA4970", VA = "0xEA4970")]
			set
			{
			}
		}

		[Token(Token = "0x17000113")]
		public MovementType movementType
		{
			[Token(Token = "0x600077A")]
			[Address(RVA = "0xEA497C", Offset = "0xEA497C", VA = "0xEA497C")]
			get
			{
				return default(MovementType);
			}
			[Token(Token = "0x600077B")]
			[Address(RVA = "0xEA4984", Offset = "0xEA4984", VA = "0xEA4984")]
			set
			{
			}
		}

		[Token(Token = "0x17000114")]
		public float elasticity
		{
			[Token(Token = "0x600077C")]
			[Address(RVA = "0xEA498C", Offset = "0xEA498C", VA = "0xEA498C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600077D")]
			[Address(RVA = "0xEA4994", Offset = "0xEA4994", VA = "0xEA4994")]
			set
			{
			}
		}

		[Token(Token = "0x17000115")]
		public bool inertia
		{
			[Token(Token = "0x600077E")]
			[Address(RVA = "0xEA499C", Offset = "0xEA499C", VA = "0xEA499C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600077F")]
			[Address(RVA = "0xEA49A4", Offset = "0xEA49A4", VA = "0xEA49A4")]
			set
			{
			}
		}

		[Token(Token = "0x17000116")]
		public float decelerationRate
		{
			[Token(Token = "0x6000780")]
			[Address(RVA = "0xEA49B0", Offset = "0xEA49B0", VA = "0xEA49B0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000781")]
			[Address(RVA = "0xEA49B8", Offset = "0xEA49B8", VA = "0xEA49B8")]
			set
			{
			}
		}

		[Token(Token = "0x17000117")]
		public float scrollSensitivity
		{
			[Token(Token = "0x6000782")]
			[Address(RVA = "0xEA49C0", Offset = "0xEA49C0", VA = "0xEA49C0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000783")]
			[Address(RVA = "0xEA49C8", Offset = "0xEA49C8", VA = "0xEA49C8")]
			set
			{
			}
		}

		[Token(Token = "0x17000118")]
		public RectTransform viewport
		{
			[Token(Token = "0x6000784")]
			[Address(RVA = "0xEA49D0", Offset = "0xEA49D0", VA = "0xEA49D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000785")]
			[Address(RVA = "0xEA49D8", Offset = "0xEA49D8", VA = "0xEA49D8")]
			set
			{
			}
		}

		[Token(Token = "0x17000119")]
		public Scrollbar horizontalScrollbar
		{
			[Token(Token = "0x6000786")]
			[Address(RVA = "0xEA4ABC", Offset = "0xEA4ABC", VA = "0xEA4ABC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000787")]
			[Address(RVA = "0xEA4AC4", Offset = "0xEA4AC4", VA = "0xEA4AC4")]
			set
			{
			}
		}

		[Token(Token = "0x1700011A")]
		public Scrollbar verticalScrollbar
		{
			[Token(Token = "0x6000788")]
			[Address(RVA = "0xEA4C54", Offset = "0xEA4C54", VA = "0xEA4C54")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000789")]
			[Address(RVA = "0xEA4C5C", Offset = "0xEA4C5C", VA = "0xEA4C5C")]
			set
			{
			}
		}

		[Token(Token = "0x1700011B")]
		public ScrollbarVisibility horizontalScrollbarVisibility
		{
			[Token(Token = "0x600078A")]
			[Address(RVA = "0xEA4DEC", Offset = "0xEA4DEC", VA = "0xEA4DEC")]
			get
			{
				return default(ScrollbarVisibility);
			}
			[Token(Token = "0x600078B")]
			[Address(RVA = "0xEA4DF4", Offset = "0xEA4DF4", VA = "0xEA4DF4")]
			set
			{
			}
		}

		[Token(Token = "0x1700011C")]
		public ScrollbarVisibility verticalScrollbarVisibility
		{
			[Token(Token = "0x600078C")]
			[Address(RVA = "0xEA4DFC", Offset = "0xEA4DFC", VA = "0xEA4DFC")]
			get
			{
				return default(ScrollbarVisibility);
			}
			[Token(Token = "0x600078D")]
			[Address(RVA = "0xEA4E04", Offset = "0xEA4E04", VA = "0xEA4E04")]
			set
			{
			}
		}

		[Token(Token = "0x1700011D")]
		public float horizontalScrollbarSpacing
		{
			[Token(Token = "0x600078E")]
			[Address(RVA = "0xEA4E0C", Offset = "0xEA4E0C", VA = "0xEA4E0C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600078F")]
			[Address(RVA = "0xEA4E14", Offset = "0xEA4E14", VA = "0xEA4E14")]
			set
			{
			}
		}

		[Token(Token = "0x1700011E")]
		public float verticalScrollbarSpacing
		{
			[Token(Token = "0x6000790")]
			[Address(RVA = "0xEA4EA4", Offset = "0xEA4EA4", VA = "0xEA4EA4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000791")]
			[Address(RVA = "0xEA4EAC", Offset = "0xEA4EAC", VA = "0xEA4EAC")]
			set
			{
			}
		}

		[Token(Token = "0x1700011F")]
		public ScrollRectEvent onValueChanged
		{
			[Token(Token = "0x6000792")]
			[Address(RVA = "0xEA4EB4", Offset = "0xEA4EB4", VA = "0xEA4EB4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000793")]
			[Address(RVA = "0xEA4EBC", Offset = "0xEA4EBC", VA = "0xEA4EBC")]
			set
			{
			}
		}

		[Token(Token = "0x17000120")]
		protected RectTransform viewRect
		{
			[Token(Token = "0x6000794")]
			[Address(RVA = "0xEA4EC4", Offset = "0xEA4EC4", VA = "0xEA4EC4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000121")]
		public Vector2 velocity
		{
			[Token(Token = "0x6000795")]
			[Address(RVA = "0xEA4FD4", Offset = "0xEA4FD4", VA = "0xEA4FD4")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000796")]
			[Address(RVA = "0xEA4FDC", Offset = "0xEA4FDC", VA = "0xEA4FDC")]
			set
			{
			}
		}

		[Token(Token = "0x17000122")]
		private RectTransform rectTransform
		{
			[Token(Token = "0x6000797")]
			[Address(RVA = "0xEA4FE4", Offset = "0xEA4FE4", VA = "0xEA4FE4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000123")]
		public Vector2 normalizedPosition
		{
			[Token(Token = "0x60007A7")]
			[Address(RVA = "0xEA6A1C", Offset = "0xEA6A1C", VA = "0xEA6A1C")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x60007A8")]
			[Address(RVA = "0xEA6D44", Offset = "0xEA6D44", VA = "0xEA6D44")]
			set
			{
			}
		}

		[Token(Token = "0x17000124")]
		public float horizontalNormalizedPosition
		{
			[Token(Token = "0x60007A9")]
			[Address(RVA = "0xEA6A8C", Offset = "0xEA6A8C", VA = "0xEA6A8C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60007AA")]
			[Address(RVA = "0xEA6D8C", Offset = "0xEA6D8C", VA = "0xEA6D8C")]
			set
			{
			}
		}

		[Token(Token = "0x17000125")]
		public float verticalNormalizedPosition
		{
			[Token(Token = "0x60007AB")]
			[Address(RVA = "0xEA6BE8", Offset = "0xEA6BE8", VA = "0xEA6BE8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60007AC")]
			[Address(RVA = "0xEA6DA0", Offset = "0xEA6DA0", VA = "0xEA6DA0")]
			set
			{
			}
		}

		[Token(Token = "0x17000126")]
		private bool hScrollingNeeded
		{
			[Token(Token = "0x60007B2")]
			[Address(RVA = "0xEA7114", Offset = "0xEA7114", VA = "0xEA7114")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000127")]
		private bool vScrollingNeeded
		{
			[Token(Token = "0x60007B3")]
			[Address(RVA = "0xEA7170", Offset = "0xEA7170", VA = "0xEA7170")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000128")]
		public virtual float minWidth
		{
			[Token(Token = "0x60007B6")]
			[Address(RVA = "0xEA71D4", Offset = "0xEA71D4", VA = "0xEA71D4", Slot = "44")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000129")]
		public virtual float preferredWidth
		{
			[Token(Token = "0x60007B7")]
			[Address(RVA = "0xEA71DC", Offset = "0xEA71DC", VA = "0xEA71DC", Slot = "45")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700012A")]
		public virtual float flexibleWidth
		{
			[Token(Token = "0x60007B8")]
			[Address(RVA = "0xEA71E4", Offset = "0xEA71E4", VA = "0xEA71E4", Slot = "46")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700012B")]
		public virtual float minHeight
		{
			[Token(Token = "0x60007B9")]
			[Address(RVA = "0xEA71EC", Offset = "0xEA71EC", VA = "0xEA71EC", Slot = "47")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700012C")]
		public virtual float preferredHeight
		{
			[Token(Token = "0x60007BA")]
			[Address(RVA = "0xEA71F4", Offset = "0xEA71F4", VA = "0xEA71F4", Slot = "48")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700012D")]
		public virtual float flexibleHeight
		{
			[Token(Token = "0x60007BB")]
			[Address(RVA = "0xEA71FC", Offset = "0xEA71FC", VA = "0xEA71FC", Slot = "49")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700012E")]
		public virtual int layoutPriority
		{
			[Token(Token = "0x60007BC")]
			[Address(RVA = "0xEA7204", Offset = "0xEA7204", VA = "0xEA7204", Slot = "50")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0xEA5084", Offset = "0xEA5084", VA = "0xEA5084")]
		protected NonDraggableScrollRect()
		{
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0xEA51E8", Offset = "0xEA51E8", VA = "0xEA51E8", Slot = "34")]
		public virtual void Rebuild(CanvasUpdate executing)
		{
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0xEA5D78", Offset = "0xEA5D78", VA = "0xEA5D78", Slot = "35")]
		public virtual void LayoutComplete()
		{
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0xEA5D7C", Offset = "0xEA5D7C", VA = "0xEA5D7C", Slot = "36")]
		public virtual void GraphicUpdateComplete()
		{
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0xEA5270", Offset = "0xEA5270", VA = "0xEA5270")]
		private void UpdateCachedData()
		{
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0xEA5D80", Offset = "0xEA5D80", VA = "0xEA5D80", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0xEA5F2C", Offset = "0xEA5F2C", VA = "0xEA5F2C", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0xEA615C", Offset = "0xEA615C", VA = "0xEA615C", Slot = "9")]
		public override bool IsActive()
		{
			return default(bool);
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0xEA61DC", Offset = "0xEA61DC", VA = "0xEA61DC")]
		private void EnsureLayoutHasRebuilt()
		{
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0xEA6250", Offset = "0xEA6250", VA = "0xEA6250", Slot = "37")]
		public virtual void StopMovement()
		{
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0xEA62A0", Offset = "0xEA62A0", VA = "0xEA62A0", Slot = "38")]
		public virtual void OnScroll(PointerEventData data)
		{
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0xEA6448", Offset = "0xEA6448", VA = "0xEA6448", Slot = "39")]
		protected virtual void SetContentAnchoredPosition(Vector2 position)
		{
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0xEA64FC", Offset = "0xEA64FC", VA = "0xEA64FC", Slot = "40")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0xEA5C9C", Offset = "0xEA5C9C", VA = "0xEA5C9C")]
		protected void UpdatePrevData()
		{
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0xEA5ABC", Offset = "0xEA5ABC", VA = "0xEA5ABC")]
		private void UpdateScrollbars(Vector2 offset)
		{
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0xEA6DB4", Offset = "0xEA6DB4", VA = "0xEA6DB4")]
		private void SetHorizontalNormalizedPosition(float value)
		{
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0xEA6DC8", Offset = "0xEA6DC8", VA = "0xEA6DC8")]
		private void SetVerticalNormalizedPosition(float value)
		{
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0xEA6DDC", Offset = "0xEA6DDC", VA = "0xEA6DDC", Slot = "41")]
		protected virtual void SetNormalizedPosition(float value, int axis)
		{
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0xEA70D4", Offset = "0xEA70D4", VA = "0xEA70D4")]
		private static float RubberDelta(float overStretching, float viewSize)
		{
			return default(float);
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0xEA7110", Offset = "0xEA7110", VA = "0xEA7110", Slot = "10")]
		protected override void OnRectTransformDimensionsChange()
		{
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0xEA71CC", Offset = "0xEA71CC", VA = "0xEA71CC", Slot = "42")]
		public virtual void CalculateLayoutInputHorizontal()
		{
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0xEA71D0", Offset = "0xEA71D0", VA = "0xEA71D0", Slot = "43")]
		public virtual void CalculateLayoutInputVertical()
		{
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0xEA720C", Offset = "0xEA720C", VA = "0xEA720C", Slot = "51")]
		public virtual void SetLayoutHorizontal()
		{
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0xEA7860", Offset = "0xEA7860", VA = "0xEA7860", Slot = "52")]
		public virtual void SetLayoutVertical()
		{
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0xEA6A4C", Offset = "0xEA6A4C", VA = "0xEA6A4C")]
		private void UpdateScrollbarVisibility()
		{
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0xEA7B90", Offset = "0xEA7B90", VA = "0xEA7B90")]
		private static void UpdateOneScrollbarVisibility(bool xScrollingNeeded, bool xAxisEnabled, ScrollbarVisibility scrollbarVisibility, Scrollbar scrollbar)
		{
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0xEA793C", Offset = "0xEA793C", VA = "0xEA793C")]
		private void UpdateScrollbarLayout()
		{
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0xEA5608", Offset = "0xEA5608", VA = "0xEA5608")]
		protected void UpdateBounds()
		{
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0xEA7C84", Offset = "0xEA7C84", VA = "0xEA7C84")]
		internal static void AdjustBounds(ref Bounds viewBounds, ref Vector2 contentPivot, ref Vector3 contentSize, ref Vector3 contentPos)
		{
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0xEA7764", Offset = "0xEA7764", VA = "0xEA7764")]
		private Bounds GetBounds()
		{
			return default(Bounds);
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0xEA7D30", Offset = "0xEA7D30", VA = "0xEA7D30")]
		internal static Bounds InternalGetBounds(Vector3[] corners, ref Matrix4x4 viewWorldToLocalMatrix)
		{
			return default(Bounds);
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0xEA6418", Offset = "0xEA6418", VA = "0xEA6418")]
		private Vector2 CalculateOffset(Vector2 delta)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0xEA7E88", Offset = "0xEA7E88", VA = "0xEA7E88")]
		internal static Vector2 InternalCalculateOffset(ref Bounds viewBounds, ref Bounds contentBounds, bool horizontal, bool vertical, MovementType movementType, ref Vector2 delta)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0xEA4E1C", Offset = "0xEA4E1C", VA = "0xEA4E1C")]
		protected void SetDirty()
		{
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0xEA49F4", Offset = "0xEA49F4", VA = "0xEA49F4")]
		protected void SetDirtyCaching()
		{
		}

		[SpecialName]
		[Token(Token = "0x60007CA")]
		[Address(RVA = "0xEA800C", Offset = "0xEA800C", VA = "0xEA800C", Slot = "19")]
		private Transform UnityEngine.UI.ICanvasElement.get_transform()
		{
			return null;
		}
	}
	[Token(Token = "0x2000162")]
	public class NonDrawingGraphic : Graphic
	{
		[Token(Token = "0x60007CC")]
		[Address(RVA = "0xEA8014", Offset = "0xEA8014", VA = "0xEA8014", Slot = "29")]
		public override void SetMaterialDirty()
		{
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0xEA8018", Offset = "0xEA8018", VA = "0xEA8018", Slot = "28")]
		public override void SetVerticesDirty()
		{
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0xEA801C", Offset = "0xEA801C", VA = "0xEA801C", Slot = "44")]
		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0xEA8034", Offset = "0xEA8034", VA = "0xEA8034")]
		public NonDrawingGraphic()
		{
		}
	}
	[Token(Token = "0x2000163")]
	public class RatingStar : MonoBehaviour
	{
		[Token(Token = "0x400072A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _fillImage;

		[Token(Token = "0x400072B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private int _rating;

		[Token(Token = "0x400072C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Color _hoverColor;

		[Token(Token = "0x400072D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private Color _clickColor;

		[Token(Token = "0x14000021")]
		public event Action<float> OnEnter
		{
			[Token(Token = "0x60007D0")]
			[Address(RVA = "0xEA808C", Offset = "0xEA808C", VA = "0xEA808C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60007D1")]
			[Address(RVA = "0xEA813C", Offset = "0xEA813C", VA = "0xEA813C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000022")]
		public event Action<float> OnExit
		{
			[Token(Token = "0x60007D2")]
			[Address(RVA = "0xEA81EC", Offset = "0xEA81EC", VA = "0xEA81EC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60007D3")]
			[Address(RVA = "0xEA829C", Offset = "0xEA829C", VA = "0xEA829C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000023")]
		public event Action<float> OnClick
		{
			[Token(Token = "0x60007D4")]
			[Address(RVA = "0xEA834C", Offset = "0xEA834C", VA = "0xEA834C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60007D5")]
			[Address(RVA = "0xEA83FC", Offset = "0xEA83FC", VA = "0xEA83FC")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0xEA84AC", Offset = "0xEA84AC", VA = "0xEA84AC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0xEA84B0", Offset = "0xEA84B0", VA = "0xEA84B0")]
		public void Enter(bool left)
		{
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0xEA8510", Offset = "0xEA8510", VA = "0xEA8510")]
		public void Exit(bool left)
		{
		}

		[Token(Token = "0x60007D9")]
		[Address(RVA = "0xEA8570", Offset = "0xEA8570", VA = "0xEA8570")]
		public void Click(bool left)
		{
		}

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0xEA85D0", Offset = "0xEA85D0", VA = "0xEA85D0")]
		public void UpdateGraphic(float fillAmount, bool hover)
		{
		}

		[Token(Token = "0x60007DB")]
		[Address(RVA = "0xEA8650", Offset = "0xEA8650", VA = "0xEA8650")]
		public RatingStar()
		{
		}
	}
	[Token(Token = "0x2000164")]
	public class SakuraMedal : MonoBehaviour
	{
		[Token(Token = "0x400072E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TaikoTrack.MedalType Medal;

		[Token(Token = "0x400072F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _fillImage;

		[Token(Token = "0x4000730")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TooltipTrigger _tooltipTrigger;

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0xEA8658", Offset = "0xEA8658", VA = "0xEA8658")]
		private void Awake()
		{
		}

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0xEA467C", Offset = "0xEA467C", VA = "0xEA467C")]
		public void SetScoreObjective(int score)
		{
		}

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0xEA46BC", Offset = "0xEA46BC", VA = "0xEA46BC")]
		public void ToggleMedal(bool toggle)
		{
		}

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0xEA865C", Offset = "0xEA865C", VA = "0xEA865C")]
		public SakuraMedal()
		{
		}
	}
	[Token(Token = "0x2000165")]
	public class SliderButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x4000731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _firstTickDelay;

		[Token(Token = "0x4000732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Vector2 _tickDelayRange;

		[Token(Token = "0x4000733")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _tickAccelerationTime;

		[Token(Token = "0x4000734")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UnityEvent OnTick;

		[Token(Token = "0x4000735")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float _tickTime;

		[Token(Token = "0x4000736")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float _lastTickTime;

		[Token(Token = "0x4000737")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool _isDown;

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0xEA8664", Offset = "0xEA8664", VA = "0xEA8664", Slot = "4")]
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0xEA86A8", Offset = "0xEA86A8", VA = "0xEA86A8", Slot = "5")]
		public void OnPointerUp(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0xEA8688", Offset = "0xEA8688", VA = "0xEA8688")]
		private void Tick()
		{
		}

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0xEA86B0", Offset = "0xEA86B0", VA = "0xEA86B0")]
		private void Update()
		{
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0xEA8750", Offset = "0xEA8750", VA = "0xEA8750")]
		public SliderButton()
		{
		}
	}
	[Token(Token = "0x2000166")]
	[RequireComponent(typeof(Image))]
	public class SpriteRemoverForQuest : MonoBehaviour
	{
		[Token(Token = "0x60007E5")]
		[Address(RVA = "0xEA8768", Offset = "0xEA8768", VA = "0xEA8768")]
		private void Start()
		{
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0xEA8880", Offset = "0xEA8880", VA = "0xEA8880")]
		public SpriteRemoverForQuest()
		{
		}
	}
	[Token(Token = "0x2000167")]
	public abstract class BaseTaikoUIHandler : MonoBehaviour
	{
		[Token(Token = "0x4000738")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Header("General")]
		protected GameManager _gameManager;

		[Token(Token = "0x4000739")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected GameObject _rootObject;

		[Token(Token = "0x400073A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected bool _shown;

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0xEA8888", Offset = "0xEA8888", VA = "0xEA8888", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0xEA888C", Offset = "0xEA888C", VA = "0xEA888C", Slot = "5")]
		public virtual void Show()
		{
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0xEA88C4", Offset = "0xEA88C4", VA = "0xEA88C4", Slot = "6")]
		public virtual void Hide()
		{
		}

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0xEA88F0", Offset = "0xEA88F0", VA = "0xEA88F0")]
		protected BaseTaikoUIHandler()
		{
		}
	}
	[Token(Token = "0x2000168")]
	public class IAPUIHandler : MonoBehaviour
	{
		[Token(Token = "0x400073B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _page1;

		[Token(Token = "0x400073C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _page2;

		[Token(Token = "0x400073D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private LocalizeStringEvent _buyText;

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0xEA88F8", Offset = "0xEA88F8", VA = "0xEA88F8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0xEA8C3C", Offset = "0xEA8C3C", VA = "0xEA8C3C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0xEA8D8C", Offset = "0xEA8D8C", VA = "0xEA8D8C")]
		private void PurchaseCompleted(IAPPlatform.IAPType iapType, bool success)
		{
		}

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0xEA8A54", Offset = "0xEA8A54", VA = "0xEA8A54")]
		private void UpdateScreen()
		{
		}

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0xEA8D90", Offset = "0xEA8D90", VA = "0xEA8D90")]
		public void PurchaseFounderPack()
		{
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0xEA8DE4", Offset = "0xEA8DE4", VA = "0xEA8DE4")]
		public IAPUIHandler()
		{
		}
	}
	[Token(Token = "0x2000169")]
	public class TaikoFeedbackUIHandler : BaseTaikoUIHandler
	{
		[Token(Token = "0x400073E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RatingStar[] _ratingStars;

		[Token(Token = "0x400073F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Button _sendButton;

		[Token(Token = "0x4000740")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _thanksObject;

		[Token(Token = "0x4000741")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float _trackRating;

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0xEA8DEC", Offset = "0xEA8DEC", VA = "0xEA8DEC", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0xEA8DF0", Offset = "0xEA8DF0", VA = "0xEA8DF0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0xEA905C", Offset = "0xEA905C", VA = "0xEA905C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0xEA8F98", Offset = "0xEA8F98", VA = "0xEA8F98")]
		private void RatingClicked(float rating)
		{
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0xEA91B8", Offset = "0xEA91B8", VA = "0xEA91B8")]
		private void RatingEntered(float rating)
		{
		}

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0xEA9264", Offset = "0xEA9264", VA = "0xEA9264")]
		private void RatingExited(float rating)
		{
		}

		[Token(Token = "0x60007F7")]
		[Address(RVA = "0xEA926C", Offset = "0xEA926C", VA = "0xEA926C")]
		public void SendFeedback()
		{
		}

		[Token(Token = "0x60007F8")]
		[Address(RVA = "0xEA9820", Offset = "0xEA9820", VA = "0xEA9820")]
		public TaikoFeedbackUIHandler()
		{
		}
	}
	[Token(Token = "0x200016A")]
	public class TaikoFounderPackUIHandler : BaseTaikoUIHandler
	{
		[Token(Token = "0x4000742")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TaikoUIFlowHandler _uiFlowHandler;

		[Token(Token = "0x4000743")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private LocalizeStringEvent _buyText;

		[Token(Token = "0x60007F9")]
		[Address(RVA = "0xEA9828", Offset = "0xEA9828", VA = "0xEA9828", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0xEA982C", Offset = "0xEA982C", VA = "0xEA982C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60007FB")]
		[Address(RVA = "0xEA98F4", Offset = "0xEA98F4", VA = "0xEA98F4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60007FC")]
		[Address(RVA = "0xEA99BC", Offset = "0xEA99BC", VA = "0xEA99BC")]
		private void PurchaseCompleted(IAPPlatform.IAPType iapType, bool purchased)
		{
		}

		[Token(Token = "0x60007FD")]
		[Address(RVA = "0xEA99D4", Offset = "0xEA99D4", VA = "0xEA99D4")]
		public void Cancel()
		{
		}

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0xEA9BC0", Offset = "0xEA9BC0", VA = "0xEA9BC0")]
		public void PurchaseFounderPack()
		{
		}

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0xEA9C14", Offset = "0xEA9C14", VA = "0xEA9C14", Slot = "5")]
		public override void Show()
		{
		}

		[Token(Token = "0x6000800")]
		[Address(RVA = "0xEA9D8C", Offset = "0xEA9D8C", VA = "0xEA9D8C")]
		public TaikoFounderPackUIHandler()
		{
		}
	}
	[Token(Token = "0x200016B")]
	public class TaikoGameUIHandler : BaseTaikoUIHandler
	{
		[Token(Token = "0x4000745")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Header("Score")]
		public GameObject Score;

		[Token(Token = "0x4000746")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public LocalizeStringEvent ScoreText;

		[Token(Token = "0x4000747")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public GameObject BestScore;

		[Token(Token = "0x4000748")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public TextMeshProUGUI BestScoreText;

		[Token(Token = "0x4000749")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Header("Progress")]
		private GameObject _progressContainer;

		[Token(Token = "0x400074A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _progressFill;

		[Token(Token = "0x400074B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Header("Combo")]
		private GameObject _consecutiveHitsContainer;

		[Token(Token = "0x400074C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _consecutiveHitsTransform;

		[Token(Token = "0x400074D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private TextMeshProUGUI _consecutiveHitsText;

		[Token(Token = "0x400074E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public GameObject TaikoComboContainer;

		[Token(Token = "0x400074F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Animator TaikoComboAnimator;

		[Token(Token = "0x4000750")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public TextMeshProUGUI TaikoComboText;

		[Token(Token = "0x4000751")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private IntVariable _playerScore;

		[Token(Token = "0x14000024")]
		public event Action OnEndFlowEnded
		{
			[Token(Token = "0x6000801")]
			[Address(RVA = "0xEA9D94", Offset = "0xEA9D94", VA = "0xEA9D94")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000802")]
			[Address(RVA = "0xEA9E30", Offset = "0xEA9E30", VA = "0xEA9E30")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000803")]
		[Address(RVA = "0xEA9ECC", Offset = "0xEA9ECC", VA = "0xEA9ECC", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000804")]
		[Address(RVA = "0xEAA020", Offset = "0xEAA020", VA = "0xEAA020")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000805")]
		[Address(RVA = "0xEAA318", Offset = "0xEAA318", VA = "0xEAA318")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000806")]
		[Address(RVA = "0xEAA588", Offset = "0xEAA588", VA = "0xEAA588", Slot = "5")]
		public override void Show()
		{
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0xEAA860", Offset = "0xEAA860", VA = "0xEAA860", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0xEAA87C", Offset = "0xEAA87C", VA = "0xEAA87C")]
		public void EndGame()
		{
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0xEAA6A0", Offset = "0xEAA6A0", VA = "0xEAA6A0")]
		public void SetScore(int score)
		{
		}

		[Token(Token = "0x600080A")]
		[Address(RVA = "0xEAA910", Offset = "0xEAA910", VA = "0xEAA910")]
		public void SetBestScore(int score)
		{
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0xEAA844", Offset = "0xEAA844", VA = "0xEAA844")]
		private void SetMusicProgress(float progress)
		{
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0xEAA958", Offset = "0xEAA958", VA = "0xEAA958")]
		private void SetMultiplier(TaikoGameParams.TaikoMultiplier multiplier)
		{
		}

		[Token(Token = "0x600080D")]
		[Address(RVA = "0xEAA988", Offset = "0xEAA988", VA = "0xEAA988")]
		private void SetConsecutiveHits(int consecutiveHits, float multiplierProgress)
		{
		}

		[Token(Token = "0x600080E")]
		[Address(RVA = "0xEAA6F8", Offset = "0xEAA6F8", VA = "0xEAA6F8")]
		public void SetCombo(int combo, string animationTrigger = "", [System.Runtime.InteropServices.Optional] Color? textColor)
		{
		}

		[Token(Token = "0x600080F")]
		[Address(RVA = "0xEAAA8C", Offset = "0xEAAA8C", VA = "0xEAAA8C")]
		public TaikoGameUIHandler()
		{
		}
	}
	[Token(Token = "0x200016C")]
	public class TaikoGameUIHandler2 : BaseTaikoUIHandler
	{
		[Token(Token = "0x4000753")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Header("Score")]
		[SerializeField]
		private TextMeshProUGUI _scoreText;

		[Token(Token = "0x4000754")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private HorizontalAutoSizedIconText _bestScore;

		[Token(Token = "0x4000755")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Header("Multiplier")]
		private Image _multiplierFillImage;

		[Token(Token = "0x4000756")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TextMeshProUGUI _multiplierText;

		[Token(Token = "0x4000757")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Header("Time")]
		private Image _timeFillImage;

		[Token(Token = "0x4000758")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private TextMeshProUGUI _timeText;

		[Token(Token = "0x4000759")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Header("Combo")]
		private GameObject _consecutiveHitsContainer;

		[Token(Token = "0x400075A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _consecutiveHitsTransform;

		[Token(Token = "0x400075B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private TextMeshProUGUI _consecutiveHitsText;

		[Token(Token = "0x400075C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int _currentMultiplier;

		[Token(Token = "0x14000025")]
		public event Action OnEndFlowEnded
		{
			[Token(Token = "0x6000810")]
			[Address(RVA = "0xEAAA94", Offset = "0xEAAA94", VA = "0xEAAA94")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000811")]
			[Address(RVA = "0xEAAB30", Offset = "0xEAAB30", VA = "0xEAAB30")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000812")]
		[Address(RVA = "0xEAABCC", Offset = "0xEAABCC", VA = "0xEAABCC", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000813")]
		[Address(RVA = "0xEAABD0", Offset = "0xEAABD0", VA = "0xEAABD0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000814")]
		[Address(RVA = "0xEAAE60", Offset = "0xEAAE60", VA = "0xEAAE60")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000815")]
		[Address(RVA = "0xEAB088", Offset = "0xEAB088", VA = "0xEAB088", Slot = "5")]
		public override void Show()
		{
		}

		[Token(Token = "0x6000816")]
		[Address(RVA = "0xEAB74C", Offset = "0xEAB74C", VA = "0xEAB74C", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6000817")]
		[Address(RVA = "0xEAB768", Offset = "0xEAB768", VA = "0xEAB768")]
		public void EndGame()
		{
		}

		[Token(Token = "0x6000818")]
		[Address(RVA = "0xEAB1D4", Offset = "0xEAB1D4", VA = "0xEAB1D4")]
		public void SetScore(int score)
		{
		}

		[Token(Token = "0x6000819")]
		[Address(RVA = "0xEAB7AC", Offset = "0xEAB7AC", VA = "0xEAB7AC")]
		public void SetBestScore(int score)
		{
		}

		[Token(Token = "0x600081A")]
		[Address(RVA = "0xEAB45C", Offset = "0xEAB45C", VA = "0xEAB45C")]
		private void TimeUpdated(int time, int duration)
		{
		}

		[Token(Token = "0x600081B")]
		[Address(RVA = "0xEAB730", Offset = "0xEAB730", VA = "0xEAB730")]
		private void SetMusicProgress(float progress)
		{
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0xEAB7EC", Offset = "0xEAB7EC", VA = "0xEAB7EC")]
		private void SetMultiplier(TaikoGameParams.TaikoMultiplier multiplier)
		{
		}

		[Token(Token = "0x600081D")]
		[Address(RVA = "0xEAB884", Offset = "0xEAB884", VA = "0xEAB884")]
		private void SetConsecutiveHits(int consecutiveHits, float multiplierProgress)
		{
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0xEAB21C", Offset = "0xEAB21C", VA = "0xEAB21C")]
		public void SetCombo(int combo, [System.Runtime.InteropServices.Optional] Color? textColor, float punchScale = 0f)
		{
		}

		[Token(Token = "0x600081F")]
		[Address(RVA = "0xEAB8F8", Offset = "0xEAB8F8", VA = "0xEAB8F8")]
		public TaikoGameUIHandler2()
		{
		}
	}
	[Token(Token = "0x200016D")]
	public class TaikoIAPUIHandler : BaseTaikoUIHandler
	{
		[Token(Token = "0x400075D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TaikoUIFlowHandler _uiFlowHandler;

		[Token(Token = "0x400075E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _buyContainer;

		[Token(Token = "0x400075F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _thanksContainer;

		[Token(Token = "0x4000760")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Toggle _previewToggle;

		[Token(Token = "0x4000761")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private EventReference _previewEventRef;

		[Token(Token = "0x4000762")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private EventInstance _previewEvent;

		[Token(Token = "0x6000820")]
		[Address(RVA = "0xEAB900", Offset = "0xEAB900", VA = "0xEAB900", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000821")]
		[Address(RVA = "0xEAB904", Offset = "0xEAB904", VA = "0xEAB904")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000822")]
		[Address(RVA = "0xEAB9D4", Offset = "0xEAB9D4", VA = "0xEAB9D4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0xEABAA4", Offset = "0xEABAA4", VA = "0xEABAA4")]
		private void StopPreviewEvent()
		{
		}

		[Token(Token = "0x6000824")]
		[Address(RVA = "0xEABB50", Offset = "0xEABB50", VA = "0xEABB50")]
		public void PreviewToggleChanged(bool value)
		{
		}

		[Token(Token = "0x6000825")]
		[Address(RVA = "0xEABBD0", Offset = "0xEABBD0", VA = "0xEABBD0")]
		public void Buy()
		{
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0xEABF74", Offset = "0xEABF74", VA = "0xEABF74")]
		private void PurchaseCompleted(IAPPlatform.IAPType iapType, bool purchased)
		{
		}

		[Token(Token = "0x6000827")]
		[Address(RVA = "0xEABFBC", Offset = "0xEABFBC", VA = "0xEABFBC", Slot = "5")]
		public override void Show()
		{
		}

		[Token(Token = "0x6000828")]
		[Address(RVA = "0xEAC050", Offset = "0xEAC050", VA = "0xEAC050")]
		public TaikoIAPUIHandler()
		{
		}
	}
	[Token(Token = "0x200016E")]
	public class TaikoLeaderboardUIHandler : BaseTaikoUIHandler
	{
		[Token(Token = "0x4000763")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private LeaderboardHandler _leaderboardHandler;

		[Token(Token = "0x4000764")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Toggle _globalToggle;

		[Token(Token = "0x4000765")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Toggle _relativeToggle;

		[Token(Token = "0x4000766")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Toggle _friendsToggle;

		[Token(Token = "0x6000829")]
		[Address(RVA = "0xEAC058", Offset = "0xEAC058", VA = "0xEAC058", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600082A")]
		[Address(RVA = "0xEAC05C", Offset = "0xEAC05C", VA = "0xEAC05C")]
		public void SwitchTab(LeaderboardPlatform.EntryType entryType)
		{
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0xEAC0AC", Offset = "0xEAC0AC", VA = "0xEAC0AC")]
		public void ToggleChanged(int index)
		{
		}

		[Token(Token = "0x600082C")]
		[Address(RVA = "0xEAC0E0", Offset = "0xEAC0E0", VA = "0xEAC0E0")]
		public void DisplayLeaderboard(string key, int score = 0)
		{
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0xEAC124", Offset = "0xEAC124", VA = "0xEAC124")]
		public void Init(string key, int score = 0)
		{
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0xEAC128", Offset = "0xEAC128", VA = "0xEAC128")]
		public TaikoLeaderboardUIHandler()
		{
		}
	}
	[Token(Token = "0x200016F")]
	public class TaikoPauseUIHandler : BaseTaikoUIHandler
	{
		[Token(Token = "0x4000767")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Header("Pause")]
		[SerializeField]
		private TextMeshProUGUI _trackText;

		[Token(Token = "0x4000768")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private LocalizeStringEvent _leaderboardText;

		[Token(Token = "0x4000769")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Header("Offset")]
		private Slider _timeOffsetSlider;

		[Token(Token = "0x400076A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<GameManager.Difficulty, string> DIFFICULTY_STRING_DICTONARY;

		[Token(Token = "0x400076B")]
		private const string TRACK_FORMAT = "{0} <color=#808080>- {1}</color>";

		[Token(Token = "0x600082F")]
		[Address(RVA = "0xEAC130", Offset = "0xEAC130", VA = "0xEAC130", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000830")]
		[Address(RVA = "0xEAC134", Offset = "0xEAC134", VA = "0xEAC134")]
		public void Menu()
		{
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0xEAC17C", Offset = "0xEAC17C", VA = "0xEAC17C")]
		public void Retry()
		{
		}

		[Token(Token = "0x6000832")]
		[Address(RVA = "0xEAC200", Offset = "0xEAC200", VA = "0xEAC200")]
		public void RetryWithOffset()
		{
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0xEAC158", Offset = "0xEAC158", VA = "0xEAC158")]
		public void Resume()
		{
		}

		[Token(Token = "0x6000834")]
		[Address(RVA = "0xEAC400", Offset = "0xEAC400", VA = "0xEAC400")]
		private void SetTrackText(string difficulty)
		{
		}

		[Token(Token = "0x6000835")]
		[Address(RVA = "0xEAC488", Offset = "0xEAC488", VA = "0xEAC488", Slot = "5")]
		public override void Show()
		{
		}

		[Token(Token = "0x6000836")]
		[Address(RVA = "0xEACB28", Offset = "0xEACB28", VA = "0xEACB28")]
		public TaikoPauseUIHandler()
		{
		}
	}
	[Token(Token = "0x2000170")]
	public class TaikoScoreUIHandler : BaseTaikoUIHandler
	{
		[Serializable]
		[Token(Token = "0x2000171")]
		private struct MedalCursor
		{
			[Token(Token = "0x4000784")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public RectTransform CursorTransform;

			[Token(Token = "0x4000785")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public SakuraMedal Medal;
		}

		[Token(Token = "0x400076C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Header("General")]
		private TextMeshProUGUI _trackText;

		[Token(Token = "0x400076D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private LocalizeStringEvent _difficultyText;

		[Token(Token = "0x400076E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TaikoLeaderboardUIHandler _leaderboardHandler;

		[Token(Token = "0x400076F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Header("Score")]
		[SerializeField]
		private TextMeshProUGUI _scoreText;

		[Token(Token = "0x4000770")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private HorizontalAutoSizedIconText _bestScore;

		[Token(Token = "0x4000771")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private AchievementsDisplay _achievementsDisplay;

		[Token(Token = "0x4000772")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Header("Animation")]
		[SerializeField]
		private float _scoreAnimationTime;

		[Token(Token = "0x4000773")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		private Ease _scoreAnimationEase;

		[Token(Token = "0x4000774")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _bestScoreAnimationTime;

		[Token(Token = "0x4000775")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private Ease _bestScoreAnimationEase;

		[Token(Token = "0x4000776")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float _bestScorePunchScale;

		[Token(Token = "0x4000777")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Header("Medals Progress")]
		[SerializeField]
		private MedalProgressHandler _progressHandler;

		[Token(Token = "0x4000778")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Header("Hits Breakdown")]
		[SerializeField]
		private TextMeshProUGUI _goodHitsText;

		[Token(Token = "0x4000779")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private TextMeshProUGUI _perfectText;

		[Token(Token = "0x400077A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private TextMeshProUGUI _superText;

		[Token(Token = "0x400077B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private TextMeshProUGUI _okText;

		[Token(Token = "0x400077C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private TextMeshProUGUI _missText;

		[Token(Token = "0x400077D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private TextMeshProUGUI _maxComboText;

		[Token(Token = "0x400077E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private DG.Tweening.Tween _scoreTween;

		[Token(Token = "0x400077F")]
		private const string GOOD_HITS_FORMAT = "{0}%\n<color=#808080>{1}/{2}</color>";

		[Token(Token = "0x4000780")]
		private const string BREAKDOWN_FORMAT = "{0}% <color=#808080>- {1}</color>";

		[Token(Token = "0x4000781")]
		private const string NEW_BEST_SCORE_STRING_KEY = "NewBestScore";

		[Token(Token = "0x4000782")]
		private const string MEDALS_UNLOCKED_STRING_KEY = "MedalsUnlocked";

		[Token(Token = "0x4000783")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<GameManager.Difficulty, string> DIFFICULTY_STRING_DICTONARY;

		[Token(Token = "0x6000839")]
		[Address(RVA = "0xEACCEC", Offset = "0xEACCEC", VA = "0xEACCEC", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0xEACCF0", Offset = "0xEACCF0", VA = "0xEACCF0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600083B")]
		[Address(RVA = "0xEACD98", Offset = "0xEACD98", VA = "0xEACD98")]
		public void InitLeaderboard()
		{
		}

		[Token(Token = "0x600083C")]
		[Address(RVA = "0xEACE18", Offset = "0xEACE18", VA = "0xEACE18", Slot = "5")]
		public override void Show()
		{
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0xEACCF4", Offset = "0xEACCF4", VA = "0xEACCF4")]
		private void KillTweens()
		{
		}

		[Token(Token = "0x600083E")]
		[Address(RVA = "0xEAD49C", Offset = "0xEAD49C", VA = "0xEAD49C")]
		private void AnimateScore()
		{
		}

		[Token(Token = "0x600083F")]
		[Address(RVA = "0xEAD2EC", Offset = "0xEAD2EC", VA = "0xEAD2EC")]
		private string GetBreakdownString(TaikoGameParams.HitTolerance tolerance, int notesCount)
		{
			return null;
		}

		[Token(Token = "0x6000840")]
		[Address(RVA = "0xEAD9E4", Offset = "0xEAD9E4", VA = "0xEAD9E4")]
		public void Retry()
		{
		}

		[Token(Token = "0x6000841")]
		[Address(RVA = "0xEADA24", Offset = "0xEADA24", VA = "0xEADA24")]
		public void Continue()
		{
		}

		[Token(Token = "0x6000842")]
		[Address(RVA = "0xEADA40", Offset = "0xEADA40", VA = "0xEADA40")]
		public TaikoScoreUIHandler()
		{
		}
	}
	[Token(Token = "0x2000173")]
	public class TaikoSettingsUIHandler : BaseTaikoUIHandler
	{
		[Token(Token = "0x2000174")]
		public enum SettingTab
		{
			[Token(Token = "0x400079C")]
			Audio,
			[Token(Token = "0x400079D")]
			Gameplay,
			[Token(Token = "0x400079E")]
			None
		}

		[Serializable]
		[Token(Token = "0x2000175")]
		private struct TabData
		{
			[Token(Token = "0x400079F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public SettingTab Tab;

			[Token(Token = "0x40007A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public GameObject Container;
		}

		[Token(Token = "0x2000176")]
		[CompilerGenerated]
		private sealed class <DelayedAudioToggle>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TaikoSettingsUIHandler <>4__this;

			[Token(Token = "0x1700012F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600085B")]
				[Address(RVA = "0xEAF684", Offset = "0xEAF684", VA = "0xEAF684", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000130")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600085D")]
				[Address(RVA = "0xEAF6CC", Offset = "0xEAF6CC", VA = "0xEAF6CC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000858")]
			[Address(RVA = "0xEADE38", Offset = "0xEADE38", VA = "0xEADE38")]
			[DebuggerHidden]
			public <DelayedAudioToggle>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x6000859")]
			[Address(RVA = "0xEAF5FC", Offset = "0xEAF5FC", VA = "0xEAF5FC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600085A")]
			[Address(RVA = "0xEAF600", Offset = "0xEAF600", VA = "0xEAF600", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600085C")]
			[Address(RVA = "0xEAF68C", Offset = "0xEAF68C", VA = "0xEAF68C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400078A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Header("UI Elements")]
		[SerializeField]
		private List<TabData> _settingTabs;

		[Token(Token = "0x400078B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Toggle _audioToggle;

		[Token(Token = "0x400078C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private MarkUIForRebuild[] _uiRebuilds;

		[Token(Token = "0x400078D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Header("Audio")]
		private GameObject _mainAudioContainer;

		[Token(Token = "0x400078E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _latencyContainer;

		[Token(Token = "0x400078F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private FMODAudioSettings _audioSettings;

		[Token(Token = "0x4000790")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private StudioEventEmitter _sfxEmitter;

		[Token(Token = "0x4000791")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private StudioEventEmitter _hitsEmitter;

		[Token(Token = "0x4000792")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private StudioEventEmitter _uiEmitter;

		[Token(Token = "0x4000793")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private VolumeSlider[] _volumeSliders;

		[Token(Token = "0x4000794")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameplaySettingSlider[] _audioSliders;

		[Token(Token = "0x4000795")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Button _audioResetButton;

		[Token(Token = "0x4000796")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Header("Gameplay")]
		private GameplaySettings _gameplaySettings;

		[Token(Token = "0x4000797")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameplaySettingSlider[] _gameplaySliders;

		[Token(Token = "0x4000798")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GameplaySettingToggle[] _gameplayToggles;

		[Token(Token = "0x4000799")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private SettingTab _currentSettingTab;

		[Token(Token = "0x400079A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private float _latencyValueBeforeCalibration;

		[Token(Token = "0x6000849")]
		[Address(RVA = "0xEADDA0", Offset = "0xEADDA0", VA = "0xEADDA0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600084A")]
		[Address(RVA = "0xEADDA4", Offset = "0xEADDA4", VA = "0xEADDA4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600084B")]
		[Address(RVA = "0xEADDC4", Offset = "0xEADDC4", VA = "0xEADDC4")]
		[IteratorStateMachine(typeof(<DelayedAudioToggle>d__21))]
		private IEnumerator DelayedAudioToggle()
		{
			return null;
		}

		[Token(Token = "0x600084C")]
		[Address(RVA = "0xEADE60", Offset = "0xEADE60", VA = "0xEADE60")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600084D")]
		[Address(RVA = "0xEAE668", Offset = "0xEAE668", VA = "0xEAE668")]
		public void ChangeSettingTab(int tabIndex)
		{
		}

		[Token(Token = "0x600084E")]
		[Address(RVA = "0xEAE66C", Offset = "0xEAE66C", VA = "0xEAE66C")]
		private void RebuildContentHeight()
		{
		}

		[Token(Token = "0x600084F")]
		[Address(RVA = "0xEADE68", Offset = "0xEADE68", VA = "0xEADE68")]
		public void ChangeSettingTab(SettingTab tab)
		{
		}

		[Token(Token = "0x6000850")]
		[Address(RVA = "0xEAEC04", Offset = "0xEAEC04", VA = "0xEAEC04")]
		private void VolumeChanged(FMODAudioSettings.BusType type, float volume)
		{
		}

		[Token(Token = "0x6000851")]
		[Address(RVA = "0xEAECB8", Offset = "0xEAECB8", VA = "0xEAECB8")]
		private void GameplaySettingChanged(GameplaySettings.SettingType type, float value)
		{
		}

		[Token(Token = "0x6000852")]
		[Address(RVA = "0xEAEEE8", Offset = "0xEAEEE8", VA = "0xEAEEE8")]
		private void GameplaySettingChanged(GameplaySettings.SettingType type, bool value)
		{
		}

		[Token(Token = "0x6000853")]
		[Address(RVA = "0xEAF0C0", Offset = "0xEAF0C0", VA = "0xEAF0C0")]
		public void ResetToAudioDefaults()
		{
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0xEAF2C8", Offset = "0xEAF2C8", VA = "0xEAF2C8")]
		public void ResetToGameplayDefaults()
		{
		}

		[Token(Token = "0x6000855")]
		[Address(RVA = "0xEAF4D8", Offset = "0xEAF4D8", VA = "0xEAF4D8")]
		public void OpenCalibration()
		{
		}

		[Token(Token = "0x6000856")]
		[Address(RVA = "0xEAF544", Offset = "0xEAF544", VA = "0xEAF544")]
		public void CloseCalibration(bool validate)
		{
		}

		[Token(Token = "0x6000857")]
		[Address(RVA = "0xEAF5EC", Offset = "0xEAF5EC", VA = "0xEAF5EC")]
		public TaikoSettingsUIHandler()
		{
		}
	}
	[Token(Token = "0x2000177")]
	public class TaikoTracksUIHandler : BaseTaikoUIHandler
	{
		[Serializable]
		[Token(Token = "0x2000178")]
		private struct DifficultyToggle
		{
			[Token(Token = "0x40007BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public GameManager.Difficulty Difficulty;

			[Token(Token = "0x40007C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Toggle Toggle;
		}

		[Token(Token = "0x40007A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Header("General")]
		private TracksManager _tracksManager;

		[Token(Token = "0x40007A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TaikoLeaderboardUIHandler _leaderboardUIHandler;

		[Token(Token = "0x40007A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Header("Scroll List")]
		[SerializeField]
		private NonDraggableScrollRect _scrollRect;

		[Token(Token = "0x40007A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _scrollContentTransform;

		[Token(Token = "0x40007A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ToggleGroup _scrollToggleGroup;

		[Token(Token = "0x40007A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TrackHeaderCell _trackHeaderCellPrefab;

		[Token(Token = "0x40007AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private TrackCell _trackCellPrefab;

		[Token(Token = "0x40007AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Header("Details")]
		[SerializeField]
		private TextMeshProUGUI _titleText;

		[Token(Token = "0x40007AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private TextMeshProUGUI _artistText;

		[Token(Token = "0x40007AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Color[] _difficultyColors;

		[Token(Token = "0x40007AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private TextMeshProUGUI _difficultyText;

		[Token(Token = "0x40007AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Image _notesImage;

		[Token(Token = "0x40007B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Sprite _notesSprite;

		[Token(Token = "0x40007B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Sprite _notesCenterSprite;

		[Token(Token = "0x40007B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private TextMeshProUGUI _notesText;

		[Token(Token = "0x40007B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private TooltipTrigger _notesTooltipTrigger;

		[Token(Token = "0x40007B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private string _notesTooltipKey;

		[Token(Token = "0x40007B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private string _notesCenterTooltipKey;

		[Token(Token = "0x40007B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private TextMeshProUGUI _bpmText;

		[Token(Token = "0x40007B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private List<DifficultyToggle> _difficultyToggles;

		[Token(Token = "0x40007B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private HorizontalAutoSizedIconText _bestScore;

		[Token(Token = "0x40007B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private GameObject _medalsContainer;

		[Token(Token = "0x40007BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private SakuraMedal[] _medals;

		[Token(Token = "0x40007BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private List<TrackCell> _trackCells;

		[Token(Token = "0x40007BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private TaikoTrack _selectedTrack;

		[Token(Token = "0x40007BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private GameManager.Difficulty _selectedDifficulty;

		[Token(Token = "0x40007BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Dictionary<GameManager.Difficulty, Toggle> _difficultyTogglesDictionary;

		[Token(Token = "0x600085E")]
		[Address(RVA = "0xEAF6D4", Offset = "0xEAF6D4", VA = "0xEAF6D4", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600085F")]
		[Address(RVA = "0xEAF888", Offset = "0xEAF888", VA = "0xEAF888")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000860")]
		[Address(RVA = "0xEAFA8C", Offset = "0xEAFA8C", VA = "0xEAFA8C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000861")]
		[Address(RVA = "0xEB0538", Offset = "0xEB0538", VA = "0xEB0538")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000862")]
		[Address(RVA = "0xEAF88C", Offset = "0xEAF88C", VA = "0xEAF88C")]
		private void ClearEvents()
		{
		}

		[Token(Token = "0x6000863")]
		[Address(RVA = "0xEAFB30", Offset = "0xEAFB30", VA = "0xEAFB30")]
		private void InitTracksList()
		{
		}

		[Token(Token = "0x6000864")]
		[Address(RVA = "0xEB1024", Offset = "0xEB1024", VA = "0xEB1024")]
		private void TrackSelected(TaikoTrack track)
		{
		}

		[Token(Token = "0x6000865")]
		[Address(RVA = "0xEB05C4", Offset = "0xEB05C4", VA = "0xEB05C4")]
		private void UpdateTrack(TaikoTrack track, bool forceDifficulty = true)
		{
		}

		[Token(Token = "0x6000866")]
		[Address(RVA = "0xEB084C", Offset = "0xEB084C", VA = "0xEB084C")]
		public void DifficultySelected(int difficulty)
		{
		}

		[Token(Token = "0x6000867")]
		[Address(RVA = "0xEB1584", Offset = "0xEB1584", VA = "0xEB1584")]
		public void ShowTutorial()
		{
		}

		[Token(Token = "0x6000868")]
		[Address(RVA = "0xEB15A8", Offset = "0xEB15A8", VA = "0xEB15A8")]
		public void Play()
		{
		}

		[Token(Token = "0x6000869")]
		[Address(RVA = "0xEB1658", Offset = "0xEB1658", VA = "0xEB1658")]
		public TaikoTracksUIHandler()
		{
		}
	}
	[Token(Token = "0x200017A")]
	public class TaikoTutorialUIHandler : BaseTaikoUIHandler
	{
		[Token(Token = "0x600086E")]
		[Address(RVA = "0xEB16F0", Offset = "0xEB16F0", VA = "0xEB16F0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600086F")]
		[Address(RVA = "0xEB16F4", Offset = "0xEB16F4", VA = "0xEB16F4")]
		public void Wait()
		{
		}

		[Token(Token = "0x6000870")]
		[Address(RVA = "0xEB1710", Offset = "0xEB1710", VA = "0xEB1710")]
		public void PlayTutorial()
		{
		}

		[Token(Token = "0x6000871")]
		[Address(RVA = "0xEB1714", Offset = "0xEB1714", VA = "0xEB1714")]
		public TaikoTutorialUIHandler()
		{
		}
	}
	[Token(Token = "0x200017B")]
	public class TaikoUIFlowHandler : MonoBehaviour
	{
		[Token(Token = "0x200017C")]
		public enum ModalType
		{
			[Token(Token = "0x40007DB")]
			Pause,
			[Token(Token = "0x40007DC")]
			FounderPack
		}

		[Serializable]
		[Token(Token = "0x200017D")]
		private struct ModalHandler
		{
			[Token(Token = "0x40007DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ModalType Type;

			[Token(Token = "0x40007DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public BaseTaikoUIHandler Handler;
		}

		[Token(Token = "0x200017E")]
		private struct ObjectStatus
		{
			[Token(Token = "0x40007DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public GameObject Obj;

			[Token(Token = "0x40007E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public bool Active;

			[Token(Token = "0x600087C")]
			[Address(RVA = "0xEB23B0", Offset = "0xEB23B0", VA = "0xEB23B0")]
			public ObjectStatus(GameObject obj)
			{
			}
		}

		[Token(Token = "0x40007C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("General")]
		[SerializeField]
		private GameManager _gameManager;

		[Token(Token = "0x40007C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("Center")]
		[SerializeField]
		private GameObject _centerContainer;

		[Token(Token = "0x40007C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private BaseTaikoUIHandler _welcomeHandler;

		[Token(Token = "0x40007C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private BaseTaikoUIHandler _centerTutorialHandler;

		[Token(Token = "0x40007C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private BaseTaikoUIHandler _waitHandler;

		[Token(Token = "0x40007C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TaikoGameUIHandler2 _gameHandler;

		[Token(Token = "0x40007CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private TaikoScoreUIHandler _scoreHandler;

		[Token(Token = "0x40007CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Header("Top")]
		[SerializeField]
		private GameObject _centerTopContainer;

		[Token(Token = "0x40007CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private BaseTaikoUIHandler _iapHandler;

		[Token(Token = "0x40007CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Header("Extreme Left")]
		[SerializeField]
		private GameObject _extremeLeftContainer;

		[Token(Token = "0x40007CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private BaseTaikoUIHandler _tutorialHandler;

		[Token(Token = "0x40007CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Header("Left")]
		[SerializeField]
		private GameObject _leftContainer;

		[Token(Token = "0x40007D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private BaseTaikoUIHandler _settingsHandler;

		[Token(Token = "0x40007D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private TaikoFeedbackUIHandler _feedbackHandler;

		[Token(Token = "0x40007D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Header("Right")]
		private GameObject _rightContainer;

		[Token(Token = "0x40007D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private TaikoLeaderboardUIHandler _leaderboardUIHandler;

		[Token(Token = "0x40007D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Header("Modals")]
		private GameObject _modalScreensContainer;

		[Token(Token = "0x40007D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private List<ModalHandler> _modalHandlers;

		[Token(Token = "0x40007D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Dictionary<ModalType, BaseTaikoUIHandler> _modalHandlersDictionary;

		[Token(Token = "0x40007D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private ModalType _currentModalType;

		[Token(Token = "0x40007D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private GameManager.GameState _gameState;

		[Token(Token = "0x40007D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private List<ObjectStatus> _panelStatus;

		[Token(Token = "0x6000872")]
		[Address(RVA = "0xEB171C", Offset = "0xEB171C", VA = "0xEB171C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000873")]
		[Address(RVA = "0xEB18D0", Offset = "0xEB18D0", VA = "0xEB18D0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000874")]
		[Address(RVA = "0xEB1C04", Offset = "0xEB1C04", VA = "0xEB1C04")]
		private void EndFlowEnded()
		{
		}

		[Token(Token = "0x6000875")]
		[Address(RVA = "0xEB1C3C", Offset = "0xEB1C3C", VA = "0xEB1C3C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000876")]
		[Address(RVA = "0xEB1E64", Offset = "0xEB1E64", VA = "0xEB1E64")]
		private void GameStateChanged(GameManager.GameState prevState, GameManager.GameState nextState)
		{
		}

		[Token(Token = "0x6000877")]
		[Address(RVA = "0xEB2324", Offset = "0xEB2324", VA = "0xEB2324")]
		private void CheckIAPDisplay()
		{
		}

		[Token(Token = "0x6000878")]
		[Address(RVA = "0xEABC08", Offset = "0xEABC08", VA = "0xEABC08")]
		public void OpenModal(ModalType modal, bool hidePanels = true)
		{
		}

		[Token(Token = "0x6000879")]
		[Address(RVA = "0xEA99EC", Offset = "0xEA99EC", VA = "0xEA99EC")]
		public void CloseModal()
		{
		}

		[Token(Token = "0x600087A")]
		[Address(RVA = "0xEB23F0", Offset = "0xEB23F0", VA = "0xEB23F0")]
		private void GamePauseChanged(bool pause)
		{
		}

		[Token(Token = "0x600087B")]
		[Address(RVA = "0xEB2404", Offset = "0xEB2404", VA = "0xEB2404")]
		public TaikoUIFlowHandler()
		{
		}
	}
	[Token(Token = "0x2000180")]
	public class TaikoUIHandler : MonoBehaviour
	{
		[Token(Token = "0x40007E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Header("General")]
		private GameManager _gameManager;

		[Token(Token = "0x40007E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _container;

		[Token(Token = "0x40007E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("Score")]
		[SerializeField]
		private TextMeshProUGUI _scoreText;

		[Token(Token = "0x40007E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Header("Multiplier")]
		private Image _multiplierFillImage;

		[Token(Token = "0x40007E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TextMeshProUGUI _multiplierText;

		[Token(Token = "0x40007E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Header("Time")]
		[SerializeField]
		private Image _timeFillImage;

		[Token(Token = "0x40007EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private TextMeshProUGUI _timeText;

		[Token(Token = "0x40007EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Header("Combo")]
		[SerializeField]
		private bool _animateComboText;

		[Token(Token = "0x40007EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RectTransform _consecutiveHitsTransform;

		[Token(Token = "0x40007ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private TextMeshProUGUI _consecutiveHitsText;

		[Token(Token = "0x40007EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int _currentMultiplier;

		[Token(Token = "0x6000881")]
		[Address(RVA = "0xEB2494", Offset = "0xEB2494", VA = "0xEB2494")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000882")]
		[Address(RVA = "0xEB2498", Offset = "0xEB2498", VA = "0xEB2498")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000883")]
		[Address(RVA = "0xEB2728", Offset = "0xEB2728", VA = "0xEB2728")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000884")]
		[Address(RVA = "0xEB29C0", Offset = "0xEB29C0", VA = "0xEB29C0")]
		private void KillTweens()
		{
		}

		[Token(Token = "0x6000885")]
		[Address(RVA = "0xEB2AA8", Offset = "0xEB2AA8", VA = "0xEB2AA8")]
		private void GameStateChanged(GameManager.GameState prevState, GameManager.GameState nextState)
		{
		}

		[Token(Token = "0x6000886")]
		[Address(RVA = "0xEB2C38", Offset = "0xEB2C38", VA = "0xEB2C38")]
		private void SetScore(int score)
		{
		}

		[Token(Token = "0x6000887")]
		[Address(RVA = "0xEB2EC0", Offset = "0xEB2EC0", VA = "0xEB2EC0")]
		private void TimeUpdated(int time, int duration)
		{
		}

		[Token(Token = "0x6000888")]
		[Address(RVA = "0xEB3194", Offset = "0xEB3194", VA = "0xEB3194")]
		private void SetMusicProgress(float progress)
		{
		}

		[Token(Token = "0x6000889")]
		[Address(RVA = "0xEB31B0", Offset = "0xEB31B0", VA = "0xEB31B0")]
		private void SetMultiplier(TaikoGameParams.TaikoMultiplier multiplier)
		{
		}

		[Token(Token = "0x600088A")]
		[Address(RVA = "0xEB3248", Offset = "0xEB3248", VA = "0xEB3248")]
		private void SetConsecutiveHits(int consecutiveHits, float multiplierProgress)
		{
		}

		[Token(Token = "0x600088B")]
		[Address(RVA = "0xEB2C80", Offset = "0xEB2C80", VA = "0xEB2C80")]
		private void SetCombo(int combo, [System.Runtime.InteropServices.Optional] Color? textColor, float punchScale = 0f)
		{
		}

		[Token(Token = "0x600088C")]
		[Address(RVA = "0xEB337C", Offset = "0xEB337C", VA = "0xEB337C")]
		public TaikoUIHandler()
		{
		}
	}
	[Token(Token = "0x2000181")]
	public class TaikoWaitUIHandler : BaseTaikoUIHandler
	{
		[Token(Token = "0x40007EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TextMeshProUGUI _ctaText;

		[Token(Token = "0x600088D")]
		[Address(RVA = "0xEB3384", Offset = "0xEB3384", VA = "0xEB3384", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600088E")]
		[Address(RVA = "0xEB3388", Offset = "0xEB3388", VA = "0xEB3388")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600088F")]
		[Address(RVA = "0xEB3398", Offset = "0xEB3398", VA = "0xEB3398", Slot = "5")]
		public override void Show()
		{
		}

		[Token(Token = "0x6000890")]
		[Address(RVA = "0xEB34A0", Offset = "0xEB34A0", VA = "0xEB34A0")]
		public TaikoWaitUIHandler()
		{
		}
	}
	[Token(Token = "0x2000182")]
	public class TaikoWelcomeUIHandler : BaseTaikoUIHandler
	{
		[Token(Token = "0x40007F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Header("Gameplay")]
		private GameplaySettings _gameplaySettings;

		[Token(Token = "0x40007F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameplaySettingSlider[] _gameplaySliders;

		[Token(Token = "0x6000891")]
		[Address(RVA = "0xEB34A8", Offset = "0xEB34A8", VA = "0xEB34A8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000892")]
		[Address(RVA = "0xEB34AC", Offset = "0xEB34AC", VA = "0xEB34AC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000893")]
		[Address(RVA = "0xEB35A0", Offset = "0xEB35A0", VA = "0xEB35A0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000894")]
		[Address(RVA = "0xEB3678", Offset = "0xEB3678", VA = "0xEB3678")]
		private void GameplaySettingChanged(GameplaySettings.SettingType type, float value)
		{
		}

		[Token(Token = "0x6000895")]
		[Address(RVA = "0xEB3690", Offset = "0xEB3690", VA = "0xEB3690")]
		public void GoTutorial()
		{
		}

		[Token(Token = "0x6000896")]
		[Address(RVA = "0xEB36AC", Offset = "0xEB36AC", VA = "0xEB36AC")]
		public TaikoWelcomeUIHandler()
		{
		}
	}
	[Token(Token = "0x2000183")]
	public class TimeSlider : MonoBehaviour
	{
		[Token(Token = "0x40007F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Slider _slider;

		[Token(Token = "0x40007F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _timeText;

		[Token(Token = "0x40007F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _valueStep;

		[Token(Token = "0x6000897")]
		[Address(RVA = "0xEB36B4", Offset = "0xEB36B4", VA = "0xEB36B4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000898")]
		[Address(RVA = "0xEB36B8", Offset = "0xEB36B8", VA = "0xEB36B8")]
		public void ValueChanged(float value)
		{
		}

		[Token(Token = "0x6000899")]
		[Address(RVA = "0xEB37CC", Offset = "0xEB37CC", VA = "0xEB37CC")]
		public void Decrement()
		{
		}

		[Token(Token = "0x600089A")]
		[Address(RVA = "0xEB382C", Offset = "0xEB382C", VA = "0xEB382C")]
		public void Increment()
		{
		}

		[Token(Token = "0x600089B")]
		[Address(RVA = "0xEB388C", Offset = "0xEB388C", VA = "0xEB388C")]
		public TimeSlider()
		{
		}
	}
	[Token(Token = "0x2000184")]
	public class ToggleEventHandler : MonoBehaviour
	{
		[Token(Token = "0x40007F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public UnityEvent OnToggleEnabled;

		[Token(Token = "0x600089C")]
		[Address(RVA = "0xEB389C", Offset = "0xEB389C", VA = "0xEB389C")]
		public void Toggle(bool value)
		{
		}

		[Token(Token = "0x600089D")]
		[Address(RVA = "0xEB38B4", Offset = "0xEB38B4", VA = "0xEB38B4")]
		public ToggleEventHandler()
		{
		}
	}
	[Token(Token = "0x2000185")]
	[RequireComponent(typeof(RectTransform))]
	public class TooltipManager : MonoBehaviour
	{
		[Token(Token = "0x40007F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _tooltipTransform;

		[Token(Token = "0x40007F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LocalizeStringEvent _text;

		[Token(Token = "0x40007F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Vector2 _offset;

		[Token(Token = "0x40007F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private RectTransform _rectTransform;

		[Token(Token = "0x40007FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private RectTransform _currentSender;

		[Token(Token = "0x600089E")]
		[Address(RVA = "0xEB38BC", Offset = "0xEB38BC", VA = "0xEB38BC")]
		private void Awake()
		{
		}

		[Token(Token = "0x600089F")]
		[Address(RVA = "0xEB3914", Offset = "0xEB3914", VA = "0xEB3914")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60008A0")]
		[Address(RVA = "0xEB39CC", Offset = "0xEB39CC", VA = "0xEB39CC")]
		private Vector2 GetTooltipPosition(RectTransform origin)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60008A1")]
		[Address(RVA = "0xEB3AB8", Offset = "0xEB3AB8", VA = "0xEB3AB8")]
		public void Show(RectTransform sender, string key, params object[] args)
		{
		}

		[Token(Token = "0x60008A2")]
		[Address(RVA = "0xEB3920", Offset = "0xEB3920", VA = "0xEB3920")]
		public void Hide(RectTransform sender, bool force = false)
		{
		}

		[Token(Token = "0x60008A3")]
		[Address(RVA = "0xEB3C34", Offset = "0xEB3C34", VA = "0xEB3C34")]
		public TooltipManager()
		{
		}
	}
	[Token(Token = "0x2000186")]
	public class TooltipTrigger : MonoBehaviour
	{
		[Token(Token = "0x40007FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TooltipManager _tooltipManager;

		[Token(Token = "0x40007FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _senderTransform;

		[Token(Token = "0x40007FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		public string StringKey;

		[Token(Token = "0x40007FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		public string PlainText;

		[Token(Token = "0x60008A4")]
		[Address(RVA = "0xEB3C3C", Offset = "0xEB3C3C", VA = "0xEB3C3C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008A5")]
		[Address(RVA = "0xEB3C40", Offset = "0xEB3C40", VA = "0xEB3C40")]
		public void Enter()
		{
		}

		[Token(Token = "0x60008A6")]
		[Address(RVA = "0xEB3DC4", Offset = "0xEB3DC4", VA = "0xEB3DC4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60008A7")]
		[Address(RVA = "0xEB3E4C", Offset = "0xEB3E4C", VA = "0xEB3E4C")]
		public void Exit()
		{
		}

		[Token(Token = "0x60008A8")]
		[Address(RVA = "0xEB3ED4", Offset = "0xEB3ED4", VA = "0xEB3ED4")]
		public TooltipTrigger()
		{
		}
	}
	[Token(Token = "0x2000187")]
	public class TrackCell : MonoBehaviour
	{
		[Token(Token = "0x4000800")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Toggle _toggle;

		[Token(Token = "0x4000801")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI _titleText;

		[Token(Token = "0x4000802")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TextMeshProUGUI _timeText;

		[Token(Token = "0x4000803")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TaikoTrack _track;

		[Token(Token = "0x14000026")]
		public event Action<TaikoTrack> OnTrackSelected
		{
			[Token(Token = "0x60008A9")]
			[Address(RVA = "0xEB0F54", Offset = "0xEB0F54", VA = "0xEB0F54")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60008AA")]
			[Address(RVA = "0xEB0C48", Offset = "0xEB0C48", VA = "0xEB0C48")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x60008AB")]
		[Address(RVA = "0xEB3EDC", Offset = "0xEB3EDC", VA = "0xEB3EDC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008AC")]
		[Address(RVA = "0xEB0E18", Offset = "0xEB0E18", VA = "0xEB0E18")]
		public void Init(TaikoTrack track, ToggleGroup toggleGroup)
		{
		}

		[Token(Token = "0x60008AD")]
		[Address(RVA = "0xEB1004", Offset = "0xEB1004", VA = "0xEB1004")]
		public void ForceOn()
		{
		}

		[Token(Token = "0x60008AE")]
		[Address(RVA = "0xEB3EE0", Offset = "0xEB3EE0", VA = "0xEB3EE0")]
		public void Toggle(bool value)
		{
		}

		[Token(Token = "0x60008AF")]
		[Address(RVA = "0xEB3F04", Offset = "0xEB3F04", VA = "0xEB3F04")]
		public TrackCell()
		{
		}
	}
	[Token(Token = "0x2000188")]
	public class TrackHeaderCell : MonoBehaviour
	{
		[Token(Token = "0x4000804")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private LocalizeStringEvent _text;

		[Token(Token = "0x60008B0")]
		[Address(RVA = "0xEB3F0C", Offset = "0xEB3F0C", VA = "0xEB3F0C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008B1")]
		[Address(RVA = "0xEB0CF8", Offset = "0xEB0CF8", VA = "0xEB0CF8")]
		public void Init(string key, params object[] args)
		{
		}

		[Token(Token = "0x60008B2")]
		[Address(RVA = "0xEB3F10", Offset = "0xEB3F10", VA = "0xEB3F10")]
		public TrackHeaderCell()
		{
		}
	}
	[Token(Token = "0x2000189")]
	public class TutorialPager : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200018A")]
		private struct VideoContent
		{
			[Token(Token = "0x4000811")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public VideoClip Clip;

			[Token(Token = "0x4000812")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public RawImage Image;
		}

		[Token(Token = "0x4000805")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("General")]
		[SerializeField]
		private bool _resetOnEnable;

		[Token(Token = "0x4000806")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("UI Elements")]
		[SerializeField]
		private RectTransform _contentTransform;

		[Token(Token = "0x4000807")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Button _prevButton;

		[Token(Token = "0x4000808")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Button _nextButton;

		[Token(Token = "0x4000809")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TextMeshProUGUI _pageText;

		[Token(Token = "0x400080A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Header("Animation")]
		[SerializeField]
		private int _pageWidth;

		[Token(Token = "0x400080B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float _animationTime;

		[Token(Token = "0x400080C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Ease _animationEase;

		[Token(Token = "0x400080D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Header("Video")]
		[SerializeField]
		private VideoContent[] _videoContents;

		[Token(Token = "0x400080E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private VideoPlayer[] _videoPlayers;

		[Token(Token = "0x400080F")]
		private const string PAGE_FORMAT = "{0}/{1}";

		[Token(Token = "0x4000810")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int _contentIndex;

		[Token(Token = "0x60008B3")]
		[Address(RVA = "0xEB3F18", Offset = "0xEB3F18", VA = "0xEB3F18")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008B4")]
		[Address(RVA = "0xEB3F1C", Offset = "0xEB3F1C", VA = "0xEB3F1C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60008B5")]
		[Address(RVA = "0xEB4204", Offset = "0xEB4204", VA = "0xEB4204")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60008B6")]
		[Address(RVA = "0xEB42EC", Offset = "0xEB42EC", VA = "0xEB42EC")]
		private void PrepareCompleted(VideoPlayer source)
		{
		}

		[Token(Token = "0x60008B7")]
		[Address(RVA = "0xEB4340", Offset = "0xEB4340", VA = "0xEB4340")]
		private void UpdateIndicator()
		{
		}

		[Token(Token = "0x60008B8")]
		[Address(RVA = "0xEB400C", Offset = "0xEB400C", VA = "0xEB400C")]
		private void SnapToChild(int index, bool animated = true)
		{
		}

		[Token(Token = "0x60008B9")]
		[Address(RVA = "0xEB446C", Offset = "0xEB446C", VA = "0xEB446C")]
		public void Prev()
		{
		}

		[Token(Token = "0x60008BA")]
		[Address(RVA = "0xEB447C", Offset = "0xEB447C", VA = "0xEB447C")]
		public void Next()
		{
		}

		[Token(Token = "0x60008BB")]
		[Address(RVA = "0xEB448C", Offset = "0xEB448C", VA = "0xEB448C")]
		public TutorialPager()
		{
		}
	}
	[Token(Token = "0x200018B")]
	public class UIAudioHandler : MonoBehaviour
	{
		[Token(Token = "0x4000813")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private StudioEventEmitter _hoverEmitter;

		[Token(Token = "0x4000814")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private StudioEventEmitter _clickEmitter;

		[Token(Token = "0x4000815")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RayInteractorsActivation _rayInteractorsActivation;

		[Token(Token = "0x60008BC")]
		[Address(RVA = "0xEB44A8", Offset = "0xEB44A8", VA = "0xEB44A8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008BD")]
		[Address(RVA = "0xEB44AC", Offset = "0xEB44AC", VA = "0xEB44AC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60008BE")]
		[Address(RVA = "0xEB456C", Offset = "0xEB456C", VA = "0xEB456C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60008BF")]
		[Address(RVA = "0xEB462C", Offset = "0xEB462C", VA = "0xEB462C")]
		private void Selected(PointableCanvasEventArgs obj)
		{
		}

		[Token(Token = "0x60008C0")]
		[Address(RVA = "0xEB47A4", Offset = "0xEB47A4", VA = "0xEB47A4")]
		private void Hovered(PointableCanvasEventArgs obj)
		{
		}

		[Token(Token = "0x60008C1")]
		[Address(RVA = "0xEB491C", Offset = "0xEB491C", VA = "0xEB491C")]
		public UIAudioHandler()
		{
		}
	}
	[Token(Token = "0x200018C")]
	public class VolumeSlider : MonoBehaviour
	{
		[Token(Token = "0x4000817")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		public FMODAudioSettings.BusType BusType;

		[Token(Token = "0x4000818")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Slider _slider;

		[Token(Token = "0x4000819")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _valueStep;

		[Token(Token = "0x400081A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TextMeshProUGUI _volumeText;

		[Token(Token = "0x14000027")]
		public event Action<FMODAudioSettings.BusType, float> OnVolumeChanged
		{
			[Token(Token = "0x60008C2")]
			[Address(RVA = "0xEAE7B4", Offset = "0xEAE7B4", VA = "0xEAE7B4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60008C3")]
			[Address(RVA = "0xEAEB54", Offset = "0xEAEB54", VA = "0xEAEB54")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x60008C4")]
		[Address(RVA = "0xEB4924", Offset = "0xEB4924", VA = "0xEB4924")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008C5")]
		[Address(RVA = "0xEB4928", Offset = "0xEB4928", VA = "0xEB4928")]
		public void ValueChanged(float value)
		{
		}

		[Token(Token = "0x60008C6")]
		[Address(RVA = "0xEAE670", Offset = "0xEAE670", VA = "0xEAE670")]
		public void SetSliderValue(float value)
		{
		}

		[Token(Token = "0x60008C7")]
		[Address(RVA = "0xEB4A7C", Offset = "0xEB4A7C", VA = "0xEB4A7C")]
		public void Decrement()
		{
		}

		[Token(Token = "0x60008C8")]
		[Address(RVA = "0xEB4AD4", Offset = "0xEB4AD4", VA = "0xEB4AD4")]
		public void Increment()
		{
		}

		[Token(Token = "0x60008C9")]
		[Address(RVA = "0xEB4B2C", Offset = "0xEB4B2C", VA = "0xEB4B2C")]
		public VolumeSlider()
		{
		}
	}
}
namespace TaikoFrenzy.Managers
{
	[Token(Token = "0x200018D")]
	public class BuildProfile : ScriptableObject
	{
		[Token(Token = "0x200018E")]
		public enum ProfileType
		{
			[Token(Token = "0x4000824")]
			Development,
			[Token(Token = "0x4000825")]
			SoundDesign,
			[Token(Token = "0x4000826")]
			Release
		}

		[Token(Token = "0x400081B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ProfileType Type;

		[Token(Token = "0x400081C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Header("General")]
		public bool EnableDRMManager;

		[Token(Token = "0x400081D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		public bool EnableDebugPauseMenu;

		[Token(Token = "0x400081E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
		public bool ScanCustomTracks;

		[Token(Token = "0x400081F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string AnalyticsEnvironment;

		[Token(Token = "0x4000820")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("Track Behaviour")]
		public bool DestroyNotesOnPause;

		[Token(Token = "0x4000821")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool ShowMeasureText;

		[Token(Token = "0x4000822")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		public bool ShowToleranceDebug;

		[Token(Token = "0x60008CA")]
		[Address(RVA = "0xEB4B40", Offset = "0xEB4B40", VA = "0xEB4B40")]
		public BuildProfile()
		{
		}
	}
	[Token(Token = "0x200018F")]
	public class BuildProfileManager : MonoBehaviour
	{
		[Token(Token = "0x4000828")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BuildProfile.ProfileType _buildType;

		[Token(Token = "0x4000829")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<BuildProfile> _profiles;

		[Token(Token = "0x400082A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Dictionary<BuildProfile.ProfileType, BuildProfile> _profilesDictionary;

		[Token(Token = "0x17000131")]
		public static BuildProfileManager Instance
		{
			[Token(Token = "0x60008CB")]
			[Address(RVA = "0xEB4B48", Offset = "0xEB4B48", VA = "0xEB4B48")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60008CC")]
			[Address(RVA = "0xEB4B90", Offset = "0xEB4B90", VA = "0xEB4B90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000132")]
		public BuildProfile Current
		{
			[Token(Token = "0x60008CD")]
			[Address(RVA = "0xEB4BE8", Offset = "0xEB4BE8", VA = "0xEB4BE8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008CE")]
		[Address(RVA = "0xEB4C3C", Offset = "0xEB4C3C", VA = "0xEB4C3C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008CF")]
		[Address(RVA = "0xEB50F4", Offset = "0xEB50F4", VA = "0xEB50F4")]
		public BuildProfileManager()
		{
		}
	}
	[Token(Token = "0x2000191")]
	public class GameManager : MonoBehaviour
	{
		[Token(Token = "0x2000192")]
		public enum Difficulty
		{
			[Token(Token = "0x4000841")]
			Beginner,
			[Token(Token = "0x4000842")]
			Easy,
			[Token(Token = "0x4000843")]
			Medium,
			[Token(Token = "0x4000844")]
			Hard
		}

		[Token(Token = "0x2000193")]
		public enum GameState
		{
			[Token(Token = "0x4000846")]
			None,
			[Token(Token = "0x4000847")]
			Wait,
			[Token(Token = "0x4000848")]
			Game,
			[Token(Token = "0x4000849")]
			Score,
			[Token(Token = "0x400084A")]
			Tutorial,
			[Token(Token = "0x400084B")]
			Welcome
		}

		[Token(Token = "0x2000194")]
		[CompilerGenerated]
		private sealed class <ScoreMusic>d__48 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400084C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400084D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400084E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GameManager <>4__this;

			[Token(Token = "0x17000139")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000902")]
				[Address(RVA = "0xEB61C8", Offset = "0xEB61C8", VA = "0xEB61C8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700013A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000904")]
				[Address(RVA = "0xEB6210", Offset = "0xEB6210", VA = "0xEB6210", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008FF")]
			[Address(RVA = "0xEB5E08", Offset = "0xEB5E08", VA = "0xEB5E08")]
			[DebuggerHidden]
			public <ScoreMusic>d__48(int <>1__state)
			{
			}

			[Token(Token = "0x6000900")]
			[Address(RVA = "0xEB6070", Offset = "0xEB6070", VA = "0xEB6070", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000901")]
			[Address(RVA = "0xEB6074", Offset = "0xEB6074", VA = "0xEB6074", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000903")]
			[Address(RVA = "0xEB61D0", Offset = "0xEB61D0", VA = "0xEB61D0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000834")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool _isGamePaused;

		[Token(Token = "0x4000835")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		private bool _isPaused;

		[Token(Token = "0x4000836")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int _timeOffset;

		[Token(Token = "0x4000837")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool _pausedFromUnmounted;

		[Token(Token = "0x4000838")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private EventInstance _pauseSnapshot;

		[Token(Token = "0x4000839")]
		private const string PAUSE_SNAPSHOT_PATH = "snapshot:/Pause";

		[Token(Token = "0x400083B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Header("Game Logic")]
		public TaikoGameLogic GameLogic;

		[Token(Token = "0x400083C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Header("Gameplay")]
		private TaikoTrack _defaultTrack;

		[Token(Token = "0x400083D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public FrenzyTaiko Taiko;

		[Token(Token = "0x400083E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Header("Score")]
		public ScoreManager ScoreManager;

		[Token(Token = "0x400083F")]
		private const string FIRST_LAUNCH_PREF_KEY = "FirstLaunch";

		[Token(Token = "0x17000133")]
		public static GameManager Instance
		{
			[Token(Token = "0x60008D4")]
			[Address(RVA = "0xEB5194", Offset = "0xEB5194", VA = "0xEB5194")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60008D5")]
			[Address(RVA = "0xEB51DC", Offset = "0xEB51DC", VA = "0xEB51DC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000134")]
		public GameState CurrentState
		{
			[Token(Token = "0x60008DC")]
			[Address(RVA = "0xEB52E4", Offset = "0xEB52E4", VA = "0xEB52E4")]
			[CompilerGenerated]
			get
			{
				return default(GameState);
			}
			[Token(Token = "0x60008DD")]
			[Address(RVA = "0xEB52EC", Offset = "0xEB52EC", VA = "0xEB52EC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000135")]
		public bool InGame
		{
			[Token(Token = "0x60008DE")]
			[Address(RVA = "0xEB52F4", Offset = "0xEB52F4", VA = "0xEB52F4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000136")]
		public Difficulty CurrentDifficulty
		{
			[Token(Token = "0x60008DF")]
			[Address(RVA = "0xEB5304", Offset = "0xEB5304", VA = "0xEB5304")]
			[CompilerGenerated]
			get
			{
				return default(Difficulty);
			}
			[Token(Token = "0x60008E0")]
			[Address(RVA = "0xEB530C", Offset = "0xEB530C", VA = "0xEB530C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000137")]
		public bool IsGamePaused
		{
			[Token(Token = "0x60008E1")]
			[Address(RVA = "0xEB5314", Offset = "0xEB5314", VA = "0xEB5314")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008E2")]
			[Address(RVA = "0xEB531C", Offset = "0xEB531C", VA = "0xEB531C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000138")]
		public TaikoTrack CurrentTrack
		{
			[Token(Token = "0x60008E3")]
			[Address(RVA = "0xEB5340", Offset = "0xEB5340", VA = "0xEB5340")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60008E4")]
			[Address(RVA = "0xEB5348", Offset = "0xEB5348", VA = "0xEB5348")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x14000028")]
		public event Action<GameState, GameState> OnStateChanged
		{
			[Token(Token = "0x60008D6")]
			[Address(RVA = "0xEB1AA4", Offset = "0xEB1AA4", VA = "0xEB1AA4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60008D7")]
			[Address(RVA = "0xEB1DB4", Offset = "0xEB1DB4", VA = "0xEB1DB4")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000029")]
		public event Action<int> OnBestScoreGet
		{
			[Token(Token = "0x60008D8")]
			[Address(RVA = "0xEAA248", Offset = "0xEAA248", VA = "0xEAA248")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60008D9")]
			[Address(RVA = "0xEAA4D8", Offset = "0xEAA4D8", VA = "0xEAA4D8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400002A")]
		public event Action<bool> OnGamePauseChanged
		{
			[Token(Token = "0x60008DA")]
			[Address(RVA = "0xEB1B54", Offset = "0xEB1B54", VA = "0xEB1B54")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60008DB")]
			[Address(RVA = "0xEB5234", Offset = "0xEB5234", VA = "0xEB5234")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x60008E5")]
		[Address(RVA = "0xEB5350", Offset = "0xEB5350", VA = "0xEB5350")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008E6")]
		[Address(RVA = "0xEB53B8", Offset = "0xEB53B8", VA = "0xEB53B8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60008E7")]
		[Address(RVA = "0xEB54A4", Offset = "0xEB54A4", VA = "0xEB54A4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60008E8")]
		[Address(RVA = "0xEB5590", Offset = "0xEB5590", VA = "0xEB5590")]
		private void Start()
		{
		}

		[Token(Token = "0x60008E9")]
		[Address(RVA = "0xEB565C", Offset = "0xEB565C", VA = "0xEB565C")]
		private void ChangeToState(GameState state)
		{
		}

		[Token(Token = "0x60008EA")]
		[Address(RVA = "0xEB5D94", Offset = "0xEB5D94", VA = "0xEB5D94")]
		[IteratorStateMachine(typeof(<ScoreMusic>d__48))]
		private IEnumerator ScoreMusic()
		{
			return null;
		}

		[Token(Token = "0x60008EB")]
		[Address(RVA = "0xEAC174", Offset = "0xEAC174", VA = "0xEAC174")]
		public void Wait()
		{
		}

		[Token(Token = "0x60008EC")]
		[Address(RVA = "0xEB1620", Offset = "0xEB1620", VA = "0xEB1620")]
		public void StartGame(TaikoTrack track, Difficulty difficulty, int timeOffset = 0)
		{
		}

		[Token(Token = "0x60008ED")]
		[Address(RVA = "0xEAC1C4", Offset = "0xEAC1C4", VA = "0xEAC1C4")]
		public void RetryGame(int timeOffset = 0)
		{
		}

		[Token(Token = "0x60008EE")]
		[Address(RVA = "0xEB5E30", Offset = "0xEB5E30", VA = "0xEB5E30")]
		public void ShowScore()
		{
		}

		[Token(Token = "0x60008EF")]
		[Address(RVA = "0xEB15A0", Offset = "0xEB15A0", VA = "0xEB15A0")]
		public void ShowTutorial()
		{
		}

		[Token(Token = "0x60008F0")]
		[Address(RVA = "0xEB5654", Offset = "0xEB5654", VA = "0xEB5654")]
		public void ShowWelcome()
		{
		}

		[Token(Token = "0x60008F1")]
		[Address(RVA = "0xEA94D8", Offset = "0xEA94D8", VA = "0xEA94D8")]
		public UserProgressSave.DifficultyProgress GetUserProgress(string trackName, Difficulty difficulty)
		{
			return default(UserProgressSave.DifficultyProgress);
		}

		[Token(Token = "0x60008F2")]
		[Address(RVA = "0xEB102C", Offset = "0xEB102C", VA = "0xEB102C")]
		public int GetBestScore(string trackName, Difficulty difficulty)
		{
			return default(int);
		}

		[Token(Token = "0x60008F3")]
		[Address(RVA = "0xEAA2F8", Offset = "0xEAA2F8", VA = "0xEAA2F8")]
		public int GetBestScore()
		{
			return default(int);
		}

		[Token(Token = "0x60008F4")]
		[Address(RVA = "0xEB108C", Offset = "0xEB108C", VA = "0xEB108C")]
		public void GetTrackMedalStates(string trackName, Difficulty difficulty, out List<TaikoTrack.MedalType> alreadyUnlocked, out List<TaikoTrack.MedalType> newUnlocked, int score = 0)
		{
		}

		[Token(Token = "0x60008F5")]
		[Address(RVA = "0xEAD9B8", Offset = "0xEAD9B8", VA = "0xEAD9B8")]
		public void GetTrackMedalStates(out List<TaikoTrack.MedalType> alreadyUnlocked, out List<TaikoTrack.MedalType> newUnlocked, int score = 0)
		{
		}

		[Token(Token = "0x60008F6")]
		[Address(RVA = "0xEB5ADC", Offset = "0xEB5ADC", VA = "0xEB5ADC")]
		public void SaveProgress()
		{
		}

		[Token(Token = "0x60008F7")]
		[Address(RVA = "0xEAC334", Offset = "0xEAC334", VA = "0xEAC334")]
		public void SetGamePause(bool pause)
		{
		}

		[Token(Token = "0x60008F8")]
		[Address(RVA = "0xEB5E38", Offset = "0xEB5E38", VA = "0xEB5E38")]
		private void SetPause(bool pause)
		{
		}

		[Token(Token = "0x60008F9")]
		[Address(RVA = "0xEB5F98", Offset = "0xEB5F98", VA = "0xEB5F98")]
		private void OnApplicationPause(bool pause)
		{
		}

		[Token(Token = "0x60008FA")]
		[Address(RVA = "0xEB5FA0", Offset = "0xEB5FA0", VA = "0xEB5FA0")]
		private void OnApplicationFocus(bool focus)
		{
		}

		[Token(Token = "0x60008FB")]
		[Address(RVA = "0xEB5FAC", Offset = "0xEB5FAC", VA = "0xEB5FAC")]
		private void HMDUnmounted()
		{
		}

		[Token(Token = "0x60008FC")]
		[Address(RVA = "0xEB5FC8", Offset = "0xEB5FC8", VA = "0xEB5FC8")]
		private void HMDMounted()
		{
		}

		[Token(Token = "0x60008FD")]
		[Address(RVA = "0xEB5FE8", Offset = "0xEB5FE8", VA = "0xEB5FE8")]
		private void Update()
		{
		}

		[Token(Token = "0x60008FE")]
		[Address(RVA = "0xEB6068", Offset = "0xEB6068", VA = "0xEB6068")]
		public GameManager()
		{
		}
	}
	[Token(Token = "0x2000195")]
	public class GameplaySettings : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000196")]
		private struct SettingData<T>
		{
			[Token(Token = "0x400085A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public SettingType Type;

			[Token(Token = "0x400085B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string SettingParam;

			[Token(Token = "0x400085C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T DefaultValue;
		}

		[Token(Token = "0x2000197")]
		public enum SettingType
		{
			[Token(Token = "0x400085E")]
			TaikoHeight,
			[Token(Token = "0x400085F")]
			HeadOffset,
			[Token(Token = "0x4000860")]
			HitLatency,
			[Token(Token = "0x4000861")]
			BeatIndicators,
			[Token(Token = "0x4000862")]
			HapticFeedbacks,
			[Token(Token = "0x4000863")]
			HitBarHolo,
			[Token(Token = "0x4000864")]
			Hands,
			[Token(Token = "0x4000865")]
			HitHelpers,
			[Token(Token = "0x4000866")]
			LeftyMode
		}

		[Token(Token = "0x4000850")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TaikoGameLogic _gameLogic;

		[Token(Token = "0x4000851")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TrackPathHandler _trackPathHandler;

		[Token(Token = "0x4000852")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _taikoVerticalTransform;

		[Token(Token = "0x4000853")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _uiTransform;

		[Token(Token = "0x4000854")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private FrenzyTaiko _taiko;

		[Token(Token = "0x4000855")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform _playAreaTransform;

		[Token(Token = "0x4000856")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<SettingData<float>> _floatSettingsList;

		[Token(Token = "0x4000857")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private List<SettingData<bool>> _boolSettingsList;

		[Token(Token = "0x4000858")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Dictionary<SettingType, SettingData<float>> _floatSettingsDictionary;

		[Token(Token = "0x4000859")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Dictionary<SettingType, SettingData<bool>> _boolSettingsDictionary;

		[Token(Token = "0x1700013B")]
		public static GameplaySettings Instance
		{
			[Token(Token = "0x6000905")]
			[Address(RVA = "0xEB6218", Offset = "0xEB6218", VA = "0xEB6218")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000906")]
			[Address(RVA = "0xEB6260", Offset = "0xEB6260", VA = "0xEB6260")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000907")]
		[Address(RVA = "0xEB62B8", Offset = "0xEB62B8", VA = "0xEB62B8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000908")]
		[Address(RVA = "0xEAECD0", Offset = "0xEAECD0", VA = "0xEAECD0")]
		public void SetFloat(SettingType type, float value)
		{
		}

		[Token(Token = "0x6000909")]
		[Address(RVA = "0xEAEF04", Offset = "0xEAEF04", VA = "0xEAEF04")]
		public void SetBool(SettingType type, bool value)
		{
		}

		[Token(Token = "0x600090A")]
		[Address(RVA = "0xEAE864", Offset = "0xEAE864", VA = "0xEAE864")]
		public float GetFloat(SettingType type)
		{
			return default(float);
		}

		[Token(Token = "0x600090B")]
		[Address(RVA = "0xEAE9BC", Offset = "0xEAE9BC", VA = "0xEAE9BC")]
		public bool GetBool(SettingType type)
		{
			return default(bool);
		}

		[Token(Token = "0x600090C")]
		[Address(RVA = "0xEAF198", Offset = "0xEAF198", VA = "0xEAF198")]
		public float GetDefaultFloat(SettingType type)
		{
			return default(float);
		}

		[Token(Token = "0x600090D")]
		[Address(RVA = "0xEAF3A4", Offset = "0xEAF3A4", VA = "0xEAF3A4")]
		public bool GetDefaultBool(SettingType type)
		{
			return default(bool);
		}

		[Token(Token = "0x600090E")]
		[Address(RVA = "0xEB685C", Offset = "0xEB685C", VA = "0xEB685C")]
		public GameplaySettings()
		{
		}
	}
	[Token(Token = "0x2000199")]
	public class ScoreManager : MonoBehaviour
	{
		[Token(Token = "0x4000871")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TaikoGameLogic _gameLogic;

		[Token(Token = "0x4000872")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ActiveComboManager _activeComboManager;

		[Token(Token = "0x4000873")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform _floatingTextTransform;

		[Token(Token = "0x4000874")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TaikoGameParams _gameParams;

		[Token(Token = "0x4000875")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private TaikoGameParams.TaikoMultiplier _currentTaikoMultiplier;

		[Token(Token = "0x4000876")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int _consecutiveHits;

		[Token(Token = "0x4000877")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private int _multiplierHits;

		[Token(Token = "0x4000878")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private int _multiplierLevel;

		[Token(Token = "0x4000879")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private bool _playMultiplierMusic;

		[Token(Token = "0x400087A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9D")]
		private bool _activeComboEnabled;

		[Token(Token = "0x1700013C")]
		public static ScoreManager Instance
		{
			[Token(Token = "0x600091B")]
			[Address(RVA = "0xEB6D34", Offset = "0xEB6D34", VA = "0xEB6D34")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600091C")]
			[Address(RVA = "0xEB6D7C", Offset = "0xEB6D7C", VA = "0xEB6D7C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700013D")]
		public TrackSession Session
		{
			[Token(Token = "0x600091D")]
			[Address(RVA = "0xEB6DD4", Offset = "0xEB6DD4", VA = "0xEB6DD4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600091E")]
			[Address(RVA = "0xEB6DDC", Offset = "0xEB6DDC", VA = "0xEB6DDC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1400002B")]
		public event Action<TaikoGameParams.TaikoMultiplier> OnMultiplierUpdated
		{
			[Token(Token = "0x6000915")]
			[Address(RVA = "0xEB6914", Offset = "0xEB6914", VA = "0xEB6914")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000916")]
			[Address(RVA = "0xEB69C4", Offset = "0xEB69C4", VA = "0xEB69C4")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400002C")]
		public event Action<int, float> OnConsecutiveHitsUpdated
		{
			[Token(Token = "0x6000917")]
			[Address(RVA = "0xEB6A74", Offset = "0xEB6A74", VA = "0xEB6A74")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000918")]
			[Address(RVA = "0xEB6B24", Offset = "0xEB6B24", VA = "0xEB6B24")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400002D")]
		public event Action<int> OnScoreUpdated
		{
			[Token(Token = "0x6000919")]
			[Address(RVA = "0xEB6BD4", Offset = "0xEB6BD4", VA = "0xEB6BD4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600091A")]
			[Address(RVA = "0xEB6C84", Offset = "0xEB6C84", VA = "0xEB6C84")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x600091F")]
		[Address(RVA = "0xEB6DE4", Offset = "0xEB6DE4", VA = "0xEB6DE4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000920")]
		[Address(RVA = "0xEB6E3C", Offset = "0xEB6E3C", VA = "0xEB6E3C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000921")]
		[Address(RVA = "0xEB7194", Offset = "0xEB7194", VA = "0xEB7194")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000922")]
		[Address(RVA = "0xEB74EC", Offset = "0xEB74EC", VA = "0xEB74EC")]
		public void Init(TaikoTrack track, GameManager.Difficulty difficulty, TaikoGameParams gameParams)
		{
		}

		[Token(Token = "0x6000923")]
		[Address(RVA = "0xEB766C", Offset = "0xEB766C", VA = "0xEB766C")]
		private void ActiveComboEnabled(bool comboEnabled)
		{
		}

		[Token(Token = "0x6000924")]
		[Address(RVA = "0xEB791C", Offset = "0xEB791C", VA = "0xEB791C")]
		private void NoteHit(TaikoStick stick, TaikoGameParams.HitTolerance tolerance, bool successAccent, bool rumbleSuccess)
		{
		}

		[Token(Token = "0x6000925")]
		[Address(RVA = "0xEB7F24", Offset = "0xEB7F24", VA = "0xEB7F24")]
		private void NoteHitResult(TaikoHitChecker.TaikoHitResult hitResult)
		{
		}

		[Token(Token = "0x6000926")]
		[Address(RVA = "0xEB75A0", Offset = "0xEB75A0", VA = "0xEB75A0")]
		private void ResetScoreMultiplier()
		{
		}

		[Token(Token = "0x6000927")]
		[Address(RVA = "0xEB7DC4", Offset = "0xEB7DC4", VA = "0xEB7DC4")]
		private void SetConsecutiveHits(int hits)
		{
		}

		[Token(Token = "0x6000928")]
		[Address(RVA = "0xEB7680", Offset = "0xEB7680", VA = "0xEB7680")]
		private void SetScoreMultiplier(int multiplierLevel)
		{
		}

		[Token(Token = "0x6000929")]
		[Address(RVA = "0xEB75A8", Offset = "0xEB75A8", VA = "0xEB75A8")]
		public void ResetScore()
		{
		}

		[Token(Token = "0x600092A")]
		[Address(RVA = "0xEB7D84", Offset = "0xEB7D84", VA = "0xEB7D84")]
		private void AddScore(int score)
		{
		}

		[Token(Token = "0x600092B")]
		[Address(RVA = "0xEB80D0", Offset = "0xEB80D0", VA = "0xEB80D0")]
		public ScoreManager()
		{
		}
	}
}
namespace TaikoFrenzy.Gameplay
{
	[Token(Token = "0x200019B")]
	public class AccentPetalsAnimationLink : MonoBehaviour
	{
		[Token(Token = "0x400087C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Material _masterMaterial;

		[Token(Token = "0x400087D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _animAlpha;

		[Token(Token = "0x400087E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MeshRenderer[] _petals;

		[Token(Token = "0x400087F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Material _materialInstance;

		[Token(Token = "0x600092E")]
		[Address(RVA = "0xEB80F4", Offset = "0xEB80F4", VA = "0xEB80F4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600092F")]
		[Address(RVA = "0xEB8164", Offset = "0xEB8164", VA = "0xEB8164")]
		private void Start()
		{
		}

		[Token(Token = "0x6000930")]
		[Address(RVA = "0xEB81C8", Offset = "0xEB81C8", VA = "0xEB81C8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000931")]
		[Address(RVA = "0xEB81FC", Offset = "0xEB81FC", VA = "0xEB81FC")]
		public AccentPetalsAnimationLink()
		{
		}
	}
	[Token(Token = "0x200019C")]
	public class ActiveComboGameplayGauge : MonoBehaviour
	{
		[Token(Token = "0x4000880")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _comboBar;

		[Token(Token = "0x4000881")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Color _activeColor;

		[Token(Token = "0x4000882")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Color _defaultColor;

		[Token(Token = "0x6000932")]
		[Address(RVA = "0xEB820C", Offset = "0xEB820C", VA = "0xEB820C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000933")]
		[Address(RVA = "0xEB8240", Offset = "0xEB8240", VA = "0xEB8240")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000934")]
		[Address(RVA = "0xEB8554", Offset = "0xEB8554", VA = "0xEB8554")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000935")]
		[Address(RVA = "0xEB8868", Offset = "0xEB8868", VA = "0xEB8868")]
		private void OnCanConsumeCombo(bool canConsume)
		{
		}

		[Token(Token = "0x6000936")]
		[Address(RVA = "0xEB892C", Offset = "0xEB892C", VA = "0xEB892C")]
		private void OnComboEnabled(bool enabled)
		{
		}

		[Token(Token = "0x6000937")]
		[Address(RVA = "0xEB89F0", Offset = "0xEB89F0", VA = "0xEB89F0")]
		private void OnValueUpdated(float value)
		{
		}

		[Token(Token = "0x6000938")]
		[Address(RVA = "0xEB8A0C", Offset = "0xEB8A0C", VA = "0xEB8A0C")]
		public ActiveComboGameplayGauge()
		{
		}
	}
	[Token(Token = "0x200019D")]
	public class ActiveComboManager : MonoBehaviour
	{
		[Token(Token = "0x4000887")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TaikoGameLogic _taikoGameLogic;

		[Token(Token = "0x4000888")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TaikoGameParams _gameParams;

		[Token(Token = "0x4000889")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private EventReference _comboReadyEventReference;

		[Token(Token = "0x400088A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private EventReference _comboActivationEventReference;

		[Token(Token = "0x400088B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private EventReference _comboActivationNoteBurstEventReference;

		[Token(Token = "0x400088C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform _noteBurstPosition;

		[Token(Token = "0x400088D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private EventReference _comboEndEventReference;

		[Token(Token = "0x400088E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool _isActive;

		[Token(Token = "0x400088F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		private bool _canConsume;

		[Token(Token = "0x4000890")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private int _barCount;

		[Token(Token = "0x4000891")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float _currentActiveCombo;

		[Token(Token = "0x4000892")]
		private const float TRIGGER_MAX = 0.95f;

		[Token(Token = "0x1700013E")]
		public static ActiveComboManager Instance
		{
			[Token(Token = "0x6000939")]
			[Address(RVA = "0xEB8A14", Offset = "0xEB8A14", VA = "0xEB8A14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600093A")]
			[Address(RVA = "0xEB8A5C", Offset = "0xEB8A5C", VA = "0xEB8A5C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700013F")]
		public bool IsActive
		{
			[Token(Token = "0x6000941")]
			[Address(RVA = "0xEB8AB4", Offset = "0xEB8AB4", VA = "0xEB8AB4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000140")]
		public bool CanConsume
		{
			[Token(Token = "0x6000942")]
			[Address(RVA = "0xEB8ABC", Offset = "0xEB8ABC", VA = "0xEB8ABC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000141")]
		public float CurrentActiveCombo
		{
			[Token(Token = "0x6000943")]
			[Address(RVA = "0xEB8AC4", Offset = "0xEB8AC4", VA = "0xEB8AC4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000944")]
			[Address(RVA = "0xEB8ACC", Offset = "0xEB8ACC", VA = "0xEB8ACC")]
			set
			{
			}
		}

		[Token(Token = "0x1400002E")]
		public event Action<bool> OnComboEnabled
		{
			[Token(Token = "0x600093B")]
			[Address(RVA = "0xEB70E4", Offset = "0xEB70E4", VA = "0xEB70E4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600093C")]
			[Address(RVA = "0xEB743C", Offset = "0xEB743C", VA = "0xEB743C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400002F")]
		public event Action<bool> OnCanConsumeCombo
		{
			[Token(Token = "0x600093D")]
			[Address(RVA = "0xEB83F4", Offset = "0xEB83F4", VA = "0xEB83F4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600093E")]
			[Address(RVA = "0xEB8708", Offset = "0xEB8708", VA = "0xEB8708")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000030")]
		public event Action<float> OnValueUpdated
		{
			[Token(Token = "0x600093F")]
			[Address(RVA = "0xEB84A4", Offset = "0xEB84A4", VA = "0xEB84A4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000940")]
			[Address(RVA = "0xEB87B8", Offset = "0xEB87B8", VA = "0xEB87B8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000945")]
		[Address(RVA = "0xEB8CAC", Offset = "0xEB8CAC", VA = "0xEB8CAC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000946")]
		[Address(RVA = "0xEB8D04", Offset = "0xEB8D04", VA = "0xEB8D04")]
		private void Start()
		{
		}

		[Token(Token = "0x6000947")]
		[Address(RVA = "0xEB8D0C", Offset = "0xEB8D0C", VA = "0xEB8D0C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000948")]
		[Address(RVA = "0xEB8E2C", Offset = "0xEB8E2C", VA = "0xEB8E2C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000949")]
		[Address(RVA = "0xEB8F4C", Offset = "0xEB8F4C", VA = "0xEB8F4C")]
		private void TaikoNoteHit(TaikoStick stick, TaikoGameParams.HitTolerance tolerance, bool successAccent, bool rumbleSuccess = false)
		{
		}

		[Token(Token = "0x600094A")]
		[Address(RVA = "0xEB904C", Offset = "0xEB904C", VA = "0xEB904C")]
		private void ManagerStateUpdated(GameManager.GameState CurrentState, GameManager.GameState State)
		{
		}

		[Token(Token = "0x600094B")]
		[Address(RVA = "0xEB8BF4", Offset = "0xEB8BF4", VA = "0xEB8BF4")]
		private void Reset(bool fullReset = true)
		{
		}

		[Token(Token = "0x600094C")]
		[Address(RVA = "0xEB9074", Offset = "0xEB9074", VA = "0xEB9074")]
		private void Update()
		{
		}

		[Token(Token = "0x600094D")]
		[Address(RVA = "0xEB9370", Offset = "0xEB9370", VA = "0xEB9370")]
		private bool IsGestureTriggered()
		{
			return default(bool);
		}

		[Token(Token = "0x600094E")]
		[Address(RVA = "0xEB9234", Offset = "0xEB9234", VA = "0xEB9234")]
		private bool IsGestureDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x600094F")]
		[Address(RVA = "0xEB9434", Offset = "0xEB9434", VA = "0xEB9434")]
		public ActiveComboManager()
		{
		}
	}
	[Token(Token = "0x200019E")]
	public class ActiveComboOnEnableState : ActiveComboState
	{
		[Token(Token = "0x4000893")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected bool _canConsumeFilter;

		[Token(Token = "0x6000950")]
		[Address(RVA = "0xEB943C", Offset = "0xEB943C", VA = "0xEB943C", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000951")]
		[Address(RVA = "0xEB9568", Offset = "0xEB9568", VA = "0xEB9568", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000952")]
		[Address(RVA = "0xEB956C", Offset = "0xEB956C", VA = "0xEB956C", Slot = "7")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000953")]
		[Address(RVA = "0xEB9570", Offset = "0xEB9570", VA = "0xEB9570")]
		public ActiveComboOnEnableState()
		{
		}
	}
	[Token(Token = "0x200019F")]
	public class ActiveComboState : MonoBehaviour
	{
		[Token(Token = "0x4000894")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected GameObject _activeComboFX;

		[Token(Token = "0x4000895")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected bool _enableGameObject;

		[Token(Token = "0x4000896")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[SerializeField]
		protected bool _resetParticles;

		[Token(Token = "0x4000897")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		[SerializeField]
		protected bool _stopEmitting;

		[Token(Token = "0x4000898")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
		[SerializeField]
		protected bool _inverseState;

		[Token(Token = "0x4000899")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ParticleSystem[] _systems;

		[Token(Token = "0x6000954")]
		[Address(RVA = "0xEB9590", Offset = "0xEB9590", VA = "0xEB9590", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000955")]
		[Address(RVA = "0xEB94EC", Offset = "0xEB94EC", VA = "0xEB94EC", Slot = "5")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x6000956")]
		[Address(RVA = "0xEB95F0", Offset = "0xEB95F0", VA = "0xEB95F0", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000957")]
		[Address(RVA = "0xEB969C", Offset = "0xEB969C", VA = "0xEB969C", Slot = "7")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000958")]
		[Address(RVA = "0xEB9748", Offset = "0xEB9748", VA = "0xEB9748", Slot = "8")]
		public virtual void EnableActiveCombo(bool enabled)
		{
		}

		[Token(Token = "0x6000959")]
		[Address(RVA = "0xEB9580", Offset = "0xEB9580", VA = "0xEB9580")]
		public ActiveComboState()
		{
		}
	}
	[Token(Token = "0x20001A0")]
	public class BurstComboState : ActiveComboState
	{
		[Token(Token = "0x400089A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private EventReference _eventReference;

		[Token(Token = "0x600095A")]
		[Address(RVA = "0xEB9834", Offset = "0xEB9834", VA = "0xEB9834", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x600095B")]
		[Address(RVA = "0xEB9854", Offset = "0xEB9854", VA = "0xEB9854", Slot = "8")]
		public override void EnableActiveCombo(bool enabled)
		{
		}

		[Token(Token = "0x600095C")]
		[Address(RVA = "0xEB98F0", Offset = "0xEB98F0", VA = "0xEB98F0")]
		public BurstComboState()
		{
		}
	}
	[Token(Token = "0x20001A1")]
	public class ComboBurstParticleAttractor : MonoBehaviour
	{
		[Token(Token = "0x20001A2")]
		public class ParticleData
		{
			[Token(Token = "0x40008A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform Target;

			[Token(Token = "0x40008A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float Speed;

			[Token(Token = "0x40008A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float Delay;

			[Token(Token = "0x40008A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 StartPosition;

			[Token(Token = "0x40008A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public bool Travel;

			[Token(Token = "0x40008A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float ZOffset;

			[Token(Token = "0x40008AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public bool PlayImpact;

			[Token(Token = "0x6000964")]
			[Address(RVA = "0xEB9C5C", Offset = "0xEB9C5C", VA = "0xEB9C5C")]
			public ParticleData()
			{
			}
		}

		[Token(Token = "0x400089B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TrackPathHandler _pathHandler;

		[Token(Token = "0x400089C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ParticleSystem _particleSystem;

		[Token(Token = "0x400089D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Vector2 _minMaxSpeed;

		[Token(Token = "0x400089E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Vector2 _minMaxDelay;

		[Token(Token = "0x400089F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Vector2 _minMaxForwardDistanceFromTarget;

		[Token(Token = "0x40008A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ParticleSystem.Particle[] _particles;

		[Token(Token = "0x40008A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<Vector4> _customData1;

		[Token(Token = "0x40008A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Dictionary<int, ParticleData> _particlesData;

		[Token(Token = "0x40008A3")]
		private const float SQR_DISTANCE_TOLERANCE = 0.04f;

		[Token(Token = "0x17000142")]
		public Vector2 MinMaxSpeed
		{
			[Token(Token = "0x600095D")]
			[Address(RVA = "0xEB9900", Offset = "0xEB9900", VA = "0xEB9900")]
			get
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x17000143")]
		public Vector2 MinMaxDelay
		{
			[Token(Token = "0x600095E")]
			[Address(RVA = "0xEB9908", Offset = "0xEB9908", VA = "0xEB9908")]
			get
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x17000144")]
		public Vector2 MinMaxForwardDistanceFromTarget
		{
			[Token(Token = "0x600095F")]
			[Address(RVA = "0xEB9910", Offset = "0xEB9910", VA = "0xEB9910")]
			get
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x6000960")]
		[Address(RVA = "0xEB9918", Offset = "0xEB9918", VA = "0xEB9918")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000961")]
		[Address(RVA = "0xEB99A0", Offset = "0xEB99A0", VA = "0xEB99A0")]
		public void SetupBurst()
		{
		}

		[Token(Token = "0x6000962")]
		[Address(RVA = "0xEB9C64", Offset = "0xEB9C64", VA = "0xEB9C64")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000963")]
		[Address(RVA = "0xEBA098", Offset = "0xEBA098", VA = "0xEBA098")]
		public ComboBurstParticleAttractor()
		{
		}
	}
	[Token(Token = "0x20001A3")]
	public class ConsumeAndActiveComboState : ActiveComboState
	{
		[Token(Token = "0x6000965")]
		[Address(RVA = "0xEBA170", Offset = "0xEBA170", VA = "0xEBA170", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000966")]
		[Address(RVA = "0xEBA2A4", Offset = "0xEBA2A4", VA = "0xEBA2A4", Slot = "7")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000967")]
		[Address(RVA = "0xEBA3D8", Offset = "0xEBA3D8", VA = "0xEBA3D8")]
		private void OnCanConsumeCombo(bool canConsume)
		{
		}

		[Token(Token = "0x6000968")]
		[Address(RVA = "0xEBA400", Offset = "0xEBA400", VA = "0xEBA400")]
		private void OnComboEnabled(bool enabled)
		{
		}

		[Token(Token = "0x6000969")]
		[Address(RVA = "0xEBA430", Offset = "0xEBA430", VA = "0xEBA430")]
		public ConsumeAndActiveComboState()
		{
		}
	}
	[Token(Token = "0x20001A4")]
	public class ConsumeComboState : ActiveComboState
	{
		[Token(Token = "0x600096A")]
		[Address(RVA = "0xEBA440", Offset = "0xEBA440", VA = "0xEBA440", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x600096B")]
		[Address(RVA = "0xEBA4BC", Offset = "0xEBA4BC", VA = "0xEBA4BC", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600096C")]
		[Address(RVA = "0xEBA568", Offset = "0xEBA568", VA = "0xEBA568", Slot = "7")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600096D")]
		[Address(RVA = "0xEBA614", Offset = "0xEBA614", VA = "0xEBA614")]
		public ConsumeComboState()
		{
		}
	}
	[Token(Token = "0x20001A5")]
	public class BeatAnimation : MonoBehaviour
	{
		[Token(Token = "0x40008AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected AnimationCurve _smoothingCurve;

		[Token(Token = "0x17000145")]
		public AnimationCurve SmoothingCurve
		{
			[Token(Token = "0x600096E")]
			[Address(RVA = "0xEBA624", Offset = "0xEBA624", VA = "0xEBA624")]
			get
			{
				return null;
			}
			[Token(Token = "0x600096F")]
			[Address(RVA = "0xEBA62C", Offset = "0xEBA62C", VA = "0xEBA62C")]
			set
			{
			}
		}

		[Token(Token = "0x17000146")]
		public float SmoothedBeat
		{
			[Token(Token = "0x6000970")]
			[Address(RVA = "0xEBA634", Offset = "0xEBA634", VA = "0xEBA634")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000971")]
		[Address(RVA = "0xEBA698", Offset = "0xEBA698", VA = "0xEBA698")]
		public BeatAnimation()
		{
		}
	}
	[Token(Token = "0x20001A6")]
	public class BeatScaler : BeatAnimation
	{
		[Token(Token = "0x40008AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector2 _minMaxScale;

		[Token(Token = "0x6000972")]
		[Address(RVA = "0xEBA6D8", Offset = "0xEBA6D8", VA = "0xEBA6D8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000973")]
		[Address(RVA = "0xEBA794", Offset = "0xEBA794", VA = "0xEBA794")]
		public BeatScaler()
		{
		}
	}
	[Token(Token = "0x20001A7")]
	public class EndFirework : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20001A8")]
		public struct SSpawn
		{
			[Token(Token = "0x40008B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Transform Center;

			[Token(Token = "0x40008B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Vector3 SpawnBounds;

			[Token(Token = "0x40008B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector2 MinMaxSpawnRate;

			[Token(Token = "0x40008B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float NextEmitTime;
		}

		[Token(Token = "0x40008AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SSpawn[] _spawns;

		[Token(Token = "0x40008AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _parent;

		[Token(Token = "0x40008AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ParticleSystem _wave;

		[Token(Token = "0x40008B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ParticleSystem _petals;

		[Token(Token = "0x40008B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ParticleSystem _fireworks;

		[Token(Token = "0x40008B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ParticleSystem _globalWind;

		[Token(Token = "0x40008B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private EventReference _fireworkEventReference;

		[Token(Token = "0x40008B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool _emit;

		[Token(Token = "0x6000974")]
		[Address(RVA = "0xEBA7E8", Offset = "0xEBA7E8", VA = "0xEBA7E8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000975")]
		[Address(RVA = "0xEBA7EC", Offset = "0xEBA7EC", VA = "0xEBA7EC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000976")]
		[Address(RVA = "0xEBA8A8", Offset = "0xEBA8A8", VA = "0xEBA8A8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000977")]
		[Address(RVA = "0xEBA964", Offset = "0xEBA964", VA = "0xEBA964")]
		private void ManagerStateUpdated(GameManager.GameState CurrentState, GameManager.GameState State)
		{
		}

		[Token(Token = "0x6000978")]
		[Address(RVA = "0xEBA9D4", Offset = "0xEBA9D4", VA = "0xEBA9D4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000979")]
		[Address(RVA = "0xEBAABC", Offset = "0xEBAABC", VA = "0xEBAABC")]
		private void SetRandomPosition(int Id)
		{
		}

		[Token(Token = "0x600097A")]
		[Address(RVA = "0xEBABA4", Offset = "0xEBABA4", VA = "0xEBABA4")]
		private void EmitParticles()
		{
		}

		[Token(Token = "0x600097B")]
		[Address(RVA = "0xEBAC54", Offset = "0xEBAC54", VA = "0xEBAC54")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600097C")]
		[Address(RVA = "0xEBAD7C", Offset = "0xEBAD7C", VA = "0xEBAD7C")]
		public EndFirework()
		{
		}
	}
	[Token(Token = "0x20001A9")]
	public class OnDeathParticleEmitter : MonoBehaviour
	{
		[Token(Token = "0x40008B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _prefab;

		[Token(Token = "0x40008BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ParticleLifeTimeEvents _events;

		[Token(Token = "0x40008BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ParticleSystem _particleSystem;

		[Token(Token = "0x600097D")]
		[Address(RVA = "0xEBAD84", Offset = "0xEBAD84", VA = "0xEBAD84")]
		private void Awake()
		{
		}

		[Token(Token = "0x600097E")]
		[Address(RVA = "0xEBAD88", Offset = "0xEBAD88", VA = "0xEBAD88")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600097F")]
		[Address(RVA = "0xEBAEC0", Offset = "0xEBAEC0", VA = "0xEBAEC0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000980")]
		[Address(RVA = "0xEBAFF8", Offset = "0xEBAFF8", VA = "0xEBAFF8")]
		private void SpawnParticle(int id, ParticleSystem.Particle particle)
		{
		}

		[Token(Token = "0x6000981")]
		[Address(RVA = "0xEBB0F8", Offset = "0xEBB0F8", VA = "0xEBB0F8")]
		public OnDeathParticleEmitter()
		{
		}
	}
	[Token(Token = "0x20001AA")]
	public class ParticleAttractor : MonoBehaviour
	{
		[Token(Token = "0x40008BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _target;

		[Token(Token = "0x40008BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _powerBased;

		[Token(Token = "0x40008BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _power;

		[Token(Token = "0x40008BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ParticleSystem _particleSystem;

		[Token(Token = "0x40008C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ParticleSystem.Particle[] _particles;

		[Token(Token = "0x17000147")]
		public Transform Target
		{
			[Token(Token = "0x6000982")]
			[Address(RVA = "0xEBB100", Offset = "0xEBB100", VA = "0xEBB100")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000983")]
			[Address(RVA = "0xEBB108", Offset = "0xEBB108", VA = "0xEBB108")]
			set
			{
			}
		}

		[Token(Token = "0x6000984")]
		[Address(RVA = "0xEBB110", Offset = "0xEBB110", VA = "0xEBB110")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000985")]
		[Address(RVA = "0xEBB198", Offset = "0xEBB198", VA = "0xEBB198")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000986")]
		[Address(RVA = "0xEBB4EC", Offset = "0xEBB4EC", VA = "0xEBB4EC")]
		public ParticleAttractor()
		{
		}
	}
	[Token(Token = "0x20001AB")]
	public class ParticleLifeTimeEvents : MonoBehaviour
	{
		[Token(Token = "0x20001AC")]
		public class ParticleState
		{
			[Token(Token = "0x40008C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool ShouldBeDestroyed;

			[Token(Token = "0x40008CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public ParticleSystem.Particle Particle;

			[Token(Token = "0x600098F")]
			[Address(RVA = "0xEBBF04", Offset = "0xEBBF04", VA = "0xEBBF04")]
			public ParticleState()
			{
			}
		}

		[Token(Token = "0x40008C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ParticleSystem _particleSystem;

		[Token(Token = "0x40008C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ParticleSystem.Particle[] _particles;

		[Token(Token = "0x40008C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Dictionary<int, ParticleState> _lastParticlesState;

		[Token(Token = "0x40008C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<int> _toDestroyIDs;

		[Token(Token = "0x40008C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<Vector4> _customData;

		[Token(Token = "0x40008C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int _uniqueID;

		[Token(Token = "0x14000031")]
		public event Action<int, ParticleSystem.Particle> ParticleBirth
		{
			[Token(Token = "0x6000987")]
			[Address(RVA = "0xEBB4F4", Offset = "0xEBB4F4", VA = "0xEBB4F4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000988")]
			[Address(RVA = "0xEBB5A4", Offset = "0xEBB5A4", VA = "0xEBB5A4")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000032")]
		public event Action<int, ParticleSystem.Particle> ParticleDeath
		{
			[Token(Token = "0x6000989")]
			[Address(RVA = "0xEBAE10", Offset = "0xEBAE10", VA = "0xEBAE10")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600098A")]
			[Address(RVA = "0xEBAF48", Offset = "0xEBAF48", VA = "0xEBAF48")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x600098B")]
		[Address(RVA = "0xEBB654", Offset = "0xEBB654", VA = "0xEBB654")]
		private void Awake()
		{
		}

		[Token(Token = "0x600098C")]
		[Address(RVA = "0xEBB718", Offset = "0xEBB718", VA = "0xEBB718")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600098D")]
		[Address(RVA = "0xEBBF0C", Offset = "0xEBBF0C", VA = "0xEBBF0C")]
		public void CleanAllParticlesTracking()
		{
		}

		[Token(Token = "0x600098E")]
		[Address(RVA = "0xEBBF5C", Offset = "0xEBBF5C", VA = "0xEBBF5C")]
		public ParticleLifeTimeEvents()
		{
		}
	}
	[Token(Token = "0x20001AD")]
	public class Player : MonoBehaviour
	{
		[Token(Token = "0x20001AE")]
		[CompilerGenerated]
		private sealed class <TriggerHapticPulseCo>d__37 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40008DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool rightHand;

			[Token(Token = "0x40008DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float frequency;

			[Token(Token = "0x40008E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float amplitude;

			[Token(Token = "0x40008E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public bool leftHand;

			[Token(Token = "0x40008E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float duration;

			[Token(Token = "0x1700014C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009A6")]
				[Address(RVA = "0xEBCA34", Offset = "0xEBCA34", VA = "0xEBCA34", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700014D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009A8")]
				[Address(RVA = "0xEBCA7C", Offset = "0xEBCA7C", VA = "0xEBCA7C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009A3")]
			[Address(RVA = "0xEBC888", Offset = "0xEBC888", VA = "0xEBC888")]
			[DebuggerHidden]
			public <TriggerHapticPulseCo>d__37(int <>1__state)
			{
			}

			[Token(Token = "0x60009A4")]
			[Address(RVA = "0xEBC8B8", Offset = "0xEBC8B8", VA = "0xEBC8B8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009A5")]
			[Address(RVA = "0xEBC8BC", Offset = "0xEBC8BC", VA = "0xEBC8BC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009A7")]
			[Address(RVA = "0xEBCA3C", Offset = "0xEBCA3C", VA = "0xEBCA3C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40008CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Camera _camera;

		[Token(Token = "0x40008CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RayInteractorsActivation _rayActivator;

		[Token(Token = "0x40008CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Hand _leftHand;

		[Token(Token = "0x40008CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Hand _rightHand;

		[Token(Token = "0x40008D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private HandVisual _leftHandVisual;

		[Token(Token = "0x40008D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private HandVisual _rightHandVisual;

		[Token(Token = "0x40008D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private HandGrabInteractor _leftGrabInteractor;

		[Token(Token = "0x40008D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private HandGrabInteractor _rightGrabInteractor;

		[Token(Token = "0x40008D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TaikoStick _leftStick;

		[Token(Token = "0x40008D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private TaikoStick _rightStick;

		[Token(Token = "0x40008D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool _leftHandActive;

		[Token(Token = "0x40008D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool _rightHandActive;

		[Token(Token = "0x40008D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
		private bool _grabLeftNextFrame;

		[Token(Token = "0x40008D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B")]
		private bool _grabRightNextFrame;

		[Token(Token = "0x40008DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private IEnumerator _hapticLeftCoroutine;

		[Token(Token = "0x40008DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private IEnumerator _hapticRightCoroutine;

		[Token(Token = "0x17000148")]
		public static Player Instance
		{
			[Token(Token = "0x6000990")]
			[Address(RVA = "0xEBC08C", Offset = "0xEBC08C", VA = "0xEBC08C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000991")]
			[Address(RVA = "0xEBC0D4", Offset = "0xEBC0D4", VA = "0xEBC0D4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000149")]
		public Camera MainCamera
		{
			[Token(Token = "0x6000992")]
			[Address(RVA = "0xEBC12C", Offset = "0xEBC12C", VA = "0xEBC12C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000993")]
			[Address(RVA = "0xEBC134", Offset = "0xEBC134", VA = "0xEBC134")]
			private set
			{
			}
		}

		[Token(Token = "0x1700014A")]
		public TaikoStick LeftStick
		{
			[Token(Token = "0x6000994")]
			[Address(RVA = "0xEBC13C", Offset = "0xEBC13C", VA = "0xEBC13C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700014B")]
		public TaikoStick RightStick
		{
			[Token(Token = "0x6000995")]
			[Address(RVA = "0xEBC144", Offset = "0xEBC144", VA = "0xEBC144")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000996")]
		[Address(RVA = "0xEBC14C", Offset = "0xEBC14C", VA = "0xEBC14C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000997")]
		[Address(RVA = "0xEBC23C", Offset = "0xEBC23C", VA = "0xEBC23C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000998")]
		[Address(RVA = "0xEBC31C", Offset = "0xEBC31C", VA = "0xEBC31C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000999")]
		[Address(RVA = "0xEBC434", Offset = "0xEBC434", VA = "0xEBC434")]
		private void UpdateLeftHandVisual()
		{
		}

		[Token(Token = "0x600099A")]
		[Address(RVA = "0xEBC520", Offset = "0xEBC520", VA = "0xEBC520")]
		private void UpdateRightHandVisual()
		{
		}

		[Token(Token = "0x600099B")]
		[Address(RVA = "0xEBC60C", Offset = "0xEBC60C", VA = "0xEBC60C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600099C")]
		[Address(RVA = "0xEBC670", Offset = "0xEBC670", VA = "0xEBC670")]
		public void EnableRayInteractor(bool enable)
		{
		}

		[Token(Token = "0x600099D")]
		[Address(RVA = "0xEBC690", Offset = "0xEBC690", VA = "0xEBC690")]
		public Transform HeadTransform()
		{
			return null;
		}

		[Token(Token = "0x600099E")]
		[Address(RVA = "0xEB9414", Offset = "0xEB9414", VA = "0xEB9414")]
		public Vector3 GetPlayerPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600099F")]
		[Address(RVA = "0xEBC698", Offset = "0xEBC698", VA = "0xEBC698")]
		public void TriggerHapticPulse(float frequency, float amplitude, float duration, bool rightHand, bool leftHand)
		{
		}

		[Token(Token = "0x60009A0")]
		[Address(RVA = "0xEBC7E4", Offset = "0xEBC7E4", VA = "0xEBC7E4")]
		[IteratorStateMachine(typeof(<TriggerHapticPulseCo>d__37))]
		private IEnumerator TriggerHapticPulseCo(float frequency, float amplitude, float duration, bool rightHand, bool leftHand)
		{
			return null;
		}

		[Token(Token = "0x60009A1")]
		[Address(RVA = "0xEB9054", Offset = "0xEB9054", VA = "0xEB9054")]
		public void EnableActiveCombo(bool enabled)
		{
		}

		[Token(Token = "0x60009A2")]
		[Address(RVA = "0xEBC8B0", Offset = "0xEBC8B0", VA = "0xEBC8B0")]
		public Player()
		{
		}
	}
	[Token(Token = "0x20001AF")]
	public class SmoothVelocityEstimator : MonoBehaviour
	{
		[Token(Token = "0x40008E3")]
		private const int k_SmoothingFrameCount = 20;

		[Token(Token = "0x40008E4")]
		private const float k_DefaultSmoothingDuration = 0.25f;

		[Token(Token = "0x40008E5")]
		private const float k_DefaultVelocityScale = 1.5f;

		[Token(Token = "0x40008E6")]
		private const float k_DefaultAngularVelocityScale = 1f;

		[Token(Token = "0x40008E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _smoothingDuration;

		[Token(Token = "0x40008E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AnimationCurve _smoothingCurve;

		[Token(Token = "0x40008E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int _smoothingCurrentFrame;

		[Token(Token = "0x40008EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly float[] _smoothingFrameTimes;

		[Token(Token = "0x40008EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly Vector3[] _smoothingVelocityFrames;

		[Token(Token = "0x40008EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly Vector3[] _smoothingAngularVelocityFrames;

		[Token(Token = "0x40008ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 _lastPosition;

		[Token(Token = "0x40008EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Quaternion _lastRotation;

		[Token(Token = "0x1700014E")]
		public float SmoothingDuration
		{
			[Token(Token = "0x60009A9")]
			[Address(RVA = "0xEBCA84", Offset = "0xEBCA84", VA = "0xEBCA84")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60009AA")]
			[Address(RVA = "0xEBCA8C", Offset = "0xEBCA8C", VA = "0xEBCA8C")]
			set
			{
			}
		}

		[Token(Token = "0x1700014F")]
		public AnimationCurve SmoothingCurve
		{
			[Token(Token = "0x60009AB")]
			[Address(RVA = "0xEBCA94", Offset = "0xEBCA94", VA = "0xEBCA94")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009AC")]
			[Address(RVA = "0xEBCA9C", Offset = "0xEBCA9C", VA = "0xEBCA9C")]
			set
			{
			}
		}

		[Token(Token = "0x60009AD")]
		[Address(RVA = "0xEBCAA4", Offset = "0xEBCAA4", VA = "0xEBCAA4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60009AE")]
		[Address(RVA = "0xEBCB44", Offset = "0xEBCB44", VA = "0xEBCB44")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60009AF")]
		[Address(RVA = "0xEBCB4C", Offset = "0xEBCB4C", VA = "0xEBCB4C")]
		private void Update()
		{
		}

		[Token(Token = "0x60009B0")]
		[Address(RVA = "0xEBCAA8", Offset = "0xEBCAA8", VA = "0xEBCAA8")]
		public void SmoothVelocityStart()
		{
		}

		[Token(Token = "0x60009B1")]
		[Address(RVA = "0xEBCB48", Offset = "0xEBCB48", VA = "0xEBCB48")]
		public void SmoothVelocityEnd()
		{
		}

		[Token(Token = "0x60009B2")]
		[Address(RVA = "0xEBCEC4", Offset = "0xEBCEC4", VA = "0xEBCEC4")]
		public Vector3 GetSmoothedVelocity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60009B3")]
		[Address(RVA = "0xEBD0D0", Offset = "0xEBD0D0", VA = "0xEBD0D0")]
		public Vector3 GetSmoothedAngularVelocity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60009B4")]
		[Address(RVA = "0xEBCB50", Offset = "0xEBCB50", VA = "0xEBCB50")]
		private void SmoothVelocityUpdate()
		{
		}

		[Token(Token = "0x60009B5")]
		[Address(RVA = "0xEBCECC", Offset = "0xEBCECC", VA = "0xEBCECC")]
		private Vector3 GetSmoothedVelocityValue(Vector3[] velocityFrames)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60009B6")]
		[Address(RVA = "0xEBD0D8", Offset = "0xEBD0D8", VA = "0xEBD0D8")]
		public SmoothVelocityEstimator()
		{
		}
	}
	[Token(Token = "0x20001B0")]
	public class FrenzyTaiko : MonoBehaviour
	{
		[Token(Token = "0x20001B1")]
		public enum HitType
		{
			[Token(Token = "0x400090B")]
			Center,
			[Token(Token = "0x400090C")]
			Side
		}

		[Token(Token = "0x20001B2")]
		public struct TaikoHitInfo
		{
			[Token(Token = "0x400090D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public TaikoStick Stick;

			[Token(Token = "0x400090E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public HitType Type;

			[Token(Token = "0x400090F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float HitNormalizedSpeed;
		}

		[Token(Token = "0x40008EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float MaxSpeedSlam;

		[Token(Token = "0x40008F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform CenterRef;

		[Token(Token = "0x40008F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform SideRef;

		[Token(Token = "0x40008F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform ForwardRef;

		[Token(Token = "0x40008F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public TaikoStick LeftStick;

		[Token(Token = "0x40008F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public TaikoStick RightStick;

		[Token(Token = "0x40008F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _bottomDeadAngle;

		[Token(Token = "0x40008F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private MeshCollider _rimCollider;

		[Token(Token = "0x40008F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _raysMaxDistanceRelativeToRimSize;

		[Token(Token = "0x40008F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private TaikoGameParams _gameParams;

		[Token(Token = "0x40008F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Renderer _leftRimHit;

		[Token(Token = "0x40008FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Renderer _rightRimHit;

		[Token(Token = "0x40008FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Renderer _centerHit;

		[Token(Token = "0x40008FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Color _normalHitColor;

		[Token(Token = "0x40008FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Color _accentedHitColor;

		[Token(Token = "0x40008FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Color _restHitColor;

		[Token(Token = "0x4000900")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private float _maxDistance;

		[Token(Token = "0x4000901")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Plane _taikoPlane;

		[Token(Token = "0x4000902")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private Ray _rayForIntersection;

		[Token(Token = "0x4000903")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private float _fxOffset;

		[Token(Token = "0x4000904")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private EffectManager.EEffectsType _centerImpactFx;

		[Token(Token = "0x4000905")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private EffectManager.EEffectsType _sideImpactFx;

		[Token(Token = "0x4000906")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private EffectManager.EEffectsType _centerImpactAccentedFx;

		[Token(Token = "0x4000907")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private EffectManager.EEffectsType _sideImpactAccentedFx;

		[Token(Token = "0x4000908")]
		private const float MIN_TIP_SPEED = 0.4f;

		[Token(Token = "0x4000909")]
		private const float HIT_BLINK_TIME = 0.2f;

		[Token(Token = "0x14000033")]
		public event Action<TaikoHitInfo> OnTaikoHit
		{
			[Token(Token = "0x60009B7")]
			[Address(RVA = "0xEBD1C0", Offset = "0xEBD1C0", VA = "0xEBD1C0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60009B8")]
			[Address(RVA = "0xEBD270", Offset = "0xEBD270", VA = "0xEBD270")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x60009B9")]
		[Address(RVA = "0xEBD320", Offset = "0xEBD320", VA = "0xEBD320")]
		private void Awake()
		{
		}

		[Token(Token = "0x60009BA")]
		[Address(RVA = "0xEBD324", Offset = "0xEBD324", VA = "0xEBD324")]
		private void Start()
		{
		}

		[Token(Token = "0x60009BB")]
		[Address(RVA = "0xEBD3A4", Offset = "0xEBD3A4", VA = "0xEBD3A4")]
		public void InitTaiko()
		{
		}

		[Token(Token = "0x60009BC")]
		[Address(RVA = "0xEBD59C", Offset = "0xEBD59C", VA = "0xEBD59C")]
		private void BlinkHitMesh(Renderer renderer, bool accented)
		{
		}

		[Token(Token = "0x60009BD")]
		[Address(RVA = "0xEBD68C", Offset = "0xEBD68C", VA = "0xEBD68C")]
		private void Update()
		{
		}

		[Token(Token = "0x60009BE")]
		[Address(RVA = "0xEBE6C8", Offset = "0xEBE6C8", VA = "0xEBE6C8")]
		public void ToggleHitHelpers(bool toggle)
		{
		}

		[Token(Token = "0x60009BF")]
		[Address(RVA = "0xEBD750", Offset = "0xEBD750", VA = "0xEBD750")]
		private void CheckSlam(TaikoStick stick)
		{
		}

		[Token(Token = "0x60009C0")]
		[Address(RVA = "0xEBE7AC", Offset = "0xEBE7AC", VA = "0xEBE7AC")]
		public FrenzyTaiko()
		{
		}
	}
	[Token(Token = "0x20001B3")]
	public class TaikoGameLogic : MonoBehaviour
	{
		[Token(Token = "0x4000919")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private TaikoGameParams _gameParams;

		[Token(Token = "0x400091A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private TrackPathHandler _trackPathHandler;

		[Token(Token = "0x400091B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private FloatingCountdown _countDown;

		[Token(Token = "0x400091C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private FrenzyTaiko _taiko;

		[Token(Token = "0x400091D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Renderer _taikoRenderer;

		[Token(Token = "0x400091E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private int _maxPausesForLeaderboard;

		[Token(Token = "0x400091F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		protected float _started;

		[Token(Token = "0x4000920")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		protected bool _gameStarted;

		[Token(Token = "0x4000924")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private TaikoGameParams.TaikoMultiplier _currentTaikoMultiplier;

		[Token(Token = "0x4000925")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private float _lastMultiplierFill;

		[Token(Token = "0x4000926")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private float _musicTime;

		[Token(Token = "0x4000927")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private float _timeShift;

		[Token(Token = "0x4000928")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private float _hitDelay;

		[Token(Token = "0x4000929")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Timer _timerBeforeEnd;

		[Token(Token = "0x400092A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private TimerLoop _timeLoop;

		[Token(Token = "0x400092B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private DG.Tweening.Tween _comboFillTween;

		[Token(Token = "0x400092C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private DG.Tweening.Tween _comboColorTween;

		[Token(Token = "0x400092D")]
		private const string COLOR_MATERIAL_PROPERTY = "_ComboColor";

		[Token(Token = "0x400092E")]
		private const string COMBO_MATERIAL_PROPERTY = "_ComboGauge";

		[Token(Token = "0x400092F")]
		private const float COMBO_COLOR_ANIMATION_TIME = 0.25f;

		[Token(Token = "0x4000930")]
		private const float COMBO_HIT_ANIMATION_TIME = 0.2f;

		[Token(Token = "0x4000931")]
		private const float COMBO_FILL_ANIMATION_TIME = 0.2f;

		[Token(Token = "0x4000932")]
		private const float FLOATING_TEXT_MISS_OFFSET = 0.04f;

		[Token(Token = "0x4000933")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private TaikoTrack _track;

		[Token(Token = "0x4000934")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private bool _trackPaused;

		[Token(Token = "0x4000935")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private TaikoHitChecker _hitChecker;

		[Token(Token = "0x4000936")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private BackTrackPlayer _trackPlayer;

		[Token(Token = "0x4000937")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private int _pausesCount;

		[Token(Token = "0x17000150")]
		protected float _runningTime
		{
			[Token(Token = "0x60009D3")]
			[Address(RVA = "0xEBF118", Offset = "0xEBF118", VA = "0xEBF118")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000151")]
		public bool GameStarted
		{
			[Token(Token = "0x60009D4")]
			[Address(RVA = "0xEBF138", Offset = "0xEBF138", VA = "0xEBF138")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009D5")]
			[Address(RVA = "0xEBF140", Offset = "0xEBF140", VA = "0xEBF140")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000152")]
		public bool CanBePaused
		{
			[Token(Token = "0x60009D6")]
			[Address(RVA = "0xEBF14C", Offset = "0xEBF14C", VA = "0xEBF14C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000153")]
		public float Latency
		{
			[Token(Token = "0x60009D7")]
			[Address(RVA = "0xEBF16C", Offset = "0xEBF16C", VA = "0xEBF16C")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60009D8")]
			[Address(RVA = "0xEBF174", Offset = "0xEBF174", VA = "0xEBF174")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000154")]
		public int PausesCount
		{
			[Token(Token = "0x60009D9")]
			[Address(RVA = "0xEBF17C", Offset = "0xEBF17C", VA = "0xEBF17C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000155")]
		public int MaxPause
		{
			[Token(Token = "0x60009DA")]
			[Address(RVA = "0xEBF184", Offset = "0xEBF184", VA = "0xEBF184")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000156")]
		public bool CanSendToLeaderboard
		{
			[Token(Token = "0x60009DB")]
			[Address(RVA = "0xEBF18C", Offset = "0xEBF18C", VA = "0xEBF18C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009DC")]
			[Address(RVA = "0xEBF194", Offset = "0xEBF194", VA = "0xEBF194")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000157")]
		public int TimeOffset
		{
			[Token(Token = "0x60009DD")]
			[Address(RVA = "0xEBF1A0", Offset = "0xEBF1A0", VA = "0xEBF1A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60009DE")]
			[Address(RVA = "0xEBF1A8", Offset = "0xEBF1A8", VA = "0xEBF1A8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x14000034")]
		public event Action<int> OnGameStarted
		{
			[Token(Token = "0x60009C1")]
			[Address(RVA = "0xEBE7F0", Offset = "0xEBE7F0", VA = "0xEBE7F0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60009C2")]
			[Address(RVA = "0xEBE8A0", Offset = "0xEBE8A0", VA = "0xEBE8A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000035")]
		public event Action OnTrackStarted
		{
			[Token(Token = "0x60009C3")]
			[Address(RVA = "0xEBE950", Offset = "0xEBE950", VA = "0xEBE950")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60009C4")]
			[Address(RVA = "0xEBE9EC", Offset = "0xEBE9EC", VA = "0xEBE9EC")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000036")]
		public event Action OnGameReset
		{
			[Token(Token = "0x60009C5")]
			[Address(RVA = "0xEBEA88", Offset = "0xEBEA88", VA = "0xEBEA88")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60009C6")]
			[Address(RVA = "0xEBEB24", Offset = "0xEBEB24", VA = "0xEBEB24")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000037")]
		public event Action OnGameEnded
		{
			[Token(Token = "0x60009C7")]
			[Address(RVA = "0xEBEBC0", Offset = "0xEBEBC0", VA = "0xEBEBC0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60009C8")]
			[Address(RVA = "0xEBEC5C", Offset = "0xEBEC5C", VA = "0xEBEC5C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000038")]
		public event Action<int, int> OnTimeUpdated
		{
			[Token(Token = "0x60009C9")]
			[Address(RVA = "0xEBECF8", Offset = "0xEBECF8", VA = "0xEBECF8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60009CA")]
			[Address(RVA = "0xEBEDA8", Offset = "0xEBEDA8", VA = "0xEBEDA8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000039")]
		public event Action<float> OnMusicProgressUpdated
		{
			[Token(Token = "0x60009CB")]
			[Address(RVA = "0xEBEE58", Offset = "0xEBEE58", VA = "0xEBEE58")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60009CC")]
			[Address(RVA = "0xEBEF08", Offset = "0xEBEF08", VA = "0xEBEF08")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400003A")]
		public event Action<float> OnMusicTimeUpdated
		{
			[Token(Token = "0x60009CD")]
			[Address(RVA = "0xEBEFB8", Offset = "0xEBEFB8", VA = "0xEBEFB8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60009CE")]
			[Address(RVA = "0xEBF068", Offset = "0xEBF068", VA = "0xEBF068")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400003B")]
		public event Action<TaikoStick, TaikoGameParams.HitTolerance, bool, bool> OnNoteHit
		{
			[Token(Token = "0x60009CF")]
			[Address(RVA = "0xEB6F84", Offset = "0xEB6F84", VA = "0xEB6F84")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60009D0")]
			[Address(RVA = "0xEB72DC", Offset = "0xEB72DC", VA = "0xEB72DC")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400003C")]
		public event Action<TaikoHitChecker.TaikoHitResult> OnNoteHitResult
		{
			[Token(Token = "0x60009D1")]
			[Address(RVA = "0xEB7034", Offset = "0xEB7034", VA = "0xEB7034")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60009D2")]
			[Address(RVA = "0xEB738C", Offset = "0xEB738C", VA = "0xEB738C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x60009DF")]
		[Address(RVA = "0xEBF1B0", Offset = "0xEBF1B0", VA = "0xEBF1B0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60009E0")]
		[Address(RVA = "0xEBF230", Offset = "0xEBF230", VA = "0xEBF230")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60009E1")]
		[Address(RVA = "0xEBF4F4", Offset = "0xEBF4F4", VA = "0xEBF4F4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60009E2")]
		[Address(RVA = "0xEBF8C4", Offset = "0xEBF8C4", VA = "0xEBF8C4")]
		public bool InitGame(TaikoTrack track, GameManager.Difficulty difficulty, int timeOffset = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x60009E3")]
		[Address(RVA = "0xEC05A0", Offset = "0xEC05A0", VA = "0xEC05A0")]
		public void StartGame()
		{
		}

		[Token(Token = "0x60009E4")]
		[Address(RVA = "0xEC0848", Offset = "0xEC0848", VA = "0xEC0848")]
		public void ResetGame()
		{
		}

		[Token(Token = "0x60009E5")]
		[Address(RVA = "0xEC0E3C", Offset = "0xEC0E3C", VA = "0xEC0E3C")]
		private void EndGame()
		{
		}

		[Token(Token = "0x60009E6")]
		[Address(RVA = "0xEC0E5C", Offset = "0xEC0E5C", VA = "0xEC0E5C")]
		public void SetPause(bool pause)
		{
		}

		[Token(Token = "0x60009E7")]
		[Address(RVA = "0xEC029C", Offset = "0xEC029C", VA = "0xEC029C")]
		private void UpdateTimeText()
		{
		}

		[Token(Token = "0x60009E8")]
		[Address(RVA = "0xEC10FC", Offset = "0xEC10FC", VA = "0xEC10FC")]
		private void NotifyTaikoHit(FrenzyTaiko.TaikoHitInfo hitInfo)
		{
		}

		[Token(Token = "0x60009E9")]
		[Address(RVA = "0xEC15D0", Offset = "0xEC15D0", VA = "0xEC15D0")]
		private void NoteHit(TaikoHitChecker.TaikoHitResult hitResult)
		{
		}

		[Token(Token = "0x60009EA")]
		[Address(RVA = "0xEC1EB8", Offset = "0xEC1EB8", VA = "0xEC1EB8")]
		private void NoteCompleted(TaikoHitChecker.TaikoHitResult hitResult, TaikoGameParams.HitToleranceThreshold toleranceThreshold)
		{
		}

		[Token(Token = "0x60009EB")]
		[Address(RVA = "0xEC2484", Offset = "0xEC2484", VA = "0xEC2484")]
		private void NoteMissed(TaikoNote note)
		{
		}

		[Token(Token = "0x60009EC")]
		[Address(RVA = "0xEC27A0", Offset = "0xEC27A0", VA = "0xEC27A0")]
		private void NoteSpawnFailed()
		{
		}

		[Token(Token = "0x60009ED")]
		[Address(RVA = "0xEC27CC", Offset = "0xEC27CC", VA = "0xEC27CC")]
		private void NoteBeingDestroyed(TaikoNote note)
		{
		}

		[Token(Token = "0x60009EE")]
		[Address(RVA = "0xEC2800", Offset = "0xEC2800", VA = "0xEC2800")]
		private void RumbleObjectiveCompleted()
		{
		}

		[Token(Token = "0x60009EF")]
		[Address(RVA = "0xEB7F60", Offset = "0xEB7F60", VA = "0xEB7F60")]
		public void ConsecutiveHitsUpdated(int hits, float multiplierFill)
		{
		}

		[Token(Token = "0x60009F0")]
		[Address(RVA = "0xEB8010", Offset = "0xEB8010", VA = "0xEB8010")]
		public void MultiplierUpdated(TaikoGameParams.TaikoMultiplier multiplier)
		{
		}

		[Token(Token = "0x60009F1")]
		[Address(RVA = "0xEC282C", Offset = "0xEC282C", VA = "0xEC282C")]
		private void NotifyMusicEnd()
		{
		}

		[Token(Token = "0x60009F2")]
		[Address(RVA = "0xEC28E0", Offset = "0xEC28E0", VA = "0xEC28E0")]
		private float GetMusicTime()
		{
			return default(float);
		}

		[Token(Token = "0x60009F3")]
		[Address(RVA = "0xEC2924", Offset = "0xEC2924", VA = "0xEC2924")]
		private void Update()
		{
		}

		[Token(Token = "0x60009F4")]
		[Address(RVA = "0xEC2D84", Offset = "0xEC2D84", VA = "0xEC2D84")]
		public TaikoGameLogic()
		{
		}
	}
	[Token(Token = "0x20001B4")]
	public class TaikoGameParams : ScriptableObject
	{
		[Serializable]
		[Token(Token = "0x20001B5")]
		public struct TaikoMultiplier
		{
			[Token(Token = "0x400094E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[Range(1f, 10f)]
			public int Multiplier;

			[Token(Token = "0x400094F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int HitsToNextLevel;

			[Token(Token = "0x4000950")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Color Color;

			[Token(Token = "0x4000951")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Color HitColor;

			[Token(Token = "0x4000952")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string ComboTrigger;

			[Token(Token = "0x4000953")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public FloatingTextManager.TextType FloatingTextType;

			[Token(Token = "0x4000954")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float PunchScale;
		}

		[Serializable]
		[Token(Token = "0x20001B6")]
		private struct DifficultyRules
		{
			[Token(Token = "0x4000955")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public GameManager.Difficulty Difficulty;

			[Token(Token = "0x4000956")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int RumbleHitsPerSecond;
		}

		[Token(Token = "0x20001B7")]
		public enum RumbleDificulty
		{
			[Token(Token = "0x4000958")]
			NoRules,
			[Token(Token = "0x4000959")]
			PenaltiesFromSide,
			[Token(Token = "0x400095A")]
			Alternate
		}

		[Token(Token = "0x20001B8")]
		public enum HitTolerance
		{
			[Token(Token = "0x400095C")]
			OK,
			[Token(Token = "0x400095D")]
			Super,
			[Token(Token = "0x400095E")]
			Perfect,
			[Token(Token = "0x400095F")]
			Miss
		}

		[Serializable]
		[Token(Token = "0x20001B9")]
		public struct HitToleranceThreshold
		{
			[Token(Token = "0x4000960")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public HitTolerance Type;

			[Token(Token = "0x4000961")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string Label;

			[Token(Token = "0x4000962")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float TimeRange;

			[Token(Token = "0x4000963")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Color Color;

			[Token(Token = "0x4000964")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public int HitScore;

			[Token(Token = "0x4000965")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public FloatingTextManager.TextType FloatingTextType;
		}

		[Token(Token = "0x4000938")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Taiko")]
		public TaikoMultiplier[] TaikoMultipliers;

		[Token(Token = "0x4000939")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TaikoMultiplier SakuraBoostMultiplier;

		[Token(Token = "0x400093A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public RumbleDificulty RumbleRules;

		[Token(Token = "0x400093B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public bool AcceptNoNoteHit;

		[Token(Token = "0x400093C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float SheetTime;

		[Token(Token = "0x400093D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public List<HitToleranceThreshold> ToleranceThresholds;

		[Token(Token = "0x400093E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public int RumbleBonusScore;

		[Token(Token = "0x400093F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float DoubleHitToleranceTime;

		[Token(Token = "0x4000940")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float EndDelayAfterMusic;

		[Token(Token = "0x4000941")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float NormalizedSpeedAccentThreshold;

		[Token(Token = "0x4000942")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private List<DifficultyRules> _difficultyRules;

		[Token(Token = "0x4000943")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool FloatingMultipliers;

		[Token(Token = "0x4000944")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		public bool FloatingScores;

		[Token(Token = "0x4000945")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[Header("ActiveCombo")]
		public float ActivComboPerfectLoad;

		[Token(Token = "0x4000946")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float ActivComboSuperLoad;

		[Token(Token = "0x4000947")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float ActivComboAccentLoad;

		[Token(Token = "0x4000948")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float ActivComboRumbleLoad;

		[Token(Token = "0x4000949")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float ActivComboBarCountModifier;

		[Token(Token = "0x400094A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public int ActiveComboMaxBarCount;

		[Token(Token = "0x400094B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float ActivComboErrorConsume;

		[Token(Token = "0x400094C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float ActivComboActiveConsumeTime;

		[Token(Token = "0x400094D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public int ActivComboRumbleMultiplier;

		[Token(Token = "0x60009F5")]
		[Address(RVA = "0xEC2E0C", Offset = "0xEC2E0C", VA = "0xEC2E0C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60009F6")]
		[Address(RVA = "0xEC2E10", Offset = "0xEC2E10", VA = "0xEC2E10")]
		public int GetRumbleHitsPerSec(GameManager.Difficulty difficulty)
		{
			return default(int);
		}

		[Token(Token = "0x60009F7")]
		[Address(RVA = "0xEC2F64", Offset = "0xEC2F64", VA = "0xEC2F64")]
		public TaikoGameParams()
		{
		}
	}
	[Token(Token = "0x20001BA")]
	public class TaikoHitChecker
	{
		[Token(Token = "0x20001BB")]
		public enum HitCheck
		{
			[Token(Token = "0x400096A")]
			Success,
			[Token(Token = "0x400096B")]
			SuccessWithAccent,
			[Token(Token = "0x400096C")]
			Failed,
			[Token(Token = "0x400096D")]
			NoNote
		}

		[Token(Token = "0x20001BC")]
		public struct TaikoHitResult
		{
			[Token(Token = "0x400096E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public HitCheck HitCheck;

			[Token(Token = "0x400096F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public TaikoNote HitNote;

			[Token(Token = "0x4000970")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FrenzyTaiko.TaikoHitInfo HitInfo;
		}

		[Token(Token = "0x4000966")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private TaikoGameParams _gameParams;

		[Token(Token = "0x4000967")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool _previousStickIsRight;

		[Token(Token = "0x4000968")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool _isRumbleFinished;

		[Token(Token = "0x60009F8")]
		[Address(RVA = "0xEBFB10", Offset = "0xEBFB10", VA = "0xEBFB10")]
		public TaikoHitChecker(TaikoGameParams gameParams)
		{
		}

		[Token(Token = "0x60009F9")]
		[Address(RVA = "0xEC1334", Offset = "0xEC1334", VA = "0xEC1334")]
		public TaikoHitResult CheckTaikoHit(List<TaikoNote> activeNotes, FrenzyTaiko.TaikoHitInfo hitInfo)
		{
			return default(TaikoHitResult);
		}

		[Token(Token = "0x60009FA")]
		[Address(RVA = "0xEC2FBC", Offset = "0xEC2FBC", VA = "0xEC2FBC")]
		private bool CheckTaikoHitForNote(TaikoNoteInfo.Type noteType, bool isRight, FrenzyTaiko.HitType hitType)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20001BD")]
	public class TaikoStick : MonoBehaviour
	{
		[Token(Token = "0x20001BE")]
		public enum TaikoStickHand
		{
			[Token(Token = "0x4000986")]
			Right,
			[Token(Token = "0x4000987")]
			Left
		}

		[Token(Token = "0x4000971")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform TipPositionRef;

		[Token(Token = "0x4000972")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform BasePositionRef;

		[Token(Token = "0x4000973")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform PivotPositionRef;

		[Token(Token = "0x4000974")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool IsRight;

		[Token(Token = "0x4000975")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _hitTimeMargin;

		[Token(Token = "0x400097F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool _canStrikeTaiko;

		[Token(Token = "0x4000980")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		private bool _canSideStrikeTaiko;

		[Token(Token = "0x4000982")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float _lastHit;

		[Token(Token = "0x4000983")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool _canStrikeOut;

		[Token(Token = "0x4000984")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x95")]
		private bool _canStrikeTime;

		[Token(Token = "0x17000158")]
		public Rigidbody Rigidbody
		{
			[Token(Token = "0x60009FB")]
			[Address(RVA = "0xEC30A8", Offset = "0xEC30A8", VA = "0xEC30A8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60009FC")]
			[Address(RVA = "0xEC30B0", Offset = "0xEC30B0", VA = "0xEC30B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000159")]
		public TaikoStickHand HandType
		{
			[Token(Token = "0x60009FD")]
			[Address(RVA = "0xEC30B8", Offset = "0xEC30B8", VA = "0xEC30B8")]
			[CompilerGenerated]
			get
			{
				return default(TaikoStickHand);
			}
			[Token(Token = "0x60009FE")]
			[Address(RVA = "0xEC30C0", Offset = "0xEC30C0", VA = "0xEC30C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700015A")]
		public Vector3 PreviousBasePosition
		{
			[Token(Token = "0x60009FF")]
			[Address(RVA = "0xEC30C8", Offset = "0xEC30C8", VA = "0xEC30C8")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000A00")]
			[Address(RVA = "0xEC30D4", Offset = "0xEC30D4", VA = "0xEC30D4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700015B")]
		public Vector3 PreviousBaseForward
		{
			[Token(Token = "0x6000A01")]
			[Address(RVA = "0xEC30E0", Offset = "0xEC30E0", VA = "0xEC30E0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000A02")]
			[Address(RVA = "0xEC30EC", Offset = "0xEC30EC", VA = "0xEC30EC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700015C")]
		public Vector3 PreviousTipPosition
		{
			[Token(Token = "0x6000A03")]
			[Address(RVA = "0xEC30F8", Offset = "0xEC30F8", VA = "0xEC30F8")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000A04")]
			[Address(RVA = "0xEC3104", Offset = "0xEC3104", VA = "0xEC3104")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700015D")]
		public Grabbable Interactable
		{
			[Token(Token = "0x6000A05")]
			[Address(RVA = "0xEC3110", Offset = "0xEC3110", VA = "0xEC3110")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A06")]
			[Address(RVA = "0xEC3118", Offset = "0xEC3118", VA = "0xEC3118")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700015E")]
		public bool IsGrabbed
		{
			[Token(Token = "0x6000A07")]
			[Address(RVA = "0xEC3120", Offset = "0xEC3120", VA = "0xEC3120")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A08")]
			[Address(RVA = "0xEC3128", Offset = "0xEC3128", VA = "0xEC3128")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700015F")]
		public HandGrabInteractable HandGrabInteractable
		{
			[Token(Token = "0x6000A09")]
			[Address(RVA = "0xEC3134", Offset = "0xEC3134", VA = "0xEC3134")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A0A")]
			[Address(RVA = "0xEC313C", Offset = "0xEC313C", VA = "0xEC313C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000160")]
		public SmoothVelocityEstimator TipVelocityEstimator
		{
			[Token(Token = "0x6000A0B")]
			[Address(RVA = "0xEC3144", Offset = "0xEC3144", VA = "0xEC3144")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A0C")]
			[Address(RVA = "0xEC314C", Offset = "0xEC314C", VA = "0xEC314C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000161")]
		public bool CanStrikeTaiko
		{
			[Token(Token = "0x6000A0D")]
			[Address(RVA = "0xEC3154", Offset = "0xEC3154", VA = "0xEC3154")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A0E")]
			[Address(RVA = "0xEBE778", Offset = "0xEBE778", VA = "0xEBE778")]
			set
			{
			}
		}

		[Token(Token = "0x17000162")]
		public bool CanSideStrikeTaiko
		{
			[Token(Token = "0x6000A0F")]
			[Address(RVA = "0xEC315C", Offset = "0xEC315C", VA = "0xEC315C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A10")]
			[Address(RVA = "0xEBE744", Offset = "0xEBE744", VA = "0xEBE744")]
			set
			{
			}
		}

		[Token(Token = "0x17000163")]
		public float StickLength
		{
			[Token(Token = "0x6000A11")]
			[Address(RVA = "0xEC3164", Offset = "0xEC3164", VA = "0xEC3164")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A12")]
			[Address(RVA = "0xEC316C", Offset = "0xEC316C", VA = "0xEC316C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000A13")]
		[Address(RVA = "0xEC3174", Offset = "0xEC3174", VA = "0xEC3174")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000A14")]
		[Address(RVA = "0xEC333C", Offset = "0xEC333C", VA = "0xEC333C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A15")]
		[Address(RVA = "0xEC3390", Offset = "0xEC3390", VA = "0xEC3390")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000A16")]
		[Address(RVA = "0xEC33EC", Offset = "0xEC33EC", VA = "0xEC33EC")]
		public void OnMove()
		{
		}

		[Token(Token = "0x6000A17")]
		[Address(RVA = "0xEC33F0", Offset = "0xEC33F0", VA = "0xEC33F0")]
		public void OnGrab()
		{
		}

		[Token(Token = "0x6000A18")]
		[Address(RVA = "0xEC34CC", Offset = "0xEC34CC", VA = "0xEC34CC")]
		public void OnUngrab()
		{
		}

		[Token(Token = "0x6000A19")]
		[Address(RVA = "0xEC36BC", Offset = "0xEC36BC", VA = "0xEC36BC")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x6000A1A")]
		[Address(RVA = "0xEC377C", Offset = "0xEC377C", VA = "0xEC377C")]
		public Vector3 StickDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000A1B")]
		[Address(RVA = "0xEC3894", Offset = "0xEC3894", VA = "0xEC3894")]
		public TaikoStick()
		{
		}
	}
	[Token(Token = "0x20001BF")]
	public class BeatManager : MonoBehaviour
	{
		[Token(Token = "0x4000989")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TaikoGameLogic _gameLogic;

		[Token(Token = "0x400098A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BeatAnimation _basicSmooth;

		[Token(Token = "0x400098C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float _currentTrackBpm;

		[Token(Token = "0x400098D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float _currentMusicTime;

		[Token(Token = "0x400098E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float _currentBpmUnit;

		[Token(Token = "0x17000164")]
		public static BeatManager Instance
		{
			[Token(Token = "0x6000A1C")]
			[Address(RVA = "0xEC38BC", Offset = "0xEC38BC", VA = "0xEC38BC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A1D")]
			[Address(RVA = "0xEC3904", Offset = "0xEC3904", VA = "0xEC3904")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x17000165")]
		public float SmoothedBpm
		{
			[Token(Token = "0x6000A1E")]
			[Address(RVA = "0xEC395C", Offset = "0xEC395C", VA = "0xEC395C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000166")]
		public float NormalizedBpm
		{
			[Token(Token = "0x6000A1F")]
			[Address(RVA = "0xEC3974", Offset = "0xEC3974", VA = "0xEC3974")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A20")]
			[Address(RVA = "0xEC397C", Offset = "0xEC397C", VA = "0xEC397C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000A21")]
		[Address(RVA = "0xEC3984", Offset = "0xEC3984", VA = "0xEC3984")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000A22")]
		[Address(RVA = "0xEC39E8", Offset = "0xEC39E8", VA = "0xEC39E8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000A23")]
		[Address(RVA = "0xEC3B30", Offset = "0xEC3B30", VA = "0xEC3B30")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000A24")]
		[Address(RVA = "0xEC3C78", Offset = "0xEC3C78", VA = "0xEC3C78")]
		private void GameStarted(int bpm)
		{
		}

		[Token(Token = "0x6000A25")]
		[Address(RVA = "0xEC3CF8", Offset = "0xEC3CF8", VA = "0xEC3CF8")]
		private void GameEnded()
		{
		}

		[Token(Token = "0x6000A26")]
		[Address(RVA = "0xEC3D54", Offset = "0xEC3D54", VA = "0xEC3D54")]
		private void GameUpdated(float musicTime)
		{
		}

		[Token(Token = "0x6000A27")]
		[Address(RVA = "0xEC3DD4", Offset = "0xEC3DD4", VA = "0xEC3DD4")]
		public BeatManager()
		{
		}
	}
}
namespace TaikoFrenzy.Gameplay.Track
{
	[Token(Token = "0x20001C0")]
	public class TaikoNote : MonoBehaviour, IPooled<TaikoNote>
	{
		[Token(Token = "0x4000995")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TrailRenderer Trail;

		[Token(Token = "0x4000996")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Renderer NoteRenderer;

		[Token(Token = "0x4000997")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Gradient TrailGradient;

		[Token(Token = "0x4000998")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Gradient TrailHitGradient;

		[Token(Token = "0x4000999")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float TrailWidth;

		[Token(Token = "0x400099A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float TrailHitWidth;

		[Token(Token = "0x400099B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SpriteRenderer _debugRenderer;

		[Token(Token = "0x400099C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _accent;

		[Token(Token = "0x400099D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private ActiveComboState _activeComboState;

		[Token(Token = "0x40009A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private CinemachinePathBase _splinePath;

		[Token(Token = "0x40009A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Timer _destroyTimer;

		[Token(Token = "0x40009A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float _startTime;

		[Token(Token = "0x40009A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private float _noteLength;

		[Token(Token = "0x40009A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private float _endTime;

		[Token(Token = "0x40009AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private float _currentPercent;

		[Token(Token = "0x40009AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float _endPercent;

		[Token(Token = "0x40009AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private int _rumbleHitsObjective;

		[Token(Token = "0x40009AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private int _rumbleHits;

		[Token(Token = "0x40009AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private bool _appearing;

		[Token(Token = "0x40009AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBD")]
		private bool _destroying;

		[Token(Token = "0x40009B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private DG.Tweening.Tween _trailTween;

		[Token(Token = "0x40009B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static readonly float MILLI_MULTIPLIER;

		[Token(Token = "0x40009B2")]
		private const float NOTE_TIME_SUBSTRACT = 0.06f;

		[Token(Token = "0x40009B3")]
		private const float APPEAR_TIME = 0.5f;

		[Token(Token = "0x40009B4")]
		private const float MISS_TIME = 0.5f;

		[Token(Token = "0x40009B5")]
		private const float HIT_TIME = 0.35f;

		[Token(Token = "0x40009B6")]
		private const float TRAIL_RESIZE_TIME = 0.25f;

		[Token(Token = "0x40009B7")]
		private const string MATERIAL_STEP_PROPERTY = "_Step";

		[Token(Token = "0x40009B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public bool isParentPoolableDependant;

		[Token(Token = "0x17000167")]
		public int PoolID
		{
			[Token(Token = "0x6000A30")]
			[Address(RVA = "0xEC41B4", Offset = "0xEC41B4", VA = "0xEC41B4", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000A31")]
			[Address(RVA = "0xEC41BC", Offset = "0xEC41BC", VA = "0xEC41BC", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000168")]
		public ObjectPooler<TaikoNote> Pool
		{
			[Token(Token = "0x6000A32")]
			[Address(RVA = "0xEC41C4", Offset = "0xEC41C4", VA = "0xEC41C4", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A33")]
			[Address(RVA = "0xEC41CC", Offset = "0xEC41CC", VA = "0xEC41CC", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000169")]
		public bool IsValidated
		{
			[Token(Token = "0x6000A34")]
			[Address(RVA = "0xEC41D4", Offset = "0xEC41D4", VA = "0xEC41D4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A35")]
			[Address(RVA = "0xEC41DC", Offset = "0xEC41DC", VA = "0xEC41DC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700016A")]
		public bool IsRight
		{
			[Token(Token = "0x6000A36")]
			[Address(RVA = "0xEC41E8", Offset = "0xEC41E8", VA = "0xEC41E8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A37")]
			[Address(RVA = "0xEC41F0", Offset = "0xEC41F0", VA = "0xEC41F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700016B")]
		public float RightHitTime
		{
			[Token(Token = "0x6000A38")]
			[Address(RVA = "0xEC41FC", Offset = "0xEC41FC", VA = "0xEC41FC")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A39")]
			[Address(RVA = "0xEC4204", Offset = "0xEC4204", VA = "0xEC4204")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700016C")]
		public float LeftHitTime
		{
			[Token(Token = "0x6000A3A")]
			[Address(RVA = "0xEC420C", Offset = "0xEC420C", VA = "0xEC420C")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A3B")]
			[Address(RVA = "0xEC4214", Offset = "0xEC4214", VA = "0xEC4214")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700016D")]
		public TaikoNote LinkedNote
		{
			[Token(Token = "0x6000A3C")]
			[Address(RVA = "0xEC421C", Offset = "0xEC421C", VA = "0xEC421C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A3D")]
			[Address(RVA = "0xEC4224", Offset = "0xEC4224", VA = "0xEC4224")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700016E")]
		public TaikoNoteInfo NoteInfo
		{
			[Token(Token = "0x6000A3E")]
			[Address(RVA = "0xEC422C", Offset = "0xEC422C", VA = "0xEC422C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A3F")]
			[Address(RVA = "0xEC4234", Offset = "0xEC4234", VA = "0xEC4234")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700016F")]
		public float StartTime
		{
			[Token(Token = "0x6000A40")]
			[Address(RVA = "0xEC423C", Offset = "0xEC423C", VA = "0xEC423C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000170")]
		public bool TrueNote
		{
			[Token(Token = "0x6000A41")]
			[Address(RVA = "0xEC4244", Offset = "0xEC4244", VA = "0xEC4244")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A42")]
			[Address(RVA = "0xEC424C", Offset = "0xEC424C", VA = "0xEC424C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000171")]
		public bool Destroying
		{
			[Token(Token = "0x6000A43")]
			[Address(RVA = "0xEC4258", Offset = "0xEC4258", VA = "0xEC4258")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000172")]
		public bool IsParentPoolableDependant
		{
			[Token(Token = "0x6000A44")]
			[Address(RVA = "0xEC4260", Offset = "0xEC4260", VA = "0xEC4260")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1400003D")]
		public static event Action<TaikoNote> OnBeforeDestroy
		{
			[Token(Token = "0x6000A28")]
			[Address(RVA = "0xEBF328", Offset = "0xEBF328", VA = "0xEBF328")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000A29")]
			[Address(RVA = "0xEBF6F8", Offset = "0xEBF6F8", VA = "0xEBF6F8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400003E")]
		public static event Action<TaikoNote> OnDestroy
		{
			[Token(Token = "0x6000A2A")]
			[Address(RVA = "0xEC3DE4", Offset = "0xEC3DE4", VA = "0xEC3DE4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000A2B")]
			[Address(RVA = "0xEC3ED8", Offset = "0xEC3ED8", VA = "0xEC3ED8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400003F")]
		public static event Action<int, int> OnRumbleHit
		{
			[Token(Token = "0x6000A2C")]
			[Address(RVA = "0xEC3FCC", Offset = "0xEC3FCC", VA = "0xEC3FCC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000A2D")]
			[Address(RVA = "0xEC40C0", Offset = "0xEC40C0", VA = "0xEC40C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000040")]
		public static event Action OnRumbleObjectiveCompleted
		{
			[Token(Token = "0x6000A2E")]
			[Address(RVA = "0xEBF418", Offset = "0xEBF418", VA = "0xEBF418")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000A2F")]
			[Address(RVA = "0xEBF7E8", Offset = "0xEBF7E8", VA = "0xEBF7E8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000A45")]
		[Address(RVA = "0xEC4268", Offset = "0xEC4268", VA = "0xEC4268")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000A46")]
		[Address(RVA = "0xEC426C", Offset = "0xEC426C", VA = "0xEC426C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000A47")]
		[Address(RVA = "0xEC442C", Offset = "0xEC442C", VA = "0xEC442C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000A48")]
		[Address(RVA = "0xEC44F0", Offset = "0xEC44F0", VA = "0xEC44F0")]
		public void SetNoteInfo(CinemachinePathBase splinePath, TaikoNoteInfo info, float sheetTime, bool isRight, bool trueNote = true, float endPercent = 1f, float lengthSubstract = 0f, int rumbleHitsPerSec = 10)
		{
		}

		[Token(Token = "0x6000A49")]
		[Address(RVA = "0xEC2780", Offset = "0xEC2780", VA = "0xEC2780")]
		public Vector3 GetFloatingScorePosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000A4A")]
		[Address(RVA = "0xEC4870", Offset = "0xEC4870", VA = "0xEC4870")]
		private void Move()
		{
		}

		[Token(Token = "0x6000A4B")]
		[Address(RVA = "0xEC2478", Offset = "0xEC2478", VA = "0xEC2478")]
		public void Validate()
		{
		}

		[Token(Token = "0x6000A4C")]
		[Address(RVA = "0xEC15C0", Offset = "0xEC15C0", VA = "0xEC15C0")]
		public void Fail(bool immediateDestroy = true)
		{
		}

		[Token(Token = "0x6000A4D")]
		[Address(RVA = "0xEC4C10", Offset = "0xEC4C10", VA = "0xEC4C10")]
		public void TravelEnded()
		{
		}

		[Token(Token = "0x6000A4E")]
		[Address(RVA = "0xEC49C4", Offset = "0xEC49C4", VA = "0xEC49C4")]
		public void Destroy()
		{
		}

		[Token(Token = "0x6000A4F")]
		[Address(RVA = "0xEC4C60", Offset = "0xEC4C60", VA = "0xEC4C60")]
		public void Depop()
		{
		}

		[Token(Token = "0x6000A50")]
		[Address(RVA = "0xEC1C54", Offset = "0xEC1C54", VA = "0xEC1C54")]
		public void RumbleHit(bool updateVisuals)
		{
		}

		[Token(Token = "0x6000A51")]
		[Address(RVA = "0xEC4CFC", Offset = "0xEC4CFC", VA = "0xEC4CFC")]
		public void UpdateTime(float musicTime)
		{
		}

		[Token(Token = "0x6000A52")]
		[Address(RVA = "0xEC42B8", Offset = "0xEC42B8", VA = "0xEC42B8")]
		public void ActiveDebug(bool toggle, Color color)
		{
		}

		[Token(Token = "0x6000A53")]
		[Address(RVA = "0xEC4E2C", Offset = "0xEC4E2C", VA = "0xEC4E2C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A54")]
		[Address(RVA = "0xEC431C", Offset = "0xEC431C", VA = "0xEC431C")]
		private void DisableTrail()
		{
		}

		[Token(Token = "0x6000A55")]
		[Address(RVA = "0xEC4E58", Offset = "0xEC4E58", VA = "0xEC4E58")]
		public TaikoNote()
		{
		}
	}
	[Token(Token = "0x20001C1")]
	public class TaikoTrack : ScriptableObject
	{
		[Serializable]
		[Token(Token = "0x20001C2")]
		public struct DifficultyNoteInfos
		{
			[Token(Token = "0x40009C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public GameManager.Difficulty Difficulty;

			[Token(Token = "0x40009C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public List<TaikoNoteInfo> NoteInfos;
		}

		[Serializable]
		[Token(Token = "0x20001C3")]
		public struct MedalInfo
		{
			[Token(Token = "0x40009C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public MedalType Type;

			[Token(Token = "0x40009C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int Score;
		}

		[Serializable]
		[Token(Token = "0x20001C4")]
		public struct DifficultyMedals
		{
			[Token(Token = "0x40009CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public GameManager.Difficulty Difficulty;

			[Token(Token = "0x40009CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public List<MedalInfo> Medals;
		}

		[Token(Token = "0x20001C5")]
		public enum MedalType
		{
			[Token(Token = "0x40009CD")]
			Bronze,
			[Token(Token = "0x40009CE")]
			Silver,
			[Token(Token = "0x40009CF")]
			Gold
		}

		[Token(Token = "0x40009B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		public string Name;

		[Token(Token = "0x40009BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		public string Artist;

		[Token(Token = "0x40009BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		public int Duration;

		[Token(Token = "0x40009BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _leaderboardPrefix;

		[Token(Token = "0x40009BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		public EventReference MusicRef;

		[Token(Token = "0x40009BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		public int Bpm;

		[Token(Token = "0x40009BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		public int TimeSignature;

		[Token(Token = "0x40009C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		public bool BeginnerCenterOnly;

		[Token(Token = "0x40009C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		[SerializeField]
		public bool IsSideloaded;

		[Token(Token = "0x40009C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private List<DifficultyNoteInfos> _noteInfosList;

		[Token(Token = "0x40009C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private List<DifficultyMedals> _difficultyMedalsList;

		[Token(Token = "0x40009C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Header("Optional")]
		private TrackSimulatedScoreRules _simulatedScoreRules;

		[Token(Token = "0x40009C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private string _trackFilePath;

		[Token(Token = "0x17000173")]
		public string TrackFilePath
		{
			[Token(Token = "0x6000A59")]
			[Address(RVA = "0xEC4ED8", Offset = "0xEC4ED8", VA = "0xEC4ED8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000174")]
		public bool CanComputeMedals
		{
			[Token(Token = "0x6000A5A")]
			[Address(RVA = "0xEC4EE0", Offset = "0xEC4EE0", VA = "0xEC4EE0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000175")]
		public List<GameManager.Difficulty> AvailableDifficulties
		{
			[Token(Token = "0x6000A5B")]
			[Address(RVA = "0xEC4FE4", Offset = "0xEC4FE4", VA = "0xEC4FE4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A5C")]
		[Address(RVA = "0xEC5104", Offset = "0xEC5104", VA = "0xEC5104")]
		public void Init(List<DifficultyNoteInfos> noteInfosList, [System.Runtime.InteropServices.Optional] string trackFilePath)
		{
		}

		[Token(Token = "0x6000A5D")]
		[Address(RVA = "0xEC4F5C", Offset = "0xEC4F5C", VA = "0xEC4F5C")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A5E")]
		[Address(RVA = "0xEC5134", Offset = "0xEC5134", VA = "0xEC5134")]
		public List<TaikoNoteInfo> GetNoteInfos(GameManager.Difficulty difficulty)
		{
			return null;
		}

		[Token(Token = "0x6000A5F")]
		[Address(RVA = "0xEBFB4C", Offset = "0xEBFB4C", VA = "0xEBFB4C")]
		public string GetLeaderboardKey(GameManager.Difficulty difficulty)
		{
			return null;
		}

		[Token(Token = "0x6000A60")]
		[Address(RVA = "0xEC5278", Offset = "0xEC5278", VA = "0xEC5278")]
		public int GetScoreForMedal(GameManager.Difficulty difficulty, MedalType medal)
		{
			return default(int);
		}

		[Token(Token = "0x6000A61")]
		[Address(RVA = "0xEC5530", Offset = "0xEC5530", VA = "0xEC5530")]
		public void ComputeMedals()
		{
		}

		[Token(Token = "0x6000A62")]
		[Address(RVA = "0xEC6880", Offset = "0xEC6880", VA = "0xEC6880")]
		public TaikoTrack()
		{
		}
	}
	[Token(Token = "0x20001C7")]
	public static class TrackImporter
	{
		[Token(Token = "0x40009D2")]
		private const string TRACK_FILE = "Track.wav";

		[Token(Token = "0x40009D3")]
		private const string BPM_FILE = "bpm.txt";

		[Token(Token = "0x6000A66")]
		[Address(RVA = "0xEC6908", Offset = "0xEC6908", VA = "0xEC6908")]
		public static TaikoTrack FromMidiDirectory(string directoryPath, [System.Runtime.InteropServices.Optional] TaikoTrack existingTrack)
		{
			return null;
		}

		[Token(Token = "0x6000A67")]
		[Address(RVA = "0xEC730C", Offset = "0xEC730C", VA = "0xEC730C")]
		public static int GetWavLength(string filePath)
		{
			return default(int);
		}
	}
	[Token(Token = "0x20001C8")]
	public class TrackIndicator : MonoBehaviour, IPooled<TrackIndicator>
	{
		[Token(Token = "0x40009D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SpriteRenderer _renderer;

		[Token(Token = "0x40009D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Range(0f, 0.15f)]
		private float _fadePercent;

		[Token(Token = "0x40009D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TrackPathHandler _pathHandler;

		[Token(Token = "0x40009D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private CinemachinePathBase _splinePath;

		[Token(Token = "0x40009DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float _startTime;

		[Token(Token = "0x40009DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float _endTime;

		[Token(Token = "0x40009DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float _currentPercent;

		[Token(Token = "0x40009DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float _hitPercent;

		[Token(Token = "0x40009DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Color _baseColor;

		[Token(Token = "0x40009DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Color _fadeColor;

		[Token(Token = "0x17000176")]
		public int PoolID
		{
			[Token(Token = "0x6000A68")]
			[Address(RVA = "0xEC7460", Offset = "0xEC7460", VA = "0xEC7460", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000A69")]
			[Address(RVA = "0xEC7468", Offset = "0xEC7468", VA = "0xEC7468", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000177")]
		public ObjectPooler<TrackIndicator> Pool
		{
			[Token(Token = "0x6000A6A")]
			[Address(RVA = "0xEC7470", Offset = "0xEC7470", VA = "0xEC7470", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A6B")]
			[Address(RVA = "0xEC7478", Offset = "0xEC7478", VA = "0xEC7478", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000A6C")]
		[Address(RVA = "0xEC7480", Offset = "0xEC7480", VA = "0xEC7480")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000A6D")]
		[Address(RVA = "0xEC74B8", Offset = "0xEC74B8", VA = "0xEC74B8")]
		public void Init(TrackPathHandler pathHandler, CinemachinePathBase splinePath, float startTime, float endTime)
		{
		}

		[Token(Token = "0x6000A6E")]
		[Address(RVA = "0xEC7538", Offset = "0xEC7538", VA = "0xEC7538")]
		public void Depop()
		{
		}

		[Token(Token = "0x6000A6F")]
		[Address(RVA = "0xEC75D4", Offset = "0xEC75D4", VA = "0xEC75D4")]
		private void Move()
		{
		}

		[Token(Token = "0x6000A70")]
		[Address(RVA = "0xEC7790", Offset = "0xEC7790", VA = "0xEC7790")]
		public void UpdateTime(float musicTime)
		{
		}

		[Token(Token = "0x6000A71")]
		[Address(RVA = "0xEC78B0", Offset = "0xEC78B0", VA = "0xEC78B0")]
		public TrackIndicator()
		{
		}
	}
	[Token(Token = "0x20001C9")]
	public class TrackIndicatorPool : GenericPoolGroup<TrackIndicator, TrackIndicatorPool.IndicatorType>
	{
		[Token(Token = "0x20001CA")]
		public enum IndicatorType
		{
			[Token(Token = "0x40009E1")]
			BeatBar
		}

		[Token(Token = "0x6000A72")]
		[Address(RVA = "0xEC78B8", Offset = "0xEC78B8", VA = "0xEC78B8")]
		public TrackIndicator Spawn(IndicatorType type, [System.Runtime.InteropServices.Optional] Vector3 position, [System.Runtime.InteropServices.Optional] Quaternion rotation)
		{
			return null;
		}

		[Token(Token = "0x6000A73")]
		[Address(RVA = "0xEC7BB8", Offset = "0xEC7BB8", VA = "0xEC7BB8")]
		public TrackIndicatorPool()
		{
		}
	}
	[Token(Token = "0x20001CB")]
	public class TrackPathHandler : MonoBehaviour
	{
		[Token(Token = "0x40009E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
		[Header("General")]
		[SerializeField]
		private bool _destroyWhenOutOfTolerance;

		[Token(Token = "0x40009E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshPro _measureText;

		[Token(Token = "0x40009E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TextMeshPro _rumbleText;

		[Token(Token = "0x40009E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TrackIndicatorPool _indicatorsPool;

		[Token(Token = "0x40009EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Header("Paths")]
		[SerializeField]
		private CinemachinePathBase _leftPath;

		[Token(Token = "0x40009EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CinemachinePathBase _centerPath;

		[Token(Token = "0x40009EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CinemachinePathBase _rightPath;

		[Token(Token = "0x40009ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Range(0f, 1f)]
		public float HitBarPosition;

		[Token(Token = "0x40009EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Header("Elements")]
		[SerializeField]
		private GameObject _hitBar;

		[Token(Token = "0x40009EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject[] _hitBarHoloObjects;

		[Token(Token = "0x40009F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform LeftSlot;

		[Token(Token = "0x40009F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform RightSlot;

		[Token(Token = "0x40009F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform FloatingScoreTransform;

		[Token(Token = "0x40009F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private TaikoTrack _track;

		[Token(Token = "0x40009F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private List<TaikoNoteInfo> _noteInfos;

		[Token(Token = "0x40009F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool _showToleranceDebug;

		[Token(Token = "0x40009F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private List<TaikoNote> _spawnedNotes;

		[Token(Token = "0x40009F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private List<TaikoNote> _activeNotes;

		[Token(Token = "0x40009F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private List<float> _beatTimingList;

		[Token(Token = "0x40009F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private int _nextNoteToSpawn;

		[Token(Token = "0x40009FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private float _currentMusicTime;

		[Token(Token = "0x40009FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float _hitDelay;

		[Token(Token = "0x40009FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float _maxHitTolerance;

		[Token(Token = "0x40009FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private List<TrackIndicator> _spawnedIndicators;

		[Token(Token = "0x40009FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int _nextBarToSpawn;

		[Token(Token = "0x40009FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private TaikoGameParams _gameParams;

		[Token(Token = "0x4000A00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool _inRumble;

		[Token(Token = "0x4000A01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private float _rumbleLengthSubstract;

		[Token(Token = "0x4000A02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int _rumbleHitsPerSec;

		[Token(Token = "0x4000A03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private TaikoGameParams.HitToleranceThreshold _okThreshold;

		[Token(Token = "0x4000A04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<TaikoNoteInfo.Type, NotesManager.ENotesType> NOTE_POOL_DICTIONARY;

		[Token(Token = "0x4000A05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly float MILLI_MULTIPLIER;

		[Token(Token = "0x17000178")]
		public List<TaikoNote> ActiveNotes
		{
			[Token(Token = "0x6000A76")]
			[Address(RVA = "0xEC7C9C", Offset = "0xEC7C9C", VA = "0xEC7C9C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000179")]
		public List<TaikoNote> SpawnedNotes
		{
			[Token(Token = "0x6000A77")]
			[Address(RVA = "0xEC7CA4", Offset = "0xEC7CA4", VA = "0xEC7CA4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700017A")]
		public float HitLatency
		{
			[Token(Token = "0x6000A78")]
			[Address(RVA = "0xEC7CAC", Offset = "0xEC7CAC", VA = "0xEC7CAC")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A79")]
			[Address(RVA = "0xEC7CB4", Offset = "0xEC7CB4", VA = "0xEC7CB4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700017B")]
		public bool ShowBeatIndicators
		{
			[Token(Token = "0x6000A7A")]
			[Address(RVA = "0xEC7CBC", Offset = "0xEC7CBC", VA = "0xEC7CBC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A7B")]
			[Address(RVA = "0xEC7CC4", Offset = "0xEC7CC4", VA = "0xEC7CC4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700017C")]
		public bool LeftyMode
		{
			[Token(Token = "0x6000A7C")]
			[Address(RVA = "0xEC7CD0", Offset = "0xEC7CD0", VA = "0xEC7CD0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A7D")]
			[Address(RVA = "0xEC7CD8", Offset = "0xEC7CD8", VA = "0xEC7CD8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x14000041")]
		public event Action OnSpawnFail
		{
			[Token(Token = "0x6000A74")]
			[Address(RVA = "0xEC07AC", Offset = "0xEC07AC", VA = "0xEC07AC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000A75")]
			[Address(RVA = "0xEC7C00", Offset = "0xEC7C00", VA = "0xEC7C00")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000A7E")]
		[Address(RVA = "0xEC7CE4", Offset = "0xEC7CE4", VA = "0xEC7CE4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000A7F")]
		[Address(RVA = "0xEC7DC8", Offset = "0xEC7DC8", VA = "0xEC7DC8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000A80")]
		[Address(RVA = "0xEC8010", Offset = "0xEC8010", VA = "0xEC8010")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000A81")]
		[Address(RVA = "0xEC8108", Offset = "0xEC8108", VA = "0xEC8108")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000A82")]
		[Address(RVA = "0xEC7EC8", Offset = "0xEC7EC8", VA = "0xEC7EC8")]
		private void UpdateHitBarPosition()
		{
		}

		[Token(Token = "0x6000A83")]
		[Address(RVA = "0xEC810C", Offset = "0xEC810C", VA = "0xEC810C")]
		private List<TaikoNoteInfo> GetMirroredNoteInfos(List<TaikoNoteInfo> source)
		{
			return null;
		}

		[Token(Token = "0x6000A84")]
		[Address(RVA = "0xEBFBF0", Offset = "0xEBFBF0", VA = "0xEBFBF0")]
		public void Init(TaikoTrack track, GameManager.Difficulty difficulty, TaikoGameParams gameParams, int timeOffset)
		{
		}

		[Token(Token = "0x6000A85")]
		[Address(RVA = "0xEC0AEC", Offset = "0xEC0AEC", VA = "0xEC0AEC")]
		public void Clean(bool cleanIndicators = true)
		{
		}

		[Token(Token = "0x6000A86")]
		[Address(RVA = "0xEC85C0", Offset = "0xEC85C0", VA = "0xEC85C0")]
		private bool GenerateNote(TaikoNoteInfo noteInfo, float timeShift)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A87")]
		[Address(RVA = "0xEC8DD8", Offset = "0xEC8DD8", VA = "0xEC8DD8")]
		private void GenerateIndicator(float startTime, float timeShift)
		{
		}

		[Token(Token = "0x6000A88")]
		[Address(RVA = "0xEC8FAC", Offset = "0xEC8FAC", VA = "0xEC8FAC")]
		public void ToggleHitBarHolo(bool toggle)
		{
		}

		[Token(Token = "0x6000A89")]
		[Address(RVA = "0xEC77FC", Offset = "0xEC77FC", VA = "0xEC77FC")]
		public void DestroyIndicator(TrackIndicator indicator)
		{
		}

		[Token(Token = "0x6000A8A")]
		[Address(RVA = "0xEC9014", Offset = "0xEC9014", VA = "0xEC9014")]
		private void NoteDestroyed(TaikoNote note)
		{
		}

		[Token(Token = "0x6000A8B")]
		[Address(RVA = "0xEC2D30", Offset = "0xEC2D30", VA = "0xEC2D30")]
		public bool HasRemainingNotes()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A8C")]
		[Address(RVA = "0xEC2A8C", Offset = "0xEC2A8C", VA = "0xEC2A8C")]
		public void UpdateMusicTime(float musicTime)
		{
		}

		[Token(Token = "0x6000A8D")]
		[Address(RVA = "0xEC9584", Offset = "0xEC9584", VA = "0xEC9584")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000A8E")]
		[Address(RVA = "0xEC1910", Offset = "0xEC1910", VA = "0xEC1910")]
		public TaikoGameParams.HitToleranceThreshold GetToleranceThresholdForNote(TaikoNote note, TaikoHitChecker.HitCheck hitCheck, float musicTime)
		{
			return default(TaikoGameParams.HitToleranceThreshold);
		}

		[Token(Token = "0x6000A8F")]
		[Address(RVA = "0xEC83B4", Offset = "0xEC83B4", VA = "0xEC83B4")]
		public TaikoGameParams.HitToleranceThreshold GetToleranceThresholdOK()
		{
			return default(TaikoGameParams.HitToleranceThreshold);
		}

		[Token(Token = "0x6000A90")]
		[Address(RVA = "0xEC90FC", Offset = "0xEC90FC", VA = "0xEC90FC")]
		private void CheckActiveNotes()
		{
		}

		[Token(Token = "0x6000A91")]
		[Address(RVA = "0xEC9670", Offset = "0xEC9670", VA = "0xEC9670")]
		private void CheckRumbleState()
		{
		}

		[Token(Token = "0x6000A92")]
		[Address(RVA = "0xEC9744", Offset = "0xEC9744", VA = "0xEC9744")]
		private void RumbleHitOccured(int rumbleHits, int rumbleObjective)
		{
		}

		[Token(Token = "0x6000A93")]
		[Address(RVA = "0xEC1F2C", Offset = "0xEC1F2C", VA = "0xEC1F2C")]
		public void PlayHitEffect(TaikoHitChecker.TaikoHitResult hitResult, TaikoGameParams.HitToleranceThreshold toleranceThreshold, bool leftHitEffect, bool rightHitEffect)
		{
		}

		[Token(Token = "0x6000A94")]
		[Address(RVA = "0xEC98C4", Offset = "0xEC98C4", VA = "0xEC98C4")]
		public TrackPathHandler()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20001CE")]
	public class TrackSession
	{
		[Token(Token = "0x4000A0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int Score;

		[Token(Token = "0x4000A0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<TaikoGameParams.HitTolerance, int> _hitsBreakdown;

		[Token(Token = "0x4000A0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int MaxConsecutiveHits;

		[Token(Token = "0x4000A0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float _centerHitSpeedSum;

		[Token(Token = "0x4000A0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int _centerHitCount;

		[Token(Token = "0x4000A10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float _centerAccHitSpeedSum;

		[Token(Token = "0x4000A11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int _centerAccHitCount;

		[Token(Token = "0x4000A12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float _rimHitSpeedSum;

		[Token(Token = "0x4000A13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int _rimHitCount;

		[Token(Token = "0x4000A14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float _rimAccHitSpeedSum;

		[Token(Token = "0x4000A15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int _rimAccHitCount;

		[Token(Token = "0x4000A16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int _successCenterAccHitCount;

		[Token(Token = "0x4000A17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int _successRimAccHitCount;

		[Token(Token = "0x1700017D")]
		public string TrackName
		{
			[Token(Token = "0x6000A9C")]
			[Address(RVA = "0xEC9AF8", Offset = "0xEC9AF8", VA = "0xEC9AF8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A9D")]
			[Address(RVA = "0xEC9B00", Offset = "0xEC9B00", VA = "0xEC9B00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700017E")]
		public GameManager.Difficulty TrackDifficulty
		{
			[Token(Token = "0x6000A9E")]
			[Address(RVA = "0xEC9B08", Offset = "0xEC9B08", VA = "0xEC9B08")]
			[CompilerGenerated]
			get
			{
				return default(GameManager.Difficulty);
			}
			[Token(Token = "0x6000A9F")]
			[Address(RVA = "0xEC9B10", Offset = "0xEC9B10", VA = "0xEC9B10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700017F")]
		public float CenterHitSpeedAvg
		{
			[Token(Token = "0x6000AA0")]
			[Address(RVA = "0xEC9B18", Offset = "0xEC9B18", VA = "0xEC9B18")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000180")]
		public float CenterAccHitSpeedAvg
		{
			[Token(Token = "0x6000AA1")]
			[Address(RVA = "0xEC9B3C", Offset = "0xEC9B3C", VA = "0xEC9B3C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000181")]
		public float SuccessCenterAccHitAvg
		{
			[Token(Token = "0x6000AA2")]
			[Address(RVA = "0xEC9B60", Offset = "0xEC9B60", VA = "0xEC9B60")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000182")]
		public float RimHitSpeedAvg
		{
			[Token(Token = "0x6000AA3")]
			[Address(RVA = "0xEC9B88", Offset = "0xEC9B88", VA = "0xEC9B88")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000183")]
		public float RimAccHitSpeedAvg
		{
			[Token(Token = "0x6000AA4")]
			[Address(RVA = "0xEC9BAC", Offset = "0xEC9BAC", VA = "0xEC9BAC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000184")]
		public float SuccessRimAccHitAvg
		{
			[Token(Token = "0x6000AA5")]
			[Address(RVA = "0xEC9BD0", Offset = "0xEC9BD0", VA = "0xEC9BD0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000AA6")]
		[Address(RVA = "0xEC9BF8", Offset = "0xEC9BF8", VA = "0xEC9BF8")]
		public TrackSession(string trackName, GameManager.Difficulty trackDifficulty)
		{
		}

		[Token(Token = "0x6000AA7")]
		[Address(RVA = "0xEC9FF0", Offset = "0xEC9FF0", VA = "0xEC9FF0")]
		public int GetHitsForTolerance(TaikoGameParams.HitTolerance tolerance)
		{
			return default(int);
		}

		[Token(Token = "0x6000AA8")]
		[Address(RVA = "0xECA048", Offset = "0xECA048", VA = "0xECA048")]
		public void IncrementHitsForTolerance(TaikoGameParams.HitTolerance tolerance, int add = 1)
		{
		}

		[Token(Token = "0x6000AA9")]
		[Address(RVA = "0xECA0D8", Offset = "0xECA0D8", VA = "0xECA0D8")]
		public void AddHitSpeed(TaikoHitChecker.TaikoHitResult hitResult)
		{
		}
	}
	[Token(Token = "0x20001CF")]
	public class TrackSimulatedScoreRules : ScriptableObject
	{
		[Serializable]
		[Token(Token = "0x20001D0")]
		public struct HitToleranceProbability
		{
			[Token(Token = "0x4000A1B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public TaikoGameParams.HitTolerance Tolerance;

			[Token(Token = "0x4000A1C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[Range(0f, 1f)]
			public float Probability;
		}

		[Serializable]
		[Token(Token = "0x20001D1")]
		public class MedalPlayerProfile
		{
			[Token(Token = "0x4000A1D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Header("General")]
			public TaikoTrack.MedalType Medal;

			[Token(Token = "0x4000A1E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public List<HitToleranceProbability> ToleranceHitMix;

			[Token(Token = "0x4000A1F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Range(0f, 1f)]
			public float ScorePercent;

			[Token(Token = "0x4000A20")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Header("Combo")]
			[Range(0f, 1f)]
			public float ActiveComboActivationRate;

			[Token(Token = "0x4000A21")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int ActiveComboActivationNotesWait;

			[Token(Token = "0x4000A22")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Range(0f, 1f)]
			public float AccentSuccessProbability;

			[Token(Token = "0x6000AAF")]
			[Address(RVA = "0xECA99C", Offset = "0xECA99C", VA = "0xECA99C")]
			public MedalPlayerProfile()
			{
			}
		}

		[Token(Token = "0x4000A18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		public TaikoGameParams GameParams;

		[Token(Token = "0x4000A19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<MedalPlayerProfile> _medalProfiles;

		[Token(Token = "0x4000A1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int _roundToClosest;

		[Token(Token = "0x6000AAA")]
		[Address(RVA = "0xECA208", Offset = "0xECA208", VA = "0xECA208")]
		public MedalPlayerProfile GetMedalPlayerProfile(TaikoTrack.MedalType medal)
		{
			return null;
		}

		[Token(Token = "0x6000AAB")]
		[Address(RVA = "0xECA3FC", Offset = "0xECA3FC", VA = "0xECA3FC")]
		public float GetAverageHitScore(TaikoTrack.MedalType medal)
		{
			return default(float);
		}

		[Token(Token = "0x6000AAC")]
		[Address(RVA = "0xECA6D0", Offset = "0xECA6D0", VA = "0xECA6D0")]
		public float GetAverageComboFill(TaikoTrack.MedalType medal)
		{
			return default(float);
		}

		[Token(Token = "0x6000AAD")]
		[Address(RVA = "0xECA888", Offset = "0xECA888", VA = "0xECA888")]
		public int GetMedalScore(float maxScore, TaikoTrack.MedalType medal)
		{
			return default(int);
		}

		[Token(Token = "0x6000AAE")]
		[Address(RVA = "0xECA98C", Offset = "0xECA98C", VA = "0xECA98C")]
		public TrackSimulatedScoreRules()
		{
		}
	}
	[Token(Token = "0x20001D2")]
	public class TracksManager : MonoBehaviour
	{
		[Token(Token = "0x4000A24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<TaikoTrack> EmbeddedTracks;

		[Token(Token = "0x4000A25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private EventReference _customMusicRef;

		[Token(Token = "0x4000A28")]
		private const string TRACK_FOLDER = "Tracks";

		[Token(Token = "0x17000185")]
		public List<TaikoTrack> CustomTracks
		{
			[Token(Token = "0x6000AB2")]
			[Address(RVA = "0xECAADC", Offset = "0xECAADC", VA = "0xECAADC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AB3")]
			[Address(RVA = "0xECAAE4", Offset = "0xECAAE4", VA = "0xECAAE4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000186")]
		public bool Initialized
		{
			[Token(Token = "0x6000AB4")]
			[Address(RVA = "0xECAAEC", Offset = "0xECAAEC", VA = "0xECAAEC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000AB5")]
			[Address(RVA = "0xECAAF4", Offset = "0xECAAF4", VA = "0xECAAF4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000187")]
		public static string TRACK_PATH
		{
			[Token(Token = "0x6000AB6")]
			[Address(RVA = "0xECAB00", Offset = "0xECAB00", VA = "0xECAB00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000042")]
		public event Action OnTracksInitialized
		{
			[Token(Token = "0x6000AB0")]
			[Address(RVA = "0xECA9A4", Offset = "0xECA9A4", VA = "0xECA9A4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000AB1")]
			[Address(RVA = "0xECAA40", Offset = "0xECAA40", VA = "0xECAA40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000AB7")]
		[Address(RVA = "0xECAB7C", Offset = "0xECAB7C", VA = "0xECAB7C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000AB8")]
		[Address(RVA = "0xECAB80", Offset = "0xECAB80", VA = "0xECAB80")]
		private void InitTracks()
		{
		}

		[Token(Token = "0x6000AB9")]
		[Address(RVA = "0xECADC0", Offset = "0xECADC0", VA = "0xECADC0")]
		private void DetectCustomTracks()
		{
		}

		[Token(Token = "0x6000ABA")]
		[Address(RVA = "0xECB100", Offset = "0xECB100", VA = "0xECB100")]
		public TracksManager()
		{
		}
	}
}
namespace TaikoFrenzy.Audio
{
	[Token(Token = "0x20001D3")]
	public static class AudioUtils
	{
		[Token(Token = "0x4000A29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int SYSTEM_SAMPLE_RATE;

		[Token(Token = "0x6000ABB")]
		[Address(RVA = "0xECB108", Offset = "0xECB108", VA = "0xECB108")]
		public static RESULT ReturnEventChannel(EventInstance eventInstance, out Channel requestedChannel, out ChannelGroup channelsGroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000ABC")]
		[Address(RVA = "0xECB214", Offset = "0xECB214", VA = "0xECB214")]
		public static RESULT ReturnEventChannelGroup(EventInstance eventInstance, out ChannelGroup channelsGroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000ABD")]
		[Address(RVA = "0xECB33C", Offset = "0xECB33C", VA = "0xECB33C")]
		public static RESULT ReturnEventChannel(StudioEventEmitter eventEmitter, out Channel requestedChannel, out ChannelGroup channelsGroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000ABE")]
		[Address(RVA = "0xECB354", Offset = "0xECB354", VA = "0xECB354")]
		public static RESULT GetCurrentDSPClock(ChannelGroup cG, out ulong dspClock, out ulong parent)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000ABF")]
		[Address(RVA = "0xECB450", Offset = "0xECB450", VA = "0xECB450")]
		public static float GetDSPTime(ulong dspClock)
		{
			return default(float);
		}
	}
	[Token(Token = "0x20001D4")]
	public class BackTrackPlayer
	{
		[Serializable]
		[Token(Token = "0x20001D5")]
		private class SideloadedParams
		{
			[Token(Token = "0x4000A30")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string FilePath;

			[Token(Token = "0x4000A31")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int TimeOffset;

			[Token(Token = "0x6000ACD")]
			[Address(RVA = "0xECBE54", Offset = "0xECBE54", VA = "0xECBE54")]
			public SideloadedParams(string filePath, int timeOffset)
			{
			}

			[Token(Token = "0x6000ACE")]
			[Address(RVA = "0xECBE90", Offset = "0xECBE90", VA = "0xECBE90")]
			public string ToJson()
			{
				return null;
			}
		}

		[Token(Token = "0x4000A2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TaikoTrack _track;

		[Token(Token = "0x4000A2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private EventInstance _eventInstance;

		[Token(Token = "0x4000A2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private EVENT_CALLBACK _eventCallback;

		[Token(Token = "0x4000A2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int _timeOffset;

		[Token(Token = "0x4000A2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int _pausedPosition;

		[Token(Token = "0x17000188")]
		public float Time
		{
			[Token(Token = "0x6000AC0")]
			[Address(RVA = "0xECB888", Offset = "0xECB888", VA = "0xECB888")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000189")]
		public bool IsPlaying
		{
			[Token(Token = "0x6000AC1")]
			[Address(RVA = "0xECB914", Offset = "0xECB914", VA = "0xECB914")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700018A")]
		public float Duration
		{
			[Token(Token = "0x6000AC2")]
			[Address(RVA = "0xECB970", Offset = "0xECB970", VA = "0xECB970")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000AC3")]
			[Address(RVA = "0xECB978", Offset = "0xECB978", VA = "0xECB978")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700018B")]
		public float Progress
		{
			[Token(Token = "0x6000AC4")]
			[Address(RVA = "0xECB980", Offset = "0xECB980", VA = "0xECB980")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000AC5")]
		[Address(RVA = "0xECB99C", Offset = "0xECB99C", VA = "0xECB99C")]
		public BackTrackPlayer(TaikoTrack track, int timeOffset)
		{
		}

		[Token(Token = "0x6000AC6")]
		[Address(RVA = "0xECBD14", Offset = "0xECBD14", VA = "0xECBD14")]
		public void Start(bool autoRelease = true)
		{
		}

		[Token(Token = "0x6000AC7")]
		[Address(RVA = "0xECBD54", Offset = "0xECBD54", VA = "0xECBD54")]
		public void Stop(FMOD.Studio.STOP_MODE stopMode, bool release = true)
		{
		}

		[Token(Token = "0x6000AC8")]
		[Address(RVA = "0xECBDAC", Offset = "0xECBDAC", VA = "0xECBDAC")]
		public void Pause()
		{
		}

		[Token(Token = "0x6000AC9")]
		[Address(RVA = "0xECBE00", Offset = "0xECBE00", VA = "0xECBE00")]
		public void Resume()
		{
		}

		[Token(Token = "0x6000ACA")]
		[Address(RVA = "0xECBB68", Offset = "0xECBB68", VA = "0xECBB68")]
		private EventInstance CreateSideloadedEvent(EventReference programmerSoundEventRef, string filePath, int timeOffset)
		{
			return default(EventInstance);
		}

		[Token(Token = "0x6000ACB")]
		[Address(RVA = "0xECB4F0", Offset = "0xECB4F0", VA = "0xECB4F0")]
		[MonoPInvokeCallback(typeof(EVENT_CALLBACK))]
		private static RESULT EmbedEventCallback(EVENT_CALLBACK_TYPE type, IntPtr instancePtr, IntPtr parameterPtr)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000ACC")]
		[Address(RVA = "0xECB4F8", Offset = "0xECB4F8", VA = "0xECB4F8")]
		[MonoPInvokeCallback(typeof(EVENT_CALLBACK))]
		private static RESULT SideloadedEventCallback(EVENT_CALLBACK_TYPE type, IntPtr instancePtr, IntPtr parameterPtr)
		{
			return default(RESULT);
		}
	}
	[Token(Token = "0x20001D6")]
	public class FMODAudioSettings : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20001D7")]
		private struct BusData
		{
			[Token(Token = "0x4000A34")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public BusType Type;

			[Token(Token = "0x4000A35")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string FmodPath;

			[Token(Token = "0x4000A36")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string VolumeSettingParam;
		}

		[Serializable]
		[Token(Token = "0x20001D8")]
		private struct BusReference
		{
			[Token(Token = "0x4000A37")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Bus Bus;

			[Token(Token = "0x4000A38")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string VolumeSettingParam;
		}

		[Token(Token = "0x20001D9")]
		public enum BusType
		{
			[Token(Token = "0x4000A3A")]
			Master,
			[Token(Token = "0x4000A3B")]
			Music,
			[Token(Token = "0x4000A3C")]
			GeneralSFX,
			[Token(Token = "0x4000A3D")]
			Hits,
			[Token(Token = "0x4000A3E")]
			UI
		}

		[Token(Token = "0x4000A32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<BusData> _busList;

		[Token(Token = "0x4000A33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<BusType, BusReference> _busDictionary;

		[Token(Token = "0x6000ACF")]
		[Address(RVA = "0xECBE98", Offset = "0xECBE98", VA = "0xECBE98")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000AD0")]
		[Address(RVA = "0xECC0D0", Offset = "0xECC0D0", VA = "0xECC0D0")]
		public void SetBusVolume(BusType type, float volume)
		{
		}

		[Token(Token = "0x6000AD1")]
		[Address(RVA = "0xECC23C", Offset = "0xECC23C", VA = "0xECC23C")]
		public float GetBusVolume(BusType type)
		{
			return default(float);
		}

		[Token(Token = "0x6000AD2")]
		[Address(RVA = "0xECC384", Offset = "0xECC384", VA = "0xECC384")]
		public float GetBusDefaultVolume(BusType type)
		{
			return default(float);
		}

		[Token(Token = "0x6000AD3")]
		[Address(RVA = "0xECC488", Offset = "0xECC488", VA = "0xECC488")]
		public FMODAudioSettings()
		{
		}
	}
	[Token(Token = "0x20001DA")]
	internal static class TaikoSounds
	{
		[Token(Token = "0x20001DB")]
		public enum HitPosition
		{
			[Token(Token = "0x4000A42")]
			Center,
			[Token(Token = "0x4000A43")]
			Rim
		}

		[Token(Token = "0x4000A3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<HitPosition, string> EVENTS_DICTIONARY;

		[Token(Token = "0x4000A40")]
		private const string HIT_INTENSITY_PARAMETER = "HitIntensity";

		[Token(Token = "0x6000AD4")]
		[Address(RVA = "0xECC490", Offset = "0xECC490", VA = "0xECC490")]
		public static EventInstance PlayTaikoHit(HitPosition hitPosition, float hitIntensity, float volume, [System.Runtime.InteropServices.Optional] Vector3 position)
		{
			return default(EventInstance);
		}
	}
}
namespace TaikoFrenzy.Analytics
{
	[Token(Token = "0x20001DC")]
	public class AnalyticsManager : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20001DD")]
		private struct ToleranceParam
		{
			[Token(Token = "0x4000A59")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public TaikoGameParams.HitTolerance Tolerance;

			[Token(Token = "0x4000A5A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string Parameter;
		}

		[StructLayout(3)]
		[Token(Token = "0x20001DF")]
		[CompilerGenerated]
		private struct <Init>d__32 : IAsyncStateMachine
		{
			[Token(Token = "0x4000A5E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000A5F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Token(Token = "0x4000A60")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public AnalyticsManager <>4__this;

			[Token(Token = "0x4000A61")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TaskAwaiter <>u__1;

			[Token(Token = "0x4000A62")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private TaskAwaiter<List<string>> <>u__2;

			[Token(Token = "0x6000AE8")]
			[Address(RVA = "0xECE610", Offset = "0xECE610", VA = "0xECE610", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000AE9")]
			[Address(RVA = "0xECEC24", Offset = "0xECEC24", VA = "0xECEC24", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4000A46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("General")]
		private string _environment;

		[Token(Token = "0x4000A47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _overrideUserId;

		[Token(Token = "0x4000A48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _trackNameParameter;

		[Token(Token = "0x4000A49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string _trackDifficultyParameter;

		[Token(Token = "0x4000A4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Header("Rating")]
		private string _trackRatingEvent;

		[Token(Token = "0x4000A4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private string _ratingParameter;

		[Token(Token = "0x4000A4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Header("Session")]
		[SerializeField]
		private string _trackSessionEvent;

		[Token(Token = "0x4000A4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private string _trackScoreParameter;

		[Token(Token = "0x4000A4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private string _maxConsecutiveHitsParameter;

		[Token(Token = "0x4000A4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private string _centerHitSpeedAvgParameter;

		[Token(Token = "0x4000A50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private string _centerAccHitSpeedAvgParameter;

		[Token(Token = "0x4000A51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private string _successCenterAccHitAvgParameter;

		[Token(Token = "0x4000A52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private string _rimHitSpeedAvgParameter;

		[Token(Token = "0x4000A53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private string _rimAccHitSpeedAvgParameter;

		[Token(Token = "0x4000A54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private string _successRimAccHitAvgParameter;

		[Token(Token = "0x4000A55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private ToleranceParam[] _toleranceParameters;

		[Token(Token = "0x4000A56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Header("Medals")]
		private string _medalUnlockedEvent;

		[Token(Token = "0x4000A57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private string _medalTypeParameter;

		[Token(Token = "0x4000A58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Dictionary<TaikoGameParams.HitTolerance, string> _toleranceParamsDictionary;

		[Token(Token = "0x1700018C")]
		public static AnalyticsManager Instance
		{
			[Token(Token = "0x6000AD6")]
			[Address(RVA = "0xECC7C8", Offset = "0xECC7C8", VA = "0xECC7C8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AD7")]
			[Address(RVA = "0xECC810", Offset = "0xECC810", VA = "0xECC810")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700018D")]
		public bool Initialized
		{
			[Token(Token = "0x6000AD8")]
			[Address(RVA = "0xECC868", Offset = "0xECC868", VA = "0xECC868")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000AD9")]
			[Address(RVA = "0xECC870", Offset = "0xECC870", VA = "0xECC870")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000ADA")]
		[Address(RVA = "0xECC87C", Offset = "0xECC87C", VA = "0xECC87C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000ADB")]
		[Address(RVA = "0xECCE00", Offset = "0xECCE00", VA = "0xECCE00")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000ADC")]
		[Address(RVA = "0xECCFEC", Offset = "0xECCFEC", VA = "0xECCFEC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000ADD")]
		[Address(RVA = "0xECD160", Offset = "0xECD160", VA = "0xECD160")]
		private string GetPlatformUserId()
		{
			return null;
		}

		[Token(Token = "0x6000ADE")]
		[Address(RVA = "0xECCF38", Offset = "0xECCF38", VA = "0xECCF38")]
		[AsyncStateMachine(typeof(<Init>d__32))]
		private void Init()
		{
		}

		[Token(Token = "0x6000ADF")]
		[Address(RVA = "0xECD1C8", Offset = "0xECD1C8", VA = "0xECD1C8")]
		private void ConnectionStatusChanged()
		{
		}

		[Token(Token = "0x6000AE0")]
		[Address(RVA = "0xECD30C", Offset = "0xECD30C", VA = "0xECD30C")]
		public void SendRating(string trackName, GameManager.Difficulty trackDifficulty, float rating, bool forceFlush = false)
		{
		}

		[Token(Token = "0x6000AE1")]
		[Address(RVA = "0xECD5F4", Offset = "0xECD5F4", VA = "0xECD5F4")]
		public void SendMedalUnlocked(TrackSession session, List<TaikoTrack.MedalType> newUnlocked, bool forceFlush = false)
		{
		}

		[Token(Token = "0x6000AE2")]
		[Address(RVA = "0xECDA4C", Offset = "0xECDA4C", VA = "0xECDA4C")]
		public void SendSession(TrackSession session, bool forceFlush = false)
		{
		}

		[Token(Token = "0x6000AE3")]
		[Address(RVA = "0xECE2F4", Offset = "0xECE2F4", VA = "0xECE2F4")]
		public AnalyticsManager()
		{
		}
	}
}
