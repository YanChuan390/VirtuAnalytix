using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using CodeStage.AntiCheat.Common;
using CodeStage.AntiCheat.ObscuredTypes;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class HideInNormalInspectorAttribute : PropertyAttribute
{
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x2C1FBD8", Offset = "0x2C1FBD8", VA = "0x2C1FBD8")]
	public HideInNormalInspectorAttribute()
	{
	}
}
namespace UnityStandardAssets.Utility
{
	[Token(Token = "0x2000003")]
	public class SmoothFollow : MonoBehaviour
	{
		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform target;

		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float distance;

		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float height;

		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float rotationDamping;

		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float heightDamping;

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x2C21E84", Offset = "0x2C21E84", VA = "0x2C21E84")]
		private void Start()
		{
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x2C21E88", Offset = "0x2C21E88", VA = "0x2C21E88")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x2C221B4", Offset = "0x2C221B4", VA = "0x2C221B4")]
		public SmoothFollow()
		{
		}
	}
}
namespace MiniJSON
{
	[Token(Token = "0x2000004")]
	public static class Json
	{
		[Token(Token = "0x2000030")]
		private sealed class Parser : IDisposable
		{
			[Token(Token = "0x2000040")]
			private enum TOKEN
			{
				[Token(Token = "0x4000171")]
				NONE,
				[Token(Token = "0x4000172")]
				CURLY_OPEN,
				[Token(Token = "0x4000173")]
				CURLY_CLOSE,
				[Token(Token = "0x4000174")]
				SQUARED_OPEN,
				[Token(Token = "0x4000175")]
				SQUARED_CLOSE,
				[Token(Token = "0x4000176")]
				COLON,
				[Token(Token = "0x4000177")]
				COMMA,
				[Token(Token = "0x4000178")]
				STRING,
				[Token(Token = "0x4000179")]
				NUMBER,
				[Token(Token = "0x400017A")]
				TRUE,
				[Token(Token = "0x400017B")]
				FALSE,
				[Token(Token = "0x400017C")]
				NULL
			}

			[Token(Token = "0x4000134")]
			private const string WORD_BREAK = "{}[],:\"";

			[Token(Token = "0x4000135")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private StringReader json;

			[Token(Token = "0x1700001D")]
			private char PeekChar
			{
				[Token(Token = "0x60002F8")]
				[Address(RVA = "0x2C208F8", Offset = "0x2C208F8", VA = "0x2C208F8")]
				get
				{
					return default(char);
				}
			}

			[Token(Token = "0x1700001E")]
			private char NextChar
			{
				[Token(Token = "0x60002F9")]
				[Address(RVA = "0x2C20700", Offset = "0x2C20700", VA = "0x2C20700")]
				get
				{
					return default(char);
				}
			}

			[Token(Token = "0x1700001F")]
			private string NextWord
			{
				[Token(Token = "0x60002FA")]
				[Address(RVA = "0x2C20788", Offset = "0x2C20788", VA = "0x2C20788")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000020")]
			private TOKEN NextToken
			{
				[Token(Token = "0x60002FB")]
				[Address(RVA = "0x2C20044", Offset = "0x2C20044", VA = "0x2C20044")]
				get
				{
					return default(TOKEN);
				}
			}

			[Token(Token = "0x60002ED")]
			[Address(RVA = "0x2C1FDA8", Offset = "0x2C1FDA8", VA = "0x2C1FDA8")]
			public static bool IsWordBreak(char c)
			{
				return default(bool);
			}

			[Token(Token = "0x60002EE")]
			[Address(RVA = "0x2C1FE48", Offset = "0x2C1FE48", VA = "0x2C1FE48")]
			private Parser(string jsonString)
			{
			}

			[Token(Token = "0x60002EF")]
			[Address(RVA = "0x2C1FBEC", Offset = "0x2C1FBEC", VA = "0x2C1FBEC")]
			public static object Parse(string jsonString)
			{
				return null;
			}

			[Token(Token = "0x60002F0")]
			[Address(RVA = "0x2C1FEF4", Offset = "0x2C1FEF4", VA = "0x2C1FEF4", Slot = "4")]
			public void Dispose()
			{
			}

			[Token(Token = "0x60002F1")]
			[Address(RVA = "0x2C1FF30", Offset = "0x2C1FF30", VA = "0x2C1FF30")]
			private Dictionary<string, object> ParseObject()
			{
				return null;
			}

			[Token(Token = "0x60002F2")]
			[Address(RVA = "0x2C20474", Offset = "0x2C20474", VA = "0x2C20474")]
			private List<object> ParseArray()
			{
				return null;
			}

			[Token(Token = "0x60002F3")]
			[Address(RVA = "0x2C1FECC", Offset = "0x2C1FECC", VA = "0x2C1FECC")]
			private object ParseValue()
			{
				return null;
			}

			[Token(Token = "0x60002F4")]
			[Address(RVA = "0x2C20548", Offset = "0x2C20548", VA = "0x2C20548")]
			private object ParseByToken(TOKEN token)
			{
				return null;
			}

			[Token(Token = "0x60002F5")]
			[Address(RVA = "0x2C201F4", Offset = "0x2C201F4", VA = "0x2C201F4")]
			private string ParseString()
			{
				return null;
			}

			[Token(Token = "0x60002F6")]
			[Address(RVA = "0x2C20624", Offset = "0x2C20624", VA = "0x2C20624")]
			private object ParseNumber()
			{
				return null;
			}

			[Token(Token = "0x60002F7")]
			[Address(RVA = "0x2C20844", Offset = "0x2C20844", VA = "0x2C20844")]
			private void EatWhitespace()
			{
			}
		}

		[Token(Token = "0x2000031")]
		private sealed class Serializer
		{
			[Token(Token = "0x4000136")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private StringBuilder builder;

			[Token(Token = "0x60002FC")]
			[Address(RVA = "0x2C20980", Offset = "0x2C20980", VA = "0x2C20980")]
			private Serializer()
			{
			}

			[Token(Token = "0x60002FD")]
			[Address(RVA = "0x2C1FD2C", Offset = "0x2C1FD2C", VA = "0x2C1FD2C")]
			public static string Serialize(object obj)
			{
				return null;
			}

			[Token(Token = "0x60002FE")]
			[Address(RVA = "0x2C209F4", Offset = "0x2C209F4", VA = "0x2C209F4")]
			private void SerializeValue(object value)
			{
			}

			[Token(Token = "0x60002FF")]
			[Address(RVA = "0x2C210BC", Offset = "0x2C210BC", VA = "0x2C210BC")]
			private void SerializeObject(IDictionary obj)
			{
			}

			[Token(Token = "0x6000300")]
			[Address(RVA = "0x2C20DF0", Offset = "0x2C20DF0", VA = "0x2C20DF0")]
			private void SerializeArray(IList anArray)
			{
			}

			[Token(Token = "0x6000301")]
			[Address(RVA = "0x2C20B90", Offset = "0x2C20B90", VA = "0x2C20B90")]
			private void SerializeString(string str)
			{
			}

			[Token(Token = "0x6000302")]
			[Address(RVA = "0x2C214B4", Offset = "0x2C214B4", VA = "0x2C214B4")]
			private void SerializeOther(object value)
			{
			}
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x2C1FBE0", Offset = "0x2C1FBE0", VA = "0x2C1FBE0")]
		public static object Deserialize(string json)
		{
			return null;
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x2C1FD28", Offset = "0x2C1FD28", VA = "0x2C1FD28")]
		public static string Serialize(object obj)
		{
			return null;
		}
	}
}
namespace UnityEngine.Analytics
{
	[Serializable]
	[Token(Token = "0x2000005")]
	public class DriveableProperty
	{
		[Serializable]
		[Token(Token = "0x2000032")]
		public class FieldWithRemoteSettingsKey
		{
			[Token(Token = "0x4000137")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			private Object m_Target;

			[Token(Token = "0x4000138")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private string m_FieldPath;

			[Token(Token = "0x4000139")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private string m_RSKeyName;

			[Token(Token = "0x400013A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[SerializeField]
			private string m_Type;

			[Token(Token = "0x17000021")]
			public Object target
			{
				[Token(Token = "0x6000303")]
				[Address(RVA = "0x2C216D8", Offset = "0x2C216D8", VA = "0x2C216D8")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000304")]
				[Address(RVA = "0x2C216E0", Offset = "0x2C216E0", VA = "0x2C216E0")]
				set
				{
				}
			}

			[Token(Token = "0x17000022")]
			public string fieldPath
			{
				[Token(Token = "0x6000305")]
				[Address(RVA = "0x2C216E8", Offset = "0x2C216E8", VA = "0x2C216E8")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000306")]
				[Address(RVA = "0x2C216F0", Offset = "0x2C216F0", VA = "0x2C216F0")]
				set
				{
				}
			}

			[Token(Token = "0x17000023")]
			public string rsKeyName
			{
				[Token(Token = "0x6000307")]
				[Address(RVA = "0x2C216F8", Offset = "0x2C216F8", VA = "0x2C216F8")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000308")]
				[Address(RVA = "0x2C21700", Offset = "0x2C21700", VA = "0x2C21700")]
				set
				{
				}
			}

			[Token(Token = "0x17000024")]
			public string type
			{
				[Token(Token = "0x6000309")]
				[Address(RVA = "0x2C21708", Offset = "0x2C21708", VA = "0x2C21708")]
				get
				{
					return null;
				}
				[Token(Token = "0x600030A")]
				[Address(RVA = "0x2C21710", Offset = "0x2C21710", VA = "0x2C21710")]
				set
				{
				}
			}

			[Token(Token = "0x600030B")]
			[Address(RVA = "0x2C21718", Offset = "0x2C21718", VA = "0x2C21718")]
			public void SetValue(object val)
			{
			}

			[Token(Token = "0x600030C")]
			[Address(RVA = "0x2C21924", Offset = "0x2C21924", VA = "0x2C21924")]
			public Type GetTypeOfField()
			{
				return null;
			}

			[Token(Token = "0x600030D")]
			[Address(RVA = "0x2C21B58", Offset = "0x2C21B58", VA = "0x2C21B58")]
			public FieldWithRemoteSettingsKey()
			{
			}
		}

		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private List<FieldWithRemoteSettingsKey> m_Fields;

		[Token(Token = "0x17000001")]
		public List<FieldWithRemoteSettingsKey> fields
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x2C216C0", Offset = "0x2C216C0", VA = "0x2C216C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x2C216C8", Offset = "0x2C216C8", VA = "0x2C216C8")]
			set
			{
			}
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x2C216D0", Offset = "0x2C216D0", VA = "0x2C216D0")]
		public DriveableProperty()
		{
		}
	}
	[Token(Token = "0x2000006")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xF6C6BC", Offset = "0xF6C6BC")]
	public class RemoteSettings : MonoBehaviour
	{
		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private DriveableProperty m_DriveableProperty;

		[Token(Token = "0x17000002")]
		internal DriveableProperty DP
		{
			[Token(Token = "0x600000A")]
			[Address(RVA = "0x2C21B60", Offset = "0x2C21B60", VA = "0x2C21B60")]
			get
			{
				return null;
			}
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x2C21B68", Offset = "0x2C21B68", VA = "0x2C21B68")]
			set
			{
			}
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x2C21B70", Offset = "0x2C21B70", VA = "0x2C21B70")]
		private void Start()
		{
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x2C21BEC", Offset = "0x2C21BEC", VA = "0x2C21BEC")]
		private void RemoteSettingsUpdated()
		{
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x2C21E10", Offset = "0x2C21E10", VA = "0x2C21E10")]
		public RemoteSettings()
		{
		}
	}
}
namespace CodeStage.AntiCheat.Utils
{
	[Token(Token = "0x2000007")]
	internal class xxHash
	{
		[Token(Token = "0x4000008")]
		private const uint PRIME32_1 = 2654435761u;

		[Token(Token = "0x4000009")]
		private const uint PRIME32_2 = 2246822519u;

		[Token(Token = "0x400000A")]
		private const uint PRIME32_3 = 3266489917u;

		[Token(Token = "0x400000B")]
		private const uint PRIME32_4 = 668265263u;

		[Token(Token = "0x400000C")]
		private const uint PRIME32_5 = 374761393u;

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x2C1F810", Offset = "0x2C1F810", VA = "0x2C1F810")]
		public static uint CalculateHash(byte[] buf, int len, uint seed)
		{
			return default(uint);
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x2C1FBD0", Offset = "0x2C1FBD0", VA = "0x2C1FBD0")]
		public xxHash()
		{
		}
	}
}
namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	[Token(Token = "0x2000008")]
	public struct ObscuredBool : IEquatable<ObscuredBool>
	{
		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static byte cryptoKey;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private byte currentCryptoKey;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[SerializeField]
		private int hiddenValue;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[SerializeField]
		private bool fakeValue;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
		[SerializeField]
		private bool fakeValueChanged;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
		[SerializeField]
		private bool inited;

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x10C5120", Offset = "0x10C5120", VA = "0x10C5120")]
		private ObscuredBool(int value)
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x1DEB29C", Offset = "0x1DEB29C", VA = "0x1DEB29C")]
		public static void SetNewCryptoKey(byte newKey)
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x1DEB308", Offset = "0x1DEB308", VA = "0x1DEB308")]
		public static int Encrypt(bool value)
		{
			return default(int);
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x1DEB370", Offset = "0x1DEB370", VA = "0x1DEB370")]
		public static int Encrypt(bool value, byte key)
		{
			return default(int);
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x1DEB408", Offset = "0x1DEB408", VA = "0x1DEB408")]
		public static bool Decrypt(int value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x1DEB470", Offset = "0x1DEB470", VA = "0x1DEB470")]
		public static bool Decrypt(int value, byte key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x10C5128", Offset = "0x10C5128", VA = "0x10C5128")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x10C5130", Offset = "0x10C5130", VA = "0x10C5130")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x10C5138", Offset = "0x10C5138", VA = "0x10C5138")]
		public int GetEncrypted()
		{
			return default(int);
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x10C5160", Offset = "0x10C5160", VA = "0x10C5160")]
		public void SetEncrypted(int encrypted)
		{
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x10C5168", Offset = "0x10C5168", VA = "0x10C5168")]
		public bool GetDecrypted()
		{
			return default(bool);
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x10C5170", Offset = "0x10C5170", VA = "0x10C5170")]
		private bool InternalDecrypt()
		{
			return default(bool);
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x1DE816C", Offset = "0x1DE816C", VA = "0x1DE816C")]
		public static implicit operator ObscuredBool(bool value)
		{
			return default(ObscuredBool);
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x1DEAD8C", Offset = "0x1DEAD8C", VA = "0x1DEAD8C")]
		public static implicit operator bool(ObscuredBool value)
		{
			return default(bool);
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x10C5178", Offset = "0x10C5178", VA = "0x10C5178", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x10C5180", Offset = "0x10C5180", VA = "0x10C5180", Slot = "4")]
		public bool Equals(ObscuredBool obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x10C518C", Offset = "0x10C518C", VA = "0x10C518C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x10C51C0", Offset = "0x10C51C0", VA = "0x10C51C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000009")]
	public struct ObscuredByte : IEquatable<ObscuredByte>, IFormattable
	{
		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static byte cryptoKey;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private byte currentCryptoKey;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		private byte hiddenValue;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		private byte fakeValue;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
		private bool inited;

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x10C5248", Offset = "0x10C5248", VA = "0x10C5248")]
		private ObscuredByte(byte value)
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x1DEBA7C", Offset = "0x1DEBA7C", VA = "0x1DEBA7C")]
		public static void SetNewCryptoKey(byte newKey)
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x1DEBAE8", Offset = "0x1DEBAE8", VA = "0x1DEBAE8")]
		public static byte EncryptDecrypt(byte value)
		{
			return default(byte);
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x1DEBB50", Offset = "0x1DEBB50", VA = "0x1DEBB50")]
		public static byte EncryptDecrypt(byte value, byte key)
		{
			return default(byte);
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x10C5250", Offset = "0x10C5250", VA = "0x10C5250")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x10C5258", Offset = "0x10C5258", VA = "0x10C5258")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x10C5260", Offset = "0x10C5260", VA = "0x10C5260")]
		public byte GetEncrypted()
		{
			return default(byte);
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x10C5288", Offset = "0x10C5288", VA = "0x10C5288")]
		public void SetEncrypted(byte encrypted)
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x10C5290", Offset = "0x10C5290", VA = "0x10C5290")]
		public byte GetDecrypted()
		{
			return default(byte);
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x10C5298", Offset = "0x10C5298", VA = "0x10C5298")]
		private byte InternalDecrypt()
		{
			return default(byte);
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x1DEADB8", Offset = "0x1DEADB8", VA = "0x1DEADB8")]
		public static implicit operator ObscuredByte(byte value)
		{
			return default(ObscuredByte);
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x1DEAE48", Offset = "0x1DEAE48", VA = "0x1DEAE48")]
		public static implicit operator byte(ObscuredByte value)
		{
			return default(byte);
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x1DEBEE4", Offset = "0x1DEBEE4", VA = "0x1DEBEE4")]
		public static ObscuredByte operator ++(ObscuredByte input)
		{
			return default(ObscuredByte);
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x1DEBF80", Offset = "0x1DEBF80", VA = "0x1DEBF80")]
		public static ObscuredByte operator --(ObscuredByte input)
		{
			return default(ObscuredByte);
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x10C52A0", Offset = "0x10C52A0", VA = "0x10C52A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x10C52A8", Offset = "0x10C52A8", VA = "0x10C52A8", Slot = "4")]
		public bool Equals(ObscuredByte obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x10C52B4", Offset = "0x10C52B4", VA = "0x10C52B4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x10C52E4", Offset = "0x10C52E4", VA = "0x10C52E4")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x10C531C", Offset = "0x10C531C", VA = "0x10C531C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x10C534C", Offset = "0x10C534C", VA = "0x10C534C")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x10C5384", Offset = "0x10C5384", VA = "0x10C5384", Slot = "5")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x200000A")]
	public struct ObscuredChar : IEquatable<ObscuredChar>
	{
		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static char cryptoKey;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private char currentCryptoKey;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		private char hiddenValue;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private char fakeValue;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
		private bool inited;

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x10C5420", Offset = "0x10C5420", VA = "0x10C5420")]
		private ObscuredChar(char value)
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x1DEC33C", Offset = "0x1DEC33C", VA = "0x1DEC33C")]
		public static void SetNewCryptoKey(char newKey)
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x1DEC3A8", Offset = "0x1DEC3A8", VA = "0x1DEC3A8")]
		public static char EncryptDecrypt(char value)
		{
			return default(char);
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x1DEC410", Offset = "0x1DEC410", VA = "0x1DEC410")]
		public static char EncryptDecrypt(char value, char key)
		{
			return default(char);
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x10C5428", Offset = "0x10C5428", VA = "0x10C5428")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x10C5430", Offset = "0x10C5430", VA = "0x10C5430")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x10C5438", Offset = "0x10C5438", VA = "0x10C5438")]
		public char GetEncrypted()
		{
			return default(char);
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x10C5460", Offset = "0x10C5460", VA = "0x10C5460")]
		public void SetEncrypted(char encrypted)
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x10C5468", Offset = "0x10C5468", VA = "0x10C5468")]
		public char GetDecrypted()
		{
			return default(char);
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x10C5470", Offset = "0x10C5470", VA = "0x10C5470")]
		private char InternalDecrypt()
		{
			return default(char);
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x1DEC7A8", Offset = "0x1DEC7A8", VA = "0x1DEC7A8")]
		public static implicit operator ObscuredChar(char value)
		{
			return default(ObscuredChar);
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x1DEC838", Offset = "0x1DEC838", VA = "0x1DEC838")]
		public static implicit operator char(ObscuredChar value)
		{
			return default(char);
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x1DEC85C", Offset = "0x1DEC85C", VA = "0x1DEC85C")]
		public static ObscuredChar operator ++(ObscuredChar input)
		{
			return default(ObscuredChar);
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x1DEC8F8", Offset = "0x1DEC8F8", VA = "0x1DEC8F8")]
		public static ObscuredChar operator --(ObscuredChar input)
		{
			return default(ObscuredChar);
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x10C5478", Offset = "0x10C5478", VA = "0x10C5478", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x10C5480", Offset = "0x10C5480", VA = "0x10C5480", Slot = "4")]
		public bool Equals(ObscuredChar obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x10C5488", Offset = "0x10C5488", VA = "0x10C5488", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x10C54B8", Offset = "0x10C54B8", VA = "0x10C54B8")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x10C54F0", Offset = "0x10C54F0", VA = "0x10C54F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x200000B")]
	public struct ObscuredDecimal : IEquatable<ObscuredDecimal>, IFormattable
	{
		[StructLayout(2)]
		[Token(Token = "0x2000033")]
		private struct DecimalLongBytesUnion
		{
			[Token(Token = "0x400013B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public decimal d;

			[Token(Token = "0x400013C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public long l1;

			[Token(Token = "0x400013D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public long l2;

			[Token(Token = "0x400013E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ACTkByte16 b16;
		}

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static long cryptoKey;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private long currentCryptoKey;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xF6CAAC", Offset = "0xF6CAAC")]
		private byte[] hiddenValueOld;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private ACTkByte16 hiddenValue;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private decimal fakeValue;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool inited;

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x10C5634", Offset = "0x10C5634", VA = "0x10C5634")]
		private ObscuredDecimal(ACTkByte16 value)
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x1DECC4C", Offset = "0x1DECC4C", VA = "0x1DECC4C")]
		public static void SetNewCryptoKey(long newKey)
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x1DECCB8", Offset = "0x1DECCB8", VA = "0x1DECCB8")]
		public static decimal Encrypt(decimal value)
		{
			return default(decimal);
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x1DECD38", Offset = "0x1DECD38", VA = "0x1DECD38")]
		public static decimal Encrypt(decimal value, long key)
		{
			return default(decimal);
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x1DECD44", Offset = "0x1DECD44", VA = "0x1DECD44")]
		private static ACTkByte16 InternalEncrypt(decimal value)
		{
			return default(ACTkByte16);
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x1DECDBC", Offset = "0x1DECDBC", VA = "0x1DECDBC")]
		private static ACTkByte16 InternalEncrypt(decimal value, long key)
		{
			return default(ACTkByte16);
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x1DECE44", Offset = "0x1DECE44", VA = "0x1DECE44")]
		public static decimal Decrypt(decimal value)
		{
			return default(decimal);
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x1DECEC4", Offset = "0x1DECEC4", VA = "0x1DECEC4")]
		public static decimal Decrypt(decimal value, long key)
		{
			return default(decimal);
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x10C563C", Offset = "0x10C563C", VA = "0x10C563C")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x10C5644", Offset = "0x10C5644", VA = "0x10C5644")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x10C564C", Offset = "0x10C564C", VA = "0x10C564C")]
		public decimal GetEncrypted()
		{
			return default(decimal);
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x10C5674", Offset = "0x10C5674", VA = "0x10C5674")]
		public void SetEncrypted(decimal encrypted)
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x10C567C", Offset = "0x10C567C", VA = "0x10C567C")]
		public decimal GetDecrypted()
		{
			return default(decimal);
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x10C5684", Offset = "0x10C5684", VA = "0x10C5684")]
		private decimal InternalDecrypt()
		{
			return default(decimal);
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x1DED264", Offset = "0x1DED264", VA = "0x1DED264")]
		public static implicit operator ObscuredDecimal(decimal value)
		{
			return default(ObscuredDecimal);
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x1DED33C", Offset = "0x1DED33C", VA = "0x1DED33C")]
		public static implicit operator decimal(ObscuredDecimal value)
		{
			return default(decimal);
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x1DED340", Offset = "0x1DED340", VA = "0x1DED340")]
		public static explicit operator ObscuredDecimal(ObscuredFloat f)
		{
			return default(ObscuredDecimal);
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x1DED44C", Offset = "0x1DED44C", VA = "0x1DED44C")]
		public static ObscuredDecimal operator ++(ObscuredDecimal input)
		{
			return default(ObscuredDecimal);
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x1DED550", Offset = "0x1DED550", VA = "0x1DED550")]
		public static ObscuredDecimal operator --(ObscuredDecimal input)
		{
			return default(ObscuredDecimal);
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x10C568C", Offset = "0x10C568C", VA = "0x10C568C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x10C56BC", Offset = "0x10C56BC", VA = "0x10C56BC")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x10C56FC", Offset = "0x10C56FC", VA = "0x10C56FC")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x10C573C", Offset = "0x10C573C", VA = "0x10C573C", Slot = "5")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x10C5784", Offset = "0x10C5784", VA = "0x10C5784", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x10C578C", Offset = "0x10C578C", VA = "0x10C578C", Slot = "4")]
		public bool Equals(ObscuredDecimal obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x10C57CC", Offset = "0x10C57CC", VA = "0x10C57CC", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x200000C")]
	public struct ObscuredDouble : IEquatable<ObscuredDouble>, IFormattable
	{
		[StructLayout(2)]
		[Token(Token = "0x2000034")]
		private struct DoubleLongBytesUnion
		{
			[Token(Token = "0x400013F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public double d;

			[Token(Token = "0x4000140")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public long l;

			[Token(Token = "0x4000141")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ACTkByte8 b8;
		}

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static long cryptoKey;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private long currentCryptoKey;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[SerializeField]
		private ACTkByte8 hiddenValue;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xF6CB04", Offset = "0xF6CB04")]
		private byte[] hiddenValueOld;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private double fakeValue;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool inited;

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x10C5910", Offset = "0x10C5910", VA = "0x10C5910")]
		private ObscuredDouble(ACTkByte8 value)
		{
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x1DED958", Offset = "0x1DED958", VA = "0x1DED958")]
		public static void SetNewCryptoKey(long newKey)
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x1DED9C4", Offset = "0x1DED9C4", VA = "0x1DED9C4")]
		public static long Encrypt(double value)
		{
			return default(long);
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x1DEDA40", Offset = "0x1DEDA40", VA = "0x1DEDA40")]
		public static long Encrypt(double value, long key)
		{
			return default(long);
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x1DEDA4C", Offset = "0x1DEDA4C", VA = "0x1DEDA4C")]
		private static ACTkByte8 InternalEncrypt(double value)
		{
			return default(ACTkByte8);
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x1DEDABC", Offset = "0x1DEDABC", VA = "0x1DEDABC")]
		private static ACTkByte8 InternalEncrypt(double value, long key)
		{
			return default(ACTkByte8);
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x1DEDB40", Offset = "0x1DEDB40", VA = "0x1DEDB40")]
		public static double Decrypt(long value)
		{
			return default(double);
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x1DEDBB4", Offset = "0x1DEDBB4", VA = "0x1DEDBB4")]
		public static double Decrypt(long value, long key)
		{
			return default(double);
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x10C5918", Offset = "0x10C5918", VA = "0x10C5918")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x10C5920", Offset = "0x10C5920", VA = "0x10C5920")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x10C5928", Offset = "0x10C5928", VA = "0x10C5928")]
		public long GetEncrypted()
		{
			return default(long);
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x10C5950", Offset = "0x10C5950", VA = "0x10C5950")]
		public void SetEncrypted(long encrypted)
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x10C5958", Offset = "0x10C5958", VA = "0x10C5958")]
		public double GetDecrypted()
		{
			return default(double);
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x10C5960", Offset = "0x10C5960", VA = "0x10C5960")]
		private double InternalDecrypt()
		{
			return default(double);
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x1DE82BC", Offset = "0x1DE82BC", VA = "0x1DE82BC")]
		public static implicit operator ObscuredDouble(double value)
		{
			return default(ObscuredDouble);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x1DEAE6C", Offset = "0x1DEAE6C", VA = "0x1DEAE6C")]
		public static implicit operator double(ObscuredDouble value)
		{
			return default(double);
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x1DEDEDC", Offset = "0x1DEDEDC", VA = "0x1DEDEDC")]
		public static ObscuredDouble operator ++(ObscuredDouble input)
		{
			return default(ObscuredDouble);
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x1DEDF90", Offset = "0x1DEDF90", VA = "0x1DEDF90")]
		public static ObscuredDouble operator --(ObscuredDouble input)
		{
			return default(ObscuredDouble);
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x10C5968", Offset = "0x10C5968", VA = "0x10C5968", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x10C5998", Offset = "0x10C5998", VA = "0x10C5998")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x10C59D0", Offset = "0x10C59D0", VA = "0x10C59D0")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x10C5A08", Offset = "0x10C5A08", VA = "0x10C5A08", Slot = "5")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x10C5A50", Offset = "0x10C5A50", VA = "0x10C5A50", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x10C5A58", Offset = "0x10C5A58", VA = "0x10C5A58", Slot = "4")]
		public bool Equals(ObscuredDouble obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x10C5A90", Offset = "0x10C5A90", VA = "0x10C5A90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x200000D")]
	public struct ObscuredFloat : IEquatable<ObscuredFloat>, IFormattable
	{
		[StructLayout(2)]
		[Token(Token = "0x2000035")]
		private struct FloatIntBytesUnion
		{
			[Token(Token = "0x4000142")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float f;

			[Token(Token = "0x4000143")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int i;

			[Token(Token = "0x4000144")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ACTkByte4 b4;
		}

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int cryptoKey;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private int currentCryptoKey;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[SerializeField]
		private ACTkByte4 hiddenValue;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xF6CB90", Offset = "0xF6CB90")]
		private byte[] hiddenValueOld;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private float fakeValue;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private bool inited;

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x10C5BD4", Offset = "0x10C5BD4", VA = "0x10C5BD4")]
		private ObscuredFloat(ACTkByte4 value)
		{
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x1DEE318", Offset = "0x1DEE318", VA = "0x1DEE318")]
		public static void SetNewCryptoKey(int newKey)
		{
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x1DEE384", Offset = "0x1DEE384", VA = "0x1DEE384")]
		public static int Encrypt(float value)
		{
			return default(int);
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x1DEE400", Offset = "0x1DEE400", VA = "0x1DEE400")]
		public static int Encrypt(float value, int key)
		{
			return default(int);
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x1DEE40C", Offset = "0x1DEE40C", VA = "0x1DEE40C")]
		private static ACTkByte4 InternalEncrypt(float value)
		{
			return default(ACTkByte4);
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x1DEE484", Offset = "0x1DEE484", VA = "0x1DEE484")]
		private static ACTkByte4 InternalEncrypt(float value, int key)
		{
			return default(ACTkByte4);
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x1DEE508", Offset = "0x1DEE508", VA = "0x1DEE508")]
		public static float Decrypt(int value)
		{
			return default(float);
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x1DEE57C", Offset = "0x1DEE57C", VA = "0x1DEE57C")]
		public static float Decrypt(int value, int key)
		{
			return default(float);
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x10C5BE0", Offset = "0x10C5BE0", VA = "0x10C5BE0")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x10C5BE8", Offset = "0x10C5BE8", VA = "0x10C5BE8")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x10C5BF0", Offset = "0x10C5BF0", VA = "0x10C5BF0")]
		public int GetEncrypted()
		{
			return default(int);
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x10C5C18", Offset = "0x10C5C18", VA = "0x10C5C18")]
		public void SetEncrypted(int encrypted)
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x10C5C20", Offset = "0x10C5C20", VA = "0x10C5C20")]
		public float GetDecrypted()
		{
			return default(float);
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x10C5C28", Offset = "0x10C5C28", VA = "0x10C5C28")]
		private float InternalDecrypt()
		{
			return default(float);
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x1DDDADC", Offset = "0x1DDDADC", VA = "0x1DDDADC")]
		public static implicit operator ObscuredFloat(float value)
		{
			return default(ObscuredFloat);
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x1DDDBAC", Offset = "0x1DDDBAC", VA = "0x1DDDBAC")]
		public static implicit operator float(ObscuredFloat value)
		{
			return default(float);
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x1DDDBB0", Offset = "0x1DDDBB0", VA = "0x1DDDBB0")]
		public static ObscuredFloat operator ++(ObscuredFloat input)
		{
			return default(ObscuredFloat);
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x1DDDC64", Offset = "0x1DDDC64", VA = "0x1DDDC64")]
		public static ObscuredFloat operator --(ObscuredFloat input)
		{
			return default(ObscuredFloat);
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x10C5C30", Offset = "0x10C5C30", VA = "0x10C5C30", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x10C5C38", Offset = "0x10C5C38", VA = "0x10C5C38", Slot = "4")]
		public bool Equals(ObscuredFloat obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x10C5C70", Offset = "0x10C5C70", VA = "0x10C5C70", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x10C5CA0", Offset = "0x10C5CA0", VA = "0x10C5CA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x10C5CD0", Offset = "0x10C5CD0", VA = "0x10C5CD0")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x10C5D08", Offset = "0x10C5D08", VA = "0x10C5D08")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x10C5D40", Offset = "0x10C5D40", VA = "0x10C5D40", Slot = "5")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x200000E")]
	public struct ObscuredInt : IEquatable<ObscuredInt>, IFormattable
	{
		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int cryptoKey;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private int currentCryptoKey;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[SerializeField]
		private int hiddenValue;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[SerializeField]
		private int fakeValue;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		private bool inited;

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x10C5DDC", Offset = "0x10C5DDC", VA = "0x10C5DDC")]
		private ObscuredInt(int value)
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x1DEEAA8", Offset = "0x1DEEAA8", VA = "0x1DEEAA8")]
		public static void SetNewCryptoKey(int newKey)
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x1DEEB14", Offset = "0x1DEEB14", VA = "0x1DEEB14")]
		public static int Encrypt(int value)
		{
			return default(int);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x1DEEB7C", Offset = "0x1DEEB7C", VA = "0x1DEEB7C")]
		public static int Encrypt(int value, int key)
		{
			return default(int);
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x1DEEBFC", Offset = "0x1DEEBFC", VA = "0x1DEEBFC")]
		public static int Decrypt(int value)
		{
			return default(int);
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x1DEEC64", Offset = "0x1DEEC64", VA = "0x1DEEC64")]
		public static int Decrypt(int value, int key)
		{
			return default(int);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x10C5DE4", Offset = "0x10C5DE4", VA = "0x10C5DE4")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x10C5DEC", Offset = "0x10C5DEC", VA = "0x10C5DEC")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x10C5DF4", Offset = "0x10C5DF4", VA = "0x10C5DF4")]
		public int GetEncrypted()
		{
			return default(int);
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x10C5E1C", Offset = "0x10C5E1C", VA = "0x10C5E1C")]
		public void SetEncrypted(int encrypted)
		{
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x10C5E24", Offset = "0x10C5E24", VA = "0x10C5E24")]
		public int GetDecrypted()
		{
			return default(int);
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x10C5E2C", Offset = "0x10C5E2C", VA = "0x10C5E2C")]
		private int InternalDecrypt()
		{
			return default(int);
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x1DDD898", Offset = "0x1DDD898", VA = "0x1DDD898")]
		public static implicit operator ObscuredInt(int value)
		{
			return default(ObscuredInt);
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x1DDD94C", Offset = "0x1DDD94C", VA = "0x1DDD94C")]
		public static implicit operator int(ObscuredInt value)
		{
			return default(int);
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x1DEEF30", Offset = "0x1DEEF30", VA = "0x1DEEF30")]
		public static implicit operator ObscuredFloat(ObscuredInt value)
		{
			return default(ObscuredFloat);
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x1DEEFB4", Offset = "0x1DEEFB4", VA = "0x1DEEFB4")]
		public static implicit operator ObscuredDouble(ObscuredInt value)
		{
			return default(ObscuredDouble);
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x1DEF038", Offset = "0x1DEF038", VA = "0x1DEF038")]
		public static explicit operator ObscuredUInt(ObscuredInt value)
		{
			return default(ObscuredUInt);
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x1DDD970", Offset = "0x1DDD970", VA = "0x1DDD970")]
		public static ObscuredInt operator ++(ObscuredInt input)
		{
			return default(ObscuredInt);
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x1DDDA0C", Offset = "0x1DDDA0C", VA = "0x1DDDA0C")]
		public static ObscuredInt operator --(ObscuredInt input)
		{
			return default(ObscuredInt);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x10C5E34", Offset = "0x10C5E34", VA = "0x10C5E34", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x10C5E3C", Offset = "0x10C5E3C", VA = "0x10C5E3C", Slot = "4")]
		public bool Equals(ObscuredInt obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x10C5E44", Offset = "0x10C5E44", VA = "0x10C5E44", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x10C5E74", Offset = "0x10C5E74", VA = "0x10C5E74", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x10C5EA4", Offset = "0x10C5EA4", VA = "0x10C5EA4")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x10C5EDC", Offset = "0x10C5EDC", VA = "0x10C5EDC")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x10C5F14", Offset = "0x10C5F14", VA = "0x10C5F14", Slot = "5")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x200000F")]
	public struct ObscuredLong : IEquatable<ObscuredLong>, IFormattable
	{
		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static long cryptoKey;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private long currentCryptoKey;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[SerializeField]
		private long hiddenValue;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private long fakeValue;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool inited;

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x10C5FB0", Offset = "0x10C5FB0", VA = "0x10C5FB0")]
		private ObscuredLong(long value)
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x1DEF3A0", Offset = "0x1DEF3A0", VA = "0x1DEF3A0")]
		public static void SetNewCryptoKey(long newKey)
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x1DEF40C", Offset = "0x1DEF40C", VA = "0x1DEF40C")]
		public static long Encrypt(long value)
		{
			return default(long);
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x1DEF4F4", Offset = "0x1DEF4F4", VA = "0x1DEF4F4")]
		public static long Decrypt(long value)
		{
			return default(long);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x1DEF474", Offset = "0x1DEF474", VA = "0x1DEF474")]
		public static long Encrypt(long value, long key)
		{
			return default(long);
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x1DEF55C", Offset = "0x1DEF55C", VA = "0x1DEF55C")]
		public static long Decrypt(long value, long key)
		{
			return default(long);
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x10C5FB8", Offset = "0x10C5FB8", VA = "0x10C5FB8")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x10C5FC0", Offset = "0x10C5FC0", VA = "0x10C5FC0")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x10C5FC8", Offset = "0x10C5FC8", VA = "0x10C5FC8")]
		public long GetEncrypted()
		{
			return default(long);
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x10C5FF0", Offset = "0x10C5FF0", VA = "0x10C5FF0")]
		public void SetEncrypted(long encrypted)
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x10C5FF8", Offset = "0x10C5FF8", VA = "0x10C5FF8")]
		public long GetDecrypted()
		{
			return default(long);
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x10C6000", Offset = "0x10C6000", VA = "0x10C6000")]
		private long InternalDecrypt()
		{
			return default(long);
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x1DE8218", Offset = "0x1DE8218", VA = "0x1DE8218")]
		public static implicit operator ObscuredLong(long value)
		{
			return default(ObscuredLong);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x1DEAE70", Offset = "0x1DEAE70", VA = "0x1DEAE70")]
		public static implicit operator long(ObscuredLong value)
		{
			return default(long);
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x1DEF8EC", Offset = "0x1DEF8EC", VA = "0x1DEF8EC")]
		public static ObscuredLong operator ++(ObscuredLong input)
		{
			return default(ObscuredLong);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x1DEF990", Offset = "0x1DEF990", VA = "0x1DEF990")]
		public static ObscuredLong operator --(ObscuredLong input)
		{
			return default(ObscuredLong);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x10C6008", Offset = "0x10C6008", VA = "0x10C6008", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x10C6010", Offset = "0x10C6010", VA = "0x10C6010", Slot = "4")]
		public bool Equals(ObscuredLong obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x10C6040", Offset = "0x10C6040", VA = "0x10C6040", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x10C6070", Offset = "0x10C6070", VA = "0x10C6070", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x10C60A0", Offset = "0x10C60A0", VA = "0x10C60A0")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x10C60D8", Offset = "0x10C60D8", VA = "0x10C60D8")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x10C6110", Offset = "0x10C6110", VA = "0x10C6110", Slot = "5")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}
	}
	[Token(Token = "0x2000010")]
	public static class ObscuredPrefs
	{
		[Token(Token = "0x2000036")]
		internal enum DataType : byte
		{
			[Token(Token = "0x4000146")]
			Unknown = 0,
			[Token(Token = "0x4000147")]
			Int = 5,
			[Token(Token = "0x4000148")]
			UInt = 10,
			[Token(Token = "0x4000149")]
			String = 15,
			[Token(Token = "0x400014A")]
			Float = 20,
			[Token(Token = "0x400014B")]
			Double = 25,
			[Token(Token = "0x400014C")]
			Decimal = 27,
			[Token(Token = "0x400014D")]
			Long = 30,
			[Token(Token = "0x400014E")]
			ULong = 32,
			[Token(Token = "0x400014F")]
			Bool = 35,
			[Token(Token = "0x4000150")]
			ByteArray = 40,
			[Token(Token = "0x4000151")]
			Vector2 = 45,
			[Token(Token = "0x4000152")]
			Vector3 = 50,
			[Token(Token = "0x4000153")]
			Quaternion = 55,
			[Token(Token = "0x4000154")]
			Color = 60,
			[Token(Token = "0x4000155")]
			Rect = 65
		}

		[Token(Token = "0x2000037")]
		public enum DeviceLockLevel : byte
		{
			[Token(Token = "0x4000157")]
			None,
			[Token(Token = "0x4000158")]
			Soft,
			[Token(Token = "0x4000159")]
			Strict
		}

		[Token(Token = "0x4000039")]
		private const byte VERSION = 2;

		[Token(Token = "0x400003A")]
		private const string RAW_NOT_FOUND = "{not_found}";

		[Token(Token = "0x400003B")]
		private const string DATA_SEPARATOR = "|";

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool foreignSavesReported;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static string cryptoKey;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static string deviceId;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static uint deviceIdHash;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Action onAlterationDetected;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static bool preservePlayerPrefs;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static Action onPossibleForeignSavesDetected;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static DeviceLockLevel lockToDevice;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public static bool readForeignSaves;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
		public static bool emergencyMode;

		[Token(Token = "0x4000046")]
		private const char DEPRECATED_RAW_SEPARATOR = ':';

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static string deprecatedDeviceId;

		[Token(Token = "0x17000003")]
		public static string CryptoKey
		{
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0x1DEFD44", Offset = "0x1DEFD44", VA = "0x1DEFD44")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0x1DEFCD4", Offset = "0x1DEFCD4", VA = "0x1DEFCD4")]
			set
			{
			}
		}

		[Token(Token = "0x17000004")]
		public static string DeviceId
		{
			[Token(Token = "0x60000D2")]
			[Address(RVA = "0x1DEFDAC", Offset = "0x1DEFDAC", VA = "0x1DEFDAC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D3")]
			[Address(RVA = "0x1DEFEE4", Offset = "0x1DEFEE4", VA = "0x1DEFEE4")]
			set
			{
			}
		}

		[Token(Token = "0x17000005")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xF6D660", Offset = "0xF6D660")]
		internal static string DeviceID
		{
			[Token(Token = "0x60000D4")]
			[Address(RVA = "0x1DEFF54", Offset = "0x1DEFF54", VA = "0x1DEFF54")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0x1DEFFB0", Offset = "0x1DEFFB0", VA = "0x1DEFFB0")]
			set
			{
			}
		}

		[Token(Token = "0x17000006")]
		private static uint DeviceIdHash
		{
			[Token(Token = "0x60000D6")]
			[Address(RVA = "0x1DF0064", Offset = "0x1DF0064", VA = "0x1DF0064")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x17000007")]
		private static string DeprecatedDeviceId
		{
			[Token(Token = "0x6000136")]
			[Address(RVA = "0x1DF45B8", Offset = "0x1DF45B8", VA = "0x1DF45B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x1DF01E4", Offset = "0x1DF01E4", VA = "0x1DF01E4")]
		public static void ForceLockToDeviceInit()
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x1DF02E4", Offset = "0x1DF02E4", VA = "0x1DF02E4")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xF6D420", Offset = "0xF6D420")]
		internal static void SetNewCryptoKey(string newKey)
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x1DE7454", Offset = "0x1DE7454", VA = "0x1DE7454")]
		public static void SetInt(string key, int value)
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x1DF053C", Offset = "0x1DF053C", VA = "0x1DF053C")]
		public static int GetInt(string key)
		{
			return default(int);
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x1DE6780", Offset = "0x1DE6780", VA = "0x1DE6780")]
		public static int GetInt(string key, int defaultValue)
		{
			return default(int);
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x1DF0490", Offset = "0x1DF0490", VA = "0x1DF0490")]
		internal static string EncryptIntValue(string key, int value)
		{
			return null;
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x1DF0688", Offset = "0x1DF0688", VA = "0x1DF0688")]
		internal static int DecryptIntValue(string key, string encryptedInput, int defaultValue)
		{
			return default(int);
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x1DE7694", Offset = "0x1DE7694", VA = "0x1DE7694")]
		public static void SetUInt(string key, uint value)
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x1DF1428", Offset = "0x1DF1428", VA = "0x1DF1428")]
		public static uint GetUInt(string key)
		{
			return default(uint);
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x1DE6CD8", Offset = "0x1DE6CD8", VA = "0x1DE6CD8")]
		public static uint GetUInt(string key, uint defaultValue)
		{
			return default(uint);
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x1DF137C", Offset = "0x1DF137C", VA = "0x1DF137C")]
		private static string EncryptUIntValue(string key, uint value)
		{
			return null;
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x1DF1490", Offset = "0x1DF1490", VA = "0x1DF1490")]
		private static uint DecryptUIntValue(string key, string encryptedInput, uint defaultValue)
		{
			return default(uint);
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x1DE7574", Offset = "0x1DE7574", VA = "0x1DE7574")]
		public static void SetString(string key, string value)
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x1DF1694", Offset = "0x1DF1694", VA = "0x1DF1694")]
		public static string GetString(string key)
		{
			return null;
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x1DE6A84", Offset = "0x1DE6A84", VA = "0x1DE6A84")]
		public static string GetString(string key, string defaultValue)
		{
			return null;
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x1DF15F0", Offset = "0x1DF15F0", VA = "0x1DF15F0")]
		internal static string EncryptStringValue(string key, string value)
		{
			return null;
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x1DF1704", Offset = "0x1DF1704", VA = "0x1DF1704")]
		internal static string DecryptStringValue(string key, string encryptedInput, string defaultValue)
		{
			return null;
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x1DE74E4", Offset = "0x1DE74E4", VA = "0x1DE74E4")]
		public static void SetFloat(string key, float value)
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x1DF18F0", Offset = "0x1DF18F0", VA = "0x1DF18F0")]
		public static float GetFloat(string key)
		{
			return default(float);
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x1DE6900", Offset = "0x1DE6900", VA = "0x1DE6900")]
		public static float GetFloat(string key, float defaultValue)
		{
			return default(float);
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x1DF1844", Offset = "0x1DF1844", VA = "0x1DF1844")]
		internal static string EncryptFloatValue(string key, float value)
		{
			return null;
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x1DF1958", Offset = "0x1DF1958", VA = "0x1DF1958")]
		internal static float DecryptFloatValue(string key, string encryptedInput, float defaultValue)
		{
			return default(float);
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x1DE77B4", Offset = "0x1DE77B4", VA = "0x1DE77B4")]
		public static void SetDouble(string key, double value)
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x1DF1B6C", Offset = "0x1DF1B6C", VA = "0x1DF1B6C")]
		public static double GetDouble(string key)
		{
			return default(double);
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x1DE6E80", Offset = "0x1DE6E80", VA = "0x1DE6E80")]
		public static double GetDouble(string key, double defaultValue)
		{
			return default(double);
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x1DF1AC0", Offset = "0x1DF1AC0", VA = "0x1DF1AC0")]
		private static string EncryptDoubleValue(string key, double value)
		{
			return null;
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x1DF1BD4", Offset = "0x1DF1BD4", VA = "0x1DF1BD4")]
		private static double DecryptDoubleValue(string key, string encryptedInput, double defaultValue)
		{
			return default(double);
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x1DF1D5C", Offset = "0x1DF1D5C", VA = "0x1DF1D5C")]
		public static void SetDecimal(string key, decimal value)
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x1DF1E84", Offset = "0x1DF1E84", VA = "0x1DF1E84")]
		public static decimal GetDecimal(string key)
		{
			return default(decimal);
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x1DF1F28", Offset = "0x1DF1F28", VA = "0x1DF1F28")]
		public static decimal GetDecimal(string key, decimal defaultValue)
		{
			return default(decimal);
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x1DF1DF4", Offset = "0x1DF1DF4", VA = "0x1DF1DF4")]
		private static string EncryptDecimalValue(string key, decimal value)
		{
			return null;
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x1DF200C", Offset = "0x1DF200C", VA = "0x1DF200C")]
		private static decimal DecryptDecimalValue(string key, string encryptedInput, decimal defaultValue)
		{
			return default(decimal);
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x1DE7724", Offset = "0x1DE7724", VA = "0x1DE7724")]
		public static void SetLong(string key, long value)
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x1DF2220", Offset = "0x1DF2220", VA = "0x1DF2220")]
		public static long GetLong(string key)
		{
			return default(long);
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x1DE6DAC", Offset = "0x1DE6DAC", VA = "0x1DE6DAC")]
		public static long GetLong(string key, long defaultValue)
		{
			return default(long);
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x1DF2174", Offset = "0x1DF2174", VA = "0x1DF2174")]
		private static string EncryptLongValue(string key, long value)
		{
			return null;
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x1DF2288", Offset = "0x1DF2288", VA = "0x1DF2288")]
		private static long DecryptLongValue(string key, string encryptedInput, long defaultValue)
		{
			return default(long);
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x1DF23E8", Offset = "0x1DF23E8", VA = "0x1DF23E8")]
		public static void SetULong(string key, ulong value)
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x1DF2524", Offset = "0x1DF2524", VA = "0x1DF2524")]
		public static ulong GetULong(string key)
		{
			return default(ulong);
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x1DF258C", Offset = "0x1DF258C", VA = "0x1DF258C")]
		public static ulong GetULong(string key, ulong defaultValue)
		{
			return default(ulong);
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x1DF2478", Offset = "0x1DF2478", VA = "0x1DF2478")]
		private static string EncryptULongValue(string key, ulong value)
		{
			return null;
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x1DF2660", Offset = "0x1DF2660", VA = "0x1DF2660")]
		private static ulong DecryptULongValue(string key, string encryptedInput, ulong defaultValue)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x1DE7604", Offset = "0x1DE7604", VA = "0x1DE7604")]
		public static void SetBool(string key, bool value)
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x1DF286C", Offset = "0x1DF286C", VA = "0x1DF286C")]
		public static bool GetBool(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x1DE6C04", Offset = "0x1DE6C04", VA = "0x1DE6C04")]
		public static bool GetBool(string key, bool defaultValue)
		{
			return default(bool);
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x1DF27C0", Offset = "0x1DF27C0", VA = "0x1DF27C0")]
		private static string EncryptBoolValue(string key, bool value)
		{
			return null;
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x1DF28D4", Offset = "0x1DF28D4", VA = "0x1DF28D4")]
		private static bool DecryptBoolValue(string key, string encryptedInput, bool defaultValue)
		{
			return default(bool);
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x1DE7B80", Offset = "0x1DE7B80", VA = "0x1DE7B80")]
		public static void SetByteArray(string key, byte[] value)
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x1DF2AB8", Offset = "0x1DF2AB8", VA = "0x1DF2AB8")]
		public static byte[] GetByteArray(string key)
		{
			return null;
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x1DE667C", Offset = "0x1DE667C", VA = "0x1DE667C")]
		public static byte[] GetByteArray(string key, byte defaultValue, int defaultLength)
		{
			return null;
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x1DF2A40", Offset = "0x1DF2A40", VA = "0x1DF2A40")]
		private static string EncryptByteArrayValue(string key, byte[] value)
		{
			return null;
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x1DF2BC8", Offset = "0x1DF2BC8", VA = "0x1DF2BC8")]
		private static byte[] DecryptByteArrayValue(string key, string encryptedInput, byte defaultValue, int defaultLength)
		{
			return null;
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x1DF2B24", Offset = "0x1DF2B24", VA = "0x1DF2B24")]
		private static byte[] ConstructByteArray(byte value, int length)
		{
			return null;
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x1DE7844", Offset = "0x1DE7844", VA = "0x1DE7844")]
		public static void SetVector2(string key, Vector2 value)
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x1DF2E38", Offset = "0x1DF2E38", VA = "0x1DF2E38")]
		public static Vector2 GetVector2(string key)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x1DE6F60", Offset = "0x1DE6F60", VA = "0x1DE6F60")]
		public static Vector2 GetVector2(string key, Vector2 defaultValue)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x1DF2D38", Offset = "0x1DF2D38", VA = "0x1DF2D38")]
		private static string EncryptVector2Value(string key, Vector2 value)
		{
			return null;
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x1DF2EDC", Offset = "0x1DF2EDC", VA = "0x1DF2EDC")]
		private static Vector2 DecryptVector2Value(string key, string encryptedInput, Vector2 defaultValue)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x1DE78DC", Offset = "0x1DE78DC", VA = "0x1DE78DC")]
		public static void SetVector3(string key, Vector3 value)
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x1DF3238", Offset = "0x1DF3238", VA = "0x1DF3238")]
		public static Vector3 GetVector3(string key)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x1DE7044", Offset = "0x1DE7044", VA = "0x1DE7044")]
		public static Vector3 GetVector3(string key, Vector3 defaultValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x1DF3108", Offset = "0x1DF3108", VA = "0x1DF3108")]
		private static string EncryptVector3Value(string key, Vector3 value)
		{
			return null;
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x1DF32EC", Offset = "0x1DF32EC", VA = "0x1DF32EC")]
		private static Vector3 DecryptVector3Value(string key, string encryptedInput, Vector3 defaultValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x1DE7984", Offset = "0x1DE7984", VA = "0x1DE7984")]
		public static void SetQuaternion(string key, Quaternion value)
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x1DF36C4", Offset = "0x1DF36C4", VA = "0x1DF36C4")]
		public static Quaternion GetQuaternion(string key)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x1DE7140", Offset = "0x1DE7140", VA = "0x1DE7140")]
		public static Quaternion GetQuaternion(string key, Quaternion defaultValue)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x1DF356C", Offset = "0x1DF356C", VA = "0x1DF356C")]
		private static string EncryptQuaternionValue(string key, Quaternion value)
		{
			return null;
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x1DF3780", Offset = "0x1DF3780", VA = "0x1DF3780")]
		private static Quaternion DecryptQuaternionValue(string key, string encryptedInput, Quaternion defaultValue)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x1DE7AE4", Offset = "0x1DE7AE4", VA = "0x1DE7AE4")]
		public static void SetColor(string key, Color32 value)
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x1DF3AE8", Offset = "0x1DF3AE8", VA = "0x1DF3AE8")]
		public static Color32 GetColor(string key)
		{
			return default(Color32);
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x1DE7358", Offset = "0x1DE7358", VA = "0x1DE7358")]
		public static Color32 GetColor(string key, Color32 defaultValue)
		{
			return default(Color32);
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x1DF3A3C", Offset = "0x1DF3A3C", VA = "0x1DF3A3C")]
		private static string EncryptColorValue(string key, uint value)
		{
			return null;
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x1DE7A34", Offset = "0x1DE7A34", VA = "0x1DE7A34")]
		public static void SetRect(string key, Rect value)
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x1DF3CF8", Offset = "0x1DF3CF8", VA = "0x1DF3CF8")]
		public static Rect GetRect(string key)
		{
			return default(Rect);
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x1DE724C", Offset = "0x1DE724C", VA = "0x1DE724C")]
		public static Rect GetRect(string key, Rect defaultValue)
		{
			return default(Rect);
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x1DF3B80", Offset = "0x1DF3B80", VA = "0x1DF3B80")]
		private static string EncryptRectValue(string key, Rect value)
		{
			return null;
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x1DF3D90", Offset = "0x1DF3D90", VA = "0x1DF3D90")]
		private static Rect DecryptRectValue(string key, string encryptedInput, Rect defaultValue)
		{
			return default(Rect);
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x1DF407C", Offset = "0x1DF407C", VA = "0x1DF407C")]
		public static void SetRawValue(string key, string encryptedValue)
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x1DF40F8", Offset = "0x1DF40F8", VA = "0x1DF40F8")]
		public static string GetRawValue(string key)
		{
			return null;
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x1DF4164", Offset = "0x1DF4164", VA = "0x1DF4164")]
		internal static DataType GetRawValueType(string value)
		{
			return default(DataType);
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x1DF0398", Offset = "0x1DF0398", VA = "0x1DF0398")]
		internal static string EncryptKey(string key)
		{
			return null;
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x1DF4290", Offset = "0x1DF4290", VA = "0x1DF4290")]
		public static bool HasKey(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x1DE7C18", Offset = "0x1DE7C18", VA = "0x1DE7C18")]
		public static void DeleteKey(string key)
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x1DF431C", Offset = "0x1DF431C", VA = "0x1DF431C")]
		public static void DeleteAll()
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x1DE7C10", Offset = "0x1DE7C10", VA = "0x1DE7C10")]
		public static void Save()
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x1DF05A4", Offset = "0x1DF05A4", VA = "0x1DF05A4")]
		private static string GetEncryptedPrefsString(string key, string encryptedKey)
		{
			return null;
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x1DF07E8", Offset = "0x1DF07E8", VA = "0x1DF07E8")]
		private static string EncryptData(string key, byte[] cleanBytes, DataType type)
		{
			return null;
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x1DF0F24", Offset = "0x1DF0F24", VA = "0x1DF0F24")]
		internal static byte[] DecryptData(string key, string encryptedInput)
		{
			return null;
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x1DF0124", Offset = "0x1DF0124", VA = "0x1DF0124")]
		private static uint CalculateChecksum(string input)
		{
			return default(uint);
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x1DF4424", Offset = "0x1DF4424", VA = "0x1DF4424")]
		private static void SavesTampered()
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x1DF44E0", Offset = "0x1DF44E0", VA = "0x1DF44E0")]
		private static void PossibleForeignSavesDetected()
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x1DEFE78", Offset = "0x1DEFE78", VA = "0x1DEFE78")]
		private static string GetDeviceId()
		{
			return null;
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x1DF4324", Offset = "0x1DF4324", VA = "0x1DF4324")]
		private static byte[] EncryptDecryptBytes(byte[] bytes, int dataLength, string key)
		{
			return null;
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x1DF0ABC", Offset = "0x1DF0ABC", VA = "0x1DF0ABC")]
		private static string DeprecatedDecryptValue(string value)
		{
			return null;
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x1DF4688", Offset = "0x1DF4688", VA = "0x1DF4688")]
		private static string DeprecatedCalculateChecksum(string input)
		{
			return null;
		}
	}
	[Token(Token = "0x2000011")]
	internal class BitconverterExt
	{
		[Token(Token = "0x6000138")]
		[Address(RVA = "0x1DEAF68", Offset = "0x1DEAF68", VA = "0x1DEAF68")]
		public static byte[] GetBytes(decimal dec)
		{
			return null;
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x1DEB0C4", Offset = "0x1DEB0C4", VA = "0x1DEB0C4")]
		public static decimal ToDecimal(byte[] bytes)
		{
			return default(decimal);
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x1DEB208", Offset = "0x1DEB208", VA = "0x1DEB208")]
		public BitconverterExt()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000012")]
	public struct ObscuredQuaternion
	{
		[Serializable]
		[Token(Token = "0x2000038")]
		public struct RawEncryptedQuaternion
		{
			[Token(Token = "0x400015A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int x;

			[Token(Token = "0x400015B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int y;

			[Token(Token = "0x400015C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int z;

			[Token(Token = "0x400015D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public int w;
		}

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int cryptoKey;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly Quaternion initialFakeValue;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private int currentCryptoKey;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[SerializeField]
		private RawEncryptedQuaternion hiddenValue;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Quaternion fakeValue;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool inited;

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x10F4A78", Offset = "0x10F4A78", VA = "0x10F4A78")]
		private ObscuredQuaternion(RawEncryptedQuaternion value)
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x10F4A80", Offset = "0x10F4A80", VA = "0x10F4A80")]
		public ObscuredQuaternion(float x, float y, float z, float w)
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x2C17818", Offset = "0x2C17818", VA = "0x2C17818")]
		public static void SetNewCryptoKey(int newKey)
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x2C17884", Offset = "0x2C17884", VA = "0x2C17884")]
		public static RawEncryptedQuaternion Encrypt(Quaternion value)
		{
			return default(RawEncryptedQuaternion);
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x2C17914", Offset = "0x2C17914", VA = "0x2C17914")]
		public static RawEncryptedQuaternion Encrypt(Quaternion value, int key)
		{
			return default(RawEncryptedQuaternion);
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x2C17704", Offset = "0x2C17704", VA = "0x2C17704")]
		public static RawEncryptedQuaternion Encrypt(float x, float y, float z, float w, int key)
		{
			return default(RawEncryptedQuaternion);
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x2C179A8", Offset = "0x2C179A8", VA = "0x2C179A8")]
		public static Quaternion Decrypt(RawEncryptedQuaternion value)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x2C17A20", Offset = "0x2C17A20", VA = "0x2C17A20")]
		public static Quaternion Decrypt(RawEncryptedQuaternion value, int key)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x10F4A88", Offset = "0x10F4A88", VA = "0x10F4A88")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x10F4A90", Offset = "0x10F4A90", VA = "0x10F4A90")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x10F4A98", Offset = "0x10F4A98", VA = "0x10F4A98")]
		public RawEncryptedQuaternion GetEncrypted()
		{
			return default(RawEncryptedQuaternion);
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x10F4AC4", Offset = "0x10F4AC4", VA = "0x10F4AC4")]
		public void SetEncrypted(RawEncryptedQuaternion encrypted)
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x10F4ACC", Offset = "0x10F4ACC", VA = "0x10F4ACC")]
		public Quaternion GetDecrypted()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x10F4AD4", Offset = "0x10F4AD4", VA = "0x10F4AD4")]
		private Quaternion InternalDecrypt()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x10F4ADC", Offset = "0x10F4ADC", VA = "0x10F4ADC")]
		private bool CompareQuaternionsWithTolerance(Quaternion q1, Quaternion q2)
		{
			return default(bool);
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x2C180D4", Offset = "0x2C180D4", VA = "0x2C180D4")]
		public static implicit operator ObscuredQuaternion(Quaternion value)
		{
			return default(ObscuredQuaternion);
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x2C181C0", Offset = "0x2C181C0", VA = "0x2C181C0")]
		public static implicit operator Quaternion(ObscuredQuaternion value)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x10F4AE0", Offset = "0x10F4AE0", VA = "0x10F4AE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x10F4AE8", Offset = "0x10F4AE8", VA = "0x10F4AE8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x10F4AF0", Offset = "0x10F4AF0", VA = "0x10F4AF0")]
		public string ToString(string format)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000013")]
	public struct ObscuredSByte : IEquatable<ObscuredSByte>, IFormattable
	{
		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static sbyte cryptoKey;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private sbyte currentCryptoKey;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		private sbyte hiddenValue;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		private sbyte fakeValue;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
		private bool inited;

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x10F4B4C", Offset = "0x10F4B4C", VA = "0x10F4B4C")]
		private ObscuredSByte(sbyte value)
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x2C1837C", Offset = "0x2C1837C", VA = "0x2C1837C")]
		public static void SetNewCryptoKey(sbyte newKey)
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x2C183E8", Offset = "0x2C183E8", VA = "0x2C183E8")]
		public static sbyte EncryptDecrypt(sbyte value)
		{
			return default(sbyte);
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x2C18450", Offset = "0x2C18450", VA = "0x2C18450")]
		public static sbyte EncryptDecrypt(sbyte value, sbyte key)
		{
			return default(sbyte);
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x10F4B54", Offset = "0x10F4B54", VA = "0x10F4B54")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x10F4B5C", Offset = "0x10F4B5C", VA = "0x10F4B5C")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x10F4B64", Offset = "0x10F4B64", VA = "0x10F4B64")]
		public sbyte GetEncrypted()
		{
			return default(sbyte);
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x10F4B8C", Offset = "0x10F4B8C", VA = "0x10F4B8C")]
		public void SetEncrypted(sbyte encrypted)
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x10F4B94", Offset = "0x10F4B94", VA = "0x10F4B94")]
		public sbyte GetDecrypted()
		{
			return default(sbyte);
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x10F4B9C", Offset = "0x10F4B9C", VA = "0x10F4B9C")]
		private sbyte InternalDecrypt()
		{
			return default(sbyte);
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x2C187F4", Offset = "0x2C187F4", VA = "0x2C187F4")]
		public static implicit operator ObscuredSByte(sbyte value)
		{
			return default(ObscuredSByte);
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x2C18888", Offset = "0x2C18888", VA = "0x2C18888")]
		public static implicit operator sbyte(ObscuredSByte value)
		{
			return default(sbyte);
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x2C188AC", Offset = "0x2C188AC", VA = "0x2C188AC")]
		public static ObscuredSByte operator ++(ObscuredSByte input)
		{
			return default(ObscuredSByte);
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x2C1894C", Offset = "0x2C1894C", VA = "0x2C1894C")]
		public static ObscuredSByte operator --(ObscuredSByte input)
		{
			return default(ObscuredSByte);
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x10F4BA4", Offset = "0x10F4BA4", VA = "0x10F4BA4", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x10F4BAC", Offset = "0x10F4BAC", VA = "0x10F4BAC", Slot = "4")]
		public bool Equals(ObscuredSByte obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x10F4BB8", Offset = "0x10F4BB8", VA = "0x10F4BB8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x10F4BE8", Offset = "0x10F4BE8", VA = "0x10F4BE8")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x10F4C20", Offset = "0x10F4C20", VA = "0x10F4C20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x10F4C50", Offset = "0x10F4C50", VA = "0x10F4C50")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x10F4C88", Offset = "0x10F4C88", VA = "0x10F4C88", Slot = "5")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000014")]
	public struct ObscuredShort : IEquatable<ObscuredShort>, IFormattable
	{
		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static short cryptoKey;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private short currentCryptoKey;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		[SerializeField]
		private short hiddenValue;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[SerializeField]
		private short fakeValue;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
		[SerializeField]
		private bool inited;

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x10F4D24", Offset = "0x10F4D24", VA = "0x10F4D24")]
		private ObscuredShort(short value)
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x2C18D0C", Offset = "0x2C18D0C", VA = "0x2C18D0C")]
		public static void SetNewCryptoKey(short newKey)
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x2C18D78", Offset = "0x2C18D78", VA = "0x2C18D78")]
		public static short EncryptDecrypt(short value)
		{
			return default(short);
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x2C18DE0", Offset = "0x2C18DE0", VA = "0x2C18DE0")]
		public static short EncryptDecrypt(short value, short key)
		{
			return default(short);
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x10F4D2C", Offset = "0x10F4D2C", VA = "0x10F4D2C")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x10F4D34", Offset = "0x10F4D34", VA = "0x10F4D34")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x10F4D3C", Offset = "0x10F4D3C", VA = "0x10F4D3C")]
		public short GetEncrypted()
		{
			return default(short);
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x10F4D64", Offset = "0x10F4D64", VA = "0x10F4D64")]
		public void SetEncrypted(short encrypted)
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x10F4D6C", Offset = "0x10F4D6C", VA = "0x10F4D6C")]
		public short GetDecrypted()
		{
			return default(short);
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x10F4D74", Offset = "0x10F4D74", VA = "0x10F4D74")]
		private short InternalDecrypt()
		{
			return default(short);
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x2C19188", Offset = "0x2C19188", VA = "0x2C19188")]
		public static implicit operator ObscuredShort(short value)
		{
			return default(ObscuredShort);
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x2C1921C", Offset = "0x2C1921C", VA = "0x2C1921C")]
		public static implicit operator short(ObscuredShort value)
		{
			return default(short);
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x2C19240", Offset = "0x2C19240", VA = "0x2C19240")]
		public static ObscuredShort operator ++(ObscuredShort input)
		{
			return default(ObscuredShort);
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x2C192D0", Offset = "0x2C192D0", VA = "0x2C192D0")]
		public static ObscuredShort operator --(ObscuredShort input)
		{
			return default(ObscuredShort);
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x10F4D7C", Offset = "0x10F4D7C", VA = "0x10F4D7C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x10F4D84", Offset = "0x10F4D84", VA = "0x10F4D84", Slot = "4")]
		public bool Equals(ObscuredShort obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x10F4D8C", Offset = "0x10F4D8C", VA = "0x10F4D8C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x10F4DBC", Offset = "0x10F4DBC", VA = "0x10F4DBC")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x10F4DF4", Offset = "0x10F4DF4", VA = "0x10F4DF4", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x10F4E24", Offset = "0x10F4E24", VA = "0x10F4E24")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x10F4E5C", Offset = "0x10F4E5C", VA = "0x10F4E5C", Slot = "5")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000015")]
	public sealed class ObscuredString
	{
		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static string cryptoKey;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string currentCryptoKey;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private byte[] hiddenValue;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string fakeValue;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool inited;

		[Token(Token = "0x17000008")]
		public int Length
		{
			[Token(Token = "0x6000189")]
			[Address(RVA = "0x2C19FB0", Offset = "0x2C19FB0", VA = "0x2C19FB0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x2C195F0", Offset = "0x2C195F0", VA = "0x2C195F0")]
		private ObscuredString()
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x2C195F8", Offset = "0x2C195F8", VA = "0x2C195F8")]
		private ObscuredString(byte[] value)
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x2C196B0", Offset = "0x2C196B0", VA = "0x2C196B0")]
		public static void SetNewCryptoKey(string newKey)
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x2C19720", Offset = "0x2C19720", VA = "0x2C19720")]
		public static string EncryptDecrypt(string value)
		{
			return null;
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x2C19790", Offset = "0x2C19790", VA = "0x2C19790")]
		public static string EncryptDecrypt(string value, string key)
		{
			return null;
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x2C19900", Offset = "0x2C19900", VA = "0x2C19900")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x2C19C20", Offset = "0x2C19C20", VA = "0x2C19C20")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x2C19D5C", Offset = "0x2C19D5C", VA = "0x2C19D5C")]
		public string GetEncrypted()
		{
			return null;
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x2C19E60", Offset = "0x2C19E60", VA = "0x2C19E60")]
		public void SetEncrypted(string encrypted)
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x2C19FAC", Offset = "0x2C19FAC", VA = "0x2C19FAC")]
		public string GetDecrypted()
		{
			return null;
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x2C19BB0", Offset = "0x2C19BB0", VA = "0x2C19BB0")]
		private static byte[] InternalEncrypt(string value)
		{
			return null;
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x2C19CE4", Offset = "0x2C19CE4", VA = "0x2C19CE4")]
		private static byte[] InternalEncrypt(string value, string key)
		{
			return null;
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x2C199F0", Offset = "0x2C199F0", VA = "0x2C199F0")]
		private string InternalDecrypt()
		{
			return null;
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x2C19FD8", Offset = "0x2C19FD8", VA = "0x2C19FD8")]
		public static implicit operator ObscuredString(string value)
		{
			return null;
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x2C1A098", Offset = "0x2C1A098", VA = "0x2C1A098")]
		public static implicit operator string(ObscuredString value)
		{
			return null;
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x2C1A21C", Offset = "0x2C1A21C", VA = "0x2C1A21C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x2C1A134", Offset = "0x2C1A134", VA = "0x2C1A134")]
		public static bool operator ==(ObscuredString a, ObscuredString b)
		{
			return default(bool);
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x2C1A2A4", Offset = "0x2C1A2A4", VA = "0x2C1A2A4")]
		public static bool operator !=(ObscuredString a, ObscuredString b)
		{
			return default(bool);
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x2C1A324", Offset = "0x2C1A324", VA = "0x2C1A324", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x2C1A3A8", Offset = "0x2C1A3A8", VA = "0x2C1A3A8")]
		public bool Equals(ObscuredString value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x2C1A4BC", Offset = "0x2C1A4BC", VA = "0x2C1A4BC")]
		public bool Equals(ObscuredString value, StringComparison comparisonType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x2C1A58C", Offset = "0x2C1A58C", VA = "0x2C1A58C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x2C19F1C", Offset = "0x2C19F1C", VA = "0x2C19F1C")]
		private static byte[] GetBytes(string str)
		{
			return null;
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x2C19DCC", Offset = "0x2C19DCC", VA = "0x2C19DCC")]
		private static string GetString(byte[] bytes)
		{
			return null;
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x2C1A220", Offset = "0x2C1A220", VA = "0x2C1A220")]
		private static bool ArraysEquals(byte[] a1, byte[] a2)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Token(Token = "0x2000016")]
	public struct ObscuredUInt : IEquatable<ObscuredUInt>, IFormattable
	{
		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static uint cryptoKey;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private uint currentCryptoKey;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[SerializeField]
		private uint hiddenValue;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[SerializeField]
		private uint fakeValue;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		private bool inited;

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x10F4EF8", Offset = "0x10F4EF8", VA = "0x10F4EF8")]
		private ObscuredUInt(uint value)
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x2C1A694", Offset = "0x2C1A694", VA = "0x2C1A694")]
		public static void SetNewCryptoKey(uint newKey)
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x2C1A700", Offset = "0x2C1A700", VA = "0x2C1A700")]
		public static uint Encrypt(uint value)
		{
			return default(uint);
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x2C1A7E8", Offset = "0x2C1A7E8", VA = "0x2C1A7E8")]
		public static uint Decrypt(uint value)
		{
			return default(uint);
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x2C1A768", Offset = "0x2C1A768", VA = "0x2C1A768")]
		public static uint Encrypt(uint value, uint key)
		{
			return default(uint);
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x2C1A850", Offset = "0x2C1A850", VA = "0x2C1A850")]
		public static uint Decrypt(uint value, uint key)
		{
			return default(uint);
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x10F4F00", Offset = "0x10F4F00", VA = "0x10F4F00")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x10F4F08", Offset = "0x10F4F08", VA = "0x10F4F08")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x10F4F10", Offset = "0x10F4F10", VA = "0x10F4F10")]
		public uint GetEncrypted()
		{
			return default(uint);
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x10F4F38", Offset = "0x10F4F38", VA = "0x10F4F38")]
		public void SetEncrypted(uint encrypted)
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x10F4F40", Offset = "0x10F4F40", VA = "0x10F4F40")]
		public uint GetDecrypted()
		{
			return default(uint);
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x10F4F48", Offset = "0x10F4F48", VA = "0x10F4F48")]
		private uint InternalDecrypt()
		{
			return default(uint);
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x2C1ABE4", Offset = "0x2C1ABE4", VA = "0x2C1ABE4")]
		public static implicit operator ObscuredUInt(uint value)
		{
			return default(ObscuredUInt);
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x2C1AC78", Offset = "0x2C1AC78", VA = "0x2C1AC78")]
		public static implicit operator uint(ObscuredUInt value)
		{
			return default(uint);
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x2C1AC9C", Offset = "0x2C1AC9C", VA = "0x2C1AC9C")]
		public static explicit operator ObscuredInt(ObscuredUInt value)
		{
			return default(ObscuredInt);
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x2C1AD1C", Offset = "0x2C1AD1C", VA = "0x2C1AD1C")]
		public static ObscuredUInt operator ++(ObscuredUInt input)
		{
			return default(ObscuredUInt);
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x2C1ADBC", Offset = "0x2C1ADBC", VA = "0x2C1ADBC")]
		public static ObscuredUInt operator --(ObscuredUInt input)
		{
			return default(ObscuredUInt);
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x10F4F50", Offset = "0x10F4F50", VA = "0x10F4F50", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x10F4F58", Offset = "0x10F4F58", VA = "0x10F4F58", Slot = "4")]
		public bool Equals(ObscuredUInt obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x10F4F60", Offset = "0x10F4F60", VA = "0x10F4F60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x10F4F90", Offset = "0x10F4F90", VA = "0x10F4F90")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x10F4FC8", Offset = "0x10F4FC8", VA = "0x10F4FC8", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x10F4FF8", Offset = "0x10F4FF8", VA = "0x10F4FF8")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x10F5030", Offset = "0x10F5030", VA = "0x10F5030", Slot = "5")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000017")]
	public struct ObscuredULong : IEquatable<ObscuredULong>, IFormattable
	{
		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static ulong cryptoKey;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private ulong currentCryptoKey;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[SerializeField]
		private ulong hiddenValue;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private ulong fakeValue;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool inited;

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x10F50CC", Offset = "0x10F50CC", VA = "0x10F50CC")]
		private ObscuredULong(ulong value)
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x2C1B178", Offset = "0x2C1B178", VA = "0x2C1B178")]
		public static void SetNewCryptoKey(ulong newKey)
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x2C1B1E4", Offset = "0x2C1B1E4", VA = "0x2C1B1E4")]
		public static ulong Encrypt(ulong value)
		{
			return default(ulong);
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x2C1B2CC", Offset = "0x2C1B2CC", VA = "0x2C1B2CC")]
		public static ulong Decrypt(ulong value)
		{
			return default(ulong);
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x2C1B24C", Offset = "0x2C1B24C", VA = "0x2C1B24C")]
		public static ulong Encrypt(ulong value, ulong key)
		{
			return default(ulong);
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x2C1B334", Offset = "0x2C1B334", VA = "0x2C1B334")]
		public static ulong Decrypt(ulong value, ulong key)
		{
			return default(ulong);
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x10F50D4", Offset = "0x10F50D4", VA = "0x10F50D4")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x10F50DC", Offset = "0x10F50DC", VA = "0x10F50DC")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x10F50E4", Offset = "0x10F50E4", VA = "0x10F50E4")]
		public ulong GetEncrypted()
		{
			return default(ulong);
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x10F510C", Offset = "0x10F510C", VA = "0x10F510C")]
		public void SetEncrypted(ulong encrypted)
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x10F5114", Offset = "0x10F5114", VA = "0x10F5114")]
		public ulong GetDecrypted()
		{
			return default(ulong);
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x10F511C", Offset = "0x10F511C", VA = "0x10F511C")]
		private ulong InternalDecrypt()
		{
			return default(ulong);
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x2C1B6C8", Offset = "0x2C1B6C8", VA = "0x2C1B6C8")]
		public static implicit operator ObscuredULong(ulong value)
		{
			return default(ObscuredULong);
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x2C1B770", Offset = "0x2C1B770", VA = "0x2C1B770")]
		public static implicit operator ulong(ObscuredULong value)
		{
			return default(ulong);
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x2C1B774", Offset = "0x2C1B774", VA = "0x2C1B774")]
		public static ObscuredULong operator ++(ObscuredULong input)
		{
			return default(ObscuredULong);
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x2C1B81C", Offset = "0x2C1B81C", VA = "0x2C1B81C")]
		public static ObscuredULong operator --(ObscuredULong input)
		{
			return default(ObscuredULong);
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x10F5124", Offset = "0x10F5124", VA = "0x10F5124", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x10F512C", Offset = "0x10F512C", VA = "0x10F512C", Slot = "4")]
		public bool Equals(ObscuredULong obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x10F515C", Offset = "0x10F515C", VA = "0x10F515C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x10F518C", Offset = "0x10F518C", VA = "0x10F518C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x10F51BC", Offset = "0x10F51BC", VA = "0x10F51BC")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x10F51F4", Offset = "0x10F51F4", VA = "0x10F51F4")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x10F522C", Offset = "0x10F522C", VA = "0x10F522C", Slot = "5")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000018")]
	public struct ObscuredUShort : IEquatable<ObscuredUShort>, IFormattable
	{
		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static ushort cryptoKey;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ushort currentCryptoKey;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		private ushort hiddenValue;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private ushort fakeValue;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
		private bool inited;

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x10F52C8", Offset = "0x10F52C8", VA = "0x10F52C8")]
		private ObscuredUShort(ushort value)
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x2C1BBF0", Offset = "0x2C1BBF0", VA = "0x2C1BBF0")]
		public static void SetNewCryptoKey(ushort newKey)
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x2C1BC5C", Offset = "0x2C1BC5C", VA = "0x2C1BC5C")]
		public static ushort EncryptDecrypt(ushort value)
		{
			return default(ushort);
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x2C1BCC4", Offset = "0x2C1BCC4", VA = "0x2C1BCC4")]
		public static ushort EncryptDecrypt(ushort value, ushort key)
		{
			return default(ushort);
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x10F52D0", Offset = "0x10F52D0", VA = "0x10F52D0")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x10F52D8", Offset = "0x10F52D8", VA = "0x10F52D8")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x10F52E0", Offset = "0x10F52E0", VA = "0x10F52E0")]
		public ushort GetEncrypted()
		{
			return default(ushort);
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x10F5308", Offset = "0x10F5308", VA = "0x10F5308")]
		public void SetEncrypted(ushort encrypted)
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x10F5310", Offset = "0x10F5310", VA = "0x10F5310")]
		public ushort GetDecrypted()
		{
			return default(ushort);
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x10F5318", Offset = "0x10F5318", VA = "0x10F5318")]
		private ushort InternalDecrypt()
		{
			return default(ushort);
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x2C1C064", Offset = "0x2C1C064", VA = "0x2C1C064")]
		public static implicit operator ObscuredUShort(ushort value)
		{
			return default(ObscuredUShort);
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x2C1C0F8", Offset = "0x2C1C0F8", VA = "0x2C1C0F8")]
		public static implicit operator ushort(ObscuredUShort value)
		{
			return default(ushort);
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x2C1C11C", Offset = "0x2C1C11C", VA = "0x2C1C11C")]
		public static ObscuredUShort operator ++(ObscuredUShort input)
		{
			return default(ObscuredUShort);
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x2C1C1BC", Offset = "0x2C1C1BC", VA = "0x2C1C1BC")]
		public static ObscuredUShort operator --(ObscuredUShort input)
		{
			return default(ObscuredUShort);
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x10F5320", Offset = "0x10F5320", VA = "0x10F5320", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x10F5328", Offset = "0x10F5328", VA = "0x10F5328", Slot = "4")]
		public bool Equals(ObscuredUShort obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x10F5330", Offset = "0x10F5330", VA = "0x10F5330", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x10F5360", Offset = "0x10F5360", VA = "0x10F5360")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x10F5398", Offset = "0x10F5398", VA = "0x10F5398", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x10F53C8", Offset = "0x10F53C8", VA = "0x10F53C8")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x10F5400", Offset = "0x10F5400", VA = "0x10F5400", Slot = "5")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000019")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xF6C6F4", Offset = "0xF6C6F4")]
	public struct ObscuredVector2
	{
		[Serializable]
		[Token(Token = "0x2000039")]
		public struct RawEncryptedVector2
		{
			[Token(Token = "0x400015E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int x;

			[Token(Token = "0x400015F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int y;
		}

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int cryptoKey;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly Vector2 initialFakeValue;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private int currentCryptoKey;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[SerializeField]
		private RawEncryptedVector2 hiddenValue;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		private Vector2 fakeValue;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private bool inited;

		[Token(Token = "0x17000009")]
		public float x
		{
			[Token(Token = "0x60001E0")]
			[Address(RVA = "0x10F54AC", Offset = "0x10F54AC", VA = "0x10F54AC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001E1")]
			[Address(RVA = "0x10F54B4", Offset = "0x10F54B4", VA = "0x10F54B4")]
			set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		public float y
		{
			[Token(Token = "0x60001E2")]
			[Address(RVA = "0x10F54BC", Offset = "0x10F54BC", VA = "0x10F54BC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001E3")]
			[Address(RVA = "0x10F54C4", Offset = "0x10F54C4", VA = "0x10F54C4")]
			set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		public float Item
		{
			[Token(Token = "0x60001E4")]
			[Address(RVA = "0x10F54CC", Offset = "0x10F54CC", VA = "0x10F54CC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001E5")]
			[Address(RVA = "0x10F54D4", Offset = "0x10F54D4", VA = "0x10F54D4")]
			set
			{
			}
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x10F549C", Offset = "0x10F549C", VA = "0x10F549C")]
		private ObscuredVector2(RawEncryptedVector2 value)
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x10F54A4", Offset = "0x10F54A4", VA = "0x10F54A4")]
		public ObscuredVector2(float x, float y)
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x2C1CC78", Offset = "0x2C1CC78", VA = "0x2C1CC78")]
		public static void SetNewCryptoKey(int newKey)
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x2C1CCE4", Offset = "0x2C1CCE4", VA = "0x2C1CCE4")]
		public static RawEncryptedVector2 Encrypt(Vector2 value)
		{
			return default(RawEncryptedVector2);
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x2C1CD5C", Offset = "0x2C1CD5C", VA = "0x2C1CD5C")]
		public static RawEncryptedVector2 Encrypt(Vector2 value, int key)
		{
			return default(RawEncryptedVector2);
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x2C1C620", Offset = "0x2C1C620", VA = "0x2C1C620")]
		public static RawEncryptedVector2 Encrypt(float x, float y, int key)
		{
			return default(RawEncryptedVector2);
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x2C1CDD8", Offset = "0x2C1CDD8", VA = "0x2C1CDD8")]
		public static Vector2 Decrypt(RawEncryptedVector2 value)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x2C1CE40", Offset = "0x2C1CE40", VA = "0x2C1CE40")]
		public static Vector2 Decrypt(RawEncryptedVector2 value, int key)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x10F54DC", Offset = "0x10F54DC", VA = "0x10F54DC")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x10F54E4", Offset = "0x10F54E4", VA = "0x10F54E4")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x10F54EC", Offset = "0x10F54EC", VA = "0x10F54EC")]
		public RawEncryptedVector2 GetEncrypted()
		{
			return default(RawEncryptedVector2);
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x10F5514", Offset = "0x10F5514", VA = "0x10F5514")]
		public void SetEncrypted(RawEncryptedVector2 encrypted)
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x10F551C", Offset = "0x10F551C", VA = "0x10F551C")]
		public Vector2 GetDecrypted()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x10F5524", Offset = "0x10F5524", VA = "0x10F5524")]
		private Vector2 InternalDecrypt()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x10F552C", Offset = "0x10F552C", VA = "0x10F552C")]
		private bool CompareVectorsWithTolerance(Vector2 vector1, Vector2 vector2)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x10F5530", Offset = "0x10F5530", VA = "0x10F5530")]
		private float InternalDecryptField(int encrypted)
		{
			return default(float);
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x10F5538", Offset = "0x10F5538", VA = "0x10F5538")]
		private int InternalEncryptField(float encrypted)
		{
			return default(int);
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x2C1D3C0", Offset = "0x2C1D3C0", VA = "0x2C1D3C0")]
		public static implicit operator ObscuredVector2(Vector2 value)
		{
			return default(ObscuredVector2);
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x2C1D478", Offset = "0x2C1D478", VA = "0x2C1D478")]
		public static implicit operator Vector2(ObscuredVector2 value)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x2C1D47C", Offset = "0x2C1D47C", VA = "0x2C1D47C")]
		public static implicit operator Vector3(ObscuredVector2 value)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x10F553C", Offset = "0x10F553C", VA = "0x10F553C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x10F556C", Offset = "0x10F556C", VA = "0x10F556C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x10F559C", Offset = "0x10F559C", VA = "0x10F559C")]
		public string ToString(string format)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x200001A")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xF6C72C", Offset = "0xF6C72C")]
	public struct ObscuredVector3
	{
		[Serializable]
		[Token(Token = "0x200003A")]
		public struct RawEncryptedVector3
		{
			[Token(Token = "0x4000160")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int x;

			[Token(Token = "0x4000161")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int y;

			[Token(Token = "0x4000162")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int z;
		}

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int cryptoKey;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly Vector3 initialFakeValue;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private int currentCryptoKey;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[SerializeField]
		private RawEncryptedVector3 hiddenValue;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Vector3 fakeValue;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private bool inited;

		[Token(Token = "0x1700000C")]
		public float x
		{
			[Token(Token = "0x60001FE")]
			[Address(RVA = "0x10F565C", Offset = "0x10F565C", VA = "0x10F565C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001FF")]
			[Address(RVA = "0x10F5664", Offset = "0x10F5664", VA = "0x10F5664")]
			set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		public float y
		{
			[Token(Token = "0x6000200")]
			[Address(RVA = "0x10F566C", Offset = "0x10F566C", VA = "0x10F566C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000201")]
			[Address(RVA = "0x10F5674", Offset = "0x10F5674", VA = "0x10F5674")]
			set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		public float z
		{
			[Token(Token = "0x6000202")]
			[Address(RVA = "0x10F567C", Offset = "0x10F567C", VA = "0x10F567C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000203")]
			[Address(RVA = "0x10F5684", Offset = "0x10F5684", VA = "0x10F5684")]
			set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public float Item
		{
			[Token(Token = "0x6000204")]
			[Address(RVA = "0x10F568C", Offset = "0x10F568C", VA = "0x10F568C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000205")]
			[Address(RVA = "0x10F5694", Offset = "0x10F5694", VA = "0x10F5694")]
			set
			{
			}
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x10F5648", Offset = "0x10F5648", VA = "0x10F5648")]
		private ObscuredVector3(RawEncryptedVector3 encrypted)
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x10F5654", Offset = "0x10F5654", VA = "0x10F5654")]
		public ObscuredVector3(float x, float y, float z)
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x2C1DF6C", Offset = "0x2C1DF6C", VA = "0x2C1DF6C")]
		public static void SetNewCryptoKey(int newKey)
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x2C1DFD8", Offset = "0x2C1DFD8", VA = "0x2C1DFD8")]
		public static RawEncryptedVector3 Encrypt(Vector3 value)
		{
			return default(RawEncryptedVector3);
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x2C1E068", Offset = "0x2C1E068", VA = "0x2C1E068")]
		public static RawEncryptedVector3 Encrypt(Vector3 value, int key)
		{
			return default(RawEncryptedVector3);
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x2C1D72C", Offset = "0x2C1D72C", VA = "0x2C1D72C")]
		public static RawEncryptedVector3 Encrypt(float x, float y, float z, int key)
		{
			return default(RawEncryptedVector3);
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x2C1E0FC", Offset = "0x2C1E0FC", VA = "0x2C1E0FC")]
		public static Vector3 Decrypt(RawEncryptedVector3 value)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x2C1E174", Offset = "0x2C1E174", VA = "0x2C1E174")]
		public static Vector3 Decrypt(RawEncryptedVector3 value, int key)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x10F569C", Offset = "0x10F569C", VA = "0x10F569C")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x10F56A4", Offset = "0x10F56A4", VA = "0x10F56A4")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x10F56AC", Offset = "0x10F56AC", VA = "0x10F56AC")]
		public RawEncryptedVector3 GetEncrypted()
		{
			return default(RawEncryptedVector3);
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x10F56D8", Offset = "0x10F56D8", VA = "0x10F56D8")]
		public void SetEncrypted(RawEncryptedVector3 encrypted)
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x10F56E4", Offset = "0x10F56E4", VA = "0x10F56E4")]
		public Vector3 GetDecrypted()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x10F56EC", Offset = "0x10F56EC", VA = "0x10F56EC")]
		private Vector3 InternalDecrypt()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x10F56F4", Offset = "0x10F56F4", VA = "0x10F56F4")]
		private bool CompareVectorsWithTolerance(Vector3 vector1, Vector3 vector2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x10F56F8", Offset = "0x10F56F8", VA = "0x10F56F8")]
		private float InternalDecryptField(int encrypted)
		{
			return default(float);
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x10F5700", Offset = "0x10F5700", VA = "0x10F5700")]
		private int InternalEncryptField(float encrypted)
		{
			return default(int);
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x2C1E7B0", Offset = "0x2C1E7B0", VA = "0x2C1E7B0")]
		public static implicit operator ObscuredVector3(Vector3 value)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x2C1E888", Offset = "0x2C1E888", VA = "0x2C1E888")]
		public static implicit operator Vector3(ObscuredVector3 value)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x2C1E88C", Offset = "0x2C1E88C", VA = "0x2C1E88C")]
		public static ObscuredVector3 operator +(ObscuredVector3 a, ObscuredVector3 b)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x2C1E998", Offset = "0x2C1E998", VA = "0x2C1E998")]
		public static ObscuredVector3 operator +(Vector3 a, ObscuredVector3 b)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x2C1EA98", Offset = "0x2C1EA98", VA = "0x2C1EA98")]
		public static ObscuredVector3 operator +(ObscuredVector3 a, Vector3 b)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x2C1EB98", Offset = "0x2C1EB98", VA = "0x2C1EB98")]
		public static ObscuredVector3 operator -(ObscuredVector3 a, ObscuredVector3 b)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x2C1ECA4", Offset = "0x2C1ECA4", VA = "0x2C1ECA4")]
		public static ObscuredVector3 operator -(Vector3 a, ObscuredVector3 b)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x2C1EDA4", Offset = "0x2C1EDA4", VA = "0x2C1EDA4")]
		public static ObscuredVector3 operator -(ObscuredVector3 a, Vector3 b)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x2C1EEA4", Offset = "0x2C1EEA4", VA = "0x2C1EEA4")]
		public static ObscuredVector3 operator -(ObscuredVector3 a)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x2C1EF84", Offset = "0x2C1EF84", VA = "0x2C1EF84")]
		public static ObscuredVector3 operator *(ObscuredVector3 a, float d)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x2C1F06C", Offset = "0x2C1F06C", VA = "0x2C1F06C")]
		public static ObscuredVector3 operator *(float d, ObscuredVector3 a)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x2C1F154", Offset = "0x2C1F154", VA = "0x2C1F154")]
		public static ObscuredVector3 operator /(ObscuredVector3 a, float d)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x2C1F23C", Offset = "0x2C1F23C", VA = "0x2C1F23C")]
		public static bool operator ==(ObscuredVector3 lhs, ObscuredVector3 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x2C1F304", Offset = "0x2C1F304", VA = "0x2C1F304")]
		public static bool operator ==(Vector3 lhs, ObscuredVector3 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x2C1F3B8", Offset = "0x2C1F3B8", VA = "0x2C1F3B8")]
		public static bool operator ==(ObscuredVector3 lhs, Vector3 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x2C1F46C", Offset = "0x2C1F46C", VA = "0x2C1F46C")]
		public static bool operator !=(ObscuredVector3 lhs, ObscuredVector3 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x2C1F534", Offset = "0x2C1F534", VA = "0x2C1F534")]
		public static bool operator !=(Vector3 lhs, ObscuredVector3 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x2C1F5E8", Offset = "0x2C1F5E8", VA = "0x2C1F5E8")]
		public static bool operator !=(ObscuredVector3 lhs, Vector3 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x10F5704", Offset = "0x10F5704", VA = "0x10F5704", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x10F570C", Offset = "0x10F570C", VA = "0x10F570C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x10F5714", Offset = "0x10F5714", VA = "0x10F5714", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x10F571C", Offset = "0x10F571C", VA = "0x10F571C")]
		public string ToString(string format)
		{
			return null;
		}
	}
}
namespace CodeStage.AntiCheat.Detectors
{
	[Token(Token = "0x200001B")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xF6C764", Offset = "0xF6C764")]
	public abstract class ActDetectorBase : MonoBehaviour
	{
		[Token(Token = "0x4000078")]
		protected const string CONTAINER_NAME = "Anti-Cheat Toolkit Detectors";

		[Token(Token = "0x4000079")]
		protected const string MENU_PATH = "Code Stage/Anti-Cheat Toolkit/";

		[Token(Token = "0x400007A")]
		protected const string GAME_OBJECT_MENU_PATH = "GameObject/Create Other/Code Stage/Anti-Cheat Toolkit/";

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected static GameObject detectorsContainer;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF6CE3C", Offset = "0xF6CE3C")]
		public bool autoStart;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF6CE74", Offset = "0xF6CE74")]
		public bool keepAlive;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF6CEAC", Offset = "0xF6CEAC")]
		public bool autoDispose;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected UnityEvent detectionEvent;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected UnityAction detectionAction;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected bool detectionEventHasListener;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		protected bool isRunning;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		protected bool started;

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x1DD4FB4", Offset = "0x1DD4FB4", VA = "0x1DD4FB4")]
		private void Start()
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x1DD50C8", Offset = "0x1DD50C8", VA = "0x1DD50C8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x1DD5128", Offset = "0x1DD5128", VA = "0x1DD5128")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x1DD5140", Offset = "0x1DD5140", VA = "0x1DD5140")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x1DD514C", Offset = "0x1DD514C", VA = "0x1DD514C", Slot = "4")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x1DD5270", Offset = "0x1DD5270", VA = "0x1DD5270", Slot = "5")]
		protected virtual bool Init(ActDetectorBase instance, string detectorName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x1DD5410", Offset = "0x1DD5410", VA = "0x1DD5410", Slot = "6")]
		protected virtual void DisposeInternal()
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x1DD5478", Offset = "0x1DD5478", VA = "0x1DD5478", Slot = "7")]
		protected virtual bool DetectorHasAdditionalCallbacks()
		{
			return default(bool);
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x1DD5480", Offset = "0x1DD5480", VA = "0x1DD5480", Slot = "8")]
		internal virtual void OnCheatingDetected()
		{
		}

		[Token(Token = "0x6000235")]
		protected abstract void StartDetectionAutomatically();

		[Token(Token = "0x6000236")]
		protected abstract void StopDetectionInternal();

		[Token(Token = "0x6000237")]
		protected abstract void PauseDetector();

		[Token(Token = "0x6000238")]
		protected abstract void ResumeDetector();

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x1DD54E4", Offset = "0x1DD54E4", VA = "0x1DD54E4")]
		protected ActDetectorBase()
		{
		}
	}
	[Token(Token = "0x200001C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xF6C79C", Offset = "0xF6C79C")]
	public class InjectionDetector : ActDetectorBase
	{
		[Token(Token = "0x200003B")]
		private class AllowedAssembly
		{
			[Token(Token = "0x4000163")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public readonly string name;

			[Token(Token = "0x4000164")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public readonly int[] hashes;

			[Token(Token = "0x600030E")]
			[Address(RVA = "0x1DD6BAC", Offset = "0x1DD6BAC", VA = "0x1DD6BAC")]
			public AllowedAssembly(string name, int[] hashes)
			{
			}
		}

		[Token(Token = "0x4000084")]
		internal const string COMPONENT_NAME = "Injection Detector";

		[Token(Token = "0x4000085")]
		internal const string FINAL_LOG_PREFIX = "[ACTk] Injection Detector: ";

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected UnityAction<string> detectionActionWithArgument;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int instancesInScene;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool signaturesAreNotGenuine;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AllowedAssembly[] allowedAssemblies;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string[] hexTable;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF6CF04", Offset = "0xF6CF04")]
		private static InjectionDetector <Instance>k__BackingField;

		[Token(Token = "0x17000010")]
		public static InjectionDetector Instance
		{
			[Token(Token = "0x600023F")]
			[Address(RVA = "0x1DD5C7C", Offset = "0x1DD5C7C", VA = "0x1DD5C7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF6D458", Offset = "0xF6D458")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000240")]
			[Address(RVA = "0x1DD5CCC", Offset = "0x1DD5CCC", VA = "0x1DD5CCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF6D468", Offset = "0xF6D468")]
			private set
			{
			}
		}

		[Token(Token = "0x17000011")]
		private static InjectionDetector GetOrCreateInstance
		{
			[Token(Token = "0x6000241")]
			[Address(RVA = "0x1DD5894", Offset = "0x1DD5894", VA = "0x1DD5894")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x1DD54FC", Offset = "0x1DD54FC", VA = "0x1DD54FC")]
		public static void StartDetection()
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x1DD5864", Offset = "0x1DD5864", VA = "0x1DD5864")]
		public static void StartDetection(UnityAction callback)
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x1DD5A54", Offset = "0x1DD5A54", VA = "0x1DD5A54")]
		public static void StartDetection(UnityAction<string> callback)
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x1DD5A84", Offset = "0x1DD5A84", VA = "0x1DD5A84")]
		public static void StopDetection()
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x1DD5B80", Offset = "0x1DD5B80", VA = "0x1DD5B80")]
		public static void Dispose()
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x1DD5D24", Offset = "0x1DD5D24", VA = "0x1DD5D24")]
		private InjectionDetector()
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x1DD5D3C", Offset = "0x1DD5D3C", VA = "0x1DD5D3C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x1DD5E64", Offset = "0x1DD5E64", VA = "0x1DD5E64", Slot = "4")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x1DD5EC8", Offset = "0x1DD5EC8", VA = "0x1DD5EC8")]
		private void OnLevelWasLoadedNew(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x1DD5ECC", Offset = "0x1DD5ECC", VA = "0x1DD5ECC")]
		private void OnLevelLoadedCallback()
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x1DD5628", Offset = "0x1DD5628", VA = "0x1DD5628")]
		private void StartDetectionInternal(UnityAction callback, UnityAction<string> callbackWithArgument)
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x1DD6630", Offset = "0x1DD6630", VA = "0x1DD6630", Slot = "9")]
		protected override void StartDetectionAutomatically()
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x1DD663C", Offset = "0x1DD663C", VA = "0x1DD663C", Slot = "11")]
		protected override void PauseDetector()
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x1DD66D8", Offset = "0x1DD66D8", VA = "0x1DD66D8", Slot = "12")]
		protected override void ResumeDetector()
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x1DD67A0", Offset = "0x1DD67A0", VA = "0x1DD67A0", Slot = "10")]
		protected override void StopDetectionInternal()
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x1DD6868", Offset = "0x1DD6868", VA = "0x1DD6868", Slot = "6")]
		protected override void DisposeInternal()
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x1DD64A8", Offset = "0x1DD64A8", VA = "0x1DD64A8")]
		private void OnCheatingDetected(string cause)
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x1DD6968", Offset = "0x1DD6968", VA = "0x1DD6968")]
		private void OnNewAssemblyLoaded(object sender, AssemblyLoadEventArgs args)
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x1DD6514", Offset = "0x1DD6514", VA = "0x1DD6514")]
		private bool FindInjectionInCurrentAssemblies(out string cause)
		{
			return default(bool);
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x1DD69C4", Offset = "0x1DD69C4", VA = "0x1DD69C4")]
		private bool AssemblyAllowed(Assembly ass)
		{
			return default(bool);
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x1DD5FC0", Offset = "0x1DD5FC0", VA = "0x1DD5FC0")]
		private void LoadAndParseAllowedAssemblies()
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x1DD6AD0", Offset = "0x1DD6AD0", VA = "0x1DD6AD0")]
		private int GetAssemblyHash(Assembly ass)
		{
			return default(int);
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x1DD6BFC", Offset = "0x1DD6BFC", VA = "0x1DD6BFC")]
		private string PublicKeyTokenToString(byte[] bytes)
		{
			return null;
		}
	}
	[Token(Token = "0x200001D")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xF6C7D4", Offset = "0xF6C7D4")]
	public class ObscuredCheatingDetector : ActDetectorBase
	{
		[Token(Token = "0x400008C")]
		internal const string COMPONENT_NAME = "Obscured Cheating Detector";

		[Token(Token = "0x400008D")]
		internal const string FINAL_LOG_PREFIX = "[ACTk] Obscured Cheating Detector: ";

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int instancesInScene;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF6CF14", Offset = "0xF6CF14")]
		public float floatEpsilon;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF6CF4C", Offset = "0xF6CF4C")]
		public float vector2Epsilon;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF6CF84", Offset = "0xF6CF84")]
		public float vector3Epsilon;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF6CFBC", Offset = "0xF6CFBC")]
		public float quaternionEpsilon;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF6CFF4", Offset = "0xF6CFF4")]
		private static ObscuredCheatingDetector <Instance>k__BackingField;

		[Token(Token = "0x17000012")]
		public static ObscuredCheatingDetector Instance
		{
			[Token(Token = "0x6000258")]
			[Address(RVA = "0x1DD7350", Offset = "0x1DD7350", VA = "0x1DD7350")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF6D478", Offset = "0xF6D478")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000259")]
			[Address(RVA = "0x1DD73A0", Offset = "0x1DD73A0", VA = "0x1DD73A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF6D488", Offset = "0xF6D488")]
			private set
			{
			}
		}

		[Token(Token = "0x17000013")]
		private static ObscuredCheatingDetector GetOrCreateInstance
		{
			[Token(Token = "0x600025A")]
			[Address(RVA = "0x1DD6F98", Offset = "0x1DD6F98", VA = "0x1DD6F98")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000014")]
		internal static bool IsRunning
		{
			[Token(Token = "0x600025B")]
			[Address(RVA = "0x1DD73F8", Offset = "0x1DD73F8", VA = "0x1DD73F8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x1DD6CB8", Offset = "0x1DD6CB8", VA = "0x1DD6CB8")]
		public static void StartDetection()
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x1DD6F6C", Offset = "0x1DD6F6C", VA = "0x1DD6F6C")]
		public static void StartDetection(UnityAction callback)
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x1DD7158", Offset = "0x1DD7158", VA = "0x1DD7158")]
		public static void StopDetection()
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x1DD7254", Offset = "0x1DD7254", VA = "0x1DD7254")]
		public static void Dispose()
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x1DD7460", Offset = "0x1DD7460", VA = "0x1DD7460")]
		private ObscuredCheatingDetector()
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x1DD7484", Offset = "0x1DD7484", VA = "0x1DD7484")]
		private void Awake()
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x1DD75AC", Offset = "0x1DD75AC", VA = "0x1DD75AC", Slot = "4")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x1DD7610", Offset = "0x1DD7610", VA = "0x1DD7610")]
		private void OnLevelWasLoadedNew(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x1DD7614", Offset = "0x1DD7614", VA = "0x1DD7614")]
		private void OnLevelLoadedCallback()
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x1DD6DE0", Offset = "0x1DD6DE0", VA = "0x1DD6DE0")]
		private void StartDetectionInternal(UnityAction callback)
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x1DD7708", Offset = "0x1DD7708", VA = "0x1DD7708", Slot = "9")]
		protected override void StartDetectionAutomatically()
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x1DD7710", Offset = "0x1DD7710", VA = "0x1DD7710", Slot = "11")]
		protected override void PauseDetector()
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x1DD7718", Offset = "0x1DD7718", VA = "0x1DD7718", Slot = "12")]
		protected override void ResumeDetector()
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x1DD7734", Offset = "0x1DD7734", VA = "0x1DD7734", Slot = "10")]
		protected override void StopDetectionInternal()
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x1DD776C", Offset = "0x1DD776C", VA = "0x1DD776C", Slot = "6")]
		protected override void DisposeInternal()
		{
		}
	}
	[Token(Token = "0x200001E")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xF6C80C", Offset = "0xF6C80C")]
	public class SpeedHackDetector : ActDetectorBase
	{
		[Token(Token = "0x4000094")]
		internal const string COMPONENT_NAME = "Speed Hack Detector";

		[Token(Token = "0x4000095")]
		internal const string FINAL_LOG_PREFIX = "[ACTk] Speed Hack Detector: ";

		[Token(Token = "0x4000096")]
		private const long TICKS_PER_SECOND = 10000000L;

		[Token(Token = "0x4000097")]
		private const int THRESHOLD = 5000000;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int instancesInScene;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF6D004", Offset = "0xF6D004")]
		public float interval;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF6D03C", Offset = "0xF6D03C")]
		public byte maxFalsePositives;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF6D074", Offset = "0xF6D074")]
		public int coolDown;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private byte currentFalsePositives;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int currentCooldownShots;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private long ticksOnStart;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private long vulnerableTicksOnStart;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private long prevTicks;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private long prevIntervalTicks;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF6D0AC", Offset = "0xF6D0AC")]
		private static SpeedHackDetector <Instance>k__BackingField;

		[Token(Token = "0x17000015")]
		public static SpeedHackDetector Instance
		{
			[Token(Token = "0x600026E")]
			[Address(RVA = "0x1DD8038", Offset = "0x1DD8038", VA = "0x1DD8038")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF6D498", Offset = "0xF6D498")]
			get
			{
				return null;
			}
			[Token(Token = "0x600026F")]
			[Address(RVA = "0x1DD8088", Offset = "0x1DD8088", VA = "0x1DD8088")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF6D4A8", Offset = "0xF6D4A8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000016")]
		private static SpeedHackDetector GetOrCreateInstance
		{
			[Token(Token = "0x6000270")]
			[Address(RVA = "0x1DD7BA4", Offset = "0x1DD7BA4", VA = "0x1DD7BA4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x1DD786C", Offset = "0x1DD786C", VA = "0x1DD786C")]
		public static void StartDetection()
		{
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x1DD7B74", Offset = "0x1DD7B74", VA = "0x1DD7B74")]
		public static void StartDetection(UnityAction callback)
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x1DD7D64", Offset = "0x1DD7D64", VA = "0x1DD7D64")]
		public static void StartDetection(UnityAction callback, float interval)
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x1DD7DA4", Offset = "0x1DD7DA4", VA = "0x1DD7DA4")]
		public static void StartDetection(UnityAction callback, float interval, byte maxFalsePositives)
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x1DD7DEC", Offset = "0x1DD7DEC", VA = "0x1DD7DEC")]
		public static void StartDetection(UnityAction callback, float interval, byte maxFalsePositives, int coolDown)
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x1DD7E40", Offset = "0x1DD7E40", VA = "0x1DD7E40")]
		public static void StopDetection()
		{
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x1DD7F3C", Offset = "0x1DD7F3C", VA = "0x1DD7F3C")]
		public static void Dispose()
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x1DD80E0", Offset = "0x1DD80E0", VA = "0x1DD80E0")]
		private SpeedHackDetector()
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x1DD8110", Offset = "0x1DD8110", VA = "0x1DD8110")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x1DD8238", Offset = "0x1DD8238", VA = "0x1DD8238", Slot = "4")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x1DD829C", Offset = "0x1DD829C", VA = "0x1DD829C")]
		private void OnLevelWasLoadedNew(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x1DD82A0", Offset = "0x1DD82A0", VA = "0x1DD82A0")]
		private void OnLevelLoadedCallback()
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x1DD8394", Offset = "0x1DD8394", VA = "0x1DD8394")]
		private void OnApplicationPause(bool pause)
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x1DD8444", Offset = "0x1DD8444", VA = "0x1DD8444")]
		private void Update()
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x1DD79A0", Offset = "0x1DD79A0", VA = "0x1DD79A0")]
		private void StartDetectionInternal(UnityAction callback, float checkInterval, byte falsePositives, int shotsTillCooldown)
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x1DD85F4", Offset = "0x1DD85F4", VA = "0x1DD85F4", Slot = "9")]
		protected override void StartDetectionAutomatically()
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x1DD8608", Offset = "0x1DD8608", VA = "0x1DD8608", Slot = "11")]
		protected override void PauseDetector()
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x1DD8610", Offset = "0x1DD8610", VA = "0x1DD8610", Slot = "12")]
		protected override void ResumeDetector()
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x1DD862C", Offset = "0x1DD862C", VA = "0x1DD862C", Slot = "10")]
		protected override void StopDetectionInternal()
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x1DD8664", Offset = "0x1DD8664", VA = "0x1DD8664", Slot = "6")]
		protected override void DisposeInternal()
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x1DD83A0", Offset = "0x1DD83A0", VA = "0x1DD83A0")]
		private void ResetStartTicks()
		{
		}
	}
	[Token(Token = "0x200001F")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xF6C844", Offset = "0xF6C844")]
	public class WallHackDetector : ActDetectorBase
	{
		[Token(Token = "0x200003C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF6C9AC", Offset = "0xF6C9AC")]
		private sealed class <InitDetector>d__78 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000165")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000166")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000167")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WallHackDetector <>4__this;

			[Token(Token = "0x17000025")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000312")]
				[Address(RVA = "0x1DDC2F0", Offset = "0x1DDC2F0", VA = "0x1DDC2F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000026")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000314")]
				[Address(RVA = "0x1DDC358", Offset = "0x1DDC358", VA = "0x1DDC358", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600030F")]
			[Address(RVA = "0x1DDB6AC", Offset = "0x1DDB6AC", VA = "0x1DDB6AC")]
			[DebuggerHidden]
			public <InitDetector>d__78(int <>1__state)
			{
			}

			[Token(Token = "0x6000310")]
			[Address(RVA = "0x1DDC238", Offset = "0x1DDC238", VA = "0x1DDC238", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000311")]
			[Address(RVA = "0x1DDC23C", Offset = "0x1DDC23C", VA = "0x1DDC23C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000313")]
			[Address(RVA = "0x1DDC2F8", Offset = "0x1DDC2F8", VA = "0x1DDC2F8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200003D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF6C9BC", Offset = "0xF6C9BC")]
		private sealed class <CaptureFrame>d__83 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000168")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000169")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400016A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WallHackDetector <>4__this;

			[Token(Token = "0x400016B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private RenderTexture <previousActive>5__2;

			[Token(Token = "0x17000027")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000318")]
				[Address(RVA = "0x1DDC1C8", Offset = "0x1DDC1C8", VA = "0x1DDC1C8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000028")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600031A")]
				[Address(RVA = "0x1DDC230", Offset = "0x1DDC230", VA = "0x1DDC230", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000315")]
			[Address(RVA = "0x1DDBC3C", Offset = "0x1DDBC3C", VA = "0x1DDBC3C")]
			[DebuggerHidden]
			public <CaptureFrame>d__83(int <>1__state)
			{
			}

			[Token(Token = "0x6000316")]
			[Address(RVA = "0x1DDBDB4", Offset = "0x1DDBDB4", VA = "0x1DDBDB4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000317")]
			[Address(RVA = "0x1DDBDB8", Offset = "0x1DDBDB8", VA = "0x1DDBDB8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000319")]
			[Address(RVA = "0x1DDC1D0", Offset = "0x1DDC1D0", VA = "0x1DDC1D0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000A3")]
		internal const string COMPONENT_NAME = "WallHack Detector";

		[Token(Token = "0x40000A4")]
		internal const string FINAL_LOG_PREFIX = "[ACTk] WallHack Detector: ";

		[Token(Token = "0x40000A5")]
		private const string SERVICE_CONTAINER_NAME = "[WH Detector Service]";

		[Token(Token = "0x40000A6")]
		private const string WIREFRAME_SHADER_NAME = "Hidden/ACTk/WallHackTexture";

		[Token(Token = "0x40000A7")]
		private const int SHADER_TEXTURE_SIZE = 4;

		[Token(Token = "0x40000A8")]
		private const int RENDER_TEXTURE_SIZE = 4;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private readonly Vector3 rigidPlayerVelocity;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int instancesInScene;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly WaitForEndOfFrame waitForEndOfFrame;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF6D0BC", Offset = "0xF6D0BC")]
		private bool checkRigidbody;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF6D108", Offset = "0xF6D108")]
		private bool checkController;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF6D154", Offset = "0xF6D154")]
		private bool checkWireframe;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4B")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF6D1A0", Offset = "0xF6D1A0")]
		private bool checkRaycast;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF6D1EC", Offset = "0xF6D1EC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xF6D1EC", Offset = "0xF6D1EC")]
		public int wireframeDelay;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF6D244", Offset = "0xF6D244")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xF6D244", Offset = "0xF6D244")]
		public int raycastDelay;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF6D29C", Offset = "0xF6D29C")]
		public Vector3 spawnPosition;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF6D2D4", Offset = "0xF6D2D4")]
		public byte maxFalsePositives;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject serviceContainer;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private GameObject solidWall;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private GameObject thinWall;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Camera wfCamera;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private MeshRenderer foregroundRenderer;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private MeshRenderer backgroundRenderer;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Color wfColor1;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Color wfColor2;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Shader wfShader;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Material wfMaterial;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Texture2D shaderTexture;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Texture2D targetTexture;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private RenderTexture renderTexture;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int whLayer;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private int raycastMask;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Rigidbody rigidPlayer;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private CharacterController charControllerPlayer;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private float charControllerVelocity;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		private byte rigidbodyDetections;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFD")]
		private byte controllerDetections;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFE")]
		private byte wireframeDetections;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFF")]
		private byte raycastDetections;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private bool wireframeDetected;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF6D30C", Offset = "0xF6D30C")]
		private static WallHackDetector <Instance>k__BackingField;

		[Token(Token = "0x17000017")]
		public bool CheckRigidbody
		{
			[Token(Token = "0x600027F")]
			[Address(RVA = "0x1DD8764", Offset = "0x1DD8764", VA = "0x1DD8764")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000280")]
			[Address(RVA = "0x1DD876C", Offset = "0x1DD876C", VA = "0x1DD876C")]
			set
			{
			}
		}

		[Token(Token = "0x17000018")]
		public bool CheckController
		{
			[Token(Token = "0x6000281")]
			[Address(RVA = "0x1DD9D34", Offset = "0x1DD9D34", VA = "0x1DD9D34")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000282")]
			[Address(RVA = "0x1DD9D3C", Offset = "0x1DD9D3C", VA = "0x1DD9D3C")]
			set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public bool CheckWireframe
		{
			[Token(Token = "0x6000283")]
			[Address(RVA = "0x1DD9FD4", Offset = "0x1DD9FD4", VA = "0x1DD9FD4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000284")]
			[Address(RVA = "0x1DD9FDC", Offset = "0x1DD9FDC", VA = "0x1DD9FDC")]
			set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		public bool CheckRaycast
		{
			[Token(Token = "0x6000285")]
			[Address(RVA = "0x1DDA170", Offset = "0x1DDA170", VA = "0x1DDA170")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000286")]
			[Address(RVA = "0x1DDA178", Offset = "0x1DDA178", VA = "0x1DDA178")]
			set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public static WallHackDetector Instance
		{
			[Token(Token = "0x600028D")]
			[Address(RVA = "0x1DDAAB0", Offset = "0x1DDAAB0", VA = "0x1DDAAB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF6D4B8", Offset = "0xF6D4B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600028E")]
			[Address(RVA = "0x1DDAB00", Offset = "0x1DDAB00", VA = "0x1DDAB00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF6D4C8", Offset = "0xF6D4C8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		private static WallHackDetector GetOrCreateInstance
		{
			[Token(Token = "0x600028F")]
			[Address(RVA = "0x1DDA644", Offset = "0x1DDA644", VA = "0x1DDA644")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x1DDA2F8", Offset = "0x1DDA2F8", VA = "0x1DDA2F8")]
		public static void StartDetection()
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x1DDA610", Offset = "0x1DDA610", VA = "0x1DDA610")]
		public static void StartDetection(UnityAction callback)
		{
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x1DDA804", Offset = "0x1DDA804", VA = "0x1DDA804")]
		public static void StartDetection(UnityAction callback, Vector3 spawnPosition)
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x1DDA85C", Offset = "0x1DDA85C", VA = "0x1DDA85C")]
		public static void StartDetection(UnityAction callback, Vector3 spawnPosition, byte maxFalsePositives)
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x1DDA8B8", Offset = "0x1DDA8B8", VA = "0x1DDA8B8")]
		public static void StopDetection()
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x1DDA9B4", Offset = "0x1DDA9B4", VA = "0x1DDA9B4")]
		public static void Dispose()
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x1DDAB58", Offset = "0x1DDAB58", VA = "0x1DDAB58")]
		private WallHackDetector()
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x1DDAC5C", Offset = "0x1DDAC5C", VA = "0x1DDAC5C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x1DDAD84", Offset = "0x1DDAD84", VA = "0x1DDAD84", Slot = "4")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x1DDAF2C", Offset = "0x1DDAF2C", VA = "0x1DDAF2C")]
		private void OnLevelWasLoadedNew(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x1DDAF30", Offset = "0x1DDAF30", VA = "0x1DDAF30")]
		private void OnLevelLoadedCallback()
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x1DDB024", Offset = "0x1DDB024", VA = "0x1DDB024")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x1DDB164", Offset = "0x1DDB164", VA = "0x1DDB164")]
		private void Update()
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x1DDA42C", Offset = "0x1DDA42C", VA = "0x1DDA42C")]
		private void StartDetectionInternal(UnityAction callback, Vector3 servicePosition, byte falsePositivesInRow)
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x1DDB320", Offset = "0x1DDB320", VA = "0x1DDB320", Slot = "9")]
		protected override void StartDetectionAutomatically()
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x1DDB334", Offset = "0x1DDB334", VA = "0x1DDB334", Slot = "11")]
		protected override void PauseDetector()
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x1DDB378", Offset = "0x1DDB378", VA = "0x1DDB378", Slot = "12")]
		protected override void ResumeDetector()
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x1DDB3F4", Offset = "0x1DDB3F4", VA = "0x1DDB3F4", Slot = "10")]
		protected override void StopDetectionInternal()
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x1DDB438", Offset = "0x1DDB438", VA = "0x1DDB438", Slot = "6")]
		protected override void DisposeInternal()
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x1DD881C", Offset = "0x1DD881C", VA = "0x1DD881C")]
		private void UpdateServiceContainer()
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x1DDB2A4", Offset = "0x1DDB2A4", VA = "0x1DDB2A4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xF6D4D8", Offset = "0xF6D4D8")]
		private IEnumerator InitDetector()
		{
			return null;
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x1DD9A8C", Offset = "0x1DD9A8C", VA = "0x1DD9A8C")]
		private void StartRigidModule()
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x1DD9DEC", Offset = "0x1DD9DEC", VA = "0x1DD9DEC")]
		private void StartControllerModule()
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x1DDA08C", Offset = "0x1DDA08C", VA = "0x1DDA08C")]
		private void StartWireframeModule()
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x1DDBB4C", Offset = "0x1DDBB4C", VA = "0x1DDBB4C")]
		private void ShootWireframeModule()
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x1DDBBC0", Offset = "0x1DDBBC0", VA = "0x1DDBBC0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xF6D53C", Offset = "0xF6D53C")]
		private IEnumerator CaptureFrame()
		{
			return null;
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x1DDA228", Offset = "0x1DDA228", VA = "0x1DDA228")]
		private void StartRaycastModule()
		{
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x1DDBC68", Offset = "0x1DDBC68", VA = "0x1DDBC68")]
		private void ShootRaycastModule()
		{
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x1DD9C6C", Offset = "0x1DD9C6C", VA = "0x1DD9C6C")]
		private void StopRigidModule()
		{
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x1DD9F48", Offset = "0x1DD9F48", VA = "0x1DD9F48")]
		private void StopControllerModule()
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x1DDA11C", Offset = "0x1DDA11C", VA = "0x1DDA11C")]
		private void StopWireframeModule()
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x1DDA2A4", Offset = "0x1DDA2A4", VA = "0x1DDA2A4")]
		private void StopRaycastModule()
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x1DDB7B0", Offset = "0x1DDB7B0", VA = "0x1DDB7B0")]
		private void InitRigidModule()
		{
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x1DDB9F4", Offset = "0x1DDB9F4", VA = "0x1DDB9F4")]
		private void InitControllerModule()
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x1DDB6D8", Offset = "0x1DDB6D8", VA = "0x1DDB6D8")]
		private void UninitRigidModule()
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x1DDB91C", Offset = "0x1DDB91C", VA = "0x1DDB91C")]
		private void UninitControllerModule()
		{
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x1DDB108", Offset = "0x1DDB108", VA = "0x1DDB108")]
		private bool Detect()
		{
			return default(bool);
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x1DDB538", Offset = "0x1DDB538", VA = "0x1DDB538")]
		private static Color32 GenerateColor()
		{
			return default(Color32);
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x1DDB5B4", Offset = "0x1DDB5B4", VA = "0x1DDB5B4")]
		private static bool ColorsSimilar(Color32 c1, Color32 c2, int tolerance)
		{
			return default(bool);
		}
	}
}
namespace CodeStage.AntiCheat.Common
{
	[Serializable]
	[Token(Token = "0x2000020")]
	public struct ACTkByte16
	{
		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public byte b1;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public byte b2;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		public byte b3;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
		public byte b4;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public byte b5;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5")]
		public byte b6;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
		public byte b7;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7")]
		public byte b8;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public byte b9;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
		public byte b10;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
		public byte b11;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB")]
		public byte b12;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public byte b13;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
		public byte b14;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
		public byte b15;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
		public byte b16;
	}
	[Serializable]
	[Token(Token = "0x2000021")]
	public struct ACTkByte4
	{
		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public byte b1;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public byte b2;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		public byte b3;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
		public byte b4;
	}
	[Serializable]
	[Token(Token = "0x2000022")]
	public struct ACTkByte8
	{
		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public byte b1;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public byte b2;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		public byte b3;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
		public byte b4;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public byte b5;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5")]
		public byte b6;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
		public byte b7;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7")]
		public byte b8;
	}
	[Token(Token = "0x2000023")]
	internal class Constants
	{
		[Token(Token = "0x40000E8")]
		internal const string LOG_PREFIX = "[ACTk] ";

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x1DD4FAC", Offset = "0x1DD4FAC", VA = "0x1DD4FAC")]
		public Constants()
		{
		}
	}
}
namespace CodeStage.AntiCheat.Examples
{
	[Token(Token = "0x2000024")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xF6C87C", Offset = "0xF6C87C")]
	public class ActRotatorExample : MonoBehaviour
	{
		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xF6D31C", Offset = "0xF6D31C")]
		public float speed;

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x1DDC360", Offset = "0x1DDC360", VA = "0x1DDC360")]
		private void Update()
		{
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x1DDC3B8", Offset = "0x1DDC3B8", VA = "0x1DDC3B8")]
		public ActRotatorExample()
		{
		}
	}
	[Token(Token = "0x2000025")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xF6C8B4", Offset = "0xF6C8B4")]
	public class ActTesterGui : MonoBehaviour
	{
		[Token(Token = "0x200003E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF6C9CC", Offset = "0xF6C9CC")]
		private sealed class <>c__DisplayClass63_0
		{
			[Token(Token = "0x400016C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string types;

			[Token(Token = "0x600031B")]
			[Address(RVA = "0x1DE6674", Offset = "0x1DE6674", VA = "0x1DE6674")]
			public <>c__DisplayClass63_0()
			{
			}

			[Token(Token = "0x600031C")]
			[Address(RVA = "0x1DE850C", Offset = "0x1DE850C", VA = "0x1DE850C")]
			internal void <GetAllSimpleObscuredTypes>b__2(Type t)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200003F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF6C9DC", Offset = "0xF6C9DC")]
		private sealed class <>c
		{
			[Token(Token = "0x400016D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400016E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<Assembly, bool> <>9__63_0;

			[Token(Token = "0x400016F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<Type, bool> <>9__63_1;

			[Token(Token = "0x600031E")]
			[Address(RVA = "0x1DE83DC", Offset = "0x1DE83DC", VA = "0x1DE83DC")]
			public <>c()
			{
			}

			[Token(Token = "0x600031F")]
			[Address(RVA = "0x1DE83E4", Offset = "0x1DE83E4", VA = "0x1DE83E4")]
			internal bool <GetAllSimpleObscuredTypes>b__63_0(Assembly assembly)
			{
				return default(bool);
			}

			[Token(Token = "0x6000320")]
			[Address(RVA = "0x1DE8458", Offset = "0x1DE8458", VA = "0x1DE8458")]
			internal bool <GetAllSimpleObscuredTypes>b__63_1(Type t)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40000EA")]
		private const string RED_COLOR = "#FF4040";

		[Token(Token = "0x40000EB")]
		private const string GREEN_COLOR = "#02C85F";

		[Token(Token = "0x40000EC")]
		private const string PREFS_STRING = "name";

		[Token(Token = "0x40000ED")]
		private const string PREFS_INT = "money";

		[Token(Token = "0x40000EE")]
		private const string PREFS_FLOAT = "lifeBar";

		[Token(Token = "0x40000EF")]
		private const string PREFS_BOOL = "gameComplete";

		[Token(Token = "0x40000F0")]
		private const string PREFS_UINT = "demoUint";

		[Token(Token = "0x40000F1")]
		private const string PREFS_LONG = "demoLong";

		[Token(Token = "0x40000F2")]
		private const string PREFS_DOUBLE = "demoDouble";

		[Token(Token = "0x40000F3")]
		private const string PREFS_VECTOR2 = "demoVector2";

		[Token(Token = "0x40000F4")]
		private const string PREFS_VECTOR3 = "demoVector3";

		[Token(Token = "0x40000F5")]
		private const string PREFS_QUATERNION = "demoQuaternion";

		[Token(Token = "0x40000F6")]
		private const string PREFS_RECT = "demoRect";

		[Token(Token = "0x40000F7")]
		private const string PREFS_COLOR = "demoColor";

		[Token(Token = "0x40000F8")]
		private const string PREFS_BYTE_ARRAY = "demoByteArray";

		[Token(Token = "0x40000F9")]
		private const string API_URL_LOCK_TO_DEVICE = "http://j.mp/1gxg1tf";

		[Token(Token = "0x40000FA")]
		private const string API_URL_PRESERVE_PREFS = "http://j.mp/1iBK5pz";

		[Token(Token = "0x40000FB")]
		private const string API_URL_EMERGENCY_MODE = "http://j.mp/1FRAL5L";

		[Token(Token = "0x40000FC")]
		private const string API_URL_READ_FOREIGN = "http://j.mp/1LCdpDa";

		[Token(Token = "0x40000FD")]
		private const string API_URL_UNOBSCURED_MODE = "http://j.mp/1KVrpxi";

		[Token(Token = "0x40000FE")]
		private const string API_URL_PLAYER_PREFS = "http://docs.unity3d.com/ScriptReference/PlayerPrefs.html";

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xF6D338", Offset = "0xF6D338")]
		public string regularString;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int regularInt;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float regularFloat;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 regularVector3;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xF6D370", Offset = "0xF6D370")]
		public ObscuredString obscuredString;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ObscuredInt obscuredInt;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public ObscuredFloat obscuredFloat;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public ObscuredVector3 obscuredVector3;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public ObscuredBool obscuredBool;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public ObscuredLong obscuredLong;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public ObscuredDouble obscuredDouble;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public ObscuredVector2 obscuredVector2;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xF6D3A8", Offset = "0xF6D3A8")]
		public string prefsEncryptionKey;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private readonly string[] tabs;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private int currentTab;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private string allSimpleObscuredTypes;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private string regularPrefs;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private string obscuredPrefs;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private int savesLock;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private bool savesAlterationDetected;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12D")]
		private bool foreignSavesDetected;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12E")]
		private bool injectionDetected;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12F")]
		private bool speedHackDetected;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private bool obscuredTypeCheatDetected;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x131")]
		private bool wallHackCheatDetected;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private readonly StringBuilder logBuilder;

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x1DDC3C8", Offset = "0x1DDC3C8", VA = "0x1DDC3C8")]
		public void OnSpeedHackDetected()
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x1DDC440", Offset = "0x1DDC440", VA = "0x1DDC440")]
		public void OnInjectionDetected()
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x1DDC4B8", Offset = "0x1DDC4B8", VA = "0x1DDC4B8")]
		public void OnInjectionDetectedWithCause(string cause)
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x1DDC554", Offset = "0x1DDC554", VA = "0x1DDC554")]
		public void OnObscuredTypeCheatingDetected()
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x1DDC5CC", Offset = "0x1DDC5CC", VA = "0x1DDC5CC")]
		public void OnWallHackDetected()
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x1DDC644", Offset = "0x1DDC644", VA = "0x1DDC644")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x1DDC718", Offset = "0x1DDC718", VA = "0x1DDC718")]
		private void Awake()
		{
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x1DDC848", Offset = "0x1DDC848", VA = "0x1DDC848")]
		private void Start()
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x1DDD6C0", Offset = "0x1DDD6C0", VA = "0x1DDD6C0")]
		private void RandomizeObscuredVars()
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x1DDC8CC", Offset = "0x1DDC8CC", VA = "0x1DDC8CC")]
		private void ObscuredStringExample()
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x1DDCA78", Offset = "0x1DDCA78", VA = "0x1DDCA78")]
		private void ObscuredIntExample()
		{
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x1DDCF30", Offset = "0x1DDCF30", VA = "0x1DDCF30")]
		private void ObscuredFloatExample()
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x1DDD294", Offset = "0x1DDD294", VA = "0x1DDD294")]
		private void ObscuredVector3Example()
		{
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x1DDDD18", Offset = "0x1DDDD18", VA = "0x1DDDD18")]
		private void SavesAlterationDetected()
		{
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x1DDDD24", Offset = "0x1DDDD24", VA = "0x1DDDD24")]
		private void ForeignSavesDetected()
		{
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x1DDDD30", Offset = "0x1DDDD30", VA = "0x1DDDD30")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x1DE489C", Offset = "0x1DE489C", VA = "0x1DE489C")]
		private string GetAllSimpleObscuredTypes()
		{
			return null;
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x1DE4C88", Offset = "0x1DE4C88", VA = "0x1DE4C88")]
		private string GetAllObscuredPrefsDataTypes()
		{
			return null;
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x1DE4CFC", Offset = "0x1DE4CFC", VA = "0x1DE4CFC")]
		private void LoadRegularPrefs()
		{
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x1DE4F7C", Offset = "0x1DE4F7C", VA = "0x1DE4F7C")]
		private void SaveRegularPrefs()
		{
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x1DE5010", Offset = "0x1DE5010", VA = "0x1DE5010")]
		private void DeleteRegularPrefs()
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x1DE508C", Offset = "0x1DE508C", VA = "0x1DE508C")]
		private void LoadObscuredPrefs()
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x1DE61A4", Offset = "0x1DE61A4", VA = "0x1DE61A4")]
		private void SaveObscuredPrefs()
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x1DE6438", Offset = "0x1DE6438", VA = "0x1DE6438")]
		private void DeleteObscuredPrefs()
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x1DE6568", Offset = "0x1DE6568", VA = "0x1DE6568")]
		private void PlaceUrlButton(string url)
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x1DE7CAC", Offset = "0x1DE7CAC", VA = "0x1DE7CAC")]
		private void PlaceUrlButton(string url, int width)
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x1DE6570", Offset = "0x1DE6570", VA = "0x1DE6570")]
		private void PlaceUrlButton(string url, string buttonName, int width)
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x1DE7D0C", Offset = "0x1DE7D0C", VA = "0x1DE7D0C")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x1DE7D20", Offset = "0x1DE7D20", VA = "0x1DE7D20")]
		public ActTesterGui()
		{
		}
	}
	[Token(Token = "0x2000026")]
	internal class HorizontalLayout : IDisposable
	{
		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x1DE4870", Offset = "0x1DE4870", VA = "0x1DE4870")]
		public HorizontalLayout(params GUILayoutOption[] options)
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x1DE85C0", Offset = "0x1DE85C0", VA = "0x1DE85C0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x2000027")]
	internal class VerticalLayout : IDisposable
	{
		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x1DE4CD0", Offset = "0x1DE4CD0", VA = "0x1DE4CD0")]
		public VerticalLayout(params GUILayoutOption[] options)
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x1DE4B9C", Offset = "0x1DE4B9C", VA = "0x1DE4B9C")]
		public VerticalLayout(GUIStyle style)
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x1DEAF60", Offset = "0x1DEAF60", VA = "0x1DEAF60", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x2000028")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xF6C8EC", Offset = "0xF6C8EC")]
	public class ObscuredPerformanceTests : MonoBehaviour
	{
		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool boolTest;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int boolIterations;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool byteTest;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int byteIterations;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool shortTest;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int shortIterations;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool ushortTest;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int ushortIterations;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool intTest;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int intIterations;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool uintTest;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public int uintIterations;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool longTest;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public int longIterations;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool floatTest;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public int floatIterations;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool doubleTest;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public int doubleIterations;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool stringTest;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int stringIterations;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool vector3Test;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public int vector3Iterations;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public bool prefsTest;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public int prefsIterations;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private readonly StringBuilder logBuilder;

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x1DE85C8", Offset = "0x1DE85C8", VA = "0x1DE85C8")]
		private void Start()
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x1DE8620", Offset = "0x1DE8620", VA = "0x1DE8620")]
		private void StartTests()
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x1DE8780", Offset = "0x1DE8780", VA = "0x1DE8780")]
		private void TestBool()
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x1DE8A68", Offset = "0x1DE8A68", VA = "0x1DE8A68")]
		private void TestByte()
		{
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x1DE8D3C", Offset = "0x1DE8D3C", VA = "0x1DE8D3C")]
		private void TestShort()
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x1DE900C", Offset = "0x1DE900C", VA = "0x1DE900C")]
		private void TestUShort()
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x1DE9EB4", Offset = "0x1DE9EB4", VA = "0x1DE9EB4")]
		private void TestDouble()
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x1DE9B90", Offset = "0x1DE9B90", VA = "0x1DE9B90")]
		private void TestFloat()
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x1DE92DC", Offset = "0x1DE92DC", VA = "0x1DE92DC")]
		private void TestInt()
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x1DE98A0", Offset = "0x1DE98A0", VA = "0x1DE98A0")]
		private void TestLong()
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x1DEA1E8", Offset = "0x1DEA1E8", VA = "0x1DEA1E8")]
		private void TestString()
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x1DE95B8", Offset = "0x1DE95B8", VA = "0x1DE95B8")]
		private void TestUInt()
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x1DEA548", Offset = "0x1DEA548", VA = "0x1DEA548")]
		private void TestVector3()
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x1DEA988", Offset = "0x1DEA988", VA = "0x1DEA988")]
		private void TestPrefs()
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x1DEAE74", Offset = "0x1DEAE74", VA = "0x1DEAE74")]
		public ObscuredPerformanceTests()
		{
		}
	}
}
namespace Beebyte.Obfuscator
{
	[Token(Token = "0x2000029")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0xF6C924", Offset = "0xF6C924")]
	public class DoNotFakeAttribute : Attribute
	{
		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x1DD4F40", Offset = "0x1DD4F40", VA = "0x1DD4F40")]
		public DoNotFakeAttribute()
		{
		}
	}
	[Token(Token = "0x200002A")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0xF6C938", Offset = "0xF6C938")]
	public class ObfuscateLiteralsAttribute : Attribute
	{
		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x1DD4F48", Offset = "0x1DD4F48", VA = "0x1DD4F48")]
		public ObfuscateLiteralsAttribute()
		{
		}
	}
	[Token(Token = "0x200002B")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0xF6C94C", Offset = "0xF6C94C")]
	public class RenameAttribute : Attribute
	{
		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly string target;

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x1DD4F50", Offset = "0x1DD4F50", VA = "0x1DD4F50")]
		private RenameAttribute()
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x1DD4F58", Offset = "0x1DD4F58", VA = "0x1DD4F58")]
		public RenameAttribute(string target)
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x1DD4F8C", Offset = "0x1DD4F8C", VA = "0x1DD4F8C")]
		public string GetTarget()
		{
			return null;
		}
	}
	[Token(Token = "0x200002C")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0xF6C960", Offset = "0xF6C960")]
	public class ReplaceLiteralsWithNameAttribute : Attribute
	{
		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x1DD4F94", Offset = "0x1DD4F94", VA = "0x1DD4F94")]
		public ReplaceLiteralsWithNameAttribute()
		{
		}
	}
	[Token(Token = "0x200002D")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0xF6C974", Offset = "0xF6C974")]
	public class SkipAttribute : Attribute
	{
		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x1DD4F9C", Offset = "0x1DD4F9C", VA = "0x1DD4F9C")]
		public SkipAttribute()
		{
		}
	}
	[Token(Token = "0x200002E")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0xF6C988", Offset = "0xF6C988")]
	public class SkipRenameAttribute : Attribute
	{
		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x1DD4FA4", Offset = "0x1DD4FA4", VA = "0x1DD4FA4")]
		public SkipRenameAttribute()
		{
		}
	}
}
