using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;
using UnityEngine.Playables;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class BluetoothDeviceScript : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<string> DiscoveredDeviceList;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Action InitializedAction;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Action DeinitializedAction;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Action<string> ErrorAction;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Action<string> ServiceAddedAction;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Action StartedAdvertisingAction;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Action StoppedAdvertisingAction;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Action<string, string> DiscoveredPeripheralAction;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Action<string, string, int, byte[]> DiscoveredPeripheralWithAdvertisingInfoAction;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Action<BluetoothLEHardwareInterface.iBeaconData> DiscoveredBeaconAction;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Action<string, string> RetrievedConnectedPeripheralAction;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Action<string, byte[]> PeripheralReceivedWriteDataAction;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Action<string> ConnectedPeripheralAction;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Action<string> ConnectedDisconnectPeripheralAction;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Action<string> DisconnectedPeripheralAction;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Action<string, string> DiscoveredServiceAction;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Action<string, string, string> DiscoveredCharacteristicAction;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Action<string> DidWriteCharacteristicAction;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Dictionary<string, Dictionary<string, Action<string>>> DidUpdateNotificationStateForCharacteristicAction;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Dictionary<string, Dictionary<string, Action<string, string>>> DidUpdateNotificationStateForCharacteristicWithDeviceAddressAction;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Dictionary<string, Dictionary<string, Action<string, byte[]>>> DidUpdateCharacteristicValueAction;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Dictionary<string, Dictionary<string, Action<string, string, byte[]>>> DidUpdateCharacteristicValueWithDeviceAddressAction;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public Action<string, int> RequestMtuAction;

	[Token(Token = "0x4000018")]
	private const string deviceInitializedString = "Initialized";

	[Token(Token = "0x4000019")]
	private const string deviceDeInitializedString = "DeInitialized";

	[Token(Token = "0x400001A")]
	private const string deviceErrorString = "Error";

	[Token(Token = "0x400001B")]
	private const string deviceServiceAdded = "ServiceAdded";

	[Token(Token = "0x400001C")]
	private const string deviceStartedAdvertising = "StartedAdvertising";

	[Token(Token = "0x400001D")]
	private const string deviceStoppedAdvertising = "StoppedAdvertising";

	[Token(Token = "0x400001E")]
	private const string deviceDiscoveredPeripheral = "DiscoveredPeripheral";

	[Token(Token = "0x400001F")]
	private const string deviceDiscoveredBeacon = "DiscoveredBeacon";

	[Token(Token = "0x4000020")]
	private const string deviceRetrievedConnectedPeripheral = "RetrievedConnectedPeripheral";

	[Token(Token = "0x4000021")]
	private const string devicePeripheralReceivedWriteData = "PeripheralReceivedWriteData";

	[Token(Token = "0x4000022")]
	private const string deviceConnectedPeripheral = "ConnectedPeripheral";

	[Token(Token = "0x4000023")]
	private const string deviceDisconnectedPeripheral = "DisconnectedPeripheral";

	[Token(Token = "0x4000024")]
	private const string deviceDiscoveredService = "DiscoveredService";

	[Token(Token = "0x4000025")]
	private const string deviceDiscoveredCharacteristic = "DiscoveredCharacteristic";

	[Token(Token = "0x4000026")]
	private const string deviceDidWriteCharacteristic = "DidWriteCharacteristic";

	[Token(Token = "0x4000027")]
	private const string deviceDidUpdateNotificationStateForCharacteristic = "DidUpdateNotificationStateForCharacteristic";

	[Token(Token = "0x4000028")]
	private const string deviceDidUpdateValueForCharacteristic = "DidUpdateValueForCharacteristic";

	[Token(Token = "0x4000029")]
	private const string deviceLog = "Log";

	[Token(Token = "0x400002A")]
	private const string deviceRequestMtu = "MtuChanged";

	[Token(Token = "0x6000001")]
	[Address(RVA = "0xA5D730", Offset = "0xA5D730", VA = "0xA5D730")]
	private void Start()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xA5D8EC", Offset = "0xA5D8EC", VA = "0xA5D8EC")]
	public void OnBluetoothMessage(string message)
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xA5EF88", Offset = "0xA5EF88", VA = "0xA5EF88")]
	public void OnBluetoothData(string base64Data)
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xA5EC04", Offset = "0xA5EC04", VA = "0xA5EC04")]
	public void OnBluetoothData(string deviceAddress, string characteristic, string base64Data)
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0xA5EA70", Offset = "0xA5EA70", VA = "0xA5EA70")]
	public void OnPeripheralData(string characteristic, string base64Data)
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xA5EFE4", Offset = "0xA5EFE4", VA = "0xA5EFE4")]
	public BluetoothDeviceScript()
	{
	}
}
[Token(Token = "0x2000003")]
public class BluetoothLEHardwareInterface
{
	[Token(Token = "0x2000004")]
	public enum iOSProximity
	{
		[Token(Token = "0x400002E")]
		Unknown,
		[Token(Token = "0x400002F")]
		Immediate,
		[Token(Token = "0x4000030")]
		Near,
		[Token(Token = "0x4000031")]
		Far
	}

	[Token(Token = "0x2000005")]
	public struct iBeaconData
	{
		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string UUID;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int Major;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int Minor;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int RSSI;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int AndroidSignalPower;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public iOSProximity iOSProximity;
	}

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static AndroidJavaObject _android;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static BluetoothDeviceScript bluetoothDeviceScript;

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xA5E7C4", Offset = "0xA5E7C4", VA = "0xA5E7C4")]
	public static void Log(string message)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0xA5EFEC", Offset = "0xA5EFEC", VA = "0xA5EFEC")]
	public static BluetoothDeviceScript Initialize(bool asCentral, bool asPeripheral, Action action, Action<string> errorAction)
	{
		return null;
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xA5F4E4", Offset = "0xA5F4E4", VA = "0xA5F4E4")]
	public static void DeInitialize(Action action)
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xA5E9C4", Offset = "0xA5E9C4", VA = "0xA5E9C4")]
	public static void FinishDeInitialize()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xA5F6AC", Offset = "0xA5F6AC", VA = "0xA5F6AC")]
	public static void BluetoothEnable(bool enable)
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xA5F7D0", Offset = "0xA5F7D0", VA = "0xA5F7D0")]
	public static void ScanForPeripheralsWithServices(string[] serviceUUIDs, Action<string, string> action, [Optional] Action<string, string, int, byte[]> actionAdvertisingInfo, bool rssiOnly = false, bool clearPeripheralList = true, int recordType = 255)
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xA5FB08", Offset = "0xA5FB08", VA = "0xA5FB08")]
	public static void StopScan()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xA5FBE0", Offset = "0xA5FBE0", VA = "0xA5FBE0")]
	public static void DisconnectAll()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xA5FCB8", Offset = "0xA5FCB8", VA = "0xA5FCB8")]
	public static void ConnectToPeripheral(string name, Action<string> connectAction, Action<string, string> serviceAction, Action<string, string, string> characteristicAction, [Optional] Action<string> disconnectAction)
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0xA5FE8C", Offset = "0xA5FE8C", VA = "0xA5FE8C")]
	public static void SubscribeCharacteristicWithDeviceAddress(string name, string service, string characteristic, Action<string, string> notificationAction, Action<string, string, byte[]> action)
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xA604D0", Offset = "0xA604D0", VA = "0xA604D0")]
	public static void UnSubscribeCharacteristic(string name, string service, string characteristic, Action<string> action)
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xA60448", Offset = "0xA60448", VA = "0xA60448")]
	public static string FullUUID(string uuid)
	{
		return null;
	}
}
namespace RootMotion
{
	[Token(Token = "0x2000006")]
	public abstract class Baker : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000007")]
		public enum Mode
		{
			[Token(Token = "0x4000047")]
			AnimationClips,
			[Token(Token = "0x4000048")]
			AnimationStates,
			[Token(Token = "0x4000049")]
			PlayableDirector,
			[Token(Token = "0x400004A")]
			Realtime
		}

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int frameRate;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float keyReductionError;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Mode mode;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationClip[] animationClips;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string[] animationStates;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool loop;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string saveToFolder;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string appendName;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string saveName;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		public Animator animator;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		public PlayableDirector director;

		[Token(Token = "0x17000001")]
		public bool isBaking
		{
			[Token(Token = "0x6000017")]
			[Address(RVA = "0xA60A54", Offset = "0xA60A54", VA = "0xA60A54")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000018")]
			[Address(RVA = "0xA60A5C", Offset = "0xA60A5C", VA = "0xA60A5C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public float bakingProgress
		{
			[Token(Token = "0x6000019")]
			[Address(RVA = "0xA60A68", Offset = "0xA60A68", VA = "0xA60A68")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600001A")]
			[Address(RVA = "0xA60A70", Offset = "0xA60A70", VA = "0xA60A70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000003")]
		protected float clipLength
		{
			[Token(Token = "0x6000020")]
			[Address(RVA = "0xA60A78", Offset = "0xA60A78", VA = "0xA60A78")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000021")]
			[Address(RVA = "0xA60A80", Offset = "0xA60A80", VA = "0xA60A80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0xA60944", Offset = "0xA60944", VA = "0xA60944")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0xA60988", Offset = "0xA60988", VA = "0xA60988")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0xA609CC", Offset = "0xA609CC", VA = "0xA609CC")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0xA60A10", Offset = "0xA60A10", VA = "0xA60A10")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600001B")]
		protected abstract Transform GetCharacterRoot();

		[Token(Token = "0x600001C")]
		protected abstract void OnStartBaking();

		[Token(Token = "0x600001D")]
		protected abstract void OnSetLoopFrame(float time);

		[Token(Token = "0x600001E")]
		protected abstract void OnSetCurves(ref AnimationClip clip);

		[Token(Token = "0x600001F")]
		protected abstract void OnSetKeyframes(float time, bool lastFrame);

		[Token(Token = "0x6000022")]
		[Address(RVA = "0xA60A88", Offset = "0xA60A88", VA = "0xA60A88")]
		protected Baker()
		{
		}
	}
	[Token(Token = "0x2000008")]
	public class GenericBaker : Baker
	{
		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public bool markAsLegacy;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform root;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform rootNode;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] ignoreList;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform[] bakePositionList;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private BakerTransform[] children;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private BakerTransform rootChild;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int rootChildIndex;

		[Token(Token = "0x6000023")]
		[Address(RVA = "0xA60BB0", Offset = "0xA60BB0", VA = "0xA60BB0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0xA60FF4", Offset = "0xA60FF4", VA = "0xA60FF4", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0xA60FFC", Offset = "0xA60FFC", VA = "0xA60FFC", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0xA61238", Offset = "0xA61238", VA = "0xA61238", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0xA6149C", Offset = "0xA6149C", VA = "0xA6149C", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0xA617B4", Offset = "0xA617B4", VA = "0xA617B4", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0xA60DDC", Offset = "0xA60DDC", VA = "0xA60DDC")]
		private bool IsIgnored(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0xA60E94", Offset = "0xA60E94", VA = "0xA60E94")]
		private bool BakePosition(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0xA61A14", Offset = "0xA61A14", VA = "0xA61A14")]
		public GenericBaker()
		{
		}
	}
	[Token(Token = "0x2000009")]
	public class TQ
	{
		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 t;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion q;

		[Token(Token = "0x600002C")]
		[Address(RVA = "0xA61A7C", Offset = "0xA61A7C", VA = "0xA61A7C")]
		public TQ(Vector3 translation, Quaternion rotation)
		{
		}
	}
	[Token(Token = "0x200000A")]
	public class AvatarUtility
	{
		[Token(Token = "0x600002D")]
		[Address(RVA = "0xA61AE0", Offset = "0xA61AE0", VA = "0xA61AE0")]
		public static TQ GetIKGoalTQ(Avatar avatar, float humanScale, AvatarIKGoal avatarIKGoal, TQ bodyPositionRotation, TQ boneTQ)
		{
			return null;
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0xA62150", Offset = "0xA62150", VA = "0xA62150")]
		public static HumanBodyBones HumanIDFromAvatarIKGoal(AvatarIKGoal avatarIKGoal)
		{
			return default(HumanBodyBones);
		}
	}
	[Token(Token = "0x200000B")]
	public static class BakerUtilities
	{
		[Token(Token = "0x600002F")]
		[Address(RVA = "0xA62170", Offset = "0xA62170", VA = "0xA62170")]
		public static void ReduceKeyframes(AnimationCurve curve, float maxError)
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0xA621A8", Offset = "0xA621A8", VA = "0xA621A8")]
		public static Keyframe[] GetReducedKeyframes(AnimationCurve curve, float maxError)
		{
			return null;
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0xA6256C", Offset = "0xA6256C", VA = "0xA6256C")]
		public static void SetLoopFrame(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0xA6274C", Offset = "0xA6274C", VA = "0xA6274C")]
		public static void SetTangentMode(AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0xA62750", Offset = "0xA62750", VA = "0xA62750")]
		public static Quaternion EnsureQuaternionContinuity(Quaternion lastQ, Quaternion q)
		{
			return default(Quaternion);
		}
	}
	[Serializable]
	[Token(Token = "0x200000C")]
	public class BakerHumanoidQT
	{
		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Transform transform;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string Qx;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string Qy;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string Qz;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string Qw;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string Tx;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string Ty;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string Tz;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve rotX;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AnimationCurve rotY;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AnimationCurve rotZ;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public AnimationCurve rotW;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AnimationCurve posX;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public AnimationCurve posY;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public AnimationCurve posZ;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private AvatarIKGoal goal;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Quaternion lastQ;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private bool lastQSet;

		[Token(Token = "0x6000034")]
		[Address(RVA = "0xA628E4", Offset = "0xA628E4", VA = "0xA628E4")]
		public BakerHumanoidQT(string name)
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0xA62C48", Offset = "0xA62C48", VA = "0xA62C48")]
		public BakerHumanoidQT(Transform transform, AvatarIKGoal goal, string name)
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0xA62AB0", Offset = "0xA62AB0", VA = "0xA62AB0")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0xA62E30", Offset = "0xA62E30", VA = "0xA62E30")]
		public void SetIKKeyframes(float time, Avatar avatar, float humanScale, Vector3 bodyPosition, Quaternion bodyRotation)
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0xA63064", Offset = "0xA63064", VA = "0xA63064")]
		public void SetKeyframes(float time, Vector3 pos, Quaternion rot)
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0xA63154", Offset = "0xA63154", VA = "0xA63154")]
		public void MoveLastKeyframes(float time)
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0xA63238", Offset = "0xA63238", VA = "0xA63238")]
		public void SetLoopFrame(float time)
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0xA631BC", Offset = "0xA631BC", VA = "0xA631BC")]
		private void MoveLastKeyframe(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0xA632A0", Offset = "0xA632A0", VA = "0xA632A0")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0xA63348", Offset = "0xA63348", VA = "0xA63348")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000D")]
	public class BakerMuscle
	{
		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AnimationCurve curve;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int muscleIndex;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string propertyName;

		[Token(Token = "0x600003E")]
		[Address(RVA = "0xA63634", Offset = "0xA63634", VA = "0xA63634")]
		public BakerMuscle(int muscleIndex)
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0xA636A4", Offset = "0xA636A4", VA = "0xA636A4")]
		private string MuscleNameToPropertyName(string n)
		{
			return null;
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0xA64140", Offset = "0xA64140", VA = "0xA64140")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0xA641E8", Offset = "0xA641E8", VA = "0xA641E8")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0xA640D8", Offset = "0xA640D8", VA = "0xA640D8")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0xA642DC", Offset = "0xA642DC", VA = "0xA642DC")]
		public void SetKeyframe(float time, float[] muscles)
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0xA64318", Offset = "0xA64318", VA = "0xA64318")]
		public void SetLoopFrame(float time)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000E")]
	public class BakerTransform
	{
		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AnimationCurve posX;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AnimationCurve posY;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationCurve posZ;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve rotX;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve rotY;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve rotZ;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AnimationCurve rotW;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string relativePath;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool recordPosition;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 relativePosition;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool isRootNode;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Quaternion relativeRotation;

		[Token(Token = "0x6000045")]
		[Address(RVA = "0xA60F4C", Offset = "0xA60F4C", VA = "0xA60F4C")]
		public BakerTransform(Transform transform, Transform root, bool recordPosition, bool isRootNode)
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0xA61224", Offset = "0xA61224", VA = "0xA61224")]
		public void SetRelativeSpace(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0xA61500", Offset = "0xA61500", VA = "0xA61500")]
		public void SetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0xA64320", Offset = "0xA64320", VA = "0xA64320")]
		private void AddRootMotionCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0xA610CC", Offset = "0xA610CC", VA = "0xA610CC")]
		public void Reset()
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0xA61820", Offset = "0xA61820", VA = "0xA61820")]
		public void SetKeyframes(float time)
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0xA612A4", Offset = "0xA612A4", VA = "0xA612A4")]
		public void AddLoopFrame(float time)
		{
		}
	}
	[Token(Token = "0x200000F")]
	public class HumanoidBaker : Baker
	{
		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public bool bakeHandIK;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float IKKeyReductionError;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public int muscleFrameRateDiv;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private BakerMuscle[] bakerMuscles;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private BakerHumanoidQT rootQT;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private BakerHumanoidQT leftFootQT;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private BakerHumanoidQT rightFootQT;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private BakerHumanoidQT leftHandQT;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private BakerHumanoidQT rightHandQT;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float[] muscles;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private HumanPose pose;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private HumanPoseHandler handler;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Vector3 bodyPosition;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Quaternion bodyRotation;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private int mN;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Quaternion lastBodyRotation;

		[Token(Token = "0x600004C")]
		[Address(RVA = "0xA645A8", Offset = "0xA645A8", VA = "0xA645A8")]
		private void Awake()
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0xA64B08", Offset = "0xA64B08", VA = "0xA64B08", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0xA64B24", Offset = "0xA64B24", VA = "0xA64B24", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0xA64C00", Offset = "0xA64C00", VA = "0xA64C00", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0xA64CBC", Offset = "0xA64CBC", VA = "0xA64CBC", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0xA64E5C", Offset = "0xA64E5C", VA = "0xA64E5C", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0xA65100", Offset = "0xA65100", VA = "0xA65100")]
		private void UpdateHumanPose()
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0xA651D8", Offset = "0xA651D8", VA = "0xA651D8")]
		public HumanoidBaker()
		{
		}
	}
	[Token(Token = "0x2000010")]
	public class CameraController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000011")]
		public enum UpdateMode
		{
			[Token(Token = "0x40000AD")]
			Update,
			[Token(Token = "0x40000AE")]
			FixedUpdate,
			[Token(Token = "0x40000AF")]
			LateUpdate,
			[Token(Token = "0x40000B0")]
			FixedLateUpdate
		}

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rotationSpace;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateMode updateMode;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool lockCursor;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		public bool smoothFollow;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 offset;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float followSpeed;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float rotationSensitivity;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float yMinLimit;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float yMaxLimit;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool rotateAlways;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		public bool rotateOnLeftButton;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E")]
		public bool rotateOnRightButton;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F")]
		public bool rotateOnMiddleButton;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float distance;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float minDistance;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float maxDistance;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float zoomSpeed;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float zoomSensitivity;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public LayerMask blockingLayers;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float blockingRadius;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float blockingSmoothTime;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float blockedOffset;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 targetDistance;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Vector3 position;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion rotation;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 smoothPosition;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Camera cam;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool fixedFrame;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float fixedDeltaTime;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Quaternion r;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Vector3 lastUp;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private float blockedDistance;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float blockedDistanceV;

		[Token(Token = "0x17000004")]
		public float x
		{
			[Token(Token = "0x6000054")]
			[Address(RVA = "0xA65288", Offset = "0xA65288", VA = "0xA65288")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000055")]
			[Address(RVA = "0xA65290", Offset = "0xA65290", VA = "0xA65290")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public float y
		{
			[Token(Token = "0x6000056")]
			[Address(RVA = "0xA65298", Offset = "0xA65298", VA = "0xA65298")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000057")]
			[Address(RVA = "0xA652A0", Offset = "0xA652A0", VA = "0xA652A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public float distanceTarget
		{
			[Token(Token = "0x6000058")]
			[Address(RVA = "0xA652A8", Offset = "0xA652A8", VA = "0xA652A8")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000059")]
			[Address(RVA = "0xA652B0", Offset = "0xA652B0", VA = "0xA652B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000007")]
		private float zoomAdd
		{
			[Token(Token = "0x6000063")]
			[Address(RVA = "0xA65CD0", Offset = "0xA65CD0", VA = "0xA65CD0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0xA652B8", Offset = "0xA652B8", VA = "0xA652B8")]
		public void SetAngles(Quaternion rotation)
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0xA652F0", Offset = "0xA652F0", VA = "0xA652F0")]
		public void SetAngles(float yaw, float pitch)
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0xA652F8", Offset = "0xA652F8", VA = "0xA652F8", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0xA65430", Offset = "0xA65430", VA = "0xA65430", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0xA65478", Offset = "0xA65478", VA = "0xA65478", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0xA654D0", Offset = "0xA654D0", VA = "0xA654D0", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0xA65528", Offset = "0xA65528", VA = "0xA65528")]
		public void UpdateInput()
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0xA6545C", Offset = "0xA6545C", VA = "0xA6545C")]
		public void UpdateTransform()
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0xA656B4", Offset = "0xA656B4", VA = "0xA656B4")]
		public void UpdateTransform(float deltaTime)
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0xA65C94", Offset = "0xA65C94", VA = "0xA65C94")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0xA65D3C", Offset = "0xA65D3C", VA = "0xA65D3C")]
		public CameraController()
		{
		}
	}
	[Token(Token = "0x2000012")]
	public class CameraControllerFPS : MonoBehaviour
	{
		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotationSensitivity;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float yMinLimit;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float yMaxLimit;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float x;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float y;

		[Token(Token = "0x6000066")]
		[Address(RVA = "0xA65DFC", Offset = "0xA65DFC", VA = "0xA65DFC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0xA65E28", Offset = "0xA65E28", VA = "0xA65E28")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0xA6604C", Offset = "0xA6604C", VA = "0xA6604C")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0xA66088", Offset = "0xA66088", VA = "0xA66088")]
		public CameraControllerFPS()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000013")]
	public enum Axis
	{
		[Token(Token = "0x40000B7")]
		X,
		[Token(Token = "0x40000B8")]
		Y,
		[Token(Token = "0x40000B9")]
		Z
	}
	[Token(Token = "0x2000014")]
	public class AxisTools
	{
		[Token(Token = "0x600006A")]
		[Address(RVA = "0xA660A4", Offset = "0xA660A4", VA = "0xA660A4")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0xA66184", Offset = "0xA66184", VA = "0xA66184")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0xA66280", Offset = "0xA66280", VA = "0xA66280")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0xA662C4", Offset = "0xA662C4", VA = "0xA662C4")]
		public static Vector3 GetAxisVectorToDirection(Quaternion r, Vector3 direction)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000015")]
	public static class BipedNaming
	{
		[Serializable]
		[Token(Token = "0x2000016")]
		public enum BoneType
		{
			[Token(Token = "0x40000CD")]
			Unassigned,
			[Token(Token = "0x40000CE")]
			Spine,
			[Token(Token = "0x40000CF")]
			Head,
			[Token(Token = "0x40000D0")]
			Arm,
			[Token(Token = "0x40000D1")]
			Leg,
			[Token(Token = "0x40000D2")]
			Tail,
			[Token(Token = "0x40000D3")]
			Eye
		}

		[Serializable]
		[Token(Token = "0x2000017")]
		public enum BoneSide
		{
			[Token(Token = "0x40000D5")]
			Center,
			[Token(Token = "0x40000D6")]
			Left,
			[Token(Token = "0x40000D7")]
			Right
		}

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeLeft;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string[] typeRight;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string[] typeSpine;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string[] typeHead;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string[] typeArm;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static string[] typeLeg;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static string[] typeTail;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static string[] typeEye;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static string[] typeExclude;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static string[] typeExcludeSpine;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static string[] typeExcludeHead;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static string[] typeExcludeArm;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static string[] typeExcludeLeg;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static string[] typeExcludeTail;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static string[] typeExcludeEye;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static string[] pelvis;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static string[] hand;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static string[] foot;

		[Token(Token = "0x600006E")]
		[Address(RVA = "0xA66750", Offset = "0xA66750", VA = "0xA66750")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0xA66A1C", Offset = "0xA66A1C", VA = "0xA66A1C")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0xA66C58", Offset = "0xA66C58", VA = "0xA66C58")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0xA66CCC", Offset = "0xA66CCC", VA = "0xA66CCC")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0xA66904", Offset = "0xA66904", VA = "0xA66904")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0xA66BD0", Offset = "0xA66BD0", VA = "0xA66BD0")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0xA67404", Offset = "0xA67404", VA = "0xA67404")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0xA6725C", Offset = "0xA6725C", VA = "0xA6725C")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0xA67330", Offset = "0xA67330", VA = "0xA67330")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0xA66EB4", Offset = "0xA66EB4", VA = "0xA66EB4")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0xA66F50", Offset = "0xA66F50", VA = "0xA66F50")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0xA66FEC", Offset = "0xA66FEC", VA = "0xA66FEC")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0xA67088", Offset = "0xA67088", VA = "0xA67088")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0xA67124", Offset = "0xA67124", VA = "0xA67124")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0xA671C0", Offset = "0xA671C0", VA = "0xA671C0")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0xA66DE0", Offset = "0xA66DE0", VA = "0xA66DE0")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0xA67568", Offset = "0xA67568", VA = "0xA67568")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0xA674F4", Offset = "0xA674F4", VA = "0xA674F4")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0xA67484", Offset = "0xA67484", VA = "0xA67484")]
		private static string lastLetter(string boneName)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000018")]
	public class BipedReferences
	{
		[Token(Token = "0x2000019")]
		public struct AutoDetectParams
		{
			[Token(Token = "0x40000E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool legsParentInSpine;

			[Token(Token = "0x40000EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool includeEyes;

			[Token(Token = "0x6000097")]
			[Address(RVA = "0xA6D930", Offset = "0xA6D930", VA = "0xA6D930")]
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes)
			{
			}
		}

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform root;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform pelvis;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform leftThigh;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftCalf;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftFoot;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform rightThigh;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform rightCalf;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform rightFoot;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform leftUpperArm;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftForearm;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform leftHand;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform rightUpperArm;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform rightForearm;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform rightHand;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform head;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] spine;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform[] eyes;

		[Token(Token = "0x17000008")]
		public virtual bool isFilled
		{
			[Token(Token = "0x6000082")]
			[Address(RVA = "0xA6A3A8", Offset = "0xA6A3A8", VA = "0xA6A3A8", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0xA6A704", Offset = "0xA6A704", VA = "0xA6A704")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0xA6AE28", Offset = "0xA6AE28", VA = "0xA6AE28")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0xA6A998", Offset = "0xA6A998", VA = "0xA6A998")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0xA6B6A8", Offset = "0xA6B6A8", VA = "0xA6B6A8")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0xA6B794", Offset = "0xA6B794", VA = "0xA6B794")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0xA6C2B0", Offset = "0xA6C2B0", VA = "0xA6C2B0")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0xA6C0BC", Offset = "0xA6C0BC", VA = "0xA6C0BC")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0xA6BE5C", Offset = "0xA6BE5C", VA = "0xA6BE5C")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0xA6B830", Offset = "0xA6B830", VA = "0xA6B830")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0xA6C1B0", Offset = "0xA6C1B0", VA = "0xA6C1B0")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0xA6C390", Offset = "0xA6C390", VA = "0xA6C390")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0xA6CF38", Offset = "0xA6CF38", VA = "0xA6CF38")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0xA6C9E0", Offset = "0xA6C9E0", VA = "0xA6C9E0")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0xA6D284", Offset = "0xA6D284", VA = "0xA6D284")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0xA6CD40", Offset = "0xA6CD40", VA = "0xA6CD40")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0xA6D28C", Offset = "0xA6D28C", VA = "0xA6D28C")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0xA6D294", Offset = "0xA6D294", VA = "0xA6D294")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0xA6D454", Offset = "0xA6D454", VA = "0xA6D454")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0xA6D8C8", Offset = "0xA6D8C8", VA = "0xA6D8C8")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0xA6A918", Offset = "0xA6A918", VA = "0xA6A918")]
		public BipedReferences()
		{
		}
	}
	[Token(Token = "0x200001A")]
	public class Comments : MonoBehaviour
	{
		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string text;

		[Token(Token = "0x6000098")]
		[Address(RVA = "0xA6D944", Offset = "0xA6D944", VA = "0xA6D944")]
		public Comments()
		{
		}
	}
	[Token(Token = "0x200001B")]
	public class DemoGUIMessage : MonoBehaviour
	{
		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string text;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color color;

		[Token(Token = "0x6000099")]
		[Address(RVA = "0xA6D94C", Offset = "0xA6D94C", VA = "0xA6D94C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0xA6DA44", Offset = "0xA6DA44", VA = "0xA6DA44")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x200001C")]
	public class Hierarchy
	{
		[Token(Token = "0x600009B")]
		[Address(RVA = "0xA6D844", Offset = "0xA6D844", VA = "0xA6D844")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0xA6D738", Offset = "0xA6D738", VA = "0xA6D738")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0xA6B994", Offset = "0xA6B994", VA = "0xA6B994")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0xA6BFAC", Offset = "0xA6BFAC", VA = "0xA6BFAC")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0xA6BC14", Offset = "0xA6BC14", VA = "0xA6BC14")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0xA6BAC4", Offset = "0xA6BAC4", VA = "0xA6BAC4")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x200001D")]
	public enum InterpolationMode
	{
		[Token(Token = "0x40000EF")]
		None,
		[Token(Token = "0x40000F0")]
		InOutCubic,
		[Token(Token = "0x40000F1")]
		InOutQuintic,
		[Token(Token = "0x40000F2")]
		InOutSine,
		[Token(Token = "0x40000F3")]
		InQuintic,
		[Token(Token = "0x40000F4")]
		InQuartic,
		[Token(Token = "0x40000F5")]
		InCubic,
		[Token(Token = "0x40000F6")]
		InQuadratic,
		[Token(Token = "0x40000F7")]
		InElastic,
		[Token(Token = "0x40000F8")]
		InElasticSmall,
		[Token(Token = "0x40000F9")]
		InElasticBig,
		[Token(Token = "0x40000FA")]
		InSine,
		[Token(Token = "0x40000FB")]
		InBack,
		[Token(Token = "0x40000FC")]
		OutQuintic,
		[Token(Token = "0x40000FD")]
		OutQuartic,
		[Token(Token = "0x40000FE")]
		OutCubic,
		[Token(Token = "0x40000FF")]
		OutInCubic,
		[Token(Token = "0x4000100")]
		OutInQuartic,
		[Token(Token = "0x4000101")]
		OutElastic,
		[Token(Token = "0x4000102")]
		OutElasticSmall,
		[Token(Token = "0x4000103")]
		OutElasticBig,
		[Token(Token = "0x4000104")]
		OutSine,
		[Token(Token = "0x4000105")]
		OutBack,
		[Token(Token = "0x4000106")]
		OutBackCubic,
		[Token(Token = "0x4000107")]
		OutBackQuartic,
		[Token(Token = "0x4000108")]
		BackInCubic,
		[Token(Token = "0x4000109")]
		BackInQuartic
	}
	[Token(Token = "0x200001E")]
	public class Interp
	{
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0xA6DA54", Offset = "0xA6DA54", VA = "0xA6DA54")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0xA6E3DC", Offset = "0xA6E3DC", VA = "0xA6E3DC")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0xA6DE54", Offset = "0xA6DE54", VA = "0xA6DE54")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0xA6DE60", Offset = "0xA6DE60", VA = "0xA6DE60")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0xA6DE84", Offset = "0xA6DE84", VA = "0xA6DE84")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0xA6DEC0", Offset = "0xA6DEC0", VA = "0xA6DEC0")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0xA6DED8", Offset = "0xA6DED8", VA = "0xA6DED8")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0xA6DEEC", Offset = "0xA6DEEC", VA = "0xA6DEEC")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0xA6DF00", Offset = "0xA6DF00", VA = "0xA6DF00")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0xA6DF10", Offset = "0xA6DF10", VA = "0xA6DF10")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0xA6DF58", Offset = "0xA6DF58", VA = "0xA6DF58")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0xA6DF90", Offset = "0xA6DF90", VA = "0xA6DF90")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0xA6DFB8", Offset = "0xA6DFB8", VA = "0xA6DFB8")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0xA6DFEC", Offset = "0xA6DFEC", VA = "0xA6DFEC")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0xA6E014", Offset = "0xA6E014", VA = "0xA6E014")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0xA6E044", Offset = "0xA6E044", VA = "0xA6E044")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0xA6E078", Offset = "0xA6E078", VA = "0xA6E078")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0xA6E0BC", Offset = "0xA6E0BC", VA = "0xA6E0BC")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0xA6E120", Offset = "0xA6E120", VA = "0xA6E120")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0xA6E184", Offset = "0xA6E184", VA = "0xA6E184")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0xA6E1D8", Offset = "0xA6E1D8", VA = "0xA6E1D8")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0xA6E22C", Offset = "0xA6E22C", VA = "0xA6E22C")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0xA6E264", Offset = "0xA6E264", VA = "0xA6E264")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0xA6E298", Offset = "0xA6E298", VA = "0xA6E298")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0xA6E2DC", Offset = "0xA6E2DC", VA = "0xA6E2DC")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0xA6E36C", Offset = "0xA6E36C", VA = "0xA6E36C")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0xA6E39C", Offset = "0xA6E39C", VA = "0xA6E39C")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}
	}
	[Token(Token = "0x200001F")]
	public static class QuaTools
	{
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0xA6E44C", Offset = "0xA6E44C", VA = "0xA6E44C")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0xA6E498", Offset = "0xA6E498", VA = "0xA6E498")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0xA6E5AC", Offset = "0xA6E5AC", VA = "0xA6E5AC")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0xA6E654", Offset = "0xA6E654", VA = "0xA6E654")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0xA6E760", Offset = "0xA6E760", VA = "0xA6E760")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0xA6E8C8", Offset = "0xA6E8C8", VA = "0xA6E8C8")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0xA6EAAC", Offset = "0xA6EAAC", VA = "0xA6EAAC")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis)
		{
			return default(Quaternion);
		}
	}
	[Token(Token = "0x2000020")]
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T sInstance;

		[Token(Token = "0x17000009")]
		public static T instance
		{
			[Token(Token = "0x60000C3")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000C4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60000C5")]
		protected Singleton()
		{
		}
	}
	[Token(Token = "0x2000021")]
	public class SolverManager : MonoBehaviour
	{
		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool fixTransforms;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animation legacy;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool updateFrame;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool componentInitiated;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		private bool skipSolverUpdate;

		[Token(Token = "0x1700000A")]
		private bool animatePhysics
		{
			[Token(Token = "0x60000CC")]
			[Address(RVA = "0xA6ED4C", Offset = "0xA6ED4C", VA = "0xA6ED4C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000B")]
		private bool isAnimated
		{
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0xA6F048", Offset = "0xA6F048", VA = "0xA6F048")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0xA6EC30", Offset = "0xA6EC30", VA = "0xA6EC30")]
		public void Disable()
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0xA6ECC4", Offset = "0xA6ECC4", VA = "0xA6ECC4", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0xA6ECC8", Offset = "0xA6ECC8", VA = "0xA6ECC8", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0xA6ECCC", Offset = "0xA6ECCC", VA = "0xA6ECCC", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0xA6ECD0", Offset = "0xA6ECD0", VA = "0xA6ECD0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0xA6ED48", Offset = "0xA6ED48", VA = "0xA6ED48")]
		private void Start()
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0xA6ECF8", Offset = "0xA6ECF8", VA = "0xA6ECF8")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0xA6F00C", Offset = "0xA6F00C", VA = "0xA6F00C")]
		private void Update()
		{
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0xA6EE18", Offset = "0xA6EE18", VA = "0xA6EE18")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0xA6F0E0", Offset = "0xA6F0E0", VA = "0xA6F0E0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0xA6F12C", Offset = "0xA6F12C", VA = "0xA6F12C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0xA6F178", Offset = "0xA6F178", VA = "0xA6F178")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0xA6F1B0", Offset = "0xA6F1B0", VA = "0xA6F1B0")]
		public SolverManager()
		{
		}
	}
	[Token(Token = "0x2000022")]
	public class TriggerEventBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject target;

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0xA6F1C0", Offset = "0xA6F1C0", VA = "0xA6F1C0")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0xA6F274", Offset = "0xA6F274", VA = "0xA6F274")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0xA6F328", Offset = "0xA6F328", VA = "0xA6F328")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0xA6F3DC", Offset = "0xA6F3DC", VA = "0xA6F3DC")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x2000023")]
	public static class V3Tools
	{
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0xA6F3E4", Offset = "0xA6F3E4", VA = "0xA6F3E4")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0xA6F440", Offset = "0xA6F440", VA = "0xA6F440")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0xA6F590", Offset = "0xA6F590", VA = "0xA6F590")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0xA6F70C", Offset = "0xA6F70C", VA = "0xA6F70C")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0xA6F95C", Offset = "0xA6F95C", VA = "0xA6F95C")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0xA6FB08", Offset = "0xA6FB08", VA = "0xA6FB08")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000024")]
	public static class Warning
	{
		[Token(Token = "0x2000025")]
		public delegate void Logger(string message);

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool logged;

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0xA6B5F4", Offset = "0xA6B5F4", VA = "0xA6B5F4")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x2000026")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0xA6FDF8", Offset = "0xA6FDF8", VA = "0xA6FDF8")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0xA6FE3C", Offset = "0xA6FE3C", VA = "0xA6FE3C")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0xA6FE80", Offset = "0xA6FE80", VA = "0xA6FE80")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0xA6FEC4", Offset = "0xA6FEC4", VA = "0xA6FEC4")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0xA6FF08", Offset = "0xA6FF08", VA = "0xA6FF08")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0xA6FFA0", Offset = "0xA6FFA0", VA = "0xA6FFA0")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0xA6FFBC", Offset = "0xA6FFBC", VA = "0xA6FFBC")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0xA6FFE8", Offset = "0xA6FFE8", VA = "0xA6FFE8")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0xA70014", Offset = "0xA70014", VA = "0xA70014")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0xA70050", Offset = "0xA70050", VA = "0xA70050")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0xA70090", Offset = "0xA70090", VA = "0xA70090")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0xA700B0", Offset = "0xA700B0", VA = "0xA700B0")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0xA700D0", Offset = "0xA700D0", VA = "0xA700D0")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0xA700F4", Offset = "0xA700F4", VA = "0xA700F4")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0xA7011C", Offset = "0xA7011C", VA = "0xA7011C")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0xA70144", Offset = "0xA70144", VA = "0xA70144")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0xA6FF24", Offset = "0xA6FF24", VA = "0xA6FF24")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0xA70168", Offset = "0xA70168", VA = "0xA70168")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0xA70174", Offset = "0xA70174", VA = "0xA70174")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0xA70180", Offset = "0xA70180", VA = "0xA70180")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0xA70434", Offset = "0xA70434", VA = "0xA70434", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0xA704D0", Offset = "0xA704D0", VA = "0xA704D0", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0xA707F4", Offset = "0xA707F4", VA = "0xA707F4", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0xA70C60", Offset = "0xA70C60", VA = "0xA70C60")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0xA70C84", Offset = "0xA70C84", VA = "0xA70C84")]
		public BipedIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000027")]
	public class BipedIKSolvers
	{
		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IKSolverLimb leftFoot;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IKSolverLimb rightFoot;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IKSolverLimb leftHand;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IKSolverLimb rightHand;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolverFABRIK spine;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt lookAt;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverAim aim;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Constraints pelvis;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb[] _limbs;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private IKSolver[] _ikSolvers;

		[Token(Token = "0x1700000C")]
		public IKSolverLimb[] limbs
		{
			[Token(Token = "0x60000FB")]
			[Address(RVA = "0xA702BC", Offset = "0xA702BC", VA = "0xA702BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0xA70680", Offset = "0xA70680", VA = "0xA70680")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0xA70D34", Offset = "0xA70D34", VA = "0xA70D34")]
		public BipedIKSolvers()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000028")]
	public class Constraints
	{
		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 positionOffset;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 position;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float positionWeight;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 rotationOffset;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float rotationWeight;

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0xA70F28", Offset = "0xA70F28", VA = "0xA70F28")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0xA707A0", Offset = "0xA707A0", VA = "0xA707A0")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0xA70968", Offset = "0xA70968", VA = "0xA70968")]
		public void Update()
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0xA70F20", Offset = "0xA70F20", VA = "0xA70F20")]
		public Constraints()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000029")]
	public class Finger
	{
		[Serializable]
		[Token(Token = "0x200002A")]
		public enum DOF
		{
			[Token(Token = "0x4000139")]
			One,
			[Token(Token = "0x400013A")]
			Three
		}

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float weight;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float rotationWeight;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public DOF rotationDOF;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool fixBone1Twist;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone1;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bone2;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform bone3;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform tip;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform target;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb solver;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion bone3RelativeToTarget;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 bone3DefaultLocalPosition;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Quaternion bone3DefaultLocalRotation;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 bone1Axis;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 tipAxis;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 bone1TwistAxis;

		[Token(Token = "0x1700000D")]
		public bool initiated
		{
			[Token(Token = "0x6000102")]
			[Address(RVA = "0xA70F88", Offset = "0xA70F88", VA = "0xA70F88")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000103")]
			[Address(RVA = "0xA70F90", Offset = "0xA70F90", VA = "0xA70F90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x6000104")]
			[Address(RVA = "0xA70F9C", Offset = "0xA70F9C", VA = "0xA70F9C")]
			set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x6000105")]
			[Address(RVA = "0xA70FBC", Offset = "0xA70FBC", VA = "0xA70FBC")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000106")]
			[Address(RVA = "0xA70FDC", Offset = "0xA70FDC", VA = "0xA70FDC")]
			set
			{
			}
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0xA70FFC", Offset = "0xA70FFC", VA = "0xA70FFC")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0xA710F4", Offset = "0xA710F4", VA = "0xA710F4")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0xA715F0", Offset = "0xA715F0", VA = "0xA715F0")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0xA716BC", Offset = "0xA716BC", VA = "0xA716BC")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0xA71774", Offset = "0xA71774", VA = "0xA71774")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0xA71DDC", Offset = "0xA71DDC", VA = "0xA71DDC")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x200002B")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float weight;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Finger[] fingers;

		[Token(Token = "0x17000010")]
		public bool initiated
		{
			[Token(Token = "0x600010D")]
			[Address(RVA = "0xA71DEC", Offset = "0xA71DEC", VA = "0xA71DEC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600010E")]
			[Address(RVA = "0xA71DF4", Offset = "0xA71DF4", VA = "0xA71DF4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0xA71E00", Offset = "0xA71E00", VA = "0xA71E00")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0xA71E74", Offset = "0xA71E74", VA = "0xA71E74")]
		[ContextMenu("Auto-detect")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0xA721EC", Offset = "0xA721EC", VA = "0xA721EC")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0xA723A4", Offset = "0xA723A4", VA = "0xA723A4")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0xA720FC", Offset = "0xA720FC", VA = "0xA720FC")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0xA72520", Offset = "0xA72520", VA = "0xA72520", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0xA725C8", Offset = "0xA725C8", VA = "0xA725C8")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0xA7262C", Offset = "0xA7262C", VA = "0xA7262C")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0xA72694", Offset = "0xA72694", VA = "0xA72694")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0xA726F0", Offset = "0xA726F0", VA = "0xA726F0", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0xA726F4", Offset = "0xA726F4", VA = "0xA726F4", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0xA72708", Offset = "0xA72708", VA = "0xA72708")]
		public FingerRig()
		{
		}
	}
	[Token(Token = "0x200002C")]
	public abstract class Grounder : MonoBehaviour
	{
		[Token(Token = "0x200002D")]
		public delegate void GrounderDelegate();

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float weight;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Grounding solver;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GrounderDelegate OnPreGrounder;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GrounderDelegate OnPostGrounder;

		[Token(Token = "0x17000011")]
		public bool initiated
		{
			[Token(Token = "0x600011C")]
			[Address(RVA = "0xA7277C", Offset = "0xA7277C", VA = "0xA7277C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600011D")]
			[Address(RVA = "0xA72784", Offset = "0xA72784", VA = "0xA72784")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x600011B")]
		public abstract void ResetPosition();

		[Token(Token = "0x600011E")]
		[Address(RVA = "0xA72790", Offset = "0xA72790", VA = "0xA72790")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0xA72A40", Offset = "0xA72A40", VA = "0xA72A40")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0xA72854", Offset = "0xA72854", VA = "0xA72854")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0xA72A64", Offset = "0xA72A64", VA = "0xA72A64")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000122")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000123")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000124")]
		[Address(RVA = "0xA72BD8", Offset = "0xA72BD8", VA = "0xA72BD8")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x200002E")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BipedIK ik;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float spineBend;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float spineSpeed;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform[] feet;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion[] footRotations;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 spineOffset;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float lastWeight;

		[Token(Token = "0x6000127")]
		[Address(RVA = "0xA72D34", Offset = "0xA72D34", VA = "0xA72D34", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0xA72D78", Offset = "0xA72D78", VA = "0xA72D78", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0xA72DBC", Offset = "0xA72DBC", VA = "0xA72DBC", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0xA72E28", Offset = "0xA72E28", VA = "0xA72E28")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0xA72EC8", Offset = "0xA72EC8", VA = "0xA72EC8")]
		private void Update()
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0xA72F1C", Offset = "0xA72F1C", VA = "0xA72F1C")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0xA7327C", Offset = "0xA7327C", VA = "0xA7327C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0xA732BC", Offset = "0xA732BC", VA = "0xA732BC")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0xA7371C", Offset = "0xA7371C", VA = "0xA7371C")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0xA737DC", Offset = "0xA737DC", VA = "0xA737DC")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0xA739AC", Offset = "0xA739AC", VA = "0xA739AC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0xA73B84", Offset = "0xA73B84", VA = "0xA73B84")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x200002F")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x2000030")]
		public class SpineEffector
		{
			[Token(Token = "0x4000153")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000154")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float horizontalWeight;

			[Token(Token = "0x4000155")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float verticalWeight;

			[Token(Token = "0x6000141")]
			[Address(RVA = "0xA75E0C", Offset = "0xA75E0C", VA = "0xA75E0C")]
			public SpineEffector()
			{
			}
		}

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float spineBend;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float spineSpeed;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public SpineEffector[] spine;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] feet;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 spineOffset;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool firstSolve;

		[Token(Token = "0x6000133")]
		[Address(RVA = "0xA74C28", Offset = "0xA74C28", VA = "0xA74C28")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0xA74C6C", Offset = "0xA74C6C", VA = "0xA74C6C", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0xA74CB0", Offset = "0xA74CB0", VA = "0xA74CB0", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0xA74CF4", Offset = "0xA74CF4", VA = "0xA74CF4", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0xA74DD4", Offset = "0xA74DD4", VA = "0xA74DD4")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0xA74E5C", Offset = "0xA74E5C", VA = "0xA74E5C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0xA75108", Offset = "0xA75108", VA = "0xA75108")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0xA75114", Offset = "0xA75114", VA = "0xA75114")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0xA74EB8", Offset = "0xA74EB8", VA = "0xA74EB8")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0xA753E4", Offset = "0xA753E4", VA = "0xA753E4")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0xA7594C", Offset = "0xA7594C", VA = "0xA7594C")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0xA75AD0", Offset = "0xA75AD0", VA = "0xA75AD0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0xA75C30", Offset = "0xA75C30", VA = "0xA75C30")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0xA75D64", Offset = "0xA75D64", VA = "0xA75D64")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x2000031")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IK[] legs;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform pelvis;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform characterRoot;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float rootRotationWeight;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float rootRotationSpeed;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float maxRootRotationAngle;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform[] feet;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] footRotations;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int solvedFeet;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool solved;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float lastWeight;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x6000142")]
		[Address(RVA = "0xA75E1C", Offset = "0xA75E1C", VA = "0xA75E1C", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0xA75E60", Offset = "0xA75E60", VA = "0xA75E60", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0xA75EA4", Offset = "0xA75EA4", VA = "0xA75EA4", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0xA75EBC", Offset = "0xA75EBC", VA = "0xA75EBC")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0xA760C8", Offset = "0xA760C8", VA = "0xA760C8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0xA761A8", Offset = "0xA761A8", VA = "0xA761A8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0xA7688C", Offset = "0xA7688C", VA = "0xA7688C")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0xA76D44", Offset = "0xA76D44", VA = "0xA76D44")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0xA76EF0", Offset = "0xA76EF0", VA = "0xA76EF0")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0xA77278", Offset = "0xA77278", VA = "0xA77278")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0xA77450", Offset = "0xA77450", VA = "0xA77450")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0xA77678", Offset = "0xA77678", VA = "0xA77678")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x2000032")]
	public class GrounderQuadruped : Grounder
	{
		[Token(Token = "0x2000033")]
		public struct Foot
		{
			[Token(Token = "0x4000181")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IKSolver solver;

			[Token(Token = "0x4000182")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform transform;

			[Token(Token = "0x4000183")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Quaternion rotation;

			[Token(Token = "0x4000184")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Grounding.Leg leg;

			[Token(Token = "0x6000160")]
			[Address(RVA = "0xA7825C", Offset = "0xA7825C", VA = "0xA7825C")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Grounding forelegSolver;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float rootRotationWeight;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float minRootRotation;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float maxRootRotation;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float rootRotationSpeed;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float maxLegOffset;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float maxForeLegOffset;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform characterRoot;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform pelvis;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform lastSpineBone;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform head;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IK[] legs;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IK[] forelegs;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Vector3 gravity;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Foot[] feet;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Quaternion animatedPelvisLocalRotation;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private Quaternion animatedHeadLocalRotation;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Quaternion solvedPelvisLocalRotation;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion solvedHeadLocalRotation;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private int solvedFeet;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private bool solved;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private float angle;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Transform forefeetRoot;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Quaternion headRotation;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private float lastWeight;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x600014E")]
		[Address(RVA = "0xA77720", Offset = "0xA77720", VA = "0xA77720", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0xA77764", Offset = "0xA77764", VA = "0xA77764", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0xA777A8", Offset = "0xA777A8", VA = "0xA777A8", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0xA777D0", Offset = "0xA777D0", VA = "0xA777D0")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0xA778D4", Offset = "0xA778D4", VA = "0xA778D4")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0xA77AB8", Offset = "0xA77AB8", VA = "0xA77AB8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0xA77B1C", Offset = "0xA77B1C", VA = "0xA77B1C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0xA77B74", Offset = "0xA77B74", VA = "0xA77B74")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0xA77EC0", Offset = "0xA77EC0", VA = "0xA77EC0")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0xA782BC", Offset = "0xA782BC", VA = "0xA782BC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0xA7834C", Offset = "0xA7834C", VA = "0xA7834C")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0xA7879C", Offset = "0xA7879C", VA = "0xA7879C")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0xA78E5C", Offset = "0xA78E5C", VA = "0xA78E5C")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0xA79114", Offset = "0xA79114", VA = "0xA79114")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0xA79248", Offset = "0xA79248", VA = "0xA79248")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0xA79510", Offset = "0xA79510", VA = "0xA79510")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0xA79540", Offset = "0xA79540", VA = "0xA79540")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0xA79760", Offset = "0xA79760", VA = "0xA79760")]
		public GrounderQuadruped()
		{
		}
	}
	[Token(Token = "0x2000034")]
	public class GrounderVRIK : Grounder
	{
		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public VRIK ik;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform[] feet;

		[Token(Token = "0x6000161")]
		[Address(RVA = "0xA7990C", Offset = "0xA7990C", VA = "0xA7990C")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0xA79950", Offset = "0xA79950", VA = "0xA79950", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0xA79994", Offset = "0xA79994", VA = "0xA79994", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0xA799D8", Offset = "0xA799D8", VA = "0xA799D8", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0xA799F0", Offset = "0xA799F0", VA = "0xA799F0")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0xA79A78", Offset = "0xA79A78", VA = "0xA79A78")]
		private void Update()
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0xA79ACC", Offset = "0xA79ACC", VA = "0xA79ACC")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0xA79D50", Offset = "0xA79D50", VA = "0xA79D50")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0xA79F44", Offset = "0xA79F44", VA = "0xA79F44")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0xA79FC8", Offset = "0xA79FC8", VA = "0xA79FC8")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0xA7A264", Offset = "0xA7A264", VA = "0xA7A264")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0xA7A3C4", Offset = "0xA7A3C4", VA = "0xA7A3C4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0xA7A58C", Offset = "0xA7A58C", VA = "0xA7A58C")]
		public GrounderVRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000035")]
	public class Grounding
	{
		[Serializable]
		[Token(Token = "0x2000036")]
		public enum Quality
		{
			[Token(Token = "0x40001A0")]
			Fastest,
			[Token(Token = "0x40001A1")]
			Simple,
			[Token(Token = "0x40001A2")]
			Best
		}

		[Token(Token = "0x2000037")]
		public class Leg
		{
			[Token(Token = "0x40001A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Quaternion rotationOffset;

			[Token(Token = "0x40001AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public bool invertFootCenter;

			[Token(Token = "0x40001AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Grounding grounding;

			[Token(Token = "0x40001AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private float lastTime;

			[Token(Token = "0x40001B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private float deltaTime;

			[Token(Token = "0x40001B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private Vector3 lastPosition;

			[Token(Token = "0x40001B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private Quaternion toHitNormal;

			[Token(Token = "0x40001B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			private Quaternion r;

			[Token(Token = "0x40001B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 up;

			[Token(Token = "0x40001B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private bool doOverrideFootPosition;

			[Token(Token = "0x40001B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			private Vector3 overrideFootPosition;

			[Token(Token = "0x40001B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			private Vector3 transformPosition;

			[Token(Token = "0x1700001A")]
			public bool isGrounded
			{
				[Token(Token = "0x6000186")]
				[Address(RVA = "0xA7B9E0", Offset = "0xA7B9E0", VA = "0xA7B9E0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000187")]
				[Address(RVA = "0xA7B9E8", Offset = "0xA7B9E8", VA = "0xA7B9E8")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700001B")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x6000188")]
				[Address(RVA = "0xA7B9F4", Offset = "0xA7B9F4", VA = "0xA7B9F4")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000189")]
				[Address(RVA = "0xA7BA00", Offset = "0xA7BA00", VA = "0xA7BA00")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700001C")]
			public bool initiated
			{
				[Token(Token = "0x600018A")]
				[Address(RVA = "0xA7BA0C", Offset = "0xA7BA0C", VA = "0xA7BA0C")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600018B")]
				[Address(RVA = "0xA7BA14", Offset = "0xA7BA14", VA = "0xA7BA14")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700001D")]
			public float heightFromGround
			{
				[Token(Token = "0x600018C")]
				[Address(RVA = "0xA7BA20", Offset = "0xA7BA20", VA = "0xA7BA20")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600018D")]
				[Address(RVA = "0xA7BA28", Offset = "0xA7BA28", VA = "0xA7BA28")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700001E")]
			public Vector3 velocity
			{
				[Token(Token = "0x600018E")]
				[Address(RVA = "0xA7BA30", Offset = "0xA7BA30", VA = "0xA7BA30")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600018F")]
				[Address(RVA = "0xA7BA3C", Offset = "0xA7BA3C", VA = "0xA7BA3C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700001F")]
			public Transform transform
			{
				[Token(Token = "0x6000190")]
				[Address(RVA = "0xA7BA48", Offset = "0xA7BA48", VA = "0xA7BA48")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000191")]
				[Address(RVA = "0xA7BA50", Offset = "0xA7BA50", VA = "0xA7BA50")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000020")]
			public float IKOffset
			{
				[Token(Token = "0x6000192")]
				[Address(RVA = "0xA7BA58", Offset = "0xA7BA58", VA = "0xA7BA58")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000193")]
				[Address(RVA = "0xA7BA60", Offset = "0xA7BA60", VA = "0xA7BA60")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000021")]
			public RaycastHit heelHit
			{
				[Token(Token = "0x6000194")]
				[Address(RVA = "0xA7BA68", Offset = "0xA7BA68", VA = "0xA7BA68")]
				[CompilerGenerated]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x6000195")]
				[Address(RVA = "0xA7BA80", Offset = "0xA7BA80", VA = "0xA7BA80")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000022")]
			public RaycastHit capsuleHit
			{
				[Token(Token = "0x6000196")]
				[Address(RVA = "0xA7BAA0", Offset = "0xA7BAA0", VA = "0xA7BAA0")]
				[CompilerGenerated]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x6000197")]
				[Address(RVA = "0xA7BAB8", Offset = "0xA7BAB8", VA = "0xA7BAB8")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000023")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x600019C")]
				[Address(RVA = "0xA7C364", Offset = "0xA7C364", VA = "0xA7C364")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000024")]
			private float rootYOffset
			{
				[Token(Token = "0x60001A5")]
				[Address(RVA = "0xA7C4B4", Offset = "0xA7C4B4", VA = "0xA7C4B4")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x6000198")]
			[Address(RVA = "0xA7AB24", Offset = "0xA7AB24", VA = "0xA7AB24")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x6000199")]
			[Address(RVA = "0xA7BAD8", Offset = "0xA7BAD8", VA = "0xA7BAD8")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x600019A")]
			[Address(RVA = "0xA7B650", Offset = "0xA7B650", VA = "0xA7B650")]
			public void Reset()
			{
			}

			[Token(Token = "0x600019B")]
			[Address(RVA = "0xA7AC38", Offset = "0xA7AC38", VA = "0xA7AC38")]
			public void Process()
			{
			}

			[Token(Token = "0x600019D")]
			[Address(RVA = "0xA7BF78", Offset = "0xA7BF78", VA = "0xA7BF78")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x600019E")]
			[Address(RVA = "0xA7BB18", Offset = "0xA7BB18", VA = "0xA7BB18")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x600019F")]
			[Address(RVA = "0xA7C3F8", Offset = "0xA7C3F8", VA = "0xA7C3F8")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60001A0")]
			[Address(RVA = "0xA7BDE0", Offset = "0xA7BDE0", VA = "0xA7BDE0")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x60001A1")]
			[Address(RVA = "0xA7BE60", Offset = "0xA7BE60", VA = "0xA7BE60")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x60001A2")]
			[Address(RVA = "0xA7C464", Offset = "0xA7C464", VA = "0xA7C464")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x60001A3")]
			[Address(RVA = "0xA7C398", Offset = "0xA7C398", VA = "0xA7C398")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x60001A4")]
			[Address(RVA = "0xA7C540", Offset = "0xA7C540", VA = "0xA7C540")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60001A6")]
			[Address(RVA = "0xA7AA84", Offset = "0xA7AA84", VA = "0xA7AA84")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x2000038")]
		public class Pelvis
		{
			[Token(Token = "0x40001BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Grounding grounding;

			[Token(Token = "0x40001BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 lastRootPosition;

			[Token(Token = "0x40001BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float damperF;

			[Token(Token = "0x40001BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private bool initiated;

			[Token(Token = "0x40001BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float lastTime;

			[Token(Token = "0x17000025")]
			public Vector3 IKOffset
			{
				[Token(Token = "0x60001A7")]
				[Address(RVA = "0xA7C6F0", Offset = "0xA7C6F0", VA = "0xA7C6F0")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60001A8")]
				[Address(RVA = "0xA7C6FC", Offset = "0xA7C6FC", VA = "0xA7C6FC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000026")]
			public float heightOffset
			{
				[Token(Token = "0x60001A9")]
				[Address(RVA = "0xA7C708", Offset = "0xA7C708", VA = "0xA7C708")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60001AA")]
				[Address(RVA = "0xA7C710", Offset = "0xA7C710", VA = "0xA7C710")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x60001AB")]
			[Address(RVA = "0xA7ABFC", Offset = "0xA7ABFC", VA = "0xA7ABFC")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x60001AC")]
			[Address(RVA = "0xA7B5BC", Offset = "0xA7B5BC", VA = "0xA7B5BC")]
			public void Reset()
			{
			}

			[Token(Token = "0x60001AD")]
			[Address(RVA = "0xA7C718", Offset = "0xA7C718", VA = "0xA7C718")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60001AE")]
			[Address(RVA = "0xA7B3D0", Offset = "0xA7B3D0", VA = "0xA7B3D0")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x60001AF")]
			[Address(RVA = "0xA7AB1C", Offset = "0xA7AB1C", VA = "0xA7AB1C")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LayerMask layers;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float maxStep;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float heightOffset;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float footSpeed;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float footRadius;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float footCenterOffset;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float prediction;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float footRotationWeight;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float footRotationSpeed;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float maxFootRotationAngle;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool rotateSolver;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float pelvisSpeed;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float pelvisDamper;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float lowerPelvisWeight;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float liftPelvisWeight;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float rootSphereCastRadius;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool overstepFallsDown;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Quality quality;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool initiated;

		[Token(Token = "0x17000012")]
		public Leg[] legs
		{
			[Token(Token = "0x600016E")]
			[Address(RVA = "0xA7A5F0", Offset = "0xA7A5F0", VA = "0xA7A5F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600016F")]
			[Address(RVA = "0xA7A5F8", Offset = "0xA7A5F8", VA = "0xA7A5F8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public Pelvis pelvis
		{
			[Token(Token = "0x6000170")]
			[Address(RVA = "0xA7A600", Offset = "0xA7A600", VA = "0xA7A600")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000171")]
			[Address(RVA = "0xA7A608", Offset = "0xA7A608", VA = "0xA7A608")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000014")]
		public bool isGrounded
		{
			[Token(Token = "0x6000172")]
			[Address(RVA = "0xA7A610", Offset = "0xA7A610", VA = "0xA7A610")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000173")]
			[Address(RVA = "0xA7A618", Offset = "0xA7A618", VA = "0xA7A618")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000015")]
		public Transform root
		{
			[Token(Token = "0x6000174")]
			[Address(RVA = "0xA7A624", Offset = "0xA7A624", VA = "0xA7A624")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000175")]
			[Address(RVA = "0xA7A62C", Offset = "0xA7A62C", VA = "0xA7A62C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x6000176")]
			[Address(RVA = "0xA7A634", Offset = "0xA7A634", VA = "0xA7A634")]
			[CompilerGenerated]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x6000177")]
			[Address(RVA = "0xA7A64C", Offset = "0xA7A64C", VA = "0xA7A64C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public bool rootGrounded
		{
			[Token(Token = "0x6000178")]
			[Address(RVA = "0xA7A66C", Offset = "0xA7A66C", VA = "0xA7A66C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000018")]
		public Vector3 up
		{
			[Token(Token = "0x6000180")]
			[Address(RVA = "0xA7A914", Offset = "0xA7A914", VA = "0xA7A914")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000019")]
		private bool useRootRotation
		{
			[Token(Token = "0x6000183")]
			[Address(RVA = "0xA7B6E4", Offset = "0xA7B6E4", VA = "0xA7B6E4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0xA7A6B4", Offset = "0xA7A6B4", VA = "0xA7A6B4")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0xA7A97C", Offset = "0xA7A97C", VA = "0xA7A97C")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0xA75120", Offset = "0xA75120", VA = "0xA75120")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0xA75758", Offset = "0xA75758", VA = "0xA75758")]
		public void Update()
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0xA76714", Offset = "0xA76714", VA = "0xA76714")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0xA74D5C", Offset = "0xA74D5C", VA = "0xA74D5C")]
		public void Reset()
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0xA7AC20", Offset = "0xA7AC20", VA = "0xA7AC20")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0xA7B798", Offset = "0xA7B798", VA = "0xA7B798")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0xA7B81C", Offset = "0xA7B81C", VA = "0xA7B81C")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0xA7B970", Offset = "0xA7B970", VA = "0xA7B970")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0xA798B8", Offset = "0xA798B8", VA = "0xA798B8")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x2000039")]
	public class AimIK : IK
	{
		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverAim solver;

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0xA7C76C", Offset = "0xA7C76C", VA = "0xA7C76C", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0xA7C7B0", Offset = "0xA7C7B0", VA = "0xA7C7B0", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0xA7C7F4", Offset = "0xA7C7F4", VA = "0xA7C7F4")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0xA7C838", Offset = "0xA7C838", VA = "0xA7C838")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0xA7C87C", Offset = "0xA7C87C", VA = "0xA7C87C")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0xA7C8C0", Offset = "0xA7C8C0", VA = "0xA7C8C0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0xA7C8C8", Offset = "0xA7C8C8", VA = "0xA7C8C8")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x200003A")]
	public class ArmIK : IK
	{
		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverArm solver;

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0xA7C944", Offset = "0xA7C944", VA = "0xA7C944", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0xA7C988", Offset = "0xA7C988", VA = "0xA7C988", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0xA7C9CC", Offset = "0xA7C9CC", VA = "0xA7C9CC")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0xA7CA10", Offset = "0xA7CA10", VA = "0xA7CA10")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0xA7CA54", Offset = "0xA7CA54", VA = "0xA7CA54", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0xA7CA5C", Offset = "0xA7CA5C", VA = "0xA7CA5C")]
		public ArmIK()
		{
		}
	}
	[Token(Token = "0x200003B")]
	public class CCDIK : IK
	{
		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverCCD solver;

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0xA7CAD0", Offset = "0xA7CAD0", VA = "0xA7CAD0", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0xA7CB14", Offset = "0xA7CB14", VA = "0xA7CB14", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0xA7CB58", Offset = "0xA7CB58", VA = "0xA7CB58")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0xA7CB9C", Offset = "0xA7CB9C", VA = "0xA7CB9C")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0xA7CBE0", Offset = "0xA7CBE0", VA = "0xA7CBE0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0xA7CBE8", Offset = "0xA7CBE8", VA = "0xA7CBE8")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x200003C")]
	public class FABRIK : IK
	{
		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0xA7CC5C", Offset = "0xA7CC5C", VA = "0xA7CC5C", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0xA7CCA0", Offset = "0xA7CCA0", VA = "0xA7CCA0", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0xA7CCE4", Offset = "0xA7CCE4", VA = "0xA7CCE4")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0xA7CD28", Offset = "0xA7CD28", VA = "0xA7CD28")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0xA7CD6C", Offset = "0xA7CD6C", VA = "0xA7CD6C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0xA7CD74", Offset = "0xA7CD74", VA = "0xA7CD74")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x200003D")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0xA7CDE8", Offset = "0xA7CDE8", VA = "0xA7CDE8", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0xA7CE2C", Offset = "0xA7CE2C", VA = "0xA7CE2C", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0xA7CE70", Offset = "0xA7CE70", VA = "0xA7CE70")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0xA7CEB4", Offset = "0xA7CEB4", VA = "0xA7CEB4")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0xA7CEF8", Offset = "0xA7CEF8", VA = "0xA7CEF8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0xA7CF00", Offset = "0xA7CF00", VA = "0xA7CF00")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x200003E")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0xA7CF74", Offset = "0xA7CF74", VA = "0xA7CF74", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0xA7CFB8", Offset = "0xA7CFB8", VA = "0xA7CFB8", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0xA7CFFC", Offset = "0xA7CFFC", VA = "0xA7CFFC")]
		[ContextMenu("TUTORIAL VIDEO (SETUP)")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0xA7D040", Offset = "0xA7D040", VA = "0xA7D040")]
		[ContextMenu("TUTORIAL VIDEO (INSPECTOR)")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0xA7D084", Offset = "0xA7D084", VA = "0xA7D084")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0xA7D0C8", Offset = "0xA7D0C8", VA = "0xA7D0C8")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0xA7D10C", Offset = "0xA7D10C", VA = "0xA7D10C")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0xA7D14C", Offset = "0xA7D14C", VA = "0xA7D14C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0xA7D154", Offset = "0xA7D154", VA = "0xA7D154")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0xA7D324", Offset = "0xA7D324", VA = "0xA7D324")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0xA7D7E0", Offset = "0xA7D7E0", VA = "0xA7D7E0")]
		[ContextMenu("Reinitiate")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0xA7D800", Offset = "0xA7D800", VA = "0xA7D800")]
		[ContextMenu("Auto-detect References")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0xA7D8F0", Offset = "0xA7D8F0", VA = "0xA7D8F0")]
		public FullBodyBipedIK()
		{
		}
	}
	[Token(Token = "0x200003F")]
	public abstract class IK : SolverManager
	{
		[Token(Token = "0x60001DC")]
		public abstract IKSolver GetIKSolver();

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0xA7D9A0", Offset = "0xA7D9A0", VA = "0xA7D9A0", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0xA7DA18", Offset = "0xA7DA18", VA = "0xA7DA18", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0xA7DA88", Offset = "0xA7DA88", VA = "0xA7DA88", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60001E0")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x60001E1")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0xA7C93C", Offset = "0xA7C93C", VA = "0xA7C93C")]
		protected IK()
		{
		}
	}
	[Token(Token = "0x2000040")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IK[] IKComponents;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Animator animator;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool fixedFrame;

		[Token(Token = "0x17000027")]
		private bool animatePhysics
		{
			[Token(Token = "0x60001E3")]
			[Address(RVA = "0xA7DAD8", Offset = "0xA7DAD8", VA = "0xA7DAD8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0xA7DB64", Offset = "0xA7DB64", VA = "0xA7DB64")]
		private void Start()
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0xA7DBC8", Offset = "0xA7DBC8", VA = "0xA7DBC8")]
		private void Update()
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0xA7DC68", Offset = "0xA7DC68", VA = "0xA7DC68")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0xA7DC94", Offset = "0xA7DC94", VA = "0xA7DC94")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0xA7DBEC", Offset = "0xA7DBEC", VA = "0xA7DBEC")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0xA7DD18", Offset = "0xA7DD18", VA = "0xA7DD18")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x2000041")]
	public class LegIK : IK
	{
		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLeg solver;

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0xA7DD20", Offset = "0xA7DD20", VA = "0xA7DD20", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0xA7DD64", Offset = "0xA7DD64", VA = "0xA7DD64", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0xA7DDA8", Offset = "0xA7DDA8", VA = "0xA7DDA8")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0xA7DDEC", Offset = "0xA7DDEC", VA = "0xA7DDEC")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0xA7DE30", Offset = "0xA7DE30", VA = "0xA7DE30", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0xA7DE38", Offset = "0xA7DE38", VA = "0xA7DE38")]
		public LegIK()
		{
		}
	}
	[Token(Token = "0x2000042")]
	public class LimbIK : IK
	{
		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLimb solver;

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0xA7DEAC", Offset = "0xA7DEAC", VA = "0xA7DEAC", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0xA7DEF0", Offset = "0xA7DEF0", VA = "0xA7DEF0", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0xA7DF34", Offset = "0xA7DF34", VA = "0xA7DF34")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0xA7DF78", Offset = "0xA7DF78", VA = "0xA7DF78")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0xA7DFBC", Offset = "0xA7DFBC", VA = "0xA7DFBC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0xA7DFC4", Offset = "0xA7DFC4", VA = "0xA7DFC4")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x2000043")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt solver;

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0xA7E038", Offset = "0xA7E038", VA = "0xA7E038", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0xA7E07C", Offset = "0xA7E07C", VA = "0xA7E07C", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0xA7E0C0", Offset = "0xA7E0C0", VA = "0xA7E0C0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0xA7E104", Offset = "0xA7E104", VA = "0xA7E104")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0xA7E148", Offset = "0xA7E148", VA = "0xA7E148", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0xA7E150", Offset = "0xA7E150", VA = "0xA7E150")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x2000044")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0xA7E1C4", Offset = "0xA7E1C4", VA = "0xA7E1C4", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0xA7E208", Offset = "0xA7E208", VA = "0xA7E208", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0xA7E24C", Offset = "0xA7E24C", VA = "0xA7E24C")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0xA7E290", Offset = "0xA7E290", VA = "0xA7E290")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0xA7E2D4", Offset = "0xA7E2D4", VA = "0xA7E2D4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0xA7E2DC", Offset = "0xA7E2DC", VA = "0xA7E2DC")]
		public TrigonometricIK()
		{
		}
	}
	[Token(Token = "0x2000045")]
	public class VRIK : IK
	{
		[Serializable]
		[Token(Token = "0x2000046")]
		public class References
		{
			[Token(Token = "0x40001CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform root;

			[Token(Token = "0x40001D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform pelvis;

			[Token(Token = "0x40001D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spine;

			[Token(Token = "0x40001D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform chest;

			[Token(Token = "0x40001D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Transform neck;

			[Token(Token = "0x40001D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform head;

			[Token(Token = "0x40001D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Transform leftShoulder;

			[Token(Token = "0x40001D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Transform leftUpperArm;

			[Token(Token = "0x40001D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Transform leftForearm;

			[Token(Token = "0x40001D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Transform leftHand;

			[Token(Token = "0x40001D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Transform rightShoulder;

			[Token(Token = "0x40001DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Transform rightUpperArm;

			[Token(Token = "0x40001DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public Transform rightForearm;

			[Token(Token = "0x40001DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public Transform rightHand;

			[Token(Token = "0x40001DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			public Transform leftThigh;

			[Token(Token = "0x40001DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			public Transform leftCalf;

			[Token(Token = "0x40001DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Transform leftFoot;

			[Token(Token = "0x40001E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			public Transform leftToes;

			[Token(Token = "0x40001E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			public Transform rightThigh;

			[Token(Token = "0x40001E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			public Transform rightCalf;

			[Token(Token = "0x40001E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			public Transform rightFoot;

			[Token(Token = "0x40001E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			public Transform rightToes;

			[Token(Token = "0x17000028")]
			public bool isFilled
			{
				[Token(Token = "0x600020C")]
				[Address(RVA = "0xA7ED2C", Offset = "0xA7ED2C", VA = "0xA7ED2C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000029")]
			public bool isEmpty
			{
				[Token(Token = "0x600020D")]
				[Address(RVA = "0xA7E970", Offset = "0xA7E970", VA = "0xA7E970")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600020B")]
			[Address(RVA = "0xA7F330", Offset = "0xA7F330", VA = "0xA7F330")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x600020E")]
			[Address(RVA = "0xA7E438", Offset = "0xA7E438", VA = "0xA7E438")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Token(Token = "0x600020F")]
			[Address(RVA = "0xA7F328", Offset = "0xA7F328", VA = "0xA7F328")]
			public References()
			{
			}
		}

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public References references;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverVR solver;

		[Token(Token = "0x6000202")]
		[Address(RVA = "0xA7E350", Offset = "0xA7E350", VA = "0xA7E350", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0xA7E394", Offset = "0xA7E394", VA = "0xA7E394", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0xA7E3D8", Offset = "0xA7E3D8", VA = "0xA7E3D8")]
		[ContextMenu("TUTORIAL VIDEO (STEAMVR SETUP)")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0xA7E41C", Offset = "0xA7E41C", VA = "0xA7E41C")]
		[ContextMenu("Auto-detect References")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0xA7E8D4", Offset = "0xA7E8D4", VA = "0xA7E8D4")]
		[ContextMenu("Guess Hand Orientations")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0xA7E8FC", Offset = "0xA7E8FC", VA = "0xA7E8FC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0xA7E904", Offset = "0xA7E904", VA = "0xA7E904", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0xA7F0E8", Offset = "0xA7F0E8", VA = "0xA7F0E8", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0xA7F278", Offset = "0xA7F278", VA = "0xA7F278")]
		public VRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000047")]
	public class FABRIKChain
	{
		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FABRIK ik;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float pull;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float pin;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] children;

		[Token(Token = "0x6000210")]
		[Address(RVA = "0xA7F874", Offset = "0xA7F874", VA = "0xA7F874")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0xA7F944", Offset = "0xA7F944", VA = "0xA7F944")]
		public void Initiate()
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0xA7F964", Offset = "0xA7F964", VA = "0xA7F964")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0xA7FBB8", Offset = "0xA7FBB8", VA = "0xA7FBB8")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0xA7FA24", Offset = "0xA7FA24", VA = "0xA7FA24")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0xA7FC9C", Offset = "0xA7FC9C", VA = "0xA7FC9C")]
		public FABRIKChain()
		{
		}
	}
	[Token(Token = "0x2000048")]
	public class FBBIKArmBending : MonoBehaviour
	{
		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 bendDirectionOffsetLeft;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 bendDirectionOffsetRight;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 characterSpaceBendOffsetLeft;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 characterSpaceBendOffsetRight;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandTargetRotation;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Quaternion rightHandTargetRotation;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool initiated;

		[Token(Token = "0x6000216")]
		[Address(RVA = "0xA7FD08", Offset = "0xA7FD08", VA = "0xA7FD08")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0xA801B8", Offset = "0xA801B8", VA = "0xA801B8")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0xA8034C", Offset = "0xA8034C", VA = "0xA8034C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0xA80478", Offset = "0xA80478", VA = "0xA80478")]
		public FBBIKArmBending()
		{
		}
	}
	[Token(Token = "0x2000049")]
	public class FBBIKHeadEffector : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200004A")]
		public class BendBone
		{
			[Token(Token = "0x400021F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x4000220")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float weight;

			[Token(Token = "0x4000221")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x6000228")]
			[Address(RVA = "0xA83730", Offset = "0xA83730", VA = "0xA83730")]
			public BendBone()
			{
			}

			[Token(Token = "0x6000229")]
			[Address(RVA = "0xA80D70", Offset = "0xA80D70", VA = "0xA80D70")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x600022A")]
			[Address(RVA = "0xA81140", Offset = "0xA81140", VA = "0xA81140")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float positionWeight;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float bodyWeight;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float thighWeight;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool handsPullBody;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float rotationWeight;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float bodyClampWeight;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float headClampWeight;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float bendWeight;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BendBone[] bendBones;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float CCDWeight;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float roll;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float damper;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform[] CCDBones;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float postStretchWeight;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float maxStretch;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float stretchDamper;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public bool fixHead;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform[] stretchBones;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Vector3 chestDirection;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public float chestDirectionWeight;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] chestBones;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IKSolver.UpdateDelegate OnPostHeadEffectorFK;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 offset;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 headToBody;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 shoulderCenterToHead;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Vector3 headToLeftThigh;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Vector3 headToRightThigh;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 leftShoulderPos;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Vector3 rightShoulderPos;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float shoulderDist;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float leftShoulderDist;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float rightShoulderDist;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion chestRotation;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Quaternion headRotationRelativeToRoot;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Quaternion[] ccdDefaultLocalRotations;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 headLocalPosition;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private Quaternion headLocalRotation;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3[] stretchLocalPositions;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Quaternion[] stretchLocalRotations;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Vector3[] chestLocalPositions;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Quaternion[] chestLocalRotations;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private int bendBonesCount;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private int ccdBonesCount;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private int stretchBonesCount;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private int chestBonesCount;

		[Token(Token = "0x600021A")]
		[Address(RVA = "0xA80480", Offset = "0xA80480", VA = "0xA80480")]
		private void Start()
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0xA808C0", Offset = "0xA808C0", VA = "0xA808C0")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0xA80D9C", Offset = "0xA80D9C", VA = "0xA80D9C")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0xA81168", Offset = "0xA81168", VA = "0xA81168")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0xA81A64", Offset = "0xA81A64", VA = "0xA81A64")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0xA81E5C", Offset = "0xA81E5C", VA = "0xA81E5C")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0xA8226C", Offset = "0xA8226C", VA = "0xA8226C")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0xA82BE4", Offset = "0xA82BE4", VA = "0xA82BE4")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0xA817A8", Offset = "0xA817A8", VA = "0xA817A8")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0xA82E20", Offset = "0xA82E20", VA = "0xA82E20")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0xA82B04", Offset = "0xA82B04", VA = "0xA82B04")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0xA82A04", Offset = "0xA82A04", VA = "0xA82A04")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0xA83180", Offset = "0xA83180", VA = "0xA83180")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0xA8351C", Offset = "0xA8351C", VA = "0xA8351C")]
		public FBBIKHeadEffector()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004B")]
	public class FBIKChain
	{
		[Serializable]
		[Token(Token = "0x200004C")]
		public class ChildConstraint
		{
			[Token(Token = "0x4000239")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float pushElasticity;

			[Token(Token = "0x400023A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pullElasticity;

			[Token(Token = "0x400023B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Transform bone1;

			[Token(Token = "0x400023C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Transform bone2;

			[Token(Token = "0x400023F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float crossFade;

			[Token(Token = "0x4000240")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float inverseCrossFade;

			[Token(Token = "0x4000241")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int chain1Index;

			[Token(Token = "0x4000242")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private int chain2Index;

			[Token(Token = "0x1700002A")]
			public float nominalDistance
			{
				[Token(Token = "0x600023E")]
				[Address(RVA = "0xA866A0", Offset = "0xA866A0", VA = "0xA866A0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600023F")]
				[Address(RVA = "0xA866A8", Offset = "0xA866A8", VA = "0xA866A8")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700002B")]
			public bool isRigid
			{
				[Token(Token = "0x6000240")]
				[Address(RVA = "0xA866B0", Offset = "0xA866B0", VA = "0xA866B0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000241")]
				[Address(RVA = "0xA866B8", Offset = "0xA866B8", VA = "0xA866B8")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000242")]
			[Address(RVA = "0xA866C4", Offset = "0xA866C4", VA = "0xA866C4")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x6000243")]
			[Address(RVA = "0xA84374", Offset = "0xA84374", VA = "0xA84374")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000244")]
			[Address(RVA = "0xA84A58", Offset = "0xA84A58", VA = "0xA84A58")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000245")]
			[Address(RVA = "0xA86464", Offset = "0xA86464", VA = "0xA86464")]
			public void Solve(IKSolverFullBody solver)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200004D")]
		public enum Smoothing
		{
			[Token(Token = "0x4000244")]
			None,
			[Token(Token = "0x4000245")]
			Exponential,
			[Token(Token = "0x4000246")]
			Cubic
		}

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float pin;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float pull;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float push;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float pushParent;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float reach;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Smoothing reachSmoothing;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Smoothing pushSmoothing;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolver.Node[] nodes;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int[] children;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ChildConstraint[] childConstraints;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public IKConstraintBend bendConstraint;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float rootLength;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool initiated;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float length;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float distance;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IKSolver.Point p;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float reachForce;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float pullParentSum;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float[] crossFades;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float sqrMag1;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float sqrMag2;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float sqrMagDif;

		[Token(Token = "0x4000238")]
		private const float maxLimbLength = 0.99999f;

		[Token(Token = "0x600022B")]
		[Address(RVA = "0xA83790", Offset = "0xA83790", VA = "0xA83790")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0xA83928", Offset = "0xA83928", VA = "0xA83928")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0xA83A58", Offset = "0xA83A58", VA = "0xA83A58")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0xA83B14", Offset = "0xA83B14", VA = "0xA83B14")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0xA83C30", Offset = "0xA83C30", VA = "0xA83C30")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0xA84674", Offset = "0xA84674", VA = "0xA84674")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0xA83DAC", Offset = "0xA83DAC", VA = "0xA83DAC")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0xA84C3C", Offset = "0xA84C3C", VA = "0xA84C3C")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0xA84ED0", Offset = "0xA84ED0", VA = "0xA84ED0")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0xA851A0", Offset = "0xA851A0", VA = "0xA851A0")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0xA85B68", Offset = "0xA85B68", VA = "0xA85B68")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0xA86060", Offset = "0xA86060", VA = "0xA86060")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0xA86260", Offset = "0xA86260", VA = "0xA86260")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0xA85F4C", Offset = "0xA85F4C", VA = "0xA85F4C")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0xA85A08", Offset = "0xA85A08", VA = "0xA85A08")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0xA85EE8", Offset = "0xA85EE8", VA = "0xA85EE8")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0xA8633C", Offset = "0xA8633C", VA = "0xA8633C")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0xA85E14", Offset = "0xA85E14", VA = "0xA85E14")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0xA86164", Offset = "0xA86164", VA = "0xA86164")]
		private void BackwardReach(Vector3 position)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004E")]
	public class IKConstraintBend
	{
		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone1;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone2;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone3;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bendGoal;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 direction;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Quaternion rotationOffset;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float weight;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector3 defaultLocalDirection;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Vector3 defaultChildDirection;

		[NonSerialized]
		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float clampF;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int chainIndex1;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int nodeIndex1;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int chainIndex2;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int nodeIndex2;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int chainIndex3;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int nodeIndex3;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		private bool limbOrientationsSet;

		[Token(Token = "0x1700002C")]
		public bool initiated
		{
			[Token(Token = "0x6000246")]
			[Address(RVA = "0xA86720", Offset = "0xA86720", VA = "0xA86720")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000247")]
			[Address(RVA = "0xA86728", Offset = "0xA86728", VA = "0xA86728")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0xA838BC", Offset = "0xA838BC", VA = "0xA838BC")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0xA843C8", Offset = "0xA843C8", VA = "0xA843C8")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0xA8440C", Offset = "0xA8440C", VA = "0xA8440C")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0xA8687C", Offset = "0xA8687C", VA = "0xA8687C")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0xA853D8", Offset = "0xA853D8", VA = "0xA853D8")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0xA86734", Offset = "0xA86734", VA = "0xA86734")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0xA867D8", Offset = "0xA867D8", VA = "0xA867D8")]
		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x200004F")]
	public class IKEffector
	{
		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float positionWeight;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float rotationWeight;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 position;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Quaternion rotation;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 positionOffset;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool effectChildNodes;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float maintainRelativePositionWeight;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform[] childBones;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform planeBone1;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform planeBone2;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform planeBone3;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Quaternion planeRotationOffset;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float posW;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float rotW;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] localPositions;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool usePlaneNodes;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Quaternion animatedPlaneRotation;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 animatedPosition;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool firstUpdate;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int chainIndex;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int nodeIndex;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int plane1ChainIndex;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int plane1NodeIndex;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int plane2ChainIndex;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int plane2NodeIndex;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int plane3ChainIndex;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private int plane3NodeIndex;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int[] childChainIndexes;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int[] childNodeIndexes;

		[Token(Token = "0x1700002D")]
		public bool isEndEffector
		{
			[Token(Token = "0x6000250")]
			[Address(RVA = "0xA86C44", Offset = "0xA86C44", VA = "0xA86C44")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000251")]
			[Address(RVA = "0xA86C4C", Offset = "0xA86C4C", VA = "0xA86C4C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0xA83124", Offset = "0xA83124", VA = "0xA83124")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0xA86C58", Offset = "0xA86C58", VA = "0xA86C58")]
		public IKEffector()
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0xA86E28", Offset = "0xA86E28", VA = "0xA86E28")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0xA87130", Offset = "0xA87130", VA = "0xA87130")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0xA87408", Offset = "0xA87408", VA = "0xA87408")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0xA87528", Offset = "0xA87528", VA = "0xA87528")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0xA875C4", Offset = "0xA875C4", VA = "0xA875C4")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0xA87C78", Offset = "0xA87C78", VA = "0xA87C78")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0xA87CD0", Offset = "0xA87CD0", VA = "0xA87CD0")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0xA87EA4", Offset = "0xA87EA4", VA = "0xA87EA4")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0xA88100", Offset = "0xA88100", VA = "0xA88100")]
		private Vector3 GetPosition(IKSolverFullBody solver, out Quaternion planeRotationOffset)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000050")]
	public class IKMapping
	{
		[Serializable]
		[Token(Token = "0x2000051")]
		public class BoneMap
		{
			[Token(Token = "0x4000279")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x400027A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int chainIndex;

			[Token(Token = "0x400027B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int nodeIndex;

			[Token(Token = "0x400027C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x400027D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x400027E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 localSwingAxis;

			[Token(Token = "0x400027F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 localTwistAxis;

			[Token(Token = "0x4000280")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 planePosition;

			[Token(Token = "0x4000281")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 ikPosition;

			[Token(Token = "0x4000282")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion defaultLocalTargetRotation;

			[Token(Token = "0x4000283")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			private Quaternion maintainRotation;

			[Token(Token = "0x4000284")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			public float length;

			[Token(Token = "0x4000285")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Quaternion animatedRotation;

			[Token(Token = "0x4000286")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private Transform planeBone1;

			[Token(Token = "0x4000287")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private Transform planeBone2;

			[Token(Token = "0x4000288")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Transform planeBone3;

			[Token(Token = "0x4000289")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private int plane1ChainIndex;

			[Token(Token = "0x400028A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private int plane1NodeIndex;

			[Token(Token = "0x400028B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private int plane2ChainIndex;

			[Token(Token = "0x400028C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			private int plane2NodeIndex;

			[Token(Token = "0x400028D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private int plane3ChainIndex;

			[Token(Token = "0x400028E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private int plane3NodeIndex;

			[Token(Token = "0x1700002E")]
			public Vector3 swingDirection
			{
				[Token(Token = "0x6000262")]
				[Address(RVA = "0xA896E0", Offset = "0xA896E0", VA = "0xA896E0")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700002F")]
			public bool isNodeBone
			{
				[Token(Token = "0x6000265")]
				[Address(RVA = "0xA89798", Offset = "0xA89798", VA = "0xA89798")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000030")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x6000278")]
				[Address(RVA = "0xA89B78", Offset = "0xA89B78", VA = "0xA89B78")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x6000261")]
			[Address(RVA = "0xA8962C", Offset = "0xA8962C", VA = "0xA8962C")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000263")]
			[Address(RVA = "0xA89710", Offset = "0xA89710", VA = "0xA89710")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000264")]
			[Address(RVA = "0xA89754", Offset = "0xA89754", VA = "0xA89754")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x6000266")]
			[Address(RVA = "0xA897A8", Offset = "0xA897A8", VA = "0xA897A8")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x6000267")]
			[Address(RVA = "0xA8987C", Offset = "0xA8987C", VA = "0xA8987C")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x6000268")]
			[Address(RVA = "0xA89884", Offset = "0xA89884", VA = "0xA89884")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x6000269")]
			[Address(RVA = "0xA89950", Offset = "0xA89950", VA = "0xA89950")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x600026A")]
			[Address(RVA = "0xA899BC", Offset = "0xA899BC", VA = "0xA899BC")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x600026B")]
			[Address(RVA = "0xA89A68", Offset = "0xA89A68", VA = "0xA89A68")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x600026C")]
			[Address(RVA = "0xA89CE0", Offset = "0xA89CE0", VA = "0xA89CE0")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x600026D")]
			[Address(RVA = "0xA89D0C", Offset = "0xA89D0C", VA = "0xA89D0C")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x600026E")]
			[Address(RVA = "0xA89D38", Offset = "0xA89D38", VA = "0xA89D38")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x600026F")]
			[Address(RVA = "0xA89D60", Offset = "0xA89D60", VA = "0xA89D60")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x6000270")]
			[Address(RVA = "0xA89E70", Offset = "0xA89E70", VA = "0xA89E70")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000271")]
			[Address(RVA = "0xA89FF4", Offset = "0xA89FF4", VA = "0xA89FF4")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x6000272")]
			[Address(RVA = "0xA8A114", Offset = "0xA8A114", VA = "0xA8A114")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x6000273")]
			[Address(RVA = "0xA8A178", Offset = "0xA8A178", VA = "0xA8A178")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x6000274")]
			[Address(RVA = "0xA8A2F8", Offset = "0xA8A2F8", VA = "0xA8A2F8")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x6000275")]
			[Address(RVA = "0xA8A478", Offset = "0xA8A478", VA = "0xA8A478")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x6000276")]
			[Address(RVA = "0xA8A4F4", Offset = "0xA8A4F4", VA = "0xA8A4F4")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x6000277")]
			[Address(RVA = "0xA89EE4", Offset = "0xA89EE4", VA = "0xA89EE4")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000279")]
			[Address(RVA = "0xA8A610", Offset = "0xA8A610", VA = "0xA8A610")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0xA893BC", Offset = "0xA893BC", VA = "0xA893BC", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0xA893C4", Offset = "0xA893C4", VA = "0xA893C4", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0xA893C8", Offset = "0xA893C8", VA = "0xA893C8")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0xA89510", Offset = "0xA89510", VA = "0xA89510")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0xA89624", Offset = "0xA89624", VA = "0xA89624")]
		public IKMapping()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000052")]
	public class IKMappingBone : IKMapping
	{
		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoneMap boneMap;

		[Token(Token = "0x600027A")]
		[Address(RVA = "0xA8A62C", Offset = "0xA8A62C", VA = "0xA8A62C", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0xA8A6D4", Offset = "0xA8A6D4", VA = "0xA8A6D4")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0xA8A764", Offset = "0xA8A764", VA = "0xA8A764")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0xA8A77C", Offset = "0xA8A77C", VA = "0xA8A77C")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0xA8A798", Offset = "0xA8A798", VA = "0xA8A798", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0xA8A840", Offset = "0xA8A840", VA = "0xA8A840")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0xA8A858", Offset = "0xA8A858", VA = "0xA8A858")]
		public void WritePose(float solverWeight)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000053")]
	public class IKMappingLimb : IKMapping
	{
		[Serializable]
		[Token(Token = "0x2000054")]
		public enum BoneMapType
		{
			[Token(Token = "0x400029E")]
			Parent,
			[Token(Token = "0x400029F")]
			Bone1,
			[Token(Token = "0x40002A0")]
			Bone2,
			[Token(Token = "0x40002A1")]
			Bone3
		}

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform parentBone;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone1;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone2;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bone3;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float weight;

		[NonSerialized]
		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool updatePlaneRotations;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private BoneMap boneMapParent;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap boneMap1;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap boneMap2;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap boneMap3;

		[Token(Token = "0x6000281")]
		[Address(RVA = "0xA8A87C", Offset = "0xA8A87C", VA = "0xA8A87C", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0xA8A8F0", Offset = "0xA8A8F0", VA = "0xA8A8F0")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0xA8A9B8", Offset = "0xA8A9B8", VA = "0xA8A9B8")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0xA8AB04", Offset = "0xA8AB04", VA = "0xA8AB04")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0xA8AB64", Offset = "0xA8AB64", VA = "0xA8AB64")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0xA8ABFC", Offset = "0xA8ABFC", VA = "0xA8ABFC")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0xA8ACA4", Offset = "0xA8ACA4", VA = "0xA8ACA4", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0xA8AF58", Offset = "0xA8AF58", VA = "0xA8AF58")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0xA8AFB8", Offset = "0xA8AFB8", VA = "0xA8AFB8")]
		public void WritePose(IKSolverFullBody solver, bool fullBody)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000055")]
	public class IKMappingSpine : IKMapping
	{
		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform[] spineBones;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform leftUpperArmBone;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rightUpperArmBone;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftThighBone;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightThighBone;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int iterations;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float twistWeight;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int rootNodeIndex;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap[] spine;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap leftUpperArm;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap rightUpperArm;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private BoneMap leftThigh;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private BoneMap rightThigh;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool useFABRIK;

		[Token(Token = "0x600028A")]
		[Address(RVA = "0xA8B0FC", Offset = "0xA8B0FC", VA = "0xA8B0FC", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0xA8B428", Offset = "0xA8B428", VA = "0xA8B428")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0xA8B5A0", Offset = "0xA8B5A0", VA = "0xA8B5A0")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0xA8B614", Offset = "0xA8B614", VA = "0xA8B614")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0xA8B670", Offset = "0xA8B670", VA = "0xA8B670")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0xA8B6E8", Offset = "0xA8B6E8", VA = "0xA8B6E8", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0xA8BD60", Offset = "0xA8BD60", VA = "0xA8BD60")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0xA8BD98", Offset = "0xA8BD98", VA = "0xA8BD98")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0xA8BFFC", Offset = "0xA8BFFC", VA = "0xA8BFFC")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0xA8C31C", Offset = "0xA8C31C", VA = "0xA8C31C")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0xA8C3FC", Offset = "0xA8C3FC", VA = "0xA8C3FC")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0xA8C4B0", Offset = "0xA8C4B0", VA = "0xA8C4B0")]
		private void MapToSolverPositions(IKSolverFullBody solver)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000056")]
	public abstract class IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000057")]
		public class Point
		{
			[Token(Token = "0x40002B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x40002BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float weight;

			[Token(Token = "0x40002BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 solverPosition;

			[Token(Token = "0x40002BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Quaternion solverRotation;

			[Token(Token = "0x40002BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x40002BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x60002AA")]
			[Address(RVA = "0xA8CB1C", Offset = "0xA8CB1C", VA = "0xA8CB1C")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60002AB")]
			[Address(RVA = "0xA8CB60", Offset = "0xA8CB60", VA = "0xA8CB60")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x60002AC")]
			[Address(RVA = "0xA8CC40", Offset = "0xA8CC40", VA = "0xA8CC40")]
			public Point()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000058")]
		public class Bone : Point
		{
			[Token(Token = "0x40002BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x40002C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float sqrMag;

			[Token(Token = "0x40002C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 axis;

			[Token(Token = "0x40002C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private RotationLimit _rotationLimit;

			[Token(Token = "0x40002C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private bool isLimited;

			[Token(Token = "0x17000032")]
			public RotationLimit rotationLimit
			{
				[Token(Token = "0x60002AD")]
				[Address(RVA = "0xA8CCA0", Offset = "0xA8CCA0", VA = "0xA8CCA0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002AE")]
			[Address(RVA = "0xA8CD90", Offset = "0xA8CD90", VA = "0xA8CD90")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60002AF")]
			[Address(RVA = "0xA8CFFC", Offset = "0xA8CFFC", VA = "0xA8CFFC")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60002B0")]
			[Address(RVA = "0xA8D1F0", Offset = "0xA8D1F0", VA = "0xA8D1F0")]
			public Bone()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000059")]
		public class Node : Point
		{
			[Token(Token = "0x40002C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x40002C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float effectorPositionWeight;

			[Token(Token = "0x40002C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public float effectorRotationWeight;

			[Token(Token = "0x40002C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 offset;

			[Token(Token = "0x60002B1")]
			[Address(RVA = "0xA8D25C", Offset = "0xA8D25C", VA = "0xA8D25C")]
			public Node()
			{
			}

			[Token(Token = "0x60002B2")]
			[Address(RVA = "0xA8D260", Offset = "0xA8D260", VA = "0xA8D260")]
			public Node(Transform transform)
			{
			}
		}

		[Token(Token = "0x200005A")]
		public delegate void UpdateDelegate();

		[Token(Token = "0x200005B")]
		public delegate void IterationDelegate(int i);

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 IKPosition;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float IKPositionWeight;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateDelegate OnPreInitiate;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UpdateDelegate OnPostInitiate;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UpdateDelegate OnPreUpdate;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UpdateDelegate OnPostUpdate;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected bool firstInitiation;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		protected Transform root;

		[Token(Token = "0x17000031")]
		public bool initiated
		{
			[Token(Token = "0x600029E")]
			[Address(RVA = "0xA8C91C", Offset = "0xA8C91C", VA = "0xA8C91C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600029F")]
			[Address(RVA = "0xA8C924", Offset = "0xA8C924", VA = "0xA8C924")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000296")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x6000297")]
		[Address(RVA = "0xA8C6EC", Offset = "0xA8C6EC", VA = "0xA8C6EC")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0xA8C868", Offset = "0xA8C868", VA = "0xA8C868")]
		public void Update()
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0xA8C8D8", Offset = "0xA8C8D8", VA = "0xA8C8D8", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0xA8C8E4", Offset = "0xA8C8E4", VA = "0xA8C8E4")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0xA8C8F0", Offset = "0xA8C8F0", VA = "0xA8C8F0")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0xA8C8F8", Offset = "0xA8C8F8", VA = "0xA8C8F8")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0xA8C914", Offset = "0xA8C914", VA = "0xA8C914")]
		public Transform GetRoot()
		{
			return null;
		}

		[Token(Token = "0x60002A0")]
		public abstract Point[] GetPoints();

		[Token(Token = "0x60002A1")]
		public abstract Point GetPoint(Transform transform);

		[Token(Token = "0x60002A2")]
		public abstract void FixTransforms();

		[Token(Token = "0x60002A3")]
		public abstract void StoreDefaultLocalState();

		[Token(Token = "0x60002A4")]
		protected abstract void OnInitiate();

		[Token(Token = "0x60002A5")]
		protected abstract void OnUpdate();

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0xA8C930", Offset = "0xA8C930", VA = "0xA8C930")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0xA8C948", Offset = "0xA8C948", VA = "0xA8C948")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0xA8CA6C", Offset = "0xA8CA6C", VA = "0xA8CA6C")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0xA8CB04", Offset = "0xA8CB04", VA = "0xA8CB04")]
		protected IKSolver()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005C")]
	public class IKSolverAim : IKSolverHeuristic
	{
		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform transform;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 axis;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public Vector3 poleAxis;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Vector3 polePosition;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float poleWeight;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform poleTarget;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public float clampWeight;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public int clampSmoothing;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float step;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 clampedIKPosition;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RotationLimit transformLimit;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Transform lastTransform;

		[Token(Token = "0x17000033")]
		public Vector3 transformAxis
		{
			[Token(Token = "0x60002B8")]
			[Address(RVA = "0xA8D58C", Offset = "0xA8D58C", VA = "0xA8D58C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000034")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x60002B9")]
			[Address(RVA = "0xA8D5BC", Offset = "0xA8D5BC", VA = "0xA8D5BC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000035")]
		protected override int minBones
		{
			[Token(Token = "0x60002BC")]
			[Address(RVA = "0xA8E20C", Offset = "0xA8E20C", VA = "0xA8E20C", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000036")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x60002C0")]
			[Address(RVA = "0xA8E74C", Offset = "0xA8E74C", VA = "0xA8E74C", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0xA8D454", Offset = "0xA8D454", VA = "0xA8D454")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0xA8D5EC", Offset = "0xA8D5EC", VA = "0xA8D5EC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0xA8D878", Offset = "0xA8D878", VA = "0xA8D878", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0xA8E164", Offset = "0xA8E164", VA = "0xA8E164")]
		private void Solve()
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0xA8DE00", Offset = "0xA8DE00", VA = "0xA8DE00")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0xA8E214", Offset = "0xA8E214", VA = "0xA8E214")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0xA8E7AC", Offset = "0xA8E7AC", VA = "0xA8E7AC")]
		public IKSolverAim()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005D")]
	public class IKSolverArm : IKSolver
	{
		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float IKRotationWeight;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point chest;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point shoulder;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point upperArm;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point forearm;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point hand;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool isLeft;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IKSolverVR.Arm arm;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3[] positions;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion[] rotations;

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0xA8E8CC", Offset = "0xA8E8CC", VA = "0xA8E8CC", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0xA8EC70", Offset = "0xA8EC70", VA = "0xA8EC70", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0xA8EDF0", Offset = "0xA8EDF0", VA = "0xA8EDF0", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0xA8EF50", Offset = "0xA8EF50", VA = "0xA8EF50", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0xA8EF90", Offset = "0xA8EF90", VA = "0xA8EF90", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0xA8EFE0", Offset = "0xA8EFE0", VA = "0xA8EFE0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0xA8F340", Offset = "0xA8F340", VA = "0xA8F340", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0xA8F360", Offset = "0xA8F360", VA = "0xA8F360")]
		private void Solve()
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0xA8F038", Offset = "0xA8F038", VA = "0xA8F038")]
		private void Read()
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0xA8F3C0", Offset = "0xA8F3C0", VA = "0xA8F3C0")]
		private void Write()
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0xA8F538", Offset = "0xA8F538", VA = "0xA8F538")]
		public IKSolverArm()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005E")]
	public class IKSolverCCD : IKSolverHeuristic
	{
		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0xA8F72C", Offset = "0xA8F72C", VA = "0xA8F72C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0xA8FC20", Offset = "0xA8FC20", VA = "0xA8FC20", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0xA902F4", Offset = "0xA902F4", VA = "0xA902F4")]
		protected void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0xA90984", Offset = "0xA90984", VA = "0xA90984")]
		public IKSolverCCD()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005F")]
	public class IKSolverFABRIK : IKSolverHeuristic
	{
		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool[] limitedBones;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3[] solverLocalPositions;

		[Token(Token = "0x17000037")]
		protected override bool boneLengthCanBeZero
		{
			[Token(Token = "0x60002D6")]
			[Address(RVA = "0xA9196C", Offset = "0xA9196C", VA = "0xA9196C", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0xA90988", Offset = "0xA90988", VA = "0xA90988")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0xA90F68", Offset = "0xA90F68", VA = "0xA90F68")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0xA91098", Offset = "0xA91098", VA = "0xA91098", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0xA91120", Offset = "0xA91120", VA = "0xA91120", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0xA91634", Offset = "0xA91634", VA = "0xA91634", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0xA91974", Offset = "0xA91974", VA = "0xA91974")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0xA90A60", Offset = "0xA90A60", VA = "0xA90A60")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0xA91050", Offset = "0xA91050", VA = "0xA91050")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0xA91924", Offset = "0xA91924", VA = "0xA91924")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0xA90DFC", Offset = "0xA90DFC", VA = "0xA90DFC")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0xA92020", Offset = "0xA92020", VA = "0xA92020")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0xA92088", Offset = "0xA92088", VA = "0xA92088")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0xA92158", Offset = "0xA92158", VA = "0xA92158")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0xA92220", Offset = "0xA92220", VA = "0xA92220")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0xA913AC", Offset = "0xA913AC", VA = "0xA913AC")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0xA914F0", Offset = "0xA914F0", VA = "0xA914F0")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0xA92310", Offset = "0xA92310", VA = "0xA92310")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0xA91C10", Offset = "0xA91C10", VA = "0xA91C10")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0xA91040", Offset = "0xA91040", VA = "0xA91040")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0xA92980", Offset = "0xA92980", VA = "0xA92980")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0xA924D0", Offset = "0xA924D0", VA = "0xA924D0")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0xA91A90", Offset = "0xA91A90", VA = "0xA91A90")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0xA91B60", Offset = "0xA91B60", VA = "0xA91B60")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0xA92A38", Offset = "0xA92A38", VA = "0xA92A38")]
		public IKSolverFABRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000060")]
	public class IKSolverFABRIKRoot : IKSolver
	{
		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int iterations;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float rootPin;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FABRIKChain[] chains;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool zeroWeightApplied;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] isRoot;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 rootDefaultPosition;

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0xA92AD0", Offset = "0xA92AD0", VA = "0xA92AD0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0xA93194", Offset = "0xA93194", VA = "0xA93194", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0xA93220", Offset = "0xA93220", VA = "0xA93220", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0xA932B4", Offset = "0xA932B4", VA = "0xA932B4", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0xA933AC", Offset = "0xA933AC", VA = "0xA933AC")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0xA9343C", Offset = "0xA9343C", VA = "0xA9343C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0xA9383C", Offset = "0xA9383C", VA = "0xA9383C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0xA93A34", Offset = "0xA93A34", VA = "0xA93A34", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0xA938DC", Offset = "0xA938DC", VA = "0xA938DC")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0xA93614", Offset = "0xA93614", VA = "0xA93614")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0xA93AB8", Offset = "0xA93AB8", VA = "0xA93AB8")]
		public IKSolverFABRIKRoot()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000061")]
	public class IKSolverFullBody : IKSolver
	{
		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int iterations;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FBIKChain[] chain;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public IKEffector[] effectors;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public IKMappingSpine spineMapping;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public IKMappingBone[] boneMappings;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public IKMappingLimb[] limbMappings;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool FABRIKPass;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public UpdateDelegate OnPreRead;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public UpdateDelegate OnPreSolve;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public IterationDelegate OnPostIteration;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public UpdateDelegate OnPreBend;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public UpdateDelegate OnPostSolve;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public UpdateDelegate OnStoreDefaultLocalState;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public UpdateDelegate OnFixTransforms;

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0xA93B34", Offset = "0xA93B34", VA = "0xA93B34")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0xA93C10", Offset = "0xA93C10", VA = "0xA93C10")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0xA89E20", Offset = "0xA89E20", VA = "0xA89E20")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0xA8966C", Offset = "0xA8966C", VA = "0xA8966C")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0xA93D24", Offset = "0xA93D24", VA = "0xA93D24", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0xA93EC4", Offset = "0xA93EC4", VA = "0xA93EC4", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0xA94020", Offset = "0xA94020", VA = "0xA94020", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0xA94224", Offset = "0xA94224", VA = "0xA94224", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0xA942F4", Offset = "0xA942F4", VA = "0xA942F4", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0xA943D0", Offset = "0xA943D0", VA = "0xA943D0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0xA94530", Offset = "0xA94530", VA = "0xA94530", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0xA946CC", Offset = "0xA946CC", VA = "0xA946CC", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0xA94900", Offset = "0xA94900", VA = "0xA94900", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0xA94BE0", Offset = "0xA94BE0", VA = "0xA94BE0", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0xA94C18", Offset = "0xA94C18", VA = "0xA94C18", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0xA94CF0", Offset = "0xA94CF0", VA = "0xA94CF0")]
		public IKSolverFullBody()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000062")]
	public enum FullBodyBipedEffector
	{
		[Token(Token = "0x40002FA")]
		Body,
		[Token(Token = "0x40002FB")]
		LeftShoulder,
		[Token(Token = "0x40002FC")]
		RightShoulder,
		[Token(Token = "0x40002FD")]
		LeftThigh,
		[Token(Token = "0x40002FE")]
		RightThigh,
		[Token(Token = "0x40002FF")]
		LeftHand,
		[Token(Token = "0x4000300")]
		RightHand,
		[Token(Token = "0x4000301")]
		LeftFoot,
		[Token(Token = "0x4000302")]
		RightFoot
	}
	[Serializable]
	[Token(Token = "0x2000063")]
	public enum FullBodyBipedChain
	{
		[Token(Token = "0x4000304")]
		LeftArm,
		[Token(Token = "0x4000305")]
		RightArm,
		[Token(Token = "0x4000306")]
		LeftLeg,
		[Token(Token = "0x4000307")]
		RightLeg
	}
	[Serializable]
	[Token(Token = "0x2000064")]
	public class IKSolverFullBodyBiped : IKSolverFullBody
	{
		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Transform rootNode;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public float spineStiffness;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public float pullBodyVertical;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public float pullBodyHorizontal;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 offset;

		[Token(Token = "0x17000038")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x6000305")]
			[Address(RVA = "0xA94E44", Offset = "0xA94E44", VA = "0xA94E44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000039")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x6000306")]
			[Address(RVA = "0xA94F84", Offset = "0xA94F84", VA = "0xA94F84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003A")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x6000307")]
			[Address(RVA = "0xA94F8C", Offset = "0xA94F8C", VA = "0xA94F8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003B")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x6000308")]
			[Address(RVA = "0xA94F94", Offset = "0xA94F94", VA = "0xA94F94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003C")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x6000309")]
			[Address(RVA = "0xA94F9C", Offset = "0xA94F9C", VA = "0xA94F9C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003D")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x600030A")]
			[Address(RVA = "0xA94FA4", Offset = "0xA94FA4", VA = "0xA94FA4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003E")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x600030B")]
			[Address(RVA = "0xA94FAC", Offset = "0xA94FAC", VA = "0xA94FAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003F")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x600030C")]
			[Address(RVA = "0xA94FB4", Offset = "0xA94FB4", VA = "0xA94FB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000040")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x600030D")]
			[Address(RVA = "0xA94FBC", Offset = "0xA94FBC", VA = "0xA94FBC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000041")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x600030E")]
			[Address(RVA = "0xA94FC4", Offset = "0xA94FC4", VA = "0xA94FC4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000042")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x600030F")]
			[Address(RVA = "0xA94FF0", Offset = "0xA94FF0", VA = "0xA94FF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000043")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x6000310")]
			[Address(RVA = "0xA9501C", Offset = "0xA9501C", VA = "0xA9501C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000044")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x6000311")]
			[Address(RVA = "0xA95044", Offset = "0xA95044", VA = "0xA95044")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000045")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x6000312")]
			[Address(RVA = "0xA95070", Offset = "0xA95070", VA = "0xA95070")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000046")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x6000313")]
			[Address(RVA = "0xA9509C", Offset = "0xA9509C", VA = "0xA9509C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000047")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x6000314")]
			[Address(RVA = "0xA950C8", Offset = "0xA950C8", VA = "0xA950C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000048")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x600031E")]
			[Address(RVA = "0xA96FD8", Offset = "0xA96FD8", VA = "0xA96FD8")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600031F")]
			[Address(RVA = "0xA96FE4", Offset = "0xA96FE4", VA = "0xA96FE4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0xA950F0", Offset = "0xA950F0", VA = "0xA950F0")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0xA951A0", Offset = "0xA951A0", VA = "0xA951A0")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0xA94E4C", Offset = "0xA94E4C", VA = "0xA94E4C")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0xA95268", Offset = "0xA95268", VA = "0xA95268")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0xA95318", Offset = "0xA95318", VA = "0xA95318")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0xA953C4", Offset = "0xA953C4", VA = "0xA953C4")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0xA95484", Offset = "0xA95484", VA = "0xA95484", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0xA95618", Offset = "0xA95618", VA = "0xA95618")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0xA96A28", Offset = "0xA96A28", VA = "0xA96A28")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0xA96E78", Offset = "0xA96E78", VA = "0xA96E78")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0xA96F28", Offset = "0xA96F28", VA = "0xA96F28")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0xA96FF0", Offset = "0xA96FF0", VA = "0xA96FF0")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0xA970B4", Offset = "0xA970B4", VA = "0xA970B4", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0xA97184", Offset = "0xA97184", VA = "0xA97184")]
		private void PullBody()
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0xA972A0", Offset = "0xA972A0", VA = "0xA972A0")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0xA97430", Offset = "0xA97430", VA = "0xA97430")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0xA975A8", Offset = "0xA975A8", VA = "0xA975A8", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0xA97808", Offset = "0xA97808", VA = "0xA97808", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0xA97880", Offset = "0xA97880", VA = "0xA97880")]
		public IKSolverFullBodyBiped()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000065")]
	public class IKSolverHeuristic : IKSolver
	{
		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float tolerance;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int maxIterations;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useRotationLimits;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		public bool XY;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Bone[] bones;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Vector3 lastLocalDirection;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		protected float chainLength;

		[Token(Token = "0x17000049")]
		protected virtual int minBones
		{
			[Token(Token = "0x6000330")]
			[Address(RVA = "0xA97FBC", Offset = "0xA97FBC", VA = "0xA97FBC", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700004A")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x6000331")]
			[Address(RVA = "0xA97FC4", Offset = "0xA97FC4", VA = "0xA97FC4", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004B")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x6000332")]
			[Address(RVA = "0xA97FCC", Offset = "0xA97FCC", VA = "0xA97FCC", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004C")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x6000336")]
			[Address(RVA = "0xA97FDC", Offset = "0xA97FDC", VA = "0xA97FDC", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700004D")]
		protected float positionOffset
		{
			[Token(Token = "0x6000337")]
			[Address(RVA = "0xA902AC", Offset = "0xA902AC", VA = "0xA902AC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0xA9788C", Offset = "0xA9788C", VA = "0xA9788C")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0xA97A34", Offset = "0xA97A34", VA = "0xA97A34", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0xA97A90", Offset = "0xA97A90", VA = "0xA97A90", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0xA97B00", Offset = "0xA97B00", VA = "0xA97B00", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0xA97ED8", Offset = "0xA97ED8", VA = "0xA97ED8", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0xA97EE0", Offset = "0xA97EE0", VA = "0xA97EE0", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0xA97FD4", Offset = "0xA97FD4", VA = "0xA97FD4", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0xA97FD8", Offset = "0xA97FD8", VA = "0xA97FD8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0xA8F798", Offset = "0xA8F798", VA = "0xA8F798")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0xA8FF00", Offset = "0xA8FF00", VA = "0xA8FF00")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0xA98098", Offset = "0xA98098", VA = "0xA98098")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0xA8E84C", Offset = "0xA8E84C", VA = "0xA8E84C")]
		public IKSolverHeuristic()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000066")]
	public class IKSolverLeg : IKSolver
	{
		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float IKRotationWeight;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point pelvis;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point thigh;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point calf;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point foot;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point toe;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public IKSolverVR.Leg leg;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 heelOffset;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] positions;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Quaternion[] rotations;

		[Token(Token = "0x600033B")]
		[Address(RVA = "0xA9832C", Offset = "0xA9832C", VA = "0xA9832C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0xA986D0", Offset = "0xA986D0", VA = "0xA986D0", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0xA98850", Offset = "0xA98850", VA = "0xA98850", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0xA989B0", Offset = "0xA989B0", VA = "0xA989B0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0xA989F0", Offset = "0xA989F0", VA = "0xA989F0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0xA98A40", Offset = "0xA98A40", VA = "0xA98A40", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0xA98DA0", Offset = "0xA98DA0", VA = "0xA98DA0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0xA98DC0", Offset = "0xA98DC0", VA = "0xA98DC0")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0xA98A98", Offset = "0xA98A98", VA = "0xA98A98")]
		private void Read()
		{
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0xA98E48", Offset = "0xA98E48", VA = "0xA98E48")]
		private void Write()
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0xA98FC0", Offset = "0xA98FC0", VA = "0xA98FC0")]
		public IKSolverLeg()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000067")]
	public class IKSolverLimb : IKSolverTrigonometric
	{
		[Serializable]
		[Token(Token = "0x2000068")]
		public enum BendModifier
		{
			[Token(Token = "0x4000332")]
			Animation,
			[Token(Token = "0x4000333")]
			Target,
			[Token(Token = "0x4000334")]
			Parent,
			[Token(Token = "0x4000335")]
			Arm,
			[Token(Token = "0x4000336")]
			Goal
		}

		[Serializable]
		[Token(Token = "0x2000069")]
		public struct AxisDirection
		{
			[Token(Token = "0x4000337")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 direction;

			[Token(Token = "0x4000338")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 axis;

			[Token(Token = "0x4000339")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float dot;

			[Token(Token = "0x6000350")]
			[Address(RVA = "0xA9A480", Offset = "0xA9A480", VA = "0xA9A480")]
			public AxisDirection(Vector3 direction, Vector3 axis)
			{
			}
		}

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public AvatarIKGoal goal;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public BendModifier bendModifier;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float bendModifierWeight;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform bendGoal;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool maintainBendFor1Frame;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		private bool maintainRotationFor1Frame;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion defaultRootRotation;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Quaternion parentDefaultRotation;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Quaternion bone3RotationBeforeSolve;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Quaternion maintainRotation;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private Quaternion bone3DefaultRotation;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Vector3 _bendNormal;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 animationNormal;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private AxisDirection[] axisDirectionsLeft;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private AxisDirection[] axisDirectionsRight;

		[Token(Token = "0x1700004E")]
		private AxisDirection[] axisDirections
		{
			[Token(Token = "0x600034D")]
			[Address(RVA = "0xA9A464", Offset = "0xA9A464", VA = "0xA9A464")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0xA991B4", Offset = "0xA991B4", VA = "0xA991B4")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0xA991F8", Offset = "0xA991F8", VA = "0xA991F8")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0xA99238", Offset = "0xA99238", VA = "0xA99238", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0xA99778", Offset = "0xA99778", VA = "0xA99778", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0xA9A298", Offset = "0xA9A298", VA = "0xA9A298", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0xA9A340", Offset = "0xA9A340", VA = "0xA9A340")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0xA9A3C8", Offset = "0xA9A3C8", VA = "0xA9A3C8")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0xA9958C", Offset = "0xA9958C", VA = "0xA9958C")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0xA99834", Offset = "0xA99834", VA = "0xA99834")]
		private Vector3 GetModifiedBendNormal()
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x200006A")]
	public class IKSolverLookAt : IKSolver
	{
		[Serializable]
		[Token(Token = "0x200006B")]
		public class LookAtBone : Bone
		{
			[Token(Token = "0x400034A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			public Vector3 baseForwardOffsetEuler;

			[Token(Token = "0x17000055")]
			public Vector3 forward
			{
				[Token(Token = "0x600036A")]
				[Address(RVA = "0xA9C870", Offset = "0xA9C870", VA = "0xA9C870")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000366")]
			[Address(RVA = "0xA9C644", Offset = "0xA9C644", VA = "0xA9C644")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x6000367")]
			[Address(RVA = "0xA9C64C", Offset = "0xA9C64C", VA = "0xA9C64C")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x6000368")]
			[Address(RVA = "0xA9C67C", Offset = "0xA9C67C", VA = "0xA9C67C")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x6000369")]
			[Address(RVA = "0xA9C768", Offset = "0xA9C768", VA = "0xA9C768")]
			public void LookAt(Vector3 direction, float weight)
			{
			}
		}

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public LookAtBone[] spine;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public LookAtBone head;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public LookAtBone[] eyes;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float bodyWeight;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float headWeight;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float eyesWeight;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public float clampWeight;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float clampWeightHead;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float clampWeightEyes;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public int clampSmoothing;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public AnimationCurve spineWeightCurve;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 spineTargetOffset;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		protected Vector3[] spineForwards;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		protected Vector3[] headForwards;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		protected Vector3[] eyeForward;

		[Token(Token = "0x1700004F")]
		protected bool spineIsValid
		{
			[Token(Token = "0x600035A")]
			[Address(RVA = "0xA9AA74", Offset = "0xA9AA74", VA = "0xA9AA74")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000050")]
		protected bool spineIsEmpty
		{
			[Token(Token = "0x600035B")]
			[Address(RVA = "0xA9AC1C", Offset = "0xA9AC1C", VA = "0xA9AC1C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000051")]
		protected bool headIsValid
		{
			[Token(Token = "0x600035D")]
			[Address(RVA = "0xA9AB40", Offset = "0xA9AB40", VA = "0xA9AB40")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000052")]
		protected bool headIsEmpty
		{
			[Token(Token = "0x600035E")]
			[Address(RVA = "0xA9AC40", Offset = "0xA9AC40", VA = "0xA9AC40")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000053")]
		protected bool eyesIsValid
		{
			[Token(Token = "0x6000360")]
			[Address(RVA = "0xA9AB50", Offset = "0xA9AB50", VA = "0xA9AB50")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000054")]
		protected bool eyesIsEmpty
		{
			[Token(Token = "0x6000361")]
			[Address(RVA = "0xA9ACAC", Offset = "0xA9ACAC", VA = "0xA9ACAC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0xA9A61C", Offset = "0xA9A61C", VA = "0xA9A61C")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0xA9A68C", Offset = "0xA9A68C", VA = "0xA9A68C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0xA9A798", Offset = "0xA9A798", VA = "0xA9A798", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0xA9A8B8", Offset = "0xA9A8B8", VA = "0xA9A8B8", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0xA9ACD0", Offset = "0xA9ACD0", VA = "0xA9ACD0", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0xA9AF24", Offset = "0xA9AF24", VA = "0xA9AF24", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0xA9B084", Offset = "0xA9B084", VA = "0xA9B084")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0xA9B2D4", Offset = "0xA9B2D4", VA = "0xA9B2D4", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0xA9B5A4", Offset = "0xA9B5A4", VA = "0xA9B5A4", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0xA9B668", Offset = "0xA9B668", VA = "0xA9B668")]
		protected void SolveSpine()
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0xA9B88C", Offset = "0xA9B88C", VA = "0xA9B88C")]
		protected void SolveHead()
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0xA9BBDC", Offset = "0xA9BBDC", VA = "0xA9BBDC")]
		protected void SolveEyes()
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0xA9C0BC", Offset = "0xA9C0BC", VA = "0xA9C0BC")]
		protected Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0xA9B13C", Offset = "0xA9B13C", VA = "0xA9B13C")]
		protected void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0xA9C3D4", Offset = "0xA9C3D4", VA = "0xA9C3D4")]
		public IKSolverLookAt()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006C")]
	public class IKSolverTrigonometric : IKSolver
	{
		[Serializable]
		[Token(Token = "0x200006D")]
		public class TrigonometricBone : Bone
		{
			[Token(Token = "0x4000354")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion targetToLocalSpace;

			[Token(Token = "0x4000355")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 defaultLocalBendNormal;

			[Token(Token = "0x6000380")]
			[Address(RVA = "0xA9D574", Offset = "0xA9D574", VA = "0xA9D574")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x6000381")]
			[Address(RVA = "0xA9DE4C", Offset = "0xA9DE4C", VA = "0xA9DE4C")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000382")]
			[Address(RVA = "0xA9DC5C", Offset = "0xA9DC5C", VA = "0xA9DC5C")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000383")]
			[Address(RVA = "0xA9E034", Offset = "0xA9E034", VA = "0xA9E034")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float IKRotationWeight;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Quaternion IKRotation;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Vector3 bendNormal;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public TrigonometricBone bone1;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public TrigonometricBone bone2;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public TrigonometricBone bone3;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected Vector3 weightIKPosition;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		protected bool directHierarchy;

		[Token(Token = "0x600036B")]
		[Address(RVA = "0xA9C8A0", Offset = "0xA9C8A0", VA = "0xA9C8A0")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0xA9CA34", Offset = "0xA9CA34", VA = "0xA9CA34")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0xA9CBB4", Offset = "0xA9CBB4", VA = "0xA9CBB4")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0xA9CBC0", Offset = "0xA9CBC0", VA = "0xA9CBC0")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0xA9CBDC", Offset = "0xA9CBDC", VA = "0xA9CBDC")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0xA9CBE8", Offset = "0xA9CBE8", VA = "0xA9CBE8")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0xA9CBF0", Offset = "0xA9CBF0", VA = "0xA9CBF0", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0xA9CD00", Offset = "0xA9CD00", VA = "0xA9CD00", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0xA9CDF8", Offset = "0xA9CDF8", VA = "0xA9CDF8", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0xA9CE38", Offset = "0xA9CE38", VA = "0xA9CE38", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0xA9CE88", Offset = "0xA9CE88", VA = "0xA9CE88", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0xA9D25C", Offset = "0xA9D25C", VA = "0xA9D25C")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0xA9D2D8", Offset = "0xA9D2D8", VA = "0xA9D2D8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0xA9D484", Offset = "0xA9D484", VA = "0xA9D484")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0xA9D404", Offset = "0xA9D404", VA = "0xA9D404")]
		private void InitiateBones()
		{
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0xA9D664", Offset = "0xA9D664", VA = "0xA9D664", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0xA9DEDC", Offset = "0xA9DEDC", VA = "0xA9DEDC", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0xA9DEE0", Offset = "0xA9DEE0", VA = "0xA9DEE0", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0xA9DEE4", Offset = "0xA9DEE4", VA = "0xA9DEE4", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0xA9DC8C", Offset = "0xA9DC8C", VA = "0xA9DC8C")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0xA9DEE8", Offset = "0xA9DEE8", VA = "0xA9DEE8")]
		public IKSolverTrigonometric()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006E")]
	public class IKSolverVR : IKSolver
	{
		[Serializable]
		[Token(Token = "0x200006F")]
		public class Arm : BodyPart
		{
			[Serializable]
			[Token(Token = "0x2000070")]
			public enum ShoulderRotationMode
			{
				[Token(Token = "0x4000398")]
				YawPitch,
				[Token(Token = "0x4000399")]
				FromTo
			}

			[Token(Token = "0x400037A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Transform target;

			[Token(Token = "0x400037B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Transform bendGoal;

			[Token(Token = "0x400037C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float positionWeight;

			[Token(Token = "0x400037D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public float rotationWeight;

			[Token(Token = "0x400037E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x400037F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public float shoulderRotationWeight;

			[Token(Token = "0x4000380")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public float shoulderTwistWeight;

			[Token(Token = "0x4000381")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public float bendGoalWeight;

			[Token(Token = "0x4000382")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public float swivelOffset;

			[Token(Token = "0x4000383")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x4000384")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			public Vector3 palmToThumbAxis;

			[Token(Token = "0x4000385")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			public float armLengthMlp;

			[Token(Token = "0x4000386")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x4000387")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x4000388")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x4000389")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			public Vector3 bendDirection;

			[NonSerialized]
			[Token(Token = "0x400038A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			public Vector3 handPositionOffset;

			[Token(Token = "0x400038D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private bool hasShoulder;

			[Token(Token = "0x400038E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 chestForwardAxis;

			[Token(Token = "0x400038F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private Vector3 chestUpAxis;

			[Token(Token = "0x4000390")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			private Quaternion chestRotation;

			[Token(Token = "0x4000391")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			private Vector3 chestForward;

			[Token(Token = "0x4000392")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
			private Vector3 chestUp;

			[Token(Token = "0x4000393")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
			private Quaternion forearmRelToUpperArm;

			[Token(Token = "0x4000394")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
			private Vector3 upperArmBendAxis;

			[Token(Token = "0x4000395")]
			private const float yawOffsetAngle = 45f;

			[Token(Token = "0x4000396")]
			private const float pitchOffsetAngle = -30f;

			[Token(Token = "0x17000057")]
			public Vector3 position
			{
				[Token(Token = "0x600039F")]
				[Address(RVA = "0xAA6380", Offset = "0xAA6380", VA = "0xAA6380")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60003A0")]
				[Address(RVA = "0xAA638C", Offset = "0xAA638C", VA = "0xAA638C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000058")]
			public Quaternion rotation
			{
				[Token(Token = "0x60003A1")]
				[Address(RVA = "0xAA6398", Offset = "0xAA6398", VA = "0xAA6398")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60003A2")]
				[Address(RVA = "0xAA63A4", Offset = "0xAA63A4", VA = "0xAA63A4")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000059")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x60003A3")]
				[Address(RVA = "0xAA63B0", Offset = "0xAA63B0", VA = "0xAA63B0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700005A")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x60003A4")]
				[Address(RVA = "0xAA63D8", Offset = "0xAA63D8", VA = "0xAA63D8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700005B")]
			private VirtualBone forearm
			{
				[Token(Token = "0x60003A5")]
				[Address(RVA = "0xAA640C", Offset = "0xAA640C", VA = "0xAA640C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700005C")]
			private VirtualBone hand
			{
				[Token(Token = "0x60003A6")]
				[Address(RVA = "0xAA644C", Offset = "0xAA644C", VA = "0xAA644C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003A7")]
			[Address(RVA = "0xAA648C", Offset = "0xAA648C", VA = "0xAA648C", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60003A8")]
			[Address(RVA = "0xAA6D60", Offset = "0xAA6D60", VA = "0xAA6D60", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x60003A9")]
			[Address(RVA = "0xAA700C", Offset = "0xAA700C", VA = "0xAA700C", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x60003AA")]
			[Address(RVA = "0xAA7030", Offset = "0xAA7030", VA = "0xAA7030")]
			private void Stretching()
			{
			}

			[Token(Token = "0x60003AB")]
			[Address(RVA = "0xAA3F54", Offset = "0xAA3F54", VA = "0xAA3F54")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x60003AC")]
			[Address(RVA = "0xAA7FCC", Offset = "0xAA7FCC", VA = "0xAA7FCC", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x60003AD")]
			[Address(RVA = "0xAA8024", Offset = "0xAA8024", VA = "0xAA8024", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x60003AE")]
			[Address(RVA = "0xAA7380", Offset = "0xAA7380", VA = "0xAA7380")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x60003AF")]
			[Address(RVA = "0xAA7588", Offset = "0xAA7588", VA = "0xAA7588")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60003B0")]
			[Address(RVA = "0xAA5FF0", Offset = "0xAA5FF0", VA = "0xAA5FF0")]
			public Arm()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000071")]
		public abstract class BodyPart
		{
			[Token(Token = "0x400039C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public VirtualBone[] bones;

			[Token(Token = "0x400039D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			protected bool initiated;

			[Token(Token = "0x400039E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			protected Vector3 rootPosition;

			[Token(Token = "0x400039F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			protected Quaternion rootRotation;

			[Token(Token = "0x40003A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			protected int index;

			[Token(Token = "0x40003A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			protected int LOD;

			[Token(Token = "0x1700005D")]
			private float sqrMag
			{
				[Token(Token = "0x60003B6")]
				[Address(RVA = "0xAA82D4", Offset = "0xAA82D4", VA = "0xAA82D4")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x1700005E")]
			public float mag
			{
				[Token(Token = "0x60003B7")]
				[Address(RVA = "0xAA82DC", Offset = "0xAA82DC", VA = "0xAA82DC")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60003B8")]
				[Address(RVA = "0xAA82E4", Offset = "0xAA82E4", VA = "0xAA82E4")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x60003B1")]
			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index);

			[Token(Token = "0x60003B2")]
			public abstract void PreSolve();

			[Token(Token = "0x60003B3")]
			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);

			[Token(Token = "0x60003B4")]
			public abstract void ApplyOffsets();

			[Token(Token = "0x60003B5")]
			public abstract void ResetOffsets();

			[Token(Token = "0x60003B9")]
			[Address(RVA = "0xAA82EC", Offset = "0xAA82EC", VA = "0xAA82EC")]
			public void SetLOD(int LOD)
			{
			}

			[Token(Token = "0x60003BA")]
			[Address(RVA = "0xAA1E88", Offset = "0xAA1E88", VA = "0xAA1E88")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60003BB")]
			[Address(RVA = "0xAA8454", Offset = "0xAA8454", VA = "0xAA8454")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x60003BC")]
			[Address(RVA = "0xAA3C48", Offset = "0xAA3C48", VA = "0xAA3C48")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x60003BD")]
			[Address(RVA = "0xAA7E68", Offset = "0xAA7E68", VA = "0xAA7E68")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x60003BE")]
			[Address(RVA = "0xAA8230", Offset = "0xAA8230", VA = "0xAA8230")]
			protected BodyPart()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000072")]
		public class Footstep
		{
			[Token(Token = "0x40003A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float stepSpeed;

			[Token(Token = "0x40003A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 characterSpaceOffset;

			[Token(Token = "0x40003A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 position;

			[Token(Token = "0x40003A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion rotation;

			[Token(Token = "0x40003A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Quaternion stepToRootRot;

			[Token(Token = "0x40003A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public bool isSupportLeg;

			[Token(Token = "0x40003A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 stepFrom;

			[Token(Token = "0x40003AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 stepTo;

			[Token(Token = "0x40003AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion stepFromRot;

			[Token(Token = "0x40003AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			public Quaternion stepToRot;

			[Token(Token = "0x40003AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			private Quaternion footRelativeToRoot;

			[Token(Token = "0x40003AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			private float supportLegW;

			[Token(Token = "0x40003AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private float supportLegWV;

			[Token(Token = "0x1700005F")]
			public bool isStepping
			{
				[Token(Token = "0x60003BF")]
				[Address(RVA = "0xAA864C", Offset = "0xAA864C", VA = "0xAA864C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000060")]
			public float stepProgress
			{
				[Token(Token = "0x60003C0")]
				[Address(RVA = "0xAA8660", Offset = "0xAA8660", VA = "0xAA8660")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60003C1")]
				[Address(RVA = "0xAA8668", Offset = "0xAA8668", VA = "0xAA8668")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x60003C2")]
			[Address(RVA = "0xAA8670", Offset = "0xAA8670", VA = "0xAA8670")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x60003C3")]
			[Address(RVA = "0xAA8834", Offset = "0xAA8834", VA = "0xAA8834")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x60003C4")]
			[Address(RVA = "0xAA887C", Offset = "0xAA887C", VA = "0xAA887C")]
			public void StepTo(Vector3 p, Quaternion rootRotation, float stepThreshold)
			{
			}

			[Token(Token = "0x60003C5")]
			[Address(RVA = "0xAA8AA0", Offset = "0xAA8AA0", VA = "0xAA8AA0")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Token(Token = "0x60003C6")]
			[Address(RVA = "0xAA8CA8", Offset = "0xAA8CA8", VA = "0xAA8CA8")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Token(Token = "0x60003C7")]
			[Address(RVA = "0xAA8E8C", Offset = "0xAA8E8C", VA = "0xAA8E8C")]
			public void Update(InterpolationMode interpolation, UnityEvent onStep)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000073")]
		public class Leg : BodyPart
		{
			[Token(Token = "0x40003B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Transform target;

			[Token(Token = "0x40003B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Transform bendGoal;

			[Token(Token = "0x40003B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float positionWeight;

			[Token(Token = "0x40003B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public float rotationWeight;

			[Token(Token = "0x40003B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public float bendGoalWeight;

			[Token(Token = "0x40003B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public float swivelOffset;

			[Token(Token = "0x40003B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public float bendToTargetWeight;

			[Token(Token = "0x40003B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public float legLengthMlp;

			[Token(Token = "0x40003B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x40003B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x40003BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x40003BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			public Vector3 footPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40003BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			public Vector3 heelPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40003BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			public Quaternion footRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40003BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			public float currentMag;

			[Token(Token = "0x40003BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			public bool useAnimatedBendNormal;

			[Token(Token = "0x40003C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			private Vector3 footPosition;

			[Token(Token = "0x40003C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			private Quaternion footRotation;

			[Token(Token = "0x40003C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
			private Vector3 bendNormal;

			[Token(Token = "0x40003C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			private Quaternion calfRelToThigh;

			[Token(Token = "0x40003C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			private Quaternion thighRelToFoot;

			[Token(Token = "0x40003C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			private Vector3 bendNormalRelToPelvis;

			[Token(Token = "0x40003CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
			private Vector3 bendNormalRelToTarget;

			[Token(Token = "0x17000061")]
			public Vector3 position
			{
				[Token(Token = "0x60003C8")]
				[Address(RVA = "0xAA9000", Offset = "0xAA9000", VA = "0xAA9000")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60003C9")]
				[Address(RVA = "0xAA900C", Offset = "0xAA900C", VA = "0xAA900C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000062")]
			public Quaternion rotation
			{
				[Token(Token = "0x60003CA")]
				[Address(RVA = "0xAA9018", Offset = "0xAA9018", VA = "0xAA9018")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60003CB")]
				[Address(RVA = "0xAA9024", Offset = "0xAA9024", VA = "0xAA9024")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000063")]
			public bool hasToes
			{
				[Token(Token = "0x60003CC")]
				[Address(RVA = "0xAA9030", Offset = "0xAA9030", VA = "0xAA9030")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60003CD")]
				[Address(RVA = "0xAA9038", Offset = "0xAA9038", VA = "0xAA9038")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000064")]
			public VirtualBone thigh
			{
				[Token(Token = "0x60003CE")]
				[Address(RVA = "0xAA9044", Offset = "0xAA9044", VA = "0xAA9044")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000065")]
			private VirtualBone calf
			{
				[Token(Token = "0x60003CF")]
				[Address(RVA = "0xAA906C", Offset = "0xAA906C", VA = "0xAA906C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000066")]
			private VirtualBone foot
			{
				[Token(Token = "0x60003D0")]
				[Address(RVA = "0xAA9098", Offset = "0xAA9098", VA = "0xAA9098")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000067")]
			private VirtualBone toes
			{
				[Token(Token = "0x60003D1")]
				[Address(RVA = "0xAA90C4", Offset = "0xAA90C4", VA = "0xAA90C4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000068")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x60003D2")]
				[Address(RVA = "0xAA3B3C", Offset = "0xAA3B3C", VA = "0xAA3B3C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000069")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x60003D3")]
				[Address(RVA = "0xAA90F0", Offset = "0xAA90F0", VA = "0xAA90F0")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60003D4")]
				[Address(RVA = "0xAA90FC", Offset = "0xAA90FC", VA = "0xAA90FC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x60003D5")]
			[Address(RVA = "0xAA9108", Offset = "0xAA9108", VA = "0xAA9108", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60003D6")]
			[Address(RVA = "0xAA9678", Offset = "0xAA9678", VA = "0xAA9678", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x60003D7")]
			[Address(RVA = "0xAA9DE8", Offset = "0xAA9DE8", VA = "0xAA9DE8", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x60003D8")]
			[Address(RVA = "0xAA9D98", Offset = "0xAA9D98", VA = "0xAA9D98")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x60003D9")]
			[Address(RVA = "0xAA9B4C", Offset = "0xAA9B4C", VA = "0xAA9B4C")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x60003DA")]
			[Address(RVA = "0xAA3D6C", Offset = "0xAA3D6C", VA = "0xAA3D6C")]
			public void Solve(bool stretch)
			{
			}

			[Token(Token = "0x60003DB")]
			[Address(RVA = "0xAAA6A0", Offset = "0xAAA6A0", VA = "0xAAA6A0")]
			private void FixTwistRotations()
			{
			}

			[Token(Token = "0x60003DC")]
			[Address(RVA = "0xAAA2C4", Offset = "0xAAA2C4", VA = "0xAAA2C4")]
			private void Stretching()
			{
			}

			[Token(Token = "0x60003DD")]
			[Address(RVA = "0xAAAAF8", Offset = "0xAAAAF8", VA = "0xAAAAF8", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x60003DE")]
			[Address(RVA = "0xAAAD00", Offset = "0xAAAD00", VA = "0xAAAD00", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x60003DF")]
			[Address(RVA = "0xAA6188", Offset = "0xAA6188", VA = "0xAA6188")]
			public Leg()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000074")]
		public class Locomotion
		{
			[Token(Token = "0x40003CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float weight;

			[Token(Token = "0x40003CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float footDistance;

			[Token(Token = "0x40003CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float stepThreshold;

			[Token(Token = "0x40003CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float angleThreshold;

			[Token(Token = "0x40003CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float comAngleMlp;

			[Token(Token = "0x40003D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float maxVelocity;

			[Token(Token = "0x40003D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float velocityFactor;

			[Token(Token = "0x40003D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float maxLegStretch;

			[Token(Token = "0x40003D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float rootSpeed;

			[Token(Token = "0x40003D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float stepSpeed;

			[Token(Token = "0x40003D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public AnimationCurve stepHeight;

			[Token(Token = "0x40003D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public AnimationCurve heelHeight;

			[Token(Token = "0x40003D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x40003D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x40003D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x40003DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 offset;

			[Token(Token = "0x40003DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public bool blockingEnabled;

			[Token(Token = "0x40003DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public LayerMask blockingLayers;

			[Token(Token = "0x40003DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public float raycastRadius;

			[Token(Token = "0x40003DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public float raycastHeight;

			[Token(Token = "0x40003DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public UnityEvent onLeftFootstep;

			[Token(Token = "0x40003E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public UnityEvent onRightFootstep;

			[Token(Token = "0x40003E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private Footstep[] footsteps;

			[Token(Token = "0x40003E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private Vector3 lastComPosition;

			[Token(Token = "0x40003E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private Vector3 comVelocity;

			[Token(Token = "0x40003E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private int leftFootIndex;

			[Token(Token = "0x40003E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			private int rightFootIndex;

			[Token(Token = "0x1700006A")]
			public Vector3 centerOfMass
			{
				[Token(Token = "0x60003E0")]
				[Address(RVA = "0xAAADE0", Offset = "0xAAADE0", VA = "0xAAADE0")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60003E1")]
				[Address(RVA = "0xAAADEC", Offset = "0xAAADEC", VA = "0xAAADEC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x60003E2")]
			[Address(RVA = "0xAA1F44", Offset = "0xAA1F44", VA = "0xAA1F44")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes)
			{
			}

			[Token(Token = "0x60003E3")]
			[Address(RVA = "0xAA05BC", Offset = "0xAA05BC", VA = "0xAA05BC")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x60003E4")]
			[Address(RVA = "0xA9F0CC", Offset = "0xA9F0CC", VA = "0xA9F0CC")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x60003E5")]
			[Address(RVA = "0xA9F014", Offset = "0xA9F014", VA = "0xA9F014")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x60003E6")]
			[Address(RVA = "0xAA2794", Offset = "0xAA2794", VA = "0xAA2794")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset)
			{
			}

			[Token(Token = "0x60003E7")]
			[Address(RVA = "0xAAAE2C", Offset = "0xAAAE2C", VA = "0xAAAE2C")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x60003E8")]
			[Address(RVA = "0xAAAFE0", Offset = "0xAAAFE0", VA = "0xAAAFE0")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x60003E9")]
			[Address(RVA = "0xAAB04C", Offset = "0xAAB04C", VA = "0xAAB04C")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x60003EA")]
			[Address(RVA = "0xAA6270", Offset = "0xAA6270", VA = "0xAA6270")]
			public Locomotion()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000075")]
		public class Spine : BodyPart
		{
			[Token(Token = "0x40003E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Transform headTarget;

			[Token(Token = "0x40003E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Transform pelvisTarget;

			[Token(Token = "0x40003E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float positionWeight;

			[Token(Token = "0x40003EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public float rotationWeight;

			[Token(Token = "0x40003EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public float pelvisPositionWeight;

			[Token(Token = "0x40003EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public float pelvisRotationWeight;

			[Token(Token = "0x40003ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Transform chestGoal;

			[Token(Token = "0x40003EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public float chestGoalWeight;

			[Token(Token = "0x40003EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			public float minHeadHeight;

			[Token(Token = "0x40003F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public float bodyPosStiffness;

			[Token(Token = "0x40003F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			public float bodyRotStiffness;

			[Token(Token = "0x40003F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[FormerlySerializedAs("chestRotationWeight")]
			public float neckStiffness;

			[Token(Token = "0x40003F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			public float rotateChestByHands;

			[Token(Token = "0x40003F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			public float chestClampWeight;

			[Token(Token = "0x40003F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			public float headClampWeight;

			[Token(Token = "0x40003F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public float moveBodyBackWhenCrouching;

			[Token(Token = "0x40003F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			public float maintainPelvisPosition;

			[Token(Token = "0x40003F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			public float maxRootAngle;

			[Token(Token = "0x40003F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			public float rootHeadingOffset;

			[NonSerialized]
			[Token(Token = "0x40003FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			public Vector3 IKPositionHead;

			[NonSerialized]
			[Token(Token = "0x40003FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			public Quaternion IKRotationHead;

			[NonSerialized]
			[Token(Token = "0x40003FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			public Vector3 IKPositionPelvis;

			[NonSerialized]
			[Token(Token = "0x40003FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			public Quaternion IKRotationPelvis;

			[NonSerialized]
			[Token(Token = "0x40003FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			public Vector3 goalPositionChest;

			[NonSerialized]
			[Token(Token = "0x40003FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			public Vector3 pelvisPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000400")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			public Vector3 chestPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000401")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			public Vector3 headPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000402")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			public Quaternion pelvisRotationOffset;

			[NonSerialized]
			[Token(Token = "0x4000403")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			public Quaternion chestRotationOffset;

			[NonSerialized]
			[Token(Token = "0x4000404")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			public Quaternion headRotationOffset;

			[NonSerialized]
			[Token(Token = "0x4000405")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			public Vector3 faceDirection;

			[NonSerialized]
			[Token(Token = "0x4000406")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
			public Vector3 locomotionHeadPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000407")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
			public Vector3 headPosition;

			[Token(Token = "0x400040A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
			private Quaternion headRotation;

			[Token(Token = "0x400040B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
			private Quaternion pelvisRotation;

			[Token(Token = "0x400040C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
			private Quaternion anchorRelativeToPelvis;

			[Token(Token = "0x400040D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
			private Quaternion pelvisRelativeRotation;

			[Token(Token = "0x400040E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
			private Quaternion chestRelativeRotation;

			[Token(Token = "0x400040F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
			private Vector3 headDeltaPosition;

			[Token(Token = "0x4000410")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
			private Quaternion pelvisDeltaRotation;

			[Token(Token = "0x4000411")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
			private Quaternion chestTargetRotation;

			[Token(Token = "0x4000412")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
			private int pelvisIndex;

			[Token(Token = "0x4000413")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1FC")]
			private int spineIndex;

			[Token(Token = "0x4000414")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
			private int chestIndex;

			[Token(Token = "0x4000415")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
			private int neckIndex;

			[Token(Token = "0x4000416")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
			private int headIndex;

			[Token(Token = "0x4000417")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
			private float length;

			[Token(Token = "0x4000418")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
			private bool hasChest;

			[Token(Token = "0x4000419")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x211")]
			private bool hasNeck;

			[Token(Token = "0x400041A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x212")]
			private bool hasLegs;

			[Token(Token = "0x400041B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x214")]
			private float headHeight;

			[Token(Token = "0x400041C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
			private float sizeMlp;

			[Token(Token = "0x400041D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x21C")]
			private Vector3 chestForward;

			[Token(Token = "0x1700006B")]
			public VirtualBone pelvis
			{
				[Token(Token = "0x60003EB")]
				[Address(RVA = "0xAA07A0", Offset = "0xAA07A0", VA = "0xAA07A0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700006C")]
			public VirtualBone chest
			{
				[Token(Token = "0x60003EC")]
				[Address(RVA = "0xAA3F0C", Offset = "0xAA3F0C", VA = "0xAA3F0C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700006D")]
			public VirtualBone head
			{
				[Token(Token = "0x60003ED")]
				[Address(RVA = "0xAAADF8", Offset = "0xAAADF8", VA = "0xAAADF8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700006E")]
			public Quaternion anchorRotation
			{
				[Token(Token = "0x60003EE")]
				[Address(RVA = "0xAAB1FC", Offset = "0xAAB1FC", VA = "0xAAB1FC")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60003EF")]
				[Address(RVA = "0xAAB210", Offset = "0xAAB210", VA = "0xAAB210")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700006F")]
			public Quaternion anchorRelativeToHead
			{
				[Token(Token = "0x60003F0")]
				[Address(RVA = "0xAAB224", Offset = "0xAAB224", VA = "0xAAB224")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60003F1")]
				[Address(RVA = "0xAAB238", Offset = "0xAAB238", VA = "0xAAB238")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x60003F2")]
			[Address(RVA = "0xAAB24C", Offset = "0xAAB24C", VA = "0xAAB24C", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60003F3")]
			[Address(RVA = "0xAABEEC", Offset = "0xAABEEC", VA = "0xAABEEC", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x60003F4")]
			[Address(RVA = "0xAAC0D4", Offset = "0xAAC0D4", VA = "0xAAC0D4", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x60003F5")]
			[Address(RVA = "0xAAC868", Offset = "0xAAC868", VA = "0xAAC868")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x60003F6")]
			[Address(RVA = "0xAA2258", Offset = "0xAA2258", VA = "0xAA2258")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms)
			{
			}

			[Token(Token = "0x60003F7")]
			[Address(RVA = "0xAAD2B0", Offset = "0xAAD2B0", VA = "0xAAD2B0")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp, float weight)
			{
			}

			[Token(Token = "0x60003F8")]
			[Address(RVA = "0xAAD97C", Offset = "0xAAD97C", VA = "0xAAD97C")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x60003F9")]
			[Address(RVA = "0xAADFD8", Offset = "0xAADFD8", VA = "0xAADFD8", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x60003FA")]
			[Address(RVA = "0xAAE1A8", Offset = "0xAAE1A8", VA = "0xAAE1A8", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x60003FB")]
			[Address(RVA = "0xAACAAC", Offset = "0xAACAAC", VA = "0xAACAAC")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x60003FC")]
			[Address(RVA = "0xAA3B70", Offset = "0xAA3B70", VA = "0xAA3B70")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x60003FD")]
			[Address(RVA = "0xAACEA4", Offset = "0xAACEA4", VA = "0xAACEA4")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation)
			{
			}

			[Token(Token = "0x60003FE")]
			[Address(RVA = "0xAAE27C", Offset = "0xAAE27C", VA = "0xAAE27C")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60003FF")]
			[Address(RVA = "0xAAD780", Offset = "0xAAD780", VA = "0xAAD780")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000400")]
			[Address(RVA = "0xAAD510", Offset = "0xAAD510", VA = "0xAAD510")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000401")]
			[Address(RVA = "0xAA5ED8", Offset = "0xAA5ED8", VA = "0xAA5ED8")]
			public Spine()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000076")]
		public enum PositionOffset
		{
			[Token(Token = "0x400041F")]
			Pelvis,
			[Token(Token = "0x4000420")]
			Chest,
			[Token(Token = "0x4000421")]
			Head,
			[Token(Token = "0x4000422")]
			LeftHand,
			[Token(Token = "0x4000423")]
			RightHand,
			[Token(Token = "0x4000424")]
			LeftFoot,
			[Token(Token = "0x4000425")]
			RightFoot,
			[Token(Token = "0x4000426")]
			LeftHeel,
			[Token(Token = "0x4000427")]
			RightHeel
		}

		[Serializable]
		[Token(Token = "0x2000077")]
		public enum RotationOffset
		{
			[Token(Token = "0x4000429")]
			Pelvis,
			[Token(Token = "0x400042A")]
			Chest,
			[Token(Token = "0x400042B")]
			Head
		}

		[Serializable]
		[Token(Token = "0x2000078")]
		public class VirtualBone
		{
			[Token(Token = "0x400042C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 readPosition;

			[Token(Token = "0x400042D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Quaternion readRotation;

			[Token(Token = "0x400042E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 solverPosition;

			[Token(Token = "0x400042F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Quaternion solverRotation;

			[Token(Token = "0x4000430")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float length;

			[Token(Token = "0x4000431")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float sqrMag;

			[Token(Token = "0x4000432")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Vector3 axis;

			[Token(Token = "0x6000402")]
			[Address(RVA = "0xAA1DF8", Offset = "0xAA1DF8", VA = "0xAA1DF8")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000403")]
			[Address(RVA = "0xAA1E68", Offset = "0xAA1E68", VA = "0xAA1E68")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000404")]
			[Address(RVA = "0xAAE518", Offset = "0xAAE518", VA = "0xAAE518")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000405")]
			[Address(RVA = "0xAA82F4", Offset = "0xAA82F4", VA = "0xAA82F4")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x6000406")]
			[Address(RVA = "0xAA84DC", Offset = "0xAA84DC", VA = "0xAA84DC")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000407")]
			[Address(RVA = "0xAA7400", Offset = "0xAA7400", VA = "0xAA7400")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000408")]
			[Address(RVA = "0xAA7A84", Offset = "0xAA7A84", VA = "0xAA7A84")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x6000409")]
			[Address(RVA = "0xAAE718", Offset = "0xAAE718", VA = "0xAAE718")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600040A")]
			[Address(RVA = "0xAADC0C", Offset = "0xAADC0C", VA = "0xAADC0C")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x600040B")]
			[Address(RVA = "0xAAE870", Offset = "0xAAE870", VA = "0xAAE870")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] solverTransforms;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool hasChest;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool hasNeck;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool hasShoulders;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool hasToes;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool hasLegs;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] readPositions;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] readRotations;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3[] solvedPositions;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Quaternion[] solvedRotations;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 rootV;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 rootVelocity;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 bodyOffset;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int supportLegIndex;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int lastLOD;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public int LOD;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public bool plantFeet;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Spine spine;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public Arm leftArm;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public Arm rightArm;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public Leg leftLeg;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public Leg rightLeg;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public Locomotion locomotion;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Leg[] legs;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Arm[] arms;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Vector3 headPosition;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private Vector3 headDeltaPosition;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Vector3 raycastOriginPelvis;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private Vector3 lastOffset;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Vector3 debugPos1;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		private Vector3 debugPos2;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private Vector3 debugPos3;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private Vector3 debugPos4;

		[Token(Token = "0x17000056")]
		public VirtualBone rootBone
		{
			[Token(Token = "0x600039A")]
			[Address(RVA = "0xAA5BEC", Offset = "0xAA5BEC", VA = "0xAA5BEC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600039B")]
			[Address(RVA = "0xAA5BF4", Offset = "0xAA5BF4", VA = "0xAA5BF4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0xA9E03C", Offset = "0xA9E03C", VA = "0xA9E03C")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0xA9E4A8", Offset = "0xA9E4A8", VA = "0xA9E4A8")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0xA9E33C", Offset = "0xA9E33C", VA = "0xA9E33C")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0xA9ECD8", Offset = "0xA9ECD8", VA = "0xA9ECD8")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0xA9EE1C", Offset = "0xA9EE1C", VA = "0xA9EE1C")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0xA9EF40", Offset = "0xA9EF40", VA = "0xA9EF40")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0xA9F494", Offset = "0xA9F494", VA = "0xA9F494", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0xA9F5E8", Offset = "0xA9F5E8", VA = "0xA9F5E8", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0xA9F7D4", Offset = "0xA9F7D4", VA = "0xA9F7D4", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0xA9F844", Offset = "0xA9F844", VA = "0xA9F844", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0xA9F8B4", Offset = "0xA9F8B4", VA = "0xA9F8B4", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0xA9E798", Offset = "0xA9E798", VA = "0xA9E798")]
		private Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0xA9E87C", Offset = "0xA9E87C", VA = "0xA9E87C")]
		private Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0xA9EBC4", Offset = "0xA9EBC4", VA = "0xA9EBC4")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0xA9FABC", Offset = "0xA9FABC", VA = "0xA9FABC")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0xA9FC0C", Offset = "0xA9FC0C", VA = "0xA9FC0C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0xAA01B8", Offset = "0xAA01B8", VA = "0xAA01B8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0xAA1930", Offset = "0xAA1930", VA = "0xAA1930")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0xA9FC48", Offset = "0xA9FC48", VA = "0xA9FC48")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs)
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0xAA07D4", Offset = "0xAA07D4", VA = "0xAA07D4")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0xAA1D84", Offset = "0xAA1D84", VA = "0xAA1D84")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0xAA1DC0", Offset = "0xAA1DC0", VA = "0xAA1DC0")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0xAA17F4", Offset = "0xAA17F4", VA = "0xAA17F4")]
		private void Write()
		{
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0xAA5520", Offset = "0xAA5520", VA = "0xAA5520")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0xAA5BFC", Offset = "0xAA5BFC", VA = "0xAA5BFC")]
		public IKSolverVR()
		{
		}
	}
	[Token(Token = "0x2000079")]
	public class TwistRelaxer : MonoBehaviour
	{
		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IK ik;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform parent;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform child;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float weight;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float parentChildCrossfade;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float twistAngleOffset;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 twistAxis;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 axis;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 axisRelativeToParentDefault;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 axisRelativeToChildDefault;

		[Token(Token = "0x600040C")]
		[Address(RVA = "0xAAF984", Offset = "0xAAF984", VA = "0xAAF984")]
		public void Relax()
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0xAAFDC8", Offset = "0xAAFDC8", VA = "0xAAFDC8")]
		private void Start()
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0xAB01B8", Offset = "0xAB01B8", VA = "0xAB01B8")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0xAB0230", Offset = "0xAB0230", VA = "0xAB0230")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0xAB02A8", Offset = "0xAB02A8", VA = "0xAB02A8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0xAB03E0", Offset = "0xAB03E0", VA = "0xAB03E0")]
		public TwistRelaxer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007A")]
	public class InteractionEffector
	{
		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Poser poser;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IKEffector effector;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float timer;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float length;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float weight;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float fadeInSpeed;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float defaultPositionWeight;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float defaultRotationWeight;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float defaultPull;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float defaultReach;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float defaultPush;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float defaultPushParent;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float defaultBendGoalWeight;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float resetTimer;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool positionWeightUsed;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool rotationWeightUsed;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool pullUsed;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool reachUsed;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool pushUsed;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
		private bool pushParentUsed;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x66")]
		private bool bendGoalWeightUsed;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x67")]
		private bool pickedUp;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool defaults;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool pickUpOnPostFBBIK;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 pausePositionRelative;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Quaternion pauseRotationRelative;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private InteractionTarget interactionTarget;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Transform target;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private List<bool> triggered;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool started;

		[Token(Token = "0x17000070")]
		public FullBodyBipedEffector effectorType
		{
			[Token(Token = "0x6000412")]
			[Address(RVA = "0xAB0480", Offset = "0xAB0480", VA = "0xAB0480")]
			[CompilerGenerated]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x6000413")]
			[Address(RVA = "0xAB0488", Offset = "0xAB0488", VA = "0xAB0488")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000071")]
		public bool isPaused
		{
			[Token(Token = "0x6000414")]
			[Address(RVA = "0xAB0490", Offset = "0xAB0490", VA = "0xAB0490")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000415")]
			[Address(RVA = "0xAB0498", Offset = "0xAB0498", VA = "0xAB0498")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000072")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x6000416")]
			[Address(RVA = "0xAB04A4", Offset = "0xAB04A4", VA = "0xAB04A4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000417")]
			[Address(RVA = "0xAB04AC", Offset = "0xAB04AC", VA = "0xAB04AC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000073")]
		public bool inInteraction
		{
			[Token(Token = "0x6000418")]
			[Address(RVA = "0xAB04B4", Offset = "0xAB04B4", VA = "0xAB04B4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000074")]
		public float progress
		{
			[Token(Token = "0x6000421")]
			[Address(RVA = "0xAB2AE8", Offset = "0xAB2AE8", VA = "0xAB2AE8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0xAB0514", Offset = "0xAB0514", VA = "0xAB0514")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0xAB05B0", Offset = "0xAB05B0", VA = "0xAB05B0")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0xAB0670", Offset = "0xAB0670", VA = "0xAB0670")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0xAB07DC", Offset = "0xAB07DC", VA = "0xAB07DC")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0xAB0BB8", Offset = "0xAB0BB8", VA = "0xAB0BB8")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0xAB0CD8", Offset = "0xAB0CD8", VA = "0xAB0CD8")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0xAB0D2C", Offset = "0xAB0D2C", VA = "0xAB0D2C")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0xAB188C", Offset = "0xAB188C", VA = "0xAB188C")]
		public void Update(Transform root, float speed)
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0xAB2340", Offset = "0xAB2340", VA = "0xAB2340")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0xAB2560", Offset = "0xAB2560", VA = "0xAB2560")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0xAB2984", Offset = "0xAB2984", VA = "0xAB2984")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0xAB2CE8", Offset = "0xAB2CE8", VA = "0xAB2CE8")]
		public void OnPostFBBIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007B")]
	public class InteractionLookAt
	{
		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LookAtIK ik;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float lerpSpeed;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float weightSpeed;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool isPaused;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform lookAtTarget;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float stopLookTime;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float weight;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool firstFBBIKSolve;

		[Token(Token = "0x6000426")]
		[Address(RVA = "0xAB2F24", Offset = "0xAB2F24", VA = "0xAB2F24")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0xAB3040", Offset = "0xAB3040", VA = "0xAB3040")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0xAB30D8", Offset = "0xAB30D8", VA = "0xAB30D8")]
		public void Update()
		{
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0xAB32E0", Offset = "0xAB32E0", VA = "0xAB32E0")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0xAB3388", Offset = "0xAB3388", VA = "0xAB3388")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0xAB3434", Offset = "0xAB3434", VA = "0xAB3434")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x200007C")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200007D")]
		public class InteractionEvent
		{
			[Token(Token = "0x4000472")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float time;

			[Token(Token = "0x4000473")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public bool pause;

			[Token(Token = "0x4000474")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			public bool pickUp;

			[Token(Token = "0x4000475")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x4000476")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Message[] messages;

			[Token(Token = "0x4000477")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public UnityEvent unityEvent;

			[Token(Token = "0x6000448")]
			[Address(RVA = "0xAB2B18", Offset = "0xAB2B18", VA = "0xAB2B18")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x6000449")]
			[Address(RVA = "0xAB43D8", Offset = "0xAB43D8", VA = "0xAB43D8")]
			public InteractionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200007E")]
		public class Message
		{
			[Token(Token = "0x4000478")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string function;

			[Token(Token = "0x4000479")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GameObject recipient;

			[Token(Token = "0x400047A")]
			private const string empty = "";

			[Token(Token = "0x600044A")]
			[Address(RVA = "0xAB42E0", Offset = "0xAB42E0", VA = "0xAB42E0")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x600044B")]
			[Address(RVA = "0xAB43E0", Offset = "0xAB43E0", VA = "0xAB43E0")]
			public Message()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200007F")]
		public class AnimatorEvent
		{
			[Token(Token = "0x400047B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Animator animator;

			[Token(Token = "0x400047C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Animation animation;

			[Token(Token = "0x400047D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string animationState;

			[Token(Token = "0x400047E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float crossfadeTime;

			[Token(Token = "0x400047F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public int layer;

			[Token(Token = "0x4000480")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool resetNormalizedTime;

			[Token(Token = "0x4000481")]
			private const string empty = "";

			[Token(Token = "0x600044C")]
			[Address(RVA = "0xAB4204", Offset = "0xAB4204", VA = "0xAB4204")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x600044D")]
			[Address(RVA = "0xAB43E8", Offset = "0xAB43E8", VA = "0xAB43E8")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x600044E")]
			[Address(RVA = "0xAB4498", Offset = "0xAB4498", VA = "0xAB4498")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x600044F")]
			[Address(RVA = "0xAB4570", Offset = "0xAB4570", VA = "0xAB4570")]
			public AnimatorEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000080")]
		public class WeightCurve
		{
			[Serializable]
			[Token(Token = "0x2000081")]
			public enum Type
			{
				[Token(Token = "0x4000485")]
				PositionWeight,
				[Token(Token = "0x4000486")]
				RotationWeight,
				[Token(Token = "0x4000487")]
				PositionOffsetX,
				[Token(Token = "0x4000488")]
				PositionOffsetY,
				[Token(Token = "0x4000489")]
				PositionOffsetZ,
				[Token(Token = "0x400048A")]
				Pull,
				[Token(Token = "0x400048B")]
				Reach,
				[Token(Token = "0x400048C")]
				RotateBoneWeight,
				[Token(Token = "0x400048D")]
				Push,
				[Token(Token = "0x400048E")]
				PushParent,
				[Token(Token = "0x400048F")]
				PoserWeight,
				[Token(Token = "0x4000490")]
				BendGoalWeight
			}

			[Token(Token = "0x4000482")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Type type;

			[Token(Token = "0x4000483")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public AnimationCurve curve;

			[Token(Token = "0x6000450")]
			[Address(RVA = "0xAB3B08", Offset = "0xAB3B08", VA = "0xAB3B08")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x6000451")]
			[Address(RVA = "0xAB4584", Offset = "0xAB4584", VA = "0xAB4584")]
			public WeightCurve()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000082")]
		public class Multiplier
		{
			[Token(Token = "0x4000491")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public WeightCurve.Type curve;

			[Token(Token = "0x4000492")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float multiplier;

			[Token(Token = "0x4000493")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public WeightCurve.Type result;

			[Token(Token = "0x6000452")]
			[Address(RVA = "0xAB4110", Offset = "0xAB4110", VA = "0xAB4110")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x6000453")]
			[Address(RVA = "0xAB458C", Offset = "0xAB458C", VA = "0xAB458C")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform positionOffsetSpace;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public WeightCurve[] weightCurves;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Multiplier[] multipliers;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionEvent[] events;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InteractionTarget[] targets;

		[Token(Token = "0x17000075")]
		public float length
		{
			[Token(Token = "0x6000434")]
			[Address(RVA = "0xAB3668", Offset = "0xAB3668", VA = "0xAB3668")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000435")]
			[Address(RVA = "0xAB3670", Offset = "0xAB3670", VA = "0xAB3670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000076")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x6000436")]
			[Address(RVA = "0xAB3678", Offset = "0xAB3678", VA = "0xAB3678")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000437")]
			[Address(RVA = "0xAB3680", Offset = "0xAB3680", VA = "0xAB3680")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000077")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x6000439")]
			[Address(RVA = "0xAB3840", Offset = "0xAB3840", VA = "0xAB3840")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000078")]
		public Transform targetsRoot
		{
			[Token(Token = "0x6000441")]
			[Address(RVA = "0xAB2BDC", Offset = "0xAB2BDC", VA = "0xAB2BDC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0xAB3448", Offset = "0xAB3448", VA = "0xAB3448")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0xAB348C", Offset = "0xAB348C", VA = "0xAB348C")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0xAB34D0", Offset = "0xAB34D0", VA = "0xAB34D0")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0xAB3514", Offset = "0xAB3514", VA = "0xAB3514")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0xAB3558", Offset = "0xAB3558", VA = "0xAB3558")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0xAB359C", Offset = "0xAB359C", VA = "0xAB359C")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0xAB35E0", Offset = "0xAB35E0", VA = "0xAB35E0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0xAB3624", Offset = "0xAB3624", VA = "0xAB3624")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0xAB3688", Offset = "0xAB3688", VA = "0xAB3688")]
		public void Initiate()
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0xAB38C0", Offset = "0xAB38C0", VA = "0xAB38C0")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0xAB134C", Offset = "0xAB134C", VA = "0xAB134C")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0xAB3A38", Offset = "0xAB3A38", VA = "0xAB3A38")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0xAB1208", Offset = "0xAB1208", VA = "0xAB1208")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0xAB1344", Offset = "0xAB1344", VA = "0xAB1344")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0xAB1F38", Offset = "0xAB1F38", VA = "0xAB1F38")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0xAB2778", Offset = "0xAB2778", VA = "0xAB2778")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0xAB4140", Offset = "0xAB4140", VA = "0xAB4140")]
		private void Start()
		{
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0xAB3B24", Offset = "0xAB3B24", VA = "0xAB3B24")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0xAB3A40", Offset = "0xAB3A40", VA = "0xAB3A40")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0xAB40B4", Offset = "0xAB40B4", VA = "0xAB40B4")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0xAB4144", Offset = "0xAB4144", VA = "0xAB4144")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0xAB41A0", Offset = "0xAB41A0", VA = "0xAB41A0")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x2000083")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x2000084")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x2000085")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string targetTag;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float fadeInTime;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float speed;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[FormerlySerializedAs("collider")]
		public Collider characterCollider;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[FormerlySerializedAs("camera")]
		public Transform FPSCamera;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float camRaycastDistance;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<InteractionTrigger> inContact;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<int> bestRangeIndexes;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public InteractionDelegate OnInteractionStart;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public InteractionDelegate OnInteractionPause;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public InteractionDelegate OnInteractionPickUp;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public InteractionDelegate OnInteractionResume;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public InteractionDelegate OnInteractionStop;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public InteractionEventDelegate OnInteractionEvent;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public RaycastHit raycastHit;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public InteractionLookAt lookAt;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private InteractionEffector[] interactionEffectors;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool initiated;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Collider lastCollider;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Collider c;

		[Token(Token = "0x17000079")]
		public bool inInteraction
		{
			[Token(Token = "0x600045C")]
			[Address(RVA = "0xAB47BC", Offset = "0xAB47BC", VA = "0xAB47BC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700007A")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x6000476")]
			[Address(RVA = "0xAB6264", Offset = "0xAB6264", VA = "0xAB6264")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000477")]
			[Address(RVA = "0xAB626C", Offset = "0xAB626C", VA = "0xAB626C")]
			set
			{
			}
		}

		[Token(Token = "0x1700007B")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x6000478")]
			[Address(RVA = "0xAB6274", Offset = "0xAB6274", VA = "0xAB6274")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000479")]
			[Address(RVA = "0xAB627C", Offset = "0xAB627C", VA = "0xAB627C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0xAB459C", Offset = "0xAB459C", VA = "0xAB459C")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0xAB45E0", Offset = "0xAB45E0", VA = "0xAB45E0")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0xAB4624", Offset = "0xAB4624", VA = "0xAB4624")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0xAB4668", Offset = "0xAB4668", VA = "0xAB4668")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0xAB46AC", Offset = "0xAB46AC", VA = "0xAB46AC")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0xAB46F0", Offset = "0xAB46F0", VA = "0xAB46F0")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0xAB4734", Offset = "0xAB4734", VA = "0xAB4734")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0xAB4778", Offset = "0xAB4778", VA = "0xAB4778")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0xAB4934", Offset = "0xAB4934", VA = "0xAB4934")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0xAB49EC", Offset = "0xAB49EC", VA = "0xAB49EC")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0xAB4AA4", Offset = "0xAB4AA4", VA = "0xAB4AA4")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0xAB4B3C", Offset = "0xAB4B3C", VA = "0xAB4B3C")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0xAB4C20", Offset = "0xAB4C20", VA = "0xAB4C20")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0xAB4D18", Offset = "0xAB4D18", VA = "0xAB4D18")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0xAB4D9C", Offset = "0xAB4D9C", VA = "0xAB4D9C")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0xAB4E20", Offset = "0xAB4E20", VA = "0xAB4E20")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0xAB4EA4", Offset = "0xAB4EA4", VA = "0xAB4EA4")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0xAB4F0C", Offset = "0xAB4F0C", VA = "0xAB4F0C")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0xAB4F74", Offset = "0xAB4F74", VA = "0xAB4F74")]
		public void StopAll()
		{
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0xAB4FD0", Offset = "0xAB4FD0", VA = "0xAB4FD0")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0xAB5050", Offset = "0xAB5050", VA = "0xAB5050")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0xAB50F8", Offset = "0xAB50F8", VA = "0xAB50F8")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0xAB51C8", Offset = "0xAB51C8", VA = "0xAB51C8")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0xAB5458", Offset = "0xAB5458", VA = "0xAB5458")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0xAB562C", Offset = "0xAB562C", VA = "0xAB562C")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0xAB589C", Offset = "0xAB589C", VA = "0xAB589C")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0xAB5B28", Offset = "0xAB5B28", VA = "0xAB5B28")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0xAB5B60", Offset = "0xAB5B60", VA = "0xAB5B60")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0xAB5BC0", Offset = "0xAB5BC0", VA = "0xAB5BC0")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0xAB5CEC", Offset = "0xAB5CEC", VA = "0xAB5CEC")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0xAB5ED0", Offset = "0xAB5ED0", VA = "0xAB5ED0")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0xAB6144", Offset = "0xAB6144", VA = "0xAB6144")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0xAB5984", Offset = "0xAB5984", VA = "0xAB5984")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0xAB6284", Offset = "0xAB6284", VA = "0xAB6284")]
		public void Start()
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0xAB6BA8", Offset = "0xAB6BA8", VA = "0xAB6BA8")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0xAB6BC8", Offset = "0xAB6BC8", VA = "0xAB6BC8")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0xAB6BE4", Offset = "0xAB6BE4", VA = "0xAB6BE4")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0xAB6C00", Offset = "0xAB6C00", VA = "0xAB6C00")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0xAB6C54", Offset = "0xAB6C54", VA = "0xAB6C54")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0xAB6DD8", Offset = "0xAB6DD8", VA = "0xAB6DD8")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0xAB6ED4", Offset = "0xAB6ED4", VA = "0xAB6ED4")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0xAB7230", Offset = "0xAB7230", VA = "0xAB7230")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0xAB7348", Offset = "0xAB7348", VA = "0xAB7348")]
		public void Update()
		{
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0xAB7630", Offset = "0xAB7630", VA = "0xAB7630")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0xAB6948", Offset = "0xAB6948", VA = "0xAB6948")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0xAB7760", Offset = "0xAB7760", VA = "0xAB7760")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0xAB786C", Offset = "0xAB786C", VA = "0xAB786C")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0xAB78F4", Offset = "0xAB78F4", VA = "0xAB78F4")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0xAB79B4", Offset = "0xAB79B4", VA = "0xAB79B4")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0xAB79CC", Offset = "0xAB79CC", VA = "0xAB79CC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0xAB4854", Offset = "0xAB4854", VA = "0xAB4854")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0xAB5344", Offset = "0xAB5344", VA = "0xAB5344")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0xAB7E44", Offset = "0xAB7E44", VA = "0xAB7E44")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x2000086")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000087")]
		public class Multiplier
		{
			[Token(Token = "0x40004B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x40004B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float multiplier;

			[Token(Token = "0x600049E")]
			[Address(RVA = "0xAB861C", Offset = "0xAB861C", VA = "0xAB861C")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Multiplier[] multipliers;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float interactionSpeedMlp;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform pivot;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 twistAxis;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float twistWeight;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float swingWeight;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool rotateOnce;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform lastPivot;

		[Token(Token = "0x6000492")]
		[Address(RVA = "0xAB838C", Offset = "0xAB838C", VA = "0xAB838C")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0xAB83D0", Offset = "0xAB83D0", VA = "0xAB83D0")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0xAB8414", Offset = "0xAB8414", VA = "0xAB8414")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0xAB8458", Offset = "0xAB8458", VA = "0xAB8458")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0xAB849C", Offset = "0xAB849C", VA = "0xAB849C")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0xAB84E0", Offset = "0xAB84E0", VA = "0xAB84E0")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0xAB8524", Offset = "0xAB8524", VA = "0xAB8524")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0xAB8568", Offset = "0xAB8568", VA = "0xAB8568")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0xAB3AA4", Offset = "0xAB3AA4", VA = "0xAB3AA4")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0xAB2C5C", Offset = "0xAB2C5C", VA = "0xAB2C5C")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0xAB13E0", Offset = "0xAB13E0", VA = "0xAB13E0")]
		public void RotateTo(Vector3 position)
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0xAB85AC", Offset = "0xAB85AC", VA = "0xAB85AC")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x2000088")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000089")]
		public class CharacterPosition
		{
			[Token(Token = "0x40004B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool use;

			[Token(Token = "0x40004BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector2 offset;

			[Token(Token = "0x40004BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float angleOffset;

			[Token(Token = "0x40004BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float maxAngle;

			[Token(Token = "0x40004BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float radius;

			[Token(Token = "0x40004BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool orbit;

			[Token(Token = "0x40004BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			public bool fixYAxis;

			[Token(Token = "0x1700007C")]
			public Vector3 offset3D
			{
				[Token(Token = "0x60004A6")]
				[Address(RVA = "0xAB888C", Offset = "0xAB888C", VA = "0xAB888C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700007D")]
			public Vector3 direction3D
			{
				[Token(Token = "0x60004A7")]
				[Address(RVA = "0xAB8898", Offset = "0xAB8898", VA = "0xAB8898")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x60004A8")]
			[Address(RVA = "0xAB8958", Offset = "0xAB8958", VA = "0xAB8958")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x60004A9")]
			[Address(RVA = "0xAB90BC", Offset = "0xAB90BC", VA = "0xAB90BC")]
			public CharacterPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200008A")]
		public class CameraPosition
		{
			[Token(Token = "0x40004C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Collider lookAtTarget;

			[Token(Token = "0x40004C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 direction;

			[Token(Token = "0x40004C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float maxDistance;

			[Token(Token = "0x40004C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float maxAngle;

			[Token(Token = "0x40004C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public bool fixYAxis;

			[Token(Token = "0x60004AA")]
			[Address(RVA = "0xAB90D0", Offset = "0xAB90D0", VA = "0xAB90D0")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60004AB")]
			[Address(RVA = "0xAB9248", Offset = "0xAB9248", VA = "0xAB9248")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x60004AC")]
			[Address(RVA = "0xAB9550", Offset = "0xAB9550", VA = "0xAB9550")]
			public CameraPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200008B")]
		public class Range
		{
			[Serializable]
			[Token(Token = "0x200008C")]
			public class Interaction
			{
				[Token(Token = "0x40004CA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public InteractionObject interactionObject;

				[Token(Token = "0x40004CB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x60004AF")]
				[Address(RVA = "0xAB95D4", Offset = "0xAB95D4", VA = "0xAB95D4")]
				public Interaction()
				{
				}
			}

			[Token(Token = "0x40004C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			public string name;

			[Token(Token = "0x40004C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			public bool show;

			[Token(Token = "0x40004C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x40004C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x40004C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Interaction[] interactions;

			[Token(Token = "0x60004AD")]
			[Address(RVA = "0xAB8778", Offset = "0xAB8778", VA = "0xAB8778")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x60004AE")]
			[Address(RVA = "0xAB95C4", Offset = "0xAB95C4", VA = "0xAB95C4")]
			public Range()
			{
			}
		}

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Range[] ranges;

		[Token(Token = "0x600049F")]
		[Address(RVA = "0xAB8624", Offset = "0xAB8624", VA = "0xAB8624")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0xAB8668", Offset = "0xAB8668", VA = "0xAB8668")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0xAB86AC", Offset = "0xAB86AC", VA = "0xAB86AC")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0xAB86F0", Offset = "0xAB86F0", VA = "0xAB86F0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0xAB8734", Offset = "0xAB8734", VA = "0xAB8734")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0xAB707C", Offset = "0xAB707C", VA = "0xAB707C")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0xAB8828", Offset = "0xAB8828", VA = "0xAB8828")]
		public InteractionTrigger()
		{
		}
	}
	[Token(Token = "0x200008D")]
	public class GenericPoser : Poser
	{
		[Serializable]
		[Token(Token = "0x200008E")]
		public class Map
		{
			[Token(Token = "0x40004CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform bone;

			[Token(Token = "0x40004CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform target;

			[Token(Token = "0x40004CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector3 defaultLocalPosition;

			[Token(Token = "0x40004D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x60004B7")]
			[Address(RVA = "0xAB98D4", Offset = "0xAB98D4", VA = "0xAB98D4")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x60004B8")]
			[Address(RVA = "0xAB9C2C", Offset = "0xAB9C2C", VA = "0xAB9C2C")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x60004B9")]
			[Address(RVA = "0xAB9BEC", Offset = "0xAB9BEC", VA = "0xAB9BEC")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x60004BA")]
			[Address(RVA = "0xAB9A70", Offset = "0xAB9A70", VA = "0xAB9A70")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0xAB95DC", Offset = "0xAB95DC", VA = "0xAB95DC", Slot = "7")]
		[ContextMenu("Auto-Mapping")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0xAB997C", Offset = "0xAB997C", VA = "0xAB997C", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0xAB9980", Offset = "0xAB9980", VA = "0xAB9980", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0xAB9B90", Offset = "0xAB9B90", VA = "0xAB9B90", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0xAB9920", Offset = "0xAB9920", VA = "0xAB9920")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0xAB9840", Offset = "0xAB9840", VA = "0xAB9840")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0xAB9C70", Offset = "0xAB9C70", VA = "0xAB9C70")]
		public GenericPoser()
		{
		}
	}
	[Token(Token = "0x200008F")]
	public class HandPoser : Poser
	{
		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Transform[] children;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform _poseRoot;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform[] poseChildren;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0xAB9C90", Offset = "0xAB9C90", VA = "0xAB9C90", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0xAB9D60", Offset = "0xAB9D60", VA = "0xAB9D60", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0xAB9F38", Offset = "0xAB9F38", VA = "0xAB9F38", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0xABA020", Offset = "0xABA020", VA = "0xABA020", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0xAB9DC0", Offset = "0xAB9DC0", VA = "0xAB9DC0")]
		protected void StoreDefaultState()
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0xABA350", Offset = "0xABA350", VA = "0xABA350")]
		public HandPoser()
		{
		}
	}
	[Token(Token = "0x2000090")]
	public abstract class Poser : SolverManager
	{
		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform poseRoot;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float weight;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float localRotationWeight;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float localPositionWeight;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool initiated;

		[Token(Token = "0x60004C1")]
		public abstract void AutoMapping();

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0xABA360", Offset = "0xABA360", VA = "0xABA360")]
		public void UpdateManual()
		{
		}

		[Token(Token = "0x60004C3")]
		protected abstract void InitiatePoser();

		[Token(Token = "0x60004C4")]
		protected abstract void UpdatePoser();

		[Token(Token = "0x60004C5")]
		protected abstract void FixPoserTransforms();

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0xABA36C", Offset = "0xABA36C", VA = "0xABA36C", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0xABA3B0", Offset = "0xABA3B0", VA = "0xABA3B0", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0xABA3DC", Offset = "0xABA3DC", VA = "0xABA3DC", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0xAB9C80", Offset = "0xAB9C80", VA = "0xAB9C80")]
		protected Poser()
		{
		}
	}
	[Token(Token = "0x2000091")]
	[RequireComponent(typeof(Animator))]
	public class RagdollUtility : MonoBehaviour
	{
		[Token(Token = "0x2000092")]
		public class Rigidbone
		{
			[Token(Token = "0x40004EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody r;

			[Token(Token = "0x40004EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform t;

			[Token(Token = "0x40004ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Collider collider;

			[Token(Token = "0x40004EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Joint joint;

			[Token(Token = "0x40004EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Rigidbody c;

			[Token(Token = "0x40004F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool updateAnchor;

			[Token(Token = "0x40004F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 deltaPosition;

			[Token(Token = "0x40004F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Quaternion deltaRotation;

			[Token(Token = "0x40004F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float deltaTime;

			[Token(Token = "0x40004F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 lastPosition;

			[Token(Token = "0x40004F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Quaternion lastRotation;

			[Token(Token = "0x60004DC")]
			[Address(RVA = "0xABAA4C", Offset = "0xABAA4C", VA = "0xABAA4C")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x60004DD")]
			[Address(RVA = "0xABB5F8", Offset = "0xABB5F8", VA = "0xABB5F8")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x60004DE")]
			[Address(RVA = "0xABB3B8", Offset = "0xABB3B8", VA = "0xABB3B8")]
			public void WakeUp(float velocityWeight, float angularVelocityWeight)
			{
			}
		}

		[Token(Token = "0x2000093")]
		public class Child
		{
			[Token(Token = "0x40004F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform t;

			[Token(Token = "0x40004F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 localPosition;

			[Token(Token = "0x40004F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Quaternion localRotation;

			[Token(Token = "0x60004DF")]
			[Address(RVA = "0xABABF4", Offset = "0xABABF4", VA = "0xABABF4")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x60004E0")]
			[Address(RVA = "0xABB710", Offset = "0xABB710", VA = "0xABB710")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x60004E1")]
			[Address(RVA = "0xABB6CC", Offset = "0xABB6CC", VA = "0xABB6CC")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IK ik;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float applyVelocity;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float applyAngularVelocity;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animator animator;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbone[] rigidbones;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Child[] children;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool enableRagdollFlag;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorUpdateMode animatorUpdateMode;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IK[] allIKComponents;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool[] fixTransforms;

		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float ragdollWeight;

		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float ragdollWeightV;

		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool fixedFrame;

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] disabledIKComponents;

		[Token(Token = "0x1700007E")]
		private bool isRagdoll
		{
			[Token(Token = "0x60004D5")]
			[Address(RVA = "0xABA420", Offset = "0xABA420", VA = "0xABA420")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700007F")]
		private bool ikUsed
		{
			[Token(Token = "0x60004D7")]
			[Address(RVA = "0xABAFEC", Offset = "0xABAFEC", VA = "0xABAFEC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0xABA3F4", Offset = "0xABA3F4", VA = "0xABA3F4")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0xABA484", Offset = "0xABA484", VA = "0xABA484")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0xABA59C", Offset = "0xABA59C", VA = "0xABA59C")]
		public void Start()
		{
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0xABA528", Offset = "0xABA528", VA = "0xABA528")]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0xABAC88", Offset = "0xABAC88", VA = "0xABAC88")]
		private void Update()
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0xABAEB0", Offset = "0xABAEB0", VA = "0xABAEB0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0xABAF50", Offset = "0xABAF50", VA = "0xABAF50")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0xABB140", Offset = "0xABB140", VA = "0xABB140")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0xABAFC0", Offset = "0xABAFC0", VA = "0xABAFC0")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0xABB10C", Offset = "0xABB10C", VA = "0xABB10C")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0xABB1C0", Offset = "0xABB1C0", VA = "0xABB1C0")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0xABB164", Offset = "0xABB164", VA = "0xABB164")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0xABA4CC", Offset = "0xABA4CC", VA = "0xABA4CC")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0xABAEE4", Offset = "0xABAEE4", VA = "0xABAEE4")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0xABB820", Offset = "0xABB820", VA = "0xABB820")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0xABB958", Offset = "0xABB958", VA = "0xABB958")]
		public RagdollUtility()
		{
		}
	}
	[Token(Token = "0x2000095")]
	public abstract class RotationLimit : MonoBehaviour
	{
		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 axis;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Quaternion defaultLocalRotation;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		private bool initiated;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		private bool applicationQuit;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
		private bool defaultLocalRotationSet;

		[Token(Token = "0x17000082")]
		public Vector3 secondaryAxis
		{
			[Token(Token = "0x60004ED")]
			[Address(RVA = "0xABC130", Offset = "0xABC130", VA = "0xABC130")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000083")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x60004EE")]
			[Address(RVA = "0xABC13C", Offset = "0xABC13C", VA = "0xABC13C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000084")]
		public bool defaultLocalRotationOverride
		{
			[Token(Token = "0x60004EF")]
			[Address(RVA = "0xABC16C", Offset = "0xABC16C", VA = "0xABC16C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004F0")]
			[Address(RVA = "0xABC174", Offset = "0xABC174", VA = "0xABC174")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0xABBCCC", Offset = "0xABBCCC", VA = "0xABBCCC")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0xABBD08", Offset = "0xABBD08", VA = "0xABBD08")]
		public void SetDefaultLocalRotation(Quaternion localRotation)
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0xABBD20", Offset = "0xABBD20", VA = "0xABBD20")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0xABC0A0", Offset = "0xABC0A0", VA = "0xABC0A0")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0xABC104", Offset = "0xABC104", VA = "0xABC104")]
		public void Disable()
		{
		}

		[Token(Token = "0x60004F1")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0xABBFA4", Offset = "0xABBFA4", VA = "0xABBFA4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0xABC180", Offset = "0xABC180", VA = "0xABC180")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0xABC184", Offset = "0xABC184", VA = "0xABC184")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0xABC1AC", Offset = "0xABC1AC", VA = "0xABC1AC")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0xABC280", Offset = "0xABC280", VA = "0xABC280")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0xABC4D8", Offset = "0xABC4D8", VA = "0xABC4D8")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0xABC62C", Offset = "0xABC62C", VA = "0xABC62C")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x2000096")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float limit;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float twistLimit;

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0xABC68C", Offset = "0xABC68C", VA = "0xABC68C")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0xABC6D0", Offset = "0xABC6D0", VA = "0xABC6D0")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0xABC714", Offset = "0xABC714", VA = "0xABC714")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0xABC758", Offset = "0xABC758", VA = "0xABC758")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0xABC79C", Offset = "0xABC79C", VA = "0xABC79C", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0xABC7D4", Offset = "0xABC7D4", VA = "0xABC7D4")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0xABCAF8", Offset = "0xABCAF8", VA = "0xABCAF8")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x2000097")]
	public class RotationLimitHinge : RotationLimit
	{
		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool useLimits;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float min;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float max;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float zeroAxisDisplayOffset;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Quaternion lastRotation;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float lastAngle;

		[Token(Token = "0x6000500")]
		[Address(RVA = "0xABCB08", Offset = "0xABCB08", VA = "0xABCB08")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0xABCB4C", Offset = "0xABCB4C", VA = "0xABCB4C")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0xABCB90", Offset = "0xABCB90", VA = "0xABCB90")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0xABCBD4", Offset = "0xABCBD4", VA = "0xABCBD4")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0xABCC18", Offset = "0xABCC18", VA = "0xABCC18", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0xABCC34", Offset = "0xABCC34", VA = "0xABCC34")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0xABCE7C", Offset = "0xABCE7C", VA = "0xABCE7C")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x2000098")]
	public class RotationLimitPolygonal : RotationLimit
	{
		[Serializable]
		[Token(Token = "0x2000099")]
		public class ReachCone
		{
			[Token(Token = "0x400050F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3[] tetrahedron;

			[Token(Token = "0x4000510")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float volume;

			[Token(Token = "0x4000511")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 S;

			[Token(Token = "0x4000512")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 B;

			[Token(Token = "0x17000085")]
			public Vector3 a
			{
				[Token(Token = "0x6000517")]
				[Address(RVA = "0xABED74", Offset = "0xABED74", VA = "0xABED74")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000086")]
			public Vector3 b
			{
				[Token(Token = "0x6000518")]
				[Address(RVA = "0xABEDA4", Offset = "0xABEDA4", VA = "0xABEDA4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000087")]
			public Vector3 c
			{
				[Token(Token = "0x6000519")]
				[Address(RVA = "0xABEDD4", Offset = "0xABEDD4", VA = "0xABEDD4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000088")]
			public bool isValid
			{
				[Token(Token = "0x600051B")]
				[Address(RVA = "0xABE29C", Offset = "0xABE29C", VA = "0xABE29C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600051A")]
			[Address(RVA = "0xABE740", Offset = "0xABE740", VA = "0xABE740")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x600051C")]
			[Address(RVA = "0xABE8B8", Offset = "0xABE8B8", VA = "0xABE8B8")]
			public void Calculate()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200009A")]
		public class LimitPoint
		{
			[Token(Token = "0x4000513")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 point;

			[Token(Token = "0x4000514")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float tangentWeight;

			[Token(Token = "0x600051D")]
			[Address(RVA = "0xABE2AC", Offset = "0xABE2AC", VA = "0xABE2AC")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float twistLimit;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int smoothIterations;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		public LimitPoint[] points;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		public Vector3[] P;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		public ReachCone[] reachCones;

		[Token(Token = "0x6000507")]
		[Address(RVA = "0xABCEE0", Offset = "0xABCEE0", VA = "0xABCEE0")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0xABCF24", Offset = "0xABCF24", VA = "0xABCF24")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0xABCF68", Offset = "0xABCF68", VA = "0xABCF68")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0xABCFAC", Offset = "0xABCFAC", VA = "0xABCFAC")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0xABCFF0", Offset = "0xABCFF0", VA = "0xABCFF0")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0xABD6D4", Offset = "0xABD6D4", VA = "0xABD6D4", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0xABD75C", Offset = "0xABD75C", VA = "0xABD75C")]
		private void Start()
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0xABDDA8", Offset = "0xABDDA8", VA = "0xABDDA8")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0xABD088", Offset = "0xABD088", VA = "0xABD088")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0xABE310", Offset = "0xABE310", VA = "0xABE310")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0xABEB2C", Offset = "0xABEB2C", VA = "0xABEB2C")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0xABEB74", Offset = "0xABEB74", VA = "0xABEB74")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0xABEBD4", Offset = "0xABEBD4", VA = "0xABEBD4")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0xABDB04", Offset = "0xABDB04", VA = "0xABDB04")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0xABEC40", Offset = "0xABEC40", VA = "0xABEC40")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0xABED0C", Offset = "0xABED0C", VA = "0xABED0C")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x200009B")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float twistLimit;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		public AnimationCurve spline;

		[Token(Token = "0x600051E")]
		[Address(RVA = "0xABEE04", Offset = "0xABEE04", VA = "0xABEE04")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0xABEE48", Offset = "0xABEE48", VA = "0xABEE48")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0xABEE8C", Offset = "0xABEE8C", VA = "0xABEE8C")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0xABEED0", Offset = "0xABEED0", VA = "0xABEED0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0xABEF14", Offset = "0xABEF14", VA = "0xABEF14")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0xABEF30", Offset = "0xABEF30", VA = "0xABEF30", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0xABEF68", Offset = "0xABEF68", VA = "0xABEF68")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0xABF314", Offset = "0xABF314", VA = "0xABF314")]
		public RotationLimitSpline()
		{
		}
	}
	[Token(Token = "0x200009C")]
	public class AimController : MonoBehaviour
	{
		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK ik;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float weight;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform target;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float weightSmoothTime;

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float maxRadiansDelta;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float slerpSpeed;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float minDistance;

		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Vector3 offset;

		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float maxRootAngle;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool turnToTarget;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float turnToTargetTime;

		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public bool useAnimatedAimDirection;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Vector3 animatedAimDirection;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Transform lastTarget;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float switchWeight;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float switchWeightV;

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float weightV;

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Vector3 lastPosition;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector3 dir;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAD")]
		private bool turningToTarget;

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float turnToTargetMlp;

		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float turnToTargetMlpV;

		[Token(Token = "0x17000089")]
		private Vector3 pivot
		{
			[Token(Token = "0x6000528")]
			[Address(RVA = "0xABF3A0", Offset = "0xABF3A0", VA = "0xABF3A0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0xABF320", Offset = "0xABF320", VA = "0xABF320")]
		private void Start()
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0xABF424", Offset = "0xABF424", VA = "0xABF424")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0xABF95C", Offset = "0xABF95C", VA = "0xABF95C")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0xABFAE0", Offset = "0xABFAE0", VA = "0xABFAE0")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0xABFD84", Offset = "0xABFD84", VA = "0xABFD84")]
		private IEnumerator TurnToTarget()
		{
			return null;
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0xABFE20", Offset = "0xABFE20", VA = "0xABFE20")]
		public AimController()
		{
		}
	}
	[Token(Token = "0x200009E")]
	public class AimPoser : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200009F")]
		public class Pose
		{
			[Token(Token = "0x4000537")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool visualize;

			[Token(Token = "0x4000538")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string name;

			[Token(Token = "0x4000539")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 direction;

			[Token(Token = "0x400053A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float yaw;

			[Token(Token = "0x400053B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float pitch;

			[Token(Token = "0x400053C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float angleBuffer;

			[Token(Token = "0x6000536")]
			[Address(RVA = "0xAC0118", Offset = "0xAC0118", VA = "0xAC0118")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x6000537")]
			[Address(RVA = "0xAC0694", Offset = "0xAC0694", VA = "0xAC0694")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x6000538")]
			[Address(RVA = "0xAC069C", Offset = "0xAC069C", VA = "0xAC069C")]
			public Pose()
			{
			}
		}

		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float angleBuffer;

		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Pose[] poses;

		[Token(Token = "0x6000533")]
		[Address(RVA = "0xAC0048", Offset = "0xAC0048", VA = "0xAC0048")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0xAC05C8", Offset = "0xAC05C8", VA = "0xAC05C8")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0xAC0628", Offset = "0xAC0628", VA = "0xAC0628")]
		public AimPoser()
		{
		}
	}
	[Token(Token = "0x20000A0")]
	public class Amplifier : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000A1")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x20000A2")]
			public class EffectorLink
			{
				[Token(Token = "0x4000547")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000548")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				public float weight;

				[Token(Token = "0x600053D")]
				[Address(RVA = "0xAC0B18", Offset = "0xAC0B18", VA = "0xAC0B18")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400053E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x400053F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform relativeTo;

			[Token(Token = "0x4000540")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000541")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float verticalWeight;

			[Token(Token = "0x4000542")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float horizontalWeight;

			[Token(Token = "0x4000543")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float speed;

			[Token(Token = "0x4000544")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 lastRelativePos;

			[Token(Token = "0x4000545")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Vector3 smoothDelta;

			[Token(Token = "0x4000546")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private bool firstUpdate;

			[Token(Token = "0x600053B")]
			[Address(RVA = "0xAC07E8", Offset = "0xAC07E8", VA = "0xAC07E8")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x600053C")]
			[Address(RVA = "0xAC0B00", Offset = "0xAC0B00", VA = "0xAC0B00")]
			public Body()
			{
			}
		}

		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Body[] bodies;

		[Token(Token = "0x6000539")]
		[Address(RVA = "0xAC06B8", Offset = "0xAC06B8", VA = "0xAC06B8", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0xAC0AF8", Offset = "0xAC0AF8", VA = "0xAC0AF8")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x20000A3")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float tiltSpeed;

		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float tiltSensitivity;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public OffsetPose poseLeft;

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public OffsetPose poseRight;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float tiltAngle;

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 lastForward;

		[Token(Token = "0x600053E")]
		[Address(RVA = "0xAC0B20", Offset = "0xAC0B20", VA = "0xAC0B20", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0xAC0B5C", Offset = "0xAC0B5C", VA = "0xAC0B5C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0xAC0D48", Offset = "0xAC0D48", VA = "0xAC0D48")]
		public BodyTilt()
		{
		}
	}
	[Token(Token = "0x20000A4")]
	[ExecuteInEditMode]
	public class EditorIK : MonoBehaviour
	{
		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IK ik;

		[Token(Token = "0x6000541")]
		[Address(RVA = "0xAC0D5C", Offset = "0xAC0D5C", VA = "0xAC0D5C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0xAC0DF8", Offset = "0xAC0DF8", VA = "0xAC0DF8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0xAC0EB8", Offset = "0xAC0EB8", VA = "0xAC0EB8")]
		public EditorIK()
		{
		}
	}
	[Token(Token = "0x20000A5")]
	public class HitReaction : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000A6")]
		public abstract class HitPoint
		{
			[Token(Token = "0x4000552")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string name;

			[Token(Token = "0x4000553")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Collider collider;

			[Token(Token = "0x4000554")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x4000559")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x400055A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x400055B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x1700008D")]
			public bool inProgress
			{
				[Token(Token = "0x6000548")]
				[Address(RVA = "0xAC0F5C", Offset = "0xAC0F5C", VA = "0xAC0F5C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700008E")]
			protected float crossFader
			{
				[Token(Token = "0x6000549")]
				[Address(RVA = "0xAC1454", Offset = "0xAC1454", VA = "0xAC1454")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600054A")]
				[Address(RVA = "0xAC145C", Offset = "0xAC145C", VA = "0xAC145C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700008F")]
			protected float timer
			{
				[Token(Token = "0x600054B")]
				[Address(RVA = "0xAC1464", Offset = "0xAC1464", VA = "0xAC1464")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600054C")]
				[Address(RVA = "0xAC146C", Offset = "0xAC146C", VA = "0xAC146C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000090")]
			protected Vector3 force
			{
				[Token(Token = "0x600054D")]
				[Address(RVA = "0xAC1474", Offset = "0xAC1474", VA = "0xAC1474")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600054E")]
				[Address(RVA = "0xAC1480", Offset = "0xAC1480", VA = "0xAC1480")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000091")]
			protected Vector3 point
			{
				[Token(Token = "0x600054F")]
				[Address(RVA = "0xAC148C", Offset = "0xAC148C", VA = "0xAC148C")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000550")]
				[Address(RVA = "0xAC1498", Offset = "0xAC1498", VA = "0xAC1498")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000551")]
			[Address(RVA = "0xAC1324", Offset = "0xAC1324", VA = "0xAC1324")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x6000552")]
			[Address(RVA = "0xAC1030", Offset = "0xAC1030", VA = "0xAC1030")]
			public void Apply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000553")]
			protected abstract float GetLength();

			[Token(Token = "0x6000554")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x6000555")]
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);

			[Token(Token = "0x6000556")]
			[Address(RVA = "0xAC14A4", Offset = "0xAC14A4", VA = "0xAC14A4")]
			protected HitPoint()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000A7")]
		public class HitPointEffector : HitPoint
		{
			[Serializable]
			[Token(Token = "0x20000A8")]
			public class EffectorLink
			{
				[Token(Token = "0x400055F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000560")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				public float weight;

				[Token(Token = "0x4000561")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000562")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x600055B")]
				[Address(RVA = "0xAC17D8", Offset = "0xAC17D8", VA = "0xAC17D8")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x600055C")]
				[Address(RVA = "0xAC1634", Offset = "0xAC1634", VA = "0xAC1634")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x600055D")]
				[Address(RVA = "0xAC1888", Offset = "0xAC1888", VA = "0xAC1888")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400055C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x400055D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x400055E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x6000557")]
			[Address(RVA = "0xAC14B8", Offset = "0xAC14B8", VA = "0xAC14B8", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x6000558")]
			[Address(RVA = "0xAC15D4", Offset = "0xAC15D4", VA = "0xAC15D4", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000559")]
			[Address(RVA = "0xAC1648", Offset = "0xAC1648", VA = "0xAC1648", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x600055A")]
			[Address(RVA = "0xAC1874", Offset = "0xAC1874", VA = "0xAC1874")]
			public HitPointEffector()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000A9")]
		public class HitPointBone : HitPoint
		{
			[Serializable]
			[Token(Token = "0x20000AA")]
			public class BoneLink
			{
				[Token(Token = "0x4000566")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public Transform bone;

				[Token(Token = "0x4000567")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public float weight;

				[Token(Token = "0x4000568")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				[Token(Token = "0x4000569")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private Quaternion current;

				[Token(Token = "0x6000562")]
				[Address(RVA = "0xAC1B58", Offset = "0xAC1B58", VA = "0xAC1B58")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000563")]
				[Address(RVA = "0xAC1974", Offset = "0xAC1974", VA = "0xAC1974")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000564")]
				[Address(RVA = "0xAC1CF8", Offset = "0xAC1CF8", VA = "0xAC1CF8")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x4000563")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x4000564")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x4000565")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x600055E")]
			[Address(RVA = "0xAC1890", Offset = "0xAC1890", VA = "0xAC1890", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x600055F")]
			[Address(RVA = "0xAC191C", Offset = "0xAC191C", VA = "0xAC191C", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000560")]
			[Address(RVA = "0xAC1980", Offset = "0xAC1980", VA = "0xAC1980", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000561")]
			[Address(RVA = "0xAC1CE4", Offset = "0xAC1CE4", VA = "0xAC1CE4")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x4000551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x1700008C")]
		public bool inProgress
		{
			[Token(Token = "0x6000544")]
			[Address(RVA = "0xAC0EC0", Offset = "0xAC0EC0", VA = "0xAC0EC0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0xAC0F70", Offset = "0xAC0F70", VA = "0xAC0F70", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0xAC1108", Offset = "0xAC1108", VA = "0xAC1108")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0xAC144C", Offset = "0xAC144C", VA = "0xAC144C")]
		public HitReaction()
		{
		}
	}
	[Token(Token = "0x20000AB")]
	public class HitReactionVRIK : OffsetModifierVRIK
	{
		[Serializable]
		[Token(Token = "0x20000AC")]
		public abstract class Offset
		{
			[Token(Token = "0x400056D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string name;

			[Token(Token = "0x400056E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Collider collider;

			[Token(Token = "0x400056F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x4000574")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x4000575")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x4000576")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x17000092")]
			protected float crossFader
			{
				[Token(Token = "0x6000568")]
				[Address(RVA = "0xAC2250", Offset = "0xAC2250", VA = "0xAC2250")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000569")]
				[Address(RVA = "0xAC2258", Offset = "0xAC2258", VA = "0xAC2258")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000093")]
			protected float timer
			{
				[Token(Token = "0x600056A")]
				[Address(RVA = "0xAC2260", Offset = "0xAC2260", VA = "0xAC2260")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600056B")]
				[Address(RVA = "0xAC2268", Offset = "0xAC2268", VA = "0xAC2268")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000094")]
			protected Vector3 force
			{
				[Token(Token = "0x600056C")]
				[Address(RVA = "0xAC2270", Offset = "0xAC2270", VA = "0xAC2270")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600056D")]
				[Address(RVA = "0xAC227C", Offset = "0xAC227C", VA = "0xAC227C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000095")]
			protected Vector3 point
			{
				[Token(Token = "0x600056E")]
				[Address(RVA = "0xAC2288", Offset = "0xAC2288", VA = "0xAC2288")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600056F")]
				[Address(RVA = "0xAC2294", Offset = "0xAC2294", VA = "0xAC2294")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000570")]
			[Address(RVA = "0xAC2118", Offset = "0xAC2118", VA = "0xAC2118")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x6000571")]
			[Address(RVA = "0xAC1E14", Offset = "0xAC1E14", VA = "0xAC1E14")]
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000572")]
			protected abstract float GetLength(AnimationCurve[] curves);

			[Token(Token = "0x6000573")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x6000574")]
			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);

			[Token(Token = "0x6000575")]
			[Address(RVA = "0xAC22A0", Offset = "0xAC22A0", VA = "0xAC22A0")]
			protected Offset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000AD")]
		public class PositionOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x20000AE")]
			public class PositionOffsetLink
			{
				[Token(Token = "0x400057A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x400057B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				public float weight;

				[Token(Token = "0x400057C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x400057D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x600057A")]
				[Address(RVA = "0xAC3684", Offset = "0xAC3684", VA = "0xAC3684")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x600057B")]
				[Address(RVA = "0xAC34A8", Offset = "0xAC34A8", VA = "0xAC34A8")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x600057C")]
				[Address(RVA = "0xAC370C", Offset = "0xAC370C", VA = "0xAC370C")]
				public PositionOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000577")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public int forceDirCurveIndex;

			[Token(Token = "0x4000578")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public int upDirCurveIndex;

			[Token(Token = "0x4000579")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x6000576")]
			[Address(RVA = "0xAC32B4", Offset = "0xAC32B4", VA = "0xAC32B4", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000577")]
			[Address(RVA = "0xAC3448", Offset = "0xAC3448", VA = "0xAC3448", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000578")]
			[Address(RVA = "0xAC34BC", Offset = "0xAC34BC", VA = "0xAC34BC", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000579")]
			[Address(RVA = "0xAC36FC", Offset = "0xAC36FC", VA = "0xAC36FC")]
			public PositionOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000AF")]
		public class RotationOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x20000B0")]
			public class RotationOffsetLink
			{
				[Token(Token = "0x4000581")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x4000582")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				public float weight;

				[Token(Token = "0x4000583")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				[Token(Token = "0x4000584")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private Quaternion current;

				[Token(Token = "0x6000581")]
				[Address(RVA = "0xAC3AE0", Offset = "0xAC3AE0", VA = "0xAC3AE0")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000582")]
				[Address(RVA = "0xAC3844", Offset = "0xAC3844", VA = "0xAC3844")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000583")]
				[Address(RVA = "0xAC3BF0", Offset = "0xAC3BF0", VA = "0xAC3BF0")]
				public RotationOffsetLink()
				{
				}
			}

			[Token(Token = "0x400057E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public int curveIndex;

			[Token(Token = "0x400057F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x4000580")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x600057D")]
			[Address(RVA = "0xAC3714", Offset = "0xAC3714", VA = "0xAC3714", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x600057E")]
			[Address(RVA = "0xAC37EC", Offset = "0xAC37EC", VA = "0xAC37EC", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600057F")]
			[Address(RVA = "0xAC3850", Offset = "0xAC3850", VA = "0xAC3850", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000580")]
			[Address(RVA = "0xAC3BE8", Offset = "0xAC3BE8", VA = "0xAC3BE8")]
			public RotationOffset()
			{
			}
		}

		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x6000565")]
		[Address(RVA = "0xAC1D5C", Offset = "0xAC1D5C", VA = "0xAC1D5C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0xAC1EF4", Offset = "0xAC1EF4", VA = "0xAC1EF4")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0xAC2248", Offset = "0xAC2248", VA = "0xAC2248")]
		public HitReactionVRIK()
		{
		}
	}
	[Token(Token = "0x20000B1")]
	public class Inertia : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000B2")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x20000B3")]
			public class EffectorLink
			{
				[Token(Token = "0x4000592")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000593")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				public float weight;

				[Token(Token = "0x600058A")]
				[Address(RVA = "0xAC41E8", Offset = "0xAC41E8", VA = "0xAC41E8")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000587")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x4000588")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000589")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float speed;

			[Token(Token = "0x400058A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float acceleration;

			[Token(Token = "0x400058B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float matchVelocity;

			[Token(Token = "0x400058C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float gravity;

			[Token(Token = "0x400058D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 delta;

			[Token(Token = "0x400058E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lazyPoint;

			[Token(Token = "0x400058F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 direction;

			[Token(Token = "0x4000590")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 lastPosition;

			[Token(Token = "0x4000591")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private bool firstUpdate;

			[Token(Token = "0x6000587")]
			[Address(RVA = "0xAC3CC0", Offset = "0xAC3CC0", VA = "0xAC3CC0")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000588")]
			[Address(RVA = "0xAC3E60", Offset = "0xAC3E60", VA = "0xAC3E60")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x6000589")]
			[Address(RVA = "0xAC41CC", Offset = "0xAC41CC", VA = "0xAC41CC")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Body[] bodies;

		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public OffsetLimits[] limits;

		[Token(Token = "0x6000584")]
		[Address(RVA = "0xAC3C54", Offset = "0xAC3C54", VA = "0xAC3C54")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0xAC3D9C", Offset = "0xAC3D9C", VA = "0xAC3D9C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0xAC41AC", Offset = "0xAC41AC", VA = "0xAC41AC")]
		public Inertia()
		{
		}
	}
	[Token(Token = "0x20000B4")]
	public class LookAtController : MonoBehaviour
	{
		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LookAtIK ik;

		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform target;

		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weight;

		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 offset;

		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float weightSmoothTime;

		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float maxRadiansDelta;

		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float slerpSpeed;

		[Token(Token = "0x400059E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x400059F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float minDistance;

		[Token(Token = "0x40005A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float maxRootAngle;

		[Token(Token = "0x40005A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform lastTarget;

		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float switchWeight;

		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float switchWeightV;

		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float weightV;

		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Vector3 lastPosition;

		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 dir;

		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x17000096")]
		private Vector3 pivot
		{
			[Token(Token = "0x600058D")]
			[Address(RVA = "0xAC4258", Offset = "0xAC4258", VA = "0xAC4258")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0xAC41F0", Offset = "0xAC41F0", VA = "0xAC41F0")]
		private void Start()
		{
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0xAC42DC", Offset = "0xAC42DC", VA = "0xAC42DC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0xAC47D0", Offset = "0xAC47D0", VA = "0xAC47D0")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0xAC4954", Offset = "0xAC4954", VA = "0xAC4954")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0xAC4BA0", Offset = "0xAC4BA0", VA = "0xAC4BA0")]
		public LookAtController()
		{
		}
	}
	[Token(Token = "0x20000B5")]
	public abstract class OffsetModifier : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000B6")]
		public class OffsetLimits
		{
			[Token(Token = "0x40005AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x40005AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float spring;

			[Token(Token = "0x40005AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool x;

			[Token(Token = "0x40005AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			public bool y;

			[Token(Token = "0x40005AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			public bool z;

			[Token(Token = "0x40005B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float minX;

			[Token(Token = "0x40005B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float maxX;

			[Token(Token = "0x40005B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float minY;

			[Token(Token = "0x40005B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float maxY;

			[Token(Token = "0x40005B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float minZ;

			[Token(Token = "0x40005B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float maxZ;

			[Token(Token = "0x6000599")]
			[Address(RVA = "0xAC4DC8", Offset = "0xAC4DC8", VA = "0xAC4DC8")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x600059A")]
			[Address(RVA = "0xAC5058", Offset = "0xAC5058", VA = "0xAC5058")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x600059B")]
			[Address(RVA = "0xAC50C8", Offset = "0xAC50C8", VA = "0xAC50C8")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x600059C")]
			[Address(RVA = "0xAC5110", Offset = "0xAC5110", VA = "0xAC5110")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float weight;

		[Token(Token = "0x40005A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40005AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float lastTime;

		[Token(Token = "0x17000097")]
		protected float deltaTime
		{
			[Token(Token = "0x6000591")]
			[Address(RVA = "0xAC3E40", Offset = "0xAC3E40", VA = "0xAC3E40")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000592")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000593")]
		[Address(RVA = "0xAC4C38", Offset = "0xAC4C38", VA = "0xAC4C38", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0xAC4C58", Offset = "0xAC4C58", VA = "0xAC4C58")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0xAC4CF4", Offset = "0xAC4CF4", VA = "0xAC4CF4")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0xAC4104", Offset = "0xAC4104", VA = "0xAC4104")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0xAC4F2C", Offset = "0xAC4F2C", VA = "0xAC4F2C", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0xAC41BC", Offset = "0xAC41BC", VA = "0xAC41BC")]
		protected OffsetModifier()
		{
		}
	}
	[Token(Token = "0x20000B8")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float weight;

		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public VRIK ik;

		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float lastTime;

		[Token(Token = "0x1700009A")]
		protected float deltaTime
		{
			[Token(Token = "0x60005A3")]
			[Address(RVA = "0xAC52DC", Offset = "0xAC52DC", VA = "0xAC52DC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60005A4")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0xAC52FC", Offset = "0xAC52FC", VA = "0xAC52FC", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0xAC531C", Offset = "0xAC531C", VA = "0xAC531C")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0xAC53B8", Offset = "0xAC53B8", VA = "0xAC53B8")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0xAC548C", Offset = "0xAC548C", VA = "0xAC548C", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0xAC55B8", Offset = "0xAC55B8", VA = "0xAC55B8")]
		protected OffsetModifierVRIK()
		{
		}
	}
	[Token(Token = "0x20000BA")]
	public class OffsetPose : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000BB")]
		public class EffectorLink
		{
			[Token(Token = "0x40005C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x40005C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 offset;

			[Token(Token = "0x40005C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 pin;

			[Token(Token = "0x40005C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 pinWeight;

			[Token(Token = "0x60005B3")]
			[Address(RVA = "0xAC5840", Offset = "0xAC5840", VA = "0xAC5840")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x60005B4")]
			[Address(RVA = "0xAC5B98", Offset = "0xAC5B98", VA = "0xAC5B98")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x40005BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0xAC578C", Offset = "0xAC578C", VA = "0xAC578C")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0xAC5A90", Offset = "0xAC5A90", VA = "0xAC5A90")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0xAC5B34", Offset = "0xAC5B34", VA = "0xAC5B34")]
		public OffsetPose()
		{
		}
	}
	[Token(Token = "0x20000BC")]
	public class PenetrationAvoidance : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000BD")]
		public class Avoider
		{
			[Serializable]
			[Token(Token = "0x20000BE")]
			public class EffectorLink
			{
				[Token(Token = "0x40005CF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40005D0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				public float weight;

				[Token(Token = "0x60005BB")]
				[Address(RVA = "0xAC61EC", Offset = "0xAC61EC", VA = "0xAC61EC")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40005C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform[] raycastFrom;

			[Token(Token = "0x40005C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform raycastTo;

			[Token(Token = "0x40005C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float raycastRadius;

			[Token(Token = "0x40005C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public EffectorLink[] effectors;

			[Token(Token = "0x40005C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float smoothTimeIn;

			[Token(Token = "0x40005CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float smoothTimeOut;

			[Token(Token = "0x40005CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public LayerMask layers;

			[Token(Token = "0x40005CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 offset;

			[Token(Token = "0x40005CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 offsetTarget;

			[Token(Token = "0x40005CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 offsetV;

			[Token(Token = "0x60005B7")]
			[Address(RVA = "0xAC5C10", Offset = "0xAC5C10", VA = "0xAC5C10")]
			public void Solve(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60005B8")]
			[Address(RVA = "0xAC5DB0", Offset = "0xAC5DB0", VA = "0xAC5DB0")]
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005B9")]
			[Address(RVA = "0xAC5EB8", Offset = "0xAC5EB8", VA = "0xAC5EB8")]
			private Vector3 Raycast(Vector3 from, Vector3 to)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005BA")]
			[Address(RVA = "0xAC61D8", Offset = "0xAC61D8", VA = "0xAC61D8")]
			public Avoider()
			{
			}
		}

		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Avoider[] avoiders;

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0xAC5BA0", Offset = "0xAC5BA0", VA = "0xAC5BA0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0xAC5DA0", Offset = "0xAC5DA0", VA = "0xAC5DA0")]
		public PenetrationAvoidance()
		{
		}
	}
	[Token(Token = "0x20000BF")]
	public class Recoil : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000C0")]
		public class RecoilOffset
		{
			[Serializable]
			[Token(Token = "0x20000C1")]
			public class EffectorLink
			{
				[Token(Token = "0x40005EE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40005EF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				public float weight;

				[Token(Token = "0x60005CB")]
				[Address(RVA = "0xAC7598", Offset = "0xAC7598", VA = "0xAC7598")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40005E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 offset;

			[Token(Token = "0x40005E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float additivity;

			[Token(Token = "0x40005EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x40005EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x40005EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 additiveOffset;

			[Token(Token = "0x40005ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lastOffset;

			[Token(Token = "0x60005C8")]
			[Address(RVA = "0xAC6390", Offset = "0xAC6390", VA = "0xAC6390")]
			public void Start()
			{
			}

			[Token(Token = "0x60005C9")]
			[Address(RVA = "0xAC6F10", Offset = "0xAC6F10", VA = "0xAC6F10")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x60005CA")]
			[Address(RVA = "0xAC7584", Offset = "0xAC7584", VA = "0xAC7584")]
			public RecoilOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000C2")]
		public enum Handedness
		{
			[Token(Token = "0x40005F1")]
			Right,
			[Token(Token = "0x40005F2")]
			Left
		}

		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AimIK aimIK;

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Handedness handedness;

		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool twoHanded;

		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float magnitudeRandom;

		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 rotationRandom;

		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float blendTime;

		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public RecoilOffset[] offsets;

		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Quaternion rotationOffset;

		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float magnitudeMlp;

		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float endTime;

		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion handRotation;

		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Quaternion secondaryHandRelativeRotation;

		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion randomRotation;

		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float length;

		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private bool initiated;

		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float blendWeight;

		[Token(Token = "0x40005E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float w;

		[Token(Token = "0x40005E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Quaternion primaryHandRotation;

		[Token(Token = "0x40005E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool handRotationsSet;

		[Token(Token = "0x40005E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Vector3 aimIKAxis;

		[Token(Token = "0x1700009D")]
		public bool isFinished
		{
			[Token(Token = "0x60005BC")]
			[Address(RVA = "0xAC61F4", Offset = "0xAC61F4", VA = "0xAC61F4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700009E")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x60005C2")]
			[Address(RVA = "0xAC7114", Offset = "0xAC7114", VA = "0xAC7114")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009F")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x60005C3")]
			[Address(RVA = "0xAC7150", Offset = "0xAC7150", VA = "0xAC7150")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A0")]
		private Transform primaryHand
		{
			[Token(Token = "0x60005C4")]
			[Address(RVA = "0xAC70DC", Offset = "0xAC70DC", VA = "0xAC70DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A1")]
		private Transform secondaryHand
		{
			[Token(Token = "0x60005C5")]
			[Address(RVA = "0xAC70F8", Offset = "0xAC70F8", VA = "0xAC70F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0xAC6218", Offset = "0xAC6218", VA = "0xAC6218")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0xAC6244", Offset = "0xAC6244", VA = "0xAC6244")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0xAC6464", Offset = "0xAC6464", VA = "0xAC6464", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0xAC718C", Offset = "0xAC718C", VA = "0xAC718C")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0xAC72A4", Offset = "0xAC72A4", VA = "0xAC72A4")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0xAC72F4", Offset = "0xAC72F4", VA = "0xAC72F4", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0xAC74F8", Offset = "0xAC74F8", VA = "0xAC74F8")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x20000C3")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x40005F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float weight;

		[Token(Token = "0x40005F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float offset;

		[Token(Token = "0x40005F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40005F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool skip;

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0xAC75A0", Offset = "0xAC75A0", VA = "0xAC75A0")]
		private void Start()
		{
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0xAC76B4", Offset = "0xAC76B4", VA = "0xAC76B4")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0xAC7790", Offset = "0xAC7790", VA = "0xAC7790")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0xAC7B94", Offset = "0xAC7B94", VA = "0xAC7B94")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0xAC7BC8", Offset = "0xAC7BC8", VA = "0xAC7BC8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0xAC7CF4", Offset = "0xAC7CF4", VA = "0xAC7CF4")]
		public ShoulderRotator()
		{
		}
	}
	[Token(Token = "0x20000C4")]
	public static class VRIKCalibrator
	{
		[Serializable]
		[Token(Token = "0x20000C5")]
		public class Settings
		{
			[Token(Token = "0x40005F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float scaleMlp;

			[Token(Token = "0x40005F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 headTrackerForward;

			[Token(Token = "0x40005F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 headTrackerUp;

			[Token(Token = "0x40005FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 bodyTrackerForward;

			[Token(Token = "0x40005FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Vector3 bodyTrackerUp;

			[Token(Token = "0x40005FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public Vector3 handTrackerForward;

			[Token(Token = "0x40005FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Vector3 handTrackerUp;

			[Token(Token = "0x40005FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 footTrackerForward;

			[Token(Token = "0x40005FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Vector3 footTrackerUp;

			[Token(Token = "0x4000600")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			public Vector3 headOffset;

			[Token(Token = "0x4000601")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			public Vector3 handOffset;

			[Token(Token = "0x4000602")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			public float footForwardOffset;

			[Token(Token = "0x4000603")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public float footInwardOffset;

			[Token(Token = "0x4000604")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			public float footHeadingOffset;

			[Token(Token = "0x4000605")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			public float pelvisPositionWeight;

			[Token(Token = "0x4000606")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			public float pelvisRotationWeight;

			[Token(Token = "0x60005D7")]
			[Address(RVA = "0xACA8AC", Offset = "0xACA8AC", VA = "0xACA8AC")]
			public Settings()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000C6")]
		public class CalibrationData
		{
			[Serializable]
			[Token(Token = "0x20000C7")]
			public class Target
			{
				[Token(Token = "0x4000613")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public bool used;

				[Token(Token = "0x4000614")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				public Vector3 localPosition;

				[Token(Token = "0x4000615")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public Quaternion localRotation;

				[Token(Token = "0x60005D9")]
				[Address(RVA = "0xAC99E4", Offset = "0xAC99E4", VA = "0xAC99E4")]
				public Target(Transform t)
				{
				}

				[Token(Token = "0x60005DA")]
				[Address(RVA = "0xACA43C", Offset = "0xACA43C", VA = "0xACA43C")]
				public void SetTo(Transform t)
				{
				}
			}

			[Token(Token = "0x4000607")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float scale;

			[Token(Token = "0x4000608")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Target head;

			[Token(Token = "0x4000609")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Target leftHand;

			[Token(Token = "0x400060A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Target rightHand;

			[Token(Token = "0x400060B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Target pelvis;

			[Token(Token = "0x400060C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Target leftFoot;

			[Token(Token = "0x400060D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Target rightFoot;

			[Token(Token = "0x400060E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Target leftLegGoal;

			[Token(Token = "0x400060F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Target rightLegGoal;

			[Token(Token = "0x4000610")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Vector3 pelvisTargetRight;

			[Token(Token = "0x4000611")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public float pelvisPositionWeight;

			[Token(Token = "0x4000612")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public float pelvisRotationWeight;

			[Token(Token = "0x60005D8")]
			[Address(RVA = "0xAC90E8", Offset = "0xAC90E8", VA = "0xAC90E8")]
			public CalibrationData()
			{
			}
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0xAC7D08", Offset = "0xAC7D08", VA = "0xAC7D08")]
		public static void RecalibrateScale(VRIK ik, Settings settings)
		{
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0xAC7DFC", Offset = "0xAC7DFC", VA = "0xAC7DFC")]
		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
			return null;
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0xAC90F0", Offset = "0xAC90F0", VA = "0xAC90F0")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0xAC9A98", Offset = "0xAC9A98", VA = "0xAC9A98")]
		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0xACA498", Offset = "0xACA498", VA = "0xACA498")]
		private static void CalibrateLeg(CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}
	}
	[Token(Token = "0x20000C8")]
	public class VRIKLODController : MonoBehaviour
	{
		[Token(Token = "0x4000616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Renderer LODRenderer;

		[Token(Token = "0x4000617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float LODDistance;

		[Token(Token = "0x4000618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool allowCulled;

		[Token(Token = "0x4000619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private VRIK ik;

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0xACAAB0", Offset = "0xACAAB0", VA = "0xACAAB0")]
		private void Start()
		{
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0xACAB08", Offset = "0xACAB08", VA = "0xACAB08")]
		private void Update()
		{
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0xACAB30", Offset = "0xACAB30", VA = "0xACAB30")]
		private int GetLODLevel()
		{
			return default(int);
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0xACAC50", Offset = "0xACAC50", VA = "0xACAC50")]
		public VRIKLODController()
		{
		}
	}
	[Token(Token = "0x20000C9")]
	public class VRIKRootController : MonoBehaviour
	{
		[Token(Token = "0x400061B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform pelvisTarget;

		[Token(Token = "0x400061C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform leftFootTarget;

		[Token(Token = "0x400061D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform rightFootTarget;

		[Token(Token = "0x400061E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private VRIK ik;

		[Token(Token = "0x170000A2")]
		public Vector3 pelvisTargetRight
		{
			[Token(Token = "0x60005DF")]
			[Address(RVA = "0xACAC68", Offset = "0xACAC68", VA = "0xACAC68")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60005E0")]
			[Address(RVA = "0xACAC74", Offset = "0xACAC74", VA = "0xACAC74")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0xACAC80", Offset = "0xACAC80", VA = "0xACAC80")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0xAC97D0", Offset = "0xAC97D0", VA = "0xAC97D0")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0xACA70C", Offset = "0xACA70C", VA = "0xACA70C")]
		public void Calibrate(VRIKCalibrator.CalibrationData data)
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0xACAD9C", Offset = "0xACAD9C", VA = "0xACAD9C")]
		private void OnPreUpdate()
		{
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0xACB164", Offset = "0xACB164", VA = "0xACB164")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0xACB290", Offset = "0xACB290", VA = "0xACB290")]
		public VRIKRootController()
		{
		}
	}
}
namespace RootMotion.Demos
{
	[Token(Token = "0x20000CA")]
	public class FKOffset : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000CB")]
		public class Offset
		{
			[Token(Token = "0x4000621")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			public string name;

			[Token(Token = "0x4000622")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HumanBodyBones bone;

			[Token(Token = "0x4000623")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 rotationOffset;

			[Token(Token = "0x4000624")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Transform t;

			[Token(Token = "0x60005EB")]
			[Address(RVA = "0xACB354", Offset = "0xACB354", VA = "0xACB354")]
			public void Apply(Animator animator)
			{
			}

			[Token(Token = "0x60005EC")]
			[Address(RVA = "0xACB5D0", Offset = "0xACB5D0", VA = "0xACB5D0")]
			public Offset()
			{
			}
		}

		[Token(Token = "0x400061F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Offset[] offsets;

		[Token(Token = "0x4000620")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0xACB298", Offset = "0xACB298", VA = "0xACB298")]
		private void Start()
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0xACB2F0", Offset = "0xACB2F0", VA = "0xACB2F0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0xACB504", Offset = "0xACB504", VA = "0xACB504")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0xACB5C8", Offset = "0xACB5C8", VA = "0xACB5C8")]
		public FKOffset()
		{
		}
	}
	[Token(Token = "0x20000CC")]
	public class AimBoxing : MonoBehaviour
	{
		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform pin;

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0xACB5D8", Offset = "0xACB5D8", VA = "0xACB5D8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0xACB658", Offset = "0xACB658", VA = "0xACB658")]
		public AimBoxing()
		{
		}
	}
	[Token(Token = "0x20000CD")]
	public class AimSwing : MonoBehaviour
	{
		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK ik;

		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 animatedSwingDirection;

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0xACB660", Offset = "0xACB660", VA = "0xACB660")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0xACB6CC", Offset = "0xACB6CC", VA = "0xACB6CC")]
		public AimSwing()
		{
		}
	}
	[Token(Token = "0x20000CE")]
	public class SecondHandOnGun : MonoBehaviour
	{
		[Token(Token = "0x4000629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aim;

		[Token(Token = "0x400062A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbIK leftArmIK;

		[Token(Token = "0x400062B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftHand;

		[Token(Token = "0x400062C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightHand;

		[Token(Token = "0x400062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 leftHandPositionOffset;

		[Token(Token = "0x400062E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 leftHandRotationOffset;

		[Token(Token = "0x400062F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector3 leftHandPosRelToRight;

		[Token(Token = "0x4000630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion leftHandRotRelToRight;

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0xACB72C", Offset = "0xACB72C", VA = "0xACB72C")]
		private void Start()
		{
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0xACB764", Offset = "0xACB764", VA = "0xACB764")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0xACBA20", Offset = "0xACBA20", VA = "0xACBA20")]
		public SecondHandOnGun()
		{
		}
	}
	[Token(Token = "0x20000CF")]
	public class SimpleAimingSystem : MonoBehaviour
	{
		[Token(Token = "0x4000631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimPoser aimPoser;

		[Token(Token = "0x4000632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AimIK aim;

		[Token(Token = "0x4000633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LookAtIK lookAt;

		[Token(Token = "0x4000634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Animator animator;

		[Token(Token = "0x4000635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float crossfadeTime;

		[Token(Token = "0x4000636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float minAimDistance;

		[Token(Token = "0x4000637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AimPoser.Pose aimPose;

		[Token(Token = "0x4000638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AimPoser.Pose lastPose;

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0xACBA28", Offset = "0xACBA28", VA = "0xACBA28")]
		private void Start()
		{
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0xACBA60", Offset = "0xACBA60", VA = "0xACBA60")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0xACBBAC", Offset = "0xACBBAC", VA = "0xACBBAC")]
		private void Pose()
		{
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0xACBD38", Offset = "0xACBD38", VA = "0xACBD38")]
		private void LimitAimTarget()
		{
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0xACBF1C", Offset = "0xACBF1C", VA = "0xACBF1C")]
		private void DirectCrossFade(string state, float target)
		{
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0xACBFAC", Offset = "0xACBFAC", VA = "0xACBFAC")]
		public SimpleAimingSystem()
		{
		}
	}
	[Token(Token = "0x20000D0")]
	public class TerrainOffset : MonoBehaviour
	{
		[Token(Token = "0x4000639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x400063A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 raycastOffset;

		[Token(Token = "0x400063B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public LayerMask raycastLayers;

		[Token(Token = "0x400063C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float min;

		[Token(Token = "0x400063D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float max;

		[Token(Token = "0x400063E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float lerpSpeed;

		[Token(Token = "0x400063F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private RaycastHit hit;

		[Token(Token = "0x4000640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 offset;

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0xACBFC0", Offset = "0xACBFC0", VA = "0xACBFC0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0xACC12C", Offset = "0xACC12C", VA = "0xACC12C")]
		private Vector3 GetGroundHeightOffset(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0xACC328", Offset = "0xACC328", VA = "0xACC328")]
		public TerrainOffset()
		{
		}
	}
	[Token(Token = "0x20000D1")]
	public class BipedIKvsAnimatorIK : MonoBehaviour
	{
		[Token(Token = "0x4000641")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Animator animator;

		[Token(Token = "0x4000642")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BipedIK bipedIK;

		[Token(Token = "0x4000643")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform lookAtTargetBiped;

		[Token(Token = "0x4000644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform lookAtTargetAnimator;

		[Token(Token = "0x4000645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float lookAtWeight;

		[Token(Token = "0x4000646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float lookAtBodyWeight;

		[Token(Token = "0x4000647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float lookAtHeadWeight;

		[Token(Token = "0x4000648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float lookAtEyesWeight;

		[Token(Token = "0x4000649")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float lookAtClampWeight;

		[Token(Token = "0x400064A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float lookAtClampWeightHead;

		[Token(Token = "0x400064B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float lookAtClampWeightEyes;

		[Token(Token = "0x400064C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform footTargetBiped;

		[Token(Token = "0x400064D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform footTargetAnimator;

		[Token(Token = "0x400064E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float footPositionWeight;

		[Token(Token = "0x400064F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float footRotationWeight;

		[Token(Token = "0x4000650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform handTargetBiped;

		[Token(Token = "0x4000651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform handTargetAnimator;

		[Token(Token = "0x4000652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float handPositionWeight;

		[Token(Token = "0x4000653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public float handRotationWeight;

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0xACC358", Offset = "0xACC358", VA = "0xACC358")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0xACC784", Offset = "0xACC784", VA = "0xACC784")]
		public BipedIKvsAnimatorIK()
		{
		}
	}
	[Token(Token = "0x20000D2")]
	public class MechSpider : MonoBehaviour
	{
		[Token(Token = "0x4000654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LayerMask raycastLayers;

		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float scale;

		[Token(Token = "0x4000656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform body;

		[Token(Token = "0x4000657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MechSpiderLeg[] legs;

		[Token(Token = "0x4000658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float legRotationWeight;

		[Token(Token = "0x4000659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float rootPositionSpeed;

		[Token(Token = "0x400065A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float rootRotationSpeed;

		[Token(Token = "0x400065B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float breatheSpeed;

		[Token(Token = "0x400065C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float breatheMagnitude;

		[Token(Token = "0x400065D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float height;

		[Token(Token = "0x400065E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float minHeight;

		[Token(Token = "0x400065F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float raycastHeight;

		[Token(Token = "0x4000660")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float raycastDistance;

		[Token(Token = "0x4000661")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000662")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 defaultBodyLocalPosition;

		[Token(Token = "0x4000663")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float sine;

		[Token(Token = "0x4000664")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RaycastHit rootHit;

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0xACC7A4", Offset = "0xACC7A4", VA = "0xACC7A4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0xACD0C0", Offset = "0xACD0C0", VA = "0xACD0C0")]
		private Vector3 GetLegCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0xACCE3C", Offset = "0xACCE3C", VA = "0xACCE3C")]
		private Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0xACD1D0", Offset = "0xACD1D0", VA = "0xACD1D0")]
		public MechSpider()
		{
		}
	}
	[Token(Token = "0x20000D3")]
	public class MechSpiderController : MonoBehaviour
	{
		[Token(Token = "0x4000665")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x4000666")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform cameraTransform;

		[Token(Token = "0x4000667")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float speed;

		[Token(Token = "0x4000668")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float turnSpeed;

		[Token(Token = "0x170000A3")]
		public Vector3 inputVector
		{
			[Token(Token = "0x6000603")]
			[Address(RVA = "0xACD1FC", Offset = "0xACD1FC", VA = "0xACD1FC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0xACD27C", Offset = "0xACD27C", VA = "0xACD27C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0xACD5C0", Offset = "0xACD5C0", VA = "0xACD5C0")]
		public MechSpiderController()
		{
		}
	}
	[Token(Token = "0x20000D4")]
	public class MechSpiderLeg : MonoBehaviour
	{
		[Token(Token = "0x4000669")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x400066A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MechSpiderLeg unSync;

		[Token(Token = "0x400066B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 offset;

		[Token(Token = "0x400066C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float minDelay;

		[Token(Token = "0x400066D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float maxOffset;

		[Token(Token = "0x400066E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float stepSpeed;

		[Token(Token = "0x400066F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float footHeight;

		[Token(Token = "0x4000670")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float velocityPrediction;

		[Token(Token = "0x4000671")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float raycastFocus;

		[Token(Token = "0x4000672")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve yOffset;

		[Token(Token = "0x4000673")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform foot;

		[Token(Token = "0x4000674")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 footUpAxis;

		[Token(Token = "0x4000675")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float footRotationSpeed;

		[Token(Token = "0x4000676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public ParticleSystem sand;

		[Token(Token = "0x4000677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private IK ik;

		[Token(Token = "0x4000678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float stepProgress;

		[Token(Token = "0x4000679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float lastStepTime;

		[Token(Token = "0x400067A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 defaultPosition;

		[Token(Token = "0x400067B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private RaycastHit hit;

		[Token(Token = "0x400067C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Quaternion lastFootLocalRotation;

		[Token(Token = "0x400067D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Vector3 smoothHitNormal;

		[Token(Token = "0x400067E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 lastStepPosition;

		[Token(Token = "0x170000A4")]
		public bool isStepping
		{
			[Token(Token = "0x6000606")]
			[Address(RVA = "0xACD5D4", Offset = "0xACD5D4", VA = "0xACD5D4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A5")]
		public Vector3 position
		{
			[Token(Token = "0x6000607")]
			[Address(RVA = "0xACD1A0", Offset = "0xACD1A0", VA = "0xACD1A0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000608")]
			[Address(RVA = "0xACD5E8", Offset = "0xACD5E8", VA = "0xACD5E8")]
			set
			{
			}
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0xACD634", Offset = "0xACD634", VA = "0xACD634")]
		private void Awake()
		{
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0xACD8B4", Offset = "0xACD8B4", VA = "0xACD8B4")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0xACDA8C", Offset = "0xACDA8C", VA = "0xACDA8C")]
		private void Start()
		{
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0xACDCB0", Offset = "0xACDCB0", VA = "0xACDCB0")]
		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0xACDF40", Offset = "0xACDF40", VA = "0xACDF40")]
		private void UpdatePosition(float distance)
		{
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0xACE0A8", Offset = "0xACE0A8", VA = "0xACE0A8")]
		private void Update()
		{
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0xACDC00", Offset = "0xACDC00", VA = "0xACDC00")]
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition)
		{
			return null;
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0xACE308", Offset = "0xACE308", VA = "0xACE308")]
		public MechSpiderLeg()
		{
		}
	}
	[Token(Token = "0x20000D6")]
	public class MechSpiderParticles : MonoBehaviour
	{
		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpiderController mechSpiderController;

		[Token(Token = "0x4000685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ParticleSystem particles;

		[Token(Token = "0x6000617")]
		[Address(RVA = "0xACE698", Offset = "0xACE698", VA = "0xACE698")]
		private void Start()
		{
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0xACE774", Offset = "0xACE774", VA = "0xACE774")]
		private void Update()
		{
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0xACE9E8", Offset = "0xACE9E8", VA = "0xACE9E8")]
		public MechSpiderParticles()
		{
		}
	}
	[Token(Token = "0x20000D7")]
	public class AnimationWarping : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000D8")]
		public struct Warp
		{
			[Token(Token = "0x400068A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int animationLayer;

			[Token(Token = "0x400068B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string animationState;

			[Token(Token = "0x400068C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AnimationCurve weightCurve;

			[Token(Token = "0x400068D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform warpFrom;

			[Token(Token = "0x400068E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform warpTo;

			[Token(Token = "0x400068F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public FullBodyBipedEffector effector;
		}

		[Serializable]
		[Token(Token = "0x20000D9")]
		public enum EffectorMode
		{
			[Token(Token = "0x4000691")]
			PositionOffset,
			[Token(Token = "0x4000692")]
			Position
		}

		[Token(Token = "0x4000686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Animator animator;

		[Token(Token = "0x4000687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public EffectorMode effectorMode;

		[Token(Token = "0x4000688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Warp[] warps;

		[Token(Token = "0x4000689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private EffectorMode lastMode;

		[Token(Token = "0x600061A")]
		[Address(RVA = "0xACE9F0", Offset = "0xACE9F0", VA = "0xACE9F0", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0xACEA1C", Offset = "0xACEA1C", VA = "0xACEA1C")]
		public float GetWarpWeight(int warpIndex)
		{
			return default(float);
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0xACEC34", Offset = "0xACEC34", VA = "0xACEC34", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0xACEEEC", Offset = "0xACEEEC", VA = "0xACEEEC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0xACEF80", Offset = "0xACEF80", VA = "0xACEF80")]
		public AnimationWarping()
		{
		}
	}
	[Token(Token = "0x20000DA")]
	[RequireComponent(typeof(Animator))]
	public class AnimatorController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x4000693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotateSpeed;

		[Token(Token = "0x4000694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float blendSpeed;

		[Token(Token = "0x4000695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float maxAngle;

		[Token(Token = "0x4000696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float moveSpeed;

		[Token(Token = "0x4000697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float rootMotionWeight;

		[Token(Token = "0x4000698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Animator animator;

		[Token(Token = "0x4000699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Vector3 moveBlend;

		[Token(Token = "0x400069A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		protected Vector3 moveInput;

		[Token(Token = "0x400069B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Vector3 velocity;

		[Token(Token = "0x600061F")]
		[Address(RVA = "0xACEF90", Offset = "0xACEF90", VA = "0xACEF90", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0xACEFE8", Offset = "0xACEFE8", VA = "0xACEFE8")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0xACF1F0", Offset = "0xACF1F0", VA = "0xACF1F0", Slot = "5")]
		public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0xACF418", Offset = "0xACF418", VA = "0xACF418")]
		public AnimatorController3rdPerson()
		{
		}
	}
	[Token(Token = "0x20000DB")]
	[RequireComponent(typeof(FullBodyBipedIK))]
	[RequireComponent(typeof(AimIK))]
	public class AnimatorController3rdPersonIK : AnimatorController3rdPerson
	{
		[Token(Token = "0x400069C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float headLookWeight;

		[Token(Token = "0x400069D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 gunHoldOffset;

		[Token(Token = "0x400069E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x400069F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Recoil recoil;

		[Token(Token = "0x40006A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private AimIK aim;

		[Token(Token = "0x40006A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40006A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 headLookAxis;

		[Token(Token = "0x40006A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 leftHandPosRelToRightHand;

		[Token(Token = "0x40006A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Quaternion leftHandRotRelToRightHand;

		[Token(Token = "0x40006A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 aimTarget;

		[Token(Token = "0x40006A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x6000623")]
		[Address(RVA = "0xACF42C", Offset = "0xACF42C", VA = "0xACF42C", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0xACF600", Offset = "0xACF600", VA = "0xACF600", Slot = "5")]
		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0xACF670", Offset = "0xACF670", VA = "0xACF670")]
		private void Read()
		{
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0xACF7A8", Offset = "0xACF7A8", VA = "0xACF7A8")]
		private void AimIK()
		{
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0xACF804", Offset = "0xACF804", VA = "0xACF804")]
		private void FBBIK()
		{
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0xACFE6C", Offset = "0xACFE6C", VA = "0xACFE6C")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0xACFC80", Offset = "0xACFC80", VA = "0xACFC80")]
		private void HeadLookAt(Vector3 lookAtTarget)
		{
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0xAD0110", Offset = "0xAD0110", VA = "0xAD0110")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0xAD023C", Offset = "0xAD023C", VA = "0xAD023C")]
		public AnimatorController3rdPersonIK()
		{
		}
	}
	[Token(Token = "0x20000DC")]
	[RequireComponent(typeof(FullBodyBipedIK))]
	public class CharacterAnimationThirdPersonIK : CharacterAnimationThirdPerson
	{
		[Token(Token = "0x40006A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x600062C")]
		[Address(RVA = "0xAD0258", Offset = "0xAD0258", VA = "0xAD0258", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0xAD02BC", Offset = "0xAD02BC", VA = "0xAD02BC", Slot = "7")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0xAD05F8", Offset = "0xAD05F8", VA = "0xAD05F8")]
		private void RotateEffector(IKEffector effector, Quaternion rotation, float mlp)
		{
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0xAD06E8", Offset = "0xAD06E8", VA = "0xAD06E8")]
		public CharacterAnimationThirdPersonIK()
		{
		}
	}
	[Token(Token = "0x20000DD")]
	[RequireComponent(typeof(AnimatorController3rdPerson))]
	public class CharacterController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x40006A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CameraController cam;

		[Token(Token = "0x40006A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AnimatorController3rdPerson animatorController;

		[Token(Token = "0x170000A8")]
		private static Vector3 inputVector
		{
			[Token(Token = "0x6000632")]
			[Address(RVA = "0xAD0950", Offset = "0xAD0950", VA = "0xAD0950")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000A9")]
		private static Vector3 inputVectorRaw
		{
			[Token(Token = "0x6000633")]
			[Address(RVA = "0xAD09D0", Offset = "0xAD09D0", VA = "0xAD09D0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0xAD06F0", Offset = "0xAD06F0", VA = "0xAD06F0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0xAD0760", Offset = "0xAD0760", VA = "0xAD0760")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0xAD0A50", Offset = "0xAD0A50", VA = "0xAD0A50")]
		public CharacterController3rdPerson()
		{
		}
	}
	[Token(Token = "0x20000DE")]
	public class EffectorOffset : OffsetModifier
	{
		[Token(Token = "0x40006AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float handsMaintainRelativePositionWeight;

		[Token(Token = "0x40006AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 bodyOffset;

		[Token(Token = "0x40006AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 leftShoulderOffset;

		[Token(Token = "0x40006AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rightShoulderOffset;

		[Token(Token = "0x40006AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 leftThighOffset;

		[Token(Token = "0x40006AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 rightThighOffset;

		[Token(Token = "0x40006B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x40006B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Vector3 rightHandOffset;

		[Token(Token = "0x40006B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Vector3 leftFootOffset;

		[Token(Token = "0x40006B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 rightFootOffset;

		[Token(Token = "0x6000635")]
		[Address(RVA = "0xAD0A58", Offset = "0xAD0A58", VA = "0xAD0A58", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0xAD0EB4", Offset = "0xAD0EB4", VA = "0xAD0EB4")]
		public EffectorOffset()
		{
		}
	}
	[Token(Token = "0x20000DF")]
	public class ExplosionDemo : MonoBehaviour
	{
		[Token(Token = "0x40006B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SimpleLocomotion character;

		[Token(Token = "0x40006B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float forceMlp;

		[Token(Token = "0x40006B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float upForce;

		[Token(Token = "0x40006B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weightFalloffSpeed;

		[Token(Token = "0x40006B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve weightFalloff;

		[Token(Token = "0x40006B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve explosionForceByDistance;

		[Token(Token = "0x40006BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve scale;

		[Token(Token = "0x40006BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float weight;

		[Token(Token = "0x40006BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 defaultScale;

		[Token(Token = "0x40006BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Rigidbody r;

		[Token(Token = "0x40006BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x6000637")]
		[Address(RVA = "0xAD0EC4", Offset = "0xAD0EC4", VA = "0xAD0EC4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0xAD0F7C", Offset = "0xAD0F7C", VA = "0xAD0F7C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0xAD13D8", Offset = "0xAD13D8", VA = "0xAD13D8")]
		private void SetEffectorWeights(float w)
		{
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0xAD1478", Offset = "0xAD1478", VA = "0xAD1478")]
		public ExplosionDemo()
		{
		}
	}
	[Token(Token = "0x20000E0")]
	public class FBBIKSettings : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000E1")]
		public class Limb
		{
			[Token(Token = "0x40006C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FBIKChain.Smoothing reachSmoothing;

			[Token(Token = "0x40006C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float maintainRelativePositionWeight;

			[Token(Token = "0x40006C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float mappingWeight;

			[Token(Token = "0x600063F")]
			[Address(RVA = "0xAD160C", Offset = "0xAD160C", VA = "0xAD160C")]
			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver)
			{
			}

			[Token(Token = "0x6000640")]
			[Address(RVA = "0xAD1730", Offset = "0xAD1730", VA = "0xAD1730")]
			public Limb()
			{
			}
		}

		[Token(Token = "0x40006BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40006C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool disableAfterStart;

		[Token(Token = "0x40006C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Limb leftArm;

		[Token(Token = "0x40006C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Limb rightArm;

		[Token(Token = "0x40006C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Limb leftLeg;

		[Token(Token = "0x40006C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Limb rightLeg;

		[Token(Token = "0x40006C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float rootPin;

		[Token(Token = "0x40006C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool bodyEffectChildNodes;

		[Token(Token = "0x600063B")]
		[Address(RVA = "0xAD14E8", Offset = "0xAD14E8", VA = "0xAD14E8")]
		public void UpdateSettings()
		{
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0xAD1684", Offset = "0xAD1684", VA = "0xAD1684")]
		private void Start()
		{
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0xAD171C", Offset = "0xAD171C", VA = "0xAD171C")]
		private void Update()
		{
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0xAD1720", Offset = "0xAD1720", VA = "0xAD1720")]
		public FBBIKSettings()
		{
		}
	}
	[Token(Token = "0x20000E2")]
	public class FBIKBendGoal : MonoBehaviour
	{
		[Token(Token = "0x40006CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40006CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedChain chain;

		[Token(Token = "0x40006CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float weight;

		[Token(Token = "0x6000641")]
		[Address(RVA = "0xAD1740", Offset = "0xAD1740", VA = "0xAD1740")]
		private void Start()
		{
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0xAD17A8", Offset = "0xAD17A8", VA = "0xAD17A8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0xAD187C", Offset = "0xAD187C", VA = "0xAD187C")]
		public FBIKBendGoal()
		{
		}
	}
	[Token(Token = "0x20000E3")]
	public class FBIKBoxing : MonoBehaviour
	{
		[Token(Token = "0x40006CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x40006CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform pin;

		[Token(Token = "0x40006CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40006D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AimIK aim;

		[Token(Token = "0x40006D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float weight;

		[Token(Token = "0x40006D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public FullBodyBipedEffector effector;

		[Token(Token = "0x40006D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve aimWeight;

		[Token(Token = "0x40006D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Animator animator;

		[Token(Token = "0x6000644")]
		[Address(RVA = "0xAD1884", Offset = "0xAD1884", VA = "0xAD1884")]
		private void Start()
		{
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0xAD18DC", Offset = "0xAD18DC", VA = "0xAD18DC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0xAD1A74", Offset = "0xAD1A74", VA = "0xAD1A74")]
		public FBIKBoxing()
		{
		}
	}
	[Token(Token = "0x20000E4")]
	public class FBIKHandsOnProp : MonoBehaviour
	{
		[Token(Token = "0x40006D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40006D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool leftHanded;

		[Token(Token = "0x6000647")]
		[Address(RVA = "0xAD1A7C", Offset = "0xAD1A7C", VA = "0xAD1A7C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0xAD1B5C", Offset = "0xAD1B5C", VA = "0xAD1B5C")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0xAD1BE8", Offset = "0xAD1BE8", VA = "0xAD1BE8")]
		private void HandsOnProp(IKEffector mainHand, IKEffector otherHand)
		{
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0xAD20BC", Offset = "0xAD20BC", VA = "0xAD20BC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0xAD21E8", Offset = "0xAD21E8", VA = "0xAD21E8")]
		public FBIKHandsOnProp()
		{
		}
	}
	[Token(Token = "0x20000E5")]
	public class FPSAiming : MonoBehaviour
	{
		[Token(Token = "0x40006D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float aimWeight;

		[Token(Token = "0x40006D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float sightWeight;

		[Token(Token = "0x40006D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float maxAngle;

		[Token(Token = "0x40006DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 aimOffset;

		[Token(Token = "0x40006DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool animatePhysics;

		[Token(Token = "0x40006DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform gun;

		[Token(Token = "0x40006DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform gunTarget;

		[Token(Token = "0x40006DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40006DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AimIK gunAim;

		[Token(Token = "0x40006E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public CameraControllerFPS cam;

		[Token(Token = "0x40006E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Recoil recoil;

		[Token(Token = "0x40006E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float cameraRecoilWeight;

		[Token(Token = "0x40006E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 gunTargetDefaultLocalPosition;

		[Token(Token = "0x40006E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Vector3 gunTargetDefaultLocalRotation;

		[Token(Token = "0x40006E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 camDefaultLocalPosition;

		[Token(Token = "0x40006E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 camRelativeToGunTarget;

		[Token(Token = "0x40006E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private bool updateFrame;

		[Token(Token = "0x600064C")]
		[Address(RVA = "0xAD21F0", Offset = "0xAD21F0", VA = "0xAD21F0")]
		private void Start()
		{
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0xAD2350", Offset = "0xAD2350", VA = "0xAD2350")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0xAD235C", Offset = "0xAD235C", VA = "0xAD235C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0xAD261C", Offset = "0xAD261C", VA = "0xAD261C")]
		private void Aiming()
		{
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0xAD27A8", Offset = "0xAD27A8", VA = "0xAD27A8")]
		private void LookDownTheSight()
		{
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0xAD2420", Offset = "0xAD2420", VA = "0xAD2420")]
		private void RotateCharacter()
		{
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0xAD3470", Offset = "0xAD3470", VA = "0xAD3470")]
		public FPSAiming()
		{
		}
	}
	[Token(Token = "0x20000E6")]
	[RequireComponent(typeof(Animator))]
	[RequireComponent(typeof(FPSAiming))]
	public class FPSCharacter : MonoBehaviour
	{
		[Token(Token = "0x40006E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float walkSpeed;

		[Token(Token = "0x40006E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float sVel;

		[Token(Token = "0x40006EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x40006EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private FPSAiming FPSAiming;

		[Token(Token = "0x6000653")]
		[Address(RVA = "0xAD3490", Offset = "0xAD3490", VA = "0xAD3490")]
		private void Start()
		{
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0xAD3520", Offset = "0xAD3520", VA = "0xAD3520")]
		private void Update()
		{
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0xAD361C", Offset = "0xAD361C", VA = "0xAD361C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0xAD36C8", Offset = "0xAD36C8", VA = "0xAD36C8")]
		public FPSCharacter()
		{
		}
	}
	[Token(Token = "0x20000E7")]
	public class HitReactionTrigger : MonoBehaviour
	{
		[Token(Token = "0x40006EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HitReaction hitReaction;

		[Token(Token = "0x40006ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float hitForce;

		[Token(Token = "0x40006EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x6000657")]
		[Address(RVA = "0xAD36D8", Offset = "0xAD36D8", VA = "0xAD36D8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0xAD3828", Offset = "0xAD3828", VA = "0xAD3828")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0xAD398C", Offset = "0xAD398C", VA = "0xAD398C")]
		public HitReactionTrigger()
		{
		}
	}
	[Token(Token = "0x20000E8")]
	public class HoldingHands : MonoBehaviour
	{
		[Token(Token = "0x40006EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK rightHandChar;

		[Token(Token = "0x40006F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedIK leftHandChar;

		[Token(Token = "0x40006F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform rightHandTarget;

		[Token(Token = "0x40006F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftHandTarget;

		[Token(Token = "0x40006F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float crossFade;

		[Token(Token = "0x40006F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float speed;

		[Token(Token = "0x40006F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x40006F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandRotation;

		[Token(Token = "0x600065A")]
		[Address(RVA = "0xAD399C", Offset = "0xAD399C", VA = "0xAD399C")]
		private void Start()
		{
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0xAD3B68", Offset = "0xAD3B68", VA = "0xAD3B68")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0xAD3F78", Offset = "0xAD3F78", VA = "0xAD3F78")]
		public HoldingHands()
		{
		}
	}
	[Token(Token = "0x20000E9")]
	public class InteractionC2CDemo : MonoBehaviour
	{
		[Token(Token = "0x40006F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem character1;

		[Token(Token = "0x40006F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem character2;

		[Token(Token = "0x40006F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject handShake;

		[Token(Token = "0x600065D")]
		[Address(RVA = "0xAD3F88", Offset = "0xAD3F88", VA = "0xAD3F88")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0xAD4070", Offset = "0xAD4070", VA = "0xAD4070")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0xAD415C", Offset = "0xAD415C", VA = "0xAD415C")]
		public InteractionC2CDemo()
		{
		}
	}
	[Token(Token = "0x20000EA")]
	public class InteractionDemo : MonoBehaviour
	{
		[Token(Token = "0x40006FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x40006FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool interrupt;

		[Token(Token = "0x40006FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject ball;

		[Token(Token = "0x40006FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public InteractionObject benchMain;

		[Token(Token = "0x40006FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public InteractionObject benchHands;

		[Token(Token = "0x40006FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionObject button;

		[Token(Token = "0x4000700")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public InteractionObject cigarette;

		[Token(Token = "0x4000701")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public InteractionObject door;

		[Token(Token = "0x4000702")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool isSitting;

		[Token(Token = "0x6000660")]
		[Address(RVA = "0xAD4164", Offset = "0xAD4164", VA = "0xAD4164")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0xAD4664", Offset = "0xAD4664", VA = "0xAD4664")]
		public InteractionDemo()
		{
		}
	}
	[Token(Token = "0x20000EB")]
	[RequireComponent(typeof(InteractionSystem))]
	public class InteractionSystemTestGUI : MonoBehaviour
	{
		[Token(Token = "0x4000703")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionObject interactionObject;

		[Token(Token = "0x4000704")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedEffector[] effectors;

		[Token(Token = "0x4000705")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x6000662")]
		[Address(RVA = "0xAD466C", Offset = "0xAD466C", VA = "0xAD466C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0xAD46C4", Offset = "0xAD46C4", VA = "0xAD46C4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0xAD4970", Offset = "0xAD4970", VA = "0xAD4970")]
		public InteractionSystemTestGUI()
		{
		}
	}
	[Token(Token = "0x20000EC")]
	public class KissingRig : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000ED")]
		public class Partner
		{
			[Token(Token = "0x400070A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedIK ik;

			[Token(Token = "0x400070B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform mouth;

			[Token(Token = "0x400070C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform mouthTarget;

			[Token(Token = "0x400070D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform touchTargetLeftHand;

			[Token(Token = "0x400070E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Transform touchTargetRightHand;

			[Token(Token = "0x400070F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float bodyWeightHorizontal;

			[Token(Token = "0x4000710")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float bodyWeightVertical;

			[Token(Token = "0x4000711")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public float neckRotationWeight;

			[Token(Token = "0x4000712")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public float headTiltAngle;

			[Token(Token = "0x4000713")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 headTiltAxis;

			[Token(Token = "0x4000714")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Quaternion neckRotation;

			[Token(Token = "0x170000AA")]
			private Transform neck
			{
				[Token(Token = "0x600066A")]
				[Address(RVA = "0xAD517C", Offset = "0xAD517C", VA = "0xAD517C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000668")]
			[Address(RVA = "0xAD49A0", Offset = "0xAD49A0", VA = "0xAD49A0")]
			public void Initiate()
			{
			}

			[Token(Token = "0x6000669")]
			[Address(RVA = "0xAD4A1C", Offset = "0xAD4A1C", VA = "0xAD4A1C")]
			public void Update(float weight)
			{
			}

			[Token(Token = "0x600066B")]
			[Address(RVA = "0xAD5014", Offset = "0xAD5014", VA = "0xAD5014")]
			private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight)
			{
			}

			[Token(Token = "0x600066C")]
			[Address(RVA = "0xAD51C8", Offset = "0xAD51C8", VA = "0xAD51C8")]
			public Partner()
			{
			}
		}

		[Token(Token = "0x4000706")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Partner partner1;

		[Token(Token = "0x4000707")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Partner partner2;

		[Token(Token = "0x4000708")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weight;

		[Token(Token = "0x4000709")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int iterations;

		[Token(Token = "0x6000665")]
		[Address(RVA = "0xAD4978", Offset = "0xAD4978", VA = "0xAD4978")]
		private void Start()
		{
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0xAD49C0", Offset = "0xAD49C0", VA = "0xAD49C0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0xAD5004", Offset = "0xAD5004", VA = "0xAD5004")]
		public KissingRig()
		{
		}
	}
	[Token(Token = "0x20000EE")]
	public class MotionAbsorb : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000EF")]
		public enum Mode
		{
			[Token(Token = "0x400071D")]
			Position,
			[Token(Token = "0x400071E")]
			PositionOffset
		}

		[Serializable]
		[Token(Token = "0x20000F0")]
		public class Absorber
		{
			[Token(Token = "0x400071F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000720")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float weight;

			[Token(Token = "0x4000721")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Vector3 position;

			[Token(Token = "0x4000722")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private Quaternion rotation;

			[Token(Token = "0x4000723")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private IKEffector e;

			[Token(Token = "0x6000673")]
			[Address(RVA = "0xAD5354", Offset = "0xAD5354", VA = "0xAD5354")]
			public void SetToBone(IKSolverFullBodyBiped solver, Mode mode)
			{
			}

			[Token(Token = "0x6000674")]
			[Address(RVA = "0xAD553C", Offset = "0xAD553C", VA = "0xAD553C")]
			public void UpdateEffectorWeights(float w)
			{
			}

			[Token(Token = "0x6000675")]
			[Address(RVA = "0xAD5560", Offset = "0xAD5560", VA = "0xAD5560")]
			public void SetPosition(float w)
			{
			}

			[Token(Token = "0x6000676")]
			[Address(RVA = "0xAD5670", Offset = "0xAD5670", VA = "0xAD5670")]
			public void SetRotation(float w)
			{
			}

			[Token(Token = "0x6000677")]
			[Address(RVA = "0xAD5828", Offset = "0xAD5828", VA = "0xAD5828")]
			public Absorber()
			{
			}
		}

		[Token(Token = "0x4000715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Mode mode;

		[Token(Token = "0x4000716")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Absorber[] absorbers;

		[Token(Token = "0x4000717")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve falloff;

		[Token(Token = "0x4000718")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float falloffSpeed;

		[Token(Token = "0x4000719")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float timer;

		[Token(Token = "0x400071A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float w;

		[Token(Token = "0x400071B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Mode initialMode;

		[Token(Token = "0x600066D")]
		[Address(RVA = "0xAD51DC", Offset = "0xAD51DC", VA = "0xAD51DC", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0xAD52D4", Offset = "0xAD52D4", VA = "0xAD52D4")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0xAD5430", Offset = "0xAD5430", VA = "0xAD5430", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0xAD55F4", Offset = "0xAD55F4", VA = "0xAD55F4")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0xAD56E0", Offset = "0xAD56E0", VA = "0xAD56E0", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0xAD5818", Offset = "0xAD5818", VA = "0xAD5818")]
		public MotionAbsorb()
		{
		}
	}
	[Token(Token = "0x20000F1")]
	public class MotionAbsorbCharacter : MonoBehaviour
	{
		[Token(Token = "0x4000724")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Animator animator;

		[Token(Token = "0x4000725")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MotionAbsorb motionAbsorb;

		[Token(Token = "0x4000726")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform cube;

		[Token(Token = "0x4000727")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float cubeRandomPosition;

		[Token(Token = "0x4000728")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve motionAbsorbWeight;

		[Token(Token = "0x4000729")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 cubeDefaultPosition;

		[Token(Token = "0x400072A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorStateInfo info;

		[Token(Token = "0x400072B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Rigidbody cubeRigidbody;

		[Token(Token = "0x6000678")]
		[Address(RVA = "0xAD5888", Offset = "0xAD5888", VA = "0xAD5888")]
		private void Start()
		{
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0xAD5900", Offset = "0xAD5900", VA = "0xAD5900")]
		private void Update()
		{
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0xAD59D0", Offset = "0xAD59D0", VA = "0xAD59D0")]
		private void SwingStart()
		{
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0xAD5B18", Offset = "0xAD5B18", VA = "0xAD5B18")]
		public MotionAbsorbCharacter()
		{
		}
	}
	[Token(Token = "0x20000F2")]
	public class OffsetEffector : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000F3")]
		public class EffectorLink
		{
			[Token(Token = "0x400072D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x400072E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float weightMultiplier;

			[Token(Token = "0x400072F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 localPosition;

			[Token(Token = "0x600067F")]
			[Address(RVA = "0xAD5D98", Offset = "0xAD5D98", VA = "0xAD5D98")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x400072C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x600067C")]
		[Address(RVA = "0xAD5B2C", Offset = "0xAD5B2C", VA = "0xAD5B2C", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0xAD5C18", Offset = "0xAD5C18", VA = "0xAD5C18", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0xAD5D90", Offset = "0xAD5D90", VA = "0xAD5D90")]
		public OffsetEffector()
		{
		}
	}
	[Token(Token = "0x20000F4")]
	[RequireComponent(typeof(FullBodyBipedIK))]
	public class PendulumExample : MonoBehaviour
	{
		[Token(Token = "0x4000730")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float weight;

		[Token(Token = "0x4000731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float hangingDistanceMlp;

		[Token(Token = "0x4000732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 rootTargetPosition;

		[Token(Token = "0x4000733")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Quaternion rootTargetRotation;

		[Token(Token = "0x4000734")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform target;

		[Token(Token = "0x4000735")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform leftHandTarget;

		[Token(Token = "0x4000736")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform rightHandTarget;

		[Token(Token = "0x4000737")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftFootTarget;

		[Token(Token = "0x4000738")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform rightFootTarget;

		[Token(Token = "0x4000739")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform pelvisTarget;

		[Token(Token = "0x400073A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform bodyTarget;

		[Token(Token = "0x400073B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform headTarget;

		[Token(Token = "0x400073C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Vector3 pelvisDownAxis;

		[Token(Token = "0x400073D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x400073E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion rootRelativeToPelvis;

		[Token(Token = "0x400073F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 pelvisToRoot;

		[Token(Token = "0x4000740")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float lastWeight;

		[Token(Token = "0x6000680")]
		[Address(RVA = "0xAD5DA8", Offset = "0xAD5DA8", VA = "0xAD5DA8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0xAD60BC", Offset = "0xAD60BC", VA = "0xAD60BC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0xAD68B8", Offset = "0xAD68B8", VA = "0xAD68B8")]
		public PendulumExample()
		{
		}
	}
	[Token(Token = "0x20000F5")]
	public abstract class PickUp2Handed : MonoBehaviour
	{
		[Token(Token = "0x4000741")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int GUIspace;

		[Token(Token = "0x4000742")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x4000743")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject obj;

		[Token(Token = "0x4000744")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform pivot;

		[Token(Token = "0x4000745")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform holdPoint;

		[Token(Token = "0x4000746")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float pickUpTime;

		[Token(Token = "0x4000747")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float holdWeight;

		[Token(Token = "0x4000748")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float holdWeightVel;

		[Token(Token = "0x4000749")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x400074A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x170000AB")]
		private bool holding
		{
			[Token(Token = "0x600068A")]
			[Address(RVA = "0xAD6B38", Offset = "0xAD6B38", VA = "0xAD6B38")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0xAD6924", Offset = "0xAD6924", VA = "0xAD6924")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000684")]
		protected abstract void RotatePivot();

		[Token(Token = "0x6000685")]
		[Address(RVA = "0xAD6B58", Offset = "0xAD6B58", VA = "0xAD6B58")]
		private void Start()
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0xAD6D48", Offset = "0xAD6D48", VA = "0xAD6D48")]
		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0xAD6EB8", Offset = "0xAD6EB8", VA = "0xAD6EB8")]
		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0xAD6F88", Offset = "0xAD6F88", VA = "0xAD6F88")]
		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0xAD70A8", Offset = "0xAD70A8", VA = "0xAD70A8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0xAD721C", Offset = "0xAD721C", VA = "0xAD721C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0xAD7458", Offset = "0xAD7458", VA = "0xAD7458")]
		protected PickUp2Handed()
		{
		}
	}
	[Token(Token = "0x20000F6")]
	public class PickUpBox : PickUp2Handed
	{
		[Token(Token = "0x600068D")]
		[Address(RVA = "0xAD746C", Offset = "0xAD746C", VA = "0xAD746C", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0xAD764C", Offset = "0xAD764C", VA = "0xAD764C")]
		public PickUpBox()
		{
		}
	}
	[Token(Token = "0x20000F7")]
	public class PickUpSphere : PickUp2Handed
	{
		[Token(Token = "0x600068F")]
		[Address(RVA = "0xAD7660", Offset = "0xAD7660", VA = "0xAD7660", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0xAD7774", Offset = "0xAD7774", VA = "0xAD7774")]
		public PickUpSphere()
		{
		}
	}
	[Token(Token = "0x20000F8")]
	public class RagdollUtilityDemo : MonoBehaviour
	{
		[Token(Token = "0x400074B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RagdollUtility ragdollUtility;

		[Token(Token = "0x400074C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform root;

		[Token(Token = "0x400074D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Rigidbody pelvis;

		[Token(Token = "0x6000691")]
		[Address(RVA = "0xAD7788", Offset = "0xAD7788", VA = "0xAD7788")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0xAD7820", Offset = "0xAD7820", VA = "0xAD7820")]
		private void Update()
		{
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0xAD7938", Offset = "0xAD7938", VA = "0xAD7938")]
		public RagdollUtilityDemo()
		{
		}
	}
	[Token(Token = "0x20000F9")]
	[RequireComponent(typeof(Recoil))]
	public class RecoilTest : MonoBehaviour
	{
		[Token(Token = "0x400074E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float magnitude;

		[Token(Token = "0x400074F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Recoil recoil;

		[Token(Token = "0x6000694")]
		[Address(RVA = "0xAD7940", Offset = "0xAD7940", VA = "0xAD7940")]
		private void Start()
		{
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0xAD7998", Offset = "0xAD7998", VA = "0xAD7998")]
		private void Update()
		{
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0xAD79E4", Offset = "0xAD79E4", VA = "0xAD79E4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0xAD7A7C", Offset = "0xAD7A7C", VA = "0xAD7A7C")]
		public RecoilTest()
		{
		}
	}
	[Token(Token = "0x20000FA")]
	public class ResetInteractionObject : MonoBehaviour
	{
		[Token(Token = "0x4000750")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float resetDelay;

		[Token(Token = "0x4000751")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector3 defaultPosition;

		[Token(Token = "0x4000752")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Quaternion defaultRotation;

		[Token(Token = "0x4000753")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform defaultParent;

		[Token(Token = "0x4000754")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody r;

		[Token(Token = "0x6000698")]
		[Address(RVA = "0xAD7A8C", Offset = "0xAD7A8C", VA = "0xAD7A8C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0xAD7B50", Offset = "0xAD7B50", VA = "0xAD7B50")]
		private void OnPickUp(Transform t)
		{
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0xAD7B8C", Offset = "0xAD7B8C", VA = "0xAD7B8C")]
		private IEnumerator ResetObject(float resetTime)
		{
			return null;
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0xAD7C38", Offset = "0xAD7C38", VA = "0xAD7C38")]
		public ResetInteractionObject()
		{
		}
	}
	[Token(Token = "0x20000FC")]
	[RequireComponent(typeof(Animator))]
	public class SoccerDemo : MonoBehaviour
	{
		[Token(Token = "0x4000759")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Animator animator;

		[Token(Token = "0x400075A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 defaultPosition;

		[Token(Token = "0x400075B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0xAD7E44", Offset = "0xAD7E44", VA = "0xAD7E44")]
		private void Start()
		{
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0xAD7EF8", Offset = "0xAD7EF8", VA = "0xAD7EF8")]
		private IEnumerator ResetDelayed()
		{
			return null;
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0xAD7F94", Offset = "0xAD7F94", VA = "0xAD7F94")]
		public SoccerDemo()
		{
		}
	}
	[Token(Token = "0x20000FE")]
	public class TouchWalls : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000FF")]
		public class EffectorLink
		{
			[Token(Token = "0x4000761")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool enabled;

			[Token(Token = "0x4000762")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000763")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public InteractionObject interactionObject;

			[Token(Token = "0x4000764")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spherecastFrom;

			[Token(Token = "0x4000765")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float spherecastRadius;

			[Token(Token = "0x4000766")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float minDistance;

			[Token(Token = "0x4000767")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public LayerMask touchLayers;

			[Token(Token = "0x4000768")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float lerpSpeed;

			[Token(Token = "0x4000769")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float minSwitchTime;

			[Token(Token = "0x400076A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float releaseDistance;

			[Token(Token = "0x400076B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool sliding;

			[Token(Token = "0x400076C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private Vector3 raycastDirectionLocal;

			[Token(Token = "0x400076D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private float raycastDistance;

			[Token(Token = "0x400076E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private bool inTouch;

			[Token(Token = "0x400076F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private RaycastHit hit;

			[Token(Token = "0x4000770")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 targetPosition;

			[Token(Token = "0x4000771")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private Quaternion targetRotation;

			[Token(Token = "0x4000772")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private bool initiated;

			[Token(Token = "0x4000773")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private float nextSwitchTime;

			[Token(Token = "0x4000774")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private float speedF;

			[Token(Token = "0x60006AF")]
			[Address(RVA = "0xAD8194", Offset = "0xAD8194", VA = "0xAD8194")]
			public void Initiate(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60006B0")]
			[Address(RVA = "0xAD8D68", Offset = "0xAD8D68", VA = "0xAD8D68")]
			private bool FindWalls(Vector3 direction)
			{
				return default(bool);
			}

			[Token(Token = "0x60006B1")]
			[Address(RVA = "0xAD859C", Offset = "0xAD859C", VA = "0xAD859C")]
			public void Update(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60006B2")]
			[Address(RVA = "0xAD8E44", Offset = "0xAD8E44", VA = "0xAD8E44")]
			private void StopTouch(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60006B3")]
			[Address(RVA = "0xAD8F28", Offset = "0xAD8F28", VA = "0xAD8F28")]
			private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x60006B4")]
			[Address(RVA = "0xAD8FB4", Offset = "0xAD8FB4", VA = "0xAD8FB4")]
			private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x60006B5")]
			[Address(RVA = "0xAD903C", Offset = "0xAD903C", VA = "0xAD903C")]
			private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x60006B6")]
			[Address(RVA = "0xAD8B54", Offset = "0xAD8B54", VA = "0xAD8B54")]
			public void Destroy(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60006B7")]
			[Address(RVA = "0xAD90C4", Offset = "0xAD90C4", VA = "0xAD90C4")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x400075F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x4000760")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0xAD8130", Offset = "0xAD8130", VA = "0xAD8130")]
		private void Start()
		{
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0xAD853C", Offset = "0xAD853C", VA = "0xAD853C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0xAD8AA4", Offset = "0xAD8AA4", VA = "0xAD8AA4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0xAD8D60", Offset = "0xAD8D60", VA = "0xAD8D60")]
		public TouchWalls()
		{
		}
	}
	[Token(Token = "0x2000100")]
	public class TransferMotion : MonoBehaviour
	{
		[Token(Token = "0x4000775")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform to;

		[Token(Token = "0x4000776")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float transferMotion;

		[Token(Token = "0x4000777")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0xAD90F8", Offset = "0xAD90F8", VA = "0xAD90F8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0xAD9128", Offset = "0xAD9128", VA = "0xAD9128")]
		private void Update()
		{
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0xAD91D8", Offset = "0xAD91D8", VA = "0xAD91D8")]
		public TransferMotion()
		{
		}
	}
	[Token(Token = "0x2000101")]
	public class TwoHandedProp : MonoBehaviour
	{
		[Token(Token = "0x4000778")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform leftHandTarget;

		[Token(Token = "0x4000779")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x400077A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 targetPosRelativeToRight;

		[Token(Token = "0x400077B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Quaternion targetRotRelativeToRight;

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0xAD91EC", Offset = "0xAD91EC", VA = "0xAD91EC")]
		private void Start()
		{
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0xAD9404", Offset = "0xAD9404", VA = "0xAD9404")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0xAD96A0", Offset = "0xAD96A0", VA = "0xAD96A0")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0xAD9768", Offset = "0xAD9768", VA = "0xAD9768")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0xAD9894", Offset = "0xAD9894", VA = "0xAD9894")]
		public TwoHandedProp()
		{
		}
	}
	[Token(Token = "0x2000102")]
	public class UserControlInteractions : UserControlThirdPerson
	{
		[Token(Token = "0x400077C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public CharacterThirdPerson character;

		[Token(Token = "0x400077D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x400077E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool disableInputInInteraction;

		[Token(Token = "0x400077F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float enableInputAtProgress;

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0xAD989C", Offset = "0xAD989C", VA = "0xAD989C", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0xAD9CF4", Offset = "0xAD9CF4", VA = "0xAD9CF4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0xAD9EBC", Offset = "0xAD9EBC", VA = "0xAD9EBC")]
		public UserControlInteractions()
		{
		}
	}
	[Token(Token = "0x2000103")]
	public class GrounderDemo : MonoBehaviour
	{
		[Token(Token = "0x4000780")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject[] characters;

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0xAD9EF0", Offset = "0xAD9EF0", VA = "0xAD9EF0")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0xADA0F8", Offset = "0xADA0F8", VA = "0xADA0F8")]
		public void Activate(int index)
		{
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0xADA164", Offset = "0xADA164", VA = "0xADA164")]
		public GrounderDemo()
		{
		}
	}
	[Token(Token = "0x2000104")]
	public class PlatformRotator : MonoBehaviour
	{
		[Token(Token = "0x4000781")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxAngle;

		[Token(Token = "0x4000782")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float switchRotationTime;

		[Token(Token = "0x4000783")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float random;

		[Token(Token = "0x4000784")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float rotationSpeed;

		[Token(Token = "0x4000785")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 movePosition;

		[Token(Token = "0x4000786")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float moveSpeed;

		[Token(Token = "0x4000787")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int characterLayer;

		[Token(Token = "0x4000788")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x4000789")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion targetRotation;

		[Token(Token = "0x400078A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 targetPosition;

		[Token(Token = "0x400078B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 velocity;

		[Token(Token = "0x400078C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Rigidbody r;

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0xADA16C", Offset = "0xADA16C", VA = "0xADA16C")]
		private void Start()
		{
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0xADA2A8", Offset = "0xADA2A8", VA = "0xADA2A8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0xADA234", Offset = "0xADA234", VA = "0xADA234")]
		private IEnumerator SwitchRotation()
		{
			return null;
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0xADA584", Offset = "0xADA584", VA = "0xADA584")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0xADA65C", Offset = "0xADA65C", VA = "0xADA65C")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0xADA730", Offset = "0xADA730", VA = "0xADA730")]
		public PlatformRotator()
		{
		}
	}
	[Token(Token = "0x2000106")]
	public class BendGoal : MonoBehaviour
	{
		[Token(Token = "0x4000790")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbIK limbIK;

		[Token(Token = "0x4000791")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float weight;

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0xADA924", Offset = "0xADA924", VA = "0xADA924")]
		private void Start()
		{
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0xADA98C", Offset = "0xADA98C", VA = "0xADA98C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0xADAA38", Offset = "0xADAA38", VA = "0xADAA38")]
		public BendGoal()
		{
		}
	}
	[Token(Token = "0x2000107")]
	public class Turret : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000108")]
		public class Part
		{
			[Token(Token = "0x4000794")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x4000795")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private RotationLimit rotationLimit;

			[Token(Token = "0x60006D7")]
			[Address(RVA = "0xADAAAC", Offset = "0xADAAAC", VA = "0xADAAAC")]
			public void AimAt(Transform target)
			{
			}

			[Token(Token = "0x60006D8")]
			[Address(RVA = "0xADABE8", Offset = "0xADABE8", VA = "0xADABE8")]
			public Part()
			{
			}
		}

		[Token(Token = "0x4000792")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000793")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Part[] parts;

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0xADAA48", Offset = "0xADAA48", VA = "0xADAA48")]
		private void Update()
		{
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0xADABE0", Offset = "0xADABE0", VA = "0xADABE0")]
		public Turret()
		{
		}
	}
	[Token(Token = "0x2000109")]
	public class HitReactionVRIKTrigger : MonoBehaviour
	{
		[Token(Token = "0x4000796")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HitReactionVRIK hitReaction;

		[Token(Token = "0x4000797")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float hitForce;

		[Token(Token = "0x4000798")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0xADABF0", Offset = "0xADABF0", VA = "0xADABF0")]
		private void Update()
		{
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0xADAD40", Offset = "0xADAD40", VA = "0xADAD40")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0xADAEA4", Offset = "0xADAEA4", VA = "0xADAEA4")]
		public HitReactionVRIKTrigger()
		{
		}
	}
	[Token(Token = "0x200010A")]
	public class VRIKCalibrationController : MonoBehaviour
	{
		[Token(Token = "0x4000799")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x400079A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public VRIKCalibrator.Settings settings;

		[Token(Token = "0x400079B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform headTracker;

		[Token(Token = "0x400079C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform bodyTracker;

		[Token(Token = "0x400079D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform leftHandTracker;

		[Token(Token = "0x400079E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform rightHandTracker;

		[Token(Token = "0x400079F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform leftFootTracker;

		[Token(Token = "0x40007A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform rightFootTracker;

		[Token(Token = "0x40007A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public VRIKCalibrator.CalibrationData data;

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0xADAEB4", Offset = "0xADAEB4", VA = "0xADAEB4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0xADB014", Offset = "0xADB014", VA = "0xADB014")]
		public VRIKCalibrationController()
		{
		}
	}
	[Token(Token = "0x200010B")]
	public class VRIKPlatform : MonoBehaviour
	{
		[Token(Token = "0x40007A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x40007A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 lastPosition;

		[Token(Token = "0x40007A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion lastRotation;

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0xADB088", Offset = "0xADB088", VA = "0xADB088")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0xADB0D8", Offset = "0xADB0D8", VA = "0xADB0D8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0xADB2B0", Offset = "0xADB2B0", VA = "0xADB2B0")]
		public VRIKPlatform()
		{
		}
	}
	[Token(Token = "0x200010C")]
	public class VRIKPlatformController : MonoBehaviour
	{
		[Token(Token = "0x40007A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x40007A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform trackingSpace;

		[Token(Token = "0x40007A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform platform;

		[Token(Token = "0x40007A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool moveToPlatform;

		[Token(Token = "0x40007A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform lastPlatform;

		[Token(Token = "0x40007AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 lastPosition;

		[Token(Token = "0x40007AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0xADB308", Offset = "0xADB308", VA = "0xADB308")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0xADB838", Offset = "0xADB838", VA = "0xADB838")]
		public VRIKPlatformController()
		{
		}
	}
	[Token(Token = "0x200010D")]
	public abstract class CharacterAnimationBase : MonoBehaviour
	{
		[Token(Token = "0x40007AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool smoothFollow;

		[Token(Token = "0x40007AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float smoothFollowSpeed;

		[Token(Token = "0x40007AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool animatePhysics;

		[Token(Token = "0x40007AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x40007B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 localPosition;

		[Token(Token = "0x40007B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion localRotation;

		[Token(Token = "0x40007B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		[Token(Token = "0x170000B2")]
		public virtual bool animationGrounded
		{
			[Token(Token = "0x60006E4")]
			[Address(RVA = "0xADB8B4", Offset = "0xADB8B4", VA = "0xADB8B4", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0xADB894", Offset = "0xADB894", VA = "0xADB894", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0xADB8BC", Offset = "0xADB8BC", VA = "0xADB8BC")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0xADB91C", Offset = "0xADB91C", VA = "0xADB91C", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0xADBAA0", Offset = "0xADBAA0", VA = "0xADBAA0", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0xADBD1C", Offset = "0xADBD1C", VA = "0xADBD1C", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0xADBAB0", Offset = "0xADBAB0", VA = "0xADBAB0")]
		private void SmoothFollow()
		{
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0xADBD2C", Offset = "0xADBD2C", VA = "0xADBD2C")]
		protected CharacterAnimationBase()
		{
		}
	}
	[Token(Token = "0x200010E")]
	[RequireComponent(typeof(Animator))]
	public class CharacterAnimationSimple : CharacterAnimationBase
	{
		[Token(Token = "0x40007B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x40007B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float pivotOffset;

		[Token(Token = "0x40007B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AnimationCurve moveSpeed;

		[Token(Token = "0x40007B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Animator animator;

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0xADBD44", Offset = "0xADBD44", VA = "0xADBD44", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0xADBDA4", Offset = "0xADBDA4", VA = "0xADBDA4", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0xADBE34", Offset = "0xADBE34", VA = "0xADBE34")]
		private void Update()
		{
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0xADBF58", Offset = "0xADBF58", VA = "0xADBF58")]
		public CharacterAnimationSimple()
		{
		}
	}
	[Token(Token = "0x200010F")]
	[RequireComponent(typeof(Animator))]
	public class CharacterAnimationThirdPerson : CharacterAnimationBase
	{
		[Token(Token = "0x40007B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x40007B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float turnSensitivity;

		[Token(Token = "0x40007B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float turnSpeed;

		[Token(Token = "0x40007BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float runCycleLegOffset;

		[Token(Token = "0x40007BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		private float animSpeedMultiplier;

		[Token(Token = "0x40007BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Animator animator;

		[Token(Token = "0x40007BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 lastForward;

		[Token(Token = "0x40007BE")]
		private const string groundedDirectional = "Grounded Directional";

		[Token(Token = "0x40007BF")]
		private const string groundedStrafe = "Grounded Strafe";

		[Token(Token = "0x40007C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float deltaAngle;

		[Token(Token = "0x170000B3")]
		public override bool animationGrounded
		{
			[Token(Token = "0x60006F1")]
			[Address(RVA = "0xADC014", Offset = "0xADC014", VA = "0xADC014", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0xADBF70", Offset = "0xADBF70", VA = "0xADBF70", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0xADBFF8", Offset = "0xADBFF8", VA = "0xADBFF8", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0xADC108", Offset = "0xADC108", VA = "0xADC108", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0xADC4DC", Offset = "0xADC4DC", VA = "0xADC4DC")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0xADC604", Offset = "0xADC604", VA = "0xADC604")]
		public CharacterAnimationThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000110")]
	[RequireComponent(typeof(Rigidbody))]
	[RequireComponent(typeof(CapsuleCollider))]
	public abstract class CharacterBase : MonoBehaviour
	{
		[Token(Token = "0x40007C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform gravityTarget;

		[Token(Token = "0x40007C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float gravityMultiplier;

		[Token(Token = "0x40007C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float airborneThreshold;

		[Token(Token = "0x40007C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float slopeStartAngle;

		[Token(Token = "0x40007C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float slopeEndAngle;

		[Token(Token = "0x40007C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float spherecastRadius;

		[Token(Token = "0x40007C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public LayerMask groundLayers;

		[Token(Token = "0x40007C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private PhysicMaterial zeroFrictionMaterial;

		[Token(Token = "0x40007C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private PhysicMaterial highFrictionMaterial;

		[Token(Token = "0x40007CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected Rigidbody r;

		[Token(Token = "0x40007CB")]
		protected const float half = 0.5f;

		[Token(Token = "0x40007CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected float originalHeight;

		[Token(Token = "0x40007CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		protected Vector3 originalCenter;

		[Token(Token = "0x40007CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected CapsuleCollider capsule;

		[Token(Token = "0x60006F5")]
		public abstract void Move(Vector3 deltaPosition, Quaternion deltaRotation);

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0xADC628", Offset = "0xADC628", VA = "0xADC628")]
		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0xADC814", Offset = "0xADC814", VA = "0xADC814", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0xADCA40", Offset = "0xADCA40", VA = "0xADCA40", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0xADCBE0", Offset = "0xADCBE0", VA = "0xADCBE0")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0xADCC40", Offset = "0xADCC40", VA = "0xADCC40")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0xADCDA4", Offset = "0xADCDA4", VA = "0xADCDA4")]
		protected void ScaleCapsule(float mlp)
		{
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0xADCFA8", Offset = "0xADCFA8", VA = "0xADCFA8")]
		protected void HighFriction()
		{
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0xADCFCC", Offset = "0xADCFCC", VA = "0xADCFCC")]
		protected void ZeroFriction()
		{
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0xADCFF0", Offset = "0xADCFF0", VA = "0xADCFF0")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default(float);
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0xADD13C", Offset = "0xADD13C", VA = "0xADD13C")]
		protected CharacterBase()
		{
		}
	}
	[Token(Token = "0x2000111")]
	public class CharacterThirdPerson : CharacterBase
	{
		[Serializable]
		[Token(Token = "0x2000112")]
		public enum MoveMode
		{
			[Token(Token = "0x4000808")]
			Directional,
			[Token(Token = "0x4000809")]
			Strafe
		}

		[Token(Token = "0x2000113")]
		public struct AnimState
		{
			[Token(Token = "0x400080A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 moveDirection;

			[Token(Token = "0x400080B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public bool jump;

			[Token(Token = "0x400080C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
			public bool crouch;

			[Token(Token = "0x400080D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
			public bool onGround;

			[Token(Token = "0x400080E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
			public bool isStrafing;

			[Token(Token = "0x400080F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float yVelocity;

			[Token(Token = "0x4000810")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public bool doubleJump;
		}

		[Token(Token = "0x40007CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public CharacterAnimationBase characterAnimation;

		[Token(Token = "0x40007D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public UserControlThirdPerson userControl;

		[Token(Token = "0x40007D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public CameraController cam;

		[Token(Token = "0x40007D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public MoveMode moveMode;

		[Token(Token = "0x40007D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool smoothPhysics;

		[Token(Token = "0x40007D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float smoothAccelerationTime;

		[Token(Token = "0x40007D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float linearAccelerationSpeed;

		[Token(Token = "0x40007D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float platformFriction;

		[Token(Token = "0x40007D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float groundStickyEffect;

		[Token(Token = "0x40007D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float maxVerticalVelocityOnGround;

		[Token(Token = "0x40007D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float velocityToGroundTangentWeight;

		[Token(Token = "0x40007DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool lookInCameraDirection;

		[Token(Token = "0x40007DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float turnSpeed;

		[Token(Token = "0x40007DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float stationaryTurnSpeedMlp;

		[Token(Token = "0x40007DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public bool smoothJump;

		[Token(Token = "0x40007DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float airSpeed;

		[Token(Token = "0x40007DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float airControl;

		[Token(Token = "0x40007E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float jumpPower;

		[Token(Token = "0x40007E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public float jumpRepeatDelayTime;

		[Token(Token = "0x40007E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public bool doubleJumpEnabled;

		[Token(Token = "0x40007E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float doubleJumpPowerMlp;

		[Token(Token = "0x40007E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public LayerMask wallRunLayers;

		[Token(Token = "0x40007E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public float wallRunMaxLength;

		[Token(Token = "0x40007E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public float wallRunMinMoveMag;

		[Token(Token = "0x40007E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public float wallRunMinVelocityY;

		[Token(Token = "0x40007E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public float wallRunRotationSpeed;

		[Token(Token = "0x40007E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public float wallRunMaxRotationAngle;

		[Token(Token = "0x40007EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public float wallRunWeightSpeed;

		[Token(Token = "0x40007EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		public float crouchCapsuleScaleMlp;

		[Token(Token = "0x40007ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		public AnimState animState;

		[Token(Token = "0x40007EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		protected Vector3 moveDirection;

		[Token(Token = "0x40007EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Animator animator;

		[Token(Token = "0x40007F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Vector3 normal;

		[Token(Token = "0x40007F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private Vector3 platformVelocity;

		[Token(Token = "0x40007F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Vector3 platformAngularVelocity;

		[Token(Token = "0x40007F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private RaycastHit hit;

		[Token(Token = "0x40007F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private float jumpLeg;

		[Token(Token = "0x40007F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private float jumpEndTime;

		[Token(Token = "0x40007F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private float forwardMlp;

		[Token(Token = "0x40007F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		private float groundDistance;

		[Token(Token = "0x40007F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private float lastAirTime;

		[Token(Token = "0x40007F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private float stickyForce;

		[Token(Token = "0x40007FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private Vector3 wallNormal;

		[Token(Token = "0x40007FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		private Vector3 moveDirectionVelocity;

		[Token(Token = "0x40007FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private float wallRunWeight;

		[Token(Token = "0x40007FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		private float lastWallRunWeight;

		[Token(Token = "0x40007FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private Vector3 fixedDeltaPosition;

		[Token(Token = "0x40007FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		private Quaternion fixedDeltaRotation;

		[Token(Token = "0x4000800")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
		private bool fixedFrame;

		[Token(Token = "0x4000801")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private float wallRunEndTime;

		[Token(Token = "0x4000802")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		private Vector3 gravity;

		[Token(Token = "0x4000803")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private Vector3 verticalVelocity;

		[Token(Token = "0x4000804")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
		private float velocityY;

		[Token(Token = "0x4000805")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private bool doubleJumped;

		[Token(Token = "0x4000806")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E1")]
		private bool jumpReleased;

		[Token(Token = "0x170000B4")]
		public bool onGround
		{
			[Token(Token = "0x6000700")]
			[Address(RVA = "0xADD15C", Offset = "0xADD15C", VA = "0xADD15C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000701")]
			[Address(RVA = "0xADD164", Offset = "0xADD164", VA = "0xADD164")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0xADD170", Offset = "0xADD170", VA = "0xADD170", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0xADD360", Offset = "0xADD360", VA = "0xADD360")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0xADD3E4", Offset = "0xADD3E4", VA = "0xADD3E4", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0xADD494", Offset = "0xADD494", VA = "0xADD494")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0xADE480", Offset = "0xADE480", VA = "0xADE480", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0xADE910", Offset = "0xADE910", VA = "0xADE910", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0xADDB44", Offset = "0xADDB44", VA = "0xADDB44")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0xADE9E8", Offset = "0xADE9E8", VA = "0xADE9E8")]
		private void WallRun()
		{
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0xADF074", Offset = "0xADF074", VA = "0xADF074")]
		private bool CanWallRun()
		{
			return default(bool);
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0xADE50C", Offset = "0xADE50C", VA = "0xADE50C")]
		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0xADF164", Offset = "0xADF164", VA = "0xADF164", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0xADF5E4", Offset = "0xADF5E4", VA = "0xADF5E4")]
		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0xADF70C", Offset = "0xADF70C", VA = "0xADF70C", Slot = "10")]
		protected virtual bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0xADF860", Offset = "0xADF860", VA = "0xADF860")]
		private IEnumerator JumpSmooth(Vector3 jumpVelocity)
		{
			return null;
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0xADDF20", Offset = "0xADDF20", VA = "0xADDF20")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0xADF920", Offset = "0xADF920", VA = "0xADF920")]
		public CharacterThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000115")]
	[RequireComponent(typeof(Animator))]
	public class SimpleLocomotion : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000116")]
		public enum RotationMode
		{
			[Token(Token = "0x4000825")]
			Smooth,
			[Token(Token = "0x4000826")]
			Linear
		}

		[Token(Token = "0x4000817")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CameraController cameraController;

		[Token(Token = "0x4000818")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float accelerationTime;

		[Token(Token = "0x4000819")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float turnTime;

		[Token(Token = "0x400081A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool walkByDefault;

		[Token(Token = "0x400081B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public RotationMode rotationMode;

		[Token(Token = "0x400081C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float moveSpeed;

		[Token(Token = "0x400081E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Animator animator;

		[Token(Token = "0x400081F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float speed;

		[Token(Token = "0x4000820")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float angleVel;

		[Token(Token = "0x4000821")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float speedVel;

		[Token(Token = "0x4000822")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 linearTargetDirection;

		[Token(Token = "0x4000823")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private CharacterController characterController;

		[Token(Token = "0x170000B7")]
		public bool isGrounded
		{
			[Token(Token = "0x6000718")]
			[Address(RVA = "0xADFB8C", Offset = "0xADFB8C", VA = "0xADFB8C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000719")]
			[Address(RVA = "0xADFB94", Offset = "0xADFB94", VA = "0xADFB94")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0xADFBA0", Offset = "0xADFBA0", VA = "0xADFBA0")]
		private void Start()
		{
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0xADFC48", Offset = "0xADFC48", VA = "0xADFC48")]
		private void Update()
		{
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0xAE0260", Offset = "0xAE0260", VA = "0xAE0260")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0xADFC90", Offset = "0xADFC90", VA = "0xADFC90")]
		private void Rotate()
		{
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0xADFFF8", Offset = "0xADFFF8", VA = "0xADFFF8")]
		private void Move()
		{
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0xAE0290", Offset = "0xAE0290", VA = "0xAE0290")]
		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0xAE0328", Offset = "0xAE0328", VA = "0xAE0328")]
		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0xAE03A8", Offset = "0xAE03A8", VA = "0xAE03A8")]
		public SimpleLocomotion()
		{
		}
	}
	[Token(Token = "0x2000117")]
	public class UserControlAI : UserControlThirdPerson
	{
		[Token(Token = "0x4000827")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform moveTarget;

		[Token(Token = "0x4000828")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float stoppingDistance;

		[Token(Token = "0x4000829")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float stoppingThreshold;

		[Token(Token = "0x400082A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Navigator navigator;

		[Token(Token = "0x6000722")]
		[Address(RVA = "0xAE03D0", Offset = "0xAE03D0", VA = "0xAE03D0", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0xAE0518", Offset = "0xAE0518", VA = "0xAE0518", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0xAE0B90", Offset = "0xAE0B90", VA = "0xAE0B90")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000725")]
		[Address(RVA = "0xAE0D7C", Offset = "0xAE0D7C", VA = "0xAE0D7C")]
		public UserControlAI()
		{
		}
	}
	[Token(Token = "0x2000118")]
	public class UserControlThirdPerson : MonoBehaviour
	{
		[Token(Token = "0x2000119")]
		public struct State
		{
			[Token(Token = "0x4000830")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 move;

			[Token(Token = "0x4000831")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 lookPos;

			[Token(Token = "0x4000832")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool crouch;

			[Token(Token = "0x4000833")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			public bool jump;

			[Token(Token = "0x4000834")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int actionIndex;
		}

		[Token(Token = "0x400082B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool walkByDefault;

		[Token(Token = "0x400082C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool canCrouch;

		[Token(Token = "0x400082D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool canJump;

		[Token(Token = "0x400082E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public State state;

		[Token(Token = "0x400082F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected Transform cam;

		[Token(Token = "0x6000726")]
		[Address(RVA = "0xAE040C", Offset = "0xAE040C", VA = "0xAE040C", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0xAD99B0", Offset = "0xAD99B0", VA = "0xAD99B0", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0xAD9EE0", Offset = "0xAD9EE0", VA = "0xAD9EE0")]
		public UserControlThirdPerson()
		{
		}
	}
	[Token(Token = "0x200011A")]
	public class ApplicationQuit : MonoBehaviour
	{
		[Token(Token = "0x6000729")]
		[Address(RVA = "0xAE0D98", Offset = "0xAE0D98", VA = "0xAE0D98")]
		private void Update()
		{
		}

		[Token(Token = "0x600072A")]
		[Address(RVA = "0xAE0DD0", Offset = "0xAE0DD0", VA = "0xAE0DD0")]
		public ApplicationQuit()
		{
		}
	}
	[Token(Token = "0x200011B")]
	public class SlowMo : MonoBehaviour
	{
		[Token(Token = "0x4000835")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public KeyCode[] keyCodes;

		[Token(Token = "0x4000836")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool mouse0;

		[Token(Token = "0x4000837")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool mouse1;

		[Token(Token = "0x4000838")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float slowMoTimeScale;

		[Token(Token = "0x600072B")]
		[Address(RVA = "0xAE0DD8", Offset = "0xAE0DD8", VA = "0xAE0DD8")]
		private void Update()
		{
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0xAE0E00", Offset = "0xAE0E00", VA = "0xAE0E00")]
		private bool IsSlowMotion()
		{
			return default(bool);
		}

		[Token(Token = "0x600072D")]
		[Address(RVA = "0xAE0EA4", Offset = "0xAE0EA4", VA = "0xAE0EA4")]
		public SlowMo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200011C")]
	public class Navigator
	{
		[Token(Token = "0x200011D")]
		public enum State
		{
			[Token(Token = "0x4000848")]
			Idle,
			[Token(Token = "0x4000849")]
			Seeking,
			[Token(Token = "0x400084A")]
			OnPath
		}

		[Token(Token = "0x4000839")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool activeTargetSeeking;

		[Token(Token = "0x400083A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float cornerRadius;

		[Token(Token = "0x400083B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float recalculateOnPathDistance;

		[Token(Token = "0x400083C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float maxSampleDistance;

		[Token(Token = "0x400083D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float nextPathInterval;

		[Token(Token = "0x4000840")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform transform;

		[Token(Token = "0x4000841")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int cornerIndex;

		[Token(Token = "0x4000842")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3[] corners;

		[Token(Token = "0x4000843")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private NavMeshPath path;

		[Token(Token = "0x4000844")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 lastTargetPosition;

		[Token(Token = "0x4000845")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool initiated;

		[Token(Token = "0x4000846")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float nextPathTime;

		[Token(Token = "0x170000B8")]
		public Vector3 normalizedDeltaPosition
		{
			[Token(Token = "0x600072E")]
			[Address(RVA = "0xAE0EB8", Offset = "0xAE0EB8", VA = "0xAE0EB8")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600072F")]
			[Address(RVA = "0xAE0EC4", Offset = "0xAE0EC4", VA = "0xAE0EC4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000B9")]
		public State state
		{
			[Token(Token = "0x6000730")]
			[Address(RVA = "0xAE0ED0", Offset = "0xAE0ED0", VA = "0xAE0ED0")]
			[CompilerGenerated]
			get
			{
				return default(State);
			}
			[Token(Token = "0x6000731")]
			[Address(RVA = "0xAE0ED8", Offset = "0xAE0ED8", VA = "0xAE0ED8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0xAE0440", Offset = "0xAE0440", VA = "0xAE0440")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0xAE0738", Offset = "0xAE0738", VA = "0xAE0738")]
		public void Update(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0xAE0FB8", Offset = "0xAE0FB8", VA = "0xAE0FB8")]
		private void CalculatePath(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0xAE101C", Offset = "0xAE101C", VA = "0xAE101C")]
		private bool Find(Vector3 targetPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0xAE0EE0", Offset = "0xAE0EE0", VA = "0xAE0EE0")]
		private void Stop()
		{
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0xAE0F3C", Offset = "0xAE0F3C", VA = "0xAE0F3C")]
		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0xAE0BB8", Offset = "0xAE0BB8", VA = "0xAE0BB8")]
		public void Visualize()
		{
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0xAE1150", Offset = "0xAE1150", VA = "0xAE1150")]
		public Navigator()
		{
		}
	}
}
