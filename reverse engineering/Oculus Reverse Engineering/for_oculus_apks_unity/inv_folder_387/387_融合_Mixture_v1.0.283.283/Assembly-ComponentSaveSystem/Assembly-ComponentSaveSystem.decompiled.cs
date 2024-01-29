using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;
using Lowscope.Saving;
using Lowscope.Saving.Components;
using Lowscope.Saving.Core;
using Lowscope.Saving.Data;
using Lowscope.Saving.Encryption;
using Lowscope.Saving.Enums;
using SQLite4Unity3d;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class SaveCollectable : MonoBehaviour, ISaveable
{
	[Serializable]
	[Token(Token = "0x2000003")]
	public struct CollectableData
	{
		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool isUnlocked;
	}

	[Token(Token = "0x2000004")]
	public enum CollectableType
	{
		[Token(Token = "0x4000008")]
		Seed,
		[Token(Token = "0x4000009")]
		Inscription
	}

	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public CollectableType collectableType;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool countWhenDisabled;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public SaveCollectable[] otherCollectibles;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public CollectableData collectableData;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public UnityEvent onUnlocked;

	[Token(Token = "0x17000001")]
	public bool IsUnlocked
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x10085A0", Offset = "0x10085A0", VA = "0x10085A0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x10085A8", Offset = "0x10085A8", VA = "0x10085A8")]
		set
		{
		}
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x10085B4", Offset = "0x10085B4", VA = "0x10085B4", Slot = "5")]
	public void OnLoad(string data)
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x1008630", Offset = "0x1008630", VA = "0x1008630", Slot = "4")]
	public string OnSave()
	{
		return null;
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x1008694", Offset = "0x1008694", VA = "0x1008694", Slot = "6")]
	public bool OnSaveCondition()
	{
		return default(bool);
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x100869C", Offset = "0x100869C", VA = "0x100869C")]
	public SaveCollectable()
	{
	}
}
[Serializable]
[Token(Token = "0x2000005")]
public class UnityEventInt : UnityEvent<int>
{
	[Token(Token = "0x6000007")]
	[Address(RVA = "0x10086AC", Offset = "0x10086AC", VA = "0x10086AC")]
	public UnityEventInt()
	{
	}
}
[Token(Token = "0x2000006")]
public class ExampleThrottledPrefabLoading : MonoBehaviour, ISaveable
{
	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool hasSpawnedPrefabs;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private int spawnPrefabs;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject testSaveable;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject initialMessage;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject doneMessage;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Slider progressSlider;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Text progressText;

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x10086F4", Offset = "0x10086F4", VA = "0x10086F4")]
	private GameObject OnLoadResource(string resourceIndex)
	{
		return null;
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x10086FC", Offset = "0x10086FC", VA = "0x10086FC")]
	private void Awake()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x1009044", Offset = "0x1009044", VA = "0x1009044")]
	private void Update()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x10095EC", Offset = "0x10095EC", VA = "0x10095EC")]
	private void OnSpawnInstanceProgress(Scene scene, int activeSpawn, int totalSpawn, float percentage)
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x1009728", Offset = "0x1009728", VA = "0x1009728")]
	private void OnStartSpawningInstances(Scene scene, int amount)
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x10097C8", Offset = "0x10097C8", VA = "0x10097C8")]
	private void OnFinishSpawningInstances(Scene obj)
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x1009838", Offset = "0x1009838", VA = "0x1009838")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x1009A28", Offset = "0x1009A28", VA = "0x1009A28", Slot = "4")]
	public string OnSave()
	{
		return null;
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x1009A38", Offset = "0x1009A38", VA = "0x1009A38", Slot = "5")]
	public void OnLoad(string data)
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x1009AA8", Offset = "0x1009AA8", VA = "0x1009AA8", Slot = "6")]
	public bool OnSaveCondition()
	{
		return default(bool);
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x1009AB8", Offset = "0x1009AB8", VA = "0x1009AB8")]
	public ExampleThrottledPrefabLoading()
	{
	}
}
namespace SQLite4Unity3d
{
	[Token(Token = "0x2000007")]
	public class SQLiteException : Exception
	{
		[Token(Token = "0x17000002")]
		public SQLite3.Result Result
		{
			[Token(Token = "0x6000013")]
			[Address(RVA = "0x1009AC8", Offset = "0x1009AC8", VA = "0x1009AC8")]
			[CompilerGenerated]
			get
			{
				return default(SQLite3.Result);
			}
			[Token(Token = "0x6000014")]
			[Address(RVA = "0x1009AD0", Offset = "0x1009AD0", VA = "0x1009AD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x1009AD8", Offset = "0x1009AD8", VA = "0x1009AD8")]
		protected SQLiteException(SQLite3.Result r, string message)
		{
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x1009B4C", Offset = "0x1009B4C", VA = "0x1009B4C")]
		public static SQLiteException New(SQLite3.Result r, string message)
		{
			return null;
		}
	}
	[Token(Token = "0x2000008")]
	public class NotNullConstraintViolationException : SQLiteException
	{
		[Token(Token = "0x17000003")]
		public IEnumerable<TableMapping.Column> Columns
		{
			[Token(Token = "0x6000017")]
			[Address(RVA = "0x1009BBC", Offset = "0x1009BBC", VA = "0x1009BBC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000018")]
			[Address(RVA = "0x1009BC4", Offset = "0x1009BC4", VA = "0x1009BC4")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x1009BCC", Offset = "0x1009BCC", VA = "0x1009BCC")]
		protected NotNullConstraintViolationException(SQLite3.Result r, string message)
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x1009BD8", Offset = "0x1009BD8", VA = "0x1009BD8")]
		protected NotNullConstraintViolationException(SQLite3.Result r, string message, TableMapping mapping, object obj)
		{
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x1009D1C", Offset = "0x1009D1C", VA = "0x1009D1C")]
		public new static NotNullConstraintViolationException New(SQLite3.Result r, string message)
		{
			return null;
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x1009D94", Offset = "0x1009D94", VA = "0x1009D94")]
		public static NotNullConstraintViolationException New(SQLite3.Result r, string message, TableMapping mapping, object obj)
		{
			return null;
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x1009E1C", Offset = "0x1009E1C", VA = "0x1009E1C")]
		public static NotNullConstraintViolationException New(SQLiteException exception, TableMapping mapping, object obj)
		{
			return null;
		}
	}
	[Token(Token = "0x200000A")]
	[Flags]
	public enum SQLiteOpenFlags
	{
		[Token(Token = "0x4000015")]
		ReadOnly = 1,
		[Token(Token = "0x4000016")]
		ReadWrite = 2,
		[Token(Token = "0x4000017")]
		Create = 4,
		[Token(Token = "0x4000018")]
		NoMutex = 0x8000,
		[Token(Token = "0x4000019")]
		FullMutex = 0x10000,
		[Token(Token = "0x400001A")]
		SharedCache = 0x20000,
		[Token(Token = "0x400001B")]
		PrivateCache = 0x40000,
		[Token(Token = "0x400001C")]
		ProtectionComplete = 0x100000,
		[Token(Token = "0x400001D")]
		ProtectionCompleteUnlessOpen = 0x200000,
		[Token(Token = "0x400001E")]
		ProtectionCompleteUntilFirstUserAuthentication = 0x300000,
		[Token(Token = "0x400001F")]
		ProtectionNone = 0x400000
	}
	[Token(Token = "0x200000B")]
	[Flags]
	public enum CreateFlags
	{
		[Token(Token = "0x4000021")]
		None = 0,
		[Token(Token = "0x4000022")]
		ImplicitPK = 1,
		[Token(Token = "0x4000023")]
		ImplicitIndex = 2,
		[Token(Token = "0x4000024")]
		AllImplicit = 3,
		[Token(Token = "0x4000025")]
		AutoIncPK = 4
	}
	[Token(Token = "0x200000C")]
	public class SQLiteConnection : IDisposable
	{
		[Token(Token = "0x200000D")]
		public delegate void TraceHandler(string message);

		[Token(Token = "0x200000E")]
		public delegate void TimeExecutionHandler(TimeSpan executionTime, TimeSpan totalExecutionTime);

		[Token(Token = "0x200000F")]
		private struct IndexedColumn
		{
			[Token(Token = "0x4000038")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int Order;

			[Token(Token = "0x4000039")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string ColumnName;
		}

		[Token(Token = "0x2000010")]
		private struct IndexInfo
		{
			[Token(Token = "0x400003A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string IndexName;

			[Token(Token = "0x400003B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string TableName;

			[Token(Token = "0x400003C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool Unique;

			[Token(Token = "0x400003D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public List<IndexedColumn> Columns;
		}

		[Token(Token = "0x2000011")]
		public class ColumnInfo
		{
			[Token(Token = "0x1700000D")]
			[Column("name")]
			public string Name
			{
				[Token(Token = "0x600007B")]
				[Address(RVA = "0x100FDB4", Offset = "0x100FDB4", VA = "0x100FDB4")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600007C")]
				[Address(RVA = "0x100FDBC", Offset = "0x100FDBC", VA = "0x100FDBC")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x1700000E")]
			public int notnull
			{
				[Token(Token = "0x600007D")]
				[Address(RVA = "0x100FDC4", Offset = "0x100FDC4", VA = "0x100FDC4")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Token(Token = "0x600007E")]
				[Address(RVA = "0x100FDCC", Offset = "0x100FDCC", VA = "0x100FDCC")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x600007F")]
			[Address(RVA = "0x100FDD4", Offset = "0x100FDD4", VA = "0x100FDD4", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6000080")]
			[Address(RVA = "0x100A888", Offset = "0x100A888", VA = "0x100A888")]
			public ColumnInfo()
			{
			}
		}

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool _open;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TimeSpan _busyTimeout;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<string, TableMapping> _mappings;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Dictionary<string, TableMapping> _tables;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Stopwatch _sw;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TimeSpan _elapsed;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int _transactionDepth;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private System.Random _rand;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static readonly IntPtr NullHandle;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Dictionary<string, object> syncObjects;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static bool _preserveDuringLinkMagic;

		[Token(Token = "0x17000004")]
		public IntPtr Handle
		{
			[Token(Token = "0x6000020")]
			[Address(RVA = "0x1009F28", Offset = "0x1009F28", VA = "0x1009F28")]
			[CompilerGenerated]
			get
			{
				return default(IntPtr);
			}
			[Token(Token = "0x6000021")]
			[Address(RVA = "0x1009F30", Offset = "0x1009F30", VA = "0x1009F30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public string DatabasePath
		{
			[Token(Token = "0x6000022")]
			[Address(RVA = "0x1009F38", Offset = "0x1009F38", VA = "0x1009F38")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000023")]
			[Address(RVA = "0x1009F40", Offset = "0x1009F40", VA = "0x1009F40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public bool Trace
		{
			[Token(Token = "0x6000024")]
			[Address(RVA = "0x1009F48", Offset = "0x1009F48", VA = "0x1009F48")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000025")]
			[Address(RVA = "0x1009F50", Offset = "0x1009F50", VA = "0x1009F50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public bool TimeExecution
		{
			[Token(Token = "0x6000026")]
			[Address(RVA = "0x1009F5C", Offset = "0x1009F5C", VA = "0x1009F5C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000027")]
			[Address(RVA = "0x1009F64", Offset = "0x1009F64", VA = "0x1009F64")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000008")]
		public bool StoreDateTimeAsTicks
		{
			[Token(Token = "0x600002E")]
			[Address(RVA = "0x100A218", Offset = "0x100A218", VA = "0x100A218")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600002F")]
			[Address(RVA = "0x100A220", Offset = "0x100A220", VA = "0x100A220")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000009")]
		public object SyncObject
		{
			[Token(Token = "0x6000034")]
			[Address(RVA = "0x100A890", Offset = "0x100A890", VA = "0x100A890")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000A")]
		public TimeSpan BusyTimeout
		{
			[Token(Token = "0x6000037")]
			[Address(RVA = "0x100AA50", Offset = "0x100AA50", VA = "0x100AA50")]
			get
			{
				return default(TimeSpan);
			}
			[Token(Token = "0x6000038")]
			[Address(RVA = "0x100A6C4", Offset = "0x100A6C4", VA = "0x100A6C4")]
			set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		public IEnumerable<TableMapping> TableMappings
		{
			[Token(Token = "0x6000039")]
			[Address(RVA = "0x100AADC", Offset = "0x100AADC", VA = "0x100AADC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000C")]
		public bool IsInTransaction
		{
			[Token(Token = "0x6000054")]
			[Address(RVA = "0x100D294", Offset = "0x100D294", VA = "0x100D294")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x14000001")]
		public event TraceHandler TraceEvent
		{
			[Token(Token = "0x6000028")]
			[Address(RVA = "0x1009F70", Offset = "0x1009F70", VA = "0x1009F70")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000029")]
			[Address(RVA = "0x100A00C", Offset = "0x100A00C", VA = "0x100A00C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000002")]
		public event TimeExecutionHandler TimeExecutionEvent
		{
			[Token(Token = "0x600002B")]
			[Address(RVA = "0x100A0C4", Offset = "0x100A0C4", VA = "0x100A0C4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600002C")]
			[Address(RVA = "0x100A160", Offset = "0x100A160", VA = "0x100A160")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x100A0A8", Offset = "0x100A0A8", VA = "0x100A0A8")]
		internal void InvokeTrace(string message)
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x100A1FC", Offset = "0x100A1FC", VA = "0x100A1FC")]
		internal void InvokeTimeExecution(TimeSpan executionTime, TimeSpan totalExecutionTime)
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x100A22C", Offset = "0x100A22C", VA = "0x100A22C")]
		public SQLiteConnection(string databasePath, bool storeDateTimeAsTicks = false)
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x100A238", Offset = "0x100A238", VA = "0x100A238")]
		public SQLiteConnection(string databasePath, SQLiteOpenFlags openFlags, bool storeDateTimeAsTicks = false)
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x100A780", Offset = "0x100A780", VA = "0x100A780")]
		static SQLiteConnection()
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x100A470", Offset = "0x100A470", VA = "0x100A470")]
		private void mayCreateSyncObject(string databasePath)
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x100A910", Offset = "0x100A910", VA = "0x100A910")]
		public void EnableLoadExtension(int onoff)
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x100A574", Offset = "0x100A574", VA = "0x100A574")]
		private static byte[] GetNullTerminatedUtf8(string s)
		{
			return null;
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x100AB88", Offset = "0x100AB88", VA = "0x100AB88")]
		public TableMapping GetMapping(Type type, CreateFlags createFlags = CreateFlags.None)
		{
			return null;
		}

		[Token(Token = "0x600003B")]
		public TableMapping GetMapping<T>()
		{
			return null;
		}

		[Token(Token = "0x600003C")]
		public int DropTable<T>()
		{
			return default(int);
		}

		[Token(Token = "0x600003D")]
		public int CreateTable<T>(CreateFlags createFlags = CreateFlags.None)
		{
			return default(int);
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x100B138", Offset = "0x100B138", VA = "0x100B138")]
		public int CreateTable(Type ty, CreateFlags createFlags = CreateFlags.None)
		{
			return default(int);
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x100C44C", Offset = "0x100C44C", VA = "0x100C44C")]
		public int CreateIndex(string indexName, string tableName, string[] columnNames, bool unique = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x100C698", Offset = "0x100C698", VA = "0x100C698")]
		public int CreateIndex(string indexName, string tableName, string columnName, bool unique = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x100C764", Offset = "0x100C764", VA = "0x100C764")]
		public int CreateIndex(string tableName, string columnName, bool unique = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x100C7E8", Offset = "0x100C7E8", VA = "0x100C7E8")]
		public int CreateIndex(string tableName, string[] columnNames, bool unique = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000043")]
		public void CreateIndex<T>(Expression<Func<T, object>> property, bool unique = false)
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x100C87C", Offset = "0x100C87C", VA = "0x100C87C")]
		public List<ColumnInfo> GetTableInfo(string tableName)
		{
			return null;
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x100C004", Offset = "0x100C004", VA = "0x100C004")]
		private void MigrateTable(TableMapping map)
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x100CC6C", Offset = "0x100CC6C", VA = "0x100CC6C", Slot = "5")]
		protected virtual SQLiteCommand NewCommand()
		{
			return null;
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x100CD94", Offset = "0x100CD94", VA = "0x100CD94")]
		public SQLiteCommand CreateCommand(string cmdText, params object[] ps)
		{
			return null;
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x100BE8C", Offset = "0x100BE8C", VA = "0x100BE8C")]
		public int Execute(string query, params object[] args)
		{
			return default(int);
		}

		[Token(Token = "0x6000049")]
		public T ExecuteScalar<T>(string query, params object[] args)
		{
			return (T)null;
		}

		[Token(Token = "0x600004A")]
		public List<T> Query<T>(string query, params object[] args) where T : new()
		{
			return null;
		}

		[Token(Token = "0x600004B")]
		public IEnumerable<T> DeferredQuery<T>(string query, params object[] args) where T : new()
		{
			return null;
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x100D0C8", Offset = "0x100D0C8", VA = "0x100D0C8")]
		public List<object> Query(TableMapping map, string query, params object[] args)
		{
			return null;
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x100D13C", Offset = "0x100D13C", VA = "0x100D13C")]
		public IEnumerable<object> DeferredQuery(TableMapping map, string query, params object[] args)
		{
			return null;
		}

		[Token(Token = "0x600004E")]
		public TableQuery<T> Table<T>() where T : new()
		{
			return null;
		}

		[Token(Token = "0x600004F")]
		public T Get<T>(object pk) where T : new()
		{
			return (T)null;
		}

		[Token(Token = "0x6000050")]
		public T Get<T>(Expression<Func<T, bool>> predicate) where T : new()
		{
			return (T)null;
		}

		[Token(Token = "0x6000051")]
		public T Find<T>(object pk) where T : new()
		{
			return (T)null;
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x100D1B0", Offset = "0x100D1B0", VA = "0x100D1B0")]
		public object Find(object pk, TableMapping map)
		{
			return null;
		}

		[Token(Token = "0x6000053")]
		public T Find<T>(Expression<Func<T, bool>> predicate) where T : new()
		{
			return (T)null;
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x100D2A4", Offset = "0x100D2A4", VA = "0x100D2A4")]
		public void BeginTransaction()
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x100D62C", Offset = "0x100D62C", VA = "0x100D62C")]
		public string SaveTransactionPoint()
		{
			return null;
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x100D890", Offset = "0x100D890", VA = "0x100D890")]
		public void Rollback()
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x100D89C", Offset = "0x100D89C", VA = "0x100D89C")]
		public void RollbackTo(string savepoint)
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x100D4A0", Offset = "0x100D4A0", VA = "0x100D4A0")]
		private void RollbackTo(string savepoint, bool noThrow)
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x100DA30", Offset = "0x100DA30", VA = "0x100DA30")]
		public void Release(string savepoint)
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x100D8A4", Offset = "0x100D8A4", VA = "0x100D8A4")]
		private void DoSavePointExecute(string savepoint, string cmd)
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x100DA88", Offset = "0x100DA88", VA = "0x100DA88")]
		public void Commit()
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x100DB44", Offset = "0x100DB44", VA = "0x100DB44")]
		public void RunInTransaction(Action action)
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x100DD38", Offset = "0x100DD38", VA = "0x100DD38")]
		public void RunInDatabaseLock(Action action)
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x100DE78", Offset = "0x100DE78", VA = "0x100DE78")]
		public int InsertAll(IEnumerable objects)
		{
			return default(int);
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x100DF68", Offset = "0x100DF68", VA = "0x100DF68")]
		public int InsertAll(IEnumerable objects, string extra)
		{
			return default(int);
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x100E06C", Offset = "0x100E06C", VA = "0x100E06C")]
		public int InsertAll(IEnumerable objects, Type objType)
		{
			return default(int);
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x100E170", Offset = "0x100E170", VA = "0x100E170")]
		public int Insert(object obj)
		{
			return default(int);
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x100E5B8", Offset = "0x100E5B8", VA = "0x100E5B8")]
		public int InsertOrReplace(object obj)
		{
			return default(int);
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x100E62C", Offset = "0x100E62C", VA = "0x100E62C")]
		public int Insert(object obj, Type objType)
		{
			return default(int);
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x100E68C", Offset = "0x100E68C", VA = "0x100E68C")]
		public int InsertOrReplace(object obj, Type objType)
		{
			return default(int);
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x100E6EC", Offset = "0x100E6EC", VA = "0x100E6EC")]
		public int Insert(object obj, string extra)
		{
			return default(int);
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x100E1E4", Offset = "0x100E1E4", VA = "0x100E1E4")]
		public int Insert(object obj, string extra, Type objType)
		{
			return default(int);
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x100EDF8", Offset = "0x100EDF8", VA = "0x100EDF8")]
		public int Update(object obj)
		{
			return default(int);
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x100EE38", Offset = "0x100EE38", VA = "0x100EE38")]
		public int Update(object obj, Type objType)
		{
			return default(int);
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x100F3EC", Offset = "0x100F3EC", VA = "0x100F3EC")]
		public int UpdateAll(IEnumerable objects)
		{
			return default(int);
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x100F4DC", Offset = "0x100F4DC", VA = "0x100F4DC")]
		public int Delete(object objectToDelete)
		{
			return default(int);
		}

		[Token(Token = "0x600006C")]
		public int Delete<T>(object primaryKey)
		{
			return default(int);
		}

		[Token(Token = "0x600006D")]
		public int DeleteAll<T>()
		{
			return default(int);
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x100F670", Offset = "0x100F670", VA = "0x100F670", Slot = "1")]
		~SQLiteConnection()
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x100F710", Offset = "0x100F710", VA = "0x100F710", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x100F77C", Offset = "0x100F77C", VA = "0x100F77C", Slot = "6")]
		protected virtual void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x100F780", Offset = "0x100F780", VA = "0x100F780")]
		public void Close()
		{
		}
	}
	[Token(Token = "0x2000018")]
	internal class SQLiteConnectionString
	{
		[Token(Token = "0x1700000F")]
		public string ConnectionString
		{
			[Token(Token = "0x6000090")]
			[Address(RVA = "0x1010AF0", Offset = "0x1010AF0", VA = "0x1010AF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000091")]
			[Address(RVA = "0x1010AF8", Offset = "0x1010AF8", VA = "0x1010AF8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public string DatabasePath
		{
			[Token(Token = "0x6000092")]
			[Address(RVA = "0x1010B00", Offset = "0x1010B00", VA = "0x1010B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000093")]
			[Address(RVA = "0x1010B08", Offset = "0x1010B08", VA = "0x1010B08")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public bool StoreDateTimeAsTicks
		{
			[Token(Token = "0x6000094")]
			[Address(RVA = "0x1010B10", Offset = "0x1010B10", VA = "0x1010B10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000095")]
			[Address(RVA = "0x1010B18", Offset = "0x1010B18", VA = "0x1010B18")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x1010B24", Offset = "0x1010B24", VA = "0x1010B24")]
		public SQLiteConnectionString(string databasePath, bool storeDateTimeAsTicks)
		{
		}
	}
	[Token(Token = "0x2000019")]
	[AttributeUsage(AttributeTargets.Class)]
	public class TableAttribute : Attribute
	{
		[Token(Token = "0x17000012")]
		public string Name
		{
			[Token(Token = "0x6000097")]
			[Address(RVA = "0x1010B70", Offset = "0x1010B70", VA = "0x1010B70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000098")]
			[Address(RVA = "0x1010B78", Offset = "0x1010B78", VA = "0x1010B78")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x1010B80", Offset = "0x1010B80", VA = "0x1010B80")]
		public TableAttribute(string name)
		{
		}
	}
	[Token(Token = "0x200001A")]
	[AttributeUsage(AttributeTargets.Property)]
	public class ColumnAttribute : Attribute
	{
		[Token(Token = "0x17000013")]
		public string Name
		{
			[Token(Token = "0x600009A")]
			[Address(RVA = "0x1010BB0", Offset = "0x1010BB0", VA = "0x1010BB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600009B")]
			[Address(RVA = "0x1010BB8", Offset = "0x1010BB8", VA = "0x1010BB8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x1010BC0", Offset = "0x1010BC0", VA = "0x1010BC0")]
		public ColumnAttribute(string name)
		{
		}
	}
	[Token(Token = "0x200001B")]
	[AttributeUsage(AttributeTargets.Property)]
	public class PrimaryKeyAttribute : Attribute
	{
		[Token(Token = "0x600009D")]
		[Address(RVA = "0x1010BF0", Offset = "0x1010BF0", VA = "0x1010BF0")]
		public PrimaryKeyAttribute()
		{
		}
	}
	[Token(Token = "0x200001C")]
	[AttributeUsage(AttributeTargets.Property)]
	public class AutoIncrementAttribute : Attribute
	{
		[Token(Token = "0x600009E")]
		[Address(RVA = "0x1010BF8", Offset = "0x1010BF8", VA = "0x1010BF8")]
		public AutoIncrementAttribute()
		{
		}
	}
	[Token(Token = "0x200001D")]
	[AttributeUsage(AttributeTargets.Property)]
	public class IndexedAttribute : Attribute
	{
		[Token(Token = "0x17000014")]
		public string Name
		{
			[Token(Token = "0x600009F")]
			[Address(RVA = "0x1010C00", Offset = "0x1010C00", VA = "0x1010C00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000A0")]
			[Address(RVA = "0x1010C08", Offset = "0x1010C08", VA = "0x1010C08")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000015")]
		public int Order
		{
			[Token(Token = "0x60000A1")]
			[Address(RVA = "0x1010C10", Offset = "0x1010C10", VA = "0x1010C10")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000A2")]
			[Address(RVA = "0x1010C18", Offset = "0x1010C18", VA = "0x1010C18")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public virtual bool Unique
		{
			[Token(Token = "0x60000A3")]
			[Address(RVA = "0x1010C20", Offset = "0x1010C20", VA = "0x1010C20", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000A4")]
			[Address(RVA = "0x1010C28", Offset = "0x1010C28", VA = "0x1010C28", Slot = "8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x1010C34", Offset = "0x1010C34", VA = "0x1010C34")]
		public IndexedAttribute()
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x1010C3C", Offset = "0x1010C3C", VA = "0x1010C3C")]
		public IndexedAttribute(string name, int order)
		{
		}
	}
	[Token(Token = "0x200001E")]
	[AttributeUsage(AttributeTargets.Property)]
	public class IgnoreAttribute : Attribute
	{
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x1010C78", Offset = "0x1010C78", VA = "0x1010C78")]
		public IgnoreAttribute()
		{
		}
	}
	[Token(Token = "0x200001F")]
	[AttributeUsage(AttributeTargets.Property)]
	public class UniqueAttribute : IndexedAttribute
	{
		[Token(Token = "0x17000017")]
		public override bool Unique
		{
			[Token(Token = "0x60000A8")]
			[Address(RVA = "0x1010C80", Offset = "0x1010C80", VA = "0x1010C80", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000A9")]
			[Address(RVA = "0x1010C88", Offset = "0x1010C88", VA = "0x1010C88", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x1010C8C", Offset = "0x1010C8C", VA = "0x1010C8C")]
		public UniqueAttribute()
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x1010C94", Offset = "0x1010C94", VA = "0x1010C94")]
		public UniqueAttribute(string name, int order)
		{
		}
	}
	[Token(Token = "0x2000020")]
	[AttributeUsage(AttributeTargets.Property)]
	public class MaxLengthAttribute : Attribute
	{
		[Token(Token = "0x17000018")]
		public int Value
		{
			[Token(Token = "0x60000AC")]
			[Address(RVA = "0x1010CD0", Offset = "0x1010CD0", VA = "0x1010CD0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000AD")]
			[Address(RVA = "0x1010CD8", Offset = "0x1010CD8", VA = "0x1010CD8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x1010CE0", Offset = "0x1010CE0", VA = "0x1010CE0")]
		public MaxLengthAttribute(int length)
		{
		}
	}
	[Token(Token = "0x2000021")]
	[AttributeUsage(AttributeTargets.Property)]
	public class CollationAttribute : Attribute
	{
		[Token(Token = "0x17000019")]
		public string Value
		{
			[Token(Token = "0x60000AF")]
			[Address(RVA = "0x1010D08", Offset = "0x1010D08", VA = "0x1010D08")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000B0")]
			[Address(RVA = "0x1010D10", Offset = "0x1010D10", VA = "0x1010D10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x1010D18", Offset = "0x1010D18", VA = "0x1010D18")]
		public CollationAttribute(string collation)
		{
		}
	}
	[Token(Token = "0x2000022")]
	[AttributeUsage(AttributeTargets.Property)]
	public class NotNullAttribute : Attribute
	{
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x1010D48", Offset = "0x1010D48", VA = "0x1010D48")]
		public NotNullAttribute()
		{
		}
	}
	[Token(Token = "0x2000023")]
	public class TableMapping
	{
		[Token(Token = "0x2000024")]
		public class Column
		{
			[Token(Token = "0x4000068")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private PropertyInfo _prop;

			[Token(Token = "0x17000022")]
			public string Name
			{
				[Token(Token = "0x60000C8")]
				[Address(RVA = "0x10118E8", Offset = "0x10118E8", VA = "0x10118E8")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60000C9")]
				[Address(RVA = "0x10118F0", Offset = "0x10118F0", VA = "0x10118F0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000023")]
			public string PropertyName
			{
				[Token(Token = "0x60000CA")]
				[Address(RVA = "0x100E734", Offset = "0x100E734", VA = "0x100E734")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000024")]
			public Type ColumnType
			{
				[Token(Token = "0x60000CB")]
				[Address(RVA = "0x10118F8", Offset = "0x10118F8", VA = "0x10118F8")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60000CC")]
				[Address(RVA = "0x1011900", Offset = "0x1011900", VA = "0x1011900")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000025")]
			public string Collation
			{
				[Token(Token = "0x60000CD")]
				[Address(RVA = "0x1011908", Offset = "0x1011908", VA = "0x1011908")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60000CE")]
				[Address(RVA = "0x1011910", Offset = "0x1011910", VA = "0x1011910")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000026")]
			public bool IsAutoInc
			{
				[Token(Token = "0x60000CF")]
				[Address(RVA = "0x1011918", Offset = "0x1011918", VA = "0x1011918")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60000D0")]
				[Address(RVA = "0x1011920", Offset = "0x1011920", VA = "0x1011920")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000027")]
			public bool IsAutoGuid
			{
				[Token(Token = "0x60000D1")]
				[Address(RVA = "0x101192C", Offset = "0x101192C", VA = "0x101192C")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60000D2")]
				[Address(RVA = "0x1011934", Offset = "0x1011934", VA = "0x1011934")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000028")]
			public bool IsPK
			{
				[Token(Token = "0x60000D3")]
				[Address(RVA = "0x1011940", Offset = "0x1011940", VA = "0x1011940")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60000D4")]
				[Address(RVA = "0x1011948", Offset = "0x1011948", VA = "0x1011948")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000029")]
			public IEnumerable<IndexedAttribute> Indices
			{
				[Token(Token = "0x60000D5")]
				[Address(RVA = "0x1011954", Offset = "0x1011954", VA = "0x1011954")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60000D6")]
				[Address(RVA = "0x101195C", Offset = "0x101195C", VA = "0x101195C")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x1700002A")]
			public bool IsNullable
			{
				[Token(Token = "0x60000D7")]
				[Address(RVA = "0x1011964", Offset = "0x1011964", VA = "0x1011964")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60000D8")]
				[Address(RVA = "0x101196C", Offset = "0x101196C", VA = "0x101196C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700002B")]
			public int? MaxStringLength
			{
				[Token(Token = "0x60000D9")]
				[Address(RVA = "0x1011978", Offset = "0x1011978", VA = "0x1011978")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60000DA")]
				[Address(RVA = "0x1011980", Offset = "0x1011980", VA = "0x1011980")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x60000DB")]
			[Address(RVA = "0x1010DA0", Offset = "0x1010DA0", VA = "0x1010DA0")]
			public Column(PropertyInfo prop, CreateFlags createFlags = CreateFlags.None)
			{
			}

			[Token(Token = "0x60000DC")]
			[Address(RVA = "0x10111B0", Offset = "0x10111B0", VA = "0x10111B0")]
			public void SetValue(object obj, object val)
			{
			}

			[Token(Token = "0x60000DD")]
			[Address(RVA = "0x1009EF4", Offset = "0x1009EF4", VA = "0x1009EF4")]
			public object GetValue(object obj)
			{
				return null;
			}
		}

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Column _autoPk;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Column[] _insertColumns;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Column[] _insertOrReplaceColumns;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private PreparedSqlLiteInsertCommand _insertCommand;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private string _insertCommandExtra;

		[Token(Token = "0x1700001A")]
		public Type MappedType
		{
			[Token(Token = "0x60000B3")]
			[Address(RVA = "0x1010D50", Offset = "0x1010D50", VA = "0x1010D50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000B4")]
			[Address(RVA = "0x1010D58", Offset = "0x1010D58", VA = "0x1010D58")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public string TableName
		{
			[Token(Token = "0x60000B5")]
			[Address(RVA = "0x1010D60", Offset = "0x1010D60", VA = "0x1010D60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000B6")]
			[Address(RVA = "0x1010D68", Offset = "0x1010D68", VA = "0x1010D68")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public Column[] Columns
		{
			[Token(Token = "0x60000B7")]
			[Address(RVA = "0x1010D70", Offset = "0x1010D70", VA = "0x1010D70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000B8")]
			[Address(RVA = "0x1010D78", Offset = "0x1010D78", VA = "0x1010D78")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		public Column PK
		{
			[Token(Token = "0x60000B9")]
			[Address(RVA = "0x1010D80", Offset = "0x1010D80", VA = "0x1010D80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000BA")]
			[Address(RVA = "0x1010D88", Offset = "0x1010D88", VA = "0x1010D88")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public string GetByPrimaryKeySql
		{
			[Token(Token = "0x60000BB")]
			[Address(RVA = "0x1010D90", Offset = "0x1010D90", VA = "0x1010D90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000BC")]
			[Address(RVA = "0x1010D98", Offset = "0x1010D98", VA = "0x1010D98")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public bool HasAutoIncPK
		{
			[Token(Token = "0x60000BE")]
			[Address(RVA = "0x101119C", Offset = "0x101119C", VA = "0x101119C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000BF")]
			[Address(RVA = "0x10111A4", Offset = "0x10111A4", VA = "0x10111A4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000020")]
		public Column[] InsertColumns
		{
			[Token(Token = "0x60000C1")]
			[Address(RVA = "0x100E754", Offset = "0x100E754", VA = "0x100E754")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000021")]
		public Column[] InsertOrReplaceColumns
		{
			[Token(Token = "0x60000C2")]
			[Address(RVA = "0x100E898", Offset = "0x100E898", VA = "0x100E898")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x100ACEC", Offset = "0x100ACEC", VA = "0x100ACEC")]
		public TableMapping(Type type, CreateFlags createFlags = CreateFlags.None)
		{
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x100ED1C", Offset = "0x100ED1C", VA = "0x100ED1C")]
		public void SetAutoIncPK(object obj, long id)
		{
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x10111D8", Offset = "0x10111D8", VA = "0x10111D8")]
		public Column FindColumnWithPropertyName(string propertyName)
		{
			return null;
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x10112C4", Offset = "0x10112C4", VA = "0x10112C4")]
		public Column FindColumn(string columnName)
		{
			return null;
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x100E904", Offset = "0x100E904", VA = "0x100E904")]
		public PreparedSqlLiteInsertCommand GetInsertCommand(SQLiteConnection conn, string extra)
		{
			return null;
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x10113B0", Offset = "0x10113B0", VA = "0x10113B0")]
		private PreparedSqlLiteInsertCommand CreateInsertCommand(SQLiteConnection conn, string extra)
		{
			return null;
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x100FA48", Offset = "0x100FA48", VA = "0x100FA48")]
		protected internal void Dispose()
		{
		}
	}
	[Token(Token = "0x2000028")]
	public static class Orm
	{
		[Token(Token = "0x4000078")]
		public const int DefaultMaxStringLength = 140;

		[Token(Token = "0x4000079")]
		public const string ImplicitPkName = "Id";

		[Token(Token = "0x400007A")]
		public const string ImplicitIndexSuffix = "Id";

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x100C97C", Offset = "0x100C97C", VA = "0x100C97C")]
		public static string SqlDecl(TableMapping.Column p, bool storeDateTimeAsTicks)
		{
			return null;
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x1012038", Offset = "0x1012038", VA = "0x1012038")]
		public static string SqlType(TableMapping.Column p, bool storeDateTimeAsTicks)
		{
			return null;
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x1011AB0", Offset = "0x1011AB0", VA = "0x1011AB0")]
		public static bool IsPK(MemberInfo p)
		{
			return default(bool);
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x1011988", Offset = "0x1011988", VA = "0x1011988")]
		public static string Collation(MemberInfo p)
		{
			return null;
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x1011B60", Offset = "0x1011B60", VA = "0x1011B60")]
		public static bool IsAutoInc(MemberInfo p)
		{
			return default(bool);
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x1011C10", Offset = "0x1011C10", VA = "0x1011C10")]
		public static IEnumerable<IndexedAttribute> GetIndices(MemberInfo p)
		{
			return null;
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x1011D78", Offset = "0x1011D78", VA = "0x1011D78")]
		public static int? MaxStringLength(PropertyInfo p)
		{
			return null;
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x1011CC8", Offset = "0x1011CC8", VA = "0x1011CC8")]
		public static bool IsMarkedNotNull(MemberInfo p)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000029")]
	public class SQLiteCommand
	{
		[Token(Token = "0x200002A")]
		private class Binding
		{
			[Token(Token = "0x1700002D")]
			public string Name
			{
				[Token(Token = "0x6000102")]
				[Address(RVA = "0x1014640", Offset = "0x1014640", VA = "0x1014640")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000103")]
				[Address(RVA = "0x1014648", Offset = "0x1014648", VA = "0x1014648")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x1700002E")]
			public object Value
			{
				[Token(Token = "0x6000104")]
				[Address(RVA = "0x1014650", Offset = "0x1014650", VA = "0x1014650")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000105")]
				[Address(RVA = "0x1014658", Offset = "0x1014658", VA = "0x1014658")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x1700002F")]
			public int Index
			{
				[Token(Token = "0x6000106")]
				[Address(RVA = "0x1014660", Offset = "0x1014660", VA = "0x1014660")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6000107")]
				[Address(RVA = "0x1014668", Offset = "0x1014668", VA = "0x1014668")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x6000108")]
			[Address(RVA = "0x10129B4", Offset = "0x10129B4", VA = "0x10129B4")]
			public Binding()
			{
			}
		}

		[Token(Token = "0x200002B")]
		[CompilerGenerated]
		private sealed class <ExecuteDeferredQuery>d__12<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000082")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x4000083")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private T <>2__current;

			[Token(Token = "0x4000084")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>l__initialThreadId;

			[Token(Token = "0x4000085")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public SQLiteCommand <>4__this;

			[Token(Token = "0x4000086")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private TableMapping map;

			[Token(Token = "0x4000087")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public TableMapping <>3__map;

			[Token(Token = "0x4000088")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private object <>7__wrap1;

			[Token(Token = "0x4000089")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private bool <>7__wrap2;

			[Token(Token = "0x400008A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private IntPtr <stmt>5__4;

			[Token(Token = "0x400008B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private TableMapping.Column[] <cols>5__5;

			[Token(Token = "0x17000030")]
			private T System.Collections.Generic.IEnumerator<T>.Current
			{
				[Token(Token = "0x600010E")]
				[DebuggerHidden]
				get
				{
					return (T)null;
				}
			}

			[Token(Token = "0x17000031")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000110")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000109")]
			[DebuggerHidden]
			public <ExecuteDeferredQuery>d__12(int <>1__state)
			{
			}

			[Token(Token = "0x600010A")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600010B")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600010C")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x600010D")]
			private void <>m__Finally2()
			{
			}

			[Token(Token = "0x600010F")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000111")]
			[DebuggerHidden]
			private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000112")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private SQLiteConnection _conn;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<Binding> _bindings;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static IntPtr NegativePointer;

		[Token(Token = "0x1700002C")]
		public string CommandText
		{
			[Token(Token = "0x60000EF")]
			[Address(RVA = "0x1012750", Offset = "0x1012750", VA = "0x1012750")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000F0")]
			[Address(RVA = "0x1012758", Offset = "0x1012758", VA = "0x1012758")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x100CCCC", Offset = "0x100CCCC", VA = "0x100CCCC")]
		internal SQLiteCommand(SQLiteConnection conn)
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x100CE70", Offset = "0x100CE70", VA = "0x100CE70")]
		public int ExecuteNonQuery()
		{
			return default(int);
		}

		[Token(Token = "0x60000F3")]
		public IEnumerable<T> ExecuteDeferredQuery<T>()
		{
			return null;
		}

		[Token(Token = "0x60000F4")]
		public List<T> ExecuteQuery<T>()
		{
			return null;
		}

		[Token(Token = "0x60000F5")]
		public List<T> ExecuteQuery<T>(TableMapping map)
		{
			return null;
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x10128A4", Offset = "0x10128A4", VA = "0x10128A4", Slot = "4")]
		protected virtual void OnInstanceCreated(object obj)
		{
		}

		[Token(Token = "0x60000F7")]
		[IteratorStateMachine(typeof(<ExecuteDeferredQuery>d__12<>))]
		public IEnumerable<T> ExecuteDeferredQuery<T>(TableMapping map)
		{
			return null;
		}

		[Token(Token = "0x60000F8")]
		public T ExecuteScalar<T>()
		{
			return (T)null;
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x10128A8", Offset = "0x10128A8", VA = "0x10128A8")]
		public void Bind(string name, object val)
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x100CE64", Offset = "0x100CE64", VA = "0x100CE64")]
		public void Bind(object val)
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x10129BC", Offset = "0x10129BC", VA = "0x10129BC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x1012760", Offset = "0x1012760", VA = "0x1012760")]
		private IntPtr Prepare()
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x1012820", Offset = "0x1012820", VA = "0x1012820")]
		private void Finalize(IntPtr stmt)
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x1012D24", Offset = "0x1012D24", VA = "0x1012D24")]
		private void BindAll(IntPtr stmt)
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x1013024", Offset = "0x1013024", VA = "0x1013024")]
		internal static void BindParameter(IntPtr stmt, int index, object value, bool storeDateTimeAsTicks)
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x10139A8", Offset = "0x10139A8", VA = "0x10139A8")]
		private object ReadCol(IntPtr stmt, int index, SQLite3.ColType type, Type clrType)
		{
			return null;
		}
	}
	[Token(Token = "0x200002C")]
	public class PreparedSqlLiteInsertCommand : IDisposable
	{
		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static readonly IntPtr NullStatement;

		[Token(Token = "0x17000032")]
		public bool Initialized
		{
			[Token(Token = "0x6000113")]
			[Address(RVA = "0x1014670", Offset = "0x1014670", VA = "0x1014670")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000114")]
			[Address(RVA = "0x1014678", Offset = "0x1014678", VA = "0x1014678")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000033")]
		protected SQLiteConnection Connection
		{
			[Token(Token = "0x6000115")]
			[Address(RVA = "0x1014684", Offset = "0x1014684", VA = "0x1014684")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000116")]
			[Address(RVA = "0x101468C", Offset = "0x101468C", VA = "0x101468C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000034")]
		public string CommandText
		{
			[Token(Token = "0x6000117")]
			[Address(RVA = "0x1014694", Offset = "0x1014694", VA = "0x1014694")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000118")]
			[Address(RVA = "0x101469C", Offset = "0x101469C", VA = "0x101469C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000035")]
		protected IntPtr Statement
		{
			[Token(Token = "0x6000119")]
			[Address(RVA = "0x10146A4", Offset = "0x10146A4", VA = "0x10146A4")]
			[CompilerGenerated]
			get
			{
				return default(IntPtr);
			}
			[Token(Token = "0x600011A")]
			[Address(RVA = "0x10146AC", Offset = "0x10146AC", VA = "0x10146AC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x10118B8", Offset = "0x10118B8", VA = "0x10118B8")]
		internal PreparedSqlLiteInsertCommand(SQLiteConnection conn)
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x100E9BC", Offset = "0x100E9BC", VA = "0x100E9BC")]
		public int ExecuteNonQuery(object[] source)
		{
			return default(int);
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x1014730", Offset = "0x1014730", VA = "0x1014730", Slot = "5")]
		protected virtual IntPtr Prepare()
		{
			return default(IntPtr);
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x1011854", Offset = "0x1011854", VA = "0x1011854", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x1014754", Offset = "0x1014754", VA = "0x1014754")]
		private void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x1014854", Offset = "0x1014854", VA = "0x1014854", Slot = "1")]
		~PreparedSqlLiteInsertCommand()
		{
		}
	}
	[Token(Token = "0x200002D")]
	public abstract class BaseTableQuery
	{
		[Token(Token = "0x200002E")]
		protected class Ordering
		{
			[Token(Token = "0x17000036")]
			public string ColumnName
			{
				[Token(Token = "0x6000122")]
				[Address(RVA = "0x10148F4", Offset = "0x10148F4", VA = "0x10148F4")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000123")]
				[Address(RVA = "0x10148FC", Offset = "0x10148FC", VA = "0x10148FC")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x17000037")]
			public bool Ascending
			{
				[Token(Token = "0x6000124")]
				[Address(RVA = "0x1014904", Offset = "0x1014904", VA = "0x1014904")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000125")]
				[Address(RVA = "0x101490C", Offset = "0x101490C", VA = "0x101490C")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x6000126")]
			[Address(RVA = "0x1014918", Offset = "0x1014918", VA = "0x1014918")]
			public Ordering()
			{
			}
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x10148EC", Offset = "0x10148EC", VA = "0x10148EC")]
		protected BaseTableQuery()
		{
		}
	}
	[Token(Token = "0x200002F")]
	public class TableQuery<T> : BaseTableQuery, IEnumerable<T>, IEnumerable
	{
		[Token(Token = "0x2000030")]
		private class CompileResult
		{
			[Token(Token = "0x1700003A")]
			public string CommandText
			{
				[Token(Token = "0x6000146")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000147")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x1700003B")]
			public object Value
			{
				[Token(Token = "0x6000148")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000149")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x600014A")]
			public CompileResult()
			{
			}
		}

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Expression _where;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private List<Ordering> _orderBys;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int? _limit;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int? _offset;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private BaseTableQuery _joinInner;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Expression _joinInnerKeySelector;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private BaseTableQuery _joinOuter;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Expression _joinOuterKeySelector;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Expression _joinSelector;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Expression _selector;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool _deferred;

		[Token(Token = "0x17000038")]
		public SQLiteConnection Connection
		{
			[Token(Token = "0x6000127")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000128")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000039")]
		public TableMapping Table
		{
			[Token(Token = "0x6000129")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600012A")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600012B")]
		private TableQuery(SQLiteConnection conn, TableMapping table)
		{
		}

		[Token(Token = "0x600012C")]
		public TableQuery(SQLiteConnection conn)
		{
		}

		[Token(Token = "0x600012D")]
		public TableQuery<U> Clone<U>()
		{
			return null;
		}

		[Token(Token = "0x600012E")]
		public TableQuery<T> Where(Expression<Func<T, bool>> predExpr)
		{
			return null;
		}

		[Token(Token = "0x600012F")]
		public TableQuery<T> Take(int n)
		{
			return null;
		}

		[Token(Token = "0x6000130")]
		public TableQuery<T> Skip(int n)
		{
			return null;
		}

		[Token(Token = "0x6000131")]
		public T ElementAt(int index)
		{
			return (T)null;
		}

		[Token(Token = "0x6000132")]
		public TableQuery<T> Deferred()
		{
			return null;
		}

		[Token(Token = "0x6000133")]
		public TableQuery<T> OrderBy<U>(Expression<Func<T, U>> orderExpr)
		{
			return null;
		}

		[Token(Token = "0x6000134")]
		public TableQuery<T> OrderByDescending<U>(Expression<Func<T, U>> orderExpr)
		{
			return null;
		}

		[Token(Token = "0x6000135")]
		public TableQuery<T> ThenBy<U>(Expression<Func<T, U>> orderExpr)
		{
			return null;
		}

		[Token(Token = "0x6000136")]
		public TableQuery<T> ThenByDescending<U>(Expression<Func<T, U>> orderExpr)
		{
			return null;
		}

		[Token(Token = "0x6000137")]
		private TableQuery<T> AddOrderBy<U>(Expression<Func<T, U>> orderExpr, bool asc)
		{
			return null;
		}

		[Token(Token = "0x6000138")]
		private void AddWhere(Expression pred)
		{
		}

		[Token(Token = "0x6000139")]
		public TableQuery<TResult> Join<TInner, TKey, TResult>(TableQuery<TInner> inner, Expression<Func<T, TKey>> outerKeySelector, Expression<Func<TInner, TKey>> innerKeySelector, Expression<Func<T, TInner, TResult>> resultSelector)
		{
			return null;
		}

		[Token(Token = "0x600013A")]
		public TableQuery<TResult> Select<TResult>(Expression<Func<T, TResult>> selector)
		{
			return null;
		}

		[Token(Token = "0x600013B")]
		private SQLiteCommand GenerateCommand(string selectionList)
		{
			return null;
		}

		[Token(Token = "0x600013C")]
		private CompileResult CompileExpr(Expression expr, List<object> queryArgs)
		{
			return null;
		}

		[Token(Token = "0x600013D")]
		private static object ConvertTo(object obj, Type t)
		{
			return null;
		}

		[Token(Token = "0x600013E")]
		private string CompileNullBinaryExpression(BinaryExpression expression, CompileResult parameter)
		{
			return null;
		}

		[Token(Token = "0x600013F")]
		private string GetSqlName(Expression expr)
		{
			return null;
		}

		[Token(Token = "0x6000140")]
		public int Count()
		{
			return default(int);
		}

		[Token(Token = "0x6000141")]
		public int Count(Expression<Func<T, bool>> predExpr)
		{
			return default(int);
		}

		[Token(Token = "0x6000142")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000143")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000144")]
		public T First()
		{
			return (T)null;
		}

		[Token(Token = "0x6000145")]
		public T FirstOrDefault()
		{
			return (T)null;
		}
	}
	[Token(Token = "0x2000032")]
	public static class SQLite3
	{
		[Token(Token = "0x2000033")]
		public enum Result
		{
			[Token(Token = "0x40000A6")]
			OK = 0,
			[Token(Token = "0x40000A7")]
			Error = 1,
			[Token(Token = "0x40000A8")]
			Internal = 2,
			[Token(Token = "0x40000A9")]
			Perm = 3,
			[Token(Token = "0x40000AA")]
			Abort = 4,
			[Token(Token = "0x40000AB")]
			Busy = 5,
			[Token(Token = "0x40000AC")]
			Locked = 6,
			[Token(Token = "0x40000AD")]
			NoMem = 7,
			[Token(Token = "0x40000AE")]
			ReadOnly = 8,
			[Token(Token = "0x40000AF")]
			Interrupt = 9,
			[Token(Token = "0x40000B0")]
			IOError = 10,
			[Token(Token = "0x40000B1")]
			Corrupt = 11,
			[Token(Token = "0x40000B2")]
			NotFound = 12,
			[Token(Token = "0x40000B3")]
			Full = 13,
			[Token(Token = "0x40000B4")]
			CannotOpen = 14,
			[Token(Token = "0x40000B5")]
			LockErr = 15,
			[Token(Token = "0x40000B6")]
			Empty = 16,
			[Token(Token = "0x40000B7")]
			SchemaChngd = 17,
			[Token(Token = "0x40000B8")]
			TooBig = 18,
			[Token(Token = "0x40000B9")]
			Constraint = 19,
			[Token(Token = "0x40000BA")]
			Mismatch = 20,
			[Token(Token = "0x40000BB")]
			Misuse = 21,
			[Token(Token = "0x40000BC")]
			NotImplementedLFS = 22,
			[Token(Token = "0x40000BD")]
			AccessDenied = 23,
			[Token(Token = "0x40000BE")]
			Format = 24,
			[Token(Token = "0x40000BF")]
			Range = 25,
			[Token(Token = "0x40000C0")]
			NonDBFile = 26,
			[Token(Token = "0x40000C1")]
			Notice = 27,
			[Token(Token = "0x40000C2")]
			Warning = 28,
			[Token(Token = "0x40000C3")]
			Row = 100,
			[Token(Token = "0x40000C4")]
			Done = 101
		}

		[Token(Token = "0x2000034")]
		public enum ExtendedResult
		{
			[Token(Token = "0x40000C6")]
			IOErrorRead = 266,
			[Token(Token = "0x40000C7")]
			IOErrorShortRead = 522,
			[Token(Token = "0x40000C8")]
			IOErrorWrite = 778,
			[Token(Token = "0x40000C9")]
			IOErrorFsync = 1034,
			[Token(Token = "0x40000CA")]
			IOErrorDirFSync = 1290,
			[Token(Token = "0x40000CB")]
			IOErrorTruncate = 1546,
			[Token(Token = "0x40000CC")]
			IOErrorFStat = 1802,
			[Token(Token = "0x40000CD")]
			IOErrorUnlock = 2058,
			[Token(Token = "0x40000CE")]
			IOErrorRdlock = 2314,
			[Token(Token = "0x40000CF")]
			IOErrorDelete = 2570,
			[Token(Token = "0x40000D0")]
			IOErrorBlocked = 2826,
			[Token(Token = "0x40000D1")]
			IOErrorNoMem = 3082,
			[Token(Token = "0x40000D2")]
			IOErrorAccess = 3338,
			[Token(Token = "0x40000D3")]
			IOErrorCheckReservedLock = 3594,
			[Token(Token = "0x40000D4")]
			IOErrorLock = 3850,
			[Token(Token = "0x40000D5")]
			IOErrorClose = 4106,
			[Token(Token = "0x40000D6")]
			IOErrorDirClose = 4362,
			[Token(Token = "0x40000D7")]
			IOErrorSHMOpen = 4618,
			[Token(Token = "0x40000D8")]
			IOErrorSHMSize = 4874,
			[Token(Token = "0x40000D9")]
			IOErrorSHMLock = 5130,
			[Token(Token = "0x40000DA")]
			IOErrorSHMMap = 5386,
			[Token(Token = "0x40000DB")]
			IOErrorSeek = 5642,
			[Token(Token = "0x40000DC")]
			IOErrorDeleteNoEnt = 5898,
			[Token(Token = "0x40000DD")]
			IOErrorMMap = 6154,
			[Token(Token = "0x40000DE")]
			LockedSharedcache = 262,
			[Token(Token = "0x40000DF")]
			BusyRecovery = 261,
			[Token(Token = "0x40000E0")]
			CannottOpenNoTempDir = 270,
			[Token(Token = "0x40000E1")]
			CannotOpenIsDir = 526,
			[Token(Token = "0x40000E2")]
			CannotOpenFullPath = 782,
			[Token(Token = "0x40000E3")]
			CorruptVTab = 267,
			[Token(Token = "0x40000E4")]
			ReadonlyRecovery = 264,
			[Token(Token = "0x40000E5")]
			ReadonlyCannotLock = 520,
			[Token(Token = "0x40000E6")]
			ReadonlyRollback = 776,
			[Token(Token = "0x40000E7")]
			AbortRollback = 516,
			[Token(Token = "0x40000E8")]
			ConstraintCheck = 275,
			[Token(Token = "0x40000E9")]
			ConstraintCommitHook = 531,
			[Token(Token = "0x40000EA")]
			ConstraintForeignKey = 787,
			[Token(Token = "0x40000EB")]
			ConstraintFunction = 1043,
			[Token(Token = "0x40000EC")]
			ConstraintNotNull = 1299,
			[Token(Token = "0x40000ED")]
			ConstraintPrimaryKey = 1555,
			[Token(Token = "0x40000EE")]
			ConstraintTrigger = 1811,
			[Token(Token = "0x40000EF")]
			ConstraintUnique = 2067,
			[Token(Token = "0x40000F0")]
			ConstraintVTab = 2323,
			[Token(Token = "0x40000F1")]
			NoticeRecoverWAL = 283,
			[Token(Token = "0x40000F2")]
			NoticeRecoverRollback = 539
		}

		[Token(Token = "0x2000035")]
		public enum ConfigOption
		{
			[Token(Token = "0x40000F4")]
			SingleThread = 1,
			[Token(Token = "0x40000F5")]
			MultiThread,
			[Token(Token = "0x40000F6")]
			Serialized
		}

		[Token(Token = "0x2000036")]
		public enum ColType
		{
			[Token(Token = "0x40000F8")]
			Integer = 1,
			[Token(Token = "0x40000F9")]
			Float,
			[Token(Token = "0x40000FA")]
			Text,
			[Token(Token = "0x40000FB")]
			Blob,
			[Token(Token = "0x40000FC")]
			Null
		}

		[PreserveSig]
		[Token(Token = "0x600014F")]
		[Address(RVA = "0x1014920", Offset = "0x1014920", VA = "0x1014920")]
		public static extern Result Open(string filename, out IntPtr db);

		[PreserveSig]
		[Token(Token = "0x6000150")]
		[Address(RVA = "0x10149BC", Offset = "0x10149BC", VA = "0x10149BC")]
		public static extern Result Open(string filename, out IntPtr db, int flags, IntPtr zvfs);

		[PreserveSig]
		[Token(Token = "0x6000151")]
		[Address(RVA = "0x100A620", Offset = "0x100A620", VA = "0x100A620")]
		public static extern Result Open(byte[] filename, out IntPtr db, int flags, IntPtr zvfs);

		[PreserveSig]
		[Token(Token = "0x6000152")]
		[Address(RVA = "0x1014A70", Offset = "0x1014A70", VA = "0x1014A70")]
		public static extern Result Open16(string filename, out IntPtr db);

		[PreserveSig]
		[Token(Token = "0x6000153")]
		[Address(RVA = "0x100A964", Offset = "0x100A964", VA = "0x100A964")]
		public static extern Result EnableLoadExtension(IntPtr db, int onoff);

		[PreserveSig]
		[Token(Token = "0x6000154")]
		[Address(RVA = "0x100FA78", Offset = "0x100FA78", VA = "0x100FA78")]
		public static extern Result Close(IntPtr db);

		[PreserveSig]
		[Token(Token = "0x6000155")]
		[Address(RVA = "0x1014AFC", Offset = "0x1014AFC", VA = "0x1014AFC")]
		public static extern Result Initialize();

		[PreserveSig]
		[Token(Token = "0x6000156")]
		[Address(RVA = "0x1014B64", Offset = "0x1014B64", VA = "0x1014B64")]
		public static extern Result Shutdown();

		[PreserveSig]
		[Token(Token = "0x6000157")]
		[Address(RVA = "0x1014BCC", Offset = "0x1014BCC", VA = "0x1014BCC")]
		public static extern Result Config(ConfigOption option);

		[PreserveSig]
		[Token(Token = "0x6000158")]
		[Address(RVA = "0x1014C48", Offset = "0x1014C48", VA = "0x1014C48")]
		public static extern int SetDirectory(uint directoryType, string directoryPath);

		[PreserveSig]
		[Token(Token = "0x6000159")]
		[Address(RVA = "0x100AA58", Offset = "0x100AA58", VA = "0x100AA58")]
		public static extern Result BusyTimeout(IntPtr db, int milliseconds);

		[PreserveSig]
		[Token(Token = "0x600015A")]
		[Address(RVA = "0x1012828", Offset = "0x1012828", VA = "0x1012828")]
		public static extern int Changes(IntPtr db);

		[PreserveSig]
		[Token(Token = "0x600015B")]
		[Address(RVA = "0x1014CD0", Offset = "0x1014CD0", VA = "0x1014CD0")]
		public static extern Result Prepare2(IntPtr db, string sql, int numBytes, out IntPtr stmt, IntPtr pzTail);

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x1012C58", Offset = "0x1012C58", VA = "0x1012C58")]
		public static IntPtr Prepare2(IntPtr db, string query)
		{
			return default(IntPtr);
		}

		[PreserveSig]
		[Token(Token = "0x600015D")]
		[Address(RVA = "0x10127A4", Offset = "0x10127A4", VA = "0x10127A4")]
		public static extern Result Step(IntPtr stmt);

		[PreserveSig]
		[Token(Token = "0x600015E")]
		[Address(RVA = "0x10146B4", Offset = "0x10146B4", VA = "0x10146B4")]
		public static extern Result Reset(IntPtr stmt);

		[PreserveSig]
		[Token(Token = "0x600015F")]
		[Address(RVA = "0x1012F08", Offset = "0x1012F08", VA = "0x1012F08")]
		public static extern Result Finalize(IntPtr stmt);

		[PreserveSig]
		[Token(Token = "0x6000160")]
		[Address(RVA = "0x100ECA0", Offset = "0x100ECA0", VA = "0x100ECA0")]
		public static extern long LastInsertRowid(IntPtr db);

		[PreserveSig]
		[Token(Token = "0x6000161")]
		[Address(RVA = "0x1014D98", Offset = "0x1014D98", VA = "0x1014D98")]
		public static extern IntPtr Errmsg(IntPtr db);

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x100A9E8", Offset = "0x100A9E8", VA = "0x100A9E8")]
		public static string GetErrmsg(IntPtr db)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x6000163")]
		[Address(RVA = "0x1012F84", Offset = "0x1012F84", VA = "0x1012F84")]
		public static extern int BindParameterIndex(IntPtr stmt, string name);

		[PreserveSig]
		[Token(Token = "0x6000164")]
		[Address(RVA = "0x1013608", Offset = "0x1013608", VA = "0x1013608")]
		public static extern int BindNull(IntPtr stmt, int index);

		[PreserveSig]
		[Token(Token = "0x6000165")]
		[Address(RVA = "0x101368C", Offset = "0x101368C", VA = "0x101368C")]
		public static extern int BindInt(IntPtr stmt, int index, int val);

		[PreserveSig]
		[Token(Token = "0x6000166")]
		[Address(RVA = "0x10137CC", Offset = "0x10137CC", VA = "0x10137CC")]
		public static extern int BindInt64(IntPtr stmt, int index, long val);

		[PreserveSig]
		[Token(Token = "0x6000167")]
		[Address(RVA = "0x1013860", Offset = "0x1013860", VA = "0x1013860")]
		public static extern int BindDouble(IntPtr stmt, int index, double val);

		[PreserveSig]
		[Token(Token = "0x6000168")]
		[Address(RVA = "0x101371C", Offset = "0x101371C", VA = "0x101371C")]
		public static extern int BindText(IntPtr stmt, int index, string val, int n, IntPtr free);

		[PreserveSig]
		[Token(Token = "0x6000169")]
		[Address(RVA = "0x10138F4", Offset = "0x10138F4", VA = "0x10138F4")]
		public static extern int BindBlob(IntPtr stmt, int index, byte[] val, int n, IntPtr free);

		[PreserveSig]
		[Token(Token = "0x600016A")]
		[Address(RVA = "0x1014E14", Offset = "0x1014E14", VA = "0x1014E14")]
		public static extern int ColumnCount(IntPtr stmt);

		[PreserveSig]
		[Token(Token = "0x600016B")]
		[Address(RVA = "0x1014E90", Offset = "0x1014E90", VA = "0x1014E90")]
		public static extern IntPtr ColumnName(IntPtr stmt, int index);

		[PreserveSig]
		[Token(Token = "0x600016C")]
		[Address(RVA = "0x1014F14", Offset = "0x1014F14", VA = "0x1014F14")]
		private static extern IntPtr ColumnName16Internal(IntPtr stmt, int index);

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x1014F98", Offset = "0x1014F98", VA = "0x1014F98")]
		public static string ColumnName16(IntPtr stmt, int index)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x600016E")]
		[Address(RVA = "0x1015010", Offset = "0x1015010", VA = "0x1015010")]
		public static extern ColType ColumnType(IntPtr stmt, int index);

		[PreserveSig]
		[Token(Token = "0x600016F")]
		[Address(RVA = "0x1014388", Offset = "0x1014388", VA = "0x1014388")]
		public static extern int ColumnInt(IntPtr stmt, int index);

		[PreserveSig]
		[Token(Token = "0x6000170")]
		[Address(RVA = "0x1014490", Offset = "0x1014490", VA = "0x1014490")]
		public static extern long ColumnInt64(IntPtr stmt, int index);

		[PreserveSig]
		[Token(Token = "0x6000171")]
		[Address(RVA = "0x101440C", Offset = "0x101440C", VA = "0x101440C")]
		public static extern double ColumnDouble(IntPtr stmt, int index);

		[PreserveSig]
		[Token(Token = "0x6000172")]
		[Address(RVA = "0x1015094", Offset = "0x1015094", VA = "0x1015094")]
		public static extern IntPtr ColumnText(IntPtr stmt, int index);

		[PreserveSig]
		[Token(Token = "0x6000173")]
		[Address(RVA = "0x1015118", Offset = "0x1015118", VA = "0x1015118")]
		public static extern IntPtr ColumnText16(IntPtr stmt, int index);

		[PreserveSig]
		[Token(Token = "0x6000174")]
		[Address(RVA = "0x101519C", Offset = "0x101519C", VA = "0x101519C")]
		public static extern IntPtr ColumnBlob(IntPtr stmt, int index);

		[PreserveSig]
		[Token(Token = "0x6000175")]
		[Address(RVA = "0x1015220", Offset = "0x1015220", VA = "0x1015220")]
		public static extern int ColumnBytes(IntPtr stmt, int index);

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x1014310", Offset = "0x1014310", VA = "0x1014310")]
		public static string ColumnString(IntPtr stmt, int index)
		{
			return null;
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x1014514", Offset = "0x1014514", VA = "0x1014514")]
		public static byte[] ColumnByteArray(IntPtr stmt, int index)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x6000178")]
		[Address(RVA = "0x100EC24", Offset = "0x100EC24", VA = "0x100EC24")]
		public static extern ExtendedResult ExtendedErrCode(IntPtr db);

		[PreserveSig]
		[Token(Token = "0x6000179")]
		[Address(RVA = "0x10152A4", Offset = "0x10152A4", VA = "0x10152A4")]
		public static extern int LibVersionNumber();
	}
}
namespace Lowscope.Saving
{
	[Token(Token = "0x2000037")]
	public enum InstanceSource
	{
		[Token(Token = "0x40000FE")]
		Resources,
		[Token(Token = "0x40000FF")]
		Custom
	}
	[Token(Token = "0x2000038")]
	[CreateAssetMenu(fileName = "Save Master Bridge", menuName = "Saving/Save Master Bridge")]
	public class SaveMasterBridge : ScriptableObject
	{
		[Token(Token = "0x600017A")]
		[Address(RVA = "0x101530C", Offset = "0x101530C", VA = "0x101530C")]
		public void SetSlotTolastUsedSlot()
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x10153F0", Offset = "0x10153F0", VA = "0x10153F0")]
		public void SetToNewAvailableSlot()
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x10154DC", Offset = "0x10154DC", VA = "0x10154DC")]
		public void ClearSlot()
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x10155DC", Offset = "0x10155DC", VA = "0x10155DC")]
		public void ClearSlotAndSaveables()
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x1015630", Offset = "0x1015630", VA = "0x1015630")]
		public void DeleteActiveSave()
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x10156D4", Offset = "0x10156D4", VA = "0x10156D4")]
		public void DeleteSave(int slot)
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x1015864", Offset = "0x1015864", VA = "0x1015864")]
		public void WriteActiveSaveToDisk()
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x1015C1C", Offset = "0x1015C1C", VA = "0x1015C1C")]
		public void SetSlot(int slot)
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x10160E0", Offset = "0x10160E0", VA = "0x10160E0")]
		public void SetSlotWithoutSavingActive(int slot)
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x1016254", Offset = "0x1016254", VA = "0x1016254")]
		public void SetToTemporarySlot(bool reloadSaveables)
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x101631C", Offset = "0x101631C", VA = "0x101631C")]
		public void WipeSceneData(string sceneName)
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x1016374", Offset = "0x1016374", VA = "0x1016374")]
		public void WipeSceneDataAndActiveSaveables(string sceneName)
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x10163CC", Offset = "0x10163CC", VA = "0x10163CC")]
		public void WipeSaveable(Saveable saveable)
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x10164CC", Offset = "0x10164CC", VA = "0x10164CC")]
		public void ClearListeners()
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x101671C", Offset = "0x101671C", VA = "0x101671C")]
		public void ClearListenersAndSave()
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x101676C", Offset = "0x101676C", VA = "0x101676C")]
		public void SaveListener(Saveable saveable)
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x101688C", Offset = "0x101688C", VA = "0x101688C")]
		public void LoadListener(Saveable saveable)
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x10169AC", Offset = "0x10169AC", VA = "0x10169AC")]
		public void ReloadListener(Saveable saveable)
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x1016ADC", Offset = "0x1016ADC", VA = "0x1016ADC")]
		public void RemoveListener(Saveable saveable)
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x1016D2C", Offset = "0x1016D2C", VA = "0x1016D2C")]
		public void ClearActiveSaveData()
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x10170E8", Offset = "0x10170E8", VA = "0x10170E8")]
		public void ClearActiveSaveDataAndListeners()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x101713C", Offset = "0x101713C", VA = "0x101713C")]
		public void ClearActiveSaveDataAndListenersAndReloadScene()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x1017190", Offset = "0x1017190", VA = "0x1017190")]
		public void SyncSave()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x1017598", Offset = "0x1017598", VA = "0x1017598")]
		public void SyncLoad()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x10179A0", Offset = "0x10179A0", VA = "0x10179A0")]
		public void SyncReset()
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x1017BC4", Offset = "0x1017BC4", VA = "0x1017BC4")]
		public void SpawnSavedPrefabResources(string resourceName)
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x1017C3C", Offset = "0x1017C3C", VA = "0x1017C3C")]
		public SaveMasterBridge()
		{
		}
	}
	[Token(Token = "0x2000039")]
	public interface ISaveable
	{
		[Token(Token = "0x6000195")]
		string OnSave();

		[Token(Token = "0x6000196")]
		void OnLoad(string data);

		[Token(Token = "0x6000197")]
		bool OnSaveCondition();
	}
	[Token(Token = "0x200003A")]
	[AddComponentMenu("")]
	public class SaveMaster : MonoBehaviour
	{
		[Token(Token = "0x200003B")]
		internal struct SlotChangeInfo
		{
			[Token(Token = "0x400011F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int fromSlot;

			[Token(Token = "0x4000120")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int toSlot;

			[Token(Token = "0x4000121")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public bool firstFrame;
		}

		[Token(Token = "0x200003C")]
		internal struct SceneInformation
		{
			[Token(Token = "0x4000122")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int hash;

			[Token(Token = "0x4000123")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string name;

			[Token(Token = "0x4000124")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isLoadedMultipleTimes;
		}

		[Token(Token = "0x200003D")]
		[CompilerGenerated]
		private sealed class <AutoSaveGame>d__163 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000125")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000126")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000127")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private WaitForSeconds <wait>5__2;

			[Token(Token = "0x1700004D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000213")]
				[Address(RVA = "0x101DA8C", Offset = "0x101DA8C", VA = "0x101DA8C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700004E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000215")]
				[Address(RVA = "0x101DAD4", Offset = "0x101DAD4", VA = "0x101DAD4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000210")]
			[Address(RVA = "0x101CAF4", Offset = "0x101CAF4", VA = "0x101CAF4")]
			[DebuggerHidden]
			public <AutoSaveGame>d__163(int <>1__state)
			{
			}

			[Token(Token = "0x6000211")]
			[Address(RVA = "0x101D998", Offset = "0x101D998", VA = "0x101D998", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000212")]
			[Address(RVA = "0x101D99C", Offset = "0x101D99C", VA = "0x101D99C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000214")]
			[Address(RVA = "0x101DA94", Offset = "0x101DA94", VA = "0x101DA94", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200003E")]
		[CompilerGenerated]
		private sealed class <TrackHotkeyUsage>d__164 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000128")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000129")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400012A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private SaveSettings <settings>5__2;

			[Token(Token = "0x1700004F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000219")]
				[Address(RVA = "0x101DE94", Offset = "0x101DE94", VA = "0x101DE94", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000050")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600021B")]
				[Address(RVA = "0x101DEDC", Offset = "0x101DEDC", VA = "0x101DEDC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000216")]
			[Address(RVA = "0x101CB1C", Offset = "0x101CB1C", VA = "0x101CB1C")]
			[DebuggerHidden]
			public <TrackHotkeyUsage>d__164(int <>1__state)
			{
			}

			[Token(Token = "0x6000217")]
			[Address(RVA = "0x101DADC", Offset = "0x101DADC", VA = "0x101DADC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000218")]
			[Address(RVA = "0x101DAE0", Offset = "0x101DAE0", VA = "0x101DAE0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600021A")]
			[Address(RVA = "0x101DE9C", Offset = "0x101DE9C", VA = "0x101DE9C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200003F")]
		[CompilerGenerated]
		private sealed class <IncrementTimePlayed>d__165 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400012B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400012C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400012D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private WaitForSeconds <incrementSecond>5__2;

			[Token(Token = "0x17000051")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600021F")]
				[Address(RVA = "0x101E038", Offset = "0x101E038", VA = "0x101E038", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000052")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000221")]
				[Address(RVA = "0x101E080", Offset = "0x101E080", VA = "0x101E080", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600021C")]
			[Address(RVA = "0x101CB44", Offset = "0x101CB44", VA = "0x101CB44")]
			[DebuggerHidden]
			public <IncrementTimePlayed>d__165(int <>1__state)
			{
			}

			[Token(Token = "0x600021D")]
			[Address(RVA = "0x101DEE4", Offset = "0x101DEE4", VA = "0x101DEE4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600021E")]
			[Address(RVA = "0x101DEE8", Offset = "0x101DEE8", VA = "0x101DEE8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000220")]
			[Address(RVA = "0x101E040", Offset = "0x101E040", VA = "0x101E040", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static SaveMaster instance;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Dictionary<string, int> loadedSceneNames;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal static Dictionary<int, SceneInformation> loadedScenes;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static HashSet<int> multiLoadedScenes;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static Dictionary<int, SaveInstanceManager> saveInstanceManagers;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static bool isQuittingGame;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static SaveGame activeSaveGame;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static int activeSlot;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private static bool invokedWritingToDiskEvent;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static HashSet<Saveable> saveables;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static HashSet<int> initiallyLoadedScenes;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static bool disableAutoSave;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private static SlotChangeInfo initialSlotChangeInfo;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static Dictionary<string, Func<string, GameObject>> customPrefabSpawners;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Action<int, int> onSlotChangeBegin;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Action<int, int> onSlotChangeDone;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Action<int> onSyncLoadBegin;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Action<int> onSyncLoadDone;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Action<int> onSyncSaveBegin;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Action<int> onSyncSaveDone;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Action<int> onLoadingFromDiskBegin;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Action<int> onLoadingFromDiskDone;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Action<int> onWritingToDiskBegin;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Action<int> onWritingToDiskDone;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Action<int> onDeletedSave;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Action onDeletedAllSaves;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Action<Scene, int> onStartSpawningInstances;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Action<Scene> onFinishSpawningInstances;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Action<Scene, SavedInstance> onSpawnedSavedInstance;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Action<Scene, int, int, float> onSpawnInstanceProgress;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private HashSet<Scene> throttledSpawningScenes;

		[Token(Token = "0x1700003C")]
		private static bool AutoSaveOnExit
		{
			[Token(Token = "0x6000198")]
			[Address(RVA = "0x1017C44", Offset = "0x1017C44", VA = "0x1017C44")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003D")]
		public static Action<int, int> OnSlotChangeBegin
		{
			[Token(Token = "0x60001E5")]
			[Address(RVA = "0x10190A8", Offset = "0x10190A8", VA = "0x10190A8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001E6")]
			[Address(RVA = "0x101BEAC", Offset = "0x101BEAC", VA = "0x101BEAC")]
			set
			{
			}
		}

		[Token(Token = "0x1700003E")]
		public static Action<int, int> OnSlotChangeDone
		{
			[Token(Token = "0x60001E7")]
			[Address(RVA = "0x10191D4", Offset = "0x10191D4", VA = "0x10191D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001E8")]
			[Address(RVA = "0x101BF18", Offset = "0x101BF18", VA = "0x101BF18")]
			set
			{
			}
		}

		[Token(Token = "0x1700003F")]
		public static Action<int> OnSyncSaveBegin
		{
			[Token(Token = "0x60001E9")]
			[Address(RVA = "0x101A0E0", Offset = "0x101A0E0", VA = "0x101A0E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001EA")]
			[Address(RVA = "0x101BF84", Offset = "0x101BF84", VA = "0x101BF84")]
			set
			{
			}
		}

		[Token(Token = "0x17000040")]
		public static Action<int> OnSyncSaveDone
		{
			[Token(Token = "0x60001EB")]
			[Address(RVA = "0x101A144", Offset = "0x101A144", VA = "0x101A144")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001EC")]
			[Address(RVA = "0x101BFF0", Offset = "0x101BFF0", VA = "0x101BFF0")]
			set
			{
			}
		}

		[Token(Token = "0x17000041")]
		public static Action<int> OnSyncLoadBegin
		{
			[Token(Token = "0x60001ED")]
			[Address(RVA = "0x101A738", Offset = "0x101A738", VA = "0x101A738")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001EE")]
			[Address(RVA = "0x101C05C", Offset = "0x101C05C", VA = "0x101C05C")]
			set
			{
			}
		}

		[Token(Token = "0x17000042")]
		public static Action<int> OnSyncLoadDone
		{
			[Token(Token = "0x60001EF")]
			[Address(RVA = "0x101A79C", Offset = "0x101A79C", VA = "0x101A79C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001F0")]
			[Address(RVA = "0x101C0C8", Offset = "0x101C0C8", VA = "0x101C0C8")]
			set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public static Action<int> OnLoadingFromDiskBegin
		{
			[Token(Token = "0x60001F1")]
			[Address(RVA = "0x101910C", Offset = "0x101910C", VA = "0x101910C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001F2")]
			[Address(RVA = "0x101C134", Offset = "0x101C134", VA = "0x101C134")]
			set
			{
			}
		}

		[Token(Token = "0x17000044")]
		public static Action<int> OnLoadingFromDiskDone
		{
			[Token(Token = "0x60001F3")]
			[Address(RVA = "0x1019170", Offset = "0x1019170", VA = "0x1019170")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001F4")]
			[Address(RVA = "0x101C1A0", Offset = "0x101C1A0", VA = "0x101C1A0")]
			set
			{
			}
		}

		[Token(Token = "0x17000045")]
		public static Action<int> OnWritingToDiskBegin
		{
			[Token(Token = "0x60001F5")]
			[Address(RVA = "0x1019A18", Offset = "0x1019A18", VA = "0x1019A18")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001F6")]
			[Address(RVA = "0x101C20C", Offset = "0x101C20C", VA = "0x101C20C")]
			set
			{
			}
		}

		[Token(Token = "0x17000046")]
		public static Action<int> OnWritingToDiskDone
		{
			[Token(Token = "0x60001F7")]
			[Address(RVA = "0x1019C54", Offset = "0x1019C54", VA = "0x1019C54")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001F8")]
			[Address(RVA = "0x101C278", Offset = "0x101C278", VA = "0x101C278")]
			set
			{
			}
		}

		[Token(Token = "0x17000047")]
		public static Action<int> OnDeletedSave
		{
			[Token(Token = "0x60001F9")]
			[Address(RVA = "0x101A07C", Offset = "0x101A07C", VA = "0x101A07C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001FA")]
			[Address(RVA = "0x101C2E4", Offset = "0x101C2E4", VA = "0x101C2E4")]
			set
			{
			}
		}

		[Token(Token = "0x17000048")]
		public static Action OnDeletedAllSaves
		{
			[Token(Token = "0x60001FB")]
			[Address(RVA = "0x101A018", Offset = "0x101A018", VA = "0x101A018")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001FC")]
			[Address(RVA = "0x101C350", Offset = "0x101C350", VA = "0x101C350")]
			set
			{
			}
		}

		[Token(Token = "0x17000049")]
		public static Action<Scene, int> OnStartSpawningInstances
		{
			[Token(Token = "0x60001FD")]
			[Address(RVA = "0x1008DD4", Offset = "0x1008DD4", VA = "0x1008DD4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001FE")]
			[Address(RVA = "0x1008E38", Offset = "0x1008E38", VA = "0x1008E38")]
			set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public static Action<Scene, int, int, float> OnSpawnInstanceProgress
		{
			[Token(Token = "0x60001FF")]
			[Address(RVA = "0x1008F74", Offset = "0x1008F74", VA = "0x1008F74")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000200")]
			[Address(RVA = "0x1008FD8", Offset = "0x1008FD8", VA = "0x1008FD8")]
			set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		public static Action<Scene> OnFinishSpawningInstances
		{
			[Token(Token = "0x6000201")]
			[Address(RVA = "0x1008EA4", Offset = "0x1008EA4", VA = "0x1008EA4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000202")]
			[Address(RVA = "0x1008F08", Offset = "0x1008F08", VA = "0x1008F08")]
			set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		public static Action<Scene, SavedInstance> OnSpawnedSavedInstance
		{
			[Token(Token = "0x6000203")]
			[Address(RVA = "0x101C3BC", Offset = "0x101C3BC", VA = "0x101C3BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000204")]
			[Address(RVA = "0x101C420", Offset = "0x101C420", VA = "0x101C420")]
			set
			{
			}
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x1017CBC", Offset = "0x1017CBC", VA = "0x1017CBC")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void CreateInstance()
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x1017FAC", Offset = "0x1017FAC", VA = "0x1017FAC")]
		internal static string GetSceneName(int sceneInstanceId)
		{
			return null;
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x10180B0", Offset = "0x10180B0", VA = "0x10180B0")]
		internal static SlotChangeInfo InitialSlotChangeInfo()
		{
			return default(SlotChangeInfo);
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x10089F0", Offset = "0x10089F0", VA = "0x10089F0")]
		public static void AddPrefabResourceLocation(string id, Func<string, GameObject> function)
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x101810C", Offset = "0x101810C", VA = "0x101810C")]
		public static void RemovePrefabResourceLocation(string id)
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x10181DC", Offset = "0x10181DC", VA = "0x10181DC")]
		internal static GameObject GetPrefabResource(string customSourceID, string id)
		{
			return null;
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x10182F8", Offset = "0x10182F8", VA = "0x10182F8")]
		private static void OnSceneUnloaded(Scene scene)
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x1018640", Offset = "0x1018640", VA = "0x1018640")]
		private static void OnSceneLoaded(Scene scene, LoadSceneMode arg1)
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x1018964", Offset = "0x1018964", VA = "0x1018964")]
		public static SaveInstanceManager SpawnInstanceManager(Scene scene, string id = "")
		{
			return null;
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x1018D68", Offset = "0x1018D68", VA = "0x1018D68")]
		public static bool IsComponentLoaded(ISaveable saveable)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x1018DC0", Offset = "0x1018DC0", VA = "0x1018DC0")]
		public static bool DeactivatedObjectExplicitly(GameObject gameObject)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x1018E58", Offset = "0x1018E58", VA = "0x1018E58")]
		public static int GetActiveSlot()
		{
			return default(int);
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x1018EB0", Offset = "0x1018EB0", VA = "0x1018EB0")]
		public static bool IsSlotLoaded()
		{
			return default(bool);
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x1018F38", Offset = "0x1018F38", VA = "0x1018F38")]
		public static bool HasUnusedSlots()
		{
			return default(bool);
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x1018F54", Offset = "0x1018F54", VA = "0x1018F54")]
		public static int[] GetUsedSlots()
		{
			return null;
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x1018F5C", Offset = "0x1018F5C", VA = "0x1018F5C")]
		public static bool IsSlotUsed(int slot)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x1018F64", Offset = "0x1018F64", VA = "0x1018F64")]
		public static bool IsSlotValid(int slot)
		{
			return default(bool);
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x1018F94", Offset = "0x1018F94", VA = "0x1018F94")]
		public static void ReloadActiveSaveFromDisk()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x101903C", Offset = "0x101903C", VA = "0x101903C")]
		public static int GetLastUsedValidSlot()
		{
			return default(int);
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x101535C", Offset = "0x101535C", VA = "0x101535C")]
		public static bool SetSlotToLastUsedSlot(bool notifyListeners)
		{
			return default(bool);
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x101544C", Offset = "0x101544C", VA = "0x101544C")]
		public static bool SetSlotToNewSlot(bool notifyListeners, out int slot)
		{
			return default(bool);
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x1015530", Offset = "0x1015530", VA = "0x1015530")]
		public static void ClearSlot(bool clearAllListeners = true, bool syncSave = true)
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x1016134", Offset = "0x1016134", VA = "0x1016134")]
		public static void SetSlotWithoutSave(int slot)
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x10162AC", Offset = "0x10162AC", VA = "0x10162AC")]
		public static void SetSlotToTemporarySlot(bool reloadSaveables, bool keepActiveSaveData = false)
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x1019238", Offset = "0x1019238", VA = "0x1019238")]
		public static TimeSpan? GetTimeSinceLastSave()
		{
			return null;
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x101939C", Offset = "0x101939C", VA = "0x101939C")]
		public static bool IsActiveSaveNewSave()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x1015C80", Offset = "0x1015C80", VA = "0x1015C80")]
		public static void SetSlot(int slot, bool reloadSaveables, [Optional] SaveGame saveGame, bool keepActiveSaveData = false, bool writeToDiskAfterChange = false)
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x10195F4", Offset = "0x10195F4", VA = "0x10195F4")]
		public static DateTime GetSaveCreationTime(int slot)
		{
			return default(DateTime);
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x101976C", Offset = "0x101976C", VA = "0x101976C")]
		public static DateTime GetSaveCreationTime()
		{
			return default(DateTime);
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x10197C4", Offset = "0x10197C4", VA = "0x10197C4")]
		public static TimeSpan GetSaveTimePlayed(int slot)
		{
			return default(TimeSpan);
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x1019898", Offset = "0x1019898", VA = "0x1019898")]
		public static TimeSpan GetSaveTimePlayed()
		{
			return default(TimeSpan);
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x10198F0", Offset = "0x10198F0", VA = "0x10198F0")]
		public static int GetSaveVersion(int slot)
		{
			return default(int);
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x10199C0", Offset = "0x10199C0", VA = "0x10199C0")]
		public static int GetSaveVersion()
		{
			return default(int);
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x10196C8", Offset = "0x10196C8", VA = "0x10196C8")]
		private static SaveGame GetSave(int slot, bool createIfEmpty = true)
		{
			return null;
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x10158B4", Offset = "0x10158B4", VA = "0x10158B4")]
		public static void WriteActiveSaveToDisk(bool syncActiveSaveables = false)
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x1009128", Offset = "0x1009128", VA = "0x1009128")]
		public static void WipeSceneData(string name, bool clearSceneSaveables = true)
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x1016424", Offset = "0x1016424", VA = "0x1016424")]
		public static void WipeSaveable(Saveable saveable, bool stopSaving = true)
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x101651C", Offset = "0x101651C", VA = "0x101651C")]
		public static void ClearListeners(bool syncSave)
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x10167C0", Offset = "0x10167C0", VA = "0x10167C0")]
		public static void SaveListener(Saveable saveable)
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x10168E0", Offset = "0x10168E0", VA = "0x10168E0")]
		public static void LoadListener(Saveable saveable)
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x1016A00", Offset = "0x1016A00", VA = "0x1016A00")]
		public static void ReloadListener(Saveable saveable)
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x1019D60", Offset = "0x1019D60", VA = "0x1019D60")]
		public static void AddListener(Saveable saveable)
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x1019E60", Offset = "0x1019E60", VA = "0x1019E60")]
		public static void AddListener(Saveable saveable, bool loadData)
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x1016B30", Offset = "0x1016B30", VA = "0x1016B30")]
		public static void RemoveListener(Saveable saveable)
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x1019CB8", Offset = "0x1019CB8", VA = "0x1019CB8")]
		public static void RemoveListener(Saveable saveable, bool saveData)
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x1016D80", Offset = "0x1016D80", VA = "0x1016D80")]
		public static void ClearActiveSaveData(bool removeListeners = true, bool reloadActiveScenes = false)
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x1019F08", Offset = "0x1019F08", VA = "0x1019F08")]
		public static void DeleteAllSaves()
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x1015728", Offset = "0x1015728", VA = "0x1015728")]
		public static void DeleteSave(int slot)
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x101567C", Offset = "0x101567C", VA = "0x101567C")]
		public static void DeleteSave()
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x10171DC", Offset = "0x10171DC", VA = "0x10171DC")]
		public static void SyncSave()
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x101A1A8", Offset = "0x101A1A8", VA = "0x101A1A8")]
		public static void SyncCollectiblesSave()
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x10175E4", Offset = "0x10175E4", VA = "0x10175E4")]
		public static void SyncLoad()
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x10179EC", Offset = "0x10179EC", VA = "0x10179EC")]
		public static void SyncReset()
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x1008AD4", Offset = "0x1008AD4", VA = "0x1008AD4")]
		public static GameObject SpawnSavedPrefab(InstanceSource source, string filePath, string customSource = "", [Optional] Scene scene, string userTag = "")
		{
			return null;
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x101A800", Offset = "0x101A800", VA = "0x101A800")]
		private static string GetSaveFileName(int slot, string fileName)
		{
			return null;
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x101A940", Offset = "0x101A940", VA = "0x101A940")]
		public static bool GetMetaData(string id, Texture2D tex, int slot = -1, string fileName = "")
		{
			return default(bool);
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x101AB30", Offset = "0x101AB30", VA = "0x101AB30")]
		public static bool GetMetaData(string id, out byte[] data, int slot = -1, string fileName = "")
		{
			return default(bool);
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x101AD30", Offset = "0x101AD30", VA = "0x101AD30")]
		public static bool GetMetaData(string id, out string data, int slot = -1, string fileName = "")
		{
			return default(bool);
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x1019A7C", Offset = "0x1019A7C", VA = "0x1019A7C")]
		public static void SetMetaData(string id, string data, int slot = -1, string fileName = "")
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x101AF30", Offset = "0x101AF30", VA = "0x101AF30")]
		public static void SetMetaData(string id, Texture2D data, int slot = -1, string fileName = "")
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x101B108", Offset = "0x101B108", VA = "0x101B108")]
		public static void SetMetaData(string id, byte[] data, int slot = -1, string fileName = "")
		{
		}

		[Token(Token = "0x60001D6")]
		public static bool GetSaveableData<T>(int slot, string saveableId, string componentId, out T data)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D7")]
		public static bool GetSaveableData<T>(string saveableId, string componentId, out T data)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x101B2E0", Offset = "0x101B2E0", VA = "0x101B2E0")]
		public static void SetInt(string key, int value)
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x101B4E0", Offset = "0x101B4E0", VA = "0x101B4E0")]
		public static int GetInt(string key, int defaultValue = -1)
		{
			return default(int);
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x101B5E4", Offset = "0x101B5E4", VA = "0x101B5E4")]
		public static void SetFloat(string key, float value)
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x101B6E8", Offset = "0x101B6E8", VA = "0x101B6E8")]
		public static float GetFloat(string key, float defaultValue = -1f)
		{
			return default(float);
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x101B7EC", Offset = "0x101B7EC", VA = "0x101B7EC")]
		public static void SetBool(string key, bool value)
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x101B8F4", Offset = "0x101B8F4", VA = "0x101B8F4")]
		public static bool GetBool(string key, bool defaultValue = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x101BA1C", Offset = "0x101BA1C", VA = "0x101BA1C")]
		public static void SetString(string key, string value)
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x101BB1C", Offset = "0x101BB1C", VA = "0x101BB1C")]
		public static string GetString(string key, string defaultValue = "")
		{
			return null;
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x101B3E4", Offset = "0x101B3E4", VA = "0x101B3E4")]
		private static bool HasActiveSaveLogAction(string action)
		{
			return default(bool);
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x10194C0", Offset = "0x10194C0", VA = "0x10194C0")]
		private static void ClearActiveSavedPrefabs()
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x101BC10", Offset = "0x101BC10", VA = "0x101BC10")]
		public static string GetActiveSaveFilePath()
		{
			return null;
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x101BD1C", Offset = "0x101BD1C", VA = "0x101BD1C")]
		public static string ExportActiveSaveToWebJSON(bool syncSaveables = true)
		{
			return null;
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x101BE38", Offset = "0x101BE38", VA = "0x101BE38")]
		public static void OverwriteActiveSaveWithWebJSON(string json)
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x101C48C", Offset = "0x101C48C", VA = "0x101C48C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x101C930", Offset = "0x101C930", VA = "0x101C930")]
		private void StartSpawningInstances(Scene arg1, int arg2)
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x101CA18", Offset = "0x101CA18", VA = "0x101CA18")]
		private void FinishSpawningInstances(Scene obj)
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x101CAF0", Offset = "0x101CAF0", VA = "0x101CAF0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x101C8D0", Offset = "0x101C8D0", VA = "0x101C8D0")]
		[IteratorStateMachine(typeof(<AutoSaveGame>d__163))]
		private IEnumerator AutoSaveGame()
		{
			return null;
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x101C870", Offset = "0x101C870", VA = "0x101C870")]
		[IteratorStateMachine(typeof(<TrackHotkeyUsage>d__164))]
		private IEnumerator TrackHotkeyUsage()
		{
			return null;
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x101C810", Offset = "0x101C810", VA = "0x101C810")]
		[IteratorStateMachine(typeof(<IncrementTimePlayed>d__165))]
		private IEnumerator IncrementTimePlayed()
		{
			return null;
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x101CB6C", Offset = "0x101CB6C", VA = "0x101CB6C")]
		private void OnApplicationPause(bool pause)
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x101CBE8", Offset = "0x101CBE8", VA = "0x101CBE8")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x101CD18", Offset = "0x101CD18", VA = "0x101CD18")]
		public SaveMaster()
		{
		}
	}
}
namespace Lowscope.Saving.Examples
{
	[Token(Token = "0x2000041")]
	[AddComponentMenu("")]
	public class ExampleCustomPrefabResource : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000042")]
		private class Resource
		{
			[Token(Token = "0x4000141")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string id;

			[Token(Token = "0x4000142")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GameObject prefab;

			[Token(Token = "0x6000238")]
			[Address(RVA = "0x101E3D4", Offset = "0x101E3D4", VA = "0x101E3D4")]
			public Resource()
			{
			}
		}

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Resource[] resources;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<string, GameObject> cachedPrefabs;

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x101E140", Offset = "0x101E140", VA = "0x101E140")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x101E270", Offset = "0x101E270", VA = "0x101E270")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x101E2D4", Offset = "0x101E2D4", VA = "0x101E2D4")]
		private GameObject LoadPrefab(string id)
		{
			return null;
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x101E34C", Offset = "0x101E34C", VA = "0x101E34C")]
		public ExampleCustomPrefabResource()
		{
		}
	}
	[Token(Token = "0x2000043")]
	[AddComponentMenu("")]
	public class ExampleGameBomb : MonoBehaviour, ISaveable
	{
		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject explosionEffectPrefab;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LayerMask affectedByExplosion;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform meshRenderer;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AudioSource audioSource;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AudioClip audioExplode;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float activeDetonationTime;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool hasExploded;

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x101E42C", Offset = "0x101E42C", VA = "0x101E42C")]
		private void Update()
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x101E760", Offset = "0x101E760", VA = "0x101E760", Slot = "5")]
		public void OnLoad(string data)
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x101E828", Offset = "0x101E828", VA = "0x101E828", Slot = "4")]
		public string OnSave()
		{
			return null;
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x101E834", Offset = "0x101E834", VA = "0x101E834", Slot = "6")]
		public bool OnSaveCondition()
		{
			return default(bool);
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x101E83C", Offset = "0x101E83C", VA = "0x101E83C")]
		public ExampleGameBomb()
		{
		}
	}
	[Token(Token = "0x2000044")]
	[AddComponentMenu("")]
	public class ExampleGameBoss : MonoBehaviour, ExampleGameIDamageable, ExampleGameIBlockable, ISaveable
	{
		[Serializable]
		[Token(Token = "0x2000045")]
		public struct SaveData
		{
			[Token(Token = "0x400015F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public State activeState;

			[Token(Token = "0x4000160")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public State targetState;

			[Token(Token = "0x4000161")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float totalTransitionTime;

			[Token(Token = "0x4000162")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float activeTransitionTime;

			[Token(Token = "0x4000163")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int currentHealth;

			[Token(Token = "0x4000164")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 fromPosition;

			[Token(Token = "0x4000165")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 randomFlyOffset;

			[Token(Token = "0x4000166")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 targetPosition;

			[Token(Token = "0x4000167")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool isParticleAuraActive;

			[Token(Token = "0x4000168")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
			public bool isParticleDizzyActive;

			[Token(Token = "0x4000169")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
			public bool gatePlatformHidden;

			[Token(Token = "0x400016A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 position;

			[Token(Token = "0x400016B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Quaternion rotation;

			[Token(Token = "0x400016C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Quaternion localHeadRotation;

			[Token(Token = "0x400016D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Quaternion localBodyRotation;
		}

		[Token(Token = "0x2000046")]
		public enum State
		{
			[Token(Token = "0x400016F")]
			None,
			[Token(Token = "0x4000170")]
			Idle,
			[Token(Token = "0x4000171")]
			Dizzy,
			[Token(Token = "0x4000172")]
			Preparing,
			[Token(Token = "0x4000173")]
			Attacking,
			[Token(Token = "0x4000174")]
			Dead
		}

		[Token(Token = "0x2000047")]
		[CompilerGenerated]
		private sealed class <MoveGatePlatformAway>d__25 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000175")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000176")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000177")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ExampleGameBoss <>4__this;

			[Token(Token = "0x4000178")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x4000179")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Vector3 <from>5__3;

			[Token(Token = "0x400017A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Vector3 <to>5__4;

			[Token(Token = "0x17000053")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600024E")]
				[Address(RVA = "0x10200C4", Offset = "0x10200C4", VA = "0x10200C4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000054")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000250")]
				[Address(RVA = "0x102010C", Offset = "0x102010C", VA = "0x102010C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600024B")]
			[Address(RVA = "0x101EDC0", Offset = "0x101EDC0", VA = "0x101EDC0")]
			[DebuggerHidden]
			public <MoveGatePlatformAway>d__25(int <>1__state)
			{
			}

			[Token(Token = "0x600024C")]
			[Address(RVA = "0x101FE58", Offset = "0x101FE58", VA = "0x101FE58", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600024D")]
			[Address(RVA = "0x101FE5C", Offset = "0x101FE5C", VA = "0x101FE5C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600024F")]
			[Address(RVA = "0x10200CC", Offset = "0x10200CC", VA = "0x10200CC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000048")]
		[CompilerGenerated]
		private sealed class <PunchScale>d__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400017B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400017C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400017D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ExampleGameBoss <>4__this;

			[Token(Token = "0x400017E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 intensity;

			[Token(Token = "0x400017F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float duration;

			[Token(Token = "0x4000180")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float <t>5__2;

			[Token(Token = "0x17000055")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000254")]
				[Address(RVA = "0x10202B0", Offset = "0x10202B0", VA = "0x10202B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000056")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000256")]
				[Address(RVA = "0x10202F8", Offset = "0x10202F8", VA = "0x10202F8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000251")]
			[Address(RVA = "0x101F964", Offset = "0x101F964", VA = "0x101F964")]
			[DebuggerHidden]
			public <PunchScale>d__30(int <>1__state)
			{
			}

			[Token(Token = "0x6000252")]
			[Address(RVA = "0x1020114", Offset = "0x1020114", VA = "0x1020114", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000253")]
			[Address(RVA = "0x1020118", Offset = "0x1020118", VA = "0x1020118", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000255")]
			[Address(RVA = "0x10202B8", Offset = "0x10202B8", VA = "0x10202B8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform gatePlatform;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform body;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform head;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform[] flyPoints;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private LayerMask obstacleLayer;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private LayerMask playerLayer;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ParticleSystem particleSystenAura;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ParticleSystem particleSystemDizzy;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private int totalHealth;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject gameBeatMessageScreen;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int currentHealth;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private State activeState;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private State targetState;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 fromPosition;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 randomFlyOffset;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 targetPosition;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float totalTransitionTime;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private float activeTransitionTime;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool gatePlatformHidden;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private GameObject player;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private bool loadedGame;

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x101E84C", Offset = "0x101E84C", VA = "0x101E84C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x101E8AC", Offset = "0x101E8AC", VA = "0x101E8AC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x101ED4C", Offset = "0x101ED4C", VA = "0x101ED4C")]
		[IteratorStateMachine(typeof(<MoveGatePlatformAway>d__25))]
		private IEnumerator MoveGatePlatformAway()
		{
			return null;
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x101E8E8", Offset = "0x101E8E8", VA = "0x101E8E8")]
		private void SetState(State state)
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x101EDE8", Offset = "0x101EDE8", VA = "0x101EDE8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x101F538", Offset = "0x101F538", VA = "0x101F538")]
		private void LookAt(Vector3 target, Vector3 offset, float speed = 1f)
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x101F854", Offset = "0x101F854", VA = "0x101F854", Slot = "4")]
		public void Damage(int amount)
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x101F8C8", Offset = "0x101F8C8", VA = "0x101F8C8")]
		[IteratorStateMachine(typeof(<PunchScale>d__30))]
		private IEnumerator PunchScale(float duration, Vector3 intensity)
		{
			return null;
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x101F98C", Offset = "0x101F98C", VA = "0x101F98C", Slot = "5")]
		public bool BlockPlayer()
		{
			return default(bool);
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x101F994", Offset = "0x101F994", VA = "0x101F994", Slot = "6")]
		public string OnSave()
		{
			return null;
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x101FBCC", Offset = "0x101FBCC", VA = "0x101FBCC", Slot = "7")]
		public void OnLoad(string data)
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x101FE48", Offset = "0x101FE48", VA = "0x101FE48", Slot = "8")]
		public bool OnSaveCondition()
		{
			return default(bool);
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x101FE50", Offset = "0x101FE50", VA = "0x101FE50")]
		public ExampleGameBoss()
		{
		}
	}
	[Token(Token = "0x2000049")]
	[AddComponentMenu("")]
	public class ExampleGameBreakablePlatform : MonoBehaviour, ExampleGameIDamageable
	{
		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool isBroken;

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x1020300", Offset = "0x1020300", VA = "0x1020300", Slot = "4")]
		public void Damage(int amount)
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x1020334", Offset = "0x1020334", VA = "0x1020334")]
		public ExampleGameBreakablePlatform()
		{
		}
	}
	[Token(Token = "0x200004A")]
	[AddComponentMenu("")]
	public class ExampleGameButtonWobble : MonoBehaviour
	{
		[Token(Token = "0x200004B")]
		[CompilerGenerated]
		private sealed class <WobbleButton>d__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000185")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000186")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000187")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform button;

			[Token(Token = "0x4000188")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ExampleGameButtonWobble <>4__this;

			[Token(Token = "0x4000189")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <customTime>5__2;

			[Token(Token = "0x17000057")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000260")]
				[Address(RVA = "0x1020580", Offset = "0x1020580", VA = "0x1020580", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000058")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000262")]
				[Address(RVA = "0x10205C8", Offset = "0x10205C8", VA = "0x10205C8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600025D")]
			[Address(RVA = "0x1020414", Offset = "0x1020414", VA = "0x1020414")]
			[DebuggerHidden]
			public <WobbleButton>d__5(int <>1__state)
			{
			}

			[Token(Token = "0x600025E")]
			[Address(RVA = "0x1020450", Offset = "0x1020450", VA = "0x1020450", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600025F")]
			[Address(RVA = "0x1020454", Offset = "0x1020454", VA = "0x1020454", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000261")]
			[Address(RVA = "0x1020588", Offset = "0x1020588", VA = "0x1020588", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform buttonTransform;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float distance;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float frequency;

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x102033C", Offset = "0x102033C", VA = "0x102033C")]
		private void Reset()
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x1020360", Offset = "0x1020360", VA = "0x1020360")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x1020384", Offset = "0x1020384", VA = "0x1020384")]
		[IteratorStateMachine(typeof(<WobbleButton>d__5))]
		private IEnumerator WobbleButton(Transform button)
		{
			return null;
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x102043C", Offset = "0x102043C", VA = "0x102043C")]
		public ExampleGameButtonWobble()
		{
		}
	}
	[Token(Token = "0x200004C")]
	[AddComponentMenu("")]
	public class ExampleGameCamera : MonoBehaviour
	{
		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static ExampleGameCamera instance;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform target;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector3 offset;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float speed;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float warpDelta;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float activeShake;

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x10205D0", Offset = "0x10205D0", VA = "0x10205D0")]
		public static void ShakeCamera()
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x102066C", Offset = "0x102066C", VA = "0x102066C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x10206CC", Offset = "0x10206CC", VA = "0x10206CC")]
		private void WarpToPlayer()
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x1020724", Offset = "0x1020724", VA = "0x1020724")]
		private void Update()
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x10208A0", Offset = "0x10208A0", VA = "0x10208A0")]
		public ExampleGameCamera()
		{
		}
	}
	[Token(Token = "0x200004D")]
	[AddComponentMenu("")]
	public class ExampleGameDamageScreen : MonoBehaviour
	{
		[Token(Token = "0x200004E")]
		[CompilerGenerated]
		private sealed class <DisplayDamageCoroutine>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000192")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000193")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000194")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ExampleGameDamageScreen <>4__this;

			[Token(Token = "0x4000195")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float duration;

			[Token(Token = "0x4000196")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <t>5__2;

			[Token(Token = "0x4000197")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Color <activeColor>5__3;

			[Token(Token = "0x17000059")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600026E")]
				[Address(RVA = "0x1020AC4", Offset = "0x1020AC4", VA = "0x1020AC4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700005A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000270")]
				[Address(RVA = "0x1020B0C", Offset = "0x1020B0C", VA = "0x1020B0C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600026B")]
			[Address(RVA = "0x1020984", Offset = "0x1020984", VA = "0x1020984")]
			[DebuggerHidden]
			public <DisplayDamageCoroutine>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x600026C")]
			[Address(RVA = "0x10209B4", Offset = "0x10209B4", VA = "0x10209B4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600026D")]
			[Address(RVA = "0x10209B8", Offset = "0x10209B8", VA = "0x10209B8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600026F")]
			[Address(RVA = "0x1020ACC", Offset = "0x1020ACC", VA = "0x1020ACC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Canvas canvas;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image image;

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x10208B4", Offset = "0x10208B4", VA = "0x10208B4")]
		public void DisplayDamage(float duration)
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x1020900", Offset = "0x1020900", VA = "0x1020900")]
		[IteratorStateMachine(typeof(<DisplayDamageCoroutine>d__3))]
		private IEnumerator DisplayDamageCoroutine(float duration)
		{
			return null;
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x10209AC", Offset = "0x10209AC", VA = "0x10209AC")]
		public ExampleGameDamageScreen()
		{
		}
	}
	[Token(Token = "0x200004F")]
	public static class ExampleGameEasings
	{
		[Token(Token = "0x6000271")]
		[Address(RVA = "0x101F79C", Offset = "0x101F79C", VA = "0x101F79C")]
		public static float EaseOutBounce(float k)
		{
			return default(float);
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x1020B14", Offset = "0x1020B14", VA = "0x1020B14")]
		public static float QuadraticEaseOut(float p)
		{
			return default(float);
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x101F75C", Offset = "0x101F75C", VA = "0x101F75C")]
		public static float QuadraticInOut(float k)
		{
			return default(float);
		}
	}
	[Token(Token = "0x2000050")]
	[AddComponentMenu("")]
	public class ExampleGameGate : MonoBehaviour, ExampleGameIInteractable, ISaveable
	{
		[Token(Token = "0x2000051")]
		[CompilerGenerated]
		private sealed class <ScaleTransform>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400019F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform transform;

			[Token(Token = "0x40001A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 from;

			[Token(Token = "0x40001A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public Vector3 to;

			[Token(Token = "0x40001A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public float duration;

			[Token(Token = "0x40001A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float <t>5__2;

			[Token(Token = "0x1700005B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000281")]
				[Address(RVA = "0x10212B4", Offset = "0x10212B4", VA = "0x10212B4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700005C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000283")]
				[Address(RVA = "0x10212FC", Offset = "0x10212FC", VA = "0x10212FC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600027E")]
			[Address(RVA = "0x10210DC", Offset = "0x10210DC", VA = "0x10210DC")]
			[DebuggerHidden]
			public <ScaleTransform>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x600027F")]
			[Address(RVA = "0x10211CC", Offset = "0x10211CC", VA = "0x10211CC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000280")]
			[Address(RVA = "0x10211D0", Offset = "0x10211D0", VA = "0x10211D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000282")]
			[Address(RVA = "0x10212BC", Offset = "0x10212BC", VA = "0x10212BC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000052")]
		[CompilerGenerated]
		private sealed class <ShakeFence>d__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ExampleGameGate <>4__this;

			[Token(Token = "0x40001A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x40001AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <duration>5__3;

			[Token(Token = "0x1700005D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000287")]
				[Address(RVA = "0x1021498", Offset = "0x1021498", VA = "0x1021498", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700005E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000289")]
				[Address(RVA = "0x10214E0", Offset = "0x10214E0", VA = "0x10214E0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000284")]
			[Address(RVA = "0x1021104", Offset = "0x1021104", VA = "0x1021104")]
			[DebuggerHidden]
			public <ShakeFence>d__12(int <>1__state)
			{
			}

			[Token(Token = "0x6000285")]
			[Address(RVA = "0x1021304", Offset = "0x1021304", VA = "0x1021304", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000286")]
			[Address(RVA = "0x1021308", Offset = "0x1021308", VA = "0x1021308", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000288")]
			[Address(RVA = "0x10214A0", Offset = "0x10214A0", VA = "0x10214A0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int gemCount;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject gemVisualizer;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject fence;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ExampleGameWarpPoint warpPoint;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AudioSource audioSource;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private AudioClip audioOpen;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool isOpen;

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x1020B24", Offset = "0x1020B24", VA = "0x1020B24", Slot = "4")]
		public void OnInteract(GameObject interactor)
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x1020CC8", Offset = "0x1020CC8", VA = "0x1020CC8")]
		private void SetOpen()
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x1020D0C", Offset = "0x1020D0C", VA = "0x1020D0C")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x1020F54", Offset = "0x1020F54", VA = "0x1020F54")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x1020E94", Offset = "0x1020E94", VA = "0x1020E94")]
		[IteratorStateMachine(typeof(<ScaleTransform>d__11))]
		private IEnumerator ScaleTransform(Transform transform, Vector3 from, Vector3 to, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x1020C54", Offset = "0x1020C54", VA = "0x1020C54")]
		[IteratorStateMachine(typeof(<ShakeFence>d__12))]
		private IEnumerator ShakeFence()
		{
			return null;
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x102112C", Offset = "0x102112C", VA = "0x102112C", Slot = "6")]
		public void OnLoad(string data)
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x10211B0", Offset = "0x10211B0", VA = "0x10211B0", Slot = "5")]
		public string OnSave()
		{
			return null;
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x10211BC", Offset = "0x10211BC", VA = "0x10211BC", Slot = "7")]
		public bool OnSaveCondition()
		{
			return default(bool);
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x10211C4", Offset = "0x10211C4", VA = "0x10211C4")]
		public ExampleGameGate()
		{
		}
	}
	[Token(Token = "0x2000053")]
	public interface ExampleGameIBlockable
	{
		[Token(Token = "0x600028A")]
		bool BlockPlayer();
	}
	[Token(Token = "0x2000054")]
	public interface ExampleGameIDamageable
	{
		[Token(Token = "0x600028B")]
		void Damage(int amount);
	}
	[Token(Token = "0x2000055")]
	public interface ExampleGameIInteractable
	{
		[Token(Token = "0x600028C")]
		void OnInteract(GameObject interactor);
	}
	[Token(Token = "0x2000056")]
	[AddComponentMenu("")]
	public class ExampleGameMainMenu : MonoBehaviour
	{
		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Button buttonContinue;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button buttonNew;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Button buttonLoad;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Button buttonAbout;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Button buttonExit;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private string startSceneName;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ExampleGameSaveMenu saveLoadMenu;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject creditsMenu;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Button creditsButtonExit;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Button creditsButtonSaveComponent;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Button creditsButtonKenney;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Button creditsButtonKay;

		[Token(Token = "0x40001B7")]
		private const string urlSaveSystem = "https://assetstore.unity.com/packages/tools/utilities/component-save-system-159191?aid=1101lHUQ";

		[Token(Token = "0x40001B8")]
		private const string urlKenney = "https://kenney.nl";

		[Token(Token = "0x40001B9")]
		private const string urlKay = "https://kaylousberg.itch.io/";

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int lastUsedSlot;

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x10214E8", Offset = "0x10214E8", VA = "0x10214E8")]
		private void Awake()
		{
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x102186C", Offset = "0x102186C", VA = "0x102186C")]
		private void OpenURL(string url)
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x1021878", Offset = "0x1021878", VA = "0x1021878")]
		private void OnPressContinue()
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x10218C8", Offset = "0x10218C8", VA = "0x10218C8")]
		private void OnPressNewGame()
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x1021954", Offset = "0x1021954", VA = "0x1021954")]
		private void OnPressLoadGame()
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x1021974", Offset = "0x1021974", VA = "0x1021974")]
		private void OnPressAbout()
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x10219B4", Offset = "0x10219B4", VA = "0x10219B4")]
		private void OnPressExit()
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x10219BC", Offset = "0x10219BC", VA = "0x10219BC")]
		public ExampleGameMainMenu()
		{
		}
	}
	[Token(Token = "0x2000057")]
	[AddComponentMenu("")]
	public class ExampleGameObjectPulser : MonoBehaviour
	{
		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool applyRotation;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Vector3 rotationRange;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float modulation;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform mesh;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool hoverHeight;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float hoverHeightDistance;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float hoverHeightModulation;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private Vector3 hoverHeightOffset;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector3 timeOffset;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 velocityOffset;

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x1021ABC", Offset = "0x1021ABC", VA = "0x1021ABC")]
		private void Awake()
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x1021BFC", Offset = "0x1021BFC", VA = "0x1021BFC")]
		private void Update()
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x1021D78", Offset = "0x1021D78", VA = "0x1021D78")]
		public ExampleGameObjectPulser()
		{
		}
	}
	[Token(Token = "0x2000058")]
	[AddComponentMenu("")]
	public class ExampleGamePauseMenu : MonoBehaviour
	{
		[Token(Token = "0x2000059")]
		[CompilerGenerated]
		private sealed class <FadeCanvas>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ExampleGamePauseMenu <>4__this;

			[Token(Token = "0x40001D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float target;

			[Token(Token = "0x40001D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float duration;

			[Token(Token = "0x40001D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <activeAlpha>5__2;

			[Token(Token = "0x40001D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <t>5__3;

			[Token(Token = "0x1700005F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60002AA")]
				[Address(RVA = "0x10226C4", Offset = "0x10226C4", VA = "0x10226C4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000060")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002AC")]
				[Address(RVA = "0x102270C", Offset = "0x102270C", VA = "0x102270C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002A7")]
			[Address(RVA = "0x1022328", Offset = "0x1022328", VA = "0x1022328")]
			[DebuggerHidden]
			public <FadeCanvas>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x60002A8")]
			[Address(RVA = "0x1022550", Offset = "0x1022550", VA = "0x1022550", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60002A9")]
			[Address(RVA = "0x1022554", Offset = "0x1022554", VA = "0x1022554", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002AB")]
			[Address(RVA = "0x10226CC", Offset = "0x10226CC", VA = "0x10226CC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200005A")]
		[CompilerGenerated]
		private sealed class <MoveUpButton>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RectTransform button;

			[Token(Token = "0x40001DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ExampleGamePauseMenu <>4__this;

			[Token(Token = "0x40001DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float startPause;

			[Token(Token = "0x40001DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float duration;

			[Token(Token = "0x40001DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float <t>5__2;

			[Token(Token = "0x40001DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector2 <targetPosition>5__3;

			[Token(Token = "0x40001E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private Vector2 <fromPosition>5__4;

			[Token(Token = "0x17000061")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60002B0")]
				[Address(RVA = "0x1022914", Offset = "0x1022914", VA = "0x1022914", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000062")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002B2")]
				[Address(RVA = "0x102295C", Offset = "0x102295C", VA = "0x102295C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002AD")]
			[Address(RVA = "0x1022350", Offset = "0x1022350", VA = "0x1022350")]
			[DebuggerHidden]
			public <MoveUpButton>d__15(int <>1__state)
			{
			}

			[Token(Token = "0x60002AE")]
			[Address(RVA = "0x1022714", Offset = "0x1022714", VA = "0x1022714", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60002AF")]
			[Address(RVA = "0x1022718", Offset = "0x1022718", VA = "0x1022718", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002B1")]
			[Address(RVA = "0x102291C", Offset = "0x102291C", VA = "0x102291C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Canvas canvas;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup canvasGroup;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Button buttonContinue;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Button buttonSave;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Button buttonLoad;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Button buttonExit;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Button buttonRestart;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform screenBottom;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private ExampleGameSaveMenu saveLoadMenu;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private string mainMenuName;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private string firstSceneName;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool canvasEnabled;

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x1021D8C", Offset = "0x1021D8C", VA = "0x1021D8C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x1021F8C", Offset = "0x1021F8C", VA = "0x1021F8C")]
		private void Update()
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x10222A0", Offset = "0x10222A0", VA = "0x10222A0")]
		[IteratorStateMachine(typeof(<FadeCanvas>d__14))]
		private IEnumerator FadeCanvas(float target, float duration)
		{
			return null;
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x10221FC", Offset = "0x10221FC", VA = "0x10221FC")]
		[IteratorStateMachine(typeof(<MoveUpButton>d__15))]
		private IEnumerator MoveUpButton(RectTransform button, float duration, float startPause)
		{
			return null;
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x1022378", Offset = "0x1022378", VA = "0x1022378")]
		public void ExitToMainMenu()
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x10223D4", Offset = "0x10223D4", VA = "0x10223D4")]
		private void OpenLoadMenu()
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x10223F4", Offset = "0x10223F4", VA = "0x10223F4")]
		private void OpenSaveMenu()
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x1022414", Offset = "0x1022414", VA = "0x1022414")]
		public void RestartGame()
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x10224A8", Offset = "0x10224A8", VA = "0x10224A8")]
		public void Continue()
		{
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x10224DC", Offset = "0x10224DC", VA = "0x10224DC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x10224E8", Offset = "0x10224E8", VA = "0x10224E8")]
		public ExampleGamePauseMenu()
		{
		}
	}
	[Token(Token = "0x200005B")]
	[AddComponentMenu("")]
	public class ExampleGamePickup : MonoBehaviour, ISaveable
	{
		[Token(Token = "0x200005C")]
		private enum PickupTypes
		{
			[Token(Token = "0x40001ED")]
			Bomb,
			[Token(Token = "0x40001EE")]
			Heart,
			[Token(Token = "0x40001EF")]
			Gem
		}

		[Serializable]
		[Token(Token = "0x200005D")]
		public struct SaveData
		{
			[Token(Token = "0x40001F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool pickedUp;

			[Token(Token = "0x40001F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float activeRespawnTime;
		}

		[Token(Token = "0x200005E")]
		[CompilerGenerated]
		private sealed class <ChangeScale>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float from;

			[Token(Token = "0x40001F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float to;

			[Token(Token = "0x40001F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ExampleGamePickup <>4__this;

			[Token(Token = "0x40001F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action exec;

			[Token(Token = "0x40001F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float <t>5__2;

			[Token(Token = "0x40001F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float <totalT>5__3;

			[Token(Token = "0x40001FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Vector3 <fromScale>5__4;

			[Token(Token = "0x40001FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private Vector3 <toScale>5__5;

			[Token(Token = "0x17000063")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60002C0")]
				[Address(RVA = "0x1023F4C", Offset = "0x1023F4C", VA = "0x1023F4C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000064")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002C2")]
				[Address(RVA = "0x1023F94", Offset = "0x1023F94", VA = "0x1023F94", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002BD")]
			[Address(RVA = "0x1023DE0", Offset = "0x1023DE0", VA = "0x1023DE0")]
			[DebuggerHidden]
			public <ChangeScale>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x60002BE")]
			[Address(RVA = "0x1023E08", Offset = "0x1023E08", VA = "0x1023E08", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60002BF")]
			[Address(RVA = "0x1023E0C", Offset = "0x1023E0C", VA = "0x1023E0C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002C1")]
			[Address(RVA = "0x1023F54", Offset = "0x1023F54", VA = "0x1023F54", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200005F")]
		[CompilerGenerated]
		private sealed class <RespawnTimer>d__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ExampleGamePickup <>4__this;

			[Token(Token = "0x17000065")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60002C6")]
				[Address(RVA = "0x1024104", Offset = "0x1024104", VA = "0x1024104", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000066")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002C8")]
				[Address(RVA = "0x102414C", Offset = "0x102414C", VA = "0x102414C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002C3")]
			[Address(RVA = "0x1023F9C", Offset = "0x1023F9C", VA = "0x1023F9C")]
			[DebuggerHidden]
			public <RespawnTimer>d__16(int <>1__state)
			{
			}

			[Token(Token = "0x60002C4")]
			[Address(RVA = "0x1023FC4", Offset = "0x1023FC4", VA = "0x1023FC4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60002C5")]
			[Address(RVA = "0x1023FC8", Offset = "0x1023FC8", VA = "0x1023FC8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002C7")]
			[Address(RVA = "0x102410C", Offset = "0x102410C", VA = "0x102410C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private PickupTypes pickupType;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private bool respawn;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector2 respawnTime;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject visual;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Collider aCollider;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ExampleGameObjectPulser pulser;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private AudioSource audioSource;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AudioClip audioPickup;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool pickedUp;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float activeRespawnTime;

		[Token(Token = "0x40001EB")]
		private const float halfPI = (float)Math.PI / 2f;

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x1022964", Offset = "0x1022964", VA = "0x1022964")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x1022B20", Offset = "0x1022B20", VA = "0x1022B20")]
		[IteratorStateMachine(typeof(<ChangeScale>d__14))]
		private IEnumerator ChangeScale(float from, float to, Action exec)
		{
			return null;
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x1022C38", Offset = "0x1022C38", VA = "0x1022C38")]
		private void SetActive(bool active)
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x1022BC4", Offset = "0x1022BC4", VA = "0x1022BC4")]
		[IteratorStateMachine(typeof(<RespawnTimer>d__16))]
		private IEnumerator RespawnTimer()
		{
			return null;
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x1022C94", Offset = "0x1022C94", VA = "0x1022C94", Slot = "4")]
		public string OnSave()
		{
			return null;
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x1022D00", Offset = "0x1022D00", VA = "0x1022D00", Slot = "5")]
		public void OnLoad(string data)
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x1022D9C", Offset = "0x1022D9C", VA = "0x1022D9C", Slot = "6")]
		public bool OnSaveCondition()
		{
			return default(bool);
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x1022DBC", Offset = "0x1022DBC", VA = "0x1022DBC")]
		public ExampleGamePickup()
		{
		}
	}
	[Token(Token = "0x2000060")]
	[AddComponentMenu("")]
	public class ExampleGamePlayer : MonoBehaviour, ExampleGameIDamageable, ISaveable
	{
		[Serializable]
		[Token(Token = "0x2000061")]
		public struct SaveData
		{
			[Token(Token = "0x4000227")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int bombCount;

			[Token(Token = "0x4000228")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int gemCount;

			[Token(Token = "0x4000229")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int health;

			[Token(Token = "0x400022A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public bool isMoving;

			[Token(Token = "0x400022B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float activeMoveDirection;

			[Token(Token = "0x400022C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 oldPosition;

			[Token(Token = "0x400022D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 newPosition;

			[Token(Token = "0x400022E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float walkTime;

			[Token(Token = "0x400022F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float jumpRandomization;

			[Token(Token = "0x4000230")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public bool transitioningLevel;

			[Token(Token = "0x4000231")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float transitionLevelTime;

			[Token(Token = "0x4000232")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string transitionLevelName;

			[Token(Token = "0x4000233")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 transitionLevelPosition;
		}

		[Token(Token = "0x2000062")]
		[CompilerGenerated]
		private sealed class <ShakeObject>d__45 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000234")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000235")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000236")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform transform;

			[Token(Token = "0x4000237")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x4000238")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <duration>5__3;

			[Token(Token = "0x17000067")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60002D9")]
				[Address(RVA = "0x10254B8", Offset = "0x10254B8", VA = "0x10254B8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000068")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002DB")]
				[Address(RVA = "0x1025500", Offset = "0x1025500", VA = "0x1025500", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002D6")]
			[Address(RVA = "0x10243E0", Offset = "0x10243E0", VA = "0x10243E0")]
			[DebuggerHidden]
			public <ShakeObject>d__45(int <>1__state)
			{
			}

			[Token(Token = "0x60002D7")]
			[Address(RVA = "0x1025354", Offset = "0x1025354", VA = "0x1025354", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60002D8")]
			[Address(RVA = "0x1025358", Offset = "0x1025358", VA = "0x1025358", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002DA")]
			[Address(RVA = "0x10254C0", Offset = "0x10254C0", VA = "0x10254C0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool lockMovement;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CharacterController controller;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform visual;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform visualHead;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private int maxBombCount;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private int maxHealthCount;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float stepLength;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float speed;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float jumpWobbleFrequency;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float lookAtSpeed;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private LayerMask objectsThatCanBlock;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		private LayerMask objectsYouInteractWith;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UnityEventInt OnHealthChanged;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UnityEventInt OnBombCountChanged;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UnityEventInt OnGemCountChanged;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UnityEvent OnDamaged;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UnityEvent OnDeath;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UnityEvent OnExitLevel;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UnityEvent OnEnterLevel;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private AudioSource audioSource;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private AudioClip jumpThud;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private AudioClip placeBomb;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private string bombPrefabResourceName;

		[Token(Token = "0x4000216")]
		private const float gravity = -9.81f;

		[Token(Token = "0x4000217")]
		private const float halfPI = (float)Math.PI / 2f;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float jumpRandomization;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float moveTime;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private int bombCount;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int gemCount;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int health;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private bool isMoving;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC5")]
		private bool transitioningLevel;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float transitionLevelTime;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private string transitionLevelname;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private float activeMoveDirection;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 oldPosition;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Vector3 newPosition;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Vector3 transitionLevelPosition;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private bool queuedBombDrop;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x101")]
		private bool queuedMoveUp;

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x1024154", Offset = "0x1024154", VA = "0x1024154")]
		public bool AdjustBombs(int amount)
		{
			return default(bool);
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x10241D0", Offset = "0x10241D0", VA = "0x10241D0")]
		public bool AdjustGems(int amount)
		{
			return default(bool);
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x1024244", Offset = "0x1024244", VA = "0x1024244")]
		public bool AdjustHealth(int amount)
		{
			return default(bool);
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x10242F0", Offset = "0x10242F0", VA = "0x10242F0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x102436C", Offset = "0x102436C", VA = "0x102436C")]
		[IteratorStateMachine(typeof(<ShakeObject>d__45))]
		private IEnumerator ShakeObject(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x1024408", Offset = "0x1024408", VA = "0x1024408")]
		private void Update()
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x1024EC8", Offset = "0x1024EC8", VA = "0x1024EC8")]
		private bool BounceTile()
		{
			return default(bool);
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x1024F94", Offset = "0x1024F94", VA = "0x1024F94", Slot = "4")]
		public void Damage(int amount)
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x1024F9C", Offset = "0x1024F9C", VA = "0x1024F9C")]
		public void MoveToLevel(string targetLevel, Vector3 position)
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x1025068", Offset = "0x1025068", VA = "0x1025068", Slot = "5")]
		public string OnSave()
		{
			return null;
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x1025174", Offset = "0x1025174", VA = "0x1025174", Slot = "6")]
		public void OnLoad(string data)
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x102531C", Offset = "0x102531C", VA = "0x102531C", Slot = "7")]
		public bool OnSaveCondition()
		{
			return default(bool);
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x1025324", Offset = "0x1025324", VA = "0x1025324")]
		public ExampleGamePlayer()
		{
		}
	}
	[Token(Token = "0x2000063")]
	[AddComponentMenu("")]
	public class ExampleGameSaveMenu : MonoBehaviour
	{
		[Token(Token = "0x2000064")]
		public enum Mode
		{
			[Token(Token = "0x400024A")]
			None,
			[Token(Token = "0x400024B")]
			Save,
			[Token(Token = "0x400024C")]
			Load
		}

		[Token(Token = "0x2000065")]
		[CompilerGenerated]
		private sealed class <FadeMenu>d__29 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400024D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400024E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400024F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float duration;

			[Token(Token = "0x4000250")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ExampleGameSaveMenu <>4__this;

			[Token(Token = "0x4000251")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float target;

			[Token(Token = "0x4000252")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float from;

			[Token(Token = "0x4000253")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float <t>5__2;

			[Token(Token = "0x17000069")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60002EF")]
				[Address(RVA = "0x10264DC", Offset = "0x10264DC", VA = "0x10264DC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700006A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002F1")]
				[Address(RVA = "0x1026524", Offset = "0x1026524", VA = "0x1026524", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002EC")]
			[Address(RVA = "0x10262D0", Offset = "0x10262D0", VA = "0x10262D0")]
			[DebuggerHidden]
			public <FadeMenu>d__29(int <>1__state)
			{
			}

			[Token(Token = "0x60002ED")]
			[Address(RVA = "0x1026318", Offset = "0x1026318", VA = "0x1026318", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60002EE")]
			[Address(RVA = "0x102631C", Offset = "0x102631C", VA = "0x102631C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002F0")]
			[Address(RVA = "0x10264E4", Offset = "0x10264E4", VA = "0x10264E4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("References")]
		[SerializeField]
		private CanvasGroup canvasGroup;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text titleText;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Button switchTabRight;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Button switchTabLeft;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text tabText;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ExampleGameSaveMenuSlot[] slots;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Header("Configuration")]
		[SerializeField]
		private Mode loadDefaultMode;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float fadeInTime;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float fadeOutTime;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Header("Events")]
		public UnityEvent OnSlotLoaded;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public UnityEvent OnSlotSaved;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int totalSlotButtons;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int activeTab;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int maxTabs;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int maxSaveSlotCount;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Mode mode;

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x1025508", Offset = "0x1025508", VA = "0x1025508")]
		private void Awake()
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x1025B48", Offset = "0x1025B48", VA = "0x1025B48")]
		private void ResetValues()
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x1025B50", Offset = "0x1025B50", VA = "0x1025B50")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x1025B70", Offset = "0x1025B70", VA = "0x1025B70")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x1025C94", Offset = "0x1025C94", VA = "0x1025C94")]
		public void SwitchTab(int direction)
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x1026030", Offset = "0x1026030", VA = "0x1026030")]
		public void DisplayLoadMode()
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x1026038", Offset = "0x1026038", VA = "0x1026038")]
		public void DisplaySaveMode()
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x1025B80", Offset = "0x1025B80", VA = "0x1025B80")]
		public void Display(Mode mode)
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x1025E5C", Offset = "0x1025E5C", VA = "0x1025E5C")]
		private void ReloadSlots(Mode mode)
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x1026178", Offset = "0x1026178", VA = "0x1026178")]
		public void Hide()
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x10261A4", Offset = "0x10261A4", VA = "0x10261A4")]
		public void OnSelectSlot(int i)
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x10261A8", Offset = "0x10261A8", VA = "0x10261A8")]
		private void ApplySlot(int i)
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x1026040", Offset = "0x1026040", VA = "0x1026040")]
		[IteratorStateMachine(typeof(<FadeMenu>d__29))]
		private IEnumerator FadeMenu(float from, float target, float duration)
		{
			return null;
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x10262F8", Offset = "0x10262F8", VA = "0x10262F8")]
		public ExampleGameSaveMenu()
		{
		}
	}
	[Token(Token = "0x2000066")]
	[AddComponentMenu("")]
	public class ExampleGameSaveMenuSlot : MonoBehaviour
	{
		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Button button;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SaveScreenShotDisplayer screenShotDisplayer;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text textSlotNumber;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text textSlotState;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private int slotVisualOffset;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int slot;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool hasScreenshotDisplayer;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		private bool hasSlotNumberText;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private ExampleGameSaveMenu saveLoadMenu;

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x102652C", Offset = "0x102652C", VA = "0x102652C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x102661C", Offset = "0x102661C", VA = "0x102661C")]
		private void Reset()
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x1026790", Offset = "0x1026790", VA = "0x1026790")]
		private void LoadSlot()
		{
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x10267B0", Offset = "0x10267B0", VA = "0x10267B0", Slot = "4")]
		public virtual void Configure(ExampleGameSaveMenu saveLoadMenu)
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x10267B8", Offset = "0x10267B8", VA = "0x10267B8", Slot = "5")]
		public virtual void SetSlot(int slotIndex, bool isInteractable)
		{
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x10260D8", Offset = "0x10260D8", VA = "0x10260D8")]
		public void SetText(string text)
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x1026870", Offset = "0x1026870", VA = "0x1026870", Slot = "6")]
		public virtual void LoadScreenshot()
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x10268A4", Offset = "0x10268A4", VA = "0x10268A4")]
		public ExampleGameSaveMenuSlot()
		{
		}
	}
	[Token(Token = "0x2000067")]
	[AddComponentMenu("")]
	public class ExampleGameScreenFader : MonoBehaviour
	{
		[Token(Token = "0x2000068")]
		[CompilerGenerated]
		private sealed class <ChangeOpactiy>d__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000260")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000261")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000262")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ExampleGameScreenFader <>4__this;

			[Token(Token = "0x4000263")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float target;

			[Token(Token = "0x4000264")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float duration;

			[Token(Token = "0x4000265")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <a>5__2;

			[Token(Token = "0x4000266")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <t>5__3;

			[Token(Token = "0x1700006B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000301")]
				[Address(RVA = "0x1026B5C", Offset = "0x1026B5C", VA = "0x1026B5C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700006C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000303")]
				[Address(RVA = "0x1026BA4", Offset = "0x1026BA4", VA = "0x1026BA4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002FE")]
			[Address(RVA = "0x10269DC", Offset = "0x10269DC", VA = "0x10269DC")]
			[DebuggerHidden]
			public <ChangeOpactiy>d__5(int <>1__state)
			{
			}

			[Token(Token = "0x60002FF")]
			[Address(RVA = "0x1026A0C", Offset = "0x1026A0C", VA = "0x1026A0C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000300")]
			[Address(RVA = "0x1026A10", Offset = "0x1026A10", VA = "0x1026A10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000302")]
			[Address(RVA = "0x1026B64", Offset = "0x1026B64", VA = "0x1026B64", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float fadeDuration;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup canvasGroup;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Canvas canvas;

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x10268B4", Offset = "0x10268B4", VA = "0x10268B4")]
		public void HideScreen()
		{
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x102698C", Offset = "0x102698C", VA = "0x102698C")]
		public void ShowScreen()
		{
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x1026904", Offset = "0x1026904", VA = "0x1026904")]
		[IteratorStateMachine(typeof(<ChangeOpactiy>d__5))]
		private IEnumerator ChangeOpactiy(float target, float duration)
		{
			return null;
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x1026A04", Offset = "0x1026A04", VA = "0x1026A04")]
		public ExampleGameScreenFader()
		{
		}
	}
	[Token(Token = "0x2000069")]
	[AddComponentMenu("")]
	public class ExampleGameUI : MonoBehaviour
	{
		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text textBombCount;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject[] heartIcons;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject[] gemIcons;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ExampleGameObjectPulser bombIcon;

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x1026BAC", Offset = "0x1026BAC", VA = "0x1026BAC")]
		public void OnBombCountChanged(int newAmount)
		{
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x1026BF4", Offset = "0x1026BF4", VA = "0x1026BF4")]
		public void HealthCountChanged(int newAmount)
		{
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x1026C80", Offset = "0x1026C80", VA = "0x1026C80")]
		public void GemCountChanged(int newAmount)
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x1026D0C", Offset = "0x1026D0C", VA = "0x1026D0C")]
		public ExampleGameUI()
		{
		}
	}
	[Token(Token = "0x200006A")]
	[AddComponentMenu("")]
	[SelectionBase]
	public class ExampleGameWarpPoint : MonoBehaviour
	{
		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ExampleGameWarpPointData data;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ExampleGameWarpPointData targetPoint;

		[Token(Token = "0x1700006D")]
		public Vector3 TargetPosition
		{
			[Token(Token = "0x6000308")]
			[Address(RVA = "0x1026D14", Offset = "0x1026D14", VA = "0x1026D14")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700006E")]
		public string TargetScene
		{
			[Token(Token = "0x6000309")]
			[Address(RVA = "0x1026D34", Offset = "0x1026D34", VA = "0x1026D34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x1026D50", Offset = "0x1026D50", VA = "0x1026D50")]
		public ExampleGameWarpPoint()
		{
		}
	}
	[Token(Token = "0x200006B")]
	public class ExampleGameWarpPointData : ScriptableObject
	{
		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Scene;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 Position;

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x1026D58", Offset = "0x1026D58", VA = "0x1026D58")]
		public ExampleGameWarpPointData()
		{
		}
	}
	[Token(Token = "0x200006C")]
	public class ExampleErrorScreen : MonoBehaviour
	{
		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text messageText;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text titleText;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Button continueButton;

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x1026D60", Offset = "0x1026D60", VA = "0x1026D60")]
		private void Start()
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x1026DF4", Offset = "0x1026DF4", VA = "0x1026DF4")]
		public void Configure(string title, string message)
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x1026E60", Offset = "0x1026E60", VA = "0x1026E60")]
		public ExampleErrorScreen()
		{
		}
	}
	[Token(Token = "0x200006D")]
	public class ExampleMainMenu : MonoBehaviour
	{
		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Header("References")]
		private Button buttonContinue;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button buttonNew;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Button buttonLoad;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Button buttonQuit;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ExampleErrorScreen errorMessage;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ExampleSlotMenu slotMenu;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Header("Configuration")]
		private string sceneToLoadOnNewGame;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int lastUsedValidSlot;

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x1026E8C", Offset = "0x1026E8C", VA = "0x1026E8C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x1027104", Offset = "0x1027104", VA = "0x1027104")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x10271F0", Offset = "0x10271F0", VA = "0x10271F0")]
		private void OnDeletedSave(int obj)
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x1027224", Offset = "0x1027224", VA = "0x1027224")]
		private void Continue()
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x1027278", Offset = "0x1027278", VA = "0x1027278")]
		private void LoadGame()
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x10272A4", Offset = "0x10272A4", VA = "0x10272A4")]
		private void QuitGame()
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x10272AC", Offset = "0x10272AC", VA = "0x10272AC")]
		private void NewGame()
		{
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x1027394", Offset = "0x1027394", VA = "0x1027394")]
		public ExampleMainMenu()
		{
		}
	}
	[Token(Token = "0x200006E")]
	public class ExamplePauseMenu : MonoBehaviour
	{
		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Header("References")]
		private Canvas canvas;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GraphicRaycaster graphicRaycaster;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject pauseMenuObjects;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ExampleSlotMenu slotMenu;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform darkenBackground;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Button buttonContinue;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Button buttonLoad;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Button buttonSave;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Button buttonQuit;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Header("Configuration")]
		[SerializeField]
		private KeyCode[] openMenuKeys;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private string quitToScene;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private bool closeWindowOnSave;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		[SerializeField]
		private bool closeWindowOnLoad;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject[] toggleObjectVisibility;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private bool pauseAndUnpauseGame;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Dictionary<GameObject, bool> cachedVisibility;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int openMenuKeyCount;

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x102739C", Offset = "0x102739C", VA = "0x102739C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x1027734", Offset = "0x1027734", VA = "0x1027734")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x10278F8", Offset = "0x10278F8", VA = "0x10278F8")]
		private void OnPressContinue()
		{
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x1027908", Offset = "0x1027908", VA = "0x1027908")]
		private void OnChangedSlot(int arg1, int arg2)
		{
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x1027910", Offset = "0x1027910", VA = "0x1027910")]
		private void OnWrittenToDisk(int obj)
		{
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x1027918", Offset = "0x1027918", VA = "0x1027918")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x1027920", Offset = "0x1027920", VA = "0x1027920")]
		private void OnQuit()
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x102797C", Offset = "0x102797C", VA = "0x102797C")]
		private void OnOpenSlotMenuSave()
		{
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x10279D0", Offset = "0x10279D0", VA = "0x10279D0")]
		private void OnOpenSlotMenuLoad()
		{
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x1027A14", Offset = "0x1027A14", VA = "0x1027A14")]
		private void ToggleDisplay(bool display)
		{
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x1027C50", Offset = "0x1027C50", VA = "0x1027C50")]
		public void Display()
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x1027900", Offset = "0x1027900", VA = "0x1027900")]
		public void Hide()
		{
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x1027C58", Offset = "0x1027C58", VA = "0x1027C58")]
		private void Update()
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x1027CF4", Offset = "0x1027CF4", VA = "0x1027CF4")]
		public ExamplePauseMenu()
		{
		}
	}
	[Token(Token = "0x200006F")]
	public class ExamplePlaySoundsOnMouse : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerEnterHandler
	{
		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AudioSource audioSource;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioClip soundHover;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AudioClip soundInteract;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Button button;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool playSounds;

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x1027DD0", Offset = "0x1027DD0", VA = "0x1027DD0")]
		public void PlaySounds(bool playSounds)
		{
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x1027DDC", Offset = "0x1027DDC", VA = "0x1027DDC", Slot = "4")]
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x1027ECC", Offset = "0x1027ECC", VA = "0x1027ECC", Slot = "5")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x1027FBC", Offset = "0x1027FBC", VA = "0x1027FBC")]
		public ExamplePlaySoundsOnMouse()
		{
		}
	}
	[Token(Token = "0x2000070")]
	public class ExampleSlotMenu : MonoBehaviour
	{
		[Token(Token = "0x2000071")]
		public enum Mode
		{
			[Token(Token = "0x400029E")]
			Load,
			[Token(Token = "0x400029F")]
			Save
		}

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Header("References")]
		private ExampleSlotMenuSlot[] slots;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text textTab;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Button switchTabLeft;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Button switchTabRight;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Button buttonClose;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text titleText;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Header("Configuration")]
		[SerializeField]
		private bool hideSwitchTabWhenUnusable;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private Mode mode;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private string titleTextLoad;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private string titleTextSave;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int slotCount;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private int activeTab;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int totalTabCount;

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x1027FCC", Offset = "0x1027FCC", VA = "0x1027FCC")]
		private void Awake()
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x10279C4", Offset = "0x10279C4", VA = "0x10279C4")]
		public void SetMode(Mode mode)
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x10281CC", Offset = "0x10281CC", VA = "0x10281CC")]
		private void UpdateSlots()
		{
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x1028328", Offset = "0x1028328", VA = "0x1028328")]
		private void SwitchTab(int direction)
		{
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x10285C4", Offset = "0x10285C4", VA = "0x10285C4")]
		private void UpdateTextTab()
		{
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x1028698", Offset = "0x1028698", VA = "0x1028698")]
		public ExampleSlotMenu()
		{
		}
	}
	[Token(Token = "0x2000072")]
	public class ExampleSlotMenuSlot : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerDownHandler, IPointerExitHandler
	{
		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text slotIndicator;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text slotText;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SaveScreenShotDisplayer screenshotDisplayer;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Button buttonRemoveSave;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ExamplePlaySoundsOnMouse playSoundsOnMouse;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ExampleSlotMenu.Mode mode;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int slotIndex;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool isSlotUsed;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		private bool isSlotValid;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Color initialSlotIndicatorColor;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Color initialSlotTextColor;

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x10286DC", Offset = "0x10286DC", VA = "0x10286DC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x1028870", Offset = "0x1028870", VA = "0x1028870")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x102895C", Offset = "0x102895C", VA = "0x102895C")]
		private void OnClickRemove()
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x10289E0", Offset = "0x10289E0", VA = "0x10289E0")]
		private void OnChangedSlot(int to, int from)
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x1028A04", Offset = "0x1028A04", VA = "0x1028A04")]
		private void Reset()
		{
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x1028398", Offset = "0x1028398", VA = "0x1028398")]
		public void SetIndex(int slotIndex, ExampleSlotMenu.Mode mode)
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x1028AB4", Offset = "0x1028AB4", VA = "0x1028AB4", Slot = "5")]
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x1028B80", Offset = "0x1028B80", VA = "0x1028B80", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x1028C3C", Offset = "0x1028C3C", VA = "0x1028C3C")]
		private void Hovering(bool state)
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x1028CD0", Offset = "0x1028CD0", VA = "0x1028CD0", Slot = "6")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x1028CD8", Offset = "0x1028CD8", VA = "0x1028CD8")]
		public ExampleSlotMenuSlot()
		{
		}
	}
	[Token(Token = "0x2000073")]
	public class ExampleEventlistening : MonoBehaviour
	{
		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Button buttonSyncSave;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button buttonSyncLoad;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Button buttonWriteToDisk;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Button buttonLoadFromDisk;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text eventText;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<string> events;

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x1028CE8", Offset = "0x1028CE8", VA = "0x1028CE8")]
		private void Awake()
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x1029360", Offset = "0x1029360", VA = "0x1029360")]
		private void OnLoadFromDiskButton()
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x1029410", Offset = "0x1029410", VA = "0x1029410")]
		private void OnWriteToDiskButton()
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x10294B0", Offset = "0x10294B0", VA = "0x10294B0")]
		private void OnSyncLoadButton()
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x102954C", Offset = "0x102954C", VA = "0x102954C")]
		private void OnSyncSaveButton()
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x10295E8", Offset = "0x10295E8", VA = "0x10295E8")]
		private void UpdateEventList()
		{
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x10296D8", Offset = "0x10296D8", VA = "0x10296D8")]
		public ExampleEventlistening()
		{
		}
	}
	[Token(Token = "0x2000074")]
	public class PartSpawner : MonoBehaviour, ISaveable
	{
		[Serializable]
		[Token(Token = "0x2000075")]
		private struct SpawnablePrefabs
		{
			[Token(Token = "0x40002B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string id;

			[Token(Token = "0x40002BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public GameObject prefab;
		}

		[Token(Token = "0x2000077")]
		[CompilerGenerated]
		private sealed class <Start>d__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40002C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PartSpawner <>4__this;

			[Token(Token = "0x40002C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <ySize>5__2;

			[Token(Token = "0x40002C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private int <xSize>5__3;

			[Token(Token = "0x40002C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int <y>5__4;

			[Token(Token = "0x40002C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private int <x>5__5;

			[Token(Token = "0x1700006F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600035F")]
				[Address(RVA = "0x102AC7C", Offset = "0x102AC7C", VA = "0x102AC7C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000070")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000361")]
				[Address(RVA = "0x102ACC4", Offset = "0x102ACC4", VA = "0x102ACC4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600035C")]
			[Address(RVA = "0x102A26C", Offset = "0x102A26C", VA = "0x102A26C")]
			[DebuggerHidden]
			public <Start>d__12(int <>1__state)
			{
			}

			[Token(Token = "0x600035D")]
			[Address(RVA = "0x102A994", Offset = "0x102A994", VA = "0x102A994", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600035E")]
			[Address(RVA = "0x102A998", Offset = "0x102A998", VA = "0x102A998", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000360")]
			[Address(RVA = "0x102AC84", Offset = "0x102AC84", VA = "0x102AC84", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string spawnedSceneName;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float totalOperationsAtOnce;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Vector2Int gridSize;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SpawnablePrefabs[] spawnablePrefabs;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Dictionary<string, GameObject> indexedSpawnablePrefabs;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Camera cam;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool neverSaved;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int operations;

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x1029F6C", Offset = "0x1029F6C", VA = "0x1029F6C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x102A118", Offset = "0x102A118", VA = "0x102A118")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x102A180", Offset = "0x102A180", VA = "0x102A180")]
		private GameObject OnLoadResource(string arg1)
		{
			return null;
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x102A1F8", Offset = "0x102A1F8", VA = "0x102A1F8")]
		[IteratorStateMachine(typeof(<Start>d__12))]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x102A294", Offset = "0x102A294", VA = "0x102A294")]
		private void OnSceneSpawned(Scene scene, Vector3 targetPosition, int id)
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x102A630", Offset = "0x102A630", VA = "0x102A630")]
		private void Update()
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x102A804", Offset = "0x102A804", VA = "0x102A804", Slot = "4")]
		public string OnSave()
		{
			return null;
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x102A85C", Offset = "0x102A85C", VA = "0x102A85C", Slot = "5")]
		public void OnLoad(string data)
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x102A8CC", Offset = "0x102A8CC", VA = "0x102A8CC", Slot = "6")]
		public bool OnSaveCondition()
		{
			return default(bool);
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x102A8D4", Offset = "0x102A8D4", VA = "0x102A8D4")]
		public PartSpawner()
		{
		}
	}
	[Token(Token = "0x2000078")]
	public class RandomizeSprite : MonoBehaviour, ISaveable
	{
		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SpriteRenderer spriteRenderer;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Sprite[] sprites;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool hasBeenSaved;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int selectedIndex;

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x102ACCC", Offset = "0x102ACCC", VA = "0x102ACCC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x102AD8C", Offset = "0x102AD8C", VA = "0x102AD8C", Slot = "5")]
		public void OnLoad(string data)
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x102ADF4", Offset = "0x102ADF4", VA = "0x102ADF4", Slot = "4")]
		public string OnSave()
		{
			return null;
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x102AE00", Offset = "0x102AE00", VA = "0x102AE00", Slot = "6")]
		public bool OnSaveCondition()
		{
			return default(bool);
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x102AE10", Offset = "0x102AE10", VA = "0x102AE10")]
		public RandomizeSprite()
		{
		}
	}
	[Token(Token = "0x2000079")]
	[AddComponentMenu("Lowscope/Flappy Happy/Arcade Machine/FlappyHappy - Demo Camera Controller")]
	public class SimpleCameraController : MonoBehaviour
	{
		[Token(Token = "0x200007A")]
		private class CameraState
		{
			[Token(Token = "0x40002D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float yaw;

			[Token(Token = "0x40002D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pitch;

			[Token(Token = "0x40002D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float roll;

			[Token(Token = "0x40002D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float x;

			[Token(Token = "0x40002D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float y;

			[Token(Token = "0x40002D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float z;

			[Token(Token = "0x600036B")]
			[Address(RVA = "0x102AE74", Offset = "0x102AE74", VA = "0x102AE74")]
			public void SetFromTransform(Transform t)
			{
			}

			[Token(Token = "0x600036C")]
			[Address(RVA = "0x102B3CC", Offset = "0x102B3CC", VA = "0x102B3CC")]
			public void Translate(Vector3 translation)
			{
			}

			[Token(Token = "0x600036D")]
			[Address(RVA = "0x102B44C", Offset = "0x102B44C", VA = "0x102B44C")]
			public void LerpTowards(CameraState target, float positionLerpPct, float rotationLerpPct)
			{
			}

			[Token(Token = "0x600036E")]
			[Address(RVA = "0x102B4D4", Offset = "0x102B4D4", VA = "0x102B4D4")]
			public void UpdateTransform(Transform t)
			{
			}

			[Token(Token = "0x600036F")]
			[Address(RVA = "0x102B6F8", Offset = "0x102B6F8", VA = "0x102B6F8")]
			public CameraState()
			{
			}
		}

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CameraState m_TargetCameraState;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private CameraState m_InterpolatingCameraState;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("Movement Settings")]
		[Tooltip("Exponential boost factor on translation, controllable by mouse wheel.")]
		public float boost;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Time it takes to interpolate camera position 99% of the way to the target.")]
		[Range(0.001f, 1f)]
		public float positionLerpTime;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Header("Rotation Settings")]
		[Tooltip("X = Change in mouse position.\nY = Multiplicative factor for camera rotation.")]
		public AnimationCurve mouseSensitivityCurve;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Time it takes to interpolate camera rotation 99% of the way to the target.")]
		[Range(0.001f, 1f)]
		public float rotationLerpTime;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("Whether or not to invert our Y axis for mouse input to rotation.")]
		public bool invertY;

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x102AE20", Offset = "0x102AE20", VA = "0x102AE20")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x102AEF8", Offset = "0x102AEF8", VA = "0x102AEF8")]
		private Vector3 GetInputTranslationDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x102B128", Offset = "0x102B128", VA = "0x102B128")]
		private void Update()
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x102B51C", Offset = "0x102B51C", VA = "0x102B51C")]
		public SimpleCameraController()
		{
		}
	}
	[Token(Token = "0x200007B")]
	public class SpawnRandomSaveables : MonoBehaviour
	{
		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string[] possiblePrefabs;

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x102A3D0", Offset = "0x102A3D0", VA = "0x102A3D0")]
		public void Spawn()
		{
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x102B700", Offset = "0x102B700", VA = "0x102B700")]
		public SpawnRandomSaveables()
		{
		}
	}
	[Token(Token = "0x200007C")]
	public class ExampleStressTestEntities : MonoBehaviour
	{
		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text debugText;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject examplePrefab;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Button spawnEntities;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Button removeEntities;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Button syncSaveAll;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Button syncLoadAll;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Button writeToDisk;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Button loadFromDisk;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Button shuffleTransforms;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text spawnEntitiesMs;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text removeEntitiesMs;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text syncSaveAllMs;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text syncLoadAllMs;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text shuffleTransformsMs;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text writeToDiskMs;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text loadFromDiskMs;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private List<SavedInstance> savedInstances;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private int totalSpawnedInstances;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private int totalSpawnedComponents;

		[Token(Token = "0x40002EA")]
		private const string CUSTOMSPAWNERID = "ExampleStressTestSpawner";

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x102B708", Offset = "0x102B708", VA = "0x102B708")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x102BAC0", Offset = "0x102BAC0", VA = "0x102BAC0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x102BBB0", Offset = "0x102BBB0", VA = "0x102BBB0")]
		private void WriteToDisk()
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x102BCAC", Offset = "0x102BCAC", VA = "0x102BCAC")]
		private void LoadFromDisk()
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x102BDF0", Offset = "0x102BDF0", VA = "0x102BDF0")]
		private void SyncSave()
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x102BEE8", Offset = "0x102BEE8", VA = "0x102BEE8")]
		private void SyncLoad()
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x102BFE0", Offset = "0x102BFE0", VA = "0x102BFE0")]
		private void ShuffleAllInstanceTransforms()
		{
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x102C334", Offset = "0x102C334", VA = "0x102C334")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x102C420", Offset = "0x102C420", VA = "0x102C420")]
		private void OnSpawnedSavedPrefab(Scene scene, SavedInstance instance)
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x102C568", Offset = "0x102C568", VA = "0x102C568")]
		private void Remove(int amount)
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x102C7C4", Offset = "0x102C7C4", VA = "0x102C7C4")]
		private void Spawn(int amount)
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x102C160", Offset = "0x102C160", VA = "0x102C160")]
		private static void ShuffleObjectTransform(System.Random rnd, GameObject obj)
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x102C95C", Offset = "0x102C95C", VA = "0x102C95C")]
		public ExampleStressTestEntities()
		{
		}
	}
	[Token(Token = "0x200007D")]
	public class ExamplePoolBall : MonoBehaviour, ISaveable
	{
		[Serializable]
		[Token(Token = "0x200007E")]
		private struct SaveData
		{
			[Token(Token = "0x40002F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float DestroyTime;

			[Token(Token = "0x40002F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public Vector3 Velocity;
		}

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public UnityEvent OnDestroyed;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UnityEvent OnDisabled;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float destroyAfterTime;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Rigidbody rigidBody;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float destroyTime;

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x102CA00", Offset = "0x102CA00", VA = "0x102CA00")]
		private void Update()
		{
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x102CA60", Offset = "0x102CA60", VA = "0x102CA60")]
		public void ResetValues()
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x102CA90", Offset = "0x102CA90", VA = "0x102CA90")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x102CAAC", Offset = "0x102CAAC", VA = "0x102CAAC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x102CAC8", Offset = "0x102CAC8", VA = "0x102CAC8", Slot = "5")]
		public void OnLoad(string data)
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x102CB44", Offset = "0x102CB44", VA = "0x102CB44", Slot = "4")]
		public string OnSave()
		{
			return null;
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x102CBC4", Offset = "0x102CBC4", VA = "0x102CBC4", Slot = "6")]
		public bool OnSaveCondition()
		{
			return default(bool);
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x102CBCC", Offset = "0x102CBCC", VA = "0x102CBCC")]
		public ExamplePoolBall()
		{
		}
	}
	[Token(Token = "0x200007F")]
	public class ExamplePoolTestEntities : MonoBehaviour
	{
		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text poolCounter;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject bulletPrefab;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Button buttonSpawnBullet;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Button buttonSyncSave;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Button buttonSyncLoad;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Button buttonWriteToDisk;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Button buttonLoadFromDiskAndSync;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Button buttonReloadScene;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<GameObject> activePoolObjects;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private List<GameObject> inactivePoolObjects;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int currentSpawnedObjects;

		[Token(Token = "0x40002FD")]
		private const int initialPoolSize = 10;

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x102CBDC", Offset = "0x102CBDC", VA = "0x102CBDC")]
		private void Awake()
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x102CF40", Offset = "0x102CF40", VA = "0x102CF40")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x102D238", Offset = "0x102D238", VA = "0x102D238")]
		private void Start()
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x102D2A4", Offset = "0x102D2A4", VA = "0x102D2A4")]
		private GameObject SpawnPrefab()
		{
			return null;
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x102D39C", Offset = "0x102D39C", VA = "0x102D39C")]
		private void AssignEvents(GameObject spawnedPrefab)
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x102D510", Offset = "0x102D510", VA = "0x102D510")]
		private void OnSpawnedSavedInstance(Scene scene, SavedInstance savedInstance)
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x102D68C", Offset = "0x102D68C", VA = "0x102D68C")]
		private void OnReloadScene()
		{
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x102D720", Offset = "0x102D720", VA = "0x102D720")]
		private void OnLoadFromDiskAndSync()
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x102D784", Offset = "0x102D784", VA = "0x102D784")]
		private void OnWriteToDisk()
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x102D7D8", Offset = "0x102D7D8", VA = "0x102D7D8")]
		private void OnSyncLoad()
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x102D828", Offset = "0x102D828", VA = "0x102D828")]
		private void OnSyncSave()
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x102D878", Offset = "0x102D878", VA = "0x102D878")]
		private void OnSpawnButton()
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x102DA84", Offset = "0x102DA84", VA = "0x102DA84")]
		private Vector3 ReturnRandomPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x102DAC0", Offset = "0x102DAC0", VA = "0x102DAC0")]
		public ExamplePoolTestEntities()
		{
		}
	}
}
namespace Lowscope.Saving.Enums
{
	[Token(Token = "0x2000081")]
	public enum EncryptionType
	{
		[Token(Token = "0x4000301")]
		None,
		[Token(Token = "0x4000302")]
		AES
	}
	[Token(Token = "0x2000082")]
	public enum LoadTrigger
	{
		[Token(Token = "0x4000304")]
		OnSlotChanged,
		[Token(Token = "0x4000305")]
		OnSyncLoad,
		[Token(Token = "0x4000306")]
		OnDestroy,
		[Token(Token = "0x4000307")]
		OnDisable,
		[Token(Token = "0x4000308")]
		OnEnable,
		[Token(Token = "0x4000309")]
		OnStart,
		[Token(Token = "0x400030A")]
		Manual
	}
	[Token(Token = "0x2000083")]
	public enum SaveFileValidation
	{
		[Token(Token = "0x400030C")]
		DontCheck,
		[Token(Token = "0x400030D")]
		GiveError,
		[Token(Token = "0x400030E")]
		ConvertToType,
		[Token(Token = "0x400030F")]
		Replace
	}
	[Token(Token = "0x2000084")]
	public enum StorageType
	{
		[Token(Token = "0x4000311")]
		JSON,
		[Token(Token = "0x4000312")]
		Binary,
		[Token(Token = "0x4000313")]
		SQLiteExperimental
	}
}
namespace Lowscope.Saving.Encryption
{
	[Token(Token = "0x2000085")]
	public class AESEncryption
	{
		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Key;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string IV;

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x102DD84", Offset = "0x102DD84", VA = "0x102DD84")]
		public AESEncryption(string key, string iv)
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x102DE84", Offset = "0x102DE84", VA = "0x102DE84")]
		public static string CreateMD5(string input)
		{
			return null;
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x102E134", Offset = "0x102E134", VA = "0x102E134")]
		public string Encrypt(string message)
		{
			return null;
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x102E49C", Offset = "0x102E49C", VA = "0x102E49C")]
		public byte[] Encrypt(byte[] bytes)
		{
			return null;
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x102E7A8", Offset = "0x102E7A8", VA = "0x102E7A8")]
		public string Decrypt(string encryptedText)
		{
			return null;
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x102EE0C", Offset = "0x102EE0C", VA = "0x102EE0C")]
		public byte[] Decrypt(byte[] bytes)
		{
			return null;
		}
	}
}
namespace Lowscope.Saving.Demo
{
	[Token(Token = "0x2000086")]
	public class SaveSpeedTest : MonoBehaviour
	{
		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Button buttonTestSyncSave;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button buttonTestSyncLoad;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Button buttonTestSyncSaveWrite;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Button buttonTestSyncSaveLoad;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Button buttonRandomizeTransforms;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Button buttonWipeAllSaveablesData;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Button buttonWipeSave;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text displayText;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject saveablesContainer;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Saveable[] saveables;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static float lastestSpeed;

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x102F31C", Offset = "0x102F31C", VA = "0x102F31C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x102F62C", Offset = "0x102F62C", VA = "0x102F62C")]
		private void SyncSave()
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x102F724", Offset = "0x102F724", VA = "0x102F724")]
		private void SyncLoad()
		{
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x102F81C", Offset = "0x102F81C", VA = "0x102F81C")]
		private void SyncSaveWrite()
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x102F918", Offset = "0x102F918", VA = "0x102F918")]
		private void SyncSaveLoad()
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x102FA64", Offset = "0x102FA64", VA = "0x102FA64")]
		private void RandomizeTransforms()
		{
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x102FB64", Offset = "0x102FB64", VA = "0x102FB64")]
		private void WipeSaveables()
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x102FCF0", Offset = "0x102FCF0", VA = "0x102FCF0")]
		private void WipeSave()
		{
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x102FDB4", Offset = "0x102FDB4", VA = "0x102FDB4")]
		public SaveSpeedTest()
		{
		}
	}
}
namespace Lowscope.Saving.Data
{
	[Token(Token = "0x2000087")]
	public interface IConvertSaveGame
	{
		[Token(Token = "0x60003AC")]
		SaveGame ConvertTo(StorageType storageType, string filePath, bool replace = true);
	}
	[Serializable]
	[Token(Token = "0x2000088")]
	public abstract class SaveGame : IDisposable
	{
		[NonSerialized]
		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public TimeSpan timePlayed;

		[NonSerialized]
		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int gameVersion;

		[NonSerialized]
		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DateTime creationDate;

		[NonSerialized]
		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int timesSaved;

		[NonSerialized]
		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public DateTime modificationDate;

		[Token(Token = "0x17000071")]
		public string fileName
		{
			[Token(Token = "0x60003AD")]
			[Address(RVA = "0x102FDBC", Offset = "0x102FDBC", VA = "0x102FDBC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60003AE")]
			[Address(RVA = "0x102FDC4", Offset = "0x102FDC4", VA = "0x102FDC4")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x102FDCC", Offset = "0x102FDCC", VA = "0x102FDCC")]
		public void SetFileName(string fileName)
		{
		}

		[Token(Token = "0x60003B0")]
		public abstract void ReadSaveFromPath(string savePath);

		[Token(Token = "0x60003B1")]
		public abstract void WriteSaveFile(SaveGame saveGame, string savePath);

		[Token(Token = "0x60003B2")]
		public abstract void OnBeforeWrite();

		[Token(Token = "0x60003B3")]
		public abstract void OnAfterLoad();

		[Token(Token = "0x60003B4")]
		public abstract void WipeSceneData(string sceneName);

		[Token(Token = "0x60003B5")]
		public abstract void Remove(string id);

		[Token(Token = "0x60003B6")]
		public abstract void Set(string id, string data, string scene);

		[Token(Token = "0x60003B7")]
		public abstract string Get(string id);

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x102FDD4", Offset = "0x102FDD4", VA = "0x102FDD4")]
		protected static void Log(string text)
		{
		}

		[Token(Token = "0x60003B9")]
		public abstract void Dispose();

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x102FDD8", Offset = "0x102FDD8", VA = "0x102FDD8")]
		protected SaveGame()
		{
		}
	}
	[Token(Token = "0x2000089")]
	public class SaveGameBinary : SaveGameJSON
	{
		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x102FDE0", Offset = "0x102FDE0", VA = "0x102FDE0", Slot = "5")]
		public override void ReadSaveFromPath(string savePath)
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x1030320", Offset = "0x1030320", VA = "0x1030320", Slot = "6")]
		public override void WriteSaveFile(SaveGame saveGame, string savePath)
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x10307D4", Offset = "0x10307D4", VA = "0x10307D4")]
		public SaveGameBinary()
		{
		}
	}
	[Token(Token = "0x200008A")]
	public class SaveGameJSON : SaveGame, IConvertSaveGame
	{
		[Serializable]
		[Token(Token = "0x200008B")]
		public struct MetaData
		{
			[Token(Token = "0x400032B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int gameVersion;

			[Token(Token = "0x400032C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string creationDate;

			[Token(Token = "0x400032D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string timePlayed;

			[Token(Token = "0x400032E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string modificationDate;
		}

		[Serializable]
		[Token(Token = "0x200008C")]
		public struct Data
		{
			[Token(Token = "0x400032F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string guid;

			[Token(Token = "0x4000330")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string data;

			[Token(Token = "0x4000331")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string scene;
		}

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		internal MetaData metaData;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		internal List<Data> saveData;

		[NonSerialized]
		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		internal Dictionary<string, int> saveDataCache;

		[NonSerialized]
		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Dictionary<string, List<string>> sceneObjectIDS;

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x103096C", Offset = "0x103096C", VA = "0x103096C", Slot = "5")]
		public override void ReadSaveFromPath(string savePath)
		{
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x1030DC8", Offset = "0x1030DC8", VA = "0x1030DC8", Slot = "6")]
		public override void WriteSaveFile(SaveGame saveGame, string savePath)
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x1030FC4", Offset = "0x1030FC4", VA = "0x1030FC4", Slot = "12")]
		public override string Get(string id)
		{
			return null;
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x103106C", Offset = "0x103106C", VA = "0x103106C", Slot = "8")]
		public override void OnAfterLoad()
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x1031484", Offset = "0x1031484", VA = "0x1031484", Slot = "7")]
		public override void OnBeforeWrite()
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x1031598", Offset = "0x1031598", VA = "0x1031598", Slot = "10")]
		public override void Remove(string id)
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x103169C", Offset = "0x103169C", VA = "0x103169C", Slot = "11")]
		public override void Set(string id, string data, string scene)
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x1031910", Offset = "0x1031910", VA = "0x1031910", Slot = "9")]
		public override void WipeSceneData(string sceneName)
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x10312BC", Offset = "0x10312BC", VA = "0x10312BC")]
		protected void AddSceneID(string scene, string id)
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x1031A50", Offset = "0x1031A50", VA = "0x1031A50", Slot = "13")]
		public override void Dispose()
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x1031AFC", Offset = "0x1031AFC", VA = "0x1031AFC", Slot = "14")]
		public SaveGame ConvertTo(StorageType storageType, string filePath, bool replace = true)
		{
			return null;
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x10307D8", Offset = "0x10307D8", VA = "0x10307D8")]
		public SaveGameJSON()
		{
		}
	}
	[Token(Token = "0x200008D")]
	public class SaveGameSqlite : SaveGame, IConvertSaveGame
	{
		[Serializable]
		[Token(Token = "0x200008E")]
		public class MetaData
		{
			[Token(Token = "0x17000072")]
			[Unique]
			[PrimaryKey]
			public int id
			{
				[Token(Token = "0x60003D6")]
				[Address(RVA = "0x1032FA8", Offset = "0x1032FA8", VA = "0x1032FA8")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Token(Token = "0x60003D7")]
				[Address(RVA = "0x1032FB0", Offset = "0x1032FB0", VA = "0x1032FB0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x17000073")]
			public int gameVersion
			{
				[Token(Token = "0x60003D8")]
				[Address(RVA = "0x1032FB8", Offset = "0x1032FB8", VA = "0x1032FB8")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Token(Token = "0x60003D9")]
				[Address(RVA = "0x1032FC0", Offset = "0x1032FC0", VA = "0x1032FC0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x17000074")]
			public string creationDate
			{
				[Token(Token = "0x60003DA")]
				[Address(RVA = "0x1032FC8", Offset = "0x1032FC8", VA = "0x1032FC8")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60003DB")]
				[Address(RVA = "0x1032FD0", Offset = "0x1032FD0", VA = "0x1032FD0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x17000075")]
			public string timePlayed
			{
				[Token(Token = "0x60003DC")]
				[Address(RVA = "0x1032FD8", Offset = "0x1032FD8", VA = "0x1032FD8")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60003DD")]
				[Address(RVA = "0x1032FE0", Offset = "0x1032FE0", VA = "0x1032FE0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x17000076")]
			public string modificationDate
			{
				[Token(Token = "0x60003DE")]
				[Address(RVA = "0x1032FE8", Offset = "0x1032FE8", VA = "0x1032FE8")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60003DF")]
				[Address(RVA = "0x1032FF0", Offset = "0x1032FF0", VA = "0x1032FF0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x60003E0")]
			[Address(RVA = "0x10328EC", Offset = "0x10328EC", VA = "0x10328EC")]
			public MetaData()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200008F")]
		public class Data
		{
			[Token(Token = "0x17000077")]
			[PrimaryKey]
			[Unique]
			public string id
			{
				[Token(Token = "0x60003E1")]
				[Address(RVA = "0x1032FF8", Offset = "0x1032FF8", VA = "0x1032FF8")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60003E2")]
				[Address(RVA = "0x1033000", Offset = "0x1033000", VA = "0x1033000")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x17000078")]
			public string data
			{
				[Token(Token = "0x60003E3")]
				[Address(RVA = "0x1033008", Offset = "0x1033008", VA = "0x1033008")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60003E4")]
				[Address(RVA = "0x1033010", Offset = "0x1033010", VA = "0x1033010")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x17000079")]
			public string scene
			{
				[Token(Token = "0x60003E5")]
				[Address(RVA = "0x1033018", Offset = "0x1033018", VA = "0x1033018")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60003E6")]
				[Address(RVA = "0x1033020", Offset = "0x1033020", VA = "0x1033020")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x60003E7")]
			[Address(RVA = "0x103214C", Offset = "0x103214C", VA = "0x103214C")]
			public Data()
			{
			}
		}

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool initialized;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private SQLiteConnection connection;

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x1031DD0", Offset = "0x1031DD0", VA = "0x1031DD0")]
		private void Initialize(string savePath)
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x1031FBC", Offset = "0x1031FBC", VA = "0x1031FBC", Slot = "5")]
		public override void ReadSaveFromPath(string savePath)
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x1031FC0", Offset = "0x1031FC0", VA = "0x1031FC0", Slot = "8")]
		public override void OnAfterLoad()
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x1031FC4", Offset = "0x1031FC4", VA = "0x1031FC4", Slot = "7")]
		public override void OnBeforeWrite()
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x1032020", Offset = "0x1032020", VA = "0x1032020", Slot = "10")]
		public override void Remove(string id)
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x1032078", Offset = "0x1032078", VA = "0x1032078", Slot = "11")]
		public override void Set(string id, string data, string scene)
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x1032154", Offset = "0x1032154", VA = "0x1032154", Slot = "12")]
		public override string Get(string id)
		{
			return null;
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x10321D4", Offset = "0x10321D4", VA = "0x10321D4", Slot = "9")]
		public override void WipeSceneData(string sceneName)
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x1032750", Offset = "0x1032750", VA = "0x1032750", Slot = "6")]
		public override void WriteSaveFile(SaveGame saveGame, string savePath)
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x10328F4", Offset = "0x10328F4", VA = "0x10328F4", Slot = "13")]
		public override void Dispose()
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x1032924", Offset = "0x1032924", VA = "0x1032924", Slot = "14")]
		public SaveGame ConvertTo(StorageType storageType, string filePath, bool replace = true)
		{
			return null;
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x1031DC8", Offset = "0x1031DC8", VA = "0x1031DC8")]
		public SaveGameSqlite()
		{
		}
	}
	[Token(Token = "0x2000091")]
	public class SaveSettings : ScriptableObject
	{
		[Token(Token = "0x2000092")]
		public enum SlotLoadBehaviour
		{
			[Token(Token = "0x4000364")]
			LoadDefaultSlot,
			[Token(Token = "0x4000365")]
			LoadTemporarySlot,
			[Token(Token = "0x4000366")]
			DontLoadSlot
		}

		[Token(Token = "0x2000093")]
		public enum SaveDirectory
		{
			[Token(Token = "0x4000368")]
			UnityPersistentDataDirectory,
			[Token(Token = "0x4000369")]
			GameFolderDesktopOnly
		}

		[Serializable]
		[Token(Token = "0x2000094")]
		public class SaveablePrefabThrottleOptions
		{
			[Token(Token = "0x400036A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Loads all saved instances throttled by default. Useful when you have a game that uses just one scene.\nMaking it possible to add a animated loading screen.")]
			public bool spawnThrottled;

			[Token(Token = "0x400036B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Range(0f, 120f)]
			[Tooltip("Will wait a frame when the framerate of the game is lower then specified amount")]
			public int throttleTargetFramerate;

			[Token(Token = "0x400036C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Will wait a frame when the total milliseconds of spawning objects adds upto 30 ms")]
			[Range(0f, 200f)]
			public int throttleTargetMilliseconds;

			[Token(Token = "0x400036D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool keepPrefabsDisabledUntilDone;

			[Token(Token = "0x400036E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
			[Tooltip("Ensures no saving/writing to disk is happening when throttled saved prefabs are being loaded.\n This is useful to prevent data loss.")]
			public bool disableAutoSaveDuringThrottle;

			[Token(Token = "0x400036F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
			public bool onlyThrottleSpecificScenes;

			[Token(Token = "0x4000370")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string[] throttleForScenes;

			[Token(Token = "0x60003EC")]
			[Address(RVA = "0x103320C", Offset = "0x103320C", VA = "0x103320C")]
			public SaveablePrefabThrottleOptions()
			{
			}
		}

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static SaveSettings instance;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Initialization")]
		[Tooltip("This slot will never be saved by default. Can be used to have some kind of saved state during play.You can save the data to a slot by using the SaveMaster.SetSlot(slotNumber ,keepActiveSaveData : true)")]
		public SlotLoadBehaviour slotLoadBehaviour;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(0f, 299f)]
		public int defaultSlot;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("Storage Settings - Save Files")]
		[Tooltip("You can learn more about the persistent directory when searching for Application.persistentDataPath in the Unity documentation.\n\nNote that it is recommended to use the first option for most platforms. When using the game folder option in the editor, it will save the game in the project folder.")]
		public SaveDirectory saveDirectory;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("Defines in what way to write savedata.Writing to JSON is most readable, Binary is a bit faster in terms of write/read. SQlite is good for big projects with thousands of objects that need to be saved.")]
		public StorageType storageType;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Apply a check or conversion if a storage type is different.\n\n-- Dontcheck --\nTry to read the file as given storage type no matter what\n\n-- Give Error --\nSends out a Unity Editor Error if type does not match. Returns a null save file\n\n-- Convert To Type --\nWill read out file with original type, and convert it to new storage type\n\n-- Replace --\nIf the type is different, replace it with a new file. WARNING: Replace will remove all data!")]
		public SaveFileValidation fileValidation;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string fileExtensionName;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string fileFolderName;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string temporaryFolderName;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string fileName;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string metaDataExtentionName;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Header("Storage Settings - Save Identification")]
		public string saveIdentifierReferenceFolder;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string saveIdentifierPrefix;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Header("Storage Settings - Encryption")]
		[Tooltip("This is mainly to prevent simple users to access save files and change the contents.Keep in mind that any experienced user is able to decompile the game and obtain the key somehow.Do note, this functionality is not supported for SQLite")]
		public EncryptionType encryptionType;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public string encryptionKey;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public string encryptionIV;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Header("Storage Settings - JSON")]
		public bool useJsonPrettyPrint;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
		[Tooltip("The old methodology added some garbage before the actual json text.This was because it was written as a BOM. Enabling this will make the save file unreadable foran older version of the Component Save System then 1.1. This is currently left off for this reason.")]
		public bool legacyJSONWriting;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[Range(1f, 300f)]
		[Header("Configuration")]
		public int maxSaveSlotCount;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[Tooltip("The save system will increment the time played since load")]
		public bool trackTimePlayed;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		[Tooltip("When you disable this, writing the game only happens when you call SaveMaster.Save()")]
		public bool autoSaveOnExit;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8A")]
		[Tooltip("Should the game get saved when switching between game saves?")]
		public bool autoSaveOnSlotSwitch;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8B")]
		[Header("Auto Save")]
		[Tooltip("Automatically save to the active slot based on a time interval, useful for WEBGL games")]
		public bool saveOnInterval;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[Range(1f, 3000f)]
		[Tooltip("Time interval in seconds before the auto save happens")]
		public int saveIntervalTime;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[Tooltip("Will do a check if object has already been instantiated with the ID")]
		[Header("Saveable")]
		public bool resetSaveableIdOnDuplicate;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
		[Tooltip("Will do a check if object is serialized under a different scene name")]
		public bool resetSaveableIdOnNewScene;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[Tooltip("Default generated guid length for a game object")]
		[Range(5f, 36f)]
		public int gameObjectGuidLength;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[Tooltip("Default generated guid length for a component")]
		[Range(5f, 36f)]
		public int componentGuidLength;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		[Tooltip("Script change: Dynamic components used to have components with <gameObjectName>-gameObject-01 etc.This has been replaced with proper naming. <gameObjetName>-<ScriptName>-01")]
		public bool legacyDynamicComponentNames;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9D")]
		[Header("Saveable Prefabs")]
		[Tooltip("Automatically remove saved instances when changing slots")]
		public bool cleanSavedPrefabsOnSlotSwitch;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9E")]
		[Tooltip("Cleans up any saved prefab instances that have no saved data tied to them.")]
		public bool cleanEmptySavedPrefabs;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public SaveablePrefabThrottleOptions throttleOptions;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[Header("Extras")]
		public bool useHotkeys;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public KeyCode saveAndWriteToDiskKey;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public KeyCode syncSaveGameKey;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public KeyCode syncLoadGameKey;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public KeyCode wipeActiveSceneData;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[Header("Debug (Unity Editor Only)")]
		public bool showSaveFileUtilityLog;

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x1033028", Offset = "0x1033028", VA = "0x1033028")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x1025968", Offset = "0x1025968", VA = "0x1025968")]
		public static SaveSettings Get()
		{
			return null;
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x103307C", Offset = "0x103307C", VA = "0x103307C")]
		public SaveSettings()
		{
		}
	}
}
namespace Lowscope.Saving.Core
{
	[Token(Token = "0x2000095")]
	public class MetaDataFileUtility
	{
		[Token(Token = "0x2000096")]
		public class MetaData : IDisposable
		{
			[Token(Token = "0x4000371")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly string filePath;

			[Token(Token = "0x4000372")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Dictionary<string, byte[]> idData;

			[Token(Token = "0x60003F3")]
			[Address(RVA = "0x10334C0", Offset = "0x10334C0", VA = "0x10334C0")]
			public MetaData(string filePath)
			{
			}

			[Token(Token = "0x60003F4")]
			[Address(RVA = "0x1033A84", Offset = "0x1033A84", VA = "0x1033A84", Slot = "4")]
			public void Dispose()
			{
			}

			[Token(Token = "0x60003F5")]
			[Address(RVA = "0x1033F34", Offset = "0x1033F34", VA = "0x1033F34")]
			public void SetData(string id, byte[] bytes)
			{
			}

			[Token(Token = "0x60003F6")]
			[Address(RVA = "0x103400C", Offset = "0x103400C", VA = "0x103400C")]
			public void SetData(string id, Texture2D texture)
			{
			}

			[Token(Token = "0x60003F7")]
			[Address(RVA = "0x10340A8", Offset = "0x10340A8", VA = "0x10340A8")]
			public void SetData(string id, string data)
			{
			}

			[Token(Token = "0x60003F8")]
			[Address(RVA = "0x1033F40", Offset = "0x1033F40", VA = "0x1033F40")]
			private void SetOrAddMetaData(string id, byte[] bytes)
			{
			}

			[Token(Token = "0x60003F9")]
			[Address(RVA = "0x1034114", Offset = "0x1034114", VA = "0x1034114")]
			public bool GetData(string id, out byte[] data)
			{
				return default(bool);
			}

			[Token(Token = "0x60003FA")]
			[Address(RVA = "0x10341B4", Offset = "0x10341B4", VA = "0x10341B4")]
			public bool GetData(string id, Texture2D tex)
			{
				return default(bool);
			}

			[Token(Token = "0x60003FB")]
			[Address(RVA = "0x1034244", Offset = "0x1034244", VA = "0x1034244")]
			public bool GetData(string id, out string data)
			{
				return default(bool);
			}

			[Token(Token = "0x60003FC")]
			[Address(RVA = "0x103431C", Offset = "0x103431C", VA = "0x103431C")]
			public void RemoveData(string id)
			{
			}
		}

		[Token(Token = "0x1700007A")]
		private static string fileMetaDataExtentionName
		{
			[Token(Token = "0x60003ED")]
			[Address(RVA = "0x1033224", Offset = "0x1033224", VA = "0x1033224")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007B")]
		private static string dataPath
		{
			[Token(Token = "0x60003EE")]
			[Address(RVA = "0x1033240", Offset = "0x1033240", VA = "0x1033240")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x103329C", Offset = "0x103329C", VA = "0x103329C")]
		public static MetaData[] GetAllMetaData()
		{
			return null;
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x10338D8", Offset = "0x10338D8", VA = "0x10338D8")]
		public static MetaData GetMetaData(string fileName)
		{
			return null;
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x10339B4", Offset = "0x10339B4", VA = "0x10339B4")]
		internal static void DeleteMetaData(string fileName)
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x1033A7C", Offset = "0x1033A7C", VA = "0x1033A7C")]
		public MetaDataFileUtility()
		{
		}
	}
	[Token(Token = "0x2000098")]
	[AddComponentMenu("")]
	public class SavedInstance : MonoBehaviour
	{
		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private SaveInstanceManager instanceManager;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool removeData;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private SaveInstanceManager.SpawnInfo spawnInfo;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int disableFrame;

		[Token(Token = "0x1700007C")]
		internal Saveable Saveable
		{
			[Token(Token = "0x6000401")]
			[Address(RVA = "0x1034458", Offset = "0x1034458", VA = "0x1034458")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000400")]
			[Address(RVA = "0x1034450", Offset = "0x1034450", VA = "0x1034450")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700007D")]
		public SaveInstanceManager.SpawnInfo SpawnInfo
		{
			[Token(Token = "0x6000402")]
			[Address(RVA = "0x1034460", Offset = "0x1034460", VA = "0x1034460")]
			get
			{
				return default(SaveInstanceManager.SpawnInfo);
			}
		}

		[Token(Token = "0x1700007E")]
		public bool DontSaveInstance
		{
			[Token(Token = "0x6000403")]
			[Address(RVA = "0x1034474", Offset = "0x1034474", VA = "0x1034474")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x10344B8", Offset = "0x10344B8", VA = "0x10344B8")]
		public void Configure(Saveable saveable, SaveInstanceManager instanceManager, SaveInstanceManager.SpawnInfo spawnInfo)
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x103450C", Offset = "0x103450C", VA = "0x103450C")]
		public void Destroy()
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x10345C0", Offset = "0x10345C0", VA = "0x10345C0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x10345CC", Offset = "0x10345CC", VA = "0x10345CC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x10345E8", Offset = "0x10345E8", VA = "0x10345E8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x10347B0", Offset = "0x10347B0", VA = "0x10347B0")]
		public SavedInstance()
		{
		}
	}
	[Token(Token = "0x2000099")]
	public class SaveFileUtility
	{
		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static AESEncryption encryption;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Dictionary<int, string> cachedSlotSaveFileNames;

		[Token(Token = "0x1700007F")]
		public static string fileExtentionName
		{
			[Token(Token = "0x600040B")]
			[Address(RVA = "0x103481C", Offset = "0x103481C", VA = "0x103481C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000080")]
		public static string gameFileName
		{
			[Token(Token = "0x600040C")]
			[Address(RVA = "0x1034838", Offset = "0x1034838", VA = "0x1034838")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000081")]
		public static string metaExtentionName
		{
			[Token(Token = "0x600040D")]
			[Address(RVA = "0x1034854", Offset = "0x1034854", VA = "0x1034854")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000082")]
		private static bool debugMode
		{
			[Token(Token = "0x600040E")]
			[Address(RVA = "0x1034870", Offset = "0x1034870", VA = "0x1034870")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000083")]
		private static string saveDirectoryPath
		{
			[Token(Token = "0x600040F")]
			[Address(RVA = "0x103488C", Offset = "0x103488C", VA = "0x103488C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000084")]
		public static string TempFolderPath
		{
			[Token(Token = "0x6000410")]
			[Address(RVA = "0x10348D4", Offset = "0x10348D4", VA = "0x10348D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000085")]
		public static string SaveFolderPath
		{
			[Token(Token = "0x6000411")]
			[Address(RVA = "0x1034948", Offset = "0x1034948", VA = "0x1034948")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x10347C8", Offset = "0x10347C8", VA = "0x10347C8")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void ResetVariable()
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x10349A0", Offset = "0x10349A0", VA = "0x10349A0")]
		private static void Log(string text)
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x1034A0C", Offset = "0x1034A0C", VA = "0x1034A0C")]
		public static Dictionary<int, string> ObtainSlotSaveFileNames()
		{
			return null;
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x1034D4C", Offset = "0x1034D4C", VA = "0x1034D4C")]
		public static string GetSaveFilePath(string fileName)
		{
			return null;
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x1034E20", Offset = "0x1034E20", VA = "0x1034E20")]
		public static void EncryptSaveFile(string savePath)
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x1035004", Offset = "0x1035004", VA = "0x1035004")]
		public static void DecryptSaveFile(string savePath)
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x1035204", Offset = "0x1035204", VA = "0x1035204")]
		private static bool GetFileStorageType(string savePath, out StorageType storageType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x1035490", Offset = "0x1035490", VA = "0x1035490")]
		internal static SaveGame CreateSaveGameInstance(StorageType storageType)
		{
			return null;
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x1035550", Offset = "0x1035550", VA = "0x1035550")]
		private static SaveGame LoadSave(string fileName, int slot = -1)
		{
			return null;
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x1035E18", Offset = "0x1035E18", VA = "0x1035E18")]
		public static int[] GetUsedSlots()
		{
			return null;
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x1035FEC", Offset = "0x1035FEC", VA = "0x1035FEC")]
		public static int GetSaveSlotCount()
		{
			return default(int);
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x1036030", Offset = "0x1036030", VA = "0x1036030")]
		public static SaveGame LoadSave(int slot, bool createIfEmpty = false)
		{
			return null;
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x10359F4", Offset = "0x10359F4", VA = "0x10359F4")]
		public static void WriteSave(SaveGame saveGame, int saveSlot = -1, string fileName = "")
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x1036320", Offset = "0x1036320", VA = "0x1036320")]
		public static void DeleteSave(int slot)
		{
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x1036704", Offset = "0x1036704", VA = "0x1036704")]
		public static void DeleteAllSaveFiles()
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x10369B4", Offset = "0x10369B4", VA = "0x10369B4")]
		public static bool IsSlotUsed(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x1036A08", Offset = "0x1036A08", VA = "0x1036A08")]
		public static bool IsSaveFileNameUsed(string fileName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x1036A78", Offset = "0x1036A78", VA = "0x1036A78")]
		public static int GetAvailableSaveSlot()
		{
			return default(int);
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x1036AFC", Offset = "0x1036AFC", VA = "0x1036AFC")]
		public static string ObtainSlotFileName(int slot)
		{
			return null;
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x1036C48", Offset = "0x1036C48", VA = "0x1036C48")]
		public SaveFileUtility()
		{
		}
	}
	[Token(Token = "0x200009B")]
	[DefaultExecutionOrder(-9100)]
	[AddComponentMenu("")]
	public class SaveInstanceManager : MonoBehaviour
	{
		[Token(Token = "0x200009C")]
		public enum SpawnSource
		{
			[Token(Token = "0x400038E")]
			FromSave,
			[Token(Token = "0x400038F")]
			FromUserCode
		}

		[Token(Token = "0x200009D")]
		public class CachedPrefab
		{
			[Token(Token = "0x4000390")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GameObject prefab;

			[Token(Token = "0x4000391")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string[] componentIDs;

			[Token(Token = "0x4000392")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool valid;

			[Token(Token = "0x600043D")]
			[Address(RVA = "0x10388FC", Offset = "0x10388FC", VA = "0x10388FC")]
			public CachedPrefab()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200009E")]
		public class SaveData
		{
			[Token(Token = "0x4000393")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<SpawnInfo> infoCollection;

			[Token(Token = "0x4000394")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int spawnCountHistory;

			[Token(Token = "0x600043E")]
			[Address(RVA = "0x103803C", Offset = "0x103803C", VA = "0x103803C")]
			public SaveData()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200009F")]
		public struct SpawnInfo
		{
			[Token(Token = "0x4000395")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public InstanceSource source;

			[Token(Token = "0x4000396")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string filePath;

			[Token(Token = "0x4000397")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string saveIdentification;

			[Token(Token = "0x4000398")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string customSource;

			[Token(Token = "0x4000399")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string userTag;

			[NonSerialized]
			[Token(Token = "0x400039A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public SpawnSource spawnSource;

			[Token(Token = "0x600043F")]
			[Address(RVA = "0x10387E8", Offset = "0x10387E8", VA = "0x10387E8")]
			public bool IsValidData()
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000A0")]
		[CompilerGenerated]
		private sealed class <SpawnPrefabsThrottled>d__38 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400039B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400039C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400039D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SaveInstanceManager <>4__this;

			[Token(Token = "0x400039E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <targetSpawnFramerate>5__2;

			[Token(Token = "0x400039F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private int <taretSpawnMilliseconds>5__3;

			[Token(Token = "0x40003A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private bool <keepDisabledUntilDone>5__4;

			[Token(Token = "0x40003A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private int <spawnTotal>5__5;

			[Token(Token = "0x40003A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int <spawnCount>5__6;

			[Token(Token = "0x40003A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Stopwatch <sw>5__7;

			[Token(Token = "0x40003A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private List<GameObject> <disabledObjects>5__8;

			[Token(Token = "0x40003A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private int <i>5__9;

			[Token(Token = "0x1700008B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000443")]
				[Address(RVA = "0x1038FB8", Offset = "0x1038FB8", VA = "0x1038FB8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000445")]
				[Address(RVA = "0x1039000", Offset = "0x1039000", VA = "0x1039000", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000440")]
			[Address(RVA = "0x10388D4", Offset = "0x10388D4", VA = "0x10388D4")]
			[DebuggerHidden]
			public <SpawnPrefabsThrottled>d__38(int <>1__state)
			{
			}

			[Token(Token = "0x6000441")]
			[Address(RVA = "0x1038AEC", Offset = "0x1038AEC", VA = "0x1038AEC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000442")]
			[Address(RVA = "0x1038AF0", Offset = "0x1038AF0", VA = "0x1038AF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000444")]
			[Address(RVA = "0x1038FC0", Offset = "0x1038FC0", VA = "0x1038FC0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Dictionary<SavedInstance, SpawnInfo> spawnInfo;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private HashSet<string> loadedIDs;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Dictionary<string, CachedPrefab> cachedResourcePrefabs;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int spawnCountHistory;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int changesMade;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<SpawnInfo> throttledSpawnList;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool spawnThrottled;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private SaveData saveData;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool quittingApplication;

		[Token(Token = "0x17000086")]
		public string SceneID
		{
			[Token(Token = "0x600042B")]
			[Address(RVA = "0x1036D54", Offset = "0x1036D54", VA = "0x1036D54")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600042A")]
			[Address(RVA = "0x1036D4C", Offset = "0x1036D4C", VA = "0x1036D4C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000087")]
		public Scene Scene
		{
			[Token(Token = "0x600042D")]
			[Address(RVA = "0x1036D64", Offset = "0x1036D64", VA = "0x1036D64")]
			[CompilerGenerated]
			get
			{
				return default(Scene);
			}
			[Token(Token = "0x600042C")]
			[Address(RVA = "0x1036D5C", Offset = "0x1036D5C", VA = "0x1036D5C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000088")]
		public Saveable Saveable
		{
			[Token(Token = "0x600042F")]
			[Address(RVA = "0x1036D74", Offset = "0x1036D74", VA = "0x1036D74")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600042E")]
			[Address(RVA = "0x1036D6C", Offset = "0x1036D6C", VA = "0x1036D6C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000089")]
		public int LoadedIDCount
		{
			[Token(Token = "0x6000430")]
			[Address(RVA = "0x1036D7C", Offset = "0x1036D7C", VA = "0x1036D7C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700008A")]
		public string SaveID
		{
			[Token(Token = "0x6000431")]
			[Address(RVA = "0x1036DC4", Offset = "0x1036DC4", VA = "0x1036DC4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000432")]
			[Address(RVA = "0x1036DCC", Offset = "0x1036DCC", VA = "0x1036DCC")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x1036DD4", Offset = "0x1036DD4", VA = "0x1036DD4")]
		public void DestroyAllObjects()
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x10370E4", Offset = "0x10370E4", VA = "0x10370E4")]
		public void ClearData()
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x10346D4", Offset = "0x10346D4", VA = "0x10346D4")]
		public void DestroyObject(SavedInstance savedInstance, Saveable saveable)
		{
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x1037168", Offset = "0x1037168", VA = "0x1037168")]
		public SavedInstance SpawnObject(InstanceSource source, string filePath, string customSourcePath = "", string saveIdentification = "", string userTag = "", SpawnSource spawnSource = SpawnSource.FromUserCode, bool spawnInactive = false)
		{
			return null;
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x1037BD8", Offset = "0x1037BD8", VA = "0x1037BD8")]
		public void OnSave(SaveGame saveGame)
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x1038044", Offset = "0x1038044", VA = "0x1038044")]
		public void OnLoad(SaveGame saveGame)
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x1038718", Offset = "0x1038718", VA = "0x1038718")]
		public bool CanSpawnThrottled()
		{
			return default(bool);
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x1038860", Offset = "0x1038860", VA = "0x1038860")]
		[IteratorStateMachine(typeof(<SpawnPrefabsThrottled>d__38))]
		private IEnumerator SpawnPrefabsThrottled()
		{
			return null;
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x10376E4", Offset = "0x10376E4", VA = "0x10376E4")]
		public CachedPrefab GetPrefabData(InstanceSource source, string path, string customSourcePath = "")
		{
			return null;
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x1038904", Offset = "0x1038904", VA = "0x1038904")]
		public SaveInstanceManager()
		{
		}
	}
	[Token(Token = "0x20000A1")]
	public class SaveTransferUtility
	{
		[Token(Token = "0x6000446")]
		[Address(RVA = "0x1039008", Offset = "0x1039008", VA = "0x1039008")]
		public static string ConvertSaveToWebJSON(SaveGame saveGame)
		{
			return null;
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x10391E8", Offset = "0x10391E8", VA = "0x10391E8")]
		public static void OverwriteSaveWithWebJSON(string json, string fileName)
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x10394C0", Offset = "0x10394C0", VA = "0x10394C0")]
		private static StringBuilder ModifyJSONDataEntries(string json, Func<StringBuilder, StringBuilder> modifyLine)
		{
			return null;
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x10397BC", Offset = "0x10397BC", VA = "0x10397BC")]
		private static List<int> AllIndexesOf(string str, string searchstring)
		{
			return null;
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x10398F4", Offset = "0x10398F4", VA = "0x10398F4")]
		public SaveTransferUtility()
		{
		}
	}
}
namespace Lowscope.Saving.Components
{
	[Token(Token = "0x20000A3")]
	[AddComponentMenu("Saving/Components/Extras/Save Event Listener")]
	[DisallowMultipleComponent]
	public class SaveEventListener : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000A4")]
		public class UnityEventSavedInstance : UnityEvent<Scene, SavedInstance>
		{
			[Token(Token = "0x6000459")]
			[Address(RVA = "0x103B5DC", Offset = "0x103B5DC", VA = "0x103B5DC")]
			public UnityEventSavedInstance()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000A5")]
		public class UnityEventSlotChange : UnityEvent<int, int>
		{
			[Token(Token = "0x600045A")]
			[Address(RVA = "0x103B624", Offset = "0x103B624", VA = "0x103B624")]
			public UnityEventSlotChange()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000A6")]
		public class UnityEventInt : UnityEvent<int>
		{
			[Token(Token = "0x600045B")]
			[Address(RVA = "0x103B66C", Offset = "0x103B66C", VA = "0x103B66C")]
			public UnityEventInt()
			{
			}
		}

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Parameters (NewSlot, OldSlot)")]
		public UnityEventSlotChange EventOnSlotChangeBegin;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UnityEventSlotChange EventOnSlotChangeDone;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("Parameter (Slot)")]
		public UnityEventInt EventOnSyncSaveBegin;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UnityEventInt EventOnSyncSaveDone;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UnityEventInt EventOnWriteToDiskBegin;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UnityEventInt EventOnWriteToDiskDone;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public UnityEventInt eventOnDeletedSave;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Header("Parameters (Scene, SavedInstance)")]
		public UnityEventSavedInstance EventOnSpawnedSavedInstance;

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x1039A4C", Offset = "0x1039A4C", VA = "0x1039A4C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x1039E98", Offset = "0x1039E98", VA = "0x1039E98")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x103A2E4", Offset = "0x103A2E4", VA = "0x103A2E4")]
		private void OnSpawnedSavedInstance(Scene arg1, SavedInstance arg2)
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x103A34C", Offset = "0x103A34C", VA = "0x103A34C")]
		private void OnWritingToDiskDone(int obj)
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x103A3A4", Offset = "0x103A3A4", VA = "0x103A3A4")]
		private void OnWritingToDiskBegin(int obj)
		{
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x103A3FC", Offset = "0x103A3FC", VA = "0x103A3FC")]
		private void OnSaveSyncDone(int obj)
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x103A454", Offset = "0x103A454", VA = "0x103A454")]
		private void OnSaveSyncBegin(int obj)
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x103A4AC", Offset = "0x103A4AC", VA = "0x103A4AC")]
		private void OnSlotChangeDone(int arg1, int arg2)
		{
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x103A514", Offset = "0x103A514", VA = "0x103A514")]
		private void OnSlotChangeBegin(int arg1, int arg2)
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x103A57C", Offset = "0x103A57C", VA = "0x103A57C")]
		private void OnDeletedSave(int obj)
		{
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x103A5D4", Offset = "0x103A5D4", VA = "0x103A5D4")]
		public SaveEventListener()
		{
		}
	}
	[Token(Token = "0x20000A7")]
	[AddComponentMenu("Saving/Components/Extras/Write Save To Disk")]
	[DisallowMultipleComponent]
	public class WriteSaveToDisk : MonoBehaviour
	{
		[Token(Token = "0x20000A8")]
		public enum Trigger
		{
			[Token(Token = "0x40003B3")]
			OnEnable,
			[Token(Token = "0x40003B4")]
			OnStart
		}

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("You can also call save using ")]
		[Tooltip("Triggers that can save the game.")]
		public Trigger[] saveTriggers;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private HashSet<Trigger> triggers;

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x103B6B4", Offset = "0x103B6B4", VA = "0x103B6B4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x103B790", Offset = "0x103B790", VA = "0x103B790")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x103B84C", Offset = "0x103B84C", VA = "0x103B84C")]
		private void Start()
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x103B7F8", Offset = "0x103B7F8", VA = "0x103B7F8")]
		public void TriggerSave()
		{
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x103B8B4", Offset = "0x103B8B4", VA = "0x103B8B4")]
		public WriteSaveToDisk()
		{
		}
	}
	[Token(Token = "0x20000A9")]
	[AddComponentMenu("Saving/Saveable")]
	[DisallowMultipleComponent]
	public class Saveable : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000AA")]
		public class CachedSaveableComponent
		{
			[Token(Token = "0x40003C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SaveIdentifierReference identification;

			[Token(Token = "0x40003C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MonoBehaviour monoBehaviour;

			[Token(Token = "0x600047D")]
			[Address(RVA = "0x103CEE0", Offset = "0x103CEE0", VA = "0x103CEE0")]
			public CachedSaveableComponent()
			{
			}
		}

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static HashSet<ISaveable> loadedSaveableComponents;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Will never allow the object to load data more then once.this is useful for persistent game objects.")]
		[SerializeField]
		[Header("Save Configuration")]
		private bool loadOnce;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[Tooltip("Save and Load will not be called by the Save System.this is useful for displaying data from a different save file")]
		[SerializeField]
		private bool manualSaveLoad;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		[Tooltip("Still attempts to save data even if object is disabled. (Do note, this only works when it has been enabled once)")]
		[SerializeField]
		[Header("Initialization options")]
		private bool saveWhenDisabled;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		[SerializeField]
		[Tooltip("Use this if you want to deactivate the object once it has been initialized. This ensures saving works when it is disabled.")]
		private bool deactivateObjectWhenInitialized;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		[SerializeField]
		private List<CachedSaveableComponent> cachedSaveableComponents;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<string> saveableComponentIDs;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<ISaveable> saveableComponentObjects;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Header("Identification")]
		[SerializeField]
		private SaveIdentifierReference saveIdentifier;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool hasLoaded;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		private bool hasStateReset;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
		private bool hasIdentification;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform thisTransform;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private GameObject thisGameObject;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int disableFrame;

		[Token(Token = "0x1700008D")]
		public bool SaveWhenDisabled
		{
			[Token(Token = "0x6000464")]
			[Address(RVA = "0x103BA78", Offset = "0x103BA78", VA = "0x103BA78")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000463")]
			[Address(RVA = "0x103BA6C", Offset = "0x103BA6C", VA = "0x103BA6C")]
			set
			{
			}
		}

		[Token(Token = "0x1700008E")]
		public List<CachedSaveableComponent> CachedSaveableComponents
		{
			[Token(Token = "0x6000465")]
			[Address(RVA = "0x103BA80", Offset = "0x103BA80", VA = "0x103BA80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008F")]
		public string SaveIdentification
		{
			[Token(Token = "0x6000466")]
			[Address(RVA = "0x103BA88", Offset = "0x103BA88", VA = "0x103BA88")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000467")]
			[Address(RVA = "0x103BB44", Offset = "0x103BB44", VA = "0x103BB44")]
			set
			{
			}
		}

		[Token(Token = "0x17000090")]
		public bool HasLoaded
		{
			[Token(Token = "0x6000468")]
			[Address(RVA = "0x103BC0C", Offset = "0x103BC0C", VA = "0x103BC0C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000091")]
		public bool HasStateReset
		{
			[Token(Token = "0x6000469")]
			[Address(RVA = "0x103BC14", Offset = "0x103BC14", VA = "0x103BC14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000092")]
		public bool HasIdentification
		{
			[Token(Token = "0x600046A")]
			[Address(RVA = "0x103BC1C", Offset = "0x103BC1C", VA = "0x103BC1C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000093")]
		internal bool HasLoadedAnyComponents
		{
			[Token(Token = "0x600046C")]
			[Address(RVA = "0x103BC30", Offset = "0x103BC30", VA = "0x103BC30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600046B")]
			[Address(RVA = "0x103BC24", Offset = "0x103BC24", VA = "0x103BC24")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000094")]
		internal bool HasSavedAnyComponents
		{
			[Token(Token = "0x600046E")]
			[Address(RVA = "0x103BC44", Offset = "0x103BC44", VA = "0x103BC44")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600046D")]
			[Address(RVA = "0x103BC38", Offset = "0x103BC38", VA = "0x103BC38")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000095")]
		public bool ManualSaveLoad
		{
			[Token(Token = "0x600046F")]
			[Address(RVA = "0x103BC4C", Offset = "0x103BC4C", VA = "0x103BC4C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000470")]
			[Address(RVA = "0x103BC54", Offset = "0x103BC54", VA = "0x103BC54")]
			set
			{
			}
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x103B974", Offset = "0x103B974", VA = "0x103B974")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void ResetVariables()
		{
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x103B9EC", Offset = "0x103B9EC", VA = "0x103B9EC")]
		public static bool IsComponentLoaded(ISaveable saveable)
		{
			return default(bool);
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x103BC60", Offset = "0x103BC60", VA = "0x103BC60")]
		public void ScanAddSaveableComponents()
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x103BE20", Offset = "0x103BE20", VA = "0x103BE20")]
		public void AddSaveableComponent(string identifier, ISaveable iSaveable, bool reloadData = false)
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x103BFDC", Offset = "0x103BFDC", VA = "0x103BFDC")]
		public List<string> GetSaveIdentifications()
		{
			return null;
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x103C194", Offset = "0x103C194", VA = "0x103C194")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x103C464", Offset = "0x103C464", VA = "0x103C464")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x103C480", Offset = "0x103C480", VA = "0x103C480")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x103C528", Offset = "0x103C528", VA = "0x103C528")]
		public void WipeData(SaveGame saveGame, bool stopSaving = true)
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x103C61C", Offset = "0x103C61C", VA = "0x103C61C")]
		public void ResetState()
		{
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x103C62C", Offset = "0x103C62C", VA = "0x103C62C")]
		public void OnSaveRequest(SaveGame saveGame)
		{
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x103C9AC", Offset = "0x103C9AC", VA = "0x103C9AC")]
		public void OnLoadRequest(SaveGame saveGame)
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x103CC80", Offset = "0x103CC80", VA = "0x103CC80")]
		public Saveable()
		{
		}
	}
	[Token(Token = "0x20000AB")]
	[AddComponentMenu("Saving/Components/Save Position")]
	[DisallowMultipleComponent]
	public class SavePosition : MonoBehaviour, ISaveable
	{
		[Serializable]
		[Token(Token = "0x20000AC")]
		public struct SaveData
		{
			[Token(Token = "0x40003CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 position;
		}

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vector3 lastPosition;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Space space;

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x103CF50", Offset = "0x103CF50", VA = "0x103CF50", Slot = "5")]
		public void OnLoad(string data)
		{
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x103D004", Offset = "0x103D004", VA = "0x103D004", Slot = "4")]
		public string OnSave()
		{
			return null;
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x103D0A4", Offset = "0x103D0A4", VA = "0x103D0A4", Slot = "6")]
		public bool OnSaveCondition()
		{
			return default(bool);
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x103D120", Offset = "0x103D120", VA = "0x103D120")]
		public SavePosition()
		{
		}
	}
	[Token(Token = "0x20000AD")]
	[DisallowMultipleComponent]
	[AddComponentMenu("Saving/Components/Save Rotation")]
	public class SaveRotation : MonoBehaviour, ISaveable
	{
		[Serializable]
		[Token(Token = "0x20000AE")]
		public struct SaveData
		{
			[Token(Token = "0x40003CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 rotation;
		}

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vector3 lastRotation;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 activeRotation;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Space space;

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x103D180", Offset = "0x103D180", VA = "0x103D180", Slot = "5")]
		public void OnLoad(string data)
		{
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x103D23C", Offset = "0x103D23C", VA = "0x103D23C", Slot = "4")]
		public string OnSave()
		{
			return null;
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x103D2F0", Offset = "0x103D2F0", VA = "0x103D2F0", Slot = "6")]
		public bool OnSaveCondition()
		{
			return default(bool);
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x103D394", Offset = "0x103D394", VA = "0x103D394")]
		public SaveRotation()
		{
		}
	}
	[Token(Token = "0x20000AF")]
	[DisallowMultipleComponent]
	[AddComponentMenu("Saving/Components/Save Scale")]
	public class SaveScale : MonoBehaviour, ISaveable
	{
		[Serializable]
		[Token(Token = "0x20000B0")]
		public struct SaveData
		{
			[Token(Token = "0x40003D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 scale;
		}

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vector3 lastScale;

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x103D3F4", Offset = "0x103D3F4", VA = "0x103D3F4", Slot = "5")]
		public void OnLoad(string data)
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x103D498", Offset = "0x103D498", VA = "0x103D498", Slot = "4")]
		public string OnSave()
		{
			return null;
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x103D528", Offset = "0x103D528", VA = "0x103D528", Slot = "6")]
		public bool OnSaveCondition()
		{
			return default(bool);
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x103D594", Offset = "0x103D594", VA = "0x103D594")]
		public SaveScale()
		{
		}
	}
	[Token(Token = "0x20000B1")]
	[AddComponentMenu("Saving/Components/Extras/Save Screenshot")]
	[DisallowMultipleComponent]
	public class SaveScreenshot : MonoBehaviour
	{
		[Token(Token = "0x20000B2")]
		public enum SaveTrigger
		{
			[Token(Token = "0x40003DB")]
			OnSaveWriteToDisk,
			[Token(Token = "0x40003DC")]
			OnDestroy,
			[Token(Token = "0x40003DD")]
			OnDisable,
			[Token(Token = "0x40003DE")]
			OnEnable,
			[Token(Token = "0x40003DF")]
			Manual
		}

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SaveTrigger[] saveTriggers;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Camera camera;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Tooltip("All referenced canvases will be set Screen Space - Camera temporarily. Only do this if the canvas isn't getting shown.")]
		private Canvas[] ensureCanvasDisplay;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject[] hideObjectsFromScreenshot;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private LayerMask screenshotCameraCullingMask;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RenderMode[] renderModes;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private HashSet<SaveTrigger> triggers;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Tooltip("At what resolution should the screenshots be made?")]
		private Vector2Int resolution;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Range(0.25f, 1f)]
		[SerializeField]
		[Tooltip("How large should the screenshot be based on the current screen resolution?")]
		private float resolutionScale;

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x103D59C", Offset = "0x103D59C", VA = "0x103D59C")]
		private void Reset()
		{
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x103D640", Offset = "0x103D640", VA = "0x103D640")]
		private void Awake()
		{
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x103D7D8", Offset = "0x103D7D8", VA = "0x103D7D8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x103DA04", Offset = "0x103DA04", VA = "0x103DA04")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x103DA70", Offset = "0x103DA70", VA = "0x103DA70")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x103D920", Offset = "0x103D920", VA = "0x103D920")]
		public void StoreScreenShot()
		{
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x103DADC", Offset = "0x103DADC", VA = "0x103DADC")]
		public void StoreScreenShot(int slot)
		{
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x103E220", Offset = "0x103E220", VA = "0x103E220")]
		public SaveScreenshot()
		{
		}
	}
	[Token(Token = "0x20000B3")]
	[AddComponentMenu("Saving/Components/Save Visibility")]
	public class SaveVisibility : MonoBehaviour, ISaveable
	{
		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool isEnabled;

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x103E2F0", Offset = "0x103E2F0", VA = "0x103E2F0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x103E2FC", Offset = "0x103E2FC", VA = "0x103E2FC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x103E374", Offset = "0x103E374", VA = "0x103E374", Slot = "5")]
		public void OnLoad(string data)
		{
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x103E3F4", Offset = "0x103E3F4", VA = "0x103E3F4", Slot = "4")]
		public string OnSave()
		{
			return null;
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x103E460", Offset = "0x103E460", VA = "0x103E460", Slot = "6")]
		public bool OnSaveCondition()
		{
			return default(bool);
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x103E468", Offset = "0x103E468", VA = "0x103E468")]
		public SaveVisibility()
		{
		}
	}
	[Token(Token = "0x20000B4")]
	[DefaultExecutionOrder(-9014)]
	[AddComponentMenu("Saving/Components/Scene Loading/Load Last Used Scenes")]
	[DisallowMultipleComponent]
	public class LoadLastUsedScenes : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000B5")]
		public class Settings
		{
			[Token(Token = "0x40003E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LoadTrigger[] loadTriggers;

			[Token(Token = "0x40003E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool onlyLoadIfMainSceneIsDifferent;

			[Token(Token = "0x40003E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			public bool onlyLoadIfAnyAdditionalScenesAreDifferent;

			[Token(Token = "0x40003E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			[Tooltip("This will ensure nothing happens if this component is disabled. Useful if you have Load Default slot turned on.")]
			public bool stopListeningIfDisabled;

			[Token(Token = "0x40003E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Create a new asset by doing create asset Component Save System/Fallback Scene Data")]
			public FallbackSceneData fallbackSceneData;

			[Token(Token = "0x40003E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Load this scene if it could not find data for a specific save slot")]
			public string defaultSceneIfEmpty;

			[Token(Token = "0x60004A0")]
			[Address(RVA = "0x103F318", Offset = "0x103F318", VA = "0x103F318")]
			public Settings()
			{
			}
		}

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Settings settings;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private HashSet<LoadTrigger> triggers;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool subscribed;

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x103E470", Offset = "0x103E470", VA = "0x103E470")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x103E61C", Offset = "0x103E61C", VA = "0x103E61C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x103ED80", Offset = "0x103ED80", VA = "0x103ED80")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x103EEC0", Offset = "0x103EEC0", VA = "0x103EEC0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x103F004", Offset = "0x103F004", VA = "0x103F004")]
		private void Start()
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x103F16C", Offset = "0x103F16C", VA = "0x103F16C")]
		private void OnSlotChangeDone(int newSlot, int fromSlot)
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x103E764", Offset = "0x103E764", VA = "0x103E764")]
		public void Load()
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x103F258", Offset = "0x103F258", VA = "0x103F258")]
		public LoadLastUsedScenes()
		{
		}
	}
	[Token(Token = "0x20000B6")]
	[DefaultExecutionOrder(-9014)]
	[DisallowMultipleComponent]
	[AddComponentMenu("Saving/Components/Scene Loading/Load Scene On Save Trigger")]
	public class LoadSceneOnSaveTrigger : MonoBehaviour
	{
		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Tooltip("Does not load a scene if the save has just been created.")]
		[Header("Configuration")]
		private bool ignoreOnNewSave;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LoadTrigger[] loadTriggers;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string sceneToLoad;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string[] scenesToLoadAdditive;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private HashSet<LoadTrigger> triggers;

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x103F384", Offset = "0x103F384", VA = "0x103F384")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x103F51C", Offset = "0x103F51C", VA = "0x103F51C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x103F7DC", Offset = "0x103F7DC", VA = "0x103F7DC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x103F848", Offset = "0x103F848", VA = "0x103F848")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x103F8B4", Offset = "0x103F8B4", VA = "0x103F8B4")]
		private void Start()
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x103FA1C", Offset = "0x103FA1C", VA = "0x103FA1C")]
		private void OnSlotChangeDone(int newSlot, int fromSlot)
		{
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x103F664", Offset = "0x103F664", VA = "0x103F664")]
		public void Load()
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x103FA2C", Offset = "0x103FA2C", VA = "0x103FA2C")]
		public LoadSceneOnSaveTrigger()
		{
		}
	}
	[Token(Token = "0x20000B7")]
	[AddComponentMenu("Saving/Components/Scene Loading/Save Last Used Scenes")]
	[DisallowMultipleComponent]
	public class SaveLastUsedScenes : MonoBehaviour
	{
		[Token(Token = "0x20000B8")]
		public enum SaveTrigger
		{
			[Token(Token = "0x40003F3")]
			OnSaveWriteToDisk,
			[Token(Token = "0x40003F4")]
			OnSyncSaveDone,
			[Token(Token = "0x40003F5")]
			OnDestroy,
			[Token(Token = "0x40003F6")]
			OnDisable,
			[Token(Token = "0x40003F7")]
			OnEnable,
			[Token(Token = "0x40003F8")]
			Manual
		}

		[Serializable]
		[Token(Token = "0x20000B9")]
		public class SavedScenes
		{
			[Token(Token = "0x40003F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string activeSceneName;

			[Token(Token = "0x40003FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public List<string> additionalSceneNames;

			[Token(Token = "0x60004B1")]
			[Address(RVA = "0x10402F8", Offset = "0x10402F8", VA = "0x10402F8")]
			public SavedScenes()
			{
			}
		}

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SaveTrigger[] saveTriggers;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool saveAdditiveScenes;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private HashSet<SaveTrigger> triggers;

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x103FAEC", Offset = "0x103FAEC", VA = "0x103FAEC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x103FD24", Offset = "0x103FD24", VA = "0x103FD24")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x103FE78", Offset = "0x103FE78", VA = "0x103FE78")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x103FEE4", Offset = "0x103FEE4", VA = "0x103FEE4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x10400CC", Offset = "0x10400CC", VA = "0x10400CC")]
		private void OnEvent(int slot)
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x103FD90", Offset = "0x103FD90", VA = "0x103FD90")]
		public void Save()
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x10400D0", Offset = "0x10400D0", VA = "0x10400D0")]
		private SavedScenes GetSavedSceneData()
		{
			return null;
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x1040300", Offset = "0x1040300", VA = "0x1040300")]
		public SaveLastUsedScenes()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000BA")]
	public class RerouteSceneSettings
	{
		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string OldSceneName;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string NewSceneName;

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x10403CC", Offset = "0x10403CC", VA = "0x10403CC")]
		public RerouteSceneSettings()
		{
		}
	}
	[Token(Token = "0x20000BB")]
	[CreateAssetMenu(fileName = "Fallback Scene Data", menuName = "Component Save System/Fallback Scene Data")]
	public class FallbackSceneData : ScriptableObject
	{
		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RerouteSceneSettings[] settings;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly Dictionary<string, string> indexedFallbackScenes;

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x103F17C", Offset = "0x103F17C", VA = "0x103F17C")]
		public string GetFallbackScene(string sceneName)
		{
			return null;
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x10403D4", Offset = "0x10403D4", VA = "0x10403D4")]
		private void IndexFallbackScenes()
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x104047C", Offset = "0x104047C", VA = "0x104047C")]
		public FallbackSceneData()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000BC")]
	public class SaveIdentifierReference
	{
		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool UseConstant;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[FormerlySerializedAs("saveIdentification")]
		public string ConstantValue;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SaveIdentifierVariable Variable;

		[Token(Token = "0x17000096")]
		public string Value
		{
			[Token(Token = "0x60004B8")]
			[Address(RVA = "0x103BAA0", Offset = "0x103BAA0", VA = "0x103BAA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x103CDE8", Offset = "0x103CDE8", VA = "0x103CDE8")]
		public SaveIdentifierReference()
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x1040504", Offset = "0x1040504", VA = "0x1040504")]
		public SaveIdentifierReference(string value)
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x1040588", Offset = "0x1040588", VA = "0x1040588")]
		public static implicit operator string(SaveIdentifierReference reference)
		{
			return null;
		}
	}
	[Token(Token = "0x20000BD")]
	[CreateAssetMenu(fileName = "Save Identifier Reference", menuName = "Saving/Save Identifier Reference")]
	public class SaveIdentifierVariable : ScriptableObject
	{
		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string identifier;

		[Token(Token = "0x17000097")]
		public string Identifier
		{
			[Token(Token = "0x60004BA")]
			[Address(RVA = "0x1040598", Offset = "0x1040598", VA = "0x1040598")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004BB")]
			[Address(RVA = "0x10405A0", Offset = "0x10405A0", VA = "0x10405A0")]
			set
			{
			}
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x10405A8", Offset = "0x10405A8", VA = "0x10405A8")]
		public SaveIdentifierVariable()
		{
		}
	}
	[Token(Token = "0x20000BE")]
	[AddComponentMenu("Saving/Components/Extras/Save Screenshot Displayer")]
	[DisallowMultipleComponent]
	public class SaveScreenShotDisplayer : MonoBehaviour
	{
		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RawImage rawImage;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Texture2D notAvailableImage;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color availableColor;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Color notAvailableColor;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private bool loadFromSlotAutomatically;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private int slot;

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x1040600", Offset = "0x1040600", VA = "0x1040600")]
		private void Reset()
		{
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x10406B0", Offset = "0x10406B0", VA = "0x10406B0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x10406C4", Offset = "0x10406C4", VA = "0x10406C4")]
		public void LoadScreenshot(int slot)
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x1040928", Offset = "0x1040928", VA = "0x1040928")]
		public SaveScreenShotDisplayer()
		{
		}
	}
}
