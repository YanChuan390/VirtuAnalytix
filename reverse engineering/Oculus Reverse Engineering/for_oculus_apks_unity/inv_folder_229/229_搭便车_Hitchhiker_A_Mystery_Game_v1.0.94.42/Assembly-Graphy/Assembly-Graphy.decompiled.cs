using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Il2CppDummyDll;
using Tayx.Graphy.Advanced;
using Tayx.Graphy.Audio;
using Tayx.Graphy.Fps;
using Tayx.Graphy.Graph;
using Tayx.Graphy.Ram;
using Tayx.Graphy.UI;
using Tayx.Graphy.Utils;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Tayx.Graphy
{
	[Token(Token = "0x2000002")]
	public class GraphyDebugger : G_Singleton<GraphyDebugger>
	{
		[Token(Token = "0x2000003")]
		public enum DebugVariable
		{
			[Token(Token = "0x4000006")]
			Fps,
			[Token(Token = "0x4000007")]
			Fps_Min,
			[Token(Token = "0x4000008")]
			Fps_Max,
			[Token(Token = "0x4000009")]
			Fps_Avg,
			[Token(Token = "0x400000A")]
			Ram_Allocated,
			[Token(Token = "0x400000B")]
			Ram_Reserved,
			[Token(Token = "0x400000C")]
			Ram_Mono,
			[Token(Token = "0x400000D")]
			Audio_DB
		}

		[Token(Token = "0x2000004")]
		public enum DebugComparer
		{
			[Token(Token = "0x400000F")]
			Less_than,
			[Token(Token = "0x4000010")]
			Equals_or_less_than,
			[Token(Token = "0x4000011")]
			Equals,
			[Token(Token = "0x4000012")]
			Equals_or_greater_than,
			[Token(Token = "0x4000013")]
			Greater_than
		}

		[Token(Token = "0x2000005")]
		public enum ConditionEvaluation
		{
			[Token(Token = "0x4000015")]
			All_conditions_must_be_met,
			[Token(Token = "0x4000016")]
			Only_one_condition_has_to_be_met
		}

		[Token(Token = "0x2000006")]
		public enum MessageType
		{
			[Token(Token = "0x4000018")]
			Log,
			[Token(Token = "0x4000019")]
			Warning,
			[Token(Token = "0x400001A")]
			Error
		}

		[Serializable]
		[Token(Token = "0x2000007")]
		public struct DebugCondition
		{
			[Token(Token = "0x400001B")]
			[FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6AD04", Offset = "0xA6AD04")]
			public DebugVariable Variable;

			[Token(Token = "0x400001C")]
			[FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6AD3C", Offset = "0xA6AD3C")]
			public DebugComparer Comparer;

			[Token(Token = "0x400001D")]
			[FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6AD74", Offset = "0xA6AD74")]
			public float Value;
		}

		[Serializable]
		[Token(Token = "0x2000008")]
		public class DebugPacket
		{
			[Token(Token = "0x400001E")]
			[FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6ADAC", Offset = "0xA6ADAC")]
			public bool Active;

			[Token(Token = "0x400001F")]
			[FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6ADE4", Offset = "0xA6ADE4")]
			public int Id;

			[Token(Token = "0x4000020")]
			[FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6AE1C", Offset = "0xA6AE1C")]
			public bool ExecuteOnce;

			[Token(Token = "0x4000021")]
			[FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6AE54", Offset = "0xA6AE54")]
			public float InitSleepTime;

			[Token(Token = "0x4000022")]
			[FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6AE8C", Offset = "0xA6AE8C")]
			public float ExecuteSleepTime;

			[Token(Token = "0x4000023")]
			[FieldOffset(Offset = "0x24")]
			public ConditionEvaluation ConditionEvaluation;

			[Token(Token = "0x4000024")]
			[FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6AEC4", Offset = "0xA6AEC4")]
			public List<DebugCondition> DebugConditions;

			[Token(Token = "0x4000025")]
			[FieldOffset(Offset = "0x30")]
			public MessageType MessageType;

			[Token(Token = "0x4000026")]
			[FieldOffset(Offset = "0x38")]
			[Multiline]
			public string Message;

			[Token(Token = "0x4000027")]
			[FieldOffset(Offset = "0x40")]
			public bool TakeScreenshot;

			[Token(Token = "0x4000028")]
			[FieldOffset(Offset = "0x48")]
			public string ScreenshotFileName;

			[Token(Token = "0x4000029")]
			[FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6AF0C", Offset = "0xA6AF0C")]
			public bool DebugBreak;

			[Token(Token = "0x400002A")]
			[FieldOffset(Offset = "0x58")]
			public UnityEvent UnityEvents;

			[Token(Token = "0x400002B")]
			[FieldOffset(Offset = "0x60")]
			public List<Action> Callbacks;

			[Token(Token = "0x400002C")]
			[FieldOffset(Offset = "0x68")]
			private bool canBeChecked;

			[Token(Token = "0x400002D")]
			[FieldOffset(Offset = "0x69")]
			private bool executed;

			[Token(Token = "0x400002E")]
			[FieldOffset(Offset = "0x6C")]
			private float timePassed;

			[Token(Token = "0x17000001")]
			public bool Check
			{
				[Token(Token = "0x6000013")]
				[Address(RVA = "0x2361780", Offset = "0x2361780", VA = "0x2361780")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000014")]
			[Address(RVA = "0x235F480", Offset = "0x235F480", VA = "0x235F480")]
			public void Update()
			{
			}

			[Token(Token = "0x6000015")]
			[Address(RVA = "0x235FB9C", Offset = "0x235FB9C", VA = "0x235FB9C")]
			public void Executed()
			{
			}

			[Token(Token = "0x6000016")]
			[Address(RVA = "0x235EAF8", Offset = "0x235EAF8", VA = "0x235EAF8")]
			public DebugPacket()
			{
			}
		}

		[Token(Token = "0x2000009")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6AC04", Offset = "0xA6AC04")]
		private sealed class <>c__DisplayClass18_0
		{
			[Token(Token = "0x400002F")]
			[FieldOffset(Offset = "0x10")]
			public int packetId;

			[Token(Token = "0x6000017")]
			[Address(RVA = "0x235EFD8", Offset = "0x235EFD8", VA = "0x235EFD8")]
			public <>c__DisplayClass18_0()
			{
			}

			[Token(Token = "0x6000018")]
			[Address(RVA = "0x2361714", Offset = "0x2361714", VA = "0x2361714")]
			internal bool <GetFirstDebugPacketWithId>b__0(DebugPacket x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200000A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6AC14", Offset = "0xA6AC14")]
		private sealed class <>c__DisplayClass19_0
		{
			[Token(Token = "0x4000030")]
			[FieldOffset(Offset = "0x10")]
			public int packetId;

			[Token(Token = "0x6000019")]
			[Address(RVA = "0x235F0D0", Offset = "0x235F0D0", VA = "0x235F0D0")]
			public <>c__DisplayClass19_0()
			{
			}

			[Token(Token = "0x600001A")]
			[Address(RVA = "0x2361738", Offset = "0x2361738", VA = "0x2361738")]
			internal bool <GetAllDebugPacketsWithId>b__0(DebugPacket x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200000B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6AC24", Offset = "0xA6AC24")]
		private sealed class <>c__DisplayClass21_0
		{
			[Token(Token = "0x4000031")]
			[FieldOffset(Offset = "0x10")]
			public int packetId;

			[Token(Token = "0x600001B")]
			[Address(RVA = "0x235F274", Offset = "0x235F274", VA = "0x235F274")]
			public <>c__DisplayClass21_0()
			{
			}

			[Token(Token = "0x600001C")]
			[Address(RVA = "0x236175C", Offset = "0x236175C", VA = "0x236175C")]
			internal bool <RemoveAllDebugPacketsWithId>b__0(DebugPacket x)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x200000C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6AC34", Offset = "0xA6AC34")]
		private sealed class <>c
		{
			[Token(Token = "0x4000032")]
			[FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000033")]
			[FieldOffset(Offset = "0x8")]
			public static Predicate<DebugPacket> <>9__24_0;

			[Token(Token = "0x600001E")]
			[Address(RVA = "0x2361700", Offset = "0x2361700", VA = "0x2361700")]
			public <>c()
			{
			}

			[Token(Token = "0x600001F")]
			[Address(RVA = "0x2361708", Offset = "0x2361708", VA = "0x2361708")]
			internal bool <CheckDebugPackets>b__24_0(DebugPacket packet)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<DebugPacket> m_debugPackets;

		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x20")]
		private G_FpsMonitor m_fpsMonitor;

		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x28")]
		private G_RamMonitor m_ramMonitor;

		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x30")]
		private G_AudioMonitor m_audioMonitor;

		[Token(Token = "0x6000001")]
		[Address(RVA = "0x235E32C", Offset = "0x235E32C", VA = "0x235E32C")]
		protected GraphyDebugger()
		{
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x235E3F0", Offset = "0x235E3F0", VA = "0x235E3F0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x235E4AC", Offset = "0x235E4AC", VA = "0x235E4AC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x235E970", Offset = "0x235E970", VA = "0x235E970")]
		public void AddNewDebugPacket(DebugPacket newDebugPacket)
		{
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x235E9E0", Offset = "0x235E9E0", VA = "0x235E9E0")]
		public void AddNewDebugPacket(int newId, DebugCondition newDebugCondition, MessageType newMessageType, string newMessage, bool newDebugBreak, Action newCallback)
		{
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x235EC2C", Offset = "0x235EC2C", VA = "0x235EC2C")]
		public void AddNewDebugPacket(int newId, List<DebugCondition> newDebugConditions, MessageType newMessageType, string newMessage, bool newDebugBreak, Action newCallback)
		{
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x235ED1C", Offset = "0x235ED1C", VA = "0x235ED1C")]
		public void AddNewDebugPacket(int newId, DebugCondition newDebugCondition, MessageType newMessageType, string newMessage, bool newDebugBreak, List<Action> newCallbacks)
		{
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x235EE18", Offset = "0x235EE18", VA = "0x235EE18")]
		public void AddNewDebugPacket(int newId, List<DebugCondition> newDebugConditions, MessageType newMessageType, string newMessage, bool newDebugBreak, List<Action> newCallbacks)
		{
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x235EEEC", Offset = "0x235EEEC", VA = "0x235EEEC")]
		public DebugPacket GetFirstDebugPacketWithId(int packetId)
		{
			return null;
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x235EFE0", Offset = "0x235EFE0", VA = "0x235EFE0")]
		public List<DebugPacket> GetAllDebugPacketsWithId(int packetId)
		{
			return null;
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x235F0D8", Offset = "0x235F0D8", VA = "0x235F0D8")]
		public void RemoveFirstDebugPacketWithId(int packetId)
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x235F174", Offset = "0x235F174", VA = "0x235F174")]
		public void RemoveAllDebugPacketsWithId(int packetId)
		{
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x235F27C", Offset = "0x235F27C", VA = "0x235F27C")]
		public void AddCallbackToFirstDebugPacketWithId(Action callback, int id)
		{
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x235F314", Offset = "0x235F314", VA = "0x235F314")]
		public void AddCallbackToAllDebugPacketWithId(Action callback, int id)
		{
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x235E4B0", Offset = "0x235E4B0", VA = "0x235E4B0")]
		private void CheckDebugPackets()
		{
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x235F4E8", Offset = "0x235F4E8", VA = "0x235F4E8")]
		private bool CheckIfConditionIsMet(DebugCondition debugCondition)
		{
			return default(bool);
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x235F974", Offset = "0x235F974", VA = "0x235F974")]
		private float GetRequestedValueFromDebugVariable(DebugVariable debugVariable)
		{
			return default(float);
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x235F590", Offset = "0x235F590", VA = "0x235F590")]
		private void ExecuteOperationsInDebugPacket(DebugPacket debugPacket)
		{
		}
	}
	[Token(Token = "0x200000D")]
	public class GraphyManager : G_Singleton<GraphyManager>
	{
		[Token(Token = "0x200000E")]
		public enum Mode
		{
			[Token(Token = "0x4000066")]
			FULL,
			[Token(Token = "0x4000067")]
			LIGHT
		}

		[Token(Token = "0x200000F")]
		public enum ModuleType
		{
			[Token(Token = "0x4000069")]
			FPS,
			[Token(Token = "0x400006A")]
			RAM,
			[Token(Token = "0x400006B")]
			AUDIO,
			[Token(Token = "0x400006C")]
			ADVANCED
		}

		[Token(Token = "0x2000010")]
		public enum ModuleState
		{
			[Token(Token = "0x400006E")]
			FULL,
			[Token(Token = "0x400006F")]
			TEXT,
			[Token(Token = "0x4000070")]
			BASIC,
			[Token(Token = "0x4000071")]
			BACKGROUND,
			[Token(Token = "0x4000072")]
			OFF
		}

		[Token(Token = "0x2000011")]
		public enum ModulePosition
		{
			[Token(Token = "0x4000074")]
			TOP_RIGHT,
			[Token(Token = "0x4000075")]
			TOP_LEFT,
			[Token(Token = "0x4000076")]
			BOTTOM_RIGHT,
			[Token(Token = "0x4000077")]
			BOTTOM_LEFT,
			[Token(Token = "0x4000078")]
			FREE
		}

		[Token(Token = "0x2000012")]
		public enum LookForAudioListener
		{
			[Token(Token = "0x400007A")]
			ALWAYS,
			[Token(Token = "0x400007B")]
			ON_SCENE_LOAD,
			[Token(Token = "0x400007C")]
			NEVER
		}

		[Token(Token = "0x2000013")]
		public enum ModulePreset
		{
			[Token(Token = "0x400007E")]
			FPS_BASIC,
			[Token(Token = "0x400007F")]
			FPS_TEXT,
			[Token(Token = "0x4000080")]
			FPS_FULL,
			[Token(Token = "0x4000081")]
			FPS_TEXT_RAM_TEXT,
			[Token(Token = "0x4000082")]
			FPS_FULL_RAM_TEXT,
			[Token(Token = "0x4000083")]
			FPS_FULL_RAM_FULL,
			[Token(Token = "0x4000084")]
			FPS_TEXT_RAM_TEXT_AUDIO_TEXT,
			[Token(Token = "0x4000085")]
			FPS_FULL_RAM_TEXT_AUDIO_TEXT,
			[Token(Token = "0x4000086")]
			FPS_FULL_RAM_FULL_AUDIO_TEXT,
			[Token(Token = "0x4000087")]
			FPS_FULL_RAM_FULL_AUDIO_FULL,
			[Token(Token = "0x4000088")]
			FPS_FULL_RAM_FULL_AUDIO_FULL_ADVANCED_FULL,
			[Token(Token = "0x4000089")]
			FPS_BASIC_ADVANCED_FULL,
			[Token(Token = "0x400008A")]
			ADVANCED_FULL_SOLO,
			[Token(Token = "0x400008B")]
			EMPTY
		}

		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Mode m_graphyMode;

		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private bool m_enableOnStartup;

		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x1D")]
		[SerializeField]
		private bool m_keepAlive;

		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x1E")]
		[SerializeField]
		private bool m_background;

		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Color m_backgroundColor;

		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool m_enableHotkeys;

		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private KeyCode m_toggleModeKeyCode;

		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool m_toggleModeCtrl;

		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x39")]
		[SerializeField]
		private bool m_toggleModeAlt;

		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private KeyCode m_toggleActiveKeyCode;

		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool m_toggleActiveCtrl;

		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x41")]
		[SerializeField]
		private bool m_toggleActiveAlt;

		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private ModulePosition m_graphModulePosition;

		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ModuleState m_fpsModuleState;

		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6B024", Offset = "0xA6B024")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA6B024", Offset = "0xA6B024")]
		private int m_timeToResetMinMaxFps;

		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Color m_goodFpsColor;

		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private int m_goodFpsThreshold;

		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private Color m_cautionFpsColor;

		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private int m_cautionFpsThreshold;

		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Color m_criticalFpsColor;

		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA6B0DC", Offset = "0xA6B0DC")]
		private int m_fpsGraphResolution;

		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA6B120", Offset = "0xA6B120")]
		[SerializeField]
		private int m_fpsTextUpdateRate;

		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private ModuleState m_ramModuleState;

		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x94")]
		[SerializeField]
		private Color m_allocatedRamColor;

		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0xA4")]
		[SerializeField]
		private Color m_reservedRamColor;

		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0xB4")]
		[SerializeField]
		private Color m_monoRamColor;

		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0xC4")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA6B1A4", Offset = "0xA6B1A4")]
		private int m_ramGraphResolution;

		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA6B1E8", Offset = "0xA6B1E8")]
		private int m_ramTextUpdateRate;

		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0xCC")]
		[SerializeField]
		private ModuleState m_audioModuleState;

		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private LookForAudioListener m_findAudioListenerInCameraIfNull;

		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private AudioListener m_audioListener;

		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private Color m_audioGraphColor;

		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA6B26C", Offset = "0xA6B26C")]
		[SerializeField]
		private int m_audioGraphResolution;

		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0xF4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA6B2B0", Offset = "0xA6B2B0")]
		[SerializeField]
		private int m_audioTextUpdateRate;

		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private FFTWindow m_FFTWindow;

		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0xFC")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6B304", Offset = "0xA6B304")]
		private int m_spectrumSize;

		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private ModulePosition m_advancedModulePosition;

		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x104")]
		[SerializeField]
		private ModuleState m_advancedModuleState;

		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x108")]
		private bool m_initialized;

		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x109")]
		private bool m_active;

		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x10A")]
		private bool m_focused;

		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x110")]
		private G_FpsManager m_fpsManager;

		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x118")]
		private G_RamManager m_ramManager;

		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x120")]
		private G_AudioManager m_audioManager;

		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x128")]
		private G_AdvancedData m_advancedData;

		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x130")]
		private G_FpsMonitor m_fpsMonitor;

		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x138")]
		private G_RamMonitor m_ramMonitor;

		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x140")]
		private G_AudioMonitor m_audioMonitor;

		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x148")]
		private ModulePreset m_modulePresetState;

		[Token(Token = "0x17000002")]
		public Mode GraphyMode
		{
			[Token(Token = "0x6000021")]
			[Address(RVA = "0x235FE30", Offset = "0x235FE30", VA = "0x235FE30")]
			get
			{
				return default(Mode);
			}
			[Token(Token = "0x6000022")]
			[Address(RVA = "0x2353684", Offset = "0x2353684", VA = "0x2353684")]
			set
			{
			}
		}

		[Token(Token = "0x17000003")]
		public bool EnableOnStartup
		{
			[Token(Token = "0x6000023")]
			[Address(RVA = "0x235FE84", Offset = "0x235FE84", VA = "0x235FE84")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000004")]
		public bool KeepAlive
		{
			[Token(Token = "0x6000024")]
			[Address(RVA = "0x235FE8C", Offset = "0x235FE8C", VA = "0x235FE8C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000005")]
		public bool Background
		{
			[Token(Token = "0x6000025")]
			[Address(RVA = "0x235FE94", Offset = "0x235FE94", VA = "0x235FE94")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000026")]
			[Address(RVA = "0x235341C", Offset = "0x235341C", VA = "0x235341C")]
			set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public Color BackgroundColor
		{
			[Token(Token = "0x6000027")]
			[Address(RVA = "0x235FE9C", Offset = "0x235FE9C", VA = "0x235FE9C")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000028")]
			[Address(RVA = "0x23535DC", Offset = "0x23535DC", VA = "0x23535DC")]
			set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public ModulePosition GraphModulePosition
		{
			[Token(Token = "0x6000029")]
			[Address(RVA = "0x235FEA8", Offset = "0x235FEA8", VA = "0x235FEA8")]
			get
			{
				return default(ModulePosition);
			}
			[Token(Token = "0x600002A")]
			[Address(RVA = "0x23536A4", Offset = "0x23536A4", VA = "0x23536A4")]
			set
			{
			}
		}

		[Token(Token = "0x17000008")]
		public ModuleState FpsModuleState
		{
			[Token(Token = "0x600002B")]
			[Address(RVA = "0x235FEB0", Offset = "0x235FEB0", VA = "0x235FEB0")]
			get
			{
				return default(ModuleState);
			}
			[Token(Token = "0x600002C")]
			[Address(RVA = "0x2353708", Offset = "0x2353708", VA = "0x2353708")]
			set
			{
			}
		}

		[Token(Token = "0x17000009")]
		public int TimeToResetMinMaxFps
		{
			[Token(Token = "0x600002D")]
			[Address(RVA = "0x235FEB8", Offset = "0x235FEB8", VA = "0x235FEB8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600002E")]
			[Address(RVA = "0x2353DF4", Offset = "0x2353DF4", VA = "0x2353DF4")]
			set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		public Color GoodFPSColor
		{
			[Token(Token = "0x600002F")]
			[Address(RVA = "0x235FEC0", Offset = "0x235FEC0", VA = "0x235FEC0")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000030")]
			[Address(RVA = "0x23539D4", Offset = "0x23539D4", VA = "0x23539D4")]
			set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		public Color CautionFPSColor
		{
			[Token(Token = "0x6000031")]
			[Address(RVA = "0x235FECC", Offset = "0x235FECC", VA = "0x235FECC")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000032")]
			[Address(RVA = "0x2353BB0", Offset = "0x2353BB0", VA = "0x2353BB0")]
			set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		public Color CriticalFPSColor
		{
			[Token(Token = "0x6000033")]
			[Address(RVA = "0x235FED8", Offset = "0x235FED8", VA = "0x235FED8")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000034")]
			[Address(RVA = "0x2353D8C", Offset = "0x2353D8C", VA = "0x2353D8C")]
			set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		public int GoodFPSThreshold
		{
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x235FEE4", Offset = "0x235FEE4", VA = "0x235FEE4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000036")]
			[Address(RVA = "0x2353784", Offset = "0x2353784", VA = "0x2353784")]
			set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		public int CautionFPSThreshold
		{
			[Token(Token = "0x6000037")]
			[Address(RVA = "0x235FEEC", Offset = "0x235FEEC", VA = "0x235FEEC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000038")]
			[Address(RVA = "0x23537FC", Offset = "0x23537FC", VA = "0x23537FC")]
			set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public int FpsGraphResolution
		{
			[Token(Token = "0x6000039")]
			[Address(RVA = "0x235FEF4", Offset = "0x235FEF4", VA = "0x235FEF4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600003A")]
			[Address(RVA = "0x2353E58", Offset = "0x2353E58", VA = "0x2353E58")]
			set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public int FpsTextUpdateRate
		{
			[Token(Token = "0x600003B")]
			[Address(RVA = "0x235FEFC", Offset = "0x235FEFC", VA = "0x235FEFC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600003C")]
			[Address(RVA = "0x2353EBC", Offset = "0x2353EBC", VA = "0x2353EBC")]
			set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public float CurrentFPS
		{
			[Token(Token = "0x600003D")]
			[Address(RVA = "0x235FF04", Offset = "0x235FF04", VA = "0x235FF04")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000012")]
		public float AverageFPS
		{
			[Token(Token = "0x600003E")]
			[Address(RVA = "0x235FF20", Offset = "0x235FF20", VA = "0x235FF20")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000013")]
		public float MinFPS
		{
			[Token(Token = "0x600003F")]
			[Address(RVA = "0x235FF3C", Offset = "0x235FF3C", VA = "0x235FF3C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000014")]
		public float MaxFPS
		{
			[Token(Token = "0x6000040")]
			[Address(RVA = "0x235FF58", Offset = "0x235FF58", VA = "0x235FF58")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000015")]
		public ModuleState RamModuleState
		{
			[Token(Token = "0x6000041")]
			[Address(RVA = "0x235FF74", Offset = "0x235FF74", VA = "0x235FF74")]
			get
			{
				return default(ModuleState);
			}
			[Token(Token = "0x6000042")]
			[Address(RVA = "0x2353EF4", Offset = "0x2353EF4", VA = "0x2353EF4")]
			set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public Color AllocatedRamColor
		{
			[Token(Token = "0x6000043")]
			[Address(RVA = "0x235FF7C", Offset = "0x235FF7C", VA = "0x235FF7C")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000044")]
			[Address(RVA = "0x23542AC", Offset = "0x23542AC", VA = "0x23542AC")]
			set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public Color ReservedRamColor
		{
			[Token(Token = "0x6000045")]
			[Address(RVA = "0x235FF88", Offset = "0x235FF88", VA = "0x235FF88")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000046")]
			[Address(RVA = "0x23540D0", Offset = "0x23540D0", VA = "0x23540D0")]
			set
			{
			}
		}

		[Token(Token = "0x17000018")]
		public Color MonoRamColor
		{
			[Token(Token = "0x6000047")]
			[Address(RVA = "0x235FF94", Offset = "0x235FF94", VA = "0x235FF94")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000048")]
			[Address(RVA = "0x2354488", Offset = "0x2354488", VA = "0x2354488")]
			set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public int RamGraphResolution
		{
			[Token(Token = "0x6000049")]
			[Address(RVA = "0x235FFA0", Offset = "0x235FFA0", VA = "0x235FFA0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600004A")]
			[Address(RVA = "0x23544F0", Offset = "0x23544F0", VA = "0x23544F0")]
			set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		public int RamTextUpdateRate
		{
			[Token(Token = "0x600004B")]
			[Address(RVA = "0x235FFA8", Offset = "0x235FFA8", VA = "0x235FFA8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600004C")]
			[Address(RVA = "0x2354554", Offset = "0x2354554", VA = "0x2354554")]
			set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public float AllocatedRam
		{
			[Token(Token = "0x600004D")]
			[Address(RVA = "0x235FFB0", Offset = "0x235FFB0", VA = "0x235FFB0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700001C")]
		public float ReservedRam
		{
			[Token(Token = "0x600004E")]
			[Address(RVA = "0x235FFCC", Offset = "0x235FFCC", VA = "0x235FFCC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700001D")]
		public float MonoRam
		{
			[Token(Token = "0x600004F")]
			[Address(RVA = "0x235FFE8", Offset = "0x235FFE8", VA = "0x235FFE8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700001E")]
		public ModuleState AudioModuleState
		{
			[Token(Token = "0x6000050")]
			[Address(RVA = "0x2360004", Offset = "0x2360004", VA = "0x2360004")]
			get
			{
				return default(ModuleState);
			}
			[Token(Token = "0x6000051")]
			[Address(RVA = "0x235458C", Offset = "0x235458C", VA = "0x235458C")]
			set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public AudioListener AudioListener
		{
			[Token(Token = "0x6000052")]
			[Address(RVA = "0x236000C", Offset = "0x236000C", VA = "0x236000C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000053")]
			[Address(RVA = "0x2360014", Offset = "0x2360014", VA = "0x2360014")]
			set
			{
			}
		}

		[Token(Token = "0x17000020")]
		public LookForAudioListener FindAudioListenerInCameraIfNull
		{
			[Token(Token = "0x6000054")]
			[Address(RVA = "0x2360048", Offset = "0x2360048", VA = "0x2360048")]
			get
			{
				return default(LookForAudioListener);
			}
			[Token(Token = "0x6000055")]
			[Address(RVA = "0x23547B4", Offset = "0x23547B4", VA = "0x23547B4")]
			set
			{
			}
		}

		[Token(Token = "0x17000021")]
		public Color AudioGraphColor
		{
			[Token(Token = "0x6000056")]
			[Address(RVA = "0x2360050", Offset = "0x2360050", VA = "0x2360050")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000057")]
			[Address(RVA = "0x2354768", Offset = "0x2354768", VA = "0x2354768")]
			set
			{
			}
		}

		[Token(Token = "0x17000022")]
		public int AudioGraphResolution
		{
			[Token(Token = "0x6000058")]
			[Address(RVA = "0x236005C", Offset = "0x236005C", VA = "0x236005C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000059")]
			[Address(RVA = "0x23548C4", Offset = "0x23548C4", VA = "0x23548C4")]
			set
			{
			}
		}

		[Token(Token = "0x17000023")]
		public int AudioTextUpdateRate
		{
			[Token(Token = "0x600005A")]
			[Address(RVA = "0x2360064", Offset = "0x2360064", VA = "0x2360064")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600005B")]
			[Address(RVA = "0x2354928", Offset = "0x2354928", VA = "0x2354928")]
			set
			{
			}
		}

		[Token(Token = "0x17000024")]
		public FFTWindow FftWindow
		{
			[Token(Token = "0x600005C")]
			[Address(RVA = "0x236006C", Offset = "0x236006C", VA = "0x236006C")]
			get
			{
				return default(FFTWindow);
			}
			[Token(Token = "0x600005D")]
			[Address(RVA = "0x23547FC", Offset = "0x23547FC", VA = "0x23547FC")]
			set
			{
			}
		}

		[Token(Token = "0x17000025")]
		public int SpectrumSize
		{
			[Token(Token = "0x600005E")]
			[Address(RVA = "0x2360074", Offset = "0x2360074", VA = "0x2360074")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600005F")]
			[Address(RVA = "0x2354860", Offset = "0x2354860", VA = "0x2354860")]
			set
			{
			}
		}

		[Token(Token = "0x17000026")]
		public float[] Spectrum
		{
			[Token(Token = "0x6000060")]
			[Address(RVA = "0x236007C", Offset = "0x236007C", VA = "0x236007C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000027")]
		public float MaxDB
		{
			[Token(Token = "0x6000061")]
			[Address(RVA = "0x2360098", Offset = "0x2360098", VA = "0x2360098")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000028")]
		public ModuleState AdvancedModuleState
		{
			[Token(Token = "0x6000062")]
			[Address(RVA = "0x23600B4", Offset = "0x23600B4", VA = "0x23600B4")]
			get
			{
				return default(ModuleState);
			}
			[Token(Token = "0x6000063")]
			[Address(RVA = "0x23549A4", Offset = "0x23549A4", VA = "0x23549A4")]
			set
			{
			}
		}

		[Token(Token = "0x17000029")]
		public ModulePosition AdvancedModulePosition
		{
			[Token(Token = "0x6000064")]
			[Address(RVA = "0x23600BC", Offset = "0x23600BC", VA = "0x23600BC")]
			get
			{
				return default(ModulePosition);
			}
			[Token(Token = "0x6000065")]
			[Address(RVA = "0x2354960", Offset = "0x2354960", VA = "0x2354960")]
			set
			{
			}
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x235FBA8", Offset = "0x235FBA8", VA = "0x235FBA8")]
		protected GraphyManager()
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x23600C4", Offset = "0x23600C4", VA = "0x23600C4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x2360614", Offset = "0x2360614", VA = "0x2360614")]
		private void Update()
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x23607B4", Offset = "0x23607B4", VA = "0x23607B4")]
		private void OnApplicationFocus(bool isFocused)
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x236081C", Offset = "0x236081C", VA = "0x236081C")]
		public void SetModulePosition(ModuleType moduleType, ModulePosition modulePosition)
		{
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x23608A0", Offset = "0x23608A0", VA = "0x23608A0")]
		public void SetModuleMode(ModuleType moduleType, ModuleState moduleState)
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x2360934", Offset = "0x2360934", VA = "0x2360934")]
		public void ToggleModes()
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x2360A30", Offset = "0x2360A30", VA = "0x2360A30")]
		public void SetPreset(ModulePreset modulePreset)
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x2360C8C", Offset = "0x2360C8C", VA = "0x2360C8C")]
		public void ToggleActive()
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x2360C9C", Offset = "0x2360C9C", VA = "0x2360C9C")]
		public void Enable()
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x2360D14", Offset = "0x2360D14", VA = "0x2360D14")]
		public void Disable()
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x23600C8", Offset = "0x23600C8", VA = "0x23600C8")]
		private void Init()
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x236062C", Offset = "0x236062C", VA = "0x236062C")]
		private void CheckForHotkeyPresses()
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x2360EC8", Offset = "0x2360EC8", VA = "0x2360EC8")]
		private bool CheckFor1KeyPress(KeyCode key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x2360E58", Offset = "0x2360E58", VA = "0x2360E58")]
		private bool CheckFor2KeyPress(KeyCode key1, KeyCode key2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x2360D88", Offset = "0x2360D88", VA = "0x2360D88")]
		private bool CheckFor3KeyPress(KeyCode key1, KeyCode key2, KeyCode key3)
		{
			return default(bool);
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x235FE38", Offset = "0x235FE38", VA = "0x235FE38")]
		private void UpdateAllParameters()
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x23607D0", Offset = "0x23607D0", VA = "0x23607D0")]
		private void RefreshAllParameters()
		{
		}
	}
	[Token(Token = "0x2000014")]
	public class G_GraphShader
	{
		[Token(Token = "0x400008C")]
		public const int ArrayMaxSizeFull = 512;

		[Token(Token = "0x400008D")]
		public const int ArrayMaxSizeLight = 128;

		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0x10")]
		public int ArrayMaxSize;

		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0x18")]
		public float[] Array;

		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0x20")]
		public Image Image;

		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0x28")]
		private string Name;

		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0x30")]
		private string Name_Length;

		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0x38")]
		public float Average;

		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0x3C")]
		private int averagePropertyId;

		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0x40")]
		public float GoodThreshold;

		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0x44")]
		public float CautionThreshold;

		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0x48")]
		private int goodThresholdPropertyId;

		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x4C")]
		private int cautionThresholdPropertyId;

		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x50")]
		public Color GoodColor;

		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x60")]
		public Color CautionColor;

		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x70")]
		public Color CriticalColor;

		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x80")]
		private int goodColorPropertyId;

		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x84")]
		private int cautionColorPropertyId;

		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x88")]
		private int criticalColorPropertyId;

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x2357628", Offset = "0x2357628", VA = "0x2357628")]
		public void InitializeShader()
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x23580F0", Offset = "0x23580F0", VA = "0x23580F0")]
		public void UpdateArray()
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x2358140", Offset = "0x2358140", VA = "0x2358140")]
		public void UpdateAverage()
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x235807C", Offset = "0x235807C", VA = "0x235807C")]
		public void UpdateThresholds()
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x2357FD0", Offset = "0x2357FD0", VA = "0x2357FD0")]
		public void UpdateColors()
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x2357D10", Offset = "0x2357D10", VA = "0x2357D10")]
		public void UpdatePoints()
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x2358188", Offset = "0x2358188", VA = "0x2358188")]
		public G_GraphShader()
		{
		}
	}
}
namespace Tayx.Graphy.Utils
{
	[Token(Token = "0x2000015")]
	public static class G_ExtensionMethods
	{
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x2358B80", Offset = "0x2358B80", VA = "0x2358B80")]
		public static List<GameObject> SetAllActive(this List<GameObject> gameObjects, bool active)
		{
			return null;
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x2358CF8", Offset = "0x2358CF8", VA = "0x2358CF8")]
		public static List<Image> SetOneActive(this List<Image> images, int active)
		{
			return null;
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x23566C8", Offset = "0x23566C8", VA = "0x23566C8")]
		public static List<Image> SetAllActive(this List<Image> images, bool active)
		{
			return null;
		}
	}
	[Token(Token = "0x2000016")]
	public class G_Singleton<T> : MonoBehaviour where T : MonoBehaviour
	{
		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x0")]
		private static T _instance;

		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x0")]
		private static object _lock;

		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x0")]
		private static bool _applicationIsQuitting;

		[Token(Token = "0x1700002A")]
		public static T Instance
		{
			[Token(Token = "0x6000081")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000082")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000083")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000084")]
		public G_Singleton()
		{
		}
	}
}
namespace Tayx.Graphy.Utils.NumString
{
	[Token(Token = "0x2000017")]
	public static class G_FloatString
	{
		[Token(Token = "0x40000A2")]
		private const string floatFormat = "0.0";

		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x0")]
		private static float decimalMultiplier;

		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x8")]
		private static string[] negativeBuffer;

		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x10")]
		private static string[] positiveBuffer;

		[Token(Token = "0x1700002B")]
		public static bool Inited
		{
			[Token(Token = "0x6000086")]
			[Address(RVA = "0x2356ADC", Offset = "0x2356ADC", VA = "0x2356ADC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002C")]
		public static float MinValue
		{
			[Token(Token = "0x6000087")]
			[Address(RVA = "0x2356B88", Offset = "0x2356B88", VA = "0x2356B88")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002D")]
		public static float MaxValue
		{
			[Token(Token = "0x6000088")]
			[Address(RVA = "0x2356C04", Offset = "0x2356C04", VA = "0x2356C04")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x2356C78", Offset = "0x2356C78", VA = "0x2356C78")]
		public static void Init(float minNegativeValue, float maxPositiveValue, int decimals = 1)
		{
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x2355FF4", Offset = "0x2355FF4", VA = "0x2355FF4")]
		public static string ToStringNonAlloc(this float value)
		{
			return null;
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x235A8DC", Offset = "0x235A8DC", VA = "0x235A8DC")]
		public static string ToStringNonAlloc(this float value, string format)
		{
			return null;
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x235AA60", Offset = "0x235AA60", VA = "0x235AA60")]
		public static int ToInt(this float f)
		{
			return default(int);
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x235AA80", Offset = "0x235AA80", VA = "0x235AA80")]
		public static float ToFloat(this int i)
		{
			return default(float);
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x235A82C", Offset = "0x235A82C", VA = "0x235A82C")]
		private static int Pow(int f, int p)
		{
			return default(int);
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x235A848", Offset = "0x235A848", VA = "0x235A848")]
		private static int ToIndex(this float f)
		{
			return default(int);
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x235A7BC", Offset = "0x235A7BC", VA = "0x235A7BC")]
		private static float FromIndex(this int i)
		{
			return default(float);
		}
	}
	[Token(Token = "0x2000018")]
	public static class G_IntString
	{
		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x0")]
		private static string[] negativeBuffer;

		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x8")]
		private static string[] positiveBuffer;

		[Token(Token = "0x1700002E")]
		public static bool Inited
		{
			[Token(Token = "0x6000092")]
			[Address(RVA = "0x235C4C0", Offset = "0x235C4C0", VA = "0x235C4C0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002F")]
		public static int MinValue
		{
			[Token(Token = "0x6000093")]
			[Address(RVA = "0x235C56C", Offset = "0x235C56C", VA = "0x235C56C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000030")]
		public static int MaxValue
		{
			[Token(Token = "0x6000094")]
			[Address(RVA = "0x235C5E4", Offset = "0x235C5E4", VA = "0x235C5E4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x235C658", Offset = "0x235C658", VA = "0x235C658")]
		public static void Init(int minNegativeValue, int maxPositiveValue)
		{
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x2355EB4", Offset = "0x2355EB4", VA = "0x2355EB4")]
		public static string ToStringNonAlloc(this int value)
		{
			return null;
		}
	}
}
namespace Tayx.Graphy.UI
{
	[Token(Token = "0x2000019")]
	public interface IModifiableState
	{
		[Token(Token = "0x6000098")]
		void SetState(GraphyManager.ModuleState newState, bool silentUpdate);
	}
	[Token(Token = "0x200001A")]
	public interface IMovable
	{
		[Token(Token = "0x6000099")]
		void SetPosition(GraphyManager.ModulePosition newModulePosition);
	}
}
namespace Tayx.Graphy.Ram
{
	[Token(Token = "0x200001B")]
	public class G_RamGraph : G_Graph
	{
		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image m_imageAllocated;

		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image m_imageReserved;

		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image m_imageMono;

		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Shader ShaderFull;

		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Shader ShaderLight;

		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x40")]
		private GraphyManager m_graphyManager;

		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x48")]
		private G_RamMonitor m_ramMonitor;

		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0x50")]
		private int m_resolution;

		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0x58")]
		private G_GraphShader m_shaderGraphAllocated;

		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0x60")]
		private G_GraphShader m_shaderGraphReserved;

		[Token(Token = "0x40000B2")]
		[FieldOffset(Offset = "0x68")]
		private G_GraphShader m_shaderGraphMono;

		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0x70")]
		private float[] m_allocatedArray;

		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0x78")]
		private float[] m_reservedArray;

		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x80")]
		private float[] m_monoArray;

		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x88")]
		private float m_highestMemory;

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x235C97C", Offset = "0x235C97C", VA = "0x235C97C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x235CAE8", Offset = "0x235CAE8", VA = "0x235CAE8")]
		private void Update()
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x235CAF4", Offset = "0x235CAF4", VA = "0x235CAF4")]
		public void UpdateParameters()
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x235CD8C", Offset = "0x235CD8C", VA = "0x235CD8C", Slot = "4")]
		protected override void UpdateGraph()
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x235D024", Offset = "0x235D024", VA = "0x235D024", Slot = "5")]
		protected override void CreatePoints()
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x235C980", Offset = "0x235C980", VA = "0x235C980")]
		private void Init()
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x235D398", Offset = "0x235D398", VA = "0x235D398")]
		public G_RamGraph()
		{
		}
	}
	[Token(Token = "0x200001C")]
	public class G_RamManager : MonoBehaviour, IMovable, IModifiableState
	{
		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject m_ramGraphGameObject;

		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<Image> m_backgroundImages;

		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0x28")]
		private GraphyManager m_graphyManager;

		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0x30")]
		private G_RamGraph m_ramGraph;

		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0x38")]
		private G_RamText m_ramText;

		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0x40")]
		private RectTransform m_rectTransform;

		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0x48")]
		private List<GameObject> m_childrenGameObjects;

		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0x50")]
		private GraphyManager.ModuleState m_previousModuleState;

		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0x54")]
		private GraphyManager.ModuleState m_currentModuleState;

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x235D3A8", Offset = "0x235D3A8", VA = "0x235D3A8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x235D7DC", Offset = "0x235D7DC", VA = "0x235D7DC")]
		private void Start()
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x235D948", Offset = "0x235D948", VA = "0x235D948", Slot = "4")]
		public void SetPosition(GraphyManager.ModulePosition newModulePosition)
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x235DAFC", Offset = "0x235DAFC", VA = "0x235DAFC", Slot = "5")]
		public void SetState(GraphyManager.ModuleState state, bool silentUpdate = false)
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x235DCA8", Offset = "0x235DCA8", VA = "0x235DCA8")]
		public void RestorePreviousState()
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x235D7E0", Offset = "0x235D7E0", VA = "0x235D7E0")]
		public void UpdateParameters()
		{
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x235DD60", Offset = "0x235DD60", VA = "0x235DD60")]
		public void RefreshParameters()
		{
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x235D3AC", Offset = "0x235D3AC", VA = "0x235D3AC")]
		private void Init()
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x235DC60", Offset = "0x235DC60", VA = "0x235DC60")]
		private void SetGraphActive(bool active)
		{
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x235DEC0", Offset = "0x235DEC0", VA = "0x235DEC0")]
		public G_RamManager()
		{
		}
	}
	[Token(Token = "0x200001D")]
	public class G_RamMonitor : MonoBehaviour
	{
		[Token(Token = "0x40000C0")]
		[FieldOffset(Offset = "0x18")]
		private float m_allocatedRam;

		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0x1C")]
		private float m_reservedRam;

		[Token(Token = "0x40000C2")]
		[FieldOffset(Offset = "0x20")]
		private float m_monoRam;

		[Token(Token = "0x17000031")]
		public float AllocatedRam
		{
			[Token(Token = "0x60000AB")]
			[Address(RVA = "0x235DF90", Offset = "0x235DF90", VA = "0x235DF90")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000032")]
		public float ReservedRam
		{
			[Token(Token = "0x60000AC")]
			[Address(RVA = "0x235DF98", Offset = "0x235DF98", VA = "0x235DF98")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000033")]
		public float MonoRam
		{
			[Token(Token = "0x60000AD")]
			[Address(RVA = "0x235DFA0", Offset = "0x235DFA0", VA = "0x235DFA0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x235DFA8", Offset = "0x235DFA8", VA = "0x235DFA8")]
		private void Update()
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x235E010", Offset = "0x235E010", VA = "0x235E010")]
		public G_RamMonitor()
		{
		}
	}
	[Token(Token = "0x200001E")]
	public class G_RamText : MonoBehaviour
	{
		[Token(Token = "0x40000C3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text m_allocatedSystemMemorySizeText;

		[Token(Token = "0x40000C4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text m_reservedSystemMemorySizeText;

		[Token(Token = "0x40000C5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text m_monoSystemMemorySizeText;

		[Token(Token = "0x40000C6")]
		[FieldOffset(Offset = "0x30")]
		private GraphyManager m_graphyManager;

		[Token(Token = "0x40000C7")]
		[FieldOffset(Offset = "0x38")]
		private G_RamMonitor m_ramMonitor;

		[Token(Token = "0x40000C8")]
		[FieldOffset(Offset = "0x40")]
		private float m_updateRate;

		[Token(Token = "0x40000C9")]
		[FieldOffset(Offset = "0x44")]
		private float m_deltaTime;

		[Token(Token = "0x40000CA")]
		[FieldOffset(Offset = "0x48")]
		private readonly string m_memoryStringFormat;

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x235E018", Offset = "0x235E018", VA = "0x235E018")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x235E188", Offset = "0x235E188", VA = "0x235E188")]
		private void Update()
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x235DCB4", Offset = "0x235DCB4", VA = "0x235DCB4")]
		public void UpdateParameters()
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x235E01C", Offset = "0x235E01C", VA = "0x235E01C")]
		private void Init()
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x235E2C8", Offset = "0x235E2C8", VA = "0x235E2C8")]
		public G_RamText()
		{
		}
	}
}
namespace Tayx.Graphy.Graph
{
	[Token(Token = "0x200001F")]
	public abstract class G_Graph : MonoBehaviour
	{
		[Token(Token = "0x60000B5")]
		protected abstract void UpdateGraph();

		[Token(Token = "0x60000B6")]
		protected abstract void CreatePoints();

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x2358250", Offset = "0x2358250", VA = "0x2358250")]
		protected G_Graph()
		{
		}
	}
}
namespace Tayx.Graphy.Fps
{
	[Token(Token = "0x2000020")]
	public class G_FpsGraph : G_Graph
	{
		[Token(Token = "0x40000CB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image m_imageGraph;

		[Token(Token = "0x40000CC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Shader ShaderFull;

		[Token(Token = "0x40000CD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Shader ShaderLight;

		[Token(Token = "0x40000CE")]
		[FieldOffset(Offset = "0x30")]
		private GraphyManager m_graphyManager;

		[Token(Token = "0x40000CF")]
		[FieldOffset(Offset = "0x38")]
		private G_FpsMonitor m_fpsMonitor;

		[Token(Token = "0x40000D0")]
		[FieldOffset(Offset = "0x40")]
		private int m_resolution;

		[Token(Token = "0x40000D1")]
		[FieldOffset(Offset = "0x48")]
		private G_GraphShader m_shaderGraph;

		[Token(Token = "0x40000D2")]
		[FieldOffset(Offset = "0x50")]
		private int[] m_fpsArray;

		[Token(Token = "0x40000D3")]
		[FieldOffset(Offset = "0x58")]
		private int m_highestFps;

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x235AB30", Offset = "0x235AB30", VA = "0x235AB30")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x235AC2C", Offset = "0x235AC2C", VA = "0x235AC2C")]
		private void Update()
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x235AC38", Offset = "0x235AC38", VA = "0x235AC38")]
		public void UpdateParameters()
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x235AD58", Offset = "0x235AD58", VA = "0x235AD58", Slot = "4")]
		protected override void UpdateGraph()
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x235AF70", Offset = "0x235AF70", VA = "0x235AF70", Slot = "5")]
		protected override void CreatePoints()
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x235AB34", Offset = "0x235AB34", VA = "0x235AB34")]
		private void Init()
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x235B0B8", Offset = "0x235B0B8", VA = "0x235B0B8")]
		public G_FpsGraph()
		{
		}
	}
	[Token(Token = "0x2000021")]
	public class G_FpsManager : MonoBehaviour, IMovable, IModifiableState
	{
		[Token(Token = "0x40000D4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject m_fpsGraphGameObject;

		[Token(Token = "0x40000D5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<GameObject> m_nonBasicTextGameObjects;

		[Token(Token = "0x40000D6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<Image> m_backgroundImages;

		[Token(Token = "0x40000D7")]
		[FieldOffset(Offset = "0x30")]
		private GraphyManager m_graphyManager;

		[Token(Token = "0x40000D8")]
		[FieldOffset(Offset = "0x38")]
		private G_FpsGraph m_fpsGraph;

		[Token(Token = "0x40000D9")]
		[FieldOffset(Offset = "0x40")]
		private G_FpsMonitor m_fpsMonitor;

		[Token(Token = "0x40000DA")]
		[FieldOffset(Offset = "0x48")]
		private G_FpsText m_fpsText;

		[Token(Token = "0x40000DB")]
		[FieldOffset(Offset = "0x50")]
		private RectTransform m_rectTransform;

		[Token(Token = "0x40000DC")]
		[FieldOffset(Offset = "0x58")]
		private List<GameObject> m_childrenGameObjects;

		[Token(Token = "0x40000DD")]
		[FieldOffset(Offset = "0x60")]
		private GraphyManager.ModuleState m_previousModuleState;

		[Token(Token = "0x40000DE")]
		[FieldOffset(Offset = "0x64")]
		private GraphyManager.ModuleState m_currentModuleState;

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x235B0C8", Offset = "0x235B0C8", VA = "0x235B0C8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x235B52C", Offset = "0x235B52C", VA = "0x235B52C")]
		private void Start()
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x235B6CC", Offset = "0x235B6CC", VA = "0x235B6CC", Slot = "4")]
		public void SetPosition(GraphyManager.ModulePosition newModulePosition)
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x235B880", Offset = "0x235B880", VA = "0x235B880", Slot = "5")]
		public void SetState(GraphyManager.ModuleState state, bool silentUpdate = false)
		{
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x235BA8C", Offset = "0x235BA8C", VA = "0x235BA8C")]
		public void RestorePreviousState()
		{
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x235B530", Offset = "0x235B530", VA = "0x235B530")]
		public void UpdateParameters()
		{
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x235BAD8", Offset = "0x235BAD8", VA = "0x235BAD8")]
		public void RefreshParameters()
		{
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x235B0CC", Offset = "0x235B0CC", VA = "0x235B0CC")]
		private void Init()
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x235BA44", Offset = "0x235BA44", VA = "0x235BA44")]
		private void SetGraphActive(bool active)
		{
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x235BC6C", Offset = "0x235BC6C", VA = "0x235BC6C")]
		public G_FpsManager()
		{
		}
	}
	[Token(Token = "0x2000022")]
	public class G_FpsMonitor : MonoBehaviour
	{
		[Token(Token = "0x40000DF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int m_averageSamples;

		[Token(Token = "0x40000E0")]
		[FieldOffset(Offset = "0x20")]
		private GraphyManager m_graphyManager;

		[Token(Token = "0x40000E1")]
		[FieldOffset(Offset = "0x28")]
		private float m_currentFps;

		[Token(Token = "0x40000E2")]
		[FieldOffset(Offset = "0x2C")]
		private float m_avgFps;

		[Token(Token = "0x40000E3")]
		[FieldOffset(Offset = "0x30")]
		private float m_minFps;

		[Token(Token = "0x40000E4")]
		[FieldOffset(Offset = "0x34")]
		private float m_maxFps;

		[Token(Token = "0x40000E5")]
		[FieldOffset(Offset = "0x38")]
		private List<float> m_averageFpsSamples;

		[Token(Token = "0x40000E6")]
		[FieldOffset(Offset = "0x40")]
		private int m_timeToResetMinMaxFps;

		[Token(Token = "0x40000E7")]
		[FieldOffset(Offset = "0x44")]
		private float m_timeToResetMinFpsPassed;

		[Token(Token = "0x40000E8")]
		[FieldOffset(Offset = "0x48")]
		private float m_timeToResetMaxFpsPassed;

		[Token(Token = "0x40000E9")]
		[FieldOffset(Offset = "0x4C")]
		private float unscaledDeltaTime;

		[Token(Token = "0x17000034")]
		public float CurrentFPS
		{
			[Token(Token = "0x60000C9")]
			[Address(RVA = "0x235BD68", Offset = "0x235BD68", VA = "0x235BD68")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000035")]
		public float AverageFPS
		{
			[Token(Token = "0x60000CA")]
			[Address(RVA = "0x235BD70", Offset = "0x235BD70", VA = "0x235BD70")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000036")]
		public float MinFPS
		{
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0x235BD78", Offset = "0x235BD78", VA = "0x235BD78")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000037")]
		public float MaxFPS
		{
			[Token(Token = "0x60000CC")]
			[Address(RVA = "0x235BD80", Offset = "0x235BD80", VA = "0x235BD80")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x235BD88", Offset = "0x235BD88", VA = "0x235BD88")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x235BE70", Offset = "0x235BE70", VA = "0x235BE70")]
		private void Update()
		{
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x235BA98", Offset = "0x235BA98", VA = "0x235BA98")]
		public void UpdateParameters()
		{
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x235BD8C", Offset = "0x235BD8C", VA = "0x235BD8C")]
		private void Init()
		{
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x235C030", Offset = "0x235C030", VA = "0x235C030")]
		public G_FpsMonitor()
		{
		}
	}
	[Token(Token = "0x2000023")]
	public class G_FpsText : MonoBehaviour
	{
		[Token(Token = "0x40000EA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text m_fpsText;

		[Token(Token = "0x40000EB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text m_msText;

		[Token(Token = "0x40000EC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text m_avgFpsText;

		[Token(Token = "0x40000ED")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text m_minFpsText;

		[Token(Token = "0x40000EE")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text m_maxFpsText;

		[Token(Token = "0x40000EF")]
		[FieldOffset(Offset = "0x40")]
		private GraphyManager m_graphyManager;

		[Token(Token = "0x40000F0")]
		[FieldOffset(Offset = "0x48")]
		private G_FpsMonitor m_fpsMonitor;

		[Token(Token = "0x40000F1")]
		[FieldOffset(Offset = "0x50")]
		private int m_updateRate;

		[Token(Token = "0x40000F2")]
		[FieldOffset(Offset = "0x54")]
		private int m_frameCount;

		[Token(Token = "0x40000F3")]
		[FieldOffset(Offset = "0x58")]
		private float m_deltaTime;

		[Token(Token = "0x40000F4")]
		[FieldOffset(Offset = "0x5C")]
		private float m_fps;

		[Token(Token = "0x40000F5")]
		private const int m_minFps = 0;

		[Token(Token = "0x40000F6")]
		private const int m_maxFps = 10000;

		[Token(Token = "0x40000F7")]
		private const string m_msStringFormat = "0.0";

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x235C048", Offset = "0x235C048", VA = "0x235C048")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x235C1B0", Offset = "0x235C1B0", VA = "0x235C1B0")]
		private void Update()
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x235BAB8", Offset = "0x235BAB8", VA = "0x235BAB8")]
		public void UpdateParameters()
		{
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x235C440", Offset = "0x235C440", VA = "0x235C440")]
		private void SetFpsRelatedTextColor(Text text, float fps)
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x235C04C", Offset = "0x235C04C", VA = "0x235C04C")]
		private void Init()
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x235C8D4", Offset = "0x235C8D4", VA = "0x235C8D4")]
		public G_FpsText()
		{
		}
	}
}
namespace Tayx.Graphy.Audio
{
	[Token(Token = "0x2000024")]
	public class G_AudioGraph : G_Graph
	{
		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image m_imageGraph;

		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image m_imageGraphHighestValues;

		[Token(Token = "0x40000FA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Shader ShaderFull;

		[Token(Token = "0x40000FB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Shader ShaderLight;

		[Token(Token = "0x40000FC")]
		[FieldOffset(Offset = "0x38")]
		private GraphyManager m_graphyManager;

		[Token(Token = "0x40000FD")]
		[FieldOffset(Offset = "0x40")]
		private G_AudioMonitor m_audioMonitor;

		[Token(Token = "0x40000FE")]
		[FieldOffset(Offset = "0x48")]
		private int m_resolution;

		[Token(Token = "0x40000FF")]
		[FieldOffset(Offset = "0x50")]
		private G_GraphShader m_shaderGraph;

		[Token(Token = "0x4000100")]
		[FieldOffset(Offset = "0x58")]
		private G_GraphShader m_shaderGraphHighestValues;

		[Token(Token = "0x4000101")]
		[FieldOffset(Offset = "0x60")]
		private float[] m_graphArray;

		[Token(Token = "0x4000102")]
		[FieldOffset(Offset = "0x68")]
		private float[] m_graphArrayHighestValue;

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x235725C", Offset = "0x235725C", VA = "0x235725C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x2357398", Offset = "0x2357398", VA = "0x2357398")]
		private void Update()
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x235744C", Offset = "0x235744C", VA = "0x235744C")]
		public void UpdateParameters()
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x2357798", Offset = "0x2357798", VA = "0x2357798", Slot = "4")]
		protected override void UpdateGraph()
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x2357D58", Offset = "0x2357D58", VA = "0x2357D58", Slot = "5")]
		protected override void CreatePoints()
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x2357260", Offset = "0x2357260", VA = "0x2357260")]
		private void Init()
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x2358240", Offset = "0x2358240", VA = "0x2358240")]
		public G_AudioGraph()
		{
		}
	}
	[Token(Token = "0x2000025")]
	public class G_AudioManager : MonoBehaviour, IMovable, IModifiableState
	{
		[Token(Token = "0x4000103")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject m_audioGraphGameObject;

		[Token(Token = "0x4000104")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text m_audioDbText;

		[Token(Token = "0x4000105")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<Image> m_backgroundImages;

		[Token(Token = "0x4000106")]
		[FieldOffset(Offset = "0x30")]
		private GraphyManager m_graphyManager;

		[Token(Token = "0x4000107")]
		[FieldOffset(Offset = "0x38")]
		private G_AudioGraph m_audioGraph;

		[Token(Token = "0x4000108")]
		[FieldOffset(Offset = "0x40")]
		private G_AudioMonitor m_audioMonitor;

		[Token(Token = "0x4000109")]
		[FieldOffset(Offset = "0x48")]
		private G_AudioText m_audioText;

		[Token(Token = "0x400010A")]
		[FieldOffset(Offset = "0x50")]
		private RectTransform m_rectTransform;

		[Token(Token = "0x400010B")]
		[FieldOffset(Offset = "0x58")]
		private List<GameObject> m_childrenGameObjects;

		[Token(Token = "0x400010C")]
		[FieldOffset(Offset = "0x60")]
		private GraphyManager.ModuleState m_previousModuleState;

		[Token(Token = "0x400010D")]
		[FieldOffset(Offset = "0x64")]
		private GraphyManager.ModuleState m_currentModuleState;

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x2358258", Offset = "0x2358258", VA = "0x2358258")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x23586BC", Offset = "0x23586BC", VA = "0x23586BC")]
		private void Start()
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x2358850", Offset = "0x2358850", VA = "0x2358850", Slot = "4")]
		public void SetPosition(GraphyManager.ModulePosition newModulePosition)
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x2358A1C", Offset = "0x2358A1C", VA = "0x2358A1C", Slot = "5")]
		public void SetState(GraphyManager.ModuleState state, bool silentUpdate = false)
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x2358DB4", Offset = "0x2358DB4", VA = "0x2358DB4")]
		public void RestorePreviousState()
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x23586C0", Offset = "0x23586C0", VA = "0x23586C0")]
		public void UpdateParameters()
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x2358EEC", Offset = "0x2358EEC", VA = "0x2358EEC")]
		public void RefreshParameters()
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x235825C", Offset = "0x235825C", VA = "0x235825C")]
		private void Init()
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x2358CB0", Offset = "0x2358CB0", VA = "0x2358CB0")]
		private void SetGraphActive(bool active)
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x2359074", Offset = "0x2359074", VA = "0x2359074")]
		public G_AudioManager()
		{
		}
	}
	[Token(Token = "0x2000026")]
	public class G_AudioMonitor : MonoBehaviour
	{
		[Token(Token = "0x400010E")]
		private const float m_refValue = 1f;

		[Token(Token = "0x400010F")]
		[FieldOffset(Offset = "0x18")]
		private GraphyManager m_graphyManager;

		[Token(Token = "0x4000110")]
		[FieldOffset(Offset = "0x20")]
		private AudioListener m_audioListener;

		[Token(Token = "0x4000111")]
		[FieldOffset(Offset = "0x28")]
		private GraphyManager.LookForAudioListener m_findAudioListenerInCameraIfNull;

		[Token(Token = "0x4000112")]
		[FieldOffset(Offset = "0x2C")]
		private FFTWindow m_FFTWindow;

		[Token(Token = "0x4000113")]
		[FieldOffset(Offset = "0x30")]
		private int m_spectrumSize;

		[Token(Token = "0x4000114")]
		[FieldOffset(Offset = "0x38")]
		private float[] m_spectrum;

		[Token(Token = "0x4000115")]
		[FieldOffset(Offset = "0x40")]
		private float[] m_spectrumHighestValues;

		[Token(Token = "0x4000116")]
		[FieldOffset(Offset = "0x48")]
		private float m_maxDB;

		[Token(Token = "0x17000038")]
		public float[] Spectrum
		{
			[Token(Token = "0x60000E9")]
			[Address(RVA = "0x2359144", Offset = "0x2359144", VA = "0x2359144")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000039")]
		public float[] SpectrumHighestValues
		{
			[Token(Token = "0x60000EA")]
			[Address(RVA = "0x235914C", Offset = "0x235914C", VA = "0x235914C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003A")]
		public float MaxDB
		{
			[Token(Token = "0x60000EB")]
			[Address(RVA = "0x2359154", Offset = "0x2359154", VA = "0x2359154")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700003B")]
		public bool SpectrumDataAvailable
		{
			[Token(Token = "0x60000EC")]
			[Address(RVA = "0x23573E0", Offset = "0x23573E0", VA = "0x23573E0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x235915C", Offset = "0x235915C", VA = "0x235915C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x2359270", Offset = "0x2359270", VA = "0x2359270")]
		private void Update()
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x2358DC0", Offset = "0x2358DC0", VA = "0x2358DC0")]
		public void UpdateParameters()
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x2357CD0", Offset = "0x2357CD0", VA = "0x2357CD0")]
		public float lin2dB(float linear)
		{
			return default(float);
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x2357CFC", Offset = "0x2357CFC", VA = "0x2357CFC")]
		public float dBNormalized(float db)
		{
			return default(float);
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x235948C", Offset = "0x235948C", VA = "0x235948C")]
		private void FindAudioListener()
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x2359160", Offset = "0x2359160", VA = "0x2359160")]
		private void Init()
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x235954C", Offset = "0x235954C", VA = "0x235954C")]
		public G_AudioMonitor()
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x2359568", Offset = "0x2359568", VA = "0x2359568")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6BABC", Offset = "0xA6BABC")]
		private void <Init>b__23_0(Scene scene, LoadSceneMode loadMode)
		{
		}
	}
	[Token(Token = "0x2000027")]
	public class G_AudioText : MonoBehaviour
	{
		[Token(Token = "0x4000117")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text m_DBText;

		[Token(Token = "0x4000118")]
		[FieldOffset(Offset = "0x20")]
		private GraphyManager m_graphyManager;

		[Token(Token = "0x4000119")]
		[FieldOffset(Offset = "0x28")]
		private G_AudioMonitor m_audioMonitor;

		[Token(Token = "0x400011A")]
		[FieldOffset(Offset = "0x30")]
		private int m_updateRate;

		[Token(Token = "0x400011B")]
		[FieldOffset(Offset = "0x34")]
		private float m_deltaTimeOffset;

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x235957C", Offset = "0x235957C", VA = "0x235957C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x23596FC", Offset = "0x23596FC", VA = "0x23596FC")]
		private void Update()
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x2358ECC", Offset = "0x2358ECC", VA = "0x2358ECC")]
		public void UpdateParameters()
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x2359580", Offset = "0x2359580", VA = "0x2359580")]
		private void Init()
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x23597F8", Offset = "0x23597F8", VA = "0x23597F8")]
		public G_AudioText()
		{
		}
	}
}
namespace Tayx.Graphy.Advanced
{
	[Token(Token = "0x2000028")]
	public class G_AdvancedData : MonoBehaviour, IMovable, IModifiableState
	{
		[Token(Token = "0x400011C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<Image> m_backgroundImages;

		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text m_graphicsDeviceVersionText;

		[Token(Token = "0x400011E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text m_processorTypeText;

		[Token(Token = "0x400011F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text m_operatingSystemText;

		[Token(Token = "0x4000120")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text m_systemMemoryText;

		[Token(Token = "0x4000121")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text m_graphicsDeviceNameText;

		[Token(Token = "0x4000122")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text m_graphicsMemorySizeText;

		[Token(Token = "0x4000123")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text m_screenResolutionText;

		[Token(Token = "0x4000124")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text m_gameWindowResolutionText;

		[Token(Token = "0x4000125")]
		[FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA6B5E0", Offset = "0xA6B5E0")]
		[SerializeField]
		private float m_updateRate;

		[Token(Token = "0x4000126")]
		[FieldOffset(Offset = "0x68")]
		private GraphyManager m_graphyManager;

		[Token(Token = "0x4000127")]
		[FieldOffset(Offset = "0x70")]
		private RectTransform m_rectTransform;

		[Token(Token = "0x4000128")]
		[FieldOffset(Offset = "0x78")]
		private float m_deltaTime;

		[Token(Token = "0x4000129")]
		[FieldOffset(Offset = "0x80")]
		private StringBuilder m_sb;

		[Token(Token = "0x400012A")]
		[FieldOffset(Offset = "0x88")]
		private GraphyManager.ModuleState m_previousModuleState;

		[Token(Token = "0x400012B")]
		[FieldOffset(Offset = "0x8C")]
		private GraphyManager.ModuleState m_currentModuleState;

		[Token(Token = "0x400012C")]
		[FieldOffset(Offset = "0x90")]
		private readonly string[] m_windowStrings;

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x2354D8C", Offset = "0x2354D8C", VA = "0x2354D8C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x2355BF8", Offset = "0x2355BF8", VA = "0x2355BF8")]
		private void Update()
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x2356160", Offset = "0x2356160", VA = "0x2356160", Slot = "4")]
		public void SetPosition(GraphyManager.ModulePosition newModulePosition)
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x235664C", Offset = "0x235664C", VA = "0x235664C", Slot = "5")]
		public void SetState(GraphyManager.ModuleState state, bool silentUpdate = false)
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x2356810", Offset = "0x2356810", VA = "0x2356810")]
		public void RestorePreviousState()
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x235681C", Offset = "0x235681C", VA = "0x235681C")]
		public void UpdateParameters()
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x2356980", Offset = "0x2356980", VA = "0x2356980")]
		public void RefreshParameters()
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x2354D90", Offset = "0x2354D90", VA = "0x2354D90")]
		private void Init()
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x2356F94", Offset = "0x2356F94", VA = "0x2356F94")]
		public G_AdvancedData()
		{
		}
	}
}
namespace Tayx.Graphy.CustomizationScene
{
	[Token(Token = "0x2000029")]
	public class G_CUIColorPicker : MonoBehaviour
	{
		[Token(Token = "0x200002A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6AC74", Offset = "0xA6AC74")]
		private sealed class <>c__DisplayClass13_0
		{
			[Token(Token = "0x4000132")]
			[FieldOffset(Offset = "0x10")]
			public Texture2D satvalTex;

			[Token(Token = "0x4000133")]
			[FieldOffset(Offset = "0x18")]
			public Color[] satvalColors;

			[Token(Token = "0x4000134")]
			[FieldOffset(Offset = "0x20")]
			public float Hue;

			[Token(Token = "0x4000135")]
			[FieldOffset(Offset = "0x28")]
			public Color[] hueColors;

			[Token(Token = "0x4000136")]
			[FieldOffset(Offset = "0x30")]
			public Action resetSatValTexture;

			[Token(Token = "0x4000137")]
			[FieldOffset(Offset = "0x38")]
			public float Saturation;

			[Token(Token = "0x4000138")]
			[FieldOffset(Offset = "0x3C")]
			public float Value;

			[Token(Token = "0x4000139")]
			[FieldOffset(Offset = "0x40")]
			public GameObject result;

			[Token(Token = "0x400013A")]
			[FieldOffset(Offset = "0x48")]
			public G_CUIColorPicker <>4__this;

			[Token(Token = "0x400013B")]
			[FieldOffset(Offset = "0x50")]
			public GameObject hueGO;

			[Token(Token = "0x400013C")]
			[FieldOffset(Offset = "0x58")]
			public Action dragH;

			[Token(Token = "0x400013D")]
			[FieldOffset(Offset = "0x60")]
			public GameObject satvalGO;

			[Token(Token = "0x400013E")]
			[FieldOffset(Offset = "0x68")]
			public Action dragSV;

			[Token(Token = "0x400013F")]
			[FieldOffset(Offset = "0x70")]
			public Vector2 hueSz;

			[Token(Token = "0x4000140")]
			[FieldOffset(Offset = "0x78")]
			public Action applyHue;

			[Token(Token = "0x4000141")]
			[FieldOffset(Offset = "0x80")]
			public Action applySaturationValue;

			[Token(Token = "0x4000142")]
			[FieldOffset(Offset = "0x88")]
			public GameObject hueKnob;

			[Token(Token = "0x4000143")]
			[FieldOffset(Offset = "0x90")]
			public Action idle;

			[Token(Token = "0x4000144")]
			[FieldOffset(Offset = "0x98")]
			public Vector2 satvalSz;

			[Token(Token = "0x4000145")]
			[FieldOffset(Offset = "0xA0")]
			public GameObject satvalKnob;

			[Token(Token = "0x6000112")]
			[Address(RVA = "0x235A438", Offset = "0x235A438", VA = "0x235A438")]
			public <>c__DisplayClass13_0()
			{
			}

			[Token(Token = "0x6000113")]
			[Address(RVA = "0x236101C", Offset = "0x236101C", VA = "0x236101C")]
			internal void <Setup>b__0()
			{
			}

			[Token(Token = "0x6000114")]
			[Address(RVA = "0x23610BC", Offset = "0x23610BC", VA = "0x23610BC")]
			internal void <Setup>b__1()
			{
			}

			[Token(Token = "0x6000115")]
			[Address(RVA = "0x23611C4", Offset = "0x23611C4", VA = "0x23611C4")]
			internal void <Setup>b__2()
			{
			}

			[Token(Token = "0x6000116")]
			[Address(RVA = "0x236149C", Offset = "0x236149C", VA = "0x236149C")]
			internal void <Setup>b__3()
			{
			}

			[Token(Token = "0x6000117")]
			[Address(RVA = "0x2361514", Offset = "0x2361514", VA = "0x2361514")]
			internal void <Setup>b__4()
			{
			}

			[Token(Token = "0x6000118")]
			[Address(RVA = "0x23615F4", Offset = "0x23615F4", VA = "0x23615F4")]
			internal void <Setup>b__5()
			{
			}
		}

		[Token(Token = "0x400012D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Slider alphaSlider;

		[Token(Token = "0x400012E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image alphaSliderBGImage;

		[Token(Token = "0x400012F")]
		[FieldOffset(Offset = "0x28")]
		private Color _color;

		[Token(Token = "0x4000130")]
		[FieldOffset(Offset = "0x38")]
		private Action<Color> _onValueChange;

		[Token(Token = "0x4000131")]
		[FieldOffset(Offset = "0x40")]
		private Action _update;

		[Token(Token = "0x1700003C")]
		public Color Color
		{
			[Token(Token = "0x6000104")]
			[Address(RVA = "0x2359808", Offset = "0x2359808", VA = "0x2359808")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000105")]
			[Address(RVA = "0x235352C", Offset = "0x235352C", VA = "0x235352C")]
			set
			{
			}
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x235A02C", Offset = "0x235A02C", VA = "0x235A02C")]
		public void SetOnValueChangeCallback(Action<Color> onValueChange)
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x235A034", Offset = "0x235A034", VA = "0x235A034")]
		private static void RGBToHSV(Color color, out float h, out float s, out float v)
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x235A1B0", Offset = "0x235A1B0", VA = "0x235A1B0")]
		private static bool GetLocalMouse(GameObject go, out Vector2 result)
		{
			return default(bool);
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x235A360", Offset = "0x235A360", VA = "0x235A360")]
		private static Vector2 GetWidgetSize(GameObject go)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x235A3F8", Offset = "0x235A3F8", VA = "0x235A3F8")]
		private GameObject GO(string name)
		{
			return null;
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x2359814", Offset = "0x2359814", VA = "0x2359814")]
		private void Setup(Color inputColor)
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x235A440", Offset = "0x235A440", VA = "0x235A440")]
		public void SetRandomColor()
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x235A580", Offset = "0x235A580", VA = "0x235A580")]
		private void Awake()
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x235A5D0", Offset = "0x235A5D0", VA = "0x235A5D0")]
		private void Start()
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x235A694", Offset = "0x235A694", VA = "0x235A694")]
		private void Update()
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x235A6A8", Offset = "0x235A6A8", VA = "0x235A6A8")]
		public G_CUIColorPicker()
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x235A704", Offset = "0x235A704", VA = "0x235A704")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6BACC", Offset = "0xA6BACC")]
		private void <Start>b__16_0(float value)
		{
		}
	}
	[Token(Token = "0x200002B")]
	public class CustomizeGraphy : MonoBehaviour
	{
		[Token(Token = "0x4000146")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA6B644", Offset = "0xA6B644")]
		[SerializeField]
		private G_CUIColorPicker m_colorPicker;

		[Token(Token = "0x4000147")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Toggle m_backgroundToggle;

		[Token(Token = "0x4000148")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Dropdown m_graphyModeDropdown;

		[Token(Token = "0x4000149")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Button m_backgroundColorButton;

		[Token(Token = "0x400014A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Dropdown m_graphModulePositionDropdown;

		[Token(Token = "0x400014B")]
		[FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA6B6D0", Offset = "0xA6B6D0")]
		[SerializeField]
		private Dropdown m_fpsModuleStateDropdown;

		[Token(Token = "0x400014C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private InputField m_goodInputField;

		[Token(Token = "0x400014D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private InputField m_cautionInputField;

		[Token(Token = "0x400014E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Button m_goodColorButton;

		[Token(Token = "0x400014F")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Button m_cautionColorButton;

		[Token(Token = "0x4000150")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Button m_criticalColorButton;

		[Token(Token = "0x4000151")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Slider m_timeToResetMinMaxSlider;

		[Token(Token = "0x4000152")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Slider m_fpsGraphResolutionSlider;

		[Token(Token = "0x4000153")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Slider m_fpsTextUpdateRateSlider;

		[Token(Token = "0x4000154")]
		[FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA6B79C", Offset = "0xA6B79C")]
		[SerializeField]
		private Dropdown m_ramModuleStateDropdown;

		[Token(Token = "0x4000155")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Button m_reservedColorButton;

		[Token(Token = "0x4000156")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Button m_allocatedColorButton;

		[Token(Token = "0x4000157")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Button m_monoColorButton;

		[Token(Token = "0x4000158")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Slider m_ramGraphResolutionSlider;

		[Token(Token = "0x4000159")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Slider m_ramTextUpdateRateSlider;

		[Token(Token = "0x400015A")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA6B838", Offset = "0xA6B838")]
		private Dropdown m_audioModuleStateDropdown;

		[Token(Token = "0x400015B")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Button m_audioGraphColorButton;

		[Token(Token = "0x400015C")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Dropdown m_findAudioListenerDropdown;

		[Token(Token = "0x400015D")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private Dropdown m_fttWindowDropdown;

		[Token(Token = "0x400015E")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private Slider m_spectrumSizeSlider;

		[Token(Token = "0x400015F")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private Slider m_audioGraphResolutionSlider;

		[Token(Token = "0x4000160")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private Slider m_audioTextUpdateRateSlider;

		[Token(Token = "0x4000161")]
		[FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA6B8E4", Offset = "0xA6B8E4")]
		[SerializeField]
		private Dropdown m_advancedModulePositionDropdown;

		[Token(Token = "0x4000162")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private Toggle m_advancedModuleToggle;

		[Token(Token = "0x4000163")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA6B940", Offset = "0xA6B940")]
		private Button m_musicButton;

		[Token(Token = "0x4000164")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private Button m_sfxButton;

		[Token(Token = "0x4000165")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private Slider m_musicVolumeSlider;

		[Token(Token = "0x4000166")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private Slider m_sfxVolumeSlider;

		[Token(Token = "0x4000167")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private AudioSource m_musicAudioSource;

		[Token(Token = "0x4000168")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private AudioSource m_sfxAudioSource;

		[Token(Token = "0x4000169")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private List<AudioClip> m_sfxAudioClips;

		[Token(Token = "0x400016A")]
		[FieldOffset(Offset = "0x138")]
		private GraphyManager m_graphyManager;

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x2352360", Offset = "0x2352360", VA = "0x2352360")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x23523EC", Offset = "0x23523EC", VA = "0x23523EC")]
		private void SetupCallbacks()
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x2353258", Offset = "0x2353258", VA = "0x2353258")]
		private void ToggleMusic()
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x23532B0", Offset = "0x23532B0", VA = "0x23532B0")]
		private void PlayRandomSFX()
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x2353378", Offset = "0x2353378", VA = "0x2353378")]
		public CustomizeGraphy()
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x23533FC", Offset = "0x23533FC", VA = "0x23533FC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6BADC", Offset = "0xA6BADC")]
		private void <SetupCallbacks>b__38_0(bool value)
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x2353428", Offset = "0x2353428", VA = "0x2353428")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6BAEC", Offset = "0xA6BAEC")]
		private void <SetupCallbacks>b__38_1()
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x2353530", Offset = "0x2353530", VA = "0x2353530")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6BAFC", Offset = "0xA6BAFC")]
		private void <SetupCallbacks>b__38_30(Color color)
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x23535E8", Offset = "0x23535E8", VA = "0x23535E8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6BB0C", Offset = "0xA6BB0C")]
		private void <SetupCallbacks>b__38_2(int value)
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x235368C", Offset = "0x235368C", VA = "0x235368C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6BB1C", Offset = "0xA6BB1C")]
		private void <SetupCallbacks>b__38_3(int value)
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x23536F0", Offset = "0x23536F0", VA = "0x23536F0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6BB2C", Offset = "0xA6BB2C")]
		private void <SetupCallbacks>b__38_4(int value)
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x235372C", Offset = "0x235372C", VA = "0x235372C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6BB3C", Offset = "0xA6BB3C")]
		private void <SetupCallbacks>b__38_5(string value)
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x23537A4", Offset = "0x23537A4", VA = "0x23537A4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6BB4C", Offset = "0xA6BB4C")]
		private void <SetupCallbacks>b__38_6(string value)
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x235381C", Offset = "0x235381C", VA = "0x235381C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6BB5C", Offset = "0xA6BB5C")]
		private void <SetupCallbacks>b__38_7()
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x2353920", Offset = "0x2353920", VA = "0x2353920")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6BB6C", Offset = "0xA6BB6C")]
		private void <SetupCallbacks>b__38_31(Color color)
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x23539F8", Offset = "0x23539F8", VA = "0x23539F8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6BB7C", Offset = "0xA6BB7C")]
		private void <SetupCallbacks>b__38_8()
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x2353AFC", Offset = "0x2353AFC", VA = "0x2353AFC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6BB8C", Offset = "0xA6BB8C")]
		private void <SetupCallbacks>b__38_32(Color color)
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x2353BD4", Offset = "0x2353BD4", VA = "0x2353BD4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6BB9C", Offset = "0xA6BB9C")]
		private void <SetupCallbacks>b__38_9()
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x2353CD8", Offset = "0x2353CD8", VA = "0x2353CD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6BBAC", Offset = "0xA6BBAC")]
		private void <SetupCallbacks>b__38_33(Color color)
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x2353DB0", Offset = "0x2353DB0", VA = "0x2353DB0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6BBBC", Offset = "0xA6BBBC")]
		private void <SetupCallbacks>b__38_10(float value)
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x2353E14", Offset = "0x2353E14", VA = "0x2353E14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6BBCC", Offset = "0xA6BBCC")]
		private void <SetupCallbacks>b__38_11(float value)
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x2353E78", Offset = "0x2353E78", VA = "0x2353E78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6BBDC", Offset = "0xA6BBDC")]
		private void <SetupCallbacks>b__38_12(float value)
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x2353EDC", Offset = "0x2353EDC", VA = "0x2353EDC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6BBEC", Offset = "0xA6BBEC")]
		private void <SetupCallbacks>b__38_13(int value)
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x2353F18", Offset = "0x2353F18", VA = "0x2353F18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6BBFC", Offset = "0xA6BBFC")]
		private void <SetupCallbacks>b__38_14()
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x235401C", Offset = "0x235401C", VA = "0x235401C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6BC0C", Offset = "0xA6BC0C")]
		private void <SetupCallbacks>b__38_34(Color color)
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x23540F4", Offset = "0x23540F4", VA = "0x23540F4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6BC1C", Offset = "0xA6BC1C")]
		private void <SetupCallbacks>b__38_15()
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x23541F8", Offset = "0x23541F8", VA = "0x23541F8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6BC2C", Offset = "0xA6BC2C")]
		private void <SetupCallbacks>b__38_35(Color color)
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x23542D0", Offset = "0x23542D0", VA = "0x23542D0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6BC3C", Offset = "0xA6BC3C")]
		private void <SetupCallbacks>b__38_16()
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x23543D4", Offset = "0x23543D4", VA = "0x23543D4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6BC4C", Offset = "0xA6BC4C")]
		private void <SetupCallbacks>b__38_36(Color color)
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x23544AC", Offset = "0x23544AC", VA = "0x23544AC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6BC5C", Offset = "0xA6BC5C")]
		private void <SetupCallbacks>b__38_17(float value)
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x2354510", Offset = "0x2354510", VA = "0x2354510")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6BC6C", Offset = "0xA6BC6C")]
		private void <SetupCallbacks>b__38_18(float value)
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x2354574", Offset = "0x2354574", VA = "0x2354574")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6BC7C", Offset = "0xA6BC7C")]
		private void <SetupCallbacks>b__38_19(int value)
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x23545B0", Offset = "0x23545B0", VA = "0x23545B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6BC8C", Offset = "0xA6BC8C")]
		private void <SetupCallbacks>b__38_20()
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x23546B4", Offset = "0x23546B4", VA = "0x23546B4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6BC9C", Offset = "0xA6BC9C")]
		private void <SetupCallbacks>b__38_37(Color color)
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x235478C", Offset = "0x235478C", VA = "0x235478C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6BCAC", Offset = "0xA6BCAC")]
		private void <SetupCallbacks>b__38_21(int value)
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x23547D4", Offset = "0x23547D4", VA = "0x23547D4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6BCBC", Offset = "0xA6BCBC")]
		private void <SetupCallbacks>b__38_22(int value)
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x235481C", Offset = "0x235481C", VA = "0x235481C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6BCCC", Offset = "0xA6BCCC")]
		private void <SetupCallbacks>b__38_23(float value)
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x2354880", Offset = "0x2354880", VA = "0x2354880")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6BCDC", Offset = "0xA6BCDC")]
		private void <SetupCallbacks>b__38_24(float value)
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x23548E4", Offset = "0x23548E4", VA = "0x23548E4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6BCEC", Offset = "0xA6BCEC")]
		private void <SetupCallbacks>b__38_25(float value)
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x2354948", Offset = "0x2354948", VA = "0x2354948")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6BCFC", Offset = "0xA6BCFC")]
		private void <SetupCallbacks>b__38_26(int value)
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x2354980", Offset = "0x2354980", VA = "0x2354980")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6BD0C", Offset = "0xA6BD0C")]
		private void <SetupCallbacks>b__38_27(bool value)
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x23549C8", Offset = "0x23549C8", VA = "0x23549C8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6BD1C", Offset = "0xA6BD1C")]
		private void <SetupCallbacks>b__38_28(float value)
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x23549F0", Offset = "0x23549F0", VA = "0x23549F0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6BD2C", Offset = "0xA6BD2C")]
		private void <SetupCallbacks>b__38_29(float value)
		{
		}
	}
	[Token(Token = "0x200002C")]
	public class ForceSliderToMultipleOf3 : MonoBehaviour
	{
		[Token(Token = "0x400016B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Slider m_slider;

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x2354A18", Offset = "0x2354A18", VA = "0x2354A18")]
		private void Start()
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x2354ADC", Offset = "0x2354ADC", VA = "0x2354ADC")]
		private void UpdateValue(float value)
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x2354B5C", Offset = "0x2354B5C", VA = "0x2354B5C")]
		public ForceSliderToMultipleOf3()
		{
		}
	}
	[Token(Token = "0x200002D")]
	public class ForceSliderToPowerOf2 : MonoBehaviour
	{
		[Token(Token = "0x400016C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Slider m_slider;

		[Token(Token = "0x400016D")]
		[FieldOffset(Offset = "0x20")]
		private int[] m_powerOf2Values;

		[Token(Token = "0x400016E")]
		[FieldOffset(Offset = "0x28")]
		private Text m_text;

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x2354B64", Offset = "0x2354B64", VA = "0x2354B64")]
		private void Start()
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x2354C28", Offset = "0x2354C28", VA = "0x2354C28")]
		private void UpdateValue(float value)
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x2354D00", Offset = "0x2354D00", VA = "0x2354D00")]
		public ForceSliderToPowerOf2()
		{
		}
	}
	[Token(Token = "0x200002E")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xA6AC84", Offset = "0xA6AC84")]
	public class UpdateTextWithSliderValue : MonoBehaviour
	{
		[Token(Token = "0x400016F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Slider m_slider;

		[Token(Token = "0x4000170")]
		[FieldOffset(Offset = "0x20")]
		private Text m_text;

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x2360ED4", Offset = "0x2360ED4", VA = "0x2360ED4")]
		private void Start()
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x2360FC8", Offset = "0x2360FC8", VA = "0x2360FC8")]
		private void UpdateText(float value)
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x2361014", Offset = "0x2361014", VA = "0x2361014")]
		public UpdateTextWithSliderValue()
		{
		}
	}
}
