using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Xml;
using Game.UI;
using Il2CppDummyDll;
using Pico.Platform;
using Pico.Platform.Models;
using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
using UnityEngine.UI;
using UnityEngine.Video;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class AndroidSignSettings : ScriptableObject
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string passwordFilePath;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x84E26C", Offset = "0x84E26C", VA = "0x84E26C")]
	public AndroidSignSettings()
	{
	}
}
[Token(Token = "0x2000003")]
public class AchievementRemoteAPI_PicoVR : AchievementRemoteAPI
{
	[Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ISet<string> neededAchievementIds;

		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action<AchievementData> action;

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x84EADC", Offset = "0x84EADC", VA = "0x84EADC")]
		public <>c__DisplayClass2_0()
		{
		}
	}

	[Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_1
	{
		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string state;

		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public <>c__DisplayClass2_0 CS$<>8__locals1;

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x84EAE4", Offset = "0x84EAE4", VA = "0x84EAE4")]
		public <>c__DisplayClass2_1()
		{
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x84EAEC", Offset = "0x84EAEC", VA = "0x84EAEC")]
		internal void <GetAchievemetsByProgress>b__0(Message<AchievementProgressList> handler)
		{
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x84EED0", Offset = "0x84EED0", VA = "0x84EED0")]
		internal bool <GetAchievemetsByProgress>b__1()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class <GetAchievemetsByProgress>d__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ISet<string> neededAchievementIds;

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action<AchievementData> action;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private <>c__DisplayClass2_0 <>8__1;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private <>c__DisplayClass2_1 <>8__2;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int <needCount>5__2;

		[Token(Token = "0x17000002")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000012")]
			[Address(RVA = "0x84F328", Offset = "0x84F328", VA = "0x84F328", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000003")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000014")]
			[Address(RVA = "0x84F370", Offset = "0x84F370", VA = "0x84F370", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x84E3D8", Offset = "0x84E3D8", VA = "0x84E3D8")]
		[DebuggerHidden]
		public <GetAchievemetsByProgress>d__2(int <>1__state)
		{
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x84EF1C", Offset = "0x84EF1C", VA = "0x84EF1C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x84EF20", Offset = "0x84EF20", VA = "0x84EF20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x84F330", Offset = "0x84F330", VA = "0x84F330", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ISet<string> neededAchievementIds;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action<AchievementData> action;

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x84F378", Offset = "0x84F378", VA = "0x84F378")]
		public <>c__DisplayClass3_0()
		{
		}
	}

	[Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_1
	{
		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string state;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public <>c__DisplayClass3_0 CS$<>8__locals1;

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x84F380", Offset = "0x84F380", VA = "0x84F380")]
		public <>c__DisplayClass3_1()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x84F388", Offset = "0x84F388", VA = "0x84F388")]
		internal void <GetAchievemetsByDefinition>b__0(Message<AchievementDefinitionList> handler)
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x84F770", Offset = "0x84F770", VA = "0x84F770")]
		internal bool <GetAchievemetsByDefinition>b__1()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class <GetAchievemetsByDefinition>d__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ISet<string> neededAchievementIds;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action<AchievementData> action;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private <>c__DisplayClass3_0 <>8__1;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private <>c__DisplayClass3_1 <>8__2;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int <needCount>5__2;

		[Token(Token = "0x17000004")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600001C")]
			[Address(RVA = "0x84FBC8", Offset = "0x84FBC8", VA = "0x84FBC8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000005")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600001E")]
			[Address(RVA = "0x84FC10", Offset = "0x84FC10", VA = "0x84FC10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x84E474", Offset = "0x84E474", VA = "0x84E474")]
		[DebuggerHidden]
		public <GetAchievemetsByDefinition>d__3(int <>1__state)
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x84F7BC", Offset = "0x84F7BC", VA = "0x84F7BC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x84F7C0", Offset = "0x84F7C0", VA = "0x84F7C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x84FBD0", Offset = "0x84FBD0", VA = "0x84FBD0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class <GetAchievemets0>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ISet<string> neededAchievementIds;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AchievementRemoteAPI_PicoVR <>4__this;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action<AchievementData> action;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int <totalNeedCount>5__2;

		[Token(Token = "0x17000006")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000022")]
			[Address(RVA = "0x850130", Offset = "0x850130", VA = "0x850130", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000007")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000024")]
			[Address(RVA = "0x850178", Offset = "0x850178", VA = "0x850178", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x84E49C", Offset = "0x84E49C", VA = "0x84E49C")]
		[DebuggerHidden]
		public <GetAchievemets0>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x84FC18", Offset = "0x84FC18", VA = "0x84FC18", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x84FC1C", Offset = "0x84FC1C", VA = "0x84FC1C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x850138", Offset = "0x850138", VA = "0x850138", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x17000001")]
	public override bool supportClearAllAchievement
	{
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x84E60C", Offset = "0x84E60C", VA = "0x84E60C", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x84E274", Offset = "0x84E274", VA = "0x84E274", Slot = "5")]
	protected override void OnAwake()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x84E2C8", Offset = "0x84E2C8", VA = "0x84E2C8", Slot = "8")]
	public override Coroutine GetAchievemets(Action<AchievementData> action, ISet<string> neededAchievementIds)
	{
		return null;
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x84E364", Offset = "0x84E364", VA = "0x84E364")]
	[IteratorStateMachine(typeof(<GetAchievemetsByProgress>d__2))]
	private static IEnumerator GetAchievemetsByProgress(Action<AchievementData> action, ISet<string> neededAchievementIds)
	{
		return null;
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x84E400", Offset = "0x84E400", VA = "0x84E400")]
	[IteratorStateMachine(typeof(<GetAchievemetsByDefinition>d__3))]
	private static IEnumerator GetAchievemetsByDefinition(Action<AchievementData> action, ISet<string> neededAchievementIds)
	{
		return null;
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x84E2E8", Offset = "0x84E2E8", VA = "0x84E2E8")]
	[IteratorStateMachine(typeof(<GetAchievemets0>d__4))]
	private IEnumerator GetAchievemets0(Action<AchievementData> action, ISet<string> neededAchievementIds)
	{
		return null;
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x84E4C4", Offset = "0x84E4C4", VA = "0x84E4C4", Slot = "10")]
	public override void SetAchievementCompelete(Action<bool> done, string id)
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x84E614", Offset = "0x84E614", VA = "0x84E614", Slot = "11")]
	public override void ClearAllAchievement(List<string> ids)
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x84EA90", Offset = "0x84EA90", VA = "0x84EA90")]
	public AchievementRemoteAPI_PicoVR()
	{
	}
}
[Token(Token = "0x200000D")]
[SingletonOption(autoCreate = true)]
public class PicoIniter : SingletonGameObject<PicoIniter>
{
	[Token(Token = "0x17000008")]
	protected override bool dontDestroyOnLoad
	{
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x850474", Offset = "0x850474", VA = "0x850474", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000009")]
	public string userId
	{
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x85047C", Offset = "0x85047C", VA = "0x85047C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x850484", Offset = "0x850484", VA = "0x850484")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700000A")]
	public string appId
	{
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x84EA50", Offset = "0x84EA50", VA = "0x84EA50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x85048C", Offset = "0x85048C", VA = "0x85048C", Slot = "5")]
	protected override void OnAwake()
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x850568", Offset = "0x850568", VA = "0x850568")]
	private void Start()
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x85056C", Offset = "0x85056C", VA = "0x85056C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x8505C0", Offset = "0x8505C0", VA = "0x8505C0")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
	private static void Init()
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x850600", Offset = "0x850600", VA = "0x850600")]
	public PicoIniter()
	{
	}
}
[Token(Token = "0x200000E")]
[SingletonOption(resource = "Prefabs/AchievementRemoteAPI")]
public abstract class AchievementRemoteAPI : SingletonGameObject<AchievementRemoteAPI>
{
	[Token(Token = "0x200000F")]
	public class AchievementData
	{
		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string id;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool isCompleted;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string name;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string description;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float? percent;

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x84EEC8", Offset = "0x84EEC8", VA = "0x84EEC8")]
		public AchievementData()
		{
		}
	}

	[Token(Token = "0x2000010")]
	public class AchievementGlobalData
	{
		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string id;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float? percent;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float? count;

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x850A94", Offset = "0x850A94", VA = "0x850A94")]
		public AchievementGlobalData()
		{
		}
	}

	[Token(Token = "0x1700000B")]
	public virtual bool supportClearAllAchievement
	{
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x850A84", Offset = "0x850A84", VA = "0x850A84", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700000C")]
	protected override bool dontDestroyOnLoad
	{
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x850A8C", Offset = "0x850A8C", VA = "0x850A8C", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000033")]
	public abstract Coroutine GetAchievemets(Action<AchievementData> action, ISet<string> neededAchievementIds);

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x850A78", Offset = "0x850A78", VA = "0x850A78", Slot = "9")]
	public virtual Coroutine GetGlobalAchievements(Action<AchievementGlobalData> action, ISet<string> neededAchievementIds)
	{
		return null;
	}

	[Token(Token = "0x6000035")]
	public abstract void SetAchievementCompelete(Action<bool> done, string id);

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x850A80", Offset = "0x850A80", VA = "0x850A80", Slot = "11")]
	public virtual void ClearAllAchievement(List<string> ids)
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x84EA94", Offset = "0x84EA94", VA = "0x84EA94")]
	protected AchievementRemoteAPI()
	{
	}
}
[Token(Token = "0x2000011")]
public class AchievementSystem : SingletonGameObject<AchievementSystem>
{
	[Serializable]
	[Token(Token = "0x2000012")]
	private class ImportSettings
	{
		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string csvFile;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string headerId;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string headerNameFmt;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string headerDescriptionFmt;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string defineXmlFile;

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x853A00", Offset = "0x853A00", VA = "0x853A00")]
		public ImportSettings()
		{
		}
	}

	[Token(Token = "0x2000013")]
	public abstract class AchievementInternal : MonoBehaviour
	{
		[Token(Token = "0x2000014")]
		public enum LevelMode
		{
			[Token(Token = "0x4000044")]
			None,
			[Token(Token = "0x4000045")]
			Tutorial,
			[Token(Token = "0x4000046")]
			Freedom,
			[Token(Token = "0x4000047")]
			Challenge
		}

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string _Name;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string _Description;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool mNewCompleted;

		[Token(Token = "0x17000012")]
		public string id
		{
			[Token(Token = "0x600004D")]
			[Address(RVA = "0x853AB4", Offset = "0x853AB4", VA = "0x853AB4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600004E")]
			[Address(RVA = "0x853ABC", Offset = "0x853ABC", VA = "0x853ABC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public new string name
		{
			[Token(Token = "0x600004F")]
			[Address(RVA = "0x852D50", Offset = "0x852D50", VA = "0x852D50")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000014")]
		public bool hidden
		{
			[Token(Token = "0x6000050")]
			[Address(RVA = "0x853AC4", Offset = "0x853AC4", VA = "0x853AC4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000051")]
			[Address(RVA = "0x853ACC", Offset = "0x853ACC", VA = "0x853ACC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000015")]
		public string description
		{
			[Token(Token = "0x6000052")]
			[Address(RVA = "0x853278", Offset = "0x853278", VA = "0x853278")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000016")]
		public AchievementSystem system
		{
			[Token(Token = "0x6000053")]
			[Address(RVA = "0x853AD8", Offset = "0x853AD8", VA = "0x853AD8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000054")]
			[Address(RVA = "0x853AE0", Offset = "0x853AE0", VA = "0x853AE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public bool isOnServer
		{
			[Token(Token = "0x6000055")]
			[Address(RVA = "0x853AE8", Offset = "0x853AE8", VA = "0x853AE8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000056")]
			[Address(RVA = "0x853AF0", Offset = "0x853AF0", VA = "0x853AF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000018")]
		public bool isOnServerCompleted
		{
			[Token(Token = "0x6000057")]
			[Address(RVA = "0x853AFC", Offset = "0x853AFC", VA = "0x853AFC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000058")]
			[Address(RVA = "0x853B04", Offset = "0x853B04", VA = "0x853B04")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public bool isCompleted
		{
			[Token(Token = "0x6000059")]
			[Address(RVA = "0x853B10", Offset = "0x853B10", VA = "0x853B10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600005A")]
			[Address(RVA = "0x853B18", Offset = "0x853B18", VA = "0x853B18")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		public bool isCompletedFromServer
		{
			[Token(Token = "0x600005B")]
			[Address(RVA = "0x853B24", Offset = "0x853B24", VA = "0x853B24")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600005C")]
			[Address(RVA = "0x853B2C", Offset = "0x853B2C", VA = "0x853B2C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public bool isNewCompleted
		{
			[Token(Token = "0x600005D")]
			[Address(RVA = "0x851594", Offset = "0x851594", VA = "0x851594")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600005E")]
			[Address(RVA = "0x853B38", Offset = "0x853B38", VA = "0x853B38")]
			set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public LevelMode levelMode
		{
			[Token(Token = "0x600005F")]
			[Address(RVA = "0x853B60", Offset = "0x853B60", VA = "0x853B60")]
			[CompilerGenerated]
			get
			{
				return default(LevelMode);
			}
			[Token(Token = "0x6000060")]
			[Address(RVA = "0x853B68", Offset = "0x853B68", VA = "0x853B68")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		public virtual int progressMax
		{
			[Token(Token = "0x6000061")]
			[Address(RVA = "0x853B70", Offset = "0x853B70", VA = "0x853B70", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700001E")]
		public float? globalPercent
		{
			[Token(Token = "0x6000062")]
			[Address(RVA = "0x853B78", Offset = "0x853B78", VA = "0x853B78")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000063")]
			[Address(RVA = "0x853B80", Offset = "0x853B80", VA = "0x853B80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public virtual int progress
		{
			[Token(Token = "0x6000064")]
			[Address(RVA = "0x853B88", Offset = "0x853B88", VA = "0x853B88", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000020")]
		public bool isCurrentLevelValid
		{
			[Token(Token = "0x6000065")]
			[Address(RVA = "0x853B90", Offset = "0x853B90", VA = "0x853B90")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000021")]
		protected XmlElement savedData
		{
			[Token(Token = "0x6000066")]
			[Address(RVA = "0x853D1C", Offset = "0x853D1C", VA = "0x853D1C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000067")]
			[Address(RVA = "0x853D24", Offset = "0x853D24", VA = "0x853D24")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x853D2C", Offset = "0x853D2C", VA = "0x853D2C", Slot = "6")]
		public virtual void OnInit(string id, XmlElement parameters, AchievementSystem achievementSystem)
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x853FA0", Offset = "0x853FA0", VA = "0x853FA0")]
		public void SetComplete()
		{
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x854294", Offset = "0x854294", VA = "0x854294", Slot = "7")]
		public virtual void OnSaveData()
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x852F10", Offset = "0x852F10", VA = "0x852F10")]
		internal void OnReceiveRemoteAchivement(AchievementRemoteAPI.AchievementData achievementData)
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x854084", Offset = "0x854084", VA = "0x854084")]
		private void SetServerCompleted()
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x853124", Offset = "0x853124", VA = "0x853124")]
		internal void OnReceiveRemoteAchivementGlobal(AchievementRemoteAPI.AchievementGlobalData achievementGlobalData)
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x8543B0", Offset = "0x8543B0", VA = "0x8543B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x854624", Offset = "0x854624", VA = "0x854624")]
		protected AchievementInternal()
		{
		}
	}

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly TaggedLogger Debug;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AudioClip _AudioOnAchievementDone;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private ImportSettings _ImportSettings;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int mNewCompletedCount;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Dictionary<string, Achievement> mAchievementDic;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private XmlElement mDataNode;

	[Token(Token = "0x1700000D")]
	public XmlDocument document
	{
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x850A9C", Offset = "0x850A9C", VA = "0x850A9C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000E")]
	public int newCompletedCount
	{
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x851408", Offset = "0x851408", VA = "0x851408")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700000F")]
	private XmlElement dataNode
	{
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x8515B4", Offset = "0x8515B4", VA = "0x8515B4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000010")]
	public IReadOnlyDictionary<string, Achievement> achievements
	{
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x8516E0", Offset = "0x8516E0", VA = "0x8516E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000011")]
	protected override bool dontDestroyOnLoad
	{
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x8516E8", Offset = "0x8516E8", VA = "0x8516E8", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x8516F0", Offset = "0x8516F0", VA = "0x8516F0")]
	public XmlElement GetSavedData(string achivementId)
	{
		return null;
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x851874", Offset = "0x851874", VA = "0x851874", Slot = "5")]
	protected override void OnAwake()
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x852BE0", Offset = "0x852BE0", VA = "0x852BE0")]
	private void SavedXmlData_onSavingData()
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x8520AC", Offset = "0x8520AC", VA = "0x8520AC")]
	private void LoadAchievements()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x852DFC", Offset = "0x852DFC", VA = "0x852DFC")]
	private void OnReceiveRemoteAchivement(AchievementRemoteAPI.AchievementData achievementData)
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x853010", Offset = "0x853010", VA = "0x853010")]
	private void OnReceiveRemoteAchivementGlobal(AchievementRemoteAPI.AchievementGlobalData achievementGlobalData)
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x853140", Offset = "0x853140", VA = "0x853140")]
	public void OnAchievementCompleted(Achievement achievement)
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x853324", Offset = "0x853324", VA = "0x853324")]
	public void Save()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x8536F8", Offset = "0x8536F8", VA = "0x8536F8", Slot = "7")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x8538F4", Offset = "0x8538F4", VA = "0x8538F4")]
	public AchievementSystem()
	{
	}
}
[Token(Token = "0x2000016")]
public abstract class Achievement : AchievementSystem.AchievementInternal
{
	[Token(Token = "0x6000077")]
	[Address(RVA = "0x8547A8", Offset = "0x8547A8", VA = "0x8547A8")]
	protected Achievement()
	{
	}
}
[Token(Token = "0x2000017")]
public class Achievement_ApplyAllCopybooks : Achievement
{
	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private HashSet<string> mAppliedCopybooks;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private HashSet<string> mNotAppliedCopybooks;

	[Token(Token = "0x17000022")]
	public override int progress
	{
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x8548B8", Offset = "0x8548B8", VA = "0x8548B8", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000023")]
	public override int progressMax
	{
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x854900", Offset = "0x854900", VA = "0x854900", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x8547B0", Offset = "0x8547B0", VA = "0x8547B0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x854834", Offset = "0x854834", VA = "0x854834")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x854958", Offset = "0x854958", VA = "0x854958")]
	public bool OnMessage(GameMessageType msgType, int what, params object[] args)
	{
		return default(bool);
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x854B0C", Offset = "0x854B0C", VA = "0x854B0C", Slot = "6")]
	public override void OnInit(string id, XmlElement parameters, AchievementSystem achievementSystem)
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x854C94", Offset = "0x854C94", VA = "0x854C94", Slot = "7")]
	public override void OnSaveData()
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x854D34", Offset = "0x854D34", VA = "0x854D34", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x854E14", Offset = "0x854E14", VA = "0x854E14")]
	public Achievement_ApplyAllCopybooks()
	{
	}
}
[Token(Token = "0x2000018")]
public class Achievement_ChallengeLevelComplete : Achievement
{
	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private int mCaledLevels;

	[Token(Token = "0x17000024")]
	public int count
	{
		[Token(Token = "0x6000082")]
		[Address(RVA = "0x854F88", Offset = "0x854F88", VA = "0x854F88")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000083")]
		[Address(RVA = "0x854F90", Offset = "0x854F90", VA = "0x854F90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000025")]
	public override int progress
	{
		[Token(Token = "0x6000084")]
		[Address(RVA = "0x854F98", Offset = "0x854F98", VA = "0x854F98", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000026")]
	public override int progressMax
	{
		[Token(Token = "0x6000085")]
		[Address(RVA = "0x854FA0", Offset = "0x854FA0", VA = "0x854FA0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x855010", Offset = "0x855010", VA = "0x855010")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x855094", Offset = "0x855094", VA = "0x855094")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x855118", Offset = "0x855118", VA = "0x855118")]
	public bool OnMessage(GameMessageType msgType, int what, params object[] args)
	{
		return default(bool);
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x855790", Offset = "0x855790", VA = "0x855790", Slot = "6")]
	public override void OnInit(string id, XmlElement parameters, AchievementSystem achievementSystem)
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x85588C", Offset = "0x85588C", VA = "0x85588C", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x8559AC", Offset = "0x8559AC", VA = "0x8559AC")]
	public Achievement_ChallengeLevelComplete()
	{
	}
}
[Token(Token = "0x2000019")]
public class Achievement_ChallengeScoreCombo : Achievement
{
	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int mCurrentCombo;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private int mLastLevel;

	[Token(Token = "0x17000027")]
	public int combo
	{
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x8559B4", Offset = "0x8559B4", VA = "0x8559B4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600008D")]
		[Address(RVA = "0x8559BC", Offset = "0x8559BC", VA = "0x8559BC")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000028")]
	public int scoreLevel
	{
		[Token(Token = "0x600008E")]
		[Address(RVA = "0x8559C4", Offset = "0x8559C4", VA = "0x8559C4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600008F")]
		[Address(RVA = "0x8559CC", Offset = "0x8559CC", VA = "0x8559CC")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000029")]
	public override int progressMax
	{
		[Token(Token = "0x6000090")]
		[Address(RVA = "0x8559D4", Offset = "0x8559D4", VA = "0x8559D4", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700002A")]
	public override int progress
	{
		[Token(Token = "0x6000091")]
		[Address(RVA = "0x8559DC", Offset = "0x8559DC", VA = "0x8559DC", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x8559E4", Offset = "0x8559E4", VA = "0x8559E4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x855AE0", Offset = "0x855AE0", VA = "0x855AE0")]
	private void SceneManager_activeSceneChanged(Scene arg0, Scene arg1)
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x855AF8", Offset = "0x855AF8", VA = "0x855AF8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x855BFC", Offset = "0x855BFC", VA = "0x855BFC")]
	public bool OnMessage(GameMessageType msgType, int what, params object[] args)
	{
		return default(bool);
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x855F98", Offset = "0x855F98", VA = "0x855F98", Slot = "6")]
	public override void OnInit(string id, XmlElement parameters, AchievementSystem achievementSystem)
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x8560AC", Offset = "0x8560AC", VA = "0x8560AC", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x856164", Offset = "0x856164", VA = "0x856164")]
	public Achievement_ChallengeScoreCombo()
	{
	}
}
[Token(Token = "0x200001A")]
public class Achievement_ChallengeScoreLevelCount : Achievement
{
	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int mCurrentCaledCount;

	[Token(Token = "0x1700002B")]
	public int count
	{
		[Token(Token = "0x6000099")]
		[Address(RVA = "0x856174", Offset = "0x856174", VA = "0x856174")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600009A")]
		[Address(RVA = "0x85617C", Offset = "0x85617C", VA = "0x85617C")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700002C")]
	public int scoreLevel
	{
		[Token(Token = "0x600009B")]
		[Address(RVA = "0x856184", Offset = "0x856184", VA = "0x856184")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600009C")]
		[Address(RVA = "0x85618C", Offset = "0x85618C", VA = "0x85618C")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700002D")]
	public override int progressMax
	{
		[Token(Token = "0x600009D")]
		[Address(RVA = "0x856194", Offset = "0x856194", VA = "0x856194", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700002E")]
	public override int progress
	{
		[Token(Token = "0x600009E")]
		[Address(RVA = "0x856204", Offset = "0x856204", VA = "0x856204", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x85620C", Offset = "0x85620C", VA = "0x85620C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x856290", Offset = "0x856290", VA = "0x856290")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x856314", Offset = "0x856314", VA = "0x856314")]
	public bool OnMessage(GameMessageType msgType, int what, params object[] args)
	{
		return default(bool);
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x8563E0", Offset = "0x8563E0", VA = "0x8563E0")]
	private int CalTargetLevelCount()
	{
		return default(int);
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x8567DC", Offset = "0x8567DC", VA = "0x8567DC", Slot = "6")]
	public override void OnInit(string id, XmlElement parameters, AchievementSystem achievementSystem)
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x8568EC", Offset = "0x8568EC", VA = "0x8568EC", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x8569E4", Offset = "0x8569E4", VA = "0x8569E4")]
	public Achievement_ChallengeScoreLevelCount()
	{
	}
}
[Token(Token = "0x200001B")]
public class Achievement_ColorPalettePick : Achievement
{
	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private int mCurrentCount;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private float mLastTime;

	[Token(Token = "0x1700002F")]
	public string targetColorPalette
	{
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x8569EC", Offset = "0x8569EC", VA = "0x8569EC")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x8569F4", Offset = "0x8569F4", VA = "0x8569F4")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000030")]
	public int count
	{
		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x8569FC", Offset = "0x8569FC", VA = "0x8569FC")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x856A04", Offset = "0x856A04", VA = "0x856A04")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000031")]
	public float cd
	{
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x856A0C", Offset = "0x856A0C", VA = "0x856A0C")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x856A14", Offset = "0x856A14", VA = "0x856A14")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000032")]
	public override int progressMax
	{
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x856A1C", Offset = "0x856A1C", VA = "0x856A1C", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000033")]
	public override int progress
	{
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x856A24", Offset = "0x856A24", VA = "0x856A24", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x856A2C", Offset = "0x856A2C", VA = "0x856A2C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x856AB0", Offset = "0x856AB0", VA = "0x856AB0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x856B34", Offset = "0x856B34", VA = "0x856B34")]
	public bool OnMessage(GameMessageType msgType, int what, params object[] args)
	{
		return default(bool);
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x856CB8", Offset = "0x856CB8", VA = "0x856CB8", Slot = "6")]
	public override void OnInit(string id, XmlElement parameters, AchievementSystem achievementSystem)
	{
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x856DEC", Offset = "0x856DEC", VA = "0x856DEC", Slot = "7")]
	public override void OnSaveData()
	{
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x856E64", Offset = "0x856E64", VA = "0x856E64", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x856FE8", Offset = "0x856FE8", VA = "0x856FE8")]
	public Achievement_ColorPalettePick()
	{
	}
}
[Token(Token = "0x200001C")]
public class Achievement_MatchEvents : Achievement
{
	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private string mMsgType;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int mWhat;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private int mCount;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private int mCurrentCount;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private float mCD;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private float mLastTime;

	[Token(Token = "0x17000034")]
	public override int progressMax
	{
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x856FF0", Offset = "0x856FF0", VA = "0x856FF0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000035")]
	public override int progress
	{
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x856FF8", Offset = "0x856FF8", VA = "0x856FF8", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x857000", Offset = "0x857000", VA = "0x857000", Slot = "6")]
	public override void OnInit(string id, XmlElement parameters, AchievementSystem achievementSystem)
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x857204", Offset = "0x857204", VA = "0x857204")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x857288", Offset = "0x857288", VA = "0x857288")]
	private bool OnMessage(GameMessageType msgType, int what, params object[] args)
	{
		return default(bool);
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x857384", Offset = "0x857384", VA = "0x857384", Slot = "7")]
	public override void OnSaveData()
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x8573FC", Offset = "0x8573FC", VA = "0x8573FC", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x857654", Offset = "0x857654", VA = "0x857654")]
	public Achievement_MatchEvents()
	{
	}
}
[Token(Token = "0x200001D")]
public class Achievement_OneStroke_MatchMultiStroke : Achievement
{
	[Token(Token = "0x17000036")]
	public int scoreLevel
	{
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x85765C", Offset = "0x85765C", VA = "0x85765C")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x857664", Offset = "0x857664", VA = "0x857664")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x85766C", Offset = "0x85766C", VA = "0x85766C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x8576F0", Offset = "0x8576F0", VA = "0x8576F0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x857774", Offset = "0x857774", VA = "0x857774")]
	public bool OnMessage(GameMessageType msgType, int what, params object[] args)
	{
		return default(bool);
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x8579B8", Offset = "0x8579B8", VA = "0x8579B8", Slot = "6")]
	public override void OnInit(string id, XmlElement parameters, AchievementSystem achievementSystem)
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x857A80", Offset = "0x857A80", VA = "0x857A80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x857B14", Offset = "0x857B14", VA = "0x857B14")]
	public Achievement_OneStroke_MatchMultiStroke()
	{
	}
}
[Token(Token = "0x200001E")]
public class Achievement_OneStroke_MathWordCount : Achievement
{
	[Token(Token = "0x17000037")]
	public int scoreLevel
	{
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x857B1C", Offset = "0x857B1C", VA = "0x857B1C")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x857B24", Offset = "0x857B24", VA = "0x857B24")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000038")]
	public int minWordsCount
	{
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x857B2C", Offset = "0x857B2C", VA = "0x857B2C")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x857B34", Offset = "0x857B34", VA = "0x857B34")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x857B3C", Offset = "0x857B3C", VA = "0x857B3C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x857BC0", Offset = "0x857BC0", VA = "0x857BC0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x857C44", Offset = "0x857C44", VA = "0x857C44")]
	public bool OnMessage(GameMessageType msgType, int what, params object[] args)
	{
		return default(bool);
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x857E9C", Offset = "0x857E9C", VA = "0x857E9C", Slot = "6")]
	public override void OnInit(string id, XmlElement parameters, AchievementSystem achievementSystem)
	{
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x857FA0", Offset = "0x857FA0", VA = "0x857FA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x858058", Offset = "0x858058", VA = "0x858058")]
	public Achievement_OneStroke_MathWordCount()
	{
	}
}
[Token(Token = "0x200001F")]
public class Achievement_OverStroke_MatchLevelCount : Achievement
{
	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private HashSet<string> mLevels;

	[Token(Token = "0x17000039")]
	public int scoreLevel
	{
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x858060", Offset = "0x858060", VA = "0x858060")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x858068", Offset = "0x858068", VA = "0x858068")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700003A")]
	public int levelCount
	{
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x858070", Offset = "0x858070", VA = "0x858070")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x858078", Offset = "0x858078", VA = "0x858078")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700003B")]
	public override int progressMax
	{
		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x858080", Offset = "0x858080", VA = "0x858080", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700003C")]
	public override int progress
	{
		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x858088", Offset = "0x858088", VA = "0x858088", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x8580D0", Offset = "0x8580D0", VA = "0x8580D0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x858154", Offset = "0x858154", VA = "0x858154")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x8581D8", Offset = "0x8581D8", VA = "0x8581D8")]
	public bool OnMessage(GameMessageType msgType, int what, params object[] args)
	{
		return default(bool);
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x858460", Offset = "0x858460", VA = "0x858460", Slot = "6")]
	public override void OnInit(string id, XmlElement parameters, AchievementSystem achievementSystem)
	{
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x8585EC", Offset = "0x8585EC", VA = "0x8585EC", Slot = "7")]
	public override void OnSaveData()
	{
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x858690", Offset = "0x858690", VA = "0x858690", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x858884", Offset = "0x858884", VA = "0x858884")]
	public Achievement_OverStroke_MatchLevelCount()
	{
	}
}
[Token(Token = "0x2000020")]
public class Achievement_OverStroke_MatchWord : Achievement
{
	[Token(Token = "0x1700003D")]
	public string targetWord
	{
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x858900", Offset = "0x858900", VA = "0x858900")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x858908", Offset = "0x858908", VA = "0x858908")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700003E")]
	public int scoreLevel
	{
		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x858910", Offset = "0x858910", VA = "0x858910")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x858918", Offset = "0x858918", VA = "0x858918")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x858920", Offset = "0x858920", VA = "0x858920")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x8589A4", Offset = "0x8589A4", VA = "0x8589A4")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x858A28", Offset = "0x858A28", VA = "0x858A28")]
	public bool OnMessage(GameMessageType msgType, int what, params object[] args)
	{
		return default(bool);
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x858C78", Offset = "0x858C78", VA = "0x858C78", Slot = "6")]
	public override void OnInit(string id, XmlElement parameters, AchievementSystem achievementSystem)
	{
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x858D70", Offset = "0x858D70", VA = "0x858D70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x858E14", Offset = "0x858E14", VA = "0x858E14")]
	public Achievement_OverStroke_MatchWord()
	{
	}
}
[Token(Token = "0x2000021")]
public class Achievement_PaintAllColors : Achievement
{
	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private HashSet<string> mNotPaintTargets;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private HashSet<string> mPaintedTargets;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private ColorPalette mLastColorPalette;

	[Token(Token = "0x1700003F")]
	public override int progressMax
	{
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x858E1C", Offset = "0x858E1C", VA = "0x858E1C", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000040")]
	public override int progress
	{
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x858E74", Offset = "0x858E74", VA = "0x858E74", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x858EBC", Offset = "0x858EBC", VA = "0x858EBC")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x858F40", Offset = "0x858F40", VA = "0x858F40")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x858FC4", Offset = "0x858FC4", VA = "0x858FC4")]
	public bool OnMessage(GameMessageType msgType, int what, params object[] args)
	{
		return default(bool);
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x8592D8", Offset = "0x8592D8", VA = "0x8592D8")]
	private bool ColorEquals(Color a, Color b)
	{
		return default(bool);
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x859400", Offset = "0x859400", VA = "0x859400")]
	private void SetTargetPainted(string target)
	{
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x8594B0", Offset = "0x8594B0", VA = "0x8594B0", Slot = "7")]
	public override void OnSaveData()
	{
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x859554", Offset = "0x859554", VA = "0x859554", Slot = "6")]
	public override void OnInit(string id, XmlElement parameters, AchievementSystem achievementSystem)
	{
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x85974C", Offset = "0x85974C", VA = "0x85974C", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x8599C8", Offset = "0x8599C8", VA = "0x8599C8")]
	public Achievement_PaintAllColors()
	{
	}
}
[Token(Token = "0x2000022")]
public class Achievement_PaintTime : Achievement
{
	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private float mCurrentTime;

	[Token(Token = "0x17000041")]
	public string targetPaper
	{
		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x859A68", Offset = "0x859A68", VA = "0x859A68")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x859A70", Offset = "0x859A70", VA = "0x859A70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000042")]
	public float time
	{
		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x859A78", Offset = "0x859A78", VA = "0x859A78")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x859A80", Offset = "0x859A80", VA = "0x859A80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000043")]
	public override int progressMax
	{
		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x859A88", Offset = "0x859A88", VA = "0x859A88", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000044")]
	public override int progress
	{
		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x859AB4", Offset = "0x859AB4", VA = "0x859AB4", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x859B54", Offset = "0x859B54", VA = "0x859B54")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x859BD8", Offset = "0x859BD8", VA = "0x859BD8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x859C5C", Offset = "0x859C5C", VA = "0x859C5C")]
	public bool OnMessage(GameMessageType msgType, int what, params object[] args)
	{
		return default(bool);
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x859DB8", Offset = "0x859DB8", VA = "0x859DB8", Slot = "6")]
	public override void OnInit(string id, XmlElement parameters, AchievementSystem achievementSystem)
	{
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x859EE0", Offset = "0x859EE0", VA = "0x859EE0", Slot = "7")]
	public override void OnSaveData()
	{
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x859F58", Offset = "0x859F58", VA = "0x859F58", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x85A0DC", Offset = "0x85A0DC", VA = "0x85A0DC")]
	public Achievement_PaintTime()
	{
	}
}
[Token(Token = "0x2000023")]
public class Achievement_PerfactWriting : Achievement
{
	[Token(Token = "0x17000045")]
	public float targetScore
	{
		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x85A0E4", Offset = "0x85A0E4", VA = "0x85A0E4")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x85A0EC", Offset = "0x85A0EC", VA = "0x85A0EC")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x85A0F4", Offset = "0x85A0F4", VA = "0x85A0F4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x85A178", Offset = "0x85A178", VA = "0x85A178")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0x85A1FC", Offset = "0x85A1FC", VA = "0x85A1FC")]
	public bool OnMessage(GameMessageType msgType, int what, params object[] args)
	{
		return default(bool);
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x85A2DC", Offset = "0x85A2DC", VA = "0x85A2DC", Slot = "6")]
	public override void OnInit(string id, XmlElement parameters, AchievementSystem achievementSystem)
	{
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x85A3A8", Offset = "0x85A3A8", VA = "0x85A3A8", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0x85A43C", Offset = "0x85A43C", VA = "0x85A43C")]
	public Achievement_PerfactWriting()
	{
	}
}
[Token(Token = "0x2000024")]
public class Achievement_SubmitEmpty : Achievement
{
	[Token(Token = "0x6000106")]
	[Address(RVA = "0x85A444", Offset = "0x85A444", VA = "0x85A444")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x85A4C8", Offset = "0x85A4C8", VA = "0x85A4C8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x85A54C", Offset = "0x85A54C", VA = "0x85A54C")]
	public bool OnMessage(GameMessageType msgType, int what, params object[] args)
	{
		return default(bool);
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x85A6D4", Offset = "0x85A6D4", VA = "0x85A6D4", Slot = "6")]
	public override void OnInit(string id, XmlElement parameters, AchievementSystem achievementSystem)
	{
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x85A6D8", Offset = "0x85A6D8", VA = "0x85A6D8")]
	public Achievement_SubmitEmpty()
	{
	}
}
[Token(Token = "0x2000025")]
public class Achievement_SubmitWithSeal : Achievement
{
	[Token(Token = "0x17000046")]
	public int scoreLevel
	{
		[Token(Token = "0x600010B")]
		[Address(RVA = "0x85A6E0", Offset = "0x85A6E0", VA = "0x85A6E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600010C")]
		[Address(RVA = "0x85A6E8", Offset = "0x85A6E8", VA = "0x85A6E8")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0x85A6F0", Offset = "0x85A6F0", VA = "0x85A6F0")]
	private void Awake()
	{
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0x85A774", Offset = "0x85A774", VA = "0x85A774")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0x85A7F8", Offset = "0x85A7F8", VA = "0x85A7F8")]
	public bool OnMessage(GameMessageType msgType, int what, params object[] args)
	{
		return default(bool);
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0x85AA24", Offset = "0x85AA24", VA = "0x85AA24", Slot = "6")]
	public override void OnInit(string id, XmlElement parameters, AchievementSystem achievementSystem)
	{
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0x85AAEC", Offset = "0x85AAEC", VA = "0x85AAEC", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0x85AB80", Offset = "0x85AB80", VA = "0x85AB80")]
	public Achievement_SubmitWithSeal()
	{
	}
}
[Token(Token = "0x2000026")]
public class Authorization : MonoBehaviour
{
	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static Authorization _instance;

	[Token(Token = "0x6000113")]
	[Address(RVA = "0x85AB88", Offset = "0x85AB88", VA = "0x85AB88")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0x85AC5C", Offset = "0x85AC5C", VA = "0x85AC5C")]
	public static byte[] Check()
	{
		return null;
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0x85AF08", Offset = "0x85AF08", VA = "0x85AF08")]
	public Authorization()
	{
	}
}
[Token(Token = "0x2000027")]
[RequireComponent(typeof(ScrollRect))]
public class BugFix_ScrollRect_UnscaledDeltaTimeZero : MonoBehaviour
{
	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ScrollRect mScrollRect;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Vector2 mOldVelocity;

	[Token(Token = "0x6000116")]
	[Address(RVA = "0x85AF10", Offset = "0x85AF10", VA = "0x85AF10")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x85AF60", Offset = "0x85AF60", VA = "0x85AF60")]
	private void Update()
	{
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x85B14C", Offset = "0x85B14C", VA = "0x85B14C")]
	public BugFix_ScrollRect_UnscaledDeltaTimeZero()
	{
	}
}
[Token(Token = "0x2000028")]
[RequireComponent(typeof(Animator), typeof(AudioSource))]
public class BookAnimationController : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000029")]
	private struct Audios
	{
		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AudioClip open;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AudioClip close;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AudioClip nextPage;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioClip prevPage;
	}

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Audios _StateAudios;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private string _StateOpen;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private string _StateClose;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private string _StateNextPage;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private string _StatePrevPage;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private UnityEvents.IntEvent _OnPageOffsetChanged;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Animator mAnimator;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private AudioSource mAudioSource;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private int mCurrentPageOffset;

	[Token(Token = "0x17000047")]
	public int currentPageOffset
	{
		[Token(Token = "0x6000119")]
		[Address(RVA = "0x85B154", Offset = "0x85B154", VA = "0x85B154")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600011A")]
		[Address(RVA = "0x85B15C", Offset = "0x85B15C", VA = "0x85B15C")]
		set
		{
		}
	}

	[Token(Token = "0x17000048")]
	public int pageCount
	{
		[Token(Token = "0x600011B")]
		[Address(RVA = "0x85B1D0", Offset = "0x85B1D0", VA = "0x85B1D0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000049")]
	public UnityEvents.IntEvent OnPageOffsetChanged
	{
		[Token(Token = "0x600011C")]
		[Address(RVA = "0x85B1D8", Offset = "0x85B1D8", VA = "0x85B1D8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0x85B1E0", Offset = "0x85B1E0", VA = "0x85B1E0")]
	private void Awake()
	{
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x85B25C", Offset = "0x85B25C", VA = "0x85B25C")]
	private void Update()
	{
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0x85B31C", Offset = "0x85B31C", VA = "0x85B31C")]
	public void PrevPage()
	{
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0x85B430", Offset = "0x85B430", VA = "0x85B430")]
	public void NextPage()
	{
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0x85B544", Offset = "0x85B544", VA = "0x85B544")]
	public void Open()
	{
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0x85B5E0", Offset = "0x85B5E0", VA = "0x85B5E0")]
	public void Close()
	{
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0x85B67C", Offset = "0x85B67C", VA = "0x85B67C")]
	public BookAnimationController()
	{
	}
}
[Token(Token = "0x200002A")]
public class BookLevelPagerUI : MonoBehaviour
{
	[Token(Token = "0x6000124")]
	[Address(RVA = "0x85B684", Offset = "0x85B684", VA = "0x85B684")]
	public BookLevelPagerUI()
	{
	}
}
[Token(Token = "0x200002B")]
[RequireComponent(typeof(CanvasGroup))]
public class BookPagerUI : MonoBehaviour
{
	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Button _ButtonPrevPage;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Button _ButtonNextPage;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Button _ButtonHomePaper;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private CanvasGroup mCanvasGroup;

	[Token(Token = "0x1700004A")]
	public Button buttonPrevPage
	{
		[Token(Token = "0x6000125")]
		[Address(RVA = "0x85B68C", Offset = "0x85B68C", VA = "0x85B68C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700004B")]
	public Button buttonNextPage
	{
		[Token(Token = "0x6000126")]
		[Address(RVA = "0x85B694", Offset = "0x85B694", VA = "0x85B694")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700004C")]
	public Button buttonHomePaper
	{
		[Token(Token = "0x6000127")]
		[Address(RVA = "0x85B69C", Offset = "0x85B69C", VA = "0x85B69C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700004D")]
	public int pageIndex
	{
		[Token(Token = "0x6000128")]
		[Address(RVA = "0x85B6A4", Offset = "0x85B6A4", VA = "0x85B6A4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000129")]
		[Address(RVA = "0x85B6AC", Offset = "0x85B6AC", VA = "0x85B6AC")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700004E")]
	public CanvasGroup canvasGroup
	{
		[Token(Token = "0x600012A")]
		[Address(RVA = "0x85B6B4", Offset = "0x85B6B4", VA = "0x85B6B4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0x85B748", Offset = "0x85B748", VA = "0x85B748")]
	public BookPagerUI()
	{
	}
}
[Token(Token = "0x200002C")]
[RequireComponent(typeof(DocumentLayoutElement))]
public class BookUI : MonoBehaviour, IScrollHandler, IEventSystemHandler
{
	[Serializable]
	[Token(Token = "0x200002D")]
	private class CataloguePager
	{
		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject templateLeftPage;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject templateRightPage;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int entryCountInPage;

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x85DF38", Offset = "0x85DF38", VA = "0x85DF38")]
		public CataloguePager()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200002E")]
	private class LevelPager
	{
		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject templateLeftPage;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject templateRightPage;

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x85DF48", Offset = "0x85DF48", VA = "0x85DF48")]
		public LevelPager()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200002F")]
	private class EmptyPager
	{
		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject templateLeftPage;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject templateRightPage;

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x85DF50", Offset = "0x85DF50", VA = "0x85DF50")]
		public EmptyPager()
		{
		}
	}

	[Token(Token = "0x2000030")]
	private class ChallengeStatisticsInfo
	{
		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int[] levelsPassed;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float[] maxScores;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int scoreACount;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int scoreBCount;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int scoreCCount;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int scoreDCount;

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x85B9B4", Offset = "0x85B9B4", VA = "0x85B9B4")]
		public ChallengeStatisticsInfo()
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x85DAC8", Offset = "0x85DAC8", VA = "0x85DAC8")]
		public float GetMaxScore(int level)
		{
			return default(float);
		}
	}

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private CataloguePager _Catalogue;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private LevelPager _LevelPager;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private EmptyPager _EmptyPager;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private BookAnimationController _Book;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private MenuPanel _BackPanel;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private int _PageWidth;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private HorizontalScrollHandler _Scroll;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private DocumentLayoutElement mDocumentLayoutElement;

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private int mCurrentPage;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private List<GameObject> mPages;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private ChallengeLevelData.Level[] mLevelsData;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private ChallengeStatisticsInfo mChallengeStatisticsInfo;

	[Token(Token = "0x1700004F")]
	private int cataloguePageCount
	{
		[Token(Token = "0x600012C")]
		[Address(RVA = "0x85B750", Offset = "0x85B750", VA = "0x85B750")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000050")]
	private int totalPageCount
	{
		[Token(Token = "0x600012D")]
		[Address(RVA = "0x85B7E0", Offset = "0x85B7E0", VA = "0x85B7E0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0x85B808", Offset = "0x85B808", VA = "0x85B808")]
	private void Awake()
	{
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0x85BBDC", Offset = "0x85BBDC", VA = "0x85BBDC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0x85BD48", Offset = "0x85BD48", VA = "0x85BD48")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0x85BD64", Offset = "0x85BD64", VA = "0x85BD64")]
	private void SetOffset(int off)
	{
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0x85BD98", Offset = "0x85BD98", VA = "0x85BD98")]
	private void Clear()
	{
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0x85BC44", Offset = "0x85BC44", VA = "0x85BC44")]
	public void SetPage(int index)
	{
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0x85BF30", Offset = "0x85BF30", VA = "0x85BF30")]
	private void RefreshPages()
	{
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0x85C49C", Offset = "0x85C49C", VA = "0x85C49C")]
	private void ResetPaperPosition()
	{
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0x85C020", Offset = "0x85C020", VA = "0x85C020")]
	private void ReplaceNext(int index, int count, bool move)
	{
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0x85C268", Offset = "0x85C268", VA = "0x85C268")]
	private void ReplacePrev(int index, int count, bool move)
	{
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0x85C5B0", Offset = "0x85C5B0", VA = "0x85C5B0")]
	public void NextPage()
	{
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0x85C5BC", Offset = "0x85C5BC", VA = "0x85C5BC")]
	public void PrevPage()
	{
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0x85C5C8", Offset = "0x85C5C8", VA = "0x85C5C8")]
	public void OnHomeButton()
	{
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0x85C610", Offset = "0x85C610", VA = "0x85C610")]
	public void Close()
	{
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0x85C63C", Offset = "0x85C63C", VA = "0x85C63C")]
	public void HomePage()
	{
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0x85C644", Offset = "0x85C644", VA = "0x85C644")]
	private void OnCatalogueSelected(int level)
	{
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0x85C670", Offset = "0x85C670", VA = "0x85C670", Slot = "5")]
	protected virtual GameObject LoadPage(int pageIndex)
	{
		return null;
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x85DD88", Offset = "0x85DD88", VA = "0x85DD88", Slot = "4")]
	public void OnScroll(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x85DE24", Offset = "0x85DE24", VA = "0x85DE24")]
	public void Scroll(float dir)
	{
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0x85DE40", Offset = "0x85DE40", VA = "0x85DE40")]
	public BookUI()
	{
	}
}
[Token(Token = "0x2000032")]
public class ChallengeBookMenuController : SingletonGameObject<ChallengeBookMenuController>
{
	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private ScenesLoader _ScenesLoaderChallenge;

	[Token(Token = "0x600014D")]
	[Address(RVA = "0x85DFD4", Offset = "0x85DFD4", VA = "0x85DFD4")]
	public void LoadChallengeLevel(int level)
	{
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0x85E040", Offset = "0x85E040", VA = "0x85E040")]
	public ChallengeBookMenuController()
	{
	}
}
[Token(Token = "0x2000033")]
public class ChallengeBookPaperRenderController : MonoBehaviour
{
	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Vector3 _CameraOffset;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private RenderTexture _RenderTarget;

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private int _PageIndex;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Camera _Camera;

	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private RectTransform mRectTransform;

	[Token(Token = "0x17000051")]
	public int pageIndex
	{
		[Token(Token = "0x600014F")]
		[Address(RVA = "0x85E088", Offset = "0x85E088", VA = "0x85E088")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000150")]
		[Address(RVA = "0x85E090", Offset = "0x85E090", VA = "0x85E090")]
		set
		{
		}
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0x85E15C", Offset = "0x85E15C", VA = "0x85E15C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0x85E298", Offset = "0x85E298", VA = "0x85E298")]
	private void Update()
	{
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0x85E410", Offset = "0x85E410", VA = "0x85E410")]
	private void OnRectTransformDimensionsChange()
	{
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0x85E364", Offset = "0x85E364", VA = "0x85E364")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0x85E5FC", Offset = "0x85E5FC", VA = "0x85E5FC")]
	public ChallengeBookPaperRenderController()
	{
	}
}
[Token(Token = "0x2000034")]
public class ChallengeCatalogueList : MonoBehaviour
{
	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private ChallengeCatalogueListRow _RowTemplate;

	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private UnityEvents.IntEvent _OnCatalogueSelected;

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int _RowCountInPage;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private ObjectPool<ChallengeCatalogueListRow> mPoolRows;

	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private List<ChallengeCatalogueListRow> mRows;

	[Token(Token = "0x17000052")]
	public int rowCountInPage
	{
		[Token(Token = "0x6000156")]
		[Address(RVA = "0x85E65C", Offset = "0x85E65C", VA = "0x85E65C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000157")]
		[Address(RVA = "0x85E664", Offset = "0x85E664", VA = "0x85E664")]
		set
		{
		}
	}

	[Token(Token = "0x17000053")]
	public UnityEvents.IntEvent onPageSelected
	{
		[Token(Token = "0x6000158")]
		[Address(RVA = "0x85E66C", Offset = "0x85E66C", VA = "0x85E66C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000159")]
	[Address(RVA = "0x85E674", Offset = "0x85E674", VA = "0x85E674")]
	private void Awake()
	{
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0x85E8F8", Offset = "0x85E8F8", VA = "0x85E8F8")]
	private void LanguageUtils_onLanguageChanged(string obj)
	{
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0x85E8FC", Offset = "0x85E8FC", VA = "0x85E8FC")]
	private void RefreshTexts()
	{
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0x85ED4C", Offset = "0x85ED4C", VA = "0x85ED4C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0x85EDF0", Offset = "0x85EDF0", VA = "0x85EDF0")]
	private void Clear()
	{
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x85D8E0", Offset = "0x85D8E0", VA = "0x85D8E0")]
	public void SetPage(int index)
	{
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0x85EF94", Offset = "0x85EF94", VA = "0x85EF94")]
	public ChallengeCatalogueList()
	{
	}
}
[Token(Token = "0x2000037")]
public class ChallengeCatalogueListRow : MonoBehaviour
{
	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Button _Button;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private TextMeshProUGUI _TextIndex;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private TextMeshProUGUI _TextEntry;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Image _Locker;

	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int _Level;

	[Token(Token = "0x17000054")]
	public Button button
	{
		[Token(Token = "0x6000167")]
		[Address(RVA = "0x85F2E8", Offset = "0x85F2E8", VA = "0x85F2E8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000055")]
	public TextMeshProUGUI textIndex
	{
		[Token(Token = "0x6000168")]
		[Address(RVA = "0x85F2F0", Offset = "0x85F2F0", VA = "0x85F2F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000056")]
	public TextMeshProUGUI textEntry
	{
		[Token(Token = "0x6000169")]
		[Address(RVA = "0x85F2F8", Offset = "0x85F2F8", VA = "0x85F2F8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000057")]
	public int level
	{
		[Token(Token = "0x600016A")]
		[Address(RVA = "0x85F300", Offset = "0x85F300", VA = "0x85F300")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600016B")]
		[Address(RVA = "0x85F308", Offset = "0x85F308", VA = "0x85F308")]
		set
		{
		}
	}

	[Token(Token = "0x17000058")]
	public Image locker
	{
		[Token(Token = "0x600016C")]
		[Address(RVA = "0x85F310", Offset = "0x85F310", VA = "0x85F310")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0x85F318", Offset = "0x85F318", VA = "0x85F318")]
	public ChallengeCatalogueListRow()
	{
	}
}
[Token(Token = "0x2000038")]
public class ChallengeLevelController : SingletonGameObject<ChallengeLevelController>
{
	[Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class <Load>d__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int levelIndex;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ChallengeLevelController <>4__this;

		[Token(Token = "0x1700005F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000184")]
			[Address(RVA = "0x85FDF8", Offset = "0x85FDF8", VA = "0x85FDF8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000060")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000186")]
			[Address(RVA = "0x85FE40", Offset = "0x85FE40", VA = "0x85FE40", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x85F954", Offset = "0x85F954", VA = "0x85F954")]
		[DebuggerHidden]
		public <Load>d__27(int <>1__state)
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x85FB44", Offset = "0x85FB44", VA = "0x85FB44", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x85FB48", Offset = "0x85FB48", VA = "0x85FB48", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x85FE00", Offset = "0x85FE00", VA = "0x85FE00", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Paper _PaperMain;

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Paper _PaperChirography;

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private BrushRecorder _ChallengeRecorder;

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private BrushRecorder _MainPaperRecorder;

	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private AudioSource _PronunciationAudio;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private ScenesLoader _BackScenesLoader;

	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float mPlayingTime;

	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly string[] mScoreTextFmtKeys;

	[Token(Token = "0x40000BF")]
	public const float kScoreLevel0 = 0.72f;

	[Token(Token = "0x40000C0")]
	public const float kScoreLevel1 = 0.57f;

	[Token(Token = "0x40000C1")]
	public const float kScoreLevel2 = 0.4f;

	[Token(Token = "0x17000059")]
	public Paper paperMain
	{
		[Token(Token = "0x600016E")]
		[Address(RVA = "0x85F320", Offset = "0x85F320", VA = "0x85F320")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700005A")]
	public Paper paperChirography
	{
		[Token(Token = "0x600016F")]
		[Address(RVA = "0x85F328", Offset = "0x85F328", VA = "0x85F328")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700005B")]
	public BrushRecorder challengeRecorder
	{
		[Token(Token = "0x6000170")]
		[Address(RVA = "0x85F330", Offset = "0x85F330", VA = "0x85F330")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700005C")]
	public BrushRecorder mainPaperRecorder
	{
		[Token(Token = "0x6000171")]
		[Address(RVA = "0x85F338", Offset = "0x85F338", VA = "0x85F338")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700005D")]
	public AudioSource pronunciationAudio
	{
		[Token(Token = "0x6000172")]
		[Address(RVA = "0x85F340", Offset = "0x85F340", VA = "0x85F340")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700005E")]
	public ScenesLoader backScenesLoader
	{
		[Token(Token = "0x6000173")]
		[Address(RVA = "0x85F348", Offset = "0x85F348", VA = "0x85F348")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0x85F350", Offset = "0x85F350", VA = "0x85F350")]
	public void PlayPronunciation()
	{
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0x85F408", Offset = "0x85F408", VA = "0x85F408", Slot = "5")]
	protected override void OnAwake()
	{
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0x85F488", Offset = "0x85F488", VA = "0x85F488")]
	public void Start()
	{
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0x85F65C", Offset = "0x85F65C", VA = "0x85F65C", Slot = "7")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0x85F7D0", Offset = "0x85F7D0", VA = "0x85F7D0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0x85F4E0", Offset = "0x85F4E0", VA = "0x85F4E0")]
	public void LoadLevel(int level)
	{
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0x85F874", Offset = "0x85F874", VA = "0x85F874")]
	public void ResetChirography()
	{
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0x85F7FC", Offset = "0x85F7FC", VA = "0x85F7FC")]
	[IteratorStateMachine(typeof(<Load>d__27))]
	private IEnumerator Load(int levelIndex)
	{
		return null;
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0x85DB40", Offset = "0x85DB40", VA = "0x85DB40")]
	public static string GetScoreLevelText(float score)
	{
		return null;
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0x855F3C", Offset = "0x855F3C", VA = "0x855F3C")]
	public static int GetScoreLevel(float score)
	{
		return default(int);
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0x85EC24", Offset = "0x85EC24", VA = "0x85EC24")]
	public static bool GetLevelUnlocked(int level)
	{
		return default(bool);
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0x85F97C", Offset = "0x85F97C", VA = "0x85F97C")]
	public ChallengeLevelController()
	{
	}
}
[Token(Token = "0x200003A")]
[CreateAssetMenu]
public class ChallengeLevelData : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x200003B")]
	public class Level
	{
		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string word;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Texture2D scoreTexture;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Texture2D copybook;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AudioClip audio;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string pinyin;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string english;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int strokeCount;

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x85FE58", Offset = "0x85FE58", VA = "0x85FE58")]
		public Level()
		{
		}
	}

	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Level[] _Levels;

	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private string _ScoreTextureAssetPathFmt;

	[Token(Token = "0x40000C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private string _CopybookAssetPathFmt;

	[Token(Token = "0x40000C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private string _AudioAssetPathFmt;

	[Token(Token = "0x17000061")]
	public Level[] levels
	{
		[Token(Token = "0x6000187")]
		[Address(RVA = "0x85FE48", Offset = "0x85FE48", VA = "0x85FE48")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000188")]
	[Address(RVA = "0x85FE50", Offset = "0x85FE50", VA = "0x85FE50")]
	public ChallengeLevelData()
	{
	}
}
[Token(Token = "0x200003C")]
public class ChallengeMainUI : MonoBehaviour
{
	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private AudioClip[] _AudioScoreLevels;

	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Button _ButtonBack;

	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Button _ButtonReplayChirography;

	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Button _ButtonRecordChirography;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Button _ButtonCommit;

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Button _ButtonPronunciation;

	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Button _ButtonNextLevel;

	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Button _ButtonPrevLevel;

	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Button _Button_BackToCatalogue;

	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Button _ButtonSave;

	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private ChallengeWordInfoUI _ChallengeWordInfoUI;

	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private MenuPanel _ScorePanel;

	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Button _Button_Score_Rechallenge;

	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private Button _Button_Score_NextLevel;

	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private Button _Button_Score_BackToCatalogue;

	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private int mLastLevel;

	[Token(Token = "0x600018A")]
	[Address(RVA = "0x85FE60", Offset = "0x85FE60", VA = "0x85FE60")]
	public void SetDirty()
	{
	}

	[Token(Token = "0x600018B")]
	[Address(RVA = "0x85FE6C", Offset = "0x85FE6C", VA = "0x85FE6C")]
	private void Start()
	{
	}

	[Token(Token = "0x600018C")]
	[Address(RVA = "0x8605E4", Offset = "0x8605E4", VA = "0x8605E4")]
	public void SubmitScore(float score)
	{
	}

	[Token(Token = "0x600018D")]
	[Address(RVA = "0x860CA4", Offset = "0x860CA4", VA = "0x860CA4")]
	private void Update()
	{
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0x861014", Offset = "0x861014", VA = "0x861014")]
	private bool CanChangeToLevel(int levelIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0x861100", Offset = "0x861100", VA = "0x861100")]
	public ChallengeMainUI()
	{
	}
}
[Token(Token = "0x200003E")]
[SingletonOption(resource = "Prefabs/ChallengeManager")]
public class ChallengeManager : SingletonGameObject<ChallengeManager>
{
	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private int _CurrentLevel;

	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private ChallengeLevelData _LevelData;

	[Token(Token = "0x17000062")]
	protected override bool dontDestroyOnLoad
	{
		[Token(Token = "0x600019E")]
		[Address(RVA = "0x861B14", Offset = "0x861B14", VA = "0x861B14", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000063")]
	public bool active
	{
		[Token(Token = "0x600019F")]
		[Address(RVA = "0x861B1C", Offset = "0x861B1C", VA = "0x861B1C")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x861B24", Offset = "0x861B24", VA = "0x861B24")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000064")]
	public int currentLevel
	{
		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x861B30", Offset = "0x861B30", VA = "0x861B30")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x861B38", Offset = "0x861B38", VA = "0x861B38")]
		set
		{
		}
	}

	[Token(Token = "0x17000065")]
	public ChallengeLevelData.Level currentLevelData
	{
		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x85F3CC", Offset = "0x85F3CC", VA = "0x85F3CC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000066")]
	public ChallengeLevelData levelData
	{
		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x861B40", Offset = "0x861B40", VA = "0x861B40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0x861B48", Offset = "0x861B48", VA = "0x861B48")]
	public ChallengeManager()
	{
	}
}
[Token(Token = "0x200003F")]
public static class ChallengeSavedData
{
	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static XmlElement mDataNode;

	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static XmlDocument mDocument;

	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static readonly Regex mArraySpliter;

	[Token(Token = "0x17000067")]
	public static float playingTime
	{
		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x85D820", Offset = "0x85D820", VA = "0x85D820")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x85F6E4", Offset = "0x85F6E4", VA = "0x85F6E4")]
		set
		{
		}
	}

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0x861B90", Offset = "0x861B90", VA = "0x861B90")]
	static ChallengeSavedData()
	{
	}

	[Token(Token = "0x60001A7")]
	[Address(RVA = "0x861D6C", Offset = "0x861D6C", VA = "0x861D6C")]
	private static XmlElement GetLevelElement(int levelIndex, bool create = true)
	{
		return null;
	}

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0x860B00", Offset = "0x860B00", VA = "0x860B00")]
	public static void AddScore(int levelIndex, float score)
	{
	}

	[Token(Token = "0x60001A9")]
	[Address(RVA = "0x860BF0", Offset = "0x860BF0", VA = "0x860BF0")]
	public static void UnlockLevel(int levelIndex, bool unlocked = true)
	{
	}

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0x85DCC0", Offset = "0x85DCC0", VA = "0x85DCC0")]
	public static bool GetLevelUnlocked(int levelIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x60001AB")]
	[Address(RVA = "0x85659C", Offset = "0x85659C", VA = "0x85659C")]
	public static float[] GetScores(int levelIndex)
	{
		return null;
	}

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0x855214", Offset = "0x855214", VA = "0x855214")]
	public static int[] GetCompletedLevels()
	{
		return null;
	}

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0x85F784", Offset = "0x85F784", VA = "0x85F784")]
	public static void Save()
	{
	}
}
[Token(Token = "0x2000040")]
public class ChallengeWordInfoUI : MonoBehaviour
{
	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private TextMeshProUGUI _TextWord;

	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private TextMeshProUGUI _TextPinyin;

	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private TextMeshProUGUI _TextEngligh;

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0x861F68", Offset = "0x861F68", VA = "0x861F68")]
	private void Start()
	{
	}

	[Token(Token = "0x60001B1")]
	[Address(RVA = "0x861464", Offset = "0x861464", VA = "0x861464")]
	public void Refresh()
	{
	}

	[Token(Token = "0x60001B2")]
	[Address(RVA = "0x861F6C", Offset = "0x861F6C", VA = "0x861F6C")]
	public ChallengeWordInfoUI()
	{
	}
}
[Token(Token = "0x2000041")]
public class ChangeRayCursorUILayerWhenEnable : MonoBehaviour
{
	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Dictionary<GameObject, int> mDic;

	[Token(Token = "0x60001B3")]
	[Address(RVA = "0x861F74", Offset = "0x861F74", VA = "0x861F74")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60001B4")]
	[Address(RVA = "0x8623F8", Offset = "0x8623F8", VA = "0x8623F8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60001B5")]
	[Address(RVA = "0x8625E0", Offset = "0x8625E0", VA = "0x8625E0")]
	public ChangeRayCursorUILayerWhenEnable()
	{
	}
}
[Token(Token = "0x2000042")]
public class Configuration
{
	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static string resourceXmlPath;

	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static XmlDocument _config;

	[Token(Token = "0x17000068")]
	private static Stream dataStream
	{
		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x86265C", Offset = "0x86265C", VA = "0x86265C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000069")]
	public static XmlDocument config
	{
		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x862764", Offset = "0x862764", VA = "0x862764")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60001B8")]
	[Address(RVA = "0x8629D0", Offset = "0x8629D0", VA = "0x8629D0")]
	public static void SaveConfig()
	{
	}

	[Token(Token = "0x60001B9")]
	[Address(RVA = "0x8627EC", Offset = "0x8627EC", VA = "0x8627EC")]
	public static void Reload()
	{
	}

	[Token(Token = "0x60001BA")]
	[Address(RVA = "0x862A24", Offset = "0x862A24", VA = "0x862A24")]
	public Configuration()
	{
	}
}
[Token(Token = "0x2000043")]
public class ConfigurationTool : MonoBehaviour
{
	[Token(Token = "0x2000044")]
	private class ConfigObject
	{
		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObjectConfiguration configObject;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<ConfigComponent> components;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool opened;

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x862F04", Offset = "0x862F04", VA = "0x862F04")]
		public ConfigObject()
		{
		}
	}

	[Token(Token = "0x2000045")]
	private class ConfigComponent
	{
		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Component component;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Dictionary<string, MemberInfo> members;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool opened;

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x8630AC", Offset = "0x8630AC", VA = "0x8630AC")]
		public ConfigComponent()
		{
		}
	}

	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool mShowGUI;

	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<ConfigObject> mObjects;

	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Vector2 mGUIScroll;

	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int mLastEditCtrl;

	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private string mLastEditedText;

	[Token(Token = "0x60001BC")]
	[Address(RVA = "0x862A8C", Offset = "0x862A8C", VA = "0x862A8C")]
	private void Update()
	{
	}

	[Token(Token = "0x60001BD")]
	[Address(RVA = "0x862A90", Offset = "0x862A90", VA = "0x862A90")]
	private void InitGUI()
	{
	}

	[Token(Token = "0x60001BE")]
	[Address(RVA = "0x8631D0", Offset = "0x8631D0", VA = "0x8631D0")]
	public void ReloadConfiguration()
	{
	}

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0x86321C", Offset = "0x86321C", VA = "0x86321C")]
	public void ApplyConfigurationToAllGameObject(bool includeInactive = true)
	{
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0x8637EC", Offset = "0x8637EC", VA = "0x8637EC")]
	public void SaveConfig()
	{
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0x863838", Offset = "0x863838", VA = "0x863838")]
	public void SaveConfigOfAllGameObject(bool includeInactive = true)
	{
	}

	[Token(Token = "0x60001C2")]
	[Address(RVA = "0x863C6C", Offset = "0x863C6C", VA = "0x863C6C")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x60001C3")]
	[Address(RVA = "0x863DB8", Offset = "0x863DB8", VA = "0x863DB8")]
	private void WindowProc(int windowId)
	{
	}

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0x864AC8", Offset = "0x864AC8", VA = "0x864AC8")]
	private string Edit(string text)
	{
		return null;
	}

	[Token(Token = "0x60001C5")]
	[Address(RVA = "0x864768", Offset = "0x864768", VA = "0x864768")]
	private static bool FolderButton(bool opened, string name)
	{
		return default(bool);
	}

	[Token(Token = "0x60001C6")]
	[Address(RVA = "0x864E3C", Offset = "0x864E3C", VA = "0x864E3C")]
	public ConfigurationTool()
	{
	}
}
[Token(Token = "0x2000046")]
public class CopybookLoader : MonoBehaviour
{
	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private GalleryPanel mGalleryPanel;

	[Token(Token = "0x4000100")]
	private const string _CopybookPath = "Data\\Copybooks";

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0x864E44", Offset = "0x864E44", VA = "0x864E44")]
	private void Start()
	{
	}

	[Token(Token = "0x60001CA")]
	[Address(RVA = "0x864F20", Offset = "0x864F20", VA = "0x864F20")]
	public CopybookLoader()
	{
	}
}
[Token(Token = "0x2000047")]
public class GameObjectConfiguration : MonoBehaviour
{
	[Token(Token = "0x2000048")]
	public delegate string OTS(object o);

	[Token(Token = "0x2000049")]
	public delegate bool STO(string s, out object o);

	[Token(Token = "0x4000101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string preferedSaveNode;

	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string objectId;

	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly Type TypeInt;

	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static readonly Type TypeFloat;

	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static readonly Type TypeString;

	[Token(Token = "0x4000106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static readonly Type TypeBool;

	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static readonly Type TypeVector3;

	[Token(Token = "0x4000108")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static readonly Type TypeQuaternion;

	[Token(Token = "0x4000109")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static readonly Type TypeColor;

	[Token(Token = "0x400010A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static readonly Dictionary<Type, OTS> TypeToStrings;

	[Token(Token = "0x400010B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static readonly Dictionary<Type, STO> StringToTypes;

	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static readonly char[] ValueStringSpliter;

	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private static readonly Type TypeConfigurableMember;

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0x8650A8", Offset = "0x8650A8", VA = "0x8650A8")]
	static GameObjectConfiguration()
	{
	}

	[Token(Token = "0x60001CD")]
	[Address(RVA = "0x865924", Offset = "0x865924", VA = "0x865924")]
	private void Start()
	{
	}

	[Token(Token = "0x60001CE")]
	[Address(RVA = "0x8632F4", Offset = "0x8632F4", VA = "0x8632F4")]
	public void Load()
	{
	}

	[Token(Token = "0x60001CF")]
	[Address(RVA = "0x863910", Offset = "0x863910", VA = "0x863910")]
	public void Save()
	{
	}

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0x866360", Offset = "0x866360", VA = "0x866360")]
	public static XmlNode GetOrCreatePath(string path, XmlNode parent, XmlDocument xmlDocument)
	{
		return null;
	}

	[Token(Token = "0x60001D1")]
	[Address(RVA = "0x86649C", Offset = "0x86649C", VA = "0x86649C")]
	private void ApplyGameObjectConfigToNode(XmlNode objectNode, XmlDocument xmlDocument)
	{
	}

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0x866900", Offset = "0x866900", VA = "0x866900")]
	private void ApplyComponentConfigToNode(Component component, XmlNode componentNode, XmlDocument xmlDocument)
	{
	}

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0x8648D8", Offset = "0x8648D8", VA = "0x8648D8")]
	public static object GetMemberValue(object obj, MemberInfo info)
	{
		return null;
	}

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0x866CCC", Offset = "0x866CCC", VA = "0x866CCC")]
	public string ObjectToString(object o)
	{
		return null;
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0x864C28", Offset = "0x864C28", VA = "0x864C28")]
	public static bool TryParseValue(Type type, string value, out object result)
	{
		return default(bool);
	}

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0x866DAC", Offset = "0x866DAC", VA = "0x866DAC")]
	public static string Vector3ToString(object o)
	{
		return null;
	}

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0x866F04", Offset = "0x866F04", VA = "0x866F04")]
	public static string QuaternionToString(object o)
	{
		return null;
	}

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0x867088", Offset = "0x867088", VA = "0x867088")]
	public static string ColorToString(object o)
	{
		return null;
	}

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0x86720C", Offset = "0x86720C", VA = "0x86720C")]
	public static bool ParseInt(string s, out object o)
	{
		return default(bool);
	}

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0x867298", Offset = "0x867298", VA = "0x867298")]
	public static bool ParseFloat(string s, out object o)
	{
		return default(bool);
	}

	[Token(Token = "0x60001DB")]
	[Address(RVA = "0x867324", Offset = "0x867324", VA = "0x867324")]
	public static bool ParseBool(string s, out object o)
	{
		return default(bool);
	}

	[Token(Token = "0x60001DC")]
	[Address(RVA = "0x8673C0", Offset = "0x8673C0", VA = "0x8673C0")]
	public static bool ParseString(string s, out object o)
	{
		return default(bool);
	}

	[Token(Token = "0x60001DD")]
	[Address(RVA = "0x8673D0", Offset = "0x8673D0", VA = "0x8673D0")]
	public static bool ParseVector3(string s, out object o)
	{
		return default(bool);
	}

	[Token(Token = "0x60001DE")]
	[Address(RVA = "0x867518", Offset = "0x867518", VA = "0x867518")]
	public static bool ParseQuaternion(string s, out object o)
	{
		return default(bool);
	}

	[Token(Token = "0x60001DF")]
	[Address(RVA = "0x867678", Offset = "0x867678", VA = "0x867678")]
	public static bool ParseColor(string s, out object o)
	{
		return default(bool);
	}

	[Token(Token = "0x60001E0")]
	[Address(RVA = "0x862F0C", Offset = "0x862F0C", VA = "0x862F0C")]
	public List<Component> GetConfigurableComponents()
	{
		return null;
	}

	[Token(Token = "0x60001E1")]
	[Address(RVA = "0x865928", Offset = "0x865928", VA = "0x865928")]
	private void LoadComponentNode(XmlNode componentNode)
	{
	}

	[Token(Token = "0x60001E2")]
	[Address(RVA = "0x8677D8", Offset = "0x8677D8", VA = "0x8677D8")]
	private Dictionary<string, MemberInfo> GetConfigurableMembers(string type, out Component comObject)
	{
		return null;
	}

	[Token(Token = "0x60001E3")]
	[Address(RVA = "0x8679D4", Offset = "0x8679D4", VA = "0x8679D4")]
	public static Type GetMemberValueType(MemberInfo member)
	{
		return null;
	}

	[Token(Token = "0x60001E4")]
	[Address(RVA = "0x8630B4", Offset = "0x8630B4", VA = "0x8630B4")]
	public static Dictionary<string, MemberInfo> GetConfigurableMembers(Type comType)
	{
		return null;
	}

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0x864D00", Offset = "0x864D00", VA = "0x864D00")]
	public static void SetMemberValue(MemberInfo member, object o, object value)
	{
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0x867AD8", Offset = "0x867AD8", VA = "0x867AD8")]
	public GameObjectConfiguration()
	{
	}
}
[Token(Token = "0x200004B")]
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, Inherited = true, AllowMultiple = true)]
internal sealed class ConfigurableMember : Attribute
{
	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private string mName;

	[Token(Token = "0x1700006A")]
	public string Name
	{
		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x867D78", Offset = "0x867D78", VA = "0x867D78")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60001F1")]
	[Address(RVA = "0x867D50", Offset = "0x867D50", VA = "0x867D50")]
	public ConfigurableMember(string name)
	{
	}
}
[Token(Token = "0x200004C")]
[AttributeUsage(AttributeTargets.Class, Inherited = true, AllowMultiple = false)]
internal sealed class ConfigurableComponent : Attribute
{
	[Token(Token = "0x60001F3")]
	[Address(RVA = "0x867D80", Offset = "0x867D80", VA = "0x867D80")]
	public ConfigurableComponent()
	{
	}
}
[Token(Token = "0x200004D")]
[CreateAssetMenu(fileName = "InternalSeals", menuName = "Project/InternalSeals")]
public class InternalSeals : ScriptableObject
{
	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private List<Texture> _Textures;

	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static InternalSeals sInternalSeals;

	[Token(Token = "0x1700006B")]
	public IReadOnlyList<Texture> textures
	{
		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x867D88", Offset = "0x867D88", VA = "0x867D88")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700006C")]
	public static InternalSeals instance
	{
		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x867D90", Offset = "0x867D90", VA = "0x867D90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60001F6")]
	[Address(RVA = "0x867E5C", Offset = "0x867E5C", VA = "0x867E5C")]
	public InternalSeals()
	{
	}
}
[Token(Token = "0x200004E")]
public static class SavedXmlData
{
	[Token(Token = "0x200004F")]
	private class FileSteamWarpper : FileStream
	{
		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private byte[] mBuffer;

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x868128", Offset = "0x868128", VA = "0x868128")]
		public FileSteamWarpper(string path, FileMode mode)
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x86825C", Offset = "0x86825C", VA = "0x86825C", Slot = "33")]
		public override int ReadByte()
		{
			return default(int);
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x86827C", Offset = "0x86827C", VA = "0x86827C", Slot = "31")]
		public override int Read(byte[] array, int offset, int count)
		{
			return default(int);
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x8682F0", Offset = "0x8682F0", VA = "0x8682F0", Slot = "34")]
		public override void Write(byte[] array, int offset, int count)
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x8683E4", Offset = "0x8683E4", VA = "0x8683E4", Slot = "36")]
		public override void WriteByte(byte value)
		{
		}
	}

	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static XmlDocument sDocument;

	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static string sDefaultDataPath;

	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static string sDataPath;

	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static string sUser;

	[Token(Token = "0x4000117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static DateTime? sImportOldSavedData;

	[Token(Token = "0x1700006D")]
	private static bool saveAsEncoded
	{
		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x867E64", Offset = "0x867E64", VA = "0x867E64")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700006E")]
	public static string user
	{
		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x867E6C", Offset = "0x867E6C", VA = "0x867E6C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700006F")]
	public static XmlElement root
	{
		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x867EC4", Offset = "0x867EC4", VA = "0x867EC4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000070")]
	public static XmlDocument document
	{
		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x850AE8", Offset = "0x850AE8", VA = "0x850AE8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x14000001")]
	public static event Action onSavingData
	{
		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x852B08", Offset = "0x852B08", VA = "0x852B08")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x85381C", Offset = "0x85381C", VA = "0x85381C")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x60001FB")]
	[Address(RVA = "0x85088C", Offset = "0x85088C", VA = "0x85088C")]
	public static void SetUser(string user, DateTime? importOldSavedData)
	{
	}

	[Token(Token = "0x60001FE")]
	[Address(RVA = "0x868088", Offset = "0x868088", VA = "0x868088")]
	public static void SetDeleted()
	{
	}

	[Token(Token = "0x60001FF")]
	[Address(RVA = "0x853370", Offset = "0x853370", VA = "0x853370")]
	public static void Save()
	{
	}

	[Token(Token = "0x6000200")]
	[Address(RVA = "0x867F20", Offset = "0x867F20", VA = "0x867F20")]
	private static Stream GetDataSteam(string path, bool save)
	{
		return null;
	}
}
[Token(Token = "0x2000050")]
public class StreamingAssetsUtil
{
	[Token(Token = "0x4000119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static IReadOnlyCollection<string> _androidAssets;

	[Token(Token = "0x17000071")]
	public static IReadOnlyCollection<string> androidAssets
	{
		[Token(Token = "0x600020B")]
		[Address(RVA = "0x868590", Offset = "0x868590", VA = "0x868590")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000207")]
	[Address(RVA = "0x8683F4", Offset = "0x8683F4", VA = "0x8683F4")]
	public static string GetAssetUrl(string assetName)
	{
		return null;
	}

	[Token(Token = "0x6000208")]
	[Address(RVA = "0x868460", Offset = "0x868460", VA = "0x868460")]
	public static string GetAssetPath(string assetName)
	{
		return null;
	}

	[Token(Token = "0x6000209")]
	[Address(RVA = "0x868510", Offset = "0x868510", VA = "0x868510")]
	public static bool IsAssetExists(string assetName)
	{
		return default(bool);
	}

	[Token(Token = "0x600020A")]
	[Address(RVA = "0x868BC0", Offset = "0x868BC0", VA = "0x868BC0")]
	public static List<string> ListAssetNames(string path, [Optional] Func<string, bool> matcher)
	{
		return null;
	}

	[Token(Token = "0x600020C")]
	[Address(RVA = "0x869144", Offset = "0x869144", VA = "0x869144")]
	public StreamingAssetsUtil()
	{
	}
}
[Token(Token = "0x2000051")]
[ConfigurableComponent]
public class TransformConf : MonoBehaviour
{
	[Token(Token = "0x400011A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject _targetObject;

	[Token(Token = "0x17000072")]
	public GameObject targetObject
	{
		[Token(Token = "0x600020D")]
		[Address(RVA = "0x86914C", Offset = "0x86914C", VA = "0x86914C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600020E")]
		[Address(RVA = "0x8691CC", Offset = "0x8691CC", VA = "0x8691CC")]
		set
		{
		}
	}

	[Token(Token = "0x17000073")]
	[ConfigurableMember("localPosition")]
	public Vector3 localPosition
	{
		[Token(Token = "0x600020F")]
		[Address(RVA = "0x8691D4", Offset = "0x8691D4", VA = "0x8691D4")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000210")]
		[Address(RVA = "0x8691FC", Offset = "0x8691FC", VA = "0x8691FC")]
		set
		{
		}
	}

	[Token(Token = "0x17000074")]
	[ConfigurableMember("localRotation")]
	public Quaternion localRotation
	{
		[Token(Token = "0x6000211")]
		[Address(RVA = "0x86924C", Offset = "0x86924C", VA = "0x86924C")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x6000212")]
		[Address(RVA = "0x869274", Offset = "0x869274", VA = "0x869274")]
		set
		{
		}
	}

	[Token(Token = "0x17000075")]
	[ConfigurableMember("localScale")]
	public Vector3 localScale
	{
		[Token(Token = "0x6000213")]
		[Address(RVA = "0x8692CC", Offset = "0x8692CC", VA = "0x8692CC")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000214")]
		[Address(RVA = "0x8692F4", Offset = "0x8692F4", VA = "0x8692F4")]
		set
		{
		}
	}

	[Token(Token = "0x6000215")]
	[Address(RVA = "0x869344", Offset = "0x869344", VA = "0x869344")]
	public TransformConf()
	{
	}
}
[Token(Token = "0x2000052")]
public class DebugToastMessage
{
	[Token(Token = "0x2000053")]
	private class Controller : MonoBehaviour
	{
		[Token(Token = "0x6000222")]
		[Address(RVA = "0x86A1E8", Offset = "0x86A1E8", VA = "0x86A1E8")]
		public Controller()
		{
		}
	}

	[Token(Token = "0x2000054")]
	private class ToastTask
	{
		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject gameObject;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float time;

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x86A080", Offset = "0x86A080", VA = "0x86A080")]
		public ToastTask()
		{
		}
	}

	[Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class <ShowUntil0>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject gameObject;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Func<bool> until;

		[Token(Token = "0x17000076")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000227")]
			[Address(RVA = "0x86A2FC", Offset = "0x86A2FC", VA = "0x86A2FC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000077")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000229")]
			[Address(RVA = "0x86A344", Offset = "0x86A344", VA = "0x86A344", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x869C2C", Offset = "0x869C2C", VA = "0x869C2C")]
		[DebuggerHidden]
		public <ShowUntil0>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x86A1F0", Offset = "0x86A1F0", VA = "0x86A1F0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x86A1F4", Offset = "0x86A1F4", VA = "0x86A1F4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x86A304", Offset = "0x86A304", VA = "0x86A304", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class <QueueTask>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ToastTask <task>5__2;

		[Token(Token = "0x17000078")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600022D")]
			[Address(RVA = "0x86A590", Offset = "0x86A590", VA = "0x86A590", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000079")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600022F")]
			[Address(RVA = "0x86A5D8", Offset = "0x86A5D8", VA = "0x86A5D8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x869F1C", Offset = "0x869F1C", VA = "0x869F1C")]
		[DebuggerHidden]
		public <QueueTask>d__12(int <>1__state)
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x86A34C", Offset = "0x86A34C", VA = "0x86A34C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x86A350", Offset = "0x86A350", VA = "0x86A350", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x86A598", Offset = "0x86A598", VA = "0x86A598", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400011B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static float defaultPlaneDistance;

	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static int defaultCanvasSortOrder;

	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static float defaultMessagPanelWidth;

	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public static int defaultFontSize;

	[Token(Token = "0x400011F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static GameObject controller;

	[Token(Token = "0x4000120")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static Queue<ToastTask> canvasList;

	[Token(Token = "0x6000216")]
	[Address(RVA = "0x86934C", Offset = "0x86934C", VA = "0x86934C")]
	public static void SetOverlayWorldCamera(Canvas canvas, Camera camera)
	{
	}

	[Token(Token = "0x6000217")]
	[Address(RVA = "0x8694F8", Offset = "0x8694F8", VA = "0x8694F8")]
	public static GameObject CreatMessage(string text, [Optional] Camera camera)
	{
		return null;
	}

	[Token(Token = "0x6000218")]
	[Address(RVA = "0x869A50", Offset = "0x869A50", VA = "0x869A50")]
	public static void ShowMessage(string text, float time = 2f, [Optional] Camera camera)
	{
	}

	[Token(Token = "0x6000219")]
	[Address(RVA = "0x869BB8", Offset = "0x869BB8", VA = "0x869BB8")]
	[IteratorStateMachine(typeof(<ShowUntil0>d__9))]
	private static IEnumerator ShowUntil0(GameObject gameObject, Func<bool> until)
	{
		return null;
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0x869C54", Offset = "0x869C54", VA = "0x869C54")]
	public static float ActiveWithAnimation(GameObject gameObject, string aniName = "ToastIn")
	{
		return default(float);
	}

	[Token(Token = "0x600021B")]
	[Address(RVA = "0x869D6C", Offset = "0x869D6C", VA = "0x869D6C")]
	public static void DestroyWithAnimation(GameObject gameObject, string aniName = "ToastOut")
	{
	}

	[Token(Token = "0x600021C")]
	[Address(RVA = "0x869EBC", Offset = "0x869EBC", VA = "0x869EBC")]
	[IteratorStateMachine(typeof(<QueueTask>d__12))]
	private static IEnumerator QueueTask()
	{
		return null;
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0x869F44", Offset = "0x869F44", VA = "0x869F44")]
	private static void InitController()
	{
	}

	[Token(Token = "0x600021E")]
	[Address(RVA = "0x869ADC", Offset = "0x869ADC", VA = "0x869ADC")]
	public static void ShowCanvas(GameObject canvasObject, float time)
	{
	}

	[Token(Token = "0x600021F")]
	[Address(RVA = "0x86A088", Offset = "0x86A088", VA = "0x86A088")]
	public static void ShowUntil(GameObject canvasObject, Func<bool> until)
	{
	}

	[Token(Token = "0x6000220")]
	[Address(RVA = "0x86A138", Offset = "0x86A138", VA = "0x86A138")]
	public DebugToastMessage()
	{
	}
}
[Token(Token = "0x2000057")]
public class FPSDisplayer : MonoBehaviour
{
	[Token(Token = "0x400012A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int mCount;

	[Token(Token = "0x400012B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private float mDeltaTime;

	[Token(Token = "0x400012C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float mDPS;

	[Token(Token = "0x6000230")]
	[Address(RVA = "0x86A5E0", Offset = "0x86A5E0", VA = "0x86A5E0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000231")]
	[Address(RVA = "0x86A664", Offset = "0x86A664", VA = "0x86A664")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000232")]
	[Address(RVA = "0x86A748", Offset = "0x86A748", VA = "0x86A748")]
	public FPSDisplayer()
	{
	}
}
[Token(Token = "0x2000058")]
public class PlatformSelectorPreprocesser : DocumentLayoutXmlLoader.IDocumentPreprocesser
{
	[Token(Token = "0x400012D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static string _runtimePlatform;

	[Token(Token = "0x1700007A")]
	private static string runtimePlatform
	{
		[Token(Token = "0x6000234")]
		[Address(RVA = "0x86A8E8", Offset = "0x86A8E8", VA = "0x86A8E8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000233")]
	[Address(RVA = "0x86A750", Offset = "0x86A750", VA = "0x86A750", Slot = "4")]
	public bool Preprocess(DocumentLayoutXmlLoader loader, XmlNode node, DocumentLayoutXmlLoader.StyleAttributs style)
	{
		return default(bool);
	}

	[Token(Token = "0x6000235")]
	[Address(RVA = "0x86AA70", Offset = "0x86AA70", VA = "0x86AA70")]
	public PlatformSelectorPreprocesser()
	{
	}
}
[Token(Token = "0x200005A")]
public static class Extensions
{
	[Token(Token = "0x6000239")]
	[Address(RVA = "0x86ABD0", Offset = "0x86ABD0", VA = "0x86ABD0")]
	public static bool IsInOrToState(this Animator animator, string name, int layer = 0)
	{
		return default(bool);
	}

	[Token(Token = "0x600023A")]
	[Address(RVA = "0x86AC88", Offset = "0x86AC88", VA = "0x86AC88")]
	public static bool IsInOrToState(this Animator animator, int nameHash, int layer = 0)
	{
		return default(bool);
	}

	[Token(Token = "0x600023B")]
	[Address(RVA = "0x86AD40", Offset = "0x86AD40", VA = "0x86AD40")]
	public static bool IsInOrToStateByTag(this Animator animator, string tag, int layer = 0)
	{
		return default(bool);
	}

	[Token(Token = "0x600023C")]
	[Address(RVA = "0x86ADF8", Offset = "0x86ADF8", VA = "0x86ADF8")]
	public static bool IsInOrToStateByTag(this Animator animator, int tagHash, int layer = 0)
	{
		return default(bool);
	}
}
[Token(Token = "0x200005B")]
[ExecuteAlways]
public class FakeLight_Light : CollectableBehavior<FakeLight_Light>
{
	[Token(Token = "0x400012F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private LightType _LightType;

	[Token(Token = "0x4000130")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Color _Color;

	[Token(Token = "0x1700007B")]
	public LightType lightType
	{
		[Token(Token = "0x600023D")]
		[Address(RVA = "0x86AEB0", Offset = "0x86AEB0", VA = "0x86AEB0")]
		get
		{
			return default(LightType);
		}
		[Token(Token = "0x600023E")]
		[Address(RVA = "0x86AEB8", Offset = "0x86AEB8", VA = "0x86AEB8")]
		set
		{
		}
	}

	[Token(Token = "0x1700007C")]
	public Color color
	{
		[Token(Token = "0x600023F")]
		[Address(RVA = "0x86AEC0", Offset = "0x86AEC0", VA = "0x86AEC0")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x6000240")]
		[Address(RVA = "0x86AECC", Offset = "0x86AECC", VA = "0x86AECC")]
		set
		{
		}
	}

	[Token(Token = "0x1700007D")]
	protected override bool enabledOnly
	{
		[Token(Token = "0x6000241")]
		[Address(RVA = "0x86AED8", Offset = "0x86AED8", VA = "0x86AED8", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000242")]
	[Address(RVA = "0x86AEE0", Offset = "0x86AEE0", VA = "0x86AEE0")]
	public FakeLight_Light()
	{
	}
}
[Token(Token = "0x200005C")]
[ExecuteAlways]
[RequireComponent(typeof(Renderer))]
public class FakeLight_Material : MonoBehaviour
{
	[Token(Token = "0x4000131")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Renderer mRenderer;

	[Token(Token = "0x4000132")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly int sMatId_LightColorBuffer;

	[Token(Token = "0x4000133")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static readonly int sMatId_LightPositionBuffer;

	[Token(Token = "0x4000134")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static readonly int sMatId_LightCount;

	[Token(Token = "0x6000243")]
	[Address(RVA = "0x86AF54", Offset = "0x86AF54", VA = "0x86AF54")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000244")]
	[Address(RVA = "0x86AFA4", Offset = "0x86AFA4", VA = "0x86AFA4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000245")]
	[Address(RVA = "0x86B5FC", Offset = "0x86B5FC", VA = "0x86B5FC")]
	public FakeLight_Material()
	{
	}
}
[Token(Token = "0x200005D")]
public class FileUtils
{
	[Token(Token = "0x200005E")]
	public enum MediaType
	{
		[Token(Token = "0x4000137")]
		SavedMyWorks = 1,
		[Token(Token = "0x4000138")]
		UserMusic,
		[Token(Token = "0x4000139")]
		SavedChallengeWorks,
		[Token(Token = "0x400013A")]
		UserPictures,
		[Token(Token = "0x400013B")]
		Seals
	}

	[Token(Token = "0x4000135")]
	public const string kAppSubfolder = "YouCalligrapher";

	[Token(Token = "0x1700007E")]
	private static string oldMyWorksDirectory
	{
		[Token(Token = "0x600024B")]
		[Address(RVA = "0x86C880", Offset = "0x86C880", VA = "0x86C880")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000247")]
	[Address(RVA = "0x86B6CC", Offset = "0x86B6CC", VA = "0x86B6CC")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	private static void CreateMediaFolders()
	{
	}

	[Token(Token = "0x6000248")]
	[Address(RVA = "0x86BCD4", Offset = "0x86BCD4", VA = "0x86BCD4")]
	public static bool SaveTextureToFile(Texture2D tex, string path)
	{
		return default(bool);
	}

	[Token(Token = "0x6000249")]
	[Address(RVA = "0x86C028", Offset = "0x86C028", VA = "0x86C028")]
	public static void GetPermissionAndDoAction(Action action, [Optional] Action onDeniedAction)
	{
	}

	[Token(Token = "0x600024A")]
	[Address(RVA = "0x86BB40", Offset = "0x86BB40", VA = "0x86BB40")]
	public static string[] GetMediaDirectory(MediaType type)
	{
		return null;
	}

	[Token(Token = "0x600024C")]
	[Address(RVA = "0x86CB68", Offset = "0x86CB68", VA = "0x86CB68")]
	private static string GetAndroidExternalSubPath()
	{
		return null;
	}

	[Token(Token = "0x600024D")]
	[Address(RVA = "0x86CE00", Offset = "0x86CE00", VA = "0x86CE00")]
	public static string GetAppSubDirectory()
	{
		return null;
	}

	[Token(Token = "0x600024E")]
	[Address(RVA = "0x86C548", Offset = "0x86C548", VA = "0x86C548")]
	public static string GetExternalStorageDirectory()
	{
		return null;
	}

	[Token(Token = "0x600024F")]
	[Address(RVA = "0x86C770", Offset = "0x86C770", VA = "0x86C770")]
	private static string GetMediaSubfolder(MediaType type)
	{
		return null;
	}

	[Token(Token = "0x6000250")]
	[Address(RVA = "0x86CE5C", Offset = "0x86CE5C", VA = "0x86CE5C")]
	public static string[] FindPictures(MediaType mediaType)
	{
		return null;
	}

	[Token(Token = "0x6000251")]
	[Address(RVA = "0x86D4EC", Offset = "0x86D4EC", VA = "0x86D4EC")]
	private static bool IsImageFile(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x6000252")]
	[Address(RVA = "0x86D5AC", Offset = "0x86D5AC", VA = "0x86D5AC")]
	public FileUtils()
	{
	}
}
[Token(Token = "0x2000060")]
[DefaultExecutionOrder(-100)]
[SingletonOption(autoCreate = true, resource = "Prefabs/GameController")]
[RequireComponent(typeof(GameLanguageContext))]
public class GameController : SingletonGameObject<GameController>
{
	[Token(Token = "0x2000061")]
	public enum TutorialOption
	{
		[Token(Token = "0x4000149")]
		Tutorial,
		[Token(Token = "0x400014A")]
		Normal
	}

	[Token(Token = "0x2000062")]
	public enum StartMenuOption
	{
		[Token(Token = "0x400014C")]
		First,
		[Token(Token = "0x400014D")]
		Normal,
		[Token(Token = "0x400014E")]
		OpenBookMenu
	}

	[Serializable]
	[Token(Token = "0x2000063")]
	private class GoldKeysHanlder
	{
		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private VRHandInput.Key[] _GoldKeys;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private HashSet<VRHandInput.Key> mKeys;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Queue<VRHandInput.Key> mHistroyKeys;

		[Token(Token = "0x17000085")]
		public IReadOnlyCollection<VRHandInput.Key> histroyKeys
		{
			[Token(Token = "0x600026B")]
			[Address(RVA = "0x86EF6C", Offset = "0x86EF6C", VA = "0x86EF6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x86EA64", Offset = "0x86EA64", VA = "0x86EA64")]
		public bool Update()
		{
			return default(bool);
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x86E238", Offset = "0x86E238", VA = "0x86E238")]
		public void OnValidate()
		{
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x86EF74", Offset = "0x86EF74", VA = "0x86EF74")]
		public GoldKeysHanlder()
		{
		}
	}

	[Token(Token = "0x400013F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Tooltip("加载本地对象的资源目录，用于实现不同平台的游戏功能配置")]
	[SerializeField]
	private string _LoadLocalGameObjectResource;

	[Token(Token = "0x4000140")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private TutorialOption _tutorialOption;

	[Token(Token = "0x4000141")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private StartMenuOption _startMenuOption;

	[Token(Token = "0x4000142")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private string _TestFestivalDate;

	[Token(Token = "0x4000143")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private GoldKeysHanlder _RuntimeTest;

	[Token(Token = "0x4000146")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private GameLanguageContext mGameLanguageContext;

	[Token(Token = "0x4000147")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float mLongF12Press;

	[Token(Token = "0x1700007F")]
	public TutorialOption tutorialOption
	{
		[Token(Token = "0x6000258")]
		[Address(RVA = "0x86DE60", Offset = "0x86DE60", VA = "0x86DE60")]
		get
		{
			return default(TutorialOption);
		}
		[Token(Token = "0x6000259")]
		[Address(RVA = "0x86DE68", Offset = "0x86DE68", VA = "0x86DE68")]
		set
		{
		}
	}

	[Token(Token = "0x17000080")]
	protected override bool dontDestroyOnLoad
	{
		[Token(Token = "0x600025A")]
		[Address(RVA = "0x86DE70", Offset = "0x86DE70", VA = "0x86DE70", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000081")]
	public StartMenuOption startMenuOption
	{
		[Token(Token = "0x600025B")]
		[Address(RVA = "0x86DE78", Offset = "0x86DE78", VA = "0x86DE78")]
		get
		{
			return default(StartMenuOption);
		}
		[Token(Token = "0x600025C")]
		[Address(RVA = "0x86DE80", Offset = "0x86DE80", VA = "0x86DE80")]
		set
		{
		}
	}

	[Token(Token = "0x17000082")]
	public bool settings_IsEnterTutorial
	{
		[Token(Token = "0x600025D")]
		[Address(RVA = "0x86DE88", Offset = "0x86DE88", VA = "0x86DE88")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600025E")]
		[Address(RVA = "0x86DF3C", Offset = "0x86DF3C", VA = "0x86DF3C")]
		set
		{
		}
	}

	[Token(Token = "0x17000083")]
	public BrushRecorder activeRecordingRecorder
	{
		[Token(Token = "0x600025F")]
		[Address(RVA = "0x86DFE8", Offset = "0x86DFE8", VA = "0x86DFE8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000260")]
		[Address(RVA = "0x86DFF0", Offset = "0x86DFF0", VA = "0x86DFF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000084")]
	public Paper mainPaper
	{
		[Token(Token = "0x6000261")]
		[Address(RVA = "0x86DFF8", Offset = "0x86DFF8", VA = "0x86DFF8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000262")]
		[Address(RVA = "0x86E000", Offset = "0x86E000", VA = "0x86E000")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x6000257")]
	[Address(RVA = "0x86D8E4", Offset = "0x86D8E4", VA = "0x86D8E4")]
	public bool CheckIsMidAutumnFestival()
	{
		return default(bool);
	}

	[Token(Token = "0x6000263")]
	[Address(RVA = "0x86E008", Offset = "0x86E008", VA = "0x86E008", Slot = "5")]
	protected override void OnAwake()
	{
	}

	[Token(Token = "0x6000264")]
	[Address(RVA = "0x86E2D4", Offset = "0x86E2D4", VA = "0x86E2D4", Slot = "7")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6000265")]
	[Address(RVA = "0x86E3A0", Offset = "0x86E3A0", VA = "0x86E3A0")]
	private void SceneManager_activeSceneChanged(Scene arg0, Scene arg1)
	{
	}

	[Token(Token = "0x6000266")]
	[Address(RVA = "0x86E458", Offset = "0x86E458", VA = "0x86E458")]
	public void ClearPaper(Paper paper)
	{
	}

	[Token(Token = "0x6000267")]
	[Address(RVA = "0x86E7DC", Offset = "0x86E7DC", VA = "0x86E7DC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000268")]
	[Address(RVA = "0x86EE40", Offset = "0x86EE40", VA = "0x86EE40", Slot = "6")]
	protected override void OnApplicationQuit()
	{
	}

	[Token(Token = "0x6000269")]
	[Address(RVA = "0x86EEBC", Offset = "0x86EEBC", VA = "0x86EEBC")]
	protected void OnApplicationFocus(bool focus)
	{
	}

	[Token(Token = "0x600026A")]
	[Address(RVA = "0x86EF24", Offset = "0x86EF24", VA = "0x86EF24")]
	public GameController()
	{
	}
}
[Token(Token = "0x2000064")]
public class GameEventHandler
{
	[Token(Token = "0x2000065")]
	public delegate bool OnMessage(GameMessageType msgType, int what, params object[] args);

	[Token(Token = "0x4000152")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static GameEventHandler mHandler;

	[Token(Token = "0x4000153")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private List<OnMessage>[] mLisnters;

	[Token(Token = "0x4000154")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private List<OnMessage> mLisnersAll;

	[Token(Token = "0x600026F")]
	[Address(RVA = "0x86F034", Offset = "0x86F034", VA = "0x86F034")]
	public static void RegisterListner(OnMessage handler, GameMessageType msgType)
	{
	}

	[Token(Token = "0x6000270")]
	[Address(RVA = "0x86F2D0", Offset = "0x86F2D0", VA = "0x86F2D0")]
	public static bool UnregisterListner(OnMessage handler, GameMessageType msgType)
	{
		return default(bool);
	}

	[Token(Token = "0x6000271")]
	[Address(RVA = "0x86E540", Offset = "0x86E540", VA = "0x86E540")]
	public static void SendMessage(GameMessageType msgType, int what, params object[] args)
	{
	}

	[Token(Token = "0x6000272")]
	[Address(RVA = "0x86F394", Offset = "0x86F394", VA = "0x86F394")]
	public static void ClearAllListner()
	{
	}

	[Token(Token = "0x6000273")]
	[Address(RVA = "0x86F228", Offset = "0x86F228", VA = "0x86F228")]
	public GameEventHandler()
	{
	}
}
[Token(Token = "0x2000066")]
public enum GameMessageType : byte
{
	[Token(Token = "0x4000156")]
	All,
	[Token(Token = "0x4000157")]
	Default,
	[Token(Token = "0x4000158")]
	Character,
	[Token(Token = "0x4000159")]
	Level,
	[Token(Token = "0x400015A")]
	System
}
[Token(Token = "0x2000067")]
public class MsgLevel
{
	[Token(Token = "0x400015B")]
	public const int Item_Picked = 1;

	[Token(Token = "0x400015C")]
	public const int Item_Droped = 2;

	[Token(Token = "0x400015D")]
	public const int BrushUpdated = 3;

	[Token(Token = "0x400015E")]
	public const int SealPainted = 4;

	[Token(Token = "0x400015F")]
	public const int ArtsSaved = 5;

	[Token(Token = "0x4000160")]
	public const int PanelOpen = 6;

	[Token(Token = "0x4000161")]
	public const int PanelClose = 7;

	[Token(Token = "0x4000162")]
	public const int CopybookApplied = 8;

	[Token(Token = "0x4000163")]
	public const int PaperCleared = 9;

	[Token(Token = "0x4000164")]
	public const int DeskHeightAdjusted = 10;

	[Token(Token = "0x4000165")]
	public const int PaperUndo = 11;

	[Token(Token = "0x4000166")]
	public const int PaperRedo = 12;

	[Token(Token = "0x4000167")]
	public const int InkGrinding = 13;

	[Token(Token = "0x4000168")]
	public const int Challenge_Level_Completed = 101;

	[Token(Token = "0x4000169")]
	public const int Tutorial_Completed = 201;

	[Token(Token = "0x6000278")]
	[Address(RVA = "0x86F598", Offset = "0x86F598", VA = "0x86F598")]
	public MsgLevel()
	{
	}
}
[Token(Token = "0x2000068")]
[DefaultExecutionOrder(-200)]
public class GameLanguageContext : MonoBehaviour, LanguageUtils.IPropertes, IEnumerable<string>, IEnumerable
{
	[Serializable]
	[Token(Token = "0x2000069")]
	private class Config
	{
		[Serializable]
		[Token(Token = "0x200006A")]
		public class Value
		{
			[Token(Token = "0x4000171")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string value;

			[Token(Token = "0x4000172")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Multiline]
			public string controllerRegex;

			[Token(Token = "0x6000281")]
			[Address(RVA = "0x86FC1C", Offset = "0x86FC1C", VA = "0x86FC1C")]
			public Value()
			{
			}
		}

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string languageKey;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string defaultValue;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Value[] values;

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x86FC14", Offset = "0x86FC14", VA = "0x86FC14")]
		public Config()
		{
		}
	}

	[Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class <GetEnumerator>d__8 : IEnumerator<string>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string <>2__current;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameLanguageContext <>4__this;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IEnumerator <>7__wrap1;

		[Token(Token = "0x17000086")]
		private string System.Collections.Generic.IEnumerator<System.String>.Current
		{
			[Token(Token = "0x6000286")]
			[Address(RVA = "0x86FFDC", Offset = "0x86FFDC", VA = "0x86FFDC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000087")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000288")]
			[Address(RVA = "0x870024", Offset = "0x870024", VA = "0x870024", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x86FB78", Offset = "0x86FB78", VA = "0x86FB78")]
		[DebuggerHidden]
		public <GetEnumerator>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x86FC24", Offset = "0x86FC24", VA = "0x86FC24", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x86FC40", Offset = "0x86FC40", VA = "0x86FC40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x86FF20", Offset = "0x86FF20", VA = "0x86FF20")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x86FFE4", Offset = "0x86FFE4", VA = "0x86FFE4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400016A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RuntimePlatform _TestRuntimePlatform;

	[Token(Token = "0x400016B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Config[] _Configs;

	[Token(Token = "0x400016C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Hashtable mProperties;

	[Token(Token = "0x400016D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private string mCurrentHandControllerType;

	[Token(Token = "0x6000279")]
	[Address(RVA = "0x86F5A0", Offset = "0x86F5A0", VA = "0x86F5A0", Slot = "4")]
	public string GetString(string key, [Optional] string defaultValue)
	{
		return null;
	}

	[Token(Token = "0x600027A")]
	[Address(RVA = "0x86F5DC", Offset = "0x86F5DC", VA = "0x86F5DC")]
	private void Awake()
	{
	}

	[Token(Token = "0x600027B")]
	[Address(RVA = "0x86F89C", Offset = "0x86F89C", VA = "0x86F89C")]
	private void Update()
	{
	}

	[Token(Token = "0x600027C")]
	[Address(RVA = "0x86FAEC", Offset = "0x86FAEC", VA = "0x86FAEC")]
	public void SetObject(string key, object obj)
	{
	}

	[Token(Token = "0x600027D")]
	[Address(RVA = "0x86FB10", Offset = "0x86FB10", VA = "0x86FB10", Slot = "5")]
	[IteratorStateMachine(typeof(<GetEnumerator>d__8))]
	public IEnumerator<string> GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x600027E")]
	[Address(RVA = "0x86FBA0", Offset = "0x86FBA0", VA = "0x86FBA0", Slot = "6")]
	private IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x600027F")]
	[Address(RVA = "0x86FBA4", Offset = "0x86FBA4", VA = "0x86FBA4")]
	public GameLanguageContext()
	{
	}
}
[Token(Token = "0x200006C")]
public class GamePadHighliter : MonoBehaviour
{
	[Token(Token = "0x4000177")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Color hightlightColor;

	[Token(Token = "0x4000178")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Material highlightMaterial;

	[Token(Token = "0x4000179")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject targetObject;

	[Token(Token = "0x400017A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public AnimationCurve curve;

	[Token(Token = "0x400017B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Material mLastMaterial;

	[Token(Token = "0x400017C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private GameObject mLastObject;

	[Token(Token = "0x400017D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float mCurrentTime;

	[Token(Token = "0x6000289")]
	[Address(RVA = "0x87002C", Offset = "0x87002C", VA = "0x87002C")]
	private void Update()
	{
	}

	[Token(Token = "0x600028A")]
	[Address(RVA = "0x87026C", Offset = "0x87026C", VA = "0x87026C")]
	private void RemoveHighlight(GameObject o)
	{
	}

	[Token(Token = "0x600028B")]
	[Address(RVA = "0x870478", Offset = "0x870478", VA = "0x870478")]
	private void AddHighlight(GameObject o)
	{
	}

	[Token(Token = "0x600028C")]
	[Address(RVA = "0x8706F0", Offset = "0x8706F0", VA = "0x8706F0")]
	public GamePadHighliter()
	{
	}
}
[Token(Token = "0x200006D")]
public class GameUtils
{
	[Token(Token = "0x400017E")]
	public const string CKey_MidAutumnFestivalRanges = "MidAutumnFestivalRanges";

	[Token(Token = "0x400017F")]
	public const string CKey_ControllerHeadOverrideRadius = "ControllerHeadOverrideRadius";

	[Token(Token = "0x4000180")]
	public const string CKey_SupportedPostProcessing = "SupportedPostProcessing";

	[Token(Token = "0x4000181")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly PropertiesConfig sConfig;

	[Token(Token = "0x17000088")]
	public static IRealdOnlyConfig config
	{
		[Token(Token = "0x600028F")]
		[Address(RVA = "0x8707DC", Offset = "0x8707DC", VA = "0x8707DC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000290")]
	[Address(RVA = "0x86DB2C", Offset = "0x86DB2C", VA = "0x86DB2C")]
	public static bool CheckIsMidAutumnFestival(DateTime dateTime)
	{
		return default(bool);
	}

	[Token(Token = "0x6000291")]
	[Address(RVA = "0x870834", Offset = "0x870834", VA = "0x870834")]
	public static float? GetControllerHeadOverrideRadius([Optional] string controllerType)
	{
		return null;
	}

	[Token(Token = "0x6000292")]
	[Address(RVA = "0x870B5C", Offset = "0x870B5C", VA = "0x870B5C")]
	public static bool? GetSupportedPostProcessing()
	{
		return null;
	}

	[Token(Token = "0x6000293")]
	[Address(RVA = "0x870C58", Offset = "0x870C58", VA = "0x870C58")]
	public GameUtils()
	{
	}
}
[Token(Token = "0x200006E")]
[RequireComponent(typeof(Paper))]
public class Grader : MonoBehaviour
{
	[Token(Token = "0x4000182")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public KeyCode printGradeKey;

	[Token(Token = "0x4000183")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Paper mPaper;

	[Token(Token = "0x4000184")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private GalleryPanel.PaperConent mSelectedPaper;

	[Token(Token = "0x4000185")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private string mWordsMaskFileUrl;

	[Token(Token = "0x4000186")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool mWordsMaskFileUrlExists;

	[Token(Token = "0x4000187")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Texture2D mMaskTexure;

	[Token(Token = "0x4000188")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool mIsLoadedTexture;

	[Token(Token = "0x4000189")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Material blit;

	[Token(Token = "0x400018A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Material _ClonedMaterial;

	[Token(Token = "0x400018B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private RenderTexture mTmpRenderTexture;

	[Token(Token = "0x17000089")]
	public Texture2D maskTexture
	{
		[Token(Token = "0x6000297")]
		[Address(RVA = "0x870DCC", Offset = "0x870DCC", VA = "0x870DCC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700008A")]
	public Material Blit
	{
		[Token(Token = "0x6000298")]
		[Address(RVA = "0x870DD4", Offset = "0x870DD4", VA = "0x870DD4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700008B")]
	public bool canCalScore
	{
		[Token(Token = "0x600029E")]
		[Address(RVA = "0x871398", Offset = "0x871398", VA = "0x871398")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000295")]
	[Address(RVA = "0x870D20", Offset = "0x870D20", VA = "0x870D20")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000296")]
	[Address(RVA = "0x870DC8", Offset = "0x870DC8", VA = "0x870DC8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000299")]
	[Address(RVA = "0x870EA4", Offset = "0x870EA4", VA = "0x870EA4")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600029A")]
	[Address(RVA = "0x870F88", Offset = "0x870F88", VA = "0x870F88")]
	public bool OnMessage(GameMessageType msgType, int what, params object[] args)
	{
		return default(bool);
	}

	[Token(Token = "0x600029B")]
	[Address(RVA = "0x871060", Offset = "0x871060", VA = "0x871060")]
	public void SetMaskTexture(Texture2D texture)
	{
	}

	[Token(Token = "0x600029C")]
	[Address(RVA = "0x871100", Offset = "0x871100", VA = "0x871100")]
	public RenderTexture OnRenderPaperImage(RenderTexture source)
	{
		return null;
	}

	[Token(Token = "0x600029D")]
	[Address(RVA = "0x87128C", Offset = "0x87128C", VA = "0x87128C")]
	private void Update()
	{
	}

	[Token(Token = "0x600029F")]
	[Address(RVA = "0x8713F8", Offset = "0x8713F8", VA = "0x8713F8")]
	public void CalScore(Action<float?> onScore)
	{
	}

	[Token(Token = "0x60002A0")]
	[Address(RVA = "0x871620", Offset = "0x871620", VA = "0x871620")]
	public void CalScoreAsyn(Texture2D mask, RenderTexture renderTexture, Action<float?> onScore)
	{
	}

	[Token(Token = "0x60002A1")]
	[Address(RVA = "0x871850", Offset = "0x871850", VA = "0x871850")]
	public static float CalScore(Texture2D mask, Texture2D target, bool debug = false)
	{
		return default(float);
	}

	[Token(Token = "0x60002A2")]
	[Address(RVA = "0x871E24", Offset = "0x871E24", VA = "0x871E24")]
	private static void SetTextureColor(Texture2D texture, float x, float y, Color color)
	{
	}

	[Token(Token = "0x60002A3")]
	[Address(RVA = "0x8720A0", Offset = "0x8720A0", VA = "0x8720A0")]
	private static void BlendTextureColor(Texture2D texture, int x, int y, Color color)
	{
	}

	[Token(Token = "0x60002A4")]
	[Address(RVA = "0x87212C", Offset = "0x87212C", VA = "0x87212C")]
	public void OnEndRender()
	{
	}

	[Token(Token = "0x60002A5")]
	[Address(RVA = "0x8721A0", Offset = "0x8721A0", VA = "0x8721A0")]
	public Grader()
	{
	}
}
[Token(Token = "0x2000072")]
public class HandController : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000073")]
	private class Events
	{
		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public VRHandInput.Button clear;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public VRHandInput.Button undoOrRecording;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRHandInput.Button redo;

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x8731FC", Offset = "0x8731FC", VA = "0x8731FC")]
		public Events()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000074")]
	private struct AudioData
	{
		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AudioClip undo;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AudioClip redo;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AudioClip clear;
	}

	[Token(Token = "0x400019E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private AudioData _Audios;

	[Token(Token = "0x400019F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Events _Events;

	[Token(Token = "0x40001A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private string _DefaultAnimationTrigger;

	[Token(Token = "0x40001A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private GameObject _HandModel;

	[Token(Token = "0x40001A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Transform _DefaultHandPosition;

	[Token(Token = "0x40001A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private bool _HindController;

	[Token(Token = "0x40001A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private string _DefaultPaper;

	[Token(Token = "0x40001A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private FeatherBrush mBrush;

	[Token(Token = "0x40001A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private VRVirtualBody mHand;

	[Token(Token = "0x40001A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private VRControllerManager mControllerMananger;

	[Token(Token = "0x40001A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Transform mCurrentPos;

	[Token(Token = "0x1700008C")]
	public GameObject handModel
	{
		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x873028", Offset = "0x873028", VA = "0x873028")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60002B0")]
	[Address(RVA = "0x87295C", Offset = "0x87295C", VA = "0x87295C")]
	private void Start()
	{
	}

	[Token(Token = "0x60002B1")]
	[Address(RVA = "0x872A14", Offset = "0x872A14", VA = "0x872A14")]
	private void OnItemPicked(PickAndDropItem item)
	{
	}

	[Token(Token = "0x60002B2")]
	[Address(RVA = "0x872B4C", Offset = "0x872B4C", VA = "0x872B4C")]
	private void OnItemDroped(PickAndDropItem item)
	{
	}

	[Token(Token = "0x60002B3")]
	[Address(RVA = "0x872B50", Offset = "0x872B50", VA = "0x872B50")]
	private void Update()
	{
	}

	[Token(Token = "0x60002B4")]
	[Address(RVA = "0x872A80", Offset = "0x872A80", VA = "0x872A80")]
	public void SetCustomState(string animationTrigger, string handPosition)
	{
	}

	[Token(Token = "0x60002B5")]
	[Address(RVA = "0x8729B0", Offset = "0x8729B0", VA = "0x8729B0")]
	public void SetIdleState()
	{
	}

	[Token(Token = "0x60002B7")]
	[Address(RVA = "0x872CD0", Offset = "0x872CD0", VA = "0x872CD0")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x60002B8")]
	[Address(RVA = "0x872D58", Offset = "0x872D58", VA = "0x872D58")]
	private void ProcessEvents()
	{
	}

	[Token(Token = "0x60002B9")]
	[Address(RVA = "0x873030", Offset = "0x873030", VA = "0x873030")]
	private Paper GetTargetPaper()
	{
		return null;
	}

	[Token(Token = "0x60002BA")]
	[Address(RVA = "0x873180", Offset = "0x873180", VA = "0x873180")]
	public HandController()
	{
	}
}
[Token(Token = "0x2000075")]
public class InteractionHand : InteractableHandler
{
	[Token(Token = "0x60002BC")]
	[Address(RVA = "0x873218", Offset = "0x873218", VA = "0x873218")]
	public InteractionHand()
	{
	}
}
[Token(Token = "0x2000076")]
public class InkStick : InteractableHandler
{
	[Token(Token = "0x40001AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Transform _RayTranform;

	[Token(Token = "0x40001B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private float _RayDistance;

	[Token(Token = "0x40001B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	[SerializeField]
	private LayerMask _TargetLayer;

	[Token(Token = "0x40001B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private VRVirtualBody mHand;

	[Token(Token = "0x40001B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private InkStickGroundable mInkStickGroundable;

	[Token(Token = "0x40001B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private InteractableObject mCurrentObject;

	[Token(Token = "0x1700008D")]
	public VRVirtualBody currentHand
	{
		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x873278", Offset = "0x873278", VA = "0x873278")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x873280", Offset = "0x873280", VA = "0x873280")]
		set
		{
		}
	}

	[Token(Token = "0x60002BD")]
	[Address(RVA = "0x873220", Offset = "0x873220", VA = "0x873220")]
	private void OnItemPicked()
	{
	}

	[Token(Token = "0x60002BE")]
	[Address(RVA = "0x873270", Offset = "0x873270", VA = "0x873270")]
	private void OnItemDroped()
	{
	}

	[Token(Token = "0x60002C1")]
	[Address(RVA = "0x873288", Offset = "0x873288", VA = "0x873288")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60002C2")]
	[Address(RVA = "0x8734FC", Offset = "0x8734FC", VA = "0x8734FC")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x60002C3")]
	[Address(RVA = "0x87361C", Offset = "0x87361C", VA = "0x87361C")]
	public InkStick()
	{
	}
}
[Token(Token = "0x2000077")]
[RequireComponent(typeof(AudioSource))]
public class InkStickGroundable : InteractableObject
{
	[Token(Token = "0x40001B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private AudioClip _AudioGriding;

	[Token(Token = "0x40001B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Renderer _InkAera;

	[Token(Token = "0x40001B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private ColorPalette _ColorPalette;

	[Token(Token = "0x40001B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Color _NotGrindedColor;

	[Token(Token = "0x40001B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Color _GrindedColor;

	[Token(Token = "0x40001BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private float _GrindingSpeed;

	[Token(Token = "0x40001BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private Vector3 mLastHandPos;

	[Token(Token = "0x40001BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private VRHandInput mCatchedInput;

	[Token(Token = "0x40001BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private AudioSource mAudioSource;

	[Token(Token = "0x1700008E")]
	public ColorPalette colorPalette
	{
		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x873730", Offset = "0x873730", VA = "0x873730")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700008F")]
	public float handSpeed
	{
		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x873738", Offset = "0x873738", VA = "0x873738")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x873740", Offset = "0x873740", VA = "0x873740")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x60002C4")]
	[Address(RVA = "0x873630", Offset = "0x873630", VA = "0x873630")]
	private void Start()
	{
	}

	[Token(Token = "0x60002C5")]
	[Address(RVA = "0x873680", Offset = "0x873680", VA = "0x873680", Slot = "12")]
	public override void OnEnter(InteractableHandler handler)
	{
	}

	[Token(Token = "0x60002C6")]
	[Address(RVA = "0x8736B8", Offset = "0x8736B8", VA = "0x8736B8", Slot = "11")]
	public override bool BeforEnter(InteractableHandler handler)
	{
		return default(bool);
	}

	[Token(Token = "0x60002CA")]
	[Address(RVA = "0x873748", Offset = "0x873748", VA = "0x873748")]
	private void Update()
	{
	}

	[Token(Token = "0x60002CB")]
	[Address(RVA = "0x873D50", Offset = "0x873D50", VA = "0x873D50")]
	public InkStickGroundable()
	{
	}
}
[Token(Token = "0x2000078")]
public class LaserController : MonoBehaviour
{
	[Token(Token = "0x40001BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float forwardMin;

	[Token(Token = "0x40001C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float forwardMax;

	[Token(Token = "0x40001C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public VRDefaultCursor target;

	[Token(Token = "0x60002CC")]
	[Address(RVA = "0x873D78", Offset = "0x873D78", VA = "0x873D78")]
	private void Update()
	{
	}

	[Token(Token = "0x60002CD")]
	[Address(RVA = "0x873F68", Offset = "0x873F68", VA = "0x873F68")]
	public LaserController()
	{
	}
}
[Token(Token = "0x2000079")]
[RequireComponent(typeof(Graphic))]
[ExecuteAlways]
public class GraphicMeshCacher : MonoBehaviour, IMeshModifier
{
	[Token(Token = "0x40001C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Graphic mGraphic;

	[Token(Token = "0x40001C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<UIVertex> mCachedVertices;

	[Token(Token = "0x17000090")]
	public Graphic graphic
	{
		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x873F7C", Offset = "0x873F7C", VA = "0x873F7C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000091")]
	public IReadOnlyList<UIVertex> vertices
	{
		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x874010", Offset = "0x874010", VA = "0x874010")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60002D0")]
	[Address(RVA = "0x874018", Offset = "0x874018", VA = "0x874018")]
	public void GetVertices(UIVertex[] buffer, int offset, int count)
	{
	}

	[Token(Token = "0x60002D1")]
	[Address(RVA = "0x87408C", Offset = "0x87408C", VA = "0x87408C", Slot = "4")]
	public void ModifyMesh(Mesh mesh)
	{
	}

	[Token(Token = "0x60002D2")]
	[Address(RVA = "0x874090", Offset = "0x874090", VA = "0x874090", Slot = "5")]
	public void ModifyMesh(VertexHelper verts)
	{
	}

	[Token(Token = "0x60002D3")]
	[Address(RVA = "0x8740F0", Offset = "0x8740F0", VA = "0x8740F0")]
	public GraphicMeshCacher()
	{
	}
}
[Token(Token = "0x200007A")]
[DefaultExecutionOrder(100)]
[RequireComponent(typeof(CanvasRenderer))]
[ExecuteAlways]
public class GraphicRectCutter : MaskableGraphic
{
	[Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class <DelayUpdate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GraphicRectCutter <>4__this;

		[Token(Token = "0x17000093")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002E8")]
			[Address(RVA = "0x876254", Offset = "0x876254", VA = "0x876254", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000094")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002EA")]
			[Address(RVA = "0x87629C", Offset = "0x87629C", VA = "0x87629C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x8744B8", Offset = "0x8744B8", VA = "0x8744B8")]
		[DebuggerHidden]
		public <DelayUpdate>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x8761A8", Offset = "0x8761A8", VA = "0x8761A8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x8761AC", Offset = "0x8761AC", VA = "0x8761AC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x87625C", Offset = "0x87625C", VA = "0x87625C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40001C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private GraphicMeshCacher _Background;

	[Token(Token = "0x40001C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Vector3[] sLoopConers;

	[Token(Token = "0x40001C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private bool mBackgroundVerticesDirty;

	[Token(Token = "0x40001C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD9")]
	private bool mBackgroundMaterialDirty;

	[Token(Token = "0x40001C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	private Rect mTargetRect;

	[Token(Token = "0x40001C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static readonly UIVertex[] sPoolPolygon;

	[Token(Token = "0x40001CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static readonly UIVertex[] sPoolPolygon2;

	[Token(Token = "0x17000092")]
	public override Texture mainTexture
	{
		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x8744E0", Offset = "0x8744E0", VA = "0x8744E0", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60002D4")]
	[Address(RVA = "0x87416C", Offset = "0x87416C", VA = "0x87416C", Slot = "6")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60002D5")]
	[Address(RVA = "0x874174", Offset = "0x874174", VA = "0x874174", Slot = "5")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x60002D6")]
	[Address(RVA = "0x8742E8", Offset = "0x8742E8", VA = "0x8742E8", Slot = "7")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x60002D7")]
	[Address(RVA = "0x874450", Offset = "0x874450", VA = "0x874450")]
	[IteratorStateMachine(typeof(<DelayUpdate>d__8))]
	private IEnumerator DelayUpdate()
	{
		return null;
	}

	[Token(Token = "0x60002D8")]
	[Address(RVA = "0x874190", Offset = "0x874190", VA = "0x874190")]
	private void RegisterCallbacks()
	{
	}

	[Token(Token = "0x60002D9")]
	[Address(RVA = "0x874308", Offset = "0x874308", VA = "0x874308")]
	private void UnregisterCallbacks(GraphicMeshCacher _Background)
	{
	}

	[Token(Token = "0x60002DB")]
	[Address(RVA = "0x874578", Offset = "0x874578", VA = "0x874578")]
	private void OnBackgroundVerticesDirty()
	{
	}

	[Token(Token = "0x60002DC")]
	[Address(RVA = "0x874584", Offset = "0x874584", VA = "0x874584")]
	private void OnBackgroundMaterialDirty()
	{
	}

	[Token(Token = "0x60002DD")]
	[Address(RVA = "0x874590", Offset = "0x874590", VA = "0x874590", Slot = "44")]
	protected override void OnPopulateMesh(VertexHelper vh)
	{
	}

	[Token(Token = "0x60002DE")]
	[Address(RVA = "0x874EFC", Offset = "0x874EFC", VA = "0x874EFC")]
	public static int RectCutout(Rect rect, Span<UIVertex> vertices, List<UIVertex> result)
	{
		return default(int);
	}

	[Token(Token = "0x60002DF")]
	[Address(RVA = "0x875AF4", Offset = "0x875AF4", VA = "0x875AF4")]
	private static void HorizontalCast(float y, ref UIVertex v1, ref UIVertex v2, out UIVertex result)
	{
	}

	[Token(Token = "0x60002E0")]
	[Address(RVA = "0x875CBC", Offset = "0x875CBC", VA = "0x875CBC")]
	private static void VerticalCast(float x, ref UIVertex v1, ref UIVertex v2, out UIVertex result)
	{
	}

	[Token(Token = "0x60002E1")]
	[Address(RVA = "0x875E80", Offset = "0x875E80", VA = "0x875E80", Slot = "65")]
	protected virtual void OnBackroundCutouted(Span<UIVertex> vertices, Rect rect)
	{
	}

	[Token(Token = "0x60002E2")]
	[Address(RVA = "0x875E84", Offset = "0x875E84", VA = "0x875E84")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60002E3")]
	[Address(RVA = "0x8760EC", Offset = "0x8760EC", VA = "0x8760EC")]
	public GraphicRectCutter()
	{
	}
}
[Token(Token = "0x200007C")]
public class GraphicRectFader : GraphicRectCutter
{
	[Token(Token = "0x200007D")]
	private enum Direction
	{
		[Token(Token = "0x40001D5")]
		None,
		[Token(Token = "0x40001D6")]
		Up,
		[Token(Token = "0x40001D7")]
		Down,
		[Token(Token = "0x40001D8")]
		Left,
		[Token(Token = "0x40001D9")]
		Right
	}

	[Token(Token = "0x200007E")]
	private enum TextureOption
	{
		[Token(Token = "0x40001DB")]
		None,
		[Token(Token = "0x40001DC")]
		Sprite,
		[Token(Token = "0x40001DD")]
		Texture
	}

	[Token(Token = "0x40001CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	[SerializeField]
	private Direction _Direction;

	[Token(Token = "0x40001CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	[SerializeField]
	private Color _StartColor;

	[Token(Token = "0x40001D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	[SerializeField]
	private Color _EndColor;

	[Token(Token = "0x40001D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	[SerializeField]
	private TextureOption _TextureOption;

	[Token(Token = "0x40001D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	[SerializeField]
	private Sprite _Sprite;

	[Token(Token = "0x40001D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	[SerializeField]
	private Texture _Texture;

	[Token(Token = "0x60002EB")]
	[Address(RVA = "0x8762A4", Offset = "0x8762A4", VA = "0x8762A4", Slot = "40")]
	protected override void UpdateMaterial()
	{
	}

	[Token(Token = "0x60002EC")]
	[Address(RVA = "0x8765BC", Offset = "0x8765BC", VA = "0x8765BC", Slot = "65")]
	protected override void OnBackroundCutouted(Span<UIVertex> vertices, Rect rect)
	{
	}

	[Token(Token = "0x60002ED")]
	[Address(RVA = "0x877554", Offset = "0x877554", VA = "0x877554")]
	public GraphicRectFader()
	{
	}
}
[Token(Token = "0x200007F")]
public class LogoManager : MonoBehaviour
{
	[Token(Token = "0x2000080")]
	[CompilerGenerated]
	private sealed class <StartLogo>d__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LogoManager <>4__this;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animation <animation>5__2;

		[Token(Token = "0x17000095")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002F4")]
			[Address(RVA = "0x8778FC", Offset = "0x8778FC", VA = "0x8778FC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000096")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002F6")]
			[Address(RVA = "0x877944", Offset = "0x877944", VA = "0x877944", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x877644", Offset = "0x877644", VA = "0x877644")]
		[DebuggerHidden]
		public <StartLogo>d__1(int <>1__state)
		{
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x877674", Offset = "0x877674", VA = "0x877674", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x877678", Offset = "0x877678", VA = "0x877678", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x877904", Offset = "0x877904", VA = "0x877904", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x60002EE")]
	[Address(RVA = "0x8775BC", Offset = "0x8775BC", VA = "0x8775BC")]
	private void Start()
	{
	}

	[Token(Token = "0x60002EF")]
	[Address(RVA = "0x8775DC", Offset = "0x8775DC", VA = "0x8775DC")]
	[IteratorStateMachine(typeof(<StartLogo>d__1))]
	private IEnumerator StartLogo()
	{
		return null;
	}

	[Token(Token = "0x60002F0")]
	[Address(RVA = "0x87766C", Offset = "0x87766C", VA = "0x87766C")]
	public LogoManager()
	{
	}
}
[Token(Token = "0x2000081")]
[RequireComponent(typeof(SpriteRenderer))]
[ExecuteInEditMode]
public class LogoSpriteAnimation : MonoBehaviour
{
	[Token(Token = "0x40001E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Sprite[] _Sprites;

	[Token(Token = "0x40001E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Range(0f, 1f)]
	private float _NormalizedTime;

	[Token(Token = "0x40001E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private SpriteRenderer mSpriteRenderer;

	[Token(Token = "0x60002F7")]
	[Address(RVA = "0x87794C", Offset = "0x87794C", VA = "0x87794C")]
	private void Start()
	{
	}

	[Token(Token = "0x60002F8")]
	[Address(RVA = "0x87799C", Offset = "0x87799C", VA = "0x87799C")]
	private void Update()
	{
	}

	[Token(Token = "0x60002F9")]
	[Address(RVA = "0x877B6C", Offset = "0x877B6C", VA = "0x877B6C")]
	public LogoSpriteAnimation()
	{
	}
}
[Token(Token = "0x2000082")]
[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class MeshLineRenderer : MonoBehaviour
{
	[Token(Token = "0x40001E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Material lMat;

	[Token(Token = "0x40001E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Mesh ml;

	[Token(Token = "0x40001E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Vector3 s;

	[Token(Token = "0x40001E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float lineSize;

	[Token(Token = "0x40001E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool firstQuad;

	[Token(Token = "0x60002FA")]
	[Address(RVA = "0x877B74", Offset = "0x877B74", VA = "0x877B74")]
	private void Start()
	{
	}

	[Token(Token = "0x60002FB")]
	[Address(RVA = "0x877C00", Offset = "0x877C00", VA = "0x877C00")]
	private void Update()
	{
	}

	[Token(Token = "0x60002FC")]
	[Address(RVA = "0x877C04", Offset = "0x877C04", VA = "0x877C04")]
	public void setWidth(float lineSize)
	{
	}

	[Token(Token = "0x60002FD")]
	[Address(RVA = "0x877C0C", Offset = "0x877C0C", VA = "0x877C0C")]
	public void AddPoint(Vector3 point)
	{
	}

	[Token(Token = "0x60002FE")]
	[Address(RVA = "0x877CF4", Offset = "0x877CF4", VA = "0x877CF4")]
	private Vector3[] MakeQuad(Vector3 s, Vector3 e, float w, bool all)
	{
		return null;
	}

	[Token(Token = "0x60002FF")]
	[Address(RVA = "0x878088", Offset = "0x878088", VA = "0x878088")]
	private void AddLine(Mesh m, Vector3[] quad)
	{
	}

	[Token(Token = "0x6000300")]
	[Address(RVA = "0x8786B4", Offset = "0x8786B4", VA = "0x8786B4")]
	private Vector3[] resizeVectices(Vector3[] ovs, int ns)
	{
		return null;
	}

	[Token(Token = "0x6000301")]
	[Address(RVA = "0x878768", Offset = "0x878768", VA = "0x878768")]
	private Vector2[] resizeUVs(Vector2[] uvs, int ns)
	{
		return null;
	}

	[Token(Token = "0x6000302")]
	[Address(RVA = "0x878814", Offset = "0x878814", VA = "0x878814")]
	private int[] resizeTriangles(int[] ovs, int ns)
	{
		return null;
	}

	[Token(Token = "0x6000303")]
	[Address(RVA = "0x8788C0", Offset = "0x8788C0", VA = "0x8788C0")]
	public MeshLineRenderer()
	{
	}
}
[Token(Token = "0x2000083")]
public class MouseLineRenderer : MonoBehaviour
{
	[Token(Token = "0x40001EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private LineRenderer lineRenderer;

	[Token(Token = "0x40001EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<Vector3> positions;

	[Token(Token = "0x40001EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Camera mainCamera;

	[Token(Token = "0x40001ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Rect canvasRect;

	[Token(Token = "0x40001EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool leftMousePressed;

	[Token(Token = "0x6000304")]
	[Address(RVA = "0x8788DC", Offset = "0x8788DC", VA = "0x8788DC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000305")]
	[Address(RVA = "0x878934", Offset = "0x878934", VA = "0x878934")]
	private void Update()
	{
	}

	[Token(Token = "0x6000306")]
	[Address(RVA = "0x878B60", Offset = "0x878B60", VA = "0x878B60")]
	private LineRenderer createLineRenderer()
	{
		return null;
	}

	[Token(Token = "0x6000307")]
	[Address(RVA = "0x878CD4", Offset = "0x878CD4", VA = "0x878CD4")]
	private void moveCameraWithRightMouse()
	{
	}

	[Token(Token = "0x6000308")]
	[Address(RVA = "0x878E58", Offset = "0x878E58", VA = "0x878E58")]
	public MouseLineRenderer()
	{
	}
}
[Token(Token = "0x2000084")]
public class MouseTrailRenderer : MonoBehaviour
{
	[Token(Token = "0x6000309")]
	[Address(RVA = "0x878E60", Offset = "0x878E60", VA = "0x878E60")]
	private void Start()
	{
	}

	[Token(Token = "0x600030A")]
	[Address(RVA = "0x878E64", Offset = "0x878E64", VA = "0x878E64")]
	private void Update()
	{
	}

	[Token(Token = "0x600030B")]
	[Address(RVA = "0x87900C", Offset = "0x87900C", VA = "0x87900C")]
	public MouseTrailRenderer()
	{
	}
}
[Token(Token = "0x2000085")]
[SingletonOption(resource = "Prefabs/MusicPlayer")]
[RequireComponent(typeof(AudioSource))]
public class MusicPlayer : SingletonGameObject<MusicPlayer>, MediaPlayerController.MediaPlayer
{
	[Serializable]
	[Token(Token = "0x2000086")]
	public class MusicInfo
	{
		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string title;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioClip clip;

		[NonSerialized]
		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string loadedUrl;

		[NonSerialized]
		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool isLoadedExternal;

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x879E88", Offset = "0x879E88", VA = "0x879E88")]
		public MusicInfo()
		{
		}
	}

	[Token(Token = "0x40001EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<MusicInfo> clips;

	[Token(Token = "0x40001F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float volumeStep;

	[Token(Token = "0x40001F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[ConfigurableMember("autoPlay")]
	public bool autoPlay;

	[Token(Token = "0x40001F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
	public bool dontPlayInEditor;

	[Token(Token = "0x40001F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E")]
	private bool _DontDestroyOnLoad;

	[Token(Token = "0x40001F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private AudioSource mAudioSource;

	[Token(Token = "0x17000097")]
	protected override bool dontDestroyOnLoad
	{
		[Token(Token = "0x600030D")]
		[Address(RVA = "0x879728", Offset = "0x879728", VA = "0x879728", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000098")]
	private int currentClipIndex
	{
		[Token(Token = "0x600030E")]
		[Address(RVA = "0x879730", Offset = "0x879730", VA = "0x879730")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000099")]
	public MusicInfo currentPlaying
	{
		[Token(Token = "0x600030F")]
		[Address(RVA = "0x879798", Offset = "0x879798", VA = "0x879798")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000310")]
		[Address(RVA = "0x8797A0", Offset = "0x8797A0", VA = "0x8797A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700009A")]
	public bool isPlaying
	{
		[Token(Token = "0x6000318")]
		[Address(RVA = "0x879D3C", Offset = "0x879D3C", VA = "0x879D3C", Slot = "8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000319")]
		[Address(RVA = "0x879144", Offset = "0x879144", VA = "0x879144", Slot = "9")]
		set
		{
		}
	}

	[Token(Token = "0x1700009B")]
	private AudioSource audioSource
	{
		[Token(Token = "0x600031B")]
		[Address(RVA = "0x8790B0", Offset = "0x8790B0", VA = "0x8790B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700009C")]
	public bool isPaused
	{
		[Token(Token = "0x600031C")]
		[Address(RVA = "0x879D58", Offset = "0x879D58", VA = "0x879D58", Slot = "10")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600031D")]
		[Address(RVA = "0x879E18", Offset = "0x879E18", VA = "0x879E18", Slot = "11")]
		set
		{
		}
	}

	[Token(Token = "0x1700009D")]
	public bool canPlay
	{
		[Token(Token = "0x600031F")]
		[Address(RVA = "0x879E90", Offset = "0x879E90", VA = "0x879E90", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700009E")]
	public bool canPlayNext
	{
		[Token(Token = "0x6000320")]
		[Address(RVA = "0x879E98", Offset = "0x879E98", VA = "0x879E98", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700009F")]
	public bool canPlayPrev
	{
		[Token(Token = "0x6000321")]
		[Address(RVA = "0x879EA0", Offset = "0x879EA0", VA = "0x879EA0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000A0")]
	public float volumn
	{
		[Token(Token = "0x6000322")]
		[Address(RVA = "0x879EA8", Offset = "0x879EA8", VA = "0x879EA8", Slot = "17")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000323")]
		[Address(RVA = "0x879EC4", Offset = "0x879EC4", VA = "0x879EC4", Slot = "18")]
		set
		{
		}
	}

	[Token(Token = "0x170000A1")]
	public float time
	{
		[Token(Token = "0x6000324")]
		[Address(RVA = "0x879EF0", Offset = "0x879EF0", VA = "0x879EF0", Slot = "19")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000325")]
		[Address(RVA = "0x879F0C", Offset = "0x879F0C", VA = "0x879F0C", Slot = "20")]
		set
		{
		}
	}

	[Token(Token = "0x170000A2")]
	public float length
	{
		[Token(Token = "0x6000326")]
		[Address(RVA = "0x879F38", Offset = "0x879F38", VA = "0x879F38", Slot = "21")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x600030C")]
	[Address(RVA = "0x879014", Offset = "0x879014", VA = "0x879014", Slot = "5")]
	protected override void OnAwake()
	{
	}

	[Token(Token = "0x6000311")]
	[Address(RVA = "0x8797A8", Offset = "0x8797A8", VA = "0x8797A8")]
	public void PlayAt(int index)
	{
	}

	[Token(Token = "0x6000312")]
	[Address(RVA = "0x879A90", Offset = "0x879A90", VA = "0x879A90")]
	public void PlayDefault()
	{
	}

	[Token(Token = "0x6000313")]
	[Address(RVA = "0x879834", Offset = "0x879834", VA = "0x879834")]
	public void Play(MusicInfo music)
	{
	}

	[Token(Token = "0x6000314")]
	[Address(RVA = "0x879BFC", Offset = "0x879BFC", VA = "0x879BFC", Slot = "12")]
	public void PlayNext()
	{
	}

	[Token(Token = "0x6000315")]
	[Address(RVA = "0x879C5C", Offset = "0x879C5C", VA = "0x879C5C", Slot = "13")]
	public void PlayPrev()
	{
	}

	[Token(Token = "0x6000316")]
	[Address(RVA = "0x879CBC", Offset = "0x879CBC", VA = "0x879CBC")]
	public void VolumeDown()
	{
	}

	[Token(Token = "0x6000317")]
	[Address(RVA = "0x879CFC", Offset = "0x879CFC", VA = "0x879CFC")]
	public void VolumeUp()
	{
	}

	[Token(Token = "0x600031A")]
	[Address(RVA = "0x879AE8", Offset = "0x879AE8", VA = "0x879AE8")]
	public static AudioType GetAudioType(string extesion)
	{
		return default(AudioType);
	}

	[Token(Token = "0x600031E")]
	[Address(RVA = "0x8793E0", Offset = "0x8793E0", VA = "0x8793E0")]
	private List<MusicInfo> FindAllUserMusicInfo()
	{
		return null;
	}

	[Token(Token = "0x6000327")]
	[Address(RVA = "0x879FE8", Offset = "0x879FE8", VA = "0x879FE8")]
	public MusicPlayer()
	{
	}
}
[Token(Token = "0x2000089")]
public class AlphaPalette : PaperObject
{
	[Token(Token = "0x40001FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float colorSmooth;

	[Token(Token = "0x4000200")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float width;

	[Token(Token = "0x4000201")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float length;

	[Token(Token = "0x4000202")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float alphaMutiply;

	[Token(Token = "0x4000203")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public AnimationCurve alphaCurve;

	[Token(Token = "0x4000204")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Color mLastColor;

	[Token(Token = "0x4000205")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private List<Material> mMats;

	[Token(Token = "0x600032F")]
	[Address(RVA = "0x87A478", Offset = "0x87A478", VA = "0x87A478")]
	public float GetAlphaFromLocalPosition(Vector3 pos)
	{
		return default(float);
	}

	[Token(Token = "0x6000330")]
	[Address(RVA = "0x87A4F4", Offset = "0x87A4F4", VA = "0x87A4F4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000331")]
	[Address(RVA = "0x87A604", Offset = "0x87A604", VA = "0x87A604")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000332")]
	[Address(RVA = "0x87A6C8", Offset = "0x87A6C8", VA = "0x87A6C8")]
	public AlphaPalette()
	{
	}
}
[Token(Token = "0x200008A")]
[ExecuteInEditMode]
public class ColorPalette : PaperObject
{
	[Token(Token = "0x200008B")]
	[Flags]
	public enum ColorMask
	{
		[Token(Token = "0x400020F")]
		R = 1,
		[Token(Token = "0x4000210")]
		G = 2,
		[Token(Token = "0x4000211")]
		B = 4,
		[Token(Token = "0x4000212")]
		A = 8
	}

	[Token(Token = "0x4000206")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Color color;

	[Token(Token = "0x4000207")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float colorSmooth;

	[Token(Token = "0x4000208")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[Range(0f, 1f)]
	public float volumn;

	[Token(Token = "0x4000209")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private ColorMask _ColorMask;

	[Token(Token = "0x400020A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[SerializeField]
	private float _LinearColorBlendSpeed;

	[Token(Token = "0x400020B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Renderer[] _TargetRenderers;

	[Token(Token = "0x400020C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Color mLastColor;

	[Token(Token = "0x400020D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private List<Material> mMats;

	[Token(Token = "0x170000A3")]
	public override Vector3 normal
	{
		[Token(Token = "0x6000333")]
		[Address(RVA = "0x87A6DC", Offset = "0x87A6DC", VA = "0x87A6DC", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x170000A4")]
	public ColorMask colorMask
	{
		[Token(Token = "0x6000334")]
		[Address(RVA = "0x87A70C", Offset = "0x87A70C", VA = "0x87A70C")]
		get
		{
			return default(ColorMask);
		}
		[Token(Token = "0x6000335")]
		[Address(RVA = "0x87A714", Offset = "0x87A714", VA = "0x87A714")]
		set
		{
		}
	}

	[Token(Token = "0x6000336")]
	[Address(RVA = "0x87A71C", Offset = "0x87A71C", VA = "0x87A71C", Slot = "5")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6000337")]
	[Address(RVA = "0x87A848", Offset = "0x87A848", VA = "0x87A848")]
	private void Update()
	{
	}

	[Token(Token = "0x6000338")]
	[Address(RVA = "0x87AE50", Offset = "0x87AE50", VA = "0x87AE50")]
	public ColorPalette()
	{
	}
}
[Token(Token = "0x200008C")]
[ExecuteAlways]
[ConfigurableComponent]
public class FeatherBrush : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200008D")]
	public class BrushNode
	{
		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 position;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 normal;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool isOnPlane;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool lastOnPlane;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float radius;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 onPaperLocalPosition;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 lastOnPaperLocalPosition;

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x87BC34", Offset = "0x87BC34", VA = "0x87BC34")]
		public BrushNode()
		{
		}
	}

	[Token(Token = "0x4000213")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[ConfigurableMember("nodeCount")]
	public int nodeCount;

	[Token(Token = "0x4000214")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[ConfigurableMember("length")]
	public float brushLength;

	[Token(Token = "0x4000215")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[ConfigurableMember("smooth")]
	public float smooth;

	[Token(Token = "0x4000216")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Color color;

	[Token(Token = "0x4000217")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public bool drawBrushInEdtior;

	[Token(Token = "0x4000218")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float onPagerError;

	[Token(Token = "0x4000219")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float errorHeight;

	[Token(Token = "0x400021A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float holderHeight;

	[Token(Token = "0x400021B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float maxAngle;

	[Token(Token = "0x400021C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	[FormerlySerializedAs("sizeMultipy")]
	private float mSizeMultipy;

	[Token(Token = "0x400021D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	public AnimationCurve brushSize;

	[Token(Token = "0x400021E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private bool _Paint;

	[Token(Token = "0x400021F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private BrushNode[] mNodes;

	[Token(Token = "0x4000220")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int mLastNodeCount;

	[Token(Token = "0x4000221")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Material mMat;

	[Token(Token = "0x4000222")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private bool mSizeChanged;

	[Token(Token = "0x4000223")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private FeatherBrushInteractable mCurrentObject;

	[Token(Token = "0x4000224")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool mSetHandVibration;

	[Token(Token = "0x4000225")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private float mHandVibration;

	[Token(Token = "0x4000226")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private VRVirtualBody mHand;

	[Token(Token = "0x4000227")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public int debugNode;

	[Token(Token = "0x170000A5")]
	[ConfigurableMember("sizeMultipy")]
	public float sizeMultipy
	{
		[Token(Token = "0x6000339")]
		[Address(RVA = "0x87AE70", Offset = "0x87AE70", VA = "0x87AE70")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600033A")]
		[Address(RVA = "0x87AE78", Offset = "0x87AE78", VA = "0x87AE78")]
		set
		{
		}
	}

	[Token(Token = "0x170000A6")]
	public FeatherBrushInteractable currentObject
	{
		[Token(Token = "0x6000344")]
		[Address(RVA = "0x87BC7C", Offset = "0x87BC7C", VA = "0x87BC7C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000345")]
		[Address(RVA = "0x87BC84", Offset = "0x87BC84", VA = "0x87BC84")]
		private set
		{
		}
	}

	[Token(Token = "0x170000A7")]
	private Ray detectRay
	{
		[Token(Token = "0x6000346")]
		[Address(RVA = "0x87BD88", Offset = "0x87BD88", VA = "0x87BD88")]
		get
		{
			return default(Ray);
		}
	}

	[Token(Token = "0x170000A8")]
	private float detectRayDitance
	{
		[Token(Token = "0x6000347")]
		[Address(RVA = "0x87BE68", Offset = "0x87BE68", VA = "0x87BE68")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170000A9")]
	private bool setHandVibration
	{
		[Token(Token = "0x600034A")]
		[Address(RVA = "0x87BFB8", Offset = "0x87BFB8", VA = "0x87BFB8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600034B")]
		[Address(RVA = "0x87BED8", Offset = "0x87BED8", VA = "0x87BED8")]
		set
		{
		}
	}

	[Token(Token = "0x170000AA")]
	public BrushNode[] nodes
	{
		[Token(Token = "0x6000352")]
		[Address(RVA = "0x87C2F0", Offset = "0x87C2F0", VA = "0x87C2F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000AB")]
	public bool isAnyNodeOnPlane
	{
		[Token(Token = "0x6000353")]
		[Address(RVA = "0x87ADFC", Offset = "0x87ADFC", VA = "0x87ADFC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000AC")]
	public bool paint
	{
		[Token(Token = "0x6000354")]
		[Address(RVA = "0x87C2F8", Offset = "0x87C2F8", VA = "0x87C2F8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000355")]
		[Address(RVA = "0x87C300", Offset = "0x87C300", VA = "0x87C300")]
		set
		{
		}
	}

	[Token(Token = "0x600033B")]
	[Address(RVA = "0x87AE88", Offset = "0x87AE88", VA = "0x87AE88")]
	private void Awake()
	{
	}

	[Token(Token = "0x600033C")]
	[Address(RVA = "0x87AF08", Offset = "0x87AF08", VA = "0x87AF08")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600033D")]
	[Address(RVA = "0x87AF88", Offset = "0x87AF88", VA = "0x87AF88")]
	[BeforeRenderOrder(10)]
	private void Application_onBeforeRender()
	{
	}

	[Token(Token = "0x600033E")]
	[Address(RVA = "0x87B070", Offset = "0x87B070", VA = "0x87B070")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600033F")]
	[Address(RVA = "0x87B074", Offset = "0x87B074", VA = "0x87B074")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000340")]
	[Address(RVA = "0x87B078", Offset = "0x87B078", VA = "0x87B078")]
	private void Update()
	{
	}

	[Token(Token = "0x6000341")]
	[Address(RVA = "0x87AFA4", Offset = "0x87AFA4", VA = "0x87AFA4")]
	private void UpdateBrush(float deltaTime)
	{
	}

	[Token(Token = "0x6000342")]
	[Address(RVA = "0x87BC28", Offset = "0x87BC28", VA = "0x87BC28")]
	public void OnValidate()
	{
	}

	[Token(Token = "0x6000343")]
	[Address(RVA = "0x87B17C", Offset = "0x87B17C", VA = "0x87B17C")]
	private void CheckParamChanges()
	{
	}

	[Token(Token = "0x6000348")]
	[Address(RVA = "0x87BE7C", Offset = "0x87BE7C", VA = "0x87BE7C")]
	private void OnItemPicked()
	{
	}

	[Token(Token = "0x6000349")]
	[Address(RVA = "0x87BF9C", Offset = "0x87BF9C", VA = "0x87BF9C")]
	private void OnItemDroped()
	{
	}

	[Token(Token = "0x600034C")]
	[Address(RVA = "0x87B380", Offset = "0x87B380", VA = "0x87B380")]
	private void DetectObjects()
	{
	}

	[Token(Token = "0x600034D")]
	[Address(RVA = "0x87BB18", Offset = "0x87BB18", VA = "0x87BB18")]
	private void UpdateColors(float deltaTime)
	{
	}

	[Token(Token = "0x600034E")]
	[Address(RVA = "0x87BC3C", Offset = "0x87BC3C", VA = "0x87BC3C")]
	public float CalculateNodeSize(int i)
	{
		return default(float);
	}

	[Token(Token = "0x600034F")]
	[Address(RVA = "0x87B618", Offset = "0x87B618", VA = "0x87B618")]
	private void UpdateNodes(float deltaTime)
	{
	}

	[Token(Token = "0x6000350")]
	[Address(RVA = "0x87BFC0", Offset = "0x87BFC0", VA = "0x87BFC0")]
	public static Vector3 ClampAngle(Vector3 normal, Vector3 vector, float maxAngle)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000351")]
	[Address(RVA = "0x87C1B4", Offset = "0x87C1B4", VA = "0x87C1B4")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000356")]
	[Address(RVA = "0x87C30C", Offset = "0x87C30C", VA = "0x87C30C")]
	public FeatherBrush()
	{
	}
}
[Token(Token = "0x200008E")]
[RequireComponent(typeof(FeatherBrush))]
[ConfigurableComponent]
public class FeatherBrushPainter : Painter
{
	[Serializable]
	[Token(Token = "0x200008F")]
	private class Painter
	{
		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool renderFirstNode;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool renderframe;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		public bool notMove;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13")]
		public bool move;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public bool leave;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float leaveRaduisScale;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float leaveMoveScale;

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x87C9F0", Offset = "0x87C9F0", VA = "0x87C9F0")]
		public bool Paint(FeatherBrushPainter painter, Paper paper, FeatherBrush brush, Action<Paper, FeatherBrush> onPaint)
		{
			return default(bool);
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x87CD68", Offset = "0x87CD68", VA = "0x87CD68")]
		public static void DrawCircleMove(Vector3 start, Vector3 end, float r1, float r2, Vector3 normal)
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x87CFF8", Offset = "0x87CFF8", VA = "0x87CFF8")]
		public static void DrawCircleMove(Vector3 start, Vector3 end, Vector3 forward1, Vector3 right1, Vector3 forward2, Vector3 right2)
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x87D2F4", Offset = "0x87D2F4", VA = "0x87D2F4")]
		public static void DrawCircle(Vector3 start, Vector3 forward, Vector3 right)
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x87D40C", Offset = "0x87D40C", VA = "0x87D40C")]
		public Painter()
		{
		}
	}

	[Token(Token = "0x400022F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private Painter _Painter;

	[Token(Token = "0x4000230")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	private bool _CopyTexture;

	[Token(Token = "0x4000231")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[SerializeField]
	private RawImage _PreviewImage;

	[Token(Token = "0x4000232")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private FeatherBrush mBrush;

	[Token(Token = "0x4000233")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private Paper mCurrentPaper;

	[Token(Token = "0x4000234")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private bool mIsFirstNodePainted;

	[Token(Token = "0x170000AD")]
	public static string paintTypeName
	{
		[Token(Token = "0x6000358")]
		[Address(RVA = "0x87C348", Offset = "0x87C348", VA = "0x87C348")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000359")]
	[Address(RVA = "0x87C388", Offset = "0x87C388", VA = "0x87C388")]
	private static void SetAllPasses(Material material, Action<Material, int> update)
	{
	}

	[Token(Token = "0x600035A")]
	[Address(RVA = "0x87C404", Offset = "0x87C404", VA = "0x87C404", Slot = "8")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x600035B")]
	[Address(RVA = "0x87C5C8", Offset = "0x87C5C8", VA = "0x87C5C8")]
	private void Update()
	{
	}

	[Token(Token = "0x600035C")]
	[Address(RVA = "0x87C650", Offset = "0x87C650", VA = "0x87C650", Slot = "12")]
	public override void RenderTo(RenderTexture target, IBackgroundBlendLayer background)
	{
	}

	[Token(Token = "0x600035D")]
	[Address(RVA = "0x87C70C", Offset = "0x87C70C", VA = "0x87C70C")]
	private void InitCanvas(Paper paper, FeatherBrush brush)
	{
	}

	[Token(Token = "0x600035E")]
	[Address(RVA = "0x87C42C", Offset = "0x87C42C", VA = "0x87C42C")]
	private void CommitPainting()
	{
	}

	[Token(Token = "0x600035F")]
	[Address(RVA = "0x87C7FC", Offset = "0x87C7FC", VA = "0x87C7FC")]
	private void OnBrushPaint()
	{
	}

	[Token(Token = "0x6000360")]
	[Address(RVA = "0x87CD58", Offset = "0x87CD58", VA = "0x87CD58")]
	public FeatherBrushPainter()
	{
	}
}
[Token(Token = "0x2000091")]
[ConfigurableComponent]
[ExecuteAlways]
[RequireComponent(typeof(FeatherBrush), typeof(MeshRenderer))]
public class FeatherBrushRenderer : MonoBehaviour
{
	[Token(Token = "0x4000242")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float paperUpOffset;

	[Token(Token = "0x4000243")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[ConfigurableMember("verticlePerCircle")]
	public int verticlePerCircle;

	[Token(Token = "0x4000244")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[ConfigurableMember("nodeCount")]
	public int meshNodeCount;

	[Token(Token = "0x4000245")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float alphaMapMin;

	[Token(Token = "0x4000246")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float alphaMapMax;

	[Token(Token = "0x4000247")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private FeatherBrush mBrush;

	[Token(Token = "0x4000248")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private MeshRenderer mRenderer;

	[Token(Token = "0x4000249")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private MeshFilter mMeshFilter;

	[Token(Token = "0x400024A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int mLastNodeCount;

	[Token(Token = "0x400024B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private int mLastVerticlePerCircle;

	[Token(Token = "0x400024C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Mesh mMesh;

	[Token(Token = "0x400024D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Vector3[] mVerticls;

	[Token(Token = "0x400024E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Vector2[] mUVs;

	[Token(Token = "0x400024F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int[] mTriangles;

	[Token(Token = "0x170000AE")]
	private Material material
	{
		[Token(Token = "0x600036E")]
		[Address(RVA = "0x87E550", Offset = "0x87E550", VA = "0x87E550")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000368")]
	[Address(RVA = "0x87DA2C", Offset = "0x87DA2C", VA = "0x87DA2C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000369")]
	[Address(RVA = "0x87DB9C", Offset = "0x87DB9C", VA = "0x87DB9C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600036A")]
	[Address(RVA = "0x87DC44", Offset = "0x87DC44", VA = "0x87DC44")]
	private void Init()
	{
	}

	[Token(Token = "0x600036B")]
	[Address(RVA = "0x87E484", Offset = "0x87E484", VA = "0x87E484")]
	private void UpdateColor()
	{
	}

	[Token(Token = "0x600036C")]
	[Address(RVA = "0x87DC80", Offset = "0x87DC80", VA = "0x87DC80")]
	private void BuildMesh()
	{
	}

	[Token(Token = "0x600036D")]
	[Address(RVA = "0x87E590", Offset = "0x87E590", VA = "0x87E590")]
	private void OnWillRenderObject()
	{
	}

	[Token(Token = "0x600036F")]
	[Address(RVA = "0x87E62C", Offset = "0x87E62C", VA = "0x87E62C")]
	private void UpdateNodes()
	{
	}

	[Token(Token = "0x6000370")]
	[Address(RVA = "0x87EA58", Offset = "0x87EA58", VA = "0x87EA58")]
	private void SetVerticlsTranform(int meshNode, Vector3 position, Quaternion rotation, float raduis)
	{
	}

	[Token(Token = "0x6000371")]
	[Address(RVA = "0x87E594", Offset = "0x87E594", VA = "0x87E594")]
	private void UpdateMesh()
	{
	}

	[Token(Token = "0x6000372")]
	[Address(RVA = "0x87EBFC", Offset = "0x87EBFC", VA = "0x87EBFC")]
	public FeatherBrushRenderer()
	{
	}
}
[Token(Token = "0x2000092")]
public abstract class FeatherBrushInteractable : CollectableBehavior<FeatherBrushInteractable>
{
	[Token(Token = "0x4000250")]
	public const string LAYER_NAME = "BrushInteractable";

	[Token(Token = "0x4000251")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected List<FeatherBrush> mBrushes;

	[Token(Token = "0x170000AF")]
	public abstract Vector3 normal
	{
		[Token(Token = "0x6000374")]
		get;
	}

	[Token(Token = "0x170000B0")]
	public IReadOnlyList<FeatherBrush> brushes
	{
		[Token(Token = "0x6000375")]
		[Address(RVA = "0x87ECC0", Offset = "0x87ECC0", VA = "0x87ECC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000373")]
	[Address(RVA = "0x87EC24", Offset = "0x87EC24", VA = "0x87EC24", Slot = "4")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6000376")]
	[Address(RVA = "0x87ECC8", Offset = "0x87ECC8", VA = "0x87ECC8", Slot = "10")]
	public virtual void AttachBrush(FeatherBrush brush)
	{
	}

	[Token(Token = "0x6000377")]
	[Address(RVA = "0x87ED9C", Offset = "0x87ED9C", VA = "0x87ED9C", Slot = "11")]
	public virtual void DettachBrush(FeatherBrush brush)
	{
	}

	[Token(Token = "0x6000378")]
	[Address(RVA = "0x87EDF4", Offset = "0x87EDF4", VA = "0x87EDF4", Slot = "12")]
	public virtual void UpdateBrush(FeatherBrush brush, float deltaTime)
	{
	}

	[Token(Token = "0x6000379")]
	[Address(RVA = "0x87EDF8", Offset = "0x87EDF8", VA = "0x87EDF8")]
	protected FeatherBrushInteractable()
	{
	}
}
[Token(Token = "0x2000093")]
public class Paper : PaperObject
{
	[Serializable]
	[Token(Token = "0x2000094")]
	private class PaperCanvas : PaintingCanvas
	{
		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RenderTexture _RenderTextureDescriptor;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private RenderTexture _FinalRenderTexture;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Renderer[] _ApplyRenderers;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Vector2Int _Size;

		[Token(Token = "0x170000B9")]
		public override RenderTexture renderTexture
		{
			[Token(Token = "0x600038C")]
			[Address(RVA = "0x87F8F4", Offset = "0x87F8F4", VA = "0x87F8F4", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BA")]
		public Vector2Int size
		{
			[Token(Token = "0x600038D")]
			[Address(RVA = "0x87FA64", Offset = "0x87FA64", VA = "0x87FA64")]
			get
			{
				return default(Vector2Int);
			}
			[Token(Token = "0x600038E")]
			[Address(RVA = "0x87FA6C", Offset = "0x87FA6C", VA = "0x87FA6C")]
			set
			{
			}
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x87F90C", Offset = "0x87F90C", VA = "0x87F90C")]
		private void InitFinalRenderTexture()
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x87FA74", Offset = "0x87FA74", VA = "0x87FA74", Slot = "9")]
		public override void Dispose()
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x87FA94", Offset = "0x87FA94", VA = "0x87FA94")]
		public PaperCanvas()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000095")]
	public class HistoryManager : PaintingHistoryManager
	{
		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Hashtable mPaintTypeOverlowCounts;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Hashtable mPaintTypeUndoCounts;

		[Token(Token = "0x170000BB")]
		public IEnumerable<string> allPaintTypes
		{
			[Token(Token = "0x6000395")]
			[Address(RVA = "0x87FE94", Offset = "0x87FE94", VA = "0x87FE94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x87FAA8", Offset = "0x87FAA8", VA = "0x87FAA8", Slot = "16")]
		protected override void OnHistoryBuffersUpdated()
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x87FCA4", Offset = "0x87FCA4", VA = "0x87FCA4", Slot = "15")]
		protected override void OnOverflowHistoryMerged(HistoryBuffer history)
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x87FE4C", Offset = "0x87FE4C", VA = "0x87FE4C", Slot = "11")]
		public override void ClearContent()
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x8804E0", Offset = "0x8804E0", VA = "0x8804E0")]
		public int GetPaintTypeCount(string name)
		{
			return default(int);
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x8805CC", Offset = "0x8805CC", VA = "0x8805CC")]
		public HistoryManager()
		{
		}
	}

	[Token(Token = "0x2000096")]
	public class PaperTemplate
	{
		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Texture texture;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PaperTemplateType type;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public object tag;

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x880650", Offset = "0x880650", VA = "0x880650")]
		public PaperTemplate()
		{
		}
	}

	[Token(Token = "0x2000097")]
	public enum PaperTemplateType
	{
		[Token(Token = "0x4000265")]
		None,
		[Token(Token = "0x4000266")]
		Copybook,
		[Token(Token = "0x4000267")]
		MyWork,
		[Token(Token = "0x4000268")]
		UserTemplate
	}

	[Token(Token = "0x4000252")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private RenderTexture _RenderTextureDescriptor;

	[Token(Token = "0x4000253")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private MeshFilter _paperMesh;

	[Token(Token = "0x4000254")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[HideInInspector]
	[SerializeField]
	private bool _isPaperMeshFlat;

	[Token(Token = "0x4000255")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private string _LocalConfigFile;

	[Token(Token = "0x4000256")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private BackgroundBlendLayer _Background;

	[Token(Token = "0x4000257")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private PaperCanvas _Canvas;

	[Token(Token = "0x4000258")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private HistoryManager _HistoryManager;

	[Token(Token = "0x4000259")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private PaperTemplate mPaperTemplate;

	[Token(Token = "0x400025A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Texture2D _emptyTexture;

	[Token(Token = "0x170000B1")]
	public bool isPaperMeshFlat
	{
		[Token(Token = "0x600037B")]
		[Address(RVA = "0x87F23C", Offset = "0x87F23C", VA = "0x87F23C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000B2")]
	public RenderTexture finalRenderTexture
	{
		[Token(Token = "0x600037C")]
		[Address(RVA = "0x87F244", Offset = "0x87F244", VA = "0x87F244")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000B3")]
	public MeshFilter paperMesh
	{
		[Token(Token = "0x600037E")]
		[Address(RVA = "0x87F4F8", Offset = "0x87F4F8", VA = "0x87F4F8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000B4")]
	public Texture emptyTexure
	{
		[Token(Token = "0x600037F")]
		[Address(RVA = "0x87F500", Offset = "0x87F500", VA = "0x87F500")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000B5")]
	public Texture backgroundTexture
	{
		[Token(Token = "0x6000380")]
		[Address(RVA = "0x87F5E4", Offset = "0x87F5E4", VA = "0x87F5E4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000381")]
		[Address(RVA = "0x87F600", Offset = "0x87F600", VA = "0x87F600")]
		set
		{
		}
	}

	[Token(Token = "0x170000B6")]
	public PaperTemplate tempate
	{
		[Token(Token = "0x6000384")]
		[Address(RVA = "0x87F69C", Offset = "0x87F69C", VA = "0x87F69C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000385")]
		[Address(RVA = "0x87F6A4", Offset = "0x87F6A4", VA = "0x87F6A4")]
		set
		{
		}
	}

	[Token(Token = "0x170000B7")]
	public PaintingCanvas canvas
	{
		[Token(Token = "0x6000389")]
		[Address(RVA = "0x87F890", Offset = "0x87F890", VA = "0x87F890")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000B8")]
	public HistoryManager historyManager
	{
		[Token(Token = "0x600038A")]
		[Address(RVA = "0x87F898", Offset = "0x87F898", VA = "0x87F898")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600037A")]
	[Address(RVA = "0x87EEB4", Offset = "0x87EEB4", VA = "0x87EEB4")]
	public void CalculatePaperRect()
	{
	}

	[Token(Token = "0x600037D")]
	[Address(RVA = "0x87F264", Offset = "0x87F264", VA = "0x87F264")]
	private void LoadLocalConfigFile()
	{
	}

	[Token(Token = "0x6000382")]
	[Address(RVA = "0x87F61C", Offset = "0x87F61C", VA = "0x87F61C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000383")]
	[Address(RVA = "0x87F67C", Offset = "0x87F67C", VA = "0x87F67C")]
	public void ClearContent()
	{
	}

	[Token(Token = "0x6000386")]
	[Address(RVA = "0x87F6F0", Offset = "0x87F6F0", VA = "0x87F6F0")]
	public void LateUpdate()
	{
	}

	[Token(Token = "0x6000387")]
	[Address(RVA = "0x87F738", Offset = "0x87F738", VA = "0x87F738", Slot = "7")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6000388")]
	[Address(RVA = "0x87F7D0", Offset = "0x87F7D0", VA = "0x87F7D0")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x600038B")]
	[Address(RVA = "0x87F8A0", Offset = "0x87F8A0", VA = "0x87F8A0")]
	public Paper()
	{
	}
}
[Token(Token = "0x2000098")]
[RequireComponent(typeof(FeatherBrush))]
public class PaperHandler : MonoBehaviour
{
	[Token(Token = "0x4000269")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public VRHandInput.Button buttonClear;

	[Token(Token = "0x400026A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public VRHandInput.Button buttonUndo;

	[Token(Token = "0x400026B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public VRHandInput.Button buttonRedo;

	[Token(Token = "0x400026C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string defaultPaper;

	[Token(Token = "0x400026D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private FeatherBrush mBrush;

	[Token(Token = "0x400026E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private VRHandInput mHandInput;

	[Token(Token = "0x6000399")]
	[Address(RVA = "0x880658", Offset = "0x880658", VA = "0x880658")]
	private void Update()
	{
	}

	[Token(Token = "0x600039A")]
	[Address(RVA = "0x88065C", Offset = "0x88065C", VA = "0x88065C")]
	private void ProcessEvents()
	{
	}

	[Token(Token = "0x600039B")]
	[Address(RVA = "0x880B40", Offset = "0x880B40", VA = "0x880B40")]
	private void OnItemPicked()
	{
	}

	[Token(Token = "0x600039C")]
	[Address(RVA = "0x880BCC", Offset = "0x880BCC", VA = "0x880BCC")]
	private void OnItemDroped()
	{
	}

	[Token(Token = "0x600039D")]
	[Address(RVA = "0x88085C", Offset = "0x88085C", VA = "0x88085C")]
	private Paper GetTargetPaper()
	{
		return null;
	}

	[Token(Token = "0x600039E")]
	[Address(RVA = "0x880BD4", Offset = "0x880BD4", VA = "0x880BD4")]
	public PaperHandler()
	{
	}
}
[Token(Token = "0x2000099")]
public class PaperObject : FeatherBrushInteractable
{
	[Token(Token = "0x400026F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	protected Rect _paperRect;

	[Token(Token = "0x170000BC")]
	public Rect paperRect
	{
		[Token(Token = "0x600039F")]
		[Address(RVA = "0x880C38", Offset = "0x880C38", VA = "0x880C38")]
		get
		{
			return default(Rect);
		}
	}

	[Token(Token = "0x170000BD")]
	public override Vector3 normal
	{
		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x880C44", Offset = "0x880C44", VA = "0x880C44", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x60003A1")]
	[Address(RVA = "0x880C74", Offset = "0x880C74", VA = "0x880C74", Slot = "12")]
	public override void UpdateBrush(FeatherBrush brush, float deltaTime)
	{
	}

	[Token(Token = "0x60003A2")]
	[Address(RVA = "0x87F8AC", Offset = "0x87F8AC", VA = "0x87F8AC")]
	public PaperObject()
	{
	}
}
[Token(Token = "0x200009A")]
[RequireComponent(typeof(Paper))]
public class PaperPainter : MonoBehaviour
{
	[Token(Token = "0x4000270")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Material mat;

	[Token(Token = "0x4000271")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Material blit;

	[Token(Token = "0x4000272")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool renderFirstNode;

	[Token(Token = "0x4000273")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	public bool renderframe;

	[Token(Token = "0x4000274")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
	public bool notMove;

	[Token(Token = "0x4000275")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
	public bool move;

	[Token(Token = "0x4000276")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool leave;

	[Token(Token = "0x4000277")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float leaveRaduisScale;

	[Token(Token = "0x4000278")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float leaveMoveScale;

	[Token(Token = "0x4000279")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Paper mPaper;

	[Token(Token = "0x60003A3")]
	[Address(RVA = "0x881398", Offset = "0x881398", VA = "0x881398")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60003A4")]
	[Address(RVA = "0x8813E8", Offset = "0x8813E8", VA = "0x8813E8")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60003A5")]
	[Address(RVA = "0x881BD0", Offset = "0x881BD0", VA = "0x881BD0")]
	private static void SetAllPasses(Material material, Action<Material, int> update)
	{
	}

	[Token(Token = "0x60003A6")]
	[Address(RVA = "0x881704", Offset = "0x881704", VA = "0x881704")]
	public void PaintTo(FeatherBrush brush, Paper paper)
	{
	}

	[Token(Token = "0x60003A7")]
	[Address(RVA = "0x881C54", Offset = "0x881C54", VA = "0x881C54")]
	public static void DrawCircleMove(Vector3 start, Vector3 end, float r1, float r2, Vector3 normal)
	{
	}

	[Token(Token = "0x60003A8")]
	[Address(RVA = "0x881EE4", Offset = "0x881EE4", VA = "0x881EE4")]
	public static void DrawCircleMove(Vector3 start, Vector3 end, Vector3 forward1, Vector3 right1, Vector3 forward2, Vector3 right2)
	{
	}

	[Token(Token = "0x60003A9")]
	[Address(RVA = "0x8821E0", Offset = "0x8821E0", VA = "0x8821E0")]
	public static void DrawCircle(Vector3 start, Vector3 forward, Vector3 right)
	{
	}

	[Token(Token = "0x60003AA")]
	[Address(RVA = "0x8822F8", Offset = "0x8822F8", VA = "0x8822F8")]
	public PaperPainter()
	{
	}
}
[Token(Token = "0x200009C")]
public class SavedPaintings : MonoBehaviour
{
	[Token(Token = "0x200009D")]
	public class Painting
	{
		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool loadFromFile;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Texture tex;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DateTime time;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string path;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Coroutine loading;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool loadingError;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public readonly SavedPaintings owner;

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x8831C0", Offset = "0x8831C0", VA = "0x8831C0")]
		public Painting(SavedPaintings o)
		{
		}
	}

	[Token(Token = "0x200009E")]
	public enum ChangeType
	{
		[Token(Token = "0x400028E")]
		Added,
		[Token(Token = "0x400028F")]
		Deleted,
		[Token(Token = "0x4000290")]
		RangeAdded,
		[Token(Token = "0x4000291")]
		Updated
	}

	[Token(Token = "0x200009F")]
	public delegate void OnPaintingsChangedDelegate(int index, ChangeType type);

	[Token(Token = "0x400027E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OnPaintingsChangedDelegate OnPaintingsChanged;

	[Token(Token = "0x4000280")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private List<Painting> mPaintings;

	[Token(Token = "0x4000281")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int mMaxLoadCount;

	[Token(Token = "0x4000282")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private int mMinViewIndex;

	[Token(Token = "0x4000283")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int mMaxViewIndex;

	[Token(Token = "0x4000284")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private FileUtils.MediaType mMediaType;

	[Token(Token = "0x4000285")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Dictionary<FileUtils.MediaType, SavedPaintings> mInstances;

	[Token(Token = "0x170000BE")]
	public bool loadedImages
	{
		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x882880", Offset = "0x882880", VA = "0x882880")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x882888", Offset = "0x882888", VA = "0x882888")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170000BF")]
	public int count
	{
		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x883CF0", Offset = "0x883CF0", VA = "0x883CF0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170000C0")]
	public FileUtils.MediaType MediaType
	{
		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x883D38", Offset = "0x883D38", VA = "0x883D38")]
		get
		{
			return default(FileUtils.MediaType);
		}
	}

	[Token(Token = "0x60003AF")]
	[Address(RVA = "0x882894", Offset = "0x882894", VA = "0x882894")]
	public static SavedPaintings Get(FileUtils.MediaType media)
	{
		return null;
	}

	[Token(Token = "0x60003B0")]
	[Address(RVA = "0x882A60", Offset = "0x882A60", VA = "0x882A60")]
	public void Add(Painting painting)
	{
	}

	[Token(Token = "0x60003B1")]
	[Address(RVA = "0x882BC0", Offset = "0x882BC0", VA = "0x882BC0")]
	private void Add(List<Painting> paintings)
	{
	}

	[Token(Token = "0x60003B2")]
	[Address(RVA = "0x882C6C", Offset = "0x882C6C", VA = "0x882C6C")]
	public void LoadImages()
	{
	}

	[Token(Token = "0x60003B3")]
	[Address(RVA = "0x8831E8", Offset = "0x8831E8", VA = "0x8831E8")]
	public void UpdatePainting(Painting painting)
	{
	}

	[Token(Token = "0x60003B4")]
	[Address(RVA = "0x883270", Offset = "0x883270", VA = "0x883270")]
	public void SetViewingRange(int minIndex, int maxIndex)
	{
	}

	[Token(Token = "0x60003B5")]
	[Address(RVA = "0x883278", Offset = "0x883278", VA = "0x883278")]
	public void Load(Painting painting, bool reload = false)
	{
	}

	[Token(Token = "0x60003B6")]
	[Address(RVA = "0x883450", Offset = "0x883450", VA = "0x883450")]
	public void Recycle()
	{
	}

	[Token(Token = "0x60003B7")]
	[Address(RVA = "0x8837A8", Offset = "0x8837A8", VA = "0x8837A8")]
	public void RemoveAt(int index)
	{
	}

	[Token(Token = "0x60003B8")]
	[Address(RVA = "0x883A10", Offset = "0x883A10", VA = "0x883A10")]
	public void Remove(Painting painting)
	{
	}

	[Token(Token = "0x60003B9")]
	[Address(RVA = "0x883A84", Offset = "0x883A84", VA = "0x883A84")]
	protected void OnDestroy()
	{
	}

	[Token(Token = "0x60003BA")]
	[Address(RVA = "0x883C98", Offset = "0x883C98", VA = "0x883C98")]
	public Painting Get(int index)
	{
		return null;
	}

	[Token(Token = "0x60003BD")]
	[Address(RVA = "0x883D40", Offset = "0x883D40", VA = "0x883D40")]
	public SavedPaintings()
	{
	}
}
[Token(Token = "0x20000A1")]
public class Seal : MonoBehaviour
{
	[Token(Token = "0x4000295")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float _width;

	[Token(Token = "0x4000296")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float _height;

	[Token(Token = "0x4000297")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Material _material;

	[Token(Token = "0x4000298")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Material _PaitingMaterial;

	[Token(Token = "0x4000299")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Material _LayerMergeMaterial;

	[Token(Token = "0x400029A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Texture _texture;

	[Token(Token = "0x400029B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private float cosAnle;

	[Token(Token = "0x400029C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private AudioClip audioClip;

	[Token(Token = "0x400029D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private float _VibrationDuration;

	[Token(Token = "0x400029E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[SerializeField]
	private float _VibrationAmplitude;

	[Token(Token = "0x400029F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private MeshFilter mMeshFilter;

	[Token(Token = "0x40002A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private MeshRenderer mMeshRenderer;

	[Token(Token = "0x40002A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Paper mLastPaper;

	[Token(Token = "0x40002A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Vector3 mLastPosition;

	[Token(Token = "0x40002A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private bool mDirty;

	[Token(Token = "0x40002A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Material mCopiedPaintingMaterial;

	[Token(Token = "0x40002A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private string mTextureTag;

	[Token(Token = "0x40002A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static string sSavedTextureTag;

	[Token(Token = "0x40002A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Texture sSavedTexture;

	[Token(Token = "0x170000C1")]
	public Texture texture
	{
		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x8842D4", Offset = "0x8842D4", VA = "0x8842D4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000C2")]
	public string textureTag
	{
		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x8842DC", Offset = "0x8842DC", VA = "0x8842DC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000C3")]
	public static string paintTypeName
	{
		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x885350", Offset = "0x885350", VA = "0x885350")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60003C6")]
	[Address(RVA = "0x884164", Offset = "0x884164", VA = "0x884164")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003C7")]
	[Address(RVA = "0x884208", Offset = "0x884208", VA = "0x884208")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60003C8")]
	[Address(RVA = "0x884264", Offset = "0x884264", VA = "0x884264")]
	public void SetTexture(Texture texture, [Optional] string textureTag)
	{
	}

	[Token(Token = "0x60003CB")]
	[Address(RVA = "0x8842E4", Offset = "0x8842E4", VA = "0x8842E4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60003CC")]
	[Address(RVA = "0x8842E8", Offset = "0x8842E8", VA = "0x8842E8")]
	public void ReInit()
	{
	}

	[Token(Token = "0x60003CD")]
	[Address(RVA = "0x8844A8", Offset = "0x8844A8", VA = "0x8844A8")]
	private void CalculateMesh()
	{
	}

	[Token(Token = "0x60003CE")]
	[Address(RVA = "0x884708", Offset = "0x884708", VA = "0x884708")]
	private void Update()
	{
	}

	[Token(Token = "0x60003D0")]
	[Address(RVA = "0x884CA0", Offset = "0x884CA0", VA = "0x884CA0")]
	private void Paint(Paper paper)
	{
	}

	[Token(Token = "0x60003D1")]
	[Address(RVA = "0x885390", Offset = "0x885390", VA = "0x885390")]
	public Seal()
	{
	}
}
[Token(Token = "0x20000A2")]
[SingletonOption(autoCreate = true)]
public class PaintingSaver : SingletonGameObject<PaintingSaver>
{
	[Token(Token = "0x40002A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Image mImage;

	[Token(Token = "0x40002A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Mesh mMesh;

	[Token(Token = "0x40002AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Material mMaterial;

	[Token(Token = "0x60003D2")]
	[Address(RVA = "0x8853C8", Offset = "0x8853C8", VA = "0x8853C8", Slot = "5")]
	protected override void OnAwake()
	{
	}

	[Token(Token = "0x60003D3")]
	[Address(RVA = "0x8854F0", Offset = "0x8854F0", VA = "0x8854F0", Slot = "7")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x60003D4")]
	[Address(RVA = "0x885578", Offset = "0x885578", VA = "0x885578")]
	public void Save(PhotoFrameListData.Data photoFrame, Paper paper, SavedPaintings.Painting replacePainting, FileUtils.MediaType mediaType)
	{
	}

	[Token(Token = "0x60003D5")]
	[Address(RVA = "0x885660", Offset = "0x885660", VA = "0x885660")]
	public static Texture2D RenderTextureTo2d(RenderTexture rt)
	{
		return null;
	}

	[Token(Token = "0x60003D6")]
	[Address(RVA = "0x885694", Offset = "0x885694", VA = "0x885694")]
	private Texture2D RenderTextureTo2dForSave(RenderTexture rt, PhotoFrameListData.Data photoFrame)
	{
		return null;
	}

	[Token(Token = "0x60003D7")]
	[Address(RVA = "0x886314", Offset = "0x886314", VA = "0x886314")]
	public PaintingSaver()
	{
	}
}
[Token(Token = "0x20000A5")]
[ConfigurableComponent]
public class PanoramaBallConfig : MonoBehaviour
{
	[Token(Token = "0x40002B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool autoPlayMovie;

	[Token(Token = "0x170000C4")]
	[ConfigurableMember("x")]
	public float positionX
	{
		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x886B90", Offset = "0x886B90", VA = "0x886B90")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x886BB0", Offset = "0x886BB0", VA = "0x886BB0")]
		set
		{
		}
	}

	[Token(Token = "0x170000C5")]
	[ConfigurableMember("y")]
	public float positionY
	{
		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x886C14", Offset = "0x886C14", VA = "0x886C14")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x886C3C", Offset = "0x886C3C", VA = "0x886C3C")]
		set
		{
		}
	}

	[Token(Token = "0x170000C6")]
	[ConfigurableMember("z")]
	public float positionZ
	{
		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x886CA0", Offset = "0x886CA0", VA = "0x886CA0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x886CC8", Offset = "0x886CC8", VA = "0x886CC8")]
		set
		{
		}
	}

	[Token(Token = "0x170000C7")]
	[ConfigurableMember("scaleX")]
	public float scaleX
	{
		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x886D2C", Offset = "0x886D2C", VA = "0x886D2C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x886D4C", Offset = "0x886D4C", VA = "0x886D4C")]
		set
		{
		}
	}

	[Token(Token = "0x170000C8")]
	[ConfigurableMember("scaleY")]
	public float scaleY
	{
		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x886DB0", Offset = "0x886DB0", VA = "0x886DB0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x886DD8", Offset = "0x886DD8", VA = "0x886DD8")]
		set
		{
		}
	}

	[Token(Token = "0x170000C9")]
	[ConfigurableMember("scaleZ")]
	public float scaleZ
	{
		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x886E3C", Offset = "0x886E3C", VA = "0x886E3C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x886E64", Offset = "0x886E64", VA = "0x886E64")]
		set
		{
		}
	}

	[Token(Token = "0x60003DD")]
	[Address(RVA = "0x886B8C", Offset = "0x886B8C", VA = "0x886B8C")]
	private void Start()
	{
	}

	[Token(Token = "0x60003EA")]
	[Address(RVA = "0x886EC8", Offset = "0x886EC8", VA = "0x886EC8")]
	public PanoramaBallConfig()
	{
	}
}
[Token(Token = "0x20000A6")]
[RequireComponent(typeof(PickAndDropItemPosition))]
public class PickAndDropHighlighter : MonoBehaviour
{
	[Token(Token = "0x20000A7")]
	private class HighlightObject
	{
		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public UnityEngine.Object originalObject;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject highlightObject;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject depthOnlyObject;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool needDestroy;

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x887160", Offset = "0x887160", VA = "0x887160")]
		public void Destroy()
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x8874F8", Offset = "0x8874F8", VA = "0x8874F8")]
		public HighlightObject()
		{
		}
	}

	[Token(Token = "0x40002B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Color _HighlightColor;

	[Token(Token = "0x40002B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Material _DepthOnlyMaterial;

	[Token(Token = "0x40002B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Material _HighlightMaterial;

	[Token(Token = "0x40002B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float _Smooth;

	[Token(Token = "0x40002B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private Color mCurrentColor;

	[Token(Token = "0x40002B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Material mHighlightMat;

	[Token(Token = "0x40002B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private PickAndDropItemPosition mPickAndDropPosition;

	[Token(Token = "0x40002BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private List<HighlightObject> mHighlightingObjects;

	[Token(Token = "0x60003EB")]
	[Address(RVA = "0x886ED8", Offset = "0x886ED8", VA = "0x886ED8")]
	private void Start()
	{
	}

	[Token(Token = "0x60003EC")]
	[Address(RVA = "0x886F7C", Offset = "0x886F7C", VA = "0x886F7C")]
	private void Update()
	{
	}

	[Token(Token = "0x60003ED")]
	[Address(RVA = "0x8871C8", Offset = "0x8871C8", VA = "0x8871C8")]
	public void HightlightDrop(PickAndDropItem itemInHand)
	{
	}

	[Token(Token = "0x60003EE")]
	[Address(RVA = "0x887500", Offset = "0x887500", VA = "0x887500")]
	private static GameObject CreateHighlightGameObject(PickAndDropItem item, Material material, Transform parent)
	{
		return null;
	}

	[Token(Token = "0x60003EF")]
	[Address(RVA = "0x887BF4", Offset = "0x887BF4", VA = "0x887BF4")]
	private void OnItemPicked(PickAndDropItem item)
	{
	}

	[Token(Token = "0x60003F0")]
	[Address(RVA = "0x887BF8", Offset = "0x887BF8", VA = "0x887BF8")]
	private void OnItemDroped(PickAndDropItem item)
	{
	}

	[Token(Token = "0x60003F1")]
	[Address(RVA = "0x887BFC", Offset = "0x887BFC", VA = "0x887BFC")]
	private void OnHoverEnter(InteractableHandler handler)
	{
	}

	[Token(Token = "0x60003F2")]
	[Address(RVA = "0x887CF0", Offset = "0x887CF0", VA = "0x887CF0")]
	private void OnHoverExit(InteractableHandler handler)
	{
	}

	[Token(Token = "0x60003F3")]
	[Address(RVA = "0x887340", Offset = "0x887340", VA = "0x887340")]
	public bool HighlightDropOff([Optional] PickAndDropItem newItem)
	{
		return default(bool);
	}

	[Token(Token = "0x60003F4")]
	[Address(RVA = "0x887AD4", Offset = "0x887AD4", VA = "0x887AD4")]
	private static Vector3 Scale(Transform parent, Transform child)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60003F5")]
	[Address(RVA = "0x887CF8", Offset = "0x887CF8", VA = "0x887CF8")]
	private static Vector3 VectorMul(Vector3 v1, Vector3 v2)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60003F6")]
	[Address(RVA = "0x887D08", Offset = "0x887D08", VA = "0x887D08")]
	public PickAndDropHighlighter()
	{
	}
}
[Token(Token = "0x20000A8")]
public class PickAndDropItem : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20000A9")]
	public struct Pose
	{
		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 position;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Vector3 rotation;
	}

	[Token(Token = "0x40002BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 pickedPosition;

	[Token(Token = "0x40002C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Vector3 pickedEuler;

	[Token(Token = "0x40002C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector3 dropedPosition;

	[Token(Token = "0x40002C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public Vector3 dropedEuler;

	[Token(Token = "0x40002C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool localPositionAsDropPosition;

	[Token(Token = "0x40002C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public string itemTag;

	[Token(Token = "0x40002C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool realPosition;

	[Token(Token = "0x40002C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public string animationTrigger;

	[Token(Token = "0x40002C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public string targetHandObject;

	[Token(Token = "0x40002C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public string applyHandPosition;

	[NonSerialized]
	[Token(Token = "0x40002C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public PickAndDropItemPosition fromPosition;

	[Token(Token = "0x60003F9")]
	[Address(RVA = "0x887D98", Offset = "0x887D98", VA = "0x887D98")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003FA")]
	[Address(RVA = "0x887DF0", Offset = "0x887DF0", VA = "0x887DF0")]
	public PickAndDropItem()
	{
	}
}
[Token(Token = "0x20000AA")]
[RequireComponent(typeof(AudioSource))]
public class PickAndDropItemPosition : InteractableVRObject
{
	[Token(Token = "0x40002CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private AudioClip _SoundPick;

	[Token(Token = "0x40002CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private AudioClip _SoundDrop;

	[Token(Token = "0x40002CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private string _ItemTag;

	[Token(Token = "0x40002CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public string handlerTag;

	[Token(Token = "0x40002D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private PickAndDropItem mItem;

	[Token(Token = "0x40002D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private AudioSource mAudio;

	[Token(Token = "0x170000CA")]
	public PickAndDropItem item
	{
		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x887DF8", Offset = "0x887DF8", VA = "0x887DF8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60003FC")]
	[Address(RVA = "0x887E00", Offset = "0x887E00", VA = "0x887E00", Slot = "17")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60003FD")]
	[Address(RVA = "0x887E88", Offset = "0x887E88", VA = "0x887E88", Slot = "11")]
	public override bool BeforEnter(InteractableHandler handler)
	{
		return default(bool);
	}

	[Token(Token = "0x60003FE")]
	[Address(RVA = "0x88806C", Offset = "0x88806C", VA = "0x88806C", Slot = "21")]
	protected virtual void DoPickAndDrop(InteractableHandler handler)
	{
	}

	[Token(Token = "0x60003FF")]
	[Address(RVA = "0x888270", Offset = "0x888270", VA = "0x888270", Slot = "22")]
	protected virtual void PickItem(InteractableHandler handler)
	{
	}

	[Token(Token = "0x6000400")]
	[Address(RVA = "0x888530", Offset = "0x888530", VA = "0x888530", Slot = "23")]
	protected virtual void DropItem(PickAndDropItem item, InteractableHandler handler)
	{
	}

	[Token(Token = "0x6000401")]
	[Address(RVA = "0x888770", Offset = "0x888770", VA = "0x888770", Slot = "12")]
	public override void OnEnter(InteractableHandler handler)
	{
	}

	[Token(Token = "0x6000402")]
	[Address(RVA = "0x8887E8", Offset = "0x8887E8", VA = "0x8887E8", Slot = "13")]
	public override void OnExit(InteractableHandler handler)
	{
	}

	[Token(Token = "0x6000403")]
	[Address(RVA = "0x888860", Offset = "0x888860", VA = "0x888860", Slot = "20")]
	protected override void OnProcessEvents(VRHandInput vrInput)
	{
	}

	[Token(Token = "0x6000404")]
	[Address(RVA = "0x8888AC", Offset = "0x8888AC", VA = "0x8888AC")]
	public PickAndDropItemPosition()
	{
	}
}
[Token(Token = "0x20000AB")]
public class BrushRecorder : MonoBehaviour
{
	[Token(Token = "0x20000AC")]
	private class PlayingObjects
	{
		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject hand;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform handBrushPosition;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject childBrush;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IEnumerator coroutine;

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x889170", Offset = "0x889170", VA = "0x889170")]
		public PlayingObjects()
		{
		}
	}

	[Token(Token = "0x20000AD")]
	private struct RecordingFile
	{
		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private string mOpenPath;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private string mSavePath;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool mIsAsset;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string mCopybook;

		[Token(Token = "0x170000D3")]
		public bool isExists
		{
			[Token(Token = "0x600041E")]
			[Address(RVA = "0x888F18", Offset = "0x888F18", VA = "0x888F18")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000D4")]
		public string copybook
		{
			[Token(Token = "0x600041F")]
			[Address(RVA = "0x889268", Offset = "0x889268", VA = "0x889268")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D5")]
		public bool isAsset
		{
			[Token(Token = "0x6000420")]
			[Address(RVA = "0x889270", Offset = "0x889270", VA = "0x889270")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000D6")]
		public string openUrl
		{
			[Token(Token = "0x6000421")]
			[Address(RVA = "0x889030", Offset = "0x889030", VA = "0x889030")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D7")]
		public string savePath
		{
			[Token(Token = "0x6000422")]
			[Address(RVA = "0x889278", Offset = "0x889278", VA = "0x889278")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x888AD8", Offset = "0x888AD8", VA = "0x888AD8")]
		public void MatchCopybookAssetPath(string assetPath)
		{
		}
	}

	[Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private sealed class <Recording>d__43 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject obj;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public BrushRecorder <>4__this;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string filePath;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <dely>5__2;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform <childBrush>5__3;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float <startTime>5__4;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int <length>5__5;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Stream <sf>5__6;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BinaryWriter <bw>5__7;

		[Token(Token = "0x170000D8")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600042A")]
			[Address(RVA = "0x88A204", Offset = "0x88A204", VA = "0x88A204", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D9")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600042C")]
			[Address(RVA = "0x88A24C", Offset = "0x88A24C", VA = "0x88A24C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x8891EC", Offset = "0x8891EC", VA = "0x8891EC")]
		[DebuggerHidden]
		public <Recording>d__43(int <>1__state)
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x889378", Offset = "0x889378", VA = "0x889378", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x8893A4", Offset = "0x8893A4", VA = "0x8893A4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x88A154", Offset = "0x88A154", VA = "0x88A154")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x88A20C", Offset = "0x88A20C", VA = "0x88A20C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private sealed class <>c__DisplayClass44_0
	{
		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public byte[] data;

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x88A254", Offset = "0x88A254", VA = "0x88A254")]
		public <>c__DisplayClass44_0()
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x88A25C", Offset = "0x88A25C", VA = "0x88A25C")]
		internal void <Play>b__0(UnityWebRequest request)
		{
		}
	}

	[Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private sealed class <Play>d__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BrushRecorder <>4__this;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string filePath;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private <>c__DisplayClass44_0 <>8__1;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Stream <sf>5__2;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private BinaryReader <br0>5__3;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float <ver>5__4;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int <length>5__5;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BinaryReader <br>5__6;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 <preFramePos>5__7;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private Quaternion <preFrameRot>5__8;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float <preFrameTime>5__9;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float <curTime>5__10;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int <i>5__11;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float <nextFrameTime>5__12;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 <nextFramePos>5__13;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion <nextFrameRot>5__14;

		[Token(Token = "0x170000DA")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000435")]
			[Address(RVA = "0x88B33C", Offset = "0x88B33C", VA = "0x88B33C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DB")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000437")]
			[Address(RVA = "0x88B384", Offset = "0x88B384", VA = "0x88B384", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x889214", Offset = "0x889214", VA = "0x889214")]
		[DebuggerHidden]
		public <Play>d__44(int <>1__state)
		{
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x88A340", Offset = "0x88A340", VA = "0x88A340", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x88A36C", Offset = "0x88A36C", VA = "0x88A36C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x88B28C", Offset = "0x88B28C", VA = "0x88B28C")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x88B344", Offset = "0x88B344", VA = "0x88B344", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40002D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Range(1f, 60f)]
	public float sample;

	[Token(Token = "0x40002D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool usingUpdateTime;

	[Token(Token = "0x40002D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Paper paper;

	[Token(Token = "0x40002D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool allowRecord;

	[Token(Token = "0x40002D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	public bool playPainting;

	[Token(Token = "0x40002D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public readonly float vertion;

	[Token(Token = "0x40002D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject handPrefab;

	[Token(Token = "0x40002D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float zRotationOffset;

	[Token(Token = "0x40002DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float timeScale;

	[Token(Token = "0x40002DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool mRecording;

	[Token(Token = "0x40002DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	private bool mPlaying;

	[Token(Token = "0x40002DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
	private bool mPaused;

	[Token(Token = "0x40002DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private PlayingObjects mPlayingObject;

	[Token(Token = "0x40002DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private RecordingFile mRecordingFile;

	[Token(Token = "0x40002E0")]
	private const int HeaderLength = 28;

	[Token(Token = "0x170000CB")]
	private static string externalDirector
	{
		[Token(Token = "0x6000405")]
		[Address(RVA = "0x8888B4", Offset = "0x8888B4", VA = "0x8888B4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000CC")]
	public bool isPlayingOrRecording
	{
		[Token(Token = "0x600040E")]
		[Address(RVA = "0x888E94", Offset = "0x888E94", VA = "0x888E94")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000CD")]
	public bool isPlaying
	{
		[Token(Token = "0x600040F")]
		[Address(RVA = "0x888ECC", Offset = "0x888ECC", VA = "0x888ECC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000CE")]
	public bool isRecording
	{
		[Token(Token = "0x6000410")]
		[Address(RVA = "0x888ED4", Offset = "0x888ED4", VA = "0x888ED4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000CF")]
	public bool canPlay
	{
		[Token(Token = "0x6000411")]
		[Address(RVA = "0x888EDC", Offset = "0x888EDC", VA = "0x888EDC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000D0")]
	public bool canRecord
	{
		[Token(Token = "0x6000412")]
		[Address(RVA = "0x888F3C", Offset = "0x888F3C", VA = "0x888F3C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000D1")]
	public bool isPaused
	{
		[Token(Token = "0x6000413")]
		[Address(RVA = "0x888F64", Offset = "0x888F64", VA = "0x888F64")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000D2")]
	public string recordingFileUrl
	{
		[Token(Token = "0x6000416")]
		[Address(RVA = "0x889028", Offset = "0x889028", VA = "0x889028")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000406")]
	[Address(RVA = "0x888930", Offset = "0x888930", VA = "0x888930")]
	public void Awake()
	{
	}

	[Token(Token = "0x6000407")]
	[Address(RVA = "0x8889B4", Offset = "0x8889B4", VA = "0x8889B4")]
	public bool OnMessage(GameMessageType msgType, int what, params object[] args)
	{
		return default(bool);
	}

	[Token(Token = "0x6000408")]
	[Address(RVA = "0x888A6C", Offset = "0x888A6C", VA = "0x888A6C")]
	public void SetTemplate(string name)
	{
	}

	[Token(Token = "0x6000409")]
	[Address(RVA = "0x888BC8", Offset = "0x888BC8", VA = "0x888BC8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600040A")]
	[Address(RVA = "0x8809AC", Offset = "0x8809AC", VA = "0x8809AC")]
	public void Record([Optional] GameObject obj)
	{
	}

	[Token(Token = "0x600040B")]
	[Address(RVA = "0x888E78", Offset = "0x888E78", VA = "0x888E78")]
	public void Pause()
	{
	}

	[Token(Token = "0x600040C")]
	[Address(RVA = "0x888EB4", Offset = "0x888EB4", VA = "0x888EB4")]
	public void Resume()
	{
	}

	[Token(Token = "0x600040D")]
	[Address(RVA = "0x888CC8", Offset = "0x888CC8", VA = "0x888CC8")]
	private GameObject findHoldingBrush()
	{
		return null;
	}

	[Token(Token = "0x6000414")]
	[Address(RVA = "0x880B0C", Offset = "0x880B0C", VA = "0x880B0C")]
	public void Stop()
	{
	}

	[Token(Token = "0x6000415")]
	[Address(RVA = "0x888F8C", Offset = "0x888F8C", VA = "0x888F8C")]
	private void DestoryPlayingObjects()
	{
	}

	[Token(Token = "0x6000417")]
	[Address(RVA = "0x888ABC", Offset = "0x888ABC", VA = "0x888ABC")]
	public void Clear()
	{
	}

	[Token(Token = "0x6000418")]
	[Address(RVA = "0x889094", Offset = "0x889094", VA = "0x889094")]
	public void Play()
	{
	}

	[Token(Token = "0x6000419")]
	[Address(RVA = "0x888C4C", Offset = "0x888C4C", VA = "0x888C4C")]
	[IteratorStateMachine(typeof(<Recording>d__43))]
	private IEnumerator Recording(GameObject obj, string filePath)
	{
		return null;
	}

	[Token(Token = "0x600041A")]
	[Address(RVA = "0x889178", Offset = "0x889178", VA = "0x889178")]
	[IteratorStateMachine(typeof(<Play>d__44))]
	private IEnumerator Play(string filePath)
	{
		return null;
	}

	[Token(Token = "0x600041B")]
	[Address(RVA = "0x88923C", Offset = "0x88923C", VA = "0x88923C")]
	public BrushRecorder()
	{
	}
}
[Token(Token = "0x20000B3")]
public class BrushRecorderId : MonoBehaviour
{
	[Token(Token = "0x400030A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	[SerializeField]
	private int _id;

	[Token(Token = "0x170000DC")]
	public int id
	{
		[Token(Token = "0x6000439")]
		[Address(RVA = "0x88A0F0", Offset = "0x88A0F0", VA = "0x88A0F0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6000438")]
	[Address(RVA = "0x88B38C", Offset = "0x88B38C", VA = "0x88B38C")]
	private void Reset()
	{
	}

	[Token(Token = "0x600043A")]
	[Address(RVA = "0x88B410", Offset = "0x88B410", VA = "0x88B410")]
	public static bool HasId(int id, BrushRecorderId[] brushRecorderIds)
	{
		return default(bool);
	}

	[Token(Token = "0x600043B")]
	[Address(RVA = "0x88B3A4", Offset = "0x88B3A4", VA = "0x88B3A4")]
	public static int GetNewId()
	{
		return default(int);
	}

	[Token(Token = "0x600043C")]
	[Address(RVA = "0x88B464", Offset = "0x88B464", VA = "0x88B464")]
	public BrushRecorderId()
	{
	}
}
[Token(Token = "0x20000B4")]
[SingletonOption(resource = "Prefabs/RuntimeTestDialog")]
public class RuntimeTestDialog : SingletonGameObject<RuntimeTestDialog>
{
	[Token(Token = "0x400030B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float _ShowDistance;

	[Token(Token = "0x400030C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject mTemplate;

	[Token(Token = "0x600043D")]
	[Address(RVA = "0x88B474", Offset = "0x88B474", VA = "0x88B474", Slot = "5")]
	protected override void OnAwake()
	{
	}

	[Token(Token = "0x600043E")]
	[Address(RVA = "0x88C674", Offset = "0x88C674", VA = "0x88C674")]
	private static void ViewTexture(Texture2D texture, bool autoDestroyTexture)
	{
	}

	[Token(Token = "0x600043F")]
	[Address(RVA = "0x88C320", Offset = "0x88C320", VA = "0x88C320")]
	public void UpdatePosition()
	{
	}

	[Token(Token = "0x6000440")]
	[Address(RVA = "0x88BEBC", Offset = "0x88BEBC", VA = "0x88BEBC")]
	private void CreateTest(string name, Action action)
	{
	}

	[Token(Token = "0x6000441")]
	[Address(RVA = "0x88C0AC", Offset = "0x88C0AC", VA = "0x88C0AC")]
	private void CreateToggle(string name, bool isOn, string onText, string offText, Func<bool, bool> action)
	{
	}

	[Token(Token = "0x6000442")]
	private void CreateToggle<Key>(string name, Key currentKey, IDictionary<Key, string> options, Func<Key, string, Key> action)
	{
	}

	[Token(Token = "0x6000443")]
	[Address(RVA = "0x88C890", Offset = "0x88C890", VA = "0x88C890")]
	public RuntimeTestDialog()
	{
	}
}
[Token(Token = "0x20000BA")]
public static class RuntimeTestSettings
{
	[Token(Token = "0x20000BB")]
	public enum FestivalMode
	{
		[Token(Token = "0x4000327")]
		None,
		[Token(Token = "0x4000328")]
		ForceNormal,
		[Token(Token = "0x4000329")]
		ForceMidAutumnFestival
	}

	[Token(Token = "0x170000DD")]
	public static bool showAchievementDetail
	{
		[Token(Token = "0x6000459")]
		[Address(RVA = "0x88D6E0", Offset = "0x88D6E0", VA = "0x88D6E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600045A")]
		[Address(RVA = "0x88D728", Offset = "0x88D728", VA = "0x88D728")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170000DE")]
	public static FestivalMode forceFestivalMode
	{
		[Token(Token = "0x600045B")]
		[Address(RVA = "0x88D774", Offset = "0x88D774", VA = "0x88D774")]
		[CompilerGenerated]
		get
		{
			return default(FestivalMode);
		}
		[Token(Token = "0x600045C")]
		[Address(RVA = "0x88D7BC", Offset = "0x88D7BC", VA = "0x88D7BC")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170000DF")]
	public static bool noLimitOfChangeChallengLevel
	{
		[Token(Token = "0x600045D")]
		[Address(RVA = "0x88D808", Offset = "0x88D808", VA = "0x88D808")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600045E")]
		[Address(RVA = "0x88D850", Offset = "0x88D850", VA = "0x88D850")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Token(Token = "0x20000BC")]
public class Settings : MonoBehaviour
{
	[Token(Token = "0x400032A")]
	public const string Is_Entered_Tutorial = "IsEnteredTutorial";

	[Token(Token = "0x600045F")]
	[Address(RVA = "0x88D89C", Offset = "0x88D89C", VA = "0x88D89C")]
	public Settings()
	{
	}
}
[Token(Token = "0x20000BD")]
[ExecuteAlways]
public class SimpleURPProjector : MonoBehaviour
{
	[Token(Token = "0x400032B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Renderer[] _Targets;

	[Token(Token = "0x400032C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Material _ProjectorMaterial;

	[Token(Token = "0x400032D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float _NearClipPlane;

	[Token(Token = "0x400032E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float _FarClipPlane;

	[Token(Token = "0x400032F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float _AspectRatio;

	[Token(Token = "0x4000330")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[SerializeField]
	private float _FieldOfView;

	[Token(Token = "0x4000331")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float _OrthographicSize;

	[Token(Token = "0x4000332")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private bool _Orthographic;

	[Token(Token = "0x4000333")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private List<Material> mCopiedMaterials;

	[Token(Token = "0x4000334")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private ObjectPool<Material> mMaterialPool;

	[Token(Token = "0x170000E0")]
	public ObjectPool<Material> materialPool
	{
		[Token(Token = "0x6000460")]
		[Address(RVA = "0x88D8A4", Offset = "0x88D8A4", VA = "0x88D8A4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000461")]
	[Address(RVA = "0x88DA5C", Offset = "0x88DA5C", VA = "0x88DA5C")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000462")]
	[Address(RVA = "0x88E4D0", Offset = "0x88E4D0", VA = "0x88E4D0")]
	private void DrawTarget(Renderer renderer, Material renderMaterial)
	{
	}

	[Token(Token = "0x6000463")]
	[Address(RVA = "0x88E6A4", Offset = "0x88E6A4", VA = "0x88E6A4")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000464")]
	[Address(RVA = "0x88E320", Offset = "0x88E320", VA = "0x88E320")]
	private void ClearCopiedMaterials()
	{
	}

	[Token(Token = "0x6000465")]
	[Address(RVA = "0x88E7BC", Offset = "0x88E7BC", VA = "0x88E7BC")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6000466")]
	[Address(RVA = "0x88E9B0", Offset = "0x88E9B0", VA = "0x88E9B0")]
	public SimpleURPProjector()
	{
	}
}
[Token(Token = "0x20000BF")]
[ExecuteAlways]
public class SimpleURPProjectorTarget : CollectableBehavior<SimpleURPProjectorTarget>
{
	[Token(Token = "0x170000E1")]
	protected override bool enabledOnly
	{
		[Token(Token = "0x600046D")]
		[Address(RVA = "0x88EC60", Offset = "0x88EC60", VA = "0x88EC60", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600046E")]
	[Address(RVA = "0x88EC68", Offset = "0x88EC68", VA = "0x88EC68")]
	public SimpleURPProjectorTarget()
	{
	}
}
[Token(Token = "0x20000C0")]
[RequireComponent(typeof(Animator))]
public class AnimatorEvent : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20000C1")]
	private class Config
	{
		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float time;

		[NonSerialized]
		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool invoked;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UnityEvents.EmptyEvent action;

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x88EE24", Offset = "0x88EE24", VA = "0x88EE24")]
		public Config()
		{
		}
	}

	[Token(Token = "0x4000338")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Config[] _Configs;

	[Token(Token = "0x4000339")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Animator mAnimator;

	[Token(Token = "0x600046F")]
	[Address(RVA = "0x88ECD4", Offset = "0x88ECD4", VA = "0x88ECD4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000470")]
	[Address(RVA = "0x88ED24", Offset = "0x88ED24", VA = "0x88ED24")]
	private void Update()
	{
	}

	[Token(Token = "0x6000471")]
	[Address(RVA = "0x88EE1C", Offset = "0x88EE1C", VA = "0x88EE1C")]
	public AnimatorEvent()
	{
	}
}
[Token(Token = "0x20000C2")]
public class DocumentTab : MonoBehaviour
{
	[Token(Token = "0x400033E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Graphic _SelectedTarget;

	[Token(Token = "0x400033F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private string _DocumentResource;

	[Token(Token = "0x4000340")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Button _Button;

	[Token(Token = "0x4000341")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool _IsSelected;

	[Token(Token = "0x170000E2")]
	public string documentResource
	{
		[Token(Token = "0x6000474")]
		[Address(RVA = "0x88EE74", Offset = "0x88EE74", VA = "0x88EE74")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000E3")]
	public Button button
	{
		[Token(Token = "0x6000475")]
		[Address(RVA = "0x88EE7C", Offset = "0x88EE7C", VA = "0x88EE7C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000E4")]
	public bool isSelected
	{
		[Token(Token = "0x6000476")]
		[Address(RVA = "0x88EF10", Offset = "0x88EF10", VA = "0x88EF10")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000477")]
		[Address(RVA = "0x88EF18", Offset = "0x88EF18", VA = "0x88EF18")]
		set
		{
		}
	}

	[Token(Token = "0x6000473")]
	[Address(RVA = "0x88EE34", Offset = "0x88EE34", VA = "0x88EE34")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000478")]
	[Address(RVA = "0x88EF78", Offset = "0x88EF78", VA = "0x88EF78")]
	public DocumentTab()
	{
	}
}
[Token(Token = "0x20000C3")]
public class LanguageList : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20000C4")]
	private class Config
	{
		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SystemLanguage language;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Sprite sprite;

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x88F7C4", Offset = "0x88F7C4", VA = "0x88F7C4")]
		public Config()
		{
		}
	}

	[Token(Token = "0x4000342")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private LanguageListRow _Template;

	[Token(Token = "0x4000343")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Config[] _Languages;

	[Token(Token = "0x4000344")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private UnityEvents.StringEvent _OnSetLanguage;

	[Token(Token = "0x4000345")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<LanguageListRow> mRows;

	[Token(Token = "0x6000479")]
	[Address(RVA = "0x88EF80", Offset = "0x88EF80", VA = "0x88EF80")]
	private void Start()
	{
	}

	[Token(Token = "0x600047A")]
	[Address(RVA = "0x88F618", Offset = "0x88F618", VA = "0x88F618")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600047B")]
	[Address(RVA = "0x88F61C", Offset = "0x88F61C", VA = "0x88F61C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600047C")]
	[Address(RVA = "0x88F6C0", Offset = "0x88F6C0", VA = "0x88F6C0")]
	private void LanguageUtils_onLanguageChanged(string obj)
	{
	}

	[Token(Token = "0x600047D")]
	[Address(RVA = "0x88F3E8", Offset = "0x88F3E8", VA = "0x88F3E8")]
	private void Refresh()
	{
	}

	[Token(Token = "0x600047E")]
	[Address(RVA = "0x88F748", Offset = "0x88F748", VA = "0x88F748")]
	public LanguageList()
	{
	}
}
[Token(Token = "0x20000C6")]
public class LanguageListRow : MonoBehaviour
{
	[Token(Token = "0x400034A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Image _Image;

	[Token(Token = "0x400034B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private TextMeshProUGUI _Text;

	[Token(Token = "0x400034C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Graphic _SelectedTarget;

	[Token(Token = "0x400034D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Button _Button;

	[Token(Token = "0x400034E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool _IsSelected;

	[Token(Token = "0x170000E5")]
	public string language
	{
		[Token(Token = "0x6000483")]
		[Address(RVA = "0x88F8BC", Offset = "0x88F8BC", VA = "0x88F8BC")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000484")]
		[Address(RVA = "0x88F8C4", Offset = "0x88F8C4", VA = "0x88F8C4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170000E6")]
	public string text
	{
		[Token(Token = "0x6000485")]
		[Address(RVA = "0x88F8CC", Offset = "0x88F8CC", VA = "0x88F8CC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000486")]
		[Address(RVA = "0x88F6C4", Offset = "0x88F6C4", VA = "0x88F6C4")]
		set
		{
		}
	}

	[Token(Token = "0x170000E7")]
	public Sprite sprite
	{
		[Token(Token = "0x6000487")]
		[Address(RVA = "0x88F8F0", Offset = "0x88F8F0", VA = "0x88F8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000488")]
		[Address(RVA = "0x88F338", Offset = "0x88F338", VA = "0x88F338")]
		set
		{
		}
	}

	[Token(Token = "0x170000E8")]
	public Button button
	{
		[Token(Token = "0x6000489")]
		[Address(RVA = "0x88F354", Offset = "0x88F354", VA = "0x88F354")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000E9")]
	public bool isSelected
	{
		[Token(Token = "0x600048A")]
		[Address(RVA = "0x88F90C", Offset = "0x88F90C", VA = "0x88F90C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600048B")]
		[Address(RVA = "0x88F6E8", Offset = "0x88F6E8", VA = "0x88F6E8")]
		set
		{
		}
	}

	[Token(Token = "0x6000482")]
	[Address(RVA = "0x88F87C", Offset = "0x88F87C", VA = "0x88F87C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600048C")]
	[Address(RVA = "0x88F914", Offset = "0x88F914", VA = "0x88F914")]
	public LanguageListRow()
	{
	}
}
[Token(Token = "0x20000C7")]
public class LevelManager_StartMenu : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20000C8")]
	private struct LogoBackground
	{
		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		public Sprite _LogoBackgroundNormal;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[SerializeField]
		public Sprite _LogoBackgroundFestival;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		public SpriteRenderer _LogoRenderer;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		public Material _LogoOverlayMaterial;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		public Material _LogoNormalMaterial;

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x88F980", Offset = "0x88F980", VA = "0x88F980")]
		public void UpdateFestival(bool isFestival)
		{
		}
	}

	[Token(Token = "0x4000350")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private LogoBackground _LogoBackground;

	[Token(Token = "0x600048D")]
	[Address(RVA = "0x88F91C", Offset = "0x88F91C", VA = "0x88F91C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600048E")]
	[Address(RVA = "0x88F9B0", Offset = "0x88F9B0", VA = "0x88F9B0")]
	public LevelManager_StartMenu()
	{
	}
}
[Token(Token = "0x20000C9")]
public class MenuAnimation_StartMenu_Main : MonoBehaviour, MenuPanel.IMenuAnimation
{
	[Token(Token = "0x20000CA")]
	[CompilerGenerated]
	private sealed class <CheckPlayDone>d__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MenuAnimation_StartMenu_Main <>4__this;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string name;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action done;

		[Token(Token = "0x170000EB")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600049A")]
			[Address(RVA = "0x88FD6C", Offset = "0x88FD6C", VA = "0x88FD6C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000EC")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600049C")]
			[Address(RVA = "0x88FDB4", Offset = "0x88FDB4", VA = "0x88FDB4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x88FBA0", Offset = "0x88FBA0", VA = "0x88FBA0")]
		[DebuggerHidden]
		public <CheckPlayDone>d__11(int <>1__state)
		{
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x88FC20", Offset = "0x88FC20", VA = "0x88FC20", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x88FC24", Offset = "0x88FC24", VA = "0x88FC24", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x88FD74", Offset = "0x88FD74", VA = "0x88FD74", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000356")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int layer;

	[Token(Token = "0x4000357")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string logoFadeIn;

	[Token(Token = "0x4000358")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string normalFadeIn;

	[Token(Token = "0x4000359")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string fadeOut;

	[Token(Token = "0x400035A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Animator mAnimator;

	[Token(Token = "0x400035B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool mPlayed;

	[Token(Token = "0x170000EA")]
	private bool playLogo
	{
		[Token(Token = "0x6000492")]
		[Address(RVA = "0x88FAB8", Offset = "0x88FAB8", VA = "0x88FAB8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000490")]
	[Address(RVA = "0x88F9B8", Offset = "0x88F9B8", VA = "0x88F9B8", Slot = "5")]
	public void OnClose([Optional] Action done)
	{
	}

	[Token(Token = "0x6000491")]
	[Address(RVA = "0x88FA68", Offset = "0x88FA68", VA = "0x88FA68", Slot = "4")]
	public void OnOpen([Optional] Action done)
	{
	}

	[Token(Token = "0x6000493")]
	[Address(RVA = "0x88F9C8", Offset = "0x88F9C8", VA = "0x88F9C8")]
	private void PlayAnimation(string name, Action done)
	{
	}

	[Token(Token = "0x6000494")]
	[Address(RVA = "0x88FB24", Offset = "0x88FB24", VA = "0x88FB24")]
	[IteratorStateMachine(typeof(<CheckPlayDone>d__11))]
	private IEnumerator CheckPlayDone(string name, Action done)
	{
		return null;
	}

	[Token(Token = "0x6000495")]
	[Address(RVA = "0x88FBC8", Offset = "0x88FBC8", VA = "0x88FBC8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000496")]
	[Address(RVA = "0x88FC18", Offset = "0x88FC18", VA = "0x88FC18")]
	public MenuAnimation_StartMenu_Main()
	{
	}
}
[Token(Token = "0x20000CB")]
public class StartMenuHelpUI : MonoBehaviour
{
	[Token(Token = "0x4000361")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private DocumentTab[] _Tabs;

	[Token(Token = "0x4000362")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private DocumentLayoutXmlLoader _Document;

	[Token(Token = "0x4000363")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private DocumentTab _SelectedTab;

	[Token(Token = "0x600049D")]
	[Address(RVA = "0x88FDBC", Offset = "0x88FDBC", VA = "0x88FDBC")]
	private void Start()
	{
	}

	[Token(Token = "0x600049E")]
	[Address(RVA = "0x890168", Offset = "0x890168", VA = "0x890168")]
	private void LanguageUtils_onLanguageChanged(string obj)
	{
	}

	[Token(Token = "0x600049F")]
	[Address(RVA = "0x8903E0", Offset = "0x8903E0", VA = "0x8903E0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60004A0")]
	[Address(RVA = "0x88FF80", Offset = "0x88FF80", VA = "0x88FF80")]
	private void SelectTab(DocumentTab tab)
	{
	}

	[Token(Token = "0x60004A1")]
	[Address(RVA = "0x8901F0", Offset = "0x8901F0", VA = "0x8901F0")]
	private void SetDocument(string resource)
	{
	}

	[Token(Token = "0x60004A2")]
	[Address(RVA = "0x89048C", Offset = "0x89048C", VA = "0x89048C")]
	public StartMenuHelpUI()
	{
	}
}
[Token(Token = "0x20000CE")]
public class StartMenuLogoEvents : MonoBehaviour
{
	[Token(Token = "0x60004A7")]
	[Address(RVA = "0x8904D8", Offset = "0x8904D8", VA = "0x8904D8")]
	public void PlayAudio(AudioClip clip)
	{
	}

	[Token(Token = "0x60004A8")]
	[Address(RVA = "0x890500", Offset = "0x890500", VA = "0x890500")]
	public StartMenuLogoEvents()
	{
	}
}
[Token(Token = "0x20000CF")]
[RequireComponent(typeof(MenuPanelManager))]
public class StartMenuUI : MonoBehaviour
{
	[Token(Token = "0x4000367")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Button _ButtonStart;

	[Token(Token = "0x4000368")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private ScenesLoader _TutorialScene;

	[Token(Token = "0x4000369")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float _LogoTime;

	[Token(Token = "0x400036A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private MenuPanelManager mMenuPanelManager;

	[Token(Token = "0x60004A9")]
	[Address(RVA = "0x890508", Offset = "0x890508", VA = "0x890508")]
	private void Awake()
	{
	}

	[Token(Token = "0x60004AA")]
	[Address(RVA = "0x8906B0", Offset = "0x8906B0", VA = "0x8906B0")]
	private void Start()
	{
	}

	[Token(Token = "0x60004AB")]
	[Address(RVA = "0x89073C", Offset = "0x89073C", VA = "0x89073C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60004AC")]
	[Address(RVA = "0x890610", Offset = "0x890610", VA = "0x890610")]
	public void PlayMusic(float delayTime = 0f)
	{
	}

	[Token(Token = "0x60004AD")]
	[Address(RVA = "0x8907B0", Offset = "0x8907B0", VA = "0x8907B0")]
	public StartMenuUI()
	{
	}
}
[Token(Token = "0x20000D0")]
public class SteamDrawLineManager : MonoBehaviour
{
	[Token(Token = "0x400036B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Material lMat;

	[Token(Token = "0x400036C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float pencilWidth;

	[Token(Token = "0x400036D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool drawing;

	[Token(Token = "0x400036E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
	public bool picking;

	[Token(Token = "0x400036F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Color currentColor;

	[Token(Token = "0x4000370")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public MeshLineRenderer currentLine;

	[Token(Token = "0x60004AF")]
	[Address(RVA = "0x890870", Offset = "0x890870", VA = "0x890870")]
	public LineRenderer CreateLineRenderer()
	{
		return null;
	}

	[Token(Token = "0x60004B0")]
	[Address(RVA = "0x8909E4", Offset = "0x8909E4", VA = "0x8909E4")]
	public MeshLineRenderer CreateMeshLineRenderer()
	{
		return null;
	}

	[Token(Token = "0x60004B1")]
	[Address(RVA = "0x890B30", Offset = "0x890B30", VA = "0x890B30")]
	public SteamDrawLineManager()
	{
	}
}
[Token(Token = "0x20000D1")]
[SingletonOption(autoCreate = true)]
public class CopybooksManager : SingletonGameObject<CopybooksManager>
{
	[Token(Token = "0x20000D2")]
	public class Copybook
	{
		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly Texture texture;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly string path;

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x890DB0", Offset = "0x890DB0", VA = "0x890DB0")]
		public Copybook(Texture texture, string path)
		{
		}
	}

	[Token(Token = "0x20000D4")]
	[CompilerGenerated]
	private sealed class <Load>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CopybooksManager <>4__this;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action<Texture, string> action;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<string>.Enumerator <>7__wrap1;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string <asset>5__3;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private UnityWebRequest <w>5__4;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private DownloadHandlerTexture <downloadHandler>5__5;

		[Token(Token = "0x170000EF")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004BF")]
			[Address(RVA = "0x891448", Offset = "0x891448", VA = "0x891448", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F0")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004C1")]
			[Address(RVA = "0x891490", Offset = "0x891490", VA = "0x891490", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x890D40", Offset = "0x890D40", VA = "0x890D40")]
		[DebuggerHidden]
		public <Load>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x890E9C", Offset = "0x890E9C", VA = "0x890E9C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x890EB8", Offset = "0x890EB8", VA = "0x890EB8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x8913F8", Offset = "0x8913F8", VA = "0x8913F8")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x891450", Offset = "0x891450", VA = "0x891450", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000371")]
	private const string _CopybookPath = "Data\\Copybooks";

	[Token(Token = "0x4000372")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<Copybook> mLoadedCopybooks;

	[Token(Token = "0x170000ED")]
	protected override bool dontDestroyOnLoad
	{
		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x890B38", Offset = "0x890B38", VA = "0x890B38", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000EE")]
	public IReadOnlyList<Copybook> loadedCopybooks
	{
		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x890D38", Offset = "0x890D38", VA = "0x890D38")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60004B3")]
	[Address(RVA = "0x890B40", Offset = "0x890B40", VA = "0x890B40")]
	public void LoadCopybooks(Action<Texture, string> action)
	{
	}

	[Token(Token = "0x60004B5")]
	[Address(RVA = "0x890CC4", Offset = "0x890CC4", VA = "0x890CC4")]
	[IteratorStateMachine(typeof(<Load>d__7))]
	private IEnumerator Load(Action<Texture, string> action)
	{
		return null;
	}

	[Token(Token = "0x60004B6")]
	[Address(RVA = "0x890D68", Offset = "0x890D68", VA = "0x890D68")]
	public CopybooksManager()
	{
	}
}
[Token(Token = "0x20000D5")]
public class HintForControllerTooCloseToHead : MonoBehaviour
{
	[Token(Token = "0x400037F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float _CheckRaduis;

	[Token(Token = "0x4000380")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private float? mOveriderRaidus;

	[Token(Token = "0x4000381")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float mStartTime;

	[Token(Token = "0x4000382")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private string mCacheControllerType;

	[Token(Token = "0x170000F1")]
	private float radius
	{
		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x8919E8", Offset = "0x8919E8", VA = "0x8919E8")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x60004C2")]
	[Address(RVA = "0x891498", Offset = "0x891498", VA = "0x891498")]
	private void Start()
	{
	}

	[Token(Token = "0x60004C3")]
	[Address(RVA = "0x8914B4", Offset = "0x8914B4", VA = "0x8914B4")]
	private void Update()
	{
	}

	[Token(Token = "0x60004C4")]
	[Address(RVA = "0x891770", Offset = "0x891770", VA = "0x891770")]
	private bool CheckControllers(params VRBodyType[] controllers)
	{
		return default(bool);
	}

	[Token(Token = "0x60004C6")]
	[Address(RVA = "0x891A54", Offset = "0x891A54", VA = "0x891A54")]
	public HintForControllerTooCloseToHead()
	{
	}
}
[Token(Token = "0x20000D6")]
public class StudyRoomController : SingletonGameObject<StudyRoomController>
{
	[Token(Token = "0x4000383")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Paper _MainPaper;

	[Token(Token = "0x4000384")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private BrushRecorder _BrushRecorder;

	[Token(Token = "0x4000385")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private ScenesLoader _ScenesLoaderStartMenu;

	[Token(Token = "0x170000F2")]
	public Paper mainPaper
	{
		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x891A64", Offset = "0x891A64", VA = "0x891A64")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000F3")]
	public BrushRecorder brushRecorder
	{
		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x891A6C", Offset = "0x891A6C", VA = "0x891A6C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60004C9")]
	[Address(RVA = "0x891A74", Offset = "0x891A74", VA = "0x891A74", Slot = "5")]
	protected override void OnAwake()
	{
	}

	[Token(Token = "0x60004CA")]
	[Address(RVA = "0x891AF4", Offset = "0x891AF4", VA = "0x891AF4")]
	public void Quit()
	{
	}

	[Token(Token = "0x60004CB")]
	[Address(RVA = "0x891B78", Offset = "0x891B78", VA = "0x891B78")]
	public StudyRoomController()
	{
	}
}
[Token(Token = "0x20000D7")]
[TreeNode(name = "Game/Check Resource")]
public class CheckResourceNode : BehaviorTreeNode
{
	[Token(Token = "0x4000386")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private string _ResourceKey;

	[Token(Token = "0x4000387")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private ExecuteState mState;

	[Token(Token = "0x60004CC")]
	[Address(RVA = "0x891BC0", Offset = "0x891BC0", VA = "0x891BC0", Slot = "9")]
	public override ExecuteState UpdateNode()
	{
		return default(ExecuteState);
	}

	[Token(Token = "0x60004CD")]
	[Address(RVA = "0x891C9C", Offset = "0x891C9C", VA = "0x891C9C")]
	public CheckResourceNode()
	{
	}
}
[Token(Token = "0x20000D8")]
[TreeNode(name = "Game/Demonstration Action")]
public class DemonstrationActionNode : BehaviorTreeNode
{
	[Token(Token = "0x4000388")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private BehaviorVariableFloat _Progress;

	[Token(Token = "0x4000389")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private float _MaxProgress;

	[Token(Token = "0x400038A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private GameObject _Prefab;

	[Token(Token = "0x400038B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Transform _Position;

	[Token(Token = "0x400038C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private GameObject _Demonstration;

	[Token(Token = "0x60004CE")]
	[Address(RVA = "0x891CA4", Offset = "0x891CA4", VA = "0x891CA4", Slot = "10")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x60004CF")]
	[Address(RVA = "0x891D78", Offset = "0x891D78", VA = "0x891D78", Slot = "9")]
	public override ExecuteState UpdateNode()
	{
		return default(ExecuteState);
	}

	[Token(Token = "0x60004D0")]
	[Address(RVA = "0x891ED0", Offset = "0x891ED0", VA = "0x891ED0")]
	public DemonstrationActionNode()
	{
	}
}
[Token(Token = "0x20000D9")]
[TreeNode(name = "Game/Hint")]
public class HintNode : BehaviorTreeNode
{
	[Token(Token = "0x400038D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[LanguageKey]
	public string hinTextKey;

	[Token(Token = "0x400038E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[LanguageKey]
	public string hintTitleKey;

	[Token(Token = "0x400038F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Transform target;

	[Token(Token = "0x4000390")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public bool showOnCamera;

	[Token(Token = "0x4000391")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public int keepShowFrames;

	[Token(Token = "0x4000392")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public string resource;

	[Token(Token = "0x4000393")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public bool viewNavgation;

	[Token(Token = "0x4000394")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
	public bool hasArrow;

	[Token(Token = "0x4000395")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Sprite sprite;

	[Token(Token = "0x4000396")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public string spriteLanResource;

	[Token(Token = "0x4000397")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public bool showProgress;

	[Token(Token = "0x4000398")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	private BehaviorVariableFloat _ProgressValue;

	[Token(Token = "0x4000399")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private HintController mController;

	[Token(Token = "0x400039A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Slider mSlider;

	[Token(Token = "0x400039B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private int mFrames;

	[Token(Token = "0x60004D1")]
	[Address(RVA = "0x891ED8", Offset = "0x891ED8", VA = "0x891ED8")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60004D2")]
	[Address(RVA = "0x892358", Offset = "0x892358", VA = "0x892358", Slot = "9")]
	public override ExecuteState UpdateNode()
	{
		return default(ExecuteState);
	}

	[Token(Token = "0x60004D3")]
	[Address(RVA = "0x89243C", Offset = "0x89243C", VA = "0x89243C")]
	public HintNode()
	{
	}
}
[Token(Token = "0x20000DA")]
[TreeNode(name = "Game/Is Tutorial Mode")]
public class IsTutorialNode : BehaviorTreeNode
{
	[Token(Token = "0x60004D4")]
	[Address(RVA = "0x892454", Offset = "0x892454", VA = "0x892454", Slot = "9")]
	public override ExecuteState UpdateNode()
	{
		return default(ExecuteState);
	}

	[Token(Token = "0x60004D5")]
	[Address(RVA = "0x8924B0", Offset = "0x8924B0", VA = "0x8924B0")]
	public IsTutorialNode()
	{
	}
}
[Token(Token = "0x20000DB")]
[TreeNode(name = "Game/Open Or Close Panel")]
public class OpenOrClosePanel : BehaviorTreeNode, IBehaviorTreeNodeInformation
{
	[Token(Token = "0x20000DC")]
	private enum Option
	{
		[Token(Token = "0x400039F")]
		None,
		[Token(Token = "0x40003A0")]
		Open,
		[Token(Token = "0x40003A1")]
		Close,
		[Token(Token = "0x40003A2")]
		Toggle
	}

	[Token(Token = "0x400039C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	public MenuPanel _TargetPanel;

	[Token(Token = "0x400039D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Option _Option;

	[Token(Token = "0x170000F4")]
	public string information
	{
		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x8924B8", Offset = "0x8924B8", VA = "0x8924B8", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60004D7")]
	[Address(RVA = "0x8925C8", Offset = "0x8925C8", VA = "0x8925C8", Slot = "9")]
	public override ExecuteState UpdateNode()
	{
		return default(ExecuteState);
	}

	[Token(Token = "0x60004D8")]
	[Address(RVA = "0x89268C", Offset = "0x89268C", VA = "0x89268C")]
	public OpenOrClosePanel()
	{
	}
}
[Token(Token = "0x20000DD")]
[TreeNode(name = "Game/Play Audio")]
public class PlayAudioNode : BehaviorTreeNode
{
	[Token(Token = "0x40003A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private AudioClip _Clip;

	[Token(Token = "0x40003A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private AudioSource _Source;

	[Token(Token = "0x60004D9")]
	[Address(RVA = "0x89269C", Offset = "0x89269C", VA = "0x89269C", Slot = "9")]
	public override ExecuteState UpdateNode()
	{
		return default(ExecuteState);
	}

	[Token(Token = "0x60004DA")]
	[Address(RVA = "0x892730", Offset = "0x892730", VA = "0x892730")]
	public PlayAudioNode()
	{
	}
}
[Token(Token = "0x20000DE")]
[TreeNode(name = "Game/Set Object Interable")]
public class SetObjectInterable : BehaviorTreeNode, IBehaviorTreeNodeInformation
{
	[Token(Token = "0x40003A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[SerializeField]
	private bool _Interable;

	[Token(Token = "0x40003A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private InteractableObject _InteractableObject;

	[Token(Token = "0x170000F5")]
	public string information
	{
		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x892738", Offset = "0x892738", VA = "0x892738", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60004DC")]
	[Address(RVA = "0x8927DC", Offset = "0x8927DC", VA = "0x8927DC", Slot = "9")]
	public override ExecuteState UpdateNode()
	{
		return default(ExecuteState);
	}

	[Token(Token = "0x60004DD")]
	[Address(RVA = "0x892864", Offset = "0x892864", VA = "0x892864")]
	public SetObjectInterable()
	{
	}
}
[Token(Token = "0x20000DF")]
[TreeNode(name = "Game/Tutorial Completed")]
public class TutorialCompleted : BehaviorTreeNode
{
	[Token(Token = "0x60004DE")]
	[Address(RVA = "0x89286C", Offset = "0x89286C", VA = "0x89286C", Slot = "9")]
	public override ExecuteState UpdateNode()
	{
		return default(ExecuteState);
	}

	[Token(Token = "0x60004DF")]
	[Address(RVA = "0x8928FC", Offset = "0x8928FC", VA = "0x8928FC")]
	public TutorialCompleted()
	{
	}
}
[Token(Token = "0x20000E0")]
[TreeNode(name = "Game/Tutorial Select Target Copybook")]
public class TutorialSelectTargetCopybook : WaitTargetCopybookSelected
{
	[Token(Token = "0x40003A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private string _HintKeyApply;

	[Token(Token = "0x40003A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private string _HintKeyApplyTitle;

	[Token(Token = "0x40003A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private string _HintKeySelect;

	[Token(Token = "0x40003AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private string _HintKeySelectTitle;

	[Token(Token = "0x40003AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Transform _HintTransform;

	[Token(Token = "0x40003AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private GalleryPanel _List;

	[Token(Token = "0x40003AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private float _AutoScrollCd;

	[Token(Token = "0x40003AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private HintController _HintController;

	[Token(Token = "0x40003AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private float _CurrentAutoScrollCd;

	[Token(Token = "0x40003B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private int mLastSelectedIndex;

	[Token(Token = "0x60004E0")]
	[Address(RVA = "0x892904", Offset = "0x892904", VA = "0x892904", Slot = "10")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x60004E1")]
	[Address(RVA = "0x89290C", Offset = "0x89290C", VA = "0x89290C", Slot = "9")]
	public override ExecuteState UpdateNode()
	{
		return default(ExecuteState);
	}

	[Token(Token = "0x60004E2")]
	[Address(RVA = "0x892AD0", Offset = "0x892AD0", VA = "0x892AD0")]
	private void ShowHint(string message, string title)
	{
	}

	[Token(Token = "0x60004E3")]
	[Address(RVA = "0x892C20", Offset = "0x892C20", VA = "0x892C20")]
	protected void Update()
	{
	}

	[Token(Token = "0x60004E4")]
	[Address(RVA = "0x892CAC", Offset = "0x892CAC", VA = "0x892CAC")]
	public TutorialSelectTargetCopybook()
	{
	}
}
[Token(Token = "0x20000E1")]
[TreeNode(name = "Game/Wait Art Saved")]
public class WaitArtSaved : WaitMessageNode
{
	[Token(Token = "0x60004E5")]
	[Address(RVA = "0x892CCC", Offset = "0x892CCC", VA = "0x892CCC", Slot = "17")]
	public override bool OnMessage(GameMessageType msgType, int what, params object[] args)
	{
		return default(bool);
	}

	[Token(Token = "0x60004E6")]
	[Address(RVA = "0x892D20", Offset = "0x892D20", VA = "0x892D20")]
	public WaitArtSaved()
	{
	}
}
[Token(Token = "0x20000E2")]
[TreeNode(name = "Game/Wait Chiorgraphy Playing")]
public class WaitChiorgraphyPlaying : WaitEventNode
{
	[Token(Token = "0x40003B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private bool _invest;

	[Token(Token = "0x40003B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private BrushRecorder mBrushRecorder;

	[Token(Token = "0x60004E7")]
	[Address(RVA = "0x892D30", Offset = "0x892D30", VA = "0x892D30")]
	private void Start()
	{
	}

	[Token(Token = "0x60004E8")]
	[Address(RVA = "0x892DA0", Offset = "0x892DA0", VA = "0x892DA0", Slot = "9")]
	public override ExecuteState UpdateNode()
	{
		return default(ExecuteState);
	}

	[Token(Token = "0x60004E9")]
	[Address(RVA = "0x892E50", Offset = "0x892E50", VA = "0x892E50")]
	public WaitChiorgraphyPlaying()
	{
	}
}
[Token(Token = "0x20000E3")]
public abstract class WaitEventNode : BehaviorTreeNode
{
	[Token(Token = "0x40003B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private ExecuteState actionState;

	[Token(Token = "0x60004EA")]
	[Address(RVA = "0x892D14", Offset = "0x892D14", VA = "0x892D14")]
	public void SetDone()
	{
	}

	[Token(Token = "0x60004EB")]
	[Address(RVA = "0x892E60", Offset = "0x892E60", VA = "0x892E60")]
	public void SetFailed()
	{
	}

	[Token(Token = "0x60004EC")]
	[Address(RVA = "0x892E6C", Offset = "0x892E6C", VA = "0x892E6C", Slot = "10")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x60004ED")]
	[Address(RVA = "0x892C08", Offset = "0x892C08", VA = "0x892C08", Slot = "9")]
	public override ExecuteState UpdateNode()
	{
		return default(ExecuteState);
	}

	[Token(Token = "0x60004EE")]
	[Address(RVA = "0x892E58", Offset = "0x892E58", VA = "0x892E58")]
	protected WaitEventNode()
	{
	}
}
[Token(Token = "0x20000E4")]
public abstract class WaitMessageNode : WaitEventNode
{
	[Token(Token = "0x60004EF")]
	[Address(RVA = "0x892E78", Offset = "0x892E78", VA = "0x892E78", Slot = "8")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60004F0")]
	public abstract bool OnMessage(GameMessageType msgType, int what, params object[] args);

	[Token(Token = "0x60004F1")]
	[Address(RVA = "0x892EFC", Offset = "0x892EFC", VA = "0x892EFC", Slot = "16")]
	public override void OnDestroy()
	{
	}

	[Token(Token = "0x60004F2")]
	[Address(RVA = "0x892D28", Offset = "0x892D28", VA = "0x892D28")]
	protected WaitMessageNode()
	{
	}
}
[Token(Token = "0x20000E5")]
[TreeNode(name = "Game/Wait Ink Grounded")]
public class WaitInkGrounded : BehaviorTreeNode
{
	[Token(Token = "0x40003B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private InkStickGroundable _TargetInk;

	[Token(Token = "0x40003B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private BehaviorVariableFloat _SetProgressValue;

	[Token(Token = "0x60004F3")]
	[Address(RVA = "0x892F80", Offset = "0x892F80", VA = "0x892F80", Slot = "10")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x60004F4")]
	[Address(RVA = "0x892FEC", Offset = "0x892FEC", VA = "0x892FEC", Slot = "9")]
	public override ExecuteState UpdateNode()
	{
		return default(ExecuteState);
	}

	[Token(Token = "0x60004F5")]
	[Address(RVA = "0x893130", Offset = "0x893130", VA = "0x893130")]
	public WaitInkGrounded()
	{
	}
}
[Token(Token = "0x20000E6")]
[TreeNode(name = "Game/Wait Item Pick And Dropped")]
public class WaitItemPickAndDroppedNode : WaitMessageNode
{
	[Token(Token = "0x20000E7")]
	private enum Option
	{
		[Token(Token = "0x40003BA")]
		Pick,
		[Token(Token = "0x40003BB")]
		Drop
	}

	[Token(Token = "0x40003B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private string _itemTag;

	[Token(Token = "0x40003B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private PickAndDropItem _targetItem;

	[Token(Token = "0x40003B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Option _option;

	[Token(Token = "0x60004F6")]
	[Address(RVA = "0x893138", Offset = "0x893138", VA = "0x893138", Slot = "17")]
	public override bool OnMessage(GameMessageType msgType, int what, params object[] args)
	{
		return default(bool);
	}

	[Token(Token = "0x60004F7")]
	[Address(RVA = "0x8932C4", Offset = "0x8932C4", VA = "0x8932C4")]
	public WaitItemPickAndDroppedNode()
	{
	}
}
[Token(Token = "0x20000E8")]
[TreeNode(name = "Game/Wait MyPaintings Selected")]
public class WaitMyPaintingsSelectedNode : WaitEventNode
{
	[Token(Token = "0x40003BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private PaintingsList _paintingsList;

	[Token(Token = "0x60004F8")]
	[Address(RVA = "0x8932CC", Offset = "0x8932CC", VA = "0x8932CC", Slot = "8")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60004F9")]
	[Address(RVA = "0x893398", Offset = "0x893398", VA = "0x893398")]
	public WaitMyPaintingsSelectedNode()
	{
	}
}
[Token(Token = "0x20000E9")]
[TreeNode(name = "Game/Wait Painted")]
public class WaitPaintedNode : WaitMessageNode
{
	[Token(Token = "0x40003BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float motionTime;

	[Token(Token = "0x40003BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public string paperName;

	[Token(Token = "0x40003BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private BehaviorVariableFloat _SetProgressValue;

	[Token(Token = "0x40003C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float mCurrentMotionTime;

	[Token(Token = "0x40003C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Paper mLastPlaper;

	[Token(Token = "0x60004FB")]
	[Address(RVA = "0x8933B8", Offset = "0x8933B8", VA = "0x8933B8", Slot = "10")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x60004FC")]
	[Address(RVA = "0x8933C0", Offset = "0x8933C0", VA = "0x8933C0", Slot = "17")]
	public override bool OnMessage(GameMessageType msgType, int what, params object[] args)
	{
		return default(bool);
	}

	[Token(Token = "0x60004FD")]
	[Address(RVA = "0x893550", Offset = "0x893550", VA = "0x893550", Slot = "9")]
	public override ExecuteState UpdateNode()
	{
		return default(ExecuteState);
	}

	[Token(Token = "0x60004FE")]
	[Address(RVA = "0x8935F0", Offset = "0x8935F0", VA = "0x8935F0")]
	public WaitPaintedNode()
	{
	}
}
[Token(Token = "0x20000EA")]
[TreeNode(name = "Game/Wait Panel Opened")]
public class WaitPanelOpenedNode : BehaviorTreeNode, IBehaviorTreeNodeInformation
{
	[Token(Token = "0x40003C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public MenuPanel targetPanel;

	[Token(Token = "0x40003C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool closeWhenOpened;

	[Token(Token = "0x170000F6")]
	public string information
	{
		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x893600", Offset = "0x893600", VA = "0x893600", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000500")]
	[Address(RVA = "0x893688", Offset = "0x893688", VA = "0x893688", Slot = "10")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x6000501")]
	[Address(RVA = "0x8936D4", Offset = "0x8936D4", VA = "0x8936D4", Slot = "9")]
	public override ExecuteState UpdateNode()
	{
		return default(ExecuteState);
	}

	[Token(Token = "0x6000502")]
	[Address(RVA = "0x89372C", Offset = "0x89372C", VA = "0x89372C")]
	public WaitPanelOpenedNode()
	{
	}
}
[Token(Token = "0x20000EB")]
[TreeNode(name = "Game/Wait Paper Cleared")]
public class WaitPaperCleared : WaitMessageNode
{
	[Token(Token = "0x6000503")]
	[Address(RVA = "0x89373C", Offset = "0x89373C", VA = "0x89373C", Slot = "17")]
	public override bool OnMessage(GameMessageType msgType, int what, params object[] args)
	{
		return default(bool);
	}

	[Token(Token = "0x6000504")]
	[Address(RVA = "0x893784", Offset = "0x893784", VA = "0x893784")]
	public WaitPaperCleared()
	{
	}
}
[Token(Token = "0x20000EC")]
[TreeNode(name = "Game/Wait Picked Color")]
public class WaitPickedColorNode : WaitMessageNode
{
	[Token(Token = "0x40003C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float motionTime;

	[Token(Token = "0x40003C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private BehaviorVariableFloat _SetProgressValue;

	[Token(Token = "0x40003C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float mCurrentMotionTime;

	[Token(Token = "0x40003C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private ColorPalette mLastColorPalette;

	[Token(Token = "0x6000505")]
	[Address(RVA = "0x89378C", Offset = "0x89378C", VA = "0x89378C", Slot = "17")]
	public override bool OnMessage(GameMessageType msgType, int what, params object[] args)
	{
		return default(bool);
	}

	[Token(Token = "0x6000506")]
	[Address(RVA = "0x893970", Offset = "0x893970", VA = "0x893970", Slot = "9")]
	public override ExecuteState UpdateNode()
	{
		return default(ExecuteState);
	}

	[Token(Token = "0x6000507")]
	[Address(RVA = "0x893A10", Offset = "0x893A10", VA = "0x893A10")]
	public WaitPickedColorNode()
	{
	}
}
[Token(Token = "0x20000ED")]
[TreeNode(name = "Game/Wait Set Video Template")]
public class WaitSetVideoTemplateNode : WaitMessageNode
{
	[Token(Token = "0x6000508")]
	[Address(RVA = "0x893A20", Offset = "0x893A20", VA = "0x893A20", Slot = "17")]
	public override bool OnMessage(GameMessageType msgType, int what, params object[] args)
	{
		return default(bool);
	}

	[Token(Token = "0x6000509")]
	[Address(RVA = "0x893A88", Offset = "0x893A88", VA = "0x893A88")]
	public WaitSetVideoTemplateNode()
	{
	}
}
[Token(Token = "0x20000EE")]
[TreeNode(name = "Game/Wait Simple Event")]
public class WaitSimpleEventNode : WaitMessageNode
{
	[Token(Token = "0x40003C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private int what;

	[Token(Token = "0x600050A")]
	[Address(RVA = "0x893A90", Offset = "0x893A90", VA = "0x893A90", Slot = "17")]
	public override bool OnMessage(GameMessageType msgType, int what, params object[] args)
	{
		return default(bool);
	}

	[Token(Token = "0x600050B")]
	[Address(RVA = "0x893ADC", Offset = "0x893ADC", VA = "0x893ADC")]
	public WaitSimpleEventNode()
	{
	}
}
[Token(Token = "0x20000EF")]
[TreeNode(name = "Game/Wait Simple Events")]
public class WaitSimpleEventsNode : WaitMessageNode
{
	[Token(Token = "0x40003C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private int[] whats;

	[Token(Token = "0x600050C")]
	[Address(RVA = "0x893AE4", Offset = "0x893AE4", VA = "0x893AE4", Slot = "17")]
	public override bool OnMessage(GameMessageType msgType, int what, params object[] args)
	{
		return default(bool);
	}

	[Token(Token = "0x600050D")]
	[Address(RVA = "0x893B70", Offset = "0x893B70", VA = "0x893B70")]
	public WaitSimpleEventsNode()
	{
	}
}
[Token(Token = "0x20000F0")]
[TreeNode(name = "Game/Wait Target Copybook Selected")]
public class WaitTargetCopybookSelected : WaitMessageNode
{
	[Token(Token = "0x40003CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	protected string _targetCopybookName;

	[Token(Token = "0x170000F7")]
	public string targetCopybookName
	{
		[Token(Token = "0x600050E")]
		[Address(RVA = "0x893B78", Offset = "0x893B78", VA = "0x893B78")]
		get
		{
			return null;
		}
		[Token(Token = "0x600050F")]
		[Address(RVA = "0x893B80", Offset = "0x893B80", VA = "0x893B80")]
		set
		{
		}
	}

	[Token(Token = "0x6000510")]
	[Address(RVA = "0x893B88", Offset = "0x893B88", VA = "0x893B88", Slot = "17")]
	public override bool OnMessage(GameMessageType msgType, int what, params object[] args)
	{
		return default(bool);
	}

	[Token(Token = "0x6000511")]
	[Address(RVA = "0x892CC4", Offset = "0x892CC4", VA = "0x892CC4")]
	public WaitTargetCopybookSelected()
	{
	}
}
[Token(Token = "0x20000F1")]
[TreeNode(name = "Game/Wait Video Playing")]
public class WaitVideoPlayingNode : WaitEventNode
{
	[Token(Token = "0x40003CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private bool _invest;

	[Token(Token = "0x6000512")]
	[Address(RVA = "0x893CA0", Offset = "0x893CA0", VA = "0x893CA0", Slot = "9")]
	public override ExecuteState UpdateNode()
	{
		return default(ExecuteState);
	}

	[Token(Token = "0x6000513")]
	[Address(RVA = "0x893D54", Offset = "0x893D54", VA = "0x893D54")]
	public WaitVideoPlayingNode()
	{
	}
}
[Token(Token = "0x20000F2")]
[TreeNode(name = "Game/Wait VR Recentered")]
public class WaitVRRecentered : WaitEventNode
{
	[Token(Token = "0x40003CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private int what;

	[Token(Token = "0x6000514")]
	[Address(RVA = "0x893D5C", Offset = "0x893D5C", VA = "0x893D5C", Slot = "8")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6000515")]
	[Address(RVA = "0x893E2C", Offset = "0x893E2C", VA = "0x893E2C")]
	private void Platform_isRecentered()
	{
	}

	[Token(Token = "0x6000516")]
	[Address(RVA = "0x893E5C", Offset = "0x893E5C", VA = "0x893E5C", Slot = "16")]
	public override void OnDestroy()
	{
	}

	[Token(Token = "0x6000517")]
	[Address(RVA = "0x893F4C", Offset = "0x893F4C", VA = "0x893F4C")]
	public WaitVRRecentered()
	{
	}
}
[Token(Token = "0x20000F3")]
[RequireComponent(typeof(Animator))]
public class DemonstrationAction : MonoBehaviour
{
	[Token(Token = "0x40003CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private AnimationInvoker[] _Animations;

	[Token(Token = "0x40003CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float[] _LayerWeights;

	[Token(Token = "0x40003CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private bool _PlayOnAwake;

	[Token(Token = "0x6000518")]
	[Address(RVA = "0x893F54", Offset = "0x893F54", VA = "0x893F54")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000519")]
	[Address(RVA = "0x893F64", Offset = "0x893F64", VA = "0x893F64")]
	public void Play()
	{
	}

	[Token(Token = "0x600051A")]
	[Address(RVA = "0x894054", Offset = "0x894054", VA = "0x894054")]
	public DemonstrationAction()
	{
	}
}
[Token(Token = "0x20000F4")]
public class BallEffectCtrl : MonoBehaviour
{
	[Token(Token = "0x40003D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject effect;

	[Token(Token = "0x40003D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Renderer mat;

	[Token(Token = "0x600051B")]
	[Address(RVA = "0x89405C", Offset = "0x89405C", VA = "0x89405C")]
	private void OnUITrigger()
	{
	}

	[Token(Token = "0x600051C")]
	[Address(RVA = "0x8940D4", Offset = "0x8940D4", VA = "0x8940D4")]
	public BallEffectCtrl()
	{
	}
}
[Token(Token = "0x20000F5")]
public class ButtonEfx : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerClickHandler
{
	[Token(Token = "0x40003D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioClip pointerEnter;

	[Token(Token = "0x40003D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AudioClip pointerClick;

	[Token(Token = "0x40003D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool vibrationOnEnter;

	[Token(Token = "0x40003D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float vibrationOnEnterTime;

	[Token(Token = "0x40003D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float vibrationOnEnterAmplitude;

	[Token(Token = "0x40003D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Selectable mSelectable;

	[Token(Token = "0x600051D")]
	[Address(RVA = "0x8940DC", Offset = "0x8940DC", VA = "0x8940DC")]
	private void Awake()
	{
	}

	[Token(Token = "0x600051E")]
	[Address(RVA = "0x89412C", Offset = "0x89412C", VA = "0x89412C", Slot = "5")]
	public void OnPointerClick(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600051F")]
	[Address(RVA = "0x8941F0", Offset = "0x8941F0", VA = "0x8941F0", Slot = "4")]
	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000520")]
	[Address(RVA = "0x89462C", Offset = "0x89462C", VA = "0x89462C")]
	public ButtonEfx()
	{
	}
}
[Token(Token = "0x20000F6")]
[RequireComponent(typeof(Button))]
public class ButtonToggle : MonoBehaviour
{
	[Token(Token = "0x40003D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject target;

	[Token(Token = "0x6000521")]
	[Address(RVA = "0x894648", Offset = "0x894648", VA = "0x894648")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000522")]
	[Address(RVA = "0x8946F8", Offset = "0x8946F8", VA = "0x8946F8")]
	public ButtonToggle()
	{
	}
}
[Token(Token = "0x20000F7")]
[RequireComponent(typeof(AudioSource))]
public class DeskHandle : InteractableVRObject
{
	[Token(Token = "0x40003D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GameObject desk;

	[Token(Token = "0x40003DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float minDeskheight;

	[Token(Token = "0x40003DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public float maxDeskHeight;

	[Token(Token = "0x40003DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Color normalColor;

	[Token(Token = "0x40003DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Color highlightColor;

	[Token(Token = "0x40003DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Color pressedColor;

	[Token(Token = "0x40003DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Material highlightMaterial;

	[Token(Token = "0x40003E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public string highlighColorName;

	[Token(Token = "0x40003E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	[SerializeField]
	private AudioClip _AudioHoldOn;

	[Token(Token = "0x40003E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private AudioClip _AudioHoldingMove;

	[Token(Token = "0x40003E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	[SerializeField]
	private AudioClip _AudioHoldOff;

	[Token(Token = "0x40003E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private string _HoldingAnimationTrigger;

	[Token(Token = "0x40003E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	[SerializeField]
	private string _HoldingAlignPosition;

	[Token(Token = "0x40003E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private float mBaseDeskY;

	[Token(Token = "0x40003E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	private float mStartDeskHeightDelta;

	[Token(Token = "0x40003E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private float mStartHandY;

	[Token(Token = "0x40003E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	private bool mIsHolding;

	[Token(Token = "0x40003EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private HandController mHoldingHand;

	[Token(Token = "0x40003EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private AudioSource mAudioSource;

	[Token(Token = "0x40003EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private Transform mHoldingHandAlignPosition;

	[Token(Token = "0x40003ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private Vector3 mHoldingResetPosition;

	[Token(Token = "0x40003EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
	private Quaternion mHoldingResetRotation;

	[Token(Token = "0x40003EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static float mCatchedDeskHeight;

	[Token(Token = "0x6000524")]
	[Address(RVA = "0x89479C", Offset = "0x89479C", VA = "0x89479C", Slot = "17")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000525")]
	[Address(RVA = "0x894A6C", Offset = "0x894A6C", VA = "0x894A6C")]
	private void SetHighlighColor(Color color)
	{
	}

	[Token(Token = "0x6000526")]
	[Address(RVA = "0x894B40", Offset = "0x894B40", VA = "0x894B40", Slot = "11")]
	public override bool BeforEnter(InteractableHandler handler)
	{
		return default(bool);
	}

	[Token(Token = "0x6000527")]
	[Address(RVA = "0x894C08", Offset = "0x894C08", VA = "0x894C08", Slot = "19")]
	protected override void Update()
	{
	}

	[Token(Token = "0x6000528")]
	[Address(RVA = "0x8948D0", Offset = "0x8948D0", VA = "0x8948D0")]
	private void SetHeight(float height)
	{
	}

	[Token(Token = "0x6000529")]
	[Address(RVA = "0x894F70", Offset = "0x894F70", VA = "0x894F70", Slot = "20")]
	protected override void OnProcessEvents(VRHandInput vrInput)
	{
	}

	[Token(Token = "0x600052A")]
	[Address(RVA = "0x8951D0", Offset = "0x8951D0", VA = "0x8951D0", Slot = "12")]
	public override void OnEnter(InteractableHandler handler)
	{
	}

	[Token(Token = "0x600052B")]
	[Address(RVA = "0x8951F8", Offset = "0x8951F8", VA = "0x8951F8", Slot = "13")]
	public override void OnExit(InteractableHandler handler)
	{
	}

	[Token(Token = "0x600052C")]
	[Address(RVA = "0x8950BC", Offset = "0x8950BC", VA = "0x8950BC")]
	private void End()
	{
	}

	[Token(Token = "0x600052D")]
	[Address(RVA = "0x895224", Offset = "0x895224", VA = "0x895224")]
	public DeskHandle()
	{
	}
}
[Token(Token = "0x20000F8")]
public class DialogBuilder : MonoBehaviour
{
	[Token(Token = "0x40003F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject _TextTitle;

	[Token(Token = "0x40003F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject _TextMessage;

	[Token(Token = "0x40003F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject _ButtonsPanel;

	[Token(Token = "0x40003F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject _TemplateButton;

	[Token(Token = "0x40003F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private List<GameObject> mButtons;

	[Token(Token = "0x40003F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Func<string, bool> mOnClicked;

	[Token(Token = "0x600052F")]
	[Address(RVA = "0x8962E8", Offset = "0x8962E8", VA = "0x8962E8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000530")]
	[Address(RVA = "0x896314", Offset = "0x896314", VA = "0x896314")]
	public DialogBuilder Clear()
	{
		return null;
	}

	[Token(Token = "0x6000531")]
	[Address(RVA = "0x8964EC", Offset = "0x8964EC", VA = "0x8964EC")]
	public DialogBuilder SetTitle(string title)
	{
		return null;
	}

	[Token(Token = "0x6000532")]
	[Address(RVA = "0x89659C", Offset = "0x89659C", VA = "0x89659C")]
	public DialogBuilder SetMessage(string message)
	{
		return null;
	}

	[Token(Token = "0x6000533")]
	[Address(RVA = "0x89664C", Offset = "0x89664C", VA = "0x89664C")]
	public DialogBuilder AddButton(string key, string text, [Optional] Func<string, bool> onClicked)
	{
		return null;
	}

	[Token(Token = "0x6000534")]
	[Address(RVA = "0x8968CC", Offset = "0x8968CC", VA = "0x8968CC")]
	public DialogBuilder SetButtonListener(Func<string, bool> onClicked)
	{
		return null;
	}

	[Token(Token = "0x6000535")]
	[Address(RVA = "0x8968D4", Offset = "0x8968D4", VA = "0x8968D4")]
	public void Open()
	{
	}

	[Token(Token = "0x6000536")]
	[Address(RVA = "0x896940", Offset = "0x896940", VA = "0x896940")]
	public void Close()
	{
	}

	[Token(Token = "0x6000537")]
	[Address(RVA = "0x89699C", Offset = "0x89699C", VA = "0x89699C")]
	public DialogBuilder()
	{
	}
}
[Serializable]
[Token(Token = "0x20000FA")]
public class HorizontalScrollHandler
{
	[Token(Token = "0x20000FB")]
	public enum State
	{
		[Token(Token = "0x4000400")]
		Start,
		[Token(Token = "0x4000401")]
		Scrolling
	}

	[Token(Token = "0x40003F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[SerializeField]
	private float _ScrollHoldDeltaTime;

	[Token(Token = "0x40003FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[SerializeField]
	private float _ScrollDeltaTime;

	[Token(Token = "0x40003FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private State state;

	[Token(Token = "0x40003FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private float startTime;

	[Token(Token = "0x40003FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float lastScrollTime;

	[Token(Token = "0x40003FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float lastHoldingFrame;

	[Token(Token = "0x600053A")]
	[Address(RVA = "0x896A84", Offset = "0x896A84", VA = "0x896A84")]
	public void OnScroll(PointerEventData eventData, Action<float> onScroll)
	{
	}

	[Token(Token = "0x600053B")]
	[Address(RVA = "0x896BA8", Offset = "0x896BA8", VA = "0x896BA8")]
	public HorizontalScrollHandler()
	{
	}
}
[Token(Token = "0x20000FC")]
public class LevelListController : MonoBehaviour
{
	[Token(Token = "0x4000402")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Button _startButton;

	[Token(Token = "0x4000403")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private UILevelList _levelList;

	[Token(Token = "0x600053C")]
	[Address(RVA = "0x896BBC", Offset = "0x896BBC", VA = "0x896BBC")]
	private void Awake()
	{
	}

	[Token(Token = "0x600053D")]
	[Address(RVA = "0x896D28", Offset = "0x896D28", VA = "0x896D28")]
	private void Load(int index)
	{
	}

	[Token(Token = "0x600053E")]
	[Address(RVA = "0x896EEC", Offset = "0x896EEC", VA = "0x896EEC")]
	public void SetTutorialMode(bool tutorial)
	{
	}

	[Token(Token = "0x600053F")]
	[Address(RVA = "0x896F48", Offset = "0x896F48", VA = "0x896F48")]
	public LevelListController()
	{
	}
}
[Token(Token = "0x20000FD")]
public class LevelListItemEvent : MonoBehaviour
{
	[Token(Token = "0x4000404")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private AudioClip _AudioAction;

	[Token(Token = "0x4000405")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private UnityEvents.EmptyEvent _OnAction;

	[Token(Token = "0x170000F8")]
	public UnityEvents.EmptyEvent onAction
	{
		[Token(Token = "0x6000543")]
		[Address(RVA = "0x897094", Offset = "0x897094", VA = "0x897094")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000544")]
	[Address(RVA = "0x89709C", Offset = "0x89709C", VA = "0x89709C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000545")]
	[Address(RVA = "0x897128", Offset = "0x897128", VA = "0x897128")]
	public LevelListItemEvent()
	{
	}
}
[Token(Token = "0x20000FE")]
public abstract class MediaPlayerController : MonoBehaviour
{
	[Token(Token = "0x20000FF")]
	public interface MediaPlayer
	{
		[Token(Token = "0x170000FA")]
		bool isPlaying
		{
			[Token(Token = "0x6000553")]
			get;
			[Token(Token = "0x6000554")]
			set;
		}

		[Token(Token = "0x170000FB")]
		bool isPaused
		{
			[Token(Token = "0x6000555")]
			get;
			[Token(Token = "0x6000556")]
			set;
		}

		[Token(Token = "0x170000FC")]
		bool canPlay
		{
			[Token(Token = "0x6000559")]
			get;
		}

		[Token(Token = "0x170000FD")]
		bool canPlayNext
		{
			[Token(Token = "0x600055A")]
			get;
		}

		[Token(Token = "0x170000FE")]
		bool canPlayPrev
		{
			[Token(Token = "0x600055B")]
			get;
		}

		[Token(Token = "0x170000FF")]
		float volumn
		{
			[Token(Token = "0x600055C")]
			get;
			[Token(Token = "0x600055D")]
			set;
		}

		[Token(Token = "0x17000100")]
		float time
		{
			[Token(Token = "0x600055E")]
			get;
			[Token(Token = "0x600055F")]
			set;
		}

		[Token(Token = "0x17000101")]
		float length
		{
			[Token(Token = "0x6000560")]
			get;
		}

		[Token(Token = "0x6000557")]
		void PlayNext();

		[Token(Token = "0x6000558")]
		void PlayPrev();
	}

	[Token(Token = "0x4000406")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Button _buttonPlayNext;

	[Token(Token = "0x4000407")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Button _buttonPlayPrev;

	[Token(Token = "0x4000408")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Button _buttonPlay;

	[Token(Token = "0x4000409")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Button _buttonPause;

	[Token(Token = "0x400040A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Button _buttonVolumnUp;

	[Token(Token = "0x400040B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Button _buttonVolumnDown;

	[Token(Token = "0x400040C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Slider _sliderVolumn;

	[Token(Token = "0x400040D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Slider _sliderProgress;

	[Token(Token = "0x400040E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private float volumnDelta;

	[Token(Token = "0x170000F9")]
	protected abstract MediaPlayer mediaPlayer
	{
		[Token(Token = "0x6000547")]
		get;
	}

	[Token(Token = "0x6000548")]
	[Address(RVA = "0x897208", Offset = "0x897208", VA = "0x897208")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000549")]
	[Address(RVA = "0x897688", Offset = "0x897688", VA = "0x897688")]
	private void Update()
	{
	}

	[Token(Token = "0x600054A")]
	[Address(RVA = "0x897C84", Offset = "0x897C84", VA = "0x897C84")]
	protected MediaPlayerController()
	{
	}
}
[Token(Token = "0x2000100")]
public class MovieList : PlayableList
{
	[Token(Token = "0x400040F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private MoviePlayer mMoviePlayer;

	[Token(Token = "0x17000102")]
	public override object currentPlayble
	{
		[Token(Token = "0x6000563")]
		[Address(RVA = "0x898C18", Offset = "0x898C18", VA = "0x898C18", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000103")]
	public override bool isPlaying
	{
		[Token(Token = "0x6000564")]
		[Address(RVA = "0x898C34", Offset = "0x898C34", VA = "0x898C34", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000561")]
	[Address(RVA = "0x8984C0", Offset = "0x8984C0", VA = "0x8984C0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000562")]
	[Address(RVA = "0x898AA0", Offset = "0x898AA0", VA = "0x898AA0", Slot = "5")]
	protected override void OnRowClicked(PlayableListRow listRow)
	{
	}

	[Token(Token = "0x6000565")]
	[Address(RVA = "0x898C74", Offset = "0x898C74", VA = "0x898C74")]
	public void BtnPlayNext()
	{
	}

	[Token(Token = "0x6000566")]
	[Address(RVA = "0x898DC8", Offset = "0x898DC8", VA = "0x898DC8")]
	public void BtnPlayBack()
	{
	}

	[Token(Token = "0x6000567")]
	[Address(RVA = "0x898F20", Offset = "0x898F20", VA = "0x898F20")]
	public void BtnPlay()
	{
	}

	[Token(Token = "0x6000568")]
	[Address(RVA = "0x898FF8", Offset = "0x898FF8", VA = "0x898FF8")]
	public void AudioVolumnUp(float up)
	{
	}

	[Token(Token = "0x6000569")]
	[Address(RVA = "0x899074", Offset = "0x899074", VA = "0x899074")]
	public MovieList()
	{
	}
}
[Token(Token = "0x2000101")]
public class MoviePlayButton : PlayButton
{
	[Token(Token = "0x17000104")]
	protected override bool isPlaying
	{
		[Token(Token = "0x600056A")]
		[Address(RVA = "0x8990F4", Offset = "0x8990F4", VA = "0x8990F4", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600056B")]
	[Address(RVA = "0x89917C", Offset = "0x89917C", VA = "0x89917C", Slot = "6")]
	protected override void Update()
	{
	}

	[Token(Token = "0x600056C")]
	[Address(RVA = "0x89923C", Offset = "0x89923C", VA = "0x89923C")]
	public MoviePlayButton()
	{
	}
}
[Token(Token = "0x2000102")]
[RequireComponent(typeof(AudioSource))]
[SingletonOption(resource = "Prefabs/MoviePlayer")]
[RequireComponent(typeof(VideoPlayer))]
public class MoviePlayer : SingletonGameObject<MoviePlayer>, MediaPlayerController.MediaPlayer
{
	[Serializable]
	[Token(Token = "0x2000103")]
	public class Movie
	{
		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string title;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VideoClip clip;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string url;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool isUnlocked;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Texture2D template;

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x899724", Offset = "0x899724", VA = "0x899724")]
		public Movie()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000104")]
	public class MovieGroup
	{
		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string title;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<Movie> movies;

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x89972C", Offset = "0x89972C", VA = "0x89972C")]
		public MovieGroup()
		{
		}
	}

	[Token(Token = "0x4000410")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private MovieGroup[] _groups;

	[Token(Token = "0x4000411")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private AudioMixerGroup _musicGroup;

	[Token(Token = "0x4000412")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float _downMusicAttenuation;

	[Token(Token = "0x4000413")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private VideoPlayer mPlayer;

	[Token(Token = "0x4000414")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private AudioSource mAudioSource;

	[Token(Token = "0x4000415")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Movie mCurrentMovie;

	[Token(Token = "0x17000105")]
	public bool isPaused
	{
		[Token(Token = "0x6000570")]
		[Address(RVA = "0x89942C", Offset = "0x89942C", VA = "0x89942C", Slot = "10")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000571")]
		[Address(RVA = "0x898F74", Offset = "0x898F74", VA = "0x898F74", Slot = "11")]
		set
		{
		}
	}

	[Token(Token = "0x17000106")]
	public bool isPlaying
	{
		[Token(Token = "0x6000572")]
		[Address(RVA = "0x898C58", Offset = "0x898C58", VA = "0x898C58", Slot = "8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000573")]
		[Address(RVA = "0x898FA0", Offset = "0x898FA0", VA = "0x898FA0", Slot = "9")]
		set
		{
		}
	}

	[Token(Token = "0x17000107")]
	public Movie currentMovie
	{
		[Token(Token = "0x6000578")]
		[Address(RVA = "0x8995FC", Offset = "0x8995FC", VA = "0x8995FC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000108")]
	public MovieGroup[] Groups
	{
		[Token(Token = "0x6000579")]
		[Address(RVA = "0x899604", Offset = "0x899604", VA = "0x899604")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000109")]
	public VideoPlayer player
	{
		[Token(Token = "0x600057A")]
		[Address(RVA = "0x89960C", Offset = "0x89960C", VA = "0x89960C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700010A")]
	public bool canPlay
	{
		[Token(Token = "0x600057B")]
		[Address(RVA = "0x899614", Offset = "0x899614", VA = "0x899614", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700010B")]
	public bool canPlayNext
	{
		[Token(Token = "0x600057C")]
		[Address(RVA = "0x89961C", Offset = "0x89961C", VA = "0x89961C", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700010C")]
	public bool canPlayPrev
	{
		[Token(Token = "0x600057D")]
		[Address(RVA = "0x899624", Offset = "0x899624", VA = "0x899624", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700010D")]
	public float volumn
	{
		[Token(Token = "0x600057E")]
		[Address(RVA = "0x89962C", Offset = "0x89962C", VA = "0x89962C", Slot = "17")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600057F")]
		[Address(RVA = "0x899648", Offset = "0x899648", VA = "0x899648", Slot = "18")]
		set
		{
		}
	}

	[Token(Token = "0x1700010E")]
	public float time
	{
		[Token(Token = "0x6000580")]
		[Address(RVA = "0x899664", Offset = "0x899664", VA = "0x899664", Slot = "19")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000581")]
		[Address(RVA = "0x899688", Offset = "0x899688", VA = "0x899688", Slot = "20")]
		set
		{
		}
	}

	[Token(Token = "0x1700010F")]
	public float length
	{
		[Token(Token = "0x6000582")]
		[Address(RVA = "0x8996A8", Offset = "0x8996A8", VA = "0x8996A8", Slot = "21")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x600056D")]
	[Address(RVA = "0x89924C", Offset = "0x89924C", VA = "0x89924C", Slot = "5")]
	protected override void OnAwake()
	{
	}

	[Token(Token = "0x600056E")]
	[Address(RVA = "0x89937C", Offset = "0x89937C", VA = "0x89937C")]
	private void Update()
	{
	}

	[Token(Token = "0x600056F")]
	[Address(RVA = "0x899410", Offset = "0x899410", VA = "0x899410")]
	private void MPlayer_prepareCompleted(VideoPlayer source)
	{
	}

	[Token(Token = "0x6000574")]
	[Address(RVA = "0x899448", Offset = "0x899448", VA = "0x899448")]
	public void PlayAt(int groupIndex, int movieIndex)
	{
	}

	[Token(Token = "0x6000575")]
	[Address(RVA = "0x898B30", Offset = "0x898B30", VA = "0x898B30")]
	public void Play(Movie movie)
	{
	}

	[Token(Token = "0x6000576")]
	[Address(RVA = "0x898C8C", Offset = "0x898C8C", VA = "0x898C8C")]
	public bool PlayNext()
	{
		return default(bool);
	}

	[Token(Token = "0x6000577")]
	[Address(RVA = "0x898DE0", Offset = "0x898DE0", VA = "0x898DE0")]
	public bool PlayBack()
	{
		return default(bool);
	}

	[Token(Token = "0x6000583")]
	[Address(RVA = "0x8994DC", Offset = "0x8994DC", VA = "0x8994DC")]
	public bool FindIndex(Movie movie, out int groupIndex, out int movieIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x6000584")]
	[Address(RVA = "0x8996CC", Offset = "0x8996CC", VA = "0x8996CC", Slot = "12")]
	private void MediaPlayerController.MediaPlayer.PlayNext()
	{
	}

	[Token(Token = "0x6000585")]
	[Address(RVA = "0x8996D0", Offset = "0x8996D0", VA = "0x8996D0", Slot = "13")]
	public void PlayPrev()
	{
	}

	[Token(Token = "0x6000586")]
	[Address(RVA = "0x8996D4", Offset = "0x8996D4", VA = "0x8996D4")]
	public MoviePlayer()
	{
	}
}
[Token(Token = "0x2000105")]
public class MoviePlayerController : MonoBehaviour
{
	[Token(Token = "0x400041D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private string _timeFormatKey;

	[Token(Token = "0x400041E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Slider _sliderProgress;

	[Token(Token = "0x400041F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Text _textTime;

	[Token(Token = "0x4000420")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private RawImage _videoView;

	[Token(Token = "0x6000589")]
	[Address(RVA = "0x899734", Offset = "0x899734", VA = "0x899734")]
	private void Awake()
	{
	}

	[Token(Token = "0x600058A")]
	[Address(RVA = "0x8997FC", Offset = "0x8997FC", VA = "0x8997FC")]
	private void Update()
	{
	}

	[Token(Token = "0x600058B")]
	[Address(RVA = "0x899A98", Offset = "0x899A98", VA = "0x899A98")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600058C")]
	[Address(RVA = "0x899A9C", Offset = "0x899A9C", VA = "0x899A9C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600058D")]
	[Address(RVA = "0x899800", Offset = "0x899800", VA = "0x899800")]
	private void UpdateSlider()
	{
	}

	[Token(Token = "0x600058E")]
	[Address(RVA = "0x899B20", Offset = "0x899B20", VA = "0x899B20")]
	private void SetProgress(float progress)
	{
	}

	[Token(Token = "0x600058F")]
	[Address(RVA = "0x899C2C", Offset = "0x899C2C", VA = "0x899C2C")]
	public MoviePlayerController()
	{
	}
}
[Token(Token = "0x2000106")]
public class MusicList : MonoBehaviour
{
	[Token(Token = "0x4000421")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private List<MusicListRow> mRows;

	[Token(Token = "0x4000422")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private MusicListRow mTemplateRow;

	[Token(Token = "0x4000423")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool mNeedScrollToSelected;

	[Token(Token = "0x4000424")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private MusicPlayer.MusicInfo mLastPlaying;

	[Token(Token = "0x6000591")]
	[Address(RVA = "0x899C38", Offset = "0x899C38", VA = "0x899C38")]
	private void Start()
	{
	}

	[Token(Token = "0x6000592")]
	[Address(RVA = "0x899DE4", Offset = "0x899DE4", VA = "0x899DE4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000593")]
	[Address(RVA = "0x899DF0", Offset = "0x899DF0", VA = "0x899DF0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000594")]
	[Address(RVA = "0x89A4C8", Offset = "0x89A4C8", VA = "0x89A4C8")]
	private void ScrollToVisible(GameObject go)
	{
	}

	[Token(Token = "0x6000595")]
	[Address(RVA = "0x89A530", Offset = "0x89A530", VA = "0x89A530")]
	public void OnClickDelegate(PointerEventData eventData, GameObject obj)
	{
	}

	[Token(Token = "0x6000596")]
	[Address(RVA = "0x89A63C", Offset = "0x89A63C", VA = "0x89A63C")]
	public MusicList()
	{
	}
}
[Token(Token = "0x2000108")]
public class MusicListRow : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
	[Token(Token = "0x2000109")]
	public delegate void OnClickDelegate(PointerEventData eventData, GameObject obj);

	[Token(Token = "0x4000427")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TextMeshProUGUI title;

	[Token(Token = "0x4000428")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Image playIcon;

	[Token(Token = "0x4000429")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Button button;

	[Token(Token = "0x14000002")]
	public event OnClickDelegate OnClicked
	{
		[Token(Token = "0x600059A")]
		[Address(RVA = "0x89A42C", Offset = "0x89A42C", VA = "0x89A42C")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600059B")]
		[Address(RVA = "0x89A6DC", Offset = "0x89A6DC", VA = "0x89A6DC")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x600059C")]
	[Address(RVA = "0x89A778", Offset = "0x89A778", VA = "0x89A778", Slot = "4")]
	public void OnPointerClick(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600059D")]
	[Address(RVA = "0x89A7C4", Offset = "0x89A7C4", VA = "0x89A7C4")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600059E")]
	[Address(RVA = "0x89A7CC", Offset = "0x89A7CC", VA = "0x89A7CC")]
	public MusicListRow()
	{
	}
}
[Token(Token = "0x200010A")]
public class MusicPlayButton : PlayButton
{
	[Token(Token = "0x17000110")]
	protected override bool isPlaying
	{
		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x89A81C", Offset = "0x89A81C", VA = "0x89A81C", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60005A4")]
	[Address(RVA = "0x89A89C", Offset = "0x89A89C", VA = "0x89A89C", Slot = "6")]
	protected override void Update()
	{
	}

	[Token(Token = "0x60005A5")]
	[Address(RVA = "0x89A8F8", Offset = "0x89A8F8", VA = "0x89A8F8")]
	public MusicPlayButton()
	{
	}
}
[Token(Token = "0x200010B")]
public abstract class PlayButton : MonoBehaviour
{
	[Token(Token = "0x400042B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text text;

	[Token(Token = "0x400042C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string playTextKey;

	[Token(Token = "0x400042D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string pauseTextKey;

	[Token(Token = "0x400042E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool prePlayState;

	[Token(Token = "0x17000111")]
	protected abstract bool isPlaying
	{
		[Token(Token = "0x60005A6")]
		get;
	}

	[Token(Token = "0x60005A7")]
	[Address(RVA = "0x89A900", Offset = "0x89A900", VA = "0x89A900")]
	protected void Awake()
	{
	}

	[Token(Token = "0x60005A8")]
	[Address(RVA = "0x89A9B4", Offset = "0x89A9B4", VA = "0x89A9B4")]
	private void LanguageUtils_onLanguageChanged(string obj)
	{
	}

	[Token(Token = "0x60005A9")]
	[Address(RVA = "0x89A9C0", Offset = "0x89A9C0", VA = "0x89A9C0", Slot = "5")]
	protected virtual void OnDestroy()
	{
	}

	[Token(Token = "0x60005AA")]
	[Address(RVA = "0x8991D8", Offset = "0x8991D8", VA = "0x8991D8", Slot = "6")]
	protected virtual void Update()
	{
	}

	[Token(Token = "0x60005AB")]
	[Address(RVA = "0x89AA64", Offset = "0x89AA64", VA = "0x89AA64", Slot = "7")]
	protected virtual void UpdateText()
	{
	}

	[Token(Token = "0x60005AC")]
	[Address(RVA = "0x899244", Offset = "0x899244", VA = "0x899244")]
	protected PlayButton()
	{
	}
}
[Token(Token = "0x200010C")]
public class MusicPlayerController : MediaPlayerController
{
	[Token(Token = "0x17000112")]
	protected override MediaPlayer mediaPlayer
	{
		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x89AB08", Offset = "0x89AB08", VA = "0x89AB08", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60005AE")]
	[Address(RVA = "0x89AB78", Offset = "0x89AB78", VA = "0x89AB78")]
	public MusicPlayerController()
	{
	}
}
[Token(Token = "0x200010D")]
public class PaintingPreview : MonoBehaviour
{
	[Token(Token = "0x400042F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject template;

	[Token(Token = "0x60005AF")]
	[Address(RVA = "0x89AB8C", Offset = "0x89AB8C", VA = "0x89AB8C")]
	private void Start()
	{
	}

	[Token(Token = "0x60005B0")]
	[Address(RVA = "0x89AB90", Offset = "0x89AB90", VA = "0x89AB90")]
	private void Update()
	{
	}

	[Token(Token = "0x60005B1")]
	[Address(RVA = "0x89AB94", Offset = "0x89AB94", VA = "0x89AB94")]
	public void SetTexture(Texture texture)
	{
	}

	[Token(Token = "0x60005B2")]
	[Address(RVA = "0x89AB98", Offset = "0x89AB98", VA = "0x89AB98")]
	public PaintingPreview()
	{
	}
}
[Token(Token = "0x200010E")]
public class PaintingsList : MonoBehaviour, IScrollHandler, IEventSystemHandler
{
	[Token(Token = "0x4000430")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public PicGrid template;

	[Token(Token = "0x4000431")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public RawImage previewImage;

	[Token(Token = "0x4000432")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float scrollSmooth;

	[Token(Token = "0x4000433")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject loadingHint;

	[Token(Token = "0x4000434")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private GameObject _ListEmptyHint;

	[Token(Token = "0x4000435")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private FileUtils.MediaType _MediaType;

	[Token(Token = "0x4000436")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private AudioClip _AudioPaging;

	[Token(Token = "0x4000437")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private AudioClip _AudioClicked;

	[Token(Token = "0x4000438")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private HorizontalScrollHandler _Scroll;

	[Token(Token = "0x4000439")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private List<PicGrid> mGrids;

	[Token(Token = "0x400043A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private LayoutGroup mLayout;

	[Token(Token = "0x400043B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private int mTargetOffset;

	[Token(Token = "0x400043C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private PicGrid mSeletedGrid;

	[Token(Token = "0x400043D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private UnityEvents.IntEvent _onListItemSelected;

	[Token(Token = "0x400043E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private UnityEvents.IntEvent _onListItemClicked;

	[Token(Token = "0x400043F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private bool mTeleport;

	[Token(Token = "0x4000440")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private SavedPaintings mSavedPaintings;

	[Token(Token = "0x17000113")]
	public UnityEvents.IntEvent onListItemSelected
	{
		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x89ABA0", Offset = "0x89ABA0", VA = "0x89ABA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000114")]
	public UnityEvents.IntEvent onListItemClicked
	{
		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x89ABA8", Offset = "0x89ABA8", VA = "0x89ABA8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000115")]
	public PicGrid seletedGrid
	{
		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x89ABB0", Offset = "0x89ABB0", VA = "0x89ABB0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x89ABB8", Offset = "0x89ABB8", VA = "0x89ABB8")]
		set
		{
		}
	}

	[Token(Token = "0x17000116")]
	public SavedPaintings savedPaintings
	{
		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x89ADC4", Offset = "0x89ADC4", VA = "0x89ADC4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60005B7")]
	[Address(RVA = "0x89AD38", Offset = "0x89AD38", VA = "0x89AD38")]
	public void Select(int index)
	{
	}

	[Token(Token = "0x60005B9")]
	[Address(RVA = "0x89ADCC", Offset = "0x89ADCC", VA = "0x89ADCC")]
	public int IndexOf(PicGrid grid)
	{
		return default(int);
	}

	[Token(Token = "0x60005BA")]
	[Address(RVA = "0x89AE24", Offset = "0x89AE24", VA = "0x89AE24")]
	private void Awake()
	{
	}

	[Token(Token = "0x60005BB")]
	[Address(RVA = "0x89AF68", Offset = "0x89AF68", VA = "0x89AF68")]
	public SavedPaintings.Painting GetSelectedSavedPanting()
	{
		return null;
	}

	[Token(Token = "0x60005BC")]
	[Address(RVA = "0x89B03C", Offset = "0x89B03C", VA = "0x89B03C")]
	private void Start()
	{
	}

	[Token(Token = "0x60005BD")]
	[Address(RVA = "0x89B058", Offset = "0x89B058", VA = "0x89B058")]
	private void LoadImages()
	{
	}

	[Token(Token = "0x60005BE")]
	[Address(RVA = "0x89B0F0", Offset = "0x89B0F0", VA = "0x89B0F0")]
	private void SetUpImages()
	{
	}

	[Token(Token = "0x60005BF")]
	[Address(RVA = "0x89B5A0", Offset = "0x89B5A0", VA = "0x89B5A0")]
	private void SavedPaintings_OnPaintingsChanged(int index, SavedPaintings.ChangeType type)
	{
	}

	[Token(Token = "0x60005C0")]
	[Address(RVA = "0x89B88C", Offset = "0x89B88C", VA = "0x89B88C")]
	private void Update()
	{
	}

	[Token(Token = "0x60005C1")]
	[Address(RVA = "0x89BDBC", Offset = "0x89BDBC", VA = "0x89BDBC")]
	public void UpdateVisibles()
	{
	}

	[Token(Token = "0x60005C2")]
	[Address(RVA = "0x89C21C", Offset = "0x89C21C", VA = "0x89C21C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60005C3")]
	[Address(RVA = "0x89C220", Offset = "0x89C220", VA = "0x89C220")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60005C4")]
	[Address(RVA = "0x89C324", Offset = "0x89C324", VA = "0x89C324", Slot = "4")]
	public void OnScroll(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60005C5")]
	[Address(RVA = "0x89C3BC", Offset = "0x89C3BC", VA = "0x89C3BC")]
	private void Scroll(float dir)
	{
	}

	[Token(Token = "0x60005C6")]
	[Address(RVA = "0x89C4A8", Offset = "0x89C4A8", VA = "0x89C4A8")]
	public PaintingsList()
	{
	}
}
[Token(Token = "0x2000110")]
public class PaintingsListController : MonoBehaviour
{
	[Token(Token = "0x4000443")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private PaintingsList _List;

	[Token(Token = "0x4000444")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Button _ButtonApply;

	[Token(Token = "0x4000445")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Button _ButtonDelete;

	[Token(Token = "0x4000446")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Paper.PaperTemplateType _ApplyType;

	[Token(Token = "0x60005C9")]
	[Address(RVA = "0x89C6FC", Offset = "0x89C6FC", VA = "0x89C6FC")]
	private void Start()
	{
	}

	[Token(Token = "0x60005CA")]
	[Address(RVA = "0x89C940", Offset = "0x89C940", VA = "0x89C940")]
	private void Apply()
	{
	}

	[Token(Token = "0x60005CB")]
	[Address(RVA = "0x89CABC", Offset = "0x89CABC", VA = "0x89CABC")]
	public PaintingsListController()
	{
	}
}
[Token(Token = "0x2000111")]
public class PhotoFrameList : MonoBehaviour, ILayoutGroup, ILayoutController
{
	[Token(Token = "0x4000447")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RectOffset _Padding;

	[Token(Token = "0x4000448")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float _Space;

	[Token(Token = "0x4000449")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[SerializeField]
	private Vector2 _ItemSize;

	[Token(Token = "0x400044A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float _ScrollSmooth;

	[Token(Token = "0x400044B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private PhotoFrameListItem _Preview;

	[Token(Token = "0x400044C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private PhotoFrameListItem mSelectedItem;

	[Token(Token = "0x400044D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private int mSelectedIndex;

	[Token(Token = "0x400044E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private List<PhotoFrameListItem> mItems;

	[Token(Token = "0x400044F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private DrivenRectTransformTracker mTracker;

	[Token(Token = "0x4000450")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private float mScrollOffset;

	[Token(Token = "0x4000451")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private RectTransform mRectTransform;

	[Token(Token = "0x4000452")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private PhotoFrameListItem mItemTemplate;

	[Token(Token = "0x4000453")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private ObjectPool<PhotoFrameListItem> mItemsPool;

	[Token(Token = "0x17000117")]
	public RectTransform rectTransform
	{
		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x89CBC0", Offset = "0x89CBC0", VA = "0x89CBC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000118")]
	public PhotoFrameListItem selectedItem
	{
		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x89CDA0", Offset = "0x89CDA0", VA = "0x89CDA0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x89CDA8", Offset = "0x89CDA8", VA = "0x89CDA8")]
		set
		{
		}
	}

	[Token(Token = "0x60005D1")]
	[Address(RVA = "0x89CC54", Offset = "0x89CC54", VA = "0x89CC54")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60005D4")]
	[Address(RVA = "0x89CEA4", Offset = "0x89CEA4", VA = "0x89CEA4")]
	private void Awake()
	{
	}

	[Token(Token = "0x60005D5")]
	[Address(RVA = "0x89D3F0", Offset = "0x89D3F0", VA = "0x89D3F0")]
	private void Start()
	{
	}

	[Token(Token = "0x60005D6")]
	[Address(RVA = "0x89DBA0", Offset = "0x89DBA0", VA = "0x89DBA0", Slot = "4")]
	public void SetLayoutHorizontal()
	{
	}

	[Token(Token = "0x60005D7")]
	[Address(RVA = "0x89DDA8", Offset = "0x89DDA8", VA = "0x89DDA8", Slot = "5")]
	public void SetLayoutVertical()
	{
	}

	[Token(Token = "0x60005D8")]
	[Address(RVA = "0x89DF8C", Offset = "0x89DF8C", VA = "0x89DF8C")]
	private void Update()
	{
	}

	[Token(Token = "0x60005D9")]
	[Address(RVA = "0x89CC58", Offset = "0x89CC58", VA = "0x89CC58")]
	private void Invalidate()
	{
	}

	[Token(Token = "0x60005DA")]
	[Address(RVA = "0x89E040", Offset = "0x89E040", VA = "0x89E040")]
	public PhotoFrameList()
	{
	}
}
[Token(Token = "0x2000114")]
[CreateAssetMenu(fileName = "PhotoFrameListData")]
public class PhotoFrameListData : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x2000115")]
	public class Data
	{
		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Sprite _Sprite;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectOffset _Offset;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _Scale;

		[Token(Token = "0x1700011B")]
		public Sprite sprite
		{
			[Token(Token = "0x60005E5")]
			[Address(RVA = "0x89E3B4", Offset = "0x89E3B4", VA = "0x89E3B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700011C")]
		public RectOffset offset
		{
			[Token(Token = "0x60005E6")]
			[Address(RVA = "0x89E3BC", Offset = "0x89E3BC", VA = "0x89E3BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700011D")]
		public float scale
		{
			[Token(Token = "0x60005E7")]
			[Address(RVA = "0x89E3C4", Offset = "0x89E3C4", VA = "0x89E3C4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x89E3CC", Offset = "0x89E3CC", VA = "0x89E3CC")]
		public Data()
		{
		}
	}

	[Token(Token = "0x4000459")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private List<Data> _Data;

	[Token(Token = "0x400045A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static PhotoFrameListData mInstance;

	[Token(Token = "0x17000119")]
	public static PhotoFrameListData instance
	{
		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x89D81C", Offset = "0x89D81C", VA = "0x89D81C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700011A")]
	public IReadOnlyList<Data> data
	{
		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x89E3A4", Offset = "0x89E3A4", VA = "0x89E3A4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60005E4")]
	[Address(RVA = "0x89E3AC", Offset = "0x89E3AC", VA = "0x89E3AC")]
	public PhotoFrameListData()
	{
	}
}
[Token(Token = "0x2000116")]
[RequireComponent(typeof(RectTransform))]
public class PhotoFrameListItem : MonoBehaviour
{
	[Token(Token = "0x400045E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Button _Button;

	[Token(Token = "0x400045F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Image _Frame;

	[Token(Token = "0x4000460")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private RawImage _Preview;

	[Token(Token = "0x4000461")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private RectTransform mRectTransform;

	[Token(Token = "0x4000462")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private PhotoFrameListData.Data mData;

	[Token(Token = "0x1700011E")]
	public bool isChecked
	{
		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x89E3DC", Offset = "0x89E3DC", VA = "0x89E3DC")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x89E3E4", Offset = "0x89E3E4", VA = "0x89E3E4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700011F")]
	public PhotoFrameListData.Data data
	{
		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x89E3F0", Offset = "0x89E3F0", VA = "0x89E3F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x89D8E8", Offset = "0x89D8E8", VA = "0x89D8E8")]
		set
		{
		}
	}

	[Token(Token = "0x17000120")]
	public Texture previewTexture
	{
		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x89E3F8", Offset = "0x89E3F8", VA = "0x89E3F8")]
		get
		{
			return null;
		}
		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x89E024", Offset = "0x89E024", VA = "0x89E024")]
		set
		{
		}
	}

	[Token(Token = "0x17000121")]
	public float scale
	{
		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x89E414", Offset = "0x89E414", VA = "0x89E414")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x89E41C", Offset = "0x89E41C", VA = "0x89E41C")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000122")]
	public Button button
	{
		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x89E424", Offset = "0x89E424", VA = "0x89E424")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000123")]
	public RectTransform rectTransform
	{
		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x89DD14", Offset = "0x89DD14", VA = "0x89DD14")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60005F3")]
	[Address(RVA = "0x89E42C", Offset = "0x89E42C", VA = "0x89E42C")]
	public PhotoFrameListItem()
	{
	}
}
[Token(Token = "0x2000117")]
public class PicGrid : MonoBehaviour
{
	[Token(Token = "0x4000465")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	[FormerlySerializedAs("Image")]
	private RawImage m_Image;

	[Token(Token = "0x4000466")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Graphic _Selected;

	[Token(Token = "0x4000467")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Button mButton;

	[Token(Token = "0x17000124")]
	public bool isChecked
	{
		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x89BDA0", Offset = "0x89BDA0", VA = "0x89BDA0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x89AD18", Offset = "0x89AD18", VA = "0x89AD18")]
		set
		{
		}
	}

	[Token(Token = "0x17000125")]
	public RawImage image
	{
		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x89E434", Offset = "0x89E434", VA = "0x89E434")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000126")]
	public Button button
	{
		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x89B50C", Offset = "0x89B50C", VA = "0x89B50C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60005F8")]
	[Address(RVA = "0x89E43C", Offset = "0x89E43C", VA = "0x89E43C")]
	public PicGrid()
	{
	}
}
[Token(Token = "0x2000118")]
public abstract class PlayableList : MonoBehaviour
{
	[Token(Token = "0x4000468")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected ObjectPool<PlayableListRow> mRowPool;

	[Token(Token = "0x4000469")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected ObjectPool<PlayableListHead> mHeadPool;

	[Token(Token = "0x400046A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected PlayableListRow mTemplateRow;

	[Token(Token = "0x400046B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected PlayableListHead mTemplateHead;

	[Token(Token = "0x400046C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private List<UnityEngine.Object> mItems;

	[Token(Token = "0x400046D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private object lastPlayable;

	[Token(Token = "0x400046E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private PlayableListRow _currentRow;

	[Token(Token = "0x17000127")]
	public PlayableListRow currentRow
	{
		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x89EAA4", Offset = "0x89EAA4", VA = "0x89EAA4")]
		get
		{
			return null;
		}
		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x89EAAC", Offset = "0x89EAAC", VA = "0x89EAAC")]
		set
		{
		}
	}

	[Token(Token = "0x17000128")]
	public abstract object currentPlayble
	{
		[Token(Token = "0x6000600")]
		get;
	}

	[Token(Token = "0x17000129")]
	public abstract bool isPlaying
	{
		[Token(Token = "0x6000601")]
		get;
	}

	[Token(Token = "0x60005F9")]
	[Address(RVA = "0x89E444", Offset = "0x89E444", VA = "0x89E444")]
	private void Awake()
	{
	}

	[Token(Token = "0x60005FA")]
	[Address(RVA = "0x89E874", Offset = "0x89E874", VA = "0x89E874", Slot = "4")]
	protected virtual void OnHeadClicked(PlayableListHead listHead)
	{
	}

	[Token(Token = "0x60005FB")]
	[Address(RVA = "0x89EAA0", Offset = "0x89EAA0", VA = "0x89EAA0", Slot = "5")]
	protected virtual void OnRowClicked(PlayableListRow listRow)
	{
	}

	[Token(Token = "0x60005FC")]
	[Address(RVA = "0x89875C", Offset = "0x89875C", VA = "0x89875C")]
	public PlayableListHead AddHead()
	{
		return null;
	}

	[Token(Token = "0x60005FD")]
	[Address(RVA = "0x898854", Offset = "0x898854", VA = "0x898854")]
	public PlayableListRow AddRow([Optional] PlayableListHead head)
	{
		return null;
	}

	[Token(Token = "0x6000602")]
	[Address(RVA = "0x89EBC4", Offset = "0x89EBC4", VA = "0x89EBC4")]
	public void Update()
	{
	}

	[Token(Token = "0x6000603")]
	[Address(RVA = "0x89ECB4", Offset = "0x89ECB4", VA = "0x89ECB4")]
	public PlayableListRow FindRow(object data)
	{
		return null;
	}

	[Token(Token = "0x6000604")]
	[Address(RVA = "0x899078", Offset = "0x899078", VA = "0x899078")]
	protected PlayableList()
	{
	}
}
[Token(Token = "0x200011C")]
[RequireComponent(typeof(Button))]
public class PlayableListHead : MonoBehaviour
{
	[Token(Token = "0x4000475")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Text _title;

	[Token(Token = "0x4000476")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject _collapsed;

	[Token(Token = "0x4000477")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject _expanded;

	[Token(Token = "0x400047A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool _isOpened;

	[Token(Token = "0x1700012A")]
	public object data
	{
		[Token(Token = "0x6000611")]
		[Address(RVA = "0x89F7AC", Offset = "0x89F7AC", VA = "0x89F7AC")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000612")]
		[Address(RVA = "0x89F7B4", Offset = "0x89F7B4", VA = "0x89F7B4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700012B")]
	public List<PlayableListRow> rows
	{
		[Token(Token = "0x6000613")]
		[Address(RVA = "0x89F7BC", Offset = "0x89F7BC", VA = "0x89F7BC")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000614")]
		[Address(RVA = "0x89F7C4", Offset = "0x89F7C4", VA = "0x89F7C4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700012C")]
	public bool isOpened
	{
		[Token(Token = "0x6000615")]
		[Address(RVA = "0x89F7CC", Offset = "0x89F7CC", VA = "0x89F7CC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000616")]
		[Address(RVA = "0x89E898", Offset = "0x89E898", VA = "0x89E898")]
		set
		{
		}
	}

	[Token(Token = "0x1700012D")]
	public string title
	{
		[Token(Token = "0x6000617")]
		[Address(RVA = "0x89F7D4", Offset = "0x89F7D4", VA = "0x89F7D4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000618")]
		[Address(RVA = "0x898830", Offset = "0x898830", VA = "0x898830")]
		set
		{
		}
	}

	[Token(Token = "0x6000619")]
	[Address(RVA = "0x89F7F8", Offset = "0x89F7F8", VA = "0x89F7F8")]
	public PlayableListHead()
	{
	}
}
[Token(Token = "0x200011D")]
[RequireComponent(typeof(Button))]
public class PlayableListRow : MonoBehaviour
{
	[Token(Token = "0x400047B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Text _title;

	[Token(Token = "0x400047C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Image _playIcon;

	[Token(Token = "0x400047D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject _locker;

	[Token(Token = "0x1700012E")]
	public object data
	{
		[Token(Token = "0x600061A")]
		[Address(RVA = "0x89F800", Offset = "0x89F800", VA = "0x89F800")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600061B")]
		[Address(RVA = "0x89F808", Offset = "0x89F808", VA = "0x89F808")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700012F")]
	public PlayableListHead head
	{
		[Token(Token = "0x600061C")]
		[Address(RVA = "0x89F810", Offset = "0x89F810", VA = "0x89F810")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600061D")]
		[Address(RVA = "0x89F818", Offset = "0x89F818", VA = "0x89F818")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000130")]
	public bool isLocked
	{
		[Token(Token = "0x600061E")]
		[Address(RVA = "0x89F820", Offset = "0x89F820", VA = "0x89F820")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600061F")]
		[Address(RVA = "0x898A70", Offset = "0x898A70", VA = "0x898A70")]
		set
		{
		}
	}

	[Token(Token = "0x17000131")]
	public string title
	{
		[Token(Token = "0x6000621")]
		[Address(RVA = "0x89F848", Offset = "0x89F848", VA = "0x89F848")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000622")]
		[Address(RVA = "0x898A4C", Offset = "0x898A4C", VA = "0x898A4C")]
		set
		{
		}
	}

	[Token(Token = "0x6000620")]
	[Address(RVA = "0x89EB60", Offset = "0x89EB60", VA = "0x89EB60")]
	public void SetPlaying(bool playing)
	{
	}

	[Token(Token = "0x6000623")]
	[Address(RVA = "0x89F86C", Offset = "0x89F86C", VA = "0x89F86C")]
	public PlayableListRow()
	{
	}
}
[Token(Token = "0x200011E")]
public class PlayButtonText : MonoBehaviour
{
	[Token(Token = "0x4000480")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string playText;

	[Token(Token = "0x4000481")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string pauseText;

	[Token(Token = "0x4000482")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Text text;

	[Token(Token = "0x4000483")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public MusicPlayer audioPlayer;

	[Token(Token = "0x6000624")]
	[Address(RVA = "0x89F874", Offset = "0x89F874", VA = "0x89F874")]
	private void Update()
	{
	}

	[Token(Token = "0x6000625")]
	[Address(RVA = "0x89F928", Offset = "0x89F928", VA = "0x89F928")]
	public PlayButtonText()
	{
	}
}
[Token(Token = "0x200011F")]
[RequireComponent(typeof(RectTransform))]
public class SealEditorCanvasMasker : MonoBehaviour
{
	[Token(Token = "0x4000484")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Paper _Paper;

	[Token(Token = "0x4000485")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float _ZOffset;

	[Token(Token = "0x4000486")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float _Aspect;

	[Token(Token = "0x4000487")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private DocumentLayoutElement _Left;

	[Token(Token = "0x4000488")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private DocumentLayoutElement _Middle;

	[Token(Token = "0x4000489")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private DocumentLayoutElement _Right;

	[Token(Token = "0x400048A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private RectTransform _RectTransform;

	[Token(Token = "0x6000626")]
	[Address(RVA = "0x89F930", Offset = "0x89F930", VA = "0x89F930")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000627")]
	[Address(RVA = "0x89F980", Offset = "0x89F980", VA = "0x89F980")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000628")]
	[Address(RVA = "0x89FB60", Offset = "0x89FB60", VA = "0x89FB60")]
	private void Update()
	{
	}

	[Token(Token = "0x6000629")]
	[Address(RVA = "0x89F984", Offset = "0x89F984", VA = "0x89F984")]
	private void UpdateLayout()
	{
	}

	[Token(Token = "0x600062A")]
	[Address(RVA = "0x89FDD0", Offset = "0x89FDD0", VA = "0x89FDD0")]
	public SealEditorCanvasMasker()
	{
	}
}
[Token(Token = "0x2000120")]
public class SealsListController : MonoBehaviour
{
	[Token(Token = "0x400048B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private PaintingsList _List;

	[Token(Token = "0x400048C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Button _ButtonDelete;

	[Token(Token = "0x400048D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Seal mSeal;

	[Token(Token = "0x600062B")]
	[Address(RVA = "0x89FDE4", Offset = "0x89FDE4", VA = "0x89FDE4")]
	private void Start()
	{
	}

	[Token(Token = "0x600062C")]
	[Address(RVA = "0x89FFB8", Offset = "0x89FFB8", VA = "0x89FFB8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600062D")]
	[Address(RVA = "0x8A003C", Offset = "0x8A003C", VA = "0x8A003C")]
	private int GetCurrentSealIndex()
	{
		return default(int);
	}

	[Token(Token = "0x600062E")]
	[Address(RVA = "0x8A0140", Offset = "0x8A0140", VA = "0x8A0140")]
	private void Apply()
	{
	}

	[Token(Token = "0x600062F")]
	[Address(RVA = "0x8A01F4", Offset = "0x8A01F4", VA = "0x8A01F4")]
	public SealsListController()
	{
	}
}
[Token(Token = "0x2000121")]
[RequireComponent(typeof(Image))]
[ExecuteAlways]
public class SliderImageFiller : MonoBehaviour
{
	[Token(Token = "0x400048E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Slider _slider;

	[Token(Token = "0x400048F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float _startFill;

	[Token(Token = "0x4000490")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float _endFill;

	[Token(Token = "0x4000491")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Image mImage;

	[Token(Token = "0x6000634")]
	[Address(RVA = "0x8A02CC", Offset = "0x8A02CC", VA = "0x8A02CC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000635")]
	[Address(RVA = "0x8A032C", Offset = "0x8A032C", VA = "0x8A032C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000636")]
	[Address(RVA = "0x8A03F8", Offset = "0x8A03F8", VA = "0x8A03F8")]
	public SliderImageFiller()
	{
	}
}
[Token(Token = "0x2000122")]
public class UIAchievementList : MonoBehaviour
{
	[Token(Token = "0x4000492")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private UIAchievementListItem _Template;

	[Token(Token = "0x4000493")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int mNewCompletedCount;

	[Token(Token = "0x4000494")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private List<UIAchievementListItem> mItems;

	[Token(Token = "0x6000637")]
	[Address(RVA = "0x8A0400", Offset = "0x8A0400", VA = "0x8A0400")]
	private void Start()
	{
	}

	[Token(Token = "0x6000638")]
	[Address(RVA = "0x8A0C1C", Offset = "0x8A0C1C", VA = "0x8A0C1C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000639")]
	[Address(RVA = "0x8A0C80", Offset = "0x8A0C80", VA = "0x8A0C80")]
	private void Sort()
	{
	}

	[Token(Token = "0x600063A")]
	[Address(RVA = "0x8A0DE8", Offset = "0x8A0DE8", VA = "0x8A0DE8")]
	private void Sort(Func<Achievement, bool> first)
	{
	}

	[Token(Token = "0x600063B")]
	[Address(RVA = "0x8A0F9C", Offset = "0x8A0F9C", VA = "0x8A0F9C")]
	private void Update()
	{
	}

	[Token(Token = "0x600063C")]
	[Address(RVA = "0x8A1014", Offset = "0x8A1014", VA = "0x8A1014")]
	public UIAchievementList()
	{
	}
}
[Token(Token = "0x2000124")]
[RequireComponent(typeof(Animator))]
public class UIAchievementListItem : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
	[Serializable]
	[Token(Token = "0x2000125")]
	private struct ItemButton
	{
		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Image _Background;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Sprite _ForNormalAchivement;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Sprite _ForHiddentAchivement;
	}

	[Token(Token = "0x400049A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Image _ImageIcon;

	[Token(Token = "0x400049B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject _Locker;

	[Token(Token = "0x400049C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject _UnlockHinter;

	[Token(Token = "0x400049D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private TextMeshProUGUI _TextTitle;

	[Token(Token = "0x400049E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private TextMeshProUGUI _TextDescription;

	[Token(Token = "0x400049F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private TextMeshProUGUI _TextProgress;

	[Token(Token = "0x40004A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private TextMeshProUGUI _TextGlobalState;

	[Token(Token = "0x40004A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private GameObject _IconFromCloud;

	[Token(Token = "0x40004A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Image _CoverImage;

	[Token(Token = "0x40004A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private AudioClip _UnlockSound;

	[Token(Token = "0x40004A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private ItemButton _ItemButton;

	[Token(Token = "0x40004A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Regex mRegex;

	[Token(Token = "0x40004A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Achievement mAchievement;

	[Token(Token = "0x40004A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Animator mAnimator;

	[Token(Token = "0x40004A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private bool mIsDirty;

	[Token(Token = "0x40004A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private int mFlags;

	[Token(Token = "0x17000132")]
	public Achievement achievement
	{
		[Token(Token = "0x6000643")]
		[Address(RVA = "0x8A1170", Offset = "0x8A1170", VA = "0x8A1170")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000644")]
	[Address(RVA = "0x8A1178", Offset = "0x8A1178", VA = "0x8A1178")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000645")]
	[Address(RVA = "0x8A1248", Offset = "0x8A1248", VA = "0x8A1248")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000646")]
	[Address(RVA = "0x8A12EC", Offset = "0x8A12EC", VA = "0x8A12EC")]
	private void LanguageUtils_onLanguageChanged(string obj)
	{
	}

	[Token(Token = "0x6000647")]
	[Address(RVA = "0x8A0B14", Offset = "0x8A0B14", VA = "0x8A0B14")]
	public void OnInit(UIAchievementList list, Achievement achievement)
	{
	}

	[Token(Token = "0x6000648")]
	[Address(RVA = "0x8A12F8", Offset = "0x8A12F8", VA = "0x8A12F8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000649")]
	[Address(RVA = "0x8A1304", Offset = "0x8A1304", VA = "0x8A1304")]
	private void Update()
	{
	}

	[Token(Token = "0x600064A")]
	[Address(RVA = "0x8A131C", Offset = "0x8A131C", VA = "0x8A131C")]
	private void UpdateState()
	{
	}

	[Token(Token = "0x600064B")]
	[Address(RVA = "0x8A143C", Offset = "0x8A143C", VA = "0x8A143C")]
	private void UpdateItem()
	{
	}

	[Token(Token = "0x600064C")]
	[Address(RVA = "0x8A1C08", Offset = "0x8A1C08", VA = "0x8A1C08", Slot = "4")]
	public void OnPointerClick(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600064D")]
	[Address(RVA = "0x8A1CF0", Offset = "0x8A1CF0", VA = "0x8A1CF0")]
	public UIAchievementListItem()
	{
	}
}
[Token(Token = "0x2000126")]
public class UIAchievementNewCount : MonoBehaviour
{
	[Token(Token = "0x40004AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private TextMeshProUGUI _Text;

	[Token(Token = "0x40004AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject _Panel;

	[Token(Token = "0x40004AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int mOldCount;

	[Token(Token = "0x600064F")]
	[Address(RVA = "0x8A1D90", Offset = "0x8A1D90", VA = "0x8A1D90")]
	private void Update()
	{
	}

	[Token(Token = "0x6000650")]
	[Address(RVA = "0x8A1EA0", Offset = "0x8A1EA0", VA = "0x8A1EA0")]
	public UIAchievementNewCount()
	{
	}
}
[Token(Token = "0x2000127")]
public class UIAnimationMenu : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000128")]
	public class SelectionChangedEvent : UnityEvent<int>
	{
		[Token(Token = "0x600065D")]
		[Address(RVA = "0x8A2614", Offset = "0x8A2614", VA = "0x8A2614")]
		public SelectionChangedEvent()
		{
		}
	}

	[NonSerialized]
	[Token(Token = "0x40004B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<GameObject> menus;

	[Token(Token = "0x40004B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool inactiveMenusOnInit;

	[Token(Token = "0x40004B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string inAnimation;

	[Token(Token = "0x40004B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string outAnimation;

	[Token(Token = "0x40004B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject firstSelection;

	[Token(Token = "0x40004B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public SelectionChangedEvent selectionChanged;

	[Token(Token = "0x40004B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private GameObject mSelectedMenu;

	[Token(Token = "0x17000133")]
	public GameObject selectedMenu
	{
		[Token(Token = "0x6000651")]
		[Address(RVA = "0x8A1EB0", Offset = "0x8A1EB0", VA = "0x8A1EB0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000652")]
		[Address(RVA = "0x8A1EB8", Offset = "0x8A1EB8", VA = "0x8A1EB8")]
		set
		{
		}
	}

	[Token(Token = "0x17000134")]
	public int selectedIndex
	{
		[Token(Token = "0x600065A")]
		[Address(RVA = "0x8A2254", Offset = "0x8A2254", VA = "0x8A2254")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600065B")]
		[Address(RVA = "0x8A2564", Offset = "0x8A2564", VA = "0x8A2564")]
		set
		{
		}
	}

	[Token(Token = "0x6000653")]
	[Address(RVA = "0x8A2104", Offset = "0x8A2104", VA = "0x8A2104")]
	private void MenuIn(GameObject target)
	{
	}

	[Token(Token = "0x6000654")]
	[Address(RVA = "0x8A1FA8", Offset = "0x8A1FA8", VA = "0x8A1FA8")]
	private void MenuOut(GameObject target)
	{
	}

	[Token(Token = "0x6000655")]
	[Address(RVA = "0x8A22A8", Offset = "0x8A22A8", VA = "0x8A22A8")]
	public void Awake()
	{
	}

	[Token(Token = "0x6000656")]
	[Address(RVA = "0x8A23F4", Offset = "0x8A23F4", VA = "0x8A23F4")]
	public void Start()
	{
	}

	[Token(Token = "0x6000657")]
	[Address(RVA = "0x8A246C", Offset = "0x8A246C", VA = "0x8A246C")]
	public void Select(int index)
	{
	}

	[Token(Token = "0x6000658")]
	[Address(RVA = "0x8A24F8", Offset = "0x8A24F8", VA = "0x8A24F8")]
	public void SelectNext()
	{
	}

	[Token(Token = "0x6000659")]
	[Address(RVA = "0x8A2568", Offset = "0x8A2568", VA = "0x8A2568")]
	public void SelectPre()
	{
	}

	[Token(Token = "0x600065C")]
	[Address(RVA = "0x8A2590", Offset = "0x8A2590", VA = "0x8A2590")]
	public UIAnimationMenu()
	{
	}
}
[Token(Token = "0x2000129")]
[RequireComponent(typeof(AudioSource))]
[SingletonOption(autoCreate = true, resource = "Prefabs/UIAudioSource")]
public class UIAudioSource : SingletonGameObject<UIAudioSource>
{
	[Token(Token = "0x40004B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private AudioSource mAudioSouce;

	[Token(Token = "0x17000135")]
	public static AudioSource audioSource
	{
		[Token(Token = "0x600065F")]
		[Address(RVA = "0x8971B8", Offset = "0x8971B8", VA = "0x8971B8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000136")]
	protected override bool dontDestroyOnLoad
	{
		[Token(Token = "0x6000660")]
		[Address(RVA = "0x8A2720", Offset = "0x8A2720", VA = "0x8A2720", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600065E")]
	[Address(RVA = "0x8A265C", Offset = "0x8A265C", VA = "0x8A265C", Slot = "5")]
	protected override void OnAwake()
	{
	}

	[Token(Token = "0x6000661")]
	[Address(RVA = "0x8A2728", Offset = "0x8A2728", VA = "0x8A2728")]
	public UIAudioSource()
	{
	}
}
[Token(Token = "0x200012A")]
public class UICopybookDirectoryList : MonoBehaviour
{
	[Token(Token = "0x40004B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Stack<UICopybookDirectoryListTemplate> mItemsPool;

	[Token(Token = "0x40004B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private UICopybookDirectoryListTemplate mUICopybookDirectoryListTemplate;

	[Token(Token = "0x40004BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private string mCurrentPath;

	[Token(Token = "0x40004BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private string CopybookPath;

	[Token(Token = "0x6000662")]
	[Address(RVA = "0x8A2770", Offset = "0x8A2770", VA = "0x8A2770")]
	private UICopybookDirectoryListTemplate getNewUICopybookDirectoryListTemplate()
	{
		return null;
	}

	[Token(Token = "0x6000663")]
	[Address(RVA = "0x8A2880", Offset = "0x8A2880", VA = "0x8A2880")]
	private void Recycle(UICopybookDirectoryListTemplate template)
	{
	}

	[Token(Token = "0x6000664")]
	[Address(RVA = "0x8A2908", Offset = "0x8A2908", VA = "0x8A2908")]
	public void OnItemClicked(UICopybookDirectoryListTemplate template)
	{
	}

	[Token(Token = "0x6000665")]
	[Address(RVA = "0x8A2A28", Offset = "0x8A2A28", VA = "0x8A2A28")]
	public void OpenPath(string path)
	{
	}

	[Token(Token = "0x6000666")]
	[Address(RVA = "0x8A2C88", Offset = "0x8A2C88", VA = "0x8A2C88")]
	public void Back()
	{
	}

	[Token(Token = "0x6000667")]
	[Address(RVA = "0x8A2D1C", Offset = "0x8A2D1C", VA = "0x8A2D1C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000668")]
	[Address(RVA = "0x8A2EE4", Offset = "0x8A2EE4", VA = "0x8A2EE4")]
	public UICopybookDirectoryList()
	{
	}
}
[Token(Token = "0x200012B")]
public class UICopybookDirectoryListTemplate : MonoBehaviour
{
	[Token(Token = "0x40004BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text uiText;

	[Token(Token = "0x17000137")]
	public string text
	{
		[Token(Token = "0x600066B")]
		[Address(RVA = "0x8A2A04", Offset = "0x8A2A04", VA = "0x8A2A04")]
		get
		{
			return null;
		}
		[Token(Token = "0x600066C")]
		[Address(RVA = "0x8A2C64", Offset = "0x8A2C64", VA = "0x8A2C64")]
		set
		{
		}
	}

	[Token(Token = "0x600066D")]
	[Address(RVA = "0x8A2F84", Offset = "0x8A2F84", VA = "0x8A2F84")]
	public void OnClicked()
	{
	}

	[Token(Token = "0x600066E")]
	[Address(RVA = "0x8A2FD8", Offset = "0x8A2FD8", VA = "0x8A2FD8")]
	public UICopybookDirectoryListTemplate()
	{
	}
}
[Token(Token = "0x200012C")]
[RequireComponent(typeof(RectTransform))]
public class UICullInvisibleItem : MonoBehaviour
{
	[Token(Token = "0x40004BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private bool _CullAnimation;

	[Token(Token = "0x40004BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<Graphic> mGraphics;

	[Token(Token = "0x40004BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private ScrollRect mScrollRect;

	[Token(Token = "0x40004C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool mVisible;

	[Token(Token = "0x40004C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	private bool mDirty;

	[Token(Token = "0x40004C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
	private bool mInitedAnimation;

	[Token(Token = "0x40004C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Vector3 mLocalPosition;

	[Token(Token = "0x40004C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private RectTransform mTransform;

	[Token(Token = "0x40004C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Animator mAnimator;

	[Token(Token = "0x40004C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float mStartTime;

	[Token(Token = "0x600066F")]
	[Address(RVA = "0x8A2FE0", Offset = "0x8A2FE0", VA = "0x8A2FE0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000670")]
	[Address(RVA = "0x8A312C", Offset = "0x8A312C", VA = "0x8A312C")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000671")]
	[Address(RVA = "0x8A31DC", Offset = "0x8A31DC", VA = "0x8A31DC")]
	private void UpdateVisible()
	{
	}

	[Token(Token = "0x6000672")]
	[Address(RVA = "0x8A35A0", Offset = "0x8A35A0", VA = "0x8A35A0")]
	private void OnRectTransformDimensionsChange()
	{
	}

	[Token(Token = "0x6000673")]
	[Address(RVA = "0x8A35AC", Offset = "0x8A35AC", VA = "0x8A35AC")]
	public UICullInvisibleItem()
	{
	}
}
[Token(Token = "0x200012D")]
public class UIHoverTransform : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	[Token(Token = "0x40004C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform _target;

	[Token(Token = "0x40004C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Vector3 _targetLocalPosition;

	[Token(Token = "0x40004C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private Vector3 _targetLocalRotation;

	[Token(Token = "0x40004CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Vector3 _targetLocalScale;

	[Token(Token = "0x40004CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[SerializeField]
	private float _smooth;

	[Token(Token = "0x40004CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Vector3 mInitLocalPosition;

	[Token(Token = "0x40004CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private Quaternion mInitLocalRotation;

	[Token(Token = "0x40004CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private Vector3 mInitLocalScale;

	[Token(Token = "0x40004CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private int mPointerCount;

	[Token(Token = "0x6000675")]
	[Address(RVA = "0x8A3644", Offset = "0x8A3644", VA = "0x8A3644")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000676")]
	[Address(RVA = "0x8A36A0", Offset = "0x8A36A0", VA = "0x8A36A0", Slot = "4")]
	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000677")]
	[Address(RVA = "0x8A36B0", Offset = "0x8A36B0", VA = "0x8A36B0", Slot = "5")]
	public void OnPointerExit(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000678")]
	[Address(RVA = "0x8A36C0", Offset = "0x8A36C0", VA = "0x8A36C0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000679")]
	[Address(RVA = "0x8A38A8", Offset = "0x8A38A8", VA = "0x8A38A8")]
	public UIHoverTransform()
	{
	}
}
[Token(Token = "0x200012E")]
public class UILevelList : MonoBehaviour, IScrollHandler, IEventSystemHandler
{
	[Serializable]
	[Token(Token = "0x200012F")]
	public class OnSelectedEvent : UnityEvent<int>
	{
		[Token(Token = "0x600068E")]
		[Address(RVA = "0x8A4924", Offset = "0x8A4924", VA = "0x8A4924")]
		public OnSelectedEvent()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000130")]
	private struct ListPosition
	{
		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public GameObject start;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public GameObject middle;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject end;
	}

	[Token(Token = "0x40004D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private AudioClip _AudioPaging;

	[Token(Token = "0x40004D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AudioClip _AudioClick;

	[Token(Token = "0x40004D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private List<GameObject> _contents;

	[Token(Token = "0x40004D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private ListPosition _targetPositon;

	[Token(Token = "0x40004D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private ListPosition _startPositon;

	[Token(Token = "0x40004D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private AnimationCurve _PositionCurve;

	[Token(Token = "0x40004D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private float _smooth;

	[Token(Token = "0x40004D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private HorizontalScrollHandler _Scroll;

	[Token(Token = "0x40004D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private OnSelectedEvent _selected;

	[Token(Token = "0x40004D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private OnSelectedEvent _onSelectedClicked;

	[Token(Token = "0x40004DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private int mSelectedIndex;

	[Token(Token = "0x40004DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private GameObject mTmp;

	[Token(Token = "0x40004DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private int mDefaultSelectedIndex;

	[Token(Token = "0x17000138")]
	public OnSelectedEvent onSelectedClicked
	{
		[Token(Token = "0x600067A")]
		[Address(RVA = "0x8A38B8", Offset = "0x8A38B8", VA = "0x8A38B8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000139")]
	public OnSelectedEvent onSelected
	{
		[Token(Token = "0x600067B")]
		[Address(RVA = "0x8A38C0", Offset = "0x8A38C0", VA = "0x8A38C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700013A")]
	public int selectedIndex
	{
		[Token(Token = "0x600067C")]
		[Address(RVA = "0x8A38C8", Offset = "0x8A38C8", VA = "0x8A38C8")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600067D")]
		[Address(RVA = "0x8A38D0", Offset = "0x8A38D0", VA = "0x8A38D0")]
		set
		{
		}
	}

	[Token(Token = "0x1700013B")]
	public IReadOnlyList<GameObject> contents
	{
		[Token(Token = "0x600067E")]
		[Address(RVA = "0x8A3A38", Offset = "0x8A3A38", VA = "0x8A3A38")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600067F")]
	[Address(RVA = "0x8A3A40", Offset = "0x8A3A40", VA = "0x8A3A40")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000680")]
	[Address(RVA = "0x8A3ED8", Offset = "0x8A3ED8", VA = "0x8A3ED8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000681")]
	[Address(RVA = "0x8A3F98", Offset = "0x8A3F98", VA = "0x8A3F98")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000682")]
	[Address(RVA = "0x8A4020", Offset = "0x8A4020", VA = "0x8A4020")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000683")]
	[Address(RVA = "0x8A4050", Offset = "0x8A4050", VA = "0x8A4050", Slot = "4")]
	public void OnScroll(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000684")]
	[Address(RVA = "0x8A40E8", Offset = "0x8A40E8", VA = "0x8A40E8")]
	private void Scroll(float dir)
	{
	}

	[Token(Token = "0x6000685")]
	[Address(RVA = "0x8A3F68", Offset = "0x8A3F68", VA = "0x8A3F68")]
	public void ResetPosition()
	{
	}

	[Token(Token = "0x6000686")]
	[Address(RVA = "0x8A42A4", Offset = "0x8A42A4", VA = "0x8A42A4")]
	public void Select(GameObject go)
	{
	}

	[Token(Token = "0x6000687")]
	[Address(RVA = "0x8A38D4", Offset = "0x8A38D4", VA = "0x8A38D4")]
	public void Select(int index)
	{
	}

	[Token(Token = "0x6000688")]
	[Address(RVA = "0x8A4308", Offset = "0x8A4308", VA = "0x8A4308")]
	private void Update()
	{
	}

	[Token(Token = "0x6000689")]
	[Address(RVA = "0x8A4338", Offset = "0x8A4338", VA = "0x8A4338")]
	private void SetContentPositionSmooth(ListPosition listPosition, int selectedIndex)
	{
	}

	[Token(Token = "0x600068A")]
	[Address(RVA = "0x8A4100", Offset = "0x8A4100", VA = "0x8A4100")]
	private void SetContentPosition(ListPosition listPosition, int selectedIndex)
	{
	}

	[Token(Token = "0x600068B")]
	[Address(RVA = "0x8A4528", Offset = "0x8A4528", VA = "0x8A4528")]
	private void Lerp(GameObject from, GameObject to, GameObject target, float k)
	{
	}

	[Token(Token = "0x600068C")]
	[Address(RVA = "0x8A44E4", Offset = "0x8A44E4", VA = "0x8A44E4")]
	private void LerpSmooth(GameObject from, GameObject to, GameObject target, float k)
	{
	}

	[Token(Token = "0x600068D")]
	[Address(RVA = "0x8A4744", Offset = "0x8A4744", VA = "0x8A4744")]
	public UILevelList()
	{
	}
}
[Token(Token = "0x2000132")]
public class UIPanelSavePainting : MonoBehaviour
{
	[Token(Token = "0x40004E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Button _ButtonSave;

	[Token(Token = "0x40004E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private PhotoFrameList _ListPhotoFrame;

	[Token(Token = "0x6000691")]
	[Address(RVA = "0x8A4AEC", Offset = "0x8A4AEC", VA = "0x8A4AEC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000692")]
	[Address(RVA = "0x8A4BC8", Offset = "0x8A4BC8", VA = "0x8A4BC8")]
	public void SaveWithNoPhotoFrame()
	{
	}

	[Token(Token = "0x6000693")]
	[Address(RVA = "0x8A4BD0", Offset = "0x8A4BD0", VA = "0x8A4BD0")]
	private void Save(PhotoFrameListItem selectedItem)
	{
	}

	[Token(Token = "0x6000694")]
	[Address(RVA = "0x8A50F8", Offset = "0x8A50F8", VA = "0x8A50F8")]
	public UIPanelSavePainting()
	{
	}
}
[Token(Token = "0x2000134")]
public class UIRecording : MonoBehaviour
{
	[Token(Token = "0x40004E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Header("[Button RecordingMode_Play]")]
	private Button _ButtonPlay;

	[Token(Token = "0x40004E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Header("[Button RecordingMode_Recording]")]
	[SerializeField]
	private Button _ButtonRecording;

	[Token(Token = "0x40004EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Header("[Button RecordingMode_Stop]")]
	[SerializeField]
	private Button _ButtonStop;

	[Token(Token = "0x40004EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private AnimationInvoker _ButtonAnimationIdle;

	[Token(Token = "0x40004EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private AnimationInvoker _ButtonAnimationRecording;

	[Token(Token = "0x40004ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private BrushRecorder _BrushRecorder;

	[Token(Token = "0x40004EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private TextSetter mTextSetterRecording;

	[Token(Token = "0x40004EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool mIsRecoding;

	[Token(Token = "0x6000698")]
	[Address(RVA = "0x8A53A8", Offset = "0x8A53A8", VA = "0x8A53A8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000699")]
	[Address(RVA = "0x8A5690", Offset = "0x8A5690", VA = "0x8A5690")]
	private void Update()
	{
	}

	[Token(Token = "0x600069A")]
	[Address(RVA = "0x8A58FC", Offset = "0x8A58FC", VA = "0x8A58FC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600069B")]
	[Address(RVA = "0x8A59BC", Offset = "0x8A59BC", VA = "0x8A59BC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600069C")]
	[Address(RVA = "0x8A5A14", Offset = "0x8A5A14", VA = "0x8A5A14")]
	public UIRecording()
	{
	}
}
[Token(Token = "0x2000135")]
[RequireComponent(typeof(AudioSource))]
public class UISoundPlayer : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000136")]
	public struct Sound
	{
		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string key;

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AudioClip clip;
	}

	[Token(Token = "0x40004F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Sound[] sounds;

	[Token(Token = "0x40004F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private AudioSource mAudio;

	[Token(Token = "0x40004F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static UISoundPlayer mInstance;

	[Token(Token = "0x600069F")]
	[Address(RVA = "0x8A5B1C", Offset = "0x8A5B1C", VA = "0x8A5B1C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60006A0")]
	[Address(RVA = "0x8A5C30", Offset = "0x8A5C30", VA = "0x8A5C30")]
	public static void PlaySound(string key)
	{
	}

	[Token(Token = "0x60006A1")]
	[Address(RVA = "0x8A5DD0", Offset = "0x8A5DD0", VA = "0x8A5DD0")]
	public UISoundPlayer()
	{
	}
}
[Token(Token = "0x2000137")]
public class UIStudyRoom_MenuBar_Main : MonoBehaviour
{
	[Token(Token = "0x40004F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Button _ButtonQuit;

	[Token(Token = "0x40004F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Button _ButtonUserTemplates;

	[Token(Token = "0x40004F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Button _ButtonAchievement;

	[Token(Token = "0x60006A2")]
	[Address(RVA = "0x8A5DD8", Offset = "0x8A5DD8", VA = "0x8A5DD8")]
	private void Start()
	{
	}

	[Token(Token = "0x60006A3")]
	[Address(RVA = "0x8A5F18", Offset = "0x8A5F18", VA = "0x8A5F18")]
	private void Update()
	{
	}

	[Token(Token = "0x60006A4")]
	[Address(RVA = "0x8A6078", Offset = "0x8A6078", VA = "0x8A6078")]
	public UIStudyRoom_MenuBar_Main()
	{
	}
}
[Token(Token = "0x2000139")]
public class UIStudyRoom_MenuBar_Tools : MonoBehaviour
{
	[Token(Token = "0x40004FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Button buttonShowMask;

	[Token(Token = "0x40004FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Button buttonGrading;

	[Token(Token = "0x40004FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Button buttonClear;

	[Token(Token = "0x40004FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Button buttonUndo;

	[Token(Token = "0x40004FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Button buttonRedo;

	[Token(Token = "0x40004FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Button buttonSetMovieTempalte;

	[Token(Token = "0x4000500")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public MenuPanel panelMovies;

	[Token(Token = "0x4000501")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Button _ButtonPlay;

	[Token(Token = "0x4000502")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Button _ButtonStop;

	[Token(Token = "0x4000503")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Button _ButtonRecording;

	[Token(Token = "0x4000504")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private BrushRecorder mBrushRecorder;

	[Token(Token = "0x60006A8")]
	[Address(RVA = "0x8A613C", Offset = "0x8A613C", VA = "0x8A613C")]
	private void Start()
	{
	}

	[Token(Token = "0x60006A9")]
	[Address(RVA = "0x8A6804", Offset = "0x8A6804", VA = "0x8A6804")]
	private void Update()
	{
	}

	[Token(Token = "0x60006AA")]
	[Address(RVA = "0x8A6DE0", Offset = "0x8A6DE0", VA = "0x8A6DE0")]
	public UIStudyRoom_MenuBar_Tools()
	{
	}
}
[Token(Token = "0x200013B")]
public class VideoPlayerController : MediaPlayerController
{
	[Token(Token = "0x400050C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private bool mNeedReplayOnEnable;

	[Token(Token = "0x1700013C")]
	protected override MediaPlayer mediaPlayer
	{
		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x8A760C", Offset = "0x8A760C", VA = "0x8A760C", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60006B7")]
	[Address(RVA = "0x8A767C", Offset = "0x8A767C", VA = "0x8A767C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60006B8")]
	[Address(RVA = "0x8A775C", Offset = "0x8A775C", VA = "0x8A775C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60006B9")]
	[Address(RVA = "0x8A78A8", Offset = "0x8A78A8", VA = "0x8A78A8")]
	public VideoPlayerController()
	{
	}
}
[Token(Token = "0x200013C")]
public static class AndroidUtils
{
	[Token(Token = "0x1700013D")]
	public static bool isAndroidDevice
	{
		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x8A79F4", Offset = "0x8A79F4", VA = "0x8A79F4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60006BA")]
	[Address(RVA = "0x8A78BC", Offset = "0x8A78BC", VA = "0x8A78BC")]
	public static int GetSDKLevel()
	{
		return default(int);
	}
}
[Token(Token = "0x200013D")]
public static class BinaryWriterExtension
{
	[Token(Token = "0x60006BC")]
	[Address(RVA = "0x8A7A10", Offset = "0x8A7A10", VA = "0x8A7A10")]
	public static void Write(this BinaryWriter bw, Vector3 v)
	{
	}

	[Token(Token = "0x60006BD")]
	[Address(RVA = "0x8A7A74", Offset = "0x8A7A74", VA = "0x8A7A74")]
	public static void Write(this BinaryWriter bw, Quaternion q)
	{
	}

	[Token(Token = "0x60006BE")]
	[Address(RVA = "0x8A7AFC", Offset = "0x8A7AFC", VA = "0x8A7AFC")]
	public static void Write(this BinaryWriter bw, Color c)
	{
	}

	[Token(Token = "0x60006BF")]
	[Address(RVA = "0x8A7B84", Offset = "0x8A7B84", VA = "0x8A7B84")]
	[Obsolete]
	public static void Write(this BinaryWriter bw, AnimationCurve ac)
	{
	}

	[Token(Token = "0x60006C0")]
	[Address(RVA = "0x8A7D8C", Offset = "0x8A7D8C", VA = "0x8A7D8C")]
	[Obsolete]
	public static AnimationCurve ReadAnimationCurve(this BinaryReader br)
	{
		return null;
	}

	[Token(Token = "0x60006C1")]
	[Address(RVA = "0x8A7F4C", Offset = "0x8A7F4C", VA = "0x8A7F4C")]
	public static Vector3 ReadVector3(this BinaryReader br)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60006C2")]
	[Address(RVA = "0x8A7FB8", Offset = "0x8A7FB8", VA = "0x8A7FB8")]
	public static Quaternion ReadQuaternion(this BinaryReader br)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x60006C3")]
	[Address(RVA = "0x8A8048", Offset = "0x8A8048", VA = "0x8A8048")]
	public static Color ReadColor(this BinaryReader br)
	{
		return default(Color);
	}
}
[Token(Token = "0x200013E")]
public static class ReflactUtils
{
	[Token(Token = "0x60006C4")]
	[Address(RVA = "0x8A80B8", Offset = "0x8A80B8", VA = "0x8A80B8")]
	public static void SetField(object obj, string name, object value)
	{
	}

	[Token(Token = "0x60006C5")]
	[Address(RVA = "0x8A8108", Offset = "0x8A8108", VA = "0x8A8108")]
	public static void Invoke(object obj, string name, params object[] args)
	{
	}
}
[Token(Token = "0x200013F")]
[SingletonOption(resource = "Prefabs/ViewNavigation")]
[RequireComponent(typeof(Canvas))]
public class ViewNavigation : SingletonGameObject<ViewNavigation>
{
	[Token(Token = "0x400050D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform hintObject;

	[Token(Token = "0x400050E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform hintArrow;

	[Token(Token = "0x400050F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public AnimationCurve raduis;

	[Token(Token = "0x4000510")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float raduisScale;

	[Token(Token = "0x4000511")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float depth;

	[Token(Token = "0x4000512")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float redio;

	[Token(Token = "0x4000513")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float clampXAngle;

	[Token(Token = "0x4000514")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float clampYAngle;

	[Token(Token = "0x4000515")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float screenOutX;

	[Token(Token = "0x4000516")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float screenOutY;

	[Token(Token = "0x4000517")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float minDistance;

	[Token(Token = "0x4000518")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Canvas mCanvas;

	[Token(Token = "0x60006C6")]
	[Address(RVA = "0x8A823C", Offset = "0x8A823C", VA = "0x8A823C")]
	private void Start()
	{
	}

	[Token(Token = "0x60006C7")]
	[Address(RVA = "0x8A828C", Offset = "0x8A828C", VA = "0x8A828C")]
	private void Update()
	{
	}

	[Token(Token = "0x60006C8")]
	[Address(RVA = "0x8A8950", Offset = "0x8A8950", VA = "0x8A8950")]
	public ViewNavigation()
	{
	}
}
[Token(Token = "0x2000140")]
public class VRPlatformGameObjectActiver : MonoBehaviour
{
	[Token(Token = "0x4000519")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private VRPlatform.PlatformTarget[] _targetPlatforms;

	[Token(Token = "0x400051A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject[] _Targets;

	[Token(Token = "0x60006C9")]
	[Address(RVA = "0x8A89B0", Offset = "0x8A89B0", VA = "0x8A89B0")]
	private void Update()
	{
	}

	[Token(Token = "0x60006CA")]
	[Address(RVA = "0x8A8AE0", Offset = "0x8A8AE0", VA = "0x8A8AE0")]
	public VRPlatformGameObjectActiver()
	{
	}
}
[Token(Token = "0x2000141")]
public class WordTemplate : MonoBehaviour
{
	[Token(Token = "0x60006CB")]
	[Address(RVA = "0x8A8AE8", Offset = "0x8A8AE8", VA = "0x8A8AE8")]
	public void OnPagerClicked(GalleryPanel o, int index)
	{
	}

	[Token(Token = "0x60006CC")]
	[Address(RVA = "0x8A8D00", Offset = "0x8A8D00", VA = "0x8A8D00")]
	public WordTemplate()
	{
	}
}
[Token(Token = "0x2000142")]
public class AddToGameObject : MonoBehaviour
{
	[Token(Token = "0x400051B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private string _GameObejctName;

	[Token(Token = "0x60006CD")]
	[Address(RVA = "0x8A8D08", Offset = "0x8A8D08", VA = "0x8A8D08")]
	private void Awake()
	{
	}

	[Token(Token = "0x60006CE")]
	[Address(RVA = "0x8A8D58", Offset = "0x8A8D58", VA = "0x8A8D58")]
	public AddToGameObject()
	{
	}
}
[Token(Token = "0x2000143")]
public class DengLongSpawner : MonoBehaviour
{
	[Token(Token = "0x2000144")]
	[CompilerGenerated]
	private sealed class <Run>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DengLongSpawner <>4__this;

		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <deltaTime>5__2;

		[Token(Token = "0x1700013E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60006D5")]
			[Address(RVA = "0x8A9378", Offset = "0x8A9378", VA = "0x8A9378", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700013F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006D7")]
			[Address(RVA = "0x8A93C0", Offset = "0x8A93C0", VA = "0x8A93C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x8A8DE8", Offset = "0x8A8DE8", VA = "0x8A8DE8")]
		[DebuggerHidden]
		public <Run>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x8A8E34", Offset = "0x8A8E34", VA = "0x8A8E34", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x8A8E38", Offset = "0x8A8E38", VA = "0x8A8E38", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x8A9380", Offset = "0x8A9380", VA = "0x8A9380", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400051C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject _PrefabDengLong;

	[Token(Token = "0x400051D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Vector2 _DeltaTime;

	[Token(Token = "0x400051E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Vector2 _Duration;

	[Token(Token = "0x400051F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Vector2 _SpeedRange;

	[Token(Token = "0x60006CF")]
	[Address(RVA = "0x8A8D60", Offset = "0x8A8D60", VA = "0x8A8D60")]
	private void Awake()
	{
	}

	[Token(Token = "0x60006D0")]
	[Address(RVA = "0x8A8D80", Offset = "0x8A8D80", VA = "0x8A8D80")]
	[IteratorStateMachine(typeof(<Run>d__5))]
	private IEnumerator Run()
	{
		return null;
	}

	[Token(Token = "0x60006D1")]
	[Address(RVA = "0x8A8E10", Offset = "0x8A8E10", VA = "0x8A8E10")]
	public DengLongSpawner()
	{
	}
}
[Token(Token = "0x2000145")]
public class FloatingLantern : MonoBehaviour
{
	[Token(Token = "0x4000524")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Renderer[] _Renderers;

	[Token(Token = "0x4000525")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private LanternLight _LanternLight;

	[Token(Token = "0x4000526")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float _Duration;

	[Token(Token = "0x4000527")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float _Speed;

	[Token(Token = "0x4000528")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private AnimationCurve _SpeedCurve;

	[Token(Token = "0x4000529")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private AnimationCurve _AlphaCurve;

	[Token(Token = "0x400052A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float mTime;

	[Token(Token = "0x17000140")]
	public float duration
	{
		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x8A93C8", Offset = "0x8A93C8", VA = "0x8A93C8")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x8A93D0", Offset = "0x8A93D0", VA = "0x8A93D0")]
		set
		{
		}
	}

	[Token(Token = "0x17000141")]
	public float speed
	{
		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x8A93D8", Offset = "0x8A93D8", VA = "0x8A93D8")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x8A93E0", Offset = "0x8A93E0", VA = "0x8A93E0")]
		set
		{
		}
	}

	[Token(Token = "0x17000142")]
	public float currentTime
	{
		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x8A93E8", Offset = "0x8A93E8", VA = "0x8A93E8")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x8A93F0", Offset = "0x8A93F0", VA = "0x8A93F0")]
		set
		{
		}
	}

	[Token(Token = "0x60006DE")]
	[Address(RVA = "0x8A93F8", Offset = "0x8A93F8", VA = "0x8A93F8")]
	private void Start()
	{
	}

	[Token(Token = "0x60006DF")]
	[Address(RVA = "0x8A90F0", Offset = "0x8A90F0", VA = "0x8A90F0")]
	public void Update()
	{
	}

	[Token(Token = "0x60006E0")]
	[Address(RVA = "0x8A94B0", Offset = "0x8A94B0", VA = "0x8A94B0")]
	public FloatingLantern()
	{
	}
}
[Token(Token = "0x2000146")]
[RequireComponent(typeof(SpriteRenderer))]
public class LanternLight : MonoBehaviour
{
	[Token(Token = "0x400052B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Range(0f, 1f)]
	private float _Alpha;

	[Token(Token = "0x400052C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Range(0f, 1f)]
	[SerializeField]
	private float _MaxAlpha;

	[Token(Token = "0x400052D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Transform _Origin;

	[Token(Token = "0x400052E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float _Distance;

	[Token(Token = "0x400052F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float _AlphaToScalePower;

	[Token(Token = "0x4000530")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private SpriteRenderer mSpriteRenderer;

	[Token(Token = "0x4000531")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector3 _LocalScale;

	[Token(Token = "0x17000143")]
	public float alpha
	{
		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x8A96D0", Offset = "0x8A96D0", VA = "0x8A96D0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x8A96D8", Offset = "0x8A96D8", VA = "0x8A96D8")]
		set
		{
		}
	}

	[Token(Token = "0x60006E3")]
	[Address(RVA = "0x8A96E0", Offset = "0x8A96E0", VA = "0x8A96E0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60006E4")]
	[Address(RVA = "0x8A9754", Offset = "0x8A9754", VA = "0x8A9754")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60006E5")]
	[Address(RVA = "0x8A9ABC", Offset = "0x8A9ABC", VA = "0x8A9ABC")]
	public LanternLight()
	{
	}
}
[Token(Token = "0x2000147")]
[DefaultExecutionOrder(-10)]
public class MidAutumnFestivalController : MonoBehaviour
{
	[Token(Token = "0x4000532")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private bool _TryEnablePostProcessing;

	[Token(Token = "0x4000533")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject[] _ObjectForNormal;

	[Token(Token = "0x4000534")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject[] _ObjectForFestival;

	[Token(Token = "0x4000535")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject[] _HideForFestival;

	[Token(Token = "0x4000536")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Material _SkyBoxForNormal;

	[Token(Token = "0x4000537")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Material _SkyBoxForFestival;

	[Token(Token = "0x4000538")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool sCurrentSupportPostProcessing;

	[Token(Token = "0x60006E6")]
	[Address(RVA = "0x8A9AD4", Offset = "0x8A9AD4", VA = "0x8A9AD4")]
	private void Awake()
	{
	}

	[Token(Token = "0x60006E7")]
	[Address(RVA = "0x8A9E70", Offset = "0x8A9E70", VA = "0x8A9E70")]
	public MidAutumnFestivalController()
	{
	}
}
[Token(Token = "0x2000148")]
public class SmoothLightingOn : MonoBehaviour
{
	[Token(Token = "0x2000149")]
	private class LightData
	{
		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Light light;

		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float initIntensity;

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x8A9FF4", Offset = "0x8A9FF4", VA = "0x8A9FF4")]
		public LightData()
		{
		}
	}

	[Token(Token = "0x4000539")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float _Duration;

	[Token(Token = "0x400053A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AnimationCurve _TimeCurve;

	[Token(Token = "0x400053B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float mTime;

	[Token(Token = "0x400053C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<LightData> mLights;

	[Token(Token = "0x60006E8")]
	[Address(RVA = "0x8A9E78", Offset = "0x8A9E78", VA = "0x8A9E78")]
	private void Start()
	{
	}

	[Token(Token = "0x60006E9")]
	[Address(RVA = "0x8A9FFC", Offset = "0x8A9FFC", VA = "0x8A9FFC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60006EA")]
	[Address(RVA = "0x8AA004", Offset = "0x8AA004", VA = "0x8AA004")]
	private void Update()
	{
	}

	[Token(Token = "0x60006EB")]
	[Address(RVA = "0x8AA214", Offset = "0x8AA214", VA = "0x8AA214")]
	public SmoothLightingOn()
	{
	}
}
[Token(Token = "0x200014A")]
public class LogoFollower : MonoBehaviour
{
	[Token(Token = "0x400053F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float _distance;

	[Token(Token = "0x4000540")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private float _smooth;

	[Token(Token = "0x4000541")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float _maxSpeed;

	[Token(Token = "0x4000542")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float _maxAngle;

	[Token(Token = "0x4000543")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Vector3 currentVelocity;

	[Token(Token = "0x4000544")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private bool mRun;

	[Token(Token = "0x60006ED")]
	[Address(RVA = "0x8AA3A0", Offset = "0x8AA3A0", VA = "0x8AA3A0")]
	private void Start()
	{
	}

	[Token(Token = "0x60006EE")]
	[Address(RVA = "0x8AA66C", Offset = "0x8AA66C", VA = "0x8AA66C")]
	private void Update()
	{
	}

	[Token(Token = "0x60006EF")]
	[Address(RVA = "0x8AAC20", Offset = "0x8AAC20", VA = "0x8AAC20")]
	public LogoFollower()
	{
	}
}
[Token(Token = "0x200014B")]
[RequireComponent(typeof(VideoPlayer))]
public class RenderVideoToImage : MonoBehaviour
{
	[Token(Token = "0x4000545")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RawImage _Image;

	[Token(Token = "0x4000546")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Color _ClearColor;

	[Token(Token = "0x4000547")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Min(1f)]
	private int _Width;

	[Token(Token = "0x4000548")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[SerializeField]
	[Min(1f)]
	private int _Height;

	[Token(Token = "0x4000549")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private VideoPlayer mVideoPlayer;

	[Token(Token = "0x400054A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private RenderTexture mRenderTexture;

	[Token(Token = "0x400054B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private RenderTextureDescriptor mDescriptor;

	[Token(Token = "0x60006F0")]
	[Address(RVA = "0x8AAC34", Offset = "0x8AAC34", VA = "0x8AAC34")]
	private void Awake()
	{
	}

	[Token(Token = "0x60006F1")]
	[Address(RVA = "0x8AACC8", Offset = "0x8AACC8", VA = "0x8AACC8")]
	private void Update()
	{
	}

	[Token(Token = "0x60006F2")]
	[Address(RVA = "0x8AADBC", Offset = "0x8AADBC", VA = "0x8AADBC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60006F3")]
	[Address(RVA = "0x8AADC8", Offset = "0x8AADC8", VA = "0x8AADC8")]
	public RenderVideoToImage()
	{
	}
}
[Token(Token = "0x200014C")]
public class VRLogoController : MonoBehaviour
{
	[Token(Token = "0x400054C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private ScenesLoader _NextLevelLoader;

	[Token(Token = "0x400054D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float _AsyncLoadStartTime;

	[Token(Token = "0x400054E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float _LogoMinTime;

	[Token(Token = "0x60006F4")]
	[Address(RVA = "0x8AADE0", Offset = "0x8AADE0", VA = "0x8AADE0")]
	private void Start()
	{
	}

	[Token(Token = "0x60006F5")]
	[Address(RVA = "0x8AAE60", Offset = "0x8AAE60", VA = "0x8AAE60")]
	private void OnStartLoadLevel()
	{
	}

	[Token(Token = "0x60006F6")]
	[Address(RVA = "0x8AAE7C", Offset = "0x8AAE7C", VA = "0x8AAE7C")]
	private void OnLogoEnd()
	{
	}

	[Token(Token = "0x60006F7")]
	[Address(RVA = "0x8AAE9C", Offset = "0x8AAE9C", VA = "0x8AAE9C")]
	public VRLogoController()
	{
	}
}
[Serializable]
[Token(Token = "0x200014D")]
public class BackgroundBlendLayer : IPaintingBlendLayer, PaintingCanvasLayer, IBackgroundBlendLayer
{
	[Token(Token = "0x400054F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[SerializeField]
	private Texture _BackgroundTexture;

	[Token(Token = "0x4000550")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Color _BackgroundColor;

	[Token(Token = "0x17000144")]
	public CanvasLayerOrder order
	{
		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x8AAEB0", Offset = "0x8AAEB0", VA = "0x8AAEB0", Slot = "5")]
		get
		{
			return default(CanvasLayerOrder);
		}
	}

	[Token(Token = "0x17000145")]
	public Texture backgroundTexture
	{
		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x8AAEB8", Offset = "0x8AAEB8", VA = "0x8AAEB8", Slot = "8")]
		get
		{
			return null;
		}
		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x8AAEC0", Offset = "0x8AAEC0", VA = "0x8AAEC0")]
		set
		{
		}
	}

	[Token(Token = "0x17000146")]
	public Color backgroundColor
	{
		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x8AAEC8", Offset = "0x8AAEC8", VA = "0x8AAEC8")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x8AAED4", Offset = "0x8AAED4", VA = "0x8AAED4")]
		set
		{
		}
	}

	[Token(Token = "0x17000147")]
	public Texture preview
	{
		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x8AAEE0", Offset = "0x8AAEE0", VA = "0x8AAEE0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60006FE")]
	[Address(RVA = "0x8AAEE8", Offset = "0x8AAEE8", VA = "0x8AAEE8", Slot = "6")]
	public void ClearContent()
	{
	}

	[Token(Token = "0x60006FF")]
	[Address(RVA = "0x8AAEEC", Offset = "0x8AAEEC", VA = "0x8AAEEC", Slot = "4")]
	public void RenderTo(RenderTexture target, IBackgroundBlendLayer background)
	{
	}

	[Token(Token = "0x6000700")]
	[Address(RVA = "0x8AAFC4", Offset = "0x8AAFC4", VA = "0x8AAFC4")]
	public BackgroundBlendLayer()
	{
	}
}
[Token(Token = "0x200014E")]
public static class MaterialsUtils
{
	[Token(Token = "0x6000701")]
	[Address(RVA = "0x8AAFCC", Offset = "0x8AAFCC", VA = "0x8AAFCC")]
	public static void SyncMaterial(ref Material old, Material source)
	{
	}
}
[Token(Token = "0x200014F")]
public class Painter : MonoBehaviour, IPaintingBlendLayer, PaintingCanvasLayer
{
	[Token(Token = "0x2000150")]
	public class SingleChannelBlendHistoryBuffer : PaintingHistoryManager.HistoryBuffer, IDisposable
	{
		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Material mMaterial;

		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private RenderTexture mRenderTexture;

		[Token(Token = "0x400055D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Color mColor;

		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string mName;

		[Token(Token = "0x1700014A")]
		public Texture previewTexture
		{
			[Token(Token = "0x600070F")]
			[Address(RVA = "0x8ABFB8", Offset = "0x8ABFB8", VA = "0x8ABFB8", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700014B")]
		public string name
		{
			[Token(Token = "0x6000710")]
			[Address(RVA = "0x8ABFC0", Offset = "0x8ABFC0", VA = "0x8ABFC0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0x8ABBA8", Offset = "0x8ABBA8", VA = "0x8ABBA8")]
		public SingleChannelBlendHistoryBuffer(string name, Color color, Material layerMergeMaterial, RenderTexture source, bool copyingRenderTexture = true)
		{
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0x8ABD3C", Offset = "0x8ABD3C", VA = "0x8ABD3C", Slot = "4")]
		public void LayerMerge(Texture baseTexture, RenderTexture to, IBackgroundBlendLayer background)
		{
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0x8ABEDC", Offset = "0x8ABEDC", VA = "0x8ABEDC", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0x8ABFC8", Offset = "0x8ABFC8", VA = "0x8ABFC8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Token(Token = "0x2000151")]
	public class RBGABlendHistoryBuffer : PaintingHistoryManager.HistoryBuffer, IDisposable
	{
		[Token(Token = "0x400055F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Material mMaterial;

		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private RenderTexture mRenderTexture;

		[Token(Token = "0x4000561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string mName;

		[Token(Token = "0x1700014C")]
		public Texture previewTexture
		{
			[Token(Token = "0x6000715")]
			[Address(RVA = "0x8AC314", Offset = "0x8AC314", VA = "0x8AC314", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700014D")]
		public string name
		{
			[Token(Token = "0x6000716")]
			[Address(RVA = "0x8AC31C", Offset = "0x8AC31C", VA = "0x8AC31C", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0x8ABFD0", Offset = "0x8ABFD0", VA = "0x8ABFD0")]
		public RBGABlendHistoryBuffer(string name, Material layerMergeMaterial, RenderTexture source, bool copyingRenderTexture = true)
		{
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0x8AC110", Offset = "0x8AC110", VA = "0x8AC110", Slot = "4")]
		public void LayerMerge(Texture baseTexture, RenderTexture to, IBackgroundBlendLayer background)
		{
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0x8AC2B0", Offset = "0x8AC2B0", VA = "0x8AC2B0", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0x8AC324", Offset = "0x8AC324", VA = "0x8AC324", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Serializable]
	[Token(Token = "0x2000152")]
	protected struct PainterMaterials
	{
		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Material layerMergeMaterial;

		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Material layerBlendMaterial;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Material paintingMaterial;
	}

	[Token(Token = "0x4000551")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	protected RenderTextureFormat _RenderTextureFormat;

	[Token(Token = "0x4000552")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	protected PainterMaterials _RRBAFormatMaterials;

	[Token(Token = "0x4000553")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	protected PainterMaterials _RFormatMaterials;

	[Token(Token = "0x4000554")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	protected bool _OverrideMSAALevel;

	[Token(Token = "0x4000555")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[SerializeField]
	[Range(0f, 3f)]
	protected int _MSAALevel;

	[Token(Token = "0x4000556")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	protected Color _Color;

	[Token(Token = "0x4000557")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	protected RenderTexture mRenderTexture;

	[Token(Token = "0x4000558")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	protected Material mCopyingBlendMaterial;

	[Token(Token = "0x4000559")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	protected Material mCopyingPaintingMaterial;

	[Token(Token = "0x400055A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private bool mPreventInitRenderTextureCycle;

	[Token(Token = "0x17000148")]
	public CanvasLayerOrder order
	{
		[Token(Token = "0x6000702")]
		[Address(RVA = "0x8AB16C", Offset = "0x8AB16C", VA = "0x8AB16C", Slot = "5")]
		get
		{
			return default(CanvasLayerOrder);
		}
	}

	[Token(Token = "0x17000149")]
	public Texture preview
	{
		[Token(Token = "0x6000703")]
		[Address(RVA = "0x8AB174", Offset = "0x8AB174", VA = "0x8AB174", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000704")]
	[Address(RVA = "0x8AB17C", Offset = "0x8AB17C", VA = "0x8AB17C", Slot = "8")]
	protected virtual void OnDestroy()
	{
	}

	[Token(Token = "0x6000705")]
	[Address(RVA = "0x8AB1F0", Offset = "0x8AB1F0", VA = "0x8AB1F0", Slot = "9")]
	protected virtual PaintingHistoryManager.HistoryBuffer CreateHistoryBuffer(string name, Color color, bool copyingRenderTexture = true)
	{
		return null;
	}

	[Token(Token = "0x6000706")]
	[Address(RVA = "0x8AB334", Offset = "0x8AB334", VA = "0x8AB334")]
	protected static bool IsSingleChannelTextureFormat(RenderTextureFormat format)
	{
		return default(bool);
	}

	[Token(Token = "0x6000707")]
	[Address(RVA = "0x8AB35C", Offset = "0x8AB35C", VA = "0x8AB35C", Slot = "10")]
	protected virtual void InitRenderTexture(PaintingCanvas canvas)
	{
	}

	[Token(Token = "0x6000708")]
	[Address(RVA = "0x8AB7F8", Offset = "0x8AB7F8", VA = "0x8AB7F8", Slot = "11")]
	protected virtual void InitMaterials()
	{
	}

	[Token(Token = "0x6000709")]
	[Address(RVA = "0x8AB950", Offset = "0x8AB950", VA = "0x8AB950", Slot = "12")]
	public virtual void RenderTo(RenderTexture target, IBackgroundBlendLayer background)
	{
	}

	[Token(Token = "0x600070A")]
	[Address(RVA = "0x8ABB00", Offset = "0x8ABB00", VA = "0x8ABB00", Slot = "13")]
	public virtual void ClearContent()
	{
	}

	[Token(Token = "0x600070B")]
	[Address(RVA = "0x8ABB98", Offset = "0x8ABB98", VA = "0x8ABB98")]
	public Painter()
	{
	}
}
[Token(Token = "0x2000153")]
public abstract class PaintingCanvas : IDisposable, IEnumerable<PaintingCanvasLayer>, IEnumerable
{
	[Token(Token = "0x2000154")]
	private class PaintingCanvasLayerSorter : IComparer<PaintingCanvasLayer>
	{
		[Token(Token = "0x6000721")]
		[Address(RVA = "0x8ACB58", Offset = "0x8ACB58", VA = "0x8ACB58", Slot = "4")]
		public int Compare(PaintingCanvasLayer x, PaintingCanvasLayer y)
		{
			return default(int);
		}

		[Token(Token = "0x6000722")]
		[Address(RVA = "0x8ACB50", Offset = "0x8ACB50", VA = "0x8ACB50")]
		public PaintingCanvasLayerSorter()
		{
		}
	}

	[Token(Token = "0x4000565")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private List<PaintingCanvasLayer> mBlendLayers;

	[Token(Token = "0x4000566")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private PaintingCanvasLayerSorter mCanvasLayerSorter;

	[Token(Token = "0x4000567")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool mIsDirty;

	[Token(Token = "0x1700014E")]
	public abstract RenderTexture renderTexture
	{
		[Token(Token = "0x6000718")]
		get;
	}

	[Token(Token = "0x6000719")]
	[Address(RVA = "0x8AC32C", Offset = "0x8AC32C", VA = "0x8AC32C", Slot = "8")]
	public virtual void AddBlendLayer(IPaintingBlendLayer blendLayer)
	{
	}

	[Token(Token = "0x600071A")]
	[Address(RVA = "0x8AC3D4", Offset = "0x8AC3D4", VA = "0x8AC3D4", Slot = "9")]
	public virtual void Dispose()
	{
	}

	[Token(Token = "0x600071B")]
	[Address(RVA = "0x8AC3D8", Offset = "0x8AC3D8", VA = "0x8AC3D8", Slot = "5")]
	public IEnumerator<PaintingCanvasLayer> GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x600071C")]
	[Address(RVA = "0x8AC478", Offset = "0x8AC478", VA = "0x8AC478", Slot = "10")]
	public virtual void Invalidate()
	{
	}

	[Token(Token = "0x600071D")]
	[Address(RVA = "0x8AC484", Offset = "0x8AC484", VA = "0x8AC484", Slot = "11")]
	public virtual void RemoveBlendLayer(IPaintingBlendLayer blendLayer)
	{
	}

	[Token(Token = "0x600071E")]
	[Address(RVA = "0x8AC4DC", Offset = "0x8AC4DC", VA = "0x8AC4DC", Slot = "12")]
	public virtual bool UpdateTexture()
	{
		return default(bool);
	}

	[Token(Token = "0x600071F")]
	[Address(RVA = "0x8AC9FC", Offset = "0x8AC9FC", VA = "0x8AC9FC", Slot = "6")]
	private IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x6000720")]
	[Address(RVA = "0x8ACA9C", Offset = "0x8ACA9C", VA = "0x8ACA9C")]
	protected PaintingCanvas()
	{
	}
}
[Token(Token = "0x2000155")]
public interface PaintingCanvasLayer
{
	[Token(Token = "0x1700014F")]
	CanvasLayerOrder order
	{
		[Token(Token = "0x6000723")]
		get;
	}

	[Token(Token = "0x17000150")]
	Texture preview
	{
		[Token(Token = "0x6000725")]
		get;
	}

	[Token(Token = "0x6000724")]
	void ClearContent();
}
[Token(Token = "0x2000156")]
public enum CanvasLayerOrder
{
	[Token(Token = "0x4000569")]
	Background = 0,
	[Token(Token = "0x400056A")]
	PaintingHistory = 100,
	[Token(Token = "0x400056B")]
	Painting = 200
}
[Token(Token = "0x2000157")]
public interface IPaintingBlendLayer : PaintingCanvasLayer
{
	[Token(Token = "0x6000726")]
	void RenderTo(RenderTexture target, IBackgroundBlendLayer layer);
}
[Token(Token = "0x2000158")]
public interface IPaintingBlendLayer2 : PaintingCanvasLayer
{
	[Token(Token = "0x6000727")]
	void RenderTo(RenderTexture source, RenderTexture target, IBackgroundBlendLayer layer);
}
[Token(Token = "0x2000159")]
public interface IBackgroundBlendLayer
{
	[Token(Token = "0x17000151")]
	Texture backgroundTexture
	{
		[Token(Token = "0x6000728")]
		get;
	}
}
[Serializable]
[Token(Token = "0x200015A")]
public class PaintingHistoryManager : IDisposable, IPaintingBlendLayer, PaintingCanvasLayer
{
	[Token(Token = "0x200015B")]
	public interface HistoryBuffer : IDisposable
	{
		[Token(Token = "0x1700015D")]
		Texture previewTexture
		{
			[Token(Token = "0x6000744")]
			get;
		}

		[Token(Token = "0x1700015E")]
		string name
		{
			[Token(Token = "0x6000745")]
			get;
		}

		[Token(Token = "0x6000743")]
		void LayerMerge(Texture from, RenderTexture to, IBackgroundBlendLayer background);
	}

	[Token(Token = "0x200015C")]
	public sealed class ClearHistoryBuffer : HistoryBuffer, IDisposable
	{
		[Token(Token = "0x1700015F")]
		public Texture previewTexture
		{
			[Token(Token = "0x6000746")]
			[Address(RVA = "0x8AE270", Offset = "0x8AE270", VA = "0x8AE270", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000160")]
		public string name
		{
			[Token(Token = "0x6000747")]
			[Address(RVA = "0x8AE278", Offset = "0x8AE278", VA = "0x8AE278", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0x8AE2B8", Offset = "0x8AE2B8", VA = "0x8AE2B8", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0x8AE2BC", Offset = "0x8AE2BC", VA = "0x8AE2BC", Slot = "4")]
		public void LayerMerge(Texture from, RenderTexture to, IBackgroundBlendLayer background)
		{
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0x8AE2E0", Offset = "0x8AE2E0", VA = "0x8AE2E0")]
		public ClearHistoryBuffer()
		{
		}
	}

	[Token(Token = "0x400056C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[Min(0f)]
	[SerializeField]
	protected int _MaxHistoryCount;

	[Token(Token = "0x400056D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	protected Material _BlitMaterial;

	[Token(Token = "0x400056E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	protected Material _AlphaBlendMergeMaterial;

	[Token(Token = "0x400056F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected RenderTexture mOverflowMergedHisotryBuffer;

	[Token(Token = "0x4000570")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected RenderTexture mMergedHisotryBuffer;

	[Token(Token = "0x4000571")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected List<HistoryBuffer> mHistoryStack;

	[Token(Token = "0x4000572")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	protected int mUndoHistoryCount;

	[Token(Token = "0x4000573")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	protected bool mIsHistoryDirty;

	[Token(Token = "0x4000574")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	protected int mLastUndoClearHistoryIndex;

	[Token(Token = "0x4000575")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	protected IBackgroundBlendLayer mCatchedBackground;

	[Token(Token = "0x17000152")]
	public int undoHistoryCount
	{
		[Token(Token = "0x6000729")]
		[Address(RVA = "0x8ACCAC", Offset = "0x8ACCAC", VA = "0x8ACCAC")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000153")]
	public RenderTexture mergedHisotryBuffer
	{
		[Token(Token = "0x600072A")]
		[Address(RVA = "0x8ACCB4", Offset = "0x8ACCB4", VA = "0x8ACCB4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000154")]
	public RenderTexture overflowMergedHisotryBuffer
	{
		[Token(Token = "0x600072B")]
		[Address(RVA = "0x8ACCBC", Offset = "0x8ACCBC", VA = "0x8ACCBC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000155")]
	public ReadOnlyCollection<HistoryBuffer> historyStack
	{
		[Token(Token = "0x600072C")]
		[Address(RVA = "0x8ACCC4", Offset = "0x8ACCC4", VA = "0x8ACCC4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000156")]
	public int maxHistoryCount
	{
		[Token(Token = "0x600072D")]
		[Address(RVA = "0x8ACD14", Offset = "0x8ACD14", VA = "0x8ACD14")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600072E")]
		[Address(RVA = "0x8ACD1C", Offset = "0x8ACD1C", VA = "0x8ACD1C")]
		set
		{
		}
	}

	[Token(Token = "0x17000157")]
	public Material blitMaterial
	{
		[Token(Token = "0x600072F")]
		[Address(RVA = "0x8ACD28", Offset = "0x8ACD28", VA = "0x8ACD28")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000730")]
		[Address(RVA = "0x8ACD30", Offset = "0x8ACD30", VA = "0x8ACD30")]
		set
		{
		}
	}

	[Token(Token = "0x17000158")]
	public CanvasLayerOrder order
	{
		[Token(Token = "0x6000731")]
		[Address(RVA = "0x8ACD38", Offset = "0x8ACD38", VA = "0x8ACD38", Slot = "6")]
		get
		{
			return default(CanvasLayerOrder);
		}
	}

	[Token(Token = "0x17000159")]
	public bool canUndo
	{
		[Token(Token = "0x6000732")]
		[Address(RVA = "0x8ACD40", Offset = "0x8ACD40", VA = "0x8ACD40")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700015A")]
	public bool canRedo
	{
		[Token(Token = "0x6000733")]
		[Address(RVA = "0x8ACD50", Offset = "0x8ACD50", VA = "0x8ACD50")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700015B")]
	public bool isDirty
	{
		[Token(Token = "0x6000734")]
		[Address(RVA = "0x8ACDA4", Offset = "0x8ACDA4", VA = "0x8ACDA4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700015C")]
	public Texture preview
	{
		[Token(Token = "0x6000735")]
		[Address(RVA = "0x8ACDAC", Offset = "0x8ACDAC", VA = "0x8ACDAC", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000736")]
	[Address(RVA = "0x8ACDB4", Offset = "0x8ACDB4", VA = "0x8ACDB4", Slot = "9")]
	public virtual void Undo()
	{
	}

	[Token(Token = "0x6000737")]
	[Address(RVA = "0x8ACDD0", Offset = "0x8ACDD0", VA = "0x8ACDD0", Slot = "10")]
	public virtual void Redo()
	{
	}

	[Token(Token = "0x6000738")]
	[Address(RVA = "0x8ACE34", Offset = "0x8ACE34", VA = "0x8ACE34", Slot = "11")]
	public virtual void ClearContent()
	{
	}

	[Token(Token = "0x6000739")]
	[Address(RVA = "0x8AD0B8", Offset = "0x8AD0B8", VA = "0x8AD0B8")]
	private void ClearRedoHistory()
	{
	}

	[Token(Token = "0x600073A")]
	[Address(RVA = "0x8AD1DC", Offset = "0x8AD1DC", VA = "0x8AD1DC", Slot = "12")]
	public virtual void AddPaintAction(HistoryBuffer historyBuffer)
	{
	}

	[Token(Token = "0x600073B")]
	[Address(RVA = "0x8AD30C", Offset = "0x8AD30C", VA = "0x8AD30C", Slot = "13")]
	public virtual void RenderTo(RenderTexture target, IBackgroundBlendLayer background)
	{
	}

	[Token(Token = "0x600073C")]
	[Address(RVA = "0x8ADCB4", Offset = "0x8ADCB4", VA = "0x8ADCB4", Slot = "14")]
	public virtual void MergeHistoryTo(RenderTexture target)
	{
	}

	[Token(Token = "0x600073D")]
	[Address(RVA = "0x8AD44C", Offset = "0x8AD44C", VA = "0x8AD44C")]
	private void Init(RenderTexture target, IBackgroundBlendLayer background)
	{
	}

	[Token(Token = "0x600073E")]
	[Address(RVA = "0x8ADFD4", Offset = "0x8ADFD4", VA = "0x8ADFD4", Slot = "15")]
	protected virtual void OnOverflowHistoryMerged(HistoryBuffer history)
	{
	}

	[Token(Token = "0x600073F")]
	[Address(RVA = "0x8ADFD8", Offset = "0x8ADFD8", VA = "0x8ADFD8", Slot = "16")]
	protected virtual void OnHistoryBuffersUpdated()
	{
	}

	[Token(Token = "0x6000740")]
	[Address(RVA = "0x8AD770", Offset = "0x8AD770", VA = "0x8AD770")]
	private void UpdateHistoryBuffers()
	{
	}

	[Token(Token = "0x6000741")]
	[Address(RVA = "0x8ADFDC", Offset = "0x8ADFDC", VA = "0x8ADFDC", Slot = "17")]
	public virtual void Dispose()
	{
	}

	[Token(Token = "0x6000742")]
	[Address(RVA = "0x8AE1E4", Offset = "0x8AE1E4", VA = "0x8AE1E4")]
	public PaintingHistoryManager()
	{
	}
}
[Token(Token = "0x200015E")]
public static class RenderTextureUtils
{
	[Token(Token = "0x200015F")]
	public enum GetTemporaryFlag
	{
		[Token(Token = "0x400057A")]
		None,
		[Token(Token = "0x400057B")]
		Clear,
		[Token(Token = "0x400057C")]
		CopyOldContent
	}

	[Token(Token = "0x600074F")]
	[Address(RVA = "0x8AE38C", Offset = "0x8AE38C", VA = "0x8AE38C")]
	public static RenderTexture GetTemporary(RenderTexture old, RenderTexture matchTarget, bool clear)
	{
		return null;
	}

	[Token(Token = "0x6000750")]
	[Address(RVA = "0x8ADD80", Offset = "0x8ADD80", VA = "0x8ADD80")]
	public static bool GetTemporary(ref RenderTexture target, RenderTextureDescriptor descriptor, GetTemporaryFlag flag = GetTemporaryFlag.CopyOldContent, [Optional] Func<RenderTextureDescriptor, RenderTextureDescriptor> onCreate)
	{
		return default(bool);
	}

	[Token(Token = "0x6000751")]
	[Address(RVA = "0x8ABF40", Offset = "0x8ABF40", VA = "0x8ABF40")]
	public static void ReleaseTemporary(ref RenderTexture texture)
	{
	}

	[Token(Token = "0x6000752")]
	[Address(RVA = "0x8AE4DC", Offset = "0x8AE4DC", VA = "0x8AE4DC")]
	public static void SetRenderTargetAndClear(RenderTexture texture)
	{
	}

	[Token(Token = "0x6000753")]
	[Address(RVA = "0x8AE4E0", Offset = "0x8AE4E0", VA = "0x8AE4E0")]
	public static void SetRenderTargetAndClear(RenderTexture texture, Color color)
	{
	}

	[Token(Token = "0x6000754")]
	[Address(RVA = "0x8AD020", Offset = "0x8AD020", VA = "0x8AD020")]
	public static void Clear(this RenderTexture rt, bool clearDepth, bool clearColor, Color backgroundColor, float depth = 1f)
	{
	}

	[Token(Token = "0x6000755")]
	[Address(RVA = "0x8AE59C", Offset = "0x8AE59C", VA = "0x8AE59C")]
	public static Texture2D RenderTextureTo2dForSave(RenderTexture renderTexture, bool apply = true, bool changeColorSpace = false)
	{
		return null;
	}
}
[Token(Token = "0x2000161")]
public class UIPainter : Painter, IDragHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler
{
	[Token(Token = "0x2000162")]
	protected class ActionData
	{
		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int pointId;

		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Camera camera;

		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector2 position;

		[Token(Token = "0x4000587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool isUp;

		[Token(Token = "0x6000761")]
		[Address(RVA = "0x8AF258", Offset = "0x8AF258", VA = "0x8AF258")]
		public ActionData()
		{
		}
	}

	[Token(Token = "0x400057F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private RawImage _PreviewImage;

	[Token(Token = "0x4000580")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	protected UIPaintingCanvas _PainterCanvasLayers;

	[Token(Token = "0x4000581")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[SerializeField]
	[Min(1f)]
	protected float _Size;

	[Token(Token = "0x4000582")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	protected RectTransform mRectTransform;

	[Token(Token = "0x4000583")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[SerializeField]
	protected ActionData mActionData;

	[Token(Token = "0x6000758")]
	[Address(RVA = "0x8AEB30", Offset = "0x8AEB30", VA = "0x8AEB30")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000759")]
	[Address(RVA = "0x8AEBA0", Offset = "0x8AEBA0", VA = "0x8AEBA0")]
	public void AddLayer(RenderTexture source)
	{
	}

	[Token(Token = "0x600075A")]
	[Address(RVA = "0x8AEC20", Offset = "0x8AEC20", VA = "0x8AEC20")]
	protected void Update()
	{
	}

	[Token(Token = "0x600075B")]
	[Address(RVA = "0x8AF130", Offset = "0x8AF130", VA = "0x8AF130", Slot = "17")]
	protected virtual void SetDone()
	{
	}

	[Token(Token = "0x600075C")]
	[Address(RVA = "0x8AEE74", Offset = "0x8AEE74", VA = "0x8AEE74")]
	private void Draw(Matrix4x4 matrix)
	{
	}

	[Token(Token = "0x600075D")]
	[Address(RVA = "0x8AF1C8", Offset = "0x8AF1C8", VA = "0x8AF1C8", Slot = "15")]
	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600075E")]
	[Address(RVA = "0x8AF260", Offset = "0x8AF260", VA = "0x8AF260", Slot = "14")]
	public void OnDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600075F")]
	[Address(RVA = "0x8AF294", Offset = "0x8AF294", VA = "0x8AF294", Slot = "16")]
	public void OnEndDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000760")]
	[Address(RVA = "0x8AF2D8", Offset = "0x8AF2D8", VA = "0x8AF2D8")]
	public UIPainter()
	{
	}
}
[Token(Token = "0x2000163")]
public class UIPaintingCanvas : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000164")]
	private class Canvas : PaintingCanvas
	{
		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RenderTexture _RenderTexture;

		[Token(Token = "0x17000163")]
		public override RenderTexture renderTexture
		{
			[Token(Token = "0x6000769")]
			[Address(RVA = "0x8AF5A4", Offset = "0x8AF5A4", VA = "0x8AF5A4", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0x8AF5AC", Offset = "0x8AF5AC", VA = "0x8AF5AC")]
		public Canvas()
		{
		}
	}

	[Token(Token = "0x4000588")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RawImage _PreviewImage;

	[Token(Token = "0x4000589")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Canvas _Canvas;

	[Token(Token = "0x400058A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private BackgroundBlendLayer _Background;

	[Token(Token = "0x400058B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private PaintingHistoryManager _HistoryManager;

	[Token(Token = "0x17000161")]
	public PaintingHistoryManager historyManager
	{
		[Token(Token = "0x6000762")]
		[Address(RVA = "0x8AF2E8", Offset = "0x8AF2E8", VA = "0x8AF2E8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000162")]
	public PaintingCanvas canvas
	{
		[Token(Token = "0x6000763")]
		[Address(RVA = "0x8AF2F0", Offset = "0x8AF2F0", VA = "0x8AF2F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000764")]
	[Address(RVA = "0x8AF2F8", Offset = "0x8AF2F8", VA = "0x8AF2F8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000765")]
	[Address(RVA = "0x8AF338", Offset = "0x8AF338", VA = "0x8AF338")]
	private void Start()
	{
	}

	[Token(Token = "0x6000766")]
	[Address(RVA = "0x8AF40C", Offset = "0x8AF40C", VA = "0x8AF40C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000767")]
	[Address(RVA = "0x8AF560", Offset = "0x8AF560", VA = "0x8AF560")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000768")]
	[Address(RVA = "0x8AF59C", Offset = "0x8AF59C", VA = "0x8AF59C")]
	public UIPaintingCanvas()
	{
	}
}
[Token(Token = "0x2000165")]
public class VRPCCameraController : SingletonGameObject<VRPCCameraController>
{
	[Token(Token = "0x2000166")]
	private class MouseInput : MouseVRRayInput
	{
		[Token(Token = "0x17000167")]
		public override bool isVRDeviceActive
		{
			[Token(Token = "0x6000780")]
			[Address(RVA = "0x8B154C", Offset = "0x8B154C", VA = "0x8B154C", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0x8B1554", Offset = "0x8B1554", VA = "0x8B1554")]
		public MouseInput()
		{
		}
	}

	[Token(Token = "0x400058D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private KeyCode _ActiveKey;

	[Token(Token = "0x400058E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private KeyCode _ActiveAndSetPoseKey;

	[Token(Token = "0x400058F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[SerializeField]
	private KeyCode _UIHideKey;

	[Token(Token = "0x4000590")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private MenuPanel _HelpUI;

	[Token(Token = "0x4000591")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private VRPCCameraPose mCurrentPose;

	[Token(Token = "0x4000592")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private VRPCCamera mVRPCCamera;

	[Token(Token = "0x4000593")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private TPSCamera mTpsCamera;

	[Token(Token = "0x4000594")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Transform mViewPosition;

	[Token(Token = "0x4000595")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool mIsUIHided;

	[Token(Token = "0x4000596")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private XmlElement mSavedNode;

	[Token(Token = "0x4000597")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float mMoveSpeed;

	[Token(Token = "0x4000598")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private VRRayController mMouseRayController;

	[Token(Token = "0x4000599")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private bool mHelpUIAndSettingsInited;

	[Token(Token = "0x400059A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private HashSet<VRRayController> mDisabledRays;

	[Token(Token = "0x17000164")]
	protected override bool dontDestroyOnLoad
	{
		[Token(Token = "0x600076B")]
		[Address(RVA = "0x8AF5B0", Offset = "0x8AF5B0", VA = "0x8AF5B0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000165")]
	public XmlElement savedData
	{
		[Token(Token = "0x600076F")]
		[Address(RVA = "0x8AFC84", Offset = "0x8AFC84", VA = "0x8AFC84")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000166")]
	private bool isInValidScene
	{
		[Token(Token = "0x6000775")]
		[Address(RVA = "0x8B05C0", Offset = "0x8B05C0", VA = "0x8B05C0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600076C")]
	[Address(RVA = "0x8AF5B8", Offset = "0x8AF5B8", VA = "0x8AF5B8")]
	private void Start()
	{
	}

	[Token(Token = "0x600076D")]
	[Address(RVA = "0x8AF8EC", Offset = "0x8AF8EC", VA = "0x8AF8EC")]
	private void InitHelpUIAndSettings()
	{
	}

	[Token(Token = "0x600076E")]
	[Address(RVA = "0x8AF7C8", Offset = "0x8AF7C8", VA = "0x8AF7C8")]
	private void CreatePCCameraRay()
	{
	}

	[Token(Token = "0x6000770")]
	[Address(RVA = "0x8AFDB4", Offset = "0x8AFDB4", VA = "0x8AFDB4")]
	private void LanguageUtils_onLanguageChanged(string obj)
	{
	}

	[Token(Token = "0x6000771")]
	[Address(RVA = "0x8AFF80", Offset = "0x8AFF80", VA = "0x8AFF80")]
	private void SceneManager_activeSceneChanged(Scene arg0, Scene arg1)
	{
	}

	[Token(Token = "0x6000772")]
	[Address(RVA = "0x8B006C", Offset = "0x8B006C", VA = "0x8B006C", Slot = "7")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6000773")]
	[Address(RVA = "0x8B01B4", Offset = "0x8B01B4", VA = "0x8B01B4")]
	private void CreateVRPCCamera()
	{
	}

	[Token(Token = "0x6000774")]
	[Address(RVA = "0x8B04A4", Offset = "0x8B04A4", VA = "0x8B04A4")]
	private void DestroyVRPCamera()
	{
	}

	[Token(Token = "0x6000776")]
	[Address(RVA = "0x8B06B8", Offset = "0x8B06B8", VA = "0x8B06B8")]
	private void UpdateVRPCCamera()
	{
	}

	[Token(Token = "0x6000777")]
	[Address(RVA = "0x8B0BE4", Offset = "0x8B0BE4", VA = "0x8B0BE4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000778")]
	[Address(RVA = "0x8B01B0", Offset = "0x8B01B0", VA = "0x8B01B0")]
	private void DisableOtherMouseRay(bool disable)
	{
	}

	[Token(Token = "0x6000779")]
	[Address(RVA = "0x8B0598", Offset = "0x8B0598", VA = "0x8B0598")]
	private void LockAndCursor(bool lockAndHide)
	{
	}

	[Token(Token = "0x600077A")]
	[Address(RVA = "0x8AFF84", Offset = "0x8AFF84", VA = "0x8AFF84")]
	private void ResetCameraPosition()
	{
	}

	[Token(Token = "0x600077B")]
	[Address(RVA = "0x8B1130", Offset = "0x8B1130", VA = "0x8B1130")]
	private void ResetCameraPosition(Transform pose)
	{
	}

	[Token(Token = "0x600077C")]
	[Address(RVA = "0x8B1308", Offset = "0x8B1308", VA = "0x8B1308")]
	private static float ClampAngle(float angle, float min, float max)
	{
		return default(float);
	}

	[Token(Token = "0x600077D")]
	[Address(RVA = "0x8B1358", Offset = "0x8B1358", VA = "0x8B1358")]
	public VRPCCameraController()
	{
	}
}
[Token(Token = "0x2000167")]
public class VRPCCameraLoader
{
	[Token(Token = "0x6000782")]
	[Address(RVA = "0x8B155C", Offset = "0x8B155C", VA = "0x8B155C")]
	[RuntimeInitializeOnLoadMethod]
	public static void OnInit()
	{
	}

	[Token(Token = "0x6000783")]
	[Address(RVA = "0x8B1588", Offset = "0x8B1588", VA = "0x8B1588")]
	private static void Load()
	{
	}

	[Token(Token = "0x6000784")]
	[Address(RVA = "0x8B1604", Offset = "0x8B1604", VA = "0x8B1604")]
	public VRPCCameraLoader()
	{
	}
}
[Token(Token = "0x2000168")]
public class VRPCCameraPose : CollectableBehavior<VRPCCameraPose>, IComparable<VRPCCameraPose>
{
	[Token(Token = "0x400059B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private int _Order;

	[Token(Token = "0x17000168")]
	protected override bool enabledOnly
	{
		[Token(Token = "0x6000785")]
		[Address(RVA = "0x8B160C", Offset = "0x8B160C", VA = "0x8B160C", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000786")]
	[Address(RVA = "0x8B1614", Offset = "0x8B1614", VA = "0x8B1614", Slot = "9")]
	public int CompareTo(VRPCCameraPose other)
	{
		return default(int);
	}

	[Token(Token = "0x6000787")]
	[Address(RVA = "0x8B1634", Offset = "0x8B1634", VA = "0x8B1634")]
	public VRPCCameraPose()
	{
	}
}
namespace System.IO.Compression
{
	[Token(Token = "0x2000169")]
	public class ZipFile
	{
		[Token(Token = "0x400059C")]
		private const int Version = 1;

		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Stream mStream;

		[Token(Token = "0x400059E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int mVersion;

		[Token(Token = "0x400059F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int mEntriesCount;

		[Token(Token = "0x40005A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int mEntryHeaderPosition;

		[Token(Token = "0x40005A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int mEntryHeaderSize;

		[Token(Token = "0x6000788")]
		[Address(RVA = "0x8B16A0", Offset = "0x8B16A0", VA = "0x8B16A0")]
		public ZipFile(string path)
		{
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0x8B17F0", Offset = "0x8B17F0", VA = "0x8B17F0")]
		public ZipEntry[] getEntries()
		{
			return null;
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0x8B1750", Offset = "0x8B1750", VA = "0x8B1750")]
		private int ReadInt()
		{
			return default(int);
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0x8B1978", Offset = "0x8B1978", VA = "0x8B1978")]
		private void Write(int i)
		{
		}
	}
	[Token(Token = "0x200016A")]
	public class ZipEntry
	{
		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal int position;

		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		internal int size;

		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal int compressiedSize;

		[Token(Token = "0x17000169")]
		public string name
		{
			[Token(Token = "0x600078C")]
			[Address(RVA = "0x8B1A00", Offset = "0x8B1A00", VA = "0x8B1A00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600078D")]
			[Address(RVA = "0x8B1A08", Offset = "0x8B1A08", VA = "0x8B1A08")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0x8B1970", Offset = "0x8B1970", VA = "0x8B1970")]
		public ZipEntry()
		{
		}
	}
}
namespace Game.UI
{
	[Token(Token = "0x200016B")]
	public class GalleryPanel : MonoBehaviour, IScrollHandler, IEventSystemHandler
	{
		[Serializable]
		[Token(Token = "0x200016C")]
		public class PaperConent
		{
			[Token(Token = "0x40005B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UnityEngine.Object image;

			[Token(Token = "0x40005B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string title;

			[Token(Token = "0x40005BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string name;

			[Token(Token = "0x600079A")]
			[Address(RVA = "0x8B3274", Offset = "0x8B3274", VA = "0x8B3274")]
			public PaperConent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200016D")]
		public class GalleryPanelEvent : UnityEvent<GalleryPanel>
		{
			[Token(Token = "0x600079B")]
			[Address(RVA = "0x8B327C", Offset = "0x8B327C", VA = "0x8B327C")]
			public GalleryPanelEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200016E")]
		public class GalleryPanelEvent2 : UnityEvent<GalleryPanel, int>
		{
			[Token(Token = "0x600079C")]
			[Address(RVA = "0x8B32C4", Offset = "0x8B32C4", VA = "0x8B32C4")]
			public GalleryPanelEvent2()
			{
			}
		}

		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AudioClip _AudioPaging;

		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioClip _AudioClicked;

		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AbsGalleryPaperTemplate startTemplate;

		[Token(Token = "0x40005A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AbsGalleryPaperTemplate endTemplate;

		[Token(Token = "0x40005AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AbsGalleryPaperTemplate[] templates;

		[Token(Token = "0x40005AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Text title;

		[Token(Token = "0x40005AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float smooth;

		[Token(Token = "0x40005AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private HorizontalScrollHandler _Scroll;

		[Token(Token = "0x40005AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public List<PaperConent> paperContents;

		[Token(Token = "0x40005AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public int selectedIndex;

		[Token(Token = "0x40005B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int selectionOffset;

		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public GalleryPanelEvent selectionChanged;

		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public GalleryPanelEvent2 pagerClicked;

		[Token(Token = "0x40005B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private AbsGalleryPaperTemplate[] mPapers;

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int mLastContentLength;

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private int mLastSelected;

		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Stack<AbsGalleryPaperTemplate> mGarbages;

		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public List<AbsGalleryPaperTemplate> mFadeouts;

		[Token(Token = "0x1700016A")]
		private int startIndex
		{
			[Token(Token = "0x600078F")]
			[Address(RVA = "0x8B1A10", Offset = "0x8B1A10", VA = "0x8B1A10")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000790")]
			[Address(RVA = "0x8B1A1C", Offset = "0x8B1A1C", VA = "0x8B1A1C")]
			set
			{
			}
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0x8B1A2C", Offset = "0x8B1A2C", VA = "0x8B1A2C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0x8B1C20", Offset = "0x8B1C20", VA = "0x8B1C20")]
		private AbsGalleryPaperTemplate CreatePaper(AbsGalleryPaperTemplate tempate)
		{
			return null;
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0x8B1ECC", Offset = "0x8B1ECC", VA = "0x8B1ECC")]
		private AbsGalleryPaperTemplate NewPaper(AbsGalleryPaperTemplate tempate)
		{
			return null;
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0x8B20A4", Offset = "0x8B20A4", VA = "0x8B20A4")]
		private void OnPaperClicked(AbsGalleryPaperTemplate sender)
		{
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0x8B2284", Offset = "0x8B2284", VA = "0x8B2284", Slot = "4")]
		public void OnScroll(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0x8B2320", Offset = "0x8B2320", VA = "0x8B2320")]
		private void Scroll(float dir)
		{
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0x8B233C", Offset = "0x8B233C", VA = "0x8B233C", Slot = "5")]
		protected virtual void OnSelectionChanged()
		{
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0x8B2470", Offset = "0x8B2470", VA = "0x8B2470")]
		private void Update()
		{
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0x8B31FC", Offset = "0x8B31FC", VA = "0x8B31FC")]
		public GalleryPanel()
		{
		}
	}
	[Token(Token = "0x200016F")]
	[RequireComponent(typeof(CanvasGroup))]
	public class GalleryPaperTemplate : AbsGalleryPaperTemplate
	{
		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RawImage image;

		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CanvasGroup mCanvasGroup;

		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private RectTransform mRectTransform;

		[Token(Token = "0x14000003")]
		public override event OnPagerClicked Clicked
		{
			[Token(Token = "0x600079D")]
			[Address(RVA = "0x8B330C", Offset = "0x8B330C", VA = "0x8B330C", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600079E")]
			[Address(RVA = "0x8B33A8", Offset = "0x8B33A8", VA = "0x8B33A8", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0x8B3444", Offset = "0x8B3444", VA = "0x8B3444", Slot = "8")]
		public override void OnSetContentIndex(int index, GalleryPanel panel)
		{
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x8B3514", Offset = "0x8B3514", VA = "0x8B3514")]
		private void Awake()
		{
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x8B3628", Offset = "0x8B3628", VA = "0x8B3628")]
		private void OnClicked()
		{
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x8B3648", Offset = "0x8B3648", VA = "0x8B3648", Slot = "9")]
		public override bool UpdatePaper(GalleryPanel panel)
		{
			return default(bool);
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x8B39CC", Offset = "0x8B39CC", VA = "0x8B39CC", Slot = "10")]
		public override void CopyStateFrom(AbsGalleryPaperTemplate from)
		{
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x8B3AAC", Offset = "0x8B3AAC", VA = "0x8B3AAC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x8B3AB4", Offset = "0x8B3AB4", VA = "0x8B3AB4")]
		public GalleryPaperTemplate()
		{
		}
	}
	[Token(Token = "0x2000170")]
	public abstract class AbsGalleryPaperTemplate : MonoBehaviour
	{
		[Token(Token = "0x2000171")]
		public delegate void OnPagerClicked(AbsGalleryPaperTemplate pager);

		[Token(Token = "0x1700016B")]
		public virtual AbsGalleryPaperTemplate targetState
		{
			[Token(Token = "0x60007A8")]
			[Address(RVA = "0x8B3AC4", Offset = "0x8B3AC4", VA = "0x8B3AC4", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60007A9")]
			[Address(RVA = "0x8B3ACC", Offset = "0x8B3ACC", VA = "0x8B3ACC", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x14000004")]
		[method: Token(Token = "0x60007A6")]
		public abstract event OnPagerClicked Clicked;

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x8B3AD4", Offset = "0x8B3AD4", VA = "0x8B3AD4", Slot = "8")]
		public virtual void OnSetContentIndex(int index, GalleryPanel panel)
		{
		}

		[Token(Token = "0x60007AB")]
		public abstract bool UpdatePaper(GalleryPanel panel);

		[Token(Token = "0x60007AC")]
		public abstract void CopyStateFrom(AbsGalleryPaperTemplate from);

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x8B3AD8", Offset = "0x8B3AD8", VA = "0x8B3AD8", Slot = "11")]
		public virtual AbsGalleryPaperTemplate CloneGameObject()
		{
			return null;
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x8B3ABC", Offset = "0x8B3ABC", VA = "0x8B3ABC")]
		protected AbsGalleryPaperTemplate()
		{
		}
	}
}
