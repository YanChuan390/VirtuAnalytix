using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class Constants
{
	[Token(Token = "0x2000003")]
	public enum AndroidStore
	{
		[Token(Token = "0x4000030")]
		GOOGLE_PLAY,
		[Token(Token = "0x4000031")]
		AMAZON
	}

	[Token(Token = "0x4000001")]
	public const int GAME_VERSION = 67;

	[Token(Token = "0x4000002")]
	public const string SUPPORT_EMAIL = "support@ivanovichgames.com";

	[Token(Token = "0x4000003")]
	public const string URL_GOOGLE_PLAY = "https://play.google.com/store/apps/details?id=com.final_kick.best_penalty_shootout.soccer_football_game_free";

	[Token(Token = "0x4000004")]
	public const string URL_ITUNES = "https://itunes.apple.com/app/id778300400";

	[Token(Token = "0x4000005")]
	public const string URL_AMAZON = "http://www.amazon.com/gp/product/B0184DJYTW";

	[Token(Token = "0x4000006")]
	public const string ITUNES_RATE_URL_7_OR_GREATER = "itms-apps://itunes.apple.com/app/id778300400";

	[Token(Token = "0x4000007")]
	public const string ITUNES_RATE_URL_LESS_THAN_7 = "itms-apps://itunes.apple.com/WebObjects/MZStore.woa/wa/viewContentsUserReviews?type=Purple+Software&id=778300400";

	[Token(Token = "0x4000008")]
	public const string AMAZON_RATE_URL = "amzn://apps/android?p=com.final_kick.best_penalty_shootout.soccer_football_game_free.underground";

	[Token(Token = "0x4000009")]
	public const string GOOGLE_PUBLIC_KEY = "MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAl7RicqLRq7m0yKCp7kOnfafj86YR9WJMYOVumh1KZLadTUUeI8Tr4zcqWDp1xQRSxGPqE5A5NHPK5leIDuYW9qzvuojObBlm3g1eEYqpxyzt/6qCSEkJRO5KuG6iBRFIWyjETNx+wsYms7qiV9uFEuPifMT9H3YSmovHtrlRg6ab98QaAkwqCxpKN+QjabLWCFCvqppLe4g1FjUXxLR/1X2rpFLZMQ3x/enuKZD8fFSfLgUatr6RYe1CZonAgq9JtaXkJglvEkanbWgqMR90x/JkxXX93lNhF5pGIbN/1rV1yU4prYs7rWulaZKXYM1jbqJ+QL/QRWYWPjbdLPbg3wIDAQAB";

	[Token(Token = "0x400000A")]
	public const string URL_MORE_FUN = "http://www.ivanovichgames.com/web/games/";

	[Token(Token = "0x400000B")]
	public const string GAME_WEBSITE_SHARED_IN_FACEBOOK = "http://finalkick.me/d/39";

	[Token(Token = "0x400000C")]
	public const string GAME_WEBSITE_RECOMMENDED_BY_EMAIL = "http://finalkick.me/d/41";

	[Token(Token = "0x400000D")]
	public const string GAME_WEBSITE_ICON = "http://www.finalkick.me/final_kick_icon.jpg";

	[Token(Token = "0x400000E")]
	public const string WEBSITE_ITUNES_IMAGE = "http://www.finalkick.me/button_app_store.png";

	[Token(Token = "0x400000F")]
	public const string WEBSITE_GOOGLE_PLAY_IMAGE = "http://www.finalkick.me/button_google_play.png";

	[Token(Token = "0x4000010")]
	public const string WEBSITE_AMAZON_IMAGE = "http://www.finalkick.me/button_amazon.png";

	[Token(Token = "0x4000011")]
	public const string GAME_WEBSITE_SHORT = "finalkick.me";

	[Token(Token = "0x4000012")]
	public const string FACEBOOK_URL = "http://www.facebook.com/FinalKick.me";

	[Token(Token = "0x4000013")]
	public const string FACEBOOK_SECURE_URL = "https://facebook.com/FinalKick.me";

	[Token(Token = "0x4000014")]
	public const string FACEBOOK_IOS_APP_URL = "fb://profile/205285369660930";

	[Token(Token = "0x4000015")]
	public const int NUM_MAX_PENALTIES_FINAL_KICK_TV = 150;

	[Token(Token = "0x4000016")]
	public const AndroidStore ANDROID_STORE = AndroidStore.GOOGLE_PLAY;

	[Token(Token = "0x4000017")]
	public const string MAIN_SERVER_IP = "http://finalkick.me/fkphpserver/";

	[Token(Token = "0x4000018")]
	public const string PROMOCODE_FULL_URL = "http://www.ivanovichgames.com/promocode.php";

	[Token(Token = "0x4000019")]
	public const string MAIN_SERVER_IP_MONGO = "http://finalkick.me/fk/";

	[Token(Token = "0x400001A")]
	public const float MAX_STATS_VALUE = 1.3f;

	[Token(Token = "0x400001B")]
	public const int PRACTICE_TOURNAMENT_ID = 1000000;

	[Token(Token = "0x400001C")]
	public const int HOURS_BY_DAY = 24;

	[Token(Token = "0x400001D")]
	public const int SECONDS_BY_HOUR = 3600;

	[Token(Token = "0x400001E")]
	public const int DAYS_BY_WEEK = 7;

	[Token(Token = "0x400001F")]
	public const int HOURS_TO_UPDATE_SERVER_CONSTANTS = 1;

	[Token(Token = "0x4000020")]
	public const bool CARNIVAL_ACTIVE = false;

	[Token(Token = "0x4000021")]
	public const string hideServer = "http://46.4.98.145:8001";

	[Token(Token = "0x4000022")]
	public const bool showHideServer = false;

	[Token(Token = "0x4000023")]
	public const int hidePlayer = 1;

	[Token(Token = "0x4000024")]
	public const int NUM_BARRIER_JUMP_TYPES = 11;

	[Token(Token = "0x4000025")]
	public const bool modeFaltas = true;

	[Token(Token = "0x4000026")]
	public const int KICK_TOURNAMENT_OFFSET = 3000000;

	[Token(Token = "0x4000027")]
	public const float KICK_GOALKEEPER_ACCURACY_FACTOR = 1.3f;

	[Token(Token = "0x4000028")]
	public const float KICK_GOALKEEPER_ROTATION_TIME = 0.3f;

	[Token(Token = "0x4000029")]
	public const string NEWS_JSON_URL = "http://finalkick.me/as.json";

	[Token(Token = "0x400002A")]
	public const float MIN_SHOOTER_POWER = 0.2f;

	[Token(Token = "0x400002B")]
	public const float MIN_SHOOTER_EFFECT = 0.1f;

	[Token(Token = "0x400002C")]
	public const float MIN_GOALKEEPER_ACCURACY = 0.2f;

	[Token(Token = "0x400002D")]
	public const float MIN_GOALKEEPER_REFLEXES = 0.2f;

	[Token(Token = "0x400002E")]
	public const float MIN_PLAYER_RESISTANCE = 0f;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x893C18", Offset = "0x893C18", VA = "0x893C18")]
	public static string GetStoreGameURL()
	{
		return null;
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x893C58", Offset = "0x893C58", VA = "0x893C58")]
	public static string GetRateUrl()
	{
		return null;
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x893CA4", Offset = "0x893CA4", VA = "0x893CA4")]
	public static string GetPlatformAndVersion()
	{
		return null;
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x893D14", Offset = "0x893D14", VA = "0x893D14")]
	public static bool IsAmazonVersion()
	{
		return default(bool);
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x893D1C", Offset = "0x893D1C", VA = "0x893D1C")]
	public Constants()
	{
	}
}
[Token(Token = "0x2000004")]
public class OSUtils : MonoBehaviour
{
	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject globalsObject;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static GameObject objectToReplyAboutRate;

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x893D24", Offset = "0x893D24", VA = "0x893D24")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x893D28", Offset = "0x893D28", VA = "0x893D28")]
	private void Start()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x893D80", Offset = "0x893D80", VA = "0x893D80")]
	public static void LogDebug(object objectToLog)
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x893DD0", Offset = "0x893DD0", VA = "0x893DD0")]
	public static void ShowOptionsAlertAndOpenItsURL(string title, string text, string button1, string button2, string button3, string urlOrAction1, string urlOrAction2, string urlOrAction3)
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x893DD4", Offset = "0x893DD4", VA = "0x893DD4")]
	public static string Md5Sum(string strToEncrypt)
	{
		return null;
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x893F64", Offset = "0x893F64", VA = "0x893F64")]
	public static byte[] StringToByteArray(string hex)
	{
		return null;
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x894078", Offset = "0x894078", VA = "0x894078")]
	public static string ByteArrayToString(byte[] ba)
	{
		return null;
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x894110", Offset = "0x894110", VA = "0x894110")]
	public static string IGConnectCalculateCRC(ArrayList param)
	{
		return null;
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x894494", Offset = "0x894494", VA = "0x894494")]
	public static string IGConnectGetHashCode(string str)
	{
		return null;
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x894598", Offset = "0x894598", VA = "0x894598")]
	public static string GetLanguageTwoLetters(string fullLanguageName)
	{
		return null;
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x89481C", Offset = "0x89481C", VA = "0x89481C")]
	public OSUtils()
	{
	}
}
namespace Kernys.Bson
{
	[Token(Token = "0x2000005")]
	public class BSONValue
	{
		[Token(Token = "0x2000006")]
		public enum ValueType
		{
			[Token(Token = "0x400003D")]
			Double,
			[Token(Token = "0x400003E")]
			String,
			[Token(Token = "0x400003F")]
			Array,
			[Token(Token = "0x4000040")]
			Binary,
			[Token(Token = "0x4000041")]
			Boolean,
			[Token(Token = "0x4000042")]
			UTCDateTime,
			[Token(Token = "0x4000043")]
			None,
			[Token(Token = "0x4000044")]
			Int32,
			[Token(Token = "0x4000045")]
			Int64,
			[Token(Token = "0x4000046")]
			Object
		}

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private ValueType mValueType;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private double _double;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string _string;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private byte[] _binary;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool _bool;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private DateTime _dateTime;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int _int32;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private long _int64;

		[Token(Token = "0x17000001")]
		public ValueType valueType
		{
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x894824", Offset = "0x894824", VA = "0x894824")]
			get
			{
				return default(ValueType);
			}
		}

		[Token(Token = "0x17000002")]
		public double doubleValue
		{
			[Token(Token = "0x6000012")]
			[Address(RVA = "0x89482C", Offset = "0x89482C", VA = "0x89482C")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000003")]
		public int int32Value
		{
			[Token(Token = "0x6000013")]
			[Address(RVA = "0x894900", Offset = "0x894900", VA = "0x894900")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000004")]
		public long int64Value
		{
			[Token(Token = "0x6000014")]
			[Address(RVA = "0x8949D0", Offset = "0x8949D0", VA = "0x8949D0")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x17000005")]
		public byte[] binaryValue
		{
			[Token(Token = "0x6000015")]
			[Address(RVA = "0x894AA0", Offset = "0x894AA0", VA = "0x894AA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000006")]
		public DateTime dateTimeValue
		{
			[Token(Token = "0x6000016")]
			[Address(RVA = "0x894B3C", Offset = "0x894B3C", VA = "0x894B3C")]
			get
			{
				return default(DateTime);
			}
		}

		[Token(Token = "0x17000007")]
		public string stringValue
		{
			[Token(Token = "0x6000017")]
			[Address(RVA = "0x894BD8", Offset = "0x894BD8", VA = "0x894BD8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000008")]
		public bool boolValue
		{
			[Token(Token = "0x6000018")]
			[Address(RVA = "0x894DC0", Offset = "0x894DC0", VA = "0x894DC0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000009")]
		public bool isNone
		{
			[Token(Token = "0x6000019")]
			[Address(RVA = "0x894E5C", Offset = "0x894E5C", VA = "0x894E5C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000A")]
		public virtual BSONValue this[string key]
		{
			[Token(Token = "0x600001A")]
			[Address(RVA = "0x894E6C", Offset = "0x894E6C", VA = "0x894E6C", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600001B")]
			[Address(RVA = "0x894E74", Offset = "0x894E74", VA = "0x894E74", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		public virtual BSONValue this[int index]
		{
			[Token(Token = "0x600001C")]
			[Address(RVA = "0x894E78", Offset = "0x894E78", VA = "0x894E78", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x600001D")]
			[Address(RVA = "0x894E80", Offset = "0x894E80", VA = "0x894E80", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x894E84", Offset = "0x894E84", VA = "0x894E84", Slot = "8")]
		public virtual void Clear()
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x894E88", Offset = "0x894E88", VA = "0x894E88", Slot = "9")]
		public virtual void Add(string key, BSONValue value)
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x894E8C", Offset = "0x894E8C", VA = "0x894E8C", Slot = "10")]
		public virtual void Add(BSONValue value)
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x894E90", Offset = "0x894E90", VA = "0x894E90", Slot = "11")]
		public virtual bool Contains(BSONValue v)
		{
			return default(bool);
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x894E98", Offset = "0x894E98", VA = "0x894E98", Slot = "12")]
		public virtual bool ContainsKey(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x894EA0", Offset = "0x894EA0", VA = "0x894EA0")]
		public static implicit operator BSONValue(double v)
		{
			return null;
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x894F3C", Offset = "0x894F3C", VA = "0x894F3C")]
		public static implicit operator BSONValue(int v)
		{
			return null;
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x894FD8", Offset = "0x894FD8", VA = "0x894FD8")]
		public static implicit operator BSONValue(long v)
		{
			return null;
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x895074", Offset = "0x895074", VA = "0x895074")]
		public static implicit operator BSONValue(byte[] v)
		{
			return null;
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x895124", Offset = "0x895124", VA = "0x895124")]
		public static implicit operator BSONValue(DateTime v)
		{
			return null;
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x8951C0", Offset = "0x8951C0", VA = "0x8951C0")]
		public static implicit operator BSONValue(string v)
		{
			return null;
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x895270", Offset = "0x895270", VA = "0x895270")]
		public static implicit operator double(BSONValue v)
		{
			return default(double);
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x895280", Offset = "0x895280", VA = "0x895280")]
		public static implicit operator int(BSONValue v)
		{
			return default(int);
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x895290", Offset = "0x895290", VA = "0x895290")]
		public static implicit operator long(BSONValue v)
		{
			return default(long);
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x8952A0", Offset = "0x8952A0", VA = "0x8952A0")]
		public static implicit operator byte[](BSONValue v)
		{
			return null;
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x8952B0", Offset = "0x8952B0", VA = "0x8952B0")]
		public static implicit operator DateTime(BSONValue v)
		{
			return default(DateTime);
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x8952C0", Offset = "0x8952C0", VA = "0x8952C0")]
		public static implicit operator string(BSONValue v)
		{
			return null;
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x8952D0", Offset = "0x8952D0", VA = "0x8952D0")]
		protected BSONValue(ValueType valueType)
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x8952F8", Offset = "0x8952F8", VA = "0x8952F8")]
		public BSONValue()
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x894F10", Offset = "0x894F10", VA = "0x894F10")]
		public BSONValue(double v)
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x895238", Offset = "0x895238", VA = "0x895238")]
		public BSONValue(string v)
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x8950EC", Offset = "0x8950EC", VA = "0x8950EC")]
		public BSONValue(byte[] v)
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x895318", Offset = "0x895318", VA = "0x895318")]
		public BSONValue(bool v)
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x895190", Offset = "0x895190", VA = "0x895190")]
		public BSONValue(DateTime dt)
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x894FA8", Offset = "0x894FA8", VA = "0x894FA8")]
		public BSONValue(int v)
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x895044", Offset = "0x895044", VA = "0x895044")]
		public BSONValue(long v)
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x895348", Offset = "0x895348", VA = "0x895348")]
		public static bool operator ==(BSONValue a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x895360", Offset = "0x895360", VA = "0x895360")]
		public static bool operator !=(BSONValue a, object b)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000007")]
	public class BSONObject : BSONValue, IEnumerable
	{
		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Dictionary<string, BSONValue> mMap;

		[Token(Token = "0x1700000C")]
		public ICollection<string> Keys
		{
			[Token(Token = "0x600003B")]
			[Address(RVA = "0x89540C", Offset = "0x89540C", VA = "0x89540C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000D")]
		public ICollection<BSONValue> Values
		{
			[Token(Token = "0x600003C")]
			[Address(RVA = "0x89545C", Offset = "0x89545C", VA = "0x89545C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000E")]
		public int Count
		{
			[Token(Token = "0x600003D")]
			[Address(RVA = "0x8954AC", Offset = "0x8954AC", VA = "0x8954AC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700000F")]
		public override BSONValue this[string key]
		{
			[Token(Token = "0x600003E")]
			[Address(RVA = "0x8954FC", Offset = "0x8954FC", VA = "0x8954FC", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600003F")]
			[Address(RVA = "0x895554", Offset = "0x895554", VA = "0x895554", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x895378", Offset = "0x895378", VA = "0x895378")]
		public BSONObject()
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x8955BC", Offset = "0x8955BC", VA = "0x8955BC", Slot = "8")]
		public override void Clear()
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x89560C", Offset = "0x89560C", VA = "0x89560C", Slot = "9")]
		public override void Add(string key, BSONValue value)
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x895674", Offset = "0x895674", VA = "0x895674", Slot = "11")]
		public override bool Contains(BSONValue v)
		{
			return default(bool);
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x8956CC", Offset = "0x8956CC", VA = "0x8956CC", Slot = "12")]
		public override bool ContainsKey(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x895724", Offset = "0x895724", VA = "0x895724")]
		public bool Remove(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x89577C", Offset = "0x89577C", VA = "0x89577C")]
		public bool TryGetValue(string key, out BSONValue value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x8957E4", Offset = "0x8957E4", VA = "0x8957E4", Slot = "13")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
	[Token(Token = "0x2000008")]
	public class BSONArray : BSONValue, IEnumerable
	{
		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<BSONValue> mList;

		[Token(Token = "0x17000010")]
		public override BSONValue this[int index]
		{
			[Token(Token = "0x6000048")]
			[Address(RVA = "0x89590C", Offset = "0x89590C", VA = "0x89590C", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000049")]
			[Address(RVA = "0x895964", Offset = "0x895964", VA = "0x895964", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public int Count
		{
			[Token(Token = "0x600004A")]
			[Address(RVA = "0x8959CC", Offset = "0x8959CC", VA = "0x8959CC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x895878", Offset = "0x895878", VA = "0x895878")]
		public BSONArray()
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x895A14", Offset = "0x895A14", VA = "0x895A14", Slot = "10")]
		public override void Add(BSONValue v)
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x895AC4", Offset = "0x895AC4", VA = "0x895AC4")]
		public int IndexOf(BSONValue item)
		{
			return default(int);
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x895B1C", Offset = "0x895B1C", VA = "0x895B1C")]
		public void Insert(int index, BSONValue item)
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x895B84", Offset = "0x895B84", VA = "0x895B84")]
		public bool Remove(BSONValue v)
		{
			return default(bool);
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x895BDC", Offset = "0x895BDC", VA = "0x895BDC")]
		public void RemoveAt(int index)
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x895C34", Offset = "0x895C34", VA = "0x895C34", Slot = "8")]
		public override void Clear()
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x895CA4", Offset = "0x895CA4", VA = "0x895CA4", Slot = "14")]
		public new virtual bool Contains(BSONValue v)
		{
			return default(bool);
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x895CFC", Offset = "0x895CFC", VA = "0x895CFC", Slot = "13")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
	[Token(Token = "0x2000009")]
	public class SimpleBSON
	{
		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private MemoryStream mMemoryStream;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private BinaryReader mBinaryReader;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BinaryWriter mBinaryWriter;

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x895D8C", Offset = "0x895D8C", VA = "0x895D8C")]
		public static BSONObject Load(byte[] buf)
		{
			return null;
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x896048", Offset = "0x896048", VA = "0x896048")]
		public static byte[] Dump(BSONObject obj)
		{
			return null;
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x895DEC", Offset = "0x895DEC", VA = "0x895DEC")]
		private SimpleBSON([Optional] byte[] buf)
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x896560", Offset = "0x896560", VA = "0x896560")]
		private BSONValue decodeElement(out string name)
		{
			return null;
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x895F1C", Offset = "0x895F1C", VA = "0x895F1C")]
		private BSONObject decodeDocument()
		{
			return null;
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x896B90", Offset = "0x896B90", VA = "0x896B90")]
		private BSONArray decodeArray()
		{
			return null;
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x896B24", Offset = "0x896B24", VA = "0x896B24")]
		private string decodeString()
		{
			return null;
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x896A3C", Offset = "0x896A3C", VA = "0x896A3C")]
		private string decodeCString()
		{
			return null;
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x896CA0", Offset = "0x896CA0", VA = "0x896CA0")]
		private void encodeElement(MemoryStream ms, string name, BSONValue v)
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x896170", Offset = "0x896170", VA = "0x896170")]
		private void encodeDocument(MemoryStream ms, BSONObject obj)
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x8972A8", Offset = "0x8972A8", VA = "0x8972A8")]
		private void encodeArray(MemoryStream ms, BSONArray lst)
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x8973B0", Offset = "0x8973B0", VA = "0x8973B0")]
		private void encodeBinary(MemoryStream ms, byte[] buf)
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x897044", Offset = "0x897044", VA = "0x897044")]
		private void encodeCString(MemoryStream ms, string v)
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x897190", Offset = "0x897190", VA = "0x897190")]
		private void encodeString(MemoryStream ms, string v)
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x897100", Offset = "0x897100", VA = "0x897100")]
		private void encodeDouble(MemoryStream ms, double v)
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x897474", Offset = "0x897474", VA = "0x897474")]
		private void encodeBool(MemoryStream ms, bool v)
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x897664", Offset = "0x897664", VA = "0x897664")]
		private void encodeInt32(MemoryStream ms, int v)
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x8976F4", Offset = "0x8976F4", VA = "0x8976F4")]
		private void encodeInt64(MemoryStream ms, long v)
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x897504", Offset = "0x897504", VA = "0x897504")]
		private void encodeUTCDateTime(MemoryStream ms, DateTime dt)
		{
		}
	}
}
namespace UnityStandardAssets.ImageEffects
{
	[Token(Token = "0x200000A")]
	public enum AAMode
	{
		[Token(Token = "0x400004D")]
		FXAA2,
		[Token(Token = "0x400004E")]
		FXAA3Console,
		[Token(Token = "0x400004F")]
		FXAA1PresetA,
		[Token(Token = "0x4000050")]
		FXAA1PresetB,
		[Token(Token = "0x4000051")]
		NFAA,
		[Token(Token = "0x4000052")]
		SSAA,
		[Token(Token = "0x4000053")]
		DLAA
	}
	[Token(Token = "0x200000B")]
	[AddComponentMenu("Image Effects/Other/Antialiasing")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class Antialiasing : PostEffectsBase
	{
		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AAMode mode;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool showGeneratedNormals;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float offsetScale;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float blurRadius;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float edgeThresholdMin;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float edgeThreshold;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float edgeSharpness;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool dlaaSharp;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader ssaaShader;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material ssaa;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader dlaaShader;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material dlaa;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Shader nfaaShader;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material nfaa;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Shader shaderFXAAPreset2;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Material materialFXAAPreset2;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Shader shaderFXAAPreset3;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Material materialFXAAPreset3;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Shader shaderFXAAII;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Material materialFXAAII;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Shader shaderFXAAIII;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Material materialFXAAIII;

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x897784", Offset = "0x897784", VA = "0x897784")]
		public Material CurrentAAMaterial()
		{
			return null;
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x8977EC", Offset = "0x8977EC", VA = "0x8977EC", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x89795C", Offset = "0x89795C", VA = "0x89795C")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x897E20", Offset = "0x897E20", VA = "0x897E20")]
		public Antialiasing()
		{
		}
	}
	[Token(Token = "0x200000C")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Bloom and Glow/Bloom")]
	public class Bloom : PostEffectsBase
	{
		[Token(Token = "0x200000D")]
		public enum LensFlareStyle
		{
			[Token(Token = "0x4000089")]
			Ghosting,
			[Token(Token = "0x400008A")]
			Anamorphic,
			[Token(Token = "0x400008B")]
			Combined
		}

		[Token(Token = "0x200000E")]
		public enum TweakMode
		{
			[Token(Token = "0x400008D")]
			Basic,
			[Token(Token = "0x400008E")]
			Complex
		}

		[Token(Token = "0x200000F")]
		public enum HDRBloomMode
		{
			[Token(Token = "0x4000090")]
			Auto,
			[Token(Token = "0x4000091")]
			On,
			[Token(Token = "0x4000092")]
			Off
		}

		[Token(Token = "0x2000010")]
		public enum BloomScreenBlendMode
		{
			[Token(Token = "0x4000094")]
			Screen,
			[Token(Token = "0x4000095")]
			Add
		}

		[Token(Token = "0x2000011")]
		public enum BloomQuality
		{
			[Token(Token = "0x4000097")]
			Cheap,
			[Token(Token = "0x4000098")]
			High
		}

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TweakMode tweakMode;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public BloomScreenBlendMode screenBlendMode;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public HDRBloomMode hdr;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool doHdr;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float sepBlurSpread;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public BloomQuality quality;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float bloomIntensity;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float bloomThreshold;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Color bloomThresholdColor;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int bloomBlurIterations;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public int hollywoodFlareBlurIterations;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float flareRotation;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public LensFlareStyle lensflareMode;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float hollyStretchWidth;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float lensflareIntensity;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float lensflareThreshold;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float lensFlareSaturation;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Color flareColorA;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Color flareColorB;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Color flareColorC;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Color flareColorD;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Texture2D lensFlareVignetteMask;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Shader lensFlareShader;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Material lensFlareMaterial;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Shader screenBlendShader;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Material screenBlend;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public Shader blurAndFlaresShader;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Material blurAndFlaresMaterial;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public Shader brightPassFilterShader;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Material brightPassFilterMaterial;

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x897E44", Offset = "0x897E44", VA = "0x897E44", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x897F30", Offset = "0x897F30", VA = "0x897F30")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x8990A0", Offset = "0x8990A0", VA = "0x8990A0")]
		private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x898F08", Offset = "0x898F08", VA = "0x898F08")]
		private void BlendFlares(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x898C5C", Offset = "0x898C5C", VA = "0x898C5C")]
		private void BrightFilter(float thresh, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x898B88", Offset = "0x898B88", VA = "0x898B88")]
		private void BrightFilter(Color threshColor, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x898D1C", Offset = "0x898D1C", VA = "0x898D1C")]
		private void Vignette(float amount, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x899164", Offset = "0x899164", VA = "0x899164")]
		public Bloom()
		{
		}
	}
	[Token(Token = "0x2000012")]
	public enum LensflareStyle34
	{
		[Token(Token = "0x400009A")]
		Ghosting,
		[Token(Token = "0x400009B")]
		Anamorphic,
		[Token(Token = "0x400009C")]
		Combined
	}
	[Token(Token = "0x2000013")]
	public enum TweakMode34
	{
		[Token(Token = "0x400009E")]
		Basic,
		[Token(Token = "0x400009F")]
		Complex
	}
	[Token(Token = "0x2000014")]
	public enum HDRBloomMode
	{
		[Token(Token = "0x40000A1")]
		Auto,
		[Token(Token = "0x40000A2")]
		On,
		[Token(Token = "0x40000A3")]
		Off
	}
	[Token(Token = "0x2000015")]
	public enum BloomScreenBlendMode
	{
		[Token(Token = "0x40000A5")]
		Screen,
		[Token(Token = "0x40000A6")]
		Add
	}
	[Token(Token = "0x2000016")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Bloom and Glow/BloomAndFlares (3.5, Deprecated)")]
	public class BloomAndFlares : PostEffectsBase
	{
		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TweakMode34 tweakMode;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public BloomScreenBlendMode screenBlendMode;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public HDRBloomMode hdr;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool doHdr;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float sepBlurSpread;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float useSrcAlphaAsMask;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float bloomIntensity;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float bloomThreshold;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public int bloomBlurIterations;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool lensflares;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int hollywoodFlareBlurIterations;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public LensflareStyle34 lensflareMode;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float hollyStretchWidth;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float lensflareIntensity;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float lensflareThreshold;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Color flareColorA;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Color flareColorB;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Color flareColorC;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public Color flareColorD;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Texture2D lensFlareVignetteMask;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Shader lensFlareShader;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Material lensFlareMaterial;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Shader vignetteShader;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Material vignetteMaterial;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Shader separableBlurShader;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Material separableBlurMaterial;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public Shader addBrightStuffOneOneShader;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Material addBrightStuffBlendOneOneMaterial;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public Shader screenBlendShader;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Material screenBlend;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public Shader hollywoodFlaresShader;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Material hollywoodFlaresMaterial;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public Shader brightPassFilterShader;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Material brightPassFilterMaterial;

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x8991F0", Offset = "0x8991F0", VA = "0x8991F0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x89934C", Offset = "0x89934C", VA = "0x89934C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x89A10C", Offset = "0x89A10C", VA = "0x89A10C")]
		private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x899F84", Offset = "0x899F84", VA = "0x899F84")]
		private void BlendFlares(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x899D2C", Offset = "0x899D2C", VA = "0x899D2C")]
		private void BrightFilter(float thresh, float useAlphaAsMask, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x899E34", Offset = "0x899E34", VA = "0x899E34")]
		private void Vignette(float amount, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x89A1BC", Offset = "0x89A1BC", VA = "0x89A1BC")]
		public BloomAndFlares()
		{
		}
	}
	[Token(Token = "0x2000017")]
	[AddComponentMenu("Image Effects/Bloom and Glow/Bloom (Optimized)")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class BloomOptimized : PostEffectsBase
	{
		[Token(Token = "0x2000018")]
		public enum Resolution
		{
			[Token(Token = "0x40000D2")]
			Low,
			[Token(Token = "0x40000D3")]
			High
		}

		[Token(Token = "0x2000019")]
		public enum BlurType
		{
			[Token(Token = "0x40000D5")]
			Standard,
			[Token(Token = "0x40000D6")]
			Sgx
		}

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(0f, 1.5f)]
		public float threshold;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0f, 2.5f)]
		public float intensity;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(0.25f, 5.5f)]
		public float blurSize;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Resolution resolution;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(1f, 4f)]
		public int blurIterations;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public BlurType blurType;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Shader fastBloomShader;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Material fastBloomMaterial;

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x89A230", Offset = "0x89A230", VA = "0x89A230", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x89A2A4", Offset = "0x89A2A4", VA = "0x89A2A4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x89A330", Offset = "0x89A330", VA = "0x89A330")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x89A6A0", Offset = "0x89A6A0", VA = "0x89A6A0")]
		public BloomOptimized()
		{
		}
	}
	[Token(Token = "0x200001A")]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Blur/Blur")]
	public class Blur : MonoBehaviour
	{
		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 10f)]
		public int iterations;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(0f, 1f)]
		public float blurSpread;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Shader blurShader;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Material m_Material;

		[Token(Token = "0x17000012")]
		protected Material material
		{
			[Token(Token = "0x600007D")]
			[Address(RVA = "0x89A6C4", Offset = "0x89A6C4", VA = "0x89A6C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x89A7CC", Offset = "0x89A7CC", VA = "0x89A7CC")]
		protected void OnDisable()
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x89A878", Offset = "0x89A878", VA = "0x89A878")]
		protected void Start()
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x89A928", Offset = "0x89A928", VA = "0x89A928")]
		public void FourTapCone(RenderTexture source, RenderTexture dest, int iteration)
		{
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x89AA38", Offset = "0x89AA38", VA = "0x89AA38")]
		private void DownSample4x(RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x89AB34", Offset = "0x89AB34", VA = "0x89AB34")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x89AC90", Offset = "0x89AC90", VA = "0x89AC90")]
		public Blur()
		{
		}
	}
	[Token(Token = "0x200001B")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Blur/Blur (Optimized)")]
	public class BlurOptimized : PostEffectsBase
	{
		[Token(Token = "0x200001C")]
		public enum BlurType
		{
			[Token(Token = "0x40000E2")]
			StandardGauss,
			[Token(Token = "0x40000E3")]
			SgxGauss
		}

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(0f, 2f)]
		public int downsample;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0f, 10f)]
		public float blurSize;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(1f, 4f)]
		public int blurIterations;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public BlurType blurType;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader blurShader;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material blurMaterial;

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x89ACA8", Offset = "0x89ACA8", VA = "0x89ACA8", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x89AD1C", Offset = "0x89AD1C", VA = "0x89AD1C")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x89ADA8", Offset = "0x89ADA8", VA = "0x89ADA8")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x89B0D0", Offset = "0x89B0D0", VA = "0x89B0D0")]
		public BlurOptimized()
		{
		}
	}
	[Token(Token = "0x200001D")]
	[AddComponentMenu("Image Effects/Camera/Camera Motion Blur")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	public class CameraMotionBlur : PostEffectsBase
	{
		[Token(Token = "0x200001E")]
		public enum MotionBlurFilter
		{
			[Token(Token = "0x4000103")]
			CameraMotion,
			[Token(Token = "0x4000104")]
			LocalBlur,
			[Token(Token = "0x4000105")]
			Reconstruction,
			[Token(Token = "0x4000106")]
			ReconstructionDX11,
			[Token(Token = "0x4000107")]
			ReconstructionDisc
		}

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static float MAX_RADIUS;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MotionBlurFilter filterType;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool preview;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 previewScale;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float movementScale;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float rotationScale;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float maxVelocity;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float minVelocity;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float velocityScale;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float softZDistance;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public int velocityDownsample;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public LayerMask excludeLayers;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GameObject tmpCam;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Shader shader;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Shader dx11MotionBlurShader;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Shader replacementClear;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Material motionBlurMaterial;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Material dx11MotionBlurMaterial;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Texture2D noiseTexture;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float jitter;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public bool showVelocity;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public float showVelocityScale;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Matrix4x4 currentViewProjMat;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Matrix4x4 prevViewProjMat;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private int prevFrameCount;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private bool wasActive;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private Vector3 prevFrameForward;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Vector3 prevFrameUp;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		private Vector3 prevFramePos;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Camera _camera;

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x89B0EC", Offset = "0x89B0EC", VA = "0x89B0EC")]
		private void CalculateViewProjection()
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x89B1F0", Offset = "0x89B1F0", VA = "0x89B1F0")]
		private new void Start()
		{
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x89B374", Offset = "0x89B374", VA = "0x89B374")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x89B434", Offset = "0x89B434", VA = "0x89B434")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x89B598", Offset = "0x89B598", VA = "0x89B598", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x89B64C", Offset = "0x89B64C", VA = "0x89B64C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x89B2D4", Offset = "0x89B2D4", VA = "0x89B2D4")]
		private void Remember()
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x89CDF8", Offset = "0x89CDF8", VA = "0x89CDF8")]
		private Camera GetTmpCam()
		{
			return null;
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x89CD74", Offset = "0x89CD74", VA = "0x89CD74")]
		private void StartFrame()
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x89CDE8", Offset = "0x89CDE8", VA = "0x89CDE8")]
		private static int divRoundUp(int x, int d)
		{
			return default(int);
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x89D18C", Offset = "0x89D18C", VA = "0x89D18C")]
		public CameraMotionBlur()
		{
		}
	}
	[Token(Token = "0x200001F")]
	[AddComponentMenu("Image Effects/Color Adjustments/Color Correction (Curves, Saturation)")]
	[ExecuteInEditMode]
	public class ColorCorrectionCurves : PostEffectsBase
	{
		[Token(Token = "0x2000020")]
		public enum ColorCorrectionMode
		{
			[Token(Token = "0x4000121")]
			Simple,
			[Token(Token = "0x4000122")]
			Advanced
		}

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationCurve redChannel;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve greenChannel;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve blueChannel;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool useDepthCorrection;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AnimationCurve zCurve;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve depthRedChannel;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AnimationCurve depthGreenChannel;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AnimationCurve depthBlueChannel;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Material ccMaterial;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material ccDepthMaterial;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Material selectiveCcMaterial;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Texture2D rgbChannelTex;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Texture2D rgbDepthChannelTex;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Texture2D zCurveTex;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float saturation;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public bool selectiveCc;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Color selectiveFromColor;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Color selectiveToColor;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public ColorCorrectionMode mode;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public bool updateTextures;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public Shader colorCorrectionCurvesShader;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Shader simpleColorCorrectionCurvesShader;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Shader colorCorrectionSelectiveShader;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool updateTexturesOnStartup;

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x89D32C", Offset = "0x89D32C", VA = "0x89D32C")]
		private new void Start()
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x89D34C", Offset = "0x89D34C", VA = "0x89D34C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x89D350", Offset = "0x89D350", VA = "0x89D350", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x89D614", Offset = "0x89D614", VA = "0x89D614")]
		public void UpdateParameters()
		{
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x89D908", Offset = "0x89D908", VA = "0x89D908")]
		private void UpdateTextures()
		{
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x89D90C", Offset = "0x89D90C", VA = "0x89D90C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x89DC18", Offset = "0x89DC18", VA = "0x89DC18")]
		public ColorCorrectionCurves()
		{
		}
	}
	[Token(Token = "0x2000021")]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Color Correction (3D Lookup Texture)")]
	public class ColorCorrectionLookup : PostEffectsBase
	{
		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Shader shader;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Material material;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Texture3D converted3DLut;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string basedOnTempTex;

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x89E2A4", Offset = "0x89E2A4", VA = "0x89E2A4", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x89E314", Offset = "0x89E314", VA = "0x89E314")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x89E3B0", Offset = "0x89E3B0", VA = "0x89E3B0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x89E440", Offset = "0x89E440", VA = "0x89E440")]
		public void SetIdentityLut()
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x89E63C", Offset = "0x89E63C", VA = "0x89E63C")]
		public bool ValidDimensions(Texture2D tex2d)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x89E73C", Offset = "0x89E73C", VA = "0x89E73C")]
		public void Convert(Texture2D temp2DTex, string path)
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x89EA84", Offset = "0x89EA84", VA = "0x89EA84")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x89EC78", Offset = "0x89EC78", VA = "0x89EC78")]
		public ColorCorrectionLookup()
		{
		}
	}
	[Token(Token = "0x2000022")]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Color Correction (Ramp)")]
	public class ColorCorrectionRamp : ImageEffectBase
	{
		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Texture textureRamp;

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x89ECD0", Offset = "0x89ECD0", VA = "0x89ECD0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x89ED8C", Offset = "0x89ED8C", VA = "0x89ED8C")]
		public ColorCorrectionRamp()
		{
		}
	}
	[Token(Token = "0x2000023")]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Color Adjustments/Contrast Enhance (Unsharp Mask)")]
	[ExecuteInEditMode]
	public class ContrastEnhance : PostEffectsBase
	{
		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(0f, 1f)]
		public float intensity;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0f, 0.999f)]
		public float threshold;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Material separableBlurMaterial;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Material contrastCompositeMaterial;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Range(0f, 1f)]
		public float blurSpread;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader separableBlurShader;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Shader contrastCompositeShader;

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x89ED94", Offset = "0x89ED94", VA = "0x89ED94", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x89EE30", Offset = "0x89EE30", VA = "0x89EE30")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x89F15C", Offset = "0x89F15C", VA = "0x89F15C")]
		public ContrastEnhance()
		{
		}
	}
	[Token(Token = "0x2000024")]
	[AddComponentMenu("Image Effects/Color Adjustments/Contrast Stretch")]
	[ExecuteInEditMode]
	public class ContrastStretch : MonoBehaviour
	{
		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0.0001f, 1f)]
		public float adaptationSpeed;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(0f, 1f)]
		public float limitMinimum;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float limitMaximum;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private RenderTexture[] adaptRenderTex;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int curAdaptIndex;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader shaderLum;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material m_materialLum;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader shaderReduce;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material m_materialReduce;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader shaderAdapt;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material m_materialAdapt;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Shader shaderApply;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material m_materialApply;

		[Token(Token = "0x17000013")]
		protected Material materialLum
		{
			[Token(Token = "0x60000A8")]
			[Address(RVA = "0x89F174", Offset = "0x89F174", VA = "0x89F174")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000014")]
		protected Material materialReduce
		{
			[Token(Token = "0x60000A9")]
			[Address(RVA = "0x89F248", Offset = "0x89F248", VA = "0x89F248")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000015")]
		protected Material materialAdapt
		{
			[Token(Token = "0x60000AA")]
			[Address(RVA = "0x89F31C", Offset = "0x89F31C", VA = "0x89F31C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000016")]
		protected Material materialApply
		{
			[Token(Token = "0x60000AB")]
			[Address(RVA = "0x89F3F0", Offset = "0x89F3F0", VA = "0x89F3F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x89F4C4", Offset = "0x89F4C4", VA = "0x89F4C4")]
		private void Start()
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x89F548", Offset = "0x89F548", VA = "0x89F548")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x89F694", Offset = "0x89F694", VA = "0x89F694")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x89F870", Offset = "0x89F870", VA = "0x89F870")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x89FAB0", Offset = "0x89FAB0", VA = "0x89FAB0")]
		private void CalculateAdaptation(Texture curTexture)
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x89FC68", Offset = "0x89FC68", VA = "0x89FC68")]
		public ContrastStretch()
		{
		}
	}
	[Token(Token = "0x2000025")]
	[AddComponentMenu("Image Effects/Edge Detection/Crease Shading")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	public class CreaseShading : PostEffectsBase
	{
		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float intensity;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int softness;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float spread;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader blurShader;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material blurMaterial;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader depthFetchShader;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material depthFetchMaterial;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader creaseApplyShader;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material creaseApplyMaterial;

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x89FCE4", Offset = "0x89FCE4", VA = "0x89FCE4", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x89FDA8", Offset = "0x89FDA8", VA = "0x89FDA8")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x8A0120", Offset = "0x8A0120", VA = "0x8A0120")]
		public CreaseShading()
		{
		}
	}
	[Token(Token = "0x2000026")]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Camera/Depth of Field (Lens Blur, Scatter, DX11)")]
	[ExecuteInEditMode]
	public class DepthOfField : PostEffectsBase
	{
		[Token(Token = "0x2000027")]
		public enum BlurType
		{
			[Token(Token = "0x400015F")]
			DiscBlur,
			[Token(Token = "0x4000160")]
			DX11
		}

		[Token(Token = "0x2000028")]
		public enum BlurSampleCount
		{
			[Token(Token = "0x4000162")]
			Low,
			[Token(Token = "0x4000163")]
			Medium,
			[Token(Token = "0x4000164")]
			High
		}

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool visualizeFocus;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float focalLength;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float focalSize;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float aperture;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform focalTransform;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float maxBlurSize;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool highResolution;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public BlurType blurType;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public BlurSampleCount blurSampleCount;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool nearBlur;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float foregroundOverlap;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader dofHdrShader;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material dofHdrMaterial;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Shader dx11BokehShader;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material dx11bokehMaterial;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float dx11BokehThreshold;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float dx11SpawnHeuristic;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Texture2D dx11BokehTexture;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float dx11BokehScale;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float dx11BokehIntensity;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float focalDistance01;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private ComputeBuffer cbDrawArgs;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private ComputeBuffer cbPoints;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private float internalBlurWidth;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Camera cachedCamera;

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x8A013C", Offset = "0x8A013C", VA = "0x8A013C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x8A033C", Offset = "0x8A033C", VA = "0x8A033C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x8A03BC", Offset = "0x8A03BC", VA = "0x8A03BC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x8A04B4", Offset = "0x8A04B4", VA = "0x8A04B4")]
		private void ReleaseComputeResources()
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x8A01F4", Offset = "0x8A01F4", VA = "0x8A01F4")]
		private void CreateComputeResources()
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x8A050C", Offset = "0x8A050C", VA = "0x8A050C")]
		private float FocalDistance01(float worldDist)
		{
			return default(float);
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x8A05F8", Offset = "0x8A05F8", VA = "0x8A05F8")]
		private void WriteCoc(RenderTexture fromTo, bool fgDilate)
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x8A08C8", Offset = "0x8A08C8", VA = "0x8A08C8")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x8A1BC8", Offset = "0x8A1BC8", VA = "0x8A1BC8")]
		public DepthOfField()
		{
		}
	}
	[Token(Token = "0x2000029")]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Camera/Depth of Field (deprecated)")]
	[RequireComponent(typeof(Camera))]
	public class DepthOfFieldDeprecated : PostEffectsBase
	{
		[Token(Token = "0x200002A")]
		public enum Dof34QualitySetting
		{
			[Token(Token = "0x4000191")]
			OnlyBackground = 1,
			[Token(Token = "0x4000192")]
			BackgroundAndForeground
		}

		[Token(Token = "0x200002B")]
		public enum DofResolution
		{
			[Token(Token = "0x4000194")]
			High = 2,
			[Token(Token = "0x4000195")]
			Medium,
			[Token(Token = "0x4000196")]
			Low
		}

		[Token(Token = "0x200002C")]
		public enum DofBlurriness
		{
			[Token(Token = "0x4000198")]
			Low = 1,
			[Token(Token = "0x4000199")]
			High = 2,
			[Token(Token = "0x400019A")]
			VeryHigh = 4
		}

		[Token(Token = "0x200002D")]
		public enum BokehDestination
		{
			[Token(Token = "0x400019C")]
			Background = 1,
			[Token(Token = "0x400019D")]
			Foreground,
			[Token(Token = "0x400019E")]
			BackgroundAndForeground
		}

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int SMOOTH_DOWNSAMPLE_PASS;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static float BOKEH_EXTRA_BLUR;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Dof34QualitySetting quality;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public DofResolution resolution;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool simpleTweakMode;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float focalPoint;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float smoothness;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float focalZDistance;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float focalZStartCurve;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float focalZEndCurve;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float focalStartCurve;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float focalEndCurve;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float focalDistance01;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform objectFocus;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float focalSize;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public DofBlurriness bluriness;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float maxBlurSpread;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float foregroundBlurExtrude;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Shader dofBlurShader;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Material dofBlurMaterial;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Shader dofShader;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Material dofMaterial;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public bool visualize;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public BokehDestination bokehDestination;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float widthOverHeight;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private float oneOverBaseSize;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool bokeh;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		public bool bokehSupport;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Shader bokehShader;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Texture2D bokehTexture;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float bokehScale;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public float bokehIntensity;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public float bokehThresholdContrast;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float bokehThresholdLuminance;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public int bokehDownsample;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Material bokehMaterial;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Camera _camera;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RenderTexture foregroundTexture;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private RenderTexture mediumRezWorkTexture;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private RenderTexture finalDefocus;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private RenderTexture lowRezWorkTexture;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private RenderTexture bokehSource;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private RenderTexture bokehSource2;

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x8A1C20", Offset = "0x8A1C20", VA = "0x8A1C20")]
		private void CreateMaterials()
		{
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x8A1D2C", Offset = "0x8A1D2C", VA = "0x8A1D2C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x8A1E68", Offset = "0x8A1E68", VA = "0x8A1E68")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x8A1E70", Offset = "0x8A1E70", VA = "0x8A1E70")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x8A1EF0", Offset = "0x8A1EF0", VA = "0x8A1EF0")]
		private float FocalDistance01(float worldDist)
		{
			return default(float);
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x8A1FDC", Offset = "0x8A1FDC", VA = "0x8A1FDC")]
		private int GetDividerBasedOnQuality()
		{
			return default(int);
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x8A2000", Offset = "0x8A2000", VA = "0x8A2000")]
		private int GetLowResolutionDividerBasedOnQuality(int baseDivider)
		{
			return default(int);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x8A2024", Offset = "0x8A2024", VA = "0x8A2024")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x8A2D90", Offset = "0x8A2D90", VA = "0x8A2D90")]
		private void Blur(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x8A3344", Offset = "0x8A3344", VA = "0x8A3344")]
		private void BlurFg(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
		{
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x8A36B8", Offset = "0x8A36B8", VA = "0x8A36B8")]
		private void BlurHex(RenderTexture from, RenderTexture to, int blurPass, float spread, RenderTexture tmp)
		{
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x8A2C68", Offset = "0x8A2C68", VA = "0x8A2C68")]
		private void Downsample(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x8A2F70", Offset = "0x8A2F70", VA = "0x8A2F70")]
		private void AddBokeh(RenderTexture bokehInfo, RenderTexture tempTex, RenderTexture finalTarget)
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x8A3550", Offset = "0x8A3550", VA = "0x8A3550")]
		private void ReleaseTextures()
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x8A28B8", Offset = "0x8A28B8", VA = "0x8A28B8")]
		private void AllocateTextures(bool blurForeground, RenderTexture source, int divider, int lowTexDivider)
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x8A3858", Offset = "0x8A3858", VA = "0x8A3858")]
		public DepthOfFieldDeprecated()
		{
		}
	}
	[Token(Token = "0x200002E")]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Edge Detection/Edge Detection")]
	[ExecuteInEditMode]
	public class EdgeDetection : PostEffectsBase
	{
		[Token(Token = "0x200002F")]
		public enum EdgeDetectMode
		{
			[Token(Token = "0x40001AB")]
			TriangleDepthNormals,
			[Token(Token = "0x40001AC")]
			RobertsCrossDepthNormals,
			[Token(Token = "0x40001AD")]
			SobelDepth,
			[Token(Token = "0x40001AE")]
			SobelDepthThin,
			[Token(Token = "0x40001AF")]
			TriangleLuminance
		}

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EdgeDetectMode mode;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float sensitivityDepth;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float sensitivityNormals;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float lumThreshold;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float edgeExp;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float sampleDist;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float edgesOnly;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Color edgesOnlyBgColor;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader edgeDetectShader;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material edgeDetectMaterial;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private EdgeDetectMode oldMode;

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x8A3920", Offset = "0x8A3920", VA = "0x8A3920", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x8A3A64", Offset = "0x8A3A64", VA = "0x8A3A64")]
		private new void Start()
		{
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x8A39B4", Offset = "0x8A39B4", VA = "0x8A39B4")]
		private void SetCameraFlag()
		{
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x8A3A70", Offset = "0x8A3A70", VA = "0x8A3A70")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x8A3A74", Offset = "0x8A3A74", VA = "0x8A3A74")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x8A3C48", Offset = "0x8A3C48", VA = "0x8A3C48")]
		public EdgeDetection()
		{
		}
	}
	[Token(Token = "0x2000030")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Displacement/Fisheye")]
	public class Fisheye : PostEffectsBase
	{
		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(0f, 1.5f)]
		public float strengthX;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0f, 1.5f)]
		public float strengthY;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Shader fishEyeShader;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Material fisheyeMaterial;

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x8A3C78", Offset = "0x8A3C78", VA = "0x8A3C78", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x8A42F8", Offset = "0x8A42F8", VA = "0x8A42F8")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x8A442C", Offset = "0x8A442C", VA = "0x8A442C")]
		public Fisheye()
		{
		}
	}
	[Token(Token = "0x2000031")]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Rendering/Global Fog")]
	[RequireComponent(typeof(Camera))]
	internal class GlobalFog : PostEffectsBase
	{
		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Apply distance-based fog?")]
		public bool distanceFog;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		[Tooltip("Exclude far plane pixels from distance-based fog? (Skybox or clear color)")]
		public bool excludeFarPixels;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		[Tooltip("Distance fog is based on radial distance from camera when checked")]
		public bool useRadialDistance;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
		[Tooltip("Apply height-based fog?")]
		public bool heightFog;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Fog top Y coordinate")]
		public float height;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(0.001f, 10f)]
		public float heightDensity;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("Push fog away from the camera by this amount")]
		public float startDistance;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader fogShader;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material fogMaterial;

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x8A44D4", Offset = "0x8A44D4", VA = "0x8A44D4", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x8A453C", Offset = "0x8A453C", VA = "0x8A453C")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x8A4E74", Offset = "0x8A4E74", VA = "0x8A4E74")]
		private static void CustomGraphicsBlit(RenderTexture source, RenderTexture dest, Material fxMaterial, int passNr)
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x8A4FD4", Offset = "0x8A4FD4", VA = "0x8A4FD4")]
		public GlobalFog()
		{
		}
	}
	[Token(Token = "0x2000032")]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Grayscale")]
	public class Grayscale : ImageEffectBase
	{
		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Texture textureRamp;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(-1f, 1f)]
		public float rampOffset;

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x8A4FF4", Offset = "0x8A4FF4", VA = "0x8A4FF4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x8A51AC", Offset = "0x8A51AC", VA = "0x8A51AC")]
		public Grayscale()
		{
		}
	}
	[Token(Token = "0x2000033")]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("")]
	public class ImageEffectBase : MonoBehaviour
	{
		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Shader shader;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material m_Material;

		[Token(Token = "0x17000017")]
		protected Material material
		{
			[Token(Token = "0x60000DF")]
			[Address(RVA = "0x8A50D8", Offset = "0x8A50D8", VA = "0x8A50D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x8A51BC", Offset = "0x8A51BC", VA = "0x8A51BC", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x8A525C", Offset = "0x8A525C", VA = "0x8A525C", Slot = "5")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x8A51B4", Offset = "0x8A51B4", VA = "0x8A51B4")]
		public ImageEffectBase()
		{
		}
	}
	[Token(Token = "0x2000034")]
	[AddComponentMenu("")]
	public class ImageEffects
	{
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x8A52E8", Offset = "0x8A52E8", VA = "0x8A52E8")]
		public static void RenderDistortion(Material material, RenderTexture source, RenderTexture destination, float angle, Vector2 center, Vector2 radius)
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x8A5558", Offset = "0x8A5558", VA = "0x8A5558")]
		[Obsolete("Use Graphics.Blit(source,dest) instead")]
		public static void Blit(RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x8A55C0", Offset = "0x8A55C0", VA = "0x8A55C0")]
		[Obsolete("Use Graphics.Blit(source, destination, material) instead")]
		public static void BlitWithMaterial(Material material, RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x8A5630", Offset = "0x8A5630", VA = "0x8A5630")]
		public ImageEffects()
		{
		}
	}
	[Token(Token = "0x2000035")]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Blur/Motion Blur (Color Accumulation)")]
	[ExecuteInEditMode]
	public class MotionBlur : ImageEffectBase
	{
		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(0f, 0.92f)]
		public float blurAmount;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool extraBlur;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private RenderTexture accumTexture;

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x8A5638", Offset = "0x8A5638", VA = "0x8A5638", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x8A566C", Offset = "0x8A566C", VA = "0x8A566C", Slot = "5")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x8A56D0", Offset = "0x8A56D0", VA = "0x8A56D0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x8A5A38", Offset = "0x8A5A38", VA = "0x8A5A38")]
		public MotionBlur()
		{
		}
	}
	[Token(Token = "0x2000036")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Noise/Noise And Grain (Filmic)")]
	public class NoiseAndGrain : PostEffectsBase
	{
		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float intensityMultiplier;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float generalIntensity;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float blackIntensity;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float whiteIntensity;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float midGrey;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool dx11Grain;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float softness;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool monochrome;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 intensities;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 tiling;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float monochromeTiling;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public FilterMode filterMode;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Texture2D noiseTexture;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Shader noiseShader;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Material noiseMaterial;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Shader dx11NoiseShader;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Material dx11NoiseMaterial;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static float TILE_AMOUNT;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Mesh mesh;

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x8A5A4C", Offset = "0x8A5A4C", VA = "0x8A5A4C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x8A5AB4", Offset = "0x8A5AB4", VA = "0x8A5AB4", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x8A5B50", Offset = "0x8A5B50", VA = "0x8A5B50")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x8A6368", Offset = "0x8A6368", VA = "0x8A6368")]
		private static void DrawNoiseQuadGrid(RenderTexture source, RenderTexture dest, Material fxMaterial, Texture2D noise, Mesh mesh, int passNr)
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x8A660C", Offset = "0x8A660C", VA = "0x8A660C")]
		private static void BuildMesh(Mesh mesh, RenderTexture source, Texture2D noise)
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x8A6A4C", Offset = "0x8A6A4C", VA = "0x8A6A4C")]
		private static void BuildMeshUV0(Mesh mesh, int width, int height, float noiseSize, int noiseWidth)
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x8A6BC8", Offset = "0x8A6BC8", VA = "0x8A6BC8")]
		public NoiseAndGrain()
		{
		}
	}
	[Token(Token = "0x2000037")]
	[AddComponentMenu("Image Effects/Noise/Noise and Scratches")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class NoiseAndScratches : MonoBehaviour
	{
		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool monochrome;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool rgbFallback;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(0f, 5f)]
		public float grainIntensityMin;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 5f)]
		public float grainIntensityMax;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Range(0.1f, 50f)]
		public float grainSize;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(0f, 5f)]
		public float scratchIntensityMin;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0f, 5f)]
		public float scratchIntensityMax;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(1f, 30f)]
		public float scratchFPS;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Range(0f, 1f)]
		public float scratchJitter;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Texture grainTexture;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Texture scratchTexture;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader shaderRGB;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Shader shaderYUV;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Material m_MaterialRGB;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material m_MaterialYUV;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float scratchTimeLeft;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float scratchX;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float scratchY;

		[Token(Token = "0x17000018")]
		protected Material material
		{
			[Token(Token = "0x60000F3")]
			[Address(RVA = "0x8A6D7C", Offset = "0x8A6D7C", VA = "0x8A6D7C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x8A6C50", Offset = "0x8A6C50", VA = "0x8A6C50")]
		protected void Start()
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x8A6EE4", Offset = "0x8A6EE4", VA = "0x8A6EE4")]
		protected void OnDisable()
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x8A6FB4", Offset = "0x8A6FB4", VA = "0x8A6FB4")]
		private void SanitizeParameters()
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x8A7058", Offset = "0x8A7058", VA = "0x8A7058")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x8A7380", Offset = "0x8A7380", VA = "0x8A7380")]
		public NoiseAndScratches()
		{
		}
	}
	[Token(Token = "0x2000038")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	public class PostEffectsBase : MonoBehaviour
	{
		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected bool supportHDRTextures;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		protected bool supportDX11;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		protected bool isSupported;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<Material> createdMaterials;

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x8A3DE4", Offset = "0x8A3DE4", VA = "0x8A3DE4")]
		protected Material CheckShaderAndCreateMaterial(Shader s, Material m2Create)
		{
			return null;
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x8A73D4", Offset = "0x8A73D4", VA = "0x8A73D4")]
		protected Material CreateMaterial(Shader s, Material m2Create)
		{
			return null;
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x8A760C", Offset = "0x8A760C", VA = "0x8A760C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x8A7618", Offset = "0x8A7618", VA = "0x8A7618")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x8A761C", Offset = "0x8A761C", VA = "0x8A761C")]
		private void RemoveCreatedMaterials()
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x8A76FC", Offset = "0x8A76FC", VA = "0x8A76FC")]
		protected bool CheckSupport()
		{
			return default(bool);
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x8A7704", Offset = "0x8A7704", VA = "0x8A7704", Slot = "4")]
		public virtual bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x8A77C4", Offset = "0x8A77C4", VA = "0x8A77C4")]
		protected void Start()
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x8A3CE0", Offset = "0x8A3CE0", VA = "0x8A3CE0")]
		protected bool CheckSupport(bool needDepth)
		{
			return default(bool);
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x8A77D0", Offset = "0x8A77D0", VA = "0x8A77D0")]
		protected bool CheckSupport(bool needDepth, bool needHdr)
		{
			return default(bool);
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x8A7828", Offset = "0x8A7828", VA = "0x8A7828")]
		public bool Dx11Support()
		{
			return default(bool);
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x8A4240", Offset = "0x8A4240", VA = "0x8A4240")]
		protected void ReportAutoDisable()
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x8A7830", Offset = "0x8A7830", VA = "0x8A7830")]
		private bool CheckShader(Shader s)
		{
			return default(bool);
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x8A73B4", Offset = "0x8A73B4", VA = "0x8A73B4")]
		protected void NotSupported()
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x8A7AB4", Offset = "0x8A7AB4", VA = "0x8A7AB4")]
		protected void DrawBorder(RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x8A4440", Offset = "0x8A4440", VA = "0x8A4440")]
		public PostEffectsBase()
		{
		}
	}
	[Token(Token = "0x2000039")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	internal class PostEffectsHelper : MonoBehaviour
	{
		[Token(Token = "0x6000108")]
		[Address(RVA = "0x8A7E2C", Offset = "0x8A7E2C", VA = "0x8A7E2C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x8A7E94", Offset = "0x8A7E94", VA = "0x8A7E94")]
		private static void DrawLowLevelPlaneAlignedWithCamera(float dist, RenderTexture source, RenderTexture dest, Material material, Camera cameraForProjectionMatrix)
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x8A80E0", Offset = "0x8A80E0", VA = "0x8A80E0")]
		private static void DrawBorder(RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x8A8454", Offset = "0x8A8454", VA = "0x8A8454")]
		private static void DrawLowLevelQuad(float x1, float x2, float y1, float y2, RenderTexture source, RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x8A85F8", Offset = "0x8A85F8", VA = "0x8A85F8")]
		public PostEffectsHelper()
		{
		}
	}
	[Token(Token = "0x200003A")]
	internal class Quads
	{
		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Mesh[] meshes;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int currentQuads;

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x8A8600", Offset = "0x8A8600", VA = "0x8A8600")]
		private static bool HasMeshes()
		{
			return default(bool);
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x8A86D0", Offset = "0x8A86D0", VA = "0x8A86D0")]
		public static void Cleanup()
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x8A8834", Offset = "0x8A8834", VA = "0x8A8834")]
		public static Mesh[] GetMeshes(int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x8A8A6C", Offset = "0x8A8A6C", VA = "0x8A8A6C")]
		private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x8A8DF0", Offset = "0x8A8DF0", VA = "0x8A8DF0")]
		public Quads()
		{
		}
	}
	[Token(Token = "0x200003B")]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Other/Screen Overlay")]
	[RequireComponent(typeof(Camera))]
	public class ScreenOverlay : PostEffectsBase
	{
		[Token(Token = "0x200003C")]
		public enum OverlayBlendMode
		{
			[Token(Token = "0x40001F5")]
			Additive,
			[Token(Token = "0x40001F6")]
			ScreenBlend,
			[Token(Token = "0x40001F7")]
			Multiply,
			[Token(Token = "0x40001F8")]
			Overlay,
			[Token(Token = "0x40001F9")]
			AlphaBlend
		}

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public OverlayBlendMode blendMode;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float intensity;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Texture2D texture;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader overlayShader;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material overlayMaterial;

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x8A8DF8", Offset = "0x8A8DF8", VA = "0x8A8DF8", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x8A8E60", Offset = "0x8A8E60", VA = "0x8A8E60")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x8A8FB0", Offset = "0x8A8FB0", VA = "0x8A8FB0")]
		public ScreenOverlay()
		{
		}
	}
	[Token(Token = "0x200003D")]
	[AddComponentMenu("Image Effects/Rendering/Screen Space Ambient Obscurance")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	internal class ScreenSpaceAmbientObscurance : PostEffectsBase
	{
		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(0f, 3f)]
		public float intensity;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0.1f, 3f)]
		public float radius;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(0f, 3f)]
		public int blurIterations;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Range(0f, 5f)]
		public float blurFilterDistance;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 1f)]
		public int downsample;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Texture2D rand;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader aoShader;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material aoMaterial;

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x8A8FC0", Offset = "0x8A8FC0", VA = "0x8A8FC0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x8A9028", Offset = "0x8A9028", VA = "0x8A9028")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x8A90B8", Offset = "0x8A90B8", VA = "0x8A90B8")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x8A9668", Offset = "0x8A9668", VA = "0x8A9668")]
		public ScreenSpaceAmbientObscurance()
		{
		}
	}
	[Token(Token = "0x200003E")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Rendering/Screen Space Ambient Occlusion")]
	public class ScreenSpaceAmbientOcclusion : MonoBehaviour
	{
		[Token(Token = "0x200003F")]
		public enum SSAOSamples
		{
			[Token(Token = "0x400020E")]
			Low,
			[Token(Token = "0x400020F")]
			Medium,
			[Token(Token = "0x4000210")]
			High
		}

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0.05f, 1f)]
		public float m_Radius;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public SSAOSamples m_SampleCount;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0.5f, 4f)]
		public float m_OcclusionIntensity;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Range(0f, 4f)]
		public int m_Blur;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(1f, 6f)]
		public int m_Downsampling;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0.2f, 2f)]
		public float m_OcclusionAttenuation;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(1E-05f, 0.5f)]
		public float m_MinZ;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader m_SSAOShader;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material m_SSAOMaterial;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Texture2D m_RandomTexture;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool m_Supported;

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x8A9684", Offset = "0x8A9684", VA = "0x8A9684")]
		private static Material CreateMaterial(Shader shader)
		{
			return null;
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x8A9730", Offset = "0x8A9730", VA = "0x8A9730")]
		private static void DestroyMaterial(Material mat)
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x8A97B4", Offset = "0x8A97B4", VA = "0x8A97B4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x8A97BC", Offset = "0x8A97BC", VA = "0x8A97BC")]
		private void Start()
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x8A995C", Offset = "0x8A995C", VA = "0x8A995C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x8A9884", Offset = "0x8A9884", VA = "0x8A9884")]
		private void CreateMaterials()
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x8A99C8", Offset = "0x8A99C8", VA = "0x8A99C8")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x8A9F9C", Offset = "0x8A9F9C", VA = "0x8A9F9C")]
		public ScreenSpaceAmbientOcclusion()
		{
		}
	}
	[Token(Token = "0x2000040")]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Sepia Tone")]
	public class SepiaTone : ImageEffectBase
	{
		[Token(Token = "0x6000121")]
		[Address(RVA = "0x8A9FD0", Offset = "0x8A9FD0", VA = "0x8A9FD0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x8AA050", Offset = "0x8AA050", VA = "0x8AA050")]
		public SepiaTone()
		{
		}
	}
	[Token(Token = "0x2000041")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Rendering/Sun Shafts")]
	public class SunShafts : PostEffectsBase
	{
		[Token(Token = "0x2000042")]
		public enum SunShaftsResolution
		{
			[Token(Token = "0x4000220")]
			Low,
			[Token(Token = "0x4000221")]
			Normal,
			[Token(Token = "0x4000222")]
			High
		}

		[Token(Token = "0x2000043")]
		public enum ShaftsScreenBlendMode
		{
			[Token(Token = "0x4000224")]
			Screen,
			[Token(Token = "0x4000225")]
			Add
		}

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SunShaftsResolution resolution;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public ShaftsScreenBlendMode screenBlendMode;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform sunTransform;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int radialBlurIterations;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Color sunColor;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Color sunThreshold;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float sunShaftBlurRadius;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float sunShaftIntensity;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float maxRadius;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useDepthTexture;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Shader sunShaftsShader;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Material sunShaftsMaterial;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Shader simpleClearShader;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Material simpleClearMaterial;

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x8AA058", Offset = "0x8AA058", VA = "0x8AA058", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x8AA0E4", Offset = "0x8AA0E4", VA = "0x8AA0E4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x8AA7A0", Offset = "0x8AA7A0", VA = "0x8AA7A0")]
		public SunShafts()
		{
		}
	}
	[Token(Token = "0x2000044")]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Camera/Tilt Shift (Lens Blur)")]
	internal class TiltShift : PostEffectsBase
	{
		[Token(Token = "0x2000045")]
		public enum TiltShiftMode
		{
			[Token(Token = "0x400022E")]
			TiltShiftMode,
			[Token(Token = "0x400022F")]
			IrisMode
		}

		[Token(Token = "0x2000046")]
		public enum TiltShiftQuality
		{
			[Token(Token = "0x4000231")]
			Preview,
			[Token(Token = "0x4000232")]
			Normal,
			[Token(Token = "0x4000233")]
			High
		}

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TiltShiftMode mode;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public TiltShiftQuality quality;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(0f, 15f)]
		public float blurArea;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Range(0f, 25f)]
		public float maxBlurSize;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 1f)]
		public int downsample;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Shader tiltShiftShader;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Material tiltShiftMaterial;

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x8AA7E4", Offset = "0x8AA7E4", VA = "0x8AA7E4", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x8AA84C", Offset = "0x8AA84C", VA = "0x8AA84C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x8AAADC", Offset = "0x8AAADC", VA = "0x8AAADC")]
		public TiltShift()
		{
		}
	}
	[Token(Token = "0x2000047")]
	[AddComponentMenu("Image Effects/Color Adjustments/Tonemapping")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	public class Tonemapping : PostEffectsBase
	{
		[Token(Token = "0x2000048")]
		public enum TonemapperType
		{
			[Token(Token = "0x4000242")]
			SimpleReinhard,
			[Token(Token = "0x4000243")]
			UserCurve,
			[Token(Token = "0x4000244")]
			Hable,
			[Token(Token = "0x4000245")]
			Photographic,
			[Token(Token = "0x4000246")]
			OptimizedHejiDawson,
			[Token(Token = "0x4000247")]
			AdaptiveReinhard,
			[Token(Token = "0x4000248")]
			AdaptiveReinhardAutoWhite
		}

		[Token(Token = "0x2000049")]
		public enum AdaptiveTexSize
		{
			[Token(Token = "0x400024A")]
			Square16 = 0x10,
			[Token(Token = "0x400024B")]
			Square32 = 0x20,
			[Token(Token = "0x400024C")]
			Square64 = 0x40,
			[Token(Token = "0x400024D")]
			Square128 = 0x80,
			[Token(Token = "0x400024E")]
			Square256 = 0x100,
			[Token(Token = "0x400024F")]
			Square512 = 0x200,
			[Token(Token = "0x4000250")]
			Square1024 = 0x400
		}

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TonemapperType type;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public AdaptiveTexSize adaptiveTextureSize;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve remapCurve;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Texture2D curveTex;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float exposureAdjustment;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float middleGrey;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float white;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float adaptionSpeed;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Shader tonemapper;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool validRenderTextureFormat;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material tonemapMaterial;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private RenderTexture rt;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RenderTextureFormat rtFormat;

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x8AAAF4", Offset = "0x8AAAF4", VA = "0x8AAAF4", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x8AAC58", Offset = "0x8AAC58", VA = "0x8AAC58")]
		public float UpdateCurve()
		{
			return default(float);
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x8AAED8", Offset = "0x8AAED8", VA = "0x8AAED8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x8AB030", Offset = "0x8AB030", VA = "0x8AB030")]
		private bool CreateInternalRenderTexture()
		{
			return default(bool);
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x8AB130", Offset = "0x8AB130", VA = "0x8AB130")]
		[ImageEffectTransformsToLDR]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x8AB8D0", Offset = "0x8AB8D0", VA = "0x8AB8D0")]
		public Tonemapping()
		{
		}
	}
	[Token(Token = "0x200004A")]
	internal class Triangles
	{
		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Mesh[] meshes;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int currentTris;

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x8AB8FC", Offset = "0x8AB8FC", VA = "0x8AB8FC")]
		private static bool HasMeshes()
		{
			return default(bool);
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x8AB9D0", Offset = "0x8AB9D0", VA = "0x8AB9D0")]
		private static void Cleanup()
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x8ABB34", Offset = "0x8ABB34", VA = "0x8ABB34")]
		private static Mesh[] GetMeshes(int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x8ABD6C", Offset = "0x8ABD6C", VA = "0x8ABD6C")]
		private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x8AC060", Offset = "0x8AC060", VA = "0x8AC060")]
		public Triangles()
		{
		}
	}
	[Token(Token = "0x200004B")]
	[AddComponentMenu("Image Effects/Displacement/Twirl")]
	[ExecuteInEditMode]
	public class Twirl : ImageEffectBase
	{
		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector2 radius;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(0f, 360f)]
		public float angle;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector2 center;

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x8AC068", Offset = "0x8AC068", VA = "0x8AC068")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x8AC0A0", Offset = "0x8AC0A0", VA = "0x8AC0A0")]
		public Twirl()
		{
		}
	}
	[Token(Token = "0x200004C")]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Camera/Vignette and Chromatic Aberration")]
	[ExecuteInEditMode]
	public class VignetteAndChromaticAberration : PostEffectsBase
	{
		[Token(Token = "0x200004D")]
		public enum AberrationMode
		{
			[Token(Token = "0x4000265")]
			Simple,
			[Token(Token = "0x4000266")]
			Advanced
		}

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AberrationMode mode;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float intensity;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float chromaticAberration;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float axialAberration;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float blur;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float blurSpread;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float luminanceDependency;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float blurDistance;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader vignetteShader;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Shader separableBlurShader;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader chromAberrationShader;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material m_VignetteMaterial;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Material m_SeparableBlurMaterial;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material m_ChromAberrationMaterial;

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x8AC0C8", Offset = "0x8AC0C8", VA = "0x8AC0C8", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x8AC178", Offset = "0x8AC178", VA = "0x8AC178")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x8AC6CC", Offset = "0x8AC6CC", VA = "0x8AC6CC")]
		public VignetteAndChromaticAberration()
		{
		}
	}
	[Token(Token = "0x200004E")]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Displacement/Vortex")]
	public class Vortex : ImageEffectBase
	{
		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector2 radius;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float angle;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector2 center;

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x8AC6F8", Offset = "0x8AC6F8", VA = "0x8AC6F8")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x8AC730", Offset = "0x8AC730", VA = "0x8AC730")]
		public Vortex()
		{
		}
	}
}
namespace SimpleJSON
{
	[Token(Token = "0x200004F")]
	public enum JSONBinaryTag
	{
		[Token(Token = "0x400026B")]
		Array = 1,
		[Token(Token = "0x400026C")]
		Class,
		[Token(Token = "0x400026D")]
		Value,
		[Token(Token = "0x400026E")]
		IntValue,
		[Token(Token = "0x400026F")]
		DoubleValue,
		[Token(Token = "0x4000270")]
		BoolValue,
		[Token(Token = "0x4000271")]
		FloatValue
	}
	[Token(Token = "0x2000050")]
	public class JSONNode
	{
		[Token(Token = "0x2000051")]
		[CompilerGenerated]
		private sealed class <get_Childs>d__17 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000272")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000273")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x4000274")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x17000025")]
			private JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x600016F")]
				[Address(RVA = "0x8AE7A0", Offset = "0x8AE7A0", VA = "0x8AE7A0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000026")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000171")]
				[Address(RVA = "0x8AE7E8", Offset = "0x8AE7E8", VA = "0x8AE7E8", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600016C")]
			[Address(RVA = "0x8AC8A8", Offset = "0x8AC8A8", VA = "0x8AC8A8")]
			[DebuggerHidden]
			public <get_Childs>d__17(int <>1__state)
			{
			}

			[Token(Token = "0x600016D")]
			[Address(RVA = "0x8AE784", Offset = "0x8AE784", VA = "0x8AE784", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600016E")]
			[Address(RVA = "0x8AE788", Offset = "0x8AE788", VA = "0x8AE788", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000170")]
			[Address(RVA = "0x8AE7A8", Offset = "0x8AE7A8", VA = "0x8AE7A8", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000172")]
			[Address(RVA = "0x8AE7F0", Offset = "0x8AE7F0", VA = "0x8AE7F0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000173")]
			[Address(RVA = "0x8AE888", Offset = "0x8AE888", VA = "0x8AE888", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x2000052")]
		[CompilerGenerated]
		private sealed class <get_DeepChilds>d__19 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000275")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000276")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x4000277")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x4000278")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public JSONNode <>4__this;

			[Token(Token = "0x4000279")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private IEnumerator<JSONNode> <>7__wrap1;

			[Token(Token = "0x400027A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private IEnumerator<JSONNode> <>7__wrap2;

			[Token(Token = "0x17000027")]
			private JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x6000179")]
				[Address(RVA = "0x8AEEF4", Offset = "0x8AEEF4", VA = "0x8AEEF4", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000028")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600017B")]
				[Address(RVA = "0x8AEF3C", Offset = "0x8AEF3C", VA = "0x8AEF3C", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000174")]
			[Address(RVA = "0x8AC960", Offset = "0x8AC960", VA = "0x8AC960")]
			[DebuggerHidden]
			public <get_DeepChilds>d__19(int <>1__state)
			{
			}

			[Token(Token = "0x6000175")]
			[Address(RVA = "0x8AE88C", Offset = "0x8AE88C", VA = "0x8AE88C", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000176")]
			[Address(RVA = "0x8AE944", Offset = "0x8AE944", VA = "0x8AE944", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000177")]
			[Address(RVA = "0x8AEE44", Offset = "0x8AEE44", VA = "0x8AEE44")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000178")]
			[Address(RVA = "0x8AED94", Offset = "0x8AED94", VA = "0x8AED94")]
			private void <>m__Finally2()
			{
			}

			[Token(Token = "0x600017A")]
			[Address(RVA = "0x8AEEFC", Offset = "0x8AEEFC", VA = "0x8AEEFC", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600017C")]
			[Address(RVA = "0x8AEF44", Offset = "0x8AEF44", VA = "0x8AEF44", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x600017D")]
			[Address(RVA = "0x8AEFF0", Offset = "0x8AEFF0", VA = "0x8AEFF0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x17000019")]
		public virtual JSONNode this[int aIndex]
		{
			[Token(Token = "0x600013C")]
			[Address(RVA = "0x8AC75C", Offset = "0x8AC75C", VA = "0x8AC75C", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x600013D")]
			[Address(RVA = "0x8AC764", Offset = "0x8AC764", VA = "0x8AC764", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		public virtual JSONNode this[string aKey]
		{
			[Token(Token = "0x600013E")]
			[Address(RVA = "0x8AC768", Offset = "0x8AC768", VA = "0x8AC768", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x600013F")]
			[Address(RVA = "0x8AC770", Offset = "0x8AC770", VA = "0x8AC770", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public virtual string Value
		{
			[Token(Token = "0x6000140")]
			[Address(RVA = "0x8AC774", Offset = "0x8AC774", VA = "0x8AC774", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000141")]
			[Address(RVA = "0x8AC7B4", Offset = "0x8AC7B4", VA = "0x8AC7B4", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public virtual int Count
		{
			[Token(Token = "0x6000142")]
			[Address(RVA = "0x8AC7B8", Offset = "0x8AC7B8", VA = "0x8AC7B8", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700001D")]
		public virtual IEnumerable<JSONNode> Childs
		{
			[Token(Token = "0x6000147")]
			[Address(RVA = "0x8AC838", Offset = "0x8AC838", VA = "0x8AC838", Slot = "16")]
			[IteratorStateMachine(typeof(<get_Childs>d__17))]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001E")]
		public IEnumerable<JSONNode> DeepChilds
		{
			[Token(Token = "0x6000148")]
			[Address(RVA = "0x8AC8DC", Offset = "0x8AC8DC", VA = "0x8AC8DC")]
			[IteratorStateMachine(typeof(<get_DeepChilds>d__19))]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001F")]
		public virtual int AsInt
		{
			[Token(Token = "0x600014B")]
			[Address(RVA = "0x8ACA14", Offset = "0x8ACA14", VA = "0x8ACA14", Slot = "18")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600014C")]
			[Address(RVA = "0x8ACA48", Offset = "0x8ACA48", VA = "0x8ACA48", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x17000020")]
		public virtual float AsFloat
		{
			[Token(Token = "0x600014D")]
			[Address(RVA = "0x8ACA84", Offset = "0x8ACA84", VA = "0x8ACA84", Slot = "20")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600014E")]
			[Address(RVA = "0x8ACABC", Offset = "0x8ACABC", VA = "0x8ACABC", Slot = "21")]
			set
			{
			}
		}

		[Token(Token = "0x17000021")]
		public virtual double AsDouble
		{
			[Token(Token = "0x600014F")]
			[Address(RVA = "0x8ACAF8", Offset = "0x8ACAF8", VA = "0x8ACAF8", Slot = "22")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6000150")]
			[Address(RVA = "0x8ACB30", Offset = "0x8ACB30", VA = "0x8ACB30", Slot = "23")]
			set
			{
			}
		}

		[Token(Token = "0x17000022")]
		public virtual bool AsBool
		{
			[Token(Token = "0x6000151")]
			[Address(RVA = "0x8ACB6C", Offset = "0x8ACB6C", VA = "0x8ACB6C", Slot = "24")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000152")]
			[Address(RVA = "0x8ACC24", Offset = "0x8ACC24", VA = "0x8ACC24", Slot = "25")]
			set
			{
			}
		}

		[Token(Token = "0x17000023")]
		public virtual JSONArray AsArray
		{
			[Token(Token = "0x6000153")]
			[Address(RVA = "0x8ACC9C", Offset = "0x8ACC9C", VA = "0x8ACC9C", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000024")]
		public virtual JSONClass AsObject
		{
			[Token(Token = "0x6000154")]
			[Address(RVA = "0x8ACD14", Offset = "0x8ACD14", VA = "0x8ACD14", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x8AC758", Offset = "0x8AC758", VA = "0x8AC758", Slot = "4")]
		public virtual void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x8AC7C0", Offset = "0x8AC7C0", VA = "0x8AC7C0", Slot = "12")]
		public virtual void Add(JSONNode aItem)
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x8AC820", Offset = "0x8AC820", VA = "0x8AC820", Slot = "13")]
		public virtual JSONNode Remove(string aKey)
		{
			return null;
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x8AC828", Offset = "0x8AC828", VA = "0x8AC828", Slot = "14")]
		public virtual JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x8AC830", Offset = "0x8AC830", VA = "0x8AC830", Slot = "15")]
		public virtual JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x8AC994", Offset = "0x8AC994", VA = "0x8AC994", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x8AC9D4", Offset = "0x8AC9D4", VA = "0x8AC9D4", Slot = "17")]
		public virtual string ToString(string aPrefix)
		{
			return null;
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x8ACD8C", Offset = "0x8ACD8C", VA = "0x8ACD8C")]
		public static implicit operator JSONNode(string s)
		{
			return null;
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x8ACE2C", Offset = "0x8ACE2C", VA = "0x8ACE2C")]
		public static implicit operator string(JSONNode d)
		{
			return null;
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x8ACE68", Offset = "0x8ACE68", VA = "0x8ACE68")]
		public static bool operator ==(JSONNode a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x8ACEF0", Offset = "0x8ACEF0", VA = "0x8ACEF0")]
		public static bool operator !=(JSONNode a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x8ACF08", Offset = "0x8ACF08", VA = "0x8ACF08", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x8ACF14", Offset = "0x8ACF14", VA = "0x8ACF14", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x8ACF1C", Offset = "0x8ACF1C", VA = "0x8ACF1C")]
		internal static string Escape(string aText)
		{
			return null;
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x8AD0E8", Offset = "0x8AD0E8", VA = "0x8AD0E8")]
		public static JSONNode Parse(string aJSON)
		{
			return null;
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x8AD914", Offset = "0x8AD914", VA = "0x8AD914", Slot = "28")]
		public virtual void Serialize(BinaryWriter aWriter)
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x8AD918", Offset = "0x8AD918", VA = "0x8AD918")]
		public void SaveToStream(Stream aData)
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x8AD998", Offset = "0x8AD998", VA = "0x8AD998")]
		public void SaveToCompressedStream(Stream aData)
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x8AD9E8", Offset = "0x8AD9E8", VA = "0x8AD9E8")]
		public void SaveToCompressedFile(string aFileName)
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x8ADA38", Offset = "0x8ADA38", VA = "0x8ADA38")]
		public string SaveToCompressedBase64()
		{
			return null;
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x8ADA88", Offset = "0x8ADA88", VA = "0x8ADA88")]
		public void SaveToFile(string aFileName)
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x8ADC58", Offset = "0x8ADC58", VA = "0x8ADC58")]
		public string SaveToBase64()
		{
			return null;
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x8ADE54", Offset = "0x8ADE54", VA = "0x8ADE54")]
		public static JSONNode Deserialize(BinaryReader aReader)
		{
			return null;
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x8AE2CC", Offset = "0x8AE2CC", VA = "0x8AE2CC")]
		public static JSONNode LoadFromCompressedFile(string aFileName)
		{
			return null;
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x8AE31C", Offset = "0x8AE31C", VA = "0x8AE31C")]
		public static JSONNode LoadFromCompressedStream(Stream aData)
		{
			return null;
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x8AE36C", Offset = "0x8AE36C", VA = "0x8AE36C")]
		public static JSONNode LoadFromCompressedBase64(string aBase64)
		{
			return null;
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x8AE3BC", Offset = "0x8AE3BC", VA = "0x8AE3BC")]
		public static JSONNode LoadFromStream(Stream aData)
		{
			return null;
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x8AE550", Offset = "0x8AE550", VA = "0x8AE550")]
		public static JSONNode LoadFromFile(string aFileName)
		{
			return null;
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x8AE6CC", Offset = "0x8AE6CC", VA = "0x8AE6CC")]
		public static JSONNode LoadFromBase64(string aBase64)
		{
			return null;
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x8AE77C", Offset = "0x8AE77C", VA = "0x8AE77C")]
		public JSONNode()
		{
		}
	}
	[Token(Token = "0x2000053")]
	public class JSONArray : JSONNode, IEnumerable
	{
		[Token(Token = "0x2000054")]
		[CompilerGenerated]
		private sealed class <get_Childs>d__13 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400027C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400027D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x400027E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x400027F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public JSONArray <>4__this;

			[Token(Token = "0x4000280")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private List<JSONNode>.Enumerator <>7__wrap1;

			[Token(Token = "0x1700002D")]
			private JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x6000190")]
				[Address(RVA = "0x8AFDEC", Offset = "0x8AFDEC", VA = "0x8AFDEC", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700002E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000192")]
				[Address(RVA = "0x8AFE34", Offset = "0x8AFE34", VA = "0x8AFE34", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600018C")]
			[Address(RVA = "0x8AF594", Offset = "0x8AF594", VA = "0x8AF594")]
			[DebuggerHidden]
			public <get_Childs>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x600018D")]
			[Address(RVA = "0x8AFBD8", Offset = "0x8AFBD8", VA = "0x8AFBD8", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600018E")]
			[Address(RVA = "0x8AFBF4", Offset = "0x8AFBF4", VA = "0x8AFBF4", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600018F")]
			[Address(RVA = "0x8AFD9C", Offset = "0x8AFD9C", VA = "0x8AFD9C")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000191")]
			[Address(RVA = "0x8AFDF4", Offset = "0x8AFDF4", VA = "0x8AFDF4", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000193")]
			[Address(RVA = "0x8AFE3C", Offset = "0x8AFE3C", VA = "0x8AFE3C", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000194")]
			[Address(RVA = "0x8AFEE8", Offset = "0x8AFEE8", VA = "0x8AFEE8", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x2000055")]
		[CompilerGenerated]
		private sealed class <GetEnumerator>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000281")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000282")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000283")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public JSONArray <>4__this;

			[Token(Token = "0x4000284")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private List<JSONNode>.Enumerator <>7__wrap1;

			[Token(Token = "0x1700002F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000199")]
				[Address(RVA = "0x8B0100", Offset = "0x8B0100", VA = "0x8B0100", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000030")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600019B")]
				[Address(RVA = "0x8B0148", Offset = "0x8B0148", VA = "0x8B0148", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000195")]
			[Address(RVA = "0x8AF63C", Offset = "0x8AF63C", VA = "0x8AF63C")]
			[DebuggerHidden]
			public <GetEnumerator>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x6000196")]
			[Address(RVA = "0x8AFEEC", Offset = "0x8AFEEC", VA = "0x8AFEEC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000197")]
			[Address(RVA = "0x8AFF08", Offset = "0x8AFF08", VA = "0x8AFF08", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000198")]
			[Address(RVA = "0x8B00B0", Offset = "0x8B00B0", VA = "0x8B00B0")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x600019A")]
			[Address(RVA = "0x8B0108", Offset = "0x8B0108", VA = "0x8B0108", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<JSONNode> m_List;

		[Token(Token = "0x17000029")]
		public override JSONNode this[int aIndex]
		{
			[Token(Token = "0x600017E")]
			[Address(RVA = "0x8AEFF4", Offset = "0x8AEFF4", VA = "0x8AEFF4", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x600017F")]
			[Address(RVA = "0x8AF0E4", Offset = "0x8AF0E4", VA = "0x8AF0E4", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public override JSONNode this[string aKey]
		{
			[Token(Token = "0x6000180")]
			[Address(RVA = "0x8AF1F4", Offset = "0x8AF1F4", VA = "0x8AF1F4", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000181")]
			[Address(RVA = "0x8AF254", Offset = "0x8AF254", VA = "0x8AF254", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public override int Count
		{
			[Token(Token = "0x6000182")]
			[Address(RVA = "0x8AF304", Offset = "0x8AF304", VA = "0x8AF304", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700002C")]
		public override IEnumerable<JSONNode> Childs
		{
			[Token(Token = "0x6000186")]
			[Address(RVA = "0x8AF510", Offset = "0x8AF510", VA = "0x8AF510", Slot = "16")]
			[IteratorStateMachine(typeof(<get_Childs>d__13))]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x8AF34C", Offset = "0x8AF34C", VA = "0x8AF34C", Slot = "4")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x8AF3FC", Offset = "0x8AF3FC", VA = "0x8AF3FC", Slot = "14")]
		public override JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x8AF4B0", Offset = "0x8AF4B0", VA = "0x8AF4B0", Slot = "15")]
		public override JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x8AF5C8", Offset = "0x8AF5C8", VA = "0x8AF5C8", Slot = "29")]
		[IteratorStateMachine(typeof(<GetEnumerator>d__14))]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x8AF664", Offset = "0x8AF664", VA = "0x8AF664", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x8AF87C", Offset = "0x8AF87C", VA = "0x8AF87C", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x8AFAFC", Offset = "0x8AFAFC", VA = "0x8AFAFC", Slot = "28")]
		public override void Serialize(BinaryWriter aWriter)
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x8AD88C", Offset = "0x8AD88C", VA = "0x8AD88C")]
		public JSONArray()
		{
		}
	}
	[Token(Token = "0x2000056")]
	public class JSONClass : JSONNode, IEnumerable
	{
		[Token(Token = "0x2000058")]
		[CompilerGenerated]
		private sealed class <get_Childs>d__14 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000287")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000288")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x4000289")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x400028A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public JSONClass <>4__this;

			[Token(Token = "0x400028B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Dictionary<string, JSONNode>.Enumerator <>7__wrap1;

			[Token(Token = "0x17000035")]
			private JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x60001B1")]
				[Address(RVA = "0x8B1864", Offset = "0x8B1864", VA = "0x8B1864", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000036")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001B3")]
				[Address(RVA = "0x8B18AC", Offset = "0x8B18AC", VA = "0x8B18AC", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001AD")]
			[Address(RVA = "0x8B0A00", Offset = "0x8B0A00", VA = "0x8B0A00")]
			[DebuggerHidden]
			public <get_Childs>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x60001AE")]
			[Address(RVA = "0x8B163C", Offset = "0x8B163C", VA = "0x8B163C", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001AF")]
			[Address(RVA = "0x8B1658", Offset = "0x8B1658", VA = "0x8B1658", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001B0")]
			[Address(RVA = "0x8B1814", Offset = "0x8B1814", VA = "0x8B1814")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60001B2")]
			[Address(RVA = "0x8B186C", Offset = "0x8B186C", VA = "0x8B186C", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60001B4")]
			[Address(RVA = "0x8B18B4", Offset = "0x8B18B4", VA = "0x8B18B4", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60001B5")]
			[Address(RVA = "0x8B1960", Offset = "0x8B1960", VA = "0x8B1960", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x2000059")]
		[CompilerGenerated]
		private sealed class <GetEnumerator>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400028C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400028D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400028E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public JSONClass <>4__this;

			[Token(Token = "0x400028F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Dictionary<string, JSONNode>.Enumerator <>7__wrap1;

			[Token(Token = "0x17000037")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001BA")]
				[Address(RVA = "0x8B1BB4", Offset = "0x8B1BB4", VA = "0x8B1BB4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000038")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001BC")]
				[Address(RVA = "0x8B1BFC", Offset = "0x8B1BFC", VA = "0x8B1BFC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001B6")]
			[Address(RVA = "0x8B0AA8", Offset = "0x8B0AA8", VA = "0x8B0AA8")]
			[DebuggerHidden]
			public <GetEnumerator>d__15(int <>1__state)
			{
			}

			[Token(Token = "0x60001B7")]
			[Address(RVA = "0x8B1964", Offset = "0x8B1964", VA = "0x8B1964", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001B8")]
			[Address(RVA = "0x8B1980", Offset = "0x8B1980", VA = "0x8B1980", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001B9")]
			[Address(RVA = "0x8B1B64", Offset = "0x8B1B64", VA = "0x8B1B64")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60001BB")]
			[Address(RVA = "0x8B1BBC", Offset = "0x8B1BBC", VA = "0x8B1BBC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Dictionary<string, JSONNode> m_Dict;

		[Token(Token = "0x17000031")]
		public override JSONNode this[string aKey]
		{
			[Token(Token = "0x600019C")]
			[Address(RVA = "0x8B0150", Offset = "0x8B0150", VA = "0x8B0150", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x600019D")]
			[Address(RVA = "0x8B0258", Offset = "0x8B0258", VA = "0x8B0258", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x17000032")]
		public override JSONNode this[int aIndex]
		{
			[Token(Token = "0x600019E")]
			[Address(RVA = "0x8B0324", Offset = "0x8B0324", VA = "0x8B0324", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x600019F")]
			[Address(RVA = "0x8B03C4", Offset = "0x8B03C4", VA = "0x8B03C4", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x17000033")]
		public override int Count
		{
			[Token(Token = "0x60001A0")]
			[Address(RVA = "0x8B04A0", Offset = "0x8B04A0", VA = "0x8B04A0", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000034")]
		public override IEnumerable<JSONNode> Childs
		{
			[Token(Token = "0x60001A5")]
			[Address(RVA = "0x8B097C", Offset = "0x8B097C", VA = "0x8B097C", Slot = "16")]
			[IteratorStateMachine(typeof(<get_Childs>d__14))]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x8B04F0", Offset = "0x8B04F0", VA = "0x8B04F0", Slot = "4")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x8B0604", Offset = "0x8B0604", VA = "0x8B0604", Slot = "13")]
		public override JSONNode Remove(string aKey)
		{
			return null;
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x8B06C8", Offset = "0x8B06C8", VA = "0x8B06C8", Slot = "14")]
		public override JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x8B07A4", Offset = "0x8B07A4", VA = "0x8B07A4", Slot = "15")]
		public override JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x8B0A34", Offset = "0x8B0A34", VA = "0x8B0A34", Slot = "29")]
		[IteratorStateMachine(typeof(<GetEnumerator>d__15))]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x8B0AD0", Offset = "0x8B0AD0", VA = "0x8B0AD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x8B0F14", Offset = "0x8B0F14", VA = "0x8B0F14", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x8B13D8", Offset = "0x8B13D8", VA = "0x8B13D8", Slot = "28")]
		public override void Serialize(BinaryWriter aWriter)
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x8AD804", Offset = "0x8AD804", VA = "0x8AD804")]
		public JSONClass()
		{
		}
	}
	[Token(Token = "0x200005A")]
	public class JSONData : JSONNode
	{
		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string m_Data;

		[Token(Token = "0x17000039")]
		public override string Value
		{
			[Token(Token = "0x60001BD")]
			[Address(RVA = "0x8B1C04", Offset = "0x8B1C04", VA = "0x8B1C04", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001BE")]
			[Address(RVA = "0x8B1C0C", Offset = "0x8B1C0C", VA = "0x8B1C0C", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x8ACDFC", Offset = "0x8ACDFC", VA = "0x8ACDFC")]
		public JSONData(string aData)
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x8AE294", Offset = "0x8AE294", VA = "0x8AE294")]
		public JSONData(float aData)
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x8AE224", Offset = "0x8AE224", VA = "0x8AE224")]
		public JSONData(double aData)
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x8AE25C", Offset = "0x8AE25C", VA = "0x8AE25C")]
		public JSONData(bool aData)
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x8AE1EC", Offset = "0x8AE1EC", VA = "0x8AE1EC")]
		public JSONData(int aData)
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x8B1C14", Offset = "0x8B1C14", VA = "0x8B1C14", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x8B1C6C", Offset = "0x8B1C6C", VA = "0x8B1C6C", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x8B1CC4", Offset = "0x8B1CC4", VA = "0x8B1CC4", Slot = "28")]
		public override void Serialize(BinaryWriter aWriter)
		{
		}
	}
	[Token(Token = "0x200005B")]
	internal class JSONLazyCreator : JSONNode
	{
		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private JSONNode m_Node;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string m_Key;

		[Token(Token = "0x1700003A")]
		public override JSONNode this[int aIndex]
		{
			[Token(Token = "0x60001CA")]
			[Address(RVA = "0x8B1FF4", Offset = "0x8B1FF4", VA = "0x8B1FF4", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001CB")]
			[Address(RVA = "0x8B2054", Offset = "0x8B2054", VA = "0x8B2054", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x1700003B")]
		public override JSONNode this[string aKey]
		{
			[Token(Token = "0x60001CC")]
			[Address(RVA = "0x8B20D4", Offset = "0x8B20D4", VA = "0x8B20D4", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001CD")]
			[Address(RVA = "0x8B2144", Offset = "0x8B2144", VA = "0x8B2144", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x1700003C")]
		public override int AsInt
		{
			[Token(Token = "0x60001D6")]
			[Address(RVA = "0x8B23A4", Offset = "0x8B23A4", VA = "0x8B23A4", Slot = "18")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001D7")]
			[Address(RVA = "0x8B2428", Offset = "0x8B2428", VA = "0x8B2428", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x1700003D")]
		public override float AsFloat
		{
			[Token(Token = "0x60001D8")]
			[Address(RVA = "0x8B24B0", Offset = "0x8B24B0", VA = "0x8B24B0", Slot = "20")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001D9")]
			[Address(RVA = "0x8B2534", Offset = "0x8B2534", VA = "0x8B2534", Slot = "21")]
			set
			{
			}
		}

		[Token(Token = "0x1700003E")]
		public override double AsDouble
		{
			[Token(Token = "0x60001DA")]
			[Address(RVA = "0x8B25BC", Offset = "0x8B25BC", VA = "0x8B25BC", Slot = "22")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x60001DB")]
			[Address(RVA = "0x8B2640", Offset = "0x8B2640", VA = "0x8B2640", Slot = "23")]
			set
			{
			}
		}

		[Token(Token = "0x1700003F")]
		public override bool AsBool
		{
			[Token(Token = "0x60001DC")]
			[Address(RVA = "0x8B26C8", Offset = "0x8B26C8", VA = "0x8B26C8", Slot = "24")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001DD")]
			[Address(RVA = "0x8B274C", Offset = "0x8B274C", VA = "0x8B274C", Slot = "25")]
			set
			{
			}
		}

		[Token(Token = "0x17000040")]
		public override JSONArray AsArray
		{
			[Token(Token = "0x60001DE")]
			[Address(RVA = "0x8B27D4", Offset = "0x8B27D4", VA = "0x8B27D4", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000041")]
		public override JSONClass AsObject
		{
			[Token(Token = "0x60001DF")]
			[Address(RVA = "0x8B283C", Offset = "0x8B283C", VA = "0x8B283C", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x8AF0A4", Offset = "0x8AF0A4", VA = "0x8AF0A4")]
		public JSONLazyCreator(JSONNode aNode)
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x8B0214", Offset = "0x8B0214", VA = "0x8B0214")]
		public JSONLazyCreator(JSONNode aNode, string aKey)
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x8B1F94", Offset = "0x8B1F94", VA = "0x8B1F94")]
		private void Set(JSONNode aVal)
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x8B21CC", Offset = "0x8B21CC", VA = "0x8B21CC", Slot = "12")]
		public override void Add(JSONNode aItem)
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x8B224C", Offset = "0x8B224C", VA = "0x8B224C", Slot = "4")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x8B22D4", Offset = "0x8B22D4", VA = "0x8B22D4")]
		public static bool operator ==(JSONLazyCreator a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x8B22EC", Offset = "0x8B22EC", VA = "0x8B22EC")]
		public static bool operator !=(JSONLazyCreator a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x8B2304", Offset = "0x8B2304", VA = "0x8B2304", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x8B231C", Offset = "0x8B231C", VA = "0x8B231C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x8B2324", Offset = "0x8B2324", VA = "0x8B2324", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x8B2364", Offset = "0x8B2364", VA = "0x8B2364", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}
	}
	[Token(Token = "0x200005C")]
	public static class JSON
	{
		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x8B28A4", Offset = "0x8B28A4", VA = "0x8B28A4")]
		public static JSONNode Parse(string aJSON)
		{
			return null;
		}
	}
}
namespace RootMotion
{
	[Token(Token = "0x200005D")]
	public class CameraController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200005E")]
		public enum UpdateMode
		{
			[Token(Token = "0x40002B1")]
			Update,
			[Token(Token = "0x40002B2")]
			FixedUpdate,
			[Token(Token = "0x40002B3")]
			LateUpdate
		}

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rotationSpace;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateMode updateMode;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool lockCursor;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		public bool smoothFollow;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float followSpeed;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float distance;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float minDistance;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float maxDistance;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float zoomSpeed;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float zoomSensitivity;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float rotationSensitivity;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float yMinLimit;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float yMaxLimit;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 offset;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool rotateAlways;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		public bool rotateOnLeftButton;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		public bool rotateOnRightButton;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		public bool rotateOnMiddleButton;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3 targetDistance;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Vector3 position;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion rotation;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 smoothPosition;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Camera cam;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion r;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Vector3 lastUp;

		[Token(Token = "0x17000042")]
		public float x
		{
			[Token(Token = "0x60001E1")]
			[Address(RVA = "0x8B28A8", Offset = "0x8B28A8", VA = "0x8B28A8")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001E2")]
			[Address(RVA = "0x8B28B0", Offset = "0x8B28B0", VA = "0x8B28B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public float y
		{
			[Token(Token = "0x60001E3")]
			[Address(RVA = "0x8B28B8", Offset = "0x8B28B8", VA = "0x8B28B8")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001E4")]
			[Address(RVA = "0x8B28C0", Offset = "0x8B28C0", VA = "0x8B28C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000044")]
		public float distanceTarget
		{
			[Token(Token = "0x60001E5")]
			[Address(RVA = "0x8B28C8", Offset = "0x8B28C8", VA = "0x8B28C8")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001E6")]
			[Address(RVA = "0x8B28D0", Offset = "0x8B28D0", VA = "0x8B28D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000045")]
		private float zoomAdd
		{
			[Token(Token = "0x60001EE")]
			[Address(RVA = "0x8B2CC0", Offset = "0x8B2CC0", VA = "0x8B2CC0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x8B28D8", Offset = "0x8B28D8", VA = "0x8B28D8", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x8B2A10", Offset = "0x8B2A10", VA = "0x8B2A10", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x8B2A58", Offset = "0x8B2A58", VA = "0x8B2A58", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x8B2A88", Offset = "0x8B2A88", VA = "0x8B2A88", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x8B2ABC", Offset = "0x8B2ABC", VA = "0x8B2ABC")]
		public void UpdateInput()
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x8B2A3C", Offset = "0x8B2A3C", VA = "0x8B2A3C")]
		public void UpdateTransform()
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x8B2D2C", Offset = "0x8B2D2C", VA = "0x8B2D2C")]
		public void UpdateTransform(float deltaTime)
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x8B2C84", Offset = "0x8B2C84", VA = "0x8B2C84")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x8B3200", Offset = "0x8B3200", VA = "0x8B3200")]
		public CameraController()
		{
		}
	}
	[Token(Token = "0x200005F")]
	public class CameraControllerFPS : MonoBehaviour
	{
		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotationSensitivity;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float yMinLimit;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float yMaxLimit;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float x;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float y;

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x8B3294", Offset = "0x8B3294", VA = "0x8B3294")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x8B32C0", Offset = "0x8B32C0", VA = "0x8B32C0")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x8B34E4", Offset = "0x8B34E4", VA = "0x8B34E4")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x8B3520", Offset = "0x8B3520", VA = "0x8B3520")]
		public CameraControllerFPS()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000060")]
	public enum Axis
	{
		[Token(Token = "0x40002BA")]
		X,
		[Token(Token = "0x40002BB")]
		Y,
		[Token(Token = "0x40002BC")]
		Z
	}
	[Token(Token = "0x2000061")]
	public class AxisTools
	{
		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x8B353C", Offset = "0x8B353C", VA = "0x8B353C")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x8B361C", Offset = "0x8B361C", VA = "0x8B361C")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x8B3654", Offset = "0x8B3654", VA = "0x8B3654")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x8B379C", Offset = "0x8B379C", VA = "0x8B379C")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x8B3750", Offset = "0x8B3750", VA = "0x8B3750")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x8B3898", Offset = "0x8B3898", VA = "0x8B3898")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x8B3CC0", Offset = "0x8B3CC0", VA = "0x8B3CC0")]
		public AxisTools()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000062")]
	public class BipedLimbOrientations
	{
		[Serializable]
		[Token(Token = "0x2000063")]
		public class LimbOrientation
		{
			[Token(Token = "0x40002C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 upperBoneForwardAxis;

			[Token(Token = "0x40002C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 lowerBoneForwardAxis;

			[Token(Token = "0x40002C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 lastBoneLeftAxis;

			[Token(Token = "0x60001FF")]
			[Address(RVA = "0x8B3FF4", Offset = "0x8B3FF4", VA = "0x8B3FF4")]
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis)
			{
			}
		}

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LimbOrientation leftArm;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbOrientation rightArm;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbOrientation leftLeg;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LimbOrientation rightLeg;

		[Token(Token = "0x17000046")]
		public static BipedLimbOrientations UMA
		{
			[Token(Token = "0x60001FD")]
			[Address(RVA = "0x8B3D3C", Offset = "0x8B3D3C", VA = "0x8B3D3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000047")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x60001FE")]
			[Address(RVA = "0x8B4068", Offset = "0x8B4068", VA = "0x8B4068")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x8B3CC8", Offset = "0x8B3CC8", VA = "0x8B3CC8")]
		public BipedLimbOrientations(LimbOrientation leftArm, LimbOrientation rightArm, LimbOrientation leftLeg, LimbOrientation rightLeg)
		{
		}
	}
	[Token(Token = "0x2000064")]
	public static class BipedNaming
	{
		[Serializable]
		[Token(Token = "0x2000065")]
		public enum BoneType
		{
			[Token(Token = "0x40002D7")]
			Unassigned,
			[Token(Token = "0x40002D8")]
			Spine,
			[Token(Token = "0x40002D9")]
			Head,
			[Token(Token = "0x40002DA")]
			Arm,
			[Token(Token = "0x40002DB")]
			Leg,
			[Token(Token = "0x40002DC")]
			Tail,
			[Token(Token = "0x40002DD")]
			Eye
		}

		[Serializable]
		[Token(Token = "0x2000066")]
		public enum BoneSide
		{
			[Token(Token = "0x40002DF")]
			Center,
			[Token(Token = "0x40002E0")]
			Left,
			[Token(Token = "0x40002E1")]
			Right
		}

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeLeft;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string[] typeRight;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string[] typeSpine;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string[] typeHead;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string[] typeArm;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static string[] typeLeg;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static string[] typeTail;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static string[] typeEye;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static string[] typeExclude;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static string[] typeExcludeSpine;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static string[] typeExcludeHead;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static string[] typeExcludeArm;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static string[] typeExcludeLeg;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static string[] typeExcludeTail;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static string[] typeExcludeEye;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static string[] pelvis;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static string[] hand;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static string[] foot;

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x8B4320", Offset = "0x8B4320", VA = "0x8B4320")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x8B45EC", Offset = "0x8B45EC", VA = "0x8B45EC")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x8B4828", Offset = "0x8B4828", VA = "0x8B4828")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x8B489C", Offset = "0x8B489C", VA = "0x8B489C")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x8B4930", Offset = "0x8B4930", VA = "0x8B4930")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x8B44D4", Offset = "0x8B44D4", VA = "0x8B44D4")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x8B47A0", Offset = "0x8B47A0", VA = "0x8B47A0")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x8B5068", Offset = "0x8B5068", VA = "0x8B5068")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x8B4EC0", Offset = "0x8B4EC0", VA = "0x8B4EC0")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x8B4F94", Offset = "0x8B4F94", VA = "0x8B4F94")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x8B4B18", Offset = "0x8B4B18", VA = "0x8B4B18")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x8B4BB4", Offset = "0x8B4BB4", VA = "0x8B4BB4")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x8B4C50", Offset = "0x8B4C50", VA = "0x8B4C50")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x8B4CEC", Offset = "0x8B4CEC", VA = "0x8B4CEC")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x8B4D88", Offset = "0x8B4D88", VA = "0x8B4D88")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x8B4E24", Offset = "0x8B4E24", VA = "0x8B4E24")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x8B5250", Offset = "0x8B5250", VA = "0x8B5250")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x8B4A44", Offset = "0x8B4A44", VA = "0x8B4A44")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x8B51CC", Offset = "0x8B51CC", VA = "0x8B51CC")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x8B52B0", Offset = "0x8B52B0", VA = "0x8B52B0")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x8B5370", Offset = "0x8B5370", VA = "0x8B5370")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x8B5158", Offset = "0x8B5158", VA = "0x8B5158")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x8B50E8", Offset = "0x8B50E8", VA = "0x8B50E8")]
		private static string lastLetter(string boneName)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000067")]
	public class BipedReferences
	{
		[Token(Token = "0x2000068")]
		public struct AutoDetectParams
		{
			[Token(Token = "0x40002F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool legsParentInSpine;

			[Token(Token = "0x40002F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool includeEyes;

			[Token(Token = "0x1700004A")]
			public static AutoDetectParams Default
			{
				[Token(Token = "0x6000231")]
				[Address(RVA = "0x8BB648", Offset = "0x8BB648", VA = "0x8BB648")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x6000230")]
			[Address(RVA = "0x8BB634", Offset = "0x8BB634", VA = "0x8BB634")]
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes)
			{
			}
		}

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform root;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform pelvis;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform leftThigh;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftCalf;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftFoot;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform rightThigh;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform rightCalf;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform rightFoot;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform leftUpperArm;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftForearm;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform leftHand;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform rightUpperArm;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform rightForearm;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform rightHand;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform head;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] spine;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform[] eyes;

		[Token(Token = "0x17000048")]
		public virtual bool isFilled
		{
			[Token(Token = "0x6000218")]
			[Address(RVA = "0x8B8160", Offset = "0x8B8160", VA = "0x8B8160", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000049")]
		public bool isEmpty
		{
			[Token(Token = "0x6000219")]
			[Address(RVA = "0x8B84BC", Offset = "0x8B84BC", VA = "0x8B84BC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x8B84CC", Offset = "0x8B84CC", VA = "0x8B84CC", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x8B8858", Offset = "0x8B8858", VA = "0x8B8858", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x8B8BE8", Offset = "0x8B8BE8", VA = "0x8B8BE8")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x8B9314", Offset = "0x8B9314", VA = "0x8B9314")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x8B8E84", Offset = "0x8B8E84", VA = "0x8B8E84")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x8B9AF4", Offset = "0x8B9AF4", VA = "0x8B9AF4")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x8B9BE0", Offset = "0x8B9BE0", VA = "0x8B9BE0")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x8BA12C", Offset = "0x8BA12C", VA = "0x8BA12C")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x8B9F34", Offset = "0x8B9F34", VA = "0x8B9F34")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x8B9DE0", Offset = "0x8B9DE0", VA = "0x8B9DE0")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x8B9C7C", Offset = "0x8B9C7C", VA = "0x8B9C7C")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x8BA02C", Offset = "0x8BA02C", VA = "0x8BA02C")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x8BA210", Offset = "0x8BA210", VA = "0x8BA210")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x8BADCC", Offset = "0x8BADCC", VA = "0x8BADCC")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x8BA868", Offset = "0x8BA868", VA = "0x8BA868")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x8BB118", Offset = "0x8BB118", VA = "0x8BB118")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x8BABD0", Offset = "0x8BABD0", VA = "0x8BABD0")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x8BB120", Offset = "0x8BB120", VA = "0x8BB120")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x8BB128", Offset = "0x8BB128", VA = "0x8BB128")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x8BB2E8", Offset = "0x8BB2E8", VA = "0x8BB2E8")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x8BB5CC", Offset = "0x8BB5CC", VA = "0x8BB5CC")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x8B8E04", Offset = "0x8B8E04", VA = "0x8B8E04")]
		public BipedReferences()
		{
		}
	}
	[Token(Token = "0x2000069")]
	public class Comments : MonoBehaviour
	{
		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Multiline]
		public string text;

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x8BB650", Offset = "0x8BB650", VA = "0x8BB650")]
		public Comments()
		{
		}
	}
	[Token(Token = "0x200006A")]
	public class DemoGUIMessage : MonoBehaviour
	{
		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string text;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color color;

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x8BB658", Offset = "0x8BB658", VA = "0x8BB658")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x8BB750", Offset = "0x8BB750", VA = "0x8BB750")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x200006B")]
	public class Hierarchy
	{
		[Token(Token = "0x6000235")]
		[Address(RVA = "0x8BB760", Offset = "0x8BB760", VA = "0x8BB760")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x8BB914", Offset = "0x8BB914", VA = "0x8BB914")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x8BB7E4", Offset = "0x8BB7E4", VA = "0x8BB7E4")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x8BBA20", Offset = "0x8BBA20", VA = "0x8BBA20")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x8BBB30", Offset = "0x8BBB30", VA = "0x8BBB30")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x8BBD78", Offset = "0x8BBD78", VA = "0x8BBD78")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x8BBE6C", Offset = "0x8BBE6C", VA = "0x8BBE6C")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x8BBFBC", Offset = "0x8BBFBC", VA = "0x8BBFBC")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x8BC328", Offset = "0x8BC328", VA = "0x8BC328")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x8BC120", Offset = "0x8BC120", VA = "0x8BC120")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x8BC4B0", Offset = "0x8BC4B0", VA = "0x8BC4B0")]
		public Hierarchy()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006C")]
	public enum InterpolationMode
	{
		[Token(Token = "0x40002F9")]
		None,
		[Token(Token = "0x40002FA")]
		InOutCubic,
		[Token(Token = "0x40002FB")]
		InOutQuintic,
		[Token(Token = "0x40002FC")]
		InOutSine,
		[Token(Token = "0x40002FD")]
		InQuintic,
		[Token(Token = "0x40002FE")]
		InQuartic,
		[Token(Token = "0x40002FF")]
		InCubic,
		[Token(Token = "0x4000300")]
		InQuadratic,
		[Token(Token = "0x4000301")]
		InElastic,
		[Token(Token = "0x4000302")]
		InElasticSmall,
		[Token(Token = "0x4000303")]
		InElasticBig,
		[Token(Token = "0x4000304")]
		InSine,
		[Token(Token = "0x4000305")]
		InBack,
		[Token(Token = "0x4000306")]
		OutQuintic,
		[Token(Token = "0x4000307")]
		OutQuartic,
		[Token(Token = "0x4000308")]
		OutCubic,
		[Token(Token = "0x4000309")]
		OutInCubic,
		[Token(Token = "0x400030A")]
		OutInQuartic,
		[Token(Token = "0x400030B")]
		OutElastic,
		[Token(Token = "0x400030C")]
		OutElasticSmall,
		[Token(Token = "0x400030D")]
		OutElasticBig,
		[Token(Token = "0x400030E")]
		OutSine,
		[Token(Token = "0x400030F")]
		OutBack,
		[Token(Token = "0x4000310")]
		OutBackCubic,
		[Token(Token = "0x4000311")]
		OutBackQuartic,
		[Token(Token = "0x4000312")]
		BackInCubic,
		[Token(Token = "0x4000313")]
		BackInQuartic
	}
	[Token(Token = "0x200006D")]
	public class Interp
	{
		[Token(Token = "0x6000240")]
		[Address(RVA = "0x8BC4B8", Offset = "0x8BC4B8", VA = "0x8BC4B8")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x8BCE40", Offset = "0x8BCE40", VA = "0x8BCE40")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x8BCEB0", Offset = "0x8BCEB0", VA = "0x8BCEB0")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x8BC8B8", Offset = "0x8BC8B8", VA = "0x8BC8B8")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x8BC8C4", Offset = "0x8BC8C4", VA = "0x8BC8C4")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x8BC8E8", Offset = "0x8BC8E8", VA = "0x8BC8E8")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x8BC924", Offset = "0x8BC924", VA = "0x8BC924")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x8BC93C", Offset = "0x8BC93C", VA = "0x8BC93C")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x8BC950", Offset = "0x8BC950", VA = "0x8BC950")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x8BC964", Offset = "0x8BC964", VA = "0x8BC964")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x8BC974", Offset = "0x8BC974", VA = "0x8BC974")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x8BC9BC", Offset = "0x8BC9BC", VA = "0x8BC9BC")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x8BC9F4", Offset = "0x8BC9F4", VA = "0x8BC9F4")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x8BCA1C", Offset = "0x8BCA1C", VA = "0x8BCA1C")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x8BCF20", Offset = "0x8BCF20", VA = "0x8BCF20")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x8BCA50", Offset = "0x8BCA50", VA = "0x8BCA50")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x8BCA78", Offset = "0x8BCA78", VA = "0x8BCA78")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x8BCAA8", Offset = "0x8BCAA8", VA = "0x8BCAA8")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x8BCADC", Offset = "0x8BCADC", VA = "0x8BCADC")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x8BCB20", Offset = "0x8BCB20", VA = "0x8BCB20")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x8BCB84", Offset = "0x8BCB84", VA = "0x8BCB84")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x8BCBE8", Offset = "0x8BCBE8", VA = "0x8BCBE8")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x8BCC3C", Offset = "0x8BCC3C", VA = "0x8BCC3C")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x8BCC90", Offset = "0x8BCC90", VA = "0x8BCC90")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x8BCCC8", Offset = "0x8BCCC8", VA = "0x8BCCC8")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x8BCCFC", Offset = "0x8BCCFC", VA = "0x8BCCFC")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x8BCF54", Offset = "0x8BCF54", VA = "0x8BCF54")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x8BCD40", Offset = "0x8BCD40", VA = "0x8BCD40")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x8BCDD0", Offset = "0x8BCDD0", VA = "0x8BCDD0")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x8BCE00", Offset = "0x8BCE00", VA = "0x8BCE00")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x8BCFE4", Offset = "0x8BCFE4", VA = "0x8BCFE4")]
		public Interp()
		{
		}
	}
	[Token(Token = "0x200006E")]
	public class LargeHeader : PropertyAttribute
	{
		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string color;

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x8BCFEC", Offset = "0x8BCFEC", VA = "0x8BCFEC")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x8BD074", Offset = "0x8BD074", VA = "0x8BD074")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x200006F")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x6000261")]
		[Address(RVA = "0x8BD100", Offset = "0x8BD100", VA = "0x8BD100")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x8BD14C", Offset = "0x8BD14C", VA = "0x8BD14C")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x8BD208", Offset = "0x8BD208", VA = "0x8BD208")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x8BD160", Offset = "0x8BD160", VA = "0x8BD160")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x8BD21C", Offset = "0x8BD21C", VA = "0x8BD21C")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x8BD2AC", Offset = "0x8BD2AC", VA = "0x8BD2AC")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x8BD2D4", Offset = "0x8BD2D4", VA = "0x8BD2D4")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x8BD320", Offset = "0x8BD320", VA = "0x8BD320")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x8BD388", Offset = "0x8BD388", VA = "0x8BD388")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x8BD4E4", Offset = "0x8BD4E4", VA = "0x8BD4E4")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x8BD61C", Offset = "0x8BD61C", VA = "0x8BD61C")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x8BD674", Offset = "0x8BD674", VA = "0x8BD674")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x2000070")]
	public static class QuaTools
	{
		[Token(Token = "0x600026D")]
		[Address(RVA = "0x8BD698", Offset = "0x8BD698", VA = "0x8BD698")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x8BD6E4", Offset = "0x8BD6E4", VA = "0x8BD6E4")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x8BD730", Offset = "0x8BD730", VA = "0x8BD730")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x8BD834", Offset = "0x8BD834", VA = "0x8BD834")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x8BD938", Offset = "0x8BD938", VA = "0x8BD938")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x8BDA4C", Offset = "0x8BDA4C", VA = "0x8BDA4C")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x8BDAF4", Offset = "0x8BDAF4", VA = "0x8BDAF4")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x8BDC00", Offset = "0x8BDC00", VA = "0x8BDC00")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x8BDD68", Offset = "0x8BDD68", VA = "0x8BDD68")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x8BDF4C", Offset = "0x8BDF4C", VA = "0x8BDF4C")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x8BE01C", Offset = "0x8BE01C", VA = "0x8BE01C")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis)
		{
			return default(Quaternion);
		}
	}
	[Token(Token = "0x2000071")]
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T sInstance;

		[Token(Token = "0x1700004B")]
		public static T instance
		{
			[Token(Token = "0x6000278")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000279")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600027A")]
		protected Singleton()
		{
		}
	}
	[Token(Token = "0x2000072")]
	public class SolverManager : MonoBehaviour
	{
		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If true, will fix all the Transforms used by the solver to their initial state in each Update. This prevents potential problems with unanimated bones and animator culling with a small cost of performance. Not recommended for CCD and FABRIK solvers.")]
		public bool fixTransforms;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animation legacy;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool updateFrame;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool componentInitiated;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		private bool skipSolverUpdate;

		[Token(Token = "0x1700004C")]
		private bool animatePhysics
		{
			[Token(Token = "0x6000281")]
			[Address(RVA = "0x8BE2BC", Offset = "0x8BE2BC", VA = "0x8BE2BC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004D")]
		private bool isAnimated
		{
			[Token(Token = "0x6000285")]
			[Address(RVA = "0x8BE5B8", Offset = "0x8BE5B8", VA = "0x8BE5B8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x8BE1A0", Offset = "0x8BE1A0", VA = "0x8BE1A0")]
		public void Disable()
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x8BE234", Offset = "0x8BE234", VA = "0x8BE234", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x8BE238", Offset = "0x8BE238", VA = "0x8BE238", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x8BE23C", Offset = "0x8BE23C", VA = "0x8BE23C", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x8BE240", Offset = "0x8BE240", VA = "0x8BE240")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x8BE2B8", Offset = "0x8BE2B8", VA = "0x8BE2B8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x8BE268", Offset = "0x8BE268", VA = "0x8BE268")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x8BE57C", Offset = "0x8BE57C", VA = "0x8BE57C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x8BE388", Offset = "0x8BE388", VA = "0x8BE388")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x8BE650", Offset = "0x8BE650", VA = "0x8BE650")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x8BE69C", Offset = "0x8BE69C", VA = "0x8BE69C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x8BE6E8", Offset = "0x8BE6E8", VA = "0x8BE6E8")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x8BE720", Offset = "0x8BE720", VA = "0x8BE720")]
		public SolverManager()
		{
		}
	}
	[Token(Token = "0x2000073")]
	public class TriggerEventBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject target;

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x8BE730", Offset = "0x8BE730", VA = "0x8BE730")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x8BE7E4", Offset = "0x8BE7E4", VA = "0x8BE7E4")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x8BE898", Offset = "0x8BE898", VA = "0x8BE898")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x8BE94C", Offset = "0x8BE94C", VA = "0x8BE94C")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x2000074")]
	public static class V3Tools
	{
		[Token(Token = "0x600028E")]
		[Address(RVA = "0x8BE954", Offset = "0x8BE954", VA = "0x8BE954")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x8BE9B0", Offset = "0x8BE9B0", VA = "0x8BE9B0")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x8BE9E8", Offset = "0x8BE9E8", VA = "0x8BE9E8")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x8BEB38", Offset = "0x8BEB38", VA = "0x8BEB38")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x8BECB4", Offset = "0x8BECB4", VA = "0x8BECB4")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x8BEF04", Offset = "0x8BEF04", VA = "0x8BEF04")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x8BF15C", Offset = "0x8BF15C", VA = "0x8BF15C")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x8BF308", Offset = "0x8BF308", VA = "0x8BF308")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000075")]
	public static class Warning
	{
		[Token(Token = "0x2000076")]
		public delegate void Logger(string message);

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool logged;

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x8BF500", Offset = "0x8BF500", VA = "0x8BF500")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x8BF598", Offset = "0x8BF598", VA = "0x8BF598")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
namespace RootMotion.Demos
{
	[Token(Token = "0x2000077")]
	public class AimBoxing : MonoBehaviour
	{
		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform pin;

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x8BF740", Offset = "0x8BF740", VA = "0x8BF740")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x8BF7C0", Offset = "0x8BF7C0", VA = "0x8BF7C0")]
		public AimBoxing()
		{
		}
	}
	[Token(Token = "0x2000078")]
	public class SimpleAimingSystem : MonoBehaviour
	{
		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("AimPoser is a tool that returns an animation name based on direction.")]
		public AimPoser aimPoser;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Reference to the AimIK component.")]
		public AimIK aim;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Reference to the LookAt component (only used for the head in this instance).")]
		public LookAtIK lookAt;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Reference to the Animator component.")]
		public Animator animator;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Time of cross-fading from pose to pose.")]
		public float crossfadeTime;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("Will keep the aim target at a distance.")]
		public float minAimDistance;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AimPoser.Pose aimPose;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AimPoser.Pose lastPose;

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x8BF7C8", Offset = "0x8BF7C8", VA = "0x8BF7C8")]
		private void Start()
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x8BF800", Offset = "0x8BF800", VA = "0x8BF800")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x8BF94C", Offset = "0x8BF94C", VA = "0x8BF94C")]
		private void Pose()
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x8BFAD8", Offset = "0x8BFAD8", VA = "0x8BFAD8")]
		private void LimitAimTarget()
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x8BFCBC", Offset = "0x8BFCBC", VA = "0x8BFCBC")]
		private void DirectCrossFade(string state, float target)
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x8BFD4C", Offset = "0x8BFD4C", VA = "0x8BFD4C")]
		public SimpleAimingSystem()
		{
		}
	}
	[Token(Token = "0x2000079")]
	public class TerrainOffset : MonoBehaviour
	{
		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 raycastOffset;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public LayerMask raycastLayers;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float min;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float max;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float lerpSpeed;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private RaycastHit hit;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 offset;

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x8BFD60", Offset = "0x8BFD60", VA = "0x8BFD60")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x8BFECC", Offset = "0x8BFECC", VA = "0x8BFECC")]
		private Vector3 GetGroundHeightOffset(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x8C00C8", Offset = "0x8C00C8", VA = "0x8C00C8")]
		public TerrainOffset()
		{
		}
	}
	[Token(Token = "0x200007A")]
	public class BipedIKvsAnimatorIK : MonoBehaviour
	{
		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[LargeHeader("References")]
		public Animator animator;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BipedIK bipedIK;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[LargeHeader("Look At")]
		public Transform lookAtTargetBiped;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform lookAtTargetAnimator;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 1f)]
		public float lookAtWeight;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 1f)]
		public float lookAtBodyWeight;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Range(0f, 1f)]
		public float lookAtHeadWeight;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Range(0f, 1f)]
		public float lookAtEyesWeight;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Range(0f, 1f)]
		public float lookAtClampWeight;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Range(0f, 1f)]
		public float lookAtClampWeightHead;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Range(0f, 1f)]
		public float lookAtClampWeightEyes;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[LargeHeader("Foot")]
		public Transform footTargetBiped;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform footTargetAnimator;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Range(0f, 1f)]
		public float footPositionWeight;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Range(0f, 1f)]
		public float footRotationWeight;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[LargeHeader("Hand")]
		public Transform handTargetBiped;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform handTargetAnimator;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Range(0f, 1f)]
		public float handPositionWeight;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[Range(0f, 1f)]
		public float handRotationWeight;

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x8C00F8", Offset = "0x8C00F8", VA = "0x8C00F8")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x8C0524", Offset = "0x8C0524", VA = "0x8C0524")]
		public BipedIKvsAnimatorIK()
		{
		}
	}
	[Token(Token = "0x200007B")]
	public class MechSpider : MonoBehaviour
	{
		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LayerMask raycastLayers;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float scale;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform body;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MechSpiderLeg[] legs;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float legRotationWeight;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float rootPositionSpeed;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float rootRotationSpeed;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float breatheSpeed;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float breatheMagnitude;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float height;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float minHeight;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float raycastHeight;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float raycastDistance;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 defaultBodyLocalPosition;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float sine;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RaycastHit rootHit;

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x8C0544", Offset = "0x8C0544", VA = "0x8C0544")]
		private void Update()
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x8C0E60", Offset = "0x8C0E60", VA = "0x8C0E60")]
		private Vector3 GetLegCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x8C0BDC", Offset = "0x8C0BDC", VA = "0x8C0BDC")]
		private Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x8C0F70", Offset = "0x8C0F70", VA = "0x8C0F70")]
		public MechSpider()
		{
		}
	}
	[Token(Token = "0x200007C")]
	public class MechSpiderController : MonoBehaviour
	{
		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform cameraTransform;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float speed;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float turnSpeed;

		[Token(Token = "0x1700004E")]
		public Vector3 inputVector
		{
			[Token(Token = "0x60002AD")]
			[Address(RVA = "0x8C0F9C", Offset = "0x8C0F9C", VA = "0x8C0F9C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x8C101C", Offset = "0x8C101C", VA = "0x8C101C")]
		private void Update()
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x8C1360", Offset = "0x8C1360", VA = "0x8C1360")]
		public MechSpiderController()
		{
		}
	}
	[Token(Token = "0x200007D")]
	public class MechSpiderLeg : MonoBehaviour
	{
		[Token(Token = "0x200007E")]
		[CompilerGenerated]
		private sealed class <Step>d__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000369")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400036A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400036B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MechSpiderLeg <>4__this;

			[Token(Token = "0x400036C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 stepStartPosition;

			[Token(Token = "0x400036D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public Vector3 targetPosition;

			[Token(Token = "0x17000051")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60002BB")]
				[Address(RVA = "0x8C1D7C", Offset = "0x8C1D7C", VA = "0x8C1D7C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000052")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002BD")]
				[Address(RVA = "0x8C1DC4", Offset = "0x8C1DC4", VA = "0x8C1DC4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002B8")]
			[Address(RVA = "0x8C1A94", Offset = "0x8C1A94", VA = "0x8C1A94")]
			[DebuggerHidden]
			public <Step>d__24(int <>1__state)
			{
			}

			[Token(Token = "0x60002B9")]
			[Address(RVA = "0x8C1AEC", Offset = "0x8C1AEC", VA = "0x8C1AEC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60002BA")]
			[Address(RVA = "0x8C1AF0", Offset = "0x8C1AF0", VA = "0x8C1AF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002BC")]
			[Address(RVA = "0x8C1D84", Offset = "0x8C1D84", VA = "0x8C1D84", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MechSpiderLeg unSync;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 offset;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float minDelay;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float maxOffset;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float stepSpeed;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float footHeight;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float velocityPrediction;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float raycastFocus;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve yOffset;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public ParticleSystem sand;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IK ik;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float stepProgress;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float lastStepTime;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3 defaultPosition;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private RaycastHit hit;

		[Token(Token = "0x1700004F")]
		public bool isStepping
		{
			[Token(Token = "0x60002B0")]
			[Address(RVA = "0x8C1374", Offset = "0x8C1374", VA = "0x8C1374")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000050")]
		public Vector3 position
		{
			[Token(Token = "0x60002B1")]
			[Address(RVA = "0x8C0F40", Offset = "0x8C0F40", VA = "0x8C0F40")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60002B2")]
			[Address(RVA = "0x8C1388", Offset = "0x8C1388", VA = "0x8C1388")]
			set
			{
			}
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x8C13D4", Offset = "0x8C13D4", VA = "0x8C13D4")]
		private void Start()
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x8C1528", Offset = "0x8C1528", VA = "0x8C1528")]
		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x8C17C8", Offset = "0x8C17C8", VA = "0x8C17C8")]
		private void Update()
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x8C19E4", Offset = "0x8C19E4", VA = "0x8C19E4")]
		[IteratorStateMachine(typeof(<Step>d__24))]
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition)
		{
			return null;
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x8C1ABC", Offset = "0x8C1ABC", VA = "0x8C1ABC")]
		public MechSpiderLeg()
		{
		}
	}
	[Token(Token = "0x200007F")]
	public class MechSpiderParticles : MonoBehaviour
	{
		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpiderController mechSpiderController;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ParticleSystem particles;

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x8C1DCC", Offset = "0x8C1DCC", VA = "0x8C1DCC")]
		private void Start()
		{
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x8C1EA8", Offset = "0x8C1EA8", VA = "0x8C1EA8")]
		private void Update()
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x8C211C", Offset = "0x8C211C", VA = "0x8C211C")]
		public MechSpiderParticles()
		{
		}
	}
	[Token(Token = "0x2000080")]
	public class AnimationWarping : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000081")]
		public struct Warp
		{
			[Token(Token = "0x4000374")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[Tooltip("Layer of the 'Animation State' in the Animator.")]
			public int animationLayer;

			[Token(Token = "0x4000375")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[Tooltip("Name of the state in the Animator to warp.")]
			public string animationState;

			[Token(Token = "0x4000376")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Warping weight by normalized time of the animation state.")]
			public AnimationCurve weightCurve;

			[Token(Token = "0x4000377")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Animated point to warp from. This should be in character space so keep this Transform parented to the root of the character.")]
			public Transform warpFrom;

			[Token(Token = "0x4000378")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("World space point to warp to.")]
			public Transform warpTo;

			[Token(Token = "0x4000379")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Which FBBIK effector to use?")]
			public FullBodyBipedEffector effector;
		}

		[Serializable]
		[Token(Token = "0x2000082")]
		public enum EffectorMode
		{
			[Token(Token = "0x400037B")]
			PositionOffset,
			[Token(Token = "0x400037C")]
			Position
		}

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Reference to the Animator component to use")]
		public Animator animator;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Using effector.positionOffset or effector.position with effector.positionWeight? The former will enable you to use effector.position for other things, the latter will weigh in the effectors, hence using Reach and Pull in the process.")]
		public EffectorMode effectorMode;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Space(10f)]
		[Tooltip("The array of warps, can have multiple simultaneous warps.")]
		public Warp[] warps;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private EffectorMode lastMode;

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x8C2124", Offset = "0x8C2124", VA = "0x8C2124", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x8C2144", Offset = "0x8C2144", VA = "0x8C2144")]
		public float GetWarpWeight(int warpIndex)
		{
			return default(float);
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x8C235C", Offset = "0x8C235C", VA = "0x8C235C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x8C2614", Offset = "0x8C2614", VA = "0x8C2614")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x8C26A8", Offset = "0x8C26A8", VA = "0x8C26A8")]
		public AnimationWarping()
		{
		}
	}
	[Token(Token = "0x2000083")]
	[RequireComponent(typeof(Animator))]
	public class AnimatorController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotateSpeed;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float blendSpeed;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float maxAngle;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float moveSpeed;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float rootMotionWeight;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Animator animator;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Vector3 moveBlend;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		protected Vector3 moveInput;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Vector3 velocity;

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x8C26B0", Offset = "0x8C26B0", VA = "0x8C26B0", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x8C2708", Offset = "0x8C2708", VA = "0x8C2708")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x8C2910", Offset = "0x8C2910", VA = "0x8C2910", Slot = "5")]
		public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x8C2B38", Offset = "0x8C2B38", VA = "0x8C2B38")]
		public AnimatorController3rdPerson()
		{
		}
	}
	[Token(Token = "0x2000084")]
	[RequireComponent(typeof(FullBodyBipedIK))]
	[RequireComponent(typeof(AimIK))]
	public class AnimatorController3rdPersonIK : AnimatorController3rdPerson
	{
		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Range(0f, 1f)]
		public float headLookWeight;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 gunHoldOffset;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Recoil recoil;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private AimIK aim;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 headLookAxis;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 leftHandPosRelToRightHand;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Quaternion leftHandRotRelToRightHand;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 aimTarget;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x8C2B4C", Offset = "0x8C2B4C", VA = "0x8C2B4C", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x8C2D20", Offset = "0x8C2D20", VA = "0x8C2D20", Slot = "5")]
		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x8C2D88", Offset = "0x8C2D88", VA = "0x8C2D88")]
		private void Read()
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x8C2EC0", Offset = "0x8C2EC0", VA = "0x8C2EC0")]
		private void AimIK()
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x8C2F1C", Offset = "0x8C2F1C", VA = "0x8C2F1C")]
		private void FBBIK()
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x8C3564", Offset = "0x8C3564", VA = "0x8C3564")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x8C3378", Offset = "0x8C3378", VA = "0x8C3378")]
		private void HeadLookAt(Vector3 lookAtTarget)
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x8C3808", Offset = "0x8C3808", VA = "0x8C3808")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x8C3934", Offset = "0x8C3934", VA = "0x8C3934")]
		public AnimatorController3rdPersonIK()
		{
		}
	}
	[Token(Token = "0x2000085")]
	[RequireComponent(typeof(FullBodyBipedIK))]
	public class CharacterAnimationThirdPersonIK : CharacterAnimationThirdPerson
	{
		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x8C3950", Offset = "0x8C3950", VA = "0x8C3950", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x8C39B4", Offset = "0x8C39B4", VA = "0x8C39B4", Slot = "7")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x8C3CF0", Offset = "0x8C3CF0", VA = "0x8C3CF0")]
		private void RotateEffector(IKEffector effector, Quaternion rotation, float mlp)
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x8C3DE0", Offset = "0x8C3DE0", VA = "0x8C3DE0")]
		public CharacterAnimationThirdPersonIK()
		{
		}
	}
	[Token(Token = "0x2000086")]
	[RequireComponent(typeof(AnimatorController3rdPerson))]
	public class CharacterController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CameraController cam;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AnimatorController3rdPerson animatorController;

		[Token(Token = "0x17000053")]
		private static Vector3 inputVector
		{
			[Token(Token = "0x60002D9")]
			[Address(RVA = "0x8C4048", Offset = "0x8C4048", VA = "0x8C4048")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000054")]
		private static Vector3 inputVectorRaw
		{
			[Token(Token = "0x60002DA")]
			[Address(RVA = "0x8C40C8", Offset = "0x8C40C8", VA = "0x8C40C8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x8C3DE8", Offset = "0x8C3DE8", VA = "0x8C3DE8")]
		private void Start()
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x8C3E58", Offset = "0x8C3E58", VA = "0x8C3E58")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x8C4148", Offset = "0x8C4148", VA = "0x8C4148")]
		public CharacterController3rdPerson()
		{
		}
	}
	[Token(Token = "0x2000087")]
	public class EffectorOffset : OffsetModifier
	{
		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0f, 1f)]
		public float handsMaintainRelativePositionWeight;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 bodyOffset;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 leftShoulderOffset;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rightShoulderOffset;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 leftThighOffset;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 rightThighOffset;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Vector3 rightHandOffset;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Vector3 leftFootOffset;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 rightFootOffset;

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x8C4150", Offset = "0x8C4150", VA = "0x8C4150", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x8C45AC", Offset = "0x8C45AC", VA = "0x8C45AC")]
		public EffectorOffset()
		{
		}
	}
	[Token(Token = "0x2000088")]
	public class ExplosionDemo : MonoBehaviour
	{
		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SimpleLocomotion character;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float forceMlp;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float upForce;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weightFalloffSpeed;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve weightFalloff;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve explosionForceByDistance;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve scale;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float weight;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 defaultScale;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Rigidbody r;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x8C45B4", Offset = "0x8C45B4", VA = "0x8C45B4")]
		private void Start()
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x8C466C", Offset = "0x8C466C", VA = "0x8C466C")]
		private void Update()
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x8C4AC8", Offset = "0x8C4AC8", VA = "0x8C4AC8")]
		private void SetEffectorWeights(float w)
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x8C4B68", Offset = "0x8C4B68", VA = "0x8C4B68")]
		public ExplosionDemo()
		{
		}
	}
	[Token(Token = "0x2000089")]
	public class FBBIKSettings : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200008A")]
		public class Limb
		{
			[Token(Token = "0x40003B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FBIKChain.Smoothing reachSmoothing;

			[Token(Token = "0x40003B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float maintainRelativePositionWeight;

			[Token(Token = "0x40003B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float mappingWeight;

			[Token(Token = "0x60002E6")]
			[Address(RVA = "0x8C4CFC", Offset = "0x8C4CFC", VA = "0x8C4CFC")]
			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver)
			{
			}

			[Token(Token = "0x60002E7")]
			[Address(RVA = "0x8C4E20", Offset = "0x8C4E20", VA = "0x8C4E20")]
			public Limb()
			{
			}
		}

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool disableAfterStart;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Limb leftArm;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Limb rightArm;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Limb leftLeg;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Limb rightLeg;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float rootPin;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool bodyEffectChildNodes;

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x8C4BD8", Offset = "0x8C4BD8", VA = "0x8C4BD8")]
		public void UpdateSettings()
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x8C4D74", Offset = "0x8C4D74", VA = "0x8C4D74")]
		private void Start()
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x8C4E0C", Offset = "0x8C4E0C", VA = "0x8C4E0C")]
		private void Update()
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x8C4E10", Offset = "0x8C4E10", VA = "0x8C4E10")]
		public FBBIKSettings()
		{
		}
	}
	[Token(Token = "0x200008B")]
	public class FBIKBendGoal : MonoBehaviour
	{
		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedChain chain;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float weight;

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x8C4E30", Offset = "0x8C4E30", VA = "0x8C4E30")]
		private void Start()
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x8C4E98", Offset = "0x8C4E98", VA = "0x8C4E98")]
		private void Update()
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x8C4F6C", Offset = "0x8C4F6C", VA = "0x8C4F6C")]
		public FBIKBendGoal()
		{
		}
	}
	[Token(Token = "0x200008C")]
	public class FBIKBoxing : MonoBehaviour
	{
		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The target we want to hit")]
		public Transform target;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The pin Transform is used to reference the exact hit point in the animation (used by AimIK to aim the upper body to follow the target).In Legacy and Generic modes you can just create and position a reference point in your animating software and include it in the FBX. Then in Unity if you added a GameObject with the exact same name under the character's root, it would be animated to the required position.In Humanoid mode however, Mecanim loses track of any Transform that does not belong to the avatar, so in this case the pin point has to be manually set inside the Unity Editor.")]
		public Transform pin;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The Full Body Biped IK component")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The Aim IK component. Aim IK is ust used for following the target slightly with the body.")]
		public AimIK aim;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The master weight")]
		public float weight;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("The effector type of the punching hand")]
		public FullBodyBipedEffector effector;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Weight of aiming the body to follow the target")]
		public AnimationCurve aimWeight;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Animator animator;

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x8C4F74", Offset = "0x8C4F74", VA = "0x8C4F74")]
		private void Start()
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x8C4FCC", Offset = "0x8C4FCC", VA = "0x8C4FCC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x8C5164", Offset = "0x8C5164", VA = "0x8C5164")]
		public FBIKBoxing()
		{
		}
	}
	[Token(Token = "0x200008D")]
	public class FBIKHandsOnProp : MonoBehaviour
	{
		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool leftHanded;

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x8C516C", Offset = "0x8C516C", VA = "0x8C516C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x8C524C", Offset = "0x8C524C", VA = "0x8C524C")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x8C52CC", Offset = "0x8C52CC", VA = "0x8C52CC")]
		private void HandsOnProp(IKEffector mainHand, IKEffector otherHand)
		{
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x8C5714", Offset = "0x8C5714", VA = "0x8C5714")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x8C5840", Offset = "0x8C5840", VA = "0x8C5840")]
		public FBIKHandsOnProp()
		{
		}
	}
	[Token(Token = "0x200008E")]
	public class FPSAiming : MonoBehaviour
	{
		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float aimWeight;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(0f, 1f)]
		public float sightWeight;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 180f)]
		public float maxAngle;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool animatePhysics;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform gun;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform gunTarget;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private AimIK gunAim;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CameraControllerFPS cam;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Recoil recoil;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Range(0f, 1f)]
		private float cameraRecoilWeight;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 gunTargetDefaultLocalPosition;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Quaternion gunTargetDefaultLocalRotation;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 camDefaultLocalPosition;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 camRelativeToGunTarget;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool updateFrame;

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x8C5848", Offset = "0x8C5848", VA = "0x8C5848")]
		private void Start()
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x8C59A8", Offset = "0x8C59A8", VA = "0x8C59A8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x8C59B4", Offset = "0x8C59B4", VA = "0x8C59B4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x8C5C74", Offset = "0x8C5C74", VA = "0x8C5C74")]
		private void Aiming()
		{
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x8C5DC4", Offset = "0x8C5DC4", VA = "0x8C5DC4")]
		private void LookDownTheSight()
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x8C5A78", Offset = "0x8C5A78", VA = "0x8C5A78")]
		private void RotateCharacter()
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x8C6A48", Offset = "0x8C6A48", VA = "0x8C6A48")]
		public FPSAiming()
		{
		}
	}
	[Token(Token = "0x200008F")]
	[RequireComponent(typeof(Animator))]
	[RequireComponent(typeof(FPSAiming))]
	public class FPSCharacter : MonoBehaviour
	{
		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float walkSpeed;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float sVel;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private FPSAiming FPSAiming;

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x8C6A68", Offset = "0x8C6A68", VA = "0x8C6A68")]
		private void Start()
		{
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x8C6AF8", Offset = "0x8C6AF8", VA = "0x8C6AF8")]
		private void Update()
		{
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x8C6BF4", Offset = "0x8C6BF4", VA = "0x8C6BF4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x8C6CA0", Offset = "0x8C6CA0", VA = "0x8C6CA0")]
		public FPSCharacter()
		{
		}
	}
	[Token(Token = "0x2000090")]
	public class HitReactionTrigger : MonoBehaviour
	{
		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private HitReaction hitReaction;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float hitForce;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x8C6CB0", Offset = "0x8C6CB0", VA = "0x8C6CB0")]
		private void Update()
		{
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x8C6E00", Offset = "0x8C6E00", VA = "0x8C6E00")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x8C6F64", Offset = "0x8C6F64", VA = "0x8C6F64")]
		public HitReactionTrigger()
		{
		}
	}
	[Token(Token = "0x2000091")]
	public class HoldingHands : MonoBehaviour
	{
		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK rightHandChar;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedIK leftHandChar;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform rightHandTarget;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftHandTarget;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float crossFade;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float speed;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandRotation;

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x8C6F74", Offset = "0x8C6F74", VA = "0x8C6F74")]
		private void Start()
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x8C7140", Offset = "0x8C7140", VA = "0x8C7140")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x8C7550", Offset = "0x8C7550", VA = "0x8C7550")]
		public HoldingHands()
		{
		}
	}
	[Token(Token = "0x2000092")]
	public class InteractionC2CDemo : MonoBehaviour
	{
		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem character1;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem character2;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject handShake;

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x8C7560", Offset = "0x8C7560", VA = "0x8C7560")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x8C7648", Offset = "0x8C7648", VA = "0x8C7648")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x8C7734", Offset = "0x8C7734", VA = "0x8C7734")]
		public InteractionC2CDemo()
		{
		}
	}
	[Token(Token = "0x2000093")]
	public class InteractionDemo : MonoBehaviour
	{
		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool interrupt;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject ball;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public InteractionObject benchMain;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public InteractionObject benchHands;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionObject button;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public InteractionObject cigarette;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public InteractionObject door;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool isSitting;

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x8C773C", Offset = "0x8C773C", VA = "0x8C773C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x8C7C3C", Offset = "0x8C7C3C", VA = "0x8C7C3C")]
		public InteractionDemo()
		{
		}
	}
	[Token(Token = "0x2000094")]
	[RequireComponent(typeof(InteractionSystem))]
	public class InteractionSystemTestGUI : MonoBehaviour
	{
		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The object to interact to")]
		[SerializeField]
		private InteractionObject interactionObject;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The effectors to interact with")]
		[SerializeField]
		private FullBodyBipedEffector[] effectors;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x8C7C44", Offset = "0x8C7C44", VA = "0x8C7C44")]
		private void Awake()
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x8C7C9C", Offset = "0x8C7C9C", VA = "0x8C7C9C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x8C7F48", Offset = "0x8C7F48", VA = "0x8C7F48")]
		public InteractionSystemTestGUI()
		{
		}
	}
	[Token(Token = "0x2000095")]
	public class KissingRig : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000096")]
		public class Partner
		{
			[Token(Token = "0x40003F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedIK ik;

			[Token(Token = "0x40003F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform mouth;

			[Token(Token = "0x40003F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform mouthTarget;

			[Token(Token = "0x40003F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform touchTargetLeftHand;

			[Token(Token = "0x40003F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Transform touchTargetRightHand;

			[Token(Token = "0x40003F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float bodyWeightHorizontal;

			[Token(Token = "0x40003F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float bodyWeightVertical;

			[Token(Token = "0x40003FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public float neckRotationWeight;

			[Token(Token = "0x40003FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public float headTiltAngle;

			[Token(Token = "0x40003FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 headTiltAxis;

			[Token(Token = "0x40003FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Quaternion neckRotation;

			[Token(Token = "0x17000055")]
			private Transform neck
			{
				[Token(Token = "0x6000311")]
				[Address(RVA = "0x8C8754", Offset = "0x8C8754", VA = "0x8C8754")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600030F")]
			[Address(RVA = "0x8C7F78", Offset = "0x8C7F78", VA = "0x8C7F78")]
			public void Initiate()
			{
			}

			[Token(Token = "0x6000310")]
			[Address(RVA = "0x8C7FF4", Offset = "0x8C7FF4", VA = "0x8C7FF4")]
			public void Update(float weight)
			{
			}

			[Token(Token = "0x6000312")]
			[Address(RVA = "0x8C85EC", Offset = "0x8C85EC", VA = "0x8C85EC")]
			private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight)
			{
			}

			[Token(Token = "0x6000313")]
			[Address(RVA = "0x8C87A0", Offset = "0x8C87A0", VA = "0x8C87A0")]
			public Partner()
			{
			}
		}

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Partner partner1;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Partner partner2;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weight;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int iterations;

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x8C7F50", Offset = "0x8C7F50", VA = "0x8C7F50")]
		private void Start()
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x8C7F98", Offset = "0x8C7F98", VA = "0x8C7F98")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x8C85DC", Offset = "0x8C85DC", VA = "0x8C85DC")]
		public KissingRig()
		{
		}
	}
	[Token(Token = "0x2000097")]
	public class MotionAbsorb : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000098")]
		public class Absorber
		{
			[Token(Token = "0x4000404")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The type of effector (hand, foot, shoulder...) - this is just an enum")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000405")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("How much should motion be absorbed on this effector")]
			public float weight;

			[Token(Token = "0x6000317")]
			[Address(RVA = "0x8C8898", Offset = "0x8C8898", VA = "0x8C8898")]
			public void SetToBone(IKSolverFullBodyBiped solver)
			{
			}

			[Token(Token = "0x6000318")]
			[Address(RVA = "0x8C8944", Offset = "0x8C8944", VA = "0x8C8944")]
			public void SetEffectorWeights(IKSolverFullBodyBiped solver, float w)
			{
			}

			[Token(Token = "0x6000319")]
			[Address(RVA = "0x8C89B4", Offset = "0x8C89B4", VA = "0x8C89B4")]
			public Absorber()
			{
			}
		}

		[Token(Token = "0x2000099")]
		[CompilerGenerated]
		private sealed class <AbsorbMotion>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000406")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000407")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000408")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MotionAbsorb <>4__this;

			[Token(Token = "0x17000056")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600031D")]
				[Address(RVA = "0x8C8B30", Offset = "0x8C8B30", VA = "0x8C8B30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000057")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600031F")]
				[Address(RVA = "0x8C8B78", Offset = "0x8C8B78", VA = "0x8C8B78", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600031A")]
			[Address(RVA = "0x8C885C", Offset = "0x8C885C", VA = "0x8C885C")]
			[DebuggerHidden]
			public <AbsorbMotion>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x600031B")]
			[Address(RVA = "0x8C89C4", Offset = "0x8C89C4", VA = "0x8C89C4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600031C")]
			[Address(RVA = "0x8C89C8", Offset = "0x8C89C8", VA = "0x8C89C8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600031E")]
			[Address(RVA = "0x8C8B38", Offset = "0x8C8B38", VA = "0x8C8B38", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Reference to the FBBIK component")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Array containing the absorbers")]
		public Absorber[] absorbers;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The master weight")]
		public float weight;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Weight falloff curve (how fast will the effect reduce after impact)")]
		public AnimationCurve falloff;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("How fast will the impact fade away. (if 1, effect lasts for 1 second)")]
		public float falloffSpeed;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float timer;

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x8C87B4", Offset = "0x8C87B4", VA = "0x8C87B4")]
		private void OnCollisionEnter()
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x8C87E8", Offset = "0x8C87E8", VA = "0x8C87E8")]
		[IteratorStateMachine(typeof(<AbsorbMotion>d__8))]
		private IEnumerator AbsorbMotion()
		{
			return null;
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x8C8884", Offset = "0x8C8884", VA = "0x8C8884")]
		public MotionAbsorb()
		{
		}
	}
	[Token(Token = "0x200009A")]
	public class MotionAbsorbCharacter : MonoBehaviour
	{
		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Animator animator;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MotionAbsorb motionAbsorb;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform cube;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float cubeRandomPosition;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve motionAbsorbWeight;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 cubeDefaultPosition;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorStateInfo info;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Rigidbody cubeRigidbody;

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x8C8B80", Offset = "0x8C8B80", VA = "0x8C8B80")]
		private void Start()
		{
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x8C8BF8", Offset = "0x8C8BF8", VA = "0x8C8BF8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x8C8CC8", Offset = "0x8C8CC8", VA = "0x8C8CC8")]
		private void SwingStart()
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x8C8E10", Offset = "0x8C8E10", VA = "0x8C8E10")]
		public MotionAbsorbCharacter()
		{
		}
	}
	[Token(Token = "0x200009B")]
	public class OffsetEffector : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x200009C")]
		public class EffectorLink
		{
			[Token(Token = "0x4000412")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000413")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float weightMultiplier;

			[Token(Token = "0x4000414")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public Vector3 localPosition;

			[Token(Token = "0x6000327")]
			[Address(RVA = "0x8C9090", Offset = "0x8C9090", VA = "0x8C9090")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x8C8E24", Offset = "0x8C8E24", VA = "0x8C8E24", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x8C8F10", Offset = "0x8C8F10", VA = "0x8C8F10", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x8C9088", Offset = "0x8C9088", VA = "0x8C9088")]
		public OffsetEffector()
		{
		}
	}
	[Token(Token = "0x200009D")]
	[RequireComponent(typeof(FullBodyBipedIK))]
	public class PendulumExample : MonoBehaviour
	{
		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		[Tooltip("The master weight of this script.")]
		public float weight;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("Multiplier for the distance of the root to the target.")]
		public float hangingDistanceMlp;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		[Tooltip("Where does the root of the character land when weight is blended out?")]
		public Vector3 rootTargetPosition;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[HideInInspector]
		[Tooltip("How is the root of the character rotated when weight is blended out?")]
		public Quaternion rootTargetRotation;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform target;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform leftHandTarget;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform rightHandTarget;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform leftFootTarget;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform rightFootTarget;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Transform pelvisTarget;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform bodyTarget;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Transform headTarget;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Vector3 pelvisDownAxis;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion rootRelativeToPelvis;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 pelvisToRoot;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float lastWeight;

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x8C90A0", Offset = "0x8C90A0", VA = "0x8C90A0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x8C93B4", Offset = "0x8C93B4", VA = "0x8C93B4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x8C9BB0", Offset = "0x8C9BB0", VA = "0x8C9BB0")]
		public PendulumExample()
		{
		}
	}
	[Token(Token = "0x200009E")]
	public abstract class PickUp2Handed : MonoBehaviour
	{
		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int GUIspace;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject obj;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform pivot;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform holdPoint;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float pickUpTime;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float holdWeight;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float holdWeightVel;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x17000058")]
		private bool holding
		{
			[Token(Token = "0x6000332")]
			[Address(RVA = "0x8C9E30", Offset = "0x8C9E30", VA = "0x8C9E30")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x8C9C1C", Offset = "0x8C9C1C", VA = "0x8C9C1C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600032C")]
		protected abstract void RotatePivot();

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x8C9E50", Offset = "0x8C9E50", VA = "0x8C9E50")]
		private void Start()
		{
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x8CA040", Offset = "0x8CA040", VA = "0x8CA040")]
		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x8CA1B0", Offset = "0x8CA1B0", VA = "0x8CA1B0")]
		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x8CA280", Offset = "0x8CA280", VA = "0x8CA280")]
		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x8CA3A0", Offset = "0x8CA3A0", VA = "0x8CA3A0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x8CA514", Offset = "0x8CA514", VA = "0x8CA514")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x8CA750", Offset = "0x8CA750", VA = "0x8CA750")]
		protected PickUp2Handed()
		{
		}
	}
	[Token(Token = "0x200009F")]
	public class PickUpBox : PickUp2Handed
	{
		[Token(Token = "0x6000335")]
		[Address(RVA = "0x8CA764", Offset = "0x8CA764", VA = "0x8CA764", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x8CA93C", Offset = "0x8CA93C", VA = "0x8CA93C")]
		public PickUpBox()
		{
		}
	}
	[Token(Token = "0x20000A0")]
	public class PickUpSphere : PickUp2Handed
	{
		[Token(Token = "0x6000337")]
		[Address(RVA = "0x8CA950", Offset = "0x8CA950", VA = "0x8CA950", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x8CAA64", Offset = "0x8CAA64", VA = "0x8CAA64")]
		public PickUpSphere()
		{
		}
	}
	[Token(Token = "0x20000A1")]
	public class RagdollUtilityDemo : MonoBehaviour
	{
		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RagdollUtility ragdollUtility;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform root;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Rigidbody pelvis;

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x8CAA78", Offset = "0x8CAA78", VA = "0x8CAA78")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x8CAB10", Offset = "0x8CAB10", VA = "0x8CAB10")]
		private void Update()
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x8CAC28", Offset = "0x8CAC28", VA = "0x8CAC28")]
		public RagdollUtilityDemo()
		{
		}
	}
	[Token(Token = "0x20000A2")]
	[RequireComponent(typeof(Recoil))]
	public class RecoilTest : MonoBehaviour
	{
		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float magnitude;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Recoil recoil;

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x8CAC30", Offset = "0x8CAC30", VA = "0x8CAC30")]
		private void Start()
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x8CAC88", Offset = "0x8CAC88", VA = "0x8CAC88")]
		private void Update()
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x8CACD4", Offset = "0x8CACD4", VA = "0x8CACD4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x8CAD6C", Offset = "0x8CAD6C", VA = "0x8CAD6C")]
		public RecoilTest()
		{
		}
	}
	[Token(Token = "0x20000A3")]
	public class ResetInteractionObject : MonoBehaviour
	{
		[Token(Token = "0x20000A4")]
		[CompilerGenerated]
		private sealed class <ResetObject>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400043A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400043B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400043C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float resetTime;

			[Token(Token = "0x400043D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ResetInteractionObject <>4__this;

			[Token(Token = "0x17000059")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000347")]
				[Address(RVA = "0x8CB0E4", Offset = "0x8CB0E4", VA = "0x8CB0E4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700005A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000349")]
				[Address(RVA = "0x8CB12C", Offset = "0x8CB12C", VA = "0x8CB12C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000344")]
			[Address(RVA = "0x8CAF00", Offset = "0x8CAF00", VA = "0x8CAF00")]
			[DebuggerHidden]
			public <ResetObject>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000345")]
			[Address(RVA = "0x8CAF38", Offset = "0x8CAF38", VA = "0x8CAF38", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000346")]
			[Address(RVA = "0x8CAF3C", Offset = "0x8CAF3C", VA = "0x8CAF3C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000348")]
			[Address(RVA = "0x8CB0EC", Offset = "0x8CB0EC", VA = "0x8CB0EC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float resetDelay;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector3 defaultPosition;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Quaternion defaultRotation;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform defaultParent;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody r;

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x8CAD7C", Offset = "0x8CAD7C", VA = "0x8CAD7C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x8CAE40", Offset = "0x8CAE40", VA = "0x8CAE40")]
		private void OnPickUp(Transform t)
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x8CAE7C", Offset = "0x8CAE7C", VA = "0x8CAE7C")]
		[IteratorStateMachine(typeof(<ResetObject>d__7))]
		private IEnumerator ResetObject(float resetTime)
		{
			return null;
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x8CAF28", Offset = "0x8CAF28", VA = "0x8CAF28")]
		public ResetInteractionObject()
		{
		}
	}
	[Token(Token = "0x20000A5")]
	[RequireComponent(typeof(Animator))]
	public class SoccerDemo : MonoBehaviour
	{
		[Token(Token = "0x20000A6")]
		[CompilerGenerated]
		private sealed class <ResetDelayed>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000441")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000442")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000443")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SoccerDemo <>4__this;

			[Token(Token = "0x1700005B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000350")]
				[Address(RVA = "0x8CB3D0", Offset = "0x8CB3D0", VA = "0x8CB3D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700005C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000352")]
				[Address(RVA = "0x8CB418", Offset = "0x8CB418", VA = "0x8CB418", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600034D")]
			[Address(RVA = "0x8CB25C", Offset = "0x8CB25C", VA = "0x8CB25C")]
			[DebuggerHidden]
			public <ResetDelayed>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x600034E")]
			[Address(RVA = "0x8CB28C", Offset = "0x8CB28C", VA = "0x8CB28C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600034F")]
			[Address(RVA = "0x8CB290", Offset = "0x8CB290", VA = "0x8CB290", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000351")]
			[Address(RVA = "0x8CB3D8", Offset = "0x8CB3D8", VA = "0x8CB3D8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Animator animator;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 defaultPosition;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x8CB134", Offset = "0x8CB134", VA = "0x8CB134")]
		private void Start()
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x8CB1E8", Offset = "0x8CB1E8", VA = "0x8CB1E8")]
		[IteratorStateMachine(typeof(<ResetDelayed>d__4))]
		private IEnumerator ResetDelayed()
		{
			return null;
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x8CB284", Offset = "0x8CB284", VA = "0x8CB284")]
		public SoccerDemo()
		{
		}
	}
	[Token(Token = "0x20000A7")]
	public class TouchWalls : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000A8")]
		public class EffectorLink
		{
			[Token(Token = "0x4000446")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool enabled;

			[Token(Token = "0x4000447")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000448")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public InteractionObject interactionObject;

			[Token(Token = "0x4000449")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spherecastFrom;

			[Token(Token = "0x400044A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float spherecastRadius;

			[Token(Token = "0x400044B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float minDistance;

			[Token(Token = "0x400044C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public LayerMask touchLayers;

			[Token(Token = "0x400044D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float lerpSpeed;

			[Token(Token = "0x400044E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float minSwitchTime;

			[Token(Token = "0x400044F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float releaseDistance;

			[Token(Token = "0x4000450")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool sliding;

			[Token(Token = "0x4000451")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private Vector3 raycastDirectionLocal;

			[Token(Token = "0x4000452")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private float raycastDistance;

			[Token(Token = "0x4000453")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private bool inTouch;

			[Token(Token = "0x4000454")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private RaycastHit hit;

			[Token(Token = "0x4000455")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 targetPosition;

			[Token(Token = "0x4000456")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private Quaternion targetRotation;

			[Token(Token = "0x4000457")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private bool initiated;

			[Token(Token = "0x4000458")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private float nextSwitchTime;

			[Token(Token = "0x4000459")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private float speedF;

			[Token(Token = "0x6000357")]
			[Address(RVA = "0x8CB484", Offset = "0x8CB484", VA = "0x8CB484")]
			public void Initiate(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000358")]
			[Address(RVA = "0x8CC058", Offset = "0x8CC058", VA = "0x8CC058")]
			private bool FindWalls(Vector3 direction)
			{
				return default(bool);
			}

			[Token(Token = "0x6000359")]
			[Address(RVA = "0x8CB88C", Offset = "0x8CB88C", VA = "0x8CB88C")]
			public void Update(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x600035A")]
			[Address(RVA = "0x8CC134", Offset = "0x8CC134", VA = "0x8CC134")]
			private void StopTouch(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x600035B")]
			[Address(RVA = "0x8CC218", Offset = "0x8CC218", VA = "0x8CC218")]
			private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x600035C")]
			[Address(RVA = "0x8CC2A4", Offset = "0x8CC2A4", VA = "0x8CC2A4")]
			private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x600035D")]
			[Address(RVA = "0x8CC32C", Offset = "0x8CC32C", VA = "0x8CC32C")]
			private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x600035E")]
			[Address(RVA = "0x8CBE44", Offset = "0x8CBE44", VA = "0x8CBE44")]
			public void Destroy(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x600035F")]
			[Address(RVA = "0x8CC3B4", Offset = "0x8CC3B4", VA = "0x8CC3B4")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x8CB420", Offset = "0x8CB420", VA = "0x8CB420")]
		private void Start()
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x8CB82C", Offset = "0x8CB82C", VA = "0x8CB82C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x8CBD94", Offset = "0x8CBD94", VA = "0x8CBD94")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x8CC050", Offset = "0x8CC050", VA = "0x8CC050")]
		public TouchWalls()
		{
		}
	}
	[Token(Token = "0x20000A9")]
	public class TransferMotion : MonoBehaviour
	{
		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The Transform to transfer motion to.")]
		public Transform to;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The amount of motion to transfer.")]
		[Range(0f, 1f)]
		public float transferMotion;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x8CC3E8", Offset = "0x8CC3E8", VA = "0x8CC3E8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x8CC418", Offset = "0x8CC418", VA = "0x8CC418")]
		private void Update()
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x8CC4C8", Offset = "0x8CC4C8", VA = "0x8CC4C8")]
		public TransferMotion()
		{
		}
	}
	[Token(Token = "0x20000AA")]
	public class TwoHandedProp : MonoBehaviour
	{
		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The left hand target parented to the right hand.")]
		public Transform leftHandTarget;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 targetPosRelativeToRight;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Quaternion targetRotRelativeToRight;

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x8CC4DC", Offset = "0x8CC4DC", VA = "0x8CC4DC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x8CC6F4", Offset = "0x8CC6F4", VA = "0x8CC6F4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x8CC990", Offset = "0x8CC990", VA = "0x8CC990")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x8CCA58", Offset = "0x8CCA58", VA = "0x8CCA58")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x8CCB84", Offset = "0x8CCB84", VA = "0x8CCB84")]
		public TwoHandedProp()
		{
		}
	}
	[Token(Token = "0x20000AB")]
	public class UserControlInteractions : UserControlThirdPerson
	{
		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CharacterThirdPerson character;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool disableInputInInteraction;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float enableInputAtProgress;

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x8CCB8C", Offset = "0x8CCB8C", VA = "0x8CCB8C", Slot = "4")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x8CCCA4", Offset = "0x8CCCA4", VA = "0x8CCCA4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x8CCE6C", Offset = "0x8CCE6C", VA = "0x8CCE6C")]
		public UserControlInteractions()
		{
		}
	}
	[Token(Token = "0x20000AC")]
	public class GrounderDemo : MonoBehaviour
	{
		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject[] characters;

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x8CCE88", Offset = "0x8CCE88", VA = "0x8CCE88")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x8CD090", Offset = "0x8CD090", VA = "0x8CD090")]
		public void Activate(int index)
		{
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x8CD0FC", Offset = "0x8CD0FC", VA = "0x8CD0FC")]
		public GrounderDemo()
		{
		}
	}
	[Token(Token = "0x20000AD")]
	public class PlatformRotator : MonoBehaviour
	{
		[Token(Token = "0x20000AE")]
		[CompilerGenerated]
		private sealed class <SwitchRotation>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000472")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000473")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000474")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PlatformRotator <>4__this;

			[Token(Token = "0x1700005D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000377")]
				[Address(RVA = "0x8CE86C", Offset = "0x8CE86C", VA = "0x8CE86C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700005E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000379")]
				[Address(RVA = "0x8CE8B4", Offset = "0x8CE8B4", VA = "0x8CE8B4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000374")]
			[Address(RVA = "0x8CE4F4", Offset = "0x8CE4F4", VA = "0x8CE4F4")]
			[DebuggerHidden]
			public <SwitchRotation>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x6000375")]
			[Address(RVA = "0x8CE6E4", Offset = "0x8CE6E4", VA = "0x8CE6E4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000376")]
			[Address(RVA = "0x8CE6E8", Offset = "0x8CE6E8", VA = "0x8CE6E8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000378")]
			[Address(RVA = "0x8CE874", Offset = "0x8CE874", VA = "0x8CE874", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxAngle;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float switchRotationTime;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float random;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float rotationSpeed;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 movePosition;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float moveSpeed;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int characterLayer;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion targetRotation;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 targetPosition;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 velocity;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Rigidbody r;

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x8CE104", Offset = "0x8CE104", VA = "0x8CE104")]
		private void Start()
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x8CE240", Offset = "0x8CE240", VA = "0x8CE240")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x8CE1CC", Offset = "0x8CE1CC", VA = "0x8CE1CC")]
		[IteratorStateMachine(typeof(<SwitchRotation>d__14))]
		private IEnumerator SwitchRotation()
		{
			return null;
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x8CE51C", Offset = "0x8CE51C", VA = "0x8CE51C")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x8CE5F4", Offset = "0x8CE5F4", VA = "0x8CE5F4")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x8CE6C8", Offset = "0x8CE6C8", VA = "0x8CE6C8")]
		public PlatformRotator()
		{
		}
	}
	[Token(Token = "0x20000AF")]
	public class BendGoal : MonoBehaviour
	{
		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbIK limbIK;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x8CE8BC", Offset = "0x8CE8BC", VA = "0x8CE8BC")]
		private void Start()
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x8CE924", Offset = "0x8CE924", VA = "0x8CE924")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x8CE9D0", Offset = "0x8CE9D0", VA = "0x8CE9D0")]
		public BendGoal()
		{
		}
	}
	[Token(Token = "0x20000B0")]
	public class Turret : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000B1")]
		public class Part
		{
			[Token(Token = "0x4000479")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x400047A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private RotationLimit rotationLimit;

			[Token(Token = "0x600037F")]
			[Address(RVA = "0x8CEA44", Offset = "0x8CEA44", VA = "0x8CEA44")]
			public void AimAt(Transform target)
			{
			}

			[Token(Token = "0x6000380")]
			[Address(RVA = "0x8CEB80", Offset = "0x8CEB80", VA = "0x8CEB80")]
			public Part()
			{
			}
		}

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Part[] parts;

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x8CE9E0", Offset = "0x8CE9E0", VA = "0x8CE9E0")]
		private void Update()
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x8CEB78", Offset = "0x8CEB78", VA = "0x8CEB78")]
		public Turret()
		{
		}
	}
	[Token(Token = "0x20000B2")]
	public class VRIKPlatform : MonoBehaviour
	{
		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 lastPosition;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion lastRotation;

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x8CEB88", Offset = "0x8CEB88", VA = "0x8CEB88")]
		private void Start()
		{
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x8CEBD8", Offset = "0x8CEBD8", VA = "0x8CEBD8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x8CEDB0", Offset = "0x8CEDB0", VA = "0x8CEDB0")]
		public VRIKPlatform()
		{
		}
	}
	[Token(Token = "0x20000B3")]
	public abstract class CharacterAnimationBase : MonoBehaviour
	{
		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool smoothFollow;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float smoothFollowSpeed;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 localPosition;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Quaternion localRotation;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Quaternion lastRotation;

		[Token(Token = "0x1700005F")]
		public virtual bool animationGrounded
		{
			[Token(Token = "0x6000385")]
			[Address(RVA = "0x8CEE28", Offset = "0x8CEE28", VA = "0x8CEE28", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x8CEE08", Offset = "0x8CEE08", VA = "0x8CEE08", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x8CEE30", Offset = "0x8CEE30", VA = "0x8CEE30")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x8CEE90", Offset = "0x8CEE90", VA = "0x8CEE90", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x8CF0FC", Offset = "0x8CF0FC", VA = "0x8CF0FC", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x8CF330", Offset = "0x8CF330", VA = "0x8CF330")]
		protected CharacterAnimationBase()
		{
		}
	}
	[Token(Token = "0x20000B4")]
	[RequireComponent(typeof(Animator))]
	public class CharacterAnimationSimple : CharacterAnimationBase
	{
		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CharacterThirdPerson characterController;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float pivotOffset;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private AnimationCurve moveSpeed;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Animator animator;

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x8CF348", Offset = "0x8CF348", VA = "0x8CF348", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x8CF3A8", Offset = "0x8CF3A8", VA = "0x8CF3A8", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x8CF438", Offset = "0x8CF438", VA = "0x8CF438")]
		private void Update()
		{
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x8CF55C", Offset = "0x8CF55C", VA = "0x8CF55C")]
		public CharacterAnimationSimple()
		{
		}
	}
	[Token(Token = "0x20000B5")]
	[RequireComponent(typeof(Animator))]
	public class CharacterAnimationThirdPerson : CharacterAnimationBase
	{
		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float turnSensitivity;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float turnSpeed;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float runCycleLegOffset;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		[Range(0.1f, 3f)]
		private float animSpeedMultiplier;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		protected Animator animator;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 lastForward;

		[Token(Token = "0x400048F")]
		private const string groundedDirectional = "Grounded Directional";

		[Token(Token = "0x4000490")]
		private const string groundedStrafe = "Grounded Strafe";

		[Token(Token = "0x17000060")]
		public override bool animationGrounded
		{
			[Token(Token = "0x6000390")]
			[Address(RVA = "0x8CF618", Offset = "0x8CF618", VA = "0x8CF618", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x8CF574", Offset = "0x8CF574", VA = "0x8CF574", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x8CF5FC", Offset = "0x8CF5FC", VA = "0x8CF5FC", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x8CF70C", Offset = "0x8CF70C", VA = "0x8CF70C", Slot = "8")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x8CFA6C", Offset = "0x8CFA6C", VA = "0x8CFA6C")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x8CFB04", Offset = "0x8CFB04", VA = "0x8CFB04")]
		public CharacterAnimationThirdPerson()
		{
		}
	}
	[Token(Token = "0x20000B6")]
	[RequireComponent(typeof(Rigidbody))]
	[RequireComponent(typeof(CapsuleCollider))]
	public abstract class CharacterBase : MonoBehaviour
	{
		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If specified, will use the direction from the character to this Transform as the gravity vector instead of Physics.gravity. Physics.gravity.magnitude will be used as the magnitude of the gravity vector.")]
		[Header("Base Parameters")]
		public Transform gravityTarget;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Multiplies gravity applied to the character even if 'Individual Gravity' is unchecked.")]
		[SerializeField]
		protected float gravityMultiplier;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		protected float airborneThreshold;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float slopeStartAngle;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float slopeEndAngle;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float spherecastRadius;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private LayerMask groundLayers;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private PhysicMaterial zeroFrictionMaterial;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private PhysicMaterial highFrictionMaterial;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected Rigidbody r;

		[Token(Token = "0x400049B")]
		protected const float half = 0.5f;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected float originalHeight;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		protected Vector3 originalCenter;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected CapsuleCollider capsule;

		[Token(Token = "0x6000394")]
		public abstract void Move(Vector3 deltaPosition, Quaternion deltaRotation);

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x8CFB28", Offset = "0x8CFB28", VA = "0x8CFB28")]
		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x8CFD14", Offset = "0x8CFD14", VA = "0x8CFD14", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x8CFF40", Offset = "0x8CFF40", VA = "0x8CFF40", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x8D00E0", Offset = "0x8D00E0", VA = "0x8D00E0")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x8D0140", Offset = "0x8D0140", VA = "0x8D0140")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x8D02A4", Offset = "0x8D02A4", VA = "0x8D02A4")]
		protected void ScaleCapsule(float mlp)
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x8D04A8", Offset = "0x8D04A8", VA = "0x8D04A8")]
		protected void HighFriction()
		{
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x8D04CC", Offset = "0x8D04CC", VA = "0x8D04CC")]
		protected void ZeroFriction()
		{
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x8D04F0", Offset = "0x8D04F0", VA = "0x8D04F0")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default(float);
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x8D063C", Offset = "0x8D063C", VA = "0x8D063C")]
		protected CharacterBase()
		{
		}
	}
	[Token(Token = "0x20000B7")]
	public class CharacterThirdPerson : CharacterBase
	{
		[Serializable]
		[Token(Token = "0x20000B8")]
		public enum MoveMode
		{
			[Token(Token = "0x40004D3")]
			Directional,
			[Token(Token = "0x40004D4")]
			Strafe
		}

		[Token(Token = "0x20000B9")]
		public struct AnimState
		{
			[Token(Token = "0x40004D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 moveDirection;

			[Token(Token = "0x40004D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public bool jump;

			[Token(Token = "0x40004D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
			public bool crouch;

			[Token(Token = "0x40004D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
			public bool onGround;

			[Token(Token = "0x40004D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
			public bool isStrafing;

			[Token(Token = "0x40004DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float yVelocity;
		}

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Header("References")]
		public CharacterAnimationBase characterAnimation;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public UserControlThirdPerson userControl;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public CameraController cam;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Header("Movement")]
		public MoveMode moveMode;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool smoothPhysics;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float smoothAccelerationTime;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float linearAccelerationSpeed;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float platformFriction;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float groundStickyEffect;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float maxVerticalVelocityOnGround;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float velocityToGroundTangentWeight;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[Header("Rotation")]
		public bool lookInCameraDirection;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float turnSpeed;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float stationaryTurnSpeedMlp;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[Header("Jumping and Falling")]
		public float airSpeed;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float airControl;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float jumpPower;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float jumpRepeatDelayTime;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[Header("Wall Running")]
		[SerializeField]
		private LayerMask wallRunLayers;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public float wallRunMaxLength;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float wallRunMinMoveMag;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public float wallRunMinVelocityY;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public float wallRunRotationSpeed;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public float wallRunMaxRotationAngle;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public float wallRunWeightSpeed;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[Header("Crouching")]
		public float crouchCapsuleScaleMlp;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public AnimState animState;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		protected Vector3 moveDirection;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Animator animator;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Vector3 normal;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Vector3 platformVelocity;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 platformAngularVelocity;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private RaycastHit hit;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private float jumpLeg;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		private float jumpEndTime;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private float forwardMlp;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private float groundDistance;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private float lastAirTime;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private float stickyForce;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private Vector3 wallNormal;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private Vector3 moveDirectionVelocity;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private float wallRunWeight;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		private float lastWallRunWeight;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private Vector3 fixedDeltaPosition;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		private Quaternion fixedDeltaRotation;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		private bool fixedFrame;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private float wallRunEndTime;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
		private Vector3 gravity;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private Vector3 verticalVelocity;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
		private float velocityY;

		[Token(Token = "0x17000061")]
		public bool onGround
		{
			[Token(Token = "0x600039F")]
			[Address(RVA = "0x8D065C", Offset = "0x8D065C", VA = "0x8D065C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003A0")]
			[Address(RVA = "0x8D0664", Offset = "0x8D0664", VA = "0x8D0664")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x8D0670", Offset = "0x8D0670", VA = "0x8D0670", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x8D0860", Offset = "0x8D0860", VA = "0x8D0860")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x8D08E4", Offset = "0x8D08E4", VA = "0x8D08E4", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x8D0994", Offset = "0x8D0994", VA = "0x8D0994")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x8D1998", Offset = "0x8D1998", VA = "0x8D1998", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x8D1E0C", Offset = "0x8D1E0C", VA = "0x8D1E0C", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x8D0FC0", Offset = "0x8D0FC0", VA = "0x8D0FC0")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x8D1EE4", Offset = "0x8D1EE4", VA = "0x8D1EE4")]
		private void WallRun()
		{
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x8D2570", Offset = "0x8D2570", VA = "0x8D2570")]
		private bool CanWallRun()
		{
			return default(bool);
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x8D1A24", Offset = "0x8D1A24", VA = "0x8D1A24")]
		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x8D2660", Offset = "0x8D2660", VA = "0x8D2660", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x8D2A84", Offset = "0x8D2A84", VA = "0x8D2A84")]
		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x8D2BAC", Offset = "0x8D2BAC", VA = "0x8D2BAC", Slot = "10")]
		protected virtual bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x8D1438", Offset = "0x8D1438", VA = "0x8D1438")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x8D2CDC", Offset = "0x8D2CDC", VA = "0x8D2CDC")]
		public CharacterThirdPerson()
		{
		}
	}
	[Token(Token = "0x20000BA")]
	[RequireComponent(typeof(Animator))]
	public class SimpleLocomotion : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000BB")]
		public enum RotationMode
		{
			[Token(Token = "0x40004E9")]
			Smooth,
			[Token(Token = "0x40004EA")]
			Linear
		}

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Tooltip("The component that updates the camera.")]
		private CameraController cameraController;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Tooltip("Acceleration of movement.")]
		private float accelerationTime;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		[Tooltip("Turning speed.")]
		private float turnTime;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("If true, will run on left shift, if not will walk on left shift.")]
		[SerializeField]
		private bool walkByDefault;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[Tooltip("Smooth or linear rotation.")]
		private RotationMode rotationMode;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Procedural motion speed (if not using root motion).")]
		[SerializeField]
		private float moveSpeed;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Animator animator;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float speed;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float angleVel;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float speedVel;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 linearTargetDirection;

		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private CharacterController characterController;

		[Token(Token = "0x17000062")]
		public bool isGrounded
		{
			[Token(Token = "0x60003B0")]
			[Address(RVA = "0x8D2DA0", Offset = "0x8D2DA0", VA = "0x8D2DA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003B1")]
			[Address(RVA = "0x8D2DA8", Offset = "0x8D2DA8", VA = "0x8D2DA8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x8D2DB4", Offset = "0x8D2DB4", VA = "0x8D2DB4")]
		private void Start()
		{
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x8D2E5C", Offset = "0x8D2E5C", VA = "0x8D2E5C")]
		private void Update()
		{
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x8D3474", Offset = "0x8D3474", VA = "0x8D3474")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x8D2EA4", Offset = "0x8D2EA4", VA = "0x8D2EA4")]
		private void Rotate()
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x8D320C", Offset = "0x8D320C", VA = "0x8D320C")]
		private void Move()
		{
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x8D34A4", Offset = "0x8D34A4", VA = "0x8D34A4")]
		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x8D353C", Offset = "0x8D353C", VA = "0x8D353C")]
		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x8D35BC", Offset = "0x8D35BC", VA = "0x8D35BC")]
		public SimpleLocomotion()
		{
		}
	}
	[Token(Token = "0x20000BC")]
	public class UserControlAI : UserControlThirdPerson
	{
		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform moveTarget;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float stoppingDistance;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float stoppingThreshold;

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x8D35E4", Offset = "0x8D35E4", VA = "0x8D35E4", Slot = "4")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x8D37A0", Offset = "0x8D37A0", VA = "0x8D37A0")]
		public UserControlAI()
		{
		}
	}
	[Token(Token = "0x20000BD")]
	public class UserControlThirdPerson : MonoBehaviour
	{
		[Token(Token = "0x20000BE")]
		public struct State
		{
			[Token(Token = "0x40004F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 move;

			[Token(Token = "0x40004F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 lookPos;

			[Token(Token = "0x40004F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool crouch;

			[Token(Token = "0x40004F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			public bool jump;

			[Token(Token = "0x40004F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int actionIndex;
		}

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool walkByDefault;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool canCrouch;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool canJump;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public State state;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected Transform cam;

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x8D37CC", Offset = "0x8D37CC", VA = "0x8D37CC")]
		private void Start()
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x8D3800", Offset = "0x8D3800", VA = "0x8D3800", Slot = "4")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x8D37BC", Offset = "0x8D37BC", VA = "0x8D37BC")]
		public UserControlThirdPerson()
		{
		}
	}
	[Token(Token = "0x20000BF")]
	public class ApplicationQuit : MonoBehaviour
	{
		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x8D3B44", Offset = "0x8D3B44", VA = "0x8D3B44")]
		private void Update()
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x8D3B7C", Offset = "0x8D3B7C", VA = "0x8D3B7C")]
		public ApplicationQuit()
		{
		}
	}
	[Token(Token = "0x20000C0")]
	public class SlowMo : MonoBehaviour
	{
		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private KeyCode[] keyCodes;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool mouse0;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[SerializeField]
		private bool mouse1;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float slowMoTimeScale;

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x8D3B84", Offset = "0x8D3B84", VA = "0x8D3B84")]
		private void Update()
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x8D3BAC", Offset = "0x8D3BAC", VA = "0x8D3BAC")]
		private bool IsSlowMotion()
		{
			return default(bool);
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x8D3C50", Offset = "0x8D3C50", VA = "0x8D3C50")]
		public SlowMo()
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x20000C1")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page2.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Biped IK")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x8D3C64", Offset = "0x8D3C64", VA = "0x8D3C64")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x8D3CA8", Offset = "0x8D3CA8", VA = "0x8D3CA8")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x8D3CEC", Offset = "0x8D3CEC", VA = "0x8D3CEC")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x8D3D30", Offset = "0x8D3D30", VA = "0x8D3D30")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x8D3D74", Offset = "0x8D3D74", VA = "0x8D3D74")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x8D3E0C", Offset = "0x8D3E0C", VA = "0x8D3E0C")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x8D3E28", Offset = "0x8D3E28", VA = "0x8D3E28")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x8D3E54", Offset = "0x8D3E54", VA = "0x8D3E54")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x8D3E80", Offset = "0x8D3E80", VA = "0x8D3E80")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x8D3EBC", Offset = "0x8D3EBC", VA = "0x8D3EBC")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x8D3EFC", Offset = "0x8D3EFC", VA = "0x8D3EFC")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x8D3F1C", Offset = "0x8D3F1C", VA = "0x8D3F1C")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x8D3F3C", Offset = "0x8D3F3C", VA = "0x8D3F3C")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x8D3F60", Offset = "0x8D3F60", VA = "0x8D3F60")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x8D3F88", Offset = "0x8D3F88", VA = "0x8D3F88")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x8D3FB0", Offset = "0x8D3FB0", VA = "0x8D3FB0")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x8D3D90", Offset = "0x8D3D90", VA = "0x8D3D90")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x8D3FD4", Offset = "0x8D3FD4", VA = "0x8D3FD4")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x8D3FE0", Offset = "0x8D3FE0", VA = "0x8D3FE0")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x8D3FEC", Offset = "0x8D3FEC", VA = "0x8D3FEC")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x8D42A0", Offset = "0x8D42A0", VA = "0x8D42A0", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x8D433C", Offset = "0x8D433C", VA = "0x8D433C", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x8D4668", Offset = "0x8D4668", VA = "0x8D4668", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x8D4AD4", Offset = "0x8D4AD4", VA = "0x8D4AD4")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x8D4AFC", Offset = "0x8D4AFC", VA = "0x8D4AFC")]
		public BipedIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000C2")]
	public class BipedIKSolvers
	{
		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IKSolverLimb leftFoot;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IKSolverLimb rightFoot;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IKSolverLimb leftHand;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IKSolverLimb rightHand;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolverFABRIK spine;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt lookAt;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverAim aim;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Constraints pelvis;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb[] _limbs;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private IKSolver[] _ikSolvers;

		[Token(Token = "0x17000063")]
		public IKSolverLimb[] limbs
		{
			[Token(Token = "0x60003DD")]
			[Address(RVA = "0x8D4128", Offset = "0x8D4128", VA = "0x8D4128")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000064")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x60003DE")]
			[Address(RVA = "0x8D4D94", Offset = "0x8D4D94", VA = "0x8D4D94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x8D44F4", Offset = "0x8D44F4", VA = "0x8D44F4")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x8D4BA8", Offset = "0x8D4BA8", VA = "0x8D4BA8")]
		public BipedIKSolvers()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000C3")]
	public abstract class Constraint
	{
		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float weight;

		[Token(Token = "0x17000065")]
		public bool isValid
		{
			[Token(Token = "0x60003E1")]
			[Address(RVA = "0x8D4FBC", Offset = "0x8D4FBC", VA = "0x8D4FBC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003E2")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x8D501C", Offset = "0x8D501C", VA = "0x8D501C")]
		protected Constraint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000C4")]
	public class ConstraintPosition : Constraint
	{
		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 position;

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x8D5024", Offset = "0x8D5024", VA = "0x8D5024", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x8D50BC", Offset = "0x8D50BC", VA = "0x8D50BC")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x8D50C4", Offset = "0x8D50C4", VA = "0x8D50C4")]
		public ConstraintPosition(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000C5")]
	public class ConstraintPositionOffset : Constraint
	{
		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 offset;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 defaultLocalPosition;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 lastLocalPosition;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool initiated;

		[Token(Token = "0x17000066")]
		private bool positionChanged
		{
			[Token(Token = "0x60003EA")]
			[Address(RVA = "0x8D51F8", Offset = "0x8D51F8", VA = "0x8D51F8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x8D50F4", Offset = "0x8D50F4", VA = "0x8D50F4", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x8D5254", Offset = "0x8D5254", VA = "0x8D5254")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x8D525C", Offset = "0x8D525C", VA = "0x8D525C")]
		public ConstraintPositionOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000C6")]
	public class ConstraintRotation : Constraint
	{
		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion rotation;

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x8D528C", Offset = "0x8D528C", VA = "0x8D528C", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x8D5308", Offset = "0x8D5308", VA = "0x8D5308")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x8D5310", Offset = "0x8D5310", VA = "0x8D5310")]
		public ConstraintRotation(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000C7")]
	public class ConstraintRotationOffset : Constraint
	{
		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion offset;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastLocalRotation;

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion defaultTargetLocalRotation;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool initiated;

		[Token(Token = "0x17000067")]
		private bool rotationChanged
		{
			[Token(Token = "0x60003F1")]
			[Address(RVA = "0x8D5444", Offset = "0x8D5444", VA = "0x8D5444")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x8D5340", Offset = "0x8D5340", VA = "0x8D5340", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x8D549C", Offset = "0x8D549C", VA = "0x8D549C")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x8D54A4", Offset = "0x8D54A4", VA = "0x8D54A4")]
		public ConstraintRotationOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000C8")]
	public class Constraints
	{
		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 positionOffset;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 position;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 1f)]
		public float positionWeight;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 rotationOffset;

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Range(0f, 1f)]
		public float rotationWeight;

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x8D54D4", Offset = "0x8D54D4", VA = "0x8D54D4")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x8D4614", Offset = "0x8D4614", VA = "0x8D4614")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x8D47DC", Offset = "0x8D47DC", VA = "0x8D47DC")]
		public void Update()
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x8D4FB4", Offset = "0x8D4FB4", VA = "0x8D4FB4")]
		public Constraints()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000C9")]
	public class Finger
	{
		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Tooltip("Master Weight for the finger.")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The first bone of the finger.")]
		public Transform bone1;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The second bone of the finger.")]
		public Transform bone2;

		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The (optional) third bone of the finger. This can be ignored for thumbs.")]
		public Transform bone3;

		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The fingertip object. If your character doesn't have tip bones, you can create an empty GameObject and parent it to the last bone in the finger. Place it to the tip of the finger.")]
		public Transform tip;

		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The IK target (optional, can use IKPosition and IKRotation directly).")]
		public Transform target;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private IKSolverLimb solver;

		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion bone3RelativeToTarget;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 bone3DefaultLocalPosition;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Quaternion bone3DefaultLocalRotation;

		[Token(Token = "0x17000068")]
		public bool initiated
		{
			[Token(Token = "0x60003F6")]
			[Address(RVA = "0x8D5534", Offset = "0x8D5534", VA = "0x8D5534")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003F7")]
			[Address(RVA = "0x8D553C", Offset = "0x8D553C", VA = "0x8D553C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000069")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x60003F8")]
			[Address(RVA = "0x8D5548", Offset = "0x8D5548", VA = "0x8D5548")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60003F9")]
			[Address(RVA = "0x8D5568", Offset = "0x8D5568", VA = "0x8D5568")]
			set
			{
			}
		}

		[Token(Token = "0x1700006A")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x60003FA")]
			[Address(RVA = "0x8D5588", Offset = "0x8D5588", VA = "0x8D5588")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x60003FB")]
			[Address(RVA = "0x8D55A8", Offset = "0x8D55A8", VA = "0x8D55A8")]
			set
			{
			}
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x8D55C8", Offset = "0x8D55C8", VA = "0x8D55C8")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x8D56C0", Offset = "0x8D56C0", VA = "0x8D56C0")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x8D5954", Offset = "0x8D5954", VA = "0x8D5954")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x8D5A14", Offset = "0x8D5A14", VA = "0x8D5A14")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x8D5C9C", Offset = "0x8D5C9C", VA = "0x8D5C9C")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x20000CA")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Range(0f, 1f)]
		[Tooltip("The master weight for all fingers.")]
		public float weight;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Finger[] fingers;

		[Token(Token = "0x1700006B")]
		public bool initiated
		{
			[Token(Token = "0x6000401")]
			[Address(RVA = "0x8D5CAC", Offset = "0x8D5CAC", VA = "0x8D5CAC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000402")]
			[Address(RVA = "0x8D5CB4", Offset = "0x8D5CB4", VA = "0x8D5CB4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x8D5CC0", Offset = "0x8D5CC0", VA = "0x8D5CC0")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x8D5D34", Offset = "0x8D5D34", VA = "0x8D5D34")]
		[ContextMenu("Auto-detect")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x8D6098", Offset = "0x8D6098", VA = "0x8D6098")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x8D6250", Offset = "0x8D6250", VA = "0x8D6250")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x8D5FA8", Offset = "0x8D5FA8", VA = "0x8D5FA8")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x8D63D0", Offset = "0x8D63D0", VA = "0x8D63D0", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x8D6478", Offset = "0x8D6478", VA = "0x8D6478")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x8D64E8", Offset = "0x8D64E8", VA = "0x8D64E8")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x8D6544", Offset = "0x8D6544", VA = "0x8D6544", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x8D6548", Offset = "0x8D6548", VA = "0x8D6548", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x8D654C", Offset = "0x8D654C", VA = "0x8D654C")]
		public FingerRig()
		{
		}
	}
	[Token(Token = "0x20000CB")]
	public abstract class Grounder : MonoBehaviour
	{
		[Token(Token = "0x20000CC")]
		public delegate void GrounderDelegate();

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The master weight. Use this to fade in/out the grounding effect.")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The Grounding solver. Not to confuse with IK solvers.")]
		public Grounding solver;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GrounderDelegate OnPreGrounder;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GrounderDelegate OnPostGrounder;

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected bool initiated;

		[Token(Token = "0x600040E")]
		public abstract void ResetPosition();

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x8D65B8", Offset = "0x8D65B8", VA = "0x8D65B8")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x8D6868", Offset = "0x8D6868", VA = "0x8D6868")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x8D667C", Offset = "0x8D667C", VA = "0x8D667C")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x8D6890", Offset = "0x8D6890", VA = "0x8D6890")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000413")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000414")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x8D6A04", Offset = "0x8D6A04", VA = "0x8D6A04")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x20000CD")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page11.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Biped")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The BipedIK componet.")]
		public BipedIK ik;

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The amount of spine bending towards upward slopes.")]
		public float spineBend;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("The interpolation speed of spine bending.")]
		public float spineSpeed;

		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform[] feet;

		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion[] footRotations;

		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 spineOffset;

		[Token(Token = "0x4000539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float lastWeight;

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x8D6BEC", Offset = "0x8D6BEC", VA = "0x8D6BEC", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x8D6C30", Offset = "0x8D6C30", VA = "0x8D6C30", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x8D6C74", Offset = "0x8D6C74", VA = "0x8D6C74", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x8D6D54", Offset = "0x8D6D54", VA = "0x8D6D54")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x8D6DF4", Offset = "0x8D6DF4", VA = "0x8D6DF4")]
		private void Update()
		{
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x8D6E48", Offset = "0x8D6E48", VA = "0x8D6E48")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x8D7468", Offset = "0x8D7468", VA = "0x8D7468")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x8D74A8", Offset = "0x8D74A8", VA = "0x8D74A8")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x8D7AF4", Offset = "0x8D7AF4", VA = "0x8D7AF4")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x8D7C1C", Offset = "0x8D7C1C", VA = "0x8D7C1C")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x8D7DEC", Offset = "0x8D7DEC", VA = "0x8D7DEC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x8D7FC4", Offset = "0x8D7FC4", VA = "0x8D7FC4")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x20000CE")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Full Body Biped")]
	[HelpURL("https://www.youtube.com/watch?v=9MiZiaJorws&index=6&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x20000CF")]
		public class SpineEffector
		{
			[Token(Token = "0x4000541")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The type of the effector.")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000542")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("The weight of horizontal bend offset towards the slope.")]
			public float horizontalWeight;

			[Token(Token = "0x4000543")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The vertical bend offset weight.")]
			public float verticalWeight;

			[Token(Token = "0x6000434")]
			[Address(RVA = "0x8D8D14", Offset = "0x8D8D14", VA = "0x8D8D14")]
			public SpineEffector()
			{
			}
		}

		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Reference to the FBBIK componet.")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400053B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The amount of spine bending towards upward slopes.")]
		public float spineBend;

		[Token(Token = "0x400053C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("The interpolation speed of spine bending.")]
		public float spineSpeed;

		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public SpineEffector[] spine;

		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] feet;

		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 spineOffset;

		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool firstSolve;

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x8D8068", Offset = "0x8D8068", VA = "0x8D8068")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x8D80AC", Offset = "0x8D80AC", VA = "0x8D80AC", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x8D80F0", Offset = "0x8D80F0", VA = "0x8D80F0", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x8D8134", Offset = "0x8D8134", VA = "0x8D8134", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x8D819C", Offset = "0x8D819C", VA = "0x8D819C")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x8D8224", Offset = "0x8D8224", VA = "0x8D8224")]
		private void Update()
		{
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x8D84D0", Offset = "0x8D84D0", VA = "0x8D84D0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x8D84DC", Offset = "0x8D84DC", VA = "0x8D84DC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x8D8280", Offset = "0x8D8280", VA = "0x8D8280")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x8D84E8", Offset = "0x8D84E8", VA = "0x8D84E8")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x8D8858", Offset = "0x8D8858", VA = "0x8D8858")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x8D89DC", Offset = "0x8D89DC", VA = "0x8D89DC")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x8D8B3C", Offset = "0x8D8B3C", VA = "0x8D8B3C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x8D8C70", Offset = "0x8D8C70", VA = "0x8D8C70")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x20000D0")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page11.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder IK")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IK[] legs;

		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The pelvis transform. Common ancestor of all the legs.")]
		public Transform pelvis;

		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("The root Transform of the character, with the rigidbody and the collider.")]
		public Transform characterRoot;

		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Range(0f, 1f)]
		[Tooltip("The weight of rotating the character root to the ground normal (range: 0 - 1).")]
		public float rootRotationWeight;

		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Tooltip("The speed of rotating the character root to the ground normal (range: 0 - inf).")]
		public float rootRotationSpeed;

		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("The maximum angle of root rotation (range: 0 - 90).")]
		public float maxRootRotationAngle;

		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform[] feet;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] footRotations;

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int solvedFeet;

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool solved;

		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float lastWeight;

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x8D8D24", Offset = "0x8D8D24", VA = "0x8D8D24", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x8D8D68", Offset = "0x8D8D68", VA = "0x8D8D68", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x8D8DAC", Offset = "0x8D8DAC", VA = "0x8D8DAC", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x8D8DC4", Offset = "0x8D8DC4", VA = "0x8D8DC4")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x8D8FE4", Offset = "0x8D8FE4", VA = "0x8D8FE4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x8D90C4", Offset = "0x8D90C4", VA = "0x8D90C4")]
		private void Update()
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x8D96EC", Offset = "0x8D96EC", VA = "0x8D96EC")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x8D9B70", Offset = "0x8D9B70", VA = "0x8D9B70")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x8D9D1C", Offset = "0x8D9D1C", VA = "0x8D9D1C")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x8DA0A4", Offset = "0x8DA0A4", VA = "0x8DA0A4")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x8DA278", Offset = "0x8DA278", VA = "0x8DA278")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x8DA4A0", Offset = "0x8DA4A0", VA = "0x8DA4A0")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x20000D1")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page11.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Quadruped")]
	public class GrounderQuadruped : Grounder
	{
		[Token(Token = "0x20000D2")]
		public struct Foot
		{
			[Token(Token = "0x400056D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IKSolver solver;

			[Token(Token = "0x400056E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform transform;

			[Token(Token = "0x400056F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Quaternion rotation;

			[Token(Token = "0x4000570")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Grounding.Leg leg;

			[Token(Token = "0x6000453")]
			[Address(RVA = "0x8DB060", Offset = "0x8DB060", VA = "0x8DB060")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x4000551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The Grounding solver for the forelegs.")]
		public Grounding forelegSolver;

		[Token(Token = "0x4000552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Range(0f, 1f)]
		[Tooltip("The weight of rotating the character root to the ground angle (range: 0 - 1).")]
		public float rootRotationWeight;

		[Token(Token = "0x4000553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("The maximum angle of rotating the quadruped downwards (going downhill, range: -90 - 0).")]
		[Range(-90f, 0f)]
		public float minRootRotation;

		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("The maximum angle of rotating the quadruped upwards (going uphill, range: 0 - 90).")]
		[Range(0f, 90f)]
		public float maxRootRotation;

		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Tooltip("The speed of interpolating the character root rotation (range: 0 - inf).")]
		public float rootRotationSpeed;

		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("The maximum IK offset for the legs (range: 0 - inf).")]
		public float maxLegOffset;

		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Tooltip("The maximum IK offset for the forelegs (range: 0 - inf).")]
		public float maxForeLegOffset;

		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Range(0f, 1f)]
		[Tooltip("The weight of maintaining the head's rotation as it was before solving the Grounding (range: 0 - 1).")]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("The root Transform of the character, with the rigidbody and the collider.")]
		public Transform characterRoot;

		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Tooltip("The pelvis transform. Common ancestor of both legs and the spine.")]
		public Transform pelvis;

		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Tooltip("The last bone in the spine that is the common parent for both forelegs.")]
		public Transform lastSpineBone;

		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Tooltip("The head (optional, if you intend to maintain it's rotation).")]
		public Transform head;

		[Token(Token = "0x400055D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IK[] legs;

		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IK[] forelegs;

		[Token(Token = "0x400055F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public Vector3 gravity;

		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Foot[] feet;

		[Token(Token = "0x4000561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Quaternion animatedPelvisLocalRotation;

		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private Quaternion animatedHeadLocalRotation;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x4000565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Quaternion solvedPelvisLocalRotation;

		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion solvedHeadLocalRotation;

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private int solvedFeet;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private bool solved;

		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private float angle;

		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Transform forefeetRoot;

		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Quaternion headRotation;

		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private float lastWeight;

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x8DA544", Offset = "0x8DA544", VA = "0x8DA544", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x8DA588", Offset = "0x8DA588", VA = "0x8DA588", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x8DA5CC", Offset = "0x8DA5CC", VA = "0x8DA5CC", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x8DA5F4", Offset = "0x8DA5F4", VA = "0x8DA5F4")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x8DA6F8", Offset = "0x8DA6F8", VA = "0x8DA6F8")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x8DA8F0", Offset = "0x8DA8F0", VA = "0x8DA8F0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x8DA954", Offset = "0x8DA954", VA = "0x8DA954")]
		private void Update()
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x8DA9AC", Offset = "0x8DA9AC", VA = "0x8DA9AC")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x8DACC4", Offset = "0x8DACC4", VA = "0x8DACC4")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x8DB0C0", Offset = "0x8DB0C0", VA = "0x8DB0C0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x8DB150", Offset = "0x8DB150", VA = "0x8DB150")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x8DB450", Offset = "0x8DB450", VA = "0x8DB450")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x8DBB10", Offset = "0x8DBB10", VA = "0x8DBB10")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x8DBDC8", Offset = "0x8DBDC8", VA = "0x8DBDC8")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x8DBEFC", Offset = "0x8DBEFC", VA = "0x8DBEFC")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x8DC1C4", Offset = "0x8DC1C4", VA = "0x8DC1C4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x8DC1F4", Offset = "0x8DC1F4", VA = "0x8DC1F4")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x8DC414", Offset = "0x8DC414", VA = "0x8DC414")]
		public GrounderQuadruped()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000D3")]
	public class Grounding
	{
		[Serializable]
		[Token(Token = "0x20000D4")]
		public enum Quality
		{
			[Token(Token = "0x4000589")]
			Fastest,
			[Token(Token = "0x400058A")]
			Simple,
			[Token(Token = "0x400058B")]
			Best
		}

		[Token(Token = "0x20000D5")]
		public class Leg
		{
			[Token(Token = "0x400058E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Quaternion rotationOffset;

			[Token(Token = "0x4000594")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public bool invertFootCenter;

			[Token(Token = "0x4000595")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Grounding grounding;

			[Token(Token = "0x4000596")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private float lastTime;

			[Token(Token = "0x4000597")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			private float deltaTime;

			[Token(Token = "0x4000598")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private Vector3 lastPosition;

			[Token(Token = "0x4000599")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion toHitNormal;

			[Token(Token = "0x400059A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Quaternion r;

			[Token(Token = "0x400059B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			private RaycastHit heelHit;

			[Token(Token = "0x400059C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private Vector3 up;

			[Token(Token = "0x17000074")]
			public bool isGrounded
			{
				[Token(Token = "0x600046C")]
				[Address(RVA = "0x8DD868", Offset = "0x8DD868", VA = "0x8DD868")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600046D")]
				[Address(RVA = "0x8DD870", Offset = "0x8DD870", VA = "0x8DD870")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000075")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x600046E")]
				[Address(RVA = "0x8DD87C", Offset = "0x8DD87C", VA = "0x8DD87C")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600046F")]
				[Address(RVA = "0x8DD888", Offset = "0x8DD888", VA = "0x8DD888")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000076")]
			public bool initiated
			{
				[Token(Token = "0x6000470")]
				[Address(RVA = "0x8DD894", Offset = "0x8DD894", VA = "0x8DD894")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000471")]
				[Address(RVA = "0x8DD89C", Offset = "0x8DD89C", VA = "0x8DD89C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000077")]
			public float heightFromGround
			{
				[Token(Token = "0x6000472")]
				[Address(RVA = "0x8DD8A8", Offset = "0x8DD8A8", VA = "0x8DD8A8")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000473")]
				[Address(RVA = "0x8DD8B0", Offset = "0x8DD8B0", VA = "0x8DD8B0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000078")]
			public Vector3 velocity
			{
				[Token(Token = "0x6000474")]
				[Address(RVA = "0x8DD8B8", Offset = "0x8DD8B8", VA = "0x8DD8B8")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000475")]
				[Address(RVA = "0x8DD8C4", Offset = "0x8DD8C4", VA = "0x8DD8C4")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000079")]
			public Transform transform
			{
				[Token(Token = "0x6000476")]
				[Address(RVA = "0x8DD8D0", Offset = "0x8DD8D0", VA = "0x8DD8D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000477")]
				[Address(RVA = "0x8DD8D8", Offset = "0x8DD8D8", VA = "0x8DD8D8")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700007A")]
			public float IKOffset
			{
				[Token(Token = "0x6000478")]
				[Address(RVA = "0x8DD8E0", Offset = "0x8DD8E0", VA = "0x8DD8E0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000479")]
				[Address(RVA = "0x8DD8E8", Offset = "0x8DD8E8", VA = "0x8DD8E8")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700007B")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x600047E")]
				[Address(RVA = "0x8DDEAC", Offset = "0x8DDEAC", VA = "0x8DDEAC")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x1700007C")]
			private float rootYOffset
			{
				[Token(Token = "0x6000487")]
				[Address(RVA = "0x8DE020", Offset = "0x8DE020", VA = "0x8DE020")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x600047A")]
			[Address(RVA = "0x8DCA1C", Offset = "0x8DCA1C", VA = "0x8DCA1C")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x600047B")]
			[Address(RVA = "0x8DD8F0", Offset = "0x8DD8F0", VA = "0x8DD8F0")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x600047C")]
			[Address(RVA = "0x8DD4D8", Offset = "0x8DD4D8", VA = "0x8DD4D8")]
			public void Reset()
			{
			}

			[Token(Token = "0x600047D")]
			[Address(RVA = "0x8DCB30", Offset = "0x8DCB30", VA = "0x8DCB30")]
			public void Process()
			{
			}

			[Token(Token = "0x600047F")]
			[Address(RVA = "0x8DDC2C", Offset = "0x8DDC2C", VA = "0x8DDC2C")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x6000480")]
			[Address(RVA = "0x8DD930", Offset = "0x8DD930", VA = "0x8DD930")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x6000481")]
			[Address(RVA = "0x8DDF40", Offset = "0x8DDF40", VA = "0x8DDF40")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000482")]
			[Address(RVA = "0x8DDA90", Offset = "0x8DDA90", VA = "0x8DDA90")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x6000483")]
			[Address(RVA = "0x8DDB10", Offset = "0x8DDB10", VA = "0x8DDB10")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x6000484")]
			[Address(RVA = "0x8DDFAC", Offset = "0x8DDFAC", VA = "0x8DDFAC")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x6000485")]
			[Address(RVA = "0x8DDEE0", Offset = "0x8DDEE0", VA = "0x8DDEE0")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x6000486")]
			[Address(RVA = "0x8DE0C4", Offset = "0x8DE0C4", VA = "0x8DE0C4")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000488")]
			[Address(RVA = "0x8DC97C", Offset = "0x8DC97C", VA = "0x8DC97C")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x20000D6")]
		public class Pelvis
		{
			[Token(Token = "0x400059F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Grounding grounding;

			[Token(Token = "0x40005A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 lastRootPosition;

			[Token(Token = "0x40005A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float damperF;

			[Token(Token = "0x40005A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private bool initiated;

			[Token(Token = "0x40005A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float lastTime;

			[Token(Token = "0x1700007D")]
			public Vector3 IKOffset
			{
				[Token(Token = "0x6000489")]
				[Address(RVA = "0x8DE274", Offset = "0x8DE274", VA = "0x8DE274")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600048A")]
				[Address(RVA = "0x8DE280", Offset = "0x8DE280", VA = "0x8DE280")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700007E")]
			public float heightOffset
			{
				[Token(Token = "0x600048B")]
				[Address(RVA = "0x8DE28C", Offset = "0x8DE28C", VA = "0x8DE28C")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600048C")]
				[Address(RVA = "0x8DE294", Offset = "0x8DE294", VA = "0x8DE294")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x600048D")]
			[Address(RVA = "0x8DCAF4", Offset = "0x8DCAF4", VA = "0x8DCAF4")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x600048E")]
			[Address(RVA = "0x8DD444", Offset = "0x8DD444", VA = "0x8DD444")]
			public void Reset()
			{
			}

			[Token(Token = "0x600048F")]
			[Address(RVA = "0x8DE29C", Offset = "0x8DE29C", VA = "0x8DE29C")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x6000490")]
			[Address(RVA = "0x8DD258", Offset = "0x8DD258", VA = "0x8DD258")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x6000491")]
			[Address(RVA = "0x8DCA14", Offset = "0x8DCA14", VA = "0x8DCA14")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x4000571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Tooltip("Layers to ground the character to. Make sure to exclude the layer of the character controller.")]
		public LayerMask layers;

		[Token(Token = "0x4000572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Tooltip("Max step height. Maximum vertical distance of Grounding from the root of the character.")]
		public float maxStep;

		[Token(Token = "0x4000573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The height offset of the root.")]
		public float heightOffset;

		[Token(Token = "0x4000574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("The speed of moving the feet up/down.")]
		public float footSpeed;

		[Token(Token = "0x4000575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("CapsuleCast radius. Should match approximately with the size of the feet.")]
		public float footRadius;

		[Token(Token = "0x4000576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[HideInInspector]
		[Tooltip("Offset of the foot center along character forward axis.")]
		public float footCenterOffset;

		[Token(Token = "0x4000577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Amount of velocity based prediction of the foot positions.")]
		public float prediction;

		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0f, 1f)]
		[Tooltip("Weight of rotating the feet to the ground normal offset.")]
		public float footRotationWeight;

		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Speed of slerping the feet to their grounded rotations.")]
		public float footRotationSpeed;

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Range(0f, 90f)]
		[Tooltip("Max Foot Rotation Angle. Max angular offset from the foot's rotation.")]
		public float maxFootRotationAngle;

		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("If true, solver will rotate with the character root so the character can be grounded for example to spherical planets. For performance reasons leave this off unless needed.")]
		public bool rotateSolver;

		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("The speed of moving the character up/down.")]
		public float pelvisSpeed;

		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Range(0f, 1f)]
		[Tooltip("Used for smoothing out vertical pelvis movement (range 0 - 1).")]
		public float pelvisDamper;

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("The weight of lowering the pelvis to the lowest foot.")]
		public float lowerPelvisWeight;

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The weight of lifting the pelvis to the highest foot. This is useful when you don't want the feet to go too high relative to the body when crouching.")]
		public float liftPelvisWeight;

		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("The radius of the spherecast from the root that determines whether the character root is grounded.")]
		public float rootSphereCastRadius;

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("The raycasting quality. Fastest is a single raycast per foot, Simple is three raycasts, Best is one raycast and a capsule cast per foot.")]
		public Quality quality;

		[Token(Token = "0x4000587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool initiated;

		[Token(Token = "0x1700006C")]
		public Leg[] legs
		{
			[Token(Token = "0x6000454")]
			[Address(RVA = "0x8DC558", Offset = "0x8DC558", VA = "0x8DC558")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000455")]
			[Address(RVA = "0x8DC560", Offset = "0x8DC560", VA = "0x8DC560")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700006D")]
		public Pelvis pelvis
		{
			[Token(Token = "0x6000456")]
			[Address(RVA = "0x8DC568", Offset = "0x8DC568", VA = "0x8DC568")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000457")]
			[Address(RVA = "0x8DC570", Offset = "0x8DC570", VA = "0x8DC570")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700006E")]
		public bool isGrounded
		{
			[Token(Token = "0x6000458")]
			[Address(RVA = "0x8DC578", Offset = "0x8DC578", VA = "0x8DC578")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000459")]
			[Address(RVA = "0x8DC580", Offset = "0x8DC580", VA = "0x8DC580")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700006F")]
		public Transform root
		{
			[Token(Token = "0x600045A")]
			[Address(RVA = "0x8DC58C", Offset = "0x8DC58C", VA = "0x8DC58C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600045B")]
			[Address(RVA = "0x8DC594", Offset = "0x8DC594", VA = "0x8DC594")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000070")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x600045C")]
			[Address(RVA = "0x8DC59C", Offset = "0x8DC59C", VA = "0x8DC59C")]
			[CompilerGenerated]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x600045D")]
			[Address(RVA = "0x8DC5B4", Offset = "0x8DC5B4", VA = "0x8DC5B4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000071")]
		public bool rootGrounded
		{
			[Token(Token = "0x600045E")]
			[Address(RVA = "0x8DC5D4", Offset = "0x8DC5D4", VA = "0x8DC5D4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000072")]
		public Vector3 up
		{
			[Token(Token = "0x6000466")]
			[Address(RVA = "0x8D7BB4", Offset = "0x8D7BB4", VA = "0x8D7BB4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000073")]
		private bool useRootRotation
		{
			[Token(Token = "0x6000469")]
			[Address(RVA = "0x8DD56C", Offset = "0x8DD56C", VA = "0x8DD56C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x8DC61C", Offset = "0x8DC61C", VA = "0x8DC61C")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x8DC874", Offset = "0x8DC874", VA = "0x8DC874")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x8D71A4", Offset = "0x8D71A4", VA = "0x8D71A4")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x8D7900", Offset = "0x8D7900", VA = "0x8D7900")]
		public void Update()
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x8D9574", Offset = "0x8D9574", VA = "0x8D9574")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x8D6CDC", Offset = "0x8D6CDC", VA = "0x8D6CDC")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x8DCB18", Offset = "0x8DCB18", VA = "0x8DCB18")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x8DD620", Offset = "0x8DD620", VA = "0x8DD620")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x8DD6A4", Offset = "0x8DD6A4", VA = "0x8DD6A4")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x8DD7F8", Offset = "0x8DD7F8", VA = "0x8DD7F8")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x8D6ABC", Offset = "0x8D6ABC", VA = "0x8D6ABC")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x20000D7")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Aim IK")]
	[HelpURL("https://www.youtube.com/watch?v=wT8fViZpLmQ&index=3&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	public class AimIK : IK
	{
		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverAim solver;

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x8DE2F0", Offset = "0x8DE2F0", VA = "0x8DE2F0", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x8DE334", Offset = "0x8DE334", VA = "0x8DE334", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x8DE378", Offset = "0x8DE378", VA = "0x8DE378")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x8DE3BC", Offset = "0x8DE3BC", VA = "0x8DE3BC")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x8DE400", Offset = "0x8DE400", VA = "0x8DE400")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x8DE444", Offset = "0x8DE444", VA = "0x8DE444", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x8DE44C", Offset = "0x8DE44C", VA = "0x8DE44C")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x20000D8")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page3.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/CCD IK")]
	public class CCDIK : IK
	{
		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverCCD solver;

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x8DE4C8", Offset = "0x8DE4C8", VA = "0x8DE4C8", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x8DE50C", Offset = "0x8DE50C", VA = "0x8DE50C", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x8DE550", Offset = "0x8DE550", VA = "0x8DE550")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x8DE594", Offset = "0x8DE594", VA = "0x8DE594")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x8DE5D8", Offset = "0x8DE5D8", VA = "0x8DE5D8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x8DE5E0", Offset = "0x8DE5E0", VA = "0x8DE5E0")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x20000D9")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page4.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/FABRIK")]
	public class FABRIK : IK
	{
		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x8DE654", Offset = "0x8DE654", VA = "0x8DE654", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x8DE698", Offset = "0x8DE698", VA = "0x8DE698", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x8DE6DC", Offset = "0x8DE6DC", VA = "0x8DE6DC")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x8DE720", Offset = "0x8DE720", VA = "0x8DE720")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x8DE764", Offset = "0x8DE764", VA = "0x8DE764", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x8DE76C", Offset = "0x8DE76C", VA = "0x8DE76C")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x20000DA")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/FABRIK Root")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page5.html")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x8DE7E0", Offset = "0x8DE7E0", VA = "0x8DE7E0", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x8DE824", Offset = "0x8DE824", VA = "0x8DE824", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x8DE868", Offset = "0x8DE868", VA = "0x8DE868")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x8DE8AC", Offset = "0x8DE8AC", VA = "0x8DE8AC")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x8DE8F0", Offset = "0x8DE8F0", VA = "0x8DE8F0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x8DE8F8", Offset = "0x8DE8F8", VA = "0x8DE8F8")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x20000DB")]
	[HelpURL("https://www.youtube.com/watch?v=7__IafZGwvI&index=1&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Full Body Biped IK")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x40005A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x8DE96C", Offset = "0x8DE96C", VA = "0x8DE96C", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x8DE9B0", Offset = "0x8DE9B0", VA = "0x8DE9B0", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x8DE9F4", Offset = "0x8DE9F4", VA = "0x8DE9F4")]
		[ContextMenu("TUTORIAL VIDEO (SETUP)")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x8DEA38", Offset = "0x8DEA38", VA = "0x8DEA38")]
		[ContextMenu("TUTORIAL VIDEO (INSPECTOR)")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x8DEA7C", Offset = "0x8DEA7C", VA = "0x8DEA7C")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x8DEAC0", Offset = "0x8DEAC0", VA = "0x8DEAC0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x8DEB04", Offset = "0x8DEB04", VA = "0x8DEB04")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x8DEB44", Offset = "0x8DEB44", VA = "0x8DEB44", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x8DEB4C", Offset = "0x8DEB4C", VA = "0x8DEB4C")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x8DED1C", Offset = "0x8DED1C", VA = "0x8DED1C")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x8DF1D8", Offset = "0x8DF1D8", VA = "0x8DF1D8")]
		[ContextMenu("Reinitiate")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x8DF1F8", Offset = "0x8DF1F8", VA = "0x8DF1F8")]
		[ContextMenu("Auto-detect References")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x8DF2E8", Offset = "0x8DF2E8", VA = "0x8DF2E8")]
		public FullBodyBipedIK()
		{
		}
	}
	[Token(Token = "0x20000DC")]
	public abstract class IK : SolverManager
	{
		[Token(Token = "0x60004B8")]
		public abstract IKSolver GetIKSolver();

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x8DF398", Offset = "0x8DF398", VA = "0x8DF398", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x8DF410", Offset = "0x8DF410", VA = "0x8DF410", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x8DF480", Offset = "0x8DF480", VA = "0x8DF480", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60004BC")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x60004BD")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x8DE4C0", Offset = "0x8DE4C0", VA = "0x8DE4C0")]
		protected IK()
		{
		}
	}
	[Token(Token = "0x20000DD")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x40005AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The IK components, assign in the order in which you wish to update them.")]
		public IK[] IKComponents;

		[Token(Token = "0x40005AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Optional. Assign it if you are using 'Animate Physics' as the Update Mode.")]
		public Animator animator;

		[Token(Token = "0x40005AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool fixedFrame;

		[Token(Token = "0x1700007F")]
		private bool animatePhysics
		{
			[Token(Token = "0x60004BF")]
			[Address(RVA = "0x8DF4D0", Offset = "0x8DF4D0", VA = "0x8DF4D0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x8DF55C", Offset = "0x8DF55C", VA = "0x8DF55C")]
		private void Start()
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x8DF5C0", Offset = "0x8DF5C0", VA = "0x8DF5C0")]
		private void Update()
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x8DF660", Offset = "0x8DF660", VA = "0x8DF660")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x8DF68C", Offset = "0x8DF68C", VA = "0x8DF68C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x8DF5E4", Offset = "0x8DF5E4", VA = "0x8DF5E4")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x8DF710", Offset = "0x8DF710", VA = "0x8DF710")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x20000DE")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Leg IK")]
	public class LegIK : IK
	{
		[Token(Token = "0x40005AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLeg solver;

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x8DF718", Offset = "0x8DF718", VA = "0x8DF718", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x8DF780", Offset = "0x8DF780", VA = "0x8DF780", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x8DF7E8", Offset = "0x8DF7E8", VA = "0x8DF7E8")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x8DF82C", Offset = "0x8DF82C", VA = "0x8DF82C")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x8DF870", Offset = "0x8DF870", VA = "0x8DF870", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x8DF878", Offset = "0x8DF878", VA = "0x8DF878")]
		public LegIK()
		{
		}
	}
	[Token(Token = "0x20000DF")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Limb IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page7.html")]
	public class LimbIK : IK
	{
		[Token(Token = "0x40005AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLimb solver;

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x8DF8EC", Offset = "0x8DF8EC", VA = "0x8DF8EC", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x8DF930", Offset = "0x8DF930", VA = "0x8DF930", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x8DF974", Offset = "0x8DF974", VA = "0x8DF974")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x8DF9B8", Offset = "0x8DF9B8", VA = "0x8DF9B8")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x8DF9FC", Offset = "0x8DF9FC", VA = "0x8DF9FC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x8DFA04", Offset = "0x8DFA04", VA = "0x8DFA04")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x20000E0")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Look At IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page8.html")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x40005AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt solver;

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x8DFA78", Offset = "0x8DFA78", VA = "0x8DFA78", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x8DFABC", Offset = "0x8DFABC", VA = "0x8DFABC", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x8DFB00", Offset = "0x8DFB00", VA = "0x8DFB00")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x8DFB44", Offset = "0x8DFB44", VA = "0x8DFB44")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x8DFB88", Offset = "0x8DFB88", VA = "0x8DFB88", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x8DFB90", Offset = "0x8DFB90", VA = "0x8DFB90")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x20000E1")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Trigonometric IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page9.html")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x40005B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x8DFC04", Offset = "0x8DFC04", VA = "0x8DFC04", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x8DFC48", Offset = "0x8DFC48", VA = "0x8DFC48", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x8DFC8C", Offset = "0x8DFC8C", VA = "0x8DFC8C")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x8DFCD0", Offset = "0x8DFCD0", VA = "0x8DFCD0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x8DFD14", Offset = "0x8DFD14", VA = "0x8DFD14", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x8DFD1C", Offset = "0x8DFD1C", VA = "0x8DFD1C")]
		public TrigonometricIK()
		{
		}
	}
	[Token(Token = "0x20000E2")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/VR IK")]
	public class VRIK : IK
	{
		[Serializable]
		[Token(Token = "0x20000E3")]
		public class References
		{
			[Token(Token = "0x40005B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform root;

			[Token(Token = "0x40005B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform pelvis;

			[Token(Token = "0x40005B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spine;

			[Token(Token = "0x40005B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform chest;

			[Token(Token = "0x40005B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Transform neck;

			[Token(Token = "0x40005B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform head;

			[Token(Token = "0x40005B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Transform leftShoulder;

			[Token(Token = "0x40005BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Transform leftUpperArm;

			[Token(Token = "0x40005BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Transform leftForearm;

			[Token(Token = "0x40005BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Transform leftHand;

			[Token(Token = "0x40005BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Transform rightShoulder;

			[Token(Token = "0x40005BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Transform rightUpperArm;

			[Token(Token = "0x40005BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public Transform rightForearm;

			[Token(Token = "0x40005C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public Transform rightHand;

			[Token(Token = "0x40005C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			public Transform leftThigh;

			[Token(Token = "0x40005C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			public Transform leftCalf;

			[Token(Token = "0x40005C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Transform leftFoot;

			[Token(Token = "0x40005C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			public Transform leftToes;

			[Token(Token = "0x40005C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			public Transform rightThigh;

			[Token(Token = "0x40005C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			public Transform rightCalf;

			[Token(Token = "0x40005C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			public Transform rightFoot;

			[Token(Token = "0x40005C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			public Transform rightToes;

			[Token(Token = "0x17000080")]
			public bool isFilled
			{
				[Token(Token = "0x60004E7")]
				[Address(RVA = "0x8E07B4", Offset = "0x8E07B4", VA = "0x8E07B4")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000081")]
			public bool isEmpty
			{
				[Token(Token = "0x60004E8")]
				[Address(RVA = "0x8E03F8", Offset = "0x8E03F8", VA = "0x8E03F8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60004E6")]
			[Address(RVA = "0x8E0B38", Offset = "0x8E0B38", VA = "0x8E0B38")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x60004E9")]
			[Address(RVA = "0x8DFEC0", Offset = "0x8DFEC0", VA = "0x8DFEC0")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Token(Token = "0x60004EA")]
			[Address(RVA = "0x8E0B30", Offset = "0x8E0B30", VA = "0x8E0B30")]
			public References()
			{
			}
		}

		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Bone mapping. Right-click on the component header and select 'Auto-detect References' of fill in manually if not a Humanoid character.")]
		[ContextMenuItem("Auto-detect References", "AutoDetectReferences")]
		public References references;

		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The VRIK solver.")]
		public IKSolverVR solver;

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x8DFD90", Offset = "0x8DFD90", VA = "0x8DFD90", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x8DFDF8", Offset = "0x8DFDF8", VA = "0x8DFDF8", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x8DFE60", Offset = "0x8DFE60", VA = "0x8DFE60")]
		[ContextMenu("TUTORIAL VIDEO (STEAMVR SETUP)")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x8DFEA4", Offset = "0x8DFEA4", VA = "0x8DFEA4")]
		[ContextMenu("Auto-detect References")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x8E035C", Offset = "0x8E035C", VA = "0x8E035C")]
		[ContextMenu("Guess Hand Orientations")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x8E0384", Offset = "0x8E0384", VA = "0x8E0384", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x8E038C", Offset = "0x8E038C", VA = "0x8E038C", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x8E0A80", Offset = "0x8E0A80", VA = "0x8E0A80")]
		public VRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000E4")]
	public class FABRIKChain
	{
		[Token(Token = "0x40005C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FABRIK ik;

		[Token(Token = "0x40005CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float pull;

		[Token(Token = "0x40005CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(0f, 1f)]
		public float pin;

		[Token(Token = "0x40005CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] children;

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x8E107C", Offset = "0x8E107C", VA = "0x8E107C")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x8E114C", Offset = "0x8E114C", VA = "0x8E114C")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x8E116C", Offset = "0x8E116C", VA = "0x8E116C")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x8E1494", Offset = "0x8E1494", VA = "0x8E1494")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x8E1300", Offset = "0x8E1300", VA = "0x8E1300")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x8E164C", Offset = "0x8E164C", VA = "0x8E164C")]
		public FABRIKChain()
		{
		}
	}
	[Token(Token = "0x20000E5")]
	public class FBBIKArmBending : MonoBehaviour
	{
		[Token(Token = "0x40005CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40005CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 bendDirectionOffsetLeft;

		[Token(Token = "0x40005CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 bendDirectionOffsetRight;

		[Token(Token = "0x40005D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 characterSpaceBendOffsetLeft;

		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 characterSpaceBendOffsetRight;

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandTargetRotation;

		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Quaternion rightHandTargetRotation;

		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool initiated;

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x8E16B8", Offset = "0x8E16B8", VA = "0x8E16B8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x8E1C0C", Offset = "0x8E1C0C", VA = "0x8E1C0C")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x8E1DA0", Offset = "0x8E1DA0", VA = "0x8E1DA0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x8E1EC8", Offset = "0x8E1EC8", VA = "0x8E1EC8")]
		public FBBIKArmBending()
		{
		}
	}
	[Token(Token = "0x20000E6")]
	public class FBBIKHeadEffector : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000E7")]
		public class BendBone
		{
			[Token(Token = "0x4000603")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Assign spine and/or neck bones.")]
			public Transform transform;

			[Token(Token = "0x4000604")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Range(0f, 1f)]
			[Tooltip("The weight of rotating this bone.")]
			public float weight;

			[Token(Token = "0x4000605")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x6000503")]
			[Address(RVA = "0x8E5238", Offset = "0x8E5238", VA = "0x8E5238")]
			public BendBone()
			{
			}

			[Token(Token = "0x6000504")]
			[Address(RVA = "0x8E5298", Offset = "0x8E5298", VA = "0x8E5298")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x6000505")]
			[Address(RVA = "0x8E2854", Offset = "0x8E2854", VA = "0x8E2854")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000506")]
			[Address(RVA = "0x8E2C28", Offset = "0x8E2C28", VA = "0x8E2C28")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Reference to the FBBIK component.")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[LargeHeader("Position")]
		[Range(0f, 1f)]
		[Tooltip("Master weight for positioning the head.")]
		public float positionWeight;

		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Range(0f, 1f)]
		[Tooltip("The weight of moving the body along with the head")]
		public float bodyWeight;

		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The weight of moving the thighs along with the head")]
		[Range(0f, 1f)]
		public float thighWeight;

		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("If false, hands will not pull the head away if they are too far. Disabling this will improve performance significantly.")]
		public bool handsPullBody;

		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		[Tooltip("The weight of rotating the head bone after solving")]
		[LargeHeader("Rotation")]
		public float rotationWeight;

		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Range(0f, 1f)]
		[Tooltip("Clamping the rotation of the body")]
		public float bodyClampWeight;

		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 1f)]
		[Tooltip("Clamping the rotation of the head")]
		public float headClampWeight;

		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 1f)]
		[Tooltip("The master weight of bending/twisting the spine to the rotation of the head effector. This is similar to CCD, but uses the rotation of the head effector not the position.")]
		public float bendWeight;

		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The bones to use for bending.")]
		public BendBone[] bendBones;

		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Optional. The master weight of the CCD (Cyclic Coordinate Descent) IK effect that bends the spine towards the head effector before FBBIK solves.")]
		[LargeHeader("CCD")]
		[Range(0f, 1f)]
		public float CCDWeight;

		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("The weight of rolling the bones in towards the target")]
		[Range(0f, 1f)]
		public float roll;

		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("Smoothing the CCD effect.")]
		[Range(0f, 1000f)]
		public float damper;

		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("Bones to use for the CCD pass. Assign spine and/or neck bones.")]
		public Transform[] CCDBones;

		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[LargeHeader("Stretching")]
		[Tooltip("Stretching the spine/neck to help reach the target. This is useful for making sure the head stays locked relative to the VR headset. NB! Stretching is done after FBBIK has solved so if you have the hand effectors pinned and spine bones included in the 'Stretch Bones', the hands might become offset from their target positions.")]
		[Range(0f, 1f)]
		public float postStretchWeight;

		[Token(Token = "0x40005E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[Tooltip("Stretch magnitude limit.")]
		public float maxStretch;

		[Token(Token = "0x40005E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("If > 0, dampers the stretching effect.")]
		public float stretchDamper;

		[Token(Token = "0x40005E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Tooltip("If true, will fix head position to this Transform no matter what. Good for making sure the head will not budge away from the VR headset")]
		public bool fixHead;

		[Token(Token = "0x40005E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Tooltip("Bones to use for stretching. The more bones you add, the less noticable the effect.")]
		public Transform[] stretchBones;

		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[LargeHeader("Chest Direction")]
		public Vector3 chestDirection;

		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[Range(0f, 1f)]
		public float chestDirectionWeight;

		[Token(Token = "0x40005EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] chestBones;

		[Token(Token = "0x40005EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IKSolver.UpdateDelegate OnPostHeadEffectorFK;

		[Token(Token = "0x40005EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 offset;

		[Token(Token = "0x40005ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 headToBody;

		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 shoulderCenterToHead;

		[Token(Token = "0x40005EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Vector3 headToLeftThigh;

		[Token(Token = "0x40005F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Vector3 headToRightThigh;

		[Token(Token = "0x40005F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 leftShoulderPos;

		[Token(Token = "0x40005F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Vector3 rightShoulderPos;

		[Token(Token = "0x40005F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float shoulderDist;

		[Token(Token = "0x40005F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float leftShoulderDist;

		[Token(Token = "0x40005F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float rightShoulderDist;

		[Token(Token = "0x40005F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion chestRotation;

		[Token(Token = "0x40005F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Quaternion headRotationRelativeToRoot;

		[Token(Token = "0x40005F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Quaternion[] ccdDefaultLocalRotations;

		[Token(Token = "0x40005F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 headLocalPosition;

		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private Quaternion headLocalRotation;

		[Token(Token = "0x40005FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3[] stretchLocalPositions;

		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Quaternion[] stretchLocalRotations;

		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Vector3[] chestLocalPositions;

		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Quaternion[] chestLocalRotations;

		[Token(Token = "0x40005FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private int bendBonesCount;

		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private int ccdBonesCount;

		[Token(Token = "0x4000601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private int stretchBonesCount;

		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private int chestBonesCount;

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x8E1ED0", Offset = "0x8E1ED0", VA = "0x8E1ED0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x8E23A4", Offset = "0x8E23A4", VA = "0x8E23A4")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x8E2880", Offset = "0x8E2880", VA = "0x8E2880")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x8E2C50", Offset = "0x8E2C50", VA = "0x8E2C50")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x8E3560", Offset = "0x8E3560", VA = "0x8E3560")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x8E3958", Offset = "0x8E3958", VA = "0x8E3958")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x8E3D68", Offset = "0x8E3D68", VA = "0x8E3D68")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x8E46EC", Offset = "0x8E46EC", VA = "0x8E46EC")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x8E32A4", Offset = "0x8E32A4", VA = "0x8E32A4")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x8E493C", Offset = "0x8E493C", VA = "0x8E493C")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x8E460C", Offset = "0x8E460C", VA = "0x8E460C")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x8E450C", Offset = "0x8E450C", VA = "0x8E450C")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x8E4C9C", Offset = "0x8E4C9C", VA = "0x8E4C9C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x8E5024", Offset = "0x8E5024", VA = "0x8E5024")]
		public FBBIKHeadEffector()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000E8")]
	public class FBIKChain
	{
		[Serializable]
		[Token(Token = "0x20000E9")]
		public class ChildConstraint
		{
			[Token(Token = "0x400061D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float pushElasticity;

			[Token(Token = "0x400061E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pullElasticity;

			[Token(Token = "0x400061F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Transform bone1;

			[Token(Token = "0x4000620")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Transform bone2;

			[Token(Token = "0x4000623")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float crossFade;

			[Token(Token = "0x4000624")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float inverseCrossFade;

			[Token(Token = "0x4000625")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int chain1Index;

			[Token(Token = "0x4000626")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private int chain2Index;

			[Token(Token = "0x17000082")]
			public float nominalDistance
			{
				[Token(Token = "0x600051B")]
				[Address(RVA = "0x8E83CC", Offset = "0x8E83CC", VA = "0x8E83CC")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600051C")]
				[Address(RVA = "0x8E83D4", Offset = "0x8E83D4", VA = "0x8E83D4")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000083")]
			public bool isRigid
			{
				[Token(Token = "0x600051D")]
				[Address(RVA = "0x8E83DC", Offset = "0x8E83DC", VA = "0x8E83DC")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600051E")]
				[Address(RVA = "0x8E83E4", Offset = "0x8E83E4", VA = "0x8E83E4")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x600051F")]
			[Address(RVA = "0x8E83F0", Offset = "0x8E83F0", VA = "0x8E83F0")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x6000520")]
			[Address(RVA = "0x8E60A8", Offset = "0x8E60A8", VA = "0x8E60A8")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000521")]
			[Address(RVA = "0x8E6784", Offset = "0x8E6784", VA = "0x8E6784")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000522")]
			[Address(RVA = "0x8E8190", Offset = "0x8E8190", VA = "0x8E8190")]
			public void Solve(IKSolverFullBody solver)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000EA")]
		public enum Smoothing
		{
			[Token(Token = "0x4000628")]
			None,
			[Token(Token = "0x4000629")]
			Exponential,
			[Token(Token = "0x400062A")]
			Cubic
		}

		[Token(Token = "0x4000606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Range(0f, 1f)]
		public float pin;

		[Token(Token = "0x4000607")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Range(0f, 1f)]
		public float pull;

		[Token(Token = "0x4000608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float push;

		[Token(Token = "0x4000609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(-1f, 1f)]
		public float pushParent;

		[Token(Token = "0x400060A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float reach;

		[Token(Token = "0x400060B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Smoothing reachSmoothing;

		[Token(Token = "0x400060C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Smoothing pushSmoothing;

		[Token(Token = "0x400060D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolver.Node[] nodes;

		[Token(Token = "0x400060E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int[] children;

		[Token(Token = "0x400060F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ChildConstraint[] childConstraints;

		[Token(Token = "0x4000610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public IKConstraintBend bendConstraint;

		[Token(Token = "0x4000611")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float rootLength;

		[Token(Token = "0x4000612")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool initiated;

		[Token(Token = "0x4000613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float length;

		[Token(Token = "0x4000614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float distance;

		[Token(Token = "0x4000615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IKSolver.Point p;

		[Token(Token = "0x4000616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float reachForce;

		[Token(Token = "0x4000617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float pullParentSum;

		[Token(Token = "0x4000618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float[] crossFades;

		[Token(Token = "0x4000619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float sqrMag1;

		[Token(Token = "0x400061A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float sqrMag2;

		[Token(Token = "0x400061B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float sqrMagDif;

		[Token(Token = "0x400061C")]
		private const float maxLimbLength = 0.99999f;

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x8E5320", Offset = "0x8E5320", VA = "0x8E5320")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x8E54B8", Offset = "0x8E54B8", VA = "0x8E54B8")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x8E5628", Offset = "0x8E5628", VA = "0x8E5628")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x8E578C", Offset = "0x8E578C", VA = "0x8E578C")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x8E5848", Offset = "0x8E5848", VA = "0x8E5848")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x8E5964", Offset = "0x8E5964", VA = "0x8E5964")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x8E63A0", Offset = "0x8E63A0", VA = "0x8E63A0")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x8E5AE0", Offset = "0x8E5AE0", VA = "0x8E5AE0")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x8E6968", Offset = "0x8E6968", VA = "0x8E6968")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x8E6BFC", Offset = "0x8E6BFC", VA = "0x8E6BFC")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x8E6ECC", Offset = "0x8E6ECC", VA = "0x8E6ECC")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x8E7894", Offset = "0x8E7894", VA = "0x8E7894")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x8E7D8C", Offset = "0x8E7D8C", VA = "0x8E7D8C")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x8E7F8C", Offset = "0x8E7F8C", VA = "0x8E7F8C")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x8E7C78", Offset = "0x8E7C78", VA = "0x8E7C78")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x8E7734", Offset = "0x8E7734", VA = "0x8E7734")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x8E7C14", Offset = "0x8E7C14", VA = "0x8E7C14")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x8E8068", Offset = "0x8E8068", VA = "0x8E8068")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x8E7B40", Offset = "0x8E7B40", VA = "0x8E7B40")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x8E7E90", Offset = "0x8E7E90", VA = "0x8E7E90")]
		private void BackwardReach(Vector3 position)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000EB")]
	public class IKConstraintBend
	{
		[Token(Token = "0x400062B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone1;

		[Token(Token = "0x400062C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone2;

		[Token(Token = "0x400062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone3;

		[Token(Token = "0x400062E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bendGoal;

		[Token(Token = "0x400062F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 direction;

		[Token(Token = "0x4000630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Quaternion rotationOffset;

		[Token(Token = "0x4000631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x4000632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector3 defaultLocalDirection;

		[Token(Token = "0x4000633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Vector3 defaultChildDirection;

		[NonSerialized]
		[Token(Token = "0x4000634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float clampF;

		[Token(Token = "0x4000635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int chainIndex1;

		[Token(Token = "0x4000636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int nodeIndex1;

		[Token(Token = "0x4000637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int chainIndex2;

		[Token(Token = "0x4000638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int nodeIndex2;

		[Token(Token = "0x4000639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int chainIndex3;

		[Token(Token = "0x400063A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int nodeIndex3;

		[Token(Token = "0x17000084")]
		public bool initiated
		{
			[Token(Token = "0x6000524")]
			[Address(RVA = "0x8E8624", Offset = "0x8E8624", VA = "0x8E8624")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000525")]
			[Address(RVA = "0x8E862C", Offset = "0x8E862C", VA = "0x8E862C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x8E844C", Offset = "0x8E844C", VA = "0x8E844C")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x8E544C", Offset = "0x8E544C", VA = "0x8E544C")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x8E8638", Offset = "0x8E8638", VA = "0x8E8638")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x8E60FC", Offset = "0x8E60FC", VA = "0x8E60FC")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x8E6140", Offset = "0x8E6140", VA = "0x8E6140")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x8E8814", Offset = "0x8E8814", VA = "0x8E8814")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x8E8B60", Offset = "0x8E8B60", VA = "0x8E8B60")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x8E7104", Offset = "0x8E7104", VA = "0x8E7104")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x8E86CC", Offset = "0x8E86CC", VA = "0x8E86CC")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x8E8770", Offset = "0x8E8770", VA = "0x8E8770")]
		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x20000EC")]
	public class IKEffector
	{
		[Token(Token = "0x400063C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x400063D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x400063E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float positionWeight;

		[Token(Token = "0x400063F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Range(0f, 1f)]
		public float rotationWeight;

		[Token(Token = "0x4000640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 position;

		[Token(Token = "0x4000641")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Quaternion rotation;

		[Token(Token = "0x4000642")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 positionOffset;

		[Token(Token = "0x4000644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool effectChildNodes;

		[Token(Token = "0x4000645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Range(0f, 1f)]
		public float maintainRelativePositionWeight;

		[Token(Token = "0x4000646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform[] childBones;

		[Token(Token = "0x4000647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform planeBone1;

		[Token(Token = "0x4000648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform planeBone2;

		[Token(Token = "0x4000649")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform planeBone3;

		[Token(Token = "0x400064A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Quaternion planeRotationOffset;

		[Token(Token = "0x400064B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float posW;

		[Token(Token = "0x400064C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float rotW;

		[Token(Token = "0x400064D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] localPositions;

		[Token(Token = "0x400064E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool usePlaneNodes;

		[Token(Token = "0x400064F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Quaternion animatedPlaneRotation;

		[Token(Token = "0x4000650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 animatedPosition;

		[Token(Token = "0x4000651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool firstUpdate;

		[Token(Token = "0x4000652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int chainIndex;

		[Token(Token = "0x4000653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int nodeIndex;

		[Token(Token = "0x4000654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int plane1ChainIndex;

		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int plane1NodeIndex;

		[Token(Token = "0x4000656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int plane2ChainIndex;

		[Token(Token = "0x4000657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int plane2NodeIndex;

		[Token(Token = "0x4000658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int plane3ChainIndex;

		[Token(Token = "0x4000659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private int plane3NodeIndex;

		[Token(Token = "0x400065A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int[] childChainIndexes;

		[Token(Token = "0x400065B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int[] childNodeIndexes;

		[Token(Token = "0x17000085")]
		public bool isEndEffector
		{
			[Token(Token = "0x6000530")]
			[Address(RVA = "0x8E8F28", Offset = "0x8E8F28", VA = "0x8E8F28")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000531")]
			[Address(RVA = "0x8E8F30", Offset = "0x8E8F30", VA = "0x8E8F30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x8E4C40", Offset = "0x8E4C40", VA = "0x8E4C40")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x8E8F3C", Offset = "0x8E8F3C", VA = "0x8E8F3C")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x8E8FC0", Offset = "0x8E8FC0", VA = "0x8E8FC0")]
		public IKEffector()
		{
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x8E9190", Offset = "0x8E9190", VA = "0x8E9190")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x8E939C", Offset = "0x8E939C", VA = "0x8E939C")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x8E96A4", Offset = "0x8E96A4", VA = "0x8E96A4")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x8E997C", Offset = "0x8E997C", VA = "0x8E997C")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x8E9A9C", Offset = "0x8E9A9C", VA = "0x8E9A9C")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x8E9B38", Offset = "0x8E9B38", VA = "0x8E9B38")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x8EA1EC", Offset = "0x8EA1EC", VA = "0x8EA1EC")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x8EA244", Offset = "0x8EA244", VA = "0x8EA244")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x8EA418", Offset = "0x8EA418", VA = "0x8EA418")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x8EA674", Offset = "0x8EA674", VA = "0x8EA674")]
		private Vector3 GetPosition(IKSolverFullBody solver, out Quaternion planeRotationOffset)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x20000ED")]
	public class IKMapping
	{
		[Serializable]
		[Token(Token = "0x20000EE")]
		public class BoneMap
		{
			[Token(Token = "0x400065C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x400065D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int chainIndex;

			[Token(Token = "0x400065E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int nodeIndex;

			[Token(Token = "0x400065F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x4000660")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x4000661")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 localSwingAxis;

			[Token(Token = "0x4000662")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 localTwistAxis;

			[Token(Token = "0x4000663")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 planePosition;

			[Token(Token = "0x4000664")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 ikPosition;

			[Token(Token = "0x4000665")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion defaultLocalTargetRotation;

			[Token(Token = "0x4000666")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			private Quaternion maintainRotation;

			[Token(Token = "0x4000667")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			public float length;

			[Token(Token = "0x4000668")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Quaternion animatedRotation;

			[Token(Token = "0x4000669")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private Transform planeBone1;

			[Token(Token = "0x400066A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private Transform planeBone2;

			[Token(Token = "0x400066B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Transform planeBone3;

			[Token(Token = "0x400066C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private int plane1ChainIndex;

			[Token(Token = "0x400066D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private int plane1NodeIndex;

			[Token(Token = "0x400066E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private int plane2ChainIndex;

			[Token(Token = "0x400066F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			private int plane2NodeIndex;

			[Token(Token = "0x4000670")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private int plane3ChainIndex;

			[Token(Token = "0x4000671")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private int plane3NodeIndex;

			[Token(Token = "0x17000086")]
			public Vector3 swingDirection
			{
				[Token(Token = "0x6000544")]
				[Address(RVA = "0x8EABE4", Offset = "0x8EABE4", VA = "0x8EABE4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000087")]
			public bool isNodeBone
			{
				[Token(Token = "0x6000547")]
				[Address(RVA = "0x8EAC9C", Offset = "0x8EAC9C", VA = "0x8EAC9C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000088")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x600055B")]
				[Address(RVA = "0x8EB088", Offset = "0x8EB088", VA = "0x8EB088")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x6000543")]
			[Address(RVA = "0x8EABA0", Offset = "0x8EABA0", VA = "0x8EABA0")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000545")]
			[Address(RVA = "0x8EAC14", Offset = "0x8EAC14", VA = "0x8EAC14")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000546")]
			[Address(RVA = "0x8EAC58", Offset = "0x8EAC58", VA = "0x8EAC58")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x6000548")]
			[Address(RVA = "0x8EACAC", Offset = "0x8EACAC", VA = "0x8EACAC")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x6000549")]
			[Address(RVA = "0x8EAD80", Offset = "0x8EAD80", VA = "0x8EAD80")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x600054A")]
			[Address(RVA = "0x8EAD88", Offset = "0x8EAD88", VA = "0x8EAD88")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x600054B")]
			[Address(RVA = "0x8EAE54", Offset = "0x8EAE54", VA = "0x8EAE54")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x600054C")]
			[Address(RVA = "0x8EAEC0", Offset = "0x8EAEC0", VA = "0x8EAEC0")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x600054D")]
			[Address(RVA = "0x8EAF78", Offset = "0x8EAF78", VA = "0x8EAF78")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x600054E")]
			[Address(RVA = "0x8EB1F0", Offset = "0x8EB1F0", VA = "0x8EB1F0")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x600054F")]
			[Address(RVA = "0x8EB21C", Offset = "0x8EB21C", VA = "0x8EB21C")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x6000550")]
			[Address(RVA = "0x8EB248", Offset = "0x8EB248", VA = "0x8EB248")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x6000551")]
			[Address(RVA = "0x8EB270", Offset = "0x8EB270", VA = "0x8EB270")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x6000552")]
			[Address(RVA = "0x8EB334", Offset = "0x8EB334", VA = "0x8EB334")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000553")]
			[Address(RVA = "0x8EB4C8", Offset = "0x8EB4C8", VA = "0x8EB4C8")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000554")]
			[Address(RVA = "0x8EB4EC", Offset = "0x8EB4EC", VA = "0x8EB4EC")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x6000555")]
			[Address(RVA = "0x8EB60C", Offset = "0x8EB60C", VA = "0x8EB60C")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x6000556")]
			[Address(RVA = "0x8EB670", Offset = "0x8EB670", VA = "0x8EB670")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x6000557")]
			[Address(RVA = "0x8EB7F0", Offset = "0x8EB7F0", VA = "0x8EB7F0")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x6000558")]
			[Address(RVA = "0x8EB970", Offset = "0x8EB970", VA = "0x8EB970")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x6000559")]
			[Address(RVA = "0x8EB9EC", Offset = "0x8EB9EC", VA = "0x8EB9EC")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x600055A")]
			[Address(RVA = "0x8EB3AC", Offset = "0x8EB3AC", VA = "0x8EB3AC")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x600055C")]
			[Address(RVA = "0x8EBB14", Offset = "0x8EBB14", VA = "0x8EBB14")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x8EA930", Offset = "0x8EA930", VA = "0x8EA930", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x8EA938", Offset = "0x8EA938", VA = "0x8EA938", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x8EA93C", Offset = "0x8EA93C", VA = "0x8EA93C")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x8EAA84", Offset = "0x8EAA84", VA = "0x8EAA84")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x8EAB98", Offset = "0x8EAB98", VA = "0x8EAB98")]
		public IKMapping()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000EF")]
	public class IKMappingBone : IKMapping
	{
		[Token(Token = "0x4000672")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x4000673")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float maintainRotationWeight;

		[Token(Token = "0x4000674")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoneMap boneMap;

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x8EBB30", Offset = "0x8EBB30", VA = "0x8EBB30", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x8EBBD8", Offset = "0x8EBBD8", VA = "0x8EBBD8")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x8EBC68", Offset = "0x8EBC68", VA = "0x8EBC68")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x8EBD14", Offset = "0x8EBD14", VA = "0x8EBD14")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x8EBD2C", Offset = "0x8EBD2C", VA = "0x8EBD2C")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x8EBD48", Offset = "0x8EBD48", VA = "0x8EBD48", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x8EBDF0", Offset = "0x8EBDF0", VA = "0x8EBDF0")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x8EBE08", Offset = "0x8EBE08", VA = "0x8EBE08")]
		public void WritePose(float solverWeight)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000F0")]
	public class IKMappingLimb : IKMapping
	{
		[Serializable]
		[Token(Token = "0x20000F1")]
		public enum BoneMapType
		{
			[Token(Token = "0x4000680")]
			Parent,
			[Token(Token = "0x4000681")]
			Bone1,
			[Token(Token = "0x4000682")]
			Bone2,
			[Token(Token = "0x4000683")]
			Bone3
		}

		[Token(Token = "0x4000675")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform parentBone;

		[Token(Token = "0x4000676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone1;

		[Token(Token = "0x4000677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone2;

		[Token(Token = "0x4000678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bone3;

		[Token(Token = "0x4000679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		public float maintainRotationWeight;

		[Token(Token = "0x400067A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x400067B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private BoneMap boneMapParent;

		[Token(Token = "0x400067C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private BoneMap boneMap1;

		[Token(Token = "0x400067D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap boneMap2;

		[Token(Token = "0x400067E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap boneMap3;

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x8EBE2C", Offset = "0x8EBE2C", VA = "0x8EBE2C", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x8EBEA0", Offset = "0x8EBEA0", VA = "0x8EBEA0")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x8EBF68", Offset = "0x8EBF68", VA = "0x8EBF68")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x8EC220", Offset = "0x8EC220", VA = "0x8EC220")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x8EC364", Offset = "0x8EC364", VA = "0x8EC364")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x8EC4E0", Offset = "0x8EC4E0", VA = "0x8EC4E0")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x8EC540", Offset = "0x8EC540", VA = "0x8EC540")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x8EC5D8", Offset = "0x8EC5D8", VA = "0x8EC5D8")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x8EC680", Offset = "0x8EC680", VA = "0x8EC680", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x8EC934", Offset = "0x8EC934", VA = "0x8EC934")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x8EC994", Offset = "0x8EC994", VA = "0x8EC994")]
		public void WritePose(IKSolverFullBody solver, bool fullBody)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000F2")]
	public class IKMappingSpine : IKMapping
	{
		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform[] spineBones;

		[Token(Token = "0x4000685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform leftUpperArmBone;

		[Token(Token = "0x4000686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rightUpperArmBone;

		[Token(Token = "0x4000687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftThighBone;

		[Token(Token = "0x4000688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightThighBone;

		[Token(Token = "0x4000689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(1f, 3f)]
		public int iterations;

		[Token(Token = "0x400068A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 1f)]
		public float twistWeight;

		[Token(Token = "0x400068B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int rootNodeIndex;

		[Token(Token = "0x400068C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap[] spine;

		[Token(Token = "0x400068D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap leftUpperArm;

		[Token(Token = "0x400068E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap rightUpperArm;

		[Token(Token = "0x400068F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private BoneMap leftThigh;

		[Token(Token = "0x4000690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private BoneMap rightThigh;

		[Token(Token = "0x4000691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool useFABRIK;

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x8ECADC", Offset = "0x8ECADC", VA = "0x8ECADC", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x8ECE08", Offset = "0x8ECE08", VA = "0x8ECE08")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x8ECF80", Offset = "0x8ECF80", VA = "0x8ECF80")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x8ED138", Offset = "0x8ED138", VA = "0x8ED138")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x8ED1AC", Offset = "0x8ED1AC", VA = "0x8ED1AC")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x8ED208", Offset = "0x8ED208", VA = "0x8ED208")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x8ED280", Offset = "0x8ED280", VA = "0x8ED280", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x8ED8F8", Offset = "0x8ED8F8", VA = "0x8ED8F8")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x8ED930", Offset = "0x8ED930", VA = "0x8ED930")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x8EDB94", Offset = "0x8EDB94", VA = "0x8EDB94")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0x8EDEBC", Offset = "0x8EDEBC", VA = "0x8EDEBC")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x8EDF9C", Offset = "0x8EDF9C", VA = "0x8EDF9C")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x8EE050", Offset = "0x8EE050", VA = "0x8EE050")]
		private void MapToSolverPositions(IKSolverFullBody solver)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000F3")]
	public abstract class IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000F4")]
		public class Point
		{
			[Token(Token = "0x400069B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x400069C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Range(0f, 1f)]
			public float weight;

			[Token(Token = "0x400069D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 solverPosition;

			[Token(Token = "0x400069E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Quaternion solverRotation;

			[Token(Token = "0x400069F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x40006A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x6000593")]
			[Address(RVA = "0x8EE92C", Offset = "0x8EE92C", VA = "0x8EE92C")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000594")]
			[Address(RVA = "0x8EE970", Offset = "0x8EE970", VA = "0x8EE970")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000595")]
			[Address(RVA = "0x8EEA50", Offset = "0x8EEA50", VA = "0x8EEA50")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x6000596")]
			[Address(RVA = "0x8EEA7C", Offset = "0x8EEA7C", VA = "0x8EEA7C")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x6000597")]
			[Address(RVA = "0x8EEAA8", Offset = "0x8EEAA8", VA = "0x8EEAA8")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x6000598")]
			[Address(RVA = "0x8EEAEC", Offset = "0x8EEAEC", VA = "0x8EEAEC")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x6000599")]
			[Address(RVA = "0x8EEB30", Offset = "0x8EEB30", VA = "0x8EEB30")]
			public Point()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000F5")]
		public class Bone : Point
		{
			[Token(Token = "0x40006A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x40006A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float sqrMag;

			[Token(Token = "0x40006A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 axis;

			[Token(Token = "0x40006A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private RotationLimit _rotationLimit;

			[Token(Token = "0x40006A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private bool isLimited;

			[Token(Token = "0x1700008A")]
			public RotationLimit rotationLimit
			{
				[Token(Token = "0x600059A")]
				[Address(RVA = "0x8EEB90", Offset = "0x8EEB90", VA = "0x8EEB90")]
				get
				{
					return null;
				}
				[Token(Token = "0x600059B")]
				[Address(RVA = "0x8EEC80", Offset = "0x8EEC80", VA = "0x8EEC80")]
				set
				{
				}
			}

			[Token(Token = "0x600059C")]
			[Address(RVA = "0x8EED04", Offset = "0x8EED04", VA = "0x8EED04")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600059D")]
			[Address(RVA = "0x8EEF70", Offset = "0x8EEF70", VA = "0x8EEF70")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600059E")]
			[Address(RVA = "0x8EF22C", Offset = "0x8EF22C", VA = "0x8EF22C")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600059F")]
			[Address(RVA = "0x8EF420", Offset = "0x8EF420", VA = "0x8EF420")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x60005A0")]
			[Address(RVA = "0x8EF448", Offset = "0x8EF448", VA = "0x8EF448")]
			public Bone()
			{
			}

			[Token(Token = "0x60005A1")]
			[Address(RVA = "0x8EF4B4", Offset = "0x8EF4B4", VA = "0x8EF4B4")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x60005A2")]
			[Address(RVA = "0x8EF534", Offset = "0x8EF534", VA = "0x8EF534")]
			public Bone(Transform transform, float weight)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000F6")]
		public class Node : Point
		{
			[Token(Token = "0x40006A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x40006A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float effectorPositionWeight;

			[Token(Token = "0x40006A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public float effectorRotationWeight;

			[Token(Token = "0x40006A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 offset;

			[Token(Token = "0x60005A3")]
			[Address(RVA = "0x8EF5C8", Offset = "0x8EF5C8", VA = "0x8EF5C8")]
			public Node()
			{
			}

			[Token(Token = "0x60005A4")]
			[Address(RVA = "0x8E5760", Offset = "0x8E5760", VA = "0x8E5760")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x60005A5")]
			[Address(RVA = "0x8EF5CC", Offset = "0x8EF5CC", VA = "0x8EF5CC")]
			public Node(Transform transform, float weight)
			{
			}
		}

		[Token(Token = "0x20000F7")]
		public delegate void UpdateDelegate();

		[Token(Token = "0x20000F8")]
		public delegate void IterationDelegate(int i);

		[Token(Token = "0x4000692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public Vector3 IKPosition;

		[Token(Token = "0x4000693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("The positional or the master weight of the solver.")]
		[Range(0f, 1f)]
		public float IKPositionWeight;

		[Token(Token = "0x4000695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateDelegate OnPreInitiate;

		[Token(Token = "0x4000696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UpdateDelegate OnPostInitiate;

		[Token(Token = "0x4000697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UpdateDelegate OnPreUpdate;

		[Token(Token = "0x4000698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UpdateDelegate OnPostUpdate;

		[Token(Token = "0x4000699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected bool firstInitiation;

		[Token(Token = "0x400069A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[HideInInspector]
		[SerializeField]
		protected Transform root;

		[Token(Token = "0x17000089")]
		public bool initiated
		{
			[Token(Token = "0x6000586")]
			[Address(RVA = "0x8EE538", Offset = "0x8EE538", VA = "0x8EE538")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000587")]
			[Address(RVA = "0x8EE540", Offset = "0x8EE540", VA = "0x8EE540")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x8EE294", Offset = "0x8EE294", VA = "0x8EE294")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x600057E")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x8EE308", Offset = "0x8EE308", VA = "0x8EE308")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x8EE484", Offset = "0x8EE484", VA = "0x8EE484")]
		public void Update()
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x8EE4F4", Offset = "0x8EE4F4", VA = "0x8EE4F4", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x8EE500", Offset = "0x8EE500", VA = "0x8EE500")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x8EE50C", Offset = "0x8EE50C", VA = "0x8EE50C")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x8EE514", Offset = "0x8EE514", VA = "0x8EE514")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x8EE530", Offset = "0x8EE530", VA = "0x8EE530")]
		public Transform GetRoot()
		{
			return null;
		}

		[Token(Token = "0x6000588")]
		public abstract Point[] GetPoints();

		[Token(Token = "0x6000589")]
		public abstract Point GetPoint(Transform transform);

		[Token(Token = "0x600058A")]
		public abstract void FixTransforms();

		[Token(Token = "0x600058B")]
		public abstract void StoreDefaultLocalState();

		[Token(Token = "0x600058C")]
		protected abstract void OnInitiate();

		[Token(Token = "0x600058D")]
		protected abstract void OnUpdate();

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x8EE54C", Offset = "0x8EE54C", VA = "0x8EE54C")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x8EE564", Offset = "0x8EE564", VA = "0x8EE564")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x8EE688", Offset = "0x8EE688", VA = "0x8EE688")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x8EE720", Offset = "0x8EE720", VA = "0x8EE720")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x8EE914", Offset = "0x8EE914", VA = "0x8EE914")]
		protected IKSolver()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000F9")]
	public class IKSolverAim : IKSolverHeuristic
	{
		[Token(Token = "0x40006AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform transform;

		[Token(Token = "0x40006AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 axis;

		[Token(Token = "0x40006AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public Vector3 poleAxis;

		[Token(Token = "0x40006AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Vector3 polePosition;

		[Token(Token = "0x40006AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[Range(0f, 1f)]
		public float poleWeight;

		[Token(Token = "0x40006AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform poleTarget;

		[Token(Token = "0x40006B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[Range(0f, 1f)]
		public float clampWeight;

		[Token(Token = "0x40006B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[Range(0f, 2f)]
		public int clampSmoothing;

		[Token(Token = "0x40006B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x40006B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float step;

		[Token(Token = "0x40006B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 clampedIKPosition;

		[Token(Token = "0x40006B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RotationLimit transformLimit;

		[Token(Token = "0x40006B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Transform lastTransform;

		[Token(Token = "0x1700008B")]
		public Vector3 transformAxis
		{
			[Token(Token = "0x60005AF")]
			[Address(RVA = "0x8EF828", Offset = "0x8EF828", VA = "0x8EF828")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700008C")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x60005B0")]
			[Address(RVA = "0x8EF858", Offset = "0x8EF858", VA = "0x8EF858")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700008D")]
		protected override int minBones
		{
			[Token(Token = "0x60005B3")]
			[Address(RVA = "0x8F04A8", Offset = "0x8F04A8", VA = "0x8F04A8", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700008E")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x60005B7")]
			[Address(RVA = "0x8F09E8", Offset = "0x8F09E8", VA = "0x8F09E8", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x8EF6F0", Offset = "0x8EF6F0", VA = "0x8EF6F0")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x8EF888", Offset = "0x8EF888", VA = "0x8EF888", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x8EFB14", Offset = "0x8EFB14", VA = "0x8EFB14", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x8F0400", Offset = "0x8F0400", VA = "0x8F0400")]
		private void Solve()
		{
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x8F009C", Offset = "0x8F009C", VA = "0x8F009C")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x8F04B0", Offset = "0x8F04B0", VA = "0x8F04B0")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x8F0A48", Offset = "0x8F0A48", VA = "0x8F0A48")]
		public IKSolverAim()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000FA")]
	public class IKSolverCCD : IKSolverHeuristic
	{
		[Token(Token = "0x40006B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x8F0AEC", Offset = "0x8F0AEC", VA = "0x8F0AEC")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x8F0B5C", Offset = "0x8F0B5C", VA = "0x8F0B5C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x8F0BCC", Offset = "0x8F0BCC", VA = "0x8F0BCC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x8F0E80", Offset = "0x8F0E80", VA = "0x8F0E80")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x8F1510", Offset = "0x8F1510", VA = "0x8F1510")]
		public IKSolverCCD()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000FB")]
	public class IKSolverFABRIK : IKSolverHeuristic
	{
		[Token(Token = "0x40006B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x40006B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool[] limitedBones;

		[Token(Token = "0x40006BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3[] solverLocalPositions;

		[Token(Token = "0x1700008F")]
		protected override bool boneLengthCanBeZero
		{
			[Token(Token = "0x60005C3")]
			[Address(RVA = "0x8F2324", Offset = "0x8F2324", VA = "0x8F2324", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x8E1228", Offset = "0x8E1228", VA = "0x8E1228")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x8E1574", Offset = "0x8E1574", VA = "0x8E1574")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x8F1A78", Offset = "0x8F1A78", VA = "0x8F1A78", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x8F1B00", Offset = "0x8F1B00", VA = "0x8F1B00", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x8F2018", Offset = "0x8F2018", VA = "0x8F2018", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x8F232C", Offset = "0x8F232C", VA = "0x8F232C")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x8F1518", Offset = "0x8F1518", VA = "0x8F1518")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x8F1A30", Offset = "0x8F1A30", VA = "0x8F1A30")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x8F22DC", Offset = "0x8F22DC", VA = "0x8F22DC")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x8F18B4", Offset = "0x8F18B4", VA = "0x8F18B4")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x8F29D8", Offset = "0x8F29D8", VA = "0x8F29D8")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x8F2A40", Offset = "0x8F2A40", VA = "0x8F2A40")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x8F2B10", Offset = "0x8F2B10", VA = "0x8F2B10")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x8F2BD8", Offset = "0x8F2BD8", VA = "0x8F2BD8")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x8F1D90", Offset = "0x8F1D90", VA = "0x8F1D90")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x8F1ED4", Offset = "0x8F1ED4", VA = "0x8F1ED4")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x8F2CC8", Offset = "0x8F2CC8", VA = "0x8F2CC8")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x8F25C8", Offset = "0x8F25C8", VA = "0x8F25C8")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x8F1A20", Offset = "0x8F1A20", VA = "0x8F1A20")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x8F3338", Offset = "0x8F3338", VA = "0x8F3338")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x8F2E88", Offset = "0x8F2E88", VA = "0x8F2E88")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x8F2448", Offset = "0x8F2448", VA = "0x8F2448")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x8F2518", Offset = "0x8F2518", VA = "0x8F2518")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x8F33F0", Offset = "0x8F33F0", VA = "0x8F33F0")]
		public IKSolverFABRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000FC")]
	public class IKSolverFABRIKRoot : IKSolver
	{
		[Token(Token = "0x40006BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int iterations;

		[Token(Token = "0x40006BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Range(0f, 1f)]
		public float rootPin;

		[Token(Token = "0x40006BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FABRIKChain[] chains;

		[Token(Token = "0x40006BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool zeroWeightApplied;

		[Token(Token = "0x40006BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] isRoot;

		[Token(Token = "0x40006C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 rootDefaultPosition;

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x8F448C", Offset = "0x8F448C", VA = "0x8F448C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x8F4B50", Offset = "0x8F4B50", VA = "0x8F4B50", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x8F4BDC", Offset = "0x8F4BDC", VA = "0x8F4BDC", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x8F4C68", Offset = "0x8F4C68", VA = "0x8F4C68", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x8F4D60", Offset = "0x8F4D60", VA = "0x8F4D60")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x8F4DF0", Offset = "0x8F4DF0", VA = "0x8F4DF0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x8F51F0", Offset = "0x8F51F0", VA = "0x8F51F0", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x8F53E8", Offset = "0x8F53E8", VA = "0x8F53E8", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x8F5290", Offset = "0x8F5290", VA = "0x8F5290")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x8F4FC8", Offset = "0x8F4FC8", VA = "0x8F4FC8")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x8F546C", Offset = "0x8F546C", VA = "0x8F546C")]
		public IKSolverFABRIKRoot()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000FD")]
	public class IKSolverFullBody : IKSolver
	{
		[Token(Token = "0x40006C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Range(0f, 10f)]
		public int iterations;

		[Token(Token = "0x40006C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FBIKChain[] chain;

		[Token(Token = "0x40006C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public IKEffector[] effectors;

		[Token(Token = "0x40006C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public IKMappingSpine spineMapping;

		[Token(Token = "0x40006C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public IKMappingBone[] boneMappings;

		[Token(Token = "0x40006C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public IKMappingLimb[] limbMappings;

		[Token(Token = "0x40006C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool FABRIKPass;

		[Token(Token = "0x40006C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public UpdateDelegate OnPreRead;

		[Token(Token = "0x40006C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public UpdateDelegate OnPreSolve;

		[Token(Token = "0x40006CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x40006CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public IterationDelegate OnPostIteration;

		[Token(Token = "0x40006CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public UpdateDelegate OnPreBend;

		[Token(Token = "0x40006CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public UpdateDelegate OnPostSolve;

		[Token(Token = "0x40006CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public UpdateDelegate OnStoreDefaultLocalState;

		[Token(Token = "0x40006CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public UpdateDelegate OnFixTransforms;

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x8F54D8", Offset = "0x8F54D8", VA = "0x8F54D8")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x8F55B4", Offset = "0x8F55B4", VA = "0x8F55B4")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x8F55FC", Offset = "0x8F55FC", VA = "0x8F55FC")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x8F5710", Offset = "0x8F5710", VA = "0x8F5710")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x8F5760", Offset = "0x8F5760", VA = "0x8F5760")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x8F57D4", Offset = "0x8F57D4", VA = "0x8F57D4", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x8F595C", Offset = "0x8F595C", VA = "0x8F595C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x8F5AB8", Offset = "0x8F5AB8", VA = "0x8F5AB8", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x8F5CBC", Offset = "0x8F5CBC", VA = "0x8F5CBC", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x8F5D90", Offset = "0x8F5D90", VA = "0x8F5D90", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x8F5E70", Offset = "0x8F5E70", VA = "0x8F5E70", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x8F5FD0", Offset = "0x8F5FD0", VA = "0x8F5FD0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x8F616C", Offset = "0x8F616C", VA = "0x8F616C", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x8F63A4", Offset = "0x8F63A4", VA = "0x8F63A4", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x8F6684", Offset = "0x8F6684", VA = "0x8F6684", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x8F66BC", Offset = "0x8F66BC", VA = "0x8F66BC", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x8F67A0", Offset = "0x8F67A0", VA = "0x8F67A0")]
		public IKSolverFullBody()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000FE")]
	public enum FullBodyBipedEffector
	{
		[Token(Token = "0x40006D1")]
		Body,
		[Token(Token = "0x40006D2")]
		LeftShoulder,
		[Token(Token = "0x40006D3")]
		RightShoulder,
		[Token(Token = "0x40006D4")]
		LeftThigh,
		[Token(Token = "0x40006D5")]
		RightThigh,
		[Token(Token = "0x40006D6")]
		LeftHand,
		[Token(Token = "0x40006D7")]
		RightHand,
		[Token(Token = "0x40006D8")]
		LeftFoot,
		[Token(Token = "0x40006D9")]
		RightFoot
	}
	[Serializable]
	[Token(Token = "0x20000FF")]
	public enum FullBodyBipedChain
	{
		[Token(Token = "0x40006DB")]
		LeftArm,
		[Token(Token = "0x40006DC")]
		RightArm,
		[Token(Token = "0x40006DD")]
		LeftLeg,
		[Token(Token = "0x40006DE")]
		RightLeg
	}
	[Serializable]
	[Token(Token = "0x2000100")]
	public class IKSolverFullBodyBiped : IKSolverFullBody
	{
		[Token(Token = "0x40006DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Transform rootNode;

		[Token(Token = "0x40006E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[Range(0f, 1f)]
		public float spineStiffness;

		[Token(Token = "0x40006E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[Range(-1f, 1f)]
		public float pullBodyVertical;

		[Token(Token = "0x40006E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[Range(-1f, 1f)]
		public float pullBodyHorizontal;

		[Token(Token = "0x40006E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 offset;

		[Token(Token = "0x17000090")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x60005F3")]
			[Address(RVA = "0x8F68EC", Offset = "0x8F68EC", VA = "0x8F68EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000091")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x60005F4")]
			[Address(RVA = "0x8F6A2C", Offset = "0x8F6A2C", VA = "0x8F6A2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000092")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x60005F5")]
			[Address(RVA = "0x8F6A34", Offset = "0x8F6A34", VA = "0x8F6A34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000093")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x60005F6")]
			[Address(RVA = "0x8F6A3C", Offset = "0x8F6A3C", VA = "0x8F6A3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000094")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x60005F7")]
			[Address(RVA = "0x8F6A44", Offset = "0x8F6A44", VA = "0x8F6A44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000095")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x60005F8")]
			[Address(RVA = "0x8F6A4C", Offset = "0x8F6A4C", VA = "0x8F6A4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000096")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x60005F9")]
			[Address(RVA = "0x8F6A54", Offset = "0x8F6A54", VA = "0x8F6A54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000097")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x60005FA")]
			[Address(RVA = "0x8F6A5C", Offset = "0x8F6A5C", VA = "0x8F6A5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000098")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x60005FB")]
			[Address(RVA = "0x8F6A64", Offset = "0x8F6A64", VA = "0x8F6A64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000099")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x60005FC")]
			[Address(RVA = "0x8F6A6C", Offset = "0x8F6A6C", VA = "0x8F6A6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009A")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x60005FD")]
			[Address(RVA = "0x8F6A98", Offset = "0x8F6A98", VA = "0x8F6A98")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009B")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x60005FE")]
			[Address(RVA = "0x8F6AC4", Offset = "0x8F6AC4", VA = "0x8F6AC4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009C")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x60005FF")]
			[Address(RVA = "0x8F6AF0", Offset = "0x8F6AF0", VA = "0x8F6AF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009D")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x6000600")]
			[Address(RVA = "0x8F6B1C", Offset = "0x8F6B1C", VA = "0x8F6B1C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009E")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x6000601")]
			[Address(RVA = "0x8F6B44", Offset = "0x8F6B44", VA = "0x8F6B44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009F")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x6000602")]
			[Address(RVA = "0x8F6B70", Offset = "0x8F6B70", VA = "0x8F6B70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A0")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x6000603")]
			[Address(RVA = "0x8F6B9C", Offset = "0x8F6B9C", VA = "0x8F6B9C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A1")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x6000604")]
			[Address(RVA = "0x8F6BC8", Offset = "0x8F6BC8", VA = "0x8F6BC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A2")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x6000614")]
			[Address(RVA = "0x8F8E04", Offset = "0x8F8E04", VA = "0x8F8E04")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000615")]
			[Address(RVA = "0x8F8E10", Offset = "0x8F8E10", VA = "0x8F8E10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x8F6BF0", Offset = "0x8F6BF0", VA = "0x8F6BF0")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x8F6CF0", Offset = "0x8F6CF0", VA = "0x8F6CF0")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0x8F6C40", Offset = "0x8F6C40", VA = "0x8F6C40")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0x8F6D68", Offset = "0x8F6D68", VA = "0x8F6D68")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x8F68F4", Offset = "0x8F68F4", VA = "0x8F68F4")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0x8F6E30", Offset = "0x8F6E30", VA = "0x8F6E30")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0x8F6EE0", Offset = "0x8F6EE0", VA = "0x8F6EE0")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0x8F6F8C", Offset = "0x8F6F8C", VA = "0x8F6F8C")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0x8F7038", Offset = "0x8F7038", VA = "0x8F7038")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0x8F7040", Offset = "0x8F7040", VA = "0x8F7040")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0x8F7068", Offset = "0x8F7068", VA = "0x8F7068")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0x8F7128", Offset = "0x8F7128", VA = "0x8F7128", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0x8F72BC", Offset = "0x8F72BC", VA = "0x8F72BC")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x8F86FC", Offset = "0x8F86FC", VA = "0x8F86FC")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x8F8CAC", Offset = "0x8F8CAC", VA = "0x8F8CAC")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0x8F8D08", Offset = "0x8F8D08", VA = "0x8F8D08")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0x8F8B4C", Offset = "0x8F8B4C", VA = "0x8F8B4C")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x8F8BFC", Offset = "0x8F8BFC", VA = "0x8F8BFC")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x8F8E1C", Offset = "0x8F8E1C", VA = "0x8F8E1C")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x8F8EE0", Offset = "0x8F8EE0", VA = "0x8F8EE0", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x8F8FB0", Offset = "0x8F8FB0", VA = "0x8F8FB0")]
		private void PullBody()
		{
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x8F90CC", Offset = "0x8F90CC", VA = "0x8F90CC")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x8F925C", Offset = "0x8F925C", VA = "0x8F925C")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0x8F93D4", Offset = "0x8F93D4", VA = "0x8F93D4", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0x8F9634", Offset = "0x8F9634", VA = "0x8F9634", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0x8F96AC", Offset = "0x8F96AC", VA = "0x8F96AC")]
		public IKSolverFullBodyBiped()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000101")]
	public class IKSolverHeuristic : IKSolver
	{
		[Token(Token = "0x40006E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x40006E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float tolerance;

		[Token(Token = "0x40006E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int maxIterations;

		[Token(Token = "0x40006E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useRotationLimits;

		[Token(Token = "0x40006E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		public bool XY;

		[Token(Token = "0x40006EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Bone[] bones;

		[Token(Token = "0x40006EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Vector3 lastLocalDirection;

		[Token(Token = "0x40006EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		protected float chainLength;

		[Token(Token = "0x170000A3")]
		protected virtual int minBones
		{
			[Token(Token = "0x6000628")]
			[Address(RVA = "0x8F9F44", Offset = "0x8F9F44", VA = "0x8F9F44", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000A4")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x6000629")]
			[Address(RVA = "0x8F9F4C", Offset = "0x8F9F4C", VA = "0x8F9F4C", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A5")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x600062A")]
			[Address(RVA = "0x8F9F54", Offset = "0x8F9F54", VA = "0x8F9F54", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A6")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x600062E")]
			[Address(RVA = "0x8FA3F8", Offset = "0x8FA3F8", VA = "0x8FA3F8", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000A7")]
		protected float positionOffset
		{
			[Token(Token = "0x600062F")]
			[Address(RVA = "0x8FA4B4", Offset = "0x8FA4B4", VA = "0x8FA4B4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0x8F96B8", Offset = "0x8F96B8", VA = "0x8F96B8")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0x8F9868", Offset = "0x8F9868", VA = "0x8F9868")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0x8F99B4", Offset = "0x8F99B4", VA = "0x8F99B4", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0x8F9A14", Offset = "0x8F9A14", VA = "0x8F9A14", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0x8F9A80", Offset = "0x8F9A80", VA = "0x8F9A80", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0x8F9E60", Offset = "0x8F9E60", VA = "0x8F9E60", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0x8F9E68", Offset = "0x8F9E68", VA = "0x8F9E68", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0x8F9F5C", Offset = "0x8F9F5C", VA = "0x8F9F5C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0x8F9F60", Offset = "0x8F9F60", VA = "0x8F9F60", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0x8F9F64", Offset = "0x8F9F64", VA = "0x8F9F64")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0x8FA4FC", Offset = "0x8FA4FC", VA = "0x8FA4FC")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0x8FA8B4", Offset = "0x8FA8B4", VA = "0x8FA8B4")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0x8FAB48", Offset = "0x8FAB48", VA = "0x8FAB48")]
		public IKSolverHeuristic()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000102")]
	public class IKSolverLeg : IKSolver
	{
		[Token(Token = "0x40006ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Range(0f, 1f)]
		public float IKRotationWeight;

		[Token(Token = "0x40006EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x40006EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point pelvis;

		[Token(Token = "0x40006F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point thigh;

		[Token(Token = "0x40006F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point calf;

		[Token(Token = "0x40006F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point foot;

		[Token(Token = "0x40006F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point toe;

		[Token(Token = "0x40006F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public IKSolverVR.Leg leg;

		[Token(Token = "0x40006F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 heelOffset;

		[Token(Token = "0x40006F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] positions;

		[Token(Token = "0x40006F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Quaternion[] rotations;

		[Token(Token = "0x6000633")]
		[Address(RVA = "0x8FABBC", Offset = "0x8FABBC", VA = "0x8FABBC", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0x8FAF60", Offset = "0x8FAF60", VA = "0x8FAF60")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x8FB014", Offset = "0x8FB014", VA = "0x8FB014", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x8FB194", Offset = "0x8FB194", VA = "0x8FB194", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x8FB2F4", Offset = "0x8FB2F4", VA = "0x8FB2F4", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x8FB344", Offset = "0x8FB344", VA = "0x8FB344", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0x8FB394", Offset = "0x8FB394", VA = "0x8FB394", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0x8FB6EC", Offset = "0x8FB6EC", VA = "0x8FB6EC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0x8FB70C", Offset = "0x8FB70C", VA = "0x8FB70C")]
		private void Solve()
		{
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0x8FB3EC", Offset = "0x8FB3EC", VA = "0x8FB3EC")]
		private void Read()
		{
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0x8FB790", Offset = "0x8FB790", VA = "0x8FB790")]
		private void Write()
		{
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x8FB89C", Offset = "0x8FB89C", VA = "0x8FB89C")]
		public IKSolverLeg()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000103")]
	public class IKSolverLimb : IKSolverTrigonometric
	{
		[Serializable]
		[Token(Token = "0x2000104")]
		public enum BendModifier
		{
			[Token(Token = "0x4000709")]
			Animation,
			[Token(Token = "0x400070A")]
			Target,
			[Token(Token = "0x400070B")]
			Parent,
			[Token(Token = "0x400070C")]
			Arm,
			[Token(Token = "0x400070D")]
			Goal
		}

		[Serializable]
		[Token(Token = "0x2000105")]
		public struct AxisDirection
		{
			[Token(Token = "0x400070E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 direction;

			[Token(Token = "0x400070F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 axis;

			[Token(Token = "0x4000710")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float dot;

			[Token(Token = "0x6000649")]
			[Address(RVA = "0x8FCED4", Offset = "0x8FCED4", VA = "0x8FCED4")]
			public AxisDirection(Vector3 direction, Vector3 axis)
			{
			}
		}

		[Token(Token = "0x40006F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public AvatarIKGoal goal;

		[Token(Token = "0x40006F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public BendModifier bendModifier;

		[Token(Token = "0x40006FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[Range(0f, 1f)]
		public float maintainRotationWeight;

		[Token(Token = "0x40006FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[Range(0f, 1f)]
		public float bendModifierWeight;

		[Token(Token = "0x40006FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform bendGoal;

		[Token(Token = "0x40006FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool maintainBendFor1Frame;

		[Token(Token = "0x40006FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		private bool maintainRotationFor1Frame;

		[Token(Token = "0x40006FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion defaultRootRotation;

		[Token(Token = "0x4000700")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Quaternion parentDefaultRotation;

		[Token(Token = "0x4000701")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Quaternion bone3RotationBeforeSolve;

		[Token(Token = "0x4000702")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Quaternion maintainRotation;

		[Token(Token = "0x4000703")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private Quaternion bone3DefaultRotation;

		[Token(Token = "0x4000704")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Vector3 _bendNormal;

		[Token(Token = "0x4000705")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 animationNormal;

		[Token(Token = "0x4000706")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private AxisDirection[] axisDirectionsLeft;

		[Token(Token = "0x4000707")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private AxisDirection[] axisDirectionsRight;

		[Token(Token = "0x170000A8")]
		private AxisDirection[] axisDirections
		{
			[Token(Token = "0x6000646")]
			[Address(RVA = "0x8FCEB8", Offset = "0x8FCEB8", VA = "0x8FCEB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x8FBA94", Offset = "0x8FBA94", VA = "0x8FBA94")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0x8FBAD8", Offset = "0x8FBAD8", VA = "0x8FBAD8")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0x8FBB44", Offset = "0x8FBB44", VA = "0x8FBB44", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0x8FC08C", Offset = "0x8FC08C", VA = "0x8FC08C", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x8FCBA8", Offset = "0x8FCBA8", VA = "0x8FCBA8", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x8FCC50", Offset = "0x8FCC50", VA = "0x8FCC50")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0x8FCE20", Offset = "0x8FCE20", VA = "0x8FCE20")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x8FBEA0", Offset = "0x8FBEA0", VA = "0x8FBEA0")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x8FC148", Offset = "0x8FC148", VA = "0x8FC148")]
		private Vector3 GetModifiedBendNormal()
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000106")]
	public class IKSolverLookAt : IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000107")]
		public class LookAtBone : Bone
		{
			[Token(Token = "0x170000AF")]
			public Vector3 forward
			{
				[Token(Token = "0x6000668")]
				[Address(RVA = "0x8FEB04", Offset = "0x8FEB04", VA = "0x8FEB04")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000664")]
			[Address(RVA = "0x8FF1B4", Offset = "0x8FF1B4", VA = "0x8FF1B4")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x6000665")]
			[Address(RVA = "0x8FDE7C", Offset = "0x8FDE7C", VA = "0x8FDE7C")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x6000666")]
			[Address(RVA = "0x8FE170", Offset = "0x8FE170", VA = "0x8FE170")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x6000667")]
			[Address(RVA = "0x8FEE4C", Offset = "0x8FEE4C", VA = "0x8FEE4C")]
			public void LookAt(Vector3 direction, float weight)
			{
			}
		}

		[Token(Token = "0x4000711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x4000712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public LookAtBone[] spine;

		[Token(Token = "0x4000713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public LookAtBone head;

		[Token(Token = "0x4000714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public LookAtBone[] eyes;

		[Token(Token = "0x4000715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Range(0f, 1f)]
		public float bodyWeight;

		[Token(Token = "0x4000716")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[Range(0f, 1f)]
		public float headWeight;

		[Token(Token = "0x4000717")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Range(0f, 1f)]
		public float eyesWeight;

		[Token(Token = "0x4000718")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[Range(0f, 1f)]
		public float clampWeight;

		[Token(Token = "0x4000719")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[Range(0f, 1f)]
		public float clampWeightHead;

		[Token(Token = "0x400071A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[Range(0f, 1f)]
		public float clampWeightEyes;

		[Token(Token = "0x400071B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[Range(0f, 2f)]
		public int clampSmoothing;

		[Token(Token = "0x400071C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public AnimationCurve spineWeightCurve;

		[Token(Token = "0x400071D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector3[] spineForwards;

		[Token(Token = "0x400071E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3[] headForwards;

		[Token(Token = "0x400071F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] eyeForward;

		[Token(Token = "0x170000A9")]
		private bool spineIsValid
		{
			[Token(Token = "0x6000658")]
			[Address(RVA = "0x8FD600", Offset = "0x8FD600", VA = "0x8FD600")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000AA")]
		private bool spineIsEmpty
		{
			[Token(Token = "0x6000659")]
			[Address(RVA = "0x8FD7A8", Offset = "0x8FD7A8", VA = "0x8FD7A8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000AB")]
		private bool headIsValid
		{
			[Token(Token = "0x600065B")]
			[Address(RVA = "0x8FD6CC", Offset = "0x8FD6CC", VA = "0x8FD6CC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000AC")]
		private bool headIsEmpty
		{
			[Token(Token = "0x600065C")]
			[Address(RVA = "0x8FD7CC", Offset = "0x8FD7CC", VA = "0x8FD7CC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000AD")]
		private bool eyesIsValid
		{
			[Token(Token = "0x600065E")]
			[Address(RVA = "0x8FD6DC", Offset = "0x8FD6DC", VA = "0x8FD6DC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000AE")]
		private bool eyesIsEmpty
		{
			[Token(Token = "0x600065F")]
			[Address(RVA = "0x8FD838", Offset = "0x8FD838", VA = "0x8FD838")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x8FD070", Offset = "0x8FD070", VA = "0x8FD070")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x8FD08C", Offset = "0x8FD08C", VA = "0x8FD08C")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x8FD0B8", Offset = "0x8FD0B8", VA = "0x8FD0B8")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x8FD0F0", Offset = "0x8FD0F0", VA = "0x8FD0F0")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x8FD138", Offset = "0x8FD138", VA = "0x8FD138")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0x8FD190", Offset = "0x8FD190", VA = "0x8FD190")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x8FD200", Offset = "0x8FD200", VA = "0x8FD200", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0x8FD318", Offset = "0x8FD318", VA = "0x8FD318", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0x8FD43C", Offset = "0x8FD43C", VA = "0x8FD43C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0x8FD85C", Offset = "0x8FD85C", VA = "0x8FD85C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x8FDAB0", Offset = "0x8FDAB0", VA = "0x8FDAB0", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0x8FDC10", Offset = "0x8FDC10", VA = "0x8FDC10")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0x8FDEAC", Offset = "0x8FDEAC", VA = "0x8FDEAC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0x8FE25C", Offset = "0x8FE25C", VA = "0x8FE25C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x8FE320", Offset = "0x8FE320", VA = "0x8FE320")]
		private void SolveSpine()
		{
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0x8FE528", Offset = "0x8FE528", VA = "0x8FE528")]
		private void SolveHead()
		{
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0x8FE870", Offset = "0x8FE870", VA = "0x8FE870")]
		private void SolveEyes()
		{
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0x8FEB34", Offset = "0x8FEB34", VA = "0x8FEB34")]
		private Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0x8FDCD8", Offset = "0x8FDCD8", VA = "0x8FDCD8")]
		private void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0x8FEF54", Offset = "0x8FEF54", VA = "0x8FEF54")]
		public IKSolverLookAt()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000108")]
	public class IKSolverTrigonometric : IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000109")]
		public class TrigonometricBone : Bone
		{
			[Token(Token = "0x4000729")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion targetToLocalSpace;

			[Token(Token = "0x400072A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 defaultLocalBendNormal;

			[Token(Token = "0x6000680")]
			[Address(RVA = "0x9004CC", Offset = "0x9004CC", VA = "0x9004CC")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x6000681")]
			[Address(RVA = "0x900D68", Offset = "0x900D68", VA = "0x900D68")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000682")]
			[Address(RVA = "0x8FBB14", Offset = "0x8FBB14", VA = "0x8FBB14")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000683")]
			[Address(RVA = "0x900E04", Offset = "0x900E04", VA = "0x900E04")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x4000720")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x4000721")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Range(0f, 1f)]
		public float IKRotationWeight;

		[Token(Token = "0x4000722")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Quaternion IKRotation;

		[Token(Token = "0x4000723")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Vector3 bendNormal;

		[Token(Token = "0x4000724")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public TrigonometricBone bone1;

		[Token(Token = "0x4000725")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public TrigonometricBone bone2;

		[Token(Token = "0x4000726")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public TrigonometricBone bone3;

		[Token(Token = "0x4000727")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected Vector3 weightIKPosition;

		[Token(Token = "0x4000728")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		protected bool directHierarchy;

		[Token(Token = "0x6000669")]
		[Address(RVA = "0x8FF1BC", Offset = "0x8FF1BC", VA = "0x8FF1BC")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0x8FF350", Offset = "0x8FF350", VA = "0x8FF350")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0x8FF4D0", Offset = "0x8FF4D0", VA = "0x8FF4D0")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0x8FF4DC", Offset = "0x8FF4DC", VA = "0x8FF4DC")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0x8FF4F8", Offset = "0x8FF4F8", VA = "0x8FF4F8")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0x8FF504", Offset = "0x8FF504", VA = "0x8FF504")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0x8FF50C", Offset = "0x8FF50C", VA = "0x8FF50C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x8FF61C", Offset = "0x8FF61C", VA = "0x8FF61C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0x8FF714", Offset = "0x8FF714", VA = "0x8FF714", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0x8FF754", Offset = "0x8FF754", VA = "0x8FF754", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0x8FF794", Offset = "0x8FF794", VA = "0x8FF794", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x8FFB68", Offset = "0x8FFB68", VA = "0x8FFB68")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0x8FFBE4", Offset = "0x8FFBE4", VA = "0x8FFBE4")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0x9000D8", Offset = "0x9000D8", VA = "0x9000D8")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0x900230", Offset = "0x900230", VA = "0x900230", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0x9003DC", Offset = "0x9003DC", VA = "0x9003DC")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0x90035C", Offset = "0x90035C", VA = "0x90035C")]
		private void InitiateBones()
		{
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0x9005BC", Offset = "0x9005BC", VA = "0x9005BC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0x900DF8", Offset = "0x900DF8", VA = "0x900DF8", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0x900DFC", Offset = "0x900DFC", VA = "0x900DFC", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0x900E00", Offset = "0x900E00", VA = "0x900E00", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0x900BB4", Offset = "0x900BB4", VA = "0x900BB4")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0x8FCCD4", Offset = "0x8FCCD4", VA = "0x8FCCD4")]
		public IKSolverTrigonometric()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200010A")]
	public class IKSolverVR : IKSolver
	{
		[Serializable]
		[Token(Token = "0x200010B")]
		public class Arm : BodyPart
		{
			[Serializable]
			[Token(Token = "0x200010C")]
			public enum ShoulderRotationMode
			{
				[Token(Token = "0x4000766")]
				YawPitch,
				[Token(Token = "0x4000767")]
				FromTo
			}

			[Token(Token = "0x400074C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Tooltip("The hand target")]
			public Transform target;

			[Token(Token = "0x400074D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("The elbow will be bent towards this Transform if 'Bend Goal Weight' > 0.")]
			public Transform bendGoal;

			[Token(Token = "0x400074E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Range(0f, 1f)]
			[Tooltip("Positional weight of the hand target.")]
			public float positionWeight;

			[Token(Token = "0x400074F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[Tooltip("Rotational weight of the hand target")]
			[Range(0f, 1f)]
			public float rotationWeight;

			[Token(Token = "0x4000750")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Tooltip("Different techniques for shoulder bone rotation.")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x4000751")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[Range(0f, 1f)]
			[Tooltip("The weight of shoulder rotation")]
			public float shoulderRotationWeight;

			[Token(Token = "0x4000752")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[Tooltip("If greater than 0, will bend the elbow towards the 'Bend Goal' Transform.")]
			[Range(0f, 1f)]
			public float bendGoalWeight;

			[Token(Token = "0x4000753")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[Tooltip("Angular offset of the elbow bending direction.")]
			[Range(-180f, 180f)]
			public float swivelOffset;

			[Token(Token = "0x4000754")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[Tooltip("Local axis of the hand bone that points from the wrist towards the palm. Used for defining hand bone orientation.")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x4000755")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[Tooltip("Local axis of the hand bone that points from the palm towards the thumb. Used for defining hand bone orientation.")]
			public Vector3 palmToThumbAxis;

			[NonSerialized]
			[Token(Token = "0x4000756")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x4000757")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x4000758")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			[HideInInspector]
			public Vector3 bendDirection;

			[NonSerialized]
			[Token(Token = "0x4000759")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[HideInInspector]
			public Vector3 handPositionOffset;

			[Token(Token = "0x400075C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			private bool hasShoulder;

			[Token(Token = "0x400075D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			private Vector3 chestForwardAxis;

			[Token(Token = "0x400075E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private Vector3 chestUpAxis;

			[Token(Token = "0x400075F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
			private Quaternion chestRotation;

			[Token(Token = "0x4000760")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			private Vector3 chestForward;

			[Token(Token = "0x4000761")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
			private Vector3 chestUp;

			[Token(Token = "0x4000762")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
			private Quaternion forearmRelToUpperArm;

			[Token(Token = "0x4000763")]
			private const float yawOffsetAngle = 45f;

			[Token(Token = "0x4000764")]
			private const float pitchOffsetAngle = -30f;

			[Token(Token = "0x170000B1")]
			public Vector3 position
			{
				[Token(Token = "0x60006A2")]
				[Address(RVA = "0x905FB4", Offset = "0x905FB4", VA = "0x905FB4")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006A3")]
				[Address(RVA = "0x905FC0", Offset = "0x905FC0", VA = "0x905FC0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000B2")]
			public Quaternion rotation
			{
				[Token(Token = "0x60006A4")]
				[Address(RVA = "0x905FCC", Offset = "0x905FCC", VA = "0x905FCC")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60006A5")]
				[Address(RVA = "0x905FD8", Offset = "0x905FD8", VA = "0x905FD8")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000B3")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x60006A6")]
				[Address(RVA = "0x905FE4", Offset = "0x905FE4", VA = "0x905FE4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B4")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x60006A7")]
				[Address(RVA = "0x90600C", Offset = "0x90600C", VA = "0x90600C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B5")]
			private VirtualBone forearm
			{
				[Token(Token = "0x60006A8")]
				[Address(RVA = "0x906038", Offset = "0x906038", VA = "0x906038")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B6")]
			private VirtualBone hand
			{
				[Token(Token = "0x60006A9")]
				[Address(RVA = "0x906064", Offset = "0x906064", VA = "0x906064")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006AA")]
			[Address(RVA = "0x906090", Offset = "0x906090", VA = "0x906090", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60006AB")]
			[Address(RVA = "0x906828", Offset = "0x906828", VA = "0x906828", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x60006AC")]
			[Address(RVA = "0x906AD4", Offset = "0x906AD4", VA = "0x906AD4", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x60006AD")]
			[Address(RVA = "0x90414C", Offset = "0x90414C", VA = "0x90414C")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x60006AE")]
			[Address(RVA = "0x907064", Offset = "0x907064", VA = "0x907064", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x60006AF")]
			[Address(RVA = "0x9070BC", Offset = "0x9070BC", VA = "0x9070BC", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x60006B0")]
			[Address(RVA = "0x906AF8", Offset = "0x906AF8", VA = "0x906AF8")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x60006B1")]
			[Address(RVA = "0x906B78", Offset = "0x906B78", VA = "0x906B78")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006B2")]
			[Address(RVA = "0x9071BC", Offset = "0x9071BC", VA = "0x9071BC")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x60006B3")]
			[Address(RVA = "0x905E6C", Offset = "0x905E6C", VA = "0x905E6C")]
			public Arm()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200010D")]
		public abstract class BodyPart
		{
			[Token(Token = "0x400076A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public VirtualBone[] bones;

			[Token(Token = "0x400076B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			protected bool initiated;

			[Token(Token = "0x400076C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			protected Vector3 rootPosition;

			[Token(Token = "0x400076D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			protected Quaternion rootRotation;

			[Token(Token = "0x400076E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			protected int index;

			[Token(Token = "0x170000B7")]
			public float sqrMag
			{
				[Token(Token = "0x60006B9")]
				[Address(RVA = "0x9072D4", Offset = "0x9072D4", VA = "0x9072D4")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006BA")]
				[Address(RVA = "0x9072DC", Offset = "0x9072DC", VA = "0x9072DC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000B8")]
			public float mag
			{
				[Token(Token = "0x60006BB")]
				[Address(RVA = "0x9072E4", Offset = "0x9072E4", VA = "0x9072E4")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006BC")]
				[Address(RVA = "0x9072EC", Offset = "0x9072EC", VA = "0x9072EC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x60006B4")]
			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index);

			[Token(Token = "0x60006B5")]
			public abstract void PreSolve();

			[Token(Token = "0x60006B6")]
			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);

			[Token(Token = "0x60006B7")]
			public abstract void ApplyOffsets();

			[Token(Token = "0x60006B8")]
			public abstract void ResetOffsets();

			[Token(Token = "0x60006BD")]
			[Address(RVA = "0x9072F4", Offset = "0x9072F4", VA = "0x9072F4")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60006BE")]
			[Address(RVA = "0x907504", Offset = "0x907504", VA = "0x907504")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x60006BF")]
			[Address(RVA = "0x90758C", Offset = "0x90758C", VA = "0x90758C")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x60006C0")]
			[Address(RVA = "0x907790", Offset = "0x907790", VA = "0x907790")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x60006C1")]
			[Address(RVA = "0x9077D8", Offset = "0x9077D8", VA = "0x9077D8")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x60006C2")]
			[Address(RVA = "0x9078FC", Offset = "0x9078FC", VA = "0x9078FC")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x60006C3")]
			[Address(RVA = "0x907A60", Offset = "0x907A60", VA = "0x907A60")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x60006C4")]
			[Address(RVA = "0x907B84", Offset = "0x907B84", VA = "0x907B84")]
			public void Visualize()
			{
			}

			[Token(Token = "0x60006C5")]
			[Address(RVA = "0x907B98", Offset = "0x907B98", VA = "0x907B98")]
			protected BodyPart()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200010E")]
		public class Footstep
		{
			[Token(Token = "0x400076F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float stepSpeed;

			[Token(Token = "0x4000770")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 characterSpaceOffset;

			[Token(Token = "0x4000771")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 position;

			[Token(Token = "0x4000772")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion rotation;

			[Token(Token = "0x4000773")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Quaternion stepToRootRot;

			[Token(Token = "0x4000774")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public bool isSupportLeg;

			[Token(Token = "0x4000776")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 stepFrom;

			[Token(Token = "0x4000777")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 stepTo;

			[Token(Token = "0x4000778")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion stepFromRot;

			[Token(Token = "0x4000779")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			public Quaternion stepToRot;

			[Token(Token = "0x400077A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			private Quaternion footRelativeToRoot;

			[Token(Token = "0x400077B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			private float supportLegW;

			[Token(Token = "0x400077C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private float supportLegWV;

			[Token(Token = "0x170000B9")]
			public bool isStepping
			{
				[Token(Token = "0x60006C6")]
				[Address(RVA = "0x907C3C", Offset = "0x907C3C", VA = "0x907C3C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000BA")]
			public float stepProgress
			{
				[Token(Token = "0x60006C7")]
				[Address(RVA = "0x907C50", Offset = "0x907C50", VA = "0x907C50")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006C8")]
				[Address(RVA = "0x907C58", Offset = "0x907C58", VA = "0x907C58")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x60006C9")]
			[Address(RVA = "0x907C60", Offset = "0x907C60", VA = "0x907C60")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x60006CA")]
			[Address(RVA = "0x907D60", Offset = "0x907D60", VA = "0x907D60")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x60006CB")]
			[Address(RVA = "0x907E3C", Offset = "0x907E3C", VA = "0x907E3C")]
			public void StepTo(Vector3 p, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x60006CC")]
			[Address(RVA = "0x907EEC", Offset = "0x907EEC", VA = "0x907EEC")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Token(Token = "0x60006CD")]
			[Address(RVA = "0x9080F4", Offset = "0x9080F4", VA = "0x9080F4")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Token(Token = "0x60006CE")]
			[Address(RVA = "0x9082D8", Offset = "0x9082D8", VA = "0x9082D8")]
			public void Update(InterpolationMode interpolation, UnityEvent onStep)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200010F")]
		public class Leg : BodyPart
		{
			[Token(Token = "0x400077D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Tooltip("The toe/foot target.")]
			public Transform target;

			[Token(Token = "0x400077E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("The knee will be bent towards this Transform if 'Bend Goal Weight' > 0.")]
			public Transform bendGoal;

			[Token(Token = "0x400077F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Range(0f, 1f)]
			[Tooltip("Positional weight of the toe/foot target.")]
			public float positionWeight;

			[Token(Token = "0x4000780")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[Range(0f, 1f)]
			[Tooltip("Rotational weight of the toe/foot target.")]
			public float rotationWeight;

			[Token(Token = "0x4000781")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Range(0f, 1f)]
			[Tooltip("If greater than 0, will bend the knee towards the 'Bend Goal' Transform.")]
			public float bendGoalWeight;

			[Token(Token = "0x4000782")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[Tooltip("Angular offset of the knee bending direction.")]
			[Range(-180f, 180f)]
			public float swivelOffset;

			[NonSerialized]
			[Token(Token = "0x4000783")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x4000784")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x4000785")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[HideInInspector]
			public Vector3 footPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000786")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[HideInInspector]
			public Vector3 heelPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000787")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[HideInInspector]
			public Quaternion footRotationOffset;

			[NonSerialized]
			[Token(Token = "0x4000788")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			public float currentMag;

			[Token(Token = "0x400078D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			private Vector3 footPosition;

			[Token(Token = "0x400078E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private Quaternion footRotation;

			[Token(Token = "0x400078F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private Vector3 bendNormal;

			[Token(Token = "0x4000790")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			private Quaternion calfRelToThigh;

			[Token(Token = "0x170000BB")]
			public Vector3 position
			{
				[Token(Token = "0x60006CF")]
				[Address(RVA = "0x90844C", Offset = "0x90844C", VA = "0x90844C")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006D0")]
				[Address(RVA = "0x908458", Offset = "0x908458", VA = "0x908458")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000BC")]
			public Quaternion rotation
			{
				[Token(Token = "0x60006D1")]
				[Address(RVA = "0x908464", Offset = "0x908464", VA = "0x908464")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60006D2")]
				[Address(RVA = "0x908470", Offset = "0x908470", VA = "0x908470")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000BD")]
			public bool hasToes
			{
				[Token(Token = "0x60006D3")]
				[Address(RVA = "0x90847C", Offset = "0x90847C", VA = "0x90847C")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60006D4")]
				[Address(RVA = "0x908484", Offset = "0x908484", VA = "0x908484")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000BE")]
			public VirtualBone thigh
			{
				[Token(Token = "0x60006D5")]
				[Address(RVA = "0x908490", Offset = "0x908490", VA = "0x908490")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BF")]
			private VirtualBone calf
			{
				[Token(Token = "0x60006D6")]
				[Address(RVA = "0x9084B8", Offset = "0x9084B8", VA = "0x9084B8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C0")]
			private VirtualBone foot
			{
				[Token(Token = "0x60006D7")]
				[Address(RVA = "0x9084E4", Offset = "0x9084E4", VA = "0x9084E4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C1")]
			private VirtualBone toes
			{
				[Token(Token = "0x60006D8")]
				[Address(RVA = "0x908510", Offset = "0x908510", VA = "0x908510")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C2")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x60006D9")]
				[Address(RVA = "0x90853C", Offset = "0x90853C", VA = "0x90853C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C3")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x60006DA")]
				[Address(RVA = "0x908570", Offset = "0x908570", VA = "0x908570")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006DB")]
				[Address(RVA = "0x90857C", Offset = "0x90857C", VA = "0x90857C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x60006DC")]
			[Address(RVA = "0x908588", Offset = "0x908588", VA = "0x908588", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60006DD")]
			[Address(RVA = "0x908AD8", Offset = "0x908AD8", VA = "0x908AD8", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x60006DE")]
			[Address(RVA = "0x9090AC", Offset = "0x9090AC", VA = "0x9090AC", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x60006DF")]
			[Address(RVA = "0x90905C", Offset = "0x90905C", VA = "0x90905C")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x60006E0")]
			[Address(RVA = "0x908E20", Offset = "0x908E20", VA = "0x908E20")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x60006E1")]
			[Address(RVA = "0x909584", Offset = "0x909584", VA = "0x909584")]
			public void Solve()
			{
			}

			[Token(Token = "0x60006E2")]
			[Address(RVA = "0x909C6C", Offset = "0x909C6C", VA = "0x909C6C", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x60006E3")]
			[Address(RVA = "0x909D68", Offset = "0x909D68", VA = "0x909D68", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x60006E4")]
			[Address(RVA = "0x909E48", Offset = "0x909E48", VA = "0x909E48")]
			public Leg()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000110")]
		public class Locomotion
		{
			[Token(Token = "0x4000791")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Used for blending in/out of procedural locomotion.")]
			[Range(0f, 1f)]
			public float weight;

			[Token(Token = "0x4000792")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("Tries to maintain this distance between the legs.")]
			public float footDistance;

			[Token(Token = "0x4000793")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Makes a step only if step target position is at least this far from the current footstep or the foot does not reach the current footstep anymore or footstep angle is past the 'Angle Threshold'.")]
			public float stepThreshold;

			[Token(Token = "0x4000794")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Tooltip("Makes a step only if step target position is at least 'Step Threshold' far from the current footstep or the foot does not reach the current footstep anymore or footstep angle is past this value.")]
			public float angleThreshold;

			[Token(Token = "0x4000795")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Multiplies angle of the center of mass - center of pressure vector. Larger value makes the character step sooner if losing balance.")]
			public float comAngleMlp;

			[Token(Token = "0x4000796")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("Maximum magnitude of head/hand target velocity used in prediction.")]
			public float maxVelocity;

			[Token(Token = "0x4000797")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The amount of head/hand target velocity prediction.")]
			public float velocityFactor;

			[Token(Token = "0x4000798")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Range(0.9f, 1f)]
			[Tooltip("How much can a leg be extended before it is forced to step to another position? 1 means fully stretched.")]
			public float maxLegStretch;

			[Token(Token = "0x4000799")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("The speed of lerping the root of the character towards the horizontal mid-point of the footsteps.")]
			public float rootSpeed;

			[Token(Token = "0x400079A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[Tooltip("The speed of steps.")]
			public float stepSpeed;

			[Token(Token = "0x400079B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[Tooltip("The height of the foot by normalized step progress (0 - 1).")]
			public AnimationCurve stepHeight;

			[Token(Token = "0x400079C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[Tooltip("The height offset of the heel by normalized step progress (0 - 1).")]
			public AnimationCurve heelHeight;

			[Token(Token = "0x400079D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Range(0f, 180f)]
			[Tooltip("Rotates the foot while the leg is not stepping to relax the twist rotation of the leg if ideal rotation is past this angle.")]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x400079E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[Tooltip("The speed of rotating the foot while the leg is not stepping to relax the twist rotation of the leg.")]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x400079F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("Interpolation mode of the step.")]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x40007A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[Tooltip("Offset for the approximated center of mass.")]
			public Vector3 offset;

			[Token(Token = "0x40007A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[HideInInspector]
			public bool blockingEnabled;

			[Token(Token = "0x40007A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[HideInInspector]
			public LayerMask blockingLayers;

			[Token(Token = "0x40007A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[HideInInspector]
			public float raycastRadius;

			[Token(Token = "0x40007A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[HideInInspector]
			public float raycastHeight;

			[Token(Token = "0x40007A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[Tooltip("Called when the left foot has finished a step.")]
			public UnityEvent onLeftFootstep;

			[Token(Token = "0x40007A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[Tooltip("Called when the right foot has finished a step")]
			public UnityEvent onRightFootstep;

			[Token(Token = "0x40007A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private Footstep[] footsteps;

			[Token(Token = "0x40007A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private Vector3 lastComPosition;

			[Token(Token = "0x40007AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private Vector3 comVelocity;

			[Token(Token = "0x40007AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private int leftFootIndex;

			[Token(Token = "0x40007AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			private int rightFootIndex;

			[Token(Token = "0x170000C4")]
			public Vector3 centerOfMass
			{
				[Token(Token = "0x60006E5")]
				[Address(RVA = "0x909EC4", Offset = "0x909EC4", VA = "0x909EC4")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006E6")]
				[Address(RVA = "0x909ED0", Offset = "0x909ED0", VA = "0x909ED0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000C5")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x60006EC")]
				[Address(RVA = "0x90BFA4", Offset = "0x90BFA4", VA = "0x90BFA4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000C6")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x60006ED")]
				[Address(RVA = "0x90BFD8", Offset = "0x90BFD8", VA = "0x90BFD8")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000C7")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x60006EE")]
				[Address(RVA = "0x90C010", Offset = "0x90C010", VA = "0x90C010")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x170000C8")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x60006EF")]
				[Address(RVA = "0x90C044", Offset = "0x90C044", VA = "0x90C044")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x60006E7")]
			[Address(RVA = "0x909EDC", Offset = "0x909EDC", VA = "0x909EDC")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes)
			{
			}

			[Token(Token = "0x60006E8")]
			[Address(RVA = "0x90A1F0", Offset = "0x90A1F0", VA = "0x90A1F0")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x60006E9")]
			[Address(RVA = "0x90A3D4", Offset = "0x90A3D4", VA = "0x90A3D4")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x60006EA")]
			[Address(RVA = "0x90A79C", Offset = "0x90A79C", VA = "0x90A79C")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x60006EB")]
			[Address(RVA = "0x90A854", Offset = "0x90A854", VA = "0x90A854")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset)
			{
			}

			[Token(Token = "0x60006F0")]
			[Address(RVA = "0x90BBD4", Offset = "0x90BBD4", VA = "0x90BBD4")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x60006F1")]
			[Address(RVA = "0x90BD88", Offset = "0x90BD88", VA = "0x90BD88")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x60006F2")]
			[Address(RVA = "0x90BDF4", Offset = "0x90BDF4", VA = "0x90BDF4")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x60006F3")]
			[Address(RVA = "0x90C07C", Offset = "0x90C07C", VA = "0x90C07C")]
			public Locomotion()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000111")]
		public class Spine : BodyPart
		{
			[Token(Token = "0x40007AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Tooltip("The head target.")]
			public Transform headTarget;

			[Token(Token = "0x40007AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("The pelvis target, useful with seated rigs.")]
			public Transform pelvisTarget;

			[Token(Token = "0x40007AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Positional weight of the head target.")]
			[Range(0f, 1f)]
			public float positionWeight;

			[Token(Token = "0x40007B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[Tooltip("Rotational weight of the head target.")]
			[Range(0f, 1f)]
			public float rotationWeight;

			[Token(Token = "0x40007B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Tooltip("Positional weight of the pelvis target.")]
			[Range(0f, 1f)]
			public float pelvisPositionWeight;

			[Token(Token = "0x40007B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[Tooltip("Rotational weight of the pelvis target.")]
			[Range(0f, 1f)]
			public float pelvisRotationWeight;

			[Token(Token = "0x40007B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[Tooltip("If 'Chest Goal Weight' is greater than 0, the chest will be turned towards this Transform.")]
			public Transform chestGoal;

			[Token(Token = "0x40007B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[Range(0f, 1f)]
			[Tooltip("Rotational weight of the chest target.")]
			public float chestGoalWeight;

			[Token(Token = "0x40007B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[Tooltip("Minimum height of the head from the root of the character.")]
			public float minHeadHeight;

			[Token(Token = "0x40007B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[Range(0f, 1f)]
			[Tooltip("Determines how much the body will follow the position of the head.")]
			public float bodyPosStiffness;

			[Token(Token = "0x40007B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[Range(0f, 1f)]
			[Tooltip("Determines how much the body will follow the rotation of the head.")]
			public float bodyRotStiffness;

			[Token(Token = "0x40007B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[Range(0f, 1f)]
			[FormerlySerializedAs("chestRotationWeight")]
			[Tooltip("Determines how much the chest will rotate to the rotation of the head.")]
			public float neckStiffness;

			[Token(Token = "0x40007B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[Range(0f, 1f)]
			[Tooltip("Clamps chest rotation.")]
			public float chestClampWeight;

			[Token(Token = "0x40007BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[Range(0f, 1f)]
			[Tooltip("Clamps head rotation.")]
			public float headClampWeight;

			[Token(Token = "0x40007BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[Range(0f, 1f)]
			[Tooltip("How much will the pelvis maintain it's animated position?")]
			public float maintainPelvisPosition;

			[Token(Token = "0x40007BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[Range(0f, 180f)]
			[Tooltip("Will automatically rotate the root of the character if the head target has turned past this angle.")]
			public float maxRootAngle;

			[NonSerialized]
			[Token(Token = "0x40007BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[HideInInspector]
			public Vector3 IKPositionHead;

			[NonSerialized]
			[Token(Token = "0x40007BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[HideInInspector]
			public Quaternion IKRotationHead;

			[NonSerialized]
			[Token(Token = "0x40007BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[HideInInspector]
			public Vector3 IKPositionPelvis;

			[NonSerialized]
			[Token(Token = "0x40007C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[HideInInspector]
			public Quaternion IKRotationPelvis;

			[NonSerialized]
			[Token(Token = "0x40007C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			[HideInInspector]
			public Vector3 goalPositionChest;

			[NonSerialized]
			[Token(Token = "0x40007C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[HideInInspector]
			public Vector3 pelvisPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40007C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			[HideInInspector]
			public Vector3 chestPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40007C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			[HideInInspector]
			public Vector3 headPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40007C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			[HideInInspector]
			public Quaternion pelvisRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40007C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
			[HideInInspector]
			public Quaternion chestRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40007C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
			[HideInInspector]
			public Quaternion headRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40007C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
			[HideInInspector]
			public Vector3 faceDirection;

			[NonSerialized]
			[Token(Token = "0x40007C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			[HideInInspector]
			public Vector3 locomotionHeadPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40007CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
			[HideInInspector]
			public Vector3 headPosition;

			[Token(Token = "0x40007CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
			private Quaternion headRotation;

			[Token(Token = "0x40007CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
			private Quaternion anchorRelativeToHead;

			[Token(Token = "0x40007CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
			private Quaternion pelvisRelativeRotation;

			[Token(Token = "0x40007CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
			private Quaternion chestRelativeRotation;

			[Token(Token = "0x40007D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
			private Vector3 headDeltaPosition;

			[Token(Token = "0x40007D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
			private Quaternion pelvisDeltaRotation;

			[Token(Token = "0x40007D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
			private Quaternion chestTargetRotation;

			[Token(Token = "0x40007D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
			private int pelvisIndex;

			[Token(Token = "0x40007D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
			private int spineIndex;

			[Token(Token = "0x40007D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
			private int chestIndex;

			[Token(Token = "0x40007D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
			private int neckIndex;

			[Token(Token = "0x40007D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
			private int headIndex;

			[Token(Token = "0x40007D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
			private float length;

			[Token(Token = "0x40007D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
			private bool hasChest;

			[Token(Token = "0x40007DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E5")]
			private bool hasNeck;

			[Token(Token = "0x40007DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
			private float headHeight;

			[Token(Token = "0x40007DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1EC")]
			private float sizeMlp;

			[Token(Token = "0x40007DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
			private Vector3 chestForward;

			[Token(Token = "0x170000C9")]
			public VirtualBone pelvis
			{
				[Token(Token = "0x60006F4")]
				[Address(RVA = "0x90BB6C", Offset = "0x90BB6C", VA = "0x90BB6C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CA")]
			public VirtualBone firstSpineBone
			{
				[Token(Token = "0x60006F5")]
				[Address(RVA = "0x90C18C", Offset = "0x90C18C", VA = "0x90C18C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CB")]
			public VirtualBone chest
			{
				[Token(Token = "0x60006F6")]
				[Address(RVA = "0x90C1C0", Offset = "0x90C1C0", VA = "0x90C1C0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CC")]
			private VirtualBone neck
			{
				[Token(Token = "0x60006F7")]
				[Address(RVA = "0x90C208", Offset = "0x90C208", VA = "0x90C208")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CD")]
			public VirtualBone head
			{
				[Token(Token = "0x60006F8")]
				[Address(RVA = "0x90BBA0", Offset = "0x90BBA0", VA = "0x90BBA0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CE")]
			public Quaternion anchorRotation
			{
				[Token(Token = "0x60006F9")]
				[Address(RVA = "0x90C23C", Offset = "0x90C23C", VA = "0x90C23C")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60006FA")]
				[Address(RVA = "0x90C250", Offset = "0x90C250", VA = "0x90C250")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x60006FB")]
			[Address(RVA = "0x90C264", Offset = "0x90C264", VA = "0x90C264", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60006FC")]
			[Address(RVA = "0x90CE88", Offset = "0x90CE88", VA = "0x90CE88", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x60006FD")]
			[Address(RVA = "0x90D034", Offset = "0x90D034", VA = "0x90D034", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x60006FE")]
			[Address(RVA = "0x90D634", Offset = "0x90D634", VA = "0x90D634")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x60006FF")]
			[Address(RVA = "0x90DBAC", Offset = "0x90DBAC", VA = "0x90DBAC")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms)
			{
			}

			[Token(Token = "0x6000700")]
			[Address(RVA = "0x90EC34", Offset = "0x90EC34", VA = "0x90EC34")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x6000701")]
			[Address(RVA = "0x90EEDC", Offset = "0x90EEDC", VA = "0x90EEDC", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000702")]
			[Address(RVA = "0x90F0AC", Offset = "0x90F0AC", VA = "0x90F0AC", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000703")]
			[Address(RVA = "0x90D878", Offset = "0x90D878", VA = "0x90D878")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x6000704")]
			[Address(RVA = "0x90E948", Offset = "0x90E948", VA = "0x90E948")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x6000705")]
			[Address(RVA = "0x90E108", Offset = "0x90E108", VA = "0x90E108")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation)
			{
			}

			[Token(Token = "0x6000706")]
			[Address(RVA = "0x90F17C", Offset = "0x90F17C", VA = "0x90F17C")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000707")]
			[Address(RVA = "0x90EA38", Offset = "0x90EA38", VA = "0x90EA38")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000708")]
			[Address(RVA = "0x90E730", Offset = "0x90E730", VA = "0x90E730")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000709")]
			[Address(RVA = "0x90F41C", Offset = "0x90F41C", VA = "0x90F41C")]
			public Spine()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000112")]
		public enum PositionOffset
		{
			[Token(Token = "0x40007DF")]
			Pelvis,
			[Token(Token = "0x40007E0")]
			Chest,
			[Token(Token = "0x40007E1")]
			Head,
			[Token(Token = "0x40007E2")]
			LeftHand,
			[Token(Token = "0x40007E3")]
			RightHand,
			[Token(Token = "0x40007E4")]
			LeftFoot,
			[Token(Token = "0x40007E5")]
			RightFoot,
			[Token(Token = "0x40007E6")]
			LeftHeel,
			[Token(Token = "0x40007E7")]
			RightHeel
		}

		[Serializable]
		[Token(Token = "0x2000113")]
		public enum RotationOffset
		{
			[Token(Token = "0x40007E9")]
			Pelvis,
			[Token(Token = "0x40007EA")]
			Chest,
			[Token(Token = "0x40007EB")]
			Head
		}

		[Serializable]
		[Token(Token = "0x2000114")]
		public class VirtualBone
		{
			[Token(Token = "0x40007EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 readPosition;

			[Token(Token = "0x40007ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Quaternion readRotation;

			[Token(Token = "0x40007EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 solverPosition;

			[Token(Token = "0x40007EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Quaternion solverRotation;

			[Token(Token = "0x40007F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float length;

			[Token(Token = "0x40007F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float sqrMag;

			[Token(Token = "0x40007F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Vector3 axis;

			[Token(Token = "0x600070A")]
			[Address(RVA = "0x908A48", Offset = "0x908A48", VA = "0x908A48")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x600070B")]
			[Address(RVA = "0x908AB8", Offset = "0x908AB8", VA = "0x908AB8")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x600070C")]
			[Address(RVA = "0x90F518", Offset = "0x90F518", VA = "0x90F518")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600070D")]
			[Address(RVA = "0x9073A4", Offset = "0x9073A4", VA = "0x9073A4")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x600070E")]
			[Address(RVA = "0x907620", Offset = "0x907620", VA = "0x907620")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x600070F")]
			[Address(RVA = "0x90F718", Offset = "0x90F718", VA = "0x90F718")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000710")]
			[Address(RVA = "0x90F8C0", Offset = "0x90F8C0", VA = "0x90F8C0")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000711")]
			[Address(RVA = "0x90FA48", Offset = "0x90FA48", VA = "0x90FA48")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000712")]
			[Address(RVA = "0x909888", Offset = "0x909888", VA = "0x909888")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x6000713")]
			[Address(RVA = "0x90FAEC", Offset = "0x90FAEC", VA = "0x90FAEC")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000714")]
			[Address(RVA = "0x90E420", Offset = "0x90E420", VA = "0x90E420")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length)
			{
			}

			[Token(Token = "0x6000715")]
			[Address(RVA = "0x90FC44", Offset = "0x90FC44", VA = "0x90FC44")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000716")]
			[Address(RVA = "0x90FD58", Offset = "0x90FD58", VA = "0x90FD58")]
			public static void SolveCCD(VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations)
			{
			}
		}

		[Token(Token = "0x400072B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] solverTransforms;

		[Token(Token = "0x400072C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool hasChest;

		[Token(Token = "0x400072D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool hasNeck;

		[Token(Token = "0x400072E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool hasShoulders;

		[Token(Token = "0x400072F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool hasToes;

		[Token(Token = "0x4000730")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] readPositions;

		[Token(Token = "0x4000731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] readRotations;

		[Token(Token = "0x4000732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3[] solvedPositions;

		[Token(Token = "0x4000733")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Quaternion[] solvedRotations;

		[Token(Token = "0x4000734")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 defaultPelvisLocalPosition;

		[Token(Token = "0x4000735")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x4000736")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector3 rootV;

		[Token(Token = "0x4000737")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 rootVelocity;

		[Token(Token = "0x4000738")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 bodyOffset;

		[Token(Token = "0x4000739")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int supportLegIndex;

		[Token(Token = "0x400073A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[Tooltip("If true, will keep the toes planted even if head target is out of reach.")]
		public bool plantFeet;

		[Token(Token = "0x400073C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[Tooltip("The spine solver.")]
		public Spine spine;

		[Token(Token = "0x400073D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[Tooltip("The left arm solver.")]
		public Arm leftArm;

		[Token(Token = "0x400073E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[Tooltip("The right arm solver.")]
		public Arm rightArm;

		[Token(Token = "0x400073F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[Tooltip("The left leg solver.")]
		public Leg leftLeg;

		[Token(Token = "0x4000740")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[Tooltip("The right leg solver.")]
		public Leg rightLeg;

		[Token(Token = "0x4000741")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[Tooltip("The procedural locomotion solver.")]
		public Locomotion locomotion;

		[Token(Token = "0x4000742")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Leg[] legs;

		[Token(Token = "0x4000743")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Arm[] arms;

		[Token(Token = "0x4000744")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Vector3 headPosition;

		[Token(Token = "0x4000745")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private Vector3 headDeltaPosition;

		[Token(Token = "0x4000746")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Vector3 raycastOriginPelvis;

		[Token(Token = "0x4000747")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private Vector3 lastOffset;

		[Token(Token = "0x4000748")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Vector3 debugPos1;

		[Token(Token = "0x4000749")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		private Vector3 debugPos2;

		[Token(Token = "0x400074A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private Vector3 debugPos3;

		[Token(Token = "0x400074B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private Vector3 debugPos4;

		[Token(Token = "0x170000B0")]
		[HideInInspector]
		public VirtualBone rootBone
		{
			[Token(Token = "0x600069D")]
			[Address(RVA = "0x905B8C", Offset = "0x905B8C", VA = "0x905B8C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600069E")]
			[Address(RVA = "0x905B94", Offset = "0x905B94", VA = "0x905B94")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0x900E0C", Offset = "0x900E0C", VA = "0x900E0C")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0x901238", Offset = "0x901238", VA = "0x901238")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0x9010CC", Offset = "0x9010CC", VA = "0x9010CC")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0x901A60", Offset = "0x901A60", VA = "0x901A60")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0x901BA4", Offset = "0x901BA4", VA = "0x901BA4")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0x901BE4", Offset = "0x901BE4", VA = "0x901BE4")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0x901D70", Offset = "0x901D70", VA = "0x901D70")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0x901E4C", Offset = "0x901E4C", VA = "0x901E4C")]
		public void Reset()
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0x9025F0", Offset = "0x9025F0", VA = "0x9025F0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0x90271C", Offset = "0x90271C", VA = "0x90271C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0x902848", Offset = "0x902848", VA = "0x902848", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0x9028B8", Offset = "0x9028B8", VA = "0x9028B8", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0x902928", Offset = "0x902928", VA = "0x902928", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0x902B30", Offset = "0x902B30", VA = "0x902B30")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0x901520", Offset = "0x901520", VA = "0x901520")]
		private Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0x901604", Offset = "0x901604", VA = "0x901604")]
		private Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0x90194C", Offset = "0x90194C", VA = "0x90194C")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0x901F4C", Offset = "0x901F4C", VA = "0x901F4C")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0x902DA0", Offset = "0x902DA0", VA = "0x902DA0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0x902DCC", Offset = "0x902DCC", VA = "0x902DCC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0x903EB0", Offset = "0x903EB0", VA = "0x903EB0")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0x90209C", Offset = "0x90209C", VA = "0x90209C")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes)
		{
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0x902E24", Offset = "0x902E24", VA = "0x902E24")]
		private void Solve()
		{
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0x904068", Offset = "0x904068", VA = "0x904068")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0x904114", Offset = "0x904114", VA = "0x904114")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0x903D7C", Offset = "0x903D7C", VA = "0x903D7C")]
		private void Write()
		{
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x9054A0", Offset = "0x9054A0", VA = "0x9054A0")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x905B9C", Offset = "0x905B9C", VA = "0x905B9C")]
		public IKSolverVR()
		{
		}
	}
	[Token(Token = "0x2000115")]
	public class TwistRelaxer : MonoBehaviour
	{
		[Token(Token = "0x40007F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The weight of relaxing the twist of this Transform")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x40007F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(0f, 1f)]
		[Tooltip("If 0.5, this Transform will be twisted half way from parent to child. If 1, the twist angle will be locked to the child and will rotate with along with it.")]
		public float parentChildCrossfade;

		[Token(Token = "0x40007F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 twistAxis;

		[Token(Token = "0x40007F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 axis;

		[Token(Token = "0x40007F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 axisRelativeToParentDefault;

		[Token(Token = "0x40007F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 axisRelativeToChildDefault;

		[Token(Token = "0x40007F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform parent;

		[Token(Token = "0x40007FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform child;

		[Token(Token = "0x6000717")]
		[Address(RVA = "0x90FF0C", Offset = "0x90FF0C", VA = "0x90FF0C")]
		public void Relax()
		{
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0x9101E0", Offset = "0x9101E0", VA = "0x9101E0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0x9103F4", Offset = "0x9103F4", VA = "0x9103F4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0x9103F8", Offset = "0x9103F8", VA = "0x9103F8")]
		public TwistRelaxer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000116")]
	public class InteractionEffector
	{
		[Token(Token = "0x40007FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Poser poser;

		[Token(Token = "0x40007FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IKEffector effector;

		[Token(Token = "0x4000800")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float timer;

		[Token(Token = "0x4000801")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float length;

		[Token(Token = "0x4000802")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float weight;

		[Token(Token = "0x4000803")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float fadeInSpeed;

		[Token(Token = "0x4000804")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float defaultPositionWeight;

		[Token(Token = "0x4000805")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float defaultRotationWeight;

		[Token(Token = "0x4000806")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float defaultPull;

		[Token(Token = "0x4000807")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float defaultReach;

		[Token(Token = "0x4000808")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float defaultPush;

		[Token(Token = "0x4000809")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float defaultPushParent;

		[Token(Token = "0x400080A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float resetTimer;

		[Token(Token = "0x400080B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private bool positionWeightUsed;

		[Token(Token = "0x400080C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
		private bool rotationWeightUsed;

		[Token(Token = "0x400080D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5E")]
		private bool pullUsed;

		[Token(Token = "0x400080E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5F")]
		private bool reachUsed;

		[Token(Token = "0x400080F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool pushUsed;

		[Token(Token = "0x4000810")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool pushParentUsed;

		[Token(Token = "0x4000811")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool pickedUp;

		[Token(Token = "0x4000812")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool defaults;

		[Token(Token = "0x4000813")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool pickUpOnPostFBBIK;

		[Token(Token = "0x4000814")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x4000815")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3 pausePositionRelative;

		[Token(Token = "0x4000816")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x4000817")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion pauseRotationRelative;

		[Token(Token = "0x4000818")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private InteractionTarget interactionTarget;

		[Token(Token = "0x4000819")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Transform target;

		[Token(Token = "0x400081A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private List<bool> triggered;

		[Token(Token = "0x400081B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x400081C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool started;

		[Token(Token = "0x170000CF")]
		public FullBodyBipedEffector effectorType
		{
			[Token(Token = "0x600071B")]
			[Address(RVA = "0x910498", Offset = "0x910498", VA = "0x910498")]
			[CompilerGenerated]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x600071C")]
			[Address(RVA = "0x9104A0", Offset = "0x9104A0", VA = "0x9104A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000D0")]
		public bool isPaused
		{
			[Token(Token = "0x600071D")]
			[Address(RVA = "0x9104A8", Offset = "0x9104A8", VA = "0x9104A8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600071E")]
			[Address(RVA = "0x9104B0", Offset = "0x9104B0", VA = "0x9104B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000D1")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x600071F")]
			[Address(RVA = "0x9104BC", Offset = "0x9104BC", VA = "0x9104BC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000720")]
			[Address(RVA = "0x9104C4", Offset = "0x9104C4", VA = "0x9104C4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000D2")]
		public bool inInteraction
		{
			[Token(Token = "0x6000721")]
			[Address(RVA = "0x9104CC", Offset = "0x9104CC", VA = "0x9104CC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000D3")]
		public float progress
		{
			[Token(Token = "0x600072A")]
			[Address(RVA = "0x9129FC", Offset = "0x9129FC", VA = "0x9129FC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000722")]
		[Address(RVA = "0x91052C", Offset = "0x91052C", VA = "0x91052C")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0x9105C8", Offset = "0x9105C8", VA = "0x9105C8")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0x910688", Offset = "0x910688", VA = "0x910688")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x6000725")]
		[Address(RVA = "0x9107BC", Offset = "0x9107BC", VA = "0x9107BC")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Token(Token = "0x6000726")]
		[Address(RVA = "0x910AEC", Offset = "0x910AEC", VA = "0x910AEC")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0x910C0C", Offset = "0x910C0C", VA = "0x910C0C")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0x910C60", Offset = "0x910C60", VA = "0x910C60")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0x91179C", Offset = "0x91179C", VA = "0x91179C")]
		public void Update(Transform root, float speed)
		{
		}

		[Token(Token = "0x600072B")]
		[Address(RVA = "0x912250", Offset = "0x912250", VA = "0x912250")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0x912470", Offset = "0x912470", VA = "0x912470")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x600072D")]
		[Address(RVA = "0x912898", Offset = "0x912898", VA = "0x912898")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x600072E")]
		[Address(RVA = "0x912BEC", Offset = "0x912BEC", VA = "0x912BEC")]
		public void OnPostFBBIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000117")]
	public class InteractionLookAt
	{
		[Token(Token = "0x400081D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Tooltip("(Optional) reference to the LookAtIK component that will be used to make the character look at the objects that it is interacting with.")]
		public LookAtIK ik;

		[Token(Token = "0x400081E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Interpolation speed of the LookAtIK target.")]
		public float lerpSpeed;

		[Token(Token = "0x400081F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("Interpolation speed of the LookAtIK weight.")]
		public float weightSpeed;

		[Token(Token = "0x4000820")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public bool isPaused;

		[Token(Token = "0x4000821")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform lookAtTarget;

		[Token(Token = "0x4000822")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float stopLookTime;

		[Token(Token = "0x4000823")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float weight;

		[Token(Token = "0x4000824")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool firstFBBIKSolve;

		[Token(Token = "0x600072F")]
		[Address(RVA = "0x912E28", Offset = "0x912E28", VA = "0x912E28")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0x912F44", Offset = "0x912F44", VA = "0x912F44")]
		public void Update()
		{
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0x91314C", Offset = "0x91314C", VA = "0x91314C")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0x9131F4", Offset = "0x9131F4", VA = "0x9131F4")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0x9132A0", Offset = "0x9132A0", VA = "0x9132A0")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x2000118")]
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Object")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000119")]
		public class InteractionEvent
		{
			[Token(Token = "0x400082E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The time of the event since interaction start.")]
			public float time;

			[Token(Token = "0x400082F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("If true, the interaction will be paused on this event. The interaction can be resumed by InteractionSystem.ResumeInteraction() or InteractionSystem.ResumeAll;")]
			public bool pause;

			[Token(Token = "0x4000830")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[Tooltip("If true, the object will be parented to the effector bone on this event. Note that picking up like this can be done by only a single effector at a time. If you wish to pick up an object with both hands, see the Interaction PickUp2Handed demo scene.")]
			public bool pickUp;

			[Token(Token = "0x4000831")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The animations called on this event.")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x4000832")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The messages sent on this event using GameObject.SendMessage().")]
			public Message[] messages;

			[Token(Token = "0x6000750")]
			[Address(RVA = "0x912A2C", Offset = "0x912A2C", VA = "0x912A2C")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x6000751")]
			[Address(RVA = "0x9141D4", Offset = "0x9141D4", VA = "0x9141D4")]
			public InteractionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200011A")]
		public class Message
		{
			[Token(Token = "0x4000833")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The name of the function called.")]
			public string function;

			[Token(Token = "0x4000834")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The recipient game object.")]
			public GameObject recipient;

			[Token(Token = "0x4000835")]
			private const string empty = "";

			[Token(Token = "0x6000752")]
			[Address(RVA = "0x9140DC", Offset = "0x9140DC", VA = "0x9140DC")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x6000753")]
			[Address(RVA = "0x9141DC", Offset = "0x9141DC", VA = "0x9141DC")]
			public Message()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200011B")]
		public class AnimatorEvent
		{
			[Token(Token = "0x4000836")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The Animator component that will receive the AnimatorEvents.")]
			public Animator animator;

			[Token(Token = "0x4000837")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The Animation component that will receive the AnimatorEvents (Legacy).")]
			public Animation animation;

			[Token(Token = "0x4000838")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The name of the animation state.")]
			public string animationState;

			[Token(Token = "0x4000839")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The crossfading time.")]
			public float crossfadeTime;

			[Token(Token = "0x400083A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("The layer of the animation state (if using Legacy, the animation state will be forced to this layer).")]
			public int layer;

			[Token(Token = "0x400083B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("Should the animation always start from 0 normalized time?")]
			public bool resetNormalizedTime;

			[Token(Token = "0x400083C")]
			private const string empty = "";

			[Token(Token = "0x6000754")]
			[Address(RVA = "0x914000", Offset = "0x914000", VA = "0x914000")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x6000755")]
			[Address(RVA = "0x9141E4", Offset = "0x9141E4", VA = "0x9141E4")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x6000756")]
			[Address(RVA = "0x914294", Offset = "0x914294", VA = "0x914294")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x6000757")]
			[Address(RVA = "0x91436C", Offset = "0x91436C", VA = "0x91436C")]
			public AnimatorEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200011C")]
		public class WeightCurve
		{
			[Serializable]
			[Token(Token = "0x200011D")]
			public enum Type
			{
				[Token(Token = "0x4000840")]
				PositionWeight,
				[Token(Token = "0x4000841")]
				RotationWeight,
				[Token(Token = "0x4000842")]
				PositionOffsetX,
				[Token(Token = "0x4000843")]
				PositionOffsetY,
				[Token(Token = "0x4000844")]
				PositionOffsetZ,
				[Token(Token = "0x4000845")]
				Pull,
				[Token(Token = "0x4000846")]
				Reach,
				[Token(Token = "0x4000847")]
				RotateBoneWeight,
				[Token(Token = "0x4000848")]
				Push,
				[Token(Token = "0x4000849")]
				PushParent,
				[Token(Token = "0x400084A")]
				PoserWeight
			}

			[Token(Token = "0x400083D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The type of the curve (InteractionObject.WeightCurve.Type).")]
			public Type type;

			[Token(Token = "0x400083E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The weight curve.")]
			public AnimationCurve curve;

			[Token(Token = "0x6000758")]
			[Address(RVA = "0x9138EC", Offset = "0x9138EC", VA = "0x9138EC")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x6000759")]
			[Address(RVA = "0x914380", Offset = "0x914380", VA = "0x914380")]
			public WeightCurve()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200011E")]
		public class Multiplier
		{
			[Token(Token = "0x400084B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The curve type to multiply.")]
			public WeightCurve.Type curve;

			[Token(Token = "0x400084C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("The multiplier of the curve's value.")]
			public float multiplier;

			[Token(Token = "0x400084D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The resulting value will be applied to this channel.")]
			public WeightCurve.Type result;

			[Token(Token = "0x600075A")]
			[Address(RVA = "0x913E84", Offset = "0x913E84", VA = "0x913E84")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x600075B")]
			[Address(RVA = "0x914388", Offset = "0x914388", VA = "0x914388")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x4000825")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If the Interaction System has a 'Look At' LookAtIK component assigned, will use it to make the character look at the specified Transform. If unassigned, will look at this GameObject.")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x4000826")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The root Transform of the InteractionTargets. If null, will use this GameObject. GetComponentsInChildren<InteractionTarget>() will be used at initiation to find all InteractionTargets associated with this InteractionObject.")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x4000827")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("If assigned, all PositionOffset channels will be applied in the rotation space of this Transform. If not, they will be in the rotation space of the character.")]
		public Transform positionOffsetSpace;

		[Token(Token = "0x4000828")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public WeightCurve[] weightCurves;

		[Token(Token = "0x4000829")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Multiplier[] multipliers;

		[Token(Token = "0x400082A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionEvent[] events;

		[Token(Token = "0x400082D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InteractionTarget[] targets;

		[Token(Token = "0x170000D4")]
		public float length
		{
			[Token(Token = "0x600073A")]
			[Address(RVA = "0x91344C", Offset = "0x91344C", VA = "0x91344C")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600073B")]
			[Address(RVA = "0x913454", Offset = "0x913454", VA = "0x913454")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000D5")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x600073C")]
			[Address(RVA = "0x91345C", Offset = "0x91345C", VA = "0x91345C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600073D")]
			[Address(RVA = "0x913464", Offset = "0x913464", VA = "0x913464")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000D6")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x600073F")]
			[Address(RVA = "0x913624", Offset = "0x913624", VA = "0x913624")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D7")]
		public Transform targetsRoot
		{
			[Token(Token = "0x6000747")]
			[Address(RVA = "0x912AE0", Offset = "0x912AE0", VA = "0x912AE0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0x9132B4", Offset = "0x9132B4", VA = "0x9132B4")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0x9132F8", Offset = "0x9132F8", VA = "0x9132F8")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0x91333C", Offset = "0x91333C", VA = "0x91333C")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0x913380", Offset = "0x913380", VA = "0x913380")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0x9133C4", Offset = "0x9133C4", VA = "0x9133C4")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0x913408", Offset = "0x913408", VA = "0x913408")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0x91346C", Offset = "0x91346C", VA = "0x91346C")]
		public void Initiate()
		{
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0x9136A4", Offset = "0x9136A4", VA = "0x9136A4")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0x91125C", Offset = "0x91125C", VA = "0x91125C")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0x91381C", Offset = "0x91381C", VA = "0x91381C")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0x911118", Offset = "0x911118", VA = "0x911118")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0x911254", Offset = "0x911254", VA = "0x911254")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0x911E48", Offset = "0x911E48", VA = "0x911E48")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0x91268C", Offset = "0x91268C", VA = "0x91268C")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0x913EB4", Offset = "0x913EB4", VA = "0x913EB4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0x913908", Offset = "0x913908", VA = "0x913908")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0x913824", Offset = "0x913824", VA = "0x913824")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0x913E28", Offset = "0x913E28", VA = "0x913E28")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0x913EB8", Offset = "0x913EB8", VA = "0x913EB8")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0x913F14", Offset = "0x913F14", VA = "0x913F14")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0x913F58", Offset = "0x913F58", VA = "0x913F58")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0x913F9C", Offset = "0x913F9C", VA = "0x913F9C")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x200011F")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction System")]
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x2000120")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x2000121")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x400084E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If not empty, only the targets with the specified tag will be used by this Interaction System.")]
		public string targetTag;

		[Token(Token = "0x400084F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The fade in time of the interaction.")]
		public float fadeInTime;

		[Token(Token = "0x4000850")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("The master speed for all interactions.")]
		public float speed;

		[Token(Token = "0x4000851")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("If > 0, lerps all the FBBIK channels used by the Interaction System back to their default or initial values when not in interaction.")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x4000852")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The collider that registers OnTriggerEnter and OnTriggerExit events with InteractionTriggers.")]
		[Header("Triggering")]
		[FormerlySerializedAs("collider")]
		public Collider characterCollider;

		[Token(Token = "0x4000853")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[FormerlySerializedAs("camera")]
		[Tooltip("Will be used by Interaction Triggers that need the camera's position. Assign the first person view character camera.")]
		public Transform FPSCamera;

		[Token(Token = "0x4000854")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The layers that will be raycasted from the camera (along camera.forward). All InteractionTrigger look at target colliders should be included.")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x4000855")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("Max distance of raycasting from the camera.")]
		public float camRaycastDistance;

		[Token(Token = "0x4000857")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<InteractionTrigger> inContact;

		[Token(Token = "0x4000858")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<int> bestRangeIndexes;

		[Token(Token = "0x4000859")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public InteractionDelegate OnInteractionStart;

		[Token(Token = "0x400085A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public InteractionDelegate OnInteractionPause;

		[Token(Token = "0x400085B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public InteractionDelegate OnInteractionPickUp;

		[Token(Token = "0x400085C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public InteractionDelegate OnInteractionResume;

		[Token(Token = "0x400085D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public InteractionDelegate OnInteractionStop;

		[Token(Token = "0x400085E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public InteractionEventDelegate OnInteractionEvent;

		[Token(Token = "0x400085F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public RaycastHit raycastHit;

		[Token(Token = "0x4000860")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[Space(10f)]
		[Tooltip("Reference to the FBBIK component.")]
		[SerializeField]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x4000861")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[Tooltip("Handles looking at the interactions.")]
		public InteractionLookAt lookAt;

		[Token(Token = "0x4000862")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private InteractionEffector[] interactionEffectors;

		[Token(Token = "0x4000863")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool initiated;

		[Token(Token = "0x4000864")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Collider lastCollider;

		[Token(Token = "0x4000865")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Collider c;

		[Token(Token = "0x170000D8")]
		public bool inInteraction
		{
			[Token(Token = "0x6000762")]
			[Address(RVA = "0x914530", Offset = "0x914530", VA = "0x914530")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000D9")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x600077C")]
			[Address(RVA = "0x915FD8", Offset = "0x915FD8", VA = "0x915FD8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600077D")]
			[Address(RVA = "0x915FE0", Offset = "0x915FE0", VA = "0x915FE0")]
			set
			{
			}
		}

		[Token(Token = "0x170000DA")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x600077E")]
			[Address(RVA = "0x915FE8", Offset = "0x915FE8", VA = "0x915FE8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600077F")]
			[Address(RVA = "0x915FF0", Offset = "0x915FF0", VA = "0x915FF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0x914398", Offset = "0x914398", VA = "0x914398")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x600075D")]
		[Address(RVA = "0x9143DC", Offset = "0x9143DC", VA = "0x9143DC")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x600075E")]
		[Address(RVA = "0x914420", Offset = "0x914420", VA = "0x914420")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0x914464", Offset = "0x914464", VA = "0x914464")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0x9144A8", Offset = "0x9144A8", VA = "0x9144A8")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0x9144EC", Offset = "0x9144EC", VA = "0x9144EC")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0x9146A8", Offset = "0x9146A8", VA = "0x9146A8")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0x914760", Offset = "0x914760", VA = "0x914760")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0x914818", Offset = "0x914818", VA = "0x914818")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x6000766")]
		[Address(RVA = "0x9148B0", Offset = "0x9148B0", VA = "0x9148B0")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0x914994", Offset = "0x914994", VA = "0x914994")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0x914A8C", Offset = "0x914A8C", VA = "0x914A8C")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0x914B10", Offset = "0x914B10", VA = "0x914B10")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0x914B94", Offset = "0x914B94", VA = "0x914B94")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600076B")]
		[Address(RVA = "0x914C18", Offset = "0x914C18", VA = "0x914C18")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x600076C")]
		[Address(RVA = "0x914C80", Offset = "0x914C80", VA = "0x914C80")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0x914CE8", Offset = "0x914CE8", VA = "0x914CE8")]
		public void StopAll()
		{
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0x914D44", Offset = "0x914D44", VA = "0x914D44")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0x914DC4", Offset = "0x914DC4", VA = "0x914DC4")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0x914E6C", Offset = "0x914E6C", VA = "0x914E6C")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0x914F3C", Offset = "0x914F3C", VA = "0x914F3C")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0x9151CC", Offset = "0x9151CC", VA = "0x9151CC")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x6000773")]
		[Address(RVA = "0x9153A0", Offset = "0x9153A0", VA = "0x9153A0")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0x915610", Offset = "0x915610", VA = "0x915610")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0x91589C", Offset = "0x91589C", VA = "0x91589C")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0x9158D4", Offset = "0x9158D4", VA = "0x9158D4")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0x915934", Offset = "0x915934", VA = "0x915934")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0x915A60", Offset = "0x915A60", VA = "0x915A60")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0x915C44", Offset = "0x915C44", VA = "0x915C44")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0x915EB8", Offset = "0x915EB8", VA = "0x915EB8")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x600077B")]
		[Address(RVA = "0x9156F8", Offset = "0x9156F8", VA = "0x9156F8")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0x915FF8", Offset = "0x915FF8", VA = "0x915FF8", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0x916864", Offset = "0x916864", VA = "0x916864")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0x916884", Offset = "0x916884", VA = "0x916884")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0x9168A0", Offset = "0x9168A0", VA = "0x9168A0")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000784")]
		[Address(RVA = "0x9168BC", Offset = "0x9168BC", VA = "0x9168BC")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0x916910", Offset = "0x916910", VA = "0x916910")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0x916A94", Offset = "0x916A94", VA = "0x916A94")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x6000787")]
		[Address(RVA = "0x916B90", Offset = "0x916B90", VA = "0x916B90")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0x916EEC", Offset = "0x916EEC", VA = "0x916EEC")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0x917004", Offset = "0x917004", VA = "0x917004")]
		private void Update()
		{
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0x9172EC", Offset = "0x9172EC", VA = "0x9172EC")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0x916604", Offset = "0x916604", VA = "0x916604")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0x91741C", Offset = "0x91741C", VA = "0x91741C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0x917528", Offset = "0x917528", VA = "0x917528")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0x9175B8", Offset = "0x9175B8", VA = "0x9175B8")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0x917688", Offset = "0x917688", VA = "0x917688")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0x9145C8", Offset = "0x9145C8", VA = "0x9145C8")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0x9150B8", Offset = "0x9150B8", VA = "0x9150B8")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0x917A6C", Offset = "0x917A6C", VA = "0x917A6C")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0x917AB0", Offset = "0x917AB0", VA = "0x917AB0")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0x917AF4", Offset = "0x917AF4", VA = "0x917AF4")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x2000122")]
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Target")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000123")]
		public class Multiplier
		{
			[Token(Token = "0x4000870")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The curve type (InteractionObject.WeightCurve.Type).")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x4000871")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("Multiplier of the curve's value.")]
			public float multiplier;

			[Token(Token = "0x60007A9")]
			[Address(RVA = "0x9183E8", Offset = "0x9183E8", VA = "0x9183E8")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x4000866")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The type of the FBBIK effector.")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x4000867")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("InteractionObject weight curve multipliers for this effector target.")]
		public Multiplier[] multipliers;

		[Token(Token = "0x4000868")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The interaction speed multiplier for this effector. This can be used to make interactions faster/slower for specific effectors.")]
		public float interactionSpeedMlp;

		[Token(Token = "0x4000869")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The pivot to twist/swing this interaction target about. For symmetric objects that can be interacted with from a certain angular range.")]
		public Transform pivot;

		[Token(Token = "0x400086A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The axis of twisting the interaction target (blue line).")]
		public Vector3 twistAxis;

		[Token(Token = "0x400086B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("The weight of twisting the interaction target towards the effector bone in the start of the interaction.")]
		public float twistWeight;

		[Token(Token = "0x400086C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The weight of swinging the interaction target towards the effector bone in the start of the interaction. Swing is defined as a 3-DOF rotation around any axis, while twist is only around the twist axis.")]
		public float swingWeight;

		[Token(Token = "0x400086D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("If true, will twist/swing around the pivot only once at the start of the interaction. If false, will continue rotating throuout the whole interaction.")]
		public bool rotateOnce;

		[Token(Token = "0x400086E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x400086F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform lastPivot;

		[Token(Token = "0x600079D")]
		[Address(RVA = "0x918158", Offset = "0x918158", VA = "0x918158")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0x91819C", Offset = "0x91819C", VA = "0x91819C")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0x9181E0", Offset = "0x9181E0", VA = "0x9181E0")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x918224", Offset = "0x918224", VA = "0x918224")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x918268", Offset = "0x918268", VA = "0x918268")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x9182AC", Offset = "0x9182AC", VA = "0x9182AC")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x913888", Offset = "0x913888", VA = "0x913888")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x912B60", Offset = "0x912B60", VA = "0x912B60")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x9112F0", Offset = "0x9112F0", VA = "0x9112F0")]
		public void RotateTo(Vector3 position)
		{
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x9182F0", Offset = "0x9182F0", VA = "0x9182F0")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x918334", Offset = "0x918334", VA = "0x918334")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x918378", Offset = "0x918378", VA = "0x918378")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x2000124")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Trigger")]
	[HelpURL("https://www.youtube.com/watch?v=-TDZpNjt2mk&index=15&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000125")]
		public class CharacterPosition
		{
			[Token(Token = "0x4000873")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("If false, will not care where the character stands, as long as it is in contact with the trigger collider.")]
			public bool use;

			[Token(Token = "0x4000874")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("The offset of the character's position relative to the trigger in XZ plane. Y position of the character is unlimited as long as it is contact with the collider.")]
			public Vector2 offset;

			[Token(Token = "0x4000875")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Range(-180f, 180f)]
			[Tooltip("Angle offset from the default forward direction.")]
			public float angleOffset;

			[Token(Token = "0x4000876")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Range(0f, 180f)]
			[Tooltip("Max angular offset of the character's forward from the direction of this trigger.")]
			public float maxAngle;

			[Token(Token = "0x4000877")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("Max offset of the character's position from this range's center.")]
			public float radius;

			[Token(Token = "0x4000878")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("If true, will rotate the trigger around it's Y axis relative to the position of the character, so the object can be interacted with from all sides.")]
			public bool orbit;

			[Token(Token = "0x4000879")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			[Tooltip("Fixes the Y axis of the trigger to Vector3.up. This makes the trigger symmetrical relative to the object. For example a gun will be able to be picked up from the same direction relative to the barrel no matter which side the gun is resting on.")]
			public bool fixYAxis;

			[Token(Token = "0x170000DB")]
			public Vector3 offset3D
			{
				[Token(Token = "0x60007B0")]
				[Address(RVA = "0x9185D4", Offset = "0x9185D4", VA = "0x9185D4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000DC")]
			public Vector3 direction3D
			{
				[Token(Token = "0x60007B1")]
				[Address(RVA = "0x9185E0", Offset = "0x9185E0", VA = "0x9185E0")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x60007B2")]
			[Address(RVA = "0x9186A0", Offset = "0x9186A0", VA = "0x9186A0")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x60007B3")]
			[Address(RVA = "0x918E04", Offset = "0x918E04", VA = "0x918E04")]
			public CharacterPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000126")]
		public class CameraPosition
		{
			[Token(Token = "0x400087A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("What the camera should be looking at to trigger the interaction?")]
			public Collider lookAtTarget;

			[Token(Token = "0x400087B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The direction from the lookAtTarget towards the camera (in lookAtTarget's space).")]
			public Vector3 direction;

			[Token(Token = "0x400087C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("Max distance from the lookAtTarget to the camera.")]
			public float maxDistance;

			[Token(Token = "0x400087D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Range(0f, 180f)]
			[Tooltip("Max angle between the direction and the direction towards the camera.")]
			public float maxAngle;

			[Token(Token = "0x400087E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("Fixes the Y axis of the trigger to Vector3.up. This makes the trigger symmetrical relative to the object.")]
			public bool fixYAxis;

			[Token(Token = "0x60007B4")]
			[Address(RVA = "0x918E18", Offset = "0x918E18", VA = "0x918E18")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60007B5")]
			[Address(RVA = "0x918F90", Offset = "0x918F90", VA = "0x918F90")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x60007B6")]
			[Address(RVA = "0x919298", Offset = "0x919298", VA = "0x919298")]
			public CameraPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000127")]
		public class Range
		{
			[Serializable]
			[Token(Token = "0x2000128")]
			public class Interaction
			{
				[Token(Token = "0x4000884")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("The InteractionObject to interact with.")]
				public InteractionObject interactionObject;

				[Token(Token = "0x4000885")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[Tooltip("The effectors to interact with.")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x60007B9")]
				[Address(RVA = "0x91931C", Offset = "0x91931C", VA = "0x91931C")]
				public Interaction()
				{
				}
			}

			[Token(Token = "0x400087F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			[SerializeField]
			public string name;

			[Token(Token = "0x4000880")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			[HideInInspector]
			public bool show;

			[Token(Token = "0x4000881")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The range for the character's position and rotation.")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x4000882")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The range for the character camera's position and rotation.")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x4000883")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("Definitions of the interactions associated with this range.")]
			public Interaction[] interactions;

			[Token(Token = "0x60007B7")]
			[Address(RVA = "0x9184C0", Offset = "0x9184C0", VA = "0x9184C0")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x60007B8")]
			[Address(RVA = "0x91930C", Offset = "0x91930C", VA = "0x91930C")]
			public Range()
			{
			}
		}

		[Token(Token = "0x4000872")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The valid ranges of the character's and/or it's camera's position for triggering interaction when the character is in contact with the collider of this trigger.")]
		public Range[] ranges;

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x9183F0", Offset = "0x9183F0", VA = "0x9183F0")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x918434", Offset = "0x918434", VA = "0x918434")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x918478", Offset = "0x918478", VA = "0x918478")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x9184BC", Offset = "0x9184BC", VA = "0x9184BC")]
		private void Start()
		{
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x916D38", Offset = "0x916D38", VA = "0x916D38")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x918570", Offset = "0x918570", VA = "0x918570")]
		public InteractionTrigger()
		{
		}
	}
	[Token(Token = "0x2000129")]
	public class GenericPoser : Poser
	{
		[Serializable]
		[Token(Token = "0x200012A")]
		public class Map
		{
			[Token(Token = "0x4000887")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform bone;

			[Token(Token = "0x4000888")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform target;

			[Token(Token = "0x4000889")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector3 defaultLocalPosition;

			[Token(Token = "0x400088A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x60007C1")]
			[Address(RVA = "0x9197E0", Offset = "0x9197E0", VA = "0x9197E0")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x60007C2")]
			[Address(RVA = "0x91982C", Offset = "0x91982C", VA = "0x91982C")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x60007C3")]
			[Address(RVA = "0x919870", Offset = "0x919870", VA = "0x919870")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x60007C4")]
			[Address(RVA = "0x9198B0", Offset = "0x9198B0", VA = "0x9198B0")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x4000886")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x919324", Offset = "0x919324", VA = "0x919324", Slot = "7")]
		[ContextMenu("Auto-Mapping")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x919680", Offset = "0x919680", VA = "0x919680", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x919684", Offset = "0x919684", VA = "0x919684", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x919778", Offset = "0x919778", VA = "0x919778", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x919620", Offset = "0x919620", VA = "0x919620")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x91958C", Offset = "0x91958C", VA = "0x91958C")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x9197D8", Offset = "0x9197D8", VA = "0x9197D8")]
		public GenericPoser()
		{
		}
	}
	[Token(Token = "0x200012B")]
	public class HandPoser : Poser
	{
		[Token(Token = "0x400088B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform _poseRoot;

		[Token(Token = "0x400088C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] children;

		[Token(Token = "0x400088D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform[] poseChildren;

		[Token(Token = "0x400088E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x400088F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x9199D0", Offset = "0x9199D0", VA = "0x9199D0", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x919AA0", Offset = "0x919AA0", VA = "0x919AA0", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x919C78", Offset = "0x919C78", VA = "0x919C78", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x919D60", Offset = "0x919D60", VA = "0x919D60", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x919B00", Offset = "0x919B00", VA = "0x919B00")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x91A090", Offset = "0x91A090", VA = "0x91A090")]
		public HandPoser()
		{
		}
	}
	[Token(Token = "0x200012C")]
	public abstract class Poser : SolverManager
	{
		[Token(Token = "0x4000890")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform poseRoot;

		[Token(Token = "0x4000891")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x4000892")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Range(0f, 1f)]
		public float localRotationWeight;

		[Token(Token = "0x4000893")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Range(0f, 1f)]
		public float localPositionWeight;

		[Token(Token = "0x4000894")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool initiated;

		[Token(Token = "0x60007CB")]
		public abstract void AutoMapping();

		[Token(Token = "0x60007CC")]
		protected abstract void InitiatePoser();

		[Token(Token = "0x60007CD")]
		protected abstract void UpdatePoser();

		[Token(Token = "0x60007CE")]
		protected abstract void FixPoserTransforms();

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x91A0B0", Offset = "0x91A0B0", VA = "0x91A0B0", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x91A0F4", Offset = "0x91A0F4", VA = "0x91A0F4", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0x91A120", Offset = "0x91A120", VA = "0x91A120", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x91A0A0", Offset = "0x91A0A0", VA = "0x91A0A0")]
		protected Poser()
		{
		}
	}
	[Token(Token = "0x200012D")]
	[RequireComponent(typeof(Animator))]
	public class RagdollUtility : MonoBehaviour
	{
		[Token(Token = "0x200012E")]
		public class Rigidbone
		{
			[Token(Token = "0x40008A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody r;

			[Token(Token = "0x40008A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform t;

			[Token(Token = "0x40008A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Collider collider;

			[Token(Token = "0x40008A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Joint joint;

			[Token(Token = "0x40008A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Rigidbody c;

			[Token(Token = "0x40008AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool updateAnchor;

			[Token(Token = "0x40008AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 deltaPosition;

			[Token(Token = "0x40008AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Quaternion deltaRotation;

			[Token(Token = "0x40008AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float deltaTime;

			[Token(Token = "0x40008AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 lastPosition;

			[Token(Token = "0x40008AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Quaternion lastRotation;

			[Token(Token = "0x60007E5")]
			[Address(RVA = "0x91A790", Offset = "0x91A790", VA = "0x91A790")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x60007E6")]
			[Address(RVA = "0x91B33C", Offset = "0x91B33C", VA = "0x91B33C")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x60007E7")]
			[Address(RVA = "0x91B0FC", Offset = "0x91B0FC", VA = "0x91B0FC")]
			public void WakeUp(float velocityWeight, float angularVelocityWeight)
			{
			}
		}

		[Token(Token = "0x200012F")]
		public class Child
		{
			[Token(Token = "0x40008B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform t;

			[Token(Token = "0x40008B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 localPosition;

			[Token(Token = "0x40008B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Quaternion localRotation;

			[Token(Token = "0x60007E8")]
			[Address(RVA = "0x91A938", Offset = "0x91A938", VA = "0x91A938")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x60007E9")]
			[Address(RVA = "0x91B454", Offset = "0x91B454", VA = "0x91B454")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x60007EA")]
			[Address(RVA = "0x91B410", Offset = "0x91B410", VA = "0x91B410")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x2000130")]
		[CompilerGenerated]
		private sealed class <DisableRagdollSmooth>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40008B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RagdollUtility <>4__this;

			[Token(Token = "0x170000DF")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007EE")]
				[Address(RVA = "0x91B9C0", Offset = "0x91B9C0", VA = "0x91B9C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E0")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007F0")]
				[Address(RVA = "0x91BA08", Offset = "0x91BA08", VA = "0x91BA08", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007EB")]
			[Address(RVA = "0x91A9A4", Offset = "0x91A9A4", VA = "0x91A9A4")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x60007EC")]
			[Address(RVA = "0x91B7D0", Offset = "0x91B7D0", VA = "0x91B7D0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007ED")]
			[Address(RVA = "0x91B7D4", Offset = "0x91B7D4", VA = "0x91B7D4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007EF")]
			[Address(RVA = "0x91B9C8", Offset = "0x91B9C8", VA = "0x91B9C8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000895")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If you have multiple IK components, then this should be the one that solves last each frame.")]
		public IK ik;

		[Token(Token = "0x4000896")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("How long does it take to blend from ragdoll to animation?")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x4000897")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("If true, IK can be used on top of physical ragdoll simulation.")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x4000898")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("How much velocity transfer from animation to ragdoll?")]
		public float applyVelocity;

		[Token(Token = "0x4000899")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("How much angular velocity to transfer from animation to ragdoll?")]
		public float applyAngularVelocity;

		[Token(Token = "0x400089A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animator animator;

		[Token(Token = "0x400089B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbone[] rigidbones;

		[Token(Token = "0x400089C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Child[] children;

		[Token(Token = "0x400089D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool enableRagdollFlag;

		[Token(Token = "0x400089E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorUpdateMode animatorUpdateMode;

		[Token(Token = "0x400089F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IK[] allIKComponents;

		[Token(Token = "0x40008A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool[] fixTransforms;

		[Token(Token = "0x40008A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float ragdollWeight;

		[Token(Token = "0x40008A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float ragdollWeightV;

		[Token(Token = "0x40008A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool fixedFrame;

		[Token(Token = "0x40008A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] disabledIKComponents;

		[Token(Token = "0x170000DD")]
		private bool isRagdoll
		{
			[Token(Token = "0x60007DE")]
			[Address(RVA = "0x91A164", Offset = "0x91A164", VA = "0x91A164")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000DE")]
		private bool ikUsed
		{
			[Token(Token = "0x60007E0")]
			[Address(RVA = "0x91AD30", Offset = "0x91AD30", VA = "0x91AD30")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x91A138", Offset = "0x91A138", VA = "0x91A138")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x91A1C8", Offset = "0x91A1C8", VA = "0x91A1C8")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0x91A2E0", Offset = "0x91A2E0", VA = "0x91A2E0")]
		public void Start()
		{
		}

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0x91A26C", Offset = "0x91A26C", VA = "0x91A26C")]
		[IteratorStateMachine(typeof(<DisableRagdollSmooth>d__21))]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0x91A9CC", Offset = "0x91A9CC", VA = "0x91A9CC")]
		private void Update()
		{
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0x91ABF4", Offset = "0x91ABF4", VA = "0x91ABF4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60007D9")]
		[Address(RVA = "0x91AC94", Offset = "0x91AC94", VA = "0x91AC94")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0x91AE84", Offset = "0x91AE84", VA = "0x91AE84")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x60007DB")]
		[Address(RVA = "0x91AD04", Offset = "0x91AD04", VA = "0x91AD04")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x91AE50", Offset = "0x91AE50", VA = "0x91AE50")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0x91AF04", Offset = "0x91AF04", VA = "0x91AF04")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x91AEA8", Offset = "0x91AEA8", VA = "0x91AEA8")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0x91A210", Offset = "0x91A210", VA = "0x91A210")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x91AC28", Offset = "0x91AC28", VA = "0x91AC28")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x91B564", Offset = "0x91B564", VA = "0x91B564")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x91B69C", Offset = "0x91B69C", VA = "0x91B69C")]
		public RagdollUtility()
		{
		}
	}
	[Token(Token = "0x2000131")]
	public abstract class RotationLimit : MonoBehaviour
	{
		[Token(Token = "0x40008B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 axis;

		[Token(Token = "0x40008B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[HideInInspector]
		public Quaternion defaultLocalRotation;

		[Token(Token = "0x40008B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool initiated;

		[Token(Token = "0x40008B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		private bool applicationQuit;

		[Token(Token = "0x40008BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		private bool defaultLocalRotationSet;

		[Token(Token = "0x170000E1")]
		public Vector3 secondaryAxis
		{
			[Token(Token = "0x60007F5")]
			[Address(RVA = "0x91BD8C", Offset = "0x91BD8C", VA = "0x91BD8C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000E2")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x60007F6")]
			[Address(RVA = "0x91BD98", Offset = "0x91BD98", VA = "0x91BD98")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0x91BA10", Offset = "0x91BA10", VA = "0x91BA10")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0x91BA48", Offset = "0x91BA48", VA = "0x91BA48")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0x91BCFC", Offset = "0x91BCFC", VA = "0x91BCFC")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0x91BD60", Offset = "0x91BD60", VA = "0x91BD60")]
		public void Disable()
		{
		}

		[Token(Token = "0x60007F7")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x60007F8")]
		[Address(RVA = "0x91BC00", Offset = "0x91BC00", VA = "0x91BC00")]
		private void Awake()
		{
		}

		[Token(Token = "0x60007F9")]
		[Address(RVA = "0x91BDC8", Offset = "0x91BDC8", VA = "0x91BDC8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0x91BDCC", Offset = "0x91BDCC", VA = "0x91BDCC")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60007FB")]
		[Address(RVA = "0x91BDF4", Offset = "0x91BDF4", VA = "0x91BDF4")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60007FC")]
		[Address(RVA = "0x91BEC8", Offset = "0x91BEC8", VA = "0x91BEC8")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60007FD")]
		[Address(RVA = "0x91C120", Offset = "0x91C120", VA = "0x91C120")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0x91C274", Offset = "0x91C274", VA = "0x91C274")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x2000132")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Angle")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page12.html")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x40008BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 180f)]
		public float limit;

		[Token(Token = "0x40008BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 180f)]
		public float twistLimit;

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0x91C2D4", Offset = "0x91C2D4", VA = "0x91C2D4")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000800")]
		[Address(RVA = "0x91C318", Offset = "0x91C318", VA = "0x91C318")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000801")]
		[Address(RVA = "0x91C35C", Offset = "0x91C35C", VA = "0x91C35C")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000802")]
		[Address(RVA = "0x91C3A0", Offset = "0x91C3A0", VA = "0x91C3A0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000803")]
		[Address(RVA = "0x91C3E4", Offset = "0x91C3E4", VA = "0x91C3E4", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000804")]
		[Address(RVA = "0x91C41C", Offset = "0x91C41C", VA = "0x91C41C")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000805")]
		[Address(RVA = "0x91C740", Offset = "0x91C740", VA = "0x91C740")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x2000133")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Hinge")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page12.html")]
	public class RotationLimitHinge : RotationLimit
	{
		[Token(Token = "0x40008BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
		public bool useLimits;

		[Token(Token = "0x40008BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float min;

		[Token(Token = "0x40008BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float max;

		[Token(Token = "0x40008C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public float zeroAxisDisplayOffset;

		[Token(Token = "0x40008C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Quaternion lastRotation;

		[Token(Token = "0x40008C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float lastAngle;

		[Token(Token = "0x6000806")]
		[Address(RVA = "0x91C750", Offset = "0x91C750", VA = "0x91C750")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0x91C794", Offset = "0x91C794", VA = "0x91C794")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0x91C7D8", Offset = "0x91C7D8", VA = "0x91C7D8")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0x91C81C", Offset = "0x91C81C", VA = "0x91C81C")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600080A")]
		[Address(RVA = "0x91C860", Offset = "0x91C860", VA = "0x91C860", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0x91C87C", Offset = "0x91C87C", VA = "0x91C87C")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0x91CAC4", Offset = "0x91CAC4", VA = "0x91CAC4")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x2000134")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page12.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Polygonal")]
	public class RotationLimitPolygonal : RotationLimit
	{
		[Serializable]
		[Token(Token = "0x2000135")]
		public class ReachCone
		{
			[Token(Token = "0x40008C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3[] tetrahedron;

			[Token(Token = "0x40008C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float volume;

			[Token(Token = "0x40008CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 S;

			[Token(Token = "0x40008CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 B;

			[Token(Token = "0x170000E3")]
			public Vector3 o
			{
				[Token(Token = "0x600081D")]
				[Address(RVA = "0x91E9BC", Offset = "0x91E9BC", VA = "0x91E9BC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000E4")]
			public Vector3 a
			{
				[Token(Token = "0x600081E")]
				[Address(RVA = "0x91E9E8", Offset = "0x91E9E8", VA = "0x91E9E8")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000E5")]
			public Vector3 b
			{
				[Token(Token = "0x600081F")]
				[Address(RVA = "0x91EA18", Offset = "0x91EA18", VA = "0x91EA18")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000E6")]
			public Vector3 c
			{
				[Token(Token = "0x6000820")]
				[Address(RVA = "0x91EA48", Offset = "0x91EA48", VA = "0x91EA48")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000E7")]
			public bool isValid
			{
				[Token(Token = "0x6000822")]
				[Address(RVA = "0x91DEE4", Offset = "0x91DEE4", VA = "0x91DEE4")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000821")]
			[Address(RVA = "0x91E388", Offset = "0x91E388", VA = "0x91E388")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x6000823")]
			[Address(RVA = "0x91E500", Offset = "0x91E500", VA = "0x91E500")]
			public void Calculate()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000136")]
		public class LimitPoint
		{
			[Token(Token = "0x40008CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 point;

			[Token(Token = "0x40008CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float tangentWeight;

			[Token(Token = "0x6000824")]
			[Address(RVA = "0x91DEF4", Offset = "0x91DEF4", VA = "0x91DEF4")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x40008C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 180f)]
		public float twistLimit;

		[Token(Token = "0x40008C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 3f)]
		public int smoothIterations;

		[Token(Token = "0x40008C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		public LimitPoint[] points;

		[Token(Token = "0x40008C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[HideInInspector]
		[SerializeField]
		public Vector3[] P;

		[Token(Token = "0x40008C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		public ReachCone[] reachCones;

		[Token(Token = "0x600080D")]
		[Address(RVA = "0x91CB28", Offset = "0x91CB28", VA = "0x91CB28")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600080E")]
		[Address(RVA = "0x91CB6C", Offset = "0x91CB6C", VA = "0x91CB6C")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600080F")]
		[Address(RVA = "0x91CBB0", Offset = "0x91CBB0", VA = "0x91CBB0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000810")]
		[Address(RVA = "0x91CBF4", Offset = "0x91CBF4", VA = "0x91CBF4")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000811")]
		[Address(RVA = "0x91CC38", Offset = "0x91CC38", VA = "0x91CC38")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x6000812")]
		[Address(RVA = "0x91D31C", Offset = "0x91D31C", VA = "0x91D31C", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000813")]
		[Address(RVA = "0x91D3A4", Offset = "0x91D3A4", VA = "0x91D3A4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000814")]
		[Address(RVA = "0x91D9F0", Offset = "0x91D9F0", VA = "0x91D9F0")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x6000815")]
		[Address(RVA = "0x91CCD0", Offset = "0x91CCD0", VA = "0x91CCD0")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x6000816")]
		[Address(RVA = "0x91DF58", Offset = "0x91DF58", VA = "0x91DF58")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x6000817")]
		[Address(RVA = "0x91E774", Offset = "0x91E774", VA = "0x91E774")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x6000818")]
		[Address(RVA = "0x91E7BC", Offset = "0x91E7BC", VA = "0x91E7BC")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000819")]
		[Address(RVA = "0x91E81C", Offset = "0x91E81C", VA = "0x91E81C")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600081A")]
		[Address(RVA = "0x91D74C", Offset = "0x91D74C", VA = "0x91D74C")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600081B")]
		[Address(RVA = "0x91E888", Offset = "0x91E888", VA = "0x91E888")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0x91E954", Offset = "0x91E954", VA = "0x91E954")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x2000137")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page12.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Spline")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x40008CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 180f)]
		public float twistLimit;

		[Token(Token = "0x40008CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		public AnimationCurve spline;

		[Token(Token = "0x6000825")]
		[Address(RVA = "0x91EA78", Offset = "0x91EA78", VA = "0x91EA78")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0x91EABC", Offset = "0x91EABC", VA = "0x91EABC")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000827")]
		[Address(RVA = "0x91EB00", Offset = "0x91EB00", VA = "0x91EB00")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000828")]
		[Address(RVA = "0x91EB44", Offset = "0x91EB44", VA = "0x91EB44")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000829")]
		[Address(RVA = "0x91EB88", Offset = "0x91EB88", VA = "0x91EB88")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x600082A")]
		[Address(RVA = "0x91EBA4", Offset = "0x91EBA4", VA = "0x91EBA4", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0x91EBDC", Offset = "0x91EBDC", VA = "0x91EBDC")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600082C")]
		[Address(RVA = "0x91EF88", Offset = "0x91EF88", VA = "0x91EF88")]
		public RotationLimitSpline()
		{
		}
	}
	[Token(Token = "0x2000138")]
	public class AimPoser : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000139")]
		public class Pose
		{
			[Token(Token = "0x40008D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool visualize;

			[Token(Token = "0x40008D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string name;

			[Token(Token = "0x40008D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 direction;

			[Token(Token = "0x40008D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float yaw;

			[Token(Token = "0x40008D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float pitch;

			[Token(Token = "0x40008D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float angleBuffer;

			[Token(Token = "0x6000830")]
			[Address(RVA = "0x91F064", Offset = "0x91F064", VA = "0x91F064")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x6000831")]
			[Address(RVA = "0x91F5E0", Offset = "0x91F5E0", VA = "0x91F5E0")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x6000832")]
			[Address(RVA = "0x91F5E8", Offset = "0x91F5E8", VA = "0x91F5E8")]
			public Pose()
			{
			}
		}

		[Token(Token = "0x40008D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float angleBuffer;

		[Token(Token = "0x40008D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Pose[] poses;

		[Token(Token = "0x600082D")]
		[Address(RVA = "0x91EF94", Offset = "0x91EF94", VA = "0x91EF94")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0x91F514", Offset = "0x91F514", VA = "0x91F514")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0x91F574", Offset = "0x91F574", VA = "0x91F574")]
		public AimPoser()
		{
		}
	}
	[Token(Token = "0x200013A")]
	public class Amplifier : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x200013B")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x200013C")]
			public class EffectorLink
			{
				[Token(Token = "0x40008E2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40008E3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("Weight of using this effector")]
				public float weight;

				[Token(Token = "0x6000838")]
				[Address(RVA = "0x91FAAC", Offset = "0x91FAAC", VA = "0x91FAAC")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40008D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The Transform that's motion we are reading.")]
			public Transform transform;

			[Token(Token = "0x40008DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Amplify the 'transform's' position relative to this Transform.")]
			public Transform relativeTo;

			[Token(Token = "0x40008DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Linking the body to effectors. One Body can be used to offset more than one effector.")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x40008DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Amplification magnitude along the up axis of the character.")]
			public float verticalWeight;

			[Token(Token = "0x40008DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("Amplification magnitude along the horizontal axes of the character.")]
			public float horizontalWeight;

			[Token(Token = "0x40008DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("Speed of the amplifier. 0 means instant.")]
			public float speed;

			[Token(Token = "0x40008DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 lastRelativePos;

			[Token(Token = "0x40008E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Vector3 smoothDelta;

			[Token(Token = "0x40008E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private bool firstUpdate;

			[Token(Token = "0x6000835")]
			[Address(RVA = "0x91F754", Offset = "0x91F754", VA = "0x91F754")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x6000836")]
			[Address(RVA = "0x91FA84", Offset = "0x91FA84", VA = "0x91FA84")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000837")]
			[Address(RVA = "0x91FA94", Offset = "0x91FA94", VA = "0x91FA94")]
			public Body()
			{
			}
		}

		[Token(Token = "0x40008D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The amplified bodies.")]
		public Body[] bodies;

		[Token(Token = "0x6000833")]
		[Address(RVA = "0x91F604", Offset = "0x91F604", VA = "0x91F604", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000834")]
		[Address(RVA = "0x91FA64", Offset = "0x91FA64", VA = "0x91FA64")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x200013D")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x40008E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Speed of tilting")]
		public float tiltSpeed;

		[Token(Token = "0x40008E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Sensitivity of tilting")]
		public float tiltSensitivity;

		[Token(Token = "0x40008E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The OffsetPose components")]
		public OffsetPose poseLeft;

		[Token(Token = "0x40008E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The OffsetPose components")]
		public OffsetPose poseRight;

		[Token(Token = "0x40008E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float tiltAngle;

		[Token(Token = "0x40008E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 lastForward;

		[Token(Token = "0x6000839")]
		[Address(RVA = "0x91FAB4", Offset = "0x91FAB4", VA = "0x91FAB4", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0x91FB1C", Offset = "0x91FB1C", VA = "0x91FB1C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600083B")]
		[Address(RVA = "0x91FDBC", Offset = "0x91FDBC", VA = "0x91FDBC")]
		public BodyTilt()
		{
		}
	}
	[Token(Token = "0x200013E")]
	public class HitReaction : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x200013F")]
		public abstract class HitPoint
		{
			[Token(Token = "0x40008EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Just for visual clarity, not used at all")]
			public string name;

			[Token(Token = "0x40008ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Linking this hit point to a collider")]
			public Collider collider;

			[Token(Token = "0x40008EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Only used if this hit point gets hit when already processing another hit")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x40008F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x40008F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x40008F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x170000E9")]
			public bool inProgress
			{
				[Token(Token = "0x6000840")]
				[Address(RVA = "0x91FE74", Offset = "0x91FE74", VA = "0x91FE74")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000EA")]
			protected float crossFader
			{
				[Token(Token = "0x6000841")]
				[Address(RVA = "0x920374", Offset = "0x920374", VA = "0x920374")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000842")]
				[Address(RVA = "0x92037C", Offset = "0x92037C", VA = "0x92037C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000EB")]
			protected float timer
			{
				[Token(Token = "0x6000843")]
				[Address(RVA = "0x920384", Offset = "0x920384", VA = "0x920384")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000844")]
				[Address(RVA = "0x92038C", Offset = "0x92038C", VA = "0x92038C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000EC")]
			protected Vector3 force
			{
				[Token(Token = "0x6000845")]
				[Address(RVA = "0x920394", Offset = "0x920394", VA = "0x920394")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000846")]
				[Address(RVA = "0x9203A0", Offset = "0x9203A0", VA = "0x9203A0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000ED")]
			protected Vector3 point
			{
				[Token(Token = "0x6000847")]
				[Address(RVA = "0x9203AC", Offset = "0x9203AC", VA = "0x9203AC")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000848")]
				[Address(RVA = "0x9203B8", Offset = "0x9203B8", VA = "0x9203B8")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000849")]
			[Address(RVA = "0x92023C", Offset = "0x92023C", VA = "0x92023C")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x600084A")]
			[Address(RVA = "0x91FF48", Offset = "0x91FF48", VA = "0x91FF48")]
			public void Apply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x600084B")]
			protected abstract float GetLength();

			[Token(Token = "0x600084C")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x600084D")]
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);

			[Token(Token = "0x600084E")]
			[Address(RVA = "0x9203C4", Offset = "0x9203C4", VA = "0x9203C4")]
			protected HitPoint()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000140")]
		public class HitPointEffector : HitPoint
		{
			[Serializable]
			[Token(Token = "0x2000141")]
			public class EffectorLink
			{
				[Token(Token = "0x40008F9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("The FBBIK effector type")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40008FA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("The weight of this effector (could also be negative)")]
				public float weight;

				[Token(Token = "0x40008FB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x40008FC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000853")]
				[Address(RVA = "0x9206F8", Offset = "0x9206F8", VA = "0x9206F8")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000854")]
				[Address(RVA = "0x920554", Offset = "0x920554", VA = "0x920554")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000855")]
				[Address(RVA = "0x9207A8", Offset = "0x9207A8", VA = "0x9207A8")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40008F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("Offset magnitude in the direction of the hit force")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x40008F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Offset magnitude in the direction of character.up")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x40008F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Tooltip("Linking this offset to the FBBIK effectors")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x600084F")]
			[Address(RVA = "0x9203D8", Offset = "0x9203D8", VA = "0x9203D8", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x6000850")]
			[Address(RVA = "0x9204F4", Offset = "0x9204F4", VA = "0x9204F4", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000851")]
			[Address(RVA = "0x920568", Offset = "0x920568", VA = "0x920568", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000852")]
			[Address(RVA = "0x920794", Offset = "0x920794", VA = "0x920794")]
			public HitPointEffector()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000142")]
		public class HitPointBone : HitPoint
		{
			[Serializable]
			[Token(Token = "0x2000143")]
			public class BoneLink
			{
				[Token(Token = "0x4000900")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Reference to the bone that this hit point rotates")]
				public Transform bone;

				[Token(Token = "0x4000901")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[Tooltip("Weight of rotating the bone")]
				[Range(0f, 1f)]
				public float weight;

				[Token(Token = "0x4000902")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				[Token(Token = "0x4000903")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private Quaternion current;

				[Token(Token = "0x600085A")]
				[Address(RVA = "0x920A78", Offset = "0x920A78", VA = "0x920A78")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x600085B")]
				[Address(RVA = "0x920894", Offset = "0x920894", VA = "0x920894")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x600085C")]
				[Address(RVA = "0x920C18", Offset = "0x920C18", VA = "0x920C18")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x40008FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("The angle to rotate the bone around it's rigidbody's world center of mass")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x40008FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Linking this hit point to bone(s)")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x40008FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000856")]
			[Address(RVA = "0x9207B0", Offset = "0x9207B0", VA = "0x9207B0", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x6000857")]
			[Address(RVA = "0x92083C", Offset = "0x92083C", VA = "0x92083C", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000858")]
			[Address(RVA = "0x9208A0", Offset = "0x9208A0", VA = "0x9208A0", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000859")]
			[Address(RVA = "0x920C04", Offset = "0x920C04", VA = "0x920C04")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x40008EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Hit points for the FBBIK effectors")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x40008EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip(" Hit points for bones without an effector, such as the head")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x170000E8")]
		public bool inProgress
		{
			[Token(Token = "0x600083C")]
			[Address(RVA = "0x91FDD8", Offset = "0x91FDD8", VA = "0x91FDD8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0x91FE88", Offset = "0x91FE88", VA = "0x91FE88", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600083E")]
		[Address(RVA = "0x920020", Offset = "0x920020", VA = "0x920020")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x600083F")]
		[Address(RVA = "0x920364", Offset = "0x920364", VA = "0x920364")]
		public HitReaction()
		{
		}
	}
	[Token(Token = "0x2000144")]
	public class HitReactionVRIK : OffsetModifierVRIK
	{
		[Serializable]
		[Token(Token = "0x2000145")]
		public abstract class Offset
		{
			[Token(Token = "0x4000907")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Just for visual clarity, not used at all")]
			public string name;

			[Token(Token = "0x4000908")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Linking this hit point to a collider")]
			public Collider collider;

			[Token(Token = "0x4000909")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			[Tooltip("Only used if this hit point gets hit when already processing another hit")]
			private float crossFadeTime;

			[Token(Token = "0x400090E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x400090F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x4000910")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x170000EE")]
			protected float crossFader
			{
				[Token(Token = "0x6000860")]
				[Address(RVA = "0x921188", Offset = "0x921188", VA = "0x921188")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000861")]
				[Address(RVA = "0x921190", Offset = "0x921190", VA = "0x921190")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000EF")]
			protected float timer
			{
				[Token(Token = "0x6000862")]
				[Address(RVA = "0x921198", Offset = "0x921198", VA = "0x921198")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000863")]
				[Address(RVA = "0x9211A0", Offset = "0x9211A0", VA = "0x9211A0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000F0")]
			protected Vector3 force
			{
				[Token(Token = "0x6000864")]
				[Address(RVA = "0x9211A8", Offset = "0x9211A8", VA = "0x9211A8")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000865")]
				[Address(RVA = "0x9211B4", Offset = "0x9211B4", VA = "0x9211B4")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000F1")]
			protected Vector3 point
			{
				[Token(Token = "0x6000866")]
				[Address(RVA = "0x9211C0", Offset = "0x9211C0", VA = "0x9211C0")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000867")]
				[Address(RVA = "0x9211CC", Offset = "0x9211CC", VA = "0x9211CC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000868")]
			[Address(RVA = "0x921038", Offset = "0x921038", VA = "0x921038")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x6000869")]
			[Address(RVA = "0x920D34", Offset = "0x920D34", VA = "0x920D34")]
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x600086A")]
			protected abstract float GetLength(AnimationCurve[] curves);

			[Token(Token = "0x600086B")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x600086C")]
			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);

			[Token(Token = "0x600086D")]
			[Address(RVA = "0x9211D8", Offset = "0x9211D8", VA = "0x9211D8")]
			protected Offset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000146")]
		public class PositionOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x2000147")]
			public class PositionOffsetLink
			{
				[Token(Token = "0x4000914")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("The FBBIK effector type")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x4000915")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("The weight of this effector (could also be negative)")]
				public float weight;

				[Token(Token = "0x4000916")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000917")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000872")]
				[Address(RVA = "0x9215BC", Offset = "0x9215BC", VA = "0x9215BC")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000873")]
				[Address(RVA = "0x9213E0", Offset = "0x9213E0", VA = "0x9213E0")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000874")]
				[Address(RVA = "0x921650", Offset = "0x921650", VA = "0x921650")]
				public PositionOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000911")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("Offset magnitude in the direction of the hit force")]
			public int forceDirCurveIndex;

			[Token(Token = "0x4000912")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[Tooltip("Offset magnitude in the direction of character.up")]
			public int upDirCurveIndex;

			[Token(Token = "0x4000913")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Linking this offset to the VRIK position offsets")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x600086E")]
			[Address(RVA = "0x9211EC", Offset = "0x9211EC", VA = "0x9211EC", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x600086F")]
			[Address(RVA = "0x921380", Offset = "0x921380", VA = "0x921380", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000870")]
			[Address(RVA = "0x9213F4", Offset = "0x9213F4", VA = "0x9213F4", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000871")]
			[Address(RVA = "0x921634", Offset = "0x921634", VA = "0x921634")]
			public PositionOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000148")]
		public class RotationOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x2000149")]
			public class RotationOffsetLink
			{
				[Token(Token = "0x400091B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Reference to the bone that this hit point rotates")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x400091C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("Weight of rotating the bone")]
				[Range(0f, 1f)]
				public float weight;

				[Token(Token = "0x400091D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				[Token(Token = "0x400091E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private Quaternion current;

				[Token(Token = "0x6000879")]
				[Address(RVA = "0x921A24", Offset = "0x921A24", VA = "0x921A24")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x600087A")]
				[Address(RVA = "0x921788", Offset = "0x921788", VA = "0x921788")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x600087B")]
				[Address(RVA = "0x921B40", Offset = "0x921B40", VA = "0x921B40")]
				public RotationOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000918")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("The angle to rotate the bone around it's rigidbody's world center of mass")]
			public int curveIndex;

			[Token(Token = "0x4000919")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Linking this hit point to bone(s)")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x400091A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000875")]
			[Address(RVA = "0x921658", Offset = "0x921658", VA = "0x921658", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000876")]
			[Address(RVA = "0x921730", Offset = "0x921730", VA = "0x921730", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000877")]
			[Address(RVA = "0x921794", Offset = "0x921794", VA = "0x921794", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000878")]
			[Address(RVA = "0x921B2C", Offset = "0x921B2C", VA = "0x921B2C")]
			public RotationOffset()
			{
			}
		}

		[Token(Token = "0x4000904")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x4000905")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Hit points for the FBBIK effectors")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x4000906")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip(" Hit points for bones without an effector, such as the head")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x600085D")]
		[Address(RVA = "0x920C7C", Offset = "0x920C7C", VA = "0x920C7C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600085E")]
		[Address(RVA = "0x920E14", Offset = "0x920E14", VA = "0x920E14")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x600085F")]
		[Address(RVA = "0x921168", Offset = "0x921168", VA = "0x921168")]
		public HitReactionVRIK()
		{
		}
	}
	[Token(Token = "0x200014A")]
	public class Inertia : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x200014B")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x200014C")]
			public class EffectorLink
			{
				[Token(Token = "0x400092C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400092D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("Weight of using this effector")]
				public float weight;

				[Token(Token = "0x6000882")]
				[Address(RVA = "0x922108", Offset = "0x922108", VA = "0x922108")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000921")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The Transform to follow, can be any bone of the character")]
			public Transform transform;

			[Token(Token = "0x4000922")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Linking the body to effectors. One Body can be used to offset more than one effector")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000923")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The speed to follow the Transform")]
			public float speed;

			[Token(Token = "0x4000924")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("The acceleration, smaller values means lazyer following")]
			public float acceleration;

			[Token(Token = "0x4000925")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Range(0f, 1f)]
			[Tooltip("Matching target velocity")]
			public float matchVelocity;

			[Token(Token = "0x4000926")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("gravity applied to the Body")]
			public float gravity;

			[Token(Token = "0x4000927")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 delta;

			[Token(Token = "0x4000928")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lazyPoint;

			[Token(Token = "0x4000929")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 direction;

			[Token(Token = "0x400092A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 lastPosition;

			[Token(Token = "0x400092B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private bool firstUpdate;

			[Token(Token = "0x600087F")]
			[Address(RVA = "0x921C10", Offset = "0x921C10", VA = "0x921C10")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000880")]
			[Address(RVA = "0x921D90", Offset = "0x921D90", VA = "0x921D90")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x6000881")]
			[Address(RVA = "0x9220EC", Offset = "0x9220EC", VA = "0x9220EC")]
			public Body()
			{
			}
		}

		[Token(Token = "0x400091F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The array of Bodies")]
		public Body[] bodies;

		[Token(Token = "0x4000920")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The array of OffsetLimits")]
		public OffsetLimits[] limits;

		[Token(Token = "0x600087C")]
		[Address(RVA = "0x921BA4", Offset = "0x921BA4", VA = "0x921BA4")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x600087D")]
		[Address(RVA = "0x921CEC", Offset = "0x921CEC", VA = "0x921CEC", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600087E")]
		[Address(RVA = "0x9220DC", Offset = "0x9220DC", VA = "0x9220DC")]
		public Inertia()
		{
		}
	}
	[Token(Token = "0x200014D")]
	public abstract class OffsetModifier : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200014E")]
		public class OffsetLimits
		{
			[Token(Token = "0x4000931")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The effector type (this is just an enum)")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000932")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("Spring force, if zero then this is a hard limit, if not, offset can exceed the limit.")]
			public float spring;

			[Token(Token = "0x4000933")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Which axes to limit the offset on?")]
			public bool x;

			[Token(Token = "0x4000934")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			[Tooltip("Which axes to limit the offset on?")]
			public bool y;

			[Token(Token = "0x4000935")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			[Tooltip("Which axes to limit the offset on?")]
			public bool z;

			[Token(Token = "0x4000936")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Tooltip("The limits")]
			public float minX;

			[Token(Token = "0x4000937")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The limits")]
			public float maxX;

			[Token(Token = "0x4000938")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("The limits")]
			public float minY;

			[Token(Token = "0x4000939")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The limits")]
			public float maxY;

			[Token(Token = "0x400093A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("The limits")]
			public float minZ;

			[Token(Token = "0x400093B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("The limits")]
			public float maxZ;

			[Token(Token = "0x600088B")]
			[Address(RVA = "0x922280", Offset = "0x922280", VA = "0x922280")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x600088C")]
			[Address(RVA = "0x922510", Offset = "0x922510", VA = "0x922510")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x600088D")]
			[Address(RVA = "0x922580", Offset = "0x922580", VA = "0x922580")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x600088E")]
			[Address(RVA = "0x9225C8", Offset = "0x9225C8", VA = "0x9225C8")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x200014F")]
		[CompilerGenerated]
		private sealed class <Initiate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400093C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400093D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400093E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifier <>4__this;

			[Token(Token = "0x170000F3")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000892")]
				[Address(RVA = "0x922744", Offset = "0x922744", VA = "0x922744", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F4")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000894")]
				[Address(RVA = "0x92278C", Offset = "0x92278C", VA = "0x92278C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600088F")]
			[Address(RVA = "0x922184", Offset = "0x922184", VA = "0x922184")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000890")]
			[Address(RVA = "0x9225D0", Offset = "0x9225D0", VA = "0x9225D0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000891")]
			[Address(RVA = "0x9225D4", Offset = "0x9225D4", VA = "0x9225D4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000893")]
			[Address(RVA = "0x92274C", Offset = "0x92274C", VA = "0x92274C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400092E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The master weight")]
		public float weight;

		[Token(Token = "0x400092F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Reference to the FBBIK component")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000930")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float lastTime;

		[Token(Token = "0x170000F2")]
		protected float deltaTime
		{
			[Token(Token = "0x6000883")]
			[Address(RVA = "0x91F734", Offset = "0x91F734", VA = "0x91F734")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000884")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000885")]
		[Address(RVA = "0x91FAFC", Offset = "0x91FAFC", VA = "0x91FAFC", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000886")]
		[Address(RVA = "0x922110", Offset = "0x922110", VA = "0x922110")]
		[IteratorStateMachine(typeof(<Initiate>d__8))]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x6000887")]
		[Address(RVA = "0x9221AC", Offset = "0x9221AC", VA = "0x9221AC")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x6000888")]
		[Address(RVA = "0x922034", Offset = "0x922034", VA = "0x922034")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x6000889")]
		[Address(RVA = "0x9223E4", Offset = "0x9223E4", VA = "0x9223E4", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600088A")]
		[Address(RVA = "0x91FA74", Offset = "0x91FA74", VA = "0x91FA74")]
		protected OffsetModifier()
		{
		}
	}
	[Token(Token = "0x2000150")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x2000151")]
		[CompilerGenerated]
		private sealed class <Initiate>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000942")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000943")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000944")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifierVRIK <>4__this;

			[Token(Token = "0x170000F6")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600089F")]
				[Address(RVA = "0x922BE4", Offset = "0x922BE4", VA = "0x922BE4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F7")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008A1")]
				[Address(RVA = "0x922C2C", Offset = "0x922C2C", VA = "0x922C2C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600089C")]
			[Address(RVA = "0x922848", Offset = "0x922848", VA = "0x922848")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x600089D")]
			[Address(RVA = "0x922A70", Offset = "0x922A70", VA = "0x922A70", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600089E")]
			[Address(RVA = "0x922A74", Offset = "0x922A74", VA = "0x922A74", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008A0")]
			[Address(RVA = "0x922BEC", Offset = "0x922BEC", VA = "0x922BEC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400093F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The master weight")]
		public float weight;

		[Token(Token = "0x4000940")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Reference to the VRIK component")]
		public VRIK ik;

		[Token(Token = "0x4000941")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float lastTime;

		[Token(Token = "0x170000F5")]
		protected float deltaTime
		{
			[Token(Token = "0x6000895")]
			[Address(RVA = "0x922794", Offset = "0x922794", VA = "0x922794")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000896")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000897")]
		[Address(RVA = "0x9227B4", Offset = "0x9227B4", VA = "0x9227B4", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000898")]
		[Address(RVA = "0x9227D4", Offset = "0x9227D4", VA = "0x9227D4")]
		[IteratorStateMachine(typeof(<Initiate>d__7))]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x6000899")]
		[Address(RVA = "0x922870", Offset = "0x922870", VA = "0x922870")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x600089A")]
		[Address(RVA = "0x922944", Offset = "0x922944", VA = "0x922944", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600089B")]
		[Address(RVA = "0x921178", Offset = "0x921178", VA = "0x921178")]
		protected OffsetModifierVRIK()
		{
		}
	}
	[Token(Token = "0x2000152")]
	public class OffsetPose : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000153")]
		public class EffectorLink
		{
			[Token(Token = "0x4000946")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000947")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 offset;

			[Token(Token = "0x4000948")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 pin;

			[Token(Token = "0x4000949")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 pinWeight;

			[Token(Token = "0x60008A5")]
			[Address(RVA = "0x922C34", Offset = "0x922C34", VA = "0x922C34")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x60008A6")]
			[Address(RVA = "0x922F8C", Offset = "0x922F8C", VA = "0x922F8C")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000945")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x60008A2")]
		[Address(RVA = "0x91FD08", Offset = "0x91FD08", VA = "0x91FD08")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x60008A3")]
		[Address(RVA = "0x922E84", Offset = "0x922E84", VA = "0x922E84")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x60008A4")]
		[Address(RVA = "0x922F28", Offset = "0x922F28", VA = "0x922F28")]
		public OffsetPose()
		{
		}
	}
	[Token(Token = "0x2000154")]
	public class Recoil : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000155")]
		public class RecoilOffset
		{
			[Serializable]
			[Token(Token = "0x2000156")]
			public class EffectorLink
			{
				[Token(Token = "0x4000967")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000968")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("Weight of using this effector")]
				public float weight;

				[Token(Token = "0x60008B6")]
				[Address(RVA = "0x924300", Offset = "0x924300", VA = "0x924300")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000961")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Offset vector for the associated effector when doing recoil.")]
			public Vector3 offset;

			[Token(Token = "0x4000962")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Tooltip("When firing before the last recoil has faded, how much of the current recoil offset will be maintained?")]
			[Range(0f, 1f)]
			public float additivity;

			[Token(Token = "0x4000963")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Max additive recoil for automatic fire.")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x4000964")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Linking this recoil offset to FBBIK effectors.")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000965")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 additiveOffset;

			[Token(Token = "0x4000966")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lastOffset;

			[Token(Token = "0x60008B3")]
			[Address(RVA = "0x923130", Offset = "0x923130", VA = "0x923130")]
			public void Start()
			{
			}

			[Token(Token = "0x60008B4")]
			[Address(RVA = "0x923C78", Offset = "0x923C78", VA = "0x923C78")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x60008B5")]
			[Address(RVA = "0x9242EC", Offset = "0x9242EC", VA = "0x9242EC")]
			public RecoilOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000157")]
		public enum Handedness
		{
			[Token(Token = "0x400096A")]
			Right,
			[Token(Token = "0x400096B")]
			Left
		}

		[Token(Token = "0x400094A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Reference to the AimIK component. Optional, only used to getting the aiming direction.")]
		public AimIK aimIK;

		[Token(Token = "0x400094B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Set this true if you are using IKExecutionOrder.cs or a custom script to force AimIK solve after FBBIK.")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x400094C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("Which hand is holding the weapon?")]
		public Handedness handedness;

		[Token(Token = "0x400094D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Check for 2-handed weapons.")]
		public bool twoHanded;

		[Token(Token = "0x400094E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Weight curve for the recoil offsets. Recoil procedure is as long as this curve.")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x400094F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("How much is the magnitude randomized each time Recoil is called?")]
		public float magnitudeRandom;

		[Token(Token = "0x4000950")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Tooltip("How much is the rotation randomized each time Recoil is called?")]
		public Vector3 rotationRandom;

		[Token(Token = "0x4000951")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("Rotating the primary hand bone for the recoil (in local space).")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x4000952")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Tooltip("Time of blending in another recoil when doing automatic fire.")]
		public float blendTime;

		[Token(Token = "0x4000953")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Tooltip("FBBIK effector position offsets for the recoil (in aiming direction space).")]
		[Space(10f)]
		public RecoilOffset[] offsets;

		[Token(Token = "0x4000954")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[HideInInspector]
		public Quaternion rotationOffset;

		[Token(Token = "0x4000955")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float magnitudeMlp;

		[Token(Token = "0x4000956")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float endTime;

		[Token(Token = "0x4000957")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion handRotation;

		[Token(Token = "0x4000958")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Quaternion secondaryHandRelativeRotation;

		[Token(Token = "0x4000959")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion randomRotation;

		[Token(Token = "0x400095A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float length;

		[Token(Token = "0x400095B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private bool initiated;

		[Token(Token = "0x400095C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float blendWeight;

		[Token(Token = "0x400095D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float w;

		[Token(Token = "0x400095E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Quaternion primaryHandRotation;

		[Token(Token = "0x400095F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool handRotationsSet;

		[Token(Token = "0x4000960")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Vector3 aimIKAxis;

		[Token(Token = "0x170000F8")]
		public bool isFinished
		{
			[Token(Token = "0x60008A7")]
			[Address(RVA = "0x922F94", Offset = "0x922F94", VA = "0x922F94")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000F9")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x60008AD")]
			[Address(RVA = "0x923E7C", Offset = "0x923E7C", VA = "0x923E7C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FA")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x60008AE")]
			[Address(RVA = "0x923EB8", Offset = "0x923EB8", VA = "0x923EB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FB")]
		private Transform primaryHand
		{
			[Token(Token = "0x60008AF")]
			[Address(RVA = "0x923E44", Offset = "0x923E44", VA = "0x923E44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FC")]
		private Transform secondaryHand
		{
			[Token(Token = "0x60008B0")]
			[Address(RVA = "0x923E60", Offset = "0x923E60", VA = "0x923E60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008A8")]
		[Address(RVA = "0x922FB8", Offset = "0x922FB8", VA = "0x922FB8")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x60008A9")]
		[Address(RVA = "0x922FE4", Offset = "0x922FE4", VA = "0x922FE4")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x60008AA")]
		[Address(RVA = "0x923204", Offset = "0x923204", VA = "0x923204", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60008AB")]
		[Address(RVA = "0x923EF4", Offset = "0x923EF4", VA = "0x923EF4")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x60008AC")]
		[Address(RVA = "0x92400C", Offset = "0x92400C", VA = "0x92400C")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x60008B1")]
		[Address(RVA = "0x92405C", Offset = "0x92405C", VA = "0x92405C", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60008B2")]
		[Address(RVA = "0x924260", Offset = "0x924260", VA = "0x924260")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x2000158")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x400096C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Weight of shoulder rotation")]
		public float weight;

		[Token(Token = "0x400096D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("The greater the offset, the sooner the shoulder will start rotating")]
		public float offset;

		[Token(Token = "0x400096E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x400096F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool skip;

		[Token(Token = "0x60008B7")]
		[Address(RVA = "0x924308", Offset = "0x924308", VA = "0x924308")]
		private void Start()
		{
		}

		[Token(Token = "0x60008B8")]
		[Address(RVA = "0x92441C", Offset = "0x92441C", VA = "0x92441C")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x60008B9")]
		[Address(RVA = "0x9244F8", Offset = "0x9244F8", VA = "0x9244F8")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x60008BA")]
		[Address(RVA = "0x9248FC", Offset = "0x9248FC", VA = "0x9248FC")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x60008BB")]
		[Address(RVA = "0x924930", Offset = "0x924930", VA = "0x924930")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60008BC")]
		[Address(RVA = "0x924A5C", Offset = "0x924A5C", VA = "0x924A5C")]
		public ShoulderRotator()
		{
		}
	}
}
namespace MiniJSON
{
	[Token(Token = "0x2000159")]
	public static class Json
	{
		[Token(Token = "0x200015A")]
		private sealed class Parser : IDisposable
		{
			[Token(Token = "0x200015B")]
			private enum TOKEN
			{
				[Token(Token = "0x4000973")]
				NONE,
				[Token(Token = "0x4000974")]
				CURLY_OPEN,
				[Token(Token = "0x4000975")]
				CURLY_CLOSE,
				[Token(Token = "0x4000976")]
				SQUARED_OPEN,
				[Token(Token = "0x4000977")]
				SQUARED_CLOSE,
				[Token(Token = "0x4000978")]
				COLON,
				[Token(Token = "0x4000979")]
				COMMA,
				[Token(Token = "0x400097A")]
				STRING,
				[Token(Token = "0x400097B")]
				NUMBER,
				[Token(Token = "0x400097C")]
				TRUE,
				[Token(Token = "0x400097D")]
				FALSE,
				[Token(Token = "0x400097E")]
				NULL
			}

			[Token(Token = "0x4000970")]
			private const string WORD_BREAK = "{}[],:\"";

			[Token(Token = "0x4000971")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private StringReader json;

			[Token(Token = "0x170000FD")]
			private char PeekChar
			{
				[Token(Token = "0x60008CA")]
				[Address(RVA = "0x9257EC", Offset = "0x9257EC", VA = "0x9257EC")]
				get
				{
					return default(char);
				}
			}

			[Token(Token = "0x170000FE")]
			private char NextChar
			{
				[Token(Token = "0x60008CB")]
				[Address(RVA = "0x925624", Offset = "0x925624", VA = "0x925624")]
				get
				{
					return default(char);
				}
			}

			[Token(Token = "0x170000FF")]
			private string NextWord
			{
				[Token(Token = "0x60008CC")]
				[Address(RVA = "0x92569C", Offset = "0x92569C", VA = "0x92569C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000100")]
			private TOKEN NextToken
			{
				[Token(Token = "0x60008CD")]
				[Address(RVA = "0x924F20", Offset = "0x924F20", VA = "0x924F20")]
				get
				{
					return default(TOKEN);
				}
			}

			[Token(Token = "0x60008BF")]
			[Address(RVA = "0x924C90", Offset = "0x924C90", VA = "0x924C90")]
			public static bool IsWordBreak(char c)
			{
				return default(bool);
			}

			[Token(Token = "0x60008C0")]
			[Address(RVA = "0x924D2C", Offset = "0x924D2C", VA = "0x924D2C")]
			private Parser(string jsonString)
			{
			}

			[Token(Token = "0x60008C1")]
			[Address(RVA = "0x924A7C", Offset = "0x924A7C", VA = "0x924A7C")]
			public static object Parse(string jsonString)
			{
				return null;
			}

			[Token(Token = "0x60008C2")]
			[Address(RVA = "0x924DCC", Offset = "0x924DCC", VA = "0x924DCC", Slot = "4")]
			public void Dispose()
			{
			}

			[Token(Token = "0x60008C3")]
			[Address(RVA = "0x924DFC", Offset = "0x924DFC", VA = "0x924DFC")]
			private Dictionary<string, object> ParseObject()
			{
				return null;
			}

			[Token(Token = "0x60008C4")]
			[Address(RVA = "0x925344", Offset = "0x925344", VA = "0x925344")]
			private List<object> ParseArray()
			{
				return null;
			}

			[Token(Token = "0x60008C5")]
			[Address(RVA = "0x924DB0", Offset = "0x924DB0", VA = "0x924DB0")]
			private object ParseValue()
			{
				return null;
			}

			[Token(Token = "0x60008C6")]
			[Address(RVA = "0x92546C", Offset = "0x92546C", VA = "0x92546C")]
			private object ParseByToken(TOKEN token)
			{
				return null;
			}

			[Token(Token = "0x60008C7")]
			[Address(RVA = "0x9250E4", Offset = "0x9250E4", VA = "0x9250E4")]
			private string ParseString()
			{
				return null;
			}

			[Token(Token = "0x60008C8")]
			[Address(RVA = "0x925554", Offset = "0x925554", VA = "0x925554")]
			private object ParseNumber()
			{
				return null;
			}

			[Token(Token = "0x60008C9")]
			[Address(RVA = "0x925748", Offset = "0x925748", VA = "0x925748")]
			private void EatWhitespace()
			{
			}
		}

		[Token(Token = "0x200015C")]
		private sealed class Serializer
		{
			[Token(Token = "0x400097F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private StringBuilder builder;

			[Token(Token = "0x60008CE")]
			[Address(RVA = "0x925864", Offset = "0x925864", VA = "0x925864")]
			private Serializer()
			{
			}

			[Token(Token = "0x60008CF")]
			[Address(RVA = "0x924C1C", Offset = "0x924C1C", VA = "0x924C1C")]
			public static string Serialize(object obj)
			{
				return null;
			}

			[Token(Token = "0x60008D0")]
			[Address(RVA = "0x9258D8", Offset = "0x9258D8", VA = "0x9258D8")]
			private void SerializeValue(object value)
			{
			}

			[Token(Token = "0x60008D1")]
			[Address(RVA = "0x9260C4", Offset = "0x9260C4", VA = "0x9260C4")]
			private void SerializeObject(IDictionary obj)
			{
			}

			[Token(Token = "0x60008D2")]
			[Address(RVA = "0x925D64", Offset = "0x925D64", VA = "0x925D64")]
			private void SerializeArray(IList anArray)
			{
			}

			[Token(Token = "0x60008D3")]
			[Address(RVA = "0x925AA8", Offset = "0x925AA8", VA = "0x925AA8")]
			private void SerializeString(string str)
			{
			}

			[Token(Token = "0x60008D4")]
			[Address(RVA = "0x926550", Offset = "0x926550", VA = "0x926550")]
			private void SerializeOther(object value)
			{
			}
		}

		[Token(Token = "0x60008BD")]
		[Address(RVA = "0x924A70", Offset = "0x924A70", VA = "0x924A70")]
		public static object Deserialize(string json)
		{
			return null;
		}

		[Token(Token = "0x60008BE")]
		[Address(RVA = "0x924C18", Offset = "0x924C18", VA = "0x924C18")]
		public static string Serialize(object obj)
		{
			return null;
		}
	}
}
